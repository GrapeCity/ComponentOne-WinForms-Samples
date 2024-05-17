namespace TransposedGrid
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            c1FlexGrid1 = new C1.Win.FlexGrid.C1FlexGrid();
            linkLabel1 = new LinkLabel();
            label7 = new Label();
            checkBox1 = new CheckBox();
            imageList1 = new ImageList(components);
            flexPie1 = new C1.Win.Chart.FlexPie();
            label2 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox4 = new GroupBox();
            flexPieActionLabel = new Label();
            groupBox1 = new GroupBox();
            linkLabel2 = new LinkLabel();
            progressBar3 = new ProgressBar();
            progressBar1 = new ProgressBar();
            progressBar2 = new ProgressBar();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)c1FlexGrid1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // c1FlexGrid1
            // 
            c1FlexGrid1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            c1FlexGrid1.ColumnInfo = "10,1,0,0,0,-1,Columns:";
            tableLayoutPanel1.SetColumnSpan(c1FlexGrid1, 2);
            c1FlexGrid1.Location = new Point(3, 214);
            c1FlexGrid1.Name = "c1FlexGrid1";
            c1FlexGrid1.Size = new Size(667, 356);
            c1FlexGrid1.TabIndex = 0;
            c1FlexGrid1.MouseClick += c1FlexGrid1_MouseClick;
            // 
            // linkLabel1
            // 
            linkLabel1.Anchor = AnchorStyles.None;
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = SystemColors.MenuHighlight;
            linkLabel1.Location = new Point(145, 23);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(88, 23);
            linkLabel1.TabIndex = 10;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "User-story";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Location = new Point(365, 23);
            label7.MaximumSize = new Size(700, 100);
            label7.Name = "label7";
            label7.Size = new Size(205, 20);
            label7.TabIndex = 9;
            label7.Text = "Read More about C1 Features";
            // 
            // checkBox1
            // 
            checkBox1.Anchor = AnchorStyles.None;
            checkBox1.Appearance = Appearance.Button;
            checkBox1.Cursor = Cursors.Hand;
            checkBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox1.ForeColor = SystemColors.MenuHighlight;
            checkBox1.ImageIndex = 0;
            checkBox1.ImageList = imageList1;
            checkBox1.Location = new Point(201, 26);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(266, 126);
            checkBox1.TabIndex = 11;
            checkBox1.Text = "Transpose";
            checkBox1.TextImageRelation = TextImageRelation.ImageBeforeText;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "Toggle Off.png");
            imageList1.Images.SetKeyName(1, "Toggle On.png");
            // 
            // flexPie1
            // 
            flexPie1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flexPie1.AnimationLoad.Attributes = C1.Chart.SliceAttribute.Radius;
            flexPie1.AnimationLoad.Duration = 400;
            flexPie1.AnimationLoad.Easing = C1.Chart.Easing.Linear;
            flexPie1.AnimationLoad.Type = C1.Chart.AnimationType.All;
            flexPie1.AnimationSettings = C1.Chart.AnimationSettings.None;
            flexPie1.AnimationUpdate.Duration = 400;
            flexPie1.AnimationUpdate.Easing = C1.Chart.Easing.Linear;
            flexPie1.AnimationUpdate.Type = C1.Chart.AnimationType.All;
            flexPie1.DataLabel.Border = false;
            flexPie1.DataLabel.BorderStyle.VerticalText = false;
            flexPie1.DataLabel.ConnectingLine = false;
            flexPie1.DataLabel.Content = null;
            flexPie1.DataLabel.Offset = 0;
            flexPie1.DataLabel.Overlapping = C1.Chart.PieLabelOverlapping.Default;
            flexPie1.DataLabel.Position = C1.Chart.PieLabelPosition.None;
            flexPie1.DataLabel.Style.VerticalText = false;
            flexPie1.Legend.ItemMaxWidth = 0;
            flexPie1.Legend.Orientation = C1.Chart.Orientation.Auto;
            flexPie1.Legend.Position = C1.Chart.Position.Bottom;
            flexPie1.Legend.Reversed = false;
            flexPie1.Legend.ScrollBars = C1.Chart.LegendScrollBars.None;
            flexPie1.Legend.TextWrapping = C1.Chart.TextWrapping.None;
            flexPie1.Legend.Title = null;
            flexPie1.Location = new Point(0, 90);
            flexPie1.Name = "flexPie1";
            flexPie1.PlotStyle.VerticalText = false;
            flexPie1.SelectionStyle.StrokeColor = Color.Red;
            flexPie1.SelectionStyle.VerticalText = false;
            flexPie1.Size = new Size(706, 260);
            flexPie1.TabIndex = 14;
            flexPie1.Text = "flexPie1";
            flexPie1.Titles = null;
            // 
            // 
            // 
            flexPie1.ToolTip.Content = "";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(23, 24);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 3;
            label2.Text = "Read about the";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.13047F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 0.343053162F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.55131F));
            tableLayoutPanel1.Controls.Add(groupBox4, 2, 2);
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 4);
            tableLayoutPanel1.Controls.Add(c1FlexGrid1, 0, 2);
            tableLayoutPanel1.Controls.Add(progressBar1, 0, 1);
            tableLayoutPanel1.Controls.Add(progressBar2, 0, 3);
            tableLayoutPanel1.Controls.Add(label5, 2, 0);
            tableLayoutPanel1.Controls.Add(checkBox1, 0, 0);
            tableLayoutPanel1.Location = new Point(33, 38);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 26.9005852F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 4.8245616F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 54.3859634F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5.70175457F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.210526F));
            tableLayoutPanel1.Size = new Size(1391, 673);
            tableLayoutPanel1.TabIndex = 15;
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox4.Controls.Add(flexPie1);
            groupBox4.Controls.Add(flexPieActionLabel);
            groupBox4.Location = new Point(676, 214);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(712, 356);
            groupBox4.TabIndex = 17;
            groupBox4.TabStop = false;
            // 
            // flexPieActionLabel
            // 
            flexPieActionLabel.Anchor = AnchorStyles.None;
            flexPieActionLabel.Location = new Point(165, 11);
            flexPieActionLabel.Name = "flexPieActionLabel";
            flexPieActionLabel.Size = new Size(351, 76);
            flexPieActionLabel.TabIndex = 16;
            flexPieActionLabel.Text = "In order to view the data in the FlexPie, transpose the FlexGrid and click a record to compare the performance of hotels.";
            flexPieActionLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(groupBox1, 2);
            groupBox1.Controls.Add(linkLabel2);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(progressBar3);
            groupBox1.Controls.Add(linkLabel1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(0, 610);
            groupBox1.Margin = new Padding(0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(673, 63);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            // 
            // linkLabel2
            // 
            linkLabel2.Anchor = AnchorStyles.None;
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel2.LinkColor = SystemColors.MenuHighlight;
            linkLabel2.Location = new Point(576, 21);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(93, 23);
            linkLabel2.TabIndex = 18;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "C1 features";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // progressBar3
            // 
            progressBar3.Anchor = AnchorStyles.None;
            progressBar3.Location = new Point(337, 21);
            progressBar3.Name = "progressBar3";
            progressBar3.Size = new Size(10, 27);
            progressBar3.TabIndex = 17;
            // 
            // progressBar1
            // 
            progressBar1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(progressBar1, 3);
            progressBar1.Location = new Point(3, 182);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(1385, 10);
            progressBar1.TabIndex = 0;
            // 
            // progressBar2
            // 
            progressBar2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(progressBar2, 3);
            progressBar2.Location = new Point(3, 586);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(1385, 10);
            progressBar2.TabIndex = 15;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoEllipsis = true;
            label5.AutoSize = true;
            label5.Location = new Point(676, 0);
            label5.MaximumSize = new Size(700, 250);
            label5.Name = "label5";
            label5.Size = new Size(700, 179);
            label5.TabIndex = 6;
            label5.Text = resources.GetString("label5.Text");
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1463, 747);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)c1FlexGrid1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private C1.Win.FlexGrid.C1FlexGrid c1FlexGrid1;
        private LinkLabel linkLabel1;
        private Label label7;
        private CheckBox checkBox1;
        private C1.Win.Chart.FlexPie flexPie1;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel1;
        private ProgressBar progressBar1;
        private ProgressBar progressBar2;
        private ImageList imageList1;
        private Label label5;
        private GroupBox groupBox1;
        private ProgressBar progressBar3;
        private Label flexPieActionLabel;
        private GroupBox groupBox4;
        private LinkLabel linkLabel2;
    }
}