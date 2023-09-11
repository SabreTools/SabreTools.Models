namespace SabreTools.Models.Quantum
{
    /// <summary>
    /// Quantum archive file structure
    /// </summary>
    /// <see href="https://handwiki.org/wiki/Software:Quantum_compression"/>
    public class Archive
    {
        /// <summary>
        /// Quantum header
        /// </summary>
#if NET48
        public Header Header { get; set; }
#else
        public Header? Header { get; set; }
#endif

        /// <summary>
        /// This is immediately followed by the list of files
        /// </summary>
#if NET48
        public FileDescriptor[] FileList { get; set; }
#else
        public FileDescriptor?[]? FileList { get; set; }
#endif

        /// <summary>
        /// Immediately following the list of files is the compressed data
        /// </summary>
        public long CompressedDataOffset { get; set; }
    }
}