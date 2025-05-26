namespace FlexGridSelection
{
    partial class About
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
            C1.Win.TreeView.C1TreeColumn c1TreeColumn1 = new C1.Win.TreeView.C1TreeColumn();
            C1.Win.TreeView.C1TreeNode c1TreeNode1 = new C1.Win.TreeView.C1TreeNode();
            C1.Win.TreeView.C1TreeNode c1TreeNode2 = new C1.Win.TreeView.C1TreeNode();
            C1.Win.TreeView.C1TreeNode c1TreeNode3 = new C1.Win.TreeView.C1TreeNode();
            splitContainer1 = new SplitContainer();
            tableLayoutPanel1 = new TableLayoutPanel();
            aboutLabel = new C1.Win.Input.C1Label();
            aboutDescriptionLabel = new C1.Win.Input.C1Label();
            learnMoreLabel = new C1.Win.Input.C1Label();
            githubLinkLabel = new LinkLabel();
            documentationLinkLabel = new LinkLabel();
            c1TreeView1 = new C1.Win.TreeView.C1TreeView();
            panel1 = new Panel();
            topicDescriptionLabel = new LinkLabel();
            c1PictureBox1 = new C1.Win.Input.C1PictureBox();
            topicHeaderLabel = new C1.Win.Input.C1Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)aboutLabel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)aboutDescriptionLabel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)learnMoreLabel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c1TreeView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)c1PictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)topicHeaderLabel).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tableLayoutPanel1);
            splitContainer1.Panel1.Padding = new Padding(0, 10, 0, 0);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panel1);
            splitContainer1.Panel2.Padding = new Padding(0, 10, 0, 0);
            splitContainer1.Size = new Size(1242, 751);
            splitContainer1.SplitterDistance = 287;
            splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(aboutLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(aboutDescriptionLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(learnMoreLabel, 0, 3);
            tableLayoutPanel1.Controls.Add(githubLinkLabel, 0, 4);
            tableLayoutPanel1.Controls.Add(documentationLinkLabel, 0, 5);
            tableLayoutPanel1.Controls.Add(c1TreeView1, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 10);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 180F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(287, 741);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // aboutLabel
            // 
            aboutLabel.AutoSize = true;
            aboutLabel.Dock = DockStyle.Fill;
            aboutLabel.Font = new Font("Segoe UI", 12F);
            aboutLabel.Location = new Point(3, 3);
            aboutLabel.Name = "aboutLabel";
            aboutLabel.Size = new Size(281, 44);
            aboutLabel.Styles.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            aboutLabel.Styles.Padding = new C1.Framework.Thickness(3, 9, 3, 3);
            aboutLabel.TabIndex = 0;
            aboutLabel.Text = "About";
            // 
            // aboutDescriptionLabel
            // 
            aboutDescriptionLabel.AutoSize = true;
            aboutDescriptionLabel.Dock = DockStyle.Fill;
            aboutDescriptionLabel.Font = new Font("Segoe UI", 10F);
            aboutDescriptionLabel.Location = new Point(3, 53);
            aboutDescriptionLabel.Name = "aboutDescriptionLabel";
            aboutDescriptionLabel.Size = new Size(281, 64);
            aboutDescriptionLabel.Styles.Padding = new C1.Framework.Thickness(10, 9, 3, 3);
            aboutDescriptionLabel.TabIndex = 1;
            aboutDescriptionLabel.Text = "This sample showcase 3 feature \r\nof Flexgrid:\r\n";
            // 
            // learnMoreLabel
            // 
            learnMoreLabel.AutoSize = true;
            learnMoreLabel.Dock = DockStyle.Fill;
            learnMoreLabel.Location = new Point(3, 303);
            learnMoreLabel.Name = "learnMoreLabel";
            learnMoreLabel.Size = new Size(281, 44);
            learnMoreLabel.Styles.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            learnMoreLabel.TabIndex = 2;
            learnMoreLabel.Text = "Learn More";
            // 
            // githubLinkLabel
            // 
            githubLinkLabel.AutoSize = true;
            githubLinkLabel.Dock = DockStyle.Fill;
            githubLinkLabel.Location = new Point(3, 350);
            githubLinkLabel.Name = "githubLinkLabel";
            githubLinkLabel.Padding = new Padding(15, 0, 0, 0);
            githubLinkLabel.Size = new Size(281, 50);
            githubLinkLabel.TabIndex = 3;
            githubLinkLabel.TabStop = true;
            githubLinkLabel.Text = "Github Link";
            // 
            // documentationLinkLabel
            // 
            documentationLinkLabel.AutoSize = true;
            documentationLinkLabel.Dock = DockStyle.Fill;
            documentationLinkLabel.Location = new Point(3, 400);
            documentationLinkLabel.Name = "documentationLinkLabel";
            documentationLinkLabel.Padding = new Padding(15, 0, 0, 0);
            documentationLinkLabel.Size = new Size(281, 50);
            documentationLinkLabel.TabIndex = 4;
            documentationLinkLabel.TabStop = true;
            documentationLinkLabel.Text = "FlexGrid Documentation";
            // 
            // c1TreeView1
            // 
            c1TreeView1.BorderStyle = BorderStyle.None;
            // 
            // 
            // 
            c1TreeView1.ButtonImageList.ColorDepth = ColorDepth.Depth32Bit;
            c1TreeView1.ButtonImageList.ImageSize = new Size(9, 9);
            c1TreeView1.ButtonImageList.TransparentColor = Color.Transparent;
            // 
            // 
            // 
            c1TreeView1.CheckImageList.ColorDepth = ColorDepth.Depth32Bit;
            c1TreeView1.CheckImageList.ImageSize = new Size(13, 13);
            c1TreeView1.CheckImageList.TransparentColor = Color.Transparent;
            c1TreeColumn1.HeaderText = "Column1";
            c1TreeColumn1.Name = "Column1";
            c1TreeColumn1.Styles.Font = new Font("Segoe UI", 10F);
            c1TreeColumn1.Styles.Hot.BackColor = SystemColors.ControlLight;
            c1TreeColumn1.Styles.Margins = new C1.Framework.Thickness(0, 3, 0, 3);
            c1TreeColumn1.Styles.Padding = new C1.Framework.Thickness(8, 4, 0, 4);
            c1TreeColumn1.Styles.Selected.BackColor = SystemColors.ControlLight;
            c1TreeColumn1.Styles.Selected.ForeColor = Color.Black;
            c1TreeView1.Columns.Add(c1TreeColumn1);
            c1TreeView1.Dock = DockStyle.Fill;
            c1TreeView1.Location = new Point(3, 123);
            c1TreeView1.Name = "c1TreeView1";
            c1TreeNode1.SetValue("Clipboard Copy Mode ");
            c1TreeNode2.SetValue("Selection Mode");
            c1TreeNode3.SetValue("Aggregate");
            c1TreeView1.Nodes.Add(c1TreeNode1);
            c1TreeView1.Nodes.Add(c1TreeNode2);
            c1TreeView1.Nodes.Add(c1TreeNode3);
            c1TreeView1.ShowColumnHeaders = false;
            c1TreeView1.Size = new Size(281, 174);
            c1TreeView1.Styles.Border = 0;
            c1TreeView1.Styles.BorderColor = Color.Transparent;
            c1TreeView1.Styles.Corners = 5;
            c1TreeView1.Styles.FocusBorderColor = SystemColors.ControlLight;
            c1TreeView1.Styles.Font = new Font("Segoe UI", 10F);
            c1TreeView1.Styles.Hot.BackColor = SystemColors.ControlLight;
            c1TreeView1.Styles.Margins = new C1.Framework.Thickness(0, 3, 0, 3);
            c1TreeView1.Styles.Padding = new C1.Framework.Thickness(8, 4, 0, 4);
            c1TreeView1.Styles.Selected.BackColor = SystemColors.ControlLight;
            c1TreeView1.Styles.Selected.ForeColor = Color.Black;
            c1TreeView1.Styles.ShowFocusBorder = true;
            c1TreeView1.Styles.ShowLines = false;
            c1TreeView1.TabIndex = 5;
            c1TreeView1.SelectionChanged += c1TreeView1_SelectionChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(topicDescriptionLabel);
            panel1.Controls.Add(c1PictureBox1);
            panel1.Controls.Add(topicHeaderLabel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(951, 741);
            panel1.TabIndex = 0;
            panel1.Paint += Panel1_Paint;
            // 
            // topicDescriptionLabel
            // 
            topicDescriptionLabel.Location = new Point(31, 92);
            topicDescriptionLabel.Name = "topicDescriptionLabel";
            topicDescriptionLabel.Size = new Size(898, 87);
            topicDescriptionLabel.TabIndex = 3;
            topicDescriptionLabel.TabStop = true;
            topicDescriptionLabel.Text = "Topic Description";
            // 
            // c1PictureBox1
            // 
            c1PictureBox1.Location = new Point(60, 182);
            c1PictureBox1.Name = "c1PictureBox1";
            c1PictureBox1.Size = new Size(792, 502);
            c1PictureBox1.TabIndex = 2;
            c1PictureBox1.TabStop = false;
            // 
            // topicHeaderLabel
            // 
            topicHeaderLabel.AutoSize = true;
            topicHeaderLabel.Font = new Font("Segoe UI Variable Display", 16F, FontStyle.Bold);
            topicHeaderLabel.Location = new Point(22, 28);
            topicHeaderLabel.Name = "topicHeaderLabel";
            topicHeaderLabel.Size = new Size(187, 42);
            topicHeaderLabel.TabIndex = 0;
            topicHeaderLabel.Text = "Topic Header";
            // 
            // About
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1242, 751);
            Controls.Add(splitContainer1);
            DoubleBuffered = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "About";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Information Page";
            Load += About_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)aboutLabel).EndInit();
            ((System.ComponentModel.ISupportInitialize)aboutDescriptionLabel).EndInit();
            ((System.ComponentModel.ISupportInitialize)learnMoreLabel).EndInit();
            ((System.ComponentModel.ISupportInitialize)c1TreeView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)c1PictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)topicHeaderLabel).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private TableLayoutPanel tableLayoutPanel1;
        private C1.Win.Input.C1Label aboutLabel;
        private C1.Win.Input.C1Label aboutDescriptionLabel;
        private C1.Win.Input.C1Label learnMoreLabel;
        private LinkLabel githubLinkLabel;
        private LinkLabel documentationLinkLabel;
        private C1.Win.TreeView.C1TreeView c1TreeView1;
        private Panel panel1;
        private C1.Win.Input.C1PictureBox c1PictureBox1;
        private C1.Win.Input.C1Label topicHeaderLabel;
        private LinkLabel topicDescriptionLabel;
    }
}