namespace SabreTools.Models.InstallShieldCabinet
{
    /// <see href="https://github.com/twogood/unshield/blob/main/lib/cabfile.h"/>
    public sealed class Descriptor
    {
        /// <summary>
        /// Offset to the descriptor strings
        /// </summary>
        public uint StringsOffset { get; set; }

        /// <summary>
        /// Reserved
        /// </summary>
        public byte[]? Reserved0 { get; set; }

        /// <summary>
        /// Offset to the component list
        /// </summary>
        public uint ComponentListOffset { get; set; }

        /// <summary>
        /// Offset to the file table
        /// </summary>
        public uint FileTableOffset { get; set; }

        /// <summary>
        /// Reserved
        /// </summary>
        public byte[]? Reserved1 { get; set; }

        /// <summary>
        /// Size of the file table
        /// </summary>
        public uint FileTableSize { get; set; }

        /// <summary>
        /// Redundant size of the file table
        /// </summary>
        public uint FileTableSize2 { get; set; }

        /// <summary>
        /// Number of directories
        /// </summary>
        public ushort DirectoryCount { get; set; }

        /// <summary>
        /// Reserved
        /// </summary>
        public byte[]? Reserved2 { get; set; }

        /// <summary>
        /// Reserved
        /// </summary>
        public byte[]? Reserved3 { get; set; }

        /// <summary>
        /// Reserved
        /// </summary>
        public byte[]? Reserved4 { get; set; }

        /// <summary>
        /// Number of files
        /// </summary>
        public uint FileCount { get; set; }

        /// <summary>
        /// Redundant offset to the file table
        /// </summary>
        public uint FileTableOffset2 { get; set; }

        /// <summary>
        /// Number of component table infos
        /// </summary>
        public ushort ComponentTableInfoCount { get; set; }

        /// <summary>
        /// Offset to the component table
        /// </summary>
        public uint ComponentTableOffset { get; set; }

        /// <summary>
        /// Reserved
        /// </summary>
        public byte[]? Reserved5 { get; set; }

        /// <summary>
        /// Reserved
        /// </summary>
        public byte[]? Reserved6 { get; set; }

        /// <summary>
        /// Offsets to the file groups
        /// </summary>
        public uint[]? FileGroupOffsets { get; set; }

        /// <summary>
        /// Offsets to the components
        /// </summary>
        public uint[]? ComponentOffsets { get; set; }

        /// <summary>
        /// Offset to the setup types
        /// </summary>
        public uint SetupTypesOffset { get; set; }

        /// <summary>
        /// Offset to the setup table
        /// </summary>
        public uint SetupTableOffset { get; set; }

        /// <summary>
        /// Reserved
        /// </summary>
        public byte[]? Reserved7 { get; set; }

        /// <summary>
        /// Reserved
        /// </summary>
        public byte[]? Reserved8 { get; set; }
    }
}