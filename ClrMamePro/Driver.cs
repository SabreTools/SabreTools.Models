namespace SabreTools.Models.ClrMamePro
{
    /// <remarks>driver</remarks>
    public class Driver
    {
        /// <remarks>status, (good|imperfect|preliminary)</remarks>
        [Required]
#if NET48
        public string Status { get; set; }
#else
        public string? Status { get; set; }
#endif

        /// <remarks>color, (good|imperfect|preliminary)</remarks>
#if NET48
        public string Color { get; set; }
#else
        public string? Color { get; set; }
#endif

        /// <remarks>sound, (good|imperfect|preliminary)</remarks>
#if NET48
        public string Sound { get; set; }
#else
        public string? Sound { get; set; }
#endif

        /// <remarks>palettesize, Numeric?</remarks>
#if NET48
        public string PaletteSize { get; set; }
#else
        public string? PaletteSize { get; set; }
#endif

        /// <remarks>blit, (plain|dirty)</remarks>
#if NET48
        public string Blit { get; set; }
#else
        public string? Blit { get; set; }
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