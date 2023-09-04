namespace SabreTools.Models.ClrMamePro
{
    /// <remarks>biosset</remarks>
    public class BiosSet
    {
        /// <remarks>name</remarks>
        [Required]
#if NET48
        public string Name { get; set; }
#else
        public string? Name { get; set; }
#endif

        /// <remarks>description</remarks>
        [Required]
#if NET48
        public string Description { get; set; }
#else
        public string? Description { get; set; }
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