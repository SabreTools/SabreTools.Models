namespace SabreTools.Models.CHD
{
    /// <see href="https://github.com/mamedev/mame/blob/master/src/lib/util/chd.h"/> 
    public class HeaderV4 : Header
    {
        /// <summary>
        /// Flags
        /// </summary>
        public Flags Flags { get; set; }

        /// <summary>
        /// Compression type
        /// </summary>
        public CompressionType Compression { get; set; }

        /// <summary>
        /// Total # of hunks represented
        /// </summary>
        public uint TotalHunks { get; set; }

        /// <summary>
        /// Logical size of the data (in bytes)
        /// </summary>
        public ulong LogicalBytes { get; set; }

        /// <summary>
        /// Offset to the first blob of metadata
        /// </summary>
        public ulong MetaOffset { get; set; }

        /// <summary>
        /// Number of bytes per hunk
        /// </summary>
        public uint HunkBytes { get; set; }

        /// <summary>
        /// Combined raw+meta SHA1
        /// </summary>
#if NET48
        public byte[] SHA1 { get; set; } = new byte[20];
#else
        public byte[]? SHA1 { get; set; } = new byte[20];
#endif

        /// <summary>
        /// Combined raw+meta SHA1 of parent
        /// </summary>
#if NET48
        public byte[] ParentSHA1 { get; set; } = new byte[20];
#else
        public byte[]? ParentSHA1 { get; set; } = new byte[20];
#endif

        /// <summary>
        /// Raw data SHA1
        /// </summary>
#if NET48
        public byte[] RawSHA1 { get; set; } = new byte[20];
#else
        public byte[]? RawSHA1 { get; set; } = new byte[20];
#endif
    }
}
