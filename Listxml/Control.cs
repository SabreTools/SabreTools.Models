using System.Xml;
using System.Xml.Serialization;

namespace SabreTools.Models.Listxml
{
    [XmlRoot("control")]
    public class Control
    {
        /// <remarks>(joy|stick|paddle|pedal|lightgun|positional|dial|trackball|mouse|only_buttons|keypad|keyboard|mahjong|hanafuda|gambling)</remarks>
        [Required]
        [XmlAttribute("type")]
#if NET48
        public string Type { get; set; }
#else
        public string? Type { get; set; }
#endif

        /// <remarks>Numeric</remarks>
        [XmlAttribute("player")]
#if NET48
        public string Player { get; set; }
#else
        public string? Player { get; set; }
#endif

        /// <remarks>Numeric</remarks>
        [XmlAttribute("buttons")]
#if NET48
        public string Buttons { get; set; }
#else
        public string? Buttons { get; set; }
#endif

        /// <remarks>Numeric</remarks>
        [XmlAttribute("reqbuttons")]
#if NET48
        public string ReqButtons { get; set; }
#else
        public string? ReqButtons { get; set; }
#endif

        /// <remarks>Numeric</remarks>
        [XmlAttribute("minimum")]
#if NET48
        public string Minimum { get; set; }
#else
        public string? Minimum { get; set; }
#endif

        /// <remarks>Numeric</remarks>
        [XmlAttribute("maximum")]
#if NET48
        public string Maximum { get; set; }
#else
        public string? Maximum { get; set; }
#endif

        /// <remarks>Numeric</remarks>
        [XmlAttribute("sensitivity")]
#if NET48
        public string Sensitivity { get; set; }
#else
        public string? Sensitivity { get; set; }
#endif

        /// <remarks>Numeric</remarks>
        [XmlAttribute("keydelta")]
#if NET48
        public string KeyDelta { get; set; }
#else
        public string? KeyDelta { get; set; }
#endif

        /// <remarks>(yes|no) "no"</remarks>
        [XmlAttribute("reverse")]
#if NET48
        public string Reverse { get; set; }
#else
        public string? Reverse { get; set; }
#endif

        /// <remarks>Numeric?</remarks>
        [XmlAttribute("ways")]
#if NET48
        public string Ways { get; set; }
#else
        public string? Ways { get; set; }
#endif

        /// <remarks>Numeric?</remarks>
        [XmlAttribute("ways2")]
#if NET48
        public string Ways2 { get; set; }
#else
        public string? Ways2 { get; set; }
#endif

        /// <remarks>Numeric?</remarks>
        [XmlAttribute("ways3")]
#if NET48
        public string Ways3 { get; set; }
#else
        public string? Ways3 { get; set; }
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