namespace SabreTools.Models.NCF
{
    /// <see href="https://github.com/RavuAlHemio/hllib/blob/master/HLLib/NCFFile.h"/>
    public sealed class DirectoryHeader
    {
        /// <summary>
        /// Always 0x00000004
        /// </summary>
        public uint Dummy0 { get; set; }

        /// <summary>
        /// Cache ID.
        /// </summary>
        public uint CacheID { get; set; }

        /// <summary>
        /// NCF file version.
        /// </summary>
        public uint LastVersionPlayed { get; set; }

        /// <summary>
        /// Number of items in the directory.
        /// </summary>
        public uint ItemCount { get; set; }

        /// <summary>
        /// Number of files in the directory.
        /// </summary>
        public uint FileCount { get; set; }

        /// <summary>
        /// Always 0x00008000.  Data per checksum?
        /// </summary>
        public uint ChecksumDataLength { get; set; }

        /// <summary>
        /// Size of lpNCFDirectoryEntries & lpNCFDirectoryNames & lpNCFDirectoryInfo1Entries & lpNCFDirectoryInfo2Entries & lpNCFDirectoryCopyEntries & lpNCFDirectoryLocalEntries in bytes.
        /// </summary>
        public uint DirectorySize { get; set; }

        /// <summary>
        /// Size of the directory names in bytes.
        /// </summary>
        public uint NameSize { get; set; }

        /// <summary>
        /// Number of Info1 entires.
        /// </summary>
        public uint Info1Count { get; set; }

        /// <summary>
        /// Number of files to copy.
        /// </summary>
        public uint CopyCount { get; set; }

        /// <summary>
        /// Number of files to keep local.
        /// </summary>
        public uint LocalCount { get; set; }

        /// <summary>
        /// Reserved
        /// </summary>
        public uint Dummy1 { get; set; }

        /// <summary>
        /// Reserved
        /// </summary>
        public uint Dummy2 { get; set; }

        /// <summary>
        /// Header checksum.
        /// </summary>
        public uint Checksum { get; set; }
    }
}
