namespace SabreTools.Models.DVD
{
    /// <see href="https://dvd.sourceforge.net/dvdinfo/ifo_vmg.html"/>
    public sealed class TitlesTableEntry
    {
        /// <summary>
        /// Title type
        /// </summary>
        public TitleType TitleType { get; set; }

        /// <summary>
        /// Number of angles
        /// </summary>
        public byte NumberOfAngles { get; set; }

        /// <summary>
        /// Number of chapters (PTTs)
        /// </summary>
        public ushort NumberOfChapters { get; set; }

        /// <summary>
        /// Parental management mask
        /// </summary>
        public ushort ParentalManagementMask { get; set; }

        /// <summary>
        /// Video Title Set number (VTSN)
        /// </summary>
        public byte VideoTitleSetNumber { get; set; }

        /// <summary>
        /// Title number within VTS (VTS_TTN)
        /// </summary>
        public byte TitleNumberWithinVTS { get; set; }

        /// <summary>
        /// Start sector for VTS, referenced to whole disk
        /// (video_ts.ifo starts at sector 00000000)
        /// </summary>
        public uint VTSStartSector { get; set; }
    }
}