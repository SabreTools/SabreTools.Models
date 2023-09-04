using System.Xml;
using System.Xml.Serialization;

namespace SabreTools.Models.Logiqx
{
    [XmlRoot("clrmamepro")]
    public class ClrMamePro
    {
        [XmlAttribute("header")]
#if NET48
        public string Header { get; set; }
#else
        public string? Header { get; set; }
#endif

        /// <remarks>(none|split|merged|nonmerged|fullmerged|device|full) "split"</remarks>
        [XmlAttribute("forcemerging")]
#if NET48
        public string ForceMerging { get; set; }
#else
        public string? ForceMerging { get; set; }
#endif

        /// <remarks>(obsolete|required|ignore) "obsolete"</remarks>
        [XmlAttribute("forcenodump")]
#if NET48
        public string ForceNodump { get; set; }
#else
        public string? ForceNodump { get; set; }
#endif

        /// <remarks>(zip|unzip) "zip"</remarks>
        [XmlAttribute("forcepacking")]
#if NET48
        public string ForcePacking { get; set; }
#else
        public string? ForcePacking { get; set; }
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