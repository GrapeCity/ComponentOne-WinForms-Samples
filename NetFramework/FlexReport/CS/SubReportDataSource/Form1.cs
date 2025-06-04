using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using C1.Report;
using C1.Win.FlexViewer;

namespace SubReportDataSource
{
    public partial class Form1 : Form
    {
        private Color _pressedColor = Color.FromArgb(unchecked((int)0xFFD2BBFF));
        private DataTable _dataTable;
        private string _strFilter;

        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            //
            // create data table
            _dataTable = new DataTable();
            _dataTable.Columns.Add("ProductName", typeof(string));
            _dataTable.Columns.Add("UnitsInStock", typeof(int));
            _dataTable.Columns.Add("CategoryID", typeof(int));
            for (int i = 0; i < 100; i++)
            {
                string name = "Product " + i;
                int units = 5 * i;
                int id = i % 20 + 1;
                _dataTable.Rows.Add(new object[] { name, units, id });
            }

            // save original subreport filter expression
            SubreportField srField = (SubreportField)_c1flxr.Fields["SubreportField"];
            _strFilter = srField.SubreportFilter;

            // hook up startReport event to apply custom filter when needed
            var rptSubreport = srField.Subreport;
            rptSubreport.StartReport += new System.EventHandler(_StartReport);
        }

        private void _btnTool_Click(object sender, EventArgs e)
        {
            if (_ppv.DocumentSource == null)
            {
                MessageBox.Show("Please select a report first.");
                return;
            }

            if (sender == _btnFirstPage)
                _ppv.PageIndex = 0;
            else if (sender == _btnPrevPage)
                --_ppv.PageIndex;
            else if (sender == _btnNextPage)
                ++_ppv.PageIndex;
            else if (sender == _btnLastPage)
                _ppv.PageIndex = _ppv.DocumentSource.PageCount - 1;
            else if (sender == _btnZoomOut)
                _ppv.ZoomFactor -= .1F;
            else if (sender == _btnZoomIn)
                _ppv.ZoomFactor += .1F;
            else if (sender == _btnZoomFit)
                _ppv.ZoomMode = FlexViewerZoomMode.WholePage;
        }

        private void _btnRepDefault_Click(object sender, EventArgs e)
        {
            _btnRepDefault.BackColor = _pressedColor;
            _btnRepCustom.BackColor = Color.Empty;
            _btnRepCustomFilter.BackColor = Color.Empty;
            RenderDefault();
        }

        private void _btnRepCustom_Click(object sender, EventArgs e)
        {
            _btnRepCustom.BackColor = _pressedColor;
            _btnRepDefault.BackColor = Color.Empty;
            _btnRepCustomFilter.BackColor = Color.Empty;
            RenderCustom();
        }

        private void _btnRepCustomFilter_Click(object sender, EventArgs e)
        {
            _btnRepCustomFilter.BackColor = _pressedColor;
            _btnRepCustom.BackColor = Color.Empty;
            _btnRepDefault.BackColor = Color.Empty;
            RenderCustomFilter();
        }

        // render report using data from the database
        private void RenderDefault()
        {
            // reset subreport custom data
            // (will use ConnectionString and RecordSource properties)
            SubreportField srField = (SubreportField)_c1flxr.Fields["SubreportField"];
            var rptSubreport = srField.Subreport;
            rptSubreport.DataSource.Recordset = null;

            //// use original subreport filter (based on category ID)
            srField.SubreportFilter = _strFilter;

            // render report
            _c1flxr.RenderAsync();
            _ppv.DocumentSource = _c1flxr;
        }

        // render report using data from _dataTable object
        // and the default filter mechanism
        private void RenderCustom()
        {
            // use custom data source
            SubreportField srField = (SubreportField)_c1flxr.Fields["SubreportField"];
            var rptSubreport = srField.Subreport;
            rptSubreport.DataSource.Recordset = _dataTable;

            // use original subreport filter (based on category ID)
            srField.SubreportFilter = _strFilter;

            // render report
            _c1flxr.RenderAsync();
            _ppv.DocumentSource = _c1flxr;
        }

        // render report using data from _dataTable object
        // and a custom filter
        private void RenderCustomFilter()
        {
            // use custom data source
            SubreportField srField = (SubreportField)_c1flxr.Fields["SubreportField"];
            var rptSubreport = srField.Subreport;
            rptSubreport.DataSource.Recordset = _dataTable;

            // use custom filter:
            srField.SubreportFilter = "";

            // render report
            _c1flxr.RenderAsync();
            _ppv.DocumentSource = _c1flxr;
        }

        // apply custom filter if one wasn't provided
        private void _StartReport(object sender, System.EventArgs e)
        {
            // get subreport field
            SubreportField srField = (SubreportField)_c1flxr.Fields["SubreportField"];

            // if the filter is set, nothing to do
            if (!string.IsNullOrEmpty((string)srField.SubreportFilter))
                return;

            // build custom filter
            // (add 5 to current ID just to show that it works)
            int currentID = (int)_c1flxr.Evaluate("CategoryID");
            string filter = string.Format("CategoryID = '{0}'", currentID + 5);

            // apply custom filter
            DataView dv = _dataTable.DefaultView;
            dv.RowFilter = filter;

            // and apply data source to the report
            var rptSubreport = srField.Subreport;
            rptSubreport.DataSource.Recordset = dv.ToTable();
        }
    }
}
