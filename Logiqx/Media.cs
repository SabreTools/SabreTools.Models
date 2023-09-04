using System.Xml;
using System.Xml.Serialization;

namespace SabreTools.Models.Logiqx
{
    [XmlRoot("media")]
    public class Media
    {
        [Required]
        [XmlAttribute("name")]
#if NET48
        public string Name { get; set; }
#else
        public string? Name { get; set; }
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

        [XmlAttribute("sha256")]
#if NET48
        public string SHA256 { get; set; }
#else
        public string? SHA256 { get; set; }
#endif

        [XmlAttribute("spamsum")]
#if NET48
        public string SpamSum { get; set; }
#else
        public string? SpamSum { get; set; }
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