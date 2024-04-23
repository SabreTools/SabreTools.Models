using System.Runtime.InteropServices;

namespace SabreTools.Models.WAD
{
    /// <see href="https://github.com/RavuAlHemio/hllib/blob/master/HLLib/WADFile.h"/>
    public sealed class LumpInfo
    {
        /// <summary>
        /// Type 0x42 has no name, type 0x43 does
        /// </summary>
        /// <remarks>16 bytes</remarks>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string? Name;

        public uint Width;

        public uint Height;

        public uint PixelOffset;

        /// <summary>
        /// Unknown data
        /// </summary>
        /// <remarks>12 bytes</remarks>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        public byte[]? UnknownData;

        /// <remarks>Width * Height bytes located at PixelOffset</remarks>
        public byte[]? PixelData { get; set; }

        // TODO: Determine what mipmap data looks like

        public uint PaletteSize { get; set; }

        /// <remarks>PaletteSize * 3 bytes</remarks>
        public byte[]? PaletteData { get; set; }
    }
}
