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
    public struct MSGBOXPARAMSW
    {
        /// UINT->unsigned int
        public uint cbSize;

        /// HWND->HWND__*
        public IntPtr hwndOwner;

        /// HINSTANCE->HINSTANCE__*
        public IntPtr hInstance;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpszText;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpszCaption;

        /// DWORD->unsigned int
        public uint dwStyle;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpszIcon;

        /// DWORD_PTR->ULONG_PTR->unsigned int
        public uint dwContextHelpId;

        /// MSGBOXCALLBACK
        public MSGBOXCALLBACK lpfnMsgBoxCallback;

        /// DWORD->unsigned int
        public uint dwLanguageId;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MSGBOXPARAMSA
    {
        /// UINT->unsigned int
        public uint cbSize;

        /// HWND->HWND__*
        public IntPtr hwndOwner;

        /// HINSTANCE->HINSTANCE__*
        public IntPtr hInstance;

        /// LPCSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpszText;

        /// LPCSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpszCaption;

        /// DWORD->unsigned int
        public uint dwStyle;

        /// LPCSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpszIcon;

        /// DWORD_PTR->ULONG_PTR->unsigned int
        public uint dwContextHelpId;

        /// MSGBOXCALLBACK
        public MSGBOXCALLBACK lpfnMsgBoxCallback;

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
    public struct WNDCLASSEXW
    {
        /// UINT->unsigned int
        public uint cbSize;

        /// UINT->unsigned int
        public uint style;

        /// WNDPROC
        public WNDPROC lpfnWndProc;

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
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpszMenuName;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpszClassName;

        /// HICON->HICON__*
        public IntPtr hIconSm;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct WNDCLASSEXA
    {
        /// UINT->unsigned int
        public uint cbSize;

        /// UINT->unsigned int
        public uint style;

        /// WNDPROC
        public WNDPROC lpfnWndProc;

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

        /// LPCSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpszMenuName;

        /// LPCSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpszClassName;

        /// HICON->HICON__*
        public IntPtr hIconSm;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct WNDCLASSW
    {
        /// UINT->unsigned int
        public uint style;

        /// WNDPROC
        public WNDPROC lpfnWndProc;

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
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpszMenuName;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpszClassName;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct WNDCLASSA
    {
        /// UINT->unsigned int
        public uint style;

        /// WNDPROC
        public WNDPROC lpfnWndProc;

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

        /// LPCSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpszMenuName;

        /// LPCSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
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

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
    public struct DEVMODE
    {
        /// WCHAR[32]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string dmDeviceName;

        /// WORD->unsigned short
        public ushort dmSpecVersion;

        /// WORD->unsigned short
        public ushort dmDriverVersion;

        /// WORD->unsigned short
        public ushort dmSize;

        /// WORD->unsigned short
        public ushort dmDriverExtra;

        /// DWORD->unsigned int
        public uint dmFields;

        /// Anonymous_7a7460d9_d99f_4e9a_9ebb_cdd10c08463d
        public PAGE_DATA pageData;

        /// short
        public short dmColor;

        /// short
        public short dmDuplex;

        /// short
        public short dmYResolution;

        /// short
        public short dmTTOption;

        /// short
        public short dmCollate;

        /// WCHAR[32]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string dmFormName;

        /// WORD->unsigned short
        public ushort dmLogPixels;

        /// DWORD->unsigned int
        public uint dmBitsPerPel;

        /// DWORD->unsigned int
        public uint dmPelsWidth;

        /// DWORD->unsigned int
        public uint dmPelsHeight;

        /// Anonymous_084dbe97_5806_4c28_a299_ed6037f61d90
        public DISPLAY_DATA displayData;

        /// DWORD->unsigned int
        public uint dmDisplayFrequency;

        /// DWORD->unsigned int
        public uint dmICMMethod;

        /// DWORD->unsigned int
        public uint dmICMIntent;

        /// DWORD->unsigned int
        public uint dmMediaType;

        /// DWORD->unsigned int
        public uint dmDitherType;

        /// DWORD->unsigned int
        public uint dmReserved1;

        /// DWORD->unsigned int
        public uint dmReserved2;

        /// DWORD->unsigned int
        public uint dmPanningWidth;

        /// DWORD->unsigned int
        public uint dmPanningHeight;
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
    public struct MENUITEMINFOW
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
        [MarshalAs(UnmanagedType.LPWStr)]
        public string dwTypeData;

        /// UINT->unsigned int
        public uint cch;

        /// HBITMAP->HBITMAP__*
        public IntPtr hbmpItem;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MENUITEMINFOA
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

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
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
        ///fFocused : 1
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
        public int mouseData; // be careful, this must be ints, not uints (was wrong before I changed it...). regards, cmew.
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
            ColorDWORD = (uint)color.R + (((uint)color.G) << 8) + (((uint)color.B) << 16);
        }

        public Color GetColor()
        {
            return Color.FromArgb((int)(0x000000FFU & ColorDWORD),
           (int)(0x0000FF00U & ColorDWORD) >> 8, (int)(0x00FF0000U & ColorDWORD) >> 16);
        }

        public void SetColor(Color color)
        {
            ColorDWORD = color.R + (((uint)color.G) << 8) + (((uint)color.B) << 16);
        }
    }
    // ReSharper restore InconsistentNaming
}
