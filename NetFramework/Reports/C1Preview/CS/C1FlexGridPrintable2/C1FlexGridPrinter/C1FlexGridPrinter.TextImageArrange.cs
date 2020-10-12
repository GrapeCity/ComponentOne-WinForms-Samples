using System.Collections.Generic;
using System.Drawing;
using System.Diagnostics;
using C1.C1Preview;

namespace C1.Win.C1FlexGrid
{
    // this file contains code that arranges text and image within a cell
    public partial class C1FlexGridPrinter
    {
        /// <summary>
        /// Holds horizontal and vertical text alignment in <see cref="C1PrintDocument"/> terms.
        /// </summary>
        private struct TextAlignInfo
        {
            /// <summary>Horizontal text alignment.</summary>
            public AlignHorzEnum Horz;
            /// <summary>Vertical text alignment.</summary>
            public AlignVertEnum Vert;
            /// <summary>Initializes a new instance of TextAlignInfo struct.</summary>
            /// <param name="horz">Horizontal text alignment.</param>
            /// <param name="vert">Vertical text alignment.</param>
            public TextAlignInfo(AlignHorzEnum horz, AlignVertEnum vert)
            {
                Horz = horz;
                Vert = vert;
            }
        }

        /// <summary>
        /// Associates C1FlexGrid text alignment with C1PrintDocument text alignment.
        /// </summary>
        private static Dictionary<TextAlignEnum, TextAlignInfo> s_TextAlignToTA = new Dictionary<TextAlignEnum, TextAlignInfo>()
        {
            { TextAlignEnum.CenterBottom, new TextAlignInfo(AlignHorzEnum.Center, AlignVertEnum.Bottom) },
            { TextAlignEnum.CenterCenter, new TextAlignInfo(AlignHorzEnum.Center, AlignVertEnum.Center) },
            { TextAlignEnum.CenterTop, new TextAlignInfo(AlignHorzEnum.Center, AlignVertEnum.Top) },
            { TextAlignEnum.LeftBottom, new TextAlignInfo(AlignHorzEnum.Left, AlignVertEnum.Bottom) },
            { TextAlignEnum.LeftCenter, new TextAlignInfo(AlignHorzEnum.Left, AlignVertEnum.Center) },
            { TextAlignEnum.LeftTop, new TextAlignInfo(AlignHorzEnum.Left, AlignVertEnum.Top) },
            { TextAlignEnum.RightBottom, new TextAlignInfo(AlignHorzEnum.Right, AlignVertEnum.Bottom) },
            { TextAlignEnum.RightCenter, new TextAlignInfo(AlignHorzEnum.Right, AlignVertEnum.Center) },
            { TextAlignEnum.RightTop, new TextAlignInfo(AlignHorzEnum.Right, AlignVertEnum.Top) },
            // "general" alignments should not appear here - if they do that is an error (will cause an exception in code).
            // { TextAlignEnum.GeneralBottom, new TextAlignPair() },
            // { TextAlignEnum.GeneralCenter, new TextAlignPair() },
            // { TextAlignEnum.GeneralTop, new TextAlignPair() },
        };

        /// <summary>
        /// Holds horizontal and vertical image alignment in <see cref="C1PrintDocument"/> terms.
        /// </summary>
        private struct ImageAlignInfo
        {
            /// <summary>Horizontal image alignment.</summary>
            public ImageAlignHorzEnum Horz;
            /// <summary>Vertical image alignment.</summary>
            public ImageAlignVertEnum Vert;
            /// <summary>Initializes a new instance of ImageAlignInfo struct.</summary>
            /// <param name="horz">Horizontal image alignment.</param>
            /// <param name="vert">Vertical image alignment.</param>
            public ImageAlignInfo(ImageAlignHorzEnum horz, ImageAlignVertEnum vert)
            {
                Horz = horz;
                Vert = vert;
            }
        }

