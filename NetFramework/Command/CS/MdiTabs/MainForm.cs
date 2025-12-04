using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using C1.Win.Command;

namespace MdiTabs
{
	/// <summary>
	/// Summary description for MainForm.
	/// </summary>
	public class MainForm : System.Windows.Forms.Form
	{
        private C1.Win.Command.C1MainMenu c1MainMenu1;
        private C1.Win.Command.C1CommandHolder c1CommandHolder1;
        private C1.Win.Command.C1CommandLink c1CommandLink1;
        private C1.Win.Command.C1ToolBar c1ToolBar1;
        private C1.Win.Command.C1CommandLink c1CommandLink2;
        private C1.Win.Command.C1CommandMenu mnuFile;
        private C1.Win.Command.C1CommandLink c1CommandLink3;
        private C1.Win.Command.C1CommandLink c1CommandLink4;
        private C1.Win.Command.C1CommandMenu mnuEdit;
        private C1.Win.Command.C1CommandLink c1CommandLink5;
        private C1.Win.Command.C1CommandLink c1CommandLink6;
        private C1.Win.Command.C1CommandMenu mnuWindow;
        private C1.Win.Command.C1CommandLink c1CommandLink7;
        private C1.Win.Command.C1Command cmdExit;
        private System.Windows.Forms.ImageList imageList1;
        private C1.Win.Command.C1CommandLink c1CommandLink8;
        private C1.Win.Command.C1Command cmdFileNew;
        private C1.Win.Command.C1CommandDock dockToolbar;
        private C1.Win.Command.C1CommandDock dockSidebar;
        private C1.Win.Command.C1CommandDock dockTray;
        private C1.Win.Command.C1DockingTabPage c1DockingTabPage2;
        private C1.Win.Command.C1DockingTabPage c1DockingTabPage3;
        private C1.Win.Command.C1DockingTab tabSidebar;
        private C1.Win.Command.C1DockingTab tabTray;
        private C1.Win.Command.C1DockingTab tabMain;
        private C1.Win.Command.C1CommandLink c1CommandLink9;
        private C1.Win.Command.C1Command cmdFileOpen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private C1.Win.Command.C1CommandLink c1CommandLink10;
        private C1.Win.Command.C1CommandLink c1CommandLink11;
        private C1.Win.Command.C1Command cmdFileSave;
        private C1.Win.Command.C1CommandLink c1CommandLink12;
        private C1.Win.Command.C1Command cmdWindowCloseAll;
        private System.Windows.Forms.TextBox textLog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private MdiTabs.DirView dirView;
        private C1.Win.Command.C1DockingTabPage c1DockingTabPage1;
        private System.Windows.Forms.ListBox listOpenFiles;
        private C1CommandMenu c1CommandMenuOptions;
        private C1CommandLink c1CommandLink14;
        private C1CommandLink c1CommandLink13;
        private C1Command c1CommandVS2005;
        private System.ComponentModel.IContainer components;

