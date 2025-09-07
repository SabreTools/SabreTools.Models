namespace SabreTools.Models.N3DS
{
    /// <summary>
    /// Offsets for each file in the CIA
    /// </summary>
    public class CIAOffsets
    {
        /// <summary>
        /// Offset to each item in the CIA
        /// </summary>
        public ulong Offset { get; set; }

        /// <summary>
        /// Item Type
        /// Lets the user keep track of what each offset is for
        /// </summary>
        public ItemTypes ItemType { get; set; }

        /// <summary>
        /// Size of each item in the CIA
        /// </summary>
        public ulong Size { get; set; }
    }
}