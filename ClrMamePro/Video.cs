namespace SabreTools.Models.ClrMamePro
{
    /// <remarks>video</remarks>
    public class Video
    {
        /// <remarks>screen, (raster|vector)</remarks>
        [Required]
#if NET48
        public string Screen { get; set; }
#else
        public string? Screen { get; set; }
#endif

        /// <remarks>orientation, (vertical|horizontal)</remarks>
        [Required]
#if NET48
        public string Orientation { get; set; }
#else
        public string? Orientation { get; set; }
#endif

        /// <remarks>x, Numeric?</remarks>
#if NET48
        public string X { get; set; }
#else
        public string? X { get; set; }
#endif

        /// <remarks>y, Numeric?</remarks>
#if NET48
        public string Y { get; set; }
#else
        public string? Y { get; set; }
#endif

        /// <remarks>aspectx, Numeric?</remarks>
#if NET48
        public string AspectX { get; set; }
#else
        public string? AspectX { get; set; }
#endif

        /// <remarks>aspecty, Numeric?</remarks>
#if NET48
        public string AspectY { get; set; }
#else
        public string? AspectY { get; set; }
#endif

        /// <remarks>freq, Numeric?</remarks>
#if NET48
        public string Freq { get; set; }
#else
        public string? Freq { get; set; }
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