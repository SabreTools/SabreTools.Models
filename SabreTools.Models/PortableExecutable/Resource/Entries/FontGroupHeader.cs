﻿namespace SabreTools.Models.PortableExecutable.Resource.Entries
{
    /// <summary>
    /// Contains the information necessary for an application to access a specific font. The structure
    /// definition provided here is for explanation only; it is not present in any standard header file.
    /// </summary>
    /// <see href="https://learn.microsoft.com/en-us/windows/win32/menurc/fontgrouphdr"/>
    public sealed class FontGroupHeader
    {
        /// <summary>
        /// The number of individual fonts associated with this resource.
        /// </summary>
        public ushort NumberOfFonts { get; set; }

        /// <summary>
        /// A structure that contains a unique ordinal identifier for each font in the resource. The DE
        /// member is a placeholder for the variable-length array of DIRENTRY structures.
        /// </summary>
        public DirEntry[]? DE { get; set; }
    }
}
