namespace SabreTools.Models.PAK
{
    /// <see href="https://github.com/RavuAlHemio/hllib/blob/master/HLLib/PAKFile.h"/>
    public sealed class DirectoryItem
    {
        /// <summary>
        /// Item Name
        /// </summary>
#if NET48
        public string ItemName;
#else
        public string? ItemName;
#endif

        /// <summary>
        /// Item Offset
        /// </summary>
        public uint ItemOffset;

        /// <summary>
        /// Item Length
        /// </summary>
        public uint ItemLength;
    }
}
