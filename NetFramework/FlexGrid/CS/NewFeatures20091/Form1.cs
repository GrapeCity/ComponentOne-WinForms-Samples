using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;

namespace NewFeatures20091
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void Form1_Load(object sender, EventArgs e)
        {
            // declare and fill data tables
            DataTable dtProducts = new DataTable();
            DataTable dtCategories = new DataTable();
            string conn = GetConnectionString();
            OleDbDataAdapter da = new OleDbDataAdapter("select * from products", conn);
            da.Fill(dtProducts);
            da = new OleDbDataAdapter("select * from categories", conn);
            da.Fill(dtCategories);

            // bind grids to data
            _flexNewRowWatermark.DataSource = dtCategories;
            _flexClipboardCopyMode.DataSource = dtCategories;
            _flexAllowMergingFixed.DataSource = dtProducts;
            _flexEditOptions.DataSource = dtProducts;
            _flexRowValidation.DataSource = dtCategories;
            _flexSubtotals.DataSource = dtProducts;

            // initialize NewRowWatermark
            _txtNewRowWatermark_TextChanged(null, EventArgs.Empty);

            // initialize ClipboardCopyMode
            _cmbClipboardCopyMode.SelectedIndex = 0;

            // initialize subtotals
            _cmbAggregate.SelectedIndex = 0;

            // initialize AllowMergingFixed: free merging in column area
            _flexAllowMergingFixed.AllowMerging = AllowMergingEnum.Free;
            foreach (string colName in "SupplierID,CategoryID,Discontinued".Split(','))
            {
                _flexAllowMergingFixed.Cols[colName].AllowMerging = true;
            }

            // initialize AllowMergingFixed: custom merging in fixed area
            _cmbAllowMergingFixed.Text = "Custom";
            MergeColumnHeaders(_flexAllowMergingFixed);

            // initialize EditOptions
            Dictionary<int, string> map = new Dictionary<int, string>();
            foreach (DataRow cat in dtCategories.Rows)
            {
                map.Add((int)cat["CategoryID"], (string)cat["CategoryName"]);
            }
            _flexEditOptions.Cols["CategoryID"].DataMap = map;
            _flexEditOptions.AllowAddNew = false;
        }
        static string GetConnectionString()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common";
            string conn = @"provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;";
            return string.Format(conn, path);
        }

        //----------------------------------------------------------------
        #region ** NewRowWatermark

        void _txtNewRowWatermark_TextChanged(object sender, EventArgs e)
        {
            _flexNewRowWatermark.NewRowWatermark = _txtNewRowWatermark.Text;
        }
        #endregion

        //----------------------------------------------------------------
        #region ** ClipboardCopyMode

        void _btnCopy_Click(object sender, EventArgs e)
        {
            _txtClipboard.Text = _flexClipboardCopyMode.Clip.Replace("\r", "\r\n");
        }
        void _cmbClipboardCopyMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            _flexClipboardCopyMode.ClipboardCopyMode = (ClipboardCopyModeEnum)Enum.Parse(typeof(ClipboardCopyModeEnum), _cmbClipboardCopyMode.Text);
        }
        #endregion

        //----------------------------------------------------------------
        #region ** RowValidating/RowValidated

        void _flexRowValidation_RowValidating(object sender, RowColEventArgs e)
        {
            if (_flexRowValidation.ContainsFocus)
            {
                // TFS 353885
                object categoryValue = _flexRowValidation[e.Row, "CategoryName"];

                string catName = (categoryValue is DBNull || string.IsNullOrEmpty((string)categoryValue)) ? string.Empty : (string)categoryValue;

                var regex = new Regex(@"^\D\S{3,}");

                if (!regex.Match(catName).Success)
                {
                    MessageBox.Show("Category name should be longer then 3 symbols and starts with letter.\nChange current category name in the proper way.", "RowValidating failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }

                _lstRowValidationEventLog.Items.Add(string.Format("RowValidating: index {0}", e.Row));
            }
        }
        void _flexRowValidation_RowValidated(object sender, RowColEventArgs e)
        {
            if (_flexRowValidation.ContainsFocus)
            {
                _lstRowValidationEventLog.Items.Add(string.Format("RowValidated: index {0}", e.Row));
            }
        }
        void _btnRowValidationEventLog_Click(object sender, EventArgs e)
        {
            _lstRowValidationEventLog.Items.Clear();
        }
        #endregion

        //----------------------------------------------------------------
        #region ** Before/AfterSubtotal

        void _btnSubtotal_Click(object sender, EventArgs e)
        {
            // remove old totals
            _flexSubtotals.Subtotal(AggregateEnum.Clear);
            _lstSubtotal.Items.Clear();

            // calculate new totals
            AggregateEnum aggregate = (AggregateEnum)Enum.Parse(typeof(AggregateEnum), _cmbAggregate.Text);
            int groupOn = _flexSubtotals.Cols.IndexOf("CategoryID");
            
            int totalOn = _flexSubtotals.Cols.IndexOf("UnitPrice");
            _flexSubtotals.Subtotal(aggregate, 0, groupOn, groupOn, totalOn, _cmbAggregate.Text + " for category {0}");

            totalOn = _flexSubtotals.Cols.IndexOf("UnitsInStock");
            _flexSubtotals.Subtotal(aggregate, 0, groupOn, groupOn, totalOn, _cmbAggregate.Text + " for category {0}");

            totalOn = _flexSubtotals.Cols.IndexOf("UnitsOnOrder");
            _flexSubtotals.Subtotal(aggregate, 0, groupOn, groupOn, totalOn, _cmbAggregate.Text + " for category {0}");

            totalOn = _flexSubtotals.Cols.IndexOf("ReorderLevel");
            _flexSubtotals.Subtotal(aggregate, 0, groupOn, groupOn, totalOn, _cmbAggregate.Text + " for category {0}");
        }
        void _flexSubtotals_BeforeSubtotal(object sender, SubtotalEventArgs e)
        {
            _lstSubtotal.Items.Add(string.Format("BeforeSubtotal, adding row {0}", e.NewRowIndex));
        }
        void _flexSubtotals_AfterSubtotal(object sender, SubtotalEventArgs e)
        {
            _lstSubtotal.Items.Add(string.Format("AfterSubtotal, added row {0}", e.NewRowIndex));
        }
        #endregion

        //----------------------------------------------------------------
        #region ** AllowMergingFixed

        void _cmbAllowMergingFixed_SelectedIndexChanged(object sender, EventArgs e)
        {
            _flexAllowMergingFixed.AllowMergingFixed = (AllowMergingEnum)Enum.Parse(typeof(AllowMergingEnum), _cmbAllowMergingFixed.Text);
        }
        void MergeColumnHeaders(C1FlexGrid fg)
        {
            // custom merge column headers
            fg.Rows.Fixed = 2;

            int colIndex = fg.Cols.IndexOf("ProductName");
            fg[0, colIndex] = "Product Name";
            fg.MergedRanges.Add(fg.GetCellRange(0, colIndex, 1, colIndex));

            colIndex++;
            fg[0, colIndex] = "ID";
            fg[1, colIndex] = "Supplier";

            colIndex++;
            fg[0, colIndex] = "ID";
            fg[1, colIndex] = "Category";
            fg.MergedRanges.Add(fg.GetCellRange(0, colIndex - 1, 0, colIndex));

            colIndex++;
            fg[0, colIndex] = "Quantity Per Unit";
            fg.MergedRanges.Add(fg.GetCellRange(0, colIndex, 1, colIndex));

            colIndex++;
            fg[0, colIndex] = "Unit Price";
            fg.MergedRanges.Add(fg.GetCellRange(0, colIndex, 1, colIndex));

            colIndex++;
            fg[0, colIndex] = "Units";
            fg[1, colIndex] = "In Stock";

            colIndex++;
            fg[0, colIndex] = "Units";
            fg[1, colIndex] = "On Order";

            colIndex++;
            fg[0, colIndex] = "Units";
            fg[1, colIndex] = "Reorder Level";

            fg.MergedRanges.Add(fg.GetCellRange(0, colIndex - 2, 0, colIndex));

            colIndex++;
            fg.MergedRanges.Add(fg.GetCellRange(0, colIndex, 1, colIndex));
        }
        #endregion

        //----------------------------------------------------------------
        #region ** EditOptions

        void _chkEditOption_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            EditFlags flag = (EditFlags)Enum.Parse(typeof(EditFlags), cb.Text);

            _flexEditOptions.EditOptions = cb.Checked
                ? _flexEditOptions.EditOptions | flag
                : _flexEditOptions.EditOptions & ~flag;
        }

        #endregion
    }
}
