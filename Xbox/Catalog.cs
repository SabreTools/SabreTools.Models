using Newtonsoft.Json;

namespace SabreTools.Models.Xbox
{
    /// <summary>
    /// Contains metadata information about XboxOne and XboxSX discs
    /// Stored in a JSON file on the disc at /MSXC/Metadata/catalog.js
    /// TODO: Check for unknown fields or values in more catalog.js files
    /// </summary>
    [JsonObject(MemberSerialization.OptIn, Description = "catalog.js")]
    public class Catalog
    {
        /// <summary>
        /// "version":
        /// Version of this catalog.js file
        /// Known values: 1.0, 2.0, 2.1, 4.0, 4.1 (4.1 not confirmed on a disc)
        /// </summary>
        [JsonProperty("version")]
        public string? Version { get; set; }

        /// <summary>
        /// "discNumber":
        /// Varies for each disc in set
        /// 0 is reserved and shouldnt be used
        /// Known Versions Present: 4.0
        /// </summary>
        [JsonProperty("discNumber", NullValueHandling = NullValueHandling.Ignore)]
        public int? DiscNumber { get; set; }

        /// <summary>
        /// "discCount":
        /// Total number of discs in set
        /// Same value for each disc in the set
        /// Known Versions Present: 4.0
        /// </summary>
        [JsonProperty("discCount", NullValueHandling = NullValueHandling.Ignore)]
        public int DiscCount { get; set; }

        /// <summary>
        /// "discSetId":
        /// 8 hex character ID for the set itself
        /// Same value for each disc in the set
        /// Known Versions Present: 4.0
        /// </summary>
        [JsonProperty("discSetId", NullValueHandling = NullValueHandling.Ignore)]
        public string? DiscSetID { get; set; }

        /// <summary>
        /// "bundle":
        /// Package details for the bundle itself
        /// Known fields used: ProductID, XboxProductID,
        ///     OneStoreProductID, Titles, VUI, Images
        /// Known Versions Present: 2.0, 4.0
        /// </summary>
        [JsonProperty("bundle", NullValueHandling = NullValueHandling.Ignore)]
        public Package? Bundle { get; set; }

        /// <summary>
        /// "launchPackage":
        /// Package details for the launch package
        /// Known fields used: ContentID
        /// Known Versions Present: 2.0
        /// </summary>
        [JsonProperty("launchPackage", NullValueHandling = NullValueHandling.Ignore)]
        public Package? LaunchPackage { get; set; }

        /// <summary>
        /// "launchPackage":
        /// Package name to use as launch package
        /// For 4.0, String rather than Package.ContentID ?
        /// Known Versions Present: 4.0
        /// </summary>
        [JsonProperty("launchPackage", NullValueHandling = NullValueHandling.Ignore)]
        public string? LaunchPackageName { get; set; }

        /// <summary>
        /// "packages":
        /// Package details for each package on disc
        /// Known Versions Present: 2.1, 4.0
        /// </summary>
        [JsonProperty("packages", NullValueHandling = NullValueHandling.Ignore)]
        public Package[]? Packages { get; set; }

        /// <summary>
        /// "siblings":
        /// List of Package Names that are related to this disc
        /// The console picks the correct one to use
        /// Known Versions Present: 4.0
        /// </summary>
        [JsonProperty("siblings", NullValueHandling = NullValueHandling.Ignore)]
        public string[]? Siblings { get; set; }
    }
}
