namespace SabreTools.Models.N3DS
{
    /// <summary>
    /// Certificates contain cryptography information for verifying Signatures.
    /// These certificates are also signed. The parent/child relationship between
    /// certificates, makes all the certificates effectively signed by 'Root',
    /// the public key for which is stored in NATIVE_FIRM.
    /// </summary>
    /// <see href="https://www.3dbrew.org/wiki/Certificates"/>
    public sealed class Certificate
    {
        /// <summary>
        /// Signature Type
        /// </summary>
        public SignatureType SignatureType { get; set; }

        /// <summary>
        /// Signature size
        /// </summary>
        public ushort SignatureSize { get; set; }

        /// <summary>
        /// Padding size
        /// </summary>
        public byte PaddingSize { get; set; }

        /// <summary>
        /// Signature
        /// </summary>
#if NET48
        public byte[] Signature { get; set; }
#else
        public byte[]? Signature { get; set; }
#endif

        /// <summary>
        /// Padding to align next data to 0x40 bytes
        /// </summary>
#if NET48
        public byte[] Padding { get; set; }
#else
        public byte[]? Padding { get; set; }
#endif

        /// <summary>
        /// Issuer
        /// </summary>
#if NET48
        public string Issuer { get; set; }
#else
        public string? Issuer { get; set; }
#endif

        /// <summary>
        /// Key Type
        /// </summary>
        public PublicKeyType KeyType { get; set; }

        /// <summary>
        /// Name
        /// </summary>
#if NET48
        public string Name { get; set; }
#else
        public string? Name { get; set; }
#endif

        /// <summary>
        /// Expiration time as UNIX Timestamp, used at least for CTCert
        /// </summary>
        public uint ExpirationTime { get; set; }

        // This contains the Public Key (i.e. Modulus & Public Exponent)
        #region RSA-4096 and RSA-2048

        /// <summary>
        /// Modulus
        /// </summary>
#if NET48
        public byte[] RSAModulus { get; set; }
#else
        public byte[]? RSAModulus { get; set; }
#endif

        /// <summary>
        /// Public Exponent
        /// </summary>
        public uint RSAPublicExponent { get; set; }

        /// <summary>
        /// Padding
        /// </summary>
#if NET48
        public byte[] RSAPadding { get; set; }
#else
        public byte[]? RSAPadding { get; set; }
#endif

        #endregion

        // This contains the ECC public key, and is as follows:
        #region ECC

        /// <summary>
        /// Public Key
        /// </summary>
#if NET48
        public byte[] ECCPublicKey { get; set; }
#else
        public byte[]? ECCPublicKey { get; set; }
#endif

        /// <summary>
        /// Padding
        /// </summary>
#if NET48
        public byte[] ECCPadding { get; set; }
#else
        public byte[]? ECCPadding { get; set; }
#endif

        #endregion
    }
}
