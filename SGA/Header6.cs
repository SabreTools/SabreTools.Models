namespace SabreTools.Models.SGA
{
    /// <see href="https://github.com/RavuAlHemio/hllib/blob/master/HLLib/SGAFile.h"/>
    public sealed class Header6 : Header
    {
#if NET48
        public string Name;
#else
        public string? Name;
#endif

        public uint HeaderLength;

        public uint FileDataOffset;

        public uint Dummy0;
    }
}
