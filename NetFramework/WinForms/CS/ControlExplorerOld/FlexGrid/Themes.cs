using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;

namespace ControlExplorer.FlexGrid
{
    public partial class Themes : C1DemoForm
    {
        Image _defaultChecked;
        Image _defaultUnchecked;

        public enum Theme
        {
            Default,
            System,
            Office2007Blue,
            Office2007Black,
            Office2007Silver,
            Office2010Blue,
            Office2010Black,
            Office2010Silver,
            Elegant,
            Glass,
            Mac,
            Energy,
            Notebook,
            Steel,
            WindowsXP,
            Vista
        }

        public Themes()
        {
            InitializeComponent();
        }

        private void Themes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'c1DemoDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.c1DemoDataSet.Products);
            c1FlexGrid1.AutoSizeCols();
            // initialize themes
            foreach (Theme theme in Enum.GetValues(typeof(Theme)))
            {
                this.comboBox1.Items.Add(theme);
            }
            this.comboBox1.SelectedIndex = 2;
            _defaultChecked = c1FlexGrid1.Glyphs[GlyphEnum.Checked];
            _defaultUnchecked = c1FlexGrid1.Glyphs[GlyphEnum.Unchecked];
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            c1FlexGrid1.ShowThemedHeaders = ShowThemedHeadersEnum.None;
            c1FlexGrid1.Styles.Clear();
            c1FlexGrid1.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Custom;
            c1FlexGrid1.Rows[0].Visible = true;
            c1FlexGrid1.Glyphs[GlyphEnum.Checked] = _defaultChecked;
            c1FlexGrid1.Glyphs[GlyphEnum.Unchecked] = _defaultUnchecked;

            switch ((Theme)this.comboBox1.SelectedItem)
            {
                case Theme.Default:
                    this.BackColor = Color.FromKnownColor(KnownColor.Control);
                    break;
                case Theme.System:
                    c1FlexGrid1.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.System;
                    this.BackColor = Color.FromKnownColor(KnownColor.Control);
                    break;
                case Theme.WindowsXP:
                    c1FlexGrid1.ShowThemedHeaders = ShowThemedHeadersEnum.Both;
                    break;
                case Theme.Office2007Blue:
                    c1FlexGrid1.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2007Blue;
                    this.BackColor = Color.FromArgb(191, 219, 255);
                    break;
                case Theme.Office2007Black:
                    c1FlexGrid1.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2007Black;
                    this.BackColor = Color.FromArgb(83, 83, 83);
                    break;
                case Theme.Office2007Silver:
                    c1FlexGrid1.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2007Silver;
                    this.BackColor = Color.FromArgb(208, 212, 221);
                    break;
                case Theme.Office2010Blue:
                    c1FlexGrid1.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue;
                    this.BackColor = Color.FromArgb(191, 219, 255);
                    break;
                case Theme.Office2010Black:
                    c1FlexGrid1.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Black;
                    this.BackColor = Color.FromArgb(83, 83, 83);
                    break;
                case Theme.Office2010Silver:
                    c1FlexGrid1.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Silver;
                    this.BackColor = Color.FromArgb(208, 212, 221);
                    break;
                case Theme.Elegant:
                    Elegant(c1FlexGrid1.Styles);
                    break;
                case Theme.Vista:
                    Vista(c1FlexGrid1.Styles);
                    break;
                case Theme.Mac:
                    Mac(c1FlexGrid1.Styles);
                    break;
                case Theme.Energy:
                    Energy(c1FlexGrid1.Styles);
                    break;
                case Theme.Steel:
                    Steel(c1FlexGrid1.Styles);
                    break;
                case Theme.Glass:
                    Glass(c1FlexGrid1.Styles);
                    break;
                case Theme.Notebook:
                    Notebook(c1FlexGrid1.Styles);
                    break;
            }

            for (int r = 0; r < c1FlexGrid1.Rows.Fixed; r++)
            {
                c1FlexGrid1.AutoSizeRow(r);
            }
        }

