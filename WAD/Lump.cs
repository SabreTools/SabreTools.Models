using System.Runtime.InteropServices;

namespace SabreTools.Models.WAD
{
    /// <see href="https://github.com/RavuAlHemio/hllib/blob/master/HLLib/WADFile.h"/>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public sealed class Lump
    {
        public uint Offset;

        public uint DiskLength;

        public uint Length;

        public byte Type;

        public byte Compression;

        public byte Padding0;

        public byte Padding1;

        /// <remarks>16 bytes</remarks>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string? Name;
    }
}
