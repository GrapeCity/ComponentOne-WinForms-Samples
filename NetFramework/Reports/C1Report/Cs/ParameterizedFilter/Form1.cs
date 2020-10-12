using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace ParameterizedFilter
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
        private C1.C1Report.C1Report _c1r;
		private System.Windows.Forms.Button _btnRender;
		private System.Windows.Forms.Label _label;
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
            this._c1r = new C1.C1Report.C1Report();
			this._btnRender = new System.Windows.Forms.Button();
			this._label = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this._c1r)).BeginInit();
			this.SuspendLayout();
			// 
			// _c1r
			// 
			this._c1r.ReportDefinition = "<!--Report *** Orders Report ***--><Report><Name>Orders Report</Name><DataSource>" +
				"<ConnectionString>Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Program Files\\" +
				"ComponentOne Studio.NET 2.0\\Common\\Nwind.mdb;Persist Security Info=False</Connection" +
				"String><RecordSource>Orders</RecordSource><Filter>ShipVia = 2</Filter></DataSour" +
				"ce><Layout><Orientation>1</Orientation></Layout><Font><Name>Arial</Name><Size>9<" +
				"/Size></Font><Groups /><Sections><Section><Name>Detail</Name><Type>0</Type><Heig" +
				"ht>250</Height></Section><Section><Name>Header</Name><Type>1</Type><Height>800</" +
				"Height></Section><Section><Name>Footer</Name><Type>2</Type><Visible>0</Visible><" +
				"/Section><Section><Name>PageHeader</Name><Type>3</Type><Height>600</Height></Sec" +
				"tion><Section><Name>PageFooter</Name><Type>4</Type><Height>500</Height></Section" +
				"></Sections><Fields><Field><Name>titleLbl</Name><Section>1</Section><Text>Orders" +
				" Report</Text><Top>200</Top><Width>9360</Width><Height>600</Height><Align>6</Ali" +
				"gn><Font><Name>Times New Roman</Name><Size>24</Size></Font></Field><Field><Name>" +
				"ftrLeft</Name><Section>4</Section><Text>Now()</Text><Calculated>-1</Calculated><" +
				"Top>30</Top><Width>4680</Width><Height>300</Height><Align>0</Align></Field><Fiel" +
				"d><Name>ftrRight</Name><Section>4</Section><Text>\"Page \" &amp; [Page] &amp; \" of" +
				" \" &amp; [Pages]</Text><Calculated>-1</Calculated><Left>4680</Left><Top>30</Top>" +
				"<Width>4680</Width><Height>300</Height><Align>2</Align></Field><Field><Name>Orde" +
				"rIDLbl</Name><Section>3</Section><Text>OrderID</Text><Top>100</Top><Width>632</W" +
				"idth><Height>400</Height><Align>3</Align><WordWrap>0</WordWrap><Font><Name>Times" +
				" New Roman</Name><Size>10</Size><Bold>-1</Bold></Font></Field><Field><Name>Order" +
				"DateLbl</Name><Section>3</Section><Text>OrderDate</Text><Left>645</Left><Top>100" +
				"</Top><Width>1054</Width><Height>400</Height><Align>3</Align><WordWrap>0</WordWr" +
				"ap><Font><Name>Times New Roman</Name><Size>10</Size><Bold>-1</Bold></Font></Fiel" +
				"d><Field><Name>ShipNameLbl</Name><Section>3</Section><Text>ShipName</Text><Left>" +
				"1713</Left><Top>100</Top><Width>1898</Width><Height>400</Height><Align>3</Align>" +
				"<WordWrap>0</WordWrap><Font><Name>Times New Roman</Name><Size>10</Size><Bold>-1<" +
				"/Bold></Font></Field><Field><Name>ShipAddressLbl</Name><Section>3</Section><Text" +
				">ShipAddress</Text><Left>3625</Left><Top>100</Top><Width>1898</Width><Height>400" +
				"</Height><Align>3</Align><WordWrap>0</WordWrap><Font><Name>Times New Roman</Name" +
				"><Size>10</Size><Bold>-1</Bold></Font></Field><Field><Name>ShipCityLbl</Name><Se" +
				"ction>3</Section><Text>ShipCity</Text><Left>5536</Left><Top>100</Top><Width>1581" +
				"</Width><Height>400</Height><Align>3</Align><WordWrap>0</WordWrap><Font><Name>Ti" +
				"mes New Roman</Name><Size>10</Size><Bold>-1</Bold></Font></Field><Field><Name>Sh" +
				"ipCountryLbl</Name><Section>3</Section><Text>ShipCountry</Text><Left>7132</Left>" +
				"<Top>100</Top><Width>1581</Width><Height>400</Height><Align>3</Align><WordWrap>0" +
				"</WordWrap><Font><Name>Times New Roman</Name><Size>10</Size><Bold>-1</Bold></Fon" +
				"t></Field><Field><Name>ShipViaLbl</Name><Section>3</Section><Text>ShipVia</Text>" +
				"<Left>8727</Left><Top>100</Top><Width>632</Width><Height>400</Height><Align>3</A" +
				"lign><WordWrap>0</WordWrap><Font><Name>Times New Roman</Name><Size>10</Size><Bol" +
				"d>-1</Bold></Font></Field><Field><Name>OrderIDCtl</Name><Section>0</Section><Tex" +
				"t>OrderID</Text><Calculated>-1</Calculated><Width>632</Width><Height>250</Height" +
				"><Align>2</Align><Font><Name>Arial</Name><Size>8</Size></Font></Field><Field><Na" +
				"me>OrderDateCtl</Name><Section>0</Section><Text>OrderDate</Text><Calculated>-1</" +
				"Calculated><Left>645</Left><Width>1054</Width><Height>250</Height><Align>0</Alig" +
				"n><Font><Name>Arial</Name><Size>8</Size></Font></Field><Field><Name>ShipNameCtl<" +
				"/Name><Section>0</Section><Text>ShipName</Text><Calculated>-1</Calculated><Left>" +
				"1713</Left><Width>1898</Width><Height>250</Height><Align>0</Align><CanGrow>-1</C" +
				"anGrow><Font><Name>Arial</Name><Size>8</Size></Font></Field><Field><Name>ShipAdd" +
				"ressCtl</Name><Section>0</Section><Text>ShipAddress</Text><Calculated>-1</Calcul" +
				"ated><Left>3625</Left><Width>1898</Width><Height>250</Height><Align>0</Align><Ca" +
				"nGrow>-1</CanGrow><Font><Name>Arial</Name><Size>8</Size></Font></Field><Field><N" +
				"ame>ShipCityCtl</Name><Section>0</Section><Text>ShipCity</Text><Calculated>-1</C" +
				"alculated><Left>5536</Left><Width>1581</Width><Height>250</Height><Align>0</Alig" +
				"n><Font><Name>Arial</Name><Size>8</Size></Font></Field><Field><Name>ShipCountryC" +
				"tl</Name><Section>0</Section><Text>ShipCountry</Text><Calculated>-1</Calculated>" +
				"<Left>7132</Left><Width>1581</Width><Height>250</Height><Align>0</Align><Font><N" +
				"ame>Arial</Name><Size>8</Size></Font></Field><Field><Name>ShipViaCtl</Name><Sect" +
				"ion>0</Section><Text>ShipVia</Text><Calculated>-1</Calculated><Left>8727</Left><" +
				"Width>632</Width><Height>250</Height><Align>2</Align><Font><Name>Arial</Name><Si" +
				"ze>8</Size></Font></Field><Field><Name>Field1</Name><Section>3</Section><Left>30" +
				"</Left><Top>540</Top><Width>9300</Width><Height>15</Height><BorderStyle>1</Borde" +
				"rStyle><LineSlant>1</LineSlant></Field><Field><Name>Field</Name><Section>4</Sect" +
				"ion><Left>15</Left><Width>9300</Width><Height>15</Height><BorderStyle>1</BorderS" +
				"tyle><LineSlant>1</LineSlant></Field></Fields></Report>";
			this._c1r.ReportName = "Orders Report";
			// 
			// _btnRender
			// 
			this._btnRender.Location = new System.Drawing.Point(8, 8);
			this._btnRender.Name = "_btnRender";
			this._btnRender.Size = new System.Drawing.Size(136, 24);
			this._btnRender.TabIndex = 0;
			this._btnRender.Text = "Show Report";
			this._btnRender.Click += new System.EventHandler(this._btnRender_Click);
			// 
			// _label
			// 
			this._label.Location = new System.Drawing.Point(8, 40);
			this._label.Name = "_label";
			this._label.Size = new System.Drawing.Size(240, 24);
			this._label.TabIndex = 1;
			this._label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(312, 70);
			this.Controls.Add(this._label);
			this.Controls.Add(this._btnRender);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "C1Report: Parameterized Filter";
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

		private void _btnRender_Click(object sender, System.EventArgs e)
		{
			// load NWind Orders table
			string sql = "select * from orders";
            string conn =
                @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" +
                Environment.GetFolderPath(Environment.SpecialFolder.Personal) +
                @"\ComponentOne Samples\Common\c1nwind.mdb";
			System.Data.OleDb.OleDbDataAdapter da = new System.Data.OleDb.OleDbDataAdapter(sql, conn);
			DataTable dt = new DataTable();
			da.Fill(dt);

			// use parameterized query mechanism to set up a filter
			string rs = _c1r.DataSource.RecordSource;
			_c1r.DataSource.RecordSource = 
				"PARAMETERS [Shipper Code] int 1;" +
				"ShipVia = [Shipper Code]";
			string filter = _c1r.DataSource.GetRecordSource(true);
			_c1r.DataSource.RecordSource = rs;

			// show resulting filter
			_label.Text = filter;

			// apply custom data source and filter to report
			_c1r.DataSource.Recordset = dt;
			_c1r.DataSource.Filter = filter;

			// show the report
            C1.Win.C1Preview.C1PrintPreviewDialog p = new C1.Win.C1Preview.C1PrintPreviewDialog();
			p.Document = _c1r;
			p.ShowDialog();
		}
	}
}
