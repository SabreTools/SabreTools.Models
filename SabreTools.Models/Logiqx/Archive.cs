using System.Xml;
using System.Xml.Serialization;

namespace SabreTools.Models.Logiqx
{
    [XmlRoot("archive")]
    public class Archive
    {
        [Required]
        [XmlAttribute("name")]
        public string? Name { get; set; }
    }
}