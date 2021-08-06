using C1.PivotEngine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlExplorer.FlexPivot
{
    public partial class Ranges : C1DemoForm
    {
        private RangeView _activeView = RangeView.Year;

        public Ranges()
        {
            InitializeComponent();

            BigNumericStep = 200;
            SmallNumericStep = 50;
            FirstMonthOfFiscalYear = 4;
            Views = new Dictionary<RangeView, RangeSetupDelegate>();
            RegisterViews();
            ShowFlexPivotPanel = false;

            WorkspaceSetup();

            AddProperty("ShowSlicers", this, "Show Slicers");
            AddProperty("ShowFlexPivotPanel", this, "Show Panel");
            AddProperty("ActiveView", this, "Active View");
        }

        public bool ShowSlicers
        {
            get => scSlicers.Visible;
            set => scSlicers.Visible = value;
        }

        public bool ShowFlexPivotPanel
        {
            get => !scPivotPanel.Panel2Collapsed;
            set => scPivotPanel.Panel2Collapsed = !value;
        }

        public int BigNumericStep { get; set; }

        public int SmallNumericStep { get; set; }

        public int FirstMonthOfFiscalYear { get; set; }

        public RangeView ActiveView
        {
            get => _activeView;
            set
            {
                _activeView = value;
                if (Engine.Fields.Count > 0)
                    Views[_activeView]?.Invoke();

            }
        }

        public Dictionary<RangeView, RangeSetupDelegate> Views
        {
            get;
        }

        public void WorkspaceSetup()
        {
            // bind to FlexPivot page
            this.pivotPanel.DataSource = DemoDataSource("Invoices");

            Engine.ValueFields.Add("ExtendedPrice");
            pivotSlicerTop.Field = Engine.Fields["OrderDate"];
            Engine.Fields["ExtendedPrice"].Caption = "Sales";

            RangesSetupYear();

            pivotSlicerTop.MultiSelect = true;
            pivotSlicerTop.ShowSelectAll = false;
        }

        C1.PivotEngine.C1PivotEngine Engine => pivotPanel.PivotEngine;

        private void RegisterViews()
        {
            Views.Add(RangeView.NoRanges, RangesSetupNo);
            Views.Add(RangeView.Year, RangesSetupYear);
            Views.Add(RangeView.YearAndMonth, RangesSetupYearMonth);
            Views.Add(RangeView.YearVsWeek, RangesSetupYearVsWeek);
            Views.Add(RangeView.YearVsQuarter, RangesSetupYearVsQuarter);
            Views.Add(RangeView.FiscalYear, RangesSetupFiscalYear);
            Views.Add(RangeView.FiscalYearAndMonth, RangesSetupFiscalYearMonth);
            Views.Add(RangeView.Alphabetical, RangesSetupAlphabet);
            Views.Add(RangeView.Numeric, RangesSetupNumeric);
            Views.Add(RangeView.ContinentsVsUnitPrice, RangesSetupCustom);
        }
        

        void Clear()
        {
            Engine.Fields["OrderDate"].Range.RangeType = RangeType.None;
            Engine.Fields["OrderDate"].Caption = "Order Date";
            Engine.Fields["OrderDate"].Format = "yyyy/MM/dd";
            Engine.Fields["Country"].Range.RangeType = RangeType.None;
            Engine.Fields["Country"].Caption = "Country";
            Engine.Fields["UnitPrice"].Caption = "Unit Price";
            Engine.Fields["UnitPrice"].Range.RangeType = RangeType.None;
            Engine.Fields["ProductName"].Caption = "Product Name";
            Engine.Fields["ProductName"].Range.RangeType = RangeType.None;
            Engine.RowFields.Clear();
            Engine.ColumnFields.Clear();
        }

        private void RangesSetupNo()
        {
            var field = Engine.Fields["OrderDate"];
            Engine.BeginUpdate();
            Clear();

            // No Ranges

            Engine.RowFields.Add("OrderDate");
            Engine.ColumnFields.Add("Country");
            Engine.EndUpdate();
            pivotSlicerTop.Field = Engine.RowFields["OrderDate"];
            pivotSlicerBottom.Field = Engine.ColumnFields["Country"];
        }

        private void RangesSetupYear()
        {
            Engine.BeginUpdate();
            Clear();

            // Years

            Engine.Fields["OrderDate"].Range.RangeType = RangeType.Format;
            Engine.Fields["OrderDate"].Format = "yyyy";
            Engine.Fields["OrderDate"].Caption = "Year";

            Engine.RowFields.Add("OrderDate");
            Engine.ColumnFields.Add("Country");
            Engine.EndUpdate();
            pivotSlicerTop.Field = Engine.RowFields["OrderDate"];
            pivotSlicerBottom.Field = Engine.ColumnFields["Country"];
        }

        private void RangesSetupYearMonth()
        {
            Engine.BeginUpdate();
            Clear();
            Engine.RowFields.Add("OrderDate");
            Engine.RowFields.Add("OrderDate");
            // Year range
            Engine.RowFields[0].Range.RangeType = RangeType.Format;
            Engine.RowFields[0].Format = "yyyy";
            Engine.RowFields[0].Caption = "Year";
            // Month range
            Engine.RowFields[1].Range.RangeType = RangeType.Format;
            Engine.RowFields[1].Format = "MMM";
            Engine.RowFields[1].Caption = "Month";

            Engine.ColumnFields.Add("Country");
            Engine.EndUpdate();
            pivotSlicerTop.Field = Engine.RowFields[0];
            pivotSlicerBottom.Field = Engine.RowFields[1];
        }

        private void RangesSetupYearVsWeek()
        {
            Engine.BeginUpdate();
            Clear();
            Engine.RowFields.Add("OrderDate");
            Engine.ColumnFields.Add("OrderDate");
            // Year range
            Engine.RowFields[0].Range.RangeType = RangeType.Format;
            Engine.RowFields[0].Format = "yyyy";
            Engine.RowFields[0].Caption = "Year";
            // Week range
            Engine.ColumnFields[0].Range.RangeType = RangeType.Week;
            Engine.ColumnFields[0].Caption = "Week";

            Engine.EndUpdate();
            pivotSlicerTop.Field = Engine.RowFields[0];
            pivotSlicerBottom.Field = Engine.ColumnFields[0];
        }

        private void RangesSetupYearVsQuarter()
        {
            Engine.BeginUpdate();
            Clear();
            Engine.RowFields.Add("OrderDate");
            Engine.ColumnFields.Add("OrderDate");
            // Year range
            Engine.RowFields[0].Range.RangeType = RangeType.Format;
            Engine.RowFields[0].Format = "yyyy";
            Engine.RowFields[0].Caption = "Year";
            // Quarter range
            Engine.ColumnFields[0].Range.RangeType = RangeType.Quarter;
            Engine.ColumnFields[0].Caption = "Quarter";

            Engine.EndUpdate();
            pivotSlicerTop.Field = Engine.RowFields[0];
            pivotSlicerBottom.Field = Engine.ColumnFields[0];
        }

        private void RangesSetupFiscalYear()
        {
            Engine.BeginUpdate();
            Clear();

            // Fiscal year
            Engine.Fields["OrderDate"].Range.RangeType = RangeType.FiscalYear;
            Engine.Fields["OrderDate"].Format = "\"FY\" yyyy";
            Engine.Fields["OrderDate"].Caption = "Fiscal Year";
            Engine.Fields["OrderDate"].Range.FiscalYearFirstMonth = FirstMonthOfFiscalYear;
            Engine.Fields["OrderDate"].Range.FiscalYearShift = 0;

            Engine.RowFields.Add("OrderDate");
            Engine.ColumnFields.Add("Country");
            Engine.EndUpdate();
            pivotSlicerTop.Field = Engine.RowFields[0];
            pivotSlicerBottom.Field = Engine.ColumnFields[0];

        }

        private void RangesSetupFiscalYearMonth()
        {
            Engine.BeginUpdate();
            Clear();
            Engine.RowFields.Add("OrderDate");
            Engine.RowFields.Add("OrderDate");
            // Fiscal year
            Engine.RowFields[0].Range.RangeType = RangeType.FiscalYear;
            Engine.RowFields[0].Format = "\"FY\" yyyy";
            Engine.RowFields[0].Caption = "F Year";
            Engine.RowFields[0].Range.FiscalYearFirstMonth = FirstMonthOfFiscalYear;
            Engine.RowFields[0].Range.FiscalYearShift = 0;
            // Month range
            Engine.RowFields[1].Range.RangeType = RangeType.FiscalMonth;
            Engine.RowFields[1].Format = "MM";
            Engine.RowFields[1].Caption = "F Month";
            Engine.RowFields[1].Range.FiscalYearFirstMonth = FirstMonthOfFiscalYear;
            Engine.RowFields[1].Range.FiscalYearShift = 0;


            Engine.ColumnFields.Add("Country");
            Engine.EndUpdate();
            pivotSlicerTop.Field = Engine.RowFields[0];
            pivotSlicerBottom.Field = Engine.RowFields[1];
        }
        private void RangesSetupQuarter()
        {
            Engine.BeginUpdate();
            Clear();

            Engine.Fields["OrderDate"].Caption = "Quarter";
            Engine.RowFields.Add("OrderDate");
            Engine.ColumnFields.Add("Country");
            Engine.EndUpdate();
            pivotSlicerTop.Field = Engine.RowFields[0];
            pivotSlicerBottom.Field = Engine.ColumnFields[0];
        }

        private void RangesSetupContinent()
        {
            Engine.BeginUpdate();
            Clear();
            Engine.Fields["OrderDate"].Caption = "Quarter";
            Engine.Fields["Country"].Caption = "Continent";
            Engine.RowFields.Add("OrderDate");
            Engine.ColumnFields.Add("Country");
            Engine.EndUpdate();
            pivotSlicerTop.Field = Engine.RowFields[0];
            pivotSlicerBottom.Field = Engine.ColumnFields[0];
        }

        private void RangesSetupSells()
        {
            Engine.BeginUpdate();
            Clear();
            Engine.Fields["Country"].Caption = "Country";
            Engine.Fields["UnitPrice"].Caption = "Price group";
            Engine.Fields["UnitPrice"].Range.RangeType = RangeType.Numeric;
            Engine.Fields["UnitPrice"].Range.NumericStep = SmallNumericStep;
            Engine.RowFields.Add("UnitPrice");
            Engine.ColumnFields.Add("Country");
            Engine.EndUpdate();
            pivotSlicerTop.Field = Engine.RowFields[0];
            pivotSlicerBottom.Field = Engine.ColumnFields[0];
        }

        private void RangesSetupAlphabet()
        {
            Engine.BeginUpdate();
            Clear();

            Engine.Fields["OrderDate"].Caption = "Year";
            Engine.ColumnFields.Add("OrderDate");
            Engine.RowFields.Add("ProductName");
            Engine.RowFields.Add("ProductName");
            Engine.RowFields[0].Caption = "Product: Group by first letter";
            Engine.RowFields[0].Range.RangeType = RangeType.AlphabeticalIgnoreCase;
            Engine.RowFields[1].Caption = "Product";
            Engine.EndUpdate();
            pivotSlicerTop.Field = Engine.RowFields[0];
            pivotSlicerBottom.Field = Engine.ColumnFields[0];
        }

        private void RangesSetupNumeric()
        {
            Engine.BeginUpdate();
            Clear();
            Engine.RowFields.Add("UnitPrice");
            Engine.RowFields.Add("UnitPrice");
            // Big range
            Engine.RowFields[0].Range.RangeType = RangeType.Numeric;
            Engine.RowFields[0].Range.NumericStep = BigNumericStep;
            Engine.RowFields[0].Caption = "Unit price big range";
            // Smaller range
            Engine.RowFields[1].Range.RangeType = RangeType.Numeric;
            Engine.RowFields[1].Range.NumericStep = SmallNumericStep;
            Engine.RowFields[1].Caption = "Unit price small range";


            Engine.ColumnFields.Add("Country");
            Engine.ColumnFields[0].Format = "yyyy";
            Engine.EndUpdate();
            pivotSlicerTop.Field = Engine.RowFields[0];
            pivotSlicerBottom.Field = Engine.ColumnFields[0];
        }

        private void RangesSetupCustom()
        {
            Engine.BeginUpdate();
            Clear();
            Engine.ColumnFields.Add("Country");
            Engine.RowFields.Add("UnitPrice");
            // Continent
            Engine.ColumnFields[0].Range.RangeType = RangeType.Custom;
            Engine.ColumnFields[0].Caption = "Continent";
            Engine.ColumnFields[0].Range.CustomRange += CustomRangeContinent;
            // Unit Price
            Engine.RowFields[0].Range.RangeType = RangeType.Custom;
            Engine.RowFields[0].Caption = "UnitPrice";
            Engine.RowFields[0].Range.CustomRange += CustomRangePrice;

            Engine.EndUpdate();
            pivotSlicerTop.Field = Engine.RowFields[0];
            pivotSlicerBottom.Field = Engine.ColumnFields[0];
        }

        private void CustomRangeContinent(object sender, CustomRangeEventArgs args)
        {
            if (_dict.ContainsKey((string)args.Value))
                args.GroupValue = _dict[(string)args.Value];
        }

        private void CustomRangePrice(object sender, CustomRangeEventArgs args)
        {
            var val = Convert.ToDouble(args.Value);
            args.GroupValue = val <= 200 ? "<= 200" : "> 200";
        }

        readonly Dictionary<string, string> _dict = new Dictionary<string, string>
        {
            { "Argentina" , "South America" },
            { "Austria" , "Europe" },
            { "Belgium" , "Europe" },
            { "Brazil" , "South America" },
            { "Canada" , "North America" },
            { "Denmark" , "Europe" },
            { "Finland" , "Europe" },
            { "France" , "Europe" },
            { "Germany" , "Europe" },
            { "Ireland" , "Europe" },
            { "Italy" , "Europe" },
            { "Mexico" , "North America" },
            { "Norway" , "Europe" },
            { "Poland" , "Europe" },
            { "Portugal" , "Europe" },
            { "Spain" , "Europe" },
            { "Sweden" , "Europe" },
            { "Switzerland" , "Europe" },
            { "UK" , "Europe" },
            { "USA" , "North America" },
            { "Venezuela" , "South America" },
        };
    }

    public enum RangeView
    {
        NoRanges,
        Year,
        YearAndMonth,
        YearVsWeek,
        YearVsQuarter,
        FiscalYear,
        FiscalYearAndMonth,
        Alphabetical,
        Numeric,
        ContinentsVsUnitPrice
    }


    public delegate void RangeSetupDelegate();
}
