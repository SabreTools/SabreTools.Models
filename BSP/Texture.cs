namespace SabreTools.Models.BSP
{
    /// <see href="https://github.com/RavuAlHemio/hllib/blob/master/HLLib/BSPFile.h"/>
    public sealed class Texture
    {
        /// <summary>
        /// Name
        /// </summary>
#if NET48
        public string Name { get; set; }
#else
        public string? Name { get; set; }
#endif
    
        /// <summary>
        /// Width
        /// </summary>
        public uint Width { get; set; }

        /// <summary>
        /// Height
        /// </summary>
        public uint Height { get; set; }

        /// <summary>
        /// Offsets
        /// </summary>
#if NET48
        public uint[] Offsets { get; set; }
#else
        public uint[]? Offsets { get; set; }
#endif

        /// <summary>
        /// Texture data
        /// </summary>
#if NET48
        public byte[] TextureData { get; set; }
#else
        public byte[]? TextureData { get; set; }
#endif

        /// <summary>
        /// Palette size
        /// </summary>
        public uint PaletteSize { get; set; }

        /// <summary>
        /// Palette data
        /// </summary>
#if NET48
        public byte[] PaletteData { get; set; }
#else
        public byte[]? PaletteData { get; set; }
#endif
    }
}