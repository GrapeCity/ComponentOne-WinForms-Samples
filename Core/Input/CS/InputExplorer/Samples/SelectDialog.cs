using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InputExplorer.Samples
{
    using InputExplorer.Data;
    public partial class SelectDialog : Form
    {
        #region "Properties"

        private DataTable _innerTable;
        private string _keyColumn = "";
        private string _valueColumn = "";

        private object _selectKey = "";
        private object _selectValue = "";

        #endregion

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="sourceTable">Source table for dictionary</param>
        /// <param name="keyColumn">The column for key</param>
        /// <param name="valueColumn">The column for value</param>
        public SelectDialog(DataTable sourceTable, string keyColumn, string valueColumn)
        {
            #region "Check data"

            if (sourceTable == null || string.IsNullOrEmpty(keyColumn) || string.IsNullOrEmpty(valueColumn))
                throw new Exception("Argument wrong!");

            if (!sourceTable.Columns.Contains(keyColumn))
                throw new Exception($"Table do not contains the column {keyColumn}!");

            if (!sourceTable.Columns.Contains(valueColumn))
                throw new Exception($"Table do not contains the column {valueColumn}!");

            #endregion

            _innerTable = sourceTable.Copy();
            _keyColumn = keyColumn;
            _valueColumn = valueColumn;

            InitializeComponent();
        }

        private void SelectDialog_Load(object sender, EventArgs e)
        {
            if(_innerTable != null)
            {
                mainSource.DataSource = _innerTable;
                sourceGrid.DataSource = mainSource;

                // Prepare columns
                var columns = (from s in sourceGrid.Columns.Cast<DataGridViewColumn>() select s)
                    .ToList();
                columns.ForEach(x =>
                {
                    x.Visible = false;
                    if (x.Name.IndexOf(_valueColumn) >= 0)
                        x.Visible = true;

                    x.Width = 350;
                });
            }

            // Add clear button
            findText.ButtonsSettings.ModalButton.Image = InputExplorer.Properties.Resources.delete;
            findText.ButtonsSettings.ModalButton.Visible = true;

            // Add find button
            findText.ButtonsSettings.DropDownButton.Image = InputExplorer.Properties.Resources.search;
            findText.ButtonsSettings.DropDownButton.Visible = true;

            this.ActiveControl = sourceGrid;
        }

        private void mainSource_CurrentChanged(object sender, EventArgs e)
        {
            if(mainSource.Current != null)
            {
                var row = (DataRowView)mainSource.Current;
                _selectKey = row[_keyColumn];
                _selectValue = row[_valueColumn];
            }
        }

        public object Key { get => _selectKey; }

        public object Value { get => _selectValue; }

        private void sourceGrid_DoubleClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void findText_ModalButtonClick(object sender, EventArgs e)
        {
            var item = sender as C1.Win.Input.C1TextBox;
            if (item != null)
            {
                mainSource.Filter = "";
                item.Text = "";
            }
        }

        private void findText_DropDownButtonClick(object sender, EventArgs e)
        {
            var item = sender as C1.Win.Input.C1TextBox;
            if (item != null)
                mainSource.Filter = $"{_valueColumn} like '%{item.Text}%'";
        }
    }
}
