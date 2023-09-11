using System.Xml;
using System.Xml.Serialization;

namespace SabreTools.Models.ArchiveDotOrg
{
    [XmlRoot("files")]
    public class Files
    {
        [XmlElement("file")]
#if NET48
        public File[] File { get; set; }
#else
        public File?[]? File { get; set; }
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