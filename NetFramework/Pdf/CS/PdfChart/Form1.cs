using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using C1.Win.C1Chart;
using C1.C1Pdf;

namespace PdfChart
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button button1;
		private C1.Win.C1Chart.C1Chart _c1c;
		private C1.C1Pdf.C1PdfDocument _pdf;
        private Button button2;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this._c1c = new C1.Win.C1Chart.C1Chart();
            this.button1 = new System.Windows.Forms.Button();
            this._pdf = new C1.C1Pdf.C1PdfDocument();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._c1c)).BeginInit();
            this.SuspendLayout();
            // 
            // _c1c
            // 
            this._c1c.Dock = System.Windows.Forms.DockStyle.Fill;
            this._c1c.Location = new System.Drawing.Point(0, 45);
            this._c1c.Name = "_c1c";
            this._c1c.PropBag = resources.GetString("_c1c.PropBag");
            this._c1c.Size = new System.Drawing.Size(560, 312);
            this._c1c.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 24);
            this.button1.TabIndex = 1;
            this.button1.Text = "Convert to Pdf (regular)";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(175, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 24);
            this.button2.TabIndex = 1;
            this.button2.Text = "Convert to Pdf (high-res)";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(560, 357);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this._c1c);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(0, 45, 0, 0);
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this._c1c)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			// get chart data
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string conn = string.Format(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0}\ComponentOne Samples\Common\C1NWind.mdb;", path);
			string sql = "select * from products";
			OleDbDataAdapter da = new OleDbDataAdapter(sql, conn);
			DataTable dt = new DataTable();
			da.Fill(dt);

			// sort and filter data
			DataView data = dt.DefaultView;
			data.Sort = "UnitPrice";
			data.RowFilter = "CategoryID = 1"; // beverages

			// configure chart
			_c1c.Reset();
			_c1c.Font = new Font("Tahoma", 8);
			_c1c.BackColor = Color.White;
			_c1c.ChartGroups[0].ChartType = Chart2DTypeEnum.Pie;

			// get series collection (pies have one series per slice)
			ChartDataSeriesCollection 
				dscoll = _c1c.ChartGroups[0].ChartData.SeriesList;
			dscoll.Clear();

			// populate the series
			for (int i = 0; i < data.Count; i++)
			{
				ChartDataSeries series = dscoll.AddNewSeries();
				series.PointData.Length = 1;
				series.Y[0] = data[i]["UnitPrice"];
				series.Label = string.Format("{0} ({1:c})",
					data[i]["ProductName"], data[i]["UnitPrice"]);
			}

			// show pie legend
			_c1c.Legend.Visible = true;
			_c1c.Legend.Text = "Product Unit Prices";
		}
		private void button1_Click(object sender, System.EventArgs e)
		{
            Image img = _c1c.GetImage(ImageFormat.Emf);
            CreatePdf(img);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Image img = GetHighResMetafile(_c1c);
            CreatePdf(img);
        }
        private void CreatePdf(Image img)
        {
            // export to pdf
            _pdf.Clear();
            RectangleF rc = _pdf.PageRectangle;
            rc.Inflate(-72, -72); // << 1" margin
            _pdf.DrawImage(img, rc, ContentAlignment.MiddleCenter, ImageSizeModeEnum.Scale);
            string fileName = Application.StartupPath + @"\pie.pdf";
            _pdf.Save(fileName);

            // show pdf
            System.Diagnostics.Process.Start(fileName);
        }

        // create metafile using high-res reference hdc (printer-based)
        private Image GetHighResMetafile(C1.Win.C1Chart.C1Chart chart)
        {
            Metafile meta = null;

            // get high-res reference dc
            using (PrintDocument doc = new PrintDocument())
            using (Graphics gref = doc.PrinterSettings.CreateMeasurementGraphics())
            {
                // create metafile
                IntPtr hdc = gref.GetHdc();
                meta = new Metafile(hdc, EmfType.EmfOnly, "test");

                // draw chart into metafile
                using (Graphics g = Graphics.FromImage(meta))
                    chart.Draw(g, new Rectangle(Point.Empty, chart.Size));
                gref.ReleaseHdc(hdc);
            }

            // done
            return meta;
        }
	}
}
