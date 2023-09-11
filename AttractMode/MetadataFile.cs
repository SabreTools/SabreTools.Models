namespace SabreTools.Models.AttractMode
{
    /// <summary>
    /// #Name;Title;Emulator;CloneOf;Year;Manufacturer;Category;Players;Rotation;Control;Status;DisplayCount;DisplayType;AltRomname;AltTitle;Extra;Buttons    /// </summary>
    /// </summary>
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
        public Row?[]? Row { get; set; }
#endif
    }
}