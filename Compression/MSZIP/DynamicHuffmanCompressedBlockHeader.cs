namespace SabreTools.Models.Compression.MSZIP
{
    /// <summary>
    /// Compression with dynamic Huffman codes (BTYPE=10)
    /// </summary>
    /// <see href="https://www.rfc-editor.org/rfc/rfc1951"/>
    public class DynamicHuffmanCompressedBlockHeader
    {
        /// <summary>
        /// Huffman code lengths for the literal / length alphabet
        /// </summary>
#if NET48
        public int[] LiteralLengths { get; set; }
#else
        public int[]? LiteralLengths { get; set; }
#endif

        /// <summary>
        /// Huffman distance codes for the literal / length alphabet
        /// </summary>
#if NET48
        public int[] DistanceCodes { get; set; }
#else
        public int[]? DistanceCodes { get; set; }
#endif
    }
}