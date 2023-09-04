using System.Xml;
using System.Xml.Serialization;

namespace SabreTools.Models.OfflineList
{
    [XmlRoot("to")]
    public class To
    {
        [XmlAttribute("value")]
#if NET48
        public string Value { get; set; }
#else
        public string? Value { get; set; }
#endif

        /// <remarks>Boolean</remarks>
        [XmlAttribute("default")]
#if NET48
        public string Default { get; set; }
#else
        public string? Default { get; set; }
#endif

        /// <remarks>Boolean</remarks>
        [XmlAttribute("auto")]
#if NET48
        public string Auto { get; set; }
#else
        public string? Auto { get; set; }
#endif

        [XmlElement("find")]
#if NET48
        public Find[] Find { get; set; }
#else
        public Find[]? Find { get; set; }
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