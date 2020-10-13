using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void Form1_Load(object sender, EventArgs e)
        {
            // load some data into grid
            string sql = "select * from products";
            string conn = GetConnectionString();
            OleDbDataAdapter da = new OleDbDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this._flex.DataSource = dt;
        }
        // change behavior of mouse down
        // instead of selecting right away, start monitoring to see if the user wants to drag the selection
        bool _checkingDrag = false;
        Point _ptDown = Point.Empty;
        void c1FlexGrid1_BeforeMouseDown(object sender, C1.Win.C1FlexGrid.BeforeMouseDownEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int row = this._flex.MouseRow;
                if (row > -1 && this._flex.Rows[row].Selected)
                {
                    _ptDown = new Point(e.X, e.Y);
                    e.Cancel = true;
                }
            }
            _checkingDrag = e.Cancel;
        }
        // monitor mouse move while checking to start drag
        // call DoDragDrop if the user moves the mouse beyond a threshold
        void c1FlexGrid1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_checkingDrag)
            {
                if (Math.Abs(_ptDown.X - e.X) + Math.Abs(_ptDown.Y - e.Y) > 5)
                {
                    DoDragDrop(_flex.Clip, DragDropEffects.Copy);
                    _checkingDrag = false;
                }
            }
        }
        // if the user didn't start a drag, select row on mouse up
        void c1FlexGrid1_MouseUp(object sender, MouseEventArgs e)
        {
            if (_checkingDrag)
            {
                int row = _flex.MouseRow;
                if ((Control.ModifierKeys & (Keys.Shift | Keys.Control)) != 0)
                {
                    _flex.Rows[row].Selected = !_flex.Rows[row].Selected;
                }
                else
                {
                    _flex.Row = row;
                }
                _checkingDrag = false;
            }
        }

        static string GetConnectionString()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common";
            string conn = @"provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;";
            return string.Format(conn, path);
        }
    }
}