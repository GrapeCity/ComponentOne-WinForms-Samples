using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Test
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView lviMessages;
        private System.Windows.Forms.TreeView trvFolders;
        private System.Windows.Forms.Label lblFolders;
        private System.Windows.Forms.RichTextBox rtxMessage;
        private System.Windows.Forms.Label lblFrom;
        private C1.Win.C1Sizer.C1Sizer c1Sizer1;
        private System.Windows.Forms.Label lblInbox;
        private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ImageList imageList1;
		private System.ComponentModel.IContainer components;

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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            "",
            "ComponentOne",
            "Welcome"}, 4, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            "",
            "Headquarters",
            "Improve productivity"}, 5, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Family");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Taxes");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Vacation");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Archive", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Office");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Home");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Todo", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Monday");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Tuesday");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Wednesday");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Thursday");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Friday");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Weekend");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Agenda", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13});
            this.lviMessages = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.trvFolders = new System.Windows.Forms.TreeView();
            this.lblFolders = new System.Windows.Forms.Label();
            this.rtxMessage = new System.Windows.Forms.RichTextBox();
            this.lblFrom = new System.Windows.Forms.Label();
            this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblInbox = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lviMessages
            // 
            this.lviMessages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lviMessages.FullRowSelect = true;
            this.lviMessages.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.lviMessages.Location = new System.Drawing.Point(145, 28);
            this.lviMessages.Name = "lviMessages";
            this.lviMessages.Size = new System.Drawing.Size(421, 117);
            this.lviMessages.SmallImageList = this.imageList1;
            this.lviMessages.TabIndex = 2;
            this.lviMessages.UseCompatibleStateImageBehavior = false;
            this.lviMessages.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "!";
            this.columnHeader1.Width = 18;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "c";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 20;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "From";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Subject";
            this.columnHeader4.Width = 500;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Red;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            this.imageList1.Images.SetKeyName(3, "");
            this.imageList1.Images.SetKeyName(4, "");
            this.imageList1.Images.SetKeyName(5, "");
            // 
            // trvFolders
            // 
            this.trvFolders.ImageIndex = 0;
            this.trvFolders.ImageList = this.imageList1;
            this.trvFolders.Location = new System.Drawing.Point(2, 46);
            this.trvFolders.Name = "trvFolders";
            treeNode1.Name = "";
            treeNode1.Text = "Family";
            treeNode2.Name = "";
            treeNode2.Text = "Taxes";
            treeNode3.Name = "";
            treeNode3.Text = "Vacation";
            treeNode4.Name = "";
            treeNode4.Text = "Archive";
            treeNode5.Name = "";
            treeNode5.Text = "Office";
            treeNode6.Name = "";
            treeNode6.Text = "Home";
            treeNode7.Name = "";
            treeNode7.Text = "Todo";
            treeNode8.Name = "";
            treeNode8.Text = "Monday";
            treeNode9.Name = "";
            treeNode9.Text = "Tuesday";
            treeNode10.Name = "";
            treeNode10.Text = "Wednesday";
            treeNode11.Name = "";
            treeNode11.Text = "Thursday";
            treeNode12.Name = "";
            treeNode12.Text = "Friday";
            treeNode13.Name = "";
            treeNode13.Text = "Weekend";
            treeNode14.Name = "";
            treeNode14.Text = "Agenda";
            this.trvFolders.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode7,
            treeNode14});
            this.trvFolders.SelectedImageIndex = 0;
            this.trvFolders.Size = new System.Drawing.Size(139, 293);
            this.trvFolders.TabIndex = 1;
            // 
            // lblFolders
            // 
            this.lblFolders.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFolders.Location = new System.Drawing.Point(2, 28);
            this.lblFolders.Name = "lblFolders";
            this.lblFolders.Size = new System.Drawing.Size(139, 14);
            this.lblFolders.TabIndex = 0;
            this.lblFolders.Text = " Folders";
            this.lblFolders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rtxMessage
            // 
            this.rtxMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxMessage.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxMessage.Location = new System.Drawing.Point(0, 22);
            this.rtxMessage.Name = "rtxMessage";
            this.rtxMessage.Size = new System.Drawing.Size(421, 168);
            this.rtxMessage.TabIndex = 1;
            this.rtxMessage.Text = resources.GetString("rtxMessage.Text");
            // 
            // lblFrom
            // 
            this.lblFrom.BackColor = System.Drawing.Color.Navy;
            this.lblFrom.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFrom.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.ForeColor = System.Drawing.Color.White;
            this.lblFrom.Location = new System.Drawing.Point(0, 0);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(421, 22);
            this.lblFrom.TabIndex = 0;
            this.lblFrom.Text = " From: ComponentOne    To: Client    Subject: C1Sizer";
            this.lblFrom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // c1Sizer1
            // 
            this.c1Sizer1.Padding = new Padding(2);
            this.c1Sizer1.Controls.Add(this.panel1);
            this.c1Sizer1.Controls.Add(this.lblFolders);
            this.c1Sizer1.Controls.Add(this.trvFolders);
            this.c1Sizer1.Controls.Add(this.lviMessages);
            this.c1Sizer1.Controls.Add(this.lblInbox);
            this.c1Sizer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1Sizer1.GridDefinition = "6.45161290322581:False:True;4.10557184750733:False:True;29.0322580645161:True:Fal" +
                "se;55.7184750733138:False:False;\t24.4718309859155:True:False;74.1197183098592:Fa" +
                "lse:False;";
            this.c1Sizer1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.c1Sizer1.Location = new System.Drawing.Point(0, 0);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(568, 341);
            this.c1Sizer1.TabIndex = 3;
            this.c1Sizer1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rtxMessage);
            this.panel1.Controls.Add(this.lblFrom);
            this.panel1.Location = new System.Drawing.Point(145, 149);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 190);
            this.panel1.TabIndex = 3;
            // 
            // lblInbox
            // 
            this.lblInbox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblInbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInbox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblInbox.Location = new System.Drawing.Point(2, 2);
            this.lblInbox.Name = "lblInbox";
            this.lblInbox.Size = new System.Drawing.Size(564, 22);
            this.lblInbox.TabIndex = 0;
            this.lblInbox.Text = "Inbox";
            this.lblInbox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(568, 341);
            this.Controls.Add(this.c1Sizer1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C1Sizer: Fake Outlook Express";
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
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

        private void menuItem1_Click(object sender, System.EventArgs e)
        {
            //this.c1Sizer1.ShowEditor();
        }
	}
}
