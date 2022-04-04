namespace ListExplorer.Samples
{
    partial class FixedColumns
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FixedColumns));
            this.c1List1 = new C1.Win.List.C1List();
            ((System.ComponentModel.ISupportInitialize)(this.c1List1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1List1
            // 
            this.c1List1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.c1List1.DeadAreaBackColor = System.Drawing.SystemColors.ControlDark;
            this.c1List1.Location = new System.Drawing.Point(3, 3);
            this.c1List1.MatchEntryTimeout = ((long)(2000));
            this.c1List1.Name = "c1List1";
            this.c1List1.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.c1List1.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.c1List1.PreviewInfo.ZoomFactor = 75D;
            this.c1List1.PropBag = resources.GetString("c1List1.PropBag");
            this.c1List1.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.c1List1.Size = new System.Drawing.Size(342, 212);
            this.c1List1.TabIndex = 0;
            this.c1List1.Text = "c1List1";
            // 
            // FixedColumns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.c1List1);
            this.Name = "FixedColumns";
            this.Size = new System.Drawing.Size(348, 218);
            this.Load += new System.EventHandler(this.FixedColumns_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1List1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.List.C1List c1List1;
    }
}
