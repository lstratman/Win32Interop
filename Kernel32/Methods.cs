using System;
using System.Runtime.InteropServices;
using System.Text;
using Win32Interop.Enums;
using Win32Interop.Structs;
using FILETIME = Win32Interop.Structs.FILETIME;

// ReSharper disable CheckNamespace
namespace Win32Interop.Methods
// ReSharper restore CheckNamespace
{
    // ReSharper disable InconsistentNaming
    /// Return Type: void
    ///param0: PVOID->void*
    ///param1: BOOLEAN->BYTE->unsigned char
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void WAITORTIMERCALLBACKFUNC(IntPtr param0, byte param1);

    /// Return Type: DWORD->unsigned int
    ///lpThreadParameter: LPVOID->void*
    public delegate uint PTHREAD_START_ROUTINE(IntPtr lpThreadParameter);

    /// Return Type: void
    ///lpFiberParameter: LPVOID->void*
    public delegate void PFIBER_START_ROUTINE(IntPtr lpFiberParameter);

    /// Return Type: int
    public delegate int FARPROC();

    /// Return Type: LONG->int
    ///ExceptionInfo: _EXCEPTION_POINTERS*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int PVECTORED_EXCEPTION_HANDLER(ref EXCEPTION_POINTERS ExceptionInfo);

    /// Return Type: BOOL->int
    ///param0: LGRPID->DWORD->unsigned int
    ///param1: LPWSTR->WCHAR*
    ///param2: LPWSTR->WCHAR*
    ///param3: DWORD->unsigned int
    ///param4: LONG_PTR->int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int LANGUAGEGROUP_ENUMPROC(
        uint param0, [MarshalAs(UnmanagedType.LPTStr)] StringBuilder param1, [MarshalAs(UnmanagedType.LPTStr)] StringBuilder param2, uint param3, IntPtr param4);

    /// Return Type: BOOL->int
    ///param0: LGRPID->DWORD->unsigned int
    ///param1: LCID->DWORD->unsigned int
    ///param2: LPWSTR->WCHAR*
    ///param3: LONG_PTR->int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int LANGGROUPLOCALE_ENUMPROC(uint param0, uint param1, [MarshalAs(UnmanagedType.LPTStr)] StringBuilder param2, IntPtr param3);

    /// Return Type: void
    ///dwErrorCode: DWORD->unsigned int
    ///dwNumberOfBytesTransfered: DWORD->unsigned int
    ///lpOverlapped: LPOVERLAPPED->_OVERLAPPED*
    public delegate void LPOVERLAPPED_COMPLETION_ROUTINE(uint dwErrorCode, uint dwNumberOfBytesTransfered, ref OVERLAPPED lpOverlapped);

    /// Return Type: BOOL->int
    ///hModule: HMODULE->HINSTANCE->HINSTANCE__*
    ///lpType: LPCWSTR->WCHAR*
    ///lpName: LPCWSTR->WCHAR*
    ///wLanguage: WORD->unsigned short
    ///lParam: LONG_PTR->int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int ENUMRESLANGPROC(
        [In] IntPtr hModule, [In] [MarshalAs(UnmanagedType.LPTStr)] string lpType, [In] [MarshalAs(UnmanagedType.LPTStr)] string lpName, ushort wLanguage,
        [In] IntPtr lParam);

    /// Return Type: BOOL->int
    ///CtrlType: DWORD->unsigned int
    public delegate int PHANDLER_ROUTINE(uint CtrlType);

    /// Return Type: DWORD->unsigned int
    ///TotalFileSize: LARGE_INTEGER->_LARGE_INTEGER
    ///TotalBytesTransferred: LARGE_INTEGER->_LARGE_INTEGER
    ///StreamSize: LARGE_INTEGER->_LARGE_INTEGER
    ///StreamBytesTransferred: LARGE_INTEGER->_LARGE_INTEGER
    ///dwStreamNumber: DWORD->unsigned int
    ///dwCallbackReason: DWORD->unsigned int
    ///hSourceFile: HANDLE->void*
    ///hDestinationFile: HANDLE->void*
    ///lpData: LPVOID->void*
    public delegate uint LPPROGRESS_ROUTINE(
        LARGE_INTEGER TotalFileSize, LARGE_INTEGER TotalBytesTransferred, LARGE_INTEGER StreamSize, LARGE_INTEGER StreamBytesTransferred, uint dwStreamNumber,
        uint dwCallbackReason, [In] IntPtr hSourceFile, [In] IntPtr hDestinationFile, [In] IntPtr lpData);

    /// Return Type: BOOL->int
    ///param0: LPWSTR->WCHAR*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int CODEPAGE_ENUMPROC([MarshalAs(UnmanagedType.LPTStr)] StringBuilder param0);

    /// Return Type: BOOL->int
    ///param0: LPWSTR->WCHAR*
    ///param1: CALID->DWORD->unsigned int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int CALINFO_ENUMPROCEX([MarshalAs(UnmanagedType.LPTStr)] StringBuilder param0, uint param1);

    /// Return Type: BOOL->int
    ///param0: LPWSTR->WCHAR*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int LOCALE_ENUMPROC([MarshalAs(UnmanagedType.LPTStr)] StringBuilder param0);

    /// Return Type: BOOL->int
    ///hModule: HMODULE->HINSTANCE->HINSTANCE__*
    ///lpType: LPWSTR->WCHAR*
    ///lParam: LONG_PTR->int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int ENUMRESTYPEPROC([In] IntPtr hModule, [In] [MarshalAs(UnmanagedType.LPTStr)] string lpType, [In] IntPtr lParam);

    /// Return Type: BOOL->int
    ///hModule: HMODULE->HINSTANCE->HINSTANCE__*
    ///lpType: LPCWSTR->WCHAR*
    ///lpName: LPWSTR->WCHAR*
    ///lParam: LONG_PTR->int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int ENUMRESNAMEPROC(
        [In] IntPtr hModule, [In] [MarshalAs(UnmanagedType.LPTStr)] string lpType, [In] [MarshalAs(UnmanagedType.LPTStr)] string lpName, [In] IntPtr lParam);

    /// Return Type: BOOL->int
    ///param0: LPWSTR->WCHAR*
    ///param1: CALID->DWORD->unsigned int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int DATEFMT_ENUMPROCEX([MarshalAs(UnmanagedType.LPTStr)] StringBuilder param0, uint param1);

    /// Return Type: BOOL->int
    ///param0: LPWSTR->WCHAR*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int CALINFO_ENUMPROC([MarshalAs(UnmanagedType.LPTStr)] StringBuilder param0);

    /// Return Type: void
    ///lpArgToCompletionRoutine: LPVOID->void*
    ///dwTimerLowValue: DWORD->unsigned int
    ///dwTimerHighValue: DWORD->unsigned int
    public delegate void PTIMERAPCROUTINE([In] IntPtr lpArgToCompletionRoutine, uint dwTimerLowValue, uint dwTimerHighValue);

    /// Return Type: BOOL->int
    ///param0: LPWSTR->WCHAR*
    ///param1: LONG_PTR->int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int UILANGUAGE_ENUMPROC([MarshalAs(UnmanagedType.LPTStr)] StringBuilder param0, IntPtr param1);

    /// Return Type: BOOL->int
    ///param0: LPWSTR->WCHAR*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int TIMEFMT_ENUMPROC([MarshalAs(UnmanagedType.LPTStr)] StringBuilder param0);

    /// Return Type: BOOL->int
    ///param0: LPWSTR->WCHAR*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int DATEFMT_ENUMPROC([MarshalAs(UnmanagedType.LPTStr)] StringBuilder param0);

    /// Return Type: BOOL->int
    ///param0: GEOID->LONG->int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int GEO_ENUMPROC(int param0);

    /// Return Type: void
    ///dwParam: ULONG_PTR->unsigned int
    public delegate void PAPCFUNC(uint dwParam);

    /// Return Type: LONG->int
    ///ExceptionInfo: _EXCEPTION_POINTERS*
    public delegate int PTOP_LEVEL_EXCEPTION_FILTER([In] ref EXCEPTION_POINTERS ExceptionInfo);

    public class Kernel32
    {
        /// Return Type: BOOL->int
        ///lpCriticalSection: LPCRITICAL_SECTION->PRTL_CRITICAL_SECTION->_RTL_CRITICAL_SECTION*
        ///dwSpinCount: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "InitializeCriticalSectionAndSpinCount")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool InitializeCriticalSectionAndSpinCount([Out] out RTL_CRITICAL_SECTION lpCriticalSection, uint dwSpinCount);

        /// Return Type: BOOL->int
        ///lpszVolumeMountPoint: LPCWSTR->WCHAR*
        ///lpszVolumeName: LPWSTR->WCHAR*
        ///cchBufferLength: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetVolumeNameForVolumeMountPoint")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetVolumeNameForVolumeMountPoint(
            [In] [MarshalAs(UnmanagedType.LPTStr)] string lpszVolumeMountPoint, [Out] [MarshalAs(UnmanagedType.LPTStr)] StringBuilder lpszVolumeName,
            uint cchBufferLength);

        /// Return Type: BOOL->int
        ///lpszVolumeName: LPCWSTR->WCHAR*
        ///lpszVolumePathNames: LPWCH->WCHAR*
        ///cchBufferLength: DWORD->unsigned int
        ///lpcchReturnLength: PDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "GetVolumePathNamesForVolumeName")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetVolumePathNamesForVolumeName(
            [In] [MarshalAs(UnmanagedType.LPTStr)] string lpszVolumeName, [Out] [MarshalAs(UnmanagedType.LPTStr)] StringBuilder lpszVolumePathNames,
            uint cchBufferLength, [Out] out uint lpcchReturnLength);

        /// Return Type: HANDLE->void*
        ///NotificationType: MEMORY_RESOURCE_NOTIFICATION_TYPE->_MEMORY_RESOURCE_NOTIFICATION_TYPE
        [DllImport("kernel32.dll", EntryPoint = "CreateMemoryResourceNotification")]
        public static extern IntPtr CreateMemoryResourceNotification(MEMORY_RESOURCE_NOTIFICATION_TYPE NotificationType);

        /// Return Type: BOOL->int
        ///lpTimeZoneInformation: LPTIME_ZONE_INFORMATION->_TIME_ZONE_INFORMATION*
        ///lpLocalTime: LPSYSTEMTIME->_SYSTEMTIME*
        ///lpUniversalTime: LPSYSTEMTIME->_SYSTEMTIME*
        [DllImport("kernel32.dll", EntryPoint = "TzSpecificLocalTimeToSystemTime")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool TzSpecificLocalTimeToSystemTime(
            [In] IntPtr lpTimeZoneInformation, [In] ref SYSTEMTIME lpLocalTime, [Out] out SYSTEMTIME lpUniversalTime);

        /// Return Type: BOOL->int
        ///lpTimeZoneInformation: LPTIME_ZONE_INFORMATION->_TIME_ZONE_INFORMATION*
        ///lpUniversalTime: LPSYSTEMTIME->_SYSTEMTIME*
        ///lpLocalTime: LPSYSTEMTIME->_SYSTEMTIME*
        [DllImport("kernel32.dll", EntryPoint = "SystemTimeToTzSpecificLocalTime")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SystemTimeToTzSpecificLocalTime(
            [In] IntPtr lpTimeZoneInformation, [In] ref SYSTEMTIME lpUniversalTime, [Out] out SYSTEMTIME lpLocalTime);

        /// Return Type: BOOL->int
        ///lpName: LPCWSTR->WCHAR*
        ///lpGuid: LPCWSTR->WCHAR*
        ///pValue: PVOID->void*
        ///nSize: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "SetFirmwareEnvironmentVariable")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetFirmwareEnvironmentVariable(
            [In] [MarshalAs(UnmanagedType.LPTStr)] string lpName, [In] [MarshalAs(UnmanagedType.LPTStr)] string lpGuid, [In] IntPtr pValue, uint nSize);

        /// Return Type: BOOL->int
        ///ResourceNotificationHandle: HANDLE->void*
        ///ResourceState: PBOOL->BOOL*
        [DllImport("kernel32.dll", EntryPoint = "QueryMemoryResourceNotification")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool QueryMemoryResourceNotification([In] IntPtr ResourceNotificationHandle, [Out] out int ResourceState);

        /// Return Type: DWORD->unsigned int
        ///lpName: LPCWSTR->WCHAR*
        ///lpGuid: LPCWSTR->WCHAR*
        ///pBuffer: PVOID->void*
        ///nSize: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetFirmwareEnvironmentVariable")]
        public static extern uint GetFirmwareEnvironmentVariable(
            [In] [MarshalAs(UnmanagedType.LPTStr)] string lpName, [In] [MarshalAs(UnmanagedType.LPTStr)] string lpGuid, IntPtr pBuffer, uint nSize);

        /// Return Type: ULONG->unsigned int
        ///Handle: PVOID->void*
        [DllImport("kernel32.dll", EntryPoint = "RemoveVectoredExceptionHandler")]
        public static extern uint RemoveVectoredExceptionHandler([In] IntPtr Handle);

        /// Return Type: DWORD->unsigned int
        ///lpszReturnBuffer: LPWSTR->WCHAR*
        ///nSize: DWORD->unsigned int
        ///lpFileName: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetPrivateProfileSectionNames")]
        public static extern uint GetPrivateProfileSectionNames(
            [Out] [MarshalAs(UnmanagedType.LPTStr)] StringBuilder lpszReturnBuffer, uint nSize, [In] [MarshalAs(UnmanagedType.LPTStr)] string lpFileName);

        /// Return Type: BOOL->int
        ///lpNumberOfMouseButtons: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "GetNumberOfConsoleMouseButtons")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetNumberOfConsoleMouseButtons(ref uint lpNumberOfMouseButtons);

        /// Return Type: HANDLE->void*
        ///hObject: HANDLE->void*
        ///Callback: WAITORTIMERCALLBACK->WAITORTIMERCALLBACKFUNC
        ///Context: PVOID->void*
        ///dwMilliseconds: ULONG->unsigned int
        ///dwFlags: ULONG->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "RegisterWaitForSingleObjectEx")]
        public static extern IntPtr RegisterWaitForSingleObjectEx(
            [In] IntPtr hObject, WAITORTIMERCALLBACKFUNC Callback, [In] IntPtr Context, uint dwMilliseconds, WT dwFlags);

        /// Return Type: BOOL->int
        ///hConsoleInput: HANDLE->void*
        ///lpNumberOfEvents: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "GetNumberOfConsoleInputEvents")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetNumberOfConsoleInputEvents(IntPtr hConsoleInput, ref uint lpNumberOfEvents);

        /// Return Type: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "WTSGetActiveConsoleSessionId")]
        public static extern uint WTSGetActiveConsoleSessionId();

        /// Return Type: BOOL->int
        ///hConsoleOutput: HANDLE->void*
        ///lpCharacter: LPCWSTR->WCHAR*
        ///nLength: DWORD->unsigned int
        ///dwWriteCoord: COORD->_COORD
        ///lpNumberOfCharsWritten: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "WriteConsoleOutputCharacter")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WriteConsoleOutputCharacter(
            IntPtr hConsoleOutput, [In] [MarshalAs(UnmanagedType.LPTStr)] string lpCharacter, uint nLength, COORD dwWriteCoord, ref uint lpNumberOfCharsWritten);

        /// Return Type: BOOL->int
        ///dwLevel: DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "SetProcessShutdownParameters")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetProcessShutdownParameters(uint dwLevel, SHUTDOWN dwFlags);

        /// Return Type: BOOL->int
        ///hConsoleOutput: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "SetConsoleActiveScreenBuffer")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetConsoleActiveScreenBuffer(IntPtr hConsoleOutput);

        /// Return Type: BOOL->int
        ///lpdwLevel: LPDWORD->DWORD*
        ///lpdwFlags: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "GetProcessShutdownParameters")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetProcessShutdownParameters([Out] out uint lpdwLevel, [Out] out SHUTDOWN lpdwFlags);

        /// Return Type: HANDLE->void*
        ///lpPathName: LPCWSTR->WCHAR*
        ///bWatchSubtree: BOOL->int
        ///dwNotifyFilter: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "FindFirstChangeNotification")]
        public static extern IntPtr FindFirstChangeNotification(
            [In] [MarshalAs(UnmanagedType.LPTStr)] string lpPathName, [MarshalAs(UnmanagedType.Bool)] bool bWatchSubtree, uint dwNotifyFilter);

        /// Return Type: BOOL->int
        ///lpAppName: LPCWSTR->WCHAR*
        ///lpString: LPCWSTR->WCHAR*
        ///lpFileName: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "WritePrivateProfileSection")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WritePrivateProfileSection(
            [In] [MarshalAs(UnmanagedType.LPTStr)] string lpAppName, [In] [MarshalAs(UnmanagedType.LPTStr)] string lpString,
            [In] [MarshalAs(UnmanagedType.LPTStr)] string lpFileName);

        /// Return Type: BOOL->int
        ///hConsoleOutput: HANDLE->void*
        ///lpAttribute: WORD*
        ///nLength: DWORD->unsigned int
        ///dwWriteCoord: COORD->_COORD
        ///lpNumberOfAttrsWritten: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "WriteConsoleOutputAttribute")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WriteConsoleOutputAttribute(
            IntPtr hConsoleOutput, ref CHARACTER_ATTRIBUTE[] lpAttribute, uint nLength, COORD dwWriteCoord, ref uint lpNumberOfAttrsWritten);

        /// Return Type: LPTOP_LEVEL_EXCEPTION_FILTER->PTOP_LEVEL_EXCEPTION_FILTER
        ///lpTopLevelExceptionFilter: LPTOP_LEVEL_EXCEPTION_FILTER->PTOP_LEVEL_EXCEPTION_FILTER
        [DllImport("kernel32.dll", EntryPoint = "SetUnhandledExceptionFilter")]
        public static extern PTOP_LEVEL_EXCEPTION_FILTER SetUnhandledExceptionFilter(PTOP_LEVEL_EXCEPTION_FILTER lpTopLevelExceptionFilter);

        /// Return Type: DWORD->unsigned int
        ///lpCriticalSection: LPCRITICAL_SECTION->PRTL_CRITICAL_SECTION->_RTL_CRITICAL_SECTION*
        ///dwSpinCount: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "SetCriticalSectionSpinCount")]
        public static extern uint SetCriticalSectionSpinCount(ref RTL_CRITICAL_SECTION lpCriticalSection, uint dwSpinCount);

        /// Return Type: BOOL->int
        ///phNewWaitObject: PHANDLE->HANDLE*
        ///hObject: HANDLE->void*
        ///Callback: WAITORTIMERCALLBACK->WAITORTIMERCALLBACKFUNC
        ///Context: PVOID->void*
        ///dwMilliseconds: ULONG->unsigned int
        ///dwFlags: ULONG->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "RegisterWaitForSingleObject")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool RegisterWaitForSingleObject(
            out IntPtr phNewWaitObject, [In] IntPtr hObject, WAITORTIMERCALLBACKFUNC Callback, [In] IntPtr Context, uint dwMilliseconds, WT dwFlags);

        /// Return Type: BOOL->int
        ///hConsoleOutput: HANDLE->void*
        ///lpCharacter: LPWSTR->WCHAR*
        ///nLength: DWORD->unsigned int
        ///dwReadCoord: COORD->_COORD
        ///lpNumberOfCharsRead: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "ReadConsoleOutputCharacter")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ReadConsoleOutputCharacter(
            IntPtr hConsoleOutput, [MarshalAs(UnmanagedType.LPTStr)] StringBuilder lpCharacter, uint nLength, COORD dwReadCoord, ref uint lpNumberOfCharsRead);

        /// Return Type: BOOL->int
        ///VirtualAddresses: PVOID*
        ///NumberOfPages: ULONG_PTR->unsigned int
        ///PageArray: PULONG_PTR->unsigned int*
        [DllImport("kernel32.dll", EntryPoint = "MapUserPhysicalPagesScatter")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool MapUserPhysicalPagesScatter(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.SysInt, SizeParamIndex = 1)] IntPtr[] VirtualAddresses, uint NumberOfPages,
            [In] IntPtr PageArray);

        /// Return Type: COORD->_COORD
        ///hConsoleOutput: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "GetLargestConsoleWindowSize")]
        public static extern COORD GetLargestConsoleWindowSize(IntPtr hConsoleOutput);

        /// Return Type: BOOL->int
        ///hChangeHandle: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "FindCloseChangeNotification")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FindCloseChangeNotification([In] IntPtr hChangeHandle);

        /// Return Type: BOOL->int
        ///hConsoleOutput: HANDLE->void*
        ///cCharacter: WCHAR->wchar_t->unsigned short
        ///nLength: DWORD->unsigned int
        ///dwWriteCoord: COORD->_COORD
        ///lpNumberOfCharsWritten: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "FillConsoleOutputCharacter")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FillConsoleOutputCharacter(
            IntPtr hConsoleOutput, char cCharacter, uint nLength, COORD dwWriteCoord, ref uint lpNumberOfCharsWritten);

        /// Return Type: PVOID->void*
        ///First: ULONG->unsigned int
        ///Handler: PVECTORED_EXCEPTION_HANDLER
        [DllImport("kernel32.dll", EntryPoint = "AddVectoredExceptionHandler")]
        public static extern IntPtr AddVectoredExceptionHandler(uint First, PVECTORED_EXCEPTION_HANDLER Handler);

        /// Return Type: BOOL->int
        ///lpszSection: LPCWSTR->WCHAR*
        ///lpszKey: LPCWSTR->WCHAR*
        ///lpStruct: LPVOID->void*
        ///uSizeStruct: UINT->unsigned int
        ///szFile: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "WritePrivateProfileStruct")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WritePrivateProfileStruct(
            [In] [MarshalAs(UnmanagedType.LPTStr)] string lpszSection, [In] [MarshalAs(UnmanagedType.LPTStr)] string lpszKey, [In] IntPtr lpStruct,
            uint uSizeStruct, [In] [MarshalAs(UnmanagedType.LPTStr)] string szFile);

        /// Return Type: BOOL->int
        ///lpAppName: LPCWSTR->WCHAR*
        ///lpKeyName: LPCWSTR->WCHAR*
        ///lpString: LPCWSTR->WCHAR*
        ///lpFileName: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "WritePrivateProfileString")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WritePrivateProfileString(
            [In] [MarshalAs(UnmanagedType.LPTStr)] string lpAppName, [In] [MarshalAs(UnmanagedType.LPTStr)] string lpKeyName,
            [In] [MarshalAs(UnmanagedType.LPTStr)] string lpString, [In] [MarshalAs(UnmanagedType.LPTStr)] string lpFileName);

        /// Return Type: BOOL->int
        ///hMsgIndicator: HANDLE->void*
        ///ulMsgCount: ULONG->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "SetMessageWaitingIndicator")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetMessageWaitingIndicator([In] IntPtr hMsgIndicator, uint ulMsgCount);

        /// Return Type: BOOL->int
        ///hConsoleOutput: HANDLE->void*
        ///dwSize: COORD->_COORD
        [DllImport("kernel32.dll", EntryPoint = "SetConsoleScreenBufferSize")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetConsoleScreenBufferSize(IntPtr hConsoleOutput, COORD dwSize);

        /// Return Type: BOOL->int
        ///hConsoleOutput: HANDLE->void*
        ///lpScrollRectangle: SMALL_RECT*
        ///lpClipRectangle: SMALL_RECT*
        ///dwDestinationOrigin: COORD->_COORD
        ///lpFill: CHAR_INFO*
        [DllImport("kernel32.dll", EntryPoint = "ScrollConsoleScreenBuffer")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ScrollConsoleScreenBuffer(
            IntPtr hConsoleOutput, ref SMALL_RECT lpScrollRectangle, ref SMALL_RECT lpClipRectangle, COORD dwDestinationOrigin, ref CHAR_INFO lpFill);

        /// Return Type: BOOL->int
        ///hConsoleOutput: HANDLE->void*
        ///lpAttribute: LPWORD->WORD*
        ///nLength: DWORD->unsigned int
        ///dwReadCoord: COORD->_COORD
        ///lpNumberOfAttrsRead: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "ReadConsoleOutputAttribute")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ReadConsoleOutputAttribute(
            IntPtr hConsoleOutput, ref CHARACTER_ATTRIBUTE[] lpAttribute, uint nLength, COORD dwReadCoord, ref uint lpNumberOfAttrsRead);

        /// Return Type: BOOL->int
        ///CompletionPort: HANDLE->void*
        ///dwNumberOfBytesTransferred: DWORD->unsigned int
        ///dwCompletionKey: ULONG_PTR->unsigned int
        ///lpOverlapped: LPOVERLAPPED->_OVERLAPPED*
        [DllImport("kernel32.dll", EntryPoint = "PostQueuedCompletionStatus")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PostQueuedCompletionStatus(
            [In] IntPtr CompletionPort, uint dwNumberOfBytesTransferred, uint dwCompletionKey, [In] IntPtr lpOverlapped);

        /// Return Type: LONG->int
        ///Destination: LONG*
        ///Exchange: LONG->int
        ///Comperand: LONG->int
        [DllImport("kernel32.dll", EntryPoint = "InterlockedCompareExchange")]
        public static extern int InterlockedCompareExchange(ref int Destination, int Exchange, int Comperand);

        /// Return Type: UINT->unsigned int
        ///lpBuffer: LPWSTR->WCHAR*
        ///uSize: UINT->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetSystemWindowsDirectory")]
        public static extern uint GetSystemWindowsDirectory([Out] [MarshalAs(UnmanagedType.LPTStr)] StringBuilder lpBuffer, uint uSize);

        /// Return Type: LANGID->WORD->unsigned short
        [DllImport("kernel32.dll", EntryPoint = "GetSystemDefaultUILanguage")]
        public static extern ushort GetSystemDefaultUILanguage();

        /// Return Type: BOOL->int
        ///Node: UCHAR->unsigned char
        ///AvailableBytes: PULONGLONG->ULONGLONG*
        [DllImport("kernel32.dll", EntryPoint = "GetNumaAvailableMemoryNode")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetNumaAvailableMemoryNode(byte Node, [Out] out ulong AvailableBytes);

        /// Return Type: BOOL->int
        ///hFile: HANDLE->void*
        ///lpFileInformation: LPBY_HANDLE_FILE_INFORMATION->_BY_HANDLE_FILE_INFORMATION*
        [DllImport("kernel32.dll", EntryPoint = "GetFileInformationByHandle")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetFileInformationByHandle([In] IntPtr hFile, [Out] out BY_HANDLE_FILE_INFORMATION lpFileInformation);

        /// Return Type: BOOL->int
        ///hConsoleOutput: HANDLE->void*
        ///lpConsoleScreenBufferInfo: PCONSOLE_SCREEN_BUFFER_INFO->_CONSOLE_SCREEN_BUFFER_INFO*
        [DllImport("kernel32.dll", EntryPoint = "GetConsoleScreenBufferInfo")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetConsoleScreenBufferInfo(IntPtr hConsoleOutput, ref CONSOLE_SCREEN_BUFFER_INFO lpConsoleScreenBufferInfo);

		[DllImport("kernel32.dll", EntryPoint = "GetConsoleScreenBufferInfoEx")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetConsoleScreenBufferInfoEx(IntPtr hConsoleOutput, ref CONSOLE_SCREEN_BUFFER_INFOEX lpConsoleScreenBufferInfoEx);

        /// Return Type: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetConsoleAliasExesLength")]
        public static extern uint GetConsoleAliasExesLength();

        /// Return Type: BOOL->int
        ///hChangeHandle: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "FindNextChangeNotification")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FindNextChangeNotification([In] IntPtr hChangeHandle);

        /// Return Type: HANDLE->void*
        ///lpszRootPathName: LPCWSTR->WCHAR*
        ///lpszVolumeMountPoint: LPWSTR->WCHAR*
        ///cchBufferLength: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "FindFirstVolumeMountPoint")]
        public static extern IntPtr FindFirstVolumeMountPoint(
            [In] [MarshalAs(UnmanagedType.LPTStr)] string lpszRootPathName, [Out] [MarshalAs(UnmanagedType.LPTStr)] StringBuilder lpszVolumeMountPoint,
            uint cchBufferLength);

        /// Return Type: BOOL->int
        ///hConsoleOutput: HANDLE->void*
        ///wAttribute: WORD->unsigned short
        ///nLength: DWORD->unsigned int
        ///dwWriteCoord: COORD->_COORD
        ///lpNumberOfAttrsWritten: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "FillConsoleOutputAttribute")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FillConsoleOutputAttribute(
            IntPtr hConsoleOutput, CHARACTER_ATTRIBUTE wAttribute, uint nLength, COORD dwWriteCoord, ref uint lpNumberOfAttrsWritten);

        /// Return Type: BOOL->int
        ///Hostname: LPCWSTR->WCHAR*
        ///ComputerName: LPWSTR->WCHAR*
        ///nSize: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "DnsHostnameToComputerName")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DnsHostnameToComputerName(
            [In] [MarshalAs(UnmanagedType.LPTStr)] string Hostname, [Out] [MarshalAs(UnmanagedType.LPTStr)] StringBuilder ComputerName, ref uint nSize);

        /// Return Type: BOOL->int
        ///hProcess: HANDLE->void*
        ///pbDebuggerPresent: PBOOL->BOOL*
        [DllImport("kernel32.dll", EntryPoint = "CheckRemoteDebuggerPresent")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CheckRemoteDebuggerPresent([In] IntPtr hProcess, [Out] out int pbDebuggerPresent);

        /// Return Type: BOOL->int
        ///lpFrequency: LARGE_INTEGER*
        [DllImport("kernel32.dll", EntryPoint = "QueryPerformanceFrequency")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool QueryPerformanceFrequency([Out] out LARGE_INTEGER lpFrequency);

        /// Return Type: BOOL->int
        ///hJob: HANDLE->void*
        ///JobObjectInformationClass: JOBOBJECTINFOCLASS->_JOBOBJECTINFOCLASS
        ///lpJobObjectInformation: LPVOID->void*
        ///cbJobObjectInformationLength: DWORD->unsigned int
        ///lpReturnLength: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "QueryInformationJobObject")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool QueryInformationJobObject(
            [In] IntPtr hJob, JOBOBJECTINFOCLASS JobObjectInformationClass, IntPtr lpJobObjectInformation, uint cbJobObjectInformationLength,
            IntPtr lpReturnLength);

        /// Return Type: BOOL->int
        ///ProcessorFeature: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "IsProcessorFeaturePresent")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsProcessorFeaturePresent(uint ProcessorFeature);

        /// Return Type: PSINGLE_LIST_ENTRY->_SINGLE_LIST_ENTRY*
        ///ListHead: PSLIST_HEADER->_SLIST_HEADER*
        ///ListEntry: PSINGLE_LIST_ENTRY->_SINGLE_LIST_ENTRY*
        [DllImport("kernel32.dll", EntryPoint = "InterlockedPushEntrySList")]
        public static extern IntPtr InterlockedPushEntrySList(ref SLIST_HEADER ListHead, ref SINGLE_LIST_ENTRY ListEntry);

        /// Return Type: void
        ///lpCriticalSection: LPCRITICAL_SECTION->PRTL_CRITICAL_SECTION->_RTL_CRITICAL_SECTION*
        [DllImport("kernel32.dll", EntryPoint = "InitializeCriticalSection")]
        public static extern void InitializeCriticalSection([Out] out RTL_CRITICAL_SECTION lpCriticalSection);

        /// Return Type: BOOL->int
        ///CompletionPort: HANDLE->void*
        ///lpNumberOfBytesTransferred: LPDWORD->DWORD*
        ///lpCompletionKey: PULONG_PTR->unsigned int*
        ///lpOverlapped: LPOVERLAPPED*
        ///dwMilliseconds: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetQueuedCompletionStatus")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetQueuedCompletionStatus(
            [In] IntPtr CompletionPort, [Out] out uint lpNumberOfBytesTransferred, [Out] out uint lpCompletionKey, ref IntPtr lpOverlapped, uint dwMilliseconds);

        /// Return Type: DWORD->unsigned int
        ///lpAppName: LPCWSTR->WCHAR*
        ///lpReturnedString: LPWSTR->WCHAR*
        ///nSize: DWORD->unsigned int
        ///lpFileName: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetPrivateProfileSection")]
        public static extern uint GetPrivateProfileSection(
            [In] [MarshalAs(UnmanagedType.LPTStr)] string lpAppName, [Out] [MarshalAs(UnmanagedType.LPTStr)] StringBuilder lpReturnedString, uint nSize,
            [In] [MarshalAs(UnmanagedType.LPTStr)] string lpFileName);

        /// Return Type: BOOL->int
        ///hFindVolumeMountPoint: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "FindVolumeMountPointClose")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FindVolumeMountPointClose([In] IntPtr hFindVolumeMountPoint);

        /// Return Type: BOOL->int
        ///hFindVolumeMountPoint: HANDLE->void*
        ///lpszVolumeMountPoint: LPWSTR->WCHAR*
        ///cchBufferLength: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "FindNextVolumeMountPoint")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FindNextVolumeMountPoint(
            [In] IntPtr hFindVolumeMountPoint, [Out] [MarshalAs(UnmanagedType.LPTStr)] StringBuilder lpszVolumeMountPoint, uint cchBufferLength);

        /// Return Type: DWORD->unsigned int
        ///lpSrc: LPCWSTR->WCHAR*
        ///lpDst: LPWSTR->WCHAR*
        ///nSize: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "ExpandEnvironmentStrings")]
        public static extern uint ExpandEnvironmentStrings(
            [In] [MarshalAs(UnmanagedType.LPTStr)] string lpSrc, [Out] [MarshalAs(UnmanagedType.LPTStr)] StringBuilder lpDst, uint nSize);

        /// Return Type: BOOL->int
        ///lpLanguageGroupEnumProc: LANGUAGEGROUP_ENUMPROCW
        ///dwFlags: DWORD->unsigned int
        ///lParam: LONG_PTR->int
        [DllImport("kernel32.dll", EntryPoint = "EnumSystemLanguageGroups")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumSystemLanguageGroups(
            LANGUAGEGROUP_ENUMPROC lpLanguageGroupEnumProc, LGRPID dwFlags, [MarshalAs(UnmanagedType.SysInt)] int lParam);

        /// Return Type: BOOL->int
        ///lpLangGroupLocaleEnumProc: LANGGROUPLOCALE_ENUMPROCW
        ///LanguageGroup: LGRPID->DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        ///lParam: LONG_PTR->int
        [DllImport("kernel32.dll", EntryPoint = "EnumLanguageGroupLocales")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumLanguageGroupLocales(
            LANGGROUPLOCALE_ENUMPROC lpLangGroupLocaleEnumProc, uint LanguageGroup, uint dwFlags, [MarshalAs(UnmanagedType.SysInt)] int lParam);

        /// Return Type: BOOL->int
        ///hLibModule: HMODULE->HINSTANCE->HINSTANCE__*
        [DllImport("kernel32.dll", EntryPoint = "DisableThreadLibraryCalls")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DisableThreadLibraryCalls([In] IntPtr hLibModule);

        /// Return Type: BOOL->int
        ///KillOnExit: BOOL->int
        [DllImport("kernel32.dll", EntryPoint = "DebugSetProcessKillOnExit")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DebugSetProcessKillOnExit([MarshalAs(UnmanagedType.Bool)] bool KillOnExit);

        /// Return Type: HANDLE->void*
        ///dwDesiredAccess: DWORD->unsigned int
        ///dwShareMode: DWORD->unsigned int
        ///lpSecurityAttributes: SECURITY_ATTRIBUTES*
        ///dwFlags: DWORD->unsigned int
        ///lpScreenBufferData: LPVOID->void*
        [DllImport("kernel32.dll", EntryPoint = "CreateConsoleScreenBuffer")]
        public static extern IntPtr CreateConsoleScreenBuffer(
            uint dwDesiredAccess, uint dwShareMode, ref SECURITY_ATTRIBUTES lpSecurityAttributes, CONSOLE_TEXTMODE dwFlags, IntPtr lpScreenBufferData);

        /// Return Type: BOOL->int
        ///hDevice: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "CancelDeviceWakeupRequest")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CancelDeviceWakeupRequest([In] IntPtr hDevice);

        /// Return Type: BOOL->int
        ///hProcess: HANDLE->void*
        ///NumberOfPages: PULONG_PTR->unsigned int*
        ///PageArray: PULONG_PTR->unsigned int*
        [DllImport("kernel32.dll", EntryPoint = "AllocateUserPhysicalPages")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AllocateUserPhysicalPages([In] IntPtr hProcess, ref uint NumberOfPages, IntPtr PageArray);

        /// Return Type: DWORD->unsigned int
        ///nCount: DWORD->unsigned int
        ///lpHandles: HANDLE*
        ///bWaitAll: BOOL->int
        ///dwMilliseconds: DWORD->unsigned int
        ///bAlertable: BOOL->int
        [DllImport("kernel32.dll", EntryPoint = "WaitForMultipleObjectsEx")]
        public static extern uint WaitForMultipleObjectsEx(
            uint nCount, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.SysInt, SizeParamIndex = 0)] IntPtr[] lpHandles,
            [MarshalAs(UnmanagedType.Bool)] bool bWaitAll, uint dwMilliseconds, [MarshalAs(UnmanagedType.Bool)] bool bAlertable);

        /// Return Type: LONG->int
        ///ExceptionInfo: _EXCEPTION_POINTERS*
        [DllImport("kernel32.dll", EntryPoint = "UnhandledExceptionFilter")]
        public static extern int UnhandledExceptionFilter([In] ref EXCEPTION_POINTERS ExceptionInfo);

        /// Return Type: BOOL->int
        ///hProcess: HANDLE->void*
        ///dwMinimumWorkingSetSize: SIZE_T->ULONG_PTR->unsigned int
        ///dwMaximumWorkingSetSize: SIZE_T->ULONG_PTR->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "SetProcessWorkingSetSize")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetProcessWorkingSetSize([In] IntPtr hProcess, uint dwMinimumWorkingSetSize, uint dwMaximumWorkingSetSize);

        /// Return Type: BOOL->int
        ///hConsoleOutput: HANDLE->void*
        ///dwCursorPosition: COORD->_COORD
        [DllImport("kernel32.dll", EntryPoint = "SetConsoleCursorPosition")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetConsoleCursorPosition(IntPtr hConsoleOutput, COORD dwCursorPosition);

        /// Return Type: PSINGLE_LIST_ENTRY->_SINGLE_LIST_ENTRY*
        ///ListHead: PSLIST_HEADER->_SLIST_HEADER*
        [DllImport("kernel32.dll", EntryPoint = "InterlockedPopEntrySList")]
        public static extern IntPtr InterlockedPopEntrySList(ref SLIST_HEADER ListHead);

        /// Return Type: LANGID->WORD->unsigned short
        [DllImport("kernel32.dll", EntryPoint = "GetUserDefaultUILanguage")]
        public static extern ushort GetUserDefaultUILanguage();

        /// Return Type: UINT->unsigned int
        ///lpBuffer: LPWSTR->WCHAR*
        ///uSize: UINT->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetSystemWow64Directory")]
        public static extern uint GetSystemWow64Directory([Out] [MarshalAs(UnmanagedType.LPTStr)] StringBuilder lpBuffer, uint uSize);

        /// Return Type: BOOL->int
        ///hProcess: HANDLE->void*
        ///lpMinimumWorkingSetSize: PSIZE_T->ULONG_PTR*
        ///lpMaximumWorkingSetSize: PSIZE_T->ULONG_PTR*
        [DllImport("kernel32.dll", EntryPoint = "GetProcessWorkingSetSize")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetProcessWorkingSetSize([In] IntPtr hProcess, [Out] out uint lpMinimumWorkingSetSize, [Out] out uint lpMaximumWorkingSetSize);

        /// Return Type: BOOL->int
        ///lpszSection: LPCWSTR->WCHAR*
        ///lpszKey: LPCWSTR->WCHAR*
        ///lpStruct: LPVOID->void*
        ///uSizeStruct: UINT->unsigned int
        ///szFile: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetPrivateProfileStruct")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetPrivateProfileStruct(
            [In] [MarshalAs(UnmanagedType.LPTStr)] string lpszSection, [In] [MarshalAs(UnmanagedType.LPTStr)] string lpszKey, IntPtr lpStruct, uint uSizeStruct,
            [In] [MarshalAs(UnmanagedType.LPTStr)] string szFile);

        /// Return Type: DWORD->unsigned int
        ///lpAppName: LPCWSTR->WCHAR*
        ///lpKeyName: LPCWSTR->WCHAR*
        ///lpDefault: LPCWSTR->WCHAR*
        ///lpReturnedString: LPWSTR->WCHAR*
        ///nSize: DWORD->unsigned int
        ///lpFileName: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetPrivateProfileString")]
        public static extern uint GetPrivateProfileString(
            [In] [MarshalAs(UnmanagedType.LPTStr)] string lpAppName, [In] [MarshalAs(UnmanagedType.LPTStr)] string lpKeyName,
            [In] [MarshalAs(UnmanagedType.LPTStr)] string lpDefault, [Out] [MarshalAs(UnmanagedType.LPTStr)] StringBuilder lpReturnedString, uint nSize,
            [In] [MarshalAs(UnmanagedType.LPTStr)] string lpFileName);

        /// Return Type: BOOL->int
        ///Node: UCHAR->unsigned char
        ///ProcessorMask: PULONGLONG->ULONGLONG*
        [DllImport("kernel32.dll", EntryPoint = "GetNumaNodeProcessorMask")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetNumaNodeProcessorMask(byte Node, [Out] out ulong ProcessorMask);

        /// Return Type: BOOL->int
        ///HighestNodeNumber: PULONG->ULONG*
        [DllImport("kernel32.dll", EntryPoint = "GetNumaHighestNodeNumber")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetNumaHighestNodeNumber([Out] out uint HighestNodeNumber);

        /// Return Type: BOOL->int
        ///hNamedPipe: HANDLE->void*
        ///lpState: LPDWORD->DWORD*
        ///lpCurInstances: LPDWORD->DWORD*
        ///lpMaxCollectionCount: LPDWORD->DWORD*
        ///lpCollectDataTimeout: LPDWORD->DWORD*
        ///lpUserName: LPWSTR->WCHAR*
        ///nMaxUserNameSize: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetNamedPipeHandleState")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetNamedPipeHandleState(
            [In] IntPtr hNamedPipe, IntPtr lpState, IntPtr lpCurInstances, IntPtr lpMaxCollectionCount, IntPtr lpCollectDataTimeout,
            [Out] [MarshalAs(UnmanagedType.LPTStr)] StringBuilder lpUserName, uint nMaxUserNameSize);

        /// Return Type: DWORD->unsigned int
        ///ExeName: LPWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetConsoleAliasesLength")]
        public static extern uint GetConsoleAliasesLength([MarshalAs(UnmanagedType.LPTStr)] StringBuilder ExeName);

        /// Return Type: BOOL->int
        ///dwCtrlEvent: DWORD->unsigned int
        ///dwProcessGroupId: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GenerateConsoleCtrlEvent")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GenerateConsoleCtrlEvent(uint dwCtrlEvent, uint dwProcessGroupId);

        /// Return Type: void
        ///hLibModule: HMODULE->HINSTANCE->HINSTANCE__*
        ///dwExitCode: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "FreeLibraryAndExitThread")]
        public static extern void FreeLibraryAndExitThread([In] IntPtr hLibModule, uint dwExitCode);

        /// Return Type: BOOL->int
        ///dwFlags: DWORD->unsigned int
        ///lpExtensionGuid: GUID*
        ///ulSectionId: ULONG->unsigned int
        ///lpStringToFind: LPCWSTR->WCHAR*
        ///ReturnedData: PACTCTX_SECTION_KEYED_DATA->tagACTCTX_SECTION_KEYED_DATA*
        [DllImport("kernel32.dll", EntryPoint = "FindActCtxSectionString")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FindActCtxSectionString(
			FIND_ACTCTX_SECTION dwFlags, IntPtr lpExtensionGuid, uint ulSectionId, [In] [MarshalAs(UnmanagedType.LPTStr)] string lpStringToFind,
            [Out] out ACTCTX_SECTION_KEYED_DATA ReturnedData);

        /// Return Type: BOOL->int
        ///lpDef: LPCWSTR->WCHAR*
        ///lpDCB: LPDCB->_DCB*
        ///lpCommTimeouts: LPCOMMTIMEOUTS->_COMMTIMEOUTS*
        [DllImport("kernel32.dll", EntryPoint = "BuildCommDCBAndTimeouts")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool BuildCommDCBAndTimeouts(
            [In] [MarshalAs(UnmanagedType.LPTStr)] string lpDef, [Out] out DCB lpDCB, [Out] out COMMTIMEOUTS lpCommTimeouts);

        /// Return Type: BOOL->int
        ///FileHandle: HANDLE->void*
        ///Function: LPOVERLAPPED_COMPLETION_ROUTINE
        ///Flags: ULONG->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "BindIoCompletionCallback")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool BindIoCompletionCallback([In] IntPtr FileHandle, LPOVERLAPPED_COMPLETION_ROUTINE Function, uint Flags);

        /// Return Type: BOOL->int
        ///hJob: HANDLE->void*
        ///hProcess: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "AssignProcessToJobObject")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AssignProcessToJobObject([In] IntPtr hJob, [In] IntPtr hProcess);

        /// Return Type: BOOL->int
        ///lpCriticalSection: LPCRITICAL_SECTION->PRTL_CRITICAL_SECTION->_RTL_CRITICAL_SECTION*
        [DllImport("kernel32.dll", EntryPoint = "TryEnterCriticalSection")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool TryEnterCriticalSection(ref RTL_CRITICAL_SECTION lpCriticalSection);

        /// Return Type: DWORD->unsigned int
        ///hThread: HANDLE->void*
        ///dwIdealProcessor: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "SetThreadIdealProcessor")]
        public static extern uint SetThreadIdealProcessor([In] IntPtr hThread, uint dwIdealProcessor);

        /// Return Type: EXECUTION_STATE->DWORD->unsigned int
        ///esFlags: EXECUTION_STATE->DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "SetThreadExecutionState")]
        public static extern uint SetThreadExecutionState(ES esFlags);

        /// Return Type: BOOL->int
        ///dwTimeAdjustment: DWORD->unsigned int
        ///bTimeAdjustmentDisabled: BOOL->int
        [DllImport("kernel32.dll", EntryPoint = "SetSystemTimeAdjustment")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetSystemTimeAdjustment(uint dwTimeAdjustment, [MarshalAs(UnmanagedType.Bool)] bool bTimeAdjustmentDisabled);

        /// Return Type: BOOL->int
        ///hProcess: HANDLE->void*
        ///bDisablePriorityBoost: BOOL->int
        [DllImport("kernel32.dll", EntryPoint = "SetProcessPriorityBoost")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetProcessPriorityBoost([In] IntPtr hProcess, [MarshalAs(UnmanagedType.Bool)] bool bDisablePriorityBoost);

        /// Return Type: BOOL->int
        ///hNamedPipe: HANDLE->void*
        ///lpMode: LPDWORD->DWORD*
        ///lpMaxCollectionCount: LPDWORD->DWORD*
        ///lpCollectDataTimeout: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "SetNamedPipeHandleState")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetNamedPipeHandleState(
            [In] IntPtr hNamedPipe, [In] IntPtr lpMode, [In] IntPtr lpMaxCollectionCount, [In] IntPtr lpCollectDataTimeout);

        /// Return Type: BOOL->int
        ///hJob: HANDLE->void*
        ///JobObjectInformationClass: JOBOBJECTINFOCLASS->_JOBOBJECTINFOCLASS
        ///lpJobObjectInformation: LPVOID->void*
        ///cbJobObjectInformationLength: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "SetInformationJobObject")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetInformationJobObject(
            [In] IntPtr hJob, JOBOBJECTINFOCLASS JobObjectInformationClass, [In] IntPtr lpJobObjectInformation, uint cbJobObjectInformationLength);

        /// Return Type: BOOL->int
        ///lpName: LPCWSTR->WCHAR*
        ///lpValue: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "SetEnvironmentVariable")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetEnvironmentVariable(
            [In] [MarshalAs(UnmanagedType.LPTStr)] string lpName, [In] [MarshalAs(UnmanagedType.LPTStr)] string lpValue);

        /// Return Type: BOOL->int
        ///hConsoleOutput: HANDLE->void*
        ///wAttributes: WORD->unsigned short
        [DllImport("kernel32.dll", EntryPoint = "SetConsoleTextAttribute")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetConsoleTextAttribute(IntPtr hConsoleOutput, CHARACTER_ATTRIBUTE wAttributes);

        /// Return Type: BOOL->int
        ///lpPerformanceCount: LARGE_INTEGER*
        [DllImport("kernel32.dll", EntryPoint = "QueryPerformanceCounter")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool QueryPerformanceCounter([Out] out LARGE_INTEGER lpPerformanceCount);

        /// Return Type: BOOL->int
        ///lpLocalFileTime: FILETIME*
        ///lpFileTime: LPFILETIME->_FILETIME*
        [DllImport("kernel32.dll", EntryPoint = "LocalFileTimeToFileTime")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool LocalFileTimeToFileTime([In] ref FILETIME lpLocalFileTime, [Out] out FILETIME lpFileTime);

        /// Return Type: BOOL->int
        [DllImport("kernel32.dll", EntryPoint = "IsSystemResumeAutomatic")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsSystemResumeAutomatic();

        /// Return Type: void
        ///lpSystemTimeAsFileTime: LPFILETIME->_FILETIME*
        [DllImport("kernel32.dll", EntryPoint = "GetSystemTimeAsFileTime")]
        public static extern void GetSystemTimeAsFileTime([Out] out FILETIME lpSystemTimeAsFileTime);

        /// Return Type: BOOL->int
        ///lpTimeAdjustment: PDWORD->DWORD*
        ///lpTimeIncrement: PDWORD->DWORD*
        ///lpTimeAdjustmentDisabled: PBOOL->BOOL*
        [DllImport("kernel32.dll", EntryPoint = "GetSystemTimeAdjustment")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetSystemTimeAdjustment(
            [Out] out uint lpTimeAdjustment, [Out] out uint lpTimeIncrement, [Out] out int lpTimeAdjustmentDisabled);

        /// Return Type: BOOL->int
        ///hProcess: HANDLE->void*
        ///pDisablePriorityBoost: PBOOL->BOOL*
        [DllImport("kernel32.dll", EntryPoint = "GetProcessPriorityBoost")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetProcessPriorityBoost([In] IntPtr hProcess, [Out] out int pDisablePriorityBoost);

        /// Return Type: DWORD->unsigned int
        ///nBufferLength: DWORD->unsigned int
        ///lpBuffer: LPWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetLogicalDriveStrings")]
        public static extern uint GetLogicalDriveStrings(uint nBufferLength, [Out] [MarshalAs(UnmanagedType.LPTStr)] StringBuilder lpBuffer);

        /// Return Type: DWORD->unsigned int
        ///lpName: LPCWSTR->WCHAR*
        ///lpBuffer: LPWSTR->WCHAR*
        ///nSize: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetEnvironmentVariable")]
        public static extern uint GetEnvironmentVariable(
            [In] [MarshalAs(UnmanagedType.LPTStr)] string lpName, [Out] [MarshalAs(UnmanagedType.LPTStr)] StringBuilder lpBuffer, uint nSize);

        /// Return Type: BOOL->int
        ///lpConsoleSelectionInfo: PCONSOLE_SELECTION_INFO->_CONSOLE_SELECTION_INFO*
        [DllImport("kernel32.dll", EntryPoint = "GetConsoleSelectionInfo")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetConsoleSelectionInfo(ref CONSOLE_SELECTION_INFO lpConsoleSelectionInfo);

        /// Return Type: BOOL->int
        ///param0: LPWCH->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "FreeEnvironmentStrings")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FreeEnvironmentStrings([In] [MarshalAs(UnmanagedType.LPTStr)] string param0);

        /// Return Type: BOOL->int
        ///hConsoleInput: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "FlushConsoleInputBuffer")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FlushConsoleInputBuffer(IntPtr hConsoleInput);

        /// Return Type: BOOL->int
        ///lpFileTime: FILETIME*
        ///lpLocalFileTime: LPFILETIME->_FILETIME*
        [DllImport("kernel32.dll", EntryPoint = "FileTimeToLocalFileTime")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FileTimeToLocalFileTime([In] ref FILETIME lpFileTime, [Out] out FILETIME lpLocalFileTime);

        /// Return Type: BOOL->int
        ///lpszVolumeMountPoint: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "DeleteVolumeMountPoint")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DeleteVolumeMountPoint([In] [MarshalAs(UnmanagedType.LPTStr)] string lpszVolumeMountPoint);

        /// Return Type: BOOL->int
        ///lpName: LPCWSTR->WCHAR*
        ///lpOemName: LPSTR->CHAR*
        ///OemNameSize: DWORD->unsigned int
        ///pbNameContainsSpaces: PBOOL->BOOL*
        ///pbNameLegal: PBOOL->BOOL*
        [DllImport("kernel32.dll", EntryPoint = "CheckNameLegalDOS8Dot3")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CheckNameLegalDOS8Dot3(
            [In] [MarshalAs(UnmanagedType.LPTStr)] string lpName, [Out] [MarshalAs(UnmanagedType.LPStr)] StringBuilder lpOemName, uint OemNameSize,
            IntPtr pbNameContainsSpaces, [Out] out int pbNameLegal);

        /// Return Type: DWORD->unsigned int
        ///nCount: DWORD->unsigned int
        ///lpHandles: HANDLE*
        ///bWaitAll: BOOL->int
        ///dwMilliseconds: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "WaitForMultipleObjects")]
        public static extern uint WaitForMultipleObjects(
            uint nCount, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.SysInt, SizeParamIndex = 0)] IntPtr[] lpHandles,
            [MarshalAs(UnmanagedType.Bool)] bool bWaitAll, uint dwMilliseconds);

        /// Return Type: BOOL->int
        ///lpTimeZoneInformation: TIME_ZONE_INFORMATION*
        [DllImport("kernel32.dll", EntryPoint = "SetTimeZoneInformation")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetTimeZoneInformation([In] ref TIME_ZONE_INFORMATION lpTimeZoneInformation);

        /// Return Type: BOOL->int
        ///hThread: HANDLE->void*
        ///bDisablePriorityBoost: BOOL->int
        [DllImport("kernel32.dll", EntryPoint = "SetThreadPriorityBoost")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetThreadPriorityBoost([In] IntPtr hThread, [MarshalAs(UnmanagedType.Bool)] bool bDisablePriorityBoost);

        /// Return Type: BOOL->int
        ///hProcess: HANDLE->void*
        ///dwProcessAffinityMask: DWORD_PTR->ULONG_PTR->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "SetProcessAffinityMask")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetProcessAffinityMask([In] IntPtr hProcess, uint dwProcessAffinityMask);

        /// Return Type: LONG->int
        ///Addend: LONG*
        ///Value: LONG->int
        [DllImport("kernel32.dll", EntryPoint = "InterlockedExchangeAdd")]
        public static extern int InterlockedExchangeAdd(ref int Addend, int Value);

        /// Return Type: DWORD->unsigned int
        ///lpTimeZoneInformation: LPTIME_ZONE_INFORMATION->_TIME_ZONE_INFORMATION*
        [DllImport("kernel32.dll", EntryPoint = "GetTimeZoneInformation")]
        public static extern uint GetTimeZoneInformation([Out] out TIME_ZONE_INFORMATION lpTimeZoneInformation);

        /// Return Type: BOOL->int
        ///hThread: HANDLE->void*
        ///dwSelector: DWORD->unsigned int
        ///lpSelectorEntry: LPLDT_ENTRY->PLDT_ENTRY->_LDT_ENTRY*
        [DllImport("kernel32.dll", EntryPoint = "GetThreadSelectorEntry")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetThreadSelectorEntry([In] IntPtr hThread, uint dwSelector, [Out] out LDT_ENTRY lpSelectorEntry);

        /// Return Type: BOOL->int
        ///hThread: HANDLE->void*
        ///pDisablePriorityBoost: PBOOL->BOOL*
        [DllImport("kernel32.dll", EntryPoint = "GetThreadPriorityBoost")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetThreadPriorityBoost([In] IntPtr hThread, [Out] out int pDisablePriorityBoost);

        /// Return Type: BOOL->int
        ///hThread: HANDLE->void*
        ///lpIOIsPending: PBOOL->BOOL*
        [DllImport("kernel32.dll", EntryPoint = "GetThreadIOPendingFlag")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetThreadIOPendingFlag([In] IntPtr hThread, [Out] out int lpIOIsPending);

        /// Return Type: BOOL->int
        ///pdwQuotaAllowed: PDWORD->DWORD*
        ///pdwQuotaUsed: PDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "GetSystemRegistryQuota")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetSystemRegistryQuota(IntPtr pdwQuotaAllowed, IntPtr pdwQuotaUsed);

        /// Return Type: LANGID->WORD->unsigned short
        [DllImport("kernel32.dll", EntryPoint = "GetSystemDefaultLangID")]
        public static extern ushort GetSystemDefaultLangID();

        /// Return Type: BOOL->int
        ///hProcess: HANDLE->void*
        ///lpProcessAffinityMask: PDWORD_PTR->ULONG_PTR*
        ///lpSystemAffinityMask: PDWORD_PTR->ULONG_PTR*
        [DllImport("kernel32.dll", EntryPoint = "GetProcessAffinityMask")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetProcessAffinityMask([In] IntPtr hProcess, [Out] out uint lpProcessAffinityMask, [Out] out uint lpSystemAffinityMask);

        /// Return Type: DWORD->unsigned int
        ///lpFileName: LPCWSTR->WCHAR*
        ///lpFileSizeHigh: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "GetCompressedFileSize")]
        public static extern uint GetCompressedFileSize([In] [MarshalAs(UnmanagedType.LPTStr)] string lpFileName, [Out] out uint lpFileSizeHigh);

        /// Return Type: BOOL->int
        ///hModule: HMODULE->HINSTANCE->HINSTANCE__*
        ///lpType: LPCWSTR->WCHAR*
        ///lpName: LPCWSTR->WCHAR*
        ///lpEnumFunc: ENUMRESLANGPROCW
        ///lParam: LONG_PTR->int
        [DllImport("kernel32.dll", EntryPoint = "EnumResourceLanguages")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumResourceLanguages(
            [In] IntPtr hModule, [In] [MarshalAs(UnmanagedType.LPTStr)] string lpType, [In] [MarshalAs(UnmanagedType.LPTStr)] string lpName,
            ENUMRESLANGPROC lpEnumFunc, [MarshalAs(UnmanagedType.SysInt)] int lParam);

        /// Return Type: BOOL->int
        ///dwProcessId: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "DebugActiveProcessStop")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DebugActiveProcessStop(uint dwProcessId);

        /// Return Type: HANDLE->void*
        ///FileHandle: HANDLE->void*
        ///ExistingCompletionPort: HANDLE->void*
        ///CompletionKey: ULONG_PTR->unsigned int
        ///NumberOfConcurrentThreads: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "CreateIoCompletionPort")]
        public static extern IntPtr CreateIoCompletionPort(
            [In] IntPtr FileHandle, [In] IntPtr ExistingCompletionPort, uint CompletionKey, uint NumberOfConcurrentThreads);

        /// Return Type: DWORD->unsigned int
        ///hHandle: HANDLE->void*
        ///dwMilliseconds: DWORD->unsigned int
        ///bAlertable: BOOL->int
        [DllImport("kernel32.dll", EntryPoint = "WaitForSingleObjectEx")]
        public static extern uint WaitForSingleObjectEx([In] IntPtr hHandle, uint dwMilliseconds, [MarshalAs(UnmanagedType.Bool)] bool bAlertable);

        /// Return Type: DWORD_PTR->ULONG_PTR->unsigned int
        ///hThread: HANDLE->void*
        ///dwThreadAffinityMask: DWORD_PTR->ULONG_PTR->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "SetThreadAffinityMask")]
        public static extern uint SetThreadAffinityMask([In] IntPtr hThread, uint dwThreadAffinityMask);

        /// Return Type: BOOL->int
        ///lpszName: LPCWSTR->WCHAR*
        ///lpCC: LPCOMMCONFIG->_COMMCONFIG*
        ///dwSize: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "SetDefaultCommConfig")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetDefaultCommConfig([In] [MarshalAs(UnmanagedType.LPTStr)] string lpszName, [In] IntPtr lpCC, uint dwSize);

        /// Return Type: BOOL->int
        ///HandlerRoutine: PHANDLER_ROUTINE
        ///Add: BOOL->int
        [DllImport("kernel32.dll", EntryPoint = "SetConsoleCtrlHandler")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetConsoleCtrlHandler(PHANDLER_ROUTINE HandlerRoutine, [MarshalAs(UnmanagedType.Bool)] bool Add);

        /// Return Type: BOOL->int
        ///hDirectory: HANDLE->void*
        ///lpBuffer: LPVOID->void*
        ///nBufferLength: DWORD->unsigned int
        ///bWatchSubtree: BOOL->int
        ///dwNotifyFilter: DWORD->unsigned int
        ///lpBytesReturned: LPDWORD->DWORD*
        ///lpOverlapped: LPOVERLAPPED->_OVERLAPPED*
        ///lpCompletionRoutine: LPOVERLAPPED_COMPLETION_ROUTINE
        [DllImport("kernel32.dll", EntryPoint = "ReadDirectoryChanges")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ReadDirectoryChanges(
            [In] IntPtr hDirectory, IntPtr lpBuffer, uint nBufferLength, [MarshalAs(UnmanagedType.Bool)] bool bWatchSubtree, uint dwNotifyFilter,
            [Out] out uint lpBytesReturned, ref OVERLAPPED lpOverlapped, LPOVERLAPPED_COMPLETION_ROUTINE lpCompletionRoutine);

        /// Return Type: BOOL->int
        ///lpExistingFileName: LPCWSTR->WCHAR*
        ///lpNewFileName: LPCWSTR->WCHAR*
        ///lpProgressRoutine: LPPROGRESS_ROUTINE
        ///lpData: LPVOID->void*
        ///dwFlags: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "MoveFileWithProgress")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool MoveFileWithProgress(
            [In] [MarshalAs(UnmanagedType.LPTStr)] string lpExistingFileName, [In] [MarshalAs(UnmanagedType.LPTStr)] string lpNewFileName,
            LPPROGRESS_ROUTINE lpProgressRoutine, [In] IntPtr lpData, MOVEFILE dwFlags);

        /// Return Type: PSINGLE_LIST_ENTRY->_SINGLE_LIST_ENTRY*
        ///ListHead: PSLIST_HEADER->_SLIST_HEADER*
        [DllImport("kernel32.dll", EntryPoint = "InterlockedFlushSList")]
        public static extern IntPtr InterlockedFlushSList(ref SLIST_HEADER ListHead);

        /// Return Type: BOOL->int
        ///lpRootPathName: LPCWSTR->WCHAR*
        ///lpVolumeNameBuffer: LPWSTR->WCHAR*
        ///nVolumeNameSize: DWORD->unsigned int
        ///lpVolumeSerialNumber: LPDWORD->DWORD*
        ///lpMaximumComponentLength: LPDWORD->DWORD*
        ///lpFileSystemFlags: LPDWORD->DWORD*
        ///lpFileSystemNameBuffer: LPWSTR->WCHAR*
        ///nFileSystemNameSize: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetVolumeInformation")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetVolumeInformation(
            [In] [MarshalAs(UnmanagedType.LPTStr)] string lpRootPathName, [Out] [MarshalAs(UnmanagedType.LPTStr)] StringBuilder lpVolumeNameBuffer,
            uint nVolumeNameSize, IntPtr lpVolumeSerialNumber, IntPtr lpMaximumComponentLength, out FILE lpFileSystemFlags,
            [Out] [MarshalAs(UnmanagedType.LPTStr)] StringBuilder lpFileSystemNameBuffer, uint nFileSystemNameSize);

        /// Return Type: BOOL->int
        ///hProcess: HANDLE->void*
        ///pdwHandleCount: PDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "GetProcessHandleCount")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetProcessHandleCount([In] IntPtr hProcess, [Out] out uint pdwHandleCount);

        /// Return Type: UINT->unsigned int
        ///lpAppName: LPCWSTR->WCHAR*
        ///lpKeyName: LPCWSTR->WCHAR*
        ///nDefault: INT->int
        ///lpFileName: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetPrivateProfileInt")]
        public static extern uint GetPrivateProfileInt(
            [In] [MarshalAs(UnmanagedType.LPTStr)] string lpAppName, [In] [MarshalAs(UnmanagedType.LPTStr)] string lpKeyName, int nDefault,
            [In] [MarshalAs(UnmanagedType.LPTStr)] string lpFileName);

        /// Return Type: LPCH->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetEnvironmentStrings")]
        public static extern IntPtr GetEnvironmentStrings();

        /// Return Type: BOOL->int
        ///lpszName: LPCWSTR->WCHAR*
        ///lpCC: LPCOMMCONFIG->_COMMCONFIG*
        ///lpdwSize: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "GetDefaultCommConfig")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetDefaultCommConfig([In] [MarshalAs(UnmanagedType.LPTStr)] string lpszName, IntPtr lpCC, ref uint lpdwSize);

        /// Return Type: BOOL->int
        ///hConsoleOutput: HANDLE->void*
        ///bMaximumWindow: BOOL->int
        ///lpConsoleCurrentFont: PCONSOLE_FONT_INFO->_CONSOLE_FONT_INFO*
        [DllImport("kernel32.dll", EntryPoint = "GetCurrentConsoleFont")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetCurrentConsoleFont(
            IntPtr hConsoleOutput, [MarshalAs(UnmanagedType.Bool)] bool bMaximumWindow, ref CONSOLE_FONT_INFO lpConsoleCurrentFont);

        /// Return Type: DWORD->unsigned int
        ///lpdwProcessList: LPDWORD->DWORD*
        ///dwProcessCount: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetConsoleProcessList")]
        public static extern uint GetConsoleProcessList(ref uint lpdwProcessList, uint dwProcessCount);

        /// Return Type: BOOL->int
        ///lpModeFlags: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "GetConsoleDisplayMode")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetConsoleDisplayMode(ref CONSOLE lpModeFlags);

        /// Return Type: BOOL->int
        ///hProcess: HANDLE->void*
        ///NumberOfPages: PULONG_PTR->unsigned int*
        ///PageArray: PULONG_PTR->unsigned int*
        [DllImport("kernel32.dll", EntryPoint = "FreeUserPhysicalPages")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FreeUserPhysicalPages([In] IntPtr hProcess, ref uint NumberOfPages, [In] IntPtr PageArray);

        /// Return Type: BOOL->int
        ///hProcess: HANDLE->void*
        ///lpBaseAddress: LPCVOID->void*
        ///dwSize: SIZE_T->ULONG_PTR->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "FlushInstructionCache")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FlushInstructionCache([In] IntPtr hProcess, [In] IntPtr lpBaseAddress, uint dwSize);

        /// Return Type: BOOL->int
        ///dwFlags: DWORD->unsigned int
        ///lpExtensionGuid: GUID*
        ///ulSectionId: ULONG->unsigned int
        ///lpGuidToFind: GUID*
        ///ReturnedData: PACTCTX_SECTION_KEYED_DATA->tagACTCTX_SECTION_KEYED_DATA*
        [DllImport("kernel32.dll", EntryPoint = "FindActCtxSectionGuid")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FindActCtxSectionGuid(
            FIND_ACTCTX_SECTION dwFlags, IntPtr lpExtensionGuid, uint ulSectionId, [In] IntPtr lpGuidToFind, [Out] out ACTCTX_SECTION_KEYED_DATA ReturnedData);

        /// Return Type: BOOL->int
        ///lpFileTime: FILETIME*
        ///lpFatDate: LPWORD->WORD*
        ///lpFatTime: LPWORD->WORD*
        [DllImport("kernel32.dll", EntryPoint = "FileTimeToDosDateTime")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FileTimeToDosDateTime([In] ref FILETIME lpFileTime, [Out] out ushort lpFatDate, [Out] out ushort lpFatTime);

        /// Return Type: BOOL->int
        ///wFatDate: WORD->unsigned short
        ///wFatTime: WORD->unsigned short
        ///lpFileTime: LPFILETIME->_FILETIME*
        [DllImport("kernel32.dll", EntryPoint = "DosDateTimeToFileTime")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DosDateTimeToFileTime(ushort wFatDate, ushort wFatTime, [Out] out FILETIME lpFileTime);

        /// Return Type: BOOL->int
        ///TimerQueue: HANDLE->void*
        ///Timer: HANDLE->void*
        ///CompletionEvent: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "DeleteTimerQueueTimer")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DeleteTimerQueueTimer([In] IntPtr TimerQueue, [In] IntPtr Timer, [In] IntPtr CompletionEvent);

        /// Return Type: void
        ///lpCriticalSection: LPCRITICAL_SECTION->PRTL_CRITICAL_SECTION->_RTL_CRITICAL_SECTION*
        [DllImport("kernel32.dll", EntryPoint = "DeleteCriticalSection")]
        public static extern void DeleteCriticalSection(ref RTL_CRITICAL_SECTION lpCriticalSection);

        /// Return Type: BOOL->int
        ///phNewTimer: PHANDLE->HANDLE*
        ///TimerQueue: HANDLE->void*
        ///Callback: WAITORTIMERCALLBACK->WAITORTIMERCALLBACKFUNC
        ///Parameter: PVOID->void*
        ///DueTime: DWORD->unsigned int
        ///Period: DWORD->unsigned int
        ///Flags: ULONG->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "CreateTimerQueueTimer")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CreateTimerQueueTimer(
            out IntPtr phNewTimer, [In] IntPtr TimerQueue, WAITORTIMERCALLBACKFUNC Callback, [In] IntPtr Parameter, uint DueTime, uint Period, WT Flags);

        /// Return Type: BOOL->int
        ///TimerQueue: HANDLE->void*
        ///Timer: HANDLE->void*
        ///DueTime: ULONG->unsigned int
        ///Period: ULONG->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "ChangeTimerQueueTimer")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ChangeTimerQueueTimer([In] IntPtr TimerQueue, IntPtr Timer, uint DueTime, uint Period);

        /// Return Type: BOOL->int
        ///TimerQueue: HANDLE->void*
        ///Timer: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "CancelTimerQueueTimer")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CancelTimerQueueTimer([In] IntPtr TimerQueue, [In] IntPtr Timer);

        /// Return Type: BOOL->int
        ///lpAppName: LPCWSTR->WCHAR*
        ///lpString: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "WriteProfileSection")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WriteProfileSection(
            [In] [MarshalAs(UnmanagedType.LPTStr)] string lpAppName, [In] [MarshalAs(UnmanagedType.LPTStr)] string lpString);

        /// Return Type: BOOL->int
        ///lpSystemTime: SYSTEMTIME*
        ///lpFileTime: LPFILETIME->_FILETIME*
        [DllImport("kernel32.dll", EntryPoint = "SystemTimeToFileTime")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SystemTimeToFileTime([In] ref SYSTEMTIME lpSystemTime, [Out] out FILETIME lpFileTime);

        /// Return Type: BOOL->int
        ///lpszVolumeMountPoint: LPCWSTR->WCHAR*
        ///lpszVolumeName: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "SetVolumeMountPoint")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetVolumeMountPoint(
            [In] [MarshalAs(UnmanagedType.LPTStr)] string lpszVolumeMountPoint, [In] [MarshalAs(UnmanagedType.LPTStr)] string lpszVolumeName);

        /// Return Type: BOOL->int
        ///hObject: HANDLE->void*
        ///dwMask: DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "SetHandleInformation")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetHandleInformation([In] IntPtr hObject, uint dwMask, HANDLE_FLAG dwFlags);

        /// Return Type: BOOL->int
        ///lpPathName: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "SetCurrentDirectory")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetCurrentDirectory([In] [MarshalAs(UnmanagedType.LPTStr)] string lpPathName);

        /// Return Type: BOOL->int
        ///hConsoleOutput: HANDLE->void*
        ///bAbsolute: BOOL->int
        ///lpConsoleWindow: SMALL_RECT*
        [DllImport("kernel32.dll", EntryPoint = "SetConsoleWindowInfo")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetConsoleWindowInfo(IntPtr hConsoleOutput, [MarshalAs(UnmanagedType.Bool)] bool bAbsolute, ref SMALL_RECT lpConsoleWindow);

        /// Return Type: BOOL->int
        ///hConsoleOutput: HANDLE->void*
        ///lpConsoleCursorInfo: CONSOLE_CURSOR_INFO*
        [DllImport("kernel32.dll", EntryPoint = "SetConsoleCursorInfo")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetConsoleCursorInfo(IntPtr hConsoleOutput, ref CONSOLE_CURSOR_INFO lpConsoleCursorInfo);

        /// Return Type: BOOL->int
        ///latency: LATENCY_TIME->Anonymous_faa2d20b_f3c7_40e5_b631_f121698025b2
        [DllImport("kernel32.dll", EntryPoint = "RequestWakeupLatency")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool RequestWakeupLatency(LATENCY_TIME latency);

        /// Return Type: BOOL->int
        ///dwProcessId: DWORD->unsigned int
        ///pSessionId: DWORD*
        [DllImport("kernel32.dll", EntryPoint = "ProcessIdToSessionId")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ProcessIdToSessionId(uint dwProcessId, [Out] out uint pSessionId);

        /// Return Type: BOOL->int
        ///VirtualAddress: PVOID->void*
        ///NumberOfPages: ULONG_PTR->unsigned int
        ///PageArray: PULONG_PTR->unsigned int*
        [DllImport("kernel32.dll", EntryPoint = "MapUserPhysicalPages")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool MapUserPhysicalPages([In] IntPtr VirtualAddress, uint NumberOfPages, [In] IntPtr PageArray);

        /// Return Type: void
        ///lpCriticalSection: LPCRITICAL_SECTION->PRTL_CRITICAL_SECTION->_RTL_CRITICAL_SECTION*
        [DllImport("kernel32.dll", EntryPoint = "LeaveCriticalSection")]
        public static extern void LeaveCriticalSection(ref RTL_CRITICAL_SECTION lpCriticalSection);

        /// Return Type: BOOL->int
        ///LanguageGroup: LGRPID->DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "IsValidLanguageGroup")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsValidLanguageGroup(uint LanguageGroup, LGRPID dwFlags);

        /// Return Type: LONG->int
        ///lpAddend: LONG*
        [DllImport("kernel32.dll", EntryPoint = "InterlockedIncrement")]
        public static extern int InterlockedIncrement(ref int lpAddend);

        /// Return Type: LONG->int
        ///lpAddend: LONG*
        [DllImport("kernel32.dll", EntryPoint = "InterlockedDecrement")]
        public static extern int InterlockedDecrement(ref int lpAddend);

        /// Return Type: BOOL->int
        ///HeapHandle: HANDLE->void*
        ///HeapInformationClass: HEAP_INFORMATION_CLASS->_HEAP_INFORMATION_CLASS
        ///HeapInformation: PVOID->void*
        ///HeapInformationLength: SIZE_T->ULONG_PTR->unsigned int
        ///ReturnLength: PSIZE_T->ULONG_PTR*
        [DllImport("kernel32.dll", EntryPoint = "HeapQueryInformation")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool HeapQueryInformation(
            [In] IntPtr HeapHandle, HEAP_INFORMATION_CLASS HeapInformationClass, IntPtr HeapInformation, uint HeapInformationLength, IntPtr ReturnLength);

        /// Return Type: BOOL->int
        ///lpBuffer: LPMEMORYSTATUSEX->_MEMORYSTATUSEX*
        [DllImport("kernel32.dll", EntryPoint = "GlobalMemoryStatusEx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GlobalMemoryStatusEx([Out] out MEMORYSTATUSEX lpBuffer);

        /// Return Type: UINT->unsigned int
        ///lpBuffer: LPWSTR->WCHAR*
        ///uSize: UINT->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetWindowsDirectory")]
        public static extern uint GetWindowsDirectory([Out] [MarshalAs(UnmanagedType.LPTStr)] StringBuilder lpBuffer, uint uSize);

        /// Return Type: LANGID->WORD->unsigned short
        [DllImport("kernel32.dll", EntryPoint = "GetUserDefaultLangID")]
        public static extern ushort GetUserDefaultLangID();

        /// Return Type: BOOL->int
        ///lpSystemPowerStatus: LPSYSTEM_POWER_STATUS->_SYSTEM_POWER_STATUS*
        [DllImport("kernel32.dll", EntryPoint = "GetSystemPowerStatus")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetSystemPowerStatus([Out] out SYSTEM_POWER_STATUS lpSystemPowerStatus);

        /// Return Type: LCID->DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetSystemDefaultLCID")]
        public static extern uint GetSystemDefaultLCID();

        /// Return Type: BOOL->int
        ///hProcess: HANDLE->void*
        ///lpIoCounters: PIO_COUNTERS->IO_COUNTERS*
        [DllImport("kernel32.dll", EntryPoint = "GetProcessIoCounters")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetProcessIoCounters([In] IntPtr hProcess, [Out] out IO_COUNTERS lpIoCounters);

        /// Return Type: BOOL->int
        ///Processor: UCHAR->unsigned char
        ///NodeNumber: PUCHAR->UCHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetNumaProcessorNode")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetNumaProcessorNode(byte Processor, [Out] [MarshalAs(UnmanagedType.LPStr)] StringBuilder NodeNumber);

        /// Return Type: BOOL->int
        ///hObject: HANDLE->void*
        ///lpdwFlags: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "GetHandleInformation")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetHandleInformation([In] IntPtr hObject, [Out] out HANDLE_FLAG lpdwFlags);

        /// Return Type: BOOL->int
        ///lpFileName: LPCWSTR->WCHAR*
        ///fInfoLevelId: GET_FILEEX_INFO_LEVELS->_GET_FILEEX_INFO_LEVELS
        ///lpFileInformation: LPVOID->void*
        [DllImport("kernel32.dll", EntryPoint = "GetFileAttributesEx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetFileAttributesEx(
            [In] [MarshalAs(UnmanagedType.LPTStr)] string lpFileName, GET_FILEEX_INFO_LEVELS fInfoLevelId, IntPtr lpFileInformation);

        /// Return Type: DWORD->unsigned int
        ///nBufferLength: DWORD->unsigned int
        ///lpBuffer: LPWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetCurrentDirectory")]
        public static extern uint GetCurrentDirectory(uint nBufferLength, [Out] [MarshalAs(UnmanagedType.LPTStr)] StringBuilder lpBuffer);

        /// Return Type: BOOL->int
        ///hConsoleOutput: HANDLE->void*
        ///lpConsoleCursorInfo: PCONSOLE_CURSOR_INFO->_CONSOLE_CURSOR_INFO*
        [DllImport("kernel32.dll", EntryPoint = "GetConsoleCursorInfo")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetConsoleCursorInfo(IntPtr hConsoleOutput, ref CONSOLE_CURSOR_INFO lpConsoleCursorInfo);

        /// Return Type: DWORD->unsigned int
        ///ExeNameBuffer: LPWSTR->WCHAR*
        ///ExeNameBufferLength: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetConsoleAliasExes")]
        public static extern uint GetConsoleAliasExes([MarshalAs(UnmanagedType.LPTStr)] StringBuilder ExeNameBuffer, uint ExeNameBufferLength);

        /// Return Type: BOOL->int
        ///lpFileTime: FILETIME*
        ///lpSystemTime: LPSYSTEMTIME->_SYSTEMTIME*
        [DllImport("kernel32.dll", EntryPoint = "FileTimeToSystemTime")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FileTimeToSystemTime([In] ref FILETIME lpFileTime, [Out] out SYSTEMTIME lpSystemTime);

        /// Return Type: BOOL->int
        ///lpCodePageEnumProc: CODEPAGE_ENUMPROCW
        ///dwFlags: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "EnumSystemCodePages")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumSystemCodePages(CODEPAGE_ENUMPROC lpCodePageEnumProc, CP dwFlags);

        /// Return Type: void
        ///lpCriticalSection: LPCRITICAL_SECTION->PRTL_CRITICAL_SECTION->_RTL_CRITICAL_SECTION*
        [DllImport("kernel32.dll", EntryPoint = "EnterCriticalSection")]
        public static extern void EnterCriticalSection(ref RTL_CRITICAL_SECTION lpCriticalSection);

        /// Return Type: HANDLE->void*
        ///lpTimerAttributes: LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        ///bManualReset: BOOL->int
        ///lpTimerName: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "CreateWaitableTimer")]
        public static extern IntPtr CreateWaitableTimer(
            [In] ref SECURITY_ATTRIBUTES lpTimerAttributes, [MarshalAs(UnmanagedType.Bool)] bool bManualReset, [In] [MarshalAs(UnmanagedType.LPTStr)] string lpTimerName);

        /// Return Type: LPVOID->void*
        ///lpParameter: LPVOID->void*
        [DllImport("kernel32.dll", EntryPoint = "ConvertThreadToFiber")]
        public static extern IntPtr ConvertThreadToFiber([In] IntPtr lpParameter);

        /// Return Type: BOOL->int
        [DllImport("kernel32.dll", EntryPoint = "ConvertFiberToThread")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ConvertFiberToThread();

        /// Return Type: LCID->DWORD->unsigned int
        ///Locale: LCID->DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "ConvertDefaultLocale")]
        public static extern uint ConvertDefaultLocale(uint Locale);

        /// Return Type: HANDLE->void*
        ///pFileName: LPCWSTR->WCHAR*
        ///bDeleteExistingResources: BOOL->int
        [DllImport("kernel32.dll", EntryPoint = "BeginUpdateResource")]
        public static extern IntPtr BeginUpdateResource(
            [In] [MarshalAs(UnmanagedType.LPTStr)] string pFileName, [MarshalAs(UnmanagedType.Bool)] bool bDeleteExistingResources);

        /// Return Type: BOOL->int
        ///lpAppName: LPCWSTR->WCHAR*
        ///lpKeyName: LPCWSTR->WCHAR*
        ///lpString: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "WriteProfileString")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WriteProfileString(
            [In] [MarshalAs(UnmanagedType.LPTStr)] string lpAppName, [In] [MarshalAs(UnmanagedType.LPTStr)] string lpKeyName,
            [In] [MarshalAs(UnmanagedType.LPTStr)] string lpString);

        /// Return Type: BOOL->int
        ///hConsoleOutput: HANDLE->void*
        ///lpBuffer: CHAR_INFO*
        ///dwBufferSize: COORD->_COORD
        ///dwBufferCoord: COORD->_COORD
        ///lpWriteRegion: PSMALL_RECT->_SMALL_RECT*
        [DllImport("kernel32.dll", EntryPoint = "WriteConsoleOutput")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WriteConsoleOutput(
            IntPtr hConsoleOutput, ref CHAR_INFO[] lpBuffer, COORD dwBufferSize, COORD dwBufferCoord, ref SMALL_RECT lpWriteRegion);

        /// Return Type: int
        ///CodePage: UINT->unsigned int
        ///dwFlags: DWORD->unsigned int
        ///lpWideCharStr: LPCWSTR->WCHAR*
        ///cchWideChar: int
        ///lpMultiByteStr: LPSTR->CHAR*
        ///cbMultiByte: int
        ///lpDefaultChar: LPCSTR->CHAR*
        ///lpUsedDefaultChar: LPBOOL->BOOL*
        [DllImport("kernel32.dll", EntryPoint = "WideCharToMultiByte")]
        public static extern int WideCharToMultiByte(
            uint CodePage, USE_CP dwFlags, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpWideCharStr, int cchWideChar, IntPtr lpMultiByteStr, int cbMultiByte,
            [In] [MarshalAs(UnmanagedType.LPStr)] string lpDefaultChar, IntPtr lpUsedDefaultChar);

        /// Return Type: DWORD->unsigned int
        ///hHandle: HANDLE->void*
        ///dwMilliseconds: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "WaitForSingleObject")]
        public static extern uint WaitForSingleObject([In] IntPtr hHandle, uint dwMilliseconds);

        /// Return Type: ULONGLONG->unsigned __int64
        ///ConditionMask: ULONGLONG->unsigned __int64
        ///TypeMask: DWORD->unsigned int
        ///Condition: BYTE->unsigned char
        [DllImport("kernel32.dll", EntryPoint = "VerSetConditionMask", CallingConvention = CallingConvention.StdCall)]
        public static extern ulong VerSetConditionMask(ulong ConditionMask, uint TypeMask, byte Condition);

        /// Return Type: DWORD->unsigned int
        ///hObjectToSignal: HANDLE->void*
        ///hObjectToWaitOn: HANDLE->void*
        ///dwMilliseconds: DWORD->unsigned int
        ///bAlertable: BOOL->int
        [DllImport("kernel32.dll", EntryPoint = "SignalObjectAndWait")]
        public static extern uint SignalObjectAndWait(
            [In] IntPtr hObjectToSignal, [In] IntPtr hObjectToWaitOn, uint dwMilliseconds, [MarshalAs(UnmanagedType.Bool)] bool bAlertable);

        /// Return Type: BOOL->int
        ///fSuspend: BOOL->int
        ///fForce: BOOL->int
        [DllImport("kernel32.dll", EntryPoint = "SetSystemPowerState")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetSystemPowerState([MarshalAs(UnmanagedType.Bool)] bool fSuspend, [MarshalAs(UnmanagedType.Bool)] bool fForce);

        /// Return Type: BOOL->int
        ///hDevice: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "RequestDeviceWakeup")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool RequestDeviceWakeup([In] IntPtr hDevice);

        /// Return Type: int
        ///CodePage: UINT->unsigned int
        ///dwFlags: DWORD->unsigned int
        ///lpMultiByteStr: LPCSTR->CHAR*
        ///cbMultiByte: int
        ///lpWideCharStr: LPWSTR->WCHAR*
        ///cchWideChar: int
        [DllImport("kernel32.dll", EntryPoint = "MultiByteToWideChar")]
        public static extern int MultiByteToWideChar(
            uint CodePage, USE_CP dwFlags, [In] [MarshalAs(UnmanagedType.LPStr)] string lpMultiByteStr, int cbMultiByte,
            [Out] [MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpWideCharStr, int cchWideChar);

        /// Return Type: LONG->int
        ///Target: LONG*
        ///Value: LONG->int
        [DllImport("kernel32.dll", EntryPoint = "InterlockedExchange")]
        public static extern int InterlockedExchange(ref int Target, int Value);

        /// Return Type: void
        ///ListHead: PSLIST_HEADER->_SLIST_HEADER*
        [DllImport("kernel32.dll", EntryPoint = "InitializeSListHead")]
        public static extern void InitializeSListHead(ref SLIST_HEADER ListHead);

        /// Return Type: UINT->unsigned int
        ///lpBuffer: LPWSTR->WCHAR*
        ///uSize: UINT->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetSystemDirectory")]
        public static extern uint GetSystemDirectory([Out] [MarshalAs(UnmanagedType.LPTStr)] StringBuilder lpBuffer, uint uSize);

        /// Return Type: BOOL->int
        ///hFile: HANDLE->void*
        ///lpOverlapped: LPOVERLAPPED->_OVERLAPPED*
        ///lpNumberOfBytesTransferred: LPDWORD->DWORD*
        ///bWait: BOOL->int
        [DllImport("kernel32.dll", EntryPoint = "GetOverlappedResult")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetOverlappedResult(
            [In] IntPtr hFile, [In] ref OVERLAPPED lpOverlapped, [Out] out uint lpNumberOfBytesTransferred, [MarshalAs(UnmanagedType.Bool)] bool bWait);

        /// Return Type: void
        ///lpSystemInfo: LPSYSTEM_INFO->_SYSTEM_INFO*
        [DllImport("kernel32.dll", EntryPoint = "GetNativeSystemInfo")]
        public static extern void GetNativeSystemInfo([Out] out SYSTEM_INFO lpSystemInfo);

        /// Return Type: BOOL->int
        ///lpDirectoryName: LPCWSTR->WCHAR*
        ///lpFreeBytesAvailableToCaller: PULARGE_INTEGER->ULARGE_INTEGER*
        ///lpTotalNumberOfBytes: PULARGE_INTEGER->ULARGE_INTEGER*
        ///lpTotalNumberOfFreeBytes: PULARGE_INTEGER->ULARGE_INTEGER*
        [DllImport("kernel32.dll", EntryPoint = "GetDiskFreeSpaceEx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetDiskFreeSpaceEx(
            [In] [MarshalAs(UnmanagedType.LPTStr)] string lpDirectoryName, IntPtr lpFreeBytesAvailableToCaller, IntPtr lpTotalNumberOfBytes,
            IntPtr lpTotalNumberOfFreeBytes);

        /// Return Type: BOOL->int
        ///hDevice: HANDLE->void*
        ///pfOn: BOOL*
        [DllImport("kernel32.dll", EntryPoint = "GetDevicePowerState")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetDevicePowerState([In] IntPtr hDevice, [Out] out int pfOn);

        /// Return Type: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetCurrentProcessId")]
        public static extern uint GetCurrentProcessId();

        /// Return Type: BOOL->int
        ///lpCalInfoEnumProcEx: CALINFO_ENUMPROCEXW
        ///Locale: LCID->DWORD->unsigned int
        ///Calendar: CALID->DWORD->unsigned int
        ///CalType: CALTYPE->DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "EnumCalendarInfoEx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumCalendarInfoEx(CALINFO_ENUMPROCEX lpCalInfoEnumProcEx, uint Locale, uint Calendar, uint CalType);

        /// Return Type: PVOID->void*
        ///Ptr: PVOID->void*
        [DllImport("kernel32.dll", EntryPoint = "EncodeSystemPointer")]
        public static extern IntPtr EncodeSystemPointer([In] IntPtr Ptr);

        /// Return Type: BOOL->int
        ///hNamedPipe: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "DisconnectNamedPipe")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DisconnectNamedPipe([In] IntPtr hNamedPipe);

        /// Return Type: PVOID->void*
        ///Ptr: PVOID->void*
        [DllImport("kernel32.dll", EntryPoint = "DecodeSystemPointer")]
        public static extern IntPtr DecodeSystemPointer([In] IntPtr Ptr);

        /// Return Type: DWORD->unsigned int
        ///hDevice: HANDLE->void*
        ///dwPartitionMethod: DWORD->unsigned int
        ///dwCount: DWORD->unsigned int
        ///dwSize: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "CreateTapePartition")]
        public static extern uint CreateTapePartition([In] IntPtr hDevice, uint dwPartitionMethod, uint dwCount, uint dwSize);

        /// Return Type: BOOL->int
        ///hTimer: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "CancelWaitableTimer")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CancelWaitableTimer([In] IntPtr hTimer);

        /// Return Type: BOOL->int
        ///hProcess: HANDLE->void*
        ///lpBaseAddress: LPVOID->void*
        ///lpBuffer: LPCVOID->void*
        ///nSize: SIZE_T->ULONG_PTR->unsigned int
        ///lpNumberOfBytesWritten: SIZE_T*
        [DllImport("kernel32.dll", EntryPoint = "WriteProcessMemory")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WriteProcessMemory(
            [In] IntPtr hProcess, [In] IntPtr lpBaseAddress, [In] IntPtr lpBuffer, uint nSize, IntPtr lpNumberOfBytesWritten);

        /// Return Type: BOOL->int
        ///hConsoleInput: HANDLE->void*
        ///lpBuffer: INPUT_RECORD*
        ///nLength: DWORD->unsigned int
        ///lpNumberOfEventsWritten: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "WriteConsoleInput")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WriteConsoleInput(IntPtr hConsoleInput, ref INPUT_RECORD lpBuffer, uint nLength, ref uint lpNumberOfEventsWritten);

        /// Return Type: BOOL->int
        ///lpVersionInformation: LPOSVERSIONINFOEXW->_OSVERSIONINFOEXW*
        ///dwTypeMask: DWORD->unsigned int
        ///dwlConditionMask: DWORDLONG->ULONGLONG->unsigned __int64
        [DllImport("kernel32.dll", EntryPoint = "VerifyVersionInfo")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool VerifyVersionInfo(ref RTL_OSVERSIONINFOEX lpVersionInformation, uint dwTypeMask, ulong dwlConditionMask);

        /// Return Type: BOOL->int
        ///hJob: HANDLE->void*
        ///uExitCode: UINT->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "TerminateJobObject")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool TerminateJobObject([In] IntPtr hJob, uint uExitCode);

        /// Return Type: HANDLE->void*
        ///TimerQueue: HANDLE->void*
        ///Callback: WAITORTIMERCALLBACK->WAITORTIMERCALLBACKFUNC
        ///Parameter: PVOID->void*
        ///DueTime: DWORD->unsigned int
        ///Period: DWORD->unsigned int
        ///PreferIo: BOOL->int
        [DllImport("kernel32.dll", EntryPoint = "SetTimerQueueTimer")]
        public static extern IntPtr SetTimerQueueTimer(
            [In] IntPtr TimerQueue, WAITORTIMERCALLBACKFUNC Callback, [In] IntPtr Parameter, uint DueTime, uint Period,
            [MarshalAs(UnmanagedType.Bool)] bool PreferIo);

        /// Return Type: BOOL->int
        ///lpFileName: LPCWSTR->WCHAR*
        ///dwFileAttributes: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "SetFileAttributes")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetFileAttributes([In] [MarshalAs(UnmanagedType.LPTStr)] string lpFileName, FILE_ATTRIBUTE dwFileAttributes);

        /// Return Type: BOOL->int
        ///wCodePageID: UINT->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "SetConsoleOutputCP")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetConsoleOutputCP(uint wCodePageID);

        /// Return Type: BOOL->int
        ///NameType: COMPUTER_NAME_FORMAT->_COMPUTER_NAME_FORMAT
        ///lpBuffer: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "SetComputerNameEx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetComputerNameEx(COMPUTER_NAME_FORMAT NameType, [In] [MarshalAs(UnmanagedType.LPTStr)] string lpBuffer);

        /// Return Type: BOOL->int
        ///hConsoleOutput: HANDLE->void*
        ///lpBuffer: PCHAR_INFO->_CHAR_INFO*
        ///dwBufferSize: COORD->_COORD
        ///dwBufferCoord: COORD->_COORD
        ///lpReadRegion: PSMALL_RECT->_SMALL_RECT*
        [DllImport("kernel32.dll", EntryPoint = "ReadConsoleOutput")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ReadConsoleOutput(
            IntPtr hConsoleOutput, ref CHAR_INFO[] lpBuffer, COORD dwBufferSize, COORD dwBufferCoord, ref SMALL_RECT lpReadRegion);

        /// Return Type: void
        ///lpOutputString: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "OutputDebugString")]
        public static extern void OutputDebugString([In] [MarshalAs(UnmanagedType.LPTStr)] string lpOutputString);

        /// Return Type: HANDLE->void*
        ///dwDesiredAccess: DWORD->unsigned int
        ///bInheritHandle: BOOL->int
        ///lpTimerName: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "OpenWaitableTimer")]
        public static extern IntPtr OpenWaitableTimer(
            uint dwDesiredAccess, [MarshalAs(UnmanagedType.Bool)] bool bInheritHandle, [In] [MarshalAs(UnmanagedType.LPTStr)] string lpTimerName);

        /// Return Type: BOOL->int
        ///HeapHandle: HANDLE->void*
        ///HeapInformationClass: HEAP_INFORMATION_CLASS->_HEAP_INFORMATION_CLASS
        ///HeapInformation: PVOID->void*
        ///HeapInformationLength: SIZE_T->ULONG_PTR->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "HeapSetInformation")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool HeapSetInformation(
            [In] IntPtr HeapHandle, HEAP_INFORMATION_CLASS HeapInformationClass, [In] IntPtr HeapInformation, uint HeapInformationLength);

        /// Return Type: void
        ///lpBuffer: LPMEMORYSTATUS->_MEMORYSTATUS*
        [DllImport("kernel32.dll", EntryPoint = "GlobalMemoryStatus")]
        public static extern void GlobalMemoryStatus([Out] out MEMORYSTATUS lpBuffer);

        /// Return Type: UINT->unsigned int
        ///nAtom: ATOM->WORD->unsigned short
        ///lpBuffer: LPWSTR->WCHAR*
        ///nSize: int
        [DllImport("kernel32.dll", EntryPoint = "GlobalGetAtomName")]
        public static extern uint GlobalGetAtomName(ushort nAtom, [Out] [MarshalAs(UnmanagedType.LPTStr)] StringBuilder lpBuffer, int nSize);

        /// Return Type: BOOL->int
        ///lpszFileName: LPCWSTR->WCHAR*
        ///lpszVolumePathName: LPWSTR->WCHAR*
        ///cchBufferLength: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetVolumePathName")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetVolumePathName(
            [In] [MarshalAs(UnmanagedType.LPTStr)] string lpszFileName, [Out] [MarshalAs(UnmanagedType.LPTStr)] StringBuilder lpszVolumePathName,
            uint cchBufferLength);

        /// Return Type: LCID->DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetUserDefaultLCID")]
        public static extern uint GetUserDefaultLCID();

        /// Return Type: DWORD->unsigned int
        ///lpAppName: LPCWSTR->WCHAR*
        ///lpReturnedString: LPWSTR->WCHAR*
        ///nSize: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetProfileSection")]
        public static extern uint GetProfileSection(
            [In] [MarshalAs(UnmanagedType.LPTStr)] string lpAppName, [Out] [MarshalAs(UnmanagedType.LPTStr)] StringBuilder lpReturnedString, uint nSize);

        /// Return Type: BOOL->int
        ///dwFlags: DWORD->unsigned int
        ///lpModuleName: LPCWSTR->WCHAR*
        ///phModule: HMODULE*
        [DllImport("kernel32.dll", EntryPoint = "GetModuleHandleEx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetModuleHandleEx(GET_MODULE_HANDLE_EX dwFlags, [In] [MarshalAs(UnmanagedType.LPTStr)] string lpModuleName, ref IntPtr phModule);

        /// Return Type: DWORD->unsigned int
        ///hModule: HMODULE->HINSTANCE->HINSTANCE__*
        ///lpFilename: LPWCH->WCHAR*
        ///nSize: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetModuleFileName")]
        public static extern uint GetModuleFileName([In] IntPtr hModule, [Out] [MarshalAs(UnmanagedType.LPTStr)] StringBuilder lpFilename, uint nSize);

        /// Return Type: DWORD->unsigned int
        ///lpFileName: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetFileAttributes")]
        public static extern uint GetFileAttributes([In] [MarshalAs(UnmanagedType.LPTStr)] string lpFileName);

        /// Return Type: BOOL->int
        ///hProcess: HANDLE->void*
        ///lpExitCode: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "GetExitCodeProcess")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetExitCodeProcess([In] IntPtr hProcess, [Out] out uint lpExitCode);

        /// Return Type: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetCurrentThreadId")]
        public static extern uint GetCurrentThreadId();

        /// Return Type: int
        ///Locale: LCID->DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        ///lpValue: LPCWSTR->WCHAR*
        ///lpFormat: CURRENCYFMTW*
        ///lpCurrencyStr: LPWSTR->WCHAR*
        ///cchCurrency: int
        [DllImport("kernel32.dll", EntryPoint = "GetCurrencyFormat")]
        public static extern int GetCurrencyFormat(
            uint Locale, LOCALE_USE dwFlags, [In] [MarshalAs(UnmanagedType.LPTStr)] string lpValue, [In] IntPtr lpFormat,
            [Out] [MarshalAs(UnmanagedType.LPTStr)] StringBuilder lpCurrencyStr, int cchCurrency);

        /// Return Type: UINT->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetConsoleOutputCP")]
        public static extern uint GetConsoleOutputCP();

        /// Return Type: COORD->_COORD
        ///hConsoleOutput: HANDLE->void*
        ///nFont: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetConsoleFontSize")]
        public static extern COORD GetConsoleFontSize(IntPtr hConsoleOutput, uint nFont);

        /// Return Type: DWORD->unsigned int
        ///AliasBuffer: LPWSTR->WCHAR*
        ///AliasBufferLength: DWORD->unsigned int
        ///ExeName: LPWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetConsoleAliases")]
        public static extern uint GetConsoleAliases(
            [MarshalAs(UnmanagedType.LPTStr)] StringBuilder AliasBuffer, uint AliasBufferLength, [MarshalAs(UnmanagedType.LPTStr)] StringBuilder ExeName);

        /// Return Type: BOOL->int
        ///NameType: COMPUTER_NAME_FORMAT->_COMPUTER_NAME_FORMAT
        ///lpBuffer: LPWSTR->WCHAR*
        ///nSize: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "GetComputerNameEx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetComputerNameEx(
            COMPUTER_NAME_FORMAT NameType, [Out] [MarshalAs(UnmanagedType.LPTStr)] StringBuilder lpBuffer, ref uint nSize);

        /// Return Type: BOOL->int
        ///hFile: HANDLE->void*
        ///lpModemStat: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "GetCommModemStatus")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetCommModemStatus([In] IntPtr hFile, [Out] out uint lpModemStat);

        /// Return Type: BOOL->int
        ///hFile: HANDLE->void*
        ///dwFunc: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "EscapeCommFunction")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EscapeCommFunction([In] IntPtr hFile, uint dwFunc);

        /// Return Type: BOOL->int
        ///lpLocaleEnumProc: LOCALE_ENUMPROCW
        ///dwFlags: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "EnumSystemLocales")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumSystemLocales(LOCALE_ENUMPROC lpLocaleEnumProc, LCID dwFlags);

        /// Return Type: BOOL->int
        ///hModule: HMODULE->HINSTANCE->HINSTANCE__*
        ///lpEnumFunc: ENUMRESTYPEPROCW
        ///lParam: LONG_PTR->int
        [DllImport("kernel32.dll", EntryPoint = "EnumResourceTypes")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumResourceTypes([In] IntPtr hModule, ENUMRESTYPEPROC lpEnumFunc, [MarshalAs(UnmanagedType.SysInt)] int lParam);

        /// Return Type: BOOL->int
        ///hModule: HMODULE->HINSTANCE->HINSTANCE__*
        ///lpType: LPCWSTR->WCHAR*
        ///lpEnumFunc: ENUMRESNAMEPROCW
        ///lParam: LONG_PTR->int
        [DllImport("kernel32.dll", EntryPoint = "EnumResourceNames")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumResourceNames(
            [In] IntPtr hModule, [In] [MarshalAs(UnmanagedType.LPTStr)] string lpType, ENUMRESNAMEPROC lpEnumFunc, [MarshalAs(UnmanagedType.SysInt)] int lParam);

        /// Return Type: BOOL->int
        ///lpDateFmtEnumProcEx: DATEFMT_ENUMPROCEXW
        ///Locale: LCID->DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "EnumDateFormatsEx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumDateFormatsEx(DATEFMT_ENUMPROCEX lpDateFmtEnumProcEx, uint Locale, DATE dwFlags);

        /// Return Type: BOOL->int
        ///hUpdate: HANDLE->void*
        ///fDiscard: BOOL->int
        [DllImport("kernel32.dll", EntryPoint = "EndUpdateResource")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EndUpdateResource([In] IntPtr hUpdate, [MarshalAs(UnmanagedType.Bool)] bool fDiscard);

        /// Return Type: BOOL->int
        ///TimerQueue: HANDLE->void*
        ///CompletionEvent: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "DeleteTimerQueueEx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DeleteTimerQueueEx([In] IntPtr TimerQueue, [In] IntPtr CompletionEvent);

        /// Return Type: BOOL->int
        ///dwProcessId: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "DebugActiveProcess")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DebugActiveProcess(uint dwProcessId);

        /// Return Type: HANDLE->void*
        ///hProcess: HANDLE->void*
        ///lpThreadAttributes: LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        ///dwStackSize: SIZE_T->ULONG_PTR->unsigned int
        ///lpStartAddress: LPTHREAD_START_ROUTINE->PTHREAD_START_ROUTINE
        ///lpParameter: LPVOID->void*
        ///dwCreationFlags: DWORD->unsigned int
        ///lpThreadId: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "CreateRemoteThread")]
        public static extern IntPtr CreateRemoteThread(
            [In] IntPtr hProcess, [In] ref SECURITY_ATTRIBUTES lpThreadAttributes, uint dwStackSize, PTHREAD_START_ROUTINE lpStartAddress, [In] IntPtr lpParameter,
            THREAD dwCreationFlags, IntPtr lpThreadId);

        /// Return Type: HANDLE->void*
        ///hFile: HANDLE->void*
        ///lpFileMappingAttributes: LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        ///flProtect: DWORD->unsigned int
        ///dwMaximumSizeHigh: DWORD->unsigned int
        ///dwMaximumSizeLow: DWORD->unsigned int
        ///lpName: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "CreateFileMapping")]
        public static extern IntPtr CreateFileMapping(
            [In] IntPtr hFile, [In] ref SECURITY_ATTRIBUTES lpFileMappingAttributes, uint flProtect, uint dwMaximumSizeHigh, uint dwMaximumSizeLow,
            [In] [MarshalAs(UnmanagedType.LPTStr)] string lpName);

        /// Return Type: BOOL->int
        ///lpTemplateDirectory: LPCWSTR->WCHAR*
        ///lpNewDirectory: LPCWSTR->WCHAR*
        ///lpSecurityAttributes: LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        [DllImport("kernel32.dll", EntryPoint = "CreateDirectoryEx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CreateDirectoryEx(
            [In] [MarshalAs(UnmanagedType.LPTStr)] string lpTemplateDirectory, [In] [MarshalAs(UnmanagedType.LPTStr)] string lpNewDirectory,
            [In] ref SECURITY_ATTRIBUTES lpSecurityAttributes);

        /// Return Type: BOOL->int
        ///dwProcessId: DWORD->unsigned int
        ///dwThreadId: DWORD->unsigned int
        ///dwContinueStatus: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "ContinueDebugEvent")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ContinueDebugEvent(uint dwProcessId, uint dwThreadId, uint dwContinueStatus);

        /// Return Type: BOOL->int
        ///lpDebugEvent: LPDEBUG_EVENT->_DEBUG_EVENT*
        ///dwMilliseconds: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "WaitForDebugEvent")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WaitForDebugEvent([In] ref DEBUG_EVENT lpDebugEvent, uint dwMilliseconds);

        /// Return Type: BOOL->int
        ///hNamedPipe: HANDLE->void*
        ///lpInBuffer: LPVOID->void*
        ///nInBufferSize: DWORD->unsigned int
        ///lpOutBuffer: LPVOID->void*
        ///nOutBufferSize: DWORD->unsigned int
        ///lpBytesRead: LPDWORD->DWORD*
        ///lpOverlapped: LPOVERLAPPED->_OVERLAPPED*
        [DllImport("kernel32.dll", EntryPoint = "TransactNamedPipe")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool TransactNamedPipe(
            [In] IntPtr hNamedPipe, [In] IntPtr lpInBuffer, uint nInBufferSize, IntPtr lpOutBuffer, uint nOutBufferSize, [Out] out uint lpBytesRead,
            IntPtr lpOverlapped);

        /// Return Type: BOOL->int
        ///hThread: HANDLE->void*
        ///nPriority: int
        [DllImport("kernel32.dll", EntryPoint = "SetThreadPriority")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetThreadPriority([In] IntPtr hThread, int nPriority);

        /// Return Type: DWORD->unsigned int
        ///hDevice: HANDLE->void*
        ///dwOperation: DWORD->unsigned int
        ///lpTapeInformation: LPVOID->void*
        [DllImport("kernel32.dll", EntryPoint = "SetTapeParameters")]
        public static extern uint SetTapeParameters([In] IntPtr hDevice, uint dwOperation, [In] IntPtr lpTapeInformation);

        /// Return Type: BOOL->int
        ///hFile: HANDLE->void*
        ///lpShortName: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "SetFileShortName")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetFileShortName([In] IntPtr hFile, [In] [MarshalAs(UnmanagedType.LPTStr)] string lpShortName);

        /// Return Type: void
        [DllImport("kernel32.dll", EntryPoint = "SetFileApisToANSI")]
        public static extern void SetFileApisToANSI();

        /// Return Type: void
        ///ContextRecord: PCONTEXT->CONTEXT*
        [DllImport("kernel32.dll", EntryPoint = "RtlCaptureContext", CallingConvention = CallingConvention.StdCall)]
        public static extern void RtlCaptureContext(ref CONTEXT ContextRecord);

        /// Return Type: BOOL->int
        ///hProcess: HANDLE->void*
        ///lpBaseAddress: LPCVOID->void*
        ///lpBuffer: LPVOID->void*
        ///nSize: SIZE_T->ULONG_PTR->unsigned int
        ///lpNumberOfBytesRead: SIZE_T*
        [DllImport("kernel32.dll", EntryPoint = "ReadProcessMemory")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ReadProcessMemory([In] IntPtr hProcess, [In] IntPtr lpBaseAddress, IntPtr lpBuffer, uint nSize, IntPtr lpNumberOfBytesRead);

        /// Return Type: BOOL->int
        ///hConsoleInput: HANDLE->void*
        ///lpBuffer: PINPUT_RECORD->_INPUT_RECORD*
        ///nLength: DWORD->unsigned int
        ///lpNumberOfEventsRead: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "ReadConsoleInput")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ReadConsoleInput(IntPtr hConsoleInput, ref INPUT_RECORD[] lpBuffer, uint nLength, ref uint lpNumberOfEventsRead);

        /// Return Type: BOOL->int
        ///Function: LPTHREAD_START_ROUTINE->PTHREAD_START_ROUTINE
        ///Context: PVOID->void*
        ///Flags: ULONG->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "QueueUserWorkItem")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool QueueUserWorkItem(PTHREAD_START_ROUTINE Function, [In] IntPtr Context, WT Flags);

        /// Return Type: BOOL->int
        ///hConsoleInput: HANDLE->void*
        ///lpBuffer: PINPUT_RECORD->_INPUT_RECORD*
        ///nLength: DWORD->unsigned int
        ///lpNumberOfEventsRead: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "PeekConsoleInput")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PeekConsoleInput(IntPtr hConsoleInput, ref INPUT_RECORD lpBuffer, uint nLength, ref uint lpNumberOfEventsRead);

        /// Return Type: BOOL->int
        [DllImport("kernel32.dll", EntryPoint = "IsDebuggerPresent")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsDebuggerPresent();

        /// Return Type: BOOL->int
        ///lp: LPVOID->void*
        ///ucb: UINT_PTR->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "IsBadHugeWritePtr")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsBadHugeWritePtr([In] IntPtr lp, [MarshalAs(UnmanagedType.SysUInt)] uint ucb);

        /// Return Type: int
        ///hThread: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "GetThreadPriority")]
        public static extern int GetThreadPriority([In] IntPtr hThread);

        /// Return Type: DWORD->unsigned int
        ///hDevice: HANDLE->void*
        ///dwOperation: DWORD->unsigned int
        ///lpdwSize: LPDWORD->DWORD*
        ///lpTapeInformation: LPVOID->void*
        [DllImport("kernel32.dll", EntryPoint = "GetTapeParameters")]
        public static extern uint GetTapeParameters([In] IntPtr hDevice, uint dwOperation, ref uint lpdwSize, IntPtr lpTapeInformation);

        /// Return Type: DWORD->unsigned int
        ///lpszLongPath: LPCWSTR->WCHAR*
        ///lpszShortPath: LPWSTR->WCHAR*
        ///cchBuffer: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetShortPathName")]
        public static extern uint GetShortPathName(
            [In] [MarshalAs(UnmanagedType.LPTStr)] string lpszLongPath, [Out] [MarshalAs(UnmanagedType.LPTStr)] StringBuilder lpszShortPath, uint cchBuffer);

        /// Return Type: DWORD->unsigned int
        ///lpAppName: LPCWSTR->WCHAR*
        ///lpKeyName: LPCWSTR->WCHAR*
        ///lpDefault: LPCWSTR->WCHAR*
        ///lpReturnedString: LPWSTR->WCHAR*
        ///nSize: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetProfileString")]
        public static extern uint GetProfileString(
            [In] [MarshalAs(UnmanagedType.LPTStr)] string lpAppName, [In] [MarshalAs(UnmanagedType.LPTStr)] string lpKeyName,
            [In] [MarshalAs(UnmanagedType.LPTStr)] string lpDefault, [Out] [MarshalAs(UnmanagedType.LPTStr)] StringBuilder lpReturnedString, uint nSize);

        /// Return Type: DWORD->unsigned int
        ///ProcessId: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetProcessVersion")]
        public static extern uint GetProcessVersion(uint ProcessId);

        /// Return Type: BOOL->int
        ///hThread: HANDLE->void*
        ///lpExitCode: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "GetExitCodeThread")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetExitCodeThread([In] IntPtr hThread, [Out] out uint lpExitCode);

        /// Return Type: BOOL->int
        ///lpRootPathName: LPCWSTR->WCHAR*
        ///lpSectorsPerCluster: LPDWORD->DWORD*
        ///lpBytesPerSector: LPDWORD->DWORD*
        ///lpNumberOfFreeClusters: LPDWORD->DWORD*
        ///lpTotalNumberOfClusters: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "GetDiskFreeSpace")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetDiskFreeSpace(
            [In] [MarshalAs(UnmanagedType.LPTStr)] string lpRootPathName, IntPtr lpSectorsPerCluster, IntPtr lpBytesPerSector, IntPtr lpNumberOfFreeClusters,
            IntPtr lpTotalNumberOfClusters);

        /// Return Type: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "GetCurrentProcess")]
        public static extern IntPtr GetCurrentProcess();

        /// Return Type: BOOL->int
        ///hFile: HANDLE->void*
        ///lpCommProp: LPCOMMPROP->_COMMPROP*
        [DllImport("kernel32.dll", EntryPoint = "GetCommProperties")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetCommProperties([In] IntPtr hFile, [Out] out COMMPROP lpCommProp);

        /// Return Type: BOOL->int
        ///lpCalInfoEnumProc: CALINFO_ENUMPROCW
        ///Locale: LCID->DWORD->unsigned int
        ///Calendar: CALID->DWORD->unsigned int
        ///CalType: CALTYPE->DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "EnumCalendarInfo")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumCalendarInfo(CALINFO_ENUMPROC lpCalInfoEnumProc, uint Locale, uint Calendar, uint CalType);

        /// Return Type: BOOL->int
        ///Process: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "DebugBreakProcess")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DebugBreakProcess([In] IntPtr Process);

        /// Return Type: BOOL->int
        ///lpszName: LPCWSTR->WCHAR*
        ///hWnd: HWND->HWND__*
        ///lpCC: LPCOMMCONFIG->_COMMCONFIG*
        [DllImport("kernel32.dll", EntryPoint = "CommConfigDialog")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CommConfigDialog([In] [MarshalAs(UnmanagedType.LPTStr)] string lpszName, [In] IntPtr hWnd, ref COMMCONFIG lpCC);

        /// Return Type: BOOL->int
        ///hProcess: HANDLE->void*
        ///lpAddress: LPVOID->void*
        ///dwSize: SIZE_T->ULONG_PTR->unsigned int
        ///flNewProtect: DWORD->unsigned int
        ///lpflOldProtect: PDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "VirtualProtectEx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool VirtualProtectEx([In] IntPtr hProcess, [In] IntPtr lpAddress, uint dwSize, uint flNewProtect, [Out] out uint lpflOldProtect);

        /// Return Type: DWORD->unsigned int
        ///wLang: DWORD->unsigned int
        ///szLang: LPWSTR->WCHAR*
        ///nSize: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "VerLanguageName")]
        public static extern uint VerLanguageName(uint wLang, [MarshalAs(UnmanagedType.LPTStr)] StringBuilder szLang, uint nSize);

        /// Return Type: BOOL->int
        ///WaitHandle: HANDLE->void*
        ///CompletionEvent: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "UnregisterWaitEx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool UnregisterWaitEx([In] IntPtr WaitHandle, [In] IntPtr CompletionEvent);

        /// Return Type: BOOL->int
        ///hFile: HANDLE->void*
        ///cChar: char
        [DllImport("kernel32.dll", EntryPoint = "TransmitCommChar")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool TransmitCommChar([In] IntPtr hFile, byte cChar);

        /// Return Type: BOOL->int
        ///hProcess: HANDLE->void*
        ///uExitCode: UINT->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "TerminateProcess")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool TerminateProcess([In] IntPtr hProcess, uint uExitCode);

        /// Return Type: BOOL->int
        ///hTimer: HANDLE->void*
        ///lpDueTime: LARGE_INTEGER*
        ///lPeriod: LONG->int
        ///pfnCompletionRoutine: PTIMERAPCROUTINE
        ///lpArgToCompletionRoutine: LPVOID->void*
        ///fResume: BOOL->int
        [DllImport("kernel32.dll", EntryPoint = "SetWaitableTimer")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWaitableTimer(
            [In] IntPtr hTimer, [In] ref LARGE_INTEGER lpDueTime, int lPeriod, PTIMERAPCROUTINE pfnCompletionRoutine, [In] IntPtr lpArgToCompletionRoutine,
            [MarshalAs(UnmanagedType.Bool)] bool fResume);

        /// Return Type: BOOL->int
        ///hThread: HANDLE->void*
        ///lpContext: CONTEXT*
        [DllImport("kernel32.dll", EntryPoint = "SetThreadContext")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetThreadContext([In] IntPtr hThread, [In] ref CONTEXT lpContext);

        /// Return Type: BOOL->int
        ///hProcess: HANDLE->void*
        ///dwPriorityClass: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "SetPriorityClass")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetPriorityClass([In] IntPtr hProcess, uint dwPriorityClass);

        /// Return Type: BOOL->int
        ///hFile: HANDLE->void*
        ///ValidDataLength: LONGLONG->__int64
        [DllImport("kernel32.dll", EntryPoint = "SetFileValidData")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetFileValidData([In] IntPtr hFile, long ValidDataLength);

        /// Return Type: BOOL->int
        ///hFile: HANDLE->void*
        ///liDistanceToMove: LARGE_INTEGER->_LARGE_INTEGER
        ///lpNewFilePointer: PLARGE_INTEGER->LARGE_INTEGER*
        ///dwMoveMethod: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "SetFilePointerEx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetFilePointerEx([In] IntPtr hFile, LARGE_INTEGER liDistanceToMove, IntPtr lpNewFilePointer, uint dwMoveMethod);

        /// Return Type: void
        [DllImport("kernel32.dll", EntryPoint = "SetFileApisToOEM")]
        public static extern void SetFileApisToOEM();

        /// Return Type: BOOL->int
        ///lpPathName: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "SetDllDirectory")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetDllDirectory([In] [MarshalAs(UnmanagedType.LPTStr)] string lpPathName);

        /// Return Type: BOOL->int
        ///lpConsoleTitle: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "SetConsoleTitle")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetConsoleTitle([In] [MarshalAs(UnmanagedType.LPTStr)] string lpConsoleTitle);

        /// Return Type: BOOL->int
        ///lpComputerName: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "SetComputerName")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetComputerName([In] [MarshalAs(UnmanagedType.LPTStr)] string lpComputerName);

        /// Return Type: BOOL->int
        ///Locale: LCID->DWORD->unsigned int
        ///Calendar: CALID->DWORD->unsigned int
        ///CalType: CALTYPE->DWORD->unsigned int
        ///lpCalData: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "SetCalendarInfo")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetCalendarInfo(uint Locale, uint Calendar, uint CalType, [In] [MarshalAs(UnmanagedType.LPTStr)] string lpCalData);

        /// Return Type: BOOL->int
        ///lpPathName: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "RemoveDirectory")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool RemoveDirectory([In] [MarshalAs(UnmanagedType.LPTStr)] string lpPathName);

        /// Return Type: BOOL->int
        ///hSemaphore: HANDLE->void*
        ///lReleaseCount: LONG->int
        ///lpPreviousCount: LPLONG->int*
        [DllImport("kernel32.dll", EntryPoint = "ReleaseSemaphore")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ReleaseSemaphore([In] IntPtr hSemaphore, int lReleaseCount, IntPtr lpPreviousCount);

        /// Return Type: HANDLE->void*
        ///dwDesiredAccess: DWORD->unsigned int
        ///bInheritHandle: BOOL->int
        ///lpName: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "OpenFileMapping")]
        public static extern IntPtr OpenFileMapping(
            uint dwDesiredAccess, [MarshalAs(UnmanagedType.Bool)] bool bInheritHandle, [In] [MarshalAs(UnmanagedType.LPTStr)] string lpName);

        /// Return Type: BOOL->int
        ///CodePage: UINT->unsigned int
        ///TestChar: BYTE->unsigned char
        [DllImport("kernel32.dll", EntryPoint = "IsDBCSLeadByteEx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsDBCSLeadByteEx(uint CodePage, byte TestChar);

        /// Return Type: BOOL->int
        ///lp: void*
        ///ucb: UINT_PTR->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "IsBadHugeReadPtr")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsBadHugeReadPtr([In] IntPtr lp, [MarshalAs(UnmanagedType.SysUInt)] uint ucb);

        /// Return Type: ATOM->WORD->unsigned short
        ///nAtom: ATOM->WORD->unsigned short
        [DllImport("kernel32.dll", EntryPoint = "GlobalDeleteAtom")]
        public static extern ushort GlobalDeleteAtom(ushort nAtom);

        /// Return Type: BOOL->int
        ///hThread: HANDLE->void*
        ///lpContext: LPCONTEXT->PCONTEXT->CONTEXT*
        [DllImport("kernel32.dll", EntryPoint = "GetThreadContext")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetThreadContext([In] IntPtr hThread, ref CONTEXT lpContext);

        /// Return Type: UINT->unsigned int
        ///lpPathName: LPCWSTR->WCHAR*
        ///lpPrefixString: LPCWSTR->WCHAR*
        ///uUnique: UINT->unsigned int
        ///lpTempFileName: LPWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetTempFileName")]
        public static extern uint GetTempFileName(
            [In] [MarshalAs(UnmanagedType.LPTStr)] string lpPathName, [In] [MarshalAs(UnmanagedType.LPTStr)] string lpPrefixString, uint uUnique,
            [Out] [MarshalAs(UnmanagedType.LPTStr)] StringBuilder lpTempFileName);

        /// Return Type: BOOL->int
        ///Locale: LCID->DWORD->unsigned int
        ///dwInfoType: DWORD->unsigned int
        ///lpSrcStr: LPCWSTR->WCHAR*
        ///cchSrc: int
        ///lpCharType: LPWORD->WORD*
        [DllImport("kernel32.dll", EntryPoint = "GetStringTypeEx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetStringTypeEx(
            uint Locale, uint dwInfoType, [In] [MarshalAs(UnmanagedType.LPTStr)] string lpSrcStr, int cchSrc, [Out] out ushort lpCharType);

        /// Return Type: DWORD->unsigned int
        ///hProcess: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "GetPriorityClass")]
        public static extern uint GetPriorityClass([In] IntPtr hProcess);

        /// Return Type: int
        ///Locale: LCID->DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        ///lpValue: LPCWSTR->WCHAR*
        ///lpFormat: NUMBERFMTW*
        ///lpNumberStr: LPWSTR->WCHAR*
        ///cchNumber: int
        [DllImport("kernel32.dll", EntryPoint = "GetNumberFormat")]
        public static extern int GetNumberFormat(
            uint Locale, LOCALE_USE dwFlags, [In] [MarshalAs(UnmanagedType.LPTStr)] string lpValue, [In] IntPtr lpFormat,
            [Out] [MarshalAs(UnmanagedType.LPTStr)] StringBuilder lpNumberStr, int cchNumber);

        /// Return Type: BOOL->int
        ///hNamedPipe: HANDLE->void*
        ///lpFlags: LPDWORD->DWORD*
        ///lpOutBufferSize: LPDWORD->DWORD*
        ///lpInBufferSize: LPDWORD->DWORD*
        ///lpMaxInstances: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "GetNamedPipeInfo")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetNamedPipeInfo([In] IntPtr hNamedPipe, out PIPE lpFlags, IntPtr lpOutBufferSize, IntPtr lpInBufferSize, IntPtr lpMaxInstances);

        /// Return Type: HMODULE->HINSTANCE->HINSTANCE__*
        ///lpModuleName: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetModuleHandle")]
        public static extern IntPtr GetModuleHandle([In] [MarshalAs(UnmanagedType.LPTStr)] string lpModuleName);

        /// Return Type: DWORD->unsigned int
        ///lpszShortPath: LPCWSTR->WCHAR*
        ///lpszLongPath: LPWSTR->WCHAR*
        ///cchBuffer: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetLongPathName")]
        public static extern uint GetLongPathName(
            [In] [MarshalAs(UnmanagedType.LPTStr)] string lpszShortPath, [Out] [MarshalAs(UnmanagedType.LPTStr)] StringBuilder lpszLongPath, uint cchBuffer);

        /// Return Type: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetLogicalDrives")]
        public static extern uint GetLogicalDrives();

        /// Return Type: DWORD->unsigned int
        ///lpFileName: LPCWSTR->WCHAR*
        ///nBufferLength: DWORD->unsigned int
        ///lpBuffer: LPWSTR->WCHAR*
        ///lpFilePart: LPWSTR*
        [DllImport("kernel32.dll", EntryPoint = "GetFullPathName")]
        public static extern uint GetFullPathName(
            [In] [MarshalAs(UnmanagedType.LPTStr)] string lpFileName, uint nBufferLength, [Out] [MarshalAs(UnmanagedType.LPTStr)] StringBuilder lpBuffer,
            ref IntPtr lpFilePart);

        /// Return Type: INT->int
        ///param0: LPWSTR->WCHAR*
        ///param1: LPWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetExpandedName")]
        public static extern int GetExpandedName(
            [MarshalAs(UnmanagedType.LPTStr)] StringBuilder param0, [MarshalAs(UnmanagedType.LPTStr)] StringBuilder param1);

        /// Return Type: DWORD->unsigned int
        ///nBufferLength: DWORD->unsigned int
        ///lpBuffer: LPWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetDllDirectory")]
        public static extern uint GetDllDirectory(uint nBufferLength, [Out] [MarshalAs(UnmanagedType.LPTStr)] StringBuilder lpBuffer);

        /// Return Type: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "GetCurrentThread")]
        public static extern IntPtr GetCurrentThread();

        /// Return Type: BOOL->int
        ///lphActCtx: HANDLE*
        [DllImport("kernel32.dll", EntryPoint = "GetCurrentActCtx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetCurrentActCtx(out IntPtr lphActCtx);

        /// Return Type: HWND->HWND__*
        [DllImport("kernel32.dll", EntryPoint = "GetConsoleWindow")]
        public static extern IntPtr GetConsoleWindow();

        /// Return Type: DWORD->unsigned int
        ///lpConsoleTitle: LPWSTR->WCHAR*
        ///nSize: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetConsoleTitle")]
        public static extern uint GetConsoleTitle([MarshalAs(UnmanagedType.LPTStr)] StringBuilder lpConsoleTitle, uint nSize);

        /// Return Type: DWORD->unsigned int
        ///Source: LPWSTR->WCHAR*
        ///TargetBuffer: LPWSTR->WCHAR*
        ///TargetBufferLength: DWORD->unsigned int
        ///ExeName: LPWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetConsoleAlias")]
        public static extern uint GetConsoleAlias(
            [MarshalAs(UnmanagedType.LPTStr)] StringBuilder Source, [MarshalAs(UnmanagedType.LPTStr)] StringBuilder TargetBuffer, uint TargetBufferLength,
            [MarshalAs(UnmanagedType.LPTStr)] StringBuilder ExeName);

        /// Return Type: BOOL->int
        ///lpBuffer: LPWSTR->WCHAR*
        ///nSize: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "GetComputerName")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetComputerName([Out] [MarshalAs(UnmanagedType.LPTStr)] StringBuilder lpBuffer, ref uint nSize);

        /// Return Type: int
        ///Locale: LCID->DWORD->unsigned int
        ///Calendar: CALID->DWORD->unsigned int
        ///CalType: CALTYPE->DWORD->unsigned int
        ///lpCalData: LPWSTR->WCHAR*
        ///cchData: int
        ///lpValue: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "GetCalendarInfo")]
        public static extern int GetCalendarInfo(
            uint Locale, uint Calendar, uint CalType, [Out] [MarshalAs(UnmanagedType.LPTStr)] StringBuilder lpCalData, int cchData, [In] IntPtr lpValue);

        /// Return Type: BOOL->int
        ///hFile: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "FlushFileBuffers")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FlushFileBuffers([In] IntPtr hFile);

        /// Return Type: HANDLE->void*
        ///lpszVolumeName: LPWSTR->WCHAR*
        ///cchBufferLength: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "FindFirstVolume")]
        public static extern IntPtr FindFirstVolume([Out] [MarshalAs(UnmanagedType.LPTStr)] StringBuilder lpszVolumeName, uint cchBufferLength);

        /// Return Type: HANDLE->void*
        ///lpFileName: LPCWSTR->WCHAR*
        ///fInfoLevelId: FINDEX_INFO_LEVELS->_FINDEX_INFO_LEVELS
        ///lpFindFileData: LPVOID->void*
        ///fSearchOp: FINDEX_SEARCH_OPS->_FINDEX_SEARCH_OPS
        ///lpSearchFilter: LPVOID->void*
        ///dwAdditionalFlags: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "FindFirstFileEx")]
        public static extern IntPtr FindFirstFileEx(
            [In] [MarshalAs(UnmanagedType.LPTStr)] string lpFileName, FINDEX_INFO_LEVELS fInfoLevelId, IntPtr lpFindFileData, FINDEX_SEARCH_OPS fSearchOp,
            IntPtr lpSearchFilter, FIND_FIRST dwAdditionalFlags);

        /// Return Type: BOOL->int
        ///lpUILanguageEnumProc: UILANGUAGE_ENUMPROCW
        ///dwFlags: DWORD->unsigned int
        ///lParam: LONG_PTR->int
        [DllImport("kernel32.dll", EntryPoint = "EnumUILanguages")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumUILanguages(UILANGUAGE_ENUMPROC lpUILanguageEnumProc, MUI_LANGUAGE_ENUM dwFlags, [MarshalAs(UnmanagedType.SysInt)] int lParam);

        /// Return Type: BOOL->int
        ///lpTimeFmtEnumProc: TIMEFMT_ENUMPROCW
        ///Locale: LCID->DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "EnumTimeFormats")]
        [return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool EnumTimeFormats(TIMEFMT_ENUMPROC lpTimeFmtEnumProc, uint Locale, TIME_FORMAT_ENUM dwFlags);

        /// Return Type: BOOL->int
        ///lpDateFmtEnumProc: DATEFMT_ENUMPROCW
        ///Locale: LCID->DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "EnumDateFormats")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumDateFormats(DATEFMT_ENUMPROC lpDateFmtEnumProc, uint Locale, DATE dwFlags);

        /// Return Type: BOOL->int
        ///TimerQueue: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "DeleteTimerQueue")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DeleteTimerQueue([In] IntPtr TimerQueue);

        /// Return Type: BOOL->int
        ///dwFlags: DWORD->unsigned int
        ///lpDeviceName: LPCWSTR->WCHAR*
        ///lpTargetPath: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "DefineDosDevice")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DefineDosDevice(
            DDD dwFlags, [In] [MarshalAs(UnmanagedType.LPTStr)] string lpDeviceName, [In] [MarshalAs(UnmanagedType.LPTStr)] string lpTargetPath);

        /// Return Type: BOOL->int
        ///dwFlags: DWORD->unsigned int
        ///ulCookie: ULONG_PTR->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "DeactivateActCtx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DeactivateActCtx(DEACTIVATE_ACTCTX_FLAG dwFlags, uint ulCookie);

        /// Return Type: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "CreateTimerQueue")]
        public static extern IntPtr CreateTimerQueue();

        /// Return Type: HANDLE->void*
        ///lpSemaphoreAttributes: LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        ///lInitialCount: LONG->int
        ///lMaximumCount: LONG->int
        ///lpName: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "CreateSemaphore")]
        public static extern IntPtr CreateSemaphore(
            [In] ref SECURITY_ATTRIBUTES lpSemaphoreAttributes, int lInitialCount, int lMaximumCount, [In] [MarshalAs(UnmanagedType.LPTStr)] string lpName);

        /// Return Type: HANDLE->void*
        ///lpName: LPCWSTR->WCHAR*
        ///dwOpenMode: DWORD->unsigned int
        ///dwPipeMode: DWORD->unsigned int
        ///nMaxInstances: DWORD->unsigned int
        ///nOutBufferSize: DWORD->unsigned int
        ///nInBufferSize: DWORD->unsigned int
        ///nDefaultTimeOut: DWORD->unsigned int
        ///lpSecurityAttributes: LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        [DllImport("kernel32.dll", EntryPoint = "CreateNamedPipe")]
        public static extern IntPtr CreateNamedPipe(
            [In] [MarshalAs(UnmanagedType.LPTStr)] string lpName, uint dwOpenMode, uint dwPipeMode, uint nMaxInstances, uint nOutBufferSize, uint nInBufferSize,
            uint nDefaultTimeOut, [In] ref SECURITY_ATTRIBUTES lpSecurityAttributes);

        /// Return Type: HANDLE->void*
        ///lpJobAttributes: LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        ///lpName: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "CreateJobObject")]
        public static extern IntPtr CreateJobObject([In] ref SECURITY_ATTRIBUTES lpJobAttributes, [In] [MarshalAs(UnmanagedType.LPTStr)] string lpName);

        /// Return Type: BOOL->int
        ///lpPathName: LPCWSTR->WCHAR*
        ///lpSecurityAttributes: LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        [DllImport("kernel32.dll", EntryPoint = "CreateDirectory")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CreateDirectory([In] [MarshalAs(UnmanagedType.LPTStr)] string lpPathName, [In] ref SECURITY_ATTRIBUTES lpSecurityAttributes);

        /// Return Type: BOOL->int
        ///hNamedPipe: HANDLE->void*
        ///lpOverlapped: LPOVERLAPPED->_OVERLAPPED*
        [DllImport("kernel32.dll", EntryPoint = "ConnectNamedPipe")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ConnectNamedPipe([In] IntPtr hNamedPipe, IntPtr lpOverlapped);

        /// Return Type: BOOL->int
        ///Source: LPWSTR->WCHAR*
        ///Target: LPWSTR->WCHAR*
        ///ExeName: LPWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "AddConsoleAlias")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AddConsoleAlias(
            [MarshalAs(UnmanagedType.LPTStr)] StringBuilder Source, [MarshalAs(UnmanagedType.LPTStr)] StringBuilder Target,
            [MarshalAs(UnmanagedType.LPTStr)] StringBuilder ExeName);

        /// Return Type: BOOL->int
        ///hFile: HANDLE->void*
        ///aSegmentArray: FILE_SEGMENT_ELEMENT*
        ///nNumberOfBytesToWrite: DWORD->unsigned int
        ///lpReserved: LPDWORD->DWORD*
        ///lpOverlapped: LPOVERLAPPED->_OVERLAPPED*
        [DllImport("kernel32.dll", EntryPoint = "WriteFileGather")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WriteFileGather(
            [In] IntPtr hFile, [In] ref FILE_SEGMENT_ELEMENT aSegmentArray, uint nNumberOfBytesToWrite, IntPtr lpReserved, ref OVERLAPPED lpOverlapped);

        /// Return Type: BOOL->int
        ///hUpdate: HANDLE->void*
        ///lpType: LPCWSTR->WCHAR*
        ///lpName: LPCWSTR->WCHAR*
        ///wLanguage: WORD->unsigned short
        ///lpData: LPVOID->void*
        ///cb: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "UpdateResource")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool UpdateResource(
            [In] IntPtr hUpdate, [In] [MarshalAs(UnmanagedType.LPTStr)] string lpType, [In] [MarshalAs(UnmanagedType.LPTStr)] string lpName, ushort wLanguage,
            [In] IntPtr lpData, uint cb);

        /// Return Type: BOOL->int
        ///lpBaseAddress: LPCVOID->void*
        [DllImport("kernel32.dll", EntryPoint = "UnmapViewOfFile")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool UnmapViewOfFile([In] IntPtr lpBaseAddress);

        /// Return Type: BOOL->int
        ///hThread: HANDLE->void*
        ///dwExitCode: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "TerminateThread")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool TerminateThread([In] IntPtr hThread, uint dwExitCode);

        /// Return Type: BOOL->int
        ///lpRootPathName: LPCWSTR->WCHAR*
        ///lpVolumeName: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "SetVolumeLabel")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetVolumeLabel(
            [In] [MarshalAs(UnmanagedType.LPTStr)] string lpRootPathName, [In] [MarshalAs(UnmanagedType.LPTStr)] string lpVolumeName);

        /// Return Type: BOOL->int
        ///Locale: LCID->DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "SetThreadLocale")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetThreadLocale(uint Locale);

        /// Return Type: DWORD->unsigned int
        ///hDevice: HANDLE->void*
        ///dwPositionMethod: DWORD->unsigned int
        ///dwPartition: DWORD->unsigned int
        ///dwOffsetLow: DWORD->unsigned int
        ///dwOffsetHigh: DWORD->unsigned int
        ///bImmediate: BOOL->int
        [DllImport("kernel32.dll", EntryPoint = "SetTapePosition")]
        public static extern uint SetTapePosition(
            [In] IntPtr hDevice, uint dwPositionMethod, uint dwPartition, uint dwOffsetLow, uint dwOffsetHigh, [MarshalAs(UnmanagedType.Bool)] bool bImmediate);

        /// Return Type: BOOL->int
        ///hMailslot: HANDLE->void*
        ///lReadTimeout: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "SetMailslotInfo")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetMailslotInfo([In] IntPtr hMailslot, uint lReadTimeout);

        /// Return Type: BOOL->int
        ///hFile: HANDLE->void*
        ///lpCommTimeouts: LPCOMMTIMEOUTS->_COMMTIMEOUTS*
        [DllImport("kernel32.dll", EntryPoint = "SetCommTimeouts")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetCommTimeouts([In] IntPtr hFile, [In] ref COMMTIMEOUTS lpCommTimeouts);

        /// Return Type: UINT->unsigned int
        ///lpBaseAddress: LPVOID->void*
        ///dwRegionSize: SIZE_T->ULONG_PTR->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "ResetWriteWatch")]
        public static extern uint ResetWriteWatch([In] IntPtr lpBaseAddress, uint dwRegionSize);

        /// Return Type: BOOL->int
        ///hFile: HANDLE->void*
        ///aSegmentArray: FILE_SEGMENT_ELEMENT*
        ///nNumberOfBytesToRead: DWORD->unsigned int
        ///lpReserved: LPDWORD->DWORD*
        ///lpOverlapped: LPOVERLAPPED->_OVERLAPPED*
        [DllImport("kernel32.dll", EntryPoint = "ReadFileScatter")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ReadFileScatter(
            [In] IntPtr hFile, [In] ref FILE_SEGMENT_ELEMENT aSegmentArray, uint nNumberOfBytesToRead, IntPtr lpReserved, ref OVERLAPPED lpOverlapped);

        /// Return Type: DWORD->unsigned int
        ///lpDeviceName: LPCWSTR->WCHAR*
        ///lpTargetPath: LPWSTR->WCHAR*
        ///ucchMax: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "QueryDosDevice")]
        public static extern uint QueryDosDevice(
            [In] [MarshalAs(UnmanagedType.LPTStr)] string lpDeviceName, [Out] [MarshalAs(UnmanagedType.LPTStr)] StringBuilder lpTargetPath, uint ucchMax);

        /// Return Type: USHORT->unsigned short
        ///ListHead: PSLIST_HEADER->_SLIST_HEADER*
        [DllImport("kernel32.dll", EntryPoint = "QueryDepthSList")]
        public static extern ushort QueryDepthSList([In] ref SLIST_HEADER ListHead);

        /// Return Type: LPVOID->void*
        ///hFileMappingObject: HANDLE->void*
        ///dwDesiredAccess: DWORD->unsigned int
        ///dwFileOffsetHigh: DWORD->unsigned int
        ///dwFileOffsetLow: DWORD->unsigned int
        ///dwNumberOfBytesToMap: SIZE_T->ULONG_PTR->unsigned int
        ///lpBaseAddress: LPVOID->void*
        [DllImport("kernel32.dll", EntryPoint = "MapViewOfFileEx")]
        public static extern IntPtr MapViewOfFileEx(
            [In] IntPtr hFileMappingObject, uint dwDesiredAccess, uint dwFileOffsetHigh, uint dwFileOffsetLow, uint dwNumberOfBytesToMap,
            [In] IntPtr lpBaseAddress);

        /// Return Type: BOOL->int
        ///CodePage: UINT->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "IsValidCodePage")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsValidCodePage(uint CodePage);

        /// Return Type: BOOL->int
        ///lpsz: LPCWSTR->WCHAR*
        ///ucchMax: UINT_PTR->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "IsBadStringPtr")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsBadStringPtr([In] [MarshalAs(UnmanagedType.LPTStr)] string lpsz, [MarshalAs(UnmanagedType.SysUInt)] uint ucchMax);

        /// Return Type: ATOM->WORD->unsigned short
        ///lpString: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "GlobalFindAtom")]
        public static extern ushort GlobalFindAtom([In] [MarshalAs(UnmanagedType.LPTStr)] string lpString);

        /// Return Type: LCID->DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetThreadLocale")]
        public static extern uint GetThreadLocale();

        /// Return Type: DWORD->unsigned int
        ///hDevice: HANDLE->void*
        ///dwPositionType: DWORD->unsigned int
        ///lpdwPartition: LPDWORD->DWORD*
        ///lpdwOffsetLow: LPDWORD->DWORD*
        ///lpdwOffsetHigh: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "GetTapePosition")]
        public static extern uint GetTapePosition(
            [In] IntPtr hDevice, uint dwPositionType, [Out] out uint lpdwPartition, [Out] out uint lpdwOffsetLow, [Out] out uint lpdwOffsetHigh);

        /// Return Type: void
        ///lpStartupInfo: LPSTARTUPINFOW->_STARTUPINFOW*
        [DllImport("kernel32.dll", EntryPoint = "GetStartupInfo")]
        public static extern void GetStartupInfo([Out] out STARTUPINFO lpStartupInfo);

        /// Return Type: BOOL->int
        ///hProcess: HANDLE->void*
        ///lpCreationTime: LPFILETIME->_FILETIME*
        ///lpExitTime: LPFILETIME->_FILETIME*
        ///lpKernelTime: LPFILETIME->_FILETIME*
        ///lpUserTime: LPFILETIME->_FILETIME*
        [DllImport("kernel32.dll", EntryPoint = "GetProcessTimes")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetProcessTimes(
            [In] IntPtr hProcess, [Out] out FILETIME lpCreationTime, [Out] out FILETIME lpExitTime, [Out] out FILETIME lpKernelTime,
            [Out] out FILETIME lpUserTime);

        /// Return Type: DWORD->unsigned int
        ///NumberOfHeaps: DWORD->unsigned int
        ///ProcessHeaps: PHANDLE->HANDLE*
        [DllImport("kernel32.dll", EntryPoint = "GetProcessHeaps")]
        public static extern uint GetProcessHeaps(uint NumberOfHeaps, ref IntPtr ProcessHeaps);

        /// Return Type: BOOL->int
        ///hMailslot: HANDLE->void*
        ///lpMaxMessageSize: LPDWORD->DWORD*
        ///lpNextSize: LPDWORD->DWORD*
        ///lpMessageCount: LPDWORD->DWORD*
        ///lpReadTimeout: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "GetMailslotInfo")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetMailslotInfo(
            [In] IntPtr hMailslot, IntPtr lpMaxMessageSize, IntPtr lpNextSize, IntPtr lpMessageCount, IntPtr lpReadTimeout);

        /// Return Type: BOOL->int
        ///hFile: HANDLE->void*
        ///lpCommTimeouts: LPCOMMTIMEOUTS->_COMMTIMEOUTS*
        [DllImport("kernel32.dll", EntryPoint = "GetCommTimeouts")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetCommTimeouts([In] IntPtr hFile, [Out] out COMMTIMEOUTS lpCommTimeouts);

        /// Return Type: LPWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetCommandLine")]
        public static extern IntPtr GetCommandLine();

        /// Return Type: BOOL->int
        ///lpBaseAddress: LPCVOID->void*
        ///dwNumberOfBytesToFlush: SIZE_T->ULONG_PTR->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "FlushViewOfFile")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FlushViewOfFile([In] IntPtr lpBaseAddress, uint dwNumberOfBytesToFlush);

        /// Return Type: BOOL->int
        ///hFindVolume: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "FindVolumeClose")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FindVolumeClose([In] IntPtr hFindVolume);

        /// Return Type: HRSRC->HRSRC__*
        ///hModule: HMODULE->HINSTANCE->HINSTANCE__*
        ///lpType: LPCWSTR->WCHAR*
        ///lpName: LPCWSTR->WCHAR*
        ///wLanguage: WORD->unsigned short
        [DllImport("kernel32.dll", EntryPoint = "FindResourceEx")]
        public static extern IntPtr FindResourceEx(
            [In] IntPtr hModule, [In] [MarshalAs(UnmanagedType.LPTStr)] string lpType, [In] [MarshalAs(UnmanagedType.LPTStr)] string lpName, ushort wLanguage);

        /// Return Type: BOOL->int
        ///hFindVolume: HANDLE->void*
        ///lpszVolumeName: LPWSTR->WCHAR*
        ///cchBufferLength: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "FindNextVolume")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FindNextVolume(
            IntPtr hFindVolume, [Out] [MarshalAs(UnmanagedType.LPTStr)] StringBuilder lpszVolumeName, uint cchBufferLength);

        /// Return Type: BOOL->int
        ///GeoClass: GEOCLASS->DWORD->unsigned int
        ///ParentGeoId: GEOID->LONG->int
        ///lpGeoEnumProc: GEO_ENUMPROC
        [DllImport("kernel32.dll", EntryPoint = "EnumSystemGeoID")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumSystemGeoID(uint GeoClass, int ParentGeoId, GEO_ENUMPROC lpGeoEnumProc);

        /// Return Type: BOOL->int
        ///hSourceProcessHandle: HANDLE->void*
        ///hSourceHandle: HANDLE->void*
        ///hTargetProcessHandle: HANDLE->void*
        ///lpTargetHandle: LPHANDLE->HANDLE*
        ///dwDesiredAccess: DWORD->unsigned int
        ///bInheritHandle: BOOL->int
        ///dwOptions: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "DuplicateHandle")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DuplicateHandle(
            [In] IntPtr hSourceProcessHandle, [In] IntPtr hSourceHandle, [In] IntPtr hTargetProcessHandle, out IntPtr lpTargetHandle, uint dwDesiredAccess,
            [MarshalAs(UnmanagedType.Bool)] bool bInheritHandle, uint dwOptions);

        /// Return Type: BOOL->int
        ///hDevice: HANDLE->void*
        ///dwIoControlCode: DWORD->unsigned int
        ///lpInBuffer: LPVOID->void*
        ///nInBufferSize: DWORD->unsigned int
        ///lpOutBuffer: LPVOID->void*
        ///nOutBufferSize: DWORD->unsigned int
        ///lpBytesReturned: LPDWORD->DWORD*
        ///lpOverlapped: LPOVERLAPPED->_OVERLAPPED*
        [DllImport("kernel32.dll", EntryPoint = "DeviceIoControl")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DeviceIoControl(
            [In] IntPtr hDevice, uint dwIoControlCode, [In] IntPtr lpInBuffer, uint nInBufferSize, IntPtr lpOutBuffer, uint nOutBufferSize,
            IntPtr lpBytesReturned, IntPtr lpOverlapped);

        /// Return Type: HANDLE->void*
        ///lpName: LPCWSTR->WCHAR*
        ///nMaxMessageSize: DWORD->unsigned int
        ///lReadTimeout: DWORD->unsigned int
        ///lpSecurityAttributes: LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        [DllImport("kernel32.dll", EntryPoint = "CreateMailslot")]
        public static extern IntPtr CreateMailslot(
            [In] [MarshalAs(UnmanagedType.LPTStr)] string lpName, uint nMaxMessageSize, uint lReadTimeout, [In] ref SECURITY_ATTRIBUTES lpSecurityAttributes);

        /// Return Type: BOOL->int
        ///lpFileName: LPCWSTR->WCHAR*
        ///lpExistingFileName: LPCWSTR->WCHAR*
        ///lpSecurityAttributes: LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        [DllImport("kernel32.dll", EntryPoint = "CreateHardLink")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CreateHardLink(
            [In] [MarshalAs(UnmanagedType.LPTStr)] string lpFileName, [In] [MarshalAs(UnmanagedType.LPTStr)] string lpExistingFileName,
            ref SECURITY_ATTRIBUTES lpSecurityAttributes);

        /// Return Type: LONG->int
        ///lpFileTime1: FILETIME*
        ///lpFileTime2: FILETIME*
        [DllImport("kernel32.dll", EntryPoint = "CompareFileTime")]
        public static extern int CompareFileTime([In] ref FILETIME lpFileTime1, [In] ref FILETIME lpFileTime2);

        /// Return Type: BOOL->int
        [DllImport("kernel32.dll", EntryPoint = "AreFileApisANSI")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AreFileApisANSI();

        /// Return Type: BOOL->int
        ///lpNamedPipeName: LPCWSTR->WCHAR*
        ///nTimeOut: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "WaitNamedPipe")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WaitNamedPipe([In] [MarshalAs(UnmanagedType.LPTStr)] string lpNamedPipeName, uint nTimeOut);

        /// Return Type: SIZE_T->ULONG_PTR->unsigned int
        ///hProcess: HANDLE->void*
        ///lpAddress: LPCVOID->void*
        ///lpBuffer: PMEMORY_BASIC_INFORMATION->_MEMORY_BASIC_INFORMATION*
        ///dwLength: SIZE_T->ULONG_PTR->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "VirtualQueryEx")]
        public static extern uint VirtualQueryEx([In] IntPtr hProcess, [In] IntPtr lpAddress, IntPtr lpBuffer, uint dwLength);

        /// Return Type: BOOL->int
        ///lpAddress: LPVOID->void*
        ///dwSize: SIZE_T->ULONG_PTR->unsigned int
        ///flNewProtect: DWORD->unsigned int
        ///lpflOldProtect: PDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "VirtualProtect")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool VirtualProtect([In] IntPtr lpAddress, uint dwSize, uint flNewProtect, [Out] out uint lpflOldProtect);

        /// Return Type: LPVOID->void*
        ///hProcess: HANDLE->void*
        ///lpAddress: LPVOID->void*
        ///dwSize: SIZE_T->ULONG_PTR->unsigned int
        ///flAllocationType: DWORD->unsigned int
        ///flProtect: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "VirtualAllocEx")]
        public static extern IntPtr VirtualAllocEx([In] IntPtr hProcess, [In] IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

        /// Return Type: BOOL->int
        ///WaitHandle: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "UnregisterWait")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool UnregisterWait([In] IntPtr WaitHandle);

        /// Return Type: BOOL->int
        [DllImport("kernel32.dll", EntryPoint = "SwitchToThread")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SwitchToThread();

        /// Return Type: DWORD->unsigned int
        ///hModule: HMODULE->HINSTANCE->HINSTANCE__*
        ///hResInfo: HRSRC->HRSRC__*
        [DllImport("kernel32.dll", EntryPoint = "SizeofResource")]
        public static extern uint SizeofResource([In] IntPtr hModule, [In] IntPtr hResInfo);

        /// Return Type: BOOL->int
        ///Locale: LCID->DWORD->unsigned int
        ///LCType: LCTYPE->DWORD->unsigned int
        ///lpLCData: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "SetLocaleInfo")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetLocaleInfo(uint Locale, uint LCType, [In] [MarshalAs(UnmanagedType.LPTStr)] string lpLCData);

        /// Return Type: UINT->unsigned int
        ///uNumber: UINT->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "SetHandleCount")]
        public static extern uint SetHandleCount(uint uNumber);

        /// Return Type: DWORD->unsigned int
        ///hFile: HANDLE->void*
        ///lDistanceToMove: LONG->int
        ///lpDistanceToMoveHigh: PLONG->LONG*
        ///dwMoveMethod: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "SetFilePointer")]
        public static extern uint SetFilePointer([In] IntPtr hFile, int lDistanceToMove, [In] IntPtr lpDistanceToMoveHigh, uint dwMoveMethod);

        /// Return Type: BOOL->int
        ///hConsoleHandle: HANDLE->void*
        ///dwMode: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "SetConsoleMode")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetConsoleMode(IntPtr hConsoleHandle, CONSOLE_MODE dwMode);

        /// Return Type: void
        ///dwExceptionCode: DWORD->unsigned int
        ///dwExceptionFlags: DWORD->unsigned int
        ///nNumberOfArguments: DWORD->unsigned int
        ///lpArguments: ULONG_PTR*
        [DllImport("kernel32.dll", EntryPoint = "RaiseException")]
        public static extern void RaiseException(uint dwExceptionCode, EXCEPTION dwExceptionFlags, uint nNumberOfArguments, [In] IntPtr lpArguments);

        /// Return Type: HANDLE->void*
        ///dwDesiredAccess: DWORD->unsigned int
        ///bInheritHandle: BOOL->int
        ///lpName: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "OpenSemaphore")]
        public static extern IntPtr OpenSemaphore(
            uint dwDesiredAccess, [MarshalAs(UnmanagedType.Bool)] bool bInheritHandle, [In] [MarshalAs(UnmanagedType.LPTStr)] string lpName);

        /// Return Type: HANDLE->void*
        ///dwDesiredAccess: DWORD->unsigned int
        ///bInheritHandle: BOOL->int
        ///lpName: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "OpenJobObject")]
        public static extern IntPtr OpenJobObject(
            uint dwDesiredAccess, [MarshalAs(UnmanagedType.Bool)] bool bInheritHandle, [In] [MarshalAs(UnmanagedType.LPTStr)] string lpName);

        /// Return Type: HMODULE->HINSTANCE->HINSTANCE__*
        ///lpLibFileName: LPCWSTR->WCHAR*
        ///hFile: HANDLE->void*
        ///dwFlags: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "LoadLibraryEx")]
        public static extern IntPtr LoadLibraryEx([In] [MarshalAs(UnmanagedType.LPTStr)] string lpLibFileName, IntPtr hFile, LOAD_LIBRARY dwFlags);

        /// Return Type: BOOL->int
        ///hProcess: HANDLE->void*
        ///Wow64Process: PBOOL->BOOL*
        [DllImport("kernel32.dll", EntryPoint = "IsWow64Process")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsWow64Process([In] IntPtr hProcess, [Out] out int Wow64Process);

        /// Return Type: BOOL->int
        ///ProcessHandle: HANDLE->void*
        ///JobHandle: HANDLE->void*
        ///Result: PBOOL->BOOL*
        [DllImport("kernel32.dll", EntryPoint = "IsProcessInJob")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsProcessInJob([In] IntPtr ProcessHandle, [In] IntPtr JobHandle, [Out] out int Result);

        /// Return Type: BOOL->int
        ///TestChar: BYTE->unsigned char
        [DllImport("kernel32.dll", EntryPoint = "IsDBCSLeadByte")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsDBCSLeadByte(byte TestChar);

        /// Return Type: ATOM->WORD->unsigned short
        ///lpString: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "GlobalAddAtom")]
        public static extern ushort GlobalAddAtom([In] [MarshalAs(UnmanagedType.LPTStr)] string lpString);

        /// Return Type: int
        ///Locale: LCID->DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        ///lpTime: SYSTEMTIME*
        ///lpFormat: LPCWSTR->WCHAR*
        ///lpTimeStr: LPWSTR->WCHAR*
        ///cchTime: int
        [DllImport("kernel32.dll", EntryPoint = "GetTimeFormat")]
        public static extern int GetTimeFormat(
            uint Locale, TIME_FORMAT dwFlags, [In] IntPtr lpTime, [In] [MarshalAs(UnmanagedType.LPTStr)] string lpFormat,
            [Out] [MarshalAs(UnmanagedType.LPTStr)] StringBuilder lpTimeStr, int cchTime);

        /// Return Type: BOOL->int
        ///hThread: HANDLE->void*
        ///lpCreationTime: LPFILETIME->_FILETIME*
        ///lpExitTime: LPFILETIME->_FILETIME*
        ///lpKernelTime: LPFILETIME->_FILETIME*
        ///lpUserTime: LPFILETIME->_FILETIME*
        [DllImport("kernel32.dll", EntryPoint = "GetThreadTimes")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetThreadTimes(
            [In] IntPtr hThread, [Out] out FILETIME lpCreationTime, [Out] out FILETIME lpExitTime, [Out] out FILETIME lpKernelTime,
            [Out] out FILETIME lpUserTime);

        /// Return Type: BOOL->int
        ///lpIdleTime: LPFILETIME->_FILETIME*
        ///lpKernelTime: LPFILETIME->_FILETIME*
        ///lpUserTime: LPFILETIME->_FILETIME*
        [DllImport("kernel32.dll", EntryPoint = "GetSystemTimes")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetSystemTimes(IntPtr lpIdleTime, IntPtr lpKernelTime, IntPtr lpUserTime);

        /// Return Type: BOOL->int
        ///dwInfoType: DWORD->unsigned int
        ///lpSrcStr: LPCWSTR->WCHAR*
        ///cchSrc: int
        ///lpCharType: LPWORD->WORD*
        [DllImport("kernel32.dll", EntryPoint = "GetStringType")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetStringType(
            uint dwInfoType, [In] [MarshalAs(UnmanagedType.LPTStr)] string lpSrcStr, int cchSrc, [Out] out ushort lpCharType);

        /// Return Type: UINT->unsigned int
        ///lpAppName: LPCWSTR->WCHAR*
        ///lpKeyName: LPCWSTR->WCHAR*
        ///nDefault: INT->int
        [DllImport("kernel32.dll", EntryPoint = "GetProfileInt")]
        public static extern uint GetProfileInt(
            [In] [MarshalAs(UnmanagedType.LPTStr)] string lpAppName, [In] [MarshalAs(UnmanagedType.LPTStr)] string lpKeyName, int nDefault);

        /// Return Type: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "GetProcessHeap")]
        public static extern IntPtr GetProcessHeap();

        /// Return Type: FARPROC
        ///hModule: HMODULE->HINSTANCE->HINSTANCE__*
        ///lpProcName: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetProcAddress")]
        public static extern FARPROC GetProcAddress([In] IntPtr hModule, [In] [MarshalAs(UnmanagedType.LPStr)] string lpProcName);

        /// Return Type: int
        ///Locale: LCID->DWORD->unsigned int
        ///LCType: LCTYPE->DWORD->unsigned int
        ///lpLCData: LPWSTR->WCHAR*
        ///cchData: int
        [DllImport("kernel32.dll", EntryPoint = "GetLocaleInfo")]
        public static extern int GetLocaleInfo(uint Locale, uint LCType, [Out] [MarshalAs(UnmanagedType.LPTStr)] StringBuilder lpLCData, int cchData);

        /// Return Type: int
        ///Locale: LCID->DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        ///lpDate: SYSTEMTIME*
        ///lpFormat: LPCWSTR->WCHAR*
        ///lpDateStr: LPWSTR->WCHAR*
        ///cchDate: int
        [DllImport("kernel32.dll", EntryPoint = "GetDateFormat")]
        public static extern int GetDateFormat(
            uint Locale, DATE dwFlags, [In] IntPtr lpDate, [In] [MarshalAs(UnmanagedType.LPTStr)] string lpFormat,
            [Out] [MarshalAs(UnmanagedType.LPTStr)] StringBuilder lpDateStr, int cchDate);

        /// Return Type: BOOL->int
        ///hConsoleHandle: HANDLE->void*
        ///lpMode: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "GetConsoleMode")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetConsoleMode(IntPtr hConsoleHandle, ref CONSOLE_MODE lpMode);

        /// Return Type: BOOL->int
        ///lpApplicationName: LPCWSTR->WCHAR*
        ///lpBinaryType: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "GetBinaryType")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetBinaryType([In] [MarshalAs(UnmanagedType.LPTStr)] string lpApplicationName, [Out] out uint lpBinaryType);

        /// Return Type: DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        ///lpSource: LPCVOID->void*
        ///dwMessageId: DWORD->unsigned int
        ///dwLanguageId: DWORD->unsigned int
        ///lpBuffer: LPWSTR->WCHAR*
        ///nSize: DWORD->unsigned int
        ///Arguments: va_list*
        [DllImport("kernel32.dll", EntryPoint = "FormatMessage")]
        public static extern uint FormatMessage(
            FORMAT_MESSAGE dwFlags, IntPtr lpSource, uint dwMessageId, uint dwLanguageId, [MarshalAs(UnmanagedType.LPTStr)] StringBuilder lpBuffer, uint nSize,
            ref IntPtr Arguments);

        /// Return Type: HANDLE->void*
        ///lpFileName: LPCWSTR->WCHAR*
        ///lpFindFileData: LPWIN32_FIND_DATAW->_WIN32_FIND_DATAW*
        [DllImport("kernel32.dll", EntryPoint = "FindFirstFile")]
        public static extern IntPtr FindFirstFile([In] [MarshalAs(UnmanagedType.LPTStr)] string lpFileName, [Out] out WIN32_FIND_DATA lpFindFileData);

        /// Return Type: BOOL->int
        ///lpApplicationName: LPCWSTR->WCHAR*
        ///lpCommandLine: LPWSTR->WCHAR*
        ///lpProcessAttributes: LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        ///lpThreadAttributes: LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        ///bInheritHandles: BOOL->int
        ///dwCreationFlags: DWORD->unsigned int
        ///lpEnvironment: LPVOID->void*
        ///lpCurrentDirectory: LPCWSTR->WCHAR*
        ///lpStartupInfo: LPSTARTUPINFOW->_STARTUPINFOW*
        ///lpProcessInformation: LPPROCESS_INFORMATION->_PROCESS_INFORMATION*
        [DllImport("kernel32.dll", EntryPoint = "CreateProcess")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CreateProcess(
            [In] [MarshalAs(UnmanagedType.LPTStr)] string lpApplicationName, IntPtr lpCommandLine, [In] ref SECURITY_ATTRIBUTES lpProcessAttributes,
            [In] ref SECURITY_ATTRIBUTES lpThreadAttributes, [MarshalAs(UnmanagedType.Bool)] bool bInheritHandles, CREATE_PROCESS dwCreationFlags, [In] IntPtr lpEnvironment,
            [In] [MarshalAs(UnmanagedType.LPTStr)] string lpCurrentDirectory, [In] ref STARTUPINFO lpStartupInfo,
            [Out] out PROCESS_INFORMATION lpProcessInformation);

        /// Return Type: int
        ///Locale: LCID->DWORD->unsigned int
        ///dwCmpFlags: DWORD->unsigned int
        ///lpString1: LPCWSTR->WCHAR*
        ///cchCount1: int
        ///lpString2: LPCWSTR->WCHAR*
        ///cchCount2: int
        [DllImport("kernel32.dll", EntryPoint = "CompareString")]
        public static extern int CompareString(
            uint Locale, COMPARE_STRING dwCmpFlags, [In] [MarshalAs(UnmanagedType.LPTStr)] string lpString1, int cchCount1,
            [In] [MarshalAs(UnmanagedType.LPTStr)] string lpString2, int cchCount2);

        /// Return Type: BOOL->int
        ///hFile: HANDLE->void*
        ///lpErrors: LPDWORD->DWORD*
        ///lpStat: LPCOMSTAT->_COMSTAT*
        [DllImport("kernel32.dll", EntryPoint = "ClearCommError")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ClearCommError([In] IntPtr hFile, IntPtr lpErrors, IntPtr lpStat);

        /// Return Type: BOOL->int
        ///hFile: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "ClearCommBreak")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ClearCommBreak([In] IntPtr hFile);

        /// Return Type: BOOL->int
        ///lpNamedPipeName: LPCWSTR->WCHAR*
        ///lpInBuffer: LPVOID->void*
        ///nInBufferSize: DWORD->unsigned int
        ///lpOutBuffer: LPVOID->void*
        ///nOutBufferSize: DWORD->unsigned int
        ///lpBytesRead: LPDWORD->DWORD*
        ///nTimeOut: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "CallNamedPipe")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CallNamedPipe(
            [In] [MarshalAs(UnmanagedType.LPTStr)] string lpNamedPipeName, [In] IntPtr lpInBuffer, uint nInBufferSize, IntPtr lpOutBuffer, uint nOutBufferSize,
            [Out] out uint lpBytesRead, uint nTimeOut);

        /// Return Type: BOOL->int
        ///hActCtx: HANDLE->void*
        ///lpCookie: ULONG_PTR*
        [DllImport("kernel32.dll", EntryPoint = "ActivateActCtx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ActivateActCtx(IntPtr hActCtx, [Out] out uint lpCookie);

        /// Return Type: BOOL->int
        ///hActCtx: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "ZombifyActCtx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ZombifyActCtx(IntPtr hActCtx);

        /// Return Type: DWORD->unsigned int
        ///hDevice: HANDLE->void*
        ///dwTapemarkType: DWORD->unsigned int
        ///dwTapemarkCount: DWORD->unsigned int
        ///bImmediate: BOOL->int
        [DllImport("kernel32.dll", EntryPoint = "WriteTapemark")]
        public static extern uint WriteTapemark([In] IntPtr hDevice, uint dwTapemarkType, uint dwTapemarkCount, [MarshalAs(UnmanagedType.Bool)] bool bImmediate);

        /// Return Type: BOOL->int
        ///hConsoleOutput: HANDLE->void*
        ///lpBuffer: void*
        ///nNumberOfCharsToWrite: DWORD->unsigned int
        ///lpNumberOfCharsWritten: LPDWORD->DWORD*
        ///lpReserved: LPVOID->void*
        [DllImport("kernel32.dll", EntryPoint = "WriteConsole")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WriteConsole(
            IntPtr hConsoleOutput, IntPtr lpBuffer, uint nNumberOfCharsToWrite, ref uint lpNumberOfCharsWritten, IntPtr lpReserved);

        /// Return Type: BOOL->int
        ///hFile: HANDLE->void*
        ///lpEvtMask: LPDWORD->DWORD*
        ///lpOverlapped: LPOVERLAPPED->_OVERLAPPED*
        [DllImport("kernel32.dll", EntryPoint = "WaitCommEvent")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WaitCommEvent([In] IntPtr hFile, ref uint lpEvtMask, IntPtr lpOverlapped);

        /// Return Type: BOOL->int
        ///lpAddress: LPVOID->void*
        ///dwSize: SIZE_T->ULONG_PTR->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "VirtualUnlock")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool VirtualUnlock([In] IntPtr lpAddress, uint dwSize);

        /// Return Type: BOOL->int
        ///hProcess: HANDLE->void*
        ///lpAddress: LPVOID->void*
        ///dwSize: SIZE_T->ULONG_PTR->unsigned int
        ///dwFreeType: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "VirtualFreeEx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool VirtualFreeEx([In] IntPtr hProcess, [In] IntPtr lpAddress, uint dwSize, uint dwFreeType);

        /// Return Type: void
        ///lpFiber: LPVOID->void*
        [DllImport("kernel32.dll", EntryPoint = "SwitchToFiber")]
        public static extern void SwitchToFiber([In] IntPtr lpFiber);

        /// Return Type: DWORD->unsigned int
        ///hThread: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "SuspendThread")]
        public static extern uint SuspendThread([In] IntPtr hThread);

        /// Return Type: BOOL->int
        ///lpSystemTime: SYSTEMTIME*
        [DllImport("kernel32.dll", EntryPoint = "SetSystemTime")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetSystemTime([In] ref SYSTEMTIME lpSystemTime);

        /// Return Type: BOOL->int
        ///hCommDev: HANDLE->void*
        ///lpCC: LPCOMMCONFIG->_COMMCONFIG*
        ///dwSize: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "SetCommConfig")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetCommConfig([In] IntPtr hCommDev, [In] IntPtr lpCC, uint dwSize);

        /// Return Type: void
        ///hActCtx: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "ReleaseActCtx")]
        public static extern void ReleaseActCtx(IntPtr hActCtx);

        /// Return Type: BOOL->int
        ///hNamedPipe: HANDLE->void*
        ///lpBuffer: LPVOID->void*
        ///nBufferSize: DWORD->unsigned int
        ///lpBytesRead: LPDWORD->DWORD*
        ///lpTotalBytesAvail: LPDWORD->DWORD*
        ///lpBytesLeftThisMessage: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "PeekNamedPipe")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PeekNamedPipe(
            [In] IntPtr hNamedPipe, IntPtr lpBuffer, uint nBufferSize, IntPtr lpBytesRead, IntPtr lpTotalBytesAvail, IntPtr lpBytesLeftThisMessage);

        /// Return Type: LPVOID->void*
        ///hFileMappingObject: HANDLE->void*
        ///dwDesiredAccess: DWORD->unsigned int
        ///dwFileOffsetHigh: DWORD->unsigned int
        ///dwFileOffsetLow: DWORD->unsigned int
        ///dwNumberOfBytesToMap: SIZE_T->ULONG_PTR->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "MapViewOfFile")]
        public static extern IntPtr MapViewOfFile(
            [In] IntPtr hFileMappingObject, uint dwDesiredAccess, uint dwFileOffsetHigh, uint dwFileOffsetLow, uint dwNumberOfBytesToMap);

        /// Return Type: BOOL->int
        ///Locale: LCID->DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "IsValidLocale")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsValidLocale(uint Locale, LCID dwFlags);

        /// Return Type: BOOL->int
        ///lp: LPVOID->void*
        ///ucb: UINT_PTR->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "IsBadWritePtr")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsBadWritePtr([In] IntPtr lp, [MarshalAs(UnmanagedType.SysUInt)] uint ucb);

        /// Return Type: BOOL->int
        ///nSize: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "InitAtomTable")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool InitAtomTable(uint nSize);

        /// Return Type: HGLOBAL->HANDLE->void*
        ///hMem: HGLOBAL->HANDLE->void*
        ///dwBytes: SIZE_T->ULONG_PTR->unsigned int
        ///uFlags: UINT->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GlobalReAlloc")]
        public static extern IntPtr GlobalReAlloc([In] IntPtr hMem, uint dwBytes, GMEM uFlags);

        /// Return Type: SIZE_T->ULONG_PTR->unsigned int
        ///dwMinFree: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GlobalCompact")]
        public static extern uint GlobalCompact(uint dwMinFree);

        /// Return Type: UINT->unsigned int
        ///dwFlags: DWORD->unsigned int
        ///lpBaseAddress: PVOID->void*
        ///dwRegionSize: SIZE_T->ULONG_PTR->unsigned int
        ///lpAddresses: PVOID*
        ///lpdwCount: ULONG_PTR*
        ///lpdwGranularity: PULONG->ULONG*
        [DllImport("kernel32.dll", EntryPoint = "GetWriteWatch")]
        public static extern uint GetWriteWatch(
            WRITE_WATCH dwFlags, [In] IntPtr lpBaseAddress, uint dwRegionSize, ref IntPtr lpAddresses, ref uint lpdwCount, [Out] out uint lpdwGranularity);

        /// Return Type: BOOL->int
        ///lpVersionInformation: LPOSVERSIONINFOW->_OSVERSIONINFOW*
        [DllImport("kernel32.dll", EntryPoint = "GetVersionEx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetVersionEx(ref RTL_OSVERSIONINFO lpVersionInformation);

        /// Return Type: DWORD->unsigned int
        ///hDevice: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "GetTapeStatus")]
        public static extern uint GetTapeStatus([In] IntPtr hDevice);

        /// Return Type: void
        ///lpSystemTime: LPSYSTEMTIME->_SYSTEMTIME*
        [DllImport("kernel32.dll", EntryPoint = "GetSystemTime")]
        public static extern void GetSystemTime([Out] out SYSTEMTIME lpSystemTime);

        /// Return Type: void
        ///lpSystemInfo: LPSYSTEM_INFO->_SYSTEM_INFO*
        [DllImport("kernel32.dll", EntryPoint = "GetSystemInfo")]
        public static extern void GetSystemInfo([Out] out SYSTEM_INFO lpSystemInfo);

        /// Return Type: BOOL->int
        ///hFile: HANDLE->void*
        ///lpFileSize: PLARGE_INTEGER->LARGE_INTEGER*
        [DllImport("kernel32.dll", EntryPoint = "GetFileSizeEx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetFileSizeEx([In] IntPtr hFile, [Out] out LARGE_INTEGER lpFileSize);

        /// Return Type: UINT->unsigned int
        ///lpRootPathName: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetDriveType")]
        public static extern uint GetDriveType([In] [MarshalAs(UnmanagedType.LPTStr)] string lpRootPathName);

        /// Return Type: BOOL->int
        ///hCommDev: HANDLE->void*
        ///lpCC: LPCOMMCONFIG->_COMMCONFIG*
        ///lpdwSize: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "GetCommConfig")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetCommConfig([In] IntPtr hCommDev, IntPtr lpCC, ref uint lpdwSize);

        /// Return Type: HRSRC->HRSRC__*
        ///hModule: HMODULE->HINSTANCE->HINSTANCE__*
        ///lpName: LPCWSTR->WCHAR*
        ///lpType: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "FindResource")]
        public static extern IntPtr FindResource(
            [In] IntPtr hModule, [In] [MarshalAs(UnmanagedType.LPTStr)] string lpName, [In] [MarshalAs(UnmanagedType.LPTStr)] string lpType);

        /// Return Type: BOOL->int
        ///hFindFile: HANDLE->void*
        ///lpFindFileData: LPWIN32_FIND_DATAW->_WIN32_FIND_DATAW*
        [DllImport("kernel32.dll", EntryPoint = "FindNextFile")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FindNextFile([In] IntPtr hFindFile, [Out] out WIN32_FIND_DATA lpFindFileData);

        /// Return Type: void
        ///uAction: UINT->unsigned int
        ///lpMessageText: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "FatalAppExit")]
        public static extern void FatalAppExit(uint uAction, [In] [MarshalAs(UnmanagedType.LPTStr)] string lpMessageText);

        /// Return Type: PVOID->void*
        ///Ptr: PVOID->void*
        [DllImport("kernel32.dll", EntryPoint = "EncodePointer")]
        public static extern IntPtr EncodePointer([In] IntPtr Ptr);

        /// Return Type: PVOID->void*
        ///Ptr: PVOID->void*
        [DllImport("kernel32.dll", EntryPoint = "DecodePointer")]
        public static extern IntPtr DecodePointer([In] IntPtr Ptr);

        /// Return Type: LPVOID->void*
        ///dwStackCommitSize: SIZE_T->ULONG_PTR->unsigned int
        ///dwStackReserveSize: SIZE_T->ULONG_PTR->unsigned int
        ///dwFlags: DWORD->unsigned int
        ///lpStartAddress: LPFIBER_START_ROUTINE->PFIBER_START_ROUTINE
        ///lpParameter: LPVOID->void*
        [DllImport("kernel32.dll", EntryPoint = "CreateFiberEx")]
        public static extern IntPtr CreateFiberEx(
            uint dwStackCommitSize, uint dwStackReserveSize, FIBER_FLAG dwFlags, PFIBER_START_ROUTINE lpStartAddress, [In] IntPtr lpParameter);

        /// Return Type: HANDLE->void*
        ///pActCtx: PCACTCTXW->ACTCTXW*
        [DllImport("kernel32.dll", EntryPoint = "CreateActCtx")]
        public static extern IntPtr CreateActCtx([In] ref ACTCTX pActCtx);

        /// Return Type: BOOL->int
        ///lpDef: LPCWSTR->WCHAR*
        ///lpDCB: LPDCB->_DCB*
        [DllImport("kernel32.dll", EntryPoint = "BuildCommDCB")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool BuildCommDCB([In] [MarshalAs(UnmanagedType.LPTStr)] string lpDef, [Out] out DCB lpDCB);

        /// Return Type: BOOL->int
        ///dwProcessId: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "AttachConsole")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AttachConsole(uint dwProcessId);

        /// Return Type: SIZE_T->ULONG_PTR->unsigned int
        ///lpAddress: LPCVOID->void*
        ///lpBuffer: PMEMORY_BASIC_INFORMATION->_MEMORY_BASIC_INFORMATION*
        ///dwLength: SIZE_T->ULONG_PTR->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "VirtualQuery")]
        public static extern uint VirtualQuery([In] IntPtr lpAddress, IntPtr lpBuffer, uint dwLength);

        /// Return Type: LPVOID->void*
        ///lpAddress: LPVOID->void*
        ///dwSize: SIZE_T->ULONG_PTR->unsigned int
        ///flAllocationType: DWORD->unsigned int
        ///flProtect: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "VirtualAlloc")]
        public static extern IntPtr VirtualAlloc([In] IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

        /// Return Type: BOOL->int
        ///hFile: HANDLE->void*
        ///dwReserved: DWORD->unsigned int
        ///nNumberOfBytesToUnlockLow: DWORD->unsigned int
        ///nNumberOfBytesToUnlockHigh: DWORD->unsigned int
        ///lpOverlapped: LPOVERLAPPED->_OVERLAPPED*
        [DllImport("kernel32.dll", EntryPoint = "UnlockFileEx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool UnlockFileEx(
            [In] IntPtr hFile, uint dwReserved, uint nNumberOfBytesToUnlockLow, uint nNumberOfBytesToUnlockHigh, ref OVERLAPPED lpOverlapped);

        /// Return Type: BOOL->int
        ///GeoId: GEOID->LONG->int
        [DllImport("kernel32.dll", EntryPoint = "SetUserGeoID")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetUserGeoID(int GeoId);

        /// Return Type: BOOL->int
        ///nStdHandle: DWORD->unsigned int
        ///hHandle: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "SetStdHandle")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetStdHandle(uint nStdHandle, [In] IntPtr hHandle);

        /// Return Type: BOOL->int
        ///lpSystemTime: SYSTEMTIME*
        [DllImport("kernel32.dll", EntryPoint = "SetLocalTime")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetLocalTime([In] ref SYSTEMTIME lpSystemTime);

        /// Return Type: void
        ///dwErrCode: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "SetLastError")]
        public static extern void SetLastError(uint dwErrCode);

        /// Return Type: UINT->unsigned int
        ///uMode: UINT->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "SetErrorMode")]
        public static extern uint SetErrorMode(uint uMode);

        /// Return Type: BOOL->int
        ///hFile: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "SetEndOfFile")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetEndOfFile([In] IntPtr hFile);

        /// Return Type: BOOL->int
        ///wCodePageID: UINT->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "SetConsoleCP")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetConsoleCP(uint wCodePageID);

        /// Return Type: BOOL->int
        ///hFile: HANDLE->void*
        ///lpDCB: LPDCB->_DCB*
        [DllImport("kernel32.dll", EntryPoint = "SetCommState")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetCommState([In] IntPtr hFile, [In] ref DCB lpDCB);

        /// Return Type: BOOL->int
        ///hFile: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "SetCommBreak")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetCommBreak([In] IntPtr hFile);

        /// Return Type: DWORD->unsigned int
        ///hThread: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "ResumeThread")]
        public static extern uint ResumeThread([In] IntPtr hThread);

        /// Return Type: BOOL->int
        ///lpReplacedFileName: LPCWSTR->WCHAR*
        ///lpReplacementFileName: LPCWSTR->WCHAR*
        ///lpBackupFileName: LPCWSTR->WCHAR*
        ///dwReplaceFlags: DWORD->unsigned int
        ///lpExclude: LPVOID->void*
        ///lpReserved: LPVOID->void*
        [DllImport("kernel32.dll", EntryPoint = "ReplaceFile")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ReplaceFile(
            [In] [MarshalAs(UnmanagedType.LPTStr)] string lpReplacedFileName, [In] [MarshalAs(UnmanagedType.LPTStr)] string lpReplacementFileName,
            [In] [MarshalAs(UnmanagedType.LPTStr)] string lpBackupFileName, REPLACEFILE dwReplaceFlags, IntPtr lpExclude, IntPtr lpReserved);

        /// Return Type: BOOL->int
        ///hMutex: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "ReleaseMutex")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ReleaseMutex([In] IntPtr hMutex);

        /// Return Type: BOOL->int
        ///hConsoleInput: HANDLE->void*
        ///lpBuffer: LPVOID->void*
        ///nNumberOfCharsToRead: DWORD->unsigned int
        ///lpNumberOfCharsRead: LPDWORD->DWORD*
        ///lpReserved: LPVOID->void*
        [DllImport("kernel32.dll", EntryPoint = "ReadConsole")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ReadConsole(
            IntPtr hConsoleInput, [MarshalAs(UnmanagedType.LPTStr)] out StringBuilder lpBuffer, uint nNumberOfCharsToRead, ref uint lpNumberOfCharsRead, IntPtr lpReserved);

        /// Return Type: DWORD->unsigned int
        ///pfnAPC: PAPCFUNC
        ///hThread: HANDLE->void*
        ///dwData: ULONG_PTR->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "QueueUserAPC")]
        public static extern uint QueueUserAPC(PAPCFUNC pfnAPC, [In] IntPtr hThread, uint dwData);

        /// Return Type: BOOL->int
        ///dwFlags: DWORD->unsigned int
        ///hActCtx: HANDLE->void*
        ///pvSubInstance: PVOID->void*
        ///ulInfoClass: ULONG->unsigned int
        ///pvBuffer: PVOID->void*
        ///cbBuffer: SIZE_T->ULONG_PTR->unsigned int
        ///pcbWrittenOrRequired: SIZE_T*
        [DllImport("kernel32.dll", EntryPoint = "QueryActCtx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool QueryActCtx(
            uint dwFlags, [In] IntPtr hActCtx, [In] IntPtr pvSubInstance, uint ulInfoClass, IntPtr pvBuffer, uint cbBuffer, IntPtr pcbWrittenOrRequired);

        /// Return Type: LPVOID->void*
        ///hResData: HGLOBAL->HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "LockResource")]
        public static extern IntPtr LockResource([In] IntPtr hResData);

        /// Return Type: HLOCAL->HANDLE->void*
        ///hMem: HLOCAL->HANDLE->void*
        ///uBytes: SIZE_T->ULONG_PTR->unsigned int
        ///uFlags: UINT->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "LocalReAlloc")]
        public static extern IntPtr LocalReAlloc([In] IntPtr hMem, uint uBytes, LMEM uFlags);

        /// Return Type: SIZE_T->ULONG_PTR->unsigned int
        ///uMinFree: UINT->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "LocalCompact")]
        public static extern uint LocalCompact(uint uMinFree);

        /// Return Type: HGLOBAL->HANDLE->void*
        ///hModule: HMODULE->HINSTANCE->HINSTANCE__*
        ///hResInfo: HRSRC->HRSRC__*
        [DllImport("kernel32.dll", EntryPoint = "LoadResource")]
        public static extern IntPtr LoadResource([In] IntPtr hModule, [In] IntPtr hResInfo);

        /// Return Type: HMODULE->HINSTANCE->HINSTANCE__*
        ///lpLibFileName: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "LoadLibrary")]
        public static extern IntPtr LoadLibrary([In] [MarshalAs(UnmanagedType.LPTStr)] string lpLibFileName);

        /// Return Type: int
        ///Locale: LCID->DWORD->unsigned int
        ///dwMapFlags: DWORD->unsigned int
        ///lpSrcStr: LPCWSTR->WCHAR*
        ///cchSrc: int
        ///lpDestStr: LPWSTR->WCHAR*
        ///cchDest: int
        [DllImport("kernel32.dll", EntryPoint = "LCMapString")]
        public static extern int LCMapString(
            uint Locale, LCMAP dwMapFlags, [In] [MarshalAs(UnmanagedType.LPTStr)] string lpSrcStr, int cchSrc,
            [Out] [MarshalAs(UnmanagedType.LPTStr)] StringBuilder lpDestStr, int cchDest);

        /// Return Type: BOOL->int
        ///lp: void*
        ///ucb: UINT_PTR->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "IsBadReadPtr")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsBadReadPtr([In] IntPtr lp, [MarshalAs(UnmanagedType.SysUInt)] uint ucb);

        /// Return Type: BOOL->int
        ///lpfn: FARPROC
        [DllImport("kernel32.dll", EntryPoint = "IsBadCodePtr")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsBadCodePtr(FARPROC lpfn);

        /// Return Type: BOOL->int
        ///hHeap: HANDLE->void*
        ///dwFlags: DWORD->unsigned int
        ///lpMem: LPCVOID->void*
        [DllImport("kernel32.dll", EntryPoint = "HeapValidate")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool HeapValidate([In] IntPtr hHeap, HEAP dwFlags, [In] IntPtr lpMem);

        /// Return Type: BOOL->int
        ///hMem: HGLOBAL->HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "GlobalUnWire")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GlobalUnWire([In] IntPtr hMem);

        /// Return Type: BOOL->int
        ///hMem: HGLOBAL->HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "GlobalUnlock")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GlobalUnlock([In] IntPtr hMem);

        /// Return Type: HGLOBAL->HANDLE->void*
        ///pMem: LPCVOID->void*
        [DllImport("kernel32.dll", EntryPoint = "GlobalHandle")]
        public static extern IntPtr GlobalHandle([In] IntPtr pMem);

        /// Return Type: GEOID->LONG->int
        ///GeoClass: GEOCLASS->DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetUserGeoID")]
        public static extern int GetUserGeoID(uint GeoClass);

        /// Return Type: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetTickCount")]
        public static extern uint GetTickCount();

        /// Return Type: DWORD->unsigned int
        ///nBufferLength: DWORD->unsigned int
        ///lpBuffer: LPWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetTempPath")]
        public static extern uint GetTempPath(uint nBufferLength, [Out] [MarshalAs(UnmanagedType.LPTStr)] StringBuilder lpBuffer);

        /// Return Type: HANDLE->void*
        ///nStdHandle: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetStdHandle")]
        public static extern IntPtr GetStdHandle(uint nStdHandle);

        /// Return Type: DWORD->unsigned int
        ///Process: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "GetProcessId")]
        public static extern uint GetProcessId([In] IntPtr Process);

        /// Return Type: void
        ///lpSystemTime: LPSYSTEMTIME->_SYSTEMTIME*
        [DllImport("kernel32.dll", EntryPoint = "GetLocalTime")]
        public static extern void GetLocalTime([Out] out SYSTEMTIME lpSystemTime);

        /// Return Type: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetLastError")]
        public static extern uint GetLastError();

        /// Return Type: BOOL->int
        ///CodePage: UINT->unsigned int
        ///dwFlags: DWORD->unsigned int
        ///lpCPInfoEx: LPCPINFOEXW->_cpinfoexW*
        [DllImport("kernel32.dll", EntryPoint = "GetCPInfoEx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetCPInfoEx(uint CodePage, USE_CP dwFlags, [Out] out CPINFOEX lpCPInfoEx);

        /// Return Type: UINT->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetConsoleCP")]
        public static extern uint GetConsoleCP();

        /// Return Type: BOOL->int
        ///hFile: HANDLE->void*
        ///lpDCB: LPDCB->_DCB*
        [DllImport("kernel32.dll", EntryPoint = "GetCommState")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetCommState([In] IntPtr hFile, [Out] out DCB lpDCB);

        /// Return Type: UINT->unsigned int
        ///nAtom: ATOM->WORD->unsigned short
        ///lpBuffer: LPWSTR->WCHAR*
        ///nSize: int
        [DllImport("kernel32.dll", EntryPoint = "GetAtomName")]
        public static extern uint GetAtomName(ushort nAtom, [Out] [MarshalAs(UnmanagedType.LPTStr)] StringBuilder lpBuffer, int nSize);

        /// Return Type: BOOL->int
        ///hResData: HGLOBAL->HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "FreeResource")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FreeResource([In] IntPtr hResData);

        /// Return Type: HANDLE->void*
        ///lpThreadAttributes: LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        ///dwStackSize: SIZE_T->ULONG_PTR->unsigned int
        ///lpStartAddress: LPTHREAD_START_ROUTINE->PTHREAD_START_ROUTINE
        ///lpParameter: LPVOID->void*
        ///dwCreationFlags: DWORD->unsigned int
        ///lpThreadId: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "CreateThread")]
        public static extern IntPtr CreateThread(
            [In] ref SECURITY_ATTRIBUTES lpThreadAttributes, uint dwStackSize, PTHREAD_START_ROUTINE lpStartAddress, [In] IntPtr lpParameter, THREAD dwCreationFlags,
            IntPtr lpThreadId);

        /// Return Type: HANDLE->void*
        ///lpMutexAttributes: LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        ///bInitialOwner: BOOL->int
        ///lpName: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "CreateMutex")]
        public static extern IntPtr CreateMutex(
            [In] ref SECURITY_ATTRIBUTES lpMutexAttributes, [MarshalAs(UnmanagedType.Bool)] bool bInitialOwner, [In] [MarshalAs(UnmanagedType.LPTStr)] string lpName);

        /// Return Type: BOOL->int
        ///NumJob: ULONG->unsigned int
        ///UserJobSet: PJOB_SET_ARRAY->_JOB_SET_ARRAY*
        ///Flags: ULONG->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "CreateJobSet")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CreateJobSet(
            uint NumJob, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 0)] JOB_SET_ARRAY[] UserJobSet, uint Flags);

        /// Return Type: HANDLE->void*
        ///lpEventAttributes: LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        ///bManualReset: BOOL->int
        ///bInitialState: BOOL->int
        ///lpName: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "CreateEvent")]
        public static extern IntPtr CreateEvent(
            [In] ref SECURITY_ATTRIBUTES lpEventAttributes, [MarshalAs(UnmanagedType.Bool)] bool bManualReset, [MarshalAs(UnmanagedType.Bool)] bool bInitialState,
            [In] [MarshalAs(UnmanagedType.LPTStr)] string lpName);

        /// Return Type: BOOL->int
        [DllImport("kernel32.dll", EntryPoint = "AllocConsole")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AllocConsole();

        /// Return Type: void
        ///hActCtx: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "AddRefActCtx")]
        public static extern void AddRefActCtx(IntPtr hActCtx);

        /// Return Type: BOOL->int
        ///hFile: HANDLE->void*
        ///lpBuffer: LPCVOID->void*
        ///nNumberOfBytesToWrite: DWORD->unsigned int
        ///lpOverlapped: LPOVERLAPPED->_OVERLAPPED*
        ///lpCompletionRoutine: LPOVERLAPPED_COMPLETION_ROUTINE
        [DllImport("kernel32.dll", EntryPoint = "WriteFileEx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WriteFileEx(
            [In] IntPtr hFile, [In] IntPtr lpBuffer, uint nNumberOfBytesToWrite, ref OVERLAPPED lpOverlapped,
            LPOVERLAPPED_COMPLETION_ROUTINE lpCompletionRoutine);

        /// Return Type: BOOL->int
        ///lpAddress: LPVOID->void*
        ///dwSize: SIZE_T->ULONG_PTR->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "VirtualLock")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool VirtualLock([In] IntPtr lpAddress, uint dwSize);

        /// Return Type: BOOL->int
        ///lpAddress: LPVOID->void*
        ///dwSize: SIZE_T->ULONG_PTR->unsigned int
        ///dwFreeType: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "VirtualFree")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool VirtualFree([In] IntPtr lpAddress, uint dwSize, uint dwFreeType);

        /// Return Type: BOOL->int
        ///dwTlsIndex: DWORD->unsigned int
        ///lpTlsValue: LPVOID->void*
        [DllImport("kernel32.dll", EntryPoint = "TlsSetValue")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool TlsSetValue(uint dwTlsIndex, [In] IntPtr lpTlsValue);

        /// Return Type: LPVOID->void*
        ///dwTlsIndex: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "TlsGetValue")]
        public static extern IntPtr TlsGetValue(uint dwTlsIndex);

        /// Return Type: BOOL->int
        ///hFile: HANDLE->void*
        ///lpCreationTime: FILETIME*
        ///lpLastAccessTime: FILETIME*
        ///lpLastWriteTime: FILETIME*
        [DllImport("kernel32.dll", EntryPoint = "SetFileTime")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetFileTime([In] IntPtr hFile, [In] IntPtr lpCreationTime, [In] IntPtr lpLastAccessTime, [In] IntPtr lpLastWriteTime);

        /// Return Type: BOOL->int
        ///hFile: HANDLE->void*
        ///dwEvtMask: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "SetCommMask")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetCommMask([In] IntPtr hFile, uint dwEvtMask);

        /// Return Type: DWORD->unsigned int
        ///lpPath: LPCWSTR->WCHAR*
        ///lpFileName: LPCWSTR->WCHAR*
        ///lpExtension: LPCWSTR->WCHAR*
        ///nBufferLength: DWORD->unsigned int
        ///lpBuffer: LPWSTR->WCHAR*
        ///lpFilePart: LPWSTR*
        [DllImport("kernel32.dll", EntryPoint = "SearchPath")]
        public static extern uint SearchPath(
            [In] [MarshalAs(UnmanagedType.LPTStr)] string lpPath, [In] [MarshalAs(UnmanagedType.LPTStr)] string lpFileName,
            [In] [MarshalAs(UnmanagedType.LPTStr)] string lpExtension, uint nBufferLength, [Out] [MarshalAs(UnmanagedType.LPTStr)] StringBuilder lpBuffer,
            ref IntPtr lpFilePart);

        /// Return Type: DWORD->unsigned int
        ///hDevice: HANDLE->void*
        ///dwOperation: DWORD->unsigned int
        ///bImmediate: BOOL->int
        [DllImport("kernel32.dll", EntryPoint = "PrepareTape")]
        public static extern uint PrepareTape([In] IntPtr hDevice, uint dwOperation, [MarshalAs(UnmanagedType.Bool)] bool bImmediate);

        /// Return Type: HANDLE->void*
        ///dwDesiredAccess: DWORD->unsigned int
        ///bInheritHandle: BOOL->int
        ///dwProcessId: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "OpenProcess")]
        public static extern IntPtr OpenProcess(uint dwDesiredAccess, [MarshalAs(UnmanagedType.Bool)] bool bInheritHandle, uint dwProcessId);

        /// Return Type: BOOL->int
        ///lpExistingFileName: LPCWSTR->WCHAR*
        ///lpNewFileName: LPCWSTR->WCHAR*
        ///dwFlags: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "MoveFileEx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool MoveFileEx(
            [In] [MarshalAs(UnmanagedType.LPTStr)] string lpExistingFileName, [In] [MarshalAs(UnmanagedType.LPTStr)] string lpNewFileName, MOVEFILE dwFlags);

        /// Return Type: INT->int
        ///param0: LPWSTR->WCHAR*
        ///param1: LPOFSTRUCT->_OFSTRUCT*
        ///param2: WORD->unsigned short
        [DllImport("kernel32.dll", EntryPoint = "LZOpenFile")]
        public static extern int LZOpenFile([MarshalAs(UnmanagedType.LPTStr)] StringBuilder param0, ref OFSTRUCT param1, ushort param2);

        /// Return Type: BOOL->int
        ///hMem: HLOCAL->HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "LocalUnlock")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool LocalUnlock([In] IntPtr hMem);

        /// Return Type: SIZE_T->ULONG_PTR->unsigned int
        ///hMem: HLOCAL->HANDLE->void*
        ///cbNewSize: UINT->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "LocalShrink")]
        public static extern uint LocalShrink([In] IntPtr hMem, uint cbNewSize);

        /// Return Type: HLOCAL->HANDLE->void*
        ///pMem: LPCVOID->void*
        [DllImport("kernel32.dll", EntryPoint = "LocalHandle")]
        public static extern IntPtr LocalHandle([In] IntPtr pMem);

        /// Return Type: LPVOID->void*
        ///hHeap: HANDLE->void*
        ///dwFlags: DWORD->unsigned int
        ///lpMem: LPVOID->void*
        ///dwBytes: SIZE_T->ULONG_PTR->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "HeapReAlloc")]
        public static extern IntPtr HeapReAlloc(IntPtr hHeap, HEAP dwFlags, IntPtr lpMem, uint dwBytes);

        /// Return Type: BOOL->int
        ///hHeap: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "HeapDestroy")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool HeapDestroy([In] IntPtr hHeap);

        /// Return Type: SIZE_T->ULONG_PTR->unsigned int
        ///hHeap: HANDLE->void*
        ///dwFlags: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "HeapCompact")]
        public static extern uint HeapCompact([In] IntPtr hHeap, HEAP dwFlags);

        /// Return Type: void
        ///hMem: HGLOBAL->HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "GlobalUnfix")]
        public static extern void GlobalUnfix([In] IntPtr hMem);

        /// Return Type: UINT->unsigned int
        ///hMem: HGLOBAL->HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "GlobalFlags")]
        public static extern uint GlobalFlags([In] IntPtr hMem);

        /// Return Type: HGLOBAL->HANDLE->void*
        ///uFlags: UINT->unsigned int
        ///dwBytes: SIZE_T->ULONG_PTR->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GlobalAlloc")]
        public static extern IntPtr GlobalAlloc(GMEM uFlags, uint dwBytes);

        /// Return Type: int
        ///Location: GEOID->LONG->int
        ///GeoType: GEOTYPE->DWORD->unsigned int
        ///lpGeoData: LPWSTR->WCHAR*
        ///cchData: int
        ///LangId: LANGID->WORD->unsigned short
        [DllImport("kernel32.dll", EntryPoint = "GetGeoInfo")]
        public static extern int GetGeoInfo(
            int Location, uint GeoType, [Out] [MarshalAs(UnmanagedType.LPTStr)] StringBuilder lpGeoData, int cchData, ushort LangId);

        /// Return Type: DWORD->unsigned int
        ///hFile: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "GetFileType")]
        public static extern uint GetFileType([In] IntPtr hFile);

        /// Return Type: BOOL->int
        ///hFile: HANDLE->void*
        ///lpCreationTime: LPFILETIME->_FILETIME*
        ///lpLastAccessTime: LPFILETIME->_FILETIME*
        ///lpLastWriteTime: LPFILETIME->_FILETIME*
        [DllImport("kernel32.dll", EntryPoint = "GetFileTime")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetFileTime([In] IntPtr hFile, IntPtr lpCreationTime, IntPtr lpLastAccessTime, IntPtr lpLastWriteTime);

        /// Return Type: DWORD->unsigned int
        ///hFile: HANDLE->void*
        ///lpFileSizeHigh: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "GetFileSize")]
        public static extern uint GetFileSize([In] IntPtr hFile, IntPtr lpFileSizeHigh);

        /// Return Type: BOOL->int
        ///hFile: HANDLE->void*
        ///lpEvtMask: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "GetCommMask")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetCommMask([In] IntPtr hFile, [Out] out uint lpEvtMask);

        /// Return Type: BOOL->int
        ///hLibModule: HMODULE->HINSTANCE->HINSTANCE__*
        [DllImport("kernel32.dll", EntryPoint = "FreeLibrary")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FreeLibrary([In] IntPtr hLibModule);

        /// Return Type: BOOL->int
        [DllImport("kernel32.dll", EntryPoint = "FreeConsole")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FreeConsole();

        /// Return Type: int
        ///dwMapFlags: DWORD->unsigned int
        ///lpSrcStr: LPCWSTR->WCHAR*
        ///cchSrc: int
        ///lpDestStr: LPWSTR->WCHAR*
        ///cchDest: int
        [DllImport("kernel32.dll", EntryPoint = "FoldString")]
        public static extern int FoldString(
            MAP dwMapFlags, [In] [MarshalAs(UnmanagedType.LPTStr)] string lpSrcStr, int cchSrc, [Out] [MarshalAs(UnmanagedType.LPTStr)] StringBuilder lpDestStr,
            int cchDest);

        /// Return Type: void
        ///uExitCode: UINT->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "ExitProcess")]
        public static extern void ExitProcess(uint uExitCode);

        /// Return Type: BOOL->int
        ///lpFileName: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "DeleteFile")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DeleteFile([In] [MarshalAs(UnmanagedType.LPTStr)] string lpFileName);

        /// Return Type: void
        ///lpFiber: LPVOID->void*
        [DllImport("kernel32.dll", EntryPoint = "DeleteFiber")]
        public static extern void DeleteFiber([In] IntPtr lpFiber);

        /// Return Type: HANDLE->void*
        ///lpFileName: LPCWSTR->WCHAR*
        ///dwDesiredAccess: DWORD->unsigned int
        ///dwShareMode: DWORD->unsigned int
        ///lpSecurityAttributes: LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        ///dwCreationDisposition: DWORD->unsigned int
        ///dwFlagsAndAttributes: DWORD->unsigned int
        ///hTemplateFile: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "CreateFile")]
        public static extern IntPtr CreateFile(
            [In] [MarshalAs(UnmanagedType.LPTStr)] string lpFileName, uint dwDesiredAccess, FILE_SHARE dwShareMode, [In] IntPtr lpSecurityAttributes,
            uint dwCreationDisposition, FILE_CREATE dwFlagsAndAttributes, [In] IntPtr hTemplateFile);

        /// Return Type: LPVOID->void*
        ///dwStackSize: SIZE_T->ULONG_PTR->unsigned int
        ///lpStartAddress: LPFIBER_START_ROUTINE->PFIBER_START_ROUTINE
        ///lpParameter: LPVOID->void*
        [DllImport("kernel32.dll", EntryPoint = "CreateFiber")]
        public static extern IntPtr CreateFiber(uint dwStackSize, PFIBER_START_ROUTINE lpStartAddress, [In] IntPtr lpParameter);

        /// Return Type: BOOL->int
        ///lpExistingFileName: LPCWSTR->WCHAR*
        ///lpNewFileName: LPCWSTR->WCHAR*
        ///lpProgressRoutine: LPPROGRESS_ROUTINE
        ///lpData: LPVOID->void*
        ///pbCancel: LPBOOL->BOOL*
        ///dwCopyFlags: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "CopyFileEx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CopyFileEx(
            [In] [MarshalAs(UnmanagedType.LPTStr)] string lpExistingFileName, [In] [MarshalAs(UnmanagedType.LPTStr)] string lpNewFileName,
            LPPROGRESS_ROUTINE lpProgressRoutine, [In] IntPtr lpData, [In] IntPtr pbCancel, COPY_FILE dwCopyFlags);

        /// Return Type: BOOL->int
        ///hObject: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "CloseHandle")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CloseHandle([In] IntPtr hObject);

        /// Return Type: BOOL->int
        ///hFile: HANDLE->void*
        ///lpBuffer: LPBYTE->BYTE*
        ///nNumberOfBytesToWrite: DWORD->unsigned int
        ///lpNumberOfBytesWritten: LPDWORD->DWORD*
        ///bAbort: BOOL->int
        ///bProcessSecurity: BOOL->int
        ///lpContext: LPVOID*
        [DllImport("kernel32.dll", EntryPoint = "BackupWrite")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool BackupWrite(
            [In] IntPtr hFile, [In] IntPtr lpBuffer, uint nNumberOfBytesToWrite, [Out] out uint lpNumberOfBytesWritten,
            [MarshalAs(UnmanagedType.Bool)] bool bAbort, [MarshalAs(UnmanagedType.Bool)] bool bProcessSecurity, ref IntPtr lpContext);

        /// Return Type: BOOL->int
        ///hFile: HANDLE->void*
        ///dwFileOffsetLow: DWORD->unsigned int
        ///dwFileOffsetHigh: DWORD->unsigned int
        ///nNumberOfBytesToUnlockLow: DWORD->unsigned int
        ///nNumberOfBytesToUnlockHigh: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "UnlockFile")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool UnlockFile(
            [In] IntPtr hFile, uint dwFileOffsetLow, uint dwFileOffsetHigh, uint nNumberOfBytesToUnlockLow, uint nNumberOfBytesToUnlockHigh);

        /// Return Type: BOOL->int
        ///hEvent: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "ResetEvent")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ResetEvent([In] IntPtr hEvent);

        /// Return Type: BOOL->int
        ///hFile: HANDLE->void*
        ///lpBuffer: LPVOID->void*
        ///nNumberOfBytesToRead: DWORD->unsigned int
        ///lpOverlapped: LPOVERLAPPED->_OVERLAPPED*
        ///lpCompletionRoutine: LPOVERLAPPED_COMPLETION_ROUTINE
        [DllImport("kernel32.dll", EntryPoint = "ReadFileEx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ReadFileEx(
            [In] IntPtr hFile, IntPtr lpBuffer, uint nNumberOfBytesToRead, ref OVERLAPPED lpOverlapped, LPOVERLAPPED_COMPLETION_ROUTINE lpCompletionRoutine);

        /// Return Type: BOOL->int
        ///hEvent: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "PulseEvent")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PulseEvent([In] IntPtr hEvent);

        /// Return Type: HANDLE->void*
        ///dwDesiredAccess: DWORD->unsigned int
        ///bInheritHandle: BOOL->int
        ///dwThreadId: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "OpenThread")]
        public static extern IntPtr OpenThread(uint dwDesiredAccess, [MarshalAs(UnmanagedType.Bool)] bool bInheritHandle, uint dwThreadId);

        /// Return Type: HANDLE->void*
        ///dwDesiredAccess: DWORD->unsigned int
        ///bInheritHandle: BOOL->int
        ///lpName: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "OpenMutex")]
        public static extern IntPtr OpenMutex(
            uint dwDesiredAccess, [MarshalAs(UnmanagedType.Bool)] bool bInheritHandle, [In] [MarshalAs(UnmanagedType.LPTStr)] string lpName);

        /// Return Type: HANDLE->void*
        ///dwDesiredAccess: DWORD->unsigned int
        ///bInheritHandle: BOOL->int
        ///lpName: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "OpenEvent")]
        public static extern IntPtr OpenEvent(
            uint dwDesiredAccess, [MarshalAs(UnmanagedType.Bool)] bool bInheritHandle, [In] [MarshalAs(UnmanagedType.LPTStr)] string lpName);

        /// Return Type: BOOL->int
        ///hFile: HANDLE->void*
        ///dwFlags: DWORD->unsigned int
        ///dwReserved: DWORD->unsigned int
        ///nNumberOfBytesToLockLow: DWORD->unsigned int
        ///nNumberOfBytesToLockHigh: DWORD->unsigned int
        ///lpOverlapped: LPOVERLAPPED->_OVERLAPPED*
        [DllImport("kernel32.dll", EntryPoint = "LockFileEx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool LockFileEx(
            [In] IntPtr hFile, LOCKFILE dwFlags, uint dwReserved, uint nNumberOfBytesToLockLow, uint nNumberOfBytesToLockHigh, ref OVERLAPPED lpOverlapped);

        /// Return Type: UINT->unsigned int
        ///hMem: HLOCAL->HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "LocalFlags")]
        public static extern uint LocalFlags([In] IntPtr hMem);

        /// Return Type: HLOCAL->HANDLE->void*
        ///uFlags: UINT->unsigned int
        ///uBytes: SIZE_T->ULONG_PTR->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "LocalAlloc")]
        public static extern IntPtr LocalAlloc(LMEM uFlags, uint uBytes);

        /// Return Type: DWORD->unsigned int
        ///lpModuleName: LPCSTR->CHAR*
        ///lpParameterBlock: LPVOID->void*
        [DllImport("kernel32.dll", EntryPoint = "LoadModule")]
        public static extern uint LoadModule([In] [MarshalAs(UnmanagedType.LPStr)] string lpModuleName, [In] IntPtr lpParameterBlock);

        /// Return Type: BOOL->int
        ///hHeap: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "HeapUnlock")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool HeapUnlock([In] IntPtr hHeap);

        /// Return Type: HANDLE->void*
        ///flOptions: DWORD->unsigned int
        ///dwInitialSize: SIZE_T->ULONG_PTR->unsigned int
        ///dwMaximumSize: SIZE_T->ULONG_PTR->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "HeapCreate")]
        public static extern IntPtr HeapCreate(uint flOptions, uint dwInitialSize, uint dwMaximumSize);

        /// Return Type: LPVOID->void*
        ///hMem: HGLOBAL->HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "GlobalWire")]
        public static extern IntPtr GlobalWire([In] IntPtr hMem);

        /// Return Type: SIZE_T->ULONG_PTR->unsigned int
        ///hMem: HGLOBAL->HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "GlobalSize")]
        public static extern uint GlobalSize([In] IntPtr hMem);

        /// Return Type: LPVOID->void*
        ///hMem: HGLOBAL->HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "GlobalLock")]
        public static extern IntPtr GlobalLock([In] IntPtr hMem);

        /// Return Type: HGLOBAL->HANDLE->void*
        ///hMem: HGLOBAL->HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "GlobalFree")]
        public static extern IntPtr GlobalFree(IntPtr hMem);

        /// Return Type: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetVersion")]
        public static extern uint GetVersion();

        /// Return Type: void
        ///dwExitCode: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "ExitThread")]
        public static extern void ExitThread(uint dwExitCode);

        /// Return Type: ATOM->WORD->unsigned short
        ///nAtom: ATOM->WORD->unsigned short
        [DllImport("kernel32.dll", EntryPoint = "DeleteAtom")]
        public static extern ushort DeleteAtom(ushort nAtom);

        /// Return Type: void
        [DllImport("kernel32.dll", EntryPoint = "DebugBreak")]
        public static extern void DebugBreak();

        /// Return Type: BOOL->int
        ///hReadPipe: PHANDLE->HANDLE*
        ///hWritePipe: PHANDLE->HANDLE*
        ///lpPipeAttributes: LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        ///nSize: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "CreatePipe")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CreatePipe(ref IntPtr hReadPipe, ref IntPtr hWritePipe, [In] ref SECURITY_ATTRIBUTES lpPipeAttributes, uint nSize);

        /// Return Type: LONG->int
        ///param0: INT->int
        ///param1: INT->int
        [DllImport("kernel32.dll", EntryPoint = "CopyLZFile")]
        public static extern int CopyLZFile(int param0, int param1);

        /// Return Type: BOOL->int
        ///hFile: HANDLE->void*
        ///dwLowBytesToSeek: DWORD->unsigned int
        ///dwHighBytesToSeek: DWORD->unsigned int
        ///lpdwLowByteSeeked: LPDWORD->DWORD*
        ///lpdwHighByteSeeked: LPDWORD->DWORD*
        ///lpContext: LPVOID*
        [DllImport("kernel32.dll", EntryPoint = "BackupSeek")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool BackupSeek(
            [In] IntPtr hFile, uint dwLowBytesToSeek, uint dwHighBytesToSeek, [Out] out uint lpdwLowByteSeeked, [Out] out uint lpdwHighByteSeeked,
            ref IntPtr lpContext);

        /// Return Type: BOOL->int
        ///hFile: HANDLE->void*
        ///lpBuffer: LPBYTE->BYTE*
        ///nNumberOfBytesToRead: DWORD->unsigned int
        ///lpNumberOfBytesRead: LPDWORD->DWORD*
        ///bAbort: BOOL->int
        ///bProcessSecurity: BOOL->int
        ///lpContext: LPVOID*
        [DllImport("kernel32.dll", EntryPoint = "BackupRead")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool BackupRead(
            [In] IntPtr hFile, IntPtr lpBuffer, uint nNumberOfBytesToRead, [Out] out uint lpNumberOfBytesRead, [MarshalAs(UnmanagedType.Bool)] bool bAbort,
            [MarshalAs(UnmanagedType.Bool)] bool bProcessSecurity, ref IntPtr lpContext);

        /// Return Type: BOOL->int
        ///hFile: HANDLE->void*
        ///lpBuffer: LPCVOID->void*
        ///nNumberOfBytesToWrite: DWORD->unsigned int
        ///lpNumberOfBytesWritten: LPDWORD->DWORD*
        ///lpOverlapped: LPOVERLAPPED->_OVERLAPPED*
        [DllImport("kernel32.dll", EntryPoint = "WriteFile")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WriteFile(
            [In] IntPtr hFile, [In] IntPtr lpBuffer, uint nNumberOfBytesToWrite, IntPtr lpNumberOfBytesWritten, IntPtr lpOverlapped);

        /// Return Type: BOOL->int
        ///hFile: HANDLE->void*
        ///dwInQueue: DWORD->unsigned int
        ///dwOutQueue: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "SetupComm")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetupComm([In] IntPtr hFile, uint dwInQueue, uint dwOutQueue);

        /// Return Type: BOOL->int
        ///hFile: HANDLE->void*
        ///dwFlags: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "PurgeComm")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PurgeComm([In] IntPtr hFile, PURGE dwFlags);

        /// Return Type: BOOL->int
        ///lpExistingFileName: LPCWSTR->WCHAR*
        ///lpNewFileName: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "MoveFile")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool MoveFile(
            [In] [MarshalAs(UnmanagedType.LPTStr)] string lpExistingFileName, [In] [MarshalAs(UnmanagedType.LPTStr)] string lpNewFileName);

        /// Return Type: LPWSTR->WCHAR*
        ///lpString1: LPWSTR->WCHAR*
        ///lpString2: LPCWSTR->WCHAR*
        ///iMaxLength: int
        [DllImport("kernel32.dll", EntryPoint = "lstrcpyn")]
        public static extern IntPtr lstrcpyn(
            [Out] [MarshalAs(UnmanagedType.LPTStr)] StringBuilder lpString1, [In] [MarshalAs(UnmanagedType.LPTStr)] string lpString2, int iMaxLength);

        /// Return Type: int
        ///lpString1: LPCWSTR->WCHAR*
        ///lpString2: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "lstrcmpi")]
        public static extern int lstrcmpi([In] [MarshalAs(UnmanagedType.LPTStr)] string lpString1, [In] [MarshalAs(UnmanagedType.LPTStr)] string lpString2);

        /// Return Type: SIZE_T->ULONG_PTR->unsigned int
        ///hMem: HLOCAL->HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "LocalSize")]
        public static extern uint LocalSize([In] IntPtr hMem);

        /// Return Type: LPVOID->void*
        ///hMem: HLOCAL->HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "LocalLock")]
        public static extern IntPtr LocalLock([In] IntPtr hMem);

        /// Return Type: HLOCAL->HANDLE->void*
        ///hMem: HLOCAL->HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "LocalFree")]
        public static extern IntPtr LocalFree(IntPtr hMem);

        /// Return Type: LPVOID->void*
        ///hHeap: HANDLE->void*
        ///dwFlags: DWORD->unsigned int
        ///dwBytes: SIZE_T->ULONG_PTR->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "HeapAlloc")]
        public static extern IntPtr HeapAlloc([In] IntPtr hHeap, HEAP dwFlags, uint dwBytes);

        /// Return Type: void
        ///hMem: HGLOBAL->HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "GlobalFix")]
        public static extern void GlobalFix([In] IntPtr hMem);

        /// Return Type: BOOL->int
        ///CodePage: UINT->unsigned int
        ///lpCPInfo: LPCPINFO->_cpinfo*
        [DllImport("kernel32.dll", EntryPoint = "GetCPInfo")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetCPInfo(uint CodePage, [Out] out CPINFO lpCPInfo);

        /// Return Type: BOOL->int
        ///hFindFile: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "FindClose")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FindClose(IntPtr hFindFile);

        /// Return Type: ATOM->WORD->unsigned short
        ///lpString: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "FindAtom")]
        public static extern ushort FindAtom([In] [MarshalAs(UnmanagedType.LPTStr)] string lpString);

        /// Return Type: void
        ///ExitCode: int
        [DllImport("kernel32.dll", EntryPoint = "FatalExit")]
        public static extern void FatalExit(int ExitCode);

        /// Return Type: DWORD->unsigned int
        ///hDevice: HANDLE->void*
        ///dwEraseType: DWORD->unsigned int
        ///bImmediate: BOOL->int
        [DllImport("kernel32.dll", EntryPoint = "EraseTape")]
        public static extern uint EraseTape([In] IntPtr hDevice, uint dwEraseType, [MarshalAs(UnmanagedType.Bool)] bool bImmediate);

        /// Return Type: BOOL->int
        ///lpExistingFileName: LPCWSTR->WCHAR*
        ///lpNewFileName: LPCWSTR->WCHAR*
        ///bFailIfExists: BOOL->int
        [DllImport("kernel32.dll", EntryPoint = "CopyFile")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CopyFile(
            [In] [MarshalAs(UnmanagedType.LPTStr)] string lpExistingFileName, [In] [MarshalAs(UnmanagedType.LPTStr)] string lpNewFileName,
            [MarshalAs(UnmanagedType.Bool)] bool bFailIfExists);

        /// Return Type: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "TlsAlloc")]
        public static extern uint TlsAlloc();

        /// Return Type: BOOL->int
        ///hEvent: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "SetEvent")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetEvent([In] IntPtr hEvent);

        /// Return Type: BOOL->int
        ///hFile: HANDLE->void*
        ///lpBuffer: LPVOID->void*
        ///nNumberOfBytesToRead: DWORD->unsigned int
        ///lpNumberOfBytesRead: LPDWORD->DWORD*
        ///lpOverlapped: LPOVERLAPPED->_OVERLAPPED*
        [DllImport("kernel32.dll", EntryPoint = "ReadFile")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ReadFile([In] IntPtr hFile, IntPtr lpBuffer, uint nNumberOfBytesToRead, IntPtr lpNumberOfBytesRead, IntPtr lpOverlapped);

        /// Return Type: HFILE->int
        ///lpFileName: LPCSTR->CHAR*
        ///lpReOpenBuff: LPOFSTRUCT->_OFSTRUCT*
        ///uStyle: UINT->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "OpenFile")]
        public static extern int OpenFile([In] [MarshalAs(UnmanagedType.LPStr)] string lpFileName, ref OFSTRUCT lpReOpenBuff, uint uStyle);

        /// Return Type: int
        ///lpString: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "lstrlen")]
        public static extern int lstrlen([In] [MarshalAs(UnmanagedType.LPTStr)] string lpString);

        /// Return Type: LPWSTR->WCHAR*
        ///lpString1: LPWSTR->WCHAR*
        ///lpString2: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "lstrcpy")]
        public static extern IntPtr lstrcpy(
            [Out] [MarshalAs(UnmanagedType.LPTStr)] StringBuilder lpString1, [In] [MarshalAs(UnmanagedType.LPTStr)] string lpString2);

        /// Return Type: int
        ///lpString1: LPCWSTR->WCHAR*
        ///lpString2: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "lstrcmp")]
        public static extern int lstrcmp([In] [MarshalAs(UnmanagedType.LPTStr)] string lpString1, [In] [MarshalAs(UnmanagedType.LPTStr)] string lpString2);

        /// Return Type: LPWSTR->WCHAR*
        ///lpString1: LPWSTR->WCHAR*
        ///lpString2: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "lstrcat")]
        public static extern IntPtr lstrcat(IntPtr lpString1, [In] [MarshalAs(UnmanagedType.LPTStr)] string lpString2);

        /// Return Type: BOOL->int
        ///hFile: HANDLE->void*
        ///dwFileOffsetLow: DWORD->unsigned int
        ///dwFileOffsetHigh: DWORD->unsigned int
        ///nNumberOfBytesToLockLow: DWORD->unsigned int
        ///nNumberOfBytesToLockHigh: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "LockFile")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool LockFile(
            [In] IntPtr hFile, uint dwFileOffsetLow, uint dwFileOffsetHigh, uint nNumberOfBytesToLockLow, uint nNumberOfBytesToLockHigh);

        /// Return Type: BOOL->int
        ///hHeap: HANDLE->void*
        ///lpEntry: LPPROCESS_HEAP_ENTRY->_PROCESS_HEAP_ENTRY*
        [DllImport("kernel32.dll", EntryPoint = "HeapWalk")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool HeapWalk([In] IntPtr hHeap, ref PROCESS_HEAP_ENTRY lpEntry);

        /// Return Type: SIZE_T->ULONG_PTR->unsigned int
        ///hHeap: HANDLE->void*
        ///dwFlags: DWORD->unsigned int
        ///lpMem: LPCVOID->void*
        [DllImport("kernel32.dll", EntryPoint = "HeapSize")]
        public static extern uint HeapSize([In] IntPtr hHeap, HEAP dwFlags, [In] IntPtr lpMem);

        /// Return Type: BOOL->int
        ///hHeap: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "HeapLock")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool HeapLock([In] IntPtr hHeap);

        /// Return Type: BOOL->int
        ///hHeap: HANDLE->void*
        ///dwFlags: DWORD->unsigned int
        ///lpMem: LPVOID->void*
        [DllImport("kernel32.dll", EntryPoint = "HeapFree")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool HeapFree(IntPtr hHeap, HEAP dwFlags, IntPtr lpMem);

        /// Return Type: UINT->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetOEMCP")]
        public static extern uint GetOEMCP();

        /// Return Type: BOOL->int
        ///hFile: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "CancelIo")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CancelIo([In] IntPtr hFile);

        /// Return Type: ATOM->WORD->unsigned short
        ///lpString: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "AddAtom")]
        public static extern ushort AddAtom([In] [MarshalAs(UnmanagedType.LPTStr)] string lpString);

        /// Return Type: UINT->unsigned int
        ///hFile: HFILE->int
        ///lpBuffer: LPCCH->CHAR*
        ///uBytes: UINT->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "_lwrite")]
        public static extern uint _lwrite(int hFile, [In] [MarshalAs(UnmanagedType.LPStr)] string lpBuffer, uint uBytes);

        /// Return Type: LONG->int
        ///hFile: HFILE->int
        ///lOffset: LONG->int
        ///iOrigin: int
        [DllImport("kernel32.dll", EntryPoint = "_llseek")]
        public static extern int _llseek(int hFile, int lOffset, int iOrigin);

        /// Return Type: HFILE->int
        ///lpPathName: LPCSTR->CHAR*
        ///iAttribute: int
        [DllImport("kernel32.dll", EntryPoint = "_lcreat")]
        public static extern int _lcreat([In] [MarshalAs(UnmanagedType.LPStr)] string lpPathName, CREATE iAttribute);

        /// Return Type: HFILE->int
        ///hFile: HFILE->int
        [DllImport("kernel32.dll", EntryPoint = "_lclose")]
        public static extern int _lclose(int hFile);

        /// Return Type: int
        ///hFile: HFILE->int
        ///lpBuffer: LPCCH->CHAR*
        ///lBytes: int
        [DllImport("kernel32.dll", EntryPoint = "_hwrite")]
        public static extern int _hwrite(int hFile, [In] [MarshalAs(UnmanagedType.LPStr)] string lpBuffer, int lBytes);

        /// Return Type: UINT->unsigned int
        ///lpCmdLine: LPCSTR->CHAR*
        ///uCmdShow: UINT->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "WinExec")]
        public static extern uint WinExec([In] [MarshalAs(UnmanagedType.LPStr)] string lpCmdLine, uint uCmdShow);

        /// Return Type: BOOL->int
        ///dwTlsIndex: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "TlsFree")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool TlsFree(uint dwTlsIndex);

        /// Return Type: DWORD->unsigned int
        ///dwMilliseconds: DWORD->unsigned int
        ///bAlertable: BOOL->int
        [DllImport("kernel32.dll", EntryPoint = "SleepEx")]
        public static extern uint SleepEx(uint dwMilliseconds, [MarshalAs(UnmanagedType.Bool)] bool bAlertable);

        /// Return Type: INT->int
        [DllImport("kernel32.dll", EntryPoint = "LZStart")]
        public static extern int LZStart();

        /// Return Type: void
        ///param0: INT->int
        [DllImport("kernel32.dll", EntryPoint = "LZClose")]
        public static extern void LZClose(int param0);

        /// Return Type: UINT->unsigned int
        ///hFile: HFILE->int
        ///lpBuffer: LPVOID->void*
        ///uBytes: UINT->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "_lread")]
        public static extern uint _lread(int hFile, IntPtr lpBuffer, uint uBytes);

        /// Return Type: HFILE->int
        ///lpPathName: LPCSTR->CHAR*
        ///iReadWrite: int
        [DllImport("kernel32.dll", EntryPoint = "_lopen")]
        public static extern int _lopen([In] [MarshalAs(UnmanagedType.LPStr)] string lpPathName, int iReadWrite);

        /// Return Type: int
        ///hFile: HFILE->int
        ///lpBuffer: LPVOID->void*
        ///lBytes: int
        [DllImport("kernel32.dll", EntryPoint = "_hread")]
        public static extern int _hread(int hFile, IntPtr lpBuffer, int lBytes);

        /// Return Type: int
        ///nNumber: int
        ///nNumerator: int
        ///nDenominator: int
        [DllImport("kernel32.dll", EntryPoint = "MulDiv")]
        public static extern int MulDiv(int nNumber, int nNumerator, int nDenominator);

        /// Return Type: LONG->int
        ///param0: INT->int
        ///param1: LONG->int
        ///param2: INT->int
        [DllImport("kernel32.dll", EntryPoint = "LZSeek")]
        public static extern int LZSeek(int param0, int param1, int param2);

        /// Return Type: INT->int
        ///param0: INT->int
        ///param1: LPSTR->CHAR*
        ///param2: INT->int
        [DllImport("kernel32.dll", EntryPoint = "LZRead")]
        public static extern int LZRead(int param0, [MarshalAs(UnmanagedType.LPStr)] StringBuilder param1, int param2);

        /// Return Type: INT->int
        ///param0: INT->int
        [DllImport("kernel32.dll", EntryPoint = "LZInit")]
        public static extern int LZInit(int param0);

        /// Return Type: void
        [DllImport("kernel32.dll", EntryPoint = "LZDone")]
        public static extern void LZDone();

        /// Return Type: LONG->int
        ///param0: INT->int
        ///param1: INT->int
        [DllImport("kernel32.dll", EntryPoint = "LZCopy")]
        public static extern int LZCopy(int param0, int param1);

        /// Return Type: UINT->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetACP")]
        public static extern uint GetACP();

        /// Return Type: void
        ///dwMilliseconds: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "Sleep")]
        public static extern void Sleep(uint dwMilliseconds);

        /// Return Type: BOOL->int
        ///dwFreq: DWORD->unsigned int
        ///dwDuration: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "Beep")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool Beep(uint dwFreq, uint dwDuration);

		[DllImport("kernel32.dll", EntryPoint = "SetConsoleScreenBufferInfoEx")]
		public static extern bool SetConsoleScreenBufferInfoEx(IntPtr ConsoleOutput, CONSOLE_SCREEN_BUFFER_INFOEX ConsoleScreenBufferInfoEx);

		[DllImport("kernel32.dll", CharSet = CharSet.Unicode, EntryPoint = "GetCurrentConsoleFontEx")]
		public static extern bool GetCurrentConsoleFontEx(IntPtr hConsoleOutput, bool bMaximumWindow, [In, Out] CONSOLE_FONT_INFOEX lpConsoleCurrentFont);

		[DllImport("kernel32.dll", EntryPoint = "SetCurrentConsoleFontEx")]
		public static extern bool SetCurrentConsoleFontEx(IntPtr ConsoleOutput, bool MaximumWindow, CONSOLE_FONT_INFOEX ConsoleCurrentFontEx);
    }

    // ReSharper restore InconsistentNaming
}