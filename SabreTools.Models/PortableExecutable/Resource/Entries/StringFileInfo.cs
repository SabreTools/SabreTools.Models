﻿namespace SabreTools.Models.PortableExecutable.Resource.Entries
{
    /// <summary>
    /// Represents the organization of data in a file-version resource. It contains version
    /// information that can be displayed for a particular language and code page.
    /// </summary>
    /// <see href="https://learn.microsoft.com/en-us/windows/win32/menurc/stringfileinfo"/>
    public sealed class StringFileInfo
    {
        /// <summary>
        /// The length, in bytes, of the entire StringFileInfo block, including all
        /// structures indicated by the Children member.
        /// </summary>
        public ushort Length { get; set; }

        /// <summary>
        /// This member is always equal to zero.
        /// </summary>
        public ushort ValueLength { get; set; }

        /// <summary>
        /// The type of data in the version resource.
        /// </summary>
        public VersionResourceType ResourceType { get; set; }

        /// <summary>
        /// The Unicode string L"StringFileInfo".
        /// </summary>
        public string? Key { get; set; }

        /// <summary>
        /// As many zero words as necessary to align the Children member on a 32-bit boundary.
        /// </summary>
        public ushort Padding { get; set; }

        /// <summary>
        /// An array of one or more StringTable structures. Each StringTable structure's Key
        /// member indicates the appropriate language and code page for displaying the text in
        /// that StringTable structure.
        /// </summary>
        public StringTable[]? Children { get; set; }
    }
}
