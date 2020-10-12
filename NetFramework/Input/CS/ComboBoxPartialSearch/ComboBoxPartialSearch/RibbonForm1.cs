using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1Input;

namespace ComboBoxPartialSearch
{
    public partial class RibbonForm1 : C1.Win.C1Ribbon.C1RibbonForm
    {
        List<string> Addresses = new List<string>()
        {
            "boss@mycompany.com",
            "info@mycompany.com",
            "hr@mail.com",
            "sergey.brin@google.com",
            "devil@hell.org",
            "sun@shining.com",
            "boss2@mycompany.com",
            "info2@mycompany.com",
            "hr2@mail.com",
            "sergey.brin2@google.com",
            "devil2@hell.org",
            "sun2@shining.com",
            "boss3@mycompany.com",
            "info3@mycompany.com",
            "hr3@mail.com",
            "sergey.brin3@google.com",
            "devil3@hell.org",
            "sun3@shining.com",
            "boss3@mycompany.com",
            "info3@mycompany.com",
            "hr3@mail.com",
            "sergey.brin3@google.com",
            "devil3@hell.org",
            "sun3@shining.com",
        };

        public RibbonForm1()
        {
            InitializeComponent();
            c1ComboBox1.Items.AddRange(Addresses);
            c1ComboBox2.Items.AddRange(Addresses);
            c1ComboBox1.AutoCompleteCustomSource.AddRange(Addresses.ToArray());
        }

        private void comboBox1_DragOver(object sender, DragEventArgs e)
        {

        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("comboBox1_DropDown");
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("comboBox1_KeyDown");
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("comboBox1_KeyPress");
        }

        private void comboBox1_KeyUp(object sender, KeyEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("comboBox1_KeyUp");
        }
    }
}
