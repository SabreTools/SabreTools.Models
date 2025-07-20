namespace SabreTools.Models.SecuROM
{
    /// <summary>
    /// File entry
    /// </summary>
    public sealed class MatroschkaFileEntry
    {

        /// <summary>
        /// Value of unknown purpose. Seems to always be set to 1 for the first file (which seems to always be the 
        /// executable that manages matroschka operations, i.e. the matroschka helper executable), 2 for the second file 
        /// (which seems to always be the "main" executable, i.e. the RC-encrypted exe to be decrypted, the main game 
        /// program executable, or the revoker executable), 4 for the third file (seems to always be a "helper"
        /// executable or dll for the second file, such as DFA.dll for RC-encrypted executables since DFA decryption
        /// will be needed, paul.dll for PA-protected games, or remover.exe for revocation executables.
        /// My assumption is this has something to do with load order, but that's purely a guess.
        /// </summary>
        public int UnknownValueOne { get; set; }
        
        /// <summary>
        /// Size
        /// </summary>
        public int Size { get; set; }

        /// <summary>
        /// Offset
        /// </summary>
        public int Offset { get; set; }

        /// <summary>
        /// Later matroschka sections have 4 0x00 bytes here, earlier ones don't.
        /// </summary>
        public int DummyOne { get; set; }
        
        /// <summary>
        /// File modification time, stored in NTFS filetime.
        /// https://learn.microsoft.com/en-us/windows/win32/sysinfo/file-times
        /// </summary>
        public ulong ModifiedTime { get; set; }
        
        /// <summary>
        /// File creation time, stored in NTFS filetime.
        /// https://learn.microsoft.com/en-us/windows/win32/sysinfo/file-times
        /// </summary>
        public ulong CreatedTime { get; set; }
        
        /// <summary>
        /// File access time, stored in NTFS filetime.
        /// https://learn.microsoft.com/en-us/windows/win32/sysinfo/file-times
        /// </summary>
        public ulong AccessedTime { get; set; }
        
        /// <summary>
        /// MD5
        /// </summary>
        public string? Md5 { get; set; }
        
        /// <summary>
        /// Name
        /// Doesn't seem to ever have spaces, but can contain filepaths with backslashes.
        /// </summary>
        public string? Name { get; set; }
    }
}
