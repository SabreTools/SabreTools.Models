using System.Xml;
using System.Xml.Serialization;

namespace SabreTools.Models.Logiqx
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

        [XmlAttribute("sourcefile")]
#if NET48
        public string SourceFile { get; set; }
#else
        public string? SourceFile { get; set; }
#endif

        /// <remarks>(yes|no) "no"</remarks>
        [XmlAttribute("isbios")]
#if NET48
        public string IsBios { get; set; }
#else
        public string? IsBios { get; set; }
#endif

        /// <remarks>(yes|no) "no", MAME extension</remarks>
        [XmlAttribute("isdevice")]
#if NET48
        public string IsDevice { get; set; }
#else
        public string? IsDevice { get; set; }
#endif

        /// <remarks>(yes|no) "no", MAME extension</remarks>
        [XmlAttribute("ismechanical")]
#if NET48
        public string IsMechanical { get; set; }
#else
        public string? IsMechanical { get; set; }
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

        [XmlAttribute("board")]
#if NET48
        public string Board { get; set; }
#else
        public string? Board { get; set; }
#endif

        [XmlAttribute("rebuildto")]
#if NET48
        public string RebuildTo { get; set; }
#else
        public string? RebuildTo { get; set; }
#endif

        /// <remarks>No-Intro extension</remarks>
        [XmlAttribute("id")]
#if NET48
        public string Id { get; set; }
#else
        public string? Id { get; set; }
#endif

        /// <remarks>No-Intro extension</remarks>
        [XmlAttribute("cloneofid")]
#if NET48
        public string CloneOfId { get; set; }
#else
        public string? CloneOfId { get; set; }
#endif

        /// <remarks>(no|partial|yes) "no"</remarks>
        [XmlAttribute("runnable")]
#if NET48
        public string Runnable { get; set; }
#else
        public string? Runnable { get; set; }
#endif

        [XmlElement("comment")]
#if NET48
        public string[] Comment { get; set; }
#else
        public string[]? Comment { get; set; }
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

        [XmlElement("publisher")]
#if NET48
        public string Publisher { get; set; }
#else
        public string? Publisher { get; set; }
#endif

        /// <remarks>No-Intro extension includes more than 1 instance</remarks>
        [XmlElement("category")]
#if NET48
        public string[] Category { get; set; }
#else
        public string[]? Category { get; set; }
#endif

        /// <remarks>Trurip extension</remarks>
        [XmlElement("trurip")]
#if NET48
        public Trurip Trurip { get; set; }
#else
        public Trurip? Trurip { get; set; }
#endif

        [XmlElement(elementName: "release")]
#if NET48
        public Release[] Release { get; set; }
#else
        public Release[]? Release { get; set; }
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

        /// <remarks>Aaru extension</remarks>
        [XmlElement("media")]
#if NET48
        public Media[] Media { get; set; }
#else
        public Media[]? Media { get; set; }
#endif

        /// <remarks>MAME extension</remarks>
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

        [XmlElement("archive")]
#if NET48
        public Archive[] Archive { get; set; }
#else
        public Archive[]? Archive { get; set; }
#endif

        /// <remarks>MAME extension</remarks>
        [XmlElement("driver")]
#if NET48
        public Driver Driver { get; set; }
#else
        public Driver? Driver { get; set; }
#endif

        /// <remarks>MAME extension</remarks>
        [XmlElement("softwarelist")]
#if NET48
        public SoftwareList[] SoftwareList { get; set; }
#else
        public SoftwareList[]? SoftwareList { get; set; }
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