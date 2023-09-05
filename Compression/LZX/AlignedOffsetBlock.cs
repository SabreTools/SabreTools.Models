namespace SabreTools.Models.Compression.LZX
{
    /// <summary>
    /// An aligned offset block is identical to the verbatim block except for the presence of the aligned offset
    /// tree preceding the other trees.
    /// </summary>
    /// <see href="https://interoperability.blob.core.windows.net/files/MS-PATCH/%5bMS-PATCH%5d.pdf"/>
    public class AlignedOffsetBlock
    {
        /// <summary>
        /// Generic block header
        /// </summary>
#if NET48
        public BlockHeader Header;
#else
        public BlockHeader? Header;
#endif

        /// <summary>
        /// Aligned offset tree
        /// </summary>
        /// <remarks>8 elements, 3 bits each</remarks>
#if NET48
        public byte[] AlignedOffsetTree;
#else
        public byte[]? AlignedOffsetTree;
#endif

        /// <summary>
        /// Pretree for first 256 elements of main tree
        /// </summary>
        /// <remarks>20 elements, 4 bits each</remarks>
#if NET48
        public byte[] PretreeFirst256;
#else
        public byte[]? PretreeFirst256;
#endif

        /// <summary>
        /// Path lengths of first 256 elements of main tree
        /// </summary>
        /// <remarks>Encoded using pretree</remarks>
#if NET48
        public int[] PathLengthsFirst256;
#else
        public int[]? PathLengthsFirst256;
#endif

        /// <summary>
        /// Pretree for remainder of main tree
        /// </summary>
        /// <remarks>20 elements, 4 bits each</remarks>
#if NET48
        public byte[] PretreeRemainder;
#else
        public byte[]? PretreeRemainder;
#endif

        /// <summary>
        /// Path lengths of remaining elements of main tree
        /// </summary>
        /// <remarks>Encoded using pretree</remarks>
#if NET48
        public int[] PathLengthsRemainder;
#else
        public int[]? PathLengthsRemainder;
#endif

        /// <summary>
        /// Pretree for length tree
        /// </summary>
        /// <remarks>20 elements, 4 bits each</remarks>
#if NET48
        public byte[] PretreeLengthTree;
#else
        public byte[]? PretreeLengthTree;
#endif

        /// <summary>
        /// Path lengths of elements in length tree
        /// </summary>
        /// <remarks>Encoded using pretree</remarks>
#if NET48
        public int[] PathLengthsLengthTree;
#else
        public int[]? PathLengthsLengthTree;
#endif

        // Entry                                    Comments                    Size
        // ---------------------------------------------------------------------------------------
        // Token sequence (matches and literals)    Specified in section 2.6    Variable
    }
}