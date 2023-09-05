namespace SabreTools.Models.Nitro
{
    /// <summary>
    /// The name table stores the names of the files and the structure
    /// of the file system. From the information stored, the index of the
    /// file's entry in the File Allocation Table can be found.
    /// 
    /// It is split into two parts:
    /// - Folder Allocation Table
    /// - Name List
    /// </summary>
    /// <see href="https://github.com/Deijin27/RanseiLink/wiki/NDS-File-System"/>
    public sealed class NameTable
    {
        /// <summary>
        /// Folder allocation table
        /// </summary>
#if NET48
        public FolderAllocationTableEntry[] FolderAllocationTable;
#else
        public FolderAllocationTableEntry[]? FolderAllocationTable;
#endif

        /// <summary>
        /// Name list
        /// </summary>
#if NET48
        public NameListEntry[] NameList;
#else
        public NameListEntry[]? NameList;
#endif
    }
}