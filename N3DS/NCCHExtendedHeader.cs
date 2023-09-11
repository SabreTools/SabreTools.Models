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
#if NET48
        public SystemControlInfo SCI { get; set; }
#else
        public SystemControlInfo? SCI { get; set; }
#endif

        /// <summary>
        /// ACI
        /// </summary>
#if NET48
        public AccessControlInfo ACI { get; set; }
#else
        public AccessControlInfo? ACI { get; set; }
#endif

        /// <summary>
        /// AccessDesc signature (RSA-2048-SHA256)
        /// </summary>
#if NET48
        public byte[] AccessDescSignature { get; set; }
#else
        public byte[]? AccessDescSignature { get; set; }
#endif

        /// <summary>
        /// NCCH HDR RSA-2048 public key
        /// </summary>
#if NET48
        public byte[] NCCHHDRPublicKey { get; set; }
#else
        public byte[]? NCCHHDRPublicKey { get; set; }
#endif

        /// <summary>
        /// ACI (for limitation of first ACI)
        /// </summary>
#if NET48
        public AccessControlInfo ACIForLimitations { get; set; }
#else
        public AccessControlInfo? ACIForLimitations { get; set; }
#endif
    }
}
