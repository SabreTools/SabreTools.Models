namespace SabreTools.Models.N3DS
{
    /// <see href="https://www.3dbrew.org/wiki/NCSD#InitialData"/>
    public sealed class InitialData
    {
        /// <summary>
        /// Card seed keyY (first u64 is Media ID (same as first NCCH partitionId))
        /// </summary>
        public byte[]? CardSeedKeyY { get; set; }

        /// <summary>
        /// Encrypted card seed (AES-CCM, keyslot 0x3B for retail cards, see CTRCARD_SECSEED)
        /// </summary>
        public byte[]? EncryptedCardSeed { get; set; }

        /// <summary>
        /// Card seed AES-MAC
        /// </summary>
        public byte[]? CardSeedAESMAC { get; set; }

        /// <summary>
        /// Card seed nonce
        /// </summary>
        public byte[]? CardSeedNonce { get; set; }

        /// <summary>
        /// Reserved3
        /// </summary>
        public byte[]? Reserved { get; set; }

        /// <summary>
        /// Copy of first NCCH header (excluding RSA signature)
        /// </summary>
        public NCCHHeader? BackupHeader { get; set; }
    }
}
