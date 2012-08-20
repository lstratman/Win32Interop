using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Win32Interop.Structs;

// ReSharper disable CheckNamespace
namespace Win32Interop.Methods
// ReSharper restore CheckNamespace
{

    /// Return Type: int
    ///param0: LPWSTR->WCHAR*
    ///param1: LPARAM->LONG_PTR->int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int ICMENUMPROCW([MarshalAsAttribute(UnmanagedType.LPWStr)] StringBuilder param0, IntPtr param1);

    /// Return Type: int
    ///param0: LPSTR->CHAR*
    ///param1: LPARAM->LONG_PTR->int
    [UnmanagedFunctionPointerAttribute(CallingConvention.StdCall)]
    public delegate int ICMENUMPROCA([MarshalAsAttribute(UnmanagedType.LPStr)] StringBuilder param0, IntPtr param1);

    /// Return Type: int
    ///hdc: HDC->HDC__*
    ///lpht: HANDLETABLE*
    ///lpmr: ENHMETARECORD*
    ///hHandles: int
    ///data: LPARAM->LONG_PTR->int
    [UnmanagedFunctionPointerAttribute(CallingConvention.StdCall)]
    public delegate int ENHMFENUMPROC([InAttribute] IntPtr hdc, [InAttribute] IntPtr lpht, [InAttribute] ref tagENHMETARECORD lpmr, int hHandles, [InAttribute] IntPtr data);

    /// Return Type: BOOL->int
    ///param0: HDC->HDC__*
    ///param1: int
    [UnmanagedFunctionPointerAttribute(CallingConvention.StdCall)]
    public delegate int ABORTPROC([InAttribute] IntPtr param0, int param1);

    /// Return Type: int
    ///hdc: HDC->HDC__*
    ///lpht: HANDLETABLE*
    ///lpMR: METARECORD*
    ///nObj: int
    ///param: LPARAM->LONG_PTR->int
    [UnmanagedFunctionPointerAttribute(CallingConvention.StdCall)]
    public delegate int MFENUMPROC([InAttribute] IntPtr hdc, [InAttribute] IntPtr lpht, [InAttribute] ref tagMETARECORD lpMR, int nObj, [InAttribute] IntPtr param);

    /// Return Type: int
    ///param0: LPVOID->void*
    ///param1: LPARAM->LONG_PTR->int
    [UnmanagedFunctionPointerAttribute(CallingConvention.StdCall)]
    public delegate int GOBJENUMPROC(IntPtr param0, IntPtr param1);

    /// Return Type: void
    ///param0: int
    ///param1: int
    ///param2: LPARAM->LONG_PTR->int
    [UnmanagedFunctionPointerAttribute(CallingConvention.StdCall)]
    public delegate void LINEDDAPROC(int param0, int param1, IntPtr param2);

    /// Return Type: int
    ///param0: LOGFONTW*
    ///param1: TEXTMETRICW*
    ///param2: DWORD->unsigned int
    ///param3: LPARAM->LONG_PTR->int
    [UnmanagedFunctionPointerAttribute(CallingConvention.StdCall)]
    public delegate int OLDFONTENUMPROCW(ref tagLOGFONTW param0, ref tagTEXTMETRICW param1, uint param2, IntPtr param3);

    /// Return Type: int
    ///param0: LOGFONTA*
    ///param1: TEXTMETRICA*
    ///param2: DWORD->unsigned int
    ///param3: LPARAM->LONG_PTR->int
    [UnmanagedFunctionPointerAttribute(CallingConvention.StdCall)]
    public delegate int OLDFONTENUMPROCA(ref tagLOGFONTA param0, ref tagTEXTMETRICA param1, uint param2, IntPtr param3);

    public class Gdi32
    {

        /// Return Type: UINT->unsigned int
        ///hemf: HENHMETAFILE->HENHMETAFILE__*
        ///nNumEntries: UINT->unsigned int
        ///lpPaletteEntries: LPPALETTEENTRY->tagPALETTEENTRY*
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetEnhMetaFilePaletteEntries")]
        public static extern uint GetEnhMetaFilePaletteEntries([InAttribute] IntPtr hemf, uint nNumEntries, IntPtr lpPaletteEntries);


        /// Return Type: BOOL->int
        ///fdwHidden: DWORD->unsigned int
        ///lpszFont: LPCWSTR->WCHAR*
        ///lpszFile: LPCWSTR->WCHAR*
        ///lpszPath: LPCWSTR->WCHAR*
        [DllImportAttribute("gdi32.dll", EntryPoint = "CreateScalableFontResourceW")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool CreateScalableFontResourceW(uint fdwHidden, [InAttribute] [MarshalAsAttribute(UnmanagedType.LPWStr)] string lpszFont, [InAttribute] [MarshalAsAttribute(UnmanagedType.LPWStr)] string lpszFile, [InAttribute] [MarshalAsAttribute(UnmanagedType.LPWStr)] string lpszPath);


        /// Return Type: BOOL->int
        ///fdwHidden: DWORD->unsigned int
        ///lpszFont: LPCSTR->CHAR*
        ///lpszFile: LPCSTR->CHAR*
        ///lpszPath: LPCSTR->CHAR*
        [DllImportAttribute("gdi32.dll", EntryPoint = "CreateScalableFontResourceA")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool CreateScalableFontResourceA(uint fdwHidden, [InAttribute] [MarshalAsAttribute(UnmanagedType.LPStr)] string lpszFont, [InAttribute] [MarshalAsAttribute(UnmanagedType.LPStr)] string lpszFile, [InAttribute] [MarshalAsAttribute(UnmanagedType.LPStr)] string lpszPath);


        /// Return Type: UINT->unsigned int
        ///hemf: HENHMETAFILE->HENHMETAFILE__*
        ///cchBuffer: UINT->unsigned int
        ///lpDescription: LPWSTR->WCHAR*
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetEnhMetaFileDescriptionW")]
        public static extern uint GetEnhMetaFileDescriptionW([InAttribute] IntPtr hemf, uint cchBuffer, [OutAttribute] [MarshalAsAttribute(UnmanagedType.LPWStr)] StringBuilder lpDescription);


        /// Return Type: UINT->unsigned int
        ///hemf: HENHMETAFILE->HENHMETAFILE__*
        ///cchBuffer: UINT->unsigned int
        ///lpDescription: LPSTR->CHAR*
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetEnhMetaFileDescriptionA")]
        public static extern uint GetEnhMetaFileDescriptionA([InAttribute] IntPtr hemf, uint cchBuffer, [OutAttribute] [MarshalAsAttribute(UnmanagedType.LPStr)] StringBuilder lpDescription);


        /// Return Type: HRGN->HRGN__*
        ///lprect: RECT*
        [DllImportAttribute("gdi32.dll", EntryPoint = "CreateEllipticRgnIndirect")]
        public static extern IntPtr CreateEllipticRgnIndirect([InAttribute] ref tagRECT lprect);


        /// Return Type: BOOL->int
        ///h: HANDLE->void*
        [DllImportAttribute("gdi32.dll", EntryPoint = "RemoveFontMemResourceEx")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool RemoveFontMemResourceEx([InAttribute] IntPtr h);


        /// Return Type: UINT->unsigned int
        ///hdc: HDC->HDC__*
        ///iStart: UINT->unsigned int
        ///cEntries: UINT->unsigned int
        ///pPalEntries: LPPALETTEENTRY->tagPALETTEENTRY*
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetSystemPaletteEntries")]
        public static extern uint GetSystemPaletteEntries([InAttribute] IntPtr hdc, uint iStart, uint cEntries, IntPtr pPalEntries);


        /// Return Type: HBITMAP->HBITMAP__*
        ///hdc: HDC->HDC__*
        ///cx: int
        ///cy: int
        [DllImportAttribute("gdi32.dll", EntryPoint = "CreateDiscardableBitmap")]
        public static extern IntPtr CreateDiscardableBitmap([InAttribute] IntPtr hdc, int cx, int cy);


        /// Return Type: HBRUSH->HBRUSH__*
        ///lpPackedDIB: void*
        ///iUsage: UINT->unsigned int
        [DllImportAttribute("gdi32.dll", EntryPoint = "CreateDIBPatternBrushPt")]
        public static extern IntPtr CreateDIBPatternBrushPt([InAttribute] IntPtr lpPackedDIB, uint iUsage);


        /// Return Type: UINT->unsigned int
        ///hdc: HDC->HDC__*
        ///cjCopy: UINT->unsigned int
        ///potm: LPOUTLINETEXTMETRICW->_OUTLINETEXTMETRICW*
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetOutlineTextMetricsW")]
        public static extern uint GetOutlineTextMetricsW([InAttribute] IntPtr hdc, uint cjCopy, IntPtr potm);


        /// Return Type: UINT->unsigned int
        ///hdc: HDC->HDC__*
        ///cjCopy: UINT->unsigned int
        ///potm: LPOUTLINETEXTMETRICA->_OUTLINETEXTMETRICA*
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetOutlineTextMetricsA")]
        public static extern uint GetOutlineTextMetricsA([InAttribute] IntPtr hdc, uint cjCopy, IntPtr potm);


        /// Return Type: UINT->unsigned int
        ///h: HPALETTE->HPALETTE__*
        ///color: COLORREF->DWORD->unsigned int
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetNearestPaletteIndex")]
        public static extern uint GetNearestPaletteIndex([InAttribute] IntPtr h, uint color);


        /// Return Type: DWORD->unsigned int
        ///hdc: HDC->HDC__*
        ///lpString: LPCWSTR->WCHAR*
        ///nCount: int
        ///nMexExtent: int
        ///lpResults: LPGCP_RESULTSW->tagGCP_RESULTSW*
        ///dwFlags: DWORD->unsigned int
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetCharacterPlacementW")]
        public static extern uint GetCharacterPlacementW([InAttribute] IntPtr hdc, [InAttribute] [MarshalAsAttribute(UnmanagedType.LPWStr)] string lpString, int nCount, int nMexExtent, ref tagGCP_RESULTSW lpResults, uint dwFlags);


        /// Return Type: DWORD->unsigned int
        ///hdc: HDC->HDC__*
        ///lpString: LPCSTR->CHAR*
        ///nCount: int
        ///nMexExtent: int
        ///lpResults: LPGCP_RESULTSA->tagGCP_RESULTSA*
        ///dwFlags: DWORD->unsigned int
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetCharacterPlacementA")]
        public static extern uint GetCharacterPlacementA([InAttribute] IntPtr hdc, [InAttribute] [MarshalAsAttribute(UnmanagedType.LPStr)] string lpString, int nCount, int nMexExtent, ref tagGCP_RESULTSA lpResults, uint dwFlags);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///iFirst: UINT->unsigned int
        ///iLast: UINT->unsigned int
        ///lpABC: LPABCFLOAT->_ABCFLOAT*
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetCharABCWidthsFloatW")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool GetCharABCWidthsFloatW([InAttribute] IntPtr hdc, uint iFirst, uint iLast, IntPtr lpABC);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///iFirst: UINT->unsigned int
        ///iLast: UINT->unsigned int
        ///lpABC: LPABCFLOAT->_ABCFLOAT*
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetCharABCWidthsFloatA")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool GetCharABCWidthsFloatA([InAttribute] IntPtr hdc, uint iFirst, uint iLast, IntPtr lpABC);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///lpsize: LPSIZE->tagSIZE*
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetAspectRatioFilterEx")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool GetAspectRatioFilterEx([InAttribute] IntPtr hdc, [OutAttribute] out tagSIZE lpsize);


        /// Return Type: HBITMAP->HBITMAP__*
        ///hdc: HDC->HDC__*
        ///cx: int
        ///cy: int
        [DllImportAttribute("gdi32.dll", EntryPoint = "CreateCompatibleBitmap")]
        public static extern IntPtr CreateCompatibleBitmap([InAttribute] IntPtr hdc, int cx, int cy);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///extra: int
        [DllImportAttribute("gdi32.dll", EntryPoint = "SetTextCharacterExtra")]
        public static extern int SetTextCharacterExtra([InAttribute] IntPtr hdc, int extra);


        /// Return Type: BOOL->int
        ///name: LPCWSTR->WCHAR*
        ///fl: DWORD->unsigned int
        ///pdv: PVOID->void*
        [DllImportAttribute("gdi32.dll", EntryPoint = "RemoveFontResourceExW")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool RemoveFontResourceExW([InAttribute] [MarshalAsAttribute(UnmanagedType.LPWStr)] string name, uint fl, IntPtr pdv);


        /// Return Type: BOOL->int
        ///name: LPCSTR->CHAR*
        ///fl: DWORD->unsigned int
        ///pdv: PVOID->void*
        [DllImportAttribute("gdi32.dll", EntryPoint = "RemoveFontResourceExA")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool RemoveFontResourceExA([InAttribute] [MarshalAsAttribute(UnmanagedType.LPStr)] string name, uint fl, IntPtr pdv);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///pht: LPHANDLETABLE->tagHANDLETABLE*
        ///pmr: ENHMETARECORD*
        ///cht: UINT->unsigned int
        [DllImportAttribute("gdi32.dll", EntryPoint = "PlayEnhMetaFileRecord")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool PlayEnhMetaFileRecord([InAttribute] IntPtr hdc, [MarshalAsAttribute(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 3)] tagHANDLETABLE[] pht, [InAttribute] ref tagENHMETARECORD pmr, uint cht);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///lpString: LPCWSTR->WCHAR*
        ///c: int
        ///psizl: LPSIZE->tagSIZE*
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetTextExtentPoint32W")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool GetTextExtentPoint32W([InAttribute] IntPtr hdc, [InAttribute] [MarshalAsAttribute(UnmanagedType.LPWStr)] string lpString, int c, [OutAttribute] out tagSIZE psizl);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///lpString: LPCSTR->CHAR*
        ///c: int
        ///psizl: LPSIZE->tagSIZE*
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetTextExtentPoint32A")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool GetTextExtentPoint32A([InAttribute] IntPtr hdc, [InAttribute] [MarshalAsAttribute(UnmanagedType.LPStr)] string lpString, int c, [OutAttribute] out tagSIZE psizl);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///lpszString: LPCWSTR->WCHAR*
        ///cchString: int
        ///nMaxExtent: int
        ///lpnFit: LPINT->int*
        ///lpnDx: LPINT->int*
        ///lpSize: LPSIZE->tagSIZE*
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetTextExtentExPointW")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool GetTextExtentExPointW([InAttribute] IntPtr hdc, [InAttribute] [MarshalAsAttribute(UnmanagedType.LPWStr)] string lpszString, int cchString, int nMaxExtent, IntPtr lpnFit, IntPtr lpnDx, [OutAttribute] out tagSIZE lpSize);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///lpwszString: LPWORD->WORD*
        ///cwchString: int
        ///nMaxExtent: int
        ///lpnFit: LPINT->int*
        ///lpnDx: LPINT->int*
        ///lpSize: LPSIZE->tagSIZE*
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetTextExtentExPointI")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool GetTextExtentExPointI([InAttribute] IntPtr hdc, [MarshalAsAttribute(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U2, SizeParamIndex = 2)] ushort[] lpwszString, int cwchString, int nMaxExtent, IntPtr lpnFit, IntPtr lpnDx, [OutAttribute] out tagSIZE lpSize);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///lpszString: LPCSTR->CHAR*
        ///cchString: int
        ///nMaxExtent: int
        ///lpnFit: LPINT->int*
        ///lpnDx: LPINT->int*
        ///lpSize: LPSIZE->tagSIZE*
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetTextExtentExPointA")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool GetTextExtentExPointA([InAttribute] IntPtr hdc, [InAttribute] [MarshalAsAttribute(UnmanagedType.LPStr)] string lpszString, int cchString, int nMaxExtent, IntPtr lpnFit, IntPtr lpnDx, [OutAttribute] out tagSIZE lpSize);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetTextCharacterExtra")]
        public static extern int GetTextCharacterExtra([InAttribute] IntPtr hdc);


        /// Return Type: HRGN->HRGN__*
        ///lprect: RECT*
        [DllImportAttribute("gdi32.dll", EntryPoint = "CreateRectRgnIndirect")]
        public static extern IntPtr CreateRectRgnIndirect([InAttribute] ref tagRECT lprect);


        /// Return Type: HPALETTE->HPALETTE__*
        ///hdc: HDC->HDC__*
        [DllImportAttribute("gdi32.dll", EntryPoint = "CreateHalftonePalette")]
        public static extern IntPtr CreateHalftonePalette([InAttribute] IntPtr hdc);


        /// Return Type: HFONT->HFONT__*
        ///param0: ENUMLOGFONTEXDVW*
        [DllImportAttribute("gdi32.dll", EntryPoint = "CreateFontIndirectExW")]
        public static extern IntPtr CreateFontIndirectExW([InAttribute] ref tagENUMLOGFONTEXDVW param0);


        /// Return Type: HFONT->HFONT__*
        ///param0: ENUMLOGFONTEXDVA*
        [DllImportAttribute("gdi32.dll", EntryPoint = "CreateFontIndirectExA")]
        public static extern IntPtr CreateFontIndirectExA([InAttribute] ref tagENUMLOGFONTEXDVA param0);


        /// Return Type: HBRUSH->HBRUSH__*
        ///h: HGLOBAL->HANDLE->void*
        ///iUsage: UINT->unsigned int
        [DllImportAttribute("gdi32.dll", EntryPoint = "CreateDIBPatternBrush")]
        public static extern IntPtr CreateDIBPatternBrush([InAttribute] IntPtr h, uint iUsage);


        /// Return Type: BOOL->int
        ///lpSrc: DWORD*
        ///lpCs: LPCHARSETINFO->tagCHARSETINFO*
        ///dwFlags: DWORD->unsigned int
        [DllImportAttribute("gdi32.dll", EntryPoint = "TranslateCharsetInfo")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool TranslateCharsetInfo(ref uint lpSrc, [OutAttribute] out tagCHARSETINFO lpCs, uint dwFlags);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///extra: int
        ///count: int
        [DllImportAttribute("gdi32.dll", EntryPoint = "SetTextJustification")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool SetTextJustification([InAttribute] IntPtr hdc, int extra, int count);


        /// Return Type: BOOL->int
        ///hbm: HBITMAP->HBITMAP__*
        ///w: int
        ///h: int
        ///lpsz: LPSIZE->tagSIZE*
        [DllImportAttribute("gdi32.dll", EntryPoint = "SetBitmapDimensionEx")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool SetBitmapDimensionEx([InAttribute] IntPtr hbm, int w, int h, IntPtr lpsz);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///lpxf: XFORM*
        ///mode: DWORD->unsigned int
        [DllImportAttribute("gdi32.dll", EntryPoint = "ModifyWorldTransform")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool ModifyWorldTransform([InAttribute] IntPtr hdc, [InAttribute] IntPtr lpxf, uint mode);


        /// Return Type: DWORD->unsigned int
        ///hdc: HDC->HDC__*
        ///lpgs: LPGLYPHSET->tagGLYPHSET*
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetFontUnicodeRanges")]
        public static extern uint GetFontUnicodeRanges([InAttribute] IntPtr hdc, IntPtr lpgs);


        /// Return Type: UINT->unsigned int
        ///hemf: HENHMETAFILE->HENHMETAFILE__*
        ///nSize: UINT->unsigned int
        ///lpEnhMetaHeader: LPENHMETAHEADER->tagENHMETAHEADER*
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetEnhMetaFileHeader")]
        public static extern uint GetEnhMetaFileHeader([InAttribute] IntPtr hemf, uint nSize, IntPtr lpEnhMetaHeader);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///lppt: LPPOINT->tagPOINT*
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetCurrentPositionEx")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool GetCurrentPositionEx([InAttribute] IntPtr hdc, [OutAttribute] out Point lppt);


        /// Return Type: BOOL->int
        ///hbit: HBITMAP->HBITMAP__*
        ///lpsize: LPSIZE->tagSIZE*
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetBitmapDimensionEx")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool GetBitmapDimensionEx([InAttribute] IntPtr hbit, [OutAttribute] out tagSIZE lpsize);


        /// Return Type: HRGN->HRGN__*
        ///pptl: POINT*
        ///pc: INT*
        ///cPoly: int
        ///iMode: int
        [DllImportAttribute("gdi32.dll", EntryPoint = "CreatePolyPolygonRgn")]
        public static extern IntPtr CreatePolyPolygonRgn([InAttribute] ref Point pptl, [InAttribute] ref int pc, int cPoly, int iMode);


        /// Return Type: HBITMAP->HBITMAP__*
        ///pbm: BITMAP*
        [DllImportAttribute("gdi32.dll", EntryPoint = "CreateBitmapIndirect")]
        public static extern IntPtr CreateBitmapIndirect([InAttribute] ref tagBITMAP pbm);


        /// Return Type: HANDLE->void*
        ///pFileView: PVOID->void*
        ///cjSize: DWORD->unsigned int
        ///pvResrved: PVOID->void*
        ///pNumFonts: DWORD*
        [DllImportAttribute("gdi32.dll", EntryPoint = "AddFontMemResourceEx")]
        public static extern IntPtr AddFontMemResourceEx([InAttribute] IntPtr pFileView, uint cjSize, IntPtr pvResrved, [InAttribute] ref uint pNumFonts);


        /// Return Type: UINT->unsigned int
        ///hdc: HDC->HDC__*
        ///use: UINT->unsigned int
        [DllImportAttribute("gdi32.dll", EntryPoint = "SetSystemPaletteUse")]
        public static extern uint SetSystemPaletteUse([InAttribute] IntPtr hdc, uint use);


        /// Return Type: BOOL->int
        ///lpFileName: LPCWSTR->WCHAR*
        [DllImportAttribute("gdi32.dll", EntryPoint = "RemoveFontResourceW")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool RemoveFontResourceW([InAttribute] [MarshalAsAttribute(UnmanagedType.LPWStr)] string lpFileName);


        /// Return Type: BOOL->int
        ///lpFileName: LPCSTR->CHAR*
        [DllImportAttribute("gdi32.dll", EntryPoint = "RemoveFontResourceA")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool RemoveFontResourceA([InAttribute] [MarshalAsAttribute(UnmanagedType.LPStr)] string lpFileName);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///x: int
        ///y: int
        ///lppt: LPPOINT->tagPOINT*
        [DllImportAttribute("gdi32.dll", EntryPoint = "OffsetViewportOrgEx")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool OffsetViewportOrgEx([InAttribute] IntPtr hdc, int x, int y, IntPtr lppt);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///lpString: LPCWSTR->WCHAR*
        ///c: int
        ///lpsz: LPSIZE->tagSIZE*
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetTextExtentPointW")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool GetTextExtentPointW([InAttribute] IntPtr hdc, [InAttribute] [MarshalAsAttribute(UnmanagedType.LPWStr)] string lpString, int c, [OutAttribute] out tagSIZE lpsz);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///pgiIn: LPWORD->WORD*
        ///cgi: int
        ///psize: LPSIZE->tagSIZE*
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetTextExtentPointI")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool GetTextExtentPointI([InAttribute] IntPtr hdc, [MarshalAsAttribute(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U2, SizeParamIndex = 2)] ushort[] pgiIn, int cgi, [OutAttribute] out tagSIZE psize);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///lpString: LPCSTR->CHAR*
        ///c: int
        ///lpsz: LPSIZE->tagSIZE*
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetTextExtentPointA")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool GetTextExtentPointA([InAttribute] IntPtr hdc, [InAttribute] [MarshalAsAttribute(UnmanagedType.LPStr)] string lpString, int c, [OutAttribute] out tagSIZE lpsz);


        /// Return Type: UINT->unsigned int
        ///hdc: HDC->HDC__*
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetSystemPaletteUse")]
        public static extern uint GetSystemPaletteUse([InAttribute] IntPtr hdc);


        /// Return Type: DWORD->unsigned int
        ///hdc: HDC->HDC__*
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetFontLanguageInfo")]
        public static extern uint GetFontLanguageInfo([InAttribute] IntPtr hdc);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///lpLogfont: LPLOGFONTW->tagLOGFONTW*
        ///lpProc: FONTENUMPROCW->OLDFONTENUMPROCW
        ///lParam: LPARAM->LONG_PTR->int
        ///dwFlags: DWORD->unsigned int
        [DllImportAttribute("gdi32.dll", EntryPoint = "EnumFontFamiliesExW")]
        public static extern int EnumFontFamiliesExW([InAttribute] IntPtr hdc, [InAttribute] ref tagLOGFONTW lpLogfont, OLDFONTENUMPROCW lpProc, [MarshalAsAttribute(UnmanagedType.SysInt)] int lParam, uint dwFlags);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///lpLogfont: LPLOGFONTA->tagLOGFONTA*
        ///lpProc: FONTENUMPROCA->OLDFONTENUMPROCA
        ///lParam: LPARAM->LONG_PTR->int
        ///dwFlags: DWORD->unsigned int
        [DllImportAttribute("gdi32.dll", EntryPoint = "EnumFontFamiliesExA")]
        public static extern int EnumFontFamiliesExA([InAttribute] IntPtr hdc, [InAttribute] ref tagLOGFONTA lpLogfont, OLDFONTENUMPROCA lpProc, [MarshalAsAttribute(UnmanagedType.SysInt)] int lParam, uint dwFlags);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///iPixelFormat: int
        ///nBytes: UINT->unsigned int
        ///ppfd: LPPIXELFORMATDESCRIPTOR->tagPIXELFORMATDESCRIPTOR*
        [DllImportAttribute("gdi32.dll", EntryPoint = "DescribePixelFormat")]
        public static extern int DescribePixelFormat([InAttribute] IntPtr hdc, int iPixelFormat, uint nBytes, IntPtr ppfd);


        /// Return Type: HFONT->HFONT__*
        ///lplf: LOGFONTW*
        [DllImportAttribute("gdi32.dll", EntryPoint = "CreateFontIndirectW")]
        public static extern IntPtr CreateFontIndirectW([InAttribute] ref tagLOGFONTW lplf);


        /// Return Type: HFONT->HFONT__*
        ///lplf: LOGFONTA*
        [DllImportAttribute("gdi32.dll", EntryPoint = "CreateFontIndirectA")]
        public static extern IntPtr CreateFontIndirectA([InAttribute] ref tagLOGFONTA lplf);


        /// Return Type: HBRUSH->HBRUSH__*
        ///plbrush: LOGBRUSH*
        [DllImportAttribute("gdi32.dll", EntryPoint = "CreateBrushIndirect")]
        public static extern IntPtr CreateBrushIndirect([InAttribute] ref tagLOGBRUSH plbrush);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///hPal: HPALETTE->HPALETTE__*
        ///deFirst: DWORD->unsigned int
        ///num: DWORD->unsigned int
        [DllImportAttribute("gdi32.dll", EntryPoint = "ColorCorrectPalette")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool ColorCorrectPalette([InAttribute] IntPtr hdc, [InAttribute] IntPtr hPal, uint deFirst, uint num);


        /// Return Type: HENHMETAFILE->HENHMETAFILE__*
        ///nSize: UINT->unsigned int
        ///lpMeta16Data: BYTE*
        ///hdcRef: HDC->HDC__*
        ///lpMFP: METAFILEPICT*
        [DllImportAttribute("gdi32.dll", EntryPoint = "SetWinMetaFileBits")]
        public static extern IntPtr SetWinMetaFileBits(uint nSize, [InAttribute] IntPtr lpMeta16Data, [InAttribute] IntPtr hdcRef, [InAttribute] IntPtr lpMFP);


        /// Return Type: HENHMETAFILE->HENHMETAFILE__*
        ///nSize: UINT->unsigned int
        ///pb: BYTE*
        [DllImportAttribute("gdi32.dll", EntryPoint = "SetEnhMetaFileBits")]
        public static extern IntPtr SetEnhMetaFileBits(uint nSize, [InAttribute] IntPtr pb);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///lpRamp: LPVOID->void*
        [DllImportAttribute("gdi32.dll", EntryPoint = "SetDeviceGammaRamp")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool SetDeviceGammaRamp([InAttribute] IntPtr hdc, [InAttribute] IntPtr lpRamp);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///lpca: COLORADJUSTMENT*
        [DllImportAttribute("gdi32.dll", EntryPoint = "SetColorAdjustment")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool SetColorAdjustment([InAttribute] IntPtr hdc, [InAttribute] ref tagCOLORADJUSTMENT lpca);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///xn: int
        ///dx: int
        ///yn: int
        ///yd: int
        ///lpsz: LPSIZE->tagSIZE*
        [DllImportAttribute("gdi32.dll", EntryPoint = "ScaleViewportExtEx")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool ScaleViewportExtEx([InAttribute] IntPtr hdc, int xn, int dx, int yn, int yd, IntPtr lpsz);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///lpHandleTable: LPHANDLETABLE->tagHANDLETABLE*
        ///lpMR: LPMETARECORD->tagMETARECORD*
        ///noObjs: UINT->unsigned int
        [DllImportAttribute("gdi32.dll", EntryPoint = "PlayMetaFileRecord")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool PlayMetaFileRecord([InAttribute] IntPtr hdc, [MarshalAsAttribute(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 3)] tagHANDLETABLE[] lpHandleTable, [InAttribute] ref tagMETARECORD lpMR, uint noObjs);


        /// Return Type: UINT->unsigned int
        ///hemf: HENHMETAFILE->HENHMETAFILE__*
        ///cbData16: UINT->unsigned int
        ///pData16: LPBYTE->BYTE*
        ///iMapMode: INT->int
        ///hdcRef: HDC->HDC__*
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetWinMetaFileBits")]
        public static extern uint GetWinMetaFileBits([InAttribute] IntPtr hemf, uint cbData16, IntPtr pData16, int iMapMode, [InAttribute] IntPtr hdcRef);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///lpSig: LPFONTSIGNATURE->tagFONTSIGNATURE*
        ///dwFlags: DWORD->unsigned int
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetTextCharsetInfo")]
        public static extern int GetTextCharsetInfo([InAttribute] IntPtr hdc, IntPtr lpSig, uint dwFlags);


        /// Return Type: UINT->unsigned int
        ///hEMF: HENHMETAFILE->HENHMETAFILE__*
        ///nSize: UINT->unsigned int
        ///lpData: LPBYTE->BYTE*
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetEnhMetaFileBits")]
        public static extern uint GetEnhMetaFileBits([InAttribute] IntPtr hEMF, uint nSize, IntPtr lpData);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///lpRamp: LPVOID->void*
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetDeviceGammaRamp")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool GetDeviceGammaRamp([InAttribute] IntPtr hdc, IntPtr lpRamp);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///lpca: LPCOLORADJUSTMENT->tagCOLORADJUSTMENT*
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetColorAdjustment")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool GetColorAdjustment([InAttribute] IntPtr hdc, [OutAttribute] out tagCOLORADJUSTMENT lpca);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///iFirst: UINT->unsigned int
        ///iLast: UINT->unsigned int
        ///lpBuffer: PFLOAT->FLOAT*
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetCharWidthFloatW")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool GetCharWidthFloatW([InAttribute] IntPtr hdc, uint iFirst, uint iLast, IntPtr lpBuffer);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///iFirst: UINT->unsigned int
        ///iLast: UINT->unsigned int
        ///lpBuffer: PFLOAT->FLOAT*
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetCharWidthFloatA")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool GetCharWidthFloatA([InAttribute] IntPtr hdc, uint iFirst, uint iLast, IntPtr lpBuffer);


        /// Return Type: HRGN->HRGN__*
        ///x1: int
        ///y1: int
        ///x2: int
        ///y2: int
        ///w: int
        ///h: int
        [DllImportAttribute("gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRgn(int x1, int y1, int x2, int y2, int w, int h);


        /// Return Type: HBRUSH->HBRUSH__*
        ///hbm: HBITMAP->HBITMAP__*
        [DllImportAttribute("gdi32.dll", EntryPoint = "CreatePatternBrush")]
        public static extern IntPtr CreatePatternBrush([InAttribute] IntPtr hbm);


        /// Return Type: HDC->HDC__*
        ///hdc: HDC->HDC__*
        ///lpFilename: LPCWSTR->WCHAR*
        ///lprc: RECT*
        ///lpDesc: LPCWSTR->WCHAR*
        [DllImportAttribute("gdi32.dll", EntryPoint = "CreateEnhMetaFileW")]
        public static extern IntPtr CreateEnhMetaFileW([InAttribute] IntPtr hdc, [InAttribute] [MarshalAsAttribute(UnmanagedType.LPWStr)] string lpFilename, [InAttribute] IntPtr lprc, [InAttribute] [MarshalAsAttribute(UnmanagedType.LPWStr)] string lpDesc);


        /// Return Type: HDC->HDC__*
        ///hdc: HDC->HDC__*
        ///lpFilename: LPCSTR->CHAR*
        ///lprc: RECT*
        ///lpDesc: LPCSTR->CHAR*
        [DllImportAttribute("gdi32.dll", EntryPoint = "CreateEnhMetaFileA")]
        public static extern IntPtr CreateEnhMetaFileA([InAttribute] IntPtr hdc, [InAttribute] [MarshalAsAttribute(UnmanagedType.LPStr)] string lpFilename, [InAttribute] IntPtr lprc, [InAttribute] [MarshalAsAttribute(UnmanagedType.LPStr)] string lpDesc);


        /// Return Type: HDC->HDC__*
        ///hdc: HDC->HDC__*
        [DllImportAttribute("gdi32.dll", EntryPoint = "CreateCompatibleDC")]
        public static extern IntPtr CreateCompatibleDC([InAttribute] IntPtr hdc);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///hdcTarget: HDC->HDC__*
        ///action: DWORD->unsigned int
        [DllImportAttribute("gdi32.dll", EntryPoint = "ColorMatchToTarget")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool ColorMatchToTarget([InAttribute] IntPtr hdc, [InAttribute] IntPtr hdcTarget, uint action);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///lpRGBTriple: LPVOID->void*
        ///dlpBuffer: LPVOID->void*
        ///nCount: DWORD->unsigned int
        [DllImportAttribute("gdi32.dll", EntryPoint = "CheckColorsInGamut")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool CheckColorsInGamut([InAttribute] IntPtr hdc, [InAttribute] IntPtr lpRGBTriple, IntPtr dlpBuffer, uint nCount);


        /// Return Type: int
        ///name: LPCWSTR->WCHAR*
        ///fl: DWORD->unsigned int
        ///res: PVOID->void*
        [DllImportAttribute("gdi32.dll", EntryPoint = "AddFontResourceExW")]
        public static extern int AddFontResourceExW([InAttribute] [MarshalAsAttribute(UnmanagedType.LPWStr)] string name, uint fl, IntPtr res);


        /// Return Type: int
        ///name: LPCSTR->CHAR*
        ///fl: DWORD->unsigned int
        ///res: PVOID->void*
        [DllImportAttribute("gdi32.dll", EntryPoint = "AddFontResourceExA")]
        public static extern int AddFontResourceExA([InAttribute] [MarshalAsAttribute(UnmanagedType.LPStr)] string name, uint fl, IntPtr res);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        [DllImportAttribute("gdi32.dll", EntryPoint = "StrokeAndFillPath")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool StrokeAndFillPath([InAttribute] IntPtr hdc);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///lpxf: XFORM*
        [DllImportAttribute("gdi32.dll", EntryPoint = "SetWorldTransform")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool SetWorldTransform([InAttribute] IntPtr hdc, [InAttribute] ref tagXFORM lpxf);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///mode: int
        [DllImportAttribute("gdi32.dll", EntryPoint = "SetStretchBltMode")]
        public static extern int SetStretchBltMode([InAttribute] IntPtr hdc, int mode);


        /// Return Type: UINT->unsigned int
        ///hpal: HPALETTE->HPALETTE__*
        ///iStart: UINT->unsigned int
        ///cEntries: UINT->unsigned int
        ///pPalEntries: PALETTEENTRY*
        [DllImportAttribute("gdi32.dll", EntryPoint = "SetPaletteEntries")]
        public static extern uint SetPaletteEntries([InAttribute] IntPtr hpal, uint iStart, uint cEntries, [MarshalAsAttribute(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 2)] tagPALETTEENTRY[] pPalEntries);


        /// Return Type: HMETAFILE->HMETAFILE__*
        ///cbBuffer: UINT->unsigned int
        ///lpData: BYTE*
        [DllImportAttribute("gdi32.dll", EntryPoint = "SetMetaFileBitsEx")]
        public static extern IntPtr SetMetaFileBitsEx(uint cbBuffer, [InAttribute] IntPtr lpData);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///xDest: int
        ///yDest: int
        ///w: DWORD->unsigned int
        ///h: DWORD->unsigned int
        ///xSrc: int
        ///ySrc: int
        ///StartScan: UINT->unsigned int
        ///cLines: UINT->unsigned int
        ///lpvBits: void*
        ///lpbmi: BITMAPINFO*
        ///ColorUse: UINT->unsigned int
        [DllImportAttribute("gdi32.dll", EntryPoint = "SetDIBitsToDevice")]
        public static extern int SetDIBitsToDevice([InAttribute] IntPtr hdc, int xDest, int yDest, uint w, uint h, int xSrc, int ySrc, uint StartScan, uint cLines, [InAttribute] IntPtr lpvBits, [InAttribute] ref tagBITMAPINFO lpbmi, uint ColorUse);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///x: int
        ///y: int
        ///lppt: LPPOINT->tagPOINT*
        [DllImportAttribute("gdi32.dll", EntryPoint = "OffsetWindowOrgEx")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool OffsetWindowOrgEx([InAttribute] IntPtr hdc, int x, int y, IntPtr lppt);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///left: int
        ///top: int
        ///right: int
        ///bottom: int
        [DllImportAttribute("gdi32.dll", EntryPoint = "IntersectClipRect")]
        public static extern int IntersectClipRect([InAttribute] IntPtr hdc, int left, int top, int right, int bottom);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///lpxf: LPXFORM->tagXFORM*
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetWorldTransform")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool GetWorldTransform([InAttribute] IntPtr hdc, [OutAttribute] out tagXFORM lpxf);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetStretchBltMode")]
        public static extern int GetStretchBltMode([InAttribute] IntPtr hdc);


        /// Return Type: BOOL->int
        ///lpraststat: LPRASTERIZER_STATUS->_RASTERIZER_STATUS*
        ///cjBytes: UINT->unsigned int
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetRasterizerCaps")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool GetRasterizerCaps(IntPtr lpraststat, uint cjBytes);


        /// Return Type: UINT->unsigned int
        ///hpal: HPALETTE->HPALETTE__*
        ///iStart: UINT->unsigned int
        ///cEntries: UINT->unsigned int
        ///pPalEntries: LPPALETTEENTRY->tagPALETTEENTRY*
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetPaletteEntries")]
        public static extern uint GetPaletteEntries([InAttribute] IntPtr hpal, uint iStart, uint cEntries, IntPtr pPalEntries);


        /// Return Type: UINT->unsigned int
        ///hMF: HMETAFILE->HMETAFILE__*
        ///cbBuffer: UINT->unsigned int
        ///lpData: LPVOID->void*
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetMetaFileBitsEx")]
        public static extern uint GetMetaFileBitsEx([InAttribute] IntPtr hMF, uint cbBuffer, IntPtr lpData);


        /// Return Type: BOOL->int
        ///hColorSpace: HCOLORSPACE->HCOLORSPACE__*
        ///lpBuffer: LPLOGCOLORSPACEW->tagLOGCOLORSPACEW*
        ///nSize: DWORD->unsigned int
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetLogColorSpaceW")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool GetLogColorSpaceW([InAttribute] IntPtr hColorSpace, IntPtr lpBuffer, uint nSize);


        /// Return Type: BOOL->int
        ///hColorSpace: HCOLORSPACE->HCOLORSPACE__*
        ///lpBuffer: LPLOGCOLORSPACEA->tagLOGCOLORSPACEA*
        ///nSize: DWORD->unsigned int
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetLogColorSpaceA")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool GetLogColorSpaceA([InAttribute] IntPtr hColorSpace, IntPtr lpBuffer, uint nSize);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///wFirst: UINT->unsigned int
        ///wLast: UINT->unsigned int
        ///lpABC: LPABC->_ABC*
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetCharABCWidthsW")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool GetCharABCWidthsW([InAttribute] IntPtr hdc, uint wFirst, uint wLast, IntPtr lpABC);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///giFirst: UINT->unsigned int
        ///cgi: UINT->unsigned int
        ///pgi: LPWORD->WORD*
        ///pabc: LPABC->_ABC*
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetCharABCWidthsI")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool GetCharABCWidthsI([InAttribute] IntPtr hdc, uint giFirst, uint cgi, [InAttribute] IntPtr pgi, IntPtr pabc);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///wFirst: UINT->unsigned int
        ///wLast: UINT->unsigned int
        ///lpABC: LPABC->_ABC*
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetCharABCWidthsA")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool GetCharABCWidthsA([InAttribute] IntPtr hdc, uint wFirst, uint wLast, IntPtr lpABC);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///lpLogfont: LPCWSTR->WCHAR*
        ///lpProc: FONTENUMPROCW->OLDFONTENUMPROCW
        ///lParam: LPARAM->LONG_PTR->int
        [DllImportAttribute("gdi32.dll", EntryPoint = "EnumFontFamiliesW")]
        public static extern int EnumFontFamiliesW([InAttribute] IntPtr hdc, [InAttribute] [MarshalAsAttribute(UnmanagedType.LPWStr)] string lpLogfont, OLDFONTENUMPROCW lpProc, [MarshalAsAttribute(UnmanagedType.SysInt)] int lParam);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///lpLogfont: LPCSTR->CHAR*
        ///lpProc: FONTENUMPROCA->OLDFONTENUMPROCA
        ///lParam: LPARAM->LONG_PTR->int
        [DllImportAttribute("gdi32.dll", EntryPoint = "EnumFontFamiliesA")]
        public static extern int EnumFontFamiliesA([InAttribute] IntPtr hdc, [InAttribute] [MarshalAsAttribute(UnmanagedType.LPStr)] string lpLogfont, OLDFONTENUMPROCA lpProc, [MarshalAsAttribute(UnmanagedType.SysInt)] int lParam);


        /// Return Type: BOOL->int
        ///hmf: HENHMETAFILE->HENHMETAFILE__*
        [DllImportAttribute("gdi32.dll", EntryPoint = "DeleteEnhMetaFile")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool DeleteEnhMetaFile([InAttribute] IntPtr hmf);


        /// Return Type: HPEN->HPEN__*
        ///plpen: LOGPEN*
        [DllImportAttribute("gdi32.dll", EntryPoint = "CreatePenIndirect")]
        public static extern IntPtr CreatePenIndirect([InAttribute] ref tagLOGPEN plpen);


        /// Return Type: HRGN->HRGN__*
        ///x1: int
        ///y1: int
        ///x2: int
        ///y2: int
        [DllImportAttribute("gdi32.dll", EntryPoint = "CreateEllipticRgn")]
        public static extern IntPtr CreateEllipticRgn(int x1, int y1, int x2, int y2);


        /// Return Type: HCOLORSPACE->HCOLORSPACE__*
        ///lplcs: LPLOGCOLORSPACEW->tagLOGCOLORSPACEW*
        [DllImportAttribute("gdi32.dll", EntryPoint = "CreateColorSpaceW")]
        public static extern IntPtr CreateColorSpaceW([InAttribute] ref tagLOGCOLORSPACEW lplcs);


        /// Return Type: HCOLORSPACE->HCOLORSPACE__*
        ///lplcs: LPLOGCOLORSPACEA->tagLOGCOLORSPACEA*
        [DllImportAttribute("gdi32.dll", EntryPoint = "CreateColorSpaceA")]
        public static extern IntPtr CreateColorSpaceA([InAttribute] ref tagLOGCOLORSPACEA lplcs);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///ppfd: PIXELFORMATDESCRIPTOR*
        [DllImportAttribute("gdi32.dll", EntryPoint = "ChoosePixelFormat")]
        public static extern int ChoosePixelFormat([InAttribute] IntPtr hdc, [InAttribute] ref tagPIXELFORMATDESCRIPTOR ppfd);


        /// Return Type: BOOL->int
        ///reserved: DWORD->unsigned int
        ///lpszCMID: LPWSTR->WCHAR*
        ///lpszFileName: LPWSTR->WCHAR*
        ///command: UINT->unsigned int
        [DllImportAttribute("gdi32.dll", EntryPoint = "UpdateICMRegKeyW")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool UpdateICMRegKeyW(uint reserved, [InAttribute] [MarshalAsAttribute(UnmanagedType.LPWStr)] string lpszCMID, [InAttribute] [MarshalAsAttribute(UnmanagedType.LPWStr)] string lpszFileName, uint command);


        /// Return Type: BOOL->int
        ///reserved: DWORD->unsigned int
        ///lpszCMID: LPSTR->CHAR*
        ///lpszFileName: LPSTR->CHAR*
        ///command: UINT->unsigned int
        [DllImportAttribute("gdi32.dll", EntryPoint = "UpdateICMRegKeyA")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool UpdateICMRegKeyA(uint reserved, [InAttribute] [MarshalAsAttribute(UnmanagedType.LPStr)] string lpszCMID, [InAttribute] [MarshalAsAttribute(UnmanagedType.LPStr)] string lpszFileName, uint command);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///x: int
        ///y: int
        ///lppt: LPPOINT->tagPOINT*
        [DllImportAttribute("gdi32.dll", EntryPoint = "SetViewportOrgEx")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool SetViewportOrgEx([InAttribute] IntPtr hdc, int x, int y, IntPtr lppt);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///x: int
        ///y: int
        ///lpsz: LPSIZE->tagSIZE*
        [DllImportAttribute("gdi32.dll", EntryPoint = "SetViewportExtEx")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool SetViewportExtEx([InAttribute] IntPtr hdc, int x, int y, IntPtr lpsz);


        /// Return Type: UINT->unsigned int
        ///hdc: HDC->HDC__*
        ///iStart: UINT->unsigned int
        ///cEntries: UINT->unsigned int
        ///prgbq: RGBQUAD*
        [DllImportAttribute("gdi32.dll", EntryPoint = "SetDIBColorTable")]
        public static extern uint SetDIBColorTable([InAttribute] IntPtr hdc, uint iStart, uint cEntries, [MarshalAsAttribute(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 2)] tagRGBQUAD[] prgbq);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///xn: int
        ///xd: int
        ///yn: int
        ///yd: int
        ///lpsz: LPSIZE->tagSIZE*
        [DllImportAttribute("gdi32.dll", EntryPoint = "ScaleWindowExtEx")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool ScaleWindowExtEx([InAttribute] IntPtr hdc, int xn, int xd, int yn, int yd, IntPtr lpsz);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///lppoint: LPPOINT->tagPOINT*
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetViewportOrgEx")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool GetViewportOrgEx([InAttribute] IntPtr hdc, [OutAttribute] out Point lppoint);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///lpsize: LPSIZE->tagSIZE*
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetViewportExtEx")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool GetViewportExtEx([InAttribute] IntPtr hdc, [OutAttribute] out tagSIZE lpsize);


        /// Return Type: DWORD->unsigned int
        ///hdc: HDC->HDC__*
        ///nPairs: DWORD->unsigned int
        ///lpKernPair: LPKERNINGPAIR->tagKERNINGPAIR*
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetKerningPairsW")]
        public static extern uint GetKerningPairsW([InAttribute] IntPtr hdc, uint nPairs, IntPtr lpKernPair);


        /// Return Type: DWORD->unsigned int
        ///hdc: HDC->HDC__*
        ///nPairs: DWORD->unsigned int
        ///lpKernPair: LPKERNINGPAIR->tagKERNINGPAIR*
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetKerningPairsA")]
        public static extern uint GetKerningPairsA([InAttribute] IntPtr hdc, uint nPairs, IntPtr lpKernPair);


        /// Return Type: DWORD->unsigned int
        ///hdc: HDC->HDC__*
        ///uChar: UINT->unsigned int
        ///fuFormat: UINT->unsigned int
        ///lpgm: LPGLYPHMETRICS->_GLYPHMETRICS*
        ///cjBuffer: DWORD->unsigned int
        ///pvBuffer: LPVOID->void*
        ///lpmat2: MAT2*
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetGlyphOutlineW")]
        public static extern uint GetGlyphOutlineW([InAttribute] IntPtr hdc, uint uChar, uint fuFormat, [OutAttribute] out GLYPHMETRICS lpgm, uint cjBuffer, IntPtr pvBuffer, [InAttribute] ref MAT2 lpmat2);


        /// Return Type: DWORD->unsigned int
        ///hdc: HDC->HDC__*
        ///uChar: UINT->unsigned int
        ///fuFormat: UINT->unsigned int
        ///lpgm: LPGLYPHMETRICS->_GLYPHMETRICS*
        ///cjBuffer: DWORD->unsigned int
        ///pvBuffer: LPVOID->void*
        ///lpmat2: MAT2*
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetGlyphOutlineA")]
        public static extern uint GetGlyphOutlineA([InAttribute] IntPtr hdc, uint uChar, uint fuFormat, [OutAttribute] out GLYPHMETRICS lpgm, uint cjBuffer, IntPtr pvBuffer, [InAttribute] ref MAT2 lpmat2);


        /// Return Type: DWORD->unsigned int
        ///hdc: HDC->HDC__*
        ///lpstr: LPCWSTR->WCHAR*
        ///c: int
        ///pgi: LPWORD->WORD*
        ///fl: DWORD->unsigned int
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetGlyphIndicesW")]
        public static extern uint GetGlyphIndicesW([InAttribute] IntPtr hdc, [InAttribute] [MarshalAsAttribute(UnmanagedType.LPWStr)] string lpstr, int c, IntPtr pgi, uint fl);


        /// Return Type: DWORD->unsigned int
        ///hdc: HDC->HDC__*
        ///lpstr: LPCSTR->CHAR*
        ///c: int
        ///pgi: LPWORD->WORD*
        ///fl: DWORD->unsigned int
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetGlyphIndicesA")]
        public static extern uint GetGlyphIndicesA([InAttribute] IntPtr hdc, [InAttribute] [MarshalAsAttribute(UnmanagedType.LPStr)] string lpstr, int c, IntPtr pgi, uint fl);


        /// Return Type: UINT->unsigned int
        ///hdc: HDC->HDC__*
        ///iStart: UINT->unsigned int
        ///cEntries: UINT->unsigned int
        ///prgbq: RGBQUAD*
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetDIBColorTable")]
        public static extern uint GetDIBColorTable([InAttribute] IntPtr hdc, uint iStart, uint cEntries, IntPtr prgbq);


        /// Return Type: HGDIOBJ->void*
        ///hdc: HDC->HDC__*
        ///type: UINT->unsigned int
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetCurrentObject")]
        public static extern IntPtr GetCurrentObject([InAttribute] IntPtr hdc, uint type);


        /// Return Type: DWORD->unsigned int
        ///dw: DWORD->unsigned int
        [DllImportAttribute("gdi32.dll", EntryPoint = "GdiSetBatchLimit")]
        public static extern uint GdiSetBatchLimit(uint dw);


        /// Return Type: DWORD->unsigned int
        [DllImportAttribute("gdi32.dll", EntryPoint = "GdiGetBatchLimit")]
        public static extern uint GdiGetBatchLimit();


        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///hrgn: HRGN->HRGN__*
        ///mode: int
        [DllImportAttribute("gdi32.dll", EntryPoint = "ExtSelectClipRgn")]
        public static extern int ExtSelectClipRgn([InAttribute] IntPtr hdc, [InAttribute] IntPtr hrgn, int mode);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///proc: ICMENUMPROCW
        ///param: LPARAM->LONG_PTR->int
        [DllImportAttribute("gdi32.dll", EntryPoint = "EnumICMProfilesW")]
        public static extern int EnumICMProfilesW([InAttribute] IntPtr hdc, ICMENUMPROCW proc, [MarshalAsAttribute(UnmanagedType.SysInt)] int param);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///proc: ICMENUMPROCA
        ///param: LPARAM->LONG_PTR->int
        [DllImportAttribute("gdi32.dll", EntryPoint = "EnumICMProfilesA")]
        public static extern int EnumICMProfilesA([InAttribute] IntPtr hdc, ICMENUMPROCA proc, [MarshalAsAttribute(UnmanagedType.SysInt)] int param);


        /// Return Type: BOOL->int
        ///hcs: HCOLORSPACE->HCOLORSPACE__*
        [DllImportAttribute("gdi32.dll", EntryPoint = "DeleteColorSpace")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool DeleteColorSpace([InAttribute] IntPtr hcs);


        /// Return Type: HBRUSH->HBRUSH__*
        ///color: COLORREF->DWORD->unsigned int
        [DllImportAttribute("gdi32.dll", EntryPoint = "CreateSolidBrush")]
        public static extern IntPtr CreateSolidBrush(uint color);


        /// Return Type: HRGN->HRGN__*
        ///pptl: POINT*
        ///cPoint: int
        ///iMode: int
        [DllImportAttribute("gdi32.dll", EntryPoint = "CreatePolygonRgn")]
        public static extern IntPtr CreatePolygonRgn([MarshalAsAttribute(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 1)] Point[] pptl, int cPoint, int iMode);


        /// Return Type: HBRUSH->HBRUSH__*
        ///iHatch: int
        ///color: COLORREF->DWORD->unsigned int
        [DllImportAttribute("gdi32.dll", EntryPoint = "CreateHatchBrush")]
        public static extern IntPtr CreateHatchBrush(int iHatch, uint color);


        /// Return Type: HBITMAP->HBITMAP__*
        ///hdc: HDC->HDC__*
        ///lpbmi: BITMAPINFO*
        ///usage: UINT->unsigned int
        ///ppvBits: void**
        ///hSection: HANDLE->void*
        ///offset: DWORD->unsigned int
        [DllImportAttribute("gdi32.dll", EntryPoint = "CreateDIBSection")]
        public static extern IntPtr CreateDIBSection([InAttribute] IntPtr hdc, [InAttribute] ref tagBITMAPINFO lpbmi, uint usage, ref IntPtr ppvBits, [InAttribute] IntPtr hSection, uint offset);


        /// Return Type: HENHMETAFILE->HENHMETAFILE__*
        ///hEnh: HENHMETAFILE->HENHMETAFILE__*
        ///lpFileName: LPCWSTR->WCHAR*
        [DllImportAttribute("gdi32.dll", EntryPoint = "CopyEnhMetaFileW")]
        public static extern IntPtr CopyEnhMetaFileW([InAttribute] IntPtr hEnh, [InAttribute] [MarshalAsAttribute(UnmanagedType.LPWStr)] string lpFileName);


        /// Return Type: HENHMETAFILE->HENHMETAFILE__*
        ///hEnh: HENHMETAFILE->HENHMETAFILE__*
        ///lpFileName: LPCSTR->CHAR*
        [DllImportAttribute("gdi32.dll", EntryPoint = "CopyEnhMetaFileA")]
        public static extern IntPtr CopyEnhMetaFileA([InAttribute] IntPtr hEnh, [InAttribute] [MarshalAsAttribute(UnmanagedType.LPStr)] string lpFileName);


        /// Return Type: BOOL->int
        ///lpxfOut: LPXFORM->tagXFORM*
        ///lpxf1: XFORM*
        ///lpxf2: XFORM*
        [DllImportAttribute("gdi32.dll", EntryPoint = "CombineTransform")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool CombineTransform([OutAttribute] out tagXFORM lpxfOut, [InAttribute] ref tagXFORM lpxf1, [InAttribute] ref tagXFORM lpxf2);


        /// Return Type: HENHMETAFILE->HENHMETAFILE__*
        ///hdc: HDC->HDC__*
        [DllImportAttribute("gdi32.dll", EntryPoint = "CloseEnhMetaFile")]
        public static extern IntPtr CloseEnhMetaFile([InAttribute] IntPtr hdc);


        /// Return Type: int
        ///param0: LPCWSTR->WCHAR*
        [DllImportAttribute("gdi32.dll", EntryPoint = "AddFontResourceW")]
        public static extern int AddFontResourceW([InAttribute] [MarshalAsAttribute(UnmanagedType.LPWStr)] string param0);


        /// Return Type: int
        ///param0: LPCSTR->CHAR*
        [DllImportAttribute("gdi32.dll", EntryPoint = "AddFontResourceA")]
        public static extern int AddFontResourceA([InAttribute] [MarshalAsAttribute(UnmanagedType.LPStr)] string param0);


        /// Return Type: BOOL->int
        ///h: HGDIOBJ->void*
        [DllImportAttribute("gdi32.dll", EntryPoint = "UnrealizeObject")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool UnrealizeObject([InAttribute] IntPtr h);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///mode: int
        [DllImportAttribute("gdi32.dll", EntryPoint = "SetPolyFillMode")]
        public static extern int SetPolyFillMode([InAttribute] IntPtr hdc, int mode);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///iMode: int
        [DllImportAttribute("gdi32.dll", EntryPoint = "SetGraphicsMode")]
        public static extern int SetGraphicsMode([InAttribute] IntPtr hdc, int iMode);


        /// Return Type: COLORREF->DWORD->unsigned int
        ///hdc: HDC->HDC__*
        ///color: COLORREF->DWORD->unsigned int
        [DllImportAttribute("gdi32.dll", EntryPoint = "SetDCBrushColor")]
        public static extern uint SetDCBrushColor([InAttribute] IntPtr hdc, uint color);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///dir: int
        [DllImportAttribute("gdi32.dll", EntryPoint = "SetArcDirection")]
        public static extern int SetArcDirection([InAttribute] IntPtr hdc, int dir);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///hmf: HENHMETAFILE->HENHMETAFILE__*
        ///lprect: RECT*
        [DllImportAttribute("gdi32.dll", EntryPoint = "PlayEnhMetaFile")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool PlayEnhMetaFile([InAttribute] IntPtr hdc, [InAttribute] IntPtr hmf, [InAttribute] ref tagRECT lprect);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///lptm: LPTEXTMETRICW->tagTEXTMETRICW*
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetTextMetricsW")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool GetTextMetricsW([InAttribute] IntPtr hdc, [OutAttribute] out tagTEXTMETRICW lptm);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///lptm: LPTEXTMETRICA->tagTEXTMETRICA*
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetTextMetricsA")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool GetTextMetricsA([InAttribute] IntPtr hdc, [OutAttribute] out tagTEXTMETRICA lptm);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetPolyFillMode")]
        public static extern int GetPolyFillMode([InAttribute] IntPtr hdc);


        /// Return Type: COLORREF->DWORD->unsigned int
        ///hdc: HDC->HDC__*
        ///color: COLORREF->DWORD->unsigned int
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetNearestColor")]
        public static extern uint GetNearestColor([InAttribute] IntPtr hdc, uint color);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetGraphicsMode")]
        public static extern int GetGraphicsMode([InAttribute] IntPtr hdc);


        /// Return Type: HENHMETAFILE->HENHMETAFILE__*
        ///lpName: LPCWSTR->WCHAR*
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetEnhMetaFileW")]
        public static extern IntPtr GetEnhMetaFileW([InAttribute] [MarshalAsAttribute(UnmanagedType.LPWStr)] string lpName);


        /// Return Type: HENHMETAFILE->HENHMETAFILE__*
        ///lpName: LPCSTR->CHAR*
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetEnhMetaFileA")]
        public static extern IntPtr GetEnhMetaFileA([InAttribute] [MarshalAsAttribute(UnmanagedType.LPStr)] string lpName);


        /// Return Type: COLORREF->DWORD->unsigned int
        ///hdc: HDC->HDC__*
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetDCBrushColor")]
        public static extern uint GetDCBrushColor([InAttribute] IntPtr hdc);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///iFirst: UINT->unsigned int
        ///iLast: UINT->unsigned int
        ///lpBuffer: LPINT->int*
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetCharWidth32W")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool GetCharWidth32W([InAttribute] IntPtr hdc, uint iFirst, uint iLast, IntPtr lpBuffer);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///iFirst: UINT->unsigned int
        ///iLast: UINT->unsigned int
        ///lpBuffer: LPINT->int*
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetCharWidth32A")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool GetCharWidth32A([InAttribute] IntPtr hdc, uint iFirst, uint iLast, IntPtr lpBuffer);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetArcDirection")]
        public static extern int GetArcDirection([InAttribute] IntPtr hdc);


        /// Return Type: HRGN->HRGN__*
        ///lpx: XFORM*
        ///nCount: DWORD->unsigned int
        ///lpData: RGNDATA*
        [DllImportAttribute("gdi32.dll", EntryPoint = "ExtCreateRegion")]
        public static extern IntPtr ExtCreateRegion([InAttribute] IntPtr lpx, uint nCount, [InAttribute] IntPtr lpData);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///left: int
        ///top: int
        ///right: int
        ///bottom: int
        [DllImportAttribute("gdi32.dll", EntryPoint = "ExcludeClipRect")]
        public static extern int ExcludeClipRect([InAttribute] IntPtr hdc, int left, int top, int right, int bottom);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///hmf: HENHMETAFILE->HENHMETAFILE__*
        ///proc: ENHMFENUMPROC
        ///param: LPVOID->void*
        ///lpRect: RECT*
        [DllImportAttribute("gdi32.dll", EntryPoint = "EnumEnhMetaFile")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool EnumEnhMetaFile([InAttribute] IntPtr hdc, [InAttribute] IntPtr hmf, ENHMFENUMPROC proc, [InAttribute] IntPtr param, [InAttribute] IntPtr lpRect);


        /// Return Type: HDC->HDC__*
        ///pszFile: LPCWSTR->WCHAR*
        [DllImportAttribute("gdi32.dll", EntryPoint = "CreateMetaFileW")]
        public static extern IntPtr CreateMetaFileW([InAttribute] [MarshalAsAttribute(UnmanagedType.LPWStr)] string pszFile);


        /// Return Type: HDC->HDC__*
        ///pszFile: LPCSTR->CHAR*
        [DllImportAttribute("gdi32.dll", EntryPoint = "CreateMetaFileA")]
        public static extern IntPtr CreateMetaFileA([InAttribute] [MarshalAsAttribute(UnmanagedType.LPStr)] string pszFile);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///x: int
        ///y: int
        ///lppt: LPPOINT->tagPOINT*
        [DllImportAttribute("gdi32.dll", EntryPoint = "SetWindowOrgEx")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool SetWindowOrgEx([InAttribute] IntPtr hdc, int x, int y, IntPtr lppt);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///x: int
        ///y: int
        ///lpsz: LPSIZE->tagSIZE*
        [DllImportAttribute("gdi32.dll", EntryPoint = "SetWindowExtEx")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool SetWindowExtEx([InAttribute] IntPtr hdc, int x, int y, IntPtr lpsz);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///format: int
        ///ppfd: PIXELFORMATDESCRIPTOR*
        [DllImportAttribute("gdi32.dll", EntryPoint = "SetPixelFormat")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool SetPixelFormat([InAttribute] IntPtr hdc, int format, [InAttribute] ref tagPIXELFORMATDESCRIPTOR ppfd);


        /// Return Type: DWORD->unsigned int
        ///hdc: HDC->HDC__*
        ///flags: DWORD->unsigned int
        [DllImportAttribute("gdi32.dll", EntryPoint = "SetMapperFlags")]
        public static extern uint SetMapperFlags([InAttribute] IntPtr hdc, uint flags);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///lpFileName: LPWSTR->WCHAR*
        [DllImportAttribute("gdi32.dll", EntryPoint = "SetICMProfileW")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool SetICMProfileW([InAttribute] IntPtr hdc, [InAttribute] [MarshalAsAttribute(UnmanagedType.LPWStr)] string lpFileName);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///lpFileName: LPSTR->CHAR*
        [DllImportAttribute("gdi32.dll", EntryPoint = "SetICMProfileA")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool SetICMProfileA([InAttribute] IntPtr hdc, [InAttribute] [MarshalAsAttribute(UnmanagedType.LPStr)] string lpFileName);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///mode: int
        [DllImportAttribute("gdi32.dll", EntryPoint = "SelectClipPath")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool SelectClipPath([InAttribute] IntPtr hdc, int mode);


        /// Return Type: UINT->unsigned int
        ///hdc: HDC->HDC__*
        [DllImportAttribute("gdi32.dll", EntryPoint = "RealizePalette")]
        public static extern uint RealizePalette([InAttribute] IntPtr hdc);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///lppoint: LPPOINT->tagPOINT*
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetWindowOrgEx")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool GetWindowOrgEx([InAttribute] IntPtr hdc, [OutAttribute] out Point lppoint);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///lpsize: LPSIZE->tagSIZE*
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetWindowExtEx")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool GetWindowExtEx([InAttribute] IntPtr hdc, [OutAttribute] out tagSIZE lpsize);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetTextCharset")]
        public static extern int GetTextCharset([InAttribute] IntPtr hdc);


        /// Return Type: HGDIOBJ->void*
        ///i: int
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetStockObject")]
        public static extern IntPtr GetStockObject(int i);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetPixelFormat")]
        public static extern int GetPixelFormat([InAttribute] IntPtr hdc);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///pBufSize: LPDWORD->DWORD*
        ///pszFilename: LPWSTR->WCHAR*
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetICMProfileW")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool GetICMProfileW([InAttribute] IntPtr hdc, ref uint pBufSize, [OutAttribute] [MarshalAsAttribute(UnmanagedType.LPWStr)] StringBuilder pszFilename);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///pBufSize: LPDWORD->DWORD*
        ///pszFilename: LPSTR->CHAR*
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetICMProfileA")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool GetICMProfileA([InAttribute] IntPtr hdc, ref uint pBufSize, [OutAttribute] [MarshalAsAttribute(UnmanagedType.LPStr)] StringBuilder pszFilename);


        /// Return Type: BOOL->int
        ///hmf: HMETAFILE->HMETAFILE__*
        [DllImportAttribute("gdi32.dll", EntryPoint = "DeleteMetaFile")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool DeleteMetaFile([InAttribute] IntPtr hmf);


        /// Return Type: HBITMAP->HBITMAP__*
        ///hdc: HDC->HDC__*
        ///pbmih: BITMAPINFOHEADER*
        ///flInit: DWORD->unsigned int
        ///pjBits: void*
        ///pbmi: BITMAPINFO*
        ///iUsage: UINT->unsigned int
        [DllImportAttribute("gdi32.dll", EntryPoint = "CreateDIBitmap")]
        public static extern IntPtr CreateDIBitmap([InAttribute] IntPtr hdc, [InAttribute] IntPtr pbmih, uint flInit, [InAttribute] IntPtr pjBits, [InAttribute] IntPtr pbmi, uint iUsage);


        /// Return Type: BOOL->int
        ///hPal: HPALETTE->HPALETTE__*
        ///iStartIndex: UINT->unsigned int
        ///cEntries: UINT->unsigned int
        ///ppe: PALETTEENTRY*
        [DllImportAttribute("gdi32.dll", EntryPoint = "AnimatePalette")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool AnimatePalette([InAttribute] IntPtr hPal, uint iStartIndex, uint cEntries, [MarshalAsAttribute(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 2)] tagPALETTEENTRY[] ppe);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///xDest: int
        ///yDest: int
        ///DestWidth: int
        ///DestHeight: int
        ///xSrc: int
        ///ySrc: int
        ///SrcWidth: int
        ///SrcHeight: int
        ///lpBits: void*
        ///lpbmi: BITMAPINFO*
        ///iUsage: UINT->unsigned int
        ///rop: DWORD->unsigned int
        [DllImportAttribute("gdi32.dll", EntryPoint = "StretchDIBits")]
        public static extern int StretchDIBits([InAttribute] IntPtr hdc, int xDest, int yDest, int DestWidth, int DestHeight, int xSrc, int ySrc, int SrcWidth, int SrcHeight, [InAttribute] IntPtr lpBits, [InAttribute] ref tagBITMAPINFO lpbmi, uint iUsage, uint rop);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///limit: FLOAT->float
        ///old: PFLOAT->FLOAT*
        [DllImportAttribute("gdi32.dll", EntryPoint = "SetMiterLimit")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool SetMiterLimit([InAttribute] IntPtr hdc, float limit, IntPtr old);


        /// Return Type: COLORREF->DWORD->unsigned int
        ///hdc: HDC->HDC__*
        ///color: COLORREF->DWORD->unsigned int
        [DllImportAttribute("gdi32.dll", EntryPoint = "SetDCPenColor")]
        public static extern uint SetDCPenColor([InAttribute] IntPtr hdc, uint color);


        /// Return Type: HCOLORSPACE->HCOLORSPACE__*
        ///hdc: HDC->HDC__*
        ///hcs: HCOLORSPACE->HCOLORSPACE__*
        [DllImportAttribute("gdi32.dll", EntryPoint = "SetColorSpace")]
        public static extern IntPtr SetColorSpace([InAttribute] IntPtr hdc, [InAttribute] IntPtr hcs);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///x: int
        ///y: int
        ///lppt: LPPOINT->tagPOINT*
        [DllImportAttribute("gdi32.dll", EntryPoint = "SetBrushOrgEx")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool SetBrushOrgEx([InAttribute] IntPtr hdc, int x, int y, IntPtr lppt);


        /// Return Type: UINT->unsigned int
        ///hdc: HDC->HDC__*
        ///lprect: RECT*
        ///flags: UINT->unsigned int
        [DllImportAttribute("gdi32.dll", EntryPoint = "SetBoundsRect")]
        public static extern uint SetBoundsRect([InAttribute] IntPtr hdc, [InAttribute] IntPtr lprect, uint flags);


        /// Return Type: LONG->int
        ///hbm: HBITMAP->HBITMAP__*
        ///cb: DWORD->unsigned int
        ///pvBits: void*
        [DllImportAttribute("gdi32.dll", EntryPoint = "SetBitmapBits")]
        public static extern int SetBitmapBits([InAttribute] IntPtr hbm, uint cb, [InAttribute] IntPtr pvBits);


        /// Return Type: HPALETTE->HPALETTE__*
        ///hdc: HDC->HDC__*
        ///hPal: HPALETTE->HPALETTE__*
        ///bForceBkgd: BOOL->int
        [DllImportAttribute("gdi32.dll", EntryPoint = "SelectPalette")]
        public static extern IntPtr SelectPalette([InAttribute] IntPtr hdc, [InAttribute] IntPtr hPal, [MarshalAsAttribute(UnmanagedType.Bool)] bool bForceBkgd);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///hrgn: HRGN->HRGN__*
        [DllImportAttribute("gdi32.dll", EntryPoint = "SelectClipRgn")]
        public static extern int SelectClipRgn([InAttribute] IntPtr hdc, [InAttribute] IntPtr hrgn);


        /// Return Type: BOOL->int
        ///hpal: HPALETTE->HPALETTE__*
        ///n: UINT->unsigned int
        [DllImportAttribute("gdi32.dll", EntryPoint = "ResizePalette")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool ResizePalette([InAttribute] IntPtr hpal, uint n);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///x: int
        ///y: int
        [DllImportAttribute("gdi32.dll", EntryPoint = "OffsetClipRgn")]
        public static extern int OffsetClipRgn([InAttribute] IntPtr hdc, int x, int y);


        /// Return Type: DWORD->unsigned int
        ///hrgn: HRGN->HRGN__*
        ///nCount: DWORD->unsigned int
        ///lpRgnData: LPRGNDATA->_RGNDATA*
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetRegionData")]
        public static extern uint GetRegionData([InAttribute] IntPtr hrgn, uint nCount, IntPtr lpRgnData);


        /// Return Type: DWORD->unsigned int
        ///h: HGDIOBJ->void*
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetObjectType")]
        public static extern uint GetObjectType([InAttribute] IntPtr h);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///plimit: PFLOAT->FLOAT*
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetMiterLimit")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool GetMiterLimit([InAttribute] IntPtr hdc, [OutAttribute] out float plimit);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///index: int
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetDeviceCaps")]
        public static extern int GetDeviceCaps([InAttribute] IntPtr hdc, int index);


        /// Return Type: COLORREF->DWORD->unsigned int
        ///hdc: HDC->HDC__*
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetDCPenColor")]
        public static extern uint GetDCPenColor([InAttribute] IntPtr hdc);


        /// Return Type: HCOLORSPACE->HCOLORSPACE__*
        ///hdc: HDC->HDC__*
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetColorSpace")]
        public static extern IntPtr GetColorSpace([InAttribute] IntPtr hdc);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///iFirst: UINT->unsigned int
        ///iLast: UINT->unsigned int
        ///lpBuffer: LPINT->int*
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetCharWidthW")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool GetCharWidthW([InAttribute] IntPtr hdc, uint iFirst, uint iLast, IntPtr lpBuffer);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///giFirst: UINT->unsigned int
        ///cgi: UINT->unsigned int
        ///pgi: LPWORD->WORD*
        ///piWidths: LPINT->int*
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetCharWidthI")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool GetCharWidthI([InAttribute] IntPtr hdc, uint giFirst, uint cgi, [InAttribute] IntPtr pgi, IntPtr piWidths);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///iFirst: UINT->unsigned int
        ///iLast: UINT->unsigned int
        ///lpBuffer: LPINT->int*
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetCharWidthA")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool GetCharWidthA([InAttribute] IntPtr hdc, uint iFirst, uint iLast, IntPtr lpBuffer);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///lppt: LPPOINT->tagPOINT*
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetBrushOrgEx")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool GetBrushOrgEx([InAttribute] IntPtr hdc, [OutAttribute] out Point lppt);


        /// Return Type: UINT->unsigned int
        ///hdc: HDC->HDC__*
        ///lprect: LPRECT->tagRECT*
        ///flags: UINT->unsigned int
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetBoundsRect")]
        public static extern uint GetBoundsRect([InAttribute] IntPtr hdc, [OutAttribute] out tagRECT lprect, uint flags);


        /// Return Type: LONG->int
        ///hbit: HBITMAP->HBITMAP__*
        ///cb: LONG->int
        ///lpvBits: LPVOID->void*
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetBitmapBits")]
        public static extern int GetBitmapBits([InAttribute] IntPtr hbit, int cb, IntPtr lpvBits);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///x: int
        ///y: int
        ///ptl: LPPOINT->tagPOINT*
        [DllImportAttribute("gdi32.dll", EntryPoint = "FixBrushOrgEx")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool FixBrushOrgEx([InAttribute] IntPtr hdc, int x, int y, [InAttribute] IntPtr ptl);


        /// Return Type: HRGN->HRGN__*
        ///x1: int
        ///y1: int
        ///x2: int
        ///y2: int
        [DllImportAttribute("gdi32.dll", EntryPoint = "CreateRectRgn")]
        public static extern IntPtr CreateRectRgn(int x1, int y1, int x2, int y2);


        /// Return Type: HPALETTE->HPALETTE__*
        ///plpal: LOGPALETTE*
        [DllImportAttribute("gdi32.dll", EntryPoint = "CreatePalette")]
        public static extern IntPtr CreatePalette([InAttribute] ref tagLOGPALETTE plpal);


        /// Return Type: HMETAFILE->HMETAFILE__*
        ///param0: HMETAFILE->HMETAFILE__*
        ///param1: LPCWSTR->WCHAR*
        [DllImportAttribute("gdi32.dll", EntryPoint = "CopyMetaFileW")]
        public static extern IntPtr CopyMetaFileW([InAttribute] IntPtr param0, [InAttribute] [MarshalAsAttribute(UnmanagedType.LPWStr)] string param1);


        /// Return Type: HMETAFILE->HMETAFILE__*
        ///param0: HMETAFILE->HMETAFILE__*
        ///param1: LPCSTR->CHAR*
        [DllImportAttribute("gdi32.dll", EntryPoint = "CopyMetaFileA")]
        public static extern IntPtr CopyMetaFileA([InAttribute] IntPtr param0, [InAttribute] [MarshalAsAttribute(UnmanagedType.LPStr)] string param1);


        /// Return Type: HMETAFILE->HMETAFILE__*
        ///hdc: HDC->HDC__*
        [DllImportAttribute("gdi32.dll", EntryPoint = "CloseMetaFile")]
        public static extern IntPtr CloseMetaFile([InAttribute] IntPtr hdc);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        [DllImportAttribute("gdi32.dll", EntryPoint = "UpdateColors")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool UpdateColors([InAttribute] IntPtr hdc);


        /// Return Type: COLORREF->DWORD->unsigned int
        ///hdc: HDC->HDC__*
        ///color: COLORREF->DWORD->unsigned int
        [DllImportAttribute("gdi32.dll", EntryPoint = "SetTextColor")]
        public static extern uint SetTextColor([InAttribute] IntPtr hdc, uint color);


        /// Return Type: UINT->unsigned int
        ///hdc: HDC->HDC__*
        ///align: UINT->unsigned int
        [DllImportAttribute("gdi32.dll", EntryPoint = "SetTextAlign")]
        public static extern uint SetTextAlign([InAttribute] IntPtr hdc, uint align);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///proc: ABORTPROC
        [DllImportAttribute("gdi32.dll", EntryPoint = "SetAbortProc")]
        public static extern int SetAbortProc([InAttribute] IntPtr hdc, ABORTPROC proc);


        /// Return Type: HGDIOBJ->void*
        ///hdc: HDC->HDC__*
        ///h: HGDIOBJ->void*
        [DllImportAttribute("gdi32.dll", EntryPoint = "SelectObject")]
        public static extern IntPtr SelectObject([InAttribute] IntPtr hdc, [InAttribute] IntPtr h);


        /// Return Type: BOOL->int
        ///hrgn: HRGN->HRGN__*
        ///lprect: RECT*
        [DllImportAttribute("gdi32.dll", EntryPoint = "RectInRegion")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool RectInRegion([InAttribute] IntPtr hrgn, [InAttribute] ref tagRECT lprect);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///ppt: POLYTEXTW*
        ///nstrings: int
        [DllImportAttribute("gdi32.dll", EntryPoint = "PolyTextOutW")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool PolyTextOutW([InAttribute] IntPtr hdc, [MarshalAsAttribute(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 2)] tagPOLYTEXTW[] ppt, int nstrings);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///ppt: POLYTEXTA*
        ///nstrings: int
        [DllImportAttribute("gdi32.dll", EntryPoint = "PolyTextOutA")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool PolyTextOutA([InAttribute] IntPtr hdc, [MarshalAsAttribute(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 2)] tagPOLYTEXTA[] ppt, int nstrings);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///apt: POINT*
        ///asz: DWORD*
        ///csz: DWORD->unsigned int
        [DllImportAttribute("gdi32.dll", EntryPoint = "PolyPolyline")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool PolyPolyline([InAttribute] IntPtr hdc, [InAttribute] ref Point apt, [MarshalAsAttribute(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U4, SizeParamIndex = 3)] uint[] asz, uint csz);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///apt: POINT*
        ///cpt: DWORD->unsigned int
        [DllImportAttribute("gdi32.dll", EntryPoint = "PolyBezierTo")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool PolyBezierTo([InAttribute] IntPtr hdc, [MarshalAsAttribute(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 2)] Point[] apt, uint cpt);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///hmf: HMETAFILE->HMETAFILE__*
        [DllImportAttribute("gdi32.dll", EntryPoint = "PlayMetaFile")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool PlayMetaFile([InAttribute] IntPtr hdc, [InAttribute] IntPtr hmf);


        /// Return Type: HRGN->HRGN__*
        ///hdc: HDC->HDC__*
        [DllImportAttribute("gdi32.dll", EntryPoint = "PathToRegion")]
        public static extern IntPtr PathToRegion([InAttribute] IntPtr hdc);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///c: int
        ///lpName: LPWSTR->WCHAR*
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetTextFaceW")]
        public static extern int GetTextFaceW([InAttribute] IntPtr hdc, int c, [OutAttribute] [MarshalAsAttribute(UnmanagedType.LPWStr)] StringBuilder lpName);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///c: int
        ///lpName: LPSTR->CHAR*
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetTextFaceA")]
        public static extern int GetTextFaceA([InAttribute] IntPtr hdc, int c, [OutAttribute] [MarshalAsAttribute(UnmanagedType.LPStr)] StringBuilder lpName);


        /// Return Type: COLORREF->DWORD->unsigned int
        ///hdc: HDC->HDC__*
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetTextColor")]
        public static extern uint GetTextColor([InAttribute] IntPtr hdc);


        /// Return Type: UINT->unsigned int
        ///hdc: HDC->HDC__*
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetTextAlign")]
        public static extern uint GetTextAlign([InAttribute] IntPtr hdc);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///hrgn: HRGN->HRGN__*
        ///i: INT->int
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetRandomRgn")]
        public static extern int GetRandomRgn([InAttribute] IntPtr hdc, [InAttribute] IntPtr hrgn, int i);


        /// Return Type: HMETAFILE->HMETAFILE__*
        ///lpName: LPCWSTR->WCHAR*
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetMetaFileW")]
        public static extern IntPtr GetMetaFileW([InAttribute] [MarshalAsAttribute(UnmanagedType.LPWStr)] string lpName);


        /// Return Type: HMETAFILE->HMETAFILE__*
        ///lpName: LPCSTR->CHAR*
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetMetaFileA")]
        public static extern IntPtr GetMetaFileA([InAttribute] [MarshalAsAttribute(UnmanagedType.LPStr)] string lpName);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///x: int
        ///y: int
        ///color: COLORREF->DWORD->unsigned int
        ///type: UINT->unsigned int
        [DllImportAttribute("gdi32.dll", EntryPoint = "ExtFloodFill")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool ExtFloodFill([InAttribute] IntPtr hdc, int x, int y, uint color, uint type);


        /// Return Type: HPEN->HPEN__*
        ///iPenStyle: DWORD->unsigned int
        ///cWidth: DWORD->unsigned int
        ///plbrush: LOGBRUSH*
        ///cStyle: DWORD->unsigned int
        ///pstyle: DWORD*
        [DllImportAttribute("gdi32.dll", EntryPoint = "ExtCreatePen")]
        public static extern IntPtr ExtCreatePen(uint iPenStyle, uint cWidth, [InAttribute] ref tagLOGBRUSH plbrush, uint cStyle, [InAttribute] IntPtr pstyle);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///hmf: HMETAFILE->HMETAFILE__*
        ///proc: MFENUMPROC
        ///param: LPARAM->LONG_PTR->int
        [DllImportAttribute("gdi32.dll", EntryPoint = "EnumMetaFile")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool EnumMetaFile([InAttribute] IntPtr hdc, [InAttribute] IntPtr hmf, MFENUMPROC proc, [MarshalAsAttribute(UnmanagedType.SysInt)] int param);


        /// Return Type: BOOL->int
        ///ho: HGDIOBJ->void*
        [DllImportAttribute("gdi32.dll", EntryPoint = "DeleteObject")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool DeleteObject([InAttribute] IntPtr ho);


        /// Return Type: HBITMAP->HBITMAP__*
        ///nWidth: int
        ///nHeight: int
        ///nPlanes: UINT->unsigned int
        ///nBitCount: UINT->unsigned int
        ///lpBits: void*
        [DllImportAttribute("gdi32.dll", EntryPoint = "CreateBitmap")]
        public static extern IntPtr CreateBitmap(int nWidth, int nHeight, uint nPlanes, uint nBitCount, [InAttribute] IntPtr lpBits);


        /// Return Type: BOOL->int
        ///param0: HDC->HDC__*
        [DllImportAttribute("gdi32.dll", EntryPoint = "SwapBuffers")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool SwapBuffers(IntPtr param0);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///lprect: RECT*
        [DllImportAttribute("gdi32.dll", EntryPoint = "RectVisible")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool RectVisible([InAttribute] IntPtr hdc, [InAttribute] ref tagRECT lprect);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///apt: POINT*
        ///asz: INT*
        ///csz: int
        [DllImportAttribute("gdi32.dll", EntryPoint = "PolyPolygon")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool PolyPolygon([InAttribute] IntPtr hdc, [InAttribute] ref Point apt, [MarshalAsAttribute(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I4, SizeParamIndex = 3)] int[] asz, int csz);


        /// Return Type: DWORD->unsigned int
        ///hdc: HDC->HDC__*
        ///dwTable: DWORD->unsigned int
        ///dwOffset: DWORD->unsigned int
        ///pvBuffer: PVOID->void*
        ///cjBuffer: DWORD->unsigned int
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetFontData")]
        public static extern uint GetFontData([InAttribute] IntPtr hdc, uint dwTable, uint dwOffset, IntPtr pvBuffer, uint cjBuffer);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        [DllImportAttribute("gdi32.dll", EntryPoint = "FlattenPath")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool FlattenPath([InAttribute] IntPtr hdc);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///x: int
        ///y: int
        ///options: UINT->unsigned int
        ///lprect: RECT*
        ///lpString: LPCWSTR->WCHAR*
        ///c: UINT->unsigned int
        ///lpDx: INT*
        [DllImportAttribute("gdi32.dll", EntryPoint = "ExtTextOutW")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool ExtTextOutW([InAttribute] IntPtr hdc, int x, int y, uint options, [InAttribute] IntPtr lprect, [InAttribute] [MarshalAsAttribute(UnmanagedType.LPWStr)] string lpString, uint c, [InAttribute] IntPtr lpDx);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///x: int
        ///y: int
        ///options: UINT->unsigned int
        ///lprect: RECT*
        ///lpString: LPCSTR->CHAR*
        ///c: UINT->unsigned int
        ///lpDx: INT*
        [DllImportAttribute("gdi32.dll", EntryPoint = "ExtTextOutA")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool ExtTextOutA([InAttribute] IntPtr hdc, int x, int y, uint options, [InAttribute] IntPtr lprect, [InAttribute] [MarshalAsAttribute(UnmanagedType.LPStr)] string lpString, uint c, [InAttribute] IntPtr lpDx);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///nType: int
        ///lpFunc: GOBJENUMPROC
        ///lParam: LPARAM->LONG_PTR->int
        [DllImportAttribute("gdi32.dll", EntryPoint = "EnumObjects")]
        public static extern int EnumObjects([InAttribute] IntPtr hdc, int nType, GOBJENUMPROC lpFunc, [MarshalAsAttribute(UnmanagedType.SysInt)] int lParam);


        /// Return Type: HFONT->HFONT__*
        ///cHeight: int
        ///cWidth: int
        ///cEscapement: int
        ///cOrientation: int
        ///cWeight: int
        ///bItalic: DWORD->unsigned int
        ///bUnderline: DWORD->unsigned int
        ///bStrikeOut: DWORD->unsigned int
        ///iCharSet: DWORD->unsigned int
        ///iOutPrecision: DWORD->unsigned int
        ///iClipPrecision: DWORD->unsigned int
        ///iQuality: DWORD->unsigned int
        ///iPitchAndFamily: DWORD->unsigned int
        ///pszFaceName: LPCWSTR->WCHAR*
        [DllImportAttribute("gdi32.dll", EntryPoint = "CreateFontW")]
        public static extern IntPtr CreateFontW(int cHeight, int cWidth, int cEscapement, int cOrientation, int cWeight, uint bItalic, uint bUnderline, uint bStrikeOut, uint iCharSet, uint iOutPrecision, uint iClipPrecision, uint iQuality, uint iPitchAndFamily, [InAttribute] [MarshalAsAttribute(UnmanagedType.LPWStr)] string pszFaceName);


        /// Return Type: HFONT->HFONT__*
        ///cHeight: int
        ///cWidth: int
        ///cEscapement: int
        ///cOrientation: int
        ///cWeight: int
        ///bItalic: DWORD->unsigned int
        ///bUnderline: DWORD->unsigned int
        ///bStrikeOut: DWORD->unsigned int
        ///iCharSet: DWORD->unsigned int
        ///iOutPrecision: DWORD->unsigned int
        ///iClipPrecision: DWORD->unsigned int
        ///iQuality: DWORD->unsigned int
        ///iPitchAndFamily: DWORD->unsigned int
        ///pszFaceName: LPCSTR->CHAR*
        [DllImportAttribute("gdi32.dll", EntryPoint = "CreateFontA")]
        public static extern IntPtr CreateFontA(int cHeight, int cWidth, int cEscapement, int cOrientation, int cWeight, uint bItalic, uint bUnderline, uint bStrikeOut, uint iCharSet, uint iOutPrecision, uint iClipPrecision, uint iQuality, uint iPitchAndFamily, [InAttribute] [MarshalAsAttribute(UnmanagedType.LPStr)] string pszFaceName);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        [DllImportAttribute("gdi32.dll", EntryPoint = "CloseFigure")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool CloseFigure([InAttribute] IntPtr hdc);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        [DllImportAttribute("gdi32.dll", EntryPoint = "StrokePath")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool StrokePath([InAttribute] IntPtr hdc);


        /// Return Type: BOOL->int
        ///hdcDest: HDC->HDC__*
        ///xDest: int
        ///yDest: int
        ///wDest: int
        ///hDest: int
        ///hdcSrc: HDC->HDC__*
        ///xSrc: int
        ///ySrc: int
        ///wSrc: int
        ///hSrc: int
        ///rop: DWORD->unsigned int
        [DllImportAttribute("gdi32.dll", EntryPoint = "StretchBlt")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool StretchBlt([InAttribute] IntPtr hdcDest, int xDest, int yDest, int wDest, int hDest, [InAttribute] IntPtr hdcSrc, int xSrc, int ySrc, int wSrc, int hSrc, uint rop);


        /// Return Type: BOOL->int
        ///hrgn: HRGN->HRGN__*
        ///left: int
        ///top: int
        ///right: int
        ///bottom: int
        [DllImportAttribute("gdi32.dll", EntryPoint = "SetRectRgn")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool SetRectRgn([InAttribute] IntPtr hrgn, int left, int top, int right, int bottom);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        [DllImportAttribute("gdi32.dll", EntryPoint = "SetMetaRgn")]
        public static extern int SetMetaRgn([InAttribute] IntPtr hdc);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///iMode: int
        [DllImportAttribute("gdi32.dll", EntryPoint = "SetMapMode")]
        public static extern int SetMapMode([InAttribute] IntPtr hdc, int iMode);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///mode: int
        [DllImportAttribute("gdi32.dll", EntryPoint = "SetICMMode")]
        public static extern int SetICMMode([InAttribute] IntPtr hdc, int mode);


        /// Return Type: COLORREF->DWORD->unsigned int
        ///hdc: HDC->HDC__*
        ///color: COLORREF->DWORD->unsigned int
        [DllImportAttribute("gdi32.dll", EntryPoint = "SetBkColor")]
        public static extern uint SetBkColor([InAttribute] IntPtr hdc, uint color);


        /// Return Type: BOOL->int
        ///hrgn: HRGN->HRGN__*
        ///x: int
        ///y: int
        [DllImportAttribute("gdi32.dll", EntryPoint = "PtInRegion")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool PtInRegion([InAttribute] IntPtr hrgn, int x, int y);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///apt: POINT*
        ///cpt: DWORD->unsigned int
        [DllImportAttribute("gdi32.dll", EntryPoint = "PolylineTo")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool PolylineTo([InAttribute] IntPtr hdc, [MarshalAsAttribute(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 2)] Point[] apt, uint cpt);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///apt: POINT*
        ///cpt: DWORD->unsigned int
        [DllImportAttribute("gdi32.dll", EntryPoint = "PolyBezier")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool PolyBezier([InAttribute] IntPtr hdc, [MarshalAsAttribute(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 2)] Point[] apt, uint cpt);


        /// Return Type: int
        ///h: HANDLE->void*
        ///c: int
        ///pv: LPVOID->void*
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetObjectW")]
        public static extern int GetObjectW([InAttribute] IntPtr h, int c, IntPtr pv);


        /// Return Type: int
        ///h: HANDLE->void*
        ///c: int
        ///pv: LPVOID->void*
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetObjectA")]
        public static extern int GetObjectA([InAttribute] IntPtr h, int c, IntPtr pv);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///hrgn: HRGN->HRGN__*
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetMetaRgn")]
        public static extern int GetMetaRgn([InAttribute] IntPtr hdc, [InAttribute] IntPtr hrgn);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetMapMode")]
        public static extern int GetMapMode([InAttribute] IntPtr hdc);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///lppt: LPPOINT->tagPOINT*
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetDCOrgEx")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool GetDCOrgEx([InAttribute] IntPtr hdc, [OutAttribute] out Point lppt);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///hrgn: HRGN->HRGN__*
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetClipRgn")]
        public static extern int GetClipRgn([InAttribute] IntPtr hdc, [InAttribute] IntPtr hrgn);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///lprect: LPRECT->tagRECT*
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetClipBox")]
        public static extern int GetClipBox([InAttribute] IntPtr hdc, [OutAttribute] out tagRECT lprect);


        /// Return Type: COLORREF->DWORD->unsigned int
        ///hdc: HDC->HDC__*
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetBkColor")]
        public static extern uint GetBkColor([InAttribute] IntPtr hdc);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///nSize: UINT->unsigned int
        ///lpData: BYTE*
        [DllImportAttribute("gdi32.dll", EntryPoint = "GdiComment")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool GdiComment([InAttribute] IntPtr hdc, uint nSize, [InAttribute] IntPtr lpData);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///lpLogfont: LPCWSTR->WCHAR*
        ///lpProc: FONTENUMPROCW->OLDFONTENUMPROCW
        ///lParam: LPARAM->LONG_PTR->int
        [DllImportAttribute("gdi32.dll", EntryPoint = "EnumFontsW")]
        public static extern int EnumFontsW([InAttribute] IntPtr hdc, [InAttribute] [MarshalAsAttribute(UnmanagedType.LPWStr)] string lpLogfont, OLDFONTENUMPROCW lpProc, [MarshalAsAttribute(UnmanagedType.SysInt)] int lParam);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///lpLogfont: LPCSTR->CHAR*
        ///lpProc: FONTENUMPROCA->OLDFONTENUMPROCA
        ///lParam: LPARAM->LONG_PTR->int
        [DllImportAttribute("gdi32.dll", EntryPoint = "EnumFontsA")]
        public static extern int EnumFontsA([InAttribute] IntPtr hdc, [InAttribute] [MarshalAsAttribute(UnmanagedType.LPStr)] string lpLogfont, OLDFONTENUMPROCA lpProc, [MarshalAsAttribute(UnmanagedType.SysInt)] int lParam);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///iEscape: int
        ///cjIn: int
        ///lpIn: LPCSTR->CHAR*
        [DllImportAttribute("gdi32.dll", EntryPoint = "DrawEscape")]
        public static extern int DrawEscape([InAttribute] IntPtr hdc, int iEscape, int cjIn, [InAttribute] [MarshalAsAttribute(UnmanagedType.LPStr)] string lpIn);


        /// Return Type: int
        ///hrgnDst: HRGN->HRGN__*
        ///hrgnSrc1: HRGN->HRGN__*
        ///hrgnSrc2: HRGN->HRGN__*
        ///iMode: int
        [DllImportAttribute("gdi32.dll", EntryPoint = "CombineRgn")]
        public static extern int CombineRgn([InAttribute] IntPtr hrgnDst, [InAttribute] IntPtr hrgnSrc1, [InAttribute] IntPtr hrgnSrc2, int iMode);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        [DllImportAttribute("gdi32.dll", EntryPoint = "WidenPath")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool WidenPath([InAttribute] IntPtr hdc);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        [DllImportAttribute("gdi32.dll", EntryPoint = "StartPage")]
        public static extern int StartPage([InAttribute] IntPtr hdc);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///lpdi: DOCINFOW*
        [DllImportAttribute("gdi32.dll", EntryPoint = "StartDocW")]
        public static extern int StartDocW([InAttribute] IntPtr hdc, [InAttribute] ref DOCINFOW lpdi);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///lpdi: DOCINFOA*
        [DllImportAttribute("gdi32.dll", EntryPoint = "StartDocA")]
        public static extern int StartDocA([InAttribute] IntPtr hdc, [InAttribute] ref DOCINFOA lpdi);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///x: int
        ///y: int
        ///color: COLORREF->DWORD->unsigned int
        [DllImportAttribute("gdi32.dll", EntryPoint = "SetPixelV")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool SetPixelV([InAttribute] IntPtr hdc, int x, int y, uint color);


        /// Return Type: DWORD->unsigned int
        ///hdc: HDC->HDC__*
        ///l: DWORD->unsigned int
        [DllImportAttribute("gdi32.dll", EntryPoint = "SetLayout")]
        public static extern uint SetLayout([InAttribute] IntPtr hdc, uint l);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///hbm: HBITMAP->HBITMAP__*
        ///start: UINT->unsigned int
        ///cLines: UINT->unsigned int
        ///lpBits: void*
        ///lpbmi: BITMAPINFO*
        ///ColorUse: UINT->unsigned int
        [DllImportAttribute("gdi32.dll", EntryPoint = "SetDIBits")]
        public static extern int SetDIBits([InAttribute] IntPtr hdc, [InAttribute] IntPtr hbm, uint start, uint cLines, [InAttribute] IntPtr lpBits, [InAttribute] ref tagBITMAPINFO lpbmi, uint ColorUse);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///mode: int
        [DllImportAttribute("gdi32.dll", EntryPoint = "SetBkMode")]
        public static extern int SetBkMode([InAttribute] IntPtr hdc, int mode);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///left: int
        ///top: int
        ///right: int
        ///bottom: int
        ///width: int
        ///height: int
        [DllImportAttribute("gdi32.dll", EntryPoint = "RoundRect")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool RoundRect([InAttribute] IntPtr hdc, int left, int top, int right, int bottom, int width, int height);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///nSavedDC: int
        [DllImportAttribute("gdi32.dll", EntryPoint = "RestoreDC")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool RestoreDC([InAttribute] IntPtr hdc, int nSavedDC);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///left: int
        ///top: int
        ///right: int
        ///bottom: int
        [DllImportAttribute("gdi32.dll", EntryPoint = "Rectangle")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool Rectangle([InAttribute] IntPtr hdc, int left, int top, int right, int bottom);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///x: int
        ///y: int
        [DllImportAttribute("gdi32.dll", EntryPoint = "PtVisible")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool PtVisible([InAttribute] IntPtr hdc, int x, int y);


        /// Return Type: int
        ///hrgn: HRGN->HRGN__*
        ///x: int
        ///y: int
        [DllImportAttribute("gdi32.dll", EntryPoint = "OffsetRgn")]
        public static extern int OffsetRgn([InAttribute] IntPtr hrgn, int x, int y);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///hrgn: HRGN->HRGN__*
        [DllImportAttribute("gdi32.dll", EntryPoint = "InvertRgn")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool InvertRgn([InAttribute] IntPtr hdc, [InAttribute] IntPtr hrgn);


        /// Return Type: int
        ///hrgn: HRGN->HRGN__*
        ///lprc: LPRECT->tagRECT*
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetRgnBox")]
        public static extern int GetRgnBox([InAttribute] IntPtr hrgn, [OutAttribute] out tagRECT lprc);


        /// Return Type: DWORD->unsigned int
        ///hdc: HDC->HDC__*
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetLayout")]
        public static extern uint GetLayout([InAttribute] IntPtr hdc);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///hbm: HBITMAP->HBITMAP__*
        ///start: UINT->unsigned int
        ///cLines: UINT->unsigned int
        ///lpvBits: LPVOID->void*
        ///lpbmi: LPBITMAPINFO->tagBITMAPINFO*
        ///usage: UINT->unsigned int
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetDIBits")]
        public static extern int GetDIBits([InAttribute] IntPtr hdc, [InAttribute] IntPtr hbm, uint start, uint cLines, IntPtr lpvBits, ref tagBITMAPINFO lpbmi, uint usage);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetBkMode")]
        public static extern int GetBkMode([InAttribute] IntPtr hdc);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///x: int
        ///y: int
        ///color: COLORREF->DWORD->unsigned int
        [DllImportAttribute("gdi32.dll", EntryPoint = "FloodFill")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool FloodFill([InAttribute] IntPtr hdc, int x, int y, uint color);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///iEscape: int
        ///cjInput: int
        ///lpInData: LPCSTR->CHAR*
        ///cjOutput: int
        ///lpOutData: LPSTR->CHAR*
        [DllImportAttribute("gdi32.dll", EntryPoint = "ExtEscape")]
        public static extern int ExtEscape([InAttribute] IntPtr hdc, int iEscape, int cjInput, [InAttribute] [MarshalAsAttribute(UnmanagedType.LPStr)] string lpInData, int cjOutput, IntPtr lpOutData);


        /// Return Type: HPEN->HPEN__*
        ///iStyle: int
        ///cWidth: int
        ///color: COLORREF->DWORD->unsigned int
        [DllImportAttribute("gdi32.dll", EntryPoint = "CreatePen")]
        public static extern IntPtr CreatePen(int iStyle, int cWidth, uint color);


        /// Return Type: HDC->HDC__*
        ///pszDriver: LPCWSTR->WCHAR*
        ///pszDevice: LPCWSTR->WCHAR*
        ///pszPort: LPCWSTR->WCHAR*
        ///pdm: DEVMODEW*
        [DllImportAttribute("gdi32.dll", EntryPoint = "CreateICW")]
        public static extern IntPtr CreateICW([InAttribute] [MarshalAsAttribute(UnmanagedType.LPWStr)] string pszDriver, [InAttribute] [MarshalAsAttribute(UnmanagedType.LPWStr)] string pszDevice, [InAttribute] [MarshalAsAttribute(UnmanagedType.LPWStr)] string pszPort, [InAttribute] IntPtr pdm);


        /// Return Type: HDC->HDC__*
        ///pszDriver: LPCSTR->CHAR*
        ///pszDevice: LPCSTR->CHAR*
        ///pszPort: LPCSTR->CHAR*
        ///pdm: DEVMODEA*
        [DllImportAttribute("gdi32.dll", EntryPoint = "CreateICA")]
        public static extern IntPtr CreateICA([InAttribute] [MarshalAsAttribute(UnmanagedType.LPStr)] string pszDriver, [InAttribute] [MarshalAsAttribute(UnmanagedType.LPStr)] string pszDevice, [InAttribute] [MarshalAsAttribute(UnmanagedType.LPStr)] string pszPort, [InAttribute] IntPtr pdm);


        /// Return Type: HDC->HDC__*
        ///pwszDriver: LPCWSTR->WCHAR*
        ///pwszDevice: LPCWSTR->WCHAR*
        ///pszPort: LPCWSTR->WCHAR*
        ///pdm: DEVMODEW*
        [DllImportAttribute("gdi32.dll", EntryPoint = "CreateDCW")]
        public static extern IntPtr CreateDCW([InAttribute] [MarshalAsAttribute(UnmanagedType.LPWStr)] string pwszDriver, [InAttribute] [MarshalAsAttribute(UnmanagedType.LPWStr)] string pwszDevice, [InAttribute] [MarshalAsAttribute(UnmanagedType.LPWStr)] string pszPort, [InAttribute] IntPtr pdm);


        /// Return Type: HDC->HDC__*
        ///pwszDriver: LPCSTR->CHAR*
        ///pwszDevice: LPCSTR->CHAR*
        ///pszPort: LPCSTR->CHAR*
        ///pdm: DEVMODEA*
        [DllImportAttribute("gdi32.dll", EntryPoint = "CreateDCA")]
        public static extern IntPtr CreateDCA([InAttribute] [MarshalAsAttribute(UnmanagedType.LPStr)] string pwszDriver, [InAttribute] [MarshalAsAttribute(UnmanagedType.LPStr)] string pwszDevice, [InAttribute] [MarshalAsAttribute(UnmanagedType.LPStr)] string pszPort, [InAttribute] IntPtr pdm);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        [DllImportAttribute("gdi32.dll", EntryPoint = "BeginPath")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool BeginPath([InAttribute] IntPtr hdc);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        [DllImportAttribute("gdi32.dll", EntryPoint = "AbortPath")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool AbortPath([InAttribute] IntPtr hdc);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///x: int
        ///y: int
        ///lpString: LPCWSTR->WCHAR*
        ///c: int
        [DllImportAttribute("gdi32.dll", EntryPoint = "TextOutW")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool TextOutW([InAttribute] IntPtr hdc, int x, int y, [InAttribute] [MarshalAsAttribute(UnmanagedType.LPWStr)] string lpString, int c);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///x: int
        ///y: int
        ///lpString: LPCSTR->CHAR*
        ///c: int
        [DllImportAttribute("gdi32.dll", EntryPoint = "TextOutA")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool TextOutA([InAttribute] IntPtr hdc, int x, int y, [InAttribute] [MarshalAsAttribute(UnmanagedType.LPStr)] string lpString, int c);


        /// Return Type: COLORREF->DWORD->unsigned int
        ///hdc: HDC->HDC__*
        ///x: int
        ///y: int
        ///color: COLORREF->DWORD->unsigned int
        [DllImportAttribute("gdi32.dll", EntryPoint = "SetPixel")]
        public static extern uint SetPixel([InAttribute] IntPtr hdc, int x, int y, uint color);


        /// Return Type: HDC->HDC__*
        ///hdc: HDC->HDC__*
        ///lpdm: DEVMODEW*
        [DllImportAttribute("gdi32.dll", EntryPoint = "ResetDCW")]
        public static extern IntPtr ResetDCW([InAttribute] IntPtr hdc, [InAttribute] ref DEVMODEW lpdm);


        /// Return Type: HDC->HDC__*
        ///hdc: HDC->HDC__*
        ///lpdm: DEVMODEA*
        [DllImportAttribute("gdi32.dll", EntryPoint = "ResetDCA")]
        public static extern IntPtr ResetDCA([InAttribute] IntPtr hdc, [InAttribute] ref DEVMODEA lpdm);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///apt: POINT*
        ///cpt: int
        [DllImportAttribute("gdi32.dll", EntryPoint = "Polyline")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool Polyline([InAttribute] IntPtr hdc, [MarshalAsAttribute(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 2)] Point[] apt, int cpt);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///apt: POINT*
        ///aj: BYTE*
        ///cpt: int
        [DllImportAttribute("gdi32.dll", EntryPoint = "PolyDraw")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool PolyDraw([InAttribute] IntPtr hdc, [MarshalAsAttribute(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 3)] Point[] apt, [MarshalAsAttribute(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I1, SizeParamIndex = 3)] byte[] aj, int cpt);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///hrgn: HRGN->HRGN__*
        [DllImportAttribute("gdi32.dll", EntryPoint = "PaintRgn")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool PaintRgn([InAttribute] IntPtr hdc, [InAttribute] IntPtr hrgn);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///x: int
        ///y: int
        ///lppt: LPPOINT->tagPOINT*
        [DllImportAttribute("gdi32.dll", EntryPoint = "MoveToEx")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool MoveToEx([InAttribute] IntPtr hdc, int x, int y, IntPtr lppt);


        /// Return Type: COLORREF->DWORD->unsigned int
        ///hdc: HDC->HDC__*
        ///x: int
        ///y: int
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetPixel")]
        public static extern uint GetPixel([InAttribute] IntPtr hdc, int x, int y);


        /// Return Type: BOOL->int
        [DllImportAttribute("gdi32.dll", EntryPoint = "GdiFlush")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool GdiFlush();


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///hrgn: HRGN->HRGN__*
        ///hbr: HBRUSH->HBRUSH__*
        ///w: int
        ///h: int
        [DllImportAttribute("gdi32.dll", EntryPoint = "FrameRgn")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool FrameRgn([InAttribute] IntPtr hdc, [InAttribute] IntPtr hrgn, [InAttribute] IntPtr hbr, int w, int h);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        [DllImportAttribute("gdi32.dll", EntryPoint = "FillPath")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool FillPath([InAttribute] IntPtr hdc);


        /// Return Type: BOOL->int
        ///hrgn1: HRGN->HRGN__*
        ///hrgn2: HRGN->HRGN__*
        [DllImportAttribute("gdi32.dll", EntryPoint = "EqualRgn")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool EqualRgn([InAttribute] IntPtr hrgn1, [InAttribute] IntPtr hrgn2);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        [DllImportAttribute("gdi32.dll", EntryPoint = "DeleteDC")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool DeleteDC([InAttribute] IntPtr hdc);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        [DllImportAttribute("gdi32.dll", EntryPoint = "CancelDC")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool CancelDC([InAttribute] IntPtr hdc);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///x: int
        ///y: int
        ///r: DWORD->unsigned int
        ///StartAngle: FLOAT->float
        ///SweepAngle: FLOAT->float
        [DllImportAttribute("gdi32.dll", EntryPoint = "AngleArc")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool AngleArc([InAttribute] IntPtr hdc, int x, int y, uint r, float StartAngle, float SweepAngle);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        [DllImportAttribute("gdi32.dll", EntryPoint = "AbortDoc")]
        public static extern int AbortDoc([InAttribute] IntPtr hdc);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///rop2: int
        [DllImportAttribute("gdi32.dll", EntryPoint = "SetROP2")]
        public static extern int SetROP2([InAttribute] IntPtr hdc, int rop2);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///apt: POINT*
        ///cpt: int
        [DllImportAttribute("gdi32.dll", EntryPoint = "Polygon")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool Polygon([InAttribute] IntPtr hdc, [MarshalAsAttribute(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 2)] Point[] apt, int cpt);


        /// Return Type: BOOL->int
        ///hdcDest: HDC->HDC__*
        ///xDest: int
        ///yDest: int
        ///width: int
        ///height: int
        ///hdcSrc: HDC->HDC__*
        ///xSrc: int
        ///ySrc: int
        ///hbmMask: HBITMAP->HBITMAP__*
        ///xMask: int
        ///yMask: int
        ///rop: DWORD->unsigned int
        [DllImportAttribute("gdi32.dll", EntryPoint = "MaskBlt")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool MaskBlt([InAttribute] IntPtr hdcDest, int xDest, int yDest, int width, int height, [InAttribute] IntPtr hdcSrc, int xSrc, int ySrc, [InAttribute] IntPtr hbmMask, int xMask, int yMask, uint rop);


        /// Return Type: BOOL->int
        ///xStart: int
        ///yStart: int
        ///xEnd: int
        ///yEnd: int
        ///lpProc: LINEDDAPROC
        ///data: LPARAM->LONG_PTR->int
        [DllImportAttribute("gdi32.dll", EntryPoint = "LineDDA")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool LineDDA(int xStart, int yStart, int xEnd, int yEnd, LINEDDAPROC lpProc, [MarshalAsAttribute(UnmanagedType.SysInt)] int data);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetROP2")]
        public static extern int GetROP2([InAttribute] IntPtr hdc);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///apt: LPPOINT->tagPOINT*
        ///aj: LPBYTE->BYTE*
        ///cpt: int
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetPath")]
        public static extern int GetPath([InAttribute] IntPtr hdc, IntPtr apt, IntPtr aj, int cpt);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///hrgn: HRGN->HRGN__*
        ///hbr: HBRUSH->HBRUSH__*
        [DllImportAttribute("gdi32.dll", EntryPoint = "FillRgn")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool FillRgn([InAttribute] IntPtr hdc, [InAttribute] IntPtr hrgn, [InAttribute] IntPtr hbr);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        [DllImportAttribute("gdi32.dll", EntryPoint = "EndPath")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool EndPath([InAttribute] IntPtr hdc);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        [DllImportAttribute("gdi32.dll", EntryPoint = "EndPage")]
        public static extern int EndPage([InAttribute] IntPtr hdc);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///left: int
        ///top: int
        ///right: int
        ///bottom: int
        [DllImportAttribute("gdi32.dll", EntryPoint = "Ellipse")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool Ellipse([InAttribute] IntPtr hdc, int left, int top, int right, int bottom);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        [DllImportAttribute("gdi32.dll", EntryPoint = "SaveDC")]
        public static extern int SaveDC([InAttribute] IntPtr hdc);


        /// Return Type: BOOL->int
        ///hdcDest: HDC->HDC__*
        ///lpPoint: POINT*
        ///hdcSrc: HDC->HDC__*
        ///xSrc: int
        ///ySrc: int
        ///width: int
        ///height: int
        ///hbmMask: HBITMAP->HBITMAP__*
        ///xMask: int
        ///yMask: int
        [DllImportAttribute("gdi32.dll", EntryPoint = "PlgBlt")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool PlgBlt([InAttribute] IntPtr hdcDest, [MarshalAsAttribute(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeConst = 3)] Point[] lpPoint, [InAttribute] IntPtr hdcSrc, int xSrc, int ySrc, int width, int height, [InAttribute] IntPtr hbmMask, int xMask, int yMask);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///x: int
        ///y: int
        ///w: int
        ///h: int
        ///rop: DWORD->unsigned int
        [DllImportAttribute("gdi32.dll", EntryPoint = "PatBlt")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool PatBlt([InAttribute] IntPtr hdc, int x, int y, int w, int h, uint rop);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///lppt: LPPOINT->tagPOINT*
        ///c: int
        [DllImportAttribute("gdi32.dll", EntryPoint = "LPtoDP")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool LPtoDP([InAttribute] IntPtr hdc, IntPtr lppt, int c);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///x: int
        ///y: int
        [DllImportAttribute("gdi32.dll", EntryPoint = "LineTo")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool LineTo([InAttribute] IntPtr hdc, int x, int y);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///iEscape: int
        ///cjIn: int
        ///pvIn: LPCSTR->CHAR*
        ///pvOut: LPVOID->void*
        [DllImportAttribute("gdi32.dll", EntryPoint = "Escape")]
        public static extern int Escape([InAttribute] IntPtr hdc, int iEscape, int cjIn, [InAttribute] [MarshalAsAttribute(UnmanagedType.LPStr)] string pvIn, IntPtr pvOut);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        [DllImportAttribute("gdi32.dll", EntryPoint = "EndDoc")]
        public static extern int EndDoc([InAttribute] IntPtr hdc);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///lppt: LPPOINT->tagPOINT*
        ///c: int
        [DllImportAttribute("gdi32.dll", EntryPoint = "DPtoLP")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool DPtoLP([InAttribute] IntPtr hdc, IntPtr lppt, int c);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///x: int
        ///y: int
        ///cx: int
        ///cy: int
        ///hdcSrc: HDC->HDC__*
        ///x1: int
        ///y1: int
        ///rop: DWORD->unsigned int
        [DllImportAttribute("gdi32.dll", EntryPoint = "BitBlt")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool BitBlt([InAttribute] IntPtr hdc, int x, int y, int cx, int cy, [InAttribute] IntPtr hdcSrc, int x1, int y1, uint rop);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///x1: int
        ///y1: int
        ///x2: int
        ///y2: int
        ///x3: int
        ///y3: int
        ///x4: int
        ///y4: int
        [DllImportAttribute("gdi32.dll", EntryPoint = "Chord")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool Chord([InAttribute] IntPtr hdc, int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///left: int
        ///top: int
        ///right: int
        ///bottom: int
        ///xr1: int
        ///yr1: int
        ///xr2: int
        ///yr2: int
        [DllImportAttribute("gdi32.dll", EntryPoint = "ArcTo")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool ArcTo([InAttribute] IntPtr hdc, int left, int top, int right, int bottom, int xr1, int yr1, int xr2, int yr2);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///left: int
        ///top: int
        ///right: int
        ///bottom: int
        ///xr1: int
        ///yr1: int
        ///xr2: int
        ///yr2: int
        [DllImportAttribute("gdi32.dll", EntryPoint = "Pie")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool Pie([InAttribute] IntPtr hdc, int left, int top, int right, int bottom, int xr1, int yr1, int xr2, int yr2);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///x1: int
        ///y1: int
        ///x2: int
        ///y2: int
        ///x3: int
        ///y3: int
        ///x4: int
        ///y4: int
        [DllImportAttribute("gdi32.dll", EntryPoint = "Arc")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool Arc([InAttribute] IntPtr hdc, int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4);


        /// Return Type: UINT->unsigned int
        ///hemf: HENHMETAFILE->HENHMETAFILE__*
        ///cbBuffer: UINT->unsigned int
        ///ppfd: PIXELFORMATDESCRIPTOR*
        [DllImportAttribute("gdi32.dll", EntryPoint = "GetEnhMetaFilePixelFormat")]
        public static extern uint GetEnhMetaFilePixelFormat([InAttribute] IntPtr hemf, uint cbBuffer, IntPtr ppfd);

    }

}
