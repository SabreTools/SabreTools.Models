namespace SabreTools.Models.SeparatedValue
{
    /// <summary>
    /// Standardized variant of a row
    /// </summary>
    public class Row
    {
        /// <remarks>File Name</remarks>
#if NET48
        public string FileName { get; set; }
#else
        public string? FileName { get; set; }
#endif

        /// <remarks>Internal Name</remarks>
#if NET48
        public string InternalName { get; set; }
#else
        public string? InternalName { get; set; }
#endif

        /// <remarks>Description</remarks>
#if NET48
        public string Description { get; set; }
#else
        public string? Description { get; set; }
#endif

        /// <remarks>Game Name</remarks>
        [Required]
#if NET48
        public string GameName { get; set; }
#else
        public string? GameName { get; set; }
#endif

        /// <remarks>Game Description</remarks>
#if NET48
        public string GameDescription { get; set; }
#else
        public string? GameDescription { get; set; }
#endif

        /// <remarks>Type</remarks>
        [Required]
#if NET48
        public string Type { get; set; }
#else
        public string? Type { get; set; }
#endif

        /// <remarks>Rom Name</remarks>
#if NET48
        public string RomName { get; set; }
#else
        public string? RomName { get; set; }
#endif

        /// <remarks>Disk Name</remarks>
#if NET48
        public string DiskName { get; set; }
#else
        public string? DiskName { get; set; }
#endif

        /// <remarks>Size, Numeric</remarks>
#if NET48
        public string Size { get; set; }
#else
        public string? Size { get; set; }
#endif

        /// <remarks>CRC</remarks>
#if NET48
        public string CRC { get; set; }
#else
        public string? CRC { get; set; }
#endif

        /// <remarks>MD5</remarks>
#if NET48
        public string MD5 { get; set; }
#else
        public string? MD5 { get; set; }
#endif

        /// <remarks>SHA1</remarks>
#if NET48
        public string SHA1 { get; set; }
#else
        public string? SHA1 { get; set; }
#endif

        /// <remarks>SHA256</remarks>
#if NET48
        public string SHA256 { get; set; }
#else
        public string? SHA256 { get; set; }
#endif

        /// <remarks>SHA384, Optional</remarks>
#if NET48
        public string SHA384 { get; set; }
#else
        public string? SHA384 { get; set; }
#endif

        /// <remarks>SHA512, Optional</remarks>
#if NET48
        public string SHA512 { get; set; }
#else
        public string? SHA512 { get; set; }
#endif

        /// <remarks>SpamSum, Optional</remarks>
#if NET48
        public string SpamSum { get; set; }
#else
        public string? SpamSum { get; set; }
#endif

        /// <remarks>Status, Nodump</remarks>
#if NET48
        public string Status { get; set; }
#else
        public string? Status { get; set; }
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