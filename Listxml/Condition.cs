using System.Xml;
using System.Xml.Serialization;

namespace SabreTools.Models.Listxml
{
    [XmlRoot("condition")]
    public class Condition
    {
        [Required]
        [XmlAttribute("tag")]
#if NET48
        public string Tag { get; set; }
#else
        public string? Tag { get; set; }
#endif

        [Required]
        [XmlAttribute("mask")]
#if NET48
        public string Mask { get; set; }
#else
        public string? Mask { get; set; }
#endif

        /// <remarks>(eq|ne|gt|le|lt|ge)</remarks>
        [Required]
        [XmlAttribute("relation")]
#if NET48
        public string Relation { get; set; }
#else
        public string? Relation { get; set; }
#endif

        [Required]
        [XmlAttribute("value")]
#if NET48
        public string Value { get; set; }
#else
        public string? Value { get; set; }
#endif

        #region DO NOT USE IN PRODUCTION

        /// <remarks>Should be empty</remarks>
        [XmlAnyAttribute]
#if NET48
        public XmlAttribute[] ADDITIONAL_ATTRIBUTES { get; set; }
#else
        public XmlAttribute[]? ADDITIONAL_ATTRIBUTES { get; set; }
#endif

        /// <remarks>Should be empty</remarks>
        [XmlAnyElement]
#if NET48
        public object[] ADDITIONAL_ELEMENTS { get; set; }
#else
        public object[]? ADDITIONAL_ELEMENTS { get; set; }
#endif

        #endregion
    }
}