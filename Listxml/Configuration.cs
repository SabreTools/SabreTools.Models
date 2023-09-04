using System.Xml;
using System.Xml.Serialization;

namespace SabreTools.Models.Listxml
{
    [XmlRoot("configuration")]
    public class Configuration
    {
        [Required]
        [XmlAttribute("name")]
#if NET48
        public string Name { get; set; }
#else
        public string? Name { get; set; }
#endif

        [Required]
        [XmlAttribute("tag")]
#if NET48
        public string Tag { get; set; }
#else
        public string? Tag { get; set; }
#endif

        [XmlAttribute("mask")]
#if NET48
        public string Mask { get; set; }
#else
        public string? Mask { get; set; }
#endif

        [XmlElement("condition")]
#if NET48
        public Condition Condition { get; set; }
#else
        public Condition? Condition { get; set; }
#endif

        [XmlElement("conflocation")]
#if NET48
        public ConfLocation[] ConfLocation { get; set; }
#else
        public ConfLocation[]? ConfLocation { get; set; }
#endif

        [XmlElement("confsetting")]
#if NET48
        public ConfSetting[] ConfSetting { get; set; }
#else
        public ConfSetting[]? ConfSetting { get; set; }
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