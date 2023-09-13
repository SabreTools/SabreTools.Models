namespace SabreTools.Models.PIC
{
    /// <see href="https://www.t10.org/ftp/t10/document.05/05-206r0.pdf"/>
    /// <see href="https://github.com/aaru-dps/Aaru.Decoders/blob/devel/Bluray/DI.cs"/>
    /// TODO: Write models for the dependent contents, if possible
    public class DiscInformationUnitBody
    {
        /// <summary>
        /// Disc Type Identifier
        /// = "BDO" for BD-ROM
        /// = "BDU" for BD-ROM Ultra
        /// = "BDW" for BD-RE
        /// = "BDR" for BD-R
        /// </summary>
#if NET48
        public string DiscTypeIdentifier { get; set; }
#else
        public string? DiscTypeIdentifier { get; set; }
#endif

        /// <summary>
        /// Disc Size/Class/Version
        /// </summary>
        public byte DiscSizeClassVersion { get; set; }

        /// <summary>
        /// DI Unit Format dependent contents
        /// </summary>
        /// <remarks>52 bytes for BD-ROM, 100 bytes for BD-R/RE</remarks>
#if NET48
        public byte[] FormatDependentContents { get; set; }
#else
        public byte[]? FormatDependentContents { get; set; }
#endif
    }
}
