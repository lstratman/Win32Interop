using Win32Interop.Methods;
using Win32Interop.Structs;

// ReSharper disable CheckNamespace

namespace Win32Interop.Enums
// ReSharper restore CheckNamespace
{
	// ReSharper disable InconsistentNaming
	/// <summary>
	///     Flags used by the <see cref="Dwmapi.DwmSetPresentParameters" /> function to specify the frame sampling type.
	/// </summary>
	public enum DWM_SOURCE_FRAME_SAMPLING
	{
		/// <summary>Use the first source frame that includes the first refresh of the output frame.</summary>
		DWM_SOURCE_FRAME_SAMPLING_POINT,

		/// <summary>
		///     Use the source frame that includes the most refreshes of the output frame. In the case of multiple source frames with the same coverage, the last
		///     frame is used.
		/// </summary>
		DWM_SOURCE_FRAME_SAMPLING_COVERAGE,

		/// <summary>
		///     The maximum recognized <see cref="DWM_SOURCE_FRAME_SAMPLING" /> value, used for validation purposes.
		/// </summary>
		DWM_SOURCE_FRAME_SAMPLING_LAST
	}

	/// <summary>The display options for the thumbnail.</summary>
	public enum SIT
	{
		/// <summary>No frame is displayed around the provided thumbnail.</summary>
		DWM_SIT_NOFRAME = 0,

		/// <summary>Displays a frame around the provided thumbnail.</summary>
		DWM_SIT_DISPLAYFRAME = 1
	}

	/// <summary>
	///     Flags used by the <see cref="Dwmapi.DwmGetWindowAttribute" /> and <see cref="Dwmapi.DwmSetWindowAttribute" /> functions to specify window
	///     attributes for non-client rendering.
	/// </summary>
	public enum DWMWINDOWATTRIBUTE
	{
		/// <summary>
		///     Use with<see cref="Dwmapi.DwmGetWindowAttribute" />. Discovers whether non-client rendering is enabled. The retrieved value is of type BOOL. TRUE
		///     if non-client rendering is enabled; otherwise, FALSE.
		/// </summary>
		DWMWA_NCRENDERING_ENABLED = 1,

		/// <summary>
		///     Use with <see cref="Dwmapi.DwmSetWindowAttribute" />\. Sets the non-client rendering policy. The pvAttribute parameter points to a value from the
		///     <see cref="DWMNCRENDERINGPOLICY" /> enumeration.
		/// </summary>
		DWMWA_NCRENDERING_POLICY,

		/// <summary>
		///     Use with <see cref="Dwmapi.DwmSetWindowAttribute" />. Enables or forcibly disables DWM transitions. The pvAttribute parameter points to a value
		///     of TRUE to disable transitions or FALSE to enable transitions.
		/// </summary>
		DWMWA_TRANSITIONS_FORCEDISABLED,

		/// <summary>
		///     Use with <see cref="Dwmapi.DwmSetWindowAttribute" />. Enables content rendered in the non-client area to be visible on the frame drawn by DWM.
		///     The pvAttribute parameter points to a value of TRUE to enable content rendered in the non-client area to be visible on the frame; otherwise, it
		///     points to FALSE.
		/// </summary>
		DWMWA_ALLOW_NCPAINT,

		/// <summary>
		///     Use with <see cref="Dwmapi.DwmGetWindowAttribute" />. Retrieves the bounds of the caption button area in the window-relative space. The retrieved
		///     value is of type RECT.
		/// </summary>
		DWMWA_CAPTION_BUTTON_BOUNDS,

		/// <summary>
		///     Use with <see cref="Dwmapi.DwmSetWindowAttribute" />. Specifies whether non-client content is right-to-left (RTL) mirrored. The pvAttribute
		///     parameter points to a value of TRUE if the non-client content is right-to-left (RTL) mirrored; otherwise, it points to FALSE.
		/// </summary>
		DWMWA_NONCLIENT_RTL_LAYOUT,

		/// <summary>
		///     Use with <see cref="Dwmapi.DwmSetWindowAttribute" /> . Forces the window to display an iconic thumbnail or peek representation (a static bitmap),
		///     even if a live or snapshot representation of the window is available. This value normally is set during a window's creation and not changed
		///     throughout the window's lifetime. Some scenarios, however, might require the value to change over time. The pvAttribute parameter points to a
		///     value of TRUE to require a iconic thumbnail or peek representation; otherwise, it points to FALSE.
		/// </summary>
		DWMWA_FORCE_ICONIC_REPRESENTATION,

		/// <summary>
		///     Use with <see cref="Dwmapi.DwmSetWindowAttribute" />. Sets how Flip3D treats the window. The pvAttribute parameter points to a value from the
		///     <see cref="DWMFLIP3DWINDOWPOLICY" /> enumeration.
		/// </summary>
		DWMWA_FLIP3D_POLICY,

		/// <summary>
		///     Use with <see cref="Dwmapi.DwmGetWindowAttribute" />. Retrieves the extended frame bounds rectangle in screen space. The retrieved value is of
		///     type <see cref="RECT" />.
		/// </summary>
		DWMWA_EXTENDED_FRAME_BOUNDS,

		/// <summary>
		///     Use with<see cref="Dwmapi.DwmSetWindowAttribute" />. The window will provide a bitmap for use by DWM as an iconic thumbnail or peek
		///     representation (a static bitmap) for the window. <see cref="DWMWA_HAS_ICONIC_BITMAP" /> can be specified with
		///     <see cref="DWMWA_FORCE_ICONIC_REPRESENTATION" />. <see cref="DWMWA_HAS_ICONIC_BITMAP" /> normally is set during a window's creation and not
		///     changed throughout the window's lifetime. Some scenarios, however, might require the value to change over time. The pvAttribute parameter points
		///     to a value of TRUE to inform DWM that the window will provide an iconic thumbnail or peek representation; otherwise, it points to FALSE.
		/// </summary>
		DWMWA_HAS_ICONIC_BITMAP,

		/// <summary>
		///     Use with <see cref="Dwmapi.DwmSetWindowAttribute" />. Do not show peek preview for the window. The peek view shows a full-sized preview of the
		///     window when the mouse hovers over the window's thumbnail in the taskbar. If this attribute is set, hovering the mouse pointer over the window's
		///     thumbnail dismisses peek (in case another window in the group has a peek preview showing). The pvAttribute parameter points to a value of TRUE to
		///     prevent peek functionality or FALSE to allow it.
		/// </summary>
		DWMWA_DISALLOW_PEEK,

		/// <summary>
		///     Use with <see cref="Dwmapi.DwmSetWindowAttribute" />. Prevents a window from fading to a glass sheet when peek is invoked. The pvAttribute
		///     parameter points to a value of TRUE to prevent the window from fading during another window's peek or FALSE for normal behavior.
		/// </summary>
		DWMWA_EXCLUDED_FROM_PEEK,

		/// <summary>
		///     The maximum recognized <see cref="DWMWINDOWATTRIBUTE" /> value, used for validation purposes.
		/// </summary>
		DWMWA_LAST
	};

	/// <summary>
	///     Flags used by the <see cref="Dwmapi.DwmSetWindowAttribute" /> function to specify the non-client area rendering policy.
	/// </summary>
	public enum DWMNCRENDERINGPOLICY
	{
		/// <summary>The non-client rendering area is rendered based on the window style.</summary>
		DWMNCRP_USEWINDOWSTYLE,

		/// <summary>The non-client area rendering is disabled; the window style is ignored.</summary>
		DWMNCRP_DISABLED,

		/// <summary>The non-client area rendering is enabled; the window style is ignored.</summary>
		DWMNCRP_ENABLED,

		/// <summary>
		///     The maximum recognized <see cref="DWMNCRENDERINGPOLICY" /> value, used for validation purposes.
		/// </summary>
		DWMNCRP_LAST
	};

	/// <summary>
	///     Flags used by the <see cref="Dwmapi.DwmSetWindowAttribute" /> function to specify the Flip3D window policy.
	/// </summary>
	/// <remarks>
	///     To use a <see cref="DWMFLIP3DWINDOWPOLICY" /> value, set the dwAttribute parameter of the <see cref="Dwmapi.DwmSetWindowAttribute" /> function to
	///     <see cref="DWMWINDOWATTRIBUTE.DWMWA_FLIP3D_POLICY" />. Set the pvAttribute parameter to the <see cref="DWMFLIP3DWINDOWPOLICY" /> value.
	/// </remarks>
	public enum DWMFLIP3DWINDOWPOLICY
	{
		/// <summary>Use the window's style and visibility settings to determine whether to hide or include the window in Flip3D rendering.</summary>
		DWMFLIP3D_DEFAULT,

		/// <summary>Exclude the window from Flip3D and display it below the Flip3D rendering.</summary>
		DWMFLIP3D_EXCLUDEBELOW,

		/// <summary>Exclude the window from Flip3D and display it above the Flip3D rendering.</summary>
		DWMFLIP3D_EXCLUDEABOVE,

		/// <summary>
		///     The maximum recognized <see cref="DWMFLIP3DWINDOWPOLICY" /> value, used for validation purposes.
		/// </summary>
		DWMFLIP3D_LAST
	}

	// ReSharper restore InconsistentNaming
}