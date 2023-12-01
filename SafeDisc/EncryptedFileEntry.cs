namespace SabreTools.Models.SafeDisc
{
    /// <see href="http://blog.w4kfu.com/tag/safedisc"/>
    public class EncryptedFileEntry
    {
        /// <summary>
        /// 0xA8726B03
        /// </summary>
        public uint Signature1 { get; set; }

        /// <summary>
        /// 0xEF01996C
        /// </summary>
        public uint Signature2 { get; set; }

        public uint FileNumber { get; set; }

        public uint Offset1 { get; set; }

        public uint Offset2 { get; set; }

        public uint Unknown1 { get; set; }

        public uint Unknown2 { get; set; }

        /// <remarks>
        /// 0x0D bytes
        /// </remarks>
        public byte[]? Name { get; set; }
    }
}
