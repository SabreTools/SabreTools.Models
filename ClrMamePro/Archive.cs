namespace SabreTools.Models.ClrMamePro
{
    /// <remarks>archive</remarks>
    public class Archive
    {
        /// <remarks>name</remarks>
        [Required]
#if NET48
        public string Name { get; set; }
#else
        public string? Name { get; set; }
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