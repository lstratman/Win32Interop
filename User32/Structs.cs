using System;
using System.Drawing;
using System.Runtime.InteropServices;
using Win32Interop.Enums;
using Win32Interop.Methods;

// ReSharper disable CheckNamespace

namespace Win32Interop.Structs
// ReSharper restore CheckNamespace
{
	// ReSharper disable InconsistentNaming
	[StructLayout(LayoutKind.Sequential)]
	public struct POINT
	{
		/// LONG->int
		public int x;

		/// LONG->int
		public int y;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct SECURITY_QUALITY_OF_SERVICE
	{
		/// DWORD->unsigned int
		public uint Length;

		/// SECURITY_IMPERSONATION_LEVEL->_SECURITY_IMPERSONATION_LEVEL
		public SECURITY_IMPERSONATION_LEVEL ImpersonationLevel;

		/// SECURITY_CONTEXT_TRACKING_MODE->BOOLEAN->BYTE->unsigned char
		public byte ContextTrackingMode;

		/// BOOLEAN->BYTE->unsigned char
		public byte EffectiveOnly;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct SIZE
	{
		/// LONG->int
		public int cx;

		/// LONG->int
		public int cy;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct BLENDFUNCTION
	{
		/// BYTE->unsigned char
		public byte BlendOp;

		/// BYTE->unsigned char
		public byte BlendFlags;

		/// BYTE->unsigned char
		public byte SourceConstantAlpha;

		/// BYTE->unsigned char
		public byte AlphaFormat;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct MSGBOXPARAMS
	{
		/// UINT->unsigned int
		public uint cbSize;

		/// HWND->HWND__*
		public IntPtr hwndOwner;

		/// HINSTANCE->HINSTANCE__*
		public IntPtr hInstance;

		/// LPCWSTR->WCHAR*
		[MarshalAs(UnmanagedType.LPTStr)]
		public string lpszText;

		/// LPCWSTR->WCHAR*
		[MarshalAs(UnmanagedType.LPTStr)]
		public string lpszCaption;

		/// DWORD->unsigned int
		public uint dwStyle;

		/// LPCWSTR->WCHAR*
		[MarshalAs(UnmanagedType.LPTStr)]
		public string lpszIcon;

		/// DWORD_PTR->ULONG_PTR->unsigned int
		public uint dwContextHelpId;

		/// MSGBOXCALLBACK
		public MsgBoxCallback lpfnMsgBoxCallback;

		/// DWORD->unsigned int
		public uint dwLanguageId;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct WINDOWPLACEMENT
	{
		/// UINT->unsigned int
		public uint length;

		/// UINT->unsigned int
		public uint flags;

		/// UINT->unsigned int
		public uint showCmd;

		/// POINT->tagPOINT
		public POINT ptMinPosition;

		/// POINT->tagPOINT
		public POINT ptMaxPosition;

		/// RECT->tagRECT
		public RECT rcNormalPosition;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct RECT
	{
		/// LONG->int
		public int left;

		/// LONG->int
		public int top;

		/// LONG->int
		public int right;

		/// LONG->int
		public int bottom;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct MSG
	{
		/// HWND->HWND__*
		public IntPtr hwnd;

		/// UINT->unsigned int
		public WM message;

		/// WPARAM->UINT_PTR->unsigned int
		public uint wParam;

		/// LPARAM->LONG_PTR->int
		public int lParam;

		/// DWORD->unsigned int
		public uint time;

		/// POINT->tagPOINT
		public POINT pt;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct WNDCLASSEX
	{
		/// UINT->unsigned int
		public uint cbSize;

		/// UINT->unsigned int
		public uint style;

		/// WNDPROC
		public WindowProc lpfnWndProc;

		/// int
		public int cbClsExtra;

		/// int
		public int cbWndExtra;

		/// HINSTANCE->HINSTANCE__*
		public IntPtr hInstance;

		/// HICON->HICON__*
		public IntPtr hIcon;

		/// HCURSOR->HICON->HICON__*
		public IntPtr hCursor;

		/// HBRUSH->HBRUSH__*
		public IntPtr hbrBackground;

		/// LPCWSTR->WCHAR*
		[MarshalAs(UnmanagedType.LPTStr)]
		public string lpszMenuName;

		/// LPCWSTR->WCHAR*
		[MarshalAs(UnmanagedType.LPTStr)]
		public string lpszClassName;

		/// HICON->HICON__*
		public IntPtr hIconSm;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct WNDCLASS
	{
		/// UINT->unsigned int
		public uint style;

		/// WNDPROC
		public WindowProc lpfnWndProc;

		/// int
		public int cbClsExtra;

		/// int
		public int cbWndExtra;

		/// HINSTANCE->HINSTANCE__*
		public IntPtr hInstance;

		/// HICON->HICON__*
		public IntPtr hIcon;

		/// HCURSOR->HICON->HICON__*
		public IntPtr hCursor;

		/// HBRUSH->HBRUSH__*
		public IntPtr hbrBackground;

		/// LPCWSTR->WCHAR*
		[MarshalAs(UnmanagedType.LPTStr)]
		public string lpszMenuName;

		/// LPCWSTR->WCHAR*
		[MarshalAs(UnmanagedType.LPTStr)]
		public string lpszClassName;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct PAINTSTRUCT
	{
		/// HDC->HDC__*
		public IntPtr hdc;

		/// BOOL->int
		[MarshalAs(UnmanagedType.Bool)]
		public bool fErase;

		/// RECT->tagRECT
		public RECT rcPaint;

		/// BOOL->int
		[MarshalAs(UnmanagedType.Bool)]
		public bool fRestore;

		/// BOOL->int
		[MarshalAs(UnmanagedType.Bool)]
		public bool fIncUpdate;

		/// BYTE[32]
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
		public byte[] rgbReserved;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct RAWINPUTDEVICE
	{
		/// USHORT->unsigned short
		public ushort usUsagePage;

		/// USHORT->unsigned short
		public ushort usUsage;

		/// DWORD->unsigned int
		public uint dwFlags;

		/// HWND->HWND__*
		public IntPtr hwndTarget;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct BSMINFO
	{
		/// UINT->unsigned int
		public uint cbSize;

		/// HDESK->HDESK__*
		public IntPtr hdesk;

		/// HWND->HWND__*
		public IntPtr hwnd;

		/// LUID->_LUID
		public LUID luid;
	}

	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public struct DEVMODE
	{
		public const int CCHDEVICENAME = 32;
		public const int CCHFORMNAME = 32;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CCHDEVICENAME)]
		[FieldOffset(0)]
		public string dmDeviceName;
		[FieldOffset(32)]
		public Int16 dmSpecVersion;
		[FieldOffset(34)]
		public Int16 dmDriverVersion;
		[FieldOffset(36)]
		public Int16 dmSize;
		[FieldOffset(38)]
		public Int16 dmDriverExtra;
		[FieldOffset(40)]
		public Int32 dmFields;

		[FieldOffset(44)]
		Int16 dmOrientation;
		[FieldOffset(46)]
		Int16 dmPaperSize;
		[FieldOffset(48)]
		Int16 dmPaperLength;
		[FieldOffset(50)]
		Int16 dmPaperWidth;
		[FieldOffset(52)]
		Int16 dmScale;
		[FieldOffset(54)]
		Int16 dmCopies;
		[FieldOffset(56)]
		Int16 dmDefaultSource;
		[FieldOffset(58)]
		Int16 dmPrintQuality;

		[FieldOffset(44)]
		public POINTL dmPosition;
		[FieldOffset(52)]
		public Int32 dmDisplayOrientation;
		[FieldOffset(56)]
		public Int32 dmDisplayFixedOutput;

		[FieldOffset(60)]
		public short dmColor;
		[FieldOffset(62)]
		public short dmDuplex;
		[FieldOffset(64)]
		public short dmYResolution;
		[FieldOffset(66)]
		public short dmTTOption;
		[FieldOffset(68)]
		public short dmCollate;
		[FieldOffset(72)]
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CCHFORMNAME)]
		public string dmFormName;
		[FieldOffset(102)]
		public Int16 dmLogPixels;
		[FieldOffset(104)]
		public Int32 dmBitsPerPel;
		[FieldOffset(108)]
		public Int32 dmPelsWidth;
		[FieldOffset(112)]
		public Int32 dmPelsHeight;
		[FieldOffset(116)]
		public Int32 dmDisplayFlags;
		[FieldOffset(116)]
		public Int32 dmNup;
		[FieldOffset(120)]
		public Int32 dmDisplayFrequency;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct ACCEL
	{
		/// BYTE->unsigned char
		public byte fVirt;

		/// WORD->unsigned short
		public ushort key;

		/// WORD->unsigned short
		public ushort cmd;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct RAWINPUTDEVICELIST
	{
		/// HANDLE->void*
		public IntPtr hDevice;

		/// DWORD->unsigned int
		public uint dwType;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct MOUSEMOVEPOINT
	{
		/// int
		public int x;

		/// int
		public int y;

		/// DWORD->unsigned int
		public uint time;

		/// ULONG_PTR->unsigned int
		public uint dwExtraInfo;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct SECURITY_ATTRIBUTES
	{
		/// DWORD->unsigned int
		public uint nLength;

		/// LPVOID->void*
		public IntPtr lpSecurityDescriptor;

		/// BOOL->int
		[MarshalAs(UnmanagedType.Bool)]
		public bool bInheritHandle;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct DISPLAY_DEVICE
	{
		/// DWORD->unsigned int
		public uint cb;

		/// WCHAR[32]
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
		public string DeviceName;

		/// WCHAR[128]
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
		public string DeviceString;

		/// DWORD->unsigned int
		public uint StateFlags;

		/// WCHAR[128]
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
		public string DeviceID;

		/// WCHAR[128]
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
		public string DeviceKey;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct RAWINPUT
	{
		/// RAWINPUTHEADER->tagRAWINPUTHEADER
		public RAWINPUTHEADER header;

		/// Anonymous_d34c77ee_53b2_47a5_a97c_d5c2b29c8ee3
		public RAW_INPUT_DATA data;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct SCROLLBARINFO
	{
		/// DWORD->unsigned int
		public uint cbSize;

		/// RECT->tagRECT
		public RECT rcScrollBar;

		/// int
		public int dxyLineButton;

		/// int
		public int xyThumbTop;

		/// int
		public int xyThumbBottom;

		/// int
		public int reserved;

		/// DWORD[6]
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.U4)]
		public uint[] rgstate;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct MENUITEMINFO
	{
		/// UINT->unsigned int
		public uint cbSize;

		/// UINT->unsigned int
		public uint fMask;

		/// UINT->unsigned int
		public uint fType;

		/// UINT->unsigned int
		public uint fState;

		/// UINT->unsigned int
		public uint wID;

		/// HMENU->HMENU__*
		public IntPtr hSubMenu;

		/// HBITMAP->HBITMAP__*
		public IntPtr hbmpChecked;

		/// HBITMAP->HBITMAP__*
		public IntPtr hbmpUnchecked;

		/// ULONG_PTR->unsigned int
		public uint dwItemData;

		/// LPWSTR->WCHAR*
		[MarshalAs(UnmanagedType.LPTStr)]
		public string dwTypeData;

		/// UINT->unsigned int
		public uint cch;

		/// HBITMAP->HBITMAP__*
		public IntPtr hbmpItem;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct LASTINPUTINFO
	{
		/// UINT->unsigned int
		public uint cbSize;

		/// DWORD->unsigned int
		public uint dwTime;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct GUITHREADINFO
	{
		/// DWORD->unsigned int
		public uint cbSize;

		/// DWORD->unsigned int
		public uint flags;

		/// HWND->HWND__*
		public IntPtr hwndActive;

		/// HWND->HWND__*
		public IntPtr hwndFocus;

		/// HWND->HWND__*
		public IntPtr hwndCapture;

		/// HWND->HWND__*
		public IntPtr hwndMenuOwner;

		/// HWND->HWND__*
		public IntPtr hwndMoveSize;

		/// HWND->HWND__*
		public IntPtr hwndCaret;

		/// RECT->tagRECT
		public RECT rcCaret;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct TRACKMOUSEEVENT
	{
		/// DWORD->unsigned int
		public uint cbSize;

		/// DWORD->unsigned int
		public uint dwFlags;

		/// HWND->HWND__*
		public IntPtr hwndTrack;

		/// DWORD->unsigned int
		public uint dwHoverTime;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct TITLEBARINFO
	{
		/// DWORD->unsigned int
		public uint cbSize;

		/// RECT->tagRECT
		public RECT rcTitleBar;

		/// DWORD[6]
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.U4)]
		public uint[] rgstate;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct MONITORINFO
	{
		/// DWORD->unsigned int
		public uint cbSize;

		/// RECT->tagRECT
		public RECT rcMonitor;

		/// RECT->tagRECT
		public RECT rcWork;

		/// DWORD->unsigned int
		public uint dwFlags;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct COMBOBOXINFO
	{
		/// DWORD->unsigned int
		public uint cbSize;

		/// RECT->tagRECT
		public RECT rcItem;

		/// RECT->tagRECT
		public RECT rcButton;

		/// DWORD->unsigned int
		public uint stateButton;

		/// HWND->HWND__*
		public IntPtr hwndCombo;

		/// HWND->HWND__*
		public IntPtr hwndItem;

		/// HWND->HWND__*
		public IntPtr hwndList;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct MENUBARINFO
	{
		/// DWORD->unsigned int
		public uint cbSize;

		/// RECT->tagRECT
		public RECT rcBar;

		/// HMENU->HMENU__*
		public IntPtr hMenu;

		/// HWND->HWND__*
		public IntPtr hwndMenu;

		/// fBarFocused : 1
		/// fFocused : 1
		public uint bitvector1;

		public uint fBarFocused
		{
			get
			{
				return bitvector1 & 1u;
			}

			set
			{
				bitvector1 = value | bitvector1;
			}
		}

		public uint fFocused
		{
			get
			{
				return (bitvector1 & 2u) / 2;
			}

			set
			{
				bitvector1 = (value * 2) | bitvector1;
			}
		}
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct ALTTABINFO
	{
		/// DWORD->unsigned int
		public uint cbSize;

		/// int
		public int cItems;

		/// int
		public int cColumns;

		/// int
		public int cRows;

		/// int
		public int iColFocus;

		/// int
		public int iRowFocus;

		/// int
		public int cxItem;

		/// int
		public int cyItem;

		/// POINT->tagPOINT
		public POINT ptStart;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct WINDOWINFO
	{
		/// DWORD->unsigned int
		public uint cbSize;

		/// RECT->tagRECT
		public RECT rcWindow;

		/// RECT->tagRECT
		public RECT rcClient;

		/// DWORD->unsigned int
		public uint dwStyle;

		/// DWORD->unsigned int
		public uint dwExStyle;

		/// DWORD->unsigned int
		public uint dwWindowStatus;

		/// UINT->unsigned int
		public uint cxWindowBorders;

		/// UINT->unsigned int
		public uint cyWindowBorders;

		/// ATOM->WORD->unsigned short
		public ushort atomWindowType;

		/// WORD->unsigned short
		public ushort wCreatorVersion;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct SCROLLINFO
	{
		/// UINT->unsigned int
		public uint cbSize;

		/// UINT->unsigned int
		public uint fMask;

		/// int
		public int nMin;

		/// int
		public int nMax;

		/// UINT->unsigned int
		public uint nPage;

		/// int
		public int nPos;

		/// int
		public int nTrackPos;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct CURSORINFO
	{
		/// DWORD->unsigned int
		public uint cbSize;

		/// DWORD->unsigned int
		public uint flags;

		/// HCURSOR->HICON->HICON__*
		public IntPtr hCursor;

		/// POINT->tagPOINT
		public POINT ptScreenPos;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct FLASHWINFO
	{
		/// UINT->unsigned int
		public uint cbSize;

		/// HWND->HWND__*
		public IntPtr hwnd;

		/// DWORD->unsigned int
		public uint dwFlags;

		/// UINT->unsigned int
		public uint uCount;

		/// DWORD->unsigned int
		public uint dwTimeout;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct MENUINFO
	{
		/// DWORD->unsigned int
		public uint cbSize;

		/// DWORD->unsigned int
		public uint fMask;

		/// DWORD->unsigned int
		public uint dwStyle;

		/// UINT->unsigned int
		public uint cyMax;

		/// HBRUSH->HBRUSH__*
		public IntPtr hbrBack;

		/// DWORD->unsigned int
		public uint dwContextHelpID;

		/// ULONG_PTR->unsigned int
		public uint dwMenuData;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct DRAWTEXTPARAMS
	{
		/// UINT->unsigned int
		public uint cbSize;

		/// int
		public int iTabLength;

		/// int
		public int iLeftMargin;

		/// int
		public int iRightMargin;

		/// UINT->unsigned int
		public uint uiLengthDrawn;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct INPUT
	{
		/// DWORD->unsigned int
		public uint type;

		/// Anonymous_dccf47da_5155_438b_92bc_41adbefe840c
		public INPUT_DATA inputData;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct DLGTEMPLATE
	{
		/// DWORD->unsigned int
		public uint style;

		/// DWORD->unsigned int
		public uint dwExtendedStyle;

		/// WORD->unsigned short
		public ushort cdit;

		/// short
		public short x;

		/// short
		public short y;

		/// short
		public short cx;

		/// short
		public short cy;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct ICONINFO
	{
		/// BOOL->int
		[MarshalAs(UnmanagedType.Bool)]
		public bool fIcon;

		/// DWORD->unsigned int
		public uint xHotspot;

		/// DWORD->unsigned int
		public uint yHotspot;

		/// HBITMAP->HBITMAP__*
		public IntPtr hbmMask;

		/// HBITMAP->HBITMAP__*
		public IntPtr hbmColor;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct TPMPARAMS
	{
		/// UINT->unsigned int
		public uint cbSize;

		/// RECT->tagRECT
		public RECT rcExclude;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct CONVINFO
	{
		/// DWORD->unsigned int
		public uint cb;

		/// DWORD_PTR->ULONG_PTR->unsigned int
		public uint hUser;

		/// HCONV->HCONV__*
		public IntPtr hConvPartner;

		/// HSZ->HSZ__*
		public IntPtr hszSvcPartner;

		/// HSZ->HSZ__*
		public IntPtr hszServiceReq;

		/// HSZ->HSZ__*
		public IntPtr hszTopic;

		/// HSZ->HSZ__*
		public IntPtr hszItem;

		/// UINT->unsigned int
		public uint wFmt;

		/// UINT->unsigned int
		public uint wType;

		/// UINT->unsigned int
		public uint wStatus;

		/// UINT->unsigned int
		public uint wConvst;

		/// UINT->unsigned int
		public uint wLastError;

		/// HCONVLIST->HCONVLIST__*
		public IntPtr hConvList;

		/// CONVCONTEXT->tagCONVCONTEXT
		public CONVCONTEXT ConvCtxt;

		/// HWND->HWND__*
		public IntPtr hwnd;

		/// HWND->HWND__*
		public IntPtr hwndPartner;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct CONVCONTEXT
	{
		/// UINT->unsigned int
		public uint cb;

		/// UINT->unsigned int
		public uint wFlags;

		/// UINT->unsigned int
		public uint wCountryID;

		/// int
		public int iCodePage;

		/// DWORD->unsigned int
		public uint dwLangID;

		/// DWORD->unsigned int
		public uint dwSecurity;

		/// SECURITY_QUALITY_OF_SERVICE->_SECURITY_QUALITY_OF_SERVICE
		public SECURITY_QUALITY_OF_SERVICE qos;
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct PAGE_DATA
	{
		/// Anonymous_865d3c92_fe8c_4ee6_9601_a9eb2536957e
		[FieldOffset(0)]
		public PAGE_SETUP pageSetup;

		/// Anonymous_1b5f787e_41ca_472c_8595_3484490ffe0c
		[FieldOffset(0)]
		public PAGE_DISPLAY pageDisplay;
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct DISPLAY_DATA
	{
		/// DWORD->unsigned int
		[FieldOffset(0)]
		public uint dmDisplayFlags;

		/// DWORD->unsigned int
		[FieldOffset(0)]
		public uint dmNup;
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct RAW_INPUT_DATA
	{
		/// RAWMOUSE->tagRAWMOUSE
		[FieldOffset(0)]
		public RAWMOUSE mouse;

		/// RAWKEYBOARD->tagRAWKEYBOARD
		[FieldOffset(0)]
		public RAWKEYBOARD keyboard;

		/// RAWHID->tagRAWHID
		[FieldOffset(0)]
		public RAWHID hid;
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct INPUT_DATA
	{
		/// MOUSEINPUT->tagMOUSEINPUT
		[FieldOffset(0)]
		public MOUSEINPUT mi;

		/// KEYBDINPUT->tagKEYBDINPUT
		[FieldOffset(0)]
		public KEYBDINPUT ki;

		/// HARDWAREINPUT->tagHARDWAREINPUT
		[FieldOffset(0)]
		public HARDWAREINPUT hi;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct LUID
	{
		/// DWORD->unsigned int
		public uint LowPart;

		/// LONG->int
		public int HighPart;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct RAWINPUTHEADER
	{
		/// DWORD->unsigned int
		public uint dwType;

		/// DWORD->unsigned int
		public uint dwSize;

		/// HANDLE->void*
		public IntPtr hDevice;

		/// WPARAM->UINT_PTR->unsigned int
		public uint wParam;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct PAGE_SETUP
	{
		/// short
		public short dmOrientation;

		/// short
		public short dmPaperSize;

		/// short
		public short dmPaperLength;

		/// short
		public short dmPaperWidth;

		/// short
		public short dmScale;

		/// short
		public short dmCopies;

		/// short
		public short dmDefaultSource;

		/// short
		public short dmPrintQuality;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct PAGE_DISPLAY
	{
		/// POINTL->_POINTL
		public POINTL dmPosition;

		/// DWORD->unsigned int
		public uint dmDisplayOrientation;

		/// DWORD->unsigned int
		public uint dmDisplayFixedOutput;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct RAWMOUSE
	{
		/// USHORT->unsigned short
		public ushort usFlags;

		/// Anonymous_4e912b36_f5ab_4eb4_804f_6587b7a78602
		public BUTTONS buttons;

		/// ULONG->unsigned int
		public uint ulRawButtons;

		/// LONG->int
		public int lLastX;

		/// LONG->int
		public int lLastY;

		/// ULONG->unsigned int
		public uint ulExtraInformation;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct RAWKEYBOARD
	{
		/// USHORT->unsigned short
		public ushort MakeCode;

		/// USHORT->unsigned short
		public ushort Flags;

		/// USHORT->unsigned short
		public ushort Reserved;

		/// USHORT->unsigned short
		public ushort VKey;

		/// UINT->unsigned int
		public uint Message;

		/// ULONG->unsigned int
		public uint ExtraInformation;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct RAWHID
	{
		/// DWORD->unsigned int
		public uint dwSizeHid;

		/// DWORD->unsigned int
		public uint dwCount;

		/// BYTE[1]
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.I1)]
		public byte[] bRawData;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct MOUSEINPUT
	{
		/// LONG->int
		public int dx;

		/// LONG->int
		public int dy;

		/// DWORD->unsigned int
		public uint mouseData;

		/// DWORD->unsigned int
		public uint dwFlags;

		/// DWORD->unsigned int
		public uint time;

		/// ULONG_PTR->unsigned int
		public uint dwExtraInfo;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct KEYBDINPUT
	{
		/// WORD->unsigned short
		public ushort wVk;

		/// WORD->unsigned short
		public ushort wScan;

		/// DWORD->unsigned int
		public uint dwFlags;

		/// DWORD->unsigned int
		public uint time;

		/// ULONG_PTR->unsigned int
		public uint dwExtraInfo;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct HARDWAREINPUT
	{
		/// DWORD->unsigned int
		public uint uMsg;

		/// WORD->unsigned short
		public ushort wParamL;

		/// WORD->unsigned short
		public ushort wParamH;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct HELPINFO
	{
		/// UINT->unsigned int
		public uint cbSize;

		/// int
		public int iContextType;

		/// int
		public int iCtrlId;

		/// HANDLE->void*
		public IntPtr hItemHandle;

		/// DWORD_PTR->ULONG_PTR->unsigned int
		public uint dwContextId;

		/// POINT->tagPOINT
		public POINT MousePos;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct POINTL
	{
		/// LONG->int
		public int x;

		/// LONG->int
		public int y;
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct BUTTONS
	{
		/// ULONG->unsigned int
		[FieldOffset(0)]
		public uint ulButtons;

		/// Anonymous_500af501_b9b4_43cc_ad24_07d5d9d24897
		[FieldOffset(0)]
		public BUTTON_DATA buttonData;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct BUTTON_DATA
	{
		/// USHORT->unsigned short
		public ushort usButtonFlags;

		/// USHORT->unsigned short
		public ushort usButtonData;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct MSLLHOOKSTRUCT
	{
		public POINT pt;
		public int mouseData;
		public int flags;
		public int time;
		public UIntPtr dwExtraInfo;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
	public class TEXTMETRIC
	{
		public int tmHeight;
		public int tmAscent;
		public int tmDescent;
		public int tmInternalLeading;
		public int tmExternalLeading;
		public int tmAveCharWidth;
		public int tmMaxCharWidth;
		public int tmWeight;
		public int tmOverhang;
		public int tmDigitizedAspectX;
		public int tmDigitizedAspectY;
		public byte tmFirstChar;
		public byte tmLastChar;
		public byte tmDefaultChar;
		public byte tmBreakChar;
		public byte tmItalic;
		public byte tmUnderlined;
		public byte tmStruckOut;
		public byte tmPitchAndFamily;
		public byte tmCharSet;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct COLORREF
	{
		public uint ColorDWORD;

		public COLORREF(Color color)
		{
			ColorDWORD = color.R + (((uint) color.G) << 8) + (((uint) color.B) << 16);
		}

		public Color GetColor()
		{
			return Color.FromArgb(
				(int) (0x000000FFU & ColorDWORD),
				(int) (0x0000FF00U & ColorDWORD) >> 8, (int) (0x00FF0000U & ColorDWORD) >> 16);
		}

		public void SetColor(Color color)
		{
			ColorDWORD = color.R + (((uint) color.G) << 8) + (((uint) color.B) << 16);
		}
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct DEV_BROADCAST_HDR
	{
		/// DWORD->unsigned int
		public uint dbch_size;

		/// DWORD->unsigned int
		public DBT dbch_devicetype;

		/// DWORD->unsigned int
		public uint dbch_reserved;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct DLGITEMTEMPLATE
	{
		/// DWORD->unsigned int
		public uint style;

		/// DWORD->unsigned int
		public uint dwExtendedStyle;

		/// short
		public short x;

		/// short
		public short y;

		/// short
		public short cx;

		/// short
		public short cy;

		/// WORD->unsigned short
		public ushort id;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct DLGITEMTEMPLATEEX
	{
		/// DWORD->unsigned int
		public uint helpID;

		/// DWORD->unsigned int
		public uint exStyle;

		/// DWORD->unsigned int
		public uint style;

		/// short
		public short x;

		/// short
		public short y;

		/// short
		public short cx;

		/// short
		public short cy;

		/// DWORD->unsigned int
		public uint id;

		/// short[]
		public short[] windowClass;

		/// short[]
		public short[] title;

		/// WORD->unsigned short
		public ushort extraCount;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
	public struct DLGTEMPLATEEX
	{
		/// WORD->unsigned short
		public ushort dlgVer;

		/// WORD->unsigned short
		public ushort signature;

		/// DWORD->unsigned int
		public uint helpID;

		/// DWORD->unsigned int
		public uint exStyle;

		/// DWORD->unsigned int
		public uint style;

		/// WORD->unsigned short
		public ushort cDlgItems;

		/// short
		public short x;

		/// short
		public short y;

		/// short
		public short cx;

		/// short
		public short cy;

		/// short[]
		public short[] menu;

		/// short[]
		public short[] windowClass;

		/// WCHAR[]
		public string title;

		/// WORD->unsigned short
		public ushort pointsize;

		/// WORD->unsigned short
		public ushort weight;

		/// BYTE->unsigned char
		public byte italic;

		/// BYTE->unsigned char
		public byte charset;

		/// WCHAR[]
		public string typeface;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct USEROBJECTFLAGS
	{
		/// BOOL->int
		[MarshalAs(UnmanagedType.Bool)]
		public bool fInherit;

		/// BOOL->int
		[MarshalAs(UnmanagedType.Bool)]
		public bool fReserved;

		/// DWORD->unsigned int
		public uint dwFlags;
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct MOUSE_KEYBOARD_HID
	{
		/// RID_DEVICE_INFO_MOUSE->tagRID_DEVICE_INFO_MOUSE
		[FieldOffset(0)]
		public RID_DEVICE_INFO_MOUSE mouse;

		/// RID_DEVICE_INFO_KEYBOARD->tagRID_DEVICE_INFO_KEYBOARD
		[FieldOffset(0)]
		public RID_DEVICE_INFO_KEYBOARD keyboard;

		/// RID_DEVICE_INFO_HID->tagRID_DEVICE_INFO_HID
		[FieldOffset(0)]
		public RID_DEVICE_INFO_HID hid;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct RID_DEVICE_INFO
	{
		/// DWORD->unsigned int
		public uint cbSize;

		/// DWORD->unsigned int
		public uint dwType;

		/// Anonymous_b3e3df38_776a_40ee_9539_1851bbc299c6
		public MOUSE_KEYBOARD_HID mouseKeyboardHid;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct RID_DEVICE_INFO_MOUSE
	{
		/// DWORD->unsigned int
		public uint dwId;

		/// DWORD->unsigned int
		public uint dwNumberOfButtons;

		/// DWORD->unsigned int
		public uint dwSampleRate;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct RID_DEVICE_INFO_KEYBOARD
	{
		/// DWORD->unsigned int
		public uint dwType;

		/// DWORD->unsigned int
		public uint dwSubType;

		/// DWORD->unsigned int
		public uint dwKeyboardMode;

		/// DWORD->unsigned int
		public uint dwNumberOfFunctionKeys;

		/// DWORD->unsigned int
		public uint dwNumberOfIndicators;

		/// DWORD->unsigned int
		public uint dwNumberOfKeysTotal;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct RID_DEVICE_INFO_HID
	{
		/// DWORD->unsigned int
		public uint dwVendorId;

		/// DWORD->unsigned int
		public uint dwProductId;

		/// DWORD->unsigned int
		public uint dwVersionNumber;

		/// USHORT->unsigned short
		public ushort usUsagePage;

		/// USHORT->unsigned short
		public ushort usUsage;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct ACCESSTIMEOUT
	{
		/// UINT->unsigned int
		public uint cbSize;

		/// DWORD->unsigned int
		public uint dwFlags;

		/// DWORD->unsigned int
		public uint iTimeOutMSec;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct AUDIODESCRIPTION
	{
		/// UINT->unsigned int
		public uint cbSize;

		/// BOOL->int
		[MarshalAs(UnmanagedType.Bool)]
		public bool Enabled;

		/// LCID->DWORD->unsigned int
		public uint Locale;
	}

	[System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
	public struct FILTERKEYS
	{

		/// UINT->unsigned int
		public uint cbSize;

		/// DWORD->unsigned int
		public uint dwFlags;

		/// DWORD->unsigned int
		public uint iWaitMSec;

		/// DWORD->unsigned int
		public uint iDelayMSec;

		/// DWORD->unsigned int
		public uint iRepeatMSec;

		/// DWORD->unsigned int
		public uint iBounceMSec;
	}

	[System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
	public struct HIGHCONTRAST
	{

		/// UINT->unsigned int
		public uint cbSize;

		/// DWORD->unsigned int
		public uint dwFlags;

		/// LPWSTR->WCHAR*
		[System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPTStr)]
		public string lpszDefaultScheme;
	}

	[System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
	public struct MOUSEKEYS
	{

		/// UINT->unsigned int
		public uint cbSize;

		/// DWORD->unsigned int
		public uint dwFlags;

		/// DWORD->unsigned int
		public uint iMaxSpeed;

		/// DWORD->unsigned int
		public uint iTimeToMaxSpeed;

		/// DWORD->unsigned int
		public uint iCtrlSpeed;

		/// DWORD->unsigned int
		public uint dwReserved1;

		/// DWORD->unsigned int
		public uint dwReserved2;
	}

	[System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
	public struct SOUNDSENTRY
	{

		/// UINT->unsigned int
		public uint cbSize;

		/// DWORD->unsigned int
		public uint dwFlags;

		/// DWORD->unsigned int
		public uint iFSTextEffect;

		/// DWORD->unsigned int
		public uint iFSTextEffectMSec;

		/// DWORD->unsigned int
		public uint iFSTextEffectColorBits;

		/// DWORD->unsigned int
		public uint iFSGrafEffect;

		/// DWORD->unsigned int
		public uint iFSGrafEffectMSec;

		/// DWORD->unsigned int
		public uint iFSGrafEffectColor;

		/// DWORD->unsigned int
		public uint iWindowsEffect;

		/// DWORD->unsigned int
		public uint iWindowsEffectMSec;

		/// LPWSTR->WCHAR*
		[System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPTStr)]
		public string lpszWindowsEffectDLL;

		/// DWORD->unsigned int
		public uint iWindowsEffectOrdinal;
	}

	[System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
	public struct STICKYKEYS
	{

		/// UINT->unsigned int
		public uint cbSize;

		/// DWORD->unsigned int
		public uint dwFlags;
	}


	[System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
	public struct TOGGLEKEYS
	{

		/// UINT->unsigned int
		public uint cbSize;

		/// DWORD->unsigned int
		public uint dwFlags;
	}

	[System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
	public struct ICONMETRICS
	{

		/// UINT->unsigned int
		public uint cbSize;

		/// int
		public int iHorzSpacing;

		/// int
		public int iVertSpacing;

		/// int
		public int iTitleWrap;

		/// LOGFONTW->tagLOGFONTW
		public LOGFONT lfFont;
	}

	[System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
	public struct ANIMATIONINFO
	{

		/// UINT->unsigned int
		public uint cbSize;

		/// int
		public int iMinAnimate;
	}

	[System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
	public struct MINIMIZEDMETRICS
	{

		/// UINT->unsigned int
		public uint cbSize;

		/// int
		public int iWidth;

		/// int
		public int iHorzGap;

		/// int
		public int iVertGap;

		/// int
		public int iArrange;
	}

	[System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
	public struct MENUITEMTEMPLATEHEADER
	{

		/// WORD->unsigned short
		public ushort versionNumber;

		/// WORD->unsigned short
		public ushort offset;
	}

	[System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Unicode)]
	public struct MENUITEMTEMPLATE
	{

		/// WORD->unsigned short
		public ushort mtOption;

		/// WORD->unsigned short
		public ushort mtID;

		/// WCHAR[1]
		[System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 1)]
		public string mtString;
	}

	[System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
	public struct NONCLIENTMETRICS
	{

		/// UINT->unsigned int
		public uint cbSize;

		/// int
		public int iBorderWidth;

		/// int
		public int iScrollWidth;

		/// int
		public int iScrollHeight;

		/// int
		public int iCaptionWidth;

		/// int
		public int iCaptionHeight;

		/// LOGFONTW->tagLOGFONTW
		public LOGFONT lfCaptionFont;

		/// int
		public int iSmCaptionWidth;

		/// int
		public int iSmCaptionHeight;

		/// LOGFONTW->tagLOGFONTW
		public LOGFONT lfSmCaptionFont;

		/// int
		public int iMenuWidth;

		/// int
		public int iMenuHeight;

		/// LOGFONTW->tagLOGFONTW
		public LOGFONT lfMenuFont;

		/// LOGFONTW->tagLOGFONTW
		public LOGFONT lfStatusFont;

		/// LOGFONTW->tagLOGFONTW
		public LOGFONT lfMessageFont;

		/// int
		public int iPaddedBorderWidth;
	}

	[System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
	public struct SECURITY_DESCRIPTOR
	{

		/// BYTE->unsigned char
		public byte Revision;

		/// BYTE->unsigned char
		public byte Sbz1;

		/// SECURITY_DESCRIPTOR_CONTROL->WORD->unsigned short
		public ushort Control;

		/// PSID->PVOID->void*
		public System.IntPtr Owner;

		/// PSID->PVOID->void*
		public System.IntPtr Group;

		/// PACL->ACL*
		public System.IntPtr Sacl;

		/// PACL->ACL*
		public System.IntPtr Dacl;
	}

	[System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
	public struct ACL
	{

		/// BYTE->unsigned char
		public byte AclRevision;

		/// BYTE->unsigned char
		public byte Sbz1;

		/// WORD->unsigned short
		public ushort AclSize;

		/// WORD->unsigned short
		public ushort AceCount;

		/// WORD->unsigned short
		public ushort Sbz2;
	}


	/// <summary>
	///     The <see cref="LOGFONT" /> structure defines the attributes of a font.
	/// </summary>
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
	public struct LOGFONT
	{
		/// <summary>
		///     <para>
		///         The height, in logical units, of the font's character cell or character. The character height value (also known as the em height) is the
		///         character cell height value minus the internal-leading value. The font mapper interprets the value specified in <see cref="lfHeight" /> in
		///         the following manner.
		///     </para>
		///     <list type="table">
		///         <item>
		///             <term>&gt; 0</term>
		///             <description>The font mapper transforms this value into device units and matches it against the cell height of the available fonts.</description>
		///         </item>
		///         <item>
		///             <term>0</term>
		///             <description>The font mapper uses a default height value when it searches for a match.</description>
		///         </item>
		///         <item>
		///             <term>&lt; 0</term>
		///             <description>
		///                 The font mapper transforms this value into device units and matches its absolute value against the character height of the
		///                 available fonts.
		///             </description>
		///         </item>
		///     </list>
		///     <para>For all height comparisons, the font mapper looks for the largest font that does not exceed the requested size.</para>
		///     <para>This mapping occurs when the font is used for the first time.</para>
		///     <para>For the MM_TEXT mapping mode, you can use the following formula to specify a height for a font with a specified point size:</para>
		/// </summary>
		public int lfHeight;

		/// <summary>
		///     The average width, in logical units, of characters in the font. If <see cref="lfWidth" /> is zero, the aspect ratio of the device is matched
		///     against the digitization aspect ratio of the available fonts to find the closest match, determined by the absolute value of the difference.
		/// </summary>
		public int lfWidth;

		/// <summary>
		///     <para>
		///         The angle, in tenths of degrees, between the escapement vector and the x-axis of the device. The escapement vector is parallel to the base
		///         line of a row of text.
		///     </para>
		///     <para>
		///         When the graphics mode is set to GM_ADVANCED, you can specify the escapement angle of the string independently of the orientation angle of
		///         the string's characters.
		///     </para>
		///     <para>
		///         When the graphics mode is set to GM_COMPATIBLE, <see cref="lfEscapement" /> specifies both the escapement and orientation. You should set
		///         <see cref="lfEscapement" /> and <see cref="lfOrientation" /> to the same value.
		///     </para>
		/// </summary>
		public int lfEscapement;

		/// <summary>The angle, in tenths of degrees, between each character's base line and the x-axis of the device.</summary>
		public int lfOrientation;

		/// <summary>
		///     <para>
		///         The weight of the font in the range 0 through 1000. For example, 400 is normal and 700 is bold. If this value is zero, a default weight is
		///         used.
		///     </para>
		///     <para>The following values are defined for convenience.</para>
		///     <list type="table">
		///         <item>
		///             <term>FW_DONTCARE</term>
		///             <description>0</description>
		///         </item>
		///         <item>
		///             <term>FW_THIN</term>
		///             <description>100</description>
		///         </item>
		///         <item>
		///             <term>FW_EXTRALIGHT</term>
		///             <description>200</description>
		///         </item>
		///         <item>
		///             <term>FW_ULTRALIGHT</term>
		///             <description>200</description>
		///         </item>
		///         <item>
		///             <term>FW_LIGHT</term>
		///             <description>300</description>
		///         </item>
		///         <item>
		///             <term>FW_NORMAL</term>
		///             <description>400</description>
		///         </item>
		///         <item>
		///             <term>FW_REGULAR</term>
		///             <description>400</description>
		///         </item>
		///         <item>
		///             <term>FW_MEDIUM</term>
		///             <description>500</description>
		///         </item>
		///         <item>
		///             <term>FW_SEMIBOLD</term>
		///             <description>600</description>
		///         </item>
		///         <item>
		///             <term>FW_DEMIBOLD</term>
		///             <description>600</description>
		///         </item>
		///         <item>
		///             <term>FW_BOLD</term>
		///             <description>700</description>
		///         </item>
		///         <item>
		///             <term>FW_EXTRABOLD</term>
		///             <description>800</description>
		///         </item>
		///         <item>
		///             <term>FW_ULTRABOLD</term>
		///             <description>800</description>
		///         </item>
		///         <item>
		///             <term>FW_HEAVY</term>
		///             <description>900</description>
		///         </item>
		///         <item>
		///             <term>FW_BLACK</term>
		///             <description>900</description>
		///         </item>
		///     </list>
		/// </summary>
		public FW lfWeight;

		/// <summary>An italic font if set to TRUE.</summary>
		[MarshalAs(UnmanagedType.U1)]
		public bool lfItalic;

		/// <summary>An underlined font if set to TRUE.</summary>
		[MarshalAs(UnmanagedType.U1)]
		public bool lfUnderline;

		/// <summary>A strikeout font if set to TRUE.</summary>
		[MarshalAs(UnmanagedType.U1)]
		public bool lfStrikeOut;

		/// <summary>
		///     <para>The character set. The following values are predefined.</para>
		///     <list type="table"></list>
		///     <para>Korean language edition of Windows:</para>
		///     <list type="table"></list>
		///     <para>Middle East language edition of Windows:</para>
		///     <list type="table"></list>
		///     <para>Thai language edition of Windows:</para>
		///     <list type="table"></list>
		///     <para>The OEM_CHARSET value specifies a character set that is operating-system dependent.</para>
		///     <para>
		///         DEFAULT_CHARSET is set to a value based on the current system locale. For example, when the system locale is English (United States), it is
		///         set as ANSI_CHARSET.
		///     </para>
		///     <para>
		///         Fonts with other character sets may exist in the operating system. If an application uses a font with an unknown character set, it should not
		///         attempt to translate or interpret strings that are rendered with that font.
		///     </para>
		///     <para>
		///         This parameter is important in the font mapping process. To ensure consistent results, specify a specific character set. If you specify a
		///         typeface name in the <see cref="lfFaceName" /> member, make sure that the <see cref="lfCharSet" /> value matches the character set of the
		///         typeface specified in <see cref="lfFaceName" />.
		///     </para>
		/// </summary>
		public CHARSET lfCharSet;

		/// <summary>
		///     <para>
		///         The output precision. The output precision defines how closely the output must match the requested font's height, width, character
		///         orientation, escapement, pitch, and font type. It can be one of the following values.
		///     </para>
		///     <list type="table">
		///         <item>
		///             <term>OUT_CHARACTER_PRECIS</term>
		///             <description>Not used.</description>
		///         </item>
		///         <item>
		///             <term>OUT_DEFAULT_PRECIS</term>
		///             <description>Specifies the default font mapper behavior.</description>
		///         </item>
		///         <item>
		///             <term>OUT_DEVICE_PRECIS</term>
		///             <description>Instructs the font mapper to choose a Device font when the system contains multiple fonts with the same name.</description>
		///         </item>
		///         <item>
		///             <term>OUT_OUTLINE_PRECIS</term>
		///             <description>This value instructs the font mapper to choose from TrueType and other outline-based fonts.</description>
		///         </item>
		///         <item>
		///             <term>OUT_PS_ONLY_PRECIS</term>
		///             <description>
		///                 Instructs the font mapper to choose from only PostScript fonts. If there are no PostScript fonts installed in the system, the font
		///                 mapper returns to default behavior.
		///             </description>
		///         </item>
		///         <item>
		///             <term>OUT_RASTER_PRECIS</term>
		///             <description>Instructs the font mapper to choose a raster font when the system contains multiple fonts with the same name.</description>
		///         </item>
		///         <item>
		///             <term>OUT_STRING_PRECIS</term>
		///             <description>This value is not used by the font mapper, but it is returned when raster fonts are enumerated.</description>
		///         </item>
		///         <item>
		///             <term>OUT_STROKE_PRECIS</term>
		///             <description>
		///                 This value is not used by the font mapper, but it is returned when TrueType, other outline-based fonts, and vector fonts are
		///                 enumerated.
		///             </description>
		///         </item>
		///         <item>
		///             <term>OUT_TT_ONLY_PRECIS</term>
		///             <description>
		///                 Instructs the font mapper to choose from only TrueType fonts. If there are no TrueType fonts installed in the system, the font mapper
		///                 returns to default behavior.
		///             </description>
		///         </item>
		///         <item>
		///             <term>OUT_TT_PRECIS</term>
		///             <description>Instructs the font mapper to choose a TrueType font when the system contains multiple fonts with the same name.</description>
		///         </item>
		///     </list>
		///     <para>
		///         Applications can use the OUT_DEVICE_PRECIS, OUT_RASTER_PRECIS, OUT_TT_PRECIS, and OUT_PS_ONLY_PRECIS values to control how the font mapper
		///         chooses a font when the operating system contains more than one font with a specified name. For example, if an operating system contains a
		///         font named Symbol in raster and TrueType form, specifying OUT_TT_PRECIS forces the font mapper to choose the TrueType version. Specifying
		///         OUT_TT_ONLY_PRECIS forces the font mapper to choose a TrueType font, even if it must substitute a TrueType font of another name.
		///     </para>
		/// </summary>
		public PRECIS lfOutPrecision;

		/// <summary>The clipping precision. The clipping precision defines how to clip characters that are partially outside the clipping region.</summary>
		public CLIP lfClipPrecision;

		/// <summary>
		///     <para>
		///         The output quality. The output quality defines how carefully the graphics device interface (GDI) must attempt to match the logical-font
		///         attributes to those of an actual physical font. It can be one of the following values.
		///     </para>
		///     <list type="table">
		///         <item>
		///             <term>ANTIALIASED_QUALITY</term>
		///             <description>Font is always antialiased if the font supports it and the size of the font is not too small or too large.</description>
		///         </item>
		///         <item>
		///             <term>CLEARTYPE_QUALITY</term>
		///             <description>If set, text is rendered (when possible) using ClearType antialiasing method. See Remarks for more information.</description>
		///         </item>
		///         <item>
		///             <term>DEFAULT_QUALITY</term>
		///             <description>Appearance of the font does not matter.</description>
		///         </item>
		///         <item>
		///             <term>DRAFT_QUALITY</term>
		///             <description>
		///                 Appearance of the font is less important than when PROOF_QUALITY is used. For GDI raster fonts, scaling is enabled, which means that
		///                 more font sizes are available, but the quality may be lower. Bold, italic, underline, and strikeout fonts are synthesized if
		///                 necessary.
		///             </description>
		///         </item>
		///         <item>
		///             <term>NONANTIALIASED_QUALITY</term>
		///             <description>Font is never antialiased.</description>
		///         </item>
		///         <item>
		///             <term>PROOF_QUALITY</term>
		///             <description>
		///                 Character quality of the font is more important than exact matching of the logical-font attributes. For GDI raster fonts, scaling is
		///                 disabled and the font closest in size is chosen. Although the chosen font size may not be mapped exactly when PROOF_QUALITY is used,
		///                 the quality of the font is high and there is no distortion of appearance. Bold, italic, underline, and strikeout fonts are
		///                 synthesized if necessary.
		///             </description>
		///         </item>
		///     </list>
		///     <para>
		///         If neither ANTIALIASED_QUALITY nor NONANTIALIASED_QUALITY is selected, the font is antialiased only if the user chooses smooth screen fonts
		///         in Control Panel.
		///     </para>
		/// </summary>
		public QUALITY lfQuality;

		/// <summary>
		///     <para>The pitch and family of the font. The two low-order bits specify the pitch of the font and can be one of the following values.</para>
		///     <para>Bits 4 through 7 of the member specify the font family and can be one of the following values.</para>
		///     <para>The proper value can be obtained by using the Boolean OR operator to join one pitch constant with one family constant.</para>
		///     <para>
		///         Font families describe the look of a font in a general way. They are intended for specifying fonts when the exact typeface desired is not
		///         available. The values for font families are as follows.
		///     </para>
		///     <list type="table">
		///         <item>
		///             <term>FF_DECORATIVE</term>
		///             <description>Novelty fonts. Old English is an example.</description>
		///         </item>
		///         <item>
		///             <term>FF_DONTCARE</term>
		///             <description>Use default font.</description>
		///         </item>
		///         <item>
		///             <term>FF_MODERN</term>
		///             <description>
		///                 Fonts with constant stroke width (monospace), with or without serifs. Monospace fonts are usually modern. Pica, Elite, and
		///                 CourierNew are examples.
		///             </description>
		///         </item>
		///         <item>
		///             <term>FF_ROMAN</term>
		///             <description>Fonts with variable stroke width (proportional) and with serifs. MS Serif is an example.</description>
		///         </item>
		///         <item>
		///             <term>FF_SCRIPT</term>
		///             <description>Fonts designed to look like handwriting. Script and Cursive are examples.</description>
		///         </item>
		///         <item>
		///             <term>FF_SWISS</term>
		///             <description>Fonts with variable stroke width (proportional) and without serifs. MS Sans Serif is an example.</description>
		///         </item>
		///     </list>
		/// </summary>
		public PITCH_FAMILY lfPitchAndFamily;

		/// <summary>
		///     A null-terminated string that specifies the typeface name of the font. The length of this string must not exceed 32 TCHAR values, including the
		///     terminating NULL. The <see cref="Gdi32.EnumFontFamiliesEx" /> function can be used to enumerate the typeface names of all currently available
		///     fonts. If <see cref="lfFaceName" /> is an empty string, GDI uses the first font that matches the other specified attributes.
		/// </summary>
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
		public string lfFaceName;
	}


	// ReSharper restore InconsistentNaming
}