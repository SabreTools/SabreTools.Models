using System.Runtime.InteropServices;

namespace SabreTools.Models.AACS
{
    /// <summary>
    /// This record type is undocumented but found in real media key blocks
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public sealed class CopyrightRecord : Record
    {
        /// <summary>
        /// Null-terminated ASCII string representing the copyright
        /// </summary>
        [MarshalAs(UnmanagedType.LPStr)]
        public string? Copyright;
    }
}