namespace SabreTools.Models.Xbox
{
    /// <summary>
    /// Contains information specific to an XGD disc
    /// </summary>
    /// <remarks>
    /// XGD2/3 XeMID Format Information:
    ///
    /// AABCCCDDEFFGHH(IIIIIIII)
    /// - AA        => The two-ASCII-character publisher identifier (see GetPublisher for details)
    /// - B         => Platform identifier; 2 indicates Xbox 360.
    /// - CCC       => Game ID
    /// - DD        => SKU number (unique per SKU of a title)
    /// - E         => Region identifier (see GetRegion for details)
    /// - FF        => Base version; usually starts at 01 (can be 1 or 2 characters)
    /// - G         => Media type identifier (see GetMediaSubtype for details)
    /// - HH        => Disc number stored in [disc number][total discs] format
    /// - IIIIIIII  => 8-hex-digit certification submission identifier; usually on test discs only
    /// </remarks>
    public class XeMID
    {
        /// <summary>
        /// 2-character publisher identifier
        /// </summary>
#if NET48
        public string PublisherIdentifier { get; set; }
#else
        public string? PublisherIdentifier { get; set; }
#endif

        /// <summary>
        /// 1-character Platform disc is made for, 2 indicates Xbox 360
        /// </summary>
        public char PlatformIdentifier { get; set; }

        /// <summary>
        /// 3-character Game ID
        /// </summary>
#if NET48
        public string GameID { get; set; }
#else
        public string? GameID { get; set; }
#endif

        /// <summary>
        /// 2-character Title-specific SKU
        /// </summary>
#if NET48
        public string SKU { get; set; }
#else
        public string? SKU { get; set; }
#endif

        /// <summary>
        /// 1-character Region identifier character
        /// </summary>
        public char RegionIdentifier { get; set; }

        /// <summary>
        /// 2-character Base version of executables, usually starts at 01
        /// </summary>
#if NET48
        public string BaseVersion { get; set; }
#else
        public string? BaseVersion { get; set; }
#endif

        /// <summary>
        /// 1-character Media subtype identifier
        /// </summary>
        public char MediaSubtypeIdentifier { get; set; }

        /// <summary>
        /// 2-character Disc number stored in [disc number][total discs] format
        /// </summary>
#if NET48
        public string DiscNumberIdentifier { get; set; }
#else
        public string? DiscNumberIdentifier { get; set; }
#endif

        /// <summary>
        /// 8-hex-digit certification submission identifier; usually on test discs only
        /// </summary>
#if NET48
        public string CertificationSubmissionIdentifier { get; set; }
#else
        public string? CertificationSubmissionIdentifier { get; set; }
#endif
    }
}
