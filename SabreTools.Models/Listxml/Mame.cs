using System.Xml;
using System.Xml.Serialization;

namespace SabreTools.Models.Listxml
{
    [XmlRoot("mame")]
    public class Mame
    {
        [XmlAttribute("build")]
        public string? Build { get; set; }

        /// <remarks>(yes|no) "no"</remarks>
        [XmlAttribute("debug")]
        public string? Debug { get; set; }

        [Required]
        [XmlAttribute("mameconfig")]
        public string? MameConfig { get; set; }

        [XmlElement("machine", typeof(Machine))]
        [XmlElement("game", typeof(Game))]
        public GameBase[]? Game { get; set; }
    }
}