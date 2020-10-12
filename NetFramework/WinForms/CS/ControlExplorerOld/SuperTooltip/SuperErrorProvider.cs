using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1SuperTooltip;

namespace ControlExplorer.SuperTooltip
{
    public partial class SuperErrorProvider : C1DemoForm
    {
        public SuperErrorProvider()
        {
            InitializeComponent();
        }

        private void SuperErrorProvider_Load(object sender, EventArgs e)
        {
            //initialize information tips
            epInfo.SetError(tbName, GetInfoMessage("This is a required field", "Must be at least 4 characters"));
            epInfo.SetError(nbAge, GetInfoMessage("This is a required field", "Must be at least 18 years old"));
            epInfo.SetError(tbEmail, GetInfoMessage("This is a required field", "Must be a valid email address"));
            epError.SetError(dateEnd, GetErrorMessage("End date must be greater than start date", "Select a date after " + dateStart.Value.ToShortDateString()));
            epInfo.SetError(tbUsername, GetInfoMessage("This is a required field", "Must contain 7-15 characters"));
            epInfo.SetError(tbPassword, GetInfoMessage("This is a required field", "Must contain 7-15 characters"));
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            string s = tb.Text;
            if(s.Length == 0)
            {
                //clear error tip
                epError.SetError(tb, "");
                //set info tip
                epInfo.SetError(tb, GetInfoMessage("This is a required field", "Must be at least 4 characters"));
            }
            else if (s.Length < 4)
            {
                //clear info tip
                epInfo.SetError(tb, "");
                //set error tip
                epError.SetError(tb, GetErrorMessage("Must be at least 4 characters", "Example: John Doe"));
            }
            else
            {
                //clear error tip
                epError.SetError(tb, "");
            }
        }

        private void nbAge_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown nb = (NumericUpDown)sender;
            decimal n = nb.Value;
            if (n < 18)
            {
                //clear info tip
                epInfo.SetError(nb, "");
                //set error tip
                epError.SetError(nb, GetErrorMessage("Age must be greater than 17", "Note: Minors not allowed to register"));
            }
            else
            {
                //clear error tip
                epError.SetError(nb, "");
            }
        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            string s = tb.Text;
            if (s.Length == 0)
            {
                //clear error tip
                epError.SetError(tb, "");
                //set info tip
                epInfo.SetError(tbEmail, GetInfoMessage("This is a required field", "Must be a valid email address"));
            }
            else if (!s.Contains('@') || !s.Contains('.'))
            {
                //clear info tip
                epInfo.SetError(tb, "");
                //set error tip
                epError.SetError(tb, GetErrorMessage("Email address must be valid", "Example: johndoe@hotmail.com"));
            }
            else
            {
                //clear error tip
                epError.SetError(tb, "");
            }
        }

        private void date_ValueChanged(object sender, EventArgs e)
        {
            if (dateStart.Value >= dateEnd.Value)
            {
                //set error tip
                epError.SetError(dateEnd, GetErrorMessage("End date must be greater than start date", "Select a date after " + dateStart.Value.ToShortDateString()));
            }
            else
            {
                //clear error tip
                epError.SetError(dateEnd, "");
            }
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            MaskedTextBox tb = (MaskedTextBox)sender;
            string s = tb.Text;
            if (s.Length == 0)
            {
                epComplete.SetError(tb, "");
                epWarning.SetError(tb, "");
                epInfo.SetError(tb, GetInfoMessage("This is a required field", "Must contain 7-15 characters"));
            }
            else
            {
                epInfo.SetError(tb, "");
                if (s.Length < 7 || s.Length > 15)
                {
                    epComplete.SetError(tb, "");
                    epWarning.SetError(tb, GetWarningMessage("Must contain 7-15 characters", "Your entry is either too short or too long"));
                }
                else
                {
                    //clear warning tip
                    epWarning.SetError(tb, "");
                    //set complete tip
                    epComplete.SetError(tb, "Click for more info");
                }
            }
        }

        private void epComplete_IconClick(object sender, IconClickEventArgs e)
        {
            MaskedTextBox tb = (MaskedTextBox)e.Control;
            MessageBox.Show("\"" + tb.Text + "\" is the correct value.", "Information");
        }

        private string GetInfoMessage(string text, string subtext)
        {
            return "<table><tr><td><parm><img src='res://Info1.png'></parm></td>" +
            "<td><b><parm>Information</parm></b></td></tr></table>" +
            "<parm><hr noshade size=1 style='margin:2' color=darker></parm>" +
            "<div style='margin:1 12'><parm>" + text +
            "</parm></div><parm><hr noshade size=1 style='margin:2' color=darker></parm>" +
            "<table><tr><td><parm></parm></td><td><b><parm>" + subtext +
            "</parm></b></td></tr></table>";
        }

        private string GetWarningMessage(string text, string subtext)
        {
            return "<table><tr><td><parm><img src='res://Warning.png'></parm></td>" +
            "<td><b><parm>Warning</parm></b></td></tr></table>" +
            "<parm><hr noshade size=1 style='margin:2' color=darker></parm>" +
            "<div style='margin:1 12'><parm>" + text +
            "</parm></div><parm><hr noshade size=1 style='margin:2' color=darker></parm>" +
            "<table><tr><td><parm></parm></td><td><b><parm>" + subtext +
            "</parm></b></td></tr></table>";
        }

        private string GetErrorMessage(string text, string subtext)
        {
            return "<table><tr><td><parm><img src='res://Error.png'></parm></td>" +
            "<td><b><parm>Error</parm></b></td></tr></table>" +
            "<parm><hr noshade size=1 style='margin:2' color=darker></parm>" +
            "<div style='margin:1 12'><parm>" + text +
            "</parm></div><parm><hr noshade size=1 style='margin:2' color=darker></parm>" +
            "<table><tr><td><parm></parm></td><td><b><parm>" + subtext +
            "</parm></b></td></tr></table>";
        }

        

        private void SetError(C1SuperErrorProvider ep, Control c, string ms)
        {
            ep.SetError(c,
                "<table><tr>" +
                "  <td><parm><img src='res://Info2.png'></parm></td>" +
                "  <td><b><parm></parm></b></td>" +
                "</tr></table>" +
                "<parm></parm>" +
                "<div style='margin:1 12'><parm>" +
                "  " + ms +
                "</parm></div>" +
                "<parm></parm>" +
                "<table><tr>" +
                "  <td><parm></parm></td>" +
                "  <td><b><parm></parm></b></td>" +
                "</tr></table>");
        }





        









  


    }
}
