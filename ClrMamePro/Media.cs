namespace SabreTools.Models.ClrMamePro
{
    /// <remarks>media</remarks>
    public class Media
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

        /// <remarks>sha256</remarks>
#if NET48
        public string SHA256 { get; set; }
#else
        public string? SHA256 { get; set; }
#endif

        /// <remarks>spamsum</remarks>
#if NET48
        public string SpamSum { get; set; }
#else
        public string? SpamSum { get; set; }
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