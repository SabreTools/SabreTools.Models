namespace SabreTools.Models.N3DS
{
    /// <summary>
    /// The exheader has two sections:
    /// - The actual exheader data, containing System Control Info (SCI) and Access Control Info (ACI);
    /// - A signed copy of NCCH HDR public key, and exheader ACI. This version of the ACI is used as limitation to the actual ACI.
    /// </summary>
    /// <see href="https://www.3dbrew.org/wiki/NCCH/Extended_Header"/>
    public sealed class NCCHExtendedHeader
    {
        /// <summary>
        /// SCI
        /// </summary>
#if NET48
        public SystemControlInfo SCI;
#else
        public SystemControlInfo? SCI;
#endif

        /// <summary>
        /// ACI
        /// </summary>
#if NET48
        public AccessControlInfo ACI;
#else
        public AccessControlInfo? ACI;
#endif

        /// <summary>
        /// AccessDesc signature (RSA-2048-SHA256)
        /// </summary>
#if NET48
        public byte[] AccessDescSignature;
#else
        public byte[]? AccessDescSignature;
#endif

        /// <summary>
        /// NCCH HDR RSA-2048 public key
        /// </summary>
#if NET48
        public byte[] NCCHHDRPublicKey;
#else
        public byte[]? NCCHHDRPublicKey;
#endif

        /// <summary>
        /// ACI (for limitation of first ACI)
        /// </summary>
#if NET48
        public AccessControlInfo ACIForLimitations;
#else
        public AccessControlInfo? ACIForLimitations;
#endif
    }
}
