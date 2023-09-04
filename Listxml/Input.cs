using System.Xml;
using System.Xml.Serialization;

namespace SabreTools.Models.Listxml
{
    [XmlRoot("input")]
    public class Input
    {
        /// <remarks>(yes|no) "no"</remarks>
        [XmlAttribute("service")]
#if NET48
        public string Service { get; set; }
#else
        public string? Service { get; set; }
#endif

        /// <remarks>(yes|no) "no"</remarks>
        [XmlAttribute("tilt")]
#if NET48
        public string Tilt { get; set; }
#else
        public string? Tilt { get; set; }
#endif

        /// <remarks>Numeric</remarks>
        [Required]
        [XmlAttribute("players")]
#if NET48
        public string Players { get; set; }
#else
        public string? Players { get; set; }
#endif

        /// <remarks>Only present in older versions</remarks>
        [XmlAttribute("control")]
#if NET48
        public string ControlAttr { get; set; }
#else
        public string? ControlAttr { get; set; }
#endif

        /// <remarks>Only present in older versions, Numeric?</remarks>
        [XmlAttribute("buttons")]
#if NET48
        public string Buttons { get; set; }
#else
        public string? Buttons { get; set; }
#endif

        /// <remarks>Numeric?</remarks>
        [XmlAttribute("coins")]
#if NET48
        public string Coins { get; set; }
#else
        public string? Coins { get; set; }
#endif

        [XmlElement("control")]
#if NET48
        public Control[] Control { get; set; }
#else
        public Control[]? Control { get; set; }
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