using System.Collections.Generic;

namespace SabreTools.Models.NewExecutable
{
    /// <summary>
    /// The segmented EXE header contains general information about the EXE
    /// file and contains information on the location and size of the other
    /// sections. The Windows loader copies this section, along with other
    /// data, into the module table in the system data. The module table is
    /// internal data used by the loader to manage the loaded executable
    /// modules in the system and to support dynamic linking.
    /// </summary>
    /// <see href="http://bytepointer.com/resources/win16_ne_exe_format_win3.0.htm"/>
    public sealed class Executable
    {
        /// <summary>
        /// MS-DOS executable stub
        /// </summary>
#if NET48
        public MSDOS.Executable Stub { get; set; }
#else
        public MSDOS.Executable? Stub { get; set; }
#endif

        /// <summary>
        /// New Executable header
        /// </summary>
#if NET48
        public ExecutableHeader Header { get; set; }
#else
        public ExecutableHeader? Header { get; set; }
#endif

        /// <summary>
        /// Segment table
        /// </summary>
#if NET48
        public SegmentTableEntry[] SegmentTable { get; set; }
#else
        public SegmentTableEntry[]? SegmentTable { get; set; }
#endif

        /// <summary>
        /// Resource table
        /// </summary>
#if NET48
        public ResourceTable ResourceTable { get; set; }
#else
        public ResourceTable? ResourceTable { get; set; }
#endif

        /// <summary>
        /// Resident-Name table
        /// </summary>
#if NET48
        public ResidentNameTableEntry[] ResidentNameTable { get; set; }
#else
        public ResidentNameTableEntry[]? ResidentNameTable { get; set; }
#endif

        /// <summary>
        /// Module-Reference table
        /// </summary>
#if NET48
        public ModuleReferenceTableEntry[] ModuleReferenceTable { get; set; }
#else
        public ModuleReferenceTableEntry[]? ModuleReferenceTable { get; set; }
#endif

        /// <summary>
        /// Imported-Name table
        /// </summary>
#if NET48
        public Dictionary<ushort, ImportedNameTableEntry> ImportedNameTable { get; set; }
#else
        public Dictionary<ushort, ImportedNameTableEntry?>? ImportedNameTable { get; set; }
#endif

        /// <summary>
        /// Entry table
        /// </summary>
#if NET48
        public EntryTableBundle[] EntryTable { get; set; }
#else
        public EntryTableBundle[]? EntryTable { get; set; }
#endif

        /// <summary>
        /// Nonresident-Name table
        /// </summary>
#if NET48
        public NonResidentNameTableEntry[] NonResidentNameTable { get; set; }
#else
        public NonResidentNameTableEntry[]? NonResidentNameTable { get; set; }
#endif
    }
}
