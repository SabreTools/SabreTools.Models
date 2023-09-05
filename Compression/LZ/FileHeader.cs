namespace SabreTools.Models.Compression.LZ
{
    /// <summary>
    /// Format of first 14 byte of LZ compressed file
    /// </summary>
    /// <see href="https://github.com/wine-mirror/wine/blob/master/dlls/kernel32/lzexpand.c"/>
    public sealed class FileHeaader
    {
#if NET48
        public string Magic;
#else
        public string? Magic;
#endif

        public byte CompressionType;

        public char LastChar;

        public uint RealLength;
    }
}