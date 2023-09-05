namespace SabreTools.Models.N3DS
{
    /// <summary>
    /// Represents a 3DS cart image
    /// </summary>
    public class Cart
    {
        /// <summary>
        /// 3DS cart header
        /// </summary>
#if NET48
        public NCSDHeader Header { get; set; }
#else
        public NCSDHeader? Header { get; set; }
#endif

        /// <summary>
        /// 3DS card info header
        /// </summary>
#if NET48
        public CardInfoHeader CardInfoHeader { get; set; }
#else
        public CardInfoHeader? CardInfoHeader { get; set; }
#endif

        /// <summary>
        /// 3DS development card info header
        /// </summary>
#if NET48
        public DevelopmentCardInfoHeader DevelopmentCardInfoHeader { get; set; }
#else
        public DevelopmentCardInfoHeader? DevelopmentCardInfoHeader { get; set; }
#endif

        /// <summary>
        /// NCCH partitions
        /// </summary>
#if NET48
        public NCCHHeader[] Partitions { get; set; }
#else
        public NCCHHeader[]? Partitions { get; set; }
#endif

        /// <summary>
        /// NCCH extended headers
        /// </summary>
#if NET48
        public NCCHExtendedHeader[] ExtendedHeaders { get; set; }
#else
        public NCCHExtendedHeader[]? ExtendedHeaders { get; set; }
#endif

        /// <summary>
        /// ExeFS headers associated with each partition
        /// </summary>
#if NET48
        public ExeFSHeader[] ExeFSHeaders { get; set; }
#else
        public ExeFSHeader[]? ExeFSHeaders { get; set; }
#endif

        /// <summary>
        /// RomFS headers associated with each partition
        /// </summary>
#if NET48
        public RomFSHeader[] RomFSHeaders { get; set; }
#else
        public RomFSHeader[]? RomFSHeaders { get; set; }
#endif
    }
}