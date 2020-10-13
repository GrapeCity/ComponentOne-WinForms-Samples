namespace ControlExplorer.InputPanel
{
    partial class Validation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Validation));
            this.c1InputPanel1 = new C1.Win.C1InputPanel.C1InputPanel();
            this.inputGroupHeader1 = new C1.Win.C1InputPanel.InputGroupHeader();
            this.inputLabel1 = new C1.Win.C1InputPanel.InputLabel();
            this.inputTextBox1 = new C1.Win.C1InputPanel.InputTextBox();
            this.inputLabel2 = new C1.Win.C1InputPanel.InputLabel();
            this.inputNumericBox1 = new C1.Win.C1InputPanel.InputNumericBox();
            this.inputLabel5 = new C1.Win.C1InputPanel.InputLabel();
            this.inputNumericBox2 = new C1.Win.C1InputPanel.InputNumericBox();
            this.inputLabel4 = new C1.Win.C1InputPanel.InputLabel();
            this.inputTimePicker1 = new C1.Win.C1InputPanel.InputTimePicker();
            this.inputLabel3 = new C1.Win.C1InputPanel.InputLabel();
            this.inputCheckBox1 = new C1.Win.C1InputPanel.InputCheckBox();
            this.inputCheckBox2 = new C1.Win.C1InputPanel.InputCheckBox();
            this.inputLabel12 = new C1.Win.C1InputPanel.InputLabel();
            this.inputTextBox2 = new C1.Win.C1InputPanel.InputTextBox();
            this.inputGroupHeader2 = new C1.Win.C1InputPanel.InputGroupHeader();
            this.inputLabel6 = new C1.Win.C1InputPanel.InputLabel();
            this.inputTextBox3 = new C1.Win.C1InputPanel.InputTextBox();
            this.inputImage1 = new C1.Win.C1InputPanel.InputImage();
            ((System.ComponentModel.ISupportInitialize)(this.c1InputPanel1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1InputPanel1
            // 
            this.c1InputPanel1.BorderThickness = 2;
            this.c1InputPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1InputPanel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.c1InputPanel1.Items.Add(this.inputGroupHeader1);
            this.c1InputPanel1.Items.Add(this.inputLabel1);
            this.c1InputPanel1.Items.Add(this.inputTextBox1);
            this.c1InputPanel1.Items.Add(this.inputLabel2);
            this.c1InputPanel1.Items.Add(this.inputNumericBox1);
            this.c1InputPanel1.Items.Add(this.inputLabel5);
            this.c1InputPanel1.Items.Add(this.inputNumericBox2);
            this.c1InputPanel1.Items.Add(this.inputLabel4);
            this.c1InputPanel1.Items.Add(this.inputTimePicker1);
            this.c1InputPanel1.Items.Add(this.inputLabel3);
            this.c1InputPanel1.Items.Add(this.inputCheckBox1);
            this.c1InputPanel1.Items.Add(this.inputCheckBox2);
            this.c1InputPanel1.Items.Add(this.inputLabel12);
            this.c1InputPanel1.Items.Add(this.inputTextBox2);
            this.c1InputPanel1.Items.Add(this.inputGroupHeader2);
            this.c1InputPanel1.Items.Add(this.inputLabel6);
            this.c1InputPanel1.Items.Add(this.inputTextBox3);
            this.c1InputPanel1.Items.Add(this.inputImage1);
            this.c1InputPanel1.Location = new System.Drawing.Point(0, 0);
            this.c1InputPanel1.Name = "c1InputPanel1";
            this.c1InputPanel1.Size = new System.Drawing.Size(592, 446);
            this.c1InputPanel1.TabIndex = 2;
            this.c1InputPanel1.ToolTipSettings.Images.Add(new C1.Win.C1SuperTooltip.ImageEntry("Protect.png", ((System.Drawing.Image)(resources.GetObject("c1InputPanel1.ToolTipSettings.Images")))));
            this.c1InputPanel1.ToolTipSettings.Images.Add(new C1.Win.C1SuperTooltip.ImageEntry("Warning.png", ((System.Drawing.Image)(resources.GetObject("c1InputPanel1.ToolTipSettings.Images1")))));
            this.c1InputPanel1.ToolTipSettings.MaximumWidth = 300;
            // 
            // inputGroupHeader1
            // 
            this.inputGroupHeader1.Name = "inputGroupHeader1";
            this.inputGroupHeader1.Text = "Error Providers";
            // 
            // inputLabel1
            // 
            this.inputLabel1.Name = "inputLabel1";
            this.inputLabel1.Text = "Type something that starts with \'a\':";
            this.inputLabel1.Width = 236;
            // 
            // inputTextBox1
            // 
            this.inputTextBox1.Name = "inputTextBox1";
            this.inputTextBox1.Text = "acceptable...";
            this.inputTextBox1.ToolTipText = "This is an <b>InputTextBox</b>.<br>What you type here doesn\'t really matter, as l" +
    "ong as it starts with \'a\'...";
            this.inputTextBox1.Width = 187;
            this.inputTextBox1.Validating += new System.ComponentModel.CancelEventHandler(this.inputTextBox1_Validating);
            // 
            // inputLabel2
            // 
            this.inputLabel2.Name = "inputLabel2";
            this.inputLabel2.Text = "Enter an even value:";
            this.inputLabel2.Width = 236;
            // 
            // inputNumericBox1
            // 
            this.inputNumericBox1.Name = "inputNumericBox1";
            this.inputNumericBox1.ToolTipText = "This is an <b>InputNumericBox</b>.<br>It only accepts even numbers.";
            this.inputNumericBox1.Value = new decimal(new int[] {
            98,
            0,
            0,
            0});
            this.inputNumericBox1.ValueChanged += new System.EventHandler(this.inputNumericBox1_Validating);
            // 
            // inputLabel5
            // 
            this.inputLabel5.Name = "inputLabel5";
            this.inputLabel5.Text = "Enter a value that totals 100 or more:";
            this.inputLabel5.Width = 236;
            // 
            // inputNumericBox2
            // 
            this.inputNumericBox2.Name = "inputNumericBox2";
            this.inputNumericBox2.ToolTipText = "This is an <b>InputNumericBox</b>.<br>The value should add to at least 100 with t" +
    "he value in the previous box.";
            this.inputNumericBox2.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.inputNumericBox2.ValueChanged += new System.EventHandler(this.inputNumericBox1_ValueChanged);
            // 
            // inputLabel4
            // 
            this.inputLabel4.Name = "inputLabel4";
            this.inputLabel4.Text = "Enter a time between 1 and 2 PM:";
            this.inputLabel4.Width = 236;
            // 
            // inputTimePicker1
            // 
            this.inputTimePicker1.Name = "inputTimePicker1";
            this.inputTimePicker1.ToolTipText = "This is an <b>InputTimePicker</b>.<br>The time you enter here should be between 1" +
    " and 2 PM.";
            this.inputTimePicker1.Value = System.TimeSpan.Parse("13:01:00");
            this.inputTimePicker1.TextChanged += new System.EventHandler(this.inputTimePicker1_TextChanged);
            // 
            // inputLabel3
            // 
            this.inputLabel3.Name = "inputLabel3";
            this.inputLabel3.Text = "Check at least one box:";
            this.inputLabel3.Width = 236;
            // 
            // inputCheckBox1
            // 
            this.inputCheckBox1.Break = C1.Win.C1InputPanel.BreakType.None;
            this.inputCheckBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.inputCheckBox1.Name = "inputCheckBox1";
            this.inputCheckBox1.ToolTipText = "This is an <b>InputCheckBox<b>.<br>Please check at least one of the boxes before " +
    "proceeding.";
            this.inputCheckBox1.CheckedChanged += new System.EventHandler(this.inputCheckBox1_CheckedChanged);
            // 
            // inputCheckBox2
            // 
            this.inputCheckBox2.Name = "inputCheckBox2";
            this.inputCheckBox2.ToolTipText = "This is an <b>InputCheckBox<b>.<br>Please check at least one of the boxes before " +
    "proceeding.";
            this.inputCheckBox2.CheckedChanged += new System.EventHandler(this.inputCheckBox1_CheckedChanged);
            // 
            // inputLabel12
            // 
            this.inputLabel12.Name = "inputLabel12";
            this.inputLabel12.Padding = new System.Windows.Forms.Padding(0, 0, 0, 35);
            this.inputLabel12.Text = "Enter at least 50 characters:";
            this.inputLabel12.Width = 236;
            // 
            // inputTextBox2
            // 
            this.inputTextBox2.ElementHeight = 60;
            this.inputTextBox2.Multiline = true;
            this.inputTextBox2.Name = "inputTextBox2";
            this.inputTextBox2.Text = "This hosted text box is multiline and requires at least 50 characters.";
            this.inputTextBox2.ToolTipText = "Characters entered: 70";
            this.inputTextBox2.Width = 237;
            this.inputTextBox2.TextChanged += new System.EventHandler(this.inputTextBox2_TextChanged);
            // 
            // inputGroupHeader2
            // 
            this.inputGroupHeader2.Name = "inputGroupHeader2";
            this.inputGroupHeader2.Text = "Tooltips";
            // 
            // inputLabel6
            // 
            this.inputLabel6.Name = "inputLabel6";
            this.inputLabel6.Text = "Enter your login credentials:";
            this.inputLabel6.Width = 236;
            // 
            // inputTextBox3
            // 
            this.inputTextBox3.Break = C1.Win.C1InputPanel.BreakType.None;
            this.inputTextBox3.Name = "inputTextBox3";
            this.inputTextBox3.ToolTipText = resources.GetString("inputTextBox3.ToolTipText");
            this.inputTextBox3.Width = 200;
            // 
            // inputImage1
            // 
            this.inputImage1.Image = ((System.Drawing.Image)(resources.GetObject("inputImage1.Image")));
            this.inputImage1.Name = "inputImage1";
            this.inputImage1.ToolTipText = resources.GetString("inputImage1.ToolTipText");
            // 
            // Validation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 446);
            this.Controls.Add(this.c1InputPanel1);
            this.Name = "Validation";
            this.Text = "Validation";
            this.Load += new System.EventHandler(this.Validation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1InputPanel1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1InputPanel.C1InputPanel c1InputPanel1;
        private C1.Win.C1InputPanel.InputGroupHeader inputGroupHeader1;
        private C1.Win.C1InputPanel.InputLabel inputLabel1;
        private C1.Win.C1InputPanel.InputTextBox inputTextBox1;
        private C1.Win.C1InputPanel.InputLabel inputLabel2;
        private C1.Win.C1InputPanel.InputNumericBox inputNumericBox1;
        private C1.Win.C1InputPanel.InputLabel inputLabel5;
        private C1.Win.C1InputPanel.InputNumericBox inputNumericBox2;
        private C1.Win.C1InputPanel.InputLabel inputLabel4;
        private C1.Win.C1InputPanel.InputTimePicker inputTimePicker1;
        private C1.Win.C1InputPanel.InputLabel inputLabel3;
        private C1.Win.C1InputPanel.InputCheckBox inputCheckBox1;
        private C1.Win.C1InputPanel.InputCheckBox inputCheckBox2;
        private C1.Win.C1InputPanel.InputLabel inputLabel12;
        private C1.Win.C1InputPanel.InputTextBox inputTextBox2;
        private C1.Win.C1InputPanel.InputGroupHeader inputGroupHeader2;
        private C1.Win.C1InputPanel.InputLabel inputLabel6;
        private C1.Win.C1InputPanel.InputTextBox inputTextBox3;
        private C1.Win.C1InputPanel.InputImage inputImage1;
    }
}