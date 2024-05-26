using C1.Win.Command;

namespace CommandExplorer.Samples
{
    public partial class RadialMenuOverview
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            radialMenuItem1 = new RadialMenuItem();
            rmiCheckOnOff = new RadialMenuItem();
            radialMenuItem3 = new RadialMenuItem();
            radialMenuItem2 = new RadialMenuItem();
            radialMenuItem11 = new RadialMenuItem();
            radialMenuItem12 = new RadialMenuItem();
            radialMenuItem13 = new RadialMenuItem();
            radialMenuItem14 = new RadialMenuItem();
            radialMenuItem15 = new RadialMenuItem();
            radialMenuItem4 = new RadialMenuItem();
            radialMenuItem7 = new RadialMenuItem();
            radialMenuItem8 = new RadialMenuItem();
            radialMenuItem9 = new RadialMenuItem();
            radialMenuItem10 = new RadialMenuItem();
            radialMenuItem5 = new RadialMenuItem();
            radialMenuItem6 = new RadialMenuItem();
            radialMenuItem16 = new RadialMenuItem();
            radialMenuItem17 = new RadialMenuItem();
            radialMenuItem18 = new RadialMenuItem();
            radialMenuItem19 = new RadialMenuItem();
            radialMenuItem20 = new RadialMenuItem();
            radialMenuItem21 = new RadialMenuItem();
            groupBox1 = new System.Windows.Forms.GroupBox();
            chkAutoHide = new System.Windows.Forms.CheckBox();
            chkAnimateMenu = new System.Windows.Forms.CheckBox();
            chkShowExpanded = new System.Windows.Forms.CheckBox();
            chkShowOnMouseDown = new System.Windows.Forms.CheckBox();
            btnHideMenu = new System.Windows.Forms.Button();
            btnShowMenu = new System.Windows.Forms.Button();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            panel1 = new System.Windows.Forms.Panel();
            rmiEEC = new RadialMenuItem();
            rmiBelgium = new RadialMenuItem();
            rmiFrance = new RadialMenuItem();
            rmiGermany = new RadialMenuItem();
            rmiItaly = new RadialMenuItem();
            rmiLuxembourg = new RadialMenuItem();
            rmiNetherlands = new RadialMenuItem();
            rmiNorthAmerica = new RadialMenuItem();
            rmiCanada = new RadialMenuItem();
            rmiUSA = new RadialMenuItem();
            rmiMexico = new RadialMenuItem();
            radialMenuItem22 = new RadialMenuItem();
            radialMenuItem23 = new RadialMenuItem();
            rmiProducts = new RadialMenuItem();
            rmiStuUlt = new RadialMenuItem();
            rmiStuEnt = new RadialMenuItem();
            rmiStuPower = new RadialMenuItem();
            rmiStuWinForms = new RadialMenuItem();
            rmiStuWPF = new RadialMenuItem();
            rmiStuWijmo = new RadialMenuItem();
            rmiDocs = new RadialMenuItem();
            rmiSamples = new RadialMenuItem();
            rmiDemos = new RadialMenuItem();
            rmiVideos = new RadialMenuItem();
            radialMenuItem25 = new RadialMenuItem();
            radialMenuItem26 = new RadialMenuItem();
            rmiLocale = new RadialMenuItem();
            rmiUS = new RadialMenuItem();
            rmiChina = new RadialMenuItem();
            rmiJapan = new RadialMenuItem();
            rmiIndia = new RadialMenuItem();
            rmiSouthKorea = new RadialMenuItem();
            rmiCheck = new RadialMenuItem();
            rmiHelp = new RadialMenuItem();
            rmiStore = new RadialMenuItem();
            radialMenuItem24 = new RadialMenuItem();
            c1RmC1 = new C1RadialMenu();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // radialMenuItem1
            // 
            radialMenuItem1.Name = "radialMenuItem1";
            radialMenuItem1.Text = "Item 1";
            radialMenuItem1.ToolTip = "Tooltip for item 1";
            // 
            // rmiCheckOnOff
            // 
            rmiCheckOnOff.Checked = true;
            rmiCheckOnOff.Name = "rmiCheckOnOff";
            rmiCheckOnOff.Text = "Check ON";
            rmiCheckOnOff.ToolTip = "A checked item";
            rmiCheckOnOff.UserData = "check";
            // 
            // radialMenuItem3
            // 
            radialMenuItem3.Items.Add(radialMenuItem2);
            radialMenuItem3.Items.Add(radialMenuItem11);
            radialMenuItem3.Items.Add(radialMenuItem12);
            radialMenuItem3.Items.Add(radialMenuItem13);
            radialMenuItem3.Items.Add(radialMenuItem14);
            radialMenuItem3.Items.Add(radialMenuItem15);
            radialMenuItem3.Name = "radialMenuItem3";
            radialMenuItem3.Text = "Submenu 1";
            radialMenuItem3.ToolTip = "Opens a submenu";
            // 
            // radialMenuItem2
            // 
            radialMenuItem2.Name = "radialMenuItem2";
            // 
            // radialMenuItem11
            // 
            radialMenuItem11.Name = "radialMenuItem11";
            // 
            // radialMenuItem12
            // 
            radialMenuItem12.Name = "radialMenuItem12";
            // 
            // radialMenuItem13
            // 
            radialMenuItem13.Name = "radialMenuItem13";
            // 
            // radialMenuItem14
            // 
            radialMenuItem14.Name = "radialMenuItem14";
            // 
            // radialMenuItem15
            // 
            radialMenuItem15.Name = "radialMenuItem15";
            // 
            // radialMenuItem4
            // 
            radialMenuItem4.Items.Add(radialMenuItem7);
            radialMenuItem4.Items.Add(radialMenuItem8);
            radialMenuItem4.Items.Add(radialMenuItem9);
            radialMenuItem4.Items.Add(radialMenuItem10);
            radialMenuItem4.Name = "radialMenuItem4";
            radialMenuItem4.Text = "Submenu 2";
            radialMenuItem4.ToolTip = "Opens a submenu";
            // 
            // radialMenuItem7
            // 
            radialMenuItem7.Name = "radialMenuItem7";
            radialMenuItem7.Text = "Nested 1";
            // 
            // radialMenuItem8
            // 
            radialMenuItem8.Name = "radialMenuItem8";
            radialMenuItem8.Text = "Nested 2";
            // 
            // radialMenuItem9
            // 
            radialMenuItem9.Name = "radialMenuItem9";
            radialMenuItem9.Text = "Nested 3";
            // 
            // radialMenuItem10
            // 
            radialMenuItem10.Name = "radialMenuItem10";
            radialMenuItem10.Text = "Nested 4";
            // 
            // radialMenuItem5
            // 
            radialMenuItem5.Name = "radialMenuItem5";
            radialMenuItem5.Text = "Item 5";
            radialMenuItem5.ToolTip = "Tooltip for item 5";
            // 
            // radialMenuItem6
            // 
            radialMenuItem6.BackColor = System.Drawing.Color.FromArgb(255, 224, 192);
            radialMenuItem6.Items.Add(radialMenuItem16);
            radialMenuItem6.Items.Add(radialMenuItem17);
            radialMenuItem6.Items.Add(radialMenuItem18);
            radialMenuItem6.Items.Add(radialMenuItem19);
            radialMenuItem6.Items.Add(radialMenuItem20);
            radialMenuItem6.Items.Add(radialMenuItem21);
            radialMenuItem6.Name = "radialMenuItem6";
            radialMenuItem6.Text = "Submenu 3";
            radialMenuItem6.ToolTip = "Tooltip for item 6";
            // 
            // radialMenuItem16
            // 
            radialMenuItem16.Name = "radialMenuItem16";
            // 
            // radialMenuItem17
            // 
            radialMenuItem17.Name = "radialMenuItem17";
            // 
            // radialMenuItem18
            // 
            radialMenuItem18.Name = "radialMenuItem18";
            // 
            // radialMenuItem19
            // 
            radialMenuItem19.Name = "radialMenuItem19";
            // 
            // radialMenuItem20
            // 
            radialMenuItem20.Name = "radialMenuItem20";
            // 
            // radialMenuItem21
            // 
            radialMenuItem21.Name = "radialMenuItem21";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            groupBox1.Controls.Add(chkAutoHide);
            groupBox1.Controls.Add(chkAnimateMenu);
            groupBox1.Controls.Add(chkShowExpanded);
            groupBox1.Controls.Add(chkShowOnMouseDown);
            groupBox1.Controls.Add(btnHideMenu);
            groupBox1.Controls.Add(btnShowMenu);
            groupBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            groupBox1.Location = new System.Drawing.Point(635, 5);
            groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            groupBox1.Size = new System.Drawing.Size(337, 395);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Menu Control";
            // 
            // chkAutoHide
            // 
            chkAutoHide.AutoSize = true;
            chkAutoHide.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(192, 0, 0);
            chkAutoHide.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(192, 64, 0);
            chkAutoHide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(192, 64, 0);
            chkAutoHide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(255, 128, 0);
            chkAutoHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            chkAutoHide.Location = new System.Drawing.Point(8, 246);
            chkAutoHide.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            chkAutoHide.Name = "chkAutoHide";
            chkAutoHide.Size = new System.Drawing.Size(135, 24);
            chkAutoHide.TabIndex = 5;
            chkAutoHide.Text = "Auto-hide menu";
            chkAutoHide.UseVisualStyleBackColor = true;
            chkAutoHide.CheckedChanged += chkAutoHide_CheckedChanged;
            // 
            // chkAnimateMenu
            // 
            chkAnimateMenu.AutoSize = true;
            chkAnimateMenu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(192, 0, 0);
            chkAnimateMenu.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(192, 64, 0);
            chkAnimateMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(192, 64, 0);
            chkAnimateMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(255, 128, 0);
            chkAnimateMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            chkAnimateMenu.Location = new System.Drawing.Point(8, 211);
            chkAnimateMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            chkAnimateMenu.Name = "chkAnimateMenu";
            chkAnimateMenu.Size = new System.Drawing.Size(124, 24);
            chkAnimateMenu.TabIndex = 4;
            chkAnimateMenu.Text = "Animate menu";
            chkAnimateMenu.UseVisualStyleBackColor = true;
            chkAnimateMenu.CheckedChanged += chkAnimateMenu_CheckedChanged;
            // 
            // chkShowExpanded
            // 
            chkShowExpanded.AutoSize = true;
            chkShowExpanded.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(192, 0, 0);
            chkShowExpanded.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(192, 64, 0);
            chkShowExpanded.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(192, 64, 0);
            chkShowExpanded.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(255, 128, 0);
            chkShowExpanded.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            chkShowExpanded.Location = new System.Drawing.Point(8, 175);
            chkShowExpanded.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            chkShowExpanded.Name = "chkShowExpanded";
            chkShowExpanded.Size = new System.Drawing.Size(176, 24);
            chkShowExpanded.TabIndex = 3;
            chkShowExpanded.Text = "Expand menu on show";
            chkShowExpanded.UseVisualStyleBackColor = true;
            // 
            // chkShowOnMouseDown
            // 
            chkShowOnMouseDown.AutoSize = true;
            chkShowOnMouseDown.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(192, 0, 0);
            chkShowOnMouseDown.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(192, 64, 0);
            chkShowOnMouseDown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(192, 64, 0);
            chkShowOnMouseDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(255, 128, 0);
            chkShowOnMouseDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            chkShowOnMouseDown.Location = new System.Drawing.Point(8, 140);
            chkShowOnMouseDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            chkShowOnMouseDown.Name = "chkShowOnMouseDown";
            chkShowOnMouseDown.Size = new System.Drawing.Size(206, 24);
            chkShowOnMouseDown.TabIndex = 2;
            chkShowOnMouseDown.Text = "Show menu on mouse click";
            chkShowOnMouseDown.UseVisualStyleBackColor = true;
            // 
            // btnHideMenu
            // 
            btnHideMenu.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            btnHideMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            btnHideMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            btnHideMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnHideMenu.Location = new System.Drawing.Point(8, 85);
            btnHideMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnHideMenu.Name = "btnHideMenu";
            btnHideMenu.Size = new System.Drawing.Size(317, 46);
            btnHideMenu.TabIndex = 1;
            btnHideMenu.Text = "Hide menu";
            btnHideMenu.UseVisualStyleBackColor = true;
            btnHideMenu.Click += btnHideMenu_Click;
            // 
            // btnShowMenu
            // 
            btnShowMenu.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            btnShowMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            btnShowMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            btnShowMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnShowMenu.Location = new System.Drawing.Point(8, 29);
            btnShowMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnShowMenu.Name = "btnShowMenu";
            btnShowMenu.Size = new System.Drawing.Size(317, 46);
            btnShowMenu.TabIndex = 0;
            btnShowMenu.Text = "Show menu in the center of the panel";
            btnShowMenu.UseVisualStyleBackColor = true;
            btnShowMenu.Click += btnShowMenu_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = System.Drawing.Color.Gray;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel1.Controls.Add(groupBox1, 1, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new System.Drawing.Size(976, 748);
            tableLayoutPanel1.TabIndex = 3;
            tableLayoutPanel1.LocationChanged += UpdateMenuPositionEventHandler;
            tableLayoutPanel1.SizeChanged += UpdateMenuPositionEventHandler;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.SystemColors.Control;
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(4, 5);
            panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(623, 738);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // rmiEEC
            // 
            rmiEEC.Image = Properties.Resources.flag_eu;
            rmiEEC.Items.Add(rmiBelgium);
            rmiEEC.Items.Add(rmiFrance);
            rmiEEC.Items.Add(rmiGermany);
            rmiEEC.Items.Add(rmiItaly);
            rmiEEC.Items.Add(rmiLuxembourg);
            rmiEEC.Items.Add(rmiNetherlands);
            rmiEEC.Name = "rmiEEC";
            rmiEEC.Text = "EEC";
            rmiEEC.ToolTip = "European Economic Community (1957)";
            // 
            // rmiBelgium
            // 
            rmiBelgium.Image = Properties.Resources.flag_belgium;
            rmiBelgium.Name = "rmiBelgium";
            rmiBelgium.Text = "Belgium";
            // 
            // rmiFrance
            // 
            rmiFrance.Image = Properties.Resources.flag_france;
            rmiFrance.Name = "rmiFrance";
            rmiFrance.Text = "France";
            // 
            // rmiGermany
            // 
            rmiGermany.Image = Properties.Resources.flag_germany;
            rmiGermany.Name = "rmiGermany";
            rmiGermany.Text = "Germany";
            // 
            // rmiItaly
            // 
            rmiItaly.Image = Properties.Resources.flag_italy;
            rmiItaly.Name = "rmiItaly";
            rmiItaly.Text = "Italy";
            // 
            // rmiLuxembourg
            // 
            rmiLuxembourg.Image = Properties.Resources.flag_luxembourg;
            rmiLuxembourg.Name = "rmiLuxembourg";
            rmiLuxembourg.Text = "Luxembourg";
            // 
            // rmiNetherlands
            // 
            rmiNetherlands.Image = Properties.Resources.flag_netherlands;
            rmiNetherlands.Name = "rmiNetherlands";
            rmiNetherlands.Text = "Netherlands";
            // 
            // rmiNorthAmerica
            // 
            rmiNorthAmerica.Items.Add(rmiCanada);
            rmiNorthAmerica.Items.Add(rmiUSA);
            rmiNorthAmerica.Items.Add(rmiMexico);
            rmiNorthAmerica.Name = "rmiNorthAmerica";
            rmiNorthAmerica.Text = "North America";
            // 
            // rmiCanada
            // 
            rmiCanada.Image = Properties.Resources.flag_canada;
            rmiCanada.Name = "rmiCanada";
            rmiCanada.Text = "Canada";
            // 
            // rmiUSA
            // 
            rmiUSA.Image = Properties.Resources.flag_usa;
            rmiUSA.Name = "rmiUSA";
            rmiUSA.Text = "USA";
            // 
            // rmiMexico
            // 
            rmiMexico.Image = Properties.Resources.flag_mexico;
            rmiMexico.Name = "rmiMexico";
            rmiMexico.Text = "Mexico";
            // 
            // radialMenuItem22
            // 
            radialMenuItem22.Enabled = false;
            radialMenuItem22.Name = "radialMenuItem22";
            radialMenuItem22.ToolTip = "Disabled item";
            // 
            // radialMenuItem23
            // 
            radialMenuItem23.Enabled = false;
            radialMenuItem23.Name = "radialMenuItem23";
            radialMenuItem23.ToolTip = "Disabled item";
            // 
            // rmiProducts
            // 
            rmiProducts.Items.Add(rmiStuUlt);
            rmiProducts.Items.Add(rmiStuEnt);
            rmiProducts.Items.Add(rmiStuPower);
            rmiProducts.Items.Add(rmiStuWinForms);
            rmiProducts.Items.Add(rmiStuWPF);
            rmiProducts.Items.Add(rmiStuWijmo);
            rmiProducts.Name = "rmiProducts";
            rmiProducts.Text = "Products";
            // 
            // rmiStuUlt
            // 
            rmiStuUlt.Image = Properties.Resources.ultLogo_32;
            rmiStuUlt.Name = "rmiStuUlt";
            rmiStuUlt.ToolTip = "Studio Ultimate";
            // 
            // rmiStuEnt
            // 
            rmiStuEnt.Image = Properties.Resources.seLogo_32;
            rmiStuEnt.Name = "rmiStuEnt";
            rmiStuEnt.ToolTip = "Studio Enterprise";
            // 
            // rmiStuPower
            // 
            rmiStuPower.Image = Properties.Resources.c1powersuite_logo_32;
            rmiStuPower.Name = "rmiStuPower";
            rmiStuPower.ToolTip = "Enterprise-ready reporting and spreadsheets controls for .NET applications. ";
            // 
            // rmiStuWinForms
            // 
            rmiStuWinForms.Image = Properties.Resources.winformsLogo_321;
            rmiStuWinForms.Name = "rmiStuWinForms";
            rmiStuWinForms.ToolTip = "Studio for WinForms";
            // 
            // rmiStuWPF
            // 
            rmiStuWPF.Image = Properties.Resources.wpfLogo_32;
            rmiStuWPF.Name = "rmiStuWPF";
            rmiStuWPF.ToolTip = "Studio for WPF";
            // 
            // rmiStuWijmo
            // 
            rmiStuWijmo.Image = Properties.Resources.aspLogo_32;
            rmiStuWijmo.Name = "rmiStuWijmo";
            rmiStuWijmo.ToolTip = "Studio for ASP.NET Wijmo";
            // 
            // rmiDocs
            // 
            rmiDocs.Name = "rmiDocs";
            rmiDocs.Text = "Documents";
            // 
            // rmiSamples
            // 
            rmiSamples.Name = "rmiSamples";
            rmiSamples.Text = "Samples";
            // 
            // rmiDemos
            // 
            rmiDemos.Name = "rmiDemos";
            rmiDemos.Text = "Demos";
            // 
            // rmiVideos
            // 
            rmiVideos.Name = "rmiVideos";
            rmiVideos.Text = "Videos";
            // 
            // radialMenuItem25
            // 
            radialMenuItem25.Name = "radialMenuItem25";
            // 
            // radialMenuItem26
            // 
            radialMenuItem26.Name = "radialMenuItem26";
            // 
            // rmiLocale
            // 
            rmiLocale.Image = Properties.Resources.flag_generic;
            rmiLocale.Items.Add(rmiUS);
            rmiLocale.Items.Add(radialMenuItem22);
            rmiLocale.Items.Add(rmiChina);
            rmiLocale.Items.Add(rmiJapan);
            rmiLocale.Items.Add(rmiIndia);
            rmiLocale.Items.Add(rmiSouthKorea);
            rmiLocale.Items.Add(radialMenuItem23);
            rmiLocale.Name = "rmiLocale";
            rmiLocale.Text = "Locations";
            rmiLocale.ToolTip = "International and local C1 sites";
            // 
            // rmiUS
            // 
            rmiUS.Image = Properties.Resources.flag_usa;
            rmiUS.Name = "rmiUS";
            rmiUS.ToolTip = "USA and International\r\n(click to select)";
            rmiUS.UserData = "locale";
            // 
            // rmiChina
            // 
            rmiChina.Image = Properties.Resources.flag_china;
            rmiChina.Name = "rmiChina";
            rmiChina.ToolTip = "China\r\n(click to select)";
            rmiChina.UserData = "locale";
            // 
            // rmiJapan
            // 
            rmiJapan.Image = Properties.Resources.flag_japan;
            rmiJapan.Name = "rmiJapan";
            rmiJapan.ToolTip = "Japan\r\n(click to select)";
            rmiJapan.UserData = "locale";
            // 
            // rmiIndia
            // 
            rmiIndia.Image = Properties.Resources.flag_india;
            rmiIndia.Name = "rmiIndia";
            rmiIndia.ToolTip = "India\r\n(click to select)";
            rmiIndia.UserData = "locale";
            // 
            // rmiSouthKorea
            // 
            rmiSouthKorea.Image = Properties.Resources.flag_south_korea;
            rmiSouthKorea.Name = "rmiSouthKorea";
            rmiSouthKorea.ToolTip = "South Korea\r\n(click to select)";
            rmiSouthKorea.UserData = "locale";
            // 
            // rmiCheck
            // 
            rmiCheck.Checked = true;
            rmiCheck.Image = Properties.Resources.bullet_ball_glass_red;
            rmiCheck.Name = "rmiCheck";
            rmiCheck.Text = "ON";
            rmiCheck.UserData = "check";
            // 
            // rmiHelp
            // 
            rmiHelp.Image = Properties.Resources.Help;
            rmiHelp.Items.Add(rmiDocs);
            rmiHelp.Items.Add(rmiSamples);
            rmiHelp.Items.Add(rmiDemos);
            rmiHelp.Items.Add(rmiVideos);
            rmiHelp.Name = "rmiHelp";
            rmiHelp.Text = "Help";
            rmiHelp.ToolTip = "Get help\r\n(NOTE: clickable item with a sub-menu)";
            rmiHelp.Click += rmiHelp_Click;
            // 
            // rmiStore
            // 
            rmiStore.Enabled = false;
            rmiStore.Image = Properties.Resources.shoppingcart_full1;
            rmiStore.Items.Add(radialMenuItem25);
            rmiStore.Items.Add(radialMenuItem26);
            rmiStore.Name = "rmiStore";
            rmiStore.Text = "Shop";
            rmiStore.ToolTip = "Shop C1 (disabled sub-menu)";
            // 
            // radialMenuItem24
            // 
            radialMenuItem24.Enabled = false;
            radialMenuItem24.Image = Properties.Resources.bullet_ball_glass_grey;
            radialMenuItem24.Name = "radialMenuItem24";
            radialMenuItem24.Text = "Disabled";
            radialMenuItem24.ToolTip = "Disabled item";
            // 
            // c1RmC1
            // 
            c1RmC1.Image = Properties.Resources.c1r;
            c1RmC1.Items.Add(rmiLocale);
            c1RmC1.Items.Add(rmiProducts);
            c1RmC1.Items.Add(rmiCheck);
            c1RmC1.Items.Add(rmiHelp);
            c1RmC1.Items.Add(rmiStore);
            c1RmC1.Items.Add(radialMenuItem24);
            c1RmC1.ItemClick += RadialMenu_ItemClick;
            _activeRadialMenu = c1RmC1;
            // 
            // RadialMenu
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(976, 748);
            Controls.Add(tableLayoutPanel1);
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "RadialMenu";
            Text = "Overview";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private RadialMenuItem radialMenuItem1;
        private RadialMenuItem rmiCheckOnOff;
        private RadialMenuItem radialMenuItem3;
        private RadialMenuItem radialMenuItem4;
        private RadialMenuItem radialMenuItem5;
        private RadialMenuItem radialMenuItem6;
        private RadialMenuItem radialMenuItem7;
        private RadialMenuItem radialMenuItem8;
        private RadialMenuItem radialMenuItem9;
        private RadialMenuItem radialMenuItem10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private RadialMenuItem radialMenuItem2;
        private RadialMenuItem radialMenuItem11;
        private RadialMenuItem radialMenuItem12;
        private RadialMenuItem radialMenuItem13;
        private RadialMenuItem radialMenuItem14;
        private RadialMenuItem radialMenuItem15;
        private RadialMenuItem radialMenuItem16;
        private RadialMenuItem radialMenuItem17;
        private RadialMenuItem radialMenuItem18;
        private RadialMenuItem radialMenuItem19;
        private RadialMenuItem radialMenuItem20;
        private RadialMenuItem radialMenuItem21;
        private RadialMenuItem rmiEEC;
        private RadialMenuItem rmiBelgium;
        private RadialMenuItem rmiFrance;
        private RadialMenuItem rmiGermany;
        private RadialMenuItem rmiItaly;
        private RadialMenuItem rmiLuxembourg;
        private RadialMenuItem rmiNetherlands;
        private RadialMenuItem rmiNorthAmerica;
        private RadialMenuItem rmiCanada;
        private RadialMenuItem rmiUSA;
        private RadialMenuItem rmiMexico;
        private C1RadialMenu c1RmC1;
        private RadialMenuItem rmiLocale;
        private RadialMenuItem rmiProducts;
        private RadialMenuItem rmiCheck;
        private RadialMenuItem rmiHelp;
        private RadialMenuItem rmiStore;
        private RadialMenuItem rmiUS;
        private RadialMenuItem rmiChina;
        private RadialMenuItem rmiJapan;
        private RadialMenuItem rmiIndia;
        private RadialMenuItem rmiSouthKorea;
        private RadialMenuItem rmiStuUlt;
        private RadialMenuItem rmiStuEnt;
        private RadialMenuItem rmiStuPower;
        private RadialMenuItem rmiStuWinForms;
        private RadialMenuItem rmiStuWPF;
        private RadialMenuItem rmiStuWijmo;
        private RadialMenuItem radialMenuItem22;
        private RadialMenuItem radialMenuItem23;
        private RadialMenuItem radialMenuItem24;
        private RadialMenuItem radialMenuItem25;
        private RadialMenuItem radialMenuItem26;
        private RadialMenuItem rmiDocs;
        private RadialMenuItem rmiSamples;
        private RadialMenuItem rmiDemos;
        private RadialMenuItem rmiVideos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnShowMenu;
        private System.Windows.Forms.Button btnHideMenu;
        private System.Windows.Forms.CheckBox chkShowOnMouseDown;
        private System.Windows.Forms.CheckBox chkShowExpanded;
        private System.Windows.Forms.CheckBox chkAnimateMenu;
        private System.Windows.Forms.CheckBox chkAutoHide;
    }
}