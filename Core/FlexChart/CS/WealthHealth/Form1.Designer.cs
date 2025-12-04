namespace WealthHealth
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            C1.Chart.ElementSize elementSize1 = new C1.Chart.ElementSize();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            textBox1 = new System.Windows.Forms.TextBox();
            trackBar1 = new System.Windows.Forms.TrackBar();
            button1 = new System.Windows.Forms.Button();
            flexChart1 = new C1.Win.Chart.FlexChart();
            textBox2 = new System.Windows.Forms.TextBox();
            textBox3 = new System.Windows.Forms.TextBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)flexChart1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 1);
            tableLayoutPanel1.Controls.Add(flexChart1, 0, 3);
            tableLayoutPanel1.Controls.Add(textBox2, 0, 4);
            tableLayoutPanel1.Controls.Add(textBox3, 0, 2);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            tableLayoutPanel1.Size = new System.Drawing.Size(915, 647);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel1.SetColumnSpan(tableLayoutPanel2, 2);
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(label1, 1, 0);
            tableLayoutPanel2.Controls.Add(label2, 1, 1);
            tableLayoutPanel2.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel2.Location = new System.Drawing.Point(9, 3);
            tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(9, 3, 9, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new System.Drawing.Size(897, 92);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = System.Windows.Forms.DockStyle.Fill;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(97, 0);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(796, 46);
            label1.TabIndex = 0;
            label1.Text = "The Wealth and Health of Nations";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(107, 46);
            label2.Margin = new System.Windows.Forms.Padding(14, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(506, 20);
            label2.TabIndex = 1;
            label2.Text = "A dynamic chart based on Gapminder’s Wealth and Health of Nations. ";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(4, 3);
            pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            tableLayoutPanel2.SetRowSpan(pictureBox1, 2);
            pictureBox1.Size = new System.Drawing.Size(85, 86);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(flowLayoutPanel1, 2);
            flowLayoutPanel1.Controls.Add(textBox1);
            flowLayoutPanel1.Controls.Add(trackBar1);
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            flowLayoutPanel1.Location = new System.Drawing.Point(9, 101);
            flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(9, 3, 9, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(897, 45);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.BackColor = System.Drawing.Color.White;
            textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox1.Location = new System.Drawing.Point(4, 3);
            textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new System.Drawing.Size(509, 39);
            textBox1.TabIndex = 3;
            textBox1.Text = "This chart shows the evolution of income, life expectancy, and population in 178 nations over a period of 210 years. Slide the gauge or press the play button and enjoy the show.";
            // 
            // trackBar1
            // 
            trackBar1.AutoSize = false;
            trackBar1.Location = new System.Drawing.Point(521, 3);
            trackBar1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            trackBar1.Maximum = 2009;
            trackBar1.Minimum = 1800;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new System.Drawing.Size(152, 39);
            trackBar1.TabIndex = 1;
            trackBar1.TickFrequency = 10;
            trackBar1.Value = 1800;
            trackBar1.ValueChanged += trackBar1_ValueChanged;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(681, 3);
            button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(77, 27);
            button1.TabIndex = 2;
            button1.Text = "Play";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // flexChart1
            // 
            flexChart1.AnimationLoad.Direction = C1.Chart.AnimationDirection.Y;
            flexChart1.AnimationLoad.Duration = 400;
            flexChart1.AnimationLoad.Easing = C1.Chart.Easing.Linear;
            flexChart1.AnimationLoad.Type = C1.Chart.AnimationType.All;
            flexChart1.AnimationSettings = C1.Chart.AnimationSettings.None;
            flexChart1.AnimationUpdate.Duration = 400;
            flexChart1.AnimationUpdate.Easing = C1.Chart.Easing.Linear;
            flexChart1.AnimationUpdate.Type = C1.Chart.AnimationType.All;
            flexChart1.AxisX.AxisLine = true;
            flexChart1.AxisX.Chart = flexChart1;
            flexChart1.AxisX.DataSource = null;
            flexChart1.AxisX.Formatter = null;
            flexChart1.AxisX.GroupProvider = null;
            flexChart1.AxisX.GroupSeparator = C1.Chart.AxisGroupSeparator.None;
            flexChart1.AxisX.GroupTitleAlignment = C1.Chart.AxisLabelAlignment.Center;
            flexChart1.AxisX.GroupVisibilityLevel = 0;
            flexChart1.AxisX.PlotAreaName = null;
            flexChart1.AxisX.Position = C1.Chart.Position.Bottom;
            flexChart1.AxisX.TimeUnit = C1.Chart.TimeUnits.Day;
            flexChart1.AxisY.AxisLine = false;
            flexChart1.AxisY.Chart = flexChart1;
            flexChart1.AxisY.DataSource = null;
            flexChart1.AxisY.Formatter = null;
            flexChart1.AxisY.GroupProvider = null;
            flexChart1.AxisY.GroupSeparator = C1.Chart.AxisGroupSeparator.None;
            flexChart1.AxisY.GroupTitleAlignment = C1.Chart.AxisLabelAlignment.Center;
            flexChart1.AxisY.GroupVisibilityLevel = 0;
            flexChart1.AxisY.MajorGrid = true;
            flexChart1.AxisY.MajorTickMarks = C1.Chart.TickMark.None;
            flexChart1.AxisY.PlotAreaName = null;
            flexChart1.AxisY.Position = C1.Chart.Position.Left;
            flexChart1.AxisY.TimeUnit = C1.Chart.TimeUnits.Day;
            tableLayoutPanel1.SetColumnSpan(flexChart1, 2);
            flexChart1.DataLabel.Angle = 0;
            flexChart1.DataLabel.Border = false;
            flexChart1.DataLabel.ConnectingLine = false;
            flexChart1.DataLabel.Content = null;
            flexChart1.DataLabel.ContentOptions = C1.Chart.ContentOptions.WordWrap;
            flexChart1.DataLabel.MaxAutoLabels = 100;
            flexChart1.DataLabel.MaxLines = 0;
            flexChart1.DataLabel.MaxWidth = 0;
            flexChart1.DataLabel.Offset = 0;
            flexChart1.DataLabel.Overlapping = C1.Chart.LabelOverlapping.Hide;
            flexChart1.DataLabel.OverlappingOptions = C1.Chart.LabelOverlappingOptions.OutsidePlotArea;
            flexChart1.DataLabel.Position = C1.Chart.LabelPosition.None;
            flexChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            flexChart1.Legend.ItemMaxWidth = 0;
            flexChart1.Legend.Orientation = C1.Chart.Orientation.Auto;
            flexChart1.Legend.Position = C1.Chart.Position.Right;
            flexChart1.Legend.Reversed = false;
            flexChart1.Legend.ScrollBars = C1.Chart.LegendScrollBars.None;
            flexChart1.Legend.TextWrapping = C1.Chart.TextWrapping.None;
            flexChart1.Legend.Title = null;
            flexChart1.Location = new System.Drawing.Point(9, 181);
            flexChart1.Margin = new System.Windows.Forms.Padding(9, 9, 28, 9);
            flexChart1.Name = "flexChart1";
            flexChart1.Options.Chart = flexChart1;
            elementSize1.SizeType = C1.Chart.ElementSizeType.Percentage;
            elementSize1.Value = 70D;
            flexChart1.Options.ClusterSize = elementSize1;
            flexChart1.PlotMargin = new System.Windows.Forms.Padding(0);
            flexChart1.SelectedSeries = null;
            flexChart1.SelectionStyle.StrokeColor = System.Drawing.Color.Red;
            flexChart1.Size = new System.Drawing.Size(878, 402);
            flexChart1.TabIndex = 2;
            flexChart1.Text = "flexChart1";
            // 
            // 
            // 
            flexChart1.ToolTip.Content = "{value}";
            // 
            // textBox2
            // 
            textBox2.BackColor = System.Drawing.Color.White;
            textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            tableLayoutPanel1.SetColumnSpan(textBox2, 2);
            textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            textBox2.Location = new System.Drawing.Point(9, 601);
            textBox2.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new System.Drawing.Size(897, 37);
            textBox2.TabIndex = 3;
            textBox2.Text = "This is a WinForms version of Mike Bostock's sample in D3, which is based on Gapminder’s Wealth & Health of Nations, made famous by Hans Rosling’s memorable 2006 TED talk.";
            // 
            // textBox3
            // 
            textBox3.BackColor = System.Drawing.Color.White;
            textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            textBox3.Location = new System.Drawing.Point(12, 152);
            textBox3.Margin = new System.Windows.Forms.Padding(12, 3, 9, 3);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new System.Drawing.Size(436, 16);
            textBox3.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(915, 647);
            Controls.Add(tableLayoutPanel1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "WealthHealth";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)flexChart1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button button1;
        private C1.Win.Chart.FlexChart flexChart1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}

