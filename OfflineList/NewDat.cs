using System.Xml;
using System.Xml.Serialization;

namespace SabreTools.Models.OfflineList
{
    [XmlRoot("newDat")]
    public class NewDat
    {
        [XmlElement("datVersionURL")]
#if NET48
        public string DatVersionUrl { get; set; }
#else
        public string? DatVersionUrl { get; set; }
#endif

        [XmlElement("datURL")]
#if NET48
        public DatUrl DatUrl { get; set; }
#else
        public DatUrl? DatUrl { get; set; }
#endif

        [XmlElement("imURL")]
#if NET48
        public string ImUrl { get; set; }
#else
        public string? ImUrl { get; set; }
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