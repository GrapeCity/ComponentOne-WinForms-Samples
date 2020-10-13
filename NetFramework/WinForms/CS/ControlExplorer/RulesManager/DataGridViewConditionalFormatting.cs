using C1.Win.C1Themes;
using C1.Win.CoditionalFormatting;
using C1.Win.Ribbon;
using C1.Win.RulesManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlExplorer.RulesManager
{
    public partial class DataGridViewConditionalFormatting : C1DemoForm
    {
        private const string xmlFileName = "DataGridViewConditionalFormattingRules.xml";
        private string pathToXmlFile = null;

        #region Initialization

        public DataGridViewConditionalFormatting()
        {
            InitializeComponent();
        }

        private void DataGridViewConditionalFormatting_Load(object sender, EventArgs e)
        {
            rulesManager.Options.AllowedRules = RuleTypes.Solid;
            rulesManager.Options.IsBorderColorVisible = false;
            rulesManager.Options.IsTextAlignVisible = false;

            formattableDataGridView.DataSource = DemoDataSource("Products");

            ApplyRules();

            // uncomment line below to allow saving of changed rules in xml file and loading of it on startup of application
            // rulesManager.RulesChanged += RulesManager_RulesChanged;
        }

        private void ApplyRules()
        {
            pathToXmlFile = Path.Combine(Directory.GetCurrentDirectory(), xmlFileName);

            if (!File.Exists(pathToXmlFile))
            {
                ApplyPredefinedRules();
            }
            else
            {
                rulesManager.LoadRules(pathToXmlFile);
            }
        }

        private void ApplyPredefinedRules()
        {
            var rule1 = new C1.Win.RulesManager.Rule()
            {
                Name = "In Order",
                Expression = "= [UnitsOnOrder] > 0",
                Style = new ItemStyle()
                {
                    ForeColor = Color.DarkBlue,
                    BorderColor = Color.DarkBlue,
                    FontStyle = FontStyle.Bold
                }
            };
            rule1.AppliesTo.Add(new FieldRange(new string[] { "UnitsOnOrder" }));
            rulesManager.Rules.Add(rule1);

            var rule2 = new C1.Win.RulesManager.Rule()
            {
                Name = "Only Few In Stock",
                Expression = "= [UnitsInStock] < 10",
                Style = new ItemStyle()
                {
                    ForeColor = Color.White,
                    BackColor = Color.Green
                }
            };
            rule2.AppliesTo.Add(new ItemRange(0, formattableDataGridView.Rows.Count - 1));
            rulesManager.Rules.Add(rule2);
        }

        private void RulesManager_RulesChanged(object sender, ListChangedEventArgs e)
        {
            rulesManager.SaveRules(pathToXmlFile);
        }

        #endregion

    }

    #region FormattableDataGridView

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

    #endregion

}
