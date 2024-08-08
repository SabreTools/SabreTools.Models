namespace SabreTools.Models.RomCenter
{
    /// <remarks>[credits]</remarks>
    public class Credits
    {
        /// <remarks>author</remarks>
        public string? Author { get; set; }

        /// <remarks>version</remarks>
        public string? Version { get; set; }

        /// <remarks>email</remarks>
        public string? Email { get; set; }

        /// <remarks>homepage</remarks>
        public string? Homepage { get; set; }

        /// <remarks>url</remarks>
        public string? Url { get; set; }

        /// <remarks>date</remarks>
        public string? Date { get; set; }

        /// <remarks>comment</remarks>
        public string? Comment { get; set; }

        #region DO NOT USE IN PRODUCTION

        /// <remarks>Should be empty</remarks>
        public string[]? ADDITIONAL_ELEMENTS { get; set; }

        #endregion
    }
}