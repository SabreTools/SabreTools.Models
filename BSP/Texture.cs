namespace SabreTools.Models.BSP
{
    /// <see href="https://github.com/RavuAlHemio/hllib/blob/master/HLLib/BSPFile.h"/>
    public sealed class Texture
    {
        /// <summary>
        /// Name
        /// </summary>
        public string? Name { get; set; }
    
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
        public uint[]? Offsets { get; set; }

        /// <summary>
        /// Texture data
        /// </summary>
        public byte[]? TextureData { get; set; }

        /// <summary>
        /// Palette size
        /// </summary>
        public uint PaletteSize { get; set; }

        /// <summary>
        /// Palette data
        /// </summary>
        public byte[]? PaletteData { get; set; }
    }
}