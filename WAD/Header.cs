namespace SabreTools.Models.WAD
{
    /// <see href="https://github.com/RavuAlHemio/hllib/blob/master/HLLib/WADFile.h"/>
    public sealed class Header
    {
        public string? Signature { get; set; }
        
        public uint LumpCount { get; set; }
        
        public uint LumpOffset { get; set; }
    }
}
