namespace SabreTools.Models.SecuROM
{
    /// <summary>
    /// Securom Matroschka Package, a package contained in an executable as a section. Offered by SecuROM, its
    /// main purpose seems to be managing some sort of SecuROM-related operation involving multiple temporary
    /// files contained within the package. Observed in Release Control executables, Product Activation Revocation
    /// executables, and in some regular Product-Activation-protected releases (such as the digital download releases
    /// of Neverwinter Nights 2 and Test Drive Unlimited) where the game executable, paul.dll and other PA-related files
    /// are stored in the matroschka package. 
    /// </summary>
    public class MatroschkaHeader
    {
        /// <summary>
        /// Number of entries
        /// </summary>
        public int NumberOfEntries { get; set; }
        
        /// <summary>
        /// Three unknown values only observed on RC matroschka sections. They only ever seem to be 0 or 1.
        /// </summary>
        public int UnknownRCValueOne { get; set; }

        public int UnknownRCValueTwo { get; set; }
        
        public int UnknownRCValueThree { get; set; }
        
        /// <summary>
        /// Unknown 32-character string only observed on RC matroschka sections. Due to encryption on later 
        /// DFA-encrypted RC executables, this is the most reliable way to identify which executables are using 
        /// the same or a different key (even if the encrypted executables inside can be different).
        /// </summary>
        public string? UnknownRCString { get; set; }

    }
}
