namespace SabreTools.Models.N3DS
{
    /// <summary>
    /// Used in FSReg:Register.
    /// </summary>
    /// <see href="https://www.3dbrew.org/wiki/NCCH/Extended_Header#Storage_Info"/>
    public sealed class StorageInfo
    {
        /// <summary>
        /// Extdata ID
        /// </summary>
        public ulong ExtdataID { get; set; }

        /// <summary>
        /// System savedata IDs
        /// </summary>
        public byte[]? SystemSavedataIDs { get; set; }

        /// <summary>
        /// Storage accessible unique IDs
        /// </summary>
        public byte[]? StorageAccessibleUniqueIDs { get; set; }

        /// <summary>
        /// Filesystem access info
        /// </summary>
        /// TODO: Create enum for the flag values
        /// TODO: Combine with "other attributes"
        public byte[]? FileSystemAccessInfo { get; set; }

        /// <summary>
        /// Other attributes
        /// </summary>
        public StorageInfoOtherAttributes OtherAttributes { get; set; }
    }
}
