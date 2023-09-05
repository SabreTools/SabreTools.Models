namespace SabreTools.Models.N3DS
{
    /// <summary>
    /// The test data is the same one encountered in development DS/DSi cartridges.
    /// </summary>
    /// <see href="https://www.3dbrew.org/wiki/NCSD#TestData"/>
    public sealed class TestData
    {
        /// <summary>
        /// The bytes FF 00 FF 00 AA 55 AA 55.
        /// </summary>
#if NET48
        public byte[] Signature;
#else
        public byte[]? Signature;
#endif

        /// <summary>
        /// An ascending byte sequence equal to the offset mod 256 (08 09 0A ... FE FF 00 01 ... FF).
        /// </summary>
#if NET48
        public byte[] AscendingByteSequence;
#else
        public byte[]? AscendingByteSequence;
#endif

        /// <summary>
        /// A descending byte sequence equal to 255 minus the offset mod 256 (FF FE FD ... 00 FF DE ... 00).
        /// </summary>
#if NET48
        public byte[] DescendingByteSequence;
#else
        public byte[]? DescendingByteSequence;
#endif

        /// <summary>
        /// Filled with 00 (0b00000000) bytes.
        /// </summary>
#if NET48
        public byte[] Filled00;
#else
        public byte[]? Filled00;
#endif

        /// <summary>
        /// Filled with FF (0b11111111) bytes.
        /// </summary>
#if NET48
        public byte[] FilledFF;
#else
        public byte[]? FilledFF;
#endif

        /// <summary>
        /// Filled with 0F (0b00001111) bytes.
        /// </summary>
#if NET48
        public byte[] Filled0F;
#else
        public byte[]? Filled0F;
#endif

        /// <summary>
        /// Filled with F0 (0b11110000) bytes.
        /// </summary>
#if NET48
        public byte[] FilledF0;
#else
        public byte[]? FilledF0;
#endif

        /// <summary>
        /// Filled with 55 (0b01010101) bytes.
        /// </summary>
#if NET48
        public byte[] Filled55;
#else
        public byte[]? Filled55;
#endif

        /// <summary>
        /// Filled with AA (0b10101010) bytes.
        /// </summary>
#if NET48
        public byte[] FilledAA;
#else
        public byte[]? FilledAA;
#endif

        /// <summary>
        /// The final byte is 00 (0b00000000).
        /// </summary>
        public byte FinalByte;
    }
}
