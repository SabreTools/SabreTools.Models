using System;

namespace SabreTools.Models.CFB
{
    /// <see href="https://github.com/GNOME/msitools/blob/master/libmsi/libmsi-summary-info.c"/>
    public sealed class SummaryInformation
    {
        #region Set Header

        /// <summary>
        /// This field MUST be set to 0xFFFE. This field is a byte order mark for
        /// all integer fields, specifying little-endian byte order.
        /// </summary>
        public ushort ByteOrder;

        /// <summary>
        /// Format
        /// </summary>
        public ushort Format;

        /// <summary>
        /// Build
        /// </summary>
        public ushort Build;

        /// <summary>
        /// Platform ID
        /// </summary>
        public ushort PlatformID;

        /// <summary>
        /// CLSID
        /// </summary>
        public Guid CLSID;

        /// <summary>
        /// 4 bytes of reserved data
        /// </summary>
#if NET48
        public byte[] Reserved;
#else
        public byte[]? Reserved;
#endif

        #endregion

        #region Format Header

        /// <summary>
        /// Format ID, should be <see cref="Constants.FMTID_SummaryInformation"/>
        /// </summary>
        public Guid FormatID;

        /// <summary>
        /// 16 bytes of unknown data
        /// </summary>
#if NET48
        public byte[] Unknown;
#else
        public byte[]? Unknown;
#endif

        #endregion

        #region Section Header

        /// <summary>
        /// Location of the section
        /// </summary>
        public uint Offset;

        /// <summary>
        /// Section count(?)
        /// </summary>
        public uint SectionCount;

        /// <summary>
        /// Property count
        /// </summary>
        public uint PropertyCount;

        /// <summary>
        /// Properties
        /// </summary>
        /// <remarks>Each Variant might be followed by an index and offset value</remarks>
#if NET48
        public Variant[] Properties;
#else
        public Variant[]? Properties;
#endif

        #endregion
    }
}