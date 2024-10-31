using System.Runtime.InteropServices;

namespace SabreTools.Models.CHD
{
    /// <see href="https://github.com/mamedev/mame/blob/master/src/lib/util/chd.cpp"/> 
    [StructLayout(LayoutKind.Sequential)]
    public sealed class MetadataHash
    {
        /// <summary>
        /// Tag of the metadata in big-endian
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[]? Tag;

        /// <summary>
        /// Hash data
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
        public byte[]? SHA1;
    }
}
