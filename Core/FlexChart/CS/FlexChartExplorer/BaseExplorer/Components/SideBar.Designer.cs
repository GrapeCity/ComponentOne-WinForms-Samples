using BaseExplorer.Core;

namespace BaseExplorer.Components
{
    partial class SideBar
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
            treeView = new StackTreeControl();
            panel2 = new System.Windows.Forms.Panel();
            searchBar1 = new CustomControls.SearchBar();
            panel3 = new System.Windows.Forms.Panel();
            panel1 = new System.Windows.Forms.Panel();
            pbMenu = new C1.Win.Input.C1PictureBox();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbMenu).BeginInit();
            SuspendLayout();
            // 
            // treeView
            // 
            treeView.AutoSize = true;
            treeView.BackColor = System.Drawing.Color.FromArgb(243, 242, 242);
            treeView.Collapsed = false;
            treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            treeView.FilterString = "";
            treeView.HoverBackColor = System.Drawing.Color.FromArgb(243, 242, 242);
            treeView.HoverForeColor = System.Drawing.Color.Empty;
            treeView.Location = new System.Drawing.Point(0, 96);
            treeView.Margin = new System.Windows.Forms.Padding(0);
            treeView.Name = "treeView";
            treeView.SelectedNode = null;
            treeView.SelectedNodeRoot = null;
            treeView.SelectionColor = System.Drawing.Color.FromArgb(233, 232, 232);
            treeView.SelectionForeColor = System.Drawing.Color.Black;
            treeView.Size = new System.Drawing.Size(360, 454);
            treeView.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            panel2.Controls.Add(searchBar1);
            panel2.Location = new System.Drawing.Point(1, 46);
            panel2.Margin = new System.Windows.Forms.Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(359, 52);
            panel2.TabIndex = 0;
            // 
            // searchBar1
            // 
            searchBar1.BackColor = System.Drawing.Color.FromArgb(243, 242, 242);
            searchBar1.Location = new System.Drawing.Point(11, 1);
            searchBar1.Margin = new System.Windows.Forms.Padding(0);
            searchBar1.Name = "searchBar1";
            searchBar1.Size = new System.Drawing.Size(334, 40);
            searchBar1.TabIndex = 0;
            searchBar1.Theme = "Office365White";
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.Color.FromArgb(243, 242, 242);
            panel3.Controls.Add(panel1);
            panel3.Controls.Add(panel2);
            panel3.Dock = System.Windows.Forms.DockStyle.Top;
            panel3.Location = new System.Drawing.Point(0, 0);
            panel3.Margin = new System.Windows.Forms.Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(360, 96);
            panel3.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(243, 242, 242);
            panel1.Controls.Add(pbMenu);
            panel1.Location = new System.Drawing.Point(6, 2);
            panel1.Margin = new System.Windows.Forms.Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(38, 44);
            panel1.TabIndex = 14;
            // 
            // pbMenu
            // 
            pbMenu.BackColor = System.Drawing.Color.FromArgb(243, 242, 242);
            pbMenu.Image = Properties.Resources.ham_menu_black;
            pbMenu.Location = new System.Drawing.Point(16, 15);
            pbMenu.Margin = new System.Windows.Forms.Padding(1);
            pbMenu.Name = "pbMenu";
            pbMenu.Size = new System.Drawing.Size(18, 18);
            pbMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pbMenu.TabIndex = 13;
            pbMenu.TabStop = false;
            pbMenu.Click += ToggleSideBar;
            pbMenu.MouseEnter += OnMouseEnter;
            pbMenu.MouseLeave += OnMouseLeave;
            // 
            // SideBar
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            Controls.Add(treeView);
            Controls.Add(panel3);
            Margin = new System.Windows.Forms.Padding(2);
            Name = "SideBar";
            Size = new System.Drawing.Size(360, 550);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbMenu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private CustomControls.SearchBar searchBar1;
        private System.Windows.Forms.Panel panel3;
        public StackTreeControl treeView;
        private C1.Win.Input.C1PictureBox pbMenu;
        private System.Windows.Forms.Panel panel1;
    }
}
