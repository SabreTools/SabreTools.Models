namespace SabreTools.Models.DVD
{
    /// <see href="https://dvd.sourceforge.net/dvdinfo/ifo_vmg.html"/>
    public sealed class TitlesTable
    {
        /// <summary>
        /// Number of titles
        /// </summary>
        public ushort NumberOfTitles;

        /// <summary>
        /// Reserved
        /// </summary>
#if NET48
        public byte[] Reserved;
#else
        public byte[]? Reserved;
#endif

        /// <summary>
        /// End address (last byte of last entry)
        /// </summary>
        public uint EndAddress;

        /// <summary>
        /// 12-byte entries
        /// </summary>
#if NET48
        public TitlesTableEntry[] Entries;
#else
        public TitlesTableEntry[]? Entries;
#endif
    }
}