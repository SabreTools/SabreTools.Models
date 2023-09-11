namespace SabreTools.Models.Quantum
{
    /// <summary>
    /// Quantum archive file header
    /// </summary>
    /// <see href="https://handwiki.org/wiki/Software:Quantum_compression"/>
    public class Header
    {
        /// <summary>
        /// Quantum signature: 0x44 0x53
        /// </summary>
#if NET48
        public string Signature { get; set; }
#else
        public string? Signature { get; set; }
#endif

        /// <summary>
        /// Quantum major version number
        /// </summary>
        public byte MajorVersion { get; set; }

        /// <summary>
        /// Quantum minor version number
        /// </summary>
        public byte MinorVersion { get; set; }

        /// <summary>
        /// Number of files within this archive
        /// </summary>
        public ushort FileCount { get; set; }

        /// <summary>
        /// Table size required for decompression
        /// </summary>
        public byte TableSize { get; set; }

        /// <summary>
        /// Compression flags
        /// </summary>
        public byte CompressionFlags { get; set; }
    }
}