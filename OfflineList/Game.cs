using System.Xml;
using System.Xml.Serialization;

namespace SabreTools.Models.OfflineList
{
    [XmlRoot("game")]
    public class Game
    {
        [XmlElement("imageNumber")]
#if NET48
        public string ImageNumber { get; set; }
#else
        public string? ImageNumber { get; set; }
#endif

        [XmlElement("releaseNumber")]
#if NET48
        public string ReleaseNumber { get; set; }
#else
        public string? ReleaseNumber { get; set; }
#endif

        [XmlElement("title")]
#if NET48
        public string Title { get; set; }
#else
        public string? Title { get; set; }
#endif

        [XmlElement("saveType")]
#if NET48
        public string SaveType { get; set; }
#else
        public string? SaveType { get; set; }
#endif

        /// <remarks>Numeric</remarks>
        [XmlElement("romSize")]
#if NET48
        public string RomSize { get; set; }
#else
        public string? RomSize { get; set; }
#endif

        [XmlElement("publisher")]
#if NET48
        public string Publisher { get; set; }
#else
        public string? Publisher { get; set; }
#endif

        [XmlElement("location")]
#if NET48
        public string Location { get; set; }
#else
        public string? Location { get; set; }
#endif

        [XmlElement("sourceRom")]
#if NET48
        public string SourceRom { get; set; }
#else
        public string? SourceRom { get; set; }
#endif

        [XmlElement("language")]
#if NET48
        public string Language { get; set; }
#else
        public string? Language { get; set; }
#endif

        [XmlElement("files")]
#if NET48
        public Files Files { get; set; }
#else
        public Files? Files { get; set; }
#endif

        [XmlElement("im1CRC")]
#if NET48
        public string Im1CRC { get; set; }
#else
        public string? Im1CRC { get; set; }
#endif

        [XmlElement("im2CRC")]
#if NET48
        public string Im2CRC { get; set; }
#else
        public string? Im2CRC { get; set; }
#endif

        [XmlElement("comment")]
#if NET48
        public string Comment { get; set; }
#else
        public string? Comment { get; set; }
#endif

        [XmlElement("duplicateID")]
#if NET48
        public string DuplicateID { get; set; }
#else
        public string? DuplicateID { get; set; }
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