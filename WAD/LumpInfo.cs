namespace SabreTools.Models.WAD
{
    /// <see href="https://github.com/RavuAlHemio/hllib/blob/master/HLLib/WADFile.h"/>
    public sealed class LumpInfo
    {
#if NET48
        public string Name { get; set; }
#else
        public string? Name { get; set; }
#endif

        public uint Width { get; set; }

        public uint Height { get; set; }

        public uint PixelOffset { get; set; }

        // 12 bytes of unknown data

#if NET48
        public byte[] PixelData { get; set; }
#else
        public byte[]? PixelData { get; set; }
#endif

        public uint PaletteSize { get; set; }

#if NET48
        public byte[] PaletteData { get; set; }
#else
        public byte[]? PaletteData { get; set; }
#endif
    }
}
