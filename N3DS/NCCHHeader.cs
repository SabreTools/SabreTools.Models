namespace SabreTools.Models.N3DS
{
    /// <see href="https://www.3dbrew.org/wiki/NCCH#NCCH_Header"/>
    public sealed class NCCHHeader
    {
        /// <summary>
        /// RSA-2048 signature of the NCCH header, using SHA-256.
        /// </summary>
        public byte[]? RSA2048Signature { get; set; }

        /// <summary>
        /// Magic ID, always 'NCCH'
        /// </summary>
        public string? MagicID { get; set; }

        /// <summary>
        /// Content size, in media units (1 media unit = 0x200 bytes)
        /// </summary>
        public uint ContentSizeInMediaUnits { get; set; }

        /// <summary>
        /// Partition ID
        /// </summary>
        public ulong PartitionId { get; set; }

        /// <summary>
        /// Maker code
        /// </summary>
        public ushort MakerCode { get; set; }

        /// <summary>
        /// Version
        /// </summary>
        public ushort Version { get; set; }

        /// <summary>
        /// When ncchflag[7] = 0x20 starting with FIRM 9.6.0-X, this is compared with the first output u32 from a
        /// SHA256 hash. The data used for that hash is 0x18-bytes: [0x10-long title-unique content lock seed]
        /// [programID from NCCH + 0x118]. This hash is only used for verification of the content lock seed, and
        /// is not the actual keyY.
        /// </summary>
        public uint VerificationHash { get; set; }

        /// <summary>
        /// Program ID
        /// </summary>
        public byte[]? ProgramId { get; set; }

        /// <summary>
        /// Reserved
        /// </summary>
        public byte[]? Reserved1 { get; set; }

        /// <summary>
        /// Logo Region SHA-256 hash. (For applications built with SDK 5+) (Supported from firmware: 5.0.0-11)
        /// </summary>
        public byte[]? LogoRegionHash { get; set; }

        /// <summary>
        /// Product code
        /// </summary>
        public string? ProductCode { get; set; }

        /// <summary>
        /// Extended header SHA-256 hash (SHA256 of 2x Alignment Size, beginning at 0x0 of ExHeader)
        /// </summary>
        public byte[]? ExtendedHeaderHash { get; set; }

        /// <summary>
        /// Extended header size, in bytes
        /// </summary>
        public uint ExtendedHeaderSizeInBytes { get; set; }

        /// <summary>
        /// Reserved
        /// </summary>
        public byte[]? Reserved2 { get; set; }

        /// <summary>
        /// Flags
        /// </summary>
        public NCCHHeaderFlags? Flags { get; set; }

        /// <summary>
        /// Plain region offset, in media units
        /// </summary>
        public uint PlainRegionOffsetInMediaUnits { get; set; }

        /// <summary>
        /// Plain region size, in media units
        /// </summary>
        public uint PlainRegionSizeInMediaUnits { get; set; }

        /// <summary>
        /// Logo Region offset, in media units (For applications built with SDK 5+) (Supported from firmware: 5.0.0-11)
        /// </summary>
        public uint LogoRegionOffsetInMediaUnits { get; set; }

        /// <summary>
        /// Logo Region size, in media units (For applications built with SDK 5+) (Supported from firmware: 5.0.0-11)
        /// </summary>
        public uint LogoRegionSizeInMediaUnits { get; set; }

        /// <summary>
        /// ExeFS offset, in media units
        /// </summary>
        public uint ExeFSOffsetInMediaUnits { get; set; }

        /// <summary>
        /// ExeFS size, in media units
        /// </summary>
        public uint ExeFSSizeInMediaUnits { get; set; }

        /// <summary>
        /// ExeFS hash region size, in media units
        /// </summary>
        public uint ExeFSHashRegionSizeInMediaUnits { get; set; }

        /// <summary>
        /// Reserved
        /// </summary>
        public byte[]? Reserved3 { get; set; }

        /// <summary>
        /// RomFS offset, in media units
        /// </summary>
        public uint RomFSOffsetInMediaUnits { get; set; }

        /// <summary>
        /// RomFS size, in media units
        /// </summary>
        public uint RomFSSizeInMediaUnits { get; set; }

        /// <summary>
        /// RomFS hash region size, in media units
        /// </summary>
        public uint RomFSHashRegionSizeInMediaUnits { get; set; }

        /// <summary>
        /// Reserved
        /// </summary>
        public byte[]? Reserved4 { get; set; }

        /// <summary>
        /// ExeFS superblock SHA-256 hash - (SHA-256 hash, starting at 0x0 of the ExeFS over the number of
        /// media units specified in the ExeFS hash region size)
        /// </summary>
        public byte[]? ExeFSSuperblockHash { get; set; }

        /// <summary>
        /// RomFS superblock SHA-256 hash - (SHA-256 hash, starting at 0x0 of the RomFS over the number
        /// of media units specified in the RomFS hash region size)
        /// </summary>
        public byte[]? RomFSSuperblockHash { get; set; }
    }
}
