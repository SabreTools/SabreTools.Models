using System.Xml;
using System.Xml.Serialization;

namespace SabreTools.Models.Listxml
{
    [XmlRoot("m1")]
    public class M1
    {
        [XmlAttribute("version")]
#if NET48
        public string Version { get; set; }
#else
        public string? Version { get; set; }
#endif

        [XmlElement("machine", typeof(Machine))]
        [XmlElement("game", typeof(Game))]
#if NET48
        public GameBase[] Game { get; set; }
#else
        public GameBase[]? Game { get; set; }
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