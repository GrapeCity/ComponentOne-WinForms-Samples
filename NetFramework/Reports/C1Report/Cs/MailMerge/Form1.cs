using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace MailMerge
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private C1.C1Report.C1Report c1Report1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
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
			this.button2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.c1Report1)).BeginInit();
			this.SuspendLayout();
			// 
			// c1Report1
			// 
			this.c1Report1.ReportDefinition = "<!--Report *** Mail Merge ***--><Report version=\"2.5.20051.166\"><Name>Mail Merge<" +
				"/Name><DataSource><ConnectionString>Provider=Microsoft.Jet.OLEDB.4.0;Data Source" +
				"=C:\\Program Files\\ComponentOne Studio.NET 2.0\\Common\\NWIND.MDB;Persist Security Info" +
				"=False</ConnectionString><RecordSource>Customers</RecordSource></DataSource><Lay" +
				"out><Width>9375</Width><Orientation>1</Orientation></Layout><Font><Name>Arial</N" +
				"ame><Size>8</Size></Font><Groups /><Sections><Section><Name>Detail</Name><Type>0" +
				"</Type><Height>4875</Height><ForcePageBreak>2</ForcePageBreak></Section><Section" +
				"><Name>Header</Name><Type>1</Type></Section><Section><Name>Footer</Name><Type>2<" +
				"/Type><Visible>0</Visible></Section><Section><Name>PageHeader</Name><Type>3</Typ" +
				"e><Height>870</Height></Section><Section><Name>PageFooter</Name><Type>4</Type><H" +
				"eight>500</Height></Section></Sections><Fields><Field><Name>titleLbl</Name><Sect" +
				"ion>3</Section><Text>NorthWind Corporate Relations</Text><Top>45</Top><Width>936" +
				"0</Width><Height>600</Height><Align>6</Align><Font><Name>Times New Roman</Name><" +
				"Size>24</Size></Font></Field><Field><Name>Field1</Name><Section>0</Section><Text" +
				">\"Dear \" &amp; ContactName &amp; \",\"</Text><Calculated>-1</Calculated><Left>90</" +
				"Left><Top>180</Top><Width>3780</Width><Height>270</Height></Field><Field><Name>F" +
				"ield2</Name><Section>0</Section><Text>\"We are very happy here at NorthWind to ha" +
				"ve customers like you. We have been doing business for a long time now and feel " +
				"that our relationship has been growing stronger all this time. In fact, \" &amp; " +
				"CompanyName &amp; \" is now our #1 customer.\"</Text><Calculated>-1</Calculated><L" +
				"eft>90</Left><Top>660</Top><Width>9180</Width><Height>510</Height></Field><Field" +
				"><Name>Field3</Name><Section>0</Section><Text>As a token of our appreciation, we" +
				" would like to offer you a gift. Just check into our site at www.nw.com/gift and" +
				" enter your customer ID. Then select up to two thousand dollars in merchandise a" +
				"nd we will send it to you free of charge.</Text><Left>90</Left><Top>1350</Top><W" +
				"idth>9180</Width><Height>510</Height></Field><Field><Name>Field4</Name><Section>" +
				"0</Section><Text>We count on your continuing support in 2005 and beyond.</Text><" +
				"Left>90</Left><Top>2070</Top><Width>9180</Width><Height>510</Height></Field><Fie" +
				"ld><Name>Field6</Name><Section>0</Section><Left>6300</Left><Top>3150</Top><Width" +
				">2970</Width><Height>990</Height><ZOrder>-1</ZOrder><Picture encoding=\"base64\">i" +
				"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" +
				"AAAAElFTkSuQmCC</Picture><PictureAlign>11</PictureAlign></Field><Field><Name>Fie" +
				"ld5</Name><Section>0</Section><Text>Sincerely yours,\r\nMargaret Atwood\r\nNW Corpor" +
				"ate Relations</Text><Left>90</Left><Top>3885</Top><Width>9180</Width><Height>720" +
				"</Height><Align>2</Align></Field></Fields></Report>";
			this.c1Report1.ReportName = "Mail Merge";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(8, 16);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(136, 40);
			this.button1.TabIndex = 1;
			this.button1.Text = "Load All Into Memory";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(152, 16);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(136, 40);
			this.button2.TabIndex = 1;
			this.button2.Text = "Load One At A Time";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(296, 69);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.button1,
																		  this.button2});
			this.Name = "Form1";
			this.Text = "Form1";
			//this.Load += new System.EventHandler(this.Form1_Load);
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

		private void button1_Click(object sender, System.EventArgs e)
		{
			string sql = "select * from customers";
			string conn = 
                @"provider=microsoft.jet.oledb.4.0;data source=" + 
                Environment.GetFolderPath(Environment.SpecialFolder.Personal) +
                @"\ComponentOne Samples\Common\c1nwind.mdb;";
			OleDbDataAdapter da = new OleDbDataAdapter(sql, conn);
			DataTable dt = new DataTable();
			da.Fill(dt);

			int cnt = 1;
			this.c1Report1.DataSource.Recordset = dt.DefaultView;
			for (int i = 0; i < 100; i++)
			{
				foreach (DataRow dr in dt.Rows)
				{
					string id = (string)dr["CustomerID"];
					dt.DefaultView.RowFilter = string.Format("CustomerID = '{0}'", id);
					string fn = string.Format(@"c:\{0}.pdf", id);

					DateTime start = DateTime.Now;
					this.c1Report1.RenderToFile(fn, C1.C1Report.FileFormatEnum.PDF);
					TimeSpan ts = DateTime.Now.Subtract(start);
					Console.WriteLine("loop {2} -- {0}: {1}", cnt++, ts.TotalMilliseconds, i);
				}
			}
			Console.WriteLine("** DONE");
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			string sql = "select * from customers";
			string conn =
                @"provider=microsoft.jet.oledb.4.0;data source=" + 
                Environment.GetFolderPath(Environment.SpecialFolder.Personal) +
                @"\ComponentOne Samples\Common\c1nwind.mdb;";
			OleDbDataAdapter da = new OleDbDataAdapter(sql, conn);
			DataTable dt = new DataTable();
			da.Fill(dt);

			int cnt = 1;
			for (int i = 0; i < 100; i++)
			{
				foreach (DataRow dr in dt.Rows)
				{
					string id = (string)dr["CustomerID"];
					string fn = string.Format(@"c:\{0}.pdf", id);

					DateTime start = DateTime.Now;
					this.c1Report1.DataSource.RecordSource = string.Format("select * from customers where CustomerID = '{0}'", id);
					this.c1Report1.RenderToFile(fn, C1.C1Report.FileFormatEnum.PDF);
					TimeSpan ts = DateTime.Now.Subtract(start);
                    Console.WriteLine("loop {2} -- {0}: {1}", cnt++, ts.TotalMilliseconds, i);
				}
			}
			Console.WriteLine("** DONE");
		}
	}
}
