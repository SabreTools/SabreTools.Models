namespace SabreTools.Models.DVD
{
    /// <see href="https://dvd.sourceforge.net/dvdinfo/ifo.html"/>
    public sealed class VideoManagerIFO
    {
        /// <summary>
        /// "DVDVIDEO-VMG"
        /// </summary>
#if NET48
        public string Signature { get; set; }
#else
        public string? Signature { get; set; }
#endif

        /// <summary>
        /// Last sector of VMG set (last sector of BUP)
        /// </summary>
        public uint LastVMGSetSector { get; set; }

        /// <summary>
        /// Last sector of IFO
        /// </summary>
        public uint LastIFOSector { get; set; }

        /// <summary>
        /// Version number
        /// - Byte 0 - Reserved, should be 0
        /// - Byte 1, Bits 7-4 - Major version number
        /// - Byte 1, Bits 3-0 - Minor version number
        /// </summary>
        public ushort VersionNumber { get; set; }

        /// <summary>
        /// VMG category
        /// </summary>
        /// <remarks>byte1=prohibited region mask</remarks>
        public uint VMGCategory { get; set; }

        /// <summary>
        /// Number of volumes
        /// </summary>
        public ushort NumberOfVolumes { get; set; }

        /// <summary>
        /// Volume number
        /// </summary>
        public ushort VolumeNumber { get; set; }

        /// <summary>
        /// Side ID
        /// </summary>
        public byte SideID { get; set; }

        /// <summary>
        /// Number of title sets
        /// </summary>
        public ushort NumberOfTitleSets { get; set; }

        /// <summary>
        /// Provider ID
        /// </summary>
#if NET48
        public byte[] ProviderID { get; set; }
#else
        public byte[]? ProviderID { get; set; }
#endif

        /// <summary>
        /// VMG POS
        /// </summary>
        public ulong VMGPOS { get; set; }

        /// <summary>
        /// End byte address of VMGI_MAT
        /// </summary>
        public uint InformationManagementTableEndByteAddress { get; set; }

        /// <summary>
        /// Start address of FP_PGC (First Play program chain)
        /// </summary>
        public uint FirstPlayProgramChainStartAddress { get; set; }

        /// <summary>
        /// Start sector of Menu VOB
        /// </summary>
        public uint MenuVOBStartSector { get; set; }

        /// <summary>
        /// Sector pointer to TT_SRPT (table of titles)
        /// </summary>
        public uint TableOfTitlesSectorPointer { get; set; }

        /// <summary>
        /// Sector pointer to VMGM_PGCI_UT (Menu Program Chain table)
        /// </summary>
        public uint MenuProgramChainTableSectorPointer { get; set; }

        /// <summary>
        /// Sector pointer to VMG_PTL_MAIT (Parental Management masks)
        /// </summary>
        public uint ParentalManagementMasksSectorPointer { get; set; }

        /// <summary>
        /// Sector pointer to VMG_VTS_ATRT (copies of VTS audio/sub-picture attributes)
        /// </summary>
        public uint AudioSubPictureAttributesSectorPointer { get; set; }

        /// <summary>
        /// Sector pointer to VMG_TXTDT_MG (text data)
        /// </summary>
        public uint TextDataSectorPointer { get; set; }

        /// <summary>
        /// Sector pointer to VMGM_C_ADT (menu cell address table)
        /// </summary>
        public uint MenuCellAddressTableSectorPointer { get; set; }

        /// <summary>
        /// Sector pointer to VMGM_VOBU_ADMAP (menu VOBU address map)
        /// </summary>
        public uint MenuVOBUAddressMapSectorPointer { get; set; }

        /// <summary>
        /// Video attributes of VMGM_VOBS
        /// </summary>
#if NET48
        public byte[] VideoAttributes { get; set; }
#else
        public byte[]? VideoAttributes { get; set; }
#endif

        /// <summary>
        /// Number of audio streams in VMGM_VOBS
        /// </summary>
        public ushort NumberOfAudioStreams { get; set; }

        /// <summary>
        /// Audio attributes of VMGM_VOBS
        /// </summary>
#if NET48
        public byte[][] AudioAttributes { get; set; }
#else
        public byte[][]? AudioAttributes { get; set; }
#endif

        /// <summary>
        /// Unknown
        /// </summary>
#if NET48
        public byte[] Unknown { get; set; }
#else
        public byte[]? Unknown { get; set; }
#endif

        /// <summary>
        /// Number of subpicture streams in VMGM_VOBS (0 or 1)
        /// </summary>
        public ushort NumberOfSubpictureStreams { get; set; }

        /// <summary>
        /// Subpicture attributes of VMGM_VOBS
        /// </summary>
#if NET48
        public byte[] SubpictureAttributes { get; set; }
#else
        public byte[]? SubpictureAttributes { get; set; }
#endif

        /// <summary>
        /// Reserved
        /// </summary>
#if NET48
        public byte[] Reserved { get; set; }
#else
        public byte[]? Reserved { get; set; }
#endif
    }
}