namespace SabreTools.Models.BFPK
{
    /// <summary>
    /// File entry
    /// </summary>
    /// <see cref="https://forum.xentax.com/viewtopic.php?t=5102"/>
    public sealed class FileEntry
    {
        /// <summary>
        /// Name size
        /// </summary>
        public int NameSize;

        /// <summary>
        /// Name
        /// </summary>
#if NET48
        public string Name;
#else
        public string? Name;
#endif

        /// <summary>
        /// Uncompressed size
        /// </summary>
        public int UncompressedSize;

        /// <summary>
        /// Offset
        /// </summary>
        public int Offset;

        /// <summary>
        /// Compressed size
        /// </summary>
        public int CompressedSize;
    }
}
