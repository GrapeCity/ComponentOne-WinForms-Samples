using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TXTextSpellCheckerDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // connect controls
            _txText.ButtonBar = buttonBar1;
            _txText.RulerBar = rulerBar1;
            _txText.StatusBar = statusBar1;

            // connect spell-checker
            _spell.SetActiveSpellChecking(_txText, true);

            // show some text in the editor
            _txText.Text = "This is a TXTextControl (by The Imaging Source) " +
                "with as-you-type spell checking provided by a ComponentOne C1SpellChecker.\r\n\r\n" +
                "Of coorse this this text has a few mispellings so you can see teh spellcheker " +
                "in acton.";
        }
    }
}