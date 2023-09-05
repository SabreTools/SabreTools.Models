namespace SabreTools.Models.N3DS
{
    /// <see href="https://www.3dbrew.org/wiki/NCSD#InitialData"/>
    public sealed class InitialData
    {
        /// <summary>
        /// Card seed keyY (first u64 is Media ID (same as first NCCH partitionId))
        /// </summary>
#if NET48
        public byte[] CardSeedKeyY;
#else
        public byte[]? CardSeedKeyY;
#endif

        /// <summary>
        /// Encrypted card seed (AES-CCM, keyslot 0x3B for retail cards, see CTRCARD_SECSEED)
        /// </summary>
#if NET48
        public byte[] EncryptedCardSeed;
#else
        public byte[]? EncryptedCardSeed;
#endif

        /// <summary>
        /// Card seed AES-MAC
        /// </summary>
#if NET48
        public byte[] CardSeedAESMAC;
#else
        public byte[]? CardSeedAESMAC;
#endif

        /// <summary>
        /// Card seed nonce
        /// </summary>
#if NET48
        public byte[] CardSeedNonce;
#else
        public byte[]? CardSeedNonce;
#endif

        /// <summary>
        /// Reserved3
        /// </summary>
#if NET48
        public byte[] Reserved;
#else
        public byte[]? Reserved;
#endif

        /// <summary>
        /// Copy of first NCCH header (excluding RSA signature)
        /// </summary>
#if NET48
        public NCCHHeader BackupHeader;
#else
        public NCCHHeader? BackupHeader;
#endif
    }
}
