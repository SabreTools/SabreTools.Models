using System.Runtime.InteropServices;

namespace SabreTools.Models.VPK
{
    /// <see href="https://github.com/RavuAlHemio/hllib/blob/master/HLLib/VPKFile.h"/>
    [StructLayout(LayoutKind.Sequential)]
    public sealed class DirectoryEntry
    {
        public uint CRC;

        public ushort PreloadBytes;

        public ushort ArchiveIndex;

        public uint EntryOffset;

        public uint EntryLength;

        /// <summary>
        /// Always 0xffff.
        /// </summary>
        public ushort Dummy0;
    }
}
