namespace SabreTools.Models.XZP
{
    /// <see href="https://github.com/RavuAlHemio/hllib/blob/master/HLLib/XZPFile.h"/>
    public sealed class Footer
    {
        public uint FileLength { get; set; }

        public string? Signature { get; set; }
    }
}
