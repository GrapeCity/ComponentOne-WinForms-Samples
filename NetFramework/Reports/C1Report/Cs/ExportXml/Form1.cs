using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace ExportXml
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
        private C1.C1Report.C1Report _c1r;
		private System.Windows.Forms.Button button3;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

        private void CorrectConnectionString(C1.C1Report.C1Report rep)
        {
            string cs = rep.DataSource.ConnectionString;

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
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
            this._c1r = new C1.C1Report.C1Report();
			this.button3 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this._c1r)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.button1.Location = new System.Drawing.Point(8, 8);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(224, 40);
			this.button1.TabIndex = 0;
			this.button1.Text = "Show Report";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.button2.Location = new System.Drawing.Point(8, 56);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(224, 40);
			this.button2.TabIndex = 0;
			this.button2.Text = "Export to Xml (values as attributes)";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// _c1r
			// 
			this._c1r.ReportDefinition = "<!--Report *** Alphabetical List of Products ***--><Report version=\"2.5.20043.144" +
				"\"><Name>Alphabetical List of Products</Name><DataSource><ConnectionString>Provid" +
                "er=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Program Files\\ComponentOne Studio.NET 2.0\\" +
                "Common\\Nwind.mdb;Persist Security Info=False</ConnectionString><RecordSource>Alpha" +
				"betical List of Products</RecordSource></DataSource><Layout /><Font><Name>Arial<" +
				"/Name><Size>9</Size></Font><Groups><Group><Name>Group0</Name><GroupBy>=Left([Pro" +
				"ductName],1)</GroupBy><Sort>1</Sort><KeepTogether>1</KeepTogether></Group><Group" +
				"><Name>Group1</Name><GroupBy>ProductName</GroupBy></Group></Groups><Sections><Se" +
				"ction><Name>Detail</Name><Type>0</Type><Height>375</Height></Section><Section><N" +
				"ame>ReportHeader</Name><Type>1</Type><Height>855</Height></Section><Section><Nam" +
				"e>ReportFooter</Name><Type>2</Type></Section><Section><Name>PageHeader</Name><Ty" +
				"pe>3</Type><Height>195</Height></Section><Section><Name>PageFooter</Name><Type>4" +
				"</Type><Height>360</Height></Section><Section><Name>Group 0 Header</Name><Type>5" +
				"</Type><Height>855</Height></Section><Section><Name>Group 0 Footer</Name><Type>6" +
				"</Type><Height>255</Height></Section><Section><Name>Group 1 Header</Name><Type>7" +
				"</Type><Visible>0</Visible></Section><Section><Name>Group 1 Footer</Name><Type>8" +
				"</Type><Visible>0</Visible></Section></Sections><Fields><Field><Name>Title</Name" +
				"><Section>1</Section><Text>Alphabetical List of Products</Text><Top>135</Top><Wi" +
				"dth>5745</Width><Height>330</Height><Font><Bold>-1</Bold><Name>Microsoft Sans Se" +
				"rif</Name><Size>12</Size></Font></Field><Field><Name>DatePrinted</Name><Section>" +
				"1</Section><Text>=Format(Date(),\"Medium Date\")</Text><Calculated>-1</Calculated>" +
				"<Top>480</Top><Width>2010</Width><Height>240</Height><BackColor>16777215</BackCo" +
				"lor><BackStyle>1</BackStyle><Font><Italic>-1</Italic><Name>Microsoft Sans Serif<" +
				"/Name><Size>8.25</Size></Font></Field><Field><Name>Line11</Name><Section>3</Sect" +
				"ion><Top>105</Top><Width>9360</Width><BorderStyle>1</BorderStyle><LineSlant>1</L" +
				"ineSlant><Font><Name>Microsoft Sans Serif</Name><Size>9</Size></Font></Field><Fi" +
				"eld><Name>FirstLetterofName</Name><Section>5</Section><Text>=Left([ProductName]," +
				"1)</Text><Calculated>-1</Calculated><Top>30</Top><Width>1965</Width><Height>240<" +
				"/Height><BackColor>16777215</BackColor><BackStyle>1</BackStyle><Font><Bold>-1</B" +
				"old><Name>Microsoft Sans Serif</Name><Size>8.25</Size></Font></Field><Field><Nam" +
				"e>ProductNameLabel</Name><Section>5</Section><Text>Product Name:</Text><Left>555" +
				"</Left><Top>495</Top><Width>2625</Width><Height>240</Height><Font><Bold>-1</Bold" +
				"><Name>Microsoft Sans Serif</Name><Size>8.25</Size></Font></Field><Field><Name>Q" +
				"uantityPerUnitLabel</Name><Section>5</Section><Text>Quantity Per Unit:</Text><Le" +
				"ft>5040</Left><Top>495</Top><Width>2385</Width><Height>240</Height><Font><Bold>-" +
				"1</Bold><Name>Microsoft Sans Serif</Name><Size>8.25</Size></Font></Field><Field>" +
				"<Name>UnitsInStockLabel</Name><Section>5</Section><Text>Units In Stock:</Text><L" +
				"eft>8010</Left><Top>495</Top><Width>1305</Width><Height>240</Height><Font><Bold>" +
				"-1</Bold><Name>Microsoft Sans Serif</Name><Size>8.25</Size></Font></Field><Field" +
				"><Name>CategoryNameLabel</Name><Section>5</Section><Text>Category Name:</Text><L" +
				"eft>3450</Left><Top>495</Top><Width>1545</Width><Height>240</Height><Font><Bold>" +
				"-1</Bold><Name>Microsoft Sans Serif</Name><Size>8.25</Size></Font></Field><Field" +
				"><Name>ProductName</Name><Section>0</Section><Text>ProductName</Text><Calculated" +
				">-1</Calculated><Left>540</Left><Top>30</Top><Width>2790</Width><Height>240</Hei" +
				"ght><BackColor>16777215</BackColor><BackStyle>1</BackStyle><Font><Name>Microsoft" +
				" Sans Serif</Name><Size>8.25</Size></Font></Field><Field><Name>QuantityPerUnit</" +
				"Name><Section>0</Section><Text>QuantityPerUnit</Text><Calculated>-1</Calculated>" +
				"<Left>5040</Left><Top>30</Top><Width>2880</Width><Height>240</Height><BackColor>" +
				"16777215</BackColor><BackStyle>1</BackStyle><Font><Name>Microsoft Sans Serif</Na" +
				"me><Size>8.25</Size></Font></Field><Field><Name>UnitsInStock</Name><Section>0</S" +
				"ection><Text>UnitsInStock</Text><Calculated>-1</Calculated><Left>8175</Left><Top" +
				">30</Top><Width>915</Width><Height>240</Height><BackColor>16777215</BackColor><B" +
				"ackStyle>1</BackStyle><Font><Name>Microsoft Sans Serif</Name><Size>8.25</Size></" +
				"Font></Field><Field><Name>CategoryName</Name><Section>0</Section><Text>CategoryN" +
				"ame</Text><Calculated>-1</Calculated><Left>3450</Left><Top>30</Top><Width>1440</" +
				"Width><Height>240</Height><BackColor>16777215</BackColor><BackStyle>1</BackStyle" +
				"><Font><Name>Microsoft Sans Serif</Name><Size>8.25</Size></Font></Field><Field><" +
				"Name>Line9</Name><Section>6</Section><Top>120</Top><Width>9360</Width><BorderSty" +
				"le>1</BorderStyle><LineSlant>1</LineSlant><Font><Name>Microsoft Sans Serif</Name" +
				"><Size>9</Size></Font></Field><Field><Name>PageNumber</Name><Section>4</Section>" +
				"<Text>=\"Page \" &amp; [Page] &amp; \" of \" &amp; [Pages]</Text><Calculated>-1</Cal" +
				"culated><Left>7890</Left><Top>30</Top><Width>1440</Width><Height>240</Height><Al" +
				"ign>2</Align><BackColor>16777215</BackColor><BackStyle>1</BackStyle><Font><Name>" +
				"Microsoft Sans Serif</Name><Size>8.25</Size></Font></Field></Fields></Report>";
			this._c1r.ReportName = "Alphabetical List of Products";
			// 
			// button3
			// 
			this.button3.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.button3.Location = new System.Drawing.Point(8, 104);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(224, 40);
			this.button3.TabIndex = 0;
			this.button3.Text = "Export to Xml (values as content)";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(240, 151);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.button1,
																		  this.button2,
																		  this.button3});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "C1Report: Export to xml";
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
            C1.Win.C1Preview.C1PrintPreviewDialog p = new C1.Win.C1Preview.C1PrintPreviewDialog();
			p.Document = _c1r;
			p.ShowDialog();
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			// create export filter
			string fileName = Application.StartupPath + @"\report.xml";
			XmlFilter f = new XmlFilter(fileName);
			f.ValuesAsAttributes = true;

			// render report to filter
			_c1r.RenderToFilter(f);
			
			// show exported report
			System.Diagnostics.Process.Start(fileName);
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			// create export filter
			string fileName = Application.StartupPath + @"\report.xml";
			XmlFilter f = new XmlFilter(fileName);
			f.ValuesAsAttributes = false;

			// render report to filter
			_c1r.RenderToFilter(f);
			
			// show exported report
			System.Diagnostics.Process.Start(fileName);
		}
	}
}
