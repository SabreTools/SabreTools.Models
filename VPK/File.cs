namespace SabreTools.Models.VPK
{
    /// <summary>
    /// Valve Package File
    /// </summary>
    /// <see href="https://github.com/RavuAlHemio/hllib/blob/master/HLLib/VPKFile.h"/>
    public sealed class File
    {
        /// <summary>
        /// Header data
        /// </summary>
#if NET48
        public Header Header { get; set; }
#else
        public Header? Header { get; set; }
#endif

        /// <summary>
        /// Extended header data
        /// </summary>
#if NET48
        public ExtendedHeader ExtendedHeader { get; set; }
#else
        public ExtendedHeader? ExtendedHeader { get; set; }
#endif

        /// <summary>
        /// Archive hashes data
        /// </summary>
#if NET48
        public ArchiveHash[] ArchiveHashes { get; set; }
#else
        public ArchiveHash[]? ArchiveHashes { get; set; }
#endif

        /// <summary>
        /// Directory items data
        /// </summary>
#if NET48
        public DirectoryItem[] DirectoryItems { get; set; }
#else
        public DirectoryItem[]? DirectoryItems { get; set; }
#endif
    }
}
