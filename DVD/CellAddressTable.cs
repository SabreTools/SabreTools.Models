namespace SabreTools.Models.DVD
{
    /// <see href="https://dvd.sourceforge.net/dvdinfo/ifo.html"/>
    public sealed class CellAddressTable
    {
        /// <summary>
        /// Number of VOB IDs
        /// </summary>
        public ushort NumberOfVOBIDs;

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
        public CellAddressTableEntry[] Entries;
#else
        public CellAddressTableEntry?[]? Entries;
#endif
    }
}