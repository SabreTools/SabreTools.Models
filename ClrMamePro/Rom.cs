namespace SabreTools.Models.ClrMamePro
{
    /// <remarks>rom</remarks>
    public class Rom
    {
        /// <remarks>name</remarks>
        [Required]
#if NET48
        public string Name { get; set; }
#else
        public string? Name { get; set; }
#endif

        /// <remarks>size, Numeric</remarks>
        [Required]
#if NET48
        public string Size { get; set; }
#else
        public string? Size { get; set; }
#endif

        /// <remarks>crc</remarks>
#if NET48
        public string CRC { get; set; }
#else
        public string? CRC { get; set; }
#endif

        /// <remarks>md5</remarks>
#if NET48
        public string MD5 { get; set; }
#else
        public string? MD5 { get; set; }
#endif

        /// <remarks>sha1</remarks>
#if NET48
        public string SHA1 { get; set; }
#else
        public string? SHA1 { get; set; }
#endif

        /// <remarks>merge</remarks>
#if NET48
        public string Merge { get; set; }
#else
        public string? Merge { get; set; }
#endif

        /// <remarks>status</remarks>
#if NET48
        public string Status { get; set; }
#else
        public string? Status { get; set; }
#endif

        /// <remarks>flags</remarks>
#if NET48
        public string Flags { get; set; }
#else
        public string? Flags { get; set; }
#endif

        /// <remarks>date</remarks>
#if NET48
        public string Date { get; set; }
#else
        public string? Date { get; set; }
#endif

        #region Hash Extensions

        /// <remarks>sha256; Also in No-Intro spec; Appears after SHA1</remarks>
#if NET48
        public string SHA256 { get; set; }
#else
        public string? SHA256 { get; set; }
#endif

        /// <remarks>sha384; Appears after SHA256</remarks>
#if NET48
        public string SHA384 { get; set; }
#else
        public string? SHA384 { get; set; }
#endif

        /// <remarks>sha512; Appears after SHA384</remarks>
#if NET48
        public string SHA512 { get; set; }
#else
        public string? SHA512 { get; set; }
#endif

        /// <remarks>spamsum; Appears after SHA512</remarks>
#if NET48
        public string SpamSum { get; set; }
#else
        public string? SpamSum { get; set; }
#endif

        #endregion

        #region DiscImgeCreator Extensions

        /// <remarks>xxh3_64; Appears after SpamSum</remarks>
#if NET48
        public string xxHash364 { get; set; }
#else
        public string? xxHash364 { get; set; }
#endif

        /// <remarks>xxh3_128; Appears after xxHash364</remarks>
#if NET48
        public string xxHash3128 { get; set; }
#else
        public string? xxHash3128 { get; set; }
#endif

        #endregion

        #region MAME Extensions

        /// <remarks>region; Appears after Status</remarks>
#if NET48
        public string Region { get; set; }
#else
        public string? Region { get; set; }
#endif

        /// <remarks>offs; Appears after Flags</remarks>
#if NET48
        public string Offs { get; set; }
#else
        public string? Offs { get; set; }
#endif

        #endregion

        #region No-Intro Extensions

        /// <remarks>serial; Appears after Offs</remarks>
#if NET48
        public string Serial { get; set; }
#else
        public string? Serial { get; set; }
#endif

        /// <remarks>header; Appears after Serial</remarks>
#if NET48
        public string Header { get; set; }
#else
        public string? Header { get; set; }
#endif

        #endregion

        #region RomVault Extensions

        /// <remarks>inverted; Boolean; Appears after Date</remarks>
#if NET48
        public string Inverted { get; set; }
#else
        public string? Inverted { get; set; }
#endif

        /// <remarks>mia; Boolean; Appears after Inverted</remarks>
#if NET48
        public string MIA { get; set; }
#else
        public string? MIA { get; set; }
#endif

        #endregion

        #region DO NOT USE IN PRODUCTION

        /// <remarks>Should be empty</remarks>
#if NET48
        public string[] ADDITIONAL_ELEMENTS { get; set; }
#else
        public string[]? ADDITIONAL_ELEMENTS { get; set; }
#endif

        #endregion
    }
}