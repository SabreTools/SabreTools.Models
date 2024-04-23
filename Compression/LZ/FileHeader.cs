using System.Runtime.InteropServices;

namespace SabreTools.Models.Compression.LZ
{
    /// <summary>
    /// Format of first 14 byte of LZ compressed file
    /// </summary>
    /// <see href="https://github.com/wine-mirror/wine/blob/master/dlls/kernel32/lzexpand.c"/>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public sealed class FileHeaader
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
        public string? Magic;

        public byte CompressionType;

        [MarshalAs(UnmanagedType.U1)]
        public char LastChar;

        public uint RealLength;
    }
}