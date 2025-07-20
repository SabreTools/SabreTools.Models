using System;

namespace SabreTools.Models.SecuROM
{
    /// <summary>
    /// Most DFA-protected files seem to also have some additional encryption (it looks like SecuROM DFE, but that
    /// could be an incorrect guess); only early RC-encrypted executables seem to have anything parsable beyond the
    /// SDFA header. This is what is meant by "observable cases".
    /// </summary>
    public class DFAFileFooter
    {
        /// <summary>
        /// Length of UR01 string. 
        /// </summary>
        public uint UR01Length { get; set; }
        
        /// <summary>
        /// First URL to connect to.
        /// </summary>
        /// <remarks>
        /// Name given by subheader.
        /// </remarks>
        public string? UR01 { get; set; }
        
        /// <summary>
        /// Length of UR02 string. Only present if UR02 is.
        /// </summary>
        public uint? UR02Length { get; set; }
        
        /// <summary>
        /// Second URL to connect to. Not always present.
        /// </summary>
        /// <remarks>
        /// Name given by subheader.
        /// </remarks>
        public string? UR02 { get; set; }
        
        /// <summary>
        /// Value of unknown purpose. 
        /// </summary>
        /// <remarks>
        /// Name given by subheader.
        /// </remarks>
        public uint PKID { get; set; }
        
        /// <summary>
        /// First value of unknown purpose following PKNA. 
        /// TODO: This is the only time the 4-byte value following the subheader isn't consistent; it always seems like
        /// TODO: it's just been part of the subheader on the others. Why is this different?
        /// </summary>
        public uint PKNAUnknownValueOne { get; set; }
        
        /// <summary>
        /// Second value of unknown purpose following PKNA. 0x09 in all observable cases.
        /// </summary>
        public uint PKNAUnknownValueTwo { get; set; }
        
        /// <summary>
        /// Byte length of PKNA string.
        /// </summary>
        public uint PKNALength { get; set; }
        
        /// <summary>
        /// Serial to let SecuROM RC servers know what executable is being unlocked. Double-byte (UTF16?) string.  Name
        /// given by subheader.
        /// </summary>
        public string? PKNA { get; set; }
        
        /// <summary>
        /// 128-bit value of unknown purpose.
        /// </summary>
        /// <remarks>
        /// Name given by subheader.
        /// </remarks>
        public Guid MAC2 { get; set; }
    }
}
