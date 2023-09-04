namespace SabreTools.Models.AttractMode
{
    public class Row
    {
        /// <remarks>Also called Romname</remarks>
        [Required]
#if NET48
        public string Name { get; set; }
#else
        public string? Name { get; set; }
#endif

#if NET48
        public string Title { get; set; }
#else
        public string? Title { get; set; }
#endif

#if NET48
        public string Emulator { get; set; }
#else
        public string? Emulator { get; set; }
#endif

#if NET48
        public string CloneOf { get; set; }
#else
        public string? CloneOf { get; set; }
#endif

#if NET48
        public string Year { get; set; }
#else
        public string? Year { get; set; }
#endif

#if NET48
        public string Manufacturer { get; set; }
#else
        public string? Manufacturer { get; set; }
#endif

#if NET48
        public string Category { get; set; }
#else
        public string? Category { get; set; }
#endif

#if NET48
        public string Players { get; set; }
#else
        public string? Players { get; set; }
#endif

#if NET48
        public string Rotation { get; set; }
#else
        public string? Rotation { get; set; }
#endif

#if NET48
        public string Control { get; set; }
#else
        public string? Control { get; set; }
#endif

#if NET48
        public string Status { get; set; }
#else
        public string? Status { get; set; }
#endif

#if NET48
        public string DisplayCount { get; set; }
#else
        public string? DisplayCount { get; set; }
#endif

#if NET48
        public string DisplayType { get; set; }
#else
        public string? DisplayType { get; set; }
#endif

#if NET48
        public string AltRomname { get; set; }
#else
        public string? AltRomname { get; set; }
#endif

#if NET48
        public string AltTitle { get; set; }
#else
        public string? AltTitle { get; set; }
#endif

#if NET48
        public string Extra { get; set; }
#else
        public string? Extra { get; set; }
#endif

#if NET48
        public string Buttons { get; set; }
#else
        public string? Buttons { get; set; }
#endif

#if NET48
        public string Favorite { get; set; }
#else
        public string? Favorite { get; set; }
#endif

#if NET48
        public string Tags { get; set; }
#else
        public string? Tags { get; set; }
#endif

#if NET48
        public string PlayedCount { get; set; }
#else
        public string? PlayedCount { get; set; }
#endif

#if NET48
        public string PlayedTime { get; set; }
#else
        public string? PlayedTime { get; set; }
#endif

#if NET48
        public string FileIsAvailable { get; set; }
#else
        public string? FileIsAvailable { get; set; }
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