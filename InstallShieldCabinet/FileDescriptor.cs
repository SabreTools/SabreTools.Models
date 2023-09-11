namespace SabreTools.Models.InstallShieldCabinet
{
    /// <see href="https://github.com/twogood/unshield/blob/main/lib/cabfile.h"/>
    public sealed class FileDescriptor
    {
        /// <summary>
        /// Offset to the file descriptor name
        /// </summary>
        public uint NameOffset { get; set; }

        /// <summary>
        /// File descriptor name
        /// </summary>
#if NET48
        public string Name { get; set; }
#else
        public string? Name { get; set; }
#endif

        /// <summary>
        /// Directory index
        /// </summary>
        public uint DirectoryIndex { get; set; }

        /// <summary>
        /// File flags
        /// </summary>
        public FileFlags Flags { get; set; }

        /// <summary>
        /// Size of the entry when expanded
        /// </summary>
        public ulong ExpandedSize { get; set; }

        /// <summary>
        /// Size of the entry when compressed
        /// </summary>
        public ulong CompressedSize { get; set; }

        /// <summary>
        /// Offset to the entry data
        /// </summary>
        public ulong DataOffset { get; set; }

        /// <summary>
        /// MD5 of the entry data
        /// </summary>
#if NET48
        public byte[] MD5 { get; set; }
#else
        public byte[]? MD5 { get; set; }
#endif

        /// <summary>
        /// Volume number
        /// </summary>
        public ushort Volume { get; set; }

        /// <summary>
        /// Link previous
        /// </summary>
        public uint LinkPrevious { get; set; }

        /// <summary>
        /// Link next
        /// </summary>
        public uint LinkNext { get; set; }

        /// <summary>
        /// Link flags
        /// </summary>
        public LinkFlags LinkFlags { get; set; }
    }
}