namespace SabreTools.Models.Nitro
{
    /// <summary>
    /// Nintendo DSi extended cart header
    /// </summary>
    /// <see href="https://dsibrew.org/wiki/DSi_cartridge_header"/>
    public sealed class ExtendedDSiHeader
    {
        /// <summary>
        /// Global MBK1..MBK5 Settings
        /// </summary>
#if NET48
        public uint[] GlobalMBK15Settings;
#else
        public uint[]? GlobalMBK15Settings;
#endif

        /// <summary>
        ///	Local MBK6..MBK8 Settings for ARM9
        /// </summary>
#if NET48
        public uint[] LocalMBK68SettingsARM9;
#else
        public uint[]? LocalMBK68SettingsARM9;
#endif

        /// <summary>
        /// Local MBK6..MBK8 Settings for ARM7
        /// </summary>
#if NET48
        public uint[] LocalMBK68SettingsARM7;
#else
        public uint[]? LocalMBK68SettingsARM7;
#endif

        /// <summary>
        /// Global MBK9 Setting
        /// </summary>
        public uint GlobalMBK9Setting;

        /// <summary>
        /// Region Flags
        /// </summary>
        public uint RegionFlags;

        /// <summary>
        /// Access control
        /// </summary>
        public uint AccessControl;

        /// <summary>
        /// ARM7 SCFG EXT mask (controls which devices to enable)
        /// </summary>
        public uint ARM7SCFGEXTMask;

        /// <summary>
        /// Reserved/flags? When bit2 of byte 0x1bf is set, usage of banner.sav from the title data dir is enabled.(additional banner data)
        /// </summary>
        public uint ReservedFlags;

        /// <summary>
        /// ARM9i rom offset
        /// </summary>
        public uint ARM9iRomOffset;

        /// <summary>
        /// Reserved
        /// </summary>
        public uint Reserved3;

        /// <summary>
        /// ARM9i load address
        /// </summary>
        public uint ARM9iLoadAddress;

        /// <summary>
        /// ARM9i size;
        /// </summary>
        public uint ARM9iSize;

        /// <summary>
        /// ARM7i rom offset
        /// </summary>
        public uint ARM7iRomOffset;

        /// <summary>
        /// Pointer to base address where various structures and parameters are passed to the title - what is that???
        /// </summary>
        public uint Reserved4;

        /// <summary>
        /// ARM7i load address
        /// </summary>
        public uint ARM7iLoadAddress;

        /// <summary>
        /// ARM7i size;
        /// </summary>
        public uint ARM7iSize;

        /// <summary>
        /// Digest NTR region offset
        /// </summary>
        public uint DigestNTRRegionOffset;

        /// <summary>
        /// Digest NTR region length
        /// </summary>
        public uint DigestNTRRegionLength;

        // <summary>
        /// Digest TWL region offset
        /// </summary>
        public uint DigestTWLRegionOffset;

        /// <summary>
        /// Digest TWL region length
        /// </summary>
        public uint DigestTWLRegionLength;

        // <summary>
        /// Digest Sector Hashtable region offset
        /// </summary>
        public uint DigestSectorHashtableRegionOffset;

        /// <summary>
        /// Digest Sector Hashtable region length
        /// </summary>
        public uint DigestSectorHashtableRegionLength;

        // <summary>
        /// Digest Block Hashtable region offset
        /// </summary>
        public uint DigestBlockHashtableRegionOffset;

        /// <summary>
        /// Digest Block Hashtable region length
        /// </summary>
        public uint DigestBlockHashtableRegionLength;

        /// <summary>
        /// Digest Sector size
        /// </summary>
        public uint DigestSectorSize;

        /// <summary>
        /// Digeset Block Sectorount
        /// </summary>
        public uint DigestBlockSectorCount;

        /// <summary>
        /// Icon Banner Size (usually 0x23C0)
        /// </summary>
        public uint IconBannerSize;

        /// <summary>
        /// Unknown (used by DSi)
        /// </summary>
        public uint Unknown1;

        /// <summary>
        /// NTR+TWL region ROM size (total size including DSi area)
        /// </summary>
        public uint NTRTWLRegionRomSize;

