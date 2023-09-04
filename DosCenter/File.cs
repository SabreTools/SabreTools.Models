namespace SabreTools.Models.DosCenter
{
    /// <remarks>file</remarks>
    public class File
    {
        /// <remarks>name, attribute</remarks>
        [Required]
#if NET48
        public string Name { get; set; }
#else
        public string? Name { get; set; }
#endif

        /// <remarks>size, attribute, numeric</remarks>
        [Required]
#if NET48
        public string Size { get; set; }
#else
        public string? Size { get; set; }
#endif

        /// <remarks>crc, attribute</remarks>
        [Required]
#if NET48
        public string CRC { get; set; }
#else
        public string? CRC { get; set; }
#endif

        /// <remarks>date, attribute</remarks>
#if NET48
        public string Date { get; set; }
#else
        public string? Date { get; set; }
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