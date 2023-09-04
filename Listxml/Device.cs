using System.Xml;
using System.Xml.Serialization;

namespace SabreTools.Models.Listxml
{
    [XmlRoot("device")]
    public class Device
    {
        [Required]
        [XmlAttribute("type")]
#if NET48
        public string Type { get; set; }
#else
        public string? Type { get; set; }
#endif

        [XmlAttribute("tag")]
#if NET48
        public string Tag { get; set; }
#else
        public string? Tag { get; set; }
#endif

        [XmlAttribute("fixed_image")]
#if NET48
        public string FixedImage { get; set; }
#else
        public string? FixedImage { get; set; }
#endif

        /// <remarks>Numeric boolean</remarks>
        [XmlAttribute("mandatory")]
#if NET48
        public string Mandatory { get; set; }
#else
        public string? Mandatory { get; set; }
#endif

        [XmlAttribute("interface")]
#if NET48
        public string Interface { get; set; }
#else
        public string? Interface { get; set; }
#endif

        [XmlElement("instance")]
#if NET48
        public Instance Instance { get; set; }
#else
        public Instance? Instance { get; set; }
#endif

        [XmlElement("extension")]
#if NET48
        public Extension[] Extension { get; set; }
#else
        public Extension[]? Extension { get; set; }
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