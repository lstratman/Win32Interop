using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Win32Interop.Enums;

namespace Win32Interop.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct ENHMETARECORD
    {

        /// DWORD->unsigned int
        public uint iType;

        /// DWORD->unsigned int
        public uint nSize;

        /// DWORD[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.U4)]
        public uint[] dParm;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ENUMLOGFONTEXDV
    {

        /// ENUMLOGFONTEXW->tagENUMLOGFONTEXW
        public ENUMLOGFONTEX elfEnumLogfontEx;

        /// DESIGNVECTOR->tagDESIGNVECTOR
        public DESIGNVECTOR elfDesignVector;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct XFORM
    {

        /// FLOAT->float
        public float eM11;

        /// FLOAT->float
        public float eM12;

        /// FLOAT->float
        public float eM21;

        /// FLOAT->float
        public float eM22;

        /// FLOAT->float
        public float eDx;

        /// FLOAT->float
        public float eDy;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct BITMAP
    {

        /// LONG->int
        public int bmType;

        /// LONG->int
        public int bmWidth;

        /// LONG->int
        public int bmHeight;

        /// LONG->int
        public int bmWidthBytes;

        /// WORD->unsigned short
        public ushort bmPlanes;

        /// WORD->unsigned short
        public ushort bmBitsPixel;

        /// LPVOID->void*
        public IntPtr bmBits;
    }

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
	public struct LOGFONT
	{
		public int lfHeight;
		public int lfWidth;
		public int lfEscapement;
		public int lfOrientation;
		public FontWeight lfWeight;
		[MarshalAs(UnmanagedType.U1)]
		public bool lfItalic;
		[MarshalAs(UnmanagedType.U1)]
		public bool lfUnderline;
		[MarshalAs(UnmanagedType.U1)]
		public bool lfStrikeOut;
		public FontCharSet lfCharSet;
		public FontPrecision lfOutPrecision;
		public FontClipPrecision lfClipPrecision;
		public FontQuality lfQuality;
		public FontPitchAndFamily lfPitchAndFamily;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
		public string lfFaceName;
	}

    [StructLayout(LayoutKind.Sequential)]
    public struct LOGBRUSH
    {

        /// UINT->unsigned int
        public uint lbStyle;

        /// COLORREF->DWORD->unsigned int
        public uint lbColor;

        /// ULONG_PTR->unsigned int
        public uint lbHatch;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct METAFILEPICT
    {

        /// LONG->int
        public int mm;

        /// LONG->int
        public int xExt;

        /// LONG->int
        public int yExt;

        /// HMETAFILE->HMETAFILE__*
        public IntPtr hMF;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct COLORADJUSTMENT
    {

        /// WORD->unsigned short
        public ushort caSize;

        /// WORD->unsigned short
        public ushort caFlags;

        /// WORD->unsigned short
        public ushort caIlluminantIndex;

        /// WORD->unsigned short
        public ushort caRedGamma;

        /// WORD->unsigned short
        public ushort caGreenGamma;

        /// WORD->unsigned short
        public ushort caBlueGamma;

        /// WORD->unsigned short
        public ushort caReferenceBlack;

        /// WORD->unsigned short
        public ushort caReferenceWhite;

        /// SHORT->short
        public short caContrast;

        /// SHORT->short
        public short caBrightness;

        /// SHORT->short
        public short caColorfulness;

        /// SHORT->short
        public short caRedGreenTint;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PALETTEENTRY
    {

        /// BYTE->unsigned char
        public byte peRed;

        /// BYTE->unsigned char
        public byte peGreen;

        /// BYTE->unsigned char
        public byte peBlue;

        /// BYTE->unsigned char
        public byte peFlags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct BITMAPINFO
    {

        /// BITMAPINFOHEADER->tagBITMAPINFOHEADER
        public BITMAPINFOHEADER bmiHeader;

        /// RGBQUAD[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.Struct)]
        public RGBQUAD[] bmiColors;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct LOGPEN
    {

        /// UINT->unsigned int
        public uint lopnStyle;

        /// POINT->tagPOINT
        public Point lopnWidth;

        /// COLORREF->DWORD->unsigned int
        public uint lopnColor;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PIXELFORMATDESCRIPTOR
    {

        /// WORD->unsigned short
        public ushort nSize;

        /// WORD->unsigned short
        public ushort nVersion;

        /// DWORD->unsigned int
        public uint dwFlags;

        /// BYTE->unsigned char
        public byte iPixelType;

        /// BYTE->unsigned char
        public byte cColorBits;

        /// BYTE->unsigned char
        public byte cRedBits;

        /// BYTE->unsigned char
        public byte cRedShift;

        /// BYTE->unsigned char
        public byte cGreenBits;

        /// BYTE->unsigned char
        public byte cGreenShift;

        /// BYTE->unsigned char
        public byte cBlueBits;

        /// BYTE->unsigned char
        public byte cBlueShift;

        /// BYTE->unsigned char
        public byte cAlphaBits;

        /// BYTE->unsigned char
        public byte cAlphaShift;

        /// BYTE->unsigned char
        public byte cAccumBits;

        /// BYTE->unsigned char
        public byte cAccumRedBits;

        /// BYTE->unsigned char
        public byte cAccumGreenBits;

        /// BYTE->unsigned char
        public byte cAccumBlueBits;

        /// BYTE->unsigned char
        public byte cAccumAlphaBits;

        /// BYTE->unsigned char
        public byte cDepthBits;

        /// BYTE->unsigned char
        public byte cStencilBits;

        /// BYTE->unsigned char
        public byte cAuxBuffers;

        /// BYTE->unsigned char
        public byte iLayerType;

        /// BYTE->unsigned char
        public byte bReserved;

        /// DWORD->unsigned int
        public uint dwLayerMask;

        /// DWORD->unsigned int
        public uint dwVisibleMask;

        /// DWORD->unsigned int
        public uint dwDamageMask;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct RGBQUAD
    {

        /// BYTE->unsigned char
        public byte rgbBlue;

        /// BYTE->unsigned char
        public byte rgbGreen;

        /// BYTE->unsigned char
        public byte rgbRed;

        /// BYTE->unsigned char
        public byte rgbReserved;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MAT2
    {

        /// FIXED->_FIXED
        public FIXED eM11;

        /// FIXED->_FIXED
        public FIXED eM12;

        /// FIXED->_FIXED
        public FIXED eM21;

        /// FIXED->_FIXED
        public FIXED eM22;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct RGNDATA
    {

        /// RGNDATAHEADER->_RGNDATAHEADER
        public RGNDATAHEADER rdh;

        /// char[1]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
        public string Buffer;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct BITMAPINFOHEADER
    {

        /// DWORD->unsigned int
        public uint biSize;

        /// LONG->int
        public int biWidth;

        /// LONG->int
        public int biHeight;

        /// WORD->unsigned short
        public ushort biPlanes;

        /// WORD->unsigned short
        public ushort biBitCount;

        /// DWORD->unsigned int
        public uint biCompression;

        /// DWORD->unsigned int
        public uint biSizeImage;

        /// LONG->int
        public int biXPelsPerMeter;

        /// LONG->int
        public int biYPelsPerMeter;

        /// DWORD->unsigned int
        public uint biClrUsed;

        /// DWORD->unsigned int
        public uint biClrImportant;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct LOGPALETTE
    {

        /// WORD->unsigned short
        public ushort palVersion;

        /// WORD->unsigned short
        public ushort palNumEntries;

        /// PALETTEENTRY[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.Struct)]
        public PALETTEENTRY[] palPalEntry;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct POLYTEXTW
    {

        /// int
        public int x;

        /// int
        public int y;

        /// UINT->unsigned int
        public uint n;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpstr;

        /// UINT->unsigned int
        public uint uiFlags;

        /// RECT->tagRECT
        public RECT rcl;

        /// int*
        public IntPtr pdx;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct POLYTEXTA
    {

        /// int
        public int x;

        /// int
        public int y;

        /// UINT->unsigned int
        public uint n;

        /// LPCSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpstr;

        /// UINT->unsigned int
        public uint uiFlags;

        /// RECT->tagRECT
        public RECT rcl;

        /// int*
        public IntPtr pdx;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DOCINFO
    {

        /// int
        public int cbSize;

        /// LPCWSTR->WCHAR*
        public string lpszDocName;

        /// LPCWSTR->WCHAR*
        public string lpszOutput;

        /// LPCWSTR->WCHAR*
        public string lpszDatatype;

        /// DWORD->unsigned int
        public uint fwType;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct OUTLINETEXTMETRIC
    {

        /// UINT->unsigned int
        public uint otmSize;

        /// TEXTMETRICW->tagTEXTMETRICW
        public TEXTMETRIC otmTextMetrics;

        /// BYTE->unsigned char
        public byte otmFiller;

        /// PANOSE->tagPANOSE
        public PANOSE otmPanoseNumber;

        /// UINT->unsigned int
        public uint otmfsSelection;

        /// UINT->unsigned int
        public uint otmfsType;

        /// int
        public int otmsCharSlopeRise;

        /// int
        public int otmsCharSlopeRun;

        /// int
        public int otmItalicAngle;

        /// UINT->unsigned int
        public uint otmEMSquare;

        /// int
        public int otmAscent;

        /// int
        public int otmDescent;

        /// UINT->unsigned int
        public uint otmLineGap;

        /// UINT->unsigned int
        public uint otmsCapEmHeight;

        /// UINT->unsigned int
        public uint otmsXHeight;

        /// RECT->tagRECT
        public RECT otmrcFontBox;

        /// int
        public int otmMacAscent;

        /// int
        public int otmMacDescent;

        /// UINT->unsigned int
        public uint otmMacLineGap;

        /// UINT->unsigned int
        public uint otmusMinimumPPEM;

        /// POINT->tagPOINT
        public Point otmptSubscriptSize;

        /// POINT->tagPOINT
        public Point otmptSubscriptOffset;

        /// POINT->tagPOINT
        public Point otmptSuperscriptSize;

        /// POINT->tagPOINT
        public Point otmptSuperscriptOffset;

        /// UINT->unsigned int
        public uint otmsStrikeoutSize;

        /// int
        public int otmsStrikeoutPosition;

        /// int
        public int otmsUnderscoreSize;

        /// int
        public int otmsUnderscorePosition;

        /// PSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string otmpFamilyName;

        /// PSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string otmpFaceName;

        /// PSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string otmpStyleName;

        /// PSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string otmpFullName;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct GCP_RESULTS
    {

        /// DWORD->unsigned int
        public uint lStructSize;

        /// LPWSTR->WCHAR*
		[MarshalAs(UnmanagedType.LPTStr)]
        public string lpOutString;

        /// UINT*
        public IntPtr lpOrder;

        /// int*
        public IntPtr lpDx;

        /// int*
        public IntPtr lpCaretPos;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpClass;

        /// LPWSTR->WCHAR*
        public string lpGlyphs;

        /// UINT->unsigned int
        public uint nGlyphs;

        /// int
        public int nMaxFit;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ABCFLOAT
    {

        /// FLOAT->float
        public float abcfA;

        /// FLOAT->float
        public float abcfB;

        /// FLOAT->float
        public float abcfC;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct HANDLETABLE
    {

        /// HGDIOBJ[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.SysUInt)]
        public IntPtr[] objectHandle;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CHARSETINFO
    {

        /// UINT->unsigned int
        public uint ciCharset;

        /// UINT->unsigned int
        public uint ciACP;

        /// FONTSIGNATURE->tagFONTSIGNATURE
        public FONTSIGNATURE fs;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct GLYPHSET
    {

        /// DWORD->unsigned int
        public uint cbThis;

        /// DWORD->unsigned int
        public uint flAccel;

        /// DWORD->unsigned int
        public uint cGlyphsSupported;

        /// DWORD->unsigned int
        public uint cRanges;

        /// WCRANGE[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.Struct)]
        public WCRANGE[] ranges;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ENHMETAHEADER
    {

        /// DWORD->unsigned int
        public uint iType;

        /// DWORD->unsigned int
        public uint nSize;

        /// RECTL->_RECTL
        public RECTL rclBounds;

        /// RECTL->_RECTL
        public RECTL rclFrame;

        /// DWORD->unsigned int
        public uint dSignature;

        /// DWORD->unsigned int
        public uint nVersion;

        /// DWORD->unsigned int
        public uint nBytes;

        /// DWORD->unsigned int
        public uint nRecords;

        /// WORD->unsigned short
        public ushort nHandles;

        /// WORD->unsigned short
        public ushort sReserved;

        /// DWORD->unsigned int
        public uint nDescription;

        /// DWORD->unsigned int
        public uint offDescription;

        /// DWORD->unsigned int
        public uint nPalEntries;

        /// SIZEL->SIZE->tagSIZE
        public SIZE szlDevice;

        /// SIZEL->SIZE->tagSIZE
        public SIZE szlMillimeters;

        /// DWORD->unsigned int
        public uint cbPixelFormat;

        /// DWORD->unsigned int
        public uint offPixelFormat;

        /// DWORD->unsigned int
        public uint bOpenGL;

        /// SIZEL->SIZE->tagSIZE
        public SIZE szlMicrometers;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct METARECORD
    {

        /// DWORD->unsigned int
        public uint rdSize;

        /// WORD->unsigned short
        public ushort rdFunction;

        /// WORD[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.U2)]
        public ushort[] rdParm;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct FONTSIGNATURE
    {

        /// DWORD[4]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.U4)]
        public uint[] fsUsb;

        /// DWORD[2]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.U4)]
        public uint[] fsCsb;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct RASTERIZER_STATUS
    {

        /// short
        public short nSize;

        /// short
        public short wFlags;

        /// short
        public short nLanguageID;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct LOGCOLORSPACE
    {

        /// DWORD->unsigned int
        public uint lcsSignature;

        /// DWORD->unsigned int
        public uint lcsVersion;

        /// DWORD->unsigned int
        public uint lcsSize;

        /// LCSCSTYPE->LONG->int
        public int lcsCSType;

        /// LCSGAMUTMATCH->LONG->int
        public int lcsIntent;

        /// CIEXYZTRIPLE->tagICEXYZTRIPLE
        public ICEXYZTRIPLE lcsEndpoints;

        /// DWORD->unsigned int
        public uint lcsGammaRed;

        /// DWORD->unsigned int
        public uint lcsGammaGreen;

        /// DWORD->unsigned int
        public uint lcsGammaBlue;

        /// WCHAR[260]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
        public string lcsFilename;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ABC
    {

        /// int
        public int abcA;

        /// UINT->unsigned int
        public uint abcB;

        /// int
        public int abcC;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct KERNINGPAIR
    {

        /// WORD->unsigned short
        public ushort wFirst;

        /// WORD->unsigned short
        public ushort wSecond;

        /// int
        public int iKernAmount;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct GLYPHMETRICS
    {

        /// UINT->unsigned int
        public uint gmBlackBoxX;

        /// UINT->unsigned int
        public uint gmBlackBoxY;

        /// POINT->tagPOINT
        public Point gmptGlyphOrigin;

        /// short
        public short gmCellIncX;

        /// short
        public short gmCellIncY;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
    public struct ENUMLOGFONTEX
    {

        /// LOGFONTW->tagLOGFONTW
        public LOGFONT elfLogFont;

        /// WCHAR[64]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
        public string elfFullName;

        /// WCHAR[32]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string elfStyle;

        /// WCHAR[32]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string elfScript;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DESIGNVECTOR
    {

        /// DWORD->unsigned int
        public uint dvReserved;

        /// DWORD->unsigned int
        public uint dvNumAxes;

        /// LONG[16]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I4)]
        public int[] dvValues;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct FIXED
    {

        /// WORD->unsigned short
        public ushort fract;

        /// short
        public short value;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct RGNDATAHEADER
    {

        /// DWORD->unsigned int
        public uint dwSize;

        /// DWORD->unsigned int
        public uint iType;

        /// DWORD->unsigned int
        public uint nCount;

        /// DWORD->unsigned int
        public uint nRgnSize;

        /// RECT->tagRECT
        public RECT rcBound;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PANOSE
    {

        /// BYTE->unsigned char
        public byte bFamilyType;

        /// BYTE->unsigned char
        public byte bSerifStyle;

        /// BYTE->unsigned char
        public byte bWeight;

        /// BYTE->unsigned char
        public byte bProportion;

        /// BYTE->unsigned char
        public byte bContrast;

        /// BYTE->unsigned char
        public byte bStrokeVariation;

        /// BYTE->unsigned char
        public byte bArmStyle;

        /// BYTE->unsigned char
        public byte bLetterform;

        /// BYTE->unsigned char
        public byte bMidline;

        /// BYTE->unsigned char
        public byte bXHeight;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct RECTL
    {

        /// LONG->int
        public int left;

        /// LONG->int
        public int top;

        /// LONG->int
        public int right;

        /// LONG->int
        public int bottom;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ICEXYZTRIPLE
    {

        /// CIEXYZ->tagCIEXYZ
        public CIEXYZ ciexyzRed;

        /// CIEXYZ->tagCIEXYZ
        public CIEXYZ ciexyzGreen;

        /// CIEXYZ->tagCIEXYZ
        public CIEXYZ ciexyzBlue;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct WCRANGE
    {

        /// WCHAR->wchar_t->unsigned short
        public ushort wcLow;

        /// USHORT->unsigned short
        public ushort cGlyphs;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CIEXYZ
    {

        /// FXPT2DOT30->int
        public int ciexyzX;

        /// FXPT2DOT30->int
        public int ciexyzY;

        /// FXPT2DOT30->int
        public int ciexyzZ;
    }

	/// <summary>
	/// The ABCFLOAT structure contains the A, B, and C widths of a font character.
	/// </summary>
	/// <remarks>
	/// <para>
	/// The A, B, and C widths are measured along the base line of the font.
	/// </para>
	/// <para>
	/// The character increment (total width) of a character is the sum of the A, B, and C spaces. Either the A or the C space can be negative to indicate underhangs or overhangs. 
	/// </para>
	/// </remarks>
	[StructLayout(LayoutKind.Sequential)]
	public struct ABCFloat
	{
		/// <summary>
		/// Specifies the A spacing of the character. The A spacing is the distance to add to the current position before drawing the character glyph.
		/// </summary>
		public float abcfA;
		/// <summary>
		/// Specifies the B spacing of the character. The B spacing is the width of the drawn portion of the character glyph.
		/// </summary>
		public float abcfB;
		/// <summary>
		/// Specifies the C spacing of the character. The C spacing is the distance to add to the current position to provide white space to the right of the character glyph.
		/// </summary>
		public float abcfC;
	}
}
