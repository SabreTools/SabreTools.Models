namespace SabreTools.Models.SGA
{
    /// <see href="https://github.com/RavuAlHemio/hllib/blob/master/HLLib/SGAFile.h"/>
    public abstract class DirectoryHeader<T>
    {
        public uint SectionOffset;

#if NET48
        public T SectionCount;
#else
        public T? SectionCount;
#endif

        public uint FolderOffset;

#if NET48
        public T FolderCount;
#else
        public T? FolderCount;
#endif

        public uint FileOffset;

#if NET48
        public T FileCount;
#else
        public T? FileCount;
#endif

        public uint StringTableOffset;

#if NET48
        public T StringTableCount;
#else
        public T? StringTableCount;
#endif
    }
}
