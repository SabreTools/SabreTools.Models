using System.Runtime.InteropServices;

namespace SabreTools.Models.PlayStation4
{
    /// <see href="https://www.psdevwiki.com/ps4/PKG_files"/>
    [StructLayout(LayoutKind.Sequential)]
    public class AppPkgHeader
    {
        /// <summary>
        /// 0x7F434E54
        /// ".CNT"
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[]? Magic;

        /// <summary>
        /// PKG Type
        /// </summary>
        public uint Type;

        /// <summary>
        /// PKG Unknown Field
        /// </summary>
        public uint PKGUnknown;

        /// <summary>
        /// PKG File count
        /// </summary>
        public uint FileCount;

        /// <summary>
        /// PKG Entry count
        /// </summary>
        public uint EntryCount;

        /// <summary>
        /// SC Entry count
        /// </summary>
        public ushort SCEntryCount;

        /// <summary>
        /// PKG Entry count (duplicated)
        /// </summary>
        public ushort EntryCount2;

        /// <summary>
        /// PKG Table offset
        /// </summary>
        public uint TableOffset;

        /// <summary>
        /// PKG Entry data size
        /// </summary>
        public uint EntryDataSize;

        /// <summary>
        /// PKG Body offset
        /// </summary>
        public ulong BodyOffset;

        /// <summary>
        /// PKG Body size
        /// </summary>
        public ulong BodySize;

        /// <summary>
        /// PKG Content offset
        /// </summary>
        public ulong ContentOffset;

        /// <summary>
        /// PKG Content size
        /// </summary>
        public ulong ContentSize;

        /// <summary>
        /// PKG Content ID
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string? ContentID;
        
        /// <summary>
        /// PKG Content Padding (Zeroes)
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        public byte[]? ContentZeroes;

        /// <summary>
        /// PKG DRM Type
        /// </summary>
        public uint DRMType;

        /// <summary>
        /// PKG Content Type
        /// </summary>
        public uint ContentType;

        /// <summary>
        /// PKG Content Flags
        /// </summary>
        public uint ContentFlags;

        /// <summary>
        /// PKG Promote Size
        /// </summary>
        public uint PromoteSize;

        /// <summary>
        /// PKG Version Date
        /// </summary>
        public uint VersionDate;

        /// <summary>
        /// PKG Content Flags
        /// </summary>
        public uint VersionHash;
        
        /// <summary>
        /// PKG Padding Section 1
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 120)]
        public byte[]? Zeroes1;
        
        /// <summary>
        /// PKG SHA256 for Main Entry 1
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public byte[]? MainEntry1SHA256;
        
        /// <summary>
        /// PKG SHA256 for Main Entry 2
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public byte[]? MainEntry2SHA256;
        
        /// <summary>
        /// PKG SHA256 for Digest Table
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public byte[]? DigestTableSHA256;
        
        /// <summary>
        /// PKG SHA256 for Main Table
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public byte[]? MainTableSHA256;
        
        /// <summary>
        /// PKG Padding Section 2
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 640)]
        public byte[]? Zeroes2;

        /// <summary>
        /// PFS Unknown Field
        /// </summary>
        public uint PFSUnknown;

        /// <summary>
        /// PFS Image Count
        /// </summary>
        public uint PFSImageCount;

        /// <summary>
        /// PFS Image Flags
        /// </summary>
        public ulong PFSImageFlags;

        /// <summary>
        /// PFS Image Offset
        /// </summary>
        public ulong PFSImageOffset;

        /// <summary>
        /// PFS Image Size
        /// </summary>
        public ulong PFSImageSize;

        /// <summary>
        /// Mount Image Offset
        /// </summary>
        public ulong MountImageOffset;

        /// <summary>
        /// Mount Image Size
        /// </summary>
        public ulong MountImageSize;

        /// <summary>
        /// PKG Size
        /// </summary>
        public ulong PKGSize;

        /// <summary>
        /// PKG Signed Size
        /// </summary>
        public uint PKGSignedSize;

        /// <summary>
        /// PKG Signed Size
        /// </summary>
        public uint PKGCacheSize;
        
        /// <summary>
        /// SHA256 for PFS Image
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public byte[]? PFSImageSHA256;
        
        /// <summary>
        /// SHA256 for PFS Signed
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public byte[]? PFSSignedSHA256;

        /// <summary>
        /// PFS Split Size nth 0
        /// </summary>
        public ulong PFSSplitSize0;

        /// <summary>
        /// PFS Split Size nth 1
        /// </summary>
        public ulong PFSSplitSize1;
        
        /// <summary>
        /// PKG Padding Section 3
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2896)]
        public byte[]? Zeroes3;
        
        /// <summary>
        /// SHA256 for PKG
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public byte[]? PKGSHA256;
    }
}
