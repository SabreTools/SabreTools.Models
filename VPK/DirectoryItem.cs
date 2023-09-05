namespace SabreTools.Models.VPK
{
    /// <see href="https://github.com/RavuAlHemio/hllib/blob/master/HLLib/VPKFile.h"/>
    public sealed class DirectoryItem
    {
#if NET48
        public string Extension;
#else
        public string? Extension;
#endif

#if NET48
        public string Path;
#else
        public string? Path;
#endif

#if NET48
        public string Name;
#else
        public string? Name;
#endif

#if NET48
        public DirectoryEntry DirectoryEntry;
#else
        public DirectoryEntry? DirectoryEntry;
#endif

#if NET48
        public byte[] PreloadData;
#else
        public byte[]? PreloadData;
#endif
    }
}
