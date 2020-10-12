using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1Command;

namespace ControlExplorer.DynamicHelp
{
    public partial class IceCreamSimulator : C1DemoForm
    {
        ArrayList _styles;
        ArrayList _flavors;
        ArrayList _recipes;

        public IceCreamSimulator()
        {
            InitializeComponent();
        }
        
        private void IceCreamSimulator_Load(object sender, EventArgs e)
        {
            //fill default styles
            _styles = new ArrayList();
            _styles.Add("Classic");
            _styles.Add("Country");
            _styles.Add("Gelato");
            
            //fill default flavors
            _flavors = new ArrayList();
            _flavors.Add("Chocolate");
            _flavors.Add("Vanilla");
            _flavors.Add("Strawberry");

            //fill default recipes
            _recipes = new ArrayList();
            _recipes.Add(new Recipe("Toasted Coconut Ice Cream", "Classic", "Vanilla", "Coconut, Pineapple, Caramel", 2, new DateTime(2007, 9, 7)));
            _recipes.Add(new Recipe("Candied Pinata", "Gelato", "Vanilla", "Blue Sprinkles, Chocolate Chips, Cookie bits, Strawberries", 4, new DateTime(2007, 12, 24)));
            _recipes.Add(new Recipe("Mud Pit", "Classic", "Chocolate", "Caramel Sauce, Gummy Worms, Pistachios", 1, new DateTime(2008, 1, 14)));
            _recipes.Add(new Recipe("Chocolate and Cinnamon", "Gelato", "Chocolate", "Cinnamon, Whipped Cream", 2, new DateTime(2008, 1, 23)));
            _recipes.Add(new Recipe("Fruity Tooty", "Country", "Strawberry", "Bananas, Cherries, Strawberries, Pineapple", 3, new DateTime(2008, 2, 14)));
            _recipes.Add(new Recipe("Eye-Screamin' Sundae", "Classic", "Vanilla", "Red Sprinkles, Strawberry Sauce, 1 Black Cherry", 1, new DateTime(2008, 3, 1)));
            _recipes.Add(new Recipe("True Waffle House", "Cone", "Waffle", "Maple Syrup, Waffle Cone", 2, new DateTime(2008, 4, 17)));
            _recipes.Add(new Recipe("Confetti", "Country", "Vanilla", "Multi-colored Sprinkles", 3, new DateTime(2008, 9, 27)));

            c1DynamicHelp1.HelpSource = AppDomain.CurrentDomain.BaseDirectory + "DynamicHelp\\HelpFiles\\IceCreamWordSource.chm";
            c1DynamicHelp1.Browser.CanGoBackChanged += new EventHandler(Browser_CanGoBackChanged);
            c1DynamicHelp1.Browser.CanGoForwardChanged += new EventHandler(Browser_CanGoForwardChanged);

            ShowTab(tabMain);
            c1DockingTab1.ShowTabs = false;

            //Show default topic
            c1DynamicHelp1.ShowTopic("WordDocuments/icecreamcreationsimulator.htm");
        }

