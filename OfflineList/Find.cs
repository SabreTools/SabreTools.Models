using System.Xml;
using System.Xml.Serialization;

namespace SabreTools.Models.OfflineList
{
    [XmlRoot("find")]
    public class Find
    {
        [XmlAttribute("operation")]
#if NET48
        public string Operation { get; set; }
#else
        public string? Operation { get; set; }
#endif

        /// <remarks>Numeric?</remarks>
        [XmlAttribute("value")]
#if NET48
        public string Value { get; set; }
#else
        public string? Value { get; set; }
#endif

        [XmlText]
#if NET48
        public string Content { get; set; }
#else
        public string? Content { get; set; }
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