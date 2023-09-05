namespace SabreTools.Models.N3DS
{
    /// <summary>
    /// A format used to store information about a title (installed title, DLC, etc.)
    /// and all its installed contents, including which contents they consist of and
    /// their SHA256 hashes. 
    /// </summary>
    /// <see href="https://www.3dbrew.org/wiki/Title_metadata"/>
    public sealed class TitleMetadata
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
        /// Padding
        /// </summary>
#if NET48
        public byte[] Padding1;
#else
        public byte[]? Padding1;
#endif

        /// <summary>
        /// Signature Issuer
        /// </summary>
#if NET48
        public string Issuer;
#else
        public string? Issuer;
#endif

        /// <summary>
        /// Version
        /// </summary>
        public byte Version;
        
        /// <summary>
        /// CaCrlVersion
        /// </summary>
        public byte CaCrlVersion;

        /// <summary>
        /// SignerCrlVersion
        /// </summary>
        public byte SignerCrlVersion;

        /// <summary>
        /// Reserved
        /// </summary>
        public byte Reserved1;

        /// <summary>
        /// System Version
        /// </summary>
        public ulong SystemVersion;

        /// <summary>
        /// TitleID
        /// </summary>
        public ulong TitleID;

        /// <summary>
        /// Title Type
        /// </summary>
        public uint TitleType;

        /// <summary>
        /// Group ID
        /// </summary>
        public ushort GroupID;

        /// <summary>
        /// Save Data Size in Little Endian (Bytes) (Also SRL Public Save Data Size)
        /// </summary>
        public uint SaveDataSize;

        /// <summary>
        /// SRL Private Save Data Size in Little Endian (Bytes)
        /// </summary>
        public uint SRLPrivateSaveDataSize;

        /// <summary>
        /// Reserved
        /// </summary>
#if NET48
        public byte[] Reserved2;
#else
        public byte[]? Reserved2;
#endif

        /// <summary>
        /// SRL Flag
        /// </summary>
        public byte SRLFlag;

        /// <summary>
        /// Reserved
        /// </summary>
#if NET48
        public byte[] Reserved3;
#else
        public byte[]? Reserved3;
#endif

        /// <summary>
        /// Access Rights
        /// </summary>
        public uint AccessRights;

        /// <summary>
        /// Title Version
        /// </summary>
        public ushort TitleVersion;

        /// <summary>
        /// Content Count (big-endian)
        /// </summary>
        public ushort ContentCount;

        /// <summary>
        /// Boot Content
        /// </summary>
        public ushort BootContent;

        /// <summary>
        /// Padding
        /// </summary>
#if NET48
        public byte[] Padding2;
#else
        public byte[]? Padding2;
#endif

        /// <summary>
        /// SHA-256 Hash of the Content Info Records
        /// </summary>
#if NET48
        public byte[] SHA256HashContentInfoRecords;
#else
        public byte[]? SHA256HashContentInfoRecords;
#endif

        /// <summary>
        /// There are 64 of these records, usually only the first is used.
        /// </summary>
#if NET48
        public ContentInfoRecord[] ContentInfoRecords;
#else
        public ContentInfoRecord[]? ContentInfoRecords;
#endif

        /// <summary>
        /// There is one of these for each content contained in this title.
        /// (Determined by "Content Count" in the TMD Header).
        /// </summary>
#if NET48
        public ContentChunkRecord[] ContentChunkRecords;
#else
        public ContentChunkRecord[]? ContentChunkRecords;
#endif

        /// <summary>
        /// Certificate chain
        /// </summary>
        /// <remarks>
        /// https://www.3dbrew.org/wiki/Title_metadata#Certificate_Chain
        /// </remarks>
#if NET48
        public Certificate[] CertificateChain;
#else
        public Certificate[]? CertificateChain;
#endif
    }
}