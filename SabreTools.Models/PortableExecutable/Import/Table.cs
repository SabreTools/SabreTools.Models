using System.Collections.Generic;

namespace SabreTools.Models.PortableExecutable.Import
{
    /// <summary>
    /// All image files that import symbols, including virtually all executable (EXE) files,
    /// have an .idata section. A typical file layout for the import information follows:
    /// 
    ///     - Directory Table
    ///       Null Directory Entry
    ///     - DLL1 Import Lookup Table
    ///       Null
    ///     - DLL2 Import Lookup Table
    ///       Null
    ///     - DLL3 Import Lookup Table
    ///       Null
    ///     - Hint-Name Table
    /// </summary>
    /// <see href="https://learn.microsoft.com/en-us/windows/win32/debug/pe-format"/>
    public sealed class Table
    {
        /// <summary>
        /// The import information begins with the import directory table, which describes the
        /// remainder of the import information. 
        /// </summary>
        public DirectoryTableEntry[]? ImportDirectoryTable { get; set; }

        /// <summary>
        /// An import lookup table is an array of 32-bit numbers for PE32 or an array of 64-bit
        /// numbers for PE32+.
        /// </summary>
        public Dictionary<int, LookupTableEntry[]?>? ImportLookupTables { get; set; }

        /// <summary>
        /// These addresses are the actual memory addresses of the symbols, although technically
        /// they are still called "virtual addresses".
        /// </summary>
        public Dictionary<int, AddressTableEntry[]?>? ImportAddressTables { get; set; }

        /// <summary>
        /// One hint/name table suffices for the entire import section.
        /// </summary>
        public HintNameTableEntry[]? HintNameTable { get; set; }
    }
}
