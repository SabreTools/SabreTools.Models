namespace SabreTools.Models.Compression.Deflate
{
    /// <summary>
    /// Compression with Huffman codes (BTYPE=01 or BTYPE=02)
    /// </summary>
    /// <see href="https://interoperability.blob.core.windows.net/files/MS-MCI/%5bMS-MCI%5d.pdf"/>
    /// <see href="https://www.rfc-editor.org/rfc/rfc1951"/>
    public abstract class CompressedDataHeader : DataHeader
    {
        /// <summary>
        /// Huffman code lengths for the literal / length alphabet
        /// </summary>
        public virtual uint[]? LiteralLengths { get; set; }

        /// <summary>
        /// Huffman distance codes for the literal / length alphabet
        /// </summary>
        public virtual uint[]? DistanceCodes { get; set; }
    }
}