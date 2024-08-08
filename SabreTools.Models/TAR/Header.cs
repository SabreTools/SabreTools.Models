namespace SabreTools.Models.TAR
{
    public sealed class Header
    {
        /// <summary>
        /// File name
        /// </summary>
        public string? FileName { get; set; }

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
        public string? LinkName { get; set; }

        /// <summary>
        /// UStar indicator, "ustar", then NUL
        /// </summary>
        public string? Magic { get; set; }

        /// <summary>
        /// UStar version, "00"
        /// </summary>
        public string? Version { get; set; }

        /// <summary>
        /// Owner user name
        /// </summary>
        public string? UserName { get; set; }

        /// <summary>
        /// Owner group name
        /// </summary>
        public string? GroupName { get; set; }

        /// <summary>
        /// Device major number
        /// </summary>
        public string? DevMajor { get; set; }

        /// <summary>
        /// Device minor number
        /// </summary>
        public string? DevMinor { get; set; }

        /// <summary>
        /// Filename prefix
        /// </summary>
        public string? Prefix { get; set; }
    }
}