using C1.Chart;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataFilterExplorer.Samples
{
    public partial class FlexChartDateTimeFilterView : FlexChartFilterView
    {
        #region fields
        private ComboBox _cbGroupBy, _cbAggregate;
        private DateTimeGroupOption _groupBy;
        private AggregateFunction _aggregate;
        #endregion

        #region Properties
        public DateTimeGroupOption GroupBy
        {
            get { return _groupBy; }
            set
            {
                if (_groupBy != value)
                {
                    _groupBy = value;
                    _cbGroupBy.SelectedIndex = _cbGroupBy.SelectedIndex == -1 ? -1 : (int)value;
                    GroupByChanged?.Invoke(this, null);
                }
            }
        }
        public AggregateFunction Aggregate
        {
            get { return _aggregate; }
            set
            {
                if (_aggregate != value)
                {
                    _aggregate = value;
                    _cbAggregate.SelectedIndex = _cbAggregate.SelectedIndex == -1 ? -1 : (int)value;
                    AggregateChanged?.Invoke(this, null);
                }
            }
        }
        public bool ShowGroupBy
        {
            get { return _cbGroupBy.Visible; }
            set { _cbGroupBy.Visible = value; }
        }
        public bool ShowAggregate
        {
            get { return _cbAggregate.Visible; }
            set { _cbAggregate.Visible = value; }
        }
        #endregion

        #region c'tor
        public FlexChartDateTimeFilterView(IEnumerable<object> items, string bindingX, string binding, ChartType chartType = ChartType.Column) : base(items, bindingX, binding, chartType)
        {
            InitializeComponent();

            _cbGroupBy = new ComboBox()
            {
                Width = 80,
                FlatStyle = FlatStyle.Flat,
                DataSource = Enum.GetValues(typeof(DateTimeGroupOption)),
            };
            _cbGroupBy.SelectedIndexChanged += _cbGroupBy_SelectedIndexChanged;

            _cbAggregate = new ComboBox()
            {
                Width = 80,
                FlatStyle = FlatStyle.Flat,
                DataSource = Enum.GetValues(typeof(AggregateFunction)),
            };
            _cbAggregate.SelectedIndexChanged += _cbAggregate_SelectedIndexChanged;

            GroupBy = DateTimeGroupOption.ShowAll;
            Aggregate = AggregateFunction.Sum;

            this._pnlControlOptions.Controls.Add(_cbGroupBy);
            this._pnlControlOptions.Controls.Add(_cbAggregate);
        }
        #endregion

        #region Events
        public event EventHandler GroupByChanged;
        public event EventHandler AggregateChanged;
        #endregion

        #region Control EventHandlers
        private void _cbAggregate_SelectedIndexChanged(object sender, EventArgs e)
        {
            Aggregate = (AggregateFunction)_cbAggregate.SelectedValue;
            //AggregateChanged?.Invoke(sender, e);
        }
        private void _cbGroupBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            GroupBy = (DateTimeGroupOption)_cbGroupBy.SelectedValue;
            //GroupByChanged?.Invoke(sender, e);
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _cbGroupBy.SelectedIndex = (int)GroupBy;
            _cbAggregate.SelectedIndex = (int)Aggregate;
        }
        #endregion
    }
}
