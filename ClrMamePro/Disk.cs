namespace SabreTools.Models.ClrMamePro
{
    /// <remarks>disk</remarks>
    public class Disk
    {
        /// <remarks>name</remarks>
        [Required]
#if NET48
        public string Name { get; set; }
#else
        public string? Name { get; set; }
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