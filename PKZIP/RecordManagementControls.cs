namespace SabreTools.Models.PKZIP
{
    /// <remarks>Header ID = 0x0018</remarks>
    /// <see href="https://pkware.cachefly.net/webdocs/casestudies/APPNOTE.TXT"/> 
    public class RecordManagementControls : ExtensibleDataField
    {
        #region Tags, Interleaved

        /// <summary>
        /// NTFS attribute tag values
        /// </summary>
        public ushort[]? Tags { get; set; }

        /// <summary>
        /// Size of attributes, in bytes
        /// </summary>
        public ushort[]? Size { get; set; }

        /// <summary>
        /// Attribute data
        /// </summary>
        public byte[]? Vars { get; set; }

        #endregion
    }
}