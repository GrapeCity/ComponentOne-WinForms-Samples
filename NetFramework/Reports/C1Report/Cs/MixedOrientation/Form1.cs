using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Diagnostics;

namespace MixedOrientation
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private C1.C1Report.C1Report _c1rPortrait;
        private C1.C1Report.C1Report _c1rLandscape;
		private C1.C1Pdf.C1PdfDocument _c1pdf;
		private System.Windows.Forms.Button button1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

        private void CorrectConnectionString(C1.C1Report.C1Report rep)
        {
            string cs = rep.DataSource.ConnectionString;
            if (cs == null || cs.Length <= 0)
                return;

            //
            int i = cs.IndexOf("Data Source", 0, StringComparison.OrdinalIgnoreCase);
            if (i < 0)
                return;
            while (i < cs.Length && cs[i] != '=') i++;
            if (i >= cs.Length)
                return;
            int j = i;
            while (i < cs.Length && cs[i] != ';') i++;

            //
            string mdbName = cs.Substring(j + 1, i - j - 1).Trim();
            if (mdbName.Length <= 0)
                return;
            mdbName = System.IO.Path.GetFileName(mdbName);
            if (string.Compare(mdbName, "nwind.mdb", true) == 0)
                mdbName = "c1nwind.mdb";

            //
            cs = cs.Substring(0, j + 1) +
                Environment.GetFolderPath(Environment.SpecialFolder.Personal) +
                @"\ComponentOne Samples\Common\" +
                mdbName +
                cs.Substring(i);

            rep.DataSource.ConnectionString = cs;

            //
            foreach (C1.C1Report.Field field in rep.Fields)
                if (field.Subreport != null)
                    CorrectConnectionString(field.Subreport);
        }

        public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
            CorrectConnectionString(_c1rLandscape);
            CorrectConnectionString(_c1rPortrait);
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
            this._c1rPortrait = new C1.C1Report.C1Report();
            this._c1rLandscape = new C1.C1Report.C1Report();
			this._c1pdf = new C1.C1Pdf.C1PdfDocument();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this._c1rPortrait)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._c1rLandscape)).BeginInit();
			this.SuspendLayout();
			// 
			// _c1rPortrait
			// 
			this._c1rPortrait.ReportDefinition = "<!--Report *** Portrait ***--><Report version=\"2.5.20043.144\"><Name>Portrait</Nam" +
				"e><DataSource><RecordSource>Products</RecordSource></DataSource><Layout><Orienta" +
				"tion>1</Orientation></Layout><Font><Name>Times New Roman</Name><Size>9</Size></F" +
				"ont><Groups /><Sections><Section><Name>Detail</Name><Type>0</Type><Height>3705</" +
				"Height></Section><Section><Name>Header</Name><Type>1</Type><Height>800</Height><" +
				"/Section><Section><Name>Footer</Name><Type>2</Type><Visible>0</Visible></Section" +
				"><Section><Name>PageHeader</Name><Type>3</Type><Height>600</Height></Section><Se" +
				"ction><Name>PageFooter</Name><Type>4</Type><Height>500</Height></Section></Secti" +
				"ons><Fields><Field><Name>titleLbl</Name><Section>0</Section><Text>Address</Text>" +
				"<Width>9360</Width><Height>3510</Height><Align>7</Align><ForeColor>128</ForeColo" +
				"r><Font><Bold>-1</Bold><Name>Times New Roman</Name><Size>36</Size></Font></Field" +
				"><Field><Name>ftrLeft</Name><Section>4</Section><Text>Now()</Text><Calculated>-1" +
				"</Calculated><Top>30</Top><Width>4680</Width><Height>300</Height><Align>0</Align" +
				"><Font><Name>Arial</Name><Size>9</Size></Font></Field><Field><Name>ftrRight</Nam" +
				"e><Section>4</Section><Text>\"Page \" &amp; [Page] &amp; \" of \" &amp; [Pages]</Tex" +
				"t><Calculated>-1</Calculated><Left>4680</Left><Top>30</Top><Width>4680</Width><H" +
				"eight>300</Height><Align>2</Align><Font><Name>Arial</Name><Size>9</Size></Font><" +
				"/Field><Field><Name>divLine</Name><Section>3</Section><Top>540</Top><Width>9360<" +
				"/Width><Height>60</Height><BackColor>0</BackColor><BackStyle>1</BackStyle></Fiel" +
				"d></Fields></Report>";
			this._c1rPortrait.ReportName = "Portrait";
			// 
			// _c1rLandscape
			// 
			this._c1rLandscape.ReportDefinition = "<!--Report *** Landscape ***--><Report version=\"2.5.20043.144\"><Name>Landscape</N" +
				"ame><DataSource><ConnectionString>Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C" +
				":\\Program Files\\ComponentOne Studio.Net 2.0\\common\\Nwind.mdb;Persist Security Info=Fal" +
				"se</ConnectionString><RecordSource>Products</RecordSource></DataSource><Layout><" +
				"Width>12345</Width><Orientation>2</Orientation></Layout><Font><Name>Times New Ro" +
				"man</Name><Size>9</Size></Font><Groups /><Sections><Section><Name>Detail</Name><" +
				"Type>0</Type><Height>500</Height></Section><Section><Name>Header</Name><Type>1</" +
				"Type><Height>800</Height></Section><Section><Name>Footer</Name><Type>2</Type><Vi" +
				"sible>0</Visible></Section><Section><Name>PageHeader</Name><Type>3</Type><Height" +
				">600</Height></Section><Section><Name>PageFooter</Name><Type>4</Type><Height>500" +
				"</Height></Section></Sections><Fields><Field><Name>titleLbl</Name><Section>1</Se" +
				"ction><Text>Products Report</Text><Top>200</Top><Width>9360</Width><Height>600</" +
				"Height><Align>6</Align><ForeColor>128</ForeColor><Font><Bold>-1</Bold><Name>Time" +
				"s New Roman</Name><Size>20</Size></Font></Field><Field><Name>ftrLeft</Name><Sect" +
				"ion>4</Section><Text>Now()</Text><Calculated>-1</Calculated><Top>30</Top><Width>" +
				"4680</Width><Height>300</Height><Align>0</Align><Font><Name>Arial</Name><Size>9<" +
				"/Size></Font></Field><Field><Name>ftrRight</Name><Section>4</Section><Text>\"Page" +
				" \" &amp; [Page] &amp; \" of \" &amp; [Pages]</Text><Calculated>-1</Calculated><Lef" +
				"t>7380</Left><Top>30</Top><Width>4680</Width><Height>300</Height><Align>2</Align" +
				"><Font><Name>Arial</Name><Size>9</Size></Font></Field><Field><Name>CategoryIDLbl" +
				"</Name><Section>3</Section><Text>CategoryID</Text><Top>100</Top><Width>652</Widt" +
				"h><Height>400</Height><Align>3</Align><ForeColor>128</ForeColor><WordWrap>0</Wor" +
				"dWrap><Font><Bold>-1</Bold><Name>Arial</Name><Size>10</Size></Font></Field><Fiel" +
				"d><Name>DiscontinuedLbl</Name><Section>3</Section><Text>Discontinued</Text><Left" +
				">665</Left><Top>100</Top><Width>326</Width><Height>400</Height><Align>3</Align><" +
				"ForeColor>128</ForeColor><WordWrap>0</WordWrap><Font><Bold>-1</Bold><Name>Arial<" +
				"/Name><Size>10</Size></Font></Field><Field><Name>ProductIDLbl</Name><Section>3</" +
				"Section><Text>ProductID</Text><Left>1005</Left><Top>100</Top><Width>652</Width><" +
				"Height>400</Height><Align>3</Align><ForeColor>128</ForeColor><WordWrap>0</WordWr" +
				"ap><Font><Bold>-1</Bold><Name>Arial</Name><Size>10</Size></Font></Field><Field><" +
				"Name>ProductNameLbl</Name><Section>3</Section><Text>ProductName</Text><Left>1670" +
				"</Left><Top>100</Top><Width>1956</Width><Height>400</Height><Align>3</Align><For" +
				"eColor>128</ForeColor><WordWrap>0</WordWrap><Font><Bold>-1</Bold><Name>Arial</Na" +
				"me><Size>10</Size></Font></Field><Field><Name>QuantityPerUnitLbl</Name><Section>" +
				"3</Section><Text>QuantityPerUnit</Text><Left>6340</Left><Top>100</Top><Width>195" +
				"6</Width><Height>400</Height><Align>3</Align><ForeColor>128</ForeColor><WordWrap" +
				">0</WordWrap><Font><Bold>-1</Bold><Name>Arial</Name><Size>10</Size></Font></Fiel" +
				"d><Field><Name>ReorderLevelLbl</Name><Section>3</Section><Text>ReorderLevel</Tex" +
				"t><Left>8310</Left><Top>100</Top><Width>652</Width><Height>400</Height><Align>3<" +
				"/Align><ForeColor>128</ForeColor><WordWrap>0</WordWrap><Font><Bold>-1</Bold><Nam" +
				"e>Arial</Name><Size>10</Size></Font></Field><Field><Name>SupplierIDLbl</Name><Se" +
				"ction>3</Section><Text>SupplierID</Text><Left>8976</Left><Top>100</Top><Width>65" +
				"2</Width><Height>400</Height><Align>3</Align><ForeColor>128</ForeColor><WordWrap" +
				">0</WordWrap><Font><Bold>-1</Bold><Name>Arial</Name><Size>10</Size></Font></Fiel" +
				"d><Field><Name>UnitPriceLbl</Name><Section>3</Section><Text>UnitPrice</Text><Lef" +
				"t>9641</Left><Top>100</Top><Width>1086</Width><Height>400</Height><Align>3</Alig" +
				"n><ForeColor>128</ForeColor><WordWrap>0</WordWrap><Font><Bold>-1</Bold><Name>Ari" +
				"al</Name><Size>10</Size></Font></Field><Field><Name>UnitsInStockLbl</Name><Secti" +
				"on>3</Section><Text>UnitsInStock</Text><Left>10742</Left><Top>100</Top><Width>65" +
				"2</Width><Height>400</Height><Align>3</Align><ForeColor>128</ForeColor><WordWrap" +
				">0</WordWrap><Font><Bold>-1</Bold><Name>Arial</Name><Size>10</Size></Font></Fiel" +
				"d><Field><Name>UnitsOnOrderLbl</Name><Section>3</Section><Text>UnitsOnOrder</Tex" +
				"t><Left>11407</Left><Top>100</Top><Width>652</Width><Height>400</Height><Align>3" +
				"</Align><ForeColor>128</ForeColor><WordWrap>0</WordWrap><Font><Bold>-1</Bold><Na" +
				"me>Arial</Name><Size>10</Size></Font></Field><Field><Name>CategoryIDCtl</Name><S" +
				"ection>0</Section><Text>CategoryID</Text><Calculated>-1</Calculated><Top>100</To" +
				"p><Width>652</Width><Height>300</Height><Align>2</Align></Field><Field><Name>Dis" +
				"continuedCtl</Name><Section>0</Section><Text>Discontinued</Text><Calculated>-1</" +
				"Calculated><Left>665</Left><Top>100</Top><Width>326</Width><Height>300</Height><" +
				"Align>0</Align></Field><Field><Name>ProductIDCtl</Name><Section>0</Section><Text" +
				">ProductID</Text><Calculated>-1</Calculated><Left>1005</Left><Top>100</Top><Widt" +
				"h>652</Width><Height>300</Height><Align>2</Align></Field><Field><Name>ProductNam" +
				"eCtl</Name><Section>0</Section><Text>ProductName</Text><Calculated>-1</Calculate" +
				"d><Left>1665</Left><Top>105</Top><Width>4635</Width><Height>300</Height><Align>0" +
				"</Align><CanGrow>-1</CanGrow></Field><Field><Name>QuantityPerUnitCtl</Name><Sect" +
				"ion>0</Section><Text>QuantityPerUnit</Text><Calculated>-1</Calculated><Left>6340" +
				"</Left><Top>100</Top><Width>1956</Width><Height>300</Height><Align>0</Align><Can" +
				"Grow>-1</CanGrow></Field><Field><Name>ReorderLevelCtl</Name><Section>0</Section>" +
				"<Text>ReorderLevel</Text><Calculated>-1</Calculated><Left>8310</Left><Top>100</T" +
				"op><Width>652</Width><Height>300</Height><Align>2</Align></Field><Field><Name>Su" +
				"pplierIDCtl</Name><Section>0</Section><Text>SupplierID</Text><Calculated>-1</Cal" +
				"culated><Left>8976</Left><Top>100</Top><Width>652</Width><Height>300</Height><Al" +
				"ign>2</Align></Field><Field><Name>UnitPriceCtl</Name><Section>0</Section><Text>U" +
				"nitPrice</Text><Calculated>-1</Calculated><Left>9641</Left><Top>100</Top><Width>" +
				"1086</Width><Height>300</Height><Align>2</Align></Field><Field><Name>UnitsInStoc" +
				"kCtl</Name><Section>0</Section><Text>UnitsInStock</Text><Calculated>-1</Calculat" +
				"ed><Left>10742</Left><Top>100</Top><Width>652</Width><Height>300</Height><Align>" +
				"2</Align></Field><Field><Name>UnitsOnOrderCtl</Name><Section>0</Section><Text>Un" +
				"itsOnOrder</Text><Calculated>-1</Calculated><Left>11407</Left><Top>100</Top><Wid" +
				"th>652</Width><Height>300</Height><Align>2</Align></Field><Field><Name>divLine</" +
				"Name><Section>3</Section><Top>540</Top><Width>12210</Width><Height>60</Height><B" +
				"ackColor>0</BackColor><BackStyle>1</BackStyle></Field></Fields></Report>";
			this._c1rLandscape.ReportName = "Landscape";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(16, 16);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(160, 48);
			this.button1.TabIndex = 0;
			this.button1.Text = "Go";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(192, 77);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.button1});
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this._c1rPortrait)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._c1rLandscape)).EndInit();
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

		private void button1_Click(object sender, System.EventArgs e)
		{
			// render both reports to generate PageImages collections
			_c1rPortrait.Render();
			_c1rLandscape.Render();

			// start a new pdf document
			_c1pdf.Clear();
			int cnt = 0;

			// add portrait pages
			_c1pdf.PaperKind = PaperKind.Letter;
			foreach (Image img in _c1rPortrait.PageImages)
			{
				if (cnt > 0) _c1pdf.NewPage();
				_c1pdf.Landscape = false;
				_c1pdf.DrawImage(img, _c1pdf.PageRectangle);
				cnt++;
			}

			// add landscape pages
			foreach (Image img in _c1rLandscape.PageImages)
			{
				if (cnt > 0) _c1pdf.NewPage();
				_c1pdf.Landscape = true;
				_c1pdf.DrawImage(img, _c1pdf.PageRectangle);
				cnt++;
			}

			// save the document
            string appPath = Application.StartupPath + "\\mixed.pdf";
			_c1pdf.Save(appPath);

            DialogResult dr = MessageBox.Show("Resulting sample pdf found at:\r\n\r\n" +
                appPath + "\r\n\r\nDo you wish to launch?", "", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                Process p = new Process();
                p.StartInfo.FileName = appPath;
                p.Start();
            }
		}

		// this method is not used in this project, but it can be useful
		// in case you don't know the image dimensions beforehand and need
		// to calculate them based on the images themselves, e.g.
		//    c1pdf.PageSize = GetImageSize(img);
		//    c1pdf.DrawImage(img, c1pdf.PageRectangle);
		private SizeF GetImageSize(Image img)
		{
			// get image size in pixels
			SizeF sz = img.Size;

			// convert to inches
			sz.Width  /= img.HorizontalResolution;
			sz.Height /= img.VerticalResolution;

			// convert to points
			sz.Width  *= 72f;
			sz.Height *= 72f;

			// done
			return sz;
		}
	}
}
