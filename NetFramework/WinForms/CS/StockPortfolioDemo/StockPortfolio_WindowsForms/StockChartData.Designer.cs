namespace StockPortfolio
{
    partial class StockChartData
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
                _stockData.Dispose();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockChartData));
            C1.Win.C1Tile.PanelElement panelElement1 = new C1.Win.C1Tile.PanelElement();
            C1.Win.C1Tile.TextElement textElement1 = new C1.Win.C1Tile.TextElement();
            this.c1SplitContainer1 = new C1.Win.C1SplitContainer.C1SplitContainer();
            this.StockSummaryPanel = new C1.Win.C1SplitContainer.C1SplitterPanel();
            this.lblVolumeDetail = new System.Windows.Forms.Label();
            this.lblVolume = new System.Windows.Forms.Label();
            this.lblAdjCloseDetail = new System.Windows.Forms.Label();
            this.lblAdjClose = new System.Windows.Forms.Label();
            this.lblLowDetail = new System.Windows.Forms.Label();
            this.lblLow = new System.Windows.Forms.Label();
            this.lblHighDetail = new System.Windows.Forms.Label();
            this.lblHigh = new System.Windows.Forms.Label();
            this.lblCloseDetail = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.lblOpen = new System.Windows.Forms.Label();
            this.lblSymbolDetail = new System.Windows.Forms.Label();
            this.lblSymbol = new System.Windows.Forms.Label();
            this.lblOpenDetail = new System.Windows.Forms.Label();
            this.lblCompanyDetail = new System.Windows.Forms.Label();
            this.lblCompany = new System.Windows.Forms.Label();
            this.StockChartPanel = new C1.Win.C1SplitContainer.C1SplitterPanel();
            this.StockChart = new C1.Win.C1Chart.C1Chart();
            this.DurationTilePanel = new C1.Win.C1SplitContainer.C1SplitterPanel();
            this.TileControlDuration = new C1.Win.C1Tile.C1TileControl();
            this.group1 = new C1.Win.C1Tile.Group();
            this.tileWeek = new C1.Win.C1Tile.Tile();
            this.tileMonth = new C1.Win.C1Tile.Tile();
            this.tileQuarter = new C1.Win.C1Tile.Tile();
            this.tileHalfyear = new C1.Win.C1Tile.Tile();
            this.tileOneYear = new C1.Win.C1Tile.Tile();
            this.tile3Years = new C1.Win.C1Tile.Tile();
            this.tile5years = new C1.Win.C1Tile.Tile();
            this.backgroundWorkerChart = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.c1SplitContainer1)).BeginInit();
            this.c1SplitContainer1.SuspendLayout();
            this.StockSummaryPanel.SuspendLayout();
            this.StockChartPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StockChart)).BeginInit();
            this.DurationTilePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // c1SplitContainer1
            // 
            this.c1SplitContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.c1SplitContainer1.CollapsingCueColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.c1SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1SplitContainer1.FixedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.c1SplitContainer1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.c1SplitContainer1.HeaderHeight = 0;
            this.c1SplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.c1SplitContainer1.Name = "c1SplitContainer1";
            this.c1SplitContainer1.Panels.Add(this.StockSummaryPanel);
            this.c1SplitContainer1.Panels.Add(this.StockChartPanel);
            this.c1SplitContainer1.Panels.Add(this.DurationTilePanel);
            this.c1SplitContainer1.Size = new System.Drawing.Size(813, 462);
            this.c1SplitContainer1.SplitterColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.c1SplitContainer1.SplitterWidth = 0;
            this.c1SplitContainer1.TabIndex = 0;
            this.c1SplitContainer1.UseParentVisualStyle = false;
            // 
            // StockSummaryPanel
            // 
            this.StockSummaryPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.StockSummaryPanel.Controls.Add(this.lblVolumeDetail);
            this.StockSummaryPanel.Controls.Add(this.lblVolume);
            this.StockSummaryPanel.Controls.Add(this.lblAdjCloseDetail);
            this.StockSummaryPanel.Controls.Add(this.lblAdjClose);
            this.StockSummaryPanel.Controls.Add(this.lblLowDetail);
            this.StockSummaryPanel.Controls.Add(this.lblLow);
            this.StockSummaryPanel.Controls.Add(this.lblHighDetail);
            this.StockSummaryPanel.Controls.Add(this.lblHigh);
            this.StockSummaryPanel.Controls.Add(this.lblCloseDetail);
            this.StockSummaryPanel.Controls.Add(this.lblClose);
            this.StockSummaryPanel.Controls.Add(this.lblOpen);
            this.StockSummaryPanel.Controls.Add(this.lblSymbolDetail);
            this.StockSummaryPanel.Controls.Add(this.lblSymbol);
            this.StockSummaryPanel.Controls.Add(this.lblOpenDetail);
            this.StockSummaryPanel.Controls.Add(this.lblCompanyDetail);
            this.StockSummaryPanel.Controls.Add(this.lblCompany);
            this.StockSummaryPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockSummaryPanel.Height = 92;
            this.StockSummaryPanel.Location = new System.Drawing.Point(0, 0);
            this.StockSummaryPanel.Name = "StockSummaryPanel";
            this.StockSummaryPanel.Size = new System.Drawing.Size(813, 92);
            this.StockSummaryPanel.SizeRatio = 19.869D;
            this.StockSummaryPanel.TabIndex = 0;
            this.StockSummaryPanel.Text = "Panel1";
            // 
            // lblVolumeDetail
            // 
            this.lblVolumeDetail.AutoSize = true;
            this.lblVolumeDetail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolumeDetail.Location = new System.Drawing.Point(711, 54);
            this.lblVolumeDetail.Name = "lblVolumeDetail";
            this.lblVolumeDetail.Size = new System.Drawing.Size(92, 17);
            this.lblVolumeDetail.TabIndex = 7;
            this.lblVolumeDetail.Text = "VolumeDetail";
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolume.Location = new System.Drawing.Point(649, 54);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(54, 17);
            this.lblVolume.TabIndex = 7;
            this.lblVolume.Text = "Volume:";
            // 
            // lblAdjCloseDetail
            // 
            this.lblAdjCloseDetail.AutoSize = true;
            this.lblAdjCloseDetail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdjCloseDetail.Location = new System.Drawing.Point(711, 18);
            this.lblAdjCloseDetail.Name = "lblAdjCloseDetail";
            this.lblAdjCloseDetail.Size = new System.Drawing.Size(99, 17);
            this.lblAdjCloseDetail.TabIndex = 6;
            this.lblAdjCloseDetail.Text = "AdjCloseDetail";
            // 
            // lblAdjClose
            // 
            this.lblAdjClose.AutoSize = true;
            this.lblAdjClose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdjClose.Location = new System.Drawing.Point(643, 18);
            this.lblAdjClose.Name = "lblAdjClose";
            this.lblAdjClose.Size = new System.Drawing.Size(62, 17);
            this.lblAdjClose.TabIndex = 6;
            this.lblAdjClose.Text = "AdjClose:";
            // 
            // lblLowDetail
            // 
            this.lblLowDetail.AutoSize = true;
            this.lblLowDetail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowDetail.Location = new System.Drawing.Point(545, 54);
            this.lblLowDetail.Name = "lblLowDetail";
            this.lblLowDetail.Size = new System.Drawing.Size(70, 17);
            this.lblLowDetail.TabIndex = 5;
            this.lblLowDetail.Text = "LowDetail";
            // 
            // lblLow
            // 
            this.lblLow.AutoSize = true;
            this.lblLow.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLow.Location = new System.Drawing.Point(501, 54);
            this.lblLow.Name = "lblLow";
            this.lblLow.Size = new System.Drawing.Size(34, 17);
            this.lblLow.TabIndex = 5;
            this.lblLow.Text = "Low:";
            // 
            // lblHighDetail
            // 
            this.lblHighDetail.AutoSize = true;
            this.lblHighDetail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighDetail.Location = new System.Drawing.Point(545, 18);
            this.lblHighDetail.Name = "lblHighDetail";
            this.lblHighDetail.Size = new System.Drawing.Size(75, 17);
            this.lblHighDetail.TabIndex = 4;
            this.lblHighDetail.Text = "HighDetail";
            // 
            // lblHigh
            // 
            this.lblHigh.AutoSize = true;
            this.lblHigh.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHigh.Location = new System.Drawing.Point(501, 18);
            this.lblHigh.Name = "lblHigh";
            this.lblHigh.Size = new System.Drawing.Size(38, 17);
            this.lblHigh.TabIndex = 4;
            this.lblHigh.Text = "High:";
            // 
            // lblCloseDetail
            // 
            this.lblCloseDetail.AutoSize = true;
            this.lblCloseDetail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCloseDetail.Location = new System.Drawing.Point(401, 54);
            this.lblCloseDetail.Name = "lblCloseDetail";
            this.lblCloseDetail.Size = new System.Drawing.Size(78, 17);
            this.lblCloseDetail.TabIndex = 3;
            this.lblCloseDetail.Text = "CloseDetail";
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.Location = new System.Drawing.Point(354, 54);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(43, 17);
            this.lblClose.TabIndex = 3;
            this.lblClose.Text = "Close:";
            // 
            // lblOpen
            // 
            this.lblOpen.AutoSize = true;
            this.lblOpen.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpen.Location = new System.Drawing.Point(354, 18);
            this.lblOpen.Name = "lblOpen";
            this.lblOpen.Size = new System.Drawing.Size(43, 17);
            this.lblOpen.TabIndex = 2;
            this.lblOpen.Text = "Open:";
            // 
            // lblSymbolDetail
            // 
            this.lblSymbolDetail.AutoSize = true;
            this.lblSymbolDetail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSymbolDetail.Location = new System.Drawing.Point(129, 54);
            this.lblSymbolDetail.Name = "lblSymbolDetail";
            this.lblSymbolDetail.Size = new System.Drawing.Size(91, 17);
            this.lblSymbolDetail.TabIndex = 1;
            this.lblSymbolDetail.Text = "SymbolDetail";
            // 
            // lblSymbol
            // 
            this.lblSymbol.AutoSize = true;
            this.lblSymbol.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSymbol.Location = new System.Drawing.Point(65, 54);
            this.lblSymbol.Name = "lblSymbol";
            this.lblSymbol.Size = new System.Drawing.Size(54, 17);
            this.lblSymbol.TabIndex = 1;
            this.lblSymbol.Text = "Symbol:";
            // 
            // lblOpenDetail
            // 
            this.lblOpenDetail.AutoSize = true;
            this.lblOpenDetail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpenDetail.Location = new System.Drawing.Point(401, 18);
            this.lblOpenDetail.Name = "lblOpenDetail";
            this.lblOpenDetail.Size = new System.Drawing.Size(78, 17);
            this.lblOpenDetail.TabIndex = 0;
            this.lblOpenDetail.Text = "OpenDetail";
            // 
            // lblCompanyDetail
            // 
            this.lblCompanyDetail.AutoSize = true;
            this.lblCompanyDetail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyDetail.Location = new System.Drawing.Point(129, 18);
            this.lblCompanyDetail.Name = "lblCompanyDetail";
            this.lblCompanyDetail.Size = new System.Drawing.Size(103, 17);
            this.lblCompanyDetail.TabIndex = 0;
            this.lblCompanyDetail.Text = "CompanyDetail";
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompany.Location = new System.Drawing.Point(53, 18);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(66, 17);
            this.lblCompany.TabIndex = 0;
            this.lblCompany.Text = "Company:";
            // 
            // StockChartPanel
            // 
            this.StockChartPanel.Controls.Add(this.StockChart);
            this.StockChartPanel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.StockChartPanel.Height = 284;
            this.StockChartPanel.Location = new System.Drawing.Point(0, 92);
            this.StockChartPanel.Name = "StockChartPanel";
            this.StockChartPanel.Size = new System.Drawing.Size(813, 284);
            this.StockChartPanel.SizeRatio = 76.86D;
            this.StockChartPanel.TabIndex = 1;
            this.StockChartPanel.Text = "Panel 2";
            // 
            // StockChart
            // 
            this.StockChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.StockChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StockChart.ForeColor = System.Drawing.SystemColors.WindowText;
            this.StockChart.Location = new System.Drawing.Point(0, 0);
            this.StockChart.Name = "StockChart";
            this.StockChart.Padding = new System.Windows.Forms.Padding(80, 0, 0, 0);
            this.StockChart.PropBag = resources.GetString("StockChart.PropBag");
            this.StockChart.Size = new System.Drawing.Size(813, 284);
            this.StockChart.TabIndex = 0;
            // 
            // DurationTilePanel
            // 
            this.DurationTilePanel.Controls.Add(this.TileControlDuration);
            this.DurationTilePanel.Height = 86;
            this.DurationTilePanel.Location = new System.Drawing.Point(0, 376);
            this.DurationTilePanel.Name = "DurationTilePanel";
            this.DurationTilePanel.Size = new System.Drawing.Size(813, 86);
            this.DurationTilePanel.TabIndex = 2;
            this.DurationTilePanel.Text = "Panel 3";
            // 
            // TileControlDuration
            // 
            this.TileControlDuration.AllowChecking = true;
            this.TileControlDuration.AutomaticLayout = false;
            this.TileControlDuration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.TileControlDuration.CellHeight = 30;
            this.TileControlDuration.CellWidth = 90;
            // 
            // 
            // 
            panelElement1.Alignment = System.Drawing.ContentAlignment.BottomLeft;
            textElement1.Font = new System.Drawing.Font("Segoe UI Light", 9.5F);
            panelElement1.Children.Add(textElement1);
            panelElement1.Margin = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.TileControlDuration.DefaultTemplate.Elements.Add(panelElement1);
            this.TileControlDuration.GroupPadding = new System.Windows.Forms.Padding(0);
            this.TileControlDuration.Groups.Add(this.group1);
            this.TileControlDuration.Location = new System.Drawing.Point(0, 0);
            this.TileControlDuration.Margin = new System.Windows.Forms.Padding(0);
            this.TileControlDuration.Name = "TileControlDuration";
            this.TileControlDuration.Padding = new System.Windows.Forms.Padding(120, 10, 0, 0);
            this.TileControlDuration.SBThumbBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.TileControlDuration.SBThumbInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.TileControlDuration.Size = new System.Drawing.Size(813, 86);
            this.TileControlDuration.SurfacePadding = new System.Windows.Forms.Padding(0);
            this.TileControlDuration.TabIndex = 0;
            this.TileControlDuration.TileBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            // 
            // group1
            // 
            this.group1.Name = "group1";
            this.group1.Tiles.Add(this.tileWeek);
            this.group1.Tiles.Add(this.tileMonth);
            this.group1.Tiles.Add(this.tileQuarter);
            this.group1.Tiles.Add(this.tileHalfyear);
            this.group1.Tiles.Add(this.tileOneYear);
            this.group1.Tiles.Add(this.tile3Years);
            this.group1.Tiles.Add(this.tile5years);
            // 
            // tileWeek
            // 
            this.tileWeek.BackColor = System.Drawing.Color.RoyalBlue;
            this.tileWeek.Name = "tileWeek";
            this.tileWeek.Text = "7 Days";
            // 
            // tileMonth
            // 
            this.tileMonth.BackColor = System.Drawing.Color.RoyalBlue;
            this.tileMonth.LeftCell = 2;
            this.tileMonth.Name = "tileMonth";
            this.tileMonth.Text = "30 Days";
            // 
            // tileQuarter
            // 
            this.tileQuarter.BackColor = System.Drawing.Color.RoyalBlue;
            this.tileQuarter.LeftCell = 3;
            this.tileQuarter.Name = "tileQuarter";
            this.tileQuarter.Text = "90 Days";
            // 
            // tileHalfyear
            // 
            this.tileHalfyear.BackColor = System.Drawing.Color.RoyalBlue;
            this.tileHalfyear.LeftCell = 4;
            this.tileHalfyear.Name = "tileHalfyear";
            this.tileHalfyear.Text = "6 Months";
            // 
            // tileOneYear
            // 
            this.tileOneYear.BackColor = System.Drawing.Color.RoyalBlue;
            this.tileOneYear.LeftCell = 5;
            this.tileOneYear.Name = "tileOneYear";
            this.tileOneYear.Text = "1 Year";
            // 
            // tile3Years
            // 
            this.tile3Years.BackColor = System.Drawing.Color.RoyalBlue;
            this.tile3Years.LeftCell = 6;
            this.tile3Years.Name = "tile3Years";
            this.tile3Years.Text = "3 Years";
            // 
            // tile5years
            // 
            this.tile5years.BackColor = System.Drawing.Color.RoyalBlue;
            this.tile5years.LeftCell = 7;
            this.tile5years.Name = "tile5years";
            this.tile5years.Text = "5 Years";
            // 
            // backgroundWorkerChart
            // 
            this.backgroundWorkerChart.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerChart_DoWork);
            this.backgroundWorkerChart.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerChart_RunWorkerCompleted);
            // 
            // StockChartData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.c1SplitContainer1);
            this.Name = "StockChartData";
            this.Size = new System.Drawing.Size(813, 462);
            ((System.ComponentModel.ISupportInitialize)(this.c1SplitContainer1)).EndInit();
            this.c1SplitContainer1.ResumeLayout(false);
            this.StockSummaryPanel.ResumeLayout(false);
            this.StockSummaryPanel.PerformLayout();
            this.StockChartPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StockChart)).EndInit();
            this.DurationTilePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1SplitContainer.C1SplitContainer c1SplitContainer1;
        private C1.Win.C1SplitContainer.C1SplitterPanel StockSummaryPanel;
        private C1.Win.C1SplitContainer.C1SplitterPanel StockChartPanel;
        private C1.Win.C1SplitContainer.C1SplitterPanel DurationTilePanel;
        private C1.Win.C1Chart.C1Chart StockChart;
        private C1.Win.C1Tile.C1TileControl TileControlDuration;
        private C1.Win.C1Tile.Group group1;
        private C1.Win.C1Tile.Tile tileWeek;
        private C1.Win.C1Tile.Tile tileMonth;
        private C1.Win.C1Tile.Tile tileQuarter;
        private C1.Win.C1Tile.Tile tileHalfyear;
        private C1.Win.C1Tile.Tile tileOneYear;
        private C1.Win.C1Tile.Tile tile3Years;
        private C1.Win.C1Tile.Tile tile5years;
        private System.ComponentModel.BackgroundWorker backgroundWorkerChart;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Label lblAdjClose;
        private System.Windows.Forms.Label lblLowDetail;
        private System.Windows.Forms.Label lblLow;
        private System.Windows.Forms.Label lblHighDetail;
        private System.Windows.Forms.Label lblHigh;
        private System.Windows.Forms.Label lblCloseDetail;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lblOpen;
        private System.Windows.Forms.Label lblSymbolDetail;
        private System.Windows.Forms.Label lblSymbol;
        private System.Windows.Forms.Label lblOpenDetail;
        private System.Windows.Forms.Label lblCompanyDetail;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label lblVolumeDetail;
        private System.Windows.Forms.Label lblAdjCloseDetail;

    }
}
