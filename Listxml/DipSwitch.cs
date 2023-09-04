using System.Xml;
using System.Xml.Serialization;

namespace SabreTools.Models.Listxml
{
    [XmlRoot("dipswitch")]
    public class DipSwitch
    {
        [Required]
        [XmlAttribute("name")]
        public string? Name { get; set; }

        [Required]
        [XmlAttribute("tag")]
        public string? Tag { get; set; }

        [XmlAttribute("mask")]
        public string? Mask { get; set; }

        [XmlElement("condition")]
        public Condition? Condition { get; set; }

        [XmlElement("diplocation")]
        public DipLocation[]? DipLocation { get; set; }

        [XmlElement("dipvalue")]
        public DipValue[]? DipValue { get; set; }

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