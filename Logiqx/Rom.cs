using System.Xml;
using System.Xml.Serialization;

namespace SabreTools.Models.Logiqx
{
    [XmlRoot("rom")]
    public class Rom
    {
        [Required]
        [XmlAttribute("name")]
        public string? Name { get; set; }

        [Required]
        [XmlAttribute("size")]
        public string? Size { get; set; }

        [XmlAttribute("crc")]
        public string? CRC { get; set; }

        [XmlAttribute("md5")]
        public string? MD5 { get; set; }

        [XmlAttribute("sha1")]
        public string? SHA1 { get; set; }

        /// <remarks>Hash/No-Intro extension</remarks>
        [XmlAttribute("sha256")]
        public string? SHA256 { get; set; }

        /// <remarks>Hash extension</remarks>
        [XmlAttribute("sha384")]
        public string? SHA384 { get; set; }

        /// <remarks>Hash extension</remarks>
        [XmlAttribute("sha512")]
        public string? SHA512 { get; set; }

        /// <remarks>Hash extension</remarks>
        [XmlAttribute("spamsum")]
        public string? SpamSum { get; set; }

        /// <remarks>DiscImgeCreator extension</remarks>
        [XmlAttribute("xxh3_64")]
        public string? xxHash364 { get; set; }

        /// <remarks>DiscImgeCreator extension</remarks>
        [XmlAttribute("xxh3_128")]
        public string? xxHash3128 { get; set; }

        [XmlAttribute("merge")]
        public string? Merge { get; set; }

        /// <remarks>(baddump|nodump|good|verified) "good"</remarks>
        [XmlAttribute("status")]
        public string? Status { get; set; }

        /// <remarks>No-Intro extension</remarks>
        [XmlAttribute("serial")]
        public string? Serial { get; set; }

        /// <remarks>No-Intro extension</remarks>
        [XmlAttribute("header")]
        public string? Header { get; set; }

        [XmlAttribute("date")]
        public string? Date { get; set; }

        /// <remarks>Boolean; RomVault extension</remarks>
        [XmlAttribute("inverted")]
        public string? Inverted { get; set; }

        /// <remarks>Boolean; RomVault extension</remarks>
        [XmlAttribute("mia")]
        public string? MIA { get; set; }
        
        #region DO NOT USE IN PRODUCTION

        /// <remarks>Should be empty</remarks>
        [XmlAnyAttribute]
        public XmlAttribute[]? ADDITIONAL_ATTRIBUTES { get; set; }

        /// <remarks>Should be empty</remarks>
        [XmlAnyElement]
        public object[]? ADDITIONAL_ELEMENTS { get; set; }

        #endregion
    }
}