namespace SabreTools.Models.SecuROM
{
    /// <summary>
    /// Most DFA-protected files seem to also have some additional encryption (it looks like SecuROM DFE, but that
    /// could be an incorrect guess); only early RC-encrypted executables seem to have anything parsable beyond the
    /// SDFA header. When I mention "observable cases" this is what I mean.
    /// </summary>
    public class DFAFileHeader
    {
        /// <summary>
        /// Value of unknown purpose. 0x00 0x04 0x00 0x00 in all observable cases.
        /// </summary>
        public int UnknownValueOne { get; set; }
        
        /// <summary>
        /// Value of unknown purpose, name given by subheader. 0x0C 0x00 0x00 0x00 in all observable cases.
        /// </summary>
        public int HVER { get; set; }

        /// <summary>
        /// Time stored in NTFS filetime, name given by subheader.
        /// https://learn.microsoft.com/en-us/windows/win32/sysinfo/file-times
        /// </summary>
        public ulong TIME { get; set; }
        
        /// <summary>
        /// 128-bit value of unknown purpose, name given by subheader.
        /// </summary>
        public byte[]? COID { get; set; }
        
        /// <summary>
        /// 128-bit value of unknown purpose, name given by subheader.
        /// D0 A2 25 C7 16 20 B7 43 99 74 2A BB 39 6B C3 57 in all observable cases.
        /// </summary>
        public byte[]? CUID { get; set; }
        
        /// <summary>
        /// 128-bit value of unknown purpose, name given by subheader. All 0x00 in all observable cases.
        /// </summary>
        public byte[]? SCID { get; set; }
        
        /// <summary>
        /// Value of unknown purpose, name given by subheader. 
        /// </summary>
        public ulong INVE { get; set; }
        
        /// <summary>
        /// Value of unknown purpose, name given by subheader. 
        /// </summary>
        public int XSPF { get; set; }
        
        /// <summary>
        /// Size of the decrypted executable. name given by subheader.
        /// </summary>
        public int RAWS { get; set; }
        
        /// <summary>
        /// Size of padding between the header and the MAC1 section. 832 in all observable cases. name given by subheader.
        /// </summary>
        public int PAD1 { get; set; }
    }
}
