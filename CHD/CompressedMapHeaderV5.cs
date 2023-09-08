namespace SabreTools.Models.CHD
{
    /// <see href="https://github.com/mamedev/mame/blob/master/src/lib/util/chd.h"/> 
    public class CompressedMapHeaderV5
    {
        /// <summary>
        /// Length of compressed map
        /// </summary>
        public uint Length { get; set; }

        /// <summary>
        /// Offset of first block
        /// </summary>
        /// <remarks>Actually UInt48</remarks>
        public ulong DataStart { get; set; }

        /// <summary>
        /// CRC-16 of the map
        /// </summary>
        public ushort CRC { get; set; }

        /// <summary>
        /// Bits used to encode complength
        /// </summary>
        public byte LengthBits { get; set; }

        /// <summary>
        /// Bits used to encode self-refs
        /// </summary>
        public byte HunkBits { get; set; }

        /// <summary>
        /// Bits used to encode parent unit refs
        /// </summary>
        public byte ParentUnitBits { get; set; }

        /// <summary>
        /// Future use
        /// </summary>
        public byte Reserved { get; set; }
    }
}
