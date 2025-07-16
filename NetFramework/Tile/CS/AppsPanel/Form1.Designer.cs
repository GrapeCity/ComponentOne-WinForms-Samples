namespace AppsPanel
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
            C1.Win.Tile.PanelElement panelElement1 = new C1.Win.Tile.PanelElement();
            C1.Win.Tile.ImageElement imageElement1 = new C1.Win.Tile.ImageElement();
            C1.Win.Tile.TextElement textElement1 = new C1.Win.Tile.TextElement();
            C1.Win.Tile.PanelElement panelElement2 = new C1.Win.Tile.PanelElement();
            C1.Win.Tile.PanelElement panelElement3 = new C1.Win.Tile.PanelElement();
            C1.Win.Tile.TextElement textElement2 = new C1.Win.Tile.TextElement();
            C1.Win.Tile.PanelElement panelElement4 = new C1.Win.Tile.PanelElement();
            C1.Win.Tile.ImageElement imageElement2 = new C1.Win.Tile.ImageElement();
            C1.Win.Tile.TextElement textElement3 = new C1.Win.Tile.TextElement();
            this.panel1 = new System.Windows.Forms.Panel();
            this.c1TileControl1 = new C1.Win.Tile.C1TileControl();
            this.group0 = new C1.Win.Tile.Group();
            this.tile5 = new C1.Win.Tile.Tile();
            this.tile17 = new C1.Win.Tile.Tile();
            this.tile6 = new C1.Win.Tile.Tile();
            this.tile10 = new C1.Win.Tile.Tile();
            this.tile8 = new C1.Win.Tile.Tile();
            this.group1 = new C1.Win.Tile.Group();
            this.tile2 = new C1.Win.Tile.Tile();
            this.subgroupTemplate = new C1.Win.Tile.Template();
            this.tile1 = new C1.Win.Tile.Tile();
            this.mapImgTemplate = new C1.Win.Tile.Template();
            this.tile12 = new C1.Win.Tile.Tile();
            this.tile13 = new C1.Win.Tile.Tile();
            this.tile7 = new C1.Win.Tile.Tile();
            this.tile14 = new C1.Win.Tile.Tile();
            this.tile15 = new C1.Win.Tile.Tile();
            this.tile16 = new C1.Win.Tile.Tile();
            this.tile3 = new C1.Win.Tile.Tile();
            this.tile4 = new C1.Win.Tile.Tile();
            this.tile9 = new C1.Win.Tile.Tile();
            this.tile11 = new C1.Win.Tile.Tile();
            this.tile18 = new C1.Win.Tile.Tile();
            this.tile19 = new C1.Win.Tile.Tile();
            this.tile20 = new C1.Win.Tile.Tile();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 417);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 55);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // c1TileControl1
            // 
            this.c1TileControl1.AllowChecking = true;
            this.c1TileControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(80)))));
            this.c1TileControl1.CellHeight = 56;
            this.c1TileControl1.CellSpacing = 4;
            this.c1TileControl1.CellWidth = 196;
            this.c1TileControl1.CheckBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(135)))));
            this.c1TileControl1.CommonImage1.Image = ((System.Drawing.Image)(resources.GetObject("c1TileControl1.CommonImage1.Image")));
            this.c1TileControl1.CommonImage1.ImageColumns = 25;
            this.c1TileControl1.CommonImage1.ImageRows = 12;
            // 
            // 
            // 
            panelElement1.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            imageElement1.FixedHeight = 40;
            imageElement1.FixedWidth = 40;
            imageElement1.ImageLayout = C1.Win.Tile.ForeImageLayout.Stretch;
            textElement1.Alignment = System.Drawing.ContentAlignment.TopLeft;
            textElement1.TextTrimming = C1.Win.Tile.TextTrimming.WordEllipsis;
            panelElement1.Children.Add(imageElement1);
            panelElement1.Children.Add(textElement1);
            panelElement1.ChildSpacing = 10;
            panelElement1.Padding = new System.Windows.Forms.Padding(8, 4, 6, 4);
            this.c1TileControl1.DefaultTemplate.Elements.Add(panelElement1);
            this.c1TileControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1TileControl1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.c1TileControl1.GroupPadding = new System.Windows.Forms.Padding(15);
            this.c1TileControl1.Groups.Add(this.group0);
            this.c1TileControl1.Groups.Add(this.group1);
            this.c1TileControl1.HotBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(89)))), ((int)(((byte)(103)))));
            this.c1TileControl1.HotCheckBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(146)))), ((int)(((byte)(151)))));
            this.c1TileControl1.Location = new System.Drawing.Point(0, 0);
            this.c1TileControl1.MaximumRowsOrColumns = 5;
            this.c1TileControl1.Name = "c1TileControl1";
            this.c1TileControl1.Padding = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.c1TileControl1.Size = new System.Drawing.Size(737, 417);
            this.c1TileControl1.SurfacePadding = new System.Windows.Forms.Padding(5, 8, 5, 5);
            this.c1TileControl1.TabIndex = 1;
            this.c1TileControl1.Templates.Add(this.subgroupTemplate);
            this.c1TileControl1.Templates.Add(this.mapImgTemplate);
            this.c1TileControl1.Text = "Apps";
            this.c1TileControl1.TextX = 28;
            this.c1TileControl1.TextY = 12;
            this.c1TileControl1.TileBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(80)))));
            this.c1TileControl1.TileBorderColor = System.Drawing.Color.Transparent;
            // 
            // group0
            // 
            this.group0.Name = "group0";
            this.group0.Tiles.Add(this.tile5);
            this.group0.Tiles.Add(this.tile17);
            this.group0.Tiles.Add(this.tile6);
            this.group0.Tiles.Add(this.tile10);
            this.group0.Tiles.Add(this.tile8);
            // 
            // tile5
            // 
            this.tile5.Image = ((System.Drawing.Image)(resources.GetObject("tile5.Image")));
            this.tile5.Name = "tile5";
            this.tile5.Text = "Calendar";
            // 
            // tile17
            // 
            this.tile17.Image = ((System.Drawing.Image)(resources.GetObject("tile17.Image")));
            this.tile17.Name = "tile17";
            this.tile17.Text = "Direct2D composite and blend effects C++ sample";
            // 
            // tile6
            // 
            this.tile6.Image = ((System.Drawing.Image)(resources.GetObject("tile6.Image")));
            this.tile6.Name = "tile6";
            this.tile6.Text = "Finance";
            // 
            // tile10
            // 
            this.tile10.Image = ((System.Drawing.Image)(resources.GetObject("tile10.Image")));
            this.tile10.Name = "tile10";
            this.tile10.Text = "OneNote";
            // 
            // tile8
            // 
            this.tile8.Image = ((System.Drawing.Image)(resources.GetObject("tile8.Image")));
            this.tile8.Name = "tile8";
            this.tile8.Text = "Weather";
            // 
            // group1
            // 
            this.group1.Name = "group1";
            this.group1.Tiles.Add(this.tile2);
            this.group1.Tiles.Add(this.tile1);
            this.group1.Tiles.Add(this.tile12);
            this.group1.Tiles.Add(this.tile13);
            this.group1.Tiles.Add(this.tile7);
            this.group1.Tiles.Add(this.tile14);
            this.group1.Tiles.Add(this.tile15);
            this.group1.Tiles.Add(this.tile16);
            this.group1.Tiles.Add(this.tile3);
            this.group1.Tiles.Add(this.tile4);
            this.group1.Tiles.Add(this.tile9);
            this.group1.Tiles.Add(this.tile11);
            this.group1.Tiles.Add(this.tile18);
            this.group1.Tiles.Add(this.tile19);
            this.group1.Tiles.Add(this.tile20);
            // 
            // tile2
            // 
            this.tile2.Name = "tile2";
            this.tile2.Template = this.subgroupTemplate;
            this.tile2.Text = "Administrative Tools";
            // 
            // subgroupTemplate
            // 
            this.subgroupTemplate.Description = "Subgroup";
            panelElement2.AlignmentOfContents = System.Drawing.ContentAlignment.BottomLeft;
            panelElement3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(92)))));
            panelElement3.Dock = System.Windows.Forms.DockStyle.Bottom;
            panelElement3.FixedHeight = 2;
            textElement2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            textElement2.ForeColorSelector = C1.Win.Tile.ForeColorSelector.Unbound;
            textElement2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 6);
            textElement2.SingleLine = true;
            panelElement2.Children.Add(panelElement3);
            panelElement2.Children.Add(textElement2);
            panelElement2.Dock = System.Windows.Forms.DockStyle.Fill;
            panelElement2.Padding = new System.Windows.Forms.Padding(8, 0, 8, 8);
            this.subgroupTemplate.Elements.Add(panelElement2);
            this.subgroupTemplate.Enabled = false;
            this.subgroupTemplate.Name = "subgroupTemplate";
            // 
            // tile1
            // 
            this.tile1.Name = "tile1";
            this.tile1.Template = this.mapImgTemplate;
            this.tile1.Text = "Component Services";
            // 
            // mapImgTemplate
            // 
            this.mapImgTemplate.Description = "Win32";
            panelElement4.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            imageElement2.ColumnIndex = 10;
            imageElement2.ColumnIndexSelector = C1.Win.Tile.IntValueSelector.Unbound;
            imageElement2.ImageSelector = C1.Win.Tile.ImageSelector.CommonImage1;
            textElement3.Alignment = System.Drawing.ContentAlignment.TopLeft;
            textElement3.TextTrimming = C1.Win.Tile.TextTrimming.WordEllipsis;
            panelElement4.Children.Add(imageElement2);
            panelElement4.Children.Add(textElement3);
            panelElement4.ChildSpacing = 10;
            panelElement4.Padding = new System.Windows.Forms.Padding(8, 4, 6, 4);
            this.mapImgTemplate.Elements.Add(panelElement4);
            this.mapImgTemplate.Name = "mapImgTemplate";
            // 
            // tile12
            // 
            this.tile12.IntValue = 1;
            this.tile12.Name = "tile12";
            this.tile12.Template = this.mapImgTemplate;
            this.tile12.Text = "Defragment and Optimize Drives";
            // 
            // tile13
            // 
            this.tile13.IntValue = 2;
            this.tile13.Name = "tile13";
            this.tile13.Template = this.mapImgTemplate;
            this.tile13.Text = "iSCSI Initiator";
            // 
            // tile7
            // 
            this.tile7.IntValue = 3;
            this.tile7.Name = "tile7";
            this.tile7.Template = this.mapImgTemplate;
            this.tile7.Text = "Task Scheduler";
            // 
            // tile14
            // 
            this.tile14.IntValue = 4;
            this.tile14.Name = "tile14";
            this.tile14.Template = this.mapImgTemplate;
            this.tile14.Text = "Windows Firewall with Advanced Security";
            // 
            // tile15
            // 
            this.tile15.Checked = true;
            this.tile15.IntValue = 5;
            this.tile15.Name = "tile15";
            this.tile15.Template = this.mapImgTemplate;
            this.tile15.Text = "Windows PowerShell (x86)";
            // 
            // tile16
            // 
            this.tile16.Name = "tile16";
            this.tile16.Template = this.subgroupTemplate;
            this.tile16.Text = "Microsoft Visual Studio 2012";
            // 
            // tile3
            // 
            this.tile3.IntValue = 6;
            this.tile3.Name = "tile3";
            this.tile3.Template = this.mapImgTemplate;
            this.tile3.Text = "Blend for Visual Studio 2012";
            // 
            // tile4
            // 
            this.tile4.IntValue = 7;
            this.tile4.Name = "tile4";
            this.tile4.Template = this.mapImgTemplate;
            this.tile4.Text = "Team Foundation Build Notifications";
            // 
            // tile9
            // 
            this.tile9.Name = "tile9";
            this.tile9.Template = this.subgroupTemplate;
            this.tile9.Text = "Windows Accessories";
            // 
            // tile11
            // 
            this.tile11.IntValue = 8;
            this.tile11.Name = "tile11";
            this.tile11.Template = this.mapImgTemplate;
            this.tile11.Text = "Calculator";
            // 
            // tile18
            // 
            this.tile18.IntValue = 9;
            this.tile18.Name = "tile18";
            this.tile18.Template = this.mapImgTemplate;
            this.tile18.Text = "Math Input Panel";
            // 
            // tile19
            // 
            this.tile19.IntValue = 10;
            this.tile19.Name = "tile19";
            this.tile19.Template = this.mapImgTemplate;
            this.tile19.Text = "Paint";
            // 
            // tile20
            // 
            this.tile20.IntValue = 11;
            this.tile20.Name = "tile20";
            this.tile20.Template = this.mapImgTemplate;
            this.tile20.Text = "Remote Desktop Connection";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(737, 472);
            this.Controls.Add(this.c1TileControl1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.Text = "All Apps Page Modelling";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private C1.Win.Tile.C1TileControl c1TileControl1;
        private C1.Win.Tile.Group group0;
        private C1.Win.Tile.Tile tile5;
        private C1.Win.Tile.Tile tile17;
        private C1.Win.Tile.Tile tile6;
        private C1.Win.Tile.Tile tile10;
        private C1.Win.Tile.Tile tile8;
        private C1.Win.Tile.Group group1;
        private C1.Win.Tile.Tile tile2;
        private C1.Win.Tile.Template subgroupTemplate;
        private C1.Win.Tile.Tile tile1;
        private C1.Win.Tile.Template mapImgTemplate;
        private C1.Win.Tile.Tile tile12;
        private C1.Win.Tile.Tile tile13;
        private C1.Win.Tile.Tile tile7;
        private C1.Win.Tile.Tile tile14;
        private C1.Win.Tile.Tile tile15;
        private C1.Win.Tile.Tile tile16;
        private C1.Win.Tile.Tile tile3;
        private C1.Win.Tile.Tile tile4;
        private C1.Win.Tile.Tile tile9;
        private C1.Win.Tile.Tile tile11;
        private C1.Win.Tile.Tile tile18;
        private C1.Win.Tile.Tile tile19;
        private C1.Win.Tile.Tile tile20;
    }
}

