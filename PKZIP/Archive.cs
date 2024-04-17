namespace SabreTools.Models.PKZIP
{
    /// <summary>
    /// Represents a single ZIP/ZIP64 archive
    /// </summary>
    public class Archive
    {
        #region Entries, Interleaved

        /// <summary>
        /// Local file headers, always appear first in each group
        /// </summary>
        public LocalFileHeader[]? LocalFileHeaders { get; set; }

        /// <summary>
        /// Encryption headers, may appear second in each group
        /// </summary>
        /// TODO: Determine the model for the encryption headers
        public byte[]?[]? EncryptionHeaders { get; set; }

        /// <summary>
        /// File data, appears after the encryption header
        /// if it exists or after the local file header otherwise
        /// </summary>
        public byte[][]? FileData { get; set; }

        /// <summary>
        /// Data descriptors, appears after the file data
        /// </summary>
        public DataDescriptor?[]? DataDescriptors { get; set; }

        /// <summary>
        /// ZIP64 Data descriptors, appears after the file data
        /// </summary>
        public DataDescriptor64?[]? ZIP64DataDescriptors { get; set; }

        #endregion

        /// <summary>
        /// Optional archive decryption header, appears after all entries
        /// </summary>
        /// TODO: Determine the model
        public byte[]? ArchiveDecryptionHeader { get; set; }

        /// <summary>
        /// Optional archive extra data record, appears after either
        /// the archive decryption header or after all entries
        /// </summary>
        public ArchiveExtraDataRecord? ArchiveExtraDataRecord { get; set; }

        /// <summary>
        /// Central directory headers in sequential order
        /// </summary>
        public CentralDirectoryFileHeader[]? CentralDirectoryHeaders { get; set; }

        /// <summary>
        /// Optional ZIP64 end of central directory record
        /// </summary>
        public EndOfCentralDirectoryRecord64? ZIP64EndOfCentralDirectoryRecord { get; set; }

        /// <summary>
        /// Optional ZIP64 end of central directory locator
        /// </summary>
        public EndOfCentralDirectoryLocator64? ZIP64EndOfCentralDirectoryLocator { get; set; }

        /// <summary>
        /// Required end of central directory record, always must be last
        /// </summary>
        public EndOfCentralDirectoryRecord? EndOfCentralDirectoryRecord { get; set; }
    }
}