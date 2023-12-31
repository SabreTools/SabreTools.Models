namespace SabreTools.Models.DVD
{
    /// <see href="https://dvd.sourceforge.net/dvdinfo/ifo_vmg.html"/>
    public sealed class LanguageUnitTableEntry
    {
        /// <summary>
        /// 	ISO639 language code
        /// </summary>
        public ushort ISO639LanguageCode { get; set; }

        /// <summary>
        /// Reserved for language code extension
        /// </summary>
        public byte Reserved { get; set; }

        /// <summary>
        /// Menu existence flag [80 = title]
        /// </summary>
        public byte MenuExistenceFlag { get; set; }

        /// <summary>
        /// Offset to VMGM_LU, relative to VMGM_PGCI_UT
        /// </summary>
        public uint LanguageUnitOffset { get; set; }
    }
}