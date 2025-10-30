namespace FlexGridCheckboxSelection
{
    public partial class Form1 : Form
    {
        #region Private Varables

        readonly IRowKeyProvider _keyProvider;
        readonly IGridGrouper _grouper;
        readonly IDataProvider _dataProvider;
        readonly SelectionStateService _selectionService;
        readonly IMessageBoxService _messageBoxService;
        readonly GridBinder _binder;
        readonly ColumnInfoManager _columnInfoManager;
        DataTable _originalDataTable;

        #endregion

        #region Public Methods
        public Form1()
        {
            InitializeComponent();
            InitializeLocalizedText();

            if (IsDesignMode()) return;

            //Enable FlexGrid Checkbox
            c1FlexGrid1.SelectionMode = SelectionModeEnum.CheckBox;

            _keyProvider = new DefaultRowKeyProvider();
            _selectionService = new SelectionStateService(c1FlexGrid1, _keyProvider);
            _grouper = new GridGrouper(c1FlexGrid1);
            _binder = new GridBinder(c1FlexGrid1, _selectionService, _grouper);
            _columnInfoManager = new ColumnInfoManager(c1FlexGrid1, _selectionService, _grouper);
            _dataProvider = new DefaultDataProvider();
            _messageBoxService = new MessageBoxService();
        }

        #endregion

        #region Private Methods
        private void InitializeLocalizedText()
        {
            this.Text = Strings.SampleTitle;
            lblDesc.Text = Strings.SampleDescription;
            cbGroupedData.Text = Strings.GroupedDataTxt;
            cbHeaderCol.Text = Strings.HeaderColumnTxt;
        }

        private static bool IsDesignMode() =>
            LicenseManager.UsageMode == LicenseUsageMode.Designtime;

        private async void Form1_Load(object? sender, EventArgs e)
        {
            if (IsDesignMode()) return;

            var result = await Task.Run(() =>
            {
                var data = _dataProvider.GetRowsSafe(SqlQuery.CustomerSqlQuery, out var dt, out var error);
                return (data, dt, error);
            });

            _originalDataTable = result.dt;
            _binder.Rebind(_originalDataTable, grouped: result.data && _originalDataTable.Rows.Count > 0);

            if (!result.data && !string.IsNullOrWhiteSpace(result.error))
            {
                BeginInvoke(() =>
                _messageBoxService.ShowWarning(string.Format(Strings.DataLoadWarning, result.error)));
            }
        }

        private void cbHeaderCol_CheckedChanged(object sender, EventArgs e)
        {
            bool showHeader = cbHeaderCol.Checked;
            bool reGroup = cbGroupedData.Checked;

            _columnInfoManager.ApplyHeader(showHeader, reGroupAfter: reGroup);
            UiUpdater.UpdateSelectedCount(c1FlexGrid1, txtSelectedCount);
        }

        private void cbGroupedData_CheckedChanged(object sender, EventArgs e)
        {
            bool grouped = cbGroupedData.Checked;
            _binder.Rebind(_originalDataTable, grouped);
            UiUpdater.UpdateSelectedCount(c1FlexGrid1, txtSelectedCount);
        }

        private void c1FlexGrid1_AfterSelChange(object sender, RangeEventArgs e)
        {
            UiUpdater.UpdateSelectedCount(c1FlexGrid1, txtSelectedCount);
        } 
        #endregion
    }
}
