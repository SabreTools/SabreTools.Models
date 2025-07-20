namespace SabreTools.Models.SecuROM
{
    public class DFAFileFooter
    {
        /// <summary>
        /// First URL to connect to. name given by subheader.
        /// </summary>
        public string? UR01 { get; set; }
        
        /// <summary>
        /// Second URL to connect to. Not always present. name given by subheader.
        /// </summary>
        public string? UR02 { get; set; }
        
        /// <summary>
        /// Value of unknown purpose, name given by subheader. 
        /// </summary>
        public int PKID { get; set; }
        
        /// <summary>
        /// First value of unknown purpose following PKNA. 
        /// TODO: This is the only time the 4-byte value following the subheader isn't consistent; it always seems like
        /// TODO: it's just been part of the subheader on the others. Why is this different?
        /// </summary>
        public int PKNAUnknownValueOne { get; set; }
        
        /// <summary>
        /// Second value of unknown purpose following PKNA. 0x09 in all observable cases.
        /// </summary>
        public int PKNAUnknownValueTwo { get; set; }
        
        /// <summary>
        /// Byte length of PKNA string.
        /// </summary>
        public int PKNALength { get; set; }
        
        /// <summary>
        /// Serial to let SecuROM RC servers know what executable is being unlocked. Double-byte (UTF16?) string.  Name
        /// given by subheader.
        /// </summary>
        public string? PKNA { get; set; }
        
        /// <summary>
        /// 128-bit value of unknown purpose, name given by subheader.
        /// </summary>
        public byte[]? MAC2 { get; set; }
    }
}
