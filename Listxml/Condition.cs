using System.Xml;
using System.Xml.Serialization;

namespace SabreTools.Models.Listxml
{
    [XmlRoot("condition")]
    public class Condition
    {
        [Required]
        [XmlAttribute("tag")]
        public string? Tag { get; set; }

        [Required]
        [XmlAttribute("mask")]
        public string? Mask { get; set; }

        /// <remarks>(eq|ne|gt|le|lt|ge)</remarks>
        [Required]
        [XmlAttribute("relation")]
        public string? Relation { get; set; }

        [Required]
        [XmlAttribute("value")]
        public string? Value { get; set; }

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