namespace ControlExplorer.Chart
{
    partial class PieCharts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PieCharts));
            this.categorySales1 = new ControlExplorer.Chart.CategorySales();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.c1Chart1 = new C1.Win.C1Chart.C1Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radImageLabels = new System.Windows.Forms.RadioButton();
            this.radDefault = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.categorySales1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Chart1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // categorySales1
            // 
            this.categorySales1.Position = 0;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Beverages.gif");
            this.imageList1.Images.SetKeyName(1, "Condiments.gif");
            this.imageList1.Images.SetKeyName(2, "Confections.gif");
            this.imageList1.Images.SetKeyName(3, "Dairy.gif");
            this.imageList1.Images.SetKeyName(4, "Grains.gif");
            this.imageList1.Images.SetKeyName(5, "Meat.gif");
            this.imageList1.Images.SetKeyName(6, "Produce.gif");
            this.imageList1.Images.SetKeyName(7, "Seafood.gif");
            // 
            // c1Chart1
            // 
            this.c1Chart1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.c1Chart1.DataSource = this.categorySales1;
            this.c1Chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1Chart1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.c1Chart1.Interaction.Enabled = true;
            this.c1Chart1.Location = new System.Drawing.Point(0, 30);
            this.c1Chart1.Name = "c1Chart1";
            this.c1Chart1.PropBag = resources.GetString("c1Chart1.PropBag");
            this.c1Chart1.Size = new System.Drawing.Size(592, 416);
            this.c1Chart1.TabIndex = 1;
            this.c1Chart1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.c1Chart1_MouseClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(212)))), ((int)(((byte)(221)))));
            this.panel1.Controls.Add(this.radImageLabels);
            this.panel1.Controls.Add(this.radDefault);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 30);
            this.panel1.TabIndex = 2;
            // 
            // radImageLabels
            // 
            this.radImageLabels.AutoSize = true;
            this.radImageLabels.Location = new System.Drawing.Point(98, 3);
            this.radImageLabels.Name = "radImageLabels";
            this.radImageLabels.Size = new System.Drawing.Size(134, 17);
            this.radImageLabels.TabIndex = 1;
            this.radImageLabels.TabStop = true;
            this.radImageLabels.Text = "Image Labels (on-click)";
            this.radImageLabels.UseVisualStyleBackColor = true;
            // 
            // radDefault
            // 
            this.radDefault.AutoSize = true;
            this.radDefault.Checked = true;
            this.radDefault.Location = new System.Drawing.Point(12, 3);
            this.radDefault.Name = "radDefault";
            this.radDefault.Size = new System.Drawing.Size(80, 17);
            this.radDefault.TabIndex = 0;
            this.radDefault.TabStop = true;
            this.radDefault.Text = "Text Labels";
            this.radDefault.UseVisualStyleBackColor = true;
            this.radDefault.CheckedChanged += new System.EventHandler(this.radDefault_CheckedChanged);
            // 
            // PieCharts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 446);
            this.Controls.Add(this.c1Chart1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PieCharts";
            this.Text = "PieCharts";
            this.Load += new System.EventHandler(this.PieCharts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categorySales1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CategorySales categorySales1;
        private System.Windows.Forms.ImageList imageList1;
        private C1.Win.C1Chart.C1Chart c1Chart1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radImageLabels;
        private System.Windows.Forms.RadioButton radDefault;
    }
}