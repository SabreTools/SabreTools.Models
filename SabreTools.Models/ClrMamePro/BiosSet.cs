namespace SabreTools.Models.ClrMamePro
{
    /// <remarks>biosset</remarks>
    public class BiosSet
    {
        /// <remarks>name</remarks>
        [Required]
        public string? Name { get; set; }

        /// <remarks>description</remarks>
        [Required]
        public string? Description { get; set; }

        /// <remarks>default</remarks>
        public string? Default { get; set; }

        #region DO NOT USE IN PRODUCTION

        /// <remarks>Should be empty</remarks>
        public string[]? ADDITIONAL_ELEMENTS { get; set; }

        #endregion
    }
}