namespace SabreTools.Models.SFFS
{
    /// <summary>
    /// Header
    /// </summary>
    /// <see href="https://forum.xentax.com/viewtopic.php?f=21&t=2084"/>
    public sealed class Header
    {
        /// <summary>
        /// "SFFS"
        /// </summary>
        public uint Magic { get; set; }

        /// <summary>
        /// Version (0x00000001)
        /// </summary>
        public uint Version { get; set; }

        /// <summary>
        /// Number of files in the container (encrypted with application key).
        /// Minimal number here is usually 65h, so its not real file count
        /// in some cases, more like index size
        /// </summary>
        public ulong FileCount { get; set; }
    }
}
