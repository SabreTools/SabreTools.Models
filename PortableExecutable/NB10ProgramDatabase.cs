using System.Runtime.InteropServices;

namespace SabreTools.Models.PortableExecutable
{
    /// <summary>
    /// PDB 2.0 files
    /// </summary>
    /// <see href="https://www.debuginfo.com/articles/debuginfomatch.html"/>
    [StructLayout(LayoutKind.Sequential)]
    public sealed class NB10ProgramDatabase
    {
        /// <summary>
        /// "CodeView signature, equal to “NB10” 
        /// </summary>
        public uint Signature { get; set; }

        /// <summary>
        /// CodeView offset. Set to 0, because debug information
        /// is stored in a separate file.
        /// </summary>
        public uint Offset { get; set; }

        /// <summary>
        /// The time when debug information was created (in seconds
        /// since 01.01.1970) 
        /// </summary>
        public uint Timestamp { get; set; }

        /// <summary>
        /// Ever-incrementing value, which is initially set to 1 and
        /// incremented every time when a part of the PDB file is updated
        /// without rewriting the whole file. 
        /// </summary>
        public uint Age { get; set; }

        /// <summary>
        /// Null-terminated name of the PDB file. It can also contain full
        /// or partial path to the file. 
        /// </summary>
#if NET48
        public string PdbFileName { get; set; }
#else
        public string? PdbFileName { get; set; }
#endif
    }
}
