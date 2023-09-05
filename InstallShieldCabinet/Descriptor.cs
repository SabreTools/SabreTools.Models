namespace SabreTools.Models.InstallShieldCabinet
{
    /// <see href="https://github.com/twogood/unshield/blob/main/lib/cabfile.h"/>
    public sealed class Descriptor
    {
        /// <summary>
        /// Offset to the descriptor strings
        /// </summary>
        public uint StringsOffset;

        /// <summary>
        /// Reserved
        /// </summary>
#if NET48
        public byte[] Reserved0;
#else
        public byte[]? Reserved0;
#endif

        /// <summary>
        /// Offset to the component list
        /// </summary>
        public uint ComponentListOffset;

        /// <summary>
        /// Offset to the file table
        /// </summary>
        public uint FileTableOffset;

        /// <summary>
        /// Reserved
        /// </summary>
#if NET48
        public byte[] Reserved1;
#else
        public byte[]? Reserved1;
#endif

        /// <summary>
        /// Size of the file table
        /// </summary>
        public uint FileTableSize;

        /// <summary>
        /// Redundant size of the file table
        /// </summary>
        public uint FileTableSize2;

        /// <summary>
        /// Number of directories
        /// </summary>
        public ushort DirectoryCount;

        /// <summary>
        /// Reserved
        /// </summary>
#if NET48
        public byte[] Reserved2;
#else
        public byte[]? Reserved2;
#endif

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
        /// Number of files
        /// </summary>
        public uint FileCount;

        /// <summary>
        /// Redundant offset to the file table
        /// </summary>
        public uint FileTableOffset2;

        /// <summary>
        /// Number of component table infos
        /// </summary>
        public ushort ComponentTableInfoCount;

        /// <summary>
        /// Offset to the component table
        /// </summary>
        public uint ComponentTableOffset;

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
        /// Offsets to the file groups
        /// </summary>
#if NET48
        public uint[] FileGroupOffsets;
#else
        public uint[]? FileGroupOffsets;
#endif

        /// <summary>
        /// Offsets to the components
        /// </summary>
#if NET48
        public uint[] ComponentOffsets;
#else
        public uint[]? ComponentOffsets;
#endif

        /// <summary>
        /// Offset to the setup types
        /// </summary>
        public uint SetupTypesOffset;

        /// <summary>
        /// Offset to the setup table
        /// </summary>
        public uint SetupTableOffset;

        /// <summary>
        /// Reserved
        /// </summary>
#if NET48
        public byte[] Reserved7;
#else
        public byte[]? Reserved7;
#endif

        /// <summary>
        /// Reserved
        /// </summary>
#if NET48
        public byte[] Reserved8;
#else
        public byte[]? Reserved8;
#endif
    }
}