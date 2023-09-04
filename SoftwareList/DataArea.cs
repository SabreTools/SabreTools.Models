using System.Xml;
using System.Xml.Serialization;

namespace SabreTools.Models.SoftwareList
{
    [XmlRoot("dataarea")]
    public class DataArea
    {
        [Required]
        [XmlAttribute("name")]
#if NET48
        public string Name { get; set; }
#else
        public string? Name { get; set; }
#endif

        [Required]
        [XmlAttribute("size")]
#if NET48
        public string Size { get; set; }
#else
        public string? Size { get; set; }
#endif
        
        /// <remarks>(8|16|32|64) "8"</remarks>
        [XmlAttribute("width")]
#if NET48
        public string Width { get; set; }
#else
        public string? Width { get; set; }
#endif
        
        /// <remarks>(big|little) "little"</remarks>
        [XmlAttribute("endianness")]
#if NET48
        public string Endianness { get; set; }
#else
        public string? Endianness { get; set; }
#endif

        [XmlElement("rom")]
#if NET48
        public Rom[] Rom { get; set; }
#else
        public Rom[]? Rom { get; set; }
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