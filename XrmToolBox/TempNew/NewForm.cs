﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using McTools.Xrm.Connection;
using McTools.Xrm.Connection.WinForms;
using Microsoft.Xrm.Sdk;
using WeifenLuo.WinFormsUI.Docking;
using XrmToolBox.AppCode;
using XrmToolBox.Controls;
using XrmToolBox.Extensibility;
using XrmToolBox.Extensibility.Interfaces;
using XrmToolBox.Forms;
using XrmToolBox.PluginsStore;
using XrmToolBox.TempNew.EventArgs;

namespace XrmToolBox.TempNew
{
    public partial class NewForm : Form
    {
        private readonly PluginsForm pluginsForm;
        private readonly Dictionary<PluginForm, ConnectionDetail> pluginConnections = new Dictionary<PluginForm, ConnectionDetail>();

        private CrmConnectionStatusBar ccsb;
        private ConnectionManager cManager;
        private FormHelper fHelper;
        private IOrganizationService service;
        private ConnectionDetail connectionDetail;

        private string initialConnectionName;
        private string initialPluginName;

        private IStore store;
        private readonly WelcomeDialog blackScreen;

        public NewForm(string[] args)
        {
            InitializeComponent();

            Text = $@"{Text} (v{Assembly.GetExecutingAssembly().GetName().Version})";

            // Set drawing optimizations
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);

            // Displaying Welcome screen
            var version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            blackScreen = new WelcomeDialog(version) { StartPosition = FormStartPosition.CenterScreen };
            blackScreen.Show(this);
            blackScreen.SetWorkingMessage("Loading...");

            //var theme = new VS2015LightTheme();
            var theme = new VS2015BlueTheme();
            dpMain.Theme = theme;

            pluginsForm = new PluginsForm();
            pluginsForm.OpenPluginRequested += PluginsForm_OpenPluginRequested;
            pluginsForm.OpenPluginProjectUrlRequested += PluginsForm_OpenPluginProjectUrlRequested;
            pluginsForm.UninstallPluginRequested += PluginsForm_UninstallPluginRequested;
            pluginsForm.ActionRequested += PluginsForm_ActionRequested;
            pluginsForm.Show(dpMain, DockState.Document);

            // Connection Management
            blackScreen.SetWorkingMessage("Loading connection controls...");
            ManageConnectionControl();
            ccsb.MergeConnectionsFiles = Options.Instance.MergeConnectionFiles;

            ProcessMenuItemsForPlugin();

            // Restore session management
            if (Options.Instance.RememberSession)
            {
                if (!string.IsNullOrEmpty(Options.Instance.LastConnection))
                {
                    initialConnectionName = Options.Instance.LastConnection;
                }
                if (!string.IsNullOrEmpty(Options.Instance.LastPlugin))
                {
                    initialPluginName = Options.Instance.LastPlugin;
                }
            }

            // Read arguments to detect if a plugin should be displayed automatically
            if (args.Length > 0)
            {
                initialConnectionName = ExtractSwitchValue("/connection:", ref args);
                initialPluginName = ExtractSwitchValue("/plugin:", ref args);

                if (!string.IsNullOrEmpty(initialConnectionName))
                {
                    pnlConnectLoading.BringToFront();

                    pnlConnectLoading.Visible = true;
                    lblConnecting.Text = string.Format(lblConnecting.Tag.ToString(), initialConnectionName);
                }
            }
        }

        public sealed override string Text
        {
            get => base.Text;
            set => base.Text = value;
        }

