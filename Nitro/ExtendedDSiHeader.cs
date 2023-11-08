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
        public uint[]? GlobalMBK15Settings { get; set; }

        /// <summary>
        ///	Local MBK6..MBK8 Settings for ARM9
        /// </summary>
        public uint[]? LocalMBK68SettingsARM9 { get; set; }

        /// <summary>
        /// Local MBK6..MBK8 Settings for ARM7
        /// </summary>
        public uint[]? LocalMBK68SettingsARM7 { get; set; }

        /// <summary>
        /// Global MBK9 Setting
        /// </summary>
        public uint GlobalMBK9Setting { get; set; }

        /// <summary>
        /// Region Flags
        /// </summary>
        public uint RegionFlags { get; set; }

        /// <summary>
        /// Access control
        /// </summary>
        public uint AccessControl { get; set; }

        /// <summary>
        /// ARM7 SCFG EXT mask (controls which devices to enable)
        /// </summary>
        public uint ARM7SCFGEXTMask { get; set; }

        /// <summary>
        /// Reserved/flags? When bit2 of byte 0x1bf is set, usage of banner.sav from the title data dir is enabled.(additional banner data)
        /// </summary>
        public uint ReservedFlags { get; set; }

        /// <summary>
        /// ARM9i rom offset
        /// </summary>
        public uint ARM9iRomOffset { get; set; }

        /// <summary>
        /// Reserved
        /// </summary>
        public uint Reserved3 { get; set; }

        /// <summary>
        /// ARM9i load address
        /// </summary>
        public uint ARM9iLoadAddress { get; set; }

        /// <summary>
        /// ARM9i size { get; set; }
        /// </summary>
        public uint ARM9iSize { get; set; }

        /// <summary>
        /// ARM7i rom offset
        /// </summary>
        public uint ARM7iRomOffset { get; set; }

        /// <summary>
        /// Pointer to base address where various structures and parameters are passed to the title - what is that???
        /// </summary>
        public uint Reserved4 { get; set; }

        /// <summary>
        /// ARM7i load address
        /// </summary>
        public uint ARM7iLoadAddress { get; set; }

        /// <summary>
        /// ARM7i size { get; set; }
        /// </summary>
        public uint ARM7iSize { get; set; }

        /// <summary>
        /// Digest NTR region offset
        /// </summary>
        public uint DigestNTRRegionOffset { get; set; }

        /// <summary>
        /// Digest NTR region length
        /// </summary>
        public uint DigestNTRRegionLength { get; set; }

        // <summary>
        /// Digest TWL region offset
        /// </summary>
        public uint DigestTWLRegionOffset { get; set; }

        /// <summary>
        /// Digest TWL region length
        /// </summary>
        public uint DigestTWLRegionLength { get; set; }

        // <summary>
        /// Digest Sector Hashtable region offset
        /// </summary>
        public uint DigestSectorHashtableRegionOffset { get; set; }

        /// <summary>
        /// Digest Sector Hashtable region length
        /// </summary>
        public uint DigestSectorHashtableRegionLength { get; set; }

        // <summary>
        /// Digest Block Hashtable region offset
        /// </summary>
        public uint DigestBlockHashtableRegionOffset { get; set; }

        /// <summary>
        /// Digest Block Hashtable region length
        /// </summary>
        public uint DigestBlockHashtableRegionLength { get; set; }

        /// <summary>
        /// Digest Sector size
        /// </summary>
        public uint DigestSectorSize { get; set; }

        /// <summary>
        /// Digeset Block Sectorount
        /// </summary>
        public uint DigestBlockSectorCount { get; set; }

        /// <summary>
        /// Icon Banner Size (usually 0x23C0)
        /// </summary>
        public uint IconBannerSize { get; set; }

        /// <summary>
        /// Unknown (used by DSi)
        /// </summary>
        public uint Unknown1 { get; set; }

        /// <summary>
        /// NTR+TWL region ROM size (total size including DSi area)
        /// </summary>
        public uint NTRTWLRegionRomSize { get; set; }

        /// <summary>
        /// Unknown (used by DSi)
        /// </summary>
        public byte[]? Unknown2 { get; set; }

        /// <summary>
        /// Modcrypt area 1 offset
        /// </summary>
        public uint ModcryptArea1Offset { get; set; }

        /// <summary>
        /// Modcrypt area 1 size
        /// </summary>
        public uint ModcryptArea1Size { get; set; }

        /// <summary>
        /// Modcrypt area 2 offset
        /// </summary>
        public uint ModcryptArea2Offset { get; set; }

        /// <summary>
        /// Modcrypt area 2 size
        /// </summary>
        public uint ModcryptArea2Size { get; set; }

        /// <summary>
        /// Title ID
        /// </summary>
        public byte[]? TitleID { get; set; }

        /// <summary>
        /// DSiWare: "public.sav" size
        /// </summary>
        public uint DSiWarePublicSavSize { get; set; }

        /// <summary>
        /// DSiWare: "private.sav" size
        /// </summary>
        public uint DSiWarePrivateSavSize { get; set; }

        /// <summary>
        /// Reserved (zero)
        /// </summary>
        public byte[]? ReservedZero { get; set; }

        /// <summary>
        /// Unknown (used by DSi)
        /// </summary>
        public byte[]? Unknown3 { get; set; }

        /// <summary>
        /// ARM9 (with encrypted secure area) SHA1 HMAC hash
        /// </summary>
        public byte[]? ARM9WithSecureAreaSHA1HMACHash { get; set; }

        /// <summary>
        /// ARM7 SHA1 HMAC hash
        /// </summary>
        public byte[]? ARM7SHA1HMACHash { get; set; }

        /// <summary>
        /// Digest master SHA1 HMAC hash
        /// </summary>
        public byte[]? DigestMasterSHA1HMACHash { get; set; }

        /// <summary>
        /// Banner SHA1 HMAC hash
        /// </summary>
        public byte[]? BannerSHA1HMACHash { get; set; }

        /// <summary>
        /// ARM9i (decrypted) SHA1 HMAC hash
        /// </summary>
        public byte[]? ARM9iDecryptedSHA1HMACHash { get; set; }

        /// <summary>
        /// ARM7i (decrypted) SHA1 HMAC hash
        /// </summary>
        public byte[]? ARM7iDecryptedSHA1HMACHash { get; set; }

        /// <summary>
        /// Reserved
        /// </summary>
        public byte[]? Reserved5 { get; set; }

        /// <summary>
        /// ARM9 (without secure area) SHA1 HMAC hash
        /// </summary>
        public byte[]? ARM9NoSecureAreaSHA1HMACHash { get; set; }

        /// <summary>
        /// Reserved
        /// </summary>
        public byte[]? Reserved6 { get; set; }

        /// <summary>
        /// Reserved and unchecked region, always zero. Used for passing arguments in debug environment.
        /// </summary>
        public byte[]? ReservedAndUnchecked { get; set; }

        /// <summary>
        /// RSA signature (the first 0xE00 bytes of the header are signed with an 1024-bit RSA signature).
        /// </summary>
        public byte[]? RSASignature { get; set; }
    }
}