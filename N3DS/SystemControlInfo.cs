namespace SabreTools.Models.N3DS
{
    /// <see href="https://www.3dbrew.org/wiki/NCCH/Extended_Header#System_Control_Info"/>
    public sealed class SystemControlInfo
    {
        /// <summary>
        /// Application title (default is "CtrApp")
        /// </summary>
        public string? ApplicationTitle { get; set; }

        /// <summary>
        /// Reserved
        /// </summary>
        public byte[]? Reserved1 { get; set; }

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
        public CodeSetInfo? TextCodeSetInfo { get; set; }

        /// <summary>
        /// Stack size
        /// </summary>
        public uint StackSize { get; set; }

        /// <summary>
        /// Read-only code set info
        /// </summary>
        public CodeSetInfo? ReadOnlyCodeSetInfo { get; set; }

        /// <summary>
        /// Reserved
        /// </summary>
        public byte[]? Reserved2 { get; set; }

        /// <summary>
        /// Data code set info
        /// </summary>
        public CodeSetInfo? DataCodeSetInfo { get; set; }

        /// <summary>
        /// BSS size
        /// </summary>
        public uint BSSSize { get; set; }

        /// <summary>
        /// Dependency module (program ID) list
        /// </summary>
        public ulong[]? DependencyModuleList { get; set; }

        /// <summary>
        /// SystemInfo
        /// </summary>
        public SystemInfo? SystemInfo { get; set; }
    }
}
