using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1InputPanel;

namespace ControlExplorer.InputPanel
{
    public partial class QueryBuilder : C1DemoForm
    {
        public QueryBuilder()
        {
            InitializeComponent();
        }

        private void QueryBuilder_Load(object sender, EventArgs e)
        {
            //add initial row without Add/Or combo
            AddPropertyBox();
            AddOperatorBox();
            AddValueBox("Tofu");
            c1InputPanel1.Items[c1InputPanel1.Items.Count - 3].Break = BreakType.Row;

            //add another query row
            AddAndOrBox();
            AddPropertyBox();
            AddOperatorBox();
            AddValueBox("");
            AddRemoveButton();

            //initialize data grid and sql textbox
            txtSqlText.Text = "SELECT * FROM Products";
            c1FlexGrid1.DataSource = DemoDataSource(txtSqlText.Text, true);
            
        }

        //adds an InputComboBox to InputPanel with And/Or options
        private void AddAndOrBox()
        {
            InputComboBox cb = new InputComboBox();
            cb.Items.Add(new InputOption("And"));
            cb.Items.Add(new InputOption("Or"));
            cb.SelectedIndex = 0;
            cb.Width = 50;
            cb.DropDownStyle = InputComboBoxStyle.DropDownList;
            cb.Break = BreakType.None;
            c1InputPanel1.Items.Insert(c1InputPanel1.Items.Count - 2, cb); 
        }

        //adds an InputComboBox to InputPanel with grid fields
        private void AddPropertyBox()
        {
            InputComboBox cb = new InputComboBox();
            AddInputOption(cb, "ProductName", "tstring");
            AddInputOption(cb, "SupplierID", "tnumber");
            AddInputOption(cb, "CategoryID", "tnumber");
            AddInputOption(cb, "QuantityPerUnit", "tstring");
            AddInputOption(cb, "UnitPrice", "tnumber");
            AddInputOption(cb, "UnitsInStock", "tnumber");
            AddInputOption(cb, "UnitsOnOrder", "tnumber");
            AddInputOption(cb, "ReorderLevel", "tnumber");
            AddInputOption(cb, "Discontinued", "tbool");
            cb.SelectedIndex = 0;
            cb.DropDownStyle = InputComboBoxStyle.DropDownList;
            cb.Break = BreakType.None;
            c1InputPanel1.Items.Insert(c1InputPanel1.Items.Count - 2, cb);   
        }

        //adds an InputComboBox to InputPanel with operator options
        private void AddOperatorBox()
        {
            InputComboBox cb = new InputComboBox();
            AddInputOption(cb, "Contains", "LIKE");
            AddInputOption(cb, "Equals", "=");  
            AddInputOption(cb, "Less Than", "<");
            AddInputOption(cb, "Greater Than", ">");
            cb.SelectedIndex = 0;
            cb.DropDownStyle = InputComboBoxStyle.DropDownList;
            cb.Break = BreakType.None;
            c1InputPanel1.Items.Insert(c1InputPanel1.Items.Count - 2, cb);
            
        }

        private void AddInputOption(InputComboBox combo, string text, string tag)
        {
            InputOption io = new InputOption();
            io.Text = text;
            io.Tag = tag;
            combo.Items.Add(io);
        }

        //adds InputTextBox to InputPanel
        private void AddValueBox(string value)
        {
            InputTextBox tb = new InputTextBox();
            tb.Text = value;
            tb.Break = BreakType.None;
            tb.Validating += new CancelEventHandler(tb_Validating);
            c1InputPanel1.Items.Insert(c1InputPanel1.Items.Count - 2, tb);
            tb.Focus();
        }

        //adds Remove button to InputPanel for removing a query row
        private void AddRemoveButton()
        {
            InputButton btn = new InputButton();
            btn.Image = imageList1.Images[0];
            btn.ToolTipText = "Remove";
            btn.Break = BreakType.Row;
            btn.Click += new EventHandler(btn_Click);
            c1InputPanel1.Items.Insert(c1InputPanel1.Items.Count - 2, btn);
        }

        //this event fires when a remove button is clicked
        //will remove an entire row of InputComponents from InputPanel
        void btn_Click(object sender, EventArgs e)
        {
            InputButton btn = (InputButton)sender;
            int index = c1InputPanel1.Items.IndexOf(btn);
            c1InputPanel1.Items.RemoveAt(index);
            c1InputPanel1.Items.RemoveAt(index -1);
            c1InputPanel1.Items.RemoveAt(index - 2);
            c1InputPanel1.Items.RemoveAt(index - 3);
            c1InputPanel1.Items.RemoveAt(index - 4);
        }

        //validation event prevents form activity when value text box is null
        void tb_Validating(object sender, CancelEventArgs e)
        {
            InputTextBox tb = (InputTextBox)sender;
            if (tb.Text.Length < 1)
            {
                tb.ErrorText = "Must Enter Value";
                //e.Cancel = true;
            }
            else
            {
                tb.ErrorText = string.Empty;
                //e.Cancel = false;
            }
        }

        //adds new query row
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            AddAndOrBox();
            AddPropertyBox();
            AddOperatorBox();
            AddValueBox("");
            AddRemoveButton();
        }

        //submit Query loops through all items in InputPanel and [roughly] builds a query string
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            StringBuilder sql = new StringBuilder("SELECT * FROM Products WHERE ");
            string type = "tstring";
            for (int i = c1InputPanel1.Items.IndexOf(hdrQueryBuilder); i < c1InputPanel1.Items.IndexOf(hdrSqlText); i++)
            {
                InputComponent ic = c1InputPanel1.Items[i];
                if (ic.GetType() == typeof(InputComboBox))
                {
                    //handle combo box
                    InputComboBox cb = (InputComboBox)ic;
                    //append ComboBox text if Property, Append ComboBox Tag if Operator
                    sql.Append(cb.SelectedOption.Tag != null && !cb.SelectedOption.Tag.ToString().StartsWith("t") ? cb.SelectedOption.Tag.ToString() + " " : ic.Text + " ");
                    //save type of Property ComboBox for later
                    if (cb.SelectedOption.Tag != null)
                    {
                        if (cb.SelectedOption.Tag.ToString().StartsWith("t"))
                            type = cb.SelectedOption.Tag.ToString();
                        if (cb.SelectedOption.Tag.ToString().Equals("LIKE"))
                            type = type + "_like";
                    }
                }
                else if (ic.GetType() == typeof(InputTextBox))
                {
                    //handle value text box
                    if (type.Equals("tstring"))
                    {
                        sql.Append("'" + ic.Text + "' ");
                    }
                    else if (type.Equals("tstring_like"))
                    {
                        sql.Append("'%" + ic.Text + "%' ");
                    }
                    else if (type.Equals("tnumber"))
                    {
                        sql.Append(ic.Text + " ");
                    }
                    else if (type.Equals("tbool"))
                    {
                        if (ic.Text.ToLower().Equals("true"))
                            sql.Append("true ");
                        else if (ic.Text.ToLower().Equals("false"))
                            sql.Append("false ");
                    }
                }
            }
            txtSqlText.Text = sql.ToString();
            try
            {
                c1FlexGrid1.DataSource = DemoDataSource(sql.ToString(), true);
                txtSqlText.ErrorText = string.Empty;
            }
            catch(Exception ex)
            {
                //show error on SqlTextBox
                txtSqlText.ErrorText = ex.Message;
            }
        }
    }
}
