namespace SabreTools.Models.VPK
{
    /// <see href="https://github.com/RavuAlHemio/hllib/blob/master/HLLib/VPKFile.h"/>
    public sealed class Header
    {
        /// <summary>
        /// Always 0x55aa1234.
        /// </summary>
        public uint Signature { get; set; }

        public uint Version { get; set; }

        public uint DirectoryLength { get; set; }
    }
}
