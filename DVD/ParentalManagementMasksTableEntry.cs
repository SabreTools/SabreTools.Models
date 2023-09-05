namespace SabreTools.Models.DVD
{
    /// <see href="https://dvd.sourceforge.net/dvdinfo/ifo_vmg.html"/>
    public sealed class ParentalManagementMasksTableEntry
    {
        /// <summary>
        /// Country code
        /// </summary>
        public ushort CountryCode;

        /// <summary>
        /// Reserved
        /// </summary>
#if NET48
        public byte[] Reserved;
#else
        public byte[]? Reserved;
#endif

        /// <summary>
        /// Offset to PTL_MAIT
        /// </summary>
        public uint Offset;
    }
}