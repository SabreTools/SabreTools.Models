namespace SabreTools.Models.N3DS
{
    /// <see href="https://www.3dbrew.org/wiki/NCCH/Extended_Header#System_Control_Info"/>
    public sealed class SystemControlInfo
    {
        /// <summary>
        /// Application title (default is "CtrApp")
        /// </summary>
#if NET48
        public string ApplicationTitle { get; set; }
#else
        public string? ApplicationTitle { get; set; }
#endif

        /// <summary>
        /// Reserved
        /// </summary>
#if NET48
        public byte[] Reserved1 { get; set; }
#else
        public byte[]? Reserved1 { get; set; }
#endif

        /// <summary>
        /// Flag (bit 0: CompressExefsCode, bit 1: SDApplication)
        /// </summary>
        public byte Flag { get; set; }

        /// <summary>
        /// Remaster version
        /// </summary>
        public ushort RemasterVersion { get; set; }

        /// <summary>
        /// Text code set info
        /// </summary>
#if NET48
        public CodeSetInfo TextCodeSetInfo { get; set; }
#else
        public CodeSetInfo? TextCodeSetInfo { get; set; }
#endif

        /// <summary>
        /// Stack size
        /// </summary>
        public uint StackSize { get; set; }

        /// <summary>
        /// Read-only code set info
        /// </summary>
#if NET48
        public CodeSetInfo ReadOnlyCodeSetInfo { get; set; }
#else
        public CodeSetInfo? ReadOnlyCodeSetInfo { get; set; }
#endif

        /// <summary>
        /// Reserved
        /// </summary>
#if NET48
        public byte[] Reserved2 { get; set; }
#else
        public byte[]? Reserved2 { get; set; }
#endif

        /// <summary>
        /// Data code set info
        /// </summary>
#if NET48
        public CodeSetInfo DataCodeSetInfo { get; set; }
#else
        public CodeSetInfo? DataCodeSetInfo { get; set; }
#endif

        /// <summary>
        /// BSS size
        /// </summary>
        public uint BSSSize { get; set; }

        /// <summary>
        /// Dependency module (program ID) list
        /// </summary>
#if NET48
        public ulong[] DependencyModuleList { get; set; }
#else
        public ulong[]? DependencyModuleList { get; set; }
#endif

        /// <summary>
        /// SystemInfo
        /// </summary>
#if NET48
        public SystemInfo SystemInfo { get; set; }
#else
        public SystemInfo? SystemInfo { get; set; }
#endif
    }
}
