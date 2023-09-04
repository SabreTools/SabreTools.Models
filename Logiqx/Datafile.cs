using System.Xml;
using System.Xml.Serialization;

namespace SabreTools.Models.Logiqx
{
    [XmlRoot("datafile")]
    public class Datafile
    {
        [XmlAttribute("build")]
#if NET48
        public string Build { get; set; }
#else
        public string? Build { get; set; }
#endif

        /// <remarks>(yes|no) "no"</remarks>
        [XmlAttribute("debug")]
#if NET48
        public string Debug { get; set; }
#else
        public string? Debug { get; set; }
#endif

        /// <remarks>No-Intro extension</remarks>
        [XmlAttribute(Namespace = "http://www.w3.org/2001/XMLSchema-instance", AttributeName = "schemaLocation")]
#if NET48
        public string SchemaLocation { get; set; }
#else
        public string? SchemaLocation { get; set; }
#endif

        [XmlElement("header")]
#if NET48
        public Header Header { get; set; }
#else
        public Header? Header { get; set; }
#endif

        [XmlElement("game", typeof(Game))]
        [XmlElement("machine", typeof(Machine))]
#if NET48
        public GameBase[] Game { get; set; }
#else
        public GameBase[]? Game { get; set; }
#endif

        /// <remarks>RomVault extension</remarks>
        [XmlElement("dir")]
#if NET48
        public Dir[] Dir { get; set; }
#else
        public Dir[]? Dir { get; set; }
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