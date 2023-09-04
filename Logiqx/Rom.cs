using System.Xml;
using System.Xml.Serialization;

namespace SabreTools.Models.Logiqx
{
    [XmlRoot("rom")]
    public class Rom
    {
        [Required]
        [XmlAttribute("name")]
#if NET48
        public string Name { get; set; }
#else
        public string? Name { get; set; }
#endif

        [Required]
        [XmlAttribute("size")]
#if NET48
        public string Size { get; set; }
#else
        public string? Size { get; set; }
#endif

        [XmlAttribute("crc")]
#if NET48
        public string CRC { get; set; }
#else
        public string? CRC { get; set; }
#endif

        [XmlAttribute("md5")]
#if NET48
        public string MD5 { get; set; }
#else
        public string? MD5 { get; set; }
#endif

        [XmlAttribute("sha1")]
#if NET48
        public string SHA1 { get; set; }
#else
        public string? SHA1 { get; set; }
#endif

        /// <remarks>Hash/No-Intro extension</remarks>
        [XmlAttribute("sha256")]
#if NET48
        public string SHA256 { get; set; }
#else
        public string? SHA256 { get; set; }
#endif

        /// <remarks>Hash extension</remarks>
        [XmlAttribute("sha384")]
#if NET48
        public string SHA384 { get; set; }
#else
        public string? SHA384 { get; set; }
#endif

        /// <remarks>Hash extension</remarks>
        [XmlAttribute("sha512")]
#if NET48
        public string SHA512 { get; set; }
#else
        public string? SHA512 { get; set; }
#endif

        /// <remarks>Hash extension</remarks>
        [XmlAttribute("spamsum")]
#if NET48
        public string SpamSum { get; set; }
#else
        public string? SpamSum { get; set; }
#endif

        /// <remarks>DiscImgeCreator extension</remarks>
        [XmlAttribute("xxh3_64")]
#if NET48
        public string xxHash364 { get; set; }
#else
        public string? xxHash364 { get; set; }
#endif

        /// <remarks>DiscImgeCreator extension</remarks>
        [XmlAttribute("xxh3_128")]
#if NET48
        public string xxHash3128 { get; set; }
#else
        public string? xxHash3128 { get; set; }
#endif

        [XmlAttribute("merge")]
#if NET48
        public string Merge { get; set; }
#else
        public string? Merge { get; set; }
#endif

        /// <remarks>(baddump|nodump|good|verified) "good"</remarks>
        [XmlAttribute("status")]
#if NET48
        public string Status { get; set; }
#else
        public string? Status { get; set; }
#endif

        /// <remarks>No-Intro extension</remarks>
        [XmlAttribute("serial")]
#if NET48
        public string Serial { get; set; }
#else
        public string? Serial { get; set; }
#endif

        /// <remarks>No-Intro extension</remarks>
        [XmlAttribute("header")]
#if NET48
        public string Header { get; set; }
#else
        public string? Header { get; set; }
#endif

        [XmlAttribute("date")]
#if NET48
        public string Date { get; set; }
#else
        public string? Date { get; set; }
#endif

        /// <remarks>Boolean; RomVault extension</remarks>
        [XmlAttribute("inverted")]
#if NET48
        public string Inverted { get; set; }
#else
        public string? Inverted { get; set; }
#endif

        /// <remarks>Boolean; RomVault extension</remarks>
        [XmlAttribute("mia")]
#if NET48
        public string MIA { get; set; }
#else
        public string? MIA { get; set; }
#endif
        
        #region DO NOT USE IN PRODUCTION

        /// <remarks>Should be empty</remarks>
        [XmlAnyAttribute]
#if NET48
        public XmlAttribute[] ADDITIONAL_ATTRIBUTES { get; set; }
#else
        public XmlAttribute[]? ADDITIONAL_ATTRIBUTES { get; set; }
#endif

        /// <remarks>Should be empty</remarks>
        [XmlAnyElement]
#if NET48
        public object[] ADDITIONAL_ELEMENTS { get; set; }
#else
        public object[]? ADDITIONAL_ELEMENTS { get; set; }
#endif

        #endregion
    }
}