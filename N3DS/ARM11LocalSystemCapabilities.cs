namespace SabreTools.Models.N3DS
{
    /// <see href="https://www.3dbrew.org/wiki/NCCH/Extended_Header#ARM11_Local_System_Capabilities"/>
    public sealed class ARM11LocalSystemCapabilities
    {
        /// <summary>
        /// Program ID
        /// </summary>
        public ulong ProgramID;

        /// <summary>
        /// Core version (The Title ID low of the required FIRM)
        /// </summary>
        public uint CoreVersion;

        /// <summary>
        /// Flag1 (implemented starting from 8.0.0-18).
        /// </summary>
        public ARM11LSCFlag1 Flag1;

        /// <summary>
        /// Flag2 (implemented starting from 8.0.0-18).
        /// </summary>
        public ARM11LSCFlag2 Flag2;

        /// <summary>
        /// Flag0
        /// </summary>
        public ARM11LSCFlag0 Flag0;

        /// <summary>
        /// Priority
        /// </summary>
        public byte Priority;

        /// <summary>
        /// Resource limit descriptors. The first byte here controls the maximum allowed CpuTime.
        /// </summary>
#if NET48
        public ushort[] ResourceLimitDescriptors;
#else
        public ushort[]? ResourceLimitDescriptors;
#endif

        /// <summary>
        /// Storage info
        /// </summary>
#if NET48
        public StorageInfo StorageInfo;
#else
        public StorageInfo? StorageInfo;
#endif

        /// <summary>
        /// Service access control
        /// </summary>
#if NET48
        public ulong[] ServiceAccessControl;
#else
        public ulong[]? ServiceAccessControl;
#endif

        /// <summary>
        /// Extended service access control, support for this was implemented with 9.3.0-X.
        /// </summary>
#if NET48
        public ulong[] ExtendedServiceAccessControl;
#else
        public ulong[]? ExtendedServiceAccessControl;
#endif

        /// <summary>
        /// Reserved
        /// </summary>
#if NET48
        public byte[] Reserved;
#else
        public byte[]? Reserved;
#endif

        /// <summary>
        /// Resource limit category. (0 = APPLICATION, 1 = SYS_APPLET, 2 = LIB_APPLET, 3 = OTHER (sysmodules running under the BASE memregion))
        /// </summary>
        public ResourceLimitCategory ResourceLimitCategory;
    }
}
