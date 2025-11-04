using FlexGridExplorer.Component;
using FlexGridExplorer.Component.SideMenu;
using FlexGridExplorer.Component.Tile;

namespace FlexGridExplorer
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
            tableLayoutPanel1 = new TableLayoutPanel();
            sideBar1 = new FlexGridExplorer.Component.SideMenu.SideBar();
            pnlSample = new Panel();
            sampleHost1 = new FlexGridExplorer.Component.SampleViewer();
            tileControl1 = new FlexGridExplorer.Component.Tile.TileControl();
            tableLayoutPanel1.SuspendLayout();
            pnlSample.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(249, 248, 248);
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(sideBar1, 0, 0);
            tableLayoutPanel1.Controls.Add(pnlSample, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(1, 2, 1, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1405, 766);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // sideBar1
            // 
            sideBar1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            sideBar1.Collapsed = false;
            sideBar1.Dock = DockStyle.Fill;
            sideBar1.Location = new Point(2, 2);
            sideBar1.Margin = new Padding(2);
            sideBar1.Name = "sideBar1";
            sideBar1.Samples = null;
            sideBar1.Size = new Size(400, 762);
            sideBar1.TabIndex = 1;
            // 
            // pnlSample
            // 
            pnlSample.BackColor = Color.FromArgb(249, 248, 248);
            pnlSample.Controls.Add(sampleHost1);
            pnlSample.Controls.Add(tileControl1);
            pnlSample.Dock = DockStyle.Fill;
            pnlSample.Location = new Point(407, 3);
            pnlSample.Name = "pnlSample";
            pnlSample.Size = new Size(995, 760);
            pnlSample.TabIndex = 0;
            // 
            // sampleHost1
            // 
            sampleHost1.BackColor = Color.FromArgb(249, 248, 248);
            sampleHost1.Dock = DockStyle.Fill;
            sampleHost1.Location = new Point(0, 0);
            sampleHost1.Margin = new Padding(4);
            sampleHost1.Name = "sampleHost1";
            sampleHost1.Sample = null;
            sampleHost1.Size = new Size(995, 760);
            sampleHost1.TabIndex = 0;
            // 
            // tileControl1
            // 
            tileControl1.AutoScroll = true;
            tileControl1.BackColor = Color.FromArgb(249, 248, 248);
            tileControl1.Dock = DockStyle.Fill;
            tileControl1.HoverColor = Color.Empty;
            tileControl1.Location = new Point(0, 0);
            tileControl1.Margin = new Padding(4);
            tileControl1.Name = "tileControl1";
            tileControl1.Size = new Size(995, 760);
            tileControl1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1405, 766);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1000, 500);
            Name = "Form1";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            pnlSample.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel pnlSample;
        private SideBar sideBar1;
        private SampleViewer sampleHost1;
        private TileControl tileControl1;
    }
}