        /// <summary>
        /// Associates C1FlexGrid image alignment with C1PrintDocument image alignment.
        /// </summary>
        private static Dictionary<ImageAlignEnum, ImageAlignInfo> s_ImageAlignToIA = new Dictionary<ImageAlignEnum, ImageAlignInfo>()
        {
            { ImageAlignEnum.LeftTop, new ImageAlignInfo(ImageAlignHorzEnum.Left, ImageAlignVertEnum.Top) },
            { ImageAlignEnum.LeftCenter, new ImageAlignInfo(ImageAlignHorzEnum.Left, ImageAlignVertEnum.Center) },
            { ImageAlignEnum.LeftBottom, new ImageAlignInfo(ImageAlignHorzEnum.Left, ImageAlignVertEnum.Bottom) },
            { ImageAlignEnum.CenterTop, new ImageAlignInfo(ImageAlignHorzEnum.Center, ImageAlignVertEnum.Top) },
            { ImageAlignEnum.CenterCenter, new ImageAlignInfo(ImageAlignHorzEnum.Center, ImageAlignVertEnum.Center) },
            { ImageAlignEnum.CenterBottom, new ImageAlignInfo(ImageAlignHorzEnum.Center, ImageAlignVertEnum.Bottom) },
            { ImageAlignEnum.RightTop, new ImageAlignInfo(ImageAlignHorzEnum.Right, ImageAlignVertEnum.Top) },
            { ImageAlignEnum.RightCenter, new ImageAlignInfo(ImageAlignHorzEnum.Right, ImageAlignVertEnum.Center) },
            { ImageAlignEnum.RightBottom, new ImageAlignInfo(ImageAlignHorzEnum.Right, ImageAlignVertEnum.Bottom) },
            //
            { ImageAlignEnum.Scale, new ImageAlignInfo(ImageAlignHorzEnum.Center, ImageAlignVertEnum.Center) },
            { ImageAlignEnum.Stretch, new ImageAlignInfo(ImageAlignHorzEnum.Center, ImageAlignVertEnum.Center) },
            // todo: those two are not supported:
            { ImageAlignEnum.Tile, new ImageAlignInfo(ImageAlignHorzEnum.Center, ImageAlignVertEnum.Center) },
            { ImageAlignEnum.TileStretch, new ImageAlignInfo(ImageAlignHorzEnum.Center, ImageAlignVertEnum.Center) },
        };

        /// <summary>
        /// Specifies, in FlexGrid logic, position of image relative to text
        /// (used to account - or not - for image when positioning text).
        /// </summary>
        private enum ImageOn
        {
            None,
            Left,
            Right,
            Top,
            Bottom,
        }

        /// <summary>
        /// Associates CheckEnum values with corresponding glyphs.
        /// </summary>
        private static Dictionary<CheckEnum, GlyphEnum> s_CheckToGlyph = new Dictionary<CheckEnum, GlyphEnum>()
        {
            { CheckEnum.Checked, GlyphEnum.Checked },
            { CheckEnum.Grayed, GlyphEnum.Grayed },
            { CheckEnum.TSChecked, GlyphEnum.Checked },
            { CheckEnum.TSGrayed, GlyphEnum.Grayed  },
            { CheckEnum.TSUnchecked, GlyphEnum.Unchecked },
            { CheckEnum.Unchecked, GlyphEnum.Unchecked },
        };

