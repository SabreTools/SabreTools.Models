namespace SabreTools.Models.PAK
{
    /// <see href="https://github.com/RavuAlHemio/hllib/blob/master/HLLib/PAKFile.h"/>
    public sealed class Header
    {
        /// <summary>
        /// Signature
        /// </summary>
#if NET48
        public string Signature;
#else
        public string? Signature;
#endif

        /// <summary>
        /// Directory Offset
        /// </summary>
        public uint DirectoryOffset;

        /// <summary>
        /// Directory Length
        /// </summary>
        public uint DirectoryLength;
    }
}
