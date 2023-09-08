namespace SabreTools.Models.CHD
{
    /// <see href="https://github.com/mamedev/mame/blob/master/src/lib/util/chd.h"/> 
    public class MapV3
    {
        /// <summary>
        /// Starting offset within the file
        /// </summary>
        public ulong StartingOffset { get; set; }

        /// <summary>
        /// 32-bit CRC of the uncompressed data
        /// </summary>
        public uint CRC32 { get; set; }

        /// <summary>
        /// Lower 16 bits of length
        /// </summary>
        public ushort LengthLo { get; set; }

        /// <summary>
        /// Upper 8 bits of length
        /// </summary>
        public byte LengthHi { get; set; }

        /// <summary>
        /// Flags, indicating compression info
        /// </summary>
        public byte Flags { get; set; }
    }
}
