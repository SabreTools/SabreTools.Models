namespace SabreTools.Models.PAK
{
    /// <see href="https://github.com/RavuAlHemio/hllib/blob/master/HLLib/PAKFile.h"/>
    public sealed class Header
    {
        /// <summary>
        /// Signature
        /// </summary>
        public string? Signature { get; set; }

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
