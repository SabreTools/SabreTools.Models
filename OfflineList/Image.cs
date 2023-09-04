using System.Xml;
using System.Xml.Serialization;

namespace SabreTools.Models.OfflineList
{
    [XmlRoot("image")]
    public class Image
    {
        [XmlAttribute("x")]
#if NET48
        public string X { get; set; }
#else
        public string? X { get; set; }
#endif

        [XmlAttribute("y")]
#if NET48
        public string Y { get; set; }
#else
        public string? Y { get; set; }
#endif

        [XmlAttribute("width")]
#if NET48
        public string Width { get; set; }
#else
        public string? Width { get; set; }
#endif

        [XmlAttribute("height")]
#if NET48
        public string Height { get; set; }
#else
        public string? Height { get; set; }
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