        private void Glass(CellStyleCollection s)
        {
            s.Clear();

            //set Normal style
            CellStyle cs = s.Normal;
            cs.BackColor = Color.FromArgb(250, 250, 250);
            cs.Border.Width = 0;
            cs.BackgroundImage = glass.Images["Glass_Normal.png"];
            cs.BackgroundImageLayout = ImageAlignEnum.TileStretch;
            //set Alternate style
            cs = s.Alternate;
            cs.BackgroundImage = glass.Images["Glass_Alternate.png"];
            cs.BackgroundImageLayout = ImageAlignEnum.TileStretch;
            //set Fixed style
            cs = s.Fixed;
            cs.BackgroundImage = glass.Images["Glass_Header.png"];
            cs.BackgroundImageLayout = ImageAlignEnum.TileStretch;
            cs.Margins = new System.Drawing.Printing.Margins(4, 4, 4, 2);
            cs.Border.Width = 0;
            //set SelectedColumnHeader style
            cs = s.SelectedColumnHeader;
            cs.MergeWith(s.Fixed);
            cs.BackgroundImage = glass.Images["Glass_HeaderSelected.png"];
            //copy to SelectedRowHeader style
            s.SelectedRowHeader.MergeWith(cs);
            //set Highlight style
            cs = s.Highlight;
            cs.BackgroundImage = glass.Images["Glass_Selected.png"];
            cs.BackgroundImageLayout = ImageAlignEnum.TileStretch;
            cs.BackColor = Color.LightPink;
            cs.ForeColor = Color.Black;
            //copy to Focus style
            s.Focus.MergeWith(cs);

            this.BackColor = Color.Azure;
        }

        private void Mac(CellStyleCollection s)
        {
            s.Clear();

            //get C1FlexGrid's normal row cell style
            CellStyle cs = s.Normal;
            cs.BackColor = Color.FromArgb(250, 250, 250);
            cs.Border.Direction = BorderDirEnum.Vertical;
            cs.Border.Color = Color.FromArgb(101, 101, 101);
            //get C1FlexGrid's alternating row cell style
            cs = s.Alternate;
            cs.BackColor = Color.FromArgb(239, 239, 255);
            //get C1FlexGrid's fixed cell style
            cs = s.Fixed;
            cs.BackgroundImage = mac.Images["Mac_Header.png"];
            cs.BackgroundImageLayout = ImageAlignEnum.TileStretch;
            cs.Border.Width = 0;
            cs.Margins = new System.Drawing.Printing.Margins(4, 4, 4, 2);
            //merge SelectedColumnHeader style with Fixed style
            cs = s.SelectedColumnHeader;
            cs.MergeWith(s.Fixed);
            //set unique background image
            cs.BackgroundImage = mac.Images["Mac_HeaderSelected.png"];

            //merge SelectedRowHeader with SelectedColumHeader
            s.SelectedRowHeader.MergeWith(cs);

            cs = s.Highlight;
            cs.Clear();
            cs.BackColor = Color.FromArgb(60, 143, 234);
            cs.ForeColor = Color.White;
            //copy Highlight style to Focus style
            s.Focus.MergeWith(cs);

            //set custom checkbox glyphs
            c1FlexGrid1.Glyphs[GlyphEnum.Checked] = checkBoxes.Images["customCheck2.png"];
            c1FlexGrid1.Glyphs[GlyphEnum.Unchecked] = checkBoxes.Images["customUncheck2.png"];
            this.BackColor = Color.FromArgb(152, 151, 151);
        }

        private void Elegant(CellStyleCollection s)
        {
            s.Clear();

            CellStyle cs = s.Normal;
            cs.ForeColor = System.Drawing.ColorTranslator.FromHtml("#6B6B6B");
            cs.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");


            cs = s.Fixed;
            cs.BackColor = System.Drawing.ColorTranslator.FromHtml("#4A6B9D");
            cs.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");

            cs = s.Highlight;
            cs.Clear();
            cs.BackColor = System.Drawing.ColorTranslator.FromHtml("#C3F09A");
            cs.ForeColor = System.Drawing.ColorTranslator.FromHtml("#000000");

            s.Focus.MergeWith(cs);

            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#7C9AC5");
        }

