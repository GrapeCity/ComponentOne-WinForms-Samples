using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using C1.C1Report;

namespace ProgressIndicator
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
        private C1.C1Report.C1Report _c1r;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.StatusBar _statusBar;
		private System.Windows.Forms.Label label1;
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
            CorrectConnectionString(_c1r);
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
            this._c1r = new C1.C1Report.C1Report();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this._statusBar = new System.Windows.Forms.StatusBar();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this._c1r)).BeginInit();
			this.SuspendLayout();
			// 
			// _c1r
			// 
			this._c1r.ReportDefinition = "<!--Report *** Cross-Tab ***--><Report version=\"2.5.20043.144\"><Name>Cross-Tab</N" +
				"ame><DataSource><ConnectionString>Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C" +
				":\\Program Files\\ComponentOne Studio.NET 2.0\\Common\\NWIND.MDB;Persist Security Info=F" +
				"alse</ConnectionString><RecordSource>SELECT Products.ProductName, Customers.Comp" +
				"anyName, Year([OrderDate]) AS OrderYear, Sum([Order Details].[UnitPrice]*[Order " +
				"Details].[Quantity]-[Discount]) AS SaleAmount, DatePart(\"q\",[OrderDate]) AS Orde" +
				"rQtr\r\nFROM Products INNER JOIN (Customers INNER JOIN (Orders INNER JOIN [Order D" +
				"etails] ON Orders.OrderID = [Order Details].OrderID) ON Customers.CustomerID = O" +
				"rders.CustomerID) ON Products.ProductID = [Order Details].ProductID\r\nGROUP BY Pr" +
				"oducts.ProductName, Customers.CompanyName, Year([OrderDate]), DatePart(\"q\",[Orde" +
				"rDate])\r\nORDER BY Products.ProductName, Customers.CompanyName, Year([OrderDate])" +
				";\r\n</RecordSource></DataSource><Layout><Orientation>1</Orientation></Layout><Fon" +
				"t><Name>Verdana</Name><Size>9</Size></Font><Groups><Group><Name>ProductName</Nam" +
				"e><GroupBy>ProductName</GroupBy><Sort>1</Sort><KeepTogether>2</KeepTogether></Gr" +
				"oup><Group><Name>CompanyName</Name><GroupBy>CompanyName</GroupBy><Sort>1</Sort><" +
				"KeepTogether>2</KeepTogether></Group><Group><Name>OrderYear</Name><GroupBy>Order" +
				"Year</GroupBy><Sort>2</Sort><KeepTogether>2</KeepTogether></Group></Groups><Sect" +
				"ions><Section><Name>Detail</Name><Type>0</Type><Visible>0</Visible></Section><Se" +
				"ction><Name>Header</Name><Type>1</Type><Height>800</Height><BackColor>11829830</" +
				"BackColor></Section><Section><Name>Footer</Name><Type>2</Type><Visible>0</Visibl" +
				"e></Section><Section><Name>PageHeader</Name><Type>3</Type><Visible>0</Visible></" +
				"Section><Section><Name>PageFooter</Name><Type>4</Type><Height>555</Height></Sect" +
				"ion><Section><Name>GroupHeader0</Name><Type>5</Type><Height>990</Height><Repeat>" +
				"-1</Repeat></Section><Section><Name>GroupFooter0</Name><Type>6</Type><Height>405" +
				"</Height><OnPrint>fContinued.Visible = false</OnPrint></Section><Section><Name>G" +
				"roupHeader1</Name><Type>7</Type><Visible>0</Visible><Repeat>-1</Repeat></Section" +
				"><Section><Name>GroupFooter1</Name><Type>8</Type><Visible>0</Visible></Section><" +
				"Section><Name>GroupHeader2</Name><Type>9</Type><Height>255</Height><Repeat>-1</R" +
				"epeat><OnPrint>fContinued.Visible = true</OnPrint></Section><Section><Name>Group" +
				"Footer2</Name><Type>10</Type><Visible>0</Visible></Section></Sections><Fields><F" +
				"ield><Name>titleLbl</Name><Section>1</Section><Text>Cross-Tab</Text><Top>200</To" +
				"p><Width>9360</Width><Height>600</Height><Align>6</Align><ForeColor>16777215</Fo" +
				"reColor><Font><Bold>-1</Bold><Name>Verdana</Name><Size>18</Size></Font></Field><" +
				"Field><Name>ftrLeft</Name><Section>4</Section><Text>Now()</Text><Calculated>-1</" +
				"Calculated><Top>255</Top><Width>4680</Width><Height>300</Height><Align>0</Align>" +
				"<Font><Name>Verdana</Name><Size>8.25</Size></Font></Field><Field><Name>ftrRight<" +
				"/Name><Section>4</Section><Text>\"Page \" &amp; [Page] &amp; \" of \" &amp; [Pages]<" +
				"/Text><Calculated>-1</Calculated><Left>4680</Left><Top>255</Top><Width>4680</Wid" +
				"th><Height>300</Height><Align>2</Align><Font><Name>Verdana</Name><Size>8.25</Siz" +
				"e></Font></Field><Field><Name>CompanyNameLbl</Name><Section>9</Section><Text>Com" +
				"panyName</Text><Calculated>-1</Calculated><Left>180</Left><Width>3240</Width><He" +
				"ight>255</Height><Align>0</Align><HideDuplicates>-1</HideDuplicates><WordWrap>0<" +
				"/WordWrap><Font><Name>Verdana</Name><Size>8.25</Size></Font></Field><Field><Name" +
				">OrderYearLbl</Name><Section>9</Section><Text>OrderYear</Text><Calculated>-1</Ca" +
				"lculated><Left>3510</Left><Width>990</Width><Height>255</Height><Align>0</Align>" +
				"<WordWrap>0</WordWrap><Font><Name>Verdana</Name><Size>8.25</Size></Font></Field>" +
				"<Field><Name>fSales</Name><Section>9</Section><Text>sum(SaleAmount)</Text><Calcu" +
				"lated>-1</Calculated><Format>#,##0</Format><Left>4515</Left><Width>1350</Width><" +
				"Height>255</Height><Align>2</Align><WordWrap>0</WordWrap><Font><Name>Verdana</Na" +
				"me><Size>8.25</Size></Font></Field><Field><Name>CompanyNameLbl1</Name><Section>5" +
				"</Section><Text>Customer</Text><Left>180</Left><Top>720</Top><Width>2460</Width>" +
				"<Height>255</Height><Align>3</Align><ForeColor>11119017</ForeColor><WordWrap>0</" +
				"WordWrap><Font><Bold>-1</Bold><Name>Verdana</Name><Size>9</Size></Font></Field><" +
				"Field><Name>OrderYearLbl1</Name><Section>5</Section><Text>Year</Text><Left>3420<" +
				"/Left><Top>720</Top><Width>1080</Width><Height>255</Height><Align>3</Align><Fore" +
				"Color>11119017</ForeColor><WordWrap>0</WordWrap><Font><Bold>-1</Bold><Name>Verda" +
				"na</Name><Size>9</Size></Font></Field><Field><Name>SaleAmountLbl1</Name><Section" +
				">5</Section><Text>Sales</Text><Left>4515</Left><Top>720</Top><Width>1350</Width>" +
				"<Height>255</Height><Align>5</Align><ForeColor>11119017</ForeColor><WordWrap>0</" +
				"WordWrap><Font><Bold>-1</Bold><Name>Verdana</Name><Size>9</Size></Font></Field><" +
				"Field><Name>OrderQtrLbl1</Name><Section>5</Section><Text>Q1</Text><Left>6015</Le" +
				"ft><Top>720</Top><Width>720</Width><Height>255</Height><Align>5</Align><ForeColo" +
				"r>11119017</ForeColor><WordWrap>0</WordWrap><Font><Bold>-1</Bold><Name>Verdana</" +
				"Name><Size>9</Size></Font></Field><Field><Name>ProductNameLbl1</Name><Section>5<" +
				"/Section><Text>ProductName</Text><Calculated>-1</Calculated><Top>270</Top><Width" +
				">5940</Width><Height>360</Height><Align>0</Align><WordWrap>0</WordWrap><Font><Bo" +
				"ld>-1</Bold><Name>Verdana</Name><Size>14.25</Size></Font></Field><Field><Name>Or" +
				"derQtrLbl2</Name><Section>5</Section><Text>Q2</Text><Left>6810</Left><Top>720</T" +
				"op><Width>720</Width><Height>255</Height><Align>5</Align><ForeColor>11119017</Fo" +
				"reColor><WordWrap>0</WordWrap><Font><Bold>-1</Bold><Name>Verdana</Name><Size>9</" +
				"Size></Font></Field><Field><Name>OrderQtrLbl3</Name><Section>5</Section><Text>Q3" +
				"</Text><Left>7605</Left><Top>720</Top><Width>720</Width><Height>255</Height><Ali" +
				"gn>5</Align><ForeColor>11119017</ForeColor><WordWrap>0</WordWrap><Font><Bold>-1<" +
				"/Bold><Name>Verdana</Name><Size>9</Size></Font></Field><Field><Name>OrderQtrLbl4" +
				"</Name><Section>5</Section><Text>Q4</Text><Left>8400</Left><Top>720</Top><Width>" +
				"720</Width><Height>255</Height><Align>5</Align><ForeColor>11119017</ForeColor><W" +
				"ordWrap>0</WordWrap><Font><Bold>-1</Bold><Name>Verdana</Name><Size>9</Size></Fon" +
				"t></Field><Field><Name>fQ2</Name><Section>9</Section><Text>sum(SaleAmount, Order" +
				"Qtr = 2)</Text><Calculated>-1</Calculated><Format>#,##0;#;#</Format><Left>6795</" +
				"Left><Width>720</Width><Height>255</Height><Align>2</Align><WordWrap>0</WordWrap" +
				"><Font><Name>Verdana</Name><Size>8.25</Size></Font></Field><Field><Name>fQ3</Nam" +
				"e><Section>9</Section><Text>sum(SaleAmount, OrderQtr = 3)</Text><Calculated>-1</" +
				"Calculated><Format>#,##0;#;#</Format><Left>7590</Left><Width>720</Width><Height>" +
				"255</Height><Align>2</Align><WordWrap>0</WordWrap><Font><Name>Verdana</Name><Siz" +
				"e>8.25</Size></Font></Field><Field><Name>fQ4</Name><Section>9</Section><Text>sum" +
				"(SaleAmount, OrderQtr = 4)</Text><Calculated>-1</Calculated><Format>#,##0;#;#</F" +
				"ormat><Left>8385</Left><Width>720</Width><Height>255</Height><Align>2</Align><Wo" +
				"rdWrap>0</WordWrap><Font><Name>Verdana</Name><Size>8.25</Size></Font></Field><Fi" +
				"eld><Name>fQ1</Name><Section>9</Section><Text>sum(SaleAmount, OrderQtr = 1)</Tex" +
				"t><Calculated>-1</Calculated><Format>#,##0;#;#</Format><Left>6000</Left><Width>7" +
				"20</Width><Height>255</Height><Align>2</Align><WordWrap>0</WordWrap><Font><Name>" +
				"Verdana</Name><Size>8.25</Size></Font></Field><Field><Name>Field1</Name><Section" +
				">6</Section><Width>9345</Width><BorderStyle>1</BorderStyle><BorderColor>11119017" +
				"</BorderColor><LineSlant>2</LineSlant></Field><Field><Name>Field</Name><Section>" +
				"5</Section><Top>990</Top><Width>9345</Width><BorderStyle>1</BorderStyle><BorderC" +
				"olor>11119017</BorderColor><LineSlant>2</LineSlant></Field><Field><Name>fQ</Name" +
				"><Section>6</Section><Text>sum(SaleAmount, OrderQtr = 2)</Text><Calculated>-1</C" +
				"alculated><Format>#,##0;#;#</Format><Left>6780</Left><Top>90</Top><Width>720</Wi" +
				"dth><Height>255</Height><Align>2</Align><WordWrap>0</WordWrap><Font><Bold>-1</Bo" +
				"ld><Name>Verdana</Name><Size>8.25</Size></Font></Field><Field><Name>fQ5</Name><S" +
				"ection>6</Section><Text>sum(SaleAmount, OrderQtr = 3)</Text><Calculated>-1</Calc" +
				"ulated><Format>#,##0;#;#</Format><Left>7575</Left><Top>90</Top><Width>720</Width" +
				"><Height>255</Height><Align>2</Align><WordWrap>0</WordWrap><Font><Bold>-1</Bold>" +
				"<Name>Verdana</Name><Size>8.25</Size></Font></Field><Field><Name>fQ6</Name><Sect" +
				"ion>6</Section><Text>sum(SaleAmount, OrderQtr = 4)</Text><Calculated>-1</Calcula" +
				"ted><Format>#,##0;#;#</Format><Left>8370</Left><Top>90</Top><Width>720</Width><H" +
				"eight>255</Height><Align>2</Align><WordWrap>0</WordWrap><Font><Bold>-1</Bold><Na" +
				"me>Verdana</Name><Size>8.25</Size></Font></Field><Field><Name>fQ7</Name><Section" +
				">6</Section><Text>sum(SaleAmount, OrderQtr = 1)</Text><Calculated>-1</Calculated" +
				"><Format>#,##0;#;#</Format><Left>5985</Left><Top>90</Top><Width>720</Width><Heig" +
				"ht>255</Height><Align>2</Align><WordWrap>0</WordWrap><Font><Bold>-1</Bold><Name>" +
				"Verdana</Name><Size>8.25</Size></Font></Field><Field><Name>fSales1</Name><Sectio" +
				"n>6</Section><Text>sum(SaleAmount)</Text><Calculated>-1</Calculated><Format>#,##" +
				"0</Format><Left>4500</Left><Top>90</Top><Width>1350</Width><Height>255</Height><" +
				"Align>2</Align><WordWrap>0</WordWrap><Font><Bold>-1</Bold><Name>Verdana</Name><S" +
				"ize>8.25</Size></Font></Field><Field><Name>fContinued</Name><Section>5</Section>" +
				"<Text>(continued)</Text><Left>6015</Left><Top>270</Top><Width>2610</Width><Heigh" +
				"t>345</Height><Align>0</Align><ForeColor>11119017</ForeColor><Visible>0</Visible" +
				"><WordWrap>0</WordWrap><Font><Bold>-1</Bold><Name>Verdana</Name><Size>11.25</Siz" +
				"e></Font></Field><Field><Name>Field2</Name><Section>9</Section><Left>5940</Left>" +
				"<Height>255</Height><BorderStyle>1</BorderStyle><BorderColor>11119017</BorderCol" +
				"or><LineSlant>1</LineSlant></Field><Field><Name>Field3</Name><Section>4</Section" +
				"><Top>255</Top><Width>9315</Width><BorderStyle>1</BorderStyle><LineSlant>1</Line" +
				"Slant></Field></Fields></Report>";
			this._c1r.ReportName = "Cross-Tab";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(77, 88);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(176, 24);
			this.button1.TabIndex = 0;
			this.button1.Text = "Render with Progress Form";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(77, 136);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(176, 24);
			this.button2.TabIndex = 1;
			this.button2.Text = "Render with Status Bar";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// _statusBar
			// 
			this._statusBar.Location = new System.Drawing.Point(0, 185);
			this._statusBar.Name = "_statusBar";
			this._statusBar.Size = new System.Drawing.Size(330, 22);
			this._statusBar.SizingGrip = false;
			this._statusBar.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(312, 72);
			this.label1.TabIndex = 3;
			this.label1.Text = "This sample renders a long report with an option of progress indicators. A progre" +
				"ss indicator form with a Cancel button or a simple StatusBar.";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(330, 207);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.label1,
																		  this._statusBar,
																		  this.button2,
																		  this.button1});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "C1Report: Progress Indicators";
			((System.ComponentModel.ISupportInitialize)(this._c1r)).EndInit();
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
			// prevent reentrant calls
			if (_c1r.IsBusy) return;

			// load data (to estimate page count)
			DataSource ds = _c1r.DataSource;
			OleDbDataAdapter da = new OleDbDataAdapter(ds.RecordSource, ds.ConnectionString);
			DataTable dt = new DataTable();
			da.Fill(dt);

			// pass the data on to c1report (to avoid re-loading it)
			ds.Recordset = dt;

			// estimate number of pages
			int pageCount = dt.Rows.Count / 45 + 1;

			// create progress form
			ProgressForm pf = new ProgressForm(this, _c1r, pageCount);

			// render report
			button1.Enabled = false;
			_c1r.Render();
			button1.Enabled = true;
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			// prevent reentrant calls
			if (_c1r.IsBusy) return;

			// prepare to work
			Cursor = Cursors.WaitCursor;
			button2.Enabled = false;
			_c1r.StartPage += new ReportEventHandler(_c1r_StartPage);

			// do the work
			_c1r.Render();
			_statusBar.Text = string.Empty;

			// restore app state
			_c1r.StartPage -= new ReportEventHandler(_c1r_StartPage);		
			button2.Enabled = true;
			Cursor = Cursors.Default;
		}
		private void _c1r_StartPage(object sender, ReportEventArgs e)
		{
			_statusBar.Text = string.Format("Rendering page {0} of '{1}'...",
				_c1r.Page, _c1r.ReportName);
		}
	}
}
