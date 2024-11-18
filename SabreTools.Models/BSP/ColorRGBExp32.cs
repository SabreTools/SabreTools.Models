using System.Runtime.InteropServices;

namespace SabreTools.Models.BSP
{
    /// <summary>
    /// 4-byte lightmap structure
    /// </summary>
    /// <see href="https://developer.valvesoftware.com/wiki/BSP_(Source)"/> 
    [StructLayout(LayoutKind.Sequential)]
    public struct ColorRGBExp32
    {
        public byte Red;

        public byte Green;

        public byte Blue;

        public sbyte Exponent;
    }
}