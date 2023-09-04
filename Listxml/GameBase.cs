using System.Xml;
using System.Xml.Serialization;

namespace SabreTools.Models.Listxml
{
    /// <summary>
    /// Base class to unify the various game-like types
    /// </summary>
    public abstract class GameBase
    {
        [Required]
        [XmlAttribute("name")]
#if NET48
        public string Name { get; set; }
#else
        public string? Name { get; set; }
#endif

        /// <remarks>Machine only</remarks>
        [XmlAttribute("sourcefile")]
#if NET48
        public string SourceFile { get; set; }
#else
        public string? SourceFile { get; set; }
#endif

        /// <remarks>(yes|no) "no", Machine only</remarks>
        [XmlAttribute("isbios")]
#if NET48
        public string IsBios { get; set; }
#else
        public string? IsBios { get; set; }
#endif

        /// <remarks>(yes|no) "no", Machine only</remarks>
        [XmlAttribute("isdevice")]
#if NET48
        public string IsDevice { get; set; }
#else
        public string? IsDevice { get; set; }
#endif

        /// <remarks>(yes|no) "no", Machine only</remarks>
        [XmlAttribute("ismechanical")]
#if NET48
        public string IsMechanical { get; set; }
#else
        public string? IsMechanical { get; set; }
#endif

        /// <remarks>(yes|no) "no"</remarks>
        [XmlAttribute("runnable")]
#if NET48
        public string Runnable { get; set; }
#else
        public string? Runnable { get; set; }
#endif

        [XmlAttribute("cloneof")]
#if NET48
        public string CloneOf { get; set; }
#else
        public string? CloneOf { get; set; }
#endif

        [XmlAttribute("romof")]
#if NET48
        public string RomOf { get; set; }
#else
        public string? RomOf { get; set; }
#endif

        [XmlAttribute("sampleof")]
#if NET48
        public string SampleOf { get; set; }
#else
        public string? SampleOf { get; set; }
#endif

        [Required]
        [XmlElement("description")]
#if NET48
        public string Description { get; set; }
#else
        public string? Description { get; set; }
#endif

        [XmlElement("year")]
#if NET48
        public string Year { get; set; }
#else
        public string? Year { get; set; }
#endif

        [XmlElement("manufacturer")]
#if NET48
        public string Manufacturer { get; set; }
#else
        public string? Manufacturer { get; set; }
#endif

        /// <remarks>Game only</remarks>
        [XmlElement("history")]
#if NET48
        public string History { get; set; }
#else
        public string? History { get; set; }
#endif

        [XmlElement("biosset")]
#if NET48
        public BiosSet[] BiosSet { get; set; }
#else
        public BiosSet[]? BiosSet { get; set; }
#endif

        [XmlElement("rom")]
#if NET48
        public Rom[] Rom { get; set; }
#else
        public Rom[]? Rom { get; set; }
#endif

        [XmlElement("disk")]
#if NET48
        public Disk[] Disk { get; set; }
#else
        public Disk[]? Disk { get; set; }
#endif

        [XmlElement("device_ref")]
#if NET48
        public DeviceRef[] DeviceRef { get; set; }
#else
        public DeviceRef[]? DeviceRef { get; set; }
#endif

        [XmlElement("sample")]
#if NET48
        public Sample[] Sample { get; set; }
#else
        public Sample[]? Sample { get; set; }
#endif

        [XmlElement("chip")]
#if NET48
        public Chip[] Chip { get; set; }
#else
        public Chip[]? Chip { get; set; }
#endif

        [XmlElement("display")]
#if NET48
        public Display[] Display { get; set; }
#else
        public Display[]? Display { get; set; }
#endif

        /// <remarks>Only present in older versions</remarks>
        [XmlElement("video")]
#if NET48
        public Video[] Video { get; set; }
#else
        public Video[]? Video { get; set; }
#endif

        [XmlElement("sound")]
#if NET48
        public Sound Sound { get; set; }
#else
        public Sound? Sound { get; set; }
#endif

        [XmlElement("input")]
#if NET48
        public Input Input { get; set; }
#else
        public Input? Input { get; set; }
#endif

        [XmlElement("dipswitch")]
#if NET48
        public DipSwitch[] DipSwitch { get; set; }
#else
        public DipSwitch[]? DipSwitch { get; set; }
#endif

        [XmlElement("configuration")]
#if NET48
        public Configuration[] Configuration { get; set; }
#else
        public Configuration[]? Configuration { get; set; }
#endif

        [XmlElement("port")]
#if NET48
        public Port[] Port { get; set; }
#else
        public Port[]? Port { get; set; }
#endif

        [XmlElement("adjuster")]
#if NET48
        public Adjuster[] Adjuster { get; set; }
#else
        public Adjuster[]? Adjuster { get; set; }
#endif

        [XmlElement("driver")]
#if NET48
        public Driver Driver { get; set; }
#else
        public Driver? Driver { get; set; }
#endif

        [XmlElement("feature")]
#if NET48
        public Feature[] Feature { get; set; }
#else
        public Feature[]? Feature { get; set; }
#endif

        [XmlElement("device")]
#if NET48
        public Device[] Device { get; set; }
#else
        public Device[]? Device { get; set; }
#endif

        [XmlElement("slot")]
#if NET48
        public Slot[] Slot { get; set; }
#else
        public Slot[]? Slot { get; set; }
#endif

        [XmlElement("softwarelist")]
#if NET48
        public SoftwareList[] SoftwareList { get; set; }
#else
        public SoftwareList[]? SoftwareList { get; set; }
#endif

        [XmlElement("ramoption")]
#if NET48
        public RamOption[] RamOption { get; set; }
#else
        public RamOption[]? RamOption { get; set; }
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