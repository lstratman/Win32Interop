namespace Win32Interop.Enums
{
    public enum MEMORY_RESOURCE_NOTIFICATION_TYPE
    {
        LowMemoryResourceNotification,

        HighMemoryResourceNotification,
    }

    public enum JOBOBJECTINFOCLASS
    {
        /// JobObjectBasicAccountingInformation -> 1
        JobObjectBasicAccountingInformation = 1,

        JobObjectBasicLimitInformation,

        JobObjectBasicProcessIdList,

        JobObjectBasicUIRestrictions,

        JobObjectSecurityLimitInformation,

        JobObjectEndOfJobTimeInformation,

        JobObjectAssociateCompletionPortInformation,

        JobObjectBasicAndIoAccountingInformation,

        JobObjectExtendedLimitInformation,

        JobObjectJobSetInformation,

        MaxJobObjectInfoClass,
    }

    public enum LATENCY_TIME
    {
        LT_DONT_CARE,

        LT_LOWEST_LATENCY,
    }

    public enum HEAP_INFORMATION_CLASS
    {
        HeapCompatibilityInformation,
    }

    public enum GET_FILEEX_INFO_LEVELS
    {
        GetFileExInfoStandard,

        GetFileExMaxInfoLevel,
    }

    public enum COMPUTER_NAME_FORMAT
    {
        ComputerNameNetBIOS,

        ComputerNameDnsHostname,

        ComputerNameDnsDomain,

        ComputerNameDnsFullyQualified,

        ComputerNamePhysicalNetBIOS,

        ComputerNamePhysicalDnsHostname,

        ComputerNamePhysicalDnsDomain,

        ComputerNamePhysicalDnsFullyQualified,

        ComputerNameMax,
    }

    public enum FINDEX_INFO_LEVELS
    {
        FindExInfoStandard,

        FindExInfoMaxInfoLevel,
    }

    public enum FINDEX_SEARCH_OPS
    {
        FindExSearchNameMatch,

        FindExSearchLimitToDirectories,

        FindExSearchLimitToDevices,

        FindExSearchMaxSearchOp,
    }
}
