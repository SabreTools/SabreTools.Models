using System;

namespace SabreTools.Models.Compression.MSZIP
{
    /// <summary>
    /// Compression with fixed Huffman codes (BTYPE=01)
    /// </summary>
    /// <see href="https://interoperability.blob.core.windows.net/files/MS-MCI/%5bMS-MCI%5d.pdf"/>
    /// <see href="https://www.rfc-editor.org/rfc/rfc1951"/>
    public class FixedHuffmanCompressedBlockHeader : CompressedBlockHeader
    {
        #region Properties

        /// <summary>
        /// Huffman code lengths for the literal / length alphabet
        /// </summary>
#if NET48
        public override uint[] LiteralLengths
#else
        public override uint[]? LiteralLengths
#endif
        {
            get
            {
                // If we have cached lengths, use those
                if (_literalLengths != null)
                    return _literalLengths;

                // Otherwise, build it from scratch
                _literalLengths = new uint[288];

                // Literal Value 0 - 143, 8 bits
                for (int i = 0; i < 144; i++)
                    _literalLengths[i] = 8;

                // Literal Value 144 - 255, 9 bits
                for (int i = 144; i < 256; i++)
                    _literalLengths[i] = 9;

                // Literal Value 256 - 279, 7 bits
                for (int i = 256; i < 280; i++)
                    _literalLengths[i] = 7;

                // Literal Value 280 - 287, 8 bits
                for (int i = 280; i < 288; i++)
                    _literalLengths[i] = 8;

                return _literalLengths;
            }
            set
            {
                throw new FieldAccessException();
            }
        }

        /// <summary>
        /// Huffman distance codes for the literal / length alphabet
        /// </summary>
#if NET48
        public override uint[] DistanceCodes
#else
        public override uint[]? DistanceCodes
#endif
        {
            get
            {
                // If we have cached distances, use those
                if (_distanceCodes != null)
                    return _distanceCodes;

                // Otherwise, build it from scratch
                _distanceCodes = new uint[30];

                // Fixed length, 5 bits
                for (int i = 0; i < 30; i++)
                    _distanceCodes[i] = 5;

                return _distanceCodes;
            }
            set
            {
                throw new FieldAccessException();
            }
        }

        #endregion

        #region Instance Variables

        /// <summary>
        /// Huffman code lengths for the literal / length alphabet
        /// </summary>
#if NET48
        private uint[] _literalLengths = null;
#else
        private uint[]? _literalLengths = null;
#endif

        /// <summary>
        /// Huffman distance codes for the literal / length alphabet
        /// </summary>
#if NET48
        private uint[] _distanceCodes = null;
#else
        private uint[]? _distanceCodes = null;
#endif

        #endregion
    }
}