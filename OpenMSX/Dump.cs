using System.Xml;
using System.Xml.Serialization;

namespace SabreTools.Models.OpenMSX
{
    [XmlRoot("dump")]
    public class Dump
    {
        [XmlElement("original")]
#if NET48
        public Original Original { get; set; }
#else
        public Original? Original { get; set; }
#endif

        [XmlElement("rom", typeof(Rom))]
        [XmlElement("megarom", typeof(MegaRom))]
        [XmlElement("sccpluscart", typeof(SCCPlusCart))]
#if NET48
        public RomBase Rom { get; set; }
#else
        public RomBase? Rom { get; set; }
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