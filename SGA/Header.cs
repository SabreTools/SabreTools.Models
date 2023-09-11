namespace SabreTools.Models.SGA
{
    /// <see href="https://github.com/RavuAlHemio/hllib/blob/master/HLLib/SGAFile.h"/>
    public abstract class Header
    {
#if NET48
        public string Signature { get; set; }
#else
        public string? Signature { get; set; }
#endif

        public ushort MajorVersion { get; set; }

        public ushort MinorVersion { get; set; }
    }
}
