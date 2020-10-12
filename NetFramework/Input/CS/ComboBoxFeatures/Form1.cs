using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1Input;

namespace ComboBoxFeatures
{
    public enum VisualStyle
    { 
        System,
        Office2007Blue,
        Office2007Silver,
        Office2007Black,
        Office2010Blue,
        Office2010Silver,
        Office2010Black
    }

    public partial class Form1 : Form
    {
        VisualStyle _visualStyle = VisualStyle.System;
        public Form1()
        {
            InitializeComponent();
            // parameters:
            // 1 - type of Enum
            // 2 - blank
            // 3 - initial selected index
            c1ComboBoxVisualStyle.SetItemsDataSource(typeof(VisualStyle), "", 0);

            cbxDropDownStyle.SetItemsDataSource(typeof(DropDownStyle), "", 0);

            cbxAutoOpen.SetItemsDataSource(new bool[] { false, true }, "", 0);

            AddCountries();
        }


        public VisualStyle VisualStyle
        {
            get { return _visualStyle; }
            set {
                if (value != _visualStyle)
                {
                    _visualStyle = value;
                    OnVisualStyleChanged();
                }
            }
        }

        protected virtual void OnVisualStyleChanged()
        {
            if (VisualStyleChanged != null)
                VisualStyleChanged(this, new EventArgs());
        }
        
        public event EventHandler VisualStyleChanged;

        private void c1ComboBoxVisualStyle_SelectedItemChanged(object sender, EventArgs e)
        {
            VisualStyle = (VisualStyle)c1ComboBoxVisualStyle.SelectedItem;
        }

        private void cbxAutoOpen_SelectedItemChanged(object sender, EventArgs e)
        {
            c1ComboBoxMain.AutoOpen = (bool)cbxAutoOpen.SelectedItem;
        }

        private void cbxDropDownStyle_SelectedItemChanged(object sender, EventArgs e)
        {
            c1ComboBoxMain.DropDownStyle = (DropDownStyle)cbxDropDownStyle.SelectedItem;
        }

        private void cbxBoundTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbxBoundTo.SelectedIndex)
            {
                case 0: // Design time
                    c1ComboBoxMain.SetItemsDataSource(null, "", 0);
                    c1ComboBoxMain.TextDetached = false;
                    break;
                case 1: // Enum
                    c1ComboBoxMain.SetItemsDataSource(typeof(DialogResult), "", 0);
                    c1ComboBoxMain.TextDetached = false;
                    break;
                case 2: //Array
                    c1ComboBoxMain.ItemsDisplayMember = "";
                    c1ComboBoxMain.ItemsValueMember = "";
                    c1ComboBoxMain.ItemsDataSource = new object[] { "First", "Second", "Third" };
                    c1ComboBoxMain.SelectedIndex = 0;
                    c1ComboBoxMain.TextDetached = false;
                    // or
                    //c1ComboBoxMain.SetItemsDataSource(new object[] { "First", "Second", "Third" }, "", 0);
                    break;
                case 3: //Binding source
                    c1ComboBoxMain.TextDetached = true;
                    c1ComboBoxMain.ItemsDataSource = countryBindingSource;
                    c1ComboBoxMain.ItemsDisplayMember = "Name";
                    c1ComboBoxMain.ItemsValueMember = "Code";
                    c1ComboBoxMain.SelectedIndex = 0;
                    // or
                    //c1ComboBoxMain.SetItemsDataSource(new object[] { "First", "Second", "Third" }, "", 0);
                    break;
            }
        }

        private void cbxDropDownSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbxDropDownSize.SelectedIndex)
            {
                case 0: // Auto
                    c1ComboBoxMain.DropDownForm.MinimumSize = new Size();
                    c1ComboBoxMain.DropDownForm.MaximumSize = new Size();
                    break;
                case 1: // Small
                    c1ComboBoxMain.DropDownForm.MinimumSize = new Size();
                    c1ComboBoxMain.DropDownForm.MaximumSize = new Size(c1ComboBoxMain.Width, 100);
                    break;
                case 2: //Large
                    c1ComboBoxMain.DropDownForm.MinimumSize = new Size(c1ComboBoxMain.Width * 2, 100);
                    c1ComboBoxMain.DropDownForm.MaximumSize = new Size();
                    // or
                    //c1ComboBoxMain.SetItemsDataSource(new object[] { "First", "Second", "Third" }, "", 0);
                    break;
            }
        }

        void AddCountries()
        {
            countryBindingSource.Add(new Country(1, "Canada"));
            countryBindingSource.Add(new Country(2, "USA"));
            countryBindingSource.Add(new Country(3, "Mexico"));
            countryBindingSource.Add(new Country(4, "India"));
            countryBindingSource.Add(new Country(5, "Russia"));
        }

        private void c1ComboBoxMain_SelectedItemChanged(object sender, EventArgs e)
        {
            lblSelectedItem.Text = string.Format("{0} ({1})", c1ComboBoxMain.SelectedItem, c1ComboBoxMain.SelectedItem == null ? "null" : c1ComboBoxMain.SelectedItem.GetType().Name);
        }

        private void c1ComboBoxMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSelectedIndex.Text = string.Format("{0}", c1ComboBoxMain.SelectedIndex);
        }

        private void c1ComboBoxMain_ValueChanged(object sender, EventArgs e)
        {
            lblValue.Text = string.Format("{0} ({1})", c1ComboBoxMain.Value, c1ComboBoxMain.Value == null ? "null" : c1ComboBoxMain.Value.GetType().Name);
        }
    }
}
