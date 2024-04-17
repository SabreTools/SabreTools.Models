using System;

/// <see href="https://pkware.cachefly.net/webdocs/casestudies/APPNOTE.TXT"/> 
namespace SabreTools.Models.PKZIP
{
    public enum CompressionMethod : ushort
    {
        /// <summary>
        /// The file is stored (no compression)
        /// </summary>
        Stored = 0,

        /// <summary>
        /// The file is Shrunk
        /// </summary>
        Shrunk = 1,

        /// <summary>
        /// The file is Reduced with compression factor 1
        /// </summary>
        ReducedCompressionFactor1 = 2,

        /// <summary>
        /// The file is Reduced with compression factor 2
        /// </summary>
        ReducedCompressionFactor2 = 3,

        /// <summary>
        /// The file is Reduced with compression factor 3
        /// </summary>
        ReducedCompressionFactor3 = 4,

        /// <summary>
        /// The file is Reduced with compression factor 4
        /// </summary>
        ReducedCompressionFactor4 = 5,

        /// <summary>
        /// The file is Imploded
        /// </summary>
        Implode = 6,

        /// <summary>
        /// Reserved for Tokenizing compression algorithm
        /// </summary>
        TokenizingCompressionAlgorithm = 7,

        /// <summary>
        /// The file is Deflated
        /// </summary>
        Deflate = 8,

        /// <summary>
        /// Enhanced Deflating using Deflate64(tm)
        /// </summary>
        Deflate64 = 9,

        /// <summary>
        /// PKWARE Data Compression Library Imploding (old IBM TERSE)
        /// </summary>
        PKWAREDataCompressionLibraryImplode = 10,

        /// <summary>
        /// Reserved by PKWARE
        /// </summary>
        CompressionMethod11 = 11,

        /// <summary>
        /// File is compressed using BZIP2 algorithm
        /// </summary>
        BZIP2 = 12,

        /// <summary>
        /// Reserved by PKWARE
        /// </summary>
        CompressionMethod13 = 13,

        /// <summary>
        /// LZMA
        /// </summary>
        LZMA = 14,

        /// <summary>
        /// Reserved by PKWARE
        /// </summary>
        CompressionMethod15 = 15,

        /// <summary>
        /// IBM z/OS CMPSC Compression
        /// </summary>
        IBMzOSCMPSC = 16,

        /// <summary>
        /// Reserved by PKWARE
        /// </summary>
        CompressionMethod17 = 17,

        /// <summary>
        /// File is compressed using IBM TERSE (new)
        /// </summary>
        IBMTERSE = 18,

        /// <summary>
        /// IBM LZ77 z Architecture
        /// </summary>
        IBMLZ77 = 19,

        /// <summary>
        /// deprecated (use method 93 for zstd)
        /// </summary>
        [Obsolete]
        OldZstandard = 20,

        /// <summary>
        /// Zstandard (zstd) Compression
        /// </summary>
        Zstandard = 93,

        /// <summary>
        /// MP3 Compression
        /// </summary>
        MP3 = 94,

        /// <summary>
        /// XZ Compression
        /// </summary>
        XZ = 95,

        /// <summary>
        /// JPEG variant
        /// </summary>
        JPEGVariant = 96,

        /// <summary>
        /// WavPack compressed data
        /// </summary>
        WavPack = 97,

        /// <summary>
        /// PPMd version I, Rev 1
        /// </summary>
        PPMdVersionIRev1 = 98,

        /// <summary>
        /// AE-x encryption marker
        /// </summary>
        AExEncryption = 99,
    }

    [Flags]
    public enum GeneralPurposeBitFlags : ushort
    {
        /// <summary>
        /// Indicates that the file is encrypted
        /// </summary>
        FileEncrypted = 0b0000_0000_0000_0001,

        #region Compression Method 6 (Implode)

        /// <summary>
        /// Set   - 8K sliding dictionary
        /// Clear - 4K sliding dictionary
        /// </summary>
        LargeSlidingDictionary = 0b0000_0000_0000_0010,

        /// <summary>
        /// Set   - 3 Shannon-Fano trees were used
        /// Clear - 2 Shannon-Fano trees were used
        /// </summary>
        ThreeTrees = 0b0000_0000_0000_0100,

        #endregion

        #region Compression Method 8 (Deflate)

        /// <summary>
        /// Normal (-en) compression
        /// </summary>
        NormalCompression = 0b0000_0000_0000_0000,

        /// <summary>
        /// Maximum (-ex) compression
        /// </summary>
        MaximumCompression = 0b0000_0000_0000_0010,

