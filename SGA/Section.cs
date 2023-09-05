namespace SabreTools.Models.SGA
{
    /// <see href="https://github.com/RavuAlHemio/hllib/blob/master/HLLib/SGAFile.h"/>
    public abstract class Section<T>
    {
#if NET48
        public string Alias;
#else
        public string? Alias;
#endif

#if NET48
        public string Name;
#else
        public string? Name;
#endif

#if NET48
        public T FolderStartIndex;
#else
        public T? FolderStartIndex;
#endif

#if NET48
        public T FolderEndIndex;
#else
        public T? FolderEndIndex;
#endif

#if NET48
        public T FileStartIndex;
#else
        public T? FileStartIndex;
#endif

#if NET48
        public T FileEndIndex;
#else
        public T? FileEndIndex;
#endif

#if NET48
        public T FolderRootIndex;
#else
        public T? FolderRootIndex;
#endif
    }
}
