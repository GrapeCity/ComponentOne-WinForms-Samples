namespace NewFeatures20091
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this._flexNewRowWatermark = new C1.Win.FlexGrid.C1FlexGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this._txtNewRowWatermark = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this._flexClipboardCopyMode = new C1.Win.FlexGrid.C1FlexGrid();
            this._txtClipboard = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this._btnCopy = new System.Windows.Forms.Button();
            this._cmbClipboardCopyMode = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this._flexAllowMergingFixed = new C1.Win.FlexGrid.C1FlexGrid();
            this.panel5 = new System.Windows.Forms.Panel();
            this._cmbAllowMergingFixed = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this._flexEditOptions = new C1.Win.FlexGrid.C1FlexGrid();
            this.panel6 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this._chkEditOption = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this._flexRowValidation = new C1.Win.FlexGrid.C1FlexGrid();
            this._lstRowValidationEventLog = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this._btnRowValidationEventLog = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this._flexSubtotals = new C1.Win.FlexGrid.C1FlexGrid();
            this._lstSubtotal = new System.Windows.Forms.ListBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this._cmbAggregate = new System.Windows.Forms.ComboBox();
            this._btnSubtotal = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.categoriesProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._flexNewRowWatermark)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._flexClipboardCopyMode)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._flexAllowMergingFixed)).BeginInit();
            this.panel5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._flexEditOptions)).BeginInit();
            this.panel6.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._flexRowValidation)).BeginInit();
            this.panel3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._flexSubtotals)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesProductsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(659, 409);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this._flexNewRowWatermark);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(651, 383);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "NewRowWatermark";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // _flexNewRowWatermark
            // 
            this._flexNewRowWatermark.AllowAddNew = true;
            this._flexNewRowWatermark.BorderStyle = C1.Win.FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
            this._flexNewRowWatermark.ColumnInfo = resources.GetString("_flexNewRowWatermark.ColumnInfo");
            this._flexNewRowWatermark.Dock = System.Windows.Forms.DockStyle.Fill;
            this._flexNewRowWatermark.Location = new System.Drawing.Point(2, 75);
            this._flexNewRowWatermark.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._flexNewRowWatermark.Name = "_flexNewRowWatermark";
            this._flexNewRowWatermark.NewRowWatermark = "";
            this._flexNewRowWatermark.Rows.Count = 1;
            this._flexNewRowWatermark.Size = new System.Drawing.Size(647, 306);
            this._flexNewRowWatermark.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._txtNewRowWatermark);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(2, 43);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(647, 32);
            this.panel1.TabIndex = 1;
            // 
            // _txtNewRowWatermark
            // 
            this._txtNewRowWatermark.Location = new System.Drawing.Point(123, 7);
            this._txtNewRowWatermark.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._txtNewRowWatermark.Name = "_txtNewRowWatermark";
            this._txtNewRowWatermark.Size = new System.Drawing.Size(317, 20);
            this._txtNewRowWatermark.TabIndex = 1;
            this._txtNewRowWatermark.Text = "Click here to add a new row...";
            this._txtNewRowWatermark.TextChanged += new System.EventHandler(this._txtNewRowWatermark_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 10);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "NewRowWatermark";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(2, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.label1.Size = new System.Drawing.Size(647, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "The NewRowWatermark property displays a string over the new row template area, ex" +
                "plaining to users how to add new rows. This property only works when the grid\'s " +
                "AllowAddNew property is set to true.";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer1);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(638, 386);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "ClipboardCopyMode";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(2, 76);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this._flexClipboardCopyMode);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this._txtClipboard);
            this.splitContainer1.Size = new System.Drawing.Size(635, 310);
            this.splitContainer1.SplitterDistance = 531;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 3;
            // 
            // _flexClipboardCopyMode
            // 
            this._flexClipboardCopyMode.AutoClipboard = true;
            this._flexClipboardCopyMode.BorderStyle = C1.Win.FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
            this._flexClipboardCopyMode.ColumnInfo = resources.GetString("_flexClipboardCopyMode.ColumnInfo");
            this._flexClipboardCopyMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this._flexClipboardCopyMode.DragMode = C1.Win.FlexGrid.DragModeEnum.AutomaticCopy;
            this._flexClipboardCopyMode.Location = new System.Drawing.Point(0, 0);
            this._flexClipboardCopyMode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._flexClipboardCopyMode.Name = "_flexClipboardCopyMode";
            this._flexClipboardCopyMode.NewRowWatermark = "";
            this._flexClipboardCopyMode.Rows.Count = 1;
            this._flexClipboardCopyMode.Size = new System.Drawing.Size(399, 311);
            this._flexClipboardCopyMode.TabIndex = 3;
            // 
            // _txtClipboard
            // 
            this._txtClipboard.AllowDrop = true;
            this._txtClipboard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._txtClipboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this._txtClipboard.Location = new System.Drawing.Point(0, 0);
            this._txtClipboard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._txtClipboard.Multiline = true;
            this._txtClipboard.Name = "_txtClipboard";
            this._txtClipboard.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this._txtClipboard.Size = new System.Drawing.Size(234, 310);
            this._txtClipboard.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this._btnCopy);
            this.panel2.Controls.Add(this._cmbClipboardCopyMode);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(2, 43);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(635, 32);
            this.panel2.TabIndex = 2;
            // 
            // _btnCopy
            // 
            this._btnCopy.Location = new System.Drawing.Point(289, 4);
            this._btnCopy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._btnCopy.Name = "_btnCopy";
            this._btnCopy.Size = new System.Drawing.Size(200, 25);
            this._btnCopy.TabIndex = 2;
            this._btnCopy.Text = ">> Copy grid selection to TextBox >>";
            this._btnCopy.UseVisualStyleBackColor = true;
            this._btnCopy.Click += new System.EventHandler(this._btnCopy_Click);
            // 
            // _cmbClipboardCopyMode
            // 
            this._cmbClipboardCopyMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cmbClipboardCopyMode.FormattingEnabled = true;
            this._cmbClipboardCopyMode.Items.AddRange(new object[] {
            "DataOnly",
            "DataAndColumnHeaders",
            "DataAndRowHeaders",
            "DataAndAllHeaders",
            "Disabled"});
            this._cmbClipboardCopyMode.Location = new System.Drawing.Point(128, 7);
            this._cmbClipboardCopyMode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._cmbClipboardCopyMode.Name = "_cmbClipboardCopyMode";
            this._cmbClipboardCopyMode.Size = new System.Drawing.Size(149, 21);
            this._cmbClipboardCopyMode.TabIndex = 1;
            this._cmbClipboardCopyMode.SelectedIndexChanged += new System.EventHandler(this._cmbClipboardCopyMode_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 10);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "ClipboardCopyMode";
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(2, 2);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.label2.Size = new System.Drawing.Size(635, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this._flexAllowMergingFixed);
            this.tabPage5.Controls.Add(this.panel5);
            this.tabPage5.Controls.Add(this.label9);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage5.Size = new System.Drawing.Size(638, 386);
            this.tabPage5.TabIndex = 5;
            this.tabPage5.Text = "AllowMergingFixed";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // _flexAllowMergingFixed
            // 
            this._flexAllowMergingFixed.BorderStyle = C1.Win.FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
            this._flexAllowMergingFixed.ColumnInfo = resources.GetString("_flexAllowMergingFixed.ColumnInfo");
            this._flexAllowMergingFixed.Dock = System.Windows.Forms.DockStyle.Fill;
            this._flexAllowMergingFixed.Location = new System.Drawing.Point(2, 76);
            this._flexAllowMergingFixed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._flexAllowMergingFixed.Name = "_flexAllowMergingFixed";
            this._flexAllowMergingFixed.NewRowWatermark = "";
            this._flexAllowMergingFixed.Rows.Count = 1;
            this._flexAllowMergingFixed.Size = new System.Drawing.Size(636, 311);
            this._flexAllowMergingFixed.TabIndex = 5;
            this._flexAllowMergingFixed.Tree.Column = 2;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this._cmbAllowMergingFixed);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(2, 43);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(635, 32);
            this.panel5.TabIndex = 8;
            // 
            // _cmbAllowMergingFixed
            // 
            this._cmbAllowMergingFixed.FormattingEnabled = true;
            this._cmbAllowMergingFixed.Items.AddRange(new object[] {
            "None",
            "Free",
            "RestrictRows",
            "RestrictCols",
            "RestrictAll",
            "FixedOnly",
            "Spill",
            "Nodes",
            "Custom",
            "Default"});
            this._cmbAllowMergingFixed.Location = new System.Drawing.Point(119, 7);
            this._cmbAllowMergingFixed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._cmbAllowMergingFixed.Name = "_cmbAllowMergingFixed";
            this._cmbAllowMergingFixed.Size = new System.Drawing.Size(221, 21);
            this._cmbAllowMergingFixed.TabIndex = 2;
            this._cmbAllowMergingFixed.SelectedIndexChanged += new System.EventHandler(this._cmbAllowMergingFixed_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(9, 10);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "AllowMergingFixed";
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Location = new System.Drawing.Point(2, 2);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.label9.Size = new System.Drawing.Size(635, 41);
            this.label9.TabIndex = 4;
            this.label9.Text = "The AllowMergingFixed property allows you to select different merging modes for t" +
                "he fixed and scrollable cells. This is ideal for generating merged column header" +
                "s as shown below.";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this._flexEditOptions);
            this.tabPage6.Controls.Add(this.panel6);
            this.tabPage6.Controls.Add(this.label12);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage6.Size = new System.Drawing.Size(638, 386);
            this.tabPage6.TabIndex = 4;
            this.tabPage6.Text = "EditOptions";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // _flexEditOptions
            // 
            this._flexEditOptions.AllowAddNew = true;
            this._flexEditOptions.BorderStyle = C1.Win.FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
            this._flexEditOptions.ColumnInfo = resources.GetString("_flexEditOptions.ColumnInfo");
            this._flexEditOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this._flexEditOptions.Location = new System.Drawing.Point(2, 76);
            this._flexEditOptions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._flexEditOptions.Name = "_flexEditOptions";
            this._flexEditOptions.NewRowWatermark = "";
            this._flexEditOptions.Rows.Count = 1;
            this._flexEditOptions.Size = new System.Drawing.Size(636, 311);
            this._flexEditOptions.TabIndex = 10;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.checkBox1);
            this.panel6.Controls.Add(this._chkEditOption);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(2, 43);
            this.panel6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(635, 32);
            this.panel6.TabIndex = 9;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(225, 9);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(74, 14);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "EditOnRequest";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this._chkEditOption_CheckedChanged);
            // 
            // _chkEditOption
            // 
            this._chkEditOption.AutoSize = true;
            this._chkEditOption.Checked = true;
            this._chkEditOption.CheckState = System.Windows.Forms.CheckState.Checked;
            this._chkEditOption.Location = new System.Drawing.Point(101, 9);
            this._chkEditOption.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._chkEditOption.Name = "_chkEditOption";
            this._chkEditOption.Size = new System.Drawing.Size(92, 14);
            this._chkEditOption.TabIndex = 1;
            this._chkEditOption.Text = "ExitOnLeftRightKeys";
            this._chkEditOption.UseVisualStyleBackColor = true;
            this._chkEditOption.CheckedChanged += new System.EventHandler(this._chkEditOption_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(9, 10);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "EditOptions";
            // 
            // label12
            // 
            this.label12.Dock = System.Windows.Forms.DockStyle.Top;
            this.label12.Location = new System.Drawing.Point(2, 2);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.label12.Size = new System.Drawing.Size(635, 41);
            this.label12.TabIndex = 1;
            this.label12.Text = "The EditOptions property has new flags that enable further customization of the e" +
                "diting process.";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.splitContainer2);
            this.tabPage3.Controls.Add(this.panel3);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Size = new System.Drawing.Size(638, 386);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "Row Validation Events";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.Location = new System.Drawing.Point(2, 76);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this._flexRowValidation);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this._lstRowValidationEventLog);
            this.splitContainer2.Size = new System.Drawing.Size(635, 310);
            this.splitContainer2.SplitterDistance = 531;
            this.splitContainer2.SplitterWidth = 3;
            this.splitContainer2.TabIndex = 4;
            // 
            // _flexRowValidation
            // 
            this._flexRowValidation.BorderStyle = C1.Win.FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
            this._flexRowValidation.ColumnInfo = resources.GetString("_flexRowValidation.ColumnInfo");
            this._flexRowValidation.Dock = System.Windows.Forms.DockStyle.Fill;
            this._flexRowValidation.Location = new System.Drawing.Point(0, 0);
            this._flexRowValidation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._flexRowValidation.Name = "_flexRowValidation";
            this._flexRowValidation.NewRowWatermark = "";
            this._flexRowValidation.Rows.Count = 1;
            this._flexRowValidation.Size = new System.Drawing.Size(399, 311);
            this._flexRowValidation.TabIndex = 3;
            this._flexRowValidation.RowValidating += new C1.Win.FlexGrid.RowColEventHandler(this._flexRowValidation_RowValidating);
            this._flexRowValidation.RowValidated += new C1.Win.FlexGrid.RowColEventHandler(this._flexRowValidation_RowValidated);
            // 
            // _lstRowValidationEventLog
            // 
            this._lstRowValidationEventLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._lstRowValidationEventLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lstRowValidationEventLog.FormattingEnabled = true;
            this._lstRowValidationEventLog.IntegralHeight = false;
            this._lstRowValidationEventLog.Location = new System.Drawing.Point(0, 0);
            this._lstRowValidationEventLog.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._lstRowValidationEventLog.Name = "_lstRowValidationEventLog";
            this._lstRowValidationEventLog.Size = new System.Drawing.Size(234, 310);
            this._lstRowValidationEventLog.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this._btnRowValidationEventLog);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(2, 43);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(635, 32);
            this.panel3.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(96, 11);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(258, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Category names must start with \"A\", \"B\", \"C\", or \"D\".";
            // 
            // _btnRowValidationEventLog
            // 
            this._btnRowValidationEventLog.Location = new System.Drawing.Point(401, 6);
            this._btnRowValidationEventLog.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._btnRowValidationEventLog.Name = "_btnRowValidationEventLog";
            this._btnRowValidationEventLog.Size = new System.Drawing.Size(104, 21);
            this._btnRowValidationEventLog.TabIndex = 1;
            this._btnRowValidationEventLog.Text = "Clear event log";
            this._btnRowValidationEventLog.UseVisualStyleBackColor = true;
            this._btnRowValidationEventLog.Click += new System.EventHandler(this._btnRowValidationEventLog_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 10);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "RowValidating";
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(2, 2);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.label3.Size = new System.Drawing.Size(635, 41);
            this.label3.TabIndex = 2;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.splitContainer3);
            this.tabPage4.Controls.Add(this.panel4);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage4.Size = new System.Drawing.Size(638, 386);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Subtotal Events";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer3.Location = new System.Drawing.Point(2, 76);
            this.splitContainer3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this._flexSubtotals);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this._lstSubtotal);
            this.splitContainer3.Size = new System.Drawing.Size(635, 310);
            this.splitContainer3.SplitterDistance = 531;
            this.splitContainer3.SplitterWidth = 3;
            this.splitContainer3.TabIndex = 6;
            // 
            // _flexSubtotals
            // 
            this._flexSubtotals.AllowMerging = C1.Win.FlexGrid.AllowMergingEnum.Nodes;
            this._flexSubtotals.BorderStyle = C1.Win.FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
            this._flexSubtotals.ColumnInfo = resources.GetString("_flexSubtotals.ColumnInfo");
            this._flexSubtotals.Dock = System.Windows.Forms.DockStyle.Fill;
            this._flexSubtotals.Location = new System.Drawing.Point(0, 0);
            this._flexSubtotals.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._flexSubtotals.Name = "_flexSubtotals";
            this._flexSubtotals.NewRowWatermark = "";
            this._flexSubtotals.Rows.Count = 1;
            this._flexSubtotals.Size = new System.Drawing.Size(399, 311);
            this._flexSubtotals.TabIndex = 3;
            this._flexSubtotals.Tree.Column = 2;
            this._flexSubtotals.BeforeSubtotal += new C1.Win.FlexGrid.SubtotalEventHandler(this._flexSubtotals_BeforeSubtotal);
            this._flexSubtotals.AfterSubtotal += new C1.Win.FlexGrid.SubtotalEventHandler(this._flexSubtotals_AfterSubtotal);
            // 
            // _lstSubtotal
            // 
            this._lstSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._lstSubtotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lstSubtotal.FormattingEnabled = true;
            this._lstSubtotal.IntegralHeight = false;
            this._lstSubtotal.Location = new System.Drawing.Point(0, 0);
            this._lstSubtotal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._lstSubtotal.Name = "_lstSubtotal";
            this._lstSubtotal.Size = new System.Drawing.Size(234, 310);
            this._lstSubtotal.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this._cmbAggregate);
            this.panel4.Controls.Add(this._btnSubtotal);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(2, 43);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(635, 32);
            this.panel4.TabIndex = 7;
            // 
            // _cmbAggregate
            // 
            this._cmbAggregate.FormattingEnabled = true;
            this._cmbAggregate.Items.AddRange(new object[] {
            "Sum",
            "Percent",
            "Count",
            "Average",
            "Max",
            "Min",
            "Std",
            "Var",
            "StdPop",
            "VarPop"});
            this._cmbAggregate.Location = new System.Drawing.Point(74, 7);
            this._cmbAggregate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._cmbAggregate.Name = "_cmbAggregate";
            this._cmbAggregate.Size = new System.Drawing.Size(221, 21);
            this._cmbAggregate.TabIndex = 2;
            // 
            // _btnSubtotal
            // 
            this._btnSubtotal.Location = new System.Drawing.Point(401, 6);
            this._btnSubtotal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._btnSubtotal.Name = "_btnSubtotal";
            this._btnSubtotal.Size = new System.Drawing.Size(104, 21);
            this._btnSubtotal.TabIndex = 1;
            this._btnSubtotal.Text = "Refresh Subtotals";
            this._btnSubtotal.UseVisualStyleBackColor = true;
            this._btnSubtotal.Click += new System.EventHandler(this._btnSubtotal_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 10);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Subtotal";
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(2, 2);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.label4.Size = new System.Drawing.Size(635, 41);
            this.label4.TabIndex = 3;
            this.label4.Text = "The BeforeSubtotal and Aftersubtotal events fire once for each subtotal row added" +
                " after a call to the Subtotal method. These events allow you to customize the su" +
                "btotal rows as they are created.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 409);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C1FlexGrid: New Features in V1/2009";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._flexNewRowWatermark)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._flexClipboardCopyMode)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._flexAllowMergingFixed)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._flexEditOptions)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._flexRowValidation)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._flexSubtotals)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesProductsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private C1.Win.FlexGrid.C1FlexGrid _flexNewRowWatermark;
        private System.Windows.Forms.TextBox _txtNewRowWatermark;
        private System.Windows.Forms.BindingSource categoriesProductsBindingSource;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private C1.Win.FlexGrid.C1FlexGrid _flexClipboardCopyMode;
        private System.Windows.Forms.TextBox _txtClipboard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button _btnCopy;
        private System.Windows.Forms.ComboBox _cmbClipboardCopyMode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private C1.Win.FlexGrid.C1FlexGrid _flexRowValidation;
        private System.Windows.Forms.ListBox _lstRowValidationEventLog;
        private System.Windows.Forms.Button _btnRowValidationEventLog;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private C1.Win.FlexGrid.C1FlexGrid _flexSubtotals;
        private System.Windows.Forms.ListBox _lstSubtotal;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox _cmbAggregate;
        private System.Windows.Forms.Button _btnSubtotal;
        private System.Windows.Forms.Label label10;
        private C1.Win.FlexGrid.C1FlexGrid _flexAllowMergingFixed;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox _cmbAllowMergingFixed;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private C1.Win.FlexGrid.C1FlexGrid _flexEditOptions;
        private System.Windows.Forms.CheckBox _chkEditOption;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

