using System;
using System.Runtime.InteropServices;
using System.Text;
using Win32Interop.Structs;

// ReSharper disable CheckNamespace

namespace Win32Interop.Methods
// ReSharper restore CheckNamespace
{
	// ReSharper disable InconsistentNaming
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate int ICMENUMPROC(StringBuilder param0, IntPtr param1);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate int ENHMFENUMPROC([In] IntPtr hdc, [In] IntPtr lpht, [In] ref ENHMETARECORD lpmr, int hHandles, [In] IntPtr data);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate int ABORTPROC([In] IntPtr param0, int param1);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate int MFENUMPROC([In] IntPtr hdc, [In] IntPtr lpht, [In] ref METARECORD lpMR, int nObj, [In] IntPtr param);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate int GOBJENUMPROC(IntPtr param0, IntPtr param1);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate void LINEDDAPROC(int param0, int param1, IntPtr param2);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate int OLDFONTENUMPROC(ref LOGFONT param0, ref TEXTMETRIC param1, uint param2, IntPtr param3);

	public class Gdi32
	{
		[DllImport("gdi32.dll", EntryPoint = "GetEnhMetaFilePaletteEntries")]
		public static extern uint GetEnhMetaFilePaletteEntries([In] IntPtr hemf, uint nNumEntries, IntPtr lpPaletteEntries);

		[DllImport("gdi32.dll", EntryPoint = "CreateScalableFontResource")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool CreateScalableFontResource(uint fdwHidden, string lpszFont, string lpszFile, string lpszPath);

		[DllImport("gdi32.dll", EntryPoint = "GetEnhMetaFileDescription")]
		public static extern uint GetEnhMetaFileDescription([In] IntPtr hemf, uint cchBuffer, [Out] StringBuilder lpDescription);

		[DllImport("gdi32.dll", EntryPoint = "CreateEllipticRgnIndirect")]
		public static extern IntPtr CreateEllipticRgnIndirect([In] ref RECT lprect);

		[DllImport("gdi32.dll", EntryPoint = "RemoveFontMemResourceEx")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool RemoveFontMemResourceEx([In] IntPtr h);

		[DllImport("gdi32.dll", EntryPoint = "GetSystemPaletteEntries")]
		public static extern uint GetSystemPaletteEntries([In] IntPtr hdc, uint iStart, uint cEntries, IntPtr pPalEntries);

		[DllImport("gdi32.dll", EntryPoint = "CreateDiscardableBitmap")]
		public static extern IntPtr CreateDiscardableBitmap([In] IntPtr hdc, int cx, int cy);

		[DllImport("gdi32.dll", EntryPoint = "CreateDIBPatternBrushPt")]
		public static extern IntPtr CreateDIBPatternBrushPt([In] IntPtr lpPackedDIB, uint iUsage);

		[DllImport("gdi32.dll", EntryPoint = "GetOutlineTextMetrics")]
		public static extern uint GetOutlineTextMetrics([In] IntPtr hdc, uint cjCopy, IntPtr potm);

		[DllImport("gdi32.dll", EntryPoint = "GetNearestPaletteIndex")]
		public static extern uint GetNearestPaletteIndex([In] IntPtr h, uint color);

		[DllImport("gdi32.dll", EntryPoint = "GetCharacterPlacement")]
		public static extern uint GetCharacterPlacement(
			[In] IntPtr hdc, [In] string lpString, int nCount, int nMexExtent, ref GCP_RESULTS lpResults, uint dwFlags);

		[DllImport("gdi32.dll", EntryPoint = "GetCharABCWidthsFloat")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetCharABCWidthsFloat(IntPtr hdc, uint iFirstChar, uint iLastChar, [Out] ABCFloat[] lpABCF);

		[DllImport("gdi32.dll", EntryPoint = "GetAspectRatioFilterEx")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetAspectRatioFilterEx([In] IntPtr hdc, [Out] out SIZE lpsize);

		[DllImport("gdi32.dll", EntryPoint = "CreateCompatibleBitmap")]
		public static extern IntPtr CreateCompatibleBitmap([In] IntPtr hdc, int cx, int cy);

		[DllImport("gdi32.dll", EntryPoint = "SetTextCharacterExtra")]
		public static extern int SetTextCharacterExtra([In] IntPtr hdc, int extra);

		[DllImport("gdi32.dll", EntryPoint = "RemoveFontResourceEx")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool RemoveFontResourceEx([In] string name, uint fl, IntPtr pdv);

		[DllImport("gdi32.dll", EntryPoint = "PlayEnhMetaFileRecord")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool PlayEnhMetaFileRecord(
			[In] IntPtr hdc, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 3)] HANDLETABLE[] pht, [In] ref ENHMETARECORD pmr,
			uint cht);

		[DllImport("gdi32.dll", EntryPoint = "GetTextExtentPoint32")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetTextExtentPoint32([In] IntPtr hdc, [In] string lpString, int c, [Out] out SIZE psizl);

		[DllImport("gdi32.dll", EntryPoint = "GetTextExtentExPoint")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetTextExtentExPoint(
			[In] IntPtr hdc, [In] string lpszString, int cchString, int nMaxExtent, IntPtr lpnFit, IntPtr lpnDx, [Out] out SIZE lpSize);

		[DllImport("gdi32.dll", EntryPoint = "GetTextExtentExPointI")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetTextExtentExPointI(
			[In] IntPtr hdc, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U2, SizeParamIndex = 2)] ushort[] lpwszString, int cwchString, int nMaxExtent,
			IntPtr lpnFit, IntPtr lpnDx, [Out] out SIZE lpSize);

		[DllImport("gdi32.dll", EntryPoint = "GetTextCharacterExtra")]
		public static extern int GetTextCharacterExtra([In] IntPtr hdc);

		[DllImport("gdi32.dll", EntryPoint = "CreateRectRgnIndirect")]
		public static extern IntPtr CreateRectRgnIndirect([In] ref RECT lprect);

		[DllImport("gdi32.dll", EntryPoint = "CreateHalftonePalette")]
		public static extern IntPtr CreateHalftonePalette([In] IntPtr hdc);

		[DllImport("gdi32.dll", EntryPoint = "CreateFontIndirectEx")]
		public static extern IntPtr CreateFontIndirectEx([In] ref ENUMLOGFONTEXDV param0);

		[DllImport("gdi32.dll", EntryPoint = "CreateDIBPatternBrush")]
		public static extern IntPtr CreateDIBPatternBrush([In] IntPtr h, uint iUsage);

		[DllImport("gdi32.dll", EntryPoint = "TranslateCharsetInfo")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool TranslateCharsetInfo(ref uint lpSrc, [Out] out CHARSETINFO lpCs, uint dwFlags);

		[DllImport("gdi32.dll", EntryPoint = "SetTextJustification")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetTextJustification([In] IntPtr hdc, int extra, int count);

		[DllImport("gdi32.dll", EntryPoint = "SetBitmapDimensionEx")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetBitmapDimensionEx([In] IntPtr hbm, int w, int h, IntPtr lpsz);

		[DllImport("gdi32.dll", EntryPoint = "ModifyWorldTransform")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool ModifyWorldTransform([In] IntPtr hdc, [In] IntPtr lpxf, uint mode);

		[DllImport("gdi32.dll", EntryPoint = "GetFontUnicodeRanges")]
		public static extern uint GetFontUnicodeRanges([In] IntPtr hdc, IntPtr lpgs);

		[DllImport("gdi32.dll", EntryPoint = "GetEnhMetaFileHeader")]
		public static extern uint GetEnhMetaFileHeader([In] IntPtr hemf, uint nSize, IntPtr lpEnhMetaHeader);

		[DllImport("gdi32.dll", EntryPoint = "GetCurrentPositionEx")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetCurrentPositionEx([In] IntPtr hdc, [Out] out Point lppt);

		[DllImport("gdi32.dll", EntryPoint = "GetBitmapDimensionEx")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetBitmapDimensionEx([In] IntPtr hbit, [Out] out SIZE lpsize);

		[DllImport("gdi32.dll", EntryPoint = "CreatePolyPolygonRgn")]
		public static extern IntPtr CreatePolyPolygonRgn([In] ref Point pptl, [In] ref int pc, int cPoly, int iMode);

		[DllImport("gdi32.dll", EntryPoint = "CreateBitmapIndirect")]
		public static extern IntPtr CreateBitmapIndirect([In] ref BITMAP pbm);

		[DllImport("gdi32.dll", EntryPoint = "AddFontMemResourceEx")]
		public static extern IntPtr AddFontMemResourceEx([In] IntPtr pFileView, uint cjSize, IntPtr pvResrved, [In] ref uint pNumFonts);

		[DllImport("gdi32.dll", EntryPoint = "SetSystemPaletteUse")]
		public static extern uint SetSystemPaletteUse([In] IntPtr hdc, uint use);

		[DllImport("gdi32.dll", EntryPoint = "RemoveFontResource")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool RemoveFontResource([In] string lpFileName);

		[DllImport("gdi32.dll", EntryPoint = "OffsetViewportOrgEx")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool OffsetViewportOrgEx([In] IntPtr hdc, int x, int y, IntPtr lppt);

		[DllImport("gdi32.dll", EntryPoint = "GetTextExtentPoint")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetTextExtentPoint([In] IntPtr hdc, [In] string lpString, int c, [Out] out SIZE lpsz);

		[DllImport("gdi32.dll", EntryPoint = "GetTextExtentPointI")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetTextExtentPointI(
			[In] IntPtr hdc, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U2, SizeParamIndex = 2)] ushort[] pgiIn, int cgi, [Out] out SIZE psize);

		[DllImport("gdi32.dll", EntryPoint = "GetSystemPaletteUse")]
		public static extern uint GetSystemPaletteUse([In] IntPtr hdc);

		[DllImport("gdi32.dll", EntryPoint = "GetFontLanguageInfo")]
		public static extern uint GetFontLanguageInfo([In] IntPtr hdc);

		[DllImport("gdi32.dll", EntryPoint = "EnumFontFamiliesEx")]
		public static extern int EnumFontFamiliesEx(
			[In] IntPtr hdc, [In] ref LOGFONT lpLogfont, OLDFONTENUMPROC lpProc, [MarshalAs(UnmanagedType.SysInt)] int lParam, uint dwFlags);

		[DllImport("gdi32.dll", EntryPoint = "DescribePixelFormat")]
		public static extern int DescribePixelFormat([In] IntPtr hdc, int iPixelFormat, uint nBytes, IntPtr ppfd);

		[DllImport("gdi32.dll", EntryPoint = "CreateFontIndirect")]
		public static extern IntPtr CreateFontIndirect([In] ref LOGFONT lplf);

		[DllImport("gdi32.dll", EntryPoint = "CreateBrushIndirect")]
		public static extern IntPtr CreateBrushIndirect([In] ref LOGBRUSH plbrush);

		[DllImport("gdi32.dll", EntryPoint = "ColorCorrectPalette")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool ColorCorrectPalette([In] IntPtr hdc, [In] IntPtr hPal, uint deFirst, uint num);

		[DllImport("gdi32.dll", EntryPoint = "SetWinMetaFileBits")]
		public static extern IntPtr SetWinMetaFileBits(uint nSize, [In] IntPtr lpMeta16Data, [In] IntPtr hdcRef, [In] IntPtr lpMFP);

		[DllImport("gdi32.dll", EntryPoint = "SetEnhMetaFileBits")]
		public static extern IntPtr SetEnhMetaFileBits(uint nSize, [In] IntPtr pb);

		[DllImport("gdi32.dll", EntryPoint = "SetDeviceGammaRamp")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetDeviceGammaRamp([In] IntPtr hdc, [In] IntPtr lpRamp);

		[DllImport("gdi32.dll", EntryPoint = "SetColorAdjustment")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetColorAdjustment([In] IntPtr hdc, [In] ref COLORADJUSTMENT lpca);

		[DllImport("gdi32.dll", EntryPoint = "ScaleViewportExtEx")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool ScaleViewportExtEx([In] IntPtr hdc, int xn, int dx, int yn, int yd, IntPtr lpsz);

		[DllImport("gdi32.dll", EntryPoint = "PlayMetaFileRecord")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool PlayMetaFileRecord(
			[In] IntPtr hdc, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 3)] HANDLETABLE[] lpHandleTable,
			[In] ref METARECORD lpMR, uint noObjs);

		[DllImport("gdi32.dll", EntryPoint = "GetWinMetaFileBits")]
		public static extern uint GetWinMetaFileBits([In] IntPtr hemf, uint cbData16, IntPtr pData16, int iMapMode, [In] IntPtr hdcRef);

		[DllImport("gdi32.dll", EntryPoint = "GetTextCharsetInfo")]
		public static extern int GetTextCharsetInfo([In] IntPtr hdc, IntPtr lpSig, uint dwFlags);

		[DllImport("gdi32.dll", EntryPoint = "GetEnhMetaFileBits")]
		public static extern uint GetEnhMetaFileBits([In] IntPtr hEMF, uint nSize, IntPtr lpData);

		[DllImport("gdi32.dll", EntryPoint = "GetDeviceGammaRamp")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetDeviceGammaRamp([In] IntPtr hdc, IntPtr lpRamp);

		[DllImport("gdi32.dll", EntryPoint = "GetColorAdjustment")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetColorAdjustment([In] IntPtr hdc, [Out] out COLORADJUSTMENT lpca);

		[DllImport("gdi32.dll", EntryPoint = "GetCharWidthFloat")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetCharWidthFloat([In] IntPtr hdc, uint iFirst, uint iLast, IntPtr lpBuffer);

		[DllImport("gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
		public static extern IntPtr CreateRoundRectRgn(int x1, int y1, int x2, int y2, int w, int h);

		[DllImport("gdi32.dll", EntryPoint = "CreatePatternBrush")]
		public static extern IntPtr CreatePatternBrush([In] IntPtr hbm);

		[DllImport("gdi32.dll", EntryPoint = "CreateEnhMetaFile")]
		public static extern IntPtr CreateEnhMetaFile([In] IntPtr hdc, [In] string lpFilename, [In] IntPtr lprc, [In] string lpDesc);

		[DllImport("gdi32.dll", EntryPoint = "CreateCompatibleDC")]
		public static extern IntPtr CreateCompatibleDC([In] IntPtr hdc);

		[DllImport("gdi32.dll", EntryPoint = "ColorMatchToTarget")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool ColorMatchToTarget([In] IntPtr hdc, [In] IntPtr hdcTarget, uint action);

		[DllImport("gdi32.dll", EntryPoint = "CheckColorsInGamut")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool CheckColorsInGamut([In] IntPtr hdc, [In] IntPtr lpRGBTriple, IntPtr dlpBuffer, uint nCount);

		[DllImport("gdi32.dll", EntryPoint = "AddFontResourceEx")]
		public static extern int AddFontResourceEx([In] string name, uint fl, IntPtr res);

		[DllImport("gdi32.dll", EntryPoint = "StrokeAndFillPath")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool StrokeAndFillPath([In] IntPtr hdc);

		[DllImport("gdi32.dll", EntryPoint = "SetWorldTransform")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetWorldTransform([In] IntPtr hdc, [In] ref XFORM lpxf);

		[DllImport("gdi32.dll", EntryPoint = "SetStretchBltMode")]
		public static extern int SetStretchBltMode([In] IntPtr hdc, int mode);

		[DllImport("gdi32.dll", EntryPoint = "SetPaletteEntries")]
		public static extern uint SetPaletteEntries(
			[In] IntPtr hpal, uint iStart, uint cEntries,
			[MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 2)] PALETTEENTRY[] pPalEntries);

		[DllImport("gdi32.dll", EntryPoint = "SetMetaFileBitsEx")]
		public static extern IntPtr SetMetaFileBitsEx(uint cbBuffer, [In] IntPtr lpData);

		[DllImport("gdi32.dll", EntryPoint = "SetDIBitsToDevice")]
		public static extern int SetDIBitsToDevice(
			[In] IntPtr hdc, int xDest, int yDest, uint w, uint h, int xSrc, int ySrc, uint StartScan, uint cLines, [In] IntPtr lpvBits, [In] ref BITMAPINFO lpbmi,
			uint ColorUse);

		[DllImport("gdi32.dll", EntryPoint = "OffsetWindowOrgEx")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool OffsetWindowOrgEx([In] IntPtr hdc, int x, int y, IntPtr lppt);

		[DllImport("gdi32.dll", EntryPoint = "IntersectClipRect")]
		public static extern int IntersectClipRect([In] IntPtr hdc, int left, int top, int right, int bottom);

		[DllImport("gdi32.dll", EntryPoint = "GetWorldTransform")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetWorldTransform([In] IntPtr hdc, [Out] out XFORM lpxf);

		[DllImport("gdi32.dll", EntryPoint = "GetStretchBltMode")]
		public static extern int GetStretchBltMode([In] IntPtr hdc);

		[DllImport("gdi32.dll", EntryPoint = "GetRasterizerCaps")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetRasterizerCaps(IntPtr lpraststat, uint cjBytes);

		[DllImport("gdi32.dll", EntryPoint = "GetPaletteEntries")]
		public static extern uint GetPaletteEntries([In] IntPtr hpal, uint iStart, uint cEntries, IntPtr pPalEntries);

		[DllImport("gdi32.dll", EntryPoint = "GetMetaFileBitsEx")]
		public static extern uint GetMetaFileBitsEx([In] IntPtr hMF, uint cbBuffer, IntPtr lpData);

		[DllImport("gdi32.dll", EntryPoint = "GetLogColorSpace")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetLogColorSpace([In] IntPtr hColorSpace, out LOGCOLORSPACE lpBuffer, uint nSize);

		[DllImport("gdi32.dll", EntryPoint = "GetCharABCWidths")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetCharABCWidths([In] IntPtr hdc, uint wFirst, uint wLast, out ABC lpABC);

		[DllImport("gdi32.dll", EntryPoint = "GetCharABCWidthsI")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetCharABCWidthsI([In] IntPtr hdc, uint giFirst, uint cgi, [In] IntPtr pgi, IntPtr pabc);

		[DllImport("gdi32.dll", EntryPoint = "EnumFontFamilies")]
		public static extern int EnumFontFamilies([In] IntPtr hdc, [In] string lpLogfont, OLDFONTENUMPROC lpProc, [MarshalAs(UnmanagedType.SysInt)] int lParam);

		[DllImport("gdi32.dll", EntryPoint = "DeleteEnhMetaFile")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool DeleteEnhMetaFile([In] IntPtr hmf);

		[DllImport("gdi32.dll", EntryPoint = "CreatePenIndirect")]
		public static extern IntPtr CreatePenIndirect([In] ref LOGPEN plpen);

		[DllImport("gdi32.dll", EntryPoint = "CreateEllipticRgn")]
		public static extern IntPtr CreateEllipticRgn(int x1, int y1, int x2, int y2);

		[DllImport("gdi32.dll", EntryPoint = "CreateColorSpace")]
		public static extern IntPtr CreateColorSpace([In] ref LOGCOLORSPACE lplcs);

		[DllImport("gdi32.dll", EntryPoint = "ChoosePixelFormat")]
		public static extern int ChoosePixelFormat([In] IntPtr hdc, [In] ref PIXELFORMATDESCRIPTOR ppfd);

		[DllImport("gdi32.dll", EntryPoint = "UpdateICMRegKey")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool UpdateICMRegKey(uint reserved, [In] string lpszCMID, [In] string lpszFileName, uint command);

		[DllImport("gdi32.dll", EntryPoint = "SetViewportOrgEx")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetViewportOrgEx([In] IntPtr hdc, int x, int y, IntPtr lppt);

		[DllImport("gdi32.dll", EntryPoint = "SetViewportExtEx")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetViewportExtEx([In] IntPtr hdc, int x, int y, IntPtr lpsz);

		[DllImport("gdi32.dll", EntryPoint = "SetDIBColorTable")]
		public static extern uint SetDIBColorTable(
			[In] IntPtr hdc, uint iStart, uint cEntries, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 2)] RGBQUAD[] prgbq);

		[DllImport("gdi32.dll", EntryPoint = "ScaleWindowExtEx")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool ScaleWindowExtEx([In] IntPtr hdc, int xn, int xd, int yn, int yd, IntPtr lpsz);

		[DllImport("gdi32.dll", EntryPoint = "GetViewportOrgEx")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetViewportOrgEx([In] IntPtr hdc, [Out] out Point lppoint);

		[DllImport("gdi32.dll", EntryPoint = "GetViewportExtEx")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetViewportExtEx([In] IntPtr hdc, [Out] out SIZE lpsize);

		[DllImport("gdi32.dll", EntryPoint = "GetKerningPairs")]
		public static extern uint GetKerningPairs([In] IntPtr hdc, uint nPairs, out KERNINGPAIR[] lpKernPair);

		[DllImport("gdi32.dll", EntryPoint = "GetGlyphOutline")]
		public static extern uint GetGlyphOutline(
			[In] IntPtr hdc, uint uChar, uint fuFormat, [Out] out GLYPHMETRICS lpgm, uint cjBuffer, IntPtr pvBuffer, [In] ref MAT2 lpmat2);

		[DllImport("gdi32.dll", EntryPoint = "GetGlyphIndices")]
		public static extern uint GetGlyphIndices([In] IntPtr hdc, [In] string lpstr, int c, out ushort[] pgi, uint fl);

		[DllImport("gdi32.dll", EntryPoint = "GetDIBColorTable")]
		public static extern uint GetDIBColorTable([In] IntPtr hdc, uint iStart, uint cEntries, IntPtr prgbq);

		[DllImport("gdi32.dll", EntryPoint = "GetCurrentObject")]
		public static extern IntPtr GetCurrentObject([In] IntPtr hdc, uint type);

		[DllImport("gdi32.dll", EntryPoint = "GdiSetBatchLimit")]
		public static extern uint GdiSetBatchLimit(uint dw);

		[DllImport("gdi32.dll", EntryPoint = "GdiGetBatchLimit")]
		public static extern uint GdiGetBatchLimit();

		[DllImport("gdi32.dll", EntryPoint = "ExtSelectClipRgn")]
		public static extern int ExtSelectClipRgn([In] IntPtr hdc, [In] IntPtr hrgn, int mode);

		[DllImport("gdi32.dll", EntryPoint = "EnumICMProfiles")]
		public static extern int EnumICMProfiles([In] IntPtr hdc, ICMENUMPROC proc, [MarshalAs(UnmanagedType.SysInt)] int param);

		[DllImport("gdi32.dll", EntryPoint = "DeleteColorSpace")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool DeleteColorSpace([In] IntPtr hcs);

		[DllImport("gdi32.dll", EntryPoint = "CreateSolidBrush")]
		public static extern IntPtr CreateSolidBrush(uint color);

		[DllImport("gdi32.dll", EntryPoint = "CreatePolygonRgn")]
		public static extern IntPtr CreatePolygonRgn(
			[MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 1)] Point[] pptl, int cPoint, int iMode);

		[DllImport("gdi32.dll", EntryPoint = "CreateHatchBrush")]
		public static extern IntPtr CreateHatchBrush(int iHatch, uint color);

		[DllImport("gdi32.dll", EntryPoint = "CreateDIBSection")]
		public static extern IntPtr CreateDIBSection([In] IntPtr hdc, [In] ref BITMAPINFO lpbmi, uint usage, ref IntPtr ppvBits, [In] IntPtr hSection, uint offset);

		[DllImport("gdi32.dll", EntryPoint = "CopyEnhMetaFile")]
		public static extern IntPtr CopyEnhMetaFile([In] IntPtr hEnh, [In] string lpFileName);

		[DllImport("gdi32.dll", EntryPoint = "CombineTransform")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool CombineTransform([Out] out XFORM lpxfOut, [In] ref XFORM lpxf1, [In] ref XFORM lpxf2);

		[DllImport("gdi32.dll", EntryPoint = "CloseEnhMetaFile")]
		public static extern IntPtr CloseEnhMetaFile([In] IntPtr hdc);

		[DllImport("gdi32.dll", EntryPoint = "AddFontResource")]
		public static extern int AddFontResource([In] string param0);

		[DllImport("gdi32.dll", EntryPoint = "UnrealizeObject")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool UnrealizeObject([In] IntPtr h);

		[DllImport("gdi32.dll", EntryPoint = "SetPolyFillMode")]
		public static extern int SetPolyFillMode([In] IntPtr hdc, int mode);

		[DllImport("gdi32.dll", EntryPoint = "SetGraphicsMode")]
		public static extern int SetGraphicsMode([In] IntPtr hdc, int iMode);

		[DllImport("gdi32.dll", EntryPoint = "SetDCBrushColor")]
		public static extern uint SetDCBrushColor([In] IntPtr hdc, uint color);

		[DllImport("gdi32.dll", EntryPoint = "SetArcDirection")]
		public static extern int SetArcDirection([In] IntPtr hdc, int dir);

		[DllImport("gdi32.dll", EntryPoint = "PlayEnhMetaFile")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool PlayEnhMetaFile([In] IntPtr hdc, [In] IntPtr hmf, [In] ref RECT lprect);

		[DllImport("gdi32.dll", EntryPoint = "GetTextMetrics")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetTextMetrics([In] IntPtr hdc, [Out] out TEXTMETRIC lptm);

		[DllImport("gdi32.dll", EntryPoint = "GetPolyFillMode")]
		public static extern int GetPolyFillMode([In] IntPtr hdc);

		[DllImport("gdi32.dll", EntryPoint = "GetNearestColor")]
		public static extern uint GetNearestColor([In] IntPtr hdc, uint color);

		[DllImport("gdi32.dll", EntryPoint = "GetGraphicsMode")]
		public static extern int GetGraphicsMode([In] IntPtr hdc);

		[DllImport("gdi32.dll", EntryPoint = "GetEnhMetaFile")]
		public static extern IntPtr GetEnhMetaFile([In] string lpName);

		[DllImport("gdi32.dll", EntryPoint = "GetDCBrushColor")]
		public static extern uint GetDCBrushColor([In] IntPtr hdc);

		[DllImport("gdi32.dll", EntryPoint = "GetCharWidth32")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetCharWidth32([In] IntPtr hdc, uint iFirst, uint iLast, out int[] lpBuffer);

		[DllImport("gdi32.dll", EntryPoint = "GetArcDirection")]
		public static extern int GetArcDirection([In] IntPtr hdc);

		[DllImport("gdi32.dll", EntryPoint = "ExtCreateRegion")]
		public static extern IntPtr ExtCreateRegion([In] IntPtr lpx, uint nCount, [In] IntPtr lpData);

		[DllImport("gdi32.dll", EntryPoint = "ExcludeClipRect")]
		public static extern int ExcludeClipRect([In] IntPtr hdc, int left, int top, int right, int bottom);

		[DllImport("gdi32.dll", EntryPoint = "EnumEnhMetaFile")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool EnumEnhMetaFile([In] IntPtr hdc, [In] IntPtr hmf, ENHMFENUMPROC proc, [In] IntPtr param, [In] IntPtr lpRect);

		[DllImport("gdi32.dll", EntryPoint = "CreateMetaFile")]
		public static extern IntPtr CreateMetaFile([In] string pszFile);

		[DllImport("gdi32.dll", EntryPoint = "SetWindowOrgEx")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetWindowOrgEx([In] IntPtr hdc, int x, int y, IntPtr lppt);

		[DllImport("gdi32.dll", EntryPoint = "SetWindowExtEx")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetWindowExtEx([In] IntPtr hdc, int x, int y, IntPtr lpsz);

		[DllImport("gdi32.dll", EntryPoint = "SetPixelFormat")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetPixelFormat([In] IntPtr hdc, int format, [In] ref PIXELFORMATDESCRIPTOR ppfd);

		[DllImport("gdi32.dll", EntryPoint = "SetMapperFlags")]
		public static extern uint SetMapperFlags([In] IntPtr hdc, uint flags);

		[DllImport("gdi32.dll", EntryPoint = "SetICMProfile")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetICMProfile([In] IntPtr hdc, [In] string lpFileName);

		[DllImport("gdi32.dll", EntryPoint = "SelectClipPath")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SelectClipPath([In] IntPtr hdc, int mode);

		[DllImport("gdi32.dll", EntryPoint = "RealizePalette")]
		public static extern uint RealizePalette([In] IntPtr hdc);

		[DllImport("gdi32.dll", EntryPoint = "GetWindowOrgEx")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetWindowOrgEx([In] IntPtr hdc, [Out] out Point lppoint);

		[DllImport("gdi32.dll", EntryPoint = "GetWindowExtEx")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetWindowExtEx([In] IntPtr hdc, [Out] out SIZE lpsize);

		[DllImport("gdi32.dll", EntryPoint = "GetTextCharset")]
		public static extern int GetTextCharset([In] IntPtr hdc);

		[DllImport("gdi32.dll", EntryPoint = "GetStockObject")]
		public static extern IntPtr GetStockObject(int i);

		[DllImport("gdi32.dll", EntryPoint = "GetPixelFormat")]
		public static extern int GetPixelFormat([In] IntPtr hdc);

		[DllImport("gdi32.dll", EntryPoint = "GetICMProfile")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetICMProfile([In] IntPtr hdc, ref uint pBufSize, [Out] StringBuilder pszFilename);

		[DllImport("gdi32.dll", EntryPoint = "DeleteMetaFile")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool DeleteMetaFile([In] IntPtr hmf);

		[DllImport("gdi32.dll", EntryPoint = "CreateDIBitmap")]
		public static extern IntPtr CreateDIBitmap([In] IntPtr hdc, [In] IntPtr pbmih, uint flInit, [In] IntPtr pjBits, [In] IntPtr pbmi, uint iUsage);

		[DllImport("gdi32.dll", EntryPoint = "AnimatePalette")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool AnimatePalette(
			[In] IntPtr hPal, uint iStartIndex, uint cEntries,
			[MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 2)] PALETTEENTRY[] ppe);

		[DllImport("gdi32.dll", EntryPoint = "StretchDIBits")]
		public static extern int StretchDIBits(
			[In] IntPtr hdc, int xDest, int yDest, int DestWidth, int DestHeight, int xSrc, int ySrc, int SrcWidth, int SrcHeight, [In] IntPtr lpBits,
			[In] ref BITMAPINFO lpbmi, uint iUsage, uint rop);

		[DllImport("gdi32.dll", EntryPoint = "SetMiterLimit")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetMiterLimit([In] IntPtr hdc, float limit, IntPtr old);

		[DllImport("gdi32.dll", EntryPoint = "SetDCPenColor")]
		public static extern uint SetDCPenColor([In] IntPtr hdc, uint color);

		[DllImport("gdi32.dll", EntryPoint = "SetColorSpace")]
		public static extern IntPtr SetColorSpace([In] IntPtr hdc, [In] IntPtr hcs);

		[DllImport("gdi32.dll", EntryPoint = "SetBrushOrgEx")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetBrushOrgEx([In] IntPtr hdc, int x, int y, IntPtr lppt);

		[DllImport("gdi32.dll", EntryPoint = "SetBoundsRect")]
		public static extern uint SetBoundsRect([In] IntPtr hdc, [In] IntPtr lprect, uint flags);

		[DllImport("gdi32.dll", EntryPoint = "SetBitmapBits")]
		public static extern int SetBitmapBits([In] IntPtr hbm, uint cb, [In] IntPtr pvBits);

		[DllImport("gdi32.dll", EntryPoint = "SelectPalette")]
		public static extern IntPtr SelectPalette([In] IntPtr hdc, [In] IntPtr hPal, [MarshalAs(UnmanagedType.Bool)] bool bForceBkgd);

		[DllImport("gdi32.dll", EntryPoint = "SelectClipRgn")]
		public static extern int SelectClipRgn([In] IntPtr hdc, [In] IntPtr hrgn);

		[DllImport("gdi32.dll", EntryPoint = "ResizePalette")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool ResizePalette([In] IntPtr hpal, uint n);

		[DllImport("gdi32.dll", EntryPoint = "OffsetClipRgn")]
		public static extern int OffsetClipRgn([In] IntPtr hdc, int x, int y);

		[DllImport("gdi32.dll", EntryPoint = "GetRegionData")]
		public static extern uint GetRegionData([In] IntPtr hrgn, uint nCount, IntPtr lpRgnData);

		[DllImport("gdi32.dll", EntryPoint = "GetObjectType")]
		public static extern uint GetObjectType([In] IntPtr h);

		[DllImport("gdi32.dll", EntryPoint = "GetMiterLimit")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetMiterLimit([In] IntPtr hdc, [Out] out float plimit);

		[DllImport("gdi32.dll", EntryPoint = "GetDeviceCaps")]
		public static extern int GetDeviceCaps([In] IntPtr hdc, int index);

		[DllImport("gdi32.dll", EntryPoint = "GetDCPenColor")]
		public static extern uint GetDCPenColor([In] IntPtr hdc);

		[DllImport("gdi32.dll", EntryPoint = "GetColorSpace")]
		public static extern IntPtr GetColorSpace([In] IntPtr hdc);

		[DllImport("gdi32.dll", EntryPoint = "GetCharWidth")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetCharWidth([In] IntPtr hdc, uint iFirst, uint iLast, out int[] lpBuffer);

		[DllImport("gdi32.dll", EntryPoint = "GetCharWidthI")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetCharWidthI([In] IntPtr hdc, uint giFirst, uint cgi, ushort[] pgi, out int[] piWidths);

		[DllImport("gdi32.dll", EntryPoint = "GetBrushOrgEx")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetBrushOrgEx([In] IntPtr hdc, [Out] out Point lppt);

		[DllImport("gdi32.dll", EntryPoint = "GetBoundsRect")]
		public static extern uint GetBoundsRect([In] IntPtr hdc, [Out] out RECT lprect, uint flags);

		[DllImport("gdi32.dll", EntryPoint = "GetBitmapBits")]
		public static extern int GetBitmapBits([In] IntPtr hbit, int cb, IntPtr lpvBits);

		[DllImport("gdi32.dll", EntryPoint = "FixBrushOrgEx")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool FixBrushOrgEx([In] IntPtr hdc, int x, int y, [In] IntPtr ptl);

		[DllImport("gdi32.dll", EntryPoint = "CreateRectRgn")]
		public static extern IntPtr CreateRectRgn(int x1, int y1, int x2, int y2);

		[DllImport("gdi32.dll", EntryPoint = "CreatePalette")]
		public static extern IntPtr CreatePalette([In] ref LOGPALETTE plpal);

		[DllImport("gdi32.dll", EntryPoint = "CopyMetaFile")]
		public static extern IntPtr CopyMetaFile([In] IntPtr param0, [In] string param1);

		[DllImport("gdi32.dll", EntryPoint = "CloseMetaFile")]
		public static extern IntPtr CloseMetaFile([In] IntPtr hdc);

		[DllImport("gdi32.dll", EntryPoint = "UpdateColors")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool UpdateColors([In] IntPtr hdc);

		[DllImport("gdi32.dll", EntryPoint = "SetTextColor")]
		public static extern uint SetTextColor([In] IntPtr hdc, uint color);

		[DllImport("gdi32.dll", EntryPoint = "SetTextAlign")]
		public static extern uint SetTextAlign([In] IntPtr hdc, uint align);

		[DllImport("gdi32.dll", EntryPoint = "SetAbortProc")]
		public static extern int SetAbortProc([In] IntPtr hdc, ABORTPROC proc);

		[DllImport("gdi32.dll", EntryPoint = "SelectObject")]
		public static extern IntPtr SelectObject([In] IntPtr hdc, [In] IntPtr h);

		[DllImport("gdi32.dll", EntryPoint = "RectInRegion")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool RectInRegion([In] IntPtr hrgn, [In] ref RECT lprect);

		[DllImport("gdi32.dll", EntryPoint = "PolyTextOut")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool PolyTextOut(
			[In] IntPtr hdc, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 2)] POLYTEXTW[] ppt, int nstrings);

		[DllImport("gdi32.dll", EntryPoint = "PolyPolyline")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool PolyPolyline(
			[In] IntPtr hdc, [In] ref Point apt, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U4, SizeParamIndex = 3)] uint[] asz, uint csz);

		[DllImport("gdi32.dll", EntryPoint = "PolyBezierTo")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool PolyBezierTo(
			[In] IntPtr hdc, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 2)] Point[] apt, uint cpt);

		[DllImport("gdi32.dll", EntryPoint = "PlayMetaFile")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool PlayMetaFile([In] IntPtr hdc, [In] IntPtr hmf);

		[DllImport("gdi32.dll", EntryPoint = "PathToRegion")]
		public static extern IntPtr PathToRegion([In] IntPtr hdc);

		[DllImport("gdi32.dll", EntryPoint = "GetTextFace")]
		public static extern int GetTextFace([In] IntPtr hdc, int c, [Out] StringBuilder lpName);

		[DllImport("gdi32.dll", EntryPoint = "GetTextColor")]
		public static extern uint GetTextColor([In] IntPtr hdc);

		[DllImport("gdi32.dll", EntryPoint = "GetTextAlign")]
		public static extern uint GetTextAlign([In] IntPtr hdc);

		[DllImport("gdi32.dll", EntryPoint = "GetRandomRgn")]
		public static extern int GetRandomRgn([In] IntPtr hdc, [In] IntPtr hrgn, int i);

		[DllImport("gdi32.dll", EntryPoint = "GetMetaFile")]
		public static extern IntPtr GetMetaFile([In] string lpName);

		[DllImport("gdi32.dll", EntryPoint = "ExtFloodFill")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool ExtFloodFill([In] IntPtr hdc, int x, int y, uint color, uint type);

		[DllImport("gdi32.dll", EntryPoint = "ExtCreatePen")]
		public static extern IntPtr ExtCreatePen(uint iPenStyle, uint cWidth, [In] ref LOGBRUSH plbrush, uint cStyle, [In] IntPtr pstyle);

		[DllImport("gdi32.dll", EntryPoint = "EnumMetaFile")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool EnumMetaFile([In] IntPtr hdc, [In] IntPtr hmf, MFENUMPROC proc, [MarshalAs(UnmanagedType.SysInt)] int param);

		[DllImport("gdi32.dll", EntryPoint = "DeleteObject")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool DeleteObject([In] IntPtr ho);

		[DllImport("gdi32.dll", EntryPoint = "CreateBitmap")]
		public static extern IntPtr CreateBitmap(int nWidth, int nHeight, uint nPlanes, uint nBitCount, [In] IntPtr lpBits);

		[DllImport("gdi32.dll", EntryPoint = "SwapBuffers")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SwapBuffers(IntPtr param0);

		[DllImport("gdi32.dll", EntryPoint = "RectVisible")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool RectVisible([In] IntPtr hdc, [In] ref RECT lprect);

		[DllImport("gdi32.dll", EntryPoint = "PolyPolygon")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool PolyPolygon(
			[In] IntPtr hdc, [In] ref Point apt, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I4, SizeParamIndex = 3)] int[] asz, int csz);

		[DllImport("gdi32.dll", EntryPoint = "GetFontData")]
		public static extern uint GetFontData([In] IntPtr hdc, uint dwTable, uint dwOffset, IntPtr pvBuffer, uint cjBuffer);

		[DllImport("gdi32.dll", EntryPoint = "FlattenPath")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool FlattenPath([In] IntPtr hdc);

		[DllImport("gdi32.dll", EntryPoint = "ExtTextOut")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool ExtTextOut(
			[In] IntPtr hdc, int x, int y, uint options, [In] ref RECT lprect, [In] string lpString, uint c, [In] int[] lpDx);

		[DllImport("gdi32.dll", EntryPoint = "EnumObjects")]
		public static extern int EnumObjects([In] IntPtr hdc, int nType, GOBJENUMPROC lpFunc, [MarshalAs(UnmanagedType.SysInt)] int lParam);

		[DllImport("gdi32.dll", EntryPoint = "CreateFont")]
		public static extern IntPtr CreateFont(
			int cHeight, int cWidth, int cEscapement, int cOrientation, int cWeight, uint bItalic, uint bUnderline, uint bStrikeOut, uint iCharSet, uint iOutPrecision,
			uint iClipPrecision, uint iQuality, uint iPitchAndFamily, [In] string pszFaceName);

		[DllImport("gdi32.dll", EntryPoint = "CloseFigure")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool CloseFigure([In] IntPtr hdc);

		[DllImport("gdi32.dll", EntryPoint = "StrokePath")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool StrokePath([In] IntPtr hdc);

		[DllImport("gdi32.dll", EntryPoint = "StretchBlt")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool StretchBlt(
			[In] IntPtr hdcDest, int xDest, int yDest, int wDest, int hDest, [In] IntPtr hdcSrc, int xSrc, int ySrc, int wSrc, int hSrc, uint rop);

		[DllImport("gdi32.dll", EntryPoint = "SetRectRgn")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetRectRgn([In] IntPtr hrgn, int left, int top, int right, int bottom);

		[DllImport("gdi32.dll", EntryPoint = "SetMetaRgn")]
		public static extern int SetMetaRgn([In] IntPtr hdc);

		[DllImport("gdi32.dll", EntryPoint = "SetMapMode")]
		public static extern int SetMapMode([In] IntPtr hdc, int iMode);

		[DllImport("gdi32.dll", EntryPoint = "SetICMMode")]
		public static extern int SetICMMode([In] IntPtr hdc, int mode);

		[DllImport("gdi32.dll", EntryPoint = "SetBkColor")]
		public static extern uint SetBkColor([In] IntPtr hdc, uint color);

		[DllImport("gdi32.dll", EntryPoint = "PtInRegion")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool PtInRegion([In] IntPtr hrgn, int x, int y);

		[DllImport("gdi32.dll", EntryPoint = "PolylineTo")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool PolylineTo(
			[In] IntPtr hdc, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 2)] Point[] apt, uint cpt);

		[DllImport("gdi32.dll", EntryPoint = "PolyBezier")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool PolyBezier(
			[In] IntPtr hdc, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 2)] Point[] apt, uint cpt);

		[DllImport("gdi32.dll", EntryPoint = "GetObject")]
		public static extern int GetObject([In] IntPtr h, int c, IntPtr pv);

		[DllImport("gdi32.dll", EntryPoint = "GetMetaRgn")]
		public static extern int GetMetaRgn([In] IntPtr hdc, [In] IntPtr hrgn);

		[DllImport("gdi32.dll", EntryPoint = "GetMapMode")]
		public static extern int GetMapMode([In] IntPtr hdc);

		[DllImport("gdi32.dll", EntryPoint = "GetDCOrgEx")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetDCOrgEx([In] IntPtr hdc, [Out] out Point lppt);

		[DllImport("gdi32.dll", EntryPoint = "GetClipRgn")]
		public static extern int GetClipRgn([In] IntPtr hdc, [In] IntPtr hrgn);

		[DllImport("gdi32.dll", EntryPoint = "GetClipBox")]
		public static extern int GetClipBox([In] IntPtr hdc, [Out] out RECT lprect);

		[DllImport("gdi32.dll", EntryPoint = "GetBkColor")]
		public static extern uint GetBkColor([In] IntPtr hdc);

		[DllImport("gdi32.dll", EntryPoint = "GdiComment")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GdiComment([In] IntPtr hdc, uint nSize, [In] IntPtr lpData);

		[DllImport("gdi32.dll", EntryPoint = "EnumFonts")]
		public static extern int EnumFonts([In] IntPtr hdc, [In] string lpLogfont, OLDFONTENUMPROC lpProc, [MarshalAs(UnmanagedType.SysInt)] int lParam);

		[DllImport("gdi32.dll", EntryPoint = "DrawEscape")]
		public static extern int DrawEscape([In] IntPtr hdc, int iEscape, int cjIn, [In] [MarshalAs(UnmanagedType.LPStr)] string lpIn);

		[DllImport("gdi32.dll", EntryPoint = "CombineRgn")]
		public static extern int CombineRgn([In] IntPtr hrgnDst, [In] IntPtr hrgnSrc1, [In] IntPtr hrgnSrc2, int iMode);

		[DllImport("gdi32.dll", EntryPoint = "WidenPath")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool WidenPath([In] IntPtr hdc);

		[DllImport("gdi32.dll", EntryPoint = "StartPage")]
		public static extern int StartPage([In] IntPtr hdc);

		[DllImport("gdi32.dll", EntryPoint = "StartDoc")]
		public static extern int StartDoc([In] IntPtr hdc, [In] ref DOCINFO lpdi);

		[DllImport("gdi32.dll", EntryPoint = "SetPixelV")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetPixelV([In] IntPtr hdc, int x, int y, uint color);

		[DllImport("gdi32.dll", EntryPoint = "SetLayout")]
		public static extern uint SetLayout([In] IntPtr hdc, uint l);

		[DllImport("gdi32.dll", EntryPoint = "SetDIBits")]
		public static extern int SetDIBits([In] IntPtr hdc, [In] IntPtr hbm, uint start, uint cLines, [In] IntPtr lpBits, [In] ref BITMAPINFO lpbmi, uint ColorUse);

		[DllImport("gdi32.dll", EntryPoint = "SetBkMode")]
		public static extern int SetBkMode([In] IntPtr hdc, int mode);

		[DllImport("gdi32.dll", EntryPoint = "RoundRect")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool RoundRect([In] IntPtr hdc, int left, int top, int right, int bottom, int width, int height);

		[DllImport("gdi32.dll", EntryPoint = "RestoreDC")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool RestoreDC([In] IntPtr hdc, int nSavedDC);

		[DllImport("gdi32.dll", EntryPoint = "Rectangle")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool Rectangle([In] IntPtr hdc, int left, int top, int right, int bottom);

		[DllImport("gdi32.dll", EntryPoint = "PtVisible")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool PtVisible([In] IntPtr hdc, int x, int y);

		[DllImport("gdi32.dll", EntryPoint = "OffsetRgn")]
		public static extern int OffsetRgn([In] IntPtr hrgn, int x, int y);

		[DllImport("gdi32.dll", EntryPoint = "InvertRgn")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool InvertRgn([In] IntPtr hdc, [In] IntPtr hrgn);

		[DllImport("gdi32.dll", EntryPoint = "GetRgnBox")]
		public static extern int GetRgnBox([In] IntPtr hrgn, [Out] out RECT lprc);

		[DllImport("gdi32.dll", EntryPoint = "GetLayout")]
		public static extern uint GetLayout([In] IntPtr hdc);

		[DllImport("gdi32.dll", EntryPoint = "GetDIBits")]
		public static extern int GetDIBits([In] IntPtr hdc, [In] IntPtr hbm, uint start, uint cLines, IntPtr lpvBits, ref BITMAPINFO lpbmi, uint usage);

		[DllImport("gdi32.dll", EntryPoint = "GetBkMode")]
		public static extern int GetBkMode([In] IntPtr hdc);

		[DllImport("gdi32.dll", EntryPoint = "FloodFill")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool FloodFill([In] IntPtr hdc, int x, int y, uint color);

		[DllImport("gdi32.dll", EntryPoint = "ExtEscape")]
		public static extern int ExtEscape(
			[In] IntPtr hdc, int iEscape, int cjInput, [In] [MarshalAs(UnmanagedType.LPStr)] string lpInData, int cjOutput, IntPtr lpOutData);

		[DllImport("gdi32.dll", EntryPoint = "CreatePen")]
		public static extern IntPtr CreatePen(int iStyle, int cWidth, uint color);

		[DllImport("gdi32.dll", EntryPoint = "CreateIC")]
		public static extern IntPtr CreateIC([In] string pszDriver, [In] string pszDevice, [In] string pszPort, [In] IntPtr pdm);

		[DllImport("gdi32.dll", EntryPoint = "CreateDC")]
		public static extern IntPtr CreateDC([In] string pwszDriver, [In] string pwszDevice, [In] string pszPort, [In] IntPtr pdm);

		[DllImport("gdi32.dll", EntryPoint = "BeginPath")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool BeginPath([In] IntPtr hdc);

		[DllImport("gdi32.dll", EntryPoint = "AbortPath")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool AbortPath([In] IntPtr hdc);

		[DllImport("gdi32.dll", EntryPoint = "TextOut")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool TextOut([In] IntPtr hdc, int x, int y, [In] string lpString, int c);

		[DllImport("gdi32.dll", EntryPoint = "SetPixel")]
		public static extern uint SetPixel([In] IntPtr hdc, int x, int y, uint color);

		[DllImport("gdi32.dll", EntryPoint = "ResetDC")]
		public static extern IntPtr ResetDC([In] IntPtr hdc, [In] ref DEVMODE lpdm);

		[DllImport("gdi32.dll", EntryPoint = "Polyline")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool Polyline(
			[In] IntPtr hdc, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 2)] Point[] apt, int cpt);

		[DllImport("gdi32.dll", EntryPoint = "PolyDraw")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool PolyDraw(
			[In] IntPtr hdc, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 3)] Point[] apt,
			[MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I1, SizeParamIndex = 3)] byte[] aj, int cpt);

		[DllImport("gdi32.dll", EntryPoint = "PaintRgn")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool PaintRgn([In] IntPtr hdc, [In] IntPtr hrgn);

		[DllImport("gdi32.dll", EntryPoint = "MoveToEx")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool MoveToEx([In] IntPtr hdc, int x, int y, IntPtr lppt);

		[DllImport("gdi32.dll", EntryPoint = "GetPixel")]
		public static extern uint GetPixel([In] IntPtr hdc, int x, int y);

		[DllImport("gdi32.dll", EntryPoint = "GdiFlush")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GdiFlush();

		[DllImport("gdi32.dll", EntryPoint = "FrameRgn")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool FrameRgn([In] IntPtr hdc, [In] IntPtr hrgn, [In] IntPtr hbr, int w, int h);

		[DllImport("gdi32.dll", EntryPoint = "FillPath")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool FillPath([In] IntPtr hdc);

		[DllImport("gdi32.dll", EntryPoint = "EqualRgn")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool EqualRgn([In] IntPtr hrgn1, [In] IntPtr hrgn2);

		[DllImport("gdi32.dll", EntryPoint = "DeleteDC")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool DeleteDC([In] IntPtr hdc);

		[DllImport("gdi32.dll", EntryPoint = "CancelDC")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool CancelDC([In] IntPtr hdc);

		[DllImport("gdi32.dll", EntryPoint = "AngleArc")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool AngleArc([In] IntPtr hdc, int x, int y, uint r, float StartAngle, float SweepAngle);

		[DllImport("gdi32.dll", EntryPoint = "AbortDoc")]
		public static extern int AbortDoc([In] IntPtr hdc);

		[DllImport("gdi32.dll", EntryPoint = "SetROP2")]
		public static extern int SetROP2([In] IntPtr hdc, int rop2);

		[DllImport("gdi32.dll", EntryPoint = "Polygon")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool Polygon(
			[In] IntPtr hdc, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 2)] Point[] apt, int cpt);

		[DllImport("gdi32.dll", EntryPoint = "MaskBlt")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool MaskBlt(
			[In] IntPtr hdcDest, int xDest, int yDest, int width, int height, [In] IntPtr hdcSrc, int xSrc, int ySrc, [In] IntPtr hbmMask, int xMask, int yMask, uint rop);

		[DllImport("gdi32.dll", EntryPoint = "LineDDA")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool LineDDA(int xStart, int yStart, int xEnd, int yEnd, LINEDDAPROC lpProc, [MarshalAs(UnmanagedType.SysInt)] int data);

		[DllImport("gdi32.dll", EntryPoint = "GetROP2")]
		public static extern int GetROP2([In] IntPtr hdc);

		[DllImport("gdi32.dll", EntryPoint = "GetPath")]
		public static extern int GetPath([In] IntPtr hdc, IntPtr apt, IntPtr aj, int cpt);

		[DllImport("gdi32.dll", EntryPoint = "FillRgn")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool FillRgn([In] IntPtr hdc, [In] IntPtr hrgn, [In] IntPtr hbr);

		[DllImport("gdi32.dll", EntryPoint = "EndPath")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool EndPath([In] IntPtr hdc);

		[DllImport("gdi32.dll", EntryPoint = "EndPage")]
		public static extern int EndPage([In] IntPtr hdc);

		[DllImport("gdi32.dll", EntryPoint = "Ellipse")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool Ellipse([In] IntPtr hdc, int left, int top, int right, int bottom);

		[DllImport("gdi32.dll", EntryPoint = "SaveDC")]
		public static extern int SaveDC([In] IntPtr hdc);

		[DllImport("gdi32.dll", EntryPoint = "PlgBlt")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool PlgBlt(
			[In] IntPtr hdcDest, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeConst = 3)] Point[] lpPoint, [In] IntPtr hdcSrc, int xSrc,
			int ySrc, int width, int height, [In] IntPtr hbmMask, int xMask, int yMask);

		[DllImport("gdi32.dll", EntryPoint = "PatBlt")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool PatBlt([In] IntPtr hdc, int x, int y, int w, int h, uint rop);

		[DllImport("gdi32.dll", EntryPoint = "LPtoDP")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool LPtoDP([In] IntPtr hdc, IntPtr lppt, int c);

		[DllImport("gdi32.dll", EntryPoint = "LineTo")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool LineTo([In] IntPtr hdc, int x, int y);

		[DllImport("gdi32.dll", EntryPoint = "Escape")]
		public static extern int Escape([In] IntPtr hdc, int iEscape, int cjIn, [In] [MarshalAs(UnmanagedType.LPStr)] string pvIn, IntPtr pvOut);

		[DllImport("gdi32.dll", EntryPoint = "EndDoc")]
		public static extern int EndDoc([In] IntPtr hdc);

		[DllImport("gdi32.dll", EntryPoint = "DPtoLP")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool DPtoLP([In] IntPtr hdc, IntPtr lppt, int c);

		[DllImport("gdi32.dll", EntryPoint = "BitBlt")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool BitBlt([In] IntPtr hdc, int x, int y, int cx, int cy, [In] IntPtr hdcSrc, int x1, int y1, uint rop);

		[DllImport("gdi32.dll", EntryPoint = "Chord")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool Chord([In] IntPtr hdc, int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4);

		[DllImport("gdi32.dll", EntryPoint = "ArcTo")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool ArcTo([In] IntPtr hdc, int left, int top, int right, int bottom, int xr1, int yr1, int xr2, int yr2);

		[DllImport("gdi32.dll", EntryPoint = "Pie")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool Pie([In] IntPtr hdc, int left, int top, int right, int bottom, int xr1, int yr1, int xr2, int yr2);

		[DllImport("gdi32.dll", EntryPoint = "Arc")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool Arc([In] IntPtr hdc, int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4);

		[DllImport("gdi32.dll", EntryPoint = "GetEnhMetaFilePixelFormat")]
		public static extern uint GetEnhMetaFilePixelFormat([In] IntPtr hemf, uint cbBuffer, IntPtr ppfd);
	}

	// ReSharper restore InconsistentNaming
}