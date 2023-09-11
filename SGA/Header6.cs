namespace SabreTools.Models.SGA
{
    /// <see href="https://github.com/RavuAlHemio/hllib/blob/master/HLLib/SGAFile.h"/>
    public sealed class Header6 : Header
    {
#if NET48
        public string Name { get; set; }
#else
        public string? Name { get; set; }
#endif

        public uint HeaderLength { get; set; }

        public uint FileDataOffset { get; set; }

        public uint Dummy0 { get; set; }
    }
}
