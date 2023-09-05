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
        public byte[] TitleIDDependencyList;
#else
        public byte[]? TitleIDDependencyList;
#endif

        /// <summary>
        /// Reserved
        /// </summary>
#if NET48
        public byte[] Reserved1;
#else
        public byte[]? Reserved1;
#endif

        /// <summary>
        /// Core Version
        /// </summary>
        public uint CoreVersion;

        /// <summary>
        /// Reserved
        /// </summary>
#if NET48
        public byte[] Reserved2;
#else
        public byte[]? Reserved2;
#endif

        /// <summary>
        /// Icon Data(.ICN) - Taken from the application's ExeFS
        /// </summary>
#if NET48
        public byte[] IconData;
#else
        public byte[]? IconData;
#endif
    }
}