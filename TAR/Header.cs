namespace SabreTools.Models.TAR
{
    public sealed class Header
    {
        /// <summary>
        /// File name
        /// </summary>
#if NET48
        public string FileName { get; set; }
#else
        public string? FileName { get; set; }
#endif

        /// <summary>
        /// File mode
        /// </summary>
        public Mode Mode { get; set; }

         /// <summary>
        /// Owner's numeric user ID
        /// </summary>
        public uint UID { get; set; }

         /// <summary>
        /// Owner's numeric user ID
        /// </summary>
        public uint GID { get; set; }

        /// <summary>
        /// File size in bytes
        /// </summary>
        public ulong Size { get; set; }

        /// <summary>
        /// Last modification time in numeric Unix time format
        /// </summary>
        public ulong ModifiedTime { get; set; }

        /// <summary>
        /// Checksum for header record
        /// </summary>
        public ushort Checksum { get; set; }

        /// <summary>
        /// Link indicator (file type) / Type flag
        /// </summary>
        public TypeFlag TypeFlag { get; set; }

        /// <summary>
        /// Name of linked file
        /// </summary>
#if NET48
        public string LinkName { get; set; }
#else
        public string? LinkName { get; set; }
#endif

        /// <summary>
        /// UStar indicator, "ustar", then NUL
        /// </summary>
#if NET48
        public string Magic { get; set; }
#else
        public string? Magic { get; set; }
#endif

        /// <summary>
        /// UStar version, "00"
        /// </summary>
#if NET48
        public string Version { get; set; }
#else
        public string? Version { get; set; }
#endif

        /// <summary>
        /// Owner user name
        /// </summary>
#if NET48
        public string UserName { get; set; }
#else
        public string? UserName { get; set; }
#endif

        /// <summary>
        /// Owner group name
        /// </summary>
#if NET48
        public string GroupName { get; set; }
#else
        public string? GroupName { get; set; }
#endif

        /// <summary>
        /// Device major number
        /// </summary>
#if NET48
        public string DevMajor { get; set; }
#else
        public string? DevMajor { get; set; }
#endif

        /// <summary>
        /// Device minor number
        /// </summary>
#if NET48
        public string DevMinor { get; set; }
#else
        public string? DevMinor { get; set; }
#endif

        /// <summary>
        /// Filename prefix
        /// </summary>
#if NET48
        public string Prefix { get; set; }
#else
        public string? Prefix { get; set; }
#endif
    }
}