namespace SabreTools.Models.WAD
{
    /// <see href="https://github.com/RavuAlHemio/hllib/blob/master/HLLib/WADFile.h"/>
    public sealed class LumpInfo
    {
        public string? Name { get; set; }

        public uint Width { get; set; }

        public uint Height { get; set; }

        public uint PixelOffset { get; set; }

        // 12 bytes of unknown data

        public byte[]? PixelData { get; set; }

        public uint PaletteSize { get; set; }

        public byte[]? PaletteData { get; set; }
    }
}
