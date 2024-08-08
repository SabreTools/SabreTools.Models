using System.Xml;
using System.Xml.Serialization;

namespace SabreTools.Models.OpenMSX
{
    [XmlRoot("original")]
    public class Original
    {
        /// <remarks>Boolean?</remarks>
        [XmlAttribute("value")]
        public string? Value { get; set; }

        [XmlText]
        public string? Content { get; set; }

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