        private async void NewForm_Load(object sender, System.EventArgs e)
        {
            WebProxyHelper.ApplyProxy();

            tstSearch.AutoCompleteCustomSource.AddRange(pluginsForm.PluginManager.Plugins.Select(p => p.Metadata.Name).ToArray());

            blackScreen.SetWorkingMessage("Loading plugins...");

            var tasks = new List<Task>
            {
                LaunchVersionCheck()
            };

            if (!string.IsNullOrEmpty(initialConnectionName))
            {
                var initialConnectionDetail = ConnectionManager.Instance.ConnectionsList.Connections.FirstOrDefault(x => x.ConnectionName == initialConnectionName);

                if (initialConnectionDetail != null)
                {
                    // If initiall connection is present, connect to given sever is initiated.
                    // After connection try to open intial plugin will be attempted.
                    tasks.Add(LaunchInitialConnection(initialConnectionDetail));
                }
                else
                {
                    // Connection detail was not found, so name provided was incorrect.
                    // But if name of the plugin is set, it should be started
                    if (!string.IsNullOrEmpty(initialPluginName))
                    {
                        StartPluginWithoutConnection();
                    }
                }
            }
            else if (!string.IsNullOrEmpty(initialPluginName))
            {
                // If there is no initial connection, but initial plugin is set, openning plugin
                StartPluginWithoutConnection();
            }

            tasks.ForEach(x => x.Start());
            await Task.WhenAll(tasks.ToArray());

            // Adapt size of current form
            if (Options.Instance.Size.IsMaximized)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                Options.Instance.Size.ApplyFormSize(this);
            }

            // Hide & remove Welcome screen
            Opacity = 100;
            blackScreen.Hide();
            blackScreen.Dispose();

            if (!Options.Instance.AllowLogUsage.HasValue)
            {
                Options.Instance.AllowLogUsage = LogUsage.PromptToLog();
                Options.Instance.Save();
            }

            if (Options.Instance.DisplayPluginsStoreOnStartup)
            {
                if (store == null)
                {
                    if (Options.Instance.PluginsStoreUseLegacy ?? false)
                    {
                        store = new Store();
                    }
                    else
                    {
                        store = new StoreFromPortal();
                    }
                }

                if (Options.Instance.DisplayPluginsStoreOnlyIfUpdates)
                {
                    if (store.PluginsCount == 0)
                    {
                        store.LoadNugetPackages();
                    }

                    if (store.HasUpdates)
                    {
                        tsddbTools_DropDownItemClicked(sender, new ToolStripItemClickedEventArgs(pluginsStoreToolStripMenuItem));
                    }
                }
                else
                {
                    tsddbTools_DropDownItemClicked(sender, new ToolStripItemClickedEventArgs(pluginsStoreToolStripMenuItem));
                }
            }

