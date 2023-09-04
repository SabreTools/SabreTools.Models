using System.Xml;
using System.Xml.Serialization;

namespace SabreTools.Models.Listxml
{
    [XmlRoot("driver")]
    public class Driver
    {
        /// <remarks>(good|imperfect|preliminary), (good|preliminary|test) in older versions</remarks>
        [Required]
        [XmlAttribute("status")]
#if NET48
        public string Status { get; set; }
#else
        public string? Status { get; set; }
#endif

        /// <remarks>(good|imperfect|preliminary), Only present in older versions</remarks>
        [XmlAttribute("color")]
#if NET48
        public string Color { get; set; }
#else
        public string? Color { get; set; }
#endif

        /// <remarks>(good|imperfect|preliminary), Only present in older versions</remarks>
        [XmlAttribute("sound")]
#if NET48
        public string Sound { get; set; }
#else
        public string? Sound { get; set; }
#endif

        /// <remarks>Only present in older versions</remarks>
        [XmlAttribute("palettesize")]
#if NET48
        public string PaletteSize { get; set; }
#else
        public string? PaletteSize { get; set; }
#endif

        /// <remarks>(good|imperfect|preliminary)</remarks>
        [Required]
        [XmlAttribute("emulation")]
#if NET48
        public string Emulation { get; set; }
#else
        public string? Emulation { get; set; }
#endif

        /// <remarks>(good|imperfect|preliminary)</remarks>
        [Required]
        [XmlAttribute("cocktail")]
#if NET48
        public string Cocktail { get; set; }
#else
        public string? Cocktail { get; set; }
#endif

        /// <remarks>(supported|unsupported)</remarks>
        [Required]
        [XmlAttribute("savestate")]
#if NET48
        public string SaveState { get; set; }
#else
        public string? SaveState { get; set; }
#endif

        /// <remarks>(yes|no) "no"</remarks>
        [XmlAttribute("requiresartwork")]
#if NET48
        public string RequiresArtwork { get; set; }
#else
        public string? RequiresArtwork { get; set; }
#endif

        /// <remarks>(yes|no) "no"</remarks>
        [XmlAttribute("unofficial")]
#if NET48
        public string Unofficial { get; set; }
#else
        public string? Unofficial { get; set; }
#endif

        /// <remarks>(yes|no) "no"</remarks>
        [XmlAttribute("nosoundhardware")]
#if NET48
        public string NoSoundHardware { get; set; }
#else
        public string? NoSoundHardware { get; set; }
#endif

        /// <remarks>(yes|no) "no"</remarks>
        [XmlAttribute("incomplete")]
#if NET48
        public string Incomplete { get; set; }
#else
        public string? Incomplete { get; set; }
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