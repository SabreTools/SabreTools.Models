using System.Collections.Generic;

namespace SabreTools.Models.PortableExecutable
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
    public sealed class ImportTable
    {
        /// <summary>
        /// The import information begins with the import directory table, which describes the
        /// remainder of the import information. 
        /// </summary>
#if NET48
        public ImportDirectoryTableEntry[] ImportDirectoryTable;
#else
        public ImportDirectoryTableEntry[]? ImportDirectoryTable;
#endif

        /// <summary>
        /// An import lookup table is an array of 32-bit numbers for PE32 or an array of 64-bit
        /// numbers for PE32+.
        /// </summary>
#if NET48
        public Dictionary<int, ImportLookupTableEntry[]> ImportLookupTables;
#else
        public Dictionary<int, ImportLookupTableEntry?[]?>? ImportLookupTables;
#endif

        /// <summary>
        /// These addresses are the actual memory addresses of the symbols, although technically
        /// they are still called "virtual addresses".
        /// </summary>
#if NET48
        public Dictionary<int, ImportAddressTableEntry[]> ImportAddressTables;
#else
        public Dictionary<int, ImportAddressTableEntry?[]?>? ImportAddressTables;
#endif

        /// <summary>
        /// One hint/name table suffices for the entire import section.
        /// </summary>
#if NET48
        public HintNameTableEntry[] HintNameTable;
#else
        public HintNameTableEntry[]? HintNameTable;
#endif
    }
}
