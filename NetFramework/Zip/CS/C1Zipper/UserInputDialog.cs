using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace C1Zipper
{
    public partial class UserInputDialog : Form
    {
        public UserInputDialog()
        {
            InitializeComponent();
        }

        // show dialog and return value to the user
        public string GetString(string caption)
        {
            return GetString(caption, string.Empty);
        }
        public string GetString(string caption, string defValue)
        {
            // initialize dialog
            Text = caption;
            _txtUser.Text = defValue;
            _txtUser.SelectAll();

            // show dialog
            var dr = ShowDialog();

            // return user input or null if user cancelled
            return dr == DialogResult.OK 
                ? _txtUser.Text 
                : null;
        }
    }
}
