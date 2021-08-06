using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlExplorer.InputPanel
{
    public partial class FlowPanelCatalogue : C1DemoForm
    {
        public FlowPanelCatalogue()
        {
            InitializeComponent();

        }

        private void FlowPanelСatalogue_Load(object sender, EventArgs e)
        {
            GetCatalogueData();
        }

        private void GetCatalogueData()
        {
            List<CatalogueItem> catalogueItems = new List<CatalogueItem>();
            string dbPath = "C1Demo.mdb";
            string connString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + dbPath;
            if (File.Exists(dbPath))
            {
                using (OleDbConnection conn = new OleDbConnection(connString))
                {
                    conn.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = conn;
                    command.CommandText = "Select top 15 Brand, Model, Category, Description, Hyperlink, Picture, Price from Cars";

                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                MemoryStream stream = new MemoryStream((Byte[])reader.GetValue(5));
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
                catalogueItems.Add(new CatalogueItem("Rolls-Royce", "Wraith", ((System.Drawing.Bitmap)(FlowCatalogueResources.rolls_roys_Wraith)), "SALOON", "Antilock brakes, traction control and automatic ride control are standard.Side - impact airbags are not available.", "<a href=\"http://www.rollsroyce.com\">http://www.rollsroyce.com</a>", 370485));
                catalogueItems.Add(new CatalogueItem("Jaguar", "F-TYPE I", ((System.Drawing.Bitmap)(FlowCatalogueResources.Jaguar_F_type1)), "SPORTS", "ENGINE & DRIVETRAIN", "<a href=\"http://www.jaguarusa.com\">http://www.jaguarusa.com</a>", 73000));
                catalogueItems.Add(new CatalogueItem("Ford", "Ranger VI", ((System.Drawing.Bitmap)(FlowCatalogueResources.Ford_Ranger)), "TRUCK", "Ford's compact Ranger pickup earned a freshened front end last year and comes with several new option groups this year. The most notable new offering is the FX-4 offroad package for the four-door SuperCab chassis, which combines off-the-pavement functionality with an appealing Styleside-box appearance. Powered by a 4.0-liter V-6 engine, the FX-4 group includes Bilstein shocks, heavy-duty springs, three skid plates, tow hooks and forged-aluminum wheels.", " <a href=\"http://www.ford.com\">http://www.ford.com</a>", 12565));
                catalogueItems.Add(new CatalogueItem("Lexus", "ES VI Sedan", ((System.Drawing.Bitmap)(FlowCatalogueResources.lexus_ES_VI_Sedan)), "SALOON", "Redesigned for 2001 with more aerodynamic styling and a bigger V-8 engine than the previous LS 400, the full-size, rear-drive flagship sedan from Toyota's luxury division gets only a single new color, Platinum Blue Pearl, for 2002. The 4.3-liter V-8 makes 290 horsepower and teams with a five-speed-automatic transmission.", "<a href=\"http://www.lexus.com\">http://www.lexus.com</a>", 54900));
                catalogueItems.Add(new CatalogueItem("Mercedes-Benz", "SLK R172 Cabriolet", ((System.Drawing.Bitmap)(FlowCatalogueResources.Mercedes_Benz_SLK_250)), "SPORTS", "Engine 4,966-cc SOHC 24-valve 90° V-8. High-pressure die-cast alloy cylinder block, alloy heads. Fuel and ignition system ME 2.8 engine management. Integrated sequential multipoint fuel injection and phased twin-spark ignition includes individual cylinder control of fuel spray, spark timing/phase and antiknock. Two high-energy ignition coils and two spark plugs per cylinder, with 100,000-mile spark plug intervals. Electronic throttle control.", "<a href=\"http://www.mercedes.com\">http://www.mercedes.com</a>", 83800));
            }
            foreach (CatalogueItem item in catalogueItems)
                this.inputFlowPanel1.Items.Add(GenerateItemCard(item));
        }

        private C1.Win.C1InputPanel.InputGridPanel GenerateItemCard(CatalogueItem item)
        {
            C1.Win.C1InputPanel.InputGridPanel inputGridPanel1 = new C1.Win.C1InputPanel.InputGridPanel();
            C1.Win.C1InputPanel.InputImage itemImage = new C1.Win.C1InputPanel.InputImage();
            C1.Win.C1InputPanel.InputLabel itemBrand = new C1.Win.C1InputPanel.InputLabel();
            C1.Win.C1InputPanel.InputLabel inputLabel2 = new C1.Win.C1InputPanel.InputLabel();
            C1.Win.C1InputPanel.InputLabel inputLabel3 = new C1.Win.C1InputPanel.InputLabel();
            C1.Win.C1InputPanel.InputHtmlLabel itemLink = new C1.Win.C1InputPanel.InputHtmlLabel();
            C1.Win.C1InputPanel.InputLabel inputLabel4 = new C1.Win.C1InputPanel.InputLabel();
            C1.Win.C1InputPanel.InputLabel itemDescription = new C1.Win.C1InputPanel.InputLabel();
            C1.Win.C1InputPanel.InputLabel itemCost = new C1.Win.C1InputPanel.InputLabel();
            C1.Win.C1InputPanel.InputLabel itemModel = new C1.Win.C1InputPanel.InputLabel();
            C1.Win.C1InputPanel.InputLabel inputLabel1 = new C1.Win.C1InputPanel.InputLabel();
            C1.Win.C1InputPanel.InputLabel itemCategory = new C1.Win.C1InputPanel.InputLabel();

            // 
            // inputGridPanel1
            // 

            inputGridPanel1.ColumnDefinitions.Add(new C1.Win.C1InputPanel.ColumnDefinition());
            inputGridPanel1.ColumnDefinitions.Add(3);
            inputGridPanel1.ColumnDefinitions[0].Width = 150;
            inputGridPanel1.ColumnDefinitions[0].SizeType = SizeType.Absolute;
            inputGridPanel1.ColumnDefinitions[1].Width = 70;
            inputGridPanel1.ColumnDefinitions[1].SizeType = SizeType.Absolute;

            inputGridPanel1.RowDefinitions.Add(5);

            inputGridPanel1.Break = C1.Win.C1InputPanel.BreakType.None;
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
            itemBrand.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Near;
            itemBrand.Text = item.Brand;
            itemBrand.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center;
            // 
            // itemModel
            // 
            itemModel.ColumnIndex = 1;
            itemModel.ColumnSpan = 2;
            itemModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            itemModel.Name = "itemModel";
            itemModel.Text = item.Model;
            itemModel.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center;
            // 
            // itemImage
            // 

            itemImage.ImageAlign = C1.Win.C1InputPanel.InputImageAlignment.MiddleCenter;
            itemImage.Image = item.ItemImage;
            itemImage.RowIndex = 1;
            itemImage.RowSpan = 4;
            itemImage.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Near;
            itemImage.Width = 142;
            itemImage.ImageScaling = C1.Win.C1InputPanel.InputImageScaling.Scale;
            // 
            // inputLabel1
            // 
            inputLabel1.ColumnIndex = 1;
            inputLabel1.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Near;
            inputLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            inputLabel1.Padding = new System.Windows.Forms.Padding(2);
            inputLabel1.RowIndex = 1;
            inputLabel1.Text = "Category:";
            inputLabel1.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center;
            // 
            // itemCategory
            // 
            itemCategory.ColumnIndex = 2;
            itemCategory.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Near;
            itemCategory.Padding = new System.Windows.Forms.Padding(2);
            itemCategory.RowIndex = 1;
            itemCategory.Text = item.Category;
            itemCategory.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center;
            // 
            // inputLabel2
            // 
            inputLabel2.ColumnIndex = 1;
            inputLabel2.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Near;
            inputLabel2.Padding = new System.Windows.Forms.Padding(2);
            inputLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            inputLabel2.RowIndex = 4;
            inputLabel2.Text = "Description:";
            inputLabel2.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Near;
            // 
            // itemDescription
            // 
            itemDescription.ColumnIndex = 2;
            itemDescription.Height = -1;
            itemDescription.Text = item.Description;
            itemDescription.WordWrap = true;
            itemDescription.RowIndex = 4;
            itemDescription.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Spread;
            itemDescription.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Near;
            // 
            // inputLabel3
            // 
            inputLabel3.ColumnIndex = 1;
            inputLabel3.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Near;
            inputLabel3.Padding = new System.Windows.Forms.Padding(2);
            inputLabel3.RowIndex = 3;
            inputLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            inputLabel3.Text = "Details:";
            inputLabel3.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center;
            // 
            // itemLink
            // 
            itemLink.ColumnIndex = 2;
            itemLink.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Near;
            itemLink.Padding = new System.Windows.Forms.Padding(2);
            itemLink.RowIndex = 3;
            itemLink.Text = item.Details;
            itemLink.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center;
            // 
            // inputLabel4
            // 
            inputLabel4.ColumnIndex = 1;
            inputLabel4.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Near;
            inputLabel4.Padding = new System.Windows.Forms.Padding(2);
            inputLabel4.RowIndex = 2;
            inputLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            inputLabel4.Text = "Cost:";
            inputLabel4.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center;
            // 
            // itemCost
            // 
            itemCost.ColumnIndex = 2;
            itemCost.Padding = new System.Windows.Forms.Padding(2);
            itemCost.RowIndex = 2;
            itemCost.Text = item.Cost;
            itemCost.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center;


            return inputGridPanel1;

        }
        class CatalogueItem
        {
            public string Brand { get; set; }

            public string Model { get; set; }
            public System.Drawing.Bitmap ItemImage { get; set; }
            public string Category { get; set; }
            public string Description { get; set; }
            public string Details { get; set; }
            public string Cost { get; set; }

            public CatalogueItem(string brand, string model, System.Drawing.Bitmap itemImage, string category, string description, string details, int cost)
            {
                Brand = brand;
                Model = model;
                ItemImage = itemImage;
                Category = category;
                Description = DescriptionToMultiline(description);
                Details = "<a href=\"" + details + "\">" + details + "</a>";
                Cost = "$" + cost.ToString();
            }

            private string DescriptionToMultiline(string longDescription)
            {
                longDescription = longDescription.Split('\n', '.')[0];
                string multiline = "";
                int spaceInd;
                int rowWidth = 30;
                while (longDescription.Length > rowWidth)
                {
                    spaceInd = (longDescription.Substring(0, rowWidth)).LastIndexOf(" ");
                    if (spaceInd < 0)
                        spaceInd = rowWidth;
                    multiline += longDescription.Substring(0, spaceInd) + "\n\r";
                    longDescription = longDescription.Substring(spaceInd + 1);
                }
                multiline += longDescription;
                return multiline;
            }
        }
    }

}
