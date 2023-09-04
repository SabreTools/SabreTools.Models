using System.Xml;
using System.Xml.Serialization;

namespace SabreTools.Models.OpenMSX
{
    /// <summary>
    /// Base class to unify the various rom types
    /// </summary>
    public abstract class RomBase
    {
        [XmlElement("start")]
#if NET48
        public string Start { get; set; }
#else
        public string? Start { get; set; }
#endif

        [XmlElement("type")]
#if NET48
        public string Type { get; set; }
#else
        public string? Type { get; set; }
#endif

        /// <remarks>SHA-1 hash</remarks>
        [XmlElement("hash")]
#if NET48
        public string Hash { get; set; }
#else
        public string? Hash { get; set; }
#endif

        [XmlElement("remark")]
#if NET48
        public string Remark { get; set; }
#else
        public string? Remark { get; set; }
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