namespace SabreTools.Models.Nitro
{
    /// <summary>
    /// Nintendo DS / DSi cartridge header
    /// </summary>
    /// <see href="https://dsibrew.org/wiki/DSi_cartridge_header"/>
    public sealed class CommonHeader
    {
        /// <summary>
        /// Game Title
        /// </summary>
        public string? GameTitle { get; set; }

        /// <summary>
        /// Gamecode
        /// </summary>
        public uint GameCode { get; set; }

        /// <summary>
        /// Makercode
        /// </summary>
        public string? MakerCode { get; set; }

        /// <summary>
        /// Unitcode
        /// </summary>
        public Unitcode UnitCode { get; set; }

        /// <summary>
        /// Encryption seed select (device code. 0 = normal)
        /// </summary>
        public byte EncryptionSeedSelect { get; set; }

        /// <summary>
        /// Devicecapacity
        /// </summary>
        public byte DeviceCapacity { get; set; }

        /// <summary>
        /// Reserved
        /// </summary>
        public byte[]? Reserved1 { get; set; }

        /// <summary>
        /// Game Revision (used by DSi titles)
        /// </summary>
        public ushort GameRevision { get; set; }

        /// <summary>
        /// ROM Version
        /// </summary>
        public byte RomVersion { get; set; }

        /// <summary>
        /// Internal flags, (Bit2: Autostart)
        /// </summary>
        public byte InternalFlags { get; set; }

        /// <summary>
        /// ARM9 rom offset
        /// </summary>
        public uint ARM9RomOffset { get; set; }

        /// <summary>
        /// ARM9 entry address
        /// </summary>
        public uint ARM9EntryAddress { get; set; }

        /// <summary>
        /// ARM9 load address
        /// </summary>
        public uint ARM9LoadAddress { get; set; }

        /// <summary>
        /// ARM9 size
        /// </summary>
        public uint ARM9Size { get; set; }

        /// <summary>
        /// ARM7 rom offset
        /// </summary>
        public uint ARM7RomOffset { get; set; }

        /// <summary>
        /// ARM7 entry address
        /// </summary>
        public uint ARM7EntryAddress { get; set; }

        /// <summary>
        /// ARM7 load address
        /// </summary>
        public uint ARM7LoadAddress { get; set; }

        /// <summary>
        /// ARM7 size
        /// </summary>
        public uint ARM7Size { get; set; }

        /// <summary>
        /// File Name Table (FNT) offset
        /// </summary>
        public uint FileNameTableOffset { get; set; }

        /// <summary>
        /// File Name Table (FNT) length
        /// </summary>
        public uint FileNameTableLength { get; set; }

        /// <summary>
        /// File Allocation Table (FNT) offset
        /// </summary>
        public uint FileAllocationTableOffset { get; set; }

        /// <summary>
        /// File Allocation Table (FNT) length
        /// </summary>
        public uint FileAllocationTableLength { get; set; }

        /// <summary>
        /// File Name Table (FNT) offset
        /// </summary>
        public uint ARM9OverlayOffset { get; set; }

        /// <summary>
        /// File Name Table (FNT) length
        /// </summary>
        public uint ARM9OverlayLength { get; set; }

        /// <summary>
        /// File Name Table (FNT) offset
        /// </summary>
        public uint ARM7OverlayOffset { get; set; }

        /// <summary>
        /// File Name Table (FNT) length
        /// </summary>
        public uint ARM7OverlayLength { get; set; }

        /// <summary>
        /// Normal card control register settings (0x00416657 for OneTimePROM)
        /// </summary>
        public uint NormalCardControlRegisterSettings { get; set; }

        /// <summary>
        /// Secure card control register settings (0x081808F8 for OneTimePROM)
        /// </summary>
        public uint SecureCardControlRegisterSettings { get; set; }

        /// <summary>
        /// Icon Banner offset (NDSi same as NDS, but with new extra entries)
        /// </summary>
        public uint IconBannerOffset { get; set; }

        /// <summary>
        /// Secure area (2K) CRC
        /// </summary>
        public ushort SecureAreaCRC { get; set; }

        /// <summary>
        /// Secure transfer timeout (0x0D7E for OneTimePROM)
        /// </summary>
        public ushort SecureTransferTimeout { get; set; }

        /// <summary>
        /// ARM9 autoload
        /// </summary>
        public uint ARM9Autoload { get; set; }

        /// <summary>
        /// ARM7 autoload
        /// </summary>
        public uint ARM7Autoload { get; set; }

        /// <summary>
        /// Secure disable
        /// </summary>
        public byte[]? SecureDisable { get; set; }

        /// <summary>
        /// NTR region ROM size (excluding DSi area)
        /// </summary>
        public uint NTRRegionRomSize { get; set; }

        /// <summary>
        /// Header size
        /// </summary>
        public uint HeaderSize { get; set; }

        /// <summary>
        ///Reserved (0x88, 0x8C, 0x90 = Unknown, used by DSi)
        /// </summary>
        public byte[]? Reserved2 { get; set; }

        /// <summary>
        /// Nintendo Logo
        /// </summary>
        public byte[]? NintendoLogo { get; set; }

        /// <summary>
        /// Nintendo Logo CRC
        /// </summary>
        public ushort NintendoLogoCRC { get; set; }

        /// <summary>
        /// Header CRC
        /// </summary>
        public ushort HeaderCRC { get; set; }

        /// <summary>
        /// Debugger reserved
        /// </summary>
        public byte[]? DebuggerReserved { get; set; }
    }
}