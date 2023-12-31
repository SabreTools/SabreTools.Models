using System.Xml.Serialization;
using Newtonsoft.Json;

namespace SabreTools.Models.Metadata
{
    [JsonObject("dipvalue"), XmlRoot("dipvalue")]
    public class DipValue : DatItem
    {
        #region Keys

        /// <remarks>Condition</remarks>
        [NoFilter]
        public const string ConditionKey = "condition";

        /// <remarks>(yes|no) "no"</remarks>
        public const string DefaultKey = "default";

        /// <remarks>string</remarks>
        public const string NameKey = "name";

        /// <remarks>string</remarks>
        public const string ValueKey = "value";

        #endregion

        public DipValue() => Type = ItemType.DipValue;
    }
}
