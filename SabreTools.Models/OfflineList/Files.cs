using System.Xml;
using System.Xml.Serialization;

namespace SabreTools.Models.OfflineList
{
    [XmlRoot("files")]
    public class Files
    {
        [XmlElement("romCRC")]
        public FileRomCRC[]? RomCRC { get; set; }
    }
}