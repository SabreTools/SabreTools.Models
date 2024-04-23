using System.Runtime.InteropServices;

namespace SabreTools.Models.BSP
{
    /// <see href="https://github.com/RavuAlHemio/hllib/blob/master/HLLib/BSPFile.h"/>
    [StructLayout(LayoutKind.Sequential)]
    public sealed class Header
    {
        /// <summary>
        /// Version
        /// </summary>
        public uint Version;
    }
}