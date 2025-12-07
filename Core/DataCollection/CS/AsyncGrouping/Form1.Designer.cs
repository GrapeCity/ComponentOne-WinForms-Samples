namespace AsyncGrouping
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            c1FlexGrid1 = new C1.Win.FlexGrid.C1FlexGrid();
            ((System.ComponentModel.ISupportInitialize)c1FlexGrid1).BeginInit();
            SuspendLayout();
            // 
            // c1FlexGrid1
            // 
            c1FlexGrid1.ColumnInfo = "3,1,0,0,0,-1,Columns:2{Width:944;StarWidth:\"*\";Name:\"Title\";}\t";
            c1FlexGrid1.Dock = DockStyle.Fill;
            c1FlexGrid1.Location = new Point(0, 0);
            c1FlexGrid1.Name = "c1FlexGrid1";
            c1FlexGrid1.Size = new Size(1172, 910);
            c1FlexGrid1.TabIndex = 0;
            c1FlexGrid1.Tree.Indent = 14;
            c1FlexGrid1.Tree.Style = C1.Win.FlexGrid.TreeStyleFlags.Symbols;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1172, 910);
            Controls.Add(c1FlexGrid1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1194, 966);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Async Grouping";
            ((System.ComponentModel.ISupportInitialize)c1FlexGrid1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private C1.Win.FlexGrid.C1FlexGrid c1FlexGrid1;
    }
}
