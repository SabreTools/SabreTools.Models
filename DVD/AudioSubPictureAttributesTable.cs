namespace SabreTools.Models.DVD
{
    /// <see href="https://dvd.sourceforge.net/dvdinfo/ifo.html"/>
    public sealed class AudioSubPictureAttributesTable
    {
        /// <summary>
        /// Number of title sets
        /// </summary>
        public ushort NumberOfTitleSets { get; set; }

        /// <summary>
        /// Reserved
        /// </summary>
#if NET48
        public byte[] Reserved { get; set; }
#else
        public byte[]? Reserved { get; set; }
#endif

        /// <summary>
        /// End address (last byte of last VTS_ATRT)
        /// </summary>
        public uint EndAddress { get; set; }

        /// <summary>
        /// Offset to VTS_ATRT n
        /// </summary>
#if NET48
        public uint[] Offsets { get; set; }
#else
        public uint[]? Offsets { get; set; }
#endif

        /// <summary>
        /// Entries
        /// </summary>
#if NET48
        public AudioSubPictureAttributesTableEntry[] Entries { get; set; }
#else
        public AudioSubPictureAttributesTableEntry?[]? Entries { get; set; }
#endif
    }
}