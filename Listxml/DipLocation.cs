using System.Xml;
using System.Xml.Serialization;

namespace SabreTools.Models.Listxml
{
    [XmlRoot("diplocation")]
    public class DipLocation
    {
        [Required]
        [XmlAttribute("name")]
        public string? Name { get; set; }

        /// <remarks>Numeric?</remarks>
        [Required]
        [XmlAttribute("number")]
        public string? Number { get; set; }

        /// <remarks>(yes|no) "no"</remarks>
        [XmlAttribute("inverted")]
        public string? Inverted { get; set; }

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