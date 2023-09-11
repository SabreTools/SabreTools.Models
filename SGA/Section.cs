namespace SabreTools.Models.SGA
{
    /// <see href="https://github.com/RavuAlHemio/hllib/blob/master/HLLib/SGAFile.h"/>
    public abstract class Section<T>
    {
#if NET48
        public string Alias { get; set; }
#else
        public string? Alias { get; set; }
#endif

#if NET48
        public string Name { get; set; }
#else
        public string? Name { get; set; }
#endif

#if NET48
        public T FolderStartIndex { get; set; }
#else
        public T? FolderStartIndex { get; set; }
#endif

#if NET48
        public T FolderEndIndex { get; set; }
#else
        public T? FolderEndIndex { get; set; }
#endif

#if NET48
        public T FileStartIndex { get; set; }
#else
        public T? FileStartIndex { get; set; }
#endif

#if NET48
        public T FileEndIndex { get; set; }
#else
        public T? FileEndIndex { get; set; }
#endif

#if NET48
        public T FolderRootIndex { get; set; }
#else
        public T? FolderRootIndex { get; set; }
#endif
    }
}
