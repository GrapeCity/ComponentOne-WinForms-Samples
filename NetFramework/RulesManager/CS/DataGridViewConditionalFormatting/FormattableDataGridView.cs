using C1.Win.CoditionalFormatting;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;

namespace DataGridViewConditionalFormatting
{
    public class FormattableDataGridView : DataGridView, IFormattableView
    {
        public event ListChangedEventHandler DataChanged;
        public event EventHandler<ItemFormattingEventArgs> ItemFormatting;

        IEnumerable<string> IFormattableView.GetFieldNames()
        {
            var fields = new List<string>();
            foreach (var column in Columns)
            {
                var name = (column as DataGridViewColumn)?.DataPropertyName;
                if (!string.IsNullOrEmpty(name))
                {
                    fields.Add(name);
                }
            }

            return fields;
        }

        int IFormattableView.GetItemCount()
        {
            return Rows.Count;
        }

        object IFormattableView.GetValue(int row, string col)
        {
            return this[col, row].Value;
        }

        protected override void OnDataBindingComplete(DataGridViewBindingCompleteEventArgs e)
        {
            base.OnDataBindingComplete(e);
            DataChanged?.Invoke(this, new ListChangedEventArgs(ListChangedType.Reset, 0));
        }

        protected override void OnCellPainting(DataGridViewCellPaintingEventArgs e)
        {
            var columnIndex = e.ColumnIndex;
            var rowIndex = e.RowIndex;
            if (columnIndex >= 0 && rowIndex >= 0)
            {
                var ifea = new ItemFormattingEventArgs(rowIndex, Columns[columnIndex].DataPropertyName);
                ItemFormatting?.Invoke(this, ifea);

                var ruleStyle = ifea?.Style;
                if (ruleStyle != null)
                {
                    var cellStyle = e.CellStyle;

                    var backColor = ruleStyle.BackColor;
                    if (!backColor.IsEmpty)
                    {
                        cellStyle.BackColor = backColor;
                    }

                    var foreColor = ruleStyle.ForeColor;
                    if (!foreColor.IsEmpty)
                    {
                        cellStyle.ForeColor = foreColor;
                    }

                    var fontStyle = ruleStyle.FontStyle;
                    if (cellStyle.Font.Style != fontStyle && fontStyle != FontStyle.Regular)
                    {
                        cellStyle.Font = new Font(cellStyle.Font, fontStyle);
                    }
                }
            }

            base.OnCellPainting(e);
        }

        void IFormattableView.UpdateView()
        {
            Invalidate();
        }
    }
}
