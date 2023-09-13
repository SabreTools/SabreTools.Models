using System;
using System.Collections.Generic;
using System.IO;

/// <remarks>
/// Information sourced from http://web.archive.org/web/20070221154246/http://www.goldenhawk.com/download/cdrwin.pdf
/// </remarks>
namespace SabreTools.Models.CueSheets
{
    /// <summary>
    /// Represents a single FILE in a cuesheet
    /// </summary>
    public class CueFile
    {
        /// <summary>
        /// filename
        /// </summary>
#if NET48
        public string FileName { get; set; }
#else
        public string? FileName { get; set; }
#endif

        /// <summary>
        /// filetype
        /// </summary>
        public CueFileType FileType { get; set; }

        /// <summary>
        /// List of TRACK in FILE
        /// </summary>
#if NET48
        public CueTrack[] Tracks { get; set; }
#else
        public CueTrack?[]? Tracks { get; set; }
#endif
    }
}
