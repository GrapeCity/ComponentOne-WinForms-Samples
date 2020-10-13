using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1Input;

namespace InputButtons
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            c1DateEdit1.Value = DateTime.Now;
            c1NumericEdit1.Value = 10;
            c1ComboBox1.SelectedIndex = 0;
        }


        private void chkButtons_Click(object sender, EventArgs e)
        {
            SetVisibleButtons(c1DateEdit1);
            SetVisibleButtons(c1NumericEdit1);
            SetVisibleButtons(c1ComboBox1);
        }

        void SetVisibleButtons(C1DropDownControl dropDownControl)
        {
            var buttons = DropDownControlButtonFlags.None;
            if (chkUpDown.Checked)
                buttons = buttons | DropDownControlButtonFlags.UpDown;
            if (chkCombo.Checked)
                buttons = buttons | DropDownControlButtonFlags.DropDown;
            if (chkModal.Checked)
                buttons = buttons | DropDownControlButtonFlags.Modal;
            if (chkCustom.Checked)
                buttons = buttons | DropDownControlButtonFlags.Custom;

            dropDownControl.VisibleButtons = buttons;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            c1ComboBox1.OpenDropDown();
            btnOpen.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            c1ComboBox1.CloseDropDown();
        }

        private void c1ComboBox1_DropDownClosed(object sender, DropDownClosedEventArgs e)
        {
            btnOpen.Enabled = true;
        }

        private void btnSpinUp_Click(object sender, EventArgs e)
        {
            c1DateEdit1.SpinUp();
            c1NumericEdit1.SpinUp();
            c1ComboBox1.SpinUp();
        }

        private void btnSpinDown_Click(object sender, EventArgs e)
        {
            c1DateEdit1.SpinDown();
            c1NumericEdit1.SpinDown();
            c1ComboBox1.SpinDown();
        }

        private void cmbUpDownButtonAlign_SelectedIndexChanged(object sender, EventArgs e)
        {
            var UpDownButtonAlignment = ((UpDownButtonAlignment)Enum.Parse(typeof(UpDownButtonAlignment), (string)cmbUpDownButtonAlign.Items[cmbUpDownButtonAlign.SelectedIndex]));
            c1DateEdit1.UpDownButtonAlignment = UpDownButtonAlignment;
            c1NumericEdit1.UpDownButtonAlignment = UpDownButtonAlignment;
            c1ComboBox1.UpDownButtonAlignment = UpDownButtonAlignment;
        }

        private void cbxRTL_Click(object sender, EventArgs e)
        {
            panelInput.RightToLeft = cbxRTL.Checked ? RightToLeft.Yes : RightToLeft.No;

        }

        private void c1ComboBox2_SelectedItemChanged(object sender, EventArgs e)
        {
            c1ThemeController1.Theme = c1ComboBox2.SelectedItem.ToString();
        }
    }
}
