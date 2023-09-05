namespace SabreTools.Models.BSP
{
    /// <see href="https://github.com/RavuAlHemio/hllib/blob/master/HLLib/BSPFile.h"/>
    public sealed class TextureHeader
    {
        /// <summary>
        /// Texture count
        /// </summary>
        public uint TextureCount;

        /// <summary>
        /// Offsets
        /// </summary>
#if NET48
        public uint[] Offsets;
#else
        public uint[]? Offsets;
#endif
    }
}