/// <remarks>
/// Information sourced from http://web.archive.org/web/20070221154246/http://www.goldenhawk.com/download/cdrwin.pdf
/// </remarks>
namespace SabreTools.Models.CueSheets
{
    /// <summary>
    /// Represents a single cuesheet
    /// </summary>
    public class CueSheet
    {
        /// <summary>
        /// CATALOG
        /// </summary>
#if NET48
        public string Catalog { get; set; }
#else
        public string? Catalog { get; set; }
#endif

        /// <summary>
        /// CDTEXTFILE
        /// </summary>
#if NET48
        public string CdTextFile { get; set; }
#else
        public string? CdTextFile { get; set; }
#endif

        /// <summary>
        /// PERFORMER
        /// </summary>
#if NET48
        public string Performer { get; set; }
#else
        public string? Performer { get; set; }
#endif

        /// <summary>
        /// SONGWRITER
        /// </summary>
#if NET48
        public string Songwriter { get; set; }
#else
        public string? Songwriter { get; set; }
#endif

        /// <summary>
        /// TITLE
        /// </summary>
#if NET48
        public string Title { get; set; }
#else
        public string? Title { get; set; }
#endif

        /// <summary>
        /// List of FILE in cuesheet
        /// </summary>
#if NET48
        public CueFile[] Files { get; set; }
#else
        public CueFile?[]? Files { get; set; }
#endif
    }
}
