using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Renderer
{
    public partial class CustomRendererForm : Form
    {
        public CustomRendererForm()
        {
            InitializeComponent();

            //c1FlexGrid1.Renderer = new CustomGridRenderer(GetColors());
        }
        private void _btnHighlight_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            using (var dlg = new ColorDialog())
            {
                dlg.Color = btn.BackColor;
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    // save new base color
                    btn.BackColor = dlg.Color;

                    // show effect in preview grid
                    //c1FlexGrid1.Renderer = new CustomGridRenderer(GetColors());
                }
            }
        }
        public Color[] GetColors()
        {
            Color highlight = (Color)_btnHighlight.BackColor;
            Color headers = (Color)_btnHeaders.BackColor;
            Color selection = (Color)_btnSelection.BackColor;
            Color hot = (Color)_btnHot.BackColor;

            var hotSel = Interpolate(selection, hot);
            Color[] colors = new Color[]
            {
                highlight,	                    // clrHighlight
                Darker(headers),	            // clrTopLeftBorder 
                Darker(headers),	            // clrTopLeft
                Lighter(headers),	            // clrImg1
                Darker(headers),	            // clrImg2 
                Lighter(headers),	            // clrCol1
                headers,	                    // clrCol2
                Darker(headers),         	    // clrColBorder
                Lighter(selection),	            // clrColSel1
                selection,	                    // clrColSel2
                Darker(selection),	            // clrSelBorder
                Lighter(hot),	                // clrColHot1
                hot,                            // clrColHot2
                Darker(hot),	                // clrHotBorder
                Lighter(hotSel),	            // clrColSelHot1
                hotSel,	                        // clrColSelHot2
                Darker(hotSel),	                // clrSelHotBorder
                headers,	                    // clrRow
                Darker(headers),	            // clrRowBorder 
                selection,	                    // clrRowSel
                Darker(selection),	            // clrRowSelBorder
                hot,	                        // clrRowHot
                Darker(hot),	                // clrRowHotBorder
                hotSel,	                        // clrRowSelHot
                Darker(hotSel),	                // clrRowSelHotBorder
            };
            return colors;
        }
        static Color Interpolate(Color c1, Color c2)
        {
            return Color.FromArgb(
                (byte)((c1.R + c2.R) / 2),
                (byte)((c1.G + c2.G) / 2),
                (byte)((c1.B + c2.B) / 2));
        }
        static Color Lighter(Color c)
        {
            return Color.FromArgb(
                (byte)(c.R + (255 - c.R) / 2),
                (byte)(c.G + (255 - c.G) / 2),
                (byte)(c.B + (255 - c.B) / 2));
        }
        static Color Darker(Color c)
        {
            return Color.FromArgb(
                (byte)(c.R * 2 / 3),
                (byte)(c.G * 2 / 3),
                (byte)(c.B * 2 / 3));
        }
    }
}
