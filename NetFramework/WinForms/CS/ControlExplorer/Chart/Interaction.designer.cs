namespace ControlExplorer.Chart
{
    partial class Interaction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Interaction));
            this.c1Chart1 = new C1.Win.C1Chart.C1Chart();
            this.c1InputPanel1 = new C1.Win.C1InputPanel.C1InputPanel();
            this.label = new C1.Win.C1InputPanel.InputLabel();
            this.inputSeparator1 = new C1.Win.C1InputPanel.InputSeparator();
            this.inputLabel1 = new C1.Win.C1InputPanel.InputLabel();
            this.comboLocations = new C1.Win.C1InputPanel.InputComboBox();
            this.inputOption1 = new C1.Win.C1InputPanel.InputOption();
            this.inputOption2 = new C1.Win.C1InputPanel.InputOption();
            this.inputGroupHeader1 = new C1.Win.C1InputPanel.InputGroupHeader();
            this.checkConductivity = new C1.Win.C1InputPanel.InputCheckBox();
            this.checkPh = new C1.Win.C1InputPanel.InputCheckBox();
            this.checkTemperature = new C1.Win.C1InputPanel.InputCheckBox();
            this.checkPressure = new C1.Win.C1InputPanel.InputCheckBox();
            this.inputGroupHeader2 = new C1.Win.C1InputPanel.InputGroupHeader();
            this.inputLabel2 = new C1.Win.C1InputPanel.InputLabel();
            this.inputLabel3 = new C1.Win.C1InputPanel.InputLabel();
            this.inputLabel4 = new C1.Win.C1InputPanel.InputLabel();
            this.inputMenu1 = new C1.Win.C1InputPanel.InputMenu();
            this.btnZoomIn = new C1.Win.C1InputPanel.InputButton();
            this.btnZoomOut = new C1.Win.C1InputPanel.InputButton();
            this.btnReset = new C1.Win.C1InputPanel.InputButton();
            this.inputGroupHeader3 = new C1.Win.C1InputPanel.InputGroupHeader();
            this.chkChartAreaInverted = new C1.Win.C1InputPanel.InputCheckBox();
            this.chkAxisXReversed = new C1.Win.C1InputPanel.InputCheckBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            ((System.ComponentModel.ISupportInitialize)(this.c1Chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1InputPanel1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1Chart1
            // 
            this.c1Chart1.BackColor = System.Drawing.Color.White;
            this.c1Chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1Chart1.Location = new System.Drawing.Point(185, 0);
            this.c1Chart1.Name = "c1Chart1";
            this.c1Chart1.PropBag = resources.GetString("c1Chart1.PropBag");
            this.c1Chart1.Size = new System.Drawing.Size(465, 464);
            this.c1Chart1.TabIndex = 3;
            this.c1Chart1.DoubleClick += new System.EventHandler(this.c1Chart1_DoubleClick);
            // 
            // c1InputPanel1
            // 
            this.c1InputPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.c1InputPanel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.c1InputPanel1.Items.Add(this.label);
            this.c1InputPanel1.Items.Add(this.inputSeparator1);
            this.c1InputPanel1.Items.Add(this.inputLabel1);
            this.c1InputPanel1.Items.Add(this.comboLocations);
            this.c1InputPanel1.Items.Add(this.inputGroupHeader1);
            this.c1InputPanel1.Items.Add(this.checkConductivity);
            this.c1InputPanel1.Items.Add(this.checkPh);
            this.c1InputPanel1.Items.Add(this.checkTemperature);
            this.c1InputPanel1.Items.Add(this.checkPressure);
            this.c1InputPanel1.Items.Add(this.inputGroupHeader2);
            this.c1InputPanel1.Items.Add(this.inputLabel2);
            this.c1InputPanel1.Items.Add(this.inputLabel3);
            this.c1InputPanel1.Items.Add(this.inputLabel4);
            this.c1InputPanel1.Items.Add(this.inputMenu1);
            this.c1InputPanel1.Items.Add(this.inputGroupHeader3);
            this.c1InputPanel1.Items.Add(this.chkChartAreaInverted);
            this.c1InputPanel1.Items.Add(this.chkAxisXReversed);
            this.c1InputPanel1.Location = new System.Drawing.Point(0, 0);
            this.c1InputPanel1.Name = "c1InputPanel1";
            this.c1InputPanel1.Size = new System.Drawing.Size(185, 464);
            this.c1InputPanel1.TabIndex = 4;
            // 
            // label
            // 
            this.label.Break = C1.Win.C1InputPanel.BreakType.Row;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Name = "label";
            this.label.Text = "Label";
            // 
            // inputSeparator1
            // 
            this.inputSeparator1.Name = "inputSeparator1";
            this.inputSeparator1.Width = 161;
            // 
            // inputLabel1
            // 
            this.inputLabel1.Name = "inputLabel1";
            this.inputLabel1.Text = "Data Source:";
            // 
            // comboLocations
            // 
            this.comboLocations.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList;
            this.comboLocations.Items.Add(this.inputOption1);
            this.comboLocations.Items.Add(this.inputOption2);
            this.comboLocations.Name = "comboLocations";
            this.comboLocations.SelectedIndexChanged += new System.EventHandler(this.comboLocations_SelectedIndexChanged);
            // 
            // inputOption1
            // 
            this.inputOption1.Name = "inputOption1";
            this.inputOption1.Text = "Dubai.xlsx";
            // 
            // inputOption2
            // 
            this.inputOption2.Name = "inputOption2";
            this.inputOption2.Text = "Houston.xlsx";
            // 
            // inputGroupHeader1
            // 
            this.inputGroupHeader1.Name = "inputGroupHeader1";
            this.inputGroupHeader1.Text = "Legend";
            // 
            // checkConductivity
            // 
            this.checkConductivity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(160)))));
            this.checkConductivity.Name = "checkConductivity";
            this.checkConductivity.Text = "Conductivity";
            this.checkConductivity.CheckedChanged += new System.EventHandler(this.checkConductivity_CheckedChanged);
            // 
            // checkPh
            // 
            this.checkPh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(126)))), ((int)(((byte)(52)))));
            this.checkPh.Name = "checkPh";
            this.checkPh.Text = "Ph";
            this.checkPh.CheckedChanged += new System.EventHandler(this.checkPh_CheckedChanged);
            // 
            // checkTemperature
            // 
            this.checkTemperature.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(32)))), ((int)(((byte)(132)))));
            this.checkTemperature.Name = "checkTemperature";
            this.checkTemperature.Text = "Temperature";
            this.checkTemperature.CheckedChanged += new System.EventHandler(this.checkTemperature_CheckedChanged);
            // 
            // checkPressure
            // 
            this.checkPressure.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(2)))), ((int)(((byte)(153)))));
            this.checkPressure.Name = "checkPressure";
            this.checkPressure.Text = "Pressure";
            this.checkPressure.CheckedChanged += new System.EventHandler(this.checkPressure_CheckedChanged);
            // 
            // inputGroupHeader2
            // 
            this.inputGroupHeader2.Name = "inputGroupHeader2";
            this.inputGroupHeader2.Text = "Actions";
            // 
            // inputLabel2
            // 
            this.inputLabel2.Break = C1.Win.C1InputPanel.BreakType.Row;
            this.inputLabel2.Name = "inputLabel2";
            this.inputLabel2.Text = "Zoom: Mouse";
            // 
            // inputLabel3
            // 
            this.inputLabel3.Break = C1.Win.C1InputPanel.BreakType.Row;
            this.inputLabel3.Name = "inputLabel3";
            this.inputLabel3.Text = "Scale: CTRL + Mouse";
            // 
            // inputLabel4
            // 
            this.inputLabel4.Break = C1.Win.C1InputPanel.BreakType.Row;
            this.inputLabel4.Name = "inputLabel4";
            this.inputLabel4.Text = "Translate: Shift + Mouse";
            // 
            // inputMenu1
            // 
            this.inputMenu1.Image = global::ControlExplorer.Properties.Resources.Zoom;
            this.inputMenu1.Items.Add(this.btnZoomIn);
            this.inputMenu1.Items.Add(this.btnZoomOut);
            this.inputMenu1.Items.Add(this.btnReset);
            this.inputMenu1.Name = "inputMenu1";
            this.inputMenu1.Text = "Zoom";
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Text = "Zoom In";
            this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Text = "Zoom Out";
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
            // 
            // btnReset
            // 
            this.btnReset.Name = "btnReset";
            this.btnReset.Text = "Reset";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // inputGroupHeader3
            // 
            this.inputGroupHeader3.Name = "inputGroupHeader3";
            this.inputGroupHeader3.Text = "Chart Area";
            // 
            // chkChartAreaInverted
            // 
            this.chkChartAreaInverted.Name = "chkChartAreaInverted";
            this.chkChartAreaInverted.Text = "Inverted";
            this.chkChartAreaInverted.CheckedChanged += new System.EventHandler(this.chkChartAreaInverted_CheckedChanged);
            // 
            // chkAxisXReversed
            // 
            this.chkAxisXReversed.Name = "chkAxisXReversed";
            this.chkAxisXReversed.Text = "AxisX.Reversed";
            this.chkAxisXReversed.CheckedChanged += new System.EventHandler(this.chkAxisXReversed_CheckedChanged);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(185, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 464);
            this.splitter1.TabIndex = 5;
            this.splitter1.TabStop = false;
            // 
            // Interaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 464);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.c1Chart1);
            this.Controls.Add(this.c1InputPanel1);
            this.Name = "Interaction";
            this.Text = "Interaction";
            this.Load += new System.EventHandler(this.Interaction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1Chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1InputPanel1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1Chart.C1Chart c1Chart1;
        private C1.Win.C1InputPanel.C1InputPanel c1InputPanel1;
        private C1.Win.C1InputPanel.InputLabel inputLabel1;
        private C1.Win.C1InputPanel.InputComboBox comboLocations;
        private C1.Win.C1InputPanel.InputSeparator inputSeparator1;
        private C1.Win.C1InputPanel.InputGroupHeader inputGroupHeader1;
        private C1.Win.C1InputPanel.InputCheckBox checkConductivity;
        private C1.Win.C1InputPanel.InputCheckBox checkPh;
        private C1.Win.C1InputPanel.InputCheckBox checkTemperature;
        private C1.Win.C1InputPanel.InputCheckBox checkPressure;
        private C1.Win.C1InputPanel.InputOption inputOption1;
        private C1.Win.C1InputPanel.InputOption inputOption2;
        private C1.Win.C1InputPanel.InputLabel label;
        private C1.Win.C1InputPanel.InputGroupHeader inputGroupHeader2;
        private C1.Win.C1InputPanel.InputLabel inputLabel2;
        private C1.Win.C1InputPanel.InputLabel inputLabel3;
        private C1.Win.C1InputPanel.InputLabel inputLabel4;
        private System.Windows.Forms.Splitter splitter1;
        private C1.Win.C1InputPanel.InputMenu inputMenu1;
        private C1.Win.C1InputPanel.InputButton btnZoomIn;
        private C1.Win.C1InputPanel.InputButton btnZoomOut;
        private C1.Win.C1InputPanel.InputButton btnReset;
        private C1.Win.C1InputPanel.InputGroupHeader inputGroupHeader3;
        private C1.Win.C1InputPanel.InputCheckBox chkChartAreaInverted;
        private C1.Win.C1InputPanel.InputCheckBox chkAxisXReversed;
    }
}