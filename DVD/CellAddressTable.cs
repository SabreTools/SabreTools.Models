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
        public byte[]? Reserved { get; set; }

        /// <summary>
        /// End address (last byte of last entry)
        /// </summary>
        public uint EndAddress { get; set; }

        /// <summary>
        /// 12-byte entries
        /// </summary>
        public CellAddressTableEntry?[]? Entries { get; set; }
    }
}