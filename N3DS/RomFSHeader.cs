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
        public string? MagicString { get; set; }

        /// <summary>
        /// Magic number 0x10000
        /// </summary>
        public uint MagicNumber { get; set; }

        /// <summary>
        /// Master hash size
        /// </summary>
        public uint MasterHashSize { get; set; }

        /// <summary>
        /// Level 1 logical offset
        /// </summary>
        public ulong Level1LogicalOffset { get; set; }

        /// <summary>
        /// Level 1 hashdata size
        /// </summary>
        public ulong Level1HashdataSize { get; set; }

        /// <summary>
        /// Level 1 block size, in log2
        /// </summary>
        public uint Level1BlockSizeLog2 { get; set; }

        /// <summary>
        /// Reserved
        /// </summary>
        public byte[]? Reserved1 { get; set; }

        /// <summary>
        /// Level 2 logical offset
        /// </summary>
        public ulong Level2LogicalOffset { get; set; }

        /// <summary>
        /// Level 2 hashdata size
        /// </summary>
        public ulong Level2HashdataSize { get; set; }

        /// <summary>
        /// Level 2 block size, in log2
        /// </summary>
        public uint Level2BlockSizeLog2 { get; set; }

        /// <summary>
        /// Reserved
        /// </summary>
        public byte[]? Reserved2 { get; set; }

        /// <summary>
        /// Level 3 logical offset
        /// </summary>
        public ulong Level3LogicalOffset { get; set; }

        /// <summary>
        /// Level 3 hashdata size
        /// </summary>
        public ulong Level3HashdataSize { get; set; }

        /// <summary>
        /// Level 3 block size, in log2
        /// </summary>
        public uint Level3BlockSizeLog2 { get; set; }

        /// <summary>
        /// Reserved
        /// </summary>
        public byte[]? Reserved3 { get; set; }

        /// <summary>
        /// Reserved
        /// </summary>
        public byte[]? Reserved4 { get; set; }

        /// <summary>
        /// Optional info size.
        /// </summary>
        public uint OptionalInfoSize { get; set; }
    }
}
