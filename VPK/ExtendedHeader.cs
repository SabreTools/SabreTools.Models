namespace SabreTools.Models.VPK
{
    /// <summary>
    /// Added in version 2.
    /// </summary>
    /// <see href="https://github.com/RavuAlHemio/hllib/blob/master/HLLib/VPKFile.h"/>
    public sealed class ExtendedHeader
    {
        /// <summary>
        /// Reserved
        /// </summary>
        public uint Dummy0 { get; set; }

        /// <summary>
        /// Archive hash length
        /// </summary>
        public uint ArchiveHashLength { get; set; }

        /// <summary>
        /// Looks like some more MD5 hashes.
        /// </summary>
        public uint ExtraLength { get; set; }

        /// <summary>
        /// Reserved
        /// </summary>
        public uint Dummy1 { get; set; }
    }
}
