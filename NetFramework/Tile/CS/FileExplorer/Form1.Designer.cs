namespace FileExplorer
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

            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            C1.Win.Tile.PanelElement panelElement1 = new C1.Win.Tile.PanelElement();
            C1.Win.Tile.ImageElement imageElement1 = new C1.Win.Tile.ImageElement();
            C1.Win.Tile.TextElement textElement1 = new C1.Win.Tile.TextElement();
            C1.Win.Tile.PanelElement panelElement2 = new C1.Win.Tile.PanelElement();
            C1.Win.Tile.ImageElement imageElement2 = new C1.Win.Tile.ImageElement();
            C1.Win.Tile.PanelElement panelElement3 = new C1.Win.Tile.PanelElement();
            C1.Win.Tile.TextElement textElement2 = new C1.Win.Tile.TextElement();
            C1.Win.Tile.TextElement textElement3 = new C1.Win.Tile.TextElement();
            C1.Win.Tile.PanelElement panelElement4 = new C1.Win.Tile.PanelElement();
            C1.Win.Tile.ImageElement imageElement3 = new C1.Win.Tile.ImageElement();
            C1.Win.Tile.PanelElement panelElement5 = new C1.Win.Tile.PanelElement();
            C1.Win.Tile.TextElement textElement4 = new C1.Win.Tile.TextElement();
            C1.Win.Tile.PanelElement panelElement6 = new C1.Win.Tile.PanelElement();
            C1.Win.Tile.TextElement textElement5 = new C1.Win.Tile.TextElement();
            C1.Win.Tile.TextElement textElement6 = new C1.Win.Tile.TextElement();
            C1.Win.Tile.PanelElement panelElement7 = new C1.Win.Tile.PanelElement();
            C1.Win.Tile.ImageElement imageElement4 = new C1.Win.Tile.ImageElement();
            C1.Win.Tile.PanelElement panelElement8 = new C1.Win.Tile.PanelElement();
            C1.Win.Tile.TextElement textElement7 = new C1.Win.Tile.TextElement();
            C1.Win.Tile.PanelElement panelElement9 = new C1.Win.Tile.PanelElement();
            C1.Win.Tile.TextElement textElement8 = new C1.Win.Tile.TextElement();
            C1.Win.Tile.TextElement textElement9 = new C1.Win.Tile.TextElement();
            C1.Win.Tile.PanelElement panelElement10 = new C1.Win.Tile.PanelElement();
            C1.Win.Tile.ImageElement imageElement5 = new C1.Win.Tile.ImageElement();
            C1.Win.Tile.TextElement textElement10 = new C1.Win.Tile.TextElement();
            this.itemTiles = new C1.Win.Tile.C1TileControl();
            this.group1 = new C1.Win.Tile.Group();
            this.tempDrive = new C1.Win.Tile.Template();
            this.tempFolder = new C1.Win.Tile.Template();
            this.tempFile = new C1.Win.Tile.Template();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.pathLabel = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.Panel();
            this.topTiles = new C1.Win.Tile.C1TileControl();
            this.group2 = new C1.Win.Tile.Group();
            this.upButton = new System.Windows.Forms.Button();
            this.tile1 = new C1.Win.Tile.Tile();
            this.tile2 = new C1.Win.Tile.Tile();
            this.tile3 = new C1.Win.Tile.Tile();
            this.upLevelTile = new C1.Win.Tile.Tile();
            this.drivesTile = new C1.Win.Tile.Tile();
            this.refreshTile = new C1.Win.Tile.Tile();
            this.newFolderTile = new C1.Win.Tile.Tile();
            this.deleteTile = new C1.Win.Tile.Tile();
            this.renameTile = new C1.Win.Tile.Tile();
            this.bottomPanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // itemTiles
            // 
            this.itemTiles.AllowChecking = true;
            this.itemTiles.BackColor = System.Drawing.Color.Gainsboro;
            this.itemTiles.CellHeight = 70;
            this.itemTiles.CellWidth = 70;
            this.itemTiles.CheckBorderColor = System.Drawing.Color.Crimson;
            // 
            // 
            // 
            panelElement1.Alignment = System.Drawing.ContentAlignment.BottomLeft;
            panelElement1.Children.Add(imageElement1);
            panelElement1.Children.Add(textElement1);
            panelElement1.Margin = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.itemTiles.DefaultTemplate.Elements.Add(panelElement1);
            this.itemTiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemTiles.FocusedBorderColor = System.Drawing.Color.RoyalBlue;
            this.itemTiles.GroupPadding = new System.Windows.Forms.Padding(10, 40, 10, 10);
            this.itemTiles.Groups.Add(this.group1);
            this.itemTiles.GroupSpacing = 5;
            this.itemTiles.GroupTextSize = 14F;
            this.itemTiles.GroupTextX = 10;
            this.itemTiles.HotBorderColor = System.Drawing.Color.White;
            this.itemTiles.Location = new System.Drawing.Point(0, 48);
            this.itemTiles.Name = "itemTiles";
            this.itemTiles.Padding = new System.Windows.Forms.Padding(0);
            this.itemTiles.Size = new System.Drawing.Size(694, 326);
            this.itemTiles.SurfacePadding = new System.Windows.Forms.Padding(15, 5, 15, 15);
            this.itemTiles.TabIndex = 0;
            this.itemTiles.Templates.Add(this.tempDrive);
            this.itemTiles.Templates.Add(this.tempFolder);
            this.itemTiles.Templates.Add(this.tempFile);
            this.itemTiles.TextSize = 16F;
            this.itemTiles.TextX = 15;
            this.itemTiles.TextY = 10;
            this.itemTiles.TileBackColor = System.Drawing.Color.IndianRed;
            this.itemTiles.TileChecked += new System.EventHandler<C1.Win.Tile.TileEventArgs>(this.itemTiles_TileCheckedChanged);
            this.itemTiles.TileUnchecked += new System.EventHandler<C1.Win.Tile.TileEventArgs>(this.itemTiles_TileCheckedChanged);
            this.itemTiles.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.itemTiles_KeyPress);
            // 
            // group1
            // 
            this.group1.Name = "group1";
            this.group1.Text = "Topic";
            this.group1.Tiles.Add(this.tile1);
            this.group1.Tiles.Add(this.tile2);
            this.group1.Tiles.Add(this.tile3);
            // 
            // tempDrive
            // 
            panelElement2.AlignmentOfContents = System.Drawing.ContentAlignment.MiddleCenter;
            panelElement2.Children.Add(imageElement2);
            panelElement2.Dock = System.Windows.Forms.DockStyle.Left;
            panelElement2.FixedWidth = 50;
            panelElement3.AlignmentOfContents = System.Drawing.ContentAlignment.MiddleLeft;
            textElement2.Alignment = System.Drawing.ContentAlignment.TopLeft;
            textElement3.Alignment = System.Drawing.ContentAlignment.BottomLeft;
            textElement3.TextSelector = C1.Win.Tile.TextSelector.Text1;
            panelElement3.Children.Add(textElement2);
            panelElement3.Children.Add(textElement3);
            panelElement3.ChildSpacing = 25;
            panelElement3.Dock = System.Windows.Forms.DockStyle.Fill;
            panelElement3.Orientation = C1.Win.Tile.LayoutOrientation.Vertical;
            this.tempDrive.Elements.Add(panelElement2);
            this.tempDrive.Elements.Add(panelElement3);
            this.tempDrive.Name = "tempDrive";
            this.tempDrive.Paint += new System.EventHandler<C1.Win.Tile.TemplatePaintEventArgs>(this.tempDrive_Paint);
            // 
            // tempFolder
            // 
            panelElement4.AlignmentOfContents = System.Drawing.ContentAlignment.MiddleCenter;
            panelElement4.Children.Add(imageElement3);
            panelElement4.Dock = System.Windows.Forms.DockStyle.Left;
            panelElement4.FixedWidth = 50;
            panelElement5.AlignmentOfContents = System.Drawing.ContentAlignment.MiddleLeft;
            textElement4.FontBold = C1.Win.Tile.ThreeStateBoolean.True;
            panelElement5.Children.Add(textElement4);
            panelElement5.Dock = System.Windows.Forms.DockStyle.Top;
            panelElement5.FixedHeight = 33;
            panelElement5.Padding = new System.Windows.Forms.Padding(0, 2, 4, 0);
            panelElement6.Alignment = System.Drawing.ContentAlignment.TopLeft;
            textElement5.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            textElement5.Text = "Folder Last Write Time:";
            textElement5.TextSelector = C1.Win.Tile.TextSelector.Unbound;
            textElement6.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            textElement6.TextSelector = C1.Win.Tile.TextSelector.Text1;
            panelElement6.Children.Add(textElement5);
            panelElement6.Children.Add(textElement6);
            panelElement6.ChildSpacing = 2;
            panelElement6.Dock = System.Windows.Forms.DockStyle.Fill;
            panelElement6.Orientation = C1.Win.Tile.LayoutOrientation.Vertical;
            this.tempFolder.Elements.Add(panelElement4);
            this.tempFolder.Elements.Add(panelElement5);
            this.tempFolder.Elements.Add(panelElement6);
            this.tempFolder.Name = "tempFolder";
            // 
            // tempFile
            // 
            panelElement7.AlignmentOfContents = System.Drawing.ContentAlignment.MiddleCenter;
            panelElement7.Children.Add(imageElement4);
            panelElement7.Dock = System.Windows.Forms.DockStyle.Left;
            panelElement7.FixedWidth = 50;
            panelElement8.AlignmentOfContents = System.Drawing.ContentAlignment.MiddleLeft;
            textElement7.FontBold = C1.Win.Tile.ThreeStateBoolean.True;
            panelElement8.Children.Add(textElement7);
            panelElement8.Dock = System.Windows.Forms.DockStyle.Top;
            panelElement8.FixedHeight = 33;
            panelElement8.Padding = new System.Windows.Forms.Padding(0, 2, 4, 0);
            panelElement9.Alignment = System.Drawing.ContentAlignment.TopLeft;
            textElement8.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            textElement8.TextSelector = C1.Win.Tile.TextSelector.Text1;
            textElement9.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            textElement9.TextSelector = C1.Win.Tile.TextSelector.Text2;
            panelElement9.Children.Add(textElement8);
            panelElement9.Children.Add(textElement9);
            panelElement9.ChildSpacing = 2;
            panelElement9.Dock = System.Windows.Forms.DockStyle.Fill;
            panelElement9.Orientation = C1.Win.Tile.LayoutOrientation.Vertical;
            this.tempFile.Elements.Add(panelElement7);
            this.tempFile.Elements.Add(panelElement8);
            this.tempFile.Elements.Add(panelElement9);
            this.tempFile.Name = "tempFile";
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.DimGray;
            this.bottomPanel.Controls.Add(this.pathLabel);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.ForeColor = System.Drawing.Color.White;
            this.bottomPanel.Location = new System.Drawing.Point(0, 374);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(694, 34);
            this.bottomPanel.TabIndex = 1;
            // 
            // pathLabel
            // 
            this.pathLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pathLabel.Location = new System.Drawing.Point(14, 2);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(675, 30);
            this.pathLabel.TabIndex = 1;
            this.pathLabel.Text = "(Drives)";
            this.pathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.topTiles);
            this.topPanel.Controls.Add(this.upButton);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(694, 48);
            this.topPanel.TabIndex = 2;
            // 
            // topTiles
            // 
            this.topTiles.AllowPanningFeedback = false;
            this.topTiles.BackColor = System.Drawing.Color.Silver;
            this.topTiles.CellHeight = 40;
            this.topTiles.CellSpacing = 6;
            this.topTiles.CellWidth = 96;
            // 
            // 
            // 
            panelElement10.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            imageElement5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            panelElement10.Children.Add(imageElement5);
            panelElement10.Children.Add(textElement10);
            panelElement10.ChildSpacing = 2;
            panelElement10.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.topTiles.DefaultTemplate.Elements.Add(panelElement10);
            this.topTiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topTiles.FocusedBorderColor = System.Drawing.Color.ForestGreen;
            this.topTiles.GroupPadding = new System.Windows.Forms.Padding(4);
            this.topTiles.Groups.Add(this.group2);
            this.topTiles.HotBorderColor = System.Drawing.Color.White;
            this.topTiles.Location = new System.Drawing.Point(0, 0);
            this.topTiles.Name = "topTiles";
            this.topTiles.Padding = new System.Windows.Forms.Padding(0);
            this.topTiles.Size = new System.Drawing.Size(694, 48);
            this.topTiles.SurfacePadding = new System.Windows.Forms.Padding(0);
            this.topTiles.TabIndex = 1;
            this.topTiles.TabStop = false;
            this.topTiles.TileBackColor = System.Drawing.Color.DimGray;
            // 
            // group2
            // 
            this.group2.Name = "group2";
            this.group2.Tiles.Add(this.upLevelTile);
            this.group2.Tiles.Add(this.drivesTile);
            this.group2.Tiles.Add(this.refreshTile);
            this.group2.Tiles.Add(this.newFolderTile);
            this.group2.Tiles.Add(this.deleteTile);
            this.group2.Tiles.Add(this.renameTile);
            // 
            // upButton
            // 
            this.upButton.Location = new System.Drawing.Point(596, 28);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(87, 27);
            this.upButton.TabIndex = 0;
            this.upButton.Text = "One Level Up";
            this.upButton.UseVisualStyleBackColor = true;
            // 
            // tile1
            // 
            this.tile1.HorizontalSize = 3;
            this.tile1.Image = global::FileExplorer.Properties.Resources.otherDrive;
            this.tile1.Name = "tile1";
            this.tile1.Symbol = C1.Win.Tile.TileSymbol.Device;
            this.tile1.Template = this.tempDrive;
            this.tile1.Text = "WIN7 (C:)";
            this.tile1.Text1 = "15.3 GB free of 44.0 GB";
            // 
            // tile2
            // 
            this.tile2.BackColor = System.Drawing.Color.SteelBlue;
            this.tile2.HorizontalSize = 3;
            this.tile2.Image = global::FileExplorer.Properties.Resources.folder;
            this.tile2.Name = "tile2";
            this.tile2.Symbol = C1.Win.Tile.TileSymbol.BrowseByAlbum;
            this.tile2.Template = this.tempFolder;
            this.tile2.Text = "Program Files (x86)";
            this.tile2.Text1 = "3/24/2013 12:58 PM";
            // 
            // tile3
            // 
            this.tile3.BackColor = System.Drawing.Color.Green;
            this.tile3.HorizontalSize = 3;
            this.tile3.Image = global::FileExplorer.Properties.Resources.file;
            this.tile3.Name = "tile3";
            this.tile3.Symbol = C1.Win.Tile.TileSymbol.Files;
            this.tile3.Template = this.tempFile;
            this.tile3.Text = "DSC04278.JPG";
            this.tile3.Text1 = "Updated: 12/31/2012 12:58 PM";
            this.tile3.Text2 = "5.96 GB";
            // 
            // upLevelTile
            // 
            this.upLevelTile.Image = global::FileExplorer.Properties.Resources.upLevel;
            this.upLevelTile.Name = "upLevelTile";
            this.upLevelTile.Text = "Level Up";
            this.upLevelTile.Click += new System.EventHandler(this.upLevelTile_Click);
            // 
            // drivesTile
            // 
            this.drivesTile.Image = global::FileExplorer.Properties.Resources.drives;
            this.drivesTile.Name = "drivesTile";
            this.drivesTile.Symbol = C1.Win.Tile.TileSymbol.VerticalDots;
            this.drivesTile.Text = "Drives";
            this.drivesTile.Click += new System.EventHandler(this.drivesTile_Click);
            // 
            // refreshTile
            // 
            this.refreshTile.Image = global::FileExplorer.Properties.Resources.refresh;
            this.refreshTile.Name = "refreshTile";
            this.refreshTile.Text = "Refresh";
            this.refreshTile.Click += new System.EventHandler(this.refreshTile_Click);
            // 
            // newFolderTile
            // 
            this.newFolderTile.Image = global::FileExplorer.Properties.Resources.newFolder;
            this.newFolderTile.Name = "newFolderTile";
            this.newFolderTile.Text = "New Folder";
            this.newFolderTile.Click += new System.EventHandler(this.newFolderTile_Click);
            // 
            // deleteTile
            // 
            this.deleteTile.Image = global::FileExplorer.Properties.Resources.delete;
            this.deleteTile.Name = "deleteTile";
            this.deleteTile.Text = "Delete";
            this.deleteTile.Click += new System.EventHandler(this.deleteTile_Click);
            // 
            // renameTile
            // 
            this.renameTile.Image = global::FileExplorer.Properties.Resources.rename;
            this.renameTile.Name = "renameTile";
            this.renameTile.Text = "Rename";
            this.renameTile.Click += new System.EventHandler(this.renameTile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(694, 408);
            this.Controls.Add(this.itemTiles);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.topPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "Form1";
            this.Text = "File Explorer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.bottomPanel.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.Tile.C1TileControl itemTiles;
        private C1.Win.Tile.Group group1;
        private C1.Win.Tile.Tile tile1;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button upButton;
        private C1.Win.Tile.C1TileControl topTiles;
        private C1.Win.Tile.Group group2;
        private C1.Win.Tile.Tile upLevelTile;
        private C1.Win.Tile.Tile drivesTile;
        private C1.Win.Tile.Tile newFolderTile;
        private System.Windows.Forms.Label pathLabel;
        private C1.Win.Tile.Tile tile2;
        private C1.Win.Tile.Tile tile3;
        private C1.Win.Tile.Template tempDrive;
        private C1.Win.Tile.Template tempFolder;
        private C1.Win.Tile.Template tempFile;
        private C1.Win.Tile.Tile refreshTile;
        private C1.Win.Tile.Tile deleteTile;
        private C1.Win.Tile.Tile renameTile;

    }
}

