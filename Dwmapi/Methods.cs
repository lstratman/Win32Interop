using System;
using System.Runtime.InteropServices;
using Win32Interop.Enums;
using Win32Interop.Structs;

// ReSharper disable CheckNamespace

namespace Win32Interop.Methods
// ReSharper restore CheckNamespace
{
	// ReSharper disable InconsistentNaming
	/// <summary>Collection of native methods in dwmapi.dll.</summary>
	public class Dwmapi
	{
		/// <summary>Default window procedure for Desktop Window Manager (DWM) hit testing within the non-client area.</summary>
		/// <param name="hwnd">A handle to the window procedure that received the message.</param>
		/// <param name="msg">The message.</param>
		/// <param name="wParam">
		///     Specifies additional message information. The content of this parameter depends on the value of the <paramref name="msg" /> parameter.
		/// </param>
		/// <param name="lParam">
		///     Specifies additional message information. The content of this parameter depends on the value of the <paramref name="msg" /> parameter.
		/// </param>
		/// <param name="plResult">A pointer to an LRESULT value that, when this method returns successfully,receives the result of the hit test.</param>
		/// <returns>TRUE if DwmDefWindowProc handled the message; otherwise, FALSE.</returns>
		/// <remarks>
		///     <para>
		///         When creating custom frames that include the standard caption buttons, WM_NCHITTEST and other non-client hit test messages should first be
		///         passed to the DwmDefWindowProc function. This enables the DWM to provide hit testing for the captions buttons. If DwmDefWindowProc does not
		///         handle the non-client hit test messages, further processing of these messages might be necessary.
		///     </para>
		/// </remarks>
		[DllImport("dwmapi.dll", EntryPoint = "DwmDefWindowProc")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool DwmDefWindowProc([In] IntPtr hwnd, uint msg, uint wParam, [MarshalAs(UnmanagedType.SysInt)] int lParam, out IntPtr plResult);

		/// <summary>Enables the blur effect on a specified window.</summary>
		/// <param name="hWnd">The handle to the window on which the blur behind data is applied.</param>
		/// <param name="pBlurBehind">
		///     A pointer to a <see cref="DWM_BLURBEHIND" /> structure that provides blur behind data.
		/// </param>
		/// <returns>If this function succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.</returns>
		/// <remarks>
		///     <para>
		///         Enabling blur by setting the fEnable member of the DWM_BLURBEHIND structure to TRUE. This results in subsequent compositions of the window
		///         blurring the content behind it. This function should be called immediately before a BeginPaint call to ensure prompt application of the
		///         effect.
		///     </para>
		///     <para>
		///         The alpha values in the window are honored and the rendering atop the blur will use these alpha values. It is the application's
		///         responsibility to ensure that the alpha values of all pixels in the window are correct. Some Windows Graphics Device Interface (GDI)
		///         operations do not preserve alpha values, so care must be taken when presenting child windows because the alpha values they contribute are
		///         unpredictable.
		///     </para>
		///     <para>
		///         The region specified within the DWM_BLURBEHIND structure is owned by the caller. It is the caller's responsibility to free the region, and
		///         they can do so as soon as the function call is completed.
		///     </para>
		///     <para>This function can only be called on top-level windows. An error occurs when this function is called on other window types.</para>
		///     <para>
		///         This function must be called whenever Desktop Window Manager (DWM) composition is toggled. Handle the WM_DWMCOMPOSITIONCHANGED message for
		///         composition change notification.
		///     </para>
		/// </remarks>
		[DllImport("dwmapi.dll", EntryPoint = "DwmEnableBlurBehindWindow")]
		public static extern int DwmEnableBlurBehindWindow(IntPtr hWnd, [In] ref DWM_BLURBEHIND pBlurBehind);

		/// <summary>Enables or disables Desktop Window Manager (DWM) composition.</summary>
		/// <param name="uCompositionAction">
		///     <para>DWM_EC_ENABLECOMPOSITION to enable DWM composition; DWM_EC_DISABLECOMPOSITION to disable composition.</para>
		///     <para>
		///         Note  As of Windows 8, calling this function with DWM_EC_DISABLECOMPOSITION has no effect. However, the function will still return a
		///         success code.
		///     </para>
		/// </param>
		/// <returns>If this function succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.</returns>
		/// <remarks>
		///     <para>
		///         Disabling DWM composition disables it for the entire desktop. DWM composition will be automatically enabled when all processes that have
		///         disabled composition have called DwmEnableComposition to enable it or have been terminated. The WM_DWMCOMPOSITIONCHANGED notification is sent
		///         whenever DWM composition is enabled or disabled.
		///     </para>
		/// </remarks>
		[DllImport("dwmapi.dll", EntryPoint = "DwmEnableComposition")]
		public static extern int DwmEnableComposition(uint uCompositionAction);

		/// <summary>
		///     Notifies the Desktop Window Manager (DWM) to opt in to or out of Multimedia Class Schedule Service (MMCSS) scheduling while the calling process
		///     is alive.
		/// </summary>
		/// <param name="fEnableMMCSS">TRUE to instruct DWM to participate in MMCSS scheduling; FALSE to opt out or end participation in MMCSS scheduling.</param>
		/// <returns>If this function succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.</returns>
		/// <remarks>
		///     <para>
		///         DWM will be scheduled by the MMCSS as long as any process that called DwmEnableMMCSS to enable MMCSS is active and has not previously called
		///         DwmEnableMMCSS to disable MMCSS.
		///     </para>
		/// </remarks>
		[DllImport("dwmapi.dll", EntryPoint = "DwmEnableMMCSS")]
		public static extern int DwmEnableMMCSS([MarshalAs(UnmanagedType.Bool)] bool fEnableMMCSS);

		/// <summary>Extends the window frame into the client area.</summary>
		/// <param name="hWnd">The handle to the window in which the frame will be extended into the client area.</param>
		/// <param name="pMarInset">
		///     A pointer to a <see cref="MARGINS" /> structure that describes the margins to use when extending the frame into the client area.
		/// </param>
		/// <returns>If this function succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.</returns>
		/// <remarks>
		///     <para>
		///         This function must be called whenever Desktop Window Manager (DWM) composition is toggled. Handle the WM_DWMCOMPOSITIONCHANGED message for
		///         composition change notification.
		///     </para>
		///     <para>
		///         Use negative margin values to create the "sheet of glass" effect where the client area is rendered as a solid surface with no window
		///         border.
		///     </para>
		/// </remarks>
		[DllImport("dwmapi.dll", EntryPoint = "DwmExtendFrameIntoClientArea")]
		public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, [In] ref MARGINS pMarInset);

		/// <summary>
		///     Retrieves the current color used for Desktop Window Manager (DWM) glass composition. This value is based on the current color scheme and can be
		///     modified by the user. Applications can listen for color changes by handling the WM_DWMCOLORIZATIONCOLORCHANGED notification.
		/// </summary>
		/// <param name="pcrColorization">
		///     A pointer to a value that, when this function returns successfully, receives the current color used for glass composition. The color format of
		///     the value is 0xAARRGGBB.
		/// </param>
		/// <param name="pfOpaqueBlend">
		///     A pointer to a value that, when this function returns successfully, indicates whether the color is an opaque blend. TRUE if the color is an
		///     opaque blend; otherwise, FALSE.
		/// </param>
		/// <returns>If this function succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.</returns>
		/// <remarks>
		///     <para>
		///         The value pointed to by pcrColorization is in an 0xAARRGGBB format. Many Microsoft Win32 APIs, such as COLORREF, use a 0x00BBGGRR format. Be
		///         careful to assure that the intended colors are used.
		///     </para>
		/// </remarks>
		[DllImport("dwmapi.dll", EntryPoint = "DwmGetColorizationColor")]
		public static extern int DwmGetColorizationColor([Out] IntPtr pcrColorization, [Out] IntPtr pfOpaqueBlend);

		/// <summary>Retrieves the current composition timing information for a specified window.</summary>
		/// <param name="hwnd">The handle to the window for which the composition timing information should be retrieved.</param>
		/// <param name="pTimingInfo">
		///     A pointer to a <see cref="DWM_TIMING_INFO" /> structure that, when this function returns successfully, receives the current composition timing
		///     information for the window. The cbSize member of this structure must be set before this function is called.
		/// </param>
		/// <returns>If this function succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.</returns>
		[DllImport("dwmapi.dll", EntryPoint = "DwmGetCompositionTimingInfo")]
		public static extern int DwmGetCompositionTimingInfo(IntPtr hwnd, out DWM_TIMING_INFO pTimingInfo);

		/// <summary>Retrieves the current value of a specified attribute applied to a window.</summary>
		/// <param name="hwnd">The handle to the window from which the attribute data is retrieved.</param>
		/// <param name="dwAttribute">
		///     The attribute to retrieve, specified as a <see cref="DWMWINDOWATTRIBUTE" /> value.
		/// </param>
		/// <param name="pvAttribute">
		///     A pointer to a value that, when this function returns successfully, receives the current value of the attribute. The type of the retrieved value
		///     depends on the value of the <paramref name="dwAttribute" /> parameter.
		/// </param>
		/// <param name="cbAttribute">
		///     The size of the <see cref="DWMWINDOWATTRIBUTE" /> value being retrieved. The size is dependent on the type of the <paramref name="pvAttribute" />
		///     parameter.
		/// </param>
		/// <returns>If this function succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.</returns>
		[DllImport("dwmapi.dll", EntryPoint = "DwmGetWindowAttribute")]
		public static extern int DwmGetWindowAttribute(IntPtr hwnd, DWMWINDOWATTRIBUTE dwAttribute, [Out] IntPtr pvAttribute, uint cbAttribute);

		/// <summary>
		///     Obtains a value that indicates whether Desktop Window Manager (DWM) composition is enabled. Applications can listen for composition state changes
		///     by handling the WM_DWMCOMPOSITIONCHANGED notification.
		/// </summary>
		/// <param name="pfEnabled">
		///     A pointer to a value that, when this function returns successfully, receives TRUE if DWM composition is enabled; otherwise,
		///     FALSE.
		/// </param>
		/// <returns>If this function succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.</returns>
		[DllImport("dwmapi.dll", EntryPoint = "DwmIsCompositionEnabled")]
		public static extern int DwmIsCompositionEnabled(out bool pfEnabled);

		/// <summary>Changes the number of monitor refreshes through which the previous frame will be displayed.</summary>
		/// <param name="hwnd">The handle to the window for which the new duration is applied to the previous frame.</param>
		/// <param name="cRefreshes">The number of refreshes to apply to the previous frame.</param>
		/// <param name="fRelative">
		///     TRUE if the value given in <paramref name="cRefreshes" /> is relative to the current value (added to or subtracted from it); FALSE if the value
		///     replaces the current value.
		/// </param>
		/// <returns>This function always returns S_OK, even when DWM is not running.</returns>
		[DllImport("dwmapi.dll", EntryPoint = "DwmModifyPreviousDxFrameDuration")]
		public static extern int DwmModifyPreviousDxFrameDuration(IntPtr hwnd, int cRefreshes, [MarshalAs(UnmanagedType.Bool)] bool fRelative);

		/// <summary>Retrieves the source size of the Desktop Window Manager (DWM) thumbnail.</summary>
		/// <param name="hThumbnail">A handle to the thumbnail to retrieve the source window size from.</param>
		/// <param name="pSize">
		///     A pointer to a <see cref="SIZE" /> structure that, when this function returns successfully, receives the size of the source thumbnail.
		/// </param>
		/// <returns>If this function succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.</returns>
		[DllImport("dwmapi.dll", EntryPoint = "DwmQueryThumbnailSourceSize")]
		public static extern int DwmQueryThumbnailSourceSize(IntPtr hThumbnail, [Out] SIZE pSize);

		/// <summary>Creates a Desktop Window Manager (DWM) thumbnail relationship between the destination and source windows.</summary>
		/// <param name="hwndDestination">
		///     The handle to the window that will use the DWM thumbnail. Setting the destination window handle to anything other than a top-level window type
		///     will result in a return value of E_INVALIDARG.
		/// </param>
		/// <param name="hwndSource">
		///     The handle to the window to use as the thumbnail source. Setting the source window handle to anything other than a top-level window type will
		///     result in a return value of E_INVALIDARG.
		/// </param>
		/// <param name="phThumbnailId">A pointer to a handle that, when this function returns successfully, represents the registration of the DWM thumbnail.</param>
		/// <returns>If this function succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.</returns>
		/// <remarks>
		///     <para>
		///         Registering a DWM thumbnail relationship will not modify desktop composition; for information about thumbnail positioning, see the
		///         documentation for the DwmUpdateThumbnailProperties function.
		///     </para>
		///     <para>
		///         The window designated by hwndDestination must either be the desktop window itself or be owned by the process that is calling
		///         DwmRegisterThumbnail. This is required to prevent applications from affecting the content of other applications.
		///     </para>
		///     <para>
		///         The thumbnail registration handle obtained by this function is not globally unique but is unique to the process. Call the
		///         DwmUnregisterThumbnail function to unregister the thumbnail. This must be done within the process that the relationship was registered in.
		///     </para>
		/// </remarks>
		[DllImport("dwmapi.dll", EntryPoint = "DwmRegisterThumbnail")]
		public static extern int DwmRegisterThumbnail(IntPtr hwndDestination, IntPtr hwndSource, [Out] IntPtr phThumbnailId);

		/// <summary>Sets the number of monitor refreshes through which to display the presented frame.</summary>
		/// <param name="hwnd">The handle to the window that displays the presented frame.</param>
		/// <param name="cRefreshes">The number of refreshes through which to display the presented frame.</param>
		/// <returns>This function always returns S_OK, even when the frame duration is not changed or DWM is not running.</returns>
		/// <remarks>
		///     <para>
		///         The DWM will attempt to display the presented frame for at least the number of monitor refreshes specified. It might be impossible to display
		///         the frame for the precise number of refreshes due to the current composition rate. If the frame is presented late to the DWM or the DWM is
		///         late in composing, a frame could be displayed for fewer than the number of refreshes requested or even skipped completely.
		///     </para>
		/// </remarks>
		[DllImport("dwmapi.dll", EntryPoint = "DwmSetDxFrameDuration")]
		public static extern int DwmSetDxFrameDuration(IntPtr hwnd, int cRefreshes);

		/// <summary>Sets the present parameters for frame composition.</summary>
		/// <param name="hwnd">The handle to the window where the present parameters are applied.</param>
		/// <param name="pPresentParams">
		///     A pointer to a <see cref="DWM_PRESENT_PARAMETERS" /> structure that contains DWM video frame parameters for frame composition.
		/// </param>
		/// <returns>This function always returns S_OK.</returns>
		[DllImport("dwmapi.dll", EntryPoint = "DwmSetPresentParameters")]
		public static extern int DwmSetPresentParameters(IntPtr hwnd, [Out] DWM_PRESENT_PARAMETERS pPresentParams);

		/// <summary>Sets the value of non-client rendering attributes for a window.</summary>
		/// <param name="hwnd">The handle to the window that will receive the attributes.</param>
		/// <param name="dwAttribute">
		///     A single <see cref="DWMWINDOWATTRIBUTE" /> flag to apply to the window. This parameter specifies the attribute and the
		///     <paramref name="pvAttribute" /> parameter points to the value of that attribute.
		/// </param>
		/// <param name="pvAttribute">
		///     A pointer to the value of the attribute specified in the <paramref name="dwAttribute" /> parameter. Different <see cref="DWMWINDOWATTRIBUTE" />
		///     flags require different value types.
		/// </param>
		/// <param name="cbAttribute">
		///     The size, in bytes, of the value type pointed to by the <paramref name="pvAttribute" /> parameter.
		/// </param>
		/// <returns>If this function succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.</returns>
		/// <remarks>
		///     <para>
		///         Calling this function with the dwAttribute set to DWMWA_NCRENDERING_ENABLED does not set the attribute. DWMWA_NCRENDERING_ENABLED is a "get"
		///         attribute and the resulting call is equivalent to a DwmGetWindowAttribute call. To enable or disable non-client rendering, the
		///         DWMWA_NCRENDERING_POLICY attribute must set to the desired value.
		///     </para>
		///     <para>If Desktop Composition has been disabled, this function returns DWM_E_COMPOSITIONDISABLED.</para>
		/// </remarks>
		[DllImport("dwmapi.dll", EntryPoint = "DwmSetWindowAttribute")]
		public static extern int DwmSetWindowAttribute(IntPtr hwnd, DWMWINDOWATTRIBUTE dwAttribute, IntPtr pvAttribute, uint cbAttribute);

		/// <summary>Removes a Desktop Window Manager (DWM) thumbnail relationship created by the DwmRegisterThumbnail function.</summary>
		/// <param name="hThumbnailId">
		///     The handle to the thumbnail relationship to be removed. Null or non-existent handles will result in a return value of
		///     E_INVALIDARG.
		/// </param>
		/// <returns>If this function succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.</returns>
		/// <remarks>
		///     <para>Unregistering DWM thumbnail relationships must be done within the process that registered the relationships.</para>
		/// </remarks>
		[DllImport("dwmapi.dll", EntryPoint = "DwmUnregisterThumbnail")]
		public static extern int DwmUnregisterThumbnail(IntPtr hThumbnailId);

		/// <summary>Updates the properties for a Desktop Window Manager (DWM) thumbnail.</summary>
		/// <param name="hThumbnailId">
		///     The handle to the DWM thumbnail to be updated. Null or invalid thumbnails, as well as thumbnails owned by other processes will result in a return
		///     value of E_INVALIDARG.
		/// </param>
		/// <param name="ptnProperties">
		///     A pointer to a <see cref="DWM_THUMBNAIL_PROPERTIES" /> structure that contains the new thumbnail properties.
		/// </param>
		/// <returns>If this function succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.</returns>
		/// <remarks>
		///     <para>
		///         Thumbnail relationships created by the DwmRegisterThumbnail function will not be rendered to the destination window until this function is
		///         called. Subsequent calls will update the thumbnail according to the provided properties.
		///     </para>
		/// </remarks>
		[DllImport("dwmapi.dll", EntryPoint = "DwmUpdateThumbnailProperties")]
		public static extern int DwmUpdateThumbnailProperties(IntPtr hThumbnailId, [In] ref DWM_THUMBNAIL_PROPERTIES ptnProperties);

		/// <summary>
		///     Sets a static, iconic bitmap on a window or tab to use as a thumbnail representation. The taskbar can use this bitmap as a thumbnail switch
		///     target for the window or tab.
		/// </summary>
		/// <param name="hwnd">A handle to the window or tab. This window must belong to the calling process.</param>
		/// <param name="hbmp">
		///     A handle to the bitmap to represent the window that <paramref name="hwnd" /> specifies.
		/// </param>
		/// <param name="dwSITFlags">
		///     <para>The display options for the thumbnail. One of the following values:</para>
		///     <list type="table">
		///         <item>
		///             <term>0 (0x00000000)</term>
		///             <description>No frame is displayed around the provided thumbnail.</description>
		///         </item>
		///         <item>
		///             <term>DWM_SIT_DISPLAYFRAME (0x00000001)</term>
		///             <description>Displays a frame around the provided thumbnail.</description>
		///         </item>
		///     </list>
		/// </param>
		/// <returns>If this function succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.</returns>
		/// <remarks>
		///     <para>
		///         An application typically calls the DwmSetIconicThumbnail function after it receives a WM_DWMSENDICONICTHUMBNAIL message for its window. The
		///         thumbnail should not exceed the maximum x-coordinate and y-coordinate that are specified in that message. The thumbnail must also have a
		///         32-bit color depth.
		///     </para>
		///     <para>
		///         The application calls DwmInvalidateIconicBitmaps to indicate to the Desktop Window Manager (DWM) that the iconic thumbnail and live preview
		///         bitmaps are out-of-date and should be refreshed. The DWM then requests new versions from the window when they are needed. However, if the DWM
		///         bitmap cache is full, DWM will not request updated versions.
		///     </para>
		///     <para>
		///         The DWM uses a copy of the bitmap, but the application can release this copy at any time because of memory constraints. If the copy is
		///         released, the window is not notified, but it might receive a subsequent WM_DWMSENDICONICTHUMBNAIL request when its thumbnail is needed again.
		///         The caller retains ownership of the original bitmap and is responsible for freeing the resources that it uses when it is no longer needed.
		///     </para>
		/// </remarks>
		[DllImport("dwmapi.dll", EntryPoint = "DwmSetIconicThumbnail")]
		public static extern int DwmSetIconicThumbnail(IntPtr hwnd, IntPtr hbmp, SIT dwSITFlags);

		/// <summary>
		///     Sets a static, iconic bitmap to display a live preview (also known as a Peek preview) of a window or tab. The taskbar can use this bitmap to show
		///     a full-sized preview of a window or tab.
		/// </summary>
		/// <param name="hwnd">A handle to the window. This window must belong to the calling process.</param>
		/// <param name="hbmp">
		///     A handle to the bitmap to represent the window that <paramref name="hwnd" /> specifies.
		/// </param>
		/// <param name="pptClient">
		///     The offset of a tab window's client region (the content area inside the client window frame) from the host window's frame. This offset enables
		///     the tab window's contents to be drawn correctly in a live preview  when it is drawn without its frame.
		/// </param>
		/// <param name="dwSITFlags">
		///     <para>The display options for the live preview. This parameter can be 0 or the following value.</para>
		///     <list type="table">
		///         <item>
		///             <term>DWM_SIT_DISPLAYFRAME (0x00000001)</term>
		///             <description>0x00000001. Displays a frame around the provided bitmap.</description>
		///         </item>
		///     </list>
		/// </param>
		/// <returns>
		///     Returns S_OK if the function succeeds, or an error value otherwise. Note that because this bitmap is not cached, if the window is not being
		///     previewed when an application calls this function, the function returns a success code but the bitmap is discarded and not used.
		/// </returns>
		/// <remarks>
		///     <para>
		///         A live preview (also known as a Peek preview) of a window appears when a user moves the mouse pointer over the window's thumbnail in the
		///         taskbar or gives the thumbnail focus in the ALT+TAB window. This view is a full-sized view of the window and can be a snapshot or an iconic
		///         representation.
		///     </para>
		///     <para>
		///         A window typically calls the DwmSetIconicLivePreviewBitmap function in response to a WM_DWMSENDICONICLIVEPREVIEWBITMAP message. The returned
		///         bitmap must not be larger than the client area of the window or frame and must have 32-bit color depth.
		///     </para>
		///     <para>
		///         The Desktop Window Manager (DWM) uses a copy of the bitmap, but the caller retains ownership of the original bitmap and is responsible for
		///         freeing the resources that it uses when it is no longer needed. The DWM does not keep its copy of the bitmap when the DWM stops displaying
		///         the live preview representation.
		///     </para>
		/// </remarks>
		[DllImport("dwmapi.dll", EntryPoint = "DwmSetIconicLivePreviewBitmap")]
		public static extern int DwmSetIconicLivePreviewBitmap(IntPtr hwnd, IntPtr hbmp, ref POINT pptClient, SIT dwSITFlags);

		/// <summary>
		///     Called by an application to indicate that all previously provided iconic bitmaps from a window, both thumbnails and peek representations, should
		///     be refreshed.
		/// </summary>
		/// <param name="hwnd">
		///     A handle to the window or tab whose bitmaps are being invalidated through this call. This window must belong to the calling
		///     process.
		/// </param>
		/// <returns>If this function succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.</returns>
		/// <remarks>
		///     <para>
		///         Calling this function causes the Desktop Window Manager (DWM) to invalidate its current bitmaps for the window and request new bitmaps from
		///         the window when they are next needed. DwmInvalidateIconicBitmaps should not be called frequently. Doing so can lead to poor performance as
		///         new bitmaps are created and retrieved.
		///     </para>
		/// </remarks>
		[DllImport("dwmapi.dll", EntryPoint = "DwmInvalidateIconicBitmaps")]
		public static extern int DwmInvalidateIconicBitmaps(IntPtr hwnd);

		/// <summary>
		///     Issues a flush call that blocks the caller until the next present, when all of the Microsoft DirectX surface updates that are currently
		///     outstanding have been made. This compensates for very complex scenes or calling processes with very low priority.
		/// </summary>
		/// <returns>If this function succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.</returns>
		/// <remarks>
		///     <para>
		///         DwmFlush waits for any queued DirectX changes that were queued by the calling application to be drawn to the screen before returning. It does
		///         not flush the entire session rendering batch.
		///     </para>
		/// </remarks>
		[DllImport("dwmapi.dll", EntryPoint = "DwmFlush")]
		public static extern int DwmFlush();

		/// <summary>Retrieves transport attributes.</summary>
		/// <param name="pfIsRemoting">
		///     A pointer to a BOOL value that indicates whether the transport supports remoting. TRUE if the transport supports remoting;
		///     otherwise, FALSE.
		/// </param>
		/// <param name="pfIsConnected">
		///     A pointer to a BOOL value that indicates whether the transport is connected. TRUE if the transport is connected;
		///     otherwise, FALSE.
		/// </param>
		/// <param name="pDwGeneration">A pointer to a DWORD that receives a generation value for the transport.</param>
		/// <returns>If this function succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.</returns>
		[DllImport("dwmapi.dll", EntryPoint = "DwmGetTransportAttributes")]
		public static extern int DwmGetTransportAttributes(
			[MarshalAs(UnmanagedType.Bool)] out bool pfIsRemoting, [MarshalAs(UnmanagedType.Bool)] out bool pfIsConnected, out uint pDwGeneration);
	}

	// ReSharper restore InconsistentNaming
}