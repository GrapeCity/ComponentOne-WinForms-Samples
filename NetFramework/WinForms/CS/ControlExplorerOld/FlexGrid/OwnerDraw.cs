using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;

namespace ControlExplorer.FlexGrid
{
    public partial class OwnerDraw : C1DemoForm
    {
        // ** fields
        Hashtable _songs = new Hashtable();
        Pen _pen;
        Bitmap _bmp;

        public OwnerDraw()
        {
            InitializeComponent();
        }

        private void OwnerDraw_Load(object sender, EventArgs e)
        {
            // load data from resource
            DataSet ds = new DataSet();
            StringReader reader = new StringReader((string)(ControlExplorer.Properties.Resources.Tracks));
            ds.ReadXml(reader);

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

        private void _flex_OwnerDrawCell(object sender, C1.Win.C1FlexGrid.OwnerDrawCellEventArgs e)
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
                rc.Inflate(-2, -2);
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
