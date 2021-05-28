using C1.Win.C1Command;
using C1.Win.C1FlexGrid;
using C1.Win.C1Preview;
using C1.Win.C1TrueDBGrid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClickOnceDemo.GcZoomPages
{
    public static class ComponentOneCreater
    {
        public static Control CreateControl(string zoomPolicy, Font font, Size layoutSize)
        {
            switch (zoomPolicy)
            {
                case "C1ChartZoomPolicy":
                    C1ChartSample chart1 = new C1ChartSample();
                    chart1.Dock = DockStyle.Fill;
                    return chart1;
                case "C1Chart3DZoomPolicy":
                    C1Charts3DSample chart3d1 = new C1Charts3DSample();
                    chart3d1.Dock = DockStyle.Fill;
                    return chart3d1;
                case "C1FlexGridZoomPolicy":
                    FlexGridSample flexGridSample1 = new FlexGridSample();
                    flexGridSample1.c1FlexGrid1.Dock = DockStyle.Fill;
                    return flexGridSample1.c1FlexGrid1;
                case "C1TrueDBGridZoomPolicy":
                    C1TrueDBGrid trueDBGrid1 = new C1TrueDBGrid();
                    trueDBGrid1.BackColor = Color.AliceBlue;
                    System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZoomPolicyDemo));
                    trueDBGrid1.GroupByCaption = "Drag a column header here to group by that column";
                    trueDBGrid1.Name = "c1TrueDBGrid1";
                    trueDBGrid1.Dock = DockStyle.Fill;
                    trueDBGrid1.TabAction = C1.Win.C1TrueDBGrid.TabActionEnum.GridNavigation;
                    trueDBGrid1.TabIndex = 0;
                    trueDBGrid1.Text = "c1TrueDBGrid1";
                    trueDBGrid1.PropBag = resources.GetString("c1TrueDBGrid_bag");
                    trueDBGrid1.AllowFilter = false;
                    trueDBGrid1.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue;
                    return trueDBGrid1;
                case "C1PrintPreviewControlZoomPolicy":
                    C1PrintPreviewControlSample printPreviewSample = new C1PrintPreviewControlSample();
                    printPreviewSample.Dock = DockStyle.Fill;
                    return printPreviewSample;
                case "C1RibbonZoomPolicy":
                    C1RibbonSample ribbonSample1 = new C1RibbonSample();
                    ribbonSample1.Dock = DockStyle.Fill;
                    return ribbonSample1;
                case "C1StatusBarZoomPolicy":
                    C1.Win.C1Ribbon.C1StatusBar c1StatusBar1 = new C1.Win.C1Ribbon.C1StatusBar();
                    C1.Win.C1Ribbon.RibbonLabel DocumentModifiedLabel = new C1.Win.C1Ribbon.RibbonLabel();
                    C1.Win.C1Ribbon.RibbonLabel zoomLabel1 = new C1.Win.C1Ribbon.RibbonLabel();
                    C1.Win.C1Ribbon.RibbonTrackBar ZoomTrackBar1 = new C1.Win.C1Ribbon.RibbonTrackBar();
                    c1StatusBar1.LeftPaneItems.Add(DocumentModifiedLabel);
                    c1StatusBar1.RightPaneItems.Add(ZoomTrackBar1);
                    c1StatusBar1.RightPaneItems.Add(zoomLabel1);
                    c1StatusBar1.RightPaneWidth = 180;
                    c1StatusBar1.Text = "Ready";
                    c1StatusBar1.VisualStyle = C1.Win.C1Ribbon.VisualStyle.Office2010Blue;
                    // 
                    // DocumentModifiedLabel
                    // 
                    DocumentModifiedLabel.Text = "Edit";
                    // 
                    // ZoomTrackBar1
                    // 
                    ZoomTrackBar1.Maximum = 1000;
                    ZoomTrackBar1.Minimum = 10;
                    ZoomTrackBar1.Value = 100;
                    // 
                    // zoomLabel1
                    // 
                    zoomLabel1.FontPadding = C1.Win.C1Ribbon.FontPadding.Yes;
                    zoomLabel1.Text = "100%";
                    return c1StatusBar1;
                case "C1CalendarZoomPolicy":
                    C1.Win.C1Schedule.C1Calendar c1Calendar1 = new C1.Win.C1Schedule.C1Calendar();
                    ZoomPolicyProviderBase.PutControlInCenter(c1Calendar1, layoutSize);
                    return c1Calendar1;
                case "C1ScheduleZoomPolicy":
                    C1.Win.C1Schedule.C1Schedule c1Schedule1 = new C1.Win.C1Schedule.C1Schedule();
                    c1Schedule1.Dock = DockStyle.Fill;
                    return c1Schedule1;
                case "C1MainMenuZoomPolicy":
                    C1MainMenu c1MainMenu1 = new C1MainMenu();
                    C1CommandLink commandLink1 = new C1CommandLink();
                    C1CommandMenu commandMenu1 = new C1CommandMenu();
                    commandMenu1.Font = new Font(c1MainMenu1.Font.FontFamily, 12);
                    commandMenu1.Text = "commandMenu1";
                    commandLink1.Command = commandMenu1;
                    c1MainMenu1.CommandLinks.Add(commandLink1);
                    return c1MainMenu1;
                case "C1DockingTabZoomPolicy":
                    C1DockingTab dockingTab1 = new C1DockingTab();
                    C1DockingTabPage dockintTabPage1 = new C1DockingTabPage();
                    C1DockingTabPage dockintTabPage2 = new C1DockingTabPage();
                    C1DockingTabPage dockintTabPage3 = new C1DockingTabPage();
                    C1DockingTabPage dockintTabPage4 = new C1DockingTabPage();
                    dockintTabPage1.Text = "TabPage1";
                    dockintTabPage2.Text = "TabPage2";
                    dockintTabPage3.Text = "TabPage3";
                    dockintTabPage4.Text = "TabPage4";
                    dockingTab1.Controls.Add(dockintTabPage1);
                    dockingTab1.Controls.Add(dockintTabPage2);
                    dockingTab1.Controls.Add(dockintTabPage3);
                    dockingTab1.Controls.Add(dockintTabPage4);
                    dockingTab1.ItemSize = new Size(80, 20);
                    dockingTab1.SplitterWidth = 5;
                    dockingTab1.TabAreaSpacing = 5;
                    dockingTab1.TabsSpacing = 5;
                    return dockingTab1;
                case "C1NavBarPolicy":
                    C1NavBarSample navBarSample1 = new C1NavBarSample();
                    navBarSample1.Dock = DockStyle.Fill;
                    return navBarSample1;
                case "C1OutBarZoomPolicy":
                    C1OutBarSample outBarSample1 = new C1OutBarSample();
                    outBarSample1.Dock = DockStyle.Fill;
                    return outBarSample1;
                default:
                    break;
            }
            return null;
        }

        public static Size? GetDemoSize(string zoomPolicy)
        {
            switch (zoomPolicy)
            {
                case "C1ChartZoomPolicy":
                case "C1Chart3DZoomPolicy":
                case "C1FlexGridZoomPolicy":
                case "C1PrintPreviewControlZoomPolicy":
                case "C1RibbonZoomPolicy":
                case "C1ScheduleZoomPolicy":
                    return new Size(1024, 600);
                default:
                    break;
            }
            return null;
        }

        internal static string[] ComponentOnePolicies = new string[] 
        {
            "C1ChartZoomPolicy",
            "C1Chart3DZoomPolicy",
            "C1FlexGridZoomPolicy",
            "C1TrueDBGridZoomPolicy",
            //"C1TDBDropDownZoomPolicy",
            //"C1PrintPreviewControlZoomPolicy",
            "C1RibbonZoomPolicy",
            "C1StatusBarZoomPolicy",
            "C1CalendarZoomPolicy",
            "C1ScheduleZoomPolicy",
            //"C1MainMenuZoomPolicy",
            "C1DockingTabZoomPolicy",
            "C1NavBarPolicy",
            "C1OutBarZoomPolicy",
        };

        private static DataTable GetData()
        {
            DataTable table = new DataTable();
            table.Columns.Add(new DataColumn("CustomerID", typeof(string)));
            table.Columns.Add(new DataColumn("CompanyName", typeof(string)));
            table.Columns.Add(new DataColumn("ContactName", typeof(string)));
            table.Rows.Add(new object[] { "aaa", "aab", "aac" });
            table.Rows.Add(new object[] { "aaa", "aab", "aac" });
            table.Rows.Add(new object[] { "aaa", "aab", "aac" });
            table.Rows.Add(new object[] { "aaa", "aab", "aac" });
            table.Rows.Add(new object[] { "aaa", "aab", "aac" });
            table.Rows.Add(new object[] { "aaa", "aab", "aac" });
            return table;
        }

        internal static string GetDescription(string zoomPolicy)
        {
            switch (zoomPolicy)
            {
                case "C1ChartZoomPolicy":
                    return Properties.Resources.ZoomPolicy_C1_C1Chart;
                case "C1Chart3DZoomPolicy":
                    return Properties.Resources.ZoomPolicy_C1_C1Chart3D;
                case "C1FlexGridZoomPolicy":
                    return Properties.Resources.ZoomPolicy_C1_C1FlexGrid;
                case "C1TrueDBGridZoomPolicy":
                    return Properties.Resources.ZoomPolicy_C1_C1TrueDBGrid;
                case "C1RibbonZoomPolicy":
                    return Properties.Resources.ZoomPolicy_C1_C1Ribbon;
                case "C1StatusBarZoomPolicy":
                    return Properties.Resources.ZoomPolicy_C1_C1StatusBar;
                case "C1CalendarZoomPolicy":
                    return Properties.Resources.ZoomPolicy_C1_C1Calendar;
                case "C1ScheduleZoomPolicy":
                    return Properties.Resources.ZoomPolicy_C1_C1Schedule;
                case "C1DockingTabZoomPolicy":
                    return Properties.Resources.ZoomPolicy_C1_C1DockingTab;
                case "C1NavBarPolicy":
                    return Properties.Resources.ZoomPolicy_C1_C1NavBar;
                case "C1OutBarZoomPolicy":
                    return Properties.Resources.ZoomPolicy_C1_C1OutBar;
                default:
                    break;
            }
            return "";
        }
    }

    internal class FlexGridSample
    { 
        //Store column indexes
        private int procCol = 2;
        private int payCol = 3;
        private int gmCol = 4;
        private int gmrCol = 5;
        private int devCol = 6;
        Random rand;
        //Pool of sample data
        private double[] values = { 9000, 8000, 6000, 500, 20000, 10000, 45000, 75000, 7000, 3000 };

        public FlexGridSample()
        {
            InitializeComponent();
            Unbound_Load();
        }

        internal C1.Win.C1FlexGrid.C1FlexGrid c1FlexGrid1;
        private System.Windows.Forms.ImageList imageList1;
        private void InitializeComponent()
        {
            this.c1FlexGrid1 = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.imageList1 = new System.Windows.Forms.ImageList();
            this.c1FlexGrid1.AllowAddNew = true;
            this.c1FlexGrid1.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            this.c1FlexGrid1.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            this.c1FlexGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.c1FlexGrid1.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Heavy;
            this.c1FlexGrid1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1FlexGrid1.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcrossOut;
            this.c1FlexGrid1.Location = new System.Drawing.Point(12, 12);
            this.c1FlexGrid1.Name = "c1FlexGrid1";
            this.c1FlexGrid1.Rows.DefaultSize = 20;
            this.c1FlexGrid1.Size = new System.Drawing.Size(682, 422);
            this.c1FlexGrid1.TabIndex = 1;
            this.c1FlexGrid1.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2007Silver;
            this.c1FlexGrid1.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.c1FlexGrid1_AfterEdit);
            this.c1FlexGrid1.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.c1FlexGrid1_BeforeEdit);
            this.c1FlexGrid1.Styles.Normal.Font = new Font(this.c1FlexGrid1.Font.FontFamily, 8);
            this.c1FlexGrid1.Styles.Fixed.Font = new Font(this.c1FlexGrid1.Font.FontFamily, 8);
            foreach (CellStyle item in this.c1FlexGrid1.Styles)
            {
                item.Font = new Font(this.c1FlexGrid1.Font.FontFamily, 8);
            }
            this.c1FlexGrid1.Rows.DefaultSize = 20;
            this.c1FlexGrid1.Cols.DefaultSize = 60;
        }

        private void Unbound_Load()
        {
            rand = new Random();
            //Set AllowMerging to Spill meaning empty adjacent cells will allow long text to spill (similar to Excel)
            c1FlexGrid1.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Spill;

            //Create some CellStyles
            CellStyle cs = c1FlexGrid1.Styles.Add("Up");
            cs.BackColor = Color.FromArgb(133, 236, 133);
            cs = c1FlexGrid1.Styles.Add("Down");
            cs.BackColor = Color.FromArgb(255, 150, 110);
            cs = c1FlexGrid1.Styles.Add("Heading");
            cs.Font = new Font(c1FlexGrid1.Font, FontStyle.Bold);

            //Load data
            LoadData();                    
        }

        private void c1FlexGrid1_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            //After edit, apply new changes to calculated columns
            if (isHeaderRow(e.Row))
            {
                //If header row remove all numeric data if it exists and apply custom Heading CellStyle
                ClearRow(e.Row);
                this.c1FlexGrid1.SetCellStyle(e.Row, 0, c1FlexGrid1.Styles["Heading"]);
            }
            else
            {
                //Calculate new totals for current row
                CalculateGrossMargins(e.Row);
                CalculateDeviation(e.Row);
            }
            //Calculate new deviation for adjacent affected row
            CalculateDeviation(e.Row + 1);       
        }

        private void CalculateGrossMargins(int row)
        {
            //this function calculates gross margin and gross margin rate given row's proceeds and payments values
            double proceeds = this.c1FlexGrid1[row, procCol] == null ? 0 : double.Parse(this.c1FlexGrid1[row, procCol].ToString());
            double payments = this.c1FlexGrid1[row, payCol] == null ? 0 : double.Parse(this.c1FlexGrid1[row, payCol].ToString());
            double grossMargin = proceeds - payments;
            double grossMarginRate = proceeds != 0 ? grossMargin / proceeds : 0;
            this.c1FlexGrid1[row, gmCol] = grossMargin;
            this.c1FlexGrid1[row, gmrCol] = grossMarginRate;
        }

        private void CalculateDeviation(int row)
        {
            //This function calculates gross margin rate deviation from previous row
            if (this.c1FlexGrid1[row, gmrCol] == null)
                return;

            if (this.c1FlexGrid1[row - 1, gmrCol] == null)
                return;

            double grossMarginRate = (double)this.c1FlexGrid1[row, gmrCol];
            double previousDateRate;
            //Try to grab previous rows GMR
            if (double.TryParse(this.c1FlexGrid1[row - 1, gmrCol].ToString(), out previousDateRate))
            {
                //If exists, calculate difference and apply Up or Down CellStyle accordingly
                Double dev = grossMarginRate - previousDateRate;

                if (dev > 0.0001)
                {
                    this.c1FlexGrid1[row, devCol] = dev;
                    this.c1FlexGrid1.SetCellStyle(row, devCol, c1FlexGrid1.Styles["Up"]);
                    this.c1FlexGrid1.SetCellImage(row, devCol, imageList1.Images["Up.png"]);
                }
                else if (dev < 0.0001 && dev > -0.0001)
                    this.c1FlexGrid1[row, devCol] = 0.000;
                else
                {
                    this.c1FlexGrid1[row, devCol] = dev;
                    this.c1FlexGrid1.SetCellStyle(row, devCol, c1FlexGrid1.Styles["Down"]);
                    this.c1FlexGrid1.SetCellImage(row, devCol, imageList1.Images["Down.png"]);
                }
            }
            else
            {
                this.c1FlexGrid1[row, devCol] = 0;
            }

        }

        private void ClearRow(int row)
        {
            //This function clears a row of data, style and images, skipping the 0th column
            for (int i = 1; i < c1FlexGrid1.Cols.Count; i++)
            {
                c1FlexGrid1[row, i] = null;
            }
            c1FlexGrid1.SetCellStyle(row, devCol, c1FlexGrid1.Styles["Normal"]);
            c1FlexGrid1.SetCellImage(row, devCol, null);
            
        }

        private void LoadData()
        {
            //This function loads random data from our pool of possible values
            this.c1FlexGrid1[1, 0] = "Quarter 1: " + DateTime.Now.ToShortDateString() + " to " + DateTime.Now.AddDays(9).ToShortDateString();
            this.c1FlexGrid1.SetCellStyle(1, 0, c1FlexGrid1.Styles["Heading"]);
            for (int i = 2; i < 12; i++)
            {
                this.c1FlexGrid1[i, 1] = DateTime.Now.AddDays(i - 2);
                this.c1FlexGrid1[i, 2] = values[rand.Next(0, 9)];
                this.c1FlexGrid1[i, 3] = values[rand.Next(0, 9)];
                CalculateGrossMargins(i);
                CalculateDeviation(i);
            }
            this.c1FlexGrid1[12, 0] = "Quarter 2: " + DateTime.Now.AddDays(10).ToShortDateString() + " to " + DateTime.Now.AddDays(20).ToShortDateString() + " (Notice this text spills across empty cells)";
            this.c1FlexGrid1.SetCellStyle(12, 0, c1FlexGrid1.Styles["Heading"]);
            this.c1FlexGrid1[13, 1] = DateTime.Now.AddDays(10);
            this.c1FlexGrid1[13, 2] = values[rand.Next(0, 9)];
            this.c1FlexGrid1[13, 3] = values[rand.Next(0, 9)];
            CalculateGrossMargins(13);
            CalculateDeviation(13);
        }

        //This function is used internally to determine if a row is a Header or data row.
        //Returns true if Header row (contains text in 0th column)
        private bool isHeaderRow(int index)
        {
            if (c1FlexGrid1[index, 0] != null)
                return true;
            else
                return false;
        }

        private void c1FlexGrid1_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            // if we begin to edit auto fill the date field
            if (e.Col == 2 || e.Col == 3)
            {
                if (c1FlexGrid1[e.Row, 1] == null && e.Row > 0)
                    if (c1FlexGrid1[e.Row - 1, 1] != null)
                        c1FlexGrid1[e.Row, 1] = ((DateTime)c1FlexGrid1[e.Row - 1, 1]).AddDays(1);
            }
        }   
    }
}
