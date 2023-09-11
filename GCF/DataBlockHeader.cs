namespace SabreTools.Models.GCF
{
    /// <see href="https://github.com/RavuAlHemio/hllib/blob/master/HLLib/GCFFile.h"/>
    public sealed class DataBlockHeader
    {
        /// <summary>
        /// GCF file version.  This field is not part of all file versions.
        /// </summary>
        public uint LastVersionPlayed { get; set; }

        /// <summary>
        /// Number of data blocks.
        /// </summary>
        public uint BlockCount { get; set; }

        /// <summary>
        /// Size of each data block in bytes.
        /// </summary>
        public uint BlockSize { get; set; }

        /// <summary>
        /// Offset to first data block.
        /// </summary>
        public uint FirstBlockOffset { get; set; }

        /// <summary>
        /// Number of data blocks that contain data.
        /// </summary>
        public uint BlocksUsed { get; set; }

        /// <summary>
        /// Header checksum.
        /// </summary>
        public uint Checksum { get; set; }
    }
}