using System.Collections.Generic;

namespace SabreTools.Models.GCF
{
    /// <summary>
    /// Half-Life Game Cache File
    /// </summary>
    /// <see href="https://github.com/RavuAlHemio/hllib/blob/master/HLLib/GCFFile.h"/>
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
        /// Block entry header data
        /// </summary>
#if NET48
        public BlockEntryHeader BlockEntryHeader { get; set; }
#else
        public BlockEntryHeader? BlockEntryHeader { get; set; }
#endif

        /// <summary>
        /// Block entries data
        /// </summary>
#if NET48
        public BlockEntry[] BlockEntries { get; set; }
#else
        public BlockEntry?[]? BlockEntries { get; set; }
#endif

        /// <summary>
        /// Fragmentation map header data
        /// </summary>
#if NET48
        public FragmentationMapHeader FragmentationMapHeader { get; set; }
#else
        public FragmentationMapHeader? FragmentationMapHeader { get; set; }
#endif

        /// <summary>
        /// Fragmentation map data
        /// </summary>
#if NET48
        public FragmentationMap[] FragmentationMaps { get; set; }
#else
        public FragmentationMap?[]? FragmentationMaps { get; set; }
#endif

        /// <summary>
        /// Block entry map header data
        /// </summary>
        /// <remarks>Part of version 5 but not version 6.</remarks>
#if NET48
        public BlockEntryMapHeader BlockEntryMapHeader { get; set; }
#else
        public BlockEntryMapHeader? BlockEntryMapHeader { get; set; }
#endif

        /// <summary>
        /// Block entry map data
        /// </summary>
        /// <remarks>Part of version 5 but not version 6.</remarks>
#if NET48
        public BlockEntryMap[] BlockEntryMaps { get; set; }
#else
        public BlockEntryMap?[]? BlockEntryMaps { get; set; }
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
        /// Directory map header data
        /// </summary>
#if NET48
        public DirectoryMapHeader DirectoryMapHeader { get; set; }
#else
        public DirectoryMapHeader? DirectoryMapHeader { get; set; }
#endif

        /// <summary>
        /// Directory map entries data
        /// </summary>
#if NET48
        public DirectoryMapEntry[] DirectoryMapEntries { get; set; }
#else
        public DirectoryMapEntry?[]? DirectoryMapEntries { get; set; }
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

        /// <summary>
        /// Data block header data
        /// </summary>
#if NET48
        public DataBlockHeader DataBlockHeader { get; set; }
#else
        public DataBlockHeader? DataBlockHeader { get; set; }
#endif
    }
}