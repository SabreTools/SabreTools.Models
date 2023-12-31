namespace SabreTools.Models.PIC
{
    /// <summary>
    /// BD-R/RE only
    /// </summary>
    /// <see href="https://www.t10.org/ftp/t10/document.05/05-206r0.pdf"/>
    /// <see href="https://github.com/aaru-dps/Aaru.Decoders/blob/devel/Bluray/DI.cs"/>
    public class DiscInformationUnitTrailer
    {
        /// <summary>
        /// Disc Manufacturer ID
        /// </summary>
        /// <remarks>6 bytes</remarks>
        public byte[]? DiscManufacturerID { get; set; } = new byte[6];

        /// <summary>
        /// Media Type ID
        /// </summary>
        /// <remarks>3 bytes</remarks>
        public byte[]? MediaTypeID { get; set; } = new byte[3];

        /// <summary>
        /// Time Stamp
        /// </summary>
        public ushort TimeStamp { get; set; }

        /// <summary>
        /// Product Revision Number
        /// </summary>
        public byte ProductRevisionNumber { get; set; }
    }
}
