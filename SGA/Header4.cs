namespace SabreTools.Models.SGA
{
    /// <see href="https://github.com/RavuAlHemio/hllib/blob/master/HLLib/SGAFile.h"/>
    public sealed class Header4 : Header
    {
#if NET48
        public byte[] FileMD5;
#else
        public byte[]? FileMD5;
#endif

#if NET48
        public string Name;
#else
        public string? Name;
#endif

#if NET48
        public byte[] HeaderMD5;
#else
        public byte[]? HeaderMD5;
#endif

        public uint HeaderLength;

        public uint FileDataOffset;

        public uint Dummy0;
    }
}
