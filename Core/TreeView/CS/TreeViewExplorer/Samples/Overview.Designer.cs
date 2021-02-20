namespace TreeViewExplorer.Samples
{
    partial class Overview
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
            C1.Win.TreeView.C1TreeColumn c1TreeColumn1 = new C1.Win.TreeView.C1TreeColumn();
            this.c1TreeView1 = new C1.Win.TreeView.C1TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.c1TreeView1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1TreeView1
            // 
            this.c1TreeView1.BindingInfo.DataMember = null;
            this.c1TreeView1.BindingInfo.KeyField = null;
            this.c1TreeView1.BindingInfo.ParentKeyField = null;
            // 
            // 
            // 
            this.c1TreeView1.ButtonImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.c1TreeView1.ButtonImageList.ImageSize = new System.Drawing.Size(16, 16);
            // 
            // 
            // 
            this.c1TreeView1.CheckImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.c1TreeView1.CheckImageList.ImageSize = new System.Drawing.Size(16, 16);
            c1TreeColumn1.AutoWidth = true;
            c1TreeColumn1.DisplayFieldName = null;
            c1TreeColumn1.HeaderText = "Column1";
            c1TreeColumn1.Name = "Column1";
            c1TreeColumn1.Width = 180;
            this.c1TreeView1.Columns.Add(c1TreeColumn1);
            this.c1TreeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1TreeView1.ImageList = this.imageList1;
            this.c1TreeView1.Location = new System.Drawing.Point(0, 0);
            this.c1TreeView1.Name = "c1TreeView1";
            this.c1TreeView1.Size = new System.Drawing.Size(691, 583);
            this.c1TreeView1.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.c1TreeView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Overview";
            this.Size = new System.Drawing.Size(691, 583);
            ((System.ComponentModel.ISupportInitialize)(this.c1TreeView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.TreeView.C1TreeView c1TreeView1;
        private System.Windows.Forms.ImageList imageList1;
    }
}