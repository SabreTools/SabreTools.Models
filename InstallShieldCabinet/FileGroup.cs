namespace SabreTools.Models.InstallShieldCabinet
{
    /// <see href="https://github.com/twogood/unshield/blob/main/lib/libunshield.h"/>
    public sealed class FileGroup
    {
        /// <summary>
        /// Offset to the file group name
        /// </summary>
        public uint NameOffset { get; set; }

        /// <summary>
        /// File group name
        /// </summary>
#if NET48
        public string Name { get; set; }
#else
        public string? Name { get; set; }
#endif

        /// <summary>
        /// Size of the expanded data
        /// </summary>
        public uint ExpandedSize { get; set; }

        /// <summary>
        /// Reserved
        /// </summary>
#if NET48
        public byte[] Reserved0 { get; set; }
#else
        public byte[]? Reserved0 { get; set; }
#endif

        /// <summary>
        /// Size of the compressed data
        /// </summary>
        public uint CompressedSize { get; set; }

        /// <summary>
        /// Reserved
        /// </summary>
#if NET48
        public byte[] Reserved1 { get; set; }
#else
        public byte[]? Reserved1 { get; set; }
#endif

        /// <summary>
        /// Reserved
        /// </summary>
#if NET48
        public byte[] Reserved2 { get; set; }
#else
        public byte[]? Reserved2 { get; set; }
#endif

        /// <summary>
        /// Attribute(?)
        /// </summary>
        public ushort Attribute1 { get; set; }

        /// <summary>
        /// Attribute(?)
        /// </summary>
        public ushort Attribute2 { get; set; }

        /// <summary>
        /// Index of the first file
        /// </summary>
        public uint FirstFile { get; set; }

        /// <summary>
        /// Index of the last file
        /// </summary>
        public uint LastFile { get; set; }

        /// <summary>
        /// Unknown offset(?)
        /// </summary>
        public uint UnknownOffset { get; set; }

        /// <summary>
        /// Var 4 offset(?)
        /// </summary>
        public uint Var4Offset { get; set; }

        /// <summary>
        /// Var 1 offset(?)
        /// </summary>
        public uint Var1Offset { get; set; }

        /// <summary>
        /// Offset to the HTTP location
        /// </summary>
        public uint HTTPLocationOffset { get; set; }

        /// <summary>
        /// Offset to the FTP location
        /// </summary>
        public uint FTPLocationOffset { get; set; }

        /// <summary>
        /// Misc offset(?)
        /// </summary>
        public uint MiscOffset { get; set; }

        /// <summary>
        /// Var 2 offset(?)
        /// </summary>
        public uint Var2Offset { get; set; }

        /// <summary>
        /// Offset to the target directory
        /// </summary>
        public uint TargetDirectoryOffset { get; set; }

        /// <summary>
        /// Reserved
        /// </summary>
#if NET48
        public byte[] Reserved3 { get; set; }
#else
        public byte[]? Reserved3 { get; set; }
#endif

        /// <summary>
        /// Reserved
        /// </summary>
#if NET48
        public byte[] Reserved4 { get; set; }
#else
        public byte[]? Reserved4 { get; set; }
#endif

        /// <summary>
        /// Reserved
        /// </summary>
#if NET48
        public byte[] Reserved5 { get; set; }
#else
        public byte[]? Reserved5 { get; set; }
#endif

        /// <summary>
        /// Reserved
        /// </summary>
#if NET48
        public byte[] Reserved6 { get; set; }
#else
        public byte[]? Reserved6 { get; set; }
#endif

        /// <summary>
        /// Reserved
        /// </summary>
#if NET48
        public byte[] Reserved7 { get; set; }
#else
        public byte[]? Reserved7 { get; set; }
#endif
    }
}