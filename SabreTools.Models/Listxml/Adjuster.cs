using System.Xml;
using System.Xml.Serialization;

namespace SabreTools.Models.Listxml
{
    [XmlRoot("adjuster")]
    public class Adjuster
    {
        [Required]
        [XmlAttribute("name")]
        public string? Name { get; set; }

        /// <remarks>(yes|no) "no"</remarks>
        [XmlAttribute("default")]
        public string? Default { get; set; }

        [XmlElement("condition")]
        public Condition? Condition { get; set; }
    }
}