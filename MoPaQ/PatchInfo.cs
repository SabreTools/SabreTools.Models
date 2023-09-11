namespace SabreTools.Models.MoPaQ
{
    /// <summary>
    /// This structure contains size of the patch, flags and also MD5 of the patch.
    /// </summary>
    /// <see href="http://zezula.net/en/mpq/mpqformat.html"/>
    public sealed class PatchInfo
    {
        /// <summary>
        /// Length of patch info header, in bytes
        /// </summary>
        public uint Length { get; set; }

        /// <summary>
        /// Flags. 0x80000000 = MD5 (?)
        /// </summary>
        public uint Flags { get; set; }

        /// <summary>
        /// Uncompressed size of the patch file
        /// </summary>
        public uint DataSize { get; set; }

        /// <summary>
        /// MD5 of the entire patch file after decompression
        /// </summary>
        /// <remarks>0x10 bytes</remarks>
#if NET48
        public byte[] MD5 { get; set; }
#else
        public byte[]? MD5 { get; set; }
#endif

        /// <summary>
        /// The sector offset table (variable length)
        /// </summary>
#if NET48
        public uint[] SectorOffsetTable { get; set; }
#else
        public uint[]? SectorOffsetTable { get; set; }
#endif
    }
}
