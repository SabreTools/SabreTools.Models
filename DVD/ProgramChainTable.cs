namespace SabreTools.Models.DVD
{
    /// <see href="https://dvd.sourceforge.net/dvdinfo/ifo_vmg.html"/>
    public sealed class ProgramChainTable
    {
        /// <summary>
        /// Number of Program Chains
        /// </summary>
        public ushort NumberOfProgramChains;

        /// <summary>
        /// Reserved
        /// </summary>
#if NET48
        public byte[] Reserved;
#else
        public byte[]? Reserved;
#endif

        /// <summary>
        /// End address (last byte of last PGC in this LU)
        /// relative to VMGM_LU
        /// </summary>
        public uint EndAddress;

        /// <summary>
        /// Program Chains
        /// </summary>
#if NET48
        public ProgramChainTableEntry[] Entries;
#else
        public ProgramChainTableEntry[]? Entries;
#endif
    }
}