        /// <summary>
        /// Used to position the RenderImage within the cell.
        /// NOTE: this method should only be used when the cell contains BOTH
        /// a RenderImage and a RenderText, in a RenderArea.
        /// Do not use for image only (style image alignment should be enough then).
        /// </summary>
        /// <param name="rimg">The image render object.</param>
        /// <param name="cellStyle">The cell style.</param>
        /// <param name="overlay">Whether image overlays the text.</param>
        /// <returns>Position of image relative to text, in flex grid logic.</returns>
        private ImageOn AlignImage(RenderObject rimg, CellStyle cellStyle, bool overlay)
        {
            ImageOn ion;
            switch (cellStyle.ImageAlign)
            {
                case ImageAlignEnum.LeftTop:
                    ion = ImageOn.Left;
                    break;
                case ImageAlignEnum.LeftCenter:
                    rimg.Y = "(parent.height - height) / 2";
                    ion = ImageOn.Left;
                    break;
                case ImageAlignEnum.LeftBottom:
                    rimg.Y = "parent.height - height";
                    ion = ImageOn.Left;
                    break;
                case ImageAlignEnum.CenterTop:
                    rimg.X = "(parent.width - width) / 2";
                    ion = ImageOn.Top;
                    break;
                case ImageAlignEnum.CenterCenter:
                    rimg.X = "(parent.width - width) / 2";
                    rimg.Y = "(parent.height - height) / 2";
                    ion = ImageOn.None;
                    break;
                case ImageAlignEnum.CenterBottom:
                    rimg.X = "(parent.width - width) / 2";
                    rimg.Y = "parent.height - height";
                    ion = ImageOn.Bottom;
                    break;
                case ImageAlignEnum.RightTop:
                    rimg.X = "parent.width - width";
                    ion = ImageOn.Right;
                    break;
                case ImageAlignEnum.RightCenter:
                    rimg.X = "parent.width - width";
                    rimg.Y = "(parent.height - height) / 2";
                    ion = ImageOn.Right;
                    break;
                case ImageAlignEnum.RightBottom:
                    rimg.X = "parent.width - width";
                    rimg.Y = "parent.height - height";
                    ion = ImageOn.Right;
                    break;
                case ImageAlignEnum.Scale:
                    rimg.Width = "100%";
                    rimg.Height = "100%";
                    ion = ImageOn.None;
                    break;
                case ImageAlignEnum.Stretch:
                    // todo: cache style:
                    rimg.Style.ImageAlign.KeepAspectRatio = false;
                    rimg.Width = "100%";
                    rimg.Height = "100%";
                    ion = ImageOn.None;
                    break;
                case ImageAlignEnum.Hide:
                case ImageAlignEnum.Tile:
                case ImageAlignEnum.TileStretch:
                    // todo
                default:
                    Debug.Assert(false); // qq
                    ion = ImageOn.None;
                    break;
            }

            if (overlay)
                ion = ImageOn.None;

            Unit imageSpacing = PixelsToUnit(cellStyle.ImageSpacing);
            // todo: cache/reuse those styles as well:
            switch (ion)
            {
                case ImageOn.Left:
                    rimg.Style.Padding.Right = imageSpacing;
                    break;
                case ImageOn.Top:
                    rimg.Style.Padding.Bottom = imageSpacing;
                    break;
                case ImageOn.Right:
                    rimg.Style.Padding.Left = imageSpacing;
                    break;
                case ImageOn.Bottom:
                    rimg.Style.Padding.Top = imageSpacing;
                    break;
            }
            return ion;
        }

