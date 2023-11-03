namespace SabreTools.Models.PlayStation3
{
    /// <see href="https://psdevwiki.com/ps3/PARAM.SFO"/> 
    public class SFOIndexTableEntry
    {
        /// <summary>
        /// Key relative offset.
        /// (Absolute start offset of key) - (Absolute start offset of key_table)
        /// </summary>
        public ushort KeyOffset { get; set; }

        /// <summary>
        /// Data type
        /// </summary>
        public DataFormat DataFormat { get; set; } 

        /// <summary>
        /// Data used length
        /// </summary>
        public uint DataLength { get; set; } 

        /// <summary>
        /// Data total length. TITLE_ID is always = 16 bytes
        /// </summary>
        public uint DataMaxLength { get; set; }

        /// <summary>
        /// Data relative offset.
        /// (Absolute start offset of data_1) - (Absolute start offset of data_table)
        /// </summary>
        public uint DataOffset { get; set; }
    }
}
