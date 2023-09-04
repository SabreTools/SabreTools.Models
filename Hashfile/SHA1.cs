namespace SabreTools.Models.Hashfile
{
    /// <summary>
    /// SHA-1 File
    /// </summary>
    public class SHA1
    {
        [Required]
#if NET48
        public string Hash { get; set; }
#else
        public string? Hash { get; set; }
#endif

        [Required]
#if NET48
        public string File { get; set; }
#else
        public string? File { get; set; }
#endif
    }
}