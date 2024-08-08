using System;

namespace SabreTools.Models.CHD
{
    /// <see href="https://github.com/mamedev/mame/blob/master/src/lib/util/chd.h"/> 
    public enum CompressionType : uint
    {
        #region V1

        CHDCOMPRESSION_NONE = 0,
        CHDCOMPRESSION_ZLIB = 1,

        #endregion

        #region V3

        CHDCOMPRESSION_ZLIB_PLUS = 2,

        #endregion

        #region V4

        CHDCOMPRESSION_AV = 3,

        #endregion
    }

    /// <see href="https://github.com/mamedev/mame/blob/master/src/lib/util/chd.h"/> 
    [Flags]
    public enum Flags : uint
    {
        /// <summary>
        /// Set if this drive has a parent
        /// </summary>
        DriveHasParent = 0x00000001,

        /// <summary>
        /// Set if this drive allows writes
        /// </summary>
        DriveAllowsWrites = 0x00000002,
    }
}