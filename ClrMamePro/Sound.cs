namespace SabreTools.Models.ClrMamePro
{
    /// <remarks>sound</remarks>
    public class Sound
    {
        /// <remarks>channels, Numeric?</remarks>
        [Required]
        public string? Channels { get; set; }

        #region DO NOT USE IN PRODUCTION

        /// <remarks>Should be empty</remarks>
        public object[]? ADDITIONAL_ELEMENTS { get; set; }

        #endregion
    }
}