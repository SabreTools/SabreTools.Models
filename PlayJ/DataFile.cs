namespace SabreTools.Models.PlayJ
{
    /// <summary>
    /// Embedded data file (V2 only?)
    /// </summary>
    public sealed class DataFile
    {
        /// <summary>
        /// Length of the data file name
        /// </summary>
        public ushort FileNameLength { get; set; }

        /// <summary>
        /// Data file name
        /// </summary>
#if NET48
        public string FileName { get; set; }
#else
        public string? FileName { get; set; }
#endif

        /// <summary>
        /// Length of the data
        /// </summary>
        public uint DataLength { get; set; }

        /// <summary>
        /// Data
        /// </summary>
#if NET48
        public byte[] Data { get; set; }
#else
        public byte[]? Data { get; set; }
#endif

        // Notes about Data:
        // - Each data block in the samples contains a GIF header
        // - Each GIF header contains an application extension: http://www.vurdalakov.net/misc/gif/application-extension
        // - Each GIF doesn't always stretch to the end of the data
        // - Remaining data seems to be padded as 0x00 (typically 8 bytes)
        // - GIF data is fully formed and may be copied to a standalone file
    }
}