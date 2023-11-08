namespace SabreTools.Models.N3DS
{
    /// <summary>
    /// The exheader has two sections:
    /// - The actual exheader data, containing System Control Info (SCI) and Access Control Info (ACI) { get; set; }
    /// - A signed copy of NCCH HDR public key, and exheader ACI. This version of the ACI is used as limitation to the actual ACI.
    /// </summary>
    /// <see href="https://www.3dbrew.org/wiki/NCCH/Extended_Header"/>
    public sealed class NCCHExtendedHeader
    {
        /// <summary>
        /// SCI
        /// </summary>
        public SystemControlInfo? SCI { get; set; }

        /// <summary>
        /// ACI
        /// </summary>
        public AccessControlInfo? ACI { get; set; }

        /// <summary>
        /// AccessDesc signature (RSA-2048-SHA256)
        /// </summary>
        public byte[]? AccessDescSignature { get; set; }

        /// <summary>
        /// NCCH HDR RSA-2048 public key
        /// </summary>
        public byte[]? NCCHHDRPublicKey { get; set; }

        /// <summary>
        /// ACI (for limitation of first ACI)
        /// </summary>
        public AccessControlInfo? ACIForLimitations { get; set; }
    }
}
