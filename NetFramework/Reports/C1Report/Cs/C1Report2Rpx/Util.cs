using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.IO;
using System.ComponentModel;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection;
using System.Xml;

using C1R = C1.C1Report;
using AR = GrapeCity.ActiveReports;
using ARS = GrapeCity.ActiveReports.SectionReportModel;

namespace C1Report2Rpx
{
    public static class Util
    {
        private static Image s_ImgError;
        private static Image s_ImgWarning;
        private static Image s_ImgSuccess;
        private static Image s_ImgUp;
        private static Image s_ImgDown;

        private static readonly Dictionary<C1R.BorderStyleEnum, AR.BorderLineStyle> c_c1borderStyle2AR =
            new Dictionary<C1R.BorderStyleEnum, AR.BorderLineStyle>()
            {
                { C1R.BorderStyleEnum.Dash, AR.BorderLineStyle.Dash },
                { C1R.BorderStyleEnum.DashDot, AR.BorderLineStyle.DashDot },
                { C1R.BorderStyleEnum.DashDotDot, AR.BorderLineStyle.DashDotDot },
                { C1R.BorderStyleEnum.Dot, AR.BorderLineStyle.Dot},
                { C1R.BorderStyleEnum.Solid, AR.BorderLineStyle.Solid },
                { C1R.BorderStyleEnum.Transparent, AR.BorderLineStyle.None },
            };

        private static readonly Dictionary<C1R.FieldAlignEnum, ContentAlignment> c_field2contentAlign =
            new Dictionary<C1R.FieldAlignEnum, ContentAlignment>()
            {
                { C1R.FieldAlignEnum.General, ContentAlignment.TopLeft }, //qq
                { C1R.FieldAlignEnum.LeftTop, ContentAlignment.TopLeft },
                { C1R.FieldAlignEnum.CenterTop, ContentAlignment.TopCenter },
                { C1R.FieldAlignEnum.RightTop, ContentAlignment.TopRight },
                { C1R.FieldAlignEnum.LeftBottom, ContentAlignment.BottomLeft },
                { C1R.FieldAlignEnum.CenterBottom, ContentAlignment.BottomCenter },
                { C1R.FieldAlignEnum.RightBottom, ContentAlignment.BottomRight },
                { C1R.FieldAlignEnum.LeftMiddle, ContentAlignment.MiddleLeft },
                { C1R.FieldAlignEnum.CenterMiddle, ContentAlignment.MiddleCenter },
                { C1R.FieldAlignEnum.RightMiddle, ContentAlignment.MiddleRight },
                { C1R.FieldAlignEnum.JustTop, ContentAlignment.TopLeft }, //qq
                { C1R.FieldAlignEnum.JustBottom, ContentAlignment.BottomLeft }, //qq
                { C1R.FieldAlignEnum.JustMiddle, ContentAlignment.MiddleLeft }, //qq
            };

        #region Constructors
        static Util()
        {
            s_ImgError = GetImage("Error.png");
            s_ImgSuccess = GetImage("Success.png");
            s_ImgWarning = GetImage("Warning.png");
            s_ImgUp = GetImage("Up.png");
            s_ImgDown = GetImage("Down.png");
        }
        #endregion

        #region Public static
        public static float ArLength(
            double c1len)
        {
            return (float)(c1len / 1440d);
        }

        public static float TwipsToPixels(
            double twips)
        {
            return (float)(twips / (1440d / 96d));
        }

        public static void ConvertBorder(
            C1R.Field fld,
            AR.Border border)
        {
            border.Style = c_c1borderStyle2AR[fld.BorderStyle];
            border.Color = fld.BorderColor;
        }

        public static AR.PaddingEx ConvertPadding(
            C1R.Field fld)
        {
            return new AR.PaddingEx(
                (int)Math.Round(TwipsToPixels(fld.MarginLeft)),
                (int)Math.Round(TwipsToPixels(fld.MarginTop)),
                (int)Math.Round(TwipsToPixels(fld.MarginRight)),
                (int)Math.Round(TwipsToPixels(fld.MarginBottom)));
        }

