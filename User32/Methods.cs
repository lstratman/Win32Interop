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

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate int NAMEENUMPROC(StringBuilder param0, IntPtr param1);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate void MSGBOXCALLBACK(ref HELPINFO lpHelpInfo);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate int DLGPROC(IntPtr param0, uint param1, IntPtr param2, IntPtr param3);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate void SENDASYNCPROC(IntPtr param0, uint param1, uint param2, IntPtr param3);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate int MONITORENUMPROC(IntPtr param0, IntPtr param1, ref RECT param2, IntPtr param3);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate int WNDENUMPROC(IntPtr param0, IntPtr param1);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate IntPtr HOOKPROC(int code, IntPtr wParam, IntPtr lParam);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate void WINEVENTPROC(IntPtr hWinEventHook, uint @event, IntPtr hwnd, int idObject, int idChild, uint idEventThread, uint dwmsEventTime);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate int WNDPROC(IntPtr param0, uint param1, IntPtr param2, IntPtr param3);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate IntPtr PFNCALLBACK(uint wType, uint wFmt, IntPtr hConv, IntPtr hsz1, IntPtr hsz2, IntPtr hData, uint dwData1, uint dwData2);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate int PROPENUMPROCEX(IntPtr param0, StringBuilder param1, IntPtr param2, uint param3);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate int GRAYSTRINGPROC(IntPtr param0, IntPtr param1, int param2);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate int PROPENUMPROC(IntPtr param0, [In] string param1, IntPtr param2);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate int DRAWSTATEPROC(IntPtr hdc, IntPtr lData, IntPtr wData, int cx, int cy);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate void TIMERPROC(IntPtr param0, uint param1, IntPtr param2, uint param3);

	public class User32
	{
		[DllImport("user32.dll", EntryPoint = "DisableProcessWindowsGhosting")]
		public static extern void DisableProcessWindowsGhosting();

		[DllImport("user32.dll", EntryPoint = "UnregisterDeviceNotification")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool UnregisterDeviceNotification([In] IntPtr Handle);

		[DllImport("user32.dll", EntryPoint = "GetRegisteredRawInputDevices")]
		public static extern uint GetRegisteredRawInputDevices(IntPtr pRawInputDevices, ref uint puiNumDevices, uint cbSize);

		[DllImport("user32.dll", EntryPoint = "RegisterDeviceNotification")]
		public static extern IntPtr RegisterDeviceNotification([In] IntPtr hRecipient, [In] IntPtr NotificationFilter, DEVICE_NOTIFY Flags);

		[DllImport("user32.dll", EntryPoint = "MsgWaitForMultipleObjectsEx")]
		public static extern uint MsgWaitForMultipleObjectsEx(uint nCount, ref IntPtr pHandles, uint dwMilliseconds, QS dwWakeMask, MWMO dwFlags);

		[DllImport("user32.dll", EntryPoint = "LookupIconIdFromDirectoryEx")]
		public static extern int LookupIconIdFromDirectoryEx(
			[In] ref byte presbits, [MarshalAs(UnmanagedType.Bool)] bool fIcon, int cxDesired, int cyDesired, LR Flags);

		[DllImport("user32.dll", EntryPoint = "SetLayeredWindowAttributes")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetLayeredWindowAttributes([In] IntPtr hwnd, uint crKey, byte bAlpha, LWA dwFlags);

		[DllImport("user32.dll", EntryPoint = "IsClipboardFormatAvailable")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool IsClipboardFormatAvailable(uint format);

		[DllImport("user32.dll", EntryPoint = "ImpersonateDdeClientWindow")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool ImpersonateDdeClientWindow(IntPtr hWndClient, IntPtr hWndServer);

		[DllImport("user32.dll", EntryPoint = "GetPriorityClipboardFormat")]
		public static extern int GetPriorityClipboardFormat(
			[MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U4, SizeParamIndex = 1)] uint[] paFormatPriorityList, int cFormats);

		[DllImport("user32.dll", EntryPoint = "GetMenuCheckMarkDimensions")]
		public static extern int GetMenuCheckMarkDimensions();

		[DllImport("user32.dll", EntryPoint = "GetLayeredWindowAttributes")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetLayeredWindowAttributes([In] IntPtr hwnd, IntPtr pcrKey, IntPtr pbAlpha, out LWA pdwFlags);

		[DllImport("user32.dll", EntryPoint = "GetClipboardSequenceNumber")]
		public static extern uint GetClipboardSequenceNumber();

		[DllImport("user32.dll", EntryPoint = "CreateDialogIndirectParam")]
		public static extern IntPtr CreateDialogIndirectParam(
			[In] IntPtr hInstance, [In] ref DLGTEMPLATE lpTemplate, [In] IntPtr hWndParent, DLGPROC lpDialogFunc,
			[MarshalAs(UnmanagedType.SysInt)] int dwInitParam);

		[DllImport("user32.dll", EntryPoint = "SetUserObjectInformation")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetUserObjectInformation([In] IntPtr hObj, int nIndex, [In] IntPtr pvInfo, uint nLength);

		[DllImport("user32.dll", EntryPoint = "MsgWaitForMultipleObjects")]
		public static extern uint MsgWaitForMultipleObjects(
			uint nCount, ref IntPtr pHandles, [MarshalAs(UnmanagedType.Bool)] bool fWaitAll, uint dwMilliseconds, uint dwWakeMask);

		[DllImport("user32.dll", EntryPoint = "LookupIconIdFromDirectory")]
		public static extern int LookupIconIdFromDirectory([In] ref byte presbits, [MarshalAs(UnmanagedType.Bool)] bool fIcon);

		[DllImport("user32.dll", EntryPoint = "GetUserObjectInformation")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetUserObjectInformation([In] IntPtr hObj, int nIndex, IntPtr pvInfo, uint nLength, IntPtr lpnLengthNeeded);

		[DllImport("user32.dll", EntryPoint = "DeregisterShellHookWindow")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool DeregisterShellHookWindow([In] IntPtr hwnd);

		[DllImport("user32.dll", EntryPoint = "BroadcastSystemMessageEx")]
		public static extern int BroadcastSystemMessageEx(
			BSF flags, IntPtr lpInfo, uint Msg, [MarshalAs(UnmanagedType.SysUInt)] uint wParam, [MarshalAs(UnmanagedType.SysInt)] int lParam, IntPtr pbsmInfo);

		[DllImport("user32.dll", EntryPoint = "RegisterClipboardFormat")]
		public static extern uint RegisterClipboardFormat([In] string lpszFormat);

		[DllImport("user32.dll", EntryPoint = "RealChildWindowFromPoint")]
		public static extern IntPtr RealChildWindowFromPoint([In] IntPtr hwndParent, POINT ptParentClientCoords);

		[DllImport("user32.dll", EntryPoint = "GetWindowThreadProcessId")]
		public static extern uint GetWindowThreadProcessId([In] IntPtr hWnd, IntPtr lpdwProcessId);

		[DllImport("user32.dll", EntryPoint = "GetWindowModuleFileName")]
		public static extern uint GetWindowModuleFileName(
			[In] IntPtr hwnd, [Out] StringBuilder pszFileName, uint cchFileNameMax);

		[DllImport("user32.dll", EntryPoint = "CreateIconFromResourceEx")]
		public static extern IntPtr CreateIconFromResourceEx(
			[In] ref byte presbits, uint dwResSize, [MarshalAs(UnmanagedType.Bool)] bool fIcon, uint dwVer, int cxDesired, int cyDesired, LR Flags);

		[DllImport("user32.dll", EntryPoint = "ChangeDisplaySettingsEx")]
		public static extern int ChangeDisplaySettingsEx(
			[In] string lpszDeviceName, [In] IntPtr lpDevMode, IntPtr hwnd, CDS dwflags, [In] IntPtr lParam);

		[DllImport("user32.dll", EntryPoint = "AllowSetForegroundWindow")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool AllowSetForegroundWindow(uint dwProcessId);

		[DllImport("user32.dll", EntryPoint = "SetProcessWindowStation")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetProcessWindowStation([In] IntPtr hWinSta);

		[DllImport("user32.dll", EntryPoint = "SetProcessDefaultLayout")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetProcessDefaultLayout(uint dwDefaultLayout);

		[DllImport("user32.dll", EntryPoint = "RegisterShellHookWindow")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool RegisterShellHookWindow([In] IntPtr hwnd);

		[DllImport("user32.dll", EntryPoint = "RegisterRawInputDevices")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool RegisterRawInputDevices(
			[MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 1)] RAWINPUTDEVICE[] pRawInputDevices, uint uiNumDevices,
			uint cbSize);

		[DllImport("user32.dll", EntryPoint = "LockSetForegroundWindow")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool LockSetForegroundWindow(uint uLockCode);

		[DllImport("user32.dll", EntryPoint = "IsWinEventHookInstalled")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool IsWinEventHookInstalled(uint @event);

		[DllImport("user32.dll", EntryPoint = "GetProcessWindowStation")]
		public static extern IntPtr GetProcessWindowStation();

		[DllImport("user32.dll", EntryPoint = "GetProcessDefaultLayout")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetProcessDefaultLayout([Out] out uint pdwDefaultLayout);

		[DllImport("user32.dll", EntryPoint = "GetClipboardFormatName")]
		public static extern int GetClipboardFormatName(uint format, [Out] StringBuilder lpszFormatName, int cchMaxCount);

		[DllImport("user32.dll", EntryPoint = "DlgDirSelectComboBoxEx")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool DlgDirSelectComboBoxEx([In] IntPtr hwndDlg, [Out] StringBuilder lpString, int cchOut, int idComboBox);

		[DllImport("user32.dll", EntryPoint = "DialogBoxIndirectParam")]
		public static extern int DialogBoxIndirectParam(
			[In] IntPtr hInstance, [In] ref DLGTEMPLATE hDialogTemplate, [In] IntPtr hWndParent, DLGPROC lpDialogFunc,
			[MarshalAs(UnmanagedType.SysInt)] int dwInitParam);

		[DllImport("user32.dll", EntryPoint = "DestroyAcceleratorTable")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool DestroyAcceleratorTable([In] IntPtr hAccel);

		[DllImport("user32.dll", EntryPoint = "CreateAcceleratorTable")]
		public static extern IntPtr CreateAcceleratorTable(
			[MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 1)] ACCEL[] paccel, int cAccel);

		[DllImport("user32.dll", EntryPoint = "BroadcastSystemMessage")]
		public static extern int BroadcastSystemMessage(
			BSF flags, IntPtr lpInfo, uint Msg, [MarshalAs(UnmanagedType.SysUInt)] uint wParam, [MarshalAs(UnmanagedType.SysInt)] int lParam);

		[DllImport("user32.dll", EntryPoint = "SetWindowContextHelpId")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetWindowContextHelpId([In] IntPtr param0, uint param1);

		[DllImport("user32.dll", EntryPoint = "RegisterWindowMessage")]
		public static extern uint RegisterWindowMessage([In] string lpString);

		[DllImport("user32.dll", EntryPoint = "GetWindowContextHelpId")]
		public static extern uint GetWindowContextHelpId([In] IntPtr param0);

		[DllImport("user32.dll", EntryPoint = "GetRawInputDeviceInfo")]
		public static extern uint GetRawInputDeviceInfo([In] IntPtr hDevice, uint uiCommand, IntPtr pData, ref uint pcbSize);

		[DllImport("user32.dll", EntryPoint = "GetOpenClipboardWindow")]
		public static extern IntPtr GetOpenClipboardWindow();

		[DllImport("user32.dll", EntryPoint = "GetKeyboardLayoutName")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetKeyboardLayoutName([Out] StringBuilder pwszKLID);

		[DllImport("user32.dll", EntryPoint = "EnumDisplaySettingsEx")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool EnumDisplaySettingsEx(
			[In] [MarshalAs(UnmanagedType.LPWStr)] string lpszDeviceName, uint iModeNum, [Out] out DEVMODE lpDevMode, EDS dwFlags);

		[DllImport("user32.dll", EntryPoint = "DdeSetQualityOfService")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool DdeSetQualityOfService(IntPtr hwndClient, ref SECURITY_QUALITY_OF_SERVICE pqosNew, ref SECURITY_QUALITY_OF_SERVICE pqosPrev);

		[DllImport("user32.dll", EntryPoint = "DdeCreateStringHandle")]
		public static extern IntPtr DdeCreateStringHandle(uint idInst, [In] string psz, int iCodePage);

		[DllImport("user32.dll", EntryPoint = "CreateIconFromResource")]
		public static extern IntPtr CreateIconFromResource([In] ref byte presbits, uint dwResSize, [MarshalAs(UnmanagedType.Bool)] bool fIcon, uint dwVer);

		[DllImport("user32.dll", EntryPoint = "ChildWindowFromPointEx")]
		public static extern IntPtr ChildWindowFromPointEx([In] IntPtr hwnd, POINT pt, CWP flags);

		[DllImport("user32.dll", EntryPoint = "ChangeDisplaySettings")]
		public static extern int ChangeDisplaySettings([In] IntPtr lpDevMode, CDS dwFlags);

		[DllImport("user32.dll", EntryPoint = "ActivateKeyboardLayout")]
		public static extern IntPtr ActivateKeyboardLayout([In] IntPtr hkl, KLF Flags);

		[DllImport("user32.dll", EntryPoint = "UserHandleGrantAccess")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool UserHandleGrantAccess([In] IntPtr hUserHandle, [In] IntPtr hJob, [MarshalAs(UnmanagedType.Bool)] bool bGrant);

		[DllImport("user32.dll", EntryPoint = "TranslateAccelerator")]
		public static extern int TranslateAccelerator([In] IntPtr hWnd, [In] IntPtr hAccTable, [In] ref MSG lpMsg);

		[DllImport("user32.dll", EntryPoint = "SystemParametersInfo")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SystemParametersInfo(uint uiAction, uint uiParam, IntPtr pvParam, uint fWinIni);

		[DllImport("user32.dll", EntryPoint = "SetUserObjectSecurity")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetUserObjectSecurity([In] IntPtr hObj, [In] ref uint pSIRequested, [In] IntPtr pSID);

		[DllImport("user32.dll", EntryPoint = "InternalGetWindowText")]
		public static extern int InternalGetWindowText([In] IntPtr hWnd, [Out] [MarshalAs(UnmanagedType.LPWStr)] StringBuilder pString, int cchMaxCount);

		[DllImport("user32.dll", EntryPoint = "GetUserObjectSecurity")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetUserObjectSecurity([In] IntPtr hObj, [In] ref uint pSIRequested, IntPtr pSID, uint nLength, [Out] out uint lpnLengthNeeded);

		[DllImport("user32.dll", EntryPoint = "GetRawInputDeviceList")]
		public static extern uint GetRawInputDeviceList(IntPtr pRawInputDeviceList, ref uint puiNumDevices, uint cbSize);

		[DllImport("user32.dll", EntryPoint = "GetKeyboardLayoutList")]
		public static extern int GetKeyboardLayoutList(int nBuff, ref IntPtr lpList);

		[DllImport("user32.dll", EntryPoint = "DdeAbandonTransaction")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool DdeAbandonTransaction(uint idInst, IntPtr hConv, uint idTransaction);

		[DllImport("user32.dll", EntryPoint = "CountClipboardFormats")]
		public static extern int CountClipboardFormats();

		[DllImport("user32.dll", EntryPoint = "CopyAcceleratorTable")]
		public static extern int CopyAcceleratorTable([In] IntPtr hAccelSrc, IntPtr lpAccelDst, int cAccelEntries);

		[DllImport("user32.dll", EntryPoint = "UnloadKeyboardLayout")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool UnloadKeyboardLayout([In] IntPtr hkl);

		[DllImport("user32.dll", EntryPoint = "TranslateMDISysAccel")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool TranslateMDISysAccel([In] IntPtr hWndClient, [In] ref MSG lpMsg);

		[DllImport("user32.dll", EntryPoint = "SetMenuContextHelpId")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetMenuContextHelpId([In] IntPtr param0, uint param1);

		[DllImport("user32.dll", EntryPoint = "SendMessageCallback")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SendMessageCallback(
			[In] IntPtr hWnd, uint Msg, [MarshalAs(UnmanagedType.SysUInt)] uint wParam, [MarshalAs(UnmanagedType.SysInt)] int lParam,
			SENDASYNCPROC lpResultCallBack, uint dwData);

		[DllImport("user32.dll", EntryPoint = "PrivateExtractIcons")]
		public static extern uint PrivateExtractIcons(
			[In] string szFileName, int nIconIndex, int cxIcon, int cyIcon, ref IntPtr phicon, IntPtr piconid, uint nIcons, LR flags);

		[DllImport("user32.dll", EntryPoint = "GetWindowTextLength")]
		public static extern int GetWindowTextLength([In] IntPtr hWnd);

		[DllImport("user32.dll", EntryPoint = "GetTabbedTextExtent")]
		public static extern uint GetTabbedTextExtent([In] IntPtr hdc, [In] string lpString, int chCount, int nTabPositions, [In] IntPtr lpnTabStopPositions);

		[DllImport("user32.dll", EntryPoint = "GetMouseMovePointsEx")]
		public static extern int GetMouseMovePointsEx(uint cbSize, [In] ref MOUSEMOVEPOINT lppt, IntPtr lpptBuf, int nBufPoints, uint resolution);

		[DllImport("user32.dll", EntryPoint = "GetMenuContextHelpId")]
		public static extern uint GetMenuContextHelpId([In] IntPtr param0);

		[DllImport("user32.dll", EntryPoint = "EnumDisplaySettings")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool EnumDisplaySettings(
			[In] [MarshalAs(UnmanagedType.LPWStr)] string lpszDeviceName, uint iModeNum, [Out] out DEVMODE lpDevMode);

		[DllImport("user32.dll", EntryPoint = "EnumClipboardFormats")]
		public static extern uint EnumClipboardFormats(uint format);

		[DllImport("user32.dll", EntryPoint = "DdeImpersonateClient")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool DdeImpersonateClient(IntPtr hConv);

		[DllImport("user32.dll", EntryPoint = "DdeClientTransaction")]
		public static extern IntPtr DdeClientTransaction(
			ref byte pData, uint cbData, IntPtr hConv, IntPtr hszItem, uint wFmt, uint wType, uint dwTimeout, ref uint pdwResult);

		[DllImport("user32.dll", EntryPoint = "CreateWindowStation")]
		public static extern IntPtr CreateWindowStation([In] string lpwinsta, CWF dwFlags, uint dwDesiredAccess, [In] IntPtr lpsa);

		[DllImport("user32.dll", EntryPoint = "ChildWindowFromPoint")]
		public static extern IntPtr ChildWindowFromPoint([In] IntPtr hWndParent, POINT Point);

		[DllImport("user32.dll", EntryPoint = "ChangeClipboardChain")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool ChangeClipboardChain([In] IntPtr hWndRemove, [In] IntPtr hWndNewNext);

		[DllImport("user32.dll", EntryPoint = "ArrangeIconicWindows")]
		public static extern uint ArrangeIconicWindows([In] IntPtr hWnd);

		[DllImport("user32.dll", EntryPoint = "UpdateLayeredWindow")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool UpdateLayeredWindow(
			[In] IntPtr hWnd, [In] IntPtr hdcDst, ref POINT pptDst, ref SIZE psize, [In] IntPtr hdcSrc, ref POINT pptSrc, uint crKey, ref BLENDFUNCTION pblend,
			ULW dwFlags);

		[DllImport("user32.dll", EntryPoint = "UnhookWindowsHookEx")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool UnhookWindowsHookEx([In] IntPtr hhk);

		[DllImport("user32.dll", EntryPoint = "SetMessageExtraInfo")]
		[return: MarshalAs(UnmanagedType.SysInt)]
		public static extern int SetMessageExtraInfo([MarshalAs(UnmanagedType.SysInt)] int lParam);

		[DllImport("user32.dll", EntryPoint = "SetForegroundWindow")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetForegroundWindow([In] IntPtr hWnd);

		[DllImport("user32.dll", EntryPoint = "SendMessageTimeout")]
		[return: MarshalAs(UnmanagedType.SysInt)]
		public static extern int SendMessageTimeout(
			[In] IntPtr hWnd, uint Msg, [MarshalAs(UnmanagedType.SysUInt)] uint wParam, [MarshalAs(UnmanagedType.SysInt)] int lParam, SMTO fuFlags,
			uint uTimeout, IntPtr lpdwResult);

		[DllImport("user32.dll", EntryPoint = "SendDlgItemMessage")]
		[return: MarshalAs(UnmanagedType.SysInt)]
		public static extern int SendDlgItemMessage(
			[In] IntPtr hDlg, int nIDDlgItem, uint Msg, [MarshalAs(UnmanagedType.SysUInt)] uint wParam, [MarshalAs(UnmanagedType.SysInt)] int lParam);

		[DllImport("user32.dll", EntryPoint = "RealGetWindowClass")]
		public static extern uint RealGetWindowClass([In] IntPtr hwnd, [Out] StringBuilder ptszClassName, uint cchClassNameMax);

		[DllImport("user32.dll", EntryPoint = "MessageBoxIndirect")]
		public static extern int MessageBoxIndirect([In] ref MSGBOXPARAMS lpmbp);

		[DllImport("user32.dll", EntryPoint = "LoadKeyboardLayout")]
		public static extern IntPtr LoadKeyboardLayout([In] string pwszKLID, KLF Flags);

		[DllImport("user32.dll", EntryPoint = "LoadCursorFromFile")]
		public static extern IntPtr LoadCursorFromFile([In] string lpFileName);

		[DllImport("user32.dll", EntryPoint = "IsCharAlphaNumeric")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool IsCharAlphaNumeric(char ch);

		[DllImport("user32.dll", EntryPoint = "GetNextDlgGroupItem")]
		public static extern IntPtr GetNextDlgGroupItem([In] IntPtr hDlg, [In] IntPtr hCtl, [MarshalAs(UnmanagedType.Bool)] bool bPrevious);

		[DllImport("user32.dll", EntryPoint = "GetMessageExtraInfo")]
		[return: MarshalAs(UnmanagedType.SysInt)]
		public static extern int GetMessageExtraInfo();

		[DllImport("user32.dll", EntryPoint = "GetForegroundWindow")]
		public static extern IntPtr GetForegroundWindow();

		[DllImport("user32.dll", EntryPoint = "EnumWindowStations")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool EnumWindowStations(NAMEENUMPROC lpEnumFunc, [MarshalAs(UnmanagedType.SysInt)] int lParam);

		[DllImport("user32.dll", EntryPoint = "EnumDisplayMonitors")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool EnumDisplayMonitors(
			[In] IntPtr hdc, [In] IntPtr lprcClip, MONITORENUMPROC lpfnEnum, [MarshalAs(UnmanagedType.SysInt)] int dwData);

		[DllImport("user32.dll", EntryPoint = "EnumDisplayDevices")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool EnumDisplayDevices(
			[In] [MarshalAs(UnmanagedType.LPTStr)] string lpDevice, uint iDevNum, ref DISPLAY_DEVICE lpDisplayDevice, EDD dwFlags);

		[DllImport("user32.dll", EntryPoint = "DlgDirListComboBox")]
		public static extern int DlgDirListComboBox([In] IntPtr hDlg, IntPtr lpPathSpec, int nIDComboBox, int nIDStaticPath, uint uFiletype);

		[DllImport("user32.dll", EntryPoint = "DdeKeepStringHandle")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool DdeKeepStringHandle(uint idInst, IntPtr hsz);

		[DllImport("user32.dll", EntryPoint = "DdeFreeStringHandle")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool DdeFreeStringHandle(uint idInst, IntPtr hsz);

		[DllImport("user32.dll", EntryPoint = "DdeCreateDataHandle")]
		public static extern IntPtr DdeCreateDataHandle(uint idInst, ref byte pSrc, uint cb, uint cbOff, IntPtr hszItem, uint wFmt, uint afCmd);

		[DllImport("user32.dll", EntryPoint = "DdeCmpStringHandles")]
		public static extern int DdeCmpStringHandles(IntPtr hsz1, IntPtr hsz2);

		[DllImport("user32.dll", EntryPoint = "BeginDeferWindowPos")]
		public static extern IntPtr BeginDeferWindowPos(int nNumWindows);

		[DllImport("user32.dll", EntryPoint = "SwitchToThisWindow")]
		public static extern void SwitchToThisWindow([In] IntPtr hwnd, [MarshalAs(UnmanagedType.Bool)] bool fUnknown);

		[DllImport("user32.dll", EntryPoint = "SetWindowPlacement")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetWindowPlacement([In] IntPtr hWnd, [In] ref WINDOWPLACEMENT lpwndpl);

		[DllImport("user32.dll", EntryPoint = "SetMenuItemBitmaps")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetMenuItemBitmaps([In] IntPtr hMenu, uint uPosition, MF uFlags, [In] IntPtr hBitmapUnchecked, [In] IntPtr hBitmapChecked);

		[DllImport("user32.dll", EntryPoint = "SetMenuDefaultItem")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetMenuDefaultItem([In] IntPtr hMenu, uint uItem, uint fByPos);

		[DllImport("user32.dll", EntryPoint = "SetDoubleClickTime")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetDoubleClickTime(uint param0);

		[DllImport("user32.dll", EntryPoint = "SetDebugErrorLevel")]
		public static extern void SetDebugErrorLevel(uint dwLevel);

		[DllImport("user32.dll", EntryPoint = "SetClipboardViewer")]
		public static extern IntPtr SetClipboardViewer([In] IntPtr hWndNewViewer);

		[DllImport("user32.dll", EntryPoint = "SendNotifyMessage")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SendNotifyMessage(
			[In] IntPtr hWnd, uint Msg, [MarshalAs(UnmanagedType.SysUInt)] uint wParam, [MarshalAs(UnmanagedType.SysInt)] int lParam);

		[DllImport("user32.dll", EntryPoint = "PostThreadMessage")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool PostThreadMessage(
			uint idThread, uint Msg, [MarshalAs(UnmanagedType.SysUInt)] uint wParam, [MarshalAs(UnmanagedType.SysInt)] int lParam);

		[DllImport("user32.dll", EntryPoint = "OpenWindowStation")]
		public static extern IntPtr OpenWindowStation([In] string lpszWinSta, [MarshalAs(UnmanagedType.Bool)] bool fInherit, uint dwDesiredAccess);

		[DllImport("user32.dll", EntryPoint = "IsDlgButtonChecked")]
		public static extern uint IsDlgButtonChecked([In] IntPtr hDlg, int nIDButton);

		[DllImport("user32.dll", EntryPoint = "GetWindowPlacement")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetWindowPlacement([In] IntPtr hWnd, ref WINDOWPLACEMENT lpwndpl);

		[DllImport("user32.dll", EntryPoint = "GetMenuDefaultItem")]
		public static extern uint GetMenuDefaultItem([In] IntPtr hMenu, uint fByPos, GMDI gmdiFlags);

		[DllImport("user32.dll", EntryPoint = "GetLastActivePopup")]
		public static extern IntPtr GetLastActivePopup([In] IntPtr hWnd);

		[DllImport("user32.dll", EntryPoint = "GetDoubleClickTime")]
		public static extern uint GetDoubleClickTime();

		[DllImport("user32.dll", EntryPoint = "GetDialogBaseUnits")]
		public static extern int GetDialogBaseUnits();

		[DllImport("user32.dll", EntryPoint = "GetClipboardViewer")]
		public static extern IntPtr GetClipboardViewer();

		[DllImport("user32.dll", EntryPoint = "EnumDesktopWindows")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool EnumDesktopWindows([In] IntPtr hDesktop, WNDENUMPROC lpfn, [MarshalAs(UnmanagedType.SysInt)] int lParam);

		[DllImport("user32.dll", EntryPoint = "DdeQueryNextServer")]
		public static extern IntPtr DdeQueryNextServer(IntPtr hConvList, IntPtr hConvPrev);

		[DllImport("user32.dll", EntryPoint = "CreateIconIndirect")]
		public static extern IntPtr CreateIconIndirect([In] ref ICONINFO piconinfo);

		[DllImport("user32.dll", EntryPoint = "CreateDialogParam")]
		public static extern IntPtr CreateDialogParam(
			[In] IntPtr hInstance, [In] string lpTemplateName, [In] IntPtr hWndParent, DLGPROC lpDialogFunc, [MarshalAs(UnmanagedType.SysInt)] int dwInitParam);

		[DllImport("user32.dll", EntryPoint = "CloseWindowStation")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool CloseWindowStation([In] IntPtr hWinSta);

		[DllImport("user32.dll", EntryPoint = "CheckMenuRadioItem")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool CheckMenuRadioItem([In] IntPtr hmenu, uint first, uint last, uint check, MF flags);

		[DllImport("user32.dll", EntryPoint = "AdjustWindowRectEx")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool AdjustWindowRectEx(ref RECT lpRect, WS dwStyle, [MarshalAs(UnmanagedType.Bool)] bool bMenu, WS_EX dwExStyle);

		[DllImport("user32.dll", EntryPoint = "UnhookWindowsHook")]
		[return: MarshalAs(UnmanagedType.Bool)]
		protected static extern bool UnhookWindowsHookInternal(WH nCode, HOOKPROC pfnFilterProc);

		public static bool UnhookWindowsHook(WH nCode, HOOKPROC pfnFilterProc)
		{
			if (nCode == WH.WH_GETMESSAGE)
				return UninitializeHook(nCode);

			return UnhookWindowsHookInternal(nCode, pfnFilterProc);
		}

		[DllImport("user32.dll", EntryPoint = "SetWindowsHookEx")]
		protected static extern IntPtr SetWindowsHookExInternal(WH idHook, HOOKPROC lpfn, [In] IntPtr hmod, uint dwThreadId);

		[DllImport("SystemHookCore.dll", EntryPoint = "SetUserHookCallback")]
		protected static extern IntPtr SetUserHookCallback(WH hookID, HOOKPROC lpfn, uint threadId);

		[DllImport("SystemHookCore.dll", EntryPoint = "UninitializeHook")]
		protected static extern bool UninitializeHook(WH hookType);

		public static IntPtr SetWindowsHookEx(WH idHook, HOOKPROC lpfn, IntPtr hmod, uint dwThreadId)
		{
			if (idHook == WH.WH_GETMESSAGE)
				return SetUserHookCallback(idHook, lpfn, dwThreadId);

			else
				return SetWindowsHookExInternal(idHook, lpfn, hmod, dwThreadId);
		}

		[DllImport("user32.dll", EntryPoint = "SetCaretBlinkTime")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetCaretBlinkTime(uint uMSeconds);

		[DllImport("user32.dll", EntryPoint = "MonitorFromWindow")]
		public static extern IntPtr MonitorFromWindow([In] IntPtr hwnd, MONITOR dwFlags);

		[DllImport("user32.dll", EntryPoint = "MenuItemFromPoint")]
		public static extern int MenuItemFromPoint([In] IntPtr hWnd, [In] IntPtr hMenu, POINT ptScreen);

		[DllImport("user32.dll", EntryPoint = "LoadMenuIndirect")]
		public static extern IntPtr LoadMenuIndirect([In] IntPtr lpMenuTemplate);

		[DllImport("user32.dll", EntryPoint = "LoadAccelerators")]
		public static extern IntPtr LoadAccelerators([In] IntPtr hInstance, [In] string lpTableName);

		[DllImport("user32.dll", EntryPoint = "GetRawInputBuffer")]
		public static extern uint GetRawInputBuffer(IntPtr pData, ref uint pcbSize, uint cbSizeHeader);

		[DllImport("user32.dll", EntryPoint = "GetNextDlgTabItem")]
		public static extern IntPtr GetNextDlgTabItem([In] IntPtr hDlg, [In] IntPtr hCtl, [MarshalAs(UnmanagedType.Bool)] bool bPrevious);

		[DllImport("user32.dll", EntryPoint = "GetKeyboardLayout")]
		public static extern IntPtr GetKeyboardLayout(uint idThread);

		[DllImport("user32.dll", EntryPoint = "GetClipboardOwner")]
		public static extern IntPtr GetClipboardOwner();

		[DllImport("user32.dll", EntryPoint = "GetCaretBlinkTime")]
		public static extern uint GetCaretBlinkTime();

		[DllImport("user32.dll", EntryPoint = "EnumThreadWindows")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool EnumThreadWindows(uint dwThreadId, WNDENUMPROC lpfn, [MarshalAs(UnmanagedType.SysInt)] int lParam);

		[DllImport("user32.dll", EntryPoint = "EndDeferWindowPos")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool EndDeferWindowPos([In] IntPtr hWinPosInfo);

		[DllImport("user32.dll", EntryPoint = "DrawAnimatedRects")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool DrawAnimatedRects([In] IntPtr hwnd, int idAni, [In] ref RECT lprcFrom, [In] ref RECT lprcTo);

		[DllImport("user32.dll", EntryPoint = "DdeFreeDataHandle")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool DdeFreeDataHandle(IntPtr hData);

		[DllImport("user32.dll", EntryPoint = "DdeEnableCallback")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool DdeEnableCallback(uint idInst, IntPtr hConv, uint wCmd);

		[DllImport("user32.dll", EntryPoint = "DdeDisconnectList")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool DdeDisconnectList(IntPtr hConvList);

		[DllImport("user32.dll", EntryPoint = "AttachThreadInput")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool AttachThreadInput(uint idAttach, uint idAttachTo, [MarshalAs(UnmanagedType.Bool)] bool fAttach);

		[DllImport("user32.dll", EntryPoint = "WaitForInputIdle")]
		public static extern uint WaitForInputIdle([In] IntPtr hProcess, uint dwMilliseconds);

		[DllImport("user32.dll", EntryPoint = "UnregisterHotKey")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool UnregisterHotKey([In] IntPtr hWnd, int id);

		[DllImport("user32.dll", EntryPoint = "UnregisterClass")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool UnregisterClass([In] string lpClassName, [In] IntPtr hInstance);

		[DllImport("user32.dll", EntryPoint = "TranslateMessage")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool TranslateMessage([In] ref MSG lpMsg);

		[DllImport("user32.dll", EntryPoint = "TrackPopupMenuEx")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool TrackPopupMenuEx([In] IntPtr param0, uint param1, int param2, int param3, [In] IntPtr param4, [In] IntPtr param5);

		[DllImport("user32.dll", EntryPoint = "SetThreadDesktop")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetThreadDesktop([In] IntPtr hDesktop);

		[DllImport("user32.dll", EntryPoint = "SetMenuItemInfo")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetMenuItemInfo(
			[In] IntPtr hmenu, uint item, [MarshalAs(UnmanagedType.Bool)] bool fByPositon, [In] ref MENUITEMINFO lpmii);

		[DllImport("user32.dll", EntryPoint = "SetKeyboardState")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetKeyboardState([MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I1, SizeConst = 256)] byte[] lpKeyState);

		[DllImport("user32.dll", EntryPoint = "SetClipboardData")]
		public static extern IntPtr SetClipboardData(uint uFormat, [In] IntPtr hMem);

		[DllImport("user32.dll", EntryPoint = "RegisterClassEx")]
		public static extern ushort RegisterClassEx([In] ref WNDCLASSEX param0);

		[DllImport("user32.dll", EntryPoint = "OpenInputDesktop")]
		public static extern IntPtr OpenInputDesktop(DF dwFlags, [MarshalAs(UnmanagedType.Bool)] bool fInherit, uint dwDesiredAccess);

		[DllImport("user32.dll", EntryPoint = "MonitorFromPoint")]
		public static extern IntPtr MonitorFromPoint(POINT pt, MONITOR dwFlags);

		[DllImport("user32.dll", EntryPoint = "MapVirtualKeyEx")]
		public static extern uint MapVirtualKeyEx(uint uCode, uint uMapType, [In] IntPtr dwhkl);

		[DllImport("user32.dll", EntryPoint = "LockWindowUpdate")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool LockWindowUpdate([In] IntPtr hWndLock);

		[DllImport("user32.dll", EntryPoint = "IsDialogMessage")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool IsDialogMessage([In] IntPtr hDlg, [In] ref MSG lpMsg);

		[DllImport("user32.dll", EntryPoint = "GetThreadDesktop")]
		public static extern IntPtr GetThreadDesktop(uint dwThreadId);

		[DllImport("user32.dll", EntryPoint = "GetSystemMetrics")]
		public static extern int GetSystemMetrics(int nIndex);

		[DllImport("user32.dll", EntryPoint = "GetSysColorBrush")]
		public static extern IntPtr GetSysColorBrush(int nIndex);

		[DllImport("user32.dll", EntryPoint = "GetScrollBarInfo")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetScrollBarInfo([In] IntPtr hwnd, int idObject, ref SCROLLBARINFO psbi);

		[DllImport("user32.dll", EntryPoint = "GetMenuItemInfo")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetMenuItemInfo([In] IntPtr hmenu, uint item, [MarshalAs(UnmanagedType.Bool)] bool fByPosition, ref MENUITEMINFO lpmii);

		[DllImport("user32.dll", EntryPoint = "GetMenuItemCount")]
		public static extern int GetMenuItemCount([In] IntPtr hMenu);

		[DllImport("user32.dll", EntryPoint = "GetLastInputInfo")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetLastInputInfo([Out] out LASTINPUTINFO plii);

		[DllImport("user32.dll", EntryPoint = "GetKeyboardState")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetKeyboardState(IntPtr lpKeyState);

		[DllImport("user32.dll", EntryPoint = "GetGUIThreadInfo")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetGUIThreadInfo(uint idThread, ref GUITHREADINFO pgui);

		[DllImport("user32.dll", EntryPoint = "GetDesktopWindow")]
		public static extern IntPtr GetDesktopWindow();

		[DllImport("user32.dll", EntryPoint = "GetClipboardData")]
		public static extern IntPtr GetClipboardData(uint uFormat);

		[DllImport("user32.dll", EntryPoint = "GetAsyncKeyState")]
		public static extern short GetAsyncKeyState(int vKey);

		[DllImport("user32.dll", EntryPoint = "ExcludeUpdateRgn")]
		public static extern int ExcludeUpdateRgn([In] IntPtr hDC, [In] IntPtr hWnd);

		[DllImport("user32.dll", EntryPoint = "EnumChildWindows")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool EnumChildWindows([In] IntPtr hWndParent, WNDENUMPROC lpEnumFunc, [MarshalAs(UnmanagedType.SysInt)] int lParam);

		[DllImport("user32.dll", EntryPoint = "DrawFrameControl")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool DrawFrameControl([In] IntPtr param0, ref RECT param1, uint param2, uint param3);

		[DllImport("user32.dll", EntryPoint = "DispatchMessage")]
		[return: MarshalAs(UnmanagedType.SysInt)]
		public static extern int DispatchMessage([In] ref MSG lpMsg);

		[DllImport("user32.dll", EntryPoint = "DefMDIChildProc")]
		[return: MarshalAs(UnmanagedType.SysInt)]
		public static extern int DefMDIChildProc(
			[In] IntPtr hWnd, uint uMsg, [MarshalAs(UnmanagedType.SysUInt)] uint wParam, [MarshalAs(UnmanagedType.SysInt)] int lParam);

		[DllImport("user32.dll", EntryPoint = "DdeSetUserHandle")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool DdeSetUserHandle(IntPtr hConv, uint id, uint hUser);

		[DllImport("user32.dll", EntryPoint = "DdeQueryConvInfo")]
		public static extern uint DdeQueryConvInfo(IntPtr hConv, uint idTransaction, ref CONVINFO pConvInfo);

		[DllImport("user32.dll", EntryPoint = "CreateMDIWindow")]
		public static extern IntPtr CreateMDIWindow(
			[In] string lpClassName, [In] string lpWindowName, WS dwStyle, int X, int Y, int nWidth, int nHeight, [In] IntPtr hWndParent, [In] IntPtr hInstance, [MarshalAs(UnmanagedType.SysInt)] int lParam);

		[DllImport("user32.dll", EntryPoint = "CheckRadioButton")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool CheckRadioButton([In] IntPtr hDlg, int nIDFirstButton, int nIDLastButton, int nIDCheckButton);

		[DllImport("user32.dll", EntryPoint = "BringWindowToTop")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool BringWindowToTop([In] IntPtr hWnd);

		[DllImport("user32.dll", EntryPoint = "AdjustWindowRect")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool AdjustWindowRect(ref RECT lpRect, WS dwStyle, [MarshalAs(UnmanagedType.Bool)] bool bMenu);

		[DllImport("user32.dll", EntryPoint = "WindowFromPoint")]
		public static extern IntPtr WindowFromPoint(POINT Point);

		[DllImport("user32.dll", EntryPoint = "UnpackDDElParam")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool UnpackDDElParam(uint msg, [MarshalAs(UnmanagedType.SysInt)] int lParam, ref uint puiLo, ref uint puiHi);

		[DllImport("user32.dll", EntryPoint = "TrackMouseEvent")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool TrackMouseEvent(ref TRACKMOUSEEVENT lpEventTrack);

		[DllImport("user32.dll", EntryPoint = "SwapMouseButton")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SwapMouseButton([MarshalAs(UnmanagedType.Bool)] bool fSwap);

		[DllImport("user32.dll", EntryPoint = "ShowWindowAsync")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool ShowWindowAsync([In] IntPtr hWnd, int nCmdShow);

		[DllImport("user32.dll", EntryPoint = "ShowOwnedPopups")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool ShowOwnedPopups([In] IntPtr hWnd, [MarshalAs(UnmanagedType.Bool)] bool fShow);

		[DllImport("user32.dll", EntryPoint = "SetWinEventHook")]
		public static extern IntPtr SetWinEventHook(
			uint eventMin, uint eventMax, [In] IntPtr hmodWinEventProc, WINEVENTPROC pfnWinEventProc, uint idProcess, uint idThread, WINEVENT dwFlags);

		[DllImport("user32.dll", EntryPoint = "SetWindowsHook")]
		public static extern IntPtr SetWindowsHook(int nFilterType, HOOKPROC pfnFilterProc);

		[DllImport("user32.dll", EntryPoint = "SetSystemCursor")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetSystemCursor([In] IntPtr hcur, uint id);

		[DllImport("user32.dll", EntryPoint = "SetMessageQueue")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetMessageQueue(int cMessagesMax);

		[DllImport("user32.dll", EntryPoint = "SetDlgItemText")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetDlgItemText([In] IntPtr hDlg, int nIDDlgItem, [In] string lpString);

		[DllImport("user32.dll", EntryPoint = "SetActiveWindow")]
		public static extern IntPtr SetActiveWindow([In] IntPtr hWnd);

		[DllImport("user32.dll", EntryPoint = "PostQuitMessage")]
		public static extern void PostQuitMessage(int nExitCode);

		[DllImport("user32.dll", EntryPoint = "MonitorFromRect")]
		public static extern IntPtr MonitorFromRect([In] ref RECT lprc, MONITOR dwFlags);

		[DllImport("user32.dll", EntryPoint = "MapWindowPoints")]
		public static extern int MapWindowPoints([In] IntPtr hWndFrom, [In] IntPtr hWndTo, IntPtr lpPoints, uint cPoints);

		[DllImport("user32.dll", EntryPoint = "LockWorkStation")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool LockWorkStation();

		[DllImport("user32.dll", EntryPoint = "IsWindowVisible")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool IsWindowVisible([In] IntPtr hWnd);

		[DllImport("user32.dll", EntryPoint = "IsWindowUnicode")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool IsWindowUnicode([In] IntPtr hWnd);

		[DllImport("user32.dll", EntryPoint = "IsWindowEnabled")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool IsWindowEnabled([In] IntPtr hWnd);

		[DllImport("user32.dll", EntryPoint = "IsHungAppWindow")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool IsHungAppWindow([In] IntPtr hwnd);

		[DllImport("user32.dll", EntryPoint = "InsertMenuItem")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool InsertMenuItem(
			[In] IntPtr hmenu, uint item, [MarshalAs(UnmanagedType.Bool)] bool fByPosition, [In] ref MENUITEMINFO lpmi);

		[DllImport("user32.dll", EntryPoint = "InSendMessageEx")]
		public static extern uint InSendMessageEx(IntPtr lpReserved);

		[DllImport("user32.dll", EntryPoint = "GetWindowRgnBox")]
		public static extern int GetWindowRgnBox([In] IntPtr hWnd, [Out] out RECT lprc);

		[DllImport("user32.dll", EntryPoint = "GetTitleBarInfo")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetTitleBarInfo([In] IntPtr hwnd, ref TITLEBARINFO pti);

		[DllImport("user32.dll", EntryPoint = "GetRawInputData")]
		public static extern uint GetRawInputData([In] IntPtr hRawInput, uint uiCommand, IntPtr pData, ref uint pcbSize, uint cbSizeHeader);

		[DllImport("user32.dll", EntryPoint = "GetMonitorInfo")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetMonitorInfo([In] IntPtr hMonitor, ref MONITORINFO lpmi);

		[DllImport("user32.dll", EntryPoint = "GetMenuItemRect")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetMenuItemRect([In] IntPtr hWnd, [In] IntPtr hMenu, uint uItem, [Out] out RECT lprcItem);

		[DllImport("user32.dll", EntryPoint = "GetKeyNameText")]
		public static extern int GetKeyNameText(int lParam, [Out] StringBuilder lpString, int cchSize);

		[DllImport("user32.dll", EntryPoint = "GetKeyboardType")]
		public static extern int GetKeyboardType(int nTypeFlag);

		[DllImport("user32.dll", EntryPoint = "GetGuiResources")]
		public static extern uint GetGuiResources([In] IntPtr hProcess, GR uiFlags);

		[DllImport("user32.dll", EntryPoint = "GetDlgItemText")]
		public static extern uint GetDlgItemText([In] IntPtr hDlg, int nIDDlgItem, [Out] StringBuilder lpString, int cchMax);

		[DllImport("user32.dll", EntryPoint = "GetComboBoxInfo")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetComboBoxInfo([In] IntPtr hwndCombo, ref COMBOBOXINFO pcbi);

		[DllImport("user32.dll", EntryPoint = "GetClassInfoEx")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetClassInfoEx([In] IntPtr hInstance, [In] string lpszClass, [Out] out WNDCLASSEX lpwcx);

		[DllImport("user32.dll", EntryPoint = "GetActiveWindow")]
		public static extern IntPtr GetActiveWindow();

		[DllImport("user32.dll", EntryPoint = "EnableScrollBar")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool EnableScrollBar([In] IntPtr hWnd, SB wSBflags, ESB wArrows);

		[DllImport("user32.dll", EntryPoint = "DlgDirSelectEx")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool DlgDirSelectEx([In] IntPtr hwndDlg, [Out] StringBuilder lpString, int chCount, int idListBox);

		[DllImport("user32.dll", EntryPoint = "DialogBoxParam")]
		public static extern int DialogBoxParam(
			[In] IntPtr hInstance, [In] string lpTemplateName, [In] IntPtr hWndParent, DLGPROC lpDialogFunc, [MarshalAs(UnmanagedType.SysInt)] int dwInitParam);

		[DllImport("user32.dll", EntryPoint = "DefRawInputProc")]
		[return: MarshalAs(UnmanagedType.SysInt)]
		public static extern int DefRawInputProc(
			[MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.SysInt, SizeParamIndex = 1)] IntPtr[] paRawInput, int nInput, uint cbSizeHeader);

		[DllImport("user32.dll", EntryPoint = "DdeUninitialize")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool DdeUninitialize(uint idInst);

		[DllImport("user32.dll", EntryPoint = "DdeUnaccessData")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool DdeUnaccessData(IntPtr hData);

		[DllImport("user32.dll", EntryPoint = "DdeQueryString")]
		public static extern uint DdeQueryString(uint idInst, IntPtr hsz, StringBuilder psz, uint cchMax, int iCodePage);

		[DllImport("user32.dll", EntryPoint = "DdeGetLastError")]
		public static extern uint DdeGetLastError(uint idInst);

		[DllImport("user32.dll", EntryPoint = "CreateWindowEx")]
		public static extern IntPtr CreateWindowEx(
			WS_EX dwExStyle, [In] string lpClassName, [In] string lpWindowName, WS dwStyle, int X, int Y, int nWidth, int nHeight, [In] IntPtr hWndParent, [In] IntPtr hMenu, [In] IntPtr hInstance, [In] IntPtr lpParam);

		[DllImport("user32.dll", EntryPoint = "CreatePopupMenu")]
		public static extern IntPtr CreatePopupMenu();

		[DllImport("user32.dll", EntryPoint = "CallWindowProc")]
		[return: MarshalAs(UnmanagedType.SysInt)]
		public static extern int CallWindowProc(
			WNDPROC lpPrevWndFunc, [In] IntPtr hWnd, uint Msg, [MarshalAs(UnmanagedType.SysUInt)] uint wParam, [MarshalAs(UnmanagedType.SysInt)] int lParam);

		[DllImport("user32.dll", EntryPoint = "UnhookWinEvent")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool UnhookWinEvent([In] IntPtr hWinEventHook);

		[DllImport("user32.dll", EntryPoint = "TrackPopupMenu")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool TrackPopupMenu([In] IntPtr hMenu, TPM uFlags, int x, int y, int nReserved, [In] IntPtr hWnd, [In] IntPtr prcRect);

		[DllImport("user32.dll", EntryPoint = "TabbedTextOut")]
		public static extern int TabbedTextOut(
			[In] IntPtr hdc, int x, int y, [In] string lpString, int chCount, int nTabPositions, [In] IntPtr lpnTabStopPositions, int nTabOrigin);

		[DllImport("user32.dll", EntryPoint = "SetWindowText")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetWindowText([In] IntPtr hWnd, [In] string lpString);

		[DllImport("user32.dll", EntryPoint = "SetWindowLong")]
		public static extern int SetWindowLong([In] IntPtr hWnd, int nIndex, int dwNewLong);

		[DllImport("user32.dll", EntryPoint = "SetScrollRange")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetScrollRange([In] IntPtr hWnd, int nBar, int nMinPos, int nMaxPos, [MarshalAs(UnmanagedType.Bool)] bool bRedraw);

		[DllImport("user32.dll", EntryPoint = "SetLastErrorEx")]
		public static extern void SetLastErrorEx(uint dwErrCode, uint dwType);

		[DllImport("user32.dll", EntryPoint = "ScrollWindowEx")]
		public static extern int ScrollWindowEx(
			[In] IntPtr hWnd, int dx, int dy, [In] IntPtr prcScroll, [In] IntPtr prcClip, [In] IntPtr hrgnUpdate, IntPtr prcUpdate, SW flags);

		[DllImport("user32.dll", EntryPoint = "ScreenToClient")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool ScreenToClient([In] IntPtr hWnd, ref POINT lpPoint);

		[DllImport("user32.dll", EntryPoint = "ReuseDDElParam")]
		[return: MarshalAs(UnmanagedType.SysInt)]
		public static extern int ReuseDDElParam(
			[MarshalAs(UnmanagedType.SysInt)] int lParam, uint msgIn, uint msgOut, [MarshalAs(UnmanagedType.SysUInt)] uint uiLo,
			[MarshalAs(UnmanagedType.SysUInt)] uint uiHi);

		[DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool ReleaseCapture();

		[DllImport("user32.dll", EntryPoint = "RegisterHotKey")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool RegisterHotKey([In] IntPtr hWnd, int id, uint fsModifiers, uint vk);

		[DllImport("user32.dll", EntryPoint = "RegisterClass")]
		public static extern ushort RegisterClass([In] ref WNDCLASS lpWndClass);

		[DllImport("user32.dll", EntryPoint = "OemToCharBuff")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool OemToCharBuff([In] [MarshalAs(UnmanagedType.LPStr)] string lpszSrc, [Out] StringBuilder lpszDst, uint cchDstLength);

		[DllImport("user32.dll", EntryPoint = "NotifyWinEvent")]
		public static extern void NotifyWinEvent(uint @event, [In] IntPtr hwnd, int idObject, int idChild);

		[DllImport("user32.dll", EntryPoint = "MapVirtualKey")]
		public static extern uint MapVirtualKey(uint uCode, uint uMapType);

		[DllImport("user32.dll", EntryPoint = "InvalidateRect")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool InvalidateRect([In] IntPtr hWnd, [In] IntPtr lpRect, [MarshalAs(UnmanagedType.Bool)] bool bErase);

		[DllImport("user32.dll", EntryPoint = "HiliteMenuItem")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool HiliteMenuItem([In] IntPtr hWnd, [In] IntPtr hMenu, uint uIDHiliteItem, uint uHilite);

		[DllImport("user32.dll", EntryPoint = "GetWindowText")]
		public static extern int GetWindowText([In] IntPtr hWnd, [Out] StringBuilder lpString, int nMaxCount);

		[DllImport("user32.dll", EntryPoint = "GetWindowLong")]
		public static extern int GetWindowLong([In] IntPtr hWnd, int nIndex);

		[DllImport("user32.dll", EntryPoint = "GetShellWindow")]
		public static extern IntPtr GetShellWindow();

		[DllImport("user32.dll", EntryPoint = "GetScrollRange")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetScrollRange([In] IntPtr hWnd, int nBar, [Out] out int lpMinPos, [Out] out int lpMaxPos);

		[DllImport("user32.dll", EntryPoint = "GetQueueStatus")]
		public static extern uint GetQueueStatus(QS flags);

		[DllImport("user32.dll", EntryPoint = "GetMessageTime")]
		public static extern int GetMessageTime();

		[DllImport("user32.dll", EntryPoint = "GetMenuString")]
		public static extern int GetMenuString([In] IntPtr hMenu, uint uIDItem, [Out] StringBuilder lpString, int cchMax, MF flags);

		[DllImport("user32.dll", EntryPoint = "GetMenuBarInfo")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetMenuBarInfo([In] IntPtr hwnd, int idObject, int idItem, ref MENUBARINFO pmbi);

		[DllImport("user32.dll", EntryPoint = "GetListBoxInfo")]
		public static extern uint GetListBoxInfo([In] IntPtr hwnd);

		[DllImport("user32.dll", EntryPoint = "GetAltTabInfo")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetAltTabInfo([In] IntPtr hwnd, int iItem, ref ALTTABINFO pati, [Out] StringBuilder pszItemText, uint cchItemText);

		[DllImport("user32.dll", EntryPoint = "EnableMenuItem")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool EnableMenuItem([In] IntPtr hMenu, uint uIDEnableItem, uint uEnable);

		[DllImport("user32.dll", EntryPoint = "EmptyClipboard")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool EmptyClipboard();

		[DllImport("user32.dll", EntryPoint = "DefWindowProc")]
		[return: MarshalAs(UnmanagedType.SysInt)]
		public static extern int DefWindowProc([In] IntPtr hWnd, uint Msg, [MarshalAs(UnmanagedType.SysUInt)] uint wParam, [MarshalAs(UnmanagedType.SysInt)] int lParam);

		[DllImport("user32.dll", EntryPoint = "DeferWindowPos")]
		public static extern IntPtr DeferWindowPos(
			[In] IntPtr hWinPosInfo, [In] IntPtr hWnd, [In] IntPtr hWndInsertAfter, int x, int y, int cx, int cy, SWP uFlags);

		[DllImport("user32.dll", EntryPoint = "DdeNameService")]
		public static extern IntPtr DdeNameService(uint idInst, IntPtr hsz1, IntPtr hsz2, uint afCmd);

		[DllImport("user32.dll", EntryPoint = "DdeInitialize")]
		public static extern uint DdeInitialize(ref uint pidInst, PFNCALLBACK pfnCallback, uint afCmd, uint ulRes);

		[DllImport("user32.dll", EntryPoint = "DdeConnectList")]
		public static extern IntPtr DdeConnectList(uint idInst, IntPtr hszService, IntPtr hszTopic, IntPtr hConvList, ref CONVCONTEXT pCC);

		[DllImport("user32.dll", EntryPoint = "CreateDesktop")]
		public static extern IntPtr CreateDesktop([In] string lpszDesktop, [In] string lpszDevice, IntPtr pDevmode, DF dwFlags, uint dwDesiredAccess, [In] IntPtr lpsa);

		[DllImport("user32.dll", EntryPoint = "CloseClipboard")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool CloseClipboard();

		[DllImport("user32.dll", EntryPoint = "ClientToScreen")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool ClientToScreen([In] IntPtr hWnd, ref POINT lpPoint);

		[DllImport("user32.dll", EntryPoint = "CheckDlgButton")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool CheckDlgButton([In] IntPtr hDlg, int nIDButton, uint uCheck);

		[DllImport("user32.dll", EntryPoint = "CharUpperBuff")]
		public static extern uint CharUpperBuff(StringBuilder lpsz, uint cchLength);

		[DllImport("user32.dll", EntryPoint = "CharToOemBuff")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool CharToOemBuff([In] string lpszSrc, [Out] StringBuilder lpszDst, uint cchDstLength);

		[DllImport("user32.dll", EntryPoint = "CharLowerBuff")]
		public static extern uint CharLowerBuff(StringBuilder lpsz, uint cchLength);

		[DllImport("user32.dll", EntryPoint = "CascadeWindows")]
		public static extern ushort CascadeWindows([In] IntPtr hwndParent, uint wHow, [In] IntPtr lpRect, uint cKids, ref IntPtr lpKids);

		[DllImport("user32.dll", EntryPoint = "CallNextHookEx")]
		public static extern IntPtr CallNextHookEx(
			[In] IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

		[DllImport("user32.dll", EntryPoint = "CallMsgFilter")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool CallMsgFilter([In] ref MSG lpMsg, int nCode);

		[DllImport("user32.dll", EntryPoint = "SwitchDesktop")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SwitchDesktop([In] IntPtr hDesktop);

		[DllImport("user32.dll", EntryPoint = "ShowScrollBar")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool ShowScrollBar([In] IntPtr hWnd, int wBar, [MarshalAs(UnmanagedType.Bool)] bool bShow);

		[DllImport("user32.dll", EntryPoint = "SetWindowWord")]
		public static extern ushort SetWindowWord([In] IntPtr hWnd, int nIndex, ushort wNewWord);

		[DllImport("user32.dll", EntryPoint = "SetScrollInfo")]
		public static extern int SetScrollInfo([In] IntPtr hwnd, int nBar, [In] ref SCROLLINFO lpsi, [MarshalAs(UnmanagedType.Bool)] bool redraw);

		[DllImport("user32.dll", EntryPoint = "SetDlgItemInt")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetDlgItemInt([In] IntPtr hDlg, int nIDDlgItem, uint uValue, [MarshalAs(UnmanagedType.Bool)] bool bSigned);

		[DllImport("user32.dll", EntryPoint = "SetClassLong")]
		public static extern uint SetClassLong([In] IntPtr hWnd, int nIndex, int dwNewLong);

		[DllImport("user32.dll", EntryPoint = "PackDDElParam")]
		[return: MarshalAs(UnmanagedType.SysInt)]
		public static extern int PackDDElParam(uint msg, [MarshalAs(UnmanagedType.SysUInt)] uint uiLo, [MarshalAs(UnmanagedType.SysUInt)] uint uiHi);

		[DllImport("user32.dll", EntryPoint = "OpenClipboard")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool OpenClipboard([In] IntPtr hWndNewOwner);

		[DllImport("user32.dll", EntryPoint = "MessageBoxEx")]
		public static extern int MessageBoxEx([In] IntPtr hWnd, [In] string lpText, [In] string lpCaption, uint uType, ushort wLanguageId);

		[DllImport("user32.dll", EntryPoint = "MapDialogRect")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool MapDialogRect([In] IntPtr hDlg, ref RECT lpRect);

		[DllImport("user32.dll", EntryPoint = "InvalidateRgn")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool InvalidateRgn([In] IntPtr hWnd, [In] IntPtr hRgn, [MarshalAs(UnmanagedType.Bool)] bool bErase);

		[DllImport("user32.dll", EntryPoint = "IntersectRect")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool IntersectRect([Out] out RECT lprcDst, [In] ref RECT lprcSrc1, [In] ref RECT lprcSrc2);

		[DllImport("user32.dll", EntryPoint = "InSendMessage")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool InSendMessage();

		[DllImport("user32.dll", EntryPoint = "GetWindowWord")]
		public static extern ushort GetWindowWord([In] IntPtr hWnd, int nIndex);

		[DllImport("user32.dll", EntryPoint = "GetWindowRect")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetWindowRect([In] IntPtr hWnd, [Out] out RECT lpRect);

		[DllImport("user32.dll", EntryPoint = "GetWindowInfo")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetWindowInfo([In] IntPtr hwnd, ref WINDOWINFO pwi);

		[DllImport("user32.dll", EntryPoint = "GetUpdateRect")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetUpdateRect([In] IntPtr hWnd, IntPtr lpRect, [MarshalAs(UnmanagedType.Bool)] bool bErase);

		[DllImport("user32.dll", EntryPoint = "GetSystemMenu")]
		public static extern IntPtr GetSystemMenu([In] IntPtr hWnd, [MarshalAs(UnmanagedType.Bool)] bool bRevert);

		[DllImport("user32.dll", EntryPoint = "GetScrollInfo")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetScrollInfo([In] IntPtr hwnd, int nBar, ref SCROLLINFO lpsi);

		[DllImport("user32.dll", EntryPoint = "GetMessagePos")]
		public static extern uint GetMessagePos();

		[DllImport("user32.dll", EntryPoint = "GetMenuItemID")]
		public static extern uint GetMenuItemID([In] IntPtr hMenu, int nPos);

		[DllImport("user32.dll", EntryPoint = "GetKBCodePage")]
		public static extern uint GetKBCodePage();

		[DllImport("user32.dll", EntryPoint = "GetInputState")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetInputState();

		[DllImport("user32.dll", EntryPoint = "GetDlgItemInt")]
		public static extern uint GetDlgItemInt([In] IntPtr hDlg, int nIDDlgItem, IntPtr lpTranslated, [MarshalAs(UnmanagedType.Bool)] bool bSigned);

		[DllImport("user32.dll", EntryPoint = "GetCursorInfo")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetCursorInfo(ref CURSORINFO pci);

		[DllImport("user32.dll", EntryPoint = "GetClipCursor")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetClipCursor([Out] out RECT lpRect);

		[DllImport("user32.dll", EntryPoint = "GetClientRect")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetClientRect([In] IntPtr hWnd, [Out] out RECT lpRect);

		[DllImport("user32.dll", EntryPoint = "GetClassName")]
		public static extern int GetClassName([In] IntPtr hWnd, [Out]  StringBuilder lpClassName, int nMaxCount);

		[DllImport("user32.dll", EntryPoint = "GetClassLong")]
		public static extern uint GetClassLong([In] IntPtr hWnd, int nIndex);

		[DllImport("user32.dll", EntryPoint = "GetClassInfo")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetClassInfo([In] IntPtr hInstance, [In] string lpClassName, [Out] out WNDCLASS lpWndClass);

		[DllImport("user32.dll", EntryPoint = "FreeDDElParam")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool FreeDDElParam(uint msg, [MarshalAs(UnmanagedType.SysInt)] int lParam);

		[DllImport("user32.dll", EntryPoint = "FlashWindowEx")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool FlashWindowEx([In] ref FLASHWINFO pfwi);

		[DllImport("user32.dll", EntryPoint = "FindWindowEx")]
		public static extern IntPtr FindWindowEx([In] IntPtr hWndParent, [In] IntPtr hWndChildAfter, [In] string lpszClass, [In] string lpszWindow);

		[DllImport("user32.dll", EntryPoint = "ExitWindowsEx")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool ExitWindowsEx(uint uFlags, uint dwReason);

		[DllImport("user32.dll", EntryPoint = "EnumDesktops")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool EnumDesktops([In] IntPtr hwinsta, NAMEENUMPROC lpEnumFunc, [MarshalAs(UnmanagedType.SysInt)] int lParam);

		[DllImport("user32.dll", EntryPoint = "DrawFocusRect")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool DrawFocusRect([In] IntPtr hDC, [In] ref RECT lprc);

		[DllImport("user32.dll", EntryPoint = "DestroyWindow")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool DestroyWindow([In] IntPtr hWnd);

		[DllImport("user32.dll", EntryPoint = "DestroyCursor")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool DestroyCursor([In] IntPtr hCursor);

		[DllImport("user32.dll", EntryPoint = "DefFrameProc")]
		[return: MarshalAs(UnmanagedType.SysInt)]
		public static extern int DefFrameProc(
			[In] IntPtr hWnd, [In] IntPtr hWndMDIClient, uint uMsg, [MarshalAs(UnmanagedType.SysUInt)] uint wParam, [MarshalAs(UnmanagedType.SysInt)] int lParam);

		[DllImport("user32.dll", EntryPoint = "DdePostAdvise")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool DdePostAdvise(uint idInst, IntPtr hszTopic, IntPtr hszItem);

		[DllImport("user32.dll", EntryPoint = "DdeDisconnect")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool DdeDisconnect(IntPtr hConv);

		[DllImport("user32.dll", EntryPoint = "DdeAccessData")]
		public static extern IntPtr DdeAccessData(IntPtr hData, ref uint pcbDataSize);

		[DllImport("user32.dll", EntryPoint = "CheckMenuItem")]
		public static extern uint CheckMenuItem([In] IntPtr hMenu, uint uIDCheckItem, uint uCheck);

		[DllImport("user32.dll", EntryPoint = "AnimateWindow")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool AnimateWindow([In] IntPtr hWnd, uint dwTime, AW dwFlags);

		[DllImport("user32.dll", EntryPoint = "WindowFromDC")]
		public static extern IntPtr WindowFromDC([In] IntPtr hDC);

		[DllImport("user32.dll", EntryPoint = "VkKeyScanEx")]
		public static extern short VkKeyScanEx(char ch, [In] IntPtr dwhkl);

		[DllImport("user32.dll", EntryPoint = "ValidateRect")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool ValidateRect([In] IntPtr hWnd, [In] IntPtr lpRect);

		[DllImport("user32.dll", EntryPoint = "UpdateWindow")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool UpdateWindow([In] IntPtr hWnd);

		[DllImport("user32.dll", EntryPoint = "SubtractRect")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SubtractRect([Out] out RECT lprcDst, [In] ref RECT lprcSrc1, [In] ref RECT lprcSrc2);

		[DllImport("user32.dll", EntryPoint = "SetWindowRgn")]
		public static extern int SetWindowRgn([In] IntPtr hWnd, [In] IntPtr hRgn, [MarshalAs(UnmanagedType.Bool)] bool bRedraw);

		[DllImport("user32.dll", EntryPoint = "SetWindowPos")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetWindowPos([In] IntPtr hWnd, [In] IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, SWP uFlags);

		[DllImport("user32.dll", EntryPoint = "SetSysColors")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetSysColors(
			int cElements, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I4, SizeParamIndex = 0)] int[] lpaElements,
			[MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U4, SizeParamIndex = 0)] uint[] lpaRgbValues);

		[DllImport("user32.dll", EntryPoint = "SetScrollPos")]
		public static extern int SetScrollPos([In] IntPtr hWnd, int nBar, int nPos, [MarshalAs(UnmanagedType.Bool)] bool bRedraw);

		[DllImport("user32.dll", EntryPoint = "SetRectEmpty")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetRectEmpty([Out] out RECT lprc);

		[DllImport("user32.dll", EntryPoint = "SetCursorPos")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetCursorPos(int X, int Y);

		[DllImport("user32.dll", EntryPoint = "SetClassWord")]
		public static extern ushort SetClassWord([In] IntPtr hWnd, int nIndex, ushort wNewWord);

		[DllImport("user32.dll", EntryPoint = "SendMessage")]
		[return: MarshalAs(UnmanagedType.SysInt)]
		public static extern int SendMessage(
			[In] IntPtr hWnd, uint Msg, [MarshalAs(UnmanagedType.SysUInt)] uint wParam, [MarshalAs(UnmanagedType.SysInt)] int lParam);

		[DllImport("user32.dll", EntryPoint = "ScrollWindow")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool ScrollWindow([In] IntPtr hWnd, int XAmount, int YAmount, [In] IntPtr lpRect, [In] IntPtr lpClipRect);

		[DllImport("user32.dll", EntryPoint = "ReplyMessage")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool ReplyMessage([MarshalAs(UnmanagedType.SysInt)] int lResult);

		[DllImport("user32.dll", EntryPoint = "RedrawWindow")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool RedrawWindow([In] IntPtr hWnd, [In] IntPtr lprcUpdate, [In] IntPtr hrgnUpdate, RDW flags);

		[DllImport("user32.dll", EntryPoint = "PostMessage")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool PostMessage(
			[In] IntPtr hWnd, uint Msg, [MarshalAs(UnmanagedType.SysUInt)] uint wParam, [MarshalAs(UnmanagedType.SysInt)] int lParam);

		[DllImport("user32.dll", EntryPoint = "PeekMessage")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool PeekMessage([Out] out MSG lpMsg, [In] IntPtr hWnd, uint wMsgFilterMin, uint wMsgFilterMax, uint wRemoveMsg);

		[DllImport("user32.dll", EntryPoint = "PaintDesktop")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool PaintDesktop([In] IntPtr hdc);

		[DllImport("user32.dll", EntryPoint = "OpenDesktop")]
		public static extern IntPtr OpenDesktop([In] string lpszDesktop, DF dwFlags, [MarshalAs(UnmanagedType.Bool)] bool fInherit, uint dwDesiredAccess);

		[DllImport("user32.dll", EntryPoint = "IsCharUpper")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool IsCharUpper(char ch);

		[DllImport("user32.dll", EntryPoint = "IsCharLower")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool IsCharLower(char ch);

		[DllImport("user32.dll", EntryPoint = "IsCharAlpha")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool IsCharAlpha(char ch);

		[DllImport("user32.dll", EntryPoint = "GetWindowRgn")]
		public static extern int GetWindowRgn([In] IntPtr hWnd, [In] IntPtr hRgn);

		[DllImport("user32.dll", EntryPoint = "GetUpdateRgn")]
		public static extern int GetUpdateRgn([In] IntPtr hWnd, [In] IntPtr hRgn, [MarshalAs(UnmanagedType.Bool)] bool bErase);

		[DllImport("user32.dll", EntryPoint = "GetTopWindow")]
		public static extern IntPtr GetTopWindow([In] IntPtr hWnd);

		[DllImport("user32.dll", EntryPoint = "GetScrollPos")]
		public static extern int GetScrollPos([In] IntPtr hWnd, int nBar);

		[DllImport("user32.dll", EntryPoint = "GetMenuState")]
		public static extern uint GetMenuState([In] IntPtr hMenu, uint uId, MF uFlags);

		[DllImport("user32.dll", EntryPoint = "GetDlgCtrlID")]
		public static extern int GetDlgCtrlID([In] IntPtr hWnd);

		[DllImport("user32.dll", EntryPoint = "GetCursorPos")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetCursorPos([Out] out POINT lpPoint);

		[DllImport("user32.dll", EntryPoint = "GetClassWord")]
		public static extern ushort GetClassWord([In] IntPtr hWnd, int nIndex);

		[DllImport("user32.dll", EntryPoint = "EnumPropsEx")]
		public static extern int EnumPropsEx([In] IntPtr hWnd, PROPENUMPROCEX lpEnumFunc, [MarshalAs(UnmanagedType.SysInt)] int lParam);

		[DllImport("user32.dll", EntryPoint = "EnableWindow")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool EnableWindow([In] IntPtr hWnd, [MarshalAs(UnmanagedType.Bool)] bool bEnable);

		[DllImport("user32.dll", EntryPoint = "DestroyCaret")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool DestroyCaret();

		[DllImport("user32.dll", EntryPoint = "DdeReconnect")]
		public static extern IntPtr DdeReconnect(IntPtr hConv);

		[DllImport("user32.dll", EntryPoint = "CreateCursor")]
		public static extern IntPtr CreateCursor(
			[In] IntPtr hInst, int xHotSpot, int yHotSpot, int nWidth, int nHeight, [In] IntPtr pvANDPlane, [In] IntPtr pvXORPlane);

		[DllImport("user32.dll", EntryPoint = "CloseDesktop")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool CloseDesktop([In] IntPtr hDesktop);

		[DllImport("user32.dll", EntryPoint = "WaitMessage")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool WaitMessage();

		[DllImport("user32.dll", EntryPoint = "ValidateRgn")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool ValidateRgn([In] IntPtr hWnd, [In] IntPtr hRgn);

		[DllImport("user32.dll", EntryPoint = "ToUnicodeEx")]
		public static extern int ToUnicodeEx(
			uint wVirtKey, uint wScanCode, [In] IntPtr lpKeyState, [Out] [MarshalAs(UnmanagedType.LPWStr)] StringBuilder pwszBuff, int cchBuff, TU wFlags,
			[In] IntPtr dwhkl);

		[DllImport("user32.dll", EntryPoint = "TileWindows")]
		public static extern ushort TileWindows([In] IntPtr hwndParent, uint wHow, [In] IntPtr lpRect, uint cKids, ref IntPtr lpKids);

		[DllImport("user32.dll", EntryPoint = "SetMenuInfo")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetMenuInfo([In] IntPtr param0, [In] ref MENUINFO param1);

		[DllImport("user32.dll", EntryPoint = "SetCaretPos")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetCaretPos(int X, int Y);

		[DllImport("user32.dll", EntryPoint = "RemoveProp")]
		public static extern IntPtr RemoveProp([In] IntPtr hWnd, [In] string lpString);

		[DllImport("user32.dll", EntryPoint = "PrintWindow")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool PrintWindow([In] IntPtr hwnd, [In] IntPtr hdcBlt, PW nFlags);

		[DllImport("user32.dll", EntryPoint = "mouse_event")]
		public static extern void mouse_event(MOUSEEVENTF dwFlags, uint dx, uint dy, uint dwData, uint dwExtraInfo);

		[DllImport("user32.dll", EntryPoint = "ModifyMenu")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool ModifyMenu([In] IntPtr hMnu, uint uPosition, MF uFlags, [MarshalAs(UnmanagedType.SysUInt)] uint uIDNewItem, [In] string lpNewItem);

		[DllImport("user32.dll", EntryPoint = "MessageBox")]
		public static extern int MessageBox([In] IntPtr hWnd, [In] string lpText, [In] string lpCaption, uint uType);

		[DllImport("user32.dll", EntryPoint = "MessageBeep")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool MessageBeep(uint uType);

		[DllImport("user32.dll", EntryPoint = "LoadString")]
		public static extern int LoadString([In] IntPtr hInstance, uint uID, [Out] StringBuilder lpBuffer, int cchBufferMax);

		[DllImport("user32.dll", EntryPoint = "LoadCursor")]
		public static extern IntPtr LoadCursor([In] IntPtr hInstance, [In] string lpCursorName);

		[DllImport("user32.dll", EntryPoint = "LoadBitmap")]
		public static extern IntPtr LoadBitmap([In] IntPtr hInstance, [In] string lpBitmapName);

		[DllImport("user32.dll", EntryPoint = "keybd_event")]
		public static extern void keybd_event(byte bVk, byte bScan, KEYEVENTF dwFlags, uint dwExtraInfo);

		[DllImport("user32.dll", EntryPoint = "IsRectEmpty")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool IsRectEmpty([In] ref RECT lprc);

		[DllImport("user32.dll", EntryPoint = "IsGUIThread")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool IsGUIThread([MarshalAs(UnmanagedType.Bool)] bool bConvert);

		[DllImport("user32.dll", EntryPoint = "InsertMenu")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool InsertMenu(
			[In] IntPtr hMenu, uint uPosition, MF uFlags, [MarshalAs(UnmanagedType.SysUInt)] uint uIDNewItem, [In] string lpNewItem);

		[DllImport("user32.dll", EntryPoint = "InflateRect")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool InflateRect(ref RECT lprc, int dx, int dy);

		[DllImport("user32.dll", EntryPoint = "GrayString")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GrayString(
			[In] IntPtr hDC, [In] IntPtr hBrush, GRAYSTRINGPROC lpOutputFunc, [MarshalAs(UnmanagedType.SysInt)] int lpData, int nCount, int X, int Y, int nWidth,
			int nHeight);

		[DllImport("user32.dll", EntryPoint = "GetWindowDC")]
		public static extern IntPtr GetWindowDC([In] IntPtr hWnd);

		[DllImport("user32.dll", EntryPoint = "GetSysColor")]
		public static extern uint GetSysColor(int nIndex);

		[DllImport("user32.dll", EntryPoint = "GetMessage")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetMessage([Out] out MSG lpMsg, [In] IntPtr hWnd, uint wMsgFilterMin, uint wMsgFilterMax);

		[DllImport("user32.dll", EntryPoint = "GetMenuInfo")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetMenuInfo([In] IntPtr param0, ref MENUINFO param1);

		[DllImport("user32.dll", EntryPoint = "GetKeyState")]
		public static extern short GetKeyState(int nVirtKey);

		[DllImport("user32.dll", EntryPoint = "GetIconInfo")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetIconInfo([In] IntPtr hIcon, [Out] out ICONINFO piconinfo);

		[DllImport("user32.dll", EntryPoint = "GetCaretPos")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetCaretPos([Out] out POINT lpPoint);

		[DllImport("user32.dll", EntryPoint = "GetAncestor")]
		public static extern IntPtr GetAncestor([In] IntPtr hwnd, GA gaFlags);

		[DllImport("user32.dll", EntryPoint = "FlashWindow")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool FlashWindow([In] IntPtr hWnd, [MarshalAs(UnmanagedType.Bool)] bool bInvert);

		[DllImport("user32.dll", EntryPoint = "FindWindow")]
		public static extern IntPtr FindWindow([In] string lpClassName, [In] string lpWindowName);

		[DllImport("user32.dll", EntryPoint = "EnumWindows")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool EnumWindows(WNDENUMPROC lpEnumFunc, [MarshalAs(UnmanagedType.SysInt)] int lParam);

		[DllImport("user32.dll", EntryPoint = "DrawTextEx")]
		public static extern int DrawTextEx([In] IntPtr hdc, StringBuilder lpchText, int cchText, ref RECT lprc, uint format, [In] IntPtr lpdtp);

		[DllImport("user32.dll", EntryPoint = "DrawMenuBar")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool DrawMenuBar([In] IntPtr hWnd);

		[DllImport("user32.dll", EntryPoint = "DrawCaption")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool DrawCaption([In] IntPtr hwnd, [In] IntPtr hdc, [In] ref RECT lprect, DC flags);

		[DllImport("user32.dll", EntryPoint = "DlgDirList")]
		public static extern int DlgDirList([In] IntPtr hDlg, IntPtr lpPathSpec, int nIDListBox, int nIDStaticPath, uint uFileType);

		[DllImport("user32.dll", EntryPoint = "DestroyMenu")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool DestroyMenu([In] IntPtr hMenu);

		[DllImport("user32.dll", EntryPoint = "DestroyIcon")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool DestroyIcon([In] IntPtr hIcon);

		[DllImport("user32.dll", EntryPoint = "DefDlgProc")]
		[return: MarshalAs(UnmanagedType.SysInt)]
		public static extern int DefDlgProc(
			[In] IntPtr hDlg, uint Msg, [MarshalAs(UnmanagedType.SysUInt)] uint wParam, [MarshalAs(UnmanagedType.SysInt)] int lParam);

		[DllImport("user32.dll", EntryPoint = "CreateCaret")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool CreateCaret([In] IntPtr hWnd, [In] IntPtr hBitmap, int nWidth, int nHeight);

		[DllImport("user32.dll", EntryPoint = "CloseWindow")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool CloseWindow([In] IntPtr hWnd);

		[DllImport("user32.dll", EntryPoint = "CharPrevEx")]
		[return: MarshalAs(UnmanagedType.LPStr)]
		public static extern string CharPrevEx(
			CP CodePage, [In] string lpStart, [In] [MarshalAs(UnmanagedType.LPStr)] string lpCurrentChar, uint dwFlags);

		[DllImport("user32.dll", EntryPoint = "CharNextEx")]
		[return: MarshalAs(UnmanagedType.LPStr)]
		public static extern string CharNextEx(CP CodePage, [In] [MarshalAs(UnmanagedType.LPStr)] string lpCurrentChar, uint dwFlags);

		[DllImport("user32.dll", EntryPoint = "ChangeMenu")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool ChangeMenu([In] IntPtr hMenu, uint cmd, [In] string lpszNewItem, uint cmdInsert, MF flags);

		[DllImport("user32.dll", EntryPoint = "AppendMenu")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool AppendMenu([In] IntPtr hMenu, MF uFlags, [MarshalAs(UnmanagedType.SysUInt)] uint uIDNewItem, [In] string lpNewItem);

		[DllImport("user32.dll", EntryPoint = "wvsprintf")]
		public static extern int wvsprintf(
			[Out] StringBuilder param0, [In] string param1, [In] [MarshalAs(UnmanagedType.LPStr)] string arglist);

		[DllImport("user32.dll", EntryPoint = "VkKeyScan")]
		public static extern short VkKeyScan(char ch);

		[DllImport("user32.dll", EntryPoint = "ShowWindow")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool ShowWindow([In] IntPtr hWnd, int nCmdShow);

		[DllImport("user32.dll", EntryPoint = "ShowCursor")]
		public static extern int ShowCursor([MarshalAs(UnmanagedType.Bool)] bool bShow);

		[DllImport("user32.dll", EntryPoint = "SetCapture")]
		public static extern IntPtr SetCapture([In] IntPtr hWnd);

		[DllImport("user32.dll", EntryPoint = "RemoveMenu")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool RemoveMenu([In] IntPtr hMenu, uint uPosition, MF uFlags);

		[DllImport("user32.dll", EntryPoint = "OffsetRect")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool OffsetRect(ref RECT lprc, int dx, int dy);

		[DllImport("user32.dll", EntryPoint = "OemToChar")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool OemToChar([In] [MarshalAs(UnmanagedType.LPStr)] string lpszSrc, [Out] StringBuilder lpszDst);

		[DllImport("user32.dll", EntryPoint = "OemKeyScan")]
		public static extern uint OemKeyScan(ushort wOemChar);

		[DllImport("user32.dll", EntryPoint = "MoveWindow")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool MoveWindow([In] IntPtr hWnd, int X, int Y, int nWidth, int nHeight, [MarshalAs(UnmanagedType.Bool)] bool bRepaint);

		[DllImport("user32.dll", EntryPoint = "LoadImage")]
		public static extern IntPtr LoadImage([In] IntPtr hInst, [In] string name, uint type, int cx, int cy, uint fuLoad);

		[DllImport("user32.dll", EntryPoint = "InvertRect")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool InvertRect([In] IntPtr hDC, [In] ref RECT lprc);

		[DllImport("user32.dll", EntryPoint = "GetSubMenu")]
		public static extern IntPtr GetSubMenu([In] IntPtr hMenu, int nPos);

		[DllImport("user32.dll", EntryPoint = "GetDlgItem")]
		public static extern IntPtr GetDlgItem([In] IntPtr hDlg, int nIDDlgItem);

		[DllImport("user32.dll", EntryPoint = "GetCapture")]
		public static extern IntPtr GetCapture();

		[DllImport("user32.dll", EntryPoint = "EnumProps")]
		public static extern int EnumProps([In] IntPtr hWnd, PROPENUMPROC lpEnumFunc);

		[DllImport("user32.dll", EntryPoint = "DrawState")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool DrawState(
			[In] IntPtr hdc, [In] IntPtr hbrFore, DRAWSTATEPROC qfnCallBack, [MarshalAs(UnmanagedType.SysInt)] int lData,
			[MarshalAs(UnmanagedType.SysUInt)] uint wData, int x, int y, int cx, int cy, uint uFlags);

		[DllImport("user32.dll", EntryPoint = "DrawIconEx")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool DrawIconEx(
			[In] IntPtr hdc, int xLeft, int yTop, [In] IntPtr hIcon, int cxWidth, int cyWidth, uint istepIfAniCur, [In] IntPtr hbrFlickerFreeDraw, DI diFlags);

		[DllImport("user32.dll", EntryPoint = "DragObject")]
		public static extern uint DragObject([In] IntPtr hwndParent, [In] IntPtr hwndFrom, uint fmt, uint data, [In] IntPtr hcur);

		[DllImport("user32.dll", EntryPoint = "DragDetect")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool DragDetect([In] IntPtr hwnd, POINT pt);

		[DllImport("user32.dll", EntryPoint = "DeleteMenu")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool DeleteMenu([In] IntPtr hMenu, uint uPosition, MF uFlags);

		[DllImport("user32.dll", EntryPoint = "DdeGetData")]
		public static extern uint DdeGetData(IntPtr hData, ref byte pDst, uint cbMax, uint cbOff);

		[DllImport("user32.dll", EntryPoint = "DdeConnect")]
		public static extern IntPtr DdeConnect(uint idInst, IntPtr hszService, IntPtr hszTopic, ref CONVCONTEXT pCC);

		[DllImport("user32.dll", EntryPoint = "DdeAddData")]
		public static extern IntPtr DdeAddData(IntPtr hData, ref byte pSrc, uint cb, uint cbOff);

		[DllImport("user32.dll", EntryPoint = "CreateMenu")]
		public static extern IntPtr CreateMenu();

		[DllImport("user32.dll", EntryPoint = "CreateIcon")]
		public static extern IntPtr CreateIcon(
			[In] IntPtr hInstance, int nWidth, int nHeight, byte cPlanes, byte cBitsPixel, [In] ref byte lpbANDbits, [In] ref byte lpbXORbits);

		[DllImport("user32.dll", EntryPoint = "ClipCursor")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool ClipCursor([In] IntPtr lpRect);

		[DllImport("user32.dll", EntryPoint = "CharUpper")]
		public static extern string CharUpper(IntPtr lpsz);

		[DllImport("user32.dll", EntryPoint = "CharToOem")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool CharToOem([In] string lpszSrc, [Out] [MarshalAs(UnmanagedType.LPStr)] StringBuilder lpszDst);

		[DllImport("user32.dll", EntryPoint = "CharLower")]
		public static extern string CharLower(IntPtr lpsz);

		[DllImport("user32.dll", EntryPoint = "BeginPaint")]
		public static extern IntPtr BeginPaint([In] IntPtr hWnd, [Out] out PAINTSTRUCT lpPaint);

		[DllImport("user32.dll", EntryPoint = "UnionRect")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool UnionRect([Out] out RECT lprcDst, [In] ref RECT lprcSrc1, [In] ref RECT lprcSrc2);

		[DllImport("user32.dll", EntryPoint = "ToUnicode")]
		public static extern int ToUnicode(
			uint wVirtKey, uint wScanCode, [In] IntPtr lpKeyState, [Out] [MarshalAs(UnmanagedType.LPWStr)] StringBuilder pwszBuff, int cchBuff, TU wFlags);

		[DllImport("user32.dll", EntryPoint = "ToAsciiEx")]
		public static extern int ToAsciiEx(uint uVirtKey, uint uScanCode, [In] IntPtr lpKeyState, [Out] out ushort lpChar, TA uFlags, [In] IntPtr dwhkl);

		[DllImport("user32.dll", EntryPoint = "ShowCaret")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool ShowCaret([In] IntPtr hWnd);

		[DllImport("user32.dll", EntryPoint = "SetParent")]
		public static extern IntPtr SetParent([In] IntPtr hWndChild, [In] IntPtr hWndNewParent);

		[DllImport("user32.dll", EntryPoint = "SetCursor")]
		public static extern IntPtr SetCursor([In] IntPtr hCursor);

		[DllImport("user32.dll", EntryPoint = "SendInput")]
		public static extern uint SendInput(
			uint cInputs, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 0)] INPUT[] pInputs, int cbSize);

		[DllImport("user32.dll", EntryPoint = "ReleaseDC")]
		public static extern int ReleaseDC([In] IntPtr hWnd, [In] IntPtr hDC);

		[DllImport("user32.dll", EntryPoint = "LoadMenu")]
		public static extern IntPtr LoadMenu([In] IntPtr hInstance, [In] string lpMenuName);

		[DllImport("user32.dll", EntryPoint = "LoadIcon")]
		public static extern IntPtr LoadIcon([In] IntPtr hInstance, [In] string lpIconName);

		[DllImport("user32.dll", EntryPoint = "KillTimer")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool KillTimer([In] IntPtr hWnd, [MarshalAs(UnmanagedType.SysUInt)] uint uIDEvent);

		[DllImport("user32.dll", EntryPoint = "HideCaret")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool HideCaret([In] IntPtr hWnd);

		[DllImport("user32.dll", EntryPoint = "GetWindow")]
		public static extern IntPtr GetWindow([In] IntPtr hWnd, GW uCmd);

		[DllImport("user32.dll", EntryPoint = "GetParent")]
		public static extern IntPtr GetParent([In] IntPtr hWnd);

		[DllImport("user32.dll", EntryPoint = "GetCursor")]
		public static extern IntPtr GetCursor();

		[DllImport("user32.dll", EntryPoint = "FrameRect")]
		public static extern int FrameRect([In] IntPtr hDC, [In] ref RECT lprc, [In] IntPtr hbr);

		[DllImport("user32.dll", EntryPoint = "EqualRect")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool EqualRect([In] ref RECT lprc1, [In] ref RECT lprc2);

		[DllImport("user32.dll", EntryPoint = "EndDialog")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool EndDialog([In] IntPtr hDlg, int nResult);

		[DllImport("user32.dll", EntryPoint = "DrawText")]
		public static extern int DrawText([In] IntPtr hdc, StringBuilder lpchText, int cchText, ref RECT lprc, uint format);

		[DllImport("user32.dll", EntryPoint = "CopyImage")]
		public static extern IntPtr CopyImage([In] IntPtr h, uint type, int cx, int cy, LR flags);

		[DllImport("user32.dll", EntryPoint = "CharPrev")]
		public static extern string CharPrev([In] string lpszStart, [In] string lpszCurrent);

		[DllImport("user32.dll", EntryPoint = "CharNext")]
		public static extern string CharNext([In] string lpsz);

		[DllImport("user32.dll", EntryPoint = "WinHelp")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool WinHelp([In] IntPtr hWndMain, [In] string lpszHelp, uint uCommand, uint dwData);

		[DllImport("user32.dll", EntryPoint = "SetTimer")]
		[return: MarshalAs(UnmanagedType.SysUInt)]
		public static extern uint SetTimer([In] IntPtr hWnd, [MarshalAs(UnmanagedType.SysUInt)] uint nIDEvent, uint uElapse, TIMERPROC lpTimerFunc);

		[DllImport("user32.dll", EntryPoint = "SetProp")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetProp([In] IntPtr hWnd, [In] string lpString, [In] IntPtr hData);

		[DllImport("user32.dll", EntryPoint = "SetFocus")]
		public static extern IntPtr SetFocus([In] IntPtr hWnd);

		[DllImport("user32.dll", EntryPoint = "ScrollDC")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool ScrollDC(
			[In] IntPtr hDC, int dx, int dy, [In] IntPtr lprcScroll, [In] IntPtr lprcClip, [In] IntPtr hrgnUpdate, IntPtr lprcUpdate);

		[DllImport("user32.dll", EntryPoint = "PtInRect")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool PtInRect([In] ref RECT lprc, POINT pt);

		[DllImport("user32.dll", EntryPoint = "OpenIcon")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool OpenIcon([In] IntPtr hWnd);

		[DllImport("user32.dll", EntryPoint = "IsZoomed")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool IsZoomed([In] IntPtr hWnd);

		[DllImport("user32.dll", EntryPoint = "IsWindow")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool IsWindow([In] IntPtr hWnd);

		[DllImport("user32.dll", EntryPoint = "IsIconic")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool IsIconic([In] IntPtr hWnd);

		[DllImport("user32.dll", EntryPoint = "GetProp")]
		public static extern IntPtr GetProp([In] IntPtr hWnd, [In] string lpString);

		[DllImport("user32.dll", EntryPoint = "GetFocus")]
		public static extern IntPtr GetFocus();

		[DllImport("user32.dll", EntryPoint = "FillRect")]
		public static extern int FillRect([In] IntPtr hDC, [In] ref RECT lprc, [In] IntPtr hbr);

		[DllImport("user32.dll", EntryPoint = "EndPaint")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool EndPaint([In] IntPtr hWnd, [In] ref PAINTSTRUCT lpPaint);

		[DllImport("user32.dll", EntryPoint = "DrawIcon")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool DrawIcon([In] IntPtr hDC, int X, int Y, [In] IntPtr hIcon);

		[DllImport("user32.dll", EntryPoint = "DrawEdge")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool DrawEdge([In] IntPtr hdc, ref RECT qrc, uint edge, BF grfFlags);

		[DllImport("user32.dll", EntryPoint = "CopyRect")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool CopyRect([Out] out RECT lprcDst, [In] ref RECT lprcSrc);

		[DllImport("user32.dll", EntryPoint = "CopyIcon")]
		public static extern IntPtr CopyIcon([In] IntPtr hIcon);

		[DllImport("user32.dll", EntryPoint = "AnyPopup")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool AnyPopup();

		[DllImport("user32.dll", EntryPoint = "ToAscii")]
		public static extern int ToAscii(uint uVirtKey, uint uScanCode, [In] IntPtr lpKeyState, [Out] out ushort lpChar, TA uFlags);

		[DllImport("user32.dll", EntryPoint = "SetRect")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetRect([Out] out RECT lprc, int xLeft, int yTop, int xRight, int yBottom);

		[DllImport("user32.dll", EntryPoint = "SetMenu")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetMenu([In] IntPtr hWnd, [In] IntPtr hMenu);

		[DllImport("user32.dll", EntryPoint = "IsChild")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool IsChild([In] IntPtr hWndParent, [In] IntPtr hWnd);

		[DllImport("user32.dll", EntryPoint = "GetMenu")]
		public static extern IntPtr GetMenu([In] IntPtr hWnd);

		[DllImport("user32.dll", EntryPoint = "GetDCEx")]
		public static extern IntPtr GetDCEx([In] IntPtr hWnd, [In] IntPtr hrgnClip, DCX flags);

		[DllImport("user32.dll", EntryPoint = "EndMenu")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool EndMenu();

		[DllImport("user32.dll", EntryPoint = "IsMenu")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool IsMenu([In] IntPtr hMenu);

		[DllImport("user32.dll", EntryPoint = "GetDC")]
		public static extern IntPtr GetDC([In] IntPtr hWnd);
	}

	// ReSharper restore InconsistentNaming
}