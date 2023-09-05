namespace SabreTools.Models.SGA
{
    /// <summary>
    /// SGA game archive
    /// </summary>
    /// <see href="https://github.com/RavuAlHemio/hllib/blob/master/HLLib/SGAFile.h"/>
    public sealed class File
    {
        /// <summary>
        ///Header data
        /// </summary>
#if NET48
        public Header Header { get; set; }
#else
        public Header? Header { get; set; }
#endif

        /// <summary>
        /// Directory data
        /// </summary>
#if NET48
        public Directory Directory { get; set; }
#else
        public Directory? Directory { get; set; }
#endif
    }
}
