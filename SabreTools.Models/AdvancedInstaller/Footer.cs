namespace SabreTools.Models.AdvancedInstaller
{
    /// <summary>
    /// Structure similar to the end of central directory
    /// header in PKZIP files
    /// </summary>
    public class Footer
    {
        /// <summary>
        /// Unknown
        /// </summary>
        /// <remarks>
        /// Observed values:
        /// - 00 00 00 00
        /// </remarks>
        public uint Unknown0 { get; set; }

        /// <summary>
        /// Pointer to <see cref="Unknown0"/>?
        /// </summary>
        public uint FooterOffset { get; set; }

        /// <summary>
        /// Number of entries that preceed the footer
        /// </summary>
        public uint EntryCount { get; set; }

        /// <summary>
        /// Unknown
        /// </summary>
        /// <remarks>
        /// Observed values:
        /// - 64 00 00 00
        /// </remarks>
        public uint Unknown1 { get; set; }

        /// <summary>
        /// Pointer to <see cref="Unknown0"/>?
        /// </summary>
        public uint FooterOffset2 { get; set; }

        /// <summary>
        /// Offset of the start of the file table
        /// </summary>
        public uint TablePointer { get; set; }

        /// <summary>
        /// Offset to the start of the file data
        /// </summary>
        public uint FileDataStart { get; set; }

        /// <summary>
        /// Null-terminated hex string that looks
        /// like a key or other identifier.
        /// </summary>
        public string? KeyString { get; set; }

        /// <summary>
        /// Unknown, always zero?
        /// </summary>
        public ushort Unknown2 { get; set; }

        /// <summary>
        /// "ADVINSTSFX", null terminated
        /// </summary>
        /// <remarks>May have another trailing null after?</remarks>
        public string? Signature { get; set; }
    }
}
