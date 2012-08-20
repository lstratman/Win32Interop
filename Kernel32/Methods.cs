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
    public delegate int LANGUAGEGROUP_ENUMPROCW(
        uint param0, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder param1, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder param2, uint param3, IntPtr param4);

    /// Return Type: BOOL->int
    ///param0: LGRPID->DWORD->unsigned int
    ///param1: LPSTR->CHAR*
    ///param2: LPSTR->CHAR*
    ///param3: DWORD->unsigned int
    ///param4: LONG_PTR->int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int LANGUAGEGROUP_ENUMPROCA(
        uint param0, [MarshalAs(UnmanagedType.LPStr)] StringBuilder param1, [MarshalAs(UnmanagedType.LPStr)] StringBuilder param2, uint param3, IntPtr param4);

    /// Return Type: BOOL->int
    ///param0: LGRPID->DWORD->unsigned int
    ///param1: LCID->DWORD->unsigned int
    ///param2: LPWSTR->WCHAR*
    ///param3: LONG_PTR->int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int LANGGROUPLOCALE_ENUMPROCW(uint param0, uint param1, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder param2, IntPtr param3);

    /// Return Type: BOOL->int
    ///param0: LGRPID->DWORD->unsigned int
    ///param1: LCID->DWORD->unsigned int
    ///param2: LPSTR->CHAR*
    ///param3: LONG_PTR->int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int LANGGROUPLOCALE_ENUMPROCA(uint param0, uint param1, [MarshalAs(UnmanagedType.LPStr)] StringBuilder param2, IntPtr param3);

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
    public delegate int ENUMRESLANGPROCW(
        [In] IntPtr hModule, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpType, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpName, ushort wLanguage,
        [In] IntPtr lParam);

    /// Return Type: BOOL->int
    ///hModule: HMODULE->HINSTANCE->HINSTANCE__*
    ///lpType: LPCSTR->CHAR*
    ///lpName: LPCSTR->CHAR*
    ///wLanguage: WORD->unsigned short
    ///lParam: LONG_PTR->int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int ENUMRESLANGPROCA(
        [In] IntPtr hModule, [In] [MarshalAs(UnmanagedType.LPStr)] string lpType, [In] [MarshalAs(UnmanagedType.LPStr)] string lpName, ushort wLanguage,
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
    public delegate int CODEPAGE_ENUMPROCW([MarshalAs(UnmanagedType.LPWStr)] StringBuilder param0);

    /// Return Type: BOOL->int
    ///param0: LPSTR->CHAR*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int CODEPAGE_ENUMPROCA([MarshalAs(UnmanagedType.LPStr)] StringBuilder param0);

    /// Return Type: BOOL->int
    ///param0: LPWSTR->WCHAR*
    ///param1: CALID->DWORD->unsigned int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int CALINFO_ENUMPROCEXW([MarshalAs(UnmanagedType.LPWStr)] StringBuilder param0, uint param1);

    /// Return Type: BOOL->int
    ///param0: LPSTR->CHAR*
    ///param1: CALID->DWORD->unsigned int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int CALINFO_ENUMPROCEXA([MarshalAs(UnmanagedType.LPStr)] StringBuilder param0, uint param1);

    /// Return Type: BOOL->int
    ///param0: LPWSTR->WCHAR*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int LOCALE_ENUMPROCW([MarshalAs(UnmanagedType.LPWStr)] StringBuilder param0);

    /// Return Type: BOOL->int
    ///param0: LPSTR->CHAR*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int LOCALE_ENUMPROCA([MarshalAs(UnmanagedType.LPStr)] StringBuilder param0);

    /// Return Type: BOOL->int
    ///hModule: HMODULE->HINSTANCE->HINSTANCE__*
    ///lpType: LPWSTR->WCHAR*
    ///lParam: LONG_PTR->int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int ENUMRESTYPEPROCW([In] IntPtr hModule, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpType, [In] IntPtr lParam);

    /// Return Type: BOOL->int
    ///hModule: HMODULE->HINSTANCE->HINSTANCE__*
    ///lpType: LPSTR->CHAR*
    ///lParam: LONG_PTR->int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int ENUMRESTYPEPROCA([In] IntPtr hModule, [In] [MarshalAs(UnmanagedType.LPStr)] string lpType, [In] IntPtr lParam);

    /// Return Type: BOOL->int
    ///hModule: HMODULE->HINSTANCE->HINSTANCE__*
    ///lpType: LPCWSTR->WCHAR*
    ///lpName: LPWSTR->WCHAR*
    ///lParam: LONG_PTR->int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int ENUMRESNAMEPROCW(
        [In] IntPtr hModule, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpType, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpName, [In] IntPtr lParam);

    /// Return Type: BOOL->int
    ///hModule: HMODULE->HINSTANCE->HINSTANCE__*
    ///lpType: LPCSTR->CHAR*
    ///lpName: LPSTR->CHAR*
    ///lParam: LONG_PTR->int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int ENUMRESNAMEPROCA(
        [In] IntPtr hModule, [In] [MarshalAs(UnmanagedType.LPStr)] string lpType, [In] [MarshalAs(UnmanagedType.LPStr)] string lpName, [In] IntPtr lParam);

    /// Return Type: BOOL->int
    ///param0: LPWSTR->WCHAR*
    ///param1: CALID->DWORD->unsigned int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int DATEFMT_ENUMPROCEXW([MarshalAs(UnmanagedType.LPWStr)] StringBuilder param0, uint param1);

    /// Return Type: BOOL->int
    ///param0: LPSTR->CHAR*
    ///param1: CALID->DWORD->unsigned int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int DATEFMT_ENUMPROCEXA([MarshalAs(UnmanagedType.LPStr)] StringBuilder param0, uint param1);

    /// Return Type: BOOL->int
    ///param0: LPWSTR->WCHAR*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int CALINFO_ENUMPROCW([MarshalAs(UnmanagedType.LPWStr)] StringBuilder param0);

    /// Return Type: BOOL->int
    ///param0: LPSTR->CHAR*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int CALINFO_ENUMPROCA([MarshalAs(UnmanagedType.LPStr)] StringBuilder param0);

    /// Return Type: void
    ///lpArgToCompletionRoutine: LPVOID->void*
    ///dwTimerLowValue: DWORD->unsigned int
    ///dwTimerHighValue: DWORD->unsigned int
    public delegate void PTIMERAPCROUTINE([In] IntPtr lpArgToCompletionRoutine, uint dwTimerLowValue, uint dwTimerHighValue);

    /// Return Type: BOOL->int
    ///param0: LPWSTR->WCHAR*
    ///param1: LONG_PTR->int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int UILANGUAGE_ENUMPROCW([MarshalAs(UnmanagedType.LPWStr)] StringBuilder param0, IntPtr param1);

    /// Return Type: BOOL->int
    ///param0: LPSTR->CHAR*
    ///param1: LONG_PTR->int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int UILANGUAGE_ENUMPROCA([MarshalAs(UnmanagedType.LPStr)] StringBuilder param0, IntPtr param1);

    /// Return Type: BOOL->int
    ///param0: LPWSTR->WCHAR*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int TIMEFMT_ENUMPROCW([MarshalAs(UnmanagedType.LPWStr)] StringBuilder param0);

    /// Return Type: BOOL->int
    ///param0: LPSTR->CHAR*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int TIMEFMT_ENUMPROCA([MarshalAs(UnmanagedType.LPStr)] StringBuilder param0);

    /// Return Type: BOOL->int
    ///param0: LPWSTR->WCHAR*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int DATEFMT_ENUMPROCW([MarshalAs(UnmanagedType.LPWStr)] StringBuilder param0);

    /// Return Type: BOOL->int
    ///param0: LPSTR->CHAR*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int DATEFMT_ENUMPROCA([MarshalAs(UnmanagedType.LPStr)] StringBuilder param0);

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
        [DllImport("kernel32.dll", EntryPoint = "GetVolumeNameForVolumeMountPointW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetVolumeNameForVolumeMountPointW(
            [In] [MarshalAs(UnmanagedType.LPWStr)] string lpszVolumeMountPoint, [Out] [MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpszVolumeName,
            uint cchBufferLength);

        /// Return Type: BOOL->int
        ///lpszVolumeMountPoint: LPCSTR->CHAR*
        ///lpszVolumeName: LPSTR->CHAR*
        ///cchBufferLength: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetVolumeNameForVolumeMountPointA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetVolumeNameForVolumeMountPointA(
            [In] [MarshalAs(UnmanagedType.LPStr)] string lpszVolumeMountPoint, [Out] [MarshalAs(UnmanagedType.LPStr)] StringBuilder lpszVolumeName,
            uint cchBufferLength);

        /// Return Type: BOOL->int
        ///lpszVolumeName: LPCWSTR->WCHAR*
        ///lpszVolumePathNames: LPWCH->WCHAR*
        ///cchBufferLength: DWORD->unsigned int
        ///lpcchReturnLength: PDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "GetVolumePathNamesForVolumeNameW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetVolumePathNamesForVolumeNameW(
            [In] [MarshalAs(UnmanagedType.LPWStr)] string lpszVolumeName, [Out] [MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpszVolumePathNames,
            uint cchBufferLength, [Out] out uint lpcchReturnLength);

        /// Return Type: BOOL->int
        ///lpszVolumeName: LPCSTR->CHAR*
        ///lpszVolumePathNames: LPCH->CHAR*
        ///cchBufferLength: DWORD->unsigned int
        ///lpcchReturnLength: PDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "GetVolumePathNamesForVolumeNameA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetVolumePathNamesForVolumeNameA(
            [In] [MarshalAs(UnmanagedType.LPStr)] string lpszVolumeName, [Out] [MarshalAs(UnmanagedType.LPStr)] StringBuilder lpszVolumePathNames,
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
        [DllImport("kernel32.dll", EntryPoint = "SetFirmwareEnvironmentVariableW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetFirmwareEnvironmentVariableW(
            [In] [MarshalAs(UnmanagedType.LPWStr)] string lpName, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpGuid, [In] IntPtr pValue, uint nSize);

        /// Return Type: BOOL->int
        ///lpName: LPCSTR->CHAR*
        ///lpGuid: LPCSTR->CHAR*
        ///pValue: PVOID->void*
        ///nSize: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "SetFirmwareEnvironmentVariableA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetFirmwareEnvironmentVariableA(
            [In] [MarshalAs(UnmanagedType.LPStr)] string lpName, [In] [MarshalAs(UnmanagedType.LPStr)] string lpGuid, [In] IntPtr pValue, uint nSize);

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
        [DllImport("kernel32.dll", EntryPoint = "GetFirmwareEnvironmentVariableW")]
        public static extern uint GetFirmwareEnvironmentVariableW(
            [In] [MarshalAs(UnmanagedType.LPWStr)] string lpName, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpGuid, IntPtr pBuffer, uint nSize);

        /// Return Type: DWORD->unsigned int
        ///lpName: LPCSTR->CHAR*
        ///lpGuid: LPCSTR->CHAR*
        ///pBuffer: PVOID->void*
        ///nSize: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetFirmwareEnvironmentVariableA")]
        public static extern uint GetFirmwareEnvironmentVariableA(
            [In] [MarshalAs(UnmanagedType.LPStr)] string lpName, [In] [MarshalAs(UnmanagedType.LPStr)] string lpGuid, IntPtr pBuffer, uint nSize);

        /// Return Type: ULONG->unsigned int
        ///Handle: PVOID->void*
        [DllImport("kernel32.dll", EntryPoint = "RemoveVectoredExceptionHandler")]
        public static extern uint RemoveVectoredExceptionHandler([In] IntPtr Handle);

        /// Return Type: DWORD->unsigned int
        ///lpszReturnBuffer: LPWSTR->WCHAR*
        ///nSize: DWORD->unsigned int
        ///lpFileName: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetPrivateProfileSectionNamesW")]
        public static extern uint GetPrivateProfileSectionNamesW(
            [Out] [MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpszReturnBuffer, uint nSize, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);

        /// Return Type: DWORD->unsigned int
        ///lpszReturnBuffer: LPSTR->CHAR*
        ///nSize: DWORD->unsigned int
        ///lpFileName: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetPrivateProfileSectionNamesA")]
        public static extern uint GetPrivateProfileSectionNamesA(
            [Out] [MarshalAs(UnmanagedType.LPStr)] StringBuilder lpszReturnBuffer, uint nSize, [In] [MarshalAs(UnmanagedType.LPStr)] string lpFileName);

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
            [In] IntPtr hObject, WAITORTIMERCALLBACKFUNC Callback, [In] IntPtr Context, uint dwMilliseconds, uint dwFlags);

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
        [DllImport("kernel32.dll", EntryPoint = "WriteConsoleOutputCharacterW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WriteConsoleOutputCharacterW(
            IntPtr hConsoleOutput, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpCharacter, uint nLength, COORD dwWriteCoord, ref uint lpNumberOfCharsWritten);

        /// Return Type: BOOL->int
        ///hConsoleOutput: HANDLE->void*
        ///lpCharacter: LPCSTR->CHAR*
        ///nLength: DWORD->unsigned int
        ///dwWriteCoord: COORD->_COORD
        ///lpNumberOfCharsWritten: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "WriteConsoleOutputCharacterA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WriteConsoleOutputCharacterA(
            IntPtr hConsoleOutput, [In] [MarshalAs(UnmanagedType.LPStr)] string lpCharacter, uint nLength, COORD dwWriteCoord, ref uint lpNumberOfCharsWritten);

        /// Return Type: BOOL->int
        ///dwLevel: DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "SetProcessShutdownParameters")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetProcessShutdownParameters(uint dwLevel, uint dwFlags);

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
        public static extern bool GetProcessShutdownParameters([Out] out uint lpdwLevel, [Out] out uint lpdwFlags);

        /// Return Type: HANDLE->void*
        ///lpPathName: LPCWSTR->WCHAR*
        ///bWatchSubtree: BOOL->int
        ///dwNotifyFilter: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "FindFirstChangeNotificationW")]
        public static extern IntPtr FindFirstChangeNotificationW(
            [In] [MarshalAs(UnmanagedType.LPWStr)] string lpPathName, [MarshalAs(UnmanagedType.Bool)] bool bWatchSubtree, uint dwNotifyFilter);

        /// Return Type: HANDLE->void*
        ///lpPathName: LPCSTR->CHAR*
        ///bWatchSubtree: BOOL->int
        ///dwNotifyFilter: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "FindFirstChangeNotificationA")]
        public static extern IntPtr FindFirstChangeNotificationA(
            [In] [MarshalAs(UnmanagedType.LPStr)] string lpPathName, [MarshalAs(UnmanagedType.Bool)] bool bWatchSubtree, uint dwNotifyFilter);

        /// Return Type: BOOL->int
        ///lpAppName: LPCWSTR->WCHAR*
        ///lpString: LPCWSTR->WCHAR*
        ///lpFileName: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "WritePrivateProfileSectionW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WritePrivateProfileSectionW(
            [In] [MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpString,
            [In] [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);

        /// Return Type: BOOL->int
        ///lpAppName: LPCSTR->CHAR*
        ///lpString: LPCSTR->CHAR*
        ///lpFileName: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "WritePrivateProfileSectionA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WritePrivateProfileSectionA(
            [In] [MarshalAs(UnmanagedType.LPStr)] string lpAppName, [In] [MarshalAs(UnmanagedType.LPStr)] string lpString,
            [In] [MarshalAs(UnmanagedType.LPStr)] string lpFileName);

        /// Return Type: BOOL->int
        ///hConsoleOutput: HANDLE->void*
        ///lpAttribute: WORD*
        ///nLength: DWORD->unsigned int
        ///dwWriteCoord: COORD->_COORD
        ///lpNumberOfAttrsWritten: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "WriteConsoleOutputAttribute")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WriteConsoleOutputAttribute(
            IntPtr hConsoleOutput, ref ushort lpAttribute, uint nLength, COORD dwWriteCoord, ref uint lpNumberOfAttrsWritten);

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
            out IntPtr phNewWaitObject, [In] IntPtr hObject, WAITORTIMERCALLBACKFUNC Callback, [In] IntPtr Context, uint dwMilliseconds, uint dwFlags);

        /// Return Type: BOOL->int
        ///hConsoleOutput: HANDLE->void*
        ///lpCharacter: LPWSTR->WCHAR*
        ///nLength: DWORD->unsigned int
        ///dwReadCoord: COORD->_COORD
        ///lpNumberOfCharsRead: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "ReadConsoleOutputCharacterW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ReadConsoleOutputCharacterW(
            IntPtr hConsoleOutput, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpCharacter, uint nLength, COORD dwReadCoord, ref uint lpNumberOfCharsRead);

        /// Return Type: BOOL->int
        ///hConsoleOutput: HANDLE->void*
        ///lpCharacter: LPSTR->CHAR*
        ///nLength: DWORD->unsigned int
        ///dwReadCoord: COORD->_COORD
        ///lpNumberOfCharsRead: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "ReadConsoleOutputCharacterA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ReadConsoleOutputCharacterA(
            IntPtr hConsoleOutput, [MarshalAs(UnmanagedType.LPStr)] StringBuilder lpCharacter, uint nLength, COORD dwReadCoord, ref uint lpNumberOfCharsRead);

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
        [DllImport("kernel32.dll", EntryPoint = "FillConsoleOutputCharacterW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FillConsoleOutputCharacterW(
            IntPtr hConsoleOutput, char cCharacter, uint nLength, COORD dwWriteCoord, ref uint lpNumberOfCharsWritten);

        /// Return Type: BOOL->int
        ///hConsoleOutput: HANDLE->void*
        ///cCharacter: CHAR->char
        ///nLength: DWORD->unsigned int
        ///dwWriteCoord: COORD->_COORD
        ///lpNumberOfCharsWritten: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "FillConsoleOutputCharacterA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FillConsoleOutputCharacterA(
            IntPtr hConsoleOutput, byte cCharacter, uint nLength, COORD dwWriteCoord, ref uint lpNumberOfCharsWritten);

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
        [DllImport("kernel32.dll", EntryPoint = "WritePrivateProfileStructW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WritePrivateProfileStructW(
            [In] [MarshalAs(UnmanagedType.LPWStr)] string lpszSection, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpszKey, [In] IntPtr lpStruct,
            uint uSizeStruct, [In] [MarshalAs(UnmanagedType.LPWStr)] string szFile);

        /// Return Type: BOOL->int
        ///lpszSection: LPCSTR->CHAR*
        ///lpszKey: LPCSTR->CHAR*
        ///lpStruct: LPVOID->void*
        ///uSizeStruct: UINT->unsigned int
        ///szFile: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "WritePrivateProfileStructA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WritePrivateProfileStructA(
            [In] [MarshalAs(UnmanagedType.LPStr)] string lpszSection, [In] [MarshalAs(UnmanagedType.LPStr)] string lpszKey, [In] IntPtr lpStruct,
            uint uSizeStruct, [In] [MarshalAs(UnmanagedType.LPStr)] string szFile);

        /// Return Type: BOOL->int
        ///lpAppName: LPCWSTR->WCHAR*
        ///lpKeyName: LPCWSTR->WCHAR*
        ///lpString: LPCWSTR->WCHAR*
        ///lpFileName: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "WritePrivateProfileStringW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WritePrivateProfileStringW(
            [In] [MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName,
            [In] [MarshalAs(UnmanagedType.LPWStr)] string lpString, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);

        /// Return Type: BOOL->int
        ///lpAppName: LPCSTR->CHAR*
        ///lpKeyName: LPCSTR->CHAR*
        ///lpString: LPCSTR->CHAR*
        ///lpFileName: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "WritePrivateProfileStringA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WritePrivateProfileStringA(
            [In] [MarshalAs(UnmanagedType.LPStr)] string lpAppName, [In] [MarshalAs(UnmanagedType.LPStr)] string lpKeyName,
            [In] [MarshalAs(UnmanagedType.LPStr)] string lpString, [In] [MarshalAs(UnmanagedType.LPStr)] string lpFileName);

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
        [DllImport("kernel32.dll", EntryPoint = "ScrollConsoleScreenBufferW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ScrollConsoleScreenBufferW(
            IntPtr hConsoleOutput, ref SMALL_RECT lpScrollRectangle, ref SMALL_RECT lpClipRectangle, COORD dwDestinationOrigin, ref CHAR_INFO lpFill);

        /// Return Type: BOOL->int
        ///hConsoleOutput: HANDLE->void*
        ///lpScrollRectangle: SMALL_RECT*
        ///lpClipRectangle: SMALL_RECT*
        ///dwDestinationOrigin: COORD->_COORD
        ///lpFill: CHAR_INFO*
        [DllImport("kernel32.dll", EntryPoint = "ScrollConsoleScreenBufferA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ScrollConsoleScreenBufferA(
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
            IntPtr hConsoleOutput, ref ushort lpAttribute, uint nLength, COORD dwReadCoord, ref uint lpNumberOfAttrsRead);

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
        [DllImport("kernel32.dll", EntryPoint = "GetSystemWindowsDirectoryW")]
        public static extern uint GetSystemWindowsDirectoryW([Out] [MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpBuffer, uint uSize);

        /// Return Type: UINT->unsigned int
        ///lpBuffer: LPSTR->CHAR*
        ///uSize: UINT->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetSystemWindowsDirectoryA")]
        public static extern uint GetSystemWindowsDirectoryA([Out] [MarshalAs(UnmanagedType.LPStr)] StringBuilder lpBuffer, uint uSize);

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

        /// Return Type: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetConsoleAliasExesLengthW")]
        public static extern uint GetConsoleAliasExesLengthW();

        /// Return Type: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetConsoleAliasExesLengthA")]
        public static extern uint GetConsoleAliasExesLengthA();

        /// Return Type: BOOL->int
        ///hChangeHandle: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "FindNextChangeNotification")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FindNextChangeNotification([In] IntPtr hChangeHandle);

        /// Return Type: HANDLE->void*
        ///lpszRootPathName: LPCWSTR->WCHAR*
        ///lpszVolumeMountPoint: LPWSTR->WCHAR*
        ///cchBufferLength: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "FindFirstVolumeMountPointW")]
        public static extern IntPtr FindFirstVolumeMountPointW(
            [In] [MarshalAs(UnmanagedType.LPWStr)] string lpszRootPathName, [Out] [MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpszVolumeMountPoint,
            uint cchBufferLength);

        /// Return Type: HANDLE->void*
        ///lpszRootPathName: LPCSTR->CHAR*
        ///lpszVolumeMountPoint: LPSTR->CHAR*
        ///cchBufferLength: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "FindFirstVolumeMountPointA")]
        public static extern IntPtr FindFirstVolumeMountPointA(
            [In] [MarshalAs(UnmanagedType.LPStr)] string lpszRootPathName, [Out] [MarshalAs(UnmanagedType.LPStr)] StringBuilder lpszVolumeMountPoint,
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
            IntPtr hConsoleOutput, ushort wAttribute, uint nLength, COORD dwWriteCoord, ref uint lpNumberOfAttrsWritten);

        /// Return Type: BOOL->int
        ///Hostname: LPCWSTR->WCHAR*
        ///ComputerName: LPWSTR->WCHAR*
        ///nSize: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "DnsHostnameToComputerNameW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DnsHostnameToComputerNameW(
            [In] [MarshalAs(UnmanagedType.LPWStr)] string Hostname, [Out] [MarshalAs(UnmanagedType.LPWStr)] StringBuilder ComputerName, ref uint nSize);

        /// Return Type: BOOL->int
        ///Hostname: LPCSTR->CHAR*
        ///ComputerName: LPSTR->CHAR*
        ///nSize: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "DnsHostnameToComputerNameA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DnsHostnameToComputerNameA(
            [In] [MarshalAs(UnmanagedType.LPStr)] string Hostname, [Out] [MarshalAs(UnmanagedType.LPStr)] StringBuilder ComputerName, ref uint nSize);

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
        [DllImport("kernel32.dll", EntryPoint = "GetPrivateProfileSectionW")]
        public static extern uint GetPrivateProfileSectionW(
            [In] [MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [Out] [MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpReturnedString, uint nSize,
            [In] [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);

        /// Return Type: DWORD->unsigned int
        ///lpAppName: LPCSTR->CHAR*
        ///lpReturnedString: LPSTR->CHAR*
        ///nSize: DWORD->unsigned int
        ///lpFileName: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetPrivateProfileSectionA")]
        public static extern uint GetPrivateProfileSectionA(
            [In] [MarshalAs(UnmanagedType.LPStr)] string lpAppName, [Out] [MarshalAs(UnmanagedType.LPStr)] StringBuilder lpReturnedString, uint nSize,
            [In] [MarshalAs(UnmanagedType.LPStr)] string lpFileName);

        /// Return Type: BOOL->int
        ///hFindVolumeMountPoint: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "FindVolumeMountPointClose")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FindVolumeMountPointClose([In] IntPtr hFindVolumeMountPoint);

        /// Return Type: BOOL->int
        ///hFindVolumeMountPoint: HANDLE->void*
        ///lpszVolumeMountPoint: LPWSTR->WCHAR*
        ///cchBufferLength: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "FindNextVolumeMountPointW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FindNextVolumeMountPointW(
            [In] IntPtr hFindVolumeMountPoint, [Out] [MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpszVolumeMountPoint, uint cchBufferLength);

        /// Return Type: BOOL->int
        ///hFindVolumeMountPoint: HANDLE->void*
        ///lpszVolumeMountPoint: LPSTR->CHAR*
        ///cchBufferLength: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "FindNextVolumeMountPointA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FindNextVolumeMountPointA(
            [In] IntPtr hFindVolumeMountPoint, [Out] [MarshalAs(UnmanagedType.LPStr)] StringBuilder lpszVolumeMountPoint, uint cchBufferLength);

        /// Return Type: DWORD->unsigned int
        ///lpSrc: LPCWSTR->WCHAR*
        ///lpDst: LPWSTR->WCHAR*
        ///nSize: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "ExpandEnvironmentStringsW")]
        public static extern uint ExpandEnvironmentStringsW(
            [In] [MarshalAs(UnmanagedType.LPWStr)] string lpSrc, [Out] [MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpDst, uint nSize);

        /// Return Type: DWORD->unsigned int
        ///lpSrc: LPCSTR->CHAR*
        ///lpDst: LPSTR->CHAR*
        ///nSize: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "ExpandEnvironmentStringsA")]
        public static extern uint ExpandEnvironmentStringsA(
            [In] [MarshalAs(UnmanagedType.LPStr)] string lpSrc, [Out] [MarshalAs(UnmanagedType.LPStr)] StringBuilder lpDst, uint nSize);

        /// Return Type: BOOL->int
        ///lpLanguageGroupEnumProc: LANGUAGEGROUP_ENUMPROCW
        ///dwFlags: DWORD->unsigned int
        ///lParam: LONG_PTR->int
        [DllImport("kernel32.dll", EntryPoint = "EnumSystemLanguageGroupsW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumSystemLanguageGroupsW(
            LANGUAGEGROUP_ENUMPROCW lpLanguageGroupEnumProc, uint dwFlags, [MarshalAs(UnmanagedType.SysInt)] int lParam);

        /// Return Type: BOOL->int
        ///lpLanguageGroupEnumProc: LANGUAGEGROUP_ENUMPROCA
        ///dwFlags: DWORD->unsigned int
        ///lParam: LONG_PTR->int
        [DllImport("kernel32.dll", EntryPoint = "EnumSystemLanguageGroupsA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumSystemLanguageGroupsA(
            LANGUAGEGROUP_ENUMPROCA lpLanguageGroupEnumProc, uint dwFlags, [MarshalAs(UnmanagedType.SysInt)] int lParam);

        /// Return Type: BOOL->int
        ///lpLangGroupLocaleEnumProc: LANGGROUPLOCALE_ENUMPROCW
        ///LanguageGroup: LGRPID->DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        ///lParam: LONG_PTR->int
        [DllImport("kernel32.dll", EntryPoint = "EnumLanguageGroupLocalesW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumLanguageGroupLocalesW(
            LANGGROUPLOCALE_ENUMPROCW lpLangGroupLocaleEnumProc, uint LanguageGroup, uint dwFlags, [MarshalAs(UnmanagedType.SysInt)] int lParam);

        /// Return Type: BOOL->int
        ///lpLangGroupLocaleEnumProc: LANGGROUPLOCALE_ENUMPROCA
        ///LanguageGroup: LGRPID->DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        ///lParam: LONG_PTR->int
        [DllImport("kernel32.dll", EntryPoint = "EnumLanguageGroupLocalesA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumLanguageGroupLocalesA(
            LANGGROUPLOCALE_ENUMPROCA lpLangGroupLocaleEnumProc, uint LanguageGroup, uint dwFlags, [MarshalAs(UnmanagedType.SysInt)] int lParam);

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
            uint dwDesiredAccess, uint dwShareMode, ref SECURITY_ATTRIBUTES lpSecurityAttributes, uint dwFlags, IntPtr lpScreenBufferData);

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
        [DllImport("kernel32.dll", EntryPoint = "GetSystemWow64DirectoryW")]
        public static extern uint GetSystemWow64DirectoryW([Out] [MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpBuffer, uint uSize);

        /// Return Type: UINT->unsigned int
        ///lpBuffer: LPSTR->CHAR*
        ///uSize: UINT->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetSystemWow64DirectoryA")]
        public static extern uint GetSystemWow64DirectoryA([Out] [MarshalAs(UnmanagedType.LPStr)] StringBuilder lpBuffer, uint uSize);

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
        [DllImport("kernel32.dll", EntryPoint = "GetPrivateProfileStructW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetPrivateProfileStructW(
            [In] [MarshalAs(UnmanagedType.LPWStr)] string lpszSection, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpszKey, IntPtr lpStruct, uint uSizeStruct,
            [In] [MarshalAs(UnmanagedType.LPWStr)] string szFile);

        /// Return Type: BOOL->int
        ///lpszSection: LPCSTR->CHAR*
        ///lpszKey: LPCSTR->CHAR*
        ///lpStruct: LPVOID->void*
        ///uSizeStruct: UINT->unsigned int
        ///szFile: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetPrivateProfileStructA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetPrivateProfileStructA(
            [In] [MarshalAs(UnmanagedType.LPStr)] string lpszSection, [In] [MarshalAs(UnmanagedType.LPStr)] string lpszKey, IntPtr lpStruct, uint uSizeStruct,
            [In] [MarshalAs(UnmanagedType.LPStr)] string szFile);

        /// Return Type: DWORD->unsigned int
        ///lpAppName: LPCWSTR->WCHAR*
        ///lpKeyName: LPCWSTR->WCHAR*
        ///lpDefault: LPCWSTR->WCHAR*
        ///lpReturnedString: LPWSTR->WCHAR*
        ///nSize: DWORD->unsigned int
        ///lpFileName: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetPrivateProfileStringW")]
        public static extern uint GetPrivateProfileStringW(
            [In] [MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName,
            [In] [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, [Out] [MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpReturnedString, uint nSize,
            [In] [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);

        /// Return Type: DWORD->unsigned int
        ///lpAppName: LPCSTR->CHAR*
        ///lpKeyName: LPCSTR->CHAR*
        ///lpDefault: LPCSTR->CHAR*
        ///lpReturnedString: LPSTR->CHAR*
        ///nSize: DWORD->unsigned int
        ///lpFileName: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetPrivateProfileStringA")]
        public static extern uint GetPrivateProfileStringA(
            [In] [MarshalAs(UnmanagedType.LPStr)] string lpAppName, [In] [MarshalAs(UnmanagedType.LPStr)] string lpKeyName,
            [In] [MarshalAs(UnmanagedType.LPStr)] string lpDefault, [Out] [MarshalAs(UnmanagedType.LPStr)] StringBuilder lpReturnedString, uint nSize,
            [In] [MarshalAs(UnmanagedType.LPStr)] string lpFileName);

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
        [DllImport("kernel32.dll", EntryPoint = "GetNamedPipeHandleStateW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetNamedPipeHandleStateW(
            [In] IntPtr hNamedPipe, IntPtr lpState, IntPtr lpCurInstances, IntPtr lpMaxCollectionCount, IntPtr lpCollectDataTimeout,
            [Out] [MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpUserName, uint nMaxUserNameSize);

        /// Return Type: BOOL->int
        ///hNamedPipe: HANDLE->void*
        ///lpState: LPDWORD->DWORD*
        ///lpCurInstances: LPDWORD->DWORD*
        ///lpMaxCollectionCount: LPDWORD->DWORD*
        ///lpCollectDataTimeout: LPDWORD->DWORD*
        ///lpUserName: LPSTR->CHAR*
        ///nMaxUserNameSize: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetNamedPipeHandleStateA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetNamedPipeHandleStateA(
            [In] IntPtr hNamedPipe, IntPtr lpState, IntPtr lpCurInstances, IntPtr lpMaxCollectionCount, IntPtr lpCollectDataTimeout,
            [Out] [MarshalAs(UnmanagedType.LPStr)] StringBuilder lpUserName, uint nMaxUserNameSize);

        /// Return Type: DWORD->unsigned int
        ///ExeName: LPWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetConsoleAliasesLengthW")]
        public static extern uint GetConsoleAliasesLengthW([MarshalAs(UnmanagedType.LPWStr)] StringBuilder ExeName);

        /// Return Type: DWORD->unsigned int
        ///ExeName: LPSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetConsoleAliasesLengthA")]
        public static extern uint GetConsoleAliasesLengthA([MarshalAs(UnmanagedType.LPStr)] StringBuilder ExeName);

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
        [DllImport("kernel32.dll", EntryPoint = "FindActCtxSectionStringW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FindActCtxSectionStringW(
            uint dwFlags, IntPtr lpExtensionGuid, uint ulSectionId, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpStringToFind,
            [Out] out tagACTCTX_SECTION_KEYED_DATA ReturnedData);

        /// Return Type: BOOL->int
        ///dwFlags: DWORD->unsigned int
        ///lpExtensionGuid: GUID*
        ///ulSectionId: ULONG->unsigned int
        ///lpStringToFind: LPCSTR->CHAR*
        ///ReturnedData: PACTCTX_SECTION_KEYED_DATA->tagACTCTX_SECTION_KEYED_DATA*
        [DllImport("kernel32.dll", EntryPoint = "FindActCtxSectionStringA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FindActCtxSectionStringA(
            uint dwFlags, IntPtr lpExtensionGuid, uint ulSectionId, [In] [MarshalAs(UnmanagedType.LPStr)] string lpStringToFind,
            [Out] out tagACTCTX_SECTION_KEYED_DATA ReturnedData);

        /// Return Type: BOOL->int
        ///lpDef: LPCWSTR->WCHAR*
        ///lpDCB: LPDCB->_DCB*
        ///lpCommTimeouts: LPCOMMTIMEOUTS->_COMMTIMEOUTS*
        [DllImport("kernel32.dll", EntryPoint = "BuildCommDCBAndTimeoutsW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool BuildCommDCBAndTimeoutsW(
            [In] [MarshalAs(UnmanagedType.LPWStr)] string lpDef, [Out] out DCB lpDCB, [Out] out COMMTIMEOUTS lpCommTimeouts);

        /// Return Type: BOOL->int
        ///lpDef: LPCSTR->CHAR*
        ///lpDCB: LPDCB->_DCB*
        ///lpCommTimeouts: LPCOMMTIMEOUTS->_COMMTIMEOUTS*
        [DllImport("kernel32.dll", EntryPoint = "BuildCommDCBAndTimeoutsA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool BuildCommDCBAndTimeoutsA(
            [In] [MarshalAs(UnmanagedType.LPStr)] string lpDef, [Out] out DCB lpDCB, [Out] out COMMTIMEOUTS lpCommTimeouts);

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
        public static extern uint SetThreadExecutionState(uint esFlags);

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
        [DllImport("kernel32.dll", EntryPoint = "SetEnvironmentVariableW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetEnvironmentVariableW(
            [In] [MarshalAs(UnmanagedType.LPWStr)] string lpName, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpValue);

        /// Return Type: BOOL->int
        ///lpName: LPCSTR->CHAR*
        ///lpValue: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "SetEnvironmentVariableA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetEnvironmentVariableA(
            [In] [MarshalAs(UnmanagedType.LPStr)] string lpName, [In] [MarshalAs(UnmanagedType.LPStr)] string lpValue);

        /// Return Type: BOOL->int
        ///hConsoleOutput: HANDLE->void*
        ///wAttributes: WORD->unsigned short
        [DllImport("kernel32.dll", EntryPoint = "SetConsoleTextAttribute")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetConsoleTextAttribute(IntPtr hConsoleOutput, ushort wAttributes);

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
        [DllImport("kernel32.dll", EntryPoint = "GetLogicalDriveStringsW")]
        public static extern uint GetLogicalDriveStringsW(uint nBufferLength, [Out] [MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpBuffer);

        /// Return Type: DWORD->unsigned int
        ///nBufferLength: DWORD->unsigned int
        ///lpBuffer: LPSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetLogicalDriveStringsA")]
        public static extern uint GetLogicalDriveStringsA(uint nBufferLength, [Out] [MarshalAs(UnmanagedType.LPStr)] StringBuilder lpBuffer);

        /// Return Type: DWORD->unsigned int
        ///lpName: LPCWSTR->WCHAR*
        ///lpBuffer: LPWSTR->WCHAR*
        ///nSize: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetEnvironmentVariableW")]
        public static extern uint GetEnvironmentVariableW(
            [In] [MarshalAs(UnmanagedType.LPWStr)] string lpName, [Out] [MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpBuffer, uint nSize);

        /// Return Type: DWORD->unsigned int
        ///lpName: LPCSTR->CHAR*
        ///lpBuffer: LPSTR->CHAR*
        ///nSize: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetEnvironmentVariableA")]
        public static extern uint GetEnvironmentVariableA(
            [In] [MarshalAs(UnmanagedType.LPStr)] string lpName, [Out] [MarshalAs(UnmanagedType.LPStr)] StringBuilder lpBuffer, uint nSize);

        /// Return Type: BOOL->int
        ///lpConsoleSelectionInfo: PCONSOLE_SELECTION_INFO->_CONSOLE_SELECTION_INFO*
        [DllImport("kernel32.dll", EntryPoint = "GetConsoleSelectionInfo")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetConsoleSelectionInfo(ref CONSOLE_SELECTION_INFO lpConsoleSelectionInfo);

        /// Return Type: BOOL->int
        ///param0: LPWCH->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "FreeEnvironmentStringsW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FreeEnvironmentStringsW([In] [MarshalAs(UnmanagedType.LPWStr)] string param0);

        /// Return Type: BOOL->int
        ///param0: LPCH->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "FreeEnvironmentStringsA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FreeEnvironmentStringsA([In] [MarshalAs(UnmanagedType.LPStr)] string param0);

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
        [DllImport("kernel32.dll", EntryPoint = "DeleteVolumeMountPointW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DeleteVolumeMountPointW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpszVolumeMountPoint);

        /// Return Type: BOOL->int
        ///lpszVolumeMountPoint: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "DeleteVolumeMountPointA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DeleteVolumeMountPointA([In] [MarshalAs(UnmanagedType.LPStr)] string lpszVolumeMountPoint);

        /// Return Type: BOOL->int
        ///lpName: LPCWSTR->WCHAR*
        ///lpOemName: LPSTR->CHAR*
        ///OemNameSize: DWORD->unsigned int
        ///pbNameContainsSpaces: PBOOL->BOOL*
        ///pbNameLegal: PBOOL->BOOL*
        [DllImport("kernel32.dll", EntryPoint = "CheckNameLegalDOS8Dot3W")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CheckNameLegalDOS8Dot3W(
            [In] [MarshalAs(UnmanagedType.LPWStr)] string lpName, [Out] [MarshalAs(UnmanagedType.LPStr)] StringBuilder lpOemName, uint OemNameSize,
            IntPtr pbNameContainsSpaces, [Out] out int pbNameLegal);

        /// Return Type: BOOL->int
        ///lpName: LPCSTR->CHAR*
        ///lpOemName: LPSTR->CHAR*
        ///OemNameSize: DWORD->unsigned int
        ///pbNameContainsSpaces: PBOOL->BOOL*
        ///pbNameLegal: PBOOL->BOOL*
        [DllImport("kernel32.dll", EntryPoint = "CheckNameLegalDOS8Dot3A")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CheckNameLegalDOS8Dot3A(
            [In] [MarshalAs(UnmanagedType.LPStr)] string lpName, [Out] [MarshalAs(UnmanagedType.LPStr)] StringBuilder lpOemName, uint OemNameSize,
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

        /// Return Type: LPWCH->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetEnvironmentStringsW")]
        public static extern IntPtr GetEnvironmentStringsW();

        /// Return Type: DWORD->unsigned int
        ///lpFileName: LPCWSTR->WCHAR*
        ///lpFileSizeHigh: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "GetCompressedFileSizeW")]
        public static extern uint GetCompressedFileSizeW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpFileName, [Out] out uint lpFileSizeHigh);

        /// Return Type: DWORD->unsigned int
        ///lpFileName: LPCSTR->CHAR*
        ///lpFileSizeHigh: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "GetCompressedFileSizeA")]
        public static extern uint GetCompressedFileSizeA([In] [MarshalAs(UnmanagedType.LPStr)] string lpFileName, [Out] out uint lpFileSizeHigh);

        /// Return Type: BOOL->int
        ///hModule: HMODULE->HINSTANCE->HINSTANCE__*
        ///lpType: LPCWSTR->WCHAR*
        ///lpName: LPCWSTR->WCHAR*
        ///lpEnumFunc: ENUMRESLANGPROCW
        ///lParam: LONG_PTR->int
        [DllImport("kernel32.dll", EntryPoint = "EnumResourceLanguagesW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumResourceLanguagesW(
            [In] IntPtr hModule, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpType, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpName,
            ENUMRESLANGPROCW lpEnumFunc, [MarshalAs(UnmanagedType.SysInt)] int lParam);

        /// Return Type: BOOL->int
        ///hModule: HMODULE->HINSTANCE->HINSTANCE__*
        ///lpType: LPCSTR->CHAR*
        ///lpName: LPCSTR->CHAR*
        ///lpEnumFunc: ENUMRESLANGPROCA
        ///lParam: LONG_PTR->int
        [DllImport("kernel32.dll", EntryPoint = "EnumResourceLanguagesA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumResourceLanguagesA(
            [In] IntPtr hModule, [In] [MarshalAs(UnmanagedType.LPStr)] string lpType, [In] [MarshalAs(UnmanagedType.LPStr)] string lpName,
            ENUMRESLANGPROCA lpEnumFunc, [MarshalAs(UnmanagedType.SysInt)] int lParam);

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
        [DllImport("kernel32.dll", EntryPoint = "SetDefaultCommConfigW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetDefaultCommConfigW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpszName, [In] IntPtr lpCC, uint dwSize);

        /// Return Type: BOOL->int
        ///lpszName: LPCSTR->CHAR*
        ///lpCC: LPCOMMCONFIG->_COMMCONFIG*
        ///dwSize: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "SetDefaultCommConfigA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetDefaultCommConfigA([In] [MarshalAs(UnmanagedType.LPStr)] string lpszName, [In] IntPtr lpCC, uint dwSize);

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
        [DllImport("kernel32.dll", EntryPoint = "ReadDirectoryChangesW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ReadDirectoryChangesW(
            [In] IntPtr hDirectory, IntPtr lpBuffer, uint nBufferLength, [MarshalAs(UnmanagedType.Bool)] bool bWatchSubtree, uint dwNotifyFilter,
            [Out] out uint lpBytesReturned, ref OVERLAPPED lpOverlapped, LPOVERLAPPED_COMPLETION_ROUTINE lpCompletionRoutine);

        /// Return Type: BOOL->int
        ///lpExistingFileName: LPCWSTR->WCHAR*
        ///lpNewFileName: LPCWSTR->WCHAR*
        ///lpProgressRoutine: LPPROGRESS_ROUTINE
        ///lpData: LPVOID->void*
        ///dwFlags: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "MoveFileWithProgressW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool MoveFileWithProgressW(
            [In] [MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpNewFileName,
            LPPROGRESS_ROUTINE lpProgressRoutine, [In] IntPtr lpData, uint dwFlags);

        /// Return Type: BOOL->int
        ///lpExistingFileName: LPCSTR->CHAR*
        ///lpNewFileName: LPCSTR->CHAR*
        ///lpProgressRoutine: LPPROGRESS_ROUTINE
        ///lpData: LPVOID->void*
        ///dwFlags: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "MoveFileWithProgressA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool MoveFileWithProgressA(
            [In] [MarshalAs(UnmanagedType.LPStr)] string lpExistingFileName, [In] [MarshalAs(UnmanagedType.LPStr)] string lpNewFileName,
            LPPROGRESS_ROUTINE lpProgressRoutine, [In] IntPtr lpData, uint dwFlags);

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
        [DllImport("kernel32.dll", EntryPoint = "GetVolumeInformationW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetVolumeInformationW(
            [In] [MarshalAs(UnmanagedType.LPWStr)] string lpRootPathName, [Out] [MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpVolumeNameBuffer,
            uint nVolumeNameSize, IntPtr lpVolumeSerialNumber, IntPtr lpMaximumComponentLength, IntPtr lpFileSystemFlags,
            [Out] [MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpFileSystemNameBuffer, uint nFileSystemNameSize);

        /// Return Type: BOOL->int
        ///lpRootPathName: LPCSTR->CHAR*
        ///lpVolumeNameBuffer: LPSTR->CHAR*
        ///nVolumeNameSize: DWORD->unsigned int
        ///lpVolumeSerialNumber: LPDWORD->DWORD*
        ///lpMaximumComponentLength: LPDWORD->DWORD*
        ///lpFileSystemFlags: LPDWORD->DWORD*
        ///lpFileSystemNameBuffer: LPSTR->CHAR*
        ///nFileSystemNameSize: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetVolumeInformationA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetVolumeInformationA(
            [In] [MarshalAs(UnmanagedType.LPStr)] string lpRootPathName, [Out] [MarshalAs(UnmanagedType.LPStr)] StringBuilder lpVolumeNameBuffer,
            uint nVolumeNameSize, IntPtr lpVolumeSerialNumber, IntPtr lpMaximumComponentLength, IntPtr lpFileSystemFlags,
            [Out] [MarshalAs(UnmanagedType.LPStr)] StringBuilder lpFileSystemNameBuffer, uint nFileSystemNameSize);

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
        [DllImport("kernel32.dll", EntryPoint = "GetPrivateProfileIntW")]
        public static extern uint GetPrivateProfileIntW(
            [In] [MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, int nDefault,
            [In] [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);

        /// Return Type: UINT->unsigned int
        ///lpAppName: LPCSTR->CHAR*
        ///lpKeyName: LPCSTR->CHAR*
        ///nDefault: INT->int
        ///lpFileName: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetPrivateProfileIntA")]
        public static extern uint GetPrivateProfileIntA(
            [In] [MarshalAs(UnmanagedType.LPStr)] string lpAppName, [In] [MarshalAs(UnmanagedType.LPStr)] string lpKeyName, int nDefault,
            [In] [MarshalAs(UnmanagedType.LPStr)] string lpFileName);

        /// Return Type: LPCH->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetEnvironmentStrings")]
        public static extern IntPtr GetEnvironmentStrings();

        /// Return Type: BOOL->int
        ///lpszName: LPCWSTR->WCHAR*
        ///lpCC: LPCOMMCONFIG->_COMMCONFIG*
        ///lpdwSize: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "GetDefaultCommConfigW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetDefaultCommConfigW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpszName, IntPtr lpCC, ref uint lpdwSize);

        /// Return Type: BOOL->int
        ///lpszName: LPCSTR->CHAR*
        ///lpCC: LPCOMMCONFIG->_COMMCONFIG*
        ///lpdwSize: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "GetDefaultCommConfigA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetDefaultCommConfigA([In] [MarshalAs(UnmanagedType.LPStr)] string lpszName, IntPtr lpCC, ref uint lpdwSize);

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
        public static extern bool GetConsoleDisplayMode(ref uint lpModeFlags);

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
            uint dwFlags, IntPtr lpExtensionGuid, uint ulSectionId, [In] IntPtr lpGuidToFind, [Out] out tagACTCTX_SECTION_KEYED_DATA ReturnedData);

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
            out IntPtr phNewTimer, [In] IntPtr TimerQueue, WAITORTIMERCALLBACKFUNC Callback, [In] IntPtr Parameter, uint DueTime, uint Period, uint Flags);

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
        [DllImport("kernel32.dll", EntryPoint = "WriteProfileSectionW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WriteProfileSectionW(
            [In] [MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpString);

        /// Return Type: BOOL->int
        ///lpAppName: LPCSTR->CHAR*
        ///lpString: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "WriteProfileSectionA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WriteProfileSectionA(
            [In] [MarshalAs(UnmanagedType.LPStr)] string lpAppName, [In] [MarshalAs(UnmanagedType.LPStr)] string lpString);

        /// Return Type: BOOL->int
        ///lpSystemTime: SYSTEMTIME*
        ///lpFileTime: LPFILETIME->_FILETIME*
        [DllImport("kernel32.dll", EntryPoint = "SystemTimeToFileTime")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SystemTimeToFileTime([In] ref SYSTEMTIME lpSystemTime, [Out] out FILETIME lpFileTime);

        /// Return Type: BOOL->int
        ///lpszVolumeMountPoint: LPCWSTR->WCHAR*
        ///lpszVolumeName: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "SetVolumeMountPointW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetVolumeMountPointW(
            [In] [MarshalAs(UnmanagedType.LPWStr)] string lpszVolumeMountPoint, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpszVolumeName);

        /// Return Type: BOOL->int
        ///lpszVolumeMountPoint: LPCSTR->CHAR*
        ///lpszVolumeName: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "SetVolumeMountPointA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetVolumeMountPointA(
            [In] [MarshalAs(UnmanagedType.LPStr)] string lpszVolumeMountPoint, [In] [MarshalAs(UnmanagedType.LPStr)] string lpszVolumeName);

        /// Return Type: BOOL->int
        ///hObject: HANDLE->void*
        ///dwMask: DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "SetHandleInformation")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetHandleInformation([In] IntPtr hObject, uint dwMask, uint dwFlags);

        /// Return Type: BOOL->int
        ///lpPathName: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "SetCurrentDirectoryW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetCurrentDirectoryW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpPathName);

        /// Return Type: BOOL->int
        ///lpPathName: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "SetCurrentDirectoryA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetCurrentDirectoryA([In] [MarshalAs(UnmanagedType.LPStr)] string lpPathName);

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
        public static extern bool IsValidLanguageGroup(uint LanguageGroup, uint dwFlags);

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
        [DllImport("kernel32.dll", EntryPoint = "GetWindowsDirectoryW")]
        public static extern uint GetWindowsDirectoryW([Out] [MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpBuffer, uint uSize);

        /// Return Type: UINT->unsigned int
        ///lpBuffer: LPSTR->CHAR*
        ///uSize: UINT->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetWindowsDirectoryA")]
        public static extern uint GetWindowsDirectoryA([Out] [MarshalAs(UnmanagedType.LPStr)] StringBuilder lpBuffer, uint uSize);

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
        public static extern bool GetHandleInformation([In] IntPtr hObject, [Out] out uint lpdwFlags);

        /// Return Type: BOOL->int
        ///lpFileName: LPCWSTR->WCHAR*
        ///fInfoLevelId: GET_FILEEX_INFO_LEVELS->_GET_FILEEX_INFO_LEVELS
        ///lpFileInformation: LPVOID->void*
        [DllImport("kernel32.dll", EntryPoint = "GetFileAttributesExW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetFileAttributesExW(
            [In] [MarshalAs(UnmanagedType.LPWStr)] string lpFileName, GET_FILEEX_INFO_LEVELS fInfoLevelId, IntPtr lpFileInformation);

        /// Return Type: BOOL->int
        ///lpFileName: LPCSTR->CHAR*
        ///fInfoLevelId: GET_FILEEX_INFO_LEVELS->_GET_FILEEX_INFO_LEVELS
        ///lpFileInformation: LPVOID->void*
        [DllImport("kernel32.dll", EntryPoint = "GetFileAttributesExA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetFileAttributesExA(
            [In] [MarshalAs(UnmanagedType.LPStr)] string lpFileName, GET_FILEEX_INFO_LEVELS fInfoLevelId, IntPtr lpFileInformation);

        /// Return Type: DWORD->unsigned int
        ///nBufferLength: DWORD->unsigned int
        ///lpBuffer: LPWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetCurrentDirectoryW")]
        public static extern uint GetCurrentDirectoryW(uint nBufferLength, [Out] [MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpBuffer);

        /// Return Type: DWORD->unsigned int
        ///nBufferLength: DWORD->unsigned int
        ///lpBuffer: LPSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetCurrentDirectoryA")]
        public static extern uint GetCurrentDirectoryA(uint nBufferLength, [Out] [MarshalAs(UnmanagedType.LPStr)] StringBuilder lpBuffer);

        /// Return Type: BOOL->int
        ///hConsoleOutput: HANDLE->void*
        ///lpConsoleCursorInfo: PCONSOLE_CURSOR_INFO->_CONSOLE_CURSOR_INFO*
        [DllImport("kernel32.dll", EntryPoint = "GetConsoleCursorInfo")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetConsoleCursorInfo(IntPtr hConsoleOutput, ref CONSOLE_CURSOR_INFO lpConsoleCursorInfo);

        /// Return Type: DWORD->unsigned int
        ///ExeNameBuffer: LPWSTR->WCHAR*
        ///ExeNameBufferLength: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetConsoleAliasExesW")]
        public static extern uint GetConsoleAliasExesW([MarshalAs(UnmanagedType.LPWStr)] StringBuilder ExeNameBuffer, uint ExeNameBufferLength);

        /// Return Type: DWORD->unsigned int
        ///ExeNameBuffer: LPSTR->CHAR*
        ///ExeNameBufferLength: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetConsoleAliasExesA")]
        public static extern uint GetConsoleAliasExesA([MarshalAs(UnmanagedType.LPStr)] StringBuilder ExeNameBuffer, uint ExeNameBufferLength);

        /// Return Type: BOOL->int
        ///lpFileTime: FILETIME*
        ///lpSystemTime: LPSYSTEMTIME->_SYSTEMTIME*
        [DllImport("kernel32.dll", EntryPoint = "FileTimeToSystemTime")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FileTimeToSystemTime([In] ref FILETIME lpFileTime, [Out] out SYSTEMTIME lpSystemTime);

        /// Return Type: BOOL->int
        ///lpCodePageEnumProc: CODEPAGE_ENUMPROCW
        ///dwFlags: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "EnumSystemCodePagesW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumSystemCodePagesW(CODEPAGE_ENUMPROCW lpCodePageEnumProc, uint dwFlags);

        /// Return Type: BOOL->int
        ///lpCodePageEnumProc: CODEPAGE_ENUMPROCA
        ///dwFlags: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "EnumSystemCodePagesA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumSystemCodePagesA(CODEPAGE_ENUMPROCA lpCodePageEnumProc, uint dwFlags);

        /// Return Type: void
        ///lpCriticalSection: LPCRITICAL_SECTION->PRTL_CRITICAL_SECTION->_RTL_CRITICAL_SECTION*
        [DllImport("kernel32.dll", EntryPoint = "EnterCriticalSection")]
        public static extern void EnterCriticalSection(ref RTL_CRITICAL_SECTION lpCriticalSection);

        /// Return Type: HANDLE->void*
        ///lpTimerAttributes: LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        ///bManualReset: BOOL->int
        ///lpTimerName: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "CreateWaitableTimerW")]
        public static extern IntPtr CreateWaitableTimerW(
            [In] IntPtr lpTimerAttributes, [MarshalAs(UnmanagedType.Bool)] bool bManualReset, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpTimerName);

        /// Return Type: HANDLE->void*
        ///lpTimerAttributes: LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        ///bManualReset: BOOL->int
        ///lpTimerName: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "CreateWaitableTimerA")]
        public static extern IntPtr CreateWaitableTimerA(
            [In] IntPtr lpTimerAttributes, [MarshalAs(UnmanagedType.Bool)] bool bManualReset, [In] [MarshalAs(UnmanagedType.LPStr)] string lpTimerName);

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
        [DllImport("kernel32.dll", EntryPoint = "BeginUpdateResourceW")]
        public static extern IntPtr BeginUpdateResourceW(
            [In] [MarshalAs(UnmanagedType.LPWStr)] string pFileName, [MarshalAs(UnmanagedType.Bool)] bool bDeleteExistingResources);

        /// Return Type: HANDLE->void*
        ///pFileName: LPCSTR->CHAR*
        ///bDeleteExistingResources: BOOL->int
        [DllImport("kernel32.dll", EntryPoint = "BeginUpdateResourceA")]
        public static extern IntPtr BeginUpdateResourceA(
            [In] [MarshalAs(UnmanagedType.LPStr)] string pFileName, [MarshalAs(UnmanagedType.Bool)] bool bDeleteExistingResources);

        /// Return Type: BOOL->int
        ///lpAppName: LPCWSTR->WCHAR*
        ///lpKeyName: LPCWSTR->WCHAR*
        ///lpString: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "WriteProfileStringW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WriteProfileStringW(
            [In] [MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName,
            [In] [MarshalAs(UnmanagedType.LPWStr)] string lpString);

        /// Return Type: BOOL->int
        ///lpAppName: LPCSTR->CHAR*
        ///lpKeyName: LPCSTR->CHAR*
        ///lpString: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "WriteProfileStringA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WriteProfileStringA(
            [In] [MarshalAs(UnmanagedType.LPStr)] string lpAppName, [In] [MarshalAs(UnmanagedType.LPStr)] string lpKeyName,
            [In] [MarshalAs(UnmanagedType.LPStr)] string lpString);

        /// Return Type: BOOL->int
        ///hConsoleOutput: HANDLE->void*
        ///lpBuffer: CHAR_INFO*
        ///dwBufferSize: COORD->_COORD
        ///dwBufferCoord: COORD->_COORD
        ///lpWriteRegion: PSMALL_RECT->_SMALL_RECT*
        [DllImport("kernel32.dll", EntryPoint = "WriteConsoleOutputW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WriteConsoleOutputW(
            IntPtr hConsoleOutput, ref CHAR_INFO lpBuffer, COORD dwBufferSize, COORD dwBufferCoord, ref SMALL_RECT lpWriteRegion);

        /// Return Type: BOOL->int
        ///hConsoleOutput: HANDLE->void*
        ///lpBuffer: CHAR_INFO*
        ///dwBufferSize: COORD->_COORD
        ///dwBufferCoord: COORD->_COORD
        ///lpWriteRegion: PSMALL_RECT->_SMALL_RECT*
        [DllImport("kernel32.dll", EntryPoint = "WriteConsoleOutputA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WriteConsoleOutputA(
            IntPtr hConsoleOutput, ref CHAR_INFO lpBuffer, COORD dwBufferSize, COORD dwBufferCoord, ref SMALL_RECT lpWriteRegion);

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
            uint CodePage, uint dwFlags, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpWideCharStr, int cchWideChar, IntPtr lpMultiByteStr, int cbMultiByte,
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
            uint CodePage, uint dwFlags, [In] [MarshalAs(UnmanagedType.LPStr)] string lpMultiByteStr, int cbMultiByte,
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
        [DllImport("kernel32.dll", EntryPoint = "GetSystemDirectoryW")]
        public static extern uint GetSystemDirectoryW([Out] [MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpBuffer, uint uSize);

        /// Return Type: UINT->unsigned int
        ///lpBuffer: LPSTR->CHAR*
        ///uSize: UINT->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetSystemDirectoryA")]
        public static extern uint GetSystemDirectoryA([Out] [MarshalAs(UnmanagedType.LPStr)] StringBuilder lpBuffer, uint uSize);

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
        [DllImport("kernel32.dll", EntryPoint = "GetDiskFreeSpaceExW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetDiskFreeSpaceExW(
            [In] [MarshalAs(UnmanagedType.LPWStr)] string lpDirectoryName, IntPtr lpFreeBytesAvailableToCaller, IntPtr lpTotalNumberOfBytes,
            IntPtr lpTotalNumberOfFreeBytes);

        /// Return Type: BOOL->int
        ///lpDirectoryName: LPCSTR->CHAR*
        ///lpFreeBytesAvailableToCaller: PULARGE_INTEGER->ULARGE_INTEGER*
        ///lpTotalNumberOfBytes: PULARGE_INTEGER->ULARGE_INTEGER*
        ///lpTotalNumberOfFreeBytes: PULARGE_INTEGER->ULARGE_INTEGER*
        [DllImport("kernel32.dll", EntryPoint = "GetDiskFreeSpaceExA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetDiskFreeSpaceExA(
            [In] [MarshalAs(UnmanagedType.LPStr)] string lpDirectoryName, IntPtr lpFreeBytesAvailableToCaller, IntPtr lpTotalNumberOfBytes,
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
        [DllImport("kernel32.dll", EntryPoint = "EnumCalendarInfoExW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumCalendarInfoExW(CALINFO_ENUMPROCEXW lpCalInfoEnumProcEx, uint Locale, uint Calendar, uint CalType);

        /// Return Type: BOOL->int
        ///lpCalInfoEnumProcEx: CALINFO_ENUMPROCEXA
        ///Locale: LCID->DWORD->unsigned int
        ///Calendar: CALID->DWORD->unsigned int
        ///CalType: CALTYPE->DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "EnumCalendarInfoExA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumCalendarInfoExA(CALINFO_ENUMPROCEXA lpCalInfoEnumProcEx, uint Locale, uint Calendar, uint CalType);

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
        [DllImport("kernel32.dll", EntryPoint = "WriteConsoleInputW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WriteConsoleInputW(IntPtr hConsoleInput, ref INPUT_RECORD lpBuffer, uint nLength, ref uint lpNumberOfEventsWritten);

        /// Return Type: BOOL->int
        ///hConsoleInput: HANDLE->void*
        ///lpBuffer: INPUT_RECORD*
        ///nLength: DWORD->unsigned int
        ///lpNumberOfEventsWritten: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "WriteConsoleInputA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WriteConsoleInputA(IntPtr hConsoleInput, ref INPUT_RECORD lpBuffer, uint nLength, ref uint lpNumberOfEventsWritten);

        /// Return Type: BOOL->int
        ///lpVersionInformation: LPOSVERSIONINFOEXW->_OSVERSIONINFOEXW*
        ///dwTypeMask: DWORD->unsigned int
        ///dwlConditionMask: DWORDLONG->ULONGLONG->unsigned __int64
        [DllImport("kernel32.dll", EntryPoint = "VerifyVersionInfoW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool VerifyVersionInfoW(ref RTL_OSVERSIONINFOEXW lpVersionInformation, uint dwTypeMask, ulong dwlConditionMask);

        /// Return Type: BOOL->int
        ///lpVersionInformation: LPOSVERSIONINFOEXA->_OSVERSIONINFOEXA*
        ///dwTypeMask: DWORD->unsigned int
        ///dwlConditionMask: DWORDLONG->ULONGLONG->unsigned __int64
        [DllImport("kernel32.dll", EntryPoint = "VerifyVersionInfoA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool VerifyVersionInfoA(ref OSVERSIONINFOEXA lpVersionInformation, uint dwTypeMask, ulong dwlConditionMask);

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
        [DllImport("kernel32.dll", EntryPoint = "SetFileAttributesW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetFileAttributesW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpFileName, uint dwFileAttributes);

        /// Return Type: BOOL->int
        ///lpFileName: LPCSTR->CHAR*
        ///dwFileAttributes: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "SetFileAttributesA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetFileAttributesA([In] [MarshalAs(UnmanagedType.LPStr)] string lpFileName, uint dwFileAttributes);

        /// Return Type: BOOL->int
        ///wCodePageID: UINT->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "SetConsoleOutputCP")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetConsoleOutputCP(uint wCodePageID);

        /// Return Type: BOOL->int
        ///NameType: COMPUTER_NAME_FORMAT->_COMPUTER_NAME_FORMAT
        ///lpBuffer: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "SetComputerNameExW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetComputerNameExW(COMPUTER_NAME_FORMAT NameType, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpBuffer);

        /// Return Type: BOOL->int
        ///NameType: COMPUTER_NAME_FORMAT->_COMPUTER_NAME_FORMAT
        ///lpBuffer: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "SetComputerNameExA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetComputerNameExA(COMPUTER_NAME_FORMAT NameType, [In] [MarshalAs(UnmanagedType.LPStr)] string lpBuffer);

        /// Return Type: BOOL->int
        ///hConsoleOutput: HANDLE->void*
        ///lpBuffer: PCHAR_INFO->_CHAR_INFO*
        ///dwBufferSize: COORD->_COORD
        ///dwBufferCoord: COORD->_COORD
        ///lpReadRegion: PSMALL_RECT->_SMALL_RECT*
        [DllImport("kernel32.dll", EntryPoint = "ReadConsoleOutputW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ReadConsoleOutputW(
            IntPtr hConsoleOutput, ref CHAR_INFO lpBuffer, COORD dwBufferSize, COORD dwBufferCoord, ref SMALL_RECT lpReadRegion);

        /// Return Type: BOOL->int
        ///hConsoleOutput: HANDLE->void*
        ///lpBuffer: PCHAR_INFO->_CHAR_INFO*
        ///dwBufferSize: COORD->_COORD
        ///dwBufferCoord: COORD->_COORD
        ///lpReadRegion: PSMALL_RECT->_SMALL_RECT*
        [DllImport("kernel32.dll", EntryPoint = "ReadConsoleOutputA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ReadConsoleOutputA(
            IntPtr hConsoleOutput, ref CHAR_INFO lpBuffer, COORD dwBufferSize, COORD dwBufferCoord, ref SMALL_RECT lpReadRegion);

        /// Return Type: void
        ///lpOutputString: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "OutputDebugStringW")]
        public static extern void OutputDebugStringW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpOutputString);

        /// Return Type: void
        ///lpOutputString: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "OutputDebugStringA")]
        public static extern void OutputDebugStringA([In] [MarshalAs(UnmanagedType.LPStr)] string lpOutputString);

        /// Return Type: HANDLE->void*
        ///dwDesiredAccess: DWORD->unsigned int
        ///bInheritHandle: BOOL->int
        ///lpTimerName: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "OpenWaitableTimerW")]
        public static extern IntPtr OpenWaitableTimerW(
            uint dwDesiredAccess, [MarshalAs(UnmanagedType.Bool)] bool bInheritHandle, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpTimerName);

        /// Return Type: HANDLE->void*
        ///dwDesiredAccess: DWORD->unsigned int
        ///bInheritHandle: BOOL->int
        ///lpTimerName: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "OpenWaitableTimerA")]
        public static extern IntPtr OpenWaitableTimerA(
            uint dwDesiredAccess, [MarshalAs(UnmanagedType.Bool)] bool bInheritHandle, [In] [MarshalAs(UnmanagedType.LPStr)] string lpTimerName);

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
        [DllImport("kernel32.dll", EntryPoint = "GlobalGetAtomNameW")]
        public static extern uint GlobalGetAtomNameW(ushort nAtom, [Out] [MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpBuffer, int nSize);

        /// Return Type: UINT->unsigned int
        ///nAtom: ATOM->WORD->unsigned short
        ///lpBuffer: LPSTR->CHAR*
        ///nSize: int
        [DllImport("kernel32.dll", EntryPoint = "GlobalGetAtomNameA")]
        public static extern uint GlobalGetAtomNameA(ushort nAtom, [Out] [MarshalAs(UnmanagedType.LPStr)] StringBuilder lpBuffer, int nSize);

        /// Return Type: BOOL->int
        ///lpszFileName: LPCWSTR->WCHAR*
        ///lpszVolumePathName: LPWSTR->WCHAR*
        ///cchBufferLength: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetVolumePathNameW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetVolumePathNameW(
            [In] [MarshalAs(UnmanagedType.LPWStr)] string lpszFileName, [Out] [MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpszVolumePathName,
            uint cchBufferLength);

        /// Return Type: BOOL->int
        ///lpszFileName: LPCSTR->CHAR*
        ///lpszVolumePathName: LPSTR->CHAR*
        ///cchBufferLength: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetVolumePathNameA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetVolumePathNameA(
            [In] [MarshalAs(UnmanagedType.LPStr)] string lpszFileName, [Out] [MarshalAs(UnmanagedType.LPStr)] StringBuilder lpszVolumePathName,
            uint cchBufferLength);

        /// Return Type: LCID->DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetUserDefaultLCID")]
        public static extern uint GetUserDefaultLCID();

        /// Return Type: DWORD->unsigned int
        ///lpAppName: LPCWSTR->WCHAR*
        ///lpReturnedString: LPWSTR->WCHAR*
        ///nSize: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetProfileSectionW")]
        public static extern uint GetProfileSectionW(
            [In] [MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [Out] [MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpReturnedString, uint nSize);

        /// Return Type: DWORD->unsigned int
        ///lpAppName: LPCSTR->CHAR*
        ///lpReturnedString: LPSTR->CHAR*
        ///nSize: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetProfileSectionA")]
        public static extern uint GetProfileSectionA(
            [In] [MarshalAs(UnmanagedType.LPStr)] string lpAppName, [Out] [MarshalAs(UnmanagedType.LPStr)] StringBuilder lpReturnedString, uint nSize);

        /// Return Type: BOOL->int
        ///dwFlags: DWORD->unsigned int
        ///lpModuleName: LPCWSTR->WCHAR*
        ///phModule: HMODULE*
        [DllImport("kernel32.dll", EntryPoint = "GetModuleHandleExW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetModuleHandleExW(uint dwFlags, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpModuleName, ref IntPtr phModule);

        /// Return Type: BOOL->int
        ///dwFlags: DWORD->unsigned int
        ///lpModuleName: LPCSTR->CHAR*
        ///phModule: HMODULE*
        [DllImport("kernel32.dll", EntryPoint = "GetModuleHandleExA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetModuleHandleExA(uint dwFlags, [In] [MarshalAs(UnmanagedType.LPStr)] string lpModuleName, ref IntPtr phModule);

        /// Return Type: DWORD->unsigned int
        ///hModule: HMODULE->HINSTANCE->HINSTANCE__*
        ///lpFilename: LPWCH->WCHAR*
        ///nSize: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetModuleFileNameW")]
        public static extern uint GetModuleFileNameW([In] IntPtr hModule, [Out] [MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpFilename, uint nSize);

        /// Return Type: DWORD->unsigned int
        ///hModule: HMODULE->HINSTANCE->HINSTANCE__*
        ///lpFilename: LPCH->CHAR*
        ///nSize: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetModuleFileNameA")]
        public static extern uint GetModuleFileNameA([In] IntPtr hModule, [Out] [MarshalAs(UnmanagedType.LPStr)] StringBuilder lpFilename, uint nSize);

        /// Return Type: DWORD->unsigned int
        ///lpFileName: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetFileAttributesW")]
        public static extern uint GetFileAttributesW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);

        /// Return Type: DWORD->unsigned int
        ///lpFileName: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetFileAttributesA")]
        public static extern uint GetFileAttributesA([In] [MarshalAs(UnmanagedType.LPStr)] string lpFileName);

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
        [DllImport("kernel32.dll", EntryPoint = "GetCurrencyFormatW")]
        public static extern int GetCurrencyFormatW(
            uint Locale, uint dwFlags, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpValue, [In] IntPtr lpFormat,
            [Out] [MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpCurrencyStr, int cchCurrency);

        /// Return Type: int
        ///Locale: LCID->DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        ///lpValue: LPCSTR->CHAR*
        ///lpFormat: CURRENCYFMTA*
        ///lpCurrencyStr: LPSTR->CHAR*
        ///cchCurrency: int
        [DllImport("kernel32.dll", EntryPoint = "GetCurrencyFormatA")]
        public static extern int GetCurrencyFormatA(
            uint Locale, uint dwFlags, [In] [MarshalAs(UnmanagedType.LPStr)] string lpValue, [In] IntPtr lpFormat,
            [Out] [MarshalAs(UnmanagedType.LPStr)] StringBuilder lpCurrencyStr, int cchCurrency);

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
        [DllImport("kernel32.dll", EntryPoint = "GetConsoleAliasesW")]
        public static extern uint GetConsoleAliasesW(
            [MarshalAs(UnmanagedType.LPWStr)] StringBuilder AliasBuffer, uint AliasBufferLength, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder ExeName);

        /// Return Type: DWORD->unsigned int
        ///AliasBuffer: LPSTR->CHAR*
        ///AliasBufferLength: DWORD->unsigned int
        ///ExeName: LPSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetConsoleAliasesA")]
        public static extern uint GetConsoleAliasesA(
            [MarshalAs(UnmanagedType.LPStr)] StringBuilder AliasBuffer, uint AliasBufferLength, [MarshalAs(UnmanagedType.LPStr)] StringBuilder ExeName);

        /// Return Type: BOOL->int
        ///NameType: COMPUTER_NAME_FORMAT->_COMPUTER_NAME_FORMAT
        ///lpBuffer: LPWSTR->WCHAR*
        ///nSize: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "GetComputerNameExW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetComputerNameExW(
            COMPUTER_NAME_FORMAT NameType, [Out] [MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpBuffer, ref uint nSize);

        /// Return Type: BOOL->int
        ///NameType: COMPUTER_NAME_FORMAT->_COMPUTER_NAME_FORMAT
        ///lpBuffer: LPSTR->CHAR*
        ///nSize: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "GetComputerNameExA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetComputerNameExA(
            COMPUTER_NAME_FORMAT NameType, [Out] [MarshalAs(UnmanagedType.LPStr)] StringBuilder lpBuffer, ref uint nSize);

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
        [DllImport("kernel32.dll", EntryPoint = "EnumSystemLocalesW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumSystemLocalesW(LOCALE_ENUMPROCW lpLocaleEnumProc, uint dwFlags);

        /// Return Type: BOOL->int
        ///lpLocaleEnumProc: LOCALE_ENUMPROCA
        ///dwFlags: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "EnumSystemLocalesA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumSystemLocalesA(LOCALE_ENUMPROCA lpLocaleEnumProc, uint dwFlags);

        /// Return Type: BOOL->int
        ///hModule: HMODULE->HINSTANCE->HINSTANCE__*
        ///lpEnumFunc: ENUMRESTYPEPROCW
        ///lParam: LONG_PTR->int
        [DllImport("kernel32.dll", EntryPoint = "EnumResourceTypesW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumResourceTypesW([In] IntPtr hModule, ENUMRESTYPEPROCW lpEnumFunc, [MarshalAs(UnmanagedType.SysInt)] int lParam);

        /// Return Type: BOOL->int
        ///hModule: HMODULE->HINSTANCE->HINSTANCE__*
        ///lpEnumFunc: ENUMRESTYPEPROCA
        ///lParam: LONG_PTR->int
        [DllImport("kernel32.dll", EntryPoint = "EnumResourceTypesA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumResourceTypesA([In] IntPtr hModule, ENUMRESTYPEPROCA lpEnumFunc, [MarshalAs(UnmanagedType.SysInt)] int lParam);

        /// Return Type: BOOL->int
        ///hModule: HMODULE->HINSTANCE->HINSTANCE__*
        ///lpType: LPCWSTR->WCHAR*
        ///lpEnumFunc: ENUMRESNAMEPROCW
        ///lParam: LONG_PTR->int
        [DllImport("kernel32.dll", EntryPoint = "EnumResourceNamesW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumResourceNamesW(
            [In] IntPtr hModule, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpType, ENUMRESNAMEPROCW lpEnumFunc, [MarshalAs(UnmanagedType.SysInt)] int lParam);

        /// Return Type: BOOL->int
        ///hModule: HMODULE->HINSTANCE->HINSTANCE__*
        ///lpType: LPCSTR->CHAR*
        ///lpEnumFunc: ENUMRESNAMEPROCA
        ///lParam: LONG_PTR->int
        [DllImport("kernel32.dll", EntryPoint = "EnumResourceNamesA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumResourceNamesA(
            [In] IntPtr hModule, [In] [MarshalAs(UnmanagedType.LPStr)] string lpType, ENUMRESNAMEPROCA lpEnumFunc, [MarshalAs(UnmanagedType.SysInt)] int lParam);

        /// Return Type: BOOL->int
        ///lpDateFmtEnumProcEx: DATEFMT_ENUMPROCEXW
        ///Locale: LCID->DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "EnumDateFormatsExW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumDateFormatsExW(DATEFMT_ENUMPROCEXW lpDateFmtEnumProcEx, uint Locale, uint dwFlags);

        /// Return Type: BOOL->int
        ///lpDateFmtEnumProcEx: DATEFMT_ENUMPROCEXA
        ///Locale: LCID->DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "EnumDateFormatsExA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumDateFormatsExA(DATEFMT_ENUMPROCEXA lpDateFmtEnumProcEx, uint Locale, uint dwFlags);

        /// Return Type: BOOL->int
        ///hUpdate: HANDLE->void*
        ///fDiscard: BOOL->int
        [DllImport("kernel32.dll", EntryPoint = "EndUpdateResourceW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EndUpdateResourceW([In] IntPtr hUpdate, [MarshalAs(UnmanagedType.Bool)] bool fDiscard);

        /// Return Type: BOOL->int
        ///hUpdate: HANDLE->void*
        ///fDiscard: BOOL->int
        [DllImport("kernel32.dll", EntryPoint = "EndUpdateResourceA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EndUpdateResourceA([In] IntPtr hUpdate, [MarshalAs(UnmanagedType.Bool)] bool fDiscard);

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
            [In] IntPtr hProcess, [In] IntPtr lpThreadAttributes, uint dwStackSize, PTHREAD_START_ROUTINE lpStartAddress, [In] IntPtr lpParameter,
            uint dwCreationFlags, IntPtr lpThreadId);

        /// Return Type: HANDLE->void*
        ///hFile: HANDLE->void*
        ///lpFileMappingAttributes: LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        ///flProtect: DWORD->unsigned int
        ///dwMaximumSizeHigh: DWORD->unsigned int
        ///dwMaximumSizeLow: DWORD->unsigned int
        ///lpName: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "CreateFileMappingW")]
        public static extern IntPtr CreateFileMappingW(
            [In] IntPtr hFile, [In] IntPtr lpFileMappingAttributes, uint flProtect, uint dwMaximumSizeHigh, uint dwMaximumSizeLow,
            [In] [MarshalAs(UnmanagedType.LPWStr)] string lpName);

        /// Return Type: HANDLE->void*
        ///hFile: HANDLE->void*
        ///lpFileMappingAttributes: LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        ///flProtect: DWORD->unsigned int
        ///dwMaximumSizeHigh: DWORD->unsigned int
        ///dwMaximumSizeLow: DWORD->unsigned int
        ///lpName: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "CreateFileMappingA")]
        public static extern IntPtr CreateFileMappingA(
            [In] IntPtr hFile, [In] IntPtr lpFileMappingAttributes, uint flProtect, uint dwMaximumSizeHigh, uint dwMaximumSizeLow,
            [In] [MarshalAs(UnmanagedType.LPStr)] string lpName);

        /// Return Type: BOOL->int
        ///lpTemplateDirectory: LPCWSTR->WCHAR*
        ///lpNewDirectory: LPCWSTR->WCHAR*
        ///lpSecurityAttributes: LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        [DllImport("kernel32.dll", EntryPoint = "CreateDirectoryExW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CreateDirectoryExW(
            [In] [MarshalAs(UnmanagedType.LPWStr)] string lpTemplateDirectory, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpNewDirectory,
            [In] IntPtr lpSecurityAttributes);

        /// Return Type: BOOL->int
        ///lpTemplateDirectory: LPCSTR->CHAR*
        ///lpNewDirectory: LPCSTR->CHAR*
        ///lpSecurityAttributes: LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        [DllImport("kernel32.dll", EntryPoint = "CreateDirectoryExA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CreateDirectoryExA(
            [In] [MarshalAs(UnmanagedType.LPStr)] string lpTemplateDirectory, [In] [MarshalAs(UnmanagedType.LPStr)] string lpNewDirectory,
            [In] IntPtr lpSecurityAttributes);

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
        [DllImport("kernel32.dll", EntryPoint = "SetFileShortNameW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetFileShortNameW([In] IntPtr hFile, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpShortName);

        /// Return Type: BOOL->int
        ///hFile: HANDLE->void*
        ///lpShortName: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "SetFileShortNameA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetFileShortNameA([In] IntPtr hFile, [In] [MarshalAs(UnmanagedType.LPStr)] string lpShortName);

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
        [DllImport("kernel32.dll", EntryPoint = "ReadConsoleInputW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ReadConsoleInputW(IntPtr hConsoleInput, ref INPUT_RECORD lpBuffer, uint nLength, ref uint lpNumberOfEventsRead);

        /// Return Type: BOOL->int
        ///hConsoleInput: HANDLE->void*
        ///lpBuffer: PINPUT_RECORD->_INPUT_RECORD*
        ///nLength: DWORD->unsigned int
        ///lpNumberOfEventsRead: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "ReadConsoleInputA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ReadConsoleInputA(IntPtr hConsoleInput, ref INPUT_RECORD lpBuffer, uint nLength, ref uint lpNumberOfEventsRead);

        /// Return Type: BOOL->int
        ///Function: LPTHREAD_START_ROUTINE->PTHREAD_START_ROUTINE
        ///Context: PVOID->void*
        ///Flags: ULONG->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "QueueUserWorkItem")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool QueueUserWorkItem(PTHREAD_START_ROUTINE Function, [In] IntPtr Context, uint Flags);

        /// Return Type: BOOL->int
        ///hConsoleInput: HANDLE->void*
        ///lpBuffer: PINPUT_RECORD->_INPUT_RECORD*
        ///nLength: DWORD->unsigned int
        ///lpNumberOfEventsRead: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "PeekConsoleInputW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PeekConsoleInputW(IntPtr hConsoleInput, ref INPUT_RECORD lpBuffer, uint nLength, ref uint lpNumberOfEventsRead);

        /// Return Type: BOOL->int
        ///hConsoleInput: HANDLE->void*
        ///lpBuffer: PINPUT_RECORD->_INPUT_RECORD*
        ///nLength: DWORD->unsigned int
        ///lpNumberOfEventsRead: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "PeekConsoleInputA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PeekConsoleInputA(IntPtr hConsoleInput, ref INPUT_RECORD lpBuffer, uint nLength, ref uint lpNumberOfEventsRead);

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
        [DllImport("kernel32.dll", EntryPoint = "GetShortPathNameW")]
        public static extern uint GetShortPathNameW(
            [In] [MarshalAs(UnmanagedType.LPWStr)] string lpszLongPath, [Out] [MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpszShortPath, uint cchBuffer);

        /// Return Type: DWORD->unsigned int
        ///lpszLongPath: LPCSTR->CHAR*
        ///lpszShortPath: LPSTR->CHAR*
        ///cchBuffer: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetShortPathNameA")]
        public static extern uint GetShortPathNameA(
            [In] [MarshalAs(UnmanagedType.LPStr)] string lpszLongPath, [Out] [MarshalAs(UnmanagedType.LPStr)] StringBuilder lpszShortPath, uint cchBuffer);

        /// Return Type: DWORD->unsigned int
        ///lpAppName: LPCWSTR->WCHAR*
        ///lpKeyName: LPCWSTR->WCHAR*
        ///lpDefault: LPCWSTR->WCHAR*
        ///lpReturnedString: LPWSTR->WCHAR*
        ///nSize: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetProfileStringW")]
        public static extern uint GetProfileStringW(
            [In] [MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName,
            [In] [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, [Out] [MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpReturnedString, uint nSize);

        /// Return Type: DWORD->unsigned int
        ///lpAppName: LPCSTR->CHAR*
        ///lpKeyName: LPCSTR->CHAR*
        ///lpDefault: LPCSTR->CHAR*
        ///lpReturnedString: LPSTR->CHAR*
        ///nSize: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetProfileStringA")]
        public static extern uint GetProfileStringA(
            [In] [MarshalAs(UnmanagedType.LPStr)] string lpAppName, [In] [MarshalAs(UnmanagedType.LPStr)] string lpKeyName,
            [In] [MarshalAs(UnmanagedType.LPStr)] string lpDefault, [Out] [MarshalAs(UnmanagedType.LPStr)] StringBuilder lpReturnedString, uint nSize);

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
        [DllImport("kernel32.dll", EntryPoint = "GetDiskFreeSpaceW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetDiskFreeSpaceW(
            [In] [MarshalAs(UnmanagedType.LPWStr)] string lpRootPathName, IntPtr lpSectorsPerCluster, IntPtr lpBytesPerSector, IntPtr lpNumberOfFreeClusters,
            IntPtr lpTotalNumberOfClusters);

        /// Return Type: BOOL->int
        ///lpRootPathName: LPCSTR->CHAR*
        ///lpSectorsPerCluster: LPDWORD->DWORD*
        ///lpBytesPerSector: LPDWORD->DWORD*
        ///lpNumberOfFreeClusters: LPDWORD->DWORD*
        ///lpTotalNumberOfClusters: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "GetDiskFreeSpaceA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetDiskFreeSpaceA(
            [In] [MarshalAs(UnmanagedType.LPStr)] string lpRootPathName, IntPtr lpSectorsPerCluster, IntPtr lpBytesPerSector, IntPtr lpNumberOfFreeClusters,
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
        [DllImport("kernel32.dll", EntryPoint = "EnumCalendarInfoW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumCalendarInfoW(CALINFO_ENUMPROCW lpCalInfoEnumProc, uint Locale, uint Calendar, uint CalType);

        /// Return Type: BOOL->int
        ///lpCalInfoEnumProc: CALINFO_ENUMPROCA
        ///Locale: LCID->DWORD->unsigned int
        ///Calendar: CALID->DWORD->unsigned int
        ///CalType: CALTYPE->DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "EnumCalendarInfoA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumCalendarInfoA(CALINFO_ENUMPROCA lpCalInfoEnumProc, uint Locale, uint Calendar, uint CalType);

        /// Return Type: BOOL->int
        ///Process: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "DebugBreakProcess")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DebugBreakProcess([In] IntPtr Process);

        /// Return Type: BOOL->int
        ///lpszName: LPCWSTR->WCHAR*
        ///hWnd: HWND->HWND__*
        ///lpCC: LPCOMMCONFIG->_COMMCONFIG*
        [DllImport("kernel32.dll", EntryPoint = "CommConfigDialogW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CommConfigDialogW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpszName, [In] IntPtr hWnd, ref COMMCONFIG lpCC);

        /// Return Type: BOOL->int
        ///lpszName: LPCSTR->CHAR*
        ///hWnd: HWND->HWND__*
        ///lpCC: LPCOMMCONFIG->_COMMCONFIG*
        [DllImport("kernel32.dll", EntryPoint = "CommConfigDialogA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CommConfigDialogA([In] [MarshalAs(UnmanagedType.LPStr)] string lpszName, [In] IntPtr hWnd, ref COMMCONFIG lpCC);

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
        [DllImport("kernel32.dll", EntryPoint = "VerLanguageNameW")]
        public static extern uint VerLanguageNameW(uint wLang, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder szLang, uint nSize);

        /// Return Type: DWORD->unsigned int
        ///wLang: DWORD->unsigned int
        ///szLang: LPSTR->CHAR*
        ///nSize: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "VerLanguageNameA")]
        public static extern uint VerLanguageNameA(uint wLang, [MarshalAs(UnmanagedType.LPStr)] StringBuilder szLang, uint nSize);

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
        [DllImport("kernel32.dll", EntryPoint = "SetDllDirectoryW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetDllDirectoryW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpPathName);

        /// Return Type: BOOL->int
        ///lpPathName: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "SetDllDirectoryA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetDllDirectoryA([In] [MarshalAs(UnmanagedType.LPStr)] string lpPathName);

        /// Return Type: BOOL->int
        ///lpConsoleTitle: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "SetConsoleTitleW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetConsoleTitleW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpConsoleTitle);

        /// Return Type: BOOL->int
        ///lpConsoleTitle: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "SetConsoleTitleA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetConsoleTitleA([In] [MarshalAs(UnmanagedType.LPStr)] string lpConsoleTitle);

        /// Return Type: BOOL->int
        ///lpComputerName: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "SetComputerNameW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetComputerNameW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpComputerName);

        /// Return Type: BOOL->int
        ///lpComputerName: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "SetComputerNameA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetComputerNameA([In] [MarshalAs(UnmanagedType.LPStr)] string lpComputerName);

        /// Return Type: BOOL->int
        ///Locale: LCID->DWORD->unsigned int
        ///Calendar: CALID->DWORD->unsigned int
        ///CalType: CALTYPE->DWORD->unsigned int
        ///lpCalData: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "SetCalendarInfoW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetCalendarInfoW(uint Locale, uint Calendar, uint CalType, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpCalData);

        /// Return Type: BOOL->int
        ///Locale: LCID->DWORD->unsigned int
        ///Calendar: CALID->DWORD->unsigned int
        ///CalType: CALTYPE->DWORD->unsigned int
        ///lpCalData: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "SetCalendarInfoA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetCalendarInfoA(uint Locale, uint Calendar, uint CalType, [In] [MarshalAs(UnmanagedType.LPStr)] string lpCalData);

        /// Return Type: BOOL->int
        ///lpPathName: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "RemoveDirectoryW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool RemoveDirectoryW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpPathName);

        /// Return Type: BOOL->int
        ///lpPathName: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "RemoveDirectoryA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool RemoveDirectoryA([In] [MarshalAs(UnmanagedType.LPStr)] string lpPathName);

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
        [DllImport("kernel32.dll", EntryPoint = "OpenFileMappingW")]
        public static extern IntPtr OpenFileMappingW(
            uint dwDesiredAccess, [MarshalAs(UnmanagedType.Bool)] bool bInheritHandle, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpName);

        /// Return Type: HANDLE->void*
        ///dwDesiredAccess: DWORD->unsigned int
        ///bInheritHandle: BOOL->int
        ///lpName: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "OpenFileMappingA")]
        public static extern IntPtr OpenFileMappingA(
            uint dwDesiredAccess, [MarshalAs(UnmanagedType.Bool)] bool bInheritHandle, [In] [MarshalAs(UnmanagedType.LPStr)] string lpName);

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
        [DllImport("kernel32.dll", EntryPoint = "GetTempFileNameW")]
        public static extern uint GetTempFileNameW(
            [In] [MarshalAs(UnmanagedType.LPWStr)] string lpPathName, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpPrefixString, uint uUnique,
            [Out] [MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpTempFileName);

        /// Return Type: UINT->unsigned int
        ///lpPathName: LPCSTR->CHAR*
        ///lpPrefixString: LPCSTR->CHAR*
        ///uUnique: UINT->unsigned int
        ///lpTempFileName: LPSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetTempFileNameA")]
        public static extern uint GetTempFileNameA(
            [In] [MarshalAs(UnmanagedType.LPStr)] string lpPathName, [In] [MarshalAs(UnmanagedType.LPStr)] string lpPrefixString, uint uUnique,
            [Out] [MarshalAs(UnmanagedType.LPStr)] StringBuilder lpTempFileName);

        /// Return Type: BOOL->int
        ///Locale: LCID->DWORD->unsigned int
        ///dwInfoType: DWORD->unsigned int
        ///lpSrcStr: LPCWSTR->WCHAR*
        ///cchSrc: int
        ///lpCharType: LPWORD->WORD*
        [DllImport("kernel32.dll", EntryPoint = "GetStringTypeExW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetStringTypeExW(
            uint Locale, uint dwInfoType, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpSrcStr, int cchSrc, [Out] out ushort lpCharType);

        /// Return Type: BOOL->int
        ///Locale: LCID->DWORD->unsigned int
        ///dwInfoType: DWORD->unsigned int
        ///lpSrcStr: LPCSTR->CHAR*
        ///cchSrc: int
        ///lpCharType: LPWORD->WORD*
        [DllImport("kernel32.dll", EntryPoint = "GetStringTypeExA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetStringTypeExA(
            uint Locale, uint dwInfoType, [In] [MarshalAs(UnmanagedType.LPStr)] string lpSrcStr, int cchSrc, [Out] out ushort lpCharType);

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
        [DllImport("kernel32.dll", EntryPoint = "GetNumberFormatW")]
        public static extern int GetNumberFormatW(
            uint Locale, uint dwFlags, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpValue, [In] IntPtr lpFormat,
            [Out] [MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpNumberStr, int cchNumber);

        /// Return Type: int
        ///Locale: LCID->DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        ///lpValue: LPCSTR->CHAR*
        ///lpFormat: NUMBERFMTA*
        ///lpNumberStr: LPSTR->CHAR*
        ///cchNumber: int
        [DllImport("kernel32.dll", EntryPoint = "GetNumberFormatA")]
        public static extern int GetNumberFormatA(
            uint Locale, uint dwFlags, [In] [MarshalAs(UnmanagedType.LPStr)] string lpValue, [In] IntPtr lpFormat,
            [Out] [MarshalAs(UnmanagedType.LPStr)] StringBuilder lpNumberStr, int cchNumber);

        /// Return Type: BOOL->int
        ///hNamedPipe: HANDLE->void*
        ///lpFlags: LPDWORD->DWORD*
        ///lpOutBufferSize: LPDWORD->DWORD*
        ///lpInBufferSize: LPDWORD->DWORD*
        ///lpMaxInstances: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "GetNamedPipeInfo")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetNamedPipeInfo([In] IntPtr hNamedPipe, IntPtr lpFlags, IntPtr lpOutBufferSize, IntPtr lpInBufferSize, IntPtr lpMaxInstances);

        /// Return Type: HMODULE->HINSTANCE->HINSTANCE__*
        ///lpModuleName: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetModuleHandleW")]
        public static extern IntPtr GetModuleHandleW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpModuleName);

        /// Return Type: HMODULE->HINSTANCE->HINSTANCE__*
        ///lpModuleName: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetModuleHandleA")]
        public static extern IntPtr GetModuleHandleA([In] [MarshalAs(UnmanagedType.LPStr)] string lpModuleName);

        /// Return Type: DWORD->unsigned int
        ///lpszShortPath: LPCWSTR->WCHAR*
        ///lpszLongPath: LPWSTR->WCHAR*
        ///cchBuffer: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetLongPathNameW")]
        public static extern uint GetLongPathNameW(
            [In] [MarshalAs(UnmanagedType.LPWStr)] string lpszShortPath, [Out] [MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpszLongPath, uint cchBuffer);

        /// Return Type: DWORD->unsigned int
        ///lpszShortPath: LPCSTR->CHAR*
        ///lpszLongPath: LPSTR->CHAR*
        ///cchBuffer: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetLongPathNameA")]
        public static extern uint GetLongPathNameA(
            [In] [MarshalAs(UnmanagedType.LPStr)] string lpszShortPath, [Out] [MarshalAs(UnmanagedType.LPStr)] StringBuilder lpszLongPath, uint cchBuffer);

        /// Return Type: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetLogicalDrives")]
        public static extern uint GetLogicalDrives();

        /// Return Type: DWORD->unsigned int
        ///lpFileName: LPCWSTR->WCHAR*
        ///nBufferLength: DWORD->unsigned int
        ///lpBuffer: LPWSTR->WCHAR*
        ///lpFilePart: LPWSTR*
        [DllImport("kernel32.dll", EntryPoint = "GetFullPathNameW")]
        public static extern uint GetFullPathNameW(
            [In] [MarshalAs(UnmanagedType.LPWStr)] string lpFileName, uint nBufferLength, [Out] [MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpBuffer,
            ref IntPtr lpFilePart);

        /// Return Type: DWORD->unsigned int
        ///lpFileName: LPCSTR->CHAR*
        ///nBufferLength: DWORD->unsigned int
        ///lpBuffer: LPSTR->CHAR*
        ///lpFilePart: LPSTR*
        [DllImport("kernel32.dll", EntryPoint = "GetFullPathNameA")]
        public static extern uint GetFullPathNameA(
            [In] [MarshalAs(UnmanagedType.LPStr)] string lpFileName, uint nBufferLength, [Out] [MarshalAs(UnmanagedType.LPStr)] StringBuilder lpBuffer,
            ref IntPtr lpFilePart);

        /// Return Type: INT->int
        ///param0: LPWSTR->WCHAR*
        ///param1: LPWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetExpandedNameW")]
        public static extern int GetExpandedNameW(
            [MarshalAs(UnmanagedType.LPWStr)] StringBuilder param0, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder param1);

        /// Return Type: INT->int
        ///param0: LPSTR->CHAR*
        ///param1: LPSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetExpandedNameA")]
        public static extern int GetExpandedNameA([MarshalAs(UnmanagedType.LPStr)] StringBuilder param0, [MarshalAs(UnmanagedType.LPStr)] StringBuilder param1);

        /// Return Type: DWORD->unsigned int
        ///nBufferLength: DWORD->unsigned int
        ///lpBuffer: LPWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetDllDirectoryW")]
        public static extern uint GetDllDirectoryW(uint nBufferLength, [Out] [MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpBuffer);

        /// Return Type: DWORD->unsigned int
        ///nBufferLength: DWORD->unsigned int
        ///lpBuffer: LPSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetDllDirectoryA")]
        public static extern uint GetDllDirectoryA(uint nBufferLength, [Out] [MarshalAs(UnmanagedType.LPStr)] StringBuilder lpBuffer);

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
        [DllImport("kernel32.dll", EntryPoint = "GetConsoleTitleW")]
        public static extern uint GetConsoleTitleW([MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpConsoleTitle, uint nSize);

        /// Return Type: DWORD->unsigned int
        ///lpConsoleTitle: LPSTR->CHAR*
        ///nSize: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetConsoleTitleA")]
        public static extern uint GetConsoleTitleA([MarshalAs(UnmanagedType.LPStr)] StringBuilder lpConsoleTitle, uint nSize);

        /// Return Type: DWORD->unsigned int
        ///Source: LPWSTR->WCHAR*
        ///TargetBuffer: LPWSTR->WCHAR*
        ///TargetBufferLength: DWORD->unsigned int
        ///ExeName: LPWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetConsoleAliasW")]
        public static extern uint GetConsoleAliasW(
            [MarshalAs(UnmanagedType.LPWStr)] StringBuilder Source, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder TargetBuffer, uint TargetBufferLength,
            [MarshalAs(UnmanagedType.LPWStr)] StringBuilder ExeName);

        /// Return Type: DWORD->unsigned int
        ///Source: LPSTR->CHAR*
        ///TargetBuffer: LPSTR->CHAR*
        ///TargetBufferLength: DWORD->unsigned int
        ///ExeName: LPSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetConsoleAliasA")]
        public static extern uint GetConsoleAliasA(
            [MarshalAs(UnmanagedType.LPStr)] StringBuilder Source, [MarshalAs(UnmanagedType.LPStr)] StringBuilder TargetBuffer, uint TargetBufferLength,
            [MarshalAs(UnmanagedType.LPStr)] StringBuilder ExeName);

        /// Return Type: BOOL->int
        ///lpBuffer: LPWSTR->WCHAR*
        ///nSize: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "GetComputerNameW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetComputerNameW([Out] [MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpBuffer, ref uint nSize);

        /// Return Type: BOOL->int
        ///lpBuffer: LPSTR->CHAR*
        ///nSize: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "GetComputerNameA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetComputerNameA([Out] [MarshalAs(UnmanagedType.LPStr)] StringBuilder lpBuffer, ref uint nSize);

        /// Return Type: int
        ///Locale: LCID->DWORD->unsigned int
        ///Calendar: CALID->DWORD->unsigned int
        ///CalType: CALTYPE->DWORD->unsigned int
        ///lpCalData: LPWSTR->WCHAR*
        ///cchData: int
        ///lpValue: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "GetCalendarInfoW")]
        public static extern int GetCalendarInfoW(
            uint Locale, uint Calendar, uint CalType, [Out] [MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpCalData, int cchData, [In] IntPtr lpValue);

        /// Return Type: int
        ///Locale: LCID->DWORD->unsigned int
        ///Calendar: CALID->DWORD->unsigned int
        ///CalType: CALTYPE->DWORD->unsigned int
        ///lpCalData: LPSTR->CHAR*
        ///cchData: int
        ///lpValue: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "GetCalendarInfoA")]
        public static extern int GetCalendarInfoA(
            uint Locale, uint Calendar, uint CalType, [Out] [MarshalAs(UnmanagedType.LPStr)] StringBuilder lpCalData, int cchData, [In] IntPtr lpValue);

        /// Return Type: BOOL->int
        ///hFile: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "FlushFileBuffers")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FlushFileBuffers([In] IntPtr hFile);

        /// Return Type: HANDLE->void*
        ///lpszVolumeName: LPWSTR->WCHAR*
        ///cchBufferLength: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "FindFirstVolumeW")]
        public static extern IntPtr FindFirstVolumeW([Out] [MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpszVolumeName, uint cchBufferLength);

        /// Return Type: HANDLE->void*
        ///lpszVolumeName: LPSTR->CHAR*
        ///cchBufferLength: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "FindFirstVolumeA")]
        public static extern IntPtr FindFirstVolumeA([Out] [MarshalAs(UnmanagedType.LPStr)] StringBuilder lpszVolumeName, uint cchBufferLength);

        /// Return Type: HANDLE->void*
        ///lpFileName: LPCWSTR->WCHAR*
        ///fInfoLevelId: FINDEX_INFO_LEVELS->_FINDEX_INFO_LEVELS
        ///lpFindFileData: LPVOID->void*
        ///fSearchOp: FINDEX_SEARCH_OPS->_FINDEX_SEARCH_OPS
        ///lpSearchFilter: LPVOID->void*
        ///dwAdditionalFlags: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "FindFirstFileExW")]
        public static extern IntPtr FindFirstFileExW(
            [In] [MarshalAs(UnmanagedType.LPWStr)] string lpFileName, FINDEX_INFO_LEVELS fInfoLevelId, IntPtr lpFindFileData, FINDEX_SEARCH_OPS fSearchOp,
            IntPtr lpSearchFilter, uint dwAdditionalFlags);

        /// Return Type: HANDLE->void*
        ///lpFileName: LPCSTR->CHAR*
        ///fInfoLevelId: FINDEX_INFO_LEVELS->_FINDEX_INFO_LEVELS
        ///lpFindFileData: LPVOID->void*
        ///fSearchOp: FINDEX_SEARCH_OPS->_FINDEX_SEARCH_OPS
        ///lpSearchFilter: LPVOID->void*
        ///dwAdditionalFlags: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "FindFirstFileExA")]
        public static extern IntPtr FindFirstFileExA(
            [In] [MarshalAs(UnmanagedType.LPStr)] string lpFileName, FINDEX_INFO_LEVELS fInfoLevelId, IntPtr lpFindFileData, FINDEX_SEARCH_OPS fSearchOp,
            IntPtr lpSearchFilter, uint dwAdditionalFlags);

        /// Return Type: BOOL->int
        ///lpUILanguageEnumProc: UILANGUAGE_ENUMPROCW
        ///dwFlags: DWORD->unsigned int
        ///lParam: LONG_PTR->int
        [DllImport("kernel32.dll", EntryPoint = "EnumUILanguagesW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumUILanguagesW(UILANGUAGE_ENUMPROCW lpUILanguageEnumProc, uint dwFlags, [MarshalAs(UnmanagedType.SysInt)] int lParam);

        /// Return Type: BOOL->int
        ///lpUILanguageEnumProc: UILANGUAGE_ENUMPROCA
        ///dwFlags: DWORD->unsigned int
        ///lParam: LONG_PTR->int
        [DllImport("kernel32.dll", EntryPoint = "EnumUILanguagesA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumUILanguagesA(UILANGUAGE_ENUMPROCA lpUILanguageEnumProc, uint dwFlags, [MarshalAs(UnmanagedType.SysInt)] int lParam);

        /// Return Type: BOOL->int
        ///lpTimeFmtEnumProc: TIMEFMT_ENUMPROCW
        ///Locale: LCID->DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "EnumTimeFormatsW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumTimeFormatsW(TIMEFMT_ENUMPROCW lpTimeFmtEnumProc, uint Locale, uint dwFlags);

        /// Return Type: BOOL->int
        ///lpTimeFmtEnumProc: TIMEFMT_ENUMPROCA
        ///Locale: LCID->DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "EnumTimeFormatsA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumTimeFormatsA(TIMEFMT_ENUMPROCA lpTimeFmtEnumProc, uint Locale, uint dwFlags);

        /// Return Type: BOOL->int
        ///lpDateFmtEnumProc: DATEFMT_ENUMPROCW
        ///Locale: LCID->DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "EnumDateFormatsW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumDateFormatsW(DATEFMT_ENUMPROCW lpDateFmtEnumProc, uint Locale, uint dwFlags);

        /// Return Type: BOOL->int
        ///lpDateFmtEnumProc: DATEFMT_ENUMPROCA
        ///Locale: LCID->DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "EnumDateFormatsA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumDateFormatsA(DATEFMT_ENUMPROCA lpDateFmtEnumProc, uint Locale, uint dwFlags);

        /// Return Type: BOOL->int
        ///TimerQueue: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "DeleteTimerQueue")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DeleteTimerQueue([In] IntPtr TimerQueue);

        /// Return Type: BOOL->int
        ///dwFlags: DWORD->unsigned int
        ///lpDeviceName: LPCWSTR->WCHAR*
        ///lpTargetPath: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "DefineDosDeviceW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DefineDosDeviceW(
            uint dwFlags, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpDeviceName, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpTargetPath);

        /// Return Type: BOOL->int
        ///dwFlags: DWORD->unsigned int
        ///lpDeviceName: LPCSTR->CHAR*
        ///lpTargetPath: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "DefineDosDeviceA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DefineDosDeviceA(
            uint dwFlags, [In] [MarshalAs(UnmanagedType.LPStr)] string lpDeviceName, [In] [MarshalAs(UnmanagedType.LPStr)] string lpTargetPath);

        /// Return Type: BOOL->int
        ///dwFlags: DWORD->unsigned int
        ///ulCookie: ULONG_PTR->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "DeactivateActCtx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DeactivateActCtx(uint dwFlags, uint ulCookie);

        /// Return Type: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "CreateTimerQueue")]
        public static extern IntPtr CreateTimerQueue();

        /// Return Type: HANDLE->void*
        ///lpSemaphoreAttributes: LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        ///lInitialCount: LONG->int
        ///lMaximumCount: LONG->int
        ///lpName: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "CreateSemaphoreW")]
        public static extern IntPtr CreateSemaphoreW(
            [In] IntPtr lpSemaphoreAttributes, int lInitialCount, int lMaximumCount, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpName);

        /// Return Type: HANDLE->void*
        ///lpSemaphoreAttributes: LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        ///lInitialCount: LONG->int
        ///lMaximumCount: LONG->int
        ///lpName: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "CreateSemaphoreA")]
        public static extern IntPtr CreateSemaphoreA(
            [In] IntPtr lpSemaphoreAttributes, int lInitialCount, int lMaximumCount, [In] [MarshalAs(UnmanagedType.LPStr)] string lpName);

        /// Return Type: HANDLE->void*
        ///lpName: LPCWSTR->WCHAR*
        ///dwOpenMode: DWORD->unsigned int
        ///dwPipeMode: DWORD->unsigned int
        ///nMaxInstances: DWORD->unsigned int
        ///nOutBufferSize: DWORD->unsigned int
        ///nInBufferSize: DWORD->unsigned int
        ///nDefaultTimeOut: DWORD->unsigned int
        ///lpSecurityAttributes: LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        [DllImport("kernel32.dll", EntryPoint = "CreateNamedPipeW")]
        public static extern IntPtr CreateNamedPipeW(
            [In] [MarshalAs(UnmanagedType.LPWStr)] string lpName, uint dwOpenMode, uint dwPipeMode, uint nMaxInstances, uint nOutBufferSize, uint nInBufferSize,
            uint nDefaultTimeOut, [In] IntPtr lpSecurityAttributes);

        /// Return Type: HANDLE->void*
        ///lpName: LPCSTR->CHAR*
        ///dwOpenMode: DWORD->unsigned int
        ///dwPipeMode: DWORD->unsigned int
        ///nMaxInstances: DWORD->unsigned int
        ///nOutBufferSize: DWORD->unsigned int
        ///nInBufferSize: DWORD->unsigned int
        ///nDefaultTimeOut: DWORD->unsigned int
        ///lpSecurityAttributes: LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        [DllImport("kernel32.dll", EntryPoint = "CreateNamedPipeA")]
        public static extern IntPtr CreateNamedPipeA(
            [In] [MarshalAs(UnmanagedType.LPStr)] string lpName, uint dwOpenMode, uint dwPipeMode, uint nMaxInstances, uint nOutBufferSize, uint nInBufferSize,
            uint nDefaultTimeOut, [In] IntPtr lpSecurityAttributes);

        /// Return Type: HANDLE->void*
        ///lpJobAttributes: LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        ///lpName: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "CreateJobObjectW")]
        public static extern IntPtr CreateJobObjectW([In] IntPtr lpJobAttributes, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpName);

        /// Return Type: HANDLE->void*
        ///lpJobAttributes: LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        ///lpName: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "CreateJobObjectA")]
        public static extern IntPtr CreateJobObjectA([In] IntPtr lpJobAttributes, [In] [MarshalAs(UnmanagedType.LPStr)] string lpName);

        /// Return Type: BOOL->int
        ///lpPathName: LPCWSTR->WCHAR*
        ///lpSecurityAttributes: LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        [DllImport("kernel32.dll", EntryPoint = "CreateDirectoryW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CreateDirectoryW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpPathName, [In] IntPtr lpSecurityAttributes);

        /// Return Type: BOOL->int
        ///lpPathName: LPCSTR->CHAR*
        ///lpSecurityAttributes: LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        [DllImport("kernel32.dll", EntryPoint = "CreateDirectoryA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CreateDirectoryA([In] [MarshalAs(UnmanagedType.LPStr)] string lpPathName, [In] IntPtr lpSecurityAttributes);

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
        [DllImport("kernel32.dll", EntryPoint = "AddConsoleAliasW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AddConsoleAliasW(
            [MarshalAs(UnmanagedType.LPWStr)] StringBuilder Source, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder Target,
            [MarshalAs(UnmanagedType.LPWStr)] StringBuilder ExeName);

        /// Return Type: BOOL->int
        ///Source: LPSTR->CHAR*
        ///Target: LPSTR->CHAR*
        ///ExeName: LPSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "AddConsoleAliasA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AddConsoleAliasA(
            [MarshalAs(UnmanagedType.LPStr)] StringBuilder Source, [MarshalAs(UnmanagedType.LPStr)] StringBuilder Target,
            [MarshalAs(UnmanagedType.LPStr)] StringBuilder ExeName);

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
        [DllImport("kernel32.dll", EntryPoint = "UpdateResourceW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool UpdateResourceW(
            [In] IntPtr hUpdate, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpType, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpName, ushort wLanguage,
            [In] IntPtr lpData, uint cb);

        /// Return Type: BOOL->int
        ///hUpdate: HANDLE->void*
        ///lpType: LPCSTR->CHAR*
        ///lpName: LPCSTR->CHAR*
        ///wLanguage: WORD->unsigned short
        ///lpData: LPVOID->void*
        ///cb: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "UpdateResourceA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool UpdateResourceA(
            [In] IntPtr hUpdate, [In] [MarshalAs(UnmanagedType.LPStr)] string lpType, [In] [MarshalAs(UnmanagedType.LPStr)] string lpName, ushort wLanguage,
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
        [DllImport("kernel32.dll", EntryPoint = "SetVolumeLabelW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetVolumeLabelW(
            [In] [MarshalAs(UnmanagedType.LPWStr)] string lpRootPathName, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpVolumeName);

        /// Return Type: BOOL->int
        ///lpRootPathName: LPCSTR->CHAR*
        ///lpVolumeName: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "SetVolumeLabelA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetVolumeLabelA(
            [In] [MarshalAs(UnmanagedType.LPStr)] string lpRootPathName, [In] [MarshalAs(UnmanagedType.LPStr)] string lpVolumeName);

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
        [DllImport("kernel32.dll", EntryPoint = "QueryDosDeviceW")]
        public static extern uint QueryDosDeviceW(
            [In] [MarshalAs(UnmanagedType.LPWStr)] string lpDeviceName, [Out] [MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpTargetPath, uint ucchMax);

        /// Return Type: DWORD->unsigned int
        ///lpDeviceName: LPCSTR->CHAR*
        ///lpTargetPath: LPSTR->CHAR*
        ///ucchMax: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "QueryDosDeviceA")]
        public static extern uint QueryDosDeviceA(
            [In] [MarshalAs(UnmanagedType.LPStr)] string lpDeviceName, [Out] [MarshalAs(UnmanagedType.LPStr)] StringBuilder lpTargetPath, uint ucchMax);

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
        [DllImport("kernel32.dll", EntryPoint = "IsBadStringPtrW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsBadStringPtrW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpsz, [MarshalAs(UnmanagedType.SysUInt)] uint ucchMax);

        /// Return Type: BOOL->int
        ///lpsz: LPCSTR->CHAR*
        ///ucchMax: UINT_PTR->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "IsBadStringPtrA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsBadStringPtrA([In] [MarshalAs(UnmanagedType.LPStr)] string lpsz, [MarshalAs(UnmanagedType.SysUInt)] uint ucchMax);

        /// Return Type: ATOM->WORD->unsigned short
        ///lpString: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "GlobalFindAtomW")]
        public static extern ushort GlobalFindAtomW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpString);

        /// Return Type: ATOM->WORD->unsigned short
        ///lpString: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "GlobalFindAtomA")]
        public static extern ushort GlobalFindAtomA([In] [MarshalAs(UnmanagedType.LPStr)] string lpString);

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
        [DllImport("kernel32.dll", EntryPoint = "GetStartupInfoW")]
        public static extern void GetStartupInfoW([Out] out STARTUPINFOW lpStartupInfo);

        /// Return Type: void
        ///lpStartupInfo: LPSTARTUPINFOA->_STARTUPINFOA*
        [DllImport("kernel32.dll", EntryPoint = "GetStartupInfoA")]
        public static extern void GetStartupInfoA([Out] out STARTUPINFOA lpStartupInfo);

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
        [DllImport("kernel32.dll", EntryPoint = "GetCommandLineW")]
        public static extern IntPtr GetCommandLineW();

        /// Return Type: LPSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetCommandLineA")]
        public static extern IntPtr GetCommandLineA();

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
        [DllImport("kernel32.dll", EntryPoint = "FindResourceExW")]
        public static extern IntPtr FindResourceExW(
            [In] IntPtr hModule, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpType, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpName, ushort wLanguage);

        /// Return Type: HRSRC->HRSRC__*
        ///hModule: HMODULE->HINSTANCE->HINSTANCE__*
        ///lpType: LPCSTR->CHAR*
        ///lpName: LPCSTR->CHAR*
        ///wLanguage: WORD->unsigned short
        [DllImport("kernel32.dll", EntryPoint = "FindResourceExA")]
        public static extern IntPtr FindResourceExA(
            [In] IntPtr hModule, [In] [MarshalAs(UnmanagedType.LPStr)] string lpType, [In] [MarshalAs(UnmanagedType.LPStr)] string lpName, ushort wLanguage);

        /// Return Type: BOOL->int
        ///hFindVolume: HANDLE->void*
        ///lpszVolumeName: LPWSTR->WCHAR*
        ///cchBufferLength: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "FindNextVolumeW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FindNextVolumeW(
            IntPtr hFindVolume, [Out] [MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpszVolumeName, uint cchBufferLength);

        /// Return Type: BOOL->int
        ///hFindVolume: HANDLE->void*
        ///lpszVolumeName: LPSTR->CHAR*
        ///cchBufferLength: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "FindNextVolumeA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FindNextVolumeA(IntPtr hFindVolume, [Out] [MarshalAs(UnmanagedType.LPStr)] StringBuilder lpszVolumeName, uint cchBufferLength);

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
        [DllImport("kernel32.dll", EntryPoint = "CreateMailslotW")]
        public static extern IntPtr CreateMailslotW(
            [In] [MarshalAs(UnmanagedType.LPWStr)] string lpName, uint nMaxMessageSize, uint lReadTimeout, [In] IntPtr lpSecurityAttributes);

        /// Return Type: HANDLE->void*
        ///lpName: LPCSTR->CHAR*
        ///nMaxMessageSize: DWORD->unsigned int
        ///lReadTimeout: DWORD->unsigned int
        ///lpSecurityAttributes: LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        [DllImport("kernel32.dll", EntryPoint = "CreateMailslotA")]
        public static extern IntPtr CreateMailslotA(
            [In] [MarshalAs(UnmanagedType.LPStr)] string lpName, uint nMaxMessageSize, uint lReadTimeout, [In] IntPtr lpSecurityAttributes);

        /// Return Type: BOOL->int
        ///lpFileName: LPCWSTR->WCHAR*
        ///lpExistingFileName: LPCWSTR->WCHAR*
        ///lpSecurityAttributes: LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        [DllImport("kernel32.dll", EntryPoint = "CreateHardLinkW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CreateHardLinkW(
            [In] [MarshalAs(UnmanagedType.LPWStr)] string lpFileName, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName,
            IntPtr lpSecurityAttributes);

        /// Return Type: BOOL->int
        ///lpFileName: LPCSTR->CHAR*
        ///lpExistingFileName: LPCSTR->CHAR*
        ///lpSecurityAttributes: LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        [DllImport("kernel32.dll", EntryPoint = "CreateHardLinkA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CreateHardLinkA(
            [In] [MarshalAs(UnmanagedType.LPStr)] string lpFileName, [In] [MarshalAs(UnmanagedType.LPStr)] string lpExistingFileName,
            IntPtr lpSecurityAttributes);

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
        [DllImport("kernel32.dll", EntryPoint = "WaitNamedPipeW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WaitNamedPipeW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpNamedPipeName, uint nTimeOut);

        /// Return Type: BOOL->int
        ///lpNamedPipeName: LPCSTR->CHAR*
        ///nTimeOut: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "WaitNamedPipeA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WaitNamedPipeA([In] [MarshalAs(UnmanagedType.LPStr)] string lpNamedPipeName, uint nTimeOut);

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
        [DllImport("kernel32.dll", EntryPoint = "SetLocaleInfoW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetLocaleInfoW(uint Locale, uint LCType, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpLCData);

        /// Return Type: BOOL->int
        ///Locale: LCID->DWORD->unsigned int
        ///LCType: LCTYPE->DWORD->unsigned int
        ///lpLCData: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "SetLocaleInfoA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetLocaleInfoA(uint Locale, uint LCType, [In] [MarshalAs(UnmanagedType.LPStr)] string lpLCData);

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
        public static extern bool SetConsoleMode(IntPtr hConsoleHandle, uint dwMode);

        /// Return Type: void
        ///dwExceptionCode: DWORD->unsigned int
        ///dwExceptionFlags: DWORD->unsigned int
        ///nNumberOfArguments: DWORD->unsigned int
        ///lpArguments: ULONG_PTR*
        [DllImport("kernel32.dll", EntryPoint = "RaiseException")]
        public static extern void RaiseException(uint dwExceptionCode, uint dwExceptionFlags, uint nNumberOfArguments, [In] IntPtr lpArguments);

        /// Return Type: HANDLE->void*
        ///dwDesiredAccess: DWORD->unsigned int
        ///bInheritHandle: BOOL->int
        ///lpName: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "OpenSemaphoreW")]
        public static extern IntPtr OpenSemaphoreW(
            uint dwDesiredAccess, [MarshalAs(UnmanagedType.Bool)] bool bInheritHandle, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpName);

        /// Return Type: HANDLE->void*
        ///dwDesiredAccess: DWORD->unsigned int
        ///bInheritHandle: BOOL->int
        ///lpName: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "OpenSemaphoreA")]
        public static extern IntPtr OpenSemaphoreA(
            uint dwDesiredAccess, [MarshalAs(UnmanagedType.Bool)] bool bInheritHandle, [In] [MarshalAs(UnmanagedType.LPStr)] string lpName);

        /// Return Type: HANDLE->void*
        ///dwDesiredAccess: DWORD->unsigned int
        ///bInheritHandle: BOOL->int
        ///lpName: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "OpenJobObjectW")]
        public static extern IntPtr OpenJobObjectW(
            uint dwDesiredAccess, [MarshalAs(UnmanagedType.Bool)] bool bInheritHandle, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpName);

        /// Return Type: HANDLE->void*
        ///dwDesiredAccess: DWORD->unsigned int
        ///bInheritHandle: BOOL->int
        ///lpName: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "OpenJobObjectA")]
        public static extern IntPtr OpenJobObjectA(
            uint dwDesiredAccess, [MarshalAs(UnmanagedType.Bool)] bool bInheritHandle, [In] [MarshalAs(UnmanagedType.LPStr)] string lpName);

        /// Return Type: HMODULE->HINSTANCE->HINSTANCE__*
        ///lpLibFileName: LPCWSTR->WCHAR*
        ///hFile: HANDLE->void*
        ///dwFlags: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "LoadLibraryExW")]
        public static extern IntPtr LoadLibraryExW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpLibFileName, IntPtr hFile, uint dwFlags);

        /// Return Type: HMODULE->HINSTANCE->HINSTANCE__*
        ///lpLibFileName: LPCSTR->CHAR*
        ///hFile: HANDLE->void*
        ///dwFlags: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "LoadLibraryExA")]
        public static extern IntPtr LoadLibraryExA([In] [MarshalAs(UnmanagedType.LPStr)] string lpLibFileName, IntPtr hFile, uint dwFlags);

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
        [DllImport("kernel32.dll", EntryPoint = "GlobalAddAtomW")]
        public static extern ushort GlobalAddAtomW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpString);

        /// Return Type: ATOM->WORD->unsigned short
        ///lpString: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "GlobalAddAtomA")]
        public static extern ushort GlobalAddAtomA([In] [MarshalAs(UnmanagedType.LPStr)] string lpString);

        /// Return Type: int
        ///Locale: LCID->DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        ///lpTime: SYSTEMTIME*
        ///lpFormat: LPCWSTR->WCHAR*
        ///lpTimeStr: LPWSTR->WCHAR*
        ///cchTime: int
        [DllImport("kernel32.dll", EntryPoint = "GetTimeFormatW")]
        public static extern int GetTimeFormatW(
            uint Locale, uint dwFlags, [In] IntPtr lpTime, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpFormat,
            [Out] [MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpTimeStr, int cchTime);

        /// Return Type: int
        ///Locale: LCID->DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        ///lpTime: SYSTEMTIME*
        ///lpFormat: LPCSTR->CHAR*
        ///lpTimeStr: LPSTR->CHAR*
        ///cchTime: int
        [DllImport("kernel32.dll", EntryPoint = "GetTimeFormatA")]
        public static extern int GetTimeFormatA(
            uint Locale, uint dwFlags, [In] IntPtr lpTime, [In] [MarshalAs(UnmanagedType.LPStr)] string lpFormat,
            [Out] [MarshalAs(UnmanagedType.LPStr)] StringBuilder lpTimeStr, int cchTime);

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
        [DllImport("kernel32.dll", EntryPoint = "GetStringTypeW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetStringTypeW(
            uint dwInfoType, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpSrcStr, int cchSrc, [Out] out ushort lpCharType);

        /// Return Type: BOOL->int
        ///Locale: LCID->DWORD->unsigned int
        ///dwInfoType: DWORD->unsigned int
        ///lpSrcStr: LPCSTR->CHAR*
        ///cchSrc: int
        ///lpCharType: LPWORD->WORD*
        [DllImport("kernel32.dll", EntryPoint = "GetStringTypeA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetStringTypeA(
            uint Locale, uint dwInfoType, [In] [MarshalAs(UnmanagedType.LPStr)] string lpSrcStr, int cchSrc, [Out] out ushort lpCharType);

        /// Return Type: UINT->unsigned int
        ///lpAppName: LPCWSTR->WCHAR*
        ///lpKeyName: LPCWSTR->WCHAR*
        ///nDefault: INT->int
        [DllImport("kernel32.dll", EntryPoint = "GetProfileIntW")]
        public static extern uint GetProfileIntW(
            [In] [MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, int nDefault);

        /// Return Type: UINT->unsigned int
        ///lpAppName: LPCSTR->CHAR*
        ///lpKeyName: LPCSTR->CHAR*
        ///nDefault: INT->int
        [DllImport("kernel32.dll", EntryPoint = "GetProfileIntA")]
        public static extern uint GetProfileIntA(
            [In] [MarshalAs(UnmanagedType.LPStr)] string lpAppName, [In] [MarshalAs(UnmanagedType.LPStr)] string lpKeyName, int nDefault);

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
        [DllImport("kernel32.dll", EntryPoint = "GetLocaleInfoW")]
        public static extern int GetLocaleInfoW(uint Locale, uint LCType, [Out] [MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpLCData, int cchData);

        /// Return Type: int
        ///Locale: LCID->DWORD->unsigned int
        ///LCType: LCTYPE->DWORD->unsigned int
        ///lpLCData: LPSTR->CHAR*
        ///cchData: int
        [DllImport("kernel32.dll", EntryPoint = "GetLocaleInfoA")]
        public static extern int GetLocaleInfoA(uint Locale, uint LCType, [Out] [MarshalAs(UnmanagedType.LPStr)] StringBuilder lpLCData, int cchData);

        /// Return Type: int
        ///Locale: LCID->DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        ///lpDate: SYSTEMTIME*
        ///lpFormat: LPCWSTR->WCHAR*
        ///lpDateStr: LPWSTR->WCHAR*
        ///cchDate: int
        [DllImport("kernel32.dll", EntryPoint = "GetDateFormatW")]
        public static extern int GetDateFormatW(
            uint Locale, uint dwFlags, [In] IntPtr lpDate, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpFormat,
            [Out] [MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpDateStr, int cchDate);

        /// Return Type: int
        ///Locale: LCID->DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        ///lpDate: SYSTEMTIME*
        ///lpFormat: LPCSTR->CHAR*
        ///lpDateStr: LPSTR->CHAR*
        ///cchDate: int
        [DllImport("kernel32.dll", EntryPoint = "GetDateFormatA")]
        public static extern int GetDateFormatA(
            uint Locale, uint dwFlags, [In] IntPtr lpDate, [In] [MarshalAs(UnmanagedType.LPStr)] string lpFormat,
            [Out] [MarshalAs(UnmanagedType.LPStr)] StringBuilder lpDateStr, int cchDate);

        /// Return Type: BOOL->int
        ///hConsoleHandle: HANDLE->void*
        ///lpMode: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "GetConsoleMode")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetConsoleMode(IntPtr hConsoleHandle, ref uint lpMode);

        /// Return Type: BOOL->int
        ///lpApplicationName: LPCWSTR->WCHAR*
        ///lpBinaryType: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "GetBinaryTypeW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetBinaryTypeW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpApplicationName, [Out] out uint lpBinaryType);

        /// Return Type: BOOL->int
        ///lpApplicationName: LPCSTR->CHAR*
        ///lpBinaryType: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "GetBinaryTypeA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetBinaryTypeA([In] [MarshalAs(UnmanagedType.LPStr)] string lpApplicationName, [Out] out uint lpBinaryType);

        /// Return Type: DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        ///lpSource: LPCVOID->void*
        ///dwMessageId: DWORD->unsigned int
        ///dwLanguageId: DWORD->unsigned int
        ///lpBuffer: LPWSTR->WCHAR*
        ///nSize: DWORD->unsigned int
        ///Arguments: va_list*
        [DllImport("kernel32.dll", EntryPoint = "FormatMessageW")]
        public static extern uint FormatMessageW(
            uint dwFlags, IntPtr lpSource, uint dwMessageId, uint dwLanguageId, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpBuffer, uint nSize,
            ref IntPtr Arguments);

        /// Return Type: DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        ///lpSource: LPCVOID->void*
        ///dwMessageId: DWORD->unsigned int
        ///dwLanguageId: DWORD->unsigned int
        ///lpBuffer: LPSTR->CHAR*
        ///nSize: DWORD->unsigned int
        ///Arguments: va_list*
        [DllImport("kernel32.dll", EntryPoint = "FormatMessageA")]
        public static extern uint FormatMessageA(
            uint dwFlags, IntPtr lpSource, uint dwMessageId, uint dwLanguageId, [MarshalAs(UnmanagedType.LPStr)] StringBuilder lpBuffer, uint nSize,
            ref IntPtr Arguments);

        /// Return Type: HANDLE->void*
        ///lpFileName: LPCWSTR->WCHAR*
        ///lpFindFileData: LPWIN32_FIND_DATAW->_WIN32_FIND_DATAW*
        [DllImport("kernel32.dll", EntryPoint = "FindFirstFileW")]
        public static extern IntPtr FindFirstFileW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpFileName, [Out] out WIN32_FIND_DATAW lpFindFileData);

        /// Return Type: HANDLE->void*
        ///lpFileName: LPCSTR->CHAR*
        ///lpFindFileData: LPWIN32_FIND_DATAA->_WIN32_FIND_DATAA*
        [DllImport("kernel32.dll", EntryPoint = "FindFirstFileA")]
        public static extern IntPtr FindFirstFileA([In] [MarshalAs(UnmanagedType.LPStr)] string lpFileName, [Out] out WIN32_FIND_DATAA lpFindFileData);

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
        [DllImport("kernel32.dll", EntryPoint = "CreateProcessW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CreateProcessW(
            [In] [MarshalAs(UnmanagedType.LPWStr)] string lpApplicationName, IntPtr lpCommandLine, [In] IntPtr lpProcessAttributes,
            [In] IntPtr lpThreadAttributes, [MarshalAs(UnmanagedType.Bool)] bool bInheritHandles, uint dwCreationFlags, [In] IntPtr lpEnvironment,
            [In] [MarshalAs(UnmanagedType.LPWStr)] string lpCurrentDirectory, [In] ref STARTUPINFOW lpStartupInfo,
            [Out] out PROCESS_INFORMATION lpProcessInformation);

        /// Return Type: BOOL->int
        ///lpApplicationName: LPCSTR->CHAR*
        ///lpCommandLine: LPSTR->CHAR*
        ///lpProcessAttributes: LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        ///lpThreadAttributes: LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        ///bInheritHandles: BOOL->int
        ///dwCreationFlags: DWORD->unsigned int
        ///lpEnvironment: LPVOID->void*
        ///lpCurrentDirectory: LPCSTR->CHAR*
        ///lpStartupInfo: LPSTARTUPINFOA->_STARTUPINFOA*
        ///lpProcessInformation: LPPROCESS_INFORMATION->_PROCESS_INFORMATION*
        [DllImport("kernel32.dll", EntryPoint = "CreateProcessA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CreateProcessA(
            [In] [MarshalAs(UnmanagedType.LPStr)] string lpApplicationName, IntPtr lpCommandLine, [In] IntPtr lpProcessAttributes,
            [In] IntPtr lpThreadAttributes, [MarshalAs(UnmanagedType.Bool)] bool bInheritHandles, uint dwCreationFlags, [In] IntPtr lpEnvironment,
            [In] [MarshalAs(UnmanagedType.LPStr)] string lpCurrentDirectory, [In] ref STARTUPINFOA lpStartupInfo,
            [Out] out PROCESS_INFORMATION lpProcessInformation);

        /// Return Type: int
        ///Locale: LCID->DWORD->unsigned int
        ///dwCmpFlags: DWORD->unsigned int
        ///lpString1: LPCWSTR->WCHAR*
        ///cchCount1: int
        ///lpString2: LPCWSTR->WCHAR*
        ///cchCount2: int
        [DllImport("kernel32.dll", EntryPoint = "CompareStringW")]
        public static extern int CompareStringW(
            uint Locale, uint dwCmpFlags, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpString1, int cchCount1,
            [In] [MarshalAs(UnmanagedType.LPWStr)] string lpString2, int cchCount2);

        /// Return Type: int
        ///Locale: LCID->DWORD->unsigned int
        ///dwCmpFlags: DWORD->unsigned int
        ///lpString1: LPCSTR->CHAR*
        ///cchCount1: int
        ///lpString2: LPCSTR->CHAR*
        ///cchCount2: int
        [DllImport("kernel32.dll", EntryPoint = "CompareStringA")]
        public static extern int CompareStringA(
            uint Locale, uint dwCmpFlags, [In] [MarshalAs(UnmanagedType.LPStr)] string lpString1, int cchCount1,
            [In] [MarshalAs(UnmanagedType.LPStr)] string lpString2, int cchCount2);

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
        [DllImport("kernel32.dll", EntryPoint = "CallNamedPipeW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CallNamedPipeW(
            [In] [MarshalAs(UnmanagedType.LPWStr)] string lpNamedPipeName, [In] IntPtr lpInBuffer, uint nInBufferSize, IntPtr lpOutBuffer, uint nOutBufferSize,
            [Out] out uint lpBytesRead, uint nTimeOut);

        /// Return Type: BOOL->int
        ///lpNamedPipeName: LPCSTR->CHAR*
        ///lpInBuffer: LPVOID->void*
        ///nInBufferSize: DWORD->unsigned int
        ///lpOutBuffer: LPVOID->void*
        ///nOutBufferSize: DWORD->unsigned int
        ///lpBytesRead: LPDWORD->DWORD*
        ///nTimeOut: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "CallNamedPipeA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CallNamedPipeA(
            [In] [MarshalAs(UnmanagedType.LPStr)] string lpNamedPipeName, [In] IntPtr lpInBuffer, uint nInBufferSize, IntPtr lpOutBuffer, uint nOutBufferSize,
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
        [DllImport("kernel32.dll", EntryPoint = "WriteConsoleW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WriteConsoleW(
            IntPtr hConsoleOutput, IntPtr lpBuffer, uint nNumberOfCharsToWrite, ref uint lpNumberOfCharsWritten, IntPtr lpReserved);

        /// Return Type: BOOL->int
        ///hConsoleOutput: HANDLE->void*
        ///lpBuffer: void*
        ///nNumberOfCharsToWrite: DWORD->unsigned int
        ///lpNumberOfCharsWritten: LPDWORD->DWORD*
        ///lpReserved: LPVOID->void*
        [DllImport("kernel32.dll", EntryPoint = "WriteConsoleA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WriteConsoleA(
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
        public static extern bool IsValidLocale(uint Locale, uint dwFlags);

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
        public static extern IntPtr GlobalReAlloc([In] IntPtr hMem, uint dwBytes, uint uFlags);

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
            uint dwFlags, [In] IntPtr lpBaseAddress, uint dwRegionSize, ref IntPtr lpAddresses, ref uint lpdwCount, [Out] out uint lpdwGranularity);

        /// Return Type: BOOL->int
        ///lpVersionInformation: LPOSVERSIONINFOW->_OSVERSIONINFOW*
        [DllImport("kernel32.dll", EntryPoint = "GetVersionExW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetVersionExW(ref RTL_OSVERSIONINFOW lpVersionInformation);

        /// Return Type: BOOL->int
        ///lpVersionInformation: LPOSVERSIONINFOA->_OSVERSIONINFOA*
        [DllImport("kernel32.dll", EntryPoint = "GetVersionExA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetVersionExA(ref OSVERSIONINFOA lpVersionInformation);

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
        [DllImport("kernel32.dll", EntryPoint = "GetDriveTypeW")]
        public static extern uint GetDriveTypeW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpRootPathName);

        /// Return Type: UINT->unsigned int
        ///lpRootPathName: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetDriveTypeA")]
        public static extern uint GetDriveTypeA([In] [MarshalAs(UnmanagedType.LPStr)] string lpRootPathName);

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
        [DllImport("kernel32.dll", EntryPoint = "FindResourceW")]
        public static extern IntPtr FindResourceW(
            [In] IntPtr hModule, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpName, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpType);

        /// Return Type: HRSRC->HRSRC__*
        ///hModule: HMODULE->HINSTANCE->HINSTANCE__*
        ///lpName: LPCSTR->CHAR*
        ///lpType: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "FindResourceA")]
        public static extern IntPtr FindResourceA(
            [In] IntPtr hModule, [In] [MarshalAs(UnmanagedType.LPStr)] string lpName, [In] [MarshalAs(UnmanagedType.LPStr)] string lpType);

        /// Return Type: BOOL->int
        ///hFindFile: HANDLE->void*
        ///lpFindFileData: LPWIN32_FIND_DATAW->_WIN32_FIND_DATAW*
        [DllImport("kernel32.dll", EntryPoint = "FindNextFileW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FindNextFileW([In] IntPtr hFindFile, [Out] out WIN32_FIND_DATAW lpFindFileData);

        /// Return Type: BOOL->int
        ///hFindFile: HANDLE->void*
        ///lpFindFileData: LPWIN32_FIND_DATAA->_WIN32_FIND_DATAA*
        [DllImport("kernel32.dll", EntryPoint = "FindNextFileA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FindNextFileA([In] IntPtr hFindFile, [Out] out WIN32_FIND_DATAA lpFindFileData);

        /// Return Type: void
        ///uAction: UINT->unsigned int
        ///lpMessageText: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "FatalAppExitW")]
        public static extern void FatalAppExitW(uint uAction, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpMessageText);

        /// Return Type: void
        ///uAction: UINT->unsigned int
        ///lpMessageText: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "FatalAppExitA")]
        public static extern void FatalAppExitA(uint uAction, [In] [MarshalAs(UnmanagedType.LPStr)] string lpMessageText);

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
            uint dwStackCommitSize, uint dwStackReserveSize, uint dwFlags, PFIBER_START_ROUTINE lpStartAddress, [In] IntPtr lpParameter);

        /// Return Type: HANDLE->void*
        ///pActCtx: PCACTCTXW->ACTCTXW*
        [DllImport("kernel32.dll", EntryPoint = "CreateActCtxW")]
        public static extern IntPtr CreateActCtxW([In] ref tagACTCTXW pActCtx);

        /// Return Type: HANDLE->void*
        ///pActCtx: PCACTCTXA->ACTCTXA*
        [DllImport("kernel32.dll", EntryPoint = "CreateActCtxA")]
        public static extern IntPtr CreateActCtxA([In] ref tagACTCTXA pActCtx);

        /// Return Type: BOOL->int
        ///lpDef: LPCWSTR->WCHAR*
        ///lpDCB: LPDCB->_DCB*
        [DllImport("kernel32.dll", EntryPoint = "BuildCommDCBW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool BuildCommDCBW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpDef, [Out] out DCB lpDCB);

        /// Return Type: BOOL->int
        ///lpDef: LPCSTR->CHAR*
        ///lpDCB: LPDCB->_DCB*
        [DllImport("kernel32.dll", EntryPoint = "BuildCommDCBA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool BuildCommDCBA([In] [MarshalAs(UnmanagedType.LPStr)] string lpDef, [Out] out DCB lpDCB);

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
        [DllImport("kernel32.dll", EntryPoint = "ReplaceFileW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ReplaceFileW(
            [In] [MarshalAs(UnmanagedType.LPWStr)] string lpReplacedFileName, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpReplacementFileName,
            [In] [MarshalAs(UnmanagedType.LPWStr)] string lpBackupFileName, uint dwReplaceFlags, IntPtr lpExclude, IntPtr lpReserved);

        /// Return Type: BOOL->int
        ///lpReplacedFileName: LPCSTR->CHAR*
        ///lpReplacementFileName: LPCSTR->CHAR*
        ///lpBackupFileName: LPCSTR->CHAR*
        ///dwReplaceFlags: DWORD->unsigned int
        ///lpExclude: LPVOID->void*
        ///lpReserved: LPVOID->void*
        [DllImport("kernel32.dll", EntryPoint = "ReplaceFileA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ReplaceFileA(
            [In] [MarshalAs(UnmanagedType.LPStr)] string lpReplacedFileName, [In] [MarshalAs(UnmanagedType.LPStr)] string lpReplacementFileName,
            [In] [MarshalAs(UnmanagedType.LPStr)] string lpBackupFileName, uint dwReplaceFlags, IntPtr lpExclude, IntPtr lpReserved);

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
        [DllImport("kernel32.dll", EntryPoint = "ReadConsoleW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ReadConsoleW(
            IntPtr hConsoleInput, IntPtr lpBuffer, uint nNumberOfCharsToRead, ref uint lpNumberOfCharsRead, IntPtr lpReserved);

        /// Return Type: BOOL->int
        ///hConsoleInput: HANDLE->void*
        ///lpBuffer: LPVOID->void*
        ///nNumberOfCharsToRead: DWORD->unsigned int
        ///lpNumberOfCharsRead: LPDWORD->DWORD*
        ///lpReserved: LPVOID->void*
        [DllImport("kernel32.dll", EntryPoint = "ReadConsoleA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ReadConsoleA(
            IntPtr hConsoleInput, IntPtr lpBuffer, uint nNumberOfCharsToRead, ref uint lpNumberOfCharsRead, IntPtr lpReserved);

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
        [DllImport("kernel32.dll", EntryPoint = "QueryActCtxW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool QueryActCtxW(
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
        public static extern IntPtr LocalReAlloc([In] IntPtr hMem, uint uBytes, uint uFlags);

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
        [DllImport("kernel32.dll", EntryPoint = "LoadLibraryW")]
        public static extern IntPtr LoadLibraryW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpLibFileName);

        /// Return Type: HMODULE->HINSTANCE->HINSTANCE__*
        ///lpLibFileName: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "LoadLibraryA")]
        public static extern IntPtr LoadLibraryA([In] [MarshalAs(UnmanagedType.LPStr)] string lpLibFileName);

        /// Return Type: int
        ///Locale: LCID->DWORD->unsigned int
        ///dwMapFlags: DWORD->unsigned int
        ///lpSrcStr: LPCWSTR->WCHAR*
        ///cchSrc: int
        ///lpDestStr: LPWSTR->WCHAR*
        ///cchDest: int
        [DllImport("kernel32.dll", EntryPoint = "LCMapStringW")]
        public static extern int LCMapStringW(
            uint Locale, uint dwMapFlags, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpSrcStr, int cchSrc,
            [Out] [MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpDestStr, int cchDest);

        /// Return Type: int
        ///Locale: LCID->DWORD->unsigned int
        ///dwMapFlags: DWORD->unsigned int
        ///lpSrcStr: LPCSTR->CHAR*
        ///cchSrc: int
        ///lpDestStr: LPSTR->CHAR*
        ///cchDest: int
        [DllImport("kernel32.dll", EntryPoint = "LCMapStringA")]
        public static extern int LCMapStringA(
            uint Locale, uint dwMapFlags, [In] [MarshalAs(UnmanagedType.LPStr)] string lpSrcStr, int cchSrc,
            [Out] [MarshalAs(UnmanagedType.LPStr)] StringBuilder lpDestStr, int cchDest);

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
        public static extern bool HeapValidate([In] IntPtr hHeap, uint dwFlags, [In] IntPtr lpMem);

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
        [DllImport("kernel32.dll", EntryPoint = "GetTempPathW")]
        public static extern uint GetTempPathW(uint nBufferLength, [Out] [MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpBuffer);

        /// Return Type: DWORD->unsigned int
        ///nBufferLength: DWORD->unsigned int
        ///lpBuffer: LPSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetTempPathA")]
        public static extern uint GetTempPathA(uint nBufferLength, [Out] [MarshalAs(UnmanagedType.LPStr)] StringBuilder lpBuffer);

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
        [DllImport("kernel32.dll", EntryPoint = "GetCPInfoExW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetCPInfoExW(uint CodePage, uint dwFlags, [Out] out CPINFOEXW lpCPInfoEx);

        /// Return Type: BOOL->int
        ///CodePage: UINT->unsigned int
        ///dwFlags: DWORD->unsigned int
        ///lpCPInfoEx: LPCPINFOEXA->_cpinfoexA*
        [DllImport("kernel32.dll", EntryPoint = "GetCPInfoExA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetCPInfoExA(uint CodePage, uint dwFlags, [Out] out CPINFOEXA lpCPInfoEx);

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
        [DllImport("kernel32.dll", EntryPoint = "GetAtomNameW")]
        public static extern uint GetAtomNameW(ushort nAtom, [Out] [MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpBuffer, int nSize);

        /// Return Type: UINT->unsigned int
        ///nAtom: ATOM->WORD->unsigned short
        ///lpBuffer: LPSTR->CHAR*
        ///nSize: int
        [DllImport("kernel32.dll", EntryPoint = "GetAtomNameA")]
        public static extern uint GetAtomNameA(ushort nAtom, [Out] [MarshalAs(UnmanagedType.LPStr)] StringBuilder lpBuffer, int nSize);

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
            [In] IntPtr lpThreadAttributes, uint dwStackSize, PTHREAD_START_ROUTINE lpStartAddress, [In] IntPtr lpParameter, uint dwCreationFlags,
            IntPtr lpThreadId);

        /// Return Type: HANDLE->void*
        ///lpMutexAttributes: LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        ///bInitialOwner: BOOL->int
        ///lpName: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "CreateMutexW")]
        public static extern IntPtr CreateMutexW(
            [In] IntPtr lpMutexAttributes, [MarshalAs(UnmanagedType.Bool)] bool bInitialOwner, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpName);

        /// Return Type: HANDLE->void*
        ///lpMutexAttributes: LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        ///bInitialOwner: BOOL->int
        ///lpName: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "CreateMutexA")]
        public static extern IntPtr CreateMutexA(
            [In] IntPtr lpMutexAttributes, [MarshalAs(UnmanagedType.Bool)] bool bInitialOwner, [In] [MarshalAs(UnmanagedType.LPStr)] string lpName);

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
        [DllImport("kernel32.dll", EntryPoint = "CreateEventW")]
        public static extern IntPtr CreateEventW(
            [In] IntPtr lpEventAttributes, [MarshalAs(UnmanagedType.Bool)] bool bManualReset, [MarshalAs(UnmanagedType.Bool)] bool bInitialState,
            [In] [MarshalAs(UnmanagedType.LPWStr)] string lpName);

        /// Return Type: HANDLE->void*
        ///lpEventAttributes: LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        ///bManualReset: BOOL->int
        ///bInitialState: BOOL->int
        ///lpName: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "CreateEventA")]
        public static extern IntPtr CreateEventA(
            [In] IntPtr lpEventAttributes, [MarshalAs(UnmanagedType.Bool)] bool bManualReset, [MarshalAs(UnmanagedType.Bool)] bool bInitialState,
            [In] [MarshalAs(UnmanagedType.LPStr)] string lpName);

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
        [DllImport("kernel32.dll", EntryPoint = "SearchPathW")]
        public static extern uint SearchPathW(
            [In] [MarshalAs(UnmanagedType.LPWStr)] string lpPath, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpFileName,
            [In] [MarshalAs(UnmanagedType.LPWStr)] string lpExtension, uint nBufferLength, [Out] [MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpBuffer,
            ref IntPtr lpFilePart);

        /// Return Type: DWORD->unsigned int
        ///lpPath: LPCSTR->CHAR*
        ///lpFileName: LPCSTR->CHAR*
        ///lpExtension: LPCSTR->CHAR*
        ///nBufferLength: DWORD->unsigned int
        ///lpBuffer: LPSTR->CHAR*
        ///lpFilePart: LPSTR*
        [DllImport("kernel32.dll", EntryPoint = "SearchPathA")]
        public static extern uint SearchPathA(
            [In] [MarshalAs(UnmanagedType.LPStr)] string lpPath, [In] [MarshalAs(UnmanagedType.LPStr)] string lpFileName,
            [In] [MarshalAs(UnmanagedType.LPStr)] string lpExtension, uint nBufferLength, [Out] [MarshalAs(UnmanagedType.LPStr)] StringBuilder lpBuffer,
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
        [DllImport("kernel32.dll", EntryPoint = "MoveFileExW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool MoveFileExW(
            [In] [MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpNewFileName, uint dwFlags);

        /// Return Type: BOOL->int
        ///lpExistingFileName: LPCSTR->CHAR*
        ///lpNewFileName: LPCSTR->CHAR*
        ///dwFlags: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "MoveFileExA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool MoveFileExA(
            [In] [MarshalAs(UnmanagedType.LPStr)] string lpExistingFileName, [In] [MarshalAs(UnmanagedType.LPStr)] string lpNewFileName, uint dwFlags);

        /// Return Type: INT->int
        ///param0: LPWSTR->WCHAR*
        ///param1: LPOFSTRUCT->_OFSTRUCT*
        ///param2: WORD->unsigned short
        [DllImport("kernel32.dll", EntryPoint = "LZOpenFileW")]
        public static extern int LZOpenFileW([MarshalAs(UnmanagedType.LPWStr)] StringBuilder param0, ref OFSTRUCT param1, ushort param2);

        /// Return Type: INT->int
        ///param0: LPSTR->CHAR*
        ///param1: LPOFSTRUCT->_OFSTRUCT*
        ///param2: WORD->unsigned short
        [DllImport("kernel32.dll", EntryPoint = "LZOpenFileA")]
        public static extern int LZOpenFileA([MarshalAs(UnmanagedType.LPStr)] StringBuilder param0, ref OFSTRUCT param1, ushort param2);

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
        public static extern IntPtr HeapReAlloc(IntPtr hHeap, uint dwFlags, IntPtr lpMem, uint dwBytes);

        /// Return Type: BOOL->int
        ///hHeap: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "HeapDestroy")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool HeapDestroy([In] IntPtr hHeap);

        /// Return Type: SIZE_T->ULONG_PTR->unsigned int
        ///hHeap: HANDLE->void*
        ///dwFlags: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "HeapCompact")]
        public static extern uint HeapCompact([In] IntPtr hHeap, uint dwFlags);

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
        public static extern IntPtr GlobalAlloc(uint uFlags, uint dwBytes);

        /// Return Type: int
        ///Location: GEOID->LONG->int
        ///GeoType: GEOTYPE->DWORD->unsigned int
        ///lpGeoData: LPWSTR->WCHAR*
        ///cchData: int
        ///LangId: LANGID->WORD->unsigned short
        [DllImport("kernel32.dll", EntryPoint = "GetGeoInfoW")]
        public static extern int GetGeoInfoW(
            int Location, uint GeoType, [Out] [MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpGeoData, int cchData, ushort LangId);

        /// Return Type: int
        ///Location: GEOID->LONG->int
        ///GeoType: GEOTYPE->DWORD->unsigned int
        ///lpGeoData: LPSTR->CHAR*
        ///cchData: int
        ///LangId: LANGID->WORD->unsigned short
        [DllImport("kernel32.dll", EntryPoint = "GetGeoInfoA")]
        public static extern int GetGeoInfoA(
            int Location, uint GeoType, [Out] [MarshalAs(UnmanagedType.LPStr)] StringBuilder lpGeoData, int cchData, ushort LangId);

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
        [DllImport("kernel32.dll", EntryPoint = "FoldStringW")]
        public static extern int FoldStringW(
            uint dwMapFlags, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpSrcStr, int cchSrc, [Out] [MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpDestStr,
            int cchDest);

        /// Return Type: int
        ///dwMapFlags: DWORD->unsigned int
        ///lpSrcStr: LPCSTR->CHAR*
        ///cchSrc: int
        ///lpDestStr: LPSTR->CHAR*
        ///cchDest: int
        [DllImport("kernel32.dll", EntryPoint = "FoldStringA")]
        public static extern int FoldStringA(
            uint dwMapFlags, [In] [MarshalAs(UnmanagedType.LPStr)] string lpSrcStr, int cchSrc, [Out] [MarshalAs(UnmanagedType.LPStr)] StringBuilder lpDestStr,
            int cchDest);

        /// Return Type: void
        ///uExitCode: UINT->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "ExitProcess")]
        public static extern void ExitProcess(uint uExitCode);

        /// Return Type: BOOL->int
        ///lpFileName: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "DeleteFileW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DeleteFileW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);

        /// Return Type: BOOL->int
        ///lpFileName: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "DeleteFileA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DeleteFileA([In] [MarshalAs(UnmanagedType.LPStr)] string lpFileName);

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
        [DllImport("kernel32.dll", EntryPoint = "CreateFileW")]
        public static extern IntPtr CreateFileW(
            [In] [MarshalAs(UnmanagedType.LPWStr)] string lpFileName, uint dwDesiredAccess, uint dwShareMode, [In] IntPtr lpSecurityAttributes,
            uint dwCreationDisposition, uint dwFlagsAndAttributes, [In] IntPtr hTemplateFile);

        /// Return Type: HANDLE->void*
        ///lpFileName: LPCSTR->CHAR*
        ///dwDesiredAccess: DWORD->unsigned int
        ///dwShareMode: DWORD->unsigned int
        ///lpSecurityAttributes: LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        ///dwCreationDisposition: DWORD->unsigned int
        ///dwFlagsAndAttributes: DWORD->unsigned int
        ///hTemplateFile: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "CreateFileA")]
        public static extern IntPtr CreateFileA(
            [In] [MarshalAs(UnmanagedType.LPStr)] string lpFileName, uint dwDesiredAccess, uint dwShareMode, [In] IntPtr lpSecurityAttributes,
            uint dwCreationDisposition, uint dwFlagsAndAttributes, [In] IntPtr hTemplateFile);

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
        [DllImport("kernel32.dll", EntryPoint = "CopyFileExW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CopyFileExW(
            [In] [MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpNewFileName,
            LPPROGRESS_ROUTINE lpProgressRoutine, [In] IntPtr lpData, [In] IntPtr pbCancel, uint dwCopyFlags);

        /// Return Type: BOOL->int
        ///lpExistingFileName: LPCSTR->CHAR*
        ///lpNewFileName: LPCSTR->CHAR*
        ///lpProgressRoutine: LPPROGRESS_ROUTINE
        ///lpData: LPVOID->void*
        ///pbCancel: LPBOOL->BOOL*
        ///dwCopyFlags: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "CopyFileExA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CopyFileExA(
            [In] [MarshalAs(UnmanagedType.LPStr)] string lpExistingFileName, [In] [MarshalAs(UnmanagedType.LPStr)] string lpNewFileName,
            LPPROGRESS_ROUTINE lpProgressRoutine, [In] IntPtr lpData, [In] IntPtr pbCancel, uint dwCopyFlags);

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
        [DllImport("kernel32.dll", EntryPoint = "OpenMutexW")]
        public static extern IntPtr OpenMutexW(
            uint dwDesiredAccess, [MarshalAs(UnmanagedType.Bool)] bool bInheritHandle, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpName);

        /// Return Type: HANDLE->void*
        ///dwDesiredAccess: DWORD->unsigned int
        ///bInheritHandle: BOOL->int
        ///lpName: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "OpenMutexA")]
        public static extern IntPtr OpenMutexA(
            uint dwDesiredAccess, [MarshalAs(UnmanagedType.Bool)] bool bInheritHandle, [In] [MarshalAs(UnmanagedType.LPStr)] string lpName);

        /// Return Type: HANDLE->void*
        ///dwDesiredAccess: DWORD->unsigned int
        ///bInheritHandle: BOOL->int
        ///lpName: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "OpenEventW")]
        public static extern IntPtr OpenEventW(
            uint dwDesiredAccess, [MarshalAs(UnmanagedType.Bool)] bool bInheritHandle, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpName);

        /// Return Type: HANDLE->void*
        ///dwDesiredAccess: DWORD->unsigned int
        ///bInheritHandle: BOOL->int
        ///lpName: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "OpenEventA")]
        public static extern IntPtr OpenEventA(
            uint dwDesiredAccess, [MarshalAs(UnmanagedType.Bool)] bool bInheritHandle, [In] [MarshalAs(UnmanagedType.LPStr)] string lpName);

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
            [In] IntPtr hFile, uint dwFlags, uint dwReserved, uint nNumberOfBytesToLockLow, uint nNumberOfBytesToLockHigh, ref OVERLAPPED lpOverlapped);

        /// Return Type: UINT->unsigned int
        ///hMem: HLOCAL->HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "LocalFlags")]
        public static extern uint LocalFlags([In] IntPtr hMem);

        /// Return Type: HLOCAL->HANDLE->void*
        ///uFlags: UINT->unsigned int
        ///uBytes: SIZE_T->ULONG_PTR->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "LocalAlloc")]
        public static extern IntPtr LocalAlloc(uint uFlags, uint uBytes);

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
        public static extern bool CreatePipe(ref IntPtr hReadPipe, ref IntPtr hWritePipe, [In] IntPtr lpPipeAttributes, uint nSize);

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
        public static extern bool PurgeComm([In] IntPtr hFile, uint dwFlags);

        /// Return Type: BOOL->int
        ///lpExistingFileName: LPCWSTR->WCHAR*
        ///lpNewFileName: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "MoveFileW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool MoveFileW(
            [In] [MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpNewFileName);

        /// Return Type: BOOL->int
        ///lpExistingFileName: LPCSTR->CHAR*
        ///lpNewFileName: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "MoveFileA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool MoveFileA(
            [In] [MarshalAs(UnmanagedType.LPStr)] string lpExistingFileName, [In] [MarshalAs(UnmanagedType.LPStr)] string lpNewFileName);

        /// Return Type: LPWSTR->WCHAR*
        ///lpString1: LPWSTR->WCHAR*
        ///lpString2: LPCWSTR->WCHAR*
        ///iMaxLength: int
        [DllImport("kernel32.dll", EntryPoint = "lstrcpynW")]
        public static extern IntPtr lstrcpynW(
            [Out] [MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpString1, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpString2, int iMaxLength);

        /// Return Type: LPSTR->CHAR*
        ///lpString1: LPSTR->CHAR*
        ///lpString2: LPCSTR->CHAR*
        ///iMaxLength: int
        [DllImport("kernel32.dll", EntryPoint = "lstrcpynA")]
        public static extern IntPtr lstrcpynA(
            [Out] [MarshalAs(UnmanagedType.LPStr)] StringBuilder lpString1, [In] [MarshalAs(UnmanagedType.LPStr)] string lpString2, int iMaxLength);

        /// Return Type: int
        ///lpString1: LPCWSTR->WCHAR*
        ///lpString2: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "lstrcmpiW")]
        public static extern int lstrcmpiW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpString1, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpString2);

        /// Return Type: int
        ///lpString1: LPCSTR->CHAR*
        ///lpString2: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "lstrcmpiA")]
        public static extern int lstrcmpiA([In] [MarshalAs(UnmanagedType.LPStr)] string lpString1, [In] [MarshalAs(UnmanagedType.LPStr)] string lpString2);

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
        public static extern IntPtr HeapAlloc([In] IntPtr hHeap, uint dwFlags, uint dwBytes);

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
        [DllImport("kernel32.dll", EntryPoint = "FindAtomW")]
        public static extern ushort FindAtomW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpString);

        /// Return Type: ATOM->WORD->unsigned short
        ///lpString: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "FindAtomA")]
        public static extern ushort FindAtomA([In] [MarshalAs(UnmanagedType.LPStr)] string lpString);

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
        [DllImport("kernel32.dll", EntryPoint = "CopyFileW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CopyFileW(
            [In] [MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpNewFileName,
            [MarshalAs(UnmanagedType.Bool)] bool bFailIfExists);

        /// Return Type: BOOL->int
        ///lpExistingFileName: LPCSTR->CHAR*
        ///lpNewFileName: LPCSTR->CHAR*
        ///bFailIfExists: BOOL->int
        [DllImport("kernel32.dll", EntryPoint = "CopyFileA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CopyFileA(
            [In] [MarshalAs(UnmanagedType.LPStr)] string lpExistingFileName, [In] [MarshalAs(UnmanagedType.LPStr)] string lpNewFileName,
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
        [DllImport("kernel32.dll", EntryPoint = "lstrlenW")]
        public static extern int lstrlenW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpString);

        /// Return Type: int
        ///lpString: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "lstrlenA")]
        public static extern int lstrlenA([In] [MarshalAs(UnmanagedType.LPStr)] string lpString);

        /// Return Type: LPWSTR->WCHAR*
        ///lpString1: LPWSTR->WCHAR*
        ///lpString2: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "lstrcpyW")]
        public static extern IntPtr lstrcpyW(
            [Out] [MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpString1, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpString2);

        /// Return Type: LPSTR->CHAR*
        ///lpString1: LPSTR->CHAR*
        ///lpString2: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "lstrcpyA")]
        public static extern IntPtr lstrcpyA(
            [Out] [MarshalAs(UnmanagedType.LPStr)] StringBuilder lpString1, [In] [MarshalAs(UnmanagedType.LPStr)] string lpString2);

        /// Return Type: int
        ///lpString1: LPCWSTR->WCHAR*
        ///lpString2: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "lstrcmpW")]
        public static extern int lstrcmpW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpString1, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpString2);

        /// Return Type: int
        ///lpString1: LPCSTR->CHAR*
        ///lpString2: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "lstrcmpA")]
        public static extern int lstrcmpA([In] [MarshalAs(UnmanagedType.LPStr)] string lpString1, [In] [MarshalAs(UnmanagedType.LPStr)] string lpString2);

        /// Return Type: LPWSTR->WCHAR*
        ///lpString1: LPWSTR->WCHAR*
        ///lpString2: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "lstrcatW")]
        public static extern IntPtr lstrcatW(IntPtr lpString1, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpString2);

        /// Return Type: LPSTR->CHAR*
        ///lpString1: LPSTR->CHAR*
        ///lpString2: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "lstrcatA")]
        public static extern IntPtr lstrcatA(IntPtr lpString1, [In] [MarshalAs(UnmanagedType.LPStr)] string lpString2);

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
        public static extern uint HeapSize([In] IntPtr hHeap, uint dwFlags, [In] IntPtr lpMem);

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
        public static extern bool HeapFree(IntPtr hHeap, uint dwFlags, IntPtr lpMem);

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
        [DllImport("kernel32.dll", EntryPoint = "AddAtomW")]
        public static extern ushort AddAtomW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpString);

        /// Return Type: ATOM->WORD->unsigned short
        ///lpString: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "AddAtomA")]
        public static extern ushort AddAtomA([In] [MarshalAs(UnmanagedType.LPStr)] string lpString);

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
        public static extern int _lcreat([In] [MarshalAs(UnmanagedType.LPStr)] string lpPathName, int iAttribute);

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
    }

    // ReSharper restore InconsistentNaming
}