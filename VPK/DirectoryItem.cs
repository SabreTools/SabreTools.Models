namespace SabreTools.Models.VPK
{
    /// <see href="https://github.com/RavuAlHemio/hllib/blob/master/HLLib/VPKFile.h"/>
    public sealed class DirectoryItem
    {
#if NET48
        public string Extension { get; set; }
#else
        public string? Extension { get; set; }
#endif

#if NET48
        public string Path { get; set; }
#else
        public string? Path { get; set; }
#endif

#if NET48
        public string Name { get; set; }
#else
        public string? Name { get; set; }
#endif

#if NET48
        public DirectoryEntry DirectoryEntry { get; set; }
#else
        public DirectoryEntry? DirectoryEntry { get; set; }
#endif

#if NET48
        public byte[] PreloadData { get; set; }
#else
        public byte[]? PreloadData { get; set; }
#endif
    }
}
