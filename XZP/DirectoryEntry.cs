namespace SabreTools.Models.XZP
{
    /// <see href="https://github.com/RavuAlHemio/hllib/blob/master/HLLib/XZPFile.h"/>
    public sealed class DirectoryEntry
    {
        public uint FileNameCRC { get; set; }

        public uint EntryLength { get; set; }

        public uint EntryOffset { get; set; }
    }
}
