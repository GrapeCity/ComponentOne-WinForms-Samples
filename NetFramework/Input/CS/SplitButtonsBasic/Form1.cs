using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SplitButtonsBasic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            c1Editor1.LoadRtf("sample.rtf");
            c1SplitButton1.DefaultItem = c1SplitButton1.Items[0];
        }

        private void c1SplitButton1_DropDownItemClicked(object sender, C1.Win.C1Input.DropDownItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text != "Save")
            {
                SaveFileDialog s1 = new SaveFileDialog();
                s1.AddExtension = false;
                s1.Filter = "Rtf files (*.rtf)|*.rtf|All files (*.*)|*.*";
                s1.FileName = "Test.rtf";
                DialogResult r1 = s1.ShowDialog();
                if (r1 == DialogResult.OK)
                    c1Editor1.SaveRtf(s1.FileName);
            }
            else
            {
                c1Editor1.SaveRtf("Test.rtf");
            }
        }
    }
}
