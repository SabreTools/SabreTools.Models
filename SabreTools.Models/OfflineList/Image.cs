using System.Xml;
using System.Xml.Serialization;

namespace SabreTools.Models.OfflineList
{
    [XmlRoot("image")]
    public class Image
    {
        [XmlAttribute("x")]
        public string? X { get; set; }

        [XmlAttribute("y")]
        public string? Y { get; set; }

        [XmlAttribute("width")]
        public string? Width { get; set; }

        [XmlAttribute("height")]
        public string? Height { get; set; }

        #region DO NOT USE IN PRODUCTION

        /// <remarks>Should be empty</remarks>
        [XmlAnyAttribute]
        public XmlAttribute[]? ADDITIONAL_ATTRIBUTES { get; set; }

        /// <remarks>Should be empty</remarks>
        [XmlAnyElement]
        public object[]? ADDITIONAL_ELEMENTS { get; set; }

        #endregion
    }
}