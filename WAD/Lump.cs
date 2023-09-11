namespace SabreTools.Models.WAD
{
    /// <see href="https://github.com/RavuAlHemio/hllib/blob/master/HLLib/WADFile.h"/>
    public sealed class Lump
    {
        public uint Offset { get; set; }

        public uint DiskLength { get; set; }

        public uint Length { get; set; }

        public byte Type { get; set; }

        public byte Compression { get; set; }

        public byte Padding0 { get; set; }

        public byte Padding1 { get; set; }

#if NET48
        public string Name { get; set; }
#else
        public string? Name { get; set; }
#endif
    }
}
