using C1.Win.FlexGrid;
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
                DisplayMember = "CategoryName"                
                
            };
            categoryEditor.HeaderHeight = categoryEditor.Font.Height + categoryEditor.Styles.DropDownView.Normal.Margins.Top +
                    categoryEditor.Styles.DropDownView.Normal.Margins.Bottom;
            categoryEditor.HeaderHeight = categoryEditor.HeaderHeight * 3;
            categoryEditor.FontChanged += CategoryEditor_FontChanged;
            categoryEditor.Columns[0].Visible = false;
            Dictionary<long, string> categories = categoriesTable.AsEnumerable().ToDictionary(row => row.Field<long>("CategoryID"), row => row.Field<string>("CategoryName"));

            c1FlexGrid1.DataSource = productsTable;
            c1FlexGrid1.Cols[1].Visible = false;
            c1FlexGrid1.Cols[3].Visible = false;
            c1FlexGrid1.Cols[4].Editor = categoryEditor;
            c1FlexGrid1.Cols[4].Caption = "Category";
            c1FlexGrid1.Cols[4].DataMap = categories;
            c1FlexGrid1.SetupEditor += C1FlexGrid1_SetupEditor;
        }

        private void C1FlexGrid1_SetupEditor(object sender, RowColEventArgs e)
        {
            if (c1FlexGrid1.Cols[e.Col].Editor is C1MultiColumnCombo multiColumnCombo)
            {
                multiColumnCombo.HeaderHeight = multiColumnCombo.Font.Height + multiColumnCombo.Styles.DropDownView.Normal.Margins.Top +
                    multiColumnCombo.Styles.DropDownView.Normal.Margins.Bottom;
                multiColumnCombo.ItemHeight = multiColumnCombo.HeaderHeight * 3;
            }
        }

        private void CategoryEditor_FontChanged(object sender, EventArgs e)
        {

        }
    }
}
