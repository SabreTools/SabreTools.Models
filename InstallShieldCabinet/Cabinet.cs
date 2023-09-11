using System.Collections.Generic;

namespace SabreTools.Models.InstallShieldCabinet
{
    /// <see href="https://github.com/twogood/unshield/blob/main/lib/cabfile.h"/>
    /// <see href="https://github.com/twogood/unshield/blob/main/lib/internal.h"/>
    public sealed class Cabinet
    {
        #region Headers

        /// <summary>
        /// Common header
        /// </summary>
#if NET48
        public CommonHeader CommonHeader { get; set; }
#else
        public CommonHeader? CommonHeader { get; set; }
#endif

        /// <summary>
        /// Volume header
        /// </summary>
#if NET48
        public VolumeHeader VolumeHeader { get; set; }
#else
        public VolumeHeader? VolumeHeader { get; set; }
#endif

        /// <summary>
        /// Descriptor
        /// </summary>
#if NET48
        public Descriptor Descriptor { get; set; }
#else
        public Descriptor? Descriptor { get; set; }
#endif

        #endregion

        #region File Descriptors

        /// <summary>
        /// Offsets to all file descriptors
        /// </summary>
#if NET48
        public uint[] FileDescriptorOffsets { get; set; }
#else
        public uint[]? FileDescriptorOffsets { get; set; }
#endif

        /// <summary>
        /// Directory names
        /// </summary>
#if NET48
        public string[] DirectoryNames { get; set; }
#else
        public string[]? DirectoryNames { get; set; }
#endif

        /// <summary>
        /// Standard file descriptors
        /// </summary>
#if NET48
        public FileDescriptor[] FileDescriptors { get; set; }
#else
        public FileDescriptor?[]? FileDescriptors { get; set; }
#endif

        #endregion

        #region File Groups

        /// <summary>
        /// File group offset to offset list mapping
        /// </summary>
#if NET48
        public Dictionary<long, OffsetList> FileGroupOffsets { get; set; }
#else
        public Dictionary<long, OffsetList?>? FileGroupOffsets { get; set; }
#endif

        /// <summary>
        /// File groups
        /// </summary>
#if NET48
        public FileGroup[] FileGroups { get; set; }
#else
        public FileGroup?[]? FileGroups { get; set; }
#endif

        #endregion

        #region Components

        /// <summary>
        /// Component offset to offset list mapping
        /// </summary>
#if NET48
        public Dictionary<long, OffsetList> ComponentOffsets { get; set; }
#else
        public Dictionary<long, OffsetList?>? ComponentOffsets { get; set; }
#endif

        /// <summary>
        /// Components
        /// </summary>
#if NET48
        public Component[] Components { get; set; }
#else
        public Component?[]? Components { get; set; }
#endif

        #endregion
    }
}