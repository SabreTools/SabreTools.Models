using System.Collections.Generic;

namespace SabreTools.Models.SGA
{
    /// <summary>
    /// Specialization File7 and up where the CRC moved to the header and the CRC is of the compressed data and there are stronger hashes.
    /// </summary>
    /// <see href="https://github.com/RavuAlHemio/hllib/blob/master/HLLib/SGAFile.h"/>
    public class SpecializedDirectory<THeader, TDirectoryHeader, TSection, TFolder, TFile, U> : Directory
        where THeader : Header
        where TDirectoryHeader : DirectoryHeader<U>
        where TSection : Section<U>
        where TFolder : Folder<U>
        where TFile : File4
    {
        /// <summary>
        /// Source SGA file
        /// </summary>
#if NET48
        public File File { get; set; }
#else
        public File? File { get; set; }
#endif

        /// <summary>
        /// Directory header data
        /// </summary>
#if NET48
        public TDirectoryHeader DirectoryHeader { get; set; }
#else
        public TDirectoryHeader? DirectoryHeader { get; set; }
#endif

        /// <summary>
        /// Sections data
        /// </summary>
#if NET48
        public TSection[] Sections { get; set; }
#else
        public TSection?[]? Sections { get; set; }
#endif

        /// <summary>
        /// Folders data
        /// </summary>
#if NET48
        public TFolder[] Folders { get; set; }
#else
        public TFolder?[]? Folders { get; set; }
#endif

        /// <summary>
        /// Files data
        /// </summary>
#if NET48
        public TFile[] Files { get; set; }
#else
        public TFile?[]? Files { get; set; }
#endif

        /// <summary>
        /// String table data
        /// </summary>
#if NET48
        public Dictionary<long, string> StringTable { get; set; }
#else
        public Dictionary<long, string?>? StringTable { get; set; }
#endif
    }
}
