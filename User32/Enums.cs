// ReSharper disable CheckNamespace

using System;

namespace Win32Interop.Enums
// ReSharper restore CheckNamespace
{
    // ReSharper disable InconsistentNaming
    public enum SECURITY_IMPERSONATION_LEVEL
    {
        SecurityAnonymous,
        SecurityIdentification,
        SecurityImpersonation,
        SecurityDelegation,
    }

    public enum WH
    {
        WH_MSGFILTER = -1,
        WH_JOURNALRECORD = 0,
        WH_JOURNALPLAYBACK = 1,
        WH_KEYBOARD = 2,
        WH_GETMESSAGE = 3,
        WH_CALLWNDPROC = 4,
        WH_CBT = 5,
        WH_SYSMSGFILTER = 6,
        WH_MOUSE = 7,
        WH_HARDWARE = 8,
        WH_DEBUG = 9,
        WH_SHELL = 10,
        WH_FOREGROUNDIDLE = 11,
        WH_CALLWNDPROCRET = 12,
        WH_KEYBOARD_LL = 13,
        WH_MOUSE_LL = 14
    }

    public enum DEVICE_NOTIFY : uint
    {
        DEVICE_NOTIFY_WINDOW_HANDLE = 0,
        DEVICE_NOTIFY_SERVICE_HANDLE = 1,
        DEVICE_NOTIFY_ALL_INTERFACE_CLASSES = 4
    }

    [Flags]
    public enum LR : uint
    {
        LR_DEFAULTCOLOR = 0x00000000,
        LR_MONOCHROME = 0x00000001,
        LR_COLOR = 0x00000002,
        LR_COPYRETURNORG = 0x00000004,
        LR_COPYDELETEORG = 0x00000008,
        LR_LOADFROMFILE = 0x00000010,
        LR_LOADTRANSPARENT = 0x00000020,
        LR_DEFAULTSIZE = 0x00000040,
        LR_VGACOLOR = 0x00000080,
        LR_LOADMAP3DCOLORS = 0x00001000,
        LR_CREATEDIBSECTION = 0x00002000,
        LR_COPYFROMRESOURCE = 0x00004000,
        LR_SHARED = 0x00008000
    }

    [Flags]
    public enum DCX : uint
    {
        DCX_WINDOW = 0x00000001,
        DCX_CACHE = 0x00000002,
        DCX_NORESETATTRS = 0x00000004,
        DCX_CLIPCHILDREN = 0x00000008,
        DCX_CLIPSIBLINGS = 0x00000010,
        DCX_PARENTCLIP = 0x00000020,
        DCX_EXCLUDERGN = 0x00000040,
        DCX_INTERSECTRGN = 0x00000080,
        DCX_EXCLUDEUPDATE = 0x00000100,
        DCX_INTERSECTUPDATE = 0x00000200,
        DCX_LOCKWINDOWUPDATE = 0x00000400,
        DCX_VALIDATE = 0x00200000
    }

    [Flags]
    public enum CWP
    {
        CWP_ALL = 0x0000,
        CWP_SKIPDISABLED = 0x0002,
        CWP_SKIPINVISIBLE = 0x0001,
        CWP_SKIPTRANSPARENT = 0x0004
    }

    [Flags]
    public enum BSF : uint
    {
        BSF_ALLOWSFW = 0x00000080,
        BSF_FLUSHDISK = 0x00000004,
        BSF_FORCEIFHUNG = 0x00000020,
        BSF_IGNORECURRENTTASK = 0x00000002,
        BSF_NOHANG = 0x00000008,
        BSF_NOTIMEOUTIFNOTHUNG = 0x00000040,
        BSF_POSTMESSAGE = 0x00000010,
        BSF_QUERY = 0x00000001,
        BSF_SENDNOTIFYMESSAGE = 0x00000100,
		BSF_LUID = 0x00000400
    }

    public enum KLF : uint
    {
		KLF_ACTIVATE = 0x00000001,
		KLF_SUBSTITUTE_OK = 0x00000002,
        KLF_REORDER = 0x00000008,
        KLF_RESET = 0x40000000,
        KLF_SETFORPROCESS = 0x00000100,
        KLF_SHIFTLOCK = 0x00010000
    }

    public enum TA : uint
    {
        TA_INACTIVE_MENU = 0,
        TA_ACTIVE_MENU = 1
    }

    [Flags]
    public enum SMTO : uint
    {
        SMTO_NORMAL = 0x0000,
        SMTO_BLOCK = 0x0001,
        SMTO_ABORTIFHUNG = 0x0002,
        SMTO_NOTIMEOUTIFNOTHUNG = 0x0008,
        SMTO_ERRORONEXIT = 0x0020
    }

    public enum GW : uint
    {
        GW_HWNDFIRST = 0,
        GW_HWNDLAST = 1,
        GW_HWNDNEXT = 2,
        GW_HWNDPREV = 3,
        GW_OWNER = 4,
        GW_CHILD = 5,
        GW_ENABLEDPOPUP = 6,
        GW_MAX = 6
    }

    [Flags]
    public enum WS_EX : uint
    {
        WS_EX_DLGMODALFRAME = 0x00000001,
        WS_EX_NOPARENTNOTIFY = 0x00000004,
        WS_EX_TOPMOST = 0x00000008,
        WS_EX_ACCEPTFILES = 0x00000010,
        WS_EX_TRANSPARENT = 0x00000020,
        WS_EX_MDICHILD = 0x00000040,
        WS_EX_TOOLWINDOW = 0x00000080,
        WS_EX_WINDOWEDGE = 0x00000100,
        WS_EX_CLIENTEDGE = 0x00000200,
        WS_EX_CONTEXTHELP = 0x00000400,
        WS_EX_RIGHT = 0x00001000,
        WS_EX_LEFT = 0x00000000,
        WS_EX_RTLREADING = 0x00002000,
        WS_EX_LTRREADING = 0x00000000,
        WS_EX_LEFTSCROLLBAR = 0x00004000,
        WS_EX_RIGHTSCROLLBAR = 0x00000000,
        WS_EX_CONTROLPARENT = 0x00010000,
        WS_EX_STATICEDGE = 0x00020000,
        WS_EX_APPWINDOW = 0x00040000,
        WS_EX_OVERLAPPEDWINDOW = (WS_EX_WINDOWEDGE | WS_EX_CLIENTEDGE),
        WS_EX_PALETTEWINDOW = (WS_EX_WINDOWEDGE | WS_EX_TOOLWINDOW | WS_EX_TOPMOST),
        WS_EX_LAYERED = 0x00080000,
        WS_EX_NOINHERITLAYOUT = 0x00100000,
        WS_EX_LAYOUTRTL = 0x00400000,
        WS_EX_COMPOSITED = 0x02000000,
        WS_EX_NOACTIVATE = 0x08000000
    }

    public enum HT
    {
        HTERROR = -2,
        HTTRANSPARENT = -1,
        HTNOWHERE = 0,
        HTCLIENT = 1,
        HTCAPTION = 2,
        HTSYSMENU = 3,
        HTGROWBOX = 4,
        HTSIZE = HTGROWBOX,
        HTMENU = 5,
        HTHSCROLL = 6,
        HTVSCROLL = 7,
        HTMINBUTTON = 8,
        HTMAXBUTTON = 9,
        HTLEFT = 10,
        HTRIGHT = 11,
        HTTOP = 12,
        HTTOPLEFT = 13,
        HTTOPRIGHT = 14,
        HTBOTTOM = 15,
        HTBOTTOMLEFT = 16,
        HTBOTTOMRIGHT = 17,
        HTBORDER = 18,
        HTREDUCE = HTMINBUTTON,
        HTZOOM = HTMAXBUTTON,
        HTSIZEFIRST = HTLEFT,
        HTSIZELAST = HTBOTTOMRIGHT,
        HTOBJECT = 19,
        HTCLOSE = 20,
        HTHELP = 21
    }

    [Flags]
    public enum WS : uint
    {
        WS_OVERLAPPED = 0x00000000,
        WS_POPUP = 0x80000000,
        WS_CHILD = 0x40000000,
        WS_MINIMIZE = 0x20000000,
        WS_VISIBLE = 0x10000000,
        WS_DISABLED = 0x08000000,
        WS_CLIPSIBLINGS = 0x04000000,
        WS_CLIPCHILDREN = 0x02000000,
        WS_MAXIMIZE = 0x01000000,
        WS_CAPTION = 0x00C00000,
        WS_BORDER = 0x00800000,
        WS_DLGFRAME = 0x00400000,
        WS_VSCROLL = 0x00200000,
        WS_HSCROLL = 0x00100000,
        WS_SYSMENU = 0x00080000,
        WS_THICKFRAME = 0x00040000,
        WS_GROUP = 0x00020000,
        WS_TABSTOP = 0x00010000,
        WS_MINIMIZEBOX = 0x00020000,
        WS_MAXIMIZEBOX = 0x00010000,
        WS_TILED = WS_OVERLAPPED,
        WS_ICONIC = WS_MINIMIZE,
        WS_SIZEBOX = WS_THICKFRAME,
        WS_TILEDWINDOW = WS_OVERLAPPEDWINDOW,
        WS_OVERLAPPEDWINDOW = (WS_OVERLAPPED | WS_CAPTION | WS_SYSMENU | WS_THICKFRAME | WS_MINIMIZEBOX | WS_MAXIMIZEBOX),
        WS_POPUPWINDOW = (WS_POPUP | WS_BORDER | WS_SYSMENU),
        WS_CHILDWINDOW = WS_CHILD
    }

    [Flags]
    public enum BF : uint
    {
        BF_LEFT = 0x0001,
        BF_TOP = 0x0002,
        BF_RIGHT = 0x0004,
        BF_BOTTOM = 0x0008,
        BF_TOPLEFT = (BF_TOP | BF_LEFT),
        BF_TOPRIGHT = (BF_TOP | BF_RIGHT),
        BF_BOTTOMLEFT = (BF_BOTTOM | BF_LEFT),
        BF_BOTTOMRIGHT = (BF_BOTTOM | BF_RIGHT),
        BF_RECT = (BF_LEFT | BF_TOP | BF_RIGHT | BF_BOTTOM),
        BF_DIAGONAL = 0x0010,
        BF_DIAGONAL_ENDTOPRIGHT = (BF_DIAGONAL | BF_TOP | BF_RIGHT),
        BF_DIAGONAL_ENDTOPLEFT = (BF_DIAGONAL | BF_TOP | BF_LEFT),
        BF_DIAGONAL_ENDBOTTOMLEFT = (BF_DIAGONAL | BF_BOTTOM | BF_LEFT),
        BF_DIAGONAL_ENDBOTTOMRIGHT = (BF_DIAGONAL | BF_BOTTOM | BF_RIGHT),
        BF_MIDDLE = 0x0800,
        BF_SOFT = 0x1000,
        BF_ADJUST = 0x2000,
        BF_FLAT = 0x4000,
        BF_MONO = 0x8000
    }

    public enum TU : uint
    {
        TU_MENU_ACTIVE = 0
    }

    public enum GA : uint
    {
        GA_PARENT = 1,
        GA_ROOT = 2,
        GA_ROOTOWNER = 3
    }

    public enum DI : uint
    {
        DI_MASK = 0x0001,
        DI_IMAGE = 0x0002,
        DI_NORMAL = 0x0003,
        DI_COMPAT = 0x0004,
        DI_DEFAULTSIZE = 0x0008,
        DI_NOMIRROR = 0x0010
    }

    public enum PW : uint
    {
        PW_CLIENTONLY = 0x00000001
    }

    public enum GR : uint
    {
        GR_GDIOBJECTS = 0,
        GR_USEROBJECTS = 1,
        GR_GDIOBJECTS_PEAK = 2,
        GR_USEROBJECTS_PEAK = 4
    }

    public enum SB : uint
    {
        SB_HORZ = 0,
        SB_VERT = 1,
        SB_CTL = 2,
        SB_BOTH = 3
    }

    public enum ESB : uint
    {
        ESB_ENABLE_BOTH = 0x0000,
        ESB_DISABLE_BOTH = 0x0003,
        ESB_DISABLE_LEFT = 0x0001,
        ESB_DISABLE_RIGHT = 0x0002,
        ESB_DISABLE_UP = 0x0001,
        ESB_DISABLE_DOWN = 0x0002,
        ESB_DISABLE_LTUP = ESB_DISABLE_LEFT,
        ESB_DISABLE_RTDN = ESB_DISABLE_RIGHT
    }

    [Flags]
    public enum GMDI : uint
    {
        GMDI_NONE = 0,
        GMDI_USEDISABLED = 0x0001,
        GMDI_GOINTOPOPUPS = 0x0002
    }

    [Flags]
    public enum MF : uint
    {
        MF_INSERT = 0x00000000,
        MF_CHANGE = 0x00000080,
        MF_APPEND = 0x00000100,
        MF_DELETE = 0x00000200,
        MF_REMOVE = 0x00001000,

        MF_BYCOMMAND = 0x00000000,
        MF_BYPOSITION = 0x00000400,

        MF_SEPARATOR = 0x00000800,

        MF_ENABLED = 0x00000000,
        MF_GRAYED = 0x00000001,
        MF_DISABLED = 0x00000002,

        MF_UNCHECKED = 0x00000000,
        MF_CHECKED = 0x00000008,
        MF_USECHECKBITMAPS = 0x00000200,

        MF_STRING = 0x00000000,
        MF_BITMAP = 0x00000004,
        MF_OWNERDRAW = 0x00000100,

        MF_POPUP = 0x00000010,
        MF_MENUBARBREAK = 0x00000020,
        MF_MENUBREAK = 0x00000040,

        MF_UNHILITE = 0x00000000,
        MF_HILITE = 0x00000080,
        MF_DEFAULT = 0x00001000,
        MF_SYSMENU = 0x00002000,
        MF_HELP = 0x00004000,
        MF_RIGHTJUSTIFY = 0x00004000,

        MF_MOUSESELECT = 0x00008000,
        MF_END = 0x00000080
    }

    [Flags]
    public enum SW : uint
    {
        SW_SCROLLCHILDREN = 0x0001,
        SW_INVALIDATE = 0x0002,
        SW_ERASE = 0x0004,
        SW_SMOOTHSCROLL = 0x0010
    }

    [Flags]
    public enum WINEVENT : uint
    {
        WINEVENT_OUTOFCONTEXT = 0x0000,
        WINEVENT_SKIPOWNTHREAD = 0x0001,
        WINEVENT_SKIPOWNPROCESS = 0x0002,
        WINEVENT_INCONTEXT = 0x0004
    }

    [Flags]
    public enum AW : uint
    {
        AW_HOR_POSITIVE = 0x00000001,
        AW_HOR_NEGATIVE = 0x00000002,
        AW_VER_POSITIVE = 0x00000004,
        AW_VER_NEGATIVE = 0x00000008,
        AW_CENTER = 0x00000010,
        AW_HIDE = 0x00010000,
        AW_ACTIVATE = 0x00020000,
        AW_SLIDE = 0x00040000,
        AW_BLEND = 0x00080000
    }

    [Flags]
    public enum SWP : uint
    {
        SWP_NOSIZE = 0x0001,
        SWP_NOMOVE = 0x0002,
        SWP_NOZORDER = 0x0004,
        SWP_NOREDRAW = 0x0008,
        SWP_NOACTIVATE = 0x0010,
        SWP_FRAMECHANGED = 0x0020,
        SWP_SHOWWINDOW = 0x0040,
        SWP_HIDEWINDOW = 0x0080,
        SWP_NOCOPYBITS = 0x0100,
        SWP_NOOWNERZORDER = 0x0200,
        SWP_NOSENDCHANGING = 0x0400,
        SWP_DRAWFRAME = SWP_FRAMECHANGED,
        SWP_NOREPOSITION = SWP_NOOWNERZORDER,
        SWP_DEFERERASE = 0x2000,
        SWP_ASYNCWINDOWPOS = 0x4000
    }

    [Flags]
    public enum EWX : uint
    {
        EWX_LOGOFF = 0,
        EWX_SHUTDOWN = 0x00000001,
        EWX_REBOOT = 0x00000002,
        EWX_FORCE = 0x00000004,
        EWX_POWEROFF = 0x00000008,
        EWX_FORCEIFHUNG = 0x00000010,
        EWX_QUICKRESOLVE = 0x00000020,
        EWX_RESTARTAPPS = 0x00000040
    }

    [Flags]
    public enum TPM : uint
    {
        TPM_LEFTBUTTON = 0x0000,
        TPM_RIGHTBUTTON = 0x0002,
        TPM_LEFTALIGN = 0x0000,
        TPM_CENTERALIGN = 0x0004,
        TPM_RIGHTALIGN = 0x0008,
        TPM_TOPALIGN = 0x0000,
        TPM_VCENTERALIGN = 0x0010,
        TPM_BOTTOMALIGN = 0x0020,
        TPM_HORIZONTAL = 0x0000,
        TPM_VERTICAL = 0x0040,
        TPM_NONOTIFY = 0x0080,
        TPM_RETURNCMD = 0x0100,
        TPM_RECURSE = 0x0001,
        TPM_HORPOSANIMATION = 0x0400,
        TPM_HORNEGANIMATION = 0x0800,
        TPM_VERPOSANIMATION = 0x1000,
        TPM_VERNEGANIMATION = 0x2000,
        TPM_NOANIMATION = 0x4000,
        TPM_LAYOUTRTL = 0x8000,
        TPM_WORKAREA = 0x10000
    }

    public enum CP : ushort
    {
        CP_ACP = 0,
        CP_MACCP = 2,
        CP_OEMCP = 1
    }

    [Flags]
    public enum KEYEVENTF : uint
    {
        KEYEVENTF_EXTENDEDKEY = 0x0001,
        KEYEVENTF_KEYUP = 0x0002,
        KEYEVENTF_UNICODE = 0x0004,
        KEYEVENTF_SCANCODE = 0x0008
    }

    [Flags]
    public enum MOUSEEVENTF : uint
    {
        MOUSEEVENTF_MOVE = 0x0001,
        MOUSEEVENTF_LEFTDOWN = 0x0002,
        MOUSEEVENTF_LEFTUP = 0x0004,
        MOUSEEVENTF_RIGHTDOWN = 0x0008,
        MOUSEEVENTF_RIGHTUP = 0x0010,
        MOUSEEVENTF_MIDDLEDOWN = 0x0020,
        MOUSEEVENTF_MIDDLEUP = 0x0040,
        MOUSEEVENTF_XDOWN = 0x0080,
        MOUSEEVENTF_XUP = 0x0100,
        MOUSEEVENTF_WHEEL = 0x0800,
        MOUSEEVENTF_HWHEEL = 0x01000,
        MOUSEEVENTF_MOVE_NOCOALESCE = 0x2000,
        MOUSEEVENTF_VIRTUALDESK = 0x4000,
        MOUSEEVENTF_ABSOLUTE = 0x8000
    }

    [Flags]
    public enum QS : uint
    {
        QS_ALLEVENTS = (QS_INPUT | QS_POSTMESSAGE | QS_TIMER | QS_PAINT | QS_HOTKEY),
        QS_ALLINPUT = (QS_INPUT | QS_POSTMESSAGE | QS_TIMER | QS_PAINT | QS_HOTKEY | QS_SENDMESSAGE),
        QS_ALLPOSTMESSAGE = 0x0100,
        QS_HOTKEY = 0x0080,
        QS_INPUT = (QS_MOUSE | QS_KEY | QS_RAWINPUT),
        QS_KEY = 0x0001,
        QS_MOUSE = (QS_MOUSEMOVE | QS_MOUSEBUTTON),
        QS_MOUSEBUTTON = 0x0004,
        QS_MOUSEMOVE = 0x0002,
        QS_PAINT = 0x0020,
        QS_POSTMESSAGE = 0x0008,
        QS_RAWINPUT = 0x0400,
        QS_SENDMESSAGE = 0x0040,
        QS_TIMER = 0x0010
    }

    public enum DF : uint
    {
        DF_NONE = 0,
        DF_ALLOWOTHERACCOUNTHOOK = 0x0001
    }

    public enum MONITOR : uint
    {
        MONITOR_DEFAULTTONULL = 0x00000000,
        MONITOR_DEFAULTTOPRIMARY = 0x00000001,
        MONITOR_DEFAULTTONEAREST = 0x00000002
    }

    public enum EDD : uint
    {
        EDD_NONE = 0,
        EDD_GET_DEVICE_INTERFACE_NAME = 0x00000001
    }

    public enum ULW : uint
    {
        ULW_COLORKEY = 0x00000001,
        ULW_ALPHA = 0x00000002,
        ULW_OPAQUE = 0x00000004,
        ULW_EX_NORESIZE = 0x00000008
    }

    public enum EDS : uint
    {
        EDS_RAWMODE = 0x00000002,
        EDS_ROTATEDMODE = 0x00000004
    }

    [Flags]
    public enum LWA : uint
    {
        LWA_ALPHA = 0x00000002,
        LWA_COLORKEY = 0x00000001
    }

    public enum CWF : uint
    {
        CWF_NONE = 0,
        CWF_CREATE_ONLY = 0x00000001
    }

    [Flags]
    public enum CDS : uint
    {
        CDS_DYNAMIC = 0,
        CDS_UPDATEREGISTRY = 0x00000001,
        CDS_TEST = 0x00000002,
        CDS_FULLSCREEN = 0x00000004,
        CDS_GLOBAL = 0x00000008,
        CDS_SET_PRIMARY = 0x00000010,
        CDS_VIDEOPARAMETERS = 0x00000020,
        CDS_ENABLE_UNSAFE_MODES = 0x00000100,
        CDS_DISABLE_UNSAFE_MODES = 0x00000200,
        CDS_RESET = 0x40000000,
        CDS_RESET_EX = 0x20000000,
        CDS_NORESET = 0x10000000
    }

    [Flags]
    public enum MWMO
    {
        MWMO_ANY = 0,
        MWMO_ALERTABLE = 0x0002,
        MWMO_INPUTAVAILABLE = 0x0004,
        MWMO_WAITALL = 0x0001
    }

    [Flags]
    public enum RDW : uint
    {
        RDW_INVALIDATE = 0x0001,
        RDW_INTERNALPAINT = 0x0002,
        RDW_ERASE = 0x0004,
        RDW_VALIDATE = 0x0008,
        RDW_NOINTERNALPAINT = 0x0010,
        RDW_NOERASE = 0x0020,
        RDW_NOCHILDREN = 0x0040,
        RDW_ALLCHILDREN = 0x0080,
        RDW_UPDATENOW = 0x0100,
        RDW_ERASENOW = 0x0200,
        RDW_FRAME = 0x0400,
        RDW_NOFRAME = 0x0800,
    }

    [Flags]
    public enum DC : uint
    {
        DC_ACTIVE = 0x0001,
        DC_SMALLCAP = 0x0002,
        DC_ICON = 0x0004,
        DC_TEXT = 0x0008,
        DC_INBUTTON = 0x0010,
        DC_GRADIENT = 0x0020,
        DC_BUTTONS = 0x1000
    }

    public enum WM : uint
    {
        /// <summary>
        /// The WM_NULL message performs no operation. An application sends the WM_NULL message if it wants to post a message that the recipient window will 
        /// ignore.
        /// </summary>
        WM_NULL = 0x0000,

        /// <summary>
        /// The WM_CREATE message is sent when an application requests that a window be created by calling the CreateWindowEx or CreateWindow function. (The 
        /// message is sent before the function returns.) The window procedure of the new window receives this message after the window is created, but before 
        /// the window becomes visible.
        /// </summary>
        WM_CREATE = 0x0001,

        /// <summary>
        /// The WM_DESTROY message is sent when a window is being destroyed. It is sent to the window procedure of the window being destroyed after the window 
        /// is removed from the screen. This message is sent first to the window being destroyed and then to the child windows (if any) as they are destroyed. 
        /// During the processing of the message, it can be assumed that all child windows still exist.
        /// </summary>
        WM_DESTROY = 0x0002,

        /// <summary>
        /// The WM_MOVE message is sent after a window has been moved. 
        /// </summary>
        WM_MOVE = 0x0003,

        /// <summary>
        /// The WM_SIZE message is sent to a window after its size has changed.
        /// </summary>
        WM_SIZE = 0x0005,

        /// <summary>
        /// The WM_ACTIVATE message is sent to both the window being activated and the window being deactivated. If the windows use the same input queue, the 
        /// message is sent synchronously, first to the window procedure of the top-level window being deactivated, then to the window procedure of the top-
        /// level window being activated. If the windows use different input queues, the message is sent asynchronously, so the window is activated 
        /// immediately. 
        /// </summary>
        WM_ACTIVATE = 0x0006,

        /// <summary>
        /// The WM_SETFOCUS message is sent to a window after it has gained the keyboard focus. 
        /// </summary>
        WM_SETFOCUS = 0x0007,

        /// <summary>
        /// The WM_KILLFOCUS message is sent to a window immediately before it loses the keyboard focus. 
        /// </summary>
        WM_KILLFOCUS = 0x0008,

        /// <summary>
        /// The WM_ENABLE message is sent when an application changes the enabled state of a window. It is sent to the window whose enabled state is changing. 
        /// This message is sent before the EnableWindow function returns, but after the enabled state (WS_DISABLED style bit) of the window has changed. 
        /// </summary>
        WM_ENABLE = 0x000A,

        /// <summary>
        /// An application sends the WM_SETREDRAW message to a window to allow changes in that window to be redrawn or to prevent changes in that window from 
        /// being redrawn. 
        /// </summary>
        WM_SETREDRAW = 0x000B,

        /// <summary>
        /// An application sends a WM_SETTEXT message to set the text of a window. 
        /// </summary>
        WM_SETTEXT = 0x000C,

        /// <summary>
        /// An application sends a WM_GETTEXT message to copy the text that corresponds to a window into a buffer provided by the caller. 
        /// </summary>
        WM_GETTEXT = 0x000D,

        /// <summary>
        /// An application sends a WM_GETTEXTLENGTH message to determine the length, in characters, of the text associated with a window. 
        /// </summary>
        WM_GETTEXTLENGTH = 0x000E,

        /// <summary>
        /// The WM_PAINT message is sent when the system or another application makes a request to paint a portion of an application's window. The message is 
        /// sent when the UpdateWindow or RedrawWindow function is called, or by the DispatchMessage function when the application obtains a WM_PAINT message 
        /// by using the GetMessage or PeekMessage function. 
        /// </summary>
        WM_PAINT = 0x000F,

        /// <summary>
        /// The WM_CLOSE message is sent as a signal that a window or an application should terminate.
        /// </summary>
        WM_CLOSE = 0x0010,

        /// <summary>
        /// The WM_QUERYENDSESSION message is sent when the user chooses to end the session or when an application calls one of the system shutdown functions. 
        /// If any application returns zero, the session is not ended. The system stops sending WM_QUERYENDSESSION messages as soon as one application returns 
        /// zero. After processing this message, the system sends the WM_ENDSESSION message with the wParam parameter set to the results of the 
        /// WM_QUERYENDSESSION message.
        /// </summary>
        WM_QUERYENDSESSION = 0x0011,

        /// <summary>
        /// The WM_QUERYOPEN message is sent to an icon when the user requests that the window be restored to its previous size and position.
        /// </summary>
        WM_QUERYOPEN = 0x0013,

        /// <summary>
        /// The WM_ENDSESSION message is sent to an application after the system processes the results of the WM_QUERYENDSESSION message. The WM_ENDSESSION 
        /// message informs the application whether the session is ending.
        /// </summary>
        WM_ENDSESSION = 0x0016,

        /// <summary>
        /// The WM_QUIT message indicates a request to terminate an application and is generated when the application calls the PostQuitMessage function. It 
        /// causes the GetMessage function to return zero.
        /// </summary>
        WM_QUIT = 0x0012,

        /// <summary>
        /// The WM_ERASEBKGND message is sent when the window background must be erased (for example, when a window is resized). The message is sent to prepare 
        /// an invalidated portion of a window for painting. 
        /// </summary>
        WM_ERASEBKGND = 0x0014,

        /// <summary>
        /// This message is sent to all top-level windows when a change is made to a system color setting. 
        /// </summary>
        WM_SYSCOLORCHANGE = 0x0015,

        /// <summary>
        /// The WM_SHOWWINDOW message is sent to a window when the window is about to be hidden or shown.
        /// </summary>
        WM_SHOWWINDOW = 0x0018,

        /// <summary>
        /// An application sends the WM_WININICHANGE message to all top-level windows after making a change to the WIN.INI file. The SystemParametersInfo 
        /// function sends this message after an application uses the function to change a setting in WIN.INI. The WM_WININICHANGE message is provided only for 
        /// compatibility with earlier versions of the system. Applications should use the WM_SETTINGCHANGE message.
        /// </summary>
        WM_WININICHANGE = 0x001A,

        /// <summary>
        /// An application sends the WM_WININICHANGE message to all top-level windows after making a change to the WIN.INI file. The SystemParametersInfo 
        /// function sends this message after an application uses the function to change a setting in WIN.INI. The WM_WININICHANGE message is provided only for 
        /// compatibility with earlier versions of the system. Applications should use the WM_SETTINGCHANGE message.
        /// </summary>
        WM_SETTINGCHANGE = WM_WININICHANGE,

        /// <summary>
        /// The WM_DEVMODECHANGE message is sent to all top-level windows whenever the user changes device-mode settings. 
        /// </summary>
        WM_DEVMODECHANGE = 0x001B,

        /// <summary>
        /// The WM_ACTIVATEAPP message is sent when a window belonging to a different application than the active window is about to be activated. The message 
        /// is sent to the application whose window is being activated and to the application whose window is being deactivated.
        /// </summary>
        WM_ACTIVATEAPP = 0x001C,

        /// <summary>
        /// An application sends the WM_FONTCHANGE message to all top-level windows in the system after changing the pool of font resources. 
        /// </summary>
        WM_FONTCHANGE = 0x001D,

        /// <summary>
        /// A message that is sent whenever there is a change in the system time.
        /// </summary>
        WM_TIMECHANGE = 0x001E,

        /// <summary>
        /// The WM_CANCELMODE message is sent to cancel certain modes, such as mouse capture. For example, the system sends this message to the active window 
        /// when a dialog box or message box is displayed. Certain functions also send this message explicitly to the specified window regardless of whether it 
        /// is the active window. For example, the EnableWindow function sends this message when disabling the specified window.
        /// </summary>
        WM_CANCELMODE = 0x001F,

        /// <summary>
        /// The WM_SETCURSOR message is sent to a window if the mouse causes the cursor to move within a window and mouse input is not captured. 
        /// </summary>
        WM_SETCURSOR = 0x0020,

        /// <summary>
        /// The WM_MOUSEACTIVATE message is sent when the cursor is in an inactive window and the user presses a mouse button. The parent window receives this 
        /// message only if the child window passes it to the DefWindowProc function.
        /// </summary>
        WM_MOUSEACTIVATE = 0x0021,

        /// <summary>
        /// The WM_CHILDACTIVATE message is sent to a child window when the user clicks the window's title bar or when the window is activated, moved, or 
        /// sized.
        /// </summary>
        WM_CHILDACTIVATE = 0x0022,

        /// <summary>
        /// The WM_QUEUESYNC message is sent by a computer-based training (CBT) application to separate user-input messages from other messages sent through 
        /// the WH_JOURNALPLAYBACK Hook procedure. 
        /// </summary>
        WM_QUEUESYNC = 0x0023,

        /// <summary>
        /// The WM_GETMINMAXINFO message is sent to a window when the size or position of the window is about to change. An application can use this message to 
        /// override the window's default maximized size and position, or its default minimum or maximum tracking size. 
        /// </summary>
        WM_GETMINMAXINFO = 0x0024,

        /// <summary>
        /// Windows NT 3.51 and earlier: The WM_PAINTICON message is sent to a minimized window when the icon is to be painted. This message is not sent by 
        /// newer versions of Microsoft Windows, except in unusual circumstances explained in the Remarks.
        /// </summary>
        WM_PAINTICON = 0x0026,

        /// <summary>
        /// Windows NT 3.51 and earlier: The WM_ICONERASEBKGND message is sent to a minimized window when the background of the icon must be filled before 
        /// painting the icon. A window receives this message only if a class icon is defined for the window; otherwise, WM_ERASEBKGND is sent. This message is 
        /// not sent by newer versions of Windows.
        /// </summary>
        WM_ICONERASEBKGND = 0x0027,

        /// <summary>
        /// The WM_NEXTDLGCTL message is sent to a dialog box procedure to set the keyboard focus to a different control in the dialog box. 
        /// </summary>
        WM_NEXTDLGCTL = 0x0028,

        /// <summary>
        /// The WM_SPOOLERSTATUS message is sent from Print Manager whenever a job is added to or removed from the Print Manager queue. 
        /// </summary>
        WM_SPOOLERSTATUS = 0x002A,

        /// <summary>
        /// The WM_DRAWITEM message is sent to the parent window of an owner-drawn button, combo box, list box, or menu when a visual aspect of the button, 
        /// combo box, list box, or menu has changed.
        /// </summary>
        WM_DRAWITEM = 0x002B,

        /// <summary>
        /// The WM_MEASUREITEM message is sent to the owner window of a combo box, list box, list view control, or menu item when the control or menu is 
        /// created.
        /// </summary>
        WM_MEASUREITEM = 0x002C,

        /// <summary>
        /// Sent to the owner of a list box or combo box when the list box or combo box is destroyed or when items are removed by the LB_DELETESTRING, 
        /// LB_RESETCONTENT, CB_DELETESTRING, or CB_RESETCONTENT message. The system sends a WM_DELETEITEM message for each deleted item. The system sends the 
        /// WM_DELETEITEM message for any deleted list box or combo box item with nonzero item data.
        /// </summary>
        WM_DELETEITEM = 0x002D,

        /// <summary>
        /// Sent by a list box with the LBS_WANTKEYBOARDINPUT style to its owner in response to a WM_KEYDOWN message. 
        /// </summary>
        WM_VKEYTOITEM = 0x002E,

        /// <summary>
        /// Sent by a list box with the LBS_WANTKEYBOARDINPUT style to its owner in response to a WM_CHAR message. 
        /// </summary>
        WM_CHARTOITEM = 0x002F,

        /// <summary>
        /// An application sends a WM_SETFONT message to specify the font that a control is to use when drawing text. 
        /// </summary>
        WM_SETFONT = 0x0030,

        /// <summary>
        /// An application sends a WM_GETFONT message to a control to retrieve the font with which the control is currently drawing its text. 
        /// </summary>
        WM_GETFONT = 0x0031,

        /// <summary>
        /// An application sends a WM_SETHOTKEY message to a window to associate a hot key with the window. When the user presses the hot key, the system 
        /// activates the window. 
        /// </summary>
        WM_SETHOTKEY = 0x0032,

        /// <summary>
        /// An application sends a WM_GETHOTKEY message to determine the hot key associated with a window. 
        /// </summary>
        WM_GETHOTKEY = 0x0033,

        /// <summary>
        /// The WM_QUERYDRAGICON message is sent to a minimized (iconic) window. The window is about to be dragged by the user but does not have an icon 
        /// defined for its class. An application can return a handle to an icon or cursor. The system displays this cursor or icon while the user drags the 
        /// icon.
        /// </summary>
        WM_QUERYDRAGICON = 0x0037,

        /// <summary>
        /// The system sends the WM_COMPAREITEM message to determine the relative position of a new item in the sorted list of an owner-drawn combo box or list 
        /// box. Whenever the application adds a new item, the system sends this message to the owner of a combo box or list box created with the CBS_SORT or 
        /// LBS_SORT style. 
        /// </summary>
        WM_COMPAREITEM = 0x0039,

        /// <summary>
        /// Active Accessibility sends the WM_GETOBJECT message to obtain information about an accessible object contained in a server application. 
        /// Applications never send this message directly. It is sent only by Active Accessibility in response to calls to AccessibleObjectFromPoint, 
        /// AccessibleObjectFromEvent, or AccessibleObjectFromWindow. However, server applications handle this message. 
        /// </summary>
        WM_GETOBJECT = 0x003D,

        /// <summary>
        /// The WM_COMPACTING message is sent to all top-level windows when the system detects more than 12.5 percent of system time over a 30- to 60-second 
        /// interval is being spent compacting memory. This indicates that system memory is low.
        /// </summary>
        WM_COMPACTING = 0x0041,

        /// <summary>
        /// WM_COMMNOTIFY is Obsolete for Win32-Based Applications
        /// </summary>
        [Obsolete]
        WM_COMMNOTIFY = 0x0044,

        /// <summary>
        /// The WM_WINDOWPOSCHANGING message is sent to a window whose size, position, or place in the Z order is about to change as a result of a call to the 
        /// SetWindowPos function or another window-management function.
        /// </summary>
        WM_WINDOWPOSCHANGING = 0x0046,

        /// <summary>
        /// The WM_WINDOWPOSCHANGED message is sent to a window whose size, position, or place in the Z order has changed as a result of a call to the 
        /// SetWindowPos function or another window-management function.
        /// </summary>
        WM_WINDOWPOSCHANGED = 0x0047,

        /// <summary>
        /// Notifies applications that the system, typically a battery-powered personal computer, is about to enter a suspended mode.
        /// Use: POWERBROADCAST
        /// </summary>
        [Obsolete]
        WM_POWER = 0x0048,

        /// <summary>
        /// An application sends the WM_COPYDATA message to pass data to another application. 
        /// </summary>
        WM_COPYDATA = 0x004A,

        /// <summary>
        /// The WM_CANCELJOURNAL message is posted to an application when a user cancels the application's journaling activities. The message is posted with a 
        /// NULL window handle. 
        /// </summary>
        WM_CANCELJOURNAL = 0x004B,

        /// <summary>
        /// Sent by a common control to its parent window when an event has occurred or the control requires some information. 
        /// </summary>
        WM_NOTIFY = 0x004E,

        /// <summary>
        /// The WM_INPUTLANGCHANGEREQUEST message is posted to the window with the focus when the user chooses a new input language, either with the hotkey 
        /// (specified in the Keyboard control panel application) or from the indicator on the system taskbar. An application can accept the change by passing 
        /// the message to the DefWindowProc function or reject the change (and prevent it from taking place) by returning immediately. 
        /// </summary>
        WM_INPUTLANGCHANGEREQUEST = 0x0050,

        /// <summary>
        /// The WM_INPUTLANGCHANGE message is sent to the topmost affected window after an application's input language has been changed. You should make any 
        /// application-specific settings and pass the message to the DefWindowProc function, which passes the message to all first-level child windows. These 
        /// child windows can pass the message to DefWindowProc to have it pass the message to their child windows, and so on. 
        /// </summary>
        WM_INPUTLANGCHANGE = 0x0051,

        /// <summary>
        /// Sent to an application that has initiated a training card with Microsoft Windows Help. The message informs the application when the user clicks an 
        /// authorable button. An application initiates a training card by specifying the HELP_TCARD command in a call to the WinHelp function.
        /// </summary>
        WM_TCARD = 0x0052,

        /// <summary>
        /// Indicates that the user pressed the F1 key. If a menu is active when F1 is pressed, WM_HELP is sent to the window associated with the menu; 
        /// otherwise, WM_HELP is sent to the window that has the keyboard focus. If no window has the keyboard focus, WM_HELP is sent to the currently active 
        /// window. 
        /// </summary>
        WM_HELP = 0x0053,

        /// <summary>
        /// The WM_USERCHANGED message is sent to all windows after the user has logged on or off. When the user logs on or off, the system updates the user-
        /// specific settings. The system sends this message immediately after updating the settings.
        /// </summary>
        WM_USERCHANGED = 0x0054,

        /// <summary>
        /// Determines if a window accepts ANSI or Unicode structures in the WM_NOTIFY notification message. WM_NOTIFYFORMAT messages are sent from a common 
        /// control to its parent window and from the parent window to the common control.
        /// </summary>
        WM_NOTIFYFORMAT = 0x0055,

        /// <summary>
        /// The WM_CONTEXTMENU message notifies a window that the user clicked the right mouse button (right-clicked) in the window.
        /// </summary>
        WM_CONTEXTMENU = 0x007B,

        /// <summary>
        /// The WM_STYLECHANGING message is sent to a window when the SetWindowLong function is about to change one or more of the window's styles.
        /// </summary>
        WM_STYLECHANGING = 0x007C,

        /// <summary>
        /// The WM_STYLECHANGED message is sent to a window after the SetWindowLong function has changed one or more of the window's styles
        /// </summary>
        WM_STYLECHANGED = 0x007D,

        /// <summary>
        /// The WM_DISPLAYCHANGE message is sent to all windows when the display resolution has changed.
        /// </summary>
        WM_DISPLAYCHANGE = 0x007E,

        /// <summary>
        /// The WM_GETICON message is sent to a window to retrieve a handle to the large or small icon associated with a window. The system displays the large 
        /// icon in the ALT+TAB dialog, and the small icon in the window caption. 
        /// </summary>
        WM_GETICON = 0x007F,

        /// <summary>
        /// An application sends the WM_SETICON message to associate a new large or small icon with a window. The system displays the large icon in the ALT+TAB 
        /// dialog box, and the small icon in the window caption. 
        /// </summary>
        WM_SETICON = 0x0080,

        /// <summary>
        /// The WM_NCCREATE message is sent prior to the WM_CREATE message when a window is first created.
        /// </summary>
        WM_NCCREATE = 0x0081,

        /// <summary>
        /// The WM_NCDESTROY message informs a window that its nonclient area is being destroyed. The DestroyWindow function sends the WM_NCDESTROY message to 
        /// the window following the WM_DESTROY message. WM_DESTROY is used to free the allocated memory object associated with the window.  The WM_NCDESTROY 
        /// message is sent after the child windows have been destroyed. In contrast, WM_DESTROY is sent before the child windows are destroyed.
        /// </summary>
        WM_NCDESTROY = 0x0082,

        /// <summary>
        /// The WM_NCCALCSIZE message is sent when the size and position of a window's client area must be calculated. By processing this message, an 
        /// application can control the content of the window's client area when the size or position of the window changes.
        /// </summary>
        WM_NCCALCSIZE = 0x0083,

        /// <summary>
        /// The WM_NCHITTEST message is sent to a window when the cursor moves, or when a mouse button is pressed or released. If the mouse is not captured, 
        /// the message is sent to the window beneath the cursor. Otherwise, the message is sent to the window that has captured the mouse.
        /// </summary>
        WM_NCHITTEST = 0x0084,

        /// <summary>
        /// The WM_NCPAINT message is sent to a window when its frame must be painted. 
        /// </summary>
        WM_NCPAINT = 0x0085,

        /// <summary>
        /// The WM_NCACTIVATE message is sent to a window when its nonclient area needs to be changed to indicate an active or inactive state.
        /// </summary>
        WM_NCACTIVATE = 0x0086,

        /// <summary>
        /// The WM_GETDLGCODE message is sent to the window procedure associated with a control. By default, the system handles all keyboard input to the 
        /// control; the system interprets certain types of keyboard input as dialog box navigation keys. To override this default behavior, the control can 
        /// respond to the WM_GETDLGCODE message to indicate the types of input it wants to process itself.
        /// </summary>
        WM_GETDLGCODE = 0x0087,

        /// <summary>
        /// The WM_SYNCPAINT message is used to synchronize painting while avoiding linking independent GUI threads.
        /// </summary>
        WM_SYNCPAINT = 0x0088,

        /// <summary>
        /// The WM_NCMOUSEMOVE message is posted to a window when the cursor is moved within the nonclient area of the window. This message is posted to the 
        /// window that contains the cursor. If a window has captured the mouse, this message is not posted.
        /// </summary>
        WM_NCMOUSEMOVE = 0x00A0,

        /// <summary>
        /// The WM_NCLBUTTONDOWN message is posted when the user presses the left mouse button while the cursor is within the nonclient area of a window. This 
        /// message is posted to the window that contains the cursor. If a window has captured the mouse, this message is not posted.
        /// </summary>
        WM_NCLBUTTONDOWN = 0x00A1,

        /// <summary>
        /// The WM_NCLBUTTONUP message is posted when the user releases the left mouse button while the cursor is within the nonclient area of a window. This 
        /// message is posted to the window that contains the cursor. If a window has captured the mouse, this message is not posted.
        /// </summary>
        WM_NCLBUTTONUP = 0x00A2,

        /// <summary>
        /// The WM_NCLBUTTONDBLCLK message is posted when the user double-clicks the left mouse button while the cursor is within the nonclient area of a 
        /// window. This message is posted to the window that contains the cursor. If a window has captured the mouse, this message is not posted.
        /// </summary>
        WM_NCLBUTTONDBLCLK = 0x00A3,

        /// <summary>
        /// The WM_NCRBUTTONDOWN message is posted when the user presses the right mouse button while the cursor is within the nonclient area of a window. This 
        /// message is posted to the window that contains the cursor. If a window has captured the mouse, this message is not posted.
        /// </summary>
        WM_NCRBUTTONDOWN = 0x00A4,

        /// <summary>
        /// The WM_NCRBUTTONUP message is posted when the user releases the right mouse button while the cursor is within the nonclient area of a window. This 
        /// message is posted to the window that contains the cursor. If a window has captured the mouse, this message is not posted.
        /// </summary>
        WM_NCRBUTTONUP = 0x00A5,

        /// <summary>
        /// The WM_NCRBUTTONDBLCLK message is posted when the user double-clicks the right mouse button while the cursor is within the nonclient area of a 
        /// window. This message is posted to the window that contains the cursor. If a window has captured the mouse, this message is not posted.
        /// </summary>
        WM_NCRBUTTONDBLCLK = 0x00A6,

        /// <summary>
        /// The WM_NCMBUTTONDOWN message is posted when the user presses the middle mouse button while the cursor is within the nonclient area of a window. 
        /// This message is posted to the window that contains the cursor. If a window has captured the mouse, this message is not posted.
        /// </summary>
        WM_NCMBUTTONDOWN = 0x00A7,

        /// <summary>
        /// The WM_NCMBUTTONUP message is posted when the user releases the middle mouse button while the cursor is within the nonclient area of a window. 
        /// This message is posted to the window that contains the cursor. If a window has captured the mouse, this message is not posted.
        /// </summary>
        WM_NCMBUTTONUP = 0x00A8,

        /// <summary>
        /// The WM_NCMBUTTONDBLCLK message is posted when the user double-clicks the middle mouse button while the cursor is within the nonclient area of a 
        /// window. This message is posted to the window that contains the cursor. If a window has captured the mouse, this message is not posted.
        /// </summary>
        WM_NCMBUTTONDBLCLK = 0x00A9,

        /// <summary>
        /// The WM_NCXBUTTONDOWN message is posted when the user presses the first or second X button while the cursor is in the nonclient area of a window. 
        /// This message is posted to the window that contains the cursor. If a window has captured the mouse, this message is not posted.
        /// </summary>
        WM_NCXBUTTONDOWN = 0x00AB,

        /// <summary>
        /// The WM_NCXBUTTONUP message is posted when the user releases the first or second X button while the cursor is in the nonclient area of a window. 
        /// This message is posted to the window that contains the cursor. If a window has captured the mouse, this message is not posted.
        /// </summary>
        WM_NCXBUTTONUP = 0x00AC,

        /// <summary>
        /// The WM_NCXBUTTONDBLCLK message is posted when the user double-clicks the first or second X button while the cursor is in the nonclient area of a 
        /// window. This message is posted to the window that contains the cursor. If a window has captured the mouse, this message is not posted.
        /// </summary>
        WM_NCXBUTTONDBLCLK = 0x00AD,

        /// <summary>
        /// The WM_INPUT_DEVICE_CHANGE message is sent to the window that registered to receive raw input. A window receives this message through its 
        /// WindowProc function.
        /// </summary>
        WM_INPUT_DEVICE_CHANGE = 0x00FE,

        /// <summary>
        /// The WM_INPUT message is sent to the window that is getting raw input. 
        /// </summary>
        WM_INPUT = 0x00FF,

        /// <summary>
        /// The WM_KEYDOWN message is posted to the window with the keyboard focus when a nonsystem key is pressed. A nonsystem key is a key that is pressed 
        /// when the ALT key is not pressed. 
        /// </summary>
        WM_KEYDOWN = 0x0100,

        /// <summary>
        /// The WM_KEYUP message is posted to the window with the keyboard focus when a nonsystem key is released. A nonsystem key is a key that is pressed 
        /// when the ALT key is not pressed, or a keyboard key that is pressed when a window has the keyboard focus. 
        /// </summary>
        WM_KEYUP = 0x0101,

        /// <summary>
        /// The WM_CHAR message is posted to the window with the keyboard focus when a WM_KEYDOWN message is translated by the TranslateMessage function. The 
        /// WM_CHAR message contains the character code of the key that was pressed. 
        /// </summary>
        WM_CHAR = 0x0102,

        /// <summary>
        /// The WM_DEADCHAR message is posted to the window with the keyboard focus when a WM_KEYUP message is translated by the TranslateMessage function. 
        /// WM_DEADCHAR specifies a character code generated by a dead key. A dead key is a key that generates a character, such as the umlaut (double-dot), 
        /// that is combined with another character to form a composite character. For example, the umlaut-O character (Ö) is generated by typing the dead key 
        /// for the umlaut character, and then typing the O key. 
        /// </summary>
        WM_DEADCHAR = 0x0103,

        /// <summary>
        /// The WM_SYSKEYDOWN message is posted to the window with the keyboard focus when the user presses the F10 key (which activates the menu bar) or holds 
        /// down the ALT key and then presses another key. It also occurs when no window currently has the keyboard focus; in this case, the WM_SYSKEYDOWN 
        /// message is sent to the active window. The window that receives the message can distinguish between these two contexts by checking the context code 
        /// in the lParam parameter. 
        /// </summary>
        WM_SYSKEYDOWN = 0x0104,

        /// <summary>
        /// The WM_SYSKEYUP message is posted to the window with the keyboard focus when the user releases a key that was pressed while the ALT key was held 
        /// down. It also occurs when no window currently has the keyboard focus; in this case, the WM_SYSKEYUP message is sent to the active window. The 
        /// window that receives the message can distinguish between these two contexts by checking the context code in the lParam parameter. 
        /// </summary>
        WM_SYSKEYUP = 0x0105,

        /// <summary>
        /// The WM_SYSCHAR message is posted to the window with the keyboard focus when a WM_SYSKEYDOWN message is translated by the TranslateMessage function. 
        /// It specifies the character code of a system character key — that is, a character key that is pressed while the ALT key is down. 
        /// </summary>
        WM_SYSCHAR = 0x0106,

        /// <summary>
        /// The WM_SYSDEADCHAR message is sent to the window with the keyboard focus when a WM_SYSKEYDOWN message is translated by the TranslateMessage 
        /// function. WM_SYSDEADCHAR specifies the character code of a system dead key — that is, a dead key that is pressed while holding down the ALT key. 
        /// </summary>
        WM_SYSDEADCHAR = 0x0107,

        /// <summary>
        /// The WM_UNICHAR message is posted to the window with the keyboard focus when a WM_KEYDOWN message is translated by the TranslateMessage function. 
        /// The WM_UNICHAR message contains the character code of the key that was pressed. The WM_UNICHAR message is equivalent to WM_CHAR, but it uses 
        /// Unicode Transformation Format (UTF)-32, whereas WM_CHAR uses UTF-16. It is designed to send or post Unicode characters to ANSI windows and it can 
        /// can handle Unicode Supplementary Plane characters.
        /// </summary>
        WM_UNICHAR = 0x0109,

        /// <summary>
        /// Sent immediately before the IME generates the composition string as a result of a keystroke. A window receives this message through its WindowProc 
        /// function. 
        /// </summary>
        WM_IME_STARTCOMPOSITION = 0x010D,

        /// <summary>
        /// Sent to an application when the IME ends composition. A window receives this message through its WindowProc function. 
        /// </summary>
        WM_IME_ENDCOMPOSITION = 0x010E,

        /// <summary>
        /// Sent to an application when the IME changes composition status as a result of a keystroke. A window receives this message through its WindowProc 
        /// function. 
        /// </summary>
        WM_IME_COMPOSITION = 0x010F,

        /// <summary>
        /// The WM_INITDIALOG message is sent to the dialog box procedure immediately before a dialog box is displayed. Dialog box procedures typically use 
        /// this message to initialize controls and carry out any other initialization tasks that affect the appearance of the dialog box. 
        /// </summary>
        WM_INITDIALOG = 0x0110,

        /// <summary>
        /// The WM_COMMAND message is sent when the user selects a command item from a menu, when a control sends a notification message to its parent window, 
        /// or when an accelerator keystroke is translated. 
        /// </summary>
        WM_COMMAND = 0x0111,

        /// <summary>
        /// A window receives this message when the user chooses a command from the Window menu, clicks the maximize button, minimize button, restore button, 
        /// close button, or moves the form. You can stop the form from moving by filtering this out.
        /// </summary>
        WM_SYSCOMMAND = 0x0112,

        /// <summary>
        /// The WM_TIMER message is posted to the installing thread's message queue when a timer expires. The message is posted by the GetMessage or 
        /// PeekMessage function. 
        /// </summary>
        WM_TIMER = 0x0113,

        /// <summary>
        /// The WM_HSCROLL message is sent to a window when a scroll event occurs in the window's standard horizontal scroll bar. This message is also sent to 
        /// the owner of a horizontal scroll bar control when a scroll event occurs in the control. 
        /// </summary>
        WM_HSCROLL = 0x0114,

        /// <summary>
        /// The WM_VSCROLL message is sent to a window when a scroll event occurs in the window's standard vertical scroll bar. This message is also sent to 
        /// the owner of a vertical scroll bar control when a scroll event occurs in the control. 
        /// </summary>
        WM_VSCROLL = 0x0115,

        /// <summary>
        /// The WM_INITMENU message is sent when a menu is about to become active. It occurs when the user clicks an item on the menu bar or presses a menu 
        /// key. This allows the application to modify the menu before it is displayed. 
        /// </summary>
        WM_INITMENU = 0x0116,

        /// <summary>
        /// The WM_INITMENUPOPUP message is sent when a drop-down menu or submenu is about to become active. This allows an application to modify the menu 
        /// before it is displayed, without changing the entire menu. 
        /// </summary>
        WM_INITMENUPOPUP = 0x0117,

        /// <summary>
        /// The WM_MENUSELECT message is sent to a menu's owner window when the user selects a menu item. 
        /// </summary>
        WM_MENUSELECT = 0x011F,

        /// <summary>
        /// The WM_MENUCHAR message is sent when a menu is active and the user presses a key that does not correspond to any mnemonic or accelerator key. This 
        /// message is sent to the window that owns the menu. 
        /// </summary>
        WM_MENUCHAR = 0x0120,

        /// <summary>
        /// The WM_ENTERIDLE message is sent to the owner window of a modal dialog box or menu that is entering an idle state. A modal dialog box or menu 
        /// enters an idle state when no messages are waiting in its queue after it has processed one or more previous messages. 
        /// </summary>
        WM_ENTERIDLE = 0x0121,

        /// <summary>
        /// The WM_MENURBUTTONUP message is sent when the user releases the right mouse button while the cursor is on a menu item. 
        /// </summary>
        WM_MENURBUTTONUP = 0x0122,

        /// <summary>
        /// The WM_MENUDRAG message is sent to the owner of a drag-and-drop menu when the user drags a menu item. 
        /// </summary>
        WM_MENUDRAG = 0x0123,

        /// <summary>
        /// The WM_MENUGETOBJECT message is sent to the owner of a drag-and-drop menu when the mouse cursor enters a menu item or moves from the center of the 
        /// item to the top or bottom of the item. 
        /// </summary>
        WM_MENUGETOBJECT = 0x0124,

        /// <summary>
        /// The WM_UNINITMENUPOPUP message is sent when a drop-down menu or submenu has been destroyed. 
        /// </summary>
        WM_UNINITMENUPOPUP = 0x0125,

        /// <summary>
        /// The WM_MENUCOMMAND message is sent when the user makes a selection from a menu. 
        /// </summary>
        WM_MENUCOMMAND = 0x0126,

        /// <summary>
        /// An application sends the WM_CHANGEUISTATE message to indicate that the user interface (UI) state should be changed.
        /// </summary>
        WM_CHANGEUISTATE = 0x0127,

        /// <summary>
        /// An application sends the WM_UPDATEUISTATE message to change the user interface (UI) state for the specified window and all its child windows.
        /// </summary>
        WM_UPDATEUISTATE = 0x0128,

        /// <summary>
        /// An application sends the WM_QUERYUISTATE message to retrieve the user interface (UI) state for a window.
        /// </summary>
        WM_QUERYUISTATE = 0x0129,

        /// <summary>
        /// The WM_CTLCOLORMSGBOX message is sent to the owner window of a message box before Windows draws the message box. By responding to this message, the 
        /// owner window can set the text and background colors of the message box by using the given display device context handle. 
        /// </summary>
        WM_CTLCOLORMSGBOX = 0x0132,

        /// <summary>
        /// An edit control that is not read-only or disabled sends the WM_CTLCOLOREDIT message to its parent window when the control is about to be drawn. By 
        /// responding to this message, the parent window can use the specified device context handle to set the text and background colors of the edit 
        /// control. 
        /// </summary>
        WM_CTLCOLOREDIT = 0x0133,

        /// <summary>
        /// Sent to the parent window of a list box before the system draws the list box. By responding to this message, the parent window can set the text and 
        /// background colors of the list box by using the specified display device context handle. 
        /// </summary>
        WM_CTLCOLORLISTBOX = 0x0134,

        /// <summary>
        /// The WM_CTLCOLORBTN message is sent to the parent window of a button before drawing the button. The parent window can change the button's text and 
        /// background colors. However, only owner-drawn buttons respond to the parent window processing this message. 
        /// </summary>
        WM_CTLCOLORBTN = 0x0135,

        /// <summary>
        /// The WM_CTLCOLORDLG message is sent to a dialog box before the system draws the dialog box. By responding to this message, the dialog box can set 
        /// its text and background colors using the specified display device context handle. 
        /// </summary>
        WM_CTLCOLORDLG = 0x0136,

        /// <summary>
        /// The WM_CTLCOLORSCROLLBAR message is sent to the parent window of a scroll bar control when the control is about to be drawn. By responding to this 
        /// message, the parent window can use the display context handle to set the background color of the scroll bar control. 
        /// </summary>
        WM_CTLCOLORSCROLLBAR = 0x0137,

        /// <summary>
        /// A static control, or an edit control that is read-only or disabled, sends the WM_CTLCOLORSTATIC message to its parent window when the control is 
        /// about to be drawn. By responding to this message, the parent window can use the specified device context handle to set the text and background 
        /// colors of the static control. 
        /// </summary>
        WM_CTLCOLORSTATIC = 0x0138,

        /// <summary>
        /// Use WM_MOUSEFIRST to specify the first mouse message. Use the PeekMessage() Function.
        /// </summary>
        WM_MOUSEFIRST = 0x0200,

        /// <summary>
        /// The WM_MOUSEMOVE message is posted to a window when the cursor moves. If the mouse is not captured, the message is posted to the window that 
        /// contains the cursor. Otherwise, the message is posted to the window that has captured the mouse.
        /// </summary>
        WM_MOUSEMOVE = 0x0200,

        /// <summary>
        /// The WM_LBUTTONDOWN message is posted when the user presses the left mouse button while the cursor is in the client area of a window. If the mouse 
        /// is not captured, the message is posted to the window beneath the cursor. Otherwise, the message is posted to the window that has captured the 
        /// mouse.
        /// </summary>
        WM_LBUTTONDOWN = 0x0201,

        /// <summary>
        /// The WM_LBUTTONUP message is posted when the user releases the left mouse button while the cursor is in the client area of a window. If the mouse 
        /// is not captured, the message is posted to the window beneath the cursor. Otherwise, the message is posted to the window that has captured the 
        /// mouse.
        /// </summary>
        WM_LBUTTONUP = 0x0202,

        /// <summary>
        /// The WM_LBUTTONDBLCLK message is posted when the user double-clicks the left mouse button while the cursor is in the client area of a window. If the 
        /// mouse is not captured, the message is posted to the window beneath the cursor. Otherwise, the message is posted to the window that has captured the 
        /// mouse.
        /// </summary>
        WM_LBUTTONDBLCLK = 0x0203,

        /// <summary>
        /// The WM_RBUTTONDOWN message is posted when the user presses the right mouse button while the cursor is in the client area of a window. If the mouse 
        /// is not captured, the message is posted to the window beneath the cursor. Otherwise, the message is posted to the window that has captured the 
        /// mouse.
        /// </summary>
        WM_RBUTTONDOWN = 0x0204,

        /// <summary>
        /// The WM_RBUTTONUP message is posted when the user releases the right mouse button while the cursor is in the client area of a window. If the mouse 
        /// is not captured, the message is posted to the window beneath the cursor. Otherwise, the message is posted to the window that has captured the 
        /// mouse.
        /// </summary>
        WM_RBUTTONUP = 0x0205,

        /// <summary>
        /// The WM_RBUTTONDBLCLK message is posted when the user double-clicks the right mouse button while the cursor is in the client area of a window. If 
        /// the mouse is not captured, the message is posted to the window beneath the cursor. Otherwise, the message is posted to the window that has captured 
        /// the mouse.
        /// </summary>
        WM_RBUTTONDBLCLK = 0x0206,

        /// <summary>
        /// The WM_MBUTTONDOWN message is posted when the user presses the middle mouse button while the cursor is in the client area of a window. If the mouse 
        /// is not captured, the message is posted to the window beneath the cursor. Otherwise, the message is posted to the window that has captured the 
        /// mouse.
        /// </summary>
        WM_MBUTTONDOWN = 0x0207,

        /// <summary>
        /// The WM_MBUTTONUP message is posted when the user releases the middle mouse button while the cursor is in the client area of a window. If the mouse 
        /// is not captured, the message is posted to the window beneath the cursor. Otherwise, the message is posted to the window that has captured the 
        /// mouse.
        /// </summary>
        WM_MBUTTONUP = 0x0208,

        /// <summary>
        /// The WM_MBUTTONDBLCLK message is posted when the user double-clicks the middle mouse button while the cursor is in the client area of a window. If 
        /// the mouse is not captured, the message is posted to the window beneath the cursor. Otherwise, the message is posted to the window that has captured 
        /// the mouse.
        /// </summary>
        WM_MBUTTONDBLCLK = 0x0209,

        /// <summary>
        /// The WM_MOUSEWHEEL message is sent to the focus window when the mouse wheel is rotated. The DefWindowProc function propagates the message to the 
        /// window's parent. There should be no internal forwarding of the message, since DefWindowProc propagates it up the parent chain until it finds a 
        /// window that processes it.
        /// </summary>
        WM_MOUSEWHEEL = 0x020A,

        /// <summary>
        /// The WM_XBUTTONDOWN message is posted when the user presses the first or second X button while the cursor is in the client area of a window. If the 
        /// mouse is not captured, the message is posted to the window beneath the cursor. Otherwise, the message is posted to the window that has captured the 
        /// mouse. 
        /// </summary>
        WM_XBUTTONDOWN = 0x020B,

        /// <summary>
        /// The WM_XBUTTONUP message is posted when the user releases the first or second X button while the cursor is in the client area of a window. If the 
        /// mouse is not captured, the message is posted to the window beneath the cursor. Otherwise, the message is posted to the window that has captured the 
        /// mouse.
        /// </summary>
        WM_XBUTTONUP = 0x020C,

        /// <summary>
        /// The WM_XBUTTONDBLCLK message is posted when the user double-clicks the first or second X button while the cursor is in the client area of a window. 
        /// If the mouse is not captured, the message is posted to the window beneath the cursor. Otherwise, the message is posted to the window that has 
        /// captured the mouse.
        /// </summary>
        WM_XBUTTONDBLCLK = 0x020D,

        /// <summary>
        /// The WM_MOUSEHWHEEL message is sent to the focus window when the mouse's horizontal scroll wheel is tilted or rotated. The DefWindowProc function 
        /// propagates the message to the window's parent. There should be no internal forwarding of the message, since DefWindowProc propagates it up the 
        /// parent chain until it finds a window that processes it.
        /// </summary>
        WM_MOUSEHWHEEL = 0x020E,

        /// <summary>
        /// Use WM_MOUSELAST to specify the last mouse message. Used with PeekMessage() Function.
        /// </summary>
        WM_MOUSELAST = 0x020E,

        /// <summary>
        /// The WM_PARENTNOTIFY message is sent to the parent of a child window when the child window is created or destroyed, or when the user clicks a mouse 
        /// button while the cursor is over the child window. When the child window is being created, the system sends WM_PARENTNOTIFY just before the 
        /// CreateWindow or CreateWindowEx function that creates the window returns. When the child window is being destroyed, the system sends the message 
        /// before any processing to destroy the window takes place.
        /// </summary>
        WM_PARENTNOTIFY = 0x0210,

        /// <summary>
        /// The WM_ENTERMENULOOP message informs an application's main window procedure that a menu modal loop has been entered. 
        /// </summary>
        WM_ENTERMENULOOP = 0x0211,

        /// <summary>
        /// The WM_EXITMENULOOP message informs an application's main window procedure that a menu modal loop has been exited. 
        /// </summary>
        WM_EXITMENULOOP = 0x0212,

        /// <summary>
        /// The WM_NEXTMENU message is sent to an application when the right or left arrow key is used to switch between the menu bar and the system menu. 
        /// </summary>
        WM_NEXTMENU = 0x0213,

        /// <summary>
        /// The WM_SIZING message is sent to a window that the user is resizing. By processing this message, an application can monitor the size and position 
        /// of the drag rectangle and, if needed, change its size or position. 
        /// </summary>
        WM_SIZING = 0x0214,

        /// <summary>
        /// The WM_CAPTURECHANGED message is sent to the window that is losing the mouse capture.
        /// </summary>
        WM_CAPTURECHANGED = 0x0215,

        /// <summary>
        /// The WM_MOVING message is sent to a window that the user is moving. By processing this message, an application can monitor the position of the drag 
        /// rectangle and, if needed, change its position.
        /// </summary>
        WM_MOVING = 0x0216,

        /// <summary>
        /// Notifies applications that a power-management event has occurred.
        /// </summary>
        WM_POWERBROADCAST = 0x0218,

        /// <summary>
        /// Notifies an application of a change to the hardware configuration of a device or the computer.
        /// </summary>
        WM_DEVICECHANGE = 0x0219,

        /// <summary>
        /// An application sends the WM_MDICREATE message to a multiple-document interface (MDI) client window to create an MDI child window. 
        /// </summary>
        WM_MDICREATE = 0x0220,

        /// <summary>
        /// An application sends the WM_MDIDESTROY message to a multiple-document interface (MDI) client window to close an MDI child window. 
        /// </summary>
        WM_MDIDESTROY = 0x0221,

        /// <summary>
        /// An application sends the WM_MDIACTIVATE message to a multiple-document interface (MDI) client window to instruct the client window to activate a 
        /// different MDI child window. 
        /// </summary>
        WM_MDIACTIVATE = 0x0222,

        /// <summary>
        /// An application sends the WM_MDIRESTORE message to a multiple-document interface (MDI) client window to restore an MDI child window from maximized 
        /// or minimized size. 
        /// </summary>
        WM_MDIRESTORE = 0x0223,

        /// <summary>
        /// An application sends the WM_MDINEXT message to a multiple-document interface (MDI) client window to activate the next or previous child window. 
        /// </summary>
        WM_MDINEXT = 0x0224,

        /// <summary>
        /// An application sends the WM_MDIMAXIMIZE message to a multiple-document interface (MDI) client window to maximize an MDI child window. The system 
        /// resizes the child window to make its client area fill the client window. The system places the child window's window menu icon in the rightmost 
        /// position of the frame window's menu bar, and places the child window's restore icon in the leftmost position. The system also appends the title bar 
        /// text of the child window to that of the frame window. 
        /// </summary>
        WM_MDIMAXIMIZE = 0x0225,

        /// <summary>
        /// An application sends the WM_MDITILE message to a multiple-document interface (MDI) client window to arrange all of its MDI child windows in a tile 
        /// format. 
        /// </summary>
        WM_MDITILE = 0x0226,

        /// <summary>
        /// An application sends the WM_MDICASCADE message to a multiple-document interface (MDI) client window to arrange all its child windows in a cascade 
        /// format. 
        /// </summary>
        WM_MDICASCADE = 0x0227,

        /// <summary>
        /// An application sends the WM_MDIICONARRANGE message to a multiple-document interface (MDI) client window to arrange all minimized MDI child windows. 
        /// It does not affect child windows that are not minimized. 
        /// </summary>
        WM_MDIICONARRANGE = 0x0228,

        /// <summary>
        /// An application sends the WM_MDIGETACTIVE message to a multiple-document interface (MDI) client window to retrieve the handle to the active MDI 
        /// child window. 
        /// </summary>
        WM_MDIGETACTIVE = 0x0229,

        /// <summary>
        /// An application sends the WM_MDISETMENU message to a multiple-document interface (MDI) client window to replace the entire menu of an MDI frame 
        /// window, to replace the window menu of the frame window, or both. 
        /// </summary>
        WM_MDISETMENU = 0x0230,

        /// <summary>
        /// The WM_ENTERSIZEMOVE message is sent one time to a window after it enters the moving or sizing modal loop. The window enters the moving or sizing 
        /// modal loop when the user clicks the window's title bar or sizing border, or when the window passes the WM_SYSCOMMAND message to the DefWindowProc 
        /// function and the wParam parameter of the message specifies the SC_MOVE or SC_SIZE value. The operation is complete when DefWindowProc returns. 
        /// The system sends the WM_ENTERSIZEMOVE message regardless of whether the dragging of full windows is enabled.
        /// </summary>
        WM_ENTERSIZEMOVE = 0x0231,

        /// <summary>
        /// The WM_EXITSIZEMOVE message is sent one time to a window, after it has exited the moving or sizing modal loop. The window enters the moving or 
        /// sizing modal loop when the user clicks the window's title bar or sizing border, or when the window passes the WM_SYSCOMMAND message to the 
        /// DefWindowProc function and the wParam parameter of the message specifies the SC_MOVE or SC_SIZE value. The operation is complete when DefWindowProc 
        /// returns. 
        /// </summary>
        WM_EXITSIZEMOVE = 0x0232,

        /// <summary>
        /// Sent when the user drops a file on the window of an application that has registered itself as a recipient of dropped files.
        /// </summary>
        WM_DROPFILES = 0x0233,

        /// <summary>
        /// An application sends the WM_MDIREFRESHMENU message to a multiple-document interface (MDI) client window to refresh the window menu of the MDI frame 
        /// window. 
        /// </summary>
        WM_MDIREFRESHMENU = 0x0234,

        /// <summary>
        /// Sent to an application when a window is activated. A window receives this message through its WindowProc function. 
        /// </summary>
        WM_IME_SETCONTEXT = 0x0281,

        /// <summary>
        /// Sent to an application to notify it of changes to the IME window. A window receives this message through its WindowProc function. 
        /// </summary>
        WM_IME_NOTIFY = 0x0282,

        /// <summary>
        /// Sent by an application to direct the IME window to carry out the requested command. The application uses this message to control the IME window 
        /// that it has created. To send this message, the application calls the SendMessage function with the following parameters.
        /// </summary>
        WM_IME_CONTROL = 0x0283,

        /// <summary>
        /// Sent to an application when the IME window finds no space to extend the area for the composition window. A window receives this message through its 
        /// WindowProc function. 
        /// </summary>
        WM_IME_COMPOSITIONFULL = 0x0284,

        /// <summary>
        /// Sent to an application when the operating system is about to change the current IME. A window receives this message through its WindowProc 
        /// function. 
        /// </summary>
        WM_IME_SELECT = 0x0285,

        /// <summary>
        /// Sent to an application when the IME gets a character of the conversion result. A window receives this message through its WindowProc function. 
        /// </summary>
        WM_IME_CHAR = 0x0286,

        /// <summary>
        /// Sent to an application to provide commands and request information. A window receives this message through its WindowProc function. 
        /// </summary>
        WM_IME_REQUEST = 0x0288,

        /// <summary>
        /// Sent to an application by the IME to notify the application of a key press and to keep message order. A window receives this message through its 
        /// WindowProc function. 
        /// </summary>
        WM_IME_KEYDOWN = 0x0290,

        /// <summary>
        /// Sent to an application by the IME to notify the application of a key release and to keep message order. A window receives this message through its 
        /// WindowProc function. 
        /// </summary>
        WM_IME_KEYUP = 0x0291,

        /// <summary>
        /// The WM_MOUSEHOVER message is posted to a window when the cursor hovers over the client area of the window for the period of time specified in a 
        /// prior call to TrackMouseEvent.
        /// </summary>
        WM_MOUSEHOVER = 0x02A1,

        /// <summary>
        /// The WM_MOUSELEAVE message is posted to a window when the cursor leaves the client area of the window specified in a prior call to TrackMouseEvent.
        /// </summary>
        WM_MOUSELEAVE = 0x02A3,

        /// <summary>
        /// The WM_NCMOUSEHOVER message is posted to a window when the cursor hovers over the nonclient area of the window for the period of time specified in 
        /// a prior call to TrackMouseEvent.
        /// </summary>
        WM_NCMOUSEHOVER = 0x02A0,

        /// <summary>
        /// The WM_NCMOUSELEAVE message is posted to a window when the cursor leaves the nonclient area of the window specified in a prior call to 
        /// TrackMouseEvent.
        /// </summary>
        WM_NCMOUSELEAVE = 0x02A2,

        /// <summary>
        /// The WM_WTSSESSION_CHANGE message notifies applications of changes in session state.
        /// </summary>
        WM_WTSSESSION_CHANGE = 0x02B1,
        WM_TABLET_FIRST = 0x02c0,
        WM_TABLET_LAST = 0x02df,

        /// <summary>
        /// An application sends a WM_CUT message to an edit control or combo box to delete (cut) the current selection, if any, in the edit control and copy 
        /// the deleted text to the clipboard in CF_TEXT format. 
        /// </summary>
        WM_CUT = 0x0300,

        /// <summary>
        /// An application sends the WM_COPY message to an edit control or combo box to copy the current selection to the clipboard in CF_TEXT format. 
        /// </summary>
        WM_COPY = 0x0301,

        /// <summary>
        /// An application sends a WM_PASTE message to an edit control or combo box to copy the current content of the clipboard to the edit control at the 
        /// current caret position. Data is inserted only if the clipboard contains data in CF_TEXT format. 
        /// </summary>
        WM_PASTE = 0x0302,

        /// <summary>
        /// An application sends a WM_CLEAR message to an edit control or combo box to delete (clear) the current selection, if any, from the edit control. 
        /// </summary>
        WM_CLEAR = 0x0303,

        /// <summary>
        /// An application sends a WM_UNDO message to an edit control to undo the last operation. When this message is sent to an edit control, the previously 
        /// deleted text is restored or the previously added text is deleted.
        /// </summary>
        WM_UNDO = 0x0304,

        /// <summary>
        /// The WM_RENDERFORMAT message is sent to the clipboard owner if it has delayed rendering a specific clipboard format and if an application has 
        /// requested data in that format. The clipboard owner must render data in the specified format and place it on the clipboard by calling the 
        /// SetClipboardData function. 
        /// </summary>
        WM_RENDERFORMAT = 0x0305,

        /// <summary>
        /// The WM_RENDERALLFORMATS message is sent to the clipboard owner before it is destroyed, if the clipboard owner has delayed rendering one or more 
        /// clipboard formats. For the content of the clipboard to remain available to other applications, the clipboard owner must render data in all the 
        /// formats it is capable of generating, and place the data on the clipboard by calling the SetClipboardData function. 
        /// </summary>
        WM_RENDERALLFORMATS = 0x0306,

        /// <summary>
        /// The WM_DESTROYCLIPBOARD message is sent to the clipboard owner when a call to the EmptyClipboard function empties the clipboard. 
        /// </summary>
        WM_DESTROYCLIPBOARD = 0x0307,

        /// <summary>
        /// The WM_DRAWCLIPBOARD message is sent to the first window in the clipboard viewer chain when the content of the clipboard changes. This enables a 
        /// clipboard viewer window to display the new content of the clipboard. 
        /// </summary>
        WM_DRAWCLIPBOARD = 0x0308,

        /// <summary>
        /// The WM_PAINTCLIPBOARD message is sent to the clipboard owner by a clipboard viewer window when the clipboard contains data in the CF_OWNERDISPLAY 
        /// format and the clipboard viewer's client area needs repainting. 
        /// </summary>
        WM_PAINTCLIPBOARD = 0x0309,

        /// <summary>
        /// The WM_VSCROLLCLIPBOARD message is sent to the clipboard owner by a clipboard viewer window when the clipboard contains data in the CF_OWNERDISPLAY 
        /// format and an event occurs in the clipboard viewer's vertical scroll bar. The owner should scroll the clipboard image and update the scroll bar 
        /// values. 
        /// </summary>
        WM_VSCROLLCLIPBOARD = 0x030A,

        /// <summary>
        /// The WM_SIZECLIPBOARD message is sent to the clipboard owner by a clipboard viewer window when the clipboard contains data in the CF_OWNERDISPLAY 
        /// format and the clipboard viewer's client area has changed size. 
        /// </summary>
        WM_SIZECLIPBOARD = 0x030B,

        /// <summary>
        /// The WM_ASKCBFORMATNAME message is sent to the clipboard owner by a clipboard viewer window to request the name of a CF_OWNERDISPLAY clipboard 
        /// format.
        /// </summary>
        WM_ASKCBFORMATNAME = 0x030C,

        /// <summary>
        /// The WM_CHANGECBCHAIN message is sent to the first window in the clipboard viewer chain when a window is being removed from the chain. 
        /// </summary>
        WM_CHANGECBCHAIN = 0x030D,

        /// <summary>
        /// The WM_HSCROLLCLIPBOARD message is sent to the clipboard owner by a clipboard viewer window. This occurs when the clipboard contains data in the 
        /// CF_OWNERDISPLAY format and an event occurs in the clipboard viewer's horizontal scroll bar. The owner should scroll the clipboard image and update 
        /// the scroll bar values. 
        /// </summary>
        WM_HSCROLLCLIPBOARD = 0x030E,

        /// <summary>
        /// This message informs a window that it is about to receive the keyboard focus, giving the window the opportunity to realize its logical palette when 
        /// it receives the focus. 
        /// </summary>
        WM_QUERYNEWPALETTE = 0x030F,

        /// <summary>
        /// The WM_PALETTEISCHANGING message informs applications that an application is going to realize its logical palette. 
        /// </summary>
        WM_PALETTEISCHANGING = 0x0310,

        /// <summary>
        /// This message is sent by the OS to all top-level and overlapped windows after the window with the keyboard focus realizes its logical palette. 
        /// This message enables windows that do not have the keyboard focus to realize their logical palettes and update their client areas.
        /// </summary>
        WM_PALETTECHANGED = 0x0311,

        /// <summary>
        /// The WM_HOTKEY message is posted when the user presses a hot key registered by the RegisterHotKey function. The message is placed at the top of the 
        /// message queue associated with the thread that registered the hot key. 
        /// </summary>
        WM_HOTKEY = 0x0312,

        /// <summary>
        /// The WM_PRINT message is sent to a window to request that it draw itself in the specified device context, most commonly in a printer device context.
        /// </summary>
        WM_PRINT = 0x0317,

        /// <summary>
        /// The WM_PRINTCLIENT message is sent to a window to request that it draw its client area in the specified device context, most commonly in a printer 
        /// device context.
        /// </summary>
        WM_PRINTCLIENT = 0x0318,

        /// <summary>
        /// The WM_APPCOMMAND message notifies a window that the user generated an application command event, for example, by clicking an application command 
        /// button using the mouse or typing an application command key on the keyboard.
        /// </summary>
        WM_APPCOMMAND = 0x0319,

        /// <summary>
        /// The WM_THEMECHANGED message is broadcast to every window following a theme change event. Examples of theme change events are the activation of a 
        /// theme, the deactivation of a theme, or a transition from one theme to another.
        /// </summary>
        WM_THEMECHANGED = 0x031A,

        /// <summary>
        /// Sent when the contents of the clipboard have changed.
        /// </summary>
        WM_CLIPBOARDUPDATE = 0x031D,

        /// <summary>
        /// The system will send a window the WM_DWMCOMPOSITIONCHANGED message to indicate that the availability of desktop composition has changed.
        /// </summary>
        WM_DWMCOMPOSITIONCHANGED = 0x031E,

        /// <summary>
        /// WM_DWMNCRENDERINGCHANGED is called when the non-client area rendering status of a window has changed. Only windows that have set the flag 
        /// DWM_BLURBEHIND.fTransitionOnMaximized to true will get this message. 
        /// </summary>
        WM_DWMNCRENDERINGCHANGED = 0x031F,

        /// <summary>
        /// Sent to all top-level windows when the colorization color has changed. 
        /// </summary>
        WM_DWMCOLORIZATIONCOLORCHANGED = 0x0320,

        /// <summary>
        /// WM_DWMWINDOWMAXIMIZEDCHANGE will let you know when a DWM composed window is maximized. You also have to register for this message as well. You'd 
        /// have other windowd go opaque when this message is sent.
        /// </summary>
        WM_DWMWINDOWMAXIMIZEDCHANGE = 0x0321,

        /// <summary>
        /// Sent to request extended title bar information. A window receives this message through its WindowProc function.
        /// </summary>
        WM_GETTITLEBARINFOEX = 0x033F,
        WM_HANDHELDFIRST = 0x0358,
        WM_HANDHELDLAST = 0x035F,
        WM_AFXFIRST = 0x0360,
        WM_AFXLAST = 0x037F,
        WM_PENWINFIRST = 0x0380,
        WM_PENWINLAST = 0x038F,

        /// <summary>
        /// The WM_APP constant is used by applications to help define private messages, usually of the form WM_APP+X, where X is an integer value. 
        /// </summary>
        WM_APP = 0x8000,

        /// <summary>
        /// The WM_USER constant is used by applications to help define private messages for use by private window classes, usually of the form WM_USER+X, 
        /// where X is an integer value. 
        /// </summary>
        WM_USER = 0x0400,

        /// <summary>
        /// An application sends the WM_CPL_LAUNCH message to Windows Control Panel to request that a Control Panel application be started. 
        /// </summary>
        WM_CPL_LAUNCH = WM_USER + 0x1000,

        /// <summary>
        /// The WM_CPL_LAUNCHED message is sent when a Control Panel application, started by the WM_CPL_LAUNCH message, has closed. The WM_CPL_LAUNCHED message 
        /// is sent to the window identified by the wParam parameter of the WM_CPL_LAUNCH message that started the application. 
        /// </summary>
        WM_CPL_LAUNCHED = WM_USER + 0x1001,

        /// <summary>
        /// WM_SYSTIMER is a well-known yet still undocumented message. Windows uses WM_SYSTIMER for internal actions like scrolling.
        /// </summary>
        WM_SYSTIMER = 0x118
    }

	public enum DBT : uint
	{
		DBT_DEVICEARRIVAL = 32768,
    
		/// DBT_DEVICEQUERYREMOVE -> 0x8001
		DBT_DEVICEQUERYREMOVE = 32769,
    
		/// DBT_DEVICEQUERYREMOVEFAILED -> 0x8002
		DBT_DEVICEQUERYREMOVEFAILED = 32770,
    
		/// DBT_DEVICEREMOVEPENDING -> 0x8003
		DBT_DEVICEREMOVEPENDING = 32771,
    
		/// DBT_DEVICEREMOVECOMPLETE -> 0x8004
		DBT_DEVICEREMOVECOMPLETE = 32772,
    
		/// DBT_DEVICETYPESPECIFIC -> 0x8005
		DBT_DEVICETYPESPECIFIC = 32773,
    
		/// DBT_CUSTOMEVENT -> 0x8006
		DBT_CUSTOMEVENT = 32774,
    
		/// DBT_DEVINSTENUMERATED -> 0x8007
		DBT_DEVINSTENUMERATED = 32775,
    
		/// DBT_DEVINSTSTARTED -> 0x8008
		DBT_DEVINSTSTARTED = 32776,
    
		/// DBT_DEVINSTREMOVED -> 0x8009
		DBT_DEVINSTREMOVED = 32777,
    
		/// DBT_DEVINSTPROPERTYCHANGED -> 0x800A
		DBT_DEVINSTPROPERTYCHANGED = 32778,
    
		/// DBT_DEVTYP_OEM -> 0x00000000
		DBT_DEVTYP_OEM = 0,
    
		/// DBT_DEVTYP_DEVNODE -> 0x00000001
		DBT_DEVTYP_DEVNODE = 1,
    
		/// DBT_DEVTYP_VOLUME -> 0x00000002
		DBT_DEVTYP_VOLUME = 2,
    
		/// DBT_DEVTYP_PORT -> 0x00000003
		DBT_DEVTYP_PORT = 3,
    
		/// DBT_DEVTYP_NET -> 0x00000004
		DBT_DEVTYP_NET = 4,
    
		/// DBT_DEVTYP_DEVICEINTERFACE -> 0x00000005
		DBT_DEVTYP_DEVICEINTERFACE = 5,
    
		/// DBT_DEVTYP_HANDLE -> 0x00000006
		DBT_DEVTYP_HANDLE = 6,
    
		/// DBT_DEVTYP_DEVINST -> 0x00000007
		DBT_DEVTYP_DEVINST = 7,

	}

	public enum SM
	{
		SM_CXSCREEN = 0,
    
    /// SM_CYSCREEN -> 1
    SM_CYSCREEN = 1,
    
    /// SM_CXVSCROLL -> 2
    SM_CXVSCROLL = 2,
    
    /// SM_CYHSCROLL -> 3
    SM_CYHSCROLL = 3,
    
    /// SM_CYCAPTION -> 4
    SM_CYCAPTION = 4,
    
    /// SM_CXBORDER -> 5
    SM_CXBORDER = 5,
    
    /// SM_CYBORDER -> 6
    SM_CYBORDER = 6,
    
    /// SM_CXDLGFRAME -> 7
    SM_CXDLGFRAME = 7,
    
    /// SM_CYDLGFRAME -> 8
    SM_CYDLGFRAME = 8,
    
    /// SM_CYVTHUMB -> 9
    SM_CYVTHUMB = 9,
    
    /// SM_CXHTHUMB -> 10
    SM_CXHTHUMB = 10,
    
    /// SM_CXICON -> 11
    SM_CXICON = 11,
    
    /// SM_CYICON -> 12
    SM_CYICON = 12,
    
    /// SM_CXCURSOR -> 13
    SM_CXCURSOR = 13,
    
    /// SM_CYCURSOR -> 14
    SM_CYCURSOR = 14,
    
    /// SM_CYMENU -> 15
    SM_CYMENU = 15,
    
    /// SM_CXFULLSCREEN -> 16
    SM_CXFULLSCREEN = 16,
    
    /// SM_CYFULLSCREEN -> 17
    SM_CYFULLSCREEN = 17,
    
    /// SM_CYKANJIWINDOW -> 18
    SM_CYKANJIWINDOW = 18,
    
    /// SM_MOUSEPRESENT -> 19
    SM_MOUSEPRESENT = 19,
    
    /// SM_CYVSCROLL -> 20
    SM_CYVSCROLL = 20,
    
    /// SM_CXHSCROLL -> 21
    SM_CXHSCROLL = 21,
    
    /// SM_DEBUG -> 22
    SM_DEBUG = 22,
    
    /// SM_SWAPBUTTON -> 23
    SM_SWAPBUTTON = 23,
    
    /// SM_RESERVED1 -> 24
    SM_RESERVED1 = 24,
    
    /// SM_RESERVED2 -> 25
    SM_RESERVED2 = 25,
    
    /// SM_RESERVED3 -> 26
    SM_RESERVED3 = 26,
    
    /// SM_RESERVED4 -> 27
    SM_RESERVED4 = 27,
    
    /// SM_CXMIN -> 28
    SM_CXMIN = 28,
    
    /// SM_CYMIN -> 29
    SM_CYMIN = 29,
    
    /// SM_CXSIZE -> 30
    SM_CXSIZE = 30,
    
    /// SM_CYSIZE -> 31
    SM_CYSIZE = 31,
    
    /// SM_CXFRAME -> 32
    SM_CXFRAME = 32,
    
    /// SM_CYFRAME -> 33
    SM_CYFRAME = 33,
    
    /// SM_CXMINTRACK -> 34
    SM_CXMINTRACK = 34,
    
    /// SM_CYMINTRACK -> 35
    SM_CYMINTRACK = 35,
    
    /// SM_CXDOUBLECLK -> 36
    SM_CXDOUBLECLK = 36,
    
    /// SM_CYDOUBLECLK -> 37
    SM_CYDOUBLECLK = 37,
    
    /// SM_CXICONSPACING -> 38
    SM_CXICONSPACING = 38,
    
    /// SM_CYICONSPACING -> 39
    SM_CYICONSPACING = 39,
    
    /// SM_MENUDROPALIGNMENT -> 40
    SM_MENUDROPALIGNMENT = 40,
    
    /// SM_PENWINDOWS -> 41
    SM_PENWINDOWS = 41,
    
    /// SM_DBCSENABLED -> 42
    SM_DBCSENABLED = 42,
    
    /// SM_CMOUSEBUTTONS -> 43
    SM_CMOUSEBUTTONS = 43,
    
    /// SM_CXFIXEDFRAME -> SM_CXDLGFRAME
    SM_CXFIXEDFRAME = SM_CXDLGFRAME,
    
    /// SM_CYFIXEDFRAME -> SM_CYDLGFRAME
    SM_CYFIXEDFRAME = SM_CYDLGFRAME,
    
    /// SM_CXSIZEFRAME -> SM_CXFRAME
    SM_CXSIZEFRAME = SM_CXFRAME,
    
    /// SM_CYSIZEFRAME -> SM_CYFRAME
    SM_CYSIZEFRAME = SM_CYFRAME,
    
    /// SM_SECURE -> 44
    SM_SECURE = 44,
    
    /// SM_CXEDGE -> 45
    SM_CXEDGE = 45,
    
    /// SM_CYEDGE -> 46
    SM_CYEDGE = 46,
    
    /// SM_CXMINSPACING -> 47
    SM_CXMINSPACING = 47,
    
    /// SM_CYMINSPACING -> 48
    SM_CYMINSPACING = 48,
    
    /// SM_CXSMICON -> 49
    SM_CXSMICON = 49,
    
    /// SM_CYSMICON -> 50
    SM_CYSMICON = 50,
    
    /// SM_CYSMCAPTION -> 51
    SM_CYSMCAPTION = 51,
    
    /// SM_CXSMSIZE -> 52
    SM_CXSMSIZE = 52,
    
    /// SM_CYSMSIZE -> 53
    SM_CYSMSIZE = 53,
    
    /// SM_CXMENUSIZE -> 54
    SM_CXMENUSIZE = 54,
    
    /// SM_CYMENUSIZE -> 55
    SM_CYMENUSIZE = 55,
    
    /// SM_ARRANGE -> 56
    SM_ARRANGE = 56,
    
    /// SM_CXMINIMIZED -> 57
    SM_CXMINIMIZED = 57,
    
    /// SM_CYMINIMIZED -> 58
    SM_CYMINIMIZED = 58,
    
    /// SM_CXMAXTRACK -> 59
    SM_CXMAXTRACK = 59,
    
    /// SM_CYMAXTRACK -> 60
    SM_CYMAXTRACK = 60,
    
    /// SM_CXMAXIMIZED -> 61
    SM_CXMAXIMIZED = 61,
    
    /// SM_CYMAXIMIZED -> 62
    SM_CYMAXIMIZED = 62,
    
    /// SM_NETWORK -> 63
    SM_NETWORK = 63,
    
    /// SM_CLEANBOOT -> 67
    SM_CLEANBOOT = 67,
    
    /// SM_CXDRAG -> 68
    SM_CXDRAG = 68,
    
    /// SM_CYDRAG -> 69
    SM_CYDRAG = 69,
    
    /// SM_SHOWSOUNDS -> 70
    SM_SHOWSOUNDS = 70,
    
    /// SM_CXMENUCHECK -> 71
    SM_CXMENUCHECK = 71,
    
    /// SM_CYMENUCHECK -> 72
    SM_CYMENUCHECK = 72,
    
    /// SM_SLOWMACHINE -> 73
    SM_SLOWMACHINE = 73,
    
    /// SM_MIDEASTENABLED -> 74
    SM_MIDEASTENABLED = 74,
    
    /// SM_MOUSEWHEELPRESENT -> 75
    SM_MOUSEWHEELPRESENT = 75,
    
    /// SM_XVIRTUALSCREEN -> 76
    SM_XVIRTUALSCREEN = 76,
    
    /// SM_YVIRTUALSCREEN -> 77
    SM_YVIRTUALSCREEN = 77,
    
    /// SM_CXVIRTUALSCREEN -> 78
    SM_CXVIRTUALSCREEN = 78,
    
    /// SM_CYVIRTUALSCREEN -> 79
    SM_CYVIRTUALSCREEN = 79,
    
    /// SM_CMONITORS -> 80
    SM_CMONITORS = 80,
    
    /// SM_SAMEDISPLAYFORMAT -> 81
    SM_SAMEDISPLAYFORMAT = 81,
    
    /// SM_IMMENABLED -> 82
    SM_IMMENABLED = 82,
    
    /// SM_CXFOCUSBORDER -> 83
    SM_CXFOCUSBORDER = 83,
    
    /// SM_CYFOCUSBORDER -> 84
    SM_CYFOCUSBORDER = 84,
    
    /// SM_TABLETPC -> 86
    SM_TABLETPC = 86,
    
    /// SM_MEDIACENTER -> 87
    SM_MEDIACENTER = 87,
    
    /// SM_STARTER -> 88
    SM_STARTER = 88,
    
    /// SM_SERVERR2 -> 89
    SM_SERVERR2 = 89,
    
    /// SM_CMETRICS -> 93
    SM_CMETRICS = 93,
    
    /// SM_REMOTESESSION -> 0x1000
    SM_REMOTESESSION = 4096,
    
    /// SM_SHUTTINGDOWN -> 0x2000
    SM_SHUTTINGDOWN = 8192,
    
    /// SM_REMOTECONTROL -> 0x2001
    SM_REMOTECONTROL = 8193,
    
    /// SM_CARETBLINKINGENABLED -> 0x2002
    SM_CARETBLINKINGENABLED = 8194,
    
    /// SM_MOUSEHORIZONTALWHEELPRESENT -> 91
    SM_MOUSEHORIZONTALWHEELPRESENT = 91,
    
    /// SM_CXPADDEDBORDER -> 92
    SM_CXPADDEDBORDER = 92,

	}

	public enum MDITILE
	{
		/// MDIS_ALLCHILDSTYLES -> 0x0001
    MDIS_ALLCHILDSTYLES = 1,
    
    /// MDITILE_VERTICAL -> 0x0000
    MDITILE_VERTICAL = 0,
    
    /// MDITILE_HORIZONTAL -> 0x0001
    MDITILE_HORIZONTAL = 1,
    
    /// MDITILE_SKIPDISABLED -> 0x0002
    MDITILE_SKIPDISABLED = 2,
    
    /// MDITILE_ZORDER -> 0x0004
    MDITILE_ZORDER = 4,
	}

	public enum CS
	{
		/// CS_VREDRAW -> 0x0001
    CS_VREDRAW = 1,
    
    /// CS_HREDRAW -> 0x0002
    CS_HREDRAW = 2,
    
    /// CS_DBLCLKS -> 0x0008
    CS_DBLCLKS = 8,
    
    /// CS_OWNDC -> 0x0020
    CS_OWNDC = 32,
    
    /// CS_CLASSDC -> 0x0040
    CS_CLASSDC = 64,
    
    /// CS_PARENTDC -> 0x0080
    CS_PARENTDC = 128,
    
    /// CS_NOCLOSE -> 0x0200
    CS_NOCLOSE = 512,
    
    /// CS_SAVEBITS -> 0x0800
    CS_SAVEBITS = 2048,
    
    /// CS_BYTEALIGNCLIENT -> 0x1000
    CS_BYTEALIGNCLIENT = 4096,
    
    /// CS_BYTEALIGNWINDOW -> 0x2000
    CS_BYTEALIGNWINDOW = 8192,
    
    /// CS_GLOBALCLASS -> 0x4000
    CS_GLOBALCLASS = 16384,
    
    /// CS_IME -> 0x00010000
    CS_IME = 65536,
    
    /// CS_DROPSHADOW -> 0x00020000
    CS_DROPSHADOW = 131072,

	}

	public enum CB
	{
		/// CB_GETEDITSEL -> 0x0140
    CB_GETEDITSEL = 320,
    
    /// CB_LIMITTEXT -> 0x0141
    CB_LIMITTEXT = 321,
    
    /// CB_SETEDITSEL -> 0x0142
    CB_SETEDITSEL = 322,
    
    /// CB_ADDSTRING -> 0x0143
    CB_ADDSTRING = 323,
    
    /// CB_DELETESTRING -> 0x0144
    CB_DELETESTRING = 324,
    
    /// CB_DIR -> 0x0145
    CB_DIR = 325,
    
    /// CB_GETCOUNT -> 0x0146
    CB_GETCOUNT = 326,
    
    /// CB_GETCURSEL -> 0x0147
    CB_GETCURSEL = 327,
    
    /// CB_GETLBTEXT -> 0x0148
    CB_GETLBTEXT = 328,
    
    /// CB_GETLBTEXTLEN -> 0x0149
    CB_GETLBTEXTLEN = 329,
    
    /// CB_INSERTSTRING -> 0x014A
    CB_INSERTSTRING = 330,
    
    /// CB_RESETCONTENT -> 0x014B
    CB_RESETCONTENT = 331,
    
    /// CB_FINDSTRING -> 0x014C
    CB_FINDSTRING = 332,
    
    /// CB_SELECTSTRING -> 0x014D
    CB_SELECTSTRING = 333,
    
    /// CB_SETCURSEL -> 0x014E
    CB_SETCURSEL = 334,
    
    /// CB_SHOWDROPDOWN -> 0x014F
    CB_SHOWDROPDOWN = 335,
    
    /// CB_GETITEMDATA -> 0x0150
    CB_GETITEMDATA = 336,
    
    /// CB_SETITEMDATA -> 0x0151
    CB_SETITEMDATA = 337,
    
    /// CB_GETDROPPEDCONTROLRECT -> 0x0152
    CB_GETDROPPEDCONTROLRECT = 338,
    
    /// CB_SETITEMHEIGHT -> 0x0153
    CB_SETITEMHEIGHT = 339,
    
    /// CB_GETITEMHEIGHT -> 0x0154
    CB_GETITEMHEIGHT = 340,
    
    /// CB_SETEXTENDEDUI -> 0x0155
    CB_SETEXTENDEDUI = 341,
    
    /// CB_GETEXTENDEDUI -> 0x0156
    CB_GETEXTENDEDUI = 342,
    
    /// CB_GETDROPPEDSTATE -> 0x0157
    CB_GETDROPPEDSTATE = 343,
    
    /// CB_FINDSTRINGEXACT -> 0x0158
    CB_FINDSTRINGEXACT = 344,
    
    /// CB_SETLOCALE -> 0x0159
    CB_SETLOCALE = 345,
    
    /// CB_GETLOCALE -> 0x015A
    CB_GETLOCALE = 346,
    
    /// CB_GETTOPINDEX -> 0x015b
    CB_GETTOPINDEX = 347,
    
    /// CB_SETTOPINDEX -> 0x015c
    CB_SETTOPINDEX = 348,
    
    /// CB_GETHORIZONTALEXTENT -> 0x015d
    CB_GETHORIZONTALEXTENT = 349,
    
    /// CB_SETHORIZONTALEXTENT -> 0x015e
    CB_SETHORIZONTALEXTENT = 350,
    
    /// CB_GETDROPPEDWIDTH -> 0x015f
    CB_GETDROPPEDWIDTH = 351,
    
    /// CB_SETDROPPEDWIDTH -> 0x0160
    CB_SETDROPPEDWIDTH = 352,
    
    /// CB_INITSTORAGE -> 0x0161
    CB_INITSTORAGE = 353,
    
    /// CB_GETCOMBOBOXINFO -> 0x0164
    CB_GETCOMBOBOXINFO = 356,

	}

	public enum CBS
	{
		/// CBS_SIMPLE -> 0x0001L
    CBS_SIMPLE = 1,
    
    /// CBS_DROPDOWN -> 0x0002L
    CBS_DROPDOWN = 2,
    
    /// CBS_DROPDOWNLIST -> 0x0003L
    CBS_DROPDOWNLIST = 3,
    
    /// CBS_OWNERDRAWFIXED -> 0x0010L
    CBS_OWNERDRAWFIXED = 16,
    
    /// CBS_OWNERDRAWVARIABLE -> 0x0020L
    CBS_OWNERDRAWVARIABLE = 32,
    
    /// CBS_AUTOHSCROLL -> 0x0040L
    CBS_AUTOHSCROLL = 64,
    
    /// CBS_OEMCONVERT -> 0x0080L
    CBS_OEMCONVERT = 128,
    
    /// CBS_SORT -> 0x0100L
    CBS_SORT = 256,
    
    /// CBS_HASSTRINGS -> 0x0200L
    CBS_HASSTRINGS = 512,
    
    /// CBS_NOINTEGRALHEIGHT -> 0x0400L
    CBS_NOINTEGRALHEIGHT = 1024,
    
    /// CBS_DISABLENOSCROLL -> 0x0800L
    CBS_DISABLENOSCROLL = 2048,
    
    /// CBS_UPPERCASE -> 0x2000L
    CBS_UPPERCASE = 8192,
    
    /// CBS_LOWERCASE -> 0x4000L
    CBS_LOWERCASE = 16384,

	}

	public enum DS
	{
		/// DS_ABSALIGN -> 0x01L
    DS_ABSALIGN = 1,
    
    /// DS_SYSMODAL -> 0x02L
    DS_SYSMODAL = 2,
    
    /// DS_LOCALEDIT -> 0x20L
    DS_LOCALEDIT = 32,
    
    /// DS_SETFONT -> 0x40L
    DS_SETFONT = 64,
    
    /// DS_MODALFRAME -> 0x80L
    DS_MODALFRAME = 128,
    
    /// DS_NOIDLEMSG -> 0x100L
    DS_NOIDLEMSG = 256,
    
    /// DS_SETFOREGROUND -> 0x200L
    DS_SETFOREGROUND = 512,
    
    /// DS_3DLOOK -> 0x0004L
    DS_3DLOOK = 4,
    
    /// DS_FIXEDSYS -> 0x0008L
    DS_FIXEDSYS = 8,
    
    /// DS_NOFAILCREATE -> 0x0010L
    DS_NOFAILCREATE = 16,
    
    /// DS_CONTROL -> 0x0400L
    DS_CONTROL = 1024,
    
    /// DS_CENTER -> 0x0800L
    DS_CENTER = 2048,
    
    /// DS_CENTERMOUSE -> 0x1000L
    DS_CENTERMOUSE = 4096,
    
    /// DS_CONTEXTHELP -> 0x2000L
    DS_CONTEXTHELP = 8192,
    
    /// DS_SHELLFONT -> (DS_SETFONT | DS_FIXEDSYS)
    DS_SHELLFONT = (DS_SETFONT | DS_FIXEDSYS),

	}

	public enum RIDI
	{
		/// RIDI_PREPARSEDDATA -> 0x20000005
    RIDI_PREPARSEDDATA = 536870917,
    
    /// RIDI_DEVICENAME -> 0x20000007
    RIDI_DEVICENAME = 536870919,
    
    /// RIDI_DEVICEINFO -> 0x2000000b
    RIDI_DEVICEINFO = 536870923,
	}

	public enum LB
	{
		 /// LB_ADDSTRING -> 0x0180
    LB_ADDSTRING = 384,
    
    /// LB_INSERTSTRING -> 0x0181
    LB_INSERTSTRING = 385,
    
    /// LB_DELETESTRING -> 0x0182
    LB_DELETESTRING = 386,
    
    /// LB_SELITEMRANGEEX -> 0x0183
    LB_SELITEMRANGEEX = 387,
    
    /// LB_RESETCONTENT -> 0x0184
    LB_RESETCONTENT = 388,
    
    /// LB_SETSEL -> 0x0185
    LB_SETSEL = 389,
    
    /// LB_SETCURSEL -> 0x0186
    LB_SETCURSEL = 390,
    
    /// LB_GETSEL -> 0x0187
    LB_GETSEL = 391,
    
    /// LB_GETCURSEL -> 0x0188
    LB_GETCURSEL = 392,
    
    /// LB_GETTEXT -> 0x0189
    LB_GETTEXT = 393,
    
    /// LB_GETTEXTLEN -> 0x018A
    LB_GETTEXTLEN = 394,
    
    /// LB_GETCOUNT -> 0x018B
    LB_GETCOUNT = 395,
    
    /// LB_SELECTSTRING -> 0x018C
    LB_SELECTSTRING = 396,
    
    /// LB_DIR -> 0x018D
    LB_DIR = 397,
    
    /// LB_GETTOPINDEX -> 0x018E
    LB_GETTOPINDEX = 398,
    
    /// LB_FINDSTRING -> 0x018F
    LB_FINDSTRING = 399,
    
    /// LB_GETSELCOUNT -> 0x0190
    LB_GETSELCOUNT = 400,
    
    /// LB_GETSELITEMS -> 0x0191
    LB_GETSELITEMS = 401,
    
    /// LB_SETTABSTOPS -> 0x0192
    LB_SETTABSTOPS = 402,
    
    /// LB_GETHORIZONTALEXTENT -> 0x0193
    LB_GETHORIZONTALEXTENT = 403,
    
    /// LB_SETHORIZONTALEXTENT -> 0x0194
    LB_SETHORIZONTALEXTENT = 404,
    
    /// LB_SETCOLUMNWIDTH -> 0x0195
    LB_SETCOLUMNWIDTH = 405,
    
    /// LB_ADDFILE -> 0x0196
    LB_ADDFILE = 406,
    
    /// LB_SETTOPINDEX -> 0x0197
    LB_SETTOPINDEX = 407,
    
    /// LB_GETITEMRECT -> 0x0198
    LB_GETITEMRECT = 408,
    
    /// LB_GETITEMDATA -> 0x0199
    LB_GETITEMDATA = 409,
    
    /// LB_SETITEMDATA -> 0x019A
    LB_SETITEMDATA = 410,
    
    /// LB_SELITEMRANGE -> 0x019B
    LB_SELITEMRANGE = 411,
    
    /// LB_SETANCHORINDEX -> 0x019C
    LB_SETANCHORINDEX = 412,
    
    /// LB_GETANCHORINDEX -> 0x019D
    LB_GETANCHORINDEX = 413,
    
    /// LB_SETCARETINDEX -> 0x019E
    LB_SETCARETINDEX = 414,
    
    /// LB_GETCARETINDEX -> 0x019F
    LB_GETCARETINDEX = 415,
    
    /// LB_SETITEMHEIGHT -> 0x01A0
    LB_SETITEMHEIGHT = 416,
    
    /// LB_GETITEMHEIGHT -> 0x01A1
    LB_GETITEMHEIGHT = 417,
    
    /// LB_FINDSTRINGEXACT -> 0x01A2
    LB_FINDSTRINGEXACT = 418,
    
    /// LB_SETLOCALE -> 0x01A5
    LB_SETLOCALE = 421,
    
    /// LB_GETLOCALE -> 0x01A6
    LB_GETLOCALE = 422,
    
    /// LB_SETCOUNT -> 0x01A7
    LB_SETCOUNT = 423,
    
    /// LB_INITSTORAGE -> 0x01A8
    LB_INITSTORAGE = 424,
    
    /// LB_ITEMFROMPOINT -> 0x01A9
    LB_ITEMFROMPOINT = 425,
    
    /// LB_GETLISTBOXINFO -> 0x01B2
    LB_GETLISTBOXINFO = 434,
	}

	public enum SPI
	{
		/// SPI_GETBEEP -> 0x0001
    SPI_GETBEEP = 1,
    
    /// SPI_SETBEEP -> 0x0002
    SPI_SETBEEP = 2,
    
    /// SPI_GETMOUSE -> 0x0003
    SPI_GETMOUSE = 3,
    
    /// SPI_SETMOUSE -> 0x0004
    SPI_SETMOUSE = 4,
    
    /// SPI_GETBORDER -> 0x0005
    SPI_GETBORDER = 5,
    
    /// SPI_SETBORDER -> 0x0006
    SPI_SETBORDER = 6,
    
    /// SPI_GETKEYBOARDSPEED -> 0x000A
    SPI_GETKEYBOARDSPEED = 10,
    
    /// SPI_SETKEYBOARDSPEED -> 0x000B
    SPI_SETKEYBOARDSPEED = 11,
    
    /// SPI_LANGDRIVER -> 0x000C
    SPI_LANGDRIVER = 12,
    
    /// SPI_ICONHORIZONTALSPACING -> 0x000D
    SPI_ICONHORIZONTALSPACING = 13,
    
    /// SPI_GETSCREENSAVETIMEOUT -> 0x000E
    SPI_GETSCREENSAVETIMEOUT = 14,
    
    /// SPI_SETSCREENSAVETIMEOUT -> 0x000F
    SPI_SETSCREENSAVETIMEOUT = 15,
    
    /// SPI_GETSCREENSAVEACTIVE -> 0x0010
    SPI_GETSCREENSAVEACTIVE = 16,
    
    /// SPI_SETSCREENSAVEACTIVE -> 0x0011
    SPI_SETSCREENSAVEACTIVE = 17,
    
    /// SPI_GETGRIDGRANULARITY -> 0x0012
    SPI_GETGRIDGRANULARITY = 18,
    
    /// SPI_SETGRIDGRANULARITY -> 0x0013
    SPI_SETGRIDGRANULARITY = 19,
    
    /// SPI_SETDESKWALLPAPER -> 0x0014
    SPI_SETDESKWALLPAPER = 20,
    
    /// SPI_SETDESKPATTERN -> 0x0015
    SPI_SETDESKPATTERN = 21,
    
    /// SPI_GETKEYBOARDDELAY -> 0x0016
    SPI_GETKEYBOARDDELAY = 22,
    
    /// SPI_SETKEYBOARDDELAY -> 0x0017
    SPI_SETKEYBOARDDELAY = 23,
    
    /// SPI_ICONVERTICALSPACING -> 0x0018
    SPI_ICONVERTICALSPACING = 24,
    
    /// SPI_GETICONTITLEWRAP -> 0x0019
    SPI_GETICONTITLEWRAP = 25,
    
    /// SPI_SETICONTITLEWRAP -> 0x001A
    SPI_SETICONTITLEWRAP = 26,
    
    /// SPI_GETMENUDROPALIGNMENT -> 0x001B
    SPI_GETMENUDROPALIGNMENT = 27,
    
    /// SPI_SETMENUDROPALIGNMENT -> 0x001C
    SPI_SETMENUDROPALIGNMENT = 28,
    
    /// SPI_SETDOUBLECLKWIDTH -> 0x001D
    SPI_SETDOUBLECLKWIDTH = 29,
    
    /// SPI_SETDOUBLECLKHEIGHT -> 0x001E
    SPI_SETDOUBLECLKHEIGHT = 30,
    
    /// SPI_GETICONTITLELOGFONT -> 0x001F
    SPI_GETICONTITLELOGFONT = 31,
    
    /// SPI_SETDOUBLECLICKTIME -> 0x0020
    SPI_SETDOUBLECLICKTIME = 32,
    
    /// SPI_SETMOUSEBUTTONSWAP -> 0x0021
    SPI_SETMOUSEBUTTONSWAP = 33,
    
    /// SPI_SETICONTITLELOGFONT -> 0x0022
    SPI_SETICONTITLELOGFONT = 34,
    
    /// SPI_GETFASTTASKSWITCH -> 0x0023
    SPI_GETFASTTASKSWITCH = 35,
    
    /// SPI_SETFASTTASKSWITCH -> 0x0024
    SPI_SETFASTTASKSWITCH = 36,
    
    /// SPI_SETDRAGFULLWINDOWS -> 0x0025
    SPI_SETDRAGFULLWINDOWS = 37,
    
    /// SPI_GETDRAGFULLWINDOWS -> 0x0026
    SPI_GETDRAGFULLWINDOWS = 38,
    
    /// SPI_GETNONCLIENTMETRICS -> 0x0029
    SPI_GETNONCLIENTMETRICS = 41,
    
    /// SPI_SETNONCLIENTMETRICS -> 0x002A
    SPI_SETNONCLIENTMETRICS = 42,
    
    /// SPI_GETMINIMIZEDMETRICS -> 0x002B
    SPI_GETMINIMIZEDMETRICS = 43,
    
    /// SPI_SETMINIMIZEDMETRICS -> 0x002C
    SPI_SETMINIMIZEDMETRICS = 44,
    
    /// SPI_GETICONMETRICS -> 0x002D
    SPI_GETICONMETRICS = 45,
    
    /// SPI_SETICONMETRICS -> 0x002E
    SPI_SETICONMETRICS = 46,
    
    /// SPI_SETWORKAREA -> 0x002F
    SPI_SETWORKAREA = 47,
    
    /// SPI_GETWORKAREA -> 0x0030
    SPI_GETWORKAREA = 48,
    
    /// SPI_SETPENWINDOWS -> 0x0031
    SPI_SETPENWINDOWS = 49,
    
    /// SPI_GETHIGHCONTRAST -> 0x0042
    SPI_GETHIGHCONTRAST = 66,
    
    /// SPI_SETHIGHCONTRAST -> 0x0043
    SPI_SETHIGHCONTRAST = 67,
    
    /// SPI_GETKEYBOARDPREF -> 0x0044
    SPI_GETKEYBOARDPREF = 68,
    
    /// SPI_SETKEYBOARDPREF -> 0x0045
    SPI_SETKEYBOARDPREF = 69,
    
    /// SPI_GETSCREENREADER -> 0x0046
    SPI_GETSCREENREADER = 70,
    
    /// SPI_SETSCREENREADER -> 0x0047
    SPI_SETSCREENREADER = 71,
    
    /// SPI_GETANIMATION -> 0x0048
    SPI_GETANIMATION = 72,
    
    /// SPI_SETANIMATION -> 0x0049
    SPI_SETANIMATION = 73,
    
    /// SPI_GETFONTSMOOTHING -> 0x004A
    SPI_GETFONTSMOOTHING = 74,
    
    /// SPI_SETFONTSMOOTHING -> 0x004B
    SPI_SETFONTSMOOTHING = 75,
    
    /// SPI_SETDRAGWIDTH -> 0x004C
    SPI_SETDRAGWIDTH = 76,
    
    /// SPI_SETDRAGHEIGHT -> 0x004D
    SPI_SETDRAGHEIGHT = 77,
    
    /// SPI_SETHANDHELD -> 0x004E
    SPI_SETHANDHELD = 78,
    
    /// SPI_GETLOWPOWERTIMEOUT -> 0x004F
    SPI_GETLOWPOWERTIMEOUT = 79,
    
    /// SPI_GETPOWEROFFTIMEOUT -> 0x0050
    SPI_GETPOWEROFFTIMEOUT = 80,
    
    /// SPI_SETLOWPOWERTIMEOUT -> 0x0051
    SPI_SETLOWPOWERTIMEOUT = 81,
    
    /// SPI_SETPOWEROFFTIMEOUT -> 0x0052
    SPI_SETPOWEROFFTIMEOUT = 82,
    
    /// SPI_GETLOWPOWERACTIVE -> 0x0053
    SPI_GETLOWPOWERACTIVE = 83,
    
    /// SPI_GETPOWEROFFACTIVE -> 0x0054
    SPI_GETPOWEROFFACTIVE = 84,
    
    /// SPI_SETLOWPOWERACTIVE -> 0x0055
    SPI_SETLOWPOWERACTIVE = 85,
    
    /// SPI_SETPOWEROFFACTIVE -> 0x0056
    SPI_SETPOWEROFFACTIVE = 86,
    
    /// SPI_SETCURSORS -> 0x0057
    SPI_SETCURSORS = 87,
    
    /// SPI_SETICONS -> 0x0058
    SPI_SETICONS = 88,
    
    /// SPI_GETDEFAULTINPUTLANG -> 0x0059
    SPI_GETDEFAULTINPUTLANG = 89,
    
    /// SPI_SETDEFAULTINPUTLANG -> 0x005A
    SPI_SETDEFAULTINPUTLANG = 90,
    
    /// SPI_SETLANGTOGGLE -> 0x005B
    SPI_SETLANGTOGGLE = 91,
    
    /// SPI_GETWINDOWSEXTENSION -> 0x005C
    SPI_GETWINDOWSEXTENSION = 92,
    
    /// SPI_SETMOUSETRAILS -> 0x005D
    SPI_SETMOUSETRAILS = 93,
    
    /// SPI_GETMOUSETRAILS -> 0x005E
    SPI_GETMOUSETRAILS = 94,
    
    /// SPI_SETSCREENSAVERRUNNING -> 0x0061
    SPI_SETSCREENSAVERRUNNING = 97,
    
    /// SPI_SCREENSAVERRUNNING -> SPI_SETSCREENSAVERRUNNING
    SPI_SCREENSAVERRUNNING = SPI_SETSCREENSAVERRUNNING,
    
    /// SPI_GETFILTERKEYS -> 0x0032
    SPI_GETFILTERKEYS = 50,
    
    /// SPI_SETFILTERKEYS -> 0x0033
    SPI_SETFILTERKEYS = 51,
    
    /// SPI_GETTOGGLEKEYS -> 0x0034
    SPI_GETTOGGLEKEYS = 52,
    
    /// SPI_SETTOGGLEKEYS -> 0x0035
    SPI_SETTOGGLEKEYS = 53,
    
    /// SPI_GETMOUSEKEYS -> 0x0036
    SPI_GETMOUSEKEYS = 54,
    
    /// SPI_SETMOUSEKEYS -> 0x0037
    SPI_SETMOUSEKEYS = 55,
    
    /// SPI_GETSHOWSOUNDS -> 0x0038
    SPI_GETSHOWSOUNDS = 56,
    
    /// SPI_SETSHOWSOUNDS -> 0x0039
    SPI_SETSHOWSOUNDS = 57,
    
    /// SPI_GETSTICKYKEYS -> 0x003A
    SPI_GETSTICKYKEYS = 58,
    
    /// SPI_SETSTICKYKEYS -> 0x003B
    SPI_SETSTICKYKEYS = 59,
    
    /// SPI_GETACCESSTIMEOUT -> 0x003C
    SPI_GETACCESSTIMEOUT = 60,
    
    /// SPI_SETACCESSTIMEOUT -> 0x003D
    SPI_SETACCESSTIMEOUT = 61,
    
    /// SPI_GETSERIALKEYS -> 0x003E
    SPI_GETSERIALKEYS = 62,
    
    /// SPI_SETSERIALKEYS -> 0x003F
    SPI_SETSERIALKEYS = 63,
    
    /// SPI_GETSOUNDSENTRY -> 0x0040
    SPI_GETSOUNDSENTRY = 64,
    
    /// SPI_SETSOUNDSENTRY -> 0x0041
    SPI_SETSOUNDSENTRY = 65,
    
    /// SPI_GETSNAPTODEFBUTTON -> 0x005F
    SPI_GETSNAPTODEFBUTTON = 95,
    
    /// SPI_SETSNAPTODEFBUTTON -> 0x0060
    SPI_SETSNAPTODEFBUTTON = 96,
    
    /// SPI_GETMOUSEHOVERWIDTH -> 0x0062
    SPI_GETMOUSEHOVERWIDTH = 98,
    
    /// SPI_SETMOUSEHOVERWIDTH -> 0x0063
    SPI_SETMOUSEHOVERWIDTH = 99,
    
    /// SPI_GETMOUSEHOVERHEIGHT -> 0x0064
    SPI_GETMOUSEHOVERHEIGHT = 100,
    
    /// SPI_SETMOUSEHOVERHEIGHT -> 0x0065
    SPI_SETMOUSEHOVERHEIGHT = 101,
    
    /// SPI_GETMOUSEHOVERTIME -> 0x0066
    SPI_GETMOUSEHOVERTIME = 102,
    
    /// SPI_SETMOUSEHOVERTIME -> 0x0067
    SPI_SETMOUSEHOVERTIME = 103,
    
    /// SPI_GETWHEELSCROLLLINES -> 0x0068
    SPI_GETWHEELSCROLLLINES = 104,
    
    /// SPI_SETWHEELSCROLLLINES -> 0x0069
    SPI_SETWHEELSCROLLLINES = 105,
    
    /// SPI_GETMENUSHOWDELAY -> 0x006A
    SPI_GETMENUSHOWDELAY = 106,
    
    /// SPI_SETMENUSHOWDELAY -> 0x006B
    SPI_SETMENUSHOWDELAY = 107,
    
    /// SPI_GETSHOWIMEUI -> 0x006E
    SPI_GETSHOWIMEUI = 110,
    
    /// SPI_SETSHOWIMEUI -> 0x006F
    SPI_SETSHOWIMEUI = 111,
    
    /// SPI_GETMOUSESPEED -> 0x0070
    SPI_GETMOUSESPEED = 112,
    
    /// SPI_SETMOUSESPEED -> 0x0071
    SPI_SETMOUSESPEED = 113,
    
    /// SPI_GETSCREENSAVERRUNNING -> 0x0072
    SPI_GETSCREENSAVERRUNNING = 114,
    
    /// SPI_GETDESKWALLPAPER -> 0x0073
    SPI_GETDESKWALLPAPER = 115,
    
    /// SPI_GETACTIVEWINDOWTRACKING -> 0x1000
    SPI_GETACTIVEWINDOWTRACKING = 4096,
    
    /// SPI_SETACTIVEWINDOWTRACKING -> 0x1001
    SPI_SETACTIVEWINDOWTRACKING = 4097,
    
    /// SPI_GETMENUANIMATION -> 0x1002
    SPI_GETMENUANIMATION = 4098,
    
    /// SPI_SETMENUANIMATION -> 0x1003
    SPI_SETMENUANIMATION = 4099,
    
    /// SPI_GETCOMBOBOXANIMATION -> 0x1004
    SPI_GETCOMBOBOXANIMATION = 4100,
    
    /// SPI_SETCOMBOBOXANIMATION -> 0x1005
    SPI_SETCOMBOBOXANIMATION = 4101,
    
    /// SPI_GETLISTBOXSMOOTHSCROLLING -> 0x1006
    SPI_GETLISTBOXSMOOTHSCROLLING = 4102,
    
    /// SPI_SETLISTBOXSMOOTHSCROLLING -> 0x1007
    SPI_SETLISTBOXSMOOTHSCROLLING = 4103,
    
    /// SPI_GETGRADIENTCAPTIONS -> 0x1008
    SPI_GETGRADIENTCAPTIONS = 4104,
    
    /// SPI_SETGRADIENTCAPTIONS -> 0x1009
    SPI_SETGRADIENTCAPTIONS = 4105,
    
    /// SPI_GETKEYBOARDCUES -> 0x100A
    SPI_GETKEYBOARDCUES = 4106,
    
    /// SPI_SETKEYBOARDCUES -> 0x100B
    SPI_SETKEYBOARDCUES = 4107,
    
    /// SPI_GETMENUUNDERLINES -> SPI_GETKEYBOARDCUES
    SPI_GETMENUUNDERLINES = SPI_GETKEYBOARDCUES,
    
    /// SPI_SETMENUUNDERLINES -> SPI_SETKEYBOARDCUES
    SPI_SETMENUUNDERLINES = SPI_SETKEYBOARDCUES,
    
    /// SPI_GETACTIVEWNDTRKZORDER -> 0x100C
    SPI_GETACTIVEWNDTRKZORDER = 4108,
    
    /// SPI_SETACTIVEWNDTRKZORDER -> 0x100D
    SPI_SETACTIVEWNDTRKZORDER = 4109,
    
    /// SPI_GETHOTTRACKING -> 0x100E
    SPI_GETHOTTRACKING = 4110,
    
    /// SPI_SETHOTTRACKING -> 0x100F
    SPI_SETHOTTRACKING = 4111,
    
    /// SPI_GETMENUFADE -> 0x1012
    SPI_GETMENUFADE = 4114,
    
    /// SPI_SETMENUFADE -> 0x1013
    SPI_SETMENUFADE = 4115,
    
    /// SPI_GETSELECTIONFADE -> 0x1014
    SPI_GETSELECTIONFADE = 4116,
    
    /// SPI_SETSELECTIONFADE -> 0x1015
    SPI_SETSELECTIONFADE = 4117,
    
    /// SPI_GETTOOLTIPANIMATION -> 0x1016
    SPI_GETTOOLTIPANIMATION = 4118,
    
    /// SPI_SETTOOLTIPANIMATION -> 0x1017
    SPI_SETTOOLTIPANIMATION = 4119,
    
    /// SPI_GETTOOLTIPFADE -> 0x1018
    SPI_GETTOOLTIPFADE = 4120,
    
    /// SPI_SETTOOLTIPFADE -> 0x1019
    SPI_SETTOOLTIPFADE = 4121,
    
    /// SPI_GETCURSORSHADOW -> 0x101A
    SPI_GETCURSORSHADOW = 4122,
    
    /// SPI_SETCURSORSHADOW -> 0x101B
    SPI_SETCURSORSHADOW = 4123,
    
    /// SPI_GETMOUSESONAR -> 0x101C
    SPI_GETMOUSESONAR = 4124,
    
    /// SPI_SETMOUSESONAR -> 0x101D
    SPI_SETMOUSESONAR = 4125,
    
    /// SPI_GETMOUSECLICKLOCK -> 0x101E
    SPI_GETMOUSECLICKLOCK = 4126,
    
    /// SPI_SETMOUSECLICKLOCK -> 0x101F
    SPI_SETMOUSECLICKLOCK = 4127,
    
    /// SPI_GETMOUSEVANISH -> 0x1020
    SPI_GETMOUSEVANISH = 4128,
    
    /// SPI_SETMOUSEVANISH -> 0x1021
    SPI_SETMOUSEVANISH = 4129,
    
    /// SPI_GETFLATMENU -> 0x1022
    SPI_GETFLATMENU = 4130,
    
    /// SPI_SETFLATMENU -> 0x1023
    SPI_SETFLATMENU = 4131,
    
    /// SPI_GETDROPSHADOW -> 0x1024
    SPI_GETDROPSHADOW = 4132,
    
    /// SPI_SETDROPSHADOW -> 0x1025
    SPI_SETDROPSHADOW = 4133,
    
    /// SPI_GETBLOCKSENDINPUTRESETS -> 0x1026
    SPI_GETBLOCKSENDINPUTRESETS = 4134,
    
    /// SPI_SETBLOCKSENDINPUTRESETS -> 0x1027
    SPI_SETBLOCKSENDINPUTRESETS = 4135,
    
    /// SPI_GETUIEFFECTS -> 0x103E
    SPI_GETUIEFFECTS = 4158,
    
    /// SPI_SETUIEFFECTS -> 0x103F
    SPI_SETUIEFFECTS = 4159,
    
    /// SPI_GETFOREGROUNDLOCKTIMEOUT -> 0x2000
    SPI_GETFOREGROUNDLOCKTIMEOUT = 8192,
    
    /// SPI_SETFOREGROUNDLOCKTIMEOUT -> 0x2001
    SPI_SETFOREGROUNDLOCKTIMEOUT = 8193,
    
    /// SPI_GETACTIVEWNDTRKTIMEOUT -> 0x2002
    SPI_GETACTIVEWNDTRKTIMEOUT = 8194,
    
    /// SPI_SETACTIVEWNDTRKTIMEOUT -> 0x2003
    SPI_SETACTIVEWNDTRKTIMEOUT = 8195,
    
    /// SPI_GETFOREGROUNDFLASHCOUNT -> 0x2004
    SPI_GETFOREGROUNDFLASHCOUNT = 8196,
    
    /// SPI_SETFOREGROUNDFLASHCOUNT -> 0x2005
    SPI_SETFOREGROUNDFLASHCOUNT = 8197,
    
    /// SPI_GETCARETWIDTH -> 0x2006
    SPI_GETCARETWIDTH = 8198,
    
    /// SPI_SETCARETWIDTH -> 0x2007
    SPI_SETCARETWIDTH = 8199,
    
    /// SPI_GETMOUSECLICKLOCKTIME -> 0x2008
    SPI_GETMOUSECLICKLOCKTIME = 8200,
    
    /// SPI_SETMOUSECLICKLOCKTIME -> 0x2009
    SPI_SETMOUSECLICKLOCKTIME = 8201,
    
    /// SPI_GETFONTSMOOTHINGTYPE -> 0x200A
    SPI_GETFONTSMOOTHINGTYPE = 8202,
    
    /// SPI_SETFONTSMOOTHINGTYPE -> 0x200B
    SPI_SETFONTSMOOTHINGTYPE = 8203,
    
    /// SPI_GETFONTSMOOTHINGCONTRAST -> 0x200C
    SPI_GETFONTSMOOTHINGCONTRAST = 8204,
    
    /// SPI_SETFONTSMOOTHINGCONTRAST -> 0x200D
    SPI_SETFONTSMOOTHINGCONTRAST = 8205,
    
    /// SPI_GETFOCUSBORDERWIDTH -> 0x200E
    SPI_GETFOCUSBORDERWIDTH = 8206,
    
    /// SPI_SETFOCUSBORDERWIDTH -> 0x200F
    SPI_SETFOCUSBORDERWIDTH = 8207,
    
    /// SPI_GETFOCUSBORDERHEIGHT -> 0x2010
    SPI_GETFOCUSBORDERHEIGHT = 8208,
    
    /// SPI_SETFOCUSBORDERHEIGHT -> 0x2011
    SPI_SETFOCUSBORDERHEIGHT = 8209,
    
    /// SPI_GETFONTSMOOTHINGORIENTATION -> 0x2012
    SPI_GETFONTSMOOTHINGORIENTATION = 8210,
    
    /// SPI_SETFONTSMOOTHINGORIENTATION -> 0x2013
    SPI_SETFONTSMOOTHINGORIENTATION = 8211,
    
    /// SPI_GETWHEELSCROLLCHARS -> 0x006C
    SPI_GETWHEELSCROLLCHARS = 108,
    
    /// SPI_SETWHEELSCROLLCHARS -> 0x006D
    SPI_SETWHEELSCROLLCHARS = 109,
    
    /// SPI_GETAUDIODESCRIPTION -> 0x0074
    SPI_GETAUDIODESCRIPTION = 116,
    
    /// SPI_SETAUDIODESCRIPTION -> 0x0075
    SPI_SETAUDIODESCRIPTION = 117,
    
    /// SPI_GETSCREENSAVESECURE -> 0x0076
    SPI_GETSCREENSAVESECURE = 118,
    
    /// SPI_SETSCREENSAVESECURE -> 0x0077
    SPI_SETSCREENSAVESECURE = 119,
    
    /// SPI_GETHUNGAPPTIMEOUT -> 0x0078
    SPI_GETHUNGAPPTIMEOUT = 120,
    
    /// SPI_SETHUNGAPPTIMEOUT -> 0x0079
    SPI_SETHUNGAPPTIMEOUT = 121,
    
    /// SPI_GETWAITTOKILLTIMEOUT -> 0x007A
    SPI_GETWAITTOKILLTIMEOUT = 122,
    
    /// SPI_SETWAITTOKILLTIMEOUT -> 0x007B
    SPI_SETWAITTOKILLTIMEOUT = 123,
    
    /// SPI_GETWAITTOKILLSERVICETIMEOUT -> 0x007C
    SPI_GETWAITTOKILLSERVICETIMEOUT = 124,
    
    /// SPI_SETWAITTOKILLSERVICETIMEOUT -> 0x007D
    SPI_SETWAITTOKILLSERVICETIMEOUT = 125,
    
    /// SPI_GETMOUSEDOCKTHRESHOLD -> 0x007E
    SPI_GETMOUSEDOCKTHRESHOLD = 126,
    
    /// SPI_SETMOUSEDOCKTHRESHOLD -> 0x007F
    SPI_SETMOUSEDOCKTHRESHOLD = 127,
    
    /// SPI_GETPENDOCKTHRESHOLD -> 0x0080
    SPI_GETPENDOCKTHRESHOLD = 128,
    
    /// SPI_SETPENDOCKTHRESHOLD -> 0x0081
    SPI_SETPENDOCKTHRESHOLD = 129,
    
    /// SPI_GETWINARRANGING -> 0x0082
    SPI_GETWINARRANGING = 130,
    
    /// SPI_SETWINARRANGING -> 0x0083
    SPI_SETWINARRANGING = 131,
    
    /// SPI_GETMOUSEDRAGOUTTHRESHOLD -> 0x0084
    SPI_GETMOUSEDRAGOUTTHRESHOLD = 132,
    
    /// SPI_SETMOUSEDRAGOUTTHRESHOLD -> 0x0085
    SPI_SETMOUSEDRAGOUTTHRESHOLD = 133,
    
    /// SPI_GETPENDRAGOUTTHRESHOLD -> 0x0086
    SPI_GETPENDRAGOUTTHRESHOLD = 134,
    
    /// SPI_SETPENDRAGOUTTHRESHOLD -> 0x0087
    SPI_SETPENDRAGOUTTHRESHOLD = 135,
    
    /// SPI_GETMOUSESIDEMOVETHRESHOLD -> 0x0088
    SPI_GETMOUSESIDEMOVETHRESHOLD = 136,
    
    /// SPI_SETMOUSESIDEMOVETHRESHOLD -> 0x0089
    SPI_SETMOUSESIDEMOVETHRESHOLD = 137,
    
    /// SPI_GETPENSIDEMOVETHRESHOLD -> 0x008A
    SPI_GETPENSIDEMOVETHRESHOLD = 138,
    
    /// SPI_SETPENSIDEMOVETHRESHOLD -> 0x008B
    SPI_SETPENSIDEMOVETHRESHOLD = 139,
    
    /// SPI_GETDRAGFROMMAXIMIZE -> 0x008C
    SPI_GETDRAGFROMMAXIMIZE = 140,
    
    /// SPI_SETDRAGFROMMAXIMIZE -> 0x008D
    SPI_SETDRAGFROMMAXIMIZE = 141,
    
    /// SPI_GETSNAPSIZING -> 0x008E
    SPI_GETSNAPSIZING = 142,
    
    /// SPI_SETSNAPSIZING -> 0x008F
    SPI_SETSNAPSIZING = 143,
    
    /// SPI_GETDOCKMOVING -> 0x0090
    SPI_GETDOCKMOVING = 144,
    
    /// SPI_SETDOCKMOVING -> 0x0091
    SPI_SETDOCKMOVING = 145,
    
    /// SPI_GETDISABLEOVERLAPPEDCONTENT -> 0x1040
    SPI_GETDISABLEOVERLAPPEDCONTENT = 4160,
    
    /// SPI_SETDISABLEOVERLAPPEDCONTENT -> 0x1041
    SPI_SETDISABLEOVERLAPPEDCONTENT = 4161,
    
    /// SPI_GETCLIENTAREAANIMATION -> 0x1042
    SPI_GETCLIENTAREAANIMATION = 4162,
    
    /// SPI_SETCLIENTAREAANIMATION -> 0x1043
    SPI_SETCLIENTAREAANIMATION = 4163,
    
    /// SPI_GETCLEARTYPE -> 0x1048
    SPI_GETCLEARTYPE = 4168,
    
    /// SPI_SETCLEARTYPE -> 0x1049
    SPI_SETCLEARTYPE = 4169,
    
    /// SPI_GETSPEECHRECOGNITION -> 0x104A
    SPI_GETSPEECHRECOGNITION = 4170,
    
    /// SPI_SETSPEECHRECOGNITION -> 0x104B
    SPI_SETSPEECHRECOGNITION = 4171,
    
    /// SPI_GETMINIMUMHITRADIUS -> 0x2014
    SPI_GETMINIMUMHITRADIUS = 8212,
    
    /// SPI_SETMINIMUMHITRADIUS -> 0x2015
    SPI_SETMINIMUMHITRADIUS = 8213,
    
    /// SPI_GETMESSAGEDURATION -> 0x2016
    SPI_GETMESSAGEDURATION = 8214,
    
    /// SPI_SETMESSAGEDURATION -> 0x2017
    SPI_SETMESSAGEDURATION = 8215,

	}

	public enum FE
	{
		/// FE_FONTSMOOTHINGORIENTATIONBGR -> 0x0000
		FE_FONTSMOOTHINGORIENTATIONBGR = 0,

		/// FE_FONTSMOOTHINGORIENTATIONRGB -> 0x0001
		FE_FONTSMOOTHINGORIENTATIONRGB = 1,

		/// FE_FONTSMOOTHINGSTANDARD -> 0x0001
		FE_FONTSMOOTHINGSTANDARD = 1,

		/// FE_FONTSMOOTHINGCLEARTYPE -> 0x0002
		FE_FONTSMOOTHINGCLEARTYPE = 2
	}

	public enum COLOR
	{
		/// COLOR_SCROLLBAR -> 0
    COLOR_SCROLLBAR = 0,
    
    /// COLOR_BACKGROUND -> 1
    COLOR_BACKGROUND = 1,
    
    /// COLOR_ACTIVECAPTION -> 2
    COLOR_ACTIVECAPTION = 2,
    
    /// COLOR_INACTIVECAPTION -> 3
    COLOR_INACTIVECAPTION = 3,
    
    /// COLOR_MENU -> 4
    COLOR_MENU = 4,
    
    /// COLOR_WINDOW -> 5
    COLOR_WINDOW = 5,
    
    /// COLOR_WINDOWFRAME -> 6
    COLOR_WINDOWFRAME = 6,
    
    /// COLOR_MENUTEXT -> 7
    COLOR_MENUTEXT = 7,
    
    /// COLOR_WINDOWTEXT -> 8
    COLOR_WINDOWTEXT = 8,
    
    /// COLOR_CAPTIONTEXT -> 9
    COLOR_CAPTIONTEXT = 9,
    
    /// COLOR_ACTIVEBORDER -> 10
    COLOR_ACTIVEBORDER = 10,
    
    /// COLOR_INACTIVEBORDER -> 11
    COLOR_INACTIVEBORDER = 11,
    
    /// COLOR_APPWORKSPACE -> 12
    COLOR_APPWORKSPACE = 12,
    
    /// COLOR_HIGHLIGHT -> 13
    COLOR_HIGHLIGHT = 13,
    
    /// COLOR_HIGHLIGHTTEXT -> 14
    COLOR_HIGHLIGHTTEXT = 14,
    
    /// COLOR_BTNFACE -> 15
    COLOR_BTNFACE = 15,
    
    /// COLOR_BTNSHADOW -> 16
    COLOR_BTNSHADOW = 16,
    
    /// COLOR_GRAYTEXT -> 17
    COLOR_GRAYTEXT = 17,
    
    /// COLOR_BTNTEXT -> 18
    COLOR_BTNTEXT = 18,
    
    /// COLOR_INACTIVECAPTIONTEXT -> 19
    COLOR_INACTIVECAPTIONTEXT = 19,
    
    /// COLOR_BTNHIGHLIGHT -> 20
    COLOR_BTNHIGHLIGHT = 20,
    
    /// COLOR_3DDKSHADOW -> 21
    COLOR_3DDKSHADOW = 21,
    
    /// COLOR_3DLIGHT -> 22
    COLOR_3DLIGHT = 22,
    
    /// COLOR_INFOTEXT -> 23
    COLOR_INFOTEXT = 23,
    
    /// COLOR_INFOBK -> 24
    COLOR_INFOBK = 24,
    
    /// COLOR_HOTLIGHT -> 26
    COLOR_HOTLIGHT = 26,
    
    /// COLOR_GRADIENTACTIVECAPTION -> 27
    COLOR_GRADIENTACTIVECAPTION = 27,
    
    /// COLOR_GRADIENTINACTIVECAPTION -> 28
    COLOR_GRADIENTINACTIVECAPTION = 28,
    
    /// COLOR_MENUHILIGHT -> 29
    COLOR_MENUHILIGHT = 29,
    
    /// COLOR_MENUBAR -> 30
    COLOR_MENUBAR = 30,
    
    /// COLOR_DESKTOP -> COLOR_BACKGROUND
    COLOR_DESKTOP = COLOR_BACKGROUND,
    
    /// COLOR_3DFACE -> COLOR_BTNFACE
	COLOR_3DFACE = COLOR_BTNFACE,
    
    /// COLOR_3DSHADOW -> COLOR_BTNSHADOW
	COLOR_3DSHADOW = COLOR_BTNSHADOW,
    
    /// COLOR_3DHIGHLIGHT -> COLOR_BTNHIGHLIGHT
	COLOR_3DHIGHLIGHT = COLOR_BTNHIGHLIGHT,
    
    /// COLOR_3DHILIGHT -> COLOR_BTNHIGHLIGHT
	COLOR_3DHILIGHT = COLOR_BTNHIGHLIGHT,
    
    /// COLOR_BTNHILIGHT -> COLOR_BTNHIGHLIGHT
	COLOR_BTNHILIGHT = COLOR_BTNHIGHLIGHT,
	}

	public enum HKL
	{
		HKL_PREF = 0,
		HKL_NEXT = 1
	}

	/// <summary>
	///     The weight of the font in the range 0 through 1000. For example, 400 is normal and 700 is bold. If this value is zero, a default weight is
	///     used.
	/// </summary>
	public enum FW
	{
		/// <summary>Don't care about the font weight.</summary>
		FW_DONTCARE = 0,

		/// <summary>Specifies a thin font weight.</summary>
		FW_THIN = 100,

		/// <summary>Specifies an extra light font weight.</summary>
		FW_EXTRALIGHT = 200,

		/// <summary>Specifies a light font weight.</summary>
		FW_LIGHT = 300,

		/// <summary>Specifies a normal font weight.</summary>
		FW_NORMAL = 400,

		/// <summary>Specifies a medium font weight.</summary>
		FW_MEDIUM = 500,

		/// <summary>Specifies a semi-bold font weight.</summary>
		FW_SEMIBOLD = 600,

		/// <summary>Specifies a bold font weight.</summary>
		FW_BOLD = 700,

		/// <summary>Specifies an extra-bold font weight.</summary>
		FW_EXTRABOLD = 800,

		/// <summary>Specifies a heavy font weight.</summary>
		FW_HEAVY = 900,
	}

	/// <summary>
	///     The <see cref="CHARSET" /> Enumeration defines the possible sets of character glyphs that are defined in fonts for graphics output.
	/// </summary>
	public enum CHARSET : byte
	{
		/// <summary>Specifies the English character set.</summary>
		ANSI_CHARSET = 0,

		/// <summary>
		///     Specifies a character set based on the current system locale; for example, when the system locale is United States English, the default character
		///     set is <see cref="ANSI_CHARSET" />.
		/// </summary>
		DEFAULT_CHARSET = 1,

		/// <summary>Specifies a character set of symbols.</summary>
		SYMBOL_CHARSET = 2,

		/// <summary>Specifies the Japanese character set.</summary>
		SHIFTJIS_CHARSET = 128,

		/// <summary>Specifies the Hangul Korean character set.</summary>
		HANGEUL_CHARSET = 129,

		/// <summary>Also spelled "Hangeul". Specifies the Hangul Korean character set.</summary>
		HANGUL_CHARSET = 129,

		/// <summary>Specifies the "simplified" Chinese character set for People's Republic of China.</summary>
		GB2312_CHARSET = 134,

		/// <summary>Specifies the "traditional" Chinese character set, used mostly in Taiwan and in the Hong Kong and Macao Special Administrative Regions.</summary>
		CHINESEBIG5_CHARSET = 136,

		/// <summary>Specifies a mapping to one of the OEM code pages, according to the current system locale setting.</summary>
		OEM_CHARSET = 255,

		/// <summary>Also spelled "Johap". Specifies the Johab Korean character set.</summary>
		JOHAB_CHARSET = 130,

		/// <summary>Specifies the Hebrew character set.</summary>
		HEBREW_CHARSET = 177,

		/// <summary>Specifies the Arabic character set.</summary>
		ARABIC_CHARSET = 178,

		/// <summary>Specifies the Greek character set.</summary>
		GREEK_CHARSET = 161,

		/// <summary>Specifies the Turkish character set.</summary>
		TURKISH_CHARSET = 162,

		/// <summary>Specifies the Vietnamese character set.</summary>
		VIETNAMESE_CHARSET = 163,

		/// <summary>Specifies the Thai character set.</summary>
		THAI_CHARSET = 222,

		/// <summary>Specifies a Eastern European character set.</summary>
		EASTEUROPE_CHARSET = 238,

		/// <summary>Specifies the Russian Cyrillic character set.</summary>
		RUSSIAN_CHARSET = 204,

		/// <summary>Specifies the Apple Macintosh character set.</summary>
		MAC_CHARSET = 77,

		/// <summary>Specifies the Baltic (Northeastern European) character set</summary>
		BALTIC_CHARSET = 186,
	}

	/// <summary>
	///     The output precision. The output precision defines how closely the output must match the requested font's height, width, character orientation,
	///     escapement, pitch, and font type.
	/// </summary>
	public enum PRECIS : byte
	{
		/// <summary>The default font mapper behavior.</summary>
		OUT_DEFAULT_PRECIS = 0,

		/// <summary>This value is not used by the font mapper, but it is returned when raster fonts are enumerated.</summary>
		OUT_STRING_PRECIS = 1,

		/// <summary>Not used.</summary>
		OUT_CHARACTER_PRECIS = 2,

		/// <summary>This value is not used by the font mapper, but it is returned when TrueType, other outline-based fonts, and vector fonts are enumerated.</summary>
		OUT_STROKE_PRECIS = 3,

		/// <summary>Instructs the font mapper to choose a TrueType font when the system contains multiple fonts with the same name.</summary>
		OUT_TT_PRECIS = 4,

		/// <summary>Instructs the font mapper to choose a Device font when the system contains multiple fonts with the same name.</summary>
		OUT_DEVICE_PRECIS = 5,

		/// <summary>Instructs the font mapper to choose a raster font when the system contains multiple fonts with the same name.</summary>
		OUT_RASTER_PRECIS = 6,

		/// <summary>
		///     Instructs the font mapper to choose from only TrueType fonts. If there are no TrueType fonts installed in the system, the font mapper returns to
		///     default behavior.
		/// </summary>
		OUT_TT_ONLY_PRECIS = 7,

		/// <summary>This value instructs the font mapper to choose from TrueType and other outline-based fonts.</summary>
		OUT_OUTLINE_PRECIS = 8,

		/// <summary>A value that specifies a preference for TrueType and other outline fonts.</summary>
		OUT_SCREEN_OUTLINE_PRECIS = 9,

		/// <summary>
		///     Instructs the font mapper to choose from only PostScript fonts. If there are no PostScript fonts installed in the system, the font mapper returns
		///     to default behavior.
		/// </summary>
		OUT_PS_ONLY_PRECIS = 10,
	}

	/// <summary>The clipping precision. The clipping precision defines how to clip characters that are partially outside the clipping region.</summary>
	public enum CLIP : byte
	{
		/// <summary>Not used.</summary>
		CLIP_DEFAULT_PRECIS = 0,

		/// <summary>Specifies default clipping behavior.</summary>
		CLIP_CHARACTER_PRECIS = 1,

		/// <summary>
		///     <para>Not used by the font mapper, but is returned when raster, vector, or TrueType fonts are enumerated.</para>
		///     <para>For compatibility, this value is always returned when enumerating fonts.</para>
		/// </summary>
		CLIP_STROKE_PRECIS = 2,

		/// <summary>Not used.</summary>
		CLIP_MASK = 0xf,

		/// <summary>
		///     <para>
		///         When this value is used, the rotation for all fonts depends on whether the orientation of the coordinate system is left-handed or
		///         right-handed.
		///     </para>
		///     <para>
		///         If not used, device fonts always rotate counterclockwise, but the rotation of other fonts is dependent on the orientation of the coordinate
		///         system.
		///     </para>
		///     <para>For more information about the orientation of coordinate systems, see the description of the nOrientation parameter.</para>
		/// </summary>
		CLIP_LH_ANGLES = (1 << 4),

		/// <summary>Not used.</summary>
		CLIP_TT_ALWAYS = (2 << 4),

		/// <summary>
		///     Windows XP SP1: Turns off font association for the font. Note that this flag is not guaranteed to have any effect on any platform after Windows
		///     Server 2003.
		/// </summary>
		CLIP_DFA_DISABLE = (4 << 4),

		/// <summary>You must specify this flag to use an embedded read-only font.</summary>
		CLIP_EMBEDDED = (8 << 4),
	}

	/// <summary>
	///     The <see cref="QUALITY" /> Enumeration specifies how closely the attributes of the logical font should match those of the physical font when
	///     rendering text.
	/// </summary>
	public enum QUALITY : byte
	{
		/// <summary>
		///     Specifies that the character quality of the font does not matter, so <see cref="DRAFT_QUALITY" /> can be used.
		/// </summary>
		DEFAULT_QUALITY = 0,

		/// <summary>
		///     Specifies that the character quality of the font is less important than the matching of logical attributes. For rasterized fonts, scaling SHOULD
		///     be enabled, which means that more font sizes are available.
		/// </summary>
		DRAFT_QUALITY = 1,

		/// <summary>
		///     Specifies that the character quality of the font is more important than the matching of logical attributes. For rasterized fonts, scaling SHOULD
		///     be disabled, and the font closest in size SHOULD be chosen.
		/// </summary>
		PROOF_QUALITY = 2,

		/// <summary>Specifies that anti-aliasing SHOULD NOT be used when rendering text.</summary>
		NONANTIALIASED_QUALITY = 3,

		/// <summary>Specifies that anti-aliasing SHOULD be used when rendering text, if the font supports it.</summary>
		ANTIALIASED_QUALITY = 4,

		/// <summary>Specifies that ClearType anti-aliasing SHOULD be used when rendering text, if the font supports it.</summary>
		CLEARTYPE_QUALITY = 5,

		/// <summary>Specifies that high-quality ClearType anti-aliasing SHOULD be used when rendering text, if the font supports it.</summary>
		CLEARTYPE_NATURAL_QUALITY = 6,
	}

	/// <summary>
	///     The PitchFont enumeration defines values that are used for specifying characteristics of a font. The values are used to indicate whether the
	///     characters in a font have a fixed or variable width, or pitch.
	/// </summary>
	[Flags]
	public enum PITCH_FAMILY : byte
	{
		/// <summary>The default pitch, which is implementation-dependent.</summary>
		DEFAULT_PITCH = 0,

		/// <summary>A fixed pitch, which means that all the characters in the font occupy the same width when output in a string.</summary>
		FIXED_PITCH = 1,

		/// <summary>
		///     A variable pitch, which means that the characters in the font occupy widths that are proportional to the actual widths of the glyphs when output
		///     in a string. For example, the "i" and space characters usually have much smaller widths than a "W" or "O" character.
		/// </summary>
		VARIABLE_PITCH = 2,

		/// <summary>Specifies that we don't care about the font family.</summary>
		FF_DONTCARE = (0 << 4),

		/// <summary>Specifies a Roman font family.</summary>
		FF_ROMAN = (1 << 4),

		/// <summary>Specifies a Swiss font family.</summary>
		FF_SWISS = (2 << 4),

		/// <summary>Specifies a Modern font family.</summary>
		FF_MODERN = (3 << 4),

		/// <summary>Specifies a Script font family.</summary>
		FF_SCRIPT = (4 << 4),

		/// <summary>Species a Decorative font family.</summary>
		FF_DECORATIVE = (5 << 4),
	}

	public enum EC
	{
    
    /// EC_ENABLEALL -> 0
    EC_ENABLEALL = 0,
    
    /// EC_ENABLEONE -> ST_BLOCKNEXT
    EC_ENABLEONE = ST.ST_BLOCKNEXT,
    
    /// EC_DISABLE -> ST_BLOCKED
    EC_DISABLE = ST.ST_BLOCKED,
    
    /// EC_QUERYWAITING -> 2
    EC_QUERYWAITING = 2,
	}

	public enum GMEM
	{
		/// GMEM_FIXED -> 0x0000
    GMEM_FIXED = 0,
    
    /// GMEM_MOVEABLE -> 0x0002
    GMEM_MOVEABLE = 2,
    
    /// GMEM_NOCOMPACT -> 0x0010
    GMEM_NOCOMPACT = 16,
    
    /// GMEM_NODISCARD -> 0x0020
    GMEM_NODISCARD = 32,
    
    /// GMEM_ZEROINIT -> 0x0040
    GMEM_ZEROINIT = 64,
    
    /// GMEM_MODIFY -> 0x0080
    GMEM_MODIFY = 128,
    
    /// GMEM_DISCARDABLE -> 0x0100
    GMEM_DISCARDABLE = 256,
    
    /// GMEM_NOT_BANKED -> 0x1000
    GMEM_NOT_BANKED = 4096,
    
    /// GMEM_SHARE -> 0x2000
    GMEM_SHARE = 8192,
    
    /// GMEM_DDESHARE -> 0x2000
    GMEM_DDESHARE = 8192,
    
    /// GMEM_NOTIFY -> 0x4000
    GMEM_NOTIFY = 16384,
    
    /// GMEM_LOWER -> GMEM_NOT_BANKED
    GMEM_LOWER = GMEM_NOT_BANKED,
    
    /// GMEM_VALID_FLAGS -> 0x7F72
    GMEM_VALID_FLAGS = 32626,
    
    /// GMEM_INVALID_HANDLE -> 0x8000
    GMEM_INVALID_HANDLE = 32768,

	}

	public enum CF
	{
		/// CF_TEXT -> 1
    CF_TEXT = 1,
    
    /// CF_BITMAP -> 2
    CF_BITMAP = 2,
    
    /// CF_METAFILEPICT -> 3
    CF_METAFILEPICT = 3,
    
    /// CF_SYLK -> 4
    CF_SYLK = 4,
    
    /// CF_DIF -> 5
    CF_DIF = 5,
    
    /// CF_TIFF -> 6
    CF_TIFF = 6,
    
    /// CF_OEMTEXT -> 7
    CF_OEMTEXT = 7,
    
    /// CF_DIB -> 8
    CF_DIB = 8,
    
    /// CF_PALETTE -> 9
    CF_PALETTE = 9,
    
    /// CF_PENDATA -> 10
    CF_PENDATA = 10,
    
    /// CF_RIFF -> 11
    CF_RIFF = 11,
    
    /// CF_WAVE -> 12
    CF_WAVE = 12,
    
    /// CF_UNICODETEXT -> 13
    CF_UNICODETEXT = 13,
    
    /// CF_ENHMETAFILE -> 14
    CF_ENHMETAFILE = 14,
    
    /// CF_HDROP -> 15
    CF_HDROP = 15,
    
    /// CF_LOCALE -> 16
    CF_LOCALE = 16,
    
    /// CF_DIBV5 -> 17
    CF_DIBV5 = 17,
    
    /// CF_OWNERDISPLAY -> 0x0080
    CF_OWNERDISPLAY = 128,
    
    /// CF_DSPTEXT -> 0x0081
    CF_DSPTEXT = 129,
    
    /// CF_DSPBITMAP -> 0x0082
    CF_DSPBITMAP = 130,
    
    /// CF_DSPMETAFILEPICT -> 0x0083
    CF_DSPMETAFILEPICT = 131,
    
    /// CF_DSPENHMETAFILE -> 0x008E
    CF_DSPENHMETAFILE = 142,
    
    /// CF_PRIVATEFIRST -> 0x0200
    CF_PRIVATEFIRST = 512,
    
    /// CF_PRIVATELAST -> 0x02FF
    CF_PRIVATELAST = 767,
    
    /// CF_GDIOBJFIRST -> 0x0300
    CF_GDIOBJFIRST = 768,
    
    /// CF_GDIOBJLAST -> 0x03FF
    CF_GDIOBJLAST = 1023,

	}

	public enum VK
	{
		 /// VK_LBUTTON -> 0x01
    VK_LBUTTON = 1,
    
    /// VK_RBUTTON -> 0x02
    VK_RBUTTON = 2,
    
    /// VK_CANCEL -> 0x03
    VK_CANCEL = 3,
    
    /// VK_MBUTTON -> 0x04
    VK_MBUTTON = 4,
    
    /// VK_XBUTTON1 -> 0x05
    VK_XBUTTON1 = 5,
    
    /// VK_XBUTTON2 -> 0x06
    VK_XBUTTON2 = 6,
    
    /// VK_BACK -> 0x08
    VK_BACK = 8,
    
    /// VK_TAB -> 0x09
    VK_TAB = 9,
    
    /// VK_CLEAR -> 0x0C
    VK_CLEAR = 12,
    
    /// VK_RETURN -> 0x0D
    VK_RETURN = 13,
    
    /// VK_SHIFT -> 0x10
    VK_SHIFT = 16,
    
    /// VK_CONTROL -> 0x11
    VK_CONTROL = 17,
    
    /// VK_MENU -> 0x12
    VK_MENU = 18,
    
    /// VK_PAUSE -> 0x13
    VK_PAUSE = 19,
    
    /// VK_CAPITAL -> 0x14
    VK_CAPITAL = 20,
    
    /// VK_KANA -> 0x15
    VK_KANA = 21,
    
    /// VK_HANGEUL -> 0x15
    VK_HANGEUL = 21,
    
    /// VK_HANGUL -> 0x15
    VK_HANGUL = 21,
    
    /// VK_JUNJA -> 0x17
    VK_JUNJA = 23,
    
    /// VK_FINAL -> 0x18
    VK_FINAL = 24,
    
    /// VK_HANJA -> 0x19
    VK_HANJA = 25,
    
    /// VK_KANJI -> 0x19
    VK_KANJI = 25,
    
    /// VK_ESCAPE -> 0x1B
    VK_ESCAPE = 27,
    
    /// VK_CONVERT -> 0x1C
    VK_CONVERT = 28,
    
    /// VK_NONCONVERT -> 0x1D
    VK_NONCONVERT = 29,
    
    /// VK_ACCEPT -> 0x1E
    VK_ACCEPT = 30,
    
    /// VK_MODECHANGE -> 0x1F
    VK_MODECHANGE = 31,
    
    /// VK_SPACE -> 0x20
    VK_SPACE = 32,
    
    /// VK_PRIOR -> 0x21
    VK_PRIOR = 33,
    
    /// VK_NEXT -> 0x22
    VK_NEXT = 34,
    
    /// VK_END -> 0x23
    VK_END = 35,
    
    /// VK_HOME -> 0x24
    VK_HOME = 36,
    
    /// VK_LEFT -> 0x25
    VK_LEFT = 37,
    
    /// VK_UP -> 0x26
    VK_UP = 38,
    
    /// VK_RIGHT -> 0x27
    VK_RIGHT = 39,
    
    /// VK_DOWN -> 0x28
    VK_DOWN = 40,
    
    /// VK_SELECT -> 0x29
    VK_SELECT = 41,
    
    /// VK_PRINT -> 0x2A
    VK_PRINT = 42,
    
    /// VK_EXECUTE -> 0x2B
    VK_EXECUTE = 43,
    
    /// VK_SNAPSHOT -> 0x2C
    VK_SNAPSHOT = 44,
    
    /// VK_INSERT -> 0x2D
    VK_INSERT = 45,
    
    /// VK_DELETE -> 0x2E
    VK_DELETE = 46,
    
    /// VK_HELP -> 0x2F
    VK_HELP = 47,
    
    /// VK_LWIN -> 0x5B
    VK_LWIN = 91,
    
    /// VK_RWIN -> 0x5C
    VK_RWIN = 92,
    
    /// VK_APPS -> 0x5D
    VK_APPS = 93,
    
    /// VK_SLEEP -> 0x5F
    VK_SLEEP = 95,
    
    /// VK_NUMPAD0 -> 0x60
    VK_NUMPAD0 = 96,
    
    /// VK_NUMPAD1 -> 0x61
    VK_NUMPAD1 = 97,
    
    /// VK_NUMPAD2 -> 0x62
    VK_NUMPAD2 = 98,
    
    /// VK_NUMPAD3 -> 0x63
    VK_NUMPAD3 = 99,
    
    /// VK_NUMPAD4 -> 0x64
    VK_NUMPAD4 = 100,
    
    /// VK_NUMPAD5 -> 0x65
    VK_NUMPAD5 = 101,
    
    /// VK_NUMPAD6 -> 0x66
    VK_NUMPAD6 = 102,
    
    /// VK_NUMPAD7 -> 0x67
    VK_NUMPAD7 = 103,
    
    /// VK_NUMPAD8 -> 0x68
    VK_NUMPAD8 = 104,
    
    /// VK_NUMPAD9 -> 0x69
    VK_NUMPAD9 = 105,
    
    /// VK_MULTIPLY -> 0x6A
    VK_MULTIPLY = 106,
    
    /// VK_ADD -> 0x6B
    VK_ADD = 107,
    
    /// VK_SEPARATOR -> 0x6C
    VK_SEPARATOR = 108,
    
    /// VK_SUBTRACT -> 0x6D
    VK_SUBTRACT = 109,
    
    /// VK_DECIMAL -> 0x6E
    VK_DECIMAL = 110,
    
    /// VK_DIVIDE -> 0x6F
    VK_DIVIDE = 111,
    
    /// VK_F1 -> 0x70
    VK_F1 = 112,
    
    /// VK_F2 -> 0x71
    VK_F2 = 113,
    
    /// VK_F3 -> 0x72
    VK_F3 = 114,
    
    /// VK_F4 -> 0x73
    VK_F4 = 115,
    
    /// VK_F5 -> 0x74
    VK_F5 = 116,
    
    /// VK_F6 -> 0x75
    VK_F6 = 117,
    
    /// VK_F7 -> 0x76
    VK_F7 = 118,
    
    /// VK_F8 -> 0x77
    VK_F8 = 119,
    
    /// VK_F9 -> 0x78
    VK_F9 = 120,
    
    /// VK_F10 -> 0x79
    VK_F10 = 121,
    
    /// VK_F11 -> 0x7A
    VK_F11 = 122,
    
    /// VK_F12 -> 0x7B
    VK_F12 = 123,
    
    /// VK_F13 -> 0x7C
    VK_F13 = 124,
    
    /// VK_F14 -> 0x7D
    VK_F14 = 125,
    
    /// VK_F15 -> 0x7E
    VK_F15 = 126,
    
    /// VK_F16 -> 0x7F
    VK_F16 = 127,
    
    /// VK_F17 -> 0x80
    VK_F17 = 128,
    
    /// VK_F18 -> 0x81
    VK_F18 = 129,
    
    /// VK_F19 -> 0x82
    VK_F19 = 130,
    
    /// VK_F20 -> 0x83
    VK_F20 = 131,
    
    /// VK_F21 -> 0x84
    VK_F21 = 132,
    
    /// VK_F22 -> 0x85
    VK_F22 = 133,
    
    /// VK_F23 -> 0x86
    VK_F23 = 134,
    
    /// VK_F24 -> 0x87
    VK_F24 = 135,
    
    /// VK_NUMLOCK -> 0x90
    VK_NUMLOCK = 144,
    
    /// VK_SCROLL -> 0x91
    VK_SCROLL = 145,
    
    /// VK_OEM_NEC_EQUAL -> 0x92
    VK_OEM_NEC_EQUAL = 146,
    
    /// VK_OEM_FJ_JISHO -> 0x92
    VK_OEM_FJ_JISHO = 146,
    
    /// VK_OEM_FJ_MASSHOU -> 0x93
    VK_OEM_FJ_MASSHOU = 147,
    
    /// VK_OEM_FJ_TOUROKU -> 0x94
    VK_OEM_FJ_TOUROKU = 148,
    
    /// VK_OEM_FJ_LOYA -> 0x95
    VK_OEM_FJ_LOYA = 149,
    
    /// VK_OEM_FJ_ROYA -> 0x96
    VK_OEM_FJ_ROYA = 150,
    
    /// VK_LSHIFT -> 0xA0
    VK_LSHIFT = 160,
    
    /// VK_RSHIFT -> 0xA1
    VK_RSHIFT = 161,
    
    /// VK_LCONTROL -> 0xA2
    VK_LCONTROL = 162,
    
    /// VK_RCONTROL -> 0xA3
    VK_RCONTROL = 163,
    
    /// VK_LMENU -> 0xA4
    VK_LMENU = 164,
    
    /// VK_RMENU -> 0xA5
    VK_RMENU = 165,
    
    /// VK_BROWSER_BACK -> 0xA6
    VK_BROWSER_BACK = 166,
    
    /// VK_BROWSER_FORWARD -> 0xA7
    VK_BROWSER_FORWARD = 167,
    
    /// VK_BROWSER_REFRESH -> 0xA8
    VK_BROWSER_REFRESH = 168,
    
    /// VK_BROWSER_STOP -> 0xA9
    VK_BROWSER_STOP = 169,
    
    /// VK_BROWSER_SEARCH -> 0xAA
    VK_BROWSER_SEARCH = 170,
    
    /// VK_BROWSER_FAVORITES -> 0xAB
    VK_BROWSER_FAVORITES = 171,
    
    /// VK_BROWSER_HOME -> 0xAC
    VK_BROWSER_HOME = 172,
    
    /// VK_VOLUME_MUTE -> 0xAD
    VK_VOLUME_MUTE = 173,
    
    /// VK_VOLUME_DOWN -> 0xAE
    VK_VOLUME_DOWN = 174,
    
    /// VK_VOLUME_UP -> 0xAF
    VK_VOLUME_UP = 175,
    
    /// VK_MEDIA_NEXT_TRACK -> 0xB0
    VK_MEDIA_NEXT_TRACK = 176,
    
    /// VK_MEDIA_PREV_TRACK -> 0xB1
    VK_MEDIA_PREV_TRACK = 177,
    
    /// VK_MEDIA_STOP -> 0xB2
    VK_MEDIA_STOP = 178,
    
    /// VK_MEDIA_PLAY_PAUSE -> 0xB3
    VK_MEDIA_PLAY_PAUSE = 179,
    
    /// VK_LAUNCH_MAIL -> 0xB4
    VK_LAUNCH_MAIL = 180,
    
    /// VK_LAUNCH_MEDIA_SELECT -> 0xB5
    VK_LAUNCH_MEDIA_SELECT = 181,
    
    /// VK_LAUNCH_APP1 -> 0xB6
    VK_LAUNCH_APP1 = 182,
    
    /// VK_LAUNCH_APP2 -> 0xB7
    VK_LAUNCH_APP2 = 183,
    
    /// VK_OEM_1 -> 0xBA
    VK_OEM_1 = 186,
    
    /// VK_OEM_PLUS -> 0xBB
    VK_OEM_PLUS = 187,
    
    /// VK_OEM_COMMA -> 0xBC
    VK_OEM_COMMA = 188,
    
    /// VK_OEM_MINUS -> 0xBD
    VK_OEM_MINUS = 189,
    
    /// VK_OEM_PERIOD -> 0xBE
    VK_OEM_PERIOD = 190,
    
    /// VK_OEM_2 -> 0xBF
    VK_OEM_2 = 191,
    
    /// VK_OEM_3 -> 0xC0
    VK_OEM_3 = 192,
    
    /// VK_OEM_4 -> 0xDB
    VK_OEM_4 = 219,
    
    /// VK_OEM_5 -> 0xDC
    VK_OEM_5 = 220,
    
    /// VK_OEM_6 -> 0xDD
    VK_OEM_6 = 221,
    
    /// VK_OEM_7 -> 0xDE
    VK_OEM_7 = 222,
    
    /// VK_OEM_8 -> 0xDF
    VK_OEM_8 = 223,
    
    /// VK_OEM_AX -> 0xE1
    VK_OEM_AX = 225,
    
    /// VK_OEM_102 -> 0xE2
    VK_OEM_102 = 226,
    
    /// VK_ICO_HELP -> 0xE3
    VK_ICO_HELP = 227,
    
    /// VK_ICO_00 -> 0xE4
    VK_ICO_00 = 228,
    
    /// VK_PROCESSKEY -> 0xE5
    VK_PROCESSKEY = 229,
    
    /// VK_ICO_CLEAR -> 0xE6
    VK_ICO_CLEAR = 230,
    
    /// VK_PACKET -> 0xE7
    VK_PACKET = 231,
    
    /// VK_OEM_RESET -> 0xE9
    VK_OEM_RESET = 233,
    
    /// VK_OEM_JUMP -> 0xEA
    VK_OEM_JUMP = 234,
    
    /// VK_OEM_PA1 -> 0xEB
    VK_OEM_PA1 = 235,
    
    /// VK_OEM_PA2 -> 0xEC
    VK_OEM_PA2 = 236,
    
    /// VK_OEM_PA3 -> 0xED
    VK_OEM_PA3 = 237,
    
    /// VK_OEM_WSCTRL -> 0xEE
    VK_OEM_WSCTRL = 238,
    
    /// VK_OEM_CUSEL -> 0xEF
    VK_OEM_CUSEL = 239,
    
    /// VK_OEM_ATTN -> 0xF0
    VK_OEM_ATTN = 240,
    
    /// VK_OEM_FINISH -> 0xF1
    VK_OEM_FINISH = 241,
    
    /// VK_OEM_COPY -> 0xF2
    VK_OEM_COPY = 242,
    
    /// VK_OEM_AUTO -> 0xF3
    VK_OEM_AUTO = 243,
    
    /// VK_OEM_ENLW -> 0xF4
    VK_OEM_ENLW = 244,
    
    /// VK_OEM_BACKTAB -> 0xF5
    VK_OEM_BACKTAB = 245,
    
    /// VK_ATTN -> 0xF6
    VK_ATTN = 246,
    
    /// VK_CRSEL -> 0xF7
    VK_CRSEL = 247,
    
    /// VK_EXSEL -> 0xF8
    VK_EXSEL = 248,
    
    /// VK_EREOF -> 0xF9
    VK_EREOF = 249,
    
    /// VK_PLAY -> 0xFA
    VK_PLAY = 250,
    
    /// VK_ZOOM -> 0xFB
    VK_ZOOM = 251,
    
    /// VK_NONAME -> 0xFC
    VK_NONAME = 252,
    
    /// VK_PA1 -> 0xFD
    VK_PA1 = 253,
    
    /// VK_OEM_CLEAR -> 0xFE
    VK_OEM_CLEAR = 254,

	}

	public enum ST
	{
		/// ST_BLOCKNEXT -> 0x0080
		ST_BLOCKNEXT = 128,

		/// ST_BLOCKED -> 0x0008
		ST_BLOCKED = 8,
	}

	public enum BS
	{
		/// BS_PUSHBUTTON -> 0x00000000L
    BS_PUSHBUTTON = 0,
    
    /// BS_DEFPUSHBUTTON -> 0x00000001L
    BS_DEFPUSHBUTTON = 1,
    
    /// BS_CHECKBOX -> 0x00000002L
    BS_CHECKBOX = 2,
    
    /// BS_AUTOCHECKBOX -> 0x00000003L
    BS_AUTOCHECKBOX = 3,
    
    /// BS_RADIOBUTTON -> 0x00000004L
    BS_RADIOBUTTON = 4,
    
    /// BS_3STATE -> 0x00000005L
    BS_3STATE = 5,
    
    /// BS_AUTO3STATE -> 0x00000006L
    BS_AUTO3STATE = 6,
    
    /// BS_GROUPBOX -> 0x00000007L
    BS_GROUPBOX = 7,
    
    /// BS_USERBUTTON -> 0x00000008L
    BS_USERBUTTON = 8,
    
    /// BS_AUTORADIOBUTTON -> 0x00000009L
    BS_AUTORADIOBUTTON = 9,
    
    /// BS_PUSHBOX -> 0x0000000AL
    BS_PUSHBOX = 10,
    
    /// BS_OWNERDRAW -> 0x0000000BL
    BS_OWNERDRAW = 11,
    
    /// BS_TYPEMASK -> 0x0000000FL
    BS_TYPEMASK = 15,
    
    /// BS_LEFTTEXT -> 0x00000020L
    BS_LEFTTEXT = 32,
    
    /// BS_TEXT -> 0x00000000L
    BS_TEXT = 0,
    
    /// BS_ICON -> 0x00000040L
    BS_ICON = 64,
    
    /// BS_BITMAP -> 0x00000080L
    BS_BITMAP = 128,
    
    /// BS_LEFT -> 0x00000100L
    BS_LEFT = 256,
    
    /// BS_RIGHT -> 0x00000200L
    BS_RIGHT = 512,
    
    /// BS_CENTER -> 0x00000300L
    BS_CENTER = 768,
    
    /// BS_TOP -> 0x00000400L
    BS_TOP = 1024,
    
    /// BS_BOTTOM -> 0x00000800L
    BS_BOTTOM = 2048,
    
    /// BS_VCENTER -> 0x00000C00L
    BS_VCENTER = 3072,
    
    /// BS_PUSHLIKE -> 0x00001000L
    BS_PUSHLIKE = 4096,
    
    /// BS_MULTILINE -> 0x00002000L
    BS_MULTILINE = 8192,
    
    /// BS_NOTIFY -> 0x00004000L
    BS_NOTIFY = 16384,
    
    /// BS_FLAT -> 0x00008000L
    BS_FLAT = 32768,
    
    /// BS_RIGHTBUTTON -> BS_LEFTTEXT
    BS_RIGHTBUTTON = BS_LEFTTEXT,
	}

    // ReSharper restore InconsistentNaming
}