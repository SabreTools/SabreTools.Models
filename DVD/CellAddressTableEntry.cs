namespace SabreTools.Models.DVD
{
    /// <see href="https://dvd.sourceforge.net/dvdinfo/ifo.html"/>
    public sealed class CellAddressTableEntry
    {
        /// <summary>
        /// VOBidn
        /// </summary>
        public ushort VOBIdentity { get; set; }

        /// <summary>
        /// CELLidn
        /// </summary>
        public byte CellIdentity { get; set; }

        /// <summary>
        /// Reserved
        /// </summary>
        public byte Reserved { get; set; }

        /// <summary>
        /// Starting sector within VOB
        /// </summary>
        public uint StartingSectorWithinVOB { get; set; }

        /// <summary>
        /// Ending sector within VOB
        /// </summary>
        public uint EndingSectorWithinVOB { get; set; }
    }
}