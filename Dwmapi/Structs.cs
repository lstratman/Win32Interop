using System;
using System.Runtime.InteropServices;
using Win32Interop.Enums;
using Win32Interop.Methods;

// ReSharper disable CheckNamespace

namespace Win32Interop.Structs
// ReSharper restore CheckNamespace
{
	// ReSharper disable InconsistentNaming
	/// <summary>Specifies Desktop Window Manager (DWM) blur-behind properties. Used by the DwmEnableBlurBehindWindow function.</summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct DWM_BLURBEHIND
	{
		/// <summary>A bitwise combination of DWM Blur Behind constant values that indicates which of the members of this structure have been set.</summary>
		public uint dwFlags;

		/// <summary>TRUE to register the window handle to DWM blur behind; FALSE to unregister the window handle from DWM blur behind.</summary>
		public bool fEnable;

		/// <summary>The region within the client area where the blur behind will be applied. A NULL value will apply the blur behind the entire client area.</summary>
		public IntPtr hRgnBlur;

		/// <summary>TRUE if the window's colorization should transition to match the maximized windows; otherwise, FALSE.</summary>
		public bool fTransitionOnMaximized;
	}

	/// <summary>Specifies Desktop Window Manager (DWM) thumbnail properties. Used by the DwmUpdateThumbnailProperties function.</summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct DWM_THUMBNAIL_PROPERTIES
	{
		/// <summary>A bitwise combination of DWM thumbnail constant values that indicates which members of this structure are set.</summary>
		public uint dwFlags;

		/// <summary>The area in the destination window where the thumbnail will be rendered.</summary>
		public RECT rcDestination;

		/// <summary>The region of the source window to use as the thumbnail. By default, the entire window is used as the thumbnail.</summary>
		public RECT rcSource;

		/// <summary>The opacity with which to render the thumbnail. 0 is fully transparent while 255 is fully opaque. The default value is 255.</summary>
		public byte opacity;

		/// <summary>TRUE to make the thumbnail visible; otherwise, FALSE. The default is FALSE.</summary>
		public bool fVisible;

		/// <summary>TRUE to use only the thumbnail source's client area; otherwise, FALSE. The default is FALSE.</summary>
		public bool fSourceClientAreaOnly;
	}

	/// <summary>
	///     Defines a data type used by the Desktop Window Manager (DWM) APIs. It represents a generic ratio and is used for different purposes and units
	///     even within a single API.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct UNSIGNED_RATIO
	{
		/// <summary>The ratio numerator.</summary>
		public UInt32 uiNumerator;

		/// <summary>The ratio denominator.</summary>
		public UInt32 uiDenominator;
	}

	/// <summary>Specifies Desktop Window Manager (DWM) video frame parameters for frame composition. Used by the DwmSetPresentParameters function.</summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct DWM_PRESENT_PARAMETERS
	{
		/// <summary>
		///     The size of the <see cref="DWM_PRESENT_PARAMETERS" /> structure.
		/// </summary>
		public UInt32 cbSize;

		/// <summary>
		///     TRUE if the caller is requesting queued presents; otherwise, FALSE. If TRUE, the remaining parameters must be specified. If FALSE, queued
		///     presentation is disabled for this window and present behavior returns to the default behavior.
		/// </summary>
		public bool fQueue;

		/// <summary>A ULONGLONG value that provides the refresh number that the next presented frame should begin to display.</summary>
		public UInt64 cRefreshStart;

		/// <summary>The number of frames the application is instructing DWM to queue. The valid range is 2-8.</summary>
		public uint cBuffer;

		/// <summary>
		///     TRUE if the application wants DWM to schedule presentation based on source rate. FALSE if the application will decide how many refreshes to
		///     display for each frame. If TRUE, <see cref="rateSource" /> must be specified. If FALSE, <see cref="cRefreshesPerFrame" /> must be specified.
		/// </summary>
		public bool fUseSourceRate;

		/// <summary>The rate, in frames per second, of the source material being displayed.</summary>
		public UNSIGNED_RATIO rateSource;

		/// <summary>The number of monitor refreshes through which each frame should be displayed on the screen.</summary>
		public uint cRefreshesPerFrame;

		/// <summary>The frame sampling type to use for composition.</summary>
		public DWM_SOURCE_FRAME_SAMPLING eSampling;
	}

	/// <summary>Specifies Desktop Window Manager (DWM) composition timing information. Used by the DwmGetCompositionTimingInfo function.</summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct DWM_TIMING_INFO
	{
		/// <summary>
		///     The size of this <see cref="DWM_TIMING_INFO" /> structure.
		/// </summary>
		public UInt32 cbSize;

		/// <summary>The monitor refresh rate.</summary>
		public UNSIGNED_RATIO rateRefresh;

		/// <summary>The monitor refresh period.</summary>
		public UInt64 qpcRefreshPeriod;

		/// <summary>The composition rate.</summary>
		public UNSIGNED_RATIO rateCompose;

		/// <summary>The query performance counter value before the vertical blank.</summary>
		public UInt64 qpcVBlank;

		/// <summary>The DWM refresh counter.</summary>
		public UInt64 cRefresh;

		/// <summary>The DirectX refresh counter.</summary>
		public uint cDXRefresh;

		/// <summary>The query performance counter value for a frame composition.</summary>
		public UInt64 qpcCompose;

		/// <summary>
		///     The frame number that was composed at <see cref="qpcCompose" />.
		/// </summary>
		public UInt64 cFrame;

		/// <summary>The DirectX present number used to identify rendering frames.</summary>
		public uint cDXPresent;

		/// <summary>
		///     The refresh count of the frame that was composed at <see cref="qpcCompose" />.
		/// </summary>
		public UInt64 cRefreshFrame;

		/// <summary>The DWM frame number that was last submitted.</summary>
		public UInt64 cFrameSubmitted;

		/// <summary>The DirectX present number that was last submitted.</summary>
		public uint cDXPresentSubmitted;

		/// <summary>The DWM frame number that was last confirmed as presented.</summary>
		public UInt64 cFrameConfirmed;

		/// <summary>The DirectX present number that was last confirmed as presented.</summary>
		public uint cDXPresentConfirmed;

		/// <summary>The target refresh count of the last frame confirmed as completed by the GPU.</summary>
		public UInt64 cRefreshConfirmed;

		/// <summary>The DirectX refresh count when the frame was confirmed as presented.</summary>
		public uint cDXRefreshConfirmed;

		/// <summary>The number of frames the DWM presented late.</summary>
		public UInt64 cFramesLate;

		/// <summary>The number of composition frames that have been issued but have not been confirmed as completed.</summary>
		public uint cFramesOutstanding;

		/// <summary>The last frame displayed.</summary>
		public UInt64 cFrameDisplayed;

		/// <summary>The QPC time of the composition pass when the frame was displayed.</summary>
		public UInt64 qpcFrameDisplayed;

		/// <summary>The vertical refresh count when the frame should have become visible.</summary>
		public UInt64 cRefreshFrameDisplayed;

		/// <summary>The ID of the last frame marked as completed.</summary>
		public UInt64 cFrameComplete;

		/// <summary>The QPC time when the last frame was marked as completed.</summary>
		public UInt64 qpcFrameComplete;

		/// <summary>The ID of the last frame marked as pending.</summary>
		public UInt64 cFramePending;

		/// <summary>The QPC time when the last frame was marked as pending.</summary>
		public UInt64 qpcFramePending;

		/// <summary>
		///     The number of unique frames displayed. This value is valid only after a second call to the <see cref="Dwmapi.DwmGetCompositionTimingInfo" />
		///     function.
		/// </summary>
		public UInt64 cFramesDisplayed;

		/// <summary>The number of new completed frames that have been received.</summary>
		public UInt64 cFramesComplete;

		/// <summary>The number of new frames submitted to DirectX but not yet completed.</summary>
		public UInt64 cFramesPending;

		/// <summary>
		///     The number of frames available but not displayed, used, or dropped. This value is valid only after a second call to
		///     <see cref="Dwmapi.DwmGetCompositionTimingInfo" />.
		/// </summary>
		public UInt64 cFramesAvailable;

		/// <summary>
		///     The number of rendered frames that were never displayed because composition occurred too late. This value is valid only after a second call to
		///     <see cref="Dwmapi.DwmGetCompositionTimingInfo" />.
		/// </summary>
		public UInt64 cFramesDropped;

		/// <summary>The number of times an old frame was composed when a new frame should have been used but was not available.</summary>
		public UInt64 cFramesMissed;

		/// <summary>The frame count at which the next frame is scheduled to be displayed.</summary>
		public UInt64 cRefreshNextDisplayed;

		/// <summary>The frame count at which the next DirectX present is scheduled to be displayed.</summary>
		public UInt64 cRefreshNextPresented;

		/// <summary>
		///     The total number of refreshes that have been displayed for the application since the <see cref="Dwmapi.DwmSetPresentParameters" /> function was
		///     last called.
		/// </summary>
		public UInt64 cRefreshesDisplayed;

		/// <summary>
		///     The total number of refreshes that have been presented by the application since <see cref="Dwmapi.DwmSetPresentParameters" /> was last called.
		/// </summary>
		public UInt64 cRefreshesPresented;

		/// <summary>The refresh number when content for this window started to be displayed.</summary>
		public UInt64 cRefreshStarted;

		/// <summary>The total number of pixels DirectX redirected to the DWM.</summary>
		public UInt64 cPixelsReceived;

		/// <summary>The number of pixels drawn.</summary>
		public UInt64 cPixelsDrawn;

		/// <summary>The number of empty buffers in the flip chain.</summary>
		public UInt64 cBuffersEmpty;
	}

	// ReSharper restore InconsistentNaming
}