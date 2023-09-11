namespace SabreTools.Models.PortableExecutable
{
    /// <summary>
    /// Overlay data associated with SecuROM executables
    /// </summary>
    /// <remarks>
    /// All information in this file has been researched in a clean room
    /// environment by using sample from legally obtained software that
    /// is protected by SecuROM.
    /// </remarks>
    public sealed class SecuROMAddD
    {
        /// <summary>
        /// "AddD", Identifier?
        /// </summary>
        public uint Signature { get; set; }

        /// <summary>
        /// Unknown (Entry count?)
        /// </summary>
        /// <remarks>
        /// 3 in EXPUNGED, 3.17.00.0017, 3.17.00.0019
        /// 3 in 4.47.00.0039, 4.84.00.0054, 4.84.69.0037, 4.84.76.7966, 4.84.76.7968, 4.85.07.0009
        /// </remarks>
        public uint EntryCount { get; set; }

        /// <summary>
        /// Version, always 8 bytes?
        /// </summary>
#if NET48
        public string Version { get; set; }
#else
        public string? Version { get; set; }
#endif

        /// <summary>
        /// Unknown (Build? Formatted as a string)
        /// </summary>
#if NET48
        public char[] Build { get; set; }
#else
        public char[]? Build { get; set; }
#endif

        /// <summary>
        /// Unknown (0x14h), Variable number of bytes before entry table
        /// </summary>
        /// <remarks>
        /// 44 bytes in EXPUNGED, 3.17.00.0017, 3.17.00.0019, 4.47.00.0039
        /// 112 bytes in 4.84.00.0054, 4.84.69.0037, 4.84.76.7966, 4.84.76.7968, 4.85.07.0009
        /// 112 byte range contains a fixed-length string at 0x2C, possibly a product ID?
        /// "801400-001" in 4.84.00.0054
        /// "594130-001" in 4.84.69.0037
        /// "554900-001" in 4.84.76.7966
        /// "554900-001" in 4.84.76.7968
        /// "548520-001" in 4.85.07.0009
        /// </remarks>
#if NET48
        public byte[] Unknown14h { get; set; }
#else
        public byte[]? Unknown14h { get; set; }
#endif

        /// <summary>
        /// Entry table
        /// </summary>
#if NET48
        public SecuROMAddDEntry[] Entries { get; set; }
#else
        public SecuROMAddDEntry?[]? Entries { get; set; }
#endif
    }
}
