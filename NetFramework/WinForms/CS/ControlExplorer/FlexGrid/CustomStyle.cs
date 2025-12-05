using C1.Win.FlexGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ControlExplorer.FlexGrid
{
    public partial class CustomStyle : C1DemoForm
    {
        public CustomStyle()
        {
            InitializeComponent();
        }

        private void CustomStyle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'c1DemoDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.c1DemoDataSet.Products);
            c1FlexGrid1.Rows[0].Visible = false;
            ApplyNotebookStyles(c1FlexGrid1.Styles);
            c1FlexGrid1.AutoSizeCols();
        }

        private void ApplyNotebookStyles(CellStyleCollection s)
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

            c1FlexGrid1.Cols[7].DataType = typeof(bool);
            c1FlexGrid1.Glyphs[GlyphEnum.Checked] = checkBoxes.Images["customCheck2.png"];
            c1FlexGrid1.Glyphs[GlyphEnum.Unchecked] = checkBoxes.Images["customUncheck2.png"];
            this.BackColor = Color.FromArgb(86, 101, 104);
        }
    }
}
