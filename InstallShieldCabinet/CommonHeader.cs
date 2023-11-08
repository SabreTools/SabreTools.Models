namespace SabreTools.Models.InstallShieldCabinet
{
    /// <see href="https://github.com/twogood/unshield/blob/main/lib/cabfile.h"/>
    public sealed class CommonHeader
    {
        /// <summary>
        /// "ISc("
        /// </summary>
        public string? Signature { get; set; }

        /// <summary>
        /// Encoded version
        /// </summary>
        public uint Version { get; set; }

        /// <summary>
        /// Volume information
        /// </summary>
        public uint VolumeInfo { get; set; }

        /// <summary>
        /// Offset to cabinet descriptor
        /// </summary>
        public uint DescriptorOffset { get; set; }

        /// <summary>
        /// Cabinet descriptor size
        /// </summary>
        public uint DescriptorSize { get; set; }
    }
}