        public static ContentAlignment ConvertAlignment(
            C1R.FieldAlignEnum fa,
            string source,
            Log log)
        {
            ContentAlignment result = c_field2contentAlign[fa];
            if (fa == C1R.FieldAlignEnum.General ||
                fa == C1R.FieldAlignEnum.JustBottom ||
                fa == C1R.FieldAlignEnum.JustMiddle ||
                fa == C1R.FieldAlignEnum.JustTop)
                log.Add(LogEntryLevel.Warning, source, string.Format(Strings.Warnings.UnsupportedFieldAlign, fa, result));
            return result;
        }

        public static ARPictureAlign ConvertPictureAlignment(
            C1R.PictureAlignEnum c1Align,
            C1R.PictureScaleEnum c1Scale,
            string source,
            Log log)
        {
            ARPictureAlign result = new ARPictureAlign();
            bool warning = false;
            //arAlign = ARS.PictureAlignment.TopLeft;
            //arSizeMode = ARS.SizeModes.Clip;
            // this logic is from C1Report sources:
            switch (c1Align)
            {
                case C1R.PictureAlignEnum.Stretch:
                    c1Align = C1R.PictureAlignEnum.LeftTop;
                    c1Scale = C1R.PictureScaleEnum.Stretch;
                    break;
                case C1R.PictureAlignEnum.Tile:
                    c1Align = C1R.PictureAlignEnum.LeftTop;
                    c1Scale = C1R.PictureScaleEnum.Tile;
                    break;
                case C1R.PictureAlignEnum.Zoom:
                    c1Align = C1R.PictureAlignEnum.LeftTop;
                    c1Scale = C1R.PictureScaleEnum.Scale;
                    break;
                case C1R.PictureAlignEnum.Clip:
                    c1Align = C1R.PictureAlignEnum.LeftTop;
                    c1Scale = C1R.PictureScaleEnum.Clip;
                    break;
            }

            switch (c1Align)
            {
                case C1R.PictureAlignEnum.LeftTop:
                    result.Alignment = ARS.PictureAlignment.TopLeft;
                    break;
                case C1R.PictureAlignEnum.RightTop:
                    result.Alignment = ARS.PictureAlignment.TopRight;
                    break;
                case C1R.PictureAlignEnum.LeftBottom:
                    result.Alignment = ARS.PictureAlignment.BottomLeft;
                    break;
                case C1R.PictureAlignEnum.RightBottom:
                    result.Alignment = ARS.PictureAlignment.BottomRight;
                    break;
                case C1R.PictureAlignEnum.CenterMiddle:
                    result.Alignment = ARS.PictureAlignment.Center;
                    break;
                case C1R.PictureAlignEnum.CenterTop:
                case C1R.PictureAlignEnum.LeftMiddle:
                case C1R.PictureAlignEnum.RightMiddle:
                case C1R.PictureAlignEnum.CenterBottom:
                    result.Alignment = ARS.PictureAlignment.Center;
                    warning = true;
                    break;
                default:
                    System.Diagnostics.Debug.Assert(false);
                    break;
            }
            switch (c1Scale)
            {
                case C1R.PictureScaleEnum.Clip:
                    result.SizeMode = ARS.SizeModes.Clip;
                    break;
                case C1R.PictureScaleEnum.Scale:
                    result.SizeMode = ARS.SizeModes.Zoom;
                    break;
                case C1R.PictureScaleEnum.Stretch:
                    result.SizeMode = ARS.SizeModes.Stretch;
                    break;
                case C1R.PictureScaleEnum.Tile:
                    result.SizeMode = ARS.SizeModes.Stretch;
                    warning = true;
                    break;
                case C1R.PictureScaleEnum.Hide:
                    result.SizeMode = ARS.SizeModes.Clip;
                    warning = true;
                    break;
                default:
                    System.Diagnostics.Debug.Assert(false);
                    break;
            }
            if (warning)
                log.Add(LogEntryLevel.Warning, source, string.Format(Strings.Warnings.UnsupportedPictureAlign, c1Align, c1Scale, result.Alignment, result.SizeMode));
            return result;
        }

