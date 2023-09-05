namespace SabreTools.Models.XZP
{
    /// <see href="https://github.com/RavuAlHemio/hllib/blob/master/HLLib/XZPFile.h"/>
    public sealed class Footer
    {
        public uint FileLength;

#if NET48
        public string Signature;
#else
        public string? Signature;
#endif
    }
}
