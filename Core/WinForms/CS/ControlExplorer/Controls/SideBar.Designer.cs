using ControlExplorer.Core;
using ControlExplorer.Utilities;

namespace ControlExplorer.Controls
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
            btnHambur = new C1.Win.Input.C1Button();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnHambur).BeginInit();
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
            treeView.Location = new System.Drawing.Point(0, 103);
            treeView.Margin = new System.Windows.Forms.Padding(0);
            treeView.Name = "treeView";
            treeView.SelectedNode = null;
            treeView.SelectedNodeRoot = null;
            treeView.SelectionColor = System.Drawing.Color.FromArgb(233, 232, 232);
            treeView.SelectionForeColor = System.Drawing.Color.Black;
            treeView.Size = new System.Drawing.Size(415, 447);
            treeView.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            panel2.Controls.Add(searchBar1);
            panel2.Location = new System.Drawing.Point(1, 50);
            panel2.Margin = new System.Windows.Forms.Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(394, 50);
            panel2.TabIndex = 0;
            // 
            // searchBar1
            // 
            searchBar1.BackColor = System.Drawing.Color.Transparent;
            searchBar1.Location = new System.Drawing.Point(13, 4);
            searchBar1.Margin = new System.Windows.Forms.Padding(0);
            searchBar1.Name = "searchBar1";
            searchBar1.SearchText = "";
            searchBar1.Size = new System.Drawing.Size(375, 40);
            searchBar1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.Color.Transparent;
            panel3.Controls.Add(btnHambur);
            panel3.Controls.Add(panel2);
            panel3.Dock = System.Windows.Forms.DockStyle.Top;
            panel3.Location = new System.Drawing.Point(0, 0);
            panel3.Margin = new System.Windows.Forms.Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(415, 103);
            panel3.TabIndex = 1;
            // 
            // btnHambur
            // 
            btnHambur.Cursor = System.Windows.Forms.Cursors.Hand;
            btnHambur.Location = new System.Drawing.Point(8, 6);
            btnHambur.Name = "btnHambur";
            btnHambur.Size = new System.Drawing.Size(45, 42);
            btnHambur.Styles.Border = new C1.Framework.Thickness(0, 0, 0, 0);
            btnHambur.Styles.Default.BackColor = System.Drawing.SystemColors.ButtonFace;
            btnHambur.Styles.Hot.BackColor = System.Drawing.Color.FromArgb(233, 232, 232);
            btnHambur.Styles.HotPressed.BackColor = System.Drawing.Color.FromArgb(233, 232, 232);
            btnHambur.Styles.Pressed.BackColor = System.Drawing.Color.FromArgb(233, 232, 232);
            btnHambur.TabIndex = 15;
            btnHambur.TabStop = false;
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
            Size = new System.Drawing.Size(415, 550);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnHambur).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private Controls.SearchBar searchBar1;
        private System.Windows.Forms.Panel panel3;
        public StackTreeControl treeView;
        private C1.Win.Input.C1PictureBox pbMenu;
        private C1.Win.Input.C1Button btnHambur;
    }
}