        private void c1CommandHolder1_CommandClick(object sender, C1.Win.C1Command.CommandClickEventArgs e)
        {   
            if (e.Command == c1CommandNew)
            {
                ShowTab(tabNew);
                ClearForms();
            }
            else if (e.Command == c1CommandReset)
            {
                ShowTab(tabNew);
            }
            else if (e.Command == c1CommandHome)
            {
                ShowTab(tabMain);
            }
            else if (e.Command == c1CommandShowHelp)
            {
                splitContainer1.Panel2Collapsed = !c1CommandShowHelp.Checked;
            }
            else if (e.Command == c1CommandCloseHelp)
            {
                splitContainer1.Panel2Collapsed = true;
                c1CommandShowHelp.Checked = false;
            }
            else if (e.Command == c1CommandShowHelpToolbar)
            {
                c1ToolBar2.Visible = c1CommandShowHelpToolbar.Checked;
            }
            else if (e.Command == c1CommandHelpBack)
            {
                //browse backward in C1DynamicHelp
                c1DynamicHelp1.Browser.GoBack();
            }
            else if (e.Command == c1CommandHelpForward)
            {
                //browse forward in C1DynamicHelp
                c1DynamicHelp1.Browser.GoForward();
            }
            else if (e.Command == c1CommandHelpContents)
            {
                //launch help contents in separate window
                c1DynamicHelp1.ShowExternalHelp(C1.Win.C1DynamicHelp.HelpTab.TableOfContents);
            }
            else if (e.Command == c1CommandHelpIndex)
            {
                //launch help index in separate window
                c1DynamicHelp1.ShowExternalHelp(C1.Win.C1DynamicHelp.HelpTab.Index);
            }
            else if (e.Command == c1CommandHelpSearch)
            {
                //launch help find in separate window
                c1DynamicHelp1.ShowExternalHelp(C1.Win.C1DynamicHelp.HelpTab.Find);
            }
            else if (e.Command == c1CommandHelpPin)
            {
                //pin help topic and change button image to reflect pinned state
                c1DynamicHelp1.IsPinnedDown = c1CommandHelpPin.Checked;
                c1CommandHelpPin.Image = c1CommandHelpPin.Checked ? ControlExplorer.Properties.Resources.Pinned : ControlExplorer.Properties.Resources.Unpinned;
            }
            else if (e.Command == c1CommandAddRecipe)
            {
                ShowTab(tabAddRecipe);
                ClearForms();
            }
            else if (e.Command == c1CommandDatabase)
            {
                ShowTab(tabDatabase);
            }
            else if (e.Command == c1CommandCreate)
            {
                ShowTab(tabAddRecipe);
            }
            else if (e.Command == c1CommandEdit)
            {
                c1FlexGrid1.StartEditing();
            }
            else if (e.Command == c1CommandDelete)
            {
                if (c1FlexGrid1.Row != -1 && c1FlexGrid1.Row < _recipes.Count)
                {
                    _recipes.RemoveAt(c1FlexGrid1.Row - 1);
                    c1FlexGrid1.Refresh();
                }
            }
        }

        //Enable state of help forward and back buttons
        void Browser_CanGoForwardChanged(object sender, EventArgs e)
        {
            c1CommandHelpForward.Enabled = c1DynamicHelp1.Browser.CanGoForward;
        }

        void Browser_CanGoBackChanged(object sender, EventArgs e)
        {
            c1CommandHelpBack.Enabled = c1DynamicHelp1.Browser.CanGoBack;
        }

        private void ShowTab(C1DockingTabPage p)
        {
            c1DockingTab1.SelectedTab = p;
            if (p == tabDesign)
            {
                cbDesign_Style.Items.Clear();
                foreach (string style in _styles)
                {
                    cbDesign_Style.Items.Add(style);
                }
                cbDesign_Flavor.Items.Clear();
                foreach (string flavor in _flavors)
                {
                    cbDesign_Flavor.Items.Add(flavor);
                }
                //Navigate to a specific topic in C1DynamicHelp
                c1DynamicHelp1.ShowTopic("WordDocuments/dessertdesign.htm");
            }
            else if (p == tabNew)
            {
                //Navigate to a specific topic in C1DynamicHelp
                c1DynamicHelp1.ShowTopic("WordDocuments/tostarttheicecreamcreationsimulator1.htm");
            }
            else if (p == tabNewStyle)
            {
                if (rbNew_Style.Checked)
                {
                    label15.Text = "New Style";
                    label12.Text = "Style Name";
                }
                else if (rbNew_Flavor.Checked)
                {
                    label15.Text = "New Flavor";
                    label12.Text = "Flavor Name:";
                }
                //Navigate to a specific topic in C1DynamicHelp
                c1DynamicHelp1.ShowTopic("WordDocuments/addinganewstyleorflavor.htm");
            }
            else if (p == tabAddRecipe)
            {
                //Navigate to a specific topic in C1DynamicHelp
                c1DynamicHelp1.ShowTopic("WordDocuments/recipedatabase1.htm");
            }
            else if (p == tabDatabase)
            {
                c1FlexGrid1.DataSource = null;
                c1FlexGrid1.DataSource = _recipes;
                //Navigate to a specific topic in C1DynamicHelp
                c1DynamicHelp1.ShowTopic("WordDocuments/workingwiththerecipedatabase.htm");
            }
        }

        private void ClearForms()
        {
            txtName_Name.Text = "";
            txtNewStyleFlavor.Text = "";
            txtRecipe_Flavor.Text = "";
            txtRecipe_Name.Text = "";
            txtRecipe_Scoops.Value = 0;
            txtRecipe_Style.Text = "";
            txtRecipe_Toppings.Text = "";
            cbDesign_Flavor.Text = "";
            cbDesign_Style.Text = "";
            chkListToppings.ClearSelected();
        }

