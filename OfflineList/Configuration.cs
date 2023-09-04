using System.Xml;
using System.Xml.Serialization;

namespace SabreTools.Models.OfflineList
{
    [XmlRoot("configuration")]
    public class Configuration
    {
        [XmlElement("datName")]
#if NET48
        public string DatName { get; set; }
#else
        public string? DatName { get; set; }
#endif

        [XmlElement("imFolder")]
#if NET48
        public string ImFolder { get; set; }
#else
        public string? ImFolder { get; set; }
#endif

        [XmlElement("datVersion")]
#if NET48
        public string DatVersion { get; set; }
#else
        public string? DatVersion { get; set; }
#endif

        [XmlElement("system")]
#if NET48
        public string System { get; set; }
#else
        public string? System { get; set; }
#endif

        /// <remarks>Numeric?</remarks>
        [XmlElement("screenshotsWidth")]
#if NET48
        public string ScreenshotsWidth { get; set; }
#else
        public string? ScreenshotsWidth { get; set; }
#endif

        /// <remarks>Numeric?</remarks>
        [XmlElement("screenshotsHeight")]
#if NET48
        public string ScreenshotsHeight { get; set; }
#else
        public string? ScreenshotsHeight { get; set; }
#endif

        [XmlElement("infos")]
#if NET48
        public Infos Infos { get; set; }
#else
        public Infos? Infos { get; set; }
#endif

        [XmlElement("canOpen")]
#if NET48
        public CanOpen CanOpen { get; set; }
#else
        public CanOpen? CanOpen { get; set; }
#endif

        [XmlElement("newDat")]
#if NET48
        public NewDat NewDat { get; set; }
#else
        public NewDat? NewDat { get; set; }
#endif

        [XmlElement("search")]
#if NET48
        public Search Search { get; set; }
#else
        public Search? Search { get; set; }
#endif

        [XmlElement("romTitle")]
#if NET48
        public string RomTitle { get; set; }
#else
        public string? RomTitle { get; set; }
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