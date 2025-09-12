namespace SabreTools.Models.AACS
{
    public enum MediaKeyBlockType : uint
    {
        /// <summary>
        /// (Type 3). This is a normal Media Key Block suitable for being recorded
        /// on a AACS Recordable Media. Both Class I and Class II Licensed Products
        /// use it to directly calculate the Media Key.
        /// </summary>
        Type3 = 0x00031003,

        /// <summary>
        /// (Type 4). This is a Media Key Block that has been designed to use Key
        /// Conversion Data (KCD). Thus, it is suitable only for pre-recorded media
        /// from which the KCD is derived. Both Class I and Class II Licensed Products
        /// use it to directly calculate the Media Key.
        /// </summary>
        Type4 = 0x00041003,

        /// <summary>
        /// (Type 10). This is a Class II Media Key Block (one that has the functionality
        /// of a Sequence Key Block). This can only be processed by Class II Licensed
        /// Products; Class I Licensed Products are revoked in Type 10 Media Key Blocks
        /// and cannot process them. This type does not contain the Host Revocation List
        /// Record, the Drive Revocation List Record, and the Media Key Data Record, as
        /// described in the following sections. It does contain the records shown in
        /// Section 3.2.5.2, which are only processed by Class II Licensed Products.
        /// </summary>
        Type10 = 0x000A1003,

        /// <summary>
        /// This is the Media Key Block Type found on pre-recorded "UHD" media (AACS v2).
        /// Needs research, seems to be UHD media equivalent of Type 4 ?
        /// </summary>
        Type4_UHD = 0x48141003,
    }

    public enum RecordType : byte
    {
        EndOfMediaKeyBlock = 0x02,
        ExplicitSubsetDifference = 0x04,
        MediaKeyData = 0x05,
        SubsetDifferenceIndex = 0x07,
        TypeAndVersion = 0x10,
        DriveRevocationList = 0x20,
        HostRevocationList = 0x21,
        VerifyMediaKey = 0x81,

        // Not documented
        Copyright = 0x7F,

        // Record types found in UHD media (AACS v2) - needs research
        Unknown64Bytes28 = 0x28,
        Unknown64Bytes30 = 0x30,
        Unknown64Bytes31 = 0x31,
        Unknown16Bytes86 = 0x86,
        EmptyRecordF8 = 0xF8,
    }
}