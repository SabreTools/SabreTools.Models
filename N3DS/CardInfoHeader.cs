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
        public byte[]? Reserved1 { get; set; }

        /// <summary>
        /// Filled size of cartridge
        /// </summary>
        public uint FilledSize { get; set; }

        /// <summary>
        /// Reserved
        /// </summary>
        public byte[]? Reserved2 { get; set; }

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
        public byte[]? Reserved3 { get; set; }

        /// <summary>
        /// Title ID of CVer in included update partition
        /// </summary>
        public byte[]? CVerTitleID { get; set; }

        /// <summary>
        /// Version number of CVer in included update partition
        /// </summary>
        public ushort CVerVersionNumber { get; set; }

        /// <summary>
        /// Reserved
        /// </summary>
        public byte[]? Reserved4 { get; set; }
    }
}
