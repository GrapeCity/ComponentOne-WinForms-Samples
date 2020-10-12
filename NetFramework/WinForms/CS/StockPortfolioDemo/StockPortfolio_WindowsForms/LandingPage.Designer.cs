using System;
namespace StockPortfolio
{
    partial class LandingPage : IDisposable
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
                _stockDataProcess.Dispose();
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
            C1.Win.C1Tile.TextElement textElement2 = new C1.Win.C1Tile.TextElement();
            C1.Win.C1Tile.TextElement textElement3 = new C1.Win.C1Tile.TextElement();
            C1.Win.C1Tile.PanelElement panelElement1 = new C1.Win.C1Tile.PanelElement();
            C1.Win.C1Tile.TextElement textElement4 = new C1.Win.C1Tile.TextElement();
            C1.Win.C1Tile.PanelElement panelElement2 = new C1.Win.C1Tile.PanelElement();
            C1.Win.C1Tile.TextElement textElement5 = new C1.Win.C1Tile.TextElement();
            C1.Win.C1Tile.PanelElement panelElement3 = new C1.Win.C1Tile.PanelElement();
            C1.Win.C1Tile.TextElement textElement6 = new C1.Win.C1Tile.TextElement();
            C1.Win.C1Tile.ImageElement imageElement1 = new C1.Win.C1Tile.ImageElement();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblIndexDataUpdatedSince = new System.Windows.Forms.Label();
            this.lblAppName2 = new System.Windows.Forms.Label();
            this.StockIndexTemplate = new C1.Win.C1Tile.Template();
            this.group1 = new C1.Win.C1Tile.Group();
            this.tileNasdaq = new C1.Win.C1Tile.Tile();
            this.tileLondon = new C1.Win.C1Tile.Tile();
            this.tiletokoyo = new C1.Win.C1Tile.Tile();
            this.tileIndia = new C1.Win.C1Tile.Tile();
            this.c1TileControl1 = new C1.Win.C1Tile.C1TileControl();
            this.ForwardTileControl = new C1.Win.C1Tile.C1TileControl();
            this.group5 = new C1.Win.C1Tile.Group();
            this.ForwardTile = new C1.Win.C1Tile.Tile();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.lblIndexDataUpdatedSince);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 615);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1083, 25);
            this.panel1.TabIndex = 1;
            // 
            // lblIndexDataUpdatedSince
            // 
            this.lblIndexDataUpdatedSince.AutoSize = true;
            this.lblIndexDataUpdatedSince.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndexDataUpdatedSince.ForeColor = System.Drawing.Color.Silver;
            this.lblIndexDataUpdatedSince.Location = new System.Drawing.Point(745, 0);
            this.lblIndexDataUpdatedSince.Name = "lblIndexDataUpdatedSince";
            this.lblIndexDataUpdatedSince.Size = new System.Drawing.Size(293, 17);
            this.lblIndexDataUpdatedSince.TabIndex = 0;
            this.lblIndexDataUpdatedSince.Text = "Last Updated Thursday, 11 July 11, 2013,8:16 AM";
            // 
            // lblAppName2
            // 
            this.lblAppName2.AutoSize = true;
            this.lblAppName2.Location = new System.Drawing.Point(154, 36);
            this.lblAppName2.Name = "lblAppName2";
            this.lblAppName2.Size = new System.Drawing.Size(0, 13);
            this.lblAppName2.TabIndex = 3;
            // 
            // StockIndexTemplate
            // 
            this.StockIndexTemplate.Description = "Stock Template for StockIndex";
            textElement1.Alignment = System.Drawing.ContentAlignment.TopCenter;
            textElement1.AlignmentOfContents = System.Drawing.ContentAlignment.TopCenter;
            textElement1.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textElement1.FontBold = C1.Win.C1Tile.ThreeStateBoolean.True;
            textElement2.AlignmentOfContents = System.Drawing.ContentAlignment.MiddleCenter;
            textElement2.Font = new System.Drawing.Font("Segoe UI Light", 7.5F);
            textElement2.FontBold = C1.Win.C1Tile.ThreeStateBoolean.True;
            textElement2.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            textElement2.SingleLine = true;
            textElement2.TextSelector = C1.Win.C1Tile.TextSelector.Text1;
            textElement3.Alignment = System.Drawing.ContentAlignment.BottomCenter;
            textElement3.AlignmentOfContents = System.Drawing.ContentAlignment.BottomCenter;
            textElement3.Font = new System.Drawing.Font("Segoe UI Light", 7.5F);
            textElement3.FontBold = C1.Win.C1Tile.ThreeStateBoolean.True;
            textElement3.TextSelector = C1.Win.C1Tile.TextSelector.Text2;
            this.StockIndexTemplate.Elements.Add(textElement1);
            this.StockIndexTemplate.Elements.Add(textElement2);
            this.StockIndexTemplate.Elements.Add(textElement3);
            this.StockIndexTemplate.Name = "StockIndexTemplate";
            // 
            // group1
            // 
            this.group1.Name = "group1";
            this.group1.Tiles.Add(this.tileNasdaq);
            this.group1.Tiles.Add(this.tileLondon);
            this.group1.Tiles.Add(this.tiletokoyo);
            this.group1.Tiles.Add(this.tileIndia);
            // 
            // tileNasdaq
            // 
            this.tileNasdaq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(107)))), ((int)(((byte)(143)))));
            this.tileNasdaq.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(87)))), ((int)(((byte)(123)))));
            this.tileNasdaq.LeftCell = 5;
            this.tileNasdaq.Name = "tileNasdaq";
            this.tileNasdaq.Symbol = C1.Win.C1Tile.TileSymbol.Like;
            this.tileNasdaq.Tag = "0";
            this.tileNasdaq.Text = "NASDAQ";
            this.tileNasdaq.Text1 = "1235";
            this.tileNasdaq.Text2 = "23%";
            this.tileNasdaq.Text3 = "^IXIC";
            this.tileNasdaq.TopCell = 7;
            // 
            // tileLondon
            // 
            this.tileLondon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(62)))), ((int)(((byte)(82)))));
            this.tileLondon.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(42)))), ((int)(((byte)(62)))));
            this.tileLondon.LeftCell = 7;
            this.tileLondon.Name = "tileLondon";
            this.tileLondon.Symbol = C1.Win.C1Tile.TileSymbol.Dislike;
            this.tileLondon.Text = "LSE(UK)";
            this.tileLondon.Text1 = "1234";
            this.tileLondon.Text2 = "3.6%";
            this.tileLondon.Text3 = "LSE.L";
            this.tileLondon.TopCell = 7;
            // 
            // tiletokoyo
            // 
            this.tiletokoyo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(78)))));
            this.tiletokoyo.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(213)))), ((int)(((byte)(58)))));
            this.tiletokoyo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tiletokoyo.LeftCell = 12;
            this.tiletokoyo.Name = "tiletokoyo";
            this.tiletokoyo.Symbol = C1.Win.C1Tile.TileSymbol.Dislike;
            this.tiletokoyo.Text = "NIKKEI ";
            this.tiletokoyo.Text1 = "156";
            this.tiletokoyo.Text2 = "67%";
            this.tiletokoyo.Text3 = "^N225";
            this.tiletokoyo.TopCell = 6;
            // 
            // tileIndia
            // 
            this.tileIndia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(230)))), ((int)(((byte)(179)))));
            this.tileIndia.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(210)))), ((int)(((byte)(159)))));
            this.tileIndia.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tileIndia.LeftCell = 9;
            this.tileIndia.Name = "tileIndia";
            this.tileIndia.Symbol = C1.Win.C1Tile.TileSymbol.Like;
            this.tileIndia.Text = "BSE";
            this.tileIndia.Text1 = "123";
            this.tileIndia.Text2 = "67%";
            this.tileIndia.Text3 = "^BSESN";
            this.tileIndia.TopCell = 11;
            // 
            // c1TileControl1
            // 
            this.c1TileControl1.AllowChecking = true;
            this.c1TileControl1.AutomaticLayout = false;
            this.c1TileControl1.BackgroundImage = global::StockPortfolio.Properties.Resources.mapBackground;
            this.c1TileControl1.BackImageLayout = C1.Win.C1Tile.BackImageLayout.Stretch;
            this.c1TileControl1.CellHeight = 30;
            this.c1TileControl1.CellSpacing = 0;
            this.c1TileControl1.CellWidth = 80;
            // 
            // 
            // 
            panelElement1.Alignment = System.Drawing.ContentAlignment.TopLeft;
            panelElement1.AlignmentOfContents = System.Drawing.ContentAlignment.MiddleCenter;
            panelElement1.BackColor = System.Drawing.Color.MediumVioletRed;
            panelElement1.BackColorSelector = C1.Win.C1Tile.BackColorSelector.BackColor1;
            textElement4.AlignmentOfContents = System.Drawing.ContentAlignment.MiddleCenter;
            textElement4.BackColor = System.Drawing.Color.MediumVioletRed;
            textElement4.BackColorSelector = C1.Win.C1Tile.BackColorSelector.BackColor1;
            textElement4.Font = new System.Drawing.Font("Segoe UI", 8F);
            textElement4.FontBold = C1.Win.C1Tile.ThreeStateBoolean.True;
            panelElement1.Children.Add(textElement4);
            panelElement1.ChildSpacing = 0;
            panelElement1.FixedHeight = 30;
            panelElement1.FixedWidth = 100;
            panelElement2.BackColorSelector = C1.Win.C1Tile.BackColorSelector.BackColor1;
            textElement5.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            textElement5.TextSelector = C1.Win.C1Tile.TextSelector.Text1;
            panelElement2.Children.Add(textElement5);
            panelElement2.Margin = new System.Windows.Forms.Padding(10, 5, 0, 0);
            panelElement2.VisibleSelector = C1.Win.C1Tile.IntValueSelector.Default;
            panelElement3.BackColorSelector = C1.Win.C1Tile.BackColorSelector.BackColor1;
            textElement6.Font = new System.Drawing.Font("Segoe UI", 16.25F);
            textElement6.TextSelector = C1.Win.C1Tile.TextSelector.Text2;
            panelElement3.Children.Add(textElement6);
            panelElement3.Margin = new System.Windows.Forms.Padding(0, 65, 0, 0);
            panelElement3.VisibleSelector = C1.Win.C1Tile.IntValueSelector.Default;
            this.c1TileControl1.DefaultTemplate.Elements.Add(panelElement1);
            this.c1TileControl1.DefaultTemplate.Elements.Add(panelElement2);
            this.c1TileControl1.DefaultTemplate.Elements.Add(panelElement3);
            this.c1TileControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1TileControl1.GroupPadding = new System.Windows.Forms.Padding(0);
            this.c1TileControl1.Groups.Add(this.group1);
            this.c1TileControl1.HotBorderColor = System.Drawing.SystemColors.Highlight;
            this.c1TileControl1.Location = new System.Drawing.Point(0, 0);
            this.c1TileControl1.Margin = new System.Windows.Forms.Padding(0);
            this.c1TileControl1.Name = "c1TileControl1";
            this.c1TileControl1.Padding = new System.Windows.Forms.Padding(0);
            this.c1TileControl1.PassthroughNavigation = true;
            this.c1TileControl1.Size = new System.Drawing.Size(1083, 640);
            this.c1TileControl1.SurfacePadding = new System.Windows.Forms.Padding(0);
            this.c1TileControl1.TabIndex = 0;
            this.c1TileControl1.Templates.Add(this.StockIndexTemplate);
            this.c1TileControl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.c1TileControl1_MouseMove);
            // 
            // ForwardTileControl
            // 
            this.ForwardTileControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ForwardTileControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(80)))));
            this.ForwardTileControl.CellHeight = 48;
            this.ForwardTileControl.CellSpacing = 0;
            this.ForwardTileControl.CellWidth = 48;
            this.ForwardTileControl.CheckMarkColor = System.Drawing.Color.Black;
            this.ForwardTileControl.CheckWaitingColor = System.Drawing.Color.Black;
            // 
            // 
            // 
            imageElement1.ImageSelector = C1.Win.C1Tile.ImageSelector.Symbol;
            imageElement1.SymbolSize = C1.Win.C1Tile.SymbolSize.Image48x48;
            this.ForwardTileControl.DefaultTemplate.Elements.Add(imageElement1);
            this.ForwardTileControl.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ForwardTileControl.GroupPadding = new System.Windows.Forms.Padding(0);
            this.ForwardTileControl.Groups.Add(this.group5);
            this.ForwardTileControl.HotBackColor = System.Drawing.Color.Transparent;
            this.ForwardTileControl.HotBorderColor = System.Drawing.Color.Transparent;
            this.ForwardTileControl.HotForeColor = System.Drawing.SystemColors.HighlightText;
            this.ForwardTileControl.Location = new System.Drawing.Point(1017, 12);
            this.ForwardTileControl.Name = "ForwardTileControl";
            this.ForwardTileControl.Padding = new System.Windows.Forms.Padding(4);
            this.ForwardTileControl.Size = new System.Drawing.Size(56, 56);
            this.ForwardTileControl.SurfacePadding = new System.Windows.Forms.Padding(0);
            this.ForwardTileControl.SwipeDistance = 1;
            this.ForwardTileControl.TabIndex = 4;
            this.ForwardTileControl.TileBackColor = System.Drawing.Color.Transparent;
            this.ForwardTileControl.TileBorderColor = System.Drawing.Color.Transparent;
            // 
            // group5
            // 
            this.group5.Name = "group5";
            this.group5.Text = "Group 1";
            this.group5.Tiles.Add(this.ForwardTile);
            // 
            // ForwardTile
            // 
            this.ForwardTile.BackColor = System.Drawing.Color.Transparent;
            this.ForwardTile.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ForwardTile.Name = "ForwardTile";
            this.ForwardTile.Symbol = C1.Win.C1Tile.TileSymbol.NavigateForward;
            // 
            // LandingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ForwardTileControl);
            this.Controls.Add(this.lblAppName2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.c1TileControl1);
            this.Name = "LandingPage";
            this.Size = new System.Drawing.Size(1083, 640);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblIndexDataUpdatedSince;
        private System.Windows.Forms.Label lblAppName2;
        private C1.Win.C1Tile.Template StockIndexTemplate;
        private C1.Win.C1Tile.Group group1;
        private C1.Win.C1Tile.Tile tileNasdaq;
        private C1.Win.C1Tile.Tile tileLondon;
        private C1.Win.C1Tile.Tile tiletokoyo;
        private C1.Win.C1Tile.Tile tileIndia;
        public C1.Win.C1Tile.C1TileControl c1TileControl1;
        public C1.Win.C1Tile.C1TileControl ForwardTileControl;
        private C1.Win.C1Tile.Group group5;
        public C1.Win.C1Tile.Tile ForwardTile;
    }
}
