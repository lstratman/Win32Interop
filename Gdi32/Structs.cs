using System;
using System.Runtime.InteropServices;
using Win32Interop.Methods;

// ReSharper disable CheckNamespace

namespace Win32Interop.Structs
// ReSharper restore CheckNamespace
{
	// ReSharper disable InconsistentNaming
	/// <summary>
	///     The <see cref="ENHMETARECORD" /> structure contains data that describes a graphics device interface (GDI) function used to create part of a
	///     picture in an enhanced-format metafile.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct ENHMETARECORD
	{
		/// <summary>The record type.</summary>
		public uint iType;

		/// <summary>The size of the record, in bytes.</summary>
		public uint nSize;

		/// <summary>An array of parameters passed to the GDI function identified by the record.</summary>
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.U4)]
		public uint[] dParm;
	}

	/// <summary>
	///     The <see cref="ENUMLOGFONTEXDV" /> structure contains the information used to create a font.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct ENUMLOGFONTEXDV
	{
		/// <summary>
		///     An <see cref="ENUMLOGFONTEX" /> structure that contains information about the logical attributes of the font.
		/// </summary>
		public ENUMLOGFONTEX elfEnumLogfontEx;

		/// <summary>
		///     A <see cref="DESIGNVECTOR" /> structure. This is zero-filled unless the font described is a multiple master OpenType font.
		/// </summary>
		public DESIGNVECTOR elfDesignVector;
	}

	/// <summary>
	///     The <see cref="XFORM" /> structure specifies a world-space to page-space transformation.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct XFORM
	{
		/// <summary>
		///     <para>The following.</para>
		///     <list type="table">
		///         <item>
		///             <term>Scaling</term>
		///             <description>Horizontal scaling component</description>
		///         </item>
		///         <item>
		///             <term>Rotation</term>
		///             <description>Cosine of rotation angle</description>
		///         </item>
		///         <item>
		///             <term>Reflection</term>
		///             <description>Horizontal component</description>
		///         </item>
		///     </list>
		/// </summary>
		public float eM11;

		/// <summary>
		///     <para>The following.</para>
		///     <list type="table">
		///         <item>
		///             <term>Shear</term>
		///             <description>Horizontal proportionality constant</description>
		///         </item>
		///         <item>
		///             <term>Rotation</term>
		///             <description>Sine of the rotation angle</description>
		///         </item>
		///     </list>
		/// </summary>
		public float eM12;

		/// <summary>
		///     <para>The following.</para>
		///     <list type="table">
		///         <item>
		///             <term>Shear</term>
		///             <description>Vertical proportionality constant</description>
		///         </item>
		///         <item>
		///             <term>Rotation</term>
		///             <description>Negative sine of the rotation angle</description>
		///         </item>
		///     </list>
		/// </summary>
		public float eM21;

		/// <summary>
		///     <para>The following.</para>
		///     <list type="table">
		///         <item>
		///             <term>Scaling</term>
		///             <description>Vertical scaling component</description>
		///         </item>
		///         <item>
		///             <term>Rotation</term>
		///             <description>Cosine of rotation angle</description>
		///         </item>
		///         <item>
		///             <term>Reflection</term>
		///             <description>Vertical reflection component</description>
		///         </item>
		///     </list>
		/// </summary>
		public float eM22;

		/// <summary>The horizontal translation component, in logical units.</summary>
		public float eDx;

		/// <summary>The vertical translation component, in logical units.</summary>
		public float eDy;
	}

	/// <summary>
	///     The <see cref="BITMAP" /> structure defines the type, width, height, color format, and bit values of a bitmap.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct BITMAP
	{
		/// <summary>The bitmap type. This member must be zero.</summary>
		public int bmType;

		/// <summary>The width, in pixels, of the bitmap. The width must be greater than zero.</summary>
		public int bmWidth;

		/// <summary>The height, in pixels, of the bitmap. The height must be greater than zero.</summary>
		public int bmHeight;

		/// <summary>
		///     The number of bytes in each scan line. This value must be divisible by 2, because the system assumes that the bit values of a bitmap form an
		///     array that is word aligned.
		/// </summary>
		public int bmWidthBytes;

		/// <summary>The count of color planes.</summary>
		public ushort bmPlanes;

		/// <summary>The number of bits required to indicate the color of a pixel.</summary>
		public ushort bmBitsPixel;

		/// <summary>
		///     A pointer to the location of the bit values for the bitmap. The <see cref="bmBits" /> member must be a pointer to an array of character (1-byte)
		///     values.
		/// </summary>
		public IntPtr bmBits;
	}

	/// <summary>
	///     The <see cref="LOGBRUSH" /> structure defines the style, color, and pattern of a physical brush. It is used by the
	///     <see cref="Gdi32.CreateBrushIndirect" /> and <see cref="Gdi32.ExtCreatePen" /> functions.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct LOGBRUSH
	{
		/// <summary>
		///     <para>
		///         The brush style. The <see cref="lbStyle" /> member must be one of the following styles.
		///     </para>
		///     <list type="table">
		///         <item>
		///             <term>BS_DIBPATTERN</term>
		///             <description>
		///                 A pattern brush defined by a device-independent bitmap (DIB) specification. If <see cref="lbStyle" /> is BS_DIBPATTERN, the
		///                 <see cref="lbHatch" /> member contains a handle to a packed DIB. For more information, see discussion in <see cref="lbHatch" />.
		///             </description>
		///         </item>
		///         <item>
		///             <term>BS_DIBPATTERN8X8</term>
		///             <description>See BS_DIBPATTERN.</description>
		///         </item>
		///         <item>
		///             <term>BS_DIBPATTERNPT</term>
		///             <description>
		///                 A pattern brush defined by a device-independent bitmap (DIB) specification. If <see cref="lbStyle" /> is BS_DIBPATTERNPT, the
		///                 <see cref="lbHatch" /> member contains a pointer to a packed DIB. For more information, see discussion in <see cref="lbHatch" />.
		///             </description>
		///         </item>
		///         <item>
		///             <term>BS_HATCHED</term>
		///             <description>Hatched brush.</description>
		///         </item>
		///         <item>
		///             <term>BS_HOLLOW</term>
		///             <description>Hollow brush.</description>
		///         </item>
		///         <item>
		///             <term>BS_NULL</term>
		///             <description>Same as BS_HOLLOW.</description>
		///         </item>
		///         <item>
		///             <term>BS_PATTERN</term>
		///             <description>Pattern brush defined by a memory bitmap.</description>
		///         </item>
		///         <item>
		///             <term>BS_PATTERN8X8</term>
		///             <description>See BS_PATTERN.</description>
		///         </item>
		///         <item>
		///             <term>BS_SOLID</term>
		///             <description>Solid brush.</description>
		///         </item>
		///     </list>
		/// </summary>
		public uint lbStyle;

		/// <summary>
		///     <para>
		///         The color in which the brush is to be drawn. If <see cref="lbStyle" /> is the BS_HOLLOW or BS_PATTERN style, <see cref="lbColor" /> is
		///         ignored.
		///     </para>
		///     <para>
		///         If <see cref="lbStyle" /> is BS_DIBPATTERN or BS_DIBPATTERNPT, the low-order word of <see cref="lbColor" /> specifies whether the
		///         <see cref="BITMAPINFO.bmiColors" /> members of the <see cref="BITMAPINFO" /> structure contain explicit red, green, blue (RGB) values or
		///         indexes into the currently realized logical palette. The <see cref="lbColor" /> member must be one of the following values.
		///     </para>
		///     <list type="table">
		///         <item>
		///             <term>DIB_PAL_COLORS</term>
		///             <description>The color table consists of an array of 16-bit indexes into the currently realized logical palette.</description>
		///         </item>
		///         <item>
		///             <term>DIB_RGB_COLORS</term>
		///             <description>The color table contains literal RGB values.</description>
		///         </item>
		///     </list>
		///     <para>
		///         If <see cref="lbStyle" /> is BS_HATCHED or BS_SOLID, <see cref="lbColor" /> is a <see cref="COLORREF" /> color value. To create a
		///         <see cref="COLORREF" /> color value, use the RGB macro.
		///     </para>
		/// </summary>
		public uint lbColor;

		/// <summary>
		///     <para>
		///         A hatch style. The meaning depends on the brush style defined by <see cref="lbStyle" />.
		///     </para>
		///     <para>
		///         If <see cref="lbStyle" /> is BS_DIBPATTERN, the <see cref="lbHatch" /> member contains a handle to a packed DIB. To obtain this handle, an
		///         application calls the GlobalAlloc function with GMEM_MOVEABLE (or LocalAlloc with LMEM_MOVEABLE) to allocate a block of memory and then fills
		///         the memory with the packed DIB. A packed DIB consists of a <see cref="BITMAPINFO" /> structure immediately followed by the array of bytes
		///         that define the pixels of the bitmap.
		///     </para>
		///     <para>
		///         If <see cref="lbStyle" /> is BS_DIBPATTERNPT, the <see cref="lbHatch" /> member contains a pointer to a packed DIB. The pointer derives from
		///         the memory block created by LocalAlloc with LMEM_FIXED set or by GlobalAlloc with GMEM_FIXED set, or it is the pointer returned by a call
		///         like LocalLock (handle_to_the_dib). A packed DIB consists of a <see cref="BITMAPINFO" /> structure immediately followed by the array of bytes
		///         that define the pixels of the bitmap.
		///     </para>
		///     <para>
		///         If <see cref="lbStyle" /> is BS_HATCHED, the <see cref="lbHatch" /> member specifies the orientation of the lines used to create the hatch.
		///         It can be one of the following values.
		///     </para>
		///     <list type="table">
		///         <item>
		///             <term>HS_BDIAGONAL</term>
		///             <description>A 45-degree upward, left-to-right hatch</description>
		///         </item>
		///         <item>
		///             <term>HS_CROSS</term>
		///             <description>Horizontal and vertical cross-hatch</description>
		///         </item>
		///         <item>
		///             <term>HS_DIAGCROSS</term>
		///             <description>45-degree crosshatch</description>
		///         </item>
		///         <item>
		///             <term>HS_FDIAGONAL</term>
		///             <description>A 45-degree downward, left-to-right hatch</description>
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
		///     <para>
		///         If <see cref="lbStyle" /> is BS_PATTERN, <see cref="lbHatch" /> is a handle to the bitmap that defines the pattern. The bitmap cannot be a
		///         DIB section bitmap, which is created by the <see cref="Gdi32.CreateDIBSection" /> function.
		///     </para>
		///     <para>
		///         If <see cref="lbStyle" /> is BS_SOLID or BS_HOLLOW, <see cref="lbHatch" /> is ignored.
		///     </para>
		/// </summary>
		public uint lbHatch;
	}

	/// <summary>Defines the metafile picture format used for exchanging metafile data through the clipboard.</summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct METAFILEPICT
	{
		/// <summary>The mapping mode in which the picture is drawn.</summary>
		public int mm;

		/// <summary>
		///     The size of the metafile picture for all modes except the MM_ISOTROPIC and MM_ANISOTROPIC modes. (For more information about these modes, see the
		///     <see cref="yExt" /> member.) The x-extent specifies the width of the rectangle within which the picture is drawn. The coordinates are in units
		///     that correspond to the mapping mode.
		/// </summary>
		public int xExt;

		/// <summary>
		///     The size of the metafile picture for all modes except the MM_ISOTROPIC and MM_ANISOTROPIC modes. The y-extent specifies the height of the
		///     rectangle within which the picture is drawn. The coordinates are in units that correspond to the mapping mode. For MM_ISOTROPIC and
		///     MM_ANISOTROPIC modes, which can be scaled, the <see cref="xExt" /> and <see cref="yExt" /> members contain an optional suggested size in
		///     MM_HIMETRIC units. For MM_ANISOTROPIC pictures, <see cref="xExt" /> and
		///     <see cref="yExt" /> can be zero when no suggested size is supplied. For MM_ISOTROPIC pictures, an aspect ratio must be supplied even when no
		///     suggested size is given. (If a suggested size is given, the aspect ratio is implied by the size.) To give an aspect ratio without implying a
		///     suggested size, set <see cref="xExt" /> and <see cref="yExt" /> to negative values whose ratio is the appropriate aspect ratio. The magnitude of
		///     the negative <see cref="xExt" /> and <see cref="yExt" /> values is ignored; only the ratio is used.
		/// </summary>
		public int yExt;

		/// <summary>A handle to a memory metafile.</summary>
		public IntPtr hMF;
	}

	/// <summary>
	///     The <see cref="COLORADJUSTMENT" /> structure defines the color adjustment values used by the <see cref="Gdi32.StretchBlt" /> and
	///     <see cref="Gdi32.StretchDIBits" /> functions when the stretch mode is HALFTONE. You can set the color adjustment values by calling the
	///     <see cref="Gdi32.SetColorAdjustment" /> function.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct COLORADJUSTMENT
	{
		/// <summary>The size, in bytes, of the structure.</summary>
		public ushort caSize;

		/// <summary>
		///     <para>Specifies how the output image should be prepared. This member may be set to NULL or any combination of the following values.</para>
		///     <list type="table">
		///         <item>
		///             <term>CA_NEGATIVE</term>
		///             <description>Specifies that the negative of the original image should be displayed.</description>
		///         </item>
		///         <item>
		///             <term>CA_LOG_FILTER</term>
		///             <description>
		///                 Specifies that a logarithmic function should be applied to the final density of the output colors. This will increase the color
		///                 contrast when the luminance is low.
		///             </description>
		///         </item>
		///     </list>
		/// </summary>
		public ushort caFlags;

		/// <summary>
		///     <para>The type of standard light source under which the image is viewed. This member may be set to one of the following values.</para>
		///     <list type="table">
		///         <item>
		///             <term>ILLUMINANT_DEVICE_DEFAULT</term>
		///             <description>Device's default. Standard used by output devices.</description>
		///         </item>
		///         <item>
		///             <term>ILLUMINANT_A</term>
		///             <description>Tungsten lamp.</description>
		///         </item>
		///         <item>
		///             <term>ILLUMINANT_B</term>
		///             <description>Noon sunlight.</description>
		///         </item>
		///         <item>
		///             <term>ILLUMINANT_C</term>
		///             <description>NTSC daylight.</description>
		///         </item>
		///         <item>
		///             <term>ILLUMINANT_D50</term>
		///             <description>Normal print.</description>
		///         </item>
		///         <item>
		///             <term>ILLUMINANT_D55</term>
		///             <description>Bond paper print.</description>
		///         </item>
		///         <item>
		///             <term>ILLUMINANT_D65</term>
		///             <description>Standard daylight. Standard for CRTs and pictures.</description>
		///         </item>
		///         <item>
		///             <term>ILLUMINANT_D75</term>
		///             <description>Northern daylight.</description>
		///         </item>
		///         <item>
		///             <term>ILLUMINANT_F2</term>
		///             <description>Cool white lamp.</description>
		///         </item>
		///         <item>
		///             <term>ILLUMINANT_TUNGSTEN</term>
		///             <description>Same as ILLUMINANT_A.</description>
		///         </item>
		///         <item>
		///             <term>ILLUMINANT_DAYLIGHT</term>
		///             <description>Same as ILLUMINANT_C.</description>
		///         </item>
		///         <item>
		///             <term>ILLUMINANT_FLUORESCENT</term>
		///             <description>Same as ILLUMINANT_F2.</description>
		///         </item>
		///         <item>
		///             <term>ILLUMINANT_NTSC</term>
		///             <description>Same as ILLUMINANT_C.</description>
		///         </item>
		///     </list>
		/// </summary>
		public ushort caIlluminantIndex;

		/// <summary>
		///     Specifies the nth power gamma-correction value for the red primary of the source colors. The value must be in the range from 2500 to 65,000. A
		///     value of 10,000 means no gamma correction.
		/// </summary>
		public ushort caRedGamma;

		/// <summary>
		///     Specifies the nth power gamma-correction value for the green primary of the source colors. The value must be in the range from 2500 to 65,000. A
		///     value of 10,000 means no gamma correction.
		/// </summary>
		public ushort caGreenGamma;

		/// <summary>
		///     Specifies the nth power gamma-correction value for the blue primary of the source colors. The value must be in the range from 2500 to 65,000. A
		///     value of 10,000 means no gamma correction.
		/// </summary>
		public ushort caBlueGamma;

		/// <summary>
		///     The black reference for the source colors. Any colors that are darker than this are treated as black. The value must be in the range from 0
		///     to 4000.
		/// </summary>
		public ushort caReferenceBlack;

		/// <summary>
		///     The white reference for the source colors. Any colors that are lighter than this are treated as white. The value must be in the range from 6000
		///     to 10,000.
		/// </summary>
		public ushort caReferenceWhite;

		/// <summary>
		///     The amount of contrast to be applied to the source object. The value must be in the range from -100 to 100. A value of 0 means no contrast
		///     adjustment.
		/// </summary>
		public short caContrast;

		/// <summary>
		///     The amount of brightness to be applied to the source object. The value must be in the range from -100 to 100. A value of 0 means no brightness
		///     adjustment.
		/// </summary>
		public short caBrightness;

		/// <summary>
		///     The amount of colorfulness to be applied to the source object. The value must be in the range from -100 to 100. A value of 0 means no
		///     colorfulness adjustment.
		/// </summary>
		public short caColorfulness;

		/// <summary>
		///     The amount of red or green tint adjustment to be applied to the source object. The value must be in the range from -100 to 100. Positive numbers
		///     adjust toward red and negative numbers adjust toward green. Zero means no tint adjustment.
		/// </summary>
		public short caRedGreenTint;
	}

	/// <summary>
	///     The <see cref="PALETTEENTRY" /> structure specifies the color and usage of an entry in a logical palette. A logical palette is defined by a
	///     <see cref="LOGPALETTE" /> structure.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct PALETTEENTRY
	{
		/// <summary>The red intensity value for the palette entry.</summary>
		public byte peRed;

		/// <summary>The green intensity value for the palette entry.</summary>
		public byte peGreen;

		/// <summary>The blue intensity value for the palette entry.</summary>
		public byte peBlue;

		/// <summary>
		///     <para>Indicates how the palette entry is to be used. This member may be set to 0 or one of the following values.</para>
		///     <list type="table">
		///         <item>
		///             <term>PC_EXPLICIT</term>
		///             <description>
		///                 Specifies that the low-order word of the logical palette entry designates a hardware palette index. This flag allows the application
		///                 to show the contents of the display device palette.
		///             </description>
		///         </item>
		///         <item>
		///             <term>PC_NOCOLLAPSE</term>
		///             <description>
		///                 Specifies that the color be placed in an unused entry in the system palette instead of being matched to an existing color in the
		///                 system palette. If there are no unused entries in the system palette, the color is matched normally. Once this color is in the system
		///                 palette, colors in other logical palettes can be matched to this color.
		///             </description>
		///         </item>
		///         <item>
		///             <term>PC_RESERVED</term>
		///             <description>
		///                 Specifies that the logical palette entry be used for palette animation. This flag prevents other windows from matching colors to the
		///                 palette entry since the color frequently changes. If an unused system-palette entry is available, the color is placed in that entry.
		///                 Otherwise, the color is not available for animation.
		///             </description>
		///         </item>
		///     </list>
		/// </summary>
		public byte peFlags;
	}

	/// <summary>
	///     The <see cref="BITMAPINFO" /> structure defines the dimensions and color information for a DIB.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct BITMAPINFO
	{
		/// <summary>
		///     <para>
		///         A <see cref="BITMAPINFOHEADER" /> structure that contains information about the dimensions of color format.
		///     </para>
		///     <para>.</para>
		/// </summary>
		public BITMAPINFOHEADER bmiHeader;

		/// <summary>
		///     <para>
		///         The <see cref="BITMAPINFO.bmiColors" /> member contains one of the following:
		///     </para>
		///     <para>
		///         The number of entries in the array depends on the values of the <see cref="BITMAPINFOHEADER.biBitCount" /> and
		///         <see cref="BITMAPINFOHEADER.biClrUsed" /> members of the
		///         <see cref="BITMAPINFOHEADER" /> structure.
		///     </para>
		///     <para>
		///         The colors in the <see cref="BITMAPINFO.bmiColors" /> table appear in order of importance. For more information, see the Remarks section.
		///     </para>
		/// </summary>
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.Struct)]
		public RGBQUAD[] bmiColors;
	}

	/// <summary>
	///     The <see cref="LOGPEN" /> structure defines the style, width, and color of a pen. The <see cref="Gdi32.CreatePenIndirect" /> function uses the
	///     <see cref="LOGPEN" /> structure.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct LOGPEN
	{
		/// <summary>
		///     <para>The pen style, which can be one of the following values.</para>
		///     <list type="table">
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
		///             <description>The pen has dashes and double dots.</description>
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
		/// </summary>
		public uint lopnStyle;

		/// <summary>
		///     The <see cref="POINT" /> structure that contains the pen width, in logical units. If the pointer member is NULL, the pen is one pixel wide on
		///     raster devices. The <see cref="POINT.y" /> member in the <see cref="POINT" /> structure for <see cref="lopnWidth" /> is not used.
		/// </summary>
		public POINT lopnWidth;

		/// <summary>
		///     The pen color. To generate a <see cref="COLORREF" /> structure, use the RGB macro.
		/// </summary>
		public uint lopnColor;
	}

	/// <summary>
	///     The <see cref="ENUMTEXTMETRIC" /> structure contains information about a physical font.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct ENUMTEXTMETRIC
	{
		/// <summary>
		///     A <see cref="NEWTEXTMETRICEX" /> structure, containing information about a physical font.
		/// </summary>
		public NEWTEXTMETRICEX etmNewTextMetricEx;

		/// <summary>
		///     An <see cref="AXESLIST" /> structure, containing information about the axes for the font. This is only used for multiple master fonts.
		/// </summary>
		public AXESLIST etmAxesList;
	}

	/// <summary>
	///     The <see cref="AXESLIST" /> structure contains information on all the axes of a multiple master font.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct AXESLIST
	{
		/// <summary>Reserved. Must be STAMP_AXESLIST.</summary>
		public uint axlReserved;

		/// <summary>Number of axes for a specified multiple master font.</summary>
		public uint axlNumAxes;

		/// <summary>
		///     An array of <see cref="AXISINFO" /> structures. Each <see cref="AXISINFO" /> structure contains information on an axis of a specified multiple
		///     master font. This corresponds to the <see cref="DESIGNVECTOR.dvValues" /> array in the <see cref="DESIGNVECTOR" /> structure.
		/// </summary>
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.Struct)]
		public AXISINFO[] axlAxisInfo;
	}

	/// <summary>
	///     The <see cref="AXISINFO" /> structure contains information about an axis of a multiple master font.
	/// </summary>
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct AXISINFO
	{
		/// <summary>The minimum value for this axis.</summary>
		public int axMinValue;

		/// <summary>The maximum value for this axis.</summary>
		public int axMaxValue;

		/// <summary>The name of the axis, specified as an array of characters.</summary>
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public string axAxisName;
	}

	/// <summary>
	///     The <see cref="NEWTEXTMETRICEX" /> structure contains information about a physical font.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct NEWTEXTMETRICEX
	{
		/// <summary>
		///     A <see cref="NEWTEXTMETRIC" /> structure.
		/// </summary>
		public NEWTEXTMETRIC ntmTm;

		/// <summary>
		///     A <see cref="FONTSIGNATURE" /> structure indicating the coverage of the font.
		/// </summary>
		public FONTSIGNATURE ntmFontSig;
	}

	/// <summary>
	///     The <see cref="NEWTEXTMETRIC" /> structure contains data that describes a physical font.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct NEWTEXTMETRIC
	{
		/// <summary>The height (ascent + descent) of characters.</summary>
		public int tmHeight;

		/// <summary>The ascent (units above the base line) of characters.</summary>
		public int tmAscent;

		/// <summary>The descent (units below the base line) of characters.</summary>
		public int tmDescent;

		/// <summary>
		///     The amount of leading (space) inside the bounds set by the <see cref="tmHeight" /> member. Accent marks and other diacritical characters may
		///     occur in this area. The designer may set this member to zero.
		/// </summary>
		public int tmInternalLeading;

		/// <summary>
		///     The amount of extra leading (space) that the application adds between rows. Since this area is outside the font, it contains no marks and is not
		///     altered by text output calls in either OPAQUE or TRANSPARENT mode. The designer may set this member to zero.
		/// </summary>
		public int tmExternalLeading;

		/// <summary>
		///     The average width of characters in the font (generally defined as the width of the letter x). This value does not include overhang required for
		///     bold or italic characters.
		/// </summary>
		public int tmAveCharWidth;

		/// <summary>The width of the widest character in the font.</summary>
		public int tmMaxCharWidth;

		/// <summary>The weight of the font.</summary>
		public int tmWeight;

		/// <summary>
		///     <para>
		///         The extra width per string that may be added to some synthesized fonts. When synthesizing some attributes, such as bold or italic, graphics
		///         device interface (GDI) or a device may have to add width to a string on both a per-character and per-string basis. For example, GDI makes a
		///         string bold by expanding the spacing of each character and overstriking by an offset value; it italicizes a font by shearing the string. In
		///         either case, there is an overhang past the basic string. For bold strings, the overhang is the distance by which the overstrike is offset.
		///         For italic strings, the overhang is the amount the top of the font is sheared past the bottom of the font.
		///     </para>
		///     <para>
		///         The <see cref="tmOverhang" /> member enables the application to determine how much of the character width returned by a
		///         <see cref="Gdi32.GetTextExtentPoint32" /> function call on a single character is the actual character width and how much is the per-string
		///         extra width. The actual width is the extent minus the overhang.
		///     </para>
		/// </summary>
		public int tmOverhang;

		/// <summary>The horizontal aspect of the device for which the font was designed.</summary>
		public int tmDigitizedAspectX;

		/// <summary>
		///     The vertical aspect of the device for which the font was designed. The ratio of the <see cref="tmDigitizedAspectX" /> and
		///     <see cref="tmDigitizedAspectY" /> members is the aspect ratio of the device for which the font was designed.
		/// </summary>
		public int tmDigitizedAspectY;

		/// <summary>The value of the first character defined in the font.</summary>
		public ushort tmFirstChar;

		/// <summary>The value of the last character defined in the font.</summary>
		public ushort tmLastChar;

		/// <summary>The value of the character to be substituted for characters that are not in the font.</summary>
		public ushort tmDefaultChar;

		/// <summary>The value of the character to be used to define word breaks for text justification.</summary>
		public ushort tmBreakChar;

		/// <summary>An italic font if it is nonzero.</summary>
		public byte tmItalic;

		/// <summary>An underlined font if it is nonzero.</summary>
		public byte tmUnderlined;

		/// <summary>A strikeout font if it is nonzero.</summary>
		public byte tmStruckOut;

		/// <summary>
		///     <para>
		///         The pitch and family of the selected font. The low-order bit (bit 0) specifies the pitch of the font. If it is 1, the font is variable pitch
		///         (or proportional). If it is 0, the font is fixed pitch (or monospace). Bits 1 and 2 specify the font type. If both bits are 0, the font is a
		///         raster font; if bit 1 is 1 and bit 2 is 0, the font is a vector font; if bit 1 is 0 and bit 2 is set, or if both bits are 1, the font is some
		///         other type. Bit 3 is 1 if the font is a device font; otherwise, it is 0.
		///     </para>
		///     <para>
		///         The four high-order bits designate the font family. The <see cref="tmPitchAndFamily" /> member can be combined with the hexadecimal value
		///         0xF0 by using the bitwise AND operator and can then be compared with the font family names for an identical match. For more information about
		///         the font families, see <see cref="LOGFONT" />.
		///     </para>
		/// </summary>
		public byte tmPitchAndFamily;

		/// <summary>The character set of the font.</summary>
		public byte tmCharSet;

		/// <summary>
		///     <para>Specifies whether the font is italic, underscored, outlined, bold, and so forth. May be any reasonable combination of the following values.</para>
		///     <list type="table">
		///         <item>
		///             <term>0</term>
		///             <description>NTM_ITALIC</description>
		///         </item>
		///         <item>
		///             <term>5</term>
		///             <description>NTM_BOLD</description>
		///         </item>
		///         <item>
		///             <term>8</term>
		///             <description>NTM_REGULAR</description>
		///         </item>
		///         <item>
		///             <term>16</term>
		///             <description>NTM_NONNEGATIVE_AC</description>
		///         </item>
		///         <item>
		///             <term>17</term>
		///             <description>NTM_PS_OPENTYPE</description>
		///         </item>
		///         <item>
		///             <term>18</term>
		///             <description>NTM_TT_OPENTYPE</description>
		///         </item>
		///         <item>
		///             <term>19</term>
		///             <description>NTM_MULTIPLEMASTER</description>
		///         </item>
		///         <item>
		///             <term>20</term>
		///             <description>NTM_TYPE1</description>
		///         </item>
		///         <item>
		///             <term>21</term>
		///             <description>NTM_DSIG</description>
		///         </item>
		///     </list>
		/// </summary>
		public uint ntmFlags;

		/// <summary>The size of the em square for the font. This value is in notional units (that is, the units for which the font was designed).</summary>
		public uint ntmSizeEM;

		/// <summary>
		///     The height, in notional units, of the font. This value should be compared with the value of the <see cref="ntmSizeEM" /> member.
		/// </summary>
		public uint ntmCellHeight;

		/// <summary>
		///     The average width of characters in the font, in notional units. This value should be compared with the value of the <see cref="ntmSizeEM" />
		///     member.
		/// </summary>
		public uint ntmAvgWidth;
	}

	/// <summary>
	///     The <see cref="TTPOLYCURVE" /> structure contains information about a curve in the outline of a TrueType character.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct TTPOLYCURVE
	{
		/// <summary>
		///     <para>The type of curve described by the structure. This member can be one of the following values.</para>
		///     <list type="table">
		///         <item>
		///             <term>TT_PRIM_LINE</term>
		///             <description>Curve is a polyline.</description>
		///         </item>
		///         <item>
		///             <term>TT_PRIM_QSPLINE</term>
		///             <description>Curve is a quadratic Bézier spline.</description>
		///         </item>
		///         <item>
		///             <term>TT_PRIM_CSPLINE</term>
		///             <description>Curve is a cubic Bézier spline.</description>
		///         </item>
		///     </list>
		/// </summary>
		public ushort wType;

		/// <summary>
		///     The number of <see cref="POINTFX" /> structures in the array.
		/// </summary>
		public ushort cpfx;

		/// <summary>
		///     Specifies an array of <see cref="POINTFX" /> structures that define the polyline or Bézier spline.
		/// </summary>
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.Struct)]
		public POINTFX[] apfx;
	}

	/// <summary>
	///     The <see cref="TTPOLYGONHEADER" /> structure specifies the starting position and type of a contour in a TrueType character outline.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct TTPOLYGONHEADER
	{
		/// <summary>
		///     The number of bytes required by the <see cref="TTPOLYGONHEADER" /> structure and <see cref="TTPOLYCURVE" /> structure or structures required to
		///     describe the contour of the character.
		/// </summary>
		public uint cb;

		/// <summary>The type of character outline returned. Currently, this value must be TT_POLYGON_TYPE.</summary>
		public uint dwType;

		/// <summary>The starting point of the contour in the character outline.</summary>
		public POINTFX pfxStart;
	}

	/// <summary>
	///     The <see cref="POINTFX" /> structure contains the coordinates of points that describe the outline of a character in a TrueType font.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct POINTFX
	{
		/// <summary>The x-component of a point on the outline of a TrueType character.</summary>
		public FIXED x;

		/// <summary>The y-component of a point on the outline of a TrueType character.</summary>
		public FIXED y;
	}

	/// <summary>
	///     The <see cref="EXTLOGPEN" /> structure defines the pen style, width, and brush attributes for an extended pen. This structure is used by the
	///     <see cref="Gdi32.GetObject" /> function when it retrieves a description of a pen that was created when an application called the
	///     <see cref="Gdi32.ExtCreatePen" /> function.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct EXTLOGPEN
	{
		/// <summary>
		///     <para>
		///         A combination of pen type, style, end cap style, and join style. The values from each category can be retrieved by using a bitwise AND
		///         operator with the appropriate mask.
		///     </para>
		///     <para>
		///         The <see cref="elpPenStyle" /> member masked with PS_TYPE_MASK has one of the following pen type values.
		///     </para>
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
		///     <para>
		///         The <see cref="elpPenStyle" /> member masked with PS_STYLE_MASK has one of the following pen styles values:
		///     </para>
		///     <list type="table">
		///         <item>
		///             <term>PS_DASH</term>
		///             <description>The pen is dashed.</description>
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
		///             <term>PS_DOT</term>
		///             <description>The pen is dotted.</description>
		///         </item>
		///         <item>
		///             <term>PS_INSIDEFRAME</term>
		///             <description>
		///                 The pen is solid. When this pen is used in any GDI drawing function that takes a bounding rectangle, the dimensions of the figure are
		///                 shrunk so that it fits entirely in the bounding rectangle, taking into account the width of the pen. This applies only to
		///                 PS_GEOMETRIC pens.
		///             </description>
		///         </item>
		///         <item>
		///             <term>PS_NULL</term>
		///             <description>The pen is invisible.</description>
		///         </item>
		///         <item>
		///             <term>PS_SOLID</term>
		///             <description>The pen is solid.</description>
		///         </item>
		///         <item>
		///             <term>PS_USERSTYLE</term>
		///             <description>The pen uses a styling array supplied by the user.</description>
		///         </item>
		///     </list>
		///     <para>
		///         The following category applies only to PS_GEOMETRIC pens. The <see cref="elpPenStyle" /> member masked with PS_ENDCAP_MASK has one of the
		///         following end cap values.
		///     </para>
		///     <list type="table">
		///         <item>
		///             <term>PS_ENDCAP_FLAT</term>
		///             <description>Line end caps are flat.</description>
		///         </item>
		///         <item>
		///             <term>PS_ENDCAP_ROUND</term>
		///             <description>Line end caps are round.</description>
		///         </item>
		///         <item>
		///             <term>PS_ENDCAP_SQUARE</term>
		///             <description>Line end caps are square.</description>
		///         </item>
		///     </list>
		///     <para>
		///         The following category applies only to PS_GEOMETRIC pens. The <see cref="elpPenStyle" /> member masked with PS_JOIN_MASK has one of the
		///         following join values.
		///     </para>
		///     <list type="table">
		///         <item>
		///             <term>PS_JOIN_BEVEL</term>
		///             <description>Line joins are beveled.</description>
		///         </item>
		///         <item>
		///             <term>PS_JOIN_MITER</term>
		///             <description>
		///                 Line joins are mitered when they are within the current limit set by the <see cref="Gdi32.SetMiterLimit" /> function. A join is
		///                 beveled when it would exceed the limit.
		///             </description>
		///         </item>
		///         <item>
		///             <term>PS_JOIN_ROUND</term>
		///             <description>Line joins are round.</description>
		///         </item>
		///     </list>
		/// </summary>
		public uint elpPenStyle;

		/// <summary>
		///     The width of the pen. If the <see cref="elpPenStyle" /> member is PS_GEOMETRIC, this value is the width of the line in logical units. Otherwise,
		///     the lines are cosmetic and this value is 1, which indicates a line with a width of one pixel.
		/// </summary>
		public uint elpWidth;

		/// <summary>
		///     <para>
		///         The brush style of the pen. The <see cref="elpBrushStyle" /> member value can be one of the following.
		///     </para>
		///     <list type="table">
		///         <item>
		///             <term>BS_DIBPATTERN</term>
		///             <description>
		///                 Specifies a pattern brush defined by a DIB specification. If <see cref="elpBrushStyle" /> is BS_DIBPATTERN, the
		///                 <see cref="elpHatch" /> member contains a handle to a packed DIB. For more information, see discussion in <see cref="elpHatch" />
		///                 ///
		///             </description>
		///         </item>
		///         <item>
		///             <term>BS_DIBPATTERNPT</term>
		///             <description>
		///                 Specifies a pattern brush defined by a DIB specification. If <see cref="elpBrushStyle" /> is BS_DIBPATTERNPT, the
		///                 <see cref="elpHatch" /> member contains a pointer to a packed DIB. For more information, see discussion in <see cref="elpHatch" />.
		///                 ///
		///             </description>
		///         </item>
		///         <item>
		///             <term>BS_HATCHED</term>
		///             <description>Specifies a hatched brush.</description>
		///         </item>
		///         <item>
		///             <term>BS_HOLLOW</term>
		///             <description>Specifies a hollow or NULL brush.</description>
		///         </item>
		///         <item>
		///             <term>BS_PATTERN</term>
		///             <description>Specifies a pattern brush defined by a memory bitmap.</description>
		///         </item>
		///         <item>
		///             <term>BS_SOLID</term>
		///             <description>Specifies a solid brush.</description>
		///         </item>
		///     </list>
		/// </summary>
		public uint elpBrushStyle;

		/// <summary>
		///     <para>
		///         If <see cref="elpBrushStyle" /> is BS_SOLID or BS_HATCHED, <see cref="elpColor" /> specifies the color in which the pen is to be drawn. For
		///         BS_HATCHED, the <see cref="Gdi32.SetBkMode" /> and <see cref="Gdi32.SetBkColor" /> functions determine the background color.
		///     </para>
		///     <para>
		///         If <see cref="elpBrushStyle" /> is BS_HOLLOW or BS_PATTERN, <see cref="elpColor" /> is ignored.
		///     </para>
		///     <para>
		///         If <see cref="elpBrushStyle" /> is BS_DIBPATTERN or BS_DIBPATTERNPT, the low-order word of <see cref="elpColor" /> specifies whether the
		///         <see cref="BITMAPINFO.bmiColors" /> member of the <see cref="BITMAPINFO" /> structure contain explicit RGB values or indices into the
		///         currently realized logical palette. The <see cref="elpColor" /> value must be one of the following.
		///     </para>
		///     <list type="table">
		///         <item>
		///             <term>DIB_PAL_COLORS</term>
		///             <description>The color table consists of an array of 16-bit indices into the currently realized logical palette.</description>
		///         </item>
		///         <item>
		///             <term>DIB_RGB_COLORS</term>
		///             <description>The color table contains literal RGB values.</description>
		///         </item>
		///     </list>
		///     <para>
		///         The RGB macro is used to generate a <see cref="COLORREF" /> structure.
		///     </para>
		/// </summary>
		public uint elpColor;

		/// <summary>
		///     <para>
		///         If <see cref="elpBrushStyle" /> is BS_PATTERN, <see cref="elpHatch" /> is a handle to the bitmap that defines the pattern.
		///     </para>
		///     <para>
		///         If <see cref="elpBrushStyle" /> is BS_SOLID or BS_HOLLOW, <see cref="elpHatch" /> is ignored.
		///     </para>
		///     <para>
		///         If <see cref="elpBrushStyle" /> is BS_DIBPATTERN, the <see cref="elpHatch" /> member is a handle to a packed DIB. To obtain this handle, an
		///         application calls the GlobalAlloc function with GMEM_MOVEABLE (or LocalAlloc with LMEM_MOVEABLE) to allocate a block of memory and then fills
		///         the memory with the packed DIB. A packed DIB consists of a <see cref="BITMAPINFO" /> structure immediately followed by the array of bytes
		///         that define the pixels of the bitmap.
		///     </para>
		///     <para>
		///         If <see cref="elpBrushStyle" /> is BS_DIBPATTERNPT, the <see cref="elpHatch" /> member is a pointer to a packed DIB. The pointer derives from
		///         the memory block created by LocalAlloc with LMEM_FIXED set or by GlobalAlloc with GMEM_FIXED set, or it is the pointer returned by a call
		///         like LocalLock (handle_to_the_dib). A packed DIB consists of a <see cref="BITMAPINFO" /> structure immediately followed by the array of bytes
		///         that define the pixels of the bitmap.
		///     </para>
		///     <para>
		///         If <see cref="elpBrushStyle" /> is BS_HATCHED, the <see cref="elpHatch" /> member specifies the orientation of the lines used to create the
		///         hatch. It can be one of the following values.
		///     </para>
		///     <list type="table">
		///         <item>
		///             <term>HS_BDIAGONAL</term>
		///             <description>45-degree upward hatch (left to right)</description>
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
		///             <description>45-degree downward hatch (left to right)</description>
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
		/// </summary>
		public uint elpHatch;

		/// <summary>
		///     The number of entries in the style array in the <see cref="elpStyleEntry" /> member. This value is zero if <see cref="elpPenStyle" /> does not
		///     specify PS_USERSTYLE.
		/// </summary>
		public uint elpNumEntries;

		/// <summary>
		///     <para>
		///         A user-supplied style array. The array is specified with a finite length, but it is used as if it repeated indefinitely. The first entry in
		///         the array specifies the length of the first dash. The second entry specifies the length of the first gap. Thereafter, lengths of dashes and
		///         gaps alternate.
		///     </para>
		///     <para>
		///         If <see cref="elpWidth" /> specifies geometric lines, the lengths are in logical units. Otherwise, the lines are cosmetic and lengths are in
		///         device units.
		///     </para>
		/// </summary>
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.U4)]
		public uint[] elpStyleEntry;
	}

	/// <summary>
	///     The <see cref="BITMAPV5HEADER" /> structure is the bitmap information header file. It is an extended version of the
	///     <see cref="BITMAPINFOHEADER" /> structure.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct BITMAPV5HEADER
	{
		/// <summary>
		///     The number of bytes required by the structure. Applications should use this member to determine which bitmap information header structure is
		///     being used.
		/// </summary>
		public uint bV5Size;

		/// <summary>
		///     <para>The width of the bitmap, in pixels.</para>
		///     <para>
		///         If <see cref="bV5Compression" /> is BI_JPEG or BI_PNG, the <see cref="bV5Width" /> member specifies the width of the decompressed JPEG or PNG
		///         image in pixels.
		///     </para>
		/// </summary>
		public int bV5Width;

		/// <summary>
		///     <para>
		///         The height of the bitmap, in pixels. If the value of <see cref="bV5Height" /> is positive, the bitmap is a bottom-up DIB and its origin is
		///         the lower-left corner. If <see cref="bV5Height" /> value is negative, the bitmap is a top-down DIB and its origin is the upper-left corner.
		///     </para>
		///     <para>
		///         If <see cref="bV5Height" /> is negative, indicating a top-down DIB, <see cref="bV5Compression" /> must be either BI_RGB or BI_BITFIELDS.
		///         Top-down DIBs cannot be compressed.
		///     </para>
		///     <para>
		///         If <see cref="bV5Compression" /> is BI_JPEG or BI_PNG, the <see cref="bV5Height" /> member specifies the height of the decompressed JPEG or
		///         PNG image in pixels.
		///     </para>
		/// </summary>
		public int bV5Height;

		/// <summary>The number of planes for the target device. This value must be set to 1.</summary>
		public ushort bV5Planes;

		/// <summary>
		///     <para>The number of bits that define each pixel and the maximum number of colors in the bitmap.</para>
		///     <para>This member can be one of the following values.</para>
		///     <list type="table">
		///         <item>
		///             <term>0</term>
		///             <description>The number of bits per pixel is specified or is implied by the JPEG or PNG file format.</description>
		///         </item>
		///         <item>
		///             <term>1</term>
		///             <description>
		///                 The bitmap is monochrome, and the <see cref="BITMAPINFO.bmiColors" /> member of <see cref="BITMAPINFO" /> contains two entries. Each
		///                 bit in the bitmap array represents a pixel. If the bit is clear, the pixel is displayed with the color of the first entry in the
		///                 <see cref="BITMAPINFO.bmiColors" /> color table. If the bit is set, the pixel has the color of the second entry in the table.		///
		///             </description>
		///         </item>
		///         <item>
		///             <term>4</term>
		///             <description>
		///                 The bitmap has a maximum of 16 colors, and the <see cref="BITMAPINFO.bmiColors" /> member of <see cref="BITMAPINFO" /> contains up to
		///                 16 entries. Each pixel in the bitmap is represented by a 4-bit index into the color table. For example, if the first byte in the
		///                 bitmap is 0x1F, the byte represents two pixels. The first pixel contains the color in the second table entry, and the second pixel
		///                 contains the color in the sixteenth table entry.		///
		///             </description>
		///         </item>
		///         <item>
		///             <term>8</term>
		///             <description>
		///                 The bitmap has a maximum of 256 colors, and the <see cref="BITMAPINFO.bmiColors" /> member of <see cref="BITMAPINFO" /> contains up
		///                 to 256 entries. In this case, each byte in the array represents a single pixel.		///
		///             </description>
		///         </item>
		///         <item>
		///             <term>16</term>
		///             <description>
		///                 <para>
		///                     If the <see cref="bV5Compression" /> member of the <see cref="BITMAPV5HEADER" /> is BI_BITFIELDS, the
		///                     <see cref="BITMAPINFO.bmiColors" />
		///                     member contains three DWORD color masks that specify the red, green, and blue components, respectively, of each pixel. Each WORD
		///                     in the bitmap array represents a single pixel.
		///                 </para>
		///                 <para>
		///                     When the <see cref="bV5Compression" /> member is BI_BITFIELDS, bits set in each DWORD mask must be contiguous and should not
		///                     overlap the bits of another mask. All the bits in the pixel do not need to be used.
		///                 </para>
		///             </description>
		///         </item>
		///         <item>
		///             <term>24</term>
		///             <description>
		///                 The bitmap has a maximum of 2^24 colors, and the <see cref="BITMAPINFO.bmiColors" /> member of <see cref="BITMAPINFO" /> is NULL.
		///                 Each 3-byte triplet in the bitmap array represents the relative intensities of blue, green, and red, respectively, for a pixel. The
		///                 <see cref="BITMAPINFO.bmiColors" /> color table is used for optimizing colors used on palette-based devices, and must contain the
		///                 number of entries specified by the <see cref="bV5ClrUsed" /> member of the <see cref="BITMAPV5HEADER" /> structure.		///
		///             </description>
		///         </item>
		///         <item>
		///             <term>32</term>
		///             <description>
		///                 <para>
		///                     If the <see cref="bV5Compression" /> member of the <see cref="BITMAPV5HEADER" /> is BI_BITFIELDS, the
		///                     <see cref="BITMAPINFO.bmiColors" />
		///                     member contains three DWORD color masks that specify the red, green, and blue components of each pixel. Each DWORD in the bitmap
		///                     array represents a single pixel.
		///                 </para>
		///             </description>
		///         </item>
		///     </list>
		/// </summary>
		public ushort bV5BitCount;

		/// <summary>
		///     <para>
		///         Specifies that the bitmap is not compressed. The <see cref="bV5RedMask" />, <see cref="bV5GreenMask" />, and <see cref="bV5BlueMask" />
		///         members specify the red, green, and blue components of each pixel. This is valid when used with 16- and 32-bpp bitmaps. This member can be
		///         one of the following values.
		///     </para>
		///     <list type="table">
		///         <item>
		///             <term>BI_RGB</term>
		///             <description>An uncompressed format.</description>
		///         </item>
		///         <item>
		///             <term>BI_RLE8</term>
		///             <description>
		///                 A run-length encoded (RLE) format for bitmaps with 8 bpp. The compression format is a two-byte format consisting of a count byte
		///                 followed by a byte containing a color index. If <see cref="bV5Compression" /> is BI_RGB and the <see cref="bV5BitCount" /> member is
		///                 16, 24, or 32, the bitmap array specifies the actual intensities of blue, green, and red rather than using color table indexes. For
		///                 more information, see Bitmap Compression.		///
		///             </description>
		///         </item>
		///         <item>
		///             <term>BI_RLE4</term>
		///             <description>
		///                 An RLE format for bitmaps with 4 bpp. The compression format is a two-byte format consisting of a count byte followed by two
		///                 word-length color indexes. For more information, see Bitmap Compression.
		///             </description>
		///         </item>
		///         <item>
		///             <term>BI_BITFIELDS</term>
		///             <description>
		///                 Specifies that the bitmap is not compressed and that the color masks for the red, green, and blue components of each pixel are
		///                 specified in the <see cref="bV5RedMask" />, <see cref="bV5GreenMask" />, and <see cref="bV5BlueMask" /> members. This is valid when
		///                 used with 16- and 32-bpp bitmaps.		///
		///             </description>
		///         </item>
		///         <item>
		///             <term>BI_JPEG</term>
		///             <description>
		///                 Specifies that the image is compressed using the JPEG file Interchange Format. JPEG compression trades off compression against loss;
		///                 it can achieve a compression ratio of 20:1 with little noticeable loss.
		///             </description>
		///         </item>
		///         <item>
		///             <term>BI_PNG</term>
		///             <description>Specifies that the image is compressed using the PNG file Interchange Format.</description>
		///         </item>
		///     </list>
		/// </summary>
		public uint bV5Compression;

		/// <summary>
		///     <para>The size, in bytes, of the image. This may be set to zero for BI_RGB bitmaps.</para>
		///     <para>
		///         If <see cref="bV5Compression" /> is BI_JPEG or BI_PNG, <see cref="bV5SizeImage" /> is the size of the JPEG or PNG image buffer.
		///     </para>
		/// </summary>
		public uint bV5SizeImage;

		/// <summary>
		///     The horizontal resolution, in pixels-per-meter, of the target device for the bitmap. An application can use this value to select a bitmap from a
		///     resource group that best matches the characteristics of the current device.
		/// </summary>
		public int bV5XPelsPerMeter;

		/// <summary>The vertical resolution, in pixels-per-meter, of the target device for the bitmap.</summary>
		public int bV5YPelsPerMeter;

		/// <summary>
		///     <para>
		///         The number of color indexes in the color table that are actually used by the bitmap. If this value is zero, the bitmap uses the maximum
		///         number of colors corresponding to the value of the <see cref="bV5BitCount" /> member for the compression mode specified by
		///         <see cref="bV5Compression" />.
		///     </para>
		///     <para>
		///         If <see cref="bV5ClrUsed" /> is nonzero and <see cref="bV5BitCount" /> is less than 16, the <see cref="bV5ClrUsed" /> member specifies the
		///         actual number of colors the graphics engine or device driver accesses. If <see cref="bV5BitCount" /> is 16 or greater, the
		///         <see cref="bV5ClrUsed" /> member specifies the size of the color table used to optimize performance of the system color palettes. If
		///         <see cref="bV5BitCount" /> equals 16 or 32, the optimal color palette starts immediately following the <see cref="BITMAPV5HEADER" />. If
		///         <see cref="bV5ClrUsed" /> is nonzero, the color table is used on palettized devices, and <see cref="bV5ClrUsed" /> specifies the number of
		///         entries.
		///     </para>
		/// </summary>
		public uint bV5ClrUsed;

		/// <summary>The number of color indexes that are required for displaying the bitmap. If this value is zero, all colors are required.</summary>
		public uint bV5ClrImportant;

		/// <summary>
		///     Color mask that specifies the red component of each pixel, valid only if <see cref="bV5Compression" /> is set to BI_BITFIELDS.
		/// </summary>
		public uint bV5RedMask;

		/// <summary>
		///     Color mask that specifies the green component of each pixel, valid only if <see cref="bV5Compression" /> is set to BI_BITFIELDS.
		/// </summary>
		public uint bV5GreenMask;

		/// <summary>
		///     Color mask that specifies the blue component of each pixel, valid only if <see cref="bV5Compression" /> is set to BI_BITFIELDS.
		/// </summary>
		public uint bV5BlueMask;

		/// <summary>Color mask that specifies the alpha component of each pixel.</summary>
		public uint bV5AlphaMask;

		/// <summary>
		///     <para>The color space of the DIB.</para>
		///     <para>
		///         The following table specifies the values for <see cref="bV5CSType" />.
		///     </para>
		///     <list type="table">
		///         <item>
		///             <term>LCS_CALIBRATED_RGB</term>
		///             <description>This value implies that endpoints and gamma values are given in the appropriate fields.</description>
		///         </item>
		///         <item>
		///             <term>LCS_sRGB</term>
		///             <description>Specifies that the bitmap is in sRGB color space.</description>
		///         </item>
		///         <item>
		///             <term>LCS_WINDOWS_COLOR_SPACE</term>
		///             <description>This value indicates that the bitmap is in the system default color space, sRGB.</description>
		///         </item>
		///         <item>
		///             <term>PROFILE_LINKED</term>
		///             <description>
		///                 This value indicates that <see cref="bV5ProfileData" /> points to the file name of the profile to use (gamma and endpoints values are
		///                 ignored).
		///             </description>
		///         </item>
		///         <item>
		///             <term>PROFILE_EMBEDDED</term>
		///             <description>
		///                 This value indicates that <see cref="bV5ProfileData" /> points to a memory buffer that contains the profile to be used (gamma and
		///                 endpoints values are ignored).
		///             </description>
		///         </item>
		///     </list>
		///     <para>
		///         See the <see cref="LOGCOLORSPACE" /> structure for information that defines a logical color space.
		///     </para>
		/// </summary>
		public uint bV5CSType;

		/// <summary>
		///     A <see cref="CIEXYZTRIPLE" /> structure that specifies the x, y, and z coordinates of the three colors that correspond to the red, green, and
		///     blue endpoints for the logical color space associated with the bitmap. This member is ignored unless the <see cref="bV5CSType" /> member
		///     specifies LCS_CALIBRATED_RGB.
		/// </summary>
		public CIEXYZTRIPLE bV5Endpoints;

		/// <summary>
		///     Toned response curve for red. Used if <see cref="bV5CSType" /> is set to LCS_CALIBRATED_RGB. Specify in unsigned fixed 16.16 format. The upper 16
		///     bits are the unsigned integer value. The lower 16 bits are the fractional part.
		/// </summary>
		public uint bV5GammaRed;

		/// <summary>
		///     Toned response curve for green. Used if <see cref="bV5CSType" /> is set to LCS_CALIBRATED_RGB. Specify in unsigned fixed 16.16 format. The upper
		///     16 bits are the unsigned integer value. The lower 16 bits are the fractional part.
		/// </summary>
		public uint bV5GammaGreen;

		/// <summary>
		///     Toned response curve for blue. Used if <see cref="bV5CSType" /> is set to LCS_CALIBRATED_RGB. Specify in unsigned fixed 16.16 format. The upper
		///     16 bits are the unsigned integer value. The lower 16 bits are the fractional part.
		/// </summary>
		public uint bV5GammaBlue;

		/// <summary>
		///     <para>Rendering intent for bitmap. This can be one of the following values.</para>
		///     <list type="table">
		///         <item>
		///             <term>LCS_GM_ABS_COLORIMETRIC</term>
		///             <description>Match</description>
		///         </item>
		///         <item>
		///             <term>LCS_GM_BUSINESS</term>
		///             <description>Graphic</description>
		///         </item>
		///         <item>
		///             <term>LCS_GM_GRAPHICS</term>
		///             <description>Proof</description>
		///         </item>
		///         <item>
		///             <term>LCS_GM_IMAGES</term>
		///             <description>Picture</description>
		///         </item>
		///     </list>
		/// </summary>
		public uint bV5Intent;

		/// <summary>
		///     The offset, in bytes, from the beginning of the <see cref="BITMAPV5HEADER" /> structure to the start of the profile data. If the profile is
		///     embedded, profile data is the actual profile, and it is linked. (The profile data is the null-terminated file name of the profile.) This cannot
		///     be a Unicode string. It must be composed exclusively of characters from the Windows character set (code page 1252). These profile members are
		///     ignored unless the <see cref="bV5CSType" /> member specifies PROFILE_LINKED or PROFILE_EMBEDDED.
		/// </summary>
		public uint bV5ProfileData;

		/// <summary>Size, in bytes, of embedded profile data.</summary>
		public uint bV5ProfileSize;

		/// <summary>This member has been reserved. Its value should be set to zero.</summary>
		public uint bV5Reserved;
	}

	/// <summary>
	///     <para>
	///         The <see cref="BITMAPV4HEADER" /> structure is the bitmap information header file. It is an extended version of the
	///         <see cref="BITMAPINFOHEADER" /> structure.
	///     </para>
	///     <para>
	///         Applications can use the <see cref="BITMAPV5HEADER" /> structure for added functionality.
	///     </para>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct BITMAPV4HEADER
	{
		/// <summary>
		///     The number of bytes required by the structure. Applications should use this member to determine which bitmap information header structure is
		///     being used.
		/// </summary>
		public uint bV4Size;

		/// <summary>
		///     <para>The width of the bitmap, in pixels.</para>
		///     <para>
		///         If <see cref="bV4Compression" /> is BI_JPEG or BI_PNG, <see cref="bV4Width" /> specifies the width of the JPEG or PNG image in pixels.
		///     </para>
		/// </summary>
		public int bV4Width;

		/// <summary>
		///     <para>
		///         The height of the bitmap, in pixels. If <see cref="bV4Height" /> is positive, the bitmap is a bottom-up DIB and its origin is the lower-left
		///         corner. If <see cref="bV4Height" /> is negative, the bitmap is a top-down DIB and its origin is the upper-left corner.
		///     </para>
		///     <para>
		///         If <see cref="bV4Height" /> is negative, indicating a top-down DIB, <see cref="bV4Compression" /> must be either BI_RGB or BI_BITFIELDS.
		///         Top-down DIBs cannot be compressed.
		///     </para>
		///     <para>
		///         If <see cref="bV4Compression" /> is BI_JPEG or BI_PNG, <see cref="bV4Height" /> specifies the height of the JPEG or PNG image in pixels.
		///     </para>
		/// </summary>
		public int bV4Height;

		/// <summary>The number of planes for the target device. This value must be set to 1.</summary>
		public ushort bV4Planes;

		/// <summary>
		///     <para>
		///         The number of bits-per-pixel. The <see cref="bV4BitCount" /> member of the <see cref="BITMAPV4HEADER" /> structure determines the number of
		///         bits that define each pixel and the maximum number of colors in the bitmap. This member must be one of the following values.
		///     </para>
		///     <list type="table">
		///         <item>
		///             <term>0</term>
		///             <description>The number of bits-per-pixel is specified or is implied by the JPEG or PNG file format.</description>
		///         </item>
		///         <item>
		///             <term>1</term>
		///             <description>
		///                 The bitmap is monochrome, and the <see cref="BITMAPINFO.bmiColors" /> member of <see cref="BITMAPINFO" /> contains two entries. Each
		///                 bit in the bitmap array represents a pixel. If the bit is clear, the pixel is displayed with the color of the first entry in the
		///                 <see cref="BITMAPINFO.bmiColors" /> table; if the bit is set, the pixel has the color of the second entry in the table.		///
		///             </description>
		///         </item>
		///         <item>
		///             <term>4</term>
		///             <description>
		///                 The bitmap has a maximum of 16 colors, and the <see cref="BITMAPINFO.bmiColors" /> member of <see cref="BITMAPINFO" /> contains up to
		///                 16 entries. Each pixel in the bitmap is represented by a 4-bit index into the color table. For example, if the first byte in the
		///                 bitmap is 0x1F, the byte represents two pixels. The first pixel contains the color in the second table entry, and the second pixel
		///                 contains the color in the sixteenth table entry.		///
		///             </description>
		///         </item>
		///         <item>
		///             <term>8</term>
		///             <description>
		///                 The bitmap has a maximum of 256 colors, and the <see cref="BITMAPINFO.bmiColors" /> member of <see cref="BITMAPINFO" /> contains up
		///                 to 256 entries. In this case, each byte in the array represents a single pixel.		///
		///             </description>
		///         </item>
		///         <item>
		///             <term>16</term>
		///             <description>
		///                 <para>
		///                     If the <see cref="bV4Compression" /> member of the <see cref="BITMAPV4HEADER" /> is BI_BITFIELDS, the
		///                     <see cref="BITMAPINFO.bmiColors" />
		///                     member contains three DWORD color masks that specify the red, green, and blue components of each pixel. Each WORD in the bitmap
		///                     array represents a single pixel.
		///                 </para>
		///             </description>
		///         </item>
		///         <item>
		///             <term>24</term>
		///             <description>
		///                 The bitmap has a maximum of 2^24 colors, and the <see cref="BITMAPINFO.bmiColors" /> member of <see cref="BITMAPINFO" /> is NULL.
		///                 Each 3-byte triplet in the bitmap array represents the relative intensities of blue, green, and red for a pixel. The
		///                 <see cref="BITMAPINFO.bmiColors" />
		///                 color table is used for optimizing colors used on palette-based devices, and must contain the number of entries specified by the
		///                 <see cref="bV4ClrUsed" /> member of the <see cref="BITMAPV4HEADER" />.		///
		///             </description>
		///         </item>
		///         <item>
		///             <term>32</term>
		///             <description>
		///                 <para>
		///                     If the <see cref="bV4Compression" /> member of the <see cref="BITMAPV4HEADER" /> is BI_BITFIELDS, the
		///                     <see cref="BITMAPINFO.bmiColors" />
		///                     member contains three DWORD color masks that specify the red, green, and blue components of each pixel. Each DWORD in the bitmap
		///                     array represents a single pixel.
		///                 </para>
		///             </description>
		///         </item>
		///     </list>
		/// </summary>
		public ushort bV4BitCount;

		/// <summary>
		///     <para>
		///         The type of compression for a compressed bottom-up bitmap (top-down DIBs cannot be compressed). This member can be one of the following
		///         values.
		///     </para>
		///     <list type="table">
		///         <item>
		///             <term>BI_RGB</term>
		///             <description>An uncompressed format.</description>
		///         </item>
		///         <item>
		///             <term>BI_RLE8</term>
		///             <description>
		///                 A run-length encoded (RLE) format for bitmaps with 8 bpp. The compression format is a 2-byte format consisting of a count byte
		///                 followed by a byte containing a color index. For more information, see Bitmap Compression.
		///             </description>
		///         </item>
		///         <item>
		///             <term>BI_RLE4</term>
		///             <description>
		///                 An RLE format for bitmaps with 4 bpp. The compression format is a 2-byte format consisting of a count byte followed by two
		///                 word-length color indexes. For more information, see Bitmap Compression.
		///             </description>
		///         </item>
		///         <item>
		///             <term>BI_BITFIELDS</term>
		///             <description>
		///                 Specifies that the bitmap is not compressed. The members <see cref="bV4RedMask" />, <see cref="bV4GreenMask" />, and
		///                 <see cref="bV4BlueMask" /> specify the red, green, and blue components for each pixel. This is valid when used with 16- and 32-bpp
		///                 bitmaps.		///
		///             </description>
		///         </item>
		///         <item>
		///             <term>BI_JPEG</term>
		///             <description>
		///                 Specifies that the image is compressed using the JPEG file interchange format. JPEG compression trades off compression against loss;
		///                 it can achieve a compression ratio of 20:1 with little noticeable loss.
		///             </description>
		///         </item>
		///         <item>
		///             <term>BI_PNG</term>
		///             <description>Specifies that the image is compressed using the PNG file interchange format.</description>
		///         </item>
		///     </list>
		/// </summary>
		public uint bV4Compression;

		/// <summary>
		///     <para>The size, in bytes, of the image. This may be set to zero for BI_RGB bitmaps.</para>
		///     <para>
		///         If <see cref="bV4Compression" /> is BI_JPEG or BI_PNG, <see cref="bV4SizeImage" /> is the size of the JPEG or PNG image buffer.
		///     </para>
		/// </summary>
		public uint bV4SizeImage;

		/// <summary>
		///     The horizontal resolution, in pixels-per-meter, of the target device for the bitmap. An application can use this value to select a bitmap from a
		///     resource group that best matches the characteristics of the current device.
		/// </summary>
		public int bV4XPelsPerMeter;

		/// <summary>The vertical resolution, in pixels-per-meter, of the target device for the bitmap.</summary>
		public int bV4YPelsPerMeter;

		/// <summary>
		///     <para>
		///         The number of color indexes in the color table that are actually used by the bitmap. If this value is zero, the bitmap uses the maximum
		///         number of colors corresponding to the value of the <see cref="bV4BitCount" /> member for the compression mode specified by
		///         <see cref="bV4Compression" />.
		///     </para>
		///     <para>
		///         If <see cref="bV4ClrUsed" /> is nonzero and the <see cref="bV4BitCount" /> member is less than 16, the <see cref="bV4ClrUsed" /> member
		///         specifies the actual number of colors the graphics engine or device driver accesses. If <see cref="bV4BitCount" /> is 16 or greater, the
		///         <see cref="bV4ClrUsed" /> member specifies the size of the color table used to optimize performance of the system color palettes. If
		///         <see cref="bV4BitCount" /> equals 16 or 32, the optimal color palette starts immediately following the <see cref="BITMAPV4HEADER" />.
		///     </para>
		/// </summary>
		public uint bV4ClrUsed;

		/// <summary>The number of color indexes that are required for displaying the bitmap. If this value is zero, all colors are important.</summary>
		public uint bV4ClrImportant;

		/// <summary>
		///     Color mask that specifies the red component of each pixel, valid only if <see cref="bV4Compression" /> is set to BI_BITFIELDS.
		/// </summary>
		public uint bV4RedMask;

		/// <summary>
		///     Color mask that specifies the green component of each pixel, valid only if <see cref="bV4Compression" /> is set to BI_BITFIELDS.
		/// </summary>
		public uint bV4GreenMask;

		/// <summary>
		///     Color mask that specifies the blue component of each pixel, valid only if <see cref="bV4Compression" /> is set to BI_BITFIELDS.
		/// </summary>
		public uint bV4BlueMask;

		/// <summary>Color mask that specifies the alpha component of each pixel.</summary>
		public uint bV4AlphaMask;

		/// <summary>
		///     <para>
		///         The color space of the DIB. The following table lists the value for <see cref="bV4CSType" />.
		///     </para>
		///     <list type="table">
		///         <item>
		///             <term>LCS_CALIBRATED_RGB</term>
		///             <description>This value indicates that endpoints and gamma values are given in the appropriate fields.</description>
		///         </item>
		///     </list>
		///     <para>
		///         See the <see cref="LOGCOLORSPACE" /> structure for information that defines a logical color space.
		///     </para>
		/// </summary>
		public uint bV4CSType;

		/// <summary>
		///     <para>
		///         A <see cref="CIEXYZTRIPLE" /> structure that specifies the x, y, and z coordinates of the three colors that correspond to the red, green, and
		///         blue endpoints for the logical color space associated with the bitmap. This member is ignored unless the <see cref="bV4CSType" /> member
		///         specifies LCS_CALIBRATED_RGB.
		///     </para>
		///     <para>
		///         Note  A color space is a model for representing color numerically in terms of three or more coordinates. For example, the RGB color space
		///         represents colors in terms of the red, green, and blue coordinates.
		///     </para>
		/// </summary>
		public CIEXYZTRIPLE bV4Endpoints;

		/// <summary>
		///     Tone response curve for red. This member is ignored unless color values are calibrated RGB values and <see cref="bV4CSType" /> is set to
		///     LCS_CALIBRATED_RGB. Specify in unsigned fixed 16.16 format. The upper 16 bits are the unsigned integer value. The lower 16 bits are the
		///     fractional part.
		/// </summary>
		public uint bV4GammaRed;

		/// <summary>
		///     Tone response curve for green. Used if <see cref="bV4CSType" /> is set to LCS_CALIBRATED_RGB. Specify in unsigned fixed 16.16 format. The upper
		///     16 bits are the unsigned integer value. The lower 16 bits are the fractional part.
		/// </summary>
		public uint bV4GammaGreen;

		/// <summary>
		///     Tone response curve for blue. Used if <see cref="bV4CSType" /> is set to LCS_CALIBRATED_RGB. Specify in unsigned fixed 16.16 format. The upper 16
		///     bits are the unsigned integer value. The lower 16 bits are the fractional part.
		/// </summary>
		public uint bV4GammaBlue;
	}

	/// <summary>
	///     <para></para>
	///     <para>
	///         The <see cref="PIXELFORMATDESCRIPTOR" /> structure describes the pixel format of a drawing surface.
	///     </para>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct PIXELFORMATDESCRIPTOR
	{
		/// <summary>
		///     Specifies the size of this data structure. This value should be set to sizeof(<see cref="PIXELFORMATDESCRIPTOR" />).
		/// </summary>
		public ushort nSize;

		/// <summary>Specifies the version of this data structure. This value should be set to 1.</summary>
		public ushort nVersion;

		/// <summary>
		///     <para>
		///         A set of bit flags that specify properties of the pixel buffer. The properties are generally not mutually exclusive; you can set any
		///         combination of bit flags, with the exceptions noted. The following bit flag constants are defined.
		///     </para>
		///     <list type="table">
		///         <item>
		///             <term>PFD_DRAW_TO_WINDOW</term>
		///             <description>The buffer can draw to a window or device surface.</description>
		///         </item>
		///         <item>
		///             <term>PFD_DRAW_TO_BITMAP</term>
		///             <description>The buffer can draw to a memory bitmap.</description>
		///         </item>
		///         <item>
		///             <term>PFD_SUPPORT_GDI</term>
		///             <description>
		///                 The buffer supports GDI drawing. This flag and PFD_DOUBLEBUFFER are mutually exclusive in the current generic
		///                 implementation.
		///             </description>
		///         </item>
		///         <item>
		///             <term>PFD_SUPPORT_OPENGL</term>
		///             <description>The buffer supports OpenGL drawing.</description>
		///         </item>
		///         <item>
		///             <term>PFD_GENERIC_ACCELERATED</term>
		///             <description>
		///                 The pixel format is supported by a device driver that accelerates the generic implementation. If this flag is clear and the
		///                 PFD_GENERIC_FORMAT flag is set, the pixel format is supported by the generic implementation only.
		///             </description>
		///         </item>
		///         <item>
		///             <term>PFD_GENERIC_FORMAT</term>
		///             <description>
		///                 The pixel format is supported by the GDI software implementation, which is also known as the generic implementation. If this bit is
		///                 clear, the pixel format is supported by a device driver or hardware.
		///             </description>
		///         </item>
		///         <item>
		///             <term>PFD_NEED_PALETTE</term>
		///             <description>
		///                 The buffer uses RGBA pixels on a palette-managed device. A logical palette is required to achieve the best results for this pixel
		///                 type. Colors in the palette should be specified according to the values of the <see cref="cRedBits" />, <see cref="cRedShift" />,
		///                 <see cref="cGreenBits" />, <see cref="cGreenShift" />, <see cref="cBlueBits" />, and <see cref="cBlueShift" /> members. The palette
		///                 should be created and realized in the device context before calling wglMakeCurrent.
		///             </description>
		///         </item>
		///         <item>
		///             <term>PFD_NEED_SYSTEM_PALETTE</term>
		///             <description>
		///                 <para>
		///                     When this flag is set, you must call <see cref="Gdi32.SetSystemPaletteUse" /> in your program to force a one-to-one mapping of
		///                     the logical palette and the system palette. If your OpenGL hardware supports multiple hardware palettes and the device driver can
		///                     allocate spare hardware palettes for OpenGL, this flag is typically clear.
		///                 </para>
		///                 <para>This flag is not set in the generic pixel formats.</para>
		///             </description>
		///         </item>
		///         <item>
		///             <term>PFD_DOUBLEBUFFER</term>
		///             <description>The buffer is double-buffered. This flag and PFD_SUPPORT_GDI are mutually exclusive in the current generic implementation.</description>
		///         </item>
		///         <item>
		///             <term>PFD_STEREO</term>
		///             <description>The buffer is stereoscopic. This flag is not supported in the current generic implementation.</description>
		///         </item>
		///         <item>
		///             <term>PFD_SWAP_LAYER_BUFFERS</term>
		///             <description>
		///                 Indicates whether a device can swap individual layer planes with pixel formats that include double-buffered overlay or underlay
		///                 planes. Otherwise all layer planes are swapped together as a group. When this flag is set, wglSwapLayerBuffers is supported.
		///             </description>
		///         </item>
		///     </list>
		///     <para>
		///         You can specify the following bit flags when calling <see cref="Gdi32.ChoosePixelFormat" />.
		///     </para>
		///     <list type="table">
		///         <item>
		///             <term>PFD_DEPTH_DONTCARE</term>
		///             <description>
		///                 The requested pixel format can either have or not have a depth buffer. To select a pixel format without a depth buffer, you must
		///                 specify this flag. The requested pixel format can be with or without a depth buffer. Otherwise, only pixel formats with a depth
		///                 buffer are considered.
		///             </description>
		///         </item>
		///         <item>
		///             <term>PFD_DOUBLEBUFFER_DONTCARE</term>
		///             <description>The requested pixel format can be either single- or double-buffered.</description>
		///         </item>
		///         <item>
		///             <term>PFD_STEREO_DONTCARE</term>
		///             <description>The requested pixel format can be either monoscopic or stereoscopic.</description>
		///         </item>
		///     </list>
		///     <para>
		///         With the glAddSwapHintRectWIN extension function, two new flags are included for the <see cref="PIXELFORMATDESCRIPTOR" />
		///         pixel format structure.
		///     </para>
		///     <list type="table">
		///         <item>
		///             <term>PFD_SWAP_COPY</term>
		///             <description>
		///                 Specifies the content of the back buffer in the double-buffered main color plane following a buffer swap. Swapping the color buffers
		///                 causes the content of the back buffer to be copied to the front buffer. The content of the back buffer is not affected by the swap.
		///                 PFD_SWAP_COPY is a hint only and might not be provided by a driver.
		///             </description>
		///         </item>
		///         <item>
		///             <term>PFD_SWAP_EXCHANGE</term>
		///             <description>
		///                 Specifies the content of the back buffer in the double-buffered main color plane following a buffer swap. Swapping the color buffers
		///                 causes the exchange of the back buffer's content with the front buffer's content. Following the swap, the back buffer's content
		///                 contains the front buffer's content before the swap. PFD_SWAP_EXCHANGE is a hint only and might not be provided by a driver.
		///             </description>
		///         </item>
		///     </list>
		/// </summary>
		public uint dwFlags;

		/// <summary>
		///     <para>Specifies the type of pixel data. The following types are defined.</para>
		///     <list type="table">
		///         <item>
		///             <term>PFD_TYPE_RGBA</term>
		///             <description>RGBA pixels. Each pixel has four components in this order: red, green, blue, and alpha.</description>
		///         </item>
		///         <item>
		///             <term>PFD_TYPE_COLORINDEX</term>
		///             <description>Color-index pixels. Each pixel uses a color-index value.</description>
		///         </item>
		///     </list>
		/// </summary>
		public byte iPixelType;

		/// <summary>
		///     Specifies the number of color bitplanes in each color buffer. For RGBA pixel types, it is the size of the color buffer, excluding the alpha
		///     bitplanes. For color-index pixels, it is the size of the color-index buffer.
		/// </summary>
		public byte cColorBits;

		/// <summary>Specifies the number of red bitplanes in each RGBA color buffer.</summary>
		public byte cRedBits;

		/// <summary>Specifies the shift count for red bitplanes in each RGBA color buffer.</summary>
		public byte cRedShift;

		/// <summary>Specifies the number of green bitplanes in each RGBA color buffer.</summary>
		public byte cGreenBits;

		/// <summary>Specifies the shift count for green bitplanes in each RGBA color buffer.</summary>
		public byte cGreenShift;

		/// <summary>Specifies the number of blue bitplanes in each RGBA color buffer.</summary>
		public byte cBlueBits;

		/// <summary>Specifies the shift count for blue bitplanes in each RGBA color buffer.</summary>
		public byte cBlueShift;

		/// <summary>Specifies the number of alpha bitplanes in each RGBA color buffer. Alpha bitplanes are not supported.</summary>
		public byte cAlphaBits;

		/// <summary>Specifies the shift count for alpha bitplanes in each RGBA color buffer. Alpha bitplanes are not supported.</summary>
		public byte cAlphaShift;

		/// <summary>Specifies the total number of bitplanes in the accumulation buffer.</summary>
		public byte cAccumBits;

		/// <summary>Specifies the number of red bitplanes in the accumulation buffer.</summary>
		public byte cAccumRedBits;

		/// <summary>Specifies the number of green bitplanes in the accumulation buffer.</summary>
		public byte cAccumGreenBits;

		/// <summary>Specifies the number of blue bitplanes in the accumulation buffer.</summary>
		public byte cAccumBlueBits;

		/// <summary>Specifies the number of alpha bitplanes in the accumulation buffer.</summary>
		public byte cAccumAlphaBits;

		/// <summary>Specifies the depth of the depth (z-axis) buffer.</summary>
		public byte cDepthBits;

		/// <summary>Specifies the depth of the stencil buffer.</summary>
		public byte cStencilBits;

		/// <summary>Specifies the number of auxiliary buffers. Auxiliary buffers are not supported.</summary>
		public byte cAuxBuffers;

		/// <summary>Ignored. Earlier implementations of OpenGL used this member, but it is no longer used.</summary>
		public byte iLayerType;

		/// <summary>
		///     Specifies the number of overlay and underlay planes. Bits 0 through 3 specify up to 15 overlay planes and bits 4 through 7 specify up to 15
		///     underlay planes.
		/// </summary>
		public byte bReserved;

		/// <summary>Ignored. Earlier implementations of OpenGL used this member, but it is no longer used.</summary>
		public uint dwLayerMask;

		/// <summary>
		///     Specifies the transparent color or index of an underlay plane. When the pixel type is RGBA, <see cref="dwVisibleMask" /> is a transparent RGB
		///     color value. When the pixel type is color index, it is a transparent index value.
		/// </summary>
		public uint dwVisibleMask;

		/// <summary>Ignored. Earlier implementations of OpenGL used this member, but it is no longer used.</summary>
		public uint dwDamageMask;
	}

	/// <summary>
	///     The <see cref="RGBQUAD" /> structure describes a color consisting of relative intensities of red, green, and blue.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct RGBQUAD
	{
		/// <summary>The intensity of blue in the color.</summary>
		public byte rgbBlue;

		/// <summary>The intensity of green in the color.</summary>
		public byte rgbGreen;

		/// <summary>The intensity of red in the color.</summary>
		public byte rgbRed;

		/// <summary>This member is reserved and must be zero.</summary>
		public byte rgbReserved;
	}

	/// <summary>
	///     The <see cref="MAT2" /> structure contains the values for a transformation matrix used by the <see cref="Gdi32.GetGlyphOutline" /> function.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct MAT2
	{
		/// <summary>A fixed-point value for the M11 component of a 3 by 3 transformation matrix.</summary>
		public FIXED eM11;

		/// <summary>A fixed-point value for the M12 component of a 3 by 3 transformation matrix.</summary>
		public FIXED eM12;

		/// <summary>A fixed-point value for the M21 component of a 3 by 3 transformation matrix.</summary>
		public FIXED eM21;

		/// <summary>A fixed-point value for the M22 component of a 3 by 3 transformation matrix.</summary>
		public FIXED eM22;
	}

	/// <summary>
	///     The <see cref="RGNDATA" /> structure contains a header and an array of rectangles that compose a region. The rectangles are sorted top to bottom,
	///     left to right. They do not overlap.
	/// </summary>
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
	public struct RGNDATA
	{
		/// <summary>
		///     A <see cref="RGNDATAHEADER" /> structure. The members of this structure specify the type of region (whether it is rectangular or trapezoidal),
		///     the number of rectangles that make up the region, the size of the buffer that contains the rectangle structures, and so on.
		/// </summary>
		public RGNDATAHEADER rdh;

		/// <summary>
		///     Specifies an arbitrary-size buffer that contains the <see cref="RECT" /> structures that make up the region.
		/// </summary>
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
		public string Buffer;
	}

	/// <summary>
	///     The <see cref="BITMAPINFOHEADER" /> structure contains information about the dimensions and color format of a DIB.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct BITMAPINFOHEADER
	{
		/// <summary>The number of bytes required by the structure.</summary>
		public uint biSize;

		/// <summary>
		///     <para>The width of the bitmap, in pixels.</para>
		///     <para>
		///         If <see cref="biCompression" /> is BI_JPEG or BI_PNG, the <see cref="biWidth" /> member specifies the width of the decompressed JPEG or PNG
		///         image file, respectively.
		///     </para>
		/// </summary>
		public int biWidth;

		/// <summary>
		///     <para>
		///         The height of the bitmap, in pixels. If <see cref="biHeight" /> is positive, the bitmap is a bottom-up DIB and its origin is the lower-left
		///         corner. If <see cref="biHeight" /> is negative, the bitmap is a top-down DIB and its origin is the upper-left corner.
		///     </para>
		///     <para>
		///         If <see cref="biHeight" /> is negative, indicating a top-down DIB, <see cref="biCompression" /> must be either BI_RGB or BI_BITFIELDS.
		///         Top-down DIBs cannot be compressed.
		///     </para>
		///     <para>
		///         If <see cref="biCompression" /> is BI_JPEG or BI_PNG, the <see cref="biHeight" /> member specifies the height of the decompressed JPEG or PNG
		///         image file, respectively.
		///     </para>
		/// </summary>
		public int biHeight;

		/// <summary>The number of planes for the target device. This value must be set to 1.</summary>
		public ushort biPlanes;

		/// <summary>
		///     <para>
		///         The number of bits-per-pixel. The <see cref="biBitCount" /> member of the <see cref="BITMAPINFOHEADER" /> structure determines the number of
		///         bits that define each pixel and the maximum number of colors in the bitmap. This member must be one of the following values.
		///     </para>
		///     <list type="table">
		///         <item>
		///             <term>0</term>
		///             <description>The number of bits-per-pixel is specified or is implied by the JPEG or PNG format.</description>
		///         </item>
		///         <item>
		///             <term>1</term>
		///             <description>
		///                 The bitmap is monochrome, and the <see cref="BITMAPINFO.bmiColors" /> member of <see cref="BITMAPINFO" /> contains two entries. Each
		///                 bit in the bitmap array represents a pixel. If the bit is clear, the pixel is displayed with the color of the first entry in the
		///                 <see cref="BITMAPINFO.bmiColors" /> table; if the bit is set, the pixel has the color of the second entry in the table.		///
		///             </description>
		///         </item>
		///         <item>
		///             <term>4</term>
		///             <description>
		///                 The bitmap has a maximum of 16 colors, and the <see cref="BITMAPINFO.bmiColors" /> member of <see cref="BITMAPINFO" /> contains up to
		///                 16 entries. Each pixel in the bitmap is represented by a 4-bit index into the color table. For example, if the first byte in the
		///                 bitmap is 0x1F, the byte represents two pixels. The first pixel contains the color in the second table entry, and the second pixel
		///                 contains the color in the sixteenth table entry.		///
		///             </description>
		///         </item>
		///         <item>
		///             <term>8</term>
		///             <description>
		///                 The bitmap has a maximum of 256 colors, and the <see cref="BITMAPINFO.bmiColors" /> member of <see cref="BITMAPINFO" /> contains up
		///                 to 256 entries. In this case, each byte in the array represents a single pixel.		///
		///             </description>
		///         </item>
		///         <item>
		///             <term>16</term>
		///             <description>
		///                 <para>
		///                     If the <see cref="biCompression" /> member of the <see cref="BITMAPINFOHEADER" /> is BI_BITFIELDS, the
		///                     <see cref="BITMAPINFO.bmiColors" />
		///                     member contains three DWORD color masks that specify the red, green, and blue components, respectively, of each pixel. Each WORD
		///                     in the bitmap array represents a single pixel.
		///                 </para>
		///                 <para>
		///                     When the <see cref="biCompression" /> member is BI_BITFIELDS, bits set in each DWORD mask must be contiguous and should not
		///                     overlap the bits of another mask. All the bits in the pixel do not have to be used.
		///                 </para>
		///             </description>
		///         </item>
		///         <item>
		///             <term>24</term>
		///             <description>
		///                 The bitmap has a maximum of 2^24 colors, and the <see cref="BITMAPINFO.bmiColors" /> member of <see cref="BITMAPINFO" /> is NULL.
		///                 Each 3-byte triplet in the bitmap array represents the relative intensities of blue, green, and red, respectively, for a pixel. The
		///                 <see cref="BITMAPINFO.bmiColors" /> color table is used for optimizing colors used on palette-based devices, and must contain the
		///                 number of entries specified by the <see cref="biClrUsed" /> member of the <see cref="BITMAPINFOHEADER" />.		///
		///             </description>
		///         </item>
		///         <item>
		///             <term>32</term>
		///             <description>
		///                 <para>
		///                     If the <see cref="biCompression" /> member of the <see cref="BITMAPINFOHEADER" /> is BI_BITFIELDS, the
		///                     <see cref="BITMAPINFO.bmiColors" />
		///                     member contains three DWORD color masks that specify the red, green, and blue components, respectively, of each pixel. Each DWORD
		///                     in the bitmap array represents a single pixel.
		///                 </para>
		///                 <para>
		///                     When the <see cref="biCompression" /> member is BI_BITFIELDS, bits set in each DWORD mask must be contiguous and should not
		///                     overlap the bits of another mask. All the bits in the pixel do not need to be used.
		///                 </para>
		///             </description>
		///         </item>
		///     </list>
		/// </summary>
		public ushort biBitCount;

		/// <summary>
		///     <para>
		///         The type of compression for a compressed bottom-up bitmap (top-down DIBs cannot be compressed). This member can be one of the following
		///         values.
		///     </para>
		///     <list type="table">
		///         <item>
		///             <term>BI_RGB</term>
		///             <description>An uncompressed format.</description>
		///         </item>
		///         <item>
		///             <term>BI_RLE8</term>
		///             <description>
		///                 A run-length encoded (RLE) format for bitmaps with 8 bpp. The compression format is a 2-byte format consisting of a count byte
		///                 followed by a byte containing a color index. For more information, see Bitmap Compression.
		///             </description>
		///         </item>
		///         <item>
		///             <term>BI_RLE4</term>
		///             <description>
		///                 An RLE format for bitmaps with 4 bpp. The compression format is a 2-byte format consisting of a count byte followed by two
		///                 word-length color indexes. For more information, see Bitmap Compression.
		///             </description>
		///         </item>
		///         <item>
		///             <term>BI_BITFIELDS</term>
		///             <description>
		///                 Specifies that the bitmap is not compressed and that the color table consists of three DWORD color masks that specify the red, green,
		///                 and blue components, respectively, of each pixel. This is valid when used with 16- and 32-bpp bitmaps.
		///             </description>
		///         </item>
		///         <item>
		///             <term>BI_JPEG</term>
		///             <description>Indicates that the image is a JPEG image.</description>
		///         </item>
		///         <item>
		///             <term>BI_PNG</term>
		///             <description>Indicates that the image is a PNG image.</description>
		///         </item>
		///     </list>
		/// </summary>
		public uint biCompression;

		/// <summary>
		///     <para>The size, in bytes, of the image. This may be set to zero for BI_RGB bitmaps.</para>
		///     <para>
		///         If <see cref="biCompression" /> is BI_JPEG or BI_PNG, <see cref="biSizeImage" /> indicates the size of the JPEG or PNG image buffer,
		///         respectively.
		///     </para>
		/// </summary>
		public uint biSizeImage;

		/// <summary>
		///     The horizontal resolution, in pixels-per-meter, of the target device for the bitmap. An application can use this value to select a bitmap from a
		///     resource group that best matches the characteristics of the current device.
		/// </summary>
		public int biXPelsPerMeter;

		/// <summary>The vertical resolution, in pixels-per-meter, of the target device for the bitmap.</summary>
		public int biYPelsPerMeter;

		/// <summary>
		///     <para>
		///         The number of color indexes in the color table that are actually used by the bitmap. If this value is zero, the bitmap uses the maximum
		///         number of colors corresponding to the value of the <see cref="biBitCount" /> member for the compression mode specified by
		///         <see cref="biCompression" />.
		///     </para>
		///     <para>
		///         If <see cref="biClrUsed" /> is nonzero and the <see cref="biBitCount" /> member is less than 16, the <see cref="biClrUsed" /> member
		///         specifies the actual number of colors the graphics engine or device driver accesses. If <see cref="biBitCount" /> is 16 or greater, the
		///         <see cref="biClrUsed" /> member specifies the size of the color table used to optimize performance of the system color palettes. If
		///         <see cref="biBitCount" /> equals 16 or 32, the optimal color palette starts immediately following the three DWORD masks.
		///     </para>
		///     <para>
		///         When the bitmap array immediately follows the <see cref="BITMAPINFO" /> structure, it is a packed bitmap. Packed bitmaps are referenced by a
		///         single pointer. Packed bitmaps require that the <see cref="biClrUsed" /> member must be either zero or the actual size of the color table.
		///     </para>
		/// </summary>
		public uint biClrUsed;

		/// <summary>The number of color indexes that are required for displaying the bitmap. If this value is zero, all colors are required.</summary>
		public uint biClrImportant;
	}

	/// <summary>
	///     The <see cref="LOGPALETTE" /> structure defines a logical palette.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct LOGPALETTE
	{
		/// <summary>The version number of the system.</summary>
		public ushort palVersion;

		/// <summary>The number of entries in the logical palette.</summary>
		public ushort palNumEntries;

		/// <summary>
		///     Specifies an array of <see cref="PALETTEENTRY" /> structures that define the color and usage of each entry in the logical palette.
		/// </summary>
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.Struct)]
		public PALETTEENTRY[] palPalEntry;
	}

	/// <summary>
	///     The <see cref="POLYTEXT" /> structure describes how the <see cref="Gdi32.PolyTextOut" /> function should draw a string of text.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct POLYTEXT
	{
		/// <summary>The horizontal reference point for the string. The string is aligned to this point using the current text-alignment mode.</summary>
		public int x;

		/// <summary>The vertical reference point for the string. The string is aligned to this point using the current text-alignment mode.</summary>
		public int y;

		/// <summary>
		///     The length of the string pointed to by <see cref="lpstr" />.
		/// </summary>
		public uint n;

		/// <summary>
		///     Pointer to a string of text to be drawn by the <see cref="Gdi32.PolyTextOut" /> function. This string need not be null-terminated, since
		///     <see cref="n" /> specifies the length of the string.
		/// </summary>
		[MarshalAs(UnmanagedType.LPTStr)]
		public string lpstr;

		/// <summary>
		///     <para>
		///         Specifies whether the string is to be opaque or clipped and whether the string is accompanied by an array of character-width values. This
		///         member can be one or more of the following values.
		///     </para>
		///     <list type="table">
		///         <item>
		///             <term>ETO_OPAQUE</term>
		///             <description>The rectangle for each string is to be opaqued with the current background color.</description>
		///         </item>
		///         <item>
		///             <term>ETO_CLIPPED</term>
		///             <description>Each string is to be clipped to its specified rectangle.</description>
		///         </item>
		///     </list>
		/// </summary>
		public uint uiFlags;

		/// <summary>
		///     A rectangle structure that contains the dimensions of the opaquing or clipping rectangle. This member is ignored if neither of the ETO_OPAQUE nor
		///     the ETO_CLIPPED value is specified for the <see cref="uiFlags" /> member.
		/// </summary>
		public RECT rcl;

		/// <summary>Pointer to an array containing the width value for each character in the string.</summary>
		public IntPtr pdx;
	}

	/// <summary>
	///     The <see cref="DOCINFO" /> structure contains the input and output file names and other information used by the <see cref="Gdi32.StartDoc" />
	///     function.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct DOCINFO
	{
		/// <summary>The size, in bytes, of the structure.</summary>
		public int cbSize;

		/// <summary>Pointer to a null-terminated string that specifies the name of the document.</summary>
		public string lpszDocName;

		/// <summary>
		///     Pointer to a null-terminated string that specifies the name of an output file. If this pointer is NULL, the output will be sent to the device
		///     identified by the device context handle that was passed to the <see cref="Gdi32.StartDoc" /> function.
		/// </summary>
		public string lpszOutput;

		/// <summary>
		///     Pointer to a null-terminated string that specifies the type of data used to record the print job. The legal values for this member can be found
		///     by calling EnumPrintProcessorDatatypes and can include such values as raw, emf, or XPS_PASS. This member can be NULL. Note that the requested
		///     data type might be ignored.
		/// </summary>
		public string lpszDatatype;

		/// <summary>
		///     <para>Specifies additional information about the print job. This member must be zero or one of the following values.</para>
		///     <list type="table">
		///         <item>
		///             <term>DI_APPBANDING</term>
		///             <description>Applications that use banding should set this flag for optimal performance during printing.</description>
		///         </item>
		///         <item>
		///             <term>DI_ROPS_READ_DESTINATION</term>
		///             <description>The application will use raster operations that involve reading from the destination surface.</description>
		///         </item>
		///     </list>
		/// </summary>
		public uint fwType;
	}

	/// <summary>
	///     The <see cref="OUTLINETEXTMETRIC" /> structure contains metrics describing a TrueType font.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct OUTLINETEXTMETRIC
	{
		/// <summary>
		///     The size, in bytes, of the <see cref="OUTLINETEXTMETRIC" /> structure.
		/// </summary>
		public uint otmSize;

		/// <summary>
		///     A <see cref="TEXTMETRIC" /> structure containing further information about the font.
		/// </summary>
		public TEXTMETRIC otmTextMetrics;

		/// <summary>A value that causes the structure to be byte-aligned.</summary>
		public byte otmFiller;

		/// <summary>The PANOSE number for this font.</summary>
		public PANOSE otmPanoseNumber;

		/// <summary>
		///     <para>The nature of the font pattern. This member can be a combination of the following bits.</para>
		///     <list type="table">
		///         <item>
		///             <term>0</term>
		///             <description>Italic</description>
		///         </item>
		///         <item>
		///             <term>1</term>
		///             <description>Underscore</description>
		///         </item>
		///         <item>
		///             <term>2</term>
		///             <description>Negative</description>
		///         </item>
		///         <item>
		///             <term>3</term>
		///             <description>Outline</description>
		///         </item>
		///         <item>
		///             <term>4</term>
		///             <description>Strikeout</description>
		///         </item>
		///         <item>
		///             <term>5</term>
		///             <description>Bold</description>
		///         </item>
		///     </list>
		/// </summary>
		public uint otmfsSelection;

		/// <summary>
		///     Indicates whether the font is licensed. Licensed fonts must not be modified or exchanged. If bit 1 is set, the font may not be embedded in a
		///     document. If bit 1 is clear, the font can be embedded. If bit 2 is set, the embedding is read-only.
		/// </summary>
		public uint otmfsType;

		/// <summary>
		///     The slope of the cursor. This value is 1 if the slope is vertical. Applications can use this value and the value of the
		///     <see cref="otmsCharSlopeRun" /> member to create an italic cursor that has the same slope as the main italic angle (specified by the
		///     <see cref="otmItalicAngle" /> member).
		/// </summary>
		public int otmsCharSlopeRise;

		/// <summary>
		///     The slope of the cursor. This value is zero if the slope is vertical. Applications can use this value and the value of the
		///     <see cref="otmsCharSlopeRise" /> member to create an italic cursor that has the same slope as the main italic angle (specified by the
		///     <see cref="otmItalicAngle" /> member).
		/// </summary>
		public int otmsCharSlopeRun;

		/// <summary>
		///     The main italic angle of the font, in tenths of a degree counterclockwise from vertical. Regular (roman) fonts have a value of zero. Italic fonts
		///     typically have a negative italic angle (that is, they lean to the right).
		/// </summary>
		public int otmItalicAngle;

		/// <summary>
		///     The number of logical units defining the x- or y-dimension of the em square for this font. (The number of units in the x- and y-directions are
		///     always the same for an em square.)
		/// </summary>
		public uint otmEMSquare;

		/// <summary>The maximum distance characters in this font extend above the base line. This is the typographic ascent for the font.</summary>
		public int otmAscent;

		/// <summary>The maximum distance characters in this font extend below the base line. This is the typographic descent for the font.</summary>
		public int otmDescent;

		/// <summary>The typographic line spacing.</summary>
		public uint otmLineGap;

		/// <summary>Not supported.</summary>
		public uint otmsCapEmHeight;

		/// <summary>Not supported.</summary>
		public uint otmsXHeight;

		/// <summary>The bounding box for the font.</summary>
		public RECT otmrcFontBox;

		/// <summary>The maximum distance characters in this font extend above the base line for the Macintosh computer.</summary>
		public int otmMacAscent;

		/// <summary>The maximum distance characters in this font extend below the base line for the Macintosh computer.</summary>
		public int otmMacDescent;

		/// <summary>The line-spacing information for the Macintosh computer.</summary>
		public uint otmMacLineGap;

		/// <summary>The smallest recommended size for this font, in pixels per em-square.</summary>
		public uint otmusMinimumPPEM;

		/// <summary>The recommended horizontal and vertical size for subscripts in this font.</summary>
		public POINT otmptSubscriptSize;

		/// <summary>
		///     The recommended horizontal and vertical offset for subscripts in this font. The subscript offset is measured from the character origin to the
		///     origin of the subscript character.
		/// </summary>
		public POINT otmptSubscriptOffset;

		/// <summary>The recommended horizontal and vertical size for superscripts in this font.</summary>
		public POINT otmptSuperscriptSize;

		/// <summary>
		///     The recommended horizontal and vertical offset for superscripts in this font. The superscript offset is measured from the character base line to
		///     the base line of the superscript character.
		/// </summary>
		public POINT otmptSuperscriptOffset;

		/// <summary>The width of the strikeout stroke for this font. Typically, this is the width of the em dash for the font.</summary>
		public uint otmsStrikeoutSize;

		/// <summary>
		///     The position of the strikeout stroke relative to the base line for this font. Positive values are above the base line and negative values
		///     are below.
		/// </summary>
		public int otmsStrikeoutPosition;

		/// <summary>The thickness of the underscore character for this font.</summary>
		public int otmsUnderscoreSize;

		/// <summary>The position of the underscore character for this font.</summary>
		public int otmsUnderscorePosition;

		/// <summary>The offset from the beginning of the structure to a string specifying the family name for the font.</summary>
		[MarshalAs(UnmanagedType.LPStr)]
		public string otmpFamilyName;

		/// <summary>
		///     The offset from the beginning of the structure to a string specifying the typeface name for the font. (This typeface name corresponds to the name
		///     specified in the <see cref="LOGFONT" /> structure.)
		/// </summary>
		[MarshalAs(UnmanagedType.LPStr)]
		public string otmpFaceName;

		/// <summary>The offset from the beginning of the structure to a string specifying the style name for the font.</summary>
		[MarshalAs(UnmanagedType.LPStr)]
		public string otmpStyleName;

		/// <summary>
		///     The offset from the beginning of the structure to a string specifying the full name for the font. This name is unique for the font and often
		///     contains a version number or other identifying information.
		/// </summary>
		[MarshalAs(UnmanagedType.LPStr)]
		public string otmpFullName;
	}

	/// <summary>
	///     The <see cref="GCP_RESULTS" /> structure contains information about characters in a string. This structure receives the results of the
	///     <see cref="Gdi32.GetCharacterPlacement" /> function. For some languages, the first element in the arrays may contain more, language-dependent
	///     information.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct GCP_RESULTS
	{
		/// <summary>The size, in bytes, of the structure.</summary>
		public uint lStructSize;

		/// <summary>
		///     A pointer to the buffer that receives the output string or is NULL if the output string is not needed. The output string is a version of the
		///     original string that is in the order that will be displayed on a specified device. Typically the output string is identical to the original
		///     string, but may be different if the string needs reordering and the GCP_REORDER flag is set or if the original string exceeds the maximum extent
		///     and the GCP_MAXEXTENT flag is set.
		/// </summary>
		[MarshalAs(UnmanagedType.LPTStr)]
		public string lpOutString;

		/// <summary>
		///     <para>
		///         A pointer to the array that receives ordering indexes or is NULL if the ordering indexes are not needed. However, its meaning depends on the
		///         other elements of <see cref="GCP_RESULTS" />. If glyph indexes are to be returned, the indexes are for the <see cref="lpGlyphs" /> array; if
		///         glyphs indexes are not returned and <see cref="lpOrder" /> is requested, the indexes are for <see cref="lpOutString" />. For example, in the
		///         latter case the value of <see cref="lpOrder" />[i] is the position of lpString[i] in the output string lpOutString.
		///     </para>
		///     <para>
		///         This is typically used when <see cref="Gdi32.GetFontLanguageInfo" /> returns the GCP_REORDER flag, which indicates that the original string
		///         needs reordering. For example, in Hebrew, in which the text runs from right to left, the <see cref="lpOrder" /> array gives the exact
		///         locations of each element in the original string.
		///     </para>
		/// </summary>
		public IntPtr lpOrder;

		/// <summary>
		///     <para>
		///         A pointer to the array that receives the distances between adjacent character cells or is NULL if these distances are not needed. If glyph
		///         rendering is done, the distances are for the glyphs not the characters, so the resulting array can be used with the
		///         <see cref="Gdi32.ExtTextOut" /> function.
		///     </para>
		///     <para>The distances in this array are in display order. To find the distance for the ith character in the original string, use the lpOrder array.</para>
		/// </summary>
		public IntPtr lpDX;

		/// <summary>
		///     <para>
		///         A pointer to the array that receives the caret position values or is NULL if caret positions are not needed. Each value specifies the caret
		///         position immediately before the corresponding character. In some languages the position of the caret for each character may not be
		///         immediately to the left of the character. For example, in Hebrew, in which the text runs from right to left, the caret position is to the
		///         right of the character. If glyph ordering is done, <see cref="lpCaretPos" /> matches the original string, not the output string. This means
		///         that some adjacent values may be the same.
		///     </para>
		///     <para>
		///         The values in this array are in input order. To find the caret position value for the ith character in the original string, use the array as
		///         follows:
		///     </para>
		/// </summary>
		public IntPtr lpCaretPos;

		/// <summary>
		///     <para>
		///         A pointer to the array that contains and/or receives character classifications. The values indicate how to lay out characters in the string
		///         and are similar (but not identical) to the CT_CTYPE2 values returned by the GetStringTypeEx function. Each element of the array can be set to
		///         zero or one of the following values.
		///     </para>
		///     <list type="table">
		///         <item>
		///             <term>GCPCLASS_ARABIC</term>
		///             <description>Arabic character.</description>
		///         </item>
		///         <item>
		///             <term>GCPCLASS_HEBREW</term>
		///             <description>Hebrew character.</description>
		///         </item>
		///         <item>
		///             <term>GCPCLASS_LATIN</term>
		///             <description>Character from a Latin or other single-byte character set for a left-to-right language.</description>
		///         </item>
		///         <item>
		///             <term>GCPCLASS_LATINNUMBER</term>
		///             <description>Digit from a Latin or other single-byte character set for a left-to-right language.</description>
		///         </item>
		///         <item>
		///             <term>GCPCLASS_LOCALNUMBER</term>
		///             <description>Digit from the character set associated with the current font.</description>
		///         </item>
		///     </list>
		///     <para>
		///         In addition, the following can be used when supplying values in the <see cref="lpClass" /> array with the GCP_CLASSIN flag.
		///     </para>
		///     <list type="table">
		///         <item>
		///             <term>GCPCLASS_LATINNUMERICSEPARATOR</term>
		///             <description>Input only. Character used to separate Latin digits, such as a comma or decimal point.</description>
		///         </item>
		///         <item>
		///             <term>GCPCLASS_LATINNUMERICTERMINATOR</term>
		///             <description>Input only. Character used to terminate Latin digits, such as a plus or minus sign.</description>
		///         </item>
		///         <item>
		///             <term>GCPCLASS_NEUTRAL</term>
		///             <description>Input only. Character has no specific classification.</description>
		///         </item>
		///         <item>
		///             <term>GCPCLASS_NUMERICSEPARATOR</term>
		///             <description>Input only. Character used to separate digits, such as a comma or decimal point.</description>
		///         </item>
		///     </list>
		///     <para>
		///         For languages that use the GCP_REORDER flag, the following values can also be used with the GCP_CLASSIN flag. Unlike the preceding values,
		///         which can be used anywhere in the <see cref="lpClass" /> array, all of the following values are used only in the first location in the array.
		///         All combine with other classifications.
		///     </para>
		///     <para>Note that GCPCLASS_PREBOUNDLTR and GCPCLASS_PREBOUNDRTL are mutually exclusive, as are GCPCLASSPOSTBOUNDLTR and GCPCLASSPOSTBOUNDRTL.</para>
		///     <list type="table">
		///         <item>
		///             <term>GCPCLASS_PREBOUNDLTR</term>
		///             <description>
		///                 Set <see cref="lpClass" />[0] to GCPCLASS_PREBOUNDLTR to bind the string to left-to-right reading order before the string.
		///             </description>
		///         </item>
		///         <item>
		///             <term>GCPCLASS_PREBOUNDRTL</term>
		///             <description>
		///                 Set <see cref="lpClass" />[0] to GCPCLASS_PREBOUNDRTL to bind the string to right-to-left reading order before the string.
		///             </description>
		///         </item>
		///         <item>
		///             <term>GCPCLASS_POSTBOUNDLTR</term>
		///             <description>
		///                 Set <see cref="lpClass" />[0] to GCPCLASS_POSTBOUNDLTR to bind the string to left-to-right reading order after the string.
		///             </description>
		///         </item>
		///         <item>
		///             <term>GCPCLASS_POSTBOUNDRTL</term>
		///             <description>
		///                 Set <see cref="lpClass" />[0] to GCPCLASS_POSTBOUNDRTL to bind the string to right-to-left reading order after the string.
		///             </description>
		///         </item>
		///     </list>
		///     <para>
		///         To force the layout of a character to be carried out in a specific way, preset the classification for the corresponding array element; the
		///         function leaves such preset classifications unchanged and computes classifications only for array elements that have been set to zero. Preset
		///         classifications are used only if the GCP_CLASSIN flag is set and the <see cref="lpClass" /> array is supplied.
		///     </para>
		///     <para>
		///         If <see cref="Gdi32.GetFontLanguageInfo" /> does not return GCP_REORDER for the current font, only the GCPCLASS_LATIN value is meaningful.
		///     </para>
		/// </summary>
		[MarshalAs(UnmanagedType.LPStr)]
		public string lpClass;

		/// <summary>
		///     <para>
		///         A pointer to the array that receives the values identifying the glyphs used for rendering the string or is NULL if glyph rendering is not
		///         needed. The number of glyphs in the array may be less than the number of characters in the original string if the string contains ligated
		///         glyphs. Also if reordering is required, the order of the glyphs may not be sequential.
		///     </para>
		///     <para>
		///         This array is useful if more than one operation is being done on a string which has any form of ligation, kerning or order-switching. Using
		///         the values in this array for subsequent operations saves the time otherwise required to generate the glyph indices each time.
		///     </para>
		///     <para>
		///         This array always contains glyph indices and the ETO_GLYPH_INDEX value must always be used when this array is used with the
		///         <see cref="Gdi32.ExtTextOut" /> function.
		///     </para>
		///     <para>
		///         When GCP_LIGATE is used, you can limit the number of characters that will be ligated together. (In Arabic for example, three-character
		///         ligations are common). This is done by setting the maximum required in lpGcpResults->lpGlyphs[0]. If no maximum is required, you should set
		///         this field to zero.
		///     </para>
		///     <para>
		///         For languages such as Arabic, where <see cref="Gdi32.GetFontLanguageInfo" /> returns the GCP_GLYPHSHAPE flag, the glyphs for a character will
		///         be different depending on whether the character is at the beginning, middle, or end of a word. Typically, the first character in the input
		///         string will also be the first character in a word, and the last character in the input string will be treated as the last character in a
		///         word. However, if the displayed string is a subset of the complete string, such as when displaying a section of scrolled text, this may not
		///         be true. In these cases, it is desirable to force the first or last characters to be shaped as not being initial or final forms. To do this,
		///         again, the first location in the <see cref="lpGlyphs" /> array is used by performing an OR operation of the ligation value above with the
		///         values GCPGLYPH_LINKBEFORE and/or GCPGLYPH_LINKAFTER. For example, a value of GCPGLYPH_LINKBEFORE | 2 means that two-character ligatures are
		///         the maximum required, and the first character in the string should be treated as if it is in the middle of a word.
		///     </para>
		/// </summary>
		public string lpGlyphs;

		/// <summary>
		///     On input, this member must be set to the size of the arrays pointed to by the array pointer members. On output, this is set to the number of
		///     glyphs filled in, in the output arrays. If glyph substitution is not required (that is, each input character maps to exactly one glyph), this
		///     member is the same as it is on input.
		/// </summary>
		public uint nGlyphs;

		/// <summary>
		///     The number of characters that fit within the extents specified by the nMaxExtent parameter of the
		///     <see cref="Gdi32.GetCharacterPlacement" /> function. If the GCP_MAXEXTENT or GCP_JUSTIFY value is set, this value may be less than the number of
		///     characters in the original string. This member is set regardless of whether the GCP_MAXEXTENT or GCP_JUSTIFY value is specified. Unlike
		///     <see cref="nGlyphs" />, which specifies the number of output glyphs, <see cref="nMaxFit" /> refers to the number of characters from the input
		///     string. For Latin SBCS languages, this will be the same.
		/// </summary>
		public int nMaxFit;
	}

	/// <summary>
	///     The <see cref="ABCFLOAT" /> structure contains the A, B, and C widths of a font character.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct ABCFLOAT
	{
		/// <summary>The A spacing of the character. The A spacing is the distance to add to the current position before drawing the character glyph.</summary>
		public float abcfA;

		/// <summary>The B spacing of the character. The B spacing is the width of the drawn portion of the character glyph.</summary>
		public float abcfB;

		/// <summary>
		///     The C spacing of the character. The C spacing is the distance to add to the current position to provide white space to the right of the character
		///     glyph.
		/// </summary>
		public float abcfC;
	}

	/// <summary>
	///     The <see cref="HANDLETABLE" /> structure is an array of handles, each of which identifies a graphics device interface (GDI) object.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct HANDLETABLE
	{
		/// <summary>An array of handles.</summary>
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.SysUInt)]
		public IntPtr[] objectHandle;
	}

	/// <summary>Contains information about a character set.</summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct CHARSETINFO
	{
		/// <summary>Character set value.</summary>
		public uint ciCharset;

		/// <summary>Windows ANSI code page identifier. For a list of identifiers, see Code Page Identifiers.</summary>
		public uint ciACP;

		/// <summary>
		///     A <see cref="FONTSIGNATURE" /> structure that identifies the Unicode subrange and the specific Windows ANSI character set/code page. Only one
		///     code page will be set when this structure is set by the function.
		/// </summary>
		public FONTSIGNATURE fs;
	}

	/// <summary>
	///     The <see cref="GLYPHSET" /> structure contains information about a range of Unicode code points.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct GLYPHSET
	{
		/// <summary>The size, in bytes, of this structure.</summary>
		public uint cbThis;

		/// <summary>
		///     <para>Flags describing the maximum size of the glyph indices. This member can be the following value.</para>
		///     <list type="table">
		///         <item>
		///             <term>GS_8BIT_INDICES</term>
		///             <description>Treat glyph indices as 8-bit wide values. Otherwise, they are 16-bit wide values.</description>
		///         </item>
		///     </list>
		/// </summary>
		public uint flAccel;

		/// <summary>The total number of Unicode code points supported in the font.</summary>
		public uint cGlyphsSupported;

		/// <summary>
		///     The total number of Unicode ranges in <see cref="ranges" />.
		/// </summary>
		public uint cRanges;

		/// <summary>Array of Unicode ranges that are supported in the font.</summary>
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.Struct)]
		public WCRANGE[] ranges;
	}

	/// <summary>
	///     <para>
	///         The <see cref="ENHMETAHEADER" /> structure contains enhanced-metafile data such as the dimensions of the picture stored in the enhanced
	///         metafile, the count of records in the enhanced metafile, the resolution of the device on which the picture was created, and so on.
	///     </para>
	///     <para>This structure is always the first record in an enhanced metafile.</para>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct ENHMETAHEADER
	{
		/// <summary>The record type. This member must specify the value assigned to the EMR_HEADER constant.</summary>
		public uint iType;

		/// <summary>The structure size, in bytes.</summary>
		public uint nSize;

		/// <summary>
		///     The dimensions, in device units, of the smallest rectangle that can be drawn around the picture stored in the metafile. This rectangle is
		///     supplied by graphics device interface (GDI). Its dimensions include the right and bottom edges.
		/// </summary>
		public RECTL rclBounds;

		/// <summary>
		///     The dimensions, in .01 millimeter units, of a rectangle that surrounds the picture stored in the metafile. This rectangle must be supplied by the
		///     application that creates the metafile. Its dimensions include the right and bottom edges.
		/// </summary>
		public RECTL rclFrame;

		/// <summary>A signature. This member must specify the value assigned to the ENHMETA_SIGNATURE constant.</summary>
		public uint dSignature;

		/// <summary>The metafile version. The current version value is 0x10000.</summary>
		public uint nVersion;

		/// <summary>The size of the enhanced metafile, in bytes.</summary>
		public uint nBytes;

		/// <summary>The number of records in the enhanced metafile.</summary>
		public uint nRecords;

		/// <summary>The number of handles in the enhanced-metafile handle table. (Index zero in this table is reserved.)</summary>
		public ushort nHandles;

		/// <summary>Reserved; must be zero.</summary>
		public ushort sReserved;

		/// <summary>
		///     The number of characters in the array that contains the description of the enhanced metafile's contents. This member should be set to zero if the
		///     enhanced metafile does not contain a description string.
		/// </summary>
		public uint nDescription;

		/// <summary>
		///     The offset from the beginning of the <see cref="ENHMETAHEADER" /> structure to the array that contains the description of the enhanced metafile's
		///     contents. This member should be set to zero if the enhanced metafile does not contain a description string.
		/// </summary>
		public uint offDescription;

		/// <summary>The number of entries in the enhanced metafile's palette.</summary>
		public uint nPalEntries;

		/// <summary>The resolution of the reference device, in pixels.</summary>
		public SIZE szlDevice;

		/// <summary>The resolution of the reference device, in millimeters.</summary>
		public SIZE szlMillimeters;

		/// <summary>
		///     The size of the last recorded pixel format in a metafile. If a pixel format is set in a reference DC at the start of recording,
		///     <see cref="cbPixelFormat" /> is set to the size of the <see cref="PIXELFORMATDESCRIPTOR" />. When no pixel format is set when a metafile is
		///     recorded, this member is set to zero. If more than a single pixel format is set, the header points to the last pixel format.
		/// </summary>
		public uint cbPixelFormat;

		/// <summary>
		///     The offset of pixel format used when recording a metafile. If a pixel format is set in a reference DC at the start of recording or during
		///     recording, <see cref="offPixelFormat" /> is set to the offset of the <see cref="PIXELFORMATDESCRIPTOR" /> in the metafile. If no pixel format is
		///     set when a metafile is recorded, this member is set to zero. If more than a single pixel format is set, the header points to the last pixel
		///     format.
		/// </summary>
		public uint offPixelFormat;

		/// <summary>
		///     Indicates whether any OpenGL records are present in a metafile. <see cref="bOpenGL" /> is a simple Boolean flag that you can use to determine
		///     whether an enhanced metafile requires OpenGL handling. When a metafile contains OpenGL records, <see cref="bOpenGL" /> is TRUE; otherwise it is
		///     FALSE.
		/// </summary>
		public uint bOpenGL;

		/// <summary>The size of the reference device, in micrometers.</summary>
		public SIZE szlMicrometers;
	}

	/// <summary>
	///     The <see cref="METARECORD" /> structure contains a Windows-format metafile record.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct METARECORD
	{
		/// <summary>The size, in words, of the record.</summary>
		public uint rdSize;

		/// <summary>The function number.</summary>
		public ushort rdFunction;

		/// <summary>An array of words containing the function parameters, in reverse of the order they are passed to the function.</summary>
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.U2)]
		public ushort[] rdParm;
	}

	/// <summary>Contains information identifying the code pages and Unicode subranges for which a given font provides glyphs.</summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct FONTSIGNATURE
	{
		/// <summary>
		///     A 128-bit Unicode subset bitfield (USB) identifying up to 126 Unicode subranges. Each bit, except the two most significant bits, represents a
		///     single subrange. The most significant bit is always 1 and identifies the bitfield as a font signature; the second most significant bit is
		///     reserved and must be 0. Unicode subranges are numbered in accordance with the ISO 10646 standard. For more information, see Unicode Subset
		///     Bitfields.
		/// </summary>
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.U4)]
		public uint[] fsUsb;

		/// <summary>
		///     A 64-bit, code-page bitfield (CPB) that identifies a specific character set or code page. Code pages are in the lower 32 bits of this bitfield.
		///     The high 32 are used for non-Windows code pages. For more information, see Code Page Bitfields.
		/// </summary>
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.U4)]
		public uint[] fsCsb;
	}

	/// <summary>
	///     The <see cref="RASTERIZER_STATUS" /> structure contains information about whether TrueType is installed. This structure is filled when an
	///     application calls the <see cref="Gdi32.GetRasterizerCaps" /> function.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct RASTERIZER_STATUS
	{
		/// <summary>
		///     The size, in bytes, of the <see cref="RASTERIZER_STATUS" /> structure.
		/// </summary>
		public short nSize;

		/// <summary>
		///     Specifies whether at least one TrueType font is installed and whether TrueType is enabled. This value is TT_AVAILABLE, TT_ENABLED, or both if
		///     TrueType is on the system.
		/// </summary>
		public short wFlags;

		/// <summary>The language in the system's Setup.inf file.</summary>
		public short nLanguageID;
	}

	/// <summary>
	///     The <see cref="LOGCOLORSPACE" /> structure contains information that defines a logical color space.
	/// </summary>
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct LOGCOLORSPACE
	{
		/// <summary>Color space signature. At present, this member should always be set to LCS_SIGNATURE.</summary>
		public uint lcsSignature;

		/// <summary>Version number; must be 0x400.</summary>
		public uint lcsVersion;

		/// <summary>Size of this structure, in bytes.</summary>
		public uint lcsSize;

		/// <summary>
		///     <para>Color space type. The member can be one of the following values.</para>
		///     <list type="table">
		///         <item>
		///             <term>LCS_CALIBRATED_RGB</term>
		///             <description>
		///                 Color values are calibrated RGB values. The values are translated using the endpoints specified by the <see cref="lcsEndpoints" />
		///                 member before being passed to the device.
		///             </description>
		///         </item>
		///         <item>
		///             <term>LCS_sRGB</term>
		///             <description>Color values are values are sRGB values.</description>
		///         </item>
		///         <item>
		///             <term>LCS_WINDOWS_COLOR_SPACE</term>
		///             <description>Color values are Windows default color space color values.</description>
		///         </item>
		///     </list>
		///     <para>
		///         If LCS_CALIBRATED_RGB is not specified, the <see cref="lcsEndpoints" /> member is ignored.
		///     </para>
		/// </summary>
		public int lcsCSType;

		/// <summary>
		///     <para>The gamut mapping method. This member can be one of the following values.</para>
		///     <list type="table">
		///         <item>
		///             <term>LCS_GM_ABS_COLORIMETRIC</term>
		///             <description>Match</description>
		///         </item>
		///         <item>
		///             <term>LCS_GM_BUSINESS</term>
		///             <description>Graphic</description>
		///         </item>
		///         <item>
		///             <term>LCS_GM_GRAPHICS</term>
		///             <description>Proof</description>
		///         </item>
		///         <item>
		///             <term>LCS_GM_IMAGES</term>
		///             <description>Picture</description>
		///         </item>
		///     </list>
		/// </summary>
		public int lcsIntent;

		/// <summary>Red, green, blue endpoints.</summary>
		public CIEXYZTRIPLE lcsEndpoints;

		/// <summary>Scale of the red coordinate.</summary>
		public uint lcsGammaRed;

		/// <summary>Scale of the green coordinate.</summary>
		public uint lcsGammaGreen;

		/// <summary>Scale of the blue coordinate.</summary>
		public uint lcsGammaBlue;

		/// <summary>
		///     A null-terminated string that names a color profile file. This member is typically set to zero, but may be used to set the color space to be
		///     exactly as specified by the color profile. This is useful for devices that input color values for a specific printer, or when using an
		///     installable image color matcher. If a color profile is specified, all other members of this structure should be set to reasonable values, even if
		///     the values are not completely accurate.
		/// </summary>
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
		public string lcsFilename;
	}

	/// <summary>
	///     The <see cref="ABC" /> structure contains the width of a character in a TrueType font.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct ABC
	{
		/// <summary>The A spacing of the character. The A spacing is the distance to add to the current position before drawing the character glyph.</summary>
		public int abcA;

		/// <summary>The B spacing of the character. The B spacing is the width of the drawn portion of the character glyph.</summary>
		public uint abcB;

		/// <summary>
		///     The C spacing of the character. The C spacing is the distance to add to the current position to provide white space to the right of the character
		///     glyph.
		/// </summary>
		public int abcC;
	}

	/// <summary>
	///     The <see cref="KERNINGPAIR" /> structure defines a kerning pair.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct KERNINGPAIR
	{
		/// <summary>The character code for the first character in the kerning pair.</summary>
		public ushort wFirst;

		/// <summary>The character code for the second character in the kerning pair.</summary>
		public ushort wSecond;

		/// <summary>
		///     The amount this pair will be kerned if they appear side by side in the same font and size. This value is typically negative, because pair kerning
		///     usually results in two characters being set more tightly than normal. The value is specified in logical units; that is, it depends on the current
		///     mapping mode.
		/// </summary>
		public int iKernAmount;
	}

	/// <summary>
	///     The <see cref="GLYPHMETRICS" /> structure contains information about the placement and orientation of a glyph in a character cell.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct GLYPHMETRICS
	{
		/// <summary>The width of the smallest rectangle that completely encloses the glyph (its black box).</summary>
		public uint gmBlackBoxX;

		/// <summary>The height of the smallest rectangle that completely encloses the glyph (its black box).</summary>
		public uint gmBlackBoxY;

		/// <summary>The x- and y-coordinates of the upper left corner of the smallest rectangle that completely encloses the glyph.</summary>
		public POINT gmptGlyphOrigin;

		/// <summary>The horizontal distance from the origin of the current character cell to the origin of the next character cell.</summary>
		public short gmCellIncX;

		/// <summary>The vertical distance from the origin of the current character cell to the origin of the next character cell.</summary>
		public short gmCellIncY;
	}

	/// <summary>
	///     The <see cref="ENUMLOGFONTEX" /> structure contains information about an enumerated font.
	/// </summary>
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
	public struct ENUMLOGFONTEX
	{
		/// <summary>
		///     A <see cref="LOGFONT" /> structure that contains values defining the font attributes.
		/// </summary>
		public LOGFONT elfLogFont;

		/// <summary>The unique name of the font. For example, ABC Font Company TrueType Bold Italic Sans Serif.</summary>
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
		public string elfFullName;

		/// <summary>The style of the font. For example, Bold Italic.</summary>
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
		public string elfStyle;

		/// <summary>The script, that is, the character set, of the font. For example, Cyrillic.</summary>
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
		public string elfScript;
	}

	/// <summary>
	///     The <see cref="DESIGNVECTOR" /> structure is used by an application to specify values for the axes of a multiple master font.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct DESIGNVECTOR
	{
		/// <summary>Reserved. Must be STAMP_DESIGNVECTOR.</summary>
		public uint dvReserved;

		/// <summary>
		///     Number of values in the <see cref="dvValues" /> array.
		/// </summary>
		public uint dvNumAxes;

		/// <summary>
		///     An array specifying the values of the axes of a multiple master OpenType font. This array corresponds to the <see cref="AXESLIST.axlAxisInfo" />
		///     array in the <see cref="AXESLIST" /> structure.
		/// </summary>
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I4)]
		public int[] dvValues;
	}

	/// <summary>
	///     The <see cref="FIXED" /> structure contains the integral and fractional parts of a fixed-point real number.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct FIXED
	{
		/// <summary>The fractional part of the number.</summary>
		public ushort fract;

		/// <summary>The integer part of the number.</summary>
		public short value;
	}

	/// <summary>
	///     The <see cref="RGNDATAHEADER" /> structure describes the data returned by the <see cref="Gdi32.GetRegionData" /> function.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct RGNDATAHEADER
	{
		/// <summary>The size, in bytes, of the header.</summary>
		public uint dwSize;

		/// <summary>The type of region. This value must be RDH_RECTANGLES.</summary>
		public uint iType;

		/// <summary>The number of rectangles that make up the region.</summary>
		public uint nCount;

		/// <summary>
		///     The size of the <see cref="RGNDATA" /> buffer required to receive the <see cref="RECT" /> structures that make up the region. If the size is not
		///     known, this member can be zero.
		/// </summary>
		public uint nRgnSize;

		/// <summary>A bounding rectangle for the region in logical units.</summary>
		public RECT rcBound;
	}

	/// <summary>
	///     The <see cref="PANOSE" /> structure describes the PANOSE font-classification values for a TrueType font. These characteristics are then used to
	///     associate the font with other fonts of similar appearance but different names.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct PANOSE
	{
		/// <summary>
		///     <para>For Latin fonts, one of one of the following values.</para>
		///     <list type="table">
		///         <item>
		///             <term>PAN_ANY</term>
		///             <description>Any</description>
		///         </item>
		///         <item>
		///             <term>PAN_NO_FIT</term>
		///             <description>No fit</description>
		///         </item>
		///         <item>
		///             <term>PAN_FAMILY_TEXT_DISPLAY</term>
		///             <description>Text and display</description>
		///         </item>
		///         <item>
		///             <term>PAN_FAMILY_SCRIPT</term>
		///             <description>Script</description>
		///         </item>
		///         <item>
		///             <term>PAN_FAMILY_DECORATIVE</term>
		///             <description>Decorative</description>
		///         </item>
		///         <item>
		///             <term>PAN_FAMILY_PICTORIAL</term>
		///             <description>Pictorial</description>
		///         </item>
		///     </list>
		/// </summary>
		public byte bFamilyType;

		/// <summary>
		///     <para>The serif style. For Latin fonts, one of the following values.</para>
		///     <list type="table">
		///         <item>
		///             <term>PAN_ANY</term>
		///             <description>Any</description>
		///         </item>
		///         <item>
		///             <term>PAN_NO_FIT</term>
		///             <description>No fit</description>
		///         </item>
		///         <item>
		///             <term>PAN_SERIF_COVE</term>
		///             <description>Cove</description>
		///         </item>
		///         <item>
		///             <term>PAN_SERIF_OBTUSE_COVE</term>
		///             <description>Obtuse cove</description>
		///         </item>
		///         <item>
		///             <term>PAN_SERIF_SQUARE_COVE</term>
		///             <description>Square cove</description>
		///         </item>
		///         <item>
		///             <term>PAN_SERIF_OBTUSE_SQUARE_COVE</term>
		///             <description>Obtuse square cove</description>
		///         </item>
		///         <item>
		///             <term>PAN_SERIF_SQUARE</term>
		///             <description>Square</description>
		///         </item>
		///         <item>
		///             <term>PAN_SERIF_THIN</term>
		///             <description>Thin</description>
		///         </item>
		///         <item>
		///             <term>PAN_SERIF_BONE</term>
		///             <description>Bone</description>
		///         </item>
		///         <item>
		///             <term>PAN_SERIF_EXAGGERATED</term>
		///             <description>Exaggerated</description>
		///         </item>
		///         <item>
		///             <term>PAN_SERIF_TRIANGLE</term>
		///             <description>Triangle</description>
		///         </item>
		///         <item>
		///             <term>PAN_SERIF_NORMAL_SANS</term>
		///             <description>Normal sans serif</description>
		///         </item>
		///         <item>
		///             <term>PAN_SERIF_OBTUSE_SANS</term>
		///             <description>Obtuse sans serif</description>
		///         </item>
		///         <item>
		///             <term>PAN_SERIF_PERP_SANS</term>
		///             <description>Perp sans serif</description>
		///         </item>
		///         <item>
		///             <term>PAN_SERIF_FLARED</term>
		///             <description>Flared</description>
		///         </item>
		///         <item>
		///             <term>PAN_SERIF_ROUNDED</term>
		///             <description>Rounded</description>
		///         </item>
		///     </list>
		/// </summary>
		public byte bSerifStyle;

		/// <summary>
		///     <para>For Latin fonts, one of the following values.</para>
		///     <list type="table">
		///         <item>
		///             <term>PAN_ANY</term>
		///             <description>Any</description>
		///         </item>
		///         <item>
		///             <term>PAN_NO_FIT</term>
		///             <description>No fit</description>
		///         </item>
		///         <item>
		///             <term>PAN_WEIGHT_VERY_LIGHT</term>
		///             <description>Very light</description>
		///         </item>
		///         <item>
		///             <term>PAN_WEIGHT_LIGHT</term>
		///             <description>Light</description>
		///         </item>
		///         <item>
		///             <term>PAN_WEIGHT_THIN</term>
		///             <description>Thin</description>
		///         </item>
		///         <item>
		///             <term>PAN_WEIGHT_BOOK</term>
		///             <description>Book</description>
		///         </item>
		///         <item>
		///             <term>PAN_WEIGHT_MEDIUM</term>
		///             <description>Medium</description>
		///         </item>
		///         <item>
		///             <term>PAN_WEIGHT_DEMI</term>
		///             <description>Demibold</description>
		///         </item>
		///         <item>
		///             <term>PAN_WEIGHT_BOLD</term>
		///             <description>Bold</description>
		///         </item>
		///         <item>
		///             <term>PAN_WEIGHT_HEAVY</term>
		///             <description>Heavy</description>
		///         </item>
		///         <item>
		///             <term>PAN_WEIGHT_BLACK</term>
		///             <description>Black</description>
		///         </item>
		///         <item>
		///             <term>PAN_WEIGHT_NORD</term>
		///             <description>Nord</description>
		///         </item>
		///     </list>
		/// </summary>
		public byte bWeight;

		/// <summary>
		///     <para>For Latin fonts, one of the following values.</para>
		///     <list type="table">
		///         <item>
		///             <term>PAN_ANY</term>
		///             <description>Any</description>
		///         </item>
		///         <item>
		///             <term>PAN_NO_FIT</term>
		///             <description>No fit</description>
		///         </item>
		///         <item>
		///             <term>PAN_PROP_OLD_STYLE</term>
		///             <description>Old style</description>
		///         </item>
		///         <item>
		///             <term>PAN_PROP_MODERN</term>
		///             <description>Modern</description>
		///         </item>
		///         <item>
		///             <term>PAN_PROP_EVEN_WIDTH</term>
		///             <description>Even width</description>
		///         </item>
		///         <item>
		///             <term>PAN_PROP_EXPANDED</term>
		///             <description>Expanded</description>
		///         </item>
		///         <item>
		///             <term>PAN_PROP_CONDENSED</term>
		///             <description>Condensed</description>
		///         </item>
		///         <item>
		///             <term>PAN_PROP_VERY_EXPANDED</term>
		///             <description>Very expanded</description>
		///         </item>
		///         <item>
		///             <term>PAN_PROP_VERY_CONDENSED</term>
		///             <description>Very condensed</description>
		///         </item>
		///         <item>
		///             <term>PAN_PROP_MONOSPACED</term>
		///             <description>Monospaced</description>
		///         </item>
		///     </list>
		/// </summary>
		public byte bProportion;

		/// <summary>
		///     <para>For Latin fonts,  one of the following values.</para>
		///     <list type="table">
		///         <item>
		///             <term>PAN_ANY</term>
		///             <description>Any</description>
		///         </item>
		///         <item>
		///             <term>PAN_NO_FIT</term>
		///             <description>No fit</description>
		///         </item>
		///         <item>
		///             <term>PAN_CONTRAST_NONE</term>
		///             <description>None</description>
		///         </item>
		///         <item>
		///             <term>PAN_CONTRAST_VERY_LOW</term>
		///             <description>Very low</description>
		///         </item>
		///         <item>
		///             <term>PAN_CONTRAST_LOW</term>
		///             <description>Low</description>
		///         </item>
		///         <item>
		///             <term>PAN_CONTRAST_MEDIUM_LOW</term>
		///             <description>Medium low</description>
		///         </item>
		///         <item>
		///             <term>PAN_CONTRAST_MEDIUM</term>
		///             <description>Medium</description>
		///         </item>
		///         <item>
		///             <term>PAN_CONTRAST_MEDIUM_HIGH</term>
		///             <description>Medium high</description>
		///         </item>
		///         <item>
		///             <term>PAN_CONTRAST_HIGH</term>
		///             <description>High</description>
		///         </item>
		///         <item>
		///             <term>PAN_CONTRAST_VERY_HIGH</term>
		///             <description>Very high</description>
		///         </item>
		///     </list>
		/// </summary>
		public byte bContrast;

		/// <summary>
		///     <para>For Latin fonts, one of the following values.</para>
		///     <list type="table">
		///         <item>
		///             <term>PAN_ANY</term>
		///             <description>Any</description>
		///         </item>
		///         <item>
		///             <term>PAN_NO_FIT</term>
		///             <description>No fit</description>
		///         </item>
		///         <item>
		///             <term>PAN_STROKE_GRADUAL_DIAG</term>
		///             <description>Gradual/diagonal</description>
		///         </item>
		///         <item>
		///             <term>PAN_STROKE_GRADUAL_TRAN</term>
		///             <description>Gradual/transitional</description>
		///         </item>
		///         <item>
		///             <term>PAN_STROKE_GRADUAL_VERT</term>
		///             <description>Gradual/vertical</description>
		///         </item>
		///         <item>
		///             <term>PAN_STROKE_GRADUAL_HORZ</term>
		///             <description>Gradual/horizontal</description>
		///         </item>
		///         <item>
		///             <term>PAN_STROKE_RAPID_VERT</term>
		///             <description>Rapid/vertical</description>
		///         </item>
		///         <item>
		///             <term>PAN_STROKE_RAPID_HORZ</term>
		///             <description>Rapid/horizontal</description>
		///         </item>
		///         <item>
		///             <term>PAN_STROKE_INSTANT_VERT</term>
		///             <description>Instant/vertical</description>
		///         </item>
		///     </list>
		/// </summary>
		public byte bStrokeVariation;

		/// <summary>
		///     <para>For Latin fonts, one of the following values.</para>
		///     <list type="table">
		///         <item>
		///             <term>PAN_ANY</term>
		///             <description>Any</description>
		///         </item>
		///         <item>
		///             <term>PAN_NO_FIT</term>
		///             <description>No fit</description>
		///         </item>
		///         <item>
		///             <term>PAN_STRAIGHT_ARMS_HORZ</term>
		///             <description>Straight arms/horizontal</description>
		///         </item>
		///         <item>
		///             <term>PAN_STRAIGHT_ARMS_WEDGE</term>
		///             <description>Straight arms/wedge</description>
		///         </item>
		///         <item>
		///             <term>PAN_STRAIGHT_ARMS_VERT</term>
		///             <description>Straight arms/vertical</description>
		///         </item>
		///         <item>
		///             <term>PAN_STRAIGHT_ARMS_SINGLE_SERIF</term>
		///             <description>Straight arms/single-serif</description>
		///         </item>
		///         <item>
		///             <term>PAN_STRAIGHT_ARMS_DOUBLE_SERIF</term>
		///             <description>Straight arms/double-serif</description>
		///         </item>
		///         <item>
		///             <term>PAN_BENT_ARMS_HORZ</term>
		///             <description>Nonstraight arms/horizontal</description>
		///         </item>
		///         <item>
		///             <term>PAN_BENT_ARMS_WEDGE</term>
		///             <description>Nonstraight arms/wedge</description>
		///         </item>
		///         <item>
		///             <term>PAN_BENT_ARMS_VERT</term>
		///             <description>Nonstraight arms/vertical</description>
		///         </item>
		///         <item>
		///             <term>PAN_BENT_ARMS_SINGLE_SERIF</term>
		///             <description>Nonstraight arms/single-serif</description>
		///         </item>
		///         <item>
		///             <term>PAN_BENT_ARMS_DOUBLE_SERIF</term>
		///             <description>Nonstraight arms/double-serif</description>
		///         </item>
		///     </list>
		/// </summary>
		public byte bArmStyle;

		/// <summary>
		///     <para>For Latin fonts, one of the following values.</para>
		///     <list type="table">
		///         <item>
		///             <term>PAN_ANY</term>
		///             <description>Any</description>
		///         </item>
		///         <item>
		///             <term>PAN_NO_FIT</term>
		///             <description>No fit</description>
		///         </item>
		///         <item>
		///             <term>PAN_LETT_NORMAL_CONTACT</term>
		///             <description>Normal/contact</description>
		///         </item>
		///         <item>
		///             <term>PAN_LETT_NORMAL_WEIGHTED</term>
		///             <description>Normal/weighted</description>
		///         </item>
		///         <item>
		///             <term>PAN_LETT_NORMAL_BOXED</term>
		///             <description>Normal/boxed</description>
		///         </item>
		///         <item>
		///             <term>PAN_LETT_NORMAL_FLATTENED</term>
		///             <description>Normal/flattened</description>
		///         </item>
		///         <item>
		///             <term>PAN_LETT_NORMAL_ROUNDED</term>
		///             <description>Normal/rounded</description>
		///         </item>
		///         <item>
		///             <term>PAN_LETT_NORMAL_OFF_CENTER</term>
		///             <description>Normal/off center</description>
		///         </item>
		///         <item>
		///             <term>PAN_LETT_NORMAL_SQUARE</term>
		///             <description>Normal/square</description>
		///         </item>
		///         <item>
		///             <term>PAN_LETT_OBLIQUE_CONTACT</term>
		///             <description>Oblique/contact</description>
		///         </item>
		///         <item>
		///             <term>PAN_LETT_OBLIQUE_WEIGHTED</term>
		///             <description>Oblique/weighted</description>
		///         </item>
		///         <item>
		///             <term>PAN_LETT_OBLIQUE_BOXED</term>
		///             <description>Oblique/boxed</description>
		///         </item>
		///         <item>
		///             <term>PAN_LETT_OBLIQUE_FLATTENED</term>
		///             <description>Oblique/flattened</description>
		///         </item>
		///         <item>
		///             <term>PAN_LETT_OBLIQUE_ROUNDED</term>
		///             <description>Oblique/rounded</description>
		///         </item>
		///         <item>
		///             <term>PAN_LETT_OBLIQUE_OFF_CENTER</term>
		///             <description>Oblique/off center</description>
		///         </item>
		///         <item>
		///             <term>PAN_LETT_OBLIQUE_SQUARE</term>
		///             <description>Oblique/square</description>
		///         </item>
		///     </list>
		/// </summary>
		public byte bLetterform;

		/// <summary>
		///     <para>For Latin fonts, one of the following values.</para>
		///     <list type="table">
		///         <item>
		///             <term>PAN_ANY</term>
		///             <description>Any</description>
		///         </item>
		///         <item>
		///             <term>PAN_NO_FIT</term>
		///             <description>No fit</description>
		///         </item>
		///         <item>
		///             <term>PAN_MIDLINE_STANDARD_TRIMMED</term>
		///             <description>Standard/trimmed</description>
		///         </item>
		///         <item>
		///             <term>PAN_MIDLINE_STANDARD_POINTED</term>
		///             <description>Standard/pointed</description>
		///         </item>
		///         <item>
		///             <term>PAN_MIDLINE_STANDARD_SERIFED</term>
		///             <description>Standard/serifed</description>
		///         </item>
		///         <item>
		///             <term>PAN_MIDLINE_HIGH_TRIMMED</term>
		///             <description>High/trimmed</description>
		///         </item>
		///         <item>
		///             <term>PAN_MIDLINE_HIGH_POINTED</term>
		///             <description>High/pointed</description>
		///         </item>
		///         <item>
		///             <term>PAN_MIDLINE_HIGH_SERIFED</term>
		///             <description>High/serifed</description>
		///         </item>
		///         <item>
		///             <term>PAN_MIDLINE_CONSTANT_TRIMMED</term>
		///             <description>Constant/trimmed</description>
		///         </item>
		///         <item>
		///             <term>PAN_MIDLINE_CONSTANT_POINTED</term>
		///             <description>Constant/pointed</description>
		///         </item>
		///         <item>
		///             <term>PAN_MIDLINE_CONSTANT_SERIFED</term>
		///             <description>Constant/serifed</description>
		///         </item>
		///         <item>
		///             <term>PAN_MIDLINE_LOW_TRIMMED</term>
		///             <description>Low/trimmed</description>
		///         </item>
		///         <item>
		///             <term>PAN_MIDLINE_LOW_POINTED</term>
		///             <description>Low/pointed</description>
		///         </item>
		///         <item>
		///             <term>PAN_MIDLINE_LOW_SERIFED</term>
		///             <description>Low/serifed</description>
		///         </item>
		///     </list>
		/// </summary>
		public byte bMidline;

		/// <summary>
		///     <para>For Latin fonts, one of the following values.</para>
		///     <list type="table">
		///         <item>
		///             <term>PAN_ANY</term>
		///             <description>Any</description>
		///         </item>
		///         <item>
		///             <term>PAN_NO_FIT</term>
		///             <description>No fit</description>
		///         </item>
		///         <item>
		///             <term>PAN_XHEIGHT_CONSTANT_SMALL</term>
		///             <description>Constant/small</description>
		///         </item>
		///         <item>
		///             <term>PAN_XHEIGHT_CONSTANT_STD</term>
		///             <description>Constant/standard</description>
		///         </item>
		///         <item>
		///             <term>PAN_XHEIGHT_CONSTANT_LARGE</term>
		///             <description>Constant/large</description>
		///         </item>
		///         <item>
		///             <term>PAN_XHEIGHT_DUCKING_SMALL</term>
		///             <description>Ducking/small</description>
		///         </item>
		///         <item>
		///             <term>PAN_XHEIGHT_DUCKING_STD</term>
		///             <description>Ducking/standard</description>
		///         </item>
		///         <item>
		///             <term>PAN_XHEIGHT_DUCKING_LARGE</term>
		///             <description>Ducking/large</description>
		///         </item>
		///     </list>
		/// </summary>
		public byte bXHeight;
	}

	/// <summary>
	///     The <see cref="RECTL" /> structure defines the coordinates of the upper-left and lower-right corners of a rectangle.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct RECTL
	{
		/// <summary>The x-coordinate of the upper-left corner of the rectangle.</summary>
		public int left;

		/// <summary>The y-coordinate of the upper-left corner of the rectangle.</summary>
		public int top;

		/// <summary>The x-coordinate of the lower-right corner of the rectangle.</summary>
		public int right;

		/// <summary>The y-coordinate of the lower-right corner of the rectangle.</summary>
		public int bottom;
	}

	/// <summary>
	///     The <see cref="CIEXYZTRIPLE" /> structure contains the x, y, and z coordinates of the three colors that correspond to the red, green, and blue
	///     endpoints for a specified logical color space.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct CIEXYZTRIPLE
	{
		/// <summary>The xyz coordinates of red endpoint.</summary>
		public CIEXYZ ciexyzRed;

		/// <summary>The xyz coordinates of green endpoint.</summary>
		public CIEXYZ ciexyzGreen;

		/// <summary>The xyz coordinates of blue endpoint.</summary>
		public CIEXYZ ciexyzBlue;
	}

	/// <summary>
	///     The <see cref="WCRANGE" /> structure specifies a range of Unicode characters.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct WCRANGE
	{
		/// <summary>Low Unicode code point in the range of supported Unicode code points.</summary>
		public ushort wcLow;

		/// <summary>Number of supported Unicode code points in this range.</summary>
		public ushort cGlyphs;
	}

	/// <summary>
	///     The <see cref="CIEXYZ" /> structure contains the x, y, and z coordinates of a specific color in a specified color space.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct CIEXYZ
	{
		/// <summary>The x coordinate in fix point (2.30).</summary>
		public int ciexyzX;

		/// <summary>The y coordinate in fix point (2.30).</summary>
		public int ciexyzY;

		/// <summary>The z coordinate in fix point (2.30).</summary>
		public int ciexyzZ;
	}

	/// <summary>The ABCFLOAT structure contains the A, B, and C widths of a font character.</summary>
	/// <remarks>
	///     <para>The A, B, and C widths are measured along the base line of the font.</para>
	///     <para>
	///         The character increment (total width) of a character is the sum of the A, B, and C spaces. Either the A or the C space can be negative to
	///         indicate underhangs or overhangs.
	///     </para>
	/// </remarks>
	[StructLayout(LayoutKind.Sequential)]
	public struct ABCFloat
	{
		/// <summary>Specifies the A spacing of the character. The A spacing is the distance to add to the current position before drawing the character glyph.</summary>
		public float abcfA;

		/// <summary>Specifies the B spacing of the character. The B spacing is the width of the drawn portion of the character glyph.</summary>
		public float abcfB;

		/// <summary>
		///     Specifies the C spacing of the character. The C spacing is the distance to add to the current position to provide white space to the right of the
		///     character glyph.
		/// </summary>
		public float abcfC;
	}

	// ReSharper restore InconsistentNaming
}