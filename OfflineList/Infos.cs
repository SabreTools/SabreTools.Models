using System.Xml;
using System.Xml.Serialization;

namespace SabreTools.Models.OfflineList
{
    [XmlRoot("infos")]
    public class Infos
    {
        [XmlElement("title")]
#if NET48
        public Title Title { get; set; }
#else
        public Title? Title { get; set; }
#endif

        [XmlElement("location")]
#if NET48
        public Location Location { get; set; }
#else
        public Location? Location { get; set; }
#endif

        [XmlElement("publisher")]
#if NET48
        public Publisher Publisher { get; set; }
#else
        public Publisher? Publisher { get; set; }
#endif

        [XmlElement("sourceRom")]
#if NET48
        public SourceRom SourceRom { get; set; }
#else
        public SourceRom? SourceRom { get; set; }
#endif

        [XmlElement("saveType")]
#if NET48
        public SaveType SaveType { get; set; }
#else
        public SaveType? SaveType { get; set; }
#endif

        [XmlElement("romSize")]
#if NET48
        public RomSize RomSize { get; set; }
#else
        public RomSize? RomSize { get; set; }
#endif

        [XmlElement("releaseNumber")]
#if NET48
        public ReleaseNumber ReleaseNumber { get; set; }
#else
        public ReleaseNumber? ReleaseNumber { get; set; }
#endif

        [XmlElement("languageNumber")]
#if NET48
        public LanguageNumber LanguageNumber { get; set; }
#else
        public LanguageNumber? LanguageNumber { get; set; }
#endif

        [XmlElement("comment")]
#if NET48
        public Comment Comment { get; set; }
#else
        public Comment? Comment { get; set; }
#endif

        [XmlElement("romCRC")]
#if NET48
        public RomCRC RomCRC { get; set; }
#else
        public RomCRC? RomCRC { get; set; }
#endif

        [XmlElement("im1CRC")]
#if NET48
        public Im1CRC Im1CRC { get; set; }
#else
        public Im1CRC? Im1CRC { get; set; }
#endif

        [XmlElement("im2CRC")]
#if NET48
        public Im2CRC Im2CRC { get; set; }
#else
        public Im2CRC? Im2CRC { get; set; }
#endif

        [XmlElement("languages")]
#if NET48
        public Languages Languages { get; set; }
#else
        public Languages? Languages { get; set; }
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