using System.Xml;
using System.Xml.Serialization;

namespace SabreTools.Models.Listxml
{
    [XmlRoot("chip")]
    public class Chip
    {
        [Required]
        [XmlAttribute("name")]
#if NET48
        public string Name { get; set; }
#else
        public string? Name { get; set; }
#endif

        [XmlAttribute("tag")]
#if NET48
        public string Tag { get; set; }
#else
        public string? Tag { get; set; }
#endif

        /// <remarks>(cpu|audio)</remarks>
        [Required]
        [XmlAttribute("type")]
#if NET48
        public string Type { get; set; }
#else
        public string? Type { get; set; }
#endif

        /// <remarks>Only present in older versions</remarks>
        [XmlAttribute("soundonly")]
#if NET48
        public string SoundOnly { get; set; }
#else
        public string? SoundOnly { get; set; }
#endif

        [XmlAttribute("clock")]
#if NET48
        public string Clock { get; set; }
#else
        public string? Clock { get; set; }
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