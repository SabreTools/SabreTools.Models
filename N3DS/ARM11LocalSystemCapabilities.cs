namespace SabreTools.Models.N3DS
{
    /// <see href="https://www.3dbrew.org/wiki/NCCH/Extended_Header#ARM11_Local_System_Capabilities"/>
    public sealed class ARM11LocalSystemCapabilities
    {
        /// <summary>
        /// Program ID
        /// </summary>
        public ulong ProgramID { get; set; }

        /// <summary>
        /// Core version (The Title ID low of the required FIRM)
        /// </summary>
        public uint CoreVersion { get; set; }

        /// <summary>
        /// Flag1 (implemented starting from 8.0.0-18).
        /// </summary>
        public ARM11LSCFlag1 Flag1 { get; set; }

        /// <summary>
        /// Flag2 (implemented starting from 8.0.0-18).
        /// </summary>
        public ARM11LSCFlag2 Flag2 { get; set; }

        /// <summary>
        /// Flag0
        /// </summary>
        public ARM11LSCFlag0 Flag0 { get; set; }

        /// <summary>
        /// Priority
        /// </summary>
        public byte Priority { get; set; }

        /// <summary>
        /// Resource limit descriptors. The first byte here controls the maximum allowed CpuTime.
        /// </summary>
#if NET48
        public ushort[] ResourceLimitDescriptors { get; set; }
#else
        public ushort[]? ResourceLimitDescriptors { get; set; }
#endif

        /// <summary>
        /// Storage info
        /// </summary>
#if NET48
        public StorageInfo StorageInfo { get; set; }
#else
        public StorageInfo? StorageInfo { get; set; }
#endif

        /// <summary>
        /// Service access control
        /// </summary>
#if NET48
        public ulong[] ServiceAccessControl { get; set; }
#else
        public ulong[]? ServiceAccessControl { get; set; }
#endif

        /// <summary>
        /// Extended service access control, support for this was implemented with 9.3.0-X.
        /// </summary>
#if NET48
        public ulong[] ExtendedServiceAccessControl { get; set; }
#else
        public ulong[]? ExtendedServiceAccessControl { get; set; }
#endif

        /// <summary>
        /// Reserved
        /// </summary>
#if NET48
        public byte[] Reserved { get; set; }
#else
        public byte[]? Reserved { get; set; }
#endif

        /// <summary>
        /// Resource limit category. (0 = APPLICATION, 1 = SYS_APPLET, 2 = LIB_APPLET, 3 = OTHER (sysmodules running under the BASE memregion))
        /// </summary>
        public ResourceLimitCategory ResourceLimitCategory { get; set; }
    }
}
