namespace SabreTools.Models.MoPaQ
{
    /// <summary>
    /// Block table contains informations about file sizes and way of their storage within
    /// the archive. It also contains the position of file content in the archive. Size
    /// of block table entry is (like hash table entry). The block table is also encrypted.
    /// </summary>
    /// <see href="http://zezula.net/en/mpq/mpqformat.html"/>
    public sealed class BlockEntry
    {
        /// <summary>
        /// Offset of the beginning of the file data, relative to the beginning of the archive.
        /// </summary>
        public uint FilePosition { get; set; }

        /// <summary>
        /// Compressed file size
        /// </summary>
        public uint CompressedSize { get; set; }

        /// <summary>
        /// Size of uncompressed file
        /// </summary>
        public uint UncompressedSize { get; set; }

        /// <summary>
        /// Flags for the file.
        /// </summary>
        public FileFlags Flags { get; set; }
    }
}
