using System.Xml;
using System.Xml.Serialization;

namespace SabreTools.Models.Logiqx
{
    [XmlRoot("header")]
    public class Header
    {
        /// <remarks>No-Intro extension</remarks>
        [XmlElement("id")]
#if NET48
        public string Id { get; set; }
#else
        public string? Id { get; set; }
#endif

        [Required]
        [XmlElement("name")]
#if NET48
        public string Name { get; set; }
#else
        public string? Name { get; set; }
#endif

        [Required]
        [XmlElement("description")]
#if NET48
        public string Description { get; set; }
#else
        public string? Description { get; set; }
#endif

        /// <remarks>Trurip extension</remarks>
        [XmlElement("rootdir")]
#if NET48
        public string RootDir { get; set; }
#else
        public string? RootDir { get; set; }
#endif

        [XmlElement("category")]
#if NET48
        public string Category { get; set; }
#else
        public string? Category { get; set; }
#endif

        [Required]
        [XmlElement("version")]
#if NET48
        public string Version { get; set; }
#else
        public string? Version { get; set; }
#endif

        [XmlElement("date")]
#if NET48
        public string Date { get; set; }
#else
        public string? Date { get; set; }
#endif

        [Required]
        [XmlElement("author")]
#if NET48
        public string Author { get; set; }
#else
        public string? Author { get; set; }
#endif

        [XmlElement("email")]
#if NET48
        public string Email { get; set; }
#else
        public string? Email { get; set; }
#endif

        [XmlElement("homepage")]
#if NET48
        public string Homepage { get; set; }
#else
        public string? Homepage { get; set; }
#endif

        [XmlElement("url")]
#if NET48
        public string Url { get; set; }
#else
        public string? Url { get; set; }
#endif

        [XmlElement("comment")]
#if NET48
        public string Comment { get; set; }
#else
        public string? Comment { get; set; }
#endif

        /// <remarks>Trurip extension</remarks>
        [XmlElement("type")]
#if NET48
        public string Type { get; set; }
#else
        public string? Type { get; set; }
#endif

        [XmlElement("clrmamepro")]
#if NET48
        public ClrMamePro ClrMamePro { get; set; }
#else
        public ClrMamePro? ClrMamePro { get; set; }
#endif

        [XmlElement("romcenter")]
#if NET48
        public RomCenter RomCenter { get; set; }
#else
        public RomCenter? RomCenter { get; set; }
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