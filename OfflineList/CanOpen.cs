using System.Xml;
using System.Xml.Serialization;

namespace SabreTools.Models.OfflineList
{
    [XmlRoot("canOpen")]
    public class CanOpen
    {
        [XmlElement("extension")]
        public string[]? Extension { get; set; }

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