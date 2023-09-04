using System.Xml;
using System.Xml.Serialization;

namespace SabreTools.Models.SoftwareList
{
    [XmlRoot("part")]
    public class Part
    {
        [Required]
        [XmlAttribute("name")]
#if NET48
        public string Name { get; set; }
#else
        public string? Name { get; set; }
#endif

        [Required]
        [XmlAttribute("interface")]
#if NET48
        public string Interface { get; set; }
#else
        public string? Interface { get; set; }
#endif

        [XmlElement("feature")]
#if NET48
        public Feature[] Feature { get; set; }
#else
        public Feature[]? Feature { get; set; }
#endif

        [XmlElement("dataarea")]
#if NET48
        public DataArea[] DataArea { get; set; }
#else
        public DataArea[]? DataArea { get; set; }
#endif

        [XmlElement("diskarea")]
#if NET48
        public DiskArea[] DiskArea { get; set; }
#else
        public DiskArea[]? DiskArea { get; set; }
#endif

        [XmlElement("dipswitch")]
#if NET48
        public DipSwitch[] DipSwitch { get; set; }
#else
        public DipSwitch[]? DipSwitch { get; set; }
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