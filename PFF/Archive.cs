namespace SabreTools.Models.PFF
{
    /// <summary>
    /// PFF archive
    /// </summary>
    /// <see href="https://devilsclaws.net/download/file-pff-new-bz2"/>
    public sealed class Archive
    {
        /// <summary>
        /// Archive header
        /// </summary>
#if NET48
        public Header Header { get; set; }
#else
        public Header? Header { get; set; }
#endif

        /// <summary>
        /// Segments
        /// </summary>
#if NET48
        public Segment[] Segments { get; set; }
#else
        public Segment[]? Segments { get; set; }
#endif

        /// <summary>
        /// Footer
        /// </summary>
#if NET48
        public Footer Footer { get; set; }
#else
        public Footer? Footer { get; set; }
#endif
    }
}