﻿using System.Runtime.InteropServices;

namespace SabreTools.Models.SFFS
{
    /// <see href="https://forum.xentax.com/viewtopic.php?f=21&t=2084"/>
    [StructLayout(LayoutKind.Sequential)]
    public sealed class FileEntry
    {
        /// <summary>
        /// MD5 hash of filename (not encrypted,)
        /// </summary>
        /// <remarks>0x10 bytes</remarks>
#if NET48
        public byte[] FilenameMD5Hash;
#else
        public byte[]? FilenameMD5Hash;
#endif

        /// <summary>
        /// Index of fileheader (encrypted with filename)
        /// </summary>
        public ulong FileHeaderIndex;
    }
}
