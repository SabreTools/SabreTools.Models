namespace SabreTools.Models.PKZIP
{
    /// <summary>
    /// The following is the layout of the OS/2 attributes "extra"
    /// block.  (Last Revision  09/05/95)
    /// 
    /// The OS/2 extended attribute structure (FEA2LIST) is
    /// compressed and then stored in its entirety within this
    /// structure.  There will only ever be one "block" of data in
    /// VarFields[].
    /// </summary>
    /// <remarks>Header ID = 0x0009</remarks>
    /// <see href="https://pkware.cachefly.net/webdocs/casestudies/APPNOTE.TXT"/> 
    public class OS2ExtraField : ExtensibleDataField
    {
        /// <summary>
        /// Uncompressed Block Size
        /// </summary>
        public uint BSize { get; set; }

        /// <summary>
        /// Compression type
        /// </summary>
        public ushort CType { get; set; }

        /// <summary>
        /// CRC value for uncompress block
        /// </summary>
        public uint EACRC { get; set; }

        /// <summary>
        /// Compressed block
        /// </summary>
        public byte[]? Var { get; set; }
    }
}