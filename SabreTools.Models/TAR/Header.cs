namespace SabreTools.Models.TAR
{
    /// <see href="https://www.ibm.com/docs/en/aix/7.3?topic=files-tarh-file"/> 
    public sealed class Header
    {
        /// <summary>
        /// File name without a forward slash
        /// </summary>
        /// <remarks>100 bytes</remarks>
        public string? FileName { get; set; }

        /// <summary>
        /// File mode
        /// </summary>
        /// <remarks>8 bytes, octal string representation</remarks>
        public Mode Mode { get; set; }

        /// <summary>
        /// Owner's numeric user ID
        /// </summary>
        /// <remarks>8 bytes, octal string representation</remarks>
        public uint UID { get; set; }

         /// <summary>
        /// Owner's numeric group ID
        /// </summary>
        /// <remarks>8 bytes, octal string representation</remarks>
        public uint GID { get; set; }

        /// <summary>
        /// File size in bytes
        /// </summary>
        /// <remarks>12 bytes, octal string representation</remarks>
        public ulong Size { get; set; }

        /// <summary>
        /// Last modification time in numeric Unix time format
        /// </summary>
        /// <remarks>12 bytes, octal string representation</remarks>
        public ulong ModifiedTime { get; set; }

        /// <summary>
        /// Checksum for header record
        /// </summary>
        /// <remarks>8 bytes, octal string representation</remarks>
        public ushort Checksum { get; set; }

        /// <summary>
        /// Link indicator (file type) / Type flag
        /// </summary>
        public TypeFlag TypeFlag { get; set; }

        /// <summary>
        /// Linked path name or file name
        /// </summary>
        /// <remarks>100 bytes</remarks>
        public string? LinkName { get; set; }

        /// <summary>
        /// UStar indicator, "ustar", then NUL
        /// </summary>
        /// <remarks>6 bytes</remarks>
        public string? Magic { get; set; }

        /// <summary>
        /// UStar version, "00"
        /// </summary>
        /// <remarks>3 bytes</remarks>
        public string? Version { get; set; }

        /// <summary>
        /// Owner user name
        /// </summary>
        /// <remarks>32 bytes</remarks>
        public string? UserName { get; set; }

        /// <summary>
        /// Owner group name
        /// </summary>
        /// <remarks>32 bytes</remarks>
        public string? GroupName { get; set; }

        /// <summary>
        /// Device major number
        /// </summary>
        /// <remarks>8 bytes, octal(?)</remarks>
        public string? DevMajor { get; set; }

        /// <summary>
        /// Device minor number
        /// </summary>
        /// <remarks>8 bytes, octal(?)</remarks>
        public string? DevMinor { get; set; }

        /// <summary>
        /// Path name without trailing slashes
        /// </summary>
        /// <remarks>155 bytes</remarks>
        public string? Prefix { get; set; }
    }
}