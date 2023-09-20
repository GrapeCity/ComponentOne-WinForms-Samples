//----------------------------------------------------------------------------
// Win32.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) MESCIUS, Inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System.Runtime.InteropServices;
using System;
using System.Drawing;
using System.Globalization;
using System.Text;

namespace C1.Util.Win
{
    internal partial class Win32
    {
        public static readonly IntPtr INVALID_HANDLE_VALUE = (IntPtr)(-1);
        public const int HWND_TOPMOST = -1;

        #region ** obsolete
        //<<IP>> borrow below code from FlexGrid for working on x64 platforms
        [Obsolete("Use method GET_X_LPARAM, LOWORDU if want to unsigned value")]
        public static int LOWORD(IntPtr ip)
        {
            return (int)((short)(ip.ToInt64() & 0xffff));
        }
        public static int LOWORD(int n)
        {
            return n & 0xffff;
        }
        [Obsolete("Use method GET_Y_LPARAM, HIWORDU if want to unsigned value")]
        public static int HIWORD(IntPtr ip)
        {
            return (int)((short)((ip.ToInt64() >> 16) & 0xffff));
        }
        public static int HIWORD(int n)
        {
            return (n >> 16) & 0xffff;
        }
        #endregion

        #region ** consistent with MSDN
        /// <summary>
        /// Retrieves the low-order word from the specified value. This function handles the message parameters of window. See in MSDN which function used to process the message.
        /// </summary>
        /// <param name="value">The value to be converted.</param>
        /// <returns>The return value is the low-order word of the specified value.</returns>
        /// <remarks>
        /// Use:
        /// WM_COMMAND, WM_SYSCOMMAND
        /// WM_SETCURSOR
        /// WM_ACTIVATE
        /// WM_MENUCHAR
        /// WM_HSCROLL WM_VSCROLL - SB_THUMBPOSITION or SB_THUMBTRACK
        /// </remarks>
        public static int LOWORDU(IntPtr value)
        {
            return (int)(value.ToInt64() & 0xffff);
        }
        /// <summary>
        /// Retrieves the high-order word from the specified value. This function handles the message parameters of window. See in MSDN which function used to process the message.
        /// </summary>
        /// <param name="value">The value to be converted.</param>
        /// <returns>The return value is the high-order word of the specified value.</returns>
        /// <remarks>
        /// WM_HSCROLL WM_VSCROLL -  current position of the scroll box
        /// </remarks>
        public static int HIWORDU(IntPtr value)
        {
            return (int)((value.ToInt64() >> 16) & 0xffff);
        }
        /// <summary>
        /// Retrieves the signed x-coordinate from the given value. 
        /// This function handles the message parameters of window and is a replacement for LOWORD because LOWORD must return the unsigned value. 
        /// See in MSDN which function used to process the message.
        /// </summary>
        /// <param name="lParam">The value to be converted.</param>
        /// <returns>The return value is the low-order int of the specified value.</returns>
        /// <remarks>
        /// Use:
        /// WM_CONTEXTMENU,
        /// WM_MOUSEDOWN, WM_MOUSEUP, WM_MOUSEWHEEL, WM_MOUSEMOVE
        /// </remarks>
        public static int GET_X_LPARAM(IntPtr lParam)
        {
            return (int)((short)(lParam.ToInt64() & 0xffff));
        }
        /// <summary>
        /// Retrieves the signed y-coordinate from the given value. 
        /// This function handles the message parameters of window and is a replacement for HIWORD because HIWORD must return the unsigned value. 
        /// See in MSDN which function used to process the message.
        /// </summary>
        /// <param name="lParam">The value to be converted.</param>
        /// <returns>The return value is the high-order int of the specified value.</returns>
        /// <remarks>
        /// Use:
        /// WM_CONTEXTMENU,
        /// WM_MOUSEDOWN, WM_MOUSEUP, WM_MOUSEWHEEL, WM_MOUSEMOVE
        /// </remarks>
        public static int GET_Y_LPARAM(IntPtr lParam)
        {
            return (int)((short)((lParam.ToInt64() >> 16) & 0xffff));
        }

        /// <summary>
        /// Retrieves the wheel-delta value from the specified WPARAM value.
        /// </summary>
        /// <param name="wParam">The value to be converted.</param>
        /// <returns>
        /// The return value is the high-order word representing the wheel-delta value. 
        /// It indicates the distance that the wheel is rotated, expressed in multiples or divisions of WHEEL_DELTA, which is 120. A positive value indicates that the wheel was rotated forward, away from the user; 
        /// a negative value indicates that the wheel was rotated backward, toward the user.
        /// </returns>
        /// <remarks>
        /// Use:
        /// WM_MOUSEWHEEL - zDelta 
        /// </remarks>
        public static int GET_WHEEL_DELTA_WPARAM(IntPtr wParam)
        {
            return GET_Y_LPARAM(wParam);
        }

        /// <summary>
        /// Retrieves the state of certain virtual keys from the specified WPARAM value.
        /// </summary>
        /// <param name="wParam">The value to be converted.</param>
        /// <returns>
        /// The return value is the low-order word representing the virtual key state.
        /// </returns>
        /// <remarks>
        /// Use:
        /// WM_MOUSEWHEEL - fwKeys  
        /// </remarks>
        public static int GET_KEYSTATE_WPARAM(IntPtr wParam)
        {
            return LOWORDU(wParam);
        }
        #endregion

        internal static IntPtr IntPtrFromPoint(Point pt)
        {
            return (IntPtr)(pt.X | (pt.Y << 16));
        }
        
        // <<IP>> probably needs to be refactored to avoid OverFlowException
        internal static Point PointFromIntPtr(IntPtr intPtr)
        {
            return new Point((int)intPtr & 0xff, (int)intPtr >> 16);
        }
 
        #region ComponentOne constants
        public enum C1PdfAcrofieldType
        {
            /// <summary>A field type invalid or not found.</summary>
            None = 0,
            PushButton = 1,
            CheckBox = 2,
            RadioButton = 3,
            Text = 4,
            List = 5,
            Combo = 6,
        }

        [Flags]
        public enum C1PdfAcrofieldFlags
        {
            None = 0x0,
            ReadOnly = 0x00000001,
            Required = 0x00000002,
            NoExport = 0x00000004,
            Multiline = 0x00001000,
            Password = 0x00002000,
            NoToggleToOff = 0x00004000,
            Radio = 0x00008000,
            PushButton = 0x00010000,
            Combo = 0x00020000,
            Edit = 0x00040000,
            FileSelect = 0x00100000,
            Multiselect = 0x00200000,
            DoNotSpellCheck = 0x00400000,
            DoNotScroll = 0x00800000,
            Comb = 0x01000000,
            RadioSinUnison = 0x02000000,
        }

        public class C1WM
        {
            public const uint
                C1WM_COMPONENTCHANGED = WM.WM_USER + 0x0100;
        }
        #endregion

