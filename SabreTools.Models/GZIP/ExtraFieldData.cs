namespace SabreTools.Models.GZIP
{
    /// <see href="https://www.ietf.org/rfc/rfc1952.txt"/> 
    public sealed class ExtraFieldData
    {
        /// <summary>
        /// SI1 and SI2 provide a subfield ID, typically two ASCII letters
        /// with some mnemonic value.
        /// </summary>
        public byte SI1;

        /// <summary>
        /// SI1 and SI2 provide a subfield ID, typically two ASCII letters
        /// with some mnemonic value.
        /// </summary>
        public byte SI2;

        /// <summary>
        /// LEN gives the length of the subfield data, excluding the 4
        /// initial bytes.
        /// </summary>
        public ushort LEN;

        public byte[]? Data;
    }
}