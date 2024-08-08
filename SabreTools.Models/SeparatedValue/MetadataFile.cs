namespace SabreTools.Models.SeparatedValue
{
    public class MetadataFile
    {
        [Required]
        public string[]? Header { get; set; }

        public Row[]? Row { get; set; }
    }
}