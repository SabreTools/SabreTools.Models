namespace SabreTools.Models.CHD
{
    /// <see href="https://github.com/mamedev/mame/blob/master/src/lib/util/chd.h"/> 
    public class HeaderV1 : Header
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
        /// 512-byte sectors per hunk
        /// </summary>
        public uint HunkSize { get; set; }

        /// <summary>
        /// Total # of hunks represented
        /// </summary>
        public uint TotalHunks { get; set; }

        /// <summary>
        /// Number of cylinders on hard disk
        /// </summary>
        public uint Cylinders { get; set; }

        /// <summary>
        /// Number of heads on hard disk
        /// </summary>
        public uint Heads { get; set; }

        /// <summary>
        /// Number of sectors on hard disk
        /// </summary>
        public uint Sectors { get; set; }

        /// <summary>
        /// MD5 checksum of raw data
        /// </summary>
        public byte[]? MD5 { get; set; } = new byte[16];

        /// <summary>
        /// MD5 checksum of parent file
        /// </summary>
        public byte[]? ParentMD5 { get; set; } = new byte[16];
    }
}
