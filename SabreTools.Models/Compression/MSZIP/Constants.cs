namespace SabreTools.Models.Compression.MSZIP
{
    /// <see href="https://github.com/wine-mirror/wine/blob/master/dlls/cabinet/cabinet.h"/>
    public static class Constants
    {
        /// <summary>
        /// Window size
        /// </summary>
        public const ushort ZIPWSIZE = 0x8000;

        /// <summary>
        /// And'ing with Zipmask[n] masks the lower n bits
        /// </summary>
        public static readonly ushort[] BitMasks =
        [
            0x0000, 0x0001, 0x0003, 0x0007, 0x000f, 0x001f, 0x003f, 0x007f, 0x00ff,
            0x01ff, 0x03ff, 0x07ff, 0x0fff, 0x1fff, 0x3fff, 0x7fff, 0xffff
        ];
    }
}