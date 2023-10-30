namespace SabreTools.Models.IRD
{
    /// <see href="https://psdevwiki.com/ps3/Bluray_disc#IRD_file"/> 
    /// <see href="https://github.com/SabreTools/MPF/files/13062347/IRD.File.Format.pdf"/> 
    public class File
    {
        /// <summary>
        /// "3IRD"
        /// </summary>
#if NET48
        public byte[] Magic { get; set; }
#else
        public byte[]? Magic { get; set; }
#endif

        /// <summary>
        /// Version
        /// </summary>
        /// <remarks>Versions 6 - 9 are accepted</remarks>
        public byte Version { get; set; }

        /// <summary>
        /// The same value stored in PARAM.SFO / TITLE_ID
        /// </summary>
        /// <remarks>9 bytes, ASCII, stored without dashes</remarks>
#if NET48
        public string TitleID { get; set; }
#else
        public string? TitleID { get; set; }
#endif

        /// <summary>
        /// Number of bytes that follow containing the title
        /// </summary>
        public byte TitleLength { get; set; }

        /// <summary>
        /// The same value stored in PARAM.SFO / TITLE
        /// </summary>
        /// <remarks><see cref="TitleLength"/> bytes, ASCII</remarks>
#if NET48
        public string Title { get; set; }
#else
        public string? Title { get; set; }
#endif

        /// <summary>
        /// The same value stored in PARAM.SFO / PS3_SYSTEM_VER
        /// </summary>
        /// <remarks>4 bytes, ASCII, missing uses "0000"</remarks>
#if NET48
        public string SystemVersion { get; set; }
#else
        public string? SystemVersion { get; set; }
#endif

        /// <summary>
        /// The same value stored in PARAM.SFO / VERSION
        /// </summary>
        /// <remarks>5 bytes, ASCII</remarks>
#if NET48
        public string GameVersion { get; set; }
#else
        public string? GameVersion { get; set; }
#endif

        /// <summary>
        /// The same value stored in PARAM.SFO / APP_VER
        /// </summary>
        /// <remarks>5 bytes, ASCII</remarks>
#if NET48
        public string AppVersion { get; set; }
#else
        public string? AppVersion { get; set; }
#endif

        /// <summary>
        /// Length of the gzip-compressed header data
        /// </summary>
        public uint HeaderLength { get; set; }

        /// <summary>
        /// Gzip-compressed header data
        /// </summary>
#if NET48
        public byte[] Header { get; set; }
#else
        public byte[]? Header { get; set; }
#endif

        /// <summary>
        /// Length of the gzip-compressed footer data
        /// </summary>
        public uint FooterLength { get; set; }

        /// <summary>
        /// Gzip-compressed footer data
        /// </summary>
#if NET48
        public byte[] Footer { get; set; }
#else
        public byte[]? Footer { get; set; }
#endif

        /// <summary>
        /// Number of complete regions in the image
        /// </summary>
        public byte RegionCount { get; set; }

        /// <summary>
        /// MD5 hashes for all complete regions in the image
        /// </summary>
        /// <remarks><see cref="RegionCount"/> regions, 16-bytes per hash</remarks>
#if NET48
        public byte[][] RegionHashes { get; set; }
#else
        public byte[][]? RegionHashes { get; set; }
#endif

        /// <summary>
        /// Number of decrypted files in the image
        /// </summary>
        public uint FileCount { get; set; }

        /// <summary>
        /// Starting sector for each decrypted file
        /// </summary>
        /// <remarks><see cref="FileCount"/> files, alternating with each <see cref="FileHashes"/> entry</remarks>
#if NET48
        public ulong[] FileKeys { get; set; }
#else
        public ulong[]? FileKeys { get; set; }
#endif

        /// <summary>
        /// MD5 hashes for all decrypted files in the image
        /// </summary>
        /// <remarks><see cref="FileCount"/> files, 16-bytes per hash, alternating with each <see cref="FileHashes"/> entry</remarks>
#if NET48
        public byte[][] FileHashes { get; set; }
#else
        public byte[][]? FileHashes { get; set; }
#endif

        /// <summary>
        /// Extra Config, usually 0x0000
        /// </summary>
        public ushort ExtraConfig { get; set; }

        /// <summary>
        /// Attachments, usually 0x0000
        /// </summary>
        public ushort Attachments { get; set; }

        /// <summary>
        /// D1 key
        /// </summary>
        /// <remarks>16 bytes</remarks>
#if NET48
        public byte[] Data1Key { get; set; }
#else
        public byte[]? Data1Key { get; set; }
#endif

        /// <summary>
        /// D2 key
        /// </summary>
        /// <remarks>16 bytes</remarks>
#if NET48
        public byte[] Data2Key { get; set; }
#else
        public byte[]? Data2Key { get; set; }
#endif

        /// <summary>
        /// Uncompressed PIC data
        /// </summary>
        /// <remarks>115 bytes, before D1/D2 keys on version 9</remarks>
#if NET48
        public byte[] PIC { get; set; }
#else
        public byte[]? PIC { get; set; }
#endif

        /// <summary>
        /// Unique Identifier
        /// </summary>
        /// <remarks>Not present on version 6 and prior, after AppVersion on version 7</remarks>
        public uint UID { get; set; }

        /// <summary>
        /// IRD content CRC
        /// </summary>
        public uint CRC { get; set; }
    }
}
