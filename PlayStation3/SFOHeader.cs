namespace SabreTools.Models.PlayStation3
{
    /// <see href="https://psdevwiki.com/ps3/PARAM.SFO"/> 
    public class SFOHeader
    {
        /// <summary>
        /// "\0PSF"
        /// </summary>
        public byte[]? Magic { get; set; }

        /// <summary>
        /// Version
        /// </summary>
        public uint Version { get; set; }

        /// <summary>
        /// Absolute start offset of key_table
        /// </summary>
        public uint KeyTableStart { get; set; }

        /// <summary>
        /// Absolute start offset of data_table
        /// </summary>
        public uint DataTableStart { get; set; }

        /// <summary>
        /// Number of entries in index_table, key_table, and data_table
        /// </summary>
        public uint TablesEntries { get; set; }
    }
}
