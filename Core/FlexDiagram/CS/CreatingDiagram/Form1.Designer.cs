namespace CreatingDiagram
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
            tableLayoutPanel1 = new TableLayoutPanel();
            flexDiagram1 = new C1.Win.Diagram.FlexDiagram();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            codeSnippet1 = new CreatingDiagram.Controls.CodeSnippet();
            tabPage2 = new TabPage();
            toolStrip1 = new ToolStrip();
            buttonBack = new ToolStripButton();
            toolStripLabel1 = new ToolStripLabel();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            tableLayoutPanel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(flexDiagram1, 0, 1);
            tableLayoutPanel1.Controls.Add(tabControl1, 1, 1);
            tableLayoutPanel1.Controls.Add(toolStrip1, 0, 0);
            tableLayoutPanel1.Controls.Add(statusStrip1, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4, 6, 4, 6);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel1.Size = new Size(1257, 840);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // flexDiagram1
            // 
            flexDiagram1.Dock = DockStyle.Fill;
            flexDiagram1.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            flexDiagram1.InteractionMode = C1.Diagram.InteractionMode.None;
            flexDiagram1.Legend.ItemMaxWidth = 0;
            flexDiagram1.Legend.Orientation = C1.Chart.Orientation.Auto;
            flexDiagram1.Legend.Position = C1.Chart.Position.Bottom;
            flexDiagram1.Legend.Reversed = false;
            flexDiagram1.Legend.ScrollBars = C1.Chart.LegendScrollBars.None;
            flexDiagram1.Legend.TextWrapping = C1.Chart.TextWrapping.None;
            flexDiagram1.Legend.Title = null;
            flexDiagram1.Location = new Point(4, 46);
            flexDiagram1.Margin = new Padding(4, 6, 4, 6);
            flexDiagram1.Name = "flexDiagram1";
            flexDiagram1.ScaleFactor = 6250F;
            flexDiagram1.ScaleMode = C1.Diagram.ScaleMode.ScaleToFit;
            flexDiagram1.SelectionStyle.StrokeColor = Color.Red;
            flexDiagram1.Size = new Size(620, 750);
            flexDiagram1.TabIndex = 0;
            flexDiagram1.Text = "flexDiagram1";
            // 
            // 
            // 
            flexDiagram1.ToolTip.Content = "";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(632, 46);
            tabControl1.Margin = new Padding(4, 6, 4, 6);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(621, 750);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(codeSnippet1);
            tabPage1.Location = new Point(4, 30);
            tabPage1.Margin = new Padding(4, 6, 4, 6);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4, 6, 4, 6);
            tabPage1.Size = new Size(613, 716);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Code";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // codeSnippet1
            // 
            codeSnippet1.Code = null;
            codeSnippet1.Dock = DockStyle.Fill;
            codeSnippet1.Location = new Point(4, 6);
            codeSnippet1.Margin = new Padding(4, 7, 4, 7);
            codeSnippet1.Name = "codeSnippet1";
            codeSnippet1.Size = new Size(605, 704);
            codeSnippet1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(4, 6, 4, 6);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4, 6, 4, 6);
            tabPage2.Size = new Size(613, 718);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Data";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            tableLayoutPanel1.SetColumnSpan(toolStrip1, 2);
            toolStrip1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { buttonBack, toolStripLabel1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1257, 40);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // buttonBack
            // 
            buttonBack.DisplayStyle = ToolStripItemDisplayStyle.Text;
            buttonBack.ImageTransparentColor = Color.Magenta;
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(44, 41);
            buttonBack.Text = "←";
            buttonBack.ToolTipText = "Back to Overview";
            buttonBack.Visible = false;
            buttonBack.Click += buttonBack_Click;
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(127, 37);
            toolStripLabel1.Text = "Overview";
            // 
            // statusStrip1
            // 
            tableLayoutPanel1.SetColumnSpan(statusStrip1, 2);
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 818);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 22, 0);
            statusStrip1.Size = new Size(1257, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(0, 17);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1257, 840);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 6, 4, 6);
            Name = "Form1";
            Text = "Creating FlexDiagram";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private C1.Win.Diagram.FlexDiagram flexDiagram1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private ToolStrip toolStrip1;
        private ToolStripButton buttonBack;
        private ToolStripLabel toolStripLabel1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private TabPage tabPage2;
        private Controls.CodeSnippet codeSnippet1;
    }
}
