namespace SabreTools.Models.PAK
{
    /// <summary>
    /// Half-Life Package File
    /// </summary>
    /// <see href="https://github.com/RavuAlHemio/hllib/blob/master/HLLib/PAKFile.h"/>
    public sealed class File
    {
        /// <summary>
        /// Deserialized directory header data
        /// </summary>
#if NET48
        public Header Header { get; set; }
#else
        public Header? Header { get; set; }
#endif

        /// <summary>
        /// Deserialized directory items data
        /// </summary>
#if NET48
        public DirectoryItem[] DirectoryItems { get; set; }
#else
        public DirectoryItem[]? DirectoryItems { get; set; }
#endif
    }
}
