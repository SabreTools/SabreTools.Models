using System.Xml;
using System.Xml.Serialization;

namespace SabreTools.Models.OfflineList
{
    [XmlRoot("to")]
    public class To
    {
        [XmlAttribute("value")]
        public string? Value { get; set; }

        /// <remarks>Boolean</remarks>
        [XmlAttribute("default")]
        public string? Default { get; set; }

        /// <remarks>Boolean</remarks>
        [XmlAttribute("auto")]
        public string? Auto { get; set; }

        [XmlElement("find")]
        public Find[]? Find { get; set; }

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