using System.Xml;
using System.Xml.Serialization;

namespace SabreTools.Models.OfflineList
{
    [XmlRoot("game")]
    public class Game
    {
        [XmlElement("imageNumber")]
        public string? ImageNumber { get; set; }

        [XmlElement("releaseNumber")]
        public string? ReleaseNumber { get; set; }

        [XmlElement("title")]
        public string? Title { get; set; }

        [XmlElement("saveType")]
        public string? SaveType { get; set; }

        /// <remarks>Numeric</remarks>
        [XmlElement("romSize")]
        public string? RomSize { get; set; }

        [XmlElement("publisher")]
        public string? Publisher { get; set; }

        [XmlElement("location")]
        public string? Location { get; set; }

        [XmlElement("sourceRom")]
        public string? SourceRom { get; set; }

        [XmlElement("language")]
        public string? Language { get; set; }

        [XmlElement("files")]
        public Files? Files { get; set; }

        [XmlElement("im1CRC")]
        public string? Im1CRC { get; set; }

        [XmlElement("im2CRC")]
        public string? Im2CRC { get; set; }

        [XmlElement("comment")]
        public string? Comment { get; set; }

        [XmlElement("duplicateID")]
        public string? DuplicateID { get; set; }

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