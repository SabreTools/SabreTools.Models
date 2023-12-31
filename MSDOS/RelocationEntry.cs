﻿namespace SabreTools.Models.MSDOS
{
    /// <summary>
    /// Each pointer in the relocation table looks as such
    /// </summary>
    /// <see href="https://wiki.osdev.org/MZ"/>
    public sealed class RelocationEntry
    {
        /// <summary>
        /// Offset of the relocation within provided segment.
        /// </summary>
        public ushort Offset { get; set; }

        /// <summary>
        /// Segment of the relocation, relative to the load segment address.
        /// </summary>
        public ushort Segment { get; set; }
    }
}
