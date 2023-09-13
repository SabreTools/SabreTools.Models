namespace SabreTools.Models.PIC
{
    /// <see href="https://www.t10.org/ftp/t10/document.05/05-206r0.pdf"/>
    /// <see href="https://github.com/aaru-dps/Aaru.Decoders/blob/devel/Bluray/DI.cs"/>
    public class DiscInformationUnit
    {
        /// <summary>
        /// Unit header
        /// </summary>
#if NET48
        public DiscInformationUnitHeader Header { get; set; }
#else
        public DiscInformationUnitHeader? Header { get; set; }
#endif

        /// <summary>
        /// Unit body
        /// </summary>
#if NET48
        public DiscInformationUnitBody Body { get; set; }
#else
        public DiscInformationUnitBody? Body { get; set; }
#endif

        /// <summary>
        /// Unit trailer (BD-R/RE only)
        /// </summary>
#if NET48
        public DiscInformationUnitTrailer Trailer { get; set; }
#else
        public DiscInformationUnitTrailer? Trailer { get; set; }
#endif
    }
}
