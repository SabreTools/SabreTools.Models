using System.Runtime.InteropServices;

namespace SabreTools.Models.BSP
{
    /// <see href="https://github.com/RavuAlHemio/hllib/blob/master/HLLib/BSPFile.h"/>
    /// <see href="https://developer.valvesoftware.com/wiki/BSP_(GoldSrc)"/>
    [StructLayout(LayoutKind.Sequential)]
    public sealed class LumpTableEntry
    {
        /// <summary>
        /// File offset to data
        /// </summary>
        public int Offset;

        /// <summary>
        /// Length of data
        /// </summary>
        public int Length;
    }
}