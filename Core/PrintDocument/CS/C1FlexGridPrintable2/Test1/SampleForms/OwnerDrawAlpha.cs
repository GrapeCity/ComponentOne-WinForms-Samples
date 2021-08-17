using System;
using System.Reflection;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using System.Data;
using C1.Win.FlexGrid;

namespace OwnerDrawAlpha
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private C1.Win.FlexGrid.C1FlexGridPrintable2 _flex;
		private System.Windows.Forms.Timer _timer;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this._flex = new C1.Win.FlexGrid.C1FlexGridPrintable2();
            this._timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this._flex)).BeginInit();
            this.SuspendLayout();
            // 
            // _flex
            // 
            this._flex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(66)))), ((int)(((byte)(40)))));
            this._flex.ColumnInfo = "10,1,0,0,0,85,Columns:";
            this._flex.Dock = System.Windows.Forms.DockStyle.Fill;
            this._flex.ForeColor = System.Drawing.Color.White;
            this._flex.Location = new System.Drawing.Point(0, 0);
            this._flex.Name = "_flex";
            this._flex.Size = new System.Drawing.Size(582, 366);
            this._flex.StyleInfo = resources.GetString("_flex.StyleInfo");
            this._flex.TabIndex = 0;
            this._flex.OwnerDrawCell += new C1.Win.FlexGrid.OwnerDrawCellEventHandler(this._flex_OwnerDrawCell);
            this._flex.DoubleClick += new System.EventHandler(this._flex_DoubleClick);
            // 
            // _timer
            // 
            this._timer.Enabled = true;
            this._timer.Tick += new System.EventHandler(this._timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(582, 366);
            this.Controls.Add(this._flex);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C1FlexGrid: OwnerDraw cells with alpha-blending";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this._flex)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		// ** utility
		private DataSet GetDataSet(string resName)
		{
			Assembly asm = Assembly.GetExecutingAssembly();
			foreach (string res in asm.GetManifestResourceNames())
			{
				if (res.EndsWith(resName))
				{
					DataSet ds = new DataSet();
					ds.ReadXml(asm.GetManifestResourceStream(res));
					return ds;
				}
			}
			throw new Exception("resource not found: " + resName);
		}

		// ** fields
		Hashtable _songs = new Hashtable();
		Pen _pen;
		Bitmap _bmp;

		// ** event handlers
		private void Form1_Load(object sender, System.EventArgs e)
		{
			// load data from resource
			DataSet ds = GetDataSet("tracks.xsd");

			// configure grid
			_flex.Cols.Fixed = 0;
			_flex.SelectionMode = SelectionModeEnum.Row;
			_flex.FocusRect = FocusRectEnum.None;
			_flex.DrawMode = DrawModeEnum.OwnerDraw;
			_flex.AutoClipboard = true;
			_flex.AllowEditing = false;

			// bind grid
			DataTable dt = ds.Tables[0];
			//dt.DefaultView.Sort = "Status";
			_flex.DataSource = dt;
			_flex.Cols["Status"].Width = 160;

			// create gdi objects
			Color color = Color.FromArgb(150, _flex.Styles.Highlight.ForeColor);
			_pen = new Pen(color, 1);
			_bmp = new Bitmap(100, 20);
			Rectangle rc = Rectangle.Empty;
			rc.Size = _bmp.Size;
			using (Graphics g = Graphics.FromImage(_bmp))
			using (Brush b = new LinearGradientBrush(rc, Color.Transparent, color, LinearGradientMode.Horizontal))
			{
				g.FillRectangle(b, rc);
			}

			// start copying all songs right away
			foreach (DataRow dr in ds.Tables[0].Rows)
				_songs[dr] = DateTime.Now;

			//ds.WriteXml(@"c:\temp\tracks.xsd", XmlWriteMode.WriteSchema);
		}

		// add song to copy list
		private void _flex_DoubleClick(object sender, System.EventArgs e)
		{
			// get song
			DataRowView drv = (DataRowView)_flex.Rows[_flex.Row].DataSource;
			DataRow dr = drv.Row;

			// add to copy list
			if (!_songs.ContainsKey(dr))
				_songs[dr] = DateTime.Now;
		}
		private void _timer_Tick(object sender, System.EventArgs e)
		{
			// change song status to force repaint
			if (_songs.Count > 0)
			{
				ArrayList al = new ArrayList(_songs.Keys);
				foreach (DataRow dr in al)
					dr["Status"] = "Copying...";
			}
		}
		private void _flex_OwnerDrawCell(object sender, C1.Win.FlexGrid.OwnerDrawCellEventArgs e)
		{
			if (_flex.Cols[e.Col].Name == "Status" && e.Row > 0)
			{
				// get song
				DataRowView drv = (DataRowView)_flex.Rows[e.Row].DataSource;
				if (drv == null) return;
				DataRow dr = drv.Row;

				// see if we're copying the song
				if (!_songs.ContainsKey(dr))
					return;

				// calculate how much is done
				DateTime start = (DateTime)_songs[dr];
				TimeSpan elapsed = DateTime.Now - start;
				TimeSpan length = (TimeSpan)dr["Length"];
				int pct = (length.TotalSeconds > 0)
					? (int)(elapsed.TotalSeconds / length.TotalSeconds * 100f * 20f)
					: 100;

				// song is done? remove from list
				if (pct >= 100)
				{
					_songs.Remove(dr);
					dr["Status"] = "Copied";
					return;
				}

				// draw background
				e.Style = _flex.Styles.Highlight;
				e.DrawCell(DrawCellFlags.Background);

				// progress bar outline
				Rectangle rc = e.Bounds;
				rc.Width--;
				rc.Height--;
				e.Graphics.DrawRectangle(_pen, rc);

				// fill progress bar
				rc = e.Bounds;
				rc.Inflate(-2,-2);
				rc.Width = rc.Width * pct / 100;
				e.Graphics.DrawImage(_bmp, rc);

				// draw text
				e.Text = string.Format("Copying ({0}% done)", pct);
				e.DrawCell(DrawCellFlags.Content);
				e.Handled = true;
			}
		}
	}
}
