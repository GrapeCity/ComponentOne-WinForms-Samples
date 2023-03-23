using System;
using System.Windows.Forms;
using C1.Win.TreeView;
using C1.Framework;
using C1.Win.ExpressionEditor;

namespace TreeViewIntegration
{
    public partial class Form1 : Form
    {
        // index of the expression column
        private static int c_totalPriceIdx = 5;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'c1NWindDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.c1NWindDataSet.Products);
            // TODO: This line of code loads data into the 'c1NWindDataSet.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.c1NWindDataSet.Categories);

            c1TreeView1.BindingInfo.DataSource = null;
            c1TreeView1.BindingInfo.DataSource = c1NWindDataSetBindingSource;

            // setting the expression info
            // set empty expression for first node level and "[UnitPrice]*([UnitsInStock]+[UnitsOnOrder])" expression for second node level.
            c1TreeView1.Columns[c_totalPriceIdx].ExpressionInfo.Expressions = new string[] { "", "[UnitPrice]*([UnitsInStock]+[UnitsOnOrder])" };
            // allow to edit in run-time only second node level expression
            c1TreeView1.Columns[c_totalPriceIdx].ExpressionInfo.AllowEdit = new bool[] { false, true };
            // deny add new expression in run-time
            c1TreeView1.Columns[c_totalPriceIdx].ExpressionInfo.AllowAddNew = false;
            // deny delete expression in run-time
            c1TreeView1.Columns[c_totalPriceIdx].ExpressionInfo.AllowDelete = false;
            // set DisplayFormat
            c1TreeView1.Columns[c_totalPriceIdx].DisplayFormat = "##.##$";
            // set custom presenter for expression column to customize appearance
            c1TreeView1.Columns[c_totalPriceIdx].CustomContentPresenter = new TotalPricePresenter();
            

            // subscribe to events to update the sum for categories
            c1TreeView1.Columns[c_totalPriceIdx].ExpressionChanged += Form1_ExpressionChanged;
            c1TreeView1.CellEndEdit += C1TreeView1_CellEndEdit;
        }

        private void Form1_ExpressionChanged(object sender, EventArgs e)
        {
            foreach (var node in c1TreeView1.Nodes)
                RecalcCategory(node);
        }

        private void C1TreeView1_CellEndEdit(object sender, C1TreeViewNodeCellEventArgs e)
        {
            // update only if value in second node level is changed to prevent the loop
            if (e.Node.Level != 0)
                RecalcCategory(e.Node.ParentCollection.Parent);
        }

        // update the sum for category node (first node level)
        private void RecalcCategory(C1TreeNode node)
        {
            if (node.Level == 0)
                node.SetValue(null, c_totalPriceIdx);
        }

        public class TotalPricePresenter : CustomContentPresenter
        {
            private float _value;
            private string _displayFormat;
            private TextElement _text;

            public TotalPricePresenter()
            {
                _text = new TextElement();
                _text.Style = new Style();
                Child = _text;
            }
            
            public override string ToolTipText
            {
                get { return _text.Text; }
            }

            public override void SetFormat(string format)
            {
                _displayFormat = format;
            }
            
            public override void SetStyle(TreeNodeCellStyles styles)
            {
                // let's highlight the small values in red
                float min = Node.Level == 0? 7000f: 500f;
                // let's highlight the large values in Green
                float max = Node.Level == 0 ? 14000f : 1000f;
                System.Drawing.Color c;
                if (_value < min && _value >= 0)
                    c = System.Drawing.Color.Red;
                else if (_value > max)
                    c = System.Drawing.Color.Green;
                else
                    c = Node.Selected ? styles.Selected.ForeColor : styles.Default.ForeColor;
                _text.Style.ForeColor = c; 
            }

            // calculate sum for category
            private float CalcSum()
            {
                float sum = 0;
                foreach (var node in Node.Nodes)
                {
                    var res = node.GetValue(c_totalPriceIdx);
                    if (res is string)
                        continue;
                    try
                    {
                        sum += Convert.ToSingle(res);
                    }
                    catch (Exception)
                    {
                    }
                }
                return sum;
            }

            public override void SetValue(object value)
            {                
                if (Node.Level == 0)
                {
                    // display sum in cell for first node level (category)               
                    _value = CalcSum();                    
                    _text.Text = _value.ToString(_displayFormat);
                }
                else
                {
                    // display price in cell for second node level (products)
                    if (value == null)
                        return;
                    if (value is string)
                    {
                        _value = -1;
                        _text.Text = value.ToString();
                    }
                    else
                    {
                        try
                        {
                            _value = Convert.ToSingle(value);
                            _text.Text = _value.ToString(_displayFormat);
                        }
                        catch (Exception)
                        {
                            _value = -1;
                            _text.Text = value.ToString();
                        }
                    }
                }
            }
        }
    }
}
