namespace SabreTools.Models.BFPK
{
    /// <summary>
    /// Header
    /// </summary>
    /// <see cref="https://forum.xentax.com/viewtopic.php?t=5102"/>
    public sealed class Header
    {
        /// <summary>
        /// "BFPK"
        /// </summary>
#if NET48
        public string Magic { get; set; }
#else
        public string? Magic { get; set; }
#endif

        /// <summary>
        /// Version
        /// </summary>
        public int Version { get; set; }

        /// <summary>
        /// Files
        /// </summary>
        public int Files { get; set; }
    }
}
