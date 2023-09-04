namespace SabreTools.Models.EverdriveSMDB
{
    /// <summary>
    /// SHA-256 \t Machine Name/Filename \t SHA-1 \t MD5 \t CRC32 \t Size (Optional)
    /// </summary>
    public class Row
    {
        [Required]
#if NET48
        public string SHA256 { get; set; }
#else
        public string? SHA256 { get; set; }
#endif

        [Required]
#if NET48
        public string Name { get; set; }
#else
        public string? Name { get; set; }
#endif

        [Required]
#if NET48
        public string SHA1 { get; set; }
#else
        public string? SHA1 { get; set; }
#endif

        [Required]
#if NET48
        public string MD5 { get; set; }
#else
        public string? MD5 { get; set; }
#endif

        [Required]
#if NET48
        public string CRC32 { get; set; }
#else
        public string? CRC32 { get; set; }
#endif

#if NET48
        public string Size { get; set; }
#else
        public string? Size { get; set; }
#endif

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