        private void Vista(CellStyleCollection s)
        {
            s.Clear();

            CellStyle cs = s.Normal;
            cs.BackColor = Color.FromArgb(247, 247, 247);
            cs.Border.Width = 0;

            cs = s.Fixed;
            cs.BackgroundImage = vista.Images["Vista_Header.png"];
            cs.BackgroundImageLayout = ImageAlignEnum.TileStretch;
            cs.ForeColor = Color.FromArgb(150, s.Normal.BackColor);
            cs.Font = new Font(s.Normal.Font, FontStyle.Bold);

            cs = s.Highlight;
            cs.Clear();
            cs.BackgroundImage = vista.Images["Vista_Highlight.png"];
            cs.BackgroundImageLayout = ImageAlignEnum.TileStretch;
            cs.ForeColor = Color.Navy;

            s.Focus.MergeWith(cs);

            this.BackColor = Color.FromArgb(4, 154, 158);
        }

        private void Steel(CellStyleCollection s)
        {
            s.Clear();

            CellStyle cs = s.Normal;
            cs.BackColor = Color.FromArgb(250, 250, 250);
            cs.Border.Width = 0;

            cs = s.Fixed;
            cs.BackgroundImage = steel.Images["Steel_Header.png"];
            cs.BackgroundImageLayout = ImageAlignEnum.TileStretch;
            cs.Border.Width = 0;

            cs = s.SelectedColumnHeader;
            cs.MergeWith(s.Fixed);
            cs.BackgroundImage = steel.Images["Steel_HeaderSelected.png"];
            cs.Font = new Font(cs.Font, FontStyle.Bold);

            s.SelectedRowHeader.MergeWith(cs);

            cs = s.Highlight;
            cs.Clear();
            cs.BackColor = Color.FromArgb(150, Color.LightSteelBlue);

            s.Focus.MergeWith(cs);

            this.BackColor = Color.Gainsboro;
        }

        private void Energy(CellStyleCollection s)
        {
            s.Clear();

            CellStyle cs = s.Normal;
            cs.BackColor = Color.White;
            cs.Border.Direction = BorderDirEnum.Horizontal;
            cs.Border.Color = Color.LightGray;

            cs = s.Fixed;
            cs.BackgroundImage = energy.Images["energy_head.png"];
            cs.BackgroundImageLayout = ImageAlignEnum.TileStretch;
            cs.ForeColor = Color.FromArgb(74, 113, 0);
            cs.Font = new Font(s.Normal.Font, FontStyle.Bold);

            cs = s.Highlight;
            cs.Clear();
            cs.BackgroundImage = energy.Images["energy_sel.png"];
            cs.BackgroundImageLayout = ImageAlignEnum.TileStretch;
            cs.ForeColor = Color.FromArgb(74, 113, 0);
            cs.Font = new Font(s.Normal.Font, FontStyle.Bold);

            s.Focus.MergeWith(cs);

            this.BackColor = Color.Gainsboro;
        }

        private void Notebook(CellStyleCollection s)
        {
            s.Clear();

            CellStyle cs = s.Normal;
            cs.ForeColor = Color.SlateGray;
            cs.BackColor = Color.White;
            cs.Border.Direction = BorderDirEnum.Horizontal;
            cs.Border.Color = Color.FromArgb(196, 228, 223);
            cs.Font = new Font(s.Normal.Font, FontStyle.Italic);

            cs = s.Fixed;
            cs.BackgroundImage = notebook.Images["notebook_side.png"];
            cs.BackgroundImageLayout = ImageAlignEnum.Stretch;
            cs.Border.Direction = BorderDirEnum.Vertical;
            cs.Border.Color = Color.FromArgb(138, 84, 134);

            cs = s.Highlight;
            cs.Clear();
            cs.BackColor = Color.FromArgb(243, 252, 81);
            cs.ForeColor = Color.SlateGray;

            s.Focus.MergeWith(cs);

            c1FlexGrid1.Rows[0].Visible = false;
            c1FlexGrid1.Glyphs[GlyphEnum.Checked] = checkBoxes.Images["customCheck1.png"];
            c1FlexGrid1.Glyphs[GlyphEnum.Unchecked] = checkBoxes.Images["customUncheck1.png"];
            this.BackColor = Color.FromArgb(86, 101, 104);
        }
    }
}
