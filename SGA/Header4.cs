namespace SabreTools.Models.SGA
{
    /// <see href="https://github.com/RavuAlHemio/hllib/blob/master/HLLib/SGAFile.h"/>
    public sealed class Header4 : Header
    {
#if NET48
        public byte[] FileMD5 { get; set; }
#else
        public byte[]? FileMD5 { get; set; }
#endif

#if NET48
        public string Name { get; set; }
#else
        public string? Name { get; set; }
#endif

#if NET48
        public byte[] HeaderMD5 { get; set; }
#else
        public byte[]? HeaderMD5 { get; set; }
#endif

        public uint HeaderLength { get; set; }

        public uint FileDataOffset { get; set; }

        public uint Dummy0 { get; set; }
    }
}
