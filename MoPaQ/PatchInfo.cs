﻿using System.Runtime.InteropServices;

namespace SabreTools.Models.MoPaQ
{
    /// <summary>
    /// This structure contains size of the patch, flags and also MD5 of the patch.
    /// </summary>
    /// <see href="http://zezula.net/en/mpq/mpqformat.html"/>
    [StructLayout(LayoutKind.Sequential)]
    public sealed class PatchInfo
    {
        /// <summary>
        /// Length of patch info header, in bytes
        /// </summary>
        public uint Length;

        /// <summary>
        /// Flags. 0x80000000 = MD5 (?)
        /// </summary>
        public uint Flags;

        /// <summary>
        /// Uncompressed size of the patch file
        /// </summary>
        public uint DataSize;

        /// <summary>
        /// MD5 of the entire patch file after decompression
        /// </summary>
        /// <remarks>0x10 bytes</remarks>
#if NET48
        public byte[] MD5;
#else
        public byte[]? MD5;
#endif

        /// <summary>
        /// The sector offset table (variable length)
        /// </summary>
#if NET48
        public uint[] SectorOffsetTable;
#else
        public uint[]? SectorOffsetTable;
#endif
    }
}
