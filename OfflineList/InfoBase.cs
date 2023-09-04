using System.Xml;
using System.Xml.Serialization;

namespace SabreTools.Models.OfflineList
{
    public class InfoBase
    {
        /// <remarks>Boolean</remarks>
        [XmlAttribute("visible")]
#if NET48
        public string Visible { get; set; }
#else
        public string? Visible { get; set; }
#endif

        /// <remarks>Boolean</remarks>
        [XmlAttribute("inNamingOption")]
#if NET48
        public string InNamingOption { get; set; }
#else
        public string? InNamingOption { get; set; }
#endif

        /// <remarks>Boolean</remarks>
        [XmlAttribute("default")]
#if NET48
        public string Default { get; set; }
#else
        public string? Default { get; set; }
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

    [XmlRoot("title")]
    public class Title : InfoBase { }

    [XmlRoot("location")]
    public class Location : InfoBase { }

    [XmlRoot("publisher")]
    public class Publisher : InfoBase { }

    [XmlRoot("sourceRom")]
    public class SourceRom : InfoBase { }

    [XmlRoot("saveType")]
    public class SaveType : InfoBase { }

    [XmlRoot("romSize")]
    public class RomSize : InfoBase { }

    [XmlRoot("releaseNumber")]
    public class ReleaseNumber : InfoBase { }

    [XmlRoot("imageNumber")]
    public class ImageNumber : InfoBase { }

    [XmlRoot("languageNumber")]
    public class LanguageNumber : InfoBase { }

    [XmlRoot("comment")]
    public class Comment : InfoBase { }

    [XmlRoot("romCRC")]
    public class RomCRC : InfoBase { }

    [XmlRoot("im1CRC")]
    public class Im1CRC : InfoBase { }

    [XmlRoot("im2CRC")]
    public class Im2CRC : InfoBase { }

    [XmlRoot("languages")]
    public class Languages : InfoBase { }
}