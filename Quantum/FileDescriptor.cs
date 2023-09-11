namespace SabreTools.Models.Quantum
{
    /// <summary>
    /// Quantum archive file descriptor
    /// </summary>
    /// <see href="https://handwiki.org/wiki/Software:Quantum_compression"/>
    public class FileDescriptor
    {
        /// <summary>
        /// Length of file name
        /// </summary>
        public int FileNameSize { get; set; }
        
        /// <summary>
        /// File name, variable length string, not zero-terminated
        /// </summary>
#if NET48
        public string FileName { get; set; }
#else
        public string? FileName { get; set; }
#endif

        /// <summary>
        /// Length of comment field
        /// </summary>
        public int CommentFieldSize { get; set; }

        /// <summary>
        /// Comment field, variable length string, not zero-terminated
        /// </summary>
#if NET48
        public string CommentField { get; set; }
#else
        public string? CommentField { get; set; }
#endif

        /// <summary>
        /// Fully expanded file size in bytes
        /// </summary>
        public uint ExpandedFileSize { get; set; }

        /// <summary>
        /// File time (DOS format) 
        /// </summary>
        public ushort FileTime { get; set; }

        /// <summary>
        /// File date (DOS format) 
        /// </summary>
        public ushort FileDate { get; set; }

        /// <summary>
        /// Unknown data, Checksum?
        /// </summary>
        /// <remarks>Minor version 22</remarks>
        public ushort? Unknown { get; set; }
    }
}