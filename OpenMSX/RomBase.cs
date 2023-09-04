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
        public string? Start { get; set; }

        [XmlElement("type")]
        public string? Type { get; set; }

        /// <remarks>SHA-1 hash</remarks>
        [XmlElement("hash")]
        public string? Hash { get; set; }

        [XmlElement("remark")]
        public string? Remark { get; set; }

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