        /// <summary>
        /// Used to position text within the cell relative to image.
        /// This method assumes that the cell (represented by a RenderArea) contains
        /// both image and text, and that the image (RenderImage) is the first child
        /// within the render area (referenced by "prev" in position strings).
        /// </summary>
        /// <param name="rtxt"></param>
        /// <param name="ta"></param>
        /// <param name="ion"></param>
        private void AlignText(RenderObject rtxt, TextAlignEnum ta, ImageOn ion)
        {
            switch (ta)
            {
                case TextAlignEnum.LeftTop:
                    rtxt.X = ion == ImageOn.Left ? "prev.right" : "0";
                    rtxt.Y = ion == ImageOn.Top ? "prev.bottom" : "0";
                    break;
                case TextAlignEnum.LeftCenter:
                    rtxt.X = ion == ImageOn.Left ? "prev.right" : "0";
                    rtxt.Y = ion == ImageOn.Top ? "prev.bottom + (parent.height - prev.height - height) / 2" :
                        (ion == ImageOn.Bottom ? "(parent.height - prev.height - height) / 2" : "(parent.height - height) / 2");
                    break;
                case TextAlignEnum.LeftBottom:
                    rtxt.X = ion == ImageOn.Left ? "prev.right" : "0";
                    rtxt.Y = ion == ImageOn.Bottom ? "prev.top - height" : "parent.height - height";
                    break;
                case TextAlignEnum.CenterTop:
                    rtxt.X = ion == ImageOn.Left ? "prev.right + (parent.width - prev.width - width) / 2" :
                        (ion == ImageOn.Right ? "(parent.width - prev.width - width) / 2" : "(parent.width - width) / 2");
                    rtxt.Y = ion == ImageOn.Top ? "prev.bottom" : "0";
                    break;
                case TextAlignEnum.CenterCenter:
                    rtxt.X = ion == ImageOn.Left ? "prev.right + (parent.width - prev.width - width) / 2" :
                        (ion == ImageOn.Right ? "(parent.width - prev.width - width) / 2" : "(parent.width - width) / 2");
                    rtxt.Y = ion == ImageOn.Top ? "prev.bottom + (parent.height - prev.height - height) / 2" :
                        (ion == ImageOn.Bottom ? "(parent.height - prev.height - height) / 2" : "(parent.height - height) / 2");
                    break;
                case TextAlignEnum.CenterBottom:
                    rtxt.X = ion == ImageOn.Left ? "prev.right + (parent.width - prev.width - width) / 2" :
                        (ion == ImageOn.Right ? "(parent.width - prev.width - width) / 2" : "(parent.width - width) / 2");
                    rtxt.Y = ion == ImageOn.Bottom ? "prev.top - height" : "parent.height - height";
                    break;
                case TextAlignEnum.RightTop:
                    rtxt.X = ion == ImageOn.Right ? "prev.left - width" : "parent.width - width";
                    rtxt.Y = ion == ImageOn.Top ? "prev.bottom" : "0";
                    break;
                case TextAlignEnum.RightCenter:
                    rtxt.X = ion == ImageOn.Right ? "prev.left - width" : "parent.width - width";
                    rtxt.Y = ion == ImageOn.Top ? "prev.bottom + (parent.height - prev.height - height) / 2" :
                        (ion == ImageOn.Bottom ? "(parent.height - prev.height - height) / 2" : "(parent.height - height) / 2");
                    break;
                case TextAlignEnum.RightBottom:
                    rtxt.X = ion == ImageOn.Right ? "prev.left - width" : "parent.width - width";
                    rtxt.Y = ion == ImageOn.Bottom ? "prev.top - height" : "parent.height - height";
                    break;
                default:
                    // "general" alignments should not get here
                    Debug.Assert(false);
                    break;
            }
        }

