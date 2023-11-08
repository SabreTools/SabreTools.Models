namespace SabreTools.Models.DVD
{
    /// <see href="https://dvd.sourceforge.net/dvdinfo/ifo_vmg.html"/>
    public sealed class ParentalManagementMasksTableEntry
    {
        /// <summary>
        /// Country code
        /// </summary>
        public ushort CountryCode { get; set; }

        /// <summary>
        /// Reserved
        /// </summary>
        public byte[]? Reserved { get; set; }

        /// <summary>
        /// Offset to PTL_MAIT
        /// </summary>
        public uint Offset { get; set; }
    }
}