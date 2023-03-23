using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace UsingUIElementResolver
{
    public partial class Form1 : C1.Win.C1Ribbon.C1RibbonForm
    {
        public Form1()
        {
            InitializeComponent();

            // try to comment this line out and no topics will be displayed and you won't be able to select 
            // separate UI elements on the C1Ribbon such as groups, etc. You will be able to select only the C1Ribbon itself
            c1DynamicHelp1.Resolver = new CustomUIElementResolver();
        }

        // toggle authoring mode when the user hits ctrl+shift+a
        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A && e.Control && e.Shift)
                c1DynamicHelp1.AuthoringMode = !c1DynamicHelp1.AuthoringMode;
            base.OnKeyDown(e);
        }
    }
}