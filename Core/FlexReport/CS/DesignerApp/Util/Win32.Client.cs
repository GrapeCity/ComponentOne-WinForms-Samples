//----------------------------------------------------------------------------
// Win32.Client.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright ©️ MESCIUS inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System.Runtime.InteropServices;
using System;
using System.Text;
using System.Drawing;
using System.Globalization;

namespace C1.Util.Win
{
    internal partial class Win32
    {
        public static readonly uint GDI_ERROR = 0xFFFFFFFF;

        #region Font structures
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        public struct NEWTEXTMETRIC
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
            public uint ntmFlags;
            public int ntmSizeEM;
            public int ntmCellHeight;
            public int ntmAvgWidth; 
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        public struct FONTSIGNATURE
        {
            [MarshalAs(UnmanagedType.ByValArray)]
            public uint[] fsUsb;
            [MarshalAs(UnmanagedType.ByValArray)]
            public uint[] fsCsb;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        public struct NEWTEXTMETRICEX
        {
            public NEWTEXTMETRIC ntmTm;
            public FONTSIGNATURE ntmFontSig;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        public struct ENUMLOGFONTEX
        {
            public LOGFONT elfLogFont;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
            public string elfFullName;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string elfStyle;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string elfScript;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        public class LOGFONT
        {
            public int lfHeight;
            public int lfWidth;
            public int lfEscapement;
            public int lfOrientation;
            public int lfWeight;
            public byte lfItalic;
            public byte lfUnderline;
            public byte lfStrikeOut;
            public byte lfCharSet;
            public byte lfOutPrecision;
            public byte lfClipPrecision;
            public byte lfQuality;
            public byte lfPitchAndFamily;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string lfFaceName;

            #region Public
            public void CopyFrom(LOGFONT source)
            {
                lfHeight = source.lfHeight;
                lfWidth = source.lfWidth;
                lfEscapement = source.lfEscapement;
                lfOrientation = source.lfOrientation;
                lfWeight = source.lfWeight;
                lfItalic = source.lfItalic;
                lfUnderline = source.lfUnderline;
                lfStrikeOut = source.lfStrikeOut;
                lfCharSet = source.lfCharSet;
                lfOutPrecision = source.lfOutPrecision;
                lfClipPrecision = source.lfClipPrecision;
                lfQuality = source.lfQuality;
                lfPitchAndFamily = source.lfPitchAndFamily;
                lfFaceName = source.lfFaceName;
            }

            public void CopyFrom(LOGFONT_UNMANAGED source)
            {
                lfHeight = source.lfHeight;
                lfWidth = source.lfWidth;
                lfEscapement = source.lfEscapement;
                lfOrientation = source.lfOrientation;
                lfWeight = source.lfWeight;
                lfItalic = source.lfItalic;
                lfUnderline = source.lfUnderline;
                lfStrikeOut = source.lfStrikeOut;
                lfCharSet = source.lfCharSet;
                lfOutPrecision = source.lfOutPrecision;
                lfClipPrecision = source.lfClipPrecision;
                lfQuality = source.lfQuality;
                lfPitchAndFamily = source.lfPitchAndFamily;
                lfFaceName = new string(new char[] {source.name0,
                                                   source.name1, source.name2, source.name3,
                                                   source.name4, source.name5, source.name6,
                                                   source.name7, source.name8, source.name9,
                                                   source.name10, source.name11, source.name12,
                                                   source.name13, source.name14, source.name15,
                                                   source.name16, source.name17, source.name18,
                                                   source.name19, source.name20, source.name21,
                                                   source.name22, source.name23, source.name24,
                                                   source.name25, source.name26, source.name27,
                                                   source.name28, source.name29, source.name30,
                                                   source.name31});
            }
            #endregion
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        internal struct LOGFONT_UNMANAGED
        {
            public int lfHeight;
            public int lfWidth;
            public int lfEscapement;
            public int lfOrientation;
            public int lfWeight;
            public byte lfItalic;
            public byte lfUnderline;
            public byte lfStrikeOut;
            public byte lfCharSet;
            public byte lfOutPrecision;
            public byte lfClipPrecision;
            public byte lfQuality;
            public byte lfPitchAndFamily;
            public char name0;
            public char name1;
            public char name2;
            public char name3;
            public char name4;
            public char name5;
            public char name6;
            public char name7;
            public char name8;
            public char name9;
            public char name10;
            public char name11;
            public char name12;
            public char name13;
            public char name14;
            public char name15;
            public char name16;
            public char name17;
            public char name18;
            public char name19;
            public char name20;
            public char name21;
            public char name22;
            public char name23;
            public char name24;
            public char name25;
            public char name26;
            public char name27;
            public char name28;
            public char name29;
            public char name30;
            public char name31;
        }
        #endregion

        #region Macros
        public static uint MAKELANGID(uint LANG_ID, uint SUBLANG_ID)
        {
            //#define MAKELANGID(p, s)       ((((WORD  )(s)) << 10) | (WORD  )(p))
            return (uint)((unchecked((ushort)SUBLANG_ID) << 10) |
                unchecked((ushort)LANG_ID));
        }

        public static uint MAKELCID(uint LANG_ID, uint SORT_ID)
        {
            //#define MAKELCID(lgid, srtid)  ((DWORD)((((DWORD)((WORD  )(srtid))) << 16) |  \
            //                             ((DWORD)((WORD  )(lgid)))))
            return (((uint)unchecked((ushort)SORT_ID)) << 16) |
                ((uint)unchecked((ushort)LANG_ID));
        }
        #endregion // Macros

        #region Constants
        public class ERROR
        {
            public const int 
                ERROR_FILE_NOT_FOUND = 2,
                ERROR_INSUFFICIENT_BUFFER = 122;
        }

        public class HWND
        {
            public const int
                HWND_BROADCAST = 0xFFFF,
                HWND_TOPMOST = -1, 
                HWND_MESSAGE = -3;
        }

        internal class GGO
        {
            public const uint
                GGO_METRICS = 0,
                GGO_BITMAP = 1,
                GGO_NATIVE = 2;
        }

        internal class GGI
        {
            public const uint
                GGI_MARK_NONEXISTING_GLYPHS = 1;
        }

        internal class FW
        {
            public const int
                FW_DONTCARE = 0,
                FW_THIN = 100,
                FW_EXTRALIGHT = 200,
                FW_LIGHT = 300,
                FW_NORMAL = 400,
                FW_MEDIUM = 500,
                FW_SEMIBOLD = 600,
                FW_BOLD = 700,
                FW_EXTRABOLD = 800,
                FW_HEAVY = 900,
                FW_ULTRALIGHT = FW_EXTRALIGHT,
                FW_REGULAR = FW_NORMAL,
                FW_DEMIBOLD = FW_SEMIBOLD,
                FW_ULTRABOLD = FW_EXTRABOLD,
                FW_BLACK = FW_HEAVY;
        }

        internal class FONT_TYPE
        {
            public const uint
                RASTER_FONTTYPE = 0x01,
                DEVICE_FONTTYPE = 0x02,
                TRUETYPE_FONTTYPE = 0x04;
        }

        internal class WMF
        {
            public const uint
                WMF_KEY = 0x9AC6CDD7;
        }

        internal class CHARSET
        {
            public const byte
                ANSI_CHARSET = 0,
                DEFAULT_CHARSET = 1,
                SYMBOL_CHARSET = 2,
                SHIFTJIS_CHARSET = 0x80,
                HANGEUL_CHARSET = 129,
                GB2312_CHARSET = 134,
                CHINESEBIG5_CHARSET = 136,
                OEM_CHARSET = 255,
                JOHAB_CHARSET = 130,
                HEBREW_CHARSET = 177,
                ARABIC_CHARSET = 178,
                GREEK_CHARSET = 161,
                TURKISH_CHARSET = 162,
                VIETNAMESE_CHARSET = 163,
                THAI_CHARSET = 222,
                EASTEUROPE_CHARSET = 238,
                RUSSIAN_CHARSET = 204,

                MAC_CHARSET = 77,
                BALTIC_CHARSET = 186;
        }

        internal class OUT
        {
            public const int
                OUT_DEFAULT_PRECIS = 0,
                OUT_STRING_PRECIS = 1,
                OUT_CHARACTER_PRECIS = 2,
                OUT_STROKE_PRECIS = 3,
                OUT_TT_PRECIS = 4,
                OUT_DEVICE_PRECIS = 5,
                OUT_RASTER_PRECIS = 6,
                OUT_TT_ONLY_PRECIS = 7,
                OUT_OUTLINE_PRECIS = 8,
                OUT_SCREEN_OUTLINE_PRECIS = 9,
                OUT_PS_ONLY_PRECIS = 10;
        }

        internal class CLIP
        {
            public const int
                CLIP_DEFAULT_PRECIS = 0,
                CLIP_CHARACTER_PRECIS = 1,
                CLIP_STROKE_PRECIS = 2,
                CLIP_MASK = 0xf,
                CLIP_LH_ANGLES = (1 << 4),
                CLIP_TT_ALWAYS = (2 << 4),
                CLIP_EMBEDDED = (8 << 4);
        }

        internal class RC
        {
            public const int
                RC_BITBLT = 1, // Can do standard BLT.
                RC_BANDING = 2, // Device requires banding support
                RC_SCALING = 4, // Device requires scaling support
                RC_BITMAP64 = 8, // Device can support >64K bitmap
                RC_GDI20_OUTPUT = 0x10, // has 2.0 output calls
                RC_GDI20_STATE = 0x20,
                RC_SAVEBITMAP = 0x40,
                RC_DI_BITMAP = 0x80, // supports DIB to memory
                RC_PALETTE = 0x100, // supports a palette
                RC_DIBTODEV = 0x200, // supports DIBitsToDevice
                RC_BIGFONT = 0x400, // supports >64K fonts
                RC_STRETCHBLT = 0x800, // supports StretchBlt
                RC_FLOODFILL = 0x1000, // supports FloodFill
                RC_STRETCHDIB = 0x2000, // supports StretchDIBits
                RC_OP_DX_OUTPUT = 0x4000,
                RC_DEVBITS = 0x8000;
        }

        internal class QUALITY
        {
            public const int
                DEFAULT_QUALITY = 0,
                DRAFT_QUALITY = 1,
                PROOF_QUALITY = 2,
                NONANTIALIASED_QUALITY = 3,
                ANTIALIASED_QUALITY = 4,
                CLEARTYPE_QUALITY = 5;
        }

        internal class DMCOLOR
        {
            public const short
                DMCOLOR_MONOCHROME = 1,
                DMCOLOR_COLOR = 2;
        }

        internal class DMORIENT
        {
            public const short
                DMORIENT_PORTRAIT = 1,
                DMORIENT_LANDSCAPE = 2; 
        }

        internal class DC
        {
            public const int
                DC_FIELDS = 1,
                DC_PAPERS = 2,
                DC_PAPERSIZE = 3,
                DC_MINEXTENT = 4,
                DC_MAXEXTENT = 5,
                DC_BINS = 6,
                DC_DUPLEX = 7,
                DC_SIZE = 8,
                DC_EXTRA = 9,
                DC_VERSION = 10,
                DC_DRIVER = 11,
                DC_BINNAMES = 12,
                DC_ENUMRESOLUTIONS = 13,
                DC_FILEDEPENDENCIES = 14,
                DC_TRUETYPE = 15,
                DC_PAPERNAMES = 16,
                DC_ORIENTATION = 17,
                DC_COPIES = 18,
                DC_BINADJUST = 19,
                DC_EMF_COMPLIANT = 20,
                DC_DATATYPE_PRODUCED = 21,
                DC_COLLATE = 22,
                DC_MANUFACTURER = 23,
                DC_MODEL = 24,
                DC_COLORDEVICE = 23,
                DC_NUP = 24,
                DC_PERSONALITY = 25,
                DC_PRINTRATE = 26,
                DC_PRINTRATEUNIT = 27,
                DC_PRINTERMEM = 28,
                DC_MEDIAREADY = 29;
        }

        /// <summary>
        /// Fiels of DEVMODE structure.
        /// </summary>
        internal class DM
        {
            public const int
                DM_ORIENTATION = 0x00001,
                DM_PAPERSIZE = 2,
                DM_PAPERLENGTH = 4,
                DM_PAPERWIDTH = 8,
                DM_DEFAULTSOURCE = 0x200,
                DM_PRINTQUALITY = 0x400,
                DM_COLOR = 0x800,
                DM_YRESOLUTION = 0x2000,
                DM_BITSPERPEL = 0x40000,
                DM_PELSWIDTH = 0x80000,
                DM_PELSHEIGHT = 0x100000,
                DM_DISPLAYFREQUENCY = 0x400000;
        }

        internal class DMBIN
        {
            public const int
                DMBIN_UPPER = 1,
                DMBIN_ONLYONE = 1,
                DMBIN_LOWER = 2,
                DMBIN_MIDDLE = 3,
                DMBIN_MANUAL = 4,
                DMBIN_ENVELOPE = 5,
                DMBIN_ENVMANUAL = 6,
                DMBIN_AUTO = 7,
                DMBIN_TRACTOR = 8,
                DMBIN_SMALLFMT = 9,
                DMBIN_LARGEFMT = 10,
                DMBIN_LARGECAPACITY = 11,
                DMBIN_CASSETTE = 14,
                DMBIN_FORMSOURCE = 15,
                DMBIN_USER = 0x100;
        }

        internal class DMRES
        {
            public const uint
                DMRES_DRAFT = unchecked((uint)-1),
                DMRES_LOW = unchecked((uint)-2),
                DMRES_MEDIUM = unchecked((uint)-3),
                DMRES_HIGH = unchecked((uint)-4);
        }

        internal class DM_PROPS
        {
            public const int
                DM_IN_BUFFER = 8,
                DM_IN_PROMPT = 4,
                DM_OUT_BUFFER = 2,
                DM_OUT_DEFAULT = 1;
        }

        internal class PRINTER_ENUM
        {
            public const int
                PRINTER_ENUM_LOCAL = 0x00000002,
                PRINTER_ENUM_NAME = 0x00000008,
                PRINTER_ENUM_SHARED = 0x00000020,
                PRINTER_ENUM_DEFAULT = 0x00000001,
                PRINTER_ENUM_CONNECTIONS = 0x00000004,
                PRINTER_ENUM_NETWORK = 0x00000040,
                PRINTER_ENUM_REMOTE = 0x00000010;
        }

        /// <summary>
        /// GetDeviceCaps() constants
        /// </summary>
        internal class GetDeviceCapsConsts
        {
            public const int
                DRIVERVERSION = 0,     /* Device driver version */
                TECHNOLOGY = 2,     /* Device classification */
                HORZSIZE = 4,     /* Horizontal size in millimeters */
                VERTSIZE = 6,     /* Vertical size in millimeters */
                HORZRES = 8,     /* Horizontal width in pixels */
                VERTRES = 10,    /* Vertical height in pixels */
                BITSPIXEL = 12,    /* Number of bits per pixel */
                PLANES = 14,    /* Number of planes */
                NUMBRUSHES = 16,    /* Number of brushes the device has */
                NUMPENS = 18,    /* Number of pens the device has */
                NUMMARKERS = 20,    /* Number of markers the device has */
                NUMFONTS = 22,    /* Number of fonts the device has */
                NUMCOLORS = 24,    /* Number of colors the device supports */
                PDEVICESIZE = 26,    /* Size required for device descriptor */
                CURVECAPS = 28,    /* Curve capabilities */
                LINECAPS = 30,    /* Line capabilities */
                POLYGONALCAPS = 32,    /* Polygonal capabilities */
                TEXTCAPS = 34,    /* Text capabilities */
                CLIPCAPS = 36,    /* Clipping capabilities */
                RASTERCAPS = 38,    /* Bitblt capabilities */
                ASPECTX = 40,    /* Length of the X leg */
                ASPECTY = 42,    /* Length of the Y leg */
                ASPECTXY = 44,    /* Length of the hypotenuse */
                LOGPIXELSX = 88,    /* Logical pixels/inch in X */
                LOGPIXELSY = 90,    /* Logical pixels/inch in Y */
                PHYSICALWIDTH = 110, /* Physical Width in device units */
                PHYSICALHEIGHT = 111, /* Physical Height in device units */
                PHYSICALOFFSETX = 112, /* Physical Printable Area x margin */
                PHYSICALOFFSETY = 113, /* Physical Printable Area y margin */
                SCALINGFACTORX = 114, /* Scaling factor x */
                SCALINGFACTORY = 115, /* Scaling factor y */
                VREFRESH = 116,
                DESKTOPVERTRES = 117, /* Vertical height of entire desktop in pixels */
                DESKTOPHORZRES = 118; /* Horizontal width of entire desktop in pixels */
        }

        /// <summary>
        /// Sorting IDs.
        /// </summary>
        internal class SORT
        {
            public const uint
                SORT_DEFAULT = 0x0, // sorting default

                SORT_JAPANESE_XJIS = 0x0, // Japanese XJIS order
                SORT_JAPANESE_UNICODE = 0x1, // Japanese Unicode order

                SORT_CHINESE_BIG5 = 0x0, // Chinese BIG5 order
                SORT_CHINESE_PRCP = 0x0, // PRC Chinese Phonetic order
                SORT_CHINESE_UNICODE = 0x1, // Chinese Unicode order
                SORT_CHINESE_PRC = 0x2, // PRC Chinese Stroke Count order
                SORT_CHINESE_BOPOMOFO = 0x3, // Traditional Chinese Bopomofo order

                SORT_KOREAN_KSC = 0x0, // Korean KSC order
                SORT_KOREAN_UNICODE = 0x1, // Korean Unicode order

                SORT_GERMAN_PHONE_BOOK = 0x1, // German Phone Book order

                SORT_HUNGARIAN_DEFAULT = 0x0, // Hungarian Default order
                SORT_HUNGARIAN_TECHNICAL = 0x1, // Hungarian Technical order

                SORT_GEORGIAN_TRADITIONAL = 0x0, // Georgian Traditional order
                SORT_GEORGIAN_MODERN = 0x1; // Georgian Modern order
        }

        /// <summary>
        /// Primary language IDs.
        /// </summary>
        internal class LANG
        {
            public const uint
                LANG_NEUTRAL = 0x00,
                LANG_INVARIANT = 0x7f,

                LANG_AFRIKAANS = 0x36,
                LANG_ALBANIAN = 0x1c,
                LANG_ARABIC = 0x01,
                LANG_ARMENIAN = 0x2b,
                LANG_ASSAMESE = 0x4d,
                LANG_AZERI = 0x2c,
                LANG_BASQUE = 0x2d,
                LANG_BELARUSIAN = 0x23,
                LANG_BENGALI = 0x45,
                LANG_BULGARIAN = 0x02,
                LANG_CATALAN = 0x03,
                LANG_CHINESE = 0x04,
                LANG_CROATIAN = 0x1a,
                LANG_CZECH = 0x05,
                LANG_DANISH = 0x06,
                LANG_DIVEHI = 0x65,
                LANG_DUTCH = 0x13,
                LANG_ENGLISH = 0x09,
                LANG_ESTONIAN = 0x25,
                LANG_FAEROESE = 0x38,
                LANG_FARSI = 0x29,
                LANG_FINNISH = 0x0b,
                LANG_FRENCH = 0x0c,
                LANG_GALICIAN = 0x56,
                LANG_GEORGIAN = 0x37,
                LANG_GERMAN = 0x07,
                LANG_GREEK = 0x08,
                LANG_GUJARATI = 0x47,
                LANG_HEBREW = 0x0d,
                LANG_HINDI = 0x39,
                LANG_HUNGARIAN = 0x0e,
                LANG_ICELANDIC = 0x0f,
                LANG_INDONESIAN = 0x21,
                LANG_ITALIAN = 0x10,
                LANG_JAPANESE = 0x11,
                LANG_KANNADA = 0x4b,
                LANG_KASHMIRI = 0x60,
                LANG_KAZAK = 0x3f,
                LANG_KONKANI = 0x57,
                LANG_KOREAN = 0x12,
                LANG_KYRGYZ = 0x40,
                LANG_LATVIAN = 0x26,
                LANG_LITHUANIAN = 0x27,
                LANG_MACEDONIAN = 0x2f,  // the Former Yugoslav Republic of Macedonia
                LANG_MALAY = 0x3e,
                LANG_MALAYALAM = 0x4c,
                LANG_MANIPURI = 0x58,
                LANG_MARATHI = 0x4e,
                LANG_MONGOLIAN = 0x50,
                LANG_NEPALI = 0x61,
                LANG_NORWEGIAN = 0x14,
                LANG_ORIYA = 0x48,
                LANG_POLISH = 0x15,
                LANG_PORTUGUESE = 0x16,
                LANG_PUNJABI = 0x46,
                LANG_ROMANIAN = 0x18,
                LANG_RUSSIAN = 0x19,
                LANG_SANSKRIT = 0x4f,
                LANG_SERBIAN = 0x1a,
                LANG_SINDHI = 0x59,
                LANG_SLOVAK = 0x1b,
                LANG_SLOVENIAN = 0x24,
                LANG_SPANISH = 0x0a,
                LANG_SWAHILI = 0x41,
                LANG_SWEDISH = 0x1d,
                LANG_SYRIAC = 0x5a,
                LANG_TAMIL = 0x49,
                LANG_TATAR = 0x44,
                LANG_TELUGU = 0x4a,
                LANG_THAI = 0x1e,
                LANG_TURKISH = 0x1f,
                LANG_UKRAINIAN = 0x22,
                LANG_URDU = 0x20,
                LANG_UZBEK = 0x43,
                LANG_VIETNAMESE = 0x2a;
        }

        /// <summary>
        ///  Sublanguage IDs.
        ///
        ///  The name immediately following SUBLANG_ dictates which primary
        ///  language ID that sublanguage ID can be combined with to form a
        ///  valid language ID.
        /// </summary>
        internal class SUBLANG
        {
            public const uint
            SUBLANG_NEUTRAL = 0x00, // language neutral
            SUBLANG_DEFAULT = 0x01, // user default
            SUBLANG_SYS_DEFAULT = 0x02, // system default

            SUBLANG_ARABIC_SAUDI_ARABIA = 0x01, // Arabic (Saudi Arabia)
            SUBLANG_ARABIC_IRAQ = 0x02, // Arabic (Iraq)
            SUBLANG_ARABIC_EGYPT = 0x03, // Arabic (Egypt)
            SUBLANG_ARABIC_LIBYA = 0x04, // Arabic (Libya)
            SUBLANG_ARABIC_ALGERIA = 0x05, // Arabic (Algeria)
            SUBLANG_ARABIC_MOROCCO = 0x06, // Arabic (Morocco)
            SUBLANG_ARABIC_TUNISIA = 0x07, // Arabic (Tunisia)
            SUBLANG_ARABIC_OMAN = 0x08, // Arabic (Oman)
            SUBLANG_ARABIC_YEMEN = 0x09, // Arabic (Yemen)
            SUBLANG_ARABIC_SYRIA = 0x0a, // Arabic (Syria)
            SUBLANG_ARABIC_JORDAN = 0x0b, // Arabic (Jordan)
            SUBLANG_ARABIC_LEBANON = 0x0c, // Arabic (Lebanon)
            SUBLANG_ARABIC_KUWAIT = 0x0d, // Arabic (Kuwait)
            SUBLANG_ARABIC_UAE = 0x0e, // Arabic (U.A.E)
            SUBLANG_ARABIC_BAHRAIN = 0x0f, // Arabic (Bahrain)
            SUBLANG_ARABIC_QATAR = 0x10, // Arabic (Qatar)
            SUBLANG_AZERI_LATIN = 0x01, // Azeri (Latin)
            SUBLANG_AZERI_CYRILLIC = 0x02, // Azeri (Cyrillic)
            SUBLANG_CHINESE_TRADITIONAL = 0x01, // Chinese (Taiwan)
            SUBLANG_CHINESE_SIMPLIFIED = 0x02, // Chinese (PR China)
            SUBLANG_CHINESE_HONGKONG = 0x03, // Chinese (Hong Kong S.A.R., P.R.C.)
            SUBLANG_CHINESE_SINGAPORE = 0x04, // Chinese (Singapore)
            SUBLANG_CHINESE_MACAU = 0x05, // Chinese (Macau S.A.R.)
            SUBLANG_DUTCH = 0x01, // Dutch
            SUBLANG_DUTCH_BELGIAN = 0x02, // Dutch (Belgian)
            SUBLANG_ENGLISH_US = 0x01, // English (USA)
            SUBLANG_ENGLISH_UK = 0x02, // English (UK)
            SUBLANG_ENGLISH_AUS = 0x03, // English (Australian)
            SUBLANG_ENGLISH_CAN = 0x04, // English (Canadian)
            SUBLANG_ENGLISH_NZ = 0x05, // English (New Zealand)
            SUBLANG_ENGLISH_EIRE = 0x06, // English (Irish)
            SUBLANG_ENGLISH_SOUTH_AFRICA = 0x07, // English (South Africa)
            SUBLANG_ENGLISH_JAMAICA = 0x08, // English (Jamaica)
            SUBLANG_ENGLISH_CARIBBEAN = 0x09, // English (Caribbean)
            SUBLANG_ENGLISH_BELIZE = 0x0a, // English (Belize)
            SUBLANG_ENGLISH_TRINIDAD = 0x0b, // English (Trinidad)
            SUBLANG_ENGLISH_ZIMBABWE = 0x0c, // English (Zimbabwe)
            SUBLANG_ENGLISH_PHILIPPINES = 0x0d, // English (Philippines)
            SUBLANG_FRENCH = 0x01, // French
            SUBLANG_FRENCH_BELGIAN = 0x02, // French (Belgian)
            SUBLANG_FRENCH_CANADIAN = 0x03, // French (Canadian)
            SUBLANG_FRENCH_SWISS = 0x04, // French (Swiss)
            SUBLANG_FRENCH_LUXEMBOURG = 0x05, // French (Luxembourg)
            SUBLANG_FRENCH_MONACO = 0x06, // French (Monaco)
            SUBLANG_GERMAN = 0x01, // German
            SUBLANG_GERMAN_SWISS = 0x02, // German (Swiss)
            SUBLANG_GERMAN_AUSTRIAN = 0x03, // German (Austrian)
            SUBLANG_GERMAN_LUXEMBOURG = 0x04, // German (Luxembourg)
            SUBLANG_GERMAN_LIECHTENSTEIN = 0x05, // German (Liechtenstein)
            SUBLANG_ITALIAN = 0x01, // Italian
            SUBLANG_ITALIAN_SWISS = 0x02, // Italian (Swiss)
            SUBLANG_KASHMIRI_SASIA = 0x02, // Kashmiri (South Asia)
            SUBLANG_KASHMIRI_INDIA = 0x02, // For app compatibility only
            SUBLANG_KOREAN = 0x01, // Korean (Extended Wansung)
            SUBLANG_LITHUANIAN = 0x01, // Lithuanian
            SUBLANG_MALAY_MALAYSIA = 0x01, // Malay (Malaysia)
            SUBLANG_MALAY_BRUNEI_DARUSSALAM = 0x02, // Malay (Brunei Darussalam)
            SUBLANG_NEPALI_INDIA = 0x02, // Nepali (India)
            SUBLANG_NORWEGIAN_BOKMAL = 0x01, // Norwegian (Bokmal)
            SUBLANG_NORWEGIAN_NYNORSK = 0x02, // Norwegian (Nynorsk)
            SUBLANG_PORTUGUESE = 0x02, // Portuguese
            SUBLANG_PORTUGUESE_BRAZILIAN = 0x01, // Portuguese (Brazilian)
            SUBLANG_SERBIAN_LATIN = 0x02, // Serbian (Latin)
            SUBLANG_SERBIAN_CYRILLIC = 0x03, // Serbian (Cyrillic)
            SUBLANG_SPANISH = 0x01, // Spanish (Castilian)
            SUBLANG_SPANISH_MEXICAN = 0x02, // Spanish (Mexican)
            SUBLANG_SPANISH_MODERN = 0x03, // Spanish (Modern)
            SUBLANG_SPANISH_GUATEMALA = 0x04, // Spanish (Guatemala)
            SUBLANG_SPANISH_COSTA_RICA = 0x05, // Spanish (Costa Rica)
            SUBLANG_SPANISH_PANAMA = 0x06, // Spanish (Panama)
            SUBLANG_SPANISH_DOMINICAN_REPUBLIC = 0x07, // Spanish (Dominican Republic)
            SUBLANG_SPANISH_VENEZUELA = 0x08, // Spanish (Venezuela)
            SUBLANG_SPANISH_COLOMBIA = 0x09, // Spanish (Colombia)
            SUBLANG_SPANISH_PERU = 0x0a, // Spanish (Peru)
            SUBLANG_SPANISH_ARGENTINA = 0x0b, // Spanish (Argentina)
            SUBLANG_SPANISH_ECUADOR = 0x0c, // Spanish (Ecuador)
            SUBLANG_SPANISH_CHILE = 0x0d, // Spanish (Chile)
            SUBLANG_SPANISH_URUGUAY = 0x0e, // Spanish (Uruguay)
            SUBLANG_SPANISH_PARAGUAY = 0x0f, // Spanish (Paraguay)
            SUBLANG_SPANISH_BOLIVIA = 0x10, // Spanish (Bolivia)
            SUBLANG_SPANISH_EL_SALVADOR = 0x11, // Spanish (El Salvador)
            SUBLANG_SPANISH_HONDURAS = 0x12, // Spanish (Honduras)
            SUBLANG_SPANISH_NICARAGUA = 0x13, // Spanish (Nicaragua)
            SUBLANG_SPANISH_PUERTO_RICO = 0x14, // Spanish (Puerto Rico)
            SUBLANG_SWEDISH = 0x01, // Swedish
            SUBLANG_SWEDISH_FINLAND = 0x02, // Swedish (Finland)
            SUBLANG_URDU_PAKISTAN = 0x01, // Urdu (Pakistan)
            SUBLANG_URDU_INDIA = 0x02, // Urdu (India)
            SUBLANG_UZBEK_LATIN = 0x01, // Uzbek (Latin)
            SUBLANG_UZBEK_CYRILLIC = 0x02; // Uzbek (Cyrillic)
        }

        /// <summary>
        /// Locale Types.
        /// </summary>
        internal class LOCALE
        {
            public static readonly uint LANG_SYSTEM_DEFAULT = MAKELANGID(LANG.LANG_NEUTRAL, SUBLANG.SUBLANG_SYS_DEFAULT);
            public static readonly uint LANG_USER_DEFAULT = MAKELANGID(LANG.LANG_NEUTRAL, SUBLANG.SUBLANG_DEFAULT);
            public static readonly uint LOCALE_SYSTEM_DEFAULT = MAKELCID(LOCALE.LANG_SYSTEM_DEFAULT, SORT.SORT_DEFAULT);
            public static readonly uint LOCALE_USER_DEFAULT = MAKELCID(LOCALE.LANG_USER_DEFAULT, SORT.SORT_DEFAULT);

            //  These types are used for the GetLocaleInfo NLS API routine.
            //  Some of these types are also used for the SetLocaleInfo NLS API routine.
            //
            //  The following LCTypes may be used in combination with any other LCTypes.
            //
            //    LOCALE_NOUSEROVERRIDE is also used in GetTimeFormat and
            //    GetDateFormat.
            //
            //    LOCALE_USE_CP_ACP is used in many of the A (Ansi) apis that need
            //    to do string translation.
            //
            //    LOCALE_RETURN_NUMBER will return the result from GetLocaleInfo as a
            //    number instead of a string.  This flag is only valid for the LCTypes
            //    beginning with LOCALE_I.
            public const uint
                LOCALE_NOUSEROVERRIDE = 0x80000000, // do not use user overrides
                LOCALE_USE_CP_ACP = 0x40000000, // use the system ACP
                LOCALE_RETURN_NUMBER = 0x20000000, // return number instead of string


                // The following LCTypes are mutually exclusive in that they may NOT
                // be used in combination with each other.
                LOCALE_ILANGUAGE = 0x00000001, // language id
                LOCALE_SLANGUAGE = 0x00000002, // localized name of language
                LOCALE_SENGLANGUAGE = 0x00001001, // English name of language
                LOCALE_SABBREVLANGNAME = 0x00000003, // abbreviated language name
                LOCALE_SNATIVELANGNAME = 0x00000004, // native name of language

            LOCALE_ICOUNTRY = 0x00000005, // country code
                LOCALE_SCOUNTRY = 0x00000006, // localized name of country
                LOCALE_SENGCOUNTRY = 0x00001002, // English name of country
                LOCALE_SABBREVCTRYNAME = 0x00000007, // abbreviated country name
                LOCALE_SNATIVECTRYNAME = 0x00000008, // native name of country

            LOCALE_IDEFAULTLANGUAGE = 0x00000009, // default language id
                LOCALE_IDEFAULTCOUNTRY = 0x0000000A, // default country code
                LOCALE_IDEFAULTCODEPAGE = 0x0000000B, // default oem code page
                LOCALE_IDEFAULTANSICODEPAGE = 0x00001004, // default ansi code page
                LOCALE_IDEFAULTMACCODEPAGE = 0x00001011, // default mac code page

            LOCALE_SLIST = 0x0000000C, // list item separator
                LOCALE_IMEASURE = 0x0000000D, // 0 = metric, 1 = US

            LOCALE_SDECIMAL = 0x0000000E, // decimal separator
                LOCALE_STHOUSAND = 0x0000000F, // thousand separator
                LOCALE_SGROUPING = 0x00000010, // digit grouping
                LOCALE_IDIGITS = 0x00000011, // number of fractional digits
                LOCALE_ILZERO = 0x00000012, // leading zeros for decimal
                LOCALE_INEGNUMBER = 0x00001010, // negative number mode
                LOCALE_SNATIVEDIGITS = 0x00000013, // native ascii 0-9

            LOCALE_SCURRENCY = 0x00000014, // local monetary symbol
                LOCALE_SINTLSYMBOL = 0x00000015, // intl monetary symbol
                LOCALE_SMONDECIMALSEP = 0x00000016, // monetary decimal separator
                LOCALE_SMONTHOUSANDSEP = 0x00000017, // monetary thousand separator
                LOCALE_SMONGROUPING = 0x00000018, // monetary grouping
                LOCALE_ICURRDIGITS = 0x00000019, // # local monetary digits
                LOCALE_IINTLCURRDIGITS = 0x0000001A, // # intl monetary digits
                LOCALE_ICURRENCY = 0x0000001B, // positive currency mode
                LOCALE_INEGCURR = 0x0000001C, // negative currency mode

            LOCALE_SDATE = 0x0000001D, // date separator
                LOCALE_STIME = 0x0000001E, // time separator
                LOCALE_SSHORTDATE = 0x0000001F, // short date format string
                LOCALE_SLONGDATE = 0x00000020, // long date format string
                LOCALE_STIMEFORMAT = 0x00001003, // time format string
                LOCALE_IDATE = 0x00000021, // short date format ordering
                LOCALE_ILDATE = 0x00000022, // long date format ordering
                LOCALE_ITIME = 0x00000023, // time format specifier
                LOCALE_ITIMEMARKPOSN = 0x00001005, // time marker position
                LOCALE_ICENTURY = 0x00000024, // century format specifier (short date)
                LOCALE_ITLZERO = 0x00000025, // leading zeros in time field
                LOCALE_IDAYLZERO = 0x00000026, // leading zeros in day field (short date)
                LOCALE_IMONLZERO = 0x00000027, // leading zeros in month field (short date)
                LOCALE_S1159 = 0x00000028, // AM designator
                LOCALE_S2359 = 0x00000029, // PM designator

            LOCALE_ICALENDARTYPE = 0x00001009, // type of calendar specifier
                LOCALE_IOPTIONALCALENDAR = 0x0000100B, // additional calendar types specifier
                LOCALE_IFIRSTDAYOFWEEK = 0x0000100C, // first day of week specifier
                LOCALE_IFIRSTWEEKOFYEAR = 0x0000100D, // first week of year specifier

            LOCALE_SDAYNAME1 = 0x0000002A, // long name for Monday
                LOCALE_SDAYNAME2 = 0x0000002B, // long name for Tuesday
                LOCALE_SDAYNAME3 = 0x0000002C, // long name for Wednesday
                LOCALE_SDAYNAME4 = 0x0000002D, // long name for Thursday
                LOCALE_SDAYNAME5 = 0x0000002E, // long name for Friday
                LOCALE_SDAYNAME6 = 0x0000002F, // long name for Saturday
                LOCALE_SDAYNAME7 = 0x00000030, // long name for Sunday
                LOCALE_SABBREVDAYNAME1 = 0x00000031, // abbreviated name for Monday
                LOCALE_SABBREVDAYNAME2 = 0x00000032, // abbreviated name for Tuesday
                LOCALE_SABBREVDAYNAME3 = 0x00000033, // abbreviated name for Wednesday
                LOCALE_SABBREVDAYNAME4 = 0x00000034, // abbreviated name for Thursday
                LOCALE_SABBREVDAYNAME5 = 0x00000035, // abbreviated name for Friday
                LOCALE_SABBREVDAYNAME6 = 0x00000036, // abbreviated name for Saturday
                LOCALE_SABBREVDAYNAME7 = 0x00000037, // abbreviated name for Sunday
                LOCALE_SMONTHNAME1 = 0x00000038, // long name for January
                LOCALE_SMONTHNAME2 = 0x00000039, // long name for February
                LOCALE_SMONTHNAME3 = 0x0000003A, // long name for March
                LOCALE_SMONTHNAME4 = 0x0000003B, // long name for April
                LOCALE_SMONTHNAME5 = 0x0000003C, // long name for May
                LOCALE_SMONTHNAME6 = 0x0000003D, // long name for June
                LOCALE_SMONTHNAME7 = 0x0000003E, // long name for July
                LOCALE_SMONTHNAME8 = 0x0000003F, // long name for August
                LOCALE_SMONTHNAME9 = 0x00000040, // long name for September
                LOCALE_SMONTHNAME10 = 0x00000041, // long name for October
                LOCALE_SMONTHNAME11 = 0x00000042, // long name for November
                LOCALE_SMONTHNAME12 = 0x00000043, // long name for December
                LOCALE_SMONTHNAME13 = 0x0000100E, // long name for 13th month (if exists)
                LOCALE_SABBREVMONTHNAME1 = 0x00000044, // abbreviated name for January
                LOCALE_SABBREVMONTHNAME2 = 0x00000045, // abbreviated name for February
                LOCALE_SABBREVMONTHNAME3 = 0x00000046, // abbreviated name for March
                LOCALE_SABBREVMONTHNAME4 = 0x00000047, // abbreviated name for April
                LOCALE_SABBREVMONTHNAME5 = 0x00000048, // abbreviated name for May
                LOCALE_SABBREVMONTHNAME6 = 0x00000049, // abbreviated name for June
                LOCALE_SABBREVMONTHNAME7 = 0x0000004A, // abbreviated name for July
                LOCALE_SABBREVMONTHNAME8 = 0x0000004B, // abbreviated name for August
                LOCALE_SABBREVMONTHNAME9 = 0x0000004C, // abbreviated name for September
                LOCALE_SABBREVMONTHNAME10 = 0x0000004D, // abbreviated name for October
                LOCALE_SABBREVMONTHNAME11 = 0x0000004E, // abbreviated name for November
                LOCALE_SABBREVMONTHNAME12 = 0x0000004F, // abbreviated name for December
                LOCALE_SABBREVMONTHNAME13 = 0x0000100F, // abbreviated name for 13th month (if exists)

            LOCALE_SPOSITIVESIGN = 0x00000050, // positive sign
                LOCALE_SNEGATIVESIGN = 0x00000051, // negative sign
                LOCALE_IPOSSIGNPOSN = 0x00000052, // positive sign position
                LOCALE_INEGSIGNPOSN = 0x00000053, // negative sign position
                LOCALE_IPOSSYMPRECEDES = 0x00000054, // mon sym precedes pos amt
                LOCALE_IPOSSEPBYSPACE = 0x00000055, // mon sym sep by space from pos amt
                LOCALE_INEGSYMPRECEDES = 0x00000056, // mon sym precedes neg amt
                LOCALE_INEGSEPBYSPACE = 0x00000057, // mon sym sep by space from neg amt

            LOCALE_FONTSIGNATURE = 0x00000058, // font signature
                LOCALE_SISO639LANGNAME = 0x00000059, // ISO abbreviated language name
                LOCALE_SISO3166CTRYNAME = 0x0000005A, // ISO abbreviated country name

            LOCALE_IDEFAULTEBCDICCODEPAGE = 0x00001012, // default ebcdic code page
                LOCALE_IPAPERSIZE = 0x0000100A, // 1 = letter, 5 = legal, 8 = a3, 9 = a4
                LOCALE_SENGCURRNAME = 0x00001007, // english name of currency
                LOCALE_SNATIVECURRNAME = 0x00001008, // native name of currency
                LOCALE_SYEARMONTH = 0x00001006, // year month format string
                LOCALE_SSORTNAME = 0x00001013, // sort name
                LOCALE_IDIGITSUBSTITUTION = 0x00001014; // 0 = context, 1 = none, 2 = national
        }
        #endregion

        #region Common structures
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        public struct WCRANGE
        {
            public UInt16 wcLow;
            public UInt16 cGlyphs;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        public struct GLYPHSET
        {
            public int cbThis;
            public int ftAccel;
            public int cGlyphsSupported;
            public int cRanges;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        public struct WMF_SPECIAL_HEADER
        {
            public uint Key;
            public ushort Handle;
            public short Left;
            public short Top;
            public short Right;
            public short Bottom;
            public ushort Inch;
            public uint Reserved;
            public ushort Checksum;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        public class PRINTER_INFO_2
        {
            public IntPtr pServerName;
            public IntPtr pPrinterName;
            public IntPtr pShareName;
            public IntPtr pPortName;
            public IntPtr pDriverName;
            public IntPtr pComment;
            public IntPtr pLocation;
            public IntPtr pDevMode;
            public IntPtr pSepFile;
            public IntPtr pPrintProcessor;
            public IntPtr pDatatype;
            public IntPtr pParameters;
            public IntPtr pSecurityDescriptor;
            public uint Attributes;
            public uint Priority;
            public uint DefaultPriority;
            public uint StartTime;
            public uint UntilTime;
            public uint Status;
            public uint cJobs;
            public uint AveragePPM;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        public class DEVMODE
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x20)]
            public string dmDeviceName;
            public short dmSpecVersion;
            public short dmDriverVersion;
            public short dmSize;
            public short dmDriverExtra;
            public int dmFields;
            public short dmOrientation;
            public short dmPaperSize;
            public short dmPaperLength;
            public short dmPaperWidth;
            public short dmScale;
            public short dmCopies;
            public short dmDefaultSource;
            public short dmPrintQuality;
            public short dmColor;
            public short dmDuplex;
            public short dmYResolution;
            public short dmTTOption;
            public short dmCollate;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x20)]
            public string dmFormName;
            public short dmLogPixels;
            public int dmBitsPerPel;
            public int dmPelsWidth;
            public int dmPelsHeight;
            public int dmDisplayFlags;
            public int dmDisplayFrequency;
            public int dmICMMethod;
            public int dmICMIntent;
            public int dmMediaType;
            public int dmDitherType;
            public int dmICCManufacturer;
            public int dmICCModel;
            public int dmPanningWidth;
            public int dmPanningHeight;
        }

        /*public struct PRINTER_INFO_4
        {
            public string PrinterName;
            public string ServerName;
            public uint Attributes;
        }*/

        #endregion

        #region FixFpu

        /// <summary>
        /// usage:
        ///  using (FixFpu ff = new FixFpu())
        ///  { do printer stuff }
        /// or
        ///  do printer stuff
        ///  FixFpu.Doit();
        /// </summary>
        internal class FixFpu : IDisposable
        {
            #region Public static

            public static void Doit()
            {
                Win32.FixFPU();
            }

            #endregion

            #region Public

            public void Dispose()
            {
                Doit();
            }

            #endregion
        }

        #endregion // FixFpu

        #region Windows API functions
        [DllImport("winspool.drv", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetDefaultPrinter(
            StringBuilder pszBuffer,
            ref int pcchBuffer);

        public static string GetDefaultPrinter()
        {
            int pcchBuffer = 0;
            if (GetDefaultPrinter(null, ref pcchBuffer))
                return null;
            if (Marshal.GetLastWin32Error() != Win32.ERROR.ERROR_INSUFFICIENT_BUFFER)
                return null;

            StringBuilder pszBuffer = new StringBuilder(pcchBuffer);
            if (GetDefaultPrinter(pszBuffer, ref pcchBuffer))
                return pszBuffer.ToString();
            return null;
        }

        [DllImport("gdi32.dll", CharSet = CharSet.Auto)]
        public static extern uint GetGlyphIndices(
            IntPtr hdc,
            string lpsz,
            int c,
            IntPtr pgi,
            uint fl);

        [DllImport("gdi32.dll", CharSet = CharSet.Auto)]
        public static extern uint GetGlyphIndices(
            IntPtr hdc,
            string lpsz,
            int c,
            [Out] ushort[] pgi,
            uint fl);

        [DllImport("gdi32.dll")]
        public static extern int GetFontUnicodeRanges(
            IntPtr dc,
            IntPtr lpgs);

        [DllImport("gdi32.dll", CharSet = CharSet.Auto)]
        public static extern int EnumFontFamiliesEx(
            IntPtr hdc,
            ref LOGFONT_UNMANAGED lpLogfont,
            EnumFontExDelegate lpEnumFontFamExProc,
            IntPtr lParam,
            uint dwFlags);

        [DllImport("gdi32.dll", CharSet = CharSet.Auto)]
        public static extern int EnumFontFamiliesEx(
            IntPtr hdc,
            LOGFONT lpLogfont,
            EnumFontExDelegate lpEnumFontFamExProc,
            IntPtr lParam,
            uint dwFlags);

        [DllImport("gdi32.dll", CharSet = CharSet.Auto)]
        public static extern int EnumFontFamiliesEx(
            IntPtr hdc,
            [In] IntPtr lpLogfont,
            EnumFontExDelegate lpEnumFontFamExProc,
            IntPtr lParam,
            uint dwFlags);

        [DllImport("gdi32.dll", CharSet = CharSet.Auto)]
        public static extern int EnumFontFamiliesEx(
            IntPtr hdc,
            LOGFONT lpLogfont,
            EnumFontExDelegate2 lpEnumFontFamExProc,
            IntPtr lParam,
            uint dwFlags);

        [DllImport("gdi32.dll", CharSet = CharSet.Auto)]
        public static extern int GetTextFace(
            IntPtr hdc,
            int nCount,
            IntPtr lpFaceName);

        [DllImport("gdi32.DLL", CharSet = CharSet.Auto)]
        public static extern bool GetCharWidth32(
            IntPtr hDC,
            int firstChar,
            int lastChar,
            int[] charWidths);

        [DllImport("GDI32.DLL")]
        public static extern uint GetFontData(
            IntPtr hDC,
            int dwTable,
            int dwOffset,
            byte[] buffer,
            int cbData);

        [DllImport("Gdi32.DLL", CharSet = CharSet.Auto)]
        public static extern IntPtr SelectObject(
            IntPtr hdc,
            IntPtr hgdiobj);

        [DllImport("winspool.drv", CharSet = CharSet.Auto)]
        public static extern int DeviceCapabilities(
            string pDevice,
            string pPort,
            int fwCapability,
            IntPtr pOutput,
            IntPtr pDevMode);

        [DllImport("winspool.drv", CharSet = CharSet.Auto)]
        public static extern bool OpenPrinter(
            string printerName,
            ref IntPtr hPrinter,
            IntPtr pDefaults);

        [DllImport("winspool.drv", CharSet = CharSet.Auto)]
        public static extern bool ClosePrinter(
            IntPtr hPrinter);

        [DllImport("winspool.drv", CharSet = CharSet.Auto)]
        public static extern bool GetPrinter(
            IntPtr hPrinter,
            int level,
            IntPtr pPrinter,
            int cbBuf,
            ref int pcbNeeded);

        [DllImport("winspool.drv", CharSet = CharSet.Auto)]
        public static extern int DocumentProperties(
            IntPtr hWnd,
            IntPtr hPrinter,
            string pDeviceName,
            IntPtr pDevModeOutput,
            IntPtr pDevModeInput,
            int fMode);

        [DllImport("gdi32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr DeleteDC(
            IntPtr dc);

        [DllImport("gdi32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr CreateIC(
            string driverName,
            string deviceName,
            IntPtr output,
            IntPtr initData);

        [DllImport("Gdi32.DLL", CharSet = CharSet.Auto)]
        public static extern int GetDeviceCaps(
            IntPtr hDC,
            int hIndex);

        [DllImport("gdi32.dll")]
        public static extern bool DeleteEnhMetaFile(
            IntPtr hemf);

        [DllImport("gdi32.dll", CharSet = CharSet.Auto)]
        public static extern uint GetEnhMetaFileBits(
            IntPtr hemf,
            uint cbBuffer,
            byte[] buffer);

        [DllImport("gdi32.dll", CharSet = CharSet.Auto)]
        public static extern uint GetEnhMetaFileBits(
            IntPtr hemf,
            uint cbBuffer,
            IntPtr buffer);

        [DllImport("gdi32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SetEnhMetaFileBits(
            uint cbBuffer,
            byte[] buffer);

        [DllImport("gdi32.dll")]
        public static extern bool DeleteMetaFile(
            IntPtr hemf);

        [DllImport("gdi32.dll", CharSet = CharSet.Auto)]
        public static extern uint GetMetaFileBitsEx(
            IntPtr hemf,
            uint cbBuffer,
            byte[] buffer);

        [DllImport("gdi32.dll", CharSet = CharSet.Auto)]
        public static extern uint GetMetaFileBitsEx(
            IntPtr hemf,
            uint cbBuffer,
            IntPtr buffer);

        [DllImport("gdi32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SetMetaFileBitsEx(
            uint cbBuffer,
            byte[] buffer);

#if !(CLR40 || CLR45)
        // Note: under 98/ME, when using some non-MS (HP) printer drivers,
        // querying printer settings resets the FPU error handling flag,
        // as a result program crashes. This is supposed to fix it.
        // for details, see
        // http://groups.google.com/groups?hl=en&lr=&ie=UTF-8&oe=UTF-8&th=613b0d1cb8ac1e47&rnum=1
        [DllImport("msvcrt.dll")]
        private static extern int _controlfp(int IN_New, int IN_Mask);

        internal static void FixFPU()
        {
            const int _MCW_EM = 0x0008001f;
            const int _EM_INVALID = 0x00000010;
            _controlfp(_MCW_EM, _EM_INVALID);
        }
#else
        internal static void FixFPU()
        {
            // Under .NET 4.0, _controlfp calls cause an error - and we hopefully do not need it anymore.
            // But, this:
            // [DllImport("msvcrt.dll", CallingConvention = CallingConvention.Cdecl)]
            // fixes the error.
        }
#endif

        [DllImport("Gdi32.DLL", CharSet = CharSet.Auto)]
        public static extern IntPtr DeleteObject(
            IntPtr hObject);

        [DllImport("Gdi32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr CreateFontIndirect(
            LOGFONT lplf);

        [DllImport("Kernel32.dll", CharSet = CharSet.Auto)]
        public static extern int GetLocaleInfo(
            uint Locale, // locale identifier
            uint LCType, // information type
            string lpLCData, // information buffer
            int cchData); // size of buffer

        [DllImport("winspool.drv", CharSet = CharSet.Auto)]
        public static extern bool EnumPrinters(
            int flags,
            string name,
            int level,
            IntPtr pPrinterEnum,
            int cbBuf,
            out int pcbNeeded,
            out int pcReturned);

        [DllImport("Kernel32.dll")]
        public static extern uint GetLastError();
        #endregion

        #region Nested types
        public delegate int EnumFontExDelegate(
            ref ENUMLOGFONTEX lpelfe,
            IntPtr lpntme,
            uint FontType,
            int lParam);

        public delegate int EnumFontExDelegate2(
            ref ENUMLOGFONTEX lpelfe,
            ref NEWTEXTMETRICEX lpntme,
            uint FontType,
            int lParam);
        #endregion
    }
}

