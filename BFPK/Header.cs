using System.Runtime.InteropServices;

namespace SabreTools.Models.BFPK
{
    /// <summary>
    /// Header
    /// </summary>
    /// <see cref="https://forum.xentax.com/viewtopic.php?t=5102"/>
    [StructLayout(LayoutKind.Sequential)]
    public sealed class Header
    {
        /// <summary>
        /// "BFPK"
        /// </summary>
#if NET48
        public string Magic;
#else
        public string? Magic;
#endif

        /// <summary>
        /// Version
        /// </summary>
        public int Version;

        /// <summary>
        /// Files
        /// </summary>
        public int Files;
    }
}
