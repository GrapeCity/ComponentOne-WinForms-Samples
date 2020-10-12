using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C1.Win.FlexReport;

namespace AdHocSorting
{
    public partial class Form1 : Form
    {
        private bool _internalChange = false;

        public Form1()
        {
            InitializeComponent();
            _rbtnAscending.Checked = true;
            _flexRep_ReportDefinitionChanged(_flexRep, EventArgs.Empty);
        }

        private void _flexRep_ReportDefinitionChanged(object sender, EventArgs e)
        {
            if (_internalChange)
                return;

            _lbFields.Items.Clear();
            _btnLoadReport.Text = _flexRep.ReportName;

            var ds = _flexRep.DataSource;
            if (ds == null)
                return;
            //
            // Two alternative ways to get the list of db fields to sort on:
            //
            // This 1st alternative retrieves the list of actual data source fields.
            // Unlike the 2nd alternative below, this will include fields that are not shown in the report
            // (such as CategoryID or ProductID in the sample), which may confuse the end user.
            // On the other hand, the alternative code will only work correctly for certain simple
            // where report fields use simple db field names as binding expressions.
            // In a real application additional logic would be required to build the appropriate list.
            //
#if fetch_datasource_fields
            foreach (var field in ds.DataSourceInfo.TextFields)
                _lbFields.Items.Add(field.Name);
#else
            foreach (FieldBase field in _flexRep.Sections.Detail.Fields)
            {
                string txt;
                if (field is TextField && ((TextField)field).Text.IsExpression)
                    txt = ((TextField)field).Text.Expression;
                else if (field is Field && ((Field)field).Calculated)
                    txt = ((Field)field).Text;
                else
                    txt = null;

                if (!string.IsNullOrEmpty(txt))
                    _lbFields.Items.Add(txt);
            }
#endif
        }

        private void _rbtnAscending_CheckedChanged(object sender, EventArgs e)
        {
            _rbtnDescending.Checked = !_rbtnAscending.Checked;
        }

        private void _rbtnDescending_CheckedChanged(object sender, EventArgs e)
        {
            _rbtnAscending.Checked = !_rbtnDescending.Checked;
        }

        private void _btnRender_Click(object sender, EventArgs e)
        {
            _internalChange = true;
            //
            _flexRep.DataSource.SortDefinitions.Clear();
            //
            string sortField = _lbFields.SelectedItem as string;
            if (!string.IsNullOrEmpty(sortField))
            {
                C1.Win.FlexReport.SortDefinition sd =
                    new C1.Win.FlexReport.SortDefinition(sortField,
                        _rbtnAscending.Checked ? C1.Win.FlexReport.SortDirection.Ascending : C1.Win.FlexReport.SortDirection.Descending);
                _flexRep.DataSource.SortDefinitions.Add(sd);
            }
            //
            try
            {
                _flexRep.Render();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error Rendering Report", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            c1FlexViewerPane1.DocumentSource = _flexRep;
            //
            _internalChange = false;
        }

        private void _btnLoadReport_Click(object sender, EventArgs e)
        {
            using (FlexPicker fp = new FlexPicker())
            {
                fp.FileName = _flexRep.FileName;
                if (fp.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                {
                    c1FlexViewerPane1.DocumentSource = null;
                    _flexRep.Load(fp.FileName, fp.ReportName);
                }
            }
        }
    }
}
