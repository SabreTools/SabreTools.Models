namespace SabreTools.Models.Hashfile
{
    /// <remarks>Hashfiles can only contain one type of hash at a time</remarks>
    public class Hashfile
    {
#if NET48
        public SFV[] SFV { get; set; }
#else
        public SFV[]? SFV { get; set; }
#endif

#if NET48
        public MD5[] MD5 { get; set; }
#else
        public MD5[]? MD5 { get; set; }
#endif

#if NET48
        public SHA1[] SHA1 { get; set; }
#else
        public SHA1[]? SHA1 { get; set; }
#endif

#if NET48
        public SHA256[] SHA256 { get; set; }
#else
        public SHA256[]? SHA256 { get; set; }
#endif

#if NET48
        public SHA384[] SHA384 { get; set; }
#else
        public SHA384[]? SHA384 { get; set; }
#endif

#if NET48
        public SHA512[] SHA512 { get; set; }
#else
        public SHA512[]? SHA512 { get; set; }
#endif

#if NET48
        public SpamSum[] SpamSum { get; set; }
#else
        public SpamSum[]? SpamSum { get; set; }
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