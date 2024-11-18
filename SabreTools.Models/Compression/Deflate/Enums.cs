namespace SabreTools.Models.Compression.Deflate
{
    /// <see href="https://www.rfc-editor.org/rfc/rfc1951"/>
    public enum CompressionType : byte
    {
        /// <summary>
        /// no compression
        /// </summary>
        NoCompression = 0b00,

        /// <summary>
        /// Compressed with fixed Huffman codes
        /// </summary>
        FixedHuffman = 0b01,

        /// <summary>
        /// Compressed with dynamic Huffman codes
        /// </summary>
        DynamicHuffman = 0b10,

        /// <summary>
        /// Reserved (error)
        /// </summary>
        Reserved = 0b11,
    }
}