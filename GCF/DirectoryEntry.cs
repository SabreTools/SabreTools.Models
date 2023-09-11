namespace SabreTools.Models.GCF
{
    /// <see href="https://github.com/RavuAlHemio/hllib/blob/master/HLLib/GCFFile.h"/>
    public sealed class DirectoryEntry
    {
        /// <summary>
        /// Offset to the directory item name from the end of the directory items.
        /// </summary>
        public uint NameOffset { get; set; }

        /// <summary>
        /// Directory item name from the end of the directory items.
        /// </summary>
#if NET48
        public string Name { get; set; }
#else
        public string? Name { get; set; }
#endif

        /// <summary>
        /// Size of the item.  (If file, file size.  If folder, num items.)
        /// </summary>
        public uint ItemSize { get; set; }

        /// <summary>
        /// Checksome index. (0xFFFFFFFF == None).
        /// </summary>
        public uint ChecksumIndex { get; set; }

        /// <summary>
        /// Flags for the directory item.  (0x00000000 == Folder).
        /// </summary>
        public HL_GCF_FLAG DirectoryFlags { get; set; }

        /// <summary>
        /// Index of the parent directory item.  (0xFFFFFFFF == None).
        /// </summary>
        public uint ParentIndex { get; set; }

        /// <summary>
        /// Index of the next directory item.  (0x00000000 == None).
        /// </summary>
        public uint NextIndex { get; set; }

        /// <summary>
        /// Index of the first directory item.  (0x00000000 == None).
        /// </summary>
        public uint FirstIndex { get; set; }
    }
}