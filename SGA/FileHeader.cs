namespace SabreTools.Models.SGA
{
    /// <see href="https://github.com/RavuAlHemio/hllib/blob/master/HLLib/SGAFile.h"/>
    public sealed class FileHeader
    {
#if NET48
        public string Name { get; set; }
#else
        public string? Name { get; set; }
#endif

        public uint CRC32 { get; set; }
    }
}
