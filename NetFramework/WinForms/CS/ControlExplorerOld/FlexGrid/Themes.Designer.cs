namespace ControlExplorer.FlexGrid
{
    partial class Themes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Themes));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.c1FlexGrid1 = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.c1DemoDataSet = new ControlExplorer.C1DemoDataSet();
            this.glass = new System.Windows.Forms.ImageList(this.components);
            this.mac = new System.Windows.Forms.ImageList(this.components);
            this.vista = new System.Windows.Forms.ImageList(this.components);
            this.steel = new System.Windows.Forms.ImageList(this.components);
            this.energy = new System.Windows.Forms.ImageList(this.components);
            this.notebook = new System.Windows.Forms.ImageList(this.components);
            this.checkBoxes = new System.Windows.Forms.ImageList(this.components);
            this.productsTableAdapter = new ControlExplorer.C1DemoDataSetTableAdapters.ProductsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1DemoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a theme:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(99, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(163, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // c1FlexGrid1
            // 
            this.c1FlexGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.c1FlexGrid1.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
            this.c1FlexGrid1.ColumnInfo = resources.GetString("c1FlexGrid1.ColumnInfo");
            this.c1FlexGrid1.DataSource = this.productsBindingSource;
            this.c1FlexGrid1.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None;
            this.c1FlexGrid1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1FlexGrid1.Location = new System.Drawing.Point(15, 45);
            this.c1FlexGrid1.Name = "c1FlexGrid1";
            this.c1FlexGrid1.Rows.Count = 1;
            this.c1FlexGrid1.Rows.DefaultSize = 19;
            this.c1FlexGrid1.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.None;
            this.c1FlexGrid1.Size = new System.Drawing.Size(565, 389);
            this.c1FlexGrid1.StyleInfo = resources.GetString("c1FlexGrid1.StyleInfo");
            this.c1FlexGrid1.TabIndex = 2;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.c1DemoDataSet;
            // 
            // c1DemoDataSet
            // 
            this.c1DemoDataSet.DataSetName = "C1DemoDataSet";
            this.c1DemoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // glass
            // 
            this.glass.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("glass.ImageStream")));
            this.glass.TransparentColor = System.Drawing.Color.Transparent;
            this.glass.Images.SetKeyName(0, "Glass_Alternate.png");
            this.glass.Images.SetKeyName(1, "Glass_Header.png");
            this.glass.Images.SetKeyName(2, "Glass_HeaderSelected.png");
            this.glass.Images.SetKeyName(3, "Glass_Normal.png");
            this.glass.Images.SetKeyName(4, "Glass_Selected.png");
            // 
            // mac
            // 
            this.mac.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("mac.ImageStream")));
            this.mac.TransparentColor = System.Drawing.Color.Transparent;
            this.mac.Images.SetKeyName(0, "Mac_Header.png");
            this.mac.Images.SetKeyName(1, "Mac_HeaderSelected.png");
            // 
            // vista
            // 
            this.vista.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("vista.ImageStream")));
            this.vista.TransparentColor = System.Drawing.Color.Transparent;
            this.vista.Images.SetKeyName(0, "Vista_Header.png");
            this.vista.Images.SetKeyName(1, "Vista_Highlight.png");
            // 
            // steel
            // 
            this.steel.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("steel.ImageStream")));
            this.steel.TransparentColor = System.Drawing.Color.Transparent;
            this.steel.Images.SetKeyName(0, "Steel_Header.png");
            this.steel.Images.SetKeyName(1, "Steel_HeaderSelected.png");
            // 
            // energy
            // 
            this.energy.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("energy.ImageStream")));
            this.energy.TransparentColor = System.Drawing.Color.Transparent;
            this.energy.Images.SetKeyName(0, "energy_head.png");
            this.energy.Images.SetKeyName(1, "energy_sel.png");
            // 
            // notebook
            // 
            this.notebook.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("notebook.ImageStream")));
            this.notebook.TransparentColor = System.Drawing.Color.Transparent;
            this.notebook.Images.SetKeyName(0, "notebook_side.png");
            // 
            // checkBoxes
            // 
            this.checkBoxes.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("checkBoxes.ImageStream")));
            this.checkBoxes.TransparentColor = System.Drawing.Color.Transparent;
            this.checkBoxes.Images.SetKeyName(0, "customUncheck1.png");
            this.checkBoxes.Images.SetKeyName(1, "customCheck1.png");
            this.checkBoxes.Images.SetKeyName(2, "customCheck2.png");
            this.checkBoxes.Images.SetKeyName(3, "customUncheck2.png");
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // Themes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 446);
            this.Controls.Add(this.c1FlexGrid1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "Themes";
            this.Text = "Themes";
            this.Load += new System.EventHandler(this.Themes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1DemoDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private C1.Win.C1FlexGrid.C1FlexGrid c1FlexGrid1;
        private System.Windows.Forms.ImageList glass;
        private System.Windows.Forms.ImageList mac;
        private System.Windows.Forms.ImageList vista;
        private System.Windows.Forms.ImageList steel;
        private System.Windows.Forms.ImageList energy;
        private System.Windows.Forms.ImageList notebook;
        private System.Windows.Forms.ImageList checkBoxes;
        private C1DemoDataSet c1DemoDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private ControlExplorer.C1DemoDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
    }
}