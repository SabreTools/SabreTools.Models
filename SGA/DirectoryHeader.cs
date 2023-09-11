namespace SabreTools.Models.SGA
{
    /// <see href="https://github.com/RavuAlHemio/hllib/blob/master/HLLib/SGAFile.h"/>
    public abstract class DirectoryHeader<T>
    {
        public uint SectionOffset { get; set; }

#if NET48
        public T SectionCount { get; set; }
#else
        public T? SectionCount { get; set; }
#endif

        public uint FolderOffset { get; set; }

#if NET48
        public T FolderCount { get; set; }
#else
        public T? FolderCount { get; set; }
#endif

        public uint FileOffset { get; set; }

#if NET48
        public T FileCount { get; set; }
#else
        public T? FileCount { get; set; }
#endif

        public uint StringTableOffset { get; set; }

#if NET48
        public T StringTableCount { get; set; }
#else
        public T? StringTableCount { get; set; }
#endif
    }
}
