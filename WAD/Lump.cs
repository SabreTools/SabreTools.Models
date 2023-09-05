namespace SabreTools.Models.WAD
{
    /// <see href="https://github.com/RavuAlHemio/hllib/blob/master/HLLib/WADFile.h"/>
    public sealed class Lump
    {
        public uint Offset;

        public uint DiskLength;

        public uint Length;

        public byte Type;

        public byte Compression;

        public byte Padding0;

        public byte Padding1;

#if NET48
        public string Name;
#else
        public string? Name;
#endif
    }
}
