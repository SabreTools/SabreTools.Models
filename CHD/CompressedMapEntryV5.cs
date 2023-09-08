namespace SabreTools.Models.CHD
{
    /// <see href="https://github.com/mamedev/mame/blob/master/src/lib/util/chd.h"/> 
    public class CompressedMapEntryV5
    {
        /// <summary>
        /// Compression type
        /// </summary>
        public byte Compression { get; set; }

        /// <summary>
        /// Compressed length
        /// </summary>
        /// <remarks>Actually UInt24</remarks>
        public uint CompLength { get; set; }

        /// <summary>
        /// Offset
        /// </summary>
        /// <remarks>Actually UInt48</remarks>
        public ulong Offset { get; set; }

        /// <summary>
        /// CRC-16 of the data
        /// </summary>
        public ushort CRC { get; set; }
    }
}
