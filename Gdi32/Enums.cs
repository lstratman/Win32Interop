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

	// ReSharper restore InconsistentNaming
}