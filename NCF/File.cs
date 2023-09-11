using System.Collections.Generic;

namespace SabreTools.Models.NCF
{
    /// <summary>
    /// Half-Life No Cache File
    /// </summary>
    /// <see href="https://github.com/RavuAlHemio/hllib/blob/master/HLLib/NCFFile.h"/>
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
        /// Directory header data
        /// </summary>
#if NET48
        public DirectoryHeader DirectoryHeader { get; set; }
#else
        public DirectoryHeader? DirectoryHeader { get; set; }
#endif

        /// <summary>
        /// Directory entries data
        /// </summary>
#if NET48
        public DirectoryEntry[] DirectoryEntries { get; set; }
#else
        public DirectoryEntry?[]? DirectoryEntries { get; set; }
#endif

        /// <summary>
        /// Directory names data
        /// </summary>
#if NET48
        public Dictionary<long, string> DirectoryNames { get; set; }
#else
        public Dictionary<long, string?>? DirectoryNames { get; set; }
#endif

        /// <summary>
        /// Directory info 1 entries data
        /// </summary>
#if NET48
        public DirectoryInfo1Entry[] DirectoryInfo1Entries { get; set; }
#else
        public DirectoryInfo1Entry?[]? DirectoryInfo1Entries { get; set; }
#endif

        /// <summary>
        /// Directory info 2 entries data
        /// </summary>
#if NET48
        public DirectoryInfo2Entry[] DirectoryInfo2Entries { get; set; }
#else
        public DirectoryInfo2Entry?[]? DirectoryInfo2Entries { get; set; }
#endif

        /// <summary>
        /// Directory copy entries data
        /// </summary>
#if NET48
        public DirectoryCopyEntry[] DirectoryCopyEntries { get; set; }
#else
        public DirectoryCopyEntry?[]? DirectoryCopyEntries { get; set; }
#endif

        /// <summary>
        /// Directory local entries data
        /// </summary>
#if NET48
        public DirectoryLocalEntry[] DirectoryLocalEntries { get; set; }
#else
        public DirectoryLocalEntry?[]? DirectoryLocalEntries { get; set; }
#endif

        /// <summary>
        /// Unknown header data
        /// </summary>
#if NET48
        public UnknownHeader UnknownHeader { get; set; }
#else
        public UnknownHeader? UnknownHeader { get; set; }
#endif

        /// <summary>
        /// Unknown entries data
        /// </summary>
#if NET48
        public UnknownEntry[] UnknownEntries { get; set; }
#else
        public UnknownEntry?[]? UnknownEntries { get; set; }
#endif

        /// <summary>
        /// Checksum header data
        /// </summary>
#if NET48
        public ChecksumHeader ChecksumHeader { get; set; }
#else
        public ChecksumHeader? ChecksumHeader { get; set; }
#endif

        /// <summary>
        /// Checksum map header data
        /// </summary>
#if NET48
        public ChecksumMapHeader ChecksumMapHeader { get; set; }
#else
        public ChecksumMapHeader? ChecksumMapHeader { get; set; }
#endif

        /// <summary>
        /// Checksum map entries data
        /// </summary>
#if NET48
        public ChecksumMapEntry[] ChecksumMapEntries { get; set; }
#else
        public ChecksumMapEntry?[]? ChecksumMapEntries { get; set; }
#endif

        /// <summary>
        /// Checksum entries data
        /// </summary>
#if NET48
        public ChecksumEntry[] ChecksumEntries { get; set; }
#else
        public ChecksumEntry?[]? ChecksumEntries { get; set; }
#endif
    }
}
