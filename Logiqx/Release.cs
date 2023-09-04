using System.Xml;
using System.Xml.Serialization;

namespace SabreTools.Models.Logiqx
{
    [XmlRoot("release")]
    public class Release
    {
        [Required]
        [XmlAttribute("name")]
#if NET48
        public string Name { get; set; }
#else
        public string? Name { get; set; }
#endif

        [Required]
        [XmlAttribute("region")]
#if NET48
        public string Region { get; set; }
#else
        public string? Region { get; set; }
#endif

        [XmlAttribute("language")]
#if NET48
        public string Language { get; set; }
#else
        public string? Language { get; set; }
#endif

        [XmlAttribute("date")]
#if NET48
        public string Date { get; set; }
#else
        public string? Date { get; set; }
#endif

        /// <remarks>(yes|no) "no"</remarks>
        [XmlAttribute("default")]
#if NET48
        public string Default { get; set; }
#else
        public string? Default { get; set; }
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