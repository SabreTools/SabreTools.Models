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
#if NET48
        public byte[] Reserved { get; set; }
#else
        public byte[]? Reserved { get; set; }
#endif

        /// <summary>
        /// Offset to PTL_MAIT
        /// </summary>
        public uint Offset { get; set; }
    }
}