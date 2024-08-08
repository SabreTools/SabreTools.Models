using System.Xml;
using System.Xml.Serialization;

namespace SabreTools.Models.SoftwareList
{
    [XmlRoot("softwarelist")]
    public class SoftwareList
    {
        [Required]
        [XmlAttribute("name")]
        public string? Name { get; set; }

        [XmlAttribute("description")]
        public string? Description { get; set; }

        [XmlElement("notes")]
        public string? Notes { get; set; }

        [XmlElement("software")]
        public Software[]? Software { get; set; }

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