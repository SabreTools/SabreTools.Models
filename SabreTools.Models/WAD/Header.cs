using System.Runtime.InteropServices;

namespace SabreTools.Models.WAD
{
    /// <see href="https://github.com/RavuAlHemio/hllib/blob/master/HLLib/WADFile.h"/>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public sealed class Header
    {
        /// <summary>
        /// "WAD3"
        /// </summary>
        /// <remarks>4 bytes</remarks>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string? Signature;

        /// <summary>
        /// Number of lumps in the file
        /// </summary>
        public uint LumpCount;

        /// <summary>
        /// Offset where lumps are stored
        /// </summary>
        public uint LumpOffset;
    }
}
