namespace SabreTools.Models.XZP
{
    /// <see href="https://github.com/RavuAlHemio/hllib/blob/master/HLLib/XZPFile.h"/>
    public sealed class Header
    {
#if NET48
        public string Signature;
#else
        public string? Signature;
#endif

        public uint Version;

        public uint PreloadDirectoryEntryCount;

        public uint DirectoryEntryCount;

        public uint PreloadBytes;

        public uint HeaderLength;

        public uint DirectoryItemCount;

        public uint DirectoryItemOffset;

        public uint DirectoryItemLength;
    }
}
