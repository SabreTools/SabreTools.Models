namespace SabreTools.Models.CHD
{
    /// <see href="https://github.com/mamedev/mame/blob/master/src/lib/util/chd.h"/> 
    public class HeaderV3 : Header
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
        /// MD5 checksum of raw data
        /// </summary>
#if NET48
        public byte[] MD5 { get; set; } = new byte[16];
#else
        public byte[]? MD5 { get; set; } = new byte[16];
#endif

        /// <summary>
        /// MD5 checksum of parent file
        /// </summary>
#if NET48
        public byte[] ParentMD5 { get; set; } = new byte[16];
#else
        public byte[]? ParentMD5 { get; set; } = new byte[16];
#endif

        /// <summary>
        /// Number of bytes per hunk
        /// </summary>
        public uint HunkBytes { get; set; }

        /// <summary>
        /// SHA1 checksum of raw data
        /// </summary>
#if NET48
        public byte[] SHA1 { get; set; } = new byte[20];
#else
        public byte[]? SHA1 { get; set; } = new byte[20];
#endif

        /// <summary>
        /// SHA1 checksum of parent file
        /// </summary>
#if NET48
        public byte[] ParentSHA1 { get; set; } = new byte[20];
#else
        public byte[]? ParentSHA1 { get; set; } = new byte[20];
#endif
    }
}
