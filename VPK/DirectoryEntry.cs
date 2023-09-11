namespace SabreTools.Models.VPK
{
    /// <see href="https://github.com/RavuAlHemio/hllib/blob/master/HLLib/VPKFile.h"/>
    public sealed class DirectoryEntry
    {
        public uint CRC { get; set; }

        public ushort PreloadBytes { get; set; }

        public ushort ArchiveIndex { get; set; }

        public uint EntryOffset { get; set; }

        public uint EntryLength { get; set; }

        /// <summary>
        /// Always 0xffff.
        /// </summary>
        public ushort Dummy0 { get; set; }
    }
}
