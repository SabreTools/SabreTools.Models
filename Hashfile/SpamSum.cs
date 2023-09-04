namespace SabreTools.Models.Hashfile
{
    /// <summary>
    /// SpamSum File
    /// </summary>
    public class SpamSum
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