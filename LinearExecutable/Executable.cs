namespace SabreTools.Models.LinearExecutable
{
    /// <summary>
    /// The `LINEAR` executable-file header contains information that the loader requires for
    /// segmented executable files. This information includes the linker version number, data
    /// specified by linker, data specified by resource compiler, tables of segment data, tables
    /// of resource data, and so on. The following illustrations shows the LE file header:
    /// </summary>
    /// <see href="https://faydoc.tripod.com/formats/exe-LE.htm"/>
    /// <see href="http://www.edm2.com/index.php/LX_-_Linear_eXecutable_Module_Format_Description"/>
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
        /// Information block
        /// </summary>
#if NET48
        public InformationBlock InformationBlock { get; set; }
#else
        public InformationBlock? InformationBlock { get; set; }
#endif

        /// <summary>
        /// Object table
        /// </summary>
#if NET48
        public ObjectTableEntry[] ObjectTable { get; set; }
#else
        public ObjectTableEntry?[]? ObjectTable { get; set; }
#endif

        /// <summary>
        /// Object page map
        /// </summary>
#if NET48
        public ObjectPageMapEntry[] ObjectPageMap { get; set; }
#else
        public ObjectPageMapEntry?[]? ObjectPageMap { get; set; }
#endif

        // TODO: Object iterate data map table (Undefined)

        /// <summary>
        /// Resource table
        /// </summary>
#if NET48
        public ResourceTableEntry[] ResourceTable { get; set; }
#else
        public ResourceTableEntry?[]? ResourceTable { get; set; }
#endif

        /// <summary>
        /// Resident Name table
        /// </summary>
#if NET48
        public ResidentNamesTableEntry[] ResidentNamesTable { get; set; }
#else
        public ResidentNamesTableEntry?[]? ResidentNamesTable { get; set; }
#endif

        /// <summary>
        /// Entry table
        /// </summary>
#if NET48
        public EntryTableBundle[] EntryTable { get; set; }
#else
        public EntryTableBundle?[]? EntryTable { get; set; }
#endif

        /// <summary>
        /// Module format directives table (optional)
        /// </summary>
#if NET48
        public ModuleFormatDirectivesTableEntry[] ModuleFormatDirectivesTable { get; set; }
#else
        public ModuleFormatDirectivesTableEntry?[]? ModuleFormatDirectivesTable { get; set; }
#endif

        /// <summary>
        /// Verify record directive table (optional)
        /// </summary>
#if NET48
        public VerifyRecordDirectiveTableEntry[] VerifyRecordDirectiveTable { get; set; }
#else
        public VerifyRecordDirectiveTableEntry?[]? VerifyRecordDirectiveTable { get; set; }
#endif

        /// <summary>
        /// Fix-up page table
        /// </summary>
#if NET48
        public FixupPageTableEntry[] FixupPageTable { get; set; }
#else
        public FixupPageTableEntry?[]? FixupPageTable { get; set; }
#endif

        /// <summary>
        /// Fix-up record table
        /// </summary>
#if NET48
        public FixupRecordTableEntry[] FixupRecordTable { get; set; }
#else
        public FixupRecordTableEntry?[]? FixupRecordTable { get; set; }
#endif

        /// <summary>
        /// Import module name table
        /// </summary>
#if NET48
        public ImportModuleNameTableEntry[] ImportModuleNameTable { get; set; }
#else
        public ImportModuleNameTableEntry?[]? ImportModuleNameTable { get; set; }
#endif

        /// <summary>
        /// Import procedure name table
        /// </summary>
#if NET48
        public ImportModuleProcedureNameTableEntry[] ImportModuleProcedureNameTable { get; set; }
#else
        public ImportModuleProcedureNameTableEntry?[]? ImportModuleProcedureNameTable { get; set; }
#endif

        /// <summary>
        /// Per-Page checksum table
        /// </summary>
#if NET48
        public PerPageChecksumTableEntry[] PerPageChecksumTable { get; set; }
#else
        public PerPageChecksumTableEntry?[]? PerPageChecksumTable { get; set; }
#endif

        /// <summary>
        /// Non-Resident Name table
        /// </summary>
#if NET48
        public NonResidentNamesTableEntry[] NonResidentNamesTable { get; set; }
#else
        public NonResidentNamesTableEntry?[]? NonResidentNamesTable { get; set; }
#endif

        // TODO: Non-resident directives data (Undefined)

        /// <summary>
        /// Debug information
        /// </summary>
#if NET48
        public DebugInformation DebugInformation { get; set; }
#else
        public DebugInformation? DebugInformation { get; set; }
#endif
    }
}
