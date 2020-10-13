using System;
using System.Reflection;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;

namespace Themes
{
    public enum Theme
    {
        Default,
        WindowsXP,
        Office2003,
        Office12,
        Vista,
        Mac,
        Shadow,
        Steel,
        Glass
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void Form1_Load(object sender, EventArgs e)
        {
            // show some data
            string sql = "select * from products";
            string conn = GetConnectionString();
            OleDbDataAdapter da = new OleDbDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            _flex.DataSource = dt;

            // initialize themes
            foreach (Theme theme in Enum.GetValues(typeof(Theme)))
            {
                this.comboBox1.Items.Add(theme);
            }
            this.comboBox1.SelectedIndex = 0;
        }
        void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _flex.ShowThemedHeaders = ShowThemedHeadersEnum.None;
            _flex.Styles.Clear();

            switch ((Theme)this.comboBox1.SelectedItem)
            {
                case Theme.Default:
                    break;
                case Theme.WindowsXP:
                    _flex.ShowThemedHeaders = ShowThemedHeadersEnum.Both;
                    break;
                case Theme.Office2003:
                    Office2003(_flex.Styles);
                    break;
                case Theme.Office12:
                    Office12(_flex.Styles);
                    break;
                case Theme.Vista:
                    Vista(_flex.Styles);
                    break;
                case Theme.Mac:
                    Mac(_flex.Styles);
                    break;
                case Theme.Shadow:
                    Shadow(_flex.Styles);
                    break;
                case Theme.Steel:
                    Steel(_flex.Styles);
                    break;
                case Theme.Glass:
                    Glass(_flex.Styles);
                    break;
            }
            _flex.AutoSizeCols();
            for (int r = 0; r < _flex.Rows.Fixed; r++)
            {
                _flex.AutoSizeRow(r);
            }
        }

