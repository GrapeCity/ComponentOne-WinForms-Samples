using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Resources;
using System.IO;

namespace ThumbnailTips
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // add some data to grid
        void Form1_Load(object sender, EventArgs e)
        {
            // bind grid on first page
            string sql = "select * from products";
            string conn = GetConnectionString();
            OleDbDataAdapter da = new OleDbDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            c1FlexGrid1.DataSource = dt;

            // select each page (needed so Control.DrawToBitmap works the first time)
            TabPage selected = this.tabControl1.SelectedTab;
            foreach (TabPage page in this.tabControl1.TabPages)
            {
                this.tabControl1.SelectedTab = page;
            }
            this.tabControl1.SelectedTab = selected;
        }

        // update tooltip as the mouse moves
        void tabControl1_MouseMove(object sender, MouseEventArgs e)
        {
            // find tab under the mouse
            TabPage page = null;
            Point pt = new Point(e.X, e.Y);
            for (int index = 0; index < this.tabControl1.TabPages.Count; index++)
            {
                if (this.tabControl1.GetTabRect(index).Contains(pt))
                {
                    page = this.tabControl1.TabPages[index];
                    break;
                }
            }

            // show tip if the mouse is over a tab that is not selected
            if (page != null && page != this.tabControl1.SelectedTab)
            {
                string fmt =
                        "<p>Here's a screenshot of page <b>'{0}'</b>.</p>" +
                        "<p>This page contains either a grid or a chart plus some other controls...</p>" +
                        "<p align='center'><img style='border:solid 4 darkblue;margin:4;' src='res://tabPage'></p>" +
                        "<p>The page image was created using the <b>Control.DrawToBitmap</b> method,<br>" +
                        "then stored in the <b>C1SuperTooltip.Images</b> list. The tooltip text displays<br>" +
                        "the image using an html tag that looks like this:</p>" +
                        "<p align='center'><b>&lt;img src='res://tabPage'&gt;</b>.</p>";
                string tipText = string.Format(fmt, page.Text);
                if (tipText != this.c1SuperTooltip1.GetToolTip(this.tabControl1))
                {
                    this.c1SuperTooltip1.Images["tabPage"].Image = GetControlImage(page, 0.5f);
                    this.c1SuperTooltip1.SetToolTip(this.tabControl1, tipText);
                }
            }
            else
            {
                this.c1SuperTooltip1.SetToolTip(this.tabControl1, string.Empty);
            }
        }

        // reset tip when mouse leaves the control
        void tabControl1_MouseLeave(object sender, EventArgs e)
        {
            this.c1SuperTooltip1.SetToolTip(this.tabControl1, string.Empty);
        }

        // helper to get control images
        static Image GetControlImage(Control ctl, float zoom)
        {
            // get image
            Rectangle rc = ctl.ClientRectangle;
            Bitmap bmp = new Bitmap(rc.Width, rc.Height);
            ctl.DrawToBitmap(bmp, rc);

            // apply zoom
            if (zoom != 1)
            {
                Size newSize = Size.Round(new SizeF(bmp.Width * zoom, bmp.Height * zoom));
                bmp = new Bitmap(bmp, newSize);
            }

            // return image
            return bmp;
        }

        static string GetConnectionString()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common";
            string conn = @"provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;";
            return string.Format(conn, path);
        }
    }
}