		public MainForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
            SetDockingStyle(true);
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("...");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("A:", 0, 4, new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("...");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("C:", 0, 4, new System.Windows.Forms.TreeNode[] {
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("...");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("D:", 0, 4, new System.Windows.Forms.TreeNode[] {
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("...");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("E:", 0, 4, new System.Windows.Forms.TreeNode[] {
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("...");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("F:", 0, 4, new System.Windows.Forms.TreeNode[] {
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("...");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("G:", 0, 4, new System.Windows.Forms.TreeNode[] {
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("...");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("U:", 0, 4, new System.Windows.Forms.TreeNode[] {
            treeNode13});
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("...");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("W:", 0, 4, new System.Windows.Forms.TreeNode[] {
            treeNode15});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("...");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("X:", 0, 4, new System.Windows.Forms.TreeNode[] {
            treeNode17});
            this.c1MainMenu1 = new C1.Win.Command.C1MainMenu();
            this.c1CommandHolder1 = new C1.Win.Command.C1CommandHolder();
            this.mnuFile = new C1.Win.Command.C1CommandMenu();
            this.c1CommandLink8 = new C1.Win.Command.C1CommandLink();
            this.cmdFileNew = new C1.Win.Command.C1Command();
            this.c1CommandLink9 = new C1.Win.Command.C1CommandLink();
            this.cmdFileOpen = new C1.Win.Command.C1Command();
            this.c1CommandLink11 = new C1.Win.Command.C1CommandLink();
            this.cmdFileSave = new C1.Win.Command.C1Command();
            this.c1CommandLink3 = new C1.Win.Command.C1CommandLink();
            this.cmdExit = new C1.Win.Command.C1Command();
            this.mnuEdit = new C1.Win.Command.C1CommandMenu();
            this.c1CommandLink5 = new C1.Win.Command.C1CommandLink();
            this.mnuWindow = new C1.Win.Command.C1CommandMenu();
            this.c1CommandLink7 = new C1.Win.Command.C1CommandLink();
            this.cmdWindowCloseAll = new C1.Win.Command.C1Command();
            this.c1CommandMenuOptions = new C1.Win.Command.C1CommandMenu();
            this.c1CommandLink14 = new C1.Win.Command.C1CommandLink();
            this.c1CommandVS2005 = new C1.Win.Command.C1Command();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.c1CommandLink1 = new C1.Win.Command.C1CommandLink();
            this.c1CommandLink4 = new C1.Win.Command.C1CommandLink();
            this.c1CommandLink13 = new C1.Win.Command.C1CommandLink();
            this.c1CommandLink6 = new C1.Win.Command.C1CommandLink();
            this.dockToolbar = new C1.Win.Command.C1CommandDock();
            this.c1ToolBar1 = new C1.Win.Command.C1ToolBar();
            this.c1CommandLink2 = new C1.Win.Command.C1CommandLink();
            this.c1CommandLink10 = new C1.Win.Command.C1CommandLink();
            this.c1CommandLink12 = new C1.Win.Command.C1CommandLink();
            this.dockSidebar = new C1.Win.Command.C1CommandDock();
            this.tabSidebar = new C1.Win.Command.C1DockingTab();
            this.c1DockingTabPage2 = new C1.Win.Command.C1DockingTabPage();
            this.dirView = new MdiTabs.DirView();
            this.c1DockingTabPage1 = new C1.Win.Command.C1DockingTabPage();
            this.listOpenFiles = new System.Windows.Forms.ListBox();
            this.dockTray = new C1.Win.Command.C1CommandDock();
            this.tabTray = new C1.Win.Command.C1DockingTab();
            this.c1DockingTabPage3 = new C1.Win.Command.C1DockingTabPage();
            this.textLog = new System.Windows.Forms.TextBox();
            this.tabMain = new C1.Win.Command.C1DockingTab();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockToolbar)).BeginInit();
            this.dockToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dockSidebar)).BeginInit();
            this.dockSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabSidebar)).BeginInit();
            this.tabSidebar.SuspendLayout();
            this.c1DockingTabPage2.SuspendLayout();
            this.c1DockingTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dockTray)).BeginInit();
            this.dockTray.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabTray)).BeginInit();
            this.tabTray.SuspendLayout();
            this.c1DockingTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).BeginInit();
            this.SuspendLayout();
            // 
            // c1MainMenu1
            // 
            this.c1MainMenu1.AccessibleName = "Menu Bar";
            this.c1MainMenu1.CommandHolder = this.c1CommandHolder1;
            this.c1MainMenu1.CommandLinks.AddRange(new C1.Win.Command.C1CommandLink[] {
            this.c1CommandLink1,
            this.c1CommandLink4,
            this.c1CommandLink13,
            this.c1CommandLink6});
            this.c1MainMenu1.Dock = System.Windows.Forms.DockStyle.Top;
            this.c1MainMenu1.Location = new System.Drawing.Point(0, 0);
            this.c1MainMenu1.Name = "c1MainMenu1";
            this.c1MainMenu1.Size = new System.Drawing.Size(760, 21);
            // 
            // c1CommandHolder1
            // 
            this.c1CommandHolder1.Commands.Add(this.mnuFile);
            this.c1CommandHolder1.Commands.Add(this.mnuEdit);
            this.c1CommandHolder1.Commands.Add(this.mnuWindow);
            this.c1CommandHolder1.Commands.Add(this.cmdExit);
            this.c1CommandHolder1.Commands.Add(this.cmdFileNew);
            this.c1CommandHolder1.Commands.Add(this.cmdFileOpen);
            this.c1CommandHolder1.Commands.Add(this.cmdFileSave);
            this.c1CommandHolder1.Commands.Add(this.cmdWindowCloseAll);
            this.c1CommandHolder1.Commands.Add(this.c1CommandMenuOptions);
            this.c1CommandHolder1.Commands.Add(this.c1CommandVS2005);
            this.c1CommandHolder1.ImageList = this.imageList1;
            this.c1CommandHolder1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.c1CommandHolder1.Owner = this;
            // 
            // mnuFile
            // 
            this.mnuFile.CommandLinks.AddRange(new C1.Win.Command.C1CommandLink[] {
            this.c1CommandLink8,
            this.c1CommandLink9,
            this.c1CommandLink11,
            this.c1CommandLink3});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Text = "&File";
            // 
            // c1CommandLink8
            // 
            this.c1CommandLink8.Command = this.cmdFileNew;
            // 
            // cmdFileNew
            // 
            this.cmdFileNew.ImageIndex = 1;
            this.cmdFileNew.Name = "cmdFileNew";
            this.cmdFileNew.Text = "&New";
            this.cmdFileNew.Click += new C1.Win.Command.ClickEventHandler(this.cmdFileNew_Click);
            // 
            // c1CommandLink9
            // 
            this.c1CommandLink9.Command = this.cmdFileOpen;
            // 
            // cmdFileOpen
            // 
            this.cmdFileOpen.ImageIndex = 0;
            this.cmdFileOpen.Name = "cmdFileOpen";
            this.cmdFileOpen.Text = "&Open";
            this.cmdFileOpen.Click += new C1.Win.Command.ClickEventHandler(this.cmdFileOpen_Click);
            // 
            // c1CommandLink11
            // 
            this.c1CommandLink11.Command = this.cmdFileSave;
            // 
            // cmdFileSave
            // 
            this.cmdFileSave.ImageIndex = 2;
            this.cmdFileSave.Name = "cmdFileSave";
            this.cmdFileSave.Text = "&Save";
            this.cmdFileSave.CommandStateQuery += new C1.Win.Command.CommandStateQueryEventHandler(this.cmdFileSave_CommandStateQuery);
            this.cmdFileSave.Click += new C1.Win.Command.ClickEventHandler(this.cmdFileSave_Click);
            // 
            // c1CommandLink3
            // 
            this.c1CommandLink3.Command = this.cmdExit;
            this.c1CommandLink3.Delimiter = true;
            // 
            // cmdExit
            // 
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Text = "E&xit";
            this.cmdExit.Click += new C1.Win.Command.ClickEventHandler(this.cmdExit_Click);
            // 
            // mnuEdit
            // 
            this.mnuEdit.CommandLinks.AddRange(new C1.Win.Command.C1CommandLink[] {
            this.c1CommandLink5});
            this.mnuEdit.HideNonRecentLinks = false;
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Text = "&Edit";
            // 
            // c1CommandLink5
            // 
            this.c1CommandLink5.Text = "[TBD]";
            // 
            // mnuWindow
            // 
            this.mnuWindow.CommandLinks.AddRange(new C1.Win.Command.C1CommandLink[] {
            this.c1CommandLink7});
            this.mnuWindow.HideNonRecentLinks = false;
            this.mnuWindow.Name = "mnuWindow";
            this.mnuWindow.Text = "&Window";
            this.mnuWindow.Popup += new System.EventHandler(this.mnuWindow_Popup);
            // 
            // c1CommandLink7
            // 
            this.c1CommandLink7.Command = this.cmdWindowCloseAll;
            // 
            // cmdWindowCloseAll
            // 
            this.cmdWindowCloseAll.Name = "cmdWindowCloseAll";
            this.cmdWindowCloseAll.Text = "Close &All";
            this.cmdWindowCloseAll.CommandStateQuery += new C1.Win.Command.CommandStateQueryEventHandler(this.cmdWindowCloseAll_CommandStateQuery);
            this.cmdWindowCloseAll.Click += new C1.Win.Command.ClickEventHandler(this.cmdWindowCloseAll_Click);
            // 
            // c1CommandMenuOptions
            // 
            this.c1CommandMenuOptions.CommandLinks.AddRange(new C1.Win.Command.C1CommandLink[] {
            this.c1CommandLink14});
            this.c1CommandMenuOptions.HideNonRecentLinks = false;
            this.c1CommandMenuOptions.Name = "c1CommandMenuOptions";
            this.c1CommandMenuOptions.Text = "O&ptions";
            // 
            // c1CommandLink14
            // 
            this.c1CommandLink14.Command = this.c1CommandVS2005;
            // 
            // c1CommandVS2005
            // 
            this.c1CommandVS2005.CheckAutoToggle = true;
            this.c1CommandVS2005.Checked = true;
            this.c1CommandVS2005.Name = "c1CommandVS2005";
            this.c1CommandVS2005.Text = "VS2005 Docking";
            this.c1CommandVS2005.CheckedChanged += new C1.Win.Command.CheckedChangedEventHandler(this.c1CommandVS2005_CheckedChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Magenta;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            // 
            // c1CommandLink1
            // 
            this.c1CommandLink1.Command = this.mnuFile;
            // 
            // c1CommandLink4
            // 
            this.c1CommandLink4.Command = this.mnuEdit;
            this.c1CommandLink4.SortOrder = 1;
            // 
            // c1CommandLink13
            // 
            this.c1CommandLink13.Command = this.c1CommandMenuOptions;
            this.c1CommandLink13.SortOrder = 2;
            // 
            // c1CommandLink6
            // 
            this.c1CommandLink6.Command = this.mnuWindow;
            this.c1CommandLink6.SortOrder = 3;
            // 
            // dockToolbar
            // 
            this.dockToolbar.Controls.Add(this.c1ToolBar1);
            this.dockToolbar.Id = 1;
            this.dockToolbar.Location = new System.Drawing.Point(0, 21);
            this.dockToolbar.Name = "dockToolbar";
            this.dockToolbar.Size = new System.Drawing.Size(760, 24);
            // 
            // c1ToolBar1
            // 
            this.c1ToolBar1.CommandHolder = this.c1CommandHolder1;
            this.c1ToolBar1.CommandLinks.AddRange(new C1.Win.Command.C1CommandLink[] {
            this.c1CommandLink2,
            this.c1CommandLink10,
            this.c1CommandLink12});
            this.c1ToolBar1.Location = new System.Drawing.Point(0, 0);
            this.c1ToolBar1.Name = "c1ToolBar1";
            this.c1ToolBar1.Size = new System.Drawing.Size(77, 24);
            this.c1ToolBar1.Text = "c1ToolBar1";
            // 
            // c1CommandLink2
            // 
            this.c1CommandLink2.Command = this.cmdFileNew;
            // 
            // c1CommandLink10
            // 
            this.c1CommandLink10.Command = this.cmdFileOpen;
            // 
            // c1CommandLink12
            // 
            this.c1CommandLink12.Command = this.cmdFileSave;
            // 
            // dockSidebar
            // 
            this.dockSidebar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.dockSidebar.Controls.Add(this.tabSidebar);
            this.dockSidebar.Dock = System.Windows.Forms.DockStyle.Right;
            this.dockSidebar.Id = 3;
            this.dockSidebar.Location = new System.Drawing.Point(592, 45);
            this.dockSidebar.Name = "dockSidebar";
            this.dockSidebar.Size = new System.Drawing.Size(168, 504);
            // 
            // tabSidebar
            // 
            this.tabSidebar.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabSidebar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tabSidebar.CanAutoHide = true;
            this.tabSidebar.CanCloseTabs = true;
            this.tabSidebar.CanMoveTabs = true;
            this.tabSidebar.Controls.Add(this.c1DockingTabPage2);
            this.tabSidebar.Controls.Add(this.c1DockingTabPage1);
            this.tabSidebar.Location = new System.Drawing.Point(0, 0);
            this.tabSidebar.Name = "tabSidebar";
            this.tabSidebar.ShowCaption = true;
            this.tabSidebar.Size = new System.Drawing.Size(168, 504);
            this.tabSidebar.TabIndex = 0;
            this.tabSidebar.TabSizeMode = C1.Win.Command.TabSizeModeEnum.Fit;
            this.tabSidebar.TabsSpacing = 0;
            // 
            // c1DockingTabPage2
            // 
            this.c1DockingTabPage2.Controls.Add(this.dirView);
            this.c1DockingTabPage2.Location = new System.Drawing.Point(3, 0);
            this.c1DockingTabPage2.Name = "c1DockingTabPage2";
            this.c1DockingTabPage2.Size = new System.Drawing.Size(165, 480);
            this.c1DockingTabPage2.TabIndex = 0;
            this.c1DockingTabPage2.Text = "Directory Listing";
            // 
            // dirView
            // 
            this.dirView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dirView.Filter = new string[] {
        "*.rtf",
        "*.txt"};
            this.dirView.ImageIndex = 0;
            this.dirView.Location = new System.Drawing.Point(0, 20);
            this.dirView.Name = "dirView";
            treeNode1.Name = "";
            treeNode1.Tag = ((object)(resources.GetObject("treeNode1.Tag")));
            treeNode1.Text = "...";
            treeNode2.ImageIndex = 0;
            treeNode2.Name = "";
            treeNode2.SelectedImageIndex = 4;
            treeNode2.Tag = ((object)(resources.GetObject("treeNode2.Tag")));
            treeNode2.Text = "A:";
            treeNode3.Name = "";
            treeNode3.Tag = ((object)(resources.GetObject("treeNode3.Tag")));
            treeNode3.Text = "...";
            treeNode4.ImageIndex = 0;
            treeNode4.Name = "";
            treeNode4.SelectedImageIndex = 4;
            treeNode4.Tag = ((object)(resources.GetObject("treeNode4.Tag")));
            treeNode4.Text = "C:";
            treeNode5.Name = "";
            treeNode5.Tag = ((object)(resources.GetObject("treeNode5.Tag")));
            treeNode5.Text = "...";
            treeNode6.ImageIndex = 0;
            treeNode6.Name = "";
            treeNode6.SelectedImageIndex = 4;
            treeNode6.Tag = ((object)(resources.GetObject("treeNode6.Tag")));
            treeNode6.Text = "D:";
            treeNode7.Name = "";
            treeNode7.Tag = ((object)(resources.GetObject("treeNode7.Tag")));
            treeNode7.Text = "...";
            treeNode8.ImageIndex = 0;
            treeNode8.Name = "";
            treeNode8.SelectedImageIndex = 4;
            treeNode8.Tag = ((object)(resources.GetObject("treeNode8.Tag")));
            treeNode8.Text = "E:";
            treeNode9.Name = "";
            treeNode9.Tag = ((object)(resources.GetObject("treeNode9.Tag")));
            treeNode9.Text = "...";
            treeNode10.ImageIndex = 0;
            treeNode10.Name = "";
            treeNode10.SelectedImageIndex = 4;
            treeNode10.Tag = ((object)(resources.GetObject("treeNode10.Tag")));
            treeNode10.Text = "F:";
            treeNode11.Name = "";
            treeNode11.Tag = ((object)(resources.GetObject("treeNode11.Tag")));
            treeNode11.Text = "...";
            treeNode12.ImageIndex = 0;
            treeNode12.Name = "";
            treeNode12.SelectedImageIndex = 4;
            treeNode12.Tag = ((object)(resources.GetObject("treeNode12.Tag")));
            treeNode12.Text = "G:";
            treeNode13.Name = "";
            treeNode13.Tag = ((object)(resources.GetObject("treeNode13.Tag")));
            treeNode13.Text = "...";
            treeNode14.ImageIndex = 0;
            treeNode14.Name = "";
            treeNode14.SelectedImageIndex = 4;
            treeNode14.Tag = ((object)(resources.GetObject("treeNode14.Tag")));
            treeNode14.Text = "U:";
            treeNode15.Name = "";
            treeNode15.Tag = ((object)(resources.GetObject("treeNode15.Tag")));
            treeNode15.Text = "...";
            treeNode16.ImageIndex = 0;
            treeNode16.Name = "";
            treeNode16.SelectedImageIndex = 4;
            treeNode16.Tag = ((object)(resources.GetObject("treeNode16.Tag")));
            treeNode16.Text = "W:";
            treeNode17.Name = "";
            treeNode17.Tag = ((object)(resources.GetObject("treeNode17.Tag")));
            treeNode17.Text = "...";
            treeNode18.ImageIndex = 0;
            treeNode18.Name = "";
            treeNode18.SelectedImageIndex = 4;
            treeNode18.Tag = ((object)(resources.GetObject("treeNode18.Tag")));
            treeNode18.Text = "X:";
            this.dirView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode4,
            treeNode6,
            treeNode8,
            treeNode10,
            treeNode12,
            treeNode14,
            treeNode16,
            treeNode18});
            this.dirView.SelectedImageIndex = 0;
            this.dirView.Size = new System.Drawing.Size(165, 460);
            this.dirView.TabIndex = 0;
            this.dirView.EditFile += new MdiTabs.DirView.EditFileEventHandler(this.dirView_EditFile);
            // 
            // c1DockingTabPage1
            // 
            this.c1DockingTabPage1.Controls.Add(this.listOpenFiles);
            this.c1DockingTabPage1.Location = new System.Drawing.Point(3, 0);
            this.c1DockingTabPage1.Name = "c1DockingTabPage1";
            this.c1DockingTabPage1.Size = new System.Drawing.Size(165, 480);
            this.c1DockingTabPage1.TabIndex = 1;
            this.c1DockingTabPage1.Text = "Open Files";
            // 
            // listOpenFiles
            // 
            this.listOpenFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listOpenFiles.Location = new System.Drawing.Point(0, 20);
            this.listOpenFiles.Name = "listOpenFiles";
            this.listOpenFiles.Size = new System.Drawing.Size(165, 459);
            this.listOpenFiles.TabIndex = 0;
            this.listOpenFiles.DoubleClick += new System.EventHandler(this.listOpenFiles_DoubleClick);
            // 
            // dockTray
            // 
            this.dockTray.BackColor = System.Drawing.SystemColors.Window;
            this.dockTray.Controls.Add(this.tabTray);
            this.dockTray.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dockTray.Id = 4;
            this.dockTray.Location = new System.Drawing.Point(0, 421);
            this.dockTray.Name = "dockTray";
            this.dockTray.Size = new System.Drawing.Size(592, 128);
            // 
            // tabTray
            // 
            this.tabTray.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabTray.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tabTray.CanAutoHide = true;
            this.tabTray.CanCloseTabs = true;
            this.tabTray.CanMoveTabs = true;
            this.tabTray.Controls.Add(this.c1DockingTabPage3);
            this.tabTray.Location = new System.Drawing.Point(0, 0);
            this.tabTray.Name = "tabTray";
            this.tabTray.ShowCaption = true;
            this.tabTray.Size = new System.Drawing.Size(592, 128);
            this.tabTray.TabIndex = 0;
            this.tabTray.TabSizeMode = C1.Win.Command.TabSizeModeEnum.Fit;
            this.tabTray.TabsSpacing = 0;
            // 
            // c1DockingTabPage3
            // 
            this.c1DockingTabPage3.Controls.Add(this.textLog);
            this.c1DockingTabPage3.Location = new System.Drawing.Point(0, 3);
            this.c1DockingTabPage3.Name = "c1DockingTabPage3";
            this.c1DockingTabPage3.Size = new System.Drawing.Size(592, 101);
            this.c1DockingTabPage3.TabIndex = 0;
            this.c1DockingTabPage3.Text = "Log";
            // 
            // textLog
            // 
            this.textLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textLog.Location = new System.Drawing.Point(0, 20);
            this.textLog.Multiline = true;
            this.textLog.Name = "textLog";
            this.textLog.ReadOnly = true;
            this.textLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textLog.Size = new System.Drawing.Size(592, 81);
            this.textLog.TabIndex = 0;
            // 
            // tabMain
            // 
            this.tabMain.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tabMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabMain.CanCloseTabs = true;
            this.tabMain.CanMoveTabs = true;
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 45);
            this.tabMain.Name = "tabMain";
            this.tabMain.Size = new System.Drawing.Size(592, 376);
            this.tabMain.TabIndex = 5;
            this.tabMain.TabsSpacing = 0;
            this.tabMain.VisualStyle = C1.Win.Command.VisualStyle.Custom;
            this.tabMain.TabPageClosed += new C1.Win.Command.TabPageEventHandler(this.tabMain_TabPageClosed);
            this.tabMain.SelectedIndexChanged += new System.EventHandler(this.tabMain_SelectedIndexChanged);
            this.tabMain.TabPageClosing += new C1.Win.Command.TabPageCancelEventHandler(this.tabMain_TabPageClosing);
            this.tabMain.DoubleClick += new System.EventHandler(this.tabMain_DoubleClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.CheckFileExists = false;
            this.openFileDialog1.Filter = "Rich text files|*.rtf|Text files|*.txt|All files|*.*";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Rich text files|*.rtf|Text files|*.txt|All files|*.*";
            // 
            // MainForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(760, 549);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.dockTray);
            this.Controls.Add(this.dockSidebar);
            this.Controls.Add(this.dockToolbar);
            this.Controls.Add(this.c1MainMenu1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockToolbar)).EndInit();
            this.dockToolbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dockSidebar)).EndInit();
            this.dockSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabSidebar)).EndInit();
            this.tabSidebar.ResumeLayout(false);
            this.c1DockingTabPage2.ResumeLayout(false);
            this.c1DockingTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dockTray)).EndInit();
            this.dockTray.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabTray)).EndInit();
            this.tabTray.ResumeLayout(false);
            this.c1DockingTabPage3.ResumeLayout(false);
            this.c1DockingTabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).EndInit();
            this.ResumeLayout(false);

        }
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new MainForm());
		}

        public SaveFileDialog SaveFileDialog { get { return this.saveFileDialog1; } }

        public void Log(string text)
        {
            this.textLog.Text += text;
            this.textLog.Text += "\r\n";
            this.textLog.SelectionStart = this.textLog.Text.Length;
            this.textLog.ScrollToCaret();
        }

        private void cmdExit_Click(object sender, C1.Win.Command.ClickEventArgs e)
        {
            this.Close();
        }

        private void NewEditor(string filename)
        {
            Editor ed = new Editor(this, filename);
            ed.TextBox.Dock = DockStyle.Fill;
            C1DockingTabPage page = new C1DockingTabPage();
            page.Controls.Add(ed.TextBox);
            page.Text = ed.FileName;
            // IMPORTANT! used for internal "plumbing"
            page.Tag = ed;
            this.tabMain.TabPages.Add(page);
            ShowEditor(ed);
            ListOpenFiles();
        }

        private void ShowEditor(Editor ed)
        {
            ed.TextBox.Parent.Show();
            ed.TextBox.Focus();
        }

        private void CloseEditor(Editor ed)
        {
            if (ed.Closing())
            {
                C1DockingTabPage page = ed.TextBox.Parent as C1DockingTabPage;
                System.Diagnostics.Debug.Assert(page != null);
                tabMain.TabPages.Remove(page);
                ListOpenFiles();
            }
        }

        private void cmdFileNew_Click(object sender, C1.Win.Command.ClickEventArgs e)
        {
            NewEditor(string.Empty);
        }

        private void cmdFileOpen_Click(object sender, C1.Win.Command.ClickEventArgs e)
        {
            try
            {
                if (this.openFileDialog1.ShowDialog(this) == DialogResult.OK)
                {
                    NewEditor(this.openFileDialog1.FileName);
                }
            }
            catch
            {
            }
        }

        private void tabMain_TabPageClosed(object sender, C1.Win.Command.TabPageEventArgs e)
        {
            // note: C1DockingTab automatically hides when all tabs are removed;
            // this code restores it
            if (!this.tabMain.Visible)
                this.tabMain.Show();
        }

        // our window menu will contain dynamic items (an entry for each open window)
        // in addition to static entries. We use UserData on commands to filter our
        // dynamically created commands
        private void mnuWindow_Popup(object sender, System.EventArgs e)
        {
            // delete old entries (we start at the bottom, and can not use foreach,
            // because we will be deleting entries from the list)
            for (int i = mnuWindow.CommandLinks.Count - 1; i >= 0; --i)
            {
                C1CommandLink cl = mnuWindow.CommandLinks[i];
                Editor ed = cl.Command.UserData as Editor;
                if (ed != null)
                {
                    c1CommandHolder1.Commands.Remove(cl.Command);
                    mnuWindow.CommandLinks.RemoveAt(i);
                }
            }
            // add new entries for all open windows
            bool first = true;
            foreach (C1DockingTabPage p in tabMain.TabPages)
            {
                C1Command cmd = new C1Command();
                cmd.Text = p.Text;
                cmd.UserData = p.Tag; // page.Tag is set by the Editor ctor
                if (p.Visible)
                    cmd.Checked = true;
                cmd.Click += new ClickEventHandler(WindowSelectHandler);
                C1CommandLink cl = new C1CommandLink(cmd);
                if (first)
                {
                    cl.Delimiter = true;
                    first = false;
                }
                mnuWindow.CommandLinks.Add(cl);
            }
        }

        private void WindowSelectHandler(object sender, C1.Win.Command.ClickEventArgs e)
        {
            ShowEditor(e.CallerLink.Command.UserData as Editor);
        }

        private void cmdWindowCloseAll_Click(object sender, C1.Win.Command.ClickEventArgs e)
        {
            for (int i = tabMain.TabPages.Count - 1; i >= 0; --i)
                CloseEditor((Editor)tabMain.TabPages[i].Tag);
        }

        private void tabMain_TabPageClosing(object sender, C1.Win.Command.TabPageCancelEventArgs e)
        {
            if (!((Editor)e.TabPage.Tag).Closing())
                e.Cancel = true;
        }

        private void tabMain_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            // todo
        }

        private Editor SelectedEditor()
        {
            if (tabMain.SelectedTab == null)
                return null;
            return tabMain.SelectedTab.Tag as Editor;
        }

        private void tabMain_DoubleClick(object sender, System.EventArgs e)
        {
            Editor ed = SelectedEditor();
            if (ed != null)
                // like some apps, close tab on double click
                CloseEditor(ed);
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
        }

        private void dirView_EditFile(object sender, MdiTabs.DirView.EditFileEventArgs e)
        {
            try
            {
                NewEditor(e.Path);
            }
            catch (Exception ex)
            {
                textLog.Text += "\n" + ex.ToString();
            }
        }

        private void ListOpenFiles()
        {
            listOpenFiles.Items.Clear();
            foreach (C1DockingTabPage p in tabMain.TabPages)
                listOpenFiles.Items.Add(p.Text);
        }

        private void listOpenFiles_DoubleClick(object sender, System.EventArgs e)
        {
            C1DockingTabPage page = tabMain.TabPages[listOpenFiles.SelectedIndex];
            Editor ed = page == null ? null : page.Tag as Editor;
            ShowEditor(ed);
        }

        private void cmdFileSave_CommandStateQuery(object sender, C1.Win.Command.CommandStateQueryEventArgs e)
        {
            Editor ed = SelectedEditor();
            e.Enabled = ed != null && ed.Dirty;
        }

        private void cmdFileSave_Click(object sender, C1.Win.Command.ClickEventArgs e)
        {
            Editor ed = SelectedEditor();
            if (ed != null)
                ed.Save();
        }

        private void cmdWindowCloseAll_CommandStateQuery(object sender, C1.Win.Command.CommandStateQueryEventArgs e)
        {
            e.Enabled = tabMain.TabPages.Count > 0;
        }

        private void c1CommandVS2005_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            SetDockingStyle(e.NewValue);
        }

        private void SetDockingStyle(bool value)
        {
            dockSidebar.DockingStyle = value ? DockingStyle.VS2005 : DockingStyle.Default;
            // the same
            dockTray.DockingStyle = dockSidebar.DockingStyle;
        }
	}
}










