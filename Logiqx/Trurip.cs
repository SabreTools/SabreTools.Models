using System.Xml;
using System.Xml.Serialization;

namespace SabreTools.Models.Logiqx
{
    [XmlRoot("trurip")]
    public class Trurip
    {
        [XmlElement("titleid")]
#if NET48
        public string TitleID { get; set; }
#else
        public string? TitleID { get; set; }
#endif

        [XmlElement("publisher")]
#if NET48
        public string Publisher { get; set; }
#else
        public string? Publisher { get; set; }
#endif

        [XmlElement("developer")]
#if NET48
        public string Developer { get; set; }
#else
        public string? Developer { get; set; }
#endif

        [XmlElement("year")]
#if NET48
        public string Year { get; set; }
#else
        public string? Year { get; set; }
#endif

        [XmlElement("genre")]
#if NET48
        public string Genre { get; set; }
#else
        public string? Genre { get; set; }
#endif

        [XmlElement("subgenre")]
#if NET48
        public string Subgenre { get; set; }
#else
        public string? Subgenre { get; set; }
#endif

        [XmlElement("ratings")]
#if NET48
        public string Ratings { get; set; }
#else
        public string? Ratings { get; set; }
#endif

        [XmlElement("score")]
#if NET48
        public string Score { get; set; }
#else
        public string? Score { get; set; }
#endif

        [XmlElement("players")]
#if NET48
        public string Players { get; set; }
#else
        public string? Players { get; set; }
#endif

        /// <remarks>Boolean?</remarks>
        [XmlElement("enabled")]
#if NET48
        public string Enabled { get; set; }
#else
        public string? Enabled { get; set; }
#endif

        [XmlElement("crc")]
#if NET48
        public string CRC { get; set; }
#else
        public string? CRC { get; set; }
#endif

        [XmlElement("source")]
#if NET48
        public string Source { get; set; }
#else
        public string? Source { get; set; }
#endif

        [XmlElement("cloneof")]
#if NET48
        public string CloneOf { get; set; }
#else
        public string? CloneOf { get; set; }
#endif

        [XmlElement("relatedto")]
#if NET48
        public string RelatedTo { get; set; }
#else
        public string? RelatedTo { get; set; }
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