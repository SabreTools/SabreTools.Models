namespace SabreTools.Models.WAD
{
    /// <see href="https://github.com/RavuAlHemio/hllib/blob/master/HLLib/WADFile.h"/>
    public sealed class LumpInfo
    {
#if NET48
        public string Name;
#else
        public string? Name;
#endif

        public uint Width;

        public uint Height;

        public uint PixelOffset;

        // 12 bytes of unknown data

#if NET48
        public byte[] PixelData;
#else
        public byte[]? PixelData;
#endif

        public uint PaletteSize;

#if NET48
        public byte[] PaletteData;
#else
        public byte[]? PaletteData;
#endif
    }
}
