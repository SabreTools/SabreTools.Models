namespace SabreTools.Models.MicrosoftCabinet
{
    /// <summary>
    /// Cabinet files are compressed packages containing a
    /// number of related files.The format of a cabinet file is optimized for maximum compression. Cabinet
    /// files support a number of compression formats, including MSZIP, LZX, or uncompressed. This
    /// document does not specify these internal compression formats.
    /// </summary>
    /// <see href="http://download.microsoft.com/download/5/0/1/501ED102-E53F-4CE0-AA6B-B0F93629DDC6/Exchange/%5BMS-CAB%5D.pdf"/>
    public sealed class Cabinet
    {
        /// <summary>
        /// Cabinet header
        /// </summary>
#if NET48
        public CFHEADER Header { get; set; }
#else
        public CFHEADER? Header { get; set; }
#endif

        /// <summary>
        /// One or more CFFOLDER entries
        /// </summary>
#if NET48
        public CFFOLDER[] Folders { get; set; }
#else
        public CFFOLDER?[]? Folders { get; set; }
#endif

        /// <summary>
        /// A series of one or more cabinet file (CFFILE) entries
        /// </summary>
#if NET48
        public CFFILE[] Files { get; set; }
#else
        public CFFILE?[]? Files { get; set; }
#endif
    }
}
