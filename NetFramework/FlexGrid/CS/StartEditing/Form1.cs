using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using C1.Win.FlexGrid;

namespace StartEditing
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private C1.Win.FlexGrid.C1FlexGrid _flex;
		private System.Windows.Forms.ComboBox comboBox1;
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
			comboBox1.SelectedIndex = 0;
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
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this._flex = new C1.Win.FlexGrid.C1FlexGrid();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this._flex)).BeginInit();
			this.SuspendLayout();
			// 
			// _flex
			// 
			this._flex.BackColor = System.Drawing.SystemColors.Window;
			this._flex.ColumnInfo = @"5,1,0,0,0,75,Columns:0{Width:24;}	1{DataType:System.Boolean;Format:""yes;no"";ImageAlign:CenterCenter;Caption:""Bool"";}	2{DataType:System.DateTime;Format:""d"";Caption:""Date"";}	3{DataType:System.Int32;TextAlign:RightCenter;Caption:""Int"";}	4{DataType:System.String;TextAlign:LeftCenter;Caption:""String"";}";
			this._flex.Dock = System.Windows.Forms.DockStyle.Fill;
			this._flex.Name = "_flex";
			this._flex.Size = new System.Drawing.Size(464, 280);
			this._flex.Styles = new C1.Win.FlexGrid.CellStyleCollection(@"Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:LightBlue;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this._flex.TabIndex = 0;
			this._flex.Tree.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(128)), ((System.Byte)(128)), ((System.Byte)(128)));
			this._flex.Tree.NodeImageCollapsed = ((System.Drawing.Bitmap)(resources.GetObject("_flex.Tree.NodeImageCollapsed")));
			this._flex.Tree.NodeImageExpanded = ((System.Drawing.Bitmap)(resources.GetObject("_flex.Tree.NodeImageExpanded")));
			this._flex.BeforeEdit += new C1.Win.FlexGrid.RowColEventHandler(this.c1FlexGrid1_BeforeEdit);
			this._flex.EnterCell += new System.EventHandler(this.c1FlexGrid1_EnterCell);
			this._flex.StartEdit += new C1.Win.FlexGrid.RowColEventHandler(this.c1FlexGrid1_StartEdit);
			// 
			// comboBox1
			// 
			this.comboBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.Items.AddRange(new object[] {
														   "EnterCell",
														   "StartEdit",
														   "BeforeEdit"});
			this.comboBox1.Location = new System.Drawing.Point(0, 280);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(464, 21);
			this.comboBox1.TabIndex = 1;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(464, 301);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this._flex,
																		  this.comboBox1});
			this.Name = "Form1";
			this.Text = "Form1";
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

		private void c1FlexGrid1_EnterCell(object sender, System.EventArgs e)
		{
            if (comboBox1.SelectedIndex == 0 || comboBox1.SelectedIndex == 1) //7927
            {
                SetupEditor();
            }
			_flex.StartEditing();
		}
		private void c1FlexGrid1_StartEdit(object sender, C1.Win.FlexGrid.RowColEventArgs e)
		{
            if (comboBox1.SelectedIndex == 1)
            {
                SetupEditor();
            }
		}
        private void c1FlexGrid1_BeforeEdit(object sender, C1.Win.FlexGrid.RowColEventArgs e)
        {
            _flex.EditOptions = EditFlags.All;

            var type = _flex.Cols[_flex.Col].DataType;

            if (type == typeof(int))
            {
                _flex.EditOptions &= ~EditFlags.UseNumericEditor;
            }

            if (comboBox1.SelectedIndex == 2)
            {
                SetupEditor();
            }
        }

		int _ctr = 0;
		private void SetupEditor()
		{
			Console.WriteLine("Setting up {0}", _ctr++);
			_flex.ComboList = ""; 
			_flex.EditMask = "";

			Type type = _flex.Cols[_flex.Col].DataType;
            if (type == typeof(bool))
            {
                _flex.ComboList = "true|false";
            }
            if (type == typeof(DateTime))
            {
                _flex.EditMask = "99/99/9999";
            }
            if (type == typeof(int))
            {
                _flex.EditMask = "999999";
            }
		}
	}
}
