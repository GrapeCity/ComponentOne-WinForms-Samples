namespace SparklineSamples
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.c1Sparkline1 = new C1.Win.Sparkline.C1Sparkline();
            this.tlpSeeItInAction = new System.Windows.Forms.TableLayoutPanel();
            this.lblSparklineType = new System.Windows.Forms.Label();
            this.cbxSparklineType = new System.Windows.Forms.ComboBox();
            this.chbxDisplayXAxisAction = new System.Windows.Forms.CheckBox();
            this.btnNewData = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.c1Sparkline2 = new C1.Win.Sparkline.C1Sparkline();
            this.tlpAppearanceOptions = new System.Windows.Forms.TableLayoutPanel();
            this.lblAppearanceSparklineType = new System.Windows.Forms.Label();
            this.lblMarksColor = new System.Windows.Forms.Label();
            this.lblHighMarkColor = new System.Windows.Forms.Label();
            this.lblSeriesColor = new System.Windows.Forms.Label();
            this.lblFirstMarkColor = new System.Windows.Forms.Label();
            this.lblLowMarkColor = new System.Windows.Forms.Label();
            this.lblAxisColor = new System.Windows.Forms.Label();
            this.lblLastMarkColor = new System.Windows.Forms.Label();
            this.lblNegativeColor = new System.Windows.Forms.Label();
            this.cbxAppearanceSparkLineType = new System.Windows.Forms.ComboBox();
            this.cbxMarksColor = new System.Windows.Forms.ComboBox();
            this.cbxHighMarksColor = new System.Windows.Forms.ComboBox();
            this.cbxSeriesColor = new System.Windows.Forms.ComboBox();
            this.cbxFirstMarkColor = new System.Windows.Forms.ComboBox();
            this.cbxLowMarkColor = new System.Windows.Forms.ComboBox();
            this.cbxAxisColor = new System.Windows.Forms.ComboBox();
            this.cbxLastMarkColor = new System.Windows.Forms.ComboBox();
            this.cbxNegativeColor = new System.Windows.Forms.ComboBox();
            this.tlpAppearanceCheckboxes = new System.Windows.Forms.TableLayoutPanel();
            this.chbxShowNegative = new System.Windows.Forms.CheckBox();
            this.chbxShowLow = new System.Windows.Forms.CheckBox();
            this.chbxShowHigh = new System.Windows.Forms.CheckBox();
            this.chbxShowLast = new System.Windows.Forms.CheckBox();
            this.chbxShowFirst = new System.Windows.Forms.CheckBox();
            this.chbxDisplayXAxisAppearance = new System.Windows.Forms.CheckBox();
            this.chbxShowMarks = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.fxgRegionSales = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.tabMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tlpSeeItInAction.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tlpAppearanceOptions.SuspendLayout();
            this.tlpAppearanceCheckboxes.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fxgRegionSales)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabPage1);
            this.tabMain.Controls.Add(this.tabPage2);
            this.tabMain.Controls.Add(this.tabPage3);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1120, 606);
            this.tabMain.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.c1Sparkline1);
            this.tabPage1.Controls.Add(this.tlpSeeItInAction);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(1112, 576);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "See it in action";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // c1Sparkline1
            // 
            this.c1Sparkline1.BackColor = System.Drawing.SystemColors.Window;
            this.c1Sparkline1.Location = new System.Drawing.Point(256, 218);
            this.c1Sparkline1.Name = "c1Sparkline1";
            this.c1Sparkline1.Size = new System.Drawing.Size(600, 350);
            this.c1Sparkline1.TabIndex = 1;
            this.c1Sparkline1.Text = "c1Sparkline1";
            // 
            // tlpSeeItInAction
            // 
            this.tlpSeeItInAction.ColumnCount = 4;
            this.tlpSeeItInAction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpSeeItInAction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSeeItInAction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpSeeItInAction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpSeeItInAction.Controls.Add(this.lblSparklineType, 0, 0);
            this.tlpSeeItInAction.Controls.Add(this.cbxSparklineType, 1, 0);
            this.tlpSeeItInAction.Controls.Add(this.chbxDisplayXAxisAction, 2, 0);
            this.tlpSeeItInAction.Controls.Add(this.btnNewData, 3, 0);
            this.tlpSeeItInAction.Location = new System.Drawing.Point(28, 28);
            this.tlpSeeItInAction.Name = "tlpSeeItInAction";
            this.tlpSeeItInAction.RowCount = 1;
            this.tlpSeeItInAction.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSeeItInAction.Size = new System.Drawing.Size(664, 50);
            this.tlpSeeItInAction.TabIndex = 0;
            // 
            // lblSparklineType
            // 
            this.lblSparklineType.AutoSize = true;
            this.lblSparklineType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSparklineType.Location = new System.Drawing.Point(10, 10);
            this.lblSparklineType.Margin = new System.Windows.Forms.Padding(10);
            this.lblSparklineType.Name = "lblSparklineType";
            this.lblSparklineType.Size = new System.Drawing.Size(107, 30);
            this.lblSparklineType.TabIndex = 0;
            this.lblSparklineType.Text = "Sparkline Type:";
            this.lblSparklineType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbxSparklineType
            // 
            this.cbxSparklineType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxSparklineType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSparklineType.FormattingEnabled = true;
            this.cbxSparklineType.Location = new System.Drawing.Point(137, 10);
            this.cbxSparklineType.Margin = new System.Windows.Forms.Padding(10);
            this.cbxSparklineType.Name = "cbxSparklineType";
            this.cbxSparklineType.Size = new System.Drawing.Size(254, 25);
            this.cbxSparklineType.TabIndex = 1;
            this.cbxSparklineType.SelectedIndexChanged += new System.EventHandler(this.cbxSparklineType_SelectedIndexChanged);
            // 
            // chbxDisplayXAxisAction
            // 
            this.chbxDisplayXAxisAction.AutoSize = true;
            this.chbxDisplayXAxisAction.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chbxDisplayXAxisAction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chbxDisplayXAxisAction.Location = new System.Drawing.Point(411, 10);
            this.chbxDisplayXAxisAction.Margin = new System.Windows.Forms.Padding(10);
            this.chbxDisplayXAxisAction.Name = "chbxDisplayXAxisAction";
            this.chbxDisplayXAxisAction.Size = new System.Drawing.Size(115, 30);
            this.chbxDisplayXAxisAction.TabIndex = 2;
            this.chbxDisplayXAxisAction.Text = "Display X Axis";
            this.chbxDisplayXAxisAction.UseVisualStyleBackColor = true;
            this.chbxDisplayXAxisAction.CheckedChanged += new System.EventHandler(this.chbxDisplayXAxisAction_CheckedChanged);
            // 
            // btnNewData
            // 
            this.btnNewData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNewData.Location = new System.Drawing.Point(546, 10);
            this.btnNewData.Margin = new System.Windows.Forms.Padding(10);
            this.btnNewData.Name = "btnNewData";
            this.btnNewData.Size = new System.Drawing.Size(108, 30);
            this.btnNewData.TabIndex = 3;
            this.btnNewData.Text = "New Data";
            this.btnNewData.UseVisualStyleBackColor = true;
            this.btnNewData.Click += new System.EventHandler(this.btnNewData_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.c1Sparkline2);
            this.tabPage2.Controls.Add(this.tlpAppearanceOptions);
            this.tabPage2.Controls.Add(this.tlpAppearanceCheckboxes);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(1112, 576);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Appearance";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // c1Sparkline2
            // 
            this.c1Sparkline2.BackColor = System.Drawing.SystemColors.Window;
            this.c1Sparkline2.Location = new System.Drawing.Point(256, 218);
            this.c1Sparkline2.Name = "c1Sparkline2";
            this.c1Sparkline2.Size = new System.Drawing.Size(600, 350);
            this.c1Sparkline2.TabIndex = 2;
            this.c1Sparkline2.Text = "c1Sparkline2";
            // 
            // tlpAppearanceOptions
            // 
            this.tlpAppearanceOptions.ColumnCount = 6;
            this.tlpAppearanceOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tlpAppearanceOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpAppearanceOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tlpAppearanceOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpAppearanceOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tlpAppearanceOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpAppearanceOptions.Controls.Add(this.lblAppearanceSparklineType, 0, 0);
            this.tlpAppearanceOptions.Controls.Add(this.lblMarksColor, 0, 1);
            this.tlpAppearanceOptions.Controls.Add(this.lblHighMarkColor, 0, 2);
            this.tlpAppearanceOptions.Controls.Add(this.lblSeriesColor, 2, 0);
            this.tlpAppearanceOptions.Controls.Add(this.lblFirstMarkColor, 2, 1);
            this.tlpAppearanceOptions.Controls.Add(this.lblLowMarkColor, 2, 2);
            this.tlpAppearanceOptions.Controls.Add(this.lblAxisColor, 4, 0);
            this.tlpAppearanceOptions.Controls.Add(this.lblLastMarkColor, 4, 1);
            this.tlpAppearanceOptions.Controls.Add(this.lblNegativeColor, 4, 2);
            this.tlpAppearanceOptions.Controls.Add(this.cbxAppearanceSparkLineType, 1, 0);
            this.tlpAppearanceOptions.Controls.Add(this.cbxMarksColor, 1, 1);
            this.tlpAppearanceOptions.Controls.Add(this.cbxHighMarksColor, 1, 2);
            this.tlpAppearanceOptions.Controls.Add(this.cbxSeriesColor, 3, 0);
            this.tlpAppearanceOptions.Controls.Add(this.cbxFirstMarkColor, 3, 1);
            this.tlpAppearanceOptions.Controls.Add(this.cbxLowMarkColor, 3, 2);
            this.tlpAppearanceOptions.Controls.Add(this.cbxAxisColor, 5, 0);
            this.tlpAppearanceOptions.Controls.Add(this.cbxLastMarkColor, 5, 1);
            this.tlpAppearanceOptions.Controls.Add(this.cbxNegativeColor, 5, 2);
            this.tlpAppearanceOptions.Location = new System.Drawing.Point(8, 112);
            this.tlpAppearanceOptions.Name = "tlpAppearanceOptions";
            this.tlpAppearanceOptions.RowCount = 3;
            this.tlpAppearanceOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpAppearanceOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpAppearanceOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpAppearanceOptions.Size = new System.Drawing.Size(1094, 100);
            this.tlpAppearanceOptions.TabIndex = 1;
            // 
            // lblAppearanceSparklineType
            // 
            this.lblAppearanceSparklineType.AutoSize = true;
            this.lblAppearanceSparklineType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAppearanceSparklineType.Location = new System.Drawing.Point(3, 3);
            this.lblAppearanceSparklineType.Margin = new System.Windows.Forms.Padding(3);
            this.lblAppearanceSparklineType.Name = "lblAppearanceSparklineType";
            this.lblAppearanceSparklineType.Size = new System.Drawing.Size(124, 27);
            this.lblAppearanceSparklineType.TabIndex = 0;
            this.lblAppearanceSparklineType.Text = "SparklineType:";
            this.lblAppearanceSparklineType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMarksColor
            // 
            this.lblMarksColor.AutoSize = true;
            this.lblMarksColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMarksColor.Location = new System.Drawing.Point(3, 36);
            this.lblMarksColor.Margin = new System.Windows.Forms.Padding(3);
            this.lblMarksColor.Name = "lblMarksColor";
            this.lblMarksColor.Size = new System.Drawing.Size(124, 27);
            this.lblMarksColor.TabIndex = 1;
            this.lblMarksColor.Text = "MarksColor:";
            this.lblMarksColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHighMarkColor
            // 
            this.lblHighMarkColor.AutoSize = true;
            this.lblHighMarkColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHighMarkColor.Location = new System.Drawing.Point(3, 69);
            this.lblHighMarkColor.Margin = new System.Windows.Forms.Padding(3);
            this.lblHighMarkColor.Name = "lblHighMarkColor";
            this.lblHighMarkColor.Size = new System.Drawing.Size(124, 28);
            this.lblHighMarkColor.TabIndex = 2;
            this.lblHighMarkColor.Text = "HighMarkColor:";
            this.lblHighMarkColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSeriesColor
            // 
            this.lblSeriesColor.AutoSize = true;
            this.lblSeriesColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSeriesColor.Location = new System.Drawing.Point(364, 3);
            this.lblSeriesColor.Margin = new System.Windows.Forms.Padding(3);
            this.lblSeriesColor.Name = "lblSeriesColor";
            this.lblSeriesColor.Size = new System.Drawing.Size(129, 27);
            this.lblSeriesColor.TabIndex = 3;
            this.lblSeriesColor.Text = "SeriesColor:";
            this.lblSeriesColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFirstMarkColor
            // 
            this.lblFirstMarkColor.AutoSize = true;
            this.lblFirstMarkColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFirstMarkColor.Location = new System.Drawing.Point(364, 36);
            this.lblFirstMarkColor.Margin = new System.Windows.Forms.Padding(3);
            this.lblFirstMarkColor.Name = "lblFirstMarkColor";
            this.lblFirstMarkColor.Size = new System.Drawing.Size(129, 27);
            this.lblFirstMarkColor.TabIndex = 4;
            this.lblFirstMarkColor.Text = "FirstMarkColor:";
            this.lblFirstMarkColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLowMarkColor
            // 
            this.lblLowMarkColor.AutoSize = true;
            this.lblLowMarkColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLowMarkColor.Location = new System.Drawing.Point(364, 69);
            this.lblLowMarkColor.Margin = new System.Windows.Forms.Padding(3);
            this.lblLowMarkColor.Name = "lblLowMarkColor";
            this.lblLowMarkColor.Size = new System.Drawing.Size(129, 28);
            this.lblLowMarkColor.TabIndex = 5;
            this.lblLowMarkColor.Text = "LowMarkColor:";
            this.lblLowMarkColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAxisColor
            // 
            this.lblAxisColor.AutoSize = true;
            this.lblAxisColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAxisColor.Location = new System.Drawing.Point(730, 3);
            this.lblAxisColor.Margin = new System.Windows.Forms.Padding(3);
            this.lblAxisColor.Name = "lblAxisColor";
            this.lblAxisColor.Size = new System.Drawing.Size(129, 27);
            this.lblAxisColor.TabIndex = 6;
            this.lblAxisColor.Text = "AxisColor:";
            this.lblAxisColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLastMarkColor
            // 
            this.lblLastMarkColor.AutoSize = true;
            this.lblLastMarkColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLastMarkColor.Location = new System.Drawing.Point(730, 36);
            this.lblLastMarkColor.Margin = new System.Windows.Forms.Padding(3);
            this.lblLastMarkColor.Name = "lblLastMarkColor";
            this.lblLastMarkColor.Size = new System.Drawing.Size(129, 27);
            this.lblLastMarkColor.TabIndex = 7;
            this.lblLastMarkColor.Text = "LastMarkColor:";
            this.lblLastMarkColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNegativeColor
            // 
            this.lblNegativeColor.AutoSize = true;
            this.lblNegativeColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNegativeColor.Location = new System.Drawing.Point(730, 69);
            this.lblNegativeColor.Margin = new System.Windows.Forms.Padding(3);
            this.lblNegativeColor.Name = "lblNegativeColor";
            this.lblNegativeColor.Size = new System.Drawing.Size(129, 28);
            this.lblNegativeColor.TabIndex = 8;
            this.lblNegativeColor.Text = "NegativeColor:";
            this.lblNegativeColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbxAppearanceSparkLineType
            // 
            this.cbxAppearanceSparkLineType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxAppearanceSparkLineType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAppearanceSparkLineType.FormattingEnabled = true;
            this.cbxAppearanceSparkLineType.Location = new System.Drawing.Point(133, 3);
            this.cbxAppearanceSparkLineType.Name = "cbxAppearanceSparkLineType";
            this.cbxAppearanceSparkLineType.Size = new System.Drawing.Size(225, 25);
            this.cbxAppearanceSparkLineType.TabIndex = 9;
            this.cbxAppearanceSparkLineType.SelectedIndexChanged += new System.EventHandler(this.cbxAppearanceSparkLineType_SelectedIndexChanged);
            // 
            // cbxMarksColor
            // 
            this.cbxMarksColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxMarksColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMarksColor.FormattingEnabled = true;
            this.cbxMarksColor.Location = new System.Drawing.Point(133, 36);
            this.cbxMarksColor.Name = "cbxMarksColor";
            this.cbxMarksColor.Size = new System.Drawing.Size(225, 25);
            this.cbxMarksColor.TabIndex = 10;
            this.cbxMarksColor.SelectedIndexChanged += new System.EventHandler(this.cbxMarksColor_SelectedIndexChanged);
            // 
            // cbxHighMarksColor
            // 
            this.cbxHighMarksColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxHighMarksColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxHighMarksColor.FormattingEnabled = true;
            this.cbxHighMarksColor.Location = new System.Drawing.Point(133, 69);
            this.cbxHighMarksColor.Name = "cbxHighMarksColor";
            this.cbxHighMarksColor.Size = new System.Drawing.Size(225, 25);
            this.cbxHighMarksColor.TabIndex = 11;
            this.cbxHighMarksColor.SelectedIndexChanged += new System.EventHandler(this.cbxHighMarksColor_SelectedIndexChanged);
            // 
            // cbxSeriesColor
            // 
            this.cbxSeriesColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxSeriesColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSeriesColor.FormattingEnabled = true;
            this.cbxSeriesColor.Location = new System.Drawing.Point(499, 3);
            this.cbxSeriesColor.Name = "cbxSeriesColor";
            this.cbxSeriesColor.Size = new System.Drawing.Size(225, 25);
            this.cbxSeriesColor.TabIndex = 12;
            this.cbxSeriesColor.SelectedIndexChanged += new System.EventHandler(this.cbxSeriesColor_SelectedIndexChanged);
            // 
            // cbxFirstMarkColor
            // 
            this.cbxFirstMarkColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxFirstMarkColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFirstMarkColor.FormattingEnabled = true;
            this.cbxFirstMarkColor.Location = new System.Drawing.Point(499, 36);
            this.cbxFirstMarkColor.Name = "cbxFirstMarkColor";
            this.cbxFirstMarkColor.Size = new System.Drawing.Size(225, 25);
            this.cbxFirstMarkColor.TabIndex = 13;
            this.cbxFirstMarkColor.SelectedIndexChanged += new System.EventHandler(this.cbxFirstMarkColor_SelectedIndexChanged);
            // 
            // cbxLowMarkColor
            // 
            this.cbxLowMarkColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxLowMarkColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLowMarkColor.FormattingEnabled = true;
            this.cbxLowMarkColor.Location = new System.Drawing.Point(499, 69);
            this.cbxLowMarkColor.Name = "cbxLowMarkColor";
            this.cbxLowMarkColor.Size = new System.Drawing.Size(225, 25);
            this.cbxLowMarkColor.TabIndex = 14;
            this.cbxLowMarkColor.SelectedIndexChanged += new System.EventHandler(this.cbxLowMarkColor_SelectedIndexChanged);
            // 
            // cbxAxisColor
            // 
            this.cbxAxisColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxAxisColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAxisColor.FormattingEnabled = true;
            this.cbxAxisColor.Location = new System.Drawing.Point(865, 3);
            this.cbxAxisColor.Name = "cbxAxisColor";
            this.cbxAxisColor.Size = new System.Drawing.Size(226, 25);
            this.cbxAxisColor.TabIndex = 15;
            this.cbxAxisColor.SelectedIndexChanged += new System.EventHandler(this.cbxAxisColor_SelectedIndexChanged);
            // 
            // cbxLastMarkColor
            // 
            this.cbxLastMarkColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxLastMarkColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLastMarkColor.FormattingEnabled = true;
            this.cbxLastMarkColor.Location = new System.Drawing.Point(865, 36);
            this.cbxLastMarkColor.Name = "cbxLastMarkColor";
            this.cbxLastMarkColor.Size = new System.Drawing.Size(226, 25);
            this.cbxLastMarkColor.TabIndex = 16;
            this.cbxLastMarkColor.SelectedIndexChanged += new System.EventHandler(this.cbxLastMarkColor_SelectedIndexChanged);
            // 
            // cbxNegativeColor
            // 
            this.cbxNegativeColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxNegativeColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNegativeColor.FormattingEnabled = true;
            this.cbxNegativeColor.Location = new System.Drawing.Point(865, 69);
            this.cbxNegativeColor.Name = "cbxNegativeColor";
            this.cbxNegativeColor.Size = new System.Drawing.Size(226, 25);
            this.cbxNegativeColor.TabIndex = 17;
            this.cbxNegativeColor.SelectedIndexChanged += new System.EventHandler(this.cbxNegativeColor_SelectedIndexChanged);
            // 
            // tlpAppearanceCheckboxes
            // 
            this.tlpAppearanceCheckboxes.ColumnCount = 7;
            this.tlpAppearanceCheckboxes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpAppearanceCheckboxes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpAppearanceCheckboxes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpAppearanceCheckboxes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpAppearanceCheckboxes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpAppearanceCheckboxes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpAppearanceCheckboxes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpAppearanceCheckboxes.Controls.Add(this.chbxShowNegative, 6, 0);
            this.tlpAppearanceCheckboxes.Controls.Add(this.chbxShowLow, 5, 0);
            this.tlpAppearanceCheckboxes.Controls.Add(this.chbxShowHigh, 4, 0);
            this.tlpAppearanceCheckboxes.Controls.Add(this.chbxShowLast, 3, 0);
            this.tlpAppearanceCheckboxes.Controls.Add(this.chbxShowFirst, 2, 0);
            this.tlpAppearanceCheckboxes.Controls.Add(this.chbxDisplayXAxisAppearance, 1, 0);
            this.tlpAppearanceCheckboxes.Controls.Add(this.chbxShowMarks, 0, 0);
            this.tlpAppearanceCheckboxes.Location = new System.Drawing.Point(8, 35);
            this.tlpAppearanceCheckboxes.Name = "tlpAppearanceCheckboxes";
            this.tlpAppearanceCheckboxes.RowCount = 1;
            this.tlpAppearanceCheckboxes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAppearanceCheckboxes.Size = new System.Drawing.Size(1094, 50);
            this.tlpAppearanceCheckboxes.TabIndex = 0;
            // 
            // chbxShowNegative
            // 
            this.chbxShowNegative.AutoSize = true;
            this.chbxShowNegative.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chbxShowNegative.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chbxShowNegative.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbxShowNegative.Location = new System.Drawing.Point(939, 3);
            this.chbxShowNegative.Margin = new System.Windows.Forms.Padding(3, 3, 8, 3);
            this.chbxShowNegative.Name = "chbxShowNegative";
            this.chbxShowNegative.Size = new System.Drawing.Size(147, 44);
            this.chbxShowNegative.TabIndex = 6;
            this.chbxShowNegative.Text = "ShowNegative:";
            this.chbxShowNegative.UseVisualStyleBackColor = true;
            this.chbxShowNegative.CheckedChanged += new System.EventHandler(this.chbxShowNegative_CheckedChanged);
            // 
            // chbxShowLow
            // 
            this.chbxShowLow.AutoSize = true;
            this.chbxShowLow.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chbxShowLow.Checked = true;
            this.chbxShowLow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbxShowLow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chbxShowLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbxShowLow.Location = new System.Drawing.Point(783, 3);
            this.chbxShowLow.Margin = new System.Windows.Forms.Padding(3, 3, 41, 3);
            this.chbxShowLow.Name = "chbxShowLow";
            this.chbxShowLow.Size = new System.Drawing.Size(112, 44);
            this.chbxShowLow.TabIndex = 5;
            this.chbxShowLow.Text = "ShowLow:";
            this.chbxShowLow.UseVisualStyleBackColor = true;
            this.chbxShowLow.CheckedChanged += new System.EventHandler(this.chbxShowLow_CheckedChanged);
            // 
            // chbxShowHigh
            // 
            this.chbxShowHigh.AutoSize = true;
            this.chbxShowHigh.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chbxShowHigh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chbxShowHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbxShowHigh.Location = new System.Drawing.Point(627, 3);
            this.chbxShowHigh.Margin = new System.Windows.Forms.Padding(3, 3, 37, 3);
            this.chbxShowHigh.Name = "chbxShowHigh";
            this.chbxShowHigh.Size = new System.Drawing.Size(116, 44);
            this.chbxShowHigh.TabIndex = 4;
            this.chbxShowHigh.Text = "ShowHigh:";
            this.chbxShowHigh.UseVisualStyleBackColor = true;
            this.chbxShowHigh.CheckedChanged += new System.EventHandler(this.chbxShowHigh_CheckedChanged);
            // 
            // chbxShowLast
            // 
            this.chbxShowLast.AutoSize = true;
            this.chbxShowLast.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chbxShowLast.Checked = true;
            this.chbxShowLast.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbxShowLast.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chbxShowLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbxShowLast.Location = new System.Drawing.Point(471, 3);
            this.chbxShowLast.Margin = new System.Windows.Forms.Padding(3, 3, 35, 3);
            this.chbxShowLast.Name = "chbxShowLast";
            this.chbxShowLast.Size = new System.Drawing.Size(118, 44);
            this.chbxShowLast.TabIndex = 3;
            this.chbxShowLast.Text = "ShowLast:";
            this.chbxShowLast.UseVisualStyleBackColor = true;
            this.chbxShowLast.CheckedChanged += new System.EventHandler(this.chbxShowLast_CheckedChanged);
            // 
            // chbxShowFirst
            // 
            this.chbxShowFirst.AutoSize = true;
            this.chbxShowFirst.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chbxShowFirst.Checked = true;
            this.chbxShowFirst.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbxShowFirst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chbxShowFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbxShowFirst.Location = new System.Drawing.Point(315, 3);
            this.chbxShowFirst.Margin = new System.Windows.Forms.Padding(3, 3, 38, 3);
            this.chbxShowFirst.Name = "chbxShowFirst";
            this.chbxShowFirst.Size = new System.Drawing.Size(115, 44);
            this.chbxShowFirst.TabIndex = 2;
            this.chbxShowFirst.Text = "ShowFirst:";
            this.chbxShowFirst.UseVisualStyleBackColor = true;
            this.chbxShowFirst.CheckedChanged += new System.EventHandler(this.chbxShowFirst_CheckedChanged);
            // 
            // chbxDisplayXAxisAppearance
            // 
            this.chbxDisplayXAxisAppearance.AutoSize = true;
            this.chbxDisplayXAxisAppearance.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chbxDisplayXAxisAppearance.Checked = true;
            this.chbxDisplayXAxisAppearance.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbxDisplayXAxisAppearance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chbxDisplayXAxisAppearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbxDisplayXAxisAppearance.Location = new System.Drawing.Point(159, 3);
            this.chbxDisplayXAxisAppearance.Margin = new System.Windows.Forms.Padding(3, 3, 17, 3);
            this.chbxDisplayXAxisAppearance.Name = "chbxDisplayXAxisAppearance";
            this.chbxDisplayXAxisAppearance.Size = new System.Drawing.Size(136, 44);
            this.chbxDisplayXAxisAppearance.TabIndex = 1;
            this.chbxDisplayXAxisAppearance.Text = "DisplayXAxis:";
            this.chbxDisplayXAxisAppearance.UseVisualStyleBackColor = true;
            this.chbxDisplayXAxisAppearance.CheckedChanged += new System.EventHandler(this.chbxDisplayXaxis_CheckedChanged);
            // 
            // chbxShowMarks
            // 
            this.chbxShowMarks.AutoSize = true;
            this.chbxShowMarks.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chbxShowMarks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chbxShowMarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbxShowMarks.Location = new System.Drawing.Point(3, 3);
            this.chbxShowMarks.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            this.chbxShowMarks.Name = "chbxShowMarks";
            this.chbxShowMarks.Size = new System.Drawing.Size(123, 44);
            this.chbxShowMarks.TabIndex = 0;
            this.chbxShowMarks.Text = "ShowMarks:";
            this.chbxShowMarks.UseVisualStyleBackColor = true;
            this.chbxShowMarks.CheckedChanged += new System.EventHandler(this.chbxShowMarks_CheckedChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.fxgRegionSales);
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Size = new System.Drawing.Size(1112, 576);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Region sales";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // fxgRegionSales
            // 
            this.fxgRegionSales.ColumnInfo = resources.GetString("fxgRegionSales.ColumnInfo");
            this.fxgRegionSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fxgRegionSales.Location = new System.Drawing.Point(3, 4);
            this.fxgRegionSales.Name = "fxgRegionSales";
            this.fxgRegionSales.Rows.DefaultSize = 22;
            this.fxgRegionSales.Size = new System.Drawing.Size(1106, 568);
            this.fxgRegionSales.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 606);
            this.Controls.Add(this.tabMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1136, 645);
            this.Name = "MainForm";
            this.Text = "Sparkline Sample";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tlpSeeItInAction.ResumeLayout(false);
            this.tlpSeeItInAction.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tlpAppearanceOptions.ResumeLayout(false);
            this.tlpAppearanceOptions.PerformLayout();
            this.tlpAppearanceCheckboxes.ResumeLayout(false);
            this.tlpAppearanceCheckboxes.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fxgRegionSales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TableLayoutPanel tlpSeeItInAction;
        private System.Windows.Forms.Label lblSparklineType;
        private System.Windows.Forms.ComboBox cbxSparklineType;
        private System.Windows.Forms.CheckBox chbxDisplayXAxisAction;
        private System.Windows.Forms.Button btnNewData;
        private System.Windows.Forms.TableLayoutPanel tlpAppearanceCheckboxes;
        private System.Windows.Forms.CheckBox chbxShowMarks;
        private System.Windows.Forms.CheckBox chbxShowFirst;
        private System.Windows.Forms.CheckBox chbxDisplayXAxisAppearance;
        private System.Windows.Forms.CheckBox chbxShowHigh;
        private System.Windows.Forms.CheckBox chbxShowLast;
        private System.Windows.Forms.CheckBox chbxShowLow;
        private System.Windows.Forms.CheckBox chbxShowNegative;
        private System.Windows.Forms.TableLayoutPanel tlpAppearanceOptions;
        private System.Windows.Forms.Label lblAppearanceSparklineType;
        private System.Windows.Forms.Label lblMarksColor;
        private System.Windows.Forms.Label lblHighMarkColor;
        private System.Windows.Forms.Label lblSeriesColor;
        private System.Windows.Forms.Label lblFirstMarkColor;
        private System.Windows.Forms.Label lblLowMarkColor;
        private System.Windows.Forms.Label lblAxisColor;
        private System.Windows.Forms.Label lblLastMarkColor;
        private System.Windows.Forms.Label lblNegativeColor;
        private System.Windows.Forms.ComboBox cbxAppearanceSparkLineType;
        private System.Windows.Forms.ComboBox cbxMarksColor;
        private System.Windows.Forms.ComboBox cbxHighMarksColor;
        private System.Windows.Forms.ComboBox cbxSeriesColor;
        private System.Windows.Forms.ComboBox cbxFirstMarkColor;
        private System.Windows.Forms.ComboBox cbxLowMarkColor;
        private System.Windows.Forms.ComboBox cbxAxisColor;
        private System.Windows.Forms.ComboBox cbxLastMarkColor;
        private System.Windows.Forms.ComboBox cbxNegativeColor;
        private C1.Win.C1FlexGrid.C1FlexGrid fxgRegionSales;
        private C1.Win.Sparkline.C1Sparkline c1Sparkline1;
        private C1.Win.Sparkline.C1Sparkline c1Sparkline2;
    }
}

