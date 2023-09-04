namespace SabreTools.Models.RomCenter
{
    /// <remarks>[credits]</remarks>
    public class Credits
    {
        /// <remarks>author</remarks>
#if NET48
        public string Author { get; set; }
#else
        public string? Author { get; set; }
#endif

        /// <remarks>version</remarks>
#if NET48
        public string Version { get; set; }
#else
        public string? Version { get; set; }
#endif

        /// <remarks>email</remarks>
#if NET48
        public string Email { get; set; }
#else
        public string? Email { get; set; }
#endif

        /// <remarks>homepage</remarks>
#if NET48
        public string Homepage { get; set; }
#else
        public string? Homepage { get; set; }
#endif

        /// <remarks>url</remarks>
#if NET48
        public string Url { get; set; }
#else
        public string? Url { get; set; }
#endif

        /// <remarks>date</remarks>
#if NET48
        public string Date { get; set; }
#else
        public string? Date { get; set; }
#endif

        /// <remarks>comment</remarks>
#if NET48
        public string Comment { get; set; }
#else
        public string? Comment { get; set; }
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