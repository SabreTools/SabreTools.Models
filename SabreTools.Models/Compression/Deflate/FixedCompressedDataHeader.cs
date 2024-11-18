namespace SabreTools.Models.Compression.Deflate
{
    /// <summary>
    /// Compression with fixed Huffman codes (BTYPE=01)
    /// </summary>
    /// <see href="https://interoperability.blob.core.windows.net/files/MS-MCI/%5bMS-MCI%5d.pdf"/>
    /// <see href="https://www.rfc-editor.org/rfc/rfc1951"/>
    public class FixedCompressedDataHeader : CompressedDataHeader
    {
        #region Properties

        /// <summary>
        /// Huffman code lengths for the literal / length alphabet
        /// </summary>
        public override uint[]? LiteralLengths => Constants.FixedLiteralLengths;

        /// <summary>
        /// Huffman distance codes for the literal / length alphabet
        /// </summary>
        public override uint[]? DistanceCodes => Constants.FixedDistanceCodes;

        #endregion
    }
}