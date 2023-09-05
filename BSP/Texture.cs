namespace SabreTools.Models.BSP
{
    /// <see href="https://github.com/RavuAlHemio/hllib/blob/master/HLLib/BSPFile.h"/>
    public sealed class Texture
    {
        /// <summary>
        /// Name
        /// </summary>
#if NET48
        public string Name;
#else
        public string? Name;
#endif
    
        /// <summary>
        /// Width
        /// </summary>
        public uint Width;

        /// <summary>
        /// Height
        /// </summary>
        public uint Height;

        /// <summary>
        /// Offsets
        /// </summary>
#if NET48
        public uint[] Offsets;
#else
        public uint[]? Offsets;
#endif

        /// <summary>
        /// Texture data
        /// </summary>
#if NET48
        public byte[] TextureData;
#else
        public byte[]? TextureData;
#endif

        /// <summary>
        /// Palette size
        /// </summary>
        public uint PaletteSize;

        /// <summary>
        /// Palette data
        /// </summary>
#if NET48
        public byte[] PaletteData;
#else
        public byte[]? PaletteData;
#endif
    }
}