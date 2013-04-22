using System;
using System.Runtime.InteropServices;
using System.Text;
using Win32Interop.Enums;
using Win32Interop.Structs;

// ReSharper disable CheckNamespace
namespace Win32Interop.Methods
// ReSharper restore CheckNamespace
{
	// ReSharper disable InconsistentNaming
	/// <summary>
	///     The <see cref="EnumICMProfilesProcCallback" /> callback is an application-defined callback function that processes color profile data from
	///     <see cref="Gdi32.EnumICMProfiles" /> .
	/// </summary>
	/// <param name="lpszFilename">Pointer to the file name of the color profile.</param>
	/// <param name="lParam">
	///     Data supplied by the application that is passed to the callback function by the <see cref="Gdi32.EnumICMProfiles" /> function.
	/// </param>
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate int EnumICMProfilesProcCallback(StringBuilder lpszFilename, IntPtr lParam);

	/// <summary>
	///     The <see cref="EnhMetaFileProc" /> function is an application-defined callback function used with the <see cref="Gdi32.EnumEnhMetaFile" />
	///     function. The <see cref="EnhMetaFileProc" /> type defines a pointer to this callback function. <see cref="EnhMetaFileProc" /> is a placeholder
	///     for the application-defined function name.
	/// </summary>
	/// <param name="hDC">
	///     Handle to the device context passed to <see cref="Gdi32.EnumEnhMetaFile" />.
	/// </param>
	/// <param name="lpHTable">
	///     Pointer to a <see cref="HANDLETABLE" /> structure representing the table of handles associated with the graphics objects (pens, brushes, and so
	///     on) in the metafile. The first entry contains the enhanced-metafile handle.
	/// </param>
	/// <param name="lpEMFR">
	///     Pointer to one of the records in the metafile. This record should not be modified. (If modification is necessary, it should be performed on a
	///     copy of the record.)
	/// </param>
	/// <param name="nObj">Specifies the number of objects with associated handles in the handle table.</param>
	/// <param name="lpData">Pointer to optional data.</param>
	/// <returns>This function must return a nonzero value to continue enumeration; to stop enumeration, it must return zero.</returns>
	/// <remarks>
	///     An application must register the callback function by passing its address to the <see cref="Gdi32.EnumEnhMetaFile" /> function.
	/// </remarks>
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate int EnhMetaFileProc([In] IntPtr hDC, [In] ref HANDLETABLE lpHTable, [In] ref ENHMETARECORD lpEMFR, int nObj, [In] IntPtr lpData);

	/// <summary>
	///     The <see cref="AbortProc" /> function is an application-defined callback function used with the <see cref="Gdi32.SetAbortProc" /> function. It is
	///     called when a print job is to be canceled during spooling. The <see cref="AbortProc" /> type defines a pointer to this callback function.
	///     <see cref="AbortProc" /> is a placeholder for the application-defined function name.
	/// </summary>
	/// <param name="hdc">A handle to the device context for the print job.</param>
	/// <param name="iError">
	///     Specifies whether an error has occurred. This parameter is zero if no error has occurred; it is SP_OUTOFDISK if Print Manager is currently out of
	///     disk space and more disk space will become available if the application waits.
	/// </param>
	/// <returns>The callback function should return TRUE to continue the print job or FALSE to cancel the print job.</returns>
	/// <remarks>
	///     <para>
	///         Note:  This is a blocking or synchronous function and might not return immediately. How quickly this function returns depends on run-time
	///         factors such as network status, print server configuration, and printer driver implementation—factors that are difficult to predict when
	///         writing an application. Calling this function from a thread that manages interaction with the user interface could make the application
	///         appear to be unresponsive.
	///     </para>
	///     <para>
	///         If the <paramref name="iError" /> parameter is SP_OUTOFDISK, the application need not cancel the print job. If it does not cancel the job, it
	///         must yield to Print Manager by calling thePeekMessage or GetMessage function.
	///     </para>
	/// </remarks>
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate int AbortProc([In] IntPtr hdc, int iError);

	/// <summary>
	///     <para>
	///         The <see cref="EnumMetaFileProc" /> function is an application-defined callback function that processes Windows-format metafile records. This
	///         function is called by the <see cref="Gdi32.EnumMetaFile" /> function. The <see cref="EnumMetaFileProc" /> type defines a pointer to this
	///         callback function. <see cref="EnumMetaFileProc" /> is a placeholder for the application-defined function name.
	///     </para>
	///     <para>
	///         Note:  This function is provided only for compatibility with Windows-format metafiles. Enhanced-format metafiles provide superior
	///         functionality and are recommended for new applications. The corresponding function for an enhanced-format metafile is
	///         <see cref="EnhMetaFileProc" />.
	///     </para>
	/// </summary>
	/// <param name="hDC">
	///     Handle to the device context passed to <see cref="Gdi32.EnumMetaFile" />.
	/// </param>
	/// <param name="lpHTable">Pointer to a table of handles associated with the graphics objects (pens, brushes, and so on) in the metafile.</param>
	/// <param name="lpMFR">
	///     Pointer to one of the records in the metafile. This record should not be modified. (If modification is necessary, it should be performed on a
	///     copy of the record.)
	/// </param>
	/// <param name="nObj">Specifies the number of objects with associated handles in the handle table.</param>
	/// <param name="lpClientData">Pointer to optional data.</param>
	/// <returns>This function must return a nonzero value to continue enumeration; to stop enumeration, it must return zero.</returns>
	/// <remarks>
	///     <para>
	///         An application must register the callback function by passing its address to the <see cref="Gdi32.EnumMetaFile" /> function.
	///     </para>
	///     <para>
	///         <see cref="EnumMetaFileProc" /> is a placeholder for the application-supplied function name.
	///     </para>
	/// </remarks>
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate int EnumMetaFileProc([In] IntPtr hDC, [In] ref HANDLETABLE lpHTable, [In] ref METARECORD lpMFR, int nObj, [In] IntPtr lpClientData);

	/// <summary>
	///     The <see cref="EnumObjectsProc" /> function is an application-defined callback function used with the <see cref="Gdi32.EnumObjects" /> function.
	///     It is used to process the object data. The GOBJENUMPROC type defines a pointer to this callback function. <see cref="EnumObjectsProc" /> is a
	///     placeholder for the application-defined function name.
	/// </summary>
	/// <param name="lpLogObject">
	///     A pointer to a <see cref="LOGPEN" /> or <see cref="LOGBRUSH" /> structure describing the attributes of the object.
	/// </param>
	/// <param name="lpData">
	///     A pointer to the application-defined data passed by the <see cref="Gdi32.EnumObjects" /> function.
	/// </param>
	/// <returns>
	///     <para>To continue enumeration, the callback function must return a nonzero value. This value is user-defined.</para>
	///     <para>To stop enumeration, the callback function must return zero.</para>
	/// </returns>
	/// <remarks>
	///     An application must register this function by passing its address to the <see cref="Gdi32.EnumObjects" /> function.
	/// </remarks>
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate int EnumObjectsProc(IntPtr lpLogObject, IntPtr lpData);

	/// <summary>
	///     The <see cref="LineDDAProc" /> function is an application-defined callback function used with the <see cref="Gdi32.LineDDA" /> function. It is
	///     used to process coordinates. The <see cref="LineDDAProc" /> type defines a pointer to this callback function. <see cref="LineDDAProc" /> is a
	///     placeholder for the application-defined function name.
	/// </summary>
	/// <param name="X">Specifies the x-coordinate, in logical units, of the current point.</param>
	/// <param name="Y">Specifies the y-coordinate, in logical units, of the current point.</param>
	/// <param name="lpData">Pointer to the application-defined data.</param>
	/// <returns>This function does not return a value.</returns>
	/// <remarks>
	///     An application registers a <see cref="LineDDAProc" /> function by passing its address to the <see cref="Gdi32.LineDDA" /> function.
	/// </remarks>
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate void LineDDAProc(int X, int Y, IntPtr lpData);

	/// <summary>
	///     The <see cref="EnumFontFamExProc" /> function is an application defined callback function used with the <see cref="Gdi32.EnumFontFamiliesEx" />
	///     function. It is used to process the fonts. It is called once for each enumerated font. The FONTENUMPROC type defines a pointer to this callback
	///     function. <see cref="EnumFontFamExProc" /> is a placeholder for the application defined function name.
	/// </summary>
	/// <param name="lpelfe">
	///     A pointer to an <see cref="LOGFONT" /> structure that contains information about the logical attributes of the font. To obtain additional
	///     information about the font, you can cast the result as an <see cref="ENUMLOGFONTEX" /> or <see cref="ENUMLOGFONTEXDV" /> structure.
	/// </param>
	/// <param name="lpntme">
	///     <para>
	///         A pointer to a structure that contains information about the physical attributes of a font. The function uses the
	///         <see cref="NEWTEXTMETRICEX" /> structure for TrueType fonts; and the <see cref="TEXTMETRIC" /> structure for other fonts.
	///     </para>
	///     <para>
	///         This can be an <see cref="ENUMTEXTMETRIC" /> structure.
	///     </para>
	/// </param>
	/// <param name="FontType">
	///     <para>The type of the font. This parameter can be a combination of these values:</para>
	///     <list type="bullet">
	///         <item>DEVICE_FONTTYPE</item>
	///         <item>RASTER_FONTTYPE</item>
	///         <item>TRUETYPE_FONTTYPE</item>
	///     </list>
	/// </param>
	/// <param name="lParam">
	///     The application-defined data passed by the <see cref="Gdi32.EnumFontFamiliesEx" /> function.
	/// </param>
	/// <returns>The return value must be a nonzero value to continue enumeration; to stop enumeration, the return value must be zero.</returns>
	/// <remarks>
	///     <para>
	///         An application must register this callback function by passing its address to the <see cref="Gdi32.EnumFontFamiliesEx" /> function.
	///     </para>
	///     <para>
	///         When the graphics mode on the device context is set to GM_ADVANCED using the <see cref="Gdi32.SetGraphicsMode" /> function and the
	///         DEVICE_FONTTYPE flag is passed to the FontType parameter, this function returns a list of type 1 and OpenType fonts on the system. When the
	///         graphics mode is not set to GM_ADVANCED, this function returns a list of type 1, OpenType, and TrueType fonts on the system.
	///     </para>
	///     <para>
	///         Unlike the EnumFontFamProc callback function, <see cref="EnumFontFamExProc" /> receives extended information about a font. The
	///         <see cref="ENUMLOGFONTEX" /> structure includes the localized name of the script (character set) and the <see cref="NEWTEXTMETRICEX" />
	///         structure includes a font-coverage signature.
	///     </para>
	/// </remarks>
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate int EnumFontFamExProc(ref LOGFONT lpelfe, IntPtr lpntme, uint FontType, IntPtr lParam);

	/// <summary>Collection of native methods in gdi32.dll.</summary>
	public class Gdi32
	{
		/// <summary>
		///     The <see cref="GetEnhMetaFilePaletteEntries" /> function retrieves optional palette entries from the specified enhanced metafile.
		/// </summary>
		/// <param name="hemf">A handle to the enhanced metafile.</param>
		/// <param name="cEntries">The number of entries to be retrieved from the optional palette.</param>
		/// <param name="lppe">
		///     A pointer to an array of <see cref="PALETTEENTRY" /> structures that receives the palette colors. The array must contain at least as many
		///     structures as there are entries specified by the <paramref name="cEntries" /> parameter.
		/// </param>
		/// <returns>
		///     If the array pointer is NULL and the enhanced metafile contains an optional palette, the return value is the number of entries in the enhanced
		///     metafile's palette; if the array pointer is a valid pointer and the enhanced metafile contains an optional palette, the return value is the
		///     number of entries copied; if the metafile does not contain an optional palette, the return value is zero. Otherwise, the return value is
		///     GDI_ERROR.
		/// </returns>
		/// <remarks>
		///     <para>
		///         An application can store an optional palette in an enhanced metafile by calling the <see cref="CreatePalette" /> and
		///         <see cref="SetPaletteEntries" /> functions before creating the picture and storing it in the metafile. By doing this, the application can
		///         achieve consistent colors when the picture is displayed on a variety of devices.
		///     </para>
		///     <para>
		///         An application that displays a picture stored in an enhanced metafile can call the <see cref="GetEnhMetaFilePaletteEntries" /> function to
		///         determine whether the optional palette exists. If it does, the application can call the <see cref="GetEnhMetaFilePaletteEntries" /> function
		///         a second time to retrieve the palette entries and then create a logical palette (by using the <see cref="CreatePalette" /> function), select
		///         it into its device context (by using the <see cref="SelectPalette" /> function), and then realize it (by using the
		///         <see cref="RealizePalette" /> function). After the logical palette has been realized, calling the <see cref="PlayEnhMetaFile" /> function
		///         displays the picture using its original colors.
		///     </para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "GetEnhMetaFilePaletteEntries")]
		public static extern uint GetEnhMetaFilePaletteEntries([In] IntPtr hemf, uint cEntries, ref PALETTEENTRY[] lppe);

		/// <summary>
		///     <para>
		///         The <see cref="CreateScalableFontResource" /> function is available for use in the operating systems specified in the Requirements section.
		///         It may be altered or unavailable in subsequent versions.
		///     </para>
		///     <para>
		///         The <see cref="CreateScalableFontResource" /> function creates a font resource file for a scalable font.
		///     </para>
		/// </summary>
		/// <param name="fdwHidden">
		///     <para>Specifies whether the font is a read-only font. This parameter can be one of the following values.</para>
		///     <list type="table">
		///         <item>
		///             <term>0</term>
		///             <description>The font has read/write permission.</description>
		///         </item>
		///         <item>
		///             <term>1</term>
		///             <description>
		///                 The font has read-only permission and should be hidden from other applications in the system. When this flag is set, the font is not
		///                 enumerated by the <see cref="EnumFonts" /> or <see cref="EnumFontFamilies" /> function.
		///             </description>
		///         </item>
		///     </list>
		/// </param>
		/// <param name="lpszFontRes">
		///     A pointer to a null-terminated string specifying the name of the font resource file to create. If this parameter specifies an existing font
		///     resource file, the function fails.
		/// </param>
		/// <param name="lpszFontFile">
		///     A pointer to a null-terminated string specifying the name of the scalable font file that this function uses to create the
		///     font resource file.
		/// </param>
		/// <param name="lpszCurrentPath">A pointer to a null-terminated string specifying the path to the scalable font file.</param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		///     <para>
		///         If <paramref name="lpszFontRes" /> specifies an existing font file, GetLastError returns ERROR_FILE_EXISTS
		///     </para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         The <see cref="CreateScalableFontResource" /> function is used by applications that install TrueType fonts. An application uses the
		///         <see cref="CreateScalableFontResource" /> function to create a font resource file (typically with a .fot file name extension) and then uses
		///         the <see cref="AddFontResource" /> function to install the font. The TrueType font file (typically with a .ttf file name extension) must be
		///         in the System subdirectory of the Windows directory to be used by the <see cref="AddFontResource" /> function.
		///     </para>
		///     <para>
		///         The <see cref="CreateScalableFontResource" /> function currently supports only TrueType-technology scalable fonts.
		///     </para>
		///     <para>
		///         When the <paramref name="lpszFontFile" /> parameter specifies only a file name and extension, the <paramref name="lpszCurrentPath" />
		///         parameter must specify a path. When the <paramref name="lpszFontFile" /> parameter specifies a full path, the
		///         <paramref name="lpszCurrentPath" /> parameter must be NULL or a pointer to NULL.
		///     </para>
		///     <para>
		///         When only a file name and extension are specified in the <paramref name="lpszFontFile" /> parameter and a path is specified in the
		///         <paramref name="lpszCurrentPath" /> parameter, the string in <paramref name="lpszFontFile" /> is copied into the .fot file as the .ttf file
		///         that belongs to this resource. When the <see cref="AddFontResource" /> function is called, the operating system assumes that the .ttf file
		///         has been copied into the System directory (or into the main Windows directory in the case of a network installation). The .ttf file need not
		///         be in this directory when the <see cref="CreateScalableFontResource" /> function is called, because the <paramref name="lpszCurrentPath" />
		///         parameter contains the directory information. A resource created in this manner does not contain absolute path information and can be used in
		///         any installation.
		///     </para>
		///     <para>
		///         When a path is specified in the <paramref name="lpszFontFile" /> parameter and NULL is specified in the <paramref name="lpszCurrentPath" />
		///         parameter, the string in <paramref name="lpszFontFile" /> is copied into the .fot file. In this case, when the <see cref="AddFontResource" />
		///         function is called, the .ttf file must be at the location specified in the <paramref name="lpszFontFile" /> parameter when the
		///         <see cref="CreateScalableFontResource" /> function was called; the <paramref name="lpszCurrentPath" /> parameter is not needed. A resource
		///         created in this manner contains absolute references to paths and drives and does not work if the .ttf file is moved to a different location.
		///     </para>
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "CreateScalableFontResource")]
		public static extern bool CreateScalableFontResource(uint fdwHidden, string lpszFontRes, string lpszFontFile, string lpszCurrentPath);

		/// <summary>
		///     The <see cref="GetEnhMetaFileDescription" /> function retrieves an optional text description from an enhanced-format metafile and copies the
		///     string to the specified buffer.
		/// </summary>
		/// <param name="hemf">A handle to the enhanced metafile.</param>
		/// <param name="cchBuffer">The size, in characters, of the buffer to receive the data. Only this many characters will be copied.</param>
		/// <param name="lpszDescription">A pointer to a buffer that receives the optional text description.</param>
		/// <returns>
		///     <para>If the optional text description exists and the buffer pointer is NULL, the return value is the length of the text string, in characters.</para>
		///     <para>
		///         If the optional text description exists and the buffer pointer is a valid pointer, the return value is the number of characters copied into
		///         the buffer.
		///     </para>
		///     <para>If the optional text description does not exist, the return value is zero.</para>
		///     <para>If the function fails, the return value is GDI_ERROR.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         The optional text description contains two strings, the first identifying the application that created the enhanced metafile and the second
		///         identifying the picture contained in the metafile. The strings are separated by a null character and terminated with two null charactersfor
		///         example, "XYZ Graphics Editor\0Bald Eagle\0\0" where \0 represents the null character.
		///     </para>
		///     <para>
		///         Where text arguments must use Unicode characters, use this function as a wide-character function. Where text arguments must use characters
		///         from the Windows character set, use this function as an ANSI function.
		///     </para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "GetEnhMetaFileDescription")]
		public static extern uint GetEnhMetaFileDescription([In] IntPtr hemf, uint cchBuffer, [Out] StringBuilder lpszDescription);

		/// <summary>
		///     The <see cref="CreateEllipticRgnIndirect" /> function creates an elliptical region.
		/// </summary>
		/// <param name="lprc">
		///     Pointer to a <see cref="RECT" /> structure that contains the coordinates of the upper-left and lower-right corners of the bounding rectangle of
		///     the ellipse in logical units.
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is the handle to the region.</para>
		///     <para>If the function fails, the return value is NULL.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         When you no longer need the HRGN object, call the <see cref="DeleteObject" /> function to delete it.
		///     </para>
		///     <para>
		///         A bounding rectangle defines the size, shape, and orientation of the region: The long sides of the rectangle define the length of the
		///         ellipse's major axis; the short sides define the length of the ellipse's minor axis; and the center of the rectangle defines the intersection
		///         of the major and minor axes.
		///     </para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "CreateEllipticRgnIndirect")]
		public static extern IntPtr CreateEllipticRgnIndirect([In] ref RECT lprc);

		/// <summary>
		///     The <see cref="RemoveFontMemResourceEx" /> function removes the fonts added from a memory image file.
		/// </summary>
		/// <param name="fh">
		///     A handle to the font-resource. This handle is returned by the <see cref="AddFontMemResourceEx" /> function.
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero. No extended error information is available.</para>
		/// </returns>
		/// <remarks>
		///     This function removes a font that was added by the <see cref="AddFontMemResourceEx" /> function. To remove the font, specify the same path and
		///     flags as were used in <see cref="AddFontMemResourceEx" />. This function will only remove the font that is specified by <paramref name="fh" />.
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "RemoveFontMemResourceEx")]
		public static extern bool RemoveFontMemResourceEx([In] IntPtr fh);

		/// <summary>
		///     The <see cref="GetSystemPaletteEntries" /> function retrieves a range of palette entries from the system palette that is associated with the
		///     specified device context (DC).
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <param name="iStartIndex">The first entry to be retrieved from the system palette.</param>
		/// <param name="nEntries">The number of entries to be retrieved from the system palette.</param>
		/// <param name="lppe">
		///     A pointer to an array of <see cref="PALETTEENTRY" /> structures to receive the palette entries. The array must contain at least as many
		///     structures as specified by the <paramref name="nEntries" /> parameter. If this parameter is NULL, the function returns the total number of
		///     entries in the palette.
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is the number of entries retrieved from the palette.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     An application can determine whether a device supports palette operations by calling the <see cref="GetDeviceCaps" /> function and specifying the
		///     RASTERCAPS constant.
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "GetSystemPaletteEntries")]
		public static extern uint GetSystemPaletteEntries([In] IntPtr hdc, uint iStartIndex, uint nEntries, ref PALETTEENTRY[] lppe);

		/// <summary>
		///     <para>
		///         The <see cref="CreateDiscardableBitmap" /> function creates a discardable bitmap that is compatible with the specified device. The bitmap has
		///         the same bits-per-pixel format and the same color palette as the device. An application can select this bitmap as the current bitmap for a
		///         memory device that is compatible with the specified device.
		///     </para>
		///     <para>
		///         This function is provided only for compatibility with 16-bit versions of Windows. Applications should use the
		///         <see cref="CreateCompatibleBitmap" /> function.
		///     </para>
		/// </summary>
		/// <param name="hdc">A handle to a device context.</param>
		/// <param name="nWidth">The width, in pixels, of the bitmap.</param>
		/// <param name="nHeight">The height, in pixels, of the bitmap.</param>
		/// <returns>
		///     <para>If the function succeeds, the return value is a handle to the compatible bitmap (DDB).</para>
		///     <para>If the function fails, the return value is NULL.</para>
		/// </returns>
		/// <remarks>
		///     When you no longer need the bitmap, call the <see cref="DeleteObject" /> function to delete it.
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "CreateDiscardableBitmap")]
		public static extern IntPtr CreateDiscardableBitmap([In] IntPtr hdc, int nWidth, int nHeight);

		/// <summary>
		///     The <see cref="CreateDIBPatternBrushPt" /> function creates a logical brush that has the pattern specified by the device-independent bitmap
		///     (DIB).
		/// </summary>
		/// <param name="lpPackedDIB">
		///     A pointer to a packed DIB consisting of a <see cref="BITMAPINFO" /> structure immediately followed by an array of bytes defining the pixels of
		///     the bitmap.
		/// </param>
		/// <param name="iUsage">
		///     <para>
		///         Specifies whether the <see cref="BITMAPINFO.bmiColors" /> member of the <see cref="BITMAPINFO" /> structure contains a valid color table and,
		///         if so, whether the entries in this color table contain explicit red, green, blue (RGB) values or palette indexes. The
		///         <paramref name="iUsage" /> parameter must be one of the following values.
		///     </para>
		///     <list type="table">
		///         <item>
		///             <term>DIB_PAL_COLORS</term>
		///             <description>
		///                 A color table is provided and consists of an array of 16-bit indexes into the logical palette of the device context into which the
		///                 brush is to be selected.
		///             </description>
		///         </item>
		///         <item>
		///             <term>DIB_RGB_COLORS</term>
		///             <description>A color table is provided and contains literal RGB values.</description>
		///         </item>
		///     </list>
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value identifies a logical brush.</para>
		///     <para>If the function fails, the return value is NULL.</para>
		/// </returns>
		/// <remarks>
		///     <para>A brush is a bitmap that the system uses to paint the interiors of filled shapes.</para>
		///     <para>
		///         After an application creates a brush by calling <see cref="CreateDIBPatternBrushPt" />, it can select that brush into any device context by
		///         calling the <see cref="SelectObject" /> function.
		///     </para>
		///     <para>
		///         When you no longer need the brush, call the <see cref="DeleteObject" /> function to delete it.
		///     </para>
		///     <para>
		///         ICM: No color is done at brush creation. However, color management is performed when the brush is selected into an ICM-enabled device
		///         context.
		///     </para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "CreateDIBPatternBrushPt")]
		public static extern IntPtr CreateDIBPatternBrushPt([In] IntPtr lpPackedDIB, uint iUsage);

		/// <summary>
		///     The <see cref="GetOutlineTextMetrics" /> function retrieves text metrics for TrueType fonts.
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <param name="cbData">The size, in bytes, of the array that receives the text metrics.</param>
		/// <param name="lpOTM">
		///     A pointer to an <see cref="OUTLINETEXTMETRIC" /> structure. If this parameter is NULL, the function returns the size of the buffer required for
		///     the retrieved metric data.
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero or the size of the required buffer.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     The <see cref="OUTLINETEXTMETRIC" /> structure contains most of the text metric information provided for TrueType fonts (including a
		///     <see cref="TEXTMETRIC" /> structure). The sizes returned in <see cref="OUTLINETEXTMETRIC" /> are in logical units; they depend on the current
		///     mapping mode.
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "GetOutlineTextMetrics")]
		public static extern uint GetOutlineTextMetrics([In] IntPtr hdc, uint cbData, ref OUTLINETEXTMETRIC lpOTM);

		/// <summary>
		///     The <see cref="GetNearestPaletteIndex" /> function retrieves the index for the entry in the specified logical palette most closely matching a
		///     specified color value.
		/// </summary>
		/// <param name="hpal">A handle to a logical palette.</param>
		/// <param name="crColor">
		///     A color to be matched. To create a <see cref="COLORREF" /> color value, use the RGB macro.
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is the index of an entry in a logical palette.</para>
		///     <para>If the function fails, the return value is CLR_INVALID.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         An application can determine whether a device supports palette operations by calling the <see cref="GetDeviceCaps" /> function and specifying
		///         the RASTERCAPS constant.
		///     </para>
		///     <para>If the given logical palette contains entries with the PC_EXPLICIT flag set, the return value is undefined.</para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "GetNearestPaletteIndex")]
		public static extern uint GetNearestPaletteIndex([In] IntPtr hpal, uint crColor);

		/// <summary>
		///     <para>
		///         The <see cref="GetCharacterPlacement" /> function retrieves information about a character string, such as character widths, caret
		///         positioning, ordering within the string, and glyph rendering. The type of information returned depends on the <paramref name="dwFlags" />
		///         parameter and is based on the currently selected font in the specified display context. The function copies the information to the specified
		///         <see cref="GCP_RESULTS" /> structure or to one or more arrays specified by the structure.
		///     </para>
		///     <para>
		///         Although this function was once adequate for working with character strings, a need to work with an increasing number of languages and
		///         scripts has rendered it obsolete. It has been superseded by the functionality of the Uniscribe module. For more information, see Uniscribe.
		///     </para>
		///     <para>
		///         It is recommended that an application use the <see cref="GetFontLanguageInfo" /> function to determine whether the GCP_DIACRITIC, GCP_DBCS,
		///         GCP_USEKERNING, GCP_LIGATE, GCP_REORDER, GCP_GLYPHSHAPE, and GCP_KASHIDA values are valid for the currently selected font. If not valid,
		///         <see cref="GetCharacterPlacement" /> ignores the value.
		///     </para>
		///     <para>The GCP_NODIACRITICS value is no longer defined and should not be used.</para>
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <param name="lpString">
		///     A pointer to the character string to process. The string does not need to be zero-terminated, since <paramref name="nCount" /> specifies the
		///     length of the string.
		/// </param>
		/// <param name="nCount">
		///     The length of the string pointed to by <paramref name="lpString" />.
		/// </param>
		/// <param name="nMaxExtent">
		///     The maximum extent (in logical units) to which the string is processed. Characters that, if processed, would exceed this extent are ignored.
		///     Computations for any required ordering or glyph arrays apply only to the included characters. This parameter is used only if the GCP_MAXEXTENT
		///     value is specified in the <paramref name="dwFlags" /> parameter. As the function processes the input string, each character and its extent is
		///     added to the output, extent, and other arrays only if the total extent has not yet exceeded the maximum. Once the limit is reached, processing
		///     will stop.
		/// </param>
		/// <param name="lpResults">
		///     A pointer to a <see cref="GCP_RESULTS" /> structure that receives the results of the function.
		/// </param>
		/// <param name="dwFlags">
		///     <para>Specifies how to process the string into the required arrays. This parameter can be one or more of the following values.</para>
		///     <list type="table">
		///         <item>
		///             <term>GCP_CLASSIN</term>
		///             <description>
		///                 Specifies that the <see cref="GCP_RESULTS.lpClass" /> array contains preset classifications for characters. The classifications may
		///                 be the same as on output. If the particular classification for a character is not known, the corresponding location in the array must
		///                 be set to zero. for more information about the classifications, see GCP_RESULTS. This is useful only if
		///                 <see cref="GetFontLanguageInfo" /> returned the GCP_REORDER flag.
		///             </description>
		///         </item>
		///         <item>
		///             <term>GCP_DIACRITIC</term>
		///             <description>
		///                 <para>
		///                     Determines how diacritics in the string are handled. If this value is not set, diacritics are treated as zero-width characters.
		///                     For example, a Hebrew string may contain diacritics, but you may not want to display them.
		///                 </para>
		///                 <para>
		///                     Use <see cref="GetFontLanguageInfo" /> to determine whether a font supports diacritics. If it does, you can use or not use the
		///                     GCP_DIACRITIC flag in the call to <see cref="GetCharacterPlacement" />, depending on the needs of your application.
		///                 </para>
		///             </description>
		///         </item>
		///         <item>
		///             <term>GCP_DISPLAYZWG</term>
		///             <description>
		///                 For languages that need reordering or different glyph shapes depending on the positions of the characters within a word,
		///                 nondisplayable characters often appear in the code page. For example, in the Hebrew code page, there are Left-To-Right and
		///                 Right-To-Left markers, to help determine the final positioning of characters within the output strings. Normally these are not
		///                 displayed and are removed from the <see cref="GCP_RESULTS.lpGlyphs" /> and <see cref="GCP_RESULTS.lpDX" /> arrays. You can use the
		///                 GCP_DISPLAYZWG flag to display these characters.
		///             </description>
		///         </item>
		///         <item>
		///             <term>GCP_GLYPHSHAPE</term>
		///             <description>
		///                 Specifies that some or all characters in the string are to be displayed using shapes other than the standard shapes defined in the
		///                 currently selected font for the current code page. Some languages, such as Arabic, cannot support glyph creation unless this value is
		///                 specified. As a general rule, if <see cref="GetFontLanguageInfo" /> returns this value for a string, this value must be used with
		///                 <see cref="GetCharacterPlacement" />.
		///             </description>
		///         </item>
		///         <item>
		///             <term>GCP_JUSTIFY</term>
		///             <description>
		///                 Adjusts the extents in the <see cref="GCP_RESULTS.lpDX" /> array so that the string length is the same as
		///                 <paramref name="nMaxExtent" />. GCP_JUSTIFY may only be used in conjunction with GCP_MAXEXTENT.
		///             </description>
		///         </item>
		///         <item>
		///             <term>GCP_KASHIDA</term>
		///             <description>
		///                 <para>
		///                     Use Kashidas as well as, or instead of, adjusted extents to modify the length of the string so that it is equal to the value
		///                     specified by <paramref name="nMaxExtent" />. In the <see cref="GCP_RESULTS.lpDX" /> array, a Kashida is indicated by a negative
		///                     justification index. GCP_KASHIDA may be used only in conjunction with GCP_JUSTIFY and only if the font (and language) support
		///                     Kashidas. Use <see cref="GetFontLanguageInfo" /> to determine whether the current font supports Kashidas.
		///                 </para>
		///                 <para>
		///                     Using Kashidas to justify the string can result in the number of glyphs required being greater than the number of characters in
		///                     the input string. Because of this, when Kashidas are used, the application cannot assume that setting the arrays to be the size
		///                     of the input string will be sufficient. (The maximum possible will be approximately dxPageWidth/dxAveCharWidth, where dxPageWidth
		///                     is the width of the document and dxAveCharWidth is the average character width as returned from a <see cref="GetTextMetrics" />
		///                     call).
		///                 </para>
		///                 <para>
		///                     Note that just because <see cref="GetFontLanguageInfo" /> returns the GCP_KASHIDA flag does not mean that it has to be used in
		///                     the call to <see cref="GetCharacterPlacement" />, just that the option is available.
		///                 </para>
		///             </description>
		///         </item>
		///         <item>
		///             <term>GCP_LIGATE</term>
		///             <description>
		///                 <para>
		///                     Use ligations wherever characters ligate. A ligation occurs where one glyph is used for two or more characters. For example, the
		///                     letters a and e can ligate to ?. For this to be used, however, both the language support and the font must support the required
		///                     glyphs (the example will not be processed by default in English).
		///                 </para>
		///                 <para>
		///                     Use <see cref="GetFontLanguageInfo" /> to determine whether the current font supports ligation. If it does and a specific maximum
		///                     is required for the number of characters that will ligate, set the number in the first element of the
		///                     <see cref="GCP_RESULTS.lpGlyphs" />
		///                     array. If normal ligation is required, set this value to zero. If GCP_LIGATE is not specified, no ligation will take place. See
		///                     GCP_RESULTS for more information.
		///                 </para>
		///                 <para>
		///                     If the GCP_REORDER value is usually required for the character set but is not specified, the output will be meaningless unless
		///                     the string being passed in is already in visual ordering (that is, the result that gets put into lpGcpResults->lpOutString in one
		///                     call to <see cref="GetCharacterPlacement" /> is the input string of a second call).
		///                 </para>
		///                 <para>
		///                     Note that just because <see cref="GetFontLanguageInfo" /> returns the GCP_LIGATE flag does not mean that it has to be used in the
		///                     call to <see cref="GetCharacterPlacement" />, just that the option is available.
		///                 </para>
		///             </description>
		///         </item>
		///         <item>
		///             <term>GCP_MAXEXTENT</term>
		///             <description>
		///                 Compute extents of the string only as long as the resulting extent, in logical units, does not exceed the values specified by the
		///                 <paramref name="nMaxExtent" /> parameter.
		///             </description>
		///         </item>
		///         <item>
		///             <term>GCP_NEUTRALOVERRIDE</term>
		///             <description>
		///                 Certain languages only. Override the normal handling of neutrals and treat them as strong characters that match the strings reading
		///                 order. Useful only with the GCP_REORDER flag.
		///             </description>
		///         </item>
		///         <item>
		///             <term>GCP_NUMERICOVERRIDE</term>
		///             <description>
		///                 Certain languages only. Override the normal handling of numerics and treat them as strong characters that match the strings reading
		///                 order. Useful only with the GCP_REORDER flag.
		///             </description>
		///         </item>
		///         <item>
		///             <term>GCP_NUMERICSLATIN</term>
		///             <description>
		///                 Arabic/Thai only. Use standard Latin glyphs for numbers and override the system default. To determine if this option is available in
		///                 the language of the font, use GetStringTypeEx to see if the language supports more than one number format.
		///             </description>
		///         </item>
		///         <item>
		///             <term>GCP_NUMERICSLOCAL</term>
		///             <description>
		///                 Arabic/Thai only. Use local glyphs for numeric characters and override the system default. To determine if this option is available
		///                 in the language of the font, use GetStringTypeEx to see if the language supports more than one number format.
		///             </description>
		///         </item>
		///         <item>
		///             <term>GCP_REORDER</term>
		///             <description>
		///                 <para>
		///                     Reorder the string. Use for languages that are not SBCS and left-to-right reading order. If this value is not specified, the
		///                     string is assumed to be in display order already.
		///                 </para>
		///                 <para>
		///                     If this flag is set for Semitic languages and the <see cref="GCP_RESULTS.lpClass" /> array is used, the first two elements of the
		///                     array are used to specify the reading order beyond the bounds of the string. GCP_CLASS_PREBOUNDRTL and GCP_CLASS_PREBOUNDLTR can
		///                     be used to set the order. If no preset order is required, set the values to zero. These values can be combined with other values
		///                     if the GCPCLASSIN flag is set.
		///                 </para>
		///                 <para>
		///                     If the GCP_REORDER value is not specified, the <paramref name="lpString" /> parameter is taken to be visual ordered for languages
		///                     where this is used, and the <see cref="GCP_RESULTS.lpOutString" /> and <see cref="GCP_RESULTS.lpOrder" /> fields are ignored.
		///                 </para>
		///                 <para>
		///                     Use <see cref="GetFontLanguageInfo" /> to determine whether the current font supports reordering.
		///                 </para>
		///             </description>
		///         </item>
		///         <item>
		///             <term>GCP_SYMSWAPOFF</term>
		///             <description>
		///                 Semitic languages only. Specifies that swappable characters are not reset. For example, in a right-to-left string, the '('
		///                 and ')' are not reversed.
		///             </description>
		///         </item>
		///         <item>
		///             <term>GCP_USEKERNING</term>
		///             <description>
		///                 <para>
		///                     Use kerning pairs in the font (if any) when creating the widths arrays. Use <see cref="GetFontLanguageInfo" /> to determine
		///                     whether the current font supports kerning pairs.
		///                 </para>
		///                 <para>
		///                     Note that just because <see cref="GetFontLanguageInfo" /> returns the GCP_USEKERNING flag does not mean that it has to be used in
		///                     the call to <see cref="GetCharacterPlacement" />, just that the option is available. Most TrueType fonts have a kerning table,
		///                     but you do not have to use it.
		///                 </para>
		///             </description>
		///         </item>
		///     </list>
		///     <para>
		///         It is recommended that an application use the <see cref="GetFontLanguageInfo" /> function to determine whether the GCP_DIACRITIC, GCP_DBCS,
		///         GCP_USEKERNING, GCP_LIGATE, GCP_REORDER, GCP_GLYPHSHAPE, and GCP_KASHIDA values are valid for the currently selected font. If not valid,
		///         <see cref="GetCharacterPlacement" /> ignores the value.
		///     </para>
		///     <para>The GCP_NODIACRITICS value is no longer defined and should not be used.</para>
		/// </param>
		/// <returns>
		///     <para>
		///         If the function succeeds, the return value is the  width and height of the string in logical units. The width is the low-order word and the
		///         height is the high-order word.
		///     </para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         <see cref="GetCharacterPlacement" /> ensures that an application can correctly process text regardless of the international setting and type
		///         of fonts available. Applications use this function before using the <see cref="ExtTextOut" /> function and in place of the
		///         <see cref="GetTextExtentPoint32" /> function (and occasionally in place of the <see cref="GetCharWidth32" /> and
		///         <see cref="GetCharABCWidths" /> functions).
		///     </para>
		///     <para>
		///         Using <see cref="GetCharacterPlacement" /> to retrieve intercharacter spacing and index arrays is not always necessary unless justification
		///         or kerning is required. For non-Latin fonts, applications can improve the speed at which the <see cref="ExtTextOut" /> function renders text
		///         by using <see cref="GetCharacterPlacement" /> to retrieve the intercharacter spacing and index arrays before calling
		///         <see cref="ExtTextOut" />. This is especially useful when rendering the same text repeatedly or when using intercharacter spacing to position
		///         the caret. If the<see cref="GCP_RESULTS.lpGlyphs" /> output array is used in the call to <see cref="ExtTextOut" />, the ETO_GLYPH_INDEX flag
		///         must be set.
		///     </para>
		///     <para>
		///         <see cref="GetCharacterPlacement" /> checks the <see cref="GCP_RESULTS.lpOrder" />, <see cref="GCP_RESULTS.lpDX" />,
		///         <see cref="GCP_RESULTS.lpCaretPos" />, <see cref="GCP_RESULTS.lpOutString" />, and <see cref="GCP_RESULTS.lpGlyphs" /> members of the
		///         <see cref="GCP_RESULTS" /> structure and fills the corresponding arrays if these members are not set to NULL. If
		///         <see cref="GetCharacterPlacement" /> cannot fill an array, it sets the corresponding member to NULL. To ensure retrieval of valid
		///         information, the application is responsible for setting the member to a valid address before calling the function and for checking the value
		///         of the member after the call. If the GCP_JUSTIFY or GCP_USEKERNING values are specified, the <see cref="GCP_RESULTS.lpDX" /> and/or
		///         <see cref="GCP_RESULTS.lpCaretPos" /> members must have valid addresses.
		///     </para>
		///     <para>
		///         Note that the glyph indexes returned in GCP_RESULTS.lpGlyphs are specific to the current font in the device context and should only be used
		///         to draw text in the device context while that font remains selected.
		///     </para>
		///     <para>
		///         When computing justification, if the trailing characters in the string are spaces, the function reduces the length of the string and removes
		///         the spaces prior to computing the justification. If the array consists of only spaces, the function returns an error.
		///     </para>
		///     <para>
		///         <see cref="ExtTextOut" /> expects an <see cref="GCP_RESULTS.lpDX" /> entry for each byte of a DBCS string, whereas
		///         <see cref="GetCharacterPlacement" />
		///         assigns an <see cref="GCP_RESULTS.lpDX" /> entry for each glyph. To correct this mismatch when using this combination of functions, either
		///         use <see cref="GetGlyphIndices" /> or expand the <see cref="GCP_RESULTS.lpDX" /> array with zero-width entries for the corresponding second
		///         byte of a DBCS byte pair.
		///     </para>
		///     <para>
		///         If the logical width is less than the width of the leading character in the input string, GCP_RESULTS.nMaxFit returns a bad value. For this
		///         case, call <see cref="GetCharacterPlacement" /> for glyph indexes and the <see cref="GCP_RESULTS.lpDX" /> array. Then use the
		///         <see cref="GCP_RESULTS.lpDX" /> array to do the extent calculation using the advance width of each character, where
		///         <see cref="GCP_RESULTS.nMaxFit" /> is the number of characters whose glyph indexes advance width is less than the width of the leading
		///         character.
		///     </para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "GetCharacterPlacement")]
		public static extern uint GetCharacterPlacement(
			[In] IntPtr hdc, [In] string lpString, int nCount, int nMaxExtent, ref GCP_RESULTS lpResults, uint dwFlags);

		/// <summary>
		///     The <see cref="GetCharABCWidthsFloat" /> function retrieves the widths, in logical units, of consecutive characters in a specified range from the
		///     current font.
		/// </summary>
		/// <param name="hdc">Handle to the device context.</param>
		/// <param name="iFirstChar">Specifies the code point of the first character in the group of consecutive characters where the ABC widths are sought.</param>
		/// <param name="iLastChar">
		///     Specifies the code point of the last character in the group of consecutive characters where the ABC widths are sought. This range is inclusive.
		///     An error is returned if the specified last character precedes the specified first character.
		/// </param>
		/// <param name="lpABCF">
		///     Pointer to an array of <see cref="ABCFLOAT" /> structures that receives the character widths, in logical units.
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         Unlike the <see cref="GetCharABCWidths" /> function that returns widths only for TrueType fonts, the <see cref="GetCharABCWidthsFloat" />
		///         function retrieves widths for any font. The widths returned by this function are in the IEEE floating-point format.
		///     </para>
		///     <para>
		///         If the current world-to-device transformation is not identified, the returned widths may be non-integer values, even if the corresponding
		///         values in the device space are integers.
		///     </para>
		///     <para>
		///         A spacing is the distance added to the current position before placing the glyph. B spacing is the width of the black part of the glyph. C
		///         spacing is the distance added to the current position to provide white space to the right of the glyph. The total advanced width is specified
		///         by A+B+C.
		///     </para>
		///     <para>The ABC spaces are measured along the character base line of the selected font.</para>
		///     <para>The ABC widths of the default character are used for characters outside the range of the currently selected font.</para>
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "GetCharABCWidthsFloat")]
		public static extern bool GetCharABCWidthsFloat(IntPtr hdc, uint iFirstChar, uint iLastChar, [Out] ABCFloat[] lpABCF);

		/// <summary>
		///     The <see cref="GetAspectRatioFilterEx" /> function retrieves the setting for the current aspect-ratio filter.
		/// </summary>
		/// <param name="hdc">Handle to a device context.</param>
		/// <param name="lpAspectRatio">
		///     Pointer to a <see cref="SIZE" /> structure that receives the current aspect-ratio filter.
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     <para>The aspect ratio is the ratio formed by the width and height of a pixel on a specified device.</para>
		///     <para>
		///         The system provides a special filter, the aspect-ratio filter, to select fonts that were designed for a particular device. An application can
		///         specify that the system should only retrieve fonts matching the specified aspect ratio by calling the <see cref="SetMapperFlags" /> function.
		///     </para>
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "GetAspectRatioFilterEx")]
		public static extern bool GetAspectRatioFilterEx([In] IntPtr hdc, [Out] out SIZE lpAspectRatio);

		/// <summary>
		///     The <see cref="CreateCompatibleBitmap" /> function creates a bitmap compatible with the device that is associated with the specified device
		///     context.
		/// </summary>
		/// <param name="hdc">A handle to a device context.</param>
		/// <param name="nWidth">The bitmap width, in pixels.</param>
		/// <param name="nHeight">The bitmap height, in pixels.</param>
		/// <returns>
		///     <para>If the function succeeds, the return value is a handle to the compatible bitmap (DDB).</para>
		///     <para>If the function fails, the return value is NULL.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         The color format of the bitmap created by the <see cref="CreateCompatibleBitmap" /> function matches the color format of the device
		///         identified by the <paramref name="hdc" /> parameter. This bitmap can be selected into any memory device context that is compatible with the
		///         original device.
		///     </para>
		///     <para>
		///         Because memory device contexts allow both color and monochrome bitmaps, the format of the bitmap returned by the
		///         <see cref="CreateCompatibleBitmap" /> function differs when the specified device context is a memory device context. However, a compatible
		///         bitmap that was created for a nonmemory device context always possesses the same color format and uses the same color palette as the
		///         specified device context.
		///     </para>
		///     <para>
		///         Note: When a memory device context is created, it initially has a 1-by-1 monochrome bitmap selected into it. If this memory device context is
		///         used in <see cref="CreateCompatibleBitmap" />, the bitmap that is created is a monochrome bitmap. To create a color bitmap, use the HDC that
		///         was used to create the memory device context, as shown in the following code:
		///     </para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "CreateCompatibleBitmap")]
		public static extern IntPtr CreateCompatibleBitmap([In] IntPtr hdc, int nWidth, int nHeight);

		/// <summary>
		///     The <see cref="SetTextCharacterExtra" /> function sets the intercharacter spacing. Intercharacter spacing is added to each character, including
		///     break characters, when the system writes a line of text.
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <param name="nCharExtra">
		///     The amount of extra space, in logical units, to be added to each character. If the current mapping mode is not MM_TEXT, the
		///     <paramref name="nCharExtra" /> parameter is transformed and rounded to the nearest pixel.
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is the previous intercharacter spacing.</para>
		///     <para>If the function fails, the return value is 0x80000000.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         This function is supported mainly for compatibility with existing applications. New applications should generally avoid calling this
		///         function, because it is incompatible with complex scripts (scripts that require text shaping; Arabic script is an example of this).
		///     </para>
		///     <para>
		///         The recommended approach is that instead of calling this function and then <see cref="TextOut" />, applications should call
		///         <see cref="ExtTextOut" /> and use its lpDx parameter to supply widths.
		///     </para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "SetTextCharacterExtra")]
		public static extern int SetTextCharacterExtra([In] IntPtr hdc, int nCharExtra);

		/// <summary>
		///     The <see cref="RemoveFontResourceEx" /> function removes the fonts in the specified file from the system font table.
		/// </summary>
		/// <param name="lpFileName">A pointer to a null-terminated string that names a font resource file.</param>
		/// <param name="fl">
		///     The characteristics of the font to be removed from the system. In order for the font to be removed, the flags used must be the same as when the
		///     font was added with the <see cref="AddFontResourceEx" /> function. See the <see cref="AddFontResourceEx" /> function for more information.
		/// </param>
		/// <param name="pdv">Reserved. Must be zero.</param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero. No extended error information is available.</para>
		/// </returns>
		/// <remarks>
		///     This function will only remove the font if the flags specified are the same as when then font was added with the <see cref="AddFontResourceEx" />
		///     function.
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "RemoveFontResourceEx")]
		public static extern bool RemoveFontResourceEx([In] string lpFileName, uint fl, IntPtr pdv);

		/// <summary>
		///     The <see cref="PlayEnhMetaFileRecord" /> function plays an enhanced-metafile record by executing the graphics device interface (GDI) functions
		///     identified by the record.
		/// </summary>
		/// <param name="hdc">
		///     A handle to the device context passed to the <see cref="EnumEnhMetaFile" /> function.
		/// </param>
		/// <param name="lpHandletable">
		///     A pointer to a table of handles to GDI objects used when playing the metafile. The first entry in this table contains the
		///     enhanced-metafile handle.
		/// </param>
		/// <param name="lpEnhMetaRecord">A pointer to the enhanced-metafile record to be played.</param>
		/// <param name="nHandles">The number of handles in the handle table.</param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     <para>This is an enhanced-metafile function.</para>
		///     <para>
		///         An application typically uses <see cref="PlayEnhMetaFileRecord" /> in conjunction with the <see cref="EnumEnhMetaFile" /> function to process
		///         and play an enhanced-format metafile one record at a time.
		///     </para>
		///     <para>
		///         The <paramref name="hdc" />, <paramref name="lpHandletable" />, and <paramref name="nHandles" /> parameters must be exactly those passed to
		///         the <see cref="EnhMetaFileProc" /> callback procedure by the <see cref="EnumEnhMetaFile" /> function.
		///     </para>
		///     <para>
		///         If <see cref="PlayEnhMetaFileRecord" /> does not recognize a record, it ignores the record and returns TRUE.
		///     </para>
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "PlayEnhMetaFileRecord")]
		public static extern bool PlayEnhMetaFileRecord(
			[In] IntPtr hdc, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 3)] HANDLETABLE[] lpHandletable,
			[In] ref ENHMETARECORD lpEnhMetaRecord,
			uint nHandles);

		/// <summary>
		///     The <see cref="GetTextExtentPoint32" /> function computes the width and height of the specified string of text.
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <param name="lpString">
		///     A pointer to a buffer that specifies the text string. The string does not need to be null-terminated, because the <paramref name="c" /> parameter
		///     specifies the length of the string.
		/// </param>
		/// <param name="c">
		///     The length of the string pointed to by <paramref name="lpString" />.
		/// </param>
		/// <param name="lpSize">
		///     A pointer to a <see cref="SIZE" /> structure that receives the dimensions of the string, in logical units.
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         The <see cref="GetTextExtentPoint32" /> function uses the currently selected font to compute the dimensions of the string. The width and
		///         height, in logical units, are computed without considering any clipping.
		///     </para>
		///     <para>Because some devices kern characters, the sum of the extents of the characters in a string may not be equal to the extent of the string.</para>
		///     <para>
		///         The calculated string width takes into account the intercharacter spacing set by the <see cref="SetTextCharacterExtra" /> function and the
		///         justification set by <see cref="SetTextJustification" />. This is true for both displaying on a screen and for printing. However, if lpDx is
		///         set in <see cref="ExtTextOut" />, <see cref="GetTextExtentPoint32" /> does not take into account either intercharacter spacing or
		///         justification. In addition, for EMF, the print result always takes both intercharacter spacing and justification into account.
		///     </para>
		///     <para>
		///         When dealing with text displayed on a screen, the calculated string width takes into account the intercharacter spacing set by the
		///         <see cref="SetTextCharacterExtra" /> function and the justification set by <see cref="SetTextJustification" />. However, if lpDx is set in
		///         <see cref="ExtTextOut" />, <see cref="GetTextExtentPoint32" /> does not take into account either intercharacter spacing or justification.
		///         However, when printing with EMF:
		///     </para>
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "GetTextExtentPoint32")]
		public static extern bool GetTextExtentPoint32([In] IntPtr hdc, [In] string lpString, int c, [Out] out SIZE lpSize);

		/// <summary>
		///     The <see cref="GetTextExtentExPoint" /> function retrieves the number of characters in a specified string that will fit within a specified space
		///     and fills an array with the text extent for each of those characters. (A text extent is the distance between the beginning of the space and a
		///     character that will fit in the space.) This information is useful for word-wrapping calculations.
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <param name="lpszStr">A pointer to the null-terminated string for which extents are to be retrieved.</param>
		/// <param name="cchString">
		///     The number of characters in the string pointed to by the <paramref name="lpszStr" /> parameter. For an ANSI call it specifies the string length
		///     in bytes and for a Unicode it specifies the string length in WORDs. Note that for the ANSI function, characters in SBCS code pages take one byte
		///     each, while most characters in DBCS code pages take two bytes; for the Unicode function, most currently defined Unicode characters (those in the
		///     Basic Multilingual Plane (BMP)) are one WORD while Unicode surrogates are two WORDs.
		/// </param>
		/// <param name="nMaxExtent">The maximum allowable width, in logical units, of the formatted string.</param>
		/// <param name="lpnFit">
		///     A pointer to an integer that receives a count of the maximum number of characters that will fit in the space specified by the
		///     <paramref name="nMaxExtent" /> parameter. When the <paramref name="lpnFit" /> parameter is NULL, the <paramref name="nMaxExtent" /> parameter is
		///     ignored.
		/// </param>
		/// <param name="alpDx">
		///     <para>
		///         A pointer to an array of integers that receives partial string extents. Each element in the array gives the distance, in logical units,
		///         between the beginning of the string and one of the characters that fits in the space specified by the <paramref name="nMaxExtent" />
		///         parameter. This array must have at least as many elements as characters specified by the <paramref name="cchString" /> parameter because the
		///         entire array is used internally. The function fills the array with valid extents for as many characters as are specified by the
		///         <paramref name="lpnFit" /> parameter. Any values in the rest of the array should be ignored. If <paramref name="alpDx" /> is NULL, the
		///         function does not compute partial string widths.
		///     </para>
		///     <para>
		///         For complex scripts, where a sequence of characters may be represented by any number of glyphs, the values in the <paramref name="alpDx" />
		///         array up to the number specified by the <paramref name="lpnFit" /> parameter match one-to-one with code points. Again, you should ignore the
		///         rest of the values in the <paramref name="alpDx" /> array.
		///     </para>
		/// </param>
		/// <param name="lpSize">
		///     A pointer to a <see cref="SIZE" /> structure that receives the dimensions of the string, in logical units. This parameter cannot be NULL.
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         If both the <paramref name="lpnFit" /> and <paramref name="alpDx" /> parameters are NULL, calling the <see cref="GetTextExtentExPoint" />
		///         function is equivalent to calling the <see cref="GetTextExtentPoint" /> function.
		///     </para>
		///     <para>
		///         For the ANSI version of <see cref="GetTextExtentExPoint" />, the <paramref name="alpDx" /> array has the same number of INT values as there
		///         are bytes in <paramref name="lpszStr" />. The INT values that correspond to the two bytes of a DBCS character are each the extent of the
		///         entire composite character.
		///     </para>
		///     <para>
		///         Note, the <paramref name="alpDx" /> values for <see cref="GetTextExtentExPoint" /> are not the same as the lpDx values for
		///         <see cref="ExtTextOut" />. To use the <paramref name="alpDx" /> values in <paramref name="alpDx" />, you must first process them.
		///     </para>
		///     <para>
		///         When this function returns the text extent, it assumes that the text is horizontal, that is, that the escapement is always 0. This is true
		///         for both the horizontal and vertical measurements of the text. Even if you use a font that specifies a nonzero escapement, this function
		///         doesn't use the angle while it computes the text extent. The app must convert it explicitly. However, when the graphics mode is set to
		///         GM_ADVANCED and the character orientation is 90 degrees from the print orientation, the values that this function return do not follow this
		///         rule. When the character orientation and the print orientation match for a given string, this function returns the dimensions of the string
		///         in the <see cref="SIZE" /> structure as { cx : 116, cy : 18 }.  When the character orientation and the print orientation are 90 degrees apart
		///         for the same string, this function returns the dimensions of the string in the <see cref="SIZE" /> structure as { cx : 18, cy : 116 }.
		///     </para>
		///     <para>
		///         This function returns the extent of each successive character in a string. When these are rounded to logical units, you get different results
		///         than what is returned from the <see cref="GetCharWidth" />, which returns the width of each individual character rounded to logical units.
		///     </para>
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "GetTextExtentExPoint")]
		public static extern bool GetTextExtentExPoint(
			[In] IntPtr hdc, [In] string lpszStr, int cchString, int nMaxExtent, IntPtr lpnFit, IntPtr alpDx, [Out] out SIZE lpSize);

		/// <summary>
		///     The <see cref="GetTextExtentExPointI" /> function retrieves the number of characters in a specified string that will fit within a specified space
		///     and fills an array with the text extent for each of those characters. (A text extent is the distance between the beginning of the space and a
		///     character that will fit in the space.) This information is useful for word-wrapping calculations.
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <param name="pgiIn">A pointer to an array of glyph indices for which extents are to be retrieved.</param>
		/// <param name="cgi">
		///     The number of glyphs in the array pointed to by the <paramref name="pgiIn" /> parameter.
		/// </param>
		/// <param name="nMaxExtent">The maximum allowable width, in logical units, of the formatted string.</param>
		/// <param name="lpnFit">
		///     A pointer to an integer that receives a count of the maximum number of characters that will fit in the space specified by the
		///     <paramref name="nMaxExtent" /> parameter. When the <paramref name="lpnFit" /> parameter is NULL, the <paramref name="nMaxExtent" /> parameter is
		///     ignored.
		/// </param>
		/// <param name="alpDx">
		///     A pointer to an array of integers that receives partial glyph extents. Each element in the array gives the distance, in logical units, between
		///     the beginning of the glyph indices array and one of the glyphs that fits in the space specified by the <paramref name="nMaxExtent" /> parameter.
		///     Although this array should have at least as many elements as glyph indices specified by the <paramref name="cgi" /> parameter, the function fills
		///     the array with extents only for as many glyph indices as are specified by the <paramref name="lpnFit" /> parameter. If <paramref name="lpnFit" />
		///     is NULL, the function does not compute partial string widths.
		/// </param>
		/// <param name="lpSize">
		///     A pointer to a <see cref="SIZE" /> structure that receives the dimensions of the glyph indices array, in logical units. This value cannot be
		///     NULL.
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         If both the <paramref name="lpnFit" /> and <paramref name="alpDx" /> parameters are NULL, calling the <see cref="GetTextExtentExPointI" />
		///         function is equivalent to calling the <see cref="GetTextExtentPointI" /> function.
		///     </para>
		///     <para>
		///         When this function returns the text extent, it assumes that the text is horizontal, that is, that the escapement is always 0. This is true
		///         for both the horizontal and vertical measurements of the text. Even if you use a font that specifies a nonzero escapement, this function
		///         doesn't use the angle while it computes the text extent. The app must convert it explicitly. However, when the graphics mode is set to
		///         GM_ADVANCED and the character orientation is 90 degrees from the print orientation, the values that this function return do not follow this
		///         rule. When the character orientation and the print orientation match for a given string, this function returns the dimensions of the string
		///         in the <see cref="SIZE" /> structure as { cx : 116, cy : 18 }.  When the character orientation and the print orientation are 90 degrees apart
		///         for the same string, this function returns the dimensions of the string in the <see cref="SIZE" /> structure as { cx : 18, cy : 116 }.
		///     </para>
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "GetTextExtentExPointI")]
		public static extern bool GetTextExtentExPointI(
			[In] IntPtr hdc, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U2, SizeParamIndex = 2)] ushort[] pgiIn, int cgi, int nMaxExtent,
			IntPtr lpnFit, IntPtr alpDx, [Out] out SIZE lpSize);

		/// <summary>
		///     The <see cref="GetTextCharacterExtra" /> function retrieves the current intercharacter spacing for the specified device context.
		/// </summary>
		/// <param name="hdc">Handle to the device context.</param>
		/// <returns>
		///     <para>If the function succeeds, the return value is the current intercharacter spacing, in logical coordinates.</para>
		///     <para>If the function fails, the return value is 0x8000000.</para>
		/// </returns>
		/// <remarks>
		///     The intercharacter spacing defines the extra space, in logical units along the base line, that the <see cref="TextOut" /> or
		///     <see cref="ExtTextOut" /> functions add to each character as a line is written. The spacing is used to expand lines of text.
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "GetTextCharacterExtra")]
		public static extern int GetTextCharacterExtra([In] IntPtr hdc);

		/// <summary>
		///     The <see cref="CreateRectRgnIndirect" /> function creates a rectangular region.
		/// </summary>
		/// <param name="lprc">
		///     Pointer to a <see cref="RECT" /> structure that contains the coordinates of the upper-left and lower-right corners of the rectangle that defines
		///     the region in logical units.
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is the handle to the region.</para>
		///     <para>If the function fails, the return value is NULL.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         When you no longer need the HRGN object, call the <see cref="DeleteObject" /> function to delete it.
		///     </para>
		///     <para>Region coordinates are represented as 27-bit signed integers.</para>
		///     <para>The region will be exclusive of the bottom and right edges.</para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "CreateRectRgnIndirect")]
		public static extern IntPtr CreateRectRgnIndirect([In] ref RECT lprc);

		/// <summary>
		///     The <see cref="CreateHalftonePalette" /> function creates a halftone palette for the specified device context (DC).
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <returns>
		///     <para>If the function succeeds, the return value is a handle to a logical halftone palette.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         An application should create a halftone palette when the stretching mode of a device context is set to HALFTONE. The logical halftone palette
		///         returned by <see cref="CreateHalftonePalette" /> should then be selected and realized into the device context before the
		///         <see cref="StretchBlt" /> or <see cref="StretchDIBits" /> function is called.
		///     </para>
		///     <para>
		///         When you no longer need the palette, call the <see cref="DeleteObject" /> function to delete it.
		///     </para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "CreateHalftonePalette")]
		public static extern IntPtr CreateHalftonePalette([In] IntPtr hdc);

		/// <summary>
		///     The <see cref="CreateFontIndirectEx" /> function specifies a logical font that has the characteristics in the specified structure. The font can
		///     subsequently be selected as the current font for any device context.
		/// </summary>
		/// <param name="penumlfex">
		///     <para>
		///         Pointer to an <see cref="ENUMLOGFONTEXDV" /> structure that defines the characteristics of a multiple master font.
		///     </para>
		///     <para>
		///         Note, this function ignores the <see cref="ENUMLOGFONTEXDV.elfDesignVector" /> member in <see cref="ENUMLOGFONTEXDV" />.
		///     </para>
		/// </param>
		/// <returns>
		///     <para>
		///         If the function succeeds, the return value is the handle to the new <see cref="ENUMLOGFONTEXDV" /> structure.
		///     </para>
		///     <para>If the function fails, the return value is zero. No extended error information is available.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         The <see cref="CreateFontIndirectEx" /> function creates a logical font with the characteristics specified in the
		///         <see cref="ENUMLOGFONTEXDV" /> structure. When this font is selected by using the <see cref="SelectObject" /> function, GDI's font mapper
		///         attempts to match the logical font with an existing physical font. If it fails to find an exact match, it provides an alternative whose
		///         characteristics match as many of the requested characteristics as possible.
		///     </para>
		///     <para>
		///         When you no longer need the font, call the <see cref="DeleteObject" /> function to delete it.
		///     </para>
		///     <para>
		///         The font mapper for <see cref="CreateFont" />, <see cref="CreateFontIndirect" />, and <see cref="CreateFontIndirectEx" /> recognizes both the
		///         English and the localized typeface name, regardless of locale.
		///     </para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "CreateFontIndirectEx")]
		public static extern IntPtr CreateFontIndirectEx([In] ref ENUMLOGFONTEXDV penumlfex);

		/// <summary>
		///     <para>
		///         The <see cref="CreateDIBPatternBrush" /> function creates a logical brush that has the pattern specified by the specified device-independent
		///         bitmap (DIB). The brush can subsequently be selected into any device context that is associated with a device that supports raster
		///         operations.
		///     </para>
		///     <para></para>
		///     <para>
		///         This function is provided only for compatibility with 16-bit versions of Windows. Applications should use the
		///         <see cref="CreateDIBPatternBrushPt" /> function.
		///     </para>
		/// </summary>
		/// <param name="hglbDIBPacked">
		///     A handle to a global memory object containing a packed DIB, which consists of a <see cref="BITMAPINFO" /> structure immediately followed by an
		///     array of bytes defining the pixels of the bitmap.
		/// </param>
		/// <param name="fuColorSpec">
		///     <para>
		///         Specifies whether the <see cref="BITMAPINFO.bmiColors" /> member of the <see cref="BITMAPINFO" /> structure is initialized and, if so,
		///         whether this member contains explicit red, green, blue (RGB) values or indexes into a logical palette. The <paramref name="fuColorSpec" />
		///         parameter must be one of the following values.
		///     </para>
		///     <list type="table">
		///         <item>
		///             <term>DIB_PAL_COLORS</term>
		///             <description>
		///                 A color table is provided and consists of an array of 16-bit indexes into the logical palette of the device context into which the
		///                 brush is to be selected.
		///             </description>
		///         </item>
		///         <item>
		///             <term>DIB_RGB_COLORS</term>
		///             <description>A color table is provided and contains literal RGB values.</description>
		///         </item>
		///     </list>
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value identifies a logical brush.</para>
		///     <para>If the function fails, the return value is NULL.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         When an application selects a two-color DIB pattern brush into a monochrome device context, the system does not acknowledge the colors
		///         specified in the DIB; instead, it displays the pattern brush using the current background and foreground colors of the device context. Pixels
		///         mapped to the first color of the DIB (offset 0 in the DIB color table) are displayed using the foreground color; pixels mapped to the second
		///         color (offset 1 in the color table) are displayed using the background color.
		///     </para>
		///     <para>
		///         When you no longer need the brush, call the <see cref="DeleteObject" /> function to delete it.
		///     </para>
		///     <para>
		///         ICM: No color is done at brush creation. However, color management is performed when the brush is selected into an ICM-enabled device
		///         context.
		///     </para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "CreateDIBPatternBrush")]
		public static extern IntPtr CreateDIBPatternBrush([In] IntPtr hglbDIBPacked, uint fuColorSpec);

		/// <summary>Translates character set information and sets all members of a destination structure to appropriate values.</summary>
		/// <param name="lpSrc">
		///     Pointer to the <see cref="FONTSIGNATURE.fsCsb" /> member of a <see cref="FONTSIGNATURE" /> structure if <paramref name="dwFlags" /> is set to
		///     TCI_SRCFONTSIG. Otherwise, this parameter is set to a DWORD value indicating the source.
		/// </param>
		/// <param name="lpCs">
		///     Pointer to a <see cref="CHARSETINFO" /> structure that receives the translated character set information.
		/// </param>
		/// <param name="dwFlags">
		///     <para>Flags specifying how to perform the translation. This parameter can be one of the following values.</para>
		///     <list type="table">
		///         <item>
		///             <term>TCI_SRCCHARSET</term>
		///             <description>Source contains the character set value in the low word, and 0 in the high word.</description>
		///         </item>
		///         <item>
		///             <term>TCI_SRCCODEPAGE</term>
		///             <description>Source is a code page identifier in the low word and 0 in the high word.</description>
		///         </item>
		///         <item>
		///             <term>TCI_SRCFONTSIG</term>
		///             <description>
		///                 <para>
		///                     Source is the code page bitfield portion of a <see cref="FONTSIGNATURE" /> structure. On input this should have only one Windows
		///                     code-page bit set, either for an ANSI code page value or for a common ANSI and OEM value (for OEM values, bits 32-63 must be
		///                     clear). On output, this has only one bit set.
		///                 </para>
		///                 <para>
		///                     If the TCI_SRCFONTSIG value is given, the <paramref name="lpSrc" /> parameter must be the address of the code-page bitfield. If
		///                     any other TCI_ value is given, the <paramref name="lpSrc" /> parameter must be a value not an address.
		///                 </para>
		///             </description>
		///         </item>
		///         <item>
		///             <term>TCI_SRCLOCALE</term>
		///             <description>
		///                 Windows 2000: Source is the locale identifier (LCID) or language identifier of the keyboard layout. If it is a language identifier,
		///                 the value is in the low word.
		///             </description>
		///         </item>
		///     </list>
		/// </param>
		/// <returns>Returns a nonzero value if successful, or 0 otherwise. To get extended error information, the application can call GetLastError.</returns>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "TranslateCharsetInfo")]
		public static extern bool TranslateCharsetInfo(ref uint lpSrc, [Out] out CHARSETINFO lpCs, uint dwFlags);

		/// <summary>
		///     The <see cref="SetTextJustification" /> function specifies the amount of space the system should add to the break characters in a string of text.
		///     The space is added when an application calls the <see cref="TextOut" /> or <see cref="ExtTextOut" /> functions.
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <param name="nBreakExtra">
		///     The total extra space, in logical units, to be added to the line of text. If the current mapping mode is not MM_TEXT, the value identified by the
		///     <paramref name="nBreakExtra" /> parameter is transformed and rounded to the nearest pixel.
		/// </param>
		/// <param name="nBreakCount">The number of break characters in the line.</param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         The break character is usually the space character (ASCII 32), but it may be defined by a font as some other character. The
		///         <see cref="GetTextMetrics" /> function can be used to retrieve a font's break character.
		///     </para>
		///     <para>
		///         The <see cref="TextOut" /> function distributes the specified extra space evenly among the break characters in the line.
		///     </para>
		///     <para>
		///         The <see cref="GetTextExtentPoint32" /> function is always used with the <see cref="SetTextJustification" /> function. Sometimes the
		///         <see cref="GetTextExtentPoint32" /> function takes justification into account when computing the width of a specified line before
		///         justification, and sometimes it does not. For more details on this, see <see cref="GetTextExtentPoint32" />. This width must be known before
		///         an appropriate <paramref name="nBreakExtra" /> value can be computed.
		///     </para>
		///     <para>
		///         <see cref="SetTextJustification" /> can be used to justify a line that contains multiple strings in different fonts. In this case, each
		///         string must be justified separately.
		///     </para>
		///     <para>
		///         Because rounding errors can occur during justification, the system keeps a running error term that defines the current error value. When
		///         justifying a line that contains multiple runs, <see cref="GetTextExtentPoint" /> automatically uses this error term when it computes the
		///         extent of the next run, allowing <see cref="TextOut" /> to blend the error into the new run. After each line has been justified, this error
		///         term must be cleared to prevent it from being incorporated into the next line. The term can be cleared by calling
		///         <see cref="SetTextJustification" /> with <paramref name="nBreakExtra" /> set to zero.
		///     </para>
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "SetTextJustification")]
		public static extern bool SetTextJustification([In] IntPtr hdc, int nBreakExtra, int nBreakCount);

		/// <summary>
		///     The <see cref="SetBitmapDimensionEx" /> function assigns preferred dimensions to a bitmap. These dimensions can be used by applications; however,
		///     they are not used by the system.
		/// </summary>
		/// <param name="hBitmap">A handle to the bitmap. The bitmap cannot be a DIB-section bitmap.</param>
		/// <param name="nWidth">The width, in 0.1-millimeter units, of the bitmap.</param>
		/// <param name="nHeight">The height, in 0.1-millimeter units, of the bitmap.</param>
		/// <param name="lpSize">
		///     A pointer to a <see cref="SIZE" /> structure to receive the previous dimensions of the bitmap. This pointer can be NULL.
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         An application can retrieve the dimensions assigned to a bitmap with the <see cref="SetBitmapDimensionEx" /> function by calling the
		///         <see cref="GetBitmapDimensionEx" /> function.
		///     </para>
		///     <para>
		///         The bitmap identified by <paramref name="hBitmap" /> cannot be a DIB section, which is a bitmap created by the
		///         <see cref="CreateDIBSection" /> function. If the bitmap is a DIB section, the <see cref="SetBitmapDimensionEx" /> function fails.
		///     </para>
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "SetBitmapDimensionEx")]
		public static extern bool SetBitmapDimensionEx([In] IntPtr hBitmap, int nWidth, int nHeight, IntPtr lpSize);

		/// <summary>
		///     The <see cref="ModifyWorldTransform" /> function changes the world transformation for a device context using the specified mode.
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <param name="lpXform">
		///     A pointer to an <see cref="XFORM" /> structure used to modify the world transformation for the given device context.
		/// </param>
		/// <param name="iMode">
		///     <para>Specifies how the transformation data modifies the current world transformation. This parameter must be one of the following values.</para>
		///     <list type="table">
		///         <item>
		///             <term>MWT_IDENTITY</term>
		///             <description>
		///                 Resets the current world transformation by using the identity matrix. If this mode is specified, the <see cref="XFORM" /> structure
		///                 pointed to by <paramref name="lpXform" /> is ignored.
		///             </description>
		///         </item>
		///         <item>
		///             <term>MWT_LEFTMULTIPLY</term>
		///             <description>
		///                 Multiplies the current transformation by the data in the <see cref="XFORM" /> structure. (The data in the <see cref="XFORM" />
		///                 structure becomes the left multiplicand, and the data for the current transformation becomes the right multiplicand.)
		///             </description>
		///         </item>
		///         <item>
		///             <term>MWT_RIGHTMULTIPLY</term>
		///             <description>
		///                 Multiplies the current transformation by the data in the <see cref="XFORM" /> structure. (The data in the <see cref="XFORM" />
		///                 structure becomes the right multiplicand, and the data for the current transformation becomes the left multiplicand.)
		///             </description>
		///         </item>
		///     </list>
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     The <see cref="ModifyWorldTransform" /> function will fail unless graphics mode for the specified device context has been set to GM_ADVANCED by
		///     previously calling the <see cref="SetGraphicsMode" /> function. Likewise, it will not be possible to reset the graphics mode for the device
		///     context to the default GM_COMPATIBLE mode, unless world transform has first been reset to the default identity transform by calling
		///     <see cref="SetWorldTransform" /> or <see cref="ModifyWorldTransform" />.
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "ModifyWorldTransform")]
		public static extern bool ModifyWorldTransform([In] IntPtr hdc, [In] ref XFORM lpXform, uint iMode);

		/// <summary>
		///     The <see cref="GetFontUnicodeRanges" /> function returns information about which Unicode characters are supported by a font. The information is
		///     returned as a <see cref="GLYPHSET" /> structure.
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <param name="lpgs">
		///     A pointer to a <see cref="GLYPHSET" /> structure that receives the glyph set information. If this parameter is NULL, the function returns the
		///     size of the <see cref="GLYPHSET" /> structure required to store the information.
		/// </param>
		/// <returns>
		///     <para>
		///         If the function succeeds, it returns number of bytes written to the GLYPHSET structure or, if the <paramref name="lpgs" /> parameter is NULL,
		///         it returns the size of the GLYPHSET structure required to store the information.
		///     </para>
		///     <para>If the function fails, it returns zero. No extended error information is available.</para>
		/// </returns>
		[DllImport("gdi32.dll", EntryPoint = "GetFontUnicodeRanges")]
		public static extern uint GetFontUnicodeRanges([In] IntPtr hdc, IntPtr lpgs);

		/// <summary>
		///     The <see cref="GetEnhMetaFileHeader" /> function retrieves the record containing the header for the specified enhanced-format metafile.
		/// </summary>
		/// <param name="hemf">A handle to the enhanced metafile for which the header is to be retrieved.</param>
		/// <param name="cbBuffer">The size, in bytes, of the buffer to receive the data. Only this many bytes will be copied.</param>
		/// <param name="lpemh">
		///     A pointer to an <see cref="ENHMETAHEADER" /> structure that receives the header record. If this parameter is NULL, the function returns the size
		///     of the header record.
		/// </param>
		/// <returns>
		///     If the function succeeds and the structure pointer is NULL, the return value is the size of the record that contains the header; if the structure
		///     pointer is a valid pointer, the return value is the number of bytes copied. Otherwise, it is zero.
		/// </returns>
		/// <remarks>
		///     <para>
		///         An enhanced-metafile header contains such information as the metafile's size, in bytes; the dimensions of the picture stored in the metafile;
		///         the number of records stored in the metafile; the offset to the optional text description; the size of the optional palette, and the
		///         resolution of the device on which the picture was created.
		///     </para>
		///     <para>The record that contains the enhanced-metafile header is always the first record in the metafile.</para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "GetEnhMetaFileHeader")]
		public static extern uint GetEnhMetaFileHeader([In] IntPtr hemf, uint cbBuffer, ref ENHMETAHEADER lpemh);

		/// <summary>
		///     The <see cref="GetCurrentPositionEx" /> function retrieves the current position in logical coordinates.
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <param name="lpPoint">
		///     A pointer to a <see cref="POINT" /> structure that receives the logical coordinates of the current position.
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "GetCurrentPositionEx")]
		public static extern bool GetCurrentPositionEx([In] IntPtr hdc, [Out] out POINT lpPoint);

		/// <summary>
		///     The <see cref="GetBitmapDimensionEx" /> function retrieves the dimensions of a compatible bitmap. The retrieved dimensions must have been set by
		///     the <see cref="SetBitmapDimensionEx" /> function.
		/// </summary>
		/// <param name="hBitmap">A handle to a compatible bitmap (DDB).</param>
		/// <param name="lpDimension">
		///     A pointer to a <see cref="SIZE" /> structure to receive the bitmap dimensions. For more information, see Remarks.
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     The function returns a data structure that contains fields for the height and width of the bitmap, in .01-mm units. If those dimensions have not
		///     yet been set, the structure that is returned will have zeros in those fields.
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "GetBitmapDimensionEx")]
		public static extern bool GetBitmapDimensionEx([In] IntPtr hBitmap, [Out] out SIZE lpDimension);

		/// <summary>
		///     The <see cref="CreatePolyPolygonRgn" /> function creates a region consisting of a series of polygons. The polygons can overlap.
		/// </summary>
		/// <param name="lppt">
		///     A pointer to an array of <see cref="POINT" /> structures that define the vertices of the polygons in logical units. The polygons are specified
		///     consecutively. Each polygon is presumed closed and each vertex is specified only once.
		/// </param>
		/// <param name="lpPolyCounts">
		///     A pointer to an array of integers, each of which specifies the number of points in one of the polygons in the array pointed to by
		///     <paramref name="lppt" />.
		/// </param>
		/// <param name="nCount">
		///     The total number of integers in the array pointed to by <paramref name="lpPolyCounts" />.
		/// </param>
		/// <param name="fnPolyFillMode">
		///     <para>The fill mode used to determine which pixels are in the region. This parameter can be one of the following values.</para>
		///     <list type="table">
		///         <item>
		///             <term>ALTERNATE</term>
		///             <description>Selects alternate mode (fills area between odd-numbered and even-numbered polygon sides on each scan line).</description>
		///         </item>
		///         <item>
		///             <term>WINDING</term>
		///             <description>Selects winding mode (fills any region with a nonzero winding value).</description>
		///         </item>
		///     </list>
		///     <para>
		///         For more information about these modes, see the <see cref="SetPolyFillMode" /> function.
		///     </para>
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is the handle to the region.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         When you no longer need the HRGN object, call the <see cref="DeleteObject" /> function to delete it.
		///     </para>
		///     <para>Region coordinates are represented as 27-bit signed integers.</para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "CreatePolyPolygonRgn")]
		public static extern IntPtr CreatePolyPolygonRgn([In] ref POINT lppt, [In] ref int lpPolyCounts, int nCount, int fnPolyFillMode);

		/// <summary>
		///     The <see cref="CreateBitmapIndirect" /> function creates a bitmap with the specified width, height, and color format (color planes and
		///     bits-per-pixel).
		/// </summary>
		/// <param name="lpbm">
		///     A pointer to a <see cref="BITMAP" /> structure that contains information about the bitmap. If an application sets the
		///     <see cref="BITMAP.bmWidth" /> or <see cref="BITMAP.bmHeight" /> members to zero, <see cref="CreateBitmapIndirect" /> returns the handle to a
		///     1-by-1 pixel, monochrome bitmap.
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is a handle to the bitmap.</para>
		///     <para>If the function fails, the return value is NULL.</para>
		///     <para>This function can return the following values.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         The <see cref="CreateBitmapIndirect" /> function creates a device-dependent bitmap.
		///     </para>
		///     <para>
		///         After a bitmap is created, it can be selected into a device context by calling the <see cref="SelectObject" /> function. However, the bitmap
		///         can only be selected into a device context if the bitmap and the DC have the same format.
		///     </para>
		///     <para>
		///         While the <see cref="CreateBitmapIndirect" /> function can be used to create color bitmaps, for performance reasons applications should use
		///         <see cref="CreateBitmapIndirect" /> to create monochrome bitmaps and <see cref="CreateCompatibleBitmap" /> to create color bitmaps. Whenever
		///         a color bitmap from <see cref="CreateBitmapIndirect" /> is selected into a device context, the system must ensure that the bitmap matches the
		///         format of the device context it is being selected into. Because <see cref="CreateCompatibleBitmap" /> takes a device context, it returns a
		///         bitmap that has the same format as the specified device context. Thus, subsequent calls to <see cref="SelectObject" /> are faster with a
		///         color bitmap from <see cref="CreateCompatibleBitmap" /> than with a color bitmap returned from <see cref="CreateBitmapIndirect" />.
		///     </para>
		///     <para>
		///         If the bitmap is monochrome, zeros represent the foreground color and ones represent the background color for the destination device
		///         context.
		///     </para>
		///     <para>
		///         When you no longer need the bitmap, call the <see cref="DeleteObject" /> function to delete it.
		///     </para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "CreateBitmapIndirect")]
		public static extern IntPtr CreateBitmapIndirect([In] ref BITMAP lpbm);

		/// <summary>
		///     The <see cref="AddFontMemResourceEx" /> function adds the font resource from a memory image to the system.
		/// </summary>
		/// <param name="pbFont">A pointer to a font resource.</param>
		/// <param name="cbFont">
		///     The number of bytes in the font resource that is pointed to by <paramref name="pbFont" />.
		/// </param>
		/// <param name="pdv">Reserved. Must be 0.</param>
		/// <param name="pcFonts">A pointer to a variable that specifies the number of fonts installed.</param>
		/// <returns>
		///     If the function succeeds, the return value specifies the handle to the font added. This handle uniquely identifies the fonts that were installed
		///     on the system. If the function fails, the return value is zero. No extended error information is available.
		/// </returns>
		/// <remarks>
		///     <para>
		///         This function allows an application to get a font that is embedded in a document or a webpage. A font that is added by
		///         <see cref="AddFontMemResourceEx" /> is always private to the process that made the call and is not enumerable.
		///     </para>
		///     <para>
		///         A memory image can contain more than one font. When this function succeeds, <paramref name="pcFonts" /> is a pointer to a DWORD whose value
		///         is the number of fonts added to the system as a result of this call. For example, this number could be 2 for the vertical and horizontal
		///         faces of an Asian font.
		///     </para>
		///     <para>
		///         When the function succeeds, the caller of this function can free the memory pointed to by <paramref name="pbFont" /> because the system has
		///         made its own copy of the memory. To remove the fonts that were installed, call <see cref="RemoveFontMemResourceEx" />. However, when the
		///         process goes away, the system will unload the fonts even if the process did not call RemoveFontMemResource.
		///     </para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "AddFontMemResourceEx")]
		public static extern IntPtr AddFontMemResourceEx([In] IntPtr pbFont, uint cbFont, IntPtr pdv, [In] ref uint pcFonts);

		/// <summary>
		///     The <see cref="SetSystemPaletteUse" /> function allows an application to specify whether the system palette contains 2 or 20 static colors. The
		///     default system palette contains 20 static colors. (Static colors cannot be changed when an application realizes a logical palette.)
		/// </summary>
		/// <param name="hdc">A handle to the device context. This device context must refer to a device that supports color palettes.</param>
		/// <param name="uUsage">
		///     <para>The new use of the system palette. This parameter can be one of the following values.</para>
		///     <list type="table">
		///         <item>
		///             <term>SYSPAL_NOSTATIC</term>
		///             <description>The system palette contains two static colors (black and white).</description>
		///         </item>
		///         <item>
		///             <term>SYSPAL_NOSTATIC256</term>
		///             <description>The system palette contains no static colors.</description>
		///         </item>
		///         <item>
		///             <term>SYSPAL_STATIC</term>
		///             <description>The system palette contains static colors that will not change when an application realizes its logical palette.</description>
		///         </item>
		///     </list>
		/// </param>
		/// <returns>
		///     <para>
		///         If the function succeeds, the return value is the previous system palette. It can be either SYSPAL_NOSTATIC, SYSPAL_NOSTATIC256, or
		///         SYSPAL_STATIC.
		///     </para>
		///     <para>If the function fails, the return value is SYSPAL_ERROR.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         An application can determine whether a device supports palette operations by calling the <see cref="GetDeviceCaps" /> function and specifying
		///         the RASTERCAPS constant.
		///     </para>
		///     <para>
		///         When an application window moves to the foreground and the SYSPAL_NOSTATIC value is set, the application must call the
		///         <see cref="User32.GetSysColor" /> function to save the current system colors setting. It must also call <see cref="User32.SetSysColors" /> to
		///         set reasonable values using only black and white. When the application returns to the background or terminates, the previous system colors
		///         must be restored.
		///     </para>
		///     <para>If the function returns SYSPAL_ERROR, the specified device context is invalid or does not support color palettes.</para>
		///     <para>An application must call this function only when its window is maximized and has the input focus.</para>
		///     <para>
		///         If an application calls <see cref="SetSystemPaletteUse" /> with <paramref name="uUsage" /> set to SYSPAL_NOSTATIC, the system continues to
		///         set aside two entries in the system palette for pure white and pure black, respectively.
		///     </para>
		///     <para>
		///         After calling this function with <paramref name="uUsage" /> set to SYSPAL_NOSTATIC, an application must take the following steps:
		///     </para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "SetSystemPaletteUse")]
		public static extern uint SetSystemPaletteUse([In] IntPtr hdc, uint uUsage);

		/// <summary>
		///     <para>
		///         The <see cref="RemoveFontResource" /> function removes the fonts in the specified file from the system font table.
		///     </para>
		///     <para>
		///         If the font was added using the <see cref="AddFontResourceEx" /> function, you must use the <see cref="RemoveFontResourceEx" /> function.
		///     </para>
		/// </summary>
		/// <param name="lpFileName">A pointer to a null-terminated string that names a font resource file.</param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         An application that adds or removes fonts from the system font table should notify other windows of the change by sending a
		///         <see cref="WM.WM_FONTCHANGE" /> message to all top-level windows in the system. The application sends this message by calling the
		///         <see cref="User32.SendMessage" /> function with the hwnd parameter set to HWND_BROADCAST.
		///     </para>
		///     <para>If there are outstanding references to a font, the associated resource remains loaded until no device context is using it.</para>
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "RemoveFontResource")]
		public static extern bool RemoveFontResource([In] string lpFileName);

		/// <summary>
		///     The <see cref="OffsetViewportOrgEx" /> function modifies the viewport origin for a device context using the specified horizontal and vertical
		///     offsets.
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <param name="nXOffset">The horizontal offset, in device units.</param>
		/// <param name="nYOffset">The vertical offset, in device units.</param>
		/// <param name="lpPoint">
		///     A pointer to a <see cref="POINT" /> structure. The previous viewport origin, in device units, is placed in this structure. If
		///     <paramref name="lpPoint" /> is NULL, the previous viewport origin is not returned.
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>The new origin is the sum of the current origin and the horizontal and vertical offsets.</remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "OffsetViewportOrgEx")]
		public static extern bool OffsetViewportOrgEx([In] IntPtr hdc, int nXOffset, int nYOffset, IntPtr lpPoint);

		/// <summary>
		///     <para>
		///         The <see cref="GetTextExtentPoint" /> function computes the width and height of the specified string of text.
		///     </para>
		///     <para></para>
		///     <para>
		///         Note:  This function is provided only for compatibility with 16-bit versions of Windows. Applications should call the
		///         <see cref="GetTextExtentPoint32" /> function, which provides more accurate results.
		///     </para>
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <param name="lpString">
		///     A pointer to the string that specifies the text. The string does not need to be zero-terminated, since <paramref name="cbString" /> specifies the
		///     length of the string.
		/// </param>
		/// <param name="cbString">
		///     The length of the string pointed to by <paramref name="lpString" />.
		/// </param>
		/// <param name="lpSize">
		///     A pointer to a <see cref="SIZE" /> structure that receives the dimensions of the string, in logical units.
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         The <see cref="GetTextExtentPoint" /> function uses the currently selected font to compute the dimensions of the string. The width and
		///         height, in logical units, are computed without considering any clipping. Also, this function assumes that the text is horizontal, that is,
		///         that the escapement is always 0. This is true for both the horizontal and vertical measurements of the text. Even if using a font specifying
		///         a nonzero escapement, this function will not use the angle while computing the text extent. The application must convert it explicitly.
		///     </para>
		///     <para>Because some devices kern characters, the sum of the extents of the characters in a string may not be equal to the extent of the string.</para>
		///     <para>
		///         The calculated string width takes into account the intercharacter spacing set by the <see cref="SetTextCharacterExtra" /> function.
		///     </para>
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "GetTextExtentPoint")]
		public static extern bool GetTextExtentPoint([In] IntPtr hdc, [In] string lpString, int cbString, [Out] out SIZE lpSize);

		/// <summary>
		///     The <see cref="GetTextExtentPointI" /> function computes the width and height of the specified array of glyph indices.
		/// </summary>
		/// <param name="hdc">Handle to the device context.</param>
		/// <param name="pgiIn">Pointer to array of glyph indices.</param>
		/// <param name="cgi">Specifies the number of glyph indices.</param>
		/// <param name="lpSize">
		///     Pointer to a <see cref="SIZE" /> structure that receives the dimensions of the string, in logical units.
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         The <see cref="GetTextExtentPointI" /> function uses the currently selected font to compute the dimensions of the array of glyph indices. The
		///         width and height, in logical units, are computed without considering any clipping.
		///     </para>
		///     <para>
		///         When this function returns the text extent, it assumes that the text is horizontal, that is, that the escapement is always 0. This is true
		///         for both the horizontal and vertical measurements of the text. Even if you use a font that specifies a nonzero escapement, this function
		///         doesn't use the angle while it computes the text extent. The app must convert it explicitly. However, when the graphics mode is set to
		///         GM_ADVANCED and the character orientation is 90 degrees from the print orientation, the values that this function return do not follow this
		///         rule. When the character orientation and the print orientation match for a given string, this function returns the dimensions of the string
		///         in the <see cref="SIZE" /> structure as { cx : 116, cy : 18 }.  When the character orientation and the print orientation are 90 degrees apart
		///         for the same string, this function returns the dimensions of the string in the <see cref="SIZE" /> structure as { cx : 18, cy : 116 }.
		///     </para>
		///     <para>
		///         Because some devices kern characters, the sum of the extents of the individual glyph indices may not be equal to the extent of the entire
		///         array of glyph indices.
		///     </para>
		///     <para>
		///         The calculated string width takes into account the intercharacter spacing set by the <see cref="SetTextCharacterExtra" /> function.
		///     </para>
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "GetTextExtentPointI")]
		public static extern bool GetTextExtentPointI(
			[In] IntPtr hdc, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U2, SizeParamIndex = 2)] ushort[] pgiIn, int cgi, [Out] out SIZE lpSize);

		/// <summary>
		///     The <see cref="GetSystemPaletteUse" /> function retrieves the current state of the system (physical) palette for the specified device context
		///     (DC).
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <returns>If the function succeeds, the return value is the current state of the system palette. This parameter can be one of the following values.</returns>
		/// <remarks>
		///     <para>
		///         By default, the system palette contains 20 static colors that are not changed when an application realizes its logical palette. An
		///         application can gain access to most of these colors by calling the <see cref="SetSystemPaletteUse" /> function.
		///     </para>
		///     <para>
		///         The device context identified by the <paramref name="hdc" /> parameter must represent a device that supports color palettes.
		///     </para>
		///     <para>
		///         An application can determine whether a device supports color palettes by calling the <see cref="GetDeviceCaps" /> function and specifying the
		///         RASTERCAPS constant.
		///     </para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "GetSystemPaletteUse")]
		public static extern uint GetSystemPaletteUse([In] IntPtr hdc);

		/// <summary>
		///     The <see cref="GetFontLanguageInfo" /> function returns information about the currently selected font for the specified display context.
		///     Applications typically use this information and the <see cref="GetCharacterPlacement" /> function to prepare a character string for display.
		/// </summary>
		/// <param name="hdc">Handle to a display device context.</param>
		/// <returns>
		///     The return value identifies characteristics of the currently selected font. The function returns 0 if the font is "normalized" and can be treated
		///     as a simple Latin font; it returns GCP_ERROR if an error occurs. Otherwise, the function returns a combination of the following values.
		/// </returns>
		[DllImport("gdi32.dll", EntryPoint = "GetFontLanguageInfo")]
		public static extern uint GetFontLanguageInfo([In] IntPtr hdc);

		/// <summary>
		///     The <see cref="EnumFontFamiliesEx" /> function enumerates all uniquely-named fonts in the system that match the font characteristics specified by
		///     the <see cref="LOGFONT" /> structure. <see cref="EnumFontFamiliesEx" /> enumerates fonts based on typeface name, character set, or both.
		/// </summary>
		/// <param name="hdc">A handle to the device context from which to enumerate the fonts.</param>
		/// <param name="lpLogfont">
		///     <para>
		///         A pointer to a <see cref="LOGFONT" /> structure that contains information about the fonts to enumerate. The function examines the following
		///         members.
		///     </para>
		///     <list type="table">
		///         <item>
		///             <term>lfCharSet</term>
		///             <description></description>
		///         </item>
		///         <item>
		///             <term>lfFaceName</term>
		///             <description></description>
		///         </item>
		///         <item>
		///             <term>lfPitchAndFamily</term>
		///             <description></description>
		///         </item>
		///     </list>
		/// </param>
		/// <param name="lpEnumFontFamExProc">
		///     A pointer to the application defined callback function. For more information, see the <see cref="EnumFontFamExProc" /> function.
		/// </param>
		/// <param name="lParam">An application defined value. The function passes this value to the callback function along with font information.</param>
		/// <param name="dwFlags">This parameter is not used and must be zero.</param>
		/// <returns>
		///     The return value is the last value returned by the callback function. This value depends on which font families are available for the specified
		///     device.
		/// </returns>
		/// <remarks>
		///     <para>
		///         The <see cref="EnumFontFamiliesEx" /> function does not use tagged typeface names to identify character sets. Instead, it always passes the
		///         correct typeface name and a separate character set value to the callback function. The function enumerates fonts based on the values of the
		///         <see cref="LOGFONT.lfCharSet" /> and <see cref="LOGFONT.lfFaceName" /> members in the <see cref="LOGFONT" /> structure.
		///     </para>
		///     <para>
		///         As with <see cref="EnumFontFamilies" />, <see cref="EnumFontFamiliesEx" /> enumerates all font styles. Not all styles of a font cover the
		///         same character sets. For example, Fontorama Bold might contain ANSI, Greek, and Cyrillic characters, but Fontorama Italic might contain only
		///         ANSI characters. For this reason, it's best not to assume that a specified font covers a specific character set, even if it is the ANSI
		///         character set. The following table shows the results of various combinations of values for <see cref="LOGFONT.lfCharSet" /> and
		///         <see cref="LOGFONT.lfFaceName" />.
		///     </para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "EnumFontFamiliesEx")]
		public static extern int EnumFontFamiliesEx(
			[In] IntPtr hdc, [In] ref LOGFONT lpLogfont, EnumFontFamExProc lpEnumFontFamExProc, [MarshalAs(UnmanagedType.SysInt)] int lParam, uint dwFlags);

		/// <summary>
		///     <para>Applies to: desktop apps only</para>
		///     <para>
		///         The <see cref="DescribePixelFormat" /> function obtains information about the pixel format identified by <paramref name="iPixelFormat" /> of
		///         the device associated with <paramref name="hdc" />. The function sets the members of the <see cref="PIXELFORMATDESCRIPTOR" /> structure
		///         pointed to by <paramref name="ppfd" /> with that pixel format data.
		///     </para>
		/// </summary>
		/// <param name="hdc">Specifies the device context.</param>
		/// <param name="iPixelFormat">
		///     Index that specifies the pixel format. The pixel formats that a device context supports are identified by positive
		///     one-based integer indexes.
		/// </param>
		/// <param name="nBytes">
		///     The size, in bytes, of the structure pointed to by <paramref name="ppfd" />. The <see cref="DescribePixelFormat" /> function stores no more than
		///     <paramref name="nBytes" /> bytes of data to that structure. Set this value to sizeof(<see cref="PIXELFORMATDESCRIPTOR" />).
		/// </param>
		/// <param name="ppfd">
		///     Pointer to a <see cref="PIXELFORMATDESCRIPTOR" /> structure whose members the function sets with pixel format data. The function stores the
		///     number of bytes copied to the structure in the structure's <see cref="PIXELFORMATDESCRIPTOR.nSize" /> member. If, upon entry,
		///     <paramref name="ppfd" /> is NULL, the function writes no data to the structure. This is useful when you only want to obtain the maximum pixel
		///     format index of a device context.
		/// </param>
		/// <returns>
		///     <para>
		///         If the function succeeds, the return value is the maximum pixel format index of the device context. In addition, the function sets the
		///         members of the <see cref="PIXELFORMATDESCRIPTOR" /> structure pointed to by <paramref name="ppfd" /> according to the specified pixel format.
		///     </para>
		///     <para>If the function fails, the return value is zero. To get extended error information, call GetLastError.</para>
		/// </returns>
		[DllImport("gdi32.dll", EntryPoint = "DescribePixelFormat")]
		public static extern int DescribePixelFormat([In] IntPtr hdc, int iPixelFormat, uint nBytes, ref PIXELFORMATDESCRIPTOR ppfd);

		/// <summary>
		///     The <see cref="CreateFontIndirect" /> function creates a logical font that has the specified characteristics. The font can subsequently be
		///     selected as the current font for any device context.
		/// </summary>
		/// <param name="lplf">
		///     A pointer to a <see cref="LOGFONT" /> structure that defines the characteristics of the logical font.
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is a handle to a logical font.</para>
		///     <para>If the function fails, the return value is NULL.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         The <see cref="CreateFontIndirect" /> function creates a logical font with the characteristics specified in the <see cref="LOGFONT" />
		///         structure. When this font is selected by using the <see cref="SelectObject" /> function, GDI's font mapper attempts to match the logical font
		///         with an existing physical font. If it fails to find an exact match, it provides an alternative whose characteristics match as many of the
		///         requested characteristics as possible.
		///     </para>
		///     <para>
		///         To get the appropriate font on different language versions of the OS, call <see cref="EnumFontFamiliesEx" /> with the desired font
		///         characteristics in the <see cref="LOGFONT" /> structure, retrieve the appropriate typeface name, and create the font using
		///         <see cref="CreateFont" /> or <see cref="CreateFontIndirect" />.
		///     </para>
		///     <para>
		///         When you no longer need the font, call the <see cref="DeleteObject" /> function to delete it.
		///     </para>
		///     <para>
		///         The fonts for many East Asian languages have two typeface names: an English name and a localized name. <see cref="CreateFont" /> and
		///         <see cref="CreateFontIndirect" /> take the localized typeface name only on a system locale that matches the language, while they take the
		///         English typeface name on all other system locales. The best method is to try one name and, on failure, try the other. Note that
		///         <see cref="EnumFonts" />, <see cref="EnumFontFamilies" />, and <see cref="EnumFontFamiliesEx" /> return the English typeface name if the
		///         system locale does not match the language of the font.
		///     </para>
		///     <para>
		///         The font mapper for <see cref="CreateFont" />, <see cref="CreateFontIndirect" />, and <see cref="CreateFontIndirectEx" /> recognizes both the
		///         English and the localized typeface name, regardless of locale.
		///     </para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "CreateFontIndirect")]
		public static extern IntPtr CreateFontIndirect([In] ref LOGFONT lplf);

		/// <summary>
		///     The <see cref="CreateBrushIndirect" /> function creates a logical brush that has the specified style, color, and pattern.
		/// </summary>
		/// <param name="lplb">
		///     A pointer to a <see cref="LOGBRUSH" /> structure that contains information about the brush.
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value identifies a logical brush.</para>
		///     <para>If the function fails, the return value is NULL.</para>
		/// </returns>
		/// <remarks>
		///     <para>A brush is a bitmap that the system uses to paint the interiors of filled shapes.</para>
		///     <para>
		///         After an application creates a brush by calling <see cref="CreateBrushIndirect" />, it can select it into any device context by calling the
		///         <see cref="SelectObject" /> function.
		///     </para>
		///     <para>
		///         A brush created by using a monochrome bitmap (one color plane, one bit per pixel) is drawn using the current text and background colors.
		///         Pixels represented by a bit set to 0 are drawn with the current text color; pixels represented by a bit set to 1 are drawn with the current
		///         background color.
		///     </para>
		///     <para>
		///         When you no longer need the brush, call the <see cref="DeleteObject" /> function to delete it.
		///     </para>
		///     <para>
		///         ICM: No color is done at brush creation. However, color management is performed when the brush is selected into an ICM-enabled device
		///         context.
		///     </para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "CreateBrushIndirect")]
		public static extern IntPtr CreateBrushIndirect([In] ref LOGBRUSH lplb);

		/// <summary>
		///     The <see cref="ColorCorrectPalette" /> function corrects the entries of a palette using the WCS 1.0 parameters in the specified device context.
		/// </summary>
		/// <param name="hDC">Specifies a device context whose WCS parameters to use.</param>
		/// <param name="hPalette">Specifies the handle to the palette to be color corrected.</param>
		/// <param name="dwFirstEntry">Specifies the first entry in the palette to be color corrected.</param>
		/// <param name="dwNumOfEntries">Specifies the number of entries to color correct.</param>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "ColorCorrectPalette")]
		public static extern bool ColorCorrectPalette([In] IntPtr hDC, [In] IntPtr hPalette, uint dwFirstEntry, uint dwNumOfEntries);

		/// <summary>
		///     The <see cref="SetWinMetaFileBits" /> function converts a metafile from the older Windows format to the new enhanced format and stores the new
		///     metafile in memory.
		/// </summary>
		/// <param name="cbBuffer">The size, in bytes, of the buffer that contains the Windows-format metafile.</param>
		/// <param name="lpbBuffer">
		///     A pointer to a buffer that contains the Windows-format metafile data. (It is assumed that the data was obtained by using the
		///     <see cref="GetMetaFileBitsEx" /> or <see cref="GetWinMetaFileBits" /> function.)
		/// </param>
		/// <param name="hdcRef">A handle to a reference device context.</param>
		/// <param name="lpmfp">
		///     A pointer to a <see cref="METAFILEPICT" /> structure that contains the suggested size of the metafile picture and the mapping mode that was used
		///     when the picture was created.
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is a handle to a memory-based enhanced metafile.</para>
		///     <para>If the function fails, the return value is NULL.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         Windows uses the reference device context's resolution data and the data in the <see cref="METAFILEPICT" /> structure to scale a picture. If
		///         the <paramref name="hdcRef" /> parameter is NULL, the system uses resolution data for the current output device. If the
		///         <paramref name="lpmfp" /> parameter is NULL, the system uses the MM_ANISOTROPIC mapping mode to scale the picture so that it fits the entire
		///         device surface. The <see cref="METAFILEPICT.hMF" /> member of the <see cref="METAFILEPICT" /> structure is not used.
		///     </para>
		///     <para>
		///         When the application no longer needs the enhanced metafile handle, it should delete it by calling the <see cref="DeleteEnhMetaFile" />
		///         function.
		///     </para>
		///     <para>The handle returned by this function can be used with other enhanced-metafile functions.</para>
		///     <para>
		///         If the reference device context is not identical to the device in which the metafile was originally created, some GDI functions that use
		///         device units may not draw the picture correctly.
		///     </para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "SetWinMetaFileBits")]
		public static extern IntPtr SetWinMetaFileBits(uint cbBuffer, [In] IntPtr lpbBuffer, [In] IntPtr hdcRef, [In] ref METAFILEPICT lpmfp);

		/// <summary>
		///     The <see cref="SetEnhMetaFileBits" /> function creates a memory-based enhanced-format metafile from the specified data.
		/// </summary>
		/// <param name="cbBuffer">Specifies the size, in bytes, of the data provided.</param>
		/// <param name="lpData">
		///     Pointer to a buffer that contains enhanced-metafile data. (It is assumed that the data in the buffer was obtained by calling the
		///     <see cref="GetEnhMetaFileBits" /> function.)
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is a handle to a memory-based enhanced metafile.</para>
		///     <para>If the function fails, the return value is NULL.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         When the application no longer needs the enhanced-metafile handle, it should delete the handle by calling the
		///         <see cref="DeleteEnhMetaFile" /> function.
		///     </para>
		///     <para>
		///         The <see cref="SetEnhMetaFileBits" /> function does not accept metafile data in the Windows format. To import Windows-format metafiles, use
		///         the <see cref="SetWinMetaFileBits" /> function.
		///     </para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "SetEnhMetaFileBits")]
		public static extern IntPtr SetEnhMetaFileBits(uint cbBuffer, [In] IntPtr lpData);

		/// <summary>
		///     The <see cref="SetDeviceGammaRamp" /> function sets the gamma ramp on direct color display boards having drivers that support downloadable gamma
		///     ramps in hardware.
		/// </summary>
		/// <param name="hDC">Specifies the device context of the direct color display board in question.</param>
		/// <param name="lpRamp">
		///     Pointer to a buffer containing the gamma ramp to be set. The gamma ramp is specified in three arrays of 256 WORD elements each, which contain the
		///     mapping between RGB values in the frame buffer and digital-analog-converter (DAC) values. The sequence of the arrays is red, green, blue. The RGB
		///     values must be stored in the most significant bits of each WORD to increase DAC independence.
		/// </param>
		/// <remarks>
		///     Direct color display modes do not use color lookup tables and are usually 16, 24, or 32 bit. Not all direct color video boards support loadable
		///     gamma ramps. <see cref="SetDeviceGammaRamp" /> succeeds only for devices with drivers that support downloadable gamma ramps in hardware.
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "SetDeviceGammaRamp")]
		public static extern bool SetDeviceGammaRamp([In] IntPtr hDC, [In] IntPtr lpRamp);

		/// <summary>
		///     The <see cref="SetColorAdjustment" /> function sets the color adjustment values for a device context (DC) using the specified values.
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <param name="lpca">
		///     A pointer to a <see cref="COLORADJUSTMENT" /> structure containing the color adjustment values.
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     The color adjustment values are used to adjust the input color of the source bitmap for calls to the <see cref="StretchBlt" /> and
		///     <see cref="StretchDIBits" /> functions when HALFTONE mode is set.
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "SetColorAdjustment")]
		public static extern bool SetColorAdjustment([In] IntPtr hdc, [In] ref COLORADJUSTMENT lpca);

		/// <summary>
		///     The <see cref="ScaleViewportExtEx" /> function modifies the viewport for a device context using the ratios formed by the specified multiplicands
		///     and divisors.
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <param name="Xnum">The amount by which to multiply the current horizontal extent.</param>
		/// <param name="Xdenom">The amount by which to divide the current horizontal extent.</param>
		/// <param name="Ynum">The amount by which to multiply the current vertical extent.</param>
		/// <param name="Ydenom">The amount by which to divide the current vertical extent.</param>
		/// <param name="lpSize">
		///     A pointer to a <see cref="SIZE" /> structure that receives the previous viewport extents, in device units. If <paramref name="lpSize" /> is NULL,
		///     this parameter is not used.
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>The viewport extents are modified as follows:</remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "ScaleViewportExtEx")]
		public static extern bool ScaleViewportExtEx([In] IntPtr hdc, int Xnum, int Xdenom, int Ynum, int Ydenom, IntPtr lpSize);

		/// <summary>
		///     <para>
		///         The <see cref="PlayMetaFileRecord" /> function plays a Windows-format metafile record by executing the graphics device interface (GDI)
		///         function contained within that record.
		///     </para>
		///     <para>
		///         Note:  This function is provided only for compatibility with Windows-format metafiles. Enhanced-format metafiles provide superior
		///         functionality and are recommended for new applications. The corresponding function for an enhanced-format metafile is
		///         <see cref="PlayEnhMetaFileRecord" />.
		///     </para>
		/// </summary>
		/// <param name="hdc">A handle to a device context.</param>
		/// <param name="lpHandletable">
		///     A pointer to a <see cref="HANDLETABLE" /> structure representing the table of handles to GDI objects used when playing the metafile.
		/// </param>
		/// <param name="lpMetaRecord">A pointer to the Windows-format metafile record.</param>
		/// <param name="nHandles">The number of handles in the handle table.</param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         To convert a Windows-format metafile into an enhanced-format metafile, use the <see cref="SetWinMetaFileBits" /> function.
		///     </para>
		///     <para>
		///         An application typically uses <see cref="PlayMetaFileRecord" /> in conjunction with the <see cref="EnumMetaFile" /> function to process and
		///         play a Windows-format metafile one record at a time.
		///     </para>
		///     <para>
		///         The <paramref name="lpHandletable" /> and <paramref name="nHandles" /> parameters must be identical to those passed to the
		///         <see cref="EnumMetaFileProc" /> callback procedure by <see cref="EnumMetaFile" />.
		///     </para>
		///     <para>
		///         If the <see cref="PlayMetaFileRecord" /> function does not recognize a record, it ignores the record and returns TRUE.
		///     </para>
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "PlayMetaFileRecord")]
		public static extern bool PlayMetaFileRecord(
			[In] IntPtr hdc, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 3)] HANDLETABLE[] lpHandletable,
			[In] ref METARECORD lpMetaRecord, uint nHandles);

		/// <summary>
		///     The <see cref="GetWinMetaFileBits" /> function converts the enhanced-format records from a metafile into Windows-format records and stores the
		///     converted records in the specified buffer.
		/// </summary>
		/// <param name="hemf">A handle to the enhanced metafile.</param>
		/// <param name="cbBuffer">The size, in bytes, of the buffer into which the converted records are to be copied.</param>
		/// <param name="lpbBuffer">
		///     A pointer to the buffer that receives the converted records. If <paramref name="lpbBuffer" /> is NULL, <see cref="GetWinMetaFileBits" /> returns
		///     the number of bytes required to store the converted metafile records.
		/// </param>
		/// <param name="fnMapMode">The mapping mode to use in the converted metafile.</param>
		/// <param name="hdcRef">A handle to the reference device context.</param>
		/// <returns>
		///     <para>
		///         If the function succeeds and the buffer pointer is NULL, the return value is the number of bytes required to store the converted records; if
		///         the function succeeds and the buffer pointer is a valid pointer, the return value is the size of the metafile data in bytes.
		///     </para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         This function converts an enhanced metafile into a Windows-format metafile so that its picture can be displayed in an application that
		///         recognizes the older format.
		///     </para>
		///     <para>The system uses the reference device context to determine the resolution of the converted metafile.</para>
		///     <para>
		///         The <see cref="GetWinMetaFileBits" /> function does not invalidate the enhanced metafile handle. An application should call the
		///         <see cref="DeleteEnhMetaFile" /> function to release the handle when it is no longer needed.
		///     </para>
		///     <para>
		///         To create a scalable Windows-format metafile, specify MM_ANISOTROPIC as the <paramref name="fnMapMode" /> parameter.
		///     </para>
		///     <para>The upper-left corner of the metafile picture is always mapped to the origin of the reference device.</para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "GetWinMetaFileBits")]
		public static extern uint GetWinMetaFileBits([In] IntPtr hemf, uint cbBuffer, IntPtr lpbBuffer, int fnMapMode, [In] IntPtr hdcRef);

		/// <summary>Retrieves information about the character set of the font that is currently selected into a specified device context.</summary>
		/// <param name="hdc">Handle to a device context. The function obtains information about the font that is selected into this device context.</param>
		/// <param name="lpSig">
		///     <para>
		///         Pointer to a <see cref="FONTSIGNATURE" /> data structure that receives font-signature information.
		///     </para>
		///     <para>
		///         If a TrueType font is currently selected into the device context, the <see cref="FONTSIGNATURE" /> structure receives information that
		///         identifies the code page and Unicode subranges for which the font provides glyphs.
		///     </para>
		///     <para>
		///         If a font other than TrueType is currently selected into the device context, the <see cref="FONTSIGNATURE" /> structure receives zeros. In
		///         this case, the application should use the <see cref="TranslateCharsetInfo" /> function to obtain generic font-signature information for the
		///         character set.
		///     </para>
		///     <para>
		///         The <paramref name="lpSig" /> parameter specifies NULL if the application does not require the <see cref="FONTSIGNATURE" /> information. In
		///         this case, the application can also call the       <see cref="GetTextCharset" /> function, which is equivalent to calling
		///         <see cref="GetTextCharsetInfo" /> with <paramref name="lpSig" /> set to NULL.
		///     </para>
		/// </param>
		/// <param name="dwFlags">Reserved; must be set to 0.</param>
		/// <returns>
		///     If successful, returns a value identifying the character set of the font currently selected into the specified device context. The following
		///     character set identifiers are defined:
		/// </returns>
		[DllImport("gdi32.dll", EntryPoint = "GetTextCharsetInfo")]
		public static extern int GetTextCharsetInfo([In] IntPtr hdc, ref FONTSIGNATURE lpSig, uint dwFlags);

		/// <summary>
		///     The <see cref="GetEnhMetaFileBits" /> function retrieves the contents of the specified enhanced-format metafile and copies them into a buffer.
		/// </summary>
		/// <param name="hemf">A handle to the enhanced metafile.</param>
		/// <param name="cbBuffer">The size, in bytes, of the buffer to receive the data.</param>
		/// <param name="lpbBuffer">
		///     A pointer to a buffer that receives the metafile data. The buffer must be sufficiently large to contain the data. If
		///     <paramref name="lpbBuffer" /> is NULL, the function returns the size necessary to hold the data.
		/// </param>
		/// <returns>
		///     <para>If the function succeeds and the buffer pointer is NULL, the return value is the size of the enhanced metafile, in bytes.</para>
		///     <para>If the function succeeds and the buffer pointer is a valid pointer, the return value is the number of bytes copied to the buffer.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         After the enhanced-metafile bits are retrieved, they can be used to create a memory-based metafile by calling the
		///         <see cref="SetEnhMetaFileBits" /> function.
		///     </para>
		///     <para>
		///         The <see cref="GetEnhMetaFileBits" /> function does not invalidate the enhanced-metafile handle. The application must call the
		///         <see cref="DeleteEnhMetaFile" /> function to delete the handle when it is no longer needed.
		///     </para>
		///     <para>
		///         The metafile contents retrieved by this function are in the enhanced format. To retrieve the metafile contents in the Windows format, use the
		///         <see cref="GetWinMetaFileBits" /> function.
		///     </para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "GetEnhMetaFileBits")]
		public static extern uint GetEnhMetaFileBits([In] IntPtr hemf, uint cbBuffer, IntPtr lpbBuffer);

		/// <summary>
		///     The <see cref="GetDeviceGammaRamp" /> function gets the gamma ramp on direct color display boards having drivers that support downloadable gamma
		///     ramps in hardware.
		/// </summary>
		/// <param name="hDC">Specifies the device context of the direct color display board in question.</param>
		/// <param name="lpRamp">
		///     Points to a buffer where the function can place the current gamma ramp of the color display board. The gamma ramp is specified in three arrays of
		///     256 WORD elements each, which contain the mapping between RGB values in the frame buffer and digital-analog-converter (DAC) values. The sequence
		///     of the arrays is red, green, blue.
		/// </param>
		/// <remarks>
		///     Direct color display modes do not use color lookup tables and are usually 16, 24, or 32 bit. Not all direct color video boards support loadable
		///     gamma ramps. <see cref="GetDeviceGammaRamp" /> succeeds only for devices with drivers that support downloadable gamma ramps in hardware.
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "GetDeviceGammaRamp")]
		public static extern bool GetDeviceGammaRamp([In] IntPtr hDC, IntPtr lpRamp);

		/// <summary>
		///     The <see cref="GetColorAdjustment" /> function retrieves the color adjustment values for the specified device context (DC).
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <param name="lpca">
		///     A pointer to a <see cref="COLORADJUSTMENT" /> structure that receives the color adjustment values.
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "GetColorAdjustment")]
		public static extern bool GetColorAdjustment([In] IntPtr hdc, [Out] out COLORADJUSTMENT lpca);

		/// <summary>
		///     The <see cref="GetCharWidthFloat" /> function retrieves the fractional widths of consecutive characters in a specified range from the current
		///     font.
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <param name="iFirstChar">The code point of the first character in the group of consecutive characters.</param>
		/// <param name="iLastChar">The code point of the last character in the group of consecutive characters.</param>
		/// <param name="pxBuffer">A pointer to a buffer that receives the character widths, in logical units.</param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     <para>The returned widths are in the 32-bit IEEE floating-point format. (The widths are measured along the base line of the characters.)</para>
		///     <para>
		///         If the <paramref name="iFirstChar" /> parameter specifies the letter a and the <paramref name="iLastChar" /> parameter specifies the letter
		///         z, <see cref="GetCharWidthFloat" /> retrieves the widths of all lowercase characters.
		///     </para>
		///     <para>If a character does not exist in the current font, it is assigned the width of the default character.</para>
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "GetCharWidthFloat")]
		public static extern bool GetCharWidthFloat([In] IntPtr hdc, uint iFirstChar, uint iLastChar, IntPtr pxBuffer);

		/// <summary>
		///     The <see cref="CreateRoundRectRgn" /> function creates a rectangular region with rounded corners.
		/// </summary>
		/// <param name="nLeftRect">Specifies the x-coordinate of the upper-left corner of the region in device units.</param>
		/// <param name="nTopRect">Specifies the y-coordinate of the upper-left corner of the region in device units.</param>
		/// <param name="nRightRect">Specifies the x-coordinate of the lower-right corner of the region in device units.</param>
		/// <param name="nBottomRect">Specifies the y-coordinate of the lower-right corner of the region in device units.</param>
		/// <param name="nWidthEllipse">Specifies the width of the ellipse used to create the rounded corners in device units.</param>
		/// <param name="nHeightEllipse">Specifies the height of the ellipse used to create the rounded corners in device units.</param>
		/// <returns>
		///     <para>If the function succeeds, the return value is the handle to the region.</para>
		///     <para>If the function fails, the return value is NULL.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         When you no longer need the HRGN object call the <see cref="DeleteObject" /> function to delete it.
		///     </para>
		///     <para>Region coordinates are represented as 27-bit signed  integers.</para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
		public static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

		/// <summary>
		///     The <see cref="CreatePatternBrush" /> function creates a logical brush with the specified bitmap pattern. The bitmap can be a DIB section bitmap,
		///     which is created by the <see cref="CreateDIBSection" /> function, or it can be a device-dependent bitmap.
		/// </summary>
		/// <param name="hbmp">A handle to the bitmap to be used to create the logical brush.</param>
		/// <returns>
		///     <para>If the function succeeds, the return value identifies a logical brush.</para>
		///     <para>If the function fails, the return value is NULL.</para>
		/// </returns>
		/// <remarks>
		///     <para>A pattern brush is a bitmap that the system uses to paint the interiors of filled shapes.</para>
		///     <para>
		///         After an application creates a brush by calling <see cref="CreatePatternBrush" />, it can select that brush into any device context by
		///         calling the <see cref="SelectObject" /> function.
		///     </para>
		///     <para>
		///         You can delete a pattern brush without affecting the associated bitmap by using the <see cref="DeleteObject" /> function. Therefore, you can
		///         then use this bitmap to create any number of pattern brushes.
		///     </para>
		///     <para>
		///         A brush created by using a monochrome (1 bit per pixel) bitmap has the text and background colors of the device context to which it is drawn.
		///         Pixels represented by a 0 bit are drawn with the current text color; pixels represented by a 1 bit are drawn with the current background
		///         color.
		///     </para>
		///     <para>
		///         ICM: No color is done at brush creation. However, color management is performed when the brush is selected into an ICM-enabled device
		///         context.
		///     </para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "CreatePatternBrush")]
		public static extern IntPtr CreatePatternBrush([In] IntPtr hbmp);

		/// <summary>
		///     The <see cref="CreateEnhMetaFile" /> function creates a device context for an enhanced-format metafile. This device context can be used to store
		///     a device-independent picture.
		/// </summary>
		/// <param name="hdcRef">A handle to a reference device for the enhanced metafile. This parameter can be NULL; for more information, see Remarks.</param>
		/// <param name="lpFilename">
		///     A pointer to the file name for the enhanced metafile to be created. If this parameter is NULL, the enhanced metafile is memory based and its
		///     contents are lost when it is deleted by using the <see cref="DeleteEnhMetaFile" /> function.
		/// </param>
		/// <param name="lpRect">
		///     A pointer to a <see cref="RECT" /> structure that specifies the dimensions (in .01-millimeter units) of the picture to be stored in the enhanced
		///     metafile.
		/// </param>
		/// <param name="lpDescription">
		///     A pointer to a string that specifies the name of the application that created the picture, as well as the picture's title. This parameter can be
		///     NULL; for more information, see Remarks.
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is a handle to the device context for the enhanced metafile.</para>
		///     <para>If the function fails, the return value is NULL.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         Where text arguments must use Unicode characters, use the <see cref="CreateEnhMetaFile" /> function as a wide-character function. Where text
		///         arguments must use characters from the Windows character set, use this function as an ANSI function.
		///     </para>
		///     <para>
		///         The system uses the reference device identified by the <paramref name="hdcRef" /> parameter to record the resolution and units of the device
		///         on which a picture originally appeared. If the <paramref name="hdcRef" /> parameter is NULL, it uses the current display device for
		///         reference.
		///     </para>
		///     <para>
		///         The <see cref="RECT.left" /> and <see cref="RECT.top" /> members of the <see cref="RECT" /> structure pointed to by the
		///         <paramref name="lpRect" />
		///         parameter must be less than the <see cref="RECT.right" /> and <see cref="RECT.bottom" /> members, respectively. Points along the edges of the
		///         rectangle are included in the picture. If <paramref name="lpRect" /> is NULL, the graphics device interface (GDI) computes the dimensions of
		///         the smallest rectangle that surrounds the picture drawn by the application. The <paramref name="lpRect" /> parameter should be provided where
		///         possible.
		///     </para>
		///     <para>
		///         The string pointed to by the <paramref name="lpDescription" /> parameter must contain a null character between the application name and the
		///         picture name and must terminate with two null characters for example, "XYZ Graphics Editor\0Bald Eagle\0\0", where \0 represents the null
		///         character. If <paramref name="lpDescription" /> is NULL, there is no corresponding entry in the enhanced-metafile header.
		///     </para>
		///     <para>
		///         Applications use the device context created by this function to store a graphics picture in an enhanced metafile. The handle identifying this
		///         device context can be passed to any GDI function.
		///     </para>
		///     <para>
		///         After an application stores a picture in an enhanced metafile, it can display the picture on any output device by calling the
		///         <see cref="PlayEnhMetaFile" /> function. When displaying the picture, the system uses the rectangle pointed to by the
		///         <paramref name="lpRect" /> parameter and the resolution data from the reference device to position and scale the picture.
		///     </para>
		///     <para>The device context returned by this function contains the same default attributes associated with any new device context.</para>
		///     <para>
		///         Applications must use the <see cref="GetWinMetaFileBits" /> function to convert an enhanced metafile to the older Windows metafile format.
		///     </para>
		///     <para>The file name for the enhanced metafile should use the .emf extension.</para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "CreateEnhMetaFile")]
		public static extern IntPtr CreateEnhMetaFile([In] IntPtr hdcRef, [In] string lpFilename, [In] ref RECT lpRect, [In] string lpDescription);

		/// <summary>
		///     The <see cref="CreateCompatibleDC" /> function creates a memory device context (DC) compatible with the specified device.
		/// </summary>
		/// <param name="hdc">
		///     A handle to an existing DC. If this handle is NULL, the function creates a memory DC compatible with the application's current
		///     screen.
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is the handle to a memory DC.</para>
		///     <para>If the function fails, the return value is NULL.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         A memory DC exists only in memory. When the memory DC is created, its display surface is exactly one monochrome pixel wide and one monochrome
		///         pixel high. Before an application can use a memory DC for drawing operations, it must select a bitmap of the correct width and height into
		///         the DC. To select a bitmap into a DC, use the <see cref="CreateCompatibleBitmap" /> function, specifying the height, width, and color
		///         organization required.
		///     </para>
		///     <para>
		///         When a memory DC is created, all attributes are set to normal default values. The memory DC can be used as a normal DC. You can set the
		///         attributes; obtain the current settings of its attributes; and select pens, brushes, and regions.
		///     </para>
		///     <para>
		///         The <see cref="CreateCompatibleDC" /> function can only be used with devices that support raster operations. An application can determine
		///         whether a device supports these operations by calling the <see cref="GetDeviceCaps" /> function.
		///     </para>
		///     <para>
		///         When you no longer need the memory DC, call the <see cref="DeleteDC" /> function. We recommend that you call <see cref="DeleteDC" /> to
		///         delete the DC.  However, you can also call <see cref="DeleteObject" /> with the HDC to delete the DC.
		///     </para>
		///     <para>
		///         If <paramref name="hdc" /> is NULL, the thread that calls <see cref="CreateCompatibleDC" /> owns the HDC that is created. When this thread is
		///         destroyed, the HDC is no longer valid. Thus, if you create the HDC and pass it to another thread, then exit the first thread, the second
		///         thread will not be able to use the HDC.
		///     </para>
		///     <para>
		///         ICM: If the DC that is passed to this function is enabled for Image Color Management (ICM), the DC created by the function is ICM-enabled.
		///         The source and destination color spaces are specified in the DC.
		///     </para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "CreateCompatibleDC")]
		public static extern IntPtr CreateCompatibleDC([In] IntPtr hdc);

		/// <summary>
		///     The <see cref="ColorMatchToTarget" /> function enables you to preview colors as they would appear on the target device.
		/// </summary>
		/// <param name="hDC">Specifies the device context for previewing, generally the screen.</param>
		/// <param name="hdcTarget">Specifies the target device context, generally a printer.</param>
		/// <param name="uiAction">
		///     <para>A constant that can have one of the following values.</para>
		///     <list type="table">
		///         <item>
		///             <term>CS_ENABLE</term>
		///             <description>
		///                 Map the colors to the target device's color gamut. This enables color proofing. All subsequent draw commands to the DC will render
		///                 colors as they would appear on the target device.
		///             </description>
		///         </item>
		///         <item>
		///             <term>CS_DISABLE</term>
		///             <description>Disable color proofing.</description>
		///         </item>
		///         <item>
		///             <term>CS_DELETE_TRANSFORM</term>
		///             <description>If color management is enabled for the target profile, disable it and delete the concatenated transform.</description>
		///         </item>
		///     </list>
		/// </param>
		/// <remarks>
		///     <para>
		///         <see cref="ColorMatchToTarget" /> can be used to proof the colors of a color output device on another color output device. Setting the
		///         <paramref name="uiAction" /> parameter to CS_ENABLE causes all subsequent drawing commands to the DC to render colors as they would appear on
		///         the target device. If <paramref name="uiAction" /> is set to CS_DISABLE, proofing is turned off. However, the current color transform is not
		///         deleted from the DC. It is just inactive.
		///     </para>
		///     <para>
		///         When <see cref="ColorMatchToTarget" /> is called, the color transform for the target device is performed first, and then the transform to the
		///         preview device is applied to the results of the first transform. This is used primarily for checking gamut mapping conditions. Before using
		///         this function, you must enable WCS for both device contexts.
		///     </para>
		///     <para>
		///         This function cannot be cascaded. While color mapping to the target is enabled by setting <paramref name="uiAction" /> to CS_ENABLE,
		///         application changes to the color space or gamut mapping method are ignored. Those changes then take effect when color mapping to the target
		///         is disabled.
		///     </para>
		///     <para>
		///         Note:  A memory leak will not occur if an application does not delete a transform using CS_DELETE_TRANSFORM. The transform will be deleted
		///         when either the device context (DC) is closed, or when the application color space is deleted. However if the transform is not going to be
		///         used again, or if the application will not be performing any more color matching on the DC, it should explicitly delete the transform to free
		///         the memory it occupies.
		///     </para>
		///     <para>
		///         The <paramref name="uiAction" /> parameter should only be set to CS_DELETE_TRANSFORM if color management is enabled before the
		///         <see cref="ColorMatchToTarget" /> function is called.
		///     </para>
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "ColorMatchToTarget")]
		public static extern bool ColorMatchToTarget([In] IntPtr hDC, [In] IntPtr hdcTarget, uint uiAction);

		/// <summary>
		///     The <see cref="CheckColorsInGamut" /> function determines whether a specified set of RGB triples lies in the output gamut of a specified device.
		///     The RGB triples are interpreted in the input logical color space.
		/// </summary>
		/// <param name="hDC">Handle to the device context whose output gamut to be checked.</param>
		/// <param name="lpRGBTriples">Pointer to an array of RGB triples to check.</param>
		/// <param name="lpBuffer">
		///     Pointer to the buffer in which the results are to be placed. This buffer must be at least as large as <paramref name="nCount" /> bytes.
		/// </param>
		/// <param name="nCount">The number of elements in the array of triples.</param>
		/// <remarks>
		///     <para>
		///         The function places the test results in the buffer pointed to by <paramref name="lpBuffer" />. Each byte in the buffer corresponds to an RGB
		///         triple, and has an unsigned value between CM_IN_GAMUT (= 0) and CM_OUT_OF_GAMUT (= 255). The value 0 denotes that the color is in gamut,
		///         while a nonzero value denotes that it is out of gamut. For any integer n such that 0 &lt; n &lt; 255, a result value of n + 1 indicates that
		///         the corresponding color is at least as far out of gamut as would be indicated by a result value of n, as specified by the ICC Profile Format
		///         Specification. For more information on the ICC Profile Format Specification, see the sources listed in Further Information.
		///     </para>
		///     <para>
		///         Note that for this function to succeed, WCS must be enabled for the device context handle that is passed in through the
		///         <paramref name="hDC" /> parameter. WCS can be enabled for a device context handle by calling the <see cref="SetICMMode" /> function.
		///     </para>
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "CheckColorsInGamut")]
		public static extern bool CheckColorsInGamut([In] IntPtr hDC, [In] IntPtr lpRGBTriples, IntPtr lpBuffer, uint nCount);

		/// <summary>
		///     The <see cref="AddFontResourceEx" /> function adds the font resource from the specified file to the system. Fonts added with the
		///     <see cref="AddFontResourceEx" /> function can be marked as private and not enumerable.
		/// </summary>
		/// <param name="lpszFilename">
		///     <para>
		///         A pointer to a null-terminated character string that contains a valid font file name. This parameter can specify any of the following
		///         files.
		///     </para>
		///     <list type="table">
		///         <item>
		///             <term>.fon</term>
		///             <description>Font resource file.</description>
		///         </item>
		///         <item>
		///             <term>.fnt</term>
		///             <description>Raw bitmap font file.</description>
		///         </item>
		///         <item>
		///             <term>.ttf</term>
		///             <description>Raw TrueType file.</description>
		///         </item>
		///         <item>
		///             <term>.ttc</term>
		///             <description>East Asian Windows: TrueType font collection.</description>
		///         </item>
		///         <item>
		///             <term>.fot</term>
		///             <description>TrueType resource file.</description>
		///         </item>
		///         <item>
		///             <term>.otf</term>
		///             <description>PostScript OpenType font.</description>
		///         </item>
		///         <item>
		///             <term>.mmm</term>
		///             <description>multiple master Type1 font resource file. It must be used with .pfm and .pfb files.</description>
		///         </item>
		///         <item>
		///             <term>.pfb</term>
		///             <description>Type 1 font bits file. It is used with a .pfm file.</description>
		///         </item>
		///         <item>
		///             <term>.pfm</term>
		///             <description>Type 1 font metrics file. It is used with a .pfb file.</description>
		///         </item>
		///     </list>
		///     <para>
		///         To add a font whose information comes from several resource files, point <paramref name="lpszFilename" /> to a string with the file names
		///         separated by a | --for example, abcxxxxx.pfm | abcxxxxx.pfb.
		///     </para>
		/// </param>
		/// <param name="fl">
		///     <para>The characteristics of the font to be added to the system. This parameter can be one of the following values.</para>
		///     <list type="table">
		///         <item>
		///             <term>FR_PRIVATE</term>
		///             <description>
		///                 Specifies that only the process that called the <see cref="AddFontResourceEx" /> function can use this font. When the font name
		///                 matches a public font, the private font will be chosen. When the process terminates, the system will remove all fonts installed by
		///                 the process with the <see cref="AddFontResourceEx" /> function.
		///             </description>
		///         </item>
		///         <item>
		///             <term>FR_NOT_ENUM</term>
		///             <description>
		///                 Specifies that no process, including the process that called the <see cref="AddFontResourceEx" /> function, can enumerate this font.
		///             </description>
		///         </item>
		///     </list>
		/// </param>
		/// <param name="pdv">Reserved. Must be zero.</param>
		/// <returns>
		///     <para>If the function succeeds, the return value specifies the number of fonts added.</para>
		///     <para>If the function fails, the return value is zero. No extended error information is available.</para>
		/// </returns>
		/// <remarks>
		///     <para>This function allows a process to use fonts without allowing other processes access to the fonts.</para>
		///     <para>
		///         When an application no longer needs a font resource it loaded by calling the <see cref="AddFontResourceEx" /> function, it must remove the
		///         resource by calling the <see cref="RemoveFontResourceEx" /> function.
		///     </para>
		///     <para>
		///         This function installs the font only for the current session. When the system restarts, the font will not be present. To have the font
		///         installed even after restarting the system, the font must be listed in the registry.
		///     </para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "AddFontResourceEx")]
		public static extern int AddFontResourceEx([In] string lpszFilename, uint fl, IntPtr pdv);

		/// <summary>
		///     The <see cref="StrokeAndFillPath" /> function closes any open figures in a path, strokes the outline of the path by using the current pen, and
		///     fills its interior by using the current brush.
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         The device context identified by the <paramref name="hdc" /> parameter must contain a closed path.
		///     </para>
		///     <para>
		///         The <see cref="StrokeAndFillPath" /> function has the same effect as closing all the open figures in the path, and stroking and filling the
		///         path separately, except that the filled region will not overlap the stroked region even if the pen is wide.
		///     </para>
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "StrokeAndFillPath")]
		public static extern bool StrokeAndFillPath([In] IntPtr hdc);

		/// <summary>
		///     The <see cref="SetWorldTransform" /> function sets a two-dimensional linear transformation between world space and page space for the specified
		///     device context. This transformation can be used to scale, rotate, shear, or translate graphics output.
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <param name="lpXform">
		///     A pointer to an <see cref="XFORM" /> structure that contains the transformation data.
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>For any coordinates (x, y) in world space, the transformed coordinates in page space (x', y') can be determined by the following algorithm:</remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "SetWorldTransform")]
		public static extern bool SetWorldTransform([In] IntPtr hdc, [In] ref XFORM lpXform);

		/// <summary>
		///     The <see cref="SetStretchBltMode" /> function sets the bitmap stretching mode in the specified device context.
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <param name="iStretchMode">
		///     <para>The stretching mode. This parameter can be one of the following values.</para>
		///     <list type="table">
		///         <item>
		///             <term>BLACKONWHITE</term>
		///             <description>
		///                 Performs a Boolean AND operation using the color values for the eliminated and existing pixels. If the bitmap is a monochrome bitmap,
		///                 this mode preserves black pixels at the expense of white pixels.
		///             </description>
		///         </item>
		///         <item>
		///             <term>COLORONCOLOR</term>
		///             <description>Deletes the pixels. This mode deletes all eliminated lines of pixels without trying to preserve their information.</description>
		///         </item>
		///         <item>
		///             <term>HALFTONE</term>
		///             <description>
		///                 <para>
		///                     Maps pixels from the source rectangle into blocks of pixels in the destination rectangle. The average color over the destination
		///                     block of pixels approximates the color of the source pixels.
		///                 </para>
		///                 <para>
		///                     After setting the HALFTONE stretching mode, an application must call the <see cref="SetBrushOrgEx" /> function to set the brush
		///                     origin. If it fails to do so, brush misalignment occurs.
		///                 </para>
		///             </description>
		///         </item>
		///         <item>
		///             <term>STRETCH_ANDSCANS</term>
		///             <description>Same as BLACKONWHITE.</description>
		///         </item>
		///         <item>
		///             <term>STRETCH_DELETESCANS</term>
		///             <description>Same as COLORONCOLOR.</description>
		///         </item>
		///         <item>
		///             <term>STRETCH_HALFTONE</term>
		///             <description>Same as HALFTONE.</description>
		///         </item>
		///         <item>
		///             <term>STRETCH_ORSCANS</term>
		///             <description>Same as WHITEONBLACK.</description>
		///         </item>
		///         <item>
		///             <term>WHITEONBLACK</term>
		///             <description>
		///                 Performs a Boolean OR operation using the color values for the eliminated and existing pixels. If the bitmap is a monochrome bitmap,
		///                 this mode preserves white pixels at the expense of black pixels.
		///             </description>
		///         </item>
		///     </list>
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is the previous stretching mode.</para>
		///     <para>If the function fails, the return value is zero.</para>
		///     <para>This function can return the following value.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         The stretching mode defines how the system combines rows or columns of a bitmap with existing pixels on a display device when an application
		///         calls the <see cref="StretchBlt" /> function.
		///     </para>
		///     <para>
		///         The BLACKONWHITE (STRETCH_ANDSCANS) and WHITEONBLACK (STRETCH_ORSCANS) modes are typically used to preserve foreground pixels in monochrome
		///         bitmaps. The COLORONCOLOR (STRETCH_DELETESCANS) mode is typically used to preserve color in color bitmaps.
		///     </para>
		///     <para>
		///         The HALFTONE mode is slower and requires more processing of the source image than the other three modes; but produces higher quality images.
		///         Also note that <see cref="SetBrushOrgEx" /> must be called after setting the HALFTONE mode to avoid brush misalignment.
		///     </para>
		///     <para>Additional stretching modes might also be available depending on the capabilities of the device driver.</para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "SetStretchBltMode")]
		public static extern int SetStretchBltMode([In] IntPtr hdc, int iStretchMode);

		/// <summary>
		///     The <see cref="SetPaletteEntries" /> function sets RGB (red, green, blue) color values and flags in a range of entries in a logical palette.
		/// </summary>
		/// <param name="hpal">A handle to the logical palette.</param>
		/// <param name="iStart">The first logical-palette entry to be set.</param>
		/// <param name="cEntries">The number of logical-palette entries to be set.</param>
		/// <param name="lppe">
		///     A pointer to the first member of an array of <see cref="PALETTEENTRY" /> structures containing the RGB values and flags.
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is the number of entries that were set in the logical palette.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         An application can determine whether a device supports palette operations by calling the <see cref="GetDeviceCaps" /> function and specifying
		///         the RASTERCAPS constant.
		///     </para>
		///     <para>
		///         Even if a logical palette has been selected and realized, changes to the palette do not affect the physical palette in the surface.
		///         <see cref="RealizePalette" /> must be called again to set the new logical palette into the surface.
		///     </para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "SetPaletteEntries")]
		public static extern uint SetPaletteEntries(
			[In] IntPtr hpal, uint iStart, uint cEntries,
			[MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 2)] PALETTEENTRY[] lppe);

		/// <summary>
		///     <para>
		///         The <see cref="SetMetaFileBitsEx" /> function creates a memory-based Windows-format metafile from the supplied data.
		///     </para>
		///     <para>
		///         Note:  This function is provided only for compatibility with Windows-format metafiles. Enhanced-format metafiles provide superior
		///         functionality and are recommended for new applications. The corresponding function for an enhanced-format metafile is
		///         <see cref="SetEnhMetaFileBits" />.
		///     </para>
		/// </summary>
		/// <param name="nSize">Specifies the size, in bytes, of the Windows-format metafile.</param>
		/// <param name="lpData">
		///     Pointer to a buffer that contains the Windows-format metafile. (It is assumed that the data was obtained by using the
		///     <see cref="GetMetaFileBitsEx" /> function.)
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is a handle to a memory-based Windows-format metafile.</para>
		///     <para>If the function fails, the return value is NULL.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         To convert a Windows-format metafile into an enhanced-format metafile, use the <see cref="SetWinMetaFileBits" /> function.
		///     </para>
		///     <para>
		///         When the application no longer needs the metafile handle returned by <see cref="SetMetaFileBitsEx" />, it should delete it by calling the
		///         <see cref="DeleteMetaFile" /> function.
		///     </para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "SetMetaFileBitsEx")]
		public static extern IntPtr SetMetaFileBitsEx(uint nSize, [In] IntPtr lpData);

		/// <summary>
		///     The <see cref="SetDIBitsToDevice" /> function sets the pixels in the specified rectangle on the device that is associated with the destination
		///     device context using color data from a DIB, JPEG, or PNG image.
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <param name="XDest">The x-coordinate, in logical units, of the upper-left corner of the destination rectangle.</param>
		/// <param name="YDest">The y-coordinate, in logical units, of the upper-left corner of the destination rectangle.</param>
		/// <param name="dwWidth">The width, in logical units, of the image.</param>
		/// <param name="dwHeight">The height, in logical units, of the image.</param>
		/// <param name="XSrc">The x-coordinate, in logical units, of the lower-left corner of the image.</param>
		/// <param name="YSrc">The y-coordinate, in logical units, of the lower-left corner of the image.</param>
		/// <param name="uStartScan">The starting scan line in the image.</param>
		/// <param name="cScanLines">
		///     The number of DIB scan lines contained in the array pointed to by the <paramref name="lpvBits" /> parameter.
		/// </param>
		/// <param name="lpvBits">A pointer to the color data stored as an array of bytes. For more information, see the following Remarks section.</param>
		/// <param name="lpbmi">
		///     A pointer to a <see cref="BITMAPINFO" /> structure that contains information about the DIB.
		/// </param>
		/// <param name="fuColorUse">
		///     <para>
		///         Indicates whether the <see cref="BITMAPINFO.bmiColors" /> member of the <see cref="BITMAPINFO" /> structure contains explicit red, green,
		///         blue (RGB) values or indexes into a palette. For more information, see the following Remarks section.
		///     </para>
		///     <para>
		///         The <paramref name="fuColorUse" /> parameter must be one of the following values.
		///     </para>
		///     <list type="table">
		///         <item>
		///             <term>DIB_PAL_COLORS</term>
		///             <description>The color table consists of an array of 16-bit indexes into the currently selected logical palette.</description>
		///         </item>
		///         <item>
		///             <term>DIB_RGB_COLORS</term>
		///             <description>The color table contains literal RGB values.</description>
		///         </item>
		///     </list>
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is the number of scan lines set.</para>
		///     <para>
		///         If zero scan lines are set (such as when <paramref name="dwHeight" /> is 0) or the function fails, the function returns zero.
		///     </para>
		///     <para>
		///         If the driver cannot support the JPEG or PNG file image passed to <see cref="SetDIBitsToDevice" />, the function will fail and return
		///         GDI_ERROR. If failure does occur, the application must fall back on its own JPEG or PNG support to decompress the image into a bitmap, and
		///         then pass the bitmap to <see cref="SetDIBitsToDevice" />.
		///     </para>
		/// </returns>
		/// <remarks>
		///     <para>Optimal bitmap drawing speed is obtained when the bitmap bits are indexes into the system palette.</para>
		///     <para>
		///         Applications can retrieve the system palette colors and indexes by calling the <see cref="GetSystemPaletteEntries" /> function. After the
		///         colors and indexes are retrieved, the application can create the DIB. For more information about the system palette, see Colors.
		///     </para>
		///     <para>The scan lines must be aligned on a DWORD except for RLE-compressed bitmaps.</para>
		///     <para>The origin of a bottom-up DIB is the lower-left corner of the bitmap; the origin of a top-down DIB is the upper-left corner.</para>
		///     <para>
		///         To reduce the amount of memory required to set bits from a large DIB on a device surface, an application can band the output by repeatedly
		///         calling <see cref="SetDIBitsToDevice" />, placing a different portion of the bitmap into the <paramref name="lpvBits" /> array each time. The
		///         values of the <paramref name="uStartScan" /> and <paramref name="cScanLines" /> parameters identify the portion of the bitmap contained in
		///         the <paramref name="lpvBits" /> array.
		///     </para>
		///     <para>
		///         The <see cref="SetDIBitsToDevice" /> function returns an error if it is called by a process that is running in the background while a
		///         full-screen MS-DOS session runs in the foreground.
		///     </para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "SetDIBitsToDevice")]
		public static extern int SetDIBitsToDevice(
			[In] IntPtr hdc, int XDest, int YDest, uint dwWidth, uint dwHeight, int XSrc, int YSrc, uint uStartScan, uint cScanLines, [In] IntPtr lpvBits,
			[In] ref BITMAPINFO lpbmi,
			uint fuColorUse);

		/// <summary>
		///     The <see cref="OffsetWindowOrgEx" /> function modifies the window origin for a device context using the specified horizontal and vertical
		///     offsets.
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <param name="nXOffset">The horizontal offset, in logical units.</param>
		/// <param name="nYOffset">The vertical offset, in logical units.</param>
		/// <param name="lpPoint">
		///     A pointer to a <see cref="POINT" /> structure. The logical coordinates of the previous window origin are placed in this structure. If
		///     <paramref name="lpPoint" /> is NULL, the previous origin is not returned.
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "OffsetWindowOrgEx")]
		public static extern bool OffsetWindowOrgEx([In] IntPtr hdc, int nXOffset, int nYOffset, IntPtr lpPoint);

		/// <summary>
		///     The <see cref="IntersectClipRect" /> function creates a new clipping region from the intersection of the current clipping region and the
		///     specified rectangle.
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <param name="nLeftRect">The x-coordinate, in logical units, of the upper-left corner of the rectangle.</param>
		/// <param name="nTopRect">The y-coordinate, in logical units, of the upper-left corner of the rectangle.</param>
		/// <param name="nRightRect">The x-coordinate, in logical units, of the lower-right corner of the rectangle.</param>
		/// <param name="nBottomRect">The y-coordinate, in logical units, of the lower-right corner of the rectangle.</param>
		/// <returns>The return value specifies the new clipping region's type and can be one of the following values.</returns>
		/// <remarks>The lower and right-most edges of the given rectangle are excluded from the clipping region.</remarks>
		[DllImport("gdi32.dll", EntryPoint = "IntersectClipRect")]
		public static extern int IntersectClipRect([In] IntPtr hdc, int nLeftRect, int nTopRect, int nRightRect, int nBottomRect);

		/// <summary>
		///     The <see cref="GetWorldTransform" /> function retrieves the current world-space to page-space transformation.
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <param name="lpXform">
		///     A pointer to an <see cref="XFORM" /> structure that receives the current world-space to page-space transformation.
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     The precision of the transformation may be altered if an application calls the <see cref="ModifyWorldTransform" /> function prior to calling
		///     <see cref="GetWorldTransform" />. (This is because the internal format for storing transformation values uses a higher precision than a FLOAT
		///     value.)
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "GetWorldTransform")]
		public static extern bool GetWorldTransform([In] IntPtr hdc, [Out] out XFORM lpXform);

		/// <summary>
		///     The <see cref="GetStretchBltMode" /> function retrieves the current stretching mode. The stretching mode defines how color data is added to or
		///     removed from bitmaps that are stretched or compressed when the <see cref="StretchBlt" /> function is called.
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <returns>If the function succeeds, the return value is the current stretching mode. This can be one of the following values.</returns>
		[DllImport("gdi32.dll", EntryPoint = "GetStretchBltMode")]
		public static extern int GetStretchBltMode([In] IntPtr hdc);

		/// <summary>
		///     The <see cref="GetRasterizerCaps" /> function returns flags indicating whether TrueType fonts are installed in the system.
		/// </summary>
		/// <param name="lprs">
		///     A pointer to a <see cref="RASTERIZER_STATUS" /> structure that receives information about the rasterizer.
		/// </param>
		/// <param name="cb">
		///     The number of bytes to be copied into the structure pointed to by the <paramref name="lprs" /> parameter.
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         The <see cref="GetRasterizerCaps" /> function enables applications and printer drivers to determine whether TrueType fonts are installed.
		///     </para>
		///     <para>
		///         If the TT_AVAILABLE flag is set in the <see cref="RASTERIZER_STATUS.wFlags" /> member of the <see cref="RASTERIZER_STATUS" /> structure, at
		///         least one TrueType font is installed. If the TT_ENABLED flag is set, TrueType is enabled for the system.
		///     </para>
		///     <para>
		///         The actual number of bytes copied is either the member specified in the <paramref name="cb" /> parameter or the length of the
		///         <see cref="RASTERIZER_STATUS" /> structure, whichever is less.
		///     </para>
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "GetRasterizerCaps")]
		public static extern bool GetRasterizerCaps(ref RASTERIZER_STATUS lprs, uint cb);

		/// <summary>
		///     The <see cref="GetPaletteEntries" /> function retrieves a specified range of palette entries from the given logical palette.
		/// </summary>
		/// <param name="hpal">A handle to the logical palette.</param>
		/// <param name="iStartIndex">The first entry in the logical palette to be retrieved.</param>
		/// <param name="nEntries">The number of entries in the logical palette to be retrieved.</param>
		/// <param name="lppe">
		///     A pointer to an array of <see cref="PALETTEENTRY" /> structures to receive the palette entries. The array must contain at least as many
		///     structures as specified by the <paramref name="nEntries" /> parameter.
		/// </param>
		/// <returns>
		///     <para>
		///         If the function succeeds and the handle to the logical palette is a valid pointer (not NULL), the return value is the number of entries
		///         retrieved from the logical palette. If the function succeeds and handle to the logical palette is NULL, the return value is the number of
		///         entries in the given palette.
		///     </para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         An application can determine whether a device supports palette operations by calling the <see cref="GetDeviceCaps" /> function and specifying
		///         the RASTERCAPS constant.
		///     </para>
		///     <para>
		///         If the <paramref name="nEntries" /> parameter specifies more entries than exist in the palette, the remaining members of the
		///         <see cref="PALETTEENTRY" /> structure are not altered.
		///     </para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "GetPaletteEntries")]
		public static extern uint GetPaletteEntries([In] IntPtr hpal, uint iStartIndex, uint nEntries, ref PALETTEENTRY[] lppe);

		/// <summary>
		///     <para>
		///         The <see cref="GetMetaFileBitsEx" /> function retrieves the contents of a Windows-format metafile and copies them into the specified buffer.
		///     </para>
		///     <para>
		///         Note:  This function is provided only for compatibility with Windows-format metafiles. Enhanced-format metafiles provide superior
		///         functionality and are recommended for new applications. The corresponding function for an enhanced-format metafile is
		///         <see cref="GetEnhMetaFileBits" />.
		///     </para>
		/// </summary>
		/// <param name="hmf">A handle to a Windows-format metafile.</param>
		/// <param name="nSize">The size, in bytes, of the buffer to receive the data.</param>
		/// <param name="lpvData">
		///     A pointer to a buffer that receives the metafile data. The buffer must be sufficiently large to contain the data. If <paramref name="lpvData" />
		///     is NULL, the function returns the number of bytes required to hold the data.
		/// </param>
		/// <returns>
		///     <para>
		///         If the function succeeds and the buffer pointer is NULL, the return value is the number of bytes required for the buffer; if the function
		///         succeeds and the buffer pointer is a valid pointer, the return value is the number of bytes copied.
		///     </para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         After the Windows-metafile bits are retrieved, they can be used to create a memory-based metafile by calling the
		///         <see cref="SetMetaFileBitsEx" /> function.
		///     </para>
		///     <para>
		///         The <see cref="GetMetaFileBitsEx" /> function does not invalidate the metafile handle. An application must delete this handle by calling the
		///         <see cref="DeleteMetaFile" /> function.
		///     </para>
		///     <para>
		///         To convert a Windows-format metafile into an enhanced-format metafile, use the <see cref="SetWinMetaFileBits" /> function.
		///     </para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "GetMetaFileBitsEx")]
		public static extern uint GetMetaFileBitsEx([In] IntPtr hmf, uint nSize, IntPtr lpvData);

		/// <summary>
		///     The <see cref="GetLogColorSpace" /> function retrieves the color space definition identified by a specified handle.
		/// </summary>
		/// <param name="hColorSpace">Specifies the handle to a color space.</param>
		/// <param name="lpBuffer">
		///     Points to a buffer to receive the <see cref="LOGCOLORSPACE" /> structure.
		/// </param>
		/// <param name="nSize">Specifies the maximum size of the buffer.</param>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "GetLogColorSpace")]
		public static extern bool GetLogColorSpace([In] IntPtr hColorSpace, out LOGCOLORSPACE lpBuffer, uint nSize);

		/// <summary>
		///     The <see cref="GetCharABCWidths" /> function retrieves the widths, in logical units, of consecutive characters in a specified range from the
		///     current TrueType font. This function succeeds only with TrueType fonts.
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <param name="uFirstChar">The first character in the group of consecutive characters from the current font.</param>
		/// <param name="uLastChar">The last character in the group of consecutive characters from the current font.</param>
		/// <param name="lpabc">
		///     A pointer to an array of <see cref="ABC" /> structures that receives the character widths, in logical units. This array must contain at least as
		///     many <see cref="ABC" /> structures as there are characters in the range specified by the <paramref name="uFirstChar" /> and
		///     <paramref name="uLastChar" /> parameters.
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         The TrueType rasterizer provides ABC character spacing after a specific point size has been selected. A spacing is the distance added to the
		///         current position before placing the glyph. B spacing is the width of the black part of the glyph. C spacing is the distance added to the
		///         current position to provide white space to the right of the glyph. The total advanced width is specified by A+B+C.
		///     </para>
		///     <para>
		///         When the <see cref="GetCharABCWidths" /> function retrieves negative A or C widths for a character, that character includes underhangs or
		///         overhangs.
		///     </para>
		///     <para>
		///         To convert the ABC widths to font design units, an application should use the value stored in the
		///         <see cref="OUTLINETEXTMETRIC.otmEMSquare" />
		///         member of a <see cref="OUTLINETEXTMETRIC" /> structure. This value can be retrieved by calling the <see cref="GetOutlineTextMetrics" />
		///         function.
		///     </para>
		///     <para>The ABC widths of the default character are used for characters outside the range of the currently selected font.</para>
		///     <para>
		///         To retrieve the widths of characters in non-TrueType fonts, applications should use the <see cref="GetCharWidth" /> function.
		///     </para>
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "GetCharABCWidths")]
		public static extern bool GetCharABCWidths([In] IntPtr hdc, uint uFirstChar, uint uLastChar, out ABC lpabc);

		/// <summary>
		///     The <see cref="GetCharABCWidthsI" /> function retrieves the widths, in logical units, of consecutive glyph indices in a specified range from the
		///     current TrueType font. This function succeeds only with TrueType fonts.
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <param name="giFirst">
		///     The first glyph index in the group of consecutive glyph indices from the current font. This parameter is only used if the <paramref name="pgi" />
		///     parameter is NULL.
		/// </param>
		/// <param name="cgi">The number of glyph indices.</param>
		/// <param name="pgi">
		///     A pointer to an array that contains glyph indices. If this parameter is NULL, the <paramref name="giFirst" /> parameter is used instead. The
		///     <paramref name="cgi" /> parameter specifies the number of glyph indices in this array.
		/// </param>
		/// <param name="lpabc">
		///     A pointer to an array of <see cref="ABC" /> structures that receives the character widths, in logical units. This array must contain at least as
		///     many <see cref="ABC" /> structures as there are glyph indices specified by the <paramref name="cgi" /> parameter.
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         The TrueType rasterizer provides ABC character spacing after a specific point size has been selected. A spacing is the distance added to the
		///         current position before placing the glyph. B spacing is the width of the black part of the glyph. C spacing is the distance added to the
		///         current position to provide white space to the right of the glyph. The total advanced width is specified by A+B+C.
		///     </para>
		///     <para>
		///         When the <see cref="GetCharABCWidthsI" /> function retrieves negative A or C widths for a character, that character includes underhangs or
		///         overhangs.
		///     </para>
		///     <para>
		///         To convert the ABC widths to font design units, an application should use the value stored in the
		///         <see cref="OUTLINETEXTMETRIC.otmEMSquare" />
		///         member of a <see cref="OUTLINETEXTMETRIC" /> structure. This value can be retrieved by calling the <see cref="GetOutlineTextMetrics" />
		///         function.
		///     </para>
		///     <para>The ABC widths of the default character are used for characters outside the range of the currently selected font.</para>
		///     <para>
		///         To retrieve the widths of glyph indices in non-TrueType fonts, applications should use the <see cref="GetCharWidthI" /> function.
		///     </para>
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "GetCharABCWidthsI")]
		public static extern bool GetCharABCWidthsI([In] IntPtr hdc, uint giFirst, uint cgi, [In] IntPtr pgi, ref ABC[] lpabc);

		/// <summary>
		///     <para>
		///         The <see cref="EnumFontFamilies" /> function enumerates the fonts in a specified font family that are available on a specified device.
		///     </para>
		///     <para>
		///         Note:  This function is provided only for compatibility with 16-bit versions of Windows. Applications should use the
		///         <see cref="EnumFontFamiliesEx" /> function.
		///     </para>
		/// </summary>
		/// <param name="hdc">A handle to the device context from which to enumerate the fonts.</param>
		/// <param name="lpszFamily">
		///     A pointer to a null-terminated string that specifies the family name of the desired fonts. If <paramref name="lpszFamily" /> is NULL,
		///     <see cref="EnumFontFamilies" /> selects and enumerates one font of each available type family.
		/// </param>
		/// <param name="lpEnumFontFamProc">
		///     A pointer to the application defined callback function. For information, see <see cref="EnumFontFamExProc" />.
		/// </param>
		/// <param name="lParam">A pointer to application-supplied data. The data is passed to the callback function along with the font information.</param>
		/// <returns>The return value is the last value returned by the callback function. Its meaning is implementation specific.</returns>
		/// <remarks>
		///     <para>
		///         For each font having the typeface name specified by the <paramref name="lpszFamily" /> parameter, the <see cref="EnumFontFamilies" />
		///         function retrieves information about that font and passes it to the function pointed to by the <paramref name="lpEnumFontFamProc" />
		///         parameter. The application defined callback function can process the font information as desired. Enumeration continues until there are no
		///         more fonts or the callback function returns zero.
		///     </para>
		///     <para>
		///         When the graphics mode on the device context is set to GM_ADVANCED using the SetGraphicsMode function and the DEVICE_FONTTYPE flag is passed
		///         to the FontType parameter, this function returns a list of type 1 and OpenType fonts on the system. When the graphics mode is not set to
		///         GM_ADVANCED, this function returns a list of type 1, OpenType, and TrueType fonts on the system.
		///     </para>
		///     <para>
		///         The fonts for many East Asian languages have two typeface names: an English name and a localized name. <see cref="EnumFonts" />,
		///         <see cref="EnumFontFamilies" />, and <see cref="EnumFontFamiliesEx" /> return the English typeface name if the system locale does not match
		///         the language of the font.
		///     </para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "EnumFontFamilies")]
		public static extern int EnumFontFamilies(
			[In] IntPtr hdc, [In] string lpszFamily, EnumFontFamExProc lpEnumFontFamProc, [MarshalAs(UnmanagedType.SysInt)] int lParam);

		/// <summary>
		///     The <see cref="DeleteEnhMetaFile" /> function deletes an enhanced-format metafile or an enhanced-format metafile handle.
		/// </summary>
		/// <param name="hemf">A handle to an enhanced metafile.</param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     If the <paramref name="hemf" /> parameter identifies an enhanced metafile stored in memory, the <see cref="DeleteEnhMetaFile" /> function deletes
		///     the metafile. If <paramref name="hemf" /> identifies a metafile stored on a disk, the function deletes the metafile handle but does not destroy
		///     the actual metafile. An application can retrieve the file by calling the <see cref="GetEnhMetaFile" /> function.
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "DeleteEnhMetaFile")]
		public static extern bool DeleteEnhMetaFile([In] IntPtr hemf);

		/// <summary>
		///     The <see cref="CreatePenIndirect" /> function creates a logical cosmetic pen that has the style, width, and color specified in a structure.
		/// </summary>
		/// <param name="lplgpn">
		///     Pointer to a <see cref="LOGPEN" /> structure that specifies the pen's style, width, and color.
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is a handle that identifies a logical cosmetic pen.</para>
		///     <para>If the function fails, the return value is NULL.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         After an application creates a logical pen, it can select that pen into a device context by calling the <see cref="SelectObject" /> function.
		///         After a pen is selected into a device context, it can be used to draw lines and curves.
		///     </para>
		///     <para>
		///         When you no longer need the pen, call the <see cref="DeleteObject" /> function to delete it.
		///     </para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "CreatePenIndirect")]
		public static extern IntPtr CreatePenIndirect([In] ref LOGPEN lplgpn);

		/// <summary>
		///     The <see cref="CreateEllipticRgn" /> function creates an elliptical region.
		/// </summary>
		/// <param name="nLeftRect">Specifies the x-coordinate in logical units, of the upper-left corner of the bounding rectangle of the ellipse.</param>
		/// <param name="nTopRect">Specifies the y-coordinate in logical units, of the upper-left corner of the bounding rectangle of the ellipse.</param>
		/// <param name="nRightRect">Specifies the x-coordinate in logical units, of the lower-right corner of the bounding rectangle of the ellipse.</param>
		/// <param name="nBottomRect">Specifies the y-coordinate in logical units, of the lower-right corner of the bounding rectangle of the ellipse.</param>
		/// <returns>
		///     <para>If the function succeeds, the return value is the handle to the region.</para>
		///     <para>If the function fails, the return value is NULL.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         When you no longer need the HRGN object, call the <see cref="DeleteObject" /> function to delete it.
		///     </para>
		///     <para>
		///         A bounding rectangle defines the size, shape, and orientation of the region: The long sides of the rectangle define the length of the
		///         ellipse's major axis; the short sides define the length of the ellipse's minor axis; and the center of the rectangle defines the intersection
		///         of the major and minor axes.
		///     </para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "CreateEllipticRgn")]
		public static extern IntPtr CreateEllipticRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect);

		/// <summary>
		///     The <see cref="CreateColorSpace" /> function creates a logical color space.
		/// </summary>
		/// <param name="lpLogColorSpace">
		///     Pointer to the <see cref="LOGCOLORSPACE" /> data structure.
		/// </param>
		/// <remarks>
		///     <para>
		///         When the color space is no longer needed, use <see cref="DeleteColorSpace" /> to delete it.
		///     </para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "CreateColorSpace")]
		public static extern IntPtr CreateColorSpace([In] ref LOGCOLORSPACE lpLogColorSpace);

		/// <summary>
		///     <para>Applies to: desktop apps only</para>
		///     <para>
		///         The <see cref="ChoosePixelFormat" /> function attempts to match an appropriate pixel format supported by a device context to a given pixel
		///         format specification.
		///     </para>
		/// </summary>
		/// <param name="hdc">
		///     Specifies the device context that the function examines to determine the best match for the pixel format descriptor pointed to by
		///     <paramref name="ppfd" />.
		/// </param>
		/// <param name="ppfd">
		///     <para>
		///         Pointer to a <see cref="PIXELFORMATDESCRIPTOR" /> structure that specifies the requested pixel format. In this context, the members of the
		///         <see cref="PIXELFORMATDESCRIPTOR" /> structure that <paramref name="ppfd" /> points to are used as follows:
		///     </para>
		///     <list type="table">
		///         <item>
		///             <term>nSize</term>
		///             <description></description>
		///         </item>
		///         <item>
		///             <term>nVersion</term>
		///             <description></description>
		///         </item>
		///         <item>
		///             <term>dwFlags</term>
		///             <description></description>
		///         </item>
		///         <item>
		///             <term>iPixelType</term>
		///             <description></description>
		///         </item>
		///         <item>
		///             <term>cColorBits</term>
		///             <description></description>
		///         </item>
		///         <item>
		///             <term>cRedBits</term>
		///             <description></description>
		///         </item>
		///         <item>
		///             <term>cRedShift</term>
		///             <description></description>
		///         </item>
		///         <item>
		///             <term>cGreenBits</term>
		///             <description></description>
		///         </item>
		///         <item>
		///             <term>cGreenShift</term>
		///             <description></description>
		///         </item>
		///         <item>
		///             <term>cBlueBits</term>
		///             <description></description>
		///         </item>
		///         <item>
		///             <term>cBlueShift</term>
		///             <description></description>
		///         </item>
		///         <item>
		///             <term>cAlphaBits</term>
		///             <description></description>
		///         </item>
		///         <item>
		///             <term>cAlphaShift</term>
		///             <description></description>
		///         </item>
		///         <item>
		///             <term>cAccumBits</term>
		///             <description></description>
		///         </item>
		///         <item>
		///             <term>cAccumRedBits</term>
		///             <description></description>
		///         </item>
		///         <item>
		///             <term>cAccumGreenBits</term>
		///             <description></description>
		///         </item>
		///         <item>
		///             <term>cAccumBlueBits</term>
		///             <description></description>
		///         </item>
		///         <item>
		///             <term>cAccumAlphaBits</term>
		///             <description></description>
		///         </item>
		///         <item>
		///             <term>cDepthBits</term>
		///             <description></description>
		///         </item>
		///         <item>
		///             <term>cStencilBits</term>
		///             <description></description>
		///         </item>
		///         <item>
		///             <term>cAuxBuffers</term>
		///             <description></description>
		///         </item>
		///         <item>
		///             <term>iLayerType</term>
		///             <description></description>
		///         </item>
		///         <item>
		///             <term>bReserved</term>
		///             <description></description>
		///         </item>
		///         <item>
		///             <term>dwLayerMask</term>
		///             <description></description>
		///         </item>
		///         <item>
		///             <term>dwVisibleMask</term>
		///             <description></description>
		///         </item>
		///         <item>
		///             <term>dwDamageMask</term>
		///             <description></description>
		///         </item>
		///     </list>
		/// </param>
		/// <returns>
		///     <para>
		///         If the function succeeds, the return value is a pixel format index (one-based) that is the closest match to the given pixel format
		///         descriptor.
		///     </para>
		///     <para>If the function fails, the return value is zero. To get extended error information, call GetLastError.</para>
		/// </returns>
		/// <remarks>
		///     You must ensure that the pixel format matched by the <see cref="ChoosePixelFormat" /> function satisfies your requirements. For example, if you
		///     request a pixel format with a 24-bit RGB color buffer but the device context offers only 8-bit RGB color buffers, the function returns a pixel
		///     format with an 8-bit RGB color buffer.
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "ChoosePixelFormat")]
		public static extern int ChoosePixelFormat([In] IntPtr hdc, [In] ref PIXELFORMATDESCRIPTOR ppfd);

		/// <summary>
		///     <para>
		///         <paramref name="(Obsolete; retained for backward compatibility)" />
		///     </para>
		///     <para>
		///         The <see cref="UpdateICMRegKey" /> function manages color profiles and Color Management Modules in the system.
		///     </para>
		/// </summary>
		/// <param name="dwReserved">Reserved, must be set to zero.</param>
		/// <param name="lpszCMID">Points to a string that specifies the ICC profile identifier for the color management DLL to use with the profile.</param>
		/// <param name="lpszFileName">
		///     Points to a fully qualified ICC color profile file name or to a <see cref="DEVMODE" /> structure.
		/// </param>
		/// <param name="nCommand">
		///     <para>Specifies a function to execute. It can have one of the following values.</para>
		///     <list type="table">
		///         <item>
		///             <term>ICM_ADDPROFILE</term>
		///             <description>Installs the ICC profile in the system.</description>
		///         </item>
		///         <item>
		///             <term>ICM_DELETEPROFILE</term>
		///             <description>Uninstalls the ICC profile from the system, but does not delete the file.</description>
		///         </item>
		///         <item>
		///             <term>ICM_QUERYPROFILE</term>
		///             <description>Determines whether the profile is already installed in the system.</description>
		///         </item>
		///         <item>
		///             <term>ICM_SETDEFAULTPROFILE</term>
		///             <description>Makes the profile first among equals.</description>
		///         </item>
		///         <item>
		///             <term>ICM_REGISTERICMATCHER</term>
		///             <description>
		///                 Registers a CMM in the system. The <paramref name="lpszFileName" /> parameter points to a fully qualified path for the CMM DLL. The
		///                 <paramref name="lpszCMID" /> parameter points to a DWORD identifying the CMM.
		///             </description>
		///         </item>
		///         <item>
		///             <term>ICM_UNREGISTERICMATCHER</term>
		///             <description>
		///                 Unregisters the CMM from the system. The <paramref name="lpszCMID" /> parameter points to a DWORD identifying the CMM.
		///             </description>
		///         </item>
		///         <item>
		///             <term>ICM_QUERYMATCH</term>
		///             <description>
		///                 Determines whether a profile exists based on the <see cref="DEVMODE" /> structure pointed to by the <paramref name="lpszFileName" />
		///                 parameter.
		///             </description>
		///         </item>
		///     </list>
		/// </param>
		/// <remarks>
		///     <para>
		///         Not all parameters are used by all functions. The <paramref name="nCommand" /> parameter specifies the function to execute.
		///     </para>
		///     <para>This function is retained for backward compatibility and may be removed in future versions of ICM.</para>
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "UpdateICMRegKey")]
		public static extern bool UpdateICMRegKey(uint dwReserved, [In] string lpszCMID, [In] string lpszFileName, uint nCommand);

		/// <summary>
		///     The <see cref="SetViewportOrgEx" /> function specifies which device point maps to the window origin (0,0).
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <param name="X">The x-coordinate, in device units, of the new viewport origin.</param>
		/// <param name="Y">The y-coordinate, in device units, of the new viewport origin.</param>
		/// <param name="lpPoint">
		///     A pointer to a <see cref="POINT" /> structure that receives the previous viewport origin, in device coordinates. If <paramref name="lpPoint" />
		///     is NULL, this parameter is not used.
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     This function (along with <see cref="SetViewportExtEx" /> and <see cref="SetWindowExtEx" />) helps define the mapping from the logical coordinate
		///     space (also known as a window) to the device coordinate space (the viewport).
		///     <see cref="SetViewportOrgEx" /> specifies which device point maps to the logical point (0,0). It has the effect of shifting the axes so that the
		///     logical point (0,0) no longer refers to the upper-left corner.
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "SetViewportOrgEx")]
		public static extern bool SetViewportOrgEx([In] IntPtr hdc, int X, int Y, IntPtr lpPoint);

		/// <summary>
		///     The <see cref="SetViewportExtEx" /> function sets the horizontal and vertical extents of the viewport for a device context by using the specified
		///     values.
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <param name="nXExtent">The horizontal extent, in device units, of the viewport.</param>
		/// <param name="nYExtent">The vertical extent, in device units, of the viewport.</param>
		/// <param name="lpSize">
		///     A pointer to a <see cref="SIZE" /> structure that receives the previous viewport extents, in device units. If <paramref name="lpSize" /> is NULL,
		///     this parameter is not used.
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         The viewport refers to the device coordinate system of the device space. The extent is the maximum value of an axis. This function sets the
		///         maximum values for the horizontal and vertical axes of the viewport in device coordinates (or pixels). When mapping between page space and
		///         device space, <see cref="SetWindowExtEx" /> and <see cref="SetViewportExtEx" /> determine the scaling factor between the window and the
		///         viewport. For more information, see Transformation of Coordinate Spaces.
		///     </para>
		///     <para>
		///         When the following mapping modes are set, calls to the <see cref="SetWindowExtEx" /> and <see cref="SetViewportExtEx" /> functions are
		///         ignored.
		///     </para>
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "SetViewportExtEx")]
		public static extern bool SetViewportExtEx([In] IntPtr hdc, int nXExtent, int nYExtent, IntPtr lpSize);

		/// <summary>
		///     The <see cref="SetDIBColorTable" /> function sets RGB (red, green, blue) color values in a range of entries in the color table of the DIB that is
		///     currently selected into a specified device context.
		/// </summary>
		/// <param name="hdc">A device context. A DIB must be selected into this device context.</param>
		/// <param name="uStartIndex">A zero-based color table index that specifies the first color table entry to set.</param>
		/// <param name="cEntries">The number of color table entries to set.</param>
		/// <param name="pColors">
		///     A pointer to an array of <see cref="RGBQUAD" /> structures containing new color information for the DIB's color table.
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is the number of color table entries that the function sets.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         This function should be called to set the color table for DIBs that use 1, 4, or 8 bpp. The <see cref="BITMAPINFOHEADER.biBitCount" /> member
		///         of a bitmap's associated bitmap information header structure.
		///     </para>
		///     <para>
		///         <see cref="BITMAPINFOHEADER" /> structure specifies the number of bits-per-pixel. Device-independent bitmaps with a
		///         <see cref="BITMAPINFOHEADER.biBitCount" />
		///         value greater than 8 do not have a color table.
		///     </para>
		///     <para>
		///         The bV5BitCount member of a bitmap's associated BITMAPV5HEADER structure specifies the number of bits-per-pixel. Device-independent bitmaps
		///         with a bV5BitCount value greater than 8 do not have a color table.
		///     </para>
		///     <para>ICM: No color management is performed.</para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "SetDIBColorTable")]
		public static extern uint SetDIBColorTable(
			[In] IntPtr hdc, uint uStartIndex, uint cEntries,
			[MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 2)] RGBQUAD[] pColors);

		/// <summary>
		///     The <see cref="ScaleWindowExtEx" /> function modifies the window for a device context using the ratios formed by the specified multiplicands and
		///     divisors.
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <param name="Xnum">The amount by which to multiply the current horizontal extent.</param>
		/// <param name="Xdenom">The amount by which to divide the current horizontal extent.</param>
		/// <param name="Ynum">The amount by which to multiply the current vertical extent.</param>
		/// <param name="Ydenom">The amount by which to divide the current vertical extent.</param>
		/// <param name="lpSize">
		///     A pointer to a <see cref="SIZE" /> structure that receives the previous window extents, in logical units. If <paramref name="lpSize" /> is NULL,
		///     this parameter is not used.
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>The window extents are modified as follows:</remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "ScaleWindowExtEx")]
		public static extern bool ScaleWindowExtEx([In] IntPtr hdc, int Xnum, int Xdenom, int Ynum, int Ydenom, IntPtr lpSize);

		/// <summary>
		///     The <see cref="GetViewportOrgEx" /> function retrieves the x-coordinates and y-coordinates of the viewport origin for the specified device
		///     context.
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <param name="lpPoint">
		///     A pointer to a <see cref="POINT" /> structure that receives the coordinates of the origin, in device units.
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "GetViewportOrgEx")]
		public static extern bool GetViewportOrgEx([In] IntPtr hdc, [Out] out POINT lpPoint);

		/// <summary>
		///     The <see cref="GetViewportExtEx" /> function retrieves the x-extent and y-extent of the current viewport for the specified device context.
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <param name="lpSize">
		///     A pointer to a <see cref="SIZE" /> structure that receives the x- and y-extents, in device units.
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "GetViewportExtEx")]
		public static extern bool GetViewportExtEx([In] IntPtr hdc, [Out] out SIZE lpSize);

		/// <summary>
		///     The <see cref="GetKerningPairs" /> function retrieves the character-kerning pairs for the currently selected font for the specified device
		///     context.
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <param name="nNumPairs">
		///     The number of pairs in the <paramref name="lpkrnpair" /> array. If the font has more than <paramref name="nNumPairs" /> kerning pairs, the
		///     function returns an error.
		/// </param>
		/// <param name="lpkrnpair">
		///     A pointer to an array of <see cref="KERNINGPAIR" /> structures that receives the kerning pairs. The array must contain at least as many
		///     structures as specified by the <paramref name="nNumPairs" /> parameter. If this parameter is NULL, the function returns the total number of
		///     kerning pairs for the font.
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is the number of kerning pairs returned.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		[DllImport("gdi32.dll", EntryPoint = "GetKerningPairs")]
		public static extern uint GetKerningPairs([In] IntPtr hdc, uint nNumPairs, out KERNINGPAIR[] lpkrnpair);

		/// <summary>
		///     The <see cref="GetGlyphOutline" /> function retrieves the outline or bitmap for a character in the TrueType font that is selected into the
		///     specified device context.
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <param name="uChar">The character for which data is to be returned.</param>
		/// <param name="uFormat">
		///     <para>The format of the data that the function retrieves. This parameter can be one of the following values.</para>
		///     <list type="table">
		///         <item>
		///             <term>GGO_BEZIER</term>
		///             <description>The function retrieves the curve data as a cubic Bézier spline (not in quadratic spline format).</description>
		///         </item>
		///         <item>
		///             <term>GGO_BITMAP</term>
		///             <description>The function retrieves the glyph bitmap. For information about memory allocation, see the following Remarks section.</description>
		///         </item>
		///         <item>
		///             <term>GGO_GLYPH_INDEX</term>
		///             <description>
		///                 Indicates that the <paramref name="uChar" /> parameter is a TrueType Glyph Index rather than a character code. See the
		///                 <see cref="ExtTextOut" /> function for additional remarks on Glyph Indexing.
		///             </description>
		///         </item>
		///         <item>
		///             <term>GGO_GRAY2_BITMAP</term>
		///             <description>The function retrieves a glyph bitmap that contains five levels of gray.</description>
		///         </item>
		///         <item>
		///             <term>GGO_GRAY4_BITMAP</term>
		///             <description>The function retrieves a glyph bitmap that contains 17 levels of gray.</description>
		///         </item>
		///         <item>
		///             <term>GGO_GRAY8_BITMAP</term>
		///             <description>The function retrieves a glyph bitmap that contains 65 levels of gray.</description>
		///         </item>
		///         <item>
		///             <term>GGO_METRICS</term>
		///             <description>
		///                 The function only retrieves the <see cref="GLYPHMETRICS" /> structure specified by <paramref name="lpgm" />. The
		///                 <paramref name="lpvBuffer" /> is ignored. This value affects the meaning of the function's return value upon failure; see the Return
		///                 Values section.
		///             </description>
		///         </item>
		///         <item>
		///             <term>GGO_NATIVE</term>
		///             <description>The function retrieves the curve data points in the rasterizer's native format and uses the font's design units.</description>
		///         </item>
		///         <item>
		///             <term>GGO_UNHINTED</term>
		///             <description>The function only returns unhinted outlines. This flag only works in conjunction with GGO_BEZIER and GGO_NATIVE.</description>
		///         </item>
		///     </list>
		///     <para>Note that, for the GGO_GRAYn_BITMAP values, the function retrieves a glyph bitmap that contains n^2+1 (n squared plus one) levels of gray.</para>
		/// </param>
		/// <param name="lpgm">
		///     A pointer to the <see cref="GLYPHMETRICS" /> structure describing the placement of the glyph in the character cell.
		/// </param>
		/// <param name="cbBuffer">
		///     The size, in bytes, of the buffer (*<paramref name="lpvBuffer" />) where the function is to copy information about the outline character. If this
		///     value is zero, the function returns the required size of the buffer.
		/// </param>
		/// <param name="lpvBuffer">
		///     A pointer to the buffer that receives information about the outline character. If this value is NULL, the function returns the required size of
		///     the buffer.
		/// </param>
		/// <param name="lpmat2">
		///     A pointer to a <see cref="MAT2" /> structure specifying a transformation matrix for the character.
		/// </param>
		/// <returns>
		///     <para>
		///         If GGO_BITMAP, GGO_GRAY2_BITMAP, GGO_GRAY4_BITMAP, GGO_GRAY8_BITMAP, or GGO_NATIVE is specified and the function succeeds, the return value
		///         is greater than zero; otherwise, the return value is GDI_ERROR. If one of these flags is specified and the buffer size or address is zero,
		///         the return value specifies the required buffer size, in bytes.
		///     </para>
		///     <para>If GGO_METRICS is specified and the function fails, the return value is GDI_ERROR.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         The glyph outline returned by the <see cref="GetGlyphOutline" /> function is for a grid-fitted glyph. (A grid-fitted glyph is a glyph that
		///         has been modified so that its bitmapped image conforms as closely as possible to the original design of the glyph.) If an application needs
		///         an unmodified glyph outline, it can request the glyph outline for a character in a font whose size is equal to the font's em unit. The value
		///         for a font's em unit is stored in the <see cref="OUTLINETEXTMETRIC.otmEMSquare" /> member of the <see cref="OUTLINETEXTMETRIC" /> structure.
		///     </para>
		///     <para>
		///         The glyph bitmap returned by <see cref="GetGlyphOutline" /> when GGO_BITMAP is specified is a DWORD-aligned, row-oriented, monochrome bitmap.
		///         When GGO_GRAY2_BITMAP is specified, the bitmap returned is a DWORD-aligned, row-oriented array of bytes whose values range from 0 to 4. When
		///         GGO_GRAY4_BITMAP is specified, the bitmap returned is a DWORD-aligned, row-oriented array of bytes whose values range from 0 to 16. When
		///         GGO_GRAY8_BITMAP is specified, the bitmap returned is a DWORD-aligned, row-oriented array of bytes whose values range from 0 to 64.
		///     </para>
		///     <para>
		///         The native buffer returned by <see cref="GetGlyphOutline" /> when GGO_NATIVE is specified is a glyph outline. A glyph outline is returned as
		///         a series of one or more contours defined by a <see cref="TTPOLYGONHEADER" /> structure followed by one or more curves. Each curve in the
		///         contour is defined by a <see cref="TTPOLYCURVE" /> structure followed by a number of <see cref="POINTFX" /> data points.
		///         <see cref="POINTFX" /> points are absolute positions, not relative moves. The starting point of a contour is given by the
		///         <see cref="TTPOLYGONHEADER.pfxStart" /> member of the <see cref="TTPOLYGONHEADER" /> structure. The starting point of each curve is the last
		///         point of the previous curve or the starting point of the contour. The count of data points in a curve is stored in the
		///         <see cref="TTPOLYCURVE.cpfx" /> member of
		///         <see cref="TTPOLYCURVE" /> structure. The size of each contour in the buffer, in bytes, is stored in the <see cref="TTPOLYGONHEADER.cb" />
		///         member of
		///         <see cref="TTPOLYGONHEADER" /> structure. Additional curve definitions are packed into the buffer following preceding curves and additional
		///         contours are packed into the buffer following preceding contours. The buffer contains as many contours as fit within the buffer returned by
		///         <see cref="GetGlyphOutline" />.
		///     </para>
		///     <para>
		///         The <see cref="GLYPHMETRICS" /> structure specifies the width of the character cell and the location of a glyph within the character cell.
		///         The origin of the character cell is located at the left side of the cell at the baseline of the font. The location of the glyph origin is
		///         relative to the character cell origin. The height of a character cell, the baseline, and other metrics global to the font are given by the
		///         <see cref="OUTLINETEXTMETRIC" /> structure.
		///     </para>
		///     <para>
		///         An application can alter the characters retrieved in bitmap or native format by specifying a 2-by-2 transformation matrix in the
		///         <paramref name="lpmat2" /> parameter. For example the glyph can be modified by shear, rotation, scaling, or any combination of the three
		///         using matrix multiplication.
		///     </para>
		///     <para>Additional information on a glyph outlines is located in the TrueType and the OpenType technical specifications.</para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "GetGlyphOutline")]
		public static extern uint GetGlyphOutline(
			[In] IntPtr hdc, uint uChar, uint uFormat, [Out] out GLYPHMETRICS lpgm, uint cbBuffer, IntPtr lpvBuffer, [In] ref MAT2 lpmat2);

		/// <summary>
		///     The <see cref="GetGlyphIndices" /> function translates a string into an array of glyph indices. The function can be used to determine whether a
		///     glyph exists in a font.
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <param name="lpstr">A pointer to the string to be converted.</param>
		/// <param name="c">
		///     The length of both the length of the string pointed to by <paramref name="lpstr" /> and the size (in WORDs) of the buffer pointed to by
		///     <paramref name="pgi" />.
		/// </param>
		/// <param name="pgi">
		///     This buffer must be of dimension c. On successful return, contains an array of glyph indices corresponding to the characters in the
		///     string.
		/// </param>
		/// <param name="fl">
		///     <para>Specifies how glyphs should be handled if they are not supported. This parameter can be the following value.</para>
		///     <list type="table">
		///         <item>
		///             <term>GGI_MARK_NONEXISTING_GLYPHS</term>
		///             <description>Marks unsupported glyphs with the hexadecimal value 0xffff.</description>
		///         </item>
		///     </list>
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, it returns the number of bytes (for the ANSI function) or WORDs (for the Unicode function) converted.</para>
		///     <para>If the function fails, the return value is GDI_ERROR.</para>
		/// </returns>
		/// <remarks>
		///     This function attempts to identify a single-glyph representation for each character in the string pointed to by <paramref name="lpstr" />. While
		///     this is useful for certain low-level purposes (such as manipulating font files), higher-level applications that wish to map a string to glyphs
		///     will typically wish to use the Uniscribe functions.
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "GetGlyphIndices")]
		public static extern uint GetGlyphIndices([In] IntPtr hdc, [In] string lpstr, int c, out ushort[] pgi, uint fl);

		/// <summary>
		///     The <see cref="GetDIBColorTable" /> function retrieves RGB (red, green, blue) color values from a range of entries in the color table of the DIB
		///     section bitmap that is currently selected into a specified device context.
		/// </summary>
		/// <param name="hdc">A handle to a device context. A DIB section bitmap must be selected into this device context.</param>
		/// <param name="uStartIndex">A zero-based color table index that specifies the first color table entry to retrieve.</param>
		/// <param name="cEntries">The number of color table entries to retrieve.</param>
		/// <param name="pColors">
		///     A pointer to a buffer that receives an array of <see cref="RGBQUAD" /> data structures containing color information from the DIB color table. The
		///     buffer must be large enough to contain as many <see cref="RGBQUAD" /> data structures as the value of <paramref name="cEntries" />.
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is the number of color table entries that the function retrieves.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     The <see cref="GetDIBColorTable" /> function should be called to retrieve the color table for DIB section bitmaps that use 1, 4, or 8 bpp. The
		///     <see cref="BITMAPINFOHEADER.biBitCount" /> member of a bitmap associated <see cref="BITMAPINFOHEADER" /> structure specifies the number of
		///     bits-per-pixel. DIB section bitmaps with a <see cref="BITMAPINFOHEADER.biBitCount" /> value greater than eight do not have a color table, but
		///     they do have associated color masks. Call the <see cref="GetObject" /> function to retrieve those color masks.
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "GetDIBColorTable")]
		public static extern uint GetDIBColorTable([In] IntPtr hdc, uint uStartIndex, uint cEntries, ref RGBQUAD[] pColors);

		/// <summary>
		///     The <see cref="GetCurrentObject" /> function retrieves a handle to an object of the specified type that has been selected into the specified
		///     device context (DC).
		/// </summary>
		/// <param name="hdc">A handle to the DC.</param>
		/// <param name="uObjectType">
		///     <para>The object type to be queried. This parameter can be one of the following values.</para>
		///     <list type="table">
		///         <item>
		///             <term>OBJ_BITMAP</term>
		///             <description>Returns the current selected bitmap.</description>
		///         </item>
		///         <item>
		///             <term>OBJ_BRUSH</term>
		///             <description>Returns the current selected brush.</description>
		///         </item>
		///         <item>
		///             <term>OBJ_COLORSPACE</term>
		///             <description>Returns the current color space.</description>
		///         </item>
		///         <item>
		///             <term>OBJ_FONT</term>
		///             <description>Returns the current selected font.</description>
		///         </item>
		///         <item>
		///             <term>OBJ_PAL</term>
		///             <description>Returns the current selected palette.</description>
		///         </item>
		///         <item>
		///             <term>OBJ_PEN</term>
		///             <description>Returns the current selected pen.</description>
		///         </item>
		///     </list>
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is a handle to the specified object.</para>
		///     <para>If the function fails, the return value is NULL.</para>
		/// </returns>
		/// <remarks>
		///     An application can use the <see cref="GetCurrentObject" /> and <see cref="GetObject" /> functions to retrieve descriptions of the graphic objects
		///     currently selected into the specified DC.
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "GetCurrentObject")]
		public static extern IntPtr GetCurrentObject([In] IntPtr hdc, uint uObjectType);

		/// <summary>
		///     The <see cref="GdiSetBatchLimit" /> function sets the maximum number of function calls that can be accumulated in the calling thread's current
		///     batch. The system flushes the current batch whenever this limit is exceeded.
		/// </summary>
		/// <param name="dwLimit">Specifies the batch limit to be set. A value of 0 sets the default limit. A value of 1 disables batching.</param>
		/// <returns>
		///     <para>If the function succeeds, the return value is the previous batch limit.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         Only GDI drawing functions that return Boolean values can be accumulated in the current batch; calls to any other GDI functions immediately
		///         flush the current batch. Exceeding the batch limit or calling the <see cref="GdiFlush" /> function also flushes the current batch.
		///     </para>
		///     <para>
		///         When the system accumulates a function call, the function returns TRUE to indicate it is in the batch. When the system flushes the current
		///         batch and executes the function for the second time, the return value is either TRUE or FALSE, depending on whether the function succeeds.
		///         This second return value is reported only if <see cref="GdiFlush" /> is used to flush the batch.
		///     </para>
		///     <para>
		///         Note: The batch limit is maintained for each thread separately. In order to completely disable batching, call
		///         <see cref="GdiSetBatchLimit" /> (1) during the initialization of each thread.
		///     </para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "GdiSetBatchLimit")]
		public static extern uint GdiSetBatchLimit(uint dwLimit);

		/// <summary>
		///     The <see cref="GdiGetBatchLimit" /> function returns the maximum number of function calls that can be accumulated in the calling thread's current
		///     batch. The system flushes the current batch whenever this limit is exceeded.
		/// </summary>
		/// <returns>
		///     <para>If the function succeeds, the return value is the batch limit.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         The batch limit is set by using the <see cref="GdiSetBatchLimit" /> function. Setting the limit to 1 effectively disables batching.
		///     </para>
		///     <para>
		///         Only GDI drawing functions that return Boolean values can be batched; calls to any other GDI functions immediately flush the current batch.
		///         Exceeding the batch limit or calling the <see cref="GdiFlush" /> function also flushes the current batch.
		///     </para>
		///     <para>
		///         When the system batches a function call, the function returns TRUE. The actual return value for the function is reported only if
		///         <see cref="GdiFlush" /> is used to flush the batch.
		///     </para>
		///     <para>
		///         Note:   The batch limit is maintained for each thread separately. In order to completely disable batching, call
		///         <see cref="GdiSetBatchLimit" /> (1) during the initialization of each thread.
		///     </para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "GdiGetBatchLimit")]
		public static extern uint GdiGetBatchLimit();

		/// <summary>
		///     The <see cref="ExtSelectClipRgn" /> function combines the specified region with the current clipping region using the specified mode.
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <param name="hrgn">A handle to the region to be selected. This handle must not be NULL unless the RGN_COPY mode is specified.</param>
		/// <param name="fnMode">
		///     <para>The operation to be performed. It must be one of the following values.</para>
		///     <list type="table">
		///         <item>
		///             <term>RGN_AND</term>
		///             <description>
		///                 The new clipping region combines the overlapping areas of the current clipping region and the region identified by
		///                 <paramref name="hrgn" />.
		///             </description>
		///         </item>
		///         <item>
		///             <term>RGN_COPY</term>
		///             <description>
		///                 The new clipping region is a copy of the region identified by <paramref name="hrgn" />. This is identical to
		///                 <see cref="SelectClipRgn" />. If the region identified by <paramref name="hrgn" /> is NULL, the new clipping region is the default
		///                 clipping region (the default clipping region is a null region).
		///             </description>
		///         </item>
		///         <item>
		///             <term>RGN_DIFF</term>
		///             <description>
		///                 The new clipping region combines the areas of the current clipping region with those areas excluded from the region identified by
		///                 <paramref name="hrgn" />.
		///             </description>
		///         </item>
		///         <item>
		///             <term>RGN_OR</term>
		///             <description>
		///                 The new clipping region combines the current clipping region and the region identified by <paramref name="hrgn" />.
		///             </description>
		///         </item>
		///         <item>
		///             <term>RGN_XOR</term>
		///             <description>
		///                 The new clipping region combines the current clipping region and the region identified by <paramref name="hrgn" /> but excludes any
		///                 overlapping areas.
		///             </description>
		///         </item>
		///     </list>
		/// </param>
		/// <returns>The return value specifies the new clipping region's complexity; it can be one of the following values.</returns>
		/// <remarks>
		///     <para>If an error occurs when this function is called, the previous clipping region for the specified device context is not affected.</para>
		///     <para>
		///         The <see cref="ExtSelectClipRgn" /> function assumes that the coordinates for the specified region are specified in device units.
		///     </para>
		///     <para>
		///         Only a copy of the region identified by the <paramref name="hrgn" /> parameter is used. The region itself can be reused after this call or it
		///         can be deleted.
		///     </para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "ExtSelectClipRgn")]
		public static extern int ExtSelectClipRgn([In] IntPtr hdc, [In] IntPtr hrgn, int fnMode);

		/// <summary>
		///     The <see cref="EnumICMProfiles" /> function enumerates the different output color profiles that the system supports for a given device context.
		/// </summary>
		/// <param name="hDC">Specifies the device context.</param>
		/// <param name="lpEnumICMProfilesFunc">
		///     Specifies the procedure instance address of a callback function defined by the application. (See <see cref="EnumICMProfilesProcCallback" />.)
		/// </param>
		/// <param name="lParam">Data supplied by the application that is passed to the callback function along with the color profile information.</param>
		/// <remarks>
		///     <para>
		///         The <see cref="EnumICMProfiles" /> function returns a list of profiles that are associated with a device context (DC), and whose settings
		///         match those of the DC. It is possible for a device context to contain device profiles that are not associated with particular hardware
		///         devices, or device profiles that do not match the settings of the DC. The sRGB profile is an example. The <see cref="SetICMProfile" />
		///         function is used to associate these types of profiles with a DC. The <see cref="GetICMProfile" /> function can be used to retrieve a profile
		///         that is not enumerated by the <see cref="EnumICMProfiles" /> function.
		///     </para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "EnumICMProfiles")]
		public static extern int EnumICMProfiles([In] IntPtr hDC, EnumICMProfilesProcCallback lpEnumICMProfilesFunc, [MarshalAs(UnmanagedType.SysInt)] int lParam);

		/// <summary>
		///     The <see cref="DeleteColorSpace" /> function removes and destroys a specified color space.
		/// </summary>
		/// <param name="hColorSpace">Specifies the handle to a color space to delete.</param>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "DeleteColorSpace")]
		public static extern bool DeleteColorSpace([In] IntPtr hColorSpace);

		/// <summary>
		///     The <see cref="CreateSolidBrush" /> function creates a logical brush that has the specified solid color.
		/// </summary>
		/// <param name="crColor">
		///     The color of the brush. To create a <see cref="COLORREF" /> color value, use the RGB macro.
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value identifies a logical brush.</para>
		///     <para>If the function fails, the return value is NULL.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         When you no longer need the HBRUSH object, call the <see cref="DeleteObject" /> function to delete it.
		///     </para>
		///     <para>A solid brush is a bitmap that the system uses to paint the interiors of filled shapes.</para>
		///     <para>
		///         After an application creates a brush by calling <see cref="CreateSolidBrush" />, it can select that brush into any device context by calling
		///         the <see cref="SelectObject" /> function.
		///     </para>
		///     <para>
		///         To paint with a system color brush, an application should use GetSysColorBrush (nIndex) instead of CreateSolidBrush(GetSysColor(nIndex)),
		///         because <see cref="User32.GetSysColorBrush" /> returns a cached brush instead of allocating a new one.
		///     </para>
		///     <para>
		///         ICM: No color management is done at brush creation. However, color management is performed when the brush is selected into an ICM-enabled
		///         device context.
		///     </para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "CreateSolidBrush")]
		public static extern IntPtr CreateSolidBrush(uint crColor);

		/// <summary>
		///     The <see cref="CreatePolygonRgn" /> function creates a polygonal region.
		/// </summary>
		/// <param name="lppt">
		///     A pointer to an array of <see cref="POINT" /> structures that define the vertices of the polygon in logical units. The polygon is presumed
		///     closed. Each vertex can be specified only once.
		/// </param>
		/// <param name="cPoints">The number of points in the array.</param>
		/// <param name="fnPolyFillMode">
		///     <para>The fill mode used to determine which pixels are in the region. This parameter can be one of the following values.</para>
		///     <list type="table">
		///         <item>
		///             <term>ALTERNATE</term>
		///             <description>Selects alternate mode (fills area between odd-numbered and even-numbered polygon sides on each scan line).</description>
		///         </item>
		///         <item>
		///             <term>WINDING</term>
		///             <description>Selects winding mode (fills any region with a nonzero winding value).</description>
		///         </item>
		///     </list>
		///     <para>
		///         For more information about these modes, see the <see cref="SetPolyFillMode" /> function.
		///     </para>
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is the handle to the region.</para>
		///     <para>If the function fails, the return value is NULL.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         When you no longer need the HRGN object, call the <see cref="DeleteObject" /> function to delete it.
		///     </para>
		///     <para>Region coordinates are represented as 27-bit signed integers.</para>
		///     <para>
		///         Regions created by the Create[Shape]Rgn methods (such as <see cref="CreateRectRgn" /> and <see cref="CreatePolygonRgn" />) only include the
		///         interior of the shape; the shape's outline is excluded from the region. This means that any point on a line between two sequential vertices
		///         is not included in the region. If you were to call <see cref="PtInRegion" /> for such a point, it would return zero as the result.
		///     </para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "CreatePolygonRgn")]
		public static extern IntPtr CreatePolygonRgn(
			[MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 1)] POINT[] lppt, int cPoints, int fnPolyFillMode);

		/// <summary>
		///     The <see cref="CreateHatchBrush" /> function creates a logical brush that has the specified hatch pattern and color.
		/// </summary>
		/// <param name="fnStyle">
		///     <para>The hatch style of the brush. This parameter can be one of the following values.</para>
		///     <list type="table">
		///         <item>
		///             <term>HS_BDIAGONAL</term>
		///             <description>45-degree upward left-to-right hatch</description>
		///         </item>
		///         <item>
		///             <term>HS_CROSS</term>
		///             <description>Horizontal and vertical crosshatch</description>
		///         </item>
		///         <item>
		///             <term>HS_DIAGCROSS</term>
		///             <description>45-degree crosshatch</description>
		///         </item>
		///         <item>
		///             <term>HS_FDIAGONAL</term>
		///             <description>45-degree downward left-to-right hatch</description>
		///         </item>
		///         <item>
		///             <term>HS_HORIZONTAL</term>
		///             <description>Horizontal hatch</description>
		///         </item>
		///         <item>
		///             <term>HS_VERTICAL</term>
		///             <description>Vertical hatch</description>
		///         </item>
		///     </list>
		/// </param>
		/// <param name="clrref">
		///     The foreground color of the brush that is used for the hatches. To create a <see cref="COLORREF" /> color value, use the RGB macro.
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value identifies a logical brush.</para>
		///     <para>If the function fails, the return value is NULL.</para>
		/// </returns>
		/// <remarks>
		///     <para>A brush is a bitmap that the system uses to paint the interiors of filled shapes.</para>
		///     <para>
		///         After an application creates a brush by calling <see cref="CreateHatchBrush" />, it can select that brush into any device context by calling
		///         the <see cref="SelectObject" /> function. It can also call <see cref="SetBkMode" /> to affect the rendering of the  brush.
		///     </para>
		///     <para>
		///         If an application uses a hatch brush to fill the backgrounds of both a parent and a child window with matching color, you must  set the brush
		///         origin before painting the background of the child window. You can do this by  calling the <see cref="SetBrushOrgEx" /> function. Your
		///         application can retrieve the current brush origin by calling the <see cref="GetBrushOrgEx" /> function.
		///     </para>
		///     <para>
		///         When you no longer need the brush, call the <see cref="DeleteObject" /> function to delete it.
		///     </para>
		///     <para>
		///         ICM: No color is defined  at brush creation. However, color management is performed when the brush is selected into an ICM-enabled device
		///         context.
		///     </para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "CreateHatchBrush")]
		public static extern IntPtr CreateHatchBrush(int fnStyle, uint clrref);

		/// <summary>
		///     The <see cref="CreateDIBSection" /> function creates a DIB that applications can write to directly. The function gives you a pointer to the
		///     location of the bitmap bit values. You can supply a handle to a file-mapping object that the function will use to create the bitmap, or you can
		///     let the system allocate the memory for the bitmap.
		/// </summary>
		/// <param name="hdc">
		///     A handle to a device context. If the value of <paramref name="iUsage" /> is DIB_PAL_COLORS, the function uses this device context's logical
		///     palette to initialize the DIB colors.
		/// </param>
		/// <param name="pbmi">
		///     A pointer to a <see cref="BITMAPINFO" /> structure that specifies various attributes of the DIB, including the bitmap dimensions and colors.
		/// </param>
		/// <param name="iUsage">
		///     <para>
		///         The type of data contained in the <see cref="BITMAPINFO.bmiColors" /> array member of the <see cref="BITMAPINFO" /> structure pointed to by
		///         <paramref name="pbmi" /> (either logical palette indexes or literal RGB values). The following values are defined.
		///     </para>
		///     <list type="table">
		///         <item>
		///             <term>DIB_PAL_COLORS</term>
		///             <description>
		///                 The <see cref="BITMAPINFO.bmiColors" /> member is an array of 16-bit indexes into the logical palette of the device context specified
		///                 by
		///                 <paramref name="hdc" />.
		///             </description>
		///         </item>
		///         <item>
		///             <term>DIB_RGB_COLORS</term>
		///             <description>
		///                 The <see cref="BITMAPINFO" /> structure contains an array of literal RGB values.
		///             </description>
		///         </item>
		///     </list>
		/// </param>
		/// <param name="ppvBits">A pointer to a variable that receives a pointer to the location of the DIB bit values.</param>
		/// <param name="hSection">
		///     <para>A handle to a file-mapping object that the function will use to create the DIB. This parameter can be NULL.</para>
		///     <para>
		///         If <paramref name="hSection" /> is not NULL, it must be a handle to a file-mapping object created by calling the CreateFileMapping function
		///         with the PAGE_READWRITE or PAGE_WRITECOPY flag. Read-only DIB sections are not supported. Handles created by other means will cause
		///         <see cref="CreateDIBSection" /> to fail.
		///     </para>
		///     <para>
		///         If <paramref name="hSection" /> is not NULL, the <see cref="CreateDIBSection" /> function locates the bitmap bit values at offset
		///         <paramref name="dwOffset" /> in the file-mapping object referred to by <paramref name="hSection" />. An application can later retrieve the
		///         <paramref name="hSection" /> handle by calling the <see cref="GetObject" /> function with the <see cref="BITMAP" /> returned by
		///         <see cref="CreateDIBSection" />.
		///     </para>
		///     <para>
		///         If <paramref name="hSection" /> is NULL, the system allocates memory for the DIB. In this case, the <see cref="CreateDIBSection" /> function
		///         ignores the <paramref name="dwOffset" /> parameter. An application cannot later obtain a handle to this memory. The dshSection member of the
		///         DIBSECTION structure filled in by calling the <see cref="GetObject" /> function will be NULL.
		///     </para>
		/// </param>
		/// <param name="dwOffset">
		///     The offset from the beginning of the file-mapping object referenced by <paramref name="hSection" /> where storage for the bitmap bit values is to
		///     begin. This value is ignored if <paramref name="hSection" /> is NULL. The bitmap bit values are aligned on double word boundaries, so
		///     <paramref name="dwOffset" /> must be a multiple of the size of a DWORD.
		/// </param>
		/// <returns>
		///     <para>
		///         If the function succeeds, the return value is a handle to the newly created DIB, and *<paramref name="ppvBits" /> points to the bitmap bit
		///         values.
		///     </para>
		///     <para>
		///         If the function fails, the return value is NULL, and *<paramref name="ppvBits" /> is NULL.
		///     </para>
		///     <para>This function can return the following value.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         As noted above, if <paramref name="hSection" /> is NULL, the system allocates memory for the DIB. The system closes the handle to that memory
		///         when you later delete the DIB by calling the <see cref="DeleteObject" /> function. If <paramref name="hSection" /> is not NULL, you must
		///         close the <paramref name="hSection" /> memory handle yourself after calling <see cref="DeleteObject" /> to delete the bitmap.
		///     </para>
		///     <para>You cannot paste a DIB section from one application into another application.</para>
		///     <para>
		///         <see cref="CreateDIBSection" /> does not use the <see cref="BITMAPINFOHEADER" /> parameters <see cref="BITMAPINFOHEADER.biXPelsPerMeter" />
		///         or
		///         <see cref="BITMAPINFOHEADER.biYPelsPerMeter" /> and will not provide resolution information in the <see cref="BITMAPINFO" /> structure.
		///     </para>
		///     <para>
		///         You need to guarantee that the GDI subsystem has completed any drawing to a bitmap created by <see cref="CreateDIBSection" /> before you draw
		///         to the bitmap yourself. Access to the bitmap must be synchronized. Do this by calling the <see cref="GdiFlush" /> function. This applies to
		///         any use of the pointer to the bitmap bit values, including passing the pointer in calls to functions such as <see cref="SetDIBits" />.
		///     </para>
		///     <para>ICM: No color management is done.</para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "CreateDIBSection")]
		public static extern IntPtr CreateDIBSection([In] IntPtr hdc, [In] ref BITMAPINFO pbmi, uint iUsage, ref IntPtr ppvBits, [In] IntPtr hSection, uint dwOffset);

		/// <summary>
		///     The <see cref="CopyEnhMetaFile" /> function copies the contents of an enhanced-format metafile to a specified file.
		/// </summary>
		/// <param name="hemfSrc">A handle to the enhanced metafile to be copied.</param>
		/// <param name="lpszFile">A pointer to the name of the destination file. If this parameter is NULL, the source metafile is copied to memory.</param>
		/// <returns>
		///     <para>If the function succeeds, the return value is a handle to the copy of the enhanced metafile.</para>
		///     <para>If the function fails, the return value is NULL.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         Where text arguments must use Unicode characters, use the <see cref="CopyEnhMetaFile" /> function as a wide-character function. Where text
		///         arguments must use characters from the Windows character set, use this function as an ANSI function.
		///     </para>
		///     <para>Applications can use metafiles stored in memory for temporary operations.</para>
		///     <para>
		///         When the application no longer needs the enhanced-metafile handle, it should delete the handle by calling the
		///         <see cref="DeleteEnhMetaFile" /> function.
		///     </para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "CopyEnhMetaFile")]
		public static extern IntPtr CopyEnhMetaFile([In] IntPtr hemfSrc, [In] string lpszFile);

		/// <summary>
		///     The <see cref="CombineTransform" /> function concatenates two world-space to page-space transformations.
		/// </summary>
		/// <param name="lpxformResult">
		///     A pointer to an <see cref="XFORM" /> structure that receives the combined transformation.
		/// </param>
		/// <param name="lpxform1">
		///     A pointer to an <see cref="XFORM" /> structure that specifies the first transformation.
		/// </param>
		/// <param name="lpxform2">
		///     A pointer to an <see cref="XFORM" /> structure that specifies the second transformation.
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     <para>Applying the combined transformation has the same effect as applying the first transformation and then applying the second transformation.</para>
		///     <para>
		///         The three transformations need not be distinct. For example, <paramref name="lpxform1" /> can point to the same <see cref="XFORM" />
		///         structure as <paramref name="lpxformResult" />.
		///     </para>
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "CombineTransform")]
		public static extern bool CombineTransform([Out] out XFORM lpxformResult, [In] ref XFORM lpxform1, [In] ref XFORM lpxform2);

		/// <summary>
		///     The <see cref="CloseEnhMetaFile" /> function closes an enhanced-metafile device context and returns a handle that identifies an enhanced-format
		///     metafile.
		/// </summary>
		/// <param name="hdc">Handle to an enhanced-metafile device context.</param>
		/// <returns>
		///     <para>If the function succeeds, the return value is a handle to an enhanced metafile.</para>
		///     <para>If the function fails, the return value is NULL.</para>
		/// </returns>
		/// <remarks>
		///     An application can use the enhanced-metafile handle returned by the <see cref="CloseEnhMetaFile" /> function to perform the following tasks:
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "CloseEnhMetaFile")]
		public static extern IntPtr CloseEnhMetaFile([In] IntPtr hdc);

		/// <summary>
		///     <para>
		///         The <see cref="AddFontResource" /> function adds the font resource from the specified file to the system font table. The font can
		///         subsequently be used for text output by any application.
		///     </para>
		///     <para>
		///         To mark a font as private or not enumerable, use the <see cref="AddFontResourceEx" /> function.
		///     </para>
		/// </summary>
		/// <param name="lpszFilename">
		///     <para>
		///         A pointer to a null-terminated character string that contains a valid font file name. This parameter can specify any of the following
		///         files.
		///     </para>
		///     <list type="table">
		///         <item>
		///             <term>.fon</term>
		///             <description>Font resource file.</description>
		///         </item>
		///         <item>
		///             <term>.fnt</term>
		///             <description>Raw bitmap font file.</description>
		///         </item>
		///         <item>
		///             <term>.ttf</term>
		///             <description>Raw TrueType file.</description>
		///         </item>
		///         <item>
		///             <term>.ttc</term>
		///             <description>East Asian Windows: TrueType font collection.</description>
		///         </item>
		///         <item>
		///             <term>.fot</term>
		///             <description>TrueType resource file.</description>
		///         </item>
		///         <item>
		///             <term>.otf</term>
		///             <description>PostScript OpenType font.</description>
		///         </item>
		///         <item>
		///             <term>.mmm</term>
		///             <description>Multiple master Type1 font resource file. It must be used with .pfm and .pfb files.</description>
		///         </item>
		///         <item>
		///             <term>.pfb</term>
		///             <description>Type 1 font bits file. It is used with a .pfm file.</description>
		///         </item>
		///         <item>
		///             <term>.pfm</term>
		///             <description>Type 1 font metrics file. It is used with a .pfb file.</description>
		///         </item>
		///     </list>
		///     <para>
		///         To add a font whose information comes from several resource files, have <paramref name="lpszFilename" /> point to a string with the file
		///         names separated by a "|" --for example, abcxxxxx.pfm | abcxxxxx.pfb.
		///     </para>
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value specifies the number of fonts added.</para>
		///     <para>If the function fails, the return value is zero. No extended error information is available.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         Any application that adds or removes fonts from the system font table should notify other windows of the change by sending a
		///         <see cref="WM.WM_FONTCHANGE" /> message to all top-level windows in the operating system. The application should send this message by calling
		///         the <see cref="User32.SendMessage" /> function and setting the hwnd parameter to HWND_BROADCAST.
		///     </para>
		///     <para>
		///         When an application no longer needs a font resource that it loaded by calling the <see cref="AddFontResource" /> function, it must remove
		///         that resource by calling the <see cref="RemoveFontResource" /> function.
		///     </para>
		///     <para>
		///         This function installs the font only for the current session. When the system restarts, the font will not be present. To have the font
		///         installed even after restarting the system, the font must be listed in the registry.
		///     </para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "AddFontResource")]
		public static extern int AddFontResource([In] string lpszFilename);

		/// <summary>
		///     The <see cref="UnrealizeObject" /> function resets the origin of a brush or resets a logical palette. If the <paramref name="hgdiobj" />
		///     parameter is a handle to a brush, <see cref="UnrealizeObject" /> directs the system to reset the origin of the brush the next time it is
		///     selected. If the <paramref name="hgdiobj" /> parameter is a handle to a logical palette, <see cref="UnrealizeObject" /> directs the system to
		///     realize the palette as though it had not previously been realized. The next time the application calls the <see cref="RealizePalette" /> function
		///     for the specified palette, the system completely remaps the logical palette to the system palette.
		/// </summary>
		/// <param name="hgdiobj">A handle to the logical palette to be reset.</param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         The <see cref="UnrealizeObject" /> function should not be used with stock objects. For example, the default palette, obtained by calling
		///         <see cref="GetStockObject" /> (DEFAULT_PALETTE), is a stock object.
		///     </para>
		///     <para>
		///         A palette identified by <paramref name="hgdiobj" /> can be the currently selected palette of a device context.
		///     </para>
		///     <para>
		///         If <paramref name="hgdiobj" /> is a brush, <see cref="UnrealizeObject" /> does nothing, and the function returns TRUE. Use
		///         <see cref="SetBrushOrgEx" /> to set the origin of a brush.
		///     </para>
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "UnrealizeObject")]
		public static extern bool UnrealizeObject([In] IntPtr hgdiobj);

		/// <summary>
		///     The <see cref="SetPolyFillMode" /> function sets the polygon fill mode for functions that fill polygons.
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <param name="iPolyFillMode">
		///     <para>The new fill mode. This parameter can be one of the following values.</para>
		///     <list type="table">
		///         <item>
		///             <term>ALTERNATE</term>
		///             <description>Selects alternate mode (fills the area between odd-numbered and even-numbered polygon sides on each scan line).</description>
		///         </item>
		///         <item>
		///             <term>WINDING</term>
		///             <description>Selects winding mode (fills any region with a nonzero winding value).</description>
		///         </item>
		///     </list>
		/// </param>
		/// <returns>The return value specifies the previous filling mode. If an error occurs, the return value is zero.</returns>
		/// <remarks>
		///     <para>
		///         In general, the modes differ only in cases where a complex, overlapping polygon must be filled (for example, a five-sided polygon that forms
		///         a five-pointed star with a pentagon in the center). In such cases, ALTERNATE mode fills every other enclosed region within the polygon (that
		///         is, the points of the star), but WINDING mode fills all regions (that is, the points and the pentagon).
		///     </para>
		///     <para>
		///         When the fill mode is ALTERNATE, GDI fills the area between odd-numbered and even-numbered polygon sides on each scan line. That is, GDI
		///         fills the area between the first and second side, between the third and fourth side, and so on.
		///     </para>
		///     <para>
		///         When the fill mode is WINDING, GDI fills any region that has a nonzero winding value. This value is defined as the number of times a pen used
		///         to draw the polygon would go around the region. The direction of each edge of the polygon is important.
		///     </para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "SetPolyFillMode")]
		public static extern int SetPolyFillMode([In] IntPtr hdc, int iPolyFillMode);

		/// <summary>
		///     The <see cref="SetGraphicsMode" /> function sets the graphics mode for the specified device context.
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <param name="iMode">
		///     <para>The graphics mode. This parameter can be one of the following values.</para>
		///     <list type="table">
		///         <item>
		///             <term>GM_COMPATIBLE</term>
		///             <description>
		///                 Sets the graphics mode that is compatible with 16-bit Windows. This is the default mode. If this value is specified, the application
		///                 can only modify the world-to-device transform by calling functions that set window and viewport extents and origins, but not by using
		///                 <see cref="SetWorldTransform" /> or <see cref="ModifyWorldTransform" />; calls to those functions will fail. Examples of functions
		///                 that set window and viewport extents and origins are <see cref="SetViewportExtEx" /> and <see cref="SetWindowExtEx" />.
		///             </description>
		///         </item>
		///         <item>
		///             <term>GM_ADVANCED</term>
		///             <description>
		///                 Sets the advanced graphics mode that allows world transformations. This value must be specified if the application will set or modify
		///                 the world transformation for the specified device context. In this mode all graphics, including text output, fully conform to the
		///                 world-to-device transformation specified in the device context.
		///             </description>
		///         </item>
		///     </list>
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is the old graphics mode.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>There are three areas in which graphics output differs according to the graphics mode:</remarks>
		[DllImport("gdi32.dll", EntryPoint = "SetGraphicsMode")]
		public static extern int SetGraphicsMode([In] IntPtr hdc, int iMode);

		/// <summary>
		///     <see cref="SetDCBrushColor" /> function sets the current device context (DC) brush color to the specified color value. If the device cannot
		///     represent the specified color value, the color is set to the nearest physical color.
		/// </summary>
		/// <param name="hdc">A handle to the DC.</param>
		/// <param name="crColor">The new brush color.</param>
		/// <returns>
		///     <para>
		///         If the function succeeds, the return value specifies the previous DC brush color as a <see cref="COLORREF" /> value.
		///     </para>
		///     <para>If the function fails, the return value is CLR_INVALID.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         When the stock DC_BRUSH is selected in a DC, all the subsequent drawings will be done using the DC brush color until the stock brush is
		///         deselected. The default DC_BRUSH color is WHITE.
		///     </para>
		///     <para>
		///         The function returns the previous DC_BRUSH color, even if the stock brush DC_BRUSH is not selected in the DC: however, this will not be used
		///         in drawing operations until the stock DC_BRUSH is selected in the DC.
		///     </para>
		///     <para>
		///         The <see cref="GetStockObject" /> function with an argument of DC_BRUSH or DC_PEN can be used interchangeably with the
		///         <see cref="SetDCPenColor" /> and <see cref="SetDCBrushColor" /> functions.
		///     </para>
		///     <para>ICM: Color management is performed if ICM is enabled.</para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "SetDCBrushColor")]
		public static extern uint SetDCBrushColor([In] IntPtr hdc, uint crColor);

		/// <summary>
		///     The <see cref="SetArcDirection" /> sets the drawing direction to be used for arc and rectangle functions.
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <param name="ArcDirection">
		///     <para>The new arc direction. This parameter can be one of the following values.</para>
		///     <list type="table">
		///         <item>
		///             <term>AD_COUNTERCLOCKWISE</term>
		///             <description>Figures drawn counterclockwise.</description>
		///         </item>
		///         <item>
		///             <term>AD_CLOCKWISE</term>
		///             <description>Figures drawn clockwise.</description>
		///         </item>
		///     </list>
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value specifies the old arc direction.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     <para>The default direction is counterclockwise.</para>
		///     <para>
		///         The <see cref="SetArcDirection" /> function specifies the direction in which the following functions draw:
		///     </para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "SetArcDirection")]
		public static extern int SetArcDirection([In] IntPtr hdc, int ArcDirection);

		/// <summary>
		///     The <see cref="PlayEnhMetaFile" /> function displays the picture stored in the specified enhanced-format metafile.
		/// </summary>
		/// <param name="hdc">A handle to the device context for the output device on which the picture will appear.</param>
		/// <param name="hemf">A handle to the enhanced metafile.</param>
		/// <param name="lpRect">
		///     A pointer to a <see cref="RECT" /> structure that contains the coordinates of the bounding rectangle used to display the picture. The coordinates
		///     are specified in logical units.
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         When an application calls the <see cref="PlayEnhMetaFile" /> function, the system uses the picture frame in the enhanced-metafile header to
		///         map the picture onto the rectangle pointed to by the <paramref name="lpRect" /> parameter. (This picture may be sheared or rotated by setting
		///         the world transform in the output device before calling <see cref="PlayEnhMetaFile" />.) Points along the edges of the rectangle are included
		///         in the picture.
		///     </para>
		///     <para>An enhanced-metafile picture can be clipped by defining the clipping region in the output device before playing the enhanced metafile.</para>
		///     <para>
		///         If an enhanced metafile contains an optional palette, an application can achieve consistent colors by setting up a color palette on the
		///         output device before calling <see cref="PlayEnhMetaFile" />. To retrieve the optional palette, use the
		///         <see cref="GetEnhMetaFilePaletteEntries" /> function.
		///     </para>
		///     <para>
		///         An enhanced metafile can be embedded in a newly created enhanced metafile by calling <see cref="PlayEnhMetaFile" /> and playing the source
		///         enhanced metafile into the device context for the new enhanced metafile.
		///     </para>
		///     <para>
		///         The states of the output device context are preserved by this function. Any object created but not deleted in the enhanced metafile is
		///         deleted by this function.
		///     </para>
		///     <para>
		///         To stop this function, an application can call the <see cref="CancelDC" /> function from another thread to terminate the operation. In this
		///         case, the function returns FALSE.
		///     </para>
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "PlayEnhMetaFile")]
		public static extern bool PlayEnhMetaFile([In] IntPtr hdc, [In] IntPtr hemf, [In] ref RECT lpRect);

		/// <summary>
		///     The <see cref="GetTextMetrics" /> function fills the specified buffer with the metrics for the currently selected font.
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <param name="lptm">
		///     A pointer to the <see cref="TEXTMETRIC" /> structure that receives the text metrics.
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     To determine whether a font is a TrueType font, first select it into a DC, then call <see cref="GetTextMetrics" />, and then check for
		///     TMPF_TRUETYPE in TEXTMETRIC.tmPitchAndFamily. Note that <see cref="User32.GetDC" /> returns an uninitialized DC, which has "System" (a bitmap
		///     font) as the default font; thus the need to select a font into the DC.
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "GetTextMetrics")]
		public static extern bool GetTextMetrics([In] IntPtr hdc, [Out] out TEXTMETRIC lptm);

		/// <summary>
		///     The <see cref="GetPolyFillMode" /> function retrieves the current polygon fill mode.
		/// </summary>
		/// <param name="hdc">Handle to the device context.</param>
		/// <returns>If the function succeeds, the return value specifies the polygon fill mode, which can be one of the following values.</returns>
		[DllImport("gdi32.dll", EntryPoint = "GetPolyFillMode")]
		public static extern int GetPolyFillMode([In] IntPtr hdc);

		/// <summary>
		///     The <see cref="GetNearestColor" /> function retrieves a color value identifying a color from the system palette that will be displayed when the
		///     specified color value is used.
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <param name="crColor">
		///     A color value that identifies a requested color. To create a <see cref="COLORREF" /> color value, use the RGB macro.
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value identifies a color from the system palette that corresponds to the given color value.</para>
		///     <para>If the function fails, the return value is CLR_INVALID.</para>
		/// </returns>
		[DllImport("gdi32.dll", EntryPoint = "GetNearestColor")]
		public static extern uint GetNearestColor([In] IntPtr hdc, uint crColor);

		/// <summary>
		///     The <see cref="GetGraphicsMode" /> function retrieves the current graphics mode for the specified device context.
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <returns>If the function succeeds, the return value is the current graphics mode. It can be one of the following values.</returns>
		/// <remarks>
		///     An application can set the graphics mode for a device context by calling the <see cref="SetGraphicsMode" /> function.
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "GetGraphicsMode")]
		public static extern int GetGraphicsMode([In] IntPtr hdc);

		/// <summary>
		///     The <see cref="GetEnhMetaFile" /> function creates a handle that identifies the enhanced-format metafile stored in the specified file.
		/// </summary>
		/// <param name="lpszMetaFile">A pointer to a null-terminated string that specifies the name of an enhanced metafile.</param>
		/// <returns>
		///     <para>If the function succeeds, the return value is a handle to the enhanced metafile.</para>
		///     <para>If the function fails, the return value is NULL.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         When the application no longer needs an enhanced-metafile handle, it should delete the handle by calling the <see cref="DeleteEnhMetaFile" />
		///         function.
		///     </para>
		///     <para>
		///         A Windows-format metafile must be converted to the enhanced format before it can be processed by the <see cref="GetEnhMetaFile" /> function.
		///         To convert the file, use the <see cref="SetWinMetaFileBits" /> function.
		///     </para>
		///     <para>
		///         Where text arguments must use Unicode characters, use this function as a wide-character function. Where text arguments must use characters
		///         from the Windows character set, use this function as an ANSI function.
		///     </para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "GetEnhMetaFile")]
		public static extern IntPtr GetEnhMetaFile([In] string lpszMetaFile);

		/// <summary>
		///     The <see cref="GetDCBrushColor" /> function retrieves the current brush color for the specified device context (DC).
		/// </summary>
		/// <param name="hdc">A handle to the DC whose brush color is to be returned.</param>
		/// <returns>
		///     <para>
		///         If the function succeeds, the return value is the <see cref="COLORREF" /> value for the current DC brush color.
		///     </para>
		///     <para>If the function fails, the return value is CLR_INVALID.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         For information on setting the brush color, see <see cref="SetDCBrushColor" />.
		///     </para>
		///     <para>ICM: Color management is performed if ICM is enabled.</para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "User32.GetDCBrushColor")]
		public static extern uint GetDCBrushColor([In] IntPtr hdc);

		/// <summary>
		///     The <see cref="GetCharWidth32" /> function retrieves the widths, in logical coordinates, of consecutive characters in a specified range from the
		///     current font.
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <param name="iFirstChar">The first character in the group of consecutive characters.</param>
		/// <param name="iLastChar">The last character in the group of consecutive characters, which must not precede the specified first character.</param>
		/// <param name="lpBuffer">A pointer to a buffer that receives the character widths, in logical coordinates.</param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         <see cref="GetCharWidth32" /> cannot be used on TrueType fonts. To retrieve character widths for TrueType fonts, use
		///         <see cref="GetCharABCWidths" />.
		///     </para>
		///     <para>
		///         The range is inclusive; that is, the returned widths include the widths of the characters specified by the <paramref name="iFirstChar" /> and
		///         <paramref name="iLastChar" /> parameters.
		///     </para>
		///     <para>If a character does not exist in the current font, it is assigned the width of the default character.</para>
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "GetCharWidth32")]
		public static extern bool GetCharWidth32([In] IntPtr hdc, uint iFirstChar, uint iLastChar, out int[] lpBuffer);

		/// <summary>
		///     The <see cref="GetArcDirection" /> function retrieves the current arc direction for the specified device context. Arc and rectangle functions use
		///     the arc direction.
		/// </summary>
		/// <param name="hdc">Handle to the device context.</param>
		/// <returns>The return value specifies the current arc direction; it can be any one of the following values:</returns>
		[DllImport("gdi32.dll", EntryPoint = "GetArcDirection")]
		public static extern int GetArcDirection([In] IntPtr hdc);

		/// <summary>
		///     The <see cref="ExtCreateRegion" /> function creates a region from the specified region and transformation data.
		/// </summary>
		/// <param name="lpXform">
		///     A pointer to an <see cref="XFORM" /> structure that defines the transformation to be performed on the region. If this pointer is NULL, the
		///     identity transformation is used.
		/// </param>
		/// <param name="nCount">
		///     The number of bytes pointed to by <paramref name="lpRgnData" />.
		/// </param>
		/// <param name="lpRgnData">
		///     A pointer to a <see cref="RGNDATA" /> structure that contains the region data in logical units.
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is the value of the region.</para>
		///     <para>If the function fails, the return value is NULL.</para>
		/// </returns>
		/// <remarks>
		///     <para>Region coordinates are represented as 27-bit signed integers.</para>
		///     <para>
		///         An application can retrieve data for a region by calling the <see cref="GetRegionData" /> function.
		///     </para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "ExtCreateRegion")]
		public static extern IntPtr ExtCreateRegion([In] ref XFORM lpXform, uint nCount, [In] ref RGNDATA lpRgnData);

		/// <summary>
		///     The <see cref="ExcludeClipRect" /> function creates a new clipping region that consists of the existing clipping region minus the specified
		///     rectangle.
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <param name="nLeftRect">The x-coordinate, in logical units, of the upper-left corner of the rectangle.</param>
		/// <param name="nTopRect">The y-coordinate, in logical units, of the upper-left corner of the rectangle.</param>
		/// <param name="nRightRect">The x-coordinate, in logical units, of the lower-right corner of the rectangle.</param>
		/// <param name="nBottomRect">The y-coordinate, in logical units, of the lower-right corner of the rectangle.</param>
		/// <returns>The return value specifies the new clipping region's complexity; it can be one of the following values.</returns>
		/// <remarks>The lower and right edges of the specified rectangle are not excluded from the clipping region.</remarks>
		[DllImport("gdi32.dll", EntryPoint = "ExcludeClipRect")]
		public static extern int ExcludeClipRect([In] IntPtr hdc, int nLeftRect, int nTopRect, int nRightRect, int nBottomRect);

		/// <summary>
		///     The <see cref="EnumEnhMetaFile" /> function enumerates the records within an enhanced-format metafile by retrieving each record and passing it to
		///     the specified callback function. The application-supplied callback function processes each record as required. The enumeration continues until
		///     the last record is processed or when the callback function returns zero.
		/// </summary>
		/// <param name="hdc">A handle to a device context. This handle is passed to the callback function.</param>
		/// <param name="hemf">A handle to an enhanced metafile.</param>
		/// <param name="lpEnhMetaFunc">
		///     A pointer to the application-supplied callback function. For more information, see the <see cref="EnhMetaFileProc" /> function.
		/// </param>
		/// <param name="lpData">A pointer to optional callback-function data.</param>
		/// <param name="lpRect">
		///     A pointer to a <see cref="RECT" /> structure that specifies the coordinates, in logical units, of the picture's upper-left and lower-right
		///     corners.
		/// </param>
		/// <returns>
		///     <para>If the callback function successfully enumerates all the records in the enhanced metafile, the return value is nonzero.</para>
		///     <para>If the callback function does not successfully enumerate all the records in the enhanced metafile, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         Points along the edge of the rectangle pointed to by the <paramref name="lpRect" /> parameter are included in the picture. If the
		///         <paramref name="hdc" /> parameter is NULL, the system ignores <paramref name="lpRect" />.
		///     </para>
		///     <para>
		///         If the callback function calls the <see cref="PlayEnhMetaFileRecord" /> function, <paramref name="hdc" /> must identify a valid device
		///         context. The system uses the device context's transformation and mapping mode to transform the picture displayed by the
		///         <see cref="PlayEnhMetaFileRecord" /> function.
		///     </para>
		///     <para>
		///         You can use the <see cref="EnumEnhMetaFile" /> function to embed one enhanced-metafile within another.
		///     </para>
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "EnumEnhMetaFile")]
		public static extern bool EnumEnhMetaFile([In] IntPtr hdc, [In] IntPtr hemf, EnhMetaFileProc lpEnhMetaFunc, [In] IntPtr lpData, [In] ref RECT lpRect);

		/// <summary>
		///     <para>
		///         The <see cref="CreateMetaFile" /> function creates a device context for a Windows-format metafile.
		///     </para>
		///     <para>
		///         Note:  This function is provided only for compatibility with Windows-format metafiles. Enhanced-format metafiles provide superior
		///         functionality and are recommended for new applications. The corresponding function for an enhanced-format metafile is
		///         <see cref="CreateEnhMetaFile" />.
		///     </para>
		/// </summary>
		/// <param name="lpszFile">
		///     A pointer to the file name for the Windows-format metafile to be created. If this parameter is NULL, the Windows-format metafile is memory based
		///     and its contents are lost when it is deleted by using the <see cref="DeleteMetaFile" /> function.
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is a handle to the device context for the Windows-format metafile.</para>
		///     <para>If the function fails, the return value is NULL.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         Where text arguments must use Unicode characters, use the <see cref="CreateMetaFile" /> function as a wide-character function. Where text
		///         arguments must use characters from the Windows character set, use this function as an ANSI function.
		///     </para>
		///     <para>
		///         <see cref="CreateMetaFile" /> is a Windows-format metafile function. This function supports only 16-bit Windows-based applications, which are
		///         listed in Windows-Format Metafiles. It does not record or play back GDI functions such as <see cref="PolyBezier" />, which were not part of
		///         16-bit Windows.
		///     </para>
		///     <para>
		///         The device context created by this function can be used to record GDI output functions in a Windows-format metafile. It cannot be used with
		///         GDI query functions such as <see cref="GetTextColor" />. When the device context is used with a GDI output function, the return value of that
		///         function becomes TRUE if the function is recorded and FALSE otherwise. When an object is selected by using the <see cref="SelectObject" />
		///         function, only a copy of the object is recorded. The object still belongs to the application.
		///     </para>
		///     <para>
		///         To create a scalable Windows-format metafile, record the graphics output in the MM_ANISOTROPIC mapping mode. The file cannot contain
		///         functions that modify the viewport origin and extents, nor can it contain device-dependent functions such as the <see cref="SelectClipRgn" />
		///         function. Once created, the Windows metafile can be scaled and rendered to any output device-format by defining the viewport origin and
		///         extents of the picture before playing it.
		///     </para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "CreateMetaFile")]
		public static extern IntPtr CreateMetaFile([In] string lpszFile);

		/// <summary>
		///     The <see cref="SetWindowOrgEx" /> function specifies which window point maps to the viewport origin (0,0).
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <param name="X">The x-coordinate, in logical units, of the new window origin.</param>
		/// <param name="Y">The y-coordinate, in logical units, of the new window origin.</param>
		/// <param name="lpPoint">
		///     A pointer to a <see cref="POINT" /> structure that receives the previous origin of the window, in logical units. If <paramref name="lpPoint" />
		///     is NULL, this parameter is not used.
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     This helps define the mapping from the logical coordinate space (also known as a window) to the device coordinate space (the viewport).
		///     <see cref="SetWindowOrgEx" /> specifies which logical point maps to the device point (0,0). It has the effect of shifting the axes so that the
		///     logical point (0,0) no longer refers to the upper-left corner.
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "SetWindowOrgEx")]
		public static extern bool SetWindowOrgEx([In] IntPtr hdc, int X, int Y, IntPtr lpPoint);

		/// <summary>
		///     The <see cref="SetWindowExtEx" /> function sets the horizontal and vertical extents of the window for a device context by using the specified
		///     values.
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <param name="nXExtent">The window's horizontal extent in logical units.</param>
		/// <param name="nYExtent">The window's vertical extent in logical units.</param>
		/// <param name="lpSize">
		///     A pointer to a <see cref="SIZE" /> structure that receives the previous window extents, in logical units. If <paramref name="lpSize" /> is NULL,
		///     this parameter is not used.
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         The window refers to the logical coordinate system of the page space. The extent is the maximum value of an axis. This function sets the
		///         maximum values for the horizontal and vertical axes of the window (in logical coordinates). When mapping between page space and device space,
		///         <see cref="SetViewportExtEx" /> and <see cref="SetWindowExtEx" /> determine the scaling factor between the window and the viewport. For more
		///         information, see Transformation of Coordinate Spaces.
		///     </para>
		///     <para>
		///         When the following mapping modes are set, calls to the <see cref="SetWindowExtEx" /> and <see cref="SetViewportExtEx" /> functions are
		///         ignored:
		///     </para>
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "SetWindowExtEx")]
		public static extern bool SetWindowExtEx([In] IntPtr hdc, int nXExtent, int nYExtent, IntPtr lpSize);

		/// <summary>
		///     <para>Applies to: desktop apps only</para>
		///     <para>
		///         The <see cref="SetPixelFormat" /> function sets the pixel format of the specified device context to the format specified by the
		///         <paramref name="iPixelFormat" /> index.
		///     </para>
		/// </summary>
		/// <param name="hdc">Specifies the device context whose pixel format the function attempts to set.</param>
		/// <param name="iPixelFormat">
		///     Index that identifies the pixel format to set. The various pixel formats supported by a device context are identified by
		///     one-based indexes.
		/// </param>
		/// <param name="ppfd">
		///     Pointer to a <see cref="PIXELFORMATDESCRIPTOR" /> structure that contains the logical pixel format specification. The system's metafile component
		///     uses this structure to record the logical pixel format specification. The structure has no other effect upon the behavior of the
		///     <see cref="SetPixelFormat" /> function.
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is TRUE.</para>
		///     <para>If the function fails, the return value is FALSE. To get extended error information, call GetLastError.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         If <paramref name="hdc" /> references a window, calling the <see cref="SetPixelFormat" /> function also changes the pixel format of the
		///         window. Setting the pixel format of a window more than once can lead to significant complications for the Window Manager and for multithread
		///         applications, so it is not allowed. An application can only set the pixel format of a window one time. Once a window's pixel format is set,
		///         it cannot be changed.
		///     </para>
		///     <para>
		///         You should select a pixel format in the device context before calling the wglCreateContext function. The wglCreateContext function creates a
		///         rendering context for drawing on the device in the selected pixel format of the device context.
		///     </para>
		///     <para>
		///         An OpenGL window has its own pixel format. Because of this, only device contexts retrieved for the client area of an OpenGL window are
		///         allowed to draw into the window. As a result, an OpenGL window should be created with the WS_CLIPCHILDREN and WS_CLIPSIBLINGS styles.
		///         Additionally, the window class attribute should not include the CS_PARENTDC style.
		///     </para>
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "SetPixelFormat")]
		public static extern bool SetPixelFormat([In] IntPtr hdc, int iPixelFormat, [In] ref PIXELFORMATDESCRIPTOR ppfd);

		/// <summary>
		///     The <see cref="SetMapperFlags" /> function alters the algorithm the font mapper uses when it maps logical fonts to physical fonts.
		/// </summary>
		/// <param name="hdc">A handle to the device context that contains the font-mapper flag.</param>
		/// <param name="dwFlag">
		///     Specifies whether the font mapper should attempt to match a font's aspect ratio to the current device's aspect ratio. If bit zero is set, the
		///     mapper selects only matching fonts.
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is the previous value of the font-mapper flag.</para>
		///     <para>If the function fails, the return value is GDI_ERROR.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         If the <paramref name="dwFlag" /> parameter is set and no matching fonts exist, Windows chooses a new aspect ratio and retrieves a font that
		///         matches this ratio.
		///     </para>
		///     <para>
		///         The remaining bits of the <paramref name="dwFlag" /> parameter must be zero.
		///     </para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "SetMapperFlags")]
		public static extern uint SetMapperFlags([In] IntPtr hdc, uint dwFlag);

		/// <summary>
		///     The <see cref="SetICMProfile" /> function sets a specified color profile as the output profile for a specified device context (DC).
		/// </summary>
		/// <param name="hDC">Specifies a device context in which to set the color profile.</param>
		/// <param name="lpFileName">Specifies the path name of the color profile to be set.</param>
		/// <remarks>
		///     <para>
		///         <see cref="SetICMProfile" /> associates a color profile with a device context. It becomes the output profile for that device context. The
		///         color profile does not have to be associated with any particular device. Device-independent profiles such as sRGB can also be used. If the
		///         color profile is not associated with a hardware device, it will be returned by <see cref="GetICMProfile" />, but not by
		///         <see cref="EnumICMProfiles" />.
		///     </para>
		///     <para>
		///         Note that under Windows 95 or later, the PostScript device driver for printers assumes a CMYK color model. Therefore, all PostScript printers
		///         must use a CMYK color profile. Windows 2000 does not have this limitation.
		///     </para>
		///     <para>
		///         <see cref="SetICMProfile" /> supports only RGB profiles in compatible DCs.
		///     </para>
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "SetICMProfile")]
		public static extern bool SetICMProfile([In] IntPtr hDC, [In] string lpFileName);

		/// <summary>
		///     The <see cref="SelectClipPath" /> function selects the current path as a clipping region for a device context, combining the new region with any
		///     existing clipping region using the specified mode.
		/// </summary>
		/// <param name="hdc">A handle to the device context of the path.</param>
		/// <param name="iMode">
		///     <para>The way to use the path. This parameter can be one of the following values.</para>
		///     <list type="table">
		///         <item>
		///             <term>RGN_AND</term>
		///             <description>The new clipping region includes the intersection (overlapping areas) of the current clipping region and the current path.</description>
		///         </item>
		///         <item>
		///             <term>RGN_COPY</term>
		///             <description>The new clipping region is the current path.</description>
		///         </item>
		///         <item>
		///             <term>RGN_DIFF</term>
		///             <description>The new clipping region includes the areas of the current clipping region with those of the current path excluded.</description>
		///         </item>
		///         <item>
		///             <term>RGN_OR</term>
		///             <description>The new clipping region includes the union (combined areas) of the current clipping region and the current path.</description>
		///         </item>
		///         <item>
		///             <term>RGN_XOR</term>
		///             <description>
		///                 The new clipping region includes the union of the current clipping region and the current path but without the overlapping
		///                 areas.
		///             </description>
		///         </item>
		///     </list>
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     The device context identified by the <paramref name="hdc" /> parameter must contain a closed path.
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "SelectClipPath")]
		public static extern bool SelectClipPath([In] IntPtr hdc, int iMode);

		/// <summary>
		///     The <see cref="RealizePalette" /> function maps palette entries from the current logical palette to the system palette.
		/// </summary>
		/// <param name="hdc">A handle to the device context into which a logical palette has been selected.</param>
		/// <returns>
		///     <para>If the function succeeds, the return value is the number of entries in the logical palette mapped to the system palette.</para>
		///     <para>If the function fails, the return value is GDI_ERROR.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         An application can determine whether a device supports palette operations by calling the <see cref="GetDeviceCaps" /> function and specifying
		///         the RASTERCAPS constant.
		///     </para>
		///     <para>
		///         The <see cref="RealizePalette" /> function modifies the palette for the device associated with the specified device context. If the device
		///         context is a memory DC, the color table for the bitmap selected into the DC is modified. If the device context is a display DC, the physical
		///         palette for that device is modified.
		///     </para>
		///     <para>
		///         A logical palette is a buffer between color-intensive applications and the system, allowing these applications to use as many colors as
		///         needed without interfering with colors displayed by other windows.
		///     </para>
		///     <para>
		///         When an application's window has the focus and it calls the <see cref="RealizePalette" /> function, the system attempts to realize as many of
		///         the requested colors as possible. The same is also true for applications with inactive windows.
		///     </para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "RealizePalette")]
		public static extern uint RealizePalette([In] IntPtr hdc);

		/// <summary>
		///     The <see cref="GetWindowOrgEx" /> function retrieves the x-coordinates and y-coordinates of the window origin for the specified device context.
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <param name="lpPoint">
		///     A pointer to a <see cref="POINT" /> structure that receives the coordinates, in logical units, of the window origin.
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "GetWindowOrgEx")]
		public static extern bool GetWindowOrgEx([In] IntPtr hdc, [Out] out POINT lpPoint);

		/// <summary>This function retrieves the x-extent and y-extent of the window for the specified device context.</summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <param name="lpSize">
		///     A pointer to a <see cref="SIZE" /> structure that receives the x- and y-extents in page-space units, that is, logical units.
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "GetWindowExtEx")]
		public static extern bool GetWindowExtEx([In] IntPtr hdc, [Out] out SIZE lpSize);

		/// <summary>
		///     <para>Retrieves a character set identifier for the font that is currently selected into a specified device context.</para>
		///     <para>
		///         A call to this function is equivalent to a call to <see cref="GetTextCharsetInfo" /> passing NULL for the data buffer.
		///     </para>
		/// </summary>
		/// <param name="hdc">Handle to a device context. The function obtains a character set identifier for the font that is selected into this device context.</param>
		/// <returns>
		///     If successful, returns a value identifying the character set of the font that is currently selected into the specified device context. The
		///     following character set identifiers are defined:
		/// </returns>
		[DllImport("gdi32.dll", EntryPoint = "GetTextCharset")]
		public static extern int GetTextCharset([In] IntPtr hdc);

		/// <summary>
		///     The <see cref="GetStockObject" /> function retrieves a handle to one of the stock pens, brushes, fonts, or palettes.
		/// </summary>
		/// <param name="fnObject">
		///     <para>The type of stock object. This parameter can be one of the following values.</para>
		///     <list type="table">
		///         <item>
		///             <term>BLACK_BRUSH</term>
		///             <description>Black brush.</description>
		///         </item>
		///         <item>
		///             <term>DKGRAY_BRUSH</term>
		///             <description>Dark gray brush.</description>
		///         </item>
		///         <item>
		///             <term>DC_BRUSH</term>
		///             <description>
		///                 Solid color brush. The default color is white. The color can be changed by using the <see cref="SetDCBrushColor" /> function. For
		///                 more information, see the Remarks section.
		///             </description>
		///         </item>
		///         <item>
		///             <term>GRAY_BRUSH</term>
		///             <description>Gray brush.</description>
		///         </item>
		///         <item>
		///             <term>HOLLOW_BRUSH</term>
		///             <description>Hollow brush (equivalent to NULL_BRUSH).</description>
		///         </item>
		///         <item>
		///             <term>LTGRAY_BRUSH</term>
		///             <description>Light gray brush.</description>
		///         </item>
		///         <item>
		///             <term>NULL_BRUSH</term>
		///             <description>Null brush (equivalent to HOLLOW_BRUSH).</description>
		///         </item>
		///         <item>
		///             <term>WHITE_BRUSH</term>
		///             <description>White brush.</description>
		///         </item>
		///         <item>
		///             <term>BLACK_PEN</term>
		///             <description>Black pen.</description>
		///         </item>
		///         <item>
		///             <term>DC_PEN</term>
		///             <description>
		///                 Solid pen color. The default color is white. The color can be changed by using the <see cref="SetDCPenColor" /> function. For more
		///                 information, see the Remarks section.
		///             </description>
		///         </item>
		///         <item>
		///             <term>NULL_PEN</term>
		///             <description>Null pen. The null pen draws nothing.</description>
		///         </item>
		///         <item>
		///             <term>WHITE_PEN</term>
		///             <description>White pen.</description>
		///         </item>
		///         <item>
		///             <term>ANSI_FIXED_FONT</term>
		///             <description>Windows fixed-pitch (monospace) system font.</description>
		///         </item>
		///         <item>
		///             <term>ANSI_VAR_FONT</term>
		///             <description>Windows variable-pitch (proportional space) system font.</description>
		///         </item>
		///         <item>
		///             <term>DEVICE_DEFAULT_FONT</term>
		///             <description>Device-dependent font.</description>
		///         </item>
		///         <item>
		///             <term>DEFAULT_GUI_FONT</term>
		///             <description>
		///                 <para>
		///                     Default font for user interface objects such as menus and dialog boxes. It is not recommended that you use DEFAULT_GUI_FONT or
		///                     SYSTEM_FONT to obtain the font used by dialogs and windows; for more information, see the remarks section.
		///                 </para>
		///                 <para>The default font is Tahoma.</para>
		///             </description>
		///         </item>
		///         <item>
		///             <term>OEM_FIXED_FONT</term>
		///             <description>Original equipment manufacturer (OEM) dependent fixed-pitch (monospace) font.</description>
		///         </item>
		///         <item>
		///             <term>SYSTEM_FONT</term>
		///             <description>
		///                 <para>
		///                     System font. By default, the system uses the system font to draw menus, dialog box controls, and text. It is not recommended that
		///                     you use DEFAULT_GUI_FONT or SYSTEM_FONT to obtain the font used by dialogs and windows; for more information, see the remarks
		///                     section.
		///                 </para>
		///                 <para>The default system font is Tahoma.</para>
		///             </description>
		///         </item>
		///         <item>
		///             <term>SYSTEM_FIXED_FONT</term>
		///             <description>
		///                 Fixed-pitch (monospace) system font. This stock object is provided only for compatibility with 16-bit Windows versions
		///                 earlier than 3.0.
		///             </description>
		///         </item>
		///         <item>
		///             <term>DEFAULT_PALETTE</term>
		///             <description>Default palette. This palette consists of the static colors in the system palette.</description>
		///         </item>
		///     </list>
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is a handle to the requested logical object.</para>
		///     <para>If the function fails, the return value is NULL.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         It is not recommended that you employ this method to obtain the current font used by dialogs and windows. Instead, use the
		///         <see cref="User32.SystemParametersInfo" /> function with the SPI_GETNONCLIENTMETRICS parameter to retrieve the current font.
		///         <see cref="User32.SystemParametersInfo" /> will take into account the current theme and provides font information for captions, menus, and
		///         message dialogs.
		///     </para>
		///     <para>
		///         Use the DKGRAY_BRUSH, GRAY_BRUSH, and LTGRAY_BRUSH stock objects only in windows with the CS_HREDRAW and CS_VREDRAW styles. Using a gray
		///         stock brush in any other style of window can lead to misalignment of brush patterns after a window is moved or sized. The origins of stock
		///         brushes cannot be adjusted.
		///     </para>
		///     <para>The HOLLOW_BRUSH and NULL_BRUSH stock objects are equivalent.</para>
		///     <para>
		///         It is not necessary (but it is not harmful) to delete stock objects by calling <see cref="DeleteObject" />.
		///     </para>
		///     <para>
		///         Both DC_BRUSH and DC_PEN can be used interchangeably with other stock objects like BLACK_BRUSH and BLACK_PEN. For information on retrieving
		///         the current pen or brush color, see <see cref="GetDCBrushColor" /> and <see cref="GetDCPenColor" />. See Setting the Pen or Brush Color for
		///         an example of setting colors. The <see cref="GetStockObject" /> function with an argument of DC_BRUSH or DC_PEN can be used interchangeably
		///         with the <see cref="SetDCPenColor" /> and <see cref="SetDCBrushColor" /> functions.
		///     </para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "GetStockObject")]
		public static extern IntPtr GetStockObject(int fnObject);

		/// <summary>
		///     <para>Applies to: desktop apps only</para>
		///     <para>
		///         The <see cref="GetPixelFormat" /> function obtains the index of the currently selected pixel format of the specified device context.
		///     </para>
		/// </summary>
		/// <param name="hdc">Specifies the device context of the currently selected pixel format index returned by the function.</param>
		/// <returns>
		///     <para>
		///         If the function succeeds, the return value is the currently selected pixel format index of the specified device context. This is a positive,
		///         one-based index value.
		///     </para>
		///     <para>If the function fails, the return value is zero. To get extended error information, call GetLastError.</para>
		/// </returns>
		[DllImport("gdi32.dll", EntryPoint = "GetPixelFormat")]
		public static extern int GetPixelFormat([In] IntPtr hdc);

		/// <summary>
		///     The <see cref="GetICMProfile" /> function retrieves the file name of the current output color profile for a specified device context.
		/// </summary>
		/// <param name="hDC">Specifies a device context from which to retrieve the color profile.</param>
		/// <param name="lpcbName">
		///     Pointer to a DWORD that contains the size of the buffer pointed to by <paramref name="lpszFilename" />. For the ANSI version of this function,
		///     the size is in bytes. For the Unicode version, the size is in WCHARs. If this function is successful, on return this parameter contains the size
		///     of the buffer actually used. However, if the buffer is not large enough, this function returns FALSE. In this case, the GetLastError function
		///     returns ERROR_INSUFFICIENT_BUFFER and the DWORD pointed to by this parameter contains the size needed for the <paramref name="lpszFilename" />
		///     buffer.
		/// </param>
		/// <param name="lpszFilename">Points to the buffer that receives the path name of the profile.</param>
		/// <remarks>
		///     <para>
		///         <see cref="GetICMProfile" /> obtains the file name of the current output profile regardless of whether or not color management is enabled for
		///         the device context.
		///     </para>
		///     <para>
		///         Given a device context, <see cref="GetICMProfile" /> will output, through the parameter <paramref name="lpszFilename" />, the path name of
		///         the file containing the color profile currently being used by the device context. It will also output, through the parameter
		///         <paramref name="lpcbName" />, the length of the string containing the path name.
		///     </para>
		///     <para>
		///         It is possible that the profile name returned by <see cref="GetICMProfile" /> will not be in the list of profiles returned by
		///         <see cref="EnumICMProfiles" />. The <see cref="EnumICMProfiles" /> function returns all color space profiles that are associated with a
		///         device context (DC) whose settings match that of the DC. If the <see cref="SetICMProfile" /> function is used to set the current profile, a
		///         profile may be associated with the DC that does not match its settings. For instance, the <see cref="SetICMProfile" /> function can be used
		///         to associate the device-independent sRGB profile with a DC. This profile will be used as the current WCS profile for that DC, and calls to
		///         <see cref="GetICMProfile" /> will return its file name. However, the profile will not appear in the list of profiles that is returned from
		///         <see cref="EnumICMProfiles" />.
		///     </para>
		///     <para>
		///         If this function is called before any calls to the <see cref="SetICMProfile" /> function, it can be used to get the default profile for a
		///         device context.
		///     </para>
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "GetICMProfile")]
		public static extern bool GetICMProfile([In] IntPtr hDC, ref uint lpcbName, [Out] StringBuilder lpszFilename);

		/// <summary>
		///     <para>
		///         The <see cref="DeleteMetaFile" /> function deletes a Windows-format metafile or Windows-format metafile handle.
		///     </para>
		///     <para>
		///         Note:  This function is provided only for compatibility with Windows-format metafiles. Enhanced-format metafiles provide superior
		///         functionality and are recommended for new applications. The corresponding function for an enhanced-format metafile is
		///         <see cref="DeleteEnhMetaFile" />.
		///     </para>
		/// </summary>
		/// <param name="hmf">A handle to a Windows-format metafile.</param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     If the metafile identified by the <paramref name="hmf" /> parameter is stored in memory (rather than on a disk), its content is lost when it is
		///     deleted by using the <see cref="DeleteMetaFile" /> function.
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "DeleteMetaFile")]
		public static extern bool DeleteMetaFile([In] IntPtr hmf);

		/// <summary>
		///     The <see cref="CreateDIBitmap" /> function creates a compatible bitmap (DDB) from a DIB and, optionally, sets the bitmap bits.
		/// </summary>
		/// <param name="hdc">A handle to a device context.</param>
		/// <param name="lpbmih">
		///     <para>A pointer to a bitmap information header structure, <see cref="BITMAPV5HEADER"/>.</para>
		///     <para>
		///         If <paramref name="fdwInit" /> is CBM_INIT, the function uses the bitmap information header structure to obtain the desired width and height
		///         of the bitmap as well as other information. Note that a positive value for the height indicates a bottom-up DIB while a negative value for
		///         the height indicates a top-down DIB. Calling <see cref="CreateDIBitmap" /> with <paramref name="fdwInit" /> as CBM_INIT is equivalent to
		///         calling the <see cref="CreateCompatibleBitmap" /> function to create a DDB in the format of the device and then calling the
		///         <see cref="SetDIBits" /> function to translate the DIB bits to the DDB.
		///     </para>
		/// </param>
		/// <param name="fdwInit">
		///     <para>Specifies how the system initializes the bitmap bits. The following value is defined.</para>
		///     <list type="table">
		///         <item>
		///             <term>CBM_INIT</term>
		///             <description>
		///                 <para>
		///                     If this flag is set, the system uses the data pointed to by the <paramref name="lpbInit" /> and <paramref name="lpbmi" />
		///                     parameters to initialize the bitmap bits.
		///                 </para>
		///                 <para>If this flag is clear, the data pointed to by those parameters is not used.</para>
		///             </description>
		///         </item>
		///     </list>
		///     <para>
		///         If <paramref name="fdwInit" /> is zero, the system does not initialize the bitmap bits.
		///     </para>
		/// </param>
		/// <param name="lpbInit">
		///     A pointer to an array of bytes containing the initial bitmap data. The format of the data depends on the
		///     <see cref="BITMAPINFOHEADER.biBitCount" /> member of the
		///     <see cref="BITMAPINFO" /> structure to which the <paramref name="lpbmi" /> parameter points.
		/// </param>
		/// <param name="lpbmi">
		///     A pointer to a <see cref="BITMAPINFO" /> structure that describes the dimensions and color format of the array pointed to by the
		///     <paramref name="lpbInit" /> parameter.
		/// </param>
		/// <param name="fuUsage">
		///     <para>
		///         Specifies whether the <see cref="BITMAPINFO.bmiColors" /> member of the <see cref="BITMAPINFO" /> structure was initialized and, if so,
		///         whether
		///         <see cref="BITMAPINFO.bmiColors" /> contains explicit red, green, blue (RGB) values or palette indexes. The <paramref name="fuUsage" />
		///         parameter must be one of the following values.
		///     </para>
		///     <list type="table">
		///         <item>
		///             <term>DIB_PAL_COLORS</term>
		///             <description>
		///                 A color table is provided and consists of an array of 16-bit indexes into the logical palette of the device context into which the
		///                 bitmap is to be selected.
		///             </description>
		///         </item>
		///         <item>
		///             <term>DIB_RGB_COLORS</term>
		///             <description>A color table is provided and contains literal RGB values.</description>
		///         </item>
		///     </list>
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is a handle to the compatible bitmap.</para>
		///     <para>If the function fails, the return value is NULL.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         The DDB that is created will be whatever bit depth your reference DC is. To create a bitmap that is of different bit depth, use
		///         <see cref="CreateDIBSection" />.
		///     </para>
		///     <para>
		///         For a device to reach optimal bitmap-drawing speed, specify <paramref name="fdwInit" /> as CBM_INIT. Then, use the same color depth DIB as
		///         the video mode. When the video is running 4- or 8-bpp, use DIB_PAL_COLORS.
		///     </para>
		///     <para>
		///         The CBM_CREATDIB flag for the <paramref name="fdwInit" /> parameter is no longer supported.
		///     </para>
		///     <para>
		///         When you no longer need the bitmap, call the <see cref="DeleteObject" /> function to delete it.
		///     </para>
		///     <para>ICM: No color management is performed. The contents of the resulting bitmap are not color matched after the bitmap has been created.</para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "CreateDIBitmap")]
		public static extern IntPtr CreateDIBitmap([In] IntPtr hdc, [In] BITMAPINFOHEADER lpbmih, uint fdwInit, [In] IntPtr lpbInit, [In] ref BITMAPINFO lpbmi, uint fuUsage);

		/// <summary>
		///     The <see cref="AnimatePalette" /> function replaces entries in the specified logical palette.
		/// </summary>
		/// <param name="hpal">A handle to the logical palette.</param>
		/// <param name="iStartIndex">The first logical palette entry to be replaced.</param>
		/// <param name="cEntries">The number of entries to be replaced.</param>
		/// <param name="ppe">
		///     A pointer to the first member in an array of <see cref="PALETTEENTRY" /> structures used to replace the current entries.
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         An application can determine whether a device supports palette operations by calling the <see cref="GetDeviceCaps" /> function and specifying
		///         the RASTERCAPS constant.
		///     </para>
		///     <para>
		///         The <see cref="AnimatePalette" /> function only changes entries with the PC_RESERVED flag set in the corresponding
		///         <see cref="LOGPALETTE.palPalEntry" />
		///         member of the <see cref="LOGPALETTE" /> structure.
		///     </para>
		///     <para>If the given palette is associated with the active window, the colors in the palette are replaced immediately.</para>
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "AnimatePalette")]
		public static extern bool AnimatePalette(
			[In] IntPtr hpal, uint iStartIndex, uint cEntries,
			[MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 2)] PALETTEENTRY[] ppe);

		/// <summary>
		///     The <see cref="StretchDIBits" /> function copies the color data for a rectangle of pixels in a DIB, JPEG, or PNG image to the specified
		///     destination rectangle. If the destination rectangle is larger than the source rectangle, this function stretches the rows and columns of color
		///     data to fit the destination rectangle. If the destination rectangle is smaller than the source rectangle, this function compresses the rows and
		///     columns by using the specified raster operation.
		/// </summary>
		/// <param name="hdc">A handle to the destination device context.</param>
		/// <param name="XDest">The x-coordinate, in logical units, of the upper-left corner of the destination rectangle.</param>
		/// <param name="YDest">The y-coordinate, in logical units, of the upper-left corner of the destination rectangle.</param>
		/// <param name="nDestWidth">The width, in logical units, of the destination rectangle.</param>
		/// <param name="nDestHeight">The height, in logical units, of the destination rectangle.</param>
		/// <param name="XSrc">The x-coordinate, in pixels, of the source rectangle in the image.</param>
		/// <param name="YSrc">The y-coordinate, in pixels, of the source rectangle in the image.</param>
		/// <param name="nSrcWidth">The width, in pixels, of the source rectangle in the image.</param>
		/// <param name="nSrcHeight">The height, in pixels, of the source rectangle in the image.</param>
		/// <param name="lpBits">A pointer to the image bits, which are stored as an array of bytes. For more information, see the Remarks section.</param>
		/// <param name="lpBitsInfo">
		///     A pointer to a <see cref="BITMAPINFO" /> structure that contains information about the DIB.
		/// </param>
		/// <param name="iUsage">
		///     <para>
		///         Specifies whether the <see cref="BITMAPINFO.bmiColors" /> member of the <see cref="BITMAPINFO" /> structure was provided and, if so, whether
		///         <see cref="BITMAPINFO.bmiColors" /> contains explicit red, green, blue (RGB) values or indexes. The <paramref name="iUsage" /> parameter must
		///         be one of the following values.
		///     </para>
		///     <list type="table">
		///         <item>
		///             <term>DIB_PAL_COLORS</term>
		///             <description>The array contains 16-bit indexes into the logical palette of the source device context.</description>
		///         </item>
		///         <item>
		///             <term>DIB_RGB_COLORS</term>
		///             <description>The color table contains literal RGB values.</description>
		///         </item>
		///     </list>
		///     <para>For more information, see the Remarks section.</para>
		/// </param>
		/// <param name="dwRop">
		///     A raster-operation code that specifies how the source pixels, the destination device context's current brush, and the destination pixels are to
		///     be combined to form the new image. For a list of some common raster operation codes, see <see cref="BitBlt" />.
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is the number of scan lines copied. Note that this value can be negative for mirrored content.</para>
		///     <para>If the function fails, or no scan lines are copied, the return value is 0.</para>
		///     <para>
		///         If the driver cannot support the JPEG or PNG file image passed to <see cref="StretchDIBits" />, the function will fail and return GDI_ERROR.
		///         If failure does occur, the application must fall back on its own JPEG or PNG support to decompress the image into a bitmap, and then pass the
		///         bitmap to <see cref="StretchDIBits" />.
		///     </para>
		/// </returns>
		/// <remarks>
		///     <para>The origin of a bottom-up DIB is the lower-left corner; the origin of a top-down DIB is the upper-left corner.</para>
		///     <para>
		///         <see cref="StretchDIBits" /> creates a mirror image of a bitmap if the signs of the <paramref name="nSrcWidth" /> and
		///         <paramref name="nDestWidth" /> parameters, or if the <paramref name="nSrcHeight" /> and <paramref name="nDestHeight" /> parameters differ. If
		///         <paramref name="nSrcWidth" /> and <paramref name="nDestWidth" /> have different signs, the function creates a mirror image of the bitmap
		///         along the x-axis. If <paramref name="nSrcHeight" /> and <paramref name="nDestHeight" /> have different signs, the function creates a mirror
		///         image of the bitmap along the y-axis.
		///     </para>
		///     <para>
		///         <see cref="StretchDIBits" /> creates a top-down image if the sign of the <see cref="BITMAPINFOHEADER.biHeight" /> member of the
		///         <see cref="BITMAPINFOHEADER" /> structure for the DIB is negative. For a code example, see Sizing a JPEG or PNG Image.
		///     </para>
		///     <para>This function allows a JPEG or PNG image to be passed as the source image. How each parameter is used remains the same, except:</para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "StretchDIBits")]
		public static extern int StretchDIBits(
			[In] IntPtr hdc, int XDest, int YDest, int nDestWidth, int nDestHeight, int XSrc, int YSrc, int nSrcWidth, int nSrcHeight, [In] IntPtr lpBits,
			[In] ref BITMAPINFO lpBitsInfo, uint iUsage, uint dwRop);

		/// <summary>
		///     The <see cref="SetMiterLimit" /> function sets the limit for the length of miter joins for the specified device context.
		/// </summary>
		/// <param name="hdc">Handle to the device context.</param>
		/// <param name="eNewLimit">Specifies the new miter limit for the device context.</param>
		/// <param name="peOldLimit">
		///     Pointer to a floating-point value that receives the previous miter limit. If this parameter is NULL, the previous miter
		///     limit is not returned.
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         The miter length is defined as the distance from the intersection of the line walls on the inside of the join to the intersection of the line
		///         walls on the outside of the join. The miter limit is the maximum allowed ratio of the miter length to the line width.
		///     </para>
		///     <para>The default miter limit is 10.0.</para>
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "SetMiterLimit")]
		public static extern bool SetMiterLimit([In] IntPtr hdc, float eNewLimit, IntPtr peOldLimit);

		/// <summary>
		///     <see cref="SetDCPenColor" /> function sets the current device context (DC) pen color to the specified color value. If the device cannot represent
		///     the specified color value, the color is set to the nearest physical color.
		/// </summary>
		/// <param name="hdc">A handle to the DC.</param>
		/// <param name="crColor">The new pen color.</param>
		/// <returns>
		///     If the function succeeds, the return value specifies the previous DC pen color as a <see cref="COLORREF" /> value. If the function fails, the
		///     return value is CLR_INVALID.
		/// </returns>
		/// <remarks>
		///     <para>
		///         The function returns the previous DC_PEN color, even if the stock pen DC_PEN is not selected in the DC; however, this will not be used in
		///         drawing operations until the stock DC_PEN is selected in the DC.
		///     </para>
		///     <para>
		///         The <see cref="GetStockObject" /> function with an argument of DC_BRUSH or DC_PEN can be used interchangeably with the
		///         <see cref="SetDCPenColor" /> and <see cref="SetDCBrushColor" /> functions.
		///     </para>
		///     <para>ICM: Color management is performed if ICM is enabled.</para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "SetDCPenColor")]
		public static extern uint SetDCPenColor([In] IntPtr hdc, uint crColor);

		/// <summary>
		///     The <see cref="SetColorSpace" /> function defines the input color space for a given device context.
		/// </summary>
		/// <param name="hDC">Specifies the handle to a device context.</param>
		/// <param name="hColorSpace">Identifies handle to the color space to set.</param>
		[DllImport("gdi32.dll", EntryPoint = "SetColorSpace")]
		public static extern IntPtr SetColorSpace([In] IntPtr hDC, [In] IntPtr hColorSpace);

		/// <summary>
		///     The <see cref="SetBrushOrgEx" /> function sets the brush origin that GDI assigns to the next brush an application selects into the specified
		///     device context.
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <param name="nXOrg">
		///     The x-coordinate, in device units, of the new brush origin. If this value is greater than the brush width, its value is reduced using the modulus
		///     operator (<paramref name="nXOrg" /> % brush width).
		/// </param>
		/// <param name="nYOrg">
		///     The y-coordinate, in device units, of the new brush origin. If this value is greater than the brush height, its value is reduced using the
		///     modulus operator (<paramref name="nYOrg" /> % brush height).
		/// </param>
		/// <param name="lppt">
		///     <para>
		///         A pointer to a <see cref="POINT" /> structure that receives the previous brush origin.
		///     </para>
		///     <para>This parameter can be NULL if the previous brush origin is not required.</para>
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     <para>A brush is a bitmap that the system uses to paint the interiors of filled shapes.</para>
		///     <para>
		///         The brush origin is a pair of coordinates specifying the location of one pixel in the bitmap. The default brush origin coordinates are (0,0).
		///         For horizontal coordinates, the value 0 corresponds to the leftmost column of pixels; the width corresponds to the rightmost column. For
		///         vertical coordinates, the value 0 corresponds to the uppermost row of pixels; the height corresponds to the lowermost row.
		///     </para>
		///     <para>
		///         The system automatically tracks the origin of all window-managed device contexts and adjusts their brushes as necessary to maintain an
		///         alignment of patterns on the surface. The brush origin that is set with this call is relative to the upper-left corner of the client area.
		///     </para>
		///     <para>
		///         An application should call <see cref="SetBrushOrgEx" /> after setting the bitmap stretching mode to HALFTONE by using
		///         <see cref="SetStretchBltMode" />. This must be done to avoid brush misalignment.
		///     </para>
		///     <para>
		///         The system automatically tracks the origin of all window-managed device contexts and adjusts their brushes as necessary to maintain an
		///         alignment of patterns on the surface.
		///     </para>
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "SetBrushOrgEx")]
		public static extern bool SetBrushOrgEx([In] IntPtr hdc, int nXOrg, int nYOrg, ref POINT lppt);

		/// <summary>
		///     The <see cref="SetBoundsRect" /> function controls the accumulation of bounding rectangle information for the specified device context. The
		///     system can maintain a bounding rectangle for all drawing operations. An application can examine and set this rectangle. The drawing boundaries
		///     are useful for invalidating bitmap caches.
		/// </summary>
		/// <param name="hdc">A handle to the device context for which to accumulate bounding rectangles.</param>
		/// <param name="lprcBounds">
		///     A pointer to a <see cref="RECT" /> structure used to set the bounding rectangle. Rectangle dimensions are in logical coordinates. This parameter
		///     can be NULL.
		/// </param>
		/// <param name="flags">
		///     <para>Specifies how the new rectangle will be combined with the accumulated rectangle. This parameter can be one of more of the following values.</para>
		///     <list type="table">
		///         <item>
		///             <term>DCB_ACCUMULATE</term>
		///             <description>
		///                 Adds the rectangle specified by the <paramref name="lprcBounds" /> parameter to the bounding rectangle (using a rectangle union
		///                 operation). Using both DCB_RESET and DCB_ACCUMULATE sets the bounding rectangle to the rectangle specified by the
		///                 <paramref name="lprcBounds" /> parameter.
		///             </description>
		///         </item>
		///         <item>
		///             <term>DCB_DISABLE</term>
		///             <description>Turns off boundary accumulation.</description>
		///         </item>
		///         <item>
		///             <term>DCB_ENABLE</term>
		///             <description>Turns on boundary accumulation, which is disabled by default.</description>
		///         </item>
		///         <item>
		///             <term>DCB_RESET</term>
		///             <description>Clears the bounding rectangle.</description>
		///         </item>
		///     </list>
		/// </param>
		/// <returns>
		///     If the function succeeds, the return value specifies the previous state of the bounding rectangle. This state can be a combination of the
		///     following values.
		/// </returns>
		/// <remarks>
		///     The DCB_SET value is a combination of the bit values DCB_ACCUMULATE and DCB_RESET. Applications that check the DCB_RESET bit to determine whether
		///     the bounding rectangle is empty must also check the DCB_ACCUMULATE bit. The bounding rectangle is empty only if the DCB_RESET bit is 1 and the
		///     DCB_ACCUMULATE bit is 0.
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "SetBoundsRect")]
		public static extern uint SetBoundsRect([In] IntPtr hdc, [In] IntPtr lprcBounds, uint flags);

		/// <summary>
		///     <para>
		///         The <see cref="SetBitmapBits" /> function sets the bits of color data for a bitmap to the specified values.
		///     </para>
		///     <para>
		///         Note:   This function is provided only for compatibility with 16-bit versions of Windows. Applications should use the
		///         <see cref="SetDIBits" /> function.
		///     </para>
		/// </summary>
		/// <param name="hbmp">A handle to the bitmap to be set. This must be a compatible bitmap (DDB).</param>
		/// <param name="cBytes">
		///     The number of bytes pointed to by the <paramref name="lpBits" /> parameter.
		/// </param>
		/// <param name="lpBits">A pointer to an array of bytes that contain color data for the specified bitmap.</param>
		/// <returns>
		///     <para>If the function succeeds, the return value is the number of bytes used in setting the bitmap bits.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     The array identified by <paramref name="lpBits" /> must be WORD aligned.
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "SetBitmapBits")]
		public static extern int SetBitmapBits([In] IntPtr hbmp, uint cBytes, [In] IntPtr lpBits);

		/// <summary>
		///     The <see cref="SelectPalette" /> function selects the specified logical palette into a device context.
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <param name="hpal">A handle to the logical palette to be selected.</param>
		/// <param name="bForceBackground">
		///     <para>
		///         Specifies whether the logical palette is forced to be a background palette. If this value is TRUE, the <see cref="RealizePalette" /> function
		///         causes the logical palette to be mapped to the colors already in the physical palette in the best possible way. This is always done, even if
		///         the window for which the palette is realized belongs to a thread without active focus.
		///     </para>
		///     <para>
		///         If this value is FALSE, <see cref="RealizePalette" /> causes the logical palette to be copied into the device palette when the application is
		///         in the foreground. (If the <paramref name="hdc" /> parameter is a memory device context, this parameter is ignored.)
		///     </para>
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is a handle to the device context's previous logical palette.</para>
		///     <para>If the function fails, the return value is NULL.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         An application can determine whether a device supports palette operations by calling the <see cref="GetDeviceCaps" /> function and specifying
		///         the RASTERCAPS constant.
		///     </para>
		///     <para>
		///         An application can select a logical palette into more than one device context only if device contexts are compatible. Otherwise
		///         <see cref="SelectPalette" /> fails. To create a device context that is compatible with another device context, call
		///         <see cref="CreateCompatibleDC" /> with the first device context as the parameter. If a logical palette is selected into more than one device
		///         context, changes to the logical palette will affect all device contexts for which it is selected.
		///     </para>
		///     <para>
		///         An application might call the <see cref="SelectPalette" /> function with the <paramref name="bForceBackground" /> parameter set to TRUE if
		///         the child windows of a top-level window each realize their own palettes. However, only the child window that needs to realize its palette
		///         must set <paramref name="bForceBackground" /> to TRUE; other child windows must set this value to FALSE.
		///     </para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "SelectPalette")]
		public static extern IntPtr SelectPalette([In] IntPtr hdc, [In] IntPtr hpal, [MarshalAs(UnmanagedType.Bool)] bool bForceBackground);

		/// <summary>
		///     The <see cref="SelectClipRgn" /> function selects a region as the current clipping region for the specified device context.
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <param name="hrgn">A handle to the region to be selected.</param>
		/// <returns>The return value specifies the region's complexity and can be one of the following values.</returns>
		/// <remarks>
		///     <para>Only a copy of the selected region is used. The region itself can be selected for any number of other device contexts or it can be deleted.</para>
		///     <para>
		///         The <see cref="SelectClipRgn" /> function assumes that the coordinates for a region are specified in device units.
		///     </para>
		///     <para>To remove a device-context's clipping region, specify a NULL region handle.</para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "SelectClipRgn")]
		public static extern int SelectClipRgn([In] IntPtr hdc, [In] IntPtr hrgn);

		/// <summary>
		///     The <see cref="ResizePalette" /> function increases or decreases the size of a logical palette based on the specified value.
		/// </summary>
		/// <param name="hpal">A handle to the palette to be changed.</param>
		/// <param name="nEntries">
		///     <para>The number of entries in the palette after it has been resized.</para>
		///     <para>The number of entries is limited to 1024.</para>
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         An application can determine whether a device supports palette operations by calling the <see cref="GetDeviceCaps" /> function and specifying
		///         the RASTERCAPS constant.
		///     </para>
		///     <para>
		///         If an application calls <see cref="ResizePalette" /> to reduce the size of the palette, the entries remaining in the resized palette are
		///         unchanged. If the application calls <see cref="ResizePalette" /> to enlarge the palette, the additional palette entries are set to black (the
		///         red, green, and blue values are all 0) and their flags are set to zero.
		///     </para>
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "ResizePalette")]
		public static extern bool ResizePalette([In] IntPtr hpal, uint nEntries);

		/// <summary>
		///     The <see cref="OffsetClipRgn" /> function moves the clipping region of a device context by the specified offsets.
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <param name="nXOffset">The number of logical units to move left or right.</param>
		/// <param name="nYOffset">The number of logical units to move up or down.</param>
		/// <returns>The return value specifies the new region's complexity and can be one of the following values.</returns>
		[DllImport("gdi32.dll", EntryPoint = "OffsetClipRgn")]
		public static extern int OffsetClipRgn([In] IntPtr hdc, int nXOffset, int nYOffset);

		/// <summary>
		///     The <see cref="GetRegionData" /> function fills the specified buffer with data describing a region. This data includes the dimensions of the
		///     rectangles that make up the region.
		/// </summary>
		/// <param name="hRgn">A handle to the region.</param>
		/// <param name="dwCount">
		///     The size, in bytes, of the <paramref name="lpRgnData" /> buffer.
		/// </param>
		/// <param name="lpRgnData">
		///     A pointer to a <see cref="RGNDATA" /> structure that receives the information. The dimensions of the region are in logical units. If this
		///     parameter is NULL, the return value contains the number of bytes needed for the region data.
		/// </param>
		/// <returns>
		///     <para>
		///         If the function succeeds and <paramref name="dwCount" /> specifies an adequate number of bytes, the return value is always
		///         <paramref name="dwCount" />. If <paramref name="dwCount" /> is too small or the function fails, the return value is 0. If
		///         <paramref name="lpRgnData" /> is NULL, the return value is the required number of bytes.
		///     </para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     The <see cref="GetRegionData" /> function is used in conjunction with the <see cref="ExtCreateRegion" /> function.
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "GetRegionData")]
		public static extern uint GetRegionData([In] IntPtr hRgn, uint dwCount, IntPtr lpRgnData);

		/// <summary>
		///     The <see cref="GetObjectType" /> retrieves the type of the specified object.
		/// </summary>
		/// <param name="h">A handle to the graphics object.</param>
		/// <returns>If the function succeeds, the return value identifies the object. This value can be one of the following.</returns>
		[DllImport("gdi32.dll", EntryPoint = "GetObjectType")]
		public static extern uint GetObjectType([In] IntPtr h);

		/// <summary>
		///     The <see cref="GetMiterLimit" /> function retrieves the miter limit for the specified device context.
		/// </summary>
		/// <param name="hdc">Handle to the device context.</param>
		/// <param name="peLimit">Pointer to a floating-point value that receives the current miter limit.</param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>The miter limit is used when drawing geometric lines that have miter joins.</remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "GetMiterLimit")]
		public static extern bool GetMiterLimit([In] IntPtr hdc, [Out] out float peLimit);

		/// <summary>
		///     The <see cref="GetDeviceCaps" /> function retrieves device-specific information for the specified device.
		/// </summary>
		/// <param name="hdc">A handle to the DC.</param>
		/// <param name="nIndex">
		///     <para>The item to be returned. This parameter can be one of the following values.</para>
		///     <list type="table">
		///         <item>
		///             <term>DRIVERVERSION</term>
		///             <description>The device driver version.</description>
		///         </item>
		///         <item>
		///             <term>TECHNOLOGY</term>
		///             <description>
		///                 <para>Device technology. It can be any one of the following values.</para>
		///                 <para>
		///                     If the <paramref name="hdc" /> parameter is a handle to the DC of an enhanced metafile, the device technology is that of the
		///                     referenced device as specified to the <see cref="CreateEnhMetaFile" /> function. To determine whether it is an enhanced metafile
		///                     DC, use the <see cref="GetObjectType" /> function.
		///                 </para>
		///             </description>
		///         </item>
		///         <item>
		///             <term>HORZSIZE</term>
		///             <description>Width, in millimeters, of the physical screen.</description>
		///         </item>
		///         <item>
		///             <term>VERTSIZE</term>
		///             <description>Height, in millimeters, of the physical screen.</description>
		///         </item>
		///         <item>
		///             <term>HORZRES</term>
		///             <description>Width, in pixels, of the screen; or for printers, the width, in pixels, of the printable area of the page.</description>
		///         </item>
		///         <item>
		///             <term>VERTRES</term>
		///             <description>Height, in raster lines, of the screen; or for printers, the height, in pixels, of the printable area of the page.</description>
		///         </item>
		///         <item>
		///             <term>LOGPIXELSX</term>
		///             <description>
		///                 Number of pixels per logical inch along the screen width. In a system with multiple display monitors, this value is the same
		///                 for all monitors.
		///             </description>
		///         </item>
		///         <item>
		///             <term>LOGPIXELSY</term>
		///             <description>
		///                 Number of pixels per logical inch along the screen height. In a system with multiple display monitors, this value is the
		///                 same for all monitors.
		///             </description>
		///         </item>
		///         <item>
		///             <term>BITSPIXEL</term>
		///             <description>Number of adjacent color bits for each pixel.</description>
		///         </item>
		///         <item>
		///             <term>PLANES</term>
		///             <description>Number of color planes.</description>
		///         </item>
		///         <item>
		///             <term>NUMBRUSHES</term>
		///             <description>Number of device-specific brushes.</description>
		///         </item>
		///         <item>
		///             <term>NUMPENS</term>
		///             <description>Number of device-specific pens.</description>
		///         </item>
		///         <item>
		///             <term>NUMFONTS</term>
		///             <description>Number of device-specific fonts.</description>
		///         </item>
		///         <item>
		///             <term>NUMCOLORS</term>
		///             <description>
		///                 Number of entries in the device's color table, if the device has a color depth of no more than 8 bits per pixel. For devices with
		///                 greater color depths, 1 is returned.
		///             </description>
		///         </item>
		///         <item>
		///             <term>ASPECTX</term>
		///             <description>Relative width of a device pixel used for line drawing.</description>
		///         </item>
		///         <item>
		///             <term>ASPECTY</term>
		///             <description>Relative height of a device pixel used for line drawing.</description>
		///         </item>
		///         <item>
		///             <term>ASPECTXY</term>
		///             <description>Diagonal width of the device pixel used for line drawing.</description>
		///         </item>
		///         <item>
		///             <term>PDEVICESIZE</term>
		///             <description>Reserved.</description>
		///         </item>
		///         <item>
		///             <term>CLIPCAPS</term>
		///             <description>
		///                 Flag that indicates the clipping capabilities of the device. If the device can clip to a rectangle, it is 1. Otherwise, it
		///                 is 0.
		///             </description>
		///         </item>
		///         <item>
		///             <term>SIZEPALETTE</term>
		///             <description>
		///                 Number of entries in the system palette. This index is valid only if the device driver sets the RC_PALETTE bit in the RASTERCAPS
		///                 index and is available only if the driver is compatible with 16-bit Windows.
		///             </description>
		///         </item>
		///         <item>
		///             <term>NUMRESERVED</term>
		///             <description>
		///                 Number of reserved entries in the system palette. This index is valid only if the device driver sets the RC_PALETTE bit in the
		///                 RASTERCAPS index and is available only if the driver is compatible with 16-bit Windows.
		///             </description>
		///         </item>
		///         <item>
		///             <term>COLORRES</term>
		///             <description>
		///                 Actual color resolution of the device, in bits per pixel. This index is valid only if the device driver sets the RC_PALETTE bit in
		///                 the RASTERCAPS index and is available only if the driver is compatible with 16-bit Windows.
		///             </description>
		///         </item>
		///         <item>
		///             <term>PHYSICALWIDTH</term>
		///             <description>
		///                 For printing devices: the width of the physical page, in device units. For example, a printer set to print at 600 dpi on 8.5-x11-inch
		///                 paper has a physical width value of 5100 device units. Note that the physical page is almost always greater than the printable area
		///                 of the page, and never smaller.
		///             </description>
		///         </item>
		///         <item>
		///             <term>PHYSICALHEIGHT</term>
		///             <description>
		///                 For printing devices: the height of the physical page, in device units. For example, a printer set to print at 600 dpi on
		///                 8.5-by-11-inch paper has a physical height value of 6600 device units. Note that the physical page is almost always greater than the
		///                 printable area of the page, and never smaller.
		///             </description>
		///         </item>
		///         <item>
		///             <term>PHYSICALOFFSETX</term>
		///             <description>
		///                 For printing devices: the distance from the left edge of the physical page to the left edge of the printable area, in device units.
		///                 For example, a printer set to print at 600 dpi on 8.5-by-11-inch paper, that cannot print on the leftmost 0.25-inch of paper, has a
		///                 horizontal physical offset of 150 device units.
		///             </description>
		///         </item>
		///         <item>
		///             <term>PHYSICALOFFSETY</term>
		///             <description>
		///                 For printing devices: the distance from the top edge of the physical page to the top edge of the printable area, in device units. For
		///                 example, a printer set to print at 600 dpi on 8.5-by-11-inch paper, that cannot print on the topmost 0.5-inch of paper, has a
		///                 vertical physical offset of 300 device units.
		///             </description>
		///         </item>
		///         <item>
		///             <term>VREFRESH</term>
		///             <description>
		///                 <para>For display devices: the current vertical refresh rate of the device, in cycles per second (Hz).</para>
		///                 <para>
		///                     A vertical refresh rate value of 0 or 1 represents the display hardware's default refresh rate. This default rate is typically
		///                     set by switches on a display card or computer motherboard, or by a configuration program that does not use display functions such
		///                     as <see cref="User32.ChangeDisplaySettings" />.
		///                 </para>
		///             </description>
		///         </item>
		///         <item>
		///             <term>SCALINGFACTORX</term>
		///             <description>Scaling factor for the x-axis of the printer.</description>
		///         </item>
		///         <item>
		///             <term>SCALINGFACTORY</term>
		///             <description>Scaling factor for the y-axis of the printer.</description>
		///         </item>
		///         <item>
		///             <term>BLTALIGNMENT</term>
		///             <description>
		///                 Preferred horizontal drawing alignment, expressed as a multiple of pixels. For best drawing performance, windows should be
		///                 horizontally aligned to a multiple of this value. A value of zero indicates that the device is accelerated, and any alignment may be
		///                 used.
		///             </description>
		///         </item>
		///         <item>
		///             <term>SHADEBLENDCAPS</term>
		///             <description>
		///                 <para>Value that indicates the shading and blending capabilities of the device. See Remarks for further comments.</para>
		///             </description>
		///         </item>
		///         <item>
		///             <term>RASTERCAPS</term>
		///             <description>
		///                 <para>Value that indicates the raster capabilities of the device, as shown in the following table.</para>
		///             </description>
		///         </item>
		///         <item>
		///             <term>CURVECAPS</term>
		///             <description>
		///                 <para>Value that indicates the curve capabilities of the device, as shown in the following table.</para>
		///             </description>
		///         </item>
		///         <item>
		///             <term>LINECAPS</term>
		///             <description>
		///                 <para>Value that indicates the line capabilities of the device, as shown in the following table:</para>
		///             </description>
		///         </item>
		///         <item>
		///             <term>POLYGONALCAPS</term>
		///             <description>
		///                 <para>Value that indicates the polygon capabilities of the device, as shown in the following table.</para>
		///             </description>
		///         </item>
		///         <item>
		///             <term>TEXTCAPS</term>
		///             <description>
		///                 <para>Value that indicates the text capabilities of the device, as shown in the following table.</para>
		///             </description>
		///         </item>
		///         <item>
		///             <term>COLORMGMTCAPS</term>
		///             <description>
		///                 <para>Value that indicates the color management capabilities of the device.</para>
		///             </description>
		///         </item>
		///     </list>
		/// </param>
		/// <returns>
		///     <para>The return value specifies the value of the desired item.</para>
		///     <para>
		///         When <paramref name="nIndex" /> is BITSPIXEL and the device has 15bpp or 16bpp, the return value is 16.
		///     </para>
		/// </returns>
		/// <remarks>
		///     When <paramref name="nIndex" /> is SHADEBLENDCAPS:
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "GetDeviceCaps")]
		public static extern int GetDeviceCaps([In] IntPtr hdc, int nIndex);

		/// <summary>
		///     The <see cref="GetDCPenColor" /> function retrieves the current pen color for the specified device context (DC).
		/// </summary>
		/// <param name="hdc">A handle to the DC whose brush color is to be returned.</param>
		/// <returns>
		///     <para>
		///         If the function succeeds, the return value is a <see cref="COLORREF" /> value for the current DC pen color.
		///     </para>
		///     <para>If the function fails, the return value is CLR_INVALID.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         For information on setting the pen color, see <see cref="SetDCPenColor" />.
		///     </para>
		///     <para>ICM: Color management is performed if ICM is enabled.</para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "User32.GetDCPenColor")]
		public static extern uint GetDCPenColor([In] IntPtr hdc);

		/// <summary>
		///     The <see cref="GetColorSpace" /> function retrieves the handle to the input color space from a specified device context.
		/// </summary>
		/// <param name="hDC">Specifies a device context that is to have its input color space handle retrieved.</param>
		/// <remarks>
		///     <see cref="GetColorSpace" /> obtains the handle to the input color space regardless of whether color management is enabled for the device
		///     context.
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "GetColorSpace")]
		public static extern IntPtr GetColorSpace([In] IntPtr hDC);

		/// <summary>
		///     <para>
		///         The <see cref="GetCharWidth" /> function retrieves the widths, in logical coordinates, of consecutive characters in a specified range from
		///         the current font.
		///     </para>
		///     <para>
		///         Note:  This function is provided only for compatibility with 16-bit versions of Windows. Applications should call the
		///         <see cref="GetCharWidth32" /> function, which provides more accurate results.
		///     </para>
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <param name="iFirstChar">The first character in the group of consecutive characters.</param>
		/// <param name="iLastChar">The last character in the group of consecutive characters, which must not precede the specified first character.</param>
		/// <param name="lpBuffer">A pointer to a buffer that receives the character widths, in logical coordinates.</param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         <see cref="GetCharWidth" /> cannot be used on TrueType fonts. To retrieve character widths for TrueType fonts, use
		///         <see cref="GetCharABCWidths" />.
		///     </para>
		///     <para>
		///         The range is inclusive; that is, the returned widths include the widths of the characters specified by the <paramref name="iFirstChar" /> and
		///         <paramref name="iLastChar" /> parameters.
		///     </para>
		///     <para>If a character does not exist in the current font, it is assigned the width of the default character.</para>
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "GetCharWidth")]
		public static extern bool GetCharWidth([In] IntPtr hdc, uint iFirstChar, uint iLastChar, out int[] lpBuffer);

		/// <summary>
		///     The <see cref="GetCharWidthI" /> function retrieves the widths, in logical coordinates, of consecutive glyph indices in a specified range from
		///     the current font.
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <param name="giFirst">The first glyph index in the group of consecutive glyph indices.</param>
		/// <param name="cgi">The number of glyph indices.</param>
		/// <param name="pgi">
		///     A pointer to an array of glyph indices. If this parameter is not NULL, it is used instead of the <paramref name="giFirst" /> parameter.
		/// </param>
		/// <param name="lpBuffer">A pointer to a buffer that receives the widths, in logical coordinates.</param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         The <see cref="GetCharWidthI" /> function processes a consecutive glyph indices if the <paramref name="pgi" /> parameter is NULL with the
		///         <paramref name="giFirst" /> parameter indicating the first glyph index to process and the <paramref name="cgi" /> parameter indicating how
		///         many glyph indices to process. Otherwise the <see cref="GetCharWidthI" /> function processes the array of glyph indices pointed to by the
		///         <paramref name="pgi" /> parameter with the <paramref name="cgi" /> parameter indicating how many glyph indices to process.
		///     </para>
		///     <para>If a character does not exist in the current font, it is assigned the width of the default character.</para>
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "GetCharWidthI")]
		public static extern bool GetCharWidthI([In] IntPtr hdc, uint giFirst, uint cgi, ushort[] pgi, out int[] lpBuffer);

		/// <summary>
		///     The <see cref="GetBrushOrgEx" /> function retrieves the current brush origin for the specified device context. This function replaces the
		///     GetBrushOrg function.
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <param name="lppt">
		///     A pointer to a <see cref="POINT" /> structure that receives the brush origin, in device coordinates.
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     <para>A brush is a bitmap that the system uses to paint the interiors of filled shapes.</para>
		///     <para>
		///         The brush origin is a set of coordinates with values between 0 and 7, specifying the location of one pixel in the bitmap. The default brush
		///         origin coordinates are (0,0). For horizontal coordinates, the value 0 corresponds to the leftmost column of pixels; the value 7 corresponds
		///         to the rightmost column. For vertical coordinates, the value 0 corresponds to the uppermost row of pixels; the value 7 corresponds to the
		///         lowermost row. When the system positions the brush at the start of any painting operation, it maps the origin of the brush to the location in
		///         the window's client area specified by the brush origin. For example, if the origin is set to (2,3), the system maps the origin of the brush
		///         (0,0) to the location (2,3) on the window's client area.
		///     </para>
		///     <para>
		///         If an application uses a brush to fill the backgrounds of both a parent and a child window with matching colors, it may be necessary to set
		///         the brush origin after painting the parent window but before painting the child window.
		///     </para>
		///     <para>
		///         The system automatically tracks the origin of all window-managed device contexts and adjusts their brushes as necessary to maintain an
		///         alignment of patterns on the surface.
		///     </para>
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "GetBrushOrgEx")]
		public static extern bool GetBrushOrgEx([In] IntPtr hdc, [Out] out POINT lppt);

		/// <summary>
		///     <para>
		///         The <see cref="GetBoundsRect" /> function obtains the current accumulated bounding rectangle for a specified device context.
		///     </para>
		///     <para>The system maintains an accumulated bounding rectangle for each application. An application can retrieve and set this rectangle.</para>
		/// </summary>
		/// <param name="hdc">A handle to the device context whose bounding rectangle the function will return.</param>
		/// <param name="lprcBounds">
		///     A pointer to the <see cref="RECT" /> structure that will receive the current bounding rectangle. The application's rectangle is returned in
		///     logical coordinates, and the bounding rectangle is returned in screen coordinates.
		/// </param>
		/// <param name="flags">
		///     <para>
		///         Specifies how the <see cref="GetBoundsRect" /> function will behave. This parameter can be the following value.
		///     </para>
		///     <list type="table">
		///         <item>
		///             <term>DCB_RESET</term>
		///             <description>Clears the bounding rectangle after returning it. If this flag is not set, the bounding rectangle will not be cleared.</description>
		///         </item>
		///     </list>
		/// </param>
		/// <returns>The return value specifies the state of the accumulated bounding rectangle; it can be one of the following values.</returns>
		/// <remarks>
		///     The DCB_SET value is a combination of the bit values DCB_ACCUMULATE and DCB_RESET. Applications that check the DCB_RESET bit to determine whether
		///     the bounding rectangle is empty must also check the DCB_ACCUMULATE bit. The bounding rectangle is empty only if the DCB_RESET bit is 1 and the
		///     DCB_ACCUMULATE bit is 0.
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "GetBoundsRect")]
		public static extern uint GetBoundsRect([In] IntPtr hdc, [Out] out RECT lprcBounds, uint flags);

		/// <summary>
		///     <para>
		///         The <see cref="GetBitmapBits" /> function copies the bitmap bits of a specified device-dependent bitmap into a buffer.
		///     </para>
		///     <para>
		///         Note:  This function is provided only for compatibility with 16-bit versions of Windows. Applications should use the <see cref="GetDIBits" />
		///         function.
		///     </para>
		/// </summary>
		/// <param name="hbmp">A handle to the device-dependent bitmap.</param>
		/// <param name="cbBuffer">The number of bytes to copy from the bitmap into the buffer.</param>
		/// <param name="lpvBits">A pointer to a buffer to receive the bitmap bits. The bits are stored as an array of byte values.</param>
		/// <returns>
		///     <para>If the function succeeds, the return value is the number of bytes copied to the buffer.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		[DllImport("gdi32.dll", EntryPoint = "GetBitmapBits")]
		public static extern int GetBitmapBits([In] IntPtr hbmp, int cbBuffer, IntPtr lpvBits);

		/// <summary>
		///     The <see cref="CreateRectRgn" /> function creates a rectangular region.
		/// </summary>
		/// <param name="nLeftRect">Specifies the x-coordinate of the upper-left corner of the region in logical units.</param>
		/// <param name="nTopRect">Specifies the y-coordinate of the upper-left corner of the region in logical units.</param>
		/// <param name="nRightRect">Specifies the x-coordinate of the lower-right corner of the region in logical units.</param>
		/// <param name="nBottomRect">Specifies the y-coordinate of the lower-right corner of the region in logical units.</param>
		/// <returns>
		///     <para>If the function succeeds, the return value is the handle to the region.</para>
		///     <para>If the function fails, the return value is NULL.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         When you no longer need the HRGN object, call the <see cref="DeleteObject" /> function to delete it.
		///     </para>
		///     <para>Region coordinates are represented as 27-bit signed integers.</para>
		///     <para>
		///         Regions created by the Create[shape]Rgn methods (such as <see cref="CreateRectRgn" /> and <see cref="CreatePolygonRgn" />) only include the
		///         interior of the shape; the shape's outline is excluded from the region. This means that any point on a line between two sequential vertices
		///         is not included in the region. If you were to call <see cref="PtInRegion" /> for such a point, it would return zero as the result.
		///     </para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "CreateRectRgn")]
		public static extern IntPtr CreateRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect);

		/// <summary>
		///     The <see cref="CreatePalette" /> function creates a logical palette.
		/// </summary>
		/// <param name="lplgpl">
		///     A pointer to a <see cref="LOGPALETTE" /> structure that contains information about the colors in the logical palette.
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is a handle to a logical palette.</para>
		///     <para>If the function fails, the return value is NULL.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         An application can determine whether a device supports palette operations by calling the <see cref="GetDeviceCaps" /> function and specifying
		///         the RASTERCAPS constant.
		///     </para>
		///     <para>
		///         Once an application creates a logical palette, it can select that palette into a device context by calling the <see cref="SelectPalette" />
		///         function. A palette selected into a device context can be realized by calling the <see cref="RealizePalette" /> function.
		///     </para>
		///     <para>
		///         When you no longer need the palette, call the <see cref="DeleteObject" /> function to delete it.
		///     </para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "CreatePalette")]
		public static extern IntPtr CreatePalette([In] ref LOGPALETTE lplgpl);

		/// <summary>
		///     <para>
		///         The <see cref="CopyMetaFile" /> function copies the content of a Windows-format metafile to the specified file.
		///     </para>
		///     <para>
		///         Note:  This function is provided only for compatibility with Windows-format metafiles. Enhanced-format metafiles provide superior
		///         functionality and are recommended for new applications. The corresponding function for an enhanced-format metafile is
		///         <see cref="CopyEnhMetaFile" />.
		///     </para>
		/// </summary>
		/// <param name="hmfSrc">A handle to the source Windows-format metafile.</param>
		/// <param name="lpszFile">A pointer to the name of the destination file. If this parameter is NULL, the source metafile is copied to memory.</param>
		/// <returns>
		///     <para>If the function succeeds, the return value is a handle to the copy of the Windows-format metafile.</para>
		///     <para>If the function fails, the return value is NULL.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         Where text arguments must use Unicode characters, use this function as a wide-character function. Where text arguments must use characters
		///         from the Windows character set, use this function as an ANSI function.
		///     </para>
		///     <para>
		///         When the application no longer needs the Windows-format metafile handle, it should delete the handle by calling the
		///         <see cref="DeleteMetaFile" /> function.
		///     </para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "CopyMetaFile")]
		public static extern IntPtr CopyMetaFile([In] IntPtr hmfSrc, [In] string lpszFile);

		/// <summary>
		///     <para>
		///         The <see cref="CloseMetaFile" /> function closes a metafile device context and returns a handle that identifies a Windows-format metafile.
		///     </para>
		///     <para>
		///         Note:  This function is provided only for compatibility with Windows-format metafiles. Enhanced-format metafiles provide superior
		///         functionality and are recommended for new applications. The corresponding function for an enhanced-format metafile is
		///         <see cref="CloseEnhMetaFile" />.
		///     </para>
		/// </summary>
		/// <param name="hdc">Handle to a metafile device context used to create a Windows-format metafile.</param>
		/// <returns>
		///     <para>If the function succeeds, the return value is a handle to a Windows-format metafile.</para>
		///     <para>If the function fails, the return value is NULL.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         To convert a Windows-format metafile into a new enhanced-format metafile, use the <see cref="SetWinMetaFileBits" /> function.
		///     </para>
		///     <para>
		///         When an application no longer needs the Windows-format metafile handle, it should delete the handle by calling the
		///         <see cref="DeleteMetaFile" /> function.
		///     </para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "CloseMetaFile")]
		public static extern IntPtr CloseMetaFile([In] IntPtr hdc);

		/// <summary>
		///     The <see cref="UpdateColors" /> function updates the client area of the specified device context by remapping the current colors in the client
		///     area to the currently realized logical palette.
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         An application can determine whether a device supports palette operations by calling the <see cref="GetDeviceCaps" /> function and specifying
		///         the RASTERCAPS constant.
		///     </para>
		///     <para>
		///         An inactive window with a realized logical palette may call <see cref="UpdateColors" /> as an alternative to redrawing its client area when
		///         the system palette changes.
		///     </para>
		///     <para>
		///         The <see cref="UpdateColors" /> function typically updates a client area faster than redrawing the area. However, because
		///         <see cref="UpdateColors" /> performs the color translation based on the color of each pixel before the system palette changed, each call to
		///         this function results in the loss of some color accuracy.
		///     </para>
		///     <para>
		///         This function must be called soon after a <see cref="WM.WM_PALETTECHANGED" /> message is received.
		///     </para>
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "UpdateColors")]
		public static extern bool UpdateColors([In] IntPtr hdc);

		/// <summary>
		///     The <see cref="SetTextColor" /> function sets the text color for the specified device context to the specified color.
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <param name="crColor">The color of the text.</param>
		/// <returns>
		///     <para>
		///         If the function succeeds, the return value is a color reference for the previous text color as a <see cref="COLORREF" /> value.
		///     </para>
		///     <para>If the function fails, the return value is CLR_INVALID.</para>
		/// </returns>
		/// <remarks>
		///     The text color is used to draw the face of each character written by the <see cref="TextOut" /> and <see cref="ExtTextOut" /> functions. The text
		///     color is also used in converting bitmaps from color to monochrome and vice versa.
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "SetTextColor")]
		public static extern uint SetTextColor([In] IntPtr hdc, uint crColor);

		/// <summary>
		///     The <see cref="SetTextAlign" /> function sets the text-alignment flags for the specified device context.
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <param name="fMode">
		///     <para>
		///         The text alignment by using a mask of the values in the following list. Only one flag can be chosen from those that affect horizontal and
		///         vertical alignment. In addition, only one of the two flags that alter the current position can be chosen.
		///     </para>
		///     <list type="table">
		///         <item>
		///             <term>TA_BASELINE</term>
		///             <description>The reference point will be on the base line of the text.</description>
		///         </item>
		///         <item>
		///             <term>TA_BOTTOM</term>
		///             <description>The reference point will be on the bottom edge of the bounding rectangle.</description>
		///         </item>
		///         <item>
		///             <term>TA_TOP</term>
		///             <description>The reference point will be on the top edge of the bounding rectangle.</description>
		///         </item>
		///         <item>
		///             <term>TA_CENTER</term>
		///             <description>The reference point will be aligned horizontally with the center of the bounding rectangle.</description>
		///         </item>
		///         <item>
		///             <term>TA_LEFT</term>
		///             <description>The reference point will be on the left edge of the bounding rectangle.</description>
		///         </item>
		///         <item>
		///             <term>TA_RIGHT</term>
		///             <description>The reference point will be on the right edge of the bounding rectangle.</description>
		///         </item>
		///         <item>
		///             <term>TA_NOUPDATECP</term>
		///             <description>The current position is not updated after each text output call. The reference point is passed to the text output function.</description>
		///         </item>
		///         <item>
		///             <term>TA_RTLREADING</term>
		///             <description>
		///                 Middle East language edition of Windows: The text is laid out in right to left reading order, as opposed to the default left to right
		///                 order. This applies only when the font selected into the device context is either Hebrew or Arabic.
		///             </description>
		///         </item>
		///         <item>
		///             <term>TA_UPDATECP</term>
		///             <description>The current position is updated after each text output call. The current position is used as the reference point.</description>
		///         </item>
		///     </list>
		///     <para>
		///         When the current font has a vertical default base line, as with Kanji, the following values must be used instead of TA_BASELINE and
		///         TA_CENTER.
		///     </para>
		///     <list type="table">
		///         <item>
		///             <term>VTA_BASELINE</term>
		///             <description>The reference point will be on the base line of the text.</description>
		///         </item>
		///         <item>
		///             <term>VTA_CENTER</term>
		///             <description>The reference point will be aligned vertically with the center of the bounding rectangle.</description>
		///         </item>
		///     </list>
		///     <para>The default values are TA_LEFT, TA_TOP, and TA_NOUPDATECP.</para>
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is the previous text-alignment setting.</para>
		///     <para>If the function fails, the return value is GDI_ERROR.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         The <see cref="TextOut" /> and <see cref="ExtTextOut" /> functions use the text-alignment flags to position a string of text on a display or
		///         other device. The flags specify the relationship between a reference point and a rectangle that bounds the text. The reference point is
		///         either the current position or a point passed to a text output function.
		///     </para>
		///     <para>The rectangle that bounds the text is formed by the character cells in the text string.</para>
		///     <para>The best way to get left-aligned text is to use either</para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "SetTextAlign")]
		public static extern uint SetTextAlign([In] IntPtr hdc, uint fMode);

		/// <summary>
		///     The <see cref="SetAbortProc" /> function sets the application-defined abort function that allows a print job to be canceled during spooling.
		/// </summary>
		/// <param name="hdc">Handle to the device context for the print job.</param>
		/// <param name="lpAbortProc">
		///     Pointer to the application-defined abort function. For more information about the callback function, see the <see cref="AbortProc" /> callback
		///     function.
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is greater than zero.</para>
		///     <para>If the function fails, the return value is SP_ERROR.</para>
		/// </returns>
		/// <remarks>
		///     Note:  This is a blocking or synchronous function and might not return immediately. How quickly this function returns depends on run-time factors
		///     such as network status, print server configuration, and printer driver implementation—factors that are difficult to predict when writing an
		///     application. Calling this function from a thread that manages interaction with the user interface could make the application appear to be
		///     unresponsive.
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "SetAbortProc")]
		public static extern int SetAbortProc([In] IntPtr hdc, AbortProc lpAbortProc);

		/// <summary>
		///     The <see cref="SelectObject" /> function selects an object into the specified device context (DC). The new object replaces the previous object of
		///     the same type.
		/// </summary>
		/// <param name="hdc">A handle to the DC.</param>
		/// <param name="hgdiobj">
		///     <para>A handle to the object to be selected. The specified object must have been created by using one of the following functions.</para>
		///     <list type="table">
		///         <item>
		///             <term>Bitmap</term>
		///             <description>
		///                 <para>
		///                     <see cref="CreateBitmap" />, <see cref="CreateBitmapIndirect" />, <see cref="CreateCompatibleBitmap" />,
		///                     <see cref="CreateDIBitmap" />, <see cref="CreateDIBSection" />
		///                 </para>
		///                 <para>Bitmaps can only be selected into memory DC's. A single bitmap cannot be selected into more than one DC at the same time.</para>
		///             </description>
		///         </item>
		///         <item>
		///             <term>Brush</term>
		///             <description>
		///                 <see cref="CreateBrushIndirect" />, <see cref="CreateDIBPatternBrush" />, <see cref="CreateDIBPatternBrushPt" />,
		///                 <see cref="CreateHatchBrush" />, <see cref="CreatePatternBrush" />, <see cref="CreateSolidBrush" />
		///             </description>
		///         </item>
		///         <item>
		///             <term>Font</term>
		///             <description>
		///                 <see cref="CreateFont" />, <see cref="CreateFontIndirect" />
		///             </description>
		///         </item>
		///         <item>
		///             <term>Pen</term>
		///             <description>
		///                 <see cref="CreatePen" />, <see cref="CreatePenIndirect" />
		///             </description>
		///         </item>
		///         <item>
		///             <term>Region</term>
		///             <description>
		///                 <see cref="CombineRgn" />, <see cref="CreateEllipticRgn" />, <see cref="CreateEllipticRgnIndirect" />,
		///                 <see cref="CreatePolygonRgn" />, <see cref="CreateRectRgn" />, <see cref="CreateRectRgnIndirect" />
		///             </description>
		///         </item>
		///     </list>
		/// </param>
		/// <returns>
		///     If the selected object is not a region and the function succeeds, the return value is a handle to the object being replaced. If the selected
		///     object is a region and the function succeeds, the return value is one of the following values.
		/// </returns>
		/// <remarks>
		///     <para>
		///         This function returns the previously selected object of the specified type. An application should always replace a new object with the
		///         original, default object after it has finished drawing with the new object.
		///     </para>
		///     <para>An application cannot select a single bitmap into more than one DC at a time.</para>
		///     <para>ICM: If the object being selected is a brush or a pen, color management is performed.</para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "SelectObject")]
		public static extern IntPtr SelectObject([In] IntPtr hdc, [In] IntPtr hgdiobj);

		/// <summary>
		///     The <see cref="RectInRegion" /> function determines whether any part of the specified rectangle is within the boundaries of a region.
		/// </summary>
		/// <param name="hrgn">Handle to the region.</param>
		/// <param name="lprc">
		///     Pointer to a <see cref="RECT" /> structure containing the coordinates of the rectangle in logical units. The lower and right edges of the
		///     rectangle are not included.
		/// </param>
		/// <returns>
		///     <para>If any part of the specified rectangle lies within the boundaries of the region, the return value is nonzero.</para>
		///     <para>If no part of the specified rectangle lies within the boundaries of the region, the return value is zero.</para>
		/// </returns>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "RectInRegion")]
		public static extern bool RectInRegion([In] IntPtr hrgn, [In] ref RECT lprc);

		/// <summary>
		///     The <see cref="PolyTextOut" /> function draws several strings using the font and text colors currently selected in the specified device context.
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <param name="pptxt">
		///     A pointer to an array of <see cref="POLYTEXT" /> structures describing the strings to be drawn. The array contains one structure for each string
		///     to be drawn.
		/// </param>
		/// <param name="cStrings">
		///     The number of <see cref="POLYTEXT" /> structures in the <paramref name="pptxt" /> array.
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         Each <see cref="POLYTEXT" /> structure contains the coordinates of a reference point that Windows uses to align the corresponding string of
		///         text. An application can specify how the reference point is used by calling the <see cref="SetTextAlign" /> function. An application can
		///         determine the current text-alignment setting for the specified device context by calling the <see cref="GetTextAlign" /> function.
		///     </para>
		///     <para>
		///         To draw a single string of text, the application should call the <see cref="ExtTextOut" /> function.
		///     </para>
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "PolyTextOut")]
		public static extern bool PolyTextOut(
			[In] IntPtr hdc, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 2)] POLYTEXT[] pptxt, int cStrings);

		/// <summary>
		///     The <see cref="PolyPolyline" /> function draws multiple series of connected line segments.
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <param name="lppt">
		///     A pointer to an array of <see cref="POINT" /> structures that contains the vertices of the polylines, in logical units. The polylines are
		///     specified consecutively.
		/// </param>
		/// <param name="lpdwPolyPoints">
		///     A pointer to an array of variables specifying the number of points in the <paramref name="lppt" /> array for the corresponding polyline. Each
		///     entry must be greater than or equal to two.
		/// </param>
		/// <param name="cCount">
		///     The total number of entries in the <paramref name="lpdwPolyPoints" /> array.
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     <para>The line segments are drawn by using the current pen. The figures formed by the segments are not filled.</para>
		///     <para>The current position is neither used nor updated by this function.</para>
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "PolyPolyline")]
		public static extern bool PolyPolyline(
			[In] IntPtr hdc, [In] ref POINT lppt, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U4, SizeParamIndex = 3)] uint[] lpdwPolyPoints,
			uint cCount);

		/// <summary>
		///     The <see cref="PolyBezierTo" /> function draws one or more Bézier curves.
		/// </summary>
		/// <param name="hdc">A handle to a device context.</param>
		/// <param name="lppt">
		///     A pointer to an array of <see cref="POINT" /> structures that contains the endpoints and control points, in logical units.
		/// </param>
		/// <param name="cCount">
		///     The number of points in the <paramref name="lppt" /> array. This value must be three times the number of curves to be drawn because each Bézier
		///     curve requires two control points and an ending point.
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         This function draws cubic Bézier curves by using the control points specified by the <paramref name="lppt" /> parameter. The first curve is
		///         drawn from the current position to the third point by using the first two points as control points. For each subsequent curve, the function
		///         needs exactly three more points, and uses the ending point of the previous curve as the starting point for the next.
		///     </para>
		///     <para>
		///         <see cref="PolyBezierTo" /> moves the current position to the ending point of the last Bézier curve. The figure is not filled.
		///     </para>
		///     <para>This function draws lines by using the current pen.</para>
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "PolyBezierTo")]
		public static extern bool PolyBezierTo(
			[In] IntPtr hdc, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 2)] POINT[] lppt, uint cCount);

		/// <summary>
		///     <para>
		///         The <see cref="PlayMetaFile" /> function displays the picture stored in the given Windows-format metafile on the specified device.
		///     </para>
		///     <para>
		///         Note:  This function is provided only for compatibility with Windows-format metafiles. Enhanced-format metafiles provide superior
		///         functionality and are recommended for new applications. The corresponding function for an enhanced-format metafile is
		///         <see cref="PlayEnhMetaFile" />.
		///     </para>
		/// </summary>
		/// <param name="hdc">Handle to a device context.</param>
		/// <param name="hmf">Handle to a Windows-format metafile.</param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         To convert a Windows-format metafile into an enhanced format metafile, use the <see cref="SetWinMetaFileBits" /> function.
		///     </para>
		///     <para>A Windows-format metafile can be played multiple times.</para>
		///     <para>
		///         A Windows-format metafile can be embedded in a second Windows-format metafile by calling the <see cref="PlayMetaFile" /> function and playing
		///         the source metafile into the device context for the target metafile.
		///     </para>
		///     <para>Any object created but not deleted in the Windows-format metafile is deleted by this function.</para>
		///     <para>
		///         To stop this function, an application can call the <see cref="CancelDC" /> function from another thread to terminate the operation. In this
		///         case, the function returns FALSE.
		///     </para>
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "PlayMetaFile")]
		public static extern bool PlayMetaFile([In] IntPtr hdc, [In] IntPtr hmf);

		/// <summary>
		///     The <see cref="PathToRegion" /> function creates a region from the path that is selected into the specified device context. The resulting region
		///     uses device coordinates.
		/// </summary>
		/// <param name="hdc">Handle to a device context that contains a closed path.</param>
		/// <returns>
		///     <para>If the function succeeds, the return value identifies a valid region.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         When you no longer need the HRGN object call the <see cref="DeleteObject" /> function to delete it.
		///     </para>
		///     <para>
		///         The device context identified by the <paramref name="hdc" /> parameter must contain a closed path.
		///     </para>
		///     <para>
		///         After <see cref="PathToRegion" /> converts a path into a region, the system discards the closed path from the specified device context.
		///     </para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "PathToRegion")]
		public static extern IntPtr PathToRegion([In] IntPtr hdc);

		/// <summary>
		///     The <see cref="GetTextFace" /> function retrieves the typeface name of the font that is selected into the specified device context.
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <param name="nCount">
		///     The length of the buffer pointed to by <paramref name="lpFaceName" />. For the ANSI function it is a BYTE count and for the Unicode function it
		///     is a WORD count. Note that for the ANSI function, characters in SBCS code pages take one byte each, while most characters in DBCS code pages take
		///     two bytes; for the Unicode function, most currently defined Unicode characters (those in the Basic Multilingual Plane (BMP)) are one WORD while
		///     Unicode surrogates are two WORDs.
		/// </param>
		/// <param name="lpFaceName">
		///     A pointer to the buffer that receives the typeface name. If this parameter is NULL, the function returns the number of characters in the name,
		///     including the terminating null character.
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is the number of characters copied to the buffer.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     <para>The typeface name is copied as a null-terminated character string.</para>
		///     <para>
		///         If the name is longer than the number of characters specified by the <paramref name="nCount" /> parameter, the name is truncated.
		///     </para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "GetTextFace")]
		public static extern int GetTextFace([In] IntPtr hdc, int nCount, [Out] StringBuilder lpFaceName);

		/// <summary>
		///     The <see cref="GetTextColor" /> function retrieves the current text color for the specified device context.
		/// </summary>
		/// <param name="hdc">Handle to the device context.</param>
		/// <returns>
		///     <para>
		///         If the function succeeds, the return value is the current text color as a <see cref="COLORREF" /> value.
		///     </para>
		///     <para>If the function fails, the return value is CLR_INVALID. No extended error information is available.</para>
		/// </returns>
		/// <remarks>
		///     The text color defines the foreground color of characters drawn by using the <see cref="TextOut" /> or <see cref="ExtTextOut" /> function.
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "GetTextColor")]
		public static extern uint GetTextColor([In] IntPtr hdc);

		/// <summary>
		///     The <see cref="GetTextAlign" /> function retrieves the text-alignment setting for the specified device context.
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <returns>
		///     If the function succeeds, the return value is the status of the text-alignment flags. For more information about the return value, see the
		///     Remarks section. The return value is a combination of the following values.
		/// </returns>
		/// <remarks>
		///     <para>
		///         The bounding rectangle is a rectangle bounding all of the character cells in a string of text. Its dimensions can be obtained by calling the
		///         <see cref="GetTextExtentPoint32" /> function.
		///     </para>
		///     <para>
		///         The text-alignment flags determine how the <see cref="TextOut" /> and <see cref="ExtTextOut" /> functions align a string of text in relation
		///         to the string's reference point provided to <see cref="TextOut" /> or <see cref="ExtTextOut" />.
		///     </para>
		///     <para>
		///         The text-alignment flags are not necessarily single bit flags and may be equal to zero. The flags must be examined in groups of related
		///         flags, as shown in the following list.
		///     </para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "GetTextAlign")]
		public static extern uint GetTextAlign([In] IntPtr hdc);

		/// <summary>
		///     The <see cref="GetRandomRgn" /> function copies the system clipping region of a specified device context to a specific region.
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <param name="hrgn">
		///     A handle to a region. Before the function is called, this identifies an existing region. After the function returns, this identifies a copy of
		///     the current system region. The old region identified by <paramref name="hrgn" /> is overwritten.
		/// </param>
		/// <param name="iNum">This parameter must be SYSRGN.</param>
		/// <returns>
		///     If the function succeeds, the return value is 1. If the function fails, the return value is -1. If the region to be retrieved is NULL, the return
		///     value is 0. If the function fails or the region to be retrieved is NULL, <paramref name="hrgn" /> is not initialized.
		/// </returns>
		/// <remarks>
		///     <para>
		///         When using the SYSRGN flag, note that the system clipping region might not be current because of window movements. Nonetheless, it is safe to
		///         retrieve and use the system clipping region within the <see cref="User32.BeginPaint" />-<see cref="User32.EndPaint" /> block during
		///         <see cref="WM.WM_PAINT" />
		///         processing. In this case, the system region is the intersection of the update region and the current visible area of the window. Any window
		///         movement following the return of <see cref="GetRandomRgn" /> and before <see cref="User32.EndPaint" /> will result in a new
		///         <see cref="WM.WM_PAINT" />
		///         message. Any other use of the SYSRGN flag may result in painting errors in your application.
		///     </para>
		///     <para>The region returned is in screen coordinates.</para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "GetRandomRgn")]
		public static extern int GetRandomRgn([In] IntPtr hdc, [In] IntPtr hrgn, int iNum);

		/// <summary>
		///     The <see cref="ExtFloodFill" /> function fills an area of the display surface with the current brush.
		/// </summary>
		/// <param name="hdc">A handle to a device context.</param>
		/// <param name="nXStart">The x-coordinate, in logical units, of the point where filling is to start.</param>
		/// <param name="nYStart">The y-coordinate, in logical units, of the point where filling is to start.</param>
		/// <param name="crColor">
		///     The color of the boundary or of the area to be filled. The interpretation of <paramref name="crColor" /> depends on the value of the
		///     <paramref name="fuFillType" /> parameter. To create a <see cref="COLORREF" /> color value, use the RGB macro.
		/// </param>
		/// <param name="fuFillType">
		///     <para>The type of fill operation to be performed. This parameter must be one of the following values.</para>
		///     <list type="table">
		///         <item>
		///             <term>FLOODFILLBORDER</term>
		///             <description>
		///                 The fill area is bounded by the color specified by the <paramref name="crColor" /> parameter. This style is identical to the filling
		///                 performed by the <see cref="FloodFill" /> function.
		///             </description>
		///         </item>
		///         <item>
		///             <term>FLOODFILLSURFACE</term>
		///             <description>
		///                 The fill area is defined by the color that is specified by <paramref name="crColor" />. Filling continues outward in all directions
		///                 as long as the color is encountered. This style is useful for filling areas with multicolored boundaries.
		///             </description>
		///         </item>
		///     </list>
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>The following are some of the reasons this function might fail:</remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "ExtFloodFill")]
		public static extern bool ExtFloodFill([In] IntPtr hdc, int nXStart, int nYStart, uint crColor, uint fuFillType);

		/// <summary>
		///     The <see cref="ExtCreatePen" /> function creates a logical cosmetic or geometric pen that has the specified style, width, and brush attributes.
		/// </summary>
		/// <param name="dwPenStyle">
		///     <para>
		///         A combination of type, style, end cap, and join attributes. The values from each category are combined by using the bitwise OR operator ( |
		///         ).
		///     </para>
		///     <para>The pen type can be one of the following values.</para>
		///     <list type="table">
		///         <item>
		///             <term>PS_GEOMETRIC</term>
		///             <description>The pen is geometric.</description>
		///         </item>
		///         <item>
		///             <term>PS_COSMETIC</term>
		///             <description>The pen is cosmetic.</description>
		///         </item>
		///     </list>
		///     <para>The pen style can be one of the following values.</para>
		///     <list type="table">
		///         <item>
		///             <term>PS_ALTERNATE</term>
		///             <description>The pen sets every other pixel. (This style is applicable only for cosmetic pens.)</description>
		///         </item>
		///         <item>
		///             <term>PS_SOLID</term>
		///             <description>The pen is solid.</description>
		///         </item>
		///         <item>
		///             <term>PS_DASH</term>
		///             <description>The pen is dashed.</description>
		///         </item>
		///         <item>
		///             <term>PS_DOT</term>
		///             <description>The pen is dotted.</description>
		///         </item>
		///         <item>
		///             <term>PS_DASHDOT</term>
		///             <description>The pen has alternating dashes and dots.</description>
		///         </item>
		///         <item>
		///             <term>PS_DASHDOTDOT</term>
		///             <description>The pen has alternating dashes and double dots.</description>
		///         </item>
		///         <item>
		///             <term>PS_NULL</term>
		///             <description>The pen is invisible.</description>
		///         </item>
		///         <item>
		///             <term>PS_USERSTYLE</term>
		///             <description>The pen uses a styling array supplied by the user.</description>
		///         </item>
		///         <item>
		///             <term>PS_INSIDEFRAME</term>
		///             <description>
		///                 The pen is solid. When this pen is used in any GDI drawing function that takes a bounding rectangle, the dimensions of the figure are
		///                 shrunk so that it fits entirely in the bounding rectangle, taking into account the width of the pen. This applies only to geometric
		///                 pens.
		///             </description>
		///         </item>
		///     </list>
		///     <para>The end cap is only specified for geometric pens. The end cap can be one of the following values.</para>
		///     <list type="table">
		///         <item>
		///             <term>PS_ENDCAP_ROUND</term>
		///             <description>End caps are round.</description>
		///         </item>
		///         <item>
		///             <term>PS_ENDCAP_SQUARE</term>
		///             <description>End caps are square.</description>
		///         </item>
		///         <item>
		///             <term>PS_ENDCAP_FLAT</term>
		///             <description>End caps are flat.</description>
		///         </item>
		///     </list>
		///     <para>The join is only specified for geometric pens. The join can be one of the following values.</para>
		///     <list type="table">
		///         <item>
		///             <term>PS_JOIN_BEVEL</term>
		///             <description>Joins are beveled.</description>
		///         </item>
		///         <item>
		///             <term>PS_JOIN_MITER</term>
		///             <description>
		///                 Joins are mitered when they are within the current limit set by the <see cref="SetMiterLimit" /> function. If it exceeds this limit,
		///                 the join is beveled.
		///             </description>
		///         </item>
		///         <item>
		///             <term>PS_JOIN_ROUND</term>
		///             <description>Joins are round.</description>
		///         </item>
		///     </list>
		/// </param>
		/// <param name="dwWidth">
		///     The width of the pen. If the <paramref name="dwPenStyle" /> parameter is PS_GEOMETRIC, the width is given in logical units. If
		///     <paramref name="dwPenStyle" /> is PS_COSMETIC, the width must be set to 1.
		/// </param>
		/// <param name="lplb">
		///     A pointer to a <see cref="LOGBRUSH" /> structure. If <paramref name="dwPenStyle" /> is PS_COSMETIC, the <see cref="LOGBRUSH.lbColor" /> member
		///     specifies the color of the pen and the <see cref="lpStyle" /> member must be set to BS_SOLID. If <paramref name="dwPenStyle" /> is PS_GEOMETRIC,
		///     all members must be used to specify the brush attributes of the pen.
		/// </param>
		/// <param name="dwStyleCount">
		///     <para>
		///         The length, in DWORD units, of the <paramref name="lpStyle" /> array. This value must be zero if
		///         <paramref name="dwPenStyle" /> is not PS_USERSTYLE.
		///     </para>
		///     <para>The style count is limited to 16.</para>
		/// </param>
		/// <param name="lpStyle">
		///     <para>
		///         A pointer to an array. The first value specifies the length of the first dash in a user-defined style, the second value specifies the length
		///         of the first space, and so on. This pointer must be NULL if <paramref name="dwPenStyle" /> is not PS_USERSTYLE.
		///     </para>
		///     <para>
		///         If the <paramref name="lpStyle" /> array is exceeded during line drawing, the pointer is reset to the beginning of the array. When this
		///         happens and <paramref name="dwStyleCount" /> is an even number, the pattern of dashes and spaces repeats. However, if
		///         <paramref name="dwStyleCount" /> is odd, the pattern reverses when the pointer is reset -- the first element of <paramref name="lpStyle" />
		///         now refers to spaces, the second refers to dashes, and so forth.
		///     </para>
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is a handle that identifies a logical pen.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         A geometric pen can have any width and can have any of the attributes of a brush, such as dithers and patterns. A cosmetic pen can only be a
		///         single pixel wide and must be a solid color, but cosmetic pens are generally faster than geometric pens.
		///     </para>
		///     <para>The width of a geometric pen is always specified in world units. The width of a cosmetic pen is always 1.</para>
		///     <para>End caps and joins are only specified for geometric pens.</para>
		///     <para>
		///         After an application creates a logical pen, it can select that pen into a device context by calling the <see cref="SelectObject" /> function.
		///         After a pen is selected into a device context, it can be used to draw lines and curves.
		///     </para>
		///     <para>
		///         If <paramref name="dwPenStyle" /> is PS_COSMETIC and PS_USERSTYLE, the entries in the <paramref name="lpStyle" /> array specify lengths of
		///         dashes and spaces in style units. A style unit is defined by the device where the pen is used to draw a line.
		///     </para>
		///     <para>
		///         If <paramref name="dwPenStyle" /> is PS_GEOMETRIC and PS_USERSTYLE, the entries in the <paramref name="lpStyle" /> array specify lengths of
		///         dashes and spaces in logical units.
		///     </para>
		///     <para>
		///         If <paramref name="dwPenStyle" /> is PS_ALTERNATE, the style unit is ignored and every other pixel is set.
		///     </para>
		///     <para>
		///         If the <see cref="LOGBRUSH.lbStyle" /> member of the <see cref="LOGBRUSH" /> structure pointed to by <paramref name="lplb" /> is BS_PATTERN,
		///         the bitmap pointed to by the <see cref="LOGBRUSH.lbHatch" /> member of that structure cannot be a DIB section. A DIB section is a bitmap
		///         created by
		///         <see cref="CreateDIBSection" />. If that bitmap is a DIB section, the <see cref="ExtCreatePen" /> function fails.
		///     </para>
		///     <para>
		///         When an application no longer requires a specified pen, it should call the <see cref="DeleteObject" /> function to delete the pen.
		///     </para>
		///     <para>
		///         ICM: No color management is done at pen creation. However, color management is performed when the pen is selected into an ICM-enabled device
		///         context.
		///     </para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "ExtCreatePen")]
		public static extern IntPtr ExtCreatePen(uint dwPenStyle, uint dwWidth, [In] ref LOGBRUSH lplb, uint dwStyleCount, [In] IntPtr lpStyle);

		/// <summary>
		///     <para>
		///         The <see cref="EnumMetaFile" /> function enumerates the records within a Windows-format metafile by retrieving each record and passing it to
		///         the specified callback function. The application-supplied callback function processes each record as required. The enumeration continues
		///         until the last record is processed or when the callback function returns zero.
		///     </para>
		///     <para>
		///         Note:  This function is provided only for compatibility with Windows-format metafiles. Enhanced-format metafiles provide superior
		///         functionality and are recommended for new applications. The corresponding function for an enhanced-format metafile is
		///         <see cref="EnumEnhMetaFile" />.
		///     </para>
		/// </summary>
		/// <param name="hdc">Handle to a device context. This handle is passed to the callback function.</param>
		/// <param name="hmf">Handle to a Windows-format metafile.</param>
		/// <param name="lpMetaFunc">
		///     Pointer to an application-supplied callback function. For more information, see <see cref="EnumMetaFileProc" />.
		/// </param>
		/// <param name="lParam">Pointer to optional data.</param>
		/// <returns>
		///     <para>If the callback function successfully enumerates all the records in the Windows-format metafile, the return value is nonzero.</para>
		///     <para>If the callback function does not successfully enumerate all the records in the Windows-format metafile, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         To convert a Windows-format metafile into an enhanced-format metafile, use the <see cref="SetWinMetaFileBits" /> function.
		///     </para>
		///     <para>
		///         You can use the <see cref="EnumMetaFile" /> function to embed one Windows-format metafile within another.
		///     </para>
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "EnumMetaFile")]
		public static extern bool EnumMetaFile([In] IntPtr hdc, [In] IntPtr hmf, EnumMetaFileProc lpMetaFunc, [MarshalAs(UnmanagedType.SysInt)] int lParam);

		/// <summary>
		///     The <see cref="DeleteObject" /> function deletes a logical pen, brush, font, bitmap, region, or palette, freeing all system resources associated
		///     with the object. After the object is deleted, the specified handle is no longer valid.
		/// </summary>
		/// <param name="hObject">A handle to a logical pen, brush, font, bitmap, region, or palette.</param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the specified handle is not valid or is currently selected into a DC, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     <para>Do not delete a drawing object (pen or brush) while it is still selected into a DC.</para>
		///     <para>When a pattern brush is deleted, the bitmap associated with the brush is not deleted. The bitmap must be deleted independently.</para>
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "DeleteObject")]
		public static extern bool DeleteObject([In] IntPtr hObject);

		/// <summary>
		///     The <see cref="CreateBitmap" /> function creates a bitmap with the specified width, height, and color format (color planes and bits-per-pixel).
		/// </summary>
		/// <param name="nWidth">The bitmap width, in pixels.</param>
		/// <param name="nHeight">The bitmap height, in pixels.</param>
		/// <param name="cPlanes">The number of color planes used by the device.</param>
		/// <param name="cBitsPerPel">The number of bits required to identify the color of a single pixel.</param>
		/// <param name="lpvBits">
		///     A pointer to an array of color data used to set the colors in a rectangle of pixels. Each scan line in the rectangle must be word aligned (scan
		///     lines that are not word aligned must be padded with zeros). If this parameter is NULL, the contents of the new bitmap is undefined.
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is a handle to a bitmap.</para>
		///     <para>If the function fails, the return value is NULL.</para>
		///     <para>This function can return the following value.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         The <see cref="CreateBitmap" /> function creates a device-dependent bitmap.
		///     </para>
		///     <para>
		///         After a bitmap is created, it can be selected into a device context by calling the <see cref="SelectObject" /> function. However, the bitmap
		///         can only be selected into a device context if the bitmap and the DC have the same format.
		///     </para>
		///     <para>
		///         The <see cref="CreateBitmap" /> function can be used to create color bitmaps. However, for performance reasons applications should use
		///         <see cref="CreateBitmap" /> to create monochrome bitmaps and <see cref="CreateCompatibleBitmap" /> to create color bitmaps. Whenever a color
		///         bitmap returned from <see cref="CreateBitmap" /> is selected into a device context, the system checks that the bitmap matches the format of
		///         the device context it is being selected into. Because <see cref="CreateCompatibleBitmap" /> takes a device context, it returns a bitmap that
		///         has the same format as the specified device context. Thus, subsequent calls to <see cref="SelectObject" /> are faster with a color bitmap
		///         from <see cref="CreateCompatibleBitmap" /> than with a color bitmap returned from <see cref="CreateBitmap" />.
		///     </para>
		///     <para>
		///         If the bitmap is monochrome, zeros represent the foreground color and ones represent the background color for the destination device
		///         context.
		///     </para>
		///     <para>
		///         If an application sets the <paramref name="nWidth" /> or <paramref name="nHeight" /> parameters to zero, <see cref="CreateBitmap" /> returns
		///         the handle to a 1-by-1 pixel, monochrome bitmap.
		///     </para>
		///     <para>
		///         When you no longer need the bitmap, call the <see cref="DeleteObject" /> function to delete it.
		///     </para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "CreateBitmap")]
		public static extern IntPtr CreateBitmap(int nWidth, int nHeight, uint cPlanes, uint cBitsPerPel, [In] IntPtr lpvBits);

		/// <summary>
		///     <para>Applies to: desktop apps only</para>
		///     <para>
		///         The <see cref="SwapBuffers" /> function exchanges the front and back buffers if the current pixel format for the window referenced by the
		///         specified device context includes a back buffer.
		///     </para>
		/// </summary>
		/// <param name="hdc">
		///     Specifies a device context. If the current pixel format for the window referenced by this device context includes a back buffer, the function
		///     exchanges the front and back buffers.
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is TRUE.</para>
		///     <para>If the function fails, the return value is FALSE. To get extended error information, call GetLastError.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         If the current pixel format for the window referenced by the device context does not include a back buffer, this call has no effect and the
		///         content of the back buffer is undefined when the function returns.
		///     </para>
		///     <para>
		///         With multithread applications, flush the drawing commands in any other threads drawing to the same window before calling
		///         <see cref="SwapBuffers" />.
		///     </para>
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "SwapBuffers")]
		public static extern bool SwapBuffers(IntPtr hdc);

		/// <summary>
		///     The <see cref="RectVisible" /> function determines whether any part of the specified rectangle lies within the clipping region of a device
		///     context.
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <param name="lprc">
		///     A pointer to a <see cref="RECT" /> structure that contains the logical coordinates of the specified rectangle.
		/// </param>
		/// <returns>
		///     <para>If the current transform does not have a rotation and the rectangle lies within the clipping region, the return value is TRUE (1).</para>
		///     <para>If the current transform does not have a rotation and the rectangle does not lie within the clipping region, the return value is FALSE (0).</para>
		///     <para>If the current transform has a rotation and the rectangle lies within the clipping region, the return value is 2.</para>
		///     <para>If the current transform has a rotation and the rectangle does not lie within the clipping region, the return value is 1.</para>
		///     <para>All other return values are considered error codes. If the any parameter is not valid, the return value is undefined.</para>
		/// </returns>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "RectVisible")]
		public static extern bool RectVisible([In] IntPtr hdc, [In] ref RECT lprc);

		/// <summary>
		///     The <see cref="PolyPolygon" /> function draws a series of closed polygons. Each polygon is outlined by using the current pen and filled by using
		///     the current brush and polygon fill mode. The polygons drawn by this function can overlap.
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <param name="lpPoints">
		///     A pointer to an array of <see cref="POINT" /> structures that define the vertices of the polygons, in logical coordinates. The polygons are
		///     specified consecutively. Each polygon is closed automatically by drawing a line from the last vertex to the first. Each vertex should be
		///     specified once.
		/// </param>
		/// <param name="lpPolyCounts">
		///     A pointer to an array of integers, each of which specifies the number of points in the corresponding polygon. Each integer must be greater than
		///     or equal to 2.
		/// </param>
		/// <param name="nCount">The total number of polygons.</param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     <para>The current position is neither used nor updated by this function.</para>
		///     <para>
		///         Any extra points are ignored. To draw the polygons with more points, divide your data into groups, each of which have less than the maximum
		///         number of points, and call the function for each group of points. Note, it is best to have a polygon in only one of the groups.
		///     </para>
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "PolyPolygon")]
		public static extern bool PolyPolygon(
			[In] IntPtr hdc, [In] ref POINT lpPoints, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I4, SizeParamIndex = 3)] int[] lpPolyCounts,
			int nCount);

		/// <summary>
		///     The <see cref="GetFontData" /> function retrieves font metric data for a TrueType font.
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <param name="dwTable">
		///     The name of a font metric table from which the font data is to be retrieved. This parameter can identify one of the metric tables documented in
		///     the TrueType Font Files specification published by Microsoft Corporation. If this parameter is zero, the information is retrieved starting at the
		///     beginning of the file for TrueType font files or from the beginning of the data for the currently selected font for TrueType Collection files. To
		///     retrieve the data from the beginning of the file for TrueType Collection files specify 'ttcf' (0x66637474).
		/// </param>
		/// <param name="dwOffset">
		///     The offset from the beginning of the font metric table to the location where the function should begin retrieving information. If this parameter
		///     is zero, the information is retrieved starting at the beginning of the table specified by the <paramref name="dwTable" /> parameter. If this
		///     value is greater than or equal to the size of the table, an error occurs.
		/// </param>
		/// <param name="lpvBuffer">
		///     A pointer to a buffer that receives the font information. If this parameter is NULL, the function returns the size of the buffer required for the
		///     font data.
		/// </param>
		/// <param name="cbData">
		///     The length, in bytes, of the information to be retrieved. If this parameter is zero, <see cref="GetFontData" /> returns the size of the data
		///     specified in the <paramref name="dwTable" /> parameter.
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is the number of bytes returned.</para>
		///     <para>If the function fails, the return value is GDI_ERROR.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         This function is intended to be used to retrieve TrueType font information directly from the font file by font-manipulation applications. For
		///         information about embedding fonts see the Font Embedding Reference.
		///     </para>
		///     <para>
		///         An application can sometimes use the <see cref="GetFontData" /> function to save a TrueType font with a document. To do this, the application
		///         determines whether the font can be embedded by checking the <see cref="OUTLINETEXTMETRIC.otmfsType" /> member of the
		///         <see cref="OUTLINETEXTMETRIC" />
		///         structure. If bit 1 of <see cref="OUTLINETEXTMETRIC.otmfsType" /> is set, embedding is not permitted for the font. If bit 1 is clear, the
		///         font can be embedded. If bit 2 is set, the embedding is read-only. If embedding is permitted, the application can retrieve the entire font
		///         file, specifying zero for the <paramref name="dwTable" />, <paramref name="dwOffset" />, and <paramref name="cbData" /> parameters.
		///     </para>
		///     <para>If an application attempts to use this function to retrieve information for a non-TrueType font, an error occurs.</para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "GetFontData")]
		public static extern uint GetFontData([In] IntPtr hdc, uint dwTable, uint dwOffset, IntPtr lpvBuffer, uint cbData);

		/// <summary>
		///     The <see cref="FlattenPath" /> function transforms any curves in the path that is selected into the current device context (DC), turning each
		///     curve into a sequence of lines.
		/// </summary>
		/// <param name="hdc">A handle to a DC that contains a valid path.</param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "FlattenPath")]
		public static extern bool FlattenPath([In] IntPtr hdc);

		/// <summary>
		///     The <see cref="ExtTextOut" /> function draws text using the currently selected font, background color, and text color. You can optionally provide
		///     dimensions to be used for clipping, opaquing, or both.
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <param name="X">The x-coordinate, in logical coordinates, of the reference point used to position the string.</param>
		/// <param name="Y">The y-coordinate, in logical coordinates, of the reference point used to position the string.</param>
		/// <param name="fuOptions">
		///     <para>Specifies how to use the application-defined rectangle. This parameter can be one or more of the following values.</para>
		///     <list type="table">
		///         <item>
		///             <term>ETO_CLIPPED</term>
		///             <description>The text will be clipped to the rectangle.</description>
		///         </item>
		///         <item>
		///             <term>ETO_GLYPH_INDEX</term>
		///             <description>
		///                 <para>
		///                     The <paramref name="lpString" /> array refers to an array returned from <see cref="GetCharacterPlacement" /> and should be parsed
		///                     directly by GDI as no further language-specific processing is required. Glyph indexing only applies to TrueType fonts, but the
		///                     flag can be used for bitmap and vector fonts to indicate that no further language processing is necessary and GDI should process
		///                     the string directly. Note that all glyph indexes are 16-bit values even though the string is assumed to be an array of 8-bit
		///                     values for raster fonts.
		///                 </para>
		///                 <para>
		///                     For ExtTextOutW, the glyph indexes are saved to a metafile. However, to display the correct characters the metafile must be
		///                     played back using the same font. For ExtTextOutA, the glyph indexes are not saved.
		///                 </para>
		///             </description>
		///         </item>
		///         <item>
		///             <term>ETO_IGNORELANGUAGE</term>
		///             <description>
		///                 Reserved for system use. If an application sets this flag, it loses international scripting support and in some cases it may
		///                 display no text at all.
		///             </description>
		///         </item>
		///         <item>
		///             <term>ETO_NUMERICSLATIN</term>
		///             <description>To display numbers, use European digits.</description>
		///         </item>
		///         <item>
		///             <term>ETO_NUMERICSLOCAL</term>
		///             <description>To display numbers, use digits appropriate to the locale.</description>
		///         </item>
		///         <item>
		///             <term>ETO_OPAQUE</term>
		///             <description>The current background color should be used to fill the rectangle.</description>
		///         </item>
		///         <item>
		///             <term>ETO_PDY</term>
		///             <description>
		///                 When this is set, the array pointed to by <paramref name="lpDx" /> contains pairs of values. The first value of each pair is, as
		///                 usual, the distance between origins of adjacent character cells, but the second value is the displacement along the vertical
		///                 direction of the font.
		///             </description>
		///         </item>
		///         <item>
		///             <term>ETO_RTLREADING</term>
		///             <description>
		///                 Middle East language edition of Windows: If this value is specified and a Hebrew or Arabic font is selected into the device context,
		///                 the string is output using right-to-left reading order. If this value is not specified, the string is output in left-to-right order.
		///                 The same effect can be achieved by setting the TA_RTLREADING value in <see cref="SetTextAlign" />. This value is preserved for
		///                 backward compatibility.
		///             </description>
		///         </item>
		///     </list>
		///     <para>
		///         The ETO_GLYPH_INDEX and ETO_RTLREADING values cannot be used together. Because ETO_GLYPH_INDEX implies that all language processing has been
		///         completed, the function ignores the ETO_RTLREADING flag if also specified.
		///     </para>
		/// </param>
		/// <param name="lprc">
		///     A pointer to an optional <see cref="RECT" /> structure that specifies the dimensions, in logical coordinates, of a rectangle that is used for
		///     clipping, opaquing, or both.
		/// </param>
		/// <param name="lpString">
		///     A pointer to a string that specifies the text to be drawn. The string does not need to be zero-terminated, since <paramref name="cbCount" />
		///     specifies the length of the string.
		/// </param>
		/// <param name="cbCount">
		///     <para>
		///         The length of the string pointed to by <paramref name="lpString" />.
		///     </para>
		///     <para>This value may not exceed 8192.</para>
		/// </param>
		/// <param name="lpDx">
		///     A pointer to an optional array of values that indicate the distance between origins of adjacent character cells. For example, lpDx[i] logical
		///     units separate the origins of character cell i and character cell i + 1.
		/// </param>
		/// <returns>
		///     <para>
		///         If the string is drawn, the return value is nonzero. However, if the ANSI version of <see cref="ExtTextOut" /> is called with
		///         ETO_GLYPH_INDEX, the function returns TRUE even though the function does nothing.
		///     </para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         The current text-alignment settings for the specified device context determine how the reference point is used to position the text. The
		///         text-alignment settings are retrieved by calling the <see cref="GetTextAlign" /> function. The text-alignment settings are altered by calling
		///         the <see cref="SetTextAlign" /> function. You can use the following values for text alignment. Only one flag can be chosen from those that
		///         affect horizontal and vertical alignment. In addition, only one of the two flags that alter the current position can be chosen.
		///     </para>
		///     <para></para>
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "ExtTextOut")]
		public static extern bool ExtTextOut(
			[In] IntPtr hdc, int X, int Y, uint fuOptions, [In] ref RECT lprc, [In] string lpString, uint cbCount, [In] int[] lpDx);

		/// <summary>
		///     The <see cref="EnumObjects" /> function enumerates the pens or brushes available for the specified device context (DC). This function calls the
		///     application-defined callback function once for each available object, supplying data describing that object. <see cref="EnumObjects" /> continues
		///     calling the callback function until the callback function returns zero or until all of the objects have been enumerated.
		/// </summary>
		/// <param name="hdc">A handle to the DC.</param>
		/// <param name="nObjectType">The object type. This parameter can be OBJ_BRUSH or OBJ_PEN.</param>
		/// <param name="lpObjectFunc">
		///     A pointer to the application-defined callback function. For more information about the callback function, see the <see cref="EnumObjectsProc" />
		///     function.
		/// </param>
		/// <param name="lParam">A pointer to the application-defined data. The data is passed to the callback function along with the object information.</param>
		/// <returns>
		///     <para>If the function succeeds, the return value is the last value returned by the callback function. Its meaning is user-defined.</para>
		///     <para>
		///         If the objects cannot be enumerated (for example, there are too many objects), the function returns zero without calling the callback
		///         function.
		///     </para>
		/// </returns>
		[DllImport("gdi32.dll", EntryPoint = "EnumObjects")]
		public static extern int EnumObjects([In] IntPtr hdc, int nObjectType, EnumObjectsProc lpObjectFunc, [MarshalAs(UnmanagedType.SysInt)] int lParam);

		/// <summary>
		///     The <see cref="CreateFont" /> function creates a logical font with the specified characteristics. The logical font can subsequently be selected
		///     as the font for any device.
		/// </summary>
		/// <param name="nHeight">
		///     <para>
		///         The height, in logical units, of the font's character cell or character. The character height value (also known as the em height) is the
		///         character cell height value minus the internal-leading value. The font mapper interprets the value specified in <paramref name="nHeight" />
		///         in the following manner.
		///     </para>
		///     <list type="table">
		///         <item>
		///             <term>&gt; 0</term>
		///             <description>The font mapper transforms this value into device units and matches it against the cell height of the available fonts.</description>
		///         </item>
		///         <item>
		///             <term>0</term>
		///             <description>The font mapper uses a default height value when it searches for a match.</description>
		///         </item>
		///         <item>
		///             <term>&lt; 0</term>
		///             <description>
		///                 The font mapper transforms this value into device units and matches its absolute value against the character height of the
		///                 available fonts.
		///             </description>
		///         </item>
		///     </list>
		///     <para>For all height comparisons, the font mapper looks for the largest font that does not exceed the requested size.</para>
		///     <para>This mapping occurs when the font is used for the first time.</para>
		///     <para>For the MM_TEXT mapping mode, you can use the following formula to specify a height for a font with a specified point size:</para>
		/// </param>
		/// <param name="nWidth">
		///     The average width, in logical units, of characters in the requested font. If this value is zero, the font mapper chooses a closest match value.
		///     The closest match value is determined by comparing the absolute values of the difference between the current device's aspect ratio and the
		///     digitized aspect ratio of available fonts.
		/// </param>
		/// <param name="nEscapement">
		///     <para>
		///         The angle, in tenths of degrees, between the escapement vector and the x-axis of the device. The escapement vector is parallel to the base
		///         line of a row of text.
		///     </para>
		///     <para>
		///         When the graphics mode is set to GM_ADVANCED, you can specify the escapement angle of the string independently of the orientation angle of
		///         the string's characters.
		///     </para>
		///     <para>
		///         When the graphics mode is set to GM_COMPATIBLE, <paramref name="nEscapement" /> specifies both the escapement and orientation. You should set
		///         <paramref name="nEscapement" /> and <paramref name="nOrientation" /> to the same value.
		///     </para>
		/// </param>
		/// <param name="nOrientation">The angle, in tenths of degrees, between each character's base line and the x-axis of the device.</param>
		/// <param name="fnWeight">
		///     <para>
		///         The weight of the font in the range 0 through 1000. For example, 400 is normal and 700 is bold. If this value is zero, a default weight is
		///         used.
		///     </para>
		///     <para>The following values are defined for convenience.</para>
		///     <list type="table">
		///         <item>
		///             <term>FW_DONTCARE</term>
		///             <description>0</description>
		///         </item>
		///         <item>
		///             <term>FW_THIN</term>
		///             <description>100</description>
		///         </item>
		///         <item>
		///             <term>FW_EXTRALIGHT</term>
		///             <description>200</description>
		///         </item>
		///         <item>
		///             <term>FW_ULTRALIGHT</term>
		///             <description>200</description>
		///         </item>
		///         <item>
		///             <term>FW_LIGHT</term>
		///             <description>300</description>
		///         </item>
		///         <item>
		///             <term>FW_NORMAL</term>
		///             <description>400</description>
		///         </item>
		///         <item>
		///             <term>FW_REGULAR</term>
		///             <description>400</description>
		///         </item>
		///         <item>
		///             <term>FW_MEDIUM</term>
		///             <description>500</description>
		///         </item>
		///         <item>
		///             <term>FW_SEMIBOLD</term>
		///             <description>600</description>
		///         </item>
		///         <item>
		///             <term>FW_DEMIBOLD</term>
		///             <description>600</description>
		///         </item>
		///         <item>
		///             <term>FW_BOLD</term>
		///             <description>700</description>
		///         </item>
		///         <item>
		///             <term>FW_EXTRABOLD</term>
		///             <description>800</description>
		///         </item>
		///         <item>
		///             <term>FW_ULTRABOLD</term>
		///             <description>800</description>
		///         </item>
		///         <item>
		///             <term>FW_HEAVY</term>
		///             <description>900</description>
		///         </item>
		///         <item>
		///             <term>FW_BLACK</term>
		///             <description>900</description>
		///         </item>
		///     </list>
		/// </param>
		/// <param name="fdwItalic">Specifies an italic font if set to TRUE.</param>
		/// <param name="fdwUnderline">Specifies an underlined font if set to TRUE.</param>
		/// <param name="fdwStrikeOut">A strikeout font if set to TRUE.</param>
		/// <param name="fdwCharSet">
		///     <para>The character set. The following values are predefined:</para>
		///     <para>Korean language edition of Windows:</para>
		///     <para>Middle East language edition of Windows:</para>
		///     <para>Thai language edition of Windows:</para>
		///     <para>The OEM_CHARSET value specifies a character set that is operating-system dependent.</para>
		///     <para>
		///         DEFAULT_CHARSET is set to a value based on the current system locale. For example, when the system locale is English (United States), it is
		///         set as ANSI_CHARSET.
		///     </para>
		///     <para>
		///         Fonts with other character sets may exist in the operating system. If an application uses a font with an unknown character set, it should not
		///         attempt to translate or interpret strings that are rendered with that font.
		///     </para>
		///     <para>
		///         To ensure consistent results when creating a font, do not specify OEM_CHARSET or DEFAULT_CHARSET. If you specify a typeface name in the
		///         <paramref name="lpszFace" /> parameter, make sure that the <paramref name="fdwCharSet" /> value matches the character set of the typeface
		///         specified in <paramref name="lpszFace" />.
		///     </para>
		/// </param>
		/// <param name="fdwOutputPrecision">
		///     <para>
		///         The output precision. The output precision defines how closely the output must match the requested font's height, width, character
		///         orientation, escapement, pitch, and font type. It can be one of the following values.
		///     </para>
		///     <list type="table">
		///         <item>
		///             <term>OUT_CHARACTER_PRECIS</term>
		///             <description>Not used.</description>
		///         </item>
		///         <item>
		///             <term>OUT_DEFAULT_PRECIS</term>
		///             <description>The default font mapper behavior.</description>
		///         </item>
		///         <item>
		///             <term>OUT_DEVICE_PRECIS</term>
		///             <description>Instructs the font mapper to choose a Device font when the system contains multiple fonts with the same name.</description>
		///         </item>
		///         <item>
		///             <term>OUT_OUTLINE_PRECIS</term>
		///             <description>This value instructs the font mapper to choose from TrueType and other outline-based fonts.</description>
		///         </item>
		///         <item>
		///             <term>OUT_PS_ONLY_PRECIS</term>
		///             <description>
		///                 Instructs the font mapper to choose from only PostScript fonts. If there are no PostScript fonts installed in the system, the font
		///                 mapper returns to default behavior.
		///             </description>
		///         </item>
		///         <item>
		///             <term>OUT_RASTER_PRECIS</term>
		///             <description>Instructs the font mapper to choose a raster font when the system contains multiple fonts with the same name.</description>
		///         </item>
		///         <item>
		///             <term>OUT_STRING_PRECIS</term>
		///             <description>This value is not used by the font mapper, but it is returned when raster fonts are enumerated.</description>
		///         </item>
		///         <item>
		///             <term>OUT_STROKE_PRECIS</term>
		///             <description>
		///                 This value is not used by the font mapper, but it is returned when TrueType, other outline-based fonts, and vector fonts are
		///                 enumerated.
		///             </description>
		///         </item>
		///         <item>
		///             <term>OUT_TT_ONLY_PRECIS</term>
		///             <description>
		///                 Instructs the font mapper to choose from only TrueType fonts. If there are no TrueType fonts installed in the system, the font mapper
		///                 returns to default behavior.
		///             </description>
		///         </item>
		///         <item>
		///             <term>OUT_TT_PRECIS</term>
		///             <description>Instructs the font mapper to choose a TrueType font when the system contains multiple fonts with the same name.</description>
		///         </item>
		///     </list>
		///     <para>
		///         Applications can use the OUT_DEVICE_PRECIS, OUT_RASTER_PRECIS, OUT_TT_PRECIS, and OUT_PS_ONLY_PRECIS values to control how the font mapper
		///         chooses a font when the operating system contains more than one font with a specified name. For example, if an operating system contains a
		///         font named Symbol in raster and TrueType form, specifying OUT_TT_PRECIS forces the font mapper to choose the TrueType version. Specifying
		///         OUT_TT_ONLY_PRECIS forces the font mapper to choose a TrueType font, even if it must substitute a TrueType font of another name.
		///     </para>
		/// </param>
		/// <param name="fdwClipPrecision">
		///     <para>
		///         The clipping precision. The clipping precision defines how to clip characters that are partially outside the clipping region. It can be one
		///         or more of the following values.
		///     </para>
		///     <list type="table">
		///         <item>
		///             <term>CLIP_CHARACTER_PRECIS</term>
		///             <description>Not used.</description>
		///         </item>
		///         <item>
		///             <term>CLIP_DEFAULT_PRECIS</term>
		///             <description>Specifies default clipping behavior.</description>
		///         </item>
		///         <item>
		///             <term>CLIP_DFA_DISABLE</term>
		///             <description>
		///                 Windows XP SP1: Turns off font association for the font. Note that this flag is not guaranteed to have any effect on any platform
		///                 after Windows Server 2003.
		///             </description>
		///         </item>
		///         <item>
		///             <term>CLIP_EMBEDDED</term>
		///             <description>You must specify this flag to use an embedded read-only font.</description>
		///         </item>
		///         <item>
		///             <term>CLIP_LH_ANGLES</term>
		///             <description>
		///                 <para>
		///                     When this value is used, the rotation for all fonts depends on whether the orientation of the coordinate system is left-handed
		///                     or right-handed.
		///                 </para>
		///                 <para>
		///                     If not used, device fonts always rotate counterclockwise, but the rotation of other fonts is dependent on the orientation of
		///                     the coordinate system.
		///                 </para>
		///                 <para>
		///                     For more information about the orientation of coordinate systems, see the description of the <paramref name="nOrientation" />
		///                     parameter
		///                 </para>
		///             </description>
		///         </item>
		///         <item>
		///             <term>CLIP_MASK</term>
		///             <description>Not used.</description>
		///         </item>
		///         <item>
		///             <term>CLIP_DFA_OVERRIDE</term>
		///             <description>
		///                 Turns off font association for the font. This is identical to CLIP_DFA_DISABLE, but it can have problems in some situations; the
		///                 recommended flag to use is CLIP_DFA_DISABLE.
		///             </description>
		///         </item>
		///         <item>
		///             <term>CLIP_STROKE_PRECIS</term>
		///             <description>
		///                 <para>Not used by the font mapper, but is returned when raster, vector, or TrueType fonts are enumerated.</para>
		///                 <para>For compatibility, this value is always returned when enumerating fonts.</para>
		///             </description>
		///         </item>
		///         <item>
		///             <term>CLIP_TT_ALWAYS</term>
		///             <description>Not used.</description>
		///         </item>
		///     </list>
		/// </param>
		/// <param name="fdwQuality">
		///     <para>
		///         The output quality. The output quality defines how carefully GDI must attempt to match the logical-font attributes to those of an actual
		///         physical font. It can be one of the following values.
		///     </para>
		///     <list type="table">
		///         <item>
		///             <term>ANTIALIASED_QUALITY</term>
		///             <description>Font is antialiased, or smoothed, if the font supports it and the size of the font is not too small or too large.</description>
		///         </item>
		///         <item>
		///             <term>CLEARTYPE_QUALITY</term>
		///             <description>If set, text is rendered (when possible) using ClearType antialiasing method. See Remarks for more information.</description>
		///         </item>
		///         <item>
		///             <term>DEFAULT_QUALITY</term>
		///             <description>Appearance of the font does not matter.</description>
		///         </item>
		///         <item>
		///             <term>DRAFT_QUALITY</term>
		///             <description>
		///                 Appearance of the font is less important than when the PROOF_QUALITY value is used. For GDI raster fonts, scaling is enabled, which
		///                 means that more font sizes are available, but the quality may be lower. Bold, italic, underline, and strikeout fonts are synthesized,
		///                 if necessary.
		///             </description>
		///         </item>
		///         <item>
		///             <term>NONANTIALIASED_QUALITY</term>
		///             <description>Font is never antialiased, that is, font smoothing is not done.</description>
		///         </item>
		///         <item>
		///             <term>PROOF_QUALITY</term>
		///             <description>
		///                 Character quality of the font is more important than exact matching of the logical-font attributes. For GDI raster fonts, scaling is
		///                 disabled and the font closest in size is chosen. Although the chosen font size may not be mapped exactly when PROOF_QUALITY is used,
		///                 the quality of the font is high and there is no distortion of appearance. Bold, italic, underline, and strikeout fonts are
		///                 synthesized, if necessary.
		///             </description>
		///         </item>
		///     </list>
		///     <para>
		///         If the output quality is DEFAULT_QUALITY, DRAFT_QUALITY, or PROOF_QUALITY, then the font is antialiased if the SPI_GETFONTSMOOTHING system
		///         parameter is TRUE. Users can control this system parameter from the Control Panel. (The precise wording of the setting in the Control panel
		///         depends on the version of Windows, but it will be words to the effect of "Smooth edges of screen fonts".)
		///     </para>
		/// </param>
		/// <param name="fdwPitchAndFamily">
		///     <para>The pitch and family of the font. The two low-order bits specify the pitch of the font and can be one of the following values:</para>
		///     <para>The four high-order bits specify the font family and can be one of the following values.</para>
		///     <list type="table">
		///         <item>
		///             <term>FF_DECORATIVE</term>
		///             <description>Novelty fonts. Old English is an example.</description>
		///         </item>
		///         <item>
		///             <term>FF_DONTCARE</term>
		///             <description>Use default font.</description>
		///         </item>
		///         <item>
		///             <term>FF_MODERN</term>
		///             <description>Fonts with constant stroke width, with or without serifs. Pica, Elite, and Courier New are examples.</description>
		///         </item>
		///         <item>
		///             <term>FF_ROMAN</term>
		///             <description>Fonts with variable stroke width and with serifs. MS Serif is an example.</description>
		///         </item>
		///         <item>
		///             <term>FF_SCRIPT</term>
		///             <description>Fonts designed to look like handwriting. Script and Cursive are examples.</description>
		///         </item>
		///         <item>
		///             <term>FF_SWISS</term>
		///             <description>Fonts with variable stroke width and without serifs. MS?Sans Serif is an example.</description>
		///         </item>
		///     </list>
		///     <para>
		///         An application can specify a value for the <paramref name="fdwPitchAndFamily" /> parameter by using the Boolean OR operator to join a pitch
		///         constant with a family constant.
		///     </para>
		///     <para>
		///         Font families describe the look of a font in a general way. They are intended for specifying fonts when the exact typeface requested is not
		///         available.
		///     </para>
		/// </param>
		/// <param name="lpszFace">
		///     <para>
		///         A pointer to a null-terminated string that specifies the typeface name of the font. The length of this string must not exceed 32 characters,
		///         including the terminating null character. The <see cref="EnumFontFamilies" /> function can be used to enumerate the typeface names of all
		///         currently available fonts. For more information, see the Remarks.
		///     </para>
		///     <para>
		///         If <paramref name="lpszFace" /> is NULL or empty string, GDI uses the first font that matches the other specified attributes.
		///     </para>
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is a handle to a logical font.</para>
		///     <para>If the function fails, the return value is NULL.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         When you no longer need the font, call the <see cref="DeleteObject" /> function to delete it.
		///     </para>
		///     <para>
		///         To help protect the copyrights of vendors who provide fonts for Windows, applications should always report the exact name of a selected font.
		///         Because available fonts can vary from system to system, do not assume that the selected font is always the same as the requested font. For
		///         example, if you request a font named Palatino, but no such font is available on the system, the font mapper will substitute a font that has
		///         similar attributes but a different name. Always report the name of the selected font to the user.
		///     </para>
		///     <para>
		///         To get the appropriate font on different language versions of the OS, call <see cref="EnumFontFamiliesEx" /> with the desired font
		///         characteristics in the <see cref="LOGFONT" /> structure, then retrieve the appropriate typeface name and create the font using
		///         <see cref="CreateFont" /> or <see cref="CreateFontIndirect" />.
		///     </para>
		///     <para>
		///         The font mapper for <see cref="CreateFont" />,<see cref="CreateFontIndirect" />, and <see cref="CreateFontIndirectEx" /> recognizes both the
		///         English and the localized typeface name, regardless of locale.
		///     </para>
		///     <para>The following situations do not support ClearType antialiasing:</para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "CreateFont")]
		public static extern IntPtr CreateFont(
			int nHeight, int nWidth, int nEscapement, int nOrientation, int fnWeight, uint fdwItalic, uint fdwUnderline, uint fdwStrikeOut, uint fdwCharSet,
			uint fdwOutputPrecision,
			uint fdwClipPrecision, uint fdwQuality, uint fdwPitchAndFamily, [In] string lpszFace);

		/// <summary>
		///     The <see cref="CloseFigure" /> function closes an open figure in a path.
		/// </summary>
		/// <param name="hdc">Handle to the device context in which the figure will be closed.</param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         The <see cref="CloseFigure" /> function closes the figure by drawing a line from the current position to the first point of the figure
		///         (usually, the point specified by the most recent call to the <see cref="MoveToEx" /> function) and then connects the lines by using the line
		///         join style. If a figure is closed by using the <see cref="LineTo" /> function instead of <see cref="CloseFigure" />, end caps are used to
		///         create the corner instead of a join.
		///     </para>
		///     <para>
		///         The <see cref="CloseFigure" /> function should only be called if there is an open path bracket in the specified device context.
		///     </para>
		///     <para>
		///         A figure in a path is open unless it is explicitly closed by using this function. (A figure can be open even if the current point and the
		///         starting point of the figure are the same.)
		///     </para>
		///     <para>
		///         After a call to <see cref="CloseFigure" />, adding a line or curve to the path starts a new figure.
		///     </para>
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "CloseFigure")]
		public static extern bool CloseFigure([In] IntPtr hdc);

		/// <summary>
		///     The <see cref="StrokePath" /> function renders the specified path by using the current pen.
		/// </summary>
		/// <param name="hdc">Handle to a device context that contains the completed path.</param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     The path, if it is to be drawn by <see cref="StrokePath" />, must have been completed through a call to <see cref="EndPath" />. Calling this
		///     function on a path for which <see cref="EndPath" /> has not been called will cause this function to fail and return zero.  Unlike other path
		///     drawing functions such as <see cref="StrokeAndFillPath" />, <see cref="StrokePath" /> will not attempt to close the path by drawing a straight
		///     line from the first point on the path to the last point on the path.
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "StrokePath")]
		public static extern bool StrokePath([In] IntPtr hdc);

		/// <summary>
		///     The <see cref="StretchBlt" /> function copies a bitmap from a source rectangle into a destination rectangle, stretching or compressing the bitmap
		///     to fit the dimensions of the destination rectangle, if necessary. The system stretches or compresses the bitmap according to the stretching mode
		///     currently set in the destination device context.
		/// </summary>
		/// <param name="hdcDest">A handle to the destination device context.</param>
		/// <param name="nXOriginDest">The x-coordinate, in logical units, of the upper-left corner of the destination rectangle.</param>
		/// <param name="nYOriginDest">The y-coordinate, in logical units, of the upper-left corner of the destination rectangle.</param>
		/// <param name="nWidthDest">The width, in logical units, of the destination rectangle.</param>
		/// <param name="nHeightDest">The height, in logical units, of the destination rectangle.</param>
		/// <param name="hdcSrc">A handle to the source device context.</param>
		/// <param name="nXOriginSrc">The x-coordinate, in logical units, of the upper-left corner of the source rectangle.</param>
		/// <param name="nYOriginSrc">The y-coordinate, in logical units, of the upper-left corner of the source rectangle.</param>
		/// <param name="nWidthSrc">The width, in logical units, of the source rectangle.</param>
		/// <param name="nHeightSrc">The height, in logical units, of the source rectangle.</param>
		/// <param name="dwRop">
		///     <para>
		///         The raster operation to be performed. Raster operation codes define how the system combines colors in output operations that involve a brush,
		///         a source bitmap, and a destination bitmap.
		///     </para>
		///     <para>
		///         See <see cref="BitBlt" /> for a list of common raster operation codes (ROPs). Note that the CAPTUREBLT ROP generally cannot be used for
		///         printing device contexts.
		///     </para>
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         <see cref="StretchBlt" /> stretches or compresses the source bitmap in memory and then copies the result to the destination rectangle. This
		///         bitmap can be either a compatible bitmap (DDB) or the output from <see cref="CreateDIBSection" />. The color data for pattern or destination
		///         pixels is merged after the stretching or compression occurs.
		///     </para>
		///     <para>
		///         When an enhanced metafile is being recorded, an error occurs (and the function returns FALSE) if the source device context identifies an
		///         enhanced-metafile device context.
		///     </para>
		///     <para>If the specified raster operation requires a brush, the system uses the brush currently selected into the destination device context.</para>
		///     <para>
		///         The destination coordinates are transformed by using the transformation currently specified for the destination device context; the source
		///         coordinates are transformed by using the transformation currently specified for the source device context.
		///     </para>
		///     <para>If the source transformation has a rotation or shear, an error occurs.</para>
		///     <para>
		///         If destination, source, and pattern bitmaps do not have the same color format, <see cref="StretchBlt" /> converts the source and pattern
		///         bitmaps to match the destination bitmap.
		///     </para>
		///     <para>
		///         If <see cref="StretchBlt" /> must convert a monochrome bitmap to a color bitmap, it sets white bits (1) to the background color and black
		///         bits (0) to the foreground color. To convert a color bitmap to a monochrome bitmap, it sets pixels that match the background color to white
		///         (1) and sets all other pixels to black (0). The foreground and background colors of the device context with color are used.
		///     </para>
		///     <para>
		///         <see cref="StretchBlt" /> creates a mirror image of a bitmap if the signs of the <paramref name="nWidthSrc" /> and
		///         <paramref name="nWidthDest" /> parameters or if the <paramref name="nHeightSrc" /> and <paramref name="nHeightDest" /> parameters differ. If
		///         <paramref name="nWidthSrc" /> and <paramref name="nWidthDest" /> have different signs, the function creates a mirror image of the bitmap
		///         along the x-axis. If <paramref name="nHeightSrc" /> and <paramref name="nHeightDest" /> have different signs, the function creates a mirror
		///         image of the bitmap along the y-axis.
		///     </para>
		///     <para>
		///         Not all devices support the <see cref="StretchBlt" /> function. For more information, see the <see cref="GetDeviceCaps" />.
		///     </para>
		///     <para>ICM: No color management is performed when a blit operation occurs.</para>
		///     <para>
		///         When used in a multiple monitor system, both <paramref name="hdcSrc" /> and <paramref name="hdcDest" /> must refer to the same device or the
		///         function will fail. To transfer data between DCs for different devices, convert the memory bitmap to a DIB by calling
		///         <see cref="GetDIBits" />. To display the DIB to the second device, call <see cref="SetDIBits" /> or <see cref="StretchDIBits" />.
		///     </para>
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "StretchBlt")]
		public static extern bool StretchBlt(
			[In] IntPtr hdcDest, int nXOriginDest, int nYOriginDest, int nWidthDest, int nHeightDest, [In] IntPtr hdcSrc, int nXOriginSrc, int nYOriginSrc, int nWidthSrc,
			int nHeightSrc, uint dwRop);

		/// <summary>
		///     The <see cref="SetRectRgn" /> function converts a region into a rectangular region with the specified coordinates.
		/// </summary>
		/// <param name="hrgn">Handle to the region.</param>
		/// <param name="nLeftRect">Specifies the x-coordinate of the upper-left corner of the rectangular region in logical units.</param>
		/// <param name="nTopRect">Specifies the y-coordinate of the upper-left corner of the rectangular region in logical units.</param>
		/// <param name="nRightRect">Specifies the x-coordinate of the lower-right corner of the rectangular region in logical units.</param>
		/// <param name="nBottomRect">Specifies the y-coordinate of the lower-right corner of the rectangular region in logical units.</param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>The region does not include the lower and right boundaries of the rectangle.</remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "SetRectRgn")]
		public static extern bool SetRectRgn([In] IntPtr hrgn, int nLeftRect, int nTopRect, int nRightRect, int nBottomRect);

		/// <summary>
		///     The <see cref="SetMetaRgn" /> function intersects the current clipping region for the specified device context with the current metaregion and
		///     saves the combined region as the new metaregion for the specified device context. The clipping region is reset to a null region.
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <returns>The return value specifies the new clipping region's complexity and can be one of the following values.</returns>
		/// <remarks>
		///     <para>The current clipping region of a device context is defined by the intersection of its clipping region and its metaregion.</para>
		///     <para>
		///         The <see cref="SetMetaRgn" /> function should only be called after an application's original device context was saved by calling the
		///         <see cref="SaveDC" /> function.
		///     </para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "SetMetaRgn")]
		public static extern int SetMetaRgn([In] IntPtr hdc);

		/// <summary>
		///     The <see cref="SetMapMode" /> function sets the mapping mode of the specified device context. The mapping mode defines the unit of measure used
		///     to transform page-space units into device-space units, and also defines the orientation of the device's x and y axes.
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <param name="fnMapMode">
		///     <para>The new mapping mode. This parameter can be one of the following values.</para>
		///     <list type="table">
		///         <item>
		///             <term>MM_ANISOTROPIC</term>
		///             <description>
		///                 Logical units are mapped to arbitrary units with arbitrarily scaled axes. Use the <see cref="SetWindowExtEx" /> and
		///                 <see cref="SetViewportExtEx" /> functions to specify the units, orientation, and scaling.
		///             </description>
		///         </item>
		///         <item>
		///             <term>MM_HIENGLISH</term>
		///             <description>Each logical unit is mapped to 0.001 inch. Positive x is to the right; positive y is up.</description>
		///         </item>
		///         <item>
		///             <term>MM_HIMETRIC</term>
		///             <description>Each logical unit is mapped to 0.01 millimeter. Positive x is to the right; positive y is up.</description>
		///         </item>
		///         <item>
		///             <term>MM_ISOTROPIC</term>
		///             <description>
		///                 Logical units are mapped to arbitrary units with equally scaled axes; that is, one unit along the x-axis is equal to one unit along
		///                 the y-axis. Use the <see cref="SetWindowExtEx" /> and <see cref="SetViewportExtEx" /> functions to specify the units and the
		///                 orientation of the axes. Graphics device interface (GDI) makes adjustments as necessary to ensure the x and y units remain the same
		///                 size (When the window extent is set, the viewport will be adjusted to keep the units isotropic).
		///             </description>
		///         </item>
		///         <item>
		///             <term>MM_LOENGLISH</term>
		///             <description>Each logical unit is mapped to 0.01 inch. Positive x is to the right; positive y is up.</description>
		///         </item>
		///         <item>
		///             <term>MM_LOMETRIC</term>
		///             <description>Each logical unit is mapped to 0.1 millimeter. Positive x is to the right; positive y is up.</description>
		///         </item>
		///         <item>
		///             <term>MM_TEXT</term>
		///             <description>Each logical unit is mapped to one device pixel. Positive x is to the right; positive y is down.</description>
		///         </item>
		///         <item>
		///             <term>MM_TWIPS</term>
		///             <description>
		///                 Each logical unit is mapped to one twentieth of a printer's point (1/1440 inch, also called a twip). Positive x is to the
		///                 right; positive y is up.
		///             </description>
		///         </item>
		///     </list>
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value identifies the previous mapping mode.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     <para>The MM_TEXT mode allows applications to work in device pixels, whose size varies from device to device.</para>
		///     <para>
		///         The MM_HIENGLISH, MM_HIMETRIC, MM_LOENGLISH, MM_LOMETRIC, and MM_TWIPS modes are useful for applications drawing in physically meaningful
		///         units (such as inches or millimeters).
		///     </para>
		///     <para>The MM_ISOTROPIC mode ensures a 1:1 aspect ratio.</para>
		///     <para>The MM_ANISOTROPIC mode allows the x-coordinates and y-coordinates to be adjusted independently.</para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "SetMapMode")]
		public static extern int SetMapMode([In] IntPtr hdc, int fnMapMode);

		/// <summary>
		///     The <see cref="SetICMMode" /> function causes Image Color Management to be enabled, disabled, or queried on a given device context (DC).
		/// </summary>
		/// <param name="hDC">Identifies handle to the device context.</param>
		/// <param name="iEnableICM">
		///     <para>Turns on and off image color management. This parameter can take one of the following constant values.</para>
		///     <list type="table">
		///         <item>
		///             <term>ICM_ON</term>
		///             <description>Turns on color management. Turns off old-style color correction of halftones.</description>
		///         </item>
		///         <item>
		///             <term>ICM_OFF</term>
		///             <description>Turns off color management. Turns on old-style color correction of halftones.</description>
		///         </item>
		///         <item>
		///             <term>ICM_QUERY</term>
		///             <description>Queries the current state of color management.</description>
		///         </item>
		///         <item>
		///             <term>ICM_DONE_OUTSIDEDC</term>
		///             <description>
		///                 Turns off color management inside DC. Under Windows 2000, also turns off old-style color correction of halftones. Not
		///                 supported under Windows 95.
		///             </description>
		///         </item>
		///     </list>
		/// </param>
		/// <remarks>
		///     <para>
		///         If the system cannot find an ICC color profile to match the state of the device, <see cref="SetICMMode" /> fails and returns zero.
		///     </para>
		///     <para>
		///         Once WCS is enabled for a device context (DC), colors passed into the DC using most Win32 API functions are color matched. The primary
		///         exceptions are <see cref="BitBlt" /> and <see cref="StretchBlt" />. The assumption is that when performing a bit block transfer (blit) from
		///         one DC to another, the two DCs are already compatible and need no color correction. If this is not the case, color correction may be
		///         performed. Specifically, if a device independent bitmap (DIB) is used as the source for a blit, and the blit is performed into a DC that has
		///         WCS enabled, color matching will be performed. If this is not what you want, turn WCS off for the destination DC by calling
		///         <see cref="SetICMMode" /> before calling <see cref="BitBlt" /> or <see cref="StretchBlt" />.
		///     </para>
		///     <para>
		///         If the <see cref="CreateCompatibleDC" /> function is used to create a bitmap in a DC, it is possible for the bitmap to be color matched
		///         twice, once when it is created and once when a blit is performed. The reason is that a bitmap in a DC created by the
		///         <see cref="CreateCompatibleDC" /> function acquires the current brush, pens, and palette of the source DC. However, WCS will be disabled by
		///         default for the new DC. If WCS is later enabled for the new DC by using the <see cref="SetICMMode" /> function, a color correction will be
		///         done. To prevent double color corrections through the use of the <see cref="CreateCompatibleDC" /> function, use the
		///         <see cref="SetICMMode" /> function to turn WCS off for the source DC before the <see cref="CreateCompatibleDC" /> function is called.
		///     </para>
		///     <para>
		///         When a compatible DC is created from a printer's DC (see <see cref="CreateCompatibleDC" /> ), the default is for color matching to always be
		///         performed if it is enabled for the printer's DC. The default color profile for the printer is used when a blit is performed into the
		///         printer's DC using <see cref="SetDIBitsToDevice" /> or <see cref="StretchDIBits" />. If this is not what you want, turn WCS off for the
		///         printer's DC by calling <see cref="SetICMMode" /> before calling <see cref="SetDIBitsToDevice" /> or <see cref="StretchDIBits" />.
		///     </para>
		///     <para>
		///         Also, when printing to a printer's DC with WCS turned on, the <see cref="SetICMMode" /> function needs to be called after every call to the
		///         <see cref="StartPage" /> function to turn back on WCS. The <see cref="StartPage" /> function calls the <see cref="RestoreDC" /> and
		///         <see cref="SaveDC" /> functions, which result in WCS being turned off for the printer's DC.
		///     </para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "SetICMMode")]
		public static extern int SetICMMode([In] IntPtr hDC, int iEnableICM);

		/// <summary>
		///     The <see cref="SetBkColor" /> function sets the current background color to the specified color value, or to the nearest physical color if the
		///     device cannot represent the specified color value.
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <param name="crColor">
		///     The new background color. To make a <see cref="COLORREF" /> value, use the RGB macro.
		/// </param>
		/// <returns>
		///     <para>
		///         If the function succeeds, the return value specifies the previous background color as a <see cref="COLORREF" /> value.
		///     </para>
		///     <para>If the function fails, the return value is CLR_INVALID.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         This function fills the gaps between styled lines drawn using a pen created by the <see cref="CreatePen" /> function; it does not fill the
		///         gaps between styled lines drawn using a pen created by the <see cref="ExtCreatePen" /> function. The <see cref="SetBkColor" /> function also
		///         sets the background colors for <see cref="TextOut" /> and <see cref="ExtTextOut" />.
		///     </para>
		///     <para>
		///         If the background mode is OPAQUE, the background color is used to fill gaps between styled lines, gaps between hatched lines in brushes, and
		///         character cells. The background color is also used when converting bitmaps from color to monochrome and vice versa.
		///     </para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "SetBkColor")]
		public static extern uint SetBkColor([In] IntPtr hdc, uint crColor);

		/// <summary>
		///     The <see cref="PtInRegion" /> function determines whether the specified point is inside the specified region.
		/// </summary>
		/// <param name="hrgn">Handle to the region to be examined.</param>
		/// <param name="X">Specifies the x-coordinate of the point in logical units.</param>
		/// <param name="Y">Specifies the y-coordinate of the point in logical units.</param>
		/// <returns>
		///     <para>If the specified point is in the region, the return value is nonzero.</para>
		///     <para>If the specified point is not in the region, the return value is zero.</para>
		/// </returns>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "PtInRegion")]
		public static extern bool PtInRegion([In] IntPtr hrgn, int X, int Y);

		/// <summary>
		///     The <see cref="PolylineTo" /> function draws one or more straight lines.
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <param name="lppt">
		///     A pointer to an array of <see cref="POINT" /> structures that contains the vertices of the line, in logical units.
		/// </param>
		/// <param name="cCount">The number of points in the array.</param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         Unlike the <see cref="Polyline" /> function, the <see cref="PolylineTo" /> function uses and updates the current position.
		///     </para>
		///     <para>
		///         A line is drawn from the current position to the first point specified by the <paramref name="lppt" /> parameter by using the current pen.
		///         For each additional line, the function draws from the ending point of the previous line to the next point specified by
		///         <paramref name="lppt" />.
		///     </para>
		///     <para>
		///         <see cref="PolylineTo" /> moves the current position to the ending point of the last line.
		///     </para>
		///     <para>If the line segments drawn by this function form a closed figure, the figure is not filled.</para>
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "PolylineTo")]
		public static extern bool PolylineTo(
			[In] IntPtr hdc, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 2)] POINT[] lppt, uint cCount);

		/// <summary>
		///     The <see cref="PolyBezier" /> function draws one or more Bézier curves.
		/// </summary>
		/// <param name="hdc">A handle to a device context.</param>
		/// <param name="lppt">
		///     A pointer to an array of <see cref="POINT" /> structures that contain the endpoints and control points of the curve(s), in logical units.
		/// </param>
		/// <param name="cPoints">
		///     The number of points in the <paramref name="lppt" /> array. This value must be one more than three times the number of curves to be drawn,
		///     because each Bézier curve requires two control points and an endpoint, and the initial curve requires an additional starting point.
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         The <see cref="PolyBezier" /> function draws cubic Bézier curves by using the endpoints and control points specified by the
		///         <paramref name="lppt" /> parameter. The first curve is drawn from the first point to the fourth point by using the second and third points as
		///         control points. Each subsequent curve in the sequence needs exactly three more points: the ending point of the previous curve is used as the
		///         starting point, the next two points in the sequence are control points, and the third is the ending point.
		///     </para>
		///     <para>
		///         The current position is neither used nor updated by the <see cref="PolyBezier" /> function. The figure is not filled.
		///     </para>
		///     <para>This function draws lines by using the current pen.</para>
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "PolyBezier")]
		public static extern bool PolyBezier(
			[In] IntPtr hdc, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 2)] POINT[] lppt, uint cPoints);

		/// <summary>
		///     The <see cref="GetObject" /> function retrieves information for the specified graphics object.
		/// </summary>
		/// <param name="hgdiobj">
		///     A handle to the graphics object of interest. This can be a handle to one of the following: a logical bitmap, a brush, a font, a palette, a pen,
		///     or a device independent bitmap created by calling the <see cref="CreateDIBSection" /> function.
		/// </param>
		/// <param name="cbBuffer">The number of bytes of information to be written to the buffer.</param>
		/// <param name="lpvObject">
		///     <para>A pointer to a buffer that receives the information about the specified graphics object.</para>
		///     <para>
		///         The following table shows the type of information the buffer receives for each type of graphics object you can specify with
		///         <paramref name="hgdiobj" />.
		///     </para>
		///     <list type="table">
		///         <item>
		///             <term>HBITMAP</term>
		///             <description>
		///                 <see cref="BITMAP" />
		///             </description>
		///         </item>
		///         <item>
		///             <term>HBITMAP returned from a call to CreateDIBSection</term>
		///             <description>
		///                 DIBSECTION, if <paramref name="cbBuffer" /> is set to sizeof (DIBSECTION), or <see cref="BITMAP" />, if
		///                 <paramref name="cbBuffer" /> is set to sizeof (BITMAP).
		///             </description>
		///         </item>
		///         <item>
		///             <term>HPALETTE</term>
		///             <description>A WORD count of the number of entries in the logical palette</description>
		///         </item>
		///         <item>
		///             <term>HPEN returned from a call to ExtCreatePen</term>
		///             <description>
		///                 <see cref="EXTLOGPEN" />
		///             </description>
		///         </item>
		///         <item>
		///             <term>HPEN</term>
		///             <description>
		///                 <see cref="LOGPEN" />
		///             </description>
		///         </item>
		///         <item>
		///             <term>HBRUSH</term>
		///             <description>
		///                 <see cref="LOGBRUSH" />
		///             </description>
		///         </item>
		///         <item>
		///             <term>HFONT</term>
		///             <description>
		///                 <see cref="LOGFONT" />
		///             </description>
		///         </item>
		///     </list>
		///     <para>
		///         If the <paramref name="lpvObject" /> parameter is NULL, the function return value is the number of bytes required to store the information it
		///         writes to the buffer for the specified graphics object.
		///     </para>
		/// </param>
		/// <returns>
		///     <para>
		///         If the function succeeds, and <paramref name="lpvObject" /> is a valid pointer, the return value is the number of bytes stored into the
		///         buffer.
		///     </para>
		///     <para>
		///         If the function succeeds, and <paramref name="lpvObject" /> is NULL, the return value is the number of bytes required to hold the information
		///         the function would store into the buffer.
		///     </para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         The buffer pointed to by the <paramref name="lpvObject" /> parameter must be sufficiently large to receive the information about the graphics
		///         object. Depending on the graphics object, the function uses a <see cref="BITMAP" />, DIBSECTION, <see cref="EXTLOGPEN" />,
		///         <see cref="LOGBRUSH" />, <see cref="LOGFONT" />, or <see cref="LOGPEN" /> structure, or a count of table entries (for a logical palette).
		///     </para>
		///     <para>
		///         If <paramref name="hgdiobj" /> is a handle to a bitmap created by calling <see cref="CreateDIBSection" />, and the specified buffer is large
		///         enough, the <see cref="GetObject" /> function returns a DIBSECTION structure. In addition, the <see cref="BITMAP.bmBits" /> member of the
		///         <see cref="BITMAP" /> structure contained within the DIBSECTION will contain a pointer to the bitmap's bit values.
		///     </para>
		///     <para>
		///         If <paramref name="hgdiobj" /> is a handle to a bitmap created by any other means, <see cref="GetObject" /> returns only the width, height,
		///         and color format information of the bitmap. You can obtain the bitmap's bit values by calling the <see cref="GetDIBits" /> or
		///         <see cref="GetBitmapBits" /> function.
		///     </para>
		///     <para>
		///         If <paramref name="hgdiobj" /> is a handle to a logical palette, <see cref="GetObject" /> retrieves a 2-byte integer that specifies the
		///         number of entries in the palette. The function does not retrieve the <see cref="LOGPALETTE" /> structure defining the palette. To retrieve
		///         information about palette entries, an application can call the <see cref="GetPaletteEntries" /> function.
		///     </para>
		///     <para>
		///         If <paramref name="hgdiobj" /> is a handle to a font, the <see cref="LOGFONT" /> that is returned is the <see cref="LOGFONT" /> used to
		///         create the font. If Windows had to make some interpolation of the font because the precise <see cref="LOGFONT" /> could not be represented,
		///         the interpolation will not be reflected in the <see cref="LOGFONT" />. For example, if you ask for a vertical version of a font that doesn't
		///         support vertical painting, the <see cref="LOGFONT" /> indicates the font is vertical, but Windows will paint it horizontally.
		///     </para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "GetObject")]
		public static extern int GetObject([In] IntPtr hgdiobj, int cbBuffer, IntPtr lpvObject);

		/// <summary>
		///     The <see cref="GetMetaRgn" /> function retrieves the current metaregion for the specified device context.
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <param name="hrgn">
		///     A handle to an existing region before the function is called. After the function returns, this parameter is a handle to a copy of the current
		///     metaregion.
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         If the function succeeds, <paramref name="hrgn" /> is a handle to a copy of the current metaregion. Subsequent changes to this copy will not
		///         affect the current metaregion.
		///     </para>
		///     <para>The current clipping region of a device context is defined by the intersection of its clipping region and its metaregion.</para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "GetMetaRgn")]
		public static extern int GetMetaRgn([In] IntPtr hdc, [In] IntPtr hrgn);

		/// <summary>
		///     The <see cref="GetMapMode" /> function retrieves the current mapping mode.
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <returns>
		///     <para>If the function succeeds, the return value specifies the mapping mode.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>The following are the various mapping modes.</remarks>
		[DllImport("gdi32.dll", EntryPoint = "GetMapMode")]
		public static extern int GetMapMode([In] IntPtr hdc);

		/// <summary>
		///     The <see cref="GetDCOrgEx" /> function retrieves the final translation origin for a specified device context (DC). The final translation origin
		///     specifies an offset that the system uses to translate device coordinates into client coordinates (for coordinates in an application's window).
		/// </summary>
		/// <param name="hdc">A handle to the DC whose final translation origin is to be retrieved.</param>
		/// <param name="lpPoint">
		///     A pointer to a <see cref="POINT" /> structure that receives the final translation origin, in device coordinates.
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>The final translation origin is relative to the physical origin of the screen.</remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "User32.GetDCOrgEx")]
		public static extern bool GetDCOrgEx([In] IntPtr hdc, [Out] out POINT lpPoint);

		/// <summary>
		///     The <see cref="GetClipRgn" /> function retrieves a handle identifying the current application-defined clipping region for the specified device
		///     context.
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <param name="hrgn">
		///     A handle to an existing region before the function is called. After the function returns, this parameter is a handle to a copy of the current
		///     clipping region.
		/// </param>
		/// <returns>
		///     If the function succeeds and there is no clipping region for the given device context, the return value is zero. If the function succeeds and
		///     there is a clipping region for the given device context, the return value is 1. If an error occurs, the return value is -1.
		/// </returns>
		/// <remarks>
		///     <para>
		///         An application-defined clipping region is a clipping region identified by the <see cref="SelectClipRgn" /> function. It is not a clipping
		///         region created when the application calls the <see cref="User32.BeginPaint" /> function.
		///     </para>
		///     <para>
		///         If the function succeeds, the <paramref name="hrgn" /> parameter is a handle to a copy of the current clipping region. Subsequent changes to
		///         this copy will not affect the current clipping region.
		///     </para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "GetClipRgn")]
		public static extern int GetClipRgn([In] IntPtr hdc, [In] IntPtr hrgn);

		/// <summary>
		///     The <see cref="GetClipBox" /> function retrieves the dimensions of the tightest bounding rectangle that can be drawn around the current visible
		///     area on the device. The visible area is defined by the current clipping region or clip path, as well as any overlapping windows.
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <param name="lprc">
		///     A pointer to a <see cref="RECT" /> structure that is to receive the rectangle dimensions, in logical units.
		/// </param>
		/// <returns>If the function succeeds, the return value specifies the clipping box's complexity and can be one of the following values.</returns>
		[DllImport("gdi32.dll", EntryPoint = "GetClipBox")]
		public static extern int GetClipBox([In] IntPtr hdc, [Out] out RECT lprc);

		/// <summary>
		///     The <see cref="GetBkColor" /> function returns the current background color for the specified device context.
		/// </summary>
		/// <param name="hdc">Handle to the device context whose background color is to be returned.</param>
		/// <returns>
		///     <para>
		///         If the function succeeds, the return value is a <see cref="COLORREF" /> value for the current background color.
		///     </para>
		///     <para>If the function fails, the return value is CLR_INVALID.</para>
		/// </returns>
		[DllImport("gdi32.dll", EntryPoint = "GetBkColor")]
		public static extern uint GetBkColor([In] IntPtr hdc);

		/// <summary>
		///     The <see cref="GdiComment" /> function copies a comment from a buffer into a specified enhanced-format metafile.
		/// </summary>
		/// <param name="hdc">A handle to an enhanced-metafile device context.</param>
		/// <param name="cbSize">The length of the comment buffer, in bytes.</param>
		/// <param name="lpData">A pointer to the buffer that contains the comment.</param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         A comment can include any kind of private information, for example, the source of a picture and the date it was created. A comment should
		///         begin with an application signature, followed by the data.
		///     </para>
		///     <para>
		///         Comments should not contain application-specific or position-specific data. Position-specific data specifies the location of a record, and it
		///         should not be included because one metafile may be embedded within another metafile.
		///     </para>
		///     <para>
		///         A public comment is a comment that begins with the comment signature identifier GDICOMMENT_IDENTIFIER. The following public comments are
		///         defined.
		///     </para>
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "GdiComment")]
		public static extern bool GdiComment([In] IntPtr hdc, uint cbSize, [In] IntPtr lpData);

		/// <summary>
		///     <para>
		///         The <see cref="EnumFonts" /> function enumerates the fonts available on a specified device. For each font with the specified typeface name,
		///         the <see cref="EnumFonts" /> function retrieves information about that font and passes it to the application defined callback function. This
		///         callback function can process the font information as desired. Enumeration continues until there are no more fonts or the callback function
		///         returns zero.
		///     </para>
		///     <para>
		///         Note:  This function is provided only for compatibility with 16-bit versions of Windows. Applications should use the
		///         <see cref="EnumFontFamiliesEx" /> function.
		///     </para>
		/// </summary>
		/// <param name="hdc">A handle to the device context from which to enumerate the fonts.</param>
		/// <param name="lpFaceName">
		///     A pointer to a null-terminated string that specifies the typeface name of the desired fonts. If <paramref name="lpFaceName" /> is NULL,
		///     <see cref="EnumFonts" /> randomly selects and enumerates one font of each available typeface.
		/// </param>
		/// <param name="lpFontFunc">
		///     A pointer to the application defined callback function. For more information, see <see cref="EnumFontFamExProc" />.
		/// </param>
		/// <param name="lParam">A pointer to any application-defined data. The data is passed to the callback function along with the font information.</param>
		/// <returns>The return value is the last value returned by the callback function. Its meaning is defined by the application.</returns>
		/// <remarks>
		///     <para>
		///         Use <see cref="EnumFontFamiliesEx" /> instead of <see cref="EnumFonts" />. The <see cref="EnumFontFamiliesEx" /> function differs from the
		///         <see cref="EnumFonts" /> function in that it retrieves the style names associated with a TrueType font. With
		///         <see cref="EnumFontFamiliesEx" />, you can retrieve information about font styles that cannot be enumerated using the
		///         <see cref="EnumFonts" /> function.
		///     </para>
		///     <para>
		///         The fonts for many East Asian languages have two typeface names: an English name and a localized name. <see cref="EnumFonts" />,
		///         <see cref="EnumFontFamilies" />, and <see cref="EnumFontFamiliesEx" /> return the English typeface name if the system locale does not match
		///         the language of the font.
		///     </para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "EnumFonts")]
		public static extern int EnumFonts([In] IntPtr hdc, [In] string lpFaceName, EnumFontFamExProc lpFontFunc, [MarshalAs(UnmanagedType.SysInt)] int lParam);

		/// <summary>
		///     The <see cref="DrawEscape" /> function provides drawing capabilities of the specified video display that are not directly available through the
		///     graphics device interface (GDI).
		/// </summary>
		/// <param name="hdc">A handle to the DC for the specified video display.</param>
		/// <param name="nEscape">The escape function to be performed.</param>
		/// <param name="cbInput">
		///     The number of bytes of data pointed to by the <paramref name="lpszInData" /> parameter.
		/// </param>
		/// <param name="lpszInData">A pointer to the input structure required for the specified escape.</param>
		/// <returns>
		///     <para>
		///         If the function is successful, the return value is greater than zero except for the QUERYESCSUPPORT draw escape, which checks for
		///         implementation only.
		///     </para>
		///     <para>If the escape is not implemented, the return value is zero.</para>
		///     <para>If an error occurred, the return value is less than zero.</para>
		/// </returns>
		/// <remarks>
		///     When an application calls the <see cref="DrawEscape" /> function, the data identified by <paramref name="cbInput" /> and
		///     <paramref name="lpszInData" /> is passed directly to the specified display driver.
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "DrawEscape")]
		public static extern int DrawEscape([In] IntPtr hdc, int nEscape, int cbInput, [In] [MarshalAs(UnmanagedType.LPStr)] string lpszInData);

		/// <summary>
		///     The <see cref="CombineRgn" /> function combines two regions and stores the result in a third region. The two regions are combined according to
		///     the specified mode.
		/// </summary>
		/// <param name="hrgnDest">
		///     A handle to a new region with dimensions defined by combining two other regions. (This region must exist before <see cref="CombineRgn" /> is
		///     called.)
		/// </param>
		/// <param name="hrgnSrc1">A handle to the first of two regions to be combined.</param>
		/// <param name="hrgnSrc2">A handle to the second of two regions to be combined.</param>
		/// <param name="fnCombineMode">
		///     <para>A mode indicating how the two regions will be combined. This parameter can be one of the following values.</para>
		///     <list type="table">
		///         <item>
		///             <term>RGN_AND</term>
		///             <description>Creates the intersection of the two combined regions.</description>
		///         </item>
		///         <item>
		///             <term>RGN_COPY</term>
		///             <description>
		///                 Creates a copy of the region identified by <paramref name="hrgnSrc1" />.
		///             </description>
		///         </item>
		///         <item>
		///             <term>RGN_DIFF</term>
		///             <description>
		///                 Combines the parts of <paramref name="hrgnSrc1" /> that are not part of <paramref name="hrgnSrc2" />.
		///             </description>
		///         </item>
		///         <item>
		///             <term>RGN_OR</term>
		///             <description>Creates the union of two combined regions.</description>
		///         </item>
		///         <item>
		///             <term>RGN_XOR</term>
		///             <description>Creates the union of two combined regions except for any overlapping areas.</description>
		///         </item>
		///     </list>
		/// </param>
		/// <returns>The return value specifies the type of the resulting region. It can be one of the following values.</returns>
		/// <remarks>
		///     The three regions need not be distinct. For example, the <paramref name="hrgnSrc1" /> parameter can equal the <paramref name="hrgnDest" />
		///     parameter.
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "CombineRgn")]
		public static extern int CombineRgn([In] IntPtr hrgnDest, [In] IntPtr hrgnSrc1, [In] IntPtr hrgnSrc2, int fnCombineMode);

		/// <summary>
		///     The <see cref="WidenPath" /> function redefines the current path as the area that would be painted if the path were stroked using the pen
		///     currently selected into the given device context.
		/// </summary>
		/// <param name="hdc">A handle to a device context that contains a closed path.</param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         The <see cref="WidenPath" /> function is successful only if the current pen is a geometric pen created by the <see cref="ExtCreatePen" />
		///         function, or if the pen is created with the <see cref="CreatePen" /> function and has a width, in device units, of more than one.
		///     </para>
		///     <para>
		///         The device context identified by the <paramref name="hdc" /> parameter must contain a closed path.
		///     </para>
		///     <para>
		///         Any Bézier curves in the path are converted to sequences of straight lines approximating the widened curves. As such, no Bézier curves remain
		///         in the path after <see cref="WidenPath" /> is called.
		///     </para>
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "WidenPath")]
		public static extern bool WidenPath([In] IntPtr hdc);

		/// <summary>
		///     The <see cref="StartPage" /> function prepares the printer driver to accept data.
		/// </summary>
		/// <param name="hDC">A handle to the device context for the print job.</param>
		/// <returns>
		///     <para>If the function succeeds, the return value is greater than zero.</para>
		///     <para>If the function fails, the return value is less than or equal to zero.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         Note:  This is a blocking or synchronous function and might not return immediately. How quickly this function returns depends on run-time
		///         factors such as network status, print server configuration, and printer driver implementation—factors that are difficult to predict when
		///         writing an application. Calling this function from a thread that manages interaction with the user interface could make the application
		///         appear to be unresponsive.
		///     </para>
		///     <para>
		///         The system disables the <see cref="ResetDC" /> function between calls to the <see cref="StartPage" /> and <see cref="EndPage" /> functions.
		///         This means that you cannot change the device mode except at page boundaries. After calling <see cref="EndPage" />, you can call
		///         <see cref="ResetDC" /> to change the device mode, if necessary. Note that a call to <see cref="ResetDC" /> resets all device context
		///         attributes back to default values.
		///     </para>
		///     <para>
		///         Neither <see cref="EndPage" /> nor <see cref="StartPage" /> resets the device context attributes. Device context attributes remain constant
		///         across subsequent pages. You do not need to re-select objects and set up the mapping mode again before printing the next page; however, doing
		///         so will produce the same results and reduce code differences between versions of Windows.
		///     </para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "StartPage")]
		public static extern int StartPage([In] IntPtr hDC);

		/// <summary>
		///     The <see cref="StartDoc" /> function starts a print job.
		/// </summary>
		/// <param name="hdc">A handle to the device context for the print job.</param>
		/// <param name="lpdi">
		///     A pointer to a <see cref="DOCINFO" /> structure containing the name of the document file and the name of the output file.
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is greater than zero. This value is the print job identifier for the document.</para>
		///     <para>If the function fails, the return value is less than or equal to zero.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         Note:  This is a blocking or synchronous function and might not return immediately. How quickly this function returns depends on run-time
		///         factors such as network status, print server configuration, and printer driver implementation—factors that are difficult to predict when
		///         writing an application. Calling this function from a thread that manages interaction with the user interface could make the application
		///         appear to be unresponsive.
		///     </para>
		///     <para>
		///         Applications should call the <see cref="StartDoc" /> function immediately before beginning a print job. Using this function ensures that
		///         multipage documents are not interspersed with other print jobs.
		///     </para>
		///     <para>
		///         Applications can use the value returned by <see cref="StartDoc" /> to retrieve or set the priority of a print job. Call the GetJob or SetJob
		///         function and supply this value as one of the required arguments.
		///     </para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "StartDoc")]
		public static extern int StartDoc([In] IntPtr hdc, [In] ref DOCINFO lpdi);

		/// <summary>
		///     The <see cref="SetPixelV" /> function sets the pixel at the specified coordinates to the closest approximation of the specified color. The point
		///     must be in the clipping region and the visible part of the device surface.
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <param name="X">The x-coordinate, in logical units, of the point to be set.</param>
		/// <param name="Y">The y-coordinate, in logical units, of the point to be set.</param>
		/// <param name="crColor">
		///     The color to be used to paint the point. To create a <see cref="COLORREF" /> color value, use the RGB macro.
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         Not all devices support the <see cref="SetPixelV" /> function. For more information, see the description of the RC_BITBLT capability in the
		///         <see cref="GetDeviceCaps" /> function.
		///     </para>
		///     <para>
		///         <see cref="SetPixelV" /> is faster than <see cref="SetPixel" /> because it does not need to return the color value of the point actually
		///         painted.
		///     </para>
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "SetPixelV")]
		public static extern bool SetPixelV([In] IntPtr hdc, int X, int Y, uint crColor);

		/// <summary>
		///     The <see cref="SetLayout" /> function changes the layout of a device context (DC).
		/// </summary>
		/// <param name="hdc">A handle to the DC.</param>
		/// <param name="dwLayout">
		///     <para>The DC layout. This parameter can be one or more of the following values.</para>
		///     <list type="table">
		///         <item>
		///             <term>LAYOUT_BITMAPORIENTATIONPRESERVED</term>
		///             <description>
		///                 Disables any reflection during <see cref="BitBlt" /> and <see cref="StretchBlt" /> operations.
		///             </description>
		///         </item>
		///         <item>
		///             <term>LAYOUT_RTL</term>
		///             <description>Sets the default horizontal layout to be right to left.</description>
		///         </item>
		///     </list>
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, it returns the previous layout of the DC.</para>
		///     <para>If the function fails, it returns GDI_ERROR.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         The layout specifies the order in which text and graphics are revealed in a window or a device context. The default is left to right. The
		///         <see cref="SetLayout" /> function changes this to be right to left, which is the standard in Arabic and Hebrew cultures.
		///     </para>
		///     <para>
		///         Once the LAYOUT_RTL flag is selected, flags normally specifying right or left are reversed. To avoid confusion, consider defining alternate
		///         words for standard flags, such as those in the following table.
		///     </para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "SetLayout")]
		public static extern uint SetLayout([In] IntPtr hdc, uint dwLayout);

		/// <summary>
		///     The <see cref="SetDIBits" /> function sets the pixels in a compatible bitmap (DDB) using the color data found in the specified DIB.
		/// </summary>
		/// <param name="hdc">A handle to a device context.</param>
		/// <param name="hbmp">A handle to the compatible bitmap (DDB) that is to be altered using the color data from the specified DIB.</param>
		/// <param name="uStartScan">
		///     The starting scan line for the device-independent color data in the array pointed to by the <paramref name="lpvBits" /> parameter.
		/// </param>
		/// <param name="cScanLines">The number of scan lines found in the array containing device-independent color data.</param>
		/// <param name="lpvBits">
		///     A pointer to the DIB color data, stored as an array of bytes. The format of the bitmap values depends on the
		///     <see cref="BITMAPINFOHEADER.biBitCount" /> member of the <see cref="BITMAPINFO" /> structure pointed to by the <paramref name="lpbmi" />
		///     parameter.
		/// </param>
		/// <param name="lpbmi">
		///     A pointer to a <see cref="BITMAPINFO" /> structure that contains information about the DIB.
		/// </param>
		/// <param name="fuColorUse">
		///     <para>
		///         Indicates whether the <see cref="BITMAPINFO.bmiColors" /> member of the <see cref="BITMAPINFO" /> structure was provided and, if so, whether
		///         <see cref="BITMAPINFO.bmiColors" /> contains explicit red, green, blue (RGB) values or palette indexes. The <paramref name="fuColorUse" />
		///         parameter must be one of the following values.
		///     </para>
		///     <list type="table">
		///         <item>
		///             <term>DIB_PAL_COLORS</term>
		///             <description>
		///                 The color table consists of an array of 16-bit indexes into the logical palette of the device context identified by the
		///                 <paramref name="hdc" /> parameter.
		///             </description>
		///         </item>
		///         <item>
		///             <term>DIB_RGB_COLORS</term>
		///             <description>The color table is provided and contains literal RGB values.</description>
		///         </item>
		///     </list>
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is the number of scan lines copied.</para>
		///     <para>If the function fails, the return value is zero.</para>
		///     <para>This can be the following value.</para>
		/// </returns>
		/// <remarks>
		///     <para>Optimal bitmap drawing speed is obtained when the bitmap bits are indexes into the system palette.</para>
		///     <para>
		///         Applications can retrieve the system palette colors and indexes by calling the <see cref="GetSystemPaletteEntries" /> function. After the
		///         colors and indexes are retrieved, the application can create the DIB. For more information, see System Palette.
		///     </para>
		///     <para>
		///         The device context identified by the <paramref name="hdc" /> parameter is used only if the DIB_PAL_COLORS constant is set for the
		///         <paramref name="fuColorUse" /> parameter; otherwise it is ignored.
		///     </para>
		///     <para>
		///         The bitmap identified by the <paramref name="hbmp" /> parameter must not be selected into a device context when the application calls this
		///         function.
		///     </para>
		///     <para>The scan lines must be aligned on a DWORD except for RLE-compressed bitmaps.</para>
		///     <para>The origin for bottom-up DIBs is the lower-left corner of the bitmap; the origin for top-down DIBs is the upper-left corner of the bitmap.</para>
		///     <para>
		///         ICM: Color management is performed if color management has been enabled with a call to <see cref="SetICMMode" /> with the iEnableICM
		///         parameter set to ICM_ON. If the bitmap specified by <paramref name="lpbmi" /> has a
		///         <see cref="BITMAPV4HEADER" /> that specifies the gamma and endpoints members, or a <see cref="BITMAPV5HEADER" /> that specifies either the
		///         gamma and endpoints members or the profileData and profileSize members, then the call treats the bitmap's pixels as being expressed in the
		///         color space described by those members, rather than in the device context's source color space.
		///     </para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "SetDIBits")]
		public static extern int SetDIBits(
			[In] IntPtr hdc, [In] IntPtr hbmp, uint uStartScan, uint cScanLines, [In] IntPtr lpvBits, [In] ref BITMAPINFO lpbmi, uint fuColorUse);

		/// <summary>
		///     The <see cref="SetBkMode" /> function sets the background mix mode of the specified device context. The background mix mode is used with text,
		///     hatched brushes, and pen styles that are not solid lines.
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <param name="iBkMode">
		///     <para>The background mode. This parameter can be one of the following values.</para>
		///     <list type="table">
		///         <item>
		///             <term>OPAQUE</term>
		///             <description>Background is filled with the current background color before the text, hatched brush, or pen is drawn.</description>
		///         </item>
		///         <item>
		///             <term>TRANSPARENT</term>
		///             <description>Background remains untouched.</description>
		///         </item>
		///     </list>
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value specifies the previous background mode.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     The <see cref="SetBkMode" /> function affects the line styles for lines drawn using a pen created by the <see cref="CreatePen" /> function.
		///     <see cref="SetBkMode" /> does not affect lines drawn using a pen created by the <see cref="ExtCreatePen" /> function.
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "SetBkMode")]
		public static extern int SetBkMode([In] IntPtr hdc, int iBkMode);

		/// <summary>
		///     The <see cref="RoundRect" /> function draws a rectangle with rounded corners. The rectangle is outlined by using the current pen and filled by
		///     using the current brush.
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <param name="nLeftRect">The x-coordinate, in logical coordinates, of the upper-left corner of the rectangle.</param>
		/// <param name="nTopRect">The y-coordinate, in logical coordinates, of the upper-left corner of the rectangle.</param>
		/// <param name="nRightRect">The x-coordinate, in logical coordinates, of the lower-right corner of the rectangle.</param>
		/// <param name="nBottomRect">The y-coordinate, in logical coordinates, of the lower-right corner of the rectangle.</param>
		/// <param name="nWidth">The width, in logical coordinates, of the ellipse used to draw the rounded corners.</param>
		/// <param name="nHeight">The height, in logical coordinates, of the ellipse used to draw the rounded corners.</param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>The current position is neither used nor updated by this function.</remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "RoundRect")]
		public static extern bool RoundRect([In] IntPtr hdc, int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidth, int nHeight);

		/// <summary>
		///     The <see cref="RestoreDC" /> function restores a device context (DC) to the specified state. The DC is restored by popping state information off
		///     a stack created by earlier calls to the <see cref="SaveDC" /> function.
		/// </summary>
		/// <param name="hdc">A handle to the DC.</param>
		/// <param name="nSavedDC">
		///     The saved state to be restored. If this parameter is positive, <paramref name="nSavedDC" /> represents a specific instance of the state to be
		///     restored. If this parameter is negative, <paramref name="nSavedDC" /> represents an instance relative to the current state. For example, -1
		///     restores the most recently saved state.
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     The stack can contain the state information for several instances of the DC. If the state specified by the specified parameter is not at the top
		///     of the stack, <see cref="RestoreDC" /> deletes all state information between the top of the stack and the specified instance.
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "RestoreDC")]
		public static extern bool RestoreDC([In] IntPtr hdc, int nSavedDC);

		/// <summary>
		///     The <see cref="Rectangle" /> function draws a rectangle. The rectangle is outlined by using the current pen and filled by using the current
		///     brush.
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <param name="nLeftRect">The x-coordinate, in logical coordinates, of the upper-left corner of the rectangle.</param>
		/// <param name="nTopRect">The y-coordinate, in logical coordinates, of the upper-left corner of the rectangle.</param>
		/// <param name="nRightRect">The x-coordinate, in logical coordinates, of the lower-right corner of the rectangle.</param>
		/// <param name="nBottomRect">The y-coordinate, in logical coordinates, of the lower-right corner of the rectangle.</param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         The current position is neither used nor updated by <see cref="Rectangle" />.
		///     </para>
		///     <para>The rectangle that is drawn excludes the bottom and right edges.</para>
		///     <para>If a PS_NULL pen is used, the dimensions of the rectangle are 1 pixel less in height and 1 pixel less in width.</para>
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "Rectangle")]
		public static extern bool Rectangle([In] IntPtr hdc, int nLeftRect, int nTopRect, int nRightRect, int nBottomRect);

		/// <summary>
		///     The <see cref="PtVisible" /> function determines whether the specified point is within the clipping region of a device context.
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <param name="X">The x-coordinate, in logical units, of the point.</param>
		/// <param name="Y">The y-coordinate, in logical units, of the point.</param>
		/// <returns>
		///     <para>If the specified point is within the clipping region of the device context, the return value is TRUE(1).</para>
		///     <para>If the specified point is not within the clipping region of the device context, the return value is FALSE(0).</para>
		///     <para>
		///         If the <see cref="hdc" /> is not valid, the return value is (BOOL)-1.
		///     </para>
		/// </returns>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "PtVisible")]
		public static extern bool PtVisible([In] IntPtr hdc, int X, int Y);

		/// <summary>
		///     The <see cref="OffsetRgn" /> function moves a region by the specified offsets.
		/// </summary>
		/// <param name="hrgn">Handle to the region to be moved.</param>
		/// <param name="nXOffset">Specifies the number of logical units to move left or right.</param>
		/// <param name="nYOffset">Specifies the number of logical units to move up or down.</param>
		/// <returns>The return value specifies the new region's complexity. It can be one of the following values.</returns>
		[DllImport("gdi32.dll", EntryPoint = "OffsetRgn")]
		public static extern int OffsetRgn([In] IntPtr hrgn, int nXOffset, int nYOffset);

		/// <summary>
		///     The <see cref="InvertRgn" /> function inverts the colors in the specified region.
		/// </summary>
		/// <param name="hdc">Handle to the device context.</param>
		/// <param name="hrgn">Handle to the region for which colors are inverted. The region's coordinates are presumed to be logical coordinates.</param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     On monochrome screens, the <see cref="InvertRgn" /> function makes white pixels black and black pixels white. On color screens, this inversion is
		///     dependent on the type of technology used to generate the colors for the screen.
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "InvertRgn")]
		public static extern bool InvertRgn([In] IntPtr hdc, [In] IntPtr hrgn);

		/// <summary>
		///     The <see cref="GetRgnBox" /> function retrieves the bounding rectangle of the specified region.
		/// </summary>
		/// <param name="hrgn">A handle to the region.</param>
		/// <param name="lprc">
		///     A pointer to a <see cref="RECT" /> structure that receives the bounding rectangle in logical units.
		/// </param>
		/// <returns>The return value specifies the region's complexity. It can be one of the following values:</returns>
		[DllImport("gdi32.dll", EntryPoint = "GetRgnBox")]
		public static extern int GetRgnBox([In] IntPtr hrgn, [Out] out RECT lprc);

		/// <summary>
		///     The <see cref="GetLayout" /> function returns the layout of a device context (DC).
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <returns>
		///     <para>If the function succeeds, it returns the layout flags for the current device context.</para>
		///     <para>If the function fails, it returns GDI_ERROR. For extended error information, call GetLastError.</para>
		/// </returns>
		/// <remarks>
		///     The layout specifies the order in which text and graphics are revealed in a window or device context. The default is left to right. The
		///     <see cref="GetLayout" /> function tells you if the default has been changed through a call to <see cref="SetLayout" />. For more information, see
		///     "Window Layout and Mirroring" in Window Features.
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "GetLayout")]
		public static extern uint GetLayout([In] IntPtr hdc);

		/// <summary>
		///     The <see cref="GetDIBits" /> function retrieves the bits of the specified compatible bitmap and copies them into a buffer as a DIB using the
		///     specified format.
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <param name="hbmp">A handle to the bitmap. This must be a compatible bitmap (DDB).</param>
		/// <param name="uStartScan">The first scan line to retrieve.</param>
		/// <param name="cScanLines">The number of scan lines to retrieve.</param>
		/// <param name="lpvBits">
		///     A pointer to a buffer to receive the bitmap data. If this parameter is NULL, the function passes the dimensions and format of the bitmap to the
		///     <see cref="BITMAPINFO" /> structure pointed to by the <paramref name="lpbi" /> parameter.
		/// </param>
		/// <param name="lpbi">
		///     A pointer to a <see cref="BITMAPINFO" /> structure that specifies the desired format for the DIB data.
		/// </param>
		/// <param name="uUsage">
		///     <para>
		///         The format of the <see cref="BITMAPINFO.bmiColors" /> member of the <see cref="BITMAPINFO" /> structure. It must be one of the following
		///         values.
		///     </para>
		///     <list type="table">
		///         <item>
		///             <term>DIB_PAL_COLORS</term>
		///             <description>The color table should consist of an array of 16-bit indexes into the current logical palette.</description>
		///         </item>
		///         <item>
		///             <term>DIB_RGB_COLORS</term>
		///             <description>The color table should consist of literal red, green, blue (RGB) values.</description>
		///         </item>
		///     </list>
		/// </param>
		/// <returns>
		///     <para>
		///         If the <paramref name="lpvBits" /> parameter is non-NULL and the function succeeds, the return value is the number of scan lines copied from
		///         the bitmap.
		///     </para>
		///     <para>
		///         If the <paramref name="lpvBits" /> parameter is NULL and <see cref="GetDIBits" /> successfully fills the <see cref="BITMAPINFO" /> structure,
		///         the return value is nonzero.
		///     </para>
		///     <para>If the function fails, the return value is zero.</para>
		///     <para>This function can return the following value.</para>
		/// </returns>
		/// <remarks>
		///     If the requested format for the DIB matches its internal format, the RGB values for the bitmap are copied. If the requested format doesn't match
		///     the internal format, a color table is synthesized. The following table describes the color table synthesized for each format.
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "GetDIBits")]
		public static extern int GetDIBits([In] IntPtr hdc, [In] IntPtr hbmp, uint uStartScan, uint cScanLines, IntPtr lpvBits, ref BITMAPINFO lpbi, uint uUsage);

		/// <summary>
		///     The <see cref="GetBkMode" /> function returns the current background mix mode for a specified device context. The background mix mode of a device
		///     context affects text, hatched brushes, and pen styles that are not solid lines.
		/// </summary>
		/// <param name="hdc">Handle to the device context whose background mode is to be returned.</param>
		/// <returns>
		///     <para>If the function succeeds, the return value specifies the current background mix mode, either OPAQUE or TRANSPARENT.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		[DllImport("gdi32.dll", EntryPoint = "GetBkMode")]
		public static extern int GetBkMode([In] IntPtr hdc);

		/// <summary>
		///     <para>
		///         The <see cref="FloodFill" /> function fills an area of the display surface with the current brush. The area is assumed to be bounded as
		///         specified by the <paramref name="crFill" /> parameter.
		///     </para>
		///     <para>
		///         Note:  The <see cref="FloodFill" /> function is included only for compatibility with 16-bit versions of Windows. Applications should use the
		///         <see cref="ExtFloodFill" /> function with FLOODFILLBORDER specified.
		///     </para>
		/// </summary>
		/// <param name="hdc">A handle to a device context.</param>
		/// <param name="nXStart">The x-coordinate, in logical units, of the point where filling is to start.</param>
		/// <param name="nYStart">The y-coordinate, in logical units, of the point where filling is to start.</param>
		/// <param name="crFill">
		///     The color of the boundary or the area to be filled. To create a <see cref="COLORREF" /> color value, use the RGB macro.
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>The following are reasons this function might fail:</remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "FloodFill")]
		public static extern bool FloodFill([In] IntPtr hdc, int nXStart, int nYStart, uint crFill);

		/// <summary>
		///     The <see cref="ExtEscape" /> function enables an application to access device capabilities that are not available through GDI.
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <param name="nEscape">
		///     <para>The escape function to be performed. It can be one of the following or it can be an application-defined escape function.</para>
		///     <list type="table">
		///         <item>
		///             <term>CHECKJPEGFORMAT</term>
		///             <description>Checks whether the printer supports a JPEG image.</description>
		///         </item>
		///         <item>
		///             <term>CHECKPNGFORMAT</term>
		///             <description>Checks whether the printer supports a PNG image.</description>
		///         </item>
		///         <item>
		///             <term>DRAWPATTERNRECT</term>
		///             <description>Draws a white, gray-scale, or black rectangle.</description>
		///         </item>
		///         <item>
		///             <term>GET_PS_FEATURESETTING</term>
		///             <description>Gets information on a specified feature setting for a PostScript driver.</description>
		///         </item>
		///         <item>
		///             <term>GETTECHNOLOGY</term>
		///             <description>Reports on whether or not the driver is a Postscript driver.</description>
		///         </item>
		///         <item>
		///             <term>PASSTHROUGH</term>
		///             <description>Allows the application to send data directly to a printer. Supported in compatibility mode and GDI-centric mode.</description>
		///         </item>
		///         <item>
		///             <term>POSTSCRIPT_DATA</term>
		///             <description>Allows the application to send data directly to a printer. Supported only in compatibility mode.</description>
		///         </item>
		///         <item>
		///             <term>POSTSCRIPT_IDENTIFY</term>
		///             <description>Sets a PostScript driver to GDI-centric or PostScript-centric mode.</description>
		///         </item>
		///         <item>
		///             <term>POSTSCRIPT_INJECTION</term>
		///             <description>Inserts a block of raw data in a PostScript job stream.</description>
		///         </item>
		///         <item>
		///             <term>POSTSCRIPT_PASSTHROUGH</term>
		///             <description>Sends data directly to a PostScript printer driver. Supported in compatibility mode and PostScript-centric mode.</description>
		///         </item>
		///         <item>
		///             <term>QUERYESCSUPPORT</term>
		///             <description>Determines whether a particular escape is implemented by the device driver.</description>
		///         </item>
		///         <item>
		///             <term>SPCLPASSTHROUGH2</term>
		///             <description>Enables applications to include private procedures and other resources at the document level-save context.</description>
		///         </item>
		///     </list>
		/// </param>
		/// <param name="cbInput">
		///     The number of bytes of data pointed to by the <paramref name="lpszInData" /> parameter.
		/// </param>
		/// <param name="lpszInData">A pointer to the input structure required for the specified escape. See also Remarks.</param>
		/// <param name="cbOutput">
		///     The number of bytes of data pointed to by the <paramref name="lpszOutData" /> parameter.
		/// </param>
		/// <param name="lpszOutData">
		///     A pointer to the structure that receives output from this escape. This parameter must not be NULL if <see cref="ExtEscape" /> is called as a
		///     query function. If no data is to be returned in this structure, set <paramref name="cbOutput" /> to 0. See also Remarks.
		/// </param>
		/// <returns>
		///     The return value specifies the outcome of the function. It is greater than zero if the function is successful, except for the QUERYESCSUPPORT
		///     printer escape, which checks for implementation only. The return value is zero if the escape is not implemented. A return value less than zero
		///     indicates an error.
		/// </returns>
		/// <remarks>
		///     <para>
		///         Note:  This is a blocking or synchronous function and might not return immediately. How quickly this function returns depends on run-time
		///         factors such as network status, print server configuration, and printer driver implementation—factors that are difficult to predict when
		///         writing an application. Calling this function from a thread that manages interaction with the user interface could make the application
		///         appear to be unresponsive.
		///     </para>
		///     <para>Use this function to pass a driver-defined escape value to a device.</para>
		///     <para>
		///         Use the Escape function to pass one of the system-defined escape values to a device, unless the escape is one of the defined escapes in
		///         <paramref name="nEscape" />. <see cref="ExtEscape" /> might not work properly with the system-defined escapes. In particular, escapes in
		///         which <paramref name="lpszInData" /> is a pointer to a structure that contains a member that is a pointer will fail.
		///     </para>
		///     <para>Note, that the behavior described in this article is the expected behavior, but it is up to the driver to comply with this model.</para>
		///     <para>
		///         The variables referenced by <paramref name="lpszInData" /> and <paramref name="lpszOutData" /> should not be the same or overlap. If the
		///         input and the output buffer size variables overlap, they may not contain the correct values after the call returns. For the best results,
		///         <paramref name="lpszInData" /> and <paramref name="lpszOutData" /> should refer to different variables.
		///     </para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "ExtEscape")]
		public static extern int ExtEscape(
			[In] IntPtr hdc, int nEscape, int cbInput, [In] [MarshalAs(UnmanagedType.LPStr)] string lpszInData, int cbOutput, IntPtr lpszOutData);

		/// <summary>
		///     The <see cref="CreatePen" /> function creates a logical pen that has the specified style, width, and color. The pen can subsequently be selected
		///     into a device context and used to draw lines and curves.
		/// </summary>
		/// <param name="fnPenStyle">
		///     <para>The pen style. It can be any one of the following values.</para>
		///     <list type="table">
		///         <item>
		///             <term>PS_SOLID</term>
		///             <description>The pen is solid.</description>
		///         </item>
		///         <item>
		///             <term>PS_DASH</term>
		///             <description>The pen is dashed. This style is valid only when the pen width is one or less in device units.</description>
		///         </item>
		///         <item>
		///             <term>PS_DOT</term>
		///             <description>The pen is dotted. This style is valid only when the pen width is one or less in device units.</description>
		///         </item>
		///         <item>
		///             <term>PS_DASHDOT</term>
		///             <description>The pen has alternating dashes and dots. This style is valid only when the pen width is one or less in device units.</description>
		///         </item>
		///         <item>
		///             <term>PS_DASHDOTDOT</term>
		///             <description>The pen has alternating dashes and double dots. This style is valid only when the pen width is one or less in device units.</description>
		///         </item>
		///         <item>
		///             <term>PS_NULL</term>
		///             <description>The pen is invisible.</description>
		///         </item>
		///         <item>
		///             <term>PS_INSIDEFRAME</term>
		///             <description>
		///                 The pen is solid. When this pen is used in any GDI drawing function that takes a bounding rectangle, the dimensions of the figure are
		///                 shrunk so that it fits entirely in the bounding rectangle, taking into account the width of the pen. This applies only to geometric
		///                 pens.
		///             </description>
		///         </item>
		///     </list>
		/// </param>
		/// <param name="nWidth">
		///     <para>
		///         The width of the pen, in logical units. If <paramref name="nWidth" /> is zero, the pen is a single pixel wide, regardless of the current
		///         transformation.
		///     </para>
		///     <para>
		///         <see cref="CreatePen" /> returns a pen with the specified width bit with the PS_SOLID style if you specify a width greater than one for the
		///         following styles: PS_DASH, PS_DOT, PS_DASHDOT, PS_DASHDOTDOT.
		///     </para>
		/// </param>
		/// <param name="crColor">
		///     A color reference for the pen color. To generate a <see cref="COLORREF" /> structure, use the RGB macro.
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is a handle that identifies a logical pen.</para>
		///     <para>If the function fails, the return value is NULL.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         After an application creates a logical pen, it can select that pen into a device context by calling the <see cref="SelectObject" /> function.
		///         After a pen is selected into a device context, it can be used to draw lines and curves.
		///     </para>
		///     <para>
		///         If the value specified by the <paramref name="nWidth" /> parameter is zero, a line drawn with the created pen always is a single pixel wide
		///         regardless of the current transformation.
		///     </para>
		///     <para>
		///         If the value specified by <paramref name="nWidth" /> is greater than 1, the <paramref name="fnPenStyle" /> parameter must be PS_NULL,
		///         PS_SOLID, or PS_INSIDEFRAME.
		///     </para>
		///     <para>
		///         If the value specified by <paramref name="nWidth" /> is greater than 1 and <paramref name="fnPenStyle" /> is PS_INSIDEFRAME, the line
		///         associated with the pen is drawn inside the frame of all primitives except polygons and polylines.
		///     </para>
		///     <para>
		///         If the value specified by <paramref name="nWidth" /> is greater than 1, <paramref name="fnPenStyle" /> is PS_INSIDEFRAME, and the color
		///         specified by the <paramref name="crColor" /> parameter does not match one of the entries in the logical palette, the system draws lines by
		///         using a dithered color. Dithered colors are not available with solid pens.
		///     </para>
		///     <para>
		///         When you no longer need the pen, call the <see cref="DeleteObject" /> function to delete it.
		///     </para>
		///     <para>
		///         ICM: No color management is done at creation. However, color management is performed when the pen is selected into an ICM-enabled device
		///         context.
		///     </para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "CreatePen")]
		public static extern IntPtr CreatePen(int fnPenStyle, int nWidth, uint crColor);

		/// <summary>
		///     The <see cref="CreateIC" /> function creates an information context for the specified device. The information context provides a fast way to get
		///     information about the device without creating a device context (DC). However, GDI drawing functions cannot accept a handle to an information
		///     context.
		/// </summary>
		/// <param name="lpszDriver">A pointer to a null-terminated character string that specifies the name of the device driver (for example, Epson).</param>
		/// <param name="lpszDevice">
		///     A pointer to a null-terminated character string that specifies the name of the specific output device being used, as shown by the Print Manager
		///     (for example, Epson FX-80). It is not the printer model name. The <paramref name="lpszDevice" /> parameter must be used.
		/// </param>
		/// <param name="lpszOutput">This parameter is ignored and should be set to NULL. It is provided only for compatibility with 16-bit Windows.</param>
		/// <param name="lpdvmInit">
		///     A pointer to a <see cref="DEVMODE" /> structure containing device-specific initialization data for the device driver. The DocumentProperties
		///     function retrieves this structure filled in for a specified device. The <paramref name="lpdvmInit" /> parameter must be NULL if the device driver
		///     is to use the default initialization (if any) specified by the user.
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is the handle to an information context.</para>
		///     <para>If the function fails, the return value is NULL.</para>
		/// </returns>
		/// <remarks>
		///     When you no longer need the information DC, call the <see cref="DeleteDC" /> function.
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "CreateIC")]
		public static extern IntPtr CreateIC([In] string lpszDriver, [In] string lpszDevice, [In] string lpszOutput, [In] IntPtr lpdvmInit);

		/// <summary>
		///     The <see cref="CreateDC" /> function creates a device context (DC) for a device using the specified name.
		/// </summary>
		/// <param name="lpszDriver">
		///     A pointer to a null-terminated character string that specifies either DISPLAY or the name of a specific display device. For printing, we
		///     recommend that you pass NULL to <paramref name="lpszDriver" /> because GDI ignores <paramref name="lpszDriver" /> for printer devices.
		/// </param>
		/// <param name="lpszDevice">
		///     <para>
		///         A pointer to a null-terminated character string that specifies the name of the specific output device being used, as shown by the Print
		///         Manager (for example, Epson FX-80). It is not the printer model name. The <paramref name="lpszDevice" /> parameter must be used.
		///     </para>
		///     <para>
		///         To obtain valid names for displays, call <see cref="User32.EnumDisplayDevices" />.
		///     </para>
		///     <para>
		///         If <paramref name="lpszDriver" /> is DISPLAY or the device name of a specific display device, then <paramref name="lpszDevice" /> must be
		///         NULL or that same device name. If <paramref name="lpszDevice" /> is NULL, then a DC is created for the primary display device.
		///     </para>
		///     <para>If there are multiple monitors on the system, calling CreateDC(TEXT("DISPLAY"),NULL,NULL,NULL) will create a DC covering all the monitors.</para>
		/// </param>
		/// <param name="lpszOutput">This parameter is ignored and should be set to NULL. It is provided only for compatibility with 16-bit Windows.</param>
		/// <param name="lpInitData">
		///     <para>
		///         A pointer to a <see cref="DEVMODE" /> structure containing device-specific initialization data for the device driver. The DocumentProperties
		///         function retrieves this structure filled in for a specified device. The <paramref name="lpInitData" />
		///         parameter must be NULL if the device driver is to use the default initialization (if any) specified by the user.
		///     </para>
		///     <para>
		///         If <paramref name="lpszDriver" /> is DISPLAY, <paramref name="lpInitData" /> must be NULL; GDI then uses the display device's current
		///         <see cref="DEVMODE" />.
		///     </para>
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is the handle to a DC for the specified device.</para>
		///     <para>If the function fails, the return value is NULL.</para>
		/// </returns>
		/// <remarks>
		///     <para>Note that the handle to the DC can only be used by a single thread at any one time.</para>
		///     <para>
		///         For parameters <paramref name="lpszDriver" /> and <paramref name="lpszDevice" />, call <see cref="User32.EnumDisplayDevices" /> to obtain
		///         valid names for displays.
		///     </para>
		///     <para>
		///         When you no longer need the DC, call the <see cref="DeleteDC" /> function.
		///     </para>
		///     <para>
		///         If <paramref name="lpszDriver" /> or <paramref name="lpszDevice" /> is DISPLAY, the thread that calls <see cref="CreateDC" /> owns the HDC
		///         that is created. When this thread is destroyed, the HDC is no longer valid. Thus, if you create the HDC and pass it to another thread, then
		///         exit the first thread, the second thread will not be able to use the HDC.
		///     </para>
		///     <para>
		///         When you call <see cref="CreateDC" /> to create the HDC> for a display device, you must pass to <paramref name="lpInitData" />
		///         either NULL or a pointer to <see cref="DEVMODE" /> that matches the current <see cref="DEVMODE" /> of the display device that
		///         <paramref name="lpszDevice" /> specifies. We recommend to pass NULL and not to try to exactly match the <see cref="DEVMODE" /> for the
		///         current display device.
		///     </para>
		///     <para>
		///         When you call <see cref="CreateDC" /> to create the HDC for a printer device, the printer driver validates the
		///         <see cref="DEVMODE" />. If the printer driver determines that the <see cref="DEVMODE" /> is invalid (that is, printer driver can’t convert or
		///         consume the DEVMODE), the printer driver provides a default <see cref="DEVMODE" /> to create the HDC for the printer device.
		///     </para>
		///     <para>
		///         ICM: To enable ICM, set the <see cref="DEVMODE.dmICMMethod" /> member of the <see cref="DEVMODE" /> structure (pointed to by the
		///         <paramref name="lpInitData" /> parameter) to the appropriate value.
		///     </para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "CreateDC")]
		public static extern IntPtr CreateDC([In] string lpszDriver, [In] string lpszDevice, [In] string lpszOutput, [In] IntPtr lpInitData);

		/// <summary>
		///     The <see cref="BeginPath" /> function opens a path bracket in the specified device context.
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         After a path bracket is open, an application can begin calling GDI drawing functions to define the points that lie in the path. An
		///         application can close an open path bracket by calling the <see cref="EndPath" /> function.
		///     </para>
		///     <para>
		///         When an application calls <see cref="BeginPath" /> for a device context, any previous paths are discarded from that device context. The
		///         following list shows which drawing functions can be used.
		///     </para>
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "BeginPath")]
		public static extern bool BeginPath([In] IntPtr hdc);

		/// <summary>
		///     The <see cref="AbortPath" /> function closes and discards any paths in the specified device context.
		/// </summary>
		/// <param name="hdc">Handle to the device context from which a path will be discarded.</param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     If there is an open path bracket in the given device context, the path bracket is closed and the path is discarded. If there is a closed path in
		///     the device context, the path is discarded.
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "AbortPath")]
		public static extern bool AbortPath([In] IntPtr hdc);

		/// <summary>
		///     The <see cref="TextOut" /> function writes a character string at the specified location, using the currently selected font, background color, and
		///     text color.
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <param name="nXStart">The x-coordinate, in logical coordinates, of the reference point that the system uses to align the string.</param>
		/// <param name="nYStart">The y-coordinate, in logical coordinates, of the reference point that the system uses to align the string.</param>
		/// <param name="lpString">
		///     A pointer to the string to be drawn. The string does not need to be zero-terminated, because <paramref name="cchString" /> specifies the length
		///     of the string.
		/// </param>
		/// <param name="cchString">
		///     The length of the string pointed to by <paramref name="lpString" />, in characters.
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         The interpretation of the reference point depends on the current text-alignment mode. An application can retrieve this mode by calling the
		///         <see cref="GetTextAlign" /> function; an application can alter this mode by calling the <see cref="SetTextAlign" /> function. You can use the
		///         following values for text alignment. Only one flag can be chosen from those that affect horizontal and vertical alignment. In addition, only
		///         one of the two flags that alter the current position can be chosen.
		///     </para>
		///     <para></para>
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "TextOut")]
		public static extern bool TextOut([In] IntPtr hdc, int nXStart, int nYStart, [In] string lpString, int cchString);

		/// <summary>
		///     The <see cref="SetPixel" /> function sets the pixel at the specified coordinates to the specified color.
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <param name="X">The x-coordinate, in logical units, of the point to be set.</param>
		/// <param name="Y">The y-coordinate, in logical units, of the point to be set.</param>
		/// <param name="crColor">
		///     The color to be used to paint the point. To create a <see cref="COLORREF" /> color value, use the RGB macro.
		/// </param>
		/// <returns>
		///     <para>
		///         If the function succeeds, the return value is the RGB value that the function sets the pixel to. This value may differ from the color
		///         specified by <paramref name="crColor" />; that occurs when an exact match for the specified color cannot be found.
		///     </para>
		///     <para>If the function fails, the return value is -1.</para>
		///     <para>This can be the following value.</para>
		/// </returns>
		/// <remarks>
		///     <para>The function fails if the pixel coordinates lie outside of the current clipping region.</para>
		///     <para>
		///         Not all devices support the <see cref="SetPixel" /> function. For more information, see <see cref="GetDeviceCaps" />.
		///     </para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "SetPixel")]
		public static extern uint SetPixel([In] IntPtr hdc, int X, int Y, uint crColor);

		/// <summary>
		///     The <see cref="ResetDC" /> function updates the specified printer or plotter device context (DC) using the specified information.
		/// </summary>
		/// <param name="hdc">A handle to the DC to update.</param>
		/// <param name="lpInitData">
		///     A pointer to a <see cref="DEVMODE" /> structure containing information about the new DC.
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is a handle to the original DC.</para>
		///     <para>If the function fails, the return value is NULL.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         An application will typically use the <see cref="ResetDC" /> function when a window receives a <see cref="WM.WM_DEVMODECHANGE" /> message.
		///         <see cref="ResetDC" /> can also be used to change the paper orientation or paper bins while printing a document.
		///     </para>
		///     <para>
		///         The <see cref="ResetDC" /> function cannot be used to change the driver name, device name, or the output port. When the user changes the port
		///         connection or device name, the application must delete the original DC and create a new DC with the new information.
		///     </para>
		///     <para>
		///         An application can pass an information DC to the <see cref="ResetDC" /> function. In that situation, <see cref="ResetDC" /> will always
		///         return a printer DC.
		///     </para>
		///     <para>
		///         ICM: The color profile of the DC specified by the <paramref name="hdc" /> parameter will be reset based on the information contained in the
		///         <see cref="lpInitData" /> member of the <see cref="DEVMODE" /> structure.
		///     </para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "ResetDC")]
		public static extern IntPtr ResetDC([In] IntPtr hdc, [In] ref DEVMODE lpInitData);

		/// <summary>
		///     The <see cref="Polyline" /> function draws a series of line segments by connecting the points in the specified array.
		/// </summary>
		/// <param name="hdc">A handle to a device context.</param>
		/// <param name="lppt">
		///     A pointer to an array of <see cref="POINT" /> structures, in logical units.
		/// </param>
		/// <param name="cPoints">The number of points in the array. This number must be greater than or equal to two.</param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     The lines are drawn from the first point through subsequent points by using the current pen. Unlike the <see cref="LineTo" /> or
		///     <see cref="PolylineTo" /> functions, the <see cref="Polyline" /> function neither uses nor updates the current position.
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "Polyline")]
		public static extern bool Polyline(
			[In] IntPtr hdc, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 2)] POINT[] lppt, int cPoints);

		/// <summary>
		///     The <see cref="PolyDraw" /> function draws a set of line segments and Bézier curves.
		/// </summary>
		/// <param name="hdc">A handle to a device context.</param>
		/// <param name="lppt">
		///     A pointer to an array of <see cref="POINT" /> structures that contains the endpoints for each line segment and the endpoints and control points
		///     for each Bézier curve, in logical units.
		/// </param>
		/// <param name="lpbTypes">
		///     <para>
		///         A pointer to an array that specifies how each point in the <paramref name="lppt" /> array is used. This parameter can be one of the following
		///         values.
		///     </para>
		///     <list type="table">
		///         <item>
		///             <term>PT_MOVETO</term>
		///             <description>Specifies that this point starts a disjoint figure. This point becomes the new current position.</description>
		///         </item>
		///         <item>
		///             <term>PT_LINETO</term>
		///             <description>Specifies that a line is to be drawn from the current position to this point, which then becomes the new current position.</description>
		///         </item>
		///         <item>
		///             <term>PT_BEZIERTO</term>
		///             <description>
		///                 <para>Specifies that this point is a control point or ending point for a Bézier curve.</para>
		///                 <para>
		///                     PT_BEZIERTO types always occur in sets of three. The current position defines the starting point for the Bézier curve. The first
		///                     two PT_BEZIERTO points are the control points, and the third PT_BEZIERTO point is the ending point. The ending point becomes the
		///                     new current position. If there are not three consecutive PT_BEZIERTO points, an error results.
		///                 </para>
		///             </description>
		///         </item>
		///     </list>
		///     <para>
		///         A PT_LINETO or PT_BEZIERTO type can be combined with the following value by using the bitwise operator OR to indicate that the corresponding
		///         point is the last point in a figure and the figure is closed.
		///     </para>
		///     <list type="table">
		///         <item>
		///             <term>PT_CLOSEFIGURE</term>
		///             <description>
		///                 <para>
		///                     Specifies that the figure is automatically closed after the PT_LINETO or PT_BEZIERTO type for this point is done. A line is drawn
		///                     from this point to the most recent PT_MOVETO or <see cref="MoveToEx" /> point.
		///                 </para>
		///                 <para>
		///                     This value is combined with the PT_LINETO type for a line, or with the PT_BEZIERTO type of the ending point for a Bézier curve,
		///                     by using the bitwise operator OR.
		///                 </para>
		///                 <para>The current position is set to the ending point of the closing line.</para>
		///             </description>
		///         </item>
		///     </list>
		/// </param>
		/// <param name="cCount">
		///     The total number of points in the <paramref name="lppt" /> array, the same as the number of bytes in the <paramref name="lpbTypes" /> array.
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         The <see cref="PolyDraw" /> function can be used in place of consecutive calls to <see cref="MoveToEx" />, <see cref="LineTo" />, and
		///         <see cref="PolyBezierTo" /> functions to draw disjoint figures. The lines and curves are drawn using the current pen and figures are not
		///         filled. If there is an active path started by calling <see cref="BeginPath" />, <see cref="PolyDraw" /> adds to the path.
		///     </para>
		///     <para>
		///         The points contained in the <paramref name="lppt" /> array and in the <paramref name="lpbTypes" /> array indicate whether each point is part
		///         of a <see cref="MoveToEx" />, <see cref="LineTo" />, or <see cref="PolyBezierTo" /> operation. It is also possible to close figures.
		///     </para>
		///     <para>This function updates the current position.</para>
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "PolyDraw")]
		public static extern bool PolyDraw(
			[In] IntPtr hdc, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 3)] POINT[] lppt,
			[MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I1, SizeParamIndex = 3)] byte[] lpbTypes, int cCount);

		/// <summary>
		///     The <see cref="PaintRgn" /> function paints the specified region by using the brush currently selected into the device context.
		/// </summary>
		/// <param name="hdc">Handle to the device context.</param>
		/// <param name="hrgn">Handle to the region to be filled. The region's coordinates are presumed to be logical coordinates.</param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "PaintRgn")]
		public static extern bool PaintRgn([In] IntPtr hdc, [In] IntPtr hrgn);

		/// <summary>
		///     The <see cref="MoveToEx" /> function updates the current position to the specified point and optionally returns the previous position.
		/// </summary>
		/// <param name="hdc">Handle to a device context.</param>
		/// <param name="X">Specifies the x-coordinate, in logical units, of the new position, in logical units.</param>
		/// <param name="Y">Specifies the y-coordinate, in logical units, of the new position, in logical units.</param>
		/// <param name="lpPoint">
		///     Pointer to a <see cref="POINT" /> structure that receives the previous current position. If this parameter is a NULL pointer, the previous
		///     position is not returned.
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     The <see cref="MoveToEx" /> function affects all drawing functions.
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "MoveToEx")]
		public static extern bool MoveToEx([In] IntPtr hdc, int X, int Y, IntPtr lpPoint);

		/// <summary>
		///     The <see cref="GetPixel" /> function retrieves the red, green, blue (RGB) color value of the pixel at the specified coordinates.
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <param name="nXPos">The x-coordinate, in logical units, of the pixel to be examined.</param>
		/// <param name="nYPos">The y-coordinate, in logical units, of the pixel to be examined.</param>
		/// <returns>
		///     The return value is the <see cref="COLORREF" /> value that specifies the RGB of the pixel. If the pixel is outside of the current clipping
		///     region, the return value is CLR_INVALID (0xFFFFFFFF defined in Wingdi.h).
		/// </returns>
		/// <remarks>
		///     <para>The pixel must be within the boundaries of the current clipping region.</para>
		///     <para>
		///         Not all devices support <see cref="GetPixel" />. An application should call <see cref="GetDeviceCaps" /> to determine whether a specified
		///         device supports this function.
		///     </para>
		///     <para>A bitmap must be selected within the device context, otherwise, CLR_INVALID is returned on all pixels.</para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "GetPixel")]
		public static extern uint GetPixel([In] IntPtr hdc, int nXPos, int nYPos);

		/// <summary>
		///     The <see cref="GdiFlush" /> function flushes the calling thread's current batch.
		/// </summary>
		/// <returns>
		///     <para>If all functions in the current batch succeed, the return value is nonzero.</para>
		///     <para>If not all functions in the current batch succeed, the return value is zero, indicating that at least one function returned an error.</para>
		/// </returns>
		/// <remarks>
		///     Batching enhances drawing performance by minimizing the amount of time needed to call GDI drawing functions that return Boolean values. The
		///     system accumulates the parameters for calls to these functions in the current batch and then calls the functions when the batch is flushed by any
		///     of the following means:
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "GdiFlush")]
		public static extern bool GdiFlush();

		/// <summary>
		///     The <see cref="FrameRgn" /> function draws a border around the specified region by using the specified brush.
		/// </summary>
		/// <param name="hdc">Handle to the device context.</param>
		/// <param name="hrgn">Handle to the region to be enclosed in a border. The region's coordinates are presumed to be in logical units.</param>
		/// <param name="hbr">Handle to the brush to be used to draw the border.</param>
		/// <param name="nWidth">Specifies the width, in logical units, of vertical brush strokes.</param>
		/// <param name="nHeight">Specifies the height, in logical units, of horizontal brush strokes.</param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "FrameRgn")]
		public static extern bool FrameRgn([In] IntPtr hdc, [In] IntPtr hrgn, [In] IntPtr hbr, int nWidth, int nHeight);

		/// <summary>
		///     The <see cref="FillPath" /> function closes any open figures in the current path and fills the path's interior by using the current brush and
		///     polygon-filling mode.
		/// </summary>
		/// <param name="hdc">A handle to a device context that contains a valid path.</param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     After its interior is filled, the path is discarded from the DC identified by the <paramref name="hdc" /> parameter.
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "FillPath")]
		public static extern bool FillPath([In] IntPtr hdc);

		/// <summary>
		///     The <see cref="EqualRgn" /> function checks the two specified regions to determine whether they are identical. The function considers two regions
		///     identical if they are equal in size and shape.
		/// </summary>
		/// <param name="hSrcRgn1">Handle to a region.</param>
		/// <param name="hSrcRgn2">Handle to a region.</param>
		/// <returns>
		///     <para>If the two regions are equal, the return value is nonzero.</para>
		///     <para>If the two regions are not equal, the return value is zero. A return value of ERROR means at least one of the region handles is invalid.</para>
		/// </returns>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "EqualRgn")]
		public static extern bool EqualRgn([In] IntPtr hSrcRgn1, [In] IntPtr hSrcRgn2);

		/// <summary>
		///     The <see cref="DeleteDC" /> function deletes the specified device context (DC).
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     An application must not delete a DC whose handle was obtained by calling the <see cref="User32.GetDC" /> function. Instead, it must call the
		///     <see cref="User32.ReleaseDC" /> function to free the DC.
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "DeleteDC")]
		public static extern bool DeleteDC([In] IntPtr hdc);

		/// <summary>
		///     The <see cref="CancelDC" /> function cancels any pending operation on the specified device context (DC).
		/// </summary>
		/// <param name="hdc">A handle to the DC.</param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         The <see cref="CancelDC" /> function is used by multithreaded applications to cancel lengthy drawing operations. If thread A initiates a
		///         lengthy drawing operation, thread B may cancel that operation by calling this function.
		///     </para>
		///     <para>
		///         If an operation is canceled, the affected thread returns an error and the result of its drawing operation is undefined. The results are also
		///         undefined if no drawing operation was in progress when the function was called.
		///     </para>
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "CancelDC")]
		public static extern bool CancelDC([In] IntPtr hdc);

		/// <summary>
		///     The <see cref="AngleArc" /> function draws a line segment and an arc. The line segment is drawn from the current position to the beginning of the
		///     arc. The arc is drawn along the perimeter of a circle with the given radius and center. The length of the arc is defined by the given start and
		///     sweep angles.
		/// </summary>
		/// <param name="hdc">Handle to a device context.</param>
		/// <param name="X">Specifies the x-coordinate, in logical units, of the center of the circle.</param>
		/// <param name="Y">Specifies the y-coordinate, in logical units, of the center of the circle.</param>
		/// <param name="dwRadius">Specifies the radius, in logical units, of the circle. This value must be positive.</param>
		/// <param name="eStartAngle">Specifies the start angle, in degrees, relative to the x-axis.</param>
		/// <param name="eSweepAngle">Specifies the sweep angle, in degrees, relative to the starting angle.</param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         The <see cref="AngleArc" /> function moves the current position to the ending point of the arc.
		///     </para>
		///     <para>
		///         The arc drawn by this function may appear to be elliptical, depending on the current transformation and mapping mode. Before drawing the arc,
		///         <see cref="AngleArc" /> draws the line segment from the current position to the beginning of the arc.
		///     </para>
		///     <para>
		///         The arc is drawn by constructing an imaginary circle around the specified center point with the specified radius. The starting point of the
		///         arc is determined by measuring counterclockwise from the x-axis of the circle by the number of degrees in the start angle. The ending point
		///         is similarly located by measuring counterclockwise from the starting point by the number of degrees in the sweep angle.
		///     </para>
		///     <para>If the sweep angle is greater than 360 degrees, the arc is swept multiple times.</para>
		///     <para>This function draws lines by using the current pen. The figure is not filled.</para>
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "AngleArc")]
		public static extern bool AngleArc([In] IntPtr hdc, int X, int Y, uint dwRadius, float eStartAngle, float eSweepAngle);

		/// <summary>
		///     The <see cref="AbortDoc" /> function stops the current print job and erases everything drawn since the last call to the <see cref="StartDoc" />
		///     function.
		/// </summary>
		/// <param name="hdc">Handle to the device context for the print job.</param>
		/// <returns>
		///     <para>If the function succeeds, the return value is greater than zero.</para>
		///     <para>If the function fails, the return value is SP_ERROR.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         Note:  This is a blocking or synchronous function and might not return immediately. How quickly this function returns depends on run-time
		///         factors such as network status, print server configuration, and printer driver implementation—factors that are difficult to predict when
		///         writing an application. Calling this function from a thread that manages interaction with the user interface could make the application
		///         appear to be unresponsive.
		///     </para>
		///     <para>
		///         Applications should call the <see cref="AbortDoc" /> function to stop a print job if an error occurs, or to stop a print job after the user
		///         cancels that job. To end a successful print job, an application should call the <see cref="EndDoc" /> function.
		///     </para>
		///     <para>
		///         If Print Manager was used to start the print job, calling <see cref="AbortDoc" /> erases the entire spool job, so that the printer receives
		///         nothing. If Print Manager was not used to start the print job, the data may already have been sent to the printer. In this case, the printer
		///         driver resets the printer (when possible) and ends the print job.
		///     </para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "AbortDoc")]
		public static extern int AbortDoc([In] IntPtr hdc);

		/// <summary>
		///     The <see cref="SetROP2" /> function sets the current foreground mix mode. GDI uses the foreground mix mode to combine pens and interiors of
		///     filled objects with the colors already on the screen. The foreground mix mode defines how colors from the brush or pen and the colors in the
		///     existing image are to be combined.
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <param name="fnDrawMode">
		///     <para>The mix mode. This parameter can be one of the following values.</para>
		///     <list type="table">
		///         <item>
		///             <term>R2_BLACK</term>
		///             <description>Pixel is always 0.</description>
		///         </item>
		///         <item>
		///             <term>R2_COPYPEN</term>
		///             <description>Pixel is the pen color.</description>
		///         </item>
		///         <item>
		///             <term>R2_MASKNOTPEN</term>
		///             <description>Pixel is a combination of the colors common to both the screen and the inverse of the pen.</description>
		///         </item>
		///         <item>
		///             <term>R2_MASKPEN</term>
		///             <description>Pixel is a combination of the colors common to both the pen and the screen.</description>
		///         </item>
		///         <item>
		///             <term>R2_MASKPENNOT</term>
		///             <description>Pixel is a combination of the colors common to both the pen and the inverse of the screen.</description>
		///         </item>
		///         <item>
		///             <term>R2_MERGENOTPEN</term>
		///             <description>Pixel is a combination of the screen color and the inverse of the pen color.</description>
		///         </item>
		///         <item>
		///             <term>R2_MERGEPEN</term>
		///             <description>Pixel is a combination of the pen color and the screen color.</description>
		///         </item>
		///         <item>
		///             <term>R2_MERGEPENNOT</term>
		///             <description>Pixel is a combination of the pen color and the inverse of the screen color.</description>
		///         </item>
		///         <item>
		///             <term>R2_NOP</term>
		///             <description>Pixel remains unchanged.</description>
		///         </item>
		///         <item>
		///             <term>R2_NOT</term>
		///             <description>Pixel is the inverse of the screen color.</description>
		///         </item>
		///         <item>
		///             <term>R2_NOTCOPYPEN</term>
		///             <description>Pixel is the inverse of the pen color.</description>
		///         </item>
		///         <item>
		///             <term>R2_NOTMASKPEN</term>
		///             <description>Pixel is the inverse of the R2_MASKPEN color.</description>
		///         </item>
		///         <item>
		///             <term>R2_NOTMERGEPEN</term>
		///             <description>Pixel is the inverse of the R2_MERGEPEN color.</description>
		///         </item>
		///         <item>
		///             <term>R2_NOTXORPEN</term>
		///             <description>Pixel is the inverse of the R2_XORPEN color.</description>
		///         </item>
		///         <item>
		///             <term>R2_WHITE</term>
		///             <description>Pixel is always 1.</description>
		///         </item>
		///         <item>
		///             <term>R2_XORPEN</term>
		///             <description>Pixel is a combination of the colors in the pen and in the screen, but not in both.</description>
		///         </item>
		///     </list>
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value specifies the previous mix mode.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     Mix modes define how GDI combines source and destination colors when drawing with the current pen. The mix modes are binary raster operation
		///     codes, representing all possible Boolean functions of two variables, using the binary operations AND, OR, and XOR (exclusive OR), and the unary
		///     operation NOT. The mix mode is for raster devices only; it is not available for vector devices.
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "SetROP2")]
		public static extern int SetROP2([In] IntPtr hdc, int fnDrawMode);

		/// <summary>
		///     The <see cref="Polygon" /> function draws a polygon consisting of two or more vertices connected by straight lines. The polygon is outlined by
		///     using the current pen and filled by using the current brush and polygon fill mode.
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <param name="lpPoints">
		///     A pointer to an array of <see cref="POINT" /> structures that specify the vertices of the polygon, in logical coordinates.
		/// </param>
		/// <param name="nCount">The number of vertices in the array. This value must be greater than or equal to 2.</param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     <para>The polygon is closed automatically by drawing a line from the last vertex to the first.</para>
		///     <para>
		///         The current position is neither used nor updated by the <see cref="Polygon" /> function.
		///     </para>
		///     <para>
		///         Any extra points are ignored. To draw a line with more points, divide your data into groups, each of which have less than the maximum number
		///         of points, and call the function for each group of points. Remember to connect the line segments.
		///     </para>
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "Polygon")]
		public static extern bool Polygon(
			[In] IntPtr hdc, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 2)] POINT[] lpPoints, int nCount);

		/// <summary>
		///     The <see cref="MaskBlt" /> function combines the color data for the source and destination bitmaps using the specified mask and raster operation.
		/// </summary>
		/// <param name="hdcDest">A handle to the destination device context.</param>
		/// <param name="nXDest">The x-coordinate, in logical units, of the upper-left corner of the destination rectangle.</param>
		/// <param name="nYDest">The y-coordinate, in logical units, of the upper-left corner of the destination rectangle.</param>
		/// <param name="nWidth">The width, in logical units, of the destination rectangle and source bitmap.</param>
		/// <param name="nHeight">The height, in logical units, of the destination rectangle and source bitmap.</param>
		/// <param name="hdcSrc">
		///     A handle to the device context from which the bitmap is to be copied. It must be zero if the <paramref name="dwRop" /> parameter specifies a
		///     raster operation that does not include a source.
		/// </param>
		/// <param name="nXSrc">The x-coordinate, in logical units, of the upper-left corner of the source bitmap.</param>
		/// <param name="nYSrc">The y-coordinate, in logical units, of the upper-left corner of the source bitmap.</param>
		/// <param name="hbmMask">A handle to the monochrome mask bitmap combined with the color bitmap in the source device context.</param>
		/// <param name="xMask">
		///     The horizontal pixel offset for the mask bitmap specified by the <paramref name="hbmMask" /> parameter.
		/// </param>
		/// <param name="yMask">
		///     The vertical pixel offset for the mask bitmap specified by the <paramref name="hbmMask" /> parameter.
		/// </param>
		/// <param name="dwRop">
		///     <para>
		///         The foreground and background ternary raster operation codes (ROPs) that the function uses to control the combination of source and
		///         destination data. The background raster operation code is stored in the high-order byte of the high-order word of this value; the foreground
		///         raster operation code is stored in the low-order byte of the high-order word of this value; the low-order word of this value is ignored, and
		///         should be zero. The macro MAKEROP4 creates such combinations of foreground and background raster operation codes.
		///     </para>
		///     <para>For a discussion of foreground and background in the context of this function, see the following Remarks section.</para>
		///     <para>
		///         For a list of common raster operation codes (ROPs), see the <see cref="BitBlt" /> function. Note that the CAPTUREBLT ROP generally cannot be
		///         used for printing device contexts.
		///     </para>
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         The <see cref="MaskBlt" /> function uses device-dependent bitmaps.
		///     </para>
		///     <para>
		///         A value of 1 in the mask specified by <paramref name="hbmMask" /> indicates that the foreground raster operation code specified by
		///         <paramref name="dwRop" /> should be applied at that location. A value of 0 in the mask indicates that the background raster operation code
		///         specified by <paramref name="dwRop" /> should be applied at that location.
		///     </para>
		///     <para>
		///         If the raster operations require a source, the mask rectangle must cover the source rectangle. If it does not, the function will fail. If the
		///         raster operations do not require a source, the mask rectangle must cover the destination rectangle. If it does not, the function will fail.
		///     </para>
		///     <para>
		///         If a rotation or shear transformation is in effect for the source device context when this function is called, an error occurs. However,
		///         other types of transformation are allowed.
		///     </para>
		///     <para>
		///         If the color formats of the source, pattern, and destination bitmaps differ, this function converts the pattern or source format, or both, to
		///         match the destination format.
		///     </para>
		///     <para>If the mask bitmap is not a monochrome bitmap, an error occurs.</para>
		///     <para>
		///         When an enhanced metafile is being recorded, an error occurs (and the function returns FALSE) if the source device context identifies an
		///         enhanced-metafile device context.
		///     </para>
		///     <para>
		///         Not all devices support the <see cref="MaskBlt" /> function. An application should call the <see cref="GetDeviceCaps" /> function with the
		///         nIndex parameter as RC_BITBLT to determine whether a device supports this function.
		///     </para>
		///     <para>
		///         If no mask bitmap is supplied, this function behaves exactly like <see cref="BitBlt" />, using the foreground raster operation code.
		///     </para>
		///     <para>ICM: No color management is performed when blits occur.</para>
		///     <para>
		///         When used in a multiple monitor system, both <paramref name="hdcSrc" /> and <paramref name="hdcDest" /> must refer to the same device or the
		///         function will fail. To transfer data between DCs for different devices, convert the memory bitmap (compatible bitmap, or DDB) to a DIB by
		///         calling <see cref="GetDIBits" />. To display the DIB to the second device, call <see cref="SetDIBits" /> or <see cref="StretchDIBits" />.
		///     </para>
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "MaskBlt")]
		public static extern bool MaskBlt(
			[In] IntPtr hdcDest, int nXDest, int nYDest, int nWidth, int nHeight, [In] IntPtr hdcSrc, int nXSrc, int nYSrc, [In] IntPtr hbmMask, int xMask, int yMask,
			uint dwRop);

		/// <summary>
		///     The <see cref="LineDDA" /> function determines which pixels should be highlighted for a line defined by the specified starting and ending points.
		/// </summary>
		/// <param name="nXStart">Specifies the x-coordinate, in logical units, of the line's starting point.</param>
		/// <param name="nYStart">Specifies the y-coordinate, in logical units, of the line's starting point.</param>
		/// <param name="nXEnd">Specifies the x-coordinate, in logical units, of the line's ending point.</param>
		/// <param name="nYEnd">Specifies the y-coordinate, in logical units, of the line's ending point.</param>
		/// <param name="lpLineFunc">
		///     Pointer to an application-defined callback function. For more information, see the <see cref="LineDDAProc" /> callback function.
		/// </param>
		/// <param name="lpData">Pointer to the application-defined data.</param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         The <see cref="LineDDA" /> function passes the coordinates for each point along the line, except for the line's ending point, to the
		///         application-defined callback function. In addition to passing the coordinates of a point, this function passes any existing
		///         application-defined data.
		///     </para>
		///     <para>
		///         The coordinates passed to the callback function match pixels on a video display only if the default transformations and mapping modes are
		///         used.
		///     </para>
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "LineDDA")]
		public static extern bool LineDDA(int nXStart, int nYStart, int nXEnd, int nYEnd, LineDDAProc lpLineFunc, [MarshalAs(UnmanagedType.SysInt)] int lpData);

		/// <summary>
		///     The <see cref="GetROP2" /> function retrieves the foreground mix mode of the specified device context. The mix mode specifies how the pen or
		///     interior color and the color already on the screen are combined to yield a new color.
		/// </summary>
		/// <param name="hdc">Handle to the device context.</param>
		/// <returns>
		///     <para>If the function succeeds, the return value specifies the foreground mix mode.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>Following are the foreground mix modes.</remarks>
		[DllImport("gdi32.dll", EntryPoint = "GetROP2")]
		public static extern int GetROP2([In] IntPtr hdc);

		/// <summary>
		///     The <see cref="GetPath" /> function retrieves the coordinates defining the endpoints of lines and the control points of curves found in the path
		///     that is selected into the specified device context.
		/// </summary>
		/// <param name="hdc">A handle to a device context that contains a closed path.</param>
		/// <param name="lpPoints">
		///     A pointer to an array of <see cref="POINT" /> structures that receives the line endpoints and curve control points, in logical coordinates.
		/// </param>
		/// <param name="lpTypes">
		///     <para>A pointer to an array of bytes that receives the vertex types. This parameter can be one of the following values.</para>
		///     <list type="table">
		///         <item>
		///             <term>PT_MOVETO</term>
		///             <description>
		///                 Specifies that the corresponding point in the <paramref name="lpPoints" /> parameter starts a disjoint figure.
		///             </description>
		///         </item>
		///         <item>
		///             <term>PT_LINETO</term>
		///             <description>
		///                 Specifies that the previous point and the corresponding point in <paramref name="lpPoints" /> are the endpoints of a line.
		///             </description>
		///         </item>
		///         <item>
		///             <term>PT_BEZIERTO</term>
		///             <description>
		///                 <para>
		///                     Specifies that the corresponding point in <paramref name="lpPoints" /> is a control point or ending point for a Bézier curve.
		///                 </para>
		///                 <para>
		///                     PT_BEZIERTO values always occur in sets of three. The point in the path immediately preceding them defines the starting point for
		///                     the Bézier curve. The first two PT_BEZIERTO points are the control points, and the third PT_BEZIERTO point is the ending (if
		///                     hard-coded) point.
		///                 </para>
		///             </description>
		///         </item>
		///     </list>
		///     <para>
		///         A PT_LINETO or PT_BEZIERTO value may be combined with the following value (by using the bitwise operator OR) to indicate that the
		///         corresponding point is the last point in a figure and the figure should be closed.
		///     </para>
		///     <list type="table">
		///         <item>
		///             <term>PT_CLOSEFIGURE</term>
		///             <description>
		///                 Specifies that the figure is automatically closed after the corresponding line or curve is drawn. The figure is closed by drawing a
		///                 line from the line or curve endpoint to the point corresponding to the last PT_MOVETO.
		///             </description>
		///         </item>
		///     </list>
		/// </param>
		/// <param name="nSize">
		///     The total number of <see cref="POINT" /> structures that can be stored in the array pointed to by <paramref name="lpPoints" />. This value must
		///     be the same as the number of bytes that can be placed in the array pointed to by <paramref name="lpTypes" />.
		/// </param>
		/// <returns>
		///     If the <paramref name="nSize" /> parameter is nonzero, the return value is the number of points enumerated. If <paramref name="nSize" /> is 0,
		///     the return value is the total number of points in the path (and <see cref="GetPath" /> writes nothing to the buffers). If
		///     <paramref name="nSize" /> is nonzero and is less than the number of points in the path, the return value is 1.
		/// </returns>
		/// <remarks>
		///     <para>
		///         The device context identified by the <paramref name="hdc" /> parameter must contain a closed path.
		///     </para>
		///     <para>
		///         The points of the path are returned in logical coordinates. Points are stored in the path in device coordinates, so <see cref="GetPath" />
		///         changes the points from device coordinates to logical coordinates by using the inverse of the current transformation.
		///     </para>
		///     <para>
		///         The <see cref="FlattenPath" /> function may be called before <see cref="GetPath" /> to convert all curves in the path into line segments.
		///     </para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "GetPath")]
		public static extern int GetPath([In] IntPtr hdc, ref POINT[] lpPoints, ref byte[] lpTypes, int nSize);

		/// <summary>
		///     The <see cref="FillRgn" /> function fills a region by using the specified brush.
		/// </summary>
		/// <param name="hdc">Handle to the device context.</param>
		/// <param name="hrgn">Handle to the region to be filled. The region's coordinates are presumed to be in logical units.</param>
		/// <param name="hbr">Handle to the brush to be used to fill the region.</param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "FillRgn")]
		public static extern bool FillRgn([In] IntPtr hdc, [In] IntPtr hrgn, [In] IntPtr hbr);

		/// <summary>
		///     The <see cref="EndPath" /> function closes a path bracket and selects the path defined by the bracket into the specified device context.
		/// </summary>
		/// <param name="hdc">A handle to the device context into which the new path is selected.</param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "EndPath")]
		public static extern bool EndPath([In] IntPtr hdc);

		/// <summary>
		///     The <see cref="EndPage" /> function notifies the device that the application has finished writing to a page. This function is typically used to
		///     direct the device driver to advance to a new page.
		/// </summary>
		/// <param name="hdc">A handle to the device context for the print job.</param>
		/// <returns>
		///     <para>If the function succeeds, the return value is greater than zero.</para>
		///     <para>If the function fails, the return value is less than or equal to zero.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         Note:  This is a blocking or synchronous function and might not return immediately. How quickly this function returns depends on run-time
		///         factors such as network status, print server configuration, and printer driver implementation—factors that are difficult to predict when
		///         writing an application. Calling this function from a thread that manages interaction with the user interface could make the application
		///         appear to be unresponsive.
		///     </para>
		///     <para>
		///         Use the <see cref="ResetDC" /> function to change the device mode, if necessary, after calling the <see cref="EndPage" /> function. Note that
		///         a call to <see cref="ResetDC" /> resets all device context attributes back to default values. Neither <see cref="EndPage" /> nor
		///         <see cref="StartPage" /> resets the device context attributes. Device context attributes remain constant across subsequent pages. You do not
		///         need to re-select objects and set up the mapping mode again before printing the next page; however, doing so will produce the same results
		///         and reduce code differences between versions of Windows.
		///     </para>
		///     <para>
		///         When a page in a spooled file exceeds approximately 350 MB, it may fail to print and not send an error message. For example, this can occur
		///         when printing large EMF files. The page size limit depends on many factors including the amount of virtual memory available, the amount of
		///         memory allocated by calling processes, and the amount of fragmentation in the process heap.
		///     </para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "EndPage")]
		public static extern int EndPage([In] IntPtr hdc);

		/// <summary>
		///     The <see cref="Ellipse" /> function draws an ellipse. The center of the ellipse is the center of the specified bounding rectangle. The ellipse is
		///     outlined by using the current pen and is filled by using the current brush.
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <param name="nLeftRect">The x-coordinate, in logical coordinates, of the upper-left corner of the bounding rectangle.</param>
		/// <param name="nTopRect">The y-coordinate, in logical coordinates, of the upper-left corner of the bounding rectangle.</param>
		/// <param name="nRightRect">The x-coordinate, in logical coordinates, of the lower-right corner of the bounding rectangle.</param>
		/// <param name="nBottomRect">The y-coordinate, in logical coordinates, of the lower-right corner of the bounding rectangle.</param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     The current position is neither used nor updated by <see cref="Ellipse" />.
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "Ellipse")]
		public static extern bool Ellipse([In] IntPtr hdc, int nLeftRect, int nTopRect, int nRightRect, int nBottomRect);

		/// <summary>
		///     The <see cref="SaveDC" /> function saves the current state of the specified device context (DC) by copying data describing selected objects and
		///     graphic modes (such as the bitmap, brush, palette, font, pen, region, drawing mode, and mapping mode) to a context stack.
		/// </summary>
		/// <param name="hdc">A handle to the DC whose state is to be saved.</param>
		/// <returns>
		///     <para>If the function succeeds, the return value identifies the saved state.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         The <see cref="SaveDC" /> function can be used any number of times to save any number of instances of the DC state.
		///     </para>
		///     <para>
		///         A saved state can be restored by using the <see cref="RestoreDC" /> function.
		///     </para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "SaveDC")]
		public static extern int SaveDC([In] IntPtr hdc);

		/// <summary>
		///     The <see cref="PlgBlt" /> function performs a bit-block transfer of the bits of color data from the specified rectangle in the source device
		///     context to the specified parallelogram in the destination device context. If the given bitmask handle identifies a valid monochrome bitmap, the
		///     function uses this bitmap to mask the bits of color data from the source rectangle.
		/// </summary>
		/// <param name="hdcDest">A handle to the destination device context.</param>
		/// <param name="lpPoint">
		///     A pointer to an array of three points in logical space that identify three corners of the destination parallelogram. The upper-left corner of the
		///     source rectangle is mapped to the first point in this array, the upper-right corner to the second point in this array, and the lower-left corner
		///     to the third point. The lower-right corner of the source rectangle is mapped to the implicit fourth point in the parallelogram.
		/// </param>
		/// <param name="hdcSrc">A handle to the source device context.</param>
		/// <param name="nXSrc">The x-coordinate, in logical units, of the upper-left corner of the source rectangle.</param>
		/// <param name="nYSrc">The y-coordinate, in logical units, of the upper-left corner of the source rectangle.</param>
		/// <param name="nWidth">The width, in logical units, of the source rectangle.</param>
		/// <param name="nHeight">The height, in logical units, of the source rectangle.</param>
		/// <param name="hbmMask">A handle to an optional monochrome bitmap that is used to mask the colors of the source rectangle.</param>
		/// <param name="xMask">The x-coordinate, in logical units, of the upper-left corner of the monochrome bitmap.</param>
		/// <param name="yMask">The y-coordinate, in logical units, of the upper-left corner of the monochrome bitmap.</param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         The <see cref="PlgBlt" /> function works with device-dependent bitmaps.
		///     </para>
		///     <para>The fourth vertex of the parallelogram (D) is defined by treating the first three points (A, B, and C ) as vectors and computing D = B +CA.</para>
		///     <para>
		///         If the bitmask exists, a value of one in the mask indicates that the source pixel color should be copied to the destination. A value of zero
		///         in the mask indicates that the destination pixel color is not to be changed. If the mask rectangle is smaller than the source and destination
		///         rectangles, the function replicates the mask pattern.
		///     </para>
		///     <para>
		///         Scaling, translation, and reflection transformations are allowed in the source device context; however, rotation and shear transformations
		///         are not. If the mask bitmap is not a monochrome bitmap, an error occurs. The stretching mode for the destination device context is used to
		///         determine how to stretch or compress the pixels, if that is necessary.
		///     </para>
		///     <para>When an enhanced metafile is being recorded, an error occurs if the source device context identifies an enhanced-metafile device context.</para>
		///     <para>
		///         The destination coordinates are transformed according to the destination device context; the source coordinates are transformed according to
		///         the source device context. If the source transformation has a rotation or shear, an error is returned.
		///     </para>
		///     <para>
		///         If the destination and source rectangles do not have the same color format, <see cref="PlgBlt" /> converts the source rectangle to match the
		///         destination rectangle.
		///     </para>
		///     <para>
		///         Not all devices support the <see cref="PlgBlt" /> function. For more information, see the description of the RC_BITBLT raster capability in
		///         the <see cref="GetDeviceCaps" /> function.
		///     </para>
		///     <para>
		///         If the source and destination device contexts represent incompatible devices, <see cref="PlgBlt" /> returns an error.
		///     </para>
		///     <para>
		///         When used in a multiple monitor system, both <paramref name="hdcSrc" /> and <paramref name="hdcDest" /> must refer to the same device or the
		///         function will fail. To transfer data between DCs for different devices, convert the memory bitmap to a DIB by calling
		///         <see cref="GetDIBits" />. To display the DIB to the second device, call <see cref="SetDIBits" /> or <see cref="StretchDIBits" />.
		///     </para>
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "PlgBlt")]
		public static extern bool PlgBlt(
			[In] IntPtr hdcDest, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeConst = 3)] POINT[] lpPoint, [In] IntPtr hdcSrc, int nXSrc,
			int nYSrc, int nWidth, int nHeight, [In] IntPtr hbmMask, int xMask, int yMask);

		/// <summary>
		///     The <see cref="PatBlt" /> function paints the specified rectangle using the brush that is currently selected into the specified device context.
		///     The brush color and the surface color or colors are combined by using the specified raster operation.
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <param name="nXLeft">The x-coordinate, in logical units, of the upper-left corner of the rectangle to be filled.</param>
		/// <param name="nYLeft">The y-coordinate, in logical units, of the upper-left corner of the rectangle to be filled.</param>
		/// <param name="nWidth">The width, in logical units, of the rectangle.</param>
		/// <param name="nHeight">The height, in logical units, of the rectangle.</param>
		/// <param name="dwRop">
		///     <para>The raster operation code. This code can be one of the following values.</para>
		///     <list type="table">
		///         <item>
		///             <term>PATCOPY</term>
		///             <description>Copies the specified pattern into the destination bitmap.</description>
		///         </item>
		///         <item>
		///             <term>PATINVERT</term>
		///             <description>Combines the colors of the specified pattern with the colors of the destination rectangle by using the Boolean XOR operator.</description>
		///         </item>
		///         <item>
		///             <term>DSTINVERT</term>
		///             <description>Inverts the destination rectangle.</description>
		///         </item>
		///         <item>
		///             <term>BLACKNESS</term>
		///             <description>
		///                 Fills the destination rectangle using the color associated with index 0 in the physical palette. (This color is black for the default
		///                 physical palette.)
		///             </description>
		///         </item>
		///         <item>
		///             <term>WHITENESS</term>
		///             <description>
		///                 Fills the destination rectangle using the color associated with index 1 in the physical palette. (This color is white for the default
		///                 physical palette.)
		///             </description>
		///         </item>
		///     </list>
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         The values of the <paramref name="dwRop" /> parameter for this function are a limited subset of the full 256 ternary raster-operation codes;
		///         in particular, an operation code that refers to a source rectangle cannot be used.
		///     </para>
		///     <para>
		///         Not all devices support the <see cref="PatBlt" /> function. For more information, see the description of the RC_BITBLT capability in the
		///         <see cref="GetDeviceCaps" /> function.
		///     </para>
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "PatBlt")]
		public static extern bool PatBlt([In] IntPtr hdc, int nXLeft, int nYLeft, int nWidth, int nHeight, uint dwRop);

		/// <summary>
		///     The <see cref="LPtoDP" /> function converts logical coordinates into device coordinates. The conversion depends on the mapping mode of the device
		///     context, the settings of the origins and extents for the window and viewport, and the world transformation.
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <param name="lpPoints">
		///     A pointer to an array of <see cref="POINT" /> structures. The x-coordinates and y-coordinates contained in each of the <see cref="POINT" />
		///     structures will be transformed.
		/// </param>
		/// <param name="nCount">The number of points in the array.</param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         The <see cref="LPtoDP" /> function fails if the logical coordinates exceed 32 bits, or if the converted device coordinates exceed 27 bits. In
		///         the case of such an overflow, the results for all the points are undefined.
		///     </para>
		///     <para>
		///         <see cref="LPtoDP" /> calculates complex floating-point arithmetic, and it has a caching system for efficiency. Therefore, the conversion
		///         result of an initial call to <see cref="LPtoDP" /> might not exactly match the conversion result of a later call to <see cref="LPtoDP" />. We
		///         recommend not to write code that relies on the exact match of the conversion results from multiple calls to <see cref="LPtoDP" /> even if the
		///         parameters that are passed to each call are identical.
		///     </para>
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "LPtoDP")]
		public static extern bool LPtoDP([In] IntPtr hdc, ref POINT[] lpPoints, int nCount);

		/// <summary>
		///     The <see cref="LineTo" /> function draws a line from the current position up to, but not including, the specified point.
		/// </summary>
		/// <param name="hdc">Handle to a device context.</param>
		/// <param name="nXEnd">Specifies the x-coordinate, in logical units, of the line's ending point.</param>
		/// <param name="nYEnd">Specifies the y-coordinate, in logical units, of the line's ending point.</param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     <para>The line is drawn by using the current pen and, if the pen is a geometric pen, the current brush.</para>
		///     <para>
		///         If <see cref="LineTo" /> succeeds, the current position is set to the specified ending point.
		///     </para>
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "LineTo")]
		public static extern bool LineTo([In] IntPtr hdc, int nXEnd, int nYEnd);

		/// <summary>
		///     The <see cref="EndDoc" /> function ends a print job.
		/// </summary>
		/// <param name="hdc">Handle to the device context for the print job.</param>
		/// <returns>
		///     <para>If the function succeeds, the return value is greater than zero.</para>
		///     <para>If the function fails, the return value is less than or equal to zero.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         Note:  This is a blocking or synchronous function and might not return immediately. How quickly this function returns depends on run-time
		///         factors such as network status, print server configuration, and printer driver implementation—factors that are difficult to predict when
		///         writing an application. Calling this function from a thread that manages interaction with the user interface could make the application
		///         appear to be unresponsive.
		///     </para>
		///     <para>
		///         Applications should call <see cref="EndDoc" /> immediately after finishing a print job.
		///     </para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "EndDoc")]
		public static extern int EndDoc([In] IntPtr hdc);

		/// <summary>
		///     The <see cref="DPtoLP" /> function converts device coordinates into logical coordinates. The conversion depends on the mapping mode of the device
		///     context, the settings of the origins and extents for the window and viewport, and the world transformation.
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <param name="lpPoints">
		///     A pointer to an array of <see cref="POINT" /> structures. The x- and y-coordinates contained in each <see cref="POINT" /> structure will be
		///     transformed.
		/// </param>
		/// <param name="nCount">The number of points in the array.</param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     The <see cref="DPtoLP" /> function fails if the device coordinates exceed 27 bits, or if the converted logical coordinates exceed 32 bits. In the
		///     case of such an overflow, the results for all the points are undefined.
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "DPtoLP")]
		public static extern bool DPtoLP([In] IntPtr hdc, ref POINT[] lpPoints, int nCount);

		/// <summary>
		///     The <see cref="BitBlt" /> function performs a bit-block transfer of the color data corresponding to a rectangle of pixels from the specified
		///     source device context into a destination device context.
		/// </summary>
		/// <param name="hdcDest">A handle to the destination device context.</param>
		/// <param name="nXDest">The x-coordinate, in logical units, of the upper-left corner of the destination rectangle.</param>
		/// <param name="nYDest">The y-coordinate, in logical units, of the upper-left corner of the destination rectangle.</param>
		/// <param name="nWidth">The width, in logical units, of the source and destination rectangles.</param>
		/// <param name="nHeight">The height, in logical units, of the source and the destination rectangles.</param>
		/// <param name="hdcSrc">A handle to the source device context.</param>
		/// <param name="nXSrc">The x-coordinate, in logical units, of the upper-left corner of the source rectangle.</param>
		/// <param name="nYSrc">The y-coordinate, in logical units, of the upper-left corner of the source rectangle.</param>
		/// <param name="dwRop">
		///     <para>
		///         A raster-operation code. These codes define how the color data for the source rectangle is to be combined with the color data for the
		///         destination rectangle to achieve the final color.
		///     </para>
		///     <para>The following list shows some common raster operation codes.</para>
		///     <list type="table">
		///         <item>
		///             <term>BLACKNESS</term>
		///             <description>
		///                 Fills the destination rectangle using the color associated with index 0 in the physical palette. (This color is black for the default
		///                 physical palette.)
		///             </description>
		///         </item>
		///         <item>
		///             <term>CAPTUREBLT</term>
		///             <description>
		///                 Includes any windows that are layered on top of your window in the resulting image. By default, the image only contains your window.
		///                 Note that this generally cannot be used for printing device contexts.
		///             </description>
		///         </item>
		///         <item>
		///             <term>DSTINVERT</term>
		///             <description>Inverts the destination rectangle.</description>
		///         </item>
		///         <item>
		///             <term>MERGECOPY</term>
		///             <description>
		///                 Merges the colors of the source rectangle with the brush currently selected in <paramref name="hdcDest" />, by using the Boolean AND
		///                 operator.
		///             </description>
		///         </item>
		///         <item>
		///             <term>MERGEPAINT</term>
		///             <description>
		///                 Merges the colors of the inverted source rectangle with the colors of the destination rectangle by using the Boolean OR
		///                 operator.
		///             </description>
		///         </item>
		///         <item>
		///             <term>NOMIRRORBITMAP</term>
		///             <description>Prevents the bitmap from being mirrored.</description>
		///         </item>
		///         <item>
		///             <term>NOTSRCCOPY</term>
		///             <description>Copies the inverted source rectangle to the destination.</description>
		///         </item>
		///         <item>
		///             <term>NOTSRCERASE</term>
		///             <description>
		///                 Combines the colors of the source and destination rectangles by using the Boolean OR operator and then inverts the resultant
		///                 color.
		///             </description>
		///         </item>
		///         <item>
		///             <term>PATCOPY</term>
		///             <description>
		///                 Copies the brush currently selected in <paramref name="hdcDest" />, into the destination bitmap.
		///             </description>
		///         </item>
		///         <item>
		///             <term>PATINVERT</term>
		///             <description>
		///                 Combines the colors of the brush currently selected in <paramref name="hdcDest" />, with the colors of the destination rectangle by
		///                 using the Boolean XOR operator.
		///             </description>
		///         </item>
		///         <item>
		///             <term>PATPAINT</term>
		///             <description>
		///                 Combines the colors of the brush currently selected in <paramref name="hdcDest" />, with the colors of the inverted source rectangle
		///                 by using the Boolean OR operator. The result of this operation is combined with the colors of the destination rectangle by using the
		///                 Boolean OR operator.
		///             </description>
		///         </item>
		///         <item>
		///             <term>SRCAND</term>
		///             <description>Combines the colors of the source and destination rectangles by using the Boolean AND operator.</description>
		///         </item>
		///         <item>
		///             <term>SRCCOPY</term>
		///             <description>Copies the source rectangle directly to the destination rectangle.</description>
		///         </item>
		///         <item>
		///             <term>SRCERASE</term>
		///             <description>
		///                 Combines the inverted colors of the destination rectangle with the colors of the source rectangle by using the Boolean AND
		///                 operator.
		///             </description>
		///         </item>
		///         <item>
		///             <term>SRCINVERT</term>
		///             <description>Combines the colors of the source and destination rectangles by using the Boolean XOR operator.</description>
		///         </item>
		///         <item>
		///             <term>SRCPAINT</term>
		///             <description>Combines the colors of the source and destination rectangles by using the Boolean OR operator.</description>
		///         </item>
		///         <item>
		///             <term>WHITENESS</term>
		///             <description>
		///                 Fills the destination rectangle using the color associated with index 1 in the physical palette. (This color is white for the default
		///                 physical palette.)
		///             </description>
		///         </item>
		///     </list>
		/// </param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero. To get extended error information, call GetLastError.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         <see cref="BitBlt" /> only does clipping on the destination DC.
		///     </para>
		///     <para>
		///         If a rotation or shear transformation is in effect in the source device context, <see cref="BitBlt" /> returns an error. If other
		///         transformations exist in the source device context (and a matching transformation is not in effect in the destination device context), the
		///         rectangle in the destination device context is stretched, compressed, or rotated, as necessary.
		///     </para>
		///     <para>
		///         If the color formats of the source and destination device contexts do not match, the <see cref="BitBlt" /> function converts the source color
		///         format to match the destination format.
		///     </para>
		///     <para>When an enhanced metafile is being recorded, an error occurs if the source device context identifies an enhanced-metafile device context.</para>
		///     <para>
		///         Not all devices support the <see cref="BitBlt" /> function. For more information, see the RC_BITBLT raster capability entry in the
		///         <see cref="GetDeviceCaps" /> function as well as the following functions: <see cref="MaskBlt" />, <see cref="PlgBlt" />, and
		///         <see cref="StretchBlt" />.
		///     </para>
		///     <para>
		///         <see cref="BitBlt" /> returns an error if the source and destination device contexts represent different devices. To transfer data between
		///         DCs for different devices, convert the memory bitmap to a DIB by calling <see cref="GetDIBits" />. To display the DIB to the second device,
		///         call <see cref="SetDIBits" /> or <see cref="StretchDIBits" />.
		///     </para>
		///     <para>ICM: No color management is performed when blits occur.</para>
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "BitBlt")]
		public static extern bool BitBlt([In] IntPtr hdcDest, int nXDest, int nYDest, int nWidth, int nHeight, [In] IntPtr hdcSrc, int nXSrc, int nYSrc, uint dwRop);

		/// <summary>
		///     The <see cref="Chord" /> function draws a chord (a region bounded by the intersection of an ellipse and a line segment, called a secant). The
		///     chord is outlined by using the current pen and filled by using the current brush.
		/// </summary>
		/// <param name="hdc">A handle to the device context in which the chord appears.</param>
		/// <param name="nLeftRect">The x-coordinate, in logical coordinates, of the upper-left corner of the bounding rectangle.</param>
		/// <param name="nTopRect">The y-coordinate, in logical coordinates, of the upper-left corner of the bounding rectangle.</param>
		/// <param name="nRightRect">The x-coordinate, in logical coordinates, of the lower-right corner of the bounding rectangle.</param>
		/// <param name="nBottomRect">The y-coordinate, in logical coordinates, of the lower-right corner of the bounding rectangle.</param>
		/// <param name="nXRadial1">The x-coordinate, in logical coordinates, of the endpoint of the radial defining the beginning of the chord.</param>
		/// <param name="nYRadial1">The y-coordinate, in logical coordinates, of the endpoint of the radial defining the beginning of the chord.</param>
		/// <param name="nXRadial2">The x-coordinate, in logical coordinates, of the endpoint of the radial defining the end of the chord.</param>
		/// <param name="nYRadial2">The y-coordinate, in logical coordinates, of the endpoint of the radial defining the end of the chord.</param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         The curve of the chord is defined by an ellipse that fits the specified bounding rectangle. The curve begins at the point where the ellipse
		///         intersects the first radial and extends counterclockwise to the point where the ellipse intersects the second radial. The chord is closed by
		///         drawing a line from the intersection of the first radial and the curve to the intersection of the second radial and the curve.
		///     </para>
		///     <para>If the starting point and ending point of the curve are the same, a complete ellipse is drawn.</para>
		///     <para>
		///         The current position is neither used nor updated by <see cref="Chord" />.
		///     </para>
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "Chord")]
		public static extern bool Chord(
			[In] IntPtr hdc, int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nXRadial1, int nYRadial1, int nXRadial2, int nYRadial2);

		/// <summary>
		///     The <see cref="ArcTo" /> function draws an elliptical arc.
		/// </summary>
		/// <param name="hdc">A handle to the device context where drawing takes place.</param>
		/// <param name="nLeftRect">The x-coordinate, in logical units, of the upper-left corner of the bounding rectangle.</param>
		/// <param name="nTopRect">The y-coordinate, in logical units, of the upper-left corner of the bounding rectangle.</param>
		/// <param name="nRightRect">The x-coordinate, in logical units, of the lower-right corner of the bounding rectangle.</param>
		/// <param name="nBottomRect">The y-coordinate, in logical units, of the lower-right corner of the bounding rectangle.</param>
		/// <param name="nXRadial1">The x-coordinate, in logical units, of the endpoint of the radial defining the starting point of the arc.</param>
		/// <param name="nYRadial1">The y-coordinate, in logical units, of the endpoint of the radial defining the starting point of the arc.</param>
		/// <param name="nXRadial2">The x-coordinate, in logical units, of the endpoint of the radial defining the ending point of the arc.</param>
		/// <param name="nYRadial2">The y-coordinate, in logical units, of the endpoint of the radial defining the ending point of the arc.</param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         <see cref="ArcTo" /> is similar to the <see cref="Arc" /> function, except that the current position is updated.
		///     </para>
		///     <para>
		///         The points (<paramref name="nLeftRect" />, <paramref name="nTopRect" />) and (<paramref name="nRightRect" />, <paramref name="nBottomRect" />
		///         ) specify the bounding rectangle. An ellipse formed by the specified bounding rectangle defines the curve of the arc. The arc extends
		///         counterclockwise from the point where it intersects the radial line from the center of the bounding rectangle to the (
		///         <paramref name="nXRadial1" />, <paramref name="nYRadial1" />) point. The arc ends where it intersects the radial line from the center of the
		///         bounding rectangle to the (<paramref name="nXRadial2" />, <paramref name="nYRadial2" />) point. If the starting point and ending point are
		///         the same, a complete ellipse is drawn.
		///     </para>
		///     <para>
		///         A line is drawn from the current position to the starting point of the arc. If no error occurs, the current position is set to the ending
		///         point of the arc.
		///     </para>
		///     <para>The arc is drawn using the current pen; it is not filled.</para>
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "ArcTo")]
		public static extern bool ArcTo(
			[In] IntPtr hdc, int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nXRadial1, int nYRadial1, int nXRadial2, int nYRadial2);

		/// <summary>
		///     The <see cref="Pie" /> function draws a pie-shaped wedge bounded by the intersection of an ellipse and two radials. The pie is outlined by using
		///     the current pen and filled by using the current brush.
		/// </summary>
		/// <param name="hdc">A handle to the device context.</param>
		/// <param name="nLeftRect">The x-coordinate, in logical coordinates, of the upper-left corner of the bounding rectangle.</param>
		/// <param name="nTopRect">The y-coordinate, in logical coordinates, of the upper-left corner of the bounding rectangle.</param>
		/// <param name="nRightRect">The x-coordinate, in logical coordinates, of the lower-right corner of the bounding rectangle.</param>
		/// <param name="nBottomRect">The y-coordinate, in logical coordinates, of the lower-right corner of the bounding rectangle.</param>
		/// <param name="nXRadial1">The x-coordinate, in logical coordinates, of the endpoint of the first radial.</param>
		/// <param name="nYRadial1">The y-coordinate, in logical coordinates, of the endpoint of the first radial.</param>
		/// <param name="nXRadial2">The x-coordinate, in logical coordinates, of the endpoint of the second radial.</param>
		/// <param name="nYRadial2">The y-coordinate, in logical coordinates, of the endpoint of the second radial.</param>
		/// <returns>
		///     <para>If the function succeeds, the return value is nonzero.</para>
		///     <para>If the function fails, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         The curve of the pie is defined by an ellipse that fits the specified bounding rectangle. The curve begins at the point where the ellipse
		///         intersects the first radial and extends counterclockwise to the point where the ellipse intersects the second radial.
		///     </para>
		///     <para>
		///         The current position is neither used nor updated by the <see cref="Pie" /> function.
		///     </para>
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "Pie")]
		public static extern bool Pie(
			[In] IntPtr hdc, int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nXRadial1, int nYRadial1, int nXRadial2, int nYRadial2);

		/// <summary>
		///     The <see cref="Arc" /> function draws an elliptical arc.
		/// </summary>
		/// <param name="hdc">A handle to the device context where drawing takes place.</param>
		/// <param name="nLeftRect">The x-coordinate, in logical units, of the upper-left corner of the bounding rectangle.</param>
		/// <param name="nTopRect">The y-coordinate, in logical units, of the upper-left corner of the bounding rectangle.</param>
		/// <param name="nRightRect">The x-coordinate, in logical units, of the lower-right corner of the bounding rectangle.</param>
		/// <param name="nBottomRect">The y-coordinate, in logical units, of the lower-right corner of the bounding rectangle.</param>
		/// <param name="nXStartArc">The x-coordinate, in logical units, of the ending point of the radial line defining the starting point of the arc.</param>
		/// <param name="nYStartArc">The y-coordinate, in logical units, of the ending point of the radial line defining the starting point of the arc.</param>
		/// <param name="nXEndArc">The x-coordinate, in logical units, of the ending point of the radial line defining the ending point of the arc.</param>
		/// <param name="nYEndArc">The y-coordinate, in logical units, of the ending point of the radial line defining the ending point of the arc.</param>
		/// <returns>
		///     <para>If the arc is drawn, the return value is nonzero.</para>
		///     <para>If the arc is not drawn, the return value is zero.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         The points (<paramref name="nLeftRect" />, <paramref name="nTopRect" />) and (<paramref name="nRightRect" />, <paramref name="nBottomRect" />
		///         ) specify the bounding rectangle. An ellipse formed by the specified bounding rectangle defines the curve of the arc. The arc extends in the
		///         current drawing direction from the point where it intersects the radial from the center of the bounding rectangle to the (
		///         <paramref name="nXStartArc" />, <paramref name="nYStartArc" />) point. The arc ends where it intersects the radial from the center of the
		///         bounding rectangle to the (<paramref name="nXEndArc" />, <paramref name="nYEndArc" />) point. If the starting point and ending point are the
		///         same, a complete ellipse is drawn.
		///     </para>
		///     <para>The arc is drawn using the current pen; it is not filled.</para>
		///     <para>
		///         The current position is neither used nor updated by <see cref="Arc" />.
		///     </para>
		///     <para>
		///         Use the <see cref="GetArcDirection" /> and <see cref="SetArcDirection" /> functions to get and set the current drawing direction for a device
		///         context. The default drawing direction is counterclockwise.
		///     </para>
		/// </remarks>
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("gdi32.dll", EntryPoint = "Arc")]
		public static extern bool Arc(
			[In] IntPtr hdc, int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nXStartArc, int nYStartArc, int nXEndArc, int nYEndArc);

		/// <summary>
		///     <para>Applies to: desktop apps only</para>
		///     <para>
		///         The <see cref="GetEnhMetaFilePixelFormat" /> function retrieves pixel format information for an enhanced metafile.
		///     </para>
		/// </summary>
		/// <param name="hemf">Identifies the enhanced metafile.</param>
		/// <param name="cbBuffer">Specifies the size, in bytes, of the buffer into which the pixel format information is copied.</param>
		/// <param name="ppfd">
		///     Pointer to a <see cref="PIXELFORMATDESCRIPTOR" /> structure that contains the logical pixel format specification. The metafile uses this
		///     structure to record the logical pixel format specification.
		/// </param>
		/// <returns>
		///     <para>If the function succeeds and finds a pixel format, the return value is the size of the metafile's pixel format.</para>
		///     <para>If no pixel format is present, the return value is zero.</para>
		///     <para>If an error occurs and the function fails, the return value is GDI_ERROR. To get extended error information, call GetLastError.</para>
		/// </returns>
		/// <remarks>
		///     <para>
		///         When an enhanced metafile specifies a pixel format in its <see cref="ENHMETAHEADER" /> structure and the pixel format fits in the buffer, the
		///         pixel format information is copied into <paramref name="ppfd" />. When <paramref name="cbBuffer" /> is too small to contain the pixel format
		///         of the metafile, the pixel format is not copied to the buffer. In either case, the function returns the size of the metafile's pixel format.
		///     </para>
		///     <para>For information on metafile recording and other operations, see Enhanced Metafile Operations.</para>
		/// </remarks>
		[DllImport("gdi32.dll", EntryPoint = "GetEnhMetaFilePixelFormat")]
		public static extern uint GetEnhMetaFilePixelFormat([In] IntPtr hemf, uint cbBuffer, ref PIXELFORMATDESCRIPTOR ppfd);
	}
	// ReSharper restore InconsistentNaming
}