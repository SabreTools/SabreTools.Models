namespace SabreTools.Models.InstallShieldCabinet
{
    /// <see href="https://github.com/twogood/unshield/blob/main/lib/libunshield.h"/>
    public sealed class FileGroup
    {
        /// <summary>
        /// Offset to the file group name
        /// </summary>
        public uint NameOffset;

        /// <summary>
        /// File group name
        /// </summary>
#if NET48
        public string Name;
#else
        public string? Name;
#endif

        /// <summary>
        /// Size of the expanded data
        /// </summary>
        public uint ExpandedSize;

        /// <summary>
        /// Reserved
        /// </summary>
#if NET48
        public byte[] Reserved0;
#else
        public byte[]? Reserved0;
#endif

        /// <summary>
        /// Size of the compressed data
        /// </summary>
        public uint CompressedSize;

        /// <summary>
        /// Reserved
        /// </summary>
#if NET48
        public byte[] Reserved1;
#else
        public byte[]? Reserved1;
#endif

        /// <summary>
        /// Reserved
        /// </summary>
#if NET48
        public byte[] Reserved2;
#else
        public byte[]? Reserved2;
#endif

        /// <summary>
        /// Attribute(?)
        /// </summary>
        public ushort Attribute1;

        /// <summary>
        /// Attribute(?)
        /// </summary>
        public ushort Attribute2;

        /// <summary>
        /// Index of the first file
        /// </summary>
        public uint FirstFile;

        /// <summary>
        /// Index of the last file
        /// </summary>
        public uint LastFile;

        /// <summary>
        /// Unknown offset(?)
        /// </summary>
        public uint UnknownOffset;

        /// <summary>
        /// Var 4 offset(?)
        /// </summary>
        public uint Var4Offset;

        /// <summary>
        /// Var 1 offset(?)
        /// </summary>
        public uint Var1Offset;

        /// <summary>
        /// Offset to the HTTP location
        /// </summary>
        public uint HTTPLocationOffset;

        /// <summary>
        /// Offset to the FTP location
        /// </summary>
        public uint FTPLocationOffset;

        /// <summary>
        /// Misc offset(?)
        /// </summary>
        public uint MiscOffset;

        /// <summary>
        /// Var 2 offset(?)
        /// </summary>
        public uint Var2Offset;

        /// <summary>
        /// Offset to the target directory
        /// </summary>
        public uint TargetDirectoryOffset;

        /// <summary>
        /// Reserved
        /// </summary>
#if NET48
        public byte[] Reserved3;
#else
        public byte[]? Reserved3;
#endif

        /// <summary>
        /// Reserved
        /// </summary>
#if NET48
        public byte[] Reserved4;
#else
        public byte[]? Reserved4;
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
        /// Reserved
        /// </summary>
#if NET48
        public byte[] Reserved6;
#else
        public byte[]? Reserved6;
#endif

        /// <summary>
        /// Reserved
        /// </summary>
#if NET48
        public byte[] Reserved7;
#else
        public byte[]? Reserved7;
#endif
    }
}