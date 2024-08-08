using System.Xml.Serialization;
using Newtonsoft.Json;

namespace SabreTools.Models.Metadata
{
    [JsonObject("sample"), XmlRoot("sample")]
    public class Sample : DatItem
    {
        #region Keys

        /// <remarks>string</remarks>
        public const string NameKey = "name";

        #endregion

        public Sample() => Type = ItemType.Sample;
    }
}
