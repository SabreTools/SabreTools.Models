namespace SabreTools.Models.N3DS
{
    #region Standard 3DS Keys

    public class Keys
    {
        /// <summary>
        /// AES Hardware Constant
        /// </summary>
        public byte[]? AESHardwareConstant { get; private set; }

        /// <summary>
        /// KeyX 0x18 (New 3DS 9.3)
        /// </summary>
        public byte[]? KeyX0x18 { get; private set; }

        /// <summary>
        /// Dev KeyX 0x18 (New 3DS 9.3)
        /// </summary>
        public byte[]? DevKeyX0x18 { get; private set; }

        /// <summary>
        /// KeyX 0x1B (New 3DS 9.6)
        /// </summary>
        public byte[]? KeyX0x1B { get; private set; }

        /// <summary>
        /// Dev KeyX 0x1B (New 3DS 9.6)
        /// </summary>
        public byte[]? DevKeyX0x1B { get; private set; }

        /// <summary>
        /// KeyX 0x25 (> 7.x)
        /// </summary>
        public byte[]? KeyX0x25 { get; private set; }

        /// <summary>
        /// Dev KeyX 0x25 (> 7.x)
        /// </summary>
        public byte[]? DevKeyX0x25 { get; private set; }

        /// <summary>
        /// KeyX 0x2C (< 6.x)
        /// </summary>
        public byte[]? KeyX0x2C { get; private set; }

        /// <summary>
        /// Dev KeyX 0x2C (< 6.x)
        /// </summary>
        public byte[]? DevKeyX0x2C { get; private set; }

        #endregion

        #region Extended Keys for CIA Decryption

        /// <summary>
        /// KeyX 0x3D (Common Key)
        /// </summary>
        public byte[]? KeyX03D { get; private set; }

        /// <summary>
        /// Dev KeyX 0x3D (Common Key)
        /// </summary>
        public byte[]? DevKeyX03D { get; private set; }

        /// <summary>
        /// KeyX 0x3B (CTR Card hardware crypto seed)
        /// </summary>
        public byte[]? KeyX03B { get; private set; }

        /// <summary>
        /// Dev KeyX 0x3B (CTR Card hardware crypto seed)
        /// </summary>
        public byte[]? DevKeyX03B { get; private set; }

        #endregion

        #region AES KeyY0x3D keys

        /// <summary>
        /// AES KeyY 0x3D array (Common Key)
        /// </summary>
        public byte[][]? AESKeyY0x3D { get; private set; }

        /// <summary>
        /// Dev AES KeyY 0x3D array (Common Key)
        /// </summary>
        public byte[][]? DevAESKeyY0x3D { get; private set; }

        #endregion

        #region SeedDB Key

        /// <summary>
        /// SeedDB key
        /// The SeedDB key is used for decrypting content that utilizes the SeedDB encryption method,
        /// which is often employed in downloadable content and updates on the 3DS platform.
        /// This key is not universal and may vary based on the specific content or title.
        /// </summary>
        public byte[]? SeedDBKey { get; private set; }

        #endregion
    }
}