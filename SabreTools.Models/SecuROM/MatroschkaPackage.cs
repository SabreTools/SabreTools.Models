using System.Collections.Generic;

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
    public class MatroschkaPackage
    {
        /// <summary>
        /// 1 or more entries
        /// </summary>
        public List<MatroschkaFileEntry>? Entries { get; set; }
    }
}
