using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DBSchemaChange
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private C1.Win.C1FlexGrid.C1FlexGrid _flex;
		private System.Windows.Forms.Button _btnAdd;
		private System.Windows.Forms.Button _btnDel;
		private System.Windows.Forms.DataGrid dataGrid1;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this._flex = new C1.Win.C1FlexGrid.C1FlexGrid();
			this._btnAdd = new System.Windows.Forms.Button();
			this._btnDel = new System.Windows.Forms.Button();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			((System.ComponentModel.ISupportInitialize)(this._flex)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			this.SuspendLayout();
			// 
			// _flex
			// 
			this._flex.Location = new System.Drawing.Point(8, 8);
			this._flex.Name = "_flex";
			this._flex.Size = new System.Drawing.Size(496, 160);
			this._flex.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this._flex.TabIndex = 0;
			this._flex.Tree.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(128)), ((System.Byte)(128)), ((System.Byte)(128)));
			this._flex.Tree.NodeImageCollapsed = ((System.Drawing.Bitmap)(resources.GetObject("_flex.Tree.NodeImageCollapsed")));
			this._flex.Tree.NodeImageExpanded = ((System.Drawing.Bitmap)(resources.GetObject("_flex.Tree.NodeImageExpanded")));
			// 
			// _btnAdd
			// 
			this._btnAdd.Location = new System.Drawing.Point(8, 312);
			this._btnAdd.Name = "_btnAdd";
			this._btnAdd.Size = new System.Drawing.Size(136, 32);
			this._btnAdd.TabIndex = 1;
			this._btnAdd.Text = "Add a column";
			this._btnAdd.Click += new System.EventHandler(this._btnAdd_Click);
			// 
			// _btnDel
			// 
			this._btnDel.Location = new System.Drawing.Point(168, 312);
			this._btnDel.Name = "_btnDel";
			this._btnDel.Size = new System.Drawing.Size(136, 32);
			this._btnDel.TabIndex = 1;
			this._btnDel.Text = "Remove a column";
			this._btnDel.Click += new System.EventHandler(this._btnDel_Click);
			// 
			// dataGrid1
			// 
			this.dataGrid1.DataMember = "";
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(8, 176);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.Size = new System.Drawing.Size(496, 128);
			this.dataGrid1.TabIndex = 2;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(512, 349);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.dataGrid1,
																		  this._btnAdd,
																		  this._flex,
																		  this._btnDel});
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this._flex)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
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

		public enum CountryEnum
		{
			Austria, Brazil, Chile, Denmark, Equador, Finland, Germany,
			Herzegovina, Italy, Japan, Korea, Luxembourg, Madagascar, Netherlands,
			Oman, Portugal, Qatar, Russia, Spain, Turkey, US, Venezuela, 
			Waaaa, Xaaaa, Zaire
		}

		DataTable _dt;
		private void Form1_Load(object sender, System.EventArgs e)
		{
			_dt = new DataTable("my table");
			
			DataColumnCollection c = _dt.Columns;
			c.Add("Name",    typeof(string));
			c.Add("Male",    typeof(bool));
			c.Add("Birth",   typeof(DateTime));
			c.Add("Country", typeof(CountryEnum));

			DataRowCollection r = _dt.Rows;
			r.Add(new object[] { "Joe",  true,  new DateTime(1962,10,5), CountryEnum.Austria });
			r.Add(new object[] { "Sue",  false, new DateTime(1972,11,7), CountryEnum.Germany });
			r.Add(new object[] { "Etti", false, new DateTime(1972,1,17), CountryEnum.Germany });
			r.Add(new object[] { "Bill", true,  new DateTime(1980,5,6),  CountryEnum.US });

			_flex.DataSource = _dt;
			this.dataGrid1.DataSource = _dt;
		}

		int _new = 1;
		private void _btnAdd_Click(object sender, System.EventArgs e)
		{
			DataColumnCollection c = _dt.Columns;
			c.Add("NewCol " + _new.ToString(), typeof(string));
			_new++;
		}

		private void _btnDel_Click(object sender, System.EventArgs e)
		{
			DataColumnCollection c = _dt.Columns;
            var lastindex = c.Count - 1;

            if (lastindex > -1)
            {
                c.RemoveAt(lastindex);
            }
        }
	}
}
