namespace SabreTools.Models.BSP
{
    /// <see href="https://github.com/RavuAlHemio/hllib/blob/master/HLLib/BSPFile.h"/>
    public sealed class TextureHeader
    {
        /// <summary>
        /// Texture count
        /// </summary>
        public uint TextureCount { get; set; }

        /// <summary>
        /// Offsets
        /// </summary>
        /// <remarks>TextureCount entries</remarks>
        public uint[]? Offsets { get; set; }
    }
}