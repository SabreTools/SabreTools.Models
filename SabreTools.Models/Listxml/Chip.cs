using System.Xml;
using System.Xml.Serialization;

namespace SabreTools.Models.Listxml
{
    [XmlRoot("chip")]
    public class Chip
    {
        [Required]
        [XmlAttribute("name")]
        public string? Name { get; set; }

        [XmlAttribute("tag")]
        public string? Tag { get; set; }

        /// <remarks>(cpu|audio)</remarks>
        [Required]
        [XmlAttribute("type")]
        public string? Type { get; set; }

        /// <remarks>Only present in older versions</remarks>
        [XmlAttribute("soundonly")]
        public string? SoundOnly { get; set; }

        [XmlAttribute("clock")]
        public string? Clock { get; set; }

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