namespace SabreTools.Models.N3DS
{
    /// <summary>
    /// There are 64 of these records, usually only the first is used.
    /// </summary>
    /// <see href="https://www.3dbrew.org/wiki/Title_metadata#Content_Info_Records"/>
    public sealed class ContentInfoRecord
    {
        /// <summary>
        /// Content index offset
        /// </summary>
        public ushort ContentIndexOffset { get; set; }

        /// <summary>
        /// Content command count [k]
        /// </summary>
        public ushort ContentCommandCount { get; set; }

        /// <summary>
        /// SHA-256 hash of the next k content records that have not been hashed yet
        /// </summary>
#if NET48
        public byte[] UnhashedContentRecordsSHA256Hash { get; set; }
#else
        public byte[]? UnhashedContentRecordsSHA256Hash { get; set; }
#endif
    }
}