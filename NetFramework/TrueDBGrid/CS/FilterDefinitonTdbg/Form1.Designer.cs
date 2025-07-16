namespace FilterDefinitionTdbg
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.c1NWindDataSet = new FilterDefinitionTdbg.C1NWindDataSet();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new FilterDefinitionTdbg.C1NWindDataSetTableAdapters.CustomersTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEmpty = new System.Windows.Forms.Button();
            this.btnUS = new System.Windows.Forms.Button();
            this.btnEU = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnNonUSOwners = new System.Windows.Forms.Button();
            this.btnCustom = new System.Windows.Forms.Button();
            this.c1TrueDBGrid1 = new C1.Win.TrueDBGrid.C1TrueDBGrid();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1NWindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnCustom);
            this.panel1.Controls.Add(this.btnNonUSOwners);
            this.panel1.Controls.Add(this.btnEU);
            this.panel1.Controls.Add(this.btnUS);
            this.panel1.Controls.Add(this.btnEmpty);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(986, 100);
            this.panel1.TabIndex = 1;
            // 
            // c1NWindDataSet
            // 
            this.c1NWindDataSet.DataSetName = "C1NWindDataSet";
            this.c1NWindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.c1NWindDataSet;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(110, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filters:";
            // 
            // btnEmpty
            // 
            this.btnEmpty.BackColor = System.Drawing.Color.White;
            this.btnEmpty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpty.ForeColor = System.Drawing.Color.Black;
            this.btnEmpty.Location = new System.Drawing.Point(117, 49);
            this.btnEmpty.Name = "btnEmpty";
            this.btnEmpty.Size = new System.Drawing.Size(160, 45);
            this.btnEmpty.TabIndex = 1;
            this.btnEmpty.Text = "<Empty>";
            this.btnEmpty.UseVisualStyleBackColor = false;
            this.btnEmpty.Click += new System.EventHandler(this.btnEmpty_Click);
            // 
            // btnUS
            // 
            this.btnUS.BackColor = System.Drawing.Color.White;
            this.btnUS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUS.ForeColor = System.Drawing.Color.Gray;
            this.btnUS.Location = new System.Drawing.Point(283, 49);
            this.btnUS.Name = "btnUS";
            this.btnUS.Size = new System.Drawing.Size(160, 45);
            this.btnUS.TabIndex = 2;
            this.btnUS.Text = "USA";
            this.btnUS.UseVisualStyleBackColor = false;
            this.btnUS.Click += new System.EventHandler(this.btnUS_Click);
            // 
            // btnEU
            // 
            this.btnEU.BackColor = System.Drawing.Color.White;
            this.btnEU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEU.ForeColor = System.Drawing.Color.Gray;
            this.btnEU.Location = new System.Drawing.Point(449, 49);
            this.btnEU.Name = "btnEU";
            this.btnEU.Size = new System.Drawing.Size(160, 45);
            this.btnEU.TabIndex = 3;
            this.btnEU.Text = "EU";
            this.btnEU.UseVisualStyleBackColor = false;
            this.btnEU.Click += new System.EventHandler(this.btnEU_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.c1TrueDBGrid1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.panel2.Size = new System.Drawing.Size(986, 445);
            this.panel2.TabIndex = 2;
            // 
            // btnNonUSOwners
            // 
            this.btnNonUSOwners.BackColor = System.Drawing.Color.White;
            this.btnNonUSOwners.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNonUSOwners.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNonUSOwners.ForeColor = System.Drawing.Color.Gray;
            this.btnNonUSOwners.Location = new System.Drawing.Point(615, 49);
            this.btnNonUSOwners.Name = "btnNonUSOwners";
            this.btnNonUSOwners.Size = new System.Drawing.Size(160, 45);
            this.btnNonUSOwners.TabIndex = 4;
            this.btnNonUSOwners.Text = "Non-US owners";
            this.btnNonUSOwners.UseVisualStyleBackColor = false;
            this.btnNonUSOwners.Click += new System.EventHandler(this.btnNonUSOwners_Click);
            // 
            // btnCustom
            // 
            this.btnCustom.BackColor = System.Drawing.Color.White;
            this.btnCustom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustom.ForeColor = System.Drawing.Color.Indigo;
            this.btnCustom.Location = new System.Drawing.Point(781, 49);
            this.btnCustom.Name = "btnCustom";
            this.btnCustom.Size = new System.Drawing.Size(130, 45);
            this.btnCustom.TabIndex = 5;
            this.btnCustom.Text = "Custom";
            this.btnCustom.UseVisualStyleBackColor = false;
            this.btnCustom.Click += new System.EventHandler(this.btnCustom_Click);
            // 
            // c1TrueDBGrid1
            // 
            this.c1TrueDBGrid1.AllowColMove = false;
            this.c1TrueDBGrid1.CaptionHeight = 28;
            this.c1TrueDBGrid1.DataSource = this.customersBindingSource;
            this.c1TrueDBGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1TrueDBGrid1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.c1TrueDBGrid1.Images.Add(((System.Drawing.Image)(resources.GetObject("c1TrueDBGrid1.Images"))));
            this.c1TrueDBGrid1.LinesPerRow = 2;
            this.c1TrueDBGrid1.Location = new System.Drawing.Point(20, 0);
            this.c1TrueDBGrid1.Name = "c1TrueDBGrid1";
            this.c1TrueDBGrid1.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.c1TrueDBGrid1.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.c1TrueDBGrid1.PreviewInfo.ZoomFactor = 75D;
            this.c1TrueDBGrid1.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("c1TrueDBGrid1.PrintInfo.PageSettings")));
            this.c1TrueDBGrid1.RowHeight = 24;
            this.c1TrueDBGrid1.Size = new System.Drawing.Size(946, 445);
            this.c1TrueDBGrid1.TabIndex = 1;
            this.c1TrueDBGrid1.Text = "c1TrueDBGrid1";
            this.c1TrueDBGrid1.VisualStyle = C1.Win.TrueDBGrid.VisualStyle.Office2010Silver;
            this.c1TrueDBGrid1.PropBag = resources.GetString("c1TrueDBGrid1.PropBag");
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::FilterDefinitionTdbg.Properties.Resources.filter_data_1_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(3, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 82);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DarkGray;
            this.btnSave.BackgroundImage = global::FilterDefinitionTdbg.Properties.Resources.Save_1_;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.Gray;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSave.Location = new System.Drawing.Point(920, 49);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(46, 45);
            this.btnSave.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btnSave, "Save custom filter");
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(986, 545);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1NWindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private C1NWindDataSet c1NWindDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private C1NWindDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.Button btnEU;
        private System.Windows.Forms.Button btnUS;
        private System.Windows.Forms.Button btnEmpty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private C1.Win.TrueDBGrid.C1TrueDBGrid c1TrueDBGrid1;
        private System.Windows.Forms.Button btnCustom;
        private System.Windows.Forms.Button btnNonUSOwners;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

