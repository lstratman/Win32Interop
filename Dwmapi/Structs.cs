using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Win32Interop.Enums;

namespace Win32Interop.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct DWM_BLURBEHIND
    {
        uint dwFlags;
        bool fEnable;
        IntPtr hRgnBlur;
        bool fTransitionOnMaximized;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DWM_THUMBNAIL_PROPERTIES
    {
        uint dwFlags;
        RECT rcDestination;
        RECT rcSource;
        byte opacity;
        bool fVisible;
        bool fSourceClientAreaOnly;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct UNSIGNED_RATIO
    {
        UInt32 uiNumerator;
        UInt32 uiDenominator;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DWM_PRESENT_PARAMETERS
    {
        UInt32 cbSize;
        bool fQueue;
        UInt64 cRefreshStart;
        uint cBuffer;
        bool fUseSourceRate;
        UNSIGNED_RATIO rateSource;
        uint cRefreshesPerFrame;
        DWM_SOURCE_FRAME_SAMPLING eSampling;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DWM_TIMING_INFO
    {
            UInt32 cbSize;

        // Data on DWM composition overall
    
        // Monitor refresh rate
        UNSIGNED_RATIO  rateRefresh;

        // Actual period
        UInt64        qpcRefreshPeriod;

        // composition rate     
        UNSIGNED_RATIO  rateCompose;

        // QPC time at a VSync interupt
        UInt64        qpcVBlank;

        // DWM refresh count of the last vsync
        // DWM refresh count is a 64bit number where zero is
        // the first refresh the DWM woke up to process
        UInt64 cRefresh;

        // DX refresh count at the last Vsync Interupt
        // DX refresh count is a 32bit number with zero 
        // being the first refresh after the card was initialized
        // DX increments a counter when ever a VSync ISR is processed
        // It is possible for DX to miss VSyncs
        //
        // There is not a fixed mapping between DX and DWM refresh counts
        // because the DX will rollover and may miss VSync interupts
        uint cDXRefresh;

        // QPC time at a compose time.  
        UInt64        qpcCompose;

        // Frame number that was composed at qpcCompose
        UInt64 cFrame;

        // The present number DX uses to identify renderer frames
        uint            cDXPresent;

        // Refresh count of the frame that was composed at qpcCompose
        UInt64 cRefreshFrame;


        // DWM frame number that was last submitted
        UInt64 cFrameSubmitted;

        // DX Present number that was last submitted
        uint cDXPresentSubmitted;

        // DWM frame number that was last confirmed presented
        UInt64 cFrameConfirmed;

        // DX Present number that was last confirmed presented
        uint cDXPresentConfirmed;

        // The target refresh count of the last
        // frame confirmed completed by the GPU
        UInt64 cRefreshConfirmed;

        // DX refresh count when the frame was confirmed presented
        uint cDXRefreshConfirmed;

        // Number of frames the DWM presented late
        // AKA Glitches
        UInt64          cFramesLate;
    
        // the number of composition frames that 
        // have been issued but not confirmed completed
        uint          cFramesOutstanding;


        // Following fields are only relavent when an HWND is specified
        // Display frame


        // Last frame displayed
        UInt64 cFrameDisplayed;

        // QPC time of the composition pass when the frame was displayed
        UInt64        qpcFrameDisplayed; 

        // Count of the VSync when the frame should have become visible
        UInt64 cRefreshFrameDisplayed;

        // Complete frames: DX has notified the DWM that the frame is done rendering

        // ID of the the last frame marked complete (starts at 0)
        UInt64 cFrameComplete;

        // QPC time when the last frame was marked complete
        UInt64        qpcFrameComplete;

        // Pending frames:
        // The application has been submitted to DX but not completed by the GPU
 
        // ID of the the last frame marked pending (starts at 0)
        UInt64 cFramePending;

        // QPC time when the last frame was marked pending
        UInt64        qpcFramePending;

        // number of unique frames displayed
        UInt64 cFramesDisplayed;

        // number of new completed frames that have been received
        UInt64 cFramesComplete;

         // number of new frames submitted to DX but not yet complete
        UInt64 cFramesPending;

        // number of frames available but not displayed, used or dropped
        UInt64 cFramesAvailable;

        // number of rendered frames that were never
        // displayed because composition occured too late
        UInt64 cFramesDropped;
    
        // number of times an old frame was composed 
        // when a new frame should have been used
        // but was not available
        UInt64 cFramesMissed;
    
        // the refresh at which the next frame is
        // scheduled to be displayed
        UInt64 cRefreshNextDisplayed;

        // the refresh at which the next DX present is 
        // scheduled to be displayed
        UInt64 cRefreshNextPresented;

        // The total number of refreshes worth of content
        // for this HWND that have been displayed by the DWM
        // since DwmSetPresentParameters was called
        UInt64 cRefreshesDisplayed;
	
        // The total number of refreshes worth of content
        // that have been presented by the application
        // since DwmSetPresentParameters was called
        UInt64 cRefreshesPresented;


        // The actual refresh # when content for this
        // window started to be displayed
        // it may be different than that requested
        // DwmSetPresentParameters
        UInt64 cRefreshStarted;

        // Total number of pixels DX redirected
        // to the DWM.
        // If Queueing is used the full buffer
        // is transfered on each present.
        // If not queuing it is possible only 
        // a dirty region is updated
        UInt64  cPixelsReceived;

        // Total number of pixels drawn.
        // Does not take into account if
        // if the window is only partial drawn
        // do to clipping or dirty rect management 
        UInt64  cPixelsDrawn;

        // The number of buffers in the flipchain
        // that are empty.   An application can 
        // present that number of times and guarantee 
        // it won't be blocked waiting for a buffer to 
        // become empty to present to
        UInt64      cBuffersEmpty;

    }

    [StructLayout(LayoutKind.Sequential)]
    public struct UUID
    {
        public uint Data1;
        public ushort Data2;
        public ushort Data3;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public byte[] Data4;
    }
}