            tstSearch.Focus();
        }

        private string ExtractSwitchValue(string key, ref string[] args)
        {
            var name = string.Empty;

            foreach (var arg in args)
            {
                if (arg.StartsWith(key))
                {
                    name = arg.Substring(key.Length);
                }
            }

            return name;
        }

        private void PluginsForm_ActionRequested(object sender, PluginsListEventArgs e)
        {
            switch (e.Action)
            {
                case PluginsListAction.OpenPluginsStore:
                    tsddbTools_DropDownItemClicked(sender, new ToolStripItemClickedEventArgs(pluginsStoreToolStripMenuItem));
                    break;

                case PluginsListAction.ResetSearchFilter:
                    tstSearch.Text = string.Empty;
                    break;
            }
        }

        private void PluginsForm_OpenPluginProjectUrlRequested(object sender, PluginEventArgs e)
        {
            var filePath = Assembly.GetAssembly(e.PluginControl.GetType()).Location;
            if (File.Exists(filePath))
            {
                var fileName = Path.GetFileName(filePath);

                if (store == null)
                {
                    MessageBox.Show(this,
                        @"The Plugins Store is not initialized so we cannot find the project url",
                        @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string projectUrl = store.GetPluginProjectUrlByFileName(fileName.ToLower());
                if (projectUrl != null)
                {
                    Process.Start(projectUrl);
                }
                else
                {
                    MessageBox.Show(this,
                        @"This plugin is not on the Plugins Store or its Project Url is not defined. Therefore, we cannot lead you to the project page",
                        @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void PluginsForm_UninstallPluginRequested(object sender, PluginEventArgs e)
        {
            if (DialogResult.No == MessageBox.Show(this,
                    @"Are you sure you want to uninstall this plugin?",
                    @"Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                return;
            }

            var filePath = Assembly.GetAssembly(e.PluginControl.GetType()).Location;
            if (File.Exists(filePath))
            {
                var fileName = Path.GetFileName(filePath);

                if (store == null)
                {
                    MessageBox.Show(this,
                        @"The Plugins Store is not initialized so we cannot find files to uninstall",
                        @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                store.UninstallByFileName(fileName);
            }
        }

        private void PluginsForm_OpenPluginRequested(object sender, PluginEventArgs e)
        {
            if (service == null)
            {
                var result = MessageBox.Show(this, @"Do you want to connect to an organization first?", @"Question",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    ConnectUponApproval(e.Plugin);
                }
                else if (result == DialogResult.No)
                {
                    if (e.Plugin != null)
                    {
                        DisplayPluginControl(e.Plugin);
                    }
                }
            }
            else
            {
                if (e.Plugin != null)
                {
                    DisplayPluginControl(e.Plugin);
                }
            }
        }

        private void DisplayPluginControl(Lazy<IXrmToolBoxPlugin, IPluginMetadata> plugin)
        {
            Guid pluginControlInstanceId = Guid.NewGuid();

            try
            {
                var pluginControl = (UserControl)plugin.Value.GetControl();
                pluginControl.Tag = pluginControlInstanceId;

                // ReSharper disable once SuspiciousTypeConversion.Global
                if (pluginControl is IMessageBusHost host)
                {
                    host.OnOutgoingMessage += MainForm_MessageBroker;
                }

                if (service != null)
                {
                    var crmSvcClient = connectionDetail.GetCrmServiceClient();

                    var clonedService = crmSvcClient.OrganizationServiceProxy;
                    var clonedWebClientService = crmSvcClient.OrganizationWebProxyClient;
                    if (clonedService != null)
                    {
                        clonedService.SdkClientVersion = connectionDetail.OrganizationVersion;
                    }
                    if (clonedWebClientService != null)
                    {
                        clonedWebClientService.SdkClientVersion = connectionDetail.OrganizationVersion;
                    }

                    // ReSharper disable once SuspiciousTypeConversion.Global
                    if (pluginControl is IEarlyBoundProxy earlyBoundProxiedControl)
                    {
                        clonedService?.EnableProxyTypes(earlyBoundProxiedControl.GetEarlyBoundProxyAssembly());
                    }

                    if (clonedService != null)
                    {
                        ((IXrmToolBoxPluginControl)pluginControl).UpdateConnection(clonedService, connectionDetail);
                    }
                    else
                    {
                        ((IXrmToolBoxPluginControl)pluginControl).UpdateConnection(clonedWebClientService, connectionDetail);
                    }
                }

                // TODO
                //((IXrmToolBoxPluginControl)pluginControl).OnRequestConnection += MainForm_OnRequestConnection;

                string name = $"{plugin.Metadata.Name} ({connectionDetail?.ConnectionName ?? "Not connected"})";

                var pluginForm = new PluginForm(pluginControl, name);
                pluginForm.FormClosed += (sender, e) => { pluginConnections.Remove((PluginForm)sender); };
                pluginForm.Show(dpMain, DockState.Document);
                pluginForm.CloseRequested += PluginForm_CloseRequested;

                pluginConnections.Add(pluginForm, connectionDetail);
                if (connectionDetail == null)
                {
                    tssOpenOrg.Visible = false;
                    tsbOpenOrg.Visible = false;
                }

                var pluginInOption = Options.Instance.MostUsedList.FirstOrDefault(i => i.Name == plugin.Value.GetType().FullName);
                if (pluginInOption == null)
                {
                    pluginInOption = new PluginUseCount { Name = plugin.Value.GetType().FullName, Count = 0 };
                    Options.Instance.MostUsedList.Add(pluginInOption);
                }

                pluginInOption.Count++;

                if (Options.Instance.LastAdvertisementDisplay == new DateTime() ||
                    Options.Instance.LastAdvertisementDisplay > DateTime.Now ||
                    Options.Instance.LastAdvertisementDisplay.AddDays(7) < DateTime.Now)
                {
                    bool displayAdvertisement = true;
                    try
                    {
                        var assembly = Assembly.LoadFile(new FileInfo(Assembly.GetExecutingAssembly().Location).Directory +
                                              "\\McTools.StopAdvertisement.dll");
                        {
                            Type type = assembly.GetType("McTools.StopAdvertisement.LicenseManager");
                            if (type != null)
                            {
                                MethodInfo methodInfo = type.GetMethod("IsValid");
                                if (methodInfo != null)
                                {
                                    object classInstance = Activator.CreateInstance(type, null);

                                    if ((bool)methodInfo.Invoke(classInstance, null))
                                    {
                                        displayAdvertisement = false;
                                    }
                                }
                            }
                        }
                    }
                    catch (FileNotFoundException)
                    {
                    }

                    if (displayAdvertisement)
                    {
                        pnlSupport.Visible = true;
                        Options.Instance.LastAdvertisementDisplay = DateTime.Now;
                    }
                }

                if (Options.Instance.AllowLogUsage.HasValue && Options.Instance.AllowLogUsage.Value)
                {
#pragma warning disable CS4014
                    LogUsage.DoLog(plugin);
#pragma warning restore CS4014
                }

                Options.Instance.Save();

                if (pnlConnectLoading.Visible)
                {
                    pnlConnectLoading.SendToBack();
                    pnlConnectLoading.Visible = false;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(this, $@"An error occured when trying to display this plugin: {error.Message}", @"Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tstSearch_TextChanged(object sender, System.EventArgs e)
        {
            pluginsForm.FilterText = tstSearch.Text;
        }

        #region Connection methods

        private void ManageConnectionControl()
        {
            if (!Directory.Exists(Paths.ConnectionsPath))
            {
                Directory.CreateDirectory(Paths.ConnectionsPath);
            }

            ConnectionsList.ConnectionsListFilePath = Path.Combine(Paths.ConnectionsPath, "MscrmTools.ConnectionsList.xml");
            cManager = ConnectionManager.Instance;
            cManager.RequestPassword += (sender, e) => fHelper.RequestPassword(e.ConnectionDetail);
            cManager.StepChanged += (sender, e) => ccsb.SetMessage(e.CurrentStep);
            cManager.ConnectionSucceed += (sender, e) =>
            {
                var parameter = e.Parameter as ConnectionParameterInfo;
                if (parameter != null)
                {
                    Controls.Remove(parameter.ConnControl);
                    parameter.ConnControl.Dispose();
                }

                connectionDetail = e.ConnectionDetail;
                service = e.OrganizationService;
                ccsb.SetConnectionStatus(true, e.ConnectionDetail);
                ccsb.SetMessage(string.Empty);

                if (parameter != null)
                {
                    var us = parameter.ConnectionParmater as UserControl;
                    var p = parameter.ConnectionParmater as Lazy<IXrmToolBoxPlugin, IPluginMetadata>;

                    if (us != null)
                    {
                        if (!(us.Tag is Lazy<IXrmToolBoxPlugin, IPluginMetadata> pluginModel))
                        {
                            // Actual Plugin was passed, Just update the plugin's Tab.
                            UpdateTabConnection((PluginForm)us.Parent);
                        }
                        else
                        {
                            DisplayPluginControl(pluginModel);
                        }
                    }
                    else if (p != null)
                    {
                        DisplayPluginControl(p);
                    }
                    else if (parameter.ConnectionParmater.ToString() == "ApplyConnectionToTabs" && dpMain.Contents.Count > 1)
                    {
                        ApplyConnectionToTabs();
                    }
                    else
                    {
                        if (parameter.ConnectionParmater is RequestConnectionEventArgs args)
                        {
                            var userControl = (UserControl)args.Control;

                            args.Control.UpdateConnection(e.OrganizationService, connectionDetail, args.ActionName, args.Parameter);

                            var indexOfParenthesis = userControl.Parent.Text?.IndexOf("(") ?? -1;
                            var pluginName = userControl.Parent.Text?.Substring(0, indexOfParenthesis - 1) ?? "N/A";

                            userControl.Parent.Text = $@"{pluginName} ({e.ConnectionDetail.ConnectionName})";
                        }
                    }
                }
                else if (dpMain.Contents.Count > 1)
                {
                    ApplyConnectionToTabs();
                }

                StartPluginWithConnection();

                tssOpenOrg.Visible = true;
                tsbOpenOrg.Visible = true;
            };
            cManager.ConnectionFailed += (sender, e) =>
            {
                Invoke(new Action(() =>
                {
                    if (e.Parameter is ConnectionParameterInfo param && param.ConnControl != null)
                    {
                        Controls.Remove(param.ConnControl);
                        param.ConnControl.Dispose();
                    }

                    MessageBox.Show(this, e.FailureReason, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    connectionDetail = null;
                    service = null;
                    ccsb.SetConnectionStatus(false, null);
                    ccsb.SetMessage(e.FailureReason);

                    StartPluginWithConnection();
                }));
            };

            fHelper = new FormHelper(this);
            ccsb = new CrmConnectionStatusBar(fHelper) { Dock = DockStyle.Bottom };
            Controls.Add(ccsb);
        }

        private void StartPluginWithConnection()
        {
            if (!string.IsNullOrEmpty(initialConnectionName) && !string.IsNullOrEmpty(initialPluginName))
            {
                StartPluginWithoutConnection();

                // Resetting initial connection name
                initialConnectionName = string.Empty;
            }
        }

        private void StartPluginWithoutConnection()
        {
            if (!string.IsNullOrEmpty(initialPluginName))
            {
                pluginsForm.OpenPlugin(initialPluginName);

                // Resetting initial plugin name
                initialPluginName = string.Empty;
            }
        }

        private void ApplyConnectionToTabs()
        {
            var pluginForms = dpMain.Contents.OfType<PluginForm>().ToList();

            var tcu = new TabConnectionUpdater(pluginForms) { StartPosition = FormStartPosition.CenterParent };

            if (tcu.ShowDialog(this) == DialogResult.OK)
            {
                foreach (PluginForm form in tcu.SelectedPluginForms)
                {
                    UpdateTabConnection(form);
                }
            }
        }

        private void UpdateTabConnection(PluginForm pluginForm, string actionName = "", object parameter = null)
        {
            var indexOfParenthesis = pluginForm.Text?.IndexOf("(") ?? -1;
            var pluginName = pluginForm.Text?.Substring(0, indexOfParenthesis - 1) ?? "N/A";

            if (pluginConnections.ContainsKey(pluginForm))
                pluginConnections[pluginForm] = connectionDetail;

            pluginForm.UpdateConnection(service, connectionDetail, actionName, parameter);
            pluginForm.Text = $@"{pluginName} ({connectionDetail?.ConnectionName ?? "Not connected"})";
        }

        private void ConnectUponApproval(object connectionParameter)
        {
            var info = new ConnectionParameterInfo
            {
                ConnectionParmater = connectionParameter
            };

            fHelper.AskForConnection(info, () =>
            {
                var connectingControl = new ConnectingControl { Anchor = AnchorStyles.None };
                connectingControl.Left = Width / 2 - connectingControl.Width / 2;
                connectingControl.Top = Height / 2 - connectingControl.Height / 2;
                Controls.Add(connectingControl);
                connectingControl.BringToFront();

                info.ConnControl = connectingControl;
            });
        }

        private Task LaunchInitialConnection(ConnectionDetail detail)
        {
            return new Task(() => ConnectionManager.Instance.ConnectToServer(detail));
        }

        private void tsbConnect_Click(object sender, System.EventArgs e)
        {
            ConnectUponApproval("ApplyConnectionToTabs");
        }

        #endregion Connection methods

        #region Message broker

        private void MainForm_MessageBroker(object sender, MessageBusEventArgs message)
        {
            if (!IsMessageValid(sender, message))
            {
                return;
            }

            var content = dpMain.Contents.FirstOrDefault(c => (c as PluginForm)?.PluginTitle == message.TargetPlugin);
            if (content != null && !message.NewInstance)
            {
                // TODO Mettre au premier plan
            }
            else
            {
                pluginsForm.OpenPlugin(message.TargetPlugin);
                MainForm_MessageBroker(sender, message);
                return;
            }

           ((PluginForm)content).SendIncomingBrokerMessage(message);
        }

        private bool IsMessageValid(object sender, MessageBusEventArgs message)
        {
            if (message == null || sender == null || !(sender is UserControl) || !(sender is IXrmToolBoxPluginControl))
            {
                // Error. Possible reasons are:
                // * empty sender
                // * empty message
                // * sender is not UserControl
                // * sender is not XrmToolBox Plugin
                return false;
            }

            var sourceControl = (UserControl)sender;

            if (string.IsNullOrEmpty(message.SourcePlugin))
            {
                message.SourcePlugin = sourceControl.GetType().GetTitle();
            }
            else if (message.SourcePlugin != sourceControl.GetType().GetTitle())
            {
                // For some reason incorrect name was set in Source Plugin field
                return false;
            }

            // Everything went ok
            return true;
        }

        #endregion Message broker

        #region Check for update

        private Task LaunchVersionCheck()
        {
            return new Task(() =>
            {
                if (Options.Instance.DoNotCheckForUpdates)
                {
                    return;
                }

                blackScreen.SetWorkingMessage("Checking for XrmToolBox update...");

                var currentVersion = Assembly.GetExecutingAssembly().GetName().Version;

                var request = WebRequest.CreateHttp("https://www.xrmtoolbox.com/_odata/releases");
                var response = request.GetResponse();
                Releases releases = null;
                using (Stream dataStream = response.GetResponseStream())
                {
                    if (dataStream != null)
                    {
                        var serializer = new DataContractJsonSerializer(typeof(Releases),
                            new DataContractJsonSerializerSettings
                            {
                                UseSimpleDictionaryFormat = true,
                                DateTimeFormat = new DateTimeFormat("yyyy-MM-dd'T'HH:mm:ss", new DateTimeFormatInfo { FullDateTimePattern = "yyyy-MM-dd'T'HH:mm:ss" })
                            });

                        releases = (Releases)serializer.ReadObject(dataStream);
                    }
                }

                if (releases != null)
                {
                    var lastReleaseVersion = releases.Items.Max(i => new Version(i.Version));
                    // TODO remove for release
                    //if (lastReleaseVersion > currentVersion &&
                    //    Options.Instance.LastUpdateCheck.Date != DateTime.Now.Date)
                    {
                        var release = releases.Items.FirstOrDefault(r => r.Version == lastReleaseVersion.ToString());

                        Invoke(new Action(() =>
                        {
                            var nvForm = new TempNew.NewVersionForm(release.Version, new Uri(release.DownloadUrl));
                            nvForm.Show(dpMain, DockState.Document);
                        }));
                    }
                }

                Options.Instance.LastUpdateCheck = DateTime.Now;
                Options.Instance.Save();
            });
        }

        #endregion Check for update

        #region Change of active content

        private void dpMain_ActiveContentChanged(object sender, System.EventArgs e)
        {
            //if (dpMain.ActiveContent is PluginForm)
            //{
            ApplyActiveContentDisplay();
            //}
        }

        private void dpMain_ActiveDocumentChanged(object sender, System.EventArgs e)
        {
            //if (dpMain.ActiveContent is PluginForm)
            //{
            ApplyActiveContentDisplay();
            //}
        }

        private void dpMain_ActivePaneChanged(object sender, System.EventArgs e)
        {
            //if (dpMain.ActiveContent is PluginForm)
            //{
            ApplyActiveContentDisplay();
            //}
        }

        private void dpMain_DocumentDragged(object sender, System.EventArgs e)
        {
            //if (dpMain.ActiveContent is PluginForm)
            //{
            ApplyActiveContentDisplay();
            //}
        }

        private void ApplyActiveContentDisplay()
        {
            ProcessMenuItemsForPlugin();
        }

        #endregion Change of active content

        private void tsddbTools_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == pluginsStoreToolStripMenuItem)
            {
                // If the options were not initialized, it means we are using the
                // new plugins store for the first time. Copy values from main
                // options file
                if (!PluginsStore.Options.Instance.IsInitialized)
                {
                    PluginsStore.Options.Instance.PluginsStoreShowInstalled = Options.Instance.PluginsStoreShowInstalled;
                    PluginsStore.Options.Instance.PluginsStoreShowIncompatible = Options.Instance.PluginsStoreShowIncompatible;
                    PluginsStore.Options.Instance.PluginsStoreShowNew = Options.Instance.PluginsStoreShowNew;
                    PluginsStore.Options.Instance.PluginsStoreShowUpdates = Options.Instance.PluginsStoreShowUpdates;
                    PluginsStore.Options.Instance.UseLegacy = false;
                    PluginsStore.Options.Instance.IsInitialized = true;
                }

                IStoreForm form;

                if (Options.Instance.PluginsStoreUseLegacy ?? false)
                {
                    form = new StoreForm();
                }
                else
                {
                    form = new StoreFormFromPortal();
                }

                form.PluginsUpdated += (storeForm, evt) =>
                {
                    // If plugins list gets updated, refresh the list
                    pluginsForm.ReloadPluginsList();
                };

                // Avoid scanning for new files during Plugins Store usage.
                pluginsForm.PluginManager.IsWatchingForNewPlugins = false;
                ((Form)form).ShowDialog(this);
                pluginsForm.PluginManager.IsWatchingForNewPlugins = true;

                // Apply option to show Plugins Store on startup on main options
                if (Options.Instance.DisplayPluginsStoreOnStartup != PluginsStore.Options.Instance.DisplayPluginsStoreOnStartup)
                {
                    Options.Instance.DisplayPluginsStoreOnStartup = PluginsStore.Options.Instance.DisplayPluginsStoreOnStartup ?? false;
                }
            }
            else if (e.ClickedItem == manageConnectionsToolStripMenuItem)
            {
                fHelper.DisplayConnectionsList(this);
            }
            else if (e.ClickedItem == settingsToolStripMenuItem)
            {
                var oDialog = new OptionsDialog(Options.Instance, pluginsForm.PluginManager);
                if (oDialog.ShowDialog(this) == DialogResult.OK)
                {
                    bool reinitDisplay = Options.Instance.DisplayMostUsedFirst != oDialog.Option.DisplayMostUsedFirst
                                         || Options.Instance.MostUsedList.Count != oDialog.Option.MostUsedList.Count
                                         || Options.Instance.DisplayLargeIcons != oDialog.Option.DisplayLargeIcons
                                         || !oDialog.Option.HiddenPlugins.SequenceEqual(Options.Instance.HiddenPlugins)
                                         || Options.Instance.DisplayOrder != oDialog.Option.DisplayOrder;

                    Options.Instance.Replace(oDialog.Option);

                    if (reinitDisplay)
                    {
                        pluginsForm.ReloadPluginsList();
                    }

                    cManager.ReuseConnections = Options.Instance.ReuseConnections;
                }
            }
        }

        private void checkForUpdateToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var worker = new BackgroundWorker();
            worker.DoWork += (s, evt) =>
            {
                var request = WebRequest.CreateHttp("https://www.xrmtoolbox.com/_odata/releases");
                var response = request.GetResponse();
                using (Stream dataStream = response.GetResponseStream())
                {
                    if (dataStream != null)
                    {
                        var serializer = new DataContractJsonSerializer(typeof(Releases),
                            new DataContractJsonSerializerSettings
                            {
                                UseSimpleDictionaryFormat = true,
                                DateTimeFormat = new DateTimeFormat("yyyy-MM-dd'T'HH:mm:ss", new DateTimeFormatInfo { FullDateTimePattern = "yyyy-MM-dd'T'HH:mm:ss" })
                            });

                        evt.Result = (Releases)serializer.ReadObject(dataStream);
                    }
                }
            };
            worker.RunWorkerCompleted += (s, evt) =>
            {
                if (evt.Result is Releases releases)
                {
                    var lastReleaseVersion = releases.Items.Max(i => new Version(i.Version));
                    // TODO remove >= for release
                    var currentVersion = Assembly.GetExecutingAssembly().GetName().Version;
                    if (lastReleaseVersion >= currentVersion)
                    {
                        var release = releases.Items.FirstOrDefault(r => r.Version == lastReleaseVersion.ToString());

                        Invoke(new Action(() =>
                        {
                            var nvForm = new TempNew.NewVersionForm(release?.Version, new Uri(release?.DownloadUrl ?? "about:_blank"));
                            nvForm.Show(dpMain, DockState.Document);
                        }));
                    }
                    else
                    {
                        MessageBox.Show(this, @"No update available!", @"Information", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show(this, @"No update information found!", @"Information", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }

                Options.Instance.LastUpdateCheck = DateTime.Now;
                Options.Instance.Save();
            };
            worker.RunWorkerAsync();
        }

        private void aboutXrmToolBoxToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            var aForm = new WelcomeDialog(version, false) { StartPosition = FormStartPosition.CenterParent };
            aForm.ShowDialog(this);
        }

        #region Document management

        private void tsbManageTabs_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == closeAllTabsToolStripMenuItem)
            {
                RequestCloseTabs(dpMain.Contents.OfType<PluginForm>(), new PluginCloseInfo(ToolBoxCloseReason.CloseAll));
            }
            else if (e.ClickedItem == closeAllTabsExceptActiveToolStripMenuItem)
            {
                RequestCloseTabs(dpMain.Contents.OfType<PluginForm>().Where(p => dpMain.ActiveContent != p), new PluginCloseInfo(ToolBoxCloseReason.CloseAllExceptActive));
            }
            else if (e.ClickedItem == closeCurrentTabToolStripMenuItem)
            {
                if (dpMain.ActiveContent is PluginForm p)
                {
                    RequestCloseTab(p, new PluginCloseInfo(ToolBoxCloseReason.CloseCurrent));
                }
            }
        }

        private void RequestCloseTab(PluginForm content, PluginCloseInfo info, bool forceSilent = false)
        {
            info.Silent = Options.Instance.CloseEachPluginSilently || forceSilent;
            var plugin = content.Control;
            plugin?.ClosingPlugin(info);
            if (info.Cancel)
            {
                return;
            }

            content.CloseRequested -= PluginForm_CloseRequested;
            pluginConnections.Remove(content);
            CloseTab(content);
        }

        private void RequestCloseTabs(IEnumerable<PluginForm> pages, PluginCloseInfo info)
        {
            var pagesList = pages.ToList();
            if ((info.FormReason != CloseReason.None ||
                 info.ToolBoxReason == ToolBoxCloseReason.CloseAll ||
                 info.ToolBoxReason == ToolBoxCloseReason.CloseAllExceptActive)
                && pagesList.Count > 0)
            {
                info.Cancel = MessageBox.Show(@"Are you sure you want to close " + pagesList.Count + @" tab(s)?", @"Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes;
                if (info.Cancel)
                {
                    return;
                }
            }

            foreach (var page in pagesList)
            {
                RequestCloseTab(page, info, true);
                if (info.Cancel) return;
            }
        }

        /// <summary>
        /// Only to be called from the RequestCloseTab
        /// </summary>
        /// <param name="page"></param>
        private void CloseTab(PluginForm page)
        {
            ((UserControl)page.Control)?.Dispose();
            page.Close();
        }

        private void PluginForm_CloseRequested(object sender, System.EventArgs e)
        {
            RequestCloseTab((PluginForm)sender, new PluginCloseInfo(ToolBoxCloseReason.CloseCurrent));
        }

        #endregion Document management

        private void NewForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Options.Instance.Size.Height = Height;
            Options.Instance.Size.CurrentSize = Size;
            Options.Instance.Size.IsMaximized = WindowState == FormWindowState.Maximized;
            Options.Instance.LastConnection = connectionDetail?.ConnectionName;

            if (dpMain.ActiveContent is PluginForm pf)
            {
                Options.Instance.LastPlugin = pf.PluginTitle;
            }
            else
            {
                Options.Instance.LastPlugin = "";
            }

            Options.Instance.Save();
        }

        private void NewForm_SizeChanged(object sender, System.EventArgs e)
        {
        }
    }
}