namespace SabreTools.Models.InstallShieldArchiveV3
{
    /// <see href="https://github.com/wfr/unshieldv3/blob/master/ISArchiveV3.h"/>
    public class File
    {
        public byte VolumeEnd { get; set; }

        public ushort Index { get; set; }

        public uint UncompressedSize { get; set; }

        public uint CompressedSize { get; set; }

        public uint Offset { get; set; }

        public uint DateTime { get; set; }

        public uint Reserved0 { get; set; }

        public ushort ChunkSize { get; set; }

        public Attributes Attrib { get; set; }

        public byte IsSplit { get; set; }

        public byte Reserved1 { get; set; }

        public byte VolumeStart { get; set; }

        public string? Name { get; set; }
    }
}