namespace FlexChartSerializer
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
            C1.Chart.ElementSize elementSize1 = new C1.Chart.ElementSize();
            C1.Win.Chart.Series series1 = new C1.Win.Chart.Series();
            C1.Win.Chart.FlexPieSlice flexPieSlice1 = new C1.Win.Chart.FlexPieSlice();
            C1.Win.Chart.FlexPieSlice flexPieSlice2 = new C1.Win.Chart.FlexPieSlice();
            C1.Win.Chart.FlexPieSlice flexPieSlice3 = new C1.Win.Chart.FlexPieSlice();
            C1.Win.Chart.FlexPieSlice flexPieSlice4 = new C1.Win.Chart.FlexPieSlice();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSerialize = new System.Windows.Forms.Button();
            this.flexChart1 = new C1.Win.Chart.FlexChart();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageXml = new System.Windows.Forms.TabPage();
            this.txtXml = new System.Windows.Forms.TextBox();
            this.tabPageJson = new System.Windows.Forms.TabPage();
            this.txtJson = new System.Windows.Forms.TextBox();
            this.tabPageBinary = new System.Windows.Forms.TabPage();
            this.txtBinary = new System.Windows.Forms.TextBox();
            this.tabBase64 = new System.Windows.Forms.TabPage();
            this.txtBase64 = new System.Windows.Forms.TextBox();
            this.btnDeserializeTab = new System.Windows.Forms.Button();
            this.btnSaveTabToFile = new System.Windows.Forms.Button();
            this.btnDeserializeFromFile = new System.Windows.Forms.Button();
            this.btnSerializeToFile = new System.Windows.Forms.Button();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPageFlexChart = new System.Windows.Forms.TabPage();
            this.tabPageFlexPie = new System.Windows.Forms.TabPage();
            this.flexPie1 = new C1.Win.Chart.FlexPie();
            ((System.ComponentModel.ISupportInitialize)(this.flexChart1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageXml.SuspendLayout();
            this.tabPageJson.SuspendLayout();
            this.tabPageBinary.SuspendLayout();
            this.tabBase64.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPageFlexChart.SuspendLayout();
            this.tabPageFlexPie.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSerialize
            // 
            this.btnSerialize.Location = new System.Drawing.Point(14, 478);
            this.btnSerialize.Name = "btnSerialize";
            this.btnSerialize.Size = new System.Drawing.Size(135, 30);
            this.btnSerialize.TabIndex = 0;
            this.btnSerialize.Text = "Serialize To Tabs";
            this.btnSerialize.UseVisualStyleBackColor = true;
            this.btnSerialize.Click += new System.EventHandler(this.btnSerialize_Click);
            // 
            // flexChart1
            // 
            this.flexChart1.AxisX.Chart = this.flexChart1;
            this.flexChart1.AxisX.Position = C1.Chart.Position.Bottom;
            this.flexChart1.AxisY.AxisLine = false;
            this.flexChart1.AxisY.Chart = this.flexChart1;
            this.flexChart1.AxisY.MajorGrid = true;
            this.flexChart1.AxisY.MajorTickMarks = C1.Chart.TickMark.None;
            this.flexChart1.AxisY.Position = C1.Chart.Position.Left;
            this.flexChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flexChart1.Legend.Orientation = C1.Chart.Orientation.Auto;
            this.flexChart1.Legend.Position = C1.Chart.Position.Right;
            this.flexChart1.Legend.Title = null;
            this.flexChart1.Location = new System.Drawing.Point(3, 3);
            this.flexChart1.Name = "flexChart1";
            elementSize1.SizeType = C1.Chart.ElementSizeType.Percentage;
            elementSize1.Value = 70D;
            this.flexChart1.Options.ClusterSize = elementSize1;
            this.flexChart1.PlotMargin = new System.Windows.Forms.Padding(0);
            this.flexChart1.SelectedSeries = null;
            this.flexChart1.SelectionStyle.StrokeColor = System.Drawing.Color.Red;
            series1.Name = "Series 1";
            series1.Style.StrokeWidth = 2F;
            this.flexChart1.Series.Add(series1);
            this.flexChart1.Size = new System.Drawing.Size(418, 428);
            this.flexChart1.TabIndex = 1;
            this.flexChart1.Text = "flexChart1";
            // 
            // 
            // 
            this.flexChart1.ToolTip.Content = "{value}";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageXml);
            this.tabControl1.Controls.Add(this.tabPageJson);
            this.tabControl1.Controls.Add(this.tabPageBinary);
            this.tabControl1.Controls.Add(this.tabBase64);
            this.tabControl1.Location = new System.Drawing.Point(450, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(491, 705);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPageXml
            // 
            this.tabPageXml.Controls.Add(this.txtXml);
            this.tabPageXml.Location = new System.Drawing.Point(4, 22);
            this.tabPageXml.Name = "tabPageXml";
            this.tabPageXml.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageXml.Size = new System.Drawing.Size(483, 679);
            this.tabPageXml.TabIndex = 0;
            this.tabPageXml.Text = "Xml";
            this.tabPageXml.UseVisualStyleBackColor = true;
            // 
            // txtXml
            // 
            this.txtXml.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtXml.Location = new System.Drawing.Point(3, 3);
            this.txtXml.Multiline = true;
            this.txtXml.Name = "txtXml";
            this.txtXml.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtXml.Size = new System.Drawing.Size(477, 673);
            this.txtXml.TabIndex = 0;
            // 
            // tabPageJson
            // 
            this.tabPageJson.Controls.Add(this.txtJson);
            this.tabPageJson.Location = new System.Drawing.Point(4, 22);
            this.tabPageJson.Name = "tabPageJson";
            this.tabPageJson.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageJson.Size = new System.Drawing.Size(483, 679);
            this.tabPageJson.TabIndex = 1;
            this.tabPageJson.Text = "Json";
            this.tabPageJson.UseVisualStyleBackColor = true;
            // 
            // txtJson
            // 
            this.txtJson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtJson.Location = new System.Drawing.Point(3, 3);
            this.txtJson.Multiline = true;
            this.txtJson.Name = "txtJson";
            this.txtJson.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtJson.Size = new System.Drawing.Size(477, 673);
            this.txtJson.TabIndex = 0;
            // 
            // tabPageBinary
            // 
            this.tabPageBinary.Controls.Add(this.txtBinary);
            this.tabPageBinary.Location = new System.Drawing.Point(4, 22);
            this.tabPageBinary.Name = "tabPageBinary";
            this.tabPageBinary.Size = new System.Drawing.Size(483, 679);
            this.tabPageBinary.TabIndex = 2;
            this.tabPageBinary.Text = "Binary";
            this.tabPageBinary.UseVisualStyleBackColor = true;
            // 
            // txtBinary
            // 
            this.txtBinary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBinary.Font = new System.Drawing.Font("Lucida Console", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBinary.Location = new System.Drawing.Point(0, 0);
            this.txtBinary.Multiline = true;
            this.txtBinary.Name = "txtBinary";
            this.txtBinary.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBinary.Size = new System.Drawing.Size(483, 679);
            this.txtBinary.TabIndex = 0;
            // 
            // tabBase64
            // 
            this.tabBase64.Controls.Add(this.txtBase64);
            this.tabBase64.Location = new System.Drawing.Point(4, 22);
            this.tabBase64.Name = "tabBase64";
            this.tabBase64.Size = new System.Drawing.Size(483, 679);
            this.tabBase64.TabIndex = 3;
            this.tabBase64.Text = "Base64";
            this.tabBase64.UseVisualStyleBackColor = true;
            // 
            // txtBase64
            // 
            this.txtBase64.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBase64.Font = new System.Drawing.Font("Lucida Console", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBase64.Location = new System.Drawing.Point(0, 0);
            this.txtBase64.Multiline = true;
            this.txtBase64.Name = "txtBase64";
            this.txtBase64.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBase64.Size = new System.Drawing.Size(483, 679);
            this.txtBase64.TabIndex = 0;
            // 
            // btnDeserializeTab
            // 
            this.btnDeserializeTab.Location = new System.Drawing.Point(41, 514);
            this.btnDeserializeTab.Name = "btnDeserializeTab";
            this.btnDeserializeTab.Size = new System.Drawing.Size(162, 30);
            this.btnDeserializeTab.TabIndex = 3;
            this.btnDeserializeTab.Text = "Deserialize Tab";
            this.btnDeserializeTab.UseVisualStyleBackColor = true;
            this.btnDeserializeTab.Click += new System.EventHandler(this.btnDeserializeTab_Click);
            // 
            // btnSaveTabToFile
            // 
            this.btnSaveTabToFile.Location = new System.Drawing.Point(41, 550);
            this.btnSaveTabToFile.Name = "btnSaveTabToFile";
            this.btnSaveTabToFile.Size = new System.Drawing.Size(162, 30);
            this.btnSaveTabToFile.TabIndex = 4;
            this.btnSaveTabToFile.Text = "Save Tab To File";
            this.btnSaveTabToFile.UseVisualStyleBackColor = true;
            this.btnSaveTabToFile.Click += new System.EventHandler(this.btnSaveTabToFile_Click);
            // 
            // btnDeserializeFromFile
            // 
            this.btnDeserializeFromFile.Location = new System.Drawing.Point(41, 645);
            this.btnDeserializeFromFile.Name = "btnDeserializeFromFile";
            this.btnDeserializeFromFile.Size = new System.Drawing.Size(162, 30);
            this.btnDeserializeFromFile.TabIndex = 6;
            this.btnDeserializeFromFile.Text = "Deserialize From File";
            this.btnDeserializeFromFile.UseVisualStyleBackColor = true;
            this.btnDeserializeFromFile.Click += new System.EventHandler(this.btnDeserializeFromFile_Click);
            // 
            // btnSerializeToFile
            // 
            this.btnSerializeToFile.Location = new System.Drawing.Point(14, 609);
            this.btnSerializeToFile.Name = "btnSerializeToFile";
            this.btnSerializeToFile.Size = new System.Drawing.Size(135, 30);
            this.btnSerializeToFile.TabIndex = 5;
            this.btnSerializeToFile.Text = "Serialize To File";
            this.btnSerializeToFile.UseVisualStyleBackColor = true;
            this.btnSerializeToFile.Click += new System.EventHandler(this.btnSerializeToFile_Click);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPageFlexChart);
            this.tabControl2.Controls.Add(this.tabPageFlexPie);
            this.tabControl2.Location = new System.Drawing.Point(14, 12);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(432, 460);
            this.tabControl2.TabIndex = 7;
            // 
            // tabPageFlexChart
            // 
            this.tabPageFlexChart.Controls.Add(this.flexChart1);
            this.tabPageFlexChart.Location = new System.Drawing.Point(4, 22);
            this.tabPageFlexChart.Name = "tabPageFlexChart";
            this.tabPageFlexChart.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFlexChart.Size = new System.Drawing.Size(424, 434);
            this.tabPageFlexChart.TabIndex = 0;
            this.tabPageFlexChart.Text = "FlexChart";
            this.tabPageFlexChart.UseVisualStyleBackColor = true;
            // 
            // tabPageFlexPie
            // 
            this.tabPageFlexPie.Controls.Add(this.flexPie1);
            this.tabPageFlexPie.Location = new System.Drawing.Point(4, 22);
            this.tabPageFlexPie.Name = "tabPageFlexPie";
            this.tabPageFlexPie.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFlexPie.Size = new System.Drawing.Size(424, 434);
            this.tabPageFlexPie.TabIndex = 1;
            this.tabPageFlexPie.Text = "FlexPie";
            this.tabPageFlexPie.UseVisualStyleBackColor = true;
            // 
            // flexPie1
            // 
            flexPieSlice1.Name = "Slice1";
            flexPieSlice1.Value = 1D;
            flexPieSlice2.Name = "Slice2";
            flexPieSlice2.Value = 2D;
            flexPieSlice3.Name = "Slice3";
            flexPieSlice3.Value = 3D;
            flexPieSlice4.Name = "Slice4";
            flexPieSlice4.Value = 4D;
            this.flexPie1.DataSource = new C1.Win.Chart.FlexPieSlice[] {
        flexPieSlice1,
        flexPieSlice2,
        flexPieSlice3,
        flexPieSlice4};
            this.flexPie1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flexPie1.Legend.Orientation = C1.Chart.Orientation.Auto;
            this.flexPie1.Legend.Position = C1.Chart.Position.Right;
            this.flexPie1.Legend.Title = null;
            this.flexPie1.Location = new System.Drawing.Point(3, 3);
            this.flexPie1.Name = "flexPie1";
            this.flexPie1.SelectionStyle.StrokeColor = System.Drawing.Color.Red;
            this.flexPie1.Size = new System.Drawing.Size(418, 428);
            this.flexPie1.TabIndex = 0;
            this.flexPie1.Text = "flexPie1";
            // 
            // 
            // 
            this.flexPie1.ToolTip.Content = "{value}";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 729);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.btnDeserializeFromFile);
            this.Controls.Add(this.btnSerializeToFile);
            this.Controls.Add(this.btnSaveTabToFile);
            this.Controls.Add(this.btnDeserializeTab);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnSerialize);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "FlexChart Serializer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.flexChart1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageXml.ResumeLayout(false);
            this.tabPageXml.PerformLayout();
            this.tabPageJson.ResumeLayout(false);
            this.tabPageJson.PerformLayout();
            this.tabPageBinary.ResumeLayout(false);
            this.tabPageBinary.PerformLayout();
            this.tabBase64.ResumeLayout(false);
            this.tabBase64.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPageFlexChart.ResumeLayout(false);
            this.tabPageFlexPie.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSerialize;
        private C1.Win.Chart.FlexChart flexChart1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageXml;
        private System.Windows.Forms.TextBox txtXml;
        private System.Windows.Forms.TabPage tabPageJson;
        private System.Windows.Forms.TextBox txtJson;
        private System.Windows.Forms.TabPage tabPageBinary;
        private System.Windows.Forms.TextBox txtBinary;
        private System.Windows.Forms.TabPage tabBase64;
        private System.Windows.Forms.TextBox txtBase64;
        private System.Windows.Forms.Button btnDeserializeTab;
        private System.Windows.Forms.Button btnSaveTabToFile;
        private System.Windows.Forms.Button btnDeserializeFromFile;
        private System.Windows.Forms.Button btnSerializeToFile;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPageFlexChart;
        private System.Windows.Forms.TabPage tabPageFlexPie;
        private C1.Win.Chart.FlexPie flexPie1;
    }
}

