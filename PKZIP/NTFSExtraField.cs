namespace SabreTools.Models.PKZIP
{
    /// <summary>
    /// The following is the layout of the NTFS attributes
    /// "extra" block. (Note: At this time the Mtime, Atime
    /// and Ctime values MAY be used on any WIN32 system.)
    /// </summary>
    /// <remarks>Header ID = 0x000A</remarks>
    /// <see href="https://pkware.cachefly.net/webdocs/casestudies/APPNOTE.TXT"/> 
    public class NTFSExtraField : ExtensibleDataField
    {
        /// <summary>
        /// Reserved for future use
        /// </summary>
        public uint Reserved { get; set; }

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