namespace SabreTools.Models.ClrMamePro
{
    /// <remarks>chip</remarks>
    public class Chip
    {
        /// <remarks>type, (cpu|audio)</remarks>
        [Required]
#if NET48
        public string Type { get; set; }
#else
        public string? Type { get; set; }
#endif

        /// <remarks>name</remarks>
        [Required]
#if NET48
        public string Name { get; set; }
#else
        public string? Name { get; set; }
#endif

        /// <remarks>flags</remarks>
#if NET48
        public string Flags { get; set; }
#else
        public string? Flags { get; set; }
#endif

        /// <remarks>clock, Numeric?</remarks>
#if NET48
        public string Clock { get; set; }
#else
        public string? Clock { get; set; }
#endif

        #region DO NOT USE IN PRODUCTION

        /// <remarks>Should be empty</remarks>
#if NET48
        public object[] ADDITIONAL_ELEMENTS { get; set; }
#else
        public object[]? ADDITIONAL_ELEMENTS { get; set; }
#endif

        #endregion
    }
}