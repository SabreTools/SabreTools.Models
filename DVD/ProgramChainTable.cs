namespace SabreTools.Models.DVD
{
    /// <see href="https://dvd.sourceforge.net/dvdinfo/ifo_vmg.html"/>
    public sealed class ProgramChainTable
    {
        /// <summary>
        /// Number of Program Chains
        /// </summary>
        public ushort NumberOfProgramChains { get; set; }

        /// <summary>
        /// Reserved
        /// </summary>
#if NET48
        public byte[] Reserved { get; set; }
#else
        public byte[]? Reserved { get; set; }
#endif

        /// <summary>
        /// End address (last byte of last PGC in this LU)
        /// relative to VMGM_LU
        /// </summary>
        public uint EndAddress { get; set; }

        /// <summary>
        /// Program Chains
        /// </summary>
#if NET48
        public ProgramChainTableEntry[] Entries { get; set; }
#else
        public ProgramChainTableEntry?[]? Entries { get; set; }
#endif
    }
}