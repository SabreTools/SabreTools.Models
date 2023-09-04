namespace SabreTools.Models.Hashfile
{
    /// <summary>
    /// SHA-512 File
    /// </summary>
    public class SHA512
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