namespace SabreTools.Models.WAD
{
    /// <summary>
    /// Half-Life Texture Package File
    /// </summary>
    /// <see href="https://github.com/RavuAlHemio/hllib/blob/master/HLLib/WADFile.h"/>
    public sealed class File
    {
        /// <summary>
        /// Deserialized header data
        /// </summary>
#if NET48
        public Header Header { get; set; }
#else
        public Header? Header { get; set; }
#endif

        /// <summary>
        /// Deserialized lumps data
        /// </summary>
#if NET48
        public Lump[] Lumps { get; set; }
#else
        public Lump?[]? Lumps { get; set; }
#endif

        /// <summary>
        /// Deserialized lump infos data
        /// </summary>
#if NET48
        public LumpInfo[] LumpInfos { get; set; }
#else
        public LumpInfo?[]? LumpInfos { get; set; }
#endif
    }
}