        /// <summary>
        /// Fast (-ef) compression
        /// </summary>
        FastCompression = 0b0000_0000_0000_0100,

        /// <summary>
        /// Super Fast (-es) compression
        /// </summary>
        SuperFastCompression = 0b0000_0000_0000_0110,

        #endregion

        #region Compression Method 14 (LZMA)

        /// <summary>
        /// Set   - indicates an end-of-stream (EOS) marker is used to
        ///         mark the end of the compressed data stream.
        /// Clear - an EOS marker is not present and the compressed data
        ///         size must be known to extract.
        /// </summary>
        EndOfStreamMarker = 0b0000_0000_0000_0010,

        #endregion

        /// <summary>
        /// set - the fields crc-32, compressed size and
        ///       uncompressed size are set to zero in the
        ///       local header. The correct values are put
        ///       in the data descriptor immediately
        ///       following the compressed data.
        /// </summary>
        NoCRC = 0b0000_0000_0000_1000,

        /// <summary>
        /// Reserved for use with method 8, for enhanced deflating. 
        /// </summary>
        EnhancedDeflateReserved = 0b0000_0000_0001_0000,

        /// <summary>
        /// Indicates that the file is compressed patched data.
        /// </summary>
        /// <remarks>Requires PKZIP version 2.70 or greater</remarks>
        CompressedPatchedData = 0b0000_0000_0010_0000,

        /// <summary>
        /// Set   - you MUST set the version needed to extract value
        ///         to at least 50 and you MUST also set bit 0. If AES
        ///         encryption is used, the version needed to extract
        ///         value MUST be at least 51.
        /// </summary>
        StrongEncryption = 0b0000_0000_0100_0000,

        /// <summary>
        /// Currently unused
        /// </summary>
        Bit7 = 0b0000_0000_1000_0000,

        /// <summary>
        /// Currently unused
        /// </summary>
        Bit8 = 0b0000_0001_0000_0000,

        /// <summary>
        /// Currently unused
        /// </summary>
        Bit9 = 0b0000_0010_0000_0000,

        /// <summary>
        /// Currently unused
        /// </summary>
        Bit10 = 0b0000_0100_0000_0000,

        /// <summary>
        /// Set   - the filename and comment fields for this
        ///         file MUST be encoded using UTF-8.
        /// </summary>
        LanguageEncodingFlag = 0b0000_1000_0000_0000,

        /// <summary>
        /// Reserved by PKWARE for enhanced compression
        /// </summary>
        PKWAREEnhancedCompression = 0b0001_0000_0000_0000,

        /// <summary>
        /// Set   - Set when encrypting the Central Directory to
        ///         indicate selected data values in the Local
        ///         Header are masked to hide their actual values
        /// </summary>
        LocalHeaderValuesMasked = 0b0010_0000_0000_0000,

        /// <summary>
        /// Reserved by PKWARE for alternate streams
        /// </summary>
        PKWAREAlternateStreams = 0b0100_0000_0000_0000,

        /// <summary>
        /// Reserved by PKWARE
        /// </summary>
        PKWAREReserved = 0b1000_0000_0000_0000,
    }

    public enum HeaderID : ushort
    {
        /// <summary>
        /// Zip64 extended information extra field
        /// </summary>
        Zip64ExtendedInformation = 0x0001,

        /// <summary>
        /// AV Info
        /// </summary>
        AVInfo = 0x0007,

        /// <summary>
        /// Reserved for extended language encoding data (PFS)
        /// </summary>
        ExtendedLanguageEncodingData = 0x0008,

        /// <summary>
        /// OS/2
        /// </summary>
        OS2 = 0x0009,

        /// <summary>
        /// NTFS
        /// </summary>
        NTFS = 0x000A,

        /// <summary>
        /// OpenVMS
        /// </summary>
        OpenVMS = 0x000C,

        /// <summary>
        /// UNIX
        /// </summary>
        UNIX = 0x000D,

        /// <summary>
        /// Reserved for file stream and fork descriptors
        /// </summary>
        FileStreamFork = 0x000E,

        /// <summary>
        /// Patch Descriptor
        /// </summary>
        PatchDescriptor = 0x000F,

        /// <summary>
        /// PKCS#7 Store for X.509 Certificates
        /// </summary>
        PKCSStore = 0x0014,

        /// <summary>
        /// X.509 Certificate ID and Signature for individual file
        /// </summary>
        X509IndividualFile = 0x0015,

