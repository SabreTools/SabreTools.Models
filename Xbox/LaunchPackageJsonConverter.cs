using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SabreTools.Models.Xbox
{
    public class LaunchPackageJsonConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
        {
            if (value == null)
                return;

            JToken t = JToken.FromObject(value);

            if (value.GetType() == typeof(string))
                t.WriteTo(writer);

            // TODO: Write to Package.ContentID rather than string
        }
        public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
        {
            if (reader.ValueType == typeof(string))
                return reader.ReadAsString();

            return JsonConvert.DeserializeObject<Package>(reader.ReadAsString() ?? "")?.ContentID;
        }

        public override bool CanConvert(Type objectType)
        {
            return true;
        }
    }
}
