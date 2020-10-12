using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CustomDictionary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // declare an instance of the custom spell dictionary
        MySpellDictionary _customDict = new MySpellDictionary();

        private void Form1_Load(object sender, EventArgs e)
        {
            // activate custom dictionary
            _spell.CustomDictionary = _customDict;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // toggle custom dictionary
            _spell.CustomDictionary = checkBox1.Checked ? _customDict : null;
        }
    }

    /// <summary>
    /// Class that implements the ISpellDictionary interface and can be assigned to the
    /// C1SpellChecker's CustomDictionary property.
    /// </summary>
    public class MySpellDictionary : C1.Win.C1SpellChecker.ISpellDictionary
    {
        // ISpellDictionary has a single method:
        // in this case, the dictionary will ignore any words that start with 'z'.
        public bool Contains(string word)
        {
            return word.StartsWith("z", StringComparison.InvariantCultureIgnoreCase);
        }
    }
}