using System;

namespace SabreTools.Models.InstallShieldCabinet
{
    /// <see href="https://github.com/twogood/unshield/blob/main/lib/libunshield.h"/>
    public sealed class Component
    {
        /// <summary>
        /// Offset to the component identifier
        /// </summary>
        public uint IdentifierOffset;

        /// <summary>
        /// Component identifier
        /// </summary>
#if NET48
        public string Identifier;
#else
        public string? Identifier;
#endif

        /// <summary>
        /// Offset to the component descriptor
        /// </summary>
        public uint DescriptorOffset;

        /// <summary>
        /// Offset to the display name
        /// </summary>
        public uint DisplayNameOffset;

        /// <summary>
        /// Display name
        /// </summary>
#if NET48
        public string DisplayName;
#else
        public string? DisplayName;
#endif

        /// <summary>
        /// Reserved
        /// </summary>
#if NET48
        public byte[] Reserved0;
#else
        public byte[]? Reserved0;
#endif

        /// <summary>
        /// Reserved offset
        /// </summary>
        public uint ReservedOffset0;

        /// <summary>
        /// Reserved offset
        /// </summary>
        public uint ReservedOffset1;

        /// <summary>
        /// Component index
        /// </summary>
        public ushort ComponentIndex;

        /// <summary>
        /// Offset to the component name
        /// </summary>
        public uint NameOffset;

        /// <summary>
        /// Component name
        /// </summary>
#if NET48
        public string Name;
#else
        public string? Name;
#endif

        /// <summary>
        /// Reserved offset
        /// </summary>
        public uint ReservedOffset2;

        /// <summary>
        /// Reserved offset
        /// </summary>
        public uint ReservedOffset3;

        /// <summary>
        /// Reserved offset
        /// </summary>
        public uint ReservedOffset4;

        /// <summary>
        /// Reserved
        /// </summary>
#if NET48
        public byte[] Reserved1;
#else
        public byte[]? Reserved1;
#endif

        /// <summary>
        /// Offset to the component CLSID
        /// </summary>
        public uint CLSIDOffset;

        /// <summary>
        /// Component CLSID
        /// </summary>
        public Guid CLSID;

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
        /// Number of depends(?)
        /// </summary>
        public ushort DependsCount;

        /// <summary>
        /// Offset to depends(?)
        /// </summary>
        public uint DependsOffset;

        /// <summary>
        /// Number of file groups
        /// </summary>
        public uint FileGroupCount;

        /// <summary>
        /// Offset to the file group names
        /// </summary>
        public uint FileGroupNamesOffset;

        /// <summary>
        /// File group names
        /// </summary>
#if NET48
        public string[] FileGroupNames;
#else
        public string[]? FileGroupNames;
#endif

        /// <summary>
        /// Number of X3(?)
        /// </summary>
        public ushort X3Count;

        /// <summary>
        /// Offset to X3(?)
        /// </summary>
        public uint X3Offset;

        /// <summary>
        /// Number of sub-components
        /// </summary>
        public ushort SubComponentsCount;

        /// <summary>
        /// Offset to the sub-components
        /// </summary>
        public uint SubComponentsOffset;

        /// <summary>
        /// Offset to the next component
        /// </summary>
        public uint NextComponentOffset;

        /// <summary>
        /// Reserved offset
        /// </summary>
        public uint ReservedOffset5;

        /// <summary>
        /// Reserved offset
        /// </summary>
        public uint ReservedOffset6;

        /// <summary>
        /// Reserved offset
        /// </summary>
        public uint ReservedOffset7;

        /// <summary>
        /// Reserved offset
        /// </summary>
        public uint ReservedOffset8;
    }
}