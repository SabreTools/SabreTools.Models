namespace SabreTools.Models.PlayStation3
{
    /// <see href="https://psdevwiki.com/ps3/PS3_DISC.SFB"/> 
    public class SFB
    {
        /// <summary>
        /// ".SFB"
        /// </summary>
        public byte[]? Magic { get; set; }

        /// <summary>
        /// File version(?)
        /// </summary>
        public uint FileVersion { get; set; }

        /// <summary>
        /// Unknown (zeroes)
        /// </summary>
        /// <remarks>0x18 bytes</remarks>
        public byte[]? Reserved1 { get; set; }

        /// <summary>
        /// "HYBRID_FLAG" (Flags type)
        /// </summary>
        /// <remarks>0x10 bytes</remarks>
        public string? FlagsType { get; set; }

        /// <summary>
        /// Disc Content Data Offset
        /// </summary>
        public uint DiscContentDataOffset { get; set; }

        /// <summary>
        /// Disc Content Data Length
        /// </summary>
        public uint DiscContentDataLength { get; set; }

        /// <summary>
        /// Unknown (zeroes)
        /// </summary>
        /// <remarks>0x08 bytes</remarks>
        public byte[]? Reserved2 { get; set; }

        /// <summary>
        /// "TITLE_ID" (Disc Title Name)
        /// </summary>
        /// <remarks>0x08 bytes</remarks>
        public string? DiscTitleName { get; set; }

        /// <summary>
        /// Unknown (zeroes)
        /// </summary>
        /// <remarks>0x08 bytes</remarks>
        public byte[]? Reserved3 { get; set; }

        /// <summary>
        /// Disc Version Data Offset
        /// </summary>
        public uint DiscVersionDataOffset { get; set; }

        /// <summary>
        /// Disc Version Data Length
        /// </summary>
        public uint DiscVersionDataLength { get; set; }

        /// <summary>
        /// Unknown (zeroes)
        /// </summary>
        /// <remarks>0x188 bytes</remarks>
        public byte[]? Reserved4 { get; set; }

        /// <summary>
        /// Disc Content (Hybrid Flags)
        /// </summary>
        /// <remarks>0x20 bytes</remarks>
        public string? DiscContent { get; set; }

        /// <summary>
        /// Disc Title
        /// </summary>
        /// <remarks>0x10 bytes</remarks>
        public string? DiscTitle { get; set; }

        /// <summary>
        /// Disc Version
        /// </summary>
        /// <remarks>0x10 bytes</remarks>
        public string? DiscVersion { get; set; }

        /// <summary>
        /// Unknown (zeroes)
        /// </summary>
        /// <remarks>0x3C0 bytes</remarks>
        public byte[]? Reserved5 { get; set; }
    }
}
