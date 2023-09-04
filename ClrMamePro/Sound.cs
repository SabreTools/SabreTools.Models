namespace SabreTools.Models.ClrMamePro
{
    /// <remarks>sound</remarks>
    public class Sound
    {
        /// <remarks>channels, Numeric?</remarks>
        [Required]
#if NET48
        public string Channels { get; set; }
#else
        public string? Channels { get; set; }
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