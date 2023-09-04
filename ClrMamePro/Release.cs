namespace SabreTools.Models.ClrMamePro
{
    /// <remarks>release</remarks>
    public class Release
    {
        /// <remarks>name</remarks>
        [Required]
#if NET48
        public string Name { get; set; }
#else
        public string? Name { get; set; }
#endif

        /// <remarks>region</remarks>
        [Required]
#if NET48
        public string Region { get; set; }
#else
        public string? Region { get; set; }
#endif

        /// <remarks>language</remarks>
#if NET48
        public string Language { get; set; }
#else
        public string? Language { get; set; }
#endif

        /// <remarks>date</remarks>
#if NET48
        public string Date { get; set; }
#else
        public string? Date { get; set; }
#endif

        /// <remarks>default</remarks>
#if NET48
        public string Default { get; set; }
#else
        public string? Default { get; set; }
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