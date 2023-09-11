namespace SabreTools.Models.GCF
{
    /// <see href="https://github.com/RavuAlHemio/hllib/blob/master/HLLib/GCFFile.h"/>
    public sealed class BlockEntryHeader
    {
        /// <summary>
        /// Number of data blocks.
        /// </summary>
        public uint BlockCount { get; set; }

        /// <summary>
        /// Number of data blocks that point to data.
        /// </summary>
        public uint BlocksUsed { get; set; }

        /// <summary>
        /// Reserved
        /// </summary>
        public uint Dummy0 { get; set; }

        /// <summary>
        /// Reserved
        /// </summary>
        public uint Dummy1 { get; set; }

        /// <summary>
        /// Reserved
        /// </summary>
        public uint Dummy2 { get; set; }

        /// <summary>
        /// Reserved
        /// </summary>
        public uint Dummy3 { get; set; }

        /// <summary>
        /// Reserved
        /// </summary>
        public uint Dummy4 { get; set; }

        /// <summary>
        /// Header checksum.
        /// </summary>
        public uint Checksum { get; set; }
    }
}