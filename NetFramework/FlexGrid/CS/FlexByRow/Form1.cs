using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace FlexByRow
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private C1.Win.C1FlexGrid.C1FlexGrid _flex;
		private System.Windows.Forms.Button _btnByRow;
		private System.Windows.Forms.Button _btnByColumn;
		private System.Windows.Forms.ImageList _imgList;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this._flex = new C1.Win.C1FlexGrid.C1FlexGrid();
			this._btnByRow = new System.Windows.Forms.Button();
			this._btnByColumn = new System.Windows.Forms.Button();
			this._imgList = new System.Windows.Forms.ImageList(this.components);
			((System.ComponentModel.ISupportInitialize)(this._flex)).BeginInit();
			this.SuspendLayout();
			// 
			// _flex
			// 
			this._flex.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this._flex.Location = new System.Drawing.Point(8, 8);
			this._flex.Name = "_flex";
			this._flex.Size = new System.Drawing.Size(440, 232);
			this._flex.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this._flex.TabIndex = 0;
			// 
			// _btnByRow
			// 
			this._btnByRow.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
			this._btnByRow.Location = new System.Drawing.Point(8, 248);
			this._btnByRow.Name = "_btnByRow";
			this._btnByRow.Size = new System.Drawing.Size(128, 24);
			this._btnByRow.TabIndex = 1;
			this._btnByRow.Text = "By &Row";
			this._btnByRow.Click += new System.EventHandler(this._btnByRow_Click);
			// 
			// _btnByColumn
			// 
			this._btnByColumn.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
			this._btnByColumn.Location = new System.Drawing.Point(152, 248);
			this._btnByColumn.Name = "_btnByColumn";
			this._btnByColumn.Size = new System.Drawing.Size(128, 24);
			this._btnByColumn.TabIndex = 1;
			this._btnByColumn.Text = "By &Column";
			this._btnByColumn.Click += new System.EventHandler(this._btnByColumn_Click);
			// 
			// _imgList
			// 
			this._imgList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this._imgList.ImageSize = new System.Drawing.Size(16, 15);
			this._imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("_imgList.ImageStream")));
			this._imgList.TransparentColor = System.Drawing.Color.Red;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(456, 277);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this._btnByRow,
																		  this._flex,
																		  this._btnByColumn});
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "C1FlexGrid: Row and Column properties";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this._flex)).EndInit();
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

		Hashtable _imgMap = new Hashtable();
		private void Form1_Load(object sender, System.EventArgs e)
		{
			for (int i = 0; i < _imgList.Images.Count; i++)
				_imgMap.Add(i, _imgList.Images[i]);
			
			_flex.Styles.Add("Hdr").Font = new Font("Tahoma", 8, FontStyle.Bold);
		}
		private void _btnByRow_Click(object sender, System.EventArgs e)
		{
			_flex.Clear();
			C1.Win.C1FlexGrid.RowCollection row = _flex.Rows;

			row[1].Caption = "String/Mask";
			row[1].DataType	= typeof(string);
			row[1].EditMask	= "(999) 999-9999;*";
			row[1].StyleFixed = _flex.Styles["Hdr"];

			row[2].Caption = "Int/ImgMap";
			row[2].DataType	= typeof(int);
			row[2].ImageMap	= _imgMap;
			row[2].ImageAndText = true;
			row[2].ComboList = "0|1|2|3|4|5";
			row[2].StyleFixed = _flex.Styles["Hdr"];

			row[3].Caption = "Currency";
			row[3].DataType	= typeof(decimal);
			row[3].ComboList = "|0|1,000|100,000|1,000,000";
			row[3].StyleFixed = _flex.Styles["Hdr"];

			row[4].Caption = "DateTime";
			row[4].DataType	= typeof(DateTime);
			row[4].StyleFixed = _flex.Styles["Hdr"];

			row[5].Caption = "Aggregate";
			row[5].DataType	= typeof(C1.Win.C1FlexGrid.AggregateEnum);
			row[5].StyleFixed = _flex.Styles["Hdr"];
		}
		private void _btnByColumn_Click(object sender, System.EventArgs e)
		{
			_flex.Clear();
			C1.Win.C1FlexGrid.ColumnCollection col = _flex.Cols;

			col[1].Caption = "String/Mask";
			col[1].DataType	= typeof(string);
			col[1].EditMask	= "(999) 999-9999;*";
			col[1].StyleFixed = _flex.Styles["Hdr"];

			col[2].Caption = "Int/ImgMap";
			col[2].DataType	= typeof(int);
			col[2].ImageMap	= _imgMap;
			col[2].ImageAndText = true;
			col[2].ComboList = "0|1|2|3|4|5";
			col[2].StyleFixed = _flex.Styles["Hdr"];

			col[3].Caption = "Currency";
			col[3].DataType = typeof(decimal);
			col[3].ComboList = "|0|1,000|100,000|1,000,000";
			col[3].StyleFixed = _flex.Styles["Hdr"];

			col[4].Caption = "DateTime";
			col[4].DataType = typeof(DateTime);
			col[4].StyleFixed = _flex.Styles["Hdr"];

			col[5].Caption = "Aggregate";
			col[5].DataType	= typeof(C1.Win.C1FlexGrid.AggregateEnum);
			col[5].StyleFixed = _flex.Styles["Hdr"];
		}
	}
}
