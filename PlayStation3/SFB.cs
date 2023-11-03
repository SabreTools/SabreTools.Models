namespace SabreTools.Models.PlayStation3
{
    /// <see href="https://psdevwiki.com/ps3/PS3_DISC.SFB"/> 
    public class SFB
    {
        /// <summary>
        /// ".SFB"
        /// </summary>
#if NET48
        public byte[] Magic { get; set; }
#else
        public byte[]? Magic { get; set; }
#endif

        /// <summary>
        /// File version(?)
        /// </summary>
        public uint FileVersion { get; set; }

        /// <summary>
        /// Unknown (zeroes)
        /// </summary>
        /// <remarks>0x18 bytes</remarks>
#if NET48
        public byte[] Reserved1 { get; set; }
#else
        public byte[]? Reserved1 { get; set; }
#endif

        /// <summary>
        /// "HYBRID_FLAG" (Flags type)
        /// </summary>
        /// <remarks>0x10 bytes</remarks>
#if NET48
        public string FlagsType { get; set; }
#else
        public string? FlagsType { get; set; }
#endif

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
#if NET48
        public byte[] Reserved2 { get; set; }
#else
        public byte[]? Reserved2 { get; set; }
#endif

        /// <summary>
        /// "TITLE_ID" (Disc Title Name)
        /// </summary>
        /// <remarks>0x08 bytes</remarks>
#if NET48
        public string DiscTitleName { get; set; }
#else
        public string? DiscTitleName { get; set; }
#endif

        /// <summary>
        /// Unknown (zeroes)
        /// </summary>
        /// <remarks>0x08 bytes</remarks>
#if NET48
        public byte[] Reserved3 { get; set; }
#else
        public byte[]? Reserved3 { get; set; }
#endif

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
#if NET48
        public byte[] Reserved4 { get; set; }
#else
        public byte[]? Reserved4 { get; set; }
#endif

        /// <summary>
        /// Disc Content (Hybrid Flags)
        /// </summary>
        /// <remarks>0x20 bytes</remarks>
#if NET48
        public string DiscContent { get; set; }
#else
        public string? DiscContent { get; set; }
#endif

        /// <summary>
        /// Disc Title
        /// </summary>
        /// <remarks>0x10 bytes</remarks>
#if NET48
        public string DiscTitle { get; set; }
#else
        public string? DiscTitle { get; set; }
#endif

        /// <summary>
        /// Disc Version
        /// </summary>
        /// <remarks>0x10 bytes</remarks>
#if NET48
        public string DiscVersion { get; set; }
#else
        public string? DiscVersion { get; set; }
#endif

        /// <summary>
        /// Unknown (zeroes)
        /// </summary>
        /// <remarks>0x3C0 bytes</remarks>
#if NET48
        public byte[] Reserved5 { get; set; }
#else
        public byte[]? Reserved5 { get; set; }
#endif
    }
}
