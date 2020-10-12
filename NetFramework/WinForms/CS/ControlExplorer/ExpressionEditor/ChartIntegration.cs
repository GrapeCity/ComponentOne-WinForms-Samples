using System;
using System.Data;

namespace ControlExplorer.ExpressionEditor
{
    public partial class ChartIntegration : C1DemoForm
    {
        C1.Win.ExpressionEditor.ExpressionEditorForm _dialog;
        DataView _dv;

        public ChartIntegration()
        {
            InitializeComponent();
        }

        private void ChartIntegration_Load(object sender, EventArgs e)
        {
            _dv = DemoDataSource("Products").DefaultView;
            _dv.RowFilter = "[UnitsInStock] > 100";

            _dialog = new C1.Win.ExpressionEditor.ExpressionEditorForm();
            _dialog.Apply += _dialog_Apply;
            _dialog.DataSource = _dv.Table;

            productChart.DataSource = _dv;
            productChart.ChartGroups[0].ChartData.SeriesList[0].Y.DataField = "Products.UnitsInStock";
            productChart.ChartGroups[0].ChartData.SeriesList[0].X.DataField = "Products.ProductName";
        }

        private void ApplyExpression()
        {
            try
            {
                if (_dialog != null)
                    _dv.RowFilter = _dialog.Expression;
            }
            catch (EvaluateException)
            {
            }
        }

        private void _dialog_Apply(object sender, EventArgs e)
        {
            ApplyExpression();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _dialog.Expression = _dv.RowFilter;
            _dialog.ShowDialog();
            if(_dialog.DialogResult == System.Windows.Forms.DialogResult.OK)
                ApplyExpression();
        }

        protected override void OnThemeApplied() => Explorer.ApplyTheme(_dialog);
    }
}
