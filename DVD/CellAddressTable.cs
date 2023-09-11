namespace SabreTools.Models.DVD
{
    /// <see href="https://dvd.sourceforge.net/dvdinfo/ifo.html"/>
    public sealed class CellAddressTable
    {
        /// <summary>
        /// Number of VOB IDs
        /// </summary>
        public ushort NumberOfVOBIDs { get; set; }

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
        public CellAddressTableEntry[] Entries { get; set; }
#else
        public CellAddressTableEntry?[]? Entries { get; set; }
#endif
    }
}