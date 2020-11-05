namespace FlexRadarIntro.Samples
{
    partial class RadarChart
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
            C1.Chart.ElementSize elementSize2 = new C1.Chart.ElementSize();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxChartType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxStacking = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxPalette = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownStartingAngle = new System.Windows.Forms.NumericUpDown();
            this.checkBoxReversed = new System.Windows.Forms.CheckBox();
            this.flexRadar = new C1.Win.Chart.FlexRadar();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStartingAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flexRadar)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flexRadar, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(640, 214);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.comboBoxChartType);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.comboBoxStacking);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.comboBoxPalette);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.numericUpDownStartingAngle);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxReversed);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(634, 27);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Chart type:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxChartType
            // 
            this.comboBoxChartType.BackColor = System.Drawing.Color.White;
            this.comboBoxChartType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChartType.FormattingEnabled = true;
            this.comboBoxChartType.Location = new System.Drawing.Point(64, 3);
            this.comboBoxChartType.Name = "comboBoxChartType";
            this.comboBoxChartType.Size = new System.Drawing.Size(77, 21);
            this.comboBoxChartType.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Stacking:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxStacking
            // 
            this.comboBoxStacking.BackColor = System.Drawing.Color.White;
            this.comboBoxStacking.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStacking.FormattingEnabled = true;
            this.comboBoxStacking.Location = new System.Drawing.Point(202, 3);
            this.comboBoxStacking.Name = "comboBoxStacking";
            this.comboBoxStacking.Size = new System.Drawing.Size(77, 21);
            this.comboBoxStacking.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(285, 3);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Palette:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxPalette
            // 
            this.comboBoxPalette.BackColor = System.Drawing.Color.White;
            this.comboBoxPalette.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPalette.FormattingEnabled = true;
            this.comboBoxPalette.Location = new System.Drawing.Point(331, 3);
            this.comboBoxPalette.Name = "comboBoxPalette";
            this.comboBoxPalette.Size = new System.Drawing.Size(77, 21);
            this.comboBoxPalette.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(414, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Starting angle:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numericUpDownStartingAngle
            // 
            this.numericUpDownStartingAngle.DecimalPlaces = 1;
            this.numericUpDownStartingAngle.Increment = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDownStartingAngle.Location = new System.Drawing.Point(492, 3);
            this.numericUpDownStartingAngle.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numericUpDownStartingAngle.Name = "numericUpDownStartingAngle";
            this.numericUpDownStartingAngle.Size = new System.Drawing.Size(38, 20);
            this.numericUpDownStartingAngle.TabIndex = 11;
            this.numericUpDownStartingAngle.ValueChanged += new System.EventHandler(this.numericUpDownStartingAngle_ValueChanged);
            // 
            // checkBoxReversed
            // 
            this.checkBoxReversed.AutoSize = true;
            this.checkBoxReversed.Location = new System.Drawing.Point(536, 3);
            this.checkBoxReversed.Name = "checkBoxReversed";
            this.checkBoxReversed.Size = new System.Drawing.Size(72, 17);
            this.checkBoxReversed.TabIndex = 12;
            this.checkBoxReversed.Text = "Reversed";
            this.checkBoxReversed.UseVisualStyleBackColor = true;
            this.checkBoxReversed.CheckedChanged += new System.EventHandler(this.checkBoxReversed_CheckedChanged);
            // 
            // flexRadar
            // 
            this.flexRadar.AxisX.Chart = this.flexRadar;
            this.flexRadar.AxisY.Chart = this.flexRadar;
            this.flexRadar.ChartType = C1.Chart.RadarChartType.Line;
            this.flexRadar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flexRadar.Legend.Orientation = C1.Chart.Orientation.Auto;
            this.flexRadar.Legend.Position = C1.Chart.Position.Right;
            this.flexRadar.Legend.Title = null;
            this.flexRadar.Location = new System.Drawing.Point(10, 43);
            this.flexRadar.Margin = new System.Windows.Forms.Padding(10);
            this.flexRadar.Name = "flexRadar";
            elementSize2.SizeType = C1.Chart.ElementSizeType.Percentage;
            elementSize2.Value = 70D;
            this.flexRadar.Options.ClusterSize = elementSize2;
            this.flexRadar.PlotMargin = new System.Windows.Forms.Padding(0);
            this.flexRadar.Reversed = false;
            this.flexRadar.SelectedSeries = null;
            this.flexRadar.SelectionStyle.StrokeColor = System.Drawing.Color.Red;
            this.flexRadar.Size = new System.Drawing.Size(620, 161);
            this.flexRadar.StartAngle = 0D;
            this.flexRadar.TabIndex = 1;
            // 
            // 
            // 
            this.flexRadar.ToolTip.Content = "{value}";
            // 
            // RadarChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "RadarChart";
            this.Size = new System.Drawing.Size(640, 214);
            this.Load += new System.EventHandler(this.GettingStarted_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStartingAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flexRadar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private C1.Win.Chart.FlexRadar flexRadar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownStartingAngle;
        private System.Windows.Forms.CheckBox checkBoxReversed;
        private System.Windows.Forms.ComboBox comboBoxChartType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxStacking;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxPalette;
    }
}
