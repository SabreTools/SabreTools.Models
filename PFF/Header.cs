namespace SabreTools.Models.PFF
{
    /// <summary>
    /// PFF archive header
    /// </summary>
    /// <remarks>Versions 2, 3, and 4 supported</remarks>
    /// <see href="https://devilsclaws.net/download/file-pff-new-bz2"/>
    public sealed class Header
    {
        /// <summary>
        /// Size of the following header
        /// </summary>
        public uint HeaderSize { get; set; }

        /// <summary>
        /// Signature
        /// </summary>
        /// <remarks>Versions 2 and 3 share the same signature but different header sizes</remarks>
#if NET48
        public string Signature { get; set; }
#else
        public string? Signature { get; set; }
#endif

        /// <summary>
        /// Number of files
        /// </summary>
        public uint NumberOfFiles { get; set; }

        /// <summary>
        /// File segment size
        /// </summary>
        public uint FileSegmentSize { get; set; }

        /// <summary>
        /// File list offset
        /// </summary>
        public uint FileListOffset { get; set; }
    }
}