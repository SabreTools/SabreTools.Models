namespace SabreTools.Models.N3DS
{
    /// <summary>
    /// A format used to store an encrypted titlekey (using 128-Bit AES-CBC).
    /// With 3DS, the Ticket format was updated (now v1) from Wii/DSi format (v0).
    /// </summary>
    /// <see href="https://www.3dbrew.org/wiki/Ticket"/>
    public sealed class Ticket
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
        /// Padding
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
        /// ECC PublicKey
        /// </summary>
#if NET48
        public byte[] ECCPublicKey { get; set; }
#else
        public byte[]? ECCPublicKey { get; set; }
#endif

        /// <summary>
        /// Version (For 3DS this is always 1)
        /// </summary>
        public byte Version { get; set; }

        /// <summary>
        /// CaCrlVersion
        /// </summary>
        public byte CaCrlVersion { get; set; }

        /// <summary>
        /// SignerCrlVersion
        /// </summary>
        public byte SignerCrlVersion { get; set; }

        /// <summary>
        /// TitleKey (normal-key encrypted using one of the common keyYs; see below)
        /// </summary>
        /// <remarks>
        /// The titlekey is decrypted by using the AES engine with the ticket common-key keyslot.
        /// The keyY is selected through an index (ticket offset 0xB1) into a plaintext array
        /// of 6 keys ("common keyYs") stored in the data section of Process9. AES-CBC mode is used
        /// where the IV is the big-endian titleID. Note that on a retail unit index0 is a retail keyY,
        /// while on a dev-unit index0 is the dev common-key which is a normal-key.
        /// (On retail for these keyYs, the hardware key-scrambler is used)
        /// 
        /// The titlekey is used to decrypt content downloaded from the CDN using 128-bit AES-CBC with
        /// the content index (as big endian u16, padded with trailing zeroes) as the IV.
        /// </remarks>
#if NET48
        public byte[] TitleKey { get; set; }
#else
        public byte[]? TitleKey { get; set; }
#endif

        /// <summary>
        /// Reserved
        /// </summary>
        public byte Reserved1 { get; set; }

        /// <summary>
        /// TicketID
        /// </summary>
        public ulong TicketID { get; set; }

        /// <summary>
        /// ConsoleID
        /// </summary>
        public uint ConsoleID { get; set; }

        /// <summary>
        /// TitleID
        /// </summary>
        public ulong TitleID { get; set; }

        /// <summary>
        /// Reserved
        /// </summary>
#if NET48
        public byte[] Reserved2 { get; set; }
#else
        public byte[]? Reserved2 { get; set; }
#endif

        /// <summary>
        /// Ticket title version
        /// </summary>
        /// <remarks>
        /// The Ticket Title Version is generally the same as the title version stored in the
        /// Title Metadata. Although it doesn't have to match the TMD version to be valid.
        /// </remarks>
        public ushort TicketTitleVersion { get; set; }

        /// <summary>
        /// Reserved
        /// </summary>
#if NET48
        public byte[] Reserved3 { get; set; }
#else
        public byte[]? Reserved3 { get; set; }
#endif

        /// <summary>
        /// License Type
        /// </summary>
        public byte LicenseType { get; set; }

        /// <summary>
        /// Index to the common keyY used for this ticket, usually 0x1 for retail system titles
        /// </summary>
        public byte CommonKeyYIndex { get; set; }

        /// <summary>
        /// Reserved
        /// </summary>
#if NET48
        public byte[] Reserved4 { get; set; }
#else
        public byte[]? Reserved4 { get; set; }
#endif

        /// <summary>
        /// eShop Account ID?
        /// </summary>
        public uint eShopAccountID { get; set; }

        /// <summary>
        /// Reserved
        /// </summary>
        public byte Reserved5 { get; set; }

        /// <summary>
        /// Audit
        /// </summary>
        public byte Audit { get; set; }

        /// <summary>
        /// Reserved
        /// </summary>
#if NET48
        public byte[] Reserved6 { get; set; }
#else
        public byte[]? Reserved6 { get; set; }
#endif

        /// <summary>
        /// Limits
        /// </summary>
        /// <remarks>
        /// In demos, the first u32 in the "Limits" section is 0x4, then the second u32 is the max-playcount.
        /// </remarks>
#if NET48
        public uint[] Limits { get; set; }
#else
        public uint[]? Limits { get; set; }
#endif

        /// <summary>
        /// The Content Index of a ticket has its own size defined within itself,
        /// with seemingly a minimal of 20 bytes, the second u32 in big endian defines
        /// the full value of X.
        /// </summary>
        public uint ContentIndexSize { get; set; }

        /// <summary>
        /// Content Index
        /// </summary>
#if NET48
        public byte[] ContentIndex { get; set; }
#else
        public byte[]? ContentIndex { get; set; }
#endif

        /// <summary>
        /// Certificate chain
        /// </summary>
        /// <remarks>
        /// https://www.3dbrew.org/wiki/Ticket#Certificate_Chain
        /// </remarks>
#if NET48
        public Certificate[] CertificateChain { get; set; }
#else
        public Certificate?[]? CertificateChain { get; set; }
#endif
    }
}
