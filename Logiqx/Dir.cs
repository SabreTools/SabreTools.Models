using System.Xml;
using System.Xml.Serialization;

namespace SabreTools.Models.Logiqx
{
    [XmlRoot("dir")]
    public class Dir
    {
        [Required]
        [XmlAttribute("name")]
        public string? Name { get; set; }

        [XmlElement("game", typeof(Game))]
        [XmlElement("machine", typeof(Machine))]
        public GameBase[]? Game { get; set; }

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