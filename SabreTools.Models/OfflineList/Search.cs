using System.Xml;
using System.Xml.Serialization;

namespace SabreTools.Models.OfflineList
{
    [XmlRoot("search")]
    public class Search
    {
        [XmlElement("to")]
        public To[]? To { get; set; }
    }
}