        #region ComponentOne structures
        [StructLayout(LayoutKind.Sequential)]
        public struct C1_ARCOFIELD_INFO
        {
            public uint dwIdent; // signature: GDICOMMENT_C1_ARCOFIELD_INFO
            public RECTL rc; // field area in logical coords
            public int FieldType;
            public int OptionFlags; // field type, required, readonly, password, multiline and others
            public int FormsStyle; // value of C1PrintDocument.FormsStyle property converted to int
            public int BackColor; // background color
            public int ForeColor; // foreground (text) color
            public int nLenFontName;
            public IntPtr sFontName;
            public float FontSize;
            public int FontStyle;
            public int ValueAlingment; // value alignment (ContentAlignment as integer)
            public int MaxLength; // max length in symbols for text
            public uint nLenValue; // length in chars of the sValue field
            public IntPtr sValue;
            public uint nLenToolTip; // length in chars of the sToolTip field
            public IntPtr sToolTip;
            public uint nLenOtherInfo;
            public IntPtr sOtherInfo;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct EMR_C1_ARCOFIELD_INFO
        {
            public uint cbData;
            public C1_ARCOFIELD_INFO data;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct C1_HYPERLINK
        {
            public uint dwIdent;
            public RECTL rc; // if not (0,0,0,0), tag area in logical coords (ow span until next tag)
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct EMR_C1_HYPERLINK
        {
            public uint cbData;
            public C1_HYPERLINK data;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct VSMETATAG
        {
            public uint dwIdent; // signature: GDICOMMENT_VSMETATAGIDENTIFIER
            public RECTL rc; // if not (0,0,0,0), tag area in logical coords (ow span until next tag)
            public uint nLen; // number of characters in tag string
            public IntPtr sTag;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct EMR_C1_VSMETATAG
        {
            public uint cbData;
            public VSMETATAG data;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct C1_HYPERLINK_BEGIN
        {
            public uint dwIdent; // signature: GDICOMMENT_C1_BEGIN_HYPERLINK
            public RECTL rc; // if not (0,0,0,0), tag area in logical coords (ow span until next tag)
            public uint nLen; // number of characters in tag string
            public IntPtr sTag;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct EMR_C1_HYPERLINK_BEGIN
        {
            public uint cbData;
            public C1_HYPERLINK_BEGIN data;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct C1_HYPERLINK_END
        {
            public uint dwIdent; // signature: GDICOMMENT_C1_END_HYPERLINK
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct EMR_C1_HYPERLINK_END
        {
            public uint cbData;
            public C1_HYPERLINK_END data;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct C1_METAFILE_INFO
        {
            public uint dwIdent; // signature: GDICOMMENT_C1_METAFILE_INFO
            public uint nLen; // length in chars of the sTag field
            public IntPtr sTag;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct EMR_C1_METAFILE_INFO
        {
            public uint cbData;
            public C1_METAFILE_INFO data;
        }
        #endregion // ComponentOne structures

        #region Common structures
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        public struct NMHDR
        {
            public IntPtr hwndFrom;
            public IntPtr idFrom;
            public int Code;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        public struct SELCHANGE
        {
            public NMHDR nmhdr;
            public CHARRANGE chrg;
            public int seltyp;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        public struct OSVERSIONINFOEX
        {
            public uint dwOSVersionInfoSize;
            public uint dwMajorVersion;
            public uint dwMinorVersion;
            public uint dwBuildNumber;
            public uint dwPlatformId;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst=128)]
            public string szCSDVersion;
            public UInt16 wServicePackMajor;
            public UInt16 wServicePackMinor;
            public UInt16 wSuiteMask;
            public char wProductType;
            public char wReserved;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        public struct TRACKMOUSEEVENT
        {
            public int cbSize;
            public uint dwFlags;
            public IntPtr hwndTrack;
            public int dwHoverTime;        
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        public struct GLYPHMETRICS
        {
            public uint gmBlackBoxX;
            public uint gmBlackBoxY;
            POINT gmptGlyphOrigin;
            public short gmCellIncX;
            public short gmCellIncY;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto), BestFitMapping(false)]
        public class WIN32_FIND_DATA
        {
            public int dwFileAttributes;
            public int ftCreationTime_dwLowDateTime;
            public int ftCreationTime_dwHighDateTime;
            public int ftLastAccessTime_dwLowDateTime;
            public int ftLastAccessTime_dwHighDateTime;
            public int ftLastWriteTime_dwLowDateTime;
            public int ftLastWriteTime_dwHighDateTime;
            public int nFileSizeHigh;
            public int nFileSizeLow;
            public int dwReserved0;
            public int dwReserved1;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
            public string cFileName;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 14)]
            public string cAlternateFileName;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct RGNDATAHEADER
        {
            public int dwSize;
            public int iType;
            public int nCount;
            public int nRgnSize;
            public RECT rcBounds;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct RGNDATA
        {
            public RGNDATAHEADER rdh;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct POINTL
        {
            public int x;
            public int y;

            #region Public
            public void CopyFrom(Point source)
            {
                x = source.X;
                y = source.Y;
            }

            public void AssignTo(ref Point destination)
            {
                destination.X = x;
                destination.Y = y;
            }
            #endregion
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct SIZEL
        {
            public int cx;
            public int cy;

            #region Public
            public void CopyFrom(Size source)
            {
                cx = source.Width;
                cy = source.Height;
            }

            public void AssignTo(ref Size destination)
            {
                destination.Width = cx;
                destination.Height = cy;
            }
            #endregion
        }


        [StructLayout(LayoutKind.Sequential)]
        public struct SIZE
        {
            public int cx;
            public int cy;

            #region Public
            public void CopyFrom(Point source)
            {
                cx = source.X;
                cy = source.Y;
            }
            #endregion
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct POINT
        {
            public int x;
            public int y;

            #region Public
            public void CopyFrom(Point source)
            {
                x = source.X;
                y = source.Y;
            }

            public void CopyFrom(POINT source)
            {
                x = source.x;
                y = source.y;
            }

            public void AssignTo(ref Point destination)
            {
                destination.X = x;
                destination.Y = y;
            }
            #endregion
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct RECTL
        {
            public int left;
            public int top;
            public int right;
            public int bottom;

            #region Public
            public void CopyFrom(Rectangle source)
            {
                left = source.Left;
                top = source.Top;
                right = source.Right;
                bottom = source.Bottom;
            }

            public void AssignTo(ref Rectangle destination)
            {
                destination.X = left;
                destination.Y = top;
                destination.Width = right - left;
                destination.Height = bottom - top;
            }

            public Rectangle ToRectangle()
            {
                Rectangle result = new Rectangle();
                AssignTo(ref result);
                return result;
            }
            #endregion
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int left;
            public int top;
            public int right;
            public int bottom;

            #region Constructors

            public RECT(Rectangle source)
            {
                left = source.Left;
                top = source.Top;
                right = source.Right;
                bottom = source.Bottom;
            }

            public RECT(int x, int y, int width, int height)
            {
                left = x;
                top = y;
                right = left + width;
                bottom = top + height;
            }

            #endregion

            #region Public properties
            public int Width
            {
                get { return right - left; }
            }

            public int Height
            {
                get { return bottom - top; }
            }
            #endregion

            #region Public

            public void CopyFrom(Rectangle source)
            {
                left = source.Left;
                top = source.Top;
                right = source.Right;
                bottom = source.Bottom;
            }

            public void CopyFrom(RECT source)
            {
                left = source.left;
                top = source.top;
                right = source.right;
                bottom = source.bottom;
            }

            public void AssignTo(ref Rectangle r)
            {
                r.X = left;
                r.Y = top;
                r.Width = right - left;
                r.Height = bottom - top;
            }

            public void Inflate(int dx, int dy)
            {
                left -= dx;
                top -= dy;
                right += dx;
                bottom += dy;
            }

            public void Offset(int dx, int dy)
            {
                left += dx;
                top += dy;
                right += dx;
                bottom += dy;
            }

            public Rectangle ToRectangle()
            {
                return new Rectangle(left, top, Width, Height);
            }

            #endregion

            #region Public static
            public static RECT FromRectangle(Rectangle rect)
            {
                RECT r = new RECT();
                r.CopyFrom(rect);
                return r;
            }
            #endregion
        }

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct BLENDFUNCTION
        {
            public byte BlendOp;
            public byte BlendFlags;
            public byte SourceConstantAlpha;
            public byte AlphaFormat;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct XFORM
        {
            public float eM11;
            public float eM12;
            public float eM21;
            public float eM22;
            public float eDx;
            public float eDy;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct DRAWITEMSTRUCT
        {
            public uint ctlType;
            public uint ctlID;
            public uint itemID;
            public uint itemAction;
            public uint itemState;
            public IntPtr hwndItem;
            public IntPtr hDC;
            public RECT rcItem;
            public IntPtr itemData;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct NONCLIENTMETRICS
        {
            public UInt32 cbSize;
            public int iBorderWidth;
            public int iScrollWidth;
            public int iScrollHeight;
            public int iCaptionWidth;
            public int iCaptionHeight;
            public LOGFONT lfCaptionFont;
            public int iSmCaptionWidth;
            public int iSmCaptionHeight;
            public LOGFONT lfSmCaptionFont;
            public int iMenuWidth;
            public int iMenuHeight;
            public LOGFONT lfMenuFont;
            public LOGFONT lfStatusFont;
            public LOGFONT lfMessageFont;
        }
        #endregion // Common structures

        #region Font structures
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        public struct PANOSE
        {
            public byte bFamilyType;
            public byte bSerifStyle;
            public byte bWeight;
            public byte bProportion;
            public byte bContrast;
            public byte bStrokeVariation;
            public byte bArmStyle;
            public byte bLetterform;
            public byte bMidline;
            public byte bXHeight;

            public void CopyFrom(PANOSE source)
            {
                bFamilyType = source.bFamilyType;
                bSerifStyle = source.bSerifStyle;
                bWeight = source.bWeight;
                bProportion = source.bProportion;
                bContrast = source.bContrast;
                bStrokeVariation = source.bStrokeVariation;
                bArmStyle = source.bArmStyle;
                bLetterform = source.bLetterform;
                bMidline = source.bMidline;
                bXHeight = source.bXHeight;
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct LOGBRUSH
        {
            public uint lbStyle;
            public int lbColor;
            public uint lbHatch;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        public struct EXTLOGFONT
        {
            public LOGFONT_UNMANAGED elfLogFont;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
            public string elfFullName;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string elfStyle;
            public uint elfVersion;
            public uint elfStyleSize;
            public uint elfMatch;
            public uint elfReserved;
            public byte elfVendorId0;
            public byte elfVendorId1;
            public byte elfVendorId2;
            public byte elfVendorId3;
            public uint elfCulture;
            public PANOSE elfPanose;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct EXTLOGFONT_UNMANAGED
        {
            public LOGFONT_UNMANAGED elfLogFont;
            public char elfFullName1;
            public char elfFullName2;
            public char elfFullName3;
            public char elfFullName4;
            public char elfFullName5;
            public char elfFullName6;
            public char elfFullName7;
            public char elfFullName8;
            public char elfFullName9;
            public char elfFullName10;
            public char elfFullName11;
            public char elfFullName12;
            public char elfFullName13;
            public char elfFullName14;
            public char elfFullName15;
            public char elfFullName16;
            public char elfFullName17;
            public char elfFullName18;
            public char elfFullName19;
            public char elfFullName20;
            public char elfFullName21;
            public char elfFullName22;
            public char elfFullName23;
            public char elfFullName24;
            public char elfFullName25;
            public char elfFullName26;
            public char elfFullName27;
            public char elfFullName28;
            public char elfFullName29;
            public char elfFullName30;
            public char elfFullName31;
            public char elfFullName32;
            public char elfFullName33;
            public char elfFullName34;
            public char elfFullName35;
            public char elfFullName36;
            public char elfFullName37;
            public char elfFullName38;
            public char elfFullName39;
            public char elfFullName40;
            public char elfFullName41;
            public char elfFullName42;
            public char elfFullName43;
            public char elfFullName44;
            public char elfFullName45;
            public char elfFullName46;
            public char elfFullName47;
            public char elfFullName48;
            public char elfFullName49;
            public char elfFullName50;
            public char elfFullName51;
            public char elfFullName52;
            public char elfFullName53;
            public char elfFullName54;
            public char elfFullName55;
            public char elfFullName56;
            public char elfFullName57;
            public char elfFullName58;
            public char elfFullName59;
            public char elfFullName60;
            public char elfFullName61;
            public char elfFullName62;
            public char elfFullName63;
            public char elfFullName64;

            public char elfStyle1;
            public char elfStyle2;
            public char elfStyle3;
            public char elfStyle4;
            public char elfStyle5;
            public char elfStyle6;
            public char elfStyle7;
            public char elfStyle8;
            public char elfStyle9;
            public char elfStyle10;
            public char elfStyle11;
            public char elfStyle12;
            public char elfStyle13;
            public char elfStyle14;
            public char elfStyle15;
            public char elfStyle16;
            public char elfStyle17;
            public char elfStyle18;
            public char elfStyle19;
            public char elfStyle20;
            public char elfStyle21;
            public char elfStyle22;
            public char elfStyle23;
            public char elfStyle24;
            public char elfStyle25;
            public char elfStyle26;
            public char elfStyle27;
            public char elfStyle28;
            public char elfStyle29;
            public char elfStyle30;
            public char elfStyle31;
            public char elfStyle32;

            public uint elfVersion;
            public uint elfStyleSize;
            public uint elfMatch;
            public uint elfReserved;
            public byte elfVendorId0;
            public byte elfVendorId1;
            public byte elfVendorId2;
            public byte elfVendorId3;
            public uint elfCulture;
            public PANOSE elfPanose;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        public struct TEXTMETRIC
        {
            public int tmHeight;
            public int tmAscent;
            public int tmDescent;
            public int tmInternalLeading;
            public int tmExternalLeading;
            public int tmAveCharWidth;
            public int tmMaxCharWidth;
            public int tmWeight;
            public int tmOverhang;
            public int tmDigitizedAspectX;
            public int tmDigitizedAspectY;
            public char tmFirstChar;
            public char tmLastChar;
            public char tmDefaultChar;
            public char tmBreakChar;
            public byte tmItalic;
            public byte tmUnderlined;
            public byte tmStruckOut;
            public byte tmPitchAndFamily;
            public byte tmCharSet;

            public void CopyFrom(TEXTMETRIC source)
            {
                tmHeight = source.tmHeight;
                tmAscent = source.tmAscent;
                tmDescent = source.tmDescent;
                tmInternalLeading = source.tmInternalLeading;
                tmExternalLeading = source.tmExternalLeading;
                tmAveCharWidth = source.tmAveCharWidth;
                tmMaxCharWidth = source.tmMaxCharWidth;
                tmWeight = source.tmWeight;
                tmOverhang = source.tmOverhang;
                tmDigitizedAspectX = source.tmDigitizedAspectX;
                tmDigitizedAspectY = source.tmDigitizedAspectY;
                tmFirstChar = source.tmFirstChar;
                tmLastChar = source.tmLastChar;
                tmDefaultChar = source.tmDefaultChar;
                tmBreakChar = source.tmBreakChar;
                tmItalic = source.tmItalic;
                tmUnderlined = source.tmUnderlined;
                tmStruckOut = source.tmStruckOut;
                tmPitchAndFamily = source.tmPitchAndFamily;
                tmCharSet = source.tmCharSet;
            }
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        public struct OUTLINETEXTMETRIC
        {
            public uint otmSize;
            public TEXTMETRIC otmTextMetrics;
            public byte otmFiller;
            public PANOSE otmPanoseNumber;
            public uint otmfsSelection;
            public uint otmfsType;
            public int otmsCharSlopeRise;
            public int otmsCharSlopeRun;
            public int otmItalicAngle;
            public uint otmEMSquare;
            public int otmAscent;
            public int otmDescent;
            public uint otmLineGap;
            public uint otmsCapEmHeight;
            public uint otmsXHeight;
            public RECT otmrcFontBox;
            public int otmMacAscent;
            public int otmMacDescent;
            public uint otmMacLineGap;
            public uint otmusMinimumPPEM;
            public POINT otmptSubscriptSize;
            public POINT otmptSubscriptOffset;
            public POINT otmptSuperscriptSize;
            public POINT otmptSuperscriptOffset;
            public uint otmsStrikeoutSize;
            public int otmsStrikeoutPosition;
            public int otmsUnderscoreSize;
            public int otmsUnderscorePosition;
            public IntPtr otmpFamilyName;
            public IntPtr otmpFaceName;
            public IntPtr otmpStyleName;
            public IntPtr otmpFullName;

            public void CopyFrom(OUTLINETEXTMETRIC source)
            {
                otmSize = source.otmSize;
                otmTextMetrics.CopyFrom(source.otmTextMetrics);
                otmFiller = source.otmFiller;
                otmPanoseNumber.CopyFrom(source.otmPanoseNumber);
                otmfsSelection = source.otmfsSelection;
                otmfsType = source.otmfsType;
                otmsCharSlopeRise = source.otmsCharSlopeRise;
                otmsCharSlopeRun = source.otmsCharSlopeRun;
                otmItalicAngle = source.otmItalicAngle;
                otmEMSquare = source.otmEMSquare;
                otmAscent = source.otmAscent;
                otmDescent = source.otmDescent;
                otmLineGap = source.otmLineGap;
                otmsCapEmHeight = source.otmsCapEmHeight;
                otmsXHeight = source.otmsXHeight;
                otmrcFontBox.CopyFrom(source.otmrcFontBox);
                otmMacAscent = source.otmMacAscent;
                otmMacDescent = source.otmMacDescent;
                otmMacLineGap = source.otmMacLineGap;
                otmusMinimumPPEM = source.otmusMinimumPPEM;
                otmptSubscriptSize.CopyFrom(source.otmptSubscriptSize);
                otmptSubscriptOffset.CopyFrom(source.otmptSubscriptOffset);
                otmptSuperscriptSize.CopyFrom(source.otmptSuperscriptSize);
                otmptSuperscriptOffset.CopyFrom(source.otmptSuperscriptOffset);
                otmsStrikeoutSize = source.otmsStrikeoutSize;
                otmsStrikeoutPosition = source.otmsStrikeoutPosition;
                otmsUnderscoreSize = source.otmsUnderscoreSize;
                otmsUnderscorePosition = source.otmsUnderscorePosition;
                otmpFamilyName = source.otmpFamilyName;
                otmpFaceName = source.otmpFaceName;
                otmpStyleName = source.otmpStyleName;
                otmpFullName = source.otmpFullName;
            }
        }
        #endregion // Font structures

        #region Metafile structures
        [StructLayout(LayoutKind.Sequential)]
        public struct EMR
        {
            public uint iType;
            public uint nSize;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct EMRGDICOMMENT
        {
            public uint cbData;
            public IntPtr data; //pData; 
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct EMRGDICOMMENT_EMR
        {
            public EMR emr;
            public EMRGDICOMMENT emrGdiComment;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct EMRSELECTOBJECT
        {
            public uint ihObject;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct EMRSELECTOBJECT_EMR
        {
            public EMR emr;
            public EMRSELECTOBJECT emrSelectObject;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct EMRDELETEOBJECT
        {
            public uint ihObject;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct EMRDELETEOBJECT_EMR
        {
            public EMR emr;
            public EMRDELETEOBJECT emrDeleteObject;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct EMRSETBKMODE
        {
            public uint iMode;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct EMRSETBKMODE_EMR
        {
            public EMR emr;
            public uint iMode;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct EMRTEXT
        {
            public POINTL ptlReference;
            public uint nChars;
            public uint offString;
            public uint fOptions;
            public RECTL rcl;
            public uint offDx;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct EMREXTTEXTOUTW
        {
            public RECTL rclBounds;
            public uint iGraphicsMode;
            public float exScale;
            public float eyScale;
            public EMRTEXT emrtext;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct EMREXTTEXTOUTW_EMR
        {
            public EMR emr;
            public EMREXTTEXTOUTW emrExtTextOutW;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct EMRSETTEXTALIGN
        {
            public uint iMode;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct EMRSETTEXTALIGN_EMR
        {
            public EMR emr;
            public EMRSETTEXTALIGN emrSetTextAlign;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct EMRBITBLT
        {
            public RECTL rclBounds;
            public int xDest;
            public int yDest;
            public int cxDest;
            public int cyDest;
            public uint dwRop;
            public int xSrc;
            public int ySrc;
            public XFORM xformSrc;
            public uint crBkColorSrc;
            public uint iUsageSrc;
            public uint offBmiSrc;
            public uint cbBmiSrc;
            public uint offBitsSrc;
            public uint cbBitsSrc;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct EMRBITBLT_EMR
        {
            public EMR emr;
            public EMRBITBLT emrBitBlt;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct EMRSETTEXTCOLOR
        {
            public uint crColor;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct EMRSETTEXTCOLOR_EMR
        {
            public EMR emr;
            public EMRSETTEXTCOLOR emrSetTextColor;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct EMREXTCREATEFONTINDIRECT
        {
            public uint ihFont;
            public EXTLOGFONT elfw;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        public struct EMREXTCREATEFONTINDIRECT_UNMANAGED
        {
            public uint ihFont;
            public EXTLOGFONT_UNMANAGED elfw;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        public struct EMREXTCREATEFONTINDIRECT_EMR
        {
            public EMR emr;
            public EMREXTCREATEFONTINDIRECT emrExtCreateFontIndirect;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        public struct EMREXTCREATEFONTINDIRECT_UNMANAGED_EMR
        {
            public EMR emr;
            public EMREXTCREATEFONTINDIRECT_UNMANAGED emrExtCreateFontIndirect;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct EMRSETBKCOLOR
        {
            public uint crColor;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct EMRSETBKCOLOR_EMR
        {
            public EMR emr;
            public EMRSETBKCOLOR emrSetTextColor;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct EMRARC
        {
            public RECTL rclBox;
            public POINTL ptlStart;
            public POINTL ptlEnd;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct EMRARC_EMR
        {
            public EMR emr;
            public EMRARC emrArc;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct EMRELLIPSE
        {
            public RECTL rclBox;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct EMRELLIPSE_EMR
        {
            public EMR emr;
            public EMRELLIPSE emrEllipse;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct EMRFILLRGN
        {
            public RECTL rclBounds;
            public uint cbRgnData;
            public uint ihBrush;
            public IntPtr RgnData;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct EMRFILLRGN_EMR
        {
            public EMR emr;
            public EMRFILLRGN emrFillRgn;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct EMRFRAMERGN
        {
            public RECTL rclBounds;
            public uint cbRgnData;
            public uint ihBrush;
            public SIZEL szlStroke;
            public IntPtr RgnData;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct EMRFRAMERGN_EMR
        {
            public EMR emr;
            public EMRFRAMERGN emrFrameRgn;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct EMRPLGBLT
        {
            public RECTL rclBounds;
            public POINTL aptlDest1;
            public POINTL aptlDest2;
            public POINTL aptlDest3;
            public int xSrc;
            public int ySrc;
            public int cxSrc;
            public int cySrc;
            public XFORM xformSrc;
            public int crBkColorSrc;
            public uint iUsageSrc;
            public uint offBmiSrc;
            public uint cbBmiSrc;
            public uint offBitsSrc;
            public uint cbBitsSrc;
            public int xMask;
            public int yMask;
            public uint iUsageMask;
            public uint offBmiMask;
            public uint cbBmiMask;
            public uint offBitsMask;
            public uint cbBitsMask;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct EMRPLGBLT_EMR
        {
            public EMR emr;
            public EMRPLGBLT emrPlgBlt;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct EMRPOLYLINE
        {
            public RECTL rclBounds;
            public uint cptl;
            public IntPtr aptl;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct EMRPOLYLINE_EMR
        {
            public EMR emr;
            public EMRPOLYLINE emrPolyLine;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct EMRPOLYDRAW
        {
            public RECTL rclBounds;
            public uint cptl;
            public IntPtr aptl;
            public IntPtr abTypes;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct EMRPOLYDRAW_EMR
        {
            public EMR emr;
            public EMRPOLYDRAW emrPolyDraw;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct EMRPOLYDRAW16
        {
            public RECTL rclBounds;
            public uint cpts;
            public IntPtr apts;
            public IntPtr abTypes;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct EMRPOLYDRAW16_EMR
        {
            public EMR emr;
            public EMRPOLYDRAW16 emrPolyDraw16;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct EMRPOLYPOLYLINE
        {
            public RECTL rclBounds;
            public uint nPolys;
            public uint cptl;
            public IntPtr aPolyCounts;
            public IntPtr aptl;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct EMRPOLYPOLYLINE_EMR
        {
            public EMR emr;
            public EMRPOLYPOLYLINE emrPolyPolyLine;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct EMRPOLYPOLYLINE16
        {
            public RECTL rclBounds;
            public uint nPolys;
            public uint cpts;
            public IntPtr aPolyCounts;
            public IntPtr apts;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct EMRPOLYPOLYLINE16_EMR
        {
            public EMR emr;
            public EMRPOLYPOLYLINE16 emrPolyPolyLine16;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct EMRPOLYTEXTOUT
        {
            public RECTL rclBounds;
            public uint iGraphicsMode;
            public float exScale;
            public float eyScale;
            public int cStrings;
            public IntPtr aemrtext;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct EMRPOLYTEXTOUT_EMR
        {
            public EMR emr;
            public EMRPOLYTEXTOUT emrPolyTextOut;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct EMRROUNDRECT
        {
            public RECTL rclBox;
            public SIZEL szlCorner;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct EMRROUNDRECT_EMR
        {
            public EMR emr;
            public EMRROUNDRECT emrRoundRect;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct EMRSTRETCHBLT
        {
            public RECTL rclBounds;
            public int xDest;
            public int yDest;
            public int cxDest;
            public int cyDest;
            public uint dwRop;
            public int xSrc;
            public int ySrc;
            public XFORM xformSrc;
            public int crBkColorSrc;
            public uint iUsageSrc;
            public uint offBmiSrc;
            public uint cbBmiSrc;
            public uint offBitsSrc;
            public uint cbBitsSrc;
            public int cxSrc;
            public int cySrc;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct EMRSTRETCHBLT_EMR
        {
            public EMR emr;
            public EMRSTRETCHBLT emrStretchBlt;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct EMRSTRETCHDIBITS
        {
            public RECTL rclBounds;
            public int xDest;
            public int yDest;
            public int xSrc;
            public int ySrc;
            public int cxSrc;
            public int cySrc;
            public uint offBmiSrc;
            public uint cbBmiSrc;
            public uint offBitsSrc;
            public uint cbBitsSrc;
            public uint iUsageSrc;
            public uint dwRop;
            public int cxDest;
            public int cyDest;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct EMRSTRETCHDIBITS_EMR
        {
            public EMR emr;
            public EMRSTRETCHDIBITS emrStretchDiBits;
        }
        #endregion // Metafile structures

        #region GDI+ Metafile structures
        [StructLayout(LayoutKind.Sequential)]
        public struct EmfDrawString
        {
            public byte Res0;
            public byte Res1;
            public byte Res2;
            public byte Res3;

            public int StringFormat;
            public int TextLength;
            public float X;
            public float Y;
            public float Width;
            public float Height;
            public IntPtr Text;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct EmfFont
        {
            public int Prefix;
            public float Size;
            public uint Unit;
            public uint Style;
            public int Res;
            public int NameSize;
            public IntPtr Name;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct EmfStringFormat
        {
            public int Prefix;
            public uint FormatFlags;
            public uint Res;
            public uint Alignment;
            public uint LineAlignment;
            public byte Res0;
            public byte Res1;
            public byte Res2;
            public byte Res3;
            public byte Res4;
            public byte Res5;
            public byte Res6;
            public byte Res7;
            public byte Res8;
            public byte Res9;
            public byte Res10;
            public byte Res11;
            public uint HotKeyPrefix;
            public byte Parent0;
            public byte Parent1;
            public byte Parent2;
            public byte Parent3;
            public byte Parent4;
            public byte Parent5;
            public byte Parent6;
            public byte Parent7;
            public byte Parent8;
            public byte Parent9;
            public byte Parent10;
            public byte Parent11;
            public uint Trimming;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct EmfSetPageTransform
        {
            public uint Prefix;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct EmfSetWorldTransform
        {
            public float m11;
            public float m12;
            public float m21;
            public float m22;
            public float dx;
            public float dy;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct EmfMultiplyWorldTransform
        {
            public float m11;
            public float m12;
            public float m21;
            public float m22;
            public float dx;
            public float dy;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct EmfRotateTransform
        {
            public float angle;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct EmfDrawImage32
        {
            public int Res0;
            public int Res1;
            public float srcRectX;
            public float srcRectY;
            public float srcRectWidth;
            public float srcRectHeight;
            public short destRectX;
            public short destRectY;
            public short destRectWidth;
            public short destRectHeight;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct EmfDrawImage40
        {
            public int Res0;
            public int Res1;
            public float srcRectX;
            public float srcRectY;
            public float srcRectWidth;
            public float srcRectHeight;
            public float destRectX;
            public float destRectY;
            public float destRectWidth;
            public float destRectHeight;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct EmfDrawImagePoints40
        {
            public int Res0;
            public int Res1;
            public float srcRectX;
            public float srcRectY;
            public float srcRectWidth;
            public float srcRectHeight;
            public int pointCount;
            public short points;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct EmfDrawImagePoints52
        {
            public int Res0;
            public int Res1;
            public float srcRectX;
            public float srcRectY;
            public float srcRectWidth;
            public float srcRectHeight;
            public int pointCount;
            public float points;
        }
        #endregion // GDI+ Metafile structures

        #region RTF structures
        [StructLayout(LayoutKind.Sequential)]
        public struct FORMATRANGE
        {
            public IntPtr hdc;
            public IntPtr hdcTarget;
            public RECT rc;
            public RECT rcPage;
            public CHARRANGE chrg;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct CHARRANGE
        {
            public int cpMin;
            public int cpMax;
        }

        // note: pack=4 needed for x64 compat.
        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public class EDITSTREAM
        {
            public IntPtr dwCookie = IntPtr.Zero;
            public int dwError = 0;
            public Win32.EditStreamCallbackProc callback = null;
        }

        // Declaration of this structure taken from reflection of System.Windows.Forms
        [StructLayout(LayoutKind.Sequential)]
        public class EDITSTREAM64
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
            public byte[] contents = new byte[20];
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4, CharSet = CharSet.Auto)]
        public struct CHARFORMAT2
        {
            public int cbSize;
            public uint dwMask;
            public uint dwEffects;
            public int yHeight;
            public int yOffset;
            public uint crTextColor;
            public byte bCharSet;
            public byte bPitchAndFamily;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string szFaceName;
            public short wWeight;
            public short sSpacing;
            public int crBackColor;
            public int lcid;
            public int dwReserved;
            public short sStyle;
            public short wKerning;
            public byte bUnderlineType;
            public byte bAnimation;
            public byte bRevAuthor;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct PARAFORMAT
        {
            public int cbSize;
            public uint dwMask;
            public short wNumbering;
            public short wReserved;
            public int dxStartIndent;
            public int dxRightIndent;
            public int dxOffset;
            public short wAlignment;
            public short cTabCount;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 0x20)]
            public int[] rgxTabs;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct PARAFORMAT2
        {
            internal int cbSize;
            internal uint dwMask;
            internal short wNumbering;
            internal short wReserved;
            internal int dxStartIndent;
            internal int dxRightIndent;
            internal int dxOffset;
            internal short wAlignment;
            internal short cTabCount;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            internal int[] rgxTabs;
            internal int dySpaceBefore;
            internal int dySpaceAfter;
            internal int dyLineSpacing;
            internal short sStyle;
            internal byte bLineSpacingRule;
            internal byte bOutlineLevel;
            internal short wShadingWeight;
            internal short wShadingStyle;
            internal short wNumberingStart;
            internal short wNumberingStyle;
            internal short wNumberingTab;
            internal short wBorderSpace;
            internal short wBorderWidth;
            internal short wBorders;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4, CharSet = CharSet.Auto)]
        public struct CHARFORMAT
        {
            public uint cbSize;
            public uint dwMask;
            public uint dwEffects;
            public int yHeight;
            public int yOffset;
            public uint crTextColor;
            public byte bCharSet;
            public byte bPitchAndFamily;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string szFaceName;
        }
        #endregion // RTF structures

        #region ListView control structures
        [StructLayout(LayoutKind.Sequential)]
        public struct LVITEM
        {
            public uint mask;
            public int iItem;
            public int iSubItem;
            public uint state;
            public uint stateMask;
            public IntPtr pszText;
            public int cchTextMax;
            public int iImage;
            public IntPtr lParam;
            public int iIndent;
            /*public int iGroupId;
            public uint cColumns;
            public IntPtr puColumns;*/
        }
        #endregion

        #region ComboBox structures
        [StructLayout(LayoutKind.Sequential)]
        public struct COMBOBOXINFO
        {
            public uint cbSize;
            public RECT rcItem;
            public RECT rcButton;
            public uint stateButton;
            public IntPtr hwndCombo;
            public IntPtr hwndItem;
            public IntPtr hwndList;
        }
        #endregion

        #region Delegates

        public delegate int EnumMetaFileProc(
            IntPtr hDC, // handle to DC
            IntPtr lpHTable, // metafile handle table
            IntPtr lpMFR, // metafile record
            int nObj, // count of objects
            IntPtr lpClientData); // optional data

        public delegate uint EditStreamCallbackProc(
            IntPtr dwCookie, // user data
            IntPtr buf, // buffer
            int cb, // number of bytes to read or write
            ref int pcb); // actually read or written

        public delegate int WindowProc(
            IntPtr hwnd,
            uint uMsg,
            IntPtr wParam,
            IntPtr lParam);

        #endregion // Delegates

        #region Constants
        public class TCM
        {
            public const int
                TCM_FIRST = 0x1300,
                TCM_SETMINTABWIDTH = TCM_FIRST + 49,
                TCM_SETITEMSIZE = TCM_FIRST + 41;
        }

        public class TME
        {
            public const uint
                TME_CANCEL = 0x80000000,
                TME_HOVER = 0x00000001,
                TME_LEAVE = 0x00000002,
                TME_NONCLIENT = 0x00000010,
                TME_QUERY = 0x40000000;
        }

        public class LWA
        {
            public const int
                LWA_ALPHA = 0x00000002,
                LWA_COLORKEY = 0x00000001;
        }

        public class STOCK_OBJECTS
        {
            public const int
                NULL_BRUSH = 5;
        }

        public class FILE_ATTRIBUTE
        {
            public const int
                FILE_ATTRIBUTE_READONLY = 0x00000001,
                FILE_ATTRIBUTE_HIDDEN = 0x00000002,
                FILE_ATTRIBUTE_SYSTEM = 0x00000004,
                FILE_ATTRIBUTE_DIRECTORY = 0x00000010,
                FILE_ATTRIBUTE_ARCHIVE = 0x00000020,
                FILE_ATTRIBUTE_NORMAL = 0x00000080,
                FILE_ATTRIBUTE_TEMPORARY = 0x00000100,
                FILE_ATTRIBUTE_COMPRESSED = 0x00000800,
                FILE_ATTRIBUTE_OFFLINE = 0x00001000;
        }

        public class HT
        {
            public const int
                HTERROR = -2,
                HTTRANSPARENT = -1,
                HTNOWHERE = 0,
                HTCLIENT = 1,
                HTCAPTION = 2,
                HTSYSMENU = 3,
                HTGROWBOX = 4,
                HTSIZE = HTGROWBOX,
                HTMENU = 5,
                HTHSCROLL = 6,
                HTVSCROLL = 7,
                HTMINBUTTON = 8,
                HTMAXBUTTON = 9,
                HTLEFT = 10,
                HTRIGHT = 11,
                HTTOP = 12,
                HTTOPLEFT = 13,
                HTTOPRIGHT = 14,
                HTBOTTOM = 15,
                HTBOTTOMLEFT = 16,
                HTBOTTOMRIGHT = 17,
                HTBORDER = 18,
                HTREDUCE = HTMINBUTTON,
                HTZOOM = HTMAXBUTTON,
                HTSIZEFIRST = HTLEFT,
                HTSIZELAST = HTBOTTOMRIGHT;
        }

        public class AW
        {
            public const int
                AW_HOR_POSITIVE = 0x00000001,   // Animates the window from left to right
                AW_HOR_NEGATIVE = 0x00000002,   // Animates the window from right to left
                AW_VER_POSITIVE = 0x00000004,   // Animates the window from top to bottom
                AW_VER_NEGATIVE = 0x00000008,   // Animates the window from bottom to top
                AW_CENTER = 0x00000010,   // Makes the window appear to collapse or expand
                AW_HIDE = 0x00010000,   // Hides the window
                AW_ACTIVATE = 0x00020000,   // Activates the window
                AW_SLIDE = 0x00040000,   // Uses slide animation
                AW_BLEND = 0x00080000;   // Uses a fade effect
        }

        public class VK
        {
            public const int
                VK_LBUTTON = 0x01,
                VK_RBUTTON = 0x02,
                VK_CANCEL = 0x03,
                VK_MBUTTON = 0x04,

                VK_XBUTTON1 = 0x05,
                VK_XBUTTON2 = 0x06,
                /*
                 * 0x07 : unassigned
                 */
                VK_BACK = 0x08,
                VK_TAB = 0x09,
                /*
                 * 0x0A - 0x0B : reserved
                 */
                VK_CLEAR = 0x0C,
                VK_RETURN = 0x0D,

                VK_SHIFT = 0x10,
                VK_CONTROL = 0x11,
                VK_MENU = 0x12,
                VK_PAUSE = 0x13,
                VK_CAPITAL = 0x14,

                VK_KANA = 0x15,
                VK_HANGEUL = 0x15,
                VK_HANGUL = 0x15,
                VK_JUNJA = 0x17,
                VK_FINAL = 0x18,
                VK_HANJA = 0x19,
                VK_KANJI = 0x19,

                VK_ESCAPE = 0x1B,

                VK_CONVERT = 0x1C,
                VK_NONCONVERT = 0x1D,
                VK_ACCEPT = 0x1E,
                VK_MODECHANGE = 0x1F,

                VK_SPACE = 0x20,
                VK_PRIOR = 0x21,
                VK_NEXT = 0x22,
                VK_END = 0x23,
                VK_HOME = 0x24,
                VK_LEFT = 0x25,
                VK_UP = 0x26,
                VK_RIGHT = 0x27,
                VK_DOWN = 0x28,
                VK_SELECT = 0x29,
                VK_PRINT = 0x2A,
                VK_EXECUTE = 0x2B,
                VK_SNAPSHOT = 0x2C,
                VK_INSERT = 0x2D,
                VK_DELETE = 0x2E,
                VK_HELP = 0x2F,
                /*
                 * VK_0 - VK_9 are the same as ASCII '0' - '9' (0x30 - 0x39)
                 * 0x40 : unassigned
                 * VK_A - VK_Z are the same as ASCII 'A' - 'Z' (0x41 - 0x5A)
                 */
                VK_LWIN = 0x5B,
                VK_RWIN = 0x5C,
                VK_APPS = 0x5D,
                /*
                 * 0x5E : reserved
                 */
                VK_SLEEP = 0x5F,

                VK_NUMPAD0 = 0x60,
                VK_NUMPAD1 = 0x61,
                VK_NUMPAD2 = 0x62,
                VK_NUMPAD3 = 0x63,
                VK_NUMPAD4 = 0x64,
                VK_NUMPAD5 = 0x65,
                VK_NUMPAD6 = 0x66,
                VK_NUMPAD7 = 0x67,
                VK_NUMPAD8 = 0x68,
                VK_NUMPAD9 = 0x69,
                VK_MULTIPLY = 0x6A,
                VK_ADD = 0x6B,
                VK_SEPARATOR = 0x6C,
                VK_SUBTRACT = 0x6D,
                VK_DECIMAL = 0x6E,
                VK_DIVIDE = 0x6F,
                VK_F1 = 0x70,
                VK_F2 = 0x71,
                VK_F3 = 0x72,
                VK_F4 = 0x73,
                VK_F5 = 0x74,
                VK_F6 = 0x75,
                VK_F7 = 0x76,
                VK_F8 = 0x77,
                VK_F9 = 0x78,
                VK_F10 = 0x79,
                VK_F11 = 0x7A,
                VK_F12 = 0x7B,
                VK_F13 = 0x7C,
                VK_F14 = 0x7D,
                VK_F15 = 0x7E,
                VK_F16 = 0x7F,
                VK_F17 = 0x80,
                VK_F18 = 0x81,
                VK_F19 = 0x82,
                VK_F20 = 0x83,
                VK_F21 = 0x84,
                VK_F22 = 0x85,
                VK_F23 = 0x86,
                VK_F24 = 0x87,
                /*
                 * 0x88 - 0x8F : unassigned
                 */
                VK_NUMLOCK = 0x90,
                VK_SCROLL = 0x91,
                /*
                 * NEC PC-9800 kbd definitions
                 */
                VK_OEM_NEC_EQUAL = 0x92,
                /*
                 * Fujitsu/OASYS kbd definitions
                 */
                VK_OEM_FJ_JISHO = 0x92,
                VK_OEM_FJ_MASSHOU = 0x93,
                VK_OEM_FJ_TOUROKU = 0x94,
                VK_OEM_FJ_LOYA = 0x95,
                VK_OEM_FJ_ROYA = 0x96,
                /*
                 * 0x97 - 0x9F : unassigned
                 */
                /*
                 * VK_L* & VK_R* - left and right Alt, Ctrl and Shift virtual keys.
                 * Used only as parameters to GetAsyncKeyState() and GetKeyState().
                 * No other API or message will distinguish left and right keys in this way.
                 */
                VK_LSHIFT = 0xA0,
                VK_RSHIFT = 0xA1,
                VK_LCONTROL = 0xA2,
                VK_RCONTROL = 0xA3,
                VK_LMENU = 0xA4,
                VK_RMENU = 0xA5,

                VK_BROWSER_BACK = 0xA6,
                VK_BROWSER_FORWARD = 0xA7,
                VK_BROWSER_REFRESH = 0xA8,
                VK_BROWSER_STOP = 0xA9,
                VK_BROWSER_SEARCH = 0xAA,
                VK_BROWSER_FAVORITES = 0xAB,
                VK_BROWSER_HOME = 0xAC,

                VK_VOLUME_MUTE = 0xAD,
                VK_VOLUME_DOWN = 0xAE,
                VK_VOLUME_UP = 0xAF,
                VK_MEDIA_NEXT_TRACK = 0xB0,
                VK_MEDIA_PREV_TRACK = 0xB1,
                VK_MEDIA_STOP = 0xB2,
                VK_MEDIA_PLAY_PAUSE = 0xB3,
                VK_LAUNCH_MAIL = 0xB4,
                VK_LAUNCH_MEDIA_SELECT = 0xB5,
                VK_LAUNCH_APP1 = 0xB6,
                VK_LAUNCH_APP2 = 0xB7,
                /*
                 * 0xB8 - 0xB9 : reserved
                 */
                VK_OEM_1 = 0xBA,
                VK_OEM_PLUS = 0xBB,
                VK_OEM_COMMA = 0xBC,
                VK_OEM_MINUS = 0xBD,
                VK_OEM_PERIOD = 0xBE,
                VK_OEM_2 = 0xBF,
                VK_OEM_3 = 0xC0,
                /*
                 * 0xC1 - 0xD7 : reserved
                 */
                /*
                 * 0xD8 - 0xDA : unassigned
                 */
                VK_OEM_4 = 0xDB,
                VK_OEM_5 = 0xDC,
                VK_OEM_6 = 0xDD,
                VK_OEM_7 = 0xDE,
                VK_OEM_8 = 0xDF,
                /*
                 * 0xE0 : reserved
                 */
                /*
                 * Various extended or enhanced keyboards
                 */
                VK_OEM_AX = 0xE1,
                VK_OEM_102 = 0xE2,
                VK_ICO_HELP = 0xE3,
                VK_ICO_00 = 0xE4,

                VK_PROCESSKEY = 0xE5,

                VK_ICO_CLEAR = 0xE6,

                VK_PACKET = 0xE7,
                /*
                 * 0xE8 : unassigned
                 */
                /*
                 * Nokia/Ericsson definitions
                 */
                VK_OEM_RESET = 0xE9,
                VK_OEM_JUMP = 0xEA,
                VK_OEM_PA1 = 0xEB,
                VK_OEM_PA2 = 0xEC,
                VK_OEM_PA3 = 0xED,
                VK_OEM_WSCTRL = 0xEE,
                VK_OEM_CUSEL = 0xEF,
                VK_OEM_ATTN = 0xF0,
                VK_OEM_FINISH = 0xF1,
                VK_OEM_COPY = 0xF2,
                VK_OEM_AUTO = 0xF3,
                VK_OEM_ENLW = 0xF4,
                VK_OEM_BACKTAB = 0xF5,

                VK_ATTN = 0xF6,
                VK_CRSEL = 0xF7,
                VK_EXSEL = 0xF8,
                VK_EREOF = 0xF9,
                VK_PLAY = 0xFA,
                VK_ZOOM = 0xFB,
                VK_NONAME = 0xFC,
                VK_PA1 = 0xFD,
                VK_OEM_CLEAR = 0xFE;
        }

        public class CS
        {
            public const int
                CS_SAVEBITS = 0x00000800;
        }

        public class OBM
        {
            public const long
                // OBM_LFARROWI   = 32734,   // A disabled left-pointing arrow for scroll bars
                // OBM_RGARROWI   = 32735,
                // OBM_DNARROWI   = 32736,   // A disabled down-pointing arrow for scroll bars
                // OBM_UPARROWI   = 32737,
                OBM_COMBO = 32738,     // dropdown arrow
                OBM_MNARROW = 32739,     // submenu arrow
                // OBM_LFARROWD   = 32740,
                // OBM_RGARROWD   = 32741,
                // OBM_DNARROWD   = 32742,
                // OBM_UPARROWD   = 32743,
                // OBM_RESTORED   = 32744,   // restore button with border pressed
                // OBM_ZOOMD      = 32745,   // maximize button with border pressed
                // OBM_REDUCED    = 32746,   // minimize button with border pressed
                // OBM_RESTORE    = 32747,   // restore button with border normal
                // OBM_ZOOM       = 32748,   // maximize button with border normal
                // OBM_REDUCE     = 32749,   // minimize button with border normal
                // OBM_LFARROW    = 32750,   // arrows from scrollbar with borders
                // OBM_RGARROW    = 32751,
                // OBM_DNARROW    = 32752,
                // OBM_UPARROW    = 32753,
                // OBM_CLOSE      = 32754,
                // OBM_BTNCORNERS = 32758,
                // OBM_CHECKBOXES = 32759,   // all checnkboxes and radiobuttons (12 images in one)
                OBM_CHECK = 32760;     // check mark
            // OBM_BTSIZE     = 32761,   // size grip
            // OBM_SIZE       = 32766,   // size grip
        }

        /// <summary>
        /// System Menu Command Values
        /// </summary>
        public class SC
        {
            public const int
                SC_SIZE = 61440,
                SC_MOVE = 61456,
                SC_MINIMIZE = 61472,
                SC_MAXIMIZE = 61488,
                SC_NEXTWINDOW = 61504,
                SC_PREVWINDOW = 61520,
                SC_CLOSE = 61536,
                // SC_VSCROLL = 61552,
                // SC_HSCROLL = 61568,
                // SC_MOUSEMENU = 61584,
                // SC_KEYMENU = 61696,
                // SC_ARRANGE = 61712,
                SC_RESTORE = 61728;
            // SC_TASKLIST = 61744,
            // SC_SCREENSAVE = 61760,
            // SC_HOTKEY = 61776,
            // SC_DEFAULT = 61792,
            // SC_MONITORPOWER = 61808,
            // SC_CONTEXTHELP = 61824,
            // SC_SEPARATOR = 61455,
        }

        public class DT
        {
            public const int
                DT_TOP = 0,
                DT_LEFT = 0,
                DT_CENTER = 1,
                DT_RIGHT = 2,
                DT_VCENTER = 4,
                DT_BOTTOM = 8,
                DT_WORDBREAK = 0x10,
                DT_SINGLELINE = 0x20,
                DT_EXPANDTABS = 0x40,
                DT_TABSTOP = 0x80,
                DT_NOCLIP = 0x100,
                DT_EXTERNALLEADING = 0x200,
                DT_CALCRECT = 0x400,
                DT_NOPREFIX = 0x800,
                DT_INTERNAL = 0x1000,
                DT_HIDEPREFIX = 0x00100000,
                DT_PREFIXONLY = 0x00200000,

                DT_EDITCONTROL = 0x2000,
                DT_PATH_ELLIPSIS = 0x4000,
                DT_END_ELLIPSIS = 0x8000,
                DT_MODIFYSTRING = 0x10000,
                DT_RTLREADING = 0x20000,
                DT_WORD_ELLIPSIS = 0x40000;
        }

        /*public class LVIF
        {
            public const uint
                LVIF_TEXT = 0x0001,
                LVIF_IMAGE = 0x0002,
                LVIF_PARAM = 0x0004,
                LVIF_STATE = 0x0008,
                LVIF_INDENT = 0x0010,
                LVIF_NORECOMPUTE = 0x0800;
        }*/

        public class COLOR
        {
            public const int
                COLOR_BTNFACE = 15,
                COLOR_BTNSHADOW = 16,
                COLOR_BTNTEXT = 18,
                COLOR_BTNHIGHLIGHT = 20,
                COLOR_3DDKSHADOW = 21,
                COLOR_MENUBAR = 30,
                COLOR_3DLIGHT = 22;
        }

        public class RDH
        {
            public const int
                RDH_RECTANGLES = 1;
        }

        public class LVIS
        {
            public const uint
                LVIS_FOCUSED = 0x0001,
                LVIS_SELECTED = 0x0002,
                LVIS_CUT = 0x0004,
                LVIS_DROPHILITED = 0x0008,
                LVIS_ACTIVATING = 0x0020,
                LVIS_OVERLAYMASK = 0x0F00,
                LVIS_STATEIMAGEMASK = 0xF000;
        }

        public class LVIF
        {
            public const uint
                LVIF_TEXT = 0x0001,
                LVIF_IMAGE = 0x0002,
                LVIF_PARAM = 0x0004,
                LVIF_STATE = 0x0008,
                LVIF_INDENT = 0x0010,
                LVIF_NORECOMPUTE = 0x0800;
        }

        public class LVM
        {
            public const uint
                LVM_FIRST = 0x1000,
                LVM_SETHOTITEM = LVM_FIRST + 60,
                LVM_SETITEMSTATE = LVM_FIRST + 43;
        }

        public class AlphaFormat
        {
            public const uint
                AC_SRC_OVER = 0x00,
                AC_SRC_ALPHA = 0x01;
        }

        public class ULW
        {
            public const uint
                ULW_COLORKEY = 0x00000001,
                ULW_ALPHA = 0x00000002,
                ULW_OPAQUE = 0x00000004;
        }

        /// <summary>
        /// SetWindowPos flags.
        /// </summary>
        public class SWP
        {
            public const uint
                SWP_NOSIZE = 0x1,
                SWP_NOMOVE = 0x2,
                SWP_NOZORDER = 0x4,
                SWP_NOREDRAW = 0x8,
                SWP_NOACTIVATE = 0x10,
                SWP_FRAMECHANGED = 0x20,
                SWP_SHOWWINDOW = 0x40,
                SWP_HIDEWINDOW = 0x80,
                SWP_NOCOPYBITS = 0x100,
                SWP_NOOWNERZORDER = 0x200,
                SWP_NOSENDCHANGING = 0x400,
                SWP_DRAWFRAME = SWP_FRAMECHANGED,
                SWP_NOREPOSITION = SWP_NOOWNERZORDER,
                SWP_DEFERERASE = 0x2000,
                SWP_ASYNCWINDOWPOS = 0x4000;
        }

        public class SWP_HWND
        {
            public static readonly IntPtr
                HWND_TOP = (IntPtr)(0),
                HWND_BOTTOM = (IntPtr)(1),
                HWND_TOPMOST = (IntPtr)(-1),
                HWND_NOTOPMOST = (IntPtr)(-2);
        }

        /// <summary>
        /// Flags for ChangeDisplaySettings() function.
        /// </summary>
        public class CDS
        {
            public const uint
                CDS_DYNAMICALLY = 0x00,
                CDS_UPDATEREGISTRY = 0x01,
                CDS_TEST = 0x02,
                CDS_FULLSCREEN = 0x04,
                CDS_GLOBAL = 0x08,
                CDS_SET_PRIMARY = 0x10,
                CDS_RESET = 0x40000000,
                CDS_SETRECT = 0x20000000,
                CDS_NORESET = 0x10000000;
        }

        /// <summary>
        /// Return values of the ChangeDisplaySettings() function.
        /// </summary>
        public class DISP
        {
            public const int
                DISP_CHANGE_SUCCESSFUL = 0,
                DISP_CHANGE_RESTART = 1,
                DISP_CHANGE_FAILED = -1,
                DISP_CHANGE_BADMODE = -2,
                DISP_CHANGE_NOTUPDATED = -3,
                DISP_CHANGE_BADFLAGS = -4,
                DISP_CHANGE_BADPARAM = -5;
        }

        public class CBN
        {
            public const int
                CBN_ERRSPACE = (-1),
                CBN_SELCHANGE = 1,
                CBN_DBLCLK = 2,
                CBN_SETFOCUS = 3,
                CBN_KILLFOCUS = 4,
                CBN_EDITCHANGE = 5,
                CBN_EDITUPDATE = 6,
                CBN_DROPDOWN = 7,
                CBN_CLOSEUP = 8,
                CBN_SELENDOK = 9,
                CBN_SELENDCANCEL = 10;
        }

        /// <summary>
        /// Windows messages.
        /// </summary>
        public class WM
        {
            public const int
                WM_NULL = 0x0000,
                WM_CREATE = 0x0001,
                WM_DESTROY = 0x0002,
                WM_MOVE = 0x0003,
                WM_SIZE = 0x0005,

                WM_ACTIVATE = 0x0006,

                WM_SETFOCUS = 0x0007,
                WM_KILLFOCUS = 0x0008,
                WM_ENABLE = 0x000A,
                WM_SETREDRAW = 0x000B,
                WM_SETTEXT = 0x000C,
                WM_GETTEXT = 0x000D,
                WM_GETTEXTLENGTH = 0x000E,
                WM_PAINT = 0x000F,
                WM_CLOSE = 0x0010,

                WM_QUERYENDSESSION = 0x0011,
                WM_QUERYOPEN = 0x0013,
                WM_ENDSESSION = 0x0016,

                WM_QUIT = 0x0012,
                WM_ERASEBKGND = 0x0014,
                WM_SYSCOLORCHANGE = 0x0015,
                WM_SHOWWINDOW = 0x0018,
                WM_WININICHANGE = 0x001A,

                WM_SETTINGCHANGE = 0x001A,

                WM_DEVMODECHANGE = 0x001B,
                WM_ACTIVATEAPP = 0x001C,
                WM_FONTCHANGE = 0x001D,
                WM_TIMECHANGE = 0x001E,
                WM_CANCELMODE = 0x001F,
                WM_SETCURSOR = 0x0020,
                WM_MOUSEACTIVATE = 0x0021,
                WM_CHILDACTIVATE = 0x0022,
                WM_QUEUESYNC = 0x0023,

                WM_GETMINMAXINFO = 0x0024,

                WM_PAINTICON = 0x0026,
                WM_ICONERASEBKGND = 0x0027,
                WM_NEXTDLGCTL = 0x0028,
                WM_SPOOLERSTATUS = 0x002A,
                WM_DRAWITEM = 0x002B,
                WM_MEASUREITEM = 0x002C,
                WM_DELETEITEM = 0x002D,
                WM_VKEYTOITEM = 0x002E,
                WM_CHARTOITEM = 0x002F,
                WM_SETFONT = 0x0030,
                WM_GETFONT = 0x0031,
                WM_SETHOTKEY = 0x0032,
                WM_GETHOTKEY = 0x0033,
                WM_QUERYDRAGICON = 0x0037,
                WM_COMPAREITEM = 0x0039,

                WM_GETOBJECT = 0x003D,

                WM_COMPACTING = 0x0041,
                WM_COMMNOTIFY = 0x0044,
                WM_WINDOWPOSCHANGING = 0x0046,
                WM_WINDOWPOSCHANGED = 0x0047,

                WM_POWER = 0x0048,

                WM_COPYDATA = 0x004A,
                WM_CANCELJOURNAL = 0x004B,

                WM_NOTIFY = 0x004E,
                WM_INPUTLANGCHANGEREQUEST = 0x0050,
                WM_INPUTLANGCHANGE = 0x0051,
                WM_TCARD = 0x0052,
                WM_HELP = 0x0053,
                WM_USERCHANGED = 0x0054,
                WM_NOTIFYFORMAT = 0x0055,

                WM_CONTEXTMENU = 0x007B,
                WM_STYLECHANGING = 0x007C,
                WM_STYLECHANGED = 0x007D,
                WM_DISPLAYCHANGE = 0x007E,
                WM_GETICON = 0x007F,
                WM_SETICON = 0x0080,

                WM_NCCREATE = 0x0081,
                WM_NCDESTROY = 0x0082,
                WM_NCCALCSIZE = 0x0083,
                WM_NCHITTEST = 0x0084,
                WM_NCPAINT = 0x0085,
                WM_NCACTIVATE = 0x0086,
                WM_GETDLGCODE = 0x0087,

                WM_SYNCPAINT = 0x0088,

                WM_NCMOUSEMOVE = 0x00A0,
                WM_NCLBUTTONDOWN = 0x00A1,
                WM_NCLBUTTONUP = 0x00A2,
                WM_NCLBUTTONDBLCLK = 0x00A3,
                WM_NCRBUTTONDOWN = 0x00A4,
                WM_NCRBUTTONUP = 0x00A5,
                WM_NCRBUTTONDBLCLK = 0x00A6,
                WM_NCMBUTTONDOWN = 0x00A7,
                WM_NCMBUTTONUP = 0x00A8,
                WM_NCMBUTTONDBLCLK = 0x00A9,

                WM_NCXBUTTONDOWN = 0x00AB,
                WM_NCXBUTTONUP = 0x00AC,
                WM_NCXBUTTONDBLCLK = 0x00AD,

                WM_INPUT = 0x00FF,

                WM_KEYFIRST = 0x0100,
                WM_KEYDOWN = 0x0100,
                WM_KEYUP = 0x0101,
                WM_CHAR = 0x0102,
                WM_DEADCHAR = 0x0103,
                WM_SYSKEYDOWN = 0x0104,
                WM_SYSKEYUP = 0x0105,
                WM_SYSCHAR = 0x0106,
                WM_SYSDEADCHAR = 0x0107,

                WM_KEYLAST = 0x0108,

                WM_IME_STARTCOMPOSITION = 0x010D,
                WM_IME_ENDCOMPOSITION = 0x010E,
                WM_IME_COMPOSITION = 0x010F,
                WM_IME_KEYLAST = 0x010F,

                WM_INITDIALOG = 0x0110,
                WM_COMMAND = 0x0111,
                WM_SYSCOMMAND = 0x0112,
                WM_TIMER = 0x0113,
                WM_HSCROLL = 0x0114,
                WM_VSCROLL = 0x0115,
                WM_INITMENU = 0x0116,
                WM_INITMENUPOPUP = 0x0117,
                WM_MENUSELECT = 0x011F,
                WM_MENUCHAR = 0x0120,
                WM_ENTERIDLE = 0x0121,

                WM_MENURBUTTONUP = 0x0122,
                WM_MENUDRAG = 0x0123,
                WM_MENUGETOBJECT = 0x0124,
                WM_UNINITMENUPOPUP = 0x0125,
                WM_MENUCOMMAND = 0x0126,

                WM_CHANGEUISTATE = 0x0127,
                WM_UPDATEUISTATE = 0x0128,
                WM_QUERYUISTATE = 0x0129,

                WM_CTLCOLORMSGBOX = 0x0132,
                WM_CTLCOLOREDIT = 0x0133,
                WM_CTLCOLORLISTBOX = 0x0134,
                WM_CTLCOLORBTN = 0x0135,
                WM_CTLCOLORDLG = 0x0136,
                WM_CTLCOLORSCROLLBAR = 0x0137,
                WM_CTLCOLORSTATIC = 0x0138,

                WM_MOUSEFIRST = 0x0200,
                WM_MOUSEMOVE = 0x0200,
                WM_LBUTTONDOWN = 0x0201,
                WM_LBUTTONUP = 0x0202,
                WM_LBUTTONDBLCLK = 0x0203,
                WM_RBUTTONDOWN = 0x0204,
                WM_RBUTTONUP = 0x0205,
                WM_RBUTTONDBLCLK = 0x0206,
                WM_MBUTTONDOWN = 0x0207,
                WM_MBUTTONUP = 0x0208,
                WM_MBUTTONDBLCLK = 0x0209,

                WM_MOUSEWHEEL = 0x020A,

                WM_XBUTTONDOWN = 0x020B,
                WM_XBUTTONUP = 0x020C,
                WM_XBUTTONDBLCLK = 0x020D,
                WM_MOUSELAST = 0x020D,

                WM_PARENTNOTIFY = 0x0210,
                WM_ENTERMENULOOP = 0x0211,
                WM_EXITMENULOOP = 0x0212,

                WM_NEXTMENU = 0x0213,
                WM_SIZING = 0x0214,
                WM_CAPTURECHANGED = 0x0215,
                WM_MOVING = 0x0216,

                WM_POWERBROADCAST = 0x0218,

                WM_DEVICECHANGE = 0x0219,

                WM_MDICREATE = 0x0220,
                WM_MDIDESTROY = 0x0221,
                WM_MDIACTIVATE = 0x0222,
                WM_MDIRESTORE = 0x0223,
                WM_MDINEXT = 0x0224,
                WM_MDIMAXIMIZE = 0x0225,
                WM_MDITILE = 0x0226,
                WM_MDICASCADE = 0x0227,
                WM_MDIICONARRANGE = 0x0228,
                WM_MDIGETACTIVE = 0x0229,

                WM_MDISETMENU = 0x0230,
                WM_ENTERSIZEMOVE = 0x0231,
                WM_EXITSIZEMOVE = 0x0232,
                WM_DROPFILES = 0x0233,
                WM_MDIREFRESHMENU = 0x0234,


                WM_IME_SETCONTEXT = 0x0281,
                WM_IME_NOTIFY = 0x0282,
                WM_IME_CONTROL = 0x0283,
                WM_IME_COMPOSITIONFULL = 0x0284,
                WM_IME_SELECT = 0x0285,
                WM_IME_CHAR = 0x0286,

                WM_IME_REQUEST = 0x0288,

                WM_IME_KEYDOWN = 0x0290,
                WM_IME_KEYUP = 0x0291,

                WM_MOUSEHOVER = 0x02A1,
                WM_MOUSELEAVE = 0x02A3,

                WM_NCMOUSEHOVER = 0x02A0,
                WM_NCMOUSELEAVE = 0x02A2,

                WM_WTSSESSION_CHANGE = 0x02B1,

                WM_TABLET_FIRST = 0x02,
                WM_TABLET_LAST = 0x02,

                WM_CUT = 0x0300,
                WM_COPY = 0x0301,
                WM_PASTE = 0x0302,
                WM_CLEAR = 0x0303,
                WM_UNDO = 0x0304,
                WM_RENDERFORMAT = 0x0305,
                WM_RENDERALLFORMATS = 0x0306,
                WM_DESTROYCLIPBOARD = 0x0307,
                WM_DRAWCLIPBOARD = 0x0308,
                WM_PAINTCLIPBOARD = 0x0309,
                WM_VSCROLLCLIPBOARD = 0x030A,
                WM_SIZECLIPBOARD = 0x030B,
                WM_ASKCBFORMATNAME = 0x030C,
                WM_CHANGECBCHAIN = 0x030D,
                WM_HSCROLLCLIPBOARD = 0x030E,
                WM_QUERYNEWPALETTE = 0x030F,
                WM_PALETTEISCHANGING = 0x0310,
                WM_PALETTECHANGED = 0x0311,
                WM_HOTKEY = 0x0312,

                WM_PRINT = 0x0317,
                WM_PRINTCLIENT = 0x0318,

                WM_APPCOMMAND = 0x0319,

                WM_THEMECHANGED = 0x031A,       // occurs when WinXP is changed to classic
                WM_THEMECHANGEDNEW = 0x031B,    // occurs when themes changed

                WM_HANDHELDFIRST = 0x0358,
                WM_HANDHELDLAST = 0x035F,

                WM_AFXFIRST = 0x0360,
                WM_AFXLAST = 0x037F,

                WM_PENWINFIRST = 0x0380,
                WM_PENWINLAST = 0x038F,

                WM_APP = 0x8000,

                /*
                 * NOTE: All Message Numbers below 0x0400 are RESERVED.
                 *
                 * Private Window Messages Start Here:
                 */
                WM_USER = 0x0400;
        }

        public class MK
        {
            public const int
                MK_LBUTTON = 0x0001,
                MK_RBUTTON = 0x0002,
                MK_SHIFT = 0x0004,
                MK_CONTROL = 0x0008,
                MK_MBUTTON = 0x0010,
                MK_XBUTTON1 = 0x0020,
                MK_XBUTTON2 = 0x0040;
        }

        /// <summary>
        /// EditControl window messages.
        /// </summary>
        public class EM
        {
            public const int
                EM_FORMATRANGE = WM.WM_USER + 57,
                EM_STREAMIN = WM.WM_USER + 73,
                EM_STREAMOUT = WM.WM_USER + 74,
                EM_SETCHARFORMAT = WM.WM_USER + 68,
                EM_GETCHARFORMAT = WM.WM_USER + 58,
                EM_SETPARAFORMAT = WM.WM_USER + 0x47,

                EM_AUTOURLDETECT = WM.WM_USER + 91,
                EM_GETAUTOURLDETECT = WM.WM_USER + 92,
                EM_SETOLECALLBACK = WM.WM_USER + 70,
                EM_SETBKGNDCOLOR = WM.WM_USER + 67,
                EM_SETTYPOGRAPHYOPTIONS = WM.WM_USER + 0xCA,
                EM_EXLIMITTEXT = WM.WM_USER + 53,

                EM_SETPASSWORDCHAR = 0xCC,

                EM_SETSEL = 0x00B1,
                // following are from true grid's Win32:
                EM_GETSEL = 0xB0,
                EM_GETRECT = 0xB2,
                EM_SETRECT = 0xB3,
                EM_SETRECTNP = 0xB4,
                EM_SCROLLCARET = 0xB7,
                EM_GETLINECOUNT = 0xBA,
                EM_LINEINDEX = 0xBB,
                EM_LINEFROMCHAR = 0xC9,
                EM_GETFIRSTVISIBLELINE = 0xCE,
                EM_SETMARGINS = 0xD3,
                EM_GETMARGINS = 0xD4,
                EM_CHARFROMPOS = 0xD7;
        }

        public static class EN
        {
            public const int
                EN_SELCHANGE = 0x0702;
        }

        /// <summary>
        /// WM_HSCROLL and WM_VSCROLL notifications codes.
        /// </summary>
        public class SB
        {
            public const uint
                SB_LINEUP = 0,
                SB_LINELEFT = 0,
                SB_LINEDOWN = 1,
                SB_LINERIGHT = 1,
                SB_PAGEUP = 2,
                SB_PAGELEFT = 2,
                SB_PAGEDOWN = 3,
                SB_PAGERIGHT = 3,
                SB_THUMBPOSITION = 4,
                SB_THUMBTRACK = 5,
                SB_TOP = 6,
                SB_LEFT = 6,
                SB_BOTTOM = 7,
                SB_RIGHT = 7,
                SB_ENDSCROLL = 8;
        }

        /// <summary>
        /// BM_GETSTATE flags.
        /// </summary>
        public class BST
        {
            public const uint
                BST_CHECKED = 0x0001,
                BST_FOCUS = 0x0008,
                BST_INDETERMINATE = 0x0002,
                BST_PUSHED = 0x0004,
                BST_UNCHECKED = 0x0000;
        }

        /// <summary>
        /// BM_XXX flags.
        /// </summary>
        public class BM
        {
            public const uint
                BM_GETCHECK = 0x00F0,
                BM_SETCHECK = 0x00F1,
                BM_GETSTATE = 0x00F2,
                BM_SETSTATE = 0x00F3,
                BM_SETSTYLE = 0x00F4,
                BM_CLICK = 0x00F5,
                BM_GETIMAGE = 0x00F6,
                BM_SETIMAGE = 0x00F7;
        }

        /// <summary>
        /// DRAWITEMSTRUCT control types.
        /// </summary>
        public class ODT
        {
            public const uint
                ODT_BUTTON = 0x0004,
                ODT_COMBOBOX = 0x0003,
                ODT_LISTBOX = 0x0002,
                ODT_MENU = 0x0001,
                ODT_STATIC = 0x0005;
        }

        /// <summary>
        /// DRAWITEMSTRUCT drawing actions.
        /// </summary>
        public class ODA
        {
            public const uint
                ODA_DRAWENTIRE = 0x0001,
                ODA_FOCUS = 0x0004,
                ODA_SELECT = 0x0002;
        }

        /// <summary>
        /// DRAWITEMSTRUCT visual states.
        /// </summary>
        public class ODS
        {
            public const uint
                ODS_CHECKED = 0x0008,
                ODS_COMBOBOXEDIT = 0x1000,
                ODS_DEFAULT = 0x0020,
                ODS_DISABLED = 0x0004,
                ODS_FOCUS = 0x0010,
                ODS_GRAYED = 0x0002,
                ODS_HOTLIGHT = 0x0040,
                ODS_INACTIVE = 0x0080,
                ODS_SELECTED = 0x0001;
        }

        /// <summary>
        /// ComponentOne constants.
        /// </summary>
        public class C1
        {
            public const uint
                GDICOMMENT_VSMETATAGIDENTIFIER = 0x88880001,
                GDICOMMENT_C1_BEGIN_HYPERLINK = 0x88880002,
                GDICOMMENT_C1_END_HYPERLINK = 0x88880003,
                GDICOMMENT_C1_METAFILE_INFO = 0x88880004,
                GDICOMMENT_C1_ARCOFIELD_INFO = 0x88880005;

            public const int
                GDICOMMENT_VSMETATAGMINSIZE = 20;
        }

        /// <summary>
        /// Specifies a raster-operation code, used by BitBlt function and other.
        /// </summary>
        public class RasterOperationCodes
        {
            public const uint
                SRCCOPY = 0x00CC0020, // dest = source
                SRCPAINT = 0x00EE0086, // dest = source OR dest
                SRCAND = 0x008800C6, // dest = source AND dest
                SRCINVERT = 0x00660046, // dest = source XOR dest
                SRCERASE = 0x00440328, // dest = source AND (NOT dest)
                NOTSRCCOPY = 0x00330008, // dest = (NOT source)
                NOTSRCERASE = 0x001100A6, // dest = (NOT src) AND (NOT dest)
                MERGECOPY = 0x00C000CA, // dest = (source AND pattern)
                MERGEPAINT = 0x00BB0226, // dest = (NOT source) OR dest
                PATCOPY = 0x00F00021, // dest = pattern
                PATPAINT = 0x00FB0A09, // dest = DPSnoo
                PATINVERT = 0x005A0049, // dest = pattern XOR dest
                DSTINVERT = 0x00550009, // dest = (NOT dest)
                BLACKNESS = 0x00000042, // dest = BLACK
                WHITENESS = 0x00FF0062; // dest = WHITE
        }

        /// <summary>
        /// ShowWindow() function codes.
        /// </summary>
        public class SW
        {
            public const int
                SW_HIDE = 0,
                SW_SHOWNORMAL = 1,
                SW_NORMAL = 1,
                SW_SHOWMINIMIZED = 2,
                SW_SHOWMAXIMIZED = 3,
                SW_MAXIMIZE = 3,
                SW_SHOWNOACTIVATE = 4,
                SW_SHOW = 5,
                SW_MINIMIZE = 6,
                SW_SHOWMINNOACTIVE = 7,
                SW_SHOWNA = 8,
                SW_RESTORE = 9,
                SW_SHOWDEFAULT = 10,
                SW_MAX = 10;
        }

        /// <summary>
        /// WM_PRINT drawing options.
        /// </summary>
        public class PRF
        {
            public const uint
                PRF_CHECKVISIBLE = 0x00000001,
                PRF_NONCLIENT = 0x00000002,
                PRF_CLIENT = 0x00000004,
                PRF_ERASEBKGND = 0x00000008,
                PRF_CHILDREN = 0x00000010,
                PRF_OWNED = 0x00000020;
        }

        /// <summary>
        /// Rich edit data format types.
        /// </summary>
        public class SF
        {
            public const uint
                SF_TEXT = 0x0001,
                SF_RTF = 0x0002,
                SF_RTFNOOBJS = 0x0003,
                SF_TEXTIZED = 0x0004,
                SF_UNICODE = 0x0010;
        }

        /// <summary>
        /// Rich edit data format replacement options.
        /// </summary>
        public class SFF
        {
            public const uint
                SFF_SELECTION = 0x8000;
        }

        /// <summary>
        /// EM_SETCHARFORMAT / EM_GETCHARFORMAT flags.
        /// </summary>
        public class SCF
        {
            public const uint
                SCF_SELECTION = 0x0001,
                SCF_WORD = 0x0002,
                SCF_DEFAULT = 0x0000,
                SCF_ALL = 0x0004;
        }

        /// <summary>
        /// EM_SETPARAFORMAT / EM_GETPARAFORMAT flags.
        /// </summary>
        public class PFM
        {
            public const uint
                PFM_ALIGNMENT = 0x08;
        }

        /// <summary>
        /// CHARFORMAT mask values.
        /// </summary>
        public class CFM
        {
            public const uint
                CFM_BOLD = 0x00000001,
                CFM_ITALIC = 0x00000002,
                CFM_UNDERLINE = 0x00000004,
                CFM_STRIKEOUT = 0x00000008,
                CFM_PROTECTED = 0x00000010,
                CFM_LINK = 0x00000020,
                CFM_SIZE = 0x80000000,
                CFM_COLOR = 0x40000000,
                CFM_FACE = 0x20000000,
                CFM_OFFSET = 0x10000000,
                CFM_BACKCOLOR = 0x04000000,
                CFM_CHARSET = 0x08000000;
        }

        /// <summary>
        /// CHARFORMAT effects.
        /// </summary>
        public class CFE
        {
            public const uint
                CFE_BOLD = 0x0001,
                CFE_ITALIC = 0x0002,
                CFE_UNDERLINE = 0x0004,
                CFE_STRIKEOUT = 0x0008,
                CFE_PROTECTED = 0x0010,
                CFE_LINK = 0x0020,
                CFE_AUTOBACKCOLOR = CFM.CFM_BACKCOLOR,
                CFE_AUTOCOLOR = 0x40000000;
        }

        /// <summary>
        /// EM_SETTYPOGRAPHYOPTIONS flags.
        /// </summary>
        public class TO
        {
            public const uint
                TO_ADVANCEDTYPOGRAPHY = 0x01;
        }

        /// <summary>
        /// Text Alignment Options.
        /// </summary>
        public class TA
        {
            public const uint
                TA_NOUPDATECP = 0,
                TA_UPDATECP = 1,

                TA_LEFT = 0,
                TA_RIGHT = 2,
                TA_CENTER = 6,

                TA_TOP = 0,
                TA_BOTTOM = 8,
                TA_BASELINE = 24;
        }

        /// <summary>
        /// GetDCEx() flags.
        /// </summary>
        public class DCX
        {
            public const uint
                DCX_WINDOW = 0x00000001,
                DCX_CACHE = 0x00000002,
                DCX_NORESETATTRS = 0x00000004,
                DCX_CLIPCHILDREN = 0x00000008,
                DCX_CLIPSIBLINGS = 0x00000010,
                DCX_PARENTCLIP = 0x00000020,
                DCX_EXCLUDERGN = 0x00000040,
                DCX_INTERSECTRGN = 0x00000080,
                DCX_EXCLUDEUPDATE = 0x00000100,  //?
                DCX_INTERSECTUPDATE = 0x00000200,  //?
                DCX_LOCKWINDOWUPDATE = 0x00000400,
                DCX_VALIDATE = 0x00200000;
        }

        /// <summary>
        /// GetWindow() Constants.
        /// </summary>
        public class GW
        {
            public const uint
                GW_HWNDFIRST = 0,
                GW_HWNDLAST = 1,
                GW_HWNDNEXT = 2,
                GW_HWNDPREV = 3,
                GW_OWNER = 4,
                GW_CHILD = 5,
                GW_ENABLEDPOPUP = 6;
        }

        /// <summary>
        /// GetAncestor() constants.
        /// </summary>
        public class GA
        {
            public const uint
                GA_PARENT = 1,
                GA_ROOT = 2,
                GA_ROOTOWNER = 3;
        }

        /// <summary>
        /// ExtTextOut() flags.
        /// </summary>
        public class ETO
        {
            public const uint
                ETO_OPAQUE = 0x2,
                ETO_CLIPPED = 0x4,
                ETO_GLYPH_INDEX = 0x10,
                ETO_RTLREADING = 0x80,
                ETO_NUMERICSLOCAL = 0x400,
                ETO_NUMERICSLATIN = 0x800,
                ETO_IGNORELANGUAGE = 0x1000,
                ETO_PDY = 0x2000;
        }

        /// <summary>
        /// SetBkMode modes.
        /// </summary>
        public class SetBkModeConsts
        {
            public const int
                OPAQUE = 0x2,
                TRANSPARENT = 0x1;
        }

        /// <summary>
        /// GetObjectType() returning values.
        /// </summary>
        public class OBJ
        {
            public const uint
                OBJ_PEN = 1,
                OBJ_BRUSH = 2,
                OBJ_DC = 3,
                OBJ_METADC = 4,
                OBJ_PAL = 5,
                OBJ_FONT = 6,
                OBJ_BITMAP = 7,
                OBJ_REGION = 8,
                OBJ_METAFILE = 9,
                OBJ_MEMDC = 10,
                OBJ_EXTPEN = 11,
                OBJ_ENHMETADC = 12,
                OBJ_ENHMETAFILE = 13;
        }

        /// <summary>
        /// TEXTMETRIC tmPitchAndFamily flags.
        /// </summary>
        public class TMPF
        {
            public const uint
                TMPF_FIXED_PITCH = 1,
                TMPF_VECTOR = 2,
                TMPF_DEVICE = 8,
                TMPF_TRUETYPE = 4;
        }

        /// <summary>
        /// Values for NETTEXMETRIC.ntmFlags.
        /// </summary>
        public class NTM
        {
            public const uint
                NTM_REGULAR = 0x00000040,
                NTM_BOLD = 0x00000020,
                NTM_ITALIC = 0x00000001,
                NTM_NONNEGATIVE_AC = 0x00010000,
                NTM_PS_OPENTYPE = 0x00020000,
                NTM_TT_OPENTYPE = 0x00040000,
                NTM_MULTIPLEMASTER = 0x00080000,
                NTM_TYPE1 = 0x00100000,
                NTM_DSIG = 0x00200000,
                
                NTM_OPENTYPE = NTM_PS_OPENTYPE | NTM_TT_OPENTYPE;
        }

        /// <summary>
        /// OLE constants.
        /// </summary>
        public class OLE
        {
            public const uint
                S_OK = 0x00000000,
                S_FALSE = 0x00000001,
                E_NOTIMPL = 0x80004001,
                E_POINTER = 0x80004003,
                E_OUTOFMEMORY = 0x8007000E,
                E_INVALIDARG = 0x80070057,
                E_UNEXPECTED = 0x8000FFFF;
        }

        /// <summary>
        /// CreateWindow() flags.
        /// </summary>
        public class WS
        {
            public const int
                WS_CAPTION = 0xC00000,
                WS_HSCROLL = 0x100000,
                WS_VSCROLL = 0x200000,
                WS_BORDER = 0x800000,
                WS_DLGFRAME = 0x400000,
                WS_THICKFRAME = 0x40000,
                WS_EX_CLIENTEDGE = 0x200,
                WS_TABSTOP = 0x10000,
                WS_EX_CONTROLPARENT = 0x10000,
                WS_EX_DLGMODALFRAME = 0x1,
                WS_GROUP = 0x20000,
                WS_CHILDWINDOW = 0x40000000,
                WS_VISIBLE = 0x10000000,
                WS_MAXIMIZE = 0x1000000,
                WS_POPUP = unchecked((int)0x80000000);
        }

        /// <summary>
        /// Extended Window Styles
        /// </summary>
        public class WS_EX
        {
            public const int
            WS_EX_DLGMODALFRAME = 0x00000001,
            WS_EX_NOPARENTNOTIFY = 0x00000004,
            WS_EX_TOPMOST = 0x00000008,
            WS_EX_ACCEPTFILES = 0x00000010,
            WS_EX_TRANSPARENT = 0x00000020,

            WS_EX_MDICHILD = 0x00000040,
            WS_EX_TOOLWINDOW = 0x00000080,
            WS_EX_WINDOWEDGE = 0x00000100,
            WS_EX_CLIENTEDGE = 0x00000200,
            WS_EX_CONTEXTHELP = 0x00000400,

            WS_EX_RIGHT = 0x00001000,
            WS_EX_LEFT = 0x00000000,
            WS_EX_RTLREADING = 0x00002000,
            WS_EX_LTRREADING = 0x00000000,
            WS_EX_LEFTSCROLLBAR = 0x00004000,
            WS_EX_RIGHTSCROLLBAR = 0x00000000,

            WS_EX_CONTROLPARENT = 0x00010000,
            WS_EX_STATICEDGE = 0x00020000,
            WS_EX_APPWINDOW = 0x00040000,


            WS_EX_OVERLAPPEDWINDOW = (WS_EX_WINDOWEDGE | WS_EX_CLIENTEDGE),
            WS_EX_PALETTEWINDOW = (WS_EX_WINDOWEDGE | WS_EX_TOOLWINDOW | WS_EX_TOPMOST),

            WS_EX_LAYERED = 0x00080000,

            WS_EX_NOINHERITLAYOUT = 0x00100000, // Disable inheritence of mirroring by children
            WS_EX_LAYOUTRTL = 0x00400000, // Right to left mirroring

            WS_EX_COMPOSITED = 0x02000000,

            WS_EX_NOACTIVATE = 0x08000000;
        }


        /// <summary>
        /// CreateWindow() flags for edit controls.
        /// </summary>
        public class ES
        {
            public const int
                ES_NOHIDESEL = 0x100,
                ES_AUTOVSCROLL = 0x40,
                ES_MULTILINE = 0x4,
                ES_SAVESEL = 0x00008000;
        }

        /// <summary>
        /// DrawFrameControl(), type of frame control to draw.
        /// </summary>
        public class DFC
        {
            public const uint
                DFC_CAPTION = 0x0001,
                DFC_MENU = 0x0002,
                DFC_SCROLL = 0x0003,
                DFC_BUTTON = 0x0004,
                DFC_POPUPMENU = 0x0005;
        }

        /// <summary>
        /// DrawFrameControl(), state of control.
        /// </summary>
        public class DFCS
        {
            public const uint
                DFCS_CAPTIONCLOSE = 0x0006,
                DFCS_CAPTIONMIN = 0x0001,
                DFCS_CAPTIONMAX = 0x0002,
                DFCS_CAPTIONRESTORE = 0x0003,
                DFCS_CAPTIONHELP = 0x0004,

                DFCS_MENUARROW = 0x0000,
                DFCS_MENUCHECK = 0x0001,
                DFCS_MENUBULLET = 0x0002,
                DFCS_MENUARROWRIGHT = 0x0004,

                DFCS_SCROLLUP = 0x0000,
                DFCS_SCROLLDOWN = 0x0001,
                DFCS_SCROLLLEFT = 0x0002,
                DFCS_SCROLLRIGHT = 0x0003,
                DFCS_SCROLLCOMBOBOX = 0x0005,
                DFCS_SCROLLSIZEGRIP = 0x0008,
                DFCS_SCROLLSIZEGRIPRIGHT = 0x0010,

                DFCS_BUTTONCHECK = 0x0000,
                DFCS_BUTTONRADIOIMAGE = 0x0001,
                DFCS_BUTTONRADIOMASK = 0x0002,
                DFCS_BUTTONRADIO = 0x0004,
                DFCS_BUTTON3STATE = 0x0008,
                DFCS_BUTTONPUSH = 0x0010,

                DFCS_INACTIVE = 0x0100,
                DFCS_PUSHED = 0x0200,
                DFCS_CHECKED = 0x0400,
                DFCS_TRANSPARENT = 0x0800,
                DFCS_HOT = 0x1000,
                DFCS_ADJUSTRECT = 0x2000,
                DFCS_FLAT = 0x4000,
                DFCS_MONO = 0x8000;
        }

        /// <summary>
        /// CreatePen() flags
        /// </summary>
        public class PS
        {
            public const int
                PS_SOLID = 0,
                PS_DASH = 1,
                PS_DOT = 2,
                PS_DASHDOT = 3,
                PS_DASHDOTDOT = 4,
                PS_NULL = 5,
                PS_INSIDEFRAME = 6,
                PS_USERSTYLE = 7,

                PS_COSMETIC = 0,
                PS_GEOMETRIC = 0x10000,

                PS_ENDCAP_ROUND = 0,
                PS_ENDCAP_SQUARE = 0x100,
                PS_ENDCAP_FLAT = 0x200,

                PS_JOIN_ROUND = 0,
                PS_JOIN_BEVEL = 0x1000,
                PS_JOIN_MITER = 0x2000;
        }

        /// <summary>
        /// SetWindowLong() flags.
        /// </summary>
        public class GWL
        {
            public const int
                GWL_WNDPROC = -4,
                GWL_HINSTANCE = -6,
                GWL_HWNDPARENT = -8,
                GWL_STYLE = -16,
                GWL_EXSTYLE = -20,
                GWL_USERDATA = -21,
                GWL_ID = -12;
        }

        /// <summary>
        /// GetGuiResources() flags.
        /// </summary>
        public class GR
        {
            public const int
                GR_GDIOBJECTS = 0,
                GR_USEROBJECTS = 1;
        }

        /// <summary>
        /// ExtSelectClipRgn() flags.
        /// </summary>
        public class RGN
        {
            public const int
                RGN_AND = 1,
                RGN_OR = 2,
                RGN_XOR = 3,
                RGN_DIFF = 4,
                RGN_COPY = 5,
                RGN_MIN = RGN_AND,
                RGN_MAX = RGN_COPY;
        }

        /// <summary>
        /// ScrollWindowEx flags
        /// </summary>
        public class ScrollWindowFlags
        {
            public const int
                SW_SCROLLCHILDREN = 0x0001, // Scroll children within *lprcScroll
                SW_INVALIDATE = 0x0002, // Invalidate after scrolling
                SW_ERASE = 0x0004, // If SW_INVALIDATE, don't send WM_ERASEBACKGROUND
                SW_SMOOTHSCROLL = 0x0010;  // Use smooth scrolling
        }

        /// <summary>
        /// WM_MOUSEACTIVATE Return Codes
        /// </summary>
        public class MA
        {
            public const int
                MA_ACTIVATE = 1,
                MA_ACTIVATEANDEAT = 2,
                MA_NOACTIVATE = 3,
                MA_NOACTIVATEANDEAT = 4;
        }

        /// <summary>
        /// Constants for SetROP2
        /// </summary>
        public class RasterOp
        {
            public const int
                R2_BLACK = 1,
                R2_NOTMERGEPEN = 2,
                R2_MASKNOTPEN = 3,
                R2_NOTCOPYPEN = 4,
                R2_MASKPENNOT = 5,
                R2_NOT = 6,
                R2_XORPEN = 7,
                R2_NOTMASKPEN = 8,
                R2_MASKPEN = 9,
                R2_NOTXORPEN = 10,
                R2_NOP = 11,
                R2_MERGENOTPEN = 12,
                R2_COPYPEN = 13,
                R2_MERGEPENNOT = 14,
                R2_MERGEPEN = 15,
                R2_WHITE = 16,
                R2_LAST = 16;
        }

        public class BDR
        {
            public const int
                BDR_RAISEDOUTER = 1,
                BDR_SUNKENOUTER = 2,
                BDR_RAISEDINNER = 4,
                BDR_SUNKENINNER = 8,
                BDR_OUTER = 3,
                BDR_INNER = 12,
                BDR_RAISED = 5,
                BDR_SUNKEN = 10;
        }

        public class EDGE
        {
            public const int
                EDGE_RAISED = BDR.BDR_RAISED,
                EDGE_SUNKEN = BDR.BDR_SUNKEN,
                EDGE_ETCHED = BDR.BDR_OUTER,
                EDGE_BUMP = BDR.BDR_INNER;
        }

        public class BF
        {
            public const int
                BF_LEFT = 1,
                BF_TOP = 2,
                BF_RIGHT = 4,
                BF_BOTTOM = 8,

                BF_TOPLEFT = BF_TOP | BF_LEFT,
                BF_TOPRIGHT = BF_TOP | BF_RIGHT,
                BF_BOTTOMLEFT = BF_BOTTOM | BF_LEFT,
                BF_BOTTOMRIGHT = BF_BOTTOM | BF_RIGHT,
                BF_RECT = BF_LEFT | BF_TOP | BF_RIGHT | BF_BOTTOM,

                BF_DIAGONAL = 0x10,

                BF_DIAGONAL_ENDTOPRIGHT = BF_DIAGONAL | BF_TOP | BF_RIGHT,
                BF_DIAGONAL_ENDTOPLEFT = BF_DIAGONAL | BF_TOP | BF_LEFT,
                BF_DIAGONAL_ENDBOTTOMLEFT = BF_DIAGONAL | BF_BOTTOM | BF_LEFT,
                BF_DIAGONAL_ENDBOTTOMRIGHT = BF_DIAGONAL | BF_BOTTOM | BF_RIGHT,

                BF_MIDDLE = 0x800,
                BF_SOFT = 0x1000,
                BF_ADJUST = 0x2000,
                BF_FLAT = 0x4000,
                BF_MONO = 0x8000;
        }

        /// <summary>
        /// Defines ASSOCF values for AssocQueryString method's first parameter (flags).
        /// </summary>
        public class ASSOCF
        {
            public const int
               ASSOCF_INIT_NOREMAPCLSID = 0x00000001,
               ASSOCF_INIT_BYEXENAME = 0x00000002,
               ASSOCF_OPEN_BYEXENAME = 0x00000002,
               ASSOCF_INIT_DEFAULTTOSTAR = 0x00000004,
               ASSOCF_INIT_DEFAULTTOFOLDER = 0x00000008,
               ASSOCF_NOUSERSETTINGS = 0x00000010,
               ASSOCF_NOTRUNCATE = 0x00000020,
               ASSOCF_VERIFY = 0x00000040,
               ASSOCF_REMAPRUNDLL = 0x00000080,
               ASSOCF_NOFIXUPS = 0x00000100,
               ASSOCF_IGNOREBASECLASS = 0x00000200,
               ASSOCF_INIT_IGNOREUNKNOWN = 0x00000400;
        }

        /// <summary>
        /// Defines ASSOCSTR values for AssocQueryString method's second parameter (str).
        /// </summary>
        public class ASSOCSTR
        {
            public const int
                ASSOCSTR_COMMAND = 1,
                ASSOCSTR_EXECUTABLE = 2,
                ASSOCSTR_FRIENDLYDOCNAME = 3,
                ASSOCSTR_FRIENDLYAPPNAME = 4,
                ASSOCSTR_NOOPEN = 5,
                ASSOCSTR_SHELLNEWVALUE = 6,
                ASSOCSTR_DDECOMMAND = 7,
                ASSOCSTR_DDEIFEXEC = 8,
                ASSOCSTR_DDEAPPLICATION = 9,
                ASSOCSTR_DDETOPIC = 10,
                ASSOCSTR_INFOTIP = 11,
                ASSOCSTR_QUICKTIP = 12,
                ASSOCSTR_TILEINFO = 13,
                ASSOCSTR_CONTENTTYPE = 14,
                ASSOCSTR_DEFAULTICON = 15,
                ASSOCSTR_SHELLEXTENSION = 16;
        }
        #endregion // Constants

        #region DWM API
        [DllImport("dwmapi.dll", ExactSpelling = true, PreserveSig = false)]
        internal static extern bool DwmIsCompositionEnabled();
        #endregion

        #region Windows API functions
        [DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
        public static extern int LCMapStringA(int Locale, int dwMapFlags, [MarshalAs(UnmanagedType.LPArray)] byte[] lpSrcStr, int cchSrc, [MarshalAs(UnmanagedType.LPArray)] byte[] lpDestStr, int cchDest);

        [DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int LCMapString(int Locale, int dwMapFlags, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpSrcStr, int cchSrc, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpDestStr, int cchDest);

        [DllImport("ntdll.dll", CharSet = CharSet.Auto)]
        public static extern int RtlGetVersion(ref OSVERSIONINFOEX osVersion);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern bool TrackMouseEvent(
            ref TRACKMOUSEEVENT lpEventTrack);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern bool SetLayeredWindowAttributes(
            IntPtr hwnd,
            int crKey,
            byte bAlpha,
            int dwFlags);

        [DllImport("User32.DLL")]
        public static extern bool GetComboBoxInfo(
            IntPtr hwndCombo,
            ref COMBOBOXINFO pcbi);

        [DllImport("Gdi32.DLL")]
        public static extern IntPtr GetStockObject(
            int fnObject);

        [DllImport("gdi32.dll", ExactSpelling = true, PreserveSig = true, SetLastError = true)]
        public static extern IntPtr ExtCreatePen(
            int dwPenStyle,
            int dwWidth,
            ref LOGBRUSH lplb,
            int dwStyleCount,
            int[] lpStyle);

        [DllImport("gdi32.dll", ExactSpelling = true, PreserveSig = true, SetLastError = true)]
        public static extern IntPtr ExtCreatePen(
            int dwPenStyle,
            int dwWidth,
            ref LOGBRUSH lplb,
            int dwStyleCount,
            IntPtr lpStyle);

        [DllImport("gdi32.dll")]
        public static extern bool StrokePath(
            IntPtr hdc);

        [DllImport("gdi32.dll", CharSet = CharSet.Auto)]
        public static extern int GetGlyphOutline(
            IntPtr hdc,
            char uChar,
            uint uFormat,
            ref GLYPHMETRICS lpgm,
            int cbBuffer,
            IntPtr lpvBuffer,
            IntPtr lpmat2);

        [DllImport("gdi32.dll", CharSet = CharSet.Auto)]
        public static extern int GetTextFace(
            IntPtr hdc,
            int nCount,
            [Out] StringBuilder lpFaceName);

        [DllImport("gdi32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr PathToRegion(
            IntPtr hdc);

        [DllImport("gdi32.dll")]
        static extern bool AngleArc(
            IntPtr hdc,
            int X,
            int Y,
            uint dwRadius,
            float eStartAngle,
            float eSweepAngle);

        [DllImport("gdi32.dll", CharSet = CharSet.Auto)]
        public static extern bool Arc(
            IntPtr hdc,         // handle to device context
            int nLeftRect,      // x-coord of rectangle's upper-left corner
            int nTopRect,       // y-coord of rectangle's upper-left corner
            int nRightRect,     // x-coord of rectangle's lower-right corner
            int nBottomRect,    // y-coord of rectangle's lower-right corner
            int nXStartArc,     // x-coord of first radial ending point
            int nYStartArc,     // y-coord of first radial ending point
            int nXEndArc,       // x-coord of second radial ending point
            int nYEndArc);      // y-coord of second radial ending point

        [DllImport("gdi32.dll", CharSet = CharSet.Auto)]
        public static extern bool ArcTo(
            IntPtr hdc,         // handle to device context
            int nLeftRect,      // x-coord of rectangle's upper-left corner
            int nTopRect,       // y-coord of rectangle's upper-left corner
            int nRightRect,     // x-coord of rectangle's lower-right corner
            int nBottomRect,    // y-coord of rectangle's lower-right corner
            int nXStartArc,     // x-coord of first radial ending point
            int nYStartArc,     // y-coord of first radial ending point
            int nXEndArc,       // x-coord of second radial ending point
            int nYEndArc);      // y-coord of second radial ending point

        [DllImport("gdi32.dll", CharSet = CharSet.Auto)]
        public static extern bool BeginPath(
            IntPtr hdc);

        [DllImport("gdi32.dll", CharSet = CharSet.Auto)]
        public static extern bool EndPath(
            IntPtr hdc);

        [DllImport("gdi32.dll", CharSet = CharSet.Auto)]
        public static extern bool CloseFigure(
            IntPtr hdc);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int GetWindowLong(
            IntPtr hWnd,
            int nIndex);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr FindFirstFile(
            string fileName,
            [In, Out] WIN32_FIND_DATA data);

        [DllImport("kernel32.dll")]
        public static extern bool FindClose(
            IntPtr handle);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool FindNextFile(
            IntPtr hndFindFile,
            [In, Out, MarshalAs(UnmanagedType.LPStruct)] WIN32_FIND_DATA lpFindFileData);

        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern int FrameRect(
            IntPtr hdc,
            ref RECT lprc,
            IntPtr hbr);

        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern int GetMenuString(IntPtr hMenu,      // handle to the menu
            UInt32 uIDItem,   // menu item identifier
            StringBuilder lpString,  // buffer for the string
            int nMaxCount,    // maximum length of string
            UInt32 uFlag);      // options

        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern bool AnimateWindow(
            IntPtr hWnd,       // handle to window
            int dwTime,        // Specifies how long it takes to play the animation
            uint dwFlags);        // Specifies the type of animation

        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr GetKeyboardLayout(
            IntPtr idThread);

        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern int ToUnicodeEx(
            uint wVirtKey,          // virtual-key code
            uint wScanCode,         // scan code
            byte[] lpKeyState,      // key-state array
            StringBuilder pwszBuff, // translated key buffer
            int cchBuff,            // size of translated key buffer
            uint wFlags,            // function options
            IntPtr dwhkl);            // input locale identifier

        [DllImport("User32.dll")]
        public static extern IntPtr LoadBitmap(
            IntPtr hInstance,  // handle to application instance
            IntPtr lpBitmapName);  // name of bitmap resource

        [DllImport("User32.dll")]
        public static extern Int32 GetKeyState(
            Int32 nVirtKey);

        [DllImport("User32.dll")]
        public static extern IntPtr CreateMenu();

        [DllImport("User32.dll")]
        public static extern bool SetMenu(
            IntPtr hWnd,
            IntPtr hMenu);

        [DllImport("User32.dll")]
        public static extern bool DrawMenuBar(
            IntPtr hWnd);

        [DllImport("User32.dll")]
        public static extern IntPtr GetMenu(
            IntPtr hWnd);

        [DllImport("User32.dll")]
        public static extern IntPtr DestroyMenu(
            IntPtr hMenu);

        [DllImport("User32.dll")]
        public static extern IntPtr GetSystemMenu(
            IntPtr hWnd,
            bool bRevert);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int DrawEdge(
            IntPtr hdc,
            ref RECT qrc,
            uint edge,
            uint qrfFlags);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int GetSysColor(
            int nIndex);

#if WIN32_INCLUDE_UNSAFE
        [DllImport("gdi32.dll", CharSet = CharSet.Auto)]
        public unsafe static extern IntPtr ExtCreateRegion(
            IntPtr lpXForm,
            int nCount,
            byte* lpRgnData);
#endif

        [DllImport("gdi32.dll", CharSet = CharSet.Auto)]
        public static extern bool FrameRgn(
            IntPtr hdc,
            IntPtr hrgn,
            IntPtr hbrush,
            int nWidth,
            int nHeight);

        [DllImport("gdi32.dll", CharSet = CharSet.Auto)]
        public static extern int CombineRgn(
            IntPtr hrgnDest,
            IntPtr hrgnSrc1,
            IntPtr hrgnSrc2,
            int fnCombineMode);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        public static extern ushort FindAtom(string lpString);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        public static extern int GetCurrentProcessId();

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int GetGuiResources(
            IntPtr hProcess,
            int uiFlags);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr GetCurrentProcess();

        [DllImport("gdi32.dll", CharSet = CharSet.Auto)]
        public static extern int SaveDC(
            IntPtr hdc);

        [DllImport("gdi32.dll", CharSet = CharSet.Auto)]
        public static extern bool RestoreDC(
            IntPtr hdc,
            int nSavedDC);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern bool ShowWindow(
            IntPtr hwnd,
            int nCmdShow);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern bool SetWindowPos(
            IntPtr hWnd,
            IntPtr hWndInsertAfter,
            int x,
            int y,
            int cx,
            int cy,
            uint uFlags);

        [DllImport("gdi32.dll", CharSet = CharSet.Auto)]
        public static extern int IntersectClipRect(
            IntPtr hdc,
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect);

        [DllImport("gdi32.dll", CharSet = CharSet.Auto)]
        public static extern int GetClipRgn(IntPtr hdc, IntPtr hrgn);

        [DllImport("gdi32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr CreateRectRgnIndirect(ref RECT lprc);

        [DllImport("gdi32.dll", CharSet = CharSet.Auto, EntryPoint = "CreateRectRgnIndirect")]
        public static extern IntPtr CreateRectRgnIndirect2(RECT lprc);

        [DllImport("gdi32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr CreatePen(
            int fnPenStyle,
            int nWidth,
            int crColor);

        [DllImport("gdi32.dll", CharSet = CharSet.Auto)]
        public static extern bool Polygon(
            IntPtr hdc,
            POINT[] lpPoints,
            int nCount);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern bool DrawFocusRect(
            IntPtr hdc,
            ref RECT lpRect);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern bool DrawFrameControl(
            IntPtr hdc,
            ref RECT lpRect,
            uint uType,
            uint uState);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr LoadLibrary(
            string fileName);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        public static extern bool FreeLibrary(
            IntPtr dllHandle);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr CreateWindow(
            string className,
            string windowName,
            uint dwStyle,
            int x,
            int y,
            int nWidth,
            int nHeight,
            IntPtr hWndParent,
            IntPtr hMenu,
            IntPtr hInstance,
            IntPtr param);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr CreateWindowEx(
            uint dwExStyle,
            string className,
            string windowName,
            uint dwStyle,
            int x,
            int y,
            int nWidth,
            int nHeight,
            IntPtr hWndParent,
            IntPtr hMenu,
            IntPtr hInstance,
            IntPtr param);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern bool DestroyWindow(
            IntPtr hWnd);

        [DllImport("gdi32.dll")]
        public static extern bool Ellipse(
            IntPtr hdc,
            int ulCornerX, int ulCornerY,
            int lrCornerX, int lrCornerY);

        [DllImport("gdi32.dll")]
        public static extern bool Rectangle(
            IntPtr hdc,
            int ulCornerX, int ulCornerY,
            int lrCornerX, int lrCornerY);

        [DllImport("gdi32.dll")]
        public static extern bool PlayEnhMetaFile(
            IntPtr hdc, // handle to DC
            IntPtr hemf, // handle to an enhanced metafile
            ref RECT lpRect); // bounding rectangle

        [DllImport("gdi32.dll")]
        public static extern bool EnumEnhMetaFile(
            IntPtr hdc, // handle to DC
            IntPtr hemf, // handle to enhanced metafile
            Win32.EnumMetaFileProc lpEnhMetaFunc, // callback function
            IntPtr lpData, // callback-function data
            ref RECT lpRect); // bounding rectangle

        [DllImport("gdi32.dll")]
        public static extern bool PlayEnhMetaFileRecord(
            IntPtr hdc, // handle to DC
            IntPtr lpHandletable, // metafile handle table
            IntPtr lpEnhMetaRecord, // metafile record
            int nHandles); // count of handles

        [DllImport("gdi32.dll")]
        public static extern int SetTextColor(
            IntPtr hdc, // handle to DC
            int crColor); // text color

        [DllImport("gdi32.dll")]
        public static extern bool BitBlt(
            IntPtr hdcDest, // handle to destination DC
            int nXDest, // x-coord of destination upper-left corner
            int nYDest, // y-coord of destination upper-left corner
            int nWidth, // width of destination rectangle
            int nHeight, // height of destination rectangle
            IntPtr hdcSrc, // handle to source DC
            int nXSrc, // x-coordinate of source upper-left corner
            int nYSrc, // y-coordinate of source upper-left corner
            uint dwRop); // raster operation code

        [DllImport("user32.dll")]
        public static extern bool InvertRect(
            IntPtr hdc,
            ref RECT lprc);

        [DllImport("gdi32.dll")]
        public static extern bool InvertRgn(
            IntPtr hdc,    // handle to device context
            IntPtr hrgn);  // handle to region to be inverted

        [DllImport("gdi32.dll")]
        public static extern bool StretchBlt(
            IntPtr hdcDest, // handle to destination DC
            int nXOriginDest, // x-coord of destination upper-left corner
            int nYOriginDest, // y-coord of destination upper-left corner
            int nWidthDest, // width of destination rectangle
            int nHeightDest, // height of destination rectangle
            IntPtr hdcSrc, // handle to source DC
            int nXOriginSrc, // x-coord of source upper-left corner
            int nYOriginSrc, // y-coord of source upper-left corner
            int nWidthSrc, // width of source rectangle
            int nHeightSrc, // height of source rectangle
            uint dwRop); // raster operation code

        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int GetLocaleInfoEx(
            string lpLocaleName,
            uint LCType,
            StringBuilder lpLCData,
            int cchData);

#if WIN32_INCLUDE_UNSAFE
        [DllImport("Kernel32.dll", CharSet = CharSet.Auto, EntryPoint = "GetLocaleInfo")]
        public unsafe static extern int GetLocaleInfoUnsafe(
            uint Locale, // locale identifier
            uint LCType, // information type
            char* lpLCData, // information buffer
            int cchData); // size of buffer
#endif

        [DllImport("User32.dll")]
        public static extern Int32 SendMessage(
            IntPtr hWnd,    // handle to destination window
            int Msg,        // message
            int wParam,     // first message parameter
            int lParam);      // second message parameter

        [DllImport("USER32.DLL", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(
            IntPtr hWnd,
            uint wMsg,
            IntPtr wParam,
            IntPtr lParam);

        [DllImport("USER32.DLL", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(
            IntPtr hWnd,
            uint wMsg,
            IntPtr wParam,
            ref LVITEM lParam);

        [DllImport("USER32.DLL", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(
            IntPtr hWnd,
            uint wMsg,
            IntPtr wParam,
            EDITSTREAM lParam);

        [DllImport("USER32.DLL", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(
            IntPtr hWnd,
            uint wMsg,
            IntPtr wParam,
            EDITSTREAM64 lParam);

        [DllImport("USER32.DLL", CharSet = CharSet.Auto)]
        public static extern IntPtr PostMessage(
            IntPtr hWnd,
            uint wMsg,
            IntPtr wParam,
            IntPtr lParam);

        [DllImport("Gdi32.DLL", CharSet = CharSet.Auto)]
        public static extern bool DPtoLP(
            IntPtr hdc, // handle to device context
            ref POINTL lpPoints, // array of points
            int nCount); // count of points in array

        [DllImport("Gdi32.DLL", CharSet = CharSet.Auto)]
        public static extern uint GetTextAlign(
            IntPtr hdc); // handle to DC

        [DllImport("Gdi32.DLL", CharSet = CharSet.Auto)]
        public static extern uint SetTextAlign(
            IntPtr hdc, // handle to DC
            uint fMode); // text-alignment option

        [DllImport("gdi32.dll")]
        public static extern uint GetObjectType(
            IntPtr h); // handle to graphics object

        [DllImport("user32.dll")]
        public static extern IntPtr GetDCEx(
            IntPtr hWnd, // handle to window
            IntPtr hrgnClip, // handle to clipping region
            uint flags); // creation options

        [DllImport("gdi32.dll")]
        public static extern IntPtr CreateRectRgn(
            int nLeftRect, // x-coordinate of upper-left corner
            int nTopRect, // y-coordinate of upper-left corner
            int nRightRect, // x-coordinate of lower-right corner
            int nBottomRect); // y-coordinate of lower-right corner

        [DllImport("user32.dll")]
        public static extern bool LockWindowUpdate(
            IntPtr hWndLock); // handle to window

        [DllImport("gdi32.dll")]
        public static extern bool MoveToEx(
            IntPtr hdc,
            int x,
            int y,
            ref POINT lpPoint);

        [DllImport("gdi32.dll")]
        public static extern bool LineTo(
            IntPtr hdc,
            int x,
            int y);

        [DllImport("gdi32.dll")]
        public static extern int ExcludeClipRect(
            IntPtr hdc, // handle to DC
            int nLeftRect, // x-coord of upper-left corner
            int nTopRect, // y-coord of upper-left corner
            int nRightRect, // x-coord of lower-right corner
            int nBottomRect); // y-coord of lower-right corner

        [DllImport("gdi32.dll")]
        public static extern int ExtSelectClipRgn(
            IntPtr hdc, // handle to DC
            IntPtr hrgn, // handle to region
            int fnMode); // region-selection mode

        [DllImport("gdi32.dll")]
        public static extern int SelectClipRgn(
            IntPtr hdc, // handle to DC
            IntPtr hrgn); // handle to region

        [DllImport("user32.dll")]
        public static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        public static extern int SetForegroundWindow(
            IntPtr hWnd);

        [DllImport("user32.dll")]
        public static extern IntPtr GetWindowThreadProcessId(
            IntPtr hWnd,
            ref int lpdwProcessId);

        [DllImport("user32.dll")]
        public static extern IntPtr WindowFromPoint(Point p);

        [DllImport("user32.dll")]
        public static extern IntPtr WindowFromPoint(POINT p);

        [DllImport("user32.dll")]
        public static extern IntPtr GetWindow(
            IntPtr hWnd, // handle to original window
            uint uCmd); // relationship

        [DllImport("user32.dll")]
        public static extern bool GetWindowRect(
            IntPtr hWnd, // handle to window
            ref RECT lpRect); // window coordinates

        [DllImport("user32.dll")]
        public static extern bool GetClientRect(
            IntPtr hWnd, // handle to window
            ref RECT lpRect); // client coordinates

        [DllImport("user32.dll")]
        public static extern IntPtr GetParent(
            IntPtr hWnd); // handle to child window

        [DllImport("user32.dll")]
        public static extern IntPtr GetAncestor(
            IntPtr hwnd, // handle to window
            uint gaFlags); // ancestor

        [DllImport("user32.dll")]
        public static extern IntPtr GetActiveWindow();

        [DllImport("user32.dll")]
        public static extern IntPtr GetFocus();

        [DllImport("user32.dll")]
        public static extern IntPtr SetParent(
            IntPtr hWndChild, // handle to window
            IntPtr hWndNewParent); // new parent window

        [DllImport("user32.dll")]
        public static extern bool ClientToScreen(
            IntPtr hWnd, // handle to window
            ref POINT lpPoint); // screen coordinates

        [DllImport("user32.dll")]
        public static extern bool ScreenToClient(
            IntPtr hWnd, // handle to window
            ref POINT lpPoint); // screen coordinates

        [DllImport("user32.dll")]
        public static extern bool IsWindowVisible(
            IntPtr hWnd); // handle to window

        [DllImport("user32.dll")]
        public static extern IntPtr GetDesktopWindow();

        [DllImport("shell32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr ShellExecute(
            IntPtr hwnd,
            string lpOperation,
            string lpFile,
            string lpParameters,
            string lpDirectory,
            int nShowCmd);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern bool SetWindowText(IntPtr hWnd, string text);

        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern bool DrawText(
            IntPtr dc,
            string s,
            int nCount,
            ref RECT lpRect,
            uint uFormat);

#if WIN32_INCLUDE_UNSAFE
        [DllImport("Gdi32.DLL", CharSet = CharSet.Auto)]
        public unsafe static extern bool ExtTextOut(
            IntPtr hdc,
            int X,
            int Y,
            uint fuOptions,
            RECT* lprc,
            string lpString,
            int cbCount,
            int* lpDX);
#endif

        [DllImport("Gdi32.DLL", CharSet = CharSet.Auto)]
        public static extern bool ExtTextOut(
            IntPtr hdc,
            int X,
            int Y,
            uint fuOptions,
            ref RECT lprc,
            string lpString,
            int cbCount,
            IntPtr lpDX);

        [DllImport("Gdi32.DLL", CharSet = CharSet.Auto)]
        public static extern bool TextOut(
            IntPtr hdc,
            int X,
            int Y,
            string lpString,
            int cbCount);

        [DllImport("Gdi32.DLL", CharSet = CharSet.Auto)]
        public static extern bool GetTextExtentPoint32(
            IntPtr hdc,
            string lpString,
            int cbString,
            ref Size lpSize);

        [DllImport("Gdi32.DLL", CharSet = CharSet.Auto)]
        public static extern bool GdiComment(
            IntPtr hdc,
            uint cbSize,
            IntPtr lpData);

        [DllImport("Gdi32.DLL", CharSet = CharSet.Auto)]
        public static extern bool GdiComment(
            IntPtr hdc,
            uint cbSize,
            byte[] data);

        [DllImport("gdi32.dll")]
        public static extern int GetTextColor(
            IntPtr hdc); // handle to DC

        [DllImport("gdi32.dll")]
        public static extern int SetBkColor(
            IntPtr hdc, // handle to DC
            int crColor); // text color

        [DllImport("gdi32.dll")]
        public static extern int GetBkColor(
            IntPtr hdc           // handle to DC
            );

        [DllImport("user32.DLL", CharSet = CharSet.Auto)]
        public static extern int FillRect(IntPtr hDC,
            ref RECT rc,
            IntPtr hbr);

        [DllImport("Gdi32.DLL", CharSet = CharSet.Auto)]
        public static extern IntPtr CreateSolidBrush(
            int crColor);

        [DllImport("Gdi32.DLL", CharSet = CharSet.Auto)]
        public static extern int GetObject(
            IntPtr hgdiobj,
            int cbBuffer,
            IntPtr lpvObject);

        [DllImport("Gdi32.DLL", CharSet = CharSet.Auto)]
        public static extern int GetObject(
            IntPtr hgdiobj,
            int cbBuffer,
            [In, Out] LOGFONT lpvObject);

        [DllImport("Gdi32.DLL", CharSet = CharSet.Auto)]
        public static extern int GetObject(
            IntPtr hgdiobj,
            int cbBuffer,
            ref LOGFONT_UNMANAGED lplf);

        [DllImport("Gdi32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr CreateFontIndirect(
            ref LOGFONT_UNMANAGED lplf);

        [DllImport("Gdi32.DLL", CharSet = CharSet.Auto)]
        public static extern bool PtInRegion(
            IntPtr hrgn,
            int x,
            int y);

        [DllImport("Gdi32.DLL", CharSet = CharSet.Auto)]
        public static extern int GetBkMode(
            IntPtr hdc);

        [DllImport("Gdi32.DLL", CharSet = CharSet.Auto)]
        public static extern int SetBkMode(
            IntPtr hdc,
            int ibkMode);

        [DllImport("Gdi32.DLL", CharSet = CharSet.Auto)]
        public static extern IntPtr GetCurrentObject(
            IntPtr hdc,
            uint uObjectType);

        [DllImport("USER32.DLL", CharSet = CharSet.Auto, EntryPoint = "SendMessage")]
        public static extern IntPtr SendMessageFormatRange(
            IntPtr hWnd,
            uint wMsg,
            IntPtr wParam,
            ref FORMATRANGE lParam);

        [DllImport("USER32.DLL", CharSet = CharSet.Auto, EntryPoint = "SendMessage")]
        public static extern IntPtr SendMessageSetCharFormat(
            IntPtr hWnd,
            uint wMsg,
            uint wParam,
            ref CHARFORMAT lParam);

        [DllImport("USER32.DLL", CharSet = CharSet.Auto, EntryPoint = "SendMessage")]
        public static extern IntPtr SendMessageSetParaFormat(
            IntPtr hWnd,
            uint wMsg,
            uint wParam,
            ref PARAFORMAT lParam);

        [DllImport("USER32.DLL", CharSet = CharSet.Auto, EntryPoint = "SendMessage")]
        public static extern IntPtr SendMessageSetParaFormat2(
            IntPtr hWnd,
            uint wMsg,
            uint wParam,
            ref PARAFORMAT2 lParam);

        [DllImport("USER32.DLL", CharSet = CharSet.Auto, EntryPoint = "SendMessage")]
        public static extern IntPtr SendMessageSetCharFormat2(
            IntPtr hWnd,
            uint wMsg,
            uint wParam,
            ref CHARFORMAT2 lParam);

        [DllImport("user32.DLL", CharSet = CharSet.Auto)]
        public static extern IntPtr GetDC(
            IntPtr hWnd);

        [DllImport("user32.DLL", CharSet = CharSet.Auto)]
        public static extern int ReleaseDC(
            IntPtr hWnd,
            IntPtr hDC);

        [DllImport("Gdi32.dll", CharSet = CharSet.Auto)]
        public static extern bool GetTextMetrics(
            IntPtr hdc,
            ref TEXTMETRIC tm);

#if WIN32_INCLUDE_UNSAFE
        [DllImport("gdi32.DLL", CharSet = CharSet.Auto)]
        public unsafe static extern uint GetOutlineTextMetrics(
            IntPtr hdc,
            int cbData,
            OUTLINETEXTMETRIC* lpOTM);

        [DllImport("Gdi32.DLL", CharSet = CharSet.Auto)]
        public unsafe static extern bool GetTextExtentExPoint(
            IntPtr hdc,
            string lpszStr,
            int cchString,
            int nMaxExtent,
            int* lpnFit,
            int* alpDX,
            ref Size lpSize);
#endif

        [DllImport("gdi32.DLL", CharSet = CharSet.Auto)]
        public static extern uint GetOutlineTextMetrics(
            IntPtr hdc,
            uint cbData,
            ref OUTLINETEXTMETRIC lpOTM);

        [DllImport("Urlmon.dll", CharSet = CharSet.Auto)]
        public static extern int IsValidURL(
            IntPtr pBC, // should be IntPtr.Zero
            string szURL, // string to test
            uint dwReserved); // should be IntPtr.Zero

        [DllImport("gdi32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr CopyEnhMetaFile(
            IntPtr hemfSrc,
            string file);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SetWindowLong(
            IntPtr hwnd,
            int nIndex,
            int dwNewLong);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SetWindowLong(
            IntPtr hwnd,
            int nIndex,
            IntPtr dwNewLong);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SetWindowLong(
            IntPtr hwnd,
            int nIndex,
            Win32.WindowProc newWindowProc);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SetWindowRgn(
            IntPtr hwnd,
            IntPtr hrgn,
            bool bRedraw);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int CallWindowProc(
            IntPtr lpPrevWndFunc,
            IntPtr hwnd,
            uint uMsg,
            IntPtr wParam,
            IntPtr lParam);

        [DllImport("ole32.dll", CharSet = CharSet.Auto)]
        public static extern int CreateILockBytesOnHGlobal(
            IntPtr hGlobal,
            bool fDeleteOnRelease,
            ref IntPtr ppLkbyt);

        [DllImport("ole32.dll", CharSet = CharSet.Auto)]
        public static extern int StgCreateDocfileOnILockBytes(
            IntPtr plkbyt,
            uint grfMode,
            uint reserved,
            ref IntPtr ppstgOpen);

        [DllImport("shell32.dll", CharSet = CharSet.Auto)]
        public static extern void DragAcceptFiles(
            IntPtr hWnd,
            bool fAccept);

        [DllImport("User32.dll")]
        public static extern int ScrollWindowEx(
            IntPtr hWnd,            // handle to window
            int dx,                 // horizontal scrolling
            int dy,                 // vertical scrolling
            ref RECT prcScroll,         // client area
            ref RECT prcClip,           // clipping rectangle
            IntPtr hrgnUpdate,      // handle to update region
            ref RECT prcUpdate,    // invalidated region
            int flags               // scrolling options
            );

        [DllImport("gdi32.dll")]
        public static extern Int32 SetROP2(
            IntPtr hdc,
            Int32 fnDrawMode);

        [DllImport("gdi32.dll")]
        public static extern bool FillRgn(
            IntPtr hdc,
            IntPtr hrgn,
            IntPtr hbr);

        [DllImport("gdi32.dll")]
        public static extern IntPtr AddFontMemResourceEx(
            IntPtr data,
            int dataLength,
            IntPtr pdv,
            ref int pcFonts);

        [DllImport("gdi32.dll")]
        public static extern IntPtr AddFontMemResourceEx(
            byte[] data,
            int dataLength,
            IntPtr pdv,
            ref int pcFonts);

        [DllImport("gdi32.dll")]
        public static extern bool RemoveFontMemResourceEx(
            IntPtr fontHandle);

        [DllImport("gdi32.dll", CharSet = CharSet.Auto)]
        public static extern int AddFontResource(
            string lpFileName);

        [DllImport("gdi32.dll")]
        public static extern bool RemoveFontResource(
            string lpFileName);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int ChangeDisplaySettings(
            ref DEVMODE lpDevMode,
            uint dwFlags);

        [DllImport("gdi32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr CreateCompatibleDC(IntPtr hDC);

        [DllImport("GDI32.DLL", ExactSpelling = true, EntryPoint = "CreateCompatibleBitmap", CharSet = CharSet.Auto)]
        public static extern IntPtr CreateCompatibleBitmap(IntPtr hdc, int nWidth, int nHeight);

        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern bool UpdateLayeredWindow(
            IntPtr hwnd,
            IntPtr hdcDst,
            ref POINT pptDst,
            ref SIZE psize,
            IntPtr hdcSrc,
            ref POINT pprSrc,
            Int32 crKey,
            ref BLENDFUNCTION pblend,
            Int32 dwFlags);

        [DllImport("User32.dll")]
        public static extern bool SystemParametersInfo(
            UInt32 uiAction,  // system parameter to retrieve or set
            UInt32 uiParam,   // depends on action to be taken
            ref NONCLIENTMETRICS pvParam,  // depends on action to be taken PVOID
            UInt32 fWinIni    // user profile update option
            );

        [DllImport("User32.dll")]
        public static extern bool SystemParametersInfo(
            int uiAction,   // system parameter to retrieve or set
            int uiParam,    // depends on action to be taken
            int pvParam,    // depends on action to be taken PVOID
            int fWinIni     // user profile update option
            );

        [DllImport("GDI32.DLL")]
        public static extern int SetStretchBltMode(
            IntPtr hdc,         // handle to DC
            int iStretchMode    // bitmap stretching mode
            );

        [DllImport("GDI32.DLL")]
        public static extern int StretchDIBits(
            IntPtr hdc,         // handle to DC
            int XDest,          // x-coord of destination upper-left corner
            int YDest,          // y-coord of destination upper-left corner
            int nDestWidth,     // width of destination rectangle
            int nDestHeight,    // height of destination rectangle
            int XSrc,           // x-coord of source upper-left corner
            int YSrc,           // y-coord of source upper-left corner
            int nSrcWidth,      // width of source rectangle
            int nSrcHeight,     // height of source rectangle
            IntPtr lpBits,      // bitmap bits
            IntPtr lpBitsInfo,  // bitmap data
            uint iUsage,        // usage options
            int dwRop           // raster operation code
            );

        /// <summary>
        /// Gets file-association string from the registry.
        /// </summary>
        /// <param name="flags">Use <see cref="ASSOCF"/> constants.</param>
        /// <param name="str">Use <see cref="ASSOCSTR"/> constants.</param>
        /// <param name="pszAssoc"></param>
        /// <param name="pszExtra"></param>
        /// <param name="pszOut"></param>
        /// <param name="pcchOut"></param>
        /// <returns>An <see cref="OLE"/> success/error code.</returns>
        /// <remarks>
        /// To get associated exe's length/exe:
        /// <code>
        /// uint assocLen = 0;
        /// AssocQueryString(ASSOCF.ASSOCF_INIT_DEFAULTTOSTAR,ASSOCSTR.ASSOCSTR_EXECUTABLE,Path.GetExtension(OutputFileName),"open",null,ref assocLen);
        /// </code>
        /// For existing files, another option is FindExecutable.
        /// </remarks>
        [DllImport("shlwapi.dll", CharSet = CharSet.Auto)]
        public static extern uint AssocQueryString(
            int flags,
            int str,
            string pszAssoc,
            string pszExtra,
            StringBuilder pszOut,
            ref uint pcchOut
        );

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr SetClipboardViewer(
            IntPtr hwndNewViewer);

        [DllImport("kernel32.dll", ExactSpelling = true, CharSet = CharSet.Auto)]
        public static extern IntPtr GlobalLock(IntPtr handle);

        [DllImport("kernel32.dll", ExactSpelling = true, CharSet = CharSet.Auto)]
        internal static extern bool GlobalUnlock(IntPtr handle);

        [DllImport("kernel32.dll", ExactSpelling = true, CharSet = CharSet.Auto)]
        internal static extern IntPtr GlobalFree(IntPtr hMem);

        [DllImport("ole32.dll", ExactSpelling = true, CharSet = CharSet.Auto)]
        internal static extern int CreateStreamOnHGlobal(IntPtr hGlobal, bool fDeleteOnRelease, ref IntPtr istream);

        [DllImport("prntvpt.dll", ExactSpelling = true, CharSet = CharSet.Auto)]
        internal static extern int PTConvertDevModeToPrintTicket(IntPtr hProvider, int cbDevmode, IntPtr devMode, int scope, IntPtr printTicket);

        [DllImport("prntvpt.dll", ExactSpelling = true, CharSet = CharSet.Unicode)]
        internal static extern int PTOpenProvider(string pszPrinterName, int dwVersion, ref IntPtr phProvider);

        [DllImport("prntvpt.dll", ExactSpelling = true, CharSet = CharSet.Auto)]
        internal static extern int PTCloseProvider(IntPtr hProvider);
        #endregion // Windows API functions

        #region Windows GDI+ API functions
        public class Gdip
        {
            private static string s_AtomName;

            #region Private static
            [DllImport("gdiplus.dll", EntryPoint = "GdipDeletePrivateFontCollection", CharSet = CharSet.Unicode, SetLastError = true, ExactSpelling = true)]
            private static extern int IntGdipDeletePrivateFontCollection(
                out IntPtr fontCollection);
            #endregion

            #region Private static properties
            /// <summary>
            /// Name of Atom create by GDI+ for current thread.
            /// </summary>
            private static string AtomName
            {
                get
                {
                    if (s_AtomName == null)
                        s_AtomName = "GDI+Atom" + Win32.GetCurrentProcessId().ToString(CultureInfo.InvariantCulture);
                    return s_AtomName;
                }
            }

            /// <summary>
            /// Gets true if GDI+ currently shutdown.
            /// </summary>
            private static bool IsShutdown
            {
                get { return Win32.FindAtom(AtomName) == 0; }
            }
            #endregion

            #region Public static
            [DllImport("gdiplus.dll", CharSet = CharSet.Unicode, SetLastError = true, ExactSpelling = true)]
            public static extern int GdipNewPrivateFontCollection(
                out IntPtr fontCollection);

            [DllImport("gdiplus.dll", CharSet = CharSet.Unicode, SetLastError = true, ExactSpelling = true)]
            public static extern int GdipPrivateAddMemoryFont(
                HandleRef fontCollection,
                HandleRef memory,
                int length);

            public static int GdipDeletePrivateFontCollection(
                out IntPtr fontCollection)
            {
                if (IsShutdown)
                {
                    fontCollection = IntPtr.Zero;
                    return 0;
                }
                return IntGdipDeletePrivateFontCollection(out fontCollection);
            }

            [DllImport("gdiplus.dll", CharSet = CharSet.Unicode, SetLastError = true, ExactSpelling = true)]
            public static extern int GdipGetFontCollectionFamilyCount(
                HandleRef fontCollection,
                out int numFound);

            [DllImport("gdiplus.dll", CharSet = CharSet.Unicode, SetLastError = true, ExactSpelling = true)]
            public static extern int GdipGetFontCollectionFamilyList(
                HandleRef fontCollection,
                int numSought,
                IntPtr[] gpfamilies,
                out int numFound);

            [DllImport("gdiplus.dll", CharSet = CharSet.Unicode, SetLastError = true, ExactSpelling = true)]
            public static extern int GdipCloneFontFamily(
                HandleRef fontfamily,
                out IntPtr clonefontfamily);

            [DllImport("gdiplus.dll", CharSet = CharSet.Unicode, SetLastError = true, ExactSpelling = true)]
            public static extern int GdipPrivateAddFontFile(
                HandleRef fontCollection,
                string filename);
            #endregion
        }
        #endregion

        #region Functions
#if WIN32_INCLUDE_UNSAFE
        public unsafe static string GetTextFace(
            IntPtr hdc)
        {
            int sz = GetTextFace(hdc, 0, IntPtr.Zero);
            if (sz <= 0)
                return null;
            IntPtr ptr = Marshal.AllocHGlobal(sz);
            string result = new string((char*)ptr);
            Marshal.FreeHGlobal(ptr);
            return result;
        }

        /// <summary>
        /// This function avoids BUG with API GetLocaleInfo function under Win9X
        /// </summary>
        /// <param name="Locale"></param>
        /// <param name="LCType"></param>
        /// <returns></returns>
        public unsafe static string GetLocaleInfo(uint Locale, uint LCType)
        {
            int bufferSize = GetLocaleInfoUnsafe(Locale, LCType, null, 0);
            if (bufferSize > 0)
            {
                char[] data = new char[bufferSize];
                fixed (char* lpData = data)
                {
                    bufferSize = GetLocaleInfoUnsafe(Locale, LCType, lpData, bufferSize);
                }
                if (bufferSize > 0)
                {
                    string s = new string(data);
                    s = s.TrimEnd('\0');
                    if (s.Length == 0)
                        return string.Empty;
                    else
                        return s;
                }
            }
            return string.Empty;
        }
#endif

        public static bool GetOutlineTextMetrics(IntPtr hdc, ref OUTLINETEXTMETRIC OTM)
        {
            GetOutlineTextMetrics(hdc, (uint)Marshal.SizeOf(OTM), ref OTM);
            return true;
        }

        public static int ColorToWin32(Color c)
        {
            return ((c.R | (c.G << 8)) | (c.B << 0x10));
        }

        public static bool MoveTo(
            IntPtr hdc,
            int x,
            int y)
        {
            POINT pt = new POINT();
            return MoveToEx(hdc, x, y, ref pt);
        }

        public static void Line(
            IntPtr hdc,
            Point p1,
            Point p2)
        {
            MoveTo(hdc, p1.X, p1.Y);
            LineTo(hdc, p2.X, p2.Y);
        }
        #endregion // Functions

        #region ODBC constants
        // ODBC Driver prompt options
        internal const ushort
            SQL_DRIVER_PROMPT = 2;

        // ODBC return values
        internal const short
            SQL_NO_DATA = 100;
        #endregion

        #region ODBC functions
        internal static bool SQL_SUCCEEDED(
            short rc)
        {
            return (((rc) & (~1)) == 0);
        }

        [DllImport("odbc32.dll")]
        internal static extern short SQLAllocEnv(
            out IntPtr EnvironmentHandle);

        [DllImport("odbc32.dll")]
        internal static extern short SQLAllocConnect(
            IntPtr EnvironmentHandle,
            out IntPtr ConnectionHandle);

        [DllImport("odbc32.dll", EntryPoint = "SQLDriverConnectW", CharSet = CharSet.Unicode)]
        internal static extern short SQLDriverConnect(
            IntPtr hdbc,
            IntPtr hwnd,
            string szConnStrIn,
            short cbConnStrIn,
            System.Text.StringBuilder szConnStrOut,
            short cbConnStrOutMax,
            out short pcbConnStrOut,
            ushort fDriverCompletion);

        [DllImport("odbc32.dll")]
        internal static extern short SQLDisconnect(
            IntPtr ConnectionHandle);

        [DllImport("odbc32.dll")]
        internal static extern short SQLFreeConnect(
            IntPtr ConnectionHandle);

        [DllImport("odbc32.dll")]
        internal static extern short SQLFreeEnv(
            IntPtr EnvironmentHandle);

        [DllImport("odbccp32.dll", CharSet = CharSet.Unicode)]
        internal static extern bool SQLGetInstalledDrivers(
            char[] lpszBuf,
            int cbBufMax,
            ref int pcbBufOut);

        [DllImport("odbccp32.dll", CharSet = CharSet.Unicode)]
        internal static extern int SQLGetPrivateProfileString(
            string lpszSection,
            string lpszEntry,
            string lpszDefault,
            StringBuilder RetBuffer,
            int cbRetBuffer,
            string lpszFilename);
        #endregion
    }
}
