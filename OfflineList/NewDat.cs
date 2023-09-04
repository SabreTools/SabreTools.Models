using System.Xml;
using System.Xml.Serialization;

namespace SabreTools.Models.OfflineList
{
    [XmlRoot("newDat")]
    public class NewDat
    {
        [XmlElement("datVersionURL")]
        public string? DatVersionUrl { get; set; }

        [XmlElement("datURL")]
        public DatUrl? DatUrl { get; set; }

        [XmlElement("imURL")]
        public string? ImUrl { get; set; }

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