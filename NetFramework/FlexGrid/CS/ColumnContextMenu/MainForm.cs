using C1.Win.C1Themes;
using C1.Win.Ribbon;
using C1.Win.RulesManager;
using C1.DataFilter;
using C1.DataCollection;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ColumnContextMenu
{
    using Forms;

    public partial class MainForm : C1RibbonForm
    {
        private ConditionalFormattingForm _rulesForm;
        private FilterEditor _filterForm;
        private Image _checkedImage;

        public MainForm()
        {
            InitializeComponent();

            _checkedImage = Properties.Resources.Checked;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitThemes();
            InitData();
            InitForms();
        }

        private void InitForms()
        {
            // Apply default filter - show only invoices with discount
            _filterForm = new FilterEditor(c1FlexGrid1);            
            var expression = new CombinationExpression();
            expression.Expressions.Add(new OperationExpression()
            {
                PropertyName = "Discount",
                FilterOperation = FilterOperation.GreaterThan,
                Value = 0
            });
            _filterForm.SetExpression(expression);

            // Apply default rule - bold text for major invoice records
            _rulesForm = new ConditionalFormattingForm(c1FlexGrid1);
            var rule = new C1.Win.RulesManager.Rule()
            {
                Name = "Major Invoices",
                Expression = "=[ExtendedPrice] > 1000",
                Style = new ItemStyle()
                {
                    FontStyle = FontStyle.Bold
                }
            };
            _rulesForm.Rules.Add(rule);

        }

        private void c1FlexGrid1_ColumnContextMenuOpening(object sender, C1.Win.C1FlexGrid.ColumnContextMenuOpeningEventArgs e)
        {
            // Update column context menu only for non-fixed columns
            if (e.Col >= c1FlexGrid1.Cols.Fixed)
            {
                var items = e.ContextMenuStrip.Items;

                // Add new separator menu item
                items.Add(new ToolStripSeparator());

                // Add new conditional formatting menu item
                var rulesItem = new ToolStripMenuItem("Conditional Formatting");
                rulesItem.Click += (s, eargs) => _rulesForm.ShowDialog();
                if (!_rulesForm.IsEmpty)
                    rulesItem.Image = _checkedImage;
                items.Add(rulesItem);

                // Add new data filter menu item
                var filterItem = new ToolStripMenuItem("Filter");
                filterItem.Click += (s, eargs) => _filterForm.ShowDialog();
                if (!_filterForm.IsEmpty)
                    filterItem.Image = _checkedImage;
                items.Add(filterItem);
            }
        }

        #region Themes

        private void InitThemes()
        {
            var themes = C1ThemeController.GetThemes().Where(x => x.Contains("Office2016"));
            foreach (var theme in themes)
                cmbTheme.Items.Add(theme);
            cmbTheme.SelectedIndex = 3;
        }

        private void cmbTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            C1ThemeController.ApplicationTheme = cmbTheme.SelectedItem.Text;
        }

        #endregion

        #region Data
        // Get standard nwind mdb connection string
        static string GetConnectionString()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common";
            string conn = @"provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;";
            return string.Format(conn, path);
        }

        // Load data
        private void InitData()
        {
            var da = new OleDbDataAdapter("select * from Invoices", GetConnectionString());
            var dt = new DataTable();
            da.Fill(dt);
            c1FlexGrid1.DataSource = dt;
        }
        #endregion
    }
}
