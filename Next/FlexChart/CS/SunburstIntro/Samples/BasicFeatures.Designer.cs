namespace SunburstIntro.Samples
{
    partial class BasicFeatures
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownInnerRadius = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownOffset = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownStartAngle = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxPalette = new System.Windows.Forms.ComboBox();
            this.checkBoxReversed = new System.Windows.Forms.CheckBox();
            this.sunburst = new C1.Win.Chart.Sunburst();
            this.comboBoxLabelPos = new System.Windows.Forms.ComboBox();
            this.comboBoxLabelOverlap = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInnerRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStartAngle)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.sunburst, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(443, 214);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.numericUpDownInnerRadius);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.numericUpDownOffset);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.numericUpDownStartAngle);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.comboBoxPalette);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxReversed);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.comboBoxLabelPos);
            this.flowLayoutPanel1.Controls.Add(this.label6);
            this.flowLayoutPanel1.Controls.Add(this.comboBoxLabelOverlap);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(437, 80);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "InnerRadius:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numericUpDownInnerRadius
            // 
            this.numericUpDownInnerRadius.DecimalPlaces = 1;
            this.numericUpDownInnerRadius.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownInnerRadius.Location = new System.Drawing.Point(76, 3);
            this.numericUpDownInnerRadius.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownInnerRadius.Name = "numericUpDownInnerRadius";
            this.numericUpDownInnerRadius.Size = new System.Drawing.Size(38, 20);
            this.numericUpDownInnerRadius.TabIndex = 2;
            this.numericUpDownInnerRadius.ValueChanged += new System.EventHandler(this.numericUpDownInnerRadius_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Offset:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numericUpDownOffset
            // 
            this.numericUpDownOffset.DecimalPlaces = 1;
            this.numericUpDownOffset.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownOffset.Location = new System.Drawing.Point(164, 3);
            this.numericUpDownOffset.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownOffset.Name = "numericUpDownOffset";
            this.numericUpDownOffset.Size = new System.Drawing.Size(38, 20);
            this.numericUpDownOffset.TabIndex = 4;
            this.numericUpDownOffset.ValueChanged += new System.EventHandler(this.numericUpDownOffset_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "StartAngle:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numericUpDownStartAngle
            // 
            this.numericUpDownStartAngle.Increment = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.numericUpDownStartAngle.Location = new System.Drawing.Point(273, 3);
            this.numericUpDownStartAngle.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numericUpDownStartAngle.Name = "numericUpDownStartAngle";
            this.numericUpDownStartAngle.Size = new System.Drawing.Size(38, 20);
            this.numericUpDownStartAngle.TabIndex = 6;
            this.numericUpDownStartAngle.ValueChanged += new System.EventHandler(this.numericUpDownStartAngle_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(317, 3);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Palette:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxPalette
            // 
            this.comboBoxPalette.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPalette.FormattingEnabled = true;
            this.comboBoxPalette.Location = new System.Drawing.Point(3, 29);
            this.comboBoxPalette.Name = "comboBoxPalette";
            this.comboBoxPalette.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPalette.TabIndex = 8;
            this.comboBoxPalette.SelectedIndexChanged += new System.EventHandler(this.comboBoxPalette_SelectedIndexChanged);
            // 
            // checkBoxReversed
            // 
            this.checkBoxReversed.AutoSize = true;
            this.flowLayoutPanel1.SetFlowBreak(this.checkBoxReversed, true);
            this.checkBoxReversed.Location = new System.Drawing.Point(130, 29);
            this.checkBoxReversed.Name = "checkBoxReversed";
            this.checkBoxReversed.Size = new System.Drawing.Size(72, 17);
            this.checkBoxReversed.TabIndex = 9;
            this.checkBoxReversed.Text = "Reversed";
            this.checkBoxReversed.UseVisualStyleBackColor = true;
            this.checkBoxReversed.CheckedChanged += new System.EventHandler(this.checkBoxReversed_CheckedChanged);
            // 
            // sunburst
            // 
            this.sunburst.ChildItemsPath = null;
            this.sunburst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sunburst.Drilldown = false;
            this.sunburst.Legend.ItemMaxWidth = 0;
            this.sunburst.Legend.Orientation = C1.Chart.Orientation.Auto;
            this.sunburst.Legend.Position = C1.Chart.Position.Right;
            this.sunburst.Legend.Reversed = false;
            this.sunburst.Legend.TextWrapping = C1.Chart.TextWrapping.None;
            this.sunburst.Legend.Title = null;
            this.sunburst.Location = new System.Drawing.Point(3, 89);
            this.sunburst.Name = "sunburst";
            this.sunburst.SelectionStyle.StrokeColor = System.Drawing.Color.Red;
            this.sunburst.Size = new System.Drawing.Size(437, 122);
            this.sunburst.TabIndex = 1;
            // 
            // 
            // 
            this.sunburst.ToolTip.Content = "{value}";
            // 
            // comboBoxLabelPos
            // 
            this.comboBoxLabelPos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLabelPos.FormattingEnabled = true;
            this.comboBoxLabelPos.Location = new System.Drawing.Point(84, 56);
            this.comboBoxLabelPos.Name = "comboBoxLabelPos";
            this.comboBoxLabelPos.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLabelPos.TabIndex = 10;
            this.comboBoxLabelPos.SelectedIndexChanged += new System.EventHandler(this.comboBoxLabelPos_SelectedIndexChanged);
            // 
            // comboBoxLabelOverlap
            // 
            this.comboBoxLabelOverlap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLabelOverlap.FormattingEnabled = true;
            this.comboBoxLabelOverlap.Location = new System.Drawing.Point(284, 56);
            this.comboBoxLabelOverlap.Name = "comboBoxLabelOverlap";
            this.comboBoxLabelOverlap.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLabelOverlap.TabIndex = 11;
            this.comboBoxLabelOverlap.SelectedIndexChanged += new System.EventHandler(this.comboBoxLabelOverlap_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 56);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Label position:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(211, 56);
            this.label6.Margin = new System.Windows.Forms.Padding(3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Overlapping:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BasicFeatures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "BasicFeatures";
            this.Size = new System.Drawing.Size(443, 214);
            this.Load += new System.EventHandler(this.BasicFeatures_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInnerRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStartAngle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private C1.Win.Chart.Sunburst sunburst;
        private System.Windows.Forms.NumericUpDown numericUpDownInnerRadius;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownOffset;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownStartAngle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxPalette;
        private System.Windows.Forms.CheckBox checkBoxReversed;
        private System.Windows.Forms.ComboBox comboBoxLabelPos;
        private System.Windows.Forms.ComboBox comboBoxLabelOverlap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}
