namespace Custom_Localization.Pages
{
    partial class ViewResourceFilePage
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
            panel1 = new Panel();
            panel2 = new Panel();
            c1FlexGrid1 = new C1.Win.FlexGrid.C1FlexGrid();
            panel3 = new Panel();
            resourceViewer = new C1.Win.Input.C1Label();
            panel4 = new Panel();
            splitContainer1 = new SplitContainer();
            customTreeView1 = new Custom_Localization.UserControls.CustomTreeView();
            richTextBox1 = new RichTextBox();
            panel5 = new Panel();
            projectDirectoryViewer = new C1.Win.Input.C1Label();
            fileSystemWatcher1 = new FileSystemWatcher();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)c1FlexGrid1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)resourceViewer).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)projectDirectoryViewer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel4);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(16, 0, 16, 16);
            panel1.Size = new Size(1048, 616);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(c1FlexGrid1);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(16, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(465, 600);
            panel2.TabIndex = 1;
            // 
            // c1FlexGrid1
            // 
            c1FlexGrid1.AllowEditing = false;
            c1FlexGrid1.AllowFiltering = true;
            c1FlexGrid1.ColumnInfo = "10,1,0,0,0,-1,Columns:";
            c1FlexGrid1.Dock = DockStyle.Fill;
            c1FlexGrid1.Location = new Point(0, 50);
            c1FlexGrid1.Margin = new Padding(2);
            c1FlexGrid1.Name = "c1FlexGrid1";
            c1FlexGrid1.Size = new Size(465, 550);
            c1FlexGrid1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(resourceViewer);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(465, 50);
            panel3.TabIndex = 1;
            // 
            // resourceViewer
            // 
            resourceViewer.AutoSize = true;
            resourceViewer.Location = new Point(0, 11);
            resourceViewer.Name = "resourceViewer";
            resourceViewer.Size = new Size(109, 26);
            resourceViewer.Styles.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resourceViewer.TabIndex = 0;
            resourceViewer.Text = "Resource.resx";
            // 
            // panel4
            // 
            panel4.Controls.Add(splitContainer1);
            panel4.Controls.Add(panel5);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(481, 0);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(16, 0, 0, 0);
            panel4.Size = new Size(551, 600);
            panel4.TabIndex = 2;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(16, 50);
            splitContainer1.Margin = new Padding(2, 2, 2, 2);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(customTreeView1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(richTextBox1);
            splitContainer1.Size = new Size(535, 550);
            splitContainer1.SplitterDistance = 255;
            splitContainer1.SplitterWidth = 3;
            splitContainer1.TabIndex = 4;
            // 
            // customTreeView1
            // 
            customTreeView1.Dock = DockStyle.Fill;
            customTreeView1.Location = new Point(0, 0);
            customTreeView1.Margin = new Padding(2, 2, 2, 2);
            customTreeView1.Name = "customTreeView1";
            customTreeView1.Size = new Size(535, 255);
            customTreeView1.TabIndex = 2;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.Linen;
            richTextBox1.BorderStyle = BorderStyle.FixedSingle;
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(0, 0);
            richTextBox1.Margin = new Padding(2, 2, 2, 2);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(535, 292);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // panel5
            // 
            panel5.Controls.Add(projectDirectoryViewer);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(16, 0);
            panel5.Margin = new Padding(2);
            panel5.Name = "panel5";
            panel5.Size = new Size(535, 50);
            panel5.TabIndex = 0;
            // 
            // projectDirectoryViewer
            // 
            projectDirectoryViewer.AutoSize = true;
            projectDirectoryViewer.Location = new Point(0, 11);
            projectDirectoryViewer.Name = "projectDirectoryViewer";
            projectDirectoryViewer.Size = new Size(171, 26);
            projectDirectoryViewer.Styles.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            projectDirectoryViewer.TabIndex = 0;
            projectDirectoryViewer.Text = "Main Project Directory";
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // ViewResourceFilePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "ViewResourceFilePage";
            Size = new Size(1048, 616);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)c1FlexGrid1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)resourceViewer).EndInit();
            panel4.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)projectDirectoryViewer).EndInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private C1.Win.FlexGrid.C1FlexGrid c1FlexGrid1;
        private Panel panel2;
        private C1.Win.Input.C1Label resourceViewer;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private C1.Win.Input.C1Label projectDirectoryViewer;
        private UserControls.CustomTreeView customTreeView1;
        private RichTextBox richTextBox1;
        private SplitContainer splitContainer1;
        private FileSystemWatcher fileSystemWatcher1;
    }
}