        public static ARPicture ConvertPicture(
            C1R.Util.PictureHolder pictureHolder,
            C1R.PictureAlignEnum pictureAlign,
            C1R.PictureScaleEnum pictureScale,
            string source,
            Log log)
        {
            ARPicture result = new ARPicture();

            //
            if (pictureHolder != null)
            {
                if (pictureHolder.IsBound)
                    result.DataField = pictureHolder.FieldName;
                else
                {
                    if (pictureHolder.IsUrl)
                        log.Add(LogEntryLevel.Warning, source, string.Format(Strings.Warnings.ImageEmbedded, pictureHolder.Url));
                    result.Image = pictureHolder.Image;
                }
            }

            //
            result.Align = Util.ConvertPictureAlignment(pictureAlign, pictureScale, source, log);

            //
            return result;
        }

        public static string MakeFileName(
            string src)
        {
            // replace all non-alphanumeric chars with underscores,
            // also prepend digits at beginning of string:
            // return Regex.Replace(src, @"(^(?=[^a-zA-Z_]))|[\W]", "_");
            return Regex.Replace(src, @"[\W]", "_");
        }

        public static DialogResult MBox(
            IWin32Window owner,
            string text,
            MessageBoxButtons buttons,
            MessageBoxIcon icon)
        {
            return MessageBox.Show(owner, text, Strings.MessageBoxCaption, buttons, icon);
        }

        public static DialogResult MBox(
            IWin32Window owner,
            string text,
            MessageBoxButtons buttons,
            MessageBoxIcon icon,
            params object[] args)
        {
            return MessageBox.Show(owner, string.Format(text, args), Strings.MessageBoxCaption, buttons, icon);
        }

        public static void MWarning(
            IWin32Window owner,
            string text,
            params object[] args)
        {
            MBox(owner, text, MessageBoxButtons.OK, MessageBoxIcon.Warning, args);
        }

        public static void MInfo(
            IWin32Window owner,
            string text,
            params object[] args)
        {
            MBox(owner, text, MessageBoxButtons.OK, MessageBoxIcon.Information, args);
        }

        public static void MError(
            IWin32Window owner,
            string text,
            params object[] args)
        {
            MBox(owner, text, MessageBoxButtons.OK, MessageBoxIcon.Error, args);
        }
        
        public static Image GetImage(
            string resourceName)
        {
            Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(string.Format(@"C1Report2Rpx.Resources.{0}", resourceName));
            System.Diagnostics.Debug.Assert(stream != null);
            return Image.FromStream(stream);
        }

        public static void LoadReport(
            AR.Design.Designer designer,
            Stream stream)
        {
            stream.Seek(0, SeekOrigin.Begin);
            XmlTextReader xtr = new XmlTextReader(stream);
            designer.LoadReport(xtr, AR.Design.DesignerReportType.Section);
        }

        public static void SaveReport(
            AR.Design.Designer designer,
            MemoryStream stream)
        {
            stream.SetLength(0);
            XmlTextWriter xtw = new XmlTextWriter(stream, Encoding.UTF8);
            designer.SaveReport(xtw);
        }
        #endregion

        #region Public static properties
        public static Image ImgError
        {
            get { return s_ImgError; }
        }

        public static Image ImgWarning
        {
            get { return s_ImgWarning; }
        }

        public static Image ImgSuccess
        {
            get { return s_ImgSuccess; }
        }

        public static Image ImgUp
        {
            get { return s_ImgUp; }
        }

        public static Image ImgDown
        {
            get { return s_ImgDown; }
        }
        #endregion

        #region Nested types
        public struct ARPictureAlign
        {
            public ARS.PictureAlignment Alignment { get; set; }
            public ARS.SizeModes SizeMode { get; set; }
        }

        public class ARPicture
        {
            private Image _image;
            private string _dataField;
            private Util.ARPictureAlign _align;

            #region Public properties
            public Image Image
            {
                get { return _image; }
                set { _image = value; }
            }

            public string DataField
            {
                get { return _dataField; }
                set { _dataField = value; }
            }

            public Util.ARPictureAlign Align
            {
                get { return _align; }
                set { _align = value; }
            }
            #endregion
        }
        #endregion
    }
}
