using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C1.PivotEngine;

namespace FlexPivotExplorer.Samples.FlexPivotRanges
{
    public partial class PivotView : UserControl
    {
        private int _activeView;

        public PivotView()
        {
            InitializeComponent();
            BigNumericStep = 200;
            SmallNumericStep = 50;
            FirstMonthOfFiscalYear = 4;
            Views = new List<View>();
            RegisterViews();
            ShowFlexPivotPanel = false;
        }

        [DefaultValue(true)]
        public bool ShowSlicers
        {
            get => splitContainer1.Visible;
            set => splitContainer1.Visible = value;
        }

        [DefaultValue(false)]
        public bool ShowFlexPivotPanel
        {
            get => !splitContainer2.Panel2Collapsed;
            set => splitContainer2.Panel2Collapsed = !value;
        }

        [DefaultValue(200)]
        public int BigNumericStep { get; set; }

        [DefaultValue(50)]
        public int SmallNumericStep { get; set; }

        [DefaultValue(4)]
        public int FirstMonthOfFiscalYear { get; set; }

        [DefaultValue(0)]
        public int ActiveViewIndex
        {
            get => _activeView;
            set
            {
                _activeView = value;
                if (Engine.Fields.Count > 0)
                    Views[_activeView].Action?.Invoke();

            }
        }

        public List<View> Views
        {
            get;
        }

        public void WorkspaceSetup(string connectionString)
        {
            var da = new OleDbDataAdapter("select * from invoices", connectionString);
            var dt = new DataTable();
            da.Fill(dt);

            // bind to FlexPivot page
            this.pivotPanel.DataSource = dt;

            Engine.ValueFields.Add("ExtendedPrice");
            c1FlexPivotSlicer1.Field = Engine.Fields["OrderDate"];
            Engine.Fields["ExtendedPrice"].Caption = "Sales";

            RangesSetupNo();

            c1FlexPivotSlicer1.MultiSelect = true;
            c1FlexPivotSlicer1.ShowSelectAll = false;
        }

        C1PivotEngine Engine => pivotPanel.PivotEngine;

        private void RegisterViews()
        {
            Views.Add(new View("No Ranges", RangesSetupNo));
            Views.Add(new View("Year", "Date", null, RangesSetupYears));
            Views.Add(new View("Year, Month", "Date", null, RangesSetupYearMonth));
            Views.Add(new View("Year vs Week", "Date", null, RangesSetupYearVsWeek));
            Views.Add(new View("Year vs Quarter", "Date", null, RangesSetupYearVsQuarter));
            Views.Add(new View("Fiscal Year", "Date", null, RangesSetupFiscalYears));
            Views.Add(new View("Fiscal Year, Month", "Date", null, RangesSetupFiscalYearMonth));
            Views.Add(new View("Alphabetical", "Text", null, RangesSetupAlphabet));
            Views.Add(new View("Numeric", "Numbers", null, RangesSetupNumeric));
            Views.Add(new View("Continents vs Unit Price (custom event)", "Custom", null, RangesSetupCustom));
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
            c1FlexPivotSlicer2.Field = null;
        }

        private void RangesSetupNo()
        {
            var field = Engine.Fields["OrderDate"];
            Engine.BeginUpdate();
            Clear();

            // No Ranges

            Engine.RowFields.Add("OrderDate");
            Engine.ColumnFields.Add("Country");
            c1FlexPivotSlicer1.Field = Engine.RowFields["OrderDate"];
            c1FlexPivotSlicer2.Field = Engine.ColumnFields["Country"];
            Engine.EndUpdate();
        }

        private void RangesSetupYears()
        {
            Engine.BeginUpdate();
            Clear();

            // Years

            Engine.Fields["OrderDate"].Range.RangeType = RangeType.Format;
            Engine.Fields["OrderDate"].Format = "yyyy";
            Engine.Fields["OrderDate"].Caption = "Year";

            Engine.RowFields.Add("OrderDate");
            Engine.ColumnFields.Add("Country");
            c1FlexPivotSlicer1.Field = Engine.RowFields["OrderDate"];
            c1FlexPivotSlicer2.Field = Engine.ColumnFields["Country"];
            Engine.EndUpdate();
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
            c1FlexPivotSlicer1.Field = Engine.RowFields[0];
            c1FlexPivotSlicer2.Field = Engine.RowFields[1];
            Engine.EndUpdate();
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

            c1FlexPivotSlicer1.Field = Engine.RowFields[0];
            c1FlexPivotSlicer2.Field = Engine.ColumnFields[0];
            Engine.EndUpdate();
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

            c1FlexPivotSlicer1.Field = Engine.RowFields[0];
            c1FlexPivotSlicer2.Field = Engine.ColumnFields[0];
            Engine.EndUpdate();
        }

