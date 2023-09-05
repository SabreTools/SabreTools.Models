namespace SabreTools.Models.TAR
{
    public sealed class Header
    {
        /// <summary>
        /// File name
        /// </summary>
#if NET48
        public string FileName;
#else
        public string? FileName;
#endif

        /// <summary>
        /// File mode
        /// </summary>
        public Mode Mode;

         /// <summary>
        /// Owner's numeric user ID
        /// </summary>
        public uint UID;

         /// <summary>
        /// Owner's numeric user ID
        /// </summary>
        public uint GID;

        /// <summary>
        /// File size in bytes
        /// </summary>
        public ulong Size;

        /// <summary>
        /// Last modification time in numeric Unix time format
        /// </summary>
        public ulong ModifiedTime;

        /// <summary>
        /// Checksum for header record
        /// </summary>
        public ushort Checksum;

        /// <summary>
        /// Link indicator (file type) / Type flag
        /// </summary>
        public TypeFlag TypeFlag;

        /// <summary>
        /// Name of linked file
        /// </summary>
#if NET48
        public string LinkName;
#else
        public string? LinkName;
#endif

        /// <summary>
        /// UStar indicator, "ustar", then NUL
        /// </summary>
#if NET48
        public string Magic;
#else
        public string? Magic;
#endif

        /// <summary>
        /// UStar version, "00"
        /// </summary>
#if NET48
        public string Version;
#else
        public string? Version;
#endif

        /// <summary>
        /// Owner user name
        /// </summary>
#if NET48
        public string UserName;
#else
        public string? UserName;
#endif

        /// <summary>
        /// Owner group name
        /// </summary>
#if NET48
        public string GroupName;
#else
        public string? GroupName;
#endif

        /// <summary>
        /// Device major number
        /// </summary>
#if NET48
        public string DevMajor;
#else
        public string? DevMajor;
#endif

        /// <summary>
        /// Device minor number
        /// </summary>
#if NET48
        public string DevMinor;
#else
        public string? DevMinor;
#endif

        /// <summary>
        /// Filename prefix
        /// </summary>
#if NET48
        public string Prefix;
#else
        public string? Prefix;
#endif
    }
}