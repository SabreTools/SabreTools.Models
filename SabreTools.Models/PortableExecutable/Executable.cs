namespace SabreTools.Models.PortableExecutable
{
    /// <summary>
    /// The following list describes the Microsoft PE executable format, with the
    /// base of the image header at the top. The section from the MS-DOS 2.0
    /// Compatible EXE Header through to the unused section just before the PE header
    /// is the MS-DOS 2.0 Section, and is used for MS-DOS compatibility only.
    /// </summary>
    /// <see href="https://learn.microsoft.com/en-us/windows/win32/debug/pe-format"/>
    public sealed class Executable
    {
        /// <summary>
        /// MS-DOS executable stub
        /// </summary>
        public MSDOS.Executable? Stub { get; set; }

        /// <summary>
        /// After the MS-DOS stub, at the file offset specified at offset 0x3c, is a 4-byte
        /// signature that identifies the file as a PE format image file. This signature is "PE\0\0"
        /// (the letters "P" and "E" followed by two null bytes).
        /// </summary>
        public string? Signature { get; set; }

        /// <summary>
        /// COFF file header
        /// </summary>
        public COFF.FileHeader? FileHeader { get; set; }

        /// <summary>
        /// Optional header
        /// </summary>
        public OptionalHeader? OptionalHeader { get; set; }

        // TODO: Support grouped sections in section reading and parsing
        // https://learn.microsoft.com/en-us/windows/win32/debug/pe-format#grouped-sections-object-only
        // Grouped sections are ordered and mean that the data in the sections contributes
        // to the "base" section (the one without the "$X" suffix). This may negatively impact
        // the use of some of the different types of executables.

        /// <summary>
        /// Section table
        /// </summary>
        public COFF.SectionHeader[]? SectionTable { get; set; }

        /// <summary>
        /// COFF symbol table
        /// </summary>
        public COFF.SymbolTableEntries.BaseEntry[]? SymbolTable { get; set; }

        /// <summary>
        /// COFF string table
        /// </summary>
        public COFF.StringTable? StringTable { get; set; }

        /// <summary>
        /// Attribute certificate table
        /// </summary>
        public AttributeCertificate.Entry[]? AttributeCertificateTable { get; set; }

        /// <summary>
        /// Delay-load directory table
        /// </summary>
        public DelayLoad.DirectoryTable? DelayLoadDirectoryTable { get; set; }

        #region Named Sections

        // .cormeta - CLR metadata is stored in this section. It is used to indicate that
        // the object file contains managed code. The format of the metadata is not
        // documented, but can be handed to the CLR interfaces for handling metadata.

        /// <summary>
        /// Base relocation table (.reloc)
        /// </summary>
        public BaseRelocation.Block[]? BaseRelocationTable { get; set; }

        /// <summary>
        /// Debug table (.debug*)
        /// </summary>
        public DebugData.Table? DebugTable { get; set; }

        // .drectve - A section is a directive section if it has the IMAGE_SCN_LNK_INFO
        // flag set in the section header and has the .drectve section name. The linker
        // removes a .drectve section after processing the information, so the section
        // does not appear in the image file that is being linked.
        //
        // A .drectve section consists of a string of text that can be encoded as ANSI
        // or UTF-8. If the UTF-8 byte order marker (BOM, a three-byte prefix that
        // consists of 0xEF, 0xBB, and 0xBF) is not present, the directive string is
        // interpreted as ANSI. The directive string is a series of linker options that
        // are separated by spaces. Each option contains a hyphen, the option name, and
        // any appropriate attribute. If an option contains spaces, the option must be
        // enclosed in quotes. The .drectve section must not have relocations or line
        // numbers.
        //
        // TODO: Can we implement reading/parsing the .drectve section?

        /// <summary>
        /// Export table (.edata)
        /// </summary>
        public Export.Table? ExportTable { get; set; }

        /// <summary>
        /// Import table (.idata)
        /// </summary>
        public ImportTable? ImportTable { get; set; }

        /// <summary>
        /// Resource directory table (.rsrc)
        /// </summary>
        public ResourceDirectoryTable? ResourceDirectoryTable { get; set; }

        // .sxdata - The valid exception handlers of an object are listed in the .sxdata
        // section of that object. The section is marked IMAGE_SCN_LNK_INFO. It contains
        // the COFF symbol index of each valid handler, using 4 bytes per index.
        //
        // Additionally, the compiler marks a COFF object as registered SEH by emitting
        // the absolute symbol "@feat.00" with the LSB of the value field set to 1. A
        // COFF object with no registered SEH handlers would have the "@feat.00" symbol,
        // but no .sxdata section.
        //
        // TODO: Can we implement reading/parsing the .sxdata section?

        #endregion

        // TODO: Implement and/or document the following non-modeled parts:
        // - Delay-Load Import Tables
        //      - [The Delay-Load Directory Table]
        //      - Delay Import Address Table
        //      - Delay Import Name Table
        //      - Delay Bound Import Address Table
        //      - Delay Unload Import Address Table
        // - The .pdata Section [Multiple formats per entry]
        // - The .tls Section
        //      - TLS Callback Functions
        // - [The Load Configuration Structure (Image Only)]

        // TODO: Determine if "Archive (Library) File Format" is worth modelling
    }
}
