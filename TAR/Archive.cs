namespace SabreTools.Models.TAR
{
    public sealed class Archive
    {
        /// <summary>
        /// File header
        /// </summary>
#if NET48
        public Header Header { get; set; }
#else
        public Header? Header { get; set; }
#endif
    }
}