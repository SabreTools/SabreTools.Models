namespace SabreTools.Models.DVD
{
    /// <see href="https://dvd.sourceforge.net/dvdinfo/ifo_vmg.html"/>
    public sealed class TitlesTable
    {
        /// <summary>
        /// Number of titles
        /// </summary>
        public ushort NumberOfTitles { get; set; }

        /// <summary>
        /// Reserved
        /// </summary>
#if NET48
        public byte[] Reserved { get; set; }
#else
        public byte[]? Reserved { get; set; }
#endif

        /// <summary>
        /// End address (last byte of last entry)
        /// </summary>
        public uint EndAddress { get; set; }

        /// <summary>
        /// 12-byte entries
        /// </summary>
#if NET48
        public TitlesTableEntry[] Entries { get; set; }
#else
        public TitlesTableEntry?[]? Entries { get; set; }
#endif
    }
}