        /// <summary>
        /// X.509 Certificate ID for Central Directory
        /// </summary>
        X509CentralDirectory = 0x0016,

        /// <summary>
        /// Strong Encryption Header
        /// </summary>
        StrongEncryptionHeader = 0x0017,

        /// <summary>
        /// Record Management Controls
        /// </summary>
        RecordManagementControls = 0x0018,

        /// <summary>
        /// PKCS#7 Encryption Recipient Certificate List
        /// </summary>
        PKCSCertificateList = 0x0019,

        /// <summary>
        /// Reserved for Timestamp record
        /// </summary>
        Timestamp = 0x0020,

        /// <summary>
        /// Policy Decryption Key Record
        /// </summary>
        PolicyDecryptionKey = 0x0021,

        /// <summary>
        /// Smartcrypt Key Provider Record
        /// </summary>
        SmartcryptKeyProvider = 0x0022,

        /// <summary>
        /// Smartcrypt Policy Key Data Record
        /// </summary>
        SmartcryptPolicyKeyData = 0x0023,

        /// <summary>
        /// IBM S/390 (Z390), AS/400 (I400) attributes - uncompressed
        /// </summary>
        IBMS390AttributesUncompressed = 0x0065,

        /// <summary>
        /// Reserved for IBM S/390 (Z390), AS/400 (I400) attributes - compressed
        /// </summary>
        IBMS390AttributesCompressed = 0x0066,

        /// <summary>
        /// POSZIP 4690 (reserved)
        /// </summary>
        POSZIP4690 = 0x4690,

        #region Third-Party

        /// <summary>
        /// Macintosh
        /// </summary>
        Macintosh = 0x07C8,

        /// <summary>
        /// Pixar USD header ID
        /// </summary>
        PixarUSD = 0x1986,

        /// <summary>
        /// ZipIt Macintosh
        /// </summary>
        ZipItMacintosh = 0x2605,

        /// <summary>
        /// ZipIt Macintosh 1.3.5+
        /// </summary>
        ZipItMacintosh135Plus = 0x2705,

        /// <summary>
        /// ZipIt Macintosh 1.3.5+
        /// </summary>
        ZipItMacintosh135PlusAlt = 0x2805,

        /// <summary>
        /// Info-ZIP Macintosh
        /// </summary>
        InfoZIPMacintosh = 0x334D,

        /// <summary>
        /// Acorn/SparkFS
        /// </summary>
        AcornSparkFS = 0x4341,

        /// <summary>
        /// Windows NT security descriptor (binary ACL)
        /// </summary>
        WindowsNTSecurityDescriptor = 0x4453,

        /// <summary>
        /// VM/CMS
        /// </summary>
        VMCMS = 0x4704,

        /// <summary>
        /// MVS
        /// </summary>
        MVS = 0x470F,

        /// <summary>
        /// THEOS (old?)
        /// </summary>
        THEOSold = 0x4854,

        /// <summary>
        /// FWKCS MD5
        /// </summary>
        FWKCSMD5 = 0x4B46,

        /// <summary>
        /// OS/2 access control list (text ACL)
        /// </summary>
        OS2AccessControlList = 0x4C41,

        /// <summary>
        /// Info-ZIP OpenVMS
        /// </summary>
        InfoZIPOpenVMS = 0x4D49,

        /// <summary>
        /// Macintosh Smartzip (??)
        /// </summary>
        MacintoshSmartzip = 0x4D63,

        /// <summary>
        /// Xceed original location extra field
        /// </summary>
        XceedOriginalLocation = 0x4F4C,

        /// <summary>
        /// AOS/VS (ACL)
        /// </summary>
        ADSVS = 0x5356,

        /// <summary>
        /// extended timestamp
        /// </summary>
        ExtendedTimestamp = 0x5455,

        /// <summary>
        /// Xceed unicode extra field
        /// </summary>
        XceedUnicode = 0x554E,

        /// <summary>
        /// Info-ZIP UNIX (original, also OS/2, NT, etc)
        /// </summary>
        InfoZIPUNIX = 0x5855,

        /// <summary>
        /// Info-ZIP Unicode Comment Extra Field
        /// </summary>
        InfoZIPUnicodeComment = 0x6375,

        /// <summary>
        /// BeOS/BeBox
        /// </summary>
        BeOSBeBox = 0x6542,

        /// <summary>
        /// THEOS
        /// </summary>
        THEOS = 0x6854,

        /// <summary>
        /// Info-ZIP Unicode Path Extra Field
        /// </summary>
        InfoZIPUnicodePath = 0x7075,

