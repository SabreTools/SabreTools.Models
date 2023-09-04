using System.Xml;
using System.Xml.Serialization;

namespace SabreTools.Models.Listxml
{
    [XmlRoot("disk")]
    public class Disk
    {
        [Required]
        [XmlAttribute("name")]
#if NET48
        public string Name { get; set; }
#else
        public string? Name { get; set; }
#endif

        /// <remarks>Only present in older versions</remarks>
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

        /// <remarks>Numeric?</remarks>
        [XmlAttribute("index")]
#if NET48
        public string Index { get; set; }
#else
        public string? Index { get; set; }
#endif

        /// <remarks>(yes|no) "no"</remarks>
        [XmlAttribute("writable")]
#if NET48
        public string Writable { get; set; }
#else
        public string? Writable { get; set; }
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