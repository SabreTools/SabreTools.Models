using System.Xml;
using System.Xml.Serialization;

namespace SabreTools.Models.Logiqx
{
    [XmlRoot("romcenter")]
    public class RomCenter
    {
        [XmlAttribute("plugin")]
        public string? Plugin { get; set; }

        /// <remarks>(none|split|merged|unmerged|fullmerged|device|full) "split"</remarks>
        [XmlAttribute("rommode")]
        public string? RomMode { get; set; }

        /// <remarks>(none|split|merged|unmerged|fullmerged|device|full) "split"</remarks>
        [XmlAttribute("biosmode")]
        public string? BiosMode { get; set; }

        /// <remarks>(none|split|merged|unmerged|fullmerged|device|full) "merged"</remarks>
        [XmlAttribute("samplemode")]
        public string? SampleMode { get; set; }

        /// <remarks>(yes|no) "no"</remarks>
        [XmlAttribute("lockrommode")]
        public string? LockRomMode { get; set; }

        /// <remarks>(yes|no) "no"</remarks>
        [XmlAttribute("lockbiosmode")]
        public string? LockBiosMode { get; set; }

        /// <remarks>(yes|no) "no"</remarks>
        [XmlAttribute("locksamplemode")]
        public string? LockSampleMode { get; set; }

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