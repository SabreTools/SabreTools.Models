namespace SabreTools.Models.DVD
{
    /// <see href="https://dvd.sourceforge.net/dvdinfo/ifo_vmg.html"/>
    public sealed class LanguageUnitTable
    {
        /// <summary>
        /// Number of Language Units
        /// </summary>
        public ushort NumberOfLanguageUnits { get; set; }

        /// <summary>
        /// Reserved
        /// </summary>
#if NET48
        public byte[] Reserved { get; set; }
#else
        public byte[]? Reserved { get; set; }
#endif

        /// <summary>
        /// End address (last byte of last PGC in last LU)
        /// relative to VMGM_PGCI_UT
        /// </summary>
        public uint EndAddress { get; set; }

        /// <summary>
        /// Language Units
        /// </summary>
#if NET48
        public LanguageUnitTableEntry[] Entries { get; set; }
#else
        public LanguageUnitTableEntry?[]? Entries { get; set; }
#endif

        /// <summary>
        /// Program Chains
        /// </summary>
#if NET48
        public ProgramChainTable[] ProgramChains { get; set; }
#else
        public ProgramChainTable?[]? ProgramChains { get; set; }
#endif
    }
}