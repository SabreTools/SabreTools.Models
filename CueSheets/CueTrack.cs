/// <remarks>
/// Information sourced from http://web.archive.org/web/20070221154246/http://www.goldenhawk.com/download/cdrwin.pdf
/// </remarks>
namespace SabreTools.Models.CueSheets
{
    /// <summary>
    /// Represents a single TRACK in a FILE
    /// </summary>
    public class CueTrack
    {
        /// <summary>
        /// Track number. The range is 1 to 99.
        /// </summary>
        public int Number { get; set; }

        /// <summary>
        /// Track datatype
        /// </summary>
        public CueTrackDataType DataType { get; set; }

        /// <summary>
        /// FLAGS
        /// </summary>
        public CueTrackFlag Flags { get; set; }

        /// <summary>
        /// ISRC
        /// </summary>
        /// <remarks>12 characters in length</remarks>
#if NET48
        public string ISRC { get; set; }
#else
        public string? ISRC { get; set; }
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
        /// PREGAP
        /// </summary>
#if NET48
        public PreGap PreGap { get; set; }
#else
        public PreGap? PreGap { get; set; }
#endif

        /// <summary>
        /// List of INDEX in TRACK
        /// </summary>
        /// <remarks>Must start with 0 or 1 and then sequential</remarks>
#if NET48
        public CueIndex[] Indices { get; set; }
#else
        public CueIndex?[]? Indices { get; set; }
#endif

        /// <summary>
        /// POSTGAP
        /// </summary>
#if NET48
        public PostGap PostGap { get; set; }
#else
        public PostGap? PostGap { get; set; }
#endif
    }
}
