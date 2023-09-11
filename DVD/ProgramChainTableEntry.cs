namespace SabreTools.Models.DVD
{
    /// <see href="https://dvd.sourceforge.net/dvdinfo/ifo_vmg.html"/>
    public sealed class ProgramChainTableEntry
    {
        /// <summary>
        /// PGC category
        /// </summary>
        public ProgramChainCategory Category { get; set; }

        /// <summary>
        /// Unknown
        /// </summary>
        public byte Unknown { get; set; }

        /// <summary>
        /// Parental management mask
        /// </summary>
        public ushort ParentalManagementMask { get; set; }

        /// <summary>
        /// Offset to VMGM_PGC, relative to VMGM_LU
        /// </summary>
        public uint Offset { get; set; }
    }
}