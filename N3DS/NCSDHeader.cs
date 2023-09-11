namespace SabreTools.Models.N3DS
{
    /// <summary>
    /// There are two known specialisations of the NCSD container format:
    /// - The CTR Cart Image (CCI) format, the 3DS' raw NAND format
    /// - CCI is the format of game ROM images.
    /// 
    /// CTR System Update (CSU) is a variant of CCI, where the only difference
    /// is in the file extension.
    /// </summary>
    /// <see href="https://www.3dbrew.org/wiki/NCSD"/>
    public sealed class NCSDHeader
    {
        #region Common to all NCSD files

        /// <summary>
        /// RSA-2048 SHA-256 signature of the NCSD header
        /// </summary>
#if NET48
        public byte[] RSA2048Signature;
#else
        public byte[]? RSA2048Signature;
#endif

        /// <summary>
        /// Magic Number 'NCSD'
        /// </summary>
#if NET48
        public string MagicNumber;
#else
        public string? MagicNumber;
#endif

        /// <summary>
        /// Size of the NCSD image, in media units (1 media unit = 0x200 bytes)
        /// </summary>
        public uint ImageSizeInMediaUnits;

        /// <summary>
        /// Media ID
        /// </summary>
#if NET48
        public byte[] MediaId;
#else
        public byte[]? MediaId;
#endif

        /// <summary>
        /// Partitions FS type (0=None, 1=Normal, 3=FIRM, 4=AGB_FIRM save)
        /// </summary>
        public FilesystemType PartitionsFSType;

        /// <summary>
        /// Partitions crypt type (each byte corresponds to a partition in the partition table)
        /// </summary>
#if NET48
        public byte[] PartitionsCryptType;
#else
        public byte[]? PartitionsCryptType;
#endif

        /// <summary>
        /// Offset & Length partition table, in media units
        /// </summary>
#if NET48
        public PartitionTableEntry[] PartitionsTable;
#else
        public PartitionTableEntry?[]? PartitionsTable;
#endif

        #endregion

        #region CTR Cart Image (CCI) Specific

        /// <summary>
        /// Exheader SHA-256 hash
        /// </summary>
#if NET48
        public byte[] ExheaderHash;
#else
        public byte[]? ExheaderHash;
#endif

        /// <summary>
        /// Additional header size
        /// </summary>
        public uint AdditionalHeaderSize;

        /// <summary>
        /// Sector zero offset
        /// </summary>
        public uint SectorZeroOffset;

        /// <summary>
        /// Partition Flags
        /// </summary>
#if NET48
        public byte[] PartitionFlags;
#else
        public byte[]? PartitionFlags;
#endif

        /// <summary>
        /// Partition ID table
        /// </summary>
#if NET48
        public ulong[] PartitionIdTable;
#else
        public ulong[]? PartitionIdTable;
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
        /// Reserved?
        /// </summary>
#if NET48
        public byte[] Reserved2;
#else
        public byte[]? Reserved2;
#endif

        /// <summary>
        /// Support for this was implemented with 9.6.0-X FIRM. Bit0=1 enables using bits 1-2, it's unknown
        /// what these two bits are actually used for(the value of these two bits get compared with some other
        /// value during NCSD verification/loading). This appears to enable a new, likely hardware-based,
        /// antipiracy check on cartridges.
        /// </summary>
        public byte FirmUpdateByte1;

        /// <summary>
        /// Support for this was implemented with 9.6.0-X FIRM, see below regarding save crypto.
        /// </summary>
        public byte FirmUpdateByte2;

        #endregion

        #region Raw NAND Format Specific

        /// <summary>
        /// Unknown
        /// </summary>
#if NET48
        public byte[] Unknown;
#else
        public byte[]? Unknown;
#endif

        /// <summary>
        /// Encrypted MBR partition-table, for the TWL partitions(key-data used for this keyslot is console-unique).
        /// </summary>
#if NET48
        public byte[] EncryptedMBR;
#else
        public byte[]? EncryptedMBR;
#endif

        #endregion
    }
}