        static string GetConnectionString()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common";
            string conn = @"provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;";
            return string.Format(conn, path);
        }

        //---------------------------------------------------------------------------
        #region ** themes

        private void Office2003(CellStyleCollection s)
        {
            s.Clear();
            s.Normal.Border.Color = SystemColors.InactiveBorder;
            s.Highlight.Clear();
            s.Highlight.BackColor = SystemColors.GradientInactiveCaption;
            s.SelectedColumnHeader.BackColor = System.Windows.Forms.VisualStyles.VisualStyleInformation.ControlHighlightHot;
            s.SelectedRowHeader.MergeWith(s.SelectedColumnHeader);
        }
        private void Office12(CellStyleCollection s)
        {
            Office2003(s);

            s.Highlight.BackColor = Color.FromArgb(180, s.Highlight.BackColor);

            CellStyle cs = s.Fixed;
            cs.BackgroundImage = BuildStyleBackground(s.Fixed.BackColor);
            cs.BackgroundImageLayout = ImageAlignEnum.TileStretch;
            cs.BackColor = Color.White;

            cs = s.SelectedColumnHeader;
            cs.BackgroundImage = BuildStyleBackground(s.SelectedColumnHeader.BackColor);
            cs.BackgroundImageLayout = ImageAlignEnum.TileStretch;
            cs.BackColor = Color.White;

            cs = s.SelectedRowHeader;
            cs.Clear();
            cs.MergeWith(s.SelectedColumnHeader);
        }
        private void Vista(CellStyleCollection s)
        {
            s.Clear();

            CellStyle cs = s.Normal;
            cs.BackColor = Color.FromArgb(247, 247, 247);
            cs.Border.Width = 0;

            cs = s.Fixed;
            cs.BackgroundImage = GetBitmapResource("Vista_Header.png");
            cs.BackgroundImageLayout = ImageAlignEnum.TileStretch;
            cs.ForeColor = Color.FromArgb(150, s.Normal.BackColor);
            cs.Font = new Font(s.Normal.Font, FontStyle.Bold);

            cs = s.Highlight;
            cs.Clear();
            cs.BackgroundImage = GetBitmapResource("Vista_Highlight.png");
            cs.BackgroundImageLayout = ImageAlignEnum.TileStretch;
            cs.ForeColor = Color.Navy;

            s.Focus.MergeWith(cs);
        }
        private void Mac(CellStyleCollection s)
        {
            s.Clear();

            CellStyle cs = s.Normal;
            cs.BackColor = Color.FromArgb(250, 250, 250);
            cs.Border.Width = 0;

            cs = s.Fixed;
            cs.BackgroundImage = GetBitmapResource("Mac_Header.png");
            cs.BackgroundImageLayout = ImageAlignEnum.TileStretch;
            cs.Border.Width = 0;
            cs.Margins = new System.Drawing.Printing.Margins(4, 4, 4, 2);

            cs = s.SelectedColumnHeader;
            cs.MergeWith(s.Fixed);
            cs.BackgroundImage = GetBitmapResource("Mac_HeaderSelected.png");

            s.SelectedRowHeader.MergeWith(cs);

            cs = s.Highlight;
            cs.Clear();
            cs.BackColor = Color.FromArgb(150, Color.LightSteelBlue);

            s.Focus.MergeWith(cs);
        }
        private void Shadow(CellStyleCollection s)
        {
            s.Clear();

            Color color = SystemColors.ActiveBorder;

            s.Normal.Border.Color = Color.FromArgb(80, color);

            CellStyle cs = s.Fixed;
            cs.BackColor = Color.FromArgb(180, color);
            cs.Border.Color = Color.FromArgb(220, color);

            cs = s.SelectedColumnHeader;
            cs.BackgroundImage = BuildStyleBackground(color, s.Normal.BackColor, 90);
            cs.BackgroundImageLayout = ImageAlignEnum.TileStretch;

            cs = s.SelectedRowHeader;
            cs.Clear();
            cs.MergeWith(s.SelectedColumnHeader);
            cs.BackgroundImage = BuildStyleBackground(color, s.Normal.BackColor, 0);

            cs = s.Highlight;
            cs.Clear();
            cs.BackColor = Color.FromArgb(150, s.Fixed.BackColor);
        }
        private void Steel(CellStyleCollection s)
        {
            s.Clear();

            CellStyle cs = s.Normal;
            cs.BackColor = Color.FromArgb(250, 250, 250);
            cs.Border.Width = 0;

            cs = s.Fixed;
            cs.BackgroundImage = GetBitmapResource("Steel_Header.png");
            cs.BackgroundImageLayout = ImageAlignEnum.TileStretch;
            cs.Border.Width = 0;

            cs = s.SelectedColumnHeader;
            cs.MergeWith(s.Fixed);
            cs.BackgroundImage = GetBitmapResource("Steel_HeaderSelected.png");
            cs.Font = new Font(cs.Font, FontStyle.Bold);

            s.SelectedRowHeader.MergeWith(cs);

            cs = s.Highlight;
            cs.Clear();
            cs.BackColor = Color.FromArgb(150, Color.LightSteelBlue);

            s.Focus.MergeWith(cs);
        }
        private void Glass(CellStyleCollection s)
        {
            s.Clear();

            CellStyle cs = s.Normal;
            cs.BackColor = Color.FromArgb(250, 250, 250);
            cs.Border.Width = 0;

            cs = s.Normal;
            cs.BackgroundImage = GetBitmapResource("Glass_Normal.png");
            cs.BackgroundImageLayout = ImageAlignEnum.TileStretch;

            cs = s.Alternate;
            cs.BackgroundImage = GetBitmapResource("Glass_Alternate.png");
            cs.BackgroundImageLayout = ImageAlignEnum.TileStretch;

            cs = s.Fixed;
            cs.BackgroundImage = GetBitmapResource("Glass_Header.png");
            cs.BackgroundImageLayout = ImageAlignEnum.TileStretch;
            cs.Margins = new System.Drawing.Printing.Margins(4, 4, 4, 2);
            cs.Border.Width = 0;

            cs = s.SelectedColumnHeader;
            cs.MergeWith(s.Fixed);
            cs.BackgroundImage = GetBitmapResource("Glass_HeaderSelected.png");

            s.SelectedRowHeader.MergeWith(cs);

            cs = s.Highlight;
            cs.BackgroundImageLayout = ImageAlignEnum.Hide;
            cs.BackColor = Color.FromArgb(165, 200, 240);

            s.Focus.MergeWith(cs);
        }

        // utilities
        private Bitmap BuildStyleBackground(Color background)
        {
            return BuildStyleBackground(Color.FromArgb(150, background), background, 90f);
        }
        private Bitmap BuildStyleBackground(Color color1, Color color2, float angle)
        {
            Rectangle rc = new Rectangle(0, 0, 10, 15);
            Bitmap bmp = new Bitmap(rc.Width, rc.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            using (LinearGradientBrush br = new LinearGradientBrush(rc, color1, color2, angle))
            {
                g.FillRectangle(br, rc);
            }
            return bmp;
        }
        private Bitmap GetBitmapResource(string name)
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            foreach (string res in asm.GetManifestResourceNames())
            {
                if (res.EndsWith(name))
                {
                    return (Bitmap)Bitmap.FromStream(asm.GetManifestResourceStream(res));
                }
            }
            throw new ArgumentException("can't find resource " + name);
        }
        #endregion

    }
}