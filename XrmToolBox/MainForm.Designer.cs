﻿using System.Drawing;

namespace XrmToolBox
{
    sealed partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbConnect = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tslFilterPlugin = new System.Windows.Forms.ToolStripLabel();
            this.tstxtFilterPlugin = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbManageTabs = new System.Windows.Forms.ToolStripDropDownButton();
            this.closeCurrentTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllTabsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllTabsExceptActiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsddbTools = new System.Windows.Forms.ToolStripDropDownButton();
            this.manageConnectionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.pluginsStoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayXrmToolBoxHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpSelectedPluginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feedbackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GithubXrmToolBoxMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.githubPluginMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.donateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donateInUSDollarsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donateInEuroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donateInGBPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PaypalXrmToolBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PayPalSelectedPluginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donateDollarPluginMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donateEuroPluginMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donateGbpPluginMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.checkForUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutXrmToolBoxToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tssOpenOrg = new System.Windows.Forms.ToolStripSeparator();
            this.tsbOpenOrg = new System.Windows.Forms.ToolStripButton();
            this.pluginsCheckerImageList = new System.Windows.Forms.ImageList(this.components);
            this.cmsOnePlugin = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiOpenProjectHomePage = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiShortcutTool = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShortcutToolConnection = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiHidePlugin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUninstallPlugin = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlSupport = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.llDonate = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.llDismiss = new System.Windows.Forms.LinkLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.HomePageTab = new System.Windows.Forms.TabPage();
            this.pnlPlugins = new System.Windows.Forms.Panel();
            this.pnlSecurityInfo = new System.Windows.Forms.Panel();
            this.lblSecurityFilter = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlNoPluginFound = new System.Windows.Forms.Panel();
            this.llResetSearchFilter = new System.Windows.Forms.LinkLabel();
            this.pbOpenPluginsStore = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPluginsNotFoundText = new System.Windows.Forms.Label();
            this.pnlHelp = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pluginTabsImagesList = new System.Windows.Forms.ImageList(this.components);
            this.pnlConnectLoading = new System.Windows.Forms.Panel();
            this.lblConnecting = new System.Windows.Forms.Label();
            this.pbConnectionLoading = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            this.cmsOnePlugin.SuspendLayout();
            this.pnlSupport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.HomePageTab.SuspendLayout();
            this.pnlSecurityInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlNoPluginFound.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOpenPluginsStore)).BeginInit();
            this.pnlHelp.SuspendLayout();
            this.pnlConnectLoading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbConnectionLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbConnect,
            this.toolStripSeparator2,
            this.tslFilterPlugin,
            this.tstxtFilterPlugin,
            this.toolStripSeparator8,
            this.tsbManageTabs,
            this.toolStripSeparator1,
            this.tsddbTools,
            this.toolStripDropDownButton2,
            this.tssOpenOrg,
            this.tsbOpenOrg});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(884, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbConnect
            // 
            this.tsbConnect.Image = ((System.Drawing.Image)(resources.GetObject("tsbConnect.Image")));
            this.tsbConnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbConnect.Name = "tsbConnect";
            this.tsbConnect.Size = new System.Drawing.Size(72, 22);
            this.tsbConnect.Text = "Connect";
            this.tsbConnect.Click += new System.EventHandler(this.TsbConnectClick);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tslFilterPlugin
            // 
            this.tslFilterPlugin.Name = "tslFilterPlugin";
            this.tslFilterPlugin.Size = new System.Drawing.Size(42, 22);
            this.tslFilterPlugin.Text = "Search";
            // 
            // tstxtFilterPlugin
            // 
            this.tstxtFilterPlugin.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tstxtFilterPlugin.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tstxtFilterPlugin.Name = "tstxtFilterPlugin";
            this.tstxtFilterPlugin.Size = new System.Drawing.Size(152, 25);
            this.tstxtFilterPlugin.ToolTipText = "Filter by plugin name, description or author";
            this.tstxtFilterPlugin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tstxtFilterPlugin_KeyDown);
            this.tstxtFilterPlugin.TextChanged += new System.EventHandler(this.tstxtFilterPlugin_TextChanged);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbManageTabs
            // 
            this.tsbManageTabs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeCurrentTabToolStripMenuItem,
            this.closeAllTabsToolStripMenuItem,
            this.closeAllTabsExceptActiveToolStripMenuItem});
            this.tsbManageTabs.Image = ((System.Drawing.Image)(resources.GetObject("tsbManageTabs.Image")));
            this.tsbManageTabs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbManageTabs.Name = "tsbManageTabs";
            this.tsbManageTabs.Size = new System.Drawing.Size(60, 22);
            this.tsbManageTabs.Text = "Tabs";
            // 
            // closeCurrentTabToolStripMenuItem
            // 
            this.closeCurrentTabToolStripMenuItem.Name = "closeCurrentTabToolStripMenuItem";
            this.closeCurrentTabToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.closeCurrentTabToolStripMenuItem.Text = "Close current tab";
            this.closeCurrentTabToolStripMenuItem.Click += new System.EventHandler(this.closeCurrentTabToolStripMenuItem_Click);
            // 
            // closeAllTabsToolStripMenuItem
            // 
            this.closeAllTabsToolStripMenuItem.Name = "closeAllTabsToolStripMenuItem";
            this.closeAllTabsToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.closeAllTabsToolStripMenuItem.Text = "Close all";
            this.closeAllTabsToolStripMenuItem.Click += new System.EventHandler(this.CloseAllTabsToolStripMenuItemClick);
            // 
            // closeAllTabsExceptActiveToolStripMenuItem
            // 
            this.closeAllTabsExceptActiveToolStripMenuItem.Name = "closeAllTabsExceptActiveToolStripMenuItem";
            this.closeAllTabsExceptActiveToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.closeAllTabsExceptActiveToolStripMenuItem.Text = "Close all except active tab";
            this.closeAllTabsExceptActiveToolStripMenuItem.Click += new System.EventHandler(this.CloseAllTabsExceptActiveToolStripMenuItemClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsddbTools
            // 
            this.tsddbTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageConnectionsToolStripMenuItem,
            this.toolStripSeparator10,
            this.pluginsStoreToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.tsddbTools.Image = ((System.Drawing.Image)(resources.GetObject("tsddbTools.Image")));
            this.tsddbTools.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddbTools.Name = "tsddbTools";
            this.tsddbTools.Size = new System.Drawing.Size(64, 22);
            this.tsddbTools.Text = "Tools";
            // 
            // manageConnectionsToolStripMenuItem
            // 
            this.manageConnectionsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("manageConnectionsToolStripMenuItem.Image")));
            this.manageConnectionsToolStripMenuItem.Name = "manageConnectionsToolStripMenuItem";
            this.manageConnectionsToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.manageConnectionsToolStripMenuItem.Text = "Manage connections";
            this.manageConnectionsToolStripMenuItem.Click += new System.EventHandler(this.manageConnectionsToolStripMenuItem_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(182, 6);
            // 
            // pluginsStoreToolStripMenuItem
            // 
            this.pluginsStoreToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pluginsStoreToolStripMenuItem.Image")));
            this.pluginsStoreToolStripMenuItem.Name = "pluginsStoreToolStripMenuItem";
            this.pluginsStoreToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.pluginsStoreToolStripMenuItem.Text = "Plugins Store";
            this.pluginsStoreToolStripMenuItem.Click += new System.EventHandler(this.pluginsStoreToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("settingsToolStripMenuItem.Image")));
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.feedbackToolStripMenuItem,
            this.toolStripSeparator11,
            this.donateToolStripMenuItem,
            this.toolStripSeparator12,
            this.checkForUpdateToolStripMenuItem,
            this.toolStripSeparator13,
            this.aboutXrmToolBoxToolStripMenuItem1});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(69, 22);
            this.toolStripDropDownButton2.Text = "About";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayXrmToolBoxHelpToolStripMenuItem,
            this.HelpSelectedPluginToolStripMenuItem});
            this.helpToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripMenuItem.Image")));
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // displayXrmToolBoxHelpToolStripMenuItem
            // 
            this.displayXrmToolBoxHelpToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("displayXrmToolBoxHelpToolStripMenuItem.Image")));
            this.displayXrmToolBoxHelpToolStripMenuItem.Name = "displayXrmToolBoxHelpToolStripMenuItem";
            this.displayXrmToolBoxHelpToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.displayXrmToolBoxHelpToolStripMenuItem.Text = "Display XrmToolBox help";
            this.displayXrmToolBoxHelpToolStripMenuItem.Click += new System.EventHandler(this.displayXrmToolBoxHelpToolStripMenuItem_Click);
            // 
            // HelpSelectedPluginToolStripMenuItem
            // 
            this.HelpSelectedPluginToolStripMenuItem.Name = "HelpSelectedPluginToolStripMenuItem";
            this.HelpSelectedPluginToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.HelpSelectedPluginToolStripMenuItem.Tag = "Display {0} help";
            this.HelpSelectedPluginToolStripMenuItem.Text = "Selected Plugin";
            this.HelpSelectedPluginToolStripMenuItem.Click += new System.EventHandler(this.HelpSelectedPluginToolStripMenuItem_Click);
            // 
            // feedbackToolStripMenuItem
            // 
            this.feedbackToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GithubXrmToolBoxMenuItem,
            this.githubPluginMenuItem});
            this.feedbackToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("feedbackToolStripMenuItem.Image")));
            this.feedbackToolStripMenuItem.Name = "feedbackToolStripMenuItem";
            this.feedbackToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.feedbackToolStripMenuItem.Text = "Feedback / Issue / Question";
            this.feedbackToolStripMenuItem.Click += new System.EventHandler(this.feedbackToolStripMenuItem_Click);
            // 
            // GithubXrmToolBoxMenuItem
            // 
            this.GithubXrmToolBoxMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("GithubXrmToolBoxMenuItem.Image")));
            this.GithubXrmToolBoxMenuItem.Name = "GithubXrmToolBoxMenuItem";
            this.GithubXrmToolBoxMenuItem.Size = new System.Drawing.Size(155, 22);
            this.GithubXrmToolBoxMenuItem.Text = "XrmToolbox";
            this.GithubXrmToolBoxMenuItem.Click += new System.EventHandler(this.GithubXrmToolBoxMenuItem_Click);
            // 
            // githubPluginMenuItem
            // 
            this.githubPluginMenuItem.Name = "githubPluginMenuItem";
            this.githubPluginMenuItem.Size = new System.Drawing.Size(155, 22);
            this.githubPluginMenuItem.Text = "Selected Plugin";
            this.githubPluginMenuItem.Visible = false;
            this.githubPluginMenuItem.Click += new System.EventHandler(this.githubPluginMenuItem_Click);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(217, 6);
            // 
            // donateToolStripMenuItem
            // 
            this.donateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.donateInUSDollarsToolStripMenuItem,
            this.donateInEuroToolStripMenuItem,
            this.donateInGBPToolStripMenuItem,
            this.PaypalXrmToolBoxToolStripMenuItem,
            this.PayPalSelectedPluginToolStripMenuItem});
            this.donateToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("donateToolStripMenuItem.Image")));
            this.donateToolStripMenuItem.Name = "donateToolStripMenuItem";
            this.donateToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.donateToolStripMenuItem.Text = "Donate";
            // 
            // donateInUSDollarsToolStripMenuItem
            // 
            this.donateInUSDollarsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("donateInUSDollarsToolStripMenuItem.Image")));
            this.donateInUSDollarsToolStripMenuItem.Name = "donateInUSDollarsToolStripMenuItem";
            this.donateInUSDollarsToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.donateInUSDollarsToolStripMenuItem.Text = "Donate in US Dollars";
            this.donateInUSDollarsToolStripMenuItem.Click += new System.EventHandler(this.donateInUSDollarsToolStripMenuItem_Click);
            // 
            // donateInEuroToolStripMenuItem
            // 
            this.donateInEuroToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("donateInEuroToolStripMenuItem.Image")));
            this.donateInEuroToolStripMenuItem.Name = "donateInEuroToolStripMenuItem";
            this.donateInEuroToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.donateInEuroToolStripMenuItem.Text = "Donate in Euro";
            this.donateInEuroToolStripMenuItem.Click += new System.EventHandler(this.donateInEuroToolStripMenuItem_Click);
            // 
            // donateInGBPToolStripMenuItem
            // 
            this.donateInGBPToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("donateInGBPToolStripMenuItem.Image")));
            this.donateInGBPToolStripMenuItem.Name = "donateInGBPToolStripMenuItem";
            this.donateInGBPToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.donateInGBPToolStripMenuItem.Text = "Donate in GBP";
            this.donateInGBPToolStripMenuItem.Click += new System.EventHandler(this.donateInGBPToolStripMenuItem_Click);
            // 
            // PaypalXrmToolBoxToolStripMenuItem
            // 
            this.PaypalXrmToolBoxToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("PaypalXrmToolBoxToolStripMenuItem.Image")));
            this.PaypalXrmToolBoxToolStripMenuItem.Name = "PaypalXrmToolBoxToolStripMenuItem";
            this.PaypalXrmToolBoxToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.PaypalXrmToolBoxToolStripMenuItem.Text = "XrmToolBox";
            // 
            // PayPalSelectedPluginToolStripMenuItem
            // 
            this.PayPalSelectedPluginToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.donateDollarPluginMenuItem,
            this.donateEuroPluginMenuItem,
            this.donateGbpPluginMenuItem});
            this.PayPalSelectedPluginToolStripMenuItem.Name = "PayPalSelectedPluginToolStripMenuItem";
            this.PayPalSelectedPluginToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.PayPalSelectedPluginToolStripMenuItem.Text = "SelectedPlugin";
            // 
            // donateDollarPluginMenuItem
            // 
            this.donateDollarPluginMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("donateDollarPluginMenuItem.Image")));
            this.donateDollarPluginMenuItem.Name = "donateDollarPluginMenuItem";
            this.donateDollarPluginMenuItem.Size = new System.Drawing.Size(181, 22);
            this.donateDollarPluginMenuItem.Text = "Donate in US Dollars";
            this.donateDollarPluginMenuItem.Click += new System.EventHandler(this.donateDollarPluginMenuItem_Click);
            // 
            // donateEuroPluginMenuItem
            // 
            this.donateEuroPluginMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("donateEuroPluginMenuItem.Image")));
            this.donateEuroPluginMenuItem.Name = "donateEuroPluginMenuItem";
            this.donateEuroPluginMenuItem.Size = new System.Drawing.Size(181, 22);
            this.donateEuroPluginMenuItem.Text = "Donate in Euro";
            this.donateEuroPluginMenuItem.Click += new System.EventHandler(this.donateEuroPluginMenuItem_Click);
            // 
            // donateGbpPluginMenuItem
            // 
            this.donateGbpPluginMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("donateGbpPluginMenuItem.Image")));
            this.donateGbpPluginMenuItem.Name = "donateGbpPluginMenuItem";
            this.donateGbpPluginMenuItem.Size = new System.Drawing.Size(181, 22);
            this.donateGbpPluginMenuItem.Text = "Donate in GBP";
            this.donateGbpPluginMenuItem.Click += new System.EventHandler(this.donateGbpPluginMenuItem_Click);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(217, 6);
            // 
            // checkForUpdateToolStripMenuItem
            // 
            this.checkForUpdateToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("checkForUpdateToolStripMenuItem.Image")));
            this.checkForUpdateToolStripMenuItem.Name = "checkForUpdateToolStripMenuItem";
            this.checkForUpdateToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.checkForUpdateToolStripMenuItem.Text = "Check for update";
            this.checkForUpdateToolStripMenuItem.Click += new System.EventHandler(this.checkForUpdateToolStripMenuItem_Click);
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(217, 6);
            // 
            // aboutXrmToolBoxToolStripMenuItem1
            // 
            this.aboutXrmToolBoxToolStripMenuItem1.Name = "aboutXrmToolBoxToolStripMenuItem1";
            this.aboutXrmToolBoxToolStripMenuItem1.Size = new System.Drawing.Size(220, 22);
            this.aboutXrmToolBoxToolStripMenuItem1.Text = "About XrmToolBox";
            this.aboutXrmToolBoxToolStripMenuItem1.Click += new System.EventHandler(this.aboutXrmToolBoxToolStripMenuItem_Click);
            // 
            // tssOpenOrg
            // 
            this.tssOpenOrg.Name = "tssOpenOrg";
            this.tssOpenOrg.Size = new System.Drawing.Size(6, 25);
            this.tssOpenOrg.Visible = false;
            // 
            // tsbOpenOrg
            // 
            this.tsbOpenOrg.Image = ((System.Drawing.Image)(resources.GetObject("tsbOpenOrg.Image")));
            this.tsbOpenOrg.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOpenOrg.Name = "tsbOpenOrg";
            this.tsbOpenOrg.Size = new System.Drawing.Size(125, 22);
            this.tsbOpenOrg.Text = "Open organization";
            this.tsbOpenOrg.ToolTipText = "Opens the connected organization in your web browser";
            this.tsbOpenOrg.Visible = false;
            this.tsbOpenOrg.Click += new System.EventHandler(this.tsbOpenOrg_Click);
            // 
            // pluginsCheckerImageList
            // 
            this.pluginsCheckerImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("pluginsCheckerImageList.ImageStream")));
            this.pluginsCheckerImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.pluginsCheckerImageList.Images.SetKeyName(0, "plugin.png");
            this.pluginsCheckerImageList.Images.SetKeyName(1, "plugin.png");
            this.pluginsCheckerImageList.Images.SetKeyName(2, "PluginsStore16.png");
            this.pluginsCheckerImageList.Images.SetKeyName(3, "PluginsStore16green.png");
            // 
            // cmsOnePlugin
            // 
            this.cmsOnePlugin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOpenProjectHomePage,
            this.toolStripSeparator9,
            this.tsmiShortcutTool,
            this.tsmiShortcutToolConnection,
            this.toolStripSeparator7,
            this.tsmiHidePlugin,
            this.tsmiUninstallPlugin});
            this.cmsOnePlugin.Name = "cmsOnePlugin";
            this.cmsOnePlugin.Size = new System.Drawing.Size(278, 126);
            // 
            // tsmiOpenProjectHomePage
            // 
            this.tsmiOpenProjectHomePage.Name = "tsmiOpenProjectHomePage";
            this.tsmiOpenProjectHomePage.Size = new System.Drawing.Size(277, 22);
            this.tsmiOpenProjectHomePage.Text = "Open project home page";
            this.tsmiOpenProjectHomePage.Click += new System.EventHandler(this.tsmiOpenProjectHomePage_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(274, 6);
            // 
            // tsmiShortcutTool
            // 
            this.tsmiShortcutTool.Name = "tsmiShortcutTool";
            this.tsmiShortcutTool.Size = new System.Drawing.Size(277, 22);
            this.tsmiShortcutTool.Text = "Create shortcut (Tool)";
            this.tsmiShortcutTool.Click += new System.EventHandler(this.tsmiShortcutTool_Click);
            // 
            // tsmiShortcutToolConnection
            // 
            this.tsmiShortcutToolConnection.Name = "tsmiShortcutToolConnection";
            this.tsmiShortcutToolConnection.Size = new System.Drawing.Size(277, 22);
            this.tsmiShortcutToolConnection.Text = "Create shortcut (Tool and Connection)";
            this.tsmiShortcutToolConnection.Click += new System.EventHandler(this.tsmiShortcutToolConnection_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(274, 6);
            // 
            // tsmiHidePlugin
            // 
            this.tsmiHidePlugin.Name = "tsmiHidePlugin";
            this.tsmiHidePlugin.Size = new System.Drawing.Size(277, 22);
            this.tsmiHidePlugin.Text = "Hide";
            this.tsmiHidePlugin.Click += new System.EventHandler(this.tsmiHidePlugin_Click);
            // 
            // tsmiUninstallPlugin
            // 
            this.tsmiUninstallPlugin.Name = "tsmiUninstallPlugin";
            this.tsmiUninstallPlugin.Size = new System.Drawing.Size(277, 22);
            this.tsmiUninstallPlugin.Text = "Uninstall";
            this.tsmiUninstallPlugin.Click += new System.EventHandler(this.tsmiUninstallPlugin_Click);
            // 
            // pnlSupport
            // 
            this.pnlSupport.BackColor = System.Drawing.Color.White;
            this.pnlSupport.Controls.Add(this.pictureBox2);
            this.pnlSupport.Controls.Add(this.llDonate);
            this.pnlSupport.Controls.Add(this.label5);
            this.pnlSupport.Controls.Add(this.label4);
            this.pnlSupport.Controls.Add(this.lblTitle);
            this.pnlSupport.Controls.Add(this.llDismiss);
            this.pnlSupport.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSupport.Location = new System.Drawing.Point(0, 432);
            this.pnlSupport.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlSupport.Name = "pnlSupport";
            this.pnlSupport.Size = new System.Drawing.Size(884, 67);
            this.pnlSupport.TabIndex = 3;
            this.pnlSupport.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(656, 10);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(158, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // llDonate
            // 
            this.llDonate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.llDonate.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.llDonate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.llDonate.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.llDonate.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.llDonate.Location = new System.Drawing.Point(334, 43);
            this.llDonate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llDonate.Name = "llDonate";
            this.llDonate.Size = new System.Drawing.Size(306, 16);
            this.llDonate.TabIndex = 21;
            this.llDonate.TabStop = true;
            this.llDonate.Text = "Click here to donate";
            this.llDonate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.llDonate.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.llDonate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llDonate_LinkClicked);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(330, 6);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(320, 37);
            this.label5.TabIndex = 20;
            this.label5.Text = "XrmToolBox is free and it won\'t change. But you can show your support by making a" +
    " donation to its author.";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(98, 39);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Donate on PayPal";
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitle.Location = new System.Drawing.Point(2, 3);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(342, 35);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "How can I help MscrmTools?";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // llDismiss
            // 
            this.llDismiss.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.llDismiss.AutoSize = true;
            this.llDismiss.Location = new System.Drawing.Point(838, 3);
            this.llDismiss.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llDismiss.Name = "llDismiss";
            this.llDismiss.Size = new System.Drawing.Size(42, 13);
            this.llDismiss.TabIndex = 0;
            this.llDismiss.TabStop = true;
            this.llDismiss.Text = "Dismiss";
            this.llDismiss.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llDismiss_LinkClicked);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.HomePageTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ImageList = this.pluginTabsImagesList;
            this.tabControl1.Location = new System.Drawing.Point(0, 25);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(884, 407);
            this.tabControl1.TabIndex = 4;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.tabControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseClick);
            // 
            // HomePageTab
            // 
            this.HomePageTab.AutoScroll = true;
            this.HomePageTab.Controls.Add(this.pnlPlugins);
            this.HomePageTab.Controls.Add(this.pnlSecurityInfo);
            this.HomePageTab.Controls.Add(this.pnlNoPluginFound);
            this.HomePageTab.Controls.Add(this.pnlHelp);
            this.HomePageTab.Location = new System.Drawing.Point(4, 23);
            this.HomePageTab.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.HomePageTab.Name = "HomePageTab";
            this.HomePageTab.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.HomePageTab.Size = new System.Drawing.Size(876, 380);
            this.HomePageTab.TabIndex = 0;
            this.HomePageTab.Text = "Home";
            this.HomePageTab.UseVisualStyleBackColor = true;
            // 
            // pnlPlugins
            // 
            this.pnlPlugins.AutoScroll = true;
            this.pnlPlugins.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPlugins.Location = new System.Drawing.Point(2, 43);
            this.pnlPlugins.Margin = new System.Windows.Forms.Padding(2);
            this.pnlPlugins.Name = "pnlPlugins";
            this.pnlPlugins.Size = new System.Drawing.Size(872, 334);
            this.pnlPlugins.TabIndex = 9;
            // 
            // pnlSecurityInfo
            // 
            this.pnlSecurityInfo.BackColor = System.Drawing.Color.LightBlue;
            this.pnlSecurityInfo.Controls.Add(this.lblSecurityFilter);
            this.pnlSecurityInfo.Controls.Add(this.pictureBox1);
            this.pnlSecurityInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSecurityInfo.Location = new System.Drawing.Point(2, 3);
            this.pnlSecurityInfo.Name = "pnlSecurityInfo";
            this.pnlSecurityInfo.Size = new System.Drawing.Size(872, 40);
            this.pnlSecurityInfo.TabIndex = 4;
            // 
            // lblSecurityFilter
            // 
            this.lblSecurityFilter.AutoSize = true;
            this.lblSecurityFilter.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.lblSecurityFilter.Location = new System.Drawing.Point(44, 7);
            this.lblSecurityFilter.Name = "lblSecurityFilter";
            this.lblSecurityFilter.Size = new System.Drawing.Size(670, 25);
            this.lblSecurityFilter.TabIndex = 1;
            this.lblSecurityFilter.Text = "Plugins list filtered by your IT administrator(s). Some plugins may not appear be" +
    "low\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlNoPluginFound
            // 
            this.pnlNoPluginFound.BackColor = System.Drawing.Color.White;
            this.pnlNoPluginFound.Controls.Add(this.llResetSearchFilter);
            this.pnlNoPluginFound.Controls.Add(this.pbOpenPluginsStore);
            this.pnlNoPluginFound.Controls.Add(this.label3);
            this.pnlNoPluginFound.Controls.Add(this.lblPluginsNotFoundText);
            this.pnlNoPluginFound.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNoPluginFound.Location = new System.Drawing.Point(2, 3);
            this.pnlNoPluginFound.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlNoPluginFound.Name = "pnlNoPluginFound";
            this.pnlNoPluginFound.Size = new System.Drawing.Size(872, 374);
            this.pnlNoPluginFound.TabIndex = 7;
            this.pnlNoPluginFound.Visible = false;
            // 
            // llResetSearchFilter
            // 
            this.llResetSearchFilter.AutoSize = true;
            this.llResetSearchFilter.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(117)))), ((int)(((byte)(188)))));
            this.llResetSearchFilter.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(117)))), ((int)(((byte)(188)))));
            this.llResetSearchFilter.Location = new System.Drawing.Point(370, 265);
            this.llResetSearchFilter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llResetSearchFilter.Name = "llResetSearchFilter";
            this.llResetSearchFilter.Size = new System.Drawing.Size(129, 13);
            this.llResetSearchFilter.TabIndex = 3;
            this.llResetSearchFilter.TabStop = true;
            this.llResetSearchFilter.Text = "or reset the search filter";
            this.llResetSearchFilter.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llResetSearchFilter_LinkClicked);
            // 
            // pbOpenPluginsStore
            // 
            this.pbOpenPluginsStore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbOpenPluginsStore.Image = ((System.Drawing.Image)(resources.GetObject("pbOpenPluginsStore.Image")));
            this.pbOpenPluginsStore.Location = new System.Drawing.Point(234, 156);
            this.pbOpenPluginsStore.Margin = new System.Windows.Forms.Padding(2);
            this.pbOpenPluginsStore.Name = "pbOpenPluginsStore";
            this.pbOpenPluginsStore.Size = new System.Drawing.Size(400, 83);
            this.pbOpenPluginsStore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbOpenPluginsStore.TabIndex = 2;
            this.pbOpenPluginsStore.TabStop = false;
            this.pbOpenPluginsStore.Click += new System.EventHandler(this.pbOpenPluginsStore_Click);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(117)))), ((int)(((byte)(188)))));
            this.label3.Location = new System.Drawing.Point(0, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(872, 52);
            this.label3.TabIndex = 1;
            this.label3.Tag = "";
            this.label3.Text = "Please redefine the criteria, reset it, or download some new plugins from our plu" +
    "gin store";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPluginsNotFoundText
            // 
            this.lblPluginsNotFoundText.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPluginsNotFoundText.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPluginsNotFoundText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(117)))), ((int)(((byte)(188)))));
            this.lblPluginsNotFoundText.Location = new System.Drawing.Point(0, 0);
            this.lblPluginsNotFoundText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPluginsNotFoundText.Name = "lblPluginsNotFoundText";
            this.lblPluginsNotFoundText.Size = new System.Drawing.Size(872, 52);
            this.lblPluginsNotFoundText.TabIndex = 0;
            this.lblPluginsNotFoundText.Tag = "Searching for \"{0}\" did not match any plugins installed";
            this.lblPluginsNotFoundText.Text = "Searching for \"{0}\" did not match any plugins installed";
            this.lblPluginsNotFoundText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlHelp
            // 
            this.pnlHelp.BackColor = System.Drawing.Color.White;
            this.pnlHelp.Controls.Add(this.label2);
            this.pnlHelp.Controls.Add(this.label1);
            this.pnlHelp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHelp.Location = new System.Drawing.Point(2, 3);
            this.pnlHelp.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlHelp.Name = "pnlHelp";
            this.pnlHelp.Size = new System.Drawing.Size(872, 374);
            this.pnlHelp.TabIndex = 8;
            this.pnlHelp.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(864, 113);
            this.label2.TabIndex = 1;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(872, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Oups... no plugin found!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pluginTabsImagesList
            // 
            this.pluginTabsImagesList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.pluginTabsImagesList.ImageSize = new System.Drawing.Size(16, 16);
            this.pluginTabsImagesList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pnlConnectLoading
            // 
            this.pnlConnectLoading.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlConnectLoading.BackColor = System.Drawing.Color.Transparent;
            this.pnlConnectLoading.Controls.Add(this.lblConnecting);
            this.pnlConnectLoading.Controls.Add(this.pbConnectionLoading);
            this.pnlConnectLoading.Location = new System.Drawing.Point(0, 0);
            this.pnlConnectLoading.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlConnectLoading.Name = "pnlConnectLoading";
            this.pnlConnectLoading.Size = new System.Drawing.Size(884, 499);
            this.pnlConnectLoading.TabIndex = 4;
            this.pnlConnectLoading.Visible = false;
            // 
            // lblConnecting
            // 
            this.lblConnecting.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblConnecting.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnecting.Location = new System.Drawing.Point(0, 275);
            this.lblConnecting.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConnecting.Name = "lblConnecting";
            this.lblConnecting.Size = new System.Drawing.Size(884, 28);
            this.lblConnecting.TabIndex = 1;
            this.lblConnecting.Tag = "Please wait while XrmToolBox is connecting to {0}";
            this.lblConnecting.Text = "Please wait while XrmToolBox is connecting to {0}";
            this.lblConnecting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbConnectionLoading
            // 
            this.pbConnectionLoading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbConnectionLoading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbConnectionLoading.Image = ((System.Drawing.Image)(resources.GetObject("pbConnectionLoading.Image")));
            this.pbConnectionLoading.Location = new System.Drawing.Point(0, 157);
            this.pbConnectionLoading.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pbConnectionLoading.Name = "pbConnectionLoading";
            this.pbConnectionLoading.Size = new System.Drawing.Size(884, 106);
            this.pbConnectionLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbConnectionLoading.TabIndex = 0;
            this.pbConnectionLoading.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 499);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pnlSupport);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pnlConnectLoading);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "MainForm";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XrmToolBox for Microsoft Dynamics CRM / 365 CE";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainForm_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.MainForm_PreviewKeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.cmsOnePlugin.ResumeLayout(false);
            this.pnlSupport.ResumeLayout(false);
            this.pnlSupport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.HomePageTab.ResumeLayout(false);
            this.pnlSecurityInfo.ResumeLayout(false);
            this.pnlSecurityInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlNoPluginFound.ResumeLayout(false);
            this.pnlNoPluginFound.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOpenPluginsStore)).EndInit();
            this.pnlHelp.ResumeLayout(false);
            this.pnlConnectLoading.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbConnectionLoading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbConnect;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripDropDownButton tsbManageTabs;
        private System.Windows.Forms.ToolStripMenuItem closeAllTabsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllTabsExceptActiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donateInUSDollarsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donateInEuroToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem donateInGBPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeCurrentTabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GithubXrmToolBoxMenuItem;
        private System.Windows.Forms.ToolStripMenuItem githubPluginMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PaypalXrmToolBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PayPalSelectedPluginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donateDollarPluginMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donateEuroPluginMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donateGbpPluginMenuItem;
        private System.Windows.Forms.ToolStripLabel tslFilterPlugin;
        private System.Windows.Forms.ToolStripTextBox tstxtFilterPlugin;
        private System.Windows.Forms.ToolStripMenuItem displayXrmToolBoxHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpSelectedPluginToolStripMenuItem;
        private System.Windows.Forms.ImageList pluginsCheckerImageList;
        private System.Windows.Forms.ContextMenuStrip cmsOnePlugin;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpenProjectHomePage;
        private System.Windows.Forms.ToolStripMenuItem tsmiHidePlugin;
        private System.Windows.Forms.ToolStripMenuItem tsmiUninstallPlugin;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem tsmiShortcutTool;
        private System.Windows.Forms.ToolStripMenuItem tsmiShortcutToolConnection;
        private System.Windows.Forms.Panel pnlSupport;
        private System.Windows.Forms.LinkLabel llDismiss;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage HomePageTab;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel llDonate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel pnlConnectLoading;
        private System.Windows.Forms.Label lblConnecting;
        private System.Windows.Forms.PictureBox pbConnectionLoading;
        private System.Windows.Forms.ToolStripDropDownButton tsddbTools;
        private System.Windows.Forms.ToolStripMenuItem manageConnectionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripMenuItem pluginsStoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem feedbackToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripMenuItem donateToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
        private System.Windows.Forms.ToolStripMenuItem aboutXrmToolBoxToolStripMenuItem1;
        private System.Windows.Forms.ImageList pluginTabsImagesList;
        private System.Windows.Forms.ToolStripSeparator tssOpenOrg;
        private System.Windows.Forms.ToolStripButton tsbOpenOrg;
        private System.Windows.Forms.Panel pnlNoPluginFound;
        private System.Windows.Forms.LinkLabel llResetSearchFilter;
        private System.Windows.Forms.PictureBox pbOpenPluginsStore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPluginsNotFoundText;
        private System.Windows.Forms.Panel pnlSecurityInfo;
        private System.Windows.Forms.Panel pnlHelp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlPlugins;
        private System.Windows.Forms.Label lblSecurityFilter;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

