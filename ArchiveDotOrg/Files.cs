using System.Xml;
using System.Xml.Serialization;

namespace SabreTools.Models.ArchiveDotOrg
{
    [XmlRoot("files")]
    public class Files
    {
        [XmlElement("file")]
        public File[]? File { get; set; }

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