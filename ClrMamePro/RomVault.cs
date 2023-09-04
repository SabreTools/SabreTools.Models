namespace SabreTools.Models.ClrMamePro
{
    /// <remarks>romvault</remarks>
    public class RomVault
    {
        /// <remarks>name</remarks>
#if NET48
        public string Name { get; set; }
#else
        public string? Name { get; set; }
#endif

        /// <remarks>description</remarks>
#if NET48
        public string Description { get; set; }
#else
        public string? Description { get; set; }
#endif

        /// <remarks>rootdir</remarks>
#if NET48
        public string RootDir { get; set; }
#else
        public string? RootDir { get; set; }
#endif

        /// <remarks>category</remarks>
#if NET48
        public string Category { get; set; }
#else
        public string? Category { get; set; }
#endif

        /// <remarks>version</remarks>
#if NET48
        public string Version { get; set; }
#else
        public string? Version { get; set; }
#endif

        /// <remarks>date</remarks>
#if NET48
        public string Date { get; set; }
#else
        public string? Date { get; set; }
#endif

        /// <remarks>author</remarks>
#if NET48
        public string Author { get; set; }
#else
        public string? Author { get; set; }
#endif

        /// <remarks>homepage</remarks>
#if NET48
        public string Homepage { get; set; }
#else
        public string? Homepage { get; set; }
#endif

        /// <remarks>url</remarks>
#if NET48
        public string Url { get; set; }
#else
        public string? Url { get; set; }
#endif

        /// <remarks>comment</remarks>
#if NET48
        public string Comment { get; set; }
#else
        public string? Comment { get; set; }
#endif

        /// <remarks>header</remarks>
#if NET48
        public string Header { get; set; }
#else
        public string? Header { get; set; }
#endif

        /// <remarks>type</remarks>
#if NET48
        public string Type { get; set; }
#else
        public string? Type { get; set; }
#endif

        /// <remarks>forcemerging</remarks>
#if NET48
        public string ForceMerging { get; set; }
#else
        public string? ForceMerging { get; set; }
#endif

        /// <remarks>forcezipping</remarks>
#if NET48
        public string ForceZipping { get; set; }
#else
        public string? ForceZipping { get; set; }
#endif

        /// <remarks>forcepacking</remarks>
#if NET48
        public string ForcePacking { get; set; }
#else
        public string? ForcePacking { get; set; }
#endif
    }
}