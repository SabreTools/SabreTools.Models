using System.Xml;
using System.Xml.Serialization;

namespace SabreTools.Models.Listxml
{
    [XmlRoot("slot")]
    public class Slot
    {
        [Required]
        [XmlAttribute("name")]
        public string? Name { get; set; }

        [XmlElement("slotoption")]
        public SlotOption[]? SlotOption { get; set; }
    }
}