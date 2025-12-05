using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using System.IO;
using C1.Win.FlexGrid;
using System.Xml;

namespace HtmlGrid
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
        private C1.Win.FlexGrid.C1FlexGrid _flex;
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
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            this._flex = new C1.Win.FlexGrid.C1FlexGrid();
            ((System.ComponentModel.ISupportInitialize)(this._flex)).BeginInit();
            this.SuspendLayout();
            // 
            // _flex
            // 
            this._flex.ColumnInfo = "10,1,0,0,0,110,Columns:0{Width:23;}\t";
            this._flex.Dock = System.Windows.Forms.DockStyle.Fill;
            this._flex.Location = new System.Drawing.Point(0, 0);
            this._flex.Name = "_flex";
            this._flex.Rows.DefaultSize = 22;
            this._flex.Size = new System.Drawing.Size(552, 325);
            this._flex.StyleInfo = resources.GetString("_flex.StyleInfo");
            this._flex.TabIndex = 0;
            this._flex.OwnerDrawCell += new C1.Win.FlexGrid.OwnerDrawCellEventHandler(this._flex_OwnerDrawCell);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
            this.ClientSize = new System.Drawing.Size(552, 325);
            this.Controls.Add(this._flex);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C1FlexGrid: HTML in cells";
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

		void Form1_Load(object sender, System.EventArgs e)
		{
			// set up grid
			_flex.AutoResize = false;
			_flex.AllowResizing = AllowResizingEnum.Both;
			_flex.DrawMode = DrawModeEnum.OwnerDraw;
			_flex.Rows.DefaultSize = 80;
			_flex.Rows[0].Height   = 20;
			_flex.Cols[0].Width    = 20;
			_flex.ShowCursor = true;

            // create a data table with an HTML field
            DataTable dt = new DataTable();
            dt.Columns.Add("HTML", typeof(string));
            dt.Columns.Add("Plain Text", typeof(string));
            for (int i = 0; i < 100; i++)
            {
                dt.Rows.Add(GetHtml(8, "This is <u>underlined</u> text in an HTML string"), "Plain text...");
                dt.Rows.Add(GetHtml(9, "This is <i>italic</i> text in an HTML string"), "Plain text...");
                dt.Rows.Add(GetHtml(12, "This is <b>bold</b> text in an HTML string"), "Plain text...");
            }

            // bind grid
			_flex.DataSource = dt;

			// make Html field conspicuous
			Column colHtml = _flex.Cols["HTML"];
            colHtml.Width = 500;
			//_flex.Cols.Move(colNotes.Index, 3);

            // use HtmlEditor class to edit values in the "C1Editor" column
            var editor = new HtmlEditor();
            editor.BorderStyle = BorderStyle.None;
            colHtml.Editor = editor;

			// use a different backcolor
            colHtml.StyleNew.BackColor = Color.LightGoldenrodYellow;
            _flex.BackColor = Color.Bisque;
		}
        string GetHtml(float fontSize, string html)
        {
            string bgColor = ColorTranslator.ToHtml(Color.LightGoldenrodYellow);
            return string.Format(
                "<html><body style='margin:0pt;padding:0pt;font-family:{0};font-size:{1}pt;background-color:{2}'><p>{3}</p></body></html>",
                Font.Name,
                fontSize, 
                bgColor,
                html);
        }

        // use this C1SuperLabel control to render Html cells
        C1.Win.SuperTooltip.C1SuperLabel _html = new C1.Win.SuperTooltip.C1SuperLabel();
        void _flex_OwnerDrawCell(object sender, C1.Win.FlexGrid.OwnerDrawCellEventArgs e)
        {
            if (_flex.Cols[e.Col].Name == "HTML")
            {
                // draw background
                e.DrawCell(DrawCellFlags.Background);

                // use the C1SuperLabel to draw the html text
                if (e.Bounds.Width > 0 && e.Bounds.Height > 0)
                {
                    _html.Text = _flex.GetDataDisplay(e.Row, e.Col);
                    _html.BackColor = Color.Transparent;
                    _html.DrawToGraphics(e.Graphics, e.Bounds);
                }

                // and draw border last
                e.DrawCell(DrawCellFlags.Border);

                // we're done with this cell
                e.Handled = true;
            }
        }
	}
}
