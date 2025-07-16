namespace ErrorProvider
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
            this.c1InputPanel1 = new C1.Win.InputPanel.C1InputPanel();
            this.inputGroupHeader1 = new C1.Win.InputPanel.InputGroupHeader();
            this.inputLabel1 = new C1.Win.InputPanel.InputLabel();
            this.inputTextBox1 = new C1.Win.InputPanel.InputTextBox();
            this.inputLabel2 = new C1.Win.InputPanel.InputLabel();
            this.inputNumericBox1 = new C1.Win.InputPanel.InputNumericBox();
            this.inputLabel5 = new C1.Win.InputPanel.InputLabel();
            this.inputNumericBox2 = new C1.Win.InputPanel.InputNumericBox();
            this.inputLabel4 = new C1.Win.InputPanel.InputLabel();
            this.inputTimePicker1 = new C1.Win.InputPanel.InputTimePicker();
            this.inputLabel3 = new C1.Win.InputPanel.InputLabel();
            this.inputCheckBox1 = new C1.Win.InputPanel.InputCheckBox();
            this.inputCheckBox2 = new C1.Win.InputPanel.InputCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.c1InputPanel1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1InputPanel1
            // 
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
            this.c1InputPanel1.Location = new System.Drawing.Point(0, 0);
            this.c1InputPanel1.Name = "c1InputPanel1";
            this.c1InputPanel1.Size = new System.Drawing.Size(443, 171);
            this.c1InputPanel1.TabIndex = 0;
            // 
            // inputGroupHeader1
            // 
            this.inputGroupHeader1.Text = "ErrorProvider Demo";
            // 
            // inputLabel1
            // 
            this.inputLabel1.Text = "Type something that starts with \'a\':";
            this.inputLabel1.Width = 236;
            // 
            // inputTextBox1
            // 
            this.inputTextBox1.ElementWidth = 180;
            this.inputTextBox1.Text = "acceptable...";
            this.inputTextBox1.ToolTipText = "This is an <b>InputTextBox</b>.<br>What you type here doesn\'t really matter, as l" +
                "ong as it starts with \'a\'...";
            this.inputTextBox1.Validating += new System.ComponentModel.CancelEventHandler(this.inputTextBox1_Validating);
            // 
            // inputLabel2
            // 
            this.inputLabel2.Text = "Enter an even value:";
            this.inputLabel2.Width = 236;
            // 
            // inputNumericBox1
            // 
            this.inputNumericBox1.Format = null;
            this.inputNumericBox1.ToolTipText = "This is an <b>InputNumericBox</b>.<br>It only accepts even numbers.";
            this.inputNumericBox1.Value = new decimal(new int[] {
            98,
            0,
            0,
            0});
            this.inputNumericBox1.ValueChanged += new System.EventHandler(this.inputNumericBox1_ValueChanged);
            this.inputNumericBox1.Validating += new System.ComponentModel.CancelEventHandler(this.inputNumericBox1_Validating);
            // 
            // inputLabel5
            // 
            this.inputLabel5.Text = "Enter a value that totals 100 or more:";
            this.inputLabel5.Width = 236;
            // 
            // inputNumericBox2
            // 
            this.inputNumericBox2.Format = null;
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
            this.inputLabel4.Text = "Enter a time after 12:00:";
            this.inputLabel4.Width = 236;
            // 
            // inputTimePicker1
            // 
            this.inputTimePicker1.ToolTipText = "This is an <b>InputTimePicker</b>.<br>The time you enter here shold be less than " +
                "12:00 (noon).";
            this.inputTimePicker1.Value = System.TimeSpan.Parse("12:01:00");
            this.inputTimePicker1.Validating += new System.ComponentModel.CancelEventHandler(this.inputTimePicker1_Validating);
            // 
            // inputLabel3
            // 
            this.inputLabel3.Text = "Check at least one box:";
            this.inputLabel3.Width = 236;
            // 
            // inputCheckBox1
            // 
            this.inputCheckBox1.Break = C1.Win.InputPanel.BreakType.None;
            this.inputCheckBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.inputCheckBox1.ToolTipText = "This is an <b>InputCheckBox<b>.<br>Please check at least one of the boxes before " +
                "proceeding.";
            this.inputCheckBox1.CheckedChanged += new System.EventHandler(this.inputCheckBox1_CheckedChanged);
            // 
            // inputCheckBox2
            // 
            this.inputCheckBox2.ToolTipText = "This is an <b>InputCheckBox<b>.<br>Please check at least one of the boxes before " +
                "proceeding.";
            this.inputCheckBox2.CheckedChanged += new System.EventHandler(this.inputCheckBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 171);
            this.Controls.Add(this.c1InputPanel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C1InputPanel: Validation";
            ((System.ComponentModel.ISupportInitialize)(this.c1InputPanel1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.InputPanel.C1InputPanel c1InputPanel1;
        private C1.Win.InputPanel.InputGroupHeader inputGroupHeader1;
        private C1.Win.InputPanel.InputLabel inputLabel1;
        private C1.Win.InputPanel.InputTextBox inputTextBox1;
        private C1.Win.InputPanel.InputLabel inputLabel2;
        private C1.Win.InputPanel.InputNumericBox inputNumericBox1;
        private C1.Win.InputPanel.InputLabel inputLabel3;
        private C1.Win.InputPanel.InputCheckBox inputCheckBox1;
        private C1.Win.InputPanel.InputCheckBox inputCheckBox2;
        private C1.Win.InputPanel.InputLabel inputLabel5;
        private C1.Win.InputPanel.InputTimePicker inputTimePicker1;
        private C1.Win.InputPanel.InputNumericBox inputNumericBox2;
        private C1.Win.InputPanel.InputLabel inputLabel4;
    }
}

