using System.Xml;
using System.Xml.Serialization;

namespace SabreTools.Models.SoftwareList
{
    [XmlRoot("part")]
    public class Part
    {
        [Required]
        [XmlAttribute("name")]
        public string? Name { get; set; }

        [Required]
        [XmlAttribute("interface")]
        public string? Interface { get; set; }

        [XmlElement("feature")]
        public Feature[]? Feature { get; set; }

        [XmlElement("dataarea")]
        public DataArea[]? DataArea { get; set; }

        [XmlElement("diskarea")]
        public DiskArea[]? DiskArea { get; set; }

        [XmlElement("dipswitch")]
        public DipSwitch[]? DipSwitch { get; set; }

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