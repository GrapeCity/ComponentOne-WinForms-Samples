using System;
using System.IO;
using System.Xml;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.FlexGrid;

namespace GridRenderer
{
    [Flags]
    public enum ColorPickers
    {
        Solid = 1,
        Gradient = 2,
        Border = 4,
        Automatic = 8
    }
    enum Part
    {
        // highlight
        Selection,

        // top left cell
        TopLeftCellBdr,
        TopLeftCell,
        TopLeftImageStart,
        TopLeftImageEnd,

        // column headers
        ColHdrStart,
        ColHdrEnd,
        ColHdrBdr,

        ColHdrSelStart,
        ColHdrSelEnd,
        ColHdrSelBdr,

        ColHdrHotStart,
        ColHdrHotEnd,
        ColHdrHotBdr,

        ColHdrHotSelStart,
        ColHdrHotSelEnd,
        ColHdrHotSelBdr,

        // row headers
        RowHdr,
        RowHdrBdr,

        RowHdrSel,
        RowHdrSelBdr,

        RowHdrHot,
        RowHdrHotBdr,

        RowHdrHotSel,
        RowHdrHotSelBdr
    }

    [ToolboxItem(false)]
    public partial class RendererEditor : Form
    {
        //-----------------------------------------------------------
        #region ** fields

        const string APP_NAME = "Renderer Editor";
        const string DEFAULT_EXTENSION = ".grpx";
        const string FILTER = "Grid Renderer Palette (*.grpx)|*.grpx|Xml Files (*.xml)|*.xml|All Files (*.*)|(*.*)";

        Color[] _palette;
        string _fileName;

        #endregion

        //-----------------------------------------------------------
        #region ** ctor

        public RendererEditor()
        {
            InitializeComponent();

            // initialize default renderer
            Renderer = new GridRendererOffice2007Blue();

            // expand tree
            _tree.ExpandAll();

            // select first node
            var nd = _tree.Nodes.Find("_ndColHdrNormal", true);
            if (nd.Length > 0)
            {
                _tree.SelectedNode = nd[0];
            }

            // initialize grid
            _flex[1, 1] = "Preview";
        }

        #endregion

        //-----------------------------------------------------------
        #region ** object model

        // gets or sets the current renderer
        public C1FlexGridRenderer Renderer
        {
            get { return _flex.Renderer; }
            set
            {
                // select a palette for the new renderer
                var palette =
                    (value is GridRendererOffice2007Blue) ? StandardPalletes.Office2007Blue :
                    (value is GridRendererOffice2007Black) ? StandardPalletes.Office2007Black :
                    (value is GridRendererOffice2007Silver) ? StandardPalletes.Office2007Silver :
                    StandardPalletes.Office2007Blue;
                _palette = palette;

                // show the new palette
                _flex.Renderer = new GridRendererOffice2007(_palette);
                UpdateColorPickers();
            }
        }

        // save the current palette to a StringBuilder
        public void SavePalette(StringBuilder stringBuilder, string paletteName)
        {
            using (var xw = XmlWriter.Create(stringBuilder, GetWriterSettings()))
            {
                SavePalette(xw, paletteName);
            }
        }

        // save the current palette to a file
        public void SavePalette(string fileName)
        {
            using (var xw = XmlWriter.Create(fileName, GetWriterSettings()))
            {
                SavePalette(xw, Path.GetFileName(fileName));
            }
        }

        // save the current palette to an XmlWriter
        public void SavePalette(XmlWriter xw, string paletteName)
        {
            xw.WriteComment(" C1FlexGrid Renderer Palette: " + paletteName + " ");
            xw.WriteStartElement("palette");
            foreach (Part p in Enum.GetValues(typeof(Part)))
            {
                xw.WriteStartElement("color");
                xw.WriteAttributeString("name", p.ToString());
                xw.WriteAttributeString("value", ColorTranslator.ToHtml(_palette[(int)p]));
                xw.WriteEndElement();
            }
            xw.WriteEndElement();
        }
        static XmlWriterSettings GetWriterSettings()
        {
            var settings = new XmlWriterSettings();
            settings.OmitXmlDeclaration = true;
            settings.Indent = true;
            return settings;
        }

        // load palette from a file
        public void LoadPalette(string fileName)
        {
            var doc = new XmlDocument();
            doc.Load(fileName);
            LoadPalette(doc);
        }

        // load palette from a string
        public void LoadPaletteXml(string xml)
        {
            var doc = new XmlDocument();
            doc.LoadXml(xml);
            LoadPalette(doc);
        }

        // load palette from an XmlDocument
        public void LoadPalette(XmlDocument doc)
        {
            // sanity
            var nodes = doc.SelectNodes("palette/color");
            if (nodes.Count < (int)Part.RowHdrHotSelBdr + 1)
            {
                throw new Exception("The file selected does not contain enough colors to define a renderer.");
            }

            // load the palette
            int index = 0;
            foreach (XmlNode node in nodes)
            {
                var value = node.Attributes["value"].Value;
                _palette[index++] = ColorTranslator.FromHtml(value);
            }

            // show the palette
            _flex.Renderer = new GridRendererOffice2007(_palette);
            UpdateColorPickers();
        }

        #endregion

        //-----------------------------------------------------------
        #region ** event handlers

        // prevent parent nodes from being selected (they have non-null Tags)
        void _tree_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Tag != null)
            {
                e.Cancel = true;
            }
        }

        // show colors for the part that was selected
        void _tree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            UpdateColorPickers();
        }

        // update the palette and the renderer when any colors change
        void _clr_ColorChanged(object sender, EventArgs e)
        {
            // save the new color back into the palette
            var cp = sender as ColorPicker;
            if (cp.Tag != null)
            {
                var index = (int)cp.Tag;
                _palette[index] = cp.Color;
                _flex.Renderer = new GridRendererOffice2007(_palette);
            }
        }

        // load standard palettes
        void standardToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // select the palette
            Color[] palette = null;
            string palName = null;
            if (e.ClickedItem == office2007BlueToolStripMenuItem)
            {
                palName = "Office 2007 Blue";
                palette = StandardPalletes.Office2007Blue;
            }
            else if (e.ClickedItem == office2007BlackToolStripMenuItem)
            {
                palName = "Office 2007 Black";
                palette = StandardPalletes.Office2007Black;
            }
            else if (e.ClickedItem == office2007SilverToolStripMenuItem)
            {
                palName = "Office 2007 Silver";
                palette = StandardPalletes.Office2007Silver;
            }

            if (palette != null)
            {
                // show the palette
                _palette = palette;
                _flex.Renderer = new GridRendererOffice2007(_palette);
                UpdateColorPickers();

                // clear file name and update app caption
                Text = string.Format("{0} - [{1}]", APP_NAME, palName);
                _fileName = null;
            }
        }

        // handle "Open" menu
        void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var dlg = new OpenFileDialog())
            {
                dlg.DefaultExt = DEFAULT_EXTENSION;
                dlg.Filter = FILTER;
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // load the palette
                        LoadPalette(dlg.FileName);

                        // save new file name and show it in the caption
                        _fileName = dlg.FileName;
                        ShowFileName();
                    }
                    catch (Exception x)
                    {
                        MessageBox.Show(this, "Error Saving File:\r\n\r\n" + x.Message, APP_NAME);
                    }
                }
            }
        }

        // handle "Save" command
        void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_fileName))
            {
                saveAsToolStripMenuItem.PerformClick();
            }
            else
            {
                try
                {
                    SavePalette(_fileName);
                }
                catch (Exception x)
                {
                    MessageBox.Show(this, "Error Saving File:\r\n\r\n" + x.Message, APP_NAME);
                }
            }
        }

        // handle "Save As" command
        void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var dlg = new SaveFileDialog())
            {
                dlg.DefaultExt = DEFAULT_EXTENSION;
                dlg.Filter = FILTER;
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    _fileName = dlg.FileName;
                    ShowFileName();
                    saveToolStripMenuItem.PerformClick();
                }
            }
        }

        // closing the form from the menu
        void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        // generate all colors automatically based on two colors provided.
        void _clrAuto_ColorChanged(object sender, EventArgs e)
        {
            // get both colors provided by the user
            var clrMain = _clrMain.Color;
            var clrSel = _clrHighlights.Color;

            // bail out if either is transparent
            if (clrMain.Equals(Color.Transparent) || clrSel.Equals(Color.Transparent) ||
                clrMain.Equals(Color.Empty) || clrSel.Equals(Color.Empty))
            {
                return;
            }

            // modify palette

            // highlight
            _palette[(int)Part.Selection] = ChangeColor(clrSel, 1.2);

            // top left cell
            _palette[(int)Part.TopLeftCellBdr] = ChangeColor(clrMain, .2);
            _palette[(int)Part.TopLeftCell] = clrMain;
            _palette[(int)Part.TopLeftImageStart] = ChangeColor(clrMain, 1.5);
            _palette[(int)Part.TopLeftImageEnd] = ChangeColor(clrMain, .5);

            // column headers
            _palette[(int)Part.ColHdrStart] = ChangeColor(clrMain, 1.5);
            _palette[(int)Part.ColHdrEnd] = ChangeColor(clrMain, .5);
            _palette[(int)Part.ColHdrBdr] = ChangeColor(clrMain, .2); ;

            _palette[(int)Part.ColHdrSelStart] = ChangeColor(clrMain, clrSel, 1.5);
            _palette[(int)Part.ColHdrSelEnd] = ChangeColor(clrMain, clrSel, .5);
            _palette[(int)Part.ColHdrSelBdr] = ChangeColor(clrMain, clrSel, .2);

            _palette[(int)Part.ColHdrHotStart] = ChangeColor(clrSel, 1.5);
            _palette[(int)Part.ColHdrHotEnd] = ChangeColor(clrSel, .5);
            _palette[(int)Part.ColHdrHotBdr] = ChangeColor(clrSel, .2);

            _palette[(int)Part.ColHdrHotSelStart] = ChangeColor(clrMain, clrSel, 1.2);
            _palette[(int)Part.ColHdrHotSelEnd] = ChangeColor(clrMain, clrSel, .4);
            _palette[(int)Part.ColHdrHotSelBdr] = ChangeColor(clrMain, clrSel, .4);

            // row headers
            _palette[(int)Part.RowHdr] = clrMain;
            _palette[(int)Part.RowHdrBdr] = ChangeColor(clrMain, .2);

            _palette[(int)Part.RowHdrSel] = ChangeColor(clrMain, clrSel, 1);
            _palette[(int)Part.RowHdrSelBdr] = ChangeColor(clrMain, clrSel, .2);

            _palette[(int)Part.RowHdrHot] = ChangeColor(clrSel, 1);
            _palette[(int)Part.RowHdrHotBdr] = ChangeColor(clrSel, .2);

            _palette[(int)Part.RowHdrHotSel] = ChangeColor(clrMain, clrSel, 1);
            _palette[(int)Part.RowHdrHotSelBdr] = ChangeColor(clrMain, clrSel, .4);

            // show new palette
            _flex.Renderer = new GridRendererOffice2007(_palette);
        }

        #endregion

        //-----------------------------------------------------------
        #region ** implementation

        // update color pickers to reflect the current node selection/palette
        void UpdateColorPickers()
        {
            if (_tree.SelectedNode != null)
            {
                switch (_tree.SelectedNode.Name)
                {
                    // column headers: gradient, border
                    case "_ndColHdrNormal":
                        BindColorPicker(_clrGradStart, Part.ColHdrStart);
                        BindColorPicker(_clrGradEnd, Part.ColHdrEnd);
                        BindColorPicker(_clrBorder, Part.ColHdrBdr);
                        ShowColorPickers(ColorPickers.Gradient | ColorPickers.Border);
                        break;
                    case "_ndColHdrSelected":
                        BindColorPicker(_clrGradStart, Part.ColHdrSelStart);
                        BindColorPicker(_clrGradEnd, Part.ColHdrSelEnd);
                        BindColorPicker(_clrBorder, Part.ColHdrSelBdr);
                        ShowColorPickers(ColorPickers.Gradient | ColorPickers.Border);
                        break;
                    case "_ndColHdrHot":
                        BindColorPicker(_clrGradStart, Part.ColHdrHotStart);
                        BindColorPicker(_clrGradEnd, Part.ColHdrHotEnd);
                        BindColorPicker(_clrBorder, Part.ColHdrHotBdr);
                        ShowColorPickers(ColorPickers.Gradient | ColorPickers.Border);
                        break;
                    case "_ndColHdrSelectedHot":
                        BindColorPicker(_clrGradStart, Part.ColHdrHotSelStart);
                        BindColorPicker(_clrGradEnd, Part.ColHdrHotSelEnd);
                        BindColorPicker(_clrBorder, Part.ColHdrHotSelBdr);
                        ShowColorPickers(ColorPickers.Gradient | ColorPickers.Border);
                        break;

                    // row headers: solid, border
                    case "_ndRowHdrNormal":
                        BindColorPicker(_clrSolid, Part.RowHdr);
                        BindColorPicker(_clrBorder, Part.RowHdrBdr);
                        ShowColorPickers(ColorPickers.Solid | ColorPickers.Border);
                        break;
                    case "_ndRowHdrSelected":
                        BindColorPicker(_clrSolid, Part.RowHdrSel);
                        BindColorPicker(_clrBorder, Part.RowHdrSelBdr);
                        ShowColorPickers(ColorPickers.Solid | ColorPickers.Border);
                        break;
                    case "_ndRowHdrHot":
                        BindColorPicker(_clrSolid, Part.RowHdrHot);
                        BindColorPicker(_clrBorder, Part.RowHdrHotBdr);
                        ShowColorPickers(ColorPickers.Solid | ColorPickers.Border);
                        break;
                    case "_ndRowHdrSelectedHot":
                        BindColorPicker(_clrSolid, Part.RowHdrHotSel);
                        BindColorPicker(_clrBorder, Part.RowHdrHotSelBdr);
                        ShowColorPickers(ColorPickers.Solid | ColorPickers.Border);
                        break;

                    // top left cell: solid, border
                    case "_ndCell":
                        BindColorPicker(_clrSolid, Part.TopLeftCell);
                        BindColorPicker(_clrBorder, Part.TopLeftCellBdr);
                        ShowColorPickers(ColorPickers.Solid | ColorPickers.Border);
                        break;

                    // top left cell image: gradient
                    case "_ndImage":
                        BindColorPicker(_clrGradStart, Part.TopLeftImageStart);
                        BindColorPicker(_clrGradEnd, Part.TopLeftImageEnd);
                        ShowColorPickers(ColorPickers.Gradient);
                        break;

                    // selection: solid
                    case "_ndSelection":
                        BindColorPicker(_clrSolid, Part.Selection);
                        ShowColorPickers(ColorPickers.Solid);
                        break;

                    // automatic: custom panel
                    case "_ndAutomatic":
                        ShowColorPickers(ColorPickers.Automatic);
                        break;
                }
            }
        }

        // show only color pickers that apply to the current selection
        void ShowColorPickers(ColorPickers editors)
        {
            _panelSolid.Visible = (editors & ColorPickers.Solid) != 0;
            _panelGradient.Visible = (editors & ColorPickers.Gradient) != 0;
            _panelBorder.Visible = (editors & ColorPickers.Border) != 0;
            _panelAuto.Visible = (editors & ColorPickers.Automatic) != 0;
        }

        // bind a color picker to a palette value
        void BindColorPicker(ColorPicker picker, Part part)
        {
            picker.Tag = part;
            picker.Color = _palette[(int)part];
        }

        // show file name in the form caption
        void ShowFileName()
        {
            Text = string.Format("{0} - {1}",
                APP_NAME,
                Path.GetFileName(_fileName));
        }

        // combine two colors and make the result lighter or darker
        Color ChangeColor(Color c1, Color c2, double scale)
        {
            Color c = Color.FromArgb(
                (c1.A + c2.A) / 2,
                (c1.R + c2.R) / 2,
                (c1.G + c2.G) / 2,
                (c1.B + c2.B) / 2);
            return ChangeColor(c, scale);
        }

        // make a color lighter or darker
        Color ChangeColor(Color c, double scale)
        {
            return Color.FromArgb(
                c.A,
                (int)Math.Min(255, (c.R * scale)),
                (int)Math.Min(255, (c.G * scale)),
                (int)Math.Min(255, (c.B * scale)));
        }

        #endregion
    }
}
