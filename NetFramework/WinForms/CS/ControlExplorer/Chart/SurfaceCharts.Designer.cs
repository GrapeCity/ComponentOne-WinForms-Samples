namespace ControlExplorer.Chart
{
    partial class SurfaceCharts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SurfaceCharts));
            this.categorySales1 = new ControlExplorer.Chart.CategorySales();
            this.c1Chart3D1 = new C1.Win.C1Chart3D.C1Chart3D();
            this.panel1 = new System.Windows.Forms.Panel();
            this.trkZAxis = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.trkYAxis = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trkXAxis = new System.Windows.Forms.TrackBar();
            this.cbProjections = new System.Windows.Forms.ComboBox();
            this.chk2DProjection = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbChartTypes = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.categorySales1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Chart3D1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkZAxis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkYAxis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkXAxis)).BeginInit();
            this.SuspendLayout();
            // 
            // categorySales1
            // 
            this.categorySales1.DataMember = "CategorySalesByQuarter";
            this.categorySales1.Position = 0;
            // 
            // c1Chart3D1
            // 
            this.c1Chart3D1.BackColor = System.Drawing.Color.White;
            this.c1Chart3D1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1Chart3D1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.c1Chart3D1.Location = new System.Drawing.Point(154, 0);
            this.c1Chart3D1.Name = "c1Chart3D1";
            this.c1Chart3D1.PropBag = resources.GetString("c1Chart3D1.PropBag");
            this.c1Chart3D1.Size = new System.Drawing.Size(438, 446);
            this.c1Chart3D1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.trkZAxis);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.trkYAxis);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.trkXAxis);
            this.panel1.Controls.Add(this.cbProjections);
            this.panel1.Controls.Add(this.chk2DProjection);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbChartTypes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(154, 446);
            this.panel1.TabIndex = 2;
            // 
            // trkZAxis
            // 
            this.trkZAxis.AutoSize = false;
            this.trkZAxis.Location = new System.Drawing.Point(12, 295);
            this.trkZAxis.Maximum = 360;
            this.trkZAxis.Name = "trkZAxis";
            this.trkZAxis.Size = new System.Drawing.Size(135, 32);
            this.trkZAxis.TabIndex = 9;
            this.trkZAxis.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trkZAxis.Value = 135;
            this.trkZAxis.Scroll += new System.EventHandler(this.trkZAxis_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Z Axis Rotation";
            // 
            // trkYAxis
            // 
            this.trkYAxis.AutoSize = false;
            this.trkYAxis.Location = new System.Drawing.Point(12, 244);
            this.trkYAxis.Maximum = 360;
            this.trkYAxis.Name = "trkYAxis";
            this.trkYAxis.Size = new System.Drawing.Size(135, 32);
            this.trkYAxis.TabIndex = 7;
            this.trkYAxis.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trkYAxis.Scroll += new System.EventHandler(this.trkYAxis_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Y-Axis Rotation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "X-Axis Rotation";
            // 
            // trkXAxis
            // 
            this.trkXAxis.AutoSize = false;
            this.trkXAxis.Location = new System.Drawing.Point(12, 193);
            this.trkXAxis.Maximum = 360;
            this.trkXAxis.Name = "trkXAxis";
            this.trkXAxis.Size = new System.Drawing.Size(135, 32);
            this.trkXAxis.TabIndex = 4;
            this.trkXAxis.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trkXAxis.Value = 45;
            this.trkXAxis.Scroll += new System.EventHandler(this.trkXAxis_Scroll);
            // 
            // cbProjections
            // 
            this.cbProjections.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProjections.FormattingEnabled = true;
            this.cbProjections.Location = new System.Drawing.Point(12, 104);
            this.cbProjections.Name = "cbProjections";
            this.cbProjections.Size = new System.Drawing.Size(135, 21);
            this.cbProjections.TabIndex = 3;
            this.cbProjections.Visible = false;
            this.cbProjections.SelectedIndexChanged += new System.EventHandler(this.cbProjections_SelectedIndexChanged);
            // 
            // chk2DProjection
            // 
            this.chk2DProjection.AutoSize = true;
            this.chk2DProjection.Location = new System.Drawing.Point(12, 81);
            this.chk2DProjection.Name = "chk2DProjection";
            this.chk2DProjection.Size = new System.Drawing.Size(90, 17);
            this.chk2DProjection.TabIndex = 2;
            this.chk2DProjection.Text = "2D Projection";
            this.chk2DProjection.UseVisualStyleBackColor = true;
            this.chk2DProjection.CheckedChanged += new System.EventHandler(this.chk2DProjection_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chart Type:";
            // 
            // cbChartTypes
            // 
            this.cbChartTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChartTypes.FormattingEnabled = true;
            this.cbChartTypes.Location = new System.Drawing.Point(12, 25);
            this.cbChartTypes.Name = "cbChartTypes";
            this.cbChartTypes.Size = new System.Drawing.Size(135, 21);
            this.cbChartTypes.TabIndex = 0;
            this.cbChartTypes.SelectedIndexChanged += new System.EventHandler(this.cbChartTypes_SelectedIndexChanged);
            // 
            // SurfaceCharts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 446);
            this.Controls.Add(this.c1Chart3D1);
            this.Controls.Add(this.panel1);
            this.Name = "SurfaceCharts";
            this.Text = "SurfaceCharts";
            this.Load += new System.EventHandler(this.SurfaceCharts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categorySales1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Chart3D1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkZAxis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkYAxis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkXAxis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CategorySales categorySales1;
        private C1.Win.C1Chart3D.C1Chart3D c1Chart3D1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbChartTypes;
        private System.Windows.Forms.ComboBox cbProjections;
        private System.Windows.Forms.CheckBox chk2DProjection;
        private System.Windows.Forms.TrackBar trkZAxis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trkYAxis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trkXAxis;

    }
}