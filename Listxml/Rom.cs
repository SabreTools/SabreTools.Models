using System.Xml;
using System.Xml.Serialization;

namespace SabreTools.Models.Listxml
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

        [XmlAttribute("bios")]
#if NET48
        public string Bios { get; set; }
#else
        public string? Bios { get; set; }
#endif

        /// <remarks>Numeric</remarks>
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

        [XmlAttribute("sha1")]
#if NET48
        public string SHA1 { get; set; }
#else
        public string? SHA1 { get; set; }
#endif

        [XmlAttribute("merge")]
#if NET48
        public string Merge { get; set; }
#else
        public string? Merge { get; set; }
#endif

        [XmlAttribute("region")]
#if NET48
        public string Region { get; set; }
#else
        public string? Region { get; set; }
#endif

        /// <remarks>Numeric</remarks>
        [XmlAttribute("offset")]
#if NET48
        public string Offset { get; set; }
#else
        public string? Offset { get; set; }
#endif

        /// <remarks>(baddump|nodump|good) "good"</remarks>
        [XmlAttribute("status")]
#if NET48
        public string Status { get; set; }
#else
        public string? Status { get; set; }
#endif

        /// <remarks>(yes|no) "no"</remarks>
        [XmlAttribute("optional")]
#if NET48
        public string Optional { get; set; }
#else
        public string? Optional { get; set; }
#endif

        /// <remarks>(yes|no) "no", Only present in older versions</remarks>
        [XmlAttribute("dispose")]
#if NET48
        public string Dispose { get; set; }
#else
        public string? Dispose { get; set; }
#endif

        /// <remarks>(yes|no) "no", Only present in older versions</remarks>
        [XmlAttribute("soundonly")]
#if NET48
        public string SoundOnly { get; set; }
#else
        public string? SoundOnly { get; set; }
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