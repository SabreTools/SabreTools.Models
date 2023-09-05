namespace SabreTools.Models.XZP
{
    /// <summary>
    /// XBox Package File
    /// </summary>
    /// <see href="https://github.com/RavuAlHemio/hllib/blob/master/HLLib/XZPFile.h"/>
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
        /// Directory entries data
        /// </summary>
#if NET48
        public DirectoryEntry[] DirectoryEntries { get; set; }
#else
        public DirectoryEntry[]? DirectoryEntries { get; set; }
#endif

        /// <summary>
        /// Preload directory entries data
        /// </summary>
#if NET48
        public DirectoryEntry[] PreloadDirectoryEntries { get; set; }
#else
        public DirectoryEntry[]? PreloadDirectoryEntries { get; set; }
#endif

        /// <summary>
        /// Preload directory mappings data
        /// </summary>
#if NET48
        public DirectoryMapping[] PreloadDirectoryMappings { get; set; }
#else
        public DirectoryMapping[]? PreloadDirectoryMappings { get; set; }
#endif

        /// <summary>
        /// Directory items data
        /// </summary>
#if NET48
        public DirectoryItem[] DirectoryItems { get; set; }
#else
        public DirectoryItem[]? DirectoryItems { get; set; }
#endif

        /// <summary>
        /// Footer data
        /// </summary>
#if NET48
        public Footer Footer { get; set; }
#else
        public Footer? Footer { get; set; }
#endif
    }
}