        private void c1ButtonNewNext_Click(object sender, EventArgs e)
        {
            if (rbNew_IceCream.Checked)
            {
                ShowTab(tabDesign);  
            }
            else if (rbNew_Style.Checked)
            {
                ShowTab(tabNewStyle);
            }
            else if (rbNew_Flavor.Checked)
            {
                ShowTab(tabNewStyle);
            }
        }

        private void btnDesign_Back_Click(object sender, EventArgs e)
        {
            ShowTab(tabNew);
        }

        private void btDesign_Ok_Click(object sender, EventArgs e)
        {
            ShowTab(tabName);
        }

        private void btnRecipe_Cancel_Click(object sender, EventArgs e)
        {
            ShowTab(tabDatabase);
        }

        private void btnRecipe_Add_Click(object sender, EventArgs e)
        {
            _recipes.Add(new Recipe(txtRecipe_Name.Text, txtRecipe_Style.Text, txtRecipe_Flavor.Text, txtRecipe_Toppings.Text, (int)txtRecipe_Scoops.Value, txtRecipe_DateAdded.Value));
            MessageBox.Show("Recipe Added!");
            ShowTab(tabDatabase);
        }

        private void btnName_Done_Click(object sender, EventArgs e)
        {
            //run progress bar
            ribbonProgressBar1.Value = 0;
            for (int i = 0; i < 5; i++)
            {
                ribbonProgressBar1.PerformStep();
                c1StatusBar1.Update();
                System.Threading.Thread.Sleep(90);
            }
            //show error screen
            ShowTab(tabError);
            //Navigate to a specific topic in C1DynamicHelp
            c1DynamicHelp1.ShowTopic("WordDocuments/error122.htm");
        }

        private void btnName_Back_Click(object sender, EventArgs e)
        {
            ShowTab(tabDesign);
        }

        private void btnNewStyleFlavor_Click(object sender, EventArgs e)
        {
            if (rbNew_Flavor.Checked)
            {
                _flavors.Add(txtNewStyleFlavor.Text);
                MessageBox.Show("New Flavor Added!");
            }
            else if (rbNew_Style.Checked)
            {
                _styles.Add(txtNewStyleFlavor.Text);
                MessageBox.Show("New Style Added!");
            }
            ShowTab(tabNew);
        }

        private void btnNewStyle_Back_Click(object sender, EventArgs e)
        {
            ShowTab(tabNew);
        }

        private void c1SuperLabel1_LinkClicked(object sender, C1.Win.C1SuperTooltip.C1SuperLabelLinkClickedEventArgs e)
        {
            splitContainer1.Panel2Collapsed = false;
        }   
        
    }

    #region "Recipe"
    /// <summary>
    /// This class represents our recipe database (which doesn't really exist)
    /// </summary>
    class Recipe
    {
        private string _name;
        private string _style;
        private string _flavor;
        private string _toppings;
        private int _scoops;
        private DateTime _dateadded;

        /// <summary>
        /// Creates new instance of Location object with the specified parameters.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        public Recipe(String name, string style, string flavor, string toppings, int scoops, DateTime dateadded)
        {
            _name = name;
            _style = style;
            _flavor = flavor;
            _toppings = toppings;
            _scoops = scoops;
            _dateadded = dateadded;
        }

        /// <summary>
        /// Gets or sets Recipe name.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (_name != value)
                {
                    _name = value;
                }
            }
        }

        /// <summary>
        /// Recipe Style
        /// </summary>
        public string Style
        {
            get
            {
                return _style;
            }
            set
            {
                if (_style != value)
                {
                    _style = value;
                }
            }
        }

        /// <summary>
        /// Recipe Flavor
        /// </summary>
        public string Flavor
        {
            get
            {
                return _flavor;
            }
            set
            {
                if (_flavor != value)
                {
                    _flavor = value;
                }
            }
        }

        /// <summary>
        /// Recipe Toppings
        /// </summary>
        public string Toppings
        {
            get
            {
                return _toppings;
            }
            set
            {
                if (_toppings != value)
                {
                    _toppings = value;
                }
            }
        }

        /// <summary>
        /// Recipe number of scoops
        /// </summary>
        public int Scoops
        {
            get
            {
                return _scoops;
            }
            set
            {
                if (_scoops != value)
                {
                    _scoops = value;
                }
            }
        }

        /// <summary>
        /// Recipe Date added
        /// </summary>
        public DateTime DateAdded
        {
            get
            {
                return _dateadded;
            }
            set
            {
                if (_dateadded != value)
                {
                    _dateadded = value;
                }
            }
        }

        /// <summary>
        /// Returns Recipe Name.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Name;
        }
    }
    #endregion
}
