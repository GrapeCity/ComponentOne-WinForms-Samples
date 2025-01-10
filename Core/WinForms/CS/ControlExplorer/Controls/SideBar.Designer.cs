using ControlExplorer.Core;

namespace ControlExplorer.Contrlols
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
            searchBar1 = new Controls.SearchBar();
            panel3 = new System.Windows.Forms.Panel();
            panel1 = new System.Windows.Forms.Panel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // treeView
            // 
            treeView.AutoSize = true;
            treeView.BackColor = System.Drawing.Color.Transparent;
            treeView.Collapsed = false;
            treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            treeView.FilterString = "";
            treeView.HoverBackColor = System.Drawing.Color.Transparent;
            treeView.HoverForeColor = System.Drawing.Color.Empty;
            treeView.Location = new System.Drawing.Point(0, 160);
            treeView.Margin = new System.Windows.Forms.Padding(0);
            treeView.Name = "treeView";
            treeView.SelectedNode = null;
            treeView.SelectedNodeRoot = null;
            treeView.SelectionColor = System.Drawing.Color.FromArgb(233, 232, 232);
            treeView.SelectionForeColor = System.Drawing.Color.Black;
            treeView.Size = new System.Drawing.Size(593, 757);
            treeView.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            panel2.Controls.Add(searchBar1);
            panel2.Location = new System.Drawing.Point(1, 77);
            panel2.Margin = new System.Windows.Forms.Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(563, 83);
            panel2.TabIndex = 0;
            // 
            // searchBar1
            // 
            searchBar1.BackColor = System.Drawing.Color.Transparent;
            searchBar1.Location = new System.Drawing.Point(19, 7);
            searchBar1.Margin = new System.Windows.Forms.Padding(0);
            searchBar1.Name = "searchBar1";
            searchBar1.SearchText = "";
            searchBar1.Size = new System.Drawing.Size(536, 67);
            searchBar1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.Color.Transparent;
            panel3.Controls.Add(panel1);
            panel3.Controls.Add(panel2);
            panel3.Dock = System.Windows.Forms.DockStyle.Top;
            panel3.Location = new System.Drawing.Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(593, 160);
            panel3.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.Transparent;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new System.Drawing.Point(9, 3);
            panel1.Margin = new System.Windows.Forms.Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(54, 73);
            panel1.TabIndex = 14;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            pictureBox1.Image = Properties.Resources.ham_menu;
            pictureBox1.Location = new System.Drawing.Point(14, 20);
            pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(29, 33);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += ToggleSideBar;
            // 
            // SideBar
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            Controls.Add(treeView);
            Controls.Add(panel3);
            Name = "SideBar";
            Size = new System.Drawing.Size(593, 917);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private Controls.SearchBar searchBar1;
        private System.Windows.Forms.Panel panel3;
        public StackTreeControl treeView;
        private C1.Win.Input.C1PictureBox pbMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
