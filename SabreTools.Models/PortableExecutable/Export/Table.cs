﻿namespace SabreTools.Models.PortableExecutable.Export
{
    /// <summary>
    /// The export data section, named .edata, contains information about symbols that other images
    /// can access through dynamic linking. Exported symbols are generally found in DLLs, but DLLs
    /// can also import symbols.
    /// 
    /// An overview of the general structure of the export section is described below. The tables
    /// described are usually contiguous in the file in the order shown (though this is not
    /// required). Only the export directory table and export address table are required to export
    /// symbols as ordinals. (An ordinal is an export that is accessed directly by its export
    /// address table index.) The name pointer table, ordinal table, and export name table all
    /// exist to support use of export names.
    /// </summary>
    /// <see href="https://learn.microsoft.com/en-us/windows/win32/debug/pe-format"/>
    public sealed class Table
    {
        // TODO: Look into splitting this up
        // Technically speaking, even though all of these should live in the same
        // section, there is nothing in the spec that guarantees that they are together
        // outside of the obvious logical grouping. The directory table is more obviously
        // directly a part of the executable, while the other 4 structures are all based
        // on information from that one-row table.

        /// <summary>
        /// A table with just one row (unlike the debug directory). This table indicates the
        /// locations and sizes of the other export tables.
        /// </summary>
        public DirectoryTable? ExportDirectoryTable { get; set; }

        /// <summary>
        /// An array of RVAs of exported symbols. These are the actual addresses of the exported
        /// functions and data within the executable code and data sections. Other image files
        /// can import a symbol by using an index to this table (an ordinal) or, optionally, by
        /// using the public name that corresponds to the ordinal if a public name is defined.
        /// </summary>
        public AddressTableEntry[]? ExportAddressTable { get; set; }

        /// <summary>
        /// An array of pointers to the public export names, sorted in ascending order.
        /// </summary>
        public NamePointerTable? NamePointerTable { get; set; }

        /// <summary>
        /// An array of the ordinals that correspond to members of the name pointer table. The
        /// correspondence is by position; therefore, the name pointer table and the ordinal table
        /// must have the same number of members. Each ordinal is an index into the export address
        /// table.
        /// </summary>
        public OrdinalTable? OrdinalTable { get; set; }

        /// <summary>
        /// A series of null-terminated ASCII strings. Members of the name pointer table point into
        /// this area. These names are the public names through which the symbols are imported and
        /// exported; they are not necessarily the same as the private names that are used within
        /// the image file. 
        /// </summary>
        public NameTable? ExportNameTable { get; set; }
    }
}
