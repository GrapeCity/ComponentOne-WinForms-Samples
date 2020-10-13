using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace ReportDictionary
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
        private C1.C1Report.C1Report c1Report1;
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
            CorrectConnectionString(c1Report1);
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
            this.c1Report1 = new C1.C1Report.C1Report();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.c1Report1)).BeginInit();
			this.SuspendLayout();
			// 
			// c1Report1
			// 
			this.c1Report1.ReportDefinition = "<!--Report *** Products Report ***--><Report version=\"2.5.20053.188\"><Name>Produc" +
				"ts Report</Name><DataSource><ConnectionString>Provider=Microsoft.Jet.OLEDB.4.0;D" +
				"ata Source=C:\\Program Files\\ComponentOne Studio.NET 2.0\\Common\\NWIND.MDB;Persist Sec" +
				"urity Info=False</ConnectionString><RecordSource>Products</RecordSource></DataSo" +
				"urce><Layout><Orientation>1</Orientation></Layout><Font><Name>Verdana</Name><Siz" +
				"e>8.25</Size></Font><Groups><Group><Name>CategoryID</Name><GroupBy>CategoryID</G" +
				"roupBy><Sort>1</Sort></Group></Groups><Sections><Section><Name>Detail</Name><Typ" +
				"e>0</Type><Height>300</Height></Section><Section><Name>Header</Name><Type>1</Typ" +
				"e><Height>800</Height><BackColor>14480885</BackColor></Section><Section><Name>Fo" +
				"oter</Name><Type>2</Type><Visible>0</Visible></Section><Section><Name>PageHeader" +
				"</Name><Type>3</Type><Height>600</Height></Section><Section><Name>PageFooter</Na" +
				"me><Type>4</Type><Height>500</Height></Section><Section><Name>CategoryID_Header<" +
				"/Name><Type>5</Type><Height>1080</Height></Section><Section><Name>CategoryID_Foo" +
				"ter</Name><Type>6</Type><Visible>0</Visible></Section></Sections><Fields><Field>" +
				"<Name>titleLbl</Name><Section>1</Section><Text>Products Report</Text><Top>200</T" +
				"op><Width>9360</Width><Height>600</Height><Align>6</Align><ForeColor>9125192</Fo" +
				"reColor><Font><Bold>-1</Bold><Name>Verdana</Name><Size>18</Size></Font></Field><" +
				"Field><Name>ftrLeft</Name><Section>4</Section><Text>Now()</Text><Calculated>-1</" +
				"Calculated><Top>30</Top><Width>4680</Width><Height>300</Height><Align>0</Align><" +
				"Font><Name>Arial</Name><Size>9</Size></Font></Field><Field><Name>ftrRight</Name>" +
				"<Section>4</Section><Text>\"Page \" &amp; [Page] &amp; \" of \" &amp; [Pages]</Text>" +
				"<Calculated>-1</Calculated><Left>4680</Left><Top>30</Top><Width>4680</Width><Hei" +
				"ght>300</Height><Align>2</Align><Font><Name>Arial</Name><Size>9</Size></Font></F" +
				"ield><Field><Name>ProductNameLbl</Name><Section>5</Section><Text>ProductName</Te" +
				"xt><Top>675</Top><Width>2880</Width><Height>405</Height><Align>3</Align><ForeCol" +
				"or>9125192</ForeColor><WordWrap>0</WordWrap><Font><Bold>-1</Bold><Name>Verdana</" +
				"Name><Size>9</Size></Font></Field><Field><Name>QuantityPerUnitLbl</Name><Section" +
				">5</Section><Text>QuantityPerUnit</Text><Left>2895</Left><Top>675</Top><Width>28" +
				"80</Width><Height>405</Height><Align>3</Align><ForeColor>9125192</ForeColor><Wor" +
				"dWrap>0</WordWrap><Font><Bold>-1</Bold><Name>Verdana</Name><Size>9</Size></Font>" +
				"</Field><Field><Name>UnitPriceLbl</Name><Section>5</Section><Text>UnitPrice</Tex" +
				"t><Left>5805</Left><Top>675</Top><Width>1035</Width><Height>405</Height><Align>5" +
				"</Align><ForeColor>9125192</ForeColor><WordWrap>0</WordWrap><Font><Bold>-1</Bold" +
				"><Name>Verdana</Name><Size>9</Size></Font></Field><Field><Name>SupplierIDLbl</Na" +
				"me><Section>5</Section><Text>SupplierID</Text><Left>6975</Left><Top>675</Top><Wi" +
				"dth>2145</Width><Height>405</Height><Align>3</Align><ForeColor>9125192</ForeColo" +
				"r><WordWrap>0</WordWrap><Font><Bold>-1</Bold><Name>Verdana</Name><Size>9</Size><" +
				"/Font></Field><Field><Name>ProductNameCtl</Name><Section>0</Section><Text>Produc" +
				"tName</Text><Calculated>-1</Calculated><Width>2880</Width><Height>300</Height><A" +
				"lign>0</Align><CanGrow>-1</CanGrow></Field><Field><Name>QuantityPerUnitCtl</Name" +
				"><Section>0</Section><Text>QuantityPerUnit</Text><Calculated>-1</Calculated><Lef" +
				"t>2900</Left><Width>2880</Width><Height>300</Height><Align>0</Align><CanGrow>-1<" +
				"/CanGrow></Field><Field><Name>UnitPriceCtl</Name><Section>0</Section><Text>UnitP" +
				"rice</Text><Calculated>-1</Calculated><Format>Currency</Format><Left>5805</Left>" +
				"<Width>1035</Width><Height>300</Height><Align>2</Align></Field><Field><Name>Supp" +
				"lierIDCtl</Name><Section>0</Section><Text>LookUp.GetValue(\"Supplier\", SupplierID" +
				")</Text><Calculated>-1</Calculated><Left>6975</Left><Width>2145</Width><Height>3" +
				"00</Height><Align>0</Align></Field><Field><Name>divLine</Name><Section>3</Sectio" +
				"n><Top>585</Top><Width>9360</Width><Height>15</Height><BackColor>13458026</BackC" +
				"olor><BackStyle>1</BackStyle></Field><Field><Name>Field1</Name><Section>5</Secti" +
				"on><Text>LookUp.GetValue(\"Category\", CategoryID)</Text><Calculated>-1</Calculate" +
				"d><Width>5985</Width><Height>420</Height><Align>3</Align><ForeColor>9125192</For" +
				"eColor><Font><Bold>-1</Bold><Name>Verdana</Name><Size>9</Size></Font></Field></F" +
				"ields></Report>";
			this.c1Report1.ReportName = "Products Report";
			this.c1Report1.StartReport += new System.EventHandler(this.c1Report1_StartReport);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(8, 16);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(288, 32);
			this.button1.TabIndex = 0;
			this.button1.Text = "Show Report";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(304, 69);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.button1});
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "C1Report: Custom Report Dictionary";
			((System.ComponentModel.ISupportInitialize)(this.c1Report1)).EndInit();
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

		// show the report when the user clicks the button
		private void button1_Click(object sender, System.EventArgs e)
		{
            C1.Win.C1Preview.C1PrintPreviewDialog dlg = new C1.Win.C1Preview.C1PrintPreviewDialog();
			dlg.Document = this.c1Report1;
			dlg.ShowDialog();
		}

		// add LookUp object to report's scripting context
		private void c1Report1_StartReport(object sender, System.EventArgs e)
		{
			c1Report1.AddScriptObject("LookUp", new LookUpObject());
		}
	}

	/// <summary>
	/// Class used to perform lookups on report values
	/// </summary>
	public class LookUpObject
	{
		private static Hashtable _suppliers = new Hashtable();
		private static Hashtable _categories = new Hashtable();

		static LookUpObject()
		{
			// initialize lookup lists
			_suppliers[1] = "IBM";
			_suppliers[2] = "Microsoft";
			_suppliers[3] = "Symantec";
			_suppliers[4] = "Adobe";
			_suppliers[5] = "Computer Associates";
			_suppliers[6] = "ComponentOne";

			_categories[1] = "Beverages";
			_categories[2] = "Condiments";
			_categories[3] = "Confections";
			_categories[4] = "Dairy Products";
			_categories[5] = "Grains/Cereals";
			_categories[6] = "Meat/Poultry";
			_categories[7] = "Seafood";
		}

		// main function: note that numeric parameters should be double
		// to work with the script engine
		public string GetValue(string category, double value)
		{
			category = category.ToLower();

			string retVal = null;
			if (category == "supplier")
			{
				retVal = _suppliers[(int)value] as string;
			}
			else if (category == "category")
			{
				retVal = _categories[(int)value] as string;
			}

			return (retVal != null)? retVal: "Other";
		}
	}
}
