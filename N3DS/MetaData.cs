namespace SabreTools.Models.N3DS
{
    /// <see href="https://www.3dbrew.org/wiki/CIA#Meta"/>
    public sealed class MetaData
    {
        /// <summary>
        /// Title ID dependency list - Taken from the application's ExHeader
        /// </summary>
        /// TODO: Determine numeric format of each entry
#if NET48
        public byte[] TitleIDDependencyList { get; set; }
#else
        public byte[]? TitleIDDependencyList { get; set; }
#endif

        /// <summary>
        /// Reserved
        /// </summary>
#if NET48
        public byte[] Reserved1 { get; set; }
#else
        public byte[]? Reserved1 { get; set; }
#endif

        /// <summary>
        /// Core Version
        /// </summary>
        public uint CoreVersion { get; set; }

        /// <summary>
        /// Reserved
        /// </summary>
#if NET48
        public byte[] Reserved2 { get; set; }
#else
        public byte[]? Reserved2 { get; set; }
#endif

        /// <summary>
        /// Icon Data(.ICN) - Taken from the application's ExeFS
        /// </summary>
#if NET48
        public byte[] IconData { get; set; }
#else
        public byte[]? IconData { get; set; }
#endif
    }
}