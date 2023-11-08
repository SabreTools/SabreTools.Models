using System;

namespace SabreTools.Models.InstallShieldCabinet
{
    /// <see href="https://github.com/twogood/unshield/blob/main/lib/libunshield.h"/>
    public sealed class Component
    {
        /// <summary>
        /// Offset to the component identifier
        /// </summary>
        public uint IdentifierOffset { get; set; }

        /// <summary>
        /// Component identifier
        /// </summary>
        public string? Identifier { get; set; }

        /// <summary>
        /// Offset to the component descriptor
        /// </summary>
        public uint DescriptorOffset { get; set; }

        /// <summary>
        /// Offset to the display name
        /// </summary>
        public uint DisplayNameOffset { get; set; }

        /// <summary>
        /// Display name
        /// </summary>
        public string? DisplayName { get; set; }

        /// <summary>
        /// Reserved
        /// </summary>
        public byte[]? Reserved0 { get; set; }

        /// <summary>
        /// Reserved offset
        /// </summary>
        public uint ReservedOffset0 { get; set; }

        /// <summary>
        /// Reserved offset
        /// </summary>
        public uint ReservedOffset1 { get; set; }

        /// <summary>
        /// Component index
        /// </summary>
        public ushort ComponentIndex { get; set; }

        /// <summary>
        /// Offset to the component name
        /// </summary>
        public uint NameOffset { get; set; }

        /// <summary>
        /// Component name
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Reserved offset
        /// </summary>
        public uint ReservedOffset2 { get; set; }

        /// <summary>
        /// Reserved offset
        /// </summary>
        public uint ReservedOffset3 { get; set; }

        /// <summary>
        /// Reserved offset
        /// </summary>
        public uint ReservedOffset4 { get; set; }

        /// <summary>
        /// Reserved
        /// </summary>
        public byte[]? Reserved1 { get; set; }

        /// <summary>
        /// Offset to the component CLSID
        /// </summary>
        public uint CLSIDOffset { get; set; }

        /// <summary>
        /// Component CLSID
        /// </summary>
        public Guid CLSID { get; set; }

        /// <summary>
        /// Reserved
        /// </summary>
        public byte[]? Reserved2 { get; set; }

        /// <summary>
        /// Reserved
        /// </summary>
        public byte[]? Reserved3 { get; set; }

        /// <summary>
        /// Number of depends(?)
        /// </summary>
        public ushort DependsCount { get; set; }

        /// <summary>
        /// Offset to depends(?)
        /// </summary>
        public uint DependsOffset { get; set; }

        /// <summary>
        /// Number of file groups
        /// </summary>
        public uint FileGroupCount { get; set; }

        /// <summary>
        /// Offset to the file group names
        /// </summary>
        public uint FileGroupNamesOffset { get; set; }

        /// <summary>
        /// File group names
        /// </summary>
        public string[]? FileGroupNames { get; set; }

        /// <summary>
        /// Number of X3(?)
        /// </summary>
        public ushort X3Count { get; set; }

        /// <summary>
        /// Offset to X3(?)
        /// </summary>
        public uint X3Offset { get; set; }

        /// <summary>
        /// Number of sub-components
        /// </summary>
        public ushort SubComponentsCount { get; set; }

        /// <summary>
        /// Offset to the sub-components
        /// </summary>
        public uint SubComponentsOffset { get; set; }

        /// <summary>
        /// Offset to the next component
        /// </summary>
        public uint NextComponentOffset { get; set; }

        /// <summary>
        /// Reserved offset
        /// </summary>
        public uint ReservedOffset5 { get; set; }

        /// <summary>
        /// Reserved offset
        /// </summary>
        public uint ReservedOffset6 { get; set; }

        /// <summary>
        /// Reserved offset
        /// </summary>
        public uint ReservedOffset7 { get; set; }

        /// <summary>
        /// Reserved offset
        /// </summary>
        public uint ReservedOffset8 { get; set; }
    }
}