namespace SabreTools.Models.XZP
{
    /// <see href="https://github.com/RavuAlHemio/hllib/blob/master/HLLib/XZPFile.h"/>
    public sealed class Footer
    {
        public uint FileLength { get; set; }

#if NET48
        public string Signature { get; set; }
#else
        public string? Signature { get; set; }
#endif
    }
}
