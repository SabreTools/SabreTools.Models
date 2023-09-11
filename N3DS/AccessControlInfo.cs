namespace SabreTools.Models.N3DS
{
    /// <see href="https://www.3dbrew.org/wiki/NCCH/Extended_Header#Access_Control_Info"/>
    public sealed class AccessControlInfo
    {
        /// <summary>
        /// ARM11 local system capabilities
        /// </summary>
#if NET48
        public ARM11LocalSystemCapabilities ARM11LocalSystemCapabilities { get; set; }
#else
        public ARM11LocalSystemCapabilities? ARM11LocalSystemCapabilities { get; set; }
#endif

        /// <summary>
        /// ARM11 kernel capabilities
        /// </summary>
#if NET48
        public ARM11KernelCapabilities ARM11KernelCapabilities { get; set; }
#else
        public ARM11KernelCapabilities? ARM11KernelCapabilities { get; set; }
#endif

        /// <summary>
        /// ARM9 access control
        /// </summary>
#if NET48
        public ARM9AccessControl ARM9AccessControl { get; set; }
#else
        public ARM9AccessControl? ARM9AccessControl { get; set; }
#endif
    }
}
