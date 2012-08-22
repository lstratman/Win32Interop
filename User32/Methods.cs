using System;
using System.Runtime.InteropServices;
using System.Text;
using Win32Interop.Structs;

// ReSharper disable CheckNamespace
namespace Win32Interop.Methods
// ReSharper restore CheckNamespace
{
    // ReSharper disable InconsistentNaming

    /// Return Type: BOOL->int
    ///param0: LPWSTR->WCHAR*
    ///param1: LPARAM->LONG_PTR->int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int NAMEENUMPROCW([MarshalAs(UnmanagedType.LPWStr)] StringBuilder param0, IntPtr param1);

    /// Return Type: BOOL->int
    ///param0: LPSTR->CHAR*
    ///param1: LPARAM->LONG_PTR->int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int NAMEENUMPROCA([MarshalAs(UnmanagedType.LPStr)] StringBuilder param0, IntPtr param1);

    /// Return Type: void
    ///lpHelpInfo: LPHELPINFO->tagHELPINFO*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void MSGBOXCALLBACK(ref HELPINFO lpHelpInfo);

    /// Return Type: INT_PTR->int
    ///param0: HWND->HWND__*
    ///param1: UINT->unsigned int
    ///param2: WPARAM->UINT_PTR->unsigned int
    ///param3: LPARAM->LONG_PTR->int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int DLGPROC(IntPtr param0, uint param1, IntPtr param2, IntPtr param3);

    /// Return Type: void
    ///param0: HWND->HWND__*
    ///param1: UINT->unsigned int
    ///param2: ULONG_PTR->unsigned int
    ///param3: LRESULT->LONG_PTR->int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void SENDASYNCPROC(IntPtr param0, uint param1, uint param2, IntPtr param3);

    /// Return Type: BOOL->int
    ///param0: HMONITOR->HMONITOR__*
    ///param1: HDC->HDC__*
    ///param2: LPRECT->tagRECT*
    ///param3: LPARAM->LONG_PTR->int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int MONITORENUMPROC(IntPtr param0, IntPtr param1, ref RECT param2, IntPtr param3);

    /// Return Type: BOOL->int
    ///param0: HWND->HWND__*
    ///param1: LPARAM->LONG_PTR->int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int WNDENUMPROC(IntPtr param0, IntPtr param1);

    /// Return Type: LRESULT->LONG_PTR->int
    ///code: int
    ///wParam: WPARAM->UINT_PTR->unsigned int
    ///lParam: LPARAM->LONG_PTR->int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int HOOKPROC(int code, IntPtr wParam, IntPtr lParam);

    /// Return Type: void
    ///hWinEventHook: HWINEVENTHOOK->HWINEVENTHOOK__*
    ///event: DWORD->unsigned int
    ///hwnd: HWND->HWND__*
    ///idObject: LONG->int
    ///idChild: LONG->int
    ///idEventThread: DWORD->unsigned int
    ///dwmsEventTime: DWORD->unsigned int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void WINEVENTPROC(IntPtr hWinEventHook, uint @event, IntPtr hwnd, int idObject, int idChild, uint idEventThread, uint dwmsEventTime);

    /// Return Type: LRESULT->LONG_PTR->int
    ///param0: HWND->HWND__*
    ///param1: UINT->unsigned int
    ///param2: WPARAM->UINT_PTR->unsigned int
    ///param3: LPARAM->LONG_PTR->int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int WNDPROC(IntPtr param0, uint param1, IntPtr param2, IntPtr param3);

    /// Return Type: HDDEDATA->HDDEDATA__*
    ///wType: UINT->unsigned int
    ///wFmt: UINT->unsigned int
    ///hConv: HCONV->HCONV__*
    ///hsz1: HSZ->HSZ__*
    ///hsz2: HSZ->HSZ__*
    ///hData: HDDEDATA->HDDEDATA__*
    ///dwData1: ULONG_PTR->unsigned int
    ///dwData2: ULONG_PTR->unsigned int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate IntPtr PFNCALLBACK(uint wType, uint wFmt, IntPtr hConv, IntPtr hsz1, IntPtr hsz2, IntPtr hData, uint dwData1, uint dwData2);

    /// Return Type: BOOL->int
    ///param0: HWND->HWND__*
    ///param1: LPWSTR->WCHAR*
    ///param2: HANDLE->void*
    ///param3: ULONG_PTR->unsigned int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int PROPENUMPROCEXW(IntPtr param0, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder param1, IntPtr param2, uint param3);

    /// Return Type: BOOL->int
    ///param0: HWND->HWND__*
    ///param1: LPSTR->CHAR*
    ///param2: HANDLE->void*
    ///param3: ULONG_PTR->unsigned int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int PROPENUMPROCEXA(IntPtr param0, [MarshalAs(UnmanagedType.LPStr)] StringBuilder param1, IntPtr param2, uint param3);

    /// Return Type: BOOL->int
    ///param0: HDC->HDC__*
    ///param1: LPARAM->LONG_PTR->int
    ///param2: int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int GRAYSTRINGPROC(IntPtr param0, IntPtr param1, int param2);

    /// Return Type: BOOL->int
    ///param0: HWND->HWND__*
    ///param1: LPCWSTR->WCHAR*
    ///param2: HANDLE->void*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int PROPENUMPROCW(IntPtr param0, [In] [MarshalAs(UnmanagedType.LPWStr)] string param1, IntPtr param2);

    /// Return Type: BOOL->int
    ///param0: HWND->HWND__*
    ///param1: LPCSTR->CHAR*
    ///param2: HANDLE->void*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int PROPENUMPROCA(IntPtr param0, [In] [MarshalAs(UnmanagedType.LPStr)] string param1, IntPtr param2);

    /// Return Type: BOOL->int
    ///hdc: HDC->HDC__*
    ///lData: LPARAM->LONG_PTR->int
    ///wData: WPARAM->UINT_PTR->unsigned int
    ///cx: int
    ///cy: int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int DRAWSTATEPROC(IntPtr hdc, IntPtr lData, IntPtr wData, int cx, int cy);

    /// Return Type: void
    ///param0: HWND->HWND__*
    ///param1: UINT->unsigned int
    ///param2: UINT_PTR->unsigned int
    ///param3: DWORD->unsigned int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void TIMERPROC(IntPtr param0, uint param1, IntPtr param2, uint param3);

    public class User32
    {
        /// Return Type: void
        [DllImport("user32.dll", EntryPoint = "DisableProcessWindowsGhosting")]
        public static extern void DisableProcessWindowsGhosting();

        /// Return Type: BOOL->int
        ///Handle: HDEVNOTIFY->PVOID->void*
        [DllImport("user32.dll", EntryPoint = "UnregisterDeviceNotification")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool UnregisterDeviceNotification([In] IntPtr Handle);

        /// Return Type: UINT->unsigned int
        ///pRawInputDevices: PRAWINPUTDEVICE->tagRAWINPUTDEVICE*
        ///puiNumDevices: PUINT->unsigned int*
        ///cbSize: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "GetRegisteredRawInputDevices")]
        public static extern uint GetRegisteredRawInputDevices(IntPtr pRawInputDevices, ref uint puiNumDevices, uint cbSize);

        /// Return Type: HDEVNOTIFY->PVOID->void*
        ///hRecipient: HANDLE->void*
        ///NotificationFilter: LPVOID->void*
        ///Flags: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "RegisterDeviceNotificationW")]
        public static extern IntPtr RegisterDeviceNotificationW([In] IntPtr hRecipient, [In] IntPtr NotificationFilter, uint Flags);

        /// Return Type: HDEVNOTIFY->PVOID->void*
        ///hRecipient: HANDLE->void*
        ///NotificationFilter: LPVOID->void*
        ///Flags: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "RegisterDeviceNotificationA")]
        public static extern IntPtr RegisterDeviceNotificationA([In] IntPtr hRecipient, [In] IntPtr NotificationFilter, uint Flags);

        /// Return Type: DWORD->unsigned int
        ///nCount: DWORD->unsigned int
        ///pHandles: HANDLE*
        ///dwMilliseconds: DWORD->unsigned int
        ///dwWakeMask: DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "MsgWaitForMultipleObjectsEx")]
        public static extern uint MsgWaitForMultipleObjectsEx(uint nCount, ref IntPtr pHandles, uint dwMilliseconds, uint dwWakeMask, uint dwFlags);

        /// Return Type: int
        ///presbits: PBYTE->BYTE*
        ///fIcon: BOOL->int
        ///cxDesired: int
        ///cyDesired: int
        ///Flags: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "LookupIconIdFromDirectoryEx")]
        public static extern int LookupIconIdFromDirectoryEx(
            [In] ref byte presbits, [MarshalAs(UnmanagedType.Bool)] bool fIcon, int cxDesired, int cyDesired, uint Flags);

        /// Return Type: BOOL->int
        ///hwnd: HWND->HWND__*
        ///crKey: COLORREF->DWORD->unsigned int
        ///bAlpha: BYTE->unsigned char
        ///dwFlags: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "SetLayeredWindowAttributes")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetLayeredWindowAttributes([In] IntPtr hwnd, uint crKey, byte bAlpha, uint dwFlags);

        /// Return Type: BOOL->int
        ///format: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "IsClipboardFormatAvailable")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsClipboardFormatAvailable(uint format);

        /// Return Type: BOOL->int
        ///hWndClient: HWND->HWND__*
        ///hWndServer: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "ImpersonateDdeClientWindow")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ImpersonateDdeClientWindow(IntPtr hWndClient, IntPtr hWndServer);

        /// Return Type: int
        ///paFormatPriorityList: UINT*
        ///cFormats: int
        [DllImport("user32.dll", EntryPoint = "GetPriorityClipboardFormat")]
        public static extern int GetPriorityClipboardFormat(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U4, SizeParamIndex = 1)] uint[] paFormatPriorityList, int cFormats);

        /// Return Type: LONG->int
        [DllImport("user32.dll", EntryPoint = "GetMenuCheckMarkDimensions")]
        public static extern int GetMenuCheckMarkDimensions();

        /// Return Type: BOOL->int
        ///hwnd: HWND->HWND__*
        ///pcrKey: COLORREF*
        ///pbAlpha: BYTE*
        ///pdwFlags: DWORD*
        [DllImport("user32.dll", EntryPoint = "GetLayeredWindowAttributes")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetLayeredWindowAttributes([In] IntPtr hwnd, IntPtr pcrKey, IntPtr pbAlpha, IntPtr pdwFlags);

        /// Return Type: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "GetClipboardSequenceNumber")]
        public static extern uint GetClipboardSequenceNumber();

        /// Return Type: HWND->HWND__*
        ///hInstance: HINSTANCE->HINSTANCE__*
        ///lpTemplate: LPCDLGTEMPLATEW->DLGTEMPLATE*
        ///hWndParent: HWND->HWND__*
        ///lpDialogFunc: DLGPROC
        ///dwInitParam: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "CreateDialogIndirectParamW")]
        public static extern IntPtr CreateDialogIndirectParamW(
            [In] IntPtr hInstance, [In] ref DLGTEMPLATE lpTemplate, [In] IntPtr hWndParent, DLGPROC lpDialogFunc,
            [MarshalAs(UnmanagedType.SysInt)] int dwInitParam);

        /// Return Type: HWND->HWND__*
        ///hInstance: HINSTANCE->HINSTANCE__*
        ///lpTemplate: LPCDLGTEMPLATEA->DLGTEMPLATE*
        ///hWndParent: HWND->HWND__*
        ///lpDialogFunc: DLGPROC
        ///dwInitParam: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "CreateDialogIndirectParamA")]
        public static extern IntPtr CreateDialogIndirectParamA(
            [In] IntPtr hInstance, [In] ref DLGTEMPLATE lpTemplate, [In] IntPtr hWndParent, DLGPROC lpDialogFunc,
            [MarshalAs(UnmanagedType.SysInt)] int dwInitParam);

        /// Return Type: BOOL->int
        ///hObj: HANDLE->void*
        ///nIndex: int
        ///pvInfo: PVOID->void*
        ///nLength: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "SetUserObjectInformationW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetUserObjectInformationW([In] IntPtr hObj, int nIndex, [In] IntPtr pvInfo, uint nLength);

        /// Return Type: BOOL->int
        ///hObj: HANDLE->void*
        ///nIndex: int
        ///pvInfo: PVOID->void*
        ///nLength: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "SetUserObjectInformationA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetUserObjectInformationA([In] IntPtr hObj, int nIndex, [In] IntPtr pvInfo, uint nLength);

        /// Return Type: DWORD->unsigned int
        ///nCount: DWORD->unsigned int
        ///pHandles: HANDLE*
        ///fWaitAll: BOOL->int
        ///dwMilliseconds: DWORD->unsigned int
        ///dwWakeMask: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "MsgWaitForMultipleObjects")]
        public static extern uint MsgWaitForMultipleObjects(
            uint nCount, ref IntPtr pHandles, [MarshalAs(UnmanagedType.Bool)] bool fWaitAll, uint dwMilliseconds, uint dwWakeMask);

        /// Return Type: int
        ///presbits: PBYTE->BYTE*
        ///fIcon: BOOL->int
        [DllImport("user32.dll", EntryPoint = "LookupIconIdFromDirectory")]
        public static extern int LookupIconIdFromDirectory([In] ref byte presbits, [MarshalAs(UnmanagedType.Bool)] bool fIcon);

        /// Return Type: BOOL->int
        ///hObj: HANDLE->void*
        ///nIndex: int
        ///pvInfo: PVOID->void*
        ///nLength: DWORD->unsigned int
        ///lpnLengthNeeded: LPDWORD->DWORD*
        [DllImport("user32.dll", EntryPoint = "GetUserObjectInformationW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetUserObjectInformationW([In] IntPtr hObj, int nIndex, IntPtr pvInfo, uint nLength, IntPtr lpnLengthNeeded);

        /// Return Type: BOOL->int
        ///hObj: HANDLE->void*
        ///nIndex: int
        ///pvInfo: PVOID->void*
        ///nLength: DWORD->unsigned int
        ///lpnLengthNeeded: LPDWORD->DWORD*
        [DllImport("user32.dll", EntryPoint = "GetUserObjectInformationA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetUserObjectInformationA([In] IntPtr hObj, int nIndex, IntPtr pvInfo, uint nLength, IntPtr lpnLengthNeeded);

        /// Return Type: BOOL->int
        ///hwnd: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "DeregisterShellHookWindow")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DeregisterShellHookWindow([In] IntPtr hwnd);

        /// Return Type: int
        ///flags: DWORD->unsigned int
        ///lpInfo: LPDWORD->DWORD*
        ///Msg: UINT->unsigned int
        ///wParam: WPARAM->UINT_PTR->unsigned int
        ///lParam: LPARAM->LONG_PTR->int
        ///pbsmInfo: PBSMINFO->Anonymous_5d2ef610_55e9_4d35_a7f7_233f11c0e96c*
        [DllImport("user32.dll", EntryPoint = "BroadcastSystemMessageExW")]
        public static extern int BroadcastSystemMessageExW(
            uint flags, IntPtr lpInfo, uint Msg, [MarshalAs(UnmanagedType.SysUInt)] uint wParam, [MarshalAs(UnmanagedType.SysInt)] int lParam, IntPtr pbsmInfo);

        /// Return Type: int
        ///flags: DWORD->unsigned int
        ///lpInfo: LPDWORD->DWORD*
        ///Msg: UINT->unsigned int
        ///wParam: WPARAM->UINT_PTR->unsigned int
        ///lParam: LPARAM->LONG_PTR->int
        ///pbsmInfo: PBSMINFO->Anonymous_5d2ef610_55e9_4d35_a7f7_233f11c0e96c*
        [DllImport("user32.dll", EntryPoint = "BroadcastSystemMessageExA")]
        public static extern int BroadcastSystemMessageExA(
            uint flags, IntPtr lpInfo, uint Msg, [MarshalAs(UnmanagedType.SysUInt)] uint wParam, [MarshalAs(UnmanagedType.SysInt)] int lParam, IntPtr pbsmInfo);

        /// Return Type: UINT->unsigned int
        ///lpszFormat: LPCWSTR->WCHAR*
        [DllImport("user32.dll", EntryPoint = "RegisterClipboardFormatW")]
        public static extern uint RegisterClipboardFormatW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpszFormat);

        /// Return Type: UINT->unsigned int
        ///lpszFormat: LPCSTR->CHAR*
        [DllImport("user32.dll", EntryPoint = "RegisterClipboardFormatA")]
        public static extern uint RegisterClipboardFormatA([In] [MarshalAs(UnmanagedType.LPStr)] string lpszFormat);

        /// Return Type: HWND->HWND__*
        ///hwndParent: HWND->HWND__*
        ///ptParentClientCoords: POINT->tagPOINT
        [DllImport("user32.dll", EntryPoint = "RealChildWindowFromPoint")]
        public static extern IntPtr RealChildWindowFromPoint([In] IntPtr hwndParent, Point ptParentClientCoords);

        /// Return Type: DWORD->unsigned int
        ///hWnd: HWND->HWND__*
        ///lpdwProcessId: LPDWORD->DWORD*
        [DllImport("user32.dll", EntryPoint = "GetWindowThreadProcessId")]
        public static extern uint GetWindowThreadProcessId([In] IntPtr hWnd, IntPtr lpdwProcessId);

        /// Return Type: UINT->unsigned int
        ///hwnd: HWND->HWND__*
        ///pszFileName: LPWSTR->WCHAR*
        ///cchFileNameMax: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "GetWindowModuleFileNameW")]
        public static extern uint GetWindowModuleFileNameW(
            [In] IntPtr hwnd, [Out] [MarshalAs(UnmanagedType.LPWStr)] StringBuilder pszFileName, uint cchFileNameMax);

        /// Return Type: UINT->unsigned int
        ///hwnd: HWND->HWND__*
        ///pszFileName: LPSTR->CHAR*
        ///cchFileNameMax: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "GetWindowModuleFileNameA")]
        public static extern uint GetWindowModuleFileNameA(
            [In] IntPtr hwnd, [Out] [MarshalAs(UnmanagedType.LPStr)] StringBuilder pszFileName, uint cchFileNameMax);

        /// Return Type: HICON->HICON__*
        ///presbits: PBYTE->BYTE*
        ///dwResSize: DWORD->unsigned int
        ///fIcon: BOOL->int
        ///dwVer: DWORD->unsigned int
        ///cxDesired: int
        ///cyDesired: int
        ///Flags: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "CreateIconFromResourceEx")]
        public static extern IntPtr CreateIconFromResourceEx(
            [In] ref byte presbits, uint dwResSize, [MarshalAs(UnmanagedType.Bool)] bool fIcon, uint dwVer, int cxDesired, int cyDesired, uint Flags);

        /// Return Type: LONG->int
        ///lpszDeviceName: LPCWSTR->WCHAR*
        ///lpDevMode: LPDEVMODEW->_devicemodeW*
        ///hwnd: HWND->HWND__*
        ///dwflags: DWORD->unsigned int
        ///lParam: LPVOID->void*
        [DllImport("user32.dll", EntryPoint = "ChangeDisplaySettingsExW")]
        public static extern int ChangeDisplaySettingsExW(
            [In] [MarshalAs(UnmanagedType.LPWStr)] string lpszDeviceName, [In] IntPtr lpDevMode, IntPtr hwnd, uint dwflags, [In] IntPtr lParam);

        /// Return Type: LONG->int
        ///lpszDeviceName: LPCSTR->CHAR*
        ///lpDevMode: LPDEVMODEA->_devicemodeA*
        ///hwnd: HWND->HWND__*
        ///dwflags: DWORD->unsigned int
        ///lParam: LPVOID->void*
        [DllImport("user32.dll", EntryPoint = "ChangeDisplaySettingsExA")]
        public static extern int ChangeDisplaySettingsExA(
            [In] [MarshalAs(UnmanagedType.LPStr)] string lpszDeviceName, [In] IntPtr lpDevMode, IntPtr hwnd, uint dwflags, [In] IntPtr lParam);

        /// Return Type: BOOL->int
        ///dwProcessId: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "AllowSetForegroundWindow")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AllowSetForegroundWindow(uint dwProcessId);

        /// Return Type: BOOL->int
        ///hWinSta: HWINSTA->HWINSTA__*
        [DllImport("user32.dll", EntryPoint = "SetProcessWindowStation")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetProcessWindowStation([In] IntPtr hWinSta);

        /// Return Type: BOOL->int
        ///dwDefaultLayout: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "SetProcessDefaultLayout")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetProcessDefaultLayout(uint dwDefaultLayout);

        /// Return Type: BOOL->int
        ///hwnd: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "RegisterShellHookWindow")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool RegisterShellHookWindow([In] IntPtr hwnd);

        /// Return Type: BOOL->int
        ///pRawInputDevices: PCRAWINPUTDEVICE->RAWINPUTDEVICE*
        ///uiNumDevices: UINT->unsigned int
        ///cbSize: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "RegisterRawInputDevices")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool RegisterRawInputDevices(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 1)] RAWINPUTDEVICE[] pRawInputDevices, uint uiNumDevices,
            uint cbSize);

        /// Return Type: BOOL->int
        ///uLockCode: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "LockSetForegroundWindow")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool LockSetForegroundWindow(uint uLockCode);

        /// Return Type: BOOL->int
        ///event: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "IsWinEventHookInstalled")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsWinEventHookInstalled(uint @event);

        /// Return Type: HWINSTA->HWINSTA__*
        [DllImport("user32.dll", EntryPoint = "GetProcessWindowStation")]
        public static extern IntPtr GetProcessWindowStation();

        /// Return Type: BOOL->int
        ///pdwDefaultLayout: DWORD*
        [DllImport("user32.dll", EntryPoint = "GetProcessDefaultLayout")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetProcessDefaultLayout([Out] out uint pdwDefaultLayout);

        /// Return Type: int
        ///format: UINT->unsigned int
        ///lpszFormatName: LPWSTR->WCHAR*
        ///cchMaxCount: int
        [DllImport("user32.dll", EntryPoint = "GetClipboardFormatNameW")]
        public static extern int GetClipboardFormatNameW(uint format, [Out] [MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpszFormatName, int cchMaxCount);

        /// Return Type: int
        ///format: UINT->unsigned int
        ///lpszFormatName: LPSTR->CHAR*
        ///cchMaxCount: int
        [DllImport("user32.dll", EntryPoint = "GetClipboardFormatNameA")]
        public static extern int GetClipboardFormatNameA(uint format, [Out] [MarshalAs(UnmanagedType.LPStr)] StringBuilder lpszFormatName, int cchMaxCount);

        /// Return Type: BOOL->int
        ///hwndDlg: HWND->HWND__*
        ///lpString: LPWSTR->WCHAR*
        ///cchOut: int
        ///idComboBox: int
        [DllImport("user32.dll", EntryPoint = "DlgDirSelectComboBoxExW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DlgDirSelectComboBoxExW(
            [In] IntPtr hwndDlg, [Out] [MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpString, int cchOut, int idComboBox);

        /// Return Type: BOOL->int
        ///hwndDlg: HWND->HWND__*
        ///lpString: LPSTR->CHAR*
        ///cchOut: int
        ///idComboBox: int
        [DllImport("user32.dll", EntryPoint = "DlgDirSelectComboBoxExA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DlgDirSelectComboBoxExA(
            [In] IntPtr hwndDlg, [Out] [MarshalAs(UnmanagedType.LPStr)] StringBuilder lpString, int cchOut, int idComboBox);

        /// Return Type: INT_PTR->int
        ///hInstance: HINSTANCE->HINSTANCE__*
        ///hDialogTemplate: LPCDLGTEMPLATEW->DLGTEMPLATE*
        ///hWndParent: HWND->HWND__*
        ///lpDialogFunc: DLGPROC
        ///dwInitParam: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "DialogBoxIndirectParamW")]
        public static extern int DialogBoxIndirectParamW(
            [In] IntPtr hInstance, [In] ref DLGTEMPLATE hDialogTemplate, [In] IntPtr hWndParent, DLGPROC lpDialogFunc,
            [MarshalAs(UnmanagedType.SysInt)] int dwInitParam);

        /// Return Type: INT_PTR->int
        ///hInstance: HINSTANCE->HINSTANCE__*
        ///hDialogTemplate: LPCDLGTEMPLATEA->DLGTEMPLATE*
        ///hWndParent: HWND->HWND__*
        ///lpDialogFunc: DLGPROC
        ///dwInitParam: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "DialogBoxIndirectParamA")]
        public static extern int DialogBoxIndirectParamA(
            [In] IntPtr hInstance, [In] ref DLGTEMPLATE hDialogTemplate, [In] IntPtr hWndParent, DLGPROC lpDialogFunc,
            [MarshalAs(UnmanagedType.SysInt)] int dwInitParam);

        /// Return Type: BOOL->int
        ///hAccel: HACCEL->HACCEL__*
        [DllImport("user32.dll", EntryPoint = "DestroyAcceleratorTable")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DestroyAcceleratorTable([In] IntPtr hAccel);

        /// Return Type: HACCEL->HACCEL__*
        ///paccel: LPACCEL->tagACCEL*
        ///cAccel: int
        [DllImport("user32.dll", EntryPoint = "CreateAcceleratorTableW")]
        public static extern IntPtr CreateAcceleratorTableW(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 1)] ACCEL[] paccel, int cAccel);

        /// Return Type: HACCEL->HACCEL__*
        ///paccel: LPACCEL->tagACCEL*
        ///cAccel: int
        [DllImport("user32.dll", EntryPoint = "CreateAcceleratorTableA")]
        public static extern IntPtr CreateAcceleratorTableA(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 1)] ACCEL[] paccel, int cAccel);

        /// Return Type: int
        ///flags: DWORD->unsigned int
        ///lpInfo: LPDWORD->DWORD*
        ///Msg: UINT->unsigned int
        ///wParam: WPARAM->UINT_PTR->unsigned int
        ///lParam: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "BroadcastSystemMessageW")]
        public static extern int BroadcastSystemMessageW(
            uint flags, IntPtr lpInfo, uint Msg, [MarshalAs(UnmanagedType.SysUInt)] uint wParam, [MarshalAs(UnmanagedType.SysInt)] int lParam);

        /// Return Type: int
        ///flags: DWORD->unsigned int
        ///lpInfo: LPDWORD->DWORD*
        ///Msg: UINT->unsigned int
        ///wParam: WPARAM->UINT_PTR->unsigned int
        ///lParam: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "BroadcastSystemMessageA")]
        public static extern int BroadcastSystemMessageA(
            uint flags, IntPtr lpInfo, uint Msg, [MarshalAs(UnmanagedType.SysUInt)] uint wParam, [MarshalAs(UnmanagedType.SysInt)] int lParam);

        /// Return Type: BOOL->int
        ///param0: HWND->HWND__*
        ///param1: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "SetWindowContextHelpId")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowContextHelpId([In] IntPtr param0, uint param1);

        /// Return Type: UINT->unsigned int
        ///lpString: LPCWSTR->WCHAR*
        [DllImport("user32.dll", EntryPoint = "RegisterWindowMessageW")]
        public static extern uint RegisterWindowMessageW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpString);

        /// Return Type: UINT->unsigned int
        ///lpString: LPCSTR->CHAR*
        [DllImport("user32.dll", EntryPoint = "RegisterWindowMessageA")]
        public static extern uint RegisterWindowMessageA([In] [MarshalAs(UnmanagedType.LPStr)] string lpString);

        /// Return Type: DWORD->unsigned int
        ///param0: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "GetWindowContextHelpId")]
        public static extern uint GetWindowContextHelpId([In] IntPtr param0);

        /// Return Type: UINT->unsigned int
        ///hDevice: HANDLE->void*
        ///uiCommand: UINT->unsigned int
        ///pData: LPVOID->void*
        ///pcbSize: PUINT->unsigned int*
        [DllImport("user32.dll", EntryPoint = "GetRawInputDeviceInfoW")]
        public static extern uint GetRawInputDeviceInfoW([In] IntPtr hDevice, uint uiCommand, IntPtr pData, ref uint pcbSize);

        /// Return Type: UINT->unsigned int
        ///hDevice: HANDLE->void*
        ///uiCommand: UINT->unsigned int
        ///pData: LPVOID->void*
        ///pcbSize: PUINT->unsigned int*
        [DllImport("user32.dll", EntryPoint = "GetRawInputDeviceInfoA")]
        public static extern uint GetRawInputDeviceInfoA([In] IntPtr hDevice, uint uiCommand, IntPtr pData, ref uint pcbSize);

        /// Return Type: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "GetOpenClipboardWindow")]
        public static extern IntPtr GetOpenClipboardWindow();

        /// Return Type: BOOL->int
        ///pwszKLID: LPWSTR->WCHAR*
        [DllImport("user32.dll", EntryPoint = "GetKeyboardLayoutNameW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetKeyboardLayoutNameW([Out] [MarshalAs(UnmanagedType.LPWStr)] StringBuilder pwszKLID);

        /// Return Type: BOOL->int
        ///pwszKLID: LPSTR->CHAR*
        [DllImport("user32.dll", EntryPoint = "GetKeyboardLayoutNameA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetKeyboardLayoutNameA([Out] [MarshalAs(UnmanagedType.LPStr)] StringBuilder pwszKLID);

        /// Return Type: BOOL->int
        ///lpszDeviceName: LPCWSTR->WCHAR*
        ///iModeNum: DWORD->unsigned int
        ///lpDevMode: LPDEVMODEW->_devicemodeW*
        ///dwFlags: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "EnumDisplaySettingsExW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumDisplaySettingsExW(
            [In] [MarshalAs(UnmanagedType.LPWStr)] string lpszDeviceName, uint iModeNum, [Out] out DEVMODEW lpDevMode, uint dwFlags);

        /// Return Type: BOOL->int
        ///lpszDeviceName: LPCSTR->CHAR*
        ///iModeNum: DWORD->unsigned int
        ///lpDevMode: LPDEVMODEA->_devicemodeA*
        ///dwFlags: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "EnumDisplaySettingsExA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumDisplaySettingsExA(
            [In] [MarshalAs(UnmanagedType.LPStr)] string lpszDeviceName, uint iModeNum, [Out] out DEVMODEA lpDevMode, uint dwFlags);

        /// Return Type: BOOL->int
        ///hwndClient: HWND->HWND__*
        ///pqosNew: SECURITY_QUALITY_OF_SERVICE*
        ///pqosPrev: PSECURITY_QUALITY_OF_SERVICE->_SECURITY_QUALITY_OF_SERVICE*
        [DllImport("user32.dll", EntryPoint = "DdeSetQualityOfService")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DdeSetQualityOfService(IntPtr hwndClient, ref SECURITY_QUALITY_OF_SERVICE pqosNew, ref SECURITY_QUALITY_OF_SERVICE pqosPrev);

        /// Return Type: HSZ->HSZ__*
        ///idInst: DWORD->unsigned int
        ///psz: LPCWSTR->WCHAR*
        ///iCodePage: int
        [DllImport("user32.dll", EntryPoint = "DdeCreateStringHandleW")]
        public static extern IntPtr DdeCreateStringHandleW(uint idInst, [In] [MarshalAs(UnmanagedType.LPWStr)] string psz, int iCodePage);

        /// Return Type: HSZ->HSZ__*
        ///idInst: DWORD->unsigned int
        ///psz: LPCSTR->CHAR*
        ///iCodePage: int
        [DllImport("user32.dll", EntryPoint = "DdeCreateStringHandleA")]
        public static extern IntPtr DdeCreateStringHandleA(uint idInst, [In] [MarshalAs(UnmanagedType.LPStr)] string psz, int iCodePage);

        /// Return Type: HICON->HICON__*
        ///presbits: PBYTE->BYTE*
        ///dwResSize: DWORD->unsigned int
        ///fIcon: BOOL->int
        ///dwVer: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "CreateIconFromResource")]
        public static extern IntPtr CreateIconFromResource([In] ref byte presbits, uint dwResSize, [MarshalAs(UnmanagedType.Bool)] bool fIcon, uint dwVer);

        /// Return Type: HWND->HWND__*
        ///hwnd: HWND->HWND__*
        ///pt: POINT->tagPOINT
        ///flags: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "ChildWindowFromPointEx")]
        public static extern IntPtr ChildWindowFromPointEx([In] IntPtr hwnd, Point pt, uint flags);

        /// Return Type: LONG->int
        ///lpDevMode: LPDEVMODEW->_devicemodeW*
        ///dwFlags: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "ChangeDisplaySettingsW")]
        public static extern int ChangeDisplaySettingsW([In] IntPtr lpDevMode, uint dwFlags);

        /// Return Type: LONG->int
        ///lpDevMode: LPDEVMODEA->_devicemodeA*
        ///dwFlags: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "ChangeDisplaySettingsA")]
        public static extern int ChangeDisplaySettingsA([In] IntPtr lpDevMode, uint dwFlags);

        /// Return Type: HKL->HKL__*
        ///hkl: HKL->HKL__*
        ///Flags: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "ActivateKeyboardLayout")]
        public static extern IntPtr ActivateKeyboardLayout([In] IntPtr hkl, uint Flags);

        /// Return Type: BOOL->int
        ///hUserHandle: HANDLE->void*
        ///hJob: HANDLE->void*
        ///bGrant: BOOL->int
        [DllImport("user32.dll", EntryPoint = "UserHandleGrantAccess")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool UserHandleGrantAccess([In] IntPtr hUserHandle, [In] IntPtr hJob, [MarshalAs(UnmanagedType.Bool)] bool bGrant);

        /// Return Type: int
        ///hWnd: HWND->HWND__*
        ///hAccTable: HACCEL->HACCEL__*
        ///lpMsg: LPMSG->tagMSG*
        [DllImport("user32.dll", EntryPoint = "TranslateAcceleratorW")]
        public static extern int TranslateAcceleratorW([In] IntPtr hWnd, [In] IntPtr hAccTable, [In] ref MSG lpMsg);

        /// Return Type: int
        ///hWnd: HWND->HWND__*
        ///hAccTable: HACCEL->HACCEL__*
        ///lpMsg: LPMSG->tagMSG*
        [DllImport("user32.dll", EntryPoint = "TranslateAcceleratorA")]
        public static extern int TranslateAcceleratorA([In] IntPtr hWnd, [In] IntPtr hAccTable, [In] ref MSG lpMsg);

        /// Return Type: BOOL->int
        ///uiAction: UINT->unsigned int
        ///uiParam: UINT->unsigned int
        ///pvParam: PVOID->void*
        ///fWinIni: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "SystemParametersInfoW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SystemParametersInfoW(uint uiAction, uint uiParam, IntPtr pvParam, uint fWinIni);

        /// Return Type: BOOL->int
        ///uiAction: UINT->unsigned int
        ///uiParam: UINT->unsigned int
        ///pvParam: PVOID->void*
        ///fWinIni: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "SystemParametersInfoA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SystemParametersInfoA(uint uiAction, uint uiParam, IntPtr pvParam, uint fWinIni);

        /// Return Type: BOOL->int
        ///hObj: HANDLE->void*
        ///pSIRequested: PSECURITY_INFORMATION->DWORD*
        ///pSID: PSECURITY_DESCRIPTOR->PVOID->void*
        [DllImport("user32.dll", EntryPoint = "SetUserObjectSecurity")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetUserObjectSecurity([In] IntPtr hObj, [In] ref uint pSIRequested, [In] IntPtr pSID);

        /// Return Type: int
        ///hWnd: HWND->HWND__*
        ///pString: LPWSTR->WCHAR*
        ///cchMaxCount: int
        [DllImport("user32.dll", EntryPoint = "InternalGetWindowText")]
        public static extern int InternalGetWindowText([In] IntPtr hWnd, [Out] [MarshalAs(UnmanagedType.LPWStr)] StringBuilder pString, int cchMaxCount);

        /// Return Type: BOOL->int
        ///hObj: HANDLE->void*
        ///pSIRequested: PSECURITY_INFORMATION->DWORD*
        ///pSID: PSECURITY_DESCRIPTOR->PVOID->void*
        ///nLength: DWORD->unsigned int
        ///lpnLengthNeeded: LPDWORD->DWORD*
        [DllImport("user32.dll", EntryPoint = "GetUserObjectSecurity")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetUserObjectSecurity([In] IntPtr hObj, [In] ref uint pSIRequested, IntPtr pSID, uint nLength, [Out] out uint lpnLengthNeeded);

        /// Return Type: UINT->unsigned int
        ///pRawInputDeviceList: PRAWINPUTDEVICELIST->tagRAWINPUTDEVICELIST*
        ///puiNumDevices: PUINT->unsigned int*
        ///cbSize: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "GetRawInputDeviceList")]
        public static extern uint GetRawInputDeviceList(IntPtr pRawInputDeviceList, ref uint puiNumDevices, uint cbSize);

        /// Return Type: int
        ///nBuff: int
        ///lpList: HKL*
        [DllImport("user32.dll", EntryPoint = "GetKeyboardLayoutList")]
        public static extern int GetKeyboardLayoutList(int nBuff, ref IntPtr lpList);

        /// Return Type: BOOL->int
        ///idInst: DWORD->unsigned int
        ///hConv: HCONV->HCONV__*
        ///idTransaction: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "DdeAbandonTransaction")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DdeAbandonTransaction(uint idInst, IntPtr hConv, uint idTransaction);

        /// Return Type: int
        [DllImport("user32.dll", EntryPoint = "CountClipboardFormats")]
        public static extern int CountClipboardFormats();

        /// Return Type: int
        ///hAccelSrc: HACCEL->HACCEL__*
        ///lpAccelDst: LPACCEL->tagACCEL*
        ///cAccelEntries: int
        [DllImport("user32.dll", EntryPoint = "CopyAcceleratorTableW")]
        public static extern int CopyAcceleratorTableW([In] IntPtr hAccelSrc, IntPtr lpAccelDst, int cAccelEntries);

        /// Return Type: int
        ///hAccelSrc: HACCEL->HACCEL__*
        ///lpAccelDst: LPACCEL->tagACCEL*
        ///cAccelEntries: int
        [DllImport("user32.dll", EntryPoint = "CopyAcceleratorTableA")]
        public static extern int CopyAcceleratorTableA([In] IntPtr hAccelSrc, IntPtr lpAccelDst, int cAccelEntries);

        /// Return Type: BOOL->int
        ///hkl: HKL->HKL__*
        [DllImport("user32.dll", EntryPoint = "UnloadKeyboardLayout")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool UnloadKeyboardLayout([In] IntPtr hkl);

        /// Return Type: BOOL->int
        ///hWndClient: HWND->HWND__*
        ///lpMsg: LPMSG->tagMSG*
        [DllImport("user32.dll", EntryPoint = "TranslateMDISysAccel")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool TranslateMDISysAccel([In] IntPtr hWndClient, [In] ref MSG lpMsg);

        /// Return Type: BOOL->int
        ///param0: HMENU->HMENU__*
        ///param1: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "SetMenuContextHelpId")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetMenuContextHelpId([In] IntPtr param0, uint param1);

        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///Msg: UINT->unsigned int
        ///wParam: WPARAM->UINT_PTR->unsigned int
        ///lParam: LPARAM->LONG_PTR->int
        ///lpResultCallBack: SENDASYNCPROC
        ///dwData: ULONG_PTR->unsigned int
        [DllImport("user32.dll", EntryPoint = "SendMessageCallbackW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SendMessageCallbackW(
            [In] IntPtr hWnd, uint Msg, [MarshalAs(UnmanagedType.SysUInt)] uint wParam, [MarshalAs(UnmanagedType.SysInt)] int lParam,
            SENDASYNCPROC lpResultCallBack, uint dwData);

        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///Msg: UINT->unsigned int
        ///wParam: WPARAM->UINT_PTR->unsigned int
        ///lParam: LPARAM->LONG_PTR->int
        ///lpResultCallBack: SENDASYNCPROC
        ///dwData: ULONG_PTR->unsigned int
        [DllImport("user32.dll", EntryPoint = "SendMessageCallbackA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SendMessageCallbackA(
            [In] IntPtr hWnd, uint Msg, [MarshalAs(UnmanagedType.SysUInt)] uint wParam, [MarshalAs(UnmanagedType.SysInt)] int lParam,
            SENDASYNCPROC lpResultCallBack, uint dwData);

        /// Return Type: UINT->unsigned int
        ///szFileName: LPCWSTR->WCHAR*
        ///nIconIndex: int
        ///cxIcon: int
        ///cyIcon: int
        ///phicon: HICON*
        ///piconid: UINT*
        ///nIcons: UINT->unsigned int
        ///flags: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "PrivateExtractIconsW")]
        public static extern uint PrivateExtractIconsW(
            [In] [MarshalAs(UnmanagedType.LPWStr)] string szFileName, int nIconIndex, int cxIcon, int cyIcon, ref IntPtr phicon, IntPtr piconid, uint nIcons,
            uint flags);

        /// Return Type: UINT->unsigned int
        ///szFileName: LPCSTR->CHAR*
        ///nIconIndex: int
        ///cxIcon: int
        ///cyIcon: int
        ///phicon: HICON*
        ///piconid: UINT*
        ///nIcons: UINT->unsigned int
        ///flags: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "PrivateExtractIconsA")]
        public static extern uint PrivateExtractIconsA(
            [In] [MarshalAs(UnmanagedType.LPStr)] string szFileName, int nIconIndex, int cxIcon, int cyIcon, ref IntPtr phicon, IntPtr piconid, uint nIcons,
            uint flags);

        /// Return Type: int
        ///hWnd: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "GetWindowTextLengthW")]
        public static extern int GetWindowTextLengthW([In] IntPtr hWnd);

        /// Return Type: int
        ///hWnd: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "GetWindowTextLengthA")]
        public static extern int GetWindowTextLengthA([In] IntPtr hWnd);

        /// Return Type: DWORD->unsigned int
        ///hdc: HDC->HDC__*
        ///lpString: LPCWSTR->WCHAR*
        ///chCount: int
        ///nTabPositions: int
        ///lpnTabStopPositions: INT*
        [DllImport("user32.dll", EntryPoint = "GetTabbedTextExtentW")]
        public static extern uint GetTabbedTextExtentW(
            [In] IntPtr hdc, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpString, int chCount, int nTabPositions, [In] IntPtr lpnTabStopPositions);

        /// Return Type: DWORD->unsigned int
        ///hdc: HDC->HDC__*
        ///lpString: LPCSTR->CHAR*
        ///chCount: int
        ///nTabPositions: int
        ///lpnTabStopPositions: INT*
        [DllImport("user32.dll", EntryPoint = "GetTabbedTextExtentA")]
        public static extern uint GetTabbedTextExtentA(
            [In] IntPtr hdc, [In] [MarshalAs(UnmanagedType.LPStr)] string lpString, int chCount, int nTabPositions, [In] IntPtr lpnTabStopPositions);

        /// Return Type: int
        ///cbSize: UINT->unsigned int
        ///lppt: LPMOUSEMOVEPOINT->tagMOUSEMOVEPOINT*
        ///lpptBuf: LPMOUSEMOVEPOINT->tagMOUSEMOVEPOINT*
        ///nBufPoints: int
        ///resolution: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "GetMouseMovePointsEx")]
        public static extern int GetMouseMovePointsEx(uint cbSize, [In] ref MOUSEMOVEPOINT lppt, IntPtr lpptBuf, int nBufPoints, uint resolution);

        /// Return Type: DWORD->unsigned int
        ///param0: HMENU->HMENU__*
        [DllImport("user32.dll", EntryPoint = "GetMenuContextHelpId")]
        public static extern uint GetMenuContextHelpId([In] IntPtr param0);

        /// Return Type: BOOL->int
        ///lpszDeviceName: LPCWSTR->WCHAR*
        ///iModeNum: DWORD->unsigned int
        ///lpDevMode: LPDEVMODEW->_devicemodeW*
        [DllImport("user32.dll", EntryPoint = "EnumDisplaySettingsW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumDisplaySettingsW(
            [In] [MarshalAs(UnmanagedType.LPWStr)] string lpszDeviceName, uint iModeNum, [Out] out DEVMODEW lpDevMode);

        /// Return Type: BOOL->int
        ///lpszDeviceName: LPCSTR->CHAR*
        ///iModeNum: DWORD->unsigned int
        ///lpDevMode: LPDEVMODEA->_devicemodeA*
        [DllImport("user32.dll", EntryPoint = "EnumDisplaySettingsA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumDisplaySettingsA([In] [MarshalAs(UnmanagedType.LPStr)] string lpszDeviceName, uint iModeNum, [Out] out DEVMODEA lpDevMode);

        /// Return Type: UINT->unsigned int
        ///format: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "EnumClipboardFormats")]
        public static extern uint EnumClipboardFormats(uint format);

        /// Return Type: BOOL->int
        ///hConv: HCONV->HCONV__*
        [DllImport("user32.dll", EntryPoint = "DdeImpersonateClient")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DdeImpersonateClient(IntPtr hConv);

        /// Return Type: HDDEDATA->HDDEDATA__*
        ///pData: LPBYTE->BYTE*
        ///cbData: DWORD->unsigned int
        ///hConv: HCONV->HCONV__*
        ///hszItem: HSZ->HSZ__*
        ///wFmt: UINT->unsigned int
        ///wType: UINT->unsigned int
        ///dwTimeout: DWORD->unsigned int
        ///pdwResult: LPDWORD->DWORD*
        [DllImport("user32.dll", EntryPoint = "DdeClientTransaction")]
        public static extern IntPtr DdeClientTransaction(
            ref byte pData, uint cbData, IntPtr hConv, IntPtr hszItem, uint wFmt, uint wType, uint dwTimeout, ref uint pdwResult);

        /// Return Type: HWINSTA->HWINSTA__*
        ///lpwinsta: LPCWSTR->WCHAR*
        ///dwFlags: DWORD->unsigned int
        ///dwDesiredAccess: ACCESS_MASK->DWORD->unsigned int
        ///lpsa: LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        [DllImport("user32.dll", EntryPoint = "CreateWindowStationW")]
        public static extern IntPtr CreateWindowStationW(
            [In] [MarshalAs(UnmanagedType.LPWStr)] string lpwinsta, uint dwFlags, uint dwDesiredAccess, [In] IntPtr lpsa);

        /// Return Type: HWINSTA->HWINSTA__*
        ///lpwinsta: LPCSTR->CHAR*
        ///dwFlags: DWORD->unsigned int
        ///dwDesiredAccess: ACCESS_MASK->DWORD->unsigned int
        ///lpsa: LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        [DllImport("user32.dll", EntryPoint = "CreateWindowStationA")]
        public static extern IntPtr CreateWindowStationA(
            [In] [MarshalAs(UnmanagedType.LPStr)] string lpwinsta, uint dwFlags, uint dwDesiredAccess, [In] IntPtr lpsa);

        /// Return Type: HWND->HWND__*
        ///hWndParent: HWND->HWND__*
        ///Point: POINT->tagPOINT
        [DllImport("user32.dll", EntryPoint = "ChildWindowFromPoint")]
        public static extern IntPtr ChildWindowFromPoint([In] IntPtr hWndParent, Point Point);

        /// Return Type: BOOL->int
        ///hWndRemove: HWND->HWND__*
        ///hWndNewNext: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "ChangeClipboardChain")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ChangeClipboardChain([In] IntPtr hWndRemove, [In] IntPtr hWndNewNext);

        /// Return Type: UINT->unsigned int
        ///hWnd: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "ArrangeIconicWindows")]
        public static extern uint ArrangeIconicWindows([In] IntPtr hWnd);

        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///hdcDst: HDC->HDC__*
        ///pptDst: POINT*
        ///psize: SIZE*
        ///hdcSrc: HDC->HDC__*
        ///pptSrc: POINT*
        ///crKey: COLORREF->DWORD->unsigned int
        ///pblend: BLENDFUNCTION*
        ///dwFlags: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "UpdateLayeredWindow")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool UpdateLayeredWindow(
            [In] IntPtr hWnd, [In] IntPtr hdcDst, [In] IntPtr pptDst, [In] IntPtr psize, [In] IntPtr hdcSrc, [In] IntPtr pptSrc, uint crKey, [In] IntPtr pblend,
            uint dwFlags);

        /// Return Type: BOOL->int
        ///hhk: HHOOK->HHOOK__*
        [DllImport("user32.dll", EntryPoint = "UnhookWindowsHookEx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool UnhookWindowsHookEx([In] IntPtr hhk);

        /// Return Type: LPARAM->LONG_PTR->int
        ///lParam: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "SetMessageExtraInfo")]
        [return: MarshalAs(UnmanagedType.SysInt)]
        public static extern int SetMessageExtraInfo([MarshalAs(UnmanagedType.SysInt)] int lParam);

        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "SetForegroundWindow")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetForegroundWindow([In] IntPtr hWnd);

        /// Return Type: LRESULT->LONG_PTR->int
        ///hWnd: HWND->HWND__*
        ///Msg: UINT->unsigned int
        ///wParam: WPARAM->UINT_PTR->unsigned int
        ///lParam: LPARAM->LONG_PTR->int
        ///fuFlags: UINT->unsigned int
        ///uTimeout: UINT->unsigned int
        ///lpdwResult: PDWORD_PTR->ULONG_PTR*
        [DllImport("user32.dll", EntryPoint = "SendMessageTimeoutW")]
        [return: MarshalAs(UnmanagedType.SysInt)]
        public static extern int SendMessageTimeoutW(
            [In] IntPtr hWnd, uint Msg, [MarshalAs(UnmanagedType.SysUInt)] uint wParam, [MarshalAs(UnmanagedType.SysInt)] int lParam, uint fuFlags,
            uint uTimeout, IntPtr lpdwResult);

        /// Return Type: LRESULT->LONG_PTR->int
        ///hWnd: HWND->HWND__*
        ///Msg: UINT->unsigned int
        ///wParam: WPARAM->UINT_PTR->unsigned int
        ///lParam: LPARAM->LONG_PTR->int
        ///fuFlags: UINT->unsigned int
        ///uTimeout: UINT->unsigned int
        ///lpdwResult: PDWORD_PTR->ULONG_PTR*
        [DllImport("user32.dll", EntryPoint = "SendMessageTimeoutA")]
        [return: MarshalAs(UnmanagedType.SysInt)]
        public static extern int SendMessageTimeoutA(
            [In] IntPtr hWnd, uint Msg, [MarshalAs(UnmanagedType.SysUInt)] uint wParam, [MarshalAs(UnmanagedType.SysInt)] int lParam, uint fuFlags,
            uint uTimeout, IntPtr lpdwResult);

        /// Return Type: LRESULT->LONG_PTR->int
        ///hDlg: HWND->HWND__*
        ///nIDDlgItem: int
        ///Msg: UINT->unsigned int
        ///wParam: WPARAM->UINT_PTR->unsigned int
        ///lParam: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "SendDlgItemMessageW")]
        [return: MarshalAs(UnmanagedType.SysInt)]
        public static extern int SendDlgItemMessageW(
            [In] IntPtr hDlg, int nIDDlgItem, uint Msg, [MarshalAs(UnmanagedType.SysUInt)] uint wParam, [MarshalAs(UnmanagedType.SysInt)] int lParam);

        /// Return Type: LRESULT->LONG_PTR->int
        ///hDlg: HWND->HWND__*
        ///nIDDlgItem: int
        ///Msg: UINT->unsigned int
        ///wParam: WPARAM->UINT_PTR->unsigned int
        ///lParam: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "SendDlgItemMessageA")]
        [return: MarshalAs(UnmanagedType.SysInt)]
        public static extern int SendDlgItemMessageA(
            [In] IntPtr hDlg, int nIDDlgItem, uint Msg, [MarshalAs(UnmanagedType.SysUInt)] uint wParam, [MarshalAs(UnmanagedType.SysInt)] int lParam);

        /// Return Type: UINT->unsigned int
        ///hwnd: HWND->HWND__*
        ///ptszClassName: LPWSTR->WCHAR*
        ///cchClassNameMax: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "RealGetWindowClassW")]
        public static extern uint RealGetWindowClassW(
            [In] IntPtr hwnd, [Out] [MarshalAs(UnmanagedType.LPWStr)] StringBuilder ptszClassName, uint cchClassNameMax);

        /// Return Type: UINT->unsigned int
        ///hwnd: HWND->HWND__*
        ///ptszClassName: LPSTR->CHAR*
        ///cchClassNameMax: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "RealGetWindowClassA")]
        public static extern uint RealGetWindowClassA(
            [In] IntPtr hwnd, [Out] [MarshalAs(UnmanagedType.LPStr)] StringBuilder ptszClassName, uint cchClassNameMax);

        /// Return Type: int
        ///lpmbp: MSGBOXPARAMSW*
        [DllImport("user32.dll", EntryPoint = "MessageBoxIndirectW")]
        public static extern int MessageBoxIndirectW([In] ref MSGBOXPARAMSW lpmbp);

        /// Return Type: int
        ///lpmbp: MSGBOXPARAMSA*
        [DllImport("user32.dll", EntryPoint = "MessageBoxIndirectA")]
        public static extern int MessageBoxIndirectA([In] ref MSGBOXPARAMSA lpmbp);

        /// Return Type: HKL->HKL__*
        ///pwszKLID: LPCWSTR->WCHAR*
        ///Flags: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "LoadKeyboardLayoutW")]
        public static extern IntPtr LoadKeyboardLayoutW([In] [MarshalAs(UnmanagedType.LPWStr)] string pwszKLID, uint Flags);

        /// Return Type: HKL->HKL__*
        ///pwszKLID: LPCSTR->CHAR*
        ///Flags: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "LoadKeyboardLayoutA")]
        public static extern IntPtr LoadKeyboardLayoutA([In] [MarshalAs(UnmanagedType.LPStr)] string pwszKLID, uint Flags);

        /// Return Type: HCURSOR->HICON->HICON__*
        ///lpFileName: LPCWSTR->WCHAR*
        [DllImport("user32.dll", EntryPoint = "LoadCursorFromFileW")]
        public static extern IntPtr LoadCursorFromFileW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);

        /// Return Type: HCURSOR->HICON->HICON__*
        ///lpFileName: LPCSTR->CHAR*
        [DllImport("user32.dll", EntryPoint = "LoadCursorFromFileA")]
        public static extern IntPtr LoadCursorFromFileA([In] [MarshalAs(UnmanagedType.LPStr)] string lpFileName);

        /// Return Type: BOOL->int
        ///ch: WCHAR->wchar_t->unsigned short
        [DllImport("user32.dll", EntryPoint = "IsCharAlphaNumericW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsCharAlphaNumericW(char ch);

        /// Return Type: BOOL->int
        ///ch: CHAR->char
        [DllImport("user32.dll", EntryPoint = "IsCharAlphaNumericA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsCharAlphaNumericA(byte ch);

        /// Return Type: HWND->HWND__*
        ///hDlg: HWND->HWND__*
        ///hCtl: HWND->HWND__*
        ///bPrevious: BOOL->int
        [DllImport("user32.dll", EntryPoint = "GetNextDlgGroupItem")]
        public static extern IntPtr GetNextDlgGroupItem([In] IntPtr hDlg, [In] IntPtr hCtl, [MarshalAs(UnmanagedType.Bool)] bool bPrevious);

        /// Return Type: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "GetMessageExtraInfo")]
        [return: MarshalAs(UnmanagedType.SysInt)]
        public static extern int GetMessageExtraInfo();

        /// Return Type: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "GetForegroundWindow")]
        public static extern IntPtr GetForegroundWindow();

        /// Return Type: BOOL->int
        ///lpEnumFunc: WINSTAENUMPROCW->NAMEENUMPROCW
        ///lParam: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "EnumWindowStationsW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumWindowStationsW(NAMEENUMPROCW lpEnumFunc, [MarshalAs(UnmanagedType.SysInt)] int lParam);

        /// Return Type: BOOL->int
        ///lpEnumFunc: WINSTAENUMPROCA->NAMEENUMPROCA
        ///lParam: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "EnumWindowStationsA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumWindowStationsA(NAMEENUMPROCA lpEnumFunc, [MarshalAs(UnmanagedType.SysInt)] int lParam);

        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///lprcClip: LPCRECT->RECT*
        ///lpfnEnum: MONITORENUMPROC
        ///dwData: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "EnumDisplayMonitors")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumDisplayMonitors(
            [In] IntPtr hdc, [In] IntPtr lprcClip, MONITORENUMPROC lpfnEnum, [MarshalAs(UnmanagedType.SysInt)] int dwData);

        /// Return Type: BOOL->int
        ///lpDevice: LPCWSTR->WCHAR*
        ///iDevNum: DWORD->unsigned int
        ///lpDisplayDevice: PDISPLAY_DEVICEW->_DISPLAY_DEVICEW*
        ///dwFlags: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "EnumDisplayDevicesW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumDisplayDevicesW(
            [In] [MarshalAs(UnmanagedType.LPWStr)] string lpDevice, uint iDevNum, ref DISPLAY_DEVICEW lpDisplayDevice, uint dwFlags);

        /// Return Type: BOOL->int
        ///lpDevice: LPCSTR->CHAR*
        ///iDevNum: DWORD->unsigned int
        ///lpDisplayDevice: PDISPLAY_DEVICEA->_DISPLAY_DEVICEA*
        ///dwFlags: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "EnumDisplayDevicesA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumDisplayDevicesA(
            [In] [MarshalAs(UnmanagedType.LPStr)] string lpDevice, uint iDevNum, ref DISPLAY_DEVICEA lpDisplayDevice, uint dwFlags);

        /// Return Type: int
        ///hDlg: HWND->HWND__*
        ///lpPathSpec: LPWSTR->WCHAR*
        ///nIDComboBox: int
        ///nIDStaticPath: int
        ///uFiletype: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "DlgDirListComboBoxW")]
        public static extern int DlgDirListComboBoxW([In] IntPtr hDlg, IntPtr lpPathSpec, int nIDComboBox, int nIDStaticPath, uint uFiletype);

        /// Return Type: int
        ///hDlg: HWND->HWND__*
        ///lpPathSpec: LPSTR->CHAR*
        ///nIDComboBox: int
        ///nIDStaticPath: int
        ///uFiletype: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "DlgDirListComboBoxA")]
        public static extern int DlgDirListComboBoxA([In] IntPtr hDlg, IntPtr lpPathSpec, int nIDComboBox, int nIDStaticPath, uint uFiletype);

        /// Return Type: BOOL->int
        ///idInst: DWORD->unsigned int
        ///hsz: HSZ->HSZ__*
        [DllImport("user32.dll", EntryPoint = "DdeKeepStringHandle")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DdeKeepStringHandle(uint idInst, IntPtr hsz);

        /// Return Type: BOOL->int
        ///idInst: DWORD->unsigned int
        ///hsz: HSZ->HSZ__*
        [DllImport("user32.dll", EntryPoint = "DdeFreeStringHandle")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DdeFreeStringHandle(uint idInst, IntPtr hsz);

        /// Return Type: HDDEDATA->HDDEDATA__*
        ///idInst: DWORD->unsigned int
        ///pSrc: LPBYTE->BYTE*
        ///cb: DWORD->unsigned int
        ///cbOff: DWORD->unsigned int
        ///hszItem: HSZ->HSZ__*
        ///wFmt: UINT->unsigned int
        ///afCmd: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "DdeCreateDataHandle")]
        public static extern IntPtr DdeCreateDataHandle(uint idInst, ref byte pSrc, uint cb, uint cbOff, IntPtr hszItem, uint wFmt, uint afCmd);

        /// Return Type: int
        ///hsz1: HSZ->HSZ__*
        ///hsz2: HSZ->HSZ__*
        [DllImport("user32.dll", EntryPoint = "DdeCmpStringHandles")]
        public static extern int DdeCmpStringHandles(IntPtr hsz1, IntPtr hsz2);

        /// Return Type: HDWP->HANDLE->void*
        ///nNumWindows: int
        [DllImport("user32.dll", EntryPoint = "BeginDeferWindowPos")]
        public static extern IntPtr BeginDeferWindowPos(int nNumWindows);

        /// Return Type: void
        ///hwnd: HWND->HWND__*
        ///fUnknown: BOOL->int
        [DllImport("user32.dll", EntryPoint = "SwitchToThisWindow")]
        public static extern void SwitchToThisWindow([In] IntPtr hwnd, [MarshalAs(UnmanagedType.Bool)] bool fUnknown);

        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///lpwndpl: WINDOWPLACEMENT*
        [DllImport("user32.dll", EntryPoint = "SetWindowPlacement")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowPlacement([In] IntPtr hWnd, [In] ref WINDOWPLACEMENT lpwndpl);

        /// Return Type: BOOL->int
        ///hMenu: HMENU->HMENU__*
        ///uPosition: UINT->unsigned int
        ///uFlags: UINT->unsigned int
        ///hBitmapUnchecked: HBITMAP->HBITMAP__*
        ///hBitmapChecked: HBITMAP->HBITMAP__*
        [DllImport("user32.dll", EntryPoint = "SetMenuItemBitmaps")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetMenuItemBitmaps([In] IntPtr hMenu, uint uPosition, uint uFlags, [In] IntPtr hBitmapUnchecked, [In] IntPtr hBitmapChecked);

        /// Return Type: BOOL->int
        ///hMenu: HMENU->HMENU__*
        ///uItem: UINT->unsigned int
        ///fByPos: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "SetMenuDefaultItem")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetMenuDefaultItem([In] IntPtr hMenu, uint uItem, uint fByPos);

        /// Return Type: BOOL->int
        ///param0: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "SetDoubleClickTime")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetDoubleClickTime(uint param0);

        /// Return Type: void
        ///dwLevel: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "SetDebugErrorLevel")]
        public static extern void SetDebugErrorLevel(uint dwLevel);

        /// Return Type: HWND->HWND__*
        ///hWndNewViewer: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "SetClipboardViewer")]
        public static extern IntPtr SetClipboardViewer([In] IntPtr hWndNewViewer);

        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///Msg: UINT->unsigned int
        ///wParam: WPARAM->UINT_PTR->unsigned int
        ///lParam: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "SendNotifyMessageW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SendNotifyMessageW(
            [In] IntPtr hWnd, uint Msg, [MarshalAs(UnmanagedType.SysUInt)] uint wParam, [MarshalAs(UnmanagedType.SysInt)] int lParam);

        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///Msg: UINT->unsigned int
        ///wParam: WPARAM->UINT_PTR->unsigned int
        ///lParam: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "SendNotifyMessageA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SendNotifyMessageA(
            [In] IntPtr hWnd, uint Msg, [MarshalAs(UnmanagedType.SysUInt)] uint wParam, [MarshalAs(UnmanagedType.SysInt)] int lParam);

        /// Return Type: BOOL->int
        ///idThread: DWORD->unsigned int
        ///Msg: UINT->unsigned int
        ///wParam: WPARAM->UINT_PTR->unsigned int
        ///lParam: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "PostThreadMessageW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PostThreadMessageW(
            uint idThread, uint Msg, [MarshalAs(UnmanagedType.SysUInt)] uint wParam, [MarshalAs(UnmanagedType.SysInt)] int lParam);

        /// Return Type: BOOL->int
        ///idThread: DWORD->unsigned int
        ///Msg: UINT->unsigned int
        ///wParam: WPARAM->UINT_PTR->unsigned int
        ///lParam: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "PostThreadMessageA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PostThreadMessageA(
            uint idThread, uint Msg, [MarshalAs(UnmanagedType.SysUInt)] uint wParam, [MarshalAs(UnmanagedType.SysInt)] int lParam);

        /// Return Type: HWINSTA->HWINSTA__*
        ///lpszWinSta: LPCWSTR->WCHAR*
        ///fInherit: BOOL->int
        ///dwDesiredAccess: ACCESS_MASK->DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "OpenWindowStationW")]
        public static extern IntPtr OpenWindowStationW(
            [In] [MarshalAs(UnmanagedType.LPWStr)] string lpszWinSta, [MarshalAs(UnmanagedType.Bool)] bool fInherit, uint dwDesiredAccess);

        /// Return Type: HWINSTA->HWINSTA__*
        ///lpszWinSta: LPCSTR->CHAR*
        ///fInherit: BOOL->int
        ///dwDesiredAccess: ACCESS_MASK->DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "OpenWindowStationA")]
        public static extern IntPtr OpenWindowStationA(
            [In] [MarshalAs(UnmanagedType.LPStr)] string lpszWinSta, [MarshalAs(UnmanagedType.Bool)] bool fInherit, uint dwDesiredAccess);

        /// Return Type: UINT->unsigned int
        ///hDlg: HWND->HWND__*
        ///nIDButton: int
        [DllImport("user32.dll", EntryPoint = "IsDlgButtonChecked")]
        public static extern uint IsDlgButtonChecked([In] IntPtr hDlg, int nIDButton);

        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///lpwndpl: WINDOWPLACEMENT*
        [DllImport("user32.dll", EntryPoint = "GetWindowPlacement")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetWindowPlacement([In] IntPtr hWnd, ref WINDOWPLACEMENT lpwndpl);

        /// Return Type: UINT->unsigned int
        ///hMenu: HMENU->HMENU__*
        ///fByPos: UINT->unsigned int
        ///gmdiFlags: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "GetMenuDefaultItem")]
        public static extern uint GetMenuDefaultItem([In] IntPtr hMenu, uint fByPos, uint gmdiFlags);

        /// Return Type: HWND->HWND__*
        ///hWnd: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "GetLastActivePopup")]
        public static extern IntPtr GetLastActivePopup([In] IntPtr hWnd);

        /// Return Type: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "GetDoubleClickTime")]
        public static extern uint GetDoubleClickTime();

        /// Return Type: int
        [DllImport("user32.dll", EntryPoint = "GetDialogBaseUnits")]
        public static extern int GetDialogBaseUnits();

        /// Return Type: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "GetClipboardViewer")]
        public static extern IntPtr GetClipboardViewer();

        /// Return Type: BOOL->int
        ///hDesktop: HDESK->HDESK__*
        ///lpfn: WNDENUMPROC
        ///lParam: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "EnumDesktopWindows")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumDesktopWindows([In] IntPtr hDesktop, WNDENUMPROC lpfn, [MarshalAs(UnmanagedType.SysInt)] int lParam);

        /// Return Type: HCONV->HCONV__*
        ///hConvList: HCONVLIST->HCONVLIST__*
        ///hConvPrev: HCONV->HCONV__*
        [DllImport("user32.dll", EntryPoint = "DdeQueryNextServer")]
        public static extern IntPtr DdeQueryNextServer(IntPtr hConvList, IntPtr hConvPrev);

        /// Return Type: HICON->HICON__*
        ///piconinfo: PICONINFO->ICONINFO*
        [DllImport("user32.dll", EntryPoint = "CreateIconIndirect")]
        public static extern IntPtr CreateIconIndirect([In] ref ICONINFO piconinfo);

        /// Return Type: HWND->HWND__*
        ///hInstance: HINSTANCE->HINSTANCE__*
        ///lpTemplateName: LPCWSTR->WCHAR*
        ///hWndParent: HWND->HWND__*
        ///lpDialogFunc: DLGPROC
        ///dwInitParam: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "CreateDialogParamW")]
        public static extern IntPtr CreateDialogParamW(
            [In] IntPtr hInstance, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpTemplateName, [In] IntPtr hWndParent, DLGPROC lpDialogFunc,
            [MarshalAs(UnmanagedType.SysInt)] int dwInitParam);

        /// Return Type: HWND->HWND__*
        ///hInstance: HINSTANCE->HINSTANCE__*
        ///lpTemplateName: LPCSTR->CHAR*
        ///hWndParent: HWND->HWND__*
        ///lpDialogFunc: DLGPROC
        ///dwInitParam: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "CreateDialogParamA")]
        public static extern IntPtr CreateDialogParamA(
            [In] IntPtr hInstance, [In] [MarshalAs(UnmanagedType.LPStr)] string lpTemplateName, [In] IntPtr hWndParent, DLGPROC lpDialogFunc,
            [MarshalAs(UnmanagedType.SysInt)] int dwInitParam);

        /// Return Type: BOOL->int
        ///hWinSta: HWINSTA->HWINSTA__*
        [DllImport("user32.dll", EntryPoint = "CloseWindowStation")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CloseWindowStation([In] IntPtr hWinSta);

        /// Return Type: BOOL->int
        ///hmenu: HMENU->HMENU__*
        ///first: UINT->unsigned int
        ///last: UINT->unsigned int
        ///check: UINT->unsigned int
        ///flags: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "CheckMenuRadioItem")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CheckMenuRadioItem([In] IntPtr hmenu, uint first, uint last, uint check, uint flags);

        /// Return Type: BOOL->int
        ///lpRect: LPRECT->tagRECT*
        ///dwStyle: DWORD->unsigned int
        ///bMenu: BOOL->int
        ///dwExStyle: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "AdjustWindowRectEx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AdjustWindowRectEx(ref RECT lpRect, uint dwStyle, [MarshalAs(UnmanagedType.Bool)] bool bMenu, uint dwExStyle);

        /// Return Type: BOOL->int
        ///nCode: int
        ///pfnFilterProc: HOOKPROC
        [DllImport("user32.dll", EntryPoint = "UnhookWindowsHook")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool UnhookWindowsHook(int nCode, HOOKPROC pfnFilterProc);

        /// Return Type: HHOOK->HHOOK__*
        ///idHook: int
        ///lpfn: HOOKPROC
        ///hmod: HINSTANCE->HINSTANCE__*
        ///dwThreadId: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "SetWindowsHookExW")]
        public static extern IntPtr SetWindowsHookExW(int idHook, HOOKPROC lpfn, [In] IntPtr hmod, uint dwThreadId);

        /// Return Type: HHOOK->HHOOK__*
        ///idHook: int
        ///lpfn: HOOKPROC
        ///hmod: HINSTANCE->HINSTANCE__*
        ///dwThreadId: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "SetWindowsHookExA")]
        public static extern IntPtr SetWindowsHookExA(int idHook, HOOKPROC lpfn, [In] IntPtr hmod, uint dwThreadId);

        /// Return Type: BOOL->int
        ///uMSeconds: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "SetCaretBlinkTime")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetCaretBlinkTime(uint uMSeconds);

        /// Return Type: HMONITOR->HMONITOR__*
        ///hwnd: HWND->HWND__*
        ///dwFlags: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "MonitorFromWindow")]
        public static extern IntPtr MonitorFromWindow([In] IntPtr hwnd, uint dwFlags);

        /// Return Type: int
        ///hWnd: HWND->HWND__*
        ///hMenu: HMENU->HMENU__*
        ///ptScreen: POINT->tagPOINT
        [DllImport("user32.dll", EntryPoint = "MenuItemFromPoint")]
        public static extern int MenuItemFromPoint([In] IntPtr hWnd, [In] IntPtr hMenu, Point ptScreen);

        /// Return Type: HMENU->HMENU__*
        ///lpMenuTemplate: MENUTEMPLATEW*
        [DllImport("user32.dll", EntryPoint = "LoadMenuIndirectW")]
        public static extern IntPtr LoadMenuIndirectW([In] IntPtr lpMenuTemplate);

        /// Return Type: HMENU->HMENU__*
        ///lpMenuTemplate: MENUTEMPLATEA*
        [DllImport("user32.dll", EntryPoint = "LoadMenuIndirectA")]
        public static extern IntPtr LoadMenuIndirectA([In] IntPtr lpMenuTemplate);

        /// Return Type: HACCEL->HACCEL__*
        ///hInstance: HINSTANCE->HINSTANCE__*
        ///lpTableName: LPCWSTR->WCHAR*
        [DllImport("user32.dll", EntryPoint = "LoadAcceleratorsW")]
        public static extern IntPtr LoadAcceleratorsW([In] IntPtr hInstance, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpTableName);

        /// Return Type: HACCEL->HACCEL__*
        ///hInstance: HINSTANCE->HINSTANCE__*
        ///lpTableName: LPCSTR->CHAR*
        [DllImport("user32.dll", EntryPoint = "LoadAcceleratorsA")]
        public static extern IntPtr LoadAcceleratorsA([In] IntPtr hInstance, [In] [MarshalAs(UnmanagedType.LPStr)] string lpTableName);

        /// Return Type: UINT->unsigned int
        ///pData: PRAWINPUT->tagRAWINPUT*
        ///pcbSize: PUINT->unsigned int*
        ///cbSizeHeader: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "GetRawInputBuffer")]
        public static extern uint GetRawInputBuffer(IntPtr pData, ref uint pcbSize, uint cbSizeHeader);

        /// Return Type: HWND->HWND__*
        ///hDlg: HWND->HWND__*
        ///hCtl: HWND->HWND__*
        ///bPrevious: BOOL->int
        [DllImport("user32.dll", EntryPoint = "GetNextDlgTabItem")]
        public static extern IntPtr GetNextDlgTabItem([In] IntPtr hDlg, [In] IntPtr hCtl, [MarshalAs(UnmanagedType.Bool)] bool bPrevious);

        /// Return Type: HKL->HKL__*
        ///idThread: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "GetKeyboardLayout")]
        public static extern IntPtr GetKeyboardLayout(uint idThread);

        /// Return Type: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "GetClipboardOwner")]
        public static extern IntPtr GetClipboardOwner();

        /// Return Type: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "GetCaretBlinkTime")]
        public static extern uint GetCaretBlinkTime();

        /// Return Type: BOOL->int
        ///dwThreadId: DWORD->unsigned int
        ///lpfn: WNDENUMPROC
        ///lParam: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "EnumThreadWindows")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumThreadWindows(uint dwThreadId, WNDENUMPROC lpfn, [MarshalAs(UnmanagedType.SysInt)] int lParam);

        /// Return Type: BOOL->int
        ///hWinPosInfo: HDWP->HANDLE->void*
        [DllImport("user32.dll", EntryPoint = "EndDeferWindowPos")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EndDeferWindowPos([In] IntPtr hWinPosInfo);

        /// Return Type: BOOL->int
        ///hwnd: HWND->HWND__*
        ///idAni: int
        ///lprcFrom: RECT*
        ///lprcTo: RECT*
        [DllImport("user32.dll", EntryPoint = "DrawAnimatedRects")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DrawAnimatedRects([In] IntPtr hwnd, int idAni, [In] ref RECT lprcFrom, [In] ref RECT lprcTo);

        /// Return Type: BOOL->int
        ///hData: HDDEDATA->HDDEDATA__*
        [DllImport("user32.dll", EntryPoint = "DdeFreeDataHandle")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DdeFreeDataHandle(IntPtr hData);

        /// Return Type: BOOL->int
        ///idInst: DWORD->unsigned int
        ///hConv: HCONV->HCONV__*
        ///wCmd: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "DdeEnableCallback")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DdeEnableCallback(uint idInst, IntPtr hConv, uint wCmd);

        /// Return Type: BOOL->int
        ///hConvList: HCONVLIST->HCONVLIST__*
        [DllImport("user32.dll", EntryPoint = "DdeDisconnectList")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DdeDisconnectList(IntPtr hConvList);

        /// Return Type: BOOL->int
        ///idAttach: DWORD->unsigned int
        ///idAttachTo: DWORD->unsigned int
        ///fAttach: BOOL->int
        [DllImport("user32.dll", EntryPoint = "AttachThreadInput")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AttachThreadInput(uint idAttach, uint idAttachTo, [MarshalAs(UnmanagedType.Bool)] bool fAttach);

        /// Return Type: DWORD->unsigned int
        ///hProcess: HANDLE->void*
        ///dwMilliseconds: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "WaitForInputIdle")]
        public static extern uint WaitForInputIdle([In] IntPtr hProcess, uint dwMilliseconds);

        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///id: int
        [DllImport("user32.dll", EntryPoint = "UnregisterHotKey")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool UnregisterHotKey([In] IntPtr hWnd, int id);

        /// Return Type: BOOL->int
        ///lpClassName: LPCWSTR->WCHAR*
        ///hInstance: HINSTANCE->HINSTANCE__*
        [DllImport("user32.dll", EntryPoint = "UnregisterClassW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool UnregisterClassW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpClassName, [In] IntPtr hInstance);

        /// Return Type: BOOL->int
        ///lpClassName: LPCSTR->CHAR*
        ///hInstance: HINSTANCE->HINSTANCE__*
        [DllImport("user32.dll", EntryPoint = "UnregisterClassA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool UnregisterClassA([In] [MarshalAs(UnmanagedType.LPStr)] string lpClassName, [In] IntPtr hInstance);

        /// Return Type: BOOL->int
        ///lpMsg: MSG*
        [DllImport("user32.dll", EntryPoint = "TranslateMessage")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool TranslateMessage([In] ref MSG lpMsg);

        /// Return Type: BOOL->int
        ///param0: HMENU->HMENU__*
        ///param1: UINT->unsigned int
        ///param2: int
        ///param3: int
        ///param4: HWND->HWND__*
        ///param5: LPTPMPARAMS->TPMPARAMS*
        [DllImport("user32.dll", EntryPoint = "TrackPopupMenuEx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool TrackPopupMenuEx([In] IntPtr param0, uint param1, int param2, int param3, [In] IntPtr param4, [In] IntPtr param5);

        /// Return Type: BOOL->int
        ///hDesktop: HDESK->HDESK__*
        [DllImport("user32.dll", EntryPoint = "SetThreadDesktop")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetThreadDesktop([In] IntPtr hDesktop);

        /// Return Type: BOOL->int
        ///hmenu: HMENU->HMENU__*
        ///item: UINT->unsigned int
        ///fByPositon: BOOL->int
        ///lpmii: LPCMENUITEMINFOW->MENUITEMINFOW*
        [DllImport("user32.dll", EntryPoint = "SetMenuItemInfoW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetMenuItemInfoW(
            [In] IntPtr hmenu, uint item, [MarshalAs(UnmanagedType.Bool)] bool fByPositon, [In] ref MENUITEMINFOW lpmii);

        /// Return Type: BOOL->int
        ///hmenu: HMENU->HMENU__*
        ///item: UINT->unsigned int
        ///fByPositon: BOOL->int
        ///lpmii: LPCMENUITEMINFOA->MENUITEMINFOA*
        [DllImport("user32.dll", EntryPoint = "SetMenuItemInfoA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetMenuItemInfoA(
            [In] IntPtr hmenu, uint item, [MarshalAs(UnmanagedType.Bool)] bool fByPositon, [In] ref MENUITEMINFOA lpmii);

        /// Return Type: BOOL->int
        ///lpKeyState: LPBYTE->BYTE*
        [DllImport("user32.dll", EntryPoint = "SetKeyboardState")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetKeyboardState([MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I1, SizeConst = 256)] byte[] lpKeyState);

        /// Return Type: HANDLE->void*
        ///uFormat: UINT->unsigned int
        ///hMem: HANDLE->void*
        [DllImport("user32.dll", EntryPoint = "SetClipboardData")]
        public static extern IntPtr SetClipboardData(uint uFormat, [In] IntPtr hMem);

        /// Return Type: ATOM->WORD->unsigned short
        ///param0: WNDCLASSEXW*
        [DllImport("user32.dll", EntryPoint = "RegisterClassExW")]
        public static extern ushort RegisterClassExW([In] ref WNDCLASSEXW param0);

        /// Return Type: ATOM->WORD->unsigned short
        ///param0: WNDCLASSEXA*
        [DllImport("user32.dll", EntryPoint = "RegisterClassExA")]
        public static extern ushort RegisterClassExA([In] ref WNDCLASSEXA param0);

        /// Return Type: HDESK->HDESK__*
        ///dwFlags: DWORD->unsigned int
        ///fInherit: BOOL->int
        ///dwDesiredAccess: ACCESS_MASK->DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "OpenInputDesktop")]
        public static extern IntPtr OpenInputDesktop(uint dwFlags, [MarshalAs(UnmanagedType.Bool)] bool fInherit, uint dwDesiredAccess);

        /// Return Type: HMONITOR->HMONITOR__*
        ///pt: POINT->tagPOINT
        ///dwFlags: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "MonitorFromPoint")]
        public static extern IntPtr MonitorFromPoint(Point pt, uint dwFlags);

        /// Return Type: UINT->unsigned int
        ///uCode: UINT->unsigned int
        ///uMapType: UINT->unsigned int
        ///dwhkl: HKL->HKL__*
        [DllImport("user32.dll", EntryPoint = "MapVirtualKeyExW")]
        public static extern uint MapVirtualKeyExW(uint uCode, uint uMapType, [In] IntPtr dwhkl);

        /// Return Type: UINT->unsigned int
        ///uCode: UINT->unsigned int
        ///uMapType: UINT->unsigned int
        ///dwhkl: HKL->HKL__*
        [DllImport("user32.dll", EntryPoint = "MapVirtualKeyExA")]
        public static extern uint MapVirtualKeyExA(uint uCode, uint uMapType, [In] IntPtr dwhkl);

        /// Return Type: BOOL->int
        ///hWndLock: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "LockWindowUpdate")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool LockWindowUpdate([In] IntPtr hWndLock);

        /// Return Type: BOOL->int
        ///hDlg: HWND->HWND__*
        ///lpMsg: LPMSG->tagMSG*
        [DllImport("user32.dll", EntryPoint = "IsDialogMessageW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsDialogMessageW([In] IntPtr hDlg, [In] ref MSG lpMsg);

        /// Return Type: BOOL->int
        ///hDlg: HWND->HWND__*
        ///lpMsg: LPMSG->tagMSG*
        [DllImport("user32.dll", EntryPoint = "IsDialogMessageA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsDialogMessageA([In] IntPtr hDlg, [In] ref MSG lpMsg);

        /// Return Type: HDESK->HDESK__*
        ///dwThreadId: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "GetThreadDesktop")]
        public static extern IntPtr GetThreadDesktop(uint dwThreadId);

        /// Return Type: int
        ///nIndex: int
        [DllImport("user32.dll", EntryPoint = "GetSystemMetrics")]
        public static extern int GetSystemMetrics(int nIndex);

        /// Return Type: HBRUSH->HBRUSH__*
        ///nIndex: int
        [DllImport("user32.dll", EntryPoint = "GetSysColorBrush")]
        public static extern IntPtr GetSysColorBrush(int nIndex);

        /// Return Type: BOOL->int
        ///hwnd: HWND->HWND__*
        ///idObject: LONG->int
        ///psbi: PSCROLLBARINFO->tagSCROLLBARINFO*
        [DllImport("user32.dll", EntryPoint = "GetScrollBarInfo")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetScrollBarInfo([In] IntPtr hwnd, int idObject, ref SCROLLBARINFO psbi);

        /// Return Type: BOOL->int
        ///hmenu: HMENU->HMENU__*
        ///item: UINT->unsigned int
        ///fByPosition: BOOL->int
        ///lpmii: LPMENUITEMINFOW->tagMENUITEMINFOW*
        [DllImport("user32.dll", EntryPoint = "GetMenuItemInfoW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetMenuItemInfoW([In] IntPtr hmenu, uint item, [MarshalAs(UnmanagedType.Bool)] bool fByPosition, ref MENUITEMINFOW lpmii);

        /// Return Type: BOOL->int
        ///hmenu: HMENU->HMENU__*
        ///item: UINT->unsigned int
        ///fByPosition: BOOL->int
        ///lpmii: LPMENUITEMINFOA->tagMENUITEMINFOA*
        [DllImport("user32.dll", EntryPoint = "GetMenuItemInfoA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetMenuItemInfoA([In] IntPtr hmenu, uint item, [MarshalAs(UnmanagedType.Bool)] bool fByPosition, ref MENUITEMINFOA lpmii);

        /// Return Type: int
        ///hMenu: HMENU->HMENU__*
        [DllImport("user32.dll", EntryPoint = "GetMenuItemCount")]
        public static extern int GetMenuItemCount([In] IntPtr hMenu);

        /// Return Type: BOOL->int
        ///plii: PLASTINPUTINFO->tagLASTINPUTINFO*
        [DllImport("user32.dll", EntryPoint = "GetLastInputInfo")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetLastInputInfo([Out] out LASTINPUTINFO plii);

        /// Return Type: BOOL->int
        ///lpKeyState: PBYTE->BYTE*
        [DllImport("user32.dll", EntryPoint = "GetKeyboardState")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetKeyboardState(IntPtr lpKeyState);

        /// Return Type: BOOL->int
        ///idThread: DWORD->unsigned int
        ///pgui: PGUITHREADINFO->tagGUITHREADINFO*
        [DllImport("user32.dll", EntryPoint = "GetGUIThreadInfo")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetGUIThreadInfo(uint idThread, ref GUITHREADINFO pgui);

        /// Return Type: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "GetDesktopWindow")]
        public static extern IntPtr GetDesktopWindow();

        /// Return Type: HANDLE->void*
        ///uFormat: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "GetClipboardData")]
        public static extern IntPtr GetClipboardData(uint uFormat);

        /// Return Type: SHORT->short
        ///vKey: int
        [DllImport("user32.dll", EntryPoint = "GetAsyncKeyState")]
        public static extern short GetAsyncKeyState(int vKey);

        /// Return Type: int
        ///hDC: HDC->HDC__*
        ///hWnd: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "ExcludeUpdateRgn")]
        public static extern int ExcludeUpdateRgn([In] IntPtr hDC, [In] IntPtr hWnd);

        /// Return Type: BOOL->int
        ///hWndParent: HWND->HWND__*
        ///lpEnumFunc: WNDENUMPROC
        ///lParam: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "EnumChildWindows")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumChildWindows([In] IntPtr hWndParent, WNDENUMPROC lpEnumFunc, [MarshalAs(UnmanagedType.SysInt)] int lParam);

        /// Return Type: BOOL->int
        ///param0: HDC->HDC__*
        ///param1: LPRECT->tagRECT*
        ///param2: UINT->unsigned int
        ///param3: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "DrawFrameControl")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DrawFrameControl([In] IntPtr param0, ref RECT param1, uint param2, uint param3);

        /// Return Type: LRESULT->LONG_PTR->int
        ///lpMsg: MSG*
        [DllImport("user32.dll", EntryPoint = "DispatchMessageW")]
        [return: MarshalAs(UnmanagedType.SysInt)]
        public static extern int DispatchMessageW([In] ref MSG lpMsg);

        /// Return Type: LRESULT->LONG_PTR->int
        ///lpMsg: MSG*
        [DllImport("user32.dll", EntryPoint = "DispatchMessageA")]
        [return: MarshalAs(UnmanagedType.SysInt)]
        public static extern int DispatchMessageA([In] ref MSG lpMsg);

        /// Return Type: LRESULT->LONG_PTR->int
        ///hWnd: HWND->HWND__*
        ///uMsg: UINT->unsigned int
        ///wParam: WPARAM->UINT_PTR->unsigned int
        ///lParam: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "DefMDIChildProcW")]
        [return: MarshalAs(UnmanagedType.SysInt)]
        public static extern int DefMDIChildProcW(
            [In] IntPtr hWnd, uint uMsg, [MarshalAs(UnmanagedType.SysUInt)] uint wParam, [MarshalAs(UnmanagedType.SysInt)] int lParam);

        /// Return Type: LRESULT->LONG_PTR->int
        ///hWnd: HWND->HWND__*
        ///uMsg: UINT->unsigned int
        ///wParam: WPARAM->UINT_PTR->unsigned int
        ///lParam: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "DefMDIChildProcA")]
        [return: MarshalAs(UnmanagedType.SysInt)]
        public static extern int DefMDIChildProcA(
            [In] IntPtr hWnd, uint uMsg, [MarshalAs(UnmanagedType.SysUInt)] uint wParam, [MarshalAs(UnmanagedType.SysInt)] int lParam);

        /// Return Type: BOOL->int
        ///hConv: HCONV->HCONV__*
        ///id: DWORD->unsigned int
        ///hUser: DWORD_PTR->ULONG_PTR->unsigned int
        [DllImport("user32.dll", EntryPoint = "DdeSetUserHandle")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DdeSetUserHandle(IntPtr hConv, uint id, uint hUser);

        /// Return Type: UINT->unsigned int
        ///hConv: HCONV->HCONV__*
        ///idTransaction: DWORD->unsigned int
        ///pConvInfo: PCONVINFO->CONVINFO*
        [DllImport("user32.dll", EntryPoint = "DdeQueryConvInfo")]
        public static extern uint DdeQueryConvInfo(IntPtr hConv, uint idTransaction, ref CONVINFO pConvInfo);

        /// Return Type: HWND->HWND__*
        ///lpClassName: LPCWSTR->WCHAR*
        ///lpWindowName: LPCWSTR->WCHAR*
        ///dwStyle: DWORD->unsigned int
        ///X: int
        ///Y: int
        ///nWidth: int
        ///nHeight: int
        ///hWndParent: HWND->HWND__*
        ///hInstance: HINSTANCE->HINSTANCE__*
        ///lParam: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "CreateMDIWindowW")]
        public static extern IntPtr CreateMDIWindowW(
            [In] [MarshalAs(UnmanagedType.LPWStr)] string lpClassName, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpWindowName, uint dwStyle, int X, int Y,
            int nWidth, int nHeight, [In] IntPtr hWndParent, [In] IntPtr hInstance, [MarshalAs(UnmanagedType.SysInt)] int lParam);

        /// Return Type: HWND->HWND__*
        ///lpClassName: LPCSTR->CHAR*
        ///lpWindowName: LPCSTR->CHAR*
        ///dwStyle: DWORD->unsigned int
        ///X: int
        ///Y: int
        ///nWidth: int
        ///nHeight: int
        ///hWndParent: HWND->HWND__*
        ///hInstance: HINSTANCE->HINSTANCE__*
        ///lParam: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "CreateMDIWindowA")]
        public static extern IntPtr CreateMDIWindowA(
            [In] [MarshalAs(UnmanagedType.LPStr)] string lpClassName, [In] [MarshalAs(UnmanagedType.LPStr)] string lpWindowName, uint dwStyle, int X, int Y,
            int nWidth, int nHeight, [In] IntPtr hWndParent, [In] IntPtr hInstance, [MarshalAs(UnmanagedType.SysInt)] int lParam);

        /// Return Type: BOOL->int
        ///hDlg: HWND->HWND__*
        ///nIDFirstButton: int
        ///nIDLastButton: int
        ///nIDCheckButton: int
        [DllImport("user32.dll", EntryPoint = "CheckRadioButton")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CheckRadioButton([In] IntPtr hDlg, int nIDFirstButton, int nIDLastButton, int nIDCheckButton);

        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "BringWindowToTop")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool BringWindowToTop([In] IntPtr hWnd);

        /// Return Type: BOOL->int
        ///lpRect: LPRECT->tagRECT*
        ///dwStyle: DWORD->unsigned int
        ///bMenu: BOOL->int
        [DllImport("user32.dll", EntryPoint = "AdjustWindowRect")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AdjustWindowRect(ref RECT lpRect, uint dwStyle, [MarshalAs(UnmanagedType.Bool)] bool bMenu);

        /// Return Type: HWND->HWND__*
        ///Point: POINT->tagPOINT
        [DllImport("user32.dll", EntryPoint = "WindowFromPoint")]
        public static extern IntPtr WindowFromPoint(Point Point);

        /// Return Type: BOOL->int
        ///msg: UINT->unsigned int
        ///lParam: LPARAM->LONG_PTR->int
        ///puiLo: PUINT_PTR->unsigned int*
        ///puiHi: PUINT_PTR->unsigned int*
        [DllImport("user32.dll", EntryPoint = "UnpackDDElParam")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool UnpackDDElParam(uint msg, [MarshalAs(UnmanagedType.SysInt)] int lParam, ref uint puiLo, ref uint puiHi);

        /// Return Type: BOOL->int
        ///lpEventTrack: LPTRACKMOUSEEVENT->tagTRACKMOUSEEVENT*
        [DllImport("user32.dll", EntryPoint = "TrackMouseEvent")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool TrackMouseEvent(ref TRACKMOUSEEVENT lpEventTrack);

        /// Return Type: BOOL->int
        ///fSwap: BOOL->int
        [DllImport("user32.dll", EntryPoint = "SwapMouseButton")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SwapMouseButton([MarshalAs(UnmanagedType.Bool)] bool fSwap);

        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///nCmdShow: int
        [DllImport("user32.dll", EntryPoint = "ShowWindowAsync")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ShowWindowAsync([In] IntPtr hWnd, int nCmdShow);

        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///fShow: BOOL->int
        [DllImport("user32.dll", EntryPoint = "ShowOwnedPopups")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ShowOwnedPopups([In] IntPtr hWnd, [MarshalAs(UnmanagedType.Bool)] bool fShow);

        /// Return Type: HWINEVENTHOOK->HWINEVENTHOOK__*
        ///eventMin: DWORD->unsigned int
        ///eventMax: DWORD->unsigned int
        ///hmodWinEventProc: HMODULE->HINSTANCE->HINSTANCE__*
        ///pfnWinEventProc: WINEVENTPROC
        ///idProcess: DWORD->unsigned int
        ///idThread: DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "SetWinEventHook")]
        public static extern IntPtr SetWinEventHook(
            uint eventMin, uint eventMax, [In] IntPtr hmodWinEventProc, WINEVENTPROC pfnWinEventProc, uint idProcess, uint idThread, uint dwFlags);

        /// Return Type: HHOOK->HHOOK__*
        ///nFilterType: int
        ///pfnFilterProc: HOOKPROC
        [DllImport("user32.dll", EntryPoint = "SetWindowsHookW")]
        public static extern IntPtr SetWindowsHookW(int nFilterType, HOOKPROC pfnFilterProc);

        /// Return Type: HHOOK->HHOOK__*
        ///nFilterType: int
        ///pfnFilterProc: HOOKPROC
        [DllImport("user32.dll", EntryPoint = "SetWindowsHookA")]
        public static extern IntPtr SetWindowsHookA(int nFilterType, HOOKPROC pfnFilterProc);

        /// Return Type: BOOL->int
        ///hcur: HCURSOR->HICON->HICON__*
        ///id: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "SetSystemCursor")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetSystemCursor([In] IntPtr hcur, uint id);

        /// Return Type: BOOL->int
        ///cMessagesMax: int
        [DllImport("user32.dll", EntryPoint = "SetMessageQueue")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetMessageQueue(int cMessagesMax);

        /// Return Type: BOOL->int
        ///hDlg: HWND->HWND__*
        ///nIDDlgItem: int
        ///lpString: LPCWSTR->WCHAR*
        [DllImport("user32.dll", EntryPoint = "SetDlgItemTextW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetDlgItemTextW([In] IntPtr hDlg, int nIDDlgItem, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpString);

        /// Return Type: BOOL->int
        ///hDlg: HWND->HWND__*
        ///nIDDlgItem: int
        ///lpString: LPCSTR->CHAR*
        [DllImport("user32.dll", EntryPoint = "SetDlgItemTextA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetDlgItemTextA([In] IntPtr hDlg, int nIDDlgItem, [In] [MarshalAs(UnmanagedType.LPStr)] string lpString);

        /// Return Type: HWND->HWND__*
        ///hWnd: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "SetActiveWindow")]
        public static extern IntPtr SetActiveWindow([In] IntPtr hWnd);

        /// Return Type: void
        ///nExitCode: int
        [DllImport("user32.dll", EntryPoint = "PostQuitMessage")]
        public static extern void PostQuitMessage(int nExitCode);

        /// Return Type: HMONITOR->HMONITOR__*
        ///lprc: LPCRECT->RECT*
        ///dwFlags: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "MonitorFromRect")]
        public static extern IntPtr MonitorFromRect([In] ref RECT lprc, uint dwFlags);

        /// Return Type: int
        ///hWndFrom: HWND->HWND__*
        ///hWndTo: HWND->HWND__*
        ///lpPoints: LPPOINT->tagPOINT*
        ///cPoints: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "MapWindowPoints")]
        public static extern int MapWindowPoints([In] IntPtr hWndFrom, [In] IntPtr hWndTo, IntPtr lpPoints, uint cPoints);

        /// Return Type: BOOL->int
        [DllImport("user32.dll", EntryPoint = "LockWorkStation")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool LockWorkStation();

        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "IsWindowVisible")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsWindowVisible([In] IntPtr hWnd);

        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "IsWindowUnicode")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsWindowUnicode([In] IntPtr hWnd);

        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "IsWindowEnabled")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsWindowEnabled([In] IntPtr hWnd);

        /// Return Type: BOOL->int
        ///hwnd: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "IsHungAppWindow")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsHungAppWindow([In] IntPtr hwnd);

        /// Return Type: BOOL->int
        ///hmenu: HMENU->HMENU__*
        ///item: UINT->unsigned int
        ///fByPosition: BOOL->int
        ///lpmi: LPCMENUITEMINFOW->MENUITEMINFOW*
        [DllImport("user32.dll", EntryPoint = "InsertMenuItemW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool InsertMenuItemW(
            [In] IntPtr hmenu, uint item, [MarshalAs(UnmanagedType.Bool)] bool fByPosition, [In] ref MENUITEMINFOW lpmi);

        /// Return Type: BOOL->int
        ///hmenu: HMENU->HMENU__*
        ///item: UINT->unsigned int
        ///fByPosition: BOOL->int
        ///lpmi: LPCMENUITEMINFOA->MENUITEMINFOA*
        [DllImport("user32.dll", EntryPoint = "InsertMenuItemA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool InsertMenuItemA(
            [In] IntPtr hmenu, uint item, [MarshalAs(UnmanagedType.Bool)] bool fByPosition, [In] ref MENUITEMINFOA lpmi);

        /// Return Type: DWORD->unsigned int
        ///lpReserved: LPVOID->void*
        [DllImport("user32.dll", EntryPoint = "InSendMessageEx")]
        public static extern uint InSendMessageEx(IntPtr lpReserved);

        /// Return Type: int
        ///hWnd: HWND->HWND__*
        ///lprc: LPRECT->tagRECT*
        [DllImport("user32.dll", EntryPoint = "GetWindowRgnBox")]
        public static extern int GetWindowRgnBox([In] IntPtr hWnd, [Out] out RECT lprc);

        /// Return Type: BOOL->int
        ///hwnd: HWND->HWND__*
        ///pti: PTITLEBARINFO->tagTITLEBARINFO*
        [DllImport("user32.dll", EntryPoint = "GetTitleBarInfo")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetTitleBarInfo([In] IntPtr hwnd, ref TITLEBARINFO pti);

        /// Return Type: UINT->unsigned int
        ///hRawInput: HRAWINPUT->HRAWINPUT__*
        ///uiCommand: UINT->unsigned int
        ///pData: LPVOID->void*
        ///pcbSize: PUINT->unsigned int*
        ///cbSizeHeader: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "GetRawInputData")]
        public static extern uint GetRawInputData([In] IntPtr hRawInput, uint uiCommand, IntPtr pData, ref uint pcbSize, uint cbSizeHeader);

        /// Return Type: BOOL->int
        ///hMonitor: HMONITOR->HMONITOR__*
        ///lpmi: LPMONITORINFO->tagMONITORINFO*
        [DllImport("user32.dll", EntryPoint = "GetMonitorInfoW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetMonitorInfoW([In] IntPtr hMonitor, ref MONITORINFO lpmi);

        /// Return Type: BOOL->int
        ///hMonitor: HMONITOR->HMONITOR__*
        ///lpmi: LPMONITORINFO->tagMONITORINFO*
        [DllImport("user32.dll", EntryPoint = "GetMonitorInfoA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetMonitorInfoA([In] IntPtr hMonitor, ref MONITORINFO lpmi);

        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///hMenu: HMENU->HMENU__*
        ///uItem: UINT->unsigned int
        ///lprcItem: LPRECT->tagRECT*
        [DllImport("user32.dll", EntryPoint = "GetMenuItemRect")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetMenuItemRect([In] IntPtr hWnd, [In] IntPtr hMenu, uint uItem, [Out] out RECT lprcItem);

        /// Return Type: int
        ///lParam: LONG->int
        ///lpString: LPWSTR->WCHAR*
        ///cchSize: int
        [DllImport("user32.dll", EntryPoint = "GetKeyNameTextW")]
        public static extern int GetKeyNameTextW(int lParam, [Out] [MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpString, int cchSize);

        /// Return Type: int
        ///lParam: LONG->int
        ///lpString: LPSTR->CHAR*
        ///cchSize: int
        [DllImport("user32.dll", EntryPoint = "GetKeyNameTextA")]
        public static extern int GetKeyNameTextA(int lParam, [Out] [MarshalAs(UnmanagedType.LPStr)] StringBuilder lpString, int cchSize);

        /// Return Type: int
        ///nTypeFlag: int
        [DllImport("user32.dll", EntryPoint = "GetKeyboardType")]
        public static extern int GetKeyboardType(int nTypeFlag);

        /// Return Type: DWORD->unsigned int
        ///hProcess: HANDLE->void*
        ///uiFlags: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "GetGuiResources")]
        public static extern uint GetGuiResources([In] IntPtr hProcess, uint uiFlags);

        /// Return Type: UINT->unsigned int
        ///hDlg: HWND->HWND__*
        ///nIDDlgItem: int
        ///lpString: LPWSTR->WCHAR*
        ///cchMax: int
        [DllImport("user32.dll", EntryPoint = "GetDlgItemTextW")]
        public static extern uint GetDlgItemTextW([In] IntPtr hDlg, int nIDDlgItem, [Out] [MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpString, int cchMax);

        /// Return Type: UINT->unsigned int
        ///hDlg: HWND->HWND__*
        ///nIDDlgItem: int
        ///lpString: LPSTR->CHAR*
        ///cchMax: int
        [DllImport("user32.dll", EntryPoint = "GetDlgItemTextA")]
        public static extern uint GetDlgItemTextA([In] IntPtr hDlg, int nIDDlgItem, [Out] [MarshalAs(UnmanagedType.LPStr)] StringBuilder lpString, int cchMax);

        /// Return Type: BOOL->int
        ///hwndCombo: HWND->HWND__*
        ///pcbi: PCOMBOBOXINFO->tagCOMBOBOXINFO*
        [DllImport("user32.dll", EntryPoint = "GetComboBoxInfo")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetComboBoxInfo([In] IntPtr hwndCombo, ref COMBOBOXINFO pcbi);

        /// Return Type: BOOL->int
        ///hInstance: HINSTANCE->HINSTANCE__*
        ///lpszClass: LPCWSTR->WCHAR*
        ///lpwcx: LPWNDCLASSEXW->tagWNDCLASSEXW*
        [DllImport("user32.dll", EntryPoint = "GetClassInfoExW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetClassInfoExW(
            [In] IntPtr hInstance, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpszClass, [Out] out WNDCLASSEXW lpwcx);

        /// Return Type: BOOL->int
        ///hInstance: HINSTANCE->HINSTANCE__*
        ///lpszClass: LPCSTR->CHAR*
        ///lpwcx: LPWNDCLASSEXA->tagWNDCLASSEXA*
        [DllImport("user32.dll", EntryPoint = "GetClassInfoExA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetClassInfoExA([In] IntPtr hInstance, [In] [MarshalAs(UnmanagedType.LPStr)] string lpszClass, [Out] out WNDCLASSEXA lpwcx);

        /// Return Type: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "GetActiveWindow")]
        public static extern IntPtr GetActiveWindow();

        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///wSBflags: UINT->unsigned int
        ///wArrows: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "EnableScrollBar")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnableScrollBar([In] IntPtr hWnd, uint wSBflags, uint wArrows);

        /// Return Type: BOOL->int
        ///hwndDlg: HWND->HWND__*
        ///lpString: LPWSTR->WCHAR*
        ///chCount: int
        ///idListBox: int
        [DllImport("user32.dll", EntryPoint = "DlgDirSelectExW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DlgDirSelectExW(
            [In] IntPtr hwndDlg, [Out] [MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpString, int chCount, int idListBox);

        /// Return Type: BOOL->int
        ///hwndDlg: HWND->HWND__*
        ///lpString: LPSTR->CHAR*
        ///chCount: int
        ///idListBox: int
        [DllImport("user32.dll", EntryPoint = "DlgDirSelectExA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DlgDirSelectExA(
            [In] IntPtr hwndDlg, [Out] [MarshalAs(UnmanagedType.LPStr)] StringBuilder lpString, int chCount, int idListBox);

        /// Return Type: INT_PTR->int
        ///hInstance: HINSTANCE->HINSTANCE__*
        ///lpTemplateName: LPCWSTR->WCHAR*
        ///hWndParent: HWND->HWND__*
        ///lpDialogFunc: DLGPROC
        ///dwInitParam: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "DialogBoxParamW")]
        public static extern int DialogBoxParamW(
            [In] IntPtr hInstance, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpTemplateName, [In] IntPtr hWndParent, DLGPROC lpDialogFunc,
            [MarshalAs(UnmanagedType.SysInt)] int dwInitParam);

        /// Return Type: INT_PTR->int
        ///hInstance: HINSTANCE->HINSTANCE__*
        ///lpTemplateName: LPCSTR->CHAR*
        ///hWndParent: HWND->HWND__*
        ///lpDialogFunc: DLGPROC
        ///dwInitParam: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "DialogBoxParamA")]
        public static extern int DialogBoxParamA(
            [In] IntPtr hInstance, [In] [MarshalAs(UnmanagedType.LPStr)] string lpTemplateName, [In] IntPtr hWndParent, DLGPROC lpDialogFunc,
            [MarshalAs(UnmanagedType.SysInt)] int dwInitParam);

        /// Return Type: LRESULT->LONG_PTR->int
        ///paRawInput: PRAWINPUT*
        ///nInput: INT->int
        ///cbSizeHeader: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "DefRawInputProc")]
        [return: MarshalAs(UnmanagedType.SysInt)]
        public static extern int DefRawInputProc(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.SysInt, SizeParamIndex = 1)] IntPtr[] paRawInput, int nInput, uint cbSizeHeader);

        /// Return Type: BOOL->int
        ///idInst: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "DdeUninitialize")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DdeUninitialize(uint idInst);

        /// Return Type: BOOL->int
        ///hData: HDDEDATA->HDDEDATA__*
        [DllImport("user32.dll", EntryPoint = "DdeUnaccessData")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DdeUnaccessData(IntPtr hData);

        /// Return Type: DWORD->unsigned int
        ///idInst: DWORD->unsigned int
        ///hsz: HSZ->HSZ__*
        ///psz: LPWSTR->WCHAR*
        ///cchMax: DWORD->unsigned int
        ///iCodePage: int
        [DllImport("user32.dll", EntryPoint = "DdeQueryStringW")]
        public static extern uint DdeQueryStringW(uint idInst, IntPtr hsz, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder psz, uint cchMax, int iCodePage);

        /// Return Type: DWORD->unsigned int
        ///idInst: DWORD->unsigned int
        ///hsz: HSZ->HSZ__*
        ///psz: LPSTR->CHAR*
        ///cchMax: DWORD->unsigned int
        ///iCodePage: int
        [DllImport("user32.dll", EntryPoint = "DdeQueryStringA")]
        public static extern uint DdeQueryStringA(uint idInst, IntPtr hsz, [MarshalAs(UnmanagedType.LPStr)] StringBuilder psz, uint cchMax, int iCodePage);

        /// Return Type: UINT->unsigned int
        ///idInst: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "DdeGetLastError")]
        public static extern uint DdeGetLastError(uint idInst);

        /// Return Type: HWND->HWND__*
        ///dwExStyle: DWORD->unsigned int
        ///lpClassName: LPCWSTR->WCHAR*
        ///lpWindowName: LPCWSTR->WCHAR*
        ///dwStyle: DWORD->unsigned int
        ///X: int
        ///Y: int
        ///nWidth: int
        ///nHeight: int
        ///hWndParent: HWND->HWND__*
        ///hMenu: HMENU->HMENU__*
        ///hInstance: HINSTANCE->HINSTANCE__*
        ///lpParam: LPVOID->void*
        [DllImport("user32.dll", EntryPoint = "CreateWindowExW")]
        public static extern IntPtr CreateWindowExW(
            uint dwExStyle, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpClassName, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpWindowName, uint dwStyle,
            int X, int Y, int nWidth, int nHeight, [In] IntPtr hWndParent, [In] IntPtr hMenu, [In] IntPtr hInstance, [In] IntPtr lpParam);

        /// Return Type: HWND->HWND__*
        ///dwExStyle: DWORD->unsigned int
        ///lpClassName: LPCSTR->CHAR*
        ///lpWindowName: LPCSTR->CHAR*
        ///dwStyle: DWORD->unsigned int
        ///X: int
        ///Y: int
        ///nWidth: int
        ///nHeight: int
        ///hWndParent: HWND->HWND__*
        ///hMenu: HMENU->HMENU__*
        ///hInstance: HINSTANCE->HINSTANCE__*
        ///lpParam: LPVOID->void*
        [DllImport("user32.dll", EntryPoint = "CreateWindowExA")]
        public static extern IntPtr CreateWindowExA(
            uint dwExStyle, [In] [MarshalAs(UnmanagedType.LPStr)] string lpClassName, [In] [MarshalAs(UnmanagedType.LPStr)] string lpWindowName, uint dwStyle,
            int X, int Y, int nWidth, int nHeight, [In] IntPtr hWndParent, [In] IntPtr hMenu, [In] IntPtr hInstance, [In] IntPtr lpParam);

        /// Return Type: HMENU->HMENU__*
        [DllImport("user32.dll", EntryPoint = "CreatePopupMenu")]
        public static extern IntPtr CreatePopupMenu();

        /// Return Type: LRESULT->LONG_PTR->int
        ///lpPrevWndFunc: WNDPROC
        ///hWnd: HWND->HWND__*
        ///Msg: UINT->unsigned int
        ///wParam: WPARAM->UINT_PTR->unsigned int
        ///lParam: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "CallWindowProcW")]
        [return: MarshalAs(UnmanagedType.SysInt)]
        public static extern int CallWindowProcW(
            WNDPROC lpPrevWndFunc, [In] IntPtr hWnd, uint Msg, [MarshalAs(UnmanagedType.SysUInt)] uint wParam, [MarshalAs(UnmanagedType.SysInt)] int lParam);

        /// Return Type: LRESULT->LONG_PTR->int
        ///lpPrevWndFunc: WNDPROC
        ///hWnd: HWND->HWND__*
        ///Msg: UINT->unsigned int
        ///wParam: WPARAM->UINT_PTR->unsigned int
        ///lParam: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "CallWindowProcA")]
        [return: MarshalAs(UnmanagedType.SysInt)]
        public static extern int CallWindowProcA(
            WNDPROC lpPrevWndFunc, [In] IntPtr hWnd, uint Msg, [MarshalAs(UnmanagedType.SysUInt)] uint wParam, [MarshalAs(UnmanagedType.SysInt)] int lParam);

        /// Return Type: BOOL->int
        ///hWinEventHook: HWINEVENTHOOK->HWINEVENTHOOK__*
        [DllImport("user32.dll", EntryPoint = "UnhookWinEvent")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool UnhookWinEvent([In] IntPtr hWinEventHook);

        /// Return Type: BOOL->int
        ///hMenu: HMENU->HMENU__*
        ///uFlags: UINT->unsigned int
        ///x: int
        ///y: int
        ///nReserved: int
        ///hWnd: HWND->HWND__*
        ///prcRect: RECT*
        [DllImport("user32.dll", EntryPoint = "TrackPopupMenu")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool TrackPopupMenu([In] IntPtr hMenu, uint uFlags, int x, int y, int nReserved, [In] IntPtr hWnd, [In] IntPtr prcRect);

        /// Return Type: LONG->int
        ///hdc: HDC->HDC__*
        ///x: int
        ///y: int
        ///lpString: LPCWSTR->WCHAR*
        ///chCount: int
        ///nTabPositions: int
        ///lpnTabStopPositions: INT*
        ///nTabOrigin: int
        [DllImport("user32.dll", EntryPoint = "TabbedTextOutW")]
        public static extern int TabbedTextOutW(
            [In] IntPtr hdc, int x, int y, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpString, int chCount, int nTabPositions,
            [In] IntPtr lpnTabStopPositions, int nTabOrigin);

        /// Return Type: LONG->int
        ///hdc: HDC->HDC__*
        ///x: int
        ///y: int
        ///lpString: LPCSTR->CHAR*
        ///chCount: int
        ///nTabPositions: int
        ///lpnTabStopPositions: INT*
        ///nTabOrigin: int
        [DllImport("user32.dll", EntryPoint = "TabbedTextOutA")]
        public static extern int TabbedTextOutA(
            [In] IntPtr hdc, int x, int y, [In] [MarshalAs(UnmanagedType.LPStr)] string lpString, int chCount, int nTabPositions,
            [In] IntPtr lpnTabStopPositions, int nTabOrigin);

        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///lpString: LPCWSTR->WCHAR*
        [DllImport("user32.dll", EntryPoint = "SetWindowTextW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowTextW([In] IntPtr hWnd, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpString);

        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///lpString: LPCSTR->CHAR*
        [DllImport("user32.dll", EntryPoint = "SetWindowTextA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowTextA([In] IntPtr hWnd, [In] [MarshalAs(UnmanagedType.LPStr)] string lpString);

        /// Return Type: LONG->int
        ///hWnd: HWND->HWND__*
        ///nIndex: int
        ///dwNewLong: LONG->int
        [DllImport("user32.dll", EntryPoint = "SetWindowLongW")]
        public static extern int SetWindowLongW([In] IntPtr hWnd, int nIndex, int dwNewLong);

        /// Return Type: LONG->int
        ///hWnd: HWND->HWND__*
        ///nIndex: int
        ///dwNewLong: LONG->int
        [DllImport("user32.dll", EntryPoint = "SetWindowLongA")]
        public static extern int SetWindowLongA([In] IntPtr hWnd, int nIndex, int dwNewLong);

        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///nBar: int
        ///nMinPos: int
        ///nMaxPos: int
        ///bRedraw: BOOL->int
        [DllImport("user32.dll", EntryPoint = "SetScrollRange")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetScrollRange([In] IntPtr hWnd, int nBar, int nMinPos, int nMaxPos, [MarshalAs(UnmanagedType.Bool)] bool bRedraw);

        /// Return Type: void
        ///dwErrCode: DWORD->unsigned int
        ///dwType: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "SetLastErrorEx")]
        public static extern void SetLastErrorEx(uint dwErrCode, uint dwType);

        /// Return Type: int
        ///hWnd: HWND->HWND__*
        ///dx: int
        ///dy: int
        ///prcScroll: RECT*
        ///prcClip: RECT*
        ///hrgnUpdate: HRGN->HRGN__*
        ///prcUpdate: LPRECT->tagRECT*
        ///flags: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "ScrollWindowEx")]
        public static extern int ScrollWindowEx(
            [In] IntPtr hWnd, int dx, int dy, [In] IntPtr prcScroll, [In] IntPtr prcClip, [In] IntPtr hrgnUpdate, IntPtr prcUpdate, uint flags);

        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///lpPoint: LPPOINT->tagPOINT*
        [DllImport("user32.dll", EntryPoint = "ScreenToClient")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ScreenToClient([In] IntPtr hWnd, ref Point lpPoint);

        /// Return Type: LPARAM->LONG_PTR->int
        ///lParam: LPARAM->LONG_PTR->int
        ///msgIn: UINT->unsigned int
        ///msgOut: UINT->unsigned int
        ///uiLo: UINT_PTR->unsigned int
        ///uiHi: UINT_PTR->unsigned int
        [DllImport("user32.dll", EntryPoint = "ReuseDDElParam")]
        [return: MarshalAs(UnmanagedType.SysInt)]
        public static extern int ReuseDDElParam(
            [MarshalAs(UnmanagedType.SysInt)] int lParam, uint msgIn, uint msgOut, [MarshalAs(UnmanagedType.SysUInt)] uint uiLo,
            [MarshalAs(UnmanagedType.SysUInt)] uint uiHi);

        /// Return Type: BOOL->int
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ReleaseCapture();

        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///id: int
        ///fsModifiers: UINT->unsigned int
        ///vk: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "RegisterHotKey")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool RegisterHotKey([In] IntPtr hWnd, int id, uint fsModifiers, uint vk);

        /// Return Type: ATOM->WORD->unsigned short
        ///lpWndClass: WNDCLASSW*
        [DllImport("user32.dll", EntryPoint = "RegisterClassW")]
        public static extern ushort RegisterClassW([In] ref WNDCLASSW lpWndClass);

        /// Return Type: ATOM->WORD->unsigned short
        ///lpWndClass: WNDCLASSA*
        [DllImport("user32.dll", EntryPoint = "RegisterClassA")]
        public static extern ushort RegisterClassA([In] ref WNDCLASSA lpWndClass);

        /// Return Type: BOOL->int
        ///lpszSrc: LPCSTR->CHAR*
        ///lpszDst: LPWSTR->WCHAR*
        ///cchDstLength: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "OemToCharBuffW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool OemToCharBuffW(
            [In] [MarshalAs(UnmanagedType.LPStr)] string lpszSrc, [Out] [MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpszDst, uint cchDstLength);

        /// Return Type: BOOL->int
        ///lpszSrc: LPCSTR->CHAR*
        ///lpszDst: LPSTR->CHAR*
        ///cchDstLength: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "OemToCharBuffA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool OemToCharBuffA(
            [In] [MarshalAs(UnmanagedType.LPStr)] string lpszSrc, [Out] [MarshalAs(UnmanagedType.LPStr)] StringBuilder lpszDst, uint cchDstLength);

        /// Return Type: void
        ///event: DWORD->unsigned int
        ///hwnd: HWND->HWND__*
        ///idObject: LONG->int
        ///idChild: LONG->int
        [DllImport("user32.dll", EntryPoint = "NotifyWinEvent")]
        public static extern void NotifyWinEvent(uint @event, [In] IntPtr hwnd, int idObject, int idChild);

        /// Return Type: UINT->unsigned int
        ///uCode: UINT->unsigned int
        ///uMapType: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "MapVirtualKeyW")]
        public static extern uint MapVirtualKeyW(uint uCode, uint uMapType);

        /// Return Type: UINT->unsigned int
        ///uCode: UINT->unsigned int
        ///uMapType: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "MapVirtualKeyA")]
        public static extern uint MapVirtualKeyA(uint uCode, uint uMapType);

        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///lpRect: RECT*
        ///bErase: BOOL->int
        [DllImport("user32.dll", EntryPoint = "InvalidateRect")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool InvalidateRect([In] IntPtr hWnd, [In] IntPtr lpRect, [MarshalAs(UnmanagedType.Bool)] bool bErase);

        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///hMenu: HMENU->HMENU__*
        ///uIDHiliteItem: UINT->unsigned int
        ///uHilite: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "HiliteMenuItem")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool HiliteMenuItem([In] IntPtr hWnd, [In] IntPtr hMenu, uint uIDHiliteItem, uint uHilite);

        /// Return Type: int
        ///hWnd: HWND->HWND__*
        ///lpString: LPWSTR->WCHAR*
        ///nMaxCount: int
        [DllImport("user32.dll", EntryPoint = "GetWindowTextW")]
        public static extern int GetWindowTextW([In] IntPtr hWnd, [Out] [MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpString, int nMaxCount);

        /// Return Type: int
        ///hWnd: HWND->HWND__*
        ///lpString: LPSTR->CHAR*
        ///nMaxCount: int
        [DllImport("user32.dll", EntryPoint = "GetWindowTextA")]
        public static extern int GetWindowTextA([In] IntPtr hWnd, [Out] [MarshalAs(UnmanagedType.LPStr)] StringBuilder lpString, int nMaxCount);

        /// Return Type: LONG->int
        ///hWnd: HWND->HWND__*
        ///nIndex: int
        [DllImport("user32.dll", EntryPoint = "GetWindowLongW")]
        public static extern int GetWindowLongW([In] IntPtr hWnd, int nIndex);

        /// Return Type: LONG->int
        ///hWnd: HWND->HWND__*
        ///nIndex: int
        [DllImport("user32.dll", EntryPoint = "GetWindowLongA")]
        public static extern int GetWindowLongA([In] IntPtr hWnd, int nIndex);

        /// Return Type: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "GetShellWindow")]
        public static extern IntPtr GetShellWindow();

        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///nBar: int
        ///lpMinPos: LPINT->int*
        ///lpMaxPos: LPINT->int*
        [DllImport("user32.dll", EntryPoint = "GetScrollRange")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetScrollRange([In] IntPtr hWnd, int nBar, [Out] out int lpMinPos, [Out] out int lpMaxPos);

        /// Return Type: DWORD->unsigned int
        ///flags: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "GetQueueStatus")]
        public static extern uint GetQueueStatus(uint flags);

        /// Return Type: LONG->int
        [DllImport("user32.dll", EntryPoint = "GetMessageTime")]
        public static extern int GetMessageTime();

        /// Return Type: int
        ///hMenu: HMENU->HMENU__*
        ///uIDItem: UINT->unsigned int
        ///lpString: LPWSTR->WCHAR*
        ///cchMax: int
        ///flags: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "GetMenuStringW")]
        public static extern int GetMenuStringW(
            [In] IntPtr hMenu, uint uIDItem, [Out] [MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpString, int cchMax, uint flags);

        /// Return Type: int
        ///hMenu: HMENU->HMENU__*
        ///uIDItem: UINT->unsigned int
        ///lpString: LPSTR->CHAR*
        ///cchMax: int
        ///flags: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "GetMenuStringA")]
        public static extern int GetMenuStringA(
            [In] IntPtr hMenu, uint uIDItem, [Out] [MarshalAs(UnmanagedType.LPStr)] StringBuilder lpString, int cchMax, uint flags);

        /// Return Type: BOOL->int
        ///hwnd: HWND->HWND__*
        ///idObject: LONG->int
        ///idItem: LONG->int
        ///pmbi: PMENUBARINFO->tagMENUBARINFO*
        [DllImport("user32.dll", EntryPoint = "GetMenuBarInfo")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetMenuBarInfo([In] IntPtr hwnd, int idObject, int idItem, ref MENUBARINFO pmbi);

        /// Return Type: DWORD->unsigned int
        ///hwnd: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "GetListBoxInfo")]
        public static extern uint GetListBoxInfo([In] IntPtr hwnd);

        /// Return Type: BOOL->int
        ///hwnd: HWND->HWND__*
        ///iItem: int
        ///pati: PALTTABINFO->tagALTTABINFO*
        ///pszItemText: LPWSTR->WCHAR*
        ///cchItemText: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "GetAltTabInfoW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetAltTabInfoW(
            [In] IntPtr hwnd, int iItem, ref ALTTABINFO pati, [Out] [MarshalAs(UnmanagedType.LPWStr)] StringBuilder pszItemText, uint cchItemText);

        /// Return Type: BOOL->int
        ///hwnd: HWND->HWND__*
        ///iItem: int
        ///pati: PALTTABINFO->tagALTTABINFO*
        ///pszItemText: LPSTR->CHAR*
        ///cchItemText: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "GetAltTabInfoA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetAltTabInfoA(
            [In] IntPtr hwnd, int iItem, ref ALTTABINFO pati, [Out] [MarshalAs(UnmanagedType.LPStr)] StringBuilder pszItemText, uint cchItemText);

        /// Return Type: BOOL->int
        ///hMenu: HMENU->HMENU__*
        ///uIDEnableItem: UINT->unsigned int
        ///uEnable: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "EnableMenuItem")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnableMenuItem([In] IntPtr hMenu, uint uIDEnableItem, uint uEnable);

        /// Return Type: BOOL->int
        [DllImport("user32.dll", EntryPoint = "EmptyClipboard")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EmptyClipboard();

        /// Return Type: LRESULT->LONG_PTR->int
        ///hWnd: HWND->HWND__*
        ///Msg: UINT->unsigned int
        ///wParam: WPARAM->UINT_PTR->unsigned int
        ///lParam: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "DefWindowProcW")]
        [return: MarshalAs(UnmanagedType.SysInt)]
        public static extern int DefWindowProcW(
            [In] IntPtr hWnd, uint Msg, [MarshalAs(UnmanagedType.SysUInt)] uint wParam, [MarshalAs(UnmanagedType.SysInt)] int lParam);

        /// Return Type: LRESULT->LONG_PTR->int
        ///hWnd: HWND->HWND__*
        ///Msg: UINT->unsigned int
        ///wParam: WPARAM->UINT_PTR->unsigned int
        ///lParam: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "DefWindowProcA")]
        [return: MarshalAs(UnmanagedType.SysInt)]
        public static extern int DefWindowProcA(
            [In] IntPtr hWnd, uint Msg, [MarshalAs(UnmanagedType.SysUInt)] uint wParam, [MarshalAs(UnmanagedType.SysInt)] int lParam);

        /// Return Type: HDWP->HANDLE->void*
        ///hWinPosInfo: HDWP->HANDLE->void*
        ///hWnd: HWND->HWND__*
        ///hWndInsertAfter: HWND->HWND__*
        ///x: int
        ///y: int
        ///cx: int
        ///cy: int
        ///uFlags: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "DeferWindowPos")]
        public static extern IntPtr DeferWindowPos(
            [In] IntPtr hWinPosInfo, [In] IntPtr hWnd, [In] IntPtr hWndInsertAfter, int x, int y, int cx, int cy, uint uFlags);

        /// Return Type: HDDEDATA->HDDEDATA__*
        ///idInst: DWORD->unsigned int
        ///hsz1: HSZ->HSZ__*
        ///hsz2: HSZ->HSZ__*
        ///afCmd: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "DdeNameService")]
        public static extern IntPtr DdeNameService(uint idInst, IntPtr hsz1, IntPtr hsz2, uint afCmd);

        /// Return Type: UINT->unsigned int
        ///pidInst: LPDWORD->DWORD*
        ///pfnCallback: PFNCALLBACK
        ///afCmd: DWORD->unsigned int
        ///ulRes: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "DdeInitializeW")]
        public static extern uint DdeInitializeW(ref uint pidInst, PFNCALLBACK pfnCallback, uint afCmd, uint ulRes);

        /// Return Type: UINT->unsigned int
        ///pidInst: LPDWORD->DWORD*
        ///pfnCallback: PFNCALLBACK
        ///afCmd: DWORD->unsigned int
        ///ulRes: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "DdeInitializeA")]
        public static extern uint DdeInitializeA(ref uint pidInst, PFNCALLBACK pfnCallback, uint afCmd, uint ulRes);

        /// Return Type: HCONVLIST->HCONVLIST__*
        ///idInst: DWORD->unsigned int
        ///hszService: HSZ->HSZ__*
        ///hszTopic: HSZ->HSZ__*
        ///hConvList: HCONVLIST->HCONVLIST__*
        ///pCC: PCONVCONTEXT->CONVCONTEXT*
        [DllImport("user32.dll", EntryPoint = "DdeConnectList")]
        public static extern IntPtr DdeConnectList(uint idInst, IntPtr hszService, IntPtr hszTopic, IntPtr hConvList, ref CONVCONTEXT pCC);

        /// Return Type: HDESK->HDESK__*
        ///lpszDesktop: LPCWSTR->WCHAR*
        ///lpszDevice: LPCWSTR->WCHAR*
        ///pDevmode: LPDEVMODEW->_devicemodeW*
        ///dwFlags: DWORD->unsigned int
        ///dwDesiredAccess: ACCESS_MASK->DWORD->unsigned int
        ///lpsa: LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        [DllImport("user32.dll", EntryPoint = "CreateDesktopW")]
        public static extern IntPtr CreateDesktopW(
            [In] [MarshalAs(UnmanagedType.LPWStr)] string lpszDesktop, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpszDevice, IntPtr pDevmode, uint dwFlags,
            uint dwDesiredAccess, [In] IntPtr lpsa);

        /// Return Type: HDESK->HDESK__*
        ///lpszDesktop: LPCSTR->CHAR*
        ///lpszDevice: LPCSTR->CHAR*
        ///pDevmode: LPDEVMODEA->_devicemodeA*
        ///dwFlags: DWORD->unsigned int
        ///dwDesiredAccess: ACCESS_MASK->DWORD->unsigned int
        ///lpsa: LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        [DllImport("user32.dll", EntryPoint = "CreateDesktopA")]
        public static extern IntPtr CreateDesktopA(
            [In] [MarshalAs(UnmanagedType.LPStr)] string lpszDesktop, [In] [MarshalAs(UnmanagedType.LPStr)] string lpszDevice, IntPtr pDevmode, uint dwFlags,
            uint dwDesiredAccess, [In] IntPtr lpsa);

        /// Return Type: BOOL->int
        [DllImport("user32.dll", EntryPoint = "CloseClipboard")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CloseClipboard();

        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///lpPoint: LPPOINT->tagPOINT*
        [DllImport("user32.dll", EntryPoint = "ClientToScreen")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ClientToScreen([In] IntPtr hWnd, ref Point lpPoint);

        /// Return Type: BOOL->int
        ///hDlg: HWND->HWND__*
        ///nIDButton: int
        ///uCheck: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "CheckDlgButton")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CheckDlgButton([In] IntPtr hDlg, int nIDButton, uint uCheck);

        /// Return Type: DWORD->unsigned int
        ///lpsz: LPWSTR->WCHAR*
        ///cchLength: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "CharUpperBuffW")]
        public static extern uint CharUpperBuffW([MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpsz, uint cchLength);

        /// Return Type: DWORD->unsigned int
        ///lpsz: LPSTR->CHAR*
        ///cchLength: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "CharUpperBuffA")]
        public static extern uint CharUpperBuffA([MarshalAs(UnmanagedType.LPStr)] StringBuilder lpsz, uint cchLength);

        /// Return Type: BOOL->int
        ///lpszSrc: LPCWSTR->WCHAR*
        ///lpszDst: LPSTR->CHAR*
        ///cchDstLength: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "CharToOemBuffW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CharToOemBuffW(
            [In] [MarshalAs(UnmanagedType.LPWStr)] string lpszSrc, [Out] [MarshalAs(UnmanagedType.LPStr)] StringBuilder lpszDst, uint cchDstLength);

        /// Return Type: BOOL->int
        ///lpszSrc: LPCSTR->CHAR*
        ///lpszDst: LPSTR->CHAR*
        ///cchDstLength: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "CharToOemBuffA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CharToOemBuffA(
            [In] [MarshalAs(UnmanagedType.LPStr)] string lpszSrc, [Out] [MarshalAs(UnmanagedType.LPStr)] StringBuilder lpszDst, uint cchDstLength);

        /// Return Type: DWORD->unsigned int
        ///lpsz: LPWSTR->WCHAR*
        ///cchLength: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "CharLowerBuffW")]
        public static extern uint CharLowerBuffW([MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpsz, uint cchLength);

        /// Return Type: DWORD->unsigned int
        ///lpsz: LPSTR->CHAR*
        ///cchLength: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "CharLowerBuffA")]
        public static extern uint CharLowerBuffA([MarshalAs(UnmanagedType.LPStr)] StringBuilder lpsz, uint cchLength);

        /// Return Type: WORD->unsigned short
        ///hwndParent: HWND->HWND__*
        ///wHow: UINT->unsigned int
        ///lpRect: RECT*
        ///cKids: UINT->unsigned int
        ///lpKids: HWND*
        [DllImport("user32.dll", EntryPoint = "CascadeWindows")]
        public static extern ushort CascadeWindows([In] IntPtr hwndParent, uint wHow, [In] IntPtr lpRect, uint cKids, ref IntPtr lpKids);

        /// Return Type: LRESULT->LONG_PTR->int
        ///hhk: HHOOK->HHOOK__*
        ///nCode: int
        ///wParam: WPARAM->UINT_PTR->unsigned int
        ///lParam: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "CallNextHookEx")]
        [return: MarshalAs(UnmanagedType.SysInt)]
        public static extern int CallNextHookEx(
            [In] IntPtr hhk, int nCode, [MarshalAs(UnmanagedType.SysUInt)] uint wParam, [MarshalAs(UnmanagedType.SysInt)] int lParam);

        /// Return Type: BOOL->int
        ///lpMsg: LPMSG->tagMSG*
        ///nCode: int
        [DllImport("user32.dll", EntryPoint = "CallMsgFilterW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CallMsgFilterW([In] ref MSG lpMsg, int nCode);

        /// Return Type: BOOL->int
        ///lpMsg: LPMSG->tagMSG*
        ///nCode: int
        [DllImport("user32.dll", EntryPoint = "CallMsgFilterA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CallMsgFilterA([In] ref MSG lpMsg, int nCode);

        /// Return Type: BOOL->int
        ///hDesktop: HDESK->HDESK__*
        [DllImport("user32.dll", EntryPoint = "SwitchDesktop")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SwitchDesktop([In] IntPtr hDesktop);

        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///wBar: int
        ///bShow: BOOL->int
        [DllImport("user32.dll", EntryPoint = "ShowScrollBar")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ShowScrollBar([In] IntPtr hWnd, int wBar, [MarshalAs(UnmanagedType.Bool)] bool bShow);

        /// Return Type: WORD->unsigned short
        ///hWnd: HWND->HWND__*
        ///nIndex: int
        ///wNewWord: WORD->unsigned short
        [DllImport("user32.dll", EntryPoint = "SetWindowWord")]
        public static extern ushort SetWindowWord([In] IntPtr hWnd, int nIndex, ushort wNewWord);

        /// Return Type: int
        ///hwnd: HWND->HWND__*
        ///nBar: int
        ///lpsi: LPCSCROLLINFO->SCROLLINFO*
        ///redraw: BOOL->int
        [DllImport("user32.dll", EntryPoint = "SetScrollInfo")]
        public static extern int SetScrollInfo([In] IntPtr hwnd, int nBar, [In] ref SCROLLINFO lpsi, [MarshalAs(UnmanagedType.Bool)] bool redraw);

        /// Return Type: BOOL->int
        ///hDlg: HWND->HWND__*
        ///nIDDlgItem: int
        ///uValue: UINT->unsigned int
        ///bSigned: BOOL->int
        [DllImport("user32.dll", EntryPoint = "SetDlgItemInt")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetDlgItemInt([In] IntPtr hDlg, int nIDDlgItem, uint uValue, [MarshalAs(UnmanagedType.Bool)] bool bSigned);

        /// Return Type: DWORD->unsigned int
        ///hWnd: HWND->HWND__*
        ///nIndex: int
        ///dwNewLong: LONG->int
        [DllImport("user32.dll", EntryPoint = "SetClassLongW")]
        public static extern uint SetClassLongW([In] IntPtr hWnd, int nIndex, int dwNewLong);

        /// Return Type: DWORD->unsigned int
        ///hWnd: HWND->HWND__*
        ///nIndex: int
        ///dwNewLong: LONG->int
        [DllImport("user32.dll", EntryPoint = "SetClassLongA")]
        public static extern uint SetClassLongA([In] IntPtr hWnd, int nIndex, int dwNewLong);

        /// Return Type: LPARAM->LONG_PTR->int
        ///msg: UINT->unsigned int
        ///uiLo: UINT_PTR->unsigned int
        ///uiHi: UINT_PTR->unsigned int
        [DllImport("user32.dll", EntryPoint = "PackDDElParam")]
        [return: MarshalAs(UnmanagedType.SysInt)]
        public static extern int PackDDElParam(uint msg, [MarshalAs(UnmanagedType.SysUInt)] uint uiLo, [MarshalAs(UnmanagedType.SysUInt)] uint uiHi);

        /// Return Type: BOOL->int
        ///hWndNewOwner: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "OpenClipboard")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool OpenClipboard([In] IntPtr hWndNewOwner);

        /// Return Type: int
        ///hWnd: HWND->HWND__*
        ///lpText: LPCWSTR->WCHAR*
        ///lpCaption: LPCWSTR->WCHAR*
        ///uType: UINT->unsigned int
        ///wLanguageId: WORD->unsigned short
        [DllImport("user32.dll", EntryPoint = "MessageBoxExW")]
        public static extern int MessageBoxExW(
            [In] IntPtr hWnd, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpText, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpCaption, uint uType,
            ushort wLanguageId);

        /// Return Type: int
        ///hWnd: HWND->HWND__*
        ///lpText: LPCSTR->CHAR*
        ///lpCaption: LPCSTR->CHAR*
        ///uType: UINT->unsigned int
        ///wLanguageId: WORD->unsigned short
        [DllImport("user32.dll", EntryPoint = "MessageBoxExA")]
        public static extern int MessageBoxExA(
            [In] IntPtr hWnd, [In] [MarshalAs(UnmanagedType.LPStr)] string lpText, [In] [MarshalAs(UnmanagedType.LPStr)] string lpCaption, uint uType,
            ushort wLanguageId);

        /// Return Type: BOOL->int
        ///hDlg: HWND->HWND__*
        ///lpRect: LPRECT->tagRECT*
        [DllImport("user32.dll", EntryPoint = "MapDialogRect")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool MapDialogRect([In] IntPtr hDlg, ref RECT lpRect);

        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///hRgn: HRGN->HRGN__*
        ///bErase: BOOL->int
        [DllImport("user32.dll", EntryPoint = "InvalidateRgn")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool InvalidateRgn([In] IntPtr hWnd, [In] IntPtr hRgn, [MarshalAs(UnmanagedType.Bool)] bool bErase);

        /// Return Type: BOOL->int
        ///lprcDst: LPRECT->tagRECT*
        ///lprcSrc1: RECT*
        ///lprcSrc2: RECT*
        [DllImport("user32.dll", EntryPoint = "IntersectRect")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IntersectRect([Out] out RECT lprcDst, [In] ref RECT lprcSrc1, [In] ref RECT lprcSrc2);

        /// Return Type: BOOL->int
        [DllImport("user32.dll", EntryPoint = "InSendMessage")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool InSendMessage();

        /// Return Type: WORD->unsigned short
        ///hWnd: HWND->HWND__*
        ///nIndex: int
        [DllImport("user32.dll", EntryPoint = "GetWindowWord")]
        public static extern ushort GetWindowWord([In] IntPtr hWnd, int nIndex);

        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///lpRect: LPRECT->tagRECT*
        [DllImport("user32.dll", EntryPoint = "GetWindowRect")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetWindowRect([In] IntPtr hWnd, [Out] out RECT lpRect);

        /// Return Type: BOOL->int
        ///hwnd: HWND->HWND__*
        ///pwi: PWINDOWINFO->tagWINDOWINFO*
        [DllImport("user32.dll", EntryPoint = "GetWindowInfo")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetWindowInfo([In] IntPtr hwnd, ref WINDOWINFO pwi);

        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///lpRect: LPRECT->tagRECT*
        ///bErase: BOOL->int
        [DllImport("user32.dll", EntryPoint = "GetUpdateRect")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetUpdateRect([In] IntPtr hWnd, IntPtr lpRect, [MarshalAs(UnmanagedType.Bool)] bool bErase);

        /// Return Type: HMENU->HMENU__*
        ///hWnd: HWND->HWND__*
        ///bRevert: BOOL->int
        [DllImport("user32.dll", EntryPoint = "GetSystemMenu")]
        public static extern IntPtr GetSystemMenu([In] IntPtr hWnd, [MarshalAs(UnmanagedType.Bool)] bool bRevert);

        /// Return Type: BOOL->int
        ///hwnd: HWND->HWND__*
        ///nBar: int
        ///lpsi: LPSCROLLINFO->tagSCROLLINFO*
        [DllImport("user32.dll", EntryPoint = "GetScrollInfo")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetScrollInfo([In] IntPtr hwnd, int nBar, ref SCROLLINFO lpsi);

        /// Return Type: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "GetMessagePos")]
        public static extern uint GetMessagePos();

        /// Return Type: UINT->unsigned int
        ///hMenu: HMENU->HMENU__*
        ///nPos: int
        [DllImport("user32.dll", EntryPoint = "GetMenuItemID")]
        public static extern uint GetMenuItemID([In] IntPtr hMenu, int nPos);

        /// Return Type: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "GetKBCodePage")]
        public static extern uint GetKBCodePage();

        /// Return Type: BOOL->int
        [DllImport("user32.dll", EntryPoint = "GetInputState")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetInputState();

        /// Return Type: UINT->unsigned int
        ///hDlg: HWND->HWND__*
        ///nIDDlgItem: int
        ///lpTranslated: BOOL*
        ///bSigned: BOOL->int
        [DllImport("user32.dll", EntryPoint = "GetDlgItemInt")]
        public static extern uint GetDlgItemInt([In] IntPtr hDlg, int nIDDlgItem, IntPtr lpTranslated, [MarshalAs(UnmanagedType.Bool)] bool bSigned);

        /// Return Type: BOOL->int
        ///pci: PCURSORINFO->tagCURSORINFO*
        [DllImport("user32.dll", EntryPoint = "GetCursorInfo")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetCursorInfo(ref CURSORINFO pci);

        /// Return Type: BOOL->int
        ///lpRect: LPRECT->tagRECT*
        [DllImport("user32.dll", EntryPoint = "GetClipCursor")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetClipCursor([Out] out RECT lpRect);

        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///lpRect: LPRECT->tagRECT*
        [DllImport("user32.dll", EntryPoint = "GetClientRect")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetClientRect([In] IntPtr hWnd, [Out] out RECT lpRect);

        /// Return Type: int
        ///hWnd: HWND->HWND__*
        ///lpClassName: LPWSTR->WCHAR*
        ///nMaxCount: int
        [DllImport("user32.dll", EntryPoint = "GetClassNameW")]
        public static extern int GetClassNameW([In] IntPtr hWnd, [Out] [MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpClassName, int nMaxCount);

        /// Return Type: int
        ///hWnd: HWND->HWND__*
        ///lpClassName: LPSTR->CHAR*
        ///nMaxCount: int
        [DllImport("user32.dll", EntryPoint = "GetClassNameA")]
        public static extern int GetClassNameA([In] IntPtr hWnd, [Out] [MarshalAs(UnmanagedType.LPStr)] StringBuilder lpClassName, int nMaxCount);

        /// Return Type: DWORD->unsigned int
        ///hWnd: HWND->HWND__*
        ///nIndex: int
        [DllImport("user32.dll", EntryPoint = "GetClassLongW")]
        public static extern uint GetClassLongW([In] IntPtr hWnd, int nIndex);

        /// Return Type: DWORD->unsigned int
        ///hWnd: HWND->HWND__*
        ///nIndex: int
        [DllImport("user32.dll", EntryPoint = "GetClassLongA")]
        public static extern uint GetClassLongA([In] IntPtr hWnd, int nIndex);

        /// Return Type: BOOL->int
        ///hInstance: HINSTANCE->HINSTANCE__*
        ///lpClassName: LPCWSTR->WCHAR*
        ///lpWndClass: LPWNDCLASSW->tagWNDCLASSW*
        [DllImport("user32.dll", EntryPoint = "GetClassInfoW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetClassInfoW(
            [In] IntPtr hInstance, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpClassName, [Out] out WNDCLASSW lpWndClass);

        /// Return Type: BOOL->int
        ///hInstance: HINSTANCE->HINSTANCE__*
        ///lpClassName: LPCSTR->CHAR*
        ///lpWndClass: LPWNDCLASSA->tagWNDCLASSA*
        [DllImport("user32.dll", EntryPoint = "GetClassInfoA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetClassInfoA(
            [In] IntPtr hInstance, [In] [MarshalAs(UnmanagedType.LPStr)] string lpClassName, [Out] out WNDCLASSA lpWndClass);

        /// Return Type: BOOL->int
        ///msg: UINT->unsigned int
        ///lParam: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "FreeDDElParam")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FreeDDElParam(uint msg, [MarshalAs(UnmanagedType.SysInt)] int lParam);

        /// Return Type: BOOL->int
        ///pfwi: PFLASHWINFO->Anonymous_d4dee27f_56a5_4822_8f80_a508c7dc0851*
        [DllImport("user32.dll", EntryPoint = "FlashWindowEx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FlashWindowEx([In] ref FLASHWINFO pfwi);

        /// Return Type: HWND->HWND__*
        ///hWndParent: HWND->HWND__*
        ///hWndChildAfter: HWND->HWND__*
        ///lpszClass: LPCWSTR->WCHAR*
        ///lpszWindow: LPCWSTR->WCHAR*
        [DllImport("user32.dll", EntryPoint = "FindWindowExW")]
        public static extern IntPtr FindWindowExW(
            [In] IntPtr hWndParent, [In] IntPtr hWndChildAfter, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpszClass,
            [In] [MarshalAs(UnmanagedType.LPWStr)] string lpszWindow);

        /// Return Type: HWND->HWND__*
        ///hWndParent: HWND->HWND__*
        ///hWndChildAfter: HWND->HWND__*
        ///lpszClass: LPCSTR->CHAR*
        ///lpszWindow: LPCSTR->CHAR*
        [DllImport("user32.dll", EntryPoint = "FindWindowExA")]
        public static extern IntPtr FindWindowExA(
            [In] IntPtr hWndParent, [In] IntPtr hWndChildAfter, [In] [MarshalAs(UnmanagedType.LPStr)] string lpszClass,
            [In] [MarshalAs(UnmanagedType.LPStr)] string lpszWindow);

        /// Return Type: BOOL->int
        ///uFlags: UINT->unsigned int
        ///dwReason: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "ExitWindowsEx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ExitWindowsEx(uint uFlags, uint dwReason);

        /// Return Type: BOOL->int
        ///hwinsta: HWINSTA->HWINSTA__*
        ///lpEnumFunc: DESKTOPENUMPROCW->NAMEENUMPROCW
        ///lParam: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "EnumDesktopsW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumDesktopsW([In] IntPtr hwinsta, NAMEENUMPROCW lpEnumFunc, [MarshalAs(UnmanagedType.SysInt)] int lParam);

        /// Return Type: BOOL->int
        ///hwinsta: HWINSTA->HWINSTA__*
        ///lpEnumFunc: DESKTOPENUMPROCA->NAMEENUMPROCA
        ///lParam: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "EnumDesktopsA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumDesktopsA([In] IntPtr hwinsta, NAMEENUMPROCA lpEnumFunc, [MarshalAs(UnmanagedType.SysInt)] int lParam);

        /// Return Type: BOOL->int
        ///hDC: HDC->HDC__*
        ///lprc: RECT*
        [DllImport("user32.dll", EntryPoint = "DrawFocusRect")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DrawFocusRect([In] IntPtr hDC, [In] ref RECT lprc);

        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "DestroyWindow")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DestroyWindow([In] IntPtr hWnd);

        /// Return Type: BOOL->int
        ///hCursor: HCURSOR->HICON->HICON__*
        [DllImport("user32.dll", EntryPoint = "DestroyCursor")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DestroyCursor([In] IntPtr hCursor);

        /// Return Type: LRESULT->LONG_PTR->int
        ///hWnd: HWND->HWND__*
        ///hWndMDIClient: HWND->HWND__*
        ///uMsg: UINT->unsigned int
        ///wParam: WPARAM->UINT_PTR->unsigned int
        ///lParam: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "DefFrameProcW")]
        [return: MarshalAs(UnmanagedType.SysInt)]
        public static extern int DefFrameProcW(
            [In] IntPtr hWnd, [In] IntPtr hWndMDIClient, uint uMsg, [MarshalAs(UnmanagedType.SysUInt)] uint wParam, [MarshalAs(UnmanagedType.SysInt)] int lParam);

        /// Return Type: LRESULT->LONG_PTR->int
        ///hWnd: HWND->HWND__*
        ///hWndMDIClient: HWND->HWND__*
        ///uMsg: UINT->unsigned int
        ///wParam: WPARAM->UINT_PTR->unsigned int
        ///lParam: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "DefFrameProcA")]
        [return: MarshalAs(UnmanagedType.SysInt)]
        public static extern int DefFrameProcA(
            [In] IntPtr hWnd, [In] IntPtr hWndMDIClient, uint uMsg, [MarshalAs(UnmanagedType.SysUInt)] uint wParam, [MarshalAs(UnmanagedType.SysInt)] int lParam);

        /// Return Type: BOOL->int
        ///idInst: DWORD->unsigned int
        ///hszTopic: HSZ->HSZ__*
        ///hszItem: HSZ->HSZ__*
        [DllImport("user32.dll", EntryPoint = "DdePostAdvise")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DdePostAdvise(uint idInst, IntPtr hszTopic, IntPtr hszItem);

        /// Return Type: BOOL->int
        ///hConv: HCONV->HCONV__*
        [DllImport("user32.dll", EntryPoint = "DdeDisconnect")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DdeDisconnect(IntPtr hConv);

        /// Return Type: LPBYTE->BYTE*
        ///hData: HDDEDATA->HDDEDATA__*
        ///pcbDataSize: LPDWORD->DWORD*
        [DllImport("user32.dll", EntryPoint = "DdeAccessData")]
        public static extern IntPtr DdeAccessData(IntPtr hData, ref uint pcbDataSize);

        /// Return Type: DWORD->unsigned int
        ///hMenu: HMENU->HMENU__*
        ///uIDCheckItem: UINT->unsigned int
        ///uCheck: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "CheckMenuItem")]
        public static extern uint CheckMenuItem([In] IntPtr hMenu, uint uIDCheckItem, uint uCheck);

        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///dwTime: DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "AnimateWindow")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AnimateWindow([In] IntPtr hWnd, uint dwTime, uint dwFlags);

        /// Return Type: HWND->HWND__*
        ///hDC: HDC->HDC__*
        [DllImport("user32.dll", EntryPoint = "WindowFromDC")]
        public static extern IntPtr WindowFromDC([In] IntPtr hDC);

        /// Return Type: SHORT->short
        ///ch: WCHAR->wchar_t->unsigned short
        ///dwhkl: HKL->HKL__*
        [DllImport("user32.dll", EntryPoint = "VkKeyScanExW")]
        public static extern short VkKeyScanExW(char ch, [In] IntPtr dwhkl);

        /// Return Type: SHORT->short
        ///ch: CHAR->char
        ///dwhkl: HKL->HKL__*
        [DllImport("user32.dll", EntryPoint = "VkKeyScanExA")]
        public static extern short VkKeyScanExA(byte ch, [In] IntPtr dwhkl);

        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///lpRect: RECT*
        [DllImport("user32.dll", EntryPoint = "ValidateRect")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ValidateRect([In] IntPtr hWnd, [In] IntPtr lpRect);

        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "UpdateWindow")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool UpdateWindow([In] IntPtr hWnd);

        /// Return Type: BOOL->int
        ///lprcDst: LPRECT->tagRECT*
        ///lprcSrc1: RECT*
        ///lprcSrc2: RECT*
        [DllImport("user32.dll", EntryPoint = "SubtractRect")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SubtractRect([Out] out RECT lprcDst, [In] ref RECT lprcSrc1, [In] ref RECT lprcSrc2);

        /// Return Type: int
        ///hWnd: HWND->HWND__*
        ///hRgn: HRGN->HRGN__*
        ///bRedraw: BOOL->int
        [DllImport("user32.dll", EntryPoint = "SetWindowRgn")]
        public static extern int SetWindowRgn([In] IntPtr hWnd, [In] IntPtr hRgn, [MarshalAs(UnmanagedType.Bool)] bool bRedraw);

        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///hWndInsertAfter: HWND->HWND__*
        ///X: int
        ///Y: int
        ///cx: int
        ///cy: int
        ///uFlags: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "SetWindowPos")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowPos([In] IntPtr hWnd, [In] IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        /// Return Type: BOOL->int
        ///cElements: int
        ///lpaElements: INT*
        ///lpaRgbValues: COLORREF*
        [DllImport("user32.dll", EntryPoint = "SetSysColors")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetSysColors(
            int cElements, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I4, SizeParamIndex = 0)] int[] lpaElements,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U4, SizeParamIndex = 0)] uint[] lpaRgbValues);

        /// Return Type: int
        ///hWnd: HWND->HWND__*
        ///nBar: int
        ///nPos: int
        ///bRedraw: BOOL->int
        [DllImport("user32.dll", EntryPoint = "SetScrollPos")]
        public static extern int SetScrollPos([In] IntPtr hWnd, int nBar, int nPos, [MarshalAs(UnmanagedType.Bool)] bool bRedraw);

        /// Return Type: BOOL->int
        ///lprc: LPRECT->tagRECT*
        [DllImport("user32.dll", EntryPoint = "SetRectEmpty")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetRectEmpty([Out] out RECT lprc);

        /// Return Type: BOOL->int
        ///X: int
        ///Y: int
        [DllImport("user32.dll", EntryPoint = "SetCursorPos")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetCursorPos(int X, int Y);

        /// Return Type: WORD->unsigned short
        ///hWnd: HWND->HWND__*
        ///nIndex: int
        ///wNewWord: WORD->unsigned short
        [DllImport("user32.dll", EntryPoint = "SetClassWord")]
        public static extern ushort SetClassWord([In] IntPtr hWnd, int nIndex, ushort wNewWord);

        /// Return Type: LRESULT->LONG_PTR->int
        ///hWnd: HWND->HWND__*
        ///Msg: UINT->unsigned int
        ///wParam: WPARAM->UINT_PTR->unsigned int
        ///lParam: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "SendMessageW")]
        [return: MarshalAs(UnmanagedType.SysInt)]
        public static extern int SendMessageW(
            [In] IntPtr hWnd, uint Msg, [MarshalAs(UnmanagedType.SysUInt)] uint wParam, [MarshalAs(UnmanagedType.SysInt)] int lParam);

        /// Return Type: LRESULT->LONG_PTR->int
        ///hWnd: HWND->HWND__*
        ///Msg: UINT->unsigned int
        ///wParam: WPARAM->UINT_PTR->unsigned int
        ///lParam: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "SendMessageA")]
        [return: MarshalAs(UnmanagedType.SysInt)]
        public static extern int SendMessageA(
            [In] IntPtr hWnd, uint Msg, [MarshalAs(UnmanagedType.SysUInt)] uint wParam, [MarshalAs(UnmanagedType.SysInt)] int lParam);

        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///XAmount: int
        ///YAmount: int
        ///lpRect: RECT*
        ///lpClipRect: RECT*
        [DllImport("user32.dll", EntryPoint = "ScrollWindow")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ScrollWindow([In] IntPtr hWnd, int XAmount, int YAmount, [In] IntPtr lpRect, [In] IntPtr lpClipRect);

        /// Return Type: BOOL->int
        ///lResult: LRESULT->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "ReplyMessage")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ReplyMessage([MarshalAs(UnmanagedType.SysInt)] int lResult);

        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///lprcUpdate: RECT*
        ///hrgnUpdate: HRGN->HRGN__*
        ///flags: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "RedrawWindow")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool RedrawWindow([In] IntPtr hWnd, [In] IntPtr lprcUpdate, [In] IntPtr hrgnUpdate, uint flags);

        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///Msg: UINT->unsigned int
        ///wParam: WPARAM->UINT_PTR->unsigned int
        ///lParam: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "PostMessageW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PostMessageW(
            [In] IntPtr hWnd, uint Msg, [MarshalAs(UnmanagedType.SysUInt)] uint wParam, [MarshalAs(UnmanagedType.SysInt)] int lParam);

        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///Msg: UINT->unsigned int
        ///wParam: WPARAM->UINT_PTR->unsigned int
        ///lParam: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "PostMessageA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PostMessageA(
            [In] IntPtr hWnd, uint Msg, [MarshalAs(UnmanagedType.SysUInt)] uint wParam, [MarshalAs(UnmanagedType.SysInt)] int lParam);

        /// Return Type: BOOL->int
        ///lpMsg: LPMSG->tagMSG*
        ///hWnd: HWND->HWND__*
        ///wMsgFilterMin: UINT->unsigned int
        ///wMsgFilterMax: UINT->unsigned int
        ///wRemoveMsg: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "PeekMessageW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PeekMessageW([Out] out MSG lpMsg, [In] IntPtr hWnd, uint wMsgFilterMin, uint wMsgFilterMax, uint wRemoveMsg);

        /// Return Type: BOOL->int
        ///lpMsg: LPMSG->tagMSG*
        ///hWnd: HWND->HWND__*
        ///wMsgFilterMin: UINT->unsigned int
        ///wMsgFilterMax: UINT->unsigned int
        ///wRemoveMsg: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "PeekMessageA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PeekMessageA([Out] out MSG lpMsg, [In] IntPtr hWnd, uint wMsgFilterMin, uint wMsgFilterMax, uint wRemoveMsg);

        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        [DllImport("user32.dll", EntryPoint = "PaintDesktop")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PaintDesktop([In] IntPtr hdc);

        /// Return Type: HDESK->HDESK__*
        ///lpszDesktop: LPCWSTR->WCHAR*
        ///dwFlags: DWORD->unsigned int
        ///fInherit: BOOL->int
        ///dwDesiredAccess: ACCESS_MASK->DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "OpenDesktopW")]
        public static extern IntPtr OpenDesktopW(
            [In] [MarshalAs(UnmanagedType.LPWStr)] string lpszDesktop, uint dwFlags, [MarshalAs(UnmanagedType.Bool)] bool fInherit, uint dwDesiredAccess);

        /// Return Type: HDESK->HDESK__*
        ///lpszDesktop: LPCSTR->CHAR*
        ///dwFlags: DWORD->unsigned int
        ///fInherit: BOOL->int
        ///dwDesiredAccess: ACCESS_MASK->DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "OpenDesktopA")]
        public static extern IntPtr OpenDesktopA(
            [In] [MarshalAs(UnmanagedType.LPStr)] string lpszDesktop, uint dwFlags, [MarshalAs(UnmanagedType.Bool)] bool fInherit, uint dwDesiredAccess);

        /// Return Type: BOOL->int
        ///ch: WCHAR->wchar_t->unsigned short
        [DllImport("user32.dll", EntryPoint = "IsCharUpperW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsCharUpperW(char ch);

        /// Return Type: BOOL->int
        ///ch: CHAR->char
        [DllImport("user32.dll", EntryPoint = "IsCharUpperA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsCharUpperA(byte ch);

        /// Return Type: BOOL->int
        ///ch: WCHAR->wchar_t->unsigned short
        [DllImport("user32.dll", EntryPoint = "IsCharLowerW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsCharLowerW(char ch);

        /// Return Type: BOOL->int
        ///ch: CHAR->char
        [DllImport("user32.dll", EntryPoint = "IsCharLowerA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsCharLowerA(byte ch);

        /// Return Type: BOOL->int
        ///ch: WCHAR->wchar_t->unsigned short
        [DllImport("user32.dll", EntryPoint = "IsCharAlphaW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsCharAlphaW(char ch);

        /// Return Type: BOOL->int
        ///ch: CHAR->char
        [DllImport("user32.dll", EntryPoint = "IsCharAlphaA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsCharAlphaA(byte ch);

        /// Return Type: int
        ///hWnd: HWND->HWND__*
        ///hRgn: HRGN->HRGN__*
        [DllImport("user32.dll", EntryPoint = "GetWindowRgn")]
        public static extern int GetWindowRgn([In] IntPtr hWnd, [In] IntPtr hRgn);

        /// Return Type: int
        ///hWnd: HWND->HWND__*
        ///hRgn: HRGN->HRGN__*
        ///bErase: BOOL->int
        [DllImport("user32.dll", EntryPoint = "GetUpdateRgn")]
        public static extern int GetUpdateRgn([In] IntPtr hWnd, [In] IntPtr hRgn, [MarshalAs(UnmanagedType.Bool)] bool bErase);

        /// Return Type: HWND->HWND__*
        ///hWnd: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "GetTopWindow")]
        public static extern IntPtr GetTopWindow([In] IntPtr hWnd);

        /// Return Type: int
        ///hWnd: HWND->HWND__*
        ///nBar: int
        [DllImport("user32.dll", EntryPoint = "GetScrollPos")]
        public static extern int GetScrollPos([In] IntPtr hWnd, int nBar);

        /// Return Type: UINT->unsigned int
        ///hMenu: HMENU->HMENU__*
        ///uId: UINT->unsigned int
        ///uFlags: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "GetMenuState")]
        public static extern uint GetMenuState([In] IntPtr hMenu, uint uId, uint uFlags);

        /// Return Type: int
        ///hWnd: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "GetDlgCtrlID")]
        public static extern int GetDlgCtrlID([In] IntPtr hWnd);

        /// Return Type: BOOL->int
        ///lpPoint: LPPOINT->tagPOINT*
        [DllImport("user32.dll", EntryPoint = "GetCursorPos")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetCursorPos([Out] out Point lpPoint);

        /// Return Type: WORD->unsigned short
        ///hWnd: HWND->HWND__*
        ///nIndex: int
        [DllImport("user32.dll", EntryPoint = "GetClassWord")]
        public static extern ushort GetClassWord([In] IntPtr hWnd, int nIndex);

        /// Return Type: int
        ///hWnd: HWND->HWND__*
        ///lpEnumFunc: PROPENUMPROCEXW
        ///lParam: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "EnumPropsExW")]
        public static extern int EnumPropsExW([In] IntPtr hWnd, PROPENUMPROCEXW lpEnumFunc, [MarshalAs(UnmanagedType.SysInt)] int lParam);

        /// Return Type: int
        ///hWnd: HWND->HWND__*
        ///lpEnumFunc: PROPENUMPROCEXA
        ///lParam: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "EnumPropsExA")]
        public static extern int EnumPropsExA([In] IntPtr hWnd, PROPENUMPROCEXA lpEnumFunc, [MarshalAs(UnmanagedType.SysInt)] int lParam);

        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///bEnable: BOOL->int
        [DllImport("user32.dll", EntryPoint = "EnableWindow")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnableWindow([In] IntPtr hWnd, [MarshalAs(UnmanagedType.Bool)] bool bEnable);

        /// Return Type: BOOL->int
        [DllImport("user32.dll", EntryPoint = "DestroyCaret")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DestroyCaret();

        /// Return Type: HCONV->HCONV__*
        ///hConv: HCONV->HCONV__*
        [DllImport("user32.dll", EntryPoint = "DdeReconnect")]
        public static extern IntPtr DdeReconnect(IntPtr hConv);

        /// Return Type: HCURSOR->HICON->HICON__*
        ///hInst: HINSTANCE->HINSTANCE__*
        ///xHotSpot: int
        ///yHotSpot: int
        ///nWidth: int
        ///nHeight: int
        ///pvANDPlane: void*
        ///pvXORPlane: void*
        [DllImport("user32.dll", EntryPoint = "CreateCursor")]
        public static extern IntPtr CreateCursor(
            [In] IntPtr hInst, int xHotSpot, int yHotSpot, int nWidth, int nHeight, [In] IntPtr pvANDPlane, [In] IntPtr pvXORPlane);

        /// Return Type: BOOL->int
        ///hDesktop: HDESK->HDESK__*
        [DllImport("user32.dll", EntryPoint = "CloseDesktop")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CloseDesktop([In] IntPtr hDesktop);

        /// Return Type: BOOL->int
        [DllImport("user32.dll", EntryPoint = "WaitMessage")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WaitMessage();

        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///hRgn: HRGN->HRGN__*
        [DllImport("user32.dll", EntryPoint = "ValidateRgn")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ValidateRgn([In] IntPtr hWnd, [In] IntPtr hRgn);

        /// Return Type: int
        ///wVirtKey: UINT->unsigned int
        ///wScanCode: UINT->unsigned int
        ///lpKeyState: BYTE*
        ///pwszBuff: LPWSTR->WCHAR*
        ///cchBuff: int
        ///wFlags: UINT->unsigned int
        ///dwhkl: HKL->HKL__*
        [DllImport("user32.dll", EntryPoint = "ToUnicodeEx")]
        public static extern int ToUnicodeEx(
            uint wVirtKey, uint wScanCode, [In] IntPtr lpKeyState, [Out] [MarshalAs(UnmanagedType.LPWStr)] StringBuilder pwszBuff, int cchBuff, uint wFlags,
            [In] IntPtr dwhkl);

        /// Return Type: WORD->unsigned short
        ///hwndParent: HWND->HWND__*
        ///wHow: UINT->unsigned int
        ///lpRect: RECT*
        ///cKids: UINT->unsigned int
        ///lpKids: HWND*
        [DllImport("user32.dll", EntryPoint = "TileWindows")]
        public static extern ushort TileWindows([In] IntPtr hwndParent, uint wHow, [In] IntPtr lpRect, uint cKids, ref IntPtr lpKids);

        /// Return Type: BOOL->int
        ///param0: HMENU->HMENU__*
        ///param1: LPCMENUINFO->MENUINFO*
        [DllImport("user32.dll", EntryPoint = "SetMenuInfo")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetMenuInfo([In] IntPtr param0, [In] ref MENUINFO param1);

        /// Return Type: BOOL->int
        ///X: int
        ///Y: int
        [DllImport("user32.dll", EntryPoint = "SetCaretPos")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetCaretPos(int X, int Y);

        /// Return Type: HANDLE->void*
        ///hWnd: HWND->HWND__*
        ///lpString: LPCWSTR->WCHAR*
        [DllImport("user32.dll", EntryPoint = "RemovePropW")]
        public static extern IntPtr RemovePropW([In] IntPtr hWnd, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpString);

        /// Return Type: HANDLE->void*
        ///hWnd: HWND->HWND__*
        ///lpString: LPCSTR->CHAR*
        [DllImport("user32.dll", EntryPoint = "RemovePropA")]
        public static extern IntPtr RemovePropA([In] IntPtr hWnd, [In] [MarshalAs(UnmanagedType.LPStr)] string lpString);

        /// Return Type: BOOL->int
        ///hwnd: HWND->HWND__*
        ///hdcBlt: HDC->HDC__*
        ///nFlags: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "PrintWindow")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PrintWindow([In] IntPtr hwnd, [In] IntPtr hdcBlt, uint nFlags);

        /// Return Type: void
        ///dwFlags: DWORD->unsigned int
        ///dx: DWORD->unsigned int
        ///dy: DWORD->unsigned int
        ///dwData: DWORD->unsigned int
        ///dwExtraInfo: ULONG_PTR->unsigned int
        [DllImport("user32.dll", EntryPoint = "mouse_event")]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, uint dwExtraInfo);

        /// Return Type: BOOL->int
        ///hMnu: HMENU->HMENU__*
        ///uPosition: UINT->unsigned int
        ///uFlags: UINT->unsigned int
        ///uIDNewItem: UINT_PTR->unsigned int
        ///lpNewItem: LPCWSTR->WCHAR*
        [DllImport("user32.dll", EntryPoint = "ModifyMenuW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ModifyMenuW(
            [In] IntPtr hMnu, uint uPosition, uint uFlags, [MarshalAs(UnmanagedType.SysUInt)] uint uIDNewItem,
            [In] [MarshalAs(UnmanagedType.LPWStr)] string lpNewItem);

        /// Return Type: BOOL->int
        ///hMnu: HMENU->HMENU__*
        ///uPosition: UINT->unsigned int
        ///uFlags: UINT->unsigned int
        ///uIDNewItem: UINT_PTR->unsigned int
        ///lpNewItem: LPCSTR->CHAR*
        [DllImport("user32.dll", EntryPoint = "ModifyMenuA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ModifyMenuA(
            [In] IntPtr hMnu, uint uPosition, uint uFlags, [MarshalAs(UnmanagedType.SysUInt)] uint uIDNewItem,
            [In] [MarshalAs(UnmanagedType.LPStr)] string lpNewItem);

        /// Return Type: int
        ///hWnd: HWND->HWND__*
        ///lpText: LPCWSTR->WCHAR*
        ///lpCaption: LPCWSTR->WCHAR*
        ///uType: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "MessageBoxW")]
        public static extern int MessageBoxW(
            [In] IntPtr hWnd, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpText, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpCaption, uint uType);

        /// Return Type: int
        ///hWnd: HWND->HWND__*
        ///lpText: LPCSTR->CHAR*
        ///lpCaption: LPCSTR->CHAR*
        ///uType: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "MessageBoxA")]
        public static extern int MessageBoxA(
            [In] IntPtr hWnd, [In] [MarshalAs(UnmanagedType.LPStr)] string lpText, [In] [MarshalAs(UnmanagedType.LPStr)] string lpCaption, uint uType);

        /// Return Type: BOOL->int
        ///uType: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "MessageBeep")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool MessageBeep(uint uType);

        /// Return Type: int
        ///hInstance: HINSTANCE->HINSTANCE__*
        ///uID: UINT->unsigned int
        ///lpBuffer: LPWSTR->WCHAR*
        ///cchBufferMax: int
        [DllImport("user32.dll", EntryPoint = "LoadStringW")]
        public static extern int LoadStringW([In] IntPtr hInstance, uint uID, [Out] [MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpBuffer, int cchBufferMax);

        /// Return Type: int
        ///hInstance: HINSTANCE->HINSTANCE__*
        ///uID: UINT->unsigned int
        ///lpBuffer: LPSTR->CHAR*
        ///cchBufferMax: int
        [DllImport("user32.dll", EntryPoint = "LoadStringA")]
        public static extern int LoadStringA([In] IntPtr hInstance, uint uID, [Out] [MarshalAs(UnmanagedType.LPStr)] StringBuilder lpBuffer, int cchBufferMax);

        /// Return Type: HCURSOR->HICON->HICON__*
        ///hInstance: HINSTANCE->HINSTANCE__*
        ///lpCursorName: LPCWSTR->WCHAR*
        [DllImport("user32.dll", EntryPoint = "LoadCursorW")]
        public static extern IntPtr LoadCursorW([In] IntPtr hInstance, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpCursorName);

        /// Return Type: HCURSOR->HICON->HICON__*
        ///hInstance: HINSTANCE->HINSTANCE__*
        ///lpCursorName: LPCSTR->CHAR*
        [DllImport("user32.dll", EntryPoint = "LoadCursorA")]
        public static extern IntPtr LoadCursorA([In] IntPtr hInstance, [In] [MarshalAs(UnmanagedType.LPStr)] string lpCursorName);

        /// Return Type: HBITMAP->HBITMAP__*
        ///hInstance: HINSTANCE->HINSTANCE__*
        ///lpBitmapName: LPCWSTR->WCHAR*
        [DllImport("user32.dll", EntryPoint = "LoadBitmapW")]
        public static extern IntPtr LoadBitmapW([In] IntPtr hInstance, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpBitmapName);

        /// Return Type: HBITMAP->HBITMAP__*
        ///hInstance: HINSTANCE->HINSTANCE__*
        ///lpBitmapName: LPCSTR->CHAR*
        [DllImport("user32.dll", EntryPoint = "LoadBitmapA")]
        public static extern IntPtr LoadBitmapA([In] IntPtr hInstance, [In] [MarshalAs(UnmanagedType.LPStr)] string lpBitmapName);

        /// Return Type: void
        ///bVk: BYTE->unsigned char
        ///bScan: BYTE->unsigned char
        ///dwFlags: DWORD->unsigned int
        ///dwExtraInfo: ULONG_PTR->unsigned int
        [DllImport("user32.dll", EntryPoint = "keybd_event")]
        public static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, uint dwExtraInfo);

        /// Return Type: BOOL->int
        ///lprc: RECT*
        [DllImport("user32.dll", EntryPoint = "IsRectEmpty")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsRectEmpty([In] ref RECT lprc);

        /// Return Type: BOOL->int
        ///bConvert: BOOL->int
        [DllImport("user32.dll", EntryPoint = "IsGUIThread")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsGUIThread([MarshalAs(UnmanagedType.Bool)] bool bConvert);

        /// Return Type: BOOL->int
        ///hMenu: HMENU->HMENU__*
        ///uPosition: UINT->unsigned int
        ///uFlags: UINT->unsigned int
        ///uIDNewItem: UINT_PTR->unsigned int
        ///lpNewItem: LPCWSTR->WCHAR*
        [DllImport("user32.dll", EntryPoint = "InsertMenuW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool InsertMenuW(
            [In] IntPtr hMenu, uint uPosition, uint uFlags, [MarshalAs(UnmanagedType.SysUInt)] uint uIDNewItem,
            [In] [MarshalAs(UnmanagedType.LPWStr)] string lpNewItem);

        /// Return Type: BOOL->int
        ///hMenu: HMENU->HMENU__*
        ///uPosition: UINT->unsigned int
        ///uFlags: UINT->unsigned int
        ///uIDNewItem: UINT_PTR->unsigned int
        ///lpNewItem: LPCSTR->CHAR*
        [DllImport("user32.dll", EntryPoint = "InsertMenuA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool InsertMenuA(
            [In] IntPtr hMenu, uint uPosition, uint uFlags, [MarshalAs(UnmanagedType.SysUInt)] uint uIDNewItem,
            [In] [MarshalAs(UnmanagedType.LPStr)] string lpNewItem);

        /// Return Type: BOOL->int
        ///lprc: LPRECT->tagRECT*
        ///dx: int
        ///dy: int
        [DllImport("user32.dll", EntryPoint = "InflateRect")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool InflateRect(ref RECT lprc, int dx, int dy);

        /// Return Type: BOOL->int
        ///hDC: HDC->HDC__*
        ///hBrush: HBRUSH->HBRUSH__*
        ///lpOutputFunc: GRAYSTRINGPROC
        ///lpData: LPARAM->LONG_PTR->int
        ///nCount: int
        ///X: int
        ///Y: int
        ///nWidth: int
        ///nHeight: int
        [DllImport("user32.dll", EntryPoint = "GrayStringW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GrayStringW(
            [In] IntPtr hDC, [In] IntPtr hBrush, GRAYSTRINGPROC lpOutputFunc, [MarshalAs(UnmanagedType.SysInt)] int lpData, int nCount, int X, int Y, int nWidth,
            int nHeight);

        /// Return Type: BOOL->int
        ///hDC: HDC->HDC__*
        ///hBrush: HBRUSH->HBRUSH__*
        ///lpOutputFunc: GRAYSTRINGPROC
        ///lpData: LPARAM->LONG_PTR->int
        ///nCount: int
        ///X: int
        ///Y: int
        ///nWidth: int
        ///nHeight: int
        [DllImport("user32.dll", EntryPoint = "GrayStringA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GrayStringA(
            [In] IntPtr hDC, [In] IntPtr hBrush, GRAYSTRINGPROC lpOutputFunc, [MarshalAs(UnmanagedType.SysInt)] int lpData, int nCount, int X, int Y, int nWidth,
            int nHeight);

        /// Return Type: HDC->HDC__*
        ///hWnd: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "GetWindowDC")]
        public static extern IntPtr GetWindowDC([In] IntPtr hWnd);

        /// Return Type: DWORD->unsigned int
        ///nIndex: int
        [DllImport("user32.dll", EntryPoint = "GetSysColor")]
        public static extern uint GetSysColor(int nIndex);

        /// Return Type: BOOL->int
        ///lpMsg: LPMSG->tagMSG*
        ///hWnd: HWND->HWND__*
        ///wMsgFilterMin: UINT->unsigned int
        ///wMsgFilterMax: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "GetMessageW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetMessageW([Out] out MSG lpMsg, [In] IntPtr hWnd, uint wMsgFilterMin, uint wMsgFilterMax);

        /// Return Type: BOOL->int
        ///lpMsg: LPMSG->tagMSG*
        ///hWnd: HWND->HWND__*
        ///wMsgFilterMin: UINT->unsigned int
        ///wMsgFilterMax: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "GetMessageA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetMessageA([Out] out MSG lpMsg, [In] IntPtr hWnd, uint wMsgFilterMin, uint wMsgFilterMax);

        /// Return Type: BOOL->int
        ///param0: HMENU->HMENU__*
        ///param1: LPMENUINFO->tagMENUINFO*
        [DllImport("user32.dll", EntryPoint = "GetMenuInfo")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetMenuInfo([In] IntPtr param0, ref MENUINFO param1);

        /// Return Type: SHORT->short
        ///nVirtKey: int
        [DllImport("user32.dll", EntryPoint = "GetKeyState")]
        public static extern short GetKeyState(int nVirtKey);

        /// Return Type: BOOL->int
        ///hIcon: HICON->HICON__*
        ///piconinfo: PICONINFO->ICONINFO*
        [DllImport("user32.dll", EntryPoint = "GetIconInfo")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetIconInfo([In] IntPtr hIcon, [Out] out ICONINFO piconinfo);

        /// Return Type: BOOL->int
        ///lpPoint: LPPOINT->tagPOINT*
        [DllImport("user32.dll", EntryPoint = "GetCaretPos")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetCaretPos([Out] out Point lpPoint);

        /// Return Type: HWND->HWND__*
        ///hwnd: HWND->HWND__*
        ///gaFlags: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "GetAncestor")]
        public static extern IntPtr GetAncestor([In] IntPtr hwnd, uint gaFlags);

        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///bInvert: BOOL->int
        [DllImport("user32.dll", EntryPoint = "FlashWindow")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FlashWindow([In] IntPtr hWnd, [MarshalAs(UnmanagedType.Bool)] bool bInvert);

        /// Return Type: HWND->HWND__*
        ///lpClassName: LPCWSTR->WCHAR*
        ///lpWindowName: LPCWSTR->WCHAR*
        [DllImport("user32.dll", EntryPoint = "FindWindowW")]
        public static extern IntPtr FindWindowW(
            [In] [MarshalAs(UnmanagedType.LPWStr)] string lpClassName, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpWindowName);

        /// Return Type: HWND->HWND__*
        ///lpClassName: LPCSTR->CHAR*
        ///lpWindowName: LPCSTR->CHAR*
        [DllImport("user32.dll", EntryPoint = "FindWindowA")]
        public static extern IntPtr FindWindowA(
            [In] [MarshalAs(UnmanagedType.LPStr)] string lpClassName, [In] [MarshalAs(UnmanagedType.LPStr)] string lpWindowName);

        /// Return Type: BOOL->int
        ///lpEnumFunc: WNDENUMPROC
        ///lParam: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "EnumWindows")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumWindows(WNDENUMPROC lpEnumFunc, [MarshalAs(UnmanagedType.SysInt)] int lParam);

        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///lpchText: LPWSTR->WCHAR*
        ///cchText: int
        ///lprc: LPRECT->tagRECT*
        ///format: UINT->unsigned int
        ///lpdtp: LPDRAWTEXTPARAMS->tagDRAWTEXTPARAMS*
        [DllImport("user32.dll", EntryPoint = "DrawTextExW")]
        public static extern int DrawTextExW(
            [In] IntPtr hdc, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpchText, int cchText, ref RECT lprc, uint format, [In] IntPtr lpdtp);

        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///lpchText: LPSTR->CHAR*
        ///cchText: int
        ///lprc: LPRECT->tagRECT*
        ///format: UINT->unsigned int
        ///lpdtp: LPDRAWTEXTPARAMS->tagDRAWTEXTPARAMS*
        [DllImport("user32.dll", EntryPoint = "DrawTextExA")]
        public static extern int DrawTextExA(
            [In] IntPtr hdc, [MarshalAs(UnmanagedType.LPStr)] StringBuilder lpchText, int cchText, ref RECT lprc, uint format, [In] IntPtr lpdtp);

        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "DrawMenuBar")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DrawMenuBar([In] IntPtr hWnd);

        /// Return Type: BOOL->int
        ///hwnd: HWND->HWND__*
        ///hdc: HDC->HDC__*
        ///lprect: RECT*
        ///flags: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "DrawCaption")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DrawCaption([In] IntPtr hwnd, [In] IntPtr hdc, [In] ref RECT lprect, uint flags);

        /// Return Type: int
        ///hDlg: HWND->HWND__*
        ///lpPathSpec: LPWSTR->WCHAR*
        ///nIDListBox: int
        ///nIDStaticPath: int
        ///uFileType: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "DlgDirListW")]
        public static extern int DlgDirListW([In] IntPtr hDlg, IntPtr lpPathSpec, int nIDListBox, int nIDStaticPath, uint uFileType);

        /// Return Type: int
        ///hDlg: HWND->HWND__*
        ///lpPathSpec: LPSTR->CHAR*
        ///nIDListBox: int
        ///nIDStaticPath: int
        ///uFileType: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "DlgDirListA")]
        public static extern int DlgDirListA([In] IntPtr hDlg, IntPtr lpPathSpec, int nIDListBox, int nIDStaticPath, uint uFileType);

        /// Return Type: BOOL->int
        ///hMenu: HMENU->HMENU__*
        [DllImport("user32.dll", EntryPoint = "DestroyMenu")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DestroyMenu([In] IntPtr hMenu);

        /// Return Type: BOOL->int
        ///hIcon: HICON->HICON__*
        [DllImport("user32.dll", EntryPoint = "DestroyIcon")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DestroyIcon([In] IntPtr hIcon);

        /// Return Type: LRESULT->LONG_PTR->int
        ///hDlg: HWND->HWND__*
        ///Msg: UINT->unsigned int
        ///wParam: WPARAM->UINT_PTR->unsigned int
        ///lParam: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "DefDlgProcW")]
        [return: MarshalAs(UnmanagedType.SysInt)]
        public static extern int DefDlgProcW(
            [In] IntPtr hDlg, uint Msg, [MarshalAs(UnmanagedType.SysUInt)] uint wParam, [MarshalAs(UnmanagedType.SysInt)] int lParam);

        /// Return Type: LRESULT->LONG_PTR->int
        ///hDlg: HWND->HWND__*
        ///Msg: UINT->unsigned int
        ///wParam: WPARAM->UINT_PTR->unsigned int
        ///lParam: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "DefDlgProcA")]
        [return: MarshalAs(UnmanagedType.SysInt)]
        public static extern int DefDlgProcA(
            [In] IntPtr hDlg, uint Msg, [MarshalAs(UnmanagedType.SysUInt)] uint wParam, [MarshalAs(UnmanagedType.SysInt)] int lParam);

        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///hBitmap: HBITMAP->HBITMAP__*
        ///nWidth: int
        ///nHeight: int
        [DllImport("user32.dll", EntryPoint = "CreateCaret")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CreateCaret([In] IntPtr hWnd, [In] IntPtr hBitmap, int nWidth, int nHeight);

        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "CloseWindow")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CloseWindow([In] IntPtr hWnd);

        /// Return Type: LPSTR->CHAR*
        ///CodePage: WORD->unsigned short
        ///lpStart: LPCSTR->CHAR*
        ///lpCurrentChar: LPCSTR->CHAR*
        ///dwFlags: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "CharPrevExA")]
        [return: MarshalAs(UnmanagedType.LPStr)]
        public static extern string CharPrevExA(
            ushort CodePage, [In] [MarshalAs(UnmanagedType.LPStr)] string lpStart, [In] [MarshalAs(UnmanagedType.LPStr)] string lpCurrentChar, uint dwFlags);

        /// Return Type: LPSTR->CHAR*
        ///CodePage: WORD->unsigned short
        ///lpCurrentChar: LPCSTR->CHAR*
        ///dwFlags: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "CharNextExA")]
        [return: MarshalAs(UnmanagedType.LPStr)]
        public static extern string CharNextExA(ushort CodePage, [In] [MarshalAs(UnmanagedType.LPStr)] string lpCurrentChar, uint dwFlags);

        /// Return Type: BOOL->int
        ///hMenu: HMENU->HMENU__*
        ///cmd: UINT->unsigned int
        ///lpszNewItem: LPCWSTR->WCHAR*
        ///cmdInsert: UINT->unsigned int
        ///flags: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "ChangeMenuW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ChangeMenuW(
            [In] IntPtr hMenu, uint cmd, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpszNewItem, uint cmdInsert, uint flags);

        /// Return Type: BOOL->int
        ///hMenu: HMENU->HMENU__*
        ///cmd: UINT->unsigned int
        ///lpszNewItem: LPCSTR->CHAR*
        ///cmdInsert: UINT->unsigned int
        ///flags: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "ChangeMenuA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ChangeMenuA([In] IntPtr hMenu, uint cmd, [In] [MarshalAs(UnmanagedType.LPStr)] string lpszNewItem, uint cmdInsert, uint flags);

        /// Return Type: BOOL->int
        ///hMenu: HMENU->HMENU__*
        ///uFlags: UINT->unsigned int
        ///uIDNewItem: UINT_PTR->unsigned int
        ///lpNewItem: LPCWSTR->WCHAR*
        [DllImport("user32.dll", EntryPoint = "AppendMenuW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AppendMenuW(
            [In] IntPtr hMenu, uint uFlags, [MarshalAs(UnmanagedType.SysUInt)] uint uIDNewItem, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpNewItem);

        /// Return Type: BOOL->int
        ///hMenu: HMENU->HMENU__*
        ///uFlags: UINT->unsigned int
        ///uIDNewItem: UINT_PTR->unsigned int
        ///lpNewItem: LPCSTR->CHAR*
        [DllImport("user32.dll", EntryPoint = "AppendMenuA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AppendMenuA(
            [In] IntPtr hMenu, uint uFlags, [MarshalAs(UnmanagedType.SysUInt)] uint uIDNewItem, [In] [MarshalAs(UnmanagedType.LPStr)] string lpNewItem);

        /// Return Type: int
        ///param0: LPWSTR->WCHAR*
        ///param1: LPCWSTR->WCHAR*
        ///arglist: va_list->char*
        [DllImport("user32.dll", EntryPoint = "wvsprintfW")]
        public static extern int wvsprintfW(
            [Out] [MarshalAs(UnmanagedType.LPWStr)] StringBuilder param0, [In] [MarshalAs(UnmanagedType.LPWStr)] string param1,
            [In] [MarshalAs(UnmanagedType.LPStr)] string arglist);

        /// Return Type: int
        ///param0: LPSTR->CHAR*
        ///param1: LPCSTR->CHAR*
        ///arglist: va_list->char*
        [DllImport("user32.dll", EntryPoint = "wvsprintfA")]
        public static extern int wvsprintfA(
            [Out] [MarshalAs(UnmanagedType.LPStr)] StringBuilder param0, [In] [MarshalAs(UnmanagedType.LPStr)] string param1,
            [In] [MarshalAs(UnmanagedType.LPStr)] string arglist);

        /// Return Type: SHORT->short
        ///ch: WCHAR->wchar_t->unsigned short
        [DllImport("user32.dll", EntryPoint = "VkKeyScanW")]
        public static extern short VkKeyScanW(char ch);

        /// Return Type: SHORT->short
        ///ch: CHAR->char
        [DllImport("user32.dll", EntryPoint = "VkKeyScanA")]
        public static extern short VkKeyScanA(byte ch);

        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///nCmdShow: int
        [DllImport("user32.dll", EntryPoint = "ShowWindow")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ShowWindow([In] IntPtr hWnd, int nCmdShow);

        /// Return Type: int
        ///bShow: BOOL->int
        [DllImport("user32.dll", EntryPoint = "ShowCursor")]
        public static extern int ShowCursor([MarshalAs(UnmanagedType.Bool)] bool bShow);

        /// Return Type: HWND->HWND__*
        ///hWnd: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "SetCapture")]
        public static extern IntPtr SetCapture([In] IntPtr hWnd);

        /// Return Type: BOOL->int
        ///hMenu: HMENU->HMENU__*
        ///uPosition: UINT->unsigned int
        ///uFlags: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "RemoveMenu")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool RemoveMenu([In] IntPtr hMenu, uint uPosition, uint uFlags);

        /// Return Type: BOOL->int
        ///lprc: LPRECT->tagRECT*
        ///dx: int
        ///dy: int
        [DllImport("user32.dll", EntryPoint = "OffsetRect")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool OffsetRect(ref RECT lprc, int dx, int dy);

        /// Return Type: BOOL->int
        ///lpszSrc: LPCSTR->CHAR*
        ///lpszDst: LPWSTR->WCHAR*
        [DllImport("user32.dll", EntryPoint = "OemToCharW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool OemToCharW(
            [In] [MarshalAs(UnmanagedType.LPStr)] string lpszSrc, [Out] [MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpszDst);

        /// Return Type: BOOL->int
        ///lpszSrc: LPCSTR->CHAR*
        ///lpszDst: LPSTR->CHAR*
        [DllImport("user32.dll", EntryPoint = "OemToCharA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool OemToCharA([In] [MarshalAs(UnmanagedType.LPStr)] string lpszSrc, [Out] [MarshalAs(UnmanagedType.LPStr)] StringBuilder lpszDst);

        /// Return Type: DWORD->unsigned int
        ///wOemChar: WORD->unsigned short
        [DllImport("user32.dll", EntryPoint = "OemKeyScan")]
        public static extern uint OemKeyScan(ushort wOemChar);

        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///X: int
        ///Y: int
        ///nWidth: int
        ///nHeight: int
        ///bRepaint: BOOL->int
        [DllImport("user32.dll", EntryPoint = "MoveWindow")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool MoveWindow([In] IntPtr hWnd, int X, int Y, int nWidth, int nHeight, [MarshalAs(UnmanagedType.Bool)] bool bRepaint);

        /// Return Type: HANDLE->void*
        ///hInst: HINSTANCE->HINSTANCE__*
        ///name: LPCWSTR->WCHAR*
        ///type: UINT->unsigned int
        ///cx: int
        ///cy: int
        ///fuLoad: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "LoadImageW")]
        public static extern IntPtr LoadImageW([In] IntPtr hInst, [In] [MarshalAs(UnmanagedType.LPWStr)] string name, uint type, int cx, int cy, uint fuLoad);

        /// Return Type: HANDLE->void*
        ///hInst: HINSTANCE->HINSTANCE__*
        ///name: LPCSTR->CHAR*
        ///type: UINT->unsigned int
        ///cx: int
        ///cy: int
        ///fuLoad: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "LoadImageA")]
        public static extern IntPtr LoadImageA([In] IntPtr hInst, [In] [MarshalAs(UnmanagedType.LPStr)] string name, uint type, int cx, int cy, uint fuLoad);

        /// Return Type: BOOL->int
        ///hDC: HDC->HDC__*
        ///lprc: RECT*
        [DllImport("user32.dll", EntryPoint = "InvertRect")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool InvertRect([In] IntPtr hDC, [In] ref RECT lprc);

        /// Return Type: HMENU->HMENU__*
        ///hMenu: HMENU->HMENU__*
        ///nPos: int
        [DllImport("user32.dll", EntryPoint = "GetSubMenu")]
        public static extern IntPtr GetSubMenu([In] IntPtr hMenu, int nPos);

        /// Return Type: HWND->HWND__*
        ///hDlg: HWND->HWND__*
        ///nIDDlgItem: int
        [DllImport("user32.dll", EntryPoint = "GetDlgItem")]
        public static extern IntPtr GetDlgItem([In] IntPtr hDlg, int nIDDlgItem);

        /// Return Type: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "GetCapture")]
        public static extern IntPtr GetCapture();

        /// Return Type: int
        ///hWnd: HWND->HWND__*
        ///lpEnumFunc: PROPENUMPROCW
        [DllImport("user32.dll", EntryPoint = "EnumPropsW")]
        public static extern int EnumPropsW([In] IntPtr hWnd, PROPENUMPROCW lpEnumFunc);

        /// Return Type: int
        ///hWnd: HWND->HWND__*
        ///lpEnumFunc: PROPENUMPROCA
        [DllImport("user32.dll", EntryPoint = "EnumPropsA")]
        public static extern int EnumPropsA([In] IntPtr hWnd, PROPENUMPROCA lpEnumFunc);

        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///hbrFore: HBRUSH->HBRUSH__*
        ///qfnCallBack: DRAWSTATEPROC
        ///lData: LPARAM->LONG_PTR->int
        ///wData: WPARAM->UINT_PTR->unsigned int
        ///x: int
        ///y: int
        ///cx: int
        ///cy: int
        ///uFlags: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "DrawStateW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DrawStateW(
            [In] IntPtr hdc, [In] IntPtr hbrFore, DRAWSTATEPROC qfnCallBack, [MarshalAs(UnmanagedType.SysInt)] int lData,
            [MarshalAs(UnmanagedType.SysUInt)] uint wData, int x, int y, int cx, int cy, uint uFlags);

        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///hbrFore: HBRUSH->HBRUSH__*
        ///qfnCallBack: DRAWSTATEPROC
        ///lData: LPARAM->LONG_PTR->int
        ///wData: WPARAM->UINT_PTR->unsigned int
        ///x: int
        ///y: int
        ///cx: int
        ///cy: int
        ///uFlags: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "DrawStateA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DrawStateA(
            [In] IntPtr hdc, [In] IntPtr hbrFore, DRAWSTATEPROC qfnCallBack, [MarshalAs(UnmanagedType.SysInt)] int lData,
            [MarshalAs(UnmanagedType.SysUInt)] uint wData, int x, int y, int cx, int cy, uint uFlags);

        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///xLeft: int
        ///yTop: int
        ///hIcon: HICON->HICON__*
        ///cxWidth: int
        ///cyWidth: int
        ///istepIfAniCur: UINT->unsigned int
        ///hbrFlickerFreeDraw: HBRUSH->HBRUSH__*
        ///diFlags: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "DrawIconEx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DrawIconEx(
            [In] IntPtr hdc, int xLeft, int yTop, [In] IntPtr hIcon, int cxWidth, int cyWidth, uint istepIfAniCur, [In] IntPtr hbrFlickerFreeDraw, uint diFlags);

        /// Return Type: DWORD->unsigned int
        ///hwndParent: HWND->HWND__*
        ///hwndFrom: HWND->HWND__*
        ///fmt: UINT->unsigned int
        ///data: ULONG_PTR->unsigned int
        ///hcur: HCURSOR->HICON->HICON__*
        [DllImport("user32.dll", EntryPoint = "DragObject")]
        public static extern uint DragObject([In] IntPtr hwndParent, [In] IntPtr hwndFrom, uint fmt, uint data, [In] IntPtr hcur);

        /// Return Type: BOOL->int
        ///hwnd: HWND->HWND__*
        ///pt: POINT->tagPOINT
        [DllImport("user32.dll", EntryPoint = "DragDetect")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DragDetect([In] IntPtr hwnd, Point pt);

        /// Return Type: BOOL->int
        ///hMenu: HMENU->HMENU__*
        ///uPosition: UINT->unsigned int
        ///uFlags: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "DeleteMenu")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DeleteMenu([In] IntPtr hMenu, uint uPosition, uint uFlags);

        /// Return Type: DWORD->unsigned int
        ///hData: HDDEDATA->HDDEDATA__*
        ///pDst: LPBYTE->BYTE*
        ///cbMax: DWORD->unsigned int
        ///cbOff: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "DdeGetData")]
        public static extern uint DdeGetData(IntPtr hData, ref byte pDst, uint cbMax, uint cbOff);

        /// Return Type: HCONV->HCONV__*
        ///idInst: DWORD->unsigned int
        ///hszService: HSZ->HSZ__*
        ///hszTopic: HSZ->HSZ__*
        ///pCC: PCONVCONTEXT->CONVCONTEXT*
        [DllImport("user32.dll", EntryPoint = "DdeConnect")]
        public static extern IntPtr DdeConnect(uint idInst, IntPtr hszService, IntPtr hszTopic, ref CONVCONTEXT pCC);

        /// Return Type: HDDEDATA->HDDEDATA__*
        ///hData: HDDEDATA->HDDEDATA__*
        ///pSrc: LPBYTE->BYTE*
        ///cb: DWORD->unsigned int
        ///cbOff: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "DdeAddData")]
        public static extern IntPtr DdeAddData(IntPtr hData, ref byte pSrc, uint cb, uint cbOff);

        /// Return Type: HMENU->HMENU__*
        [DllImport("user32.dll", EntryPoint = "CreateMenu")]
        public static extern IntPtr CreateMenu();

        /// Return Type: HICON->HICON__*
        ///hInstance: HINSTANCE->HINSTANCE__*
        ///nWidth: int
        ///nHeight: int
        ///cPlanes: BYTE->unsigned char
        ///cBitsPixel: BYTE->unsigned char
        ///lpbANDbits: BYTE*
        ///lpbXORbits: BYTE*
        [DllImport("user32.dll", EntryPoint = "CreateIcon")]
        public static extern IntPtr CreateIcon(
            [In] IntPtr hInstance, int nWidth, int nHeight, byte cPlanes, byte cBitsPixel, [In] ref byte lpbANDbits, [In] ref byte lpbXORbits);

        /// Return Type: BOOL->int
        ///lpRect: RECT*
        [DllImport("user32.dll", EntryPoint = "ClipCursor")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ClipCursor([In] IntPtr lpRect);

        /// Return Type: LPWSTR->WCHAR*
        ///lpsz: LPWSTR->WCHAR*
        [DllImport("user32.dll", EntryPoint = "CharUpperW")]
        [return: MarshalAs(UnmanagedType.LPWStr)]
        public static extern string CharUpperW(IntPtr lpsz);

        /// Return Type: LPSTR->CHAR*
        ///lpsz: LPSTR->CHAR*
        [DllImport("user32.dll", EntryPoint = "CharUpperA")]
        [return: MarshalAs(UnmanagedType.LPStr)]
        public static extern string CharUpperA(IntPtr lpsz);

        /// Return Type: BOOL->int
        ///lpszSrc: LPCWSTR->WCHAR*
        ///lpszDst: LPSTR->CHAR*
        [DllImport("user32.dll", EntryPoint = "CharToOemW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CharToOemW(
            [In] [MarshalAs(UnmanagedType.LPWStr)] string lpszSrc, [Out] [MarshalAs(UnmanagedType.LPStr)] StringBuilder lpszDst);

        /// Return Type: BOOL->int
        ///lpszSrc: LPCSTR->CHAR*
        ///lpszDst: LPSTR->CHAR*
        [DllImport("user32.dll", EntryPoint = "CharToOemA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CharToOemA([In] [MarshalAs(UnmanagedType.LPStr)] string lpszSrc, [Out] [MarshalAs(UnmanagedType.LPStr)] StringBuilder lpszDst);

        /// Return Type: LPWSTR->WCHAR*
        ///lpsz: LPWSTR->WCHAR*
        [DllImport("user32.dll", EntryPoint = "CharLowerW")]
        [return: MarshalAs(UnmanagedType.LPWStr)]
        public static extern string CharLowerW(IntPtr lpsz);

        /// Return Type: LPSTR->CHAR*
        ///lpsz: LPSTR->CHAR*
        [DllImport("user32.dll", EntryPoint = "CharLowerA")]
        [return: MarshalAs(UnmanagedType.LPStr)]
        public static extern string CharLowerA(IntPtr lpsz);

        /// Return Type: HDC->HDC__*
        ///hWnd: HWND->HWND__*
        ///lpPaint: LPPAINTSTRUCT->tagPAINTSTRUCT*
        [DllImport("user32.dll", EntryPoint = "BeginPaint")]
        public static extern IntPtr BeginPaint([In] IntPtr hWnd, [Out] out PAINTSTRUCT lpPaint);

        /// Return Type: BOOL->int
        ///lprcDst: LPRECT->tagRECT*
        ///lprcSrc1: RECT*
        ///lprcSrc2: RECT*
        [DllImport("user32.dll", EntryPoint = "UnionRect")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool UnionRect([Out] out RECT lprcDst, [In] ref RECT lprcSrc1, [In] ref RECT lprcSrc2);

        /// Return Type: int
        ///wVirtKey: UINT->unsigned int
        ///wScanCode: UINT->unsigned int
        ///lpKeyState: BYTE*
        ///pwszBuff: LPWSTR->WCHAR*
        ///cchBuff: int
        ///wFlags: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "ToUnicode")]
        public static extern int ToUnicode(
            uint wVirtKey, uint wScanCode, [In] IntPtr lpKeyState, [Out] [MarshalAs(UnmanagedType.LPWStr)] StringBuilder pwszBuff, int cchBuff, uint wFlags);

        /// Return Type: int
        ///uVirtKey: UINT->unsigned int
        ///uScanCode: UINT->unsigned int
        ///lpKeyState: BYTE*
        ///lpChar: LPWORD->WORD*
        ///uFlags: UINT->unsigned int
        ///dwhkl: HKL->HKL__*
        [DllImport("user32.dll", EntryPoint = "ToAsciiEx")]
        public static extern int ToAsciiEx(uint uVirtKey, uint uScanCode, [In] IntPtr lpKeyState, [Out] out ushort lpChar, uint uFlags, [In] IntPtr dwhkl);

        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "ShowCaret")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ShowCaret([In] IntPtr hWnd);

        /// Return Type: HWND->HWND__*
        ///hWndChild: HWND->HWND__*
        ///hWndNewParent: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "SetParent")]
        public static extern IntPtr SetParent([In] IntPtr hWndChild, [In] IntPtr hWndNewParent);

        /// Return Type: HCURSOR->HICON->HICON__*
        ///hCursor: HCURSOR->HICON->HICON__*
        [DllImport("user32.dll", EntryPoint = "SetCursor")]
        public static extern IntPtr SetCursor([In] IntPtr hCursor);

        /// Return Type: UINT->unsigned int
        ///cInputs: UINT->unsigned int
        ///pInputs: LPINPUT->tagINPUT*
        ///cbSize: int
        [DllImport("user32.dll", EntryPoint = "SendInput")]
        public static extern uint SendInput(
            uint cInputs, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 0)] INPUT[] pInputs, int cbSize);

        /// Return Type: int
        ///hWnd: HWND->HWND__*
        ///hDC: HDC->HDC__*
        [DllImport("user32.dll", EntryPoint = "ReleaseDC")]
        public static extern int ReleaseDC([In] IntPtr hWnd, [In] IntPtr hDC);

        /// Return Type: HMENU->HMENU__*
        ///hInstance: HINSTANCE->HINSTANCE__*
        ///lpMenuName: LPCWSTR->WCHAR*
        [DllImport("user32.dll", EntryPoint = "LoadMenuW")]
        public static extern IntPtr LoadMenuW([In] IntPtr hInstance, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpMenuName);

        /// Return Type: HMENU->HMENU__*
        ///hInstance: HINSTANCE->HINSTANCE__*
        ///lpMenuName: LPCSTR->CHAR*
        [DllImport("user32.dll", EntryPoint = "LoadMenuA")]
        public static extern IntPtr LoadMenuA([In] IntPtr hInstance, [In] [MarshalAs(UnmanagedType.LPStr)] string lpMenuName);

        /// Return Type: HICON->HICON__*
        ///hInstance: HINSTANCE->HINSTANCE__*
        ///lpIconName: LPCWSTR->WCHAR*
        [DllImport("user32.dll", EntryPoint = "LoadIconW")]
        public static extern IntPtr LoadIconW([In] IntPtr hInstance, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpIconName);

        /// Return Type: HICON->HICON__*
        ///hInstance: HINSTANCE->HINSTANCE__*
        ///lpIconName: LPCSTR->CHAR*
        [DllImport("user32.dll", EntryPoint = "LoadIconA")]
        public static extern IntPtr LoadIconA([In] IntPtr hInstance, [In] [MarshalAs(UnmanagedType.LPStr)] string lpIconName);

        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///uIDEvent: UINT_PTR->unsigned int
        [DllImport("user32.dll", EntryPoint = "KillTimer")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool KillTimer([In] IntPtr hWnd, [MarshalAs(UnmanagedType.SysUInt)] uint uIDEvent);

        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "HideCaret")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool HideCaret([In] IntPtr hWnd);

        /// Return Type: HWND->HWND__*
        ///hWnd: HWND->HWND__*
        ///uCmd: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "GetWindow")]
        public static extern IntPtr GetWindow([In] IntPtr hWnd, uint uCmd);

        /// Return Type: HWND->HWND__*
        ///hWnd: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "GetParent")]
        public static extern IntPtr GetParent([In] IntPtr hWnd);

        /// Return Type: HCURSOR->HICON->HICON__*
        [DllImport("user32.dll", EntryPoint = "GetCursor")]
        public static extern IntPtr GetCursor();

        /// Return Type: int
        ///hDC: HDC->HDC__*
        ///lprc: RECT*
        ///hbr: HBRUSH->HBRUSH__*
        [DllImport("user32.dll", EntryPoint = "FrameRect")]
        public static extern int FrameRect([In] IntPtr hDC, [In] ref RECT lprc, [In] IntPtr hbr);

        /// Return Type: BOOL->int
        ///lprc1: RECT*
        ///lprc2: RECT*
        [DllImport("user32.dll", EntryPoint = "EqualRect")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EqualRect([In] ref RECT lprc1, [In] ref RECT lprc2);

        /// Return Type: BOOL->int
        ///hDlg: HWND->HWND__*
        ///nResult: INT_PTR->int
        [DllImport("user32.dll", EntryPoint = "EndDialog")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EndDialog([In] IntPtr hDlg, int nResult);

        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///lpchText: LPCWSTR->WCHAR*
        ///cchText: int
        ///lprc: LPRECT->tagRECT*
        ///format: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "DrawTextW")]
        public static extern int DrawTextW(
            [In] IntPtr hdc, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpchText, int cchText, ref RECT lprc, uint format);

        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///lpchText: LPCSTR->CHAR*
        ///cchText: int
        ///lprc: LPRECT->tagRECT*
        ///format: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "DrawTextA")]
        public static extern int DrawTextA([In] IntPtr hdc, [MarshalAs(UnmanagedType.LPStr)] StringBuilder lpchText, int cchText, ref RECT lprc, uint format);

        /// Return Type: HANDLE->void*
        ///h: HANDLE->void*
        ///type: UINT->unsigned int
        ///cx: int
        ///cy: int
        ///flags: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "CopyImage")]
        public static extern IntPtr CopyImage([In] IntPtr h, uint type, int cx, int cy, uint flags);

        /// Return Type: LPWSTR->WCHAR*
        ///lpszStart: LPCWSTR->WCHAR*
        ///lpszCurrent: LPCWSTR->WCHAR*
        [DllImport("user32.dll", EntryPoint = "CharPrevW")]
        [return: MarshalAs(UnmanagedType.LPWStr)]
        public static extern string CharPrevW(
            [In] [MarshalAs(UnmanagedType.LPWStr)] string lpszStart, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpszCurrent);

        /// Return Type: LPSTR->CHAR*
        ///lpszStart: LPCSTR->CHAR*
        ///lpszCurrent: LPCSTR->CHAR*
        [DllImport("user32.dll", EntryPoint = "CharPrevA")]
        [return: MarshalAs(UnmanagedType.LPStr)]
        public static extern string CharPrevA([In] [MarshalAs(UnmanagedType.LPStr)] string lpszStart, [In] [MarshalAs(UnmanagedType.LPStr)] string lpszCurrent);

        /// Return Type: LPWSTR->WCHAR*
        ///lpsz: LPCWSTR->WCHAR*
        [DllImport("user32.dll", EntryPoint = "CharNextW")]
        [return: MarshalAs(UnmanagedType.LPWStr)]
        public static extern string CharNextW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpsz);

        /// Return Type: LPSTR->CHAR*
        ///lpsz: LPCSTR->CHAR*
        [DllImport("user32.dll", EntryPoint = "CharNextA")]
        [return: MarshalAs(UnmanagedType.LPStr)]
        public static extern string CharNextA([In] [MarshalAs(UnmanagedType.LPStr)] string lpsz);

        /// Return Type: BOOL->int
        ///hWndMain: HWND->HWND__*
        ///lpszHelp: LPCWSTR->WCHAR*
        ///uCommand: UINT->unsigned int
        ///dwData: ULONG_PTR->unsigned int
        [DllImport("user32.dll", EntryPoint = "WinHelpW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WinHelpW([In] IntPtr hWndMain, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpszHelp, uint uCommand, uint dwData);

        /// Return Type: BOOL->int
        ///hWndMain: HWND->HWND__*
        ///lpszHelp: LPCSTR->CHAR*
        ///uCommand: UINT->unsigned int
        ///dwData: ULONG_PTR->unsigned int
        [DllImport("user32.dll", EntryPoint = "WinHelpA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WinHelpA([In] IntPtr hWndMain, [In] [MarshalAs(UnmanagedType.LPStr)] string lpszHelp, uint uCommand, uint dwData);

        /// Return Type: UINT_PTR->unsigned int
        ///hWnd: HWND->HWND__*
        ///nIDEvent: UINT_PTR->unsigned int
        ///uElapse: UINT->unsigned int
        ///lpTimerFunc: TIMERPROC
        [DllImport("user32.dll", EntryPoint = "SetTimer")]
        [return: MarshalAs(UnmanagedType.SysUInt)]
        public static extern uint SetTimer([In] IntPtr hWnd, [MarshalAs(UnmanagedType.SysUInt)] uint nIDEvent, uint uElapse, TIMERPROC lpTimerFunc);

        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///lpString: LPCWSTR->WCHAR*
        ///hData: HANDLE->void*
        [DllImport("user32.dll", EntryPoint = "SetPropW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetPropW([In] IntPtr hWnd, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpString, [In] IntPtr hData);

        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///lpString: LPCSTR->CHAR*
        ///hData: HANDLE->void*
        [DllImport("user32.dll", EntryPoint = "SetPropA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetPropA([In] IntPtr hWnd, [In] [MarshalAs(UnmanagedType.LPStr)] string lpString, [In] IntPtr hData);

        /// Return Type: HWND->HWND__*
        ///hWnd: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "SetFocus")]
        public static extern IntPtr SetFocus([In] IntPtr hWnd);

        /// Return Type: BOOL->int
        ///hDC: HDC->HDC__*
        ///dx: int
        ///dy: int
        ///lprcScroll: RECT*
        ///lprcClip: RECT*
        ///hrgnUpdate: HRGN->HRGN__*
        ///lprcUpdate: LPRECT->tagRECT*
        [DllImport("user32.dll", EntryPoint = "ScrollDC")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ScrollDC(
            [In] IntPtr hDC, int dx, int dy, [In] IntPtr lprcScroll, [In] IntPtr lprcClip, [In] IntPtr hrgnUpdate, IntPtr lprcUpdate);

        /// Return Type: BOOL->int
        ///lprc: RECT*
        ///pt: POINT->tagPOINT
        [DllImport("user32.dll", EntryPoint = "PtInRect")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PtInRect([In] ref RECT lprc, Point pt);

        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "OpenIcon")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool OpenIcon([In] IntPtr hWnd);

        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "IsZoomed")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsZoomed([In] IntPtr hWnd);

        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "IsWindow")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsWindow([In] IntPtr hWnd);

        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "IsIconic")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsIconic([In] IntPtr hWnd);

        /// Return Type: HANDLE->void*
        ///hWnd: HWND->HWND__*
        ///lpString: LPCWSTR->WCHAR*
        [DllImport("user32.dll", EntryPoint = "GetPropW")]
        public static extern IntPtr GetPropW([In] IntPtr hWnd, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpString);

        /// Return Type: HANDLE->void*
        ///hWnd: HWND->HWND__*
        ///lpString: LPCSTR->CHAR*
        [DllImport("user32.dll", EntryPoint = "GetPropA")]
        public static extern IntPtr GetPropA([In] IntPtr hWnd, [In] [MarshalAs(UnmanagedType.LPStr)] string lpString);

        /// Return Type: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "GetFocus")]
        public static extern IntPtr GetFocus();

        /// Return Type: int
        ///hDC: HDC->HDC__*
        ///lprc: RECT*
        ///hbr: HBRUSH->HBRUSH__*
        [DllImport("user32.dll", EntryPoint = "FillRect")]
        public static extern int FillRect([In] IntPtr hDC, [In] ref RECT lprc, [In] IntPtr hbr);

        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///lpPaint: PAINTSTRUCT*
        [DllImport("user32.dll", EntryPoint = "EndPaint")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EndPaint([In] IntPtr hWnd, [In] ref PAINTSTRUCT lpPaint);

        /// Return Type: BOOL->int
        ///hDC: HDC->HDC__*
        ///X: int
        ///Y: int
        ///hIcon: HICON->HICON__*
        [DllImport("user32.dll", EntryPoint = "DrawIcon")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DrawIcon([In] IntPtr hDC, int X, int Y, [In] IntPtr hIcon);

        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///qrc: LPRECT->tagRECT*
        ///edge: UINT->unsigned int
        ///grfFlags: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "DrawEdge")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DrawEdge([In] IntPtr hdc, ref RECT qrc, uint edge, uint grfFlags);

        /// Return Type: BOOL->int
        ///lprcDst: LPRECT->tagRECT*
        ///lprcSrc: RECT*
        [DllImport("user32.dll", EntryPoint = "CopyRect")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CopyRect([Out] out RECT lprcDst, [In] ref RECT lprcSrc);

        /// Return Type: HICON->HICON__*
        ///hIcon: HICON->HICON__*
        [DllImport("user32.dll", EntryPoint = "CopyIcon")]
        public static extern IntPtr CopyIcon([In] IntPtr hIcon);

        /// Return Type: BOOL->int
        [DllImport("user32.dll", EntryPoint = "AnyPopup")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AnyPopup();

        /// Return Type: int
        ///uVirtKey: UINT->unsigned int
        ///uScanCode: UINT->unsigned int
        ///lpKeyState: BYTE*
        ///lpChar: LPWORD->WORD*
        ///uFlags: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "ToAscii")]
        public static extern int ToAscii(uint uVirtKey, uint uScanCode, [In] IntPtr lpKeyState, [Out] out ushort lpChar, uint uFlags);

        /// Return Type: BOOL->int
        ///lprc: LPRECT->tagRECT*
        ///xLeft: int
        ///yTop: int
        ///xRight: int
        ///yBottom: int
        [DllImport("user32.dll", EntryPoint = "SetRect")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetRect([Out] out RECT lprc, int xLeft, int yTop, int xRight, int yBottom);

        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///hMenu: HMENU->HMENU__*
        [DllImport("user32.dll", EntryPoint = "SetMenu")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetMenu([In] IntPtr hWnd, [In] IntPtr hMenu);

        /// Return Type: BOOL->int
        ///hWndParent: HWND->HWND__*
        ///hWnd: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "IsChild")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsChild([In] IntPtr hWndParent, [In] IntPtr hWnd);

        /// Return Type: HMENU->HMENU__*
        ///hWnd: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "GetMenu")]
        public static extern IntPtr GetMenu([In] IntPtr hWnd);

        /// Return Type: HDC->HDC__*
        ///hWnd: HWND->HWND__*
        ///hrgnClip: HRGN->HRGN__*
        ///flags: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "GetDCEx")]
        public static extern IntPtr GetDCEx([In] IntPtr hWnd, [In] IntPtr hrgnClip, uint flags);

        /// Return Type: BOOL->int
        [DllImport("user32.dll", EntryPoint = "EndMenu")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EndMenu();

        /// Return Type: BOOL->int
        ///hMenu: HMENU->HMENU__*
        [DllImport("user32.dll", EntryPoint = "IsMenu")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsMenu([In] IntPtr hMenu);

        /// Return Type: HDC->HDC__*
        ///hWnd: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "GetDC")]
        public static extern IntPtr GetDC([In] IntPtr hWnd);
    }

    // ReSharper restore InconsistentNaming
}