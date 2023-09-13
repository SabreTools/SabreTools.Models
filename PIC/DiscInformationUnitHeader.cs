namespace SabreTools.Models.PIC
{
    /// <see href="https://www.t10.org/ftp/t10/document.05/05-206r0.pdf"/>
    /// <see href="https://github.com/aaru-dps/Aaru.Decoders/blob/devel/Bluray/DI.cs"/>
    public class DiscInformationUnitHeader
    {
        /// <summary>
        /// Disc Information Identifier "DI"
        /// Emergency Brake Identifier "EB"
        /// </summary>
#if NET48
        public string DiscInformationIdentifier { get; set; }
#else
        public string? DiscInformationIdentifier { get; set; }
#endif

        /// <summary>
        /// Disc Information Format
        /// </summary>
        public byte DiscInformationFormat { get; set; }

        /// <summary>
        /// Number of DI units in each DI block
        /// </summary>
        public byte NumberOfUnitsInBlock { get; set; }

        /// <summary>
        /// Should be 0x00
        /// </summary>
        public byte Reserved0 { get; set; }

        /// <summary>
        /// DI unit Sequence Number
        /// </summary>
        public byte SequenceNumber { get; set; }

        /// <summary>
        /// Number of bytes in use in this DI unit
        /// </summary>
        public byte BytesInUse { get; set; }

        /// <summary>
        /// Should be 0x00
        /// </summary>
        public byte Reserved1 { get; set; }
    }
}
