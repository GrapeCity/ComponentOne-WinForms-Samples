using C1.Win.Input.MultiColumnCombo;
using MultiColumnComboExplorer.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MultiColumnComboExplorer.Samples
{
    public partial class EmbeddedEditorInFlexGrid : UserControl
    {
        public EmbeddedEditorInFlexGrid()
        {
            InitializeComponent();
        }

        private void EmbeddedEditor_Load(object sender, EventArgs e)
        {
            var imageColumns = new List<string>() { "Picture" };
            DataTable categoriesTable = DataSource.GetRows("Select * from Categories", "Categories", imageColumns);
            DataTable productsTable = DataSource.GetRows("Select * from Products", "Products");
            // C1MultiColumnCombo as category editor
            C1MultiColumnCombo categoryEditor = new()
            {
                DataSource = categoriesTable,
                ValueMember = "CategoryID",
                DisplayMember = "CategoryName",
                HeaderHeight = 22,
                ItemHeight = 54,
            };
            categoryEditor.Columns[0].Visible = false;
            Dictionary<long, string> categories = categoriesTable.AsEnumerable().ToDictionary(row => row.Field<long>("CategoryID"), row => row.Field<string>("CategoryName"));

            c1FlexGrid1.DataSource = productsTable;
            c1FlexGrid1.Cols[1].Visible = false;
            c1FlexGrid1.Cols[3].Visible = false;
            c1FlexGrid1.Cols[4].Editor = categoryEditor;
            c1FlexGrid1.Cols[4].Caption = "Category";
            c1FlexGrid1.Cols[4].DataMap = categories;
        }
    }
}
