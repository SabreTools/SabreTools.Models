using System.Xml;
using System.Xml.Serialization;

namespace SabreTools.Models.Listxml
{
    [XmlRoot("display")]
    public class Display
    {
        [XmlAttribute("tag")]
#if NET48
        public string Tag { get; set; }
#else
        public string? Tag { get; set; }
#endif

        /// <remarks>(raster|vector|lcd|svg|unknown)</remarks>
        [Required]
        [XmlAttribute("type")]
#if NET48
        public string Type { get; set; }
#else
        public string? Type { get; set; }
#endif

        /// <remarks>(0|90|180|270)</remarks>
        [XmlAttribute("rotate")]
#if NET48
        public string Rotate { get; set; }
#else
        public string? Rotate { get; set; }
#endif

        /// <remarks>(yes|no) "no"</remarks>
        [XmlAttribute("flipx")]
#if NET48
        public string FlipX { get; set; }
#else
        public string? FlipX { get; set; }
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
        [Required]
        [XmlAttribute("refresh")]
#if NET48
        public string Refresh { get; set; }
#else
        public string? Refresh { get; set; }
#endif

        /// <remarks>Numeric</remarks>
        [XmlAttribute("pixclock")]
#if NET48
        public string PixClock { get; set; }
#else
        public string? PixClock { get; set; }
#endif

        /// <remarks>Numeric</remarks>
        [XmlAttribute("htotal")]
#if NET48
        public string HTotal { get; set; }
#else
        public string? HTotal { get; set; }
#endif

        /// <remarks>Numeric</remarks>
        [XmlAttribute("hbend")]
#if NET48
        public string HBEnd { get; set; }
#else
        public string? HBEnd { get; set; }
#endif

        /// <remarks>Numeric</remarks>
        [XmlAttribute("hbstart")]
#if NET48
        public string HBStart { get; set; }
#else
        public string? HBStart { get; set; }
#endif

        /// <remarks>Numeric</remarks>
        [XmlAttribute("vtotal")]
#if NET48
        public string VTotal { get; set; }
#else
        public string? VTotal { get; set; }
#endif

        /// <remarks>Numeric</remarks>
        [XmlAttribute("vbend")]
#if NET48
        public string VBEnd { get; set; }
#else
        public string? VBEnd { get; set; }
#endif

        /// <remarks>Numeric</remarks>
        [XmlAttribute("vbstart")]
#if NET48
        public string VBStart { get; set; }
#else
        public string? VBStart { get; set; }
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