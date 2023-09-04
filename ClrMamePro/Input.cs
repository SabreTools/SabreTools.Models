namespace SabreTools.Models.ClrMamePro
{
    /// <remarks>input</remarks>
    public class Input
    {
        /// <remarks>players, Numeric/remarks>
        [Required]
#if NET48
        public string Players { get; set; }
#else
        public string? Players { get; set; }
#endif

        /// <remarks>control</remarks>
#if NET48
        public string Control { get; set; }
#else
        public string? Control { get; set; }
#endif

        /// <remarks>buttons, Numeric</remarks>
        [Required]
#if NET48
        public string Buttons { get; set; }
#else
        public string? Buttons { get; set; }
#endif

        /// <remarks>coins, Numeric</remarks>
#if NET48
        public string Coins { get; set; }
#else
        public string? Coins { get; set; }
#endif

        /// <remarks>tilt, (yes|no) "no"</remarks>
#if NET48
        public string Tilt { get; set; }
#else
        public string? Tilt { get; set; }
#endif

        /// <remarks>service, (yes|no) "no"</remarks>
#if NET48
        public string Service { get; set; }
#else
        public string? Service { get; set; }
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