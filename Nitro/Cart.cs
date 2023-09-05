namespace SabreTools.Models.Nitro
{
    /// <summary>
    /// Represents a DS/DSi cart image
    /// </summary>
    public class Cart
    {
        /// <summary>
        /// DS/DSi cart header
        /// </summary>
#if NET48
        public CommonHeader CommonHeader { get; set; }
#else
        public CommonHeader? CommonHeader { get; set; }
#endif

        /// <summary>
        /// DSi extended cart header
        /// </summary>
#if NET48
        public ExtendedDSiHeader ExtendedDSiHeader { get; set; }
#else
        public ExtendedDSiHeader? ExtendedDSiHeader { get; set; }
#endif

        /// <summary>
        /// Secure area, may be encrypted or decrypted
        /// </summary>
#if NET48
        public byte[] SecureArea { get; set; }
#else
        public byte[]? SecureArea { get; set; }
#endif

        /// <summary>
        /// Name table (folder allocation table, name list)
        /// </summary>
#if NET48
        public NameTable NameTable { get; set; }
#else
        public NameTable? NameTable { get; set; }
#endif

        /// <summary>
        /// File allocation table
        /// </summary>
#if NET48
        public FileAllocationTableEntry[] FileAllocationTable { get; set; }
#else
        public FileAllocationTableEntry[]? FileAllocationTable { get; set; }
#endif
    }
}