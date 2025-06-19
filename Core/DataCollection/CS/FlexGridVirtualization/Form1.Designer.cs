using C1.Win.Input.DbNavigator.Items;

namespace FlexGridVirtualization
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
            NavLabel navLabel1 = new NavLabel();
            NavFirstButton navFirstButton1 = new NavFirstButton();
            NavPrevButton navPrevButton1 = new NavPrevButton();
            NavEditor navEditor1 = new NavEditor();
            NavNextButton navNextButton1 = new NavNextButton();
            NavLastButton navLastButton1 = new NavLastButton();
            NavLabel navLabel2 = new NavLabel();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            c1FlexGrid1 = new C1.Win.FlexGrid.C1FlexGrid();
            c1DbNavigator1 = new C1.Win.Input.DbNavigator.C1DbNavigator();
            ((System.ComponentModel.ISupportInitialize)c1FlexGrid1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c1DbNavigator1).BeginInit();
            SuspendLayout();
            // 
            // c1FlexGrid1
            // 
            c1FlexGrid1.ColumnInfo = "10,1,0,0,0,-1,Columns:";
            c1FlexGrid1.Dock = DockStyle.Fill;
            c1FlexGrid1.Location = new Point(0, 36);
            c1FlexGrid1.Name = "c1FlexGrid1";
            c1FlexGrid1.Size = new Size(1240, 806);
            c1FlexGrid1.TabIndex = 1;
            // 
            // c1DbNavigator1
            // 
            c1DbNavigator1.Dock = DockStyle.Top;
            navLabel1.Text = "Row: ";
            navLabel2.Size = 100;
            c1DbNavigator1.Items.Add(navLabel1);
            c1DbNavigator1.Items.Add(navFirstButton1);
            c1DbNavigator1.Items.Add(navPrevButton1);
            c1DbNavigator1.Items.Add(navEditor1);
            c1DbNavigator1.Items.Add(navNextButton1);
            c1DbNavigator1.Items.Add(navLastButton1);
            c1DbNavigator1.Items.Add(navLabel2);
            c1DbNavigator1.Location = new Point(0, 0);
            c1DbNavigator1.Name = "c1DbNavigator1";
            c1DbNavigator1.Size = new Size(1240, 36);
            c1DbNavigator1.TabIndex = 3;
            c1DbNavigator1.Text = "c1DbNavigator1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1240, 842);
            Controls.Add(c1FlexGrid1);
            Controls.Add(c1DbNavigator1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FlexGrid Virtualization";
            ((System.ComponentModel.ISupportInitialize)c1FlexGrid1).EndInit();
            ((System.ComponentModel.ISupportInitialize)c1DbNavigator1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private C1.Win.FlexGrid.C1FlexGrid c1FlexGrid1;
        private C1.Win.Input.DbNavigator.C1DbNavigator c1DbNavigator1;
    }
}
