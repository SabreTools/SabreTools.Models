namespace SabreTools.Models.DVD
{
    /// <see href="https://dvd.sourceforge.net/dvdinfo/ifo.html"/>
    public sealed class AudioSubPictureAttributesTable
    {
        /// <summary>
        /// Number of title sets
        /// </summary>
        public ushort NumberOfTitleSets;

        /// <summary>
        /// Reserved
        /// </summary>
#if NET48
        public byte[] Reserved;
#else
        public byte[]? Reserved;
#endif

        /// <summary>
        /// End address (last byte of last VTS_ATRT)
        /// </summary>
        public uint EndAddress;

        /// <summary>
        /// Offset to VTS_ATRT n
        /// </summary>
#if NET48
        public uint[] Offsets;
#else
        public uint[]? Offsets;
#endif

        /// <summary>
        /// Entries
        /// </summary>
#if NET48
        public AudioSubPictureAttributesTableEntry[] Entries;
#else
        public AudioSubPictureAttributesTableEntry[]? Entries;
#endif
    }
}