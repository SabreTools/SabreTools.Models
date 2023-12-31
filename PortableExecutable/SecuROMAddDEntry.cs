﻿namespace SabreTools.Models.PortableExecutable
{
    /// <summary>
    /// Overlay data associated with SecuROM executables
    /// </summary>
    /// <remarks>
    /// All information in this file has been researched in a clean room
    /// environment by using sample from legally obtained software that
    /// is protected by SecuROM.
    /// </remarks>
    public sealed class SecuROMAddDEntry
    {
        /// <summary>
        /// Physical offset of the embedded file
        /// </summary>
        public uint PhysicalOffset { get; set; }

        /// <summary>
        /// Length of the embedded file
        /// </summary>
        /// <remarks>The last entry seems to be 4 bytes short in 4.47.00.0039</remarks>
        public uint Length { get; set; }

        /// <summary>
        /// Unknown (0x08)
        /// </summary>
        /// <remarks>3149224 [3496, 48] in the sample (all 3 entries) in 4.47.00.0039</remarks>
        public uint Unknown08h { get; set; }

        /// <summary>
        /// Unknown (0x0C)
        /// </summary>
        /// <remarks>3147176 [1448, 48] in the sample (all 3 entries) in 4.47.00.0039</remarks>
        public uint Unknown0Ch { get; set; }

        /// <summary>
        /// Unknown (0x10)
        /// </summary>
        /// <remarks>3149224 [3496, 48] in the sample (all 3 entries) in 4.47.00.0039</remarks>
        public uint Unknown10h { get; set; }

        /// <summary>
        /// Unknown (0x14)
        /// </summary>
        /// <remarks>1245044 [65396, 18] in the sample (all 3 entries) in 4.47.00.0039</remarks>
        public uint Unknown14h { get; set; }

        /// <summary>
        /// Unknown (0x18)
        /// </summary>
        /// <remarks>4214725 [20421, 64] in the sample (all 3 entries) in 4.47.00.0039</remarks>
        public uint Unknown18h { get; set; }

        /// <summary>
        /// Unknown (0x1C)
        /// </summary>
        /// <remarks>2 [2, 0] in the sample (all 3 entries) in 4.47.00.0039</remarks>
        public uint Unknown1Ch { get; set; }

        /// <summary>
        /// Entry file name (null-terminated)
        /// </summary>
        /// <remarks>12 bytes long in the sample (all 3 entries) in 4.47.00.0039</remarks>
        public string? FileName { get; set; }

        /// <summary>
        /// Unknown (0x2C)
        /// </summary>
        /// <remarks>
        /// Offset based on consistent-sized filenames (12 bytes) in 4.47.00.0039
        /// 132 [132, 0] in the sample (all 3 entries) in 4.47.00.0039
        /// </remarks>
        public uint Unknown2Ch { get; set; }
    }
}
