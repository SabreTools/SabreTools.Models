namespace SabreTools.Models.SecuROM
{
    public class MatroshkaEntry
    {
        /// <summary>
        /// File entry path
        /// - Older versions are always 256 bytes
        /// - Newer versions are always 512 bytes
        /// </summary>
        /// <remarks>Length may be tied to unknown values in header</remarks>
        public byte[]? Path { get; set; }

        /// <summary>
        /// Type of the entry data
        /// </summary>
        public MatroshkaEntryType EntryType { get; set; }

        /// <summary>
        /// Data size
        /// </summary>
        public uint Size { get; set; }

        /// <summary>
        /// Data offset within the package
        /// </summary>
        public uint Offset { get; set; }

        /// <summary>
        /// Unknown value only seen in later versions
        /// </summary>
        public uint? Unknown { get; set; }

        /// <summary>
        /// File modification time, stored in NTFS filetime.
        /// </summary>
        /// <see href="https://learn.microsoft.com/en-us/windows/win32/sysinfo/file-times"/> 
        public ulong ModifiedTime { get; set; }

        /// <summary>
        /// File creation time, stored in NTFS filetime.
        /// </summary>
        /// <see href="https://learn.microsoft.com/en-us/windows/win32/sysinfo/file-times"/> 
        public ulong CreatedTime { get; set; }

        /// <summary>
        /// File access time, stored in NTFS filetime.
        /// </summary>
        /// <see href="https://learn.microsoft.com/en-us/windows/win32/sysinfo/file-times"/> 
        public ulong AccessedTime { get; set; }

        /// <summary>
        /// MD5 hash of the data
        /// </summary>
        /// <remarks>16 bytes</remarks>
        public byte[]? MD5 { get; set; }
    }
}