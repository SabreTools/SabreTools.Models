namespace SabreTools.Models.SGA
{
    /// <see href="https://github.com/RavuAlHemio/hllib/blob/master/HLLib/SGAFile.h"/>
    public abstract class Header
    {
#if NET48
        public string Signature;
#else
        public string? Signature;
#endif

        public ushort MajorVersion;

        public ushort MinorVersion;
    }
}
