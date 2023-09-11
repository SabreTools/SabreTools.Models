namespace SabreTools.Models.N3DS
{
    /// <see href="https://www.3dbrew.org/wiki/NCSD#InitialData"/>
    public sealed class InitialData
    {
        /// <summary>
        /// Card seed keyY (first u64 is Media ID (same as first NCCH partitionId))
        /// </summary>
#if NET48
        public byte[] CardSeedKeyY { get; set; }
#else
        public byte[]? CardSeedKeyY { get; set; }
#endif

        /// <summary>
        /// Encrypted card seed (AES-CCM, keyslot 0x3B for retail cards, see CTRCARD_SECSEED)
        /// </summary>
#if NET48
        public byte[] EncryptedCardSeed { get; set; }
#else
        public byte[]? EncryptedCardSeed { get; set; }
#endif

        /// <summary>
        /// Card seed AES-MAC
        /// </summary>
#if NET48
        public byte[] CardSeedAESMAC { get; set; }
#else
        public byte[]? CardSeedAESMAC { get; set; }
#endif

        /// <summary>
        /// Card seed nonce
        /// </summary>
#if NET48
        public byte[] CardSeedNonce { get; set; }
#else
        public byte[]? CardSeedNonce { get; set; }
#endif

        /// <summary>
        /// Reserved3
        /// </summary>
#if NET48
        public byte[] Reserved { get; set; }
#else
        public byte[]? Reserved { get; set; }
#endif

        /// <summary>
        /// Copy of first NCCH header (excluding RSA signature)
        /// </summary>
#if NET48
        public NCCHHeader BackupHeader { get; set; }
#else
        public NCCHHeader? BackupHeader { get; set; }
#endif
    }
}
