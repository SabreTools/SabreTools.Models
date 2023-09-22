namespace SabreTools.Models.Compression.MSZIP
{
    /// <summary>
    /// Each MSZIP block MUST consist of a 2-byte MSZIP signature and one or more RFC 1951 blocks. The
    /// 2-byte MSZIP signature MUST consist of the bytes 0x43 and 0x4B. The MSZIP signature MUST be
    /// the first 2 bytes in the MSZIP block. The MSZIP signature is shown in the following packet diagram.
    /// </summary>
    /// <see href="https://interoperability.blob.core.windows.net/files/MS-MCI/%5bMS-MCI%5d.pdf"/>
    public class BlockHeader
    {
        /// <summary>
        /// 'CK'
        /// </summary>
        public ushort Signature { get; set; }
    }
}