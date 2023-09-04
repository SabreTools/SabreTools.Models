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
        public string? Screen { get; set; }

        /// <remarks>(vertical|horizontal)</remarks>
        [Required]
        [XmlAttribute("orientation")]
        public string? Orientation { get; set; }

        /// <remarks>Numeric</remarks>
        [XmlAttribute("width")]
        public string? Width { get; set; }

        /// <remarks>Numeric</remarks>
        [XmlAttribute("height")]
        public string? Height { get; set; }

        /// <remarks>Numeric</remarks>
        [XmlAttribute("aspectx")]
        public string? AspectX { get; set; }

        /// <remarks>Numeric</remarks>
        [XmlAttribute("aspecty")]
        public string? AspectY { get; set; }

        /// <remarks>Numeric</remarks>
        [XmlAttribute("refresh")]
        public string? Refresh { get; set; }

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