namespace SabreTools.Models.SeparatedValue
{
    public class MetadataFile
    {
        [Required]
#if NET48
        public string[] Header { get; set; }
#else
        public string[]? Header { get; set; }
#endif

#if NET48
        public Row[] Row { get; set; }
#else
        public Row[]? Row { get; set; }
#endif
    }
}