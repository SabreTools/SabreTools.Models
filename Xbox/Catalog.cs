namespace SabreTools.Models.Xbox
{
    /// <summary>
    /// Contains metadata information about XboxOne and XboxSX discs
    /// Stored in a JSON file on the disc at /MSXC/Metadata/catalog.js
    /// TODO: Check for unknown fields or values in more catalog.js files
    /// </summary>
    public class Catalog
    {
        /// <summary>
        /// Metadata about each package on disc
        /// Packages are stored wtihin /MSXC/
        /// </summary>
        public class Package
        {
            /// <summary>
            /// Package Title for each locale
            /// </summary>
            public class Title
            {
                /// <summary>
                /// "locale":
                /// String representing locale that this title is in
                /// Known values: "default", "en", "de", "fr", "ar", "zh-hans",
                ///     "zh-hant", "zh-TW", "zh-HK", "zh-CN", "zh-SG", etc
                /// </summary>
                public string? Locale { get; set; }

                /// <summary>
                /// "title":
                /// Package title
                /// </summary>
                public string? Name { get; set; }
            }

            /// <summary>
            /// List of image files associated with this package
            /// </summary>
            public class Image
            {
                /// <summary>
                /// "size":
                /// String representing image size
                /// Known values: "100x100", "208x208", "480x480"
                /// </summary>
                public string? Size { get; set; }

                /// <summary>
                /// "image":
                /// File name of image within MSXC/Metadata/<PackageName>/
                /// </summary>
                public string? Name { get; set; }
            }

            /// <summary>
            /// Package rating for each rating system
            /// </summary>
            public class Rating
            {
                /// <summary>
                /// "system":
                /// Name of rating system
                /// Known values: COB-AU, PEGI, PCBP, USK, China, CERO, ESRB, GCAM, CSRR,
                ///     COB, DJCTQ, GRB, OFLC, OFLC-NZ, PEGIPortugal, FPB, Microsoft
                /// </summary>
                public string? System { get; set; }

                /// <summary>
                /// "value":
                /// String representing rating value, depends on rating system
                /// </summary>
                public string? Value { get; set; }
            }

            /// <summary>
            /// Extra attributes relating to package
            /// </summary>
            public class Attribute
            {
                /// <summary>
                /// "supports4k":
                /// True if package supports 4K, false otherwise
                /// </summary>
                public bool Supports4K { get; set; }

                /// <summary>
                /// "supportsHdr":
                /// True if package supports HDR, false otherwise
                /// </summary>
                public bool SupportsHDR { get; set; }

                /// <summary>
                /// "isXboxOneXEnhanced":
                /// True if package is XboxOne X enhanced, false otherwise
                /// </summary>
                public bool IsXboxOneXEnhanced { get; set; }

            }

            /// <summary>
            /// Package details of package variant present on disc
            /// </summary>
            public class Variant
            {
                /// <summary>
                /// "generation":
                /// Console Generation the variant is for
                /// Known values: "8" (XboxOne), "9" (Xbox Series X|S)
                /// </summary>
                public string? Generation { get; set; }

                /// <summary>
                /// "packageName":
                /// Package name of the variant
                /// Matches MSXC/<PackageName> and MSXC/Metdata/<PackageName>
                /// </summary>
                public string? PackageName { get; set; }

                /// <summary>
                /// Extra attributes for the variant
                /// </summary>
                public Attribute[]? Attributes { get; set; } // Attributes for this variant
            }

            /// <summary>
            /// "packageName":
            /// Package name of variant
            /// Matches MSXC/<PackageName> and MSXC/Metdata/<PackageName>
            /// Known Versions Present: 2.0, 2.1, 4.0
            /// </summary>
            public string? PackageName { get; set; }

            /// <summary>
            /// "productId":
            /// Hex identifier for package Product ID
            /// Known Versions Present: 2.0, 2.1
            /// </summary>
            public string? ProductID { get; set; }

            /// <summary>
            /// "contentId":
            /// Hex content identifier
            /// Known Versions present: 2.0, 2.1
            /// </summary>
            public string? ContentID { get; set;}

            /// <summary>
            /// "xboxProductId":
            /// Hex product identifier
            /// Known Versions Present: 4.0
            /// </summary>
            public string? XboxProductID { get; set; }

            /// <summary>
            /// "oneStoreProductId":
            /// Partner Center Product ID
            /// 12 character uppercase alphanumeric
            /// Known Versions Present: 4.0
            /// </summary>
            public string? OneStoreProductID { get; set; }

            /// <summary>
            /// "oneStoreProductId":
            /// List of OneStoreProductID that this package is associated with
            /// Used for DLC packages only (Type = "Durable")
            /// Known Versions Present: 4.0
            /// </summary>
            public string[]? AllowedOneStoreProductIDs { get; set; }

            /// <summary>
            /// "franchiseGameHubId":
            /// Hex identifier
            /// Optionally used to mark package as game hub
            /// Known Versions Present: 4.1
            /// </summary>
            public string? FranchiseGameHubID { get; set; }

            /// <summary>
            /// "associatedFranchiseGameHubId":
            /// Hex identifier
            /// Marks corresponding FranchiseGameHubID that this package is launched with
            /// Known Versions Present: 4.1
            /// </summary>
            public string? AssociatedFranchiseGameHubID { get; set; }

            /// <summary>
            /// "titleId":
            /// 8 hex character package Title ID
            /// Known Versions Present: 2.0, 2.1, 4.0
            /// </summary>
            public string? TitleID { get; set; }

            /// <summary>
            /// "titles"
            /// List of name of package for each locale
            /// Known Versions Present: 2.0, 2.1, 4.0
            /// </summary>
            public Title[]? Titles { get; set; }

            /// <summary>
            /// "vui":
            /// List of Voice User Interface packages titles for each locale
            /// Known Versions Present: 2.0, 2.1, 4.0
            /// </summary>
            public Title[]? VUI { get; set; }

            /// <summary>
            /// "images":
            /// List of paths to each image in MSXC/Metadata/<PackageName>/
            /// Known Versions Present: 2.0, 2.1, 4.0
            /// </summary>
            public Image[]? Images { get; set; }

            /// <summary>
            /// "ratings":
            /// List of package age ratings for each relevant rating system
            /// Known Versions Present: 2.0, 2.1, 4.0
            /// </summary>
            public Rating[]? Ratings { get; set; }

            /// <summary>
            /// "attributes":
            /// Extra attributes associated with this package
            /// Known Versions Present: 2.1, 4.0
            /// </summary>
            public Attribute[]? Attributes { get; set; }

            /// <summary>
            /// "variants":
            /// Alternative packages
            /// Known Versions Present: 4.0
            /// </summary>
            public Variant[]? Variants { get; set; }

            /// <summary>
            /// "generation":
            /// Console generation the package is for
            /// Known values: "8" (XboxOne), "9" (Xbox Series X|S)
            /// Known Versions Present: 4.0
            /// </summary>
            public string? Generation { get; set; }

            /// <summary>
            /// "size":
            /// Size of package in bytes
            /// Known Versions Present: 2.0, 2.1
            /// </summary>
            public int? Size { get; set; }

            /// <summary>
            /// "type":
            /// Package Type
            /// Known values: "Game" (Game package), "Durable" (DLC package)
            /// Known Versions Present: 2.0, 2.1, 4.0
            /// </summary>
            public string? Type { get; set; }
        }

        /// <summary>
        /// "version":
        /// Version of this catalog.js file
        /// Known values: 1.0, 2.0, 2.1, 4.0, 4.1 (4.1 not confirmed on a disc)
        /// </summary>
        public string? Version { get; set; }

        /// <summary>
        /// "discNumber":
        /// Varies for each disc in set
        /// 0 is reserved and shouldnt be used
        /// Known Versions Present: 4.0
        /// </summary>
        public int? DiscNumber { get; set; }

        /// <summary>
        /// "discCount":
        /// Total number of discs in set
        /// Same value for each disc in the set
        /// Known Versions Present: 4.0
        /// </summary>
        public int DiscCount { get; set; }

        /// <summary>
        /// "discSetId":
        /// 8 hex character ID for the set itself
        /// Same value for each disc in the set
        /// Known Versions Present: 4.0
        /// </summary>
        public string? DiscSetID { get; set; }

        /// <summary>
        /// "bundle":
        /// Package details for the bundle itself
        /// Known fields used: ProductID, XboxProductID,
        ///     OneStoreProductID, Titles, VUI, Images
        /// Known Versions Present: 2.0, 4.0
        /// </summary>
        public Package? Bundle { get; set; }

        /// <summary>
        /// "launchPackage":
        /// Package details for the launch package
        /// Known fields used: ContentID
        /// Known Versions Present: 2.0
        /// </summary>
        public Package? LaunchPackage { get; set; }

        /// <summary>
        /// "launchPackage":
        /// Package name to use as launch package
        /// For 4.0, String rather than Package.ContentID ?
        /// Known Versions Present: 4.0
        /// </summary>
        public string? LaunchPackageName { get; set; }

        /// <summary>
        /// "packages":
        /// Package details for each package on disc
        /// Known Versions Present: 2.1, 4.0
        /// </summary>
        public Package[]? Packages { get; set; }

        /// <summary>
        /// "siblings":
        /// List of Package Names that are related to this disc
        /// The console picks the correct one to use
        /// Known Versions Present: 4.0
        /// </summary>
        public string[]? Siblings { get; set; }
    }
}
