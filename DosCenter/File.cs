namespace SabreTools.Models.DosCenter
{
    /// <remarks>file</remarks>
    public class File
    {
        /// <remarks>name, attribute</remarks>
        [Required]
        public string? Name { get; set; }

        /// <remarks>size, attribute, numeric</remarks>
        [Required]
        public string? Size { get; set; }

        /// <remarks>crc, attribute</remarks>
        [Required]
        public string? CRC { get; set; }

        /// <remarks>date, attribute</remarks>
        public string? Date { get; set; }

        #region DO NOT USE IN PRODUCTION

        /// <remarks>Should be empty</remarks>
        public string[]? ADDITIONAL_ELEMENTS { get; set; }

        #endregion
    }
}