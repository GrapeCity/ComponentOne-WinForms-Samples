using System;
using System.Windows.Forms;

namespace SeparateControls
{
    public partial class DropDownExpression : UserControl
    {
        private DropDownPanel _dialog;

        public DropDownExpression()
        {
            InitializeComponent();
            AttachEvents();
        }

        #region Model
        public event EventHandler ExpressionChanged;
        private void OnExpressionChanged(object sender, EventArgs e)
        {
            ExpressionChanged?.Invoke(this, EventArgs.Empty);
        }
        // returns result of expression
        public object GetResult()
        {
            if (c1ExpressionEditor1.IsValid)
                return c1ExpressionEditor1.Evaluate();
            return c1ExpressionEditor1.GetErrors()[0].Message;
        }

        public object DataSource
        {
            get { return c1ExpressionEditor1.DataSource; }
            set { c1ExpressionEditor1.DataSource = value; }
        }
        #endregion

        #region Private
        private void AttachEvents()
        {
            c1ExpressionEditor1.ExpressionChanged += OnExpressionChanged;
        }

        private void DetachEvents()
        {
            c1ExpressionEditor1.ExpressionChanged -= OnExpressionChanged;
        }
        // opens ExpressionEditorPanel dialog
        private void OpenDialog()
        {
            if (_dialog == null)
                _dialog = new DropDownPanel(this, c1ExpressionEditor1);
            _dialog.ShowDialog();
        }

        private void c1Button1_Click(object sender, EventArgs e)
        {
            OpenDialog();
        }
        #endregion
    }
}
