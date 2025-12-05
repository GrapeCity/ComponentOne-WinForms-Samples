using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.FlexGrid;

namespace Renderer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // set dimensions
            _flex.Rows.Count = _names.Length + 1;
            _flex.Cols.Count = 5;

            // set data types and custom editor
            var cp = new ColorPicker();
            for (int i = 1; i < 5; i++)
            {
                _flex.Cols[i].DataType = typeof(Color);
                _flex.Cols[i].Editor = cp;
            }

            // set column titlese
            _flex[0, 1] = "Blue";
            _flex[0, 2] = "Silver";
            _flex[0, 3] = "Black";
            _flex[0, 4] = "Custom";

            // apply back color when cell value changes
            _flex.CellChanged += _flex_CellChanged;

            // set row titles and cell data
            for (int i = 0; i < _names.Length; i++)
            {
                _flex[i + 1, 0] = _names[i];
                _flex[i + 1, 1] = _vsBlue[i];
                _flex[i + 1, 2] = _vsSilver[i];
                _flex[i + 1, 3] = _vsBlack[i];
                _flex[i + 1, 4] = _vsBlack[i];
            }

            // autosize fixed column
            _flex.AutoSizeCol(0);
        }

        void _flex_CellChanged(object sender, C1.Win.FlexGrid.RowColEventArgs e)
        {
            var value = _flex[e.Row, e.Col];
            if (value is Color)
            {
                var rg = _flex.GetCellRange(e.Row, e.Col);
                rg.StyleNew.BackColor = (Color)value;
            }
        }

        string[] _names = new string[]
            {
                "clrHighlight",
                "clrTopLeftBorder",
                "clrTopLeft",
                "clrImg1",
                "clrImg2",
                "clrCol1",
                "clrCol2",
                "clrColBorder",
                "clrColSel1",
                "clrColSel2",
                "clrSelBorder",
                "clrColHot1",
                "clrColHot2",
                "clrHotBorder",
                "clrColSelHot1",
                "clrColSelHot2",
                "clrSelHotBorder",
                "clrRow",
                "clrRowBorder",
                "clrRowSel",
                "clrRowSelBorder",
                "clrRowHot",
                "clrRowHotBorder",
                "clrRowSelHot",
                "clrRowSelHotBorder"
            };
        Color[] _vsBlue = new Color[] 
            {
                Color.FromArgb(234,236,245),	// clrHighlight
                Color.FromArgb(208,215,229),	// clrTopLeftBorder 
                Color.FromArgb(169,196,233),	// clrTopLeft
                Color.FromArgb(249,250,251),	// clrImg1
                Color.FromArgb(215,218,226),	// clrImg2 
                Color.FromArgb(249,252,253),	// clrCol1
                Color.FromArgb(211,219,233),	// clrCol2
                Color.FromArgb(158,182,206),	// clrColBorder
                Color.FromArgb(249,217,159),	// clrColSel1
                Color.FromArgb(241,193,95),	    // clrColSel2
                Color.FromArgb(242,149,53),	    // clrSelBorder
                Color.FromArgb(221,224,227),	// clrColHot1
                Color.FromArgb(188,197,210),	// clrColHot2
                Color.FromArgb(135,159,183),	// clrHotBorder
                Color.FromArgb(255,213,141),	// clrColSelHot1
                Color.FromArgb(242,146,59),	    // clrColSelHot2
                Color.FromArgb(242,146,59),	    // clrSelHotBorder
                Color.FromArgb(228,236,247),	// clrRow
                Color.FromArgb(158,182,206),	// clrRowBorder 
                Color.FromArgb(255,213,141),	// clrRowSel
                Color.FromArgb(242,149,53),	    // clrRowSelBorder
                Color.FromArgb(187,196,209),	// clrRowHot
                Color.FromArgb(135,159,183),	// clrRowHotBorder
                Color.FromArgb(241,192,92),	    // clrRowSelHot
                Color.FromArgb(242,149,53),	    // clrRowSelHotBorder
            };
        Color[] _vsSilver = new Color[]
            {
                Color.FromArgb(234,236,245),	// clrHighlight
                Color.FromArgb(208,215,229),	// clrTopLeftBorder 
                Color.FromArgb(198,198,198),	// clrTopLeft
                Color.FromArgb(253,253,253),	// clrImg1
                Color.FromArgb(239,239,239),	// clrImg2 
                Color.FromArgb(241,243,243),	// clrCol1
                Color.FromArgb(202,203,204),	// clrCol2
                Color.FromArgb(144,145,146),	// clrColBorder
                Color.FromArgb(255,204,153),	// clrColSel1
                Color.FromArgb(255,155,103),	// clrColSel2
                Color.FromArgb(212,118,61),	    // clrSelBorder
                Color.FromArgb(208,208,208),	// clrColHot1
                Color.FromArgb(166,166,166),	// clrColHot2
                Color.FromArgb(166,166,166),	// clrHotBorder
                Color.FromArgb(215,215,215),	// clrColSelHot1
                Color.FromArgb(164,164,164),	// clrColSelHot2
                Color.FromArgb(212,118,61),	    // clrSelHotBorder
                Color.FromArgb(231,231,231),	// clrRow
                Color.FromArgb(144,145,146),	// clrRowBorder 
                Color.FromArgb(245,199,149),	// clrRowSel
                Color.FromArgb(212,118,61),	    // clrRowSelBorder
                Color.FromArgb(184,191,196),	// clrRowHot
                Color.FromArgb(157,163,169),	// clrRowHotBorder
                Color.FromArgb(237,139,78),	    // clrRowSelHot
                Color.FromArgb(212,118,61),	    // clrRowSelHotBorder
            };
        Color[] _vsBlack = new Color[] 
            {
                Color.FromArgb(234,236,245),	// clrHighlight
                Color.FromArgb(208,215,229),	// clrTopLeftBorder 
                Color.FromArgb(201,201,201),	// clrTopLeft
                Color.FromArgb(173,173,173),	// clrImg1
                Color.FromArgb(103,103,103),	// clrImg2 
                Color.FromArgb(248,248,248),	// clrCol1
                Color.FromArgb(222,222,222),	// clrCol2
                Color.FromArgb(182,182,182),	// clrColBorder
                Color.FromArgb(249,217,159),	// clrColSel1
                Color.FromArgb(241,193,95),	    // clrColSel2
                Color.FromArgb(242,149,53),	    // clrSelBorder
                Color.FromArgb(224,224,224),	// clrColHot1
                Color.FromArgb(195,195,195),	// clrColHot2
                Color.FromArgb(182,182,182),	// clrHotBorder
                Color.FromArgb(255,213,141),	// clrColSelHot1
                Color.FromArgb(242,146,59),	    // clrColSelHot2
                Color.FromArgb(242,149,53),	    // clrSelHotBorder
                Color.FromArgb(237,237,237),	// clrRow
                Color.FromArgb(182,182,182),	// clrRowBorder 
                Color.FromArgb(255,213,141),	// clrRowSel
                Color.FromArgb(242,149,53),	    // clrRowSelBorder
                Color.FromArgb(241,192,92),	    // clrRowHot
                Color.FromArgb(182,182,182),	// clrRowHotBorder
                Color.FromArgb(241,192,92),	    // clrRowSelHot
                Color.FromArgb(242,149,53),	    // clrRowSelHotBorder
            };

        // handle menu events
        private void resetToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == blueToolStripMenuItem)
            {
                SetCustomColors(_vsBlue);
            }
            else if (e.ClickedItem == silverToolStripMenuItem)
            {
                SetCustomColors(_vsSilver);
            }
            else if (e.ClickedItem == blackToolStripMenuItem)
            {
                SetCustomColors(_vsBlack);
            }
        }

        // handle menu events
        private void showCustomToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == showToolStripMenuItem)
            {
                ShowCustomRenderer();
            }
            else if (e.ClickedItem == copyToClipboardToolStripMenuItem)
            {
                CopyCustomRenderer();
            }
            else if (e.ClickedItem == quickBuilderToolStripMenuItem)
            {
                using (var dlg = new CustomRendererForm())
                {
                    dlg.Font = this.Font;
                    if (dlg.ShowDialog(this) == DialogResult.OK)
                    {
                        SetCustomColors(dlg.GetColors());
                        ShowCustomRenderer();
                    }
                }
            }
        }

        // copy colors to "custom" column
        void SetCustomColors(Color[] styleColors)
        {
            for (int i = 0; i < styleColors.Length; i++)
            {
                _flex[i + 1, 4] = styleColors[i];
            }
        }

        // show custom renderer in action in a new form
        void ShowCustomRenderer()
        {
            // build array with custom colors
            var colors = new List<Color>();
            for (int i = 0; i < _vsBlack.Length; i++)
            {
                colors.Add((Color)_flex[i + 1, 4]);
            }

            // build custom renderer using the selected colors
            var r = new CustomGridRenderer(colors.ToArray());

            // show the result
            PreviewForm f = new PreviewForm();
            f.CustomGrid.Renderer = r;
            f.StartPosition = FormStartPosition.Manual;
            f.Bounds = this.Bounds;
            f.Font = this.Font;
            f.ShowDialog(this);
        }

        // copy custom renderer definition to clipboard
        void CopyCustomRenderer()
        {
            // copy the custom renderer definition to the clipboard
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < _vsBlack.Length; i++)
            {
                Color c = (Color)_flex[i + 1, 4];
                if (i > 0)
                {
                    sb.Append(", ");
                    if (i % 3 == 0)
                    {
                        sb.Append("\r\n\t\t");
                    }
                }
                sb.AppendFormat("Color.FromArgb({0}, {1}, {2})", c.R, c.G, c.B);
            }
            var fmt =
                "public class CustomGridRenderer : GridRendererOffice2007\r\n" +
                "{\r\n" +
                "\tpublic CustomGridRenderer(Color[] colors)\r\n" +
                "\t: base({0})\r\n" +
                "\t{\r\n" +
                "\t}\r\n" +
                "}";
            var classDefinition = fmt.Replace("{0}", sb.ToString());
            Clipboard.SetData(DataFormats.Text, classDefinition);
        }
    }
}
