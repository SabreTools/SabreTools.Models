namespace SabreTools.Models.N3DS
{
    /// <see href="https://www.3dbrew.org/wiki/NCCH#NCCH_Header"/>
    public sealed class NCCHHeader
    {
        /// <summary>
        /// RSA-2048 signature of the NCCH header, using SHA-256.
        /// </summary>
#if NET48
        public byte[] RSA2048Signature;
#else
        public byte[]? RSA2048Signature;
#endif

        /// <summary>
        /// Magic ID, always 'NCCH'
        /// </summary>
#if NET48
        public string MagicID;
#else
        public string? MagicID;
#endif

        /// <summary>
        /// Content size, in media units (1 media unit = 0x200 bytes)
        /// </summary>
        public uint ContentSizeInMediaUnits;

        /// <summary>
        /// Partition ID
        /// </summary>
        public ulong PartitionId;

        /// <summary>
        /// Maker code
        /// </summary>
        public ushort MakerCode;

        /// <summary>
        /// Version
        /// </summary>
        public ushort Version;

        /// <summary>
        /// When ncchflag[7] = 0x20 starting with FIRM 9.6.0-X, this is compared with the first output u32 from a
        /// SHA256 hash. The data used for that hash is 0x18-bytes: [0x10-long title-unique content lock seed]
        /// [programID from NCCH + 0x118]. This hash is only used for verification of the content lock seed, and
        /// is not the actual keyY.
        /// </summary>
        public uint VerificationHash;

        /// <summary>
        /// Program ID
        /// </summary>
#if NET48
        public byte[] ProgramId;
#else
        public byte[]? ProgramId;
#endif

        /// <summary>
        /// Reserved
        /// </summary>
#if NET48
        public byte[] Reserved1;
#else
        public byte[]? Reserved1;
#endif

        /// <summary>
        /// Logo Region SHA-256 hash. (For applications built with SDK 5+) (Supported from firmware: 5.0.0-11)
        /// </summary>
#if NET48
        public byte[] LogoRegionHash;
#else
        public byte[]? LogoRegionHash;
#endif

        /// <summary>
        /// Product code
        /// </summary>
#if NET48
        public string ProductCode;
#else
        public string? ProductCode;
#endif

        /// <summary>
        /// Extended header SHA-256 hash (SHA256 of 2x Alignment Size, beginning at 0x0 of ExHeader)
        /// </summary>
#if NET48
        public byte[] ExtendedHeaderHash;
#else
        public byte[]? ExtendedHeaderHash;
#endif

        /// <summary>
        /// Extended header size, in bytes
        /// </summary>
        public uint ExtendedHeaderSizeInBytes;

        /// <summary>
        /// Reserved
        /// </summary>
#if NET48
        public byte[] Reserved2;
#else
        public byte[]? Reserved2;
#endif

        /// <summary>
        /// Flags
        /// </summary>
#if NET48
        public NCCHHeaderFlags Flags;
#else
        public NCCHHeaderFlags? Flags;
#endif

        /// <summary>
        /// Plain region offset, in media units
        /// </summary>
        public uint PlainRegionOffsetInMediaUnits;

        /// <summary>
        /// Plain region size, in media units
        /// </summary>
        public uint PlainRegionSizeInMediaUnits;

        /// <summary>
        /// Logo Region offset, in media units (For applications built with SDK 5+) (Supported from firmware: 5.0.0-11)
        /// </summary>
        public uint LogoRegionOffsetInMediaUnits;

        /// <summary>
        /// Logo Region size, in media units (For applications built with SDK 5+) (Supported from firmware: 5.0.0-11)
        /// </summary>
        public uint LogoRegionSizeInMediaUnits;

        /// <summary>
        /// ExeFS offset, in media units
        /// </summary>
        public uint ExeFSOffsetInMediaUnits;

        /// <summary>
        /// ExeFS size, in media units
        /// </summary>
        public uint ExeFSSizeInMediaUnits;

        /// <summary>
        /// ExeFS hash region size, in media units
        /// </summary>
        public uint ExeFSHashRegionSizeInMediaUnits;

        /// <summary>
        /// Reserved
        /// </summary>
#if NET48
        public byte[] Reserved3;
#else
        public byte[]? Reserved3;
#endif

        /// <summary>
        /// RomFS offset, in media units
        /// </summary>
        public uint RomFSOffsetInMediaUnits;

        /// <summary>
        /// RomFS size, in media units
        /// </summary>
        public uint RomFSSizeInMediaUnits;

        /// <summary>
        /// RomFS hash region size, in media units
        /// </summary>
        public uint RomFSHashRegionSizeInMediaUnits;

        /// <summary>
        /// Reserved
        /// </summary>
#if NET48
        public byte[] Reserved4;
#else
        public byte[]? Reserved4;
#endif

        /// <summary>
        /// ExeFS superblock SHA-256 hash - (SHA-256 hash, starting at 0x0 of the ExeFS over the number of
        /// media units specified in the ExeFS hash region size)
        /// </summary>
#if NET48
        public byte[] ExeFSSuperblockHash;
#else
        public byte[]? ExeFSSuperblockHash;
#endif

        /// <summary>
        /// RomFS superblock SHA-256 hash - (SHA-256 hash, starting at 0x0 of the RomFS over the number
        /// of media units specified in the RomFS hash region size)
        /// </summary>
#if NET48
        public byte[] RomFSSuperblockHash;
#else
        public byte[]? RomFSSuperblockHash;
#endif
    }
}
