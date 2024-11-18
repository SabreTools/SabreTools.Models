using System.Runtime.InteropServices;

namespace SabreTools.Models.BSP
{
    /// <see href="https://github.com/RavuAlHemio/hllib/blob/master/HLLib/BSPFile.h"/>
    /// <see href="https://developer.valvesoftware.com/wiki/BSP_(GoldSrc)"/>
    [StructLayout(LayoutKind.Sequential)]
    public sealed class Header
    {
        /// <summary>
        /// Version
        /// </summary>
        /// <remarks>Must be 30 for a valid HL BSP file</remarks>
        public int Version;

        /// <summary>
        /// Lumps
        /// </summary>
        /// <remarks>15 entries</remarks>
        public LumpTableEntry[]? Lumps { get; set; }
    }
}