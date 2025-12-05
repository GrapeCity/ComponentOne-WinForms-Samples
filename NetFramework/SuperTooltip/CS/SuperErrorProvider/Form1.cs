using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using C1.Win.SuperTooltip;

namespace SuperErrorProvider
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ds.DataSetName = "AuthorsDataSet";
            ds.ReadXml("authors.xml", System.Data.XmlReadMode.Auto);
            bs.DataMember = "authors";

            txtFirstName.DataBindings.Add(new Binding("Text", bs, "FirstName"));
            txtLastName.DataBindings.Add(new Binding("Text", bs, "LastName"));
            txtPhone.DataBindings.Add(new Binding("Text", bs, "Phone"));
            txtAddress.DataBindings.Add(new Binding("Text", bs, "Address"));
            txtCity.DataBindings.Add(new Binding("Text", bs, "City"));
            txtState.DataBindings.Add(new Binding("Text", bs, "State"));
            txtZip.DataBindings.Add(new Binding("Text", bs, "Zip"));

            cbField.SelectedIndex = 2;
        }

        private void btnSetError_Click(object sender, EventArgs e)
        {
            string columnName = cbField.Text;
            if (!string.IsNullOrEmpty(columnName))
            {
                ((DataRowView)bs.Current).Row.SetColumnError(columnName,
                    "<table><tr>" +
                      "<td><parm><img src='res://Cancel2.png'></parm></td>" +
                      "<td><b><parm>Wrong value</parm></b></td>" +
                    "</tr></table>" +
                    "<parm><hr noshade size=1 style='margin:2' color=darker></parm>" +
                    "<div style='margin:1 12'><parm>" +
                      "This field has an associated error." +
                    "</parm></div>" +
                    "<parm></parm>" +
                    "<table><tr>" +
                      "<td><parm></parm></td>" +
                      "<td><b><parm></parm></b></td>" +
                    "</tr></table>");
            }
        }

        private void btnClearError_Click(object sender, EventArgs e)
        {
            string columnName = cbField.Text;
            if (!string.IsNullOrEmpty(columnName))
            {
                ((DataRowView)bs.Current).Row.SetColumnError(columnName, "");
            }
        }

        private void epComplete_IconClick(object sender, IconClickEventArgs e)
        {
            TextBox tb = (TextBox)e.Control;
            MessageBox.Show("\"" + tb.Text + "\" is the correct value.", "Information");
        }

        private void SetError1(C1SuperErrorProvider ep, TextBox tb)
        {
            ep.SetError(tb,
                "<table><tr>" +
                "  <td><parm><img src='res://Info2.png'></parm></td>" +
                "  <td><b><parm></parm></b></td>" +
                "</tr></table>" +
                "<parm></parm>" +
                "<div style='margin:1 12'><parm>" +
                "  This is a required field." +
                "</parm></div>" +
                "<parm></parm>" +
                "<table><tr>" +
                "  <td><parm></parm></td>" +
                "  <td><b><parm></parm></b></td>" +
                "</tr></table>");
        }

        private void SetError2(C1SuperErrorProvider ep, TextBox tb)
        {
            ep.SetError(tb, "<b>Too short or too long string.</b><br>The string must consist of 5 - 10 characters.");
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            string s = tb.Text;
            if (s.Length == 0)
            {
                epComplete.SetError(tb, "");
                epWarning.SetError(tb, "");
                SetError1(epInfo, tb);
            }
            else
            {
                epInfo.SetError(tb, "");
                if (s.Length < 5 || s.Length > 10)
                {
                    epComplete.SetError(tb, "");
                    SetError2(epWarning, tb);
                }
                else
                {
                    epWarning.SetError(tb, "");
                    epComplete.SetError(tb, "Click for more info");
                }
            }
        }

        private void textBox_Enter(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            string s = tb.Text;
            if (s.Length > 0 && (s.Length < 5 || s.Length > 10))
            {
                epError.SetError(tb, "");
                SetError2(epWarning, tb);
            }
        }

        private void textBox_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            string s = tb.Text;
            if (s.Length > 0 && (s.Length < 5 || s.Length > 10))
            {
                epWarning.SetError(tb, "");
                SetError2(epError, tb);
            }
        }
    }
}