using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using C1.Win.C1Ribbon;

namespace AddRibbonItems
{
    public partial class Form1 : C1RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Create a new instance of C1Ribbon and add it to the form.
            C1Ribbon c1Ribbon1 = new C1Ribbon();
            this.Controls.Add(c1Ribbon1);

            // Add the Home tab and the Font group.
            RibbonTab homeTab = c1Ribbon1.Tabs.Add("Home");
            RibbonGroup fontGroup = homeTab.Groups.Add("Font");

            // Add a toolbar to arrange the buttons in a row.
            RibbonToolBar toolBar1 = new RibbonToolBar();
            fontGroup.Items.Add(toolBar1);

            // Add the Bold, Italic, and Strike Through buttons.
            toolBar1.Items.Add(new RibbonToggleButton(Properties.Resources.Bold));
            toolBar1.Items.Add(new RibbonToggleButton(Properties.Resources.Italic));
            toolBar1.Items.Add(new RibbonToggleButton(Properties.Resources.Strikethrough));

            // Add a separator to visually separate the button groups.
            toolBar1.Items.Add(new RibbonSeparator());

            // Add a toggle button group 
            RibbonToggleGroup toggleGroup = new RibbonToggleGroup();
            toolBar1.Items.Add(toggleGroup);

            // Add the Subscript and Superscript buttons to the toggle group.
            // This makes the buttons behave like radio buttons (pressing one releases all others).
            toggleGroup.Items.Add(new RibbonToggleButton(Properties.Resources.Subscript));
            toggleGroup.Items.Add(new RibbonToggleButton(Properties.Resources.Superscript));

            // Add another toolbar for the second row.
            RibbonToolBar toolbar2 = new RibbonToolBar();
            fontGroup.Items.Add(toolbar2);

            // Add a combo box.
            toolbar2.Items.Add(new RibbonComboBox());
        }
    }
}