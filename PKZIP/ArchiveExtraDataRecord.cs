namespace SabreTools.Models.PKZIP
{
    /// <summary>
    /// Archive extra data record
    /// </summary>
    /// <see href="https://pkwaredownloads.blob.core.windows.net/pkware-general/Documentation/APPNOTE-6.3.9.TXT"/> 
    public class ArchiveExtraDataRecord
    {
        /// <summary>
        /// Archive extra data signature (0x08064B50)
        /// </summary>
        public uint Signature { get; set; }

        /// <summary>
        /// Extra field length
        /// </summary>
        public uint ExtraFieldLength { get; set; }

        /// <summary>
        /// Extra field data (variable size)
        /// </summary>
        public byte[]? ExtraFieldData { get; set; }
    }
}