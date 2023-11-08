namespace SabreTools.Models.XZP
{
    /// <see href="https://github.com/RavuAlHemio/hllib/blob/master/HLLib/XZPFile.h"/>
    public sealed class Header
    {
        public string? Signature { get; set; }

        public uint Version { get; set; }

        public uint PreloadDirectoryEntryCount { get; set; }

        public uint DirectoryEntryCount { get; set; }

        public uint PreloadBytes { get; set; }

        public uint HeaderLength { get; set; }

        public uint DirectoryItemCount { get; set; }

        public uint DirectoryItemOffset { get; set; }

        public uint DirectoryItemLength { get; set; }
    }
}
