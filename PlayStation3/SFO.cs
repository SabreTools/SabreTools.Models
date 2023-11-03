namespace SabreTools.Models.PlayStation3
{
    /// <see href="https://psdevwiki.com/ps3/PARAM.SFO"/> 
    public class SFO
    {
        /// <summary>
        /// SFO header
        /// </summary>
#if NET48
        public SFOHeader Header { get; set; }
#else
        public SFOHeader? Header { get; set; }
#endif

        /// <summary>
        /// Index table
        /// </summary>
#if NET48
        public SFOIndexTableEntry[] IndexTable { get; set; }
#else
        public SFOIndexTableEntry[]? IndexTable { get; set; }
#endif

        /// <summary>
        /// Key table
        /// </summary>
        /// <remarks>
        /// Composed by a number of key entries defined with tables_entries in
        /// the header, are short utf8 strings in capitals, NULL terminated
        /// (0x00), and ordered alphabetically (from A to Z). This alphabetically
        /// order defines the order of the associated entries in the other
        /// two tables (index_table, and data_table)
        /// 
        /// The end offset of this table needs to be aligned to a multiply of
        /// 32bits (4 bytes), this is made with a padding at the end of key_table
        /// when needed (in a few SFO's the table is aligned naturally as a
        /// coincidence caused by the length of the key names used, when this
        /// happens there is no padding needed) 
        /// </remarks>
#if NET48
        public string[] KeyTable { get; set; }
#else
        public string[]? KeyTable { get; set; }
#endif

        /// <summary>
        /// Padding
        /// </summary>
        /// <remarks>Enough bytes to align to 4 bytes</remarks>
#if NET48
        public byte[] Padding { get; set; }
#else
        public byte[]? Padding { get; set; }
#endif

        /// <summary>
        /// Data table
        /// </summary>
        /// <remarks>
        /// Composed by a number of data entries defined with tables_entries in
        /// the header, every entry in this table is defined by the associated entry
        /// in the index_table by using: fmt, len, max_len, and offset. There is
        /// no padding between entries neither at the end of this table
        /// 
        /// Some data entries can be filled with zeroes (not used, but availables for
        /// being used). This entries can be considered reserved, and are marked with
        /// a len = 0 in the associated entry in the index_table
        /// </remarks>
#if NET48
        public byte[][] DataTable { get; set; }
#else
        public byte[][]? DataTable { get; set; }
#endif
    }
}
