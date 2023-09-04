using System.Xml;
using System.Xml.Serialization;

namespace SabreTools.Models.Listxml
{
    [XmlRoot("feature")]
    public class Feature
    {
        /// <remarks>(protection|timing|graphics|palette|sound|capture|camera|microphone|controls|keyboard|mouse|media|disk|printer|tape|punch|drum|rom|comms|lan|wan)</remarks>
        [Required]
        [XmlAttribute("type")]
#if NET48
        public string Type { get; set; }
#else
        public string? Type { get; set; }
#endif

        /// <remarks>(unemulated|imperfect)</remarks>
        [XmlAttribute("status")]
#if NET48
        public string Status { get; set; }
#else
        public string? Status { get; set; }
#endif

        /// <remarks>(unemulated|imperfect)</remarks>
        [XmlAttribute("overall")]
#if NET48
        public string Overall { get; set; }
#else
        public string? Overall { get; set; }
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