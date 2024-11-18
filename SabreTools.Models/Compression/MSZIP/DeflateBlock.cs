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
    public class DeflateBlock
    {
        /// <summary>
        /// Deflate block (RFC-1951) header
        /// </summary>
        public Deflate.BlockHeader? Header { get; set; }

        /// <summary>
        /// Compression-specific data header
        /// </summary>
        public Deflate.DataHeader? DataHeader { get; set; }

        /// <summary>
        /// MSZIP data
        /// </summary>
        /// <remarks>
        /// Depending on the implementation of these models, this property could either be
        /// compressed or uncompressed data. Keep this in mind when using the built
        /// versions of this model.
        /// </remarks>
        public byte[]? Data { get; set; }
    }
}