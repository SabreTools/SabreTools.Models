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
#if NET48
        public byte[] SystemSavedataIDs { get; set; }
#else
        public byte[]? SystemSavedataIDs { get; set; }
#endif

        /// <summary>
        /// Storage accessible unique IDs
        /// </summary>
#if NET48
        public byte[] StorageAccessibleUniqueIDs { get; set; }
#else
        public byte[]? StorageAccessibleUniqueIDs { get; set; }
#endif

        /// <summary>
        /// Filesystem access info
        /// </summary>
        /// TODO: Create enum for the flag values
        /// TODO: Combine with "other attributes"
#if NET48
        public byte[] FileSystemAccessInfo { get; set; }
#else
        public byte[]? FileSystemAccessInfo { get; set; }
#endif

        /// <summary>
        /// Other attributes
        /// </summary>
        public StorageInfoOtherAttributes OtherAttributes { get; set; }
    }
}
