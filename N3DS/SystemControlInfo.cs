namespace SabreTools.Models.N3DS
{
    /// <see href="https://www.3dbrew.org/wiki/NCCH/Extended_Header#System_Control_Info"/>
    public sealed class SystemControlInfo
    {
        /// <summary>
        /// Application title (default is "CtrApp")
        /// </summary>
#if NET48
        public string ApplicationTitle;
#else
        public string? ApplicationTitle;
#endif

        /// <summary>
        /// Reserved
        /// </summary>
#if NET48
        public byte[] Reserved1;
#else
        public byte[]? Reserved1;
#endif

        /// <summary>
        /// Flag (bit 0: CompressExefsCode, bit 1: SDApplication)
        /// </summary>
        public byte Flag;

        /// <summary>
        /// Remaster version
        /// </summary>
        public ushort RemasterVersion;

        /// <summary>
        /// Text code set info
        /// </summary>
#if NET48
        public CodeSetInfo TextCodeSetInfo;
#else
        public CodeSetInfo? TextCodeSetInfo;
#endif

        /// <summary>
        /// Stack size
        /// </summary>
        public uint StackSize;

        /// <summary>
        /// Read-only code set info
        /// </summary>
#if NET48
        public CodeSetInfo ReadOnlyCodeSetInfo;
#else
        public CodeSetInfo? ReadOnlyCodeSetInfo;
#endif

        /// <summary>
        /// Reserved
        /// </summary>
#if NET48
        public byte[] Reserved2;
#else
        public byte[]? Reserved2;
#endif

        /// <summary>
        /// Data code set info
        /// </summary>
#if NET48
        public CodeSetInfo DataCodeSetInfo;
#else
        public CodeSetInfo? DataCodeSetInfo;
#endif

        /// <summary>
        /// BSS size
        /// </summary>
        public uint BSSSize;

        /// <summary>
        /// Dependency module (program ID) list
        /// </summary>
#if NET48
        public ulong[] DependencyModuleList;
#else
        public ulong[]? DependencyModuleList;
#endif

        /// <summary>
        /// SystemInfo
        /// </summary>
#if NET48
        public SystemInfo SystemInfo;
#else
        public SystemInfo? SystemInfo;
#endif
    }
}
