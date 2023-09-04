using System.Xml;
using System.Xml.Serialization;

namespace SabreTools.Models.SoftwareList
{
    [XmlRoot("software")]
    public class Software
    {
        [Required]
        [XmlAttribute("name")]
#if NET48
        public string Name { get; set; }
#else
        public string? Name { get; set; }
#endif

        [XmlAttribute("cloneof")]
#if NET48
        public string CloneOf { get; set; }
#else
        public string? CloneOf { get; set; }
#endif

        /// <remarks>(yes|partial|no) "yes"</remarks>
        [XmlAttribute("supported")]
#if NET48
        public string Supported { get; set; }
#else
        public string? Supported { get; set; }
#endif

        [Required]
        [XmlElement("description")]
#if NET48
        public string Description { get; set; }
#else
        public string? Description { get; set; }
#endif

        [Required]
        [XmlElement("year")]
#if NET48
        public string Year { get; set; }
#else
        public string? Year { get; set; }
#endif

        [Required]
        [XmlElement("publisher")]
#if NET48
        public string Publisher { get; set; }
#else
        public string? Publisher { get; set; }
#endif

        [XmlElement("notes")]
#if NET48
        public string Notes { get; set; }
#else
        public string? Notes { get; set; }
#endif

        [XmlElement("info")]
#if NET48
        public Info[] Info { get; set; }
#else
        public Info[]? Info { get; set; }
#endif

        [XmlElement("sharedfeat")]
#if NET48
        public SharedFeat[] SharedFeat { get; set; }
#else
        public SharedFeat[]? SharedFeat { get; set; }
#endif

        [XmlElement("part")]
#if NET48
        public Part[] Part { get; set; }
#else
        public Part[]? Part { get; set; }
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