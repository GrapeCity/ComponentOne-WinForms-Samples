using C1.Win.C1InputPanel;
using C1.Win.C1Themes;
using C1.Win.Ribbon;
using FlowPanelCatalogue.Properties;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FlowPanelCatalogue
{
    public partial class MainForm : C1RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            GetCatalogueData();
            InitThemes();
        }

        private void GetCatalogueData()
        {
            List<CatalogueItem> catalogueItems = new List<CatalogueItem>();
            string dbPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\ComponentOne Samples\\Common\\C1NWind.db";
            string connString = "Data Source=" + dbPath+ ";Version=3;";
            if (File.Exists(dbPath))
            {
                using (SqliteConnection conn = new SqliteConnection(connString))
                {
                    conn.Open();
                    SqliteCommand command = new SqliteCommand();
                    command.Connection = conn;
                    command.CommandText = "Select Brand, Model, Category, Description, Hyperlink, Picture, Price from Cars limit 15";
                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                MemoryStream stream = new MemoryStream(Convert.FromBase64String(reader.GetValue(5).ToString().TrimStart().TrimEnd()));
                                Bitmap bitmap = new Bitmap(stream);
                                catalogueItems.Add(new CatalogueItem(reader.GetValue(0).ToString(), reader.GetValue(1).ToString(), bitmap, reader.GetValue(2).ToString(), reader.GetValue(3).ToString(), reader.GetValue(4).ToString(), Convert.ToInt32(reader.GetValue(6))));
                            }
                        }
                    }
                    conn.Close();
                }

            }
            else
            {
                catalogueItems.Add(new CatalogueItem("Rolls-Royce", "Wraith", ((System.Drawing.Bitmap)(Resources.rolls_roys_Wraith)), "SALOON", "Antilock brakes, traction control and automatic ride control are standard.Side - impact airbags are not available.", "<a href=\"http://www.rollsroyce.com\">http://www.rollsroyce.com</a>", 370485));
                catalogueItems.Add(new CatalogueItem("Jaguar", "F-TYPE I", ((System.Drawing.Bitmap)(Resources.Jaguar_F_type1)), "SPORTS", "ENGINE & DRIVETRAIN", "<a href=\"http://www.jaguarusa.com\">http://www.jaguarusa.com</a>", 73000));
                catalogueItems.Add(new CatalogueItem("Ford", "Ranger VI", ((System.Drawing.Bitmap)(Resources.Ford_Ranger)), "TRUCK", "Ford's compact Ranger pickup earned a freshened front end last year and comes with several new option groups this year. The most notable new offering is the FX-4 offroad package for the four-door SuperCab chassis, which combines off-the-pavement functionality with an appealing Styleside-box appearance. Powered by a 4.0-liter V-6 engine, the FX-4 group includes Bilstein shocks, heavy-duty springs, three skid plates, tow hooks and forged-aluminum wheels.", " <a href=\"http://www.ford.com\">http://www.ford.com</a>", 12565));
                catalogueItems.Add(new CatalogueItem("Lexus", "ES VI Sedan", ((System.Drawing.Bitmap)(Resources.lexus_ES_VI_Sedan)), "SALOON", "Redesigned for 2001 with more aerodynamic styling and a bigger V-8 engine than the previous LS 400, the full-size, rear-drive flagship sedan from Toyota's luxury division gets only a single new color, Platinum Blue Pearl, for 2002. The 4.3-liter V-8 makes 290 horsepower and teams with a five-speed-automatic transmission.", "<a href=\"http://www.lexus.com\">http://www.lexus.com</a>", 54900));
                catalogueItems.Add(new CatalogueItem("Mercedes-Benz", "SLK R172 Cabriolet", ((System.Drawing.Bitmap)(Resources.Mercedes_Benz_SLK_250)), "SPORTS", "Engine 4,966-cc SOHC 24-valve 90° V-8. High-pressure die-cast alloy cylinder block, alloy heads. Fuel and ignition system ME 2.8 engine management. Integrated sequential multipoint fuel injection and phased twin-spark ignition includes individual cylinder control of fuel spray, spark timing/phase and antiknock. Two high-energy ignition coils and two spark plugs per cylinder, with 100,000-mile spark plug intervals. Electronic throttle control.", "<a href=\"http://www.mercedes.com\">http://www.mercedes.com</a>", 83800));
            }
            foreach (CatalogueItem item in catalogueItems)
                this.inputFlowPanel1.Items.Add(GenerateItemCard(item));
        }

        private InputGridPanel GenerateItemCard(CatalogueItem item)
        {
            InputGridPanel inputGridPanel1 = new InputGridPanel();
            InputImage itemImage = new InputImage();
            InputLabel itemBrand = new InputLabel();
            InputLabel inputLabel2 = new InputLabel();
            InputLabel inputLabel3 = new InputLabel();
            InputHtmlLabel itemLink = new InputHtmlLabel();
            InputLabel inputLabel4 = new InputLabel();
            InputLabel itemDescription = new InputLabel();
            InputLabel itemCost = new InputLabel();
            InputLabel itemModel = new InputLabel();
            InputLabel inputLabel1 = new InputLabel();
            InputLabel itemCategory = new InputLabel();

            // 
            // inputGridPanel1
            // 

            inputGridPanel1.ColumnDefinitions.Add(new ColumnDefinition());
            inputGridPanel1.ColumnDefinitions.Add(3);
            inputGridPanel1.ColumnDefinitions[0].Width = 150;
            inputGridPanel1.ColumnDefinitions[0].SizeType = SizeType.Absolute;
            inputGridPanel1.ColumnDefinitions[1].Width = 70;
            inputGridPanel1.ColumnDefinitions[1].SizeType = SizeType.Absolute;

            inputGridPanel1.RowDefinitions.Add(5);

            inputGridPanel1.Break = BreakType.None;        
            inputGridPanel1.Items.Add(itemBrand);
            inputGridPanel1.Items.Add(itemModel);
            inputGridPanel1.Items.Add(itemImage);
            inputGridPanel1.Items.Add(inputLabel1);
            inputGridPanel1.Items.Add(itemCategory);
            inputGridPanel1.Items.Add(inputLabel2);
            inputGridPanel1.Items.Add(itemDescription);
            inputGridPanel1.Items.Add(inputLabel3);
            inputGridPanel1.Items.Add(itemLink);
            inputGridPanel1.Items.Add(inputLabel4);
            inputGridPanel1.Items.Add(itemCost);
            inputGridPanel1.Name = "inputGridPanel1";
            inputGridPanel1.Padding = new System.Windows.Forms.Padding(10);
            inputGridPanel1.Width = 400;
            // 
            // itemBrand
            // 
            itemBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            itemBrand.HorizontalAlign = InputContentAlignment.Near;
            itemBrand.Text = item.Brand;
            itemBrand.VerticalAlign = InputContentAlignment.Center;
            // 
            // itemModel
            // 
            itemModel.ColumnIndex = 1;
            itemModel.ColumnSpan = 2;
            itemModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            itemModel.Name = "itemModel";
            itemModel.Text = item.Model;
            itemModel.VerticalAlign = InputContentAlignment.Center;
            // 
            // itemImage
            // 
            
            itemImage.ImageAlign = InputImageAlignment.MiddleCenter;
            itemImage.Image = item.ItemImage;
            itemImage.RowIndex = 1;
            itemImage.RowSpan = 4;
            itemImage.VerticalAlign = InputContentAlignment.Near;
            itemImage.Width = 142;
            itemImage.ImageScaling = InputImageScaling.Scale;
            // 
            // inputLabel1
            // 
            inputLabel1.ColumnIndex = 1;
            inputLabel1.HorizontalAlign = InputContentAlignment.Near;
            inputLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            inputLabel1.Padding = new System.Windows.Forms.Padding(2);
            inputLabel1.RowIndex = 1;
            inputLabel1.Text = "Category:";
            inputLabel1.VerticalAlign = InputContentAlignment.Center;
            // 
            // itemCategory
            // 
            itemCategory.ColumnIndex = 2;
            itemCategory.HorizontalAlign = InputContentAlignment.Near;
            itemCategory.Padding = new System.Windows.Forms.Padding(2);
            itemCategory.RowIndex = 1;
            itemCategory.Text = item.Category;
            itemCategory.VerticalAlign = InputContentAlignment.Center;
            // 
            // inputLabel2
            // 
            inputLabel2.ColumnIndex = 1;
            inputLabel2.HorizontalAlign = InputContentAlignment.Near;
            inputLabel2.Padding = new System.Windows.Forms.Padding(2);
            inputLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            inputLabel2.RowIndex = 4;
            inputLabel2.Text = "Description:";
            inputLabel2.VerticalAlign = InputContentAlignment.Near;
            // 
            // itemDescription
            // 
            itemDescription.ColumnIndex = 2;
            itemDescription.Height = -1;
            itemDescription.Text = item.Description;
            itemDescription.WordWrap = true;
            itemDescription.RowIndex = 4;
            itemDescription.HorizontalAlign = InputContentAlignment.Spread;
            itemDescription.VerticalAlign = InputContentAlignment.Near;
            // 
            // inputLabel3
            // 
            inputLabel3.ColumnIndex = 1;
            inputLabel3.HorizontalAlign = InputContentAlignment.Near;
            inputLabel3.Padding = new System.Windows.Forms.Padding(2);
            inputLabel3.RowIndex = 3;
            inputLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            inputLabel3.Text = "Details:";
            inputLabel3.VerticalAlign = InputContentAlignment.Center;
            // 
            // itemLink
            // 
            itemLink.ColumnIndex = 2;
            itemLink.HorizontalAlign = InputContentAlignment.Near;
            itemLink.Padding = new System.Windows.Forms.Padding(2);
            itemLink.RowIndex = 3;
            itemLink.Text = item.Details;
            itemLink.VerticalAlign = InputContentAlignment.Center;
            // 
            // inputLabel4
            // 
            inputLabel4.ColumnIndex = 1;
            inputLabel4.HorizontalAlign = InputContentAlignment.Near;
            inputLabel4.Padding = new System.Windows.Forms.Padding(2);
            inputLabel4.RowIndex = 2;
            inputLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            inputLabel4.Text = "Cost:";
            inputLabel4.VerticalAlign = InputContentAlignment.Center;
            // 
            // itemCost
            // 
            itemCost.ColumnIndex = 2;
            itemCost.Padding = new System.Windows.Forms.Padding(2);
            itemCost.RowIndex = 2;
            itemCost.Text = item.Cost;
            itemCost.VerticalAlign = InputContentAlignment.Center;

            
            return inputGridPanel1;

        }

        #region Themes

        private void InitThemes()
        {
            var themes = C1ThemeController.GetThemes().Where(x => x.Contains("Office2016"));
            foreach (var theme in themes)
                cmbTheme.Items.Add(theme);
        }

        private void cmbTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            c1ThemeController1.Theme = cmbTheme.SelectedItem.Text;
        }

        #endregion

    }


}