        /// <summary>
        /// Unknown (used by DSi)
        /// </summary>
#if NET48
        public byte[] Unknown2;
#else
        public byte[]? Unknown2;
#endif

        /// <summary>
        /// Modcrypt area 1 offset
        /// </summary>
        public uint ModcryptArea1Offset;

        /// <summary>
        /// Modcrypt area 1 size
        /// </summary>
        public uint ModcryptArea1Size;

        /// <summary>
        /// Modcrypt area 2 offset
        /// </summary>
        public uint ModcryptArea2Offset;

        /// <summary>
        /// Modcrypt area 2 size
        /// </summary>
        public uint ModcryptArea2Size;

        /// <summary>
        /// Title ID
        /// </summary>
#if NET48
        public byte[] TitleID;
#else
        public byte[]? TitleID;
#endif

        /// <summary>
        /// DSiWare: "public.sav" size
        /// </summary>
        public uint DSiWarePublicSavSize;

        /// <summary>
        /// DSiWare: "private.sav" size
        /// </summary>
        public uint DSiWarePrivateSavSize;

        /// <summary>
        /// Reserved (zero)
        /// </summary>
#if NET48
        public byte[] ReservedZero;
#else
        public byte[]? ReservedZero;
#endif

        /// <summary>
        /// Unknown (used by DSi)
        /// </summary>
#if NET48
        public byte[] Unknown3;
#else
        public byte[]? Unknown3;
#endif

        /// <summary>
        /// ARM9 (with encrypted secure area) SHA1 HMAC hash
        /// </summary>
#if NET48
        public byte[] ARM9WithSecureAreaSHA1HMACHash;
#else
        public byte[]? ARM9WithSecureAreaSHA1HMACHash;
#endif

        /// <summary>
        /// ARM7 SHA1 HMAC hash
        /// </summary>
#if NET48
        public byte[] ARM7SHA1HMACHash;
#else
        public byte[]? ARM7SHA1HMACHash;
#endif

        /// <summary>
        /// Digest master SHA1 HMAC hash
        /// </summary>
#if NET48
        public byte[] DigestMasterSHA1HMACHash;
#else
        public byte[]? DigestMasterSHA1HMACHash;
#endif

        /// <summary>
        /// Banner SHA1 HMAC hash
        /// </summary>
#if NET48
        public byte[] BannerSHA1HMACHash;
#else
        public byte[]? BannerSHA1HMACHash;
#endif

        /// <summary>
        /// ARM9i (decrypted) SHA1 HMAC hash
        /// </summary>
#if NET48
        public byte[] ARM9iDecryptedSHA1HMACHash;
#else
        public byte[]? ARM9iDecryptedSHA1HMACHash;
#endif

        /// <summary>
        /// ARM7i (decrypted) SHA1 HMAC hash
        /// </summary>
#if NET48
        public byte[] ARM7iDecryptedSHA1HMACHash;
#else
        public byte[]? ARM7iDecryptedSHA1HMACHash;
#endif

        /// <summary>
        /// Reserved
        /// </summary>
#if NET48
        public byte[] Reserved5;
#else
        public byte[]? Reserved5;
#endif

        /// <summary>
        /// ARM9 (without secure area) SHA1 HMAC hash
        /// </summary>
#if NET48
        public byte[] ARM9NoSecureAreaSHA1HMACHash;
#else
        public byte[]? ARM9NoSecureAreaSHA1HMACHash;
#endif

        /// <summary>
        /// Reserved
        /// </summary>
#if NET48
        public byte[] Reserved6;
#else
        public byte[]? Reserved6;
#endif

        /// <summary>
        /// Reserved and unchecked region, always zero. Used for passing arguments in debug environment.
        /// </summary>
#if NET48
        public byte[] ReservedAndUnchecked;
#else
        public byte[]? ReservedAndUnchecked;
#endif

        /// <summary>
        /// RSA signature (the first 0xE00 bytes of the header are signed with an 1024-bit RSA signature).
        /// </summary>
#if NET48
        public byte[] RSASignature;
#else
        public byte[]? RSASignature;
#endif
    }
}