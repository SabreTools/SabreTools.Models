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
        public SignatureType SignatureType;

        /// <summary>
        /// Signature size
        /// </summary>
        public ushort SignatureSize;

        /// <summary>
        /// Padding size
        /// </summary>
        public byte PaddingSize;

        /// <summary>
        /// Signature
        /// </summary>
#if NET48
        public byte[] Signature;
#else
        public byte[]? Signature;
#endif

        /// <summary>
        /// Padding to align next data to 0x40 bytes
        /// </summary>
#if NET48
        public byte[] Padding;
#else
        public byte[]? Padding;
#endif

        /// <summary>
        /// Issuer
        /// </summary>
#if NET48
        public string Issuer;
#else
        public string? Issuer;
#endif

        /// <summary>
        /// Key Type
        /// </summary>
        public PublicKeyType KeyType;

        /// <summary>
        /// Name
        /// </summary>
#if NET48
        public string Name;
#else
        public string? Name;
#endif

        /// <summary>
        /// Expiration time as UNIX Timestamp, used at least for CTCert
        /// </summary>
        public uint ExpirationTime;

        // This contains the Public Key (i.e. Modulus & Public Exponent)
        #region RSA-4096 and RSA-2048

        /// <summary>
        /// Modulus
        /// </summary>
#if NET48
        public byte[] RSAModulus;
#else
        public byte[]? RSAModulus;
#endif

        /// <summary>
        /// Public Exponent
        /// </summary>
        public uint RSAPublicExponent;

        /// <summary>
        /// Padding
        /// </summary>
#if NET48
        public byte[] RSAPadding;
#else
        public byte[]? RSAPadding;
#endif

        #endregion

        // This contains the ECC public key, and is as follows:
        #region ECC

        /// <summary>
        /// Public Key
        /// </summary>
#if NET48
        public byte[] ECCPublicKey;
#else
        public byte[]? ECCPublicKey;
#endif

        /// <summary>
        /// Padding
        /// </summary>
#if NET48
        public byte[] ECCPadding;
#else
        public byte[]? ECCPadding;
#endif

        #endregion
    }
}