        /// <summary>
        /// AtheOS/Syllable
        /// </summary>
        AtheOSSyllable = 0x7441,

        /// <summary>
        /// ASi UNIX
        /// </summary>
        ASiUNIX = 0x756E,

        /// <summary>
        /// Info-ZIP UNIX (new)
        /// </summary>
        InfoZIPUNIXNew = 0x7855,

        /// <summary>
        /// Info-ZIP UNIX (newer UID/GID)
        /// </summary>
        InfoZIPUNIXNewer = 0x7875,

        /// <summary>
        /// Data Stream Alignment (Apache Commons-Compress)
        /// </summary>
        DataStreamAlignment = 0xA11E,

        /// <summary>
        /// Microsoft Open Packaging Growth Hint
        /// </summary>
        MicrosoftOpenPackagingGrowthHint = 0xA220,

        /// <summary>
        /// Java JAR file Extra Field Header ID
        /// </summary>
        JavaJAR = 0xCAFE,

        /// <summary>
        /// Android ZIP Alignment Extra Field
        /// </summary>
        AndroidZIPAlignment = 0xD935,

        /// <summary>
        /// Korean ZIP code page info
        /// </summary>
        KoreanZIPCodePage = 0xE57A,

        /// <summary>
        /// SMS/QDOS
        /// </summary>
        SMSQDOS = 0xFD4A,

        /// <summary>
        /// AE-x encryption structure
        /// </summary>
        AExEncryptionStructure = 0x9901,

        /// <summary>
        /// Unknown
        /// </summary>
        Unknown = 0x9902,

        #endregion
    }

    public enum HostSystem : byte
    {
        /// <summary>
        /// MS-DOS and OS/2 (FAT / VFAT / FAT32 file systems)
        /// </summary>
        MSDOS = 0,

        /// <summary>
        /// Amiga
        /// </summary>
        Amiga = 1,

        /// <summary>
        /// OpenVMS
        /// </summary>
        OpenVMS = 2,

        /// <summary>
        /// UNIX
        /// </summary>
        UNIX = 3,

        /// <summary>
        /// VM/CMS
        /// </summary>
        VMCMS = 4,

        /// <summary>
        /// Atari ST
        /// </summary>
        AtariST = 5,

        /// <summary>
        /// OS/2 H.P.F.S.
        /// </summary>
        OS2HPFS = 6,

        /// <summary>
        /// Macintosh
        /// </summary>
        Macintosh = 7,

        /// <summary>
        /// Z-System
        /// </summary>
        ZSystem = 8,

        /// <summary>
        /// CP/M
        /// </summary>
        CPM = 9,

        /// <summary>
        /// Windows NTFS
        /// </summary>
        WindowsNTFS = 10,

        /// <summary>
        /// MVS (OS/390 - Z/OS)
        /// </summary>
        MVS = 11,

        /// <summary>
        /// VSE
        /// </summary>
        VSE = 12,

        /// <summary>
        /// Acorn Risc
        /// </summary>
        AcornRisc = 13,

        /// <summary>
        /// VFAT
        /// </summary>
        VFAT = 14,

        /// <summary>
        /// alternate MVS
        /// </summary>
        AlternateVMS = 15,

        /// <summary>
        /// BeOS
        /// </summary>
        BeOS = 16,

        /// <summary>
        /// Tandem
        /// </summary>
        Tandem = 17,

        /// <summary>
        /// OS/400
        /// </summary>
        OS400 = 18,

        /// <summary>
        /// OS X (Darwin)
        /// </summary>
        OSX = 19,

        // 20 thru 255 - unused
    }

    [Flags]
    public enum InternalFileAttributes : ushort
    {
        /// <summary>
        /// Set   - The file is apparently an ASCII or text file
        /// Clear - The file is apparently binary data
        /// </summary>
        ASCII = 0b0000_0000_0000_0001,

        /// <summary>
        /// Reserved for use by PKWARE
        /// </summary>
        Bit1 = 0b0000_0000_0000_0010,

        /// <summary>
        /// Reserved for use by PKWARE
        /// </summary>
        Bit2 = 0b0000_0000_0000_0100,

        /*
         4.4.14.2 The 0x0002 bit of this field indicates, if set, that 
         a 4 byte variable record length control field precedes each 
         logical record indicating the length of the record. The 
         record length control field is stored in little-endian byte
         order.  This flag is independent of text control characters, 
         and if used in conjunction with text data, includes any 
         control characters in the total length of the record. This 
         value is provided for mainframe data transfer support.
        */
    }
}