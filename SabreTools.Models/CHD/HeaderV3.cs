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
        public byte[]? MD5 { get; set; } = new byte[16];

        /// <summary>
        /// MD5 checksum of parent file
        /// </summary>
        public byte[]? ParentMD5 { get; set; } = new byte[16];

        /// <summary>
        /// Number of bytes per hunk
        /// </summary>
        public uint HunkBytes { get; set; }

        /// <summary>
        /// SHA1 checksum of raw data
        /// </summary>
        public byte[]? SHA1 { get; set; } = new byte[20];

        /// <summary>
        /// SHA1 checksum of parent file
        /// </summary>
        public byte[]? ParentSHA1 { get; set; } = new byte[20];
    }
}