        private void RangesSetupFiscalYears()
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

            c1FlexPivotSlicer1.Field = Engine.RowFields[0];
            c1FlexPivotSlicer2.Field = Engine.ColumnFields[0];
            Engine.EndUpdate();


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
            c1FlexPivotSlicer1.Field = Engine.RowFields[0];
            c1FlexPivotSlicer2.Field = Engine.RowFields[1];
            Engine.EndUpdate();

        }
        private void RangesSetupQuarters()
        {
            Engine.BeginUpdate();
            Clear();

            Engine.Fields["OrderDate"].Caption = "Quarter";
            Engine.RowFields.Add("OrderDate");
            Engine.ColumnFields.Add("Country");
            Engine.EndUpdate();
            c1FlexPivotSlicer1.Field = Engine.RowFields[0];
            c1FlexPivotSlicer2.Field = Engine.ColumnFields[0];
        }

        private void RangesSetupContinents()
        {
            Engine.BeginUpdate();
            Clear();
            //Engine.Fields["OrderDate"].Ranges = new QuarterRange();
            Engine.Fields["OrderDate"].Caption = "Quarter";
            //Engine.Fields["Country"].Ranges = new ContinentsRange();
            Engine.Fields["Country"].Caption = "Continent";
            Engine.RowFields.Add("OrderDate");
            Engine.ColumnFields.Add("Country");
            Engine.EndUpdate();
            c1FlexPivotSlicer1.Field = Engine.RowFields[0];
            c1FlexPivotSlicer2.Field = Engine.ColumnFields[0];
        }

        private void RangesSetupSells()
        {
            Engine.BeginUpdate();
            Clear();
            Engine.Fields["Country"].Caption = "Country";
            //Engine.Fields["Country"].Ranges = new ContinentsRange();
            Engine.Fields["UnitPrice"].Caption = "Price group";
            Engine.Fields["UnitPrice"].Range.RangeType = RangeType.Numeric;
            Engine.Fields["UnitPrice"].Range.NumericStep = SmallNumericStep;
            Engine.RowFields.Add("UnitPrice");
            Engine.ColumnFields.Add("Country");
            Engine.EndUpdate();
            c1FlexPivotSlicer1.Field = Engine.RowFields[0];
            c1FlexPivotSlicer2.Field = Engine.ColumnFields[0];
        }

        private void RangesSetupAlphabet()
        {
            Engine.BeginUpdate();
            Clear();
            Engine.Fields["OrderDate"].Caption = "Year";
            Engine.Fields["OrderDate"].Range.RangeType = RangeType.Format;
            Engine.Fields["OrderDate"].Format = "yyyy";
            Engine.ColumnFields.Add("OrderDate");
            Engine.RowFields.Add("ProductName");
            Engine.RowFields.Add("ProductName");
            Engine.RowFields[0].Caption = "Product: Group by first letter";
            Engine.RowFields[0].Range.RangeType = RangeType.AlphabeticalIgnoreCase;
            Engine.RowFields[1].Caption = "Product";
            Engine.ColumnFields[0].Range.RangeType = RangeType.Format;
            Engine.ColumnFields[0].Format = "yyyy";

            c1FlexPivotSlicer1.Field = Engine.RowFields[0];
            c1FlexPivotSlicer2.Field = Engine.ColumnFields[0];
            Engine.EndUpdate();
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

            c1FlexPivotSlicer1.Field = Engine.RowFields[0];
            c1FlexPivotSlicer2.Field = Engine.ColumnFields[0];
            Engine.EndUpdate();
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

            c1FlexPivotSlicer1.Field = Engine.RowFields[0];
            c1FlexPivotSlicer2.Field = Engine.ColumnFields[0];
            Engine.EndUpdate();
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

        private void pivotPanel_LoadedFields(object sender, EventArgs e)
        {
            ActiveViewIndex = 1;
        }
    }


    public delegate void RangeSetupDelegate();
    public class View
    {
        public View(string name, string group, Image preview, RangeSetupDelegate action)
        {
            Name = name;
            GroupName = group;
            Preview = preview;
            Action = action;
        }

        public View(string name, RangeSetupDelegate action): this(name, "", null, action)
        {

        }
        public string Name { get; }
        public string GroupName { get; }
        public Image Preview { get; }

        public RangeSetupDelegate Action { get; }
    }
}
