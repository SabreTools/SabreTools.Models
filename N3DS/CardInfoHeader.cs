namespace SabreTools.Models.N3DS
{
    /// <see href="https://www.3dbrew.org/wiki/NCSD#Card_Info_Header"/>
    public sealed class CardInfoHeader
    {
        /// <summary>
        /// CARD2: Writable Address In Media Units (For 'On-Chip' Savedata). CARD1: Always 0xFFFFFFFF.
        /// </summary>
        public uint WritableAddressMediaUnits { get; set; }

        /// <summary>
        /// Card Info Bitmask
        /// </summary>
        public uint CardInfoBitmask { get; set; }

        /// <summary>
        /// Reserved
        /// </summary>
#if NET48
        public byte[] Reserved1 { get; set; }
#else
        public byte[]? Reserved1 { get; set; }
#endif

        /// <summary>
        /// Filled size of cartridge
        /// </summary>
        public uint FilledSize { get; set; }

        /// <summary>
        /// Reserved
        /// </summary>
#if NET48
        public byte[] Reserved2 { get; set; }
#else
        public byte[]? Reserved2 { get; set; }
#endif

        /// <summary>
        /// Title version
        /// </summary>
        public ushort TitleVersion { get; set; }

        /// <summary>
        /// Card revision
        /// </summary>
        public ushort CardRevision { get; set; }

        /// <summary>
        /// Reserved
        /// </summary>
#if NET48
        public byte[] Reserved3 { get; set; }
#else
        public byte[]? Reserved3 { get; set; }
#endif

        /// <summary>
        /// Title ID of CVer in included update partition
        /// </summary>
#if NET48
        public byte[] CVerTitleID { get; set; }
#else
        public byte[]? CVerTitleID { get; set; }
#endif

        /// <summary>
        /// Version number of CVer in included update partition
        /// </summary>
        public ushort CVerVersionNumber { get; set; }

        /// <summary>
        /// Reserved
        /// </summary>
#if NET48
        public byte[] Reserved4 { get; set; }
#else
        public byte[]? Reserved4 { get; set; }
#endif
    }
}