        /// <summary>
        /// Makes render object representing a grid cell. That render object
        /// may be inserted into the corresponding RenderTable's cell, or
        /// for tree grids, into a RenderArea that combines the cell with tree glyphs.
        /// </summary>
        /// <param name="row">Grid row index.</param>
        /// <param name="col">Grid column index.</param>
        /// <param name="cellStyle">Cell style. May be modified by owner-drawn cells.</param>
        /// <param name="text">The cell text.</param>
        /// <returns>The render object representing the cell.
        /// The type of object varies depending on the cell's content - it can be
        /// a RenderText, a RenderImage, or a RenderArea containing both.
        /// </returns>
        private RenderObject MakeCellRO(int row, int col, ref CellStyle cellStyle, out string text)
        {
            Image image;
            CheckEnum chk;
            text = _grid.GetDataDisplay(row, col, out image, out chk);
            // special treatment of bool columns - suppress text if a checkbox is drawn:
            if (cellStyle.DataType == typeof(bool) && chk != CheckEnum.None)
                text = null;

            // handle owner-drawn cells:
            if (_grid.DrawMode == DrawModeEnum.OwnerDraw && _grid2 != null)
            {
                // note: the next call may modify cell's style, text and image while returning null.
                RenderObject ro = _grid2.MakeOwnerDrawCellRO(row, col, ref cellStyle, ref text, ref image);
                if (ro != null)
                    return ro;
                // else process as regular (non-ownerdraw) cell; taking into consideration
                // the possibly modified cell style, text and image.
            }

            bool overlay = false;
            bool hasImage = image != null || chk != CheckEnum.None;
            switch (cellStyle.Display)
            {
                case DisplayEnum.ImageOnly:
                    text = null;
                    break;
                case DisplayEnum.None:
                    text = null;
                    hasImage = false;
                    break;
                case DisplayEnum.Overlay:
                    overlay = true;
                    break;
                case DisplayEnum.Stack:
                    break;
                case DisplayEnum.TextOnly:
                    hasImage = false;
                    break;
                default:
                    Debug.Assert(false);
                    break;
            }
            if (cellStyle.ImageAlign == ImageAlignEnum.Hide)
                hasImage = false;

            if (string.IsNullOrEmpty(text) && !hasImage)
                return null;
            else if (!hasImage)
                return MakeTextRO(text, null);
            else if (string.IsNullOrEmpty(text))
                return MakeImageRO(image, chk, null);
            else
            {
                RenderObject rimg = MakeImageRO(image, chk, "img");
                RenderObject rtxt = MakeTextRO(text, "txt");

                ImageOn ion = AlignImage(rimg, cellStyle, overlay);
                AlignText(rtxt, GetTextAlign(cellStyle, cellStyle.DataType, text), ion);

                RenderArea ra = new RenderArea();
                ra.Stacking = StackingRulesEnum.BlockLeftToRight;
                ra.Children.Add(rimg);
                ra.Children.Add(rtxt);
                if (ion == ImageOn.Left || ion == ImageOn.Right)
                    ra.Width = "img.width + txt.width";
                else if (ion == ImageOn.Top || ion == ImageOn.Bottom)
                    ra.Height = "img.height + txt.height";
                else
                {
                    ra.Width = Unit.Auto;
                    ra.Height = Unit.Auto;
                }
                return ra;
            }
        }

        /// <summary>
        /// Makes render object representing the cell image.
        /// </summary>
        /// <param name="image">The cell image.</param>
        /// <param name="chk">The cell check status.</param>
        /// <param name="name">The name for the created render object (may be null).</param>
        /// <returns>The render object representing the cell image.</returns>
        private RenderObject MakeImageRO(Image image, CheckEnum chk, string name)
        {
            if (chk != CheckEnum.None)
                return MakeCheckboxRO(chk, name);
            else
            {
                RenderImage rimg = new RenderImage(image);
                if (!string.IsNullOrEmpty(name))
                    rimg.Name = name;
                return rimg;
            }

            // todo:
            // In grid, ImageSpacing covers text if there's not enough space for both;
            // to mimic that behavior, rimg must opaquely cover text - for that to work,
            // we must set rimg.Style.BackColor to a non-transparent color (White IS transparent),
            // e.g. with some off-white like 255,255,254.
            // If we do that, we must also cache those styles (as main styles) to improve performance...
            // rimg.Style.BackColor = Color.White;
        }

        /// <summary>
        /// Makes render object representing the cell text.
        /// </summary>
        /// <param name="text">The cell text.</param>
        /// <param name="name">The name for the created render object (may be null).</param>
        /// <returns>The render object representing the cell text.</returns>
        private RenderObject MakeTextRO(string text, string name)
        {
            RenderText rtxt = new RenderText(text ?? "");
            if (!string.IsNullOrEmpty(name))
                rtxt.Name = name;
            rtxt.Width = Unit.Auto;
            return rtxt;
        }

        /// <summary>
        /// Makes render object representing a check mark.
        /// </summary>
        /// <param name="chk">The check status (must not be None).</param>
        /// <param name="name">The name for the created render object (may be null).</param>
        /// <returns>The render object representing the check mark.</returns>
        private RenderObject MakeCheckboxRO(CheckEnum chk, string name)
        {
            Debug.Assert(chk != CheckEnum.None);
            RenderImage rimg = MakeGlyphRO(s_CheckToGlyph[chk]);
            if (!string.IsNullOrEmpty(name))
                rimg.Name = name;
            return rimg;
        }
    }
}
