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
        public uint SystemIP { get; set; }

        /// <summary>
        /// Reserved
        /// </summary>
        public uint Reserved { get; set; }

        /// <summary>
        /// King tag
        /// </summary>
        public string? KingTag { get; set; }
    }
}