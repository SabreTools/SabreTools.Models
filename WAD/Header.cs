namespace SabreTools.Models.WAD
{
    /// <see href="https://github.com/RavuAlHemio/hllib/blob/master/HLLib/WADFile.h"/>
    public sealed class Header
    {
#if NET48
        public string Signature;
#else
        public string? Signature;
#endif
        
        public uint LumpCount;
        
        public uint LumpOffset;
    }
}
