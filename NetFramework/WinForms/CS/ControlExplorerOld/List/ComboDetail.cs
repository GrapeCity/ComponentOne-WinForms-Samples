using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1List;

namespace ControlExplorer.List
{
    public partial class ComboDetail : C1DemoForm
    {
        public ComboDetail()
        {
            InitializeComponent();  
        }

        private void ComboDetail_Load(object sender, EventArgs e)
        {
            c1Combo1.DataSource = DemoDataSource("Composer");
            c1Combo1.DisplayMember = "Last";
            c1Combo1.ValueMember = "Last";
            c1Combo1.Text = "Bach";
            
            //don't need these columns
            c1Combo1.Splits[0].DisplayColumns[3].Visible = false;
            c1Combo1.Splits[0].DisplayColumns[4].Visible = false; 

            c1Combo1_Change(null, EventArgs.Empty);

            //add demo properties
            AddPropertyHeader("C1Combo Properties");
            AddProperty("AutoCompletion", c1Combo1);
            AddProperty("AutoDropDown", c1Combo1);
            AddProperty("MaxDropDownItems", c1Combo1);
        }

        private void c1Combo1_Change(object sender, EventArgs e)
        {
            c1List1.DataSource = DemoDataSource("SELECT * FROM Opus WHERE Last='" + c1Combo1.Text + "'", true);
        }
    }
}
