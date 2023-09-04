using System.Xml;
using System.Xml.Serialization;

namespace SabreTools.Models.SoftwareList
{
    [XmlRoot("dataarea")]
    public class DataArea
    {
        [Required]
        [XmlAttribute("name")]
        public string? Name { get; set; }

        [Required]
        [XmlAttribute("size")]
        public string? Size { get; set; }
        
        /// <remarks>(8|16|32|64) "8"</remarks>
        [XmlAttribute("width")]
        public string? Width { get; set; }
        
        /// <remarks>(big|little) "little"</remarks>
        [XmlAttribute("endianness")]
        public string? Endianness { get; set; }

        [XmlElement("rom")]
        public Rom[]? Rom { get; set; }

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