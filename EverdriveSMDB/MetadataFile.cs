namespace SabreTools.Models.EverdriveSMDB
{
    public class MetadataFile
    {
#if NET48
        public Row[] Row { get; set; }
#else
        public Row[]? Row { get; set; }
#endif
    }
}