namespace SabreTools.Models.N3DS
{
    /// <see href="https://www.3dbrew.org/wiki/NCSD#Card_Info_Header"/>
    public sealed class CardInfoHeader
    {
        /// <summary>
        /// CARD2: Writable Address In Media Units (For 'On-Chip' Savedata). CARD1: Always 0xFFFFFFFF.
        /// </summary>
        public uint WritableAddressMediaUnits;

        /// <summary>
        /// Card Info Bitmask
        /// </summary>
        public uint CardInfoBitmask;

        /// <summary>
        /// Reserved
        /// </summary>
#if NET48
        public byte[] Reserved1;
#else
        public byte[]? Reserved1;
#endif

        /// <summary>
        /// Filled size of cartridge
        /// </summary>
        public uint FilledSize;

        /// <summary>
        /// Reserved
        /// </summary>
#if NET48
        public byte[] Reserved2;
#else
        public byte[]? Reserved2;
#endif

        /// <summary>
        /// Title version
        /// </summary>
        public ushort TitleVersion;

        /// <summary>
        /// Card revision
        /// </summary>
        public ushort CardRevision;

        /// <summary>
        /// Reserved
        /// </summary>
#if NET48
        public byte[] Reserved3;
#else
        public byte[]? Reserved3;
#endif

        /// <summary>
        /// Title ID of CVer in included update partition
        /// </summary>
#if NET48
        public byte[] CVerTitleID;
#else
        public byte[]? CVerTitleID;
#endif

        /// <summary>
        /// Version number of CVer in included update partition
        /// </summary>
        public ushort CVerVersionNumber;

        /// <summary>
        /// Reserved
        /// </summary>
#if NET48
        public byte[] Reserved4;
#else
        public byte[]? Reserved4;
#endif
    }
}
