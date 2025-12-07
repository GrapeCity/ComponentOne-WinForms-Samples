using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;
using C1.Win.Tile;

namespace DataBound
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region Switch to C1NWind.mdb database

            string dbPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal) +
                "\\ComponentOne Samples\\Common\\C1NWind.mdb";
            if (File.Exists(dbPath))
            {
                OleDbConnectionStringBuilder csb = new OleDbConnectionStringBuilder(productsConnection.ConnectionString);
                csb.DataSource = dbPath;
                productsConnection.ConnectionString = csb.ToString();
            }

            #endregion

            categoriesDataAdapter.Fill(dataSet11);
            suppliersDataAdapter.Fill(dataSet11);
            productsDataAdapter.Fill(dataSet11);
        }

        private void c1TileControl1_FormatValue(object sender, FormatValueEventArgs e)
        {
            if (e.TileProperty == TileProperty.BackColor)
            {
                if (e.Value is bool && (bool)e.Value)
                    e.Value = Color.Firebrick;
                else
                    e.Value = Color.DimGray;
            }
            else if (e.TileProperty == TileProperty.IntValue)
            {
                int result = 0;
                switch (e.Value as string)
                {
                    case "UK":
                        result = 1; break;
                    case "France":
                        result = 2; break;
                    case "Brazil":
                        result = 3; break;
                    case "Singapore":
                        result = 4; break;
                    case "USA":
                        result = 5; break;
                    case "Germany":
                        result = 6; break;
                    case "Australia":
                        result = 7; break;
                    case "Japan":
                        result = 8; break;
                    case "Canada":
                        result = 9; break;
                    case "Netherlands":
                        result = 10; break;
                    case "Finland":
                        result = 11; break;
                    case "Norway":
                        result = 12; break;
                    case "Italy":
                        result = 13; break;
                    case "Spain":
                        result = 14; break;
                    case "Sweden":
                        result = 15; break;
                    case "Denmark":
                        result = 16; break;
                }
                e.Value = result;
            }
        }

        private void c1TileControl1_TileClicked(object sender, TileEventArgs e)
        {
            CurrencyManager cm = this.BindingContext[dataSet11, "Products"] as CurrencyManager;
            IBindingList list = cm.List as IBindingList;
            PropertyDescriptor pd = cm.GetItemProperties()["ProductID"];
            cm.Position = list.Find(pd, e.Tile.Tag);
        }
    }
}
