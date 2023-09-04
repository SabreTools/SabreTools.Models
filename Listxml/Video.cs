using System.Xml;
using System.Xml.Serialization;

namespace SabreTools.Models.Listxml
{
    [XmlRoot("video")]
    public class Video
    {
        /// <remarks>(raster|vector)</remarks>
        [Required]
        [XmlAttribute("screen")]
#if NET48
        public string Screen { get; set; }
#else
        public string? Screen { get; set; }
#endif

        /// <remarks>(vertical|horizontal)</remarks>
        [Required]
        [XmlAttribute("orientation")]
#if NET48
        public string Orientation { get; set; }
#else
        public string? Orientation { get; set; }
#endif

        /// <remarks>Numeric</remarks>
        [XmlAttribute("width")]
#if NET48
        public string Width { get; set; }
#else
        public string? Width { get; set; }
#endif

        /// <remarks>Numeric</remarks>
        [XmlAttribute("height")]
#if NET48
        public string Height { get; set; }
#else
        public string? Height { get; set; }
#endif

        /// <remarks>Numeric</remarks>
        [XmlAttribute("aspectx")]
#if NET48
        public string AspectX { get; set; }
#else
        public string? AspectX { get; set; }
#endif

        /// <remarks>Numeric</remarks>
        [XmlAttribute("aspecty")]
#if NET48
        public string AspectY { get; set; }
#else
        public string? AspectY { get; set; }
#endif

        /// <remarks>Numeric</remarks>
        [XmlAttribute("refresh")]
#if NET48
        public string Refresh { get; set; }
#else
        public string? Refresh { get; set; }
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