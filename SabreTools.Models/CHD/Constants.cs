namespace SabreTools.Models.CHD
{
    public static class Constants
    {
        public const string SignatureString = "MComprHD";

        #region Header Sizes

        public const int HeaderV1Size = 76;
        public const int HeaderV2Size = 80;
        public const int HeaderV3Size = 120;
        public const int HeaderV4Size = 108;
        public const int HeaderV5Size = 124;

        #endregion

        #region Metadata Parameters

        public const uint CHDMETAINDEX_APPEND = uint.MaxValue;

        #endregion
    }
}