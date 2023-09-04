using System.Xml;
using System.Xml.Serialization;

namespace SabreTools.Models.Logiqx
{
    [XmlRoot("romcenter")]
    public class RomCenter
    {
        [XmlAttribute("plugin")]
#if NET48
        public string Plugin { get; set; }
#else
        public string? Plugin { get; set; }
#endif

        /// <remarks>(none|split|merged|unmerged|fullmerged|device|full) "split"</remarks>
        [XmlAttribute("rommode")]
#if NET48
        public string RomMode { get; set; }
#else
        public string? RomMode { get; set; }
#endif

        /// <remarks>(none|split|merged|unmerged|fullmerged|device|full) "split"</remarks>
        [XmlAttribute("biosmode")]
#if NET48
        public string BiosMode { get; set; }
#else
        public string? BiosMode { get; set; }
#endif

        /// <remarks>(none|split|merged|unmerged|fullmerged|device|full) "merged"</remarks>
        [XmlAttribute("samplemode")]
#if NET48
        public string SampleMode { get; set; }
#else
        public string? SampleMode { get; set; }
#endif

        /// <remarks>(yes|no) "no"</remarks>
        [XmlAttribute("lockrommode")]
#if NET48
        public string LockRomMode { get; set; }
#else
        public string? LockRomMode { get; set; }
#endif

        /// <remarks>(yes|no) "no"</remarks>
        [XmlAttribute("lockbiosmode")]
#if NET48
        public string LockBiosMode { get; set; }
#else
        public string? LockBiosMode { get; set; }
#endif

        /// <remarks>(yes|no) "no"</remarks>
        [XmlAttribute("locksamplemode")]
#if NET48
        public string LockSampleMode { get; set; }
#else
        public string? LockSampleMode { get; set; }
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