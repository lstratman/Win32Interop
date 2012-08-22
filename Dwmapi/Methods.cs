using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using Win32Interop.Structs;

namespace Win32Interop.Methods
{
    public class Dwmapi
    {
        [DllImport("dwmapi.dll", EntryPoint = "DwmDefWindowProc")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DwmDefWindowProc(
    [In] IntPtr hWnd,
    uint msg,
    uint wParam,
    [MarshalAs(UnmanagedType.SysInt)] int lParam,
    out IntPtr plResult
    );

        [DllImport("dwmapi.dll", EntryPoint = "DwmEnableBlurBehindWindow")]
public static extern int 
DwmEnableBlurBehindWindow(
    IntPtr hWnd, 
    [In] ref DWM_BLURBEHIND pBlurBehind
    );

[DllImport("dwmapi.dll", EntryPoint = "DwmEnableComposition")]
public static extern int 
DwmEnableComposition(
    uint uCompositionAction
    );

[DllImport("dwmapi.dll", EntryPoint = "DwmEnableMMCSS")]
public static extern int  
DwmEnableMMCSS(
    [MarshalAs(UnmanagedType.Bool)] bool fEnableMMCSS
    );

[DllImport("dwmapi.dll", EntryPoint = "DwmExtendFrameIntoClientArea")]
public static extern int 
DwmExtendFrameIntoClientArea(
    IntPtr hWnd,
    [In] ref MARGINS pMarInset
    );

[DllImport("dwmapi.dll", EntryPoint = "DwmGetColorizationColor")]
public static extern int
DwmGetColorizationColor(
    [Out] IntPtr pcrColorization,
    [Out] IntPtr pfOpaqueBlend
    );

[DllImport("dwmapi.dll", EntryPoint = "DwmGetCompositionTimingInfo")]
public static extern int
DwmGetCompositionTimingInfo(
    IntPtr hwnd,
    out DWM_TIMING_INFO pTimingInfo
    );


[DllImport("dwmapi.dll", EntryPoint = "DwmGetWindowAttribute")]
public static extern int
DwmGetWindowAttribute(
    IntPtr hwnd,
    uint dwAttribute,
    [Out] IntPtr pvAttribute, 
    uint cbAttribute
    );

[DllImport("dwmapi.dll", EntryPoint = "DwmIsCompositionEnabled")]
public static extern int 
DwmIsCompositionEnabled(
    [Out] IntPtr pfEnabled
    );

[DllImport("dwmapi.dll", EntryPoint = "DwmModifyPreviousDxFrameDuration")]
public static extern int
DwmModifyPreviousDxFrameDuration(
    IntPtr hwnd, 
    int cRefreshes,
    [MarshalAs(UnmanagedType.Bool)] bool fRelative
    );

[DllImport("dwmapi.dll", EntryPoint = "DwmQueryThumbnailSourceSize")]
public static extern int
DwmQueryThumbnailSourceSize(
    IntPtr hThumbnail, 
    [Out] SIZE pSize
    );

[DllImport("dwmapi.dll", EntryPoint = "DwmRegisterThumbnail")]
public static extern int
DwmRegisterThumbnail(
    IntPtr hwndDestination, 
    IntPtr hwndSource, 
    [Out] IntPtr phThumbnailId
    );

[DllImport("dwmapi.dll", EntryPoint = "DwmSetDxFrameDuration")]
public static extern int
DwmSetDxFrameDuration(
    IntPtr hwnd, 
    int cRefreshes
    );

[DllImport("dwmapi.dll", EntryPoint = "DwmSetPresentParameters")]
public static extern int
DwmSetPresentParameters(
    IntPtr hwnd,
    [Out] DWM_PRESENT_PARAMETERS pPresentParams
    );

[DllImport("dwmapi.dll", EntryPoint = "DwmSetWindowAttribute")]
public static extern int
DwmSetWindowAttribute(
    IntPtr hwnd,
    uint dwAttribute,
    IntPtr pvAttribute, 
    uint cbAttribute
    );

[DllImport("dwmapi.dll", EntryPoint = "DwmUnregisterThumbnail")]
public static extern int
DwmUnregisterThumbnail(
    IntPtr hThumbnailId
    );

[DllImport("dwmapi.dll", EntryPoint = "DwmUpdateThumbnailProperties")]
public static extern int
DwmUpdateThumbnailProperties(
    IntPtr hThumbnailId, 
    [In] ref DWM_THUMBNAIL_PROPERTIES ptnProperties
    );

[DllImport("dwmapi.dll", EntryPoint = "DwmSetIconicThumbnail")]
public static extern int DwmSetIconicThumbnail(
    IntPtr hwnd,
    IntPtr hbmp,
    uint dwSITFlags
    );

[DllImport("dwmapi.dll", EntryPoint = "DwmSetIconicLivePreviewBitmap")]
public static extern int DwmSetIconicLivePreviewBitmap(
    IntPtr hwnd,
    IntPtr hbmp,
    ref Point pptClient,
    uint dwSITFlags
    );

[DllImport("dwmapi.dll", EntryPoint = "DwmInvalidateIconicBitmaps")]
public static extern int DwmInvalidateIconicBitmaps(
    IntPtr hwnd
    );

[DllImport("dwmapi.dll", EntryPoint = "DwmAttachMilContent")]
public static extern int
DwmAttachMilContent(
    [In] IntPtr hwnd
    );

[DllImport("dwmapi.dll", EntryPoint = "DwmDetachMilContent")]
public static extern int
DwmDetachMilContent(
    [In] IntPtr hwnd
    );

[DllImport("dwmapi.dll", EntryPoint = "DwmFlush")]
public static extern int DwmFlush();

[DllImport("dwmapi.dll", EntryPoint = "DwmGetGraphicsStreamTransformHint")]
public static extern int
DwmGetGraphicsStreamTransformHint(
    uint uIndex,
    [Out] IntPtr pTransform
    );

[DllImport("dwmapi.dll", EntryPoint = "DwmGetGraphicsStreamClient")]
public static extern int
DwmGetGraphicsStreamClient(
    uint uIndex,
    out UUID pClientUuid
    );

[DllImport("dwmapi.dll", EntryPoint = "DwmGetTransportAttributes")]
public static extern int
DwmGetTransportAttributes(
    [MarshalAs(UnmanagedType.Bool)] out bool pfIsRemoting,
    [MarshalAs(UnmanagedType.Bool)] out bool pfIsConnected,
    out uint pDwGeneration
    );
    }
}
