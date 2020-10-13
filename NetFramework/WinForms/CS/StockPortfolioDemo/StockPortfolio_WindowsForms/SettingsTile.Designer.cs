namespace StockPortfolio
{
    partial class SettingsTile
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
            C1.Win.C1Tile.TextElement textElement1 = new C1.Win.C1Tile.TextElement();
            C1.Win.C1Tile.ImageElement imageElement1 = new C1.Win.C1Tile.ImageElement();
            this.group1 = new C1.Win.C1Tile.Group();
            this.TileSettings = new C1.Win.C1Tile.Tile();
            this.TileRemove = new C1.Win.C1Tile.Tile();
            this.TileSearch = new C1.Win.C1Tile.Tile();
            this.TileRefresh = new C1.Win.C1Tile.Tile();
            this.TileAllSettings = new C1.Win.C1Tile.C1TileControl();
            this.SuspendLayout();
            // 
            // group1
            // 
            this.group1.Name = "group1";
            this.group1.Text = "Group 1";
            this.group1.Tiles.Add(this.TileSettings);
            this.group1.Tiles.Add(this.TileRemove);
            this.group1.Tiles.Add(this.TileSearch);
            this.group1.Tiles.Add(this.TileRefresh);
            // 
            // TileSettings
            // 
            this.TileSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.TileSettings.Name = "TileSettings";
            this.TileSettings.Symbol = C1.Win.C1Tile.TileSymbol.Settings;
            this.TileSettings.Text = "Settings";
            this.TileSettings.Visible = false;
            // 
            // TileRemove
            // 
            this.TileRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.TileRemove.Name = "TileRemove";
            this.TileRemove.Symbol = C1.Win.C1Tile.TileSymbol.Delete;
            this.TileRemove.Text = "Remove";
            this.TileRemove.Click += new System.EventHandler(this.TileRemove_Click);
            // 
            // TileSearch
            // 
            this.TileSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.TileSearch.Name = "TileSearch";
            this.TileSearch.Symbol = C1.Win.C1Tile.TileSymbol.Find;
            this.TileSearch.Text = "Search";
            this.TileSearch.Click += new System.EventHandler(this.TileSearch_Click);
            // 
            // TileRefresh
            // 
            this.TileRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.TileRefresh.Name = "TileRefresh";
            this.TileRefresh.Symbol = C1.Win.C1Tile.TileSymbol.Sync;
            this.TileRefresh.Text = "Refresh";
            this.TileRefresh.Click += new System.EventHandler(this.TileRefresh_Click);
            // 
            // TileAllSettings
            // 
            this.TileAllSettings.AllowRearranging = true;
            this.TileAllSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.TileAllSettings.CellHeight = 70;
            this.TileAllSettings.CellWidth = 70;
            // 
            // 
            // 
            textElement1.Alignment = System.Drawing.ContentAlignment.BottomCenter;
            textElement1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textElement1.Margin = new System.Windows.Forms.Padding(5);
            imageElement1.AlignmentOfContents = System.Drawing.ContentAlignment.MiddleCenter;
            imageElement1.ImageSelector = C1.Win.C1Tile.ImageSelector.Symbol;
            imageElement1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 15);
            imageElement1.Symbol = C1.Win.C1Tile.TileSymbol.Home;
            imageElement1.SymbolSize = C1.Win.C1Tile.SymbolSize.Image48x48;
            this.TileAllSettings.DefaultTemplate.Elements.Add(textElement1);
            this.TileAllSettings.DefaultTemplate.Elements.Add(imageElement1);
            this.TileAllSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TileAllSettings.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TileAllSettings.GroupPadding = new System.Windows.Forms.Padding(10);
            this.TileAllSettings.Groups.Add(this.group1);
            this.TileAllSettings.HotBackColor = System.Drawing.Color.Transparent;
            this.TileAllSettings.HotBorderColor = System.Drawing.Color.Transparent;
            this.TileAllSettings.HotForeColor = System.Drawing.SystemColors.HotTrack;
            this.TileAllSettings.Location = new System.Drawing.Point(10, 0);
            this.TileAllSettings.Margin = new System.Windows.Forms.Padding(0);
            this.TileAllSettings.Name = "TileAllSettings";
            this.TileAllSettings.Padding = new System.Windows.Forms.Padding(0);
            this.TileAllSettings.SBThumbBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.TileAllSettings.SBThumbInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.TileAllSettings.Size = new System.Drawing.Size(521, 91);
            this.TileAllSettings.SurfacePadding = new System.Windows.Forms.Padding(0);
            this.TileAllSettings.SwipeDistance = 10;
            this.TileAllSettings.TabIndex = 1;
            this.TileAllSettings.TileBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.TileAllSettings.TileBorderColor = System.Drawing.Color.Transparent;
            this.TileAllSettings.TileForeColor = System.Drawing.SystemColors.WindowText;
            this.TileAllSettings.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TileAllSettings_MouseClick);
            // 
            // SettingsTile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.TileAllSettings);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "SettingsTile";
            this.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Size = new System.Drawing.Size(531, 91);
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1Tile.Group group1;
        private C1.Win.C1Tile.Tile TileSettings;
        private C1.Win.C1Tile.Tile TileRemove;
        private C1.Win.C1Tile.Tile TileSearch;
        private C1.Win.C1Tile.Tile TileRefresh;
        public C1.Win.C1Tile.C1TileControl TileAllSettings;



    }
}
