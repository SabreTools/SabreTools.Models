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
        /// Size of the original filename?
        /// </summary>
        /// <remarks>Doesn't exist in some cases?</remarks>
        public uint? OriginalFilenameSize { get; set; }

        /// <summary>
        /// Unicode-encoded original filename?
        /// </summary>
        /// <remarks>Doesn't exist in some cases?</remarks>
        public string? OriginalFilename { get; set; }

        /// <summary>
        /// Unknown, possibly a string count?
        /// </summary>
        /// <remarks>
        /// Only seen when the preceeding two fields exist
        /// 
        /// Observed values:
        /// - 01 00 00 00
        /// </remarks>
        public uint? Unknown1 { get; set; }

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
        public uint Unknown2 { get; set; }

        /// <summary>
        /// Unknown offset
        /// </summary>
        /// <remarks>
        /// Points to <see cref="Unknown0"/> if no original filename.
        /// Points to <see cref="EntryCount"/> if contains an original filename.
        /// </remarks>
        public uint UnknownOffset { get; set; }

        /// <summary>
        /// Offset of the start of the file table
        /// </summary>
        public uint TablePointer { get; set; }

        /// <summary>
        /// Offset to the start of the file data
        /// </summary>
        public uint FileDataStart { get; set; }

        /// <summary>
        /// Hex string that looks like a key or other identifier
        /// </summary>
        /// <remarks>32 bytes</remarks>
        public string? HexString { get; set; }

        /// <summary>
        /// Relative offset pointer to <see cref="FileDataStart"/> 
        /// </summary>
        /// <remarks>
        /// Relative to the end of the signature
        /// 
        /// At least one case where this does not point correctly?
        /// Invalid cases have a value of 531 but unknown if this
        /// is coincidental or not.
        /// </remarks>
        public uint FileDataStartPointer { get; set; }

        /// <summary>
        /// "ADVINSTSFX"
        /// </summary>
        public string? Signature { get; set; }

        /// <summary>
        /// Unknown, always 0? Padding?
        /// </summary>
        public ushort? Unknown3 { get; set; }
    }
}
