using System;
using System.Drawing;
using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace SetupEditor
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private C1.Win.FlexGrid.C1FlexGrid flex;
		private System.Windows.Forms.StatusBar sb;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.flex = new C1.Win.FlexGrid.C1FlexGrid();
            this.sb = new System.Windows.Forms.StatusBar();
            ((System.ComponentModel.ISupportInitialize)(this.flex)).BeginInit();
            this.SuspendLayout();
            // 
            // flex
            // 
            this.flex.ColumnInfo = "10,1,0,0,0,-1,Columns:";
            this.flex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flex.Location = new System.Drawing.Point(0, 0);
            this.flex.Name = "flex";
            this.flex.Size = new System.Drawing.Size(408, 280);
            this.flex.StyleInfo = resources.GetString("flex.StyleInfo");
            this.flex.TabIndex = 0;
            this.flex.Tree.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.flex.Tree.NodeImageCollapsed = ((System.Drawing.Image)(resources.GetObject("flex.Tree.NodeImageCollapsed")));
            this.flex.Tree.NodeImageExpanded = ((System.Drawing.Image)(resources.GetObject("flex.Tree.NodeImageExpanded")));
            this.flex.UseCompatibleTextRendering = true;
            this.flex.SetupEditor += new C1.Win.FlexGrid.RowColEventHandler(this.flex_SetupEditor);
            // 
            // sb
            // 
            this.sb.Location = new System.Drawing.Point(0, 280);
            this.sb.Name = "sb";
            this.sb.Size = new System.Drawing.Size(408, 37);
            this.sb.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(9, 22);
            this.ClientSize = new System.Drawing.Size(408, 317);
            this.Controls.Add(this.flex);
            this.Controls.Add(this.sb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "C1FlexGrid: Editor events";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.flex)).EndInit();
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

		// ** assign a DataMap to column 1

		private void Form1_Load(object sender, System.EventArgs e)
		{
			ListDictionary dm = new ListDictionary();
			dm.Add("Red",	Color.Red);
			dm.Add("Green",	Color.Green);
			dm.Add("Blue",	Color.Blue);
			flex.Cols[1].DataMap = dm;
		}

		// ** initialize and hook up event handlers for the grid editors

		private void flex_SetupEditor(object sender, C1.Win.FlexGrid.RowColEventArgs e)
		{
			// Note that this routine first unhooks (-=) any old handlers that might 
			// have been connected earlier, then hooks up (+=) the event handlers. 
			// If you don't disconnect the handlers, they may be called multiple times.
			// This could be done in other ways (e.g. connect only once at startup), but 
			// this is probably the safest approach.

			// set up the grid's combo box
			ComboBox cb = flex.Editor as ComboBox;
			if (cb != null)
			{
				// make this a real combo, even if we're using a DataMap
				cb.DropDownStyle = ComboBoxStyle.DropDown;

				// hook up combo event
				cb.SelectedIndexChanged -= new System.EventHandler(flexComboEditor_SelectedValueChanged);
				cb.SelectedIndexChanged += new System.EventHandler(flexComboEditor_SelectedValueChanged);

				// hook up textbox event
				cb.TextChanged -= new System.EventHandler(flexTextEditor_SelectedValueChanged);
				cb.TextChanged += new System.EventHandler(flexTextEditor_SelectedValueChanged);
			}

			// set up the grid's text box
			TextBox tb = flex.Editor as TextBox;
			if (tb != null)
			{
				tb.TextChanged -= new System.EventHandler(flexTextEditor_SelectedValueChanged);
				tb.TextChanged += new System.EventHandler(flexTextEditor_SelectedValueChanged);
			}
		}

		// ** event handlers for the grid editors

		int _i;
		private void flexComboEditor_SelectedValueChanged(object sender, System.EventArgs e)
		{
			_i++;
			sb.Text = "Combo value changed " + _i.ToString();
		}
		private void flexTextEditor_SelectedValueChanged(object sender, System.EventArgs e)
		{
			_i++;
			sb.Text = "Text value changed " + _i.ToString();
		}
	}
}
