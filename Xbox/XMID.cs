namespace SabreTools.Models.Xbox
{
    /// <summary>
    /// Contains information specific to an XGD disc
    /// </summary>
    /// <remarks>
    /// XGD1 XMID Format Information:
    ///
    /// AABBBCCD
    /// - AA        => The two-ASCII-character publisher identifier (see GetPublisher for details)
    /// - BBB       => Game ID
    /// - CC        => Version number
    /// - D         => Region identifier (see GetRegion for details)
    /// </remarks>
    public class XMID
    {
        /// <summary>
        /// 2-character publisher identifier
        /// </summary>
#if NET48
        public string PublisherIdentifier { get; set; }
#else
        public string PublisherIdentifier { get; set; }
#endif

        /// <summary>
        /// 3-character Game ID
        /// </summary>
#if NET48
        public string GameID { get; set; }
#else
        public string? GameID { get; set; }
#endif

        /// <summary>
        /// 2-character Internal version number
        /// </summary>
#if NET48
        public string VersionNumber { get; set; }
#else
        public string? VersionNumber { get; set; }
#endif

        /// <summary>
        /// 1-character Region identifier character
        /// </summary
        public char RegionIdentifier { get; set; }
    }
}
