using System.Collections.Generic;

namespace SabreTools.Models.Charts
{
    /// <see href="https://github.com/TheNathannator/GuitarGame_ChartFormats/blob/main/doc/FileFormats/Other/Frets%20on%20Fire%20X/Careers.md"/> 
    /// <remarks>[titles]</remarks>
    internal class TitlesIni
    {
        /// <summary>
        /// A space-separated list of .ini sections to include in the career.
        /// </summary>
        /// <remarks>sections</remarks>
#if NET48
        public string[] SectionList { get; set; }
#else
        public string[]? SectionList { get; set; }
#endif

        /// <summary>
        /// `name` - Display name of the tier.
        /// `unlock_id` - Name used for associating a song with this tier, and for checking unlock requirements.
        /// </summary>
#if NET48
        public Dictionary<string, (string Name, string UnlockId)> Sections { get; set; }
#else
        public Dictionary<string, (string Name, string UnlockId)>? Sections { get; set; }
#endif
    }
}