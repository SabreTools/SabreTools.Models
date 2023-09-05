namespace SabreTools.Models.DVD
{
    /// <see href="https://dvd.sourceforge.net/dvdinfo/ifo_vmg.html"/>
    public sealed class LanguageUnitTable
    {
        /// <summary>
        /// Number of Language Units
        /// </summary>
        public ushort NumberOfLanguageUnits;

        /// <summary>
        /// Reserved
        /// </summary>
#if NET48
        public byte[] Reserved;
#else
        public byte[]? Reserved;
#endif

        /// <summary>
        /// End address (last byte of last PGC in last LU)
        /// relative to VMGM_PGCI_UT
        /// </summary>
        public uint EndAddress;

        /// <summary>
        /// Language Units
        /// </summary>
#if NET48
        public LanguageUnitTableEntry[] Entries;
#else
        public LanguageUnitTableEntry[]? Entries;
#endif

        /// <summary>
        /// Program Chains
        /// </summary>
#if NET48
        public ProgramChainTable[] ProgramChains;
#else
        public ProgramChainTable[]? ProgramChains;
#endif
    }
}