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
        public byte[] Signature { get; set; }
#else
        public byte[]? Signature { get; set; }
#endif

        /// <summary>
        /// An ascending byte sequence equal to the offset mod 256 (08 09 0A ... FE FF 00 01 ... FF).
        /// </summary>
#if NET48
        public byte[] AscendingByteSequence { get; set; }
#else
        public byte[]? AscendingByteSequence { get; set; }
#endif

        /// <summary>
        /// A descending byte sequence equal to 255 minus the offset mod 256 (FF FE FD ... 00 FF DE ... 00).
        /// </summary>
#if NET48
        public byte[] DescendingByteSequence { get; set; }
#else
        public byte[]? DescendingByteSequence { get; set; }
#endif

        /// <summary>
        /// Filled with 00 (0b00000000) bytes.
        /// </summary>
#if NET48
        public byte[] Filled00 { get; set; }
#else
        public byte[]? Filled00 { get; set; }
#endif

        /// <summary>
        /// Filled with FF (0b11111111) bytes.
        /// </summary>
#if NET48
        public byte[] FilledFF { get; set; }
#else
        public byte[]? FilledFF { get; set; }
#endif

        /// <summary>
        /// Filled with 0F (0b00001111) bytes.
        /// </summary>
#if NET48
        public byte[] Filled0F { get; set; }
#else
        public byte[]? Filled0F { get; set; }
#endif

        /// <summary>
        /// Filled with F0 (0b11110000) bytes.
        /// </summary>
#if NET48
        public byte[] FilledF0 { get; set; }
#else
        public byte[]? FilledF0 { get; set; }
#endif

        /// <summary>
        /// Filled with 55 (0b01010101) bytes.
        /// </summary>
#if NET48
        public byte[] Filled55 { get; set; }
#else
        public byte[]? Filled55 { get; set; }
#endif

        /// <summary>
        /// Filled with AA (0b10101010) bytes.
        /// </summary>
#if NET48
        public byte[] FilledAA { get; set; }
#else
        public byte[]? FilledAA { get; set; }
#endif

        /// <summary>
        /// The final byte is 00 (0b00000000).
        /// </summary>
        public byte FinalByte { get; set; }
    }
}
