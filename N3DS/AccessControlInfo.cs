namespace SabreTools.Models.N3DS
{
    /// <see href="https://www.3dbrew.org/wiki/NCCH/Extended_Header#Access_Control_Info"/>
    public sealed class AccessControlInfo
    {
        /// <summary>
        /// ARM11 local system capabilities
        /// </summary>
#if NET48
        public ARM11LocalSystemCapabilities ARM11LocalSystemCapabilities;
#else
        public ARM11LocalSystemCapabilities? ARM11LocalSystemCapabilities;
#endif

        /// <summary>
        /// ARM11 kernel capabilities
        /// </summary>
#if NET48
        public ARM11KernelCapabilities ARM11KernelCapabilities;
#else
        public ARM11KernelCapabilities? ARM11KernelCapabilities;
#endif

        /// <summary>
        /// ARM9 access control
        /// </summary>
#if NET48
        public ARM9AccessControl ARM9AccessControl;
#else
        public ARM9AccessControl? ARM9AccessControl;
#endif
    }
}
