using System;

namespace SabreTools.Models.SecuROM
{
    /// <summary>
    /// Most DFA-protected files seem to also have some additional encryption (it looks like SecuROM DFE, but that
    /// could be an incorrect guess); only early RC-encrypted executables seem to have anything parsable beyond the
    /// SDFA header. This is what is meant by "observable cases".
    /// </summary>
    public class DFAFileHeader
    {
        /// <summary>
        /// Value of unknown purpose. 0x00 0x04 0x00 0x00 in all observable cases.
        /// </summary>
        public uint UnknownValueOne { get; set; }
        
        /// <summary>
        /// Value of unknown purpose. 0x0C 0x00 0x00 0x00 in all observable cases.
        /// </summary>
        /// <remarks>
        /// Name given by subheader.
        /// </remarks>
        public uint HVER { get; set; }

        /// <summary>
        /// Time stored in NTFS filetime.
        /// https://learn.microsoft.com/en-us/windows/win32/sysinfo/file-times
        /// </summary>
        /// <remarks>
        /// Name given by subheader.
        /// </remarks>
        public ulong TIME { get; set; }
        
        /// <summary>
        /// 128-bit value of unknown purpose.
        /// </summary>
        /// <remarks>
        /// Name given by subheader.
        /// </remarks>
        public Guid COID { get; set; }
        
        /// <summary>
        /// 128-bit value of unknown purpose.
        /// D0 A2 25 C7 16 20 B7 43 99 74 2A BB 39 6B C3 57 in all observable cases.
        /// </summary>
        /// <remarks>
        /// Name given by subheader.
        /// </remarks>
        public Guid CUID { get; set; }
        
        /// <summary>
        /// 128-bit value of unknown purpose. All 0x00 in all observable cases.
        /// </summary>
        /// <remarks>
        /// Name given by subheader.
        /// </remarks>
        public Guid? SCID { get; set; }
        
        /// <summary>
        /// Value of unknown purpose. 
        /// </summary>
        /// <remarks>
        /// Name given by subheader.
        /// </remarks>
        public ulong INVE { get; set; }
        
        /// <summary>
        /// Value of unknown purpose. 
        /// </summary>
        /// <remarks>
        /// Name given by subheader.
        /// </remarks>
        public uint XSPF { get; set; }
        
        /// <summary>
        /// Size of the decrypted executable.
        /// </summary>
        /// <remarks>
        /// Name given by subheader.
        /// </remarks>
        public uint RAWS { get; set; }
        
        /// <summary>
        /// Size of padding between the header and the MAC1 section. 832 in all observable cases.
        /// </summary>
        /// <remarks>
        /// Name given by subheader.
        /// </remarks>
        public uint PAD1 { get; set; }
    }
}
