using FlexGridExplorer.Component.Input;
using FlexGridExplorer.Core;
using FlexGridExplorer.Utility;

namespace FlexGridExplorer.Component.SideMenu
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
            panel2 = new Panel();
            searchBar1 = new SearchBar();
            panel3 = new Panel();
            btnHambur = new C1.Win.Input.C1Button();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnHambur).BeginInit();
            SuspendLayout();
            // 
            // treeView
            // 
            treeView.AutoSize = true;
            treeView.BackColor = Color.FromArgb(243, 242, 242);
            treeView.Collapsed = false;
            treeView.Dock = DockStyle.Fill;
            treeView.FilterString = "";
            treeView.HoverBackColor = Color.Transparent;
            treeView.HoverForeColor = Color.Empty;
            treeView.Location = new Point(0, 103);
            treeView.Margin = new Padding(0);
            treeView.Name = "treeView";
            treeView.SelectedNode = null;
            treeView.SelectedNodeRoot = null;
            treeView.SelectionColor = Color.FromArgb(233, 232, 232);
            treeView.SelectionForeColor = Color.Black;
            treeView.Size = new Size(415, 447);
            treeView.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.Controls.Add(searchBar1);
            panel2.Location = new Point(1, 50);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(394, 50);
            panel2.TabIndex = 0;
            // 
            // searchBar1
            // 
            searchBar1.BackColor = Color.Transparent;
            searchBar1.Location = new Point(13, 4);
            searchBar1.Margin = new Padding(0);
            searchBar1.Name = "searchBar1";
            searchBar1.SearchText = "";
            searchBar1.Size = new Size(375, 40);
            searchBar1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(243, 242, 242);
            panel3.Controls.Add(btnHambur);
            panel3.Controls.Add(panel2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(415, 103);
            panel3.TabIndex = 1;
            // 
            // btnHambur
            // 
            btnHambur.Cursor = Cursors.Hand;
            btnHambur.Location = new Point(8, 6);
            btnHambur.Name = "btnHambur";
            btnHambur.Size = new Size(45, 42);
            btnHambur.Styles.Border = new C1.Framework.Thickness(0, 0, 0, 0);
            btnHambur.Styles.Default.BackColor = SystemColors.ButtonFace;
            btnHambur.Styles.Hot.BackColor = Color.FromArgb(233, 232, 232);
            btnHambur.Styles.HotPressed.BackColor = Color.FromArgb(233, 232, 232);
            btnHambur.Styles.Pressed.BackColor = Color.FromArgb(233, 232, 232);
            btnHambur.TabIndex = 15;
            btnHambur.TabStop = false;
            // 
            // SideBar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(treeView);
            Controls.Add(panel3);
            Margin = new Padding(2);
            Name = "SideBar";
            Size = new Size(415, 550);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnHambur).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private SearchBar searchBar1;
        private System.Windows.Forms.Panel panel3;
        public StackTreeControl treeView;
        private C1.Win.Input.C1PictureBox pbMenu;
        private C1.Win.Input.C1Button btnHambur;
    }
}
