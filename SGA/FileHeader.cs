namespace SabreTools.Models.SGA
{
    /// <see href="https://github.com/RavuAlHemio/hllib/blob/master/HLLib/SGAFile.h"/>
    public sealed class FileHeader
    {
#if NET48
        public string Name;
#else
        public string? Name;
#endif

        public uint CRC32;
    }
}
