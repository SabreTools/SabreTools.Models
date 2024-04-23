using System.Runtime.InteropServices;

namespace SabreTools.Models.VBSP
{
    /// <see href="https://github.com/RavuAlHemio/hllib/blob/master/HLLib/VBSPFile.h"/>
    [StructLayout(LayoutKind.Sequential)]
    public sealed class Lump
    {
        public uint Offset;

        public uint Length;

        /// <summary>
        /// Default to zero.
        /// </summary>
        public uint Version;

        /// <summary>
        /// Default to (char)0, (char)0, (char)0, (char)0.
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public char[]? FourCC;
    }
}
