namespace SabreTools.Models.N3DS
{
    /// <see href="https://www.3dbrew.org/wiki/CIA#CIA_Header"/>
    public sealed class CIAHeader
    {
        /// <summary>
        /// Archive header size, usually 0x2020 bytes
        /// </summary>
        public uint HeaderSize { get; set; }

        /// <summary>
        /// Type
        /// </summary>
        public ushort Type { get; set; }

        /// <summary>
        /// Version
        /// </summary>
        public ushort Version { get; set; }

        /// <summary>
        /// Certificate chain size
        /// </summary>
        public uint CertificateChainSize { get; set; }

        /// <summary>
        /// Ticket size
        /// </summary>
        public uint TicketSize { get; set; }

        /// <summary>
        /// TMD file size
        /// </summary>
        public uint TMDFileSize { get; set; }

        /// <summary>
        /// Meta size (0 if no Meta data is present)
        /// </summary>
        public uint MetaSize { get; set; }

        /// <summary>
        /// Content size
        /// </summary>
        public ulong ContentSize { get; set; }

        /// <summary>
        /// Content Index
        /// </summary>
#if NET48
        public byte[] ContentIndex { get; set; }
#else
        public byte[]? ContentIndex { get; set; }
#endif
    }
}