namespace SabreTools.Models.N3DS
{
    /// <summary>
    /// RomFS (or Read-Only Filesystem) is part of the NCCH format, and is
    /// used as external file storage.
    /// </summary>
    /// <see href="https://www.3dbrew.org/wiki/RomFS"/>
    /// TODO: Implement the other parts of the RomFS tree structure
    public sealed class RomFSHeader
    {
        /// <summary>
        /// Magic "IVFC"
        /// </summary>
#if NET48
        public string MagicString;
#else
        public string? MagicString;
#endif

        /// <summary>
        /// Magic number 0x10000
        /// </summary>
        public uint MagicNumber;

        /// <summary>
        /// Master hash size
        /// </summary>
        public uint MasterHashSize;

        /// <summary>
        /// Level 1 logical offset
        /// </summary>
        public ulong Level1LogicalOffset;

        /// <summary>
        /// Level 1 hashdata size
        /// </summary>
        public ulong Level1HashdataSize;

        /// <summary>
        /// Level 1 block size, in log2
        /// </summary>
        public uint Level1BlockSizeLog2;

        /// <summary>
        /// Reserved
        /// </summary>
#if NET48
        public byte[] Reserved1;
#else
        public byte[]? Reserved1;
#endif

        /// <summary>
        /// Level 2 logical offset
        /// </summary>
        public ulong Level2LogicalOffset;

        /// <summary>
        /// Level 2 hashdata size
        /// </summary>
        public ulong Level2HashdataSize;

        /// <summary>
        /// Level 2 block size, in log2
        /// </summary>
        public uint Level2BlockSizeLog2;

        /// <summary>
        /// Reserved
        /// </summary>
#if NET48
        public byte[] Reserved2;
#else
        public byte[]? Reserved2;
#endif

        /// <summary>
        /// Level 3 logical offset
        /// </summary>
        public ulong Level3LogicalOffset;

        /// <summary>
        /// Level 3 hashdata size
        /// </summary>
        public ulong Level3HashdataSize;

        /// <summary>
        /// Level 3 block size, in log2
        /// </summary>
        public uint Level3BlockSizeLog2;

        /// <summary>
        /// Reserved
        /// </summary>
#if NET48
        public byte[] Reserved3;
#else
        public byte[]? Reserved3;
#endif

        /// <summary>
        /// Reserved
        /// </summary>
#if NET48
        public byte[] Reserved4;
#else
        public byte[]? Reserved4;
#endif

        /// <summary>
        /// Optional info size.
        /// </summary>
        public uint OptionalInfoSize;
    }
}
