﻿namespace SabreTools.Models.SFFS
{
    /// <see href="https://forum.xentax.com/viewtopic.php?f=21&t=2084"/>
    public sealed class FileHeader
    {
        /// <summary>
        /// Start of file content (encrypted with filename)
        /// </summary>
        public ulong FileContentStart { get; set; }

        /// <summary>
        /// File info (timestamps, size, data position, encrypted)
        /// </summary>
        /// <remarks>Unknown format</remarks>
        public byte[]? FileInfo { get; set; }
    }
}
