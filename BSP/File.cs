namespace SabreTools.Models.BSP
{
    /// <summary>
    /// Half-Life Level
    /// </summary>
    /// <see href="https://github.com/RavuAlHemio/hllib/blob/master/HLLib/BSPFile.h"/>
    public sealed class File
    {
        /// <summary>
        /// Header data
        /// </summary>
#if NET48
        public Header Header { get; set; }
#else
        public Header? Header { get; set; }
#endif

        /// <summary>
        /// Lumps
        /// </summary>
#if NET48
        public Lump[] Lumps { get; set; }
#else
        public Lump[]? Lumps { get; set; }
#endif

        /// <summary>
        /// Texture header data
        /// </summary>
#if NET48
        public TextureHeader TextureHeader { get; set; }
#else
        public TextureHeader? TextureHeader { get; set; }
#endif

        /// <summary>
        /// Textures
        /// </summary>
#if NET48
        public Texture[] Textures { get; set; }
#else
        public Texture[]? Textures { get; set; }
#endif
    }
}