namespace SabreTools.Models.CHD
{
    /// <see href="https://github.com/mamedev/mame/blob/master/src/lib/util/chd.h"/> 
    public class HeaderV5 : Header
    {
        /// <summary>
        /// Which custom compressors are used?
        /// </summary>
        public uint[] Compressors { get; set; } = new uint[4];

        /// <summary>
        /// Logical size of the data (in bytes)
        /// </summary>
        public ulong LogicalBytes { get; set; }

        /// <summary>
        /// Offset to the map
        /// </summary>
        public ulong MapOffset { get; set; }

        /// <summary>
        /// Offset to the first blob of metadata
        /// </summary>
        public ulong MetaOffset { get; set; }

        /// <summary>
        /// Number of bytes per hunk (512k maximum)
        /// </summary>
        public uint HunkBytes { get; set; }

        /// <summary>
        /// Number of bytes per unit within each hunk
        /// </summary>
        public uint UnitBytes { get; set; }

        /// <summary>
        /// Raw data SHA1
        /// </summary>
#if NET48
        public byte[] RawSHA1 { get; set; }
#else
        public byte[]? RawSHA1 { get; set; }
#endif

        /// <summary>
        /// Combined raw+meta SHA1
        /// </summary>
#if NET48
        public byte[] SHA1 { get; set; }
#else
        public byte[]? SHA1 { get; set; }
#endif

        /// <summary>
        /// Combined raw+meta SHA1 of parent
        /// </summary>
#if NET48
        public byte[] ParentSHA1 { get; set; }
#else
        public byte[]? ParentSHA1 { get; set; }
#endif
    }
}
