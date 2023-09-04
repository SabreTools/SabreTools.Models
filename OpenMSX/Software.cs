using System.Xml;
using System.Xml.Serialization;

namespace SabreTools.Models.OpenMSX
{
    [XmlRoot("software")]
    public class Software
    {
        [Required]
        [XmlElement("title")]
#if NET48
        public string Title { get; set; }
#else
        public string? Title { get; set; }
#endif

        [XmlElement("genmsxid")]
#if NET48
        public string GenMSXID { get; set; }
#else
        public string? GenMSXID { get; set; }
#endif

        [Required]
        [XmlElement("system")]
#if NET48
        public string System { get; set; }
#else
        public string? System { get; set; }
#endif

        [Required]
        [XmlElement("company")]
#if NET48
        public string Company { get; set; }
#else
        public string? Company { get; set; }
#endif

        [Required]
        [XmlElement("year")]
#if NET48
        public string Year { get; set; }
#else
        public string? Year { get; set; }
#endif

        [Required]
        [XmlElement("country")]
#if NET48
        public string Country { get; set; }
#else
        public string? Country { get; set; }
#endif

        [XmlElement("dump")]
#if NET48
        public Dump[] Dump { get; set; }
#else
        public Dump[]? Dump { get; set; }
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