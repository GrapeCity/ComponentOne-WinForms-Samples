using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Framework;

// Make sure to import the C1Ribbon namespace:
using C1.Win.Ribbon;

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

            var saveButton = new RibbonButton();
            saveButton.IconSet.Add(new C1BitmapIcon("Save", new Size(16, 16), Color.Transparent, "Preset_SmallImages", -1));
            c1Ribbon1.Qat.Items.Add(saveButton);
            var undoButton = new RibbonButton();
            undoButton.IconSet.Add(new C1BitmapIcon("Undo", new Size(16, 16), Color.Transparent, "Preset_SmallImages", -1));
            c1Ribbon1.Qat.Items.Add(undoButton);
            var redoButton = new RibbonButton();
            redoButton.IconSet.Add(new C1BitmapIcon("Redo", new Size(16, 16), Color.Transparent, "Preset_SmallImages", -1));
            c1Ribbon1.Qat.Items.Add(redoButton);
        }
    }
}