using C1.Win.Input.MultiColumnCombo;
using MultiColumnComboExplorer.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MultiColumnComboExplorer.Samples
{
    public partial class EmbeddedEditorInDataGridView : UserControl
    {
        public EmbeddedEditorInDataGridView()
        {
            InitializeComponent();
        }

        private void EmbeddedEditorInDataGridView_Load(object sender, EventArgs e)
        {
            DataTable productsTable = DataSource.GetRows("Select * from Products", "Products");

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.DataSource = productsTable;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].HeaderText = "Category";
            dataGridView1.Columns[3].CellTemplate = new MultiColumnComboCell();
        }

        public class MultiColumnComboCell : DataGridViewTextBoxCell
        {
            private object _dataSource;
            Dictionary<long, string> _categories;
            public MultiColumnComboCell()
            {
                var imageColumns = new List<string>() { "Picture" };
                DataTable categoriesTable = DataSource.GetRows("Select * from Categories", "Categories", imageColumns);
                _categories = categoriesTable.AsEnumerable().ToDictionary(row => row.Field<long>("CategoryID"), row => row.Field<string>("CategoryName"));
                _dataSource = categoriesTable;
            }

            public override void InitializeEditingControl(int rowIndex, object initialFormattedValue, DataGridViewCellStyle dataGridViewCellStyle)
            {
                base.InitializeEditingControl(rowIndex, initialFormattedValue, dataGridViewCellStyle);
                MultiColumnComboEditingControl editor = DataGridView.EditingControl as MultiColumnComboEditingControl;

                editor.DataSource = _dataSource;
                editor.ValueMember = "CategoryID";
                editor.DisplayMember = "CategoryName";
                editor.HeaderHeight = editor.Font.Height + editor.Styles.DropDownView.Normal.Margins.Top +
                        editor.Styles.DropDownView.Normal.Margins.Bottom;
                editor.ItemHeight = editor.HeaderHeight * 3;
                editor.Columns[0].Visible = false;

                editor.SelectedValue = Value;
            }


            public override Type EditType => typeof(MultiColumnComboEditingControl);

            public override Type ValueType => typeof(long);

            public override Type FormattedValueType => ValueType;

            protected override object GetFormattedValue(object value, int rowIndex, ref DataGridViewCellStyle cellStyle, TypeConverter valueTypeConverter, TypeConverter formattedValueTypeConverter, DataGridViewDataErrorContexts context)
            {
                return _categories.ContainsKey((long)value) ? _categories[(long)value] : string.Empty;
            }
        }

        public class MultiColumnComboEditingControl : C1MultiColumnCombo, IDataGridViewEditingControl
        {
            [DefaultValue(null)]
            public DataGridView EditingControlDataGridView { get; set; }

            [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
            public object EditingControlFormattedValue
            {
                get => (long)SelectedValue;
                set => SelectedValue = value;
            }

            [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
            public int EditingControlRowIndex { get; set; }
            
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
            public bool EditingControlValueChanged { get; set; }

            public Cursor EditingPanelCursor => base.Cursor;

            public bool RepositionEditingControlOnValueChange => false;

            public void ApplyCellStyleToEditingControl(DataGridViewCellStyle dataGridViewCellStyle)
            {

            }

            public bool EditingControlWantsInputKey(Keys keyData, bool dataGridViewWantsInputKey)
            {
                switch (keyData & Keys.KeyCode)
                {
                    case Keys.Left:
                    case Keys.Up:
                    case Keys.Down:
                    case Keys.Right:
                    case Keys.Home:
                    case Keys.End:
                    case Keys.PageDown:
                    case Keys.PageUp:
                        return true;
                    default:
                        return !dataGridViewWantsInputKey;
                }
            }

            public object GetEditingControlFormattedValue(DataGridViewDataErrorContexts context)
            {
                return EditingControlFormattedValue;
            }

            public void PrepareEditingControlForEdit(bool selectAll)
            {

            }

            protected override void OnSelectedValueChanged(EventArgs e)
            {
                EditingControlValueChanged = true;
                EditingControlDataGridView.NotifyCurrentCellDirty(true);
                base.OnSelectedValueChanged(e);
            }
        }
    }
}
