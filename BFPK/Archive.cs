namespace SabreTools.Models.BFPK
{
    /// <summary>
    /// BFPK custom archive format
    /// </summary>
    /// <see cref="https://forum.xentax.com/viewtopic.php?t=5102"/>
    public sealed class Archive
    {
        /// <summary>
        /// Header
        /// </summary>
#if NET48
        public Header Header { get; set; }
#else
        public Header? Header { get; set; }
#endif

        /// <summary>
        /// Files
        /// </summary>
#if NET48
        public FileEntry[] Files { get; set; }
#else
        public FileEntry[]? Files { get; set; }
#endif
    }
}
