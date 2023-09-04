using System.Xml;
using System.Xml.Serialization;

namespace SabreTools.Models.Listxml
{
    [XmlRoot("confsetting")]
    public class ConfSetting
    {
        [Required]
        [XmlAttribute("name")]
#if NET48
        public string Name { get; set; }
#else
        public string? Name { get; set; }
#endif

        [Required]
        [XmlAttribute("value")]
#if NET48
        public string Value { get; set; }
#else
        public string? Value { get; set; }
#endif

        /// <remarks>(yes|no) "no"</remarks>
        [XmlAttribute("default")]
#if NET48
        public string Default { get; set; }
#else
        public string? Default { get; set; }
#endif

        [XmlElement("condition")]
#if NET48
        public Condition Condition { get; set; }
#else
        public Condition? Condition { get; set; }
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