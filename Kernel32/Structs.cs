using System;
using System.Runtime.InteropServices;
using Win32Interop.Enums;
using Win32Interop.Methods;

namespace Win32Interop.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct EXCEPTION_POINTERS
    {
        /// PEXCEPTION_RECORD->EXCEPTION_RECORD*
        public IntPtr ExceptionRecord;

        /// PCONTEXT->CONTEXT*
        public IntPtr ContextRecord;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct COORD
    {
        /// SHORT->short
        public short X;

        /// SHORT->short
        public short Y;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct LARGE_INTEGER
    {
        /// Anonymous_9320654f_2227_43bf_a385_74cc8c562686
        [FieldOffset(0)]
        public LOW_HIGH lowHigh;

        /// Anonymous_947eb392_1446_4e25_bbd4_10e98165f3a9
        [FieldOffset(0)]
        public LOW_HIGH u;

        /// LONGLONG->__int64
        [FieldOffset(0)]
        public long QuadPart;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SMALL_RECT
    {
        /// SHORT->short
        public short Left;

        /// SHORT->short
        public short Top;

        /// SHORT->short
        public short Right;

        /// SHORT->short
        public short Bottom;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CHAR_INFO
    {
        /// Anonymous_f3630dcb_df39_4f30_a593_48e610e9363d
        public ENCODING_INFO Char;

        /// WORD->unsigned short
        public UInt16 Attributes;
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

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct GUID
    {
        /// unsigned int
        public uint Data1;

        /// unsigned short
        public ushort Data2;

        /// unsigned short
        public ushort Data3;

        /// unsigned char[8]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
        public string Data4;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct FILETIME
    {
        /// DWORD->unsigned int
        public uint dwLowDateTime;

        /// DWORD->unsigned int
        public uint dwHighDateTime;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct TIME_ZONE_INFORMATION
    {
        /// LONG->int
        public int Bias;

        /// WCHAR[32]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string StandardName;

        /// SYSTEMTIME->_SYSTEMTIME
        public SYSTEMTIME StandardDate;

        /// LONG->int
        public int StandardBias;

        /// WCHAR[32]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string DaylightName;

        /// SYSTEMTIME->_SYSTEMTIME
        public SYSTEMTIME DaylightDate;

        /// LONG->int
        public int DaylightBias;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SYSTEMTIME
    {
        /// WORD->unsigned short
        public ushort wYear;

        /// WORD->unsigned short
        public ushort wMonth;

        /// WORD->unsigned short
        public ushort wDayOfWeek;

        /// WORD->unsigned short
        public ushort wDay;

        /// WORD->unsigned short
        public ushort wHour;

        /// WORD->unsigned short
        public ushort wMinute;

        /// WORD->unsigned short
        public ushort wSecond;

        /// WORD->unsigned short
        public ushort wMilliseconds;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CONSOLE_CURSOR_INFO
    {
        /// DWORD->unsigned int
        public uint dwSize;

        /// BOOL->int
        [MarshalAs(UnmanagedType.Bool)]
        public bool bVisible;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct INPUT_RECORD
    {
        /// WORD->unsigned short
        public ushort EventType;

        /// Anonymous_79fe9041_6876_475e_b93a_ffb0d7822836
        public EVENT_INFO Event;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CURRENCYFMTW
    {
        /// UINT->unsigned int
        public uint NumDigits;

        /// UINT->unsigned int
        public uint LeadingZero;

        /// UINT->unsigned int
        public uint Grouping;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpDecimalSep;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpThousandSep;

        /// UINT->unsigned int
        public uint NegativeOrder;

        /// UINT->unsigned int
        public uint PositiveOrder;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpCurrencySymbol;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CURRENCYFMTA
    {
        /// UINT->unsigned int
        public uint NumDigits;

        /// UINT->unsigned int
        public uint LeadingZero;

        /// UINT->unsigned int
        public uint Grouping;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpDecimalSep;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpThousandSep;

        /// UINT->unsigned int
        public uint NegativeOrder;

        /// UINT->unsigned int
        public uint PositiveOrder;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpCurrencySymbol;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CONTEXT
    {
        /// DWORD->unsigned int
        public uint ContextFlags;

        /// DWORD->unsigned int
        public uint Dr0;

        /// DWORD->unsigned int
        public uint Dr1;

        /// DWORD->unsigned int
        public uint Dr2;

        /// DWORD->unsigned int
        public uint Dr3;

        /// DWORD->unsigned int
        public uint Dr6;

        /// DWORD->unsigned int
        public uint Dr7;

        /// FLOATING_SAVE_AREA->_FLOATING_SAVE_AREA
        public FLOATING_SAVE_AREA FloatSave;

        /// DWORD->unsigned int
        public uint SegGs;

        /// DWORD->unsigned int
        public uint SegFs;

        /// DWORD->unsigned int
        public uint SegEs;

        /// DWORD->unsigned int
        public uint SegDs;

        /// DWORD->unsigned int
        public uint Edi;

        /// DWORD->unsigned int
        public uint Esi;

        /// DWORD->unsigned int
        public uint Ebx;

        /// DWORD->unsigned int
        public uint Edx;

        /// DWORD->unsigned int
        public uint Ecx;

        /// DWORD->unsigned int
        public uint Eax;

        /// DWORD->unsigned int
        public uint Ebp;

        /// DWORD->unsigned int
        public uint Eip;

        /// DWORD->unsigned int
        public uint SegCs;

        /// DWORD->unsigned int
        public uint EFlags;

        /// DWORD->unsigned int
        public uint Esp;

        /// DWORD->unsigned int
        public uint SegSs;

        /// BYTE[512]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 512, ArraySubType = UnmanagedType.I1)]
        public byte[] ExtendedRegisters;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct NUMBERFMTW
    {
        /// UINT->unsigned int
        public uint NumDigits;

        /// UINT->unsigned int
        public uint LeadingZero;

        /// UINT->unsigned int
        public uint Grouping;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpDecimalSep;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpThousandSep;

        /// UINT->unsigned int
        public uint NegativeOrder;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct NUMBERFMTA
    {
        /// UINT->unsigned int
        public uint NumDigits;

        /// UINT->unsigned int
        public uint LeadingZero;

        /// UINT->unsigned int
        public uint Grouping;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpDecimalSep;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpThousandSep;

        /// UINT->unsigned int
        public uint NegativeOrder;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct FILE_SEGMENT_ELEMENT
    {
        /// PVOID64->void*
        [FieldOffset(0)]
        public IntPtr Buffer;

        /// ULONGLONG->unsigned __int64
        [FieldOffset(0)]
        public ulong Alignment;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SINGLE_LIST_ENTRY
    {
        /// _SINGLE_LIST_ENTRY*
        public IntPtr Next;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct OVERLAPPED
    {
        /// ULONG_PTR->unsigned int
        public uint Internal;

        /// ULONG_PTR->unsigned int
        public uint InternalHigh;

        /// Anonymous_7416d31a_1ce9_4e50_b1e1_0f2ad25c0196
        public DATA_INFO DataInfo;

        /// HANDLE->void*
        public IntPtr hEvent;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct BY_HANDLE_FILE_INFORMATION
    {
        /// DWORD->unsigned int
        public FILE_ATTRIBUTE dwFileAttributes;

        /// FILETIME->_FILETIME
        public FILETIME ftCreationTime;

        /// FILETIME->_FILETIME
        public FILETIME ftLastAccessTime;

        /// FILETIME->_FILETIME
        public FILETIME ftLastWriteTime;

        /// DWORD->unsigned int
        public uint dwVolumeSerialNumber;

        /// DWORD->unsigned int
        public uint nFileSizeHigh;

        /// DWORD->unsigned int
        public uint nFileSizeLow;

        /// DWORD->unsigned int
        public uint nNumberOfLinks;

        /// DWORD->unsigned int
        public uint nFileIndexHigh;

        /// DWORD->unsigned int
        public uint nFileIndexLow;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CONSOLE_SCREEN_BUFFER_INFO
    {
        /// COORD->_COORD
        public COORD dwSize;

        /// COORD->_COORD
        public COORD dwCursorPosition;

        /// WORD->unsigned short
        public CHARACTER_ATTRIBUTE wAttributes;

        /// SMALL_RECT->_SMALL_RECT
        public SMALL_RECT srWindow;

        /// COORD->_COORD
        public COORD dwMaximumWindowSize;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct SLIST_HEADER
    {
        /// ULONGLONG->unsigned __int64
        [FieldOffset(0)]
        public ulong Alignment;

        /// Anonymous_fd626461_7f3e_49a1_aabe_a2b90f0df936
        [FieldOffset(0)]
        public LIST_ITEM_INFO ListItemInfo;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ACTCTX_SECTION_KEYED_DATA
    {
        /// ULONG->unsigned int
        public uint cbSize;

        /// ULONG->unsigned int
        public uint ulDataFormatVersion;

        /// PVOID->void*
        public IntPtr lpData;

        /// ULONG->unsigned int
        public uint ulLength;

        /// PVOID->void*
        public IntPtr lpSectionGlobalData;

        /// ULONG->unsigned int
        public uint ulSectionGlobalDataLength;

        /// PVOID->void*
        public IntPtr lpSectionBase;

        /// ULONG->unsigned int
        public uint ulSectionTotalLength;

        /// HANDLE->void*
        public IntPtr hActCtx;

        /// ULONG->unsigned int
        public uint ulAssemblyRosterIndex;

        /// ULONG->unsigned int
        public uint ulFlags;

        /// ACTCTX_SECTION_KEYED_DATA_ASSEMBLY_METADATA->tagACTCTX_SECTION_KEYED_DATA_ASSEMBLY_METADATA
        public ACTCTX_SECTION_KEYED_DATA_ASSEMBLY_METADATA AssemblyMetadata;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DCB
    {
        /// DWORD->unsigned int
        public uint DCBlength;

        /// DWORD->unsigned int
        public uint BaudRate;

        /// fBinary : 1
        ///fParity : 1
        ///fOutxCtsFlow : 1
        ///fOutxDsrFlow : 1
        ///fDtrControl : 2
        ///fDsrSensitivity : 1
        ///fTXContinueOnXoff : 1
        ///fOutX : 1
        ///fInX : 1
        ///fErrorChar : 1
        ///fNull : 1
        ///fRtsControl : 2
        ///fAbortOnError : 1
        ///fDummy2 : 17
        public uint bitvector1;

        /// WORD->unsigned short
        public ushort wReserved;

        /// WORD->unsigned short
        public ushort XonLim;

        /// WORD->unsigned short
        public ushort XoffLim;

        /// BYTE->unsigned char
        public byte ByteSize;

        /// BYTE->unsigned char
        public byte Parity;

        /// BYTE->unsigned char
        public byte StopBits;

        /// char
        public byte XonChar;

        /// char
        public byte XoffChar;

        /// char
        public byte ErrorChar;

        /// char
        public byte EofChar;

        /// char
        public byte EvtChar;

        /// WORD->unsigned short
        public ushort wReserved1;

        public uint fBinary
        {
            get
            {
                return (((bitvector1 & 1u)));
            }
            set
            {
                bitvector1 = (((value | bitvector1)));
            }
        }

        public uint fParity
        {
            get
            {
                return ((((bitvector1 & 2u)
                          / 2)));
            }
            set
            {
                bitvector1 = ((((value * 2)
                                | bitvector1)));
            }
        }

        public uint fOutxCtsFlow
        {
            get
            {
                return ((((bitvector1 & 4u)
                          / 4)));
            }
            set
            {
                bitvector1 = ((((value * 4)
                                | bitvector1)));
            }
        }

        public uint fOutxDsrFlow
        {
            get
            {
                return ((((bitvector1 & 8u)
                          / 8)));
            }
            set
            {
                bitvector1 = ((((value * 8)
                                | bitvector1)));
            }
        }

        public uint fDtrControl
        {
            get
            {
                return ((((bitvector1 & 48u)
                          / 16)));
            }
            set
            {
                bitvector1 = ((((value * 16)
                                | bitvector1)));
            }
        }

        public uint fDsrSensitivity
        {
            get
            {
                return ((((bitvector1 & 64u)
                          / 64)));
            }
            set
            {
                bitvector1 = ((((value * 64)
                                | bitvector1)));
            }
        }

        public uint fTXContinueOnXoff
        {
            get
            {
                return ((((bitvector1 & 128u)
                          / 128)));
            }
            set
            {
                bitvector1 = ((((value * 128)
                                | bitvector1)));
            }
        }

        public uint fOutX
        {
            get
            {
                return ((((bitvector1 & 256u)
                          / 256)));
            }
            set
            {
                bitvector1 = ((((value * 256)
                                | bitvector1)));
            }
        }

        public uint fInX
        {
            get
            {
                return ((((bitvector1 & 512u)
                          / 512)));
            }
            set
            {
                bitvector1 = ((((value * 512)
                                | bitvector1)));
            }
        }

        public uint fErrorChar
        {
            get
            {
                return ((((bitvector1 & 1024u)
                          / 1024)));
            }
            set
            {
                bitvector1 = ((((value * 1024)
                                | bitvector1)));
            }
        }

        public uint fNull
        {
            get
            {
                return ((((bitvector1 & 2048u)
                          / 2048)));
            }
            set
            {
                bitvector1 = ((((value * 2048)
                                | bitvector1)));
            }
        }

        public uint fRtsControl
        {
            get
            {
                return ((((bitvector1 & 12288u)
                          / 4096)));
            }
            set
            {
                bitvector1 = ((((value * 4096)
                                | bitvector1)));
            }
        }

        public uint fAbortOnError
        {
            get
            {
                return ((((bitvector1 & 16384u)
                          / 16384)));
            }
            set
            {
                bitvector1 = ((((value * 16384)
                                | bitvector1)));
            }
        }

        public uint fDummy2
        {
            get
            {
                return ((((bitvector1 & 4294934528u)
                          / 32768)));
            }
            set
            {
                bitvector1 = ((((value * 32768)
                                | bitvector1)));
            }
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct COMMTIMEOUTS
    {
        /// DWORD->unsigned int
        public uint ReadIntervalTimeout;

        /// DWORD->unsigned int
        public uint ReadTotalTimeoutMultiplier;

        /// DWORD->unsigned int
        public uint ReadTotalTimeoutConstant;

        /// DWORD->unsigned int
        public uint WriteTotalTimeoutMultiplier;

        /// DWORD->unsigned int
        public uint WriteTotalTimeoutConstant;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CONSOLE_SELECTION_INFO
    {
        /// DWORD->unsigned int
        public CONSOLE_SELECTION dwFlags;

        /// COORD->_COORD
        public COORD dwSelectionAnchor;

        /// SMALL_RECT->_SMALL_RECT
        public SMALL_RECT srSelection;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct COMMCONFIG
    {
        /// DWORD->unsigned int
        public uint dwSize;

        /// WORD->unsigned short
        public ushort wVersion;

        /// WORD->unsigned short
        public ushort wReserved;

        /// DCB->_DCB
        public DCB dcb;

        /// DWORD->unsigned int
        public uint dwProviderSubType;

        /// DWORD->unsigned int
        public uint dwProviderOffset;

        /// DWORD->unsigned int
        public uint dwProviderSize;

        /// WCHAR[1]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
        public string wcProviderData;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CONSOLE_FONT_INFO
    {
        /// DWORD->unsigned int
        public uint nFont;

        /// COORD->_COORD
        public COORD dwFontSize;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MEMORYSTATUSEX
    {
        /// DWORD->unsigned int
        public uint dwLength;

        /// DWORD->unsigned int
        public uint dwMemoryLoad;

        /// DWORDLONG->ULONGLONG->unsigned __int64
        public ulong ullTotalPhys;

        /// DWORDLONG->ULONGLONG->unsigned __int64
        public ulong ullAvailPhys;

        /// DWORDLONG->ULONGLONG->unsigned __int64
        public ulong ullTotalPageFile;

        /// DWORDLONG->ULONGLONG->unsigned __int64
        public ulong ullAvailPageFile;

        /// DWORDLONG->ULONGLONG->unsigned __int64
        public ulong ullTotalVirtual;

        /// DWORDLONG->ULONGLONG->unsigned __int64
        public ulong ullAvailVirtual;

        /// DWORDLONG->ULONGLONG->unsigned __int64
        public ulong ullAvailExtendedVirtual;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SYSTEM_POWER_STATUS
    {
        /// BYTE->unsigned char
        public AC_STATUS ACLineStatus;

        /// BYTE->unsigned char
        public BATTERY_STATUS BatteryFlag;

        /// BYTE->unsigned char
        public byte BatteryLifePercent;

        /// BYTE->unsigned char
        public byte Reserved1;

        /// DWORD->unsigned int
        public uint BatteryLifeTime;

        /// DWORD->unsigned int
        public uint BatteryFullLifeTime;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SYSTEM_INFO
    {
        /// Anonymous_459bdf75_2992_4fef_9fb5_389952f59d12
        public PROCESSOR_INFO processorInfo;

        /// DWORD->unsigned int
        public uint dwPageSize;

        /// LPVOID->void*
        public IntPtr lpMinimumApplicationAddress;

        /// LPVOID->void*
        public IntPtr lpMaximumApplicationAddress;

        /// DWORD_PTR->ULONG_PTR->unsigned int
        public uint dwActiveProcessorMask;

        /// DWORD->unsigned int
        public uint dwNumberOfProcessors;

        /// DWORD->unsigned int
        public uint dwProcessorType;

        /// DWORD->unsigned int
        public uint dwAllocationGranularity;

        /// WORD->unsigned short
        public ushort wProcessorLevel;

        /// WORD->unsigned short
        public ushort wProcessorRevision;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct RTL_OSVERSIONINFOEX
    {
        /// DWORD->unsigned int
        public uint dwOSVersionInfoSize;

        /// DWORD->unsigned int
        public uint dwMajorVersion;

        /// DWORD->unsigned int
        public uint dwMinorVersion;

        /// DWORD->unsigned int
        public uint dwBuildNumber;

        /// DWORD->unsigned int
        public uint dwPlatformId;

        /// WCHAR[128]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public string szCSDVersion;

        /// WORD->unsigned short
        public ushort wServicePackMajor;

        /// WORD->unsigned short
        public ushort wServicePackMinor;

        /// WORD->unsigned short
        public ushort wSuiteMask;

        /// BYTE->unsigned char
        public byte wProductType;

        /// BYTE->unsigned char
        public byte wReserved;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MEMORYSTATUS
    {
        /// DWORD->unsigned int
        public uint dwLength;

        /// DWORD->unsigned int
        public uint dwMemoryLoad;

        /// SIZE_T->ULONG_PTR->unsigned int
        public uint dwTotalPhys;

        /// SIZE_T->ULONG_PTR->unsigned int
        public uint dwAvailPhys;

        /// SIZE_T->ULONG_PTR->unsigned int
        public uint dwTotalPageFile;

        /// SIZE_T->ULONG_PTR->unsigned int
        public uint dwAvailPageFile;

        /// SIZE_T->ULONG_PTR->unsigned int
        public uint dwTotalVirtual;

        /// SIZE_T->ULONG_PTR->unsigned int
        public uint dwAvailVirtual;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DEBUG_EVENT
    {
        /// DWORD->unsigned int
        public uint dwDebugEventCode;

        /// DWORD->unsigned int
        public uint dwProcessId;

        /// DWORD->unsigned int
        public uint dwThreadId;

        /// Anonymous_c0f5f2ce_b74f_423c_81ee_f2fb7ef45eb7
        public EXCEPTION_INFO u;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct COMMPROP
    {
        /// WORD->unsigned short
        public ushort wPacketLength;

        /// WORD->unsigned short
        public ushort wPacketVersion;

        /// DWORD->unsigned int
        public uint dwServiceMask;

        /// DWORD->unsigned int
        public uint dwReserved1;

        /// DWORD->unsigned int
        public uint dwMaxTxQueue;

        /// DWORD->unsigned int
        public uint dwMaxRxQueue;

        /// DWORD->unsigned int
        public uint dwMaxBaud;

        /// DWORD->unsigned int
        public uint dwProvSubType;

        /// DWORD->unsigned int
        public uint dwProvCapabilities;

        /// DWORD->unsigned int
        public uint dwSettableParams;

        /// DWORD->unsigned int
        public uint dwSettableBaud;

        /// WORD->unsigned short
        public ushort wSettableData;

        /// WORD->unsigned short
        public ushort wSettableStopParity;

        /// DWORD->unsigned int
        public uint dwCurrentTxQueue;

        /// DWORD->unsigned int
        public uint dwCurrentRxQueue;

        /// DWORD->unsigned int
        public uint dwProvSpec1;

        /// DWORD->unsigned int
        public uint dwProvSpec2;

        /// WCHAR[1]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
        public string wcProvChar;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct STARTUPINFO
    {
        /// DWORD->unsigned int
        public uint cb;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPTStr)]
        public string lpReserved;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPTStr)]
        public string lpDesktop;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPTStr)]
        public string lpTitle;

        /// DWORD->unsigned int
        public uint dwX;

        /// DWORD->unsigned int
        public uint dwY;

        /// DWORD->unsigned int
        public uint dwXSize;

        /// DWORD->unsigned int
        public uint dwYSize;

        /// DWORD->unsigned int
        public uint dwXCountChars;

        /// DWORD->unsigned int
        public uint dwYCountChars;

        /// DWORD->unsigned int
        public CHARACTER_ATTRIBUTE dwFillAttribute;

        /// DWORD->unsigned int
        public STARTF dwFlags;

        /// WORD->unsigned short
        public ushort wShowWindow;

        /// WORD->unsigned short
        public ushort cbReserved2;

        /// LPBYTE->BYTE*
        public IntPtr lpReserved2;

        /// HANDLE->void*
        public IntPtr hStdInput;

        /// HANDLE->void*
        public IntPtr hStdOutput;

        /// HANDLE->void*
        public IntPtr hStdError;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MEMORY_BASIC_INFORMATION
    {
        /// PVOID->void*
        public IntPtr BaseAddress;

        /// PVOID->void*
        public IntPtr AllocationBase;

        /// DWORD->unsigned int
        public uint AllocationProtect;

        /// SIZE_T->ULONG_PTR->unsigned int
        public uint RegionSize;

        /// DWORD->unsigned int
        public uint State;

        /// DWORD->unsigned int
        public uint Protect;

        /// DWORD->unsigned int
        public uint Type;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct WIN32_FIND_DATA
    {
        /// DWORD->unsigned int
        public FILE_ATTRIBUTE dwFileAttributes;

        /// FILETIME->_FILETIME
        public FILETIME ftCreationTime;

        /// FILETIME->_FILETIME
        public FILETIME ftLastAccessTime;

        /// FILETIME->_FILETIME
        public FILETIME ftLastWriteTime;

        /// DWORD->unsigned int
        public uint nFileSizeHigh;

        /// DWORD->unsigned int
        public uint nFileSizeLow;

        /// DWORD->unsigned int
        public uint dwReserved0;

        /// DWORD->unsigned int
        public uint dwReserved1;

        /// WCHAR[260]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
        public string cFileName;

        /// WCHAR[14]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 14)]
        public string cAlternateFileName;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PROCESS_INFORMATION
    {
        /// HANDLE->void*
        public IntPtr hProcess;

        /// HANDLE->void*
        public IntPtr hThread;

        /// DWORD->unsigned int
        public uint dwProcessId;

        /// DWORD->unsigned int
        public uint dwThreadId;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct COMSTAT
    {
        /// fCtsHold : 1
        ///fDsrHold : 1
        ///fRlsdHold : 1
        ///fXoffHold : 1
        ///fXoffSent : 1
        ///fEof : 1
        ///fTxim : 1
        ///fReserved : 25
        public uint bitvector1;

        /// DWORD->unsigned int
        public uint cbInQue;

        /// DWORD->unsigned int
        public uint cbOutQue;

        public uint fCtsHold
        {
            get
            {
                return (((bitvector1 & 1u)));
            }
            set
            {
                bitvector1 = (((value | bitvector1)));
            }
        }

        public uint fDsrHold
        {
            get
            {
                return ((((bitvector1 & 2u)
                          / 2)));
            }
            set
            {
                bitvector1 = ((((value * 2)
                                | bitvector1)));
            }
        }

        public uint fRlsdHold
        {
            get
            {
                return ((((bitvector1 & 4u)
                          / 4)));
            }
            set
            {
                bitvector1 = ((((value * 4)
                                | bitvector1)));
            }
        }

        public uint fXoffHold
        {
            get
            {
                return ((((bitvector1 & 8u)
                          / 8)));
            }
            set
            {
                bitvector1 = ((((value * 8)
                                | bitvector1)));
            }
        }

        public uint fXoffSent
        {
            get
            {
                return ((((bitvector1 & 16u)
                          / 16)));
            }
            set
            {
                bitvector1 = ((((value * 16)
                                | bitvector1)));
            }
        }

        public uint fEof
        {
            get
            {
                return ((((bitvector1 & 32u)
                          / 32)));
            }
            set
            {
                bitvector1 = ((((value * 32)
                                | bitvector1)));
            }
        }

        public uint fTxim
        {
            get
            {
                return ((((bitvector1 & 64u)
                          / 64)));
            }
            set
            {
                bitvector1 = ((((value * 64)
                                | bitvector1)));
            }
        }

        public uint fReserved
        {
            get
            {
                return ((((bitvector1 & 4294967168u)
                          / 128)));
            }
            set
            {
                bitvector1 = ((((value * 128)
                                | bitvector1)));
            }
        }
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct RTL_OSVERSIONINFO
    {
        /// DWORD->unsigned int
        public uint dwOSVersionInfoSize;

        /// DWORD->unsigned int
        public uint dwMajorVersion;

        /// DWORD->unsigned int
        public uint dwMinorVersion;

        /// DWORD->unsigned int
        public uint dwBuildNumber;

        /// DWORD->unsigned int
        public uint dwPlatformId;

        /// WCHAR[128]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public string szCSDVersion;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct CPINFOEX
    {
        /// UINT->unsigned int
        public uint MaxCharSize;

        /// BYTE[2]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
        public byte[] DefaultChar;

        /// BYTE[12]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
        public byte[] LeadByte;

        /// WCHAR->wchar_t->unsigned short
        public ushort UnicodeDefaultChar;

        /// UINT->unsigned int
        public uint CodePage;

        /// WCHAR[260]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
        public string CodePageName;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct JOB_SET_ARRAY
    {
        /// HANDLE->void*
        public IntPtr JobHandle;

        /// DWORD->unsigned int
        public uint MemberLevel;

        /// DWORD->unsigned int
        public uint Flags;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct OFSTRUCT
    {
        /// BYTE->unsigned char
        public byte cBytes;

        /// BYTE->unsigned char
        public byte fFixedDisk;

        /// WORD->unsigned short
        public ushort nErrCode;

        /// WORD->unsigned short
        public ushort Reserved1;

        /// WORD->unsigned short
        public ushort Reserved2;

        /// CHAR[128]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public string szPathName;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CPINFO
    {
        /// UINT->unsigned int
        public uint MaxCharSize;

        /// BYTE[2]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
        public byte[] DefaultChar;

        /// BYTE[12]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
        public byte[] LeadByte;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PROCESS_HEAP_ENTRY
    {
        /// PVOID->void*
        public IntPtr lpData;

        /// DWORD->unsigned int
        public uint cbData;

        /// BYTE->unsigned char
        public byte cbOverhead;

        /// BYTE->unsigned char
        public byte iRegionIndex;

        /// WORD->unsigned short
        public PROCESS_HEAP wFlags;

        /// Anonymous_53c79322_6506_4260_871f_234e2af0cacb
        public BLOCK_REGION BlockRegion;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct IO_COUNTERS
    {
        /// ULONGLONG->unsigned __int64
        public ulong ReadOperationCount;

        /// ULONGLONG->unsigned __int64
        public ulong WriteOperationCount;

        /// ULONGLONG->unsigned __int64
        public ulong OtherOperationCount;

        /// ULONGLONG->unsigned __int64
        public ulong ReadTransferCount;

        /// ULONGLONG->unsigned __int64
        public ulong WriteTransferCount;

        /// ULONGLONG->unsigned __int64
        public ulong OtherTransferCount;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct ULARGE_INTEGER
    {
        /// Anonymous_652f900e_e9d5_4a81_ba95_5c3af2ba5157
        [FieldOffset(0)]
        public LOW_HIGH lowHigh;

        /// Anonymous_da3d5bb2_d7f6_4b49_a86f_df044e26e59a
        [FieldOffset(0)]
        public LOW_HIGH u;

        /// ULONGLONG->unsigned __int64
        [FieldOffset(0)]
        public ulong QuadPart;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ACTCTX
    {
        /// ULONG->unsigned int
        public uint cbSize;

        /// DWORD->unsigned int
        public ACTCTX_FLAG dwFlags;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPTStr)]
        public string lpSource;

        /// USHORT->unsigned short
        public ushort wProcessorArchitecture;

        /// LANGID->WORD->unsigned short
        public ushort wLangId;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPTStr)]
        public string lpAssemblyDirectory;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPTStr)]
        public string lpResourceName;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPTStr)]
        public string lpApplicationName;

        /// HMODULE->HINSTANCE->HINSTANCE__*
        public IntPtr hModule;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct ENCODING_INFO
    {
        /// WCHAR->wchar_t->unsigned short
        [FieldOffset(0)]
        public ushort UnicodeChar;

        /// CHAR->char
        [FieldOffset(0)]
        public byte AsciiChar;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct EVENT_INFO
    {
        /// KEY_EVENT_RECORD->_KEY_EVENT_RECORD
        [FieldOffset(0)]
        public KEY_EVENT_RECORD KeyEvent;

        /// MOUSE_EVENT_RECORD->_MOUSE_EVENT_RECORD
        [FieldOffset(0)]
        public MOUSE_EVENT_RECORD MouseEvent;

        /// WINDOW_BUFFER_SIZE_RECORD->_WINDOW_BUFFER_SIZE_RECORD
        [FieldOffset(0)]
        public WINDOW_BUFFER_SIZE_RECORD WindowBufferSizeEvent;

        /// MENU_EVENT_RECORD->_MENU_EVENT_RECORD
        [FieldOffset(0)]
        public MENU_EVENT_RECORD MenuEvent;

        /// FOCUS_EVENT_RECORD->_FOCUS_EVENT_RECORD
        [FieldOffset(0)]
        public FOCUS_EVENT_RECORD FocusEvent;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct DATA_INFO
    {
        /// Anonymous_ac6e4301_4438_458f_96dd_e86faeeca2a6
        [FieldOffset(0)]
        public OFFSET_INFO offsetInfo;

        /// PVOID->void*
        [FieldOffset(0)]
        public IntPtr Pointer;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct LIST_ITEM_INFO
    {
        /// SINGLE_LIST_ENTRY->_SINGLE_LIST_ENTRY
        public SINGLE_LIST_ENTRY Next;

        /// WORD->unsigned short
        public ushort Depth;

        /// WORD->unsigned short
        public ushort Sequence;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct PROCESSOR_INFO
    {
        /// DWORD->unsigned int
        [FieldOffset(0)]
        public uint dwOemId;

        /// Anonymous_a30d5f78_3b46_471a_9d25_915a0fe3987d
        [FieldOffset(0)]
        public PROCESSOR_ARCHITECTURE processorArchitecture;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct EXCEPTION_INFO
    {
        /// EXCEPTION_DEBUG_INFO->_EXCEPTION_DEBUG_INFO
        [FieldOffset(0)]
        public EXCEPTION_DEBUG_INFO Exception;

        /// CREATE_THREAD_DEBUG_INFO->_CREATE_THREAD_DEBUG_INFO
        [FieldOffset(0)]
        public CREATE_THREAD_DEBUG_INFO CreateThread;

        /// CREATE_PROCESS_DEBUG_INFO->_CREATE_PROCESS_DEBUG_INFO
        [FieldOffset(0)]
        public CREATE_PROCESS_DEBUG_INFO CreateProcessInfo;

        /// EXIT_THREAD_DEBUG_INFO->_EXIT_THREAD_DEBUG_INFO
        [FieldOffset(0)]
        public EXIT_THREAD_DEBUG_INFO ExitThread;

        /// EXIT_PROCESS_DEBUG_INFO->_EXIT_PROCESS_DEBUG_INFO
        [FieldOffset(0)]
        public EXIT_PROCESS_DEBUG_INFO ExitProcess;

        /// LOAD_DLL_DEBUG_INFO->_LOAD_DLL_DEBUG_INFO
        [FieldOffset(0)]
        public LOAD_DLL_DEBUG_INFO LoadDll;

        /// UNLOAD_DLL_DEBUG_INFO->_UNLOAD_DLL_DEBUG_INFO
        [FieldOffset(0)]
        public UNLOAD_DLL_DEBUG_INFO UnloadDll;

        /// OUTPUT_DEBUG_STRING_INFO->_OUTPUT_DEBUG_STRING_INFO
        [FieldOffset(0)]
        public OUTPUT_DEBUG_STRING_INFO DebugString;

        /// RIP_INFO->_RIP_INFO
        [FieldOffset(0)]
        public RIP_INFO RipInfo;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct BLOCK_REGION
    {
        /// Anonymous_8fdd9a27_0167_4a68_9d58_0eb653f5b1e6
        [FieldOffset(0)]
        public BLOCK_DATA Block;

        /// Anonymous_e469aa29_5a46_4c74_b009_60adb4b669c8
        [FieldOffset(0)]
        public REGION_DATA Region;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct RTL_CRITICAL_SECTION
    {
        /// PRTL_CRITICAL_SECTION_DEBUG->_RTL_CRITICAL_SECTION_DEBUG*
        public IntPtr DebugInfo;

        /// LONG->int
        public int LockCount;

        /// LONG->int
        public int RecursionCount;

        /// HANDLE->void*
        public IntPtr OwningThread;

        /// HANDLE->void*
        public IntPtr LockSemaphore;

        /// ULONG_PTR->unsigned int
        public uint SpinCount;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct LDT_ENTRY
    {
        /// WORD->unsigned short
        public ushort LimitLow;

        /// WORD->unsigned short
        public ushort BaseLow;

        /// Anonymous_6ec22b34_e8ab_46f2_a900_b8a44fc9e55d
        public HIGH_WORD HighWord;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct FLOATING_SAVE_AREA
    {
        /// DWORD->unsigned int
        public uint ControlWord;

        /// DWORD->unsigned int
        public uint StatusWord;

        /// DWORD->unsigned int
        public uint TagWord;

        /// DWORD->unsigned int
        public uint ErrorOffset;

        /// DWORD->unsigned int
        public uint ErrorSelector;

        /// DWORD->unsigned int
        public uint DataOffset;

        /// DWORD->unsigned int
        public uint DataSelector;

        /// BYTE[80]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 80, ArraySubType = UnmanagedType.I1)]
        public byte[] RegisterArea;

        /// DWORD->unsigned int
        public uint Cr0NpxState;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ACTCTX_SECTION_KEYED_DATA_ASSEMBLY_METADATA
    {
        /// PVOID->void*
        public IntPtr lpInformation;

        /// PVOID->void*
        public IntPtr lpSectionBase;

        /// ULONG->unsigned int
        public uint ulSectionLength;

        /// PVOID->void*
        public IntPtr lpSectionGlobalDataBase;

        /// ULONG->unsigned int
        public uint ulSectionGlobalDataLength;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct EXCEPTION_RECORD
    {
        /// DWORD->unsigned int
        public uint ExceptionCode;

        /// DWORD->unsigned int
        public EXCEPTION ExceptionFlags;

        /// _EXCEPTION_RECORD*
        public IntPtr ExceptionRecord;

        /// PVOID->void*
        public IntPtr ExceptionAddress;

        /// DWORD->unsigned int
        public uint NumberParameters;

        /// ULONG_PTR[15]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 15, ArraySubType = UnmanagedType.U4)]
        public uint[] ExceptionInformation;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct LOW_HIGH
    {
        /// DWORD->unsigned int
        public uint LowPart;

        /// DWORD->unsigned int
        public uint HighPart;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct OFFSET_INFO
    {
        /// DWORD->unsigned int
        public uint Offset;

        /// DWORD->unsigned int
        public uint OffsetHigh;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PROCESSOR_ARCHITECTURE
    {
        /// WORD->unsigned short
        public ushort wProcessorArchitecture;

        /// WORD->unsigned short
        public ushort wReserved;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct BLOCK_DATA
    {
        /// HANDLE->void*
        public IntPtr hMem;

        /// DWORD[3]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.U4)]
        public uint[] dwReserved;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct REGION_DATA
    {
        /// DWORD->unsigned int
        public uint dwCommittedSize;

        /// DWORD->unsigned int
        public uint dwUnCommittedSize;

        /// LPVOID->void*
        public IntPtr lpFirstBlock;

        /// LPVOID->void*
        public IntPtr lpLastBlock;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct HIGH_WORD
    {
        /// Anonymous_715d4807_68f7_43b3_b3b6_d2fd0500eaa4
        [FieldOffset(0)]
        public BYTES_INFO Bytes;

        /// Anonymous_75f63f95_3c9e_4dd3_9ea4_4111163afbd5
        [FieldOffset(0)]
        public BITS_INFO Bits;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct KEY_EVENT_RECORD
    {
        /// BOOL->int
        [MarshalAs(UnmanagedType.Bool)]
        public bool bKeyDown;

        /// WORD->unsigned short
        public ushort wRepeatCount;

        /// WORD->unsigned short
        public ushort wVirtualKeyCode;

        /// WORD->unsigned short
        public ushort wVirtualScanCode;

        /// Anonymous_ee4ad878_dde2_4d9b_b7de_b1588db350c7
        public ENCODING_INFO uChar;

        /// DWORD->unsigned int
        public uint dwControlKeyState;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MOUSE_EVENT_RECORD
    {
        /// COORD->_COORD
        public COORD dwMousePosition;

        /// DWORD->unsigned int
        public BUTTON_STATE dwButtonState;

        /// DWORD->unsigned int
        public CONTROL_KEY_STATE dwControlKeyState;

        /// DWORD->unsigned int
		public MOUSE_EVENT_FLAG dwEventFlags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct WINDOW_BUFFER_SIZE_RECORD
    {
        /// COORD->_COORD
        public COORD dwSize;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MENU_EVENT_RECORD
    {
        /// UINT->unsigned int
        public uint dwCommandId;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct FOCUS_EVENT_RECORD
    {
        /// BOOL->int
        [MarshalAs(UnmanagedType.Bool)]
        public bool bSetFocus;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct EXCEPTION_DEBUG_INFO
    {
        /// EXCEPTION_RECORD->_EXCEPTION_RECORD
        public EXCEPTION_RECORD ExceptionRecord;

        /// DWORD->unsigned int
        public uint dwFirstChance;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CREATE_THREAD_DEBUG_INFO
    {
        /// HANDLE->void*
        public IntPtr hThread;

        /// LPVOID->void*
        public IntPtr lpThreadLocalBase;

        /// LPTHREAD_START_ROUTINE->PTHREAD_START_ROUTINE
        public PTHREAD_START_ROUTINE lpStartAddress;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CREATE_PROCESS_DEBUG_INFO
    {
        /// HANDLE->void*
        public IntPtr hFile;

        /// HANDLE->void*
        public IntPtr hProcess;

        /// HANDLE->void*
        public IntPtr hThread;

        /// LPVOID->void*
        public IntPtr lpBaseOfImage;

        /// DWORD->unsigned int
        public uint dwDebugInfoFileOffset;

        /// DWORD->unsigned int
        public uint nDebugInfoSize;

        /// LPVOID->void*
        public IntPtr lpThreadLocalBase;

        /// LPTHREAD_START_ROUTINE->PTHREAD_START_ROUTINE
        public PTHREAD_START_ROUTINE lpStartAddress;

        /// LPVOID->void*
        public IntPtr lpImageName;

        /// WORD->unsigned short
        public ushort fUnicode;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct EXIT_THREAD_DEBUG_INFO
    {
        /// DWORD->unsigned int
        public uint dwExitCode;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct EXIT_PROCESS_DEBUG_INFO
    {
        /// DWORD->unsigned int
        public uint dwExitCode;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct LOAD_DLL_DEBUG_INFO
    {
        /// HANDLE->void*
        public IntPtr hFile;

        /// LPVOID->void*
        public IntPtr lpBaseOfDll;

        /// DWORD->unsigned int
        public uint dwDebugInfoFileOffset;

        /// DWORD->unsigned int
        public uint nDebugInfoSize;

        /// LPVOID->void*
        public IntPtr lpImageName;

        /// WORD->unsigned short
        public ushort fUnicode;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct UNLOAD_DLL_DEBUG_INFO
    {
        /// LPVOID->void*
        public IntPtr lpBaseOfDll;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct OUTPUT_DEBUG_STRING_INFO
    {
        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpDebugStringData;

        /// WORD->unsigned short
        public ushort fUnicode;

        /// WORD->unsigned short
        public ushort nDebugStringLength;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct RIP_INFO
    {
        /// DWORD->unsigned int
        public uint dwError;

        /// DWORD->unsigned int
        public uint dwType;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct BYTES_INFO
    {
        /// BYTE->unsigned char
        public byte BaseMid;

        /// BYTE->unsigned char
        public byte Flags1;

        /// BYTE->unsigned char
        public byte Flags2;

        /// BYTE->unsigned char
        public byte BaseHi;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct BITS_INFO
    {
        /// BaseMid : 8
        ///Type : 5
        ///Dpl : 2
        ///Pres : 1
        ///LimitHi : 4
        ///Sys : 1
        ///Reserved_0 : 1
        ///Default_Big : 1
        ///Granularity : 1
        ///BaseHi : 8
        public uint bitvector1;

        public uint BaseMid
        {
            get
            {
                return (((bitvector1 & 255u)));
            }

            set
            {
                bitvector1 = (((value | bitvector1)));
            }
        }

        public uint Type
        {
            get
            {
                return ((((bitvector1 & 7936u)
                          / 256)));
            }

            set
            {
                bitvector1 = ((((value * 256)
                                | bitvector1)));
            }
        }

        public uint Dpl
        {
            get
            {
                return ((((bitvector1 & 24576u)
                          / 8192)));
            }

            set
            {
                bitvector1 = ((((value * 8192)
                                | bitvector1)));
            }
        }

        public uint Pres
        {
            get
            {
                return ((((bitvector1 & 32768u)
                          / 32768)));
            }

            set
            {
                bitvector1 = ((((value * 32768)
                                | bitvector1)));
            }
        }

        public uint LimitHi
        {
            get
            {
                return ((((bitvector1 & 983040u)
                          / 65536)));
            }

            set
            {
                bitvector1 = ((((value * 65536)
                                | bitvector1)));
            }
        }

        public uint Sys
        {
            get
            {
                return ((((bitvector1 & 1048576u)
                          / 1048576)));
            }

            set
            {
                bitvector1 = ((((value * 1048576)
                                | bitvector1)));
            }
        }

        public uint Reserved_0
        {
            get
            {
                return ((((bitvector1 & 2097152u)
                          / 2097152)));
            }

            set
            {
                bitvector1 = ((((value * 2097152)
                                | bitvector1)));
            }
        }

        public uint Default_Big
        {
            get
            {
                return ((((bitvector1 & 4194304u)
                          / 4194304)));
            }

            set
            {
                bitvector1 = ((((value * 4194304)
                                | bitvector1)));
            }
        }

        public uint Granularity
        {
            get
            {
                return ((((bitvector1 & 8388608u)
                          / 8388608)));
            }

            set
            {
                bitvector1 = ((((value * 8388608)
                                | bitvector1)));
            }
        }

        public uint BaseHi
        {
            get
            {
                return ((((bitvector1 & 4278190080u)
                          / 16777216)));
            }

            set
            {
                bitvector1 = ((((value * 16777216)
                                | bitvector1)));
            }
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct RTL_RESOURCE_DEBUG
    {
        /// WORD->unsigned short
        public ushort Type;

        /// WORD->unsigned short
        public ushort CreatorBackTraceIndex;

        /// _RTL_CRITICAL_SECTION*
        public IntPtr CriticalSection;

        /// LIST_ENTRY->_LIST_ENTRY
        public LIST_ENTRY ProcessLocksList;

        /// DWORD->unsigned int
        public uint EntryCount;

        /// DWORD->unsigned int
        public uint ContentionCount;

        /// DWORD[2]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.U4)]
        public uint[] Spare;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct LIST_ENTRY
    {
        /// _LIST_ENTRY*
        public IntPtr Flink;

        /// _LIST_ENTRY*
        public IntPtr Blink;
    }

	public struct CONSOLE_SCREEN_BUFFER_INFOEX
	{

		/// ULONG->unsigned int
		public uint cbSize;

		/// COORD->_COORD
		public COORD dwSize;

		/// COORD->_COORD
		public COORD dwCursorPosition;

		/// WORD->unsigned short
		public ushort wAttributes;

		/// SMALL_RECT->_SMALL_RECT
		public SMALL_RECT srWindow;

		/// COORD->_COORD
		public COORD dwMaximumWindowSize;

		/// WORD->unsigned short
		public ushort wPopupAttributes;

		/// BOOL->int
		[MarshalAsAttribute(UnmanagedType.Bool)]
		public bool bFullscreenSupported;

		/// COLORREF[16]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.U4)]
		public uint[] ColorTable;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public class CONSOLE_FONT_INFOEX
	{
		private int cbSize;
		public CONSOLE_FONT_INFOEX()
		{
			cbSize = Marshal.SizeOf(typeof(CONSOLE_FONT_INFOEX));
		}
		public int FontIndex;
		public short FontWidth;
		public short FontHeight;
		public int FontFamily;
		public int FontWeight;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
		public string FaceName;
	}

}
