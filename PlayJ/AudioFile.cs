namespace SabreTools.Models.PlayJ
{
    /// <summary>
    /// PlayJ audio file / CDS entry
    /// <summary>
    public sealed class AudioFile
    {
        /// <summary>
        /// Header
        /// </summary>
#if NET48
        public AudioHeader Header { get; set; }
#else
        public AudioHeader? Header { get; set; }
#endif

        /// <summary>
        /// Unknown block 1
        /// </summary>
#if NET48
        public UnknownBlock1 UnknownBlock1 { get; set; }
#else
        public UnknownBlock1? UnknownBlock1 { get; set; }
#endif

        #region V1 Only

        /// <summary>
        /// Value referred to by <see cref="AudioHeaderV1.UnknownOffset2"/>
        /// </summary>
        /// <remarks>Typically 0x00000000</remarks>
        public uint UnknownValue2 { get; set; }

        /// <summary>
        /// Unknown block 3 (V1 only)
        /// </summary>
#if NET48
        public UnknownBlock3 UnknownBlock3 { get; set; }
#else
        public UnknownBlock3? UnknownBlock3 { get; set; }
#endif

        #endregion

        #region V2 Only

        /// <summary>
        /// Number of data files embedded
        /// </summary>
        public uint DataFilesCount { get; set; }

        /// <summary>
        /// Data files (V2 only)
        /// </summary>
#if NET48
        public DataFile[] DataFiles { get; set; }
#else
        public DataFile?[]? DataFiles { get; set; }
#endif

        // After the data files is a block starting with 0x00000001
        // This block then contains highly repeating data, possible audio samples?

        #endregion
    }
}