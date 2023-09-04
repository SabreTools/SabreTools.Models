using System.Xml;
using System.Xml.Serialization;

namespace SabreTools.Models.OfflineList
{
    [XmlRoot("dat")]
    public class Dat
    {
        [XmlAttribute(Namespace = "http://www.w3.org/2001/XMLSchema-instance", AttributeName = "noNamespaceSchemaLocation")]
#if NET48
        public string NoNamespaceSchemaLocation { get; set; }
#else
        public string? NoNamespaceSchemaLocation { get; set; }
#endif

        [XmlElement("configuration")]
#if NET48
        public Configuration Configuration { get; set; }
#else
        public Configuration? Configuration { get; set; }
#endif

        [XmlElement("games")]
#if NET48
        public Games Games { get; set; }
#else
        public Games? Games { get; set; }
#endif

        [XmlElement("gui")]
#if NET48
        public GUI GUI { get; set; }
#else
        public GUI? GUI { get; set; }
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