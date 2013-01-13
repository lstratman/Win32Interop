using System;

// ReSharper disable CheckNamespace

namespace Win32Interop.Enums
// ReSharper restore CheckNamespace
{
	// ReSharper disable InconsistentNaming
	/// <summary>
	///     The alpha-blending function for source and destination bitmaps, a global alpha value to be applied to the entire source bitmap, and format
	///     information for the source bitmap.
	/// </summary>
	public enum AC
	{
		/// <summary>The source bitmap is placed over the destination bitmap based on the alpha values of the source pixels.</summary>
		AC_SRC_OVER = 0x00,

		/// <summary>
		///     This flag is set when the bitmap has an Alpha channel (that is, per-pixel alpha). Note that the APIs use premultiplied alpha, which means that
		///     the red, green and blue channel values in the bitmap must be premultiplied with the alpha channel value. For example, if the alpha channel value
		///     is x, the red, green and blue channels must be multiplied by x and divided by 0xff prior to the call.
		/// </summary>
		AC_SRC_ALPHA = 0x01
	}

	/// <summary>
	///     The weight of the font in the range 0 through 1000. For example, 400 is normal and 700 is bold. If this value is zero, a default weight is
	///     used.
	/// </summary>
	public enum FW
	{
		/// <summary>Don't care about the font weight.</summary>
		FW_DONTCARE = 0,

		/// <summary>Specifies a thin font weight.</summary>
		FW_THIN = 100,

		/// <summary>Specifies an extra light font weight.</summary>
		FW_EXTRALIGHT = 200,

		/// <summary>Specifies a light font weight.</summary>
		FW_LIGHT = 300,

		/// <summary>Specifies a normal font weight.</summary>
		FW_NORMAL = 400,

		/// <summary>Specifies a medium font weight.</summary>
		FW_MEDIUM = 500,

		/// <summary>Specifies a semi-bold font weight.</summary>
		FW_SEMIBOLD = 600,

		/// <summary>Specifies a bold font weight.</summary>
		FW_BOLD = 700,

		/// <summary>Specifies an extra-bold font weight.</summary>
		FW_EXTRABOLD = 800,

		/// <summary>Specifies a heavy font weight.</summary>
		FW_HEAVY = 900,
	}

	/// <summary>
	///     The <see cref="CHARSET" /> Enumeration defines the possible sets of character glyphs that are defined in fonts for graphics output.
	/// </summary>
	public enum CHARSET : byte
	{
		/// <summary>Specifies the English character set.</summary>
		ANSI_CHARSET = 0,

		/// <summary>
		///     Specifies a character set based on the current system locale; for example, when the system locale is United States English, the default character
		///     set is <see cref="ANSI_CHARSET" />.
		/// </summary>
		DEFAULT_CHARSET = 1,

		/// <summary>Specifies a character set of symbols.</summary>
		SYMBOL_CHARSET = 2,

		/// <summary>Specifies the Japanese character set.</summary>
		SHIFTJIS_CHARSET = 128,

		/// <summary>Specifies the Hangul Korean character set.</summary>
		HANGEUL_CHARSET = 129,

		/// <summary>Also spelled "Hangeul". Specifies the Hangul Korean character set.</summary>
		HANGUL_CHARSET = 129,

		/// <summary>Specifies the "simplified" Chinese character set for People's Republic of China.</summary>
		GB2312_CHARSET = 134,

		/// <summary>Specifies the "traditional" Chinese character set, used mostly in Taiwan and in the Hong Kong and Macao Special Administrative Regions.</summary>
		CHINESEBIG5_CHARSET = 136,

		/// <summary>Specifies a mapping to one of the OEM code pages, according to the current system locale setting.</summary>
		OEM_CHARSET = 255,

		/// <summary>Also spelled "Johap". Specifies the Johab Korean character set.</summary>
		JOHAB_CHARSET = 130,

		/// <summary>Specifies the Hebrew character set.</summary>
		HEBREW_CHARSET = 177,

		/// <summary>Specifies the Arabic character set.</summary>
		ARABIC_CHARSET = 178,

		/// <summary>Specifies the Greek character set.</summary>
		GREEK_CHARSET = 161,

		/// <summary>Specifies the Turkish character set.</summary>
		TURKISH_CHARSET = 162,

		/// <summary>Specifies the Vietnamese character set.</summary>
		VIETNAMESE_CHARSET = 163,

		/// <summary>Specifies the Thai character set.</summary>
		THAI_CHARSET = 222,

		/// <summary>Specifies a Eastern European character set.</summary>
		EASTEUROPE_CHARSET = 238,

		/// <summary>Specifies the Russian Cyrillic character set.</summary>
		RUSSIAN_CHARSET = 204,

		/// <summary>Specifies the Apple Macintosh character set.</summary>
		MAC_CHARSET = 77,

		/// <summary>Specifies the Baltic (Northeastern European) character set</summary>
		BALTIC_CHARSET = 186,
	}

	/// <summary>
	///     The output precision. The output precision defines how closely the output must match the requested font's height, width, character orientation,
	///     escapement, pitch, and font type.
	/// </summary>
	public enum PRECIS : byte
	{
		/// <summary>The default font mapper behavior.</summary>
		OUT_DEFAULT_PRECIS = 0,

		/// <summary>This value is not used by the font mapper, but it is returned when raster fonts are enumerated.</summary>
		OUT_STRING_PRECIS = 1,

		/// <summary>Not used.</summary>
		OUT_CHARACTER_PRECIS = 2,

		/// <summary>This value is not used by the font mapper, but it is returned when TrueType, other outline-based fonts, and vector fonts are enumerated.</summary>
		OUT_STROKE_PRECIS = 3,

		/// <summary>Instructs the font mapper to choose a TrueType font when the system contains multiple fonts with the same name.</summary>
		OUT_TT_PRECIS = 4,

		/// <summary>Instructs the font mapper to choose a Device font when the system contains multiple fonts with the same name.</summary>
		OUT_DEVICE_PRECIS = 5,

		/// <summary>Instructs the font mapper to choose a raster font when the system contains multiple fonts with the same name.</summary>
		OUT_RASTER_PRECIS = 6,

		/// <summary>
		///     Instructs the font mapper to choose from only TrueType fonts. If there are no TrueType fonts installed in the system, the font mapper returns to
		///     default behavior.
		/// </summary>
		OUT_TT_ONLY_PRECIS = 7,

		/// <summary>This value instructs the font mapper to choose from TrueType and other outline-based fonts.</summary>
		OUT_OUTLINE_PRECIS = 8,

		/// <summary>A value that specifies a preference for TrueType and other outline fonts.</summary>
		OUT_SCREEN_OUTLINE_PRECIS = 9,

		/// <summary>
		///     Instructs the font mapper to choose from only PostScript fonts. If there are no PostScript fonts installed in the system, the font mapper returns
		///     to default behavior.
		/// </summary>
		OUT_PS_ONLY_PRECIS = 10,
	}

	/// <summary>The clipping precision. The clipping precision defines how to clip characters that are partially outside the clipping region.</summary>
	public enum CLIP : byte
	{
		/// <summary>Not used.</summary>
		CLIP_DEFAULT_PRECIS = 0,

		/// <summary>Specifies default clipping behavior.</summary>
		CLIP_CHARACTER_PRECIS = 1,

		/// <summary>
		///     <para>Not used by the font mapper, but is returned when raster, vector, or TrueType fonts are enumerated.</para>
		///     <para>For compatibility, this value is always returned when enumerating fonts.</para>
		/// </summary>
		CLIP_STROKE_PRECIS = 2,

		/// <summary>Not used.</summary>
		CLIP_MASK = 0xf,

		/// <summary>
		///     <para>
		///         When this value is used, the rotation for all fonts depends on whether the orientation of the coordinate system is left-handed or
		///         right-handed.
		///     </para>
		///     <para>
		///         If not used, device fonts always rotate counterclockwise, but the rotation of other fonts is dependent on the orientation of the coordinate
		///         system.
		///     </para>
		///     <para>For more information about the orientation of coordinate systems, see the description of the nOrientation parameter.</para>
		/// </summary>
		CLIP_LH_ANGLES = (1 << 4),

		/// <summary>Not used.</summary>
		CLIP_TT_ALWAYS = (2 << 4),

		/// <summary>
		///     Windows XP SP1: Turns off font association for the font. Note that this flag is not guaranteed to have any effect on any platform after Windows
		///     Server 2003.
		/// </summary>
		CLIP_DFA_DISABLE = (4 << 4),

		/// <summary>You must specify this flag to use an embedded read-only font.</summary>
		CLIP_EMBEDDED = (8 << 4),
	}

	/// <summary>
	///     The <see cref="QUALITY" /> Enumeration specifies how closely the attributes of the logical font should match those of the physical font when
	///     rendering text.
	/// </summary>
	public enum QUALITY : byte
	{
		/// <summary>
		///     Specifies that the character quality of the font does not matter, so <see cref="DRAFT_QUALITY" /> can be used.
		/// </summary>
		DEFAULT_QUALITY = 0,

		/// <summary>
		///     Specifies that the character quality of the font is less important than the matching of logical attributes. For rasterized fonts, scaling SHOULD
		///     be enabled, which means that more font sizes are available.
		/// </summary>
		DRAFT_QUALITY = 1,

		/// <summary>
		///     Specifies that the character quality of the font is more important than the matching of logical attributes. For rasterized fonts, scaling SHOULD
		///     be disabled, and the font closest in size SHOULD be chosen.
		/// </summary>
		PROOF_QUALITY = 2,

		/// <summary>Specifies that anti-aliasing SHOULD NOT be used when rendering text.</summary>
		NONANTIALIASED_QUALITY = 3,

		/// <summary>Specifies that anti-aliasing SHOULD be used when rendering text, if the font supports it.</summary>
		ANTIALIASED_QUALITY = 4,

		/// <summary>Specifies that ClearType anti-aliasing SHOULD be used when rendering text, if the font supports it.</summary>
		CLEARTYPE_QUALITY = 5,

		/// <summary>Specifies that high-quality ClearType anti-aliasing SHOULD be used when rendering text, if the font supports it.</summary>
		CLEARTYPE_NATURAL_QUALITY = 6,
	}

	/// <summary>
	///     The PitchFont enumeration defines values that are used for specifying characteristics of a font. The values are used to indicate whether the
	///     characters in a font have a fixed or variable width, or pitch.
	/// </summary>
	[Flags]
	public enum PITCH_FAMILY : byte
	{
		/// <summary>The default pitch, which is implementation-dependent.</summary>
		DEFAULT_PITCH = 0,

		/// <summary>A fixed pitch, which means that all the characters in the font occupy the same width when output in a string.</summary>
		FIXED_PITCH = 1,

		/// <summary>
		///     A variable pitch, which means that the characters in the font occupy widths that are proportional to the actual widths of the glyphs when output
		///     in a string. For example, the "i" and space characters usually have much smaller widths than a "W" or "O" character.
		/// </summary>
		VARIABLE_PITCH = 2,

		/// <summary>Specifies that we don't care about the font family.</summary>
		FF_DONTCARE = (0 << 4),

		/// <summary>Specifies a Roman font family.</summary>
		FF_ROMAN = (1 << 4),

		/// <summary>Specifies a Swiss font family.</summary>
		FF_SWISS = (2 << 4),

		/// <summary>Specifies a Modern font family.</summary>
		FF_MODERN = (3 << 4),

		/// <summary>Specifies a Script font family.</summary>
		FF_SCRIPT = (4 << 4),

		/// <summary>Species a Decorative font family.</summary>
		FF_DECORATIVE = (5 << 4),
	}

	// ReSharper restore InconsistentNaming
}