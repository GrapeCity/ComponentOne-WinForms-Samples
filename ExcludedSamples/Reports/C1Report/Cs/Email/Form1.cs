using System;
using System.Text;
using System.IO;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Web.Mail;

namespace Email
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private C1.C1Report.C1Report _c1r;
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
			((System.ComponentModel.ISupportInitialize)(this._c1r)).BeginInit();
			this.SuspendLayout();
			// 
			// _c1r
			// 
			this._c1r.ReportDefinition = "<!--Report *** Alphabetical List of Products ***--><Report version=\"2.5.20052.176" +
				"\"><Name>Alphabetical List of Products</Name><DataSource><ConnectionString>Provid" +
				"er=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Program Files\\ComponentOne Studio.NET 2.0\\" +
				"common\\Nwind.mdb;Persist Security Info=False</ConnectionString><RecordSource>Alp" +
				"habetical List of Products</RecordSource></DataSource><Layout><CustomWidth>12240" +
				"</CustomWidth><CustomHeight>15840</CustomHeight></Layout><Font><Name>Microsoft S" +
				"ans Serif</Name><Size>9</Size></Font><Groups><Group><Name>Group0</Name><GroupBy>" +
				"=Left([ProductName],1)</GroupBy><Sort>1</Sort><KeepTogether>1</KeepTogether></Gr" +
				"oup><Group><Name>Group1</Name><GroupBy>ProductName</GroupBy></Group></Groups><Se" +
				"ctions><Section><Name>Detail</Name><Type>0</Type><Height>375</Height></Section><" +
				"Section><Name>ReportHeader</Name><Type>1</Type><Height>855</Height></Section><Se" +
				"ction><Name>ReportFooter</Name><Type>2</Type></Section><Section><Name>PageHeader" +
				"</Name><Type>3</Type><Height>195</Height></Section><Section><Name>PageFooter</Na" +
				"me><Type>4</Type><Height>360</Height></Section><Section><Name>Group 0 Header</Na" +
				"me><Type>5</Type><Height>855</Height></Section><Section><Name>Group 0 Footer</Na" +
				"me><Type>6</Type><Height>255</Height></Section><Section><Name>Group 1 Header</Na" +
				"me><Type>7</Type><Visible>0</Visible></Section><Section><Name>Group 1 Footer</Na" +
				"me><Type>8</Type><Visible>0</Visible></Section></Sections><Fields><Field><Name>T" +
				"itle</Name><Section>1</Section><Text>Alphabetical List of Products</Text><Calcul" +
				"ated>-1</Calculated><Top>135</Top><Width>5745</Width><Height>330</Height><Font><" +
				"Bold>-1</Bold><Name>Arial</Name><Size>12</Size></Font></Field><Field><Name>DateP" +
				"rinted</Name><Section>1</Section><Text>=Format(Date(),\"Medium Date\")</Text><Calc" +
				"ulated>-1</Calculated><Top>480</Top><Width>2010</Width><Height>240</Height><Font" +
				"><Italic>-1</Italic><Name>Arial</Name><Size>8.25</Size></Font></Field><Field><Na" +
				"me>Line11</Name><Section>3</Section><Calculated>-1</Calculated><Top>105</Top><Wi" +
				"dth>9360</Width><BorderStyle>1</BorderStyle><LineSlant>1</LineSlant><Font><Name>" +
				"Arial</Name><Size>9</Size></Font></Field><Field><Name>FirstLetterofName</Name><S" +
				"ection>5</Section><Text>=Left([ProductName],1)</Text><Calculated>-1</Calculated>" +
				"<Top>30</Top><Width>1965</Width><Height>240</Height><Font><Bold>-1</Bold><Name>A" +
				"rial</Name><Size>8.25</Size></Font></Field><Field><Name>ProductNameLabel</Name><" +
				"Section>5</Section><Text>Product Name:</Text><Calculated>-1</Calculated><Left>55" +
				"5</Left><Top>495</Top><Width>1440</Width><Height>240</Height><Font><Bold>-1</Bol" +
				"d><Name>Arial</Name><Size>8.25</Size></Font></Field><Field><Name>QuantityPerUnit" +
				"Label</Name><Section>5</Section><Text>Quantity Per Unit:</Text><Calculated>-1</C" +
				"alculated><Left>5040</Left><Top>495</Top><Width>1800</Width><Height>240</Height>" +
				"<Font><Bold>-1</Bold><Name>Arial</Name><Size>8.25</Size></Font></Field><Field><N" +
				"ame>UnitsInStockLabel</Name><Section>5</Section><Text>Units In Stock:</Text><Cal" +
				"culated>-1</Calculated><Left>7830</Left><Top>495</Top><Width>1425</Width><Height" +
				">240</Height><Font><Bold>-1</Bold><Name>Arial</Name><Size>8.25</Size></Font></Fi" +
				"eld><Field><Name>CategoryNameLabel</Name><Section>5</Section><Text>Category Name" +
				":</Text><Calculated>-1</Calculated><Left>3450</Left><Top>495</Top><Width>1530</W" +
				"idth><Height>240</Height><Font><Bold>-1</Bold><Name>Arial</Name><Size>8.25</Size" +
				"></Font></Field><Field><Name>ProductName</Name><Section>0</Section><Text>Product" +
				"Name</Text><Calculated>-1</Calculated><Left>540</Left><Top>30</Top><Width>2790</" +
				"Width><Height>240</Height><Font><Name>Arial</Name><Size>8.25</Size></Font></Fiel" +
				"d><Field><Name>QuantityPerUnit</Name><Section>0</Section><Text>QuantityPerUnit</" +
				"Text><Calculated>-1</Calculated><Left>5040</Left><Top>30</Top><Width>2880</Width" +
				"><Height>240</Height><Font><Name>Arial</Name><Size>8.25</Size></Font></Field><Fi" +
				"eld><Name>UnitsInStock</Name><Section>0</Section><Text>UnitsInStock</Text><Calcu" +
				"lated>-1</Calculated><Left>8175</Left><Top>30</Top><Width>915</Width><Height>240" +
				"</Height><Font><Name>Arial</Name><Size>8.25</Size></Font></Field><Field><Name>Ca" +
				"tegoryName</Name><Section>0</Section><Text>CategoryName</Text><Calculated>-1</Ca" +
				"lculated><Left>3450</Left><Top>30</Top><Width>1440</Width><Height>240</Height><F" +
				"ont><Name>Arial</Name><Size>8.25</Size></Font></Field><Field><Name>Line9</Name><" +
				"Section>6</Section><Calculated>-1</Calculated><Top>120</Top><Width>9360</Width><" +
				"BorderStyle>1</BorderStyle><LineSlant>1</LineSlant><Font><Name>Arial</Name><Size" +
				">9</Size></Font></Field><Field><Name>PageNumber</Name><Section>4</Section><Text>" +
				"=\"Page \" &amp; [Page] &amp; \" of \" &amp; [Pages]</Text><Calculated>-1</Calculate" +
				"d><Left>7890</Left><Top>30</Top><Width>1440</Width><Height>240</Height><Align>2<" +
				"/Align><Font><Name>Arial</Name><Size>8.25</Size></Font></Field></Fields></Report" +
				">";
			this._c1r.ReportName = "Alphabetical List of Products";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(56, 8);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(176, 32);
			this.button1.TabIndex = 0;
			this.button1.Text = "Send with Html body";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(56, 48);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(176, 32);
			this.button2.TabIndex = 0;
			this.button2.Text = "Send with Html attachment";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(288, 93);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.button1,
																		  this.button2});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "C1Report: Send reports by email.";
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
			SendMessage(false);
		}
		private void button2_Click(object sender, System.EventArgs e)
		{
			SendMessage(true);
		}
		private void SendMessage(bool useAttachment)
		{
            // @"c:\temp\test\report.html";
            string fname = Path.GetTempPath() + @"\c1_report.html";

			// create message
			MailMessage msg = new MailMessage();
			msg.From = "C1Report";
			msg.To = "someone@somewhere.com";

			// add body
			if (useAttachment)
			{
				// create attachment
				_c1r.RenderToFile(fname, C1.C1Report.FileFormatEnum.HTMLDrillDown);
				MailAttachment att = new MailAttachment(fname);

				// add body
				msg.Subject = "Test HTML attachment.";
				msg.Body = "HTML report is attached.";
				msg.Attachments.Add(att);
			}
			else
			{
				// render to stream
				MemoryStream ms = new MemoryStream();
				_c1r.RenderToStream(ms, C1.C1Report.FileFormatEnum.HTMLDrillDown);
				string body = Encoding.UTF8.GetString(ms.GetBuffer());

				// add body
				msg.Subject = "Test HTML body.";
				msg.BodyFormat = MailFormat.Html;
				msg.Body = body;
			}

			// send the message
			try
			{
				SmtpMail.SmtpServer = "YOUR.SMTP.SERVER.HERE"; // << your mail server goes here
				SmtpMail.Send(msg);
				MessageBox.Show("Message sent successfully");
			}
			catch (Exception x)
			{
				MessageBox.Show(x.Message);
			}

			// clean up
			if (File.Exists(fname))
				File.Delete(fname);
		}
	}
}
