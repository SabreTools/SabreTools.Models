namespace SabreTools.Models.PFF
{
    /// <summary>
    /// PFF file footer
    /// </summary>
    /// <see href="https://devilsclaws.net/download/file-pff-new-bz2"/>
    public sealed class Footer
    {
        /// <summary>
        /// Current system IP
        /// </summary>
        public uint SystemIP;

        /// <summary>
        /// Reserved
        /// </summary>
        public uint Reserved;

        /// <summary>
        /// King tag
        /// </summary>
#if NET48
        public string KingTag;
#else
        public string? KingTag;
#endif
    }
}