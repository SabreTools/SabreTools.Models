namespace SabreTools.Models.PKZIP
{
    /// <summary>
    /// Data descriptor
    /// </summary>
    /// <see href="https://pkwaredownloads.blob.core.windows.net/pkware-general/Documentation/APPNOTE-6.3.9.TXT"/> 
    public class DataDescriptor
    {
        /// <summary>
        /// Recommended, but optional, signature (0x08074B50)
        /// </summary>
        public uint? Signature { get; set; }

        /// <summary>
        /// CRC-32
        /// </summary>
        public uint CRC32 { get; set; }

        /// <summary>
        /// Compressed size
        /// </summary>
        public uint CompressedSize { get; set; }

        /// <summary>
        /// Uncompressed size
        /// </summary>
        public uint UncompressedSize { get; set; }
    }
}