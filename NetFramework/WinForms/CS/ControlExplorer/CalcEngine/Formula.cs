using System;
using System.Windows.Forms;
using C1.CalcEngine;
using C1.CalcEngine.ExcelEngine;
using C1.CalcEngine.VBAEngine;
using C1.CalcEngine.ExpressionEngine;
using C1.Win.C1SuperTooltip;
using System.ComponentModel;

namespace ControlExplorer.CalcEngine
{
    [ToolboxItem(true)]
    public partial class Formula : UserControl
    {
        C1SuperTooltip _tooltip;

        EngineType _engineType;
        ExpressionEngine _engine;
        ExpressionDropDown _dialog;

        public event EventHandler Evaluate;

        public Formula()
        {
            InitializeComponent();
            UpdateEngine();

            _tooltip = new C1SuperTooltip();
            _tooltip.SetToolTip(btnReset, "Reset Expression");
            _tooltip.SetToolTip(btnEvaluate, "Evaluate Expression");
            _tooltip.SetToolTip(expressionButton1, "Add Function");
        }

        public EngineType EngineType
        {
            get { return _engineType; }
            set
            {
                if (_engineType != value)
                {
                    _engineType = value;
                    UpdateEngine();
                }
            }
        }

        public string DefaultExpression { get; set; }

        public string Expression
        {
            get { return txtExpression.Text; }
            set { txtExpression.Text = value; }
        }

        public string Result
        {
            get { return txtResult.Text; }
            set { txtResult.Text = value; }
        }

        public void ApplyTheme()
        {
            if (_dialog == null)
                _dialog = new ExpressionDropDown();

            Explorer.Theme.ApplyThemeToControlTree(_dialog);
            Explorer.Theme.ApplyThemeToObject(_tooltip);
        }

        public void ResetExpression() => Expression = DefaultExpression;

        private void expressionButton1_Click(object sender, EventArgs e)
        {
            if (_dialog == null)
                _dialog = new ExpressionDropDown();

            _dialog.Engine = _engine;
            var x = PointToScreen(txtExpression.Location).X;
            var y = PointToScreen(txtExpression.Location).Y + txtExpression.Height + txtExpression.Padding.Vertical + txtExpression.Margin.Vertical;
            _dialog.OpenLocation = new System.Drawing.Point(x,y);
            if (_dialog.ShowDialog() == DialogResult.OK)
            {
                var text = txtExpression.Text.Substring(0, txtExpression.SelectionStart);
                text += _dialog.Syntax;
                text += txtExpression.Text.Substring(txtExpression.SelectionStart + txtExpression.SelectionLength);
                txtExpression.Text = text;
            }
        }        

        private void UpdateEngine()
        {
            switch (_engineType)
            {
                case EngineType.Excel:
                    _engine = new ExcelEngine();
                    break;
                case EngineType.VBA:
                    _engine = new VBAEngine();
                    break;
                default:
                    break;
            }
        }

        private void c1Button1_Click(object sender, EventArgs e) => Evaluate?.Invoke(this, EventArgs.Empty);

        private void btnReset_Click(object sender, EventArgs e)
        {
            Expression = DefaultExpression;
            Evaluate?.Invoke(this, EventArgs.Empty);
        }
    }

    public enum EngineType
    {
        Excel,
        VBA
    }
}
