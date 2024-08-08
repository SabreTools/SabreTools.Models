using System.Xml;
using System.Xml.Serialization;

namespace SabreTools.Models.Listxml
{
    [XmlRoot("confsetting")]
    public class ConfSetting
    {
        [Required]
        [XmlAttribute("name")]
        public string? Name { get; set; }

        [Required]
        [XmlAttribute("value")]
        public string? Value { get; set; }

        /// <remarks>(yes|no) "no"</remarks>
        [XmlAttribute("default")]
        public string? Default { get; set; }

        [XmlElement("condition")]
        public Condition? Condition { get; set; }

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