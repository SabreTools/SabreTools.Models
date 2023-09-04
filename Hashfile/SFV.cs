namespace SabreTools.Models.Hashfile
{
    /// <summary>
    /// File CRC
    /// </summary>
    public class SFV
    {
        [Required]
#if NET48
        public string File { get; set; }
#else
        public string? File { get; set; }
#endif

        [Required]
#if NET48
        public string Hash { get; set; }
#else
        public string? Hash { get; set; }
#endif
    }
}