using System.Collections.Generic;

namespace SabreTools.Models.Metadata
{
    /// <summary>
    /// Specialized dictionary base for item types
    /// </summary>
#if NET48
    public abstract class DictionaryBase : Dictionary<string, object>
#else
    public abstract class DictionaryBase : Dictionary<string, object?>
#endif
    {
        /// <summary>
        /// Read a key as the specified type, returning null on error
        /// </summary>
#if NET48
        public T Read<T>(string key)
#else
        public T? Read<T>(string key)
#endif
        {
            try
            {
                if (!ValidateKey(key))
                    return default;
#if NET48
                if (!(this[key] is T))
#else
                if (this[key] is not T)
#endif
                    return default;
#if NET48
                return (T)this[key];
#else
                return (T?)this[key];
#endif
            }
            catch
            {
                return default;
            }
        }

        /// <summary>
        /// Read a key as a bool, returning null on error
        /// </summary>
        public bool? ReadBool(string key)
        {
            if (!ValidateKey(key))
                return null;

            bool? asBool = Read<bool?>(key);
            if (asBool != null)
                return asBool;

#if NET48
            string asString = Read<string>(key);
            switch (asString?.ToLowerInvariant())
            {
                case "true": case "yes": return true;
                case "false": case "no": return false;
                default: return null;
            }
#else
            string? asString = Read<string>(key);
            return asString?.ToLowerInvariant() switch
            {
                "true" or "yes" => true,
                "false" or "no" => false,
                _ => null,
            };
#endif
        }

        /// <summary>
        /// Read a key as a double, returning null on error
        /// </summary>
        public double? ReadDouble(string key)
        {
            if (!ValidateKey(key))
                return null;

            double? asDouble = Read<double?>(key);
            if (asDouble != null)
                return asDouble;

#if NET48
            string asString = Read<string>(key);
#else
            string? asString = Read<string>(key);
#endif
            if (asString != null && double.TryParse(asString, out double asStringDouble))
                return asStringDouble;

            return null;
        }

        /// <summary>
        /// Read a key as a long, returning null on error
        /// </summary>
        /// <remarks>TODO: Add logic to convert SI suffixes and hex</remarks>
        public long? ReadLong(string key)
        {
            if (!ValidateKey(key))
                return null;

            long? asLong = Read<long?>(key);
            if (asLong != null)
                return asLong;

#if NET48
            string asString = Read<string>(key);
#else
            string? asString = Read<string>(key);
#endif
            if (asString != null && long.TryParse(asString, out long asStringLong))
                return asStringLong;

            return null;
        }

        /// <summary>
        /// Read a key as a string, returning null on error
        /// </summary>
#if NET48
        public string ReadString(string key)
#else
        public string? ReadString(string key)
#endif
        {
            if (!ValidateKey(key))
                return null;

#if NET48
            string asString = Read<string>(key);
#else
            string? asString = Read<string>(key);
#endif
            if (asString != null)
                return asString;

#if NET48
            string[] asArray = Read<string[]>(key);
            if (asArray != null)
                return string.Join(",", asArray);
#else
            string[]? asArray = Read<string[]>(key);
            if (asArray != null)
                return string.Join(',', asArray);
#endif

            // TODO: Add byte array conversion here
            // TODO: Add byte array read helper

#if NET48
            return this[key].ToString();
#else
            return this[key]!.ToString();
#endif
        }

        /// <summary>
        /// Read a key as a string[], returning null on error
        /// </summary>
#if NET48
        public string[] ReadStringArray(string key)
#else
        public string[]? ReadStringArray(string key)
#endif
        {
            if (!ValidateKey(key))
                return null;

#if NET48
            string[] asArray = Read<string[]>(key);
#else
            string[]? asArray = Read<string[]>(key);
#endif
            if (asArray != null)
                return asArray;

#if NET48
            string asString = Read<string>(key);
#else
            string? asString = Read<string>(key);
#endif
            if (asString != null)
                return new string[] { asString };

#if NET48
            asString = this[key].ToString();
#else
            asString = this[key]!.ToString();
#endif
            if (asString != null)
                return new string[] { asString };

            return null;
        }

        /// <summary>
        /// Check if a key is valid
        /// </summary>
        private bool ValidateKey(string key)
        {
            if (string.IsNullOrWhiteSpace(key))
                return false;
            else if (!ContainsKey(key))
                return false;
            else if (this[key] == null)
                return false;

            return true;
        }
    }
}