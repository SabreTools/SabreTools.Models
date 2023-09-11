namespace SabreTools.Models.NCF
{
    /// <see href="https://github.com/RavuAlHemio/hllib/blob/master/HLLib/NCFFile.h"/>
    public sealed class Header
    {
        /// <summary>
        /// Always 0x00000001
        /// </summary>
        public uint Dummy0 { get; set; }

        /// <summary>
        /// Always 0x00000002
        /// </summary>
        public uint MajorVersion { get; set; }

        /// <summary>
        /// NCF version number.
        /// </summary>
        public uint MinorVersion { get; set; }

        /// <summary>
        /// Cache ID
        /// </summary>
        public uint CacheID { get; set; }

        /// <summary>
        /// Last version played
        /// </summary>
        public uint LastVersionPlayed { get; set; }

        /// <summary>
        /// Reserved
        /// </summary>
        public uint Dummy1 { get; set; }

        /// <summary>
        /// Reserved
        /// </summary>
        public uint Dummy2 { get; set; }

        /// <summary>
        /// Total size of NCF file in bytes.
        /// </summary>
        public uint FileSize { get; set; }

        /// <summary>
        /// Size of each data block in bytes.
        /// </summary>
        public uint BlockSize { get; set; }

        /// <summary>
        /// Number of data blocks.
        /// </summary>
        public uint BlockCount { get; set; }

        /// <summary>
        /// Reserved
        /// </summary>
        public uint Dummy3 { get; set; }
    }
}
