namespace SabreTools.Models.RomCenter
{
    /// <remarks>[dat]</remarks>
    public class Dat
    {
        /// <remarks>version</remarks>
        public string? Version { get; set; }

        /// <remarks>plugin</remarks>
        public string? Plugin { get; set; }

        /// <remarks>split</remarks>
        public string? Split { get; set; }

        /// <remarks>merge</remarks>
        public string? Merge { get; set; }

        #region DO NOT USE IN PRODUCTION

        /// <remarks>Should be empty</remarks>
        public string[]? ADDITIONAL_ELEMENTS { get; set; }

        #endregion
    }
}