using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using C1.Win.FlexGrid;

namespace ColumnBandsAdvanced
{
    public partial class ColumnBandsUserControl : UserControl
    {
        public ColumnBandsUserControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sets BandsColumnsRelation of column bands
        /// </summary>
        /// <param name="bandsColumnsRelation">BandsColumnsRelation value</param>
        public void SetBandsColumnsRelation(BandsColumnsRelation bandsColumnsRelation)
        {
            c1FlexGridBandedView1.BeginUpdate();

            c1FlexGridBandedView1.BandsColumnsRelation = bandsColumnsRelation;

            c1FlexGridBandedView1.EndUpdate();
        }

        /// <summary>
        /// Clear column bands
        /// </summary>
        public void ClearColumnBands()
        {
            c1FlexGridBandedView1.Bands.Clear();
        }

        /// <summary>
        /// Create column bands
        /// </summary>
        public void CreateBands()
        {
            c1FlexGridBandedView1.BeginUpdate();

            ClearColumnBands();

            var bands = c1FlexGridBandedView1.Bands;
            bands.Add("ID");

            var bMain = bands.Add("Main");
            bMain.ColSpan = 3;
            bMain.Children.Add("Brand");
            bMain.Children.Add("Model");
            bMain.Children.Add("Category");

            var bDescription = bMain.Children.Add("Description");
            bDescription.ColSpan = 3;
            bDescription.RowSpan = 3;

            bands.Add("HP");
            bands.Add("Cyl");
            bands.Add("MPG_City", "MPG City");
            bands.Add("MPG_Highway", "MPG Highway");
            bands.Add("TransmissAutomatic", "Transmission Automatic");
            bands.Add("TransmissSpeedCount", "Transmission Speed Count");
            bands.Add("Liter");
            bands.Add("Hyperlink");

            c1FlexGridBandedView1.EndUpdate();
        }

        /// <summary>
        /// Initializing the control
        /// </summary>
        public void Init()
        {
            SetupC1FlexGrid();
        }

        /// <summary>
        /// Setup C1FlexGrid with data
        /// </summary>
        private void SetupC1FlexGrid()
        {
            c1FlexGrid1.BeginUpdate();

            carsTableAdapter.Connection.ConnectionString = GetConnectionString();
            this.carsTableAdapter.Fill(this.c1NWindDataSet.Cars);

            //truncate long descriptions
            var cars = c1NWindDataSet.Cars.AsEnumerable().ToList();
            cars.ForEach(x =>
            {
                var descr = Regex.Replace(x["Description"].ToString(), @"\r\n\s*\r\n", Environment.NewLine);
                descr = Regex.Replace(descr, "(.{" + 77 + "})", "$1" + Environment.NewLine);
                x["Description"] = descr.Substring(0, Math.Min(descr.Length, 333));
            });

            foreach (RowCol col in c1FlexGrid1.Cols)
            {
                col.TextAlign = TextAlignEnum.CenterCenter;
            }
            c1FlexGrid1.Cols["Description"].TextAlign = TextAlignEnum.LeftCenter;

            c1FlexGrid1.AllowMergingFixed = AllowMergingEnum.Free;

            c1FlexGrid1.EndUpdate();
        }

        private static string GetConnectionString()
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common";
            //var conn = @"provider=Microsoft.ACE.OLEDB.12.0;data source={0}\c1nwind.mdb;";
            var conn = @"provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;";
            return string.Format(conn, path);
        }

    }
}
