namespace SabreTools.Models.DosCenter
{
    /// <remarks>doscenter</remarks>
    public class DosCenter
    {
        /// <remarks>name</remarks>
        public string? Name { get; set; }

        /// <remarks>description</remarks>
        public string? Description { get; set; }

        /// <remarks>version</remarks>
        public string? Version { get; set; }

        /// <remarks>date</remarks>
        public string? Date { get; set; }

        /// <remarks>author</remarks>
        public string? Author { get; set; }

        /// <remarks>homepage</remarks>
        public string? Homepage { get; set; }

        /// <remarks>comment</remarks>
        public string? Comment { get; set; }

        #region DO NOT USE IN PRODUCTION

        /// <remarks>Should be empty</remarks>
        public string[]? ADDITIONAL_ELEMENTS { get; set; }

        #endregion
    }
}