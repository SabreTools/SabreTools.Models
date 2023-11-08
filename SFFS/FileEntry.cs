namespace SabreTools.Models.SFFS
{
    /// <see href="https://forum.xentax.com/viewtopic.php?f=21&t=2084"/>
    public sealed class FileEntry
    {
        /// <summary>
        /// MD5 hash of filename (not encrypted,)
        /// </summary>
        /// <remarks>0x10 bytes</remarks>
        public byte[]? FilenameMD5Hash { get; set; }

        /// <summary>
        /// Index of fileheader (encrypted with filename)
        /// </summary>
        public ulong FileHeaderIndex { get; set; }
    }
}
