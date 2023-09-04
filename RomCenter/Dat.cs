namespace SabreTools.Models.RomCenter
{
    /// <remarks>[dat]</remarks>
    public class Dat
    {
        /// <remarks>version</remarks>
#if NET48
        public string Version { get; set; }
#else
        public string? Version { get; set; }
#endif

        /// <remarks>plugin</remarks>
#if NET48
        public string Plugin { get; set; }
#else
        public string? Plugin { get; set; }
#endif

        /// <remarks>split</remarks>
#if NET48
        public string Split { get; set; }
#else
        public string? Split { get; set; }
#endif

        /// <remarks>merge</remarks>
#if NET48
        public string Merge { get; set; }
#else
        public string? Merge { get; set; }
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