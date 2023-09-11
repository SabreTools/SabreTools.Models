namespace SabreTools.Models.PAK
{
    /// <see href="https://github.com/RavuAlHemio/hllib/blob/master/HLLib/PAKFile.h"/>
    public sealed class Header
    {
        /// <summary>
        /// Signature
        /// </summary>
#if NET48
        public string Signature { get; set; }
#else
        public string? Signature { get; set; }
#endif

        /// <summary>
        /// Directory Offset
        /// </summary>
        public uint DirectoryOffset { get; set; }

        /// <summary>
        /// Directory Length
        /// </summary>
        public uint DirectoryLength { get; set; }
    }
}
