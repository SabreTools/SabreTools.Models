namespace SabreTools.Models.Compression.MSZIP
{
    /// <summary>
    /// Each MSZIP block is the result of a single deflate compression operation, as defined in [RFC1951].
    /// The compressor that performs the compression operation MUST generate one or more RFC 1951
    /// blocks, as defined in [RFC1951]. The number, deflation mode, and type of RFC 1951 blocks in each
    /// MSZIP block is determined by the compressor, as defined in [RFC1951]. The last RFC 1951 block in
    /// each MSZIP block MUST be marked as the "end" of the stream(1), as defined by [RFC1951]
    /// section 3.2.3. Decoding trees MUST be discarded after each RFC 1951 block, but the history buffer
    /// MUST be maintained.Each MSZIP block MUST represent no more than 32 KB of uncompressed data.
    /// </summary>
    /// <see href="https://interoperability.blob.core.windows.net/files/MS-MCI/%5bMS-MCI%5d.pdf"/>
    public class RFC1951Block
    {
        /// <summary>
        /// Compressed MSZIP data block
        /// </summary>
#if NET48
        public byte[] Data { get; set; }
#else
        public byte[]? Data { get; set; }
#endif
    }
}