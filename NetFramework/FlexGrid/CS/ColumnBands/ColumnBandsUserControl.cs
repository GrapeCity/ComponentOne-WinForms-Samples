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
using C1.Win.C1FlexGrid;

namespace ColumnBands
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

            c1FlexGridBandedView1.BandsColumnsRelation = BandsColumnsRelation.BandsBeforeColumns;

            var bands = c1FlexGridBandedView1.Bands;
            bands.Add("ID");
            IBand band1 = bands.Add("Car");
            band1.CollapseTo = "Model";
            IBand band2 = band1.Children.Add("Model");
            band2.CollapseTo = "Model";
            band2.Children.Add("Brand");
            band2.Children.Add("Model");
            band1.Children.Add("Category");

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

            LoadImages();

            c1FlexGrid1.AutoSizeCols();
            c1FlexGrid1.AutoSizeRows();
            c1FlexGrid1.Cols["Description"].Width = 388;

            foreach (RowCol col in c1FlexGrid1.Cols)
            {
                col.TextAlign = TextAlignEnum.CenterCenter;
            }
            c1FlexGrid1.Cols["Description"].TextAlign = TextAlignEnum.LeftCenter;

            c1FlexGrid1.EndUpdate();
        }

        /// <summary>
        /// Load images to C1FlexGrid
        /// </summary>
        private void LoadImages()
        {
            var cars = c1NWindDataSet.Cars.AsEnumerable().ToList();

            var images = new Dictionary<byte[], Image>();
            cars.ForEach(x =>
            {
                images.Add((byte[])x["Picture"], GetImage(x));
            });
            c1FlexGrid1.Cols["Picture"].ImageMap = images;
            c1FlexGrid1.Cols["Picture"].Visible = true;
            c1FlexGrid1.Cols["Picture"].ImageAndText = false;
        }

        /// <summary>
        /// Converts DataRow image bytes to image object
        /// </summary>
        /// <param name="imgBytes">DataRow image bytes</param>
        /// <returns>image object</returns>
        private Image GetImage(DataRow row)
        {
            if (row == null) throw new ArgumentNullException();

            var imgBytes = (byte[])row["Picture"];

            var result = Image.FromStream(new MemoryStream(imgBytes));

            return result;
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
