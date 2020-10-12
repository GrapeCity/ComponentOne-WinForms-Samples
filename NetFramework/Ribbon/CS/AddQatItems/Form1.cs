using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

// Make sure to import the C1Ribbon namespace:
using C1.Win.C1Ribbon;

namespace AddQatItems
{
    public partial class Form1 : C1RibbonForm
    {
        public Form1()
        {
            InitializeComponent();

            // Create a new instance of C1Ribbon and add it to the form.
            C1Ribbon c1Ribbon1 = new C1Ribbon();
            this.Controls.Add(c1Ribbon1);

            c1Ribbon1.Qat.Items.Add(new RibbonButton(Properties.Resources.Save));
            c1Ribbon1.Qat.Items.Add(new RibbonButton(Properties.Resources.Undo));
            c1Ribbon1.Qat.Items.Add(new RibbonButton(Properties.Resources.Redo));
        }
    }
}