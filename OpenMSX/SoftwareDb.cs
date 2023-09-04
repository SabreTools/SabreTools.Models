using System.Xml;
using System.Xml.Serialization;

namespace SabreTools.Models.OpenMSX
{
    [XmlRoot("softwaredb")]
    public class SoftwareDb
    {
        [XmlAttribute("timestamp")]
        public string? Timestamp { get; set; }

        [XmlElement("software")]
        public Software[]? Software { get; set; }

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