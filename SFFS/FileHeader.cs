using System.Runtime.InteropServices;

namespace SabreTools.Models.SFFS
{
    /// <see href="https://forum.xentax.com/viewtopic.php?f=21&t=2084"/>
    [StructLayout(LayoutKind.Sequential)]
    public sealed class FileHeader
    {
        /// <summary>
        /// Start of file content (encrypted with filename)
        /// </summary>
        public ulong FileContentStart { get; set; }

        /// <summary>
        /// File info (timestamps, size, data position, encrypted)
        /// </summary>
        /// <remarks>Unknown format</remarks>
#if NET48
        public byte[] FileInfo { get; set; }
#else
        public byte[]? FileInfo { get; set; }
#endif
    }
}
