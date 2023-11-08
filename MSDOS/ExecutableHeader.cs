namespace SabreTools.Models.MSDOS
{
    /// <summary>
    /// MZ executables only consists of 2 structures: the header and the relocation table.
    /// The header, which is followed by the program image, looks like this.
    /// </summary>
    /// <see href="https://wiki.osdev.org/MZ"/>
    /// <see href="http://www.pinvoke.net/default.aspx/Structures.IMAGE_DOS_HEADER"/>
    public sealed class ExecutableHeader
    {
        #region Standard Fields

        /// <summary>
        /// 0x5A4D (ASCII for 'M' and 'Z')
        /// </summary>
        public string? Magic { get; set; }

        /// <summary>
        /// Number of bytes in the last page.
        /// </summary>
        public ushort LastPageBytes { get; set; }

        /// <summary>
        /// Number of whole/partial pages.
        /// </summary>
        /// <remarks>A page (or block) is 512 bytes long.</remarks>
        public ushort Pages { get; set; }

        /// <summary>
        /// Number of entries in the relocation table.
        /// </summary>
        public ushort RelocationItems { get; set; }

        /// <summary>
        /// The number of paragraphs taken up by the header. It can be any value, as the loader
        /// just uses it to find where the actual executable data starts. It may be larger than
        /// what the "standard" fields take up, and you may use it if you want to include your
        /// own header metadata, or put the relocation table there, or use it for any other purpose. [08]
        /// </summary>
        /// <remarks>A paragraph is 16 bytes in size</remarks>
        public ushort HeaderParagraphSize { get; set; }

        /// <summary>
        /// The number of paragraphs required by the program, excluding the PSP and program image.
        /// If no free block is big enough, the loading stops.
        /// </summary>
        /// <remarks>A paragraph is 16 bytes in size</remarks>
        public ushort MinimumExtraParagraphs { get; set; }

        /// <summary>
        /// The number of paragraphs requested by the program.
        /// If no free block is big enough, the biggest one possible is allocated.
        /// </summary>
        /// <remarks>A paragraph is 16 bytes in size</remarks>
        public ushort MaximumExtraParagraphs { get; set; }

        /// <summary>
        /// Relocatable segment address for SS.
        /// </summary>
        public ushort InitialSSValue { get; set; }

        /// <summary>
        /// Initial value for SP.
        /// </summary>
        public ushort InitialSPValue { get; set; }

        /// <summary>
        /// When added to the sum of all other words in the file, the result should be zero.
        /// </summary>
        public ushort Checksum { get; set; }

        /// <summary>
        /// Initial value for IP. [14]
        /// </summary>
        public ushort InitialIPValue { get; set; }

        /// <summary>
        /// Relocatable segment address for CS.
        /// </summary>
        public ushort InitialCSValue { get; set; }

        /// <summary>
        /// The (absolute) offset to the relocation table.
        /// </summary>
        public ushort RelocationTableAddr { get; set; }

        /// <summary>
        /// Value used for overlay management.
        /// If zero, this is the main executable.
        /// </summary>
        public ushort OverlayNumber { get; set; }

        #endregion

        #region PE Extensions

        /// <summary>
        /// Reserved words
        /// </summary>
        public ushort[]? Reserved1 { get; set; } = new ushort[4];

        /// <summary>
        /// Defined by name but no other information is given; typically zeroes
        /// </summary>
        public ushort OEMIdentifier { get; set; }

        /// <summary>
        /// Defined by name but no other information is given; typically zeroes
        /// </summary>
        public ushort OEMInformation { get; set; }

        /// <summary>
        /// Reserved words
        /// </summary>
        public ushort[]? Reserved2 { get; set; } = new ushort[10];

        /// <summary>
        /// Starting address of the PE header
        /// </summary>
        public uint NewExeHeaderAddr { get; set; }

        #endregion
    }
}
