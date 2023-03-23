using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using C1.Win.FlexGrid;

namespace Test1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            c1FlexGridPrintable2.PrintCell += new C1FlexGridPrintable2.PrintCellEventHandler(c1FlexGridPrintable2_PrintCell);
        }

        void c1FlexGridPrintable2_PrintCell(object sender, C1FlexGridPrintable2.PrintCellEventArgs e)
        {
            if (e.TableCell.Row == e.TableCell.Col)
            {
                if (e.TableCell.RenderObject != null)
                    e.TableCell.RenderObject.Style.Borders.All = new C1.C1Preview.LineDef("2mm", Color.Blue);
                else
                    e.TableCell.Style.BackColor = Color.LightCoral;
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // bind main grid to a data source
            string conn = GetConnectionString();
            // string rs = "select * from Customers;";
            string rs = "select * from Orders;";
            OleDbDataAdapter da = new OleDbDataAdapter(rs, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.c1FlexGridPrintable2.DataSource = dt;
        }

        static string GetConnectionString()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common";
            string conn = @"provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;";
            return string.Format(conn, path);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            C1FlexGridPrinter printer = new C1FlexGridPrinter(c1FlexGridPrintable2);
            printer.PrintPreview();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            c1FlexGridPrintable2.Cols.Fixed = 3;

            CellStyle ss = c1FlexGridPrintable2.Styles.Add("qq");
            ss.BackColor = Color.Red;
            c1FlexGridPrintable2.SetCellStyle(1, 2, ss);

            CellStyle ss1 = c1FlexGridPrintable2.Styles.Add("qqq");
            ss1.TextDirection = TextDirectionEnum.Down;
            c1FlexGridPrintable2.SetCellStyle(4, 2, ss1);
            c1FlexGridPrintable2.Rows[4].Height = 50;

            CellStyle ss3 = c1FlexGridPrintable2.Styles.Add("qqqq");
            // ss3.TextDirection = TextDirectionEnum.Down;
            ss3.ImageAlign = ImageAlignEnum.RightBottom;
            // ss3.Display = DisplayEnum.Overlay;
            ss3.ImageSpacing = 30;//qq
            c1FlexGridPrintable2.SetCellStyle(4, 3, ss3);
            c1FlexGridPrintable2.SetCellImage(4, 3, pictureBox1.Image);
            c1FlexGridPrintable2.AutoSizeCol(3);

            CellStyle ss4 = c1FlexGridPrintable2.Styles.Add("qq4");
            // ss4.ImageAlign = ImageAlignEnum.CenterTop;
            ss4.ImageAlign = ImageAlignEnum.RightTop;
            ss4.ImageSpacing = 30;//qq
            ss4.TextAlign = TextAlignEnum.CenterCenter;
            // ss4.TextAlign = TextAlignEnum.LeftBottom;
            ss4.Display = DisplayEnum.Stack;//.Overlay;
            ss4.Border.Style = BorderStyleEnum.None;
            //ss4.Border.Direction = BorderDirEnum.Vertical;
            ss4.Margins.Right = 12;
            c1FlexGridPrintable2.Rows[5].Height = 50;
            c1FlexGridPrintable2.SetCellStyle(5, 2, ss4);

            c1FlexGridPrintable2.SetCellStyle(5, c1FlexGridPrintable2.Cols.Count - 1, ss4);

            c1FlexGridPrintable2.Rows[5][2] = "aaaa";
            c1FlexGridPrintable2.SetCellImage(5, 2, pictureBox1.Image);
            c1FlexGridPrintable2.SetCellCheck(5, 2, CheckEnum.Checked);
            // c1FlexGrid1[4, 3] = "!aaaaaaaaaa!";
            // c1FlexGrid1.AutoSizeCol(3);

            c1FlexGridPrintable2.Cols[4].TextAlign = TextAlignEnum.RightCenter;

            c1FlexGridPrintable2.Rows.InsertNode(2, -1);
            // c1FlexGridPrintable2.ShowSortAt(

            //c1FlexGridPrintable2.SetCellImage(0, 3, pictureBox1.Image);
            //c1FlexGridPrintable2.Cols[3].Width = pictureBox1.Image.Width;
            c1FlexGridPrintable2[0, 3] = "AAAAAAAAAAAAA";


            c1FlexGridPrintable2.AutoSizeRows();
            c1FlexGridPrintable2.AllowResizing = AllowResizingEnum.Both;
        }
    }
}
