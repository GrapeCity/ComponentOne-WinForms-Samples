using System;
using System.Windows.Forms;


namespace ExpressionEditorExplorer.Samples
{
    using C1.Win.ExpressionEditor;
    public class DataGridViewEE : DataGridView, IDisposable
    {
        private ExpressionEditorCollection _editors; // collection of expression editors

        public DataGridViewEE() : base()
        {
            _editors = new ExpressionEditorCollection();
        }

        #region ** Model
        // updates the expression for the editor associated with the specified column
        public void UpdateExpression(string columnName, string expression)
        {
            // if the collection does not contain editor associated with the specified column
            if (!_editors.Contains(columnName))
            {
                // add a new column if necessary
                if (!Columns.Contains(columnName))
                    Columns.Add(columnName, columnName);                
            }
            // updates the expression editor, or adds a new editor
            _editors.Update(columnName, expression);
            Evaluate(columnName);
            Invalidate();
        }
        // evaluates expression for all rows
        public void Evaluate(string columnName)
        {            
            for (int i = 0; i < Rows.Count; i++)
                Evaluate(i, columnName);
        }
        public string GetExpression(string columnName)
        {
            return _editors.Contains(columnName) ? _editors[columnName].Expression : null;
        }
        #endregion

        #region ** Override
        protected override void OnCellValueChanged(DataGridViewCellEventArgs e)
        {
            if (!_editors.Contains(Columns[e.ColumnIndex].Name))
            {
                Evaluate(e.RowIndex);
                Invalidate();
            }
            base.OnCellValueChanged(e);
        }
        protected override void OnSorted(EventArgs e)
        {
            Evaluate();
        }
        protected override void OnDataSourceChanged(EventArgs e)
        {
            // update the data source for editors
            _editors.DataSource = DataSource;
            // evaluate expressions with new data        
            Evaluate();
            base.OnDataSourceChanged(e);
        }
        #endregion

        #region ** Private
        // evaluates all expressions
        private void Evaluate()
        {            
            for (int i = 0; i < Rows.Count; i++)
                Evaluate(i);
        }
        // evaluates all expressions for specified row    
        private void Evaluate(int row)
        {
            // item context - data for specified row
            var context = Rows[row].DataBoundItem;            
            if (context != null)
            {
                // set item context
                _editors.ItemContext = context;
                // for all editors
                foreach (var editor in _editors)
                {
                    object value = null;
                    if (editor.Value.TryEvaluate(out value))
                        base[editor.Key, row].Value = value;
                }
            }
        }
        // evaluates expression for specified column and row
        private void Evaluate(int row, string columnName)
        {
            // item context - data for specified row
            var context = Rows[row].DataBoundItem;
            if (context != null)
            {
                // set item context
                _editors.ItemContext = context;
                object value = null;
                if (_editors[columnName].TryEvaluate(out value))
                    base[columnName, row].Value = value;
            } 
        }
        #endregion

        #region ** IDisposable
        public new void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected override void Dispose(bool disposing)
        {
            if(disposing)
                _editors?.Dispose();
            base.Dispose(disposing);
        }
        #endregion
    }
}
