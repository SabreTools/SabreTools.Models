namespace SabreTools.Models.DosCenter
{
    /// <remarks>doscenter</remarks>
    public class DosCenter
    {
        /// <remarks>name</remarks>
#if NET48
        public string Name { get; set; }
#else
        public string? Name { get; set; }
#endif

        /// <remarks>description</remarks>
#if NET48
        public string Description { get; set; }
#else
        public string? Description { get; set; }
#endif

        /// <remarks>version</remarks>
#if NET48
        public string Version { get; set; }
#else
        public string? Version { get; set; }
#endif

        /// <remarks>date</remarks>
#if NET48
        public string Date { get; set; }
#else
        public string? Date { get; set; }
#endif

        /// <remarks>author</remarks>
#if NET48
        public string Author { get; set; }
#else
        public string? Author { get; set; }
#endif

        /// <remarks>homepage</remarks>
#if NET48
        public string Homepage { get; set; }
#else
        public string? Homepage { get; set; }
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