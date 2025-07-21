namespace SabreTools.Models.SecuROM
{
    /// <summary>
    /// Securom Matroschka Package, a package contained in an executable as
    /// a section. Offered by SecuROM, its main purpose seems to be managing
    /// some sort of SecuROM-related operation involving multiple temporary
    /// files contained within the package. Observed in Release Control
    /// executables, Product Activation Revocation executables, and in some
    /// regular Product-Activation-protected releases (such as the digital
    /// download releases of Neverwinter Nights 2 and Test Drive Unlimited)
    /// where the game executable, paul.dll and other PA-related files are
    /// stored in the matroschka package. 
    /// </summary>
    public class MatroshkaPackage
    {
        /// <summary>
        /// "MatR"
        /// </summary>
        /// <remarks>4 bytes</remarks>
        public string? Signature { get; set; }

        /// <summary>
        /// Number of internal entries
        /// </summary>
        public uint EntryCount { get; set; }

        #region Release Control only

        /// <summary>
        /// One of four unknown values only observed on RC matroschka sections
        /// </summary>
        /// <remarks>Only values of 0 or 1 have been found</remarks>
        public uint? UnknownRCValue1 { get; set; }

        /// <summary>
        /// One of four unknown values only observed on RC matroschka sections
        /// </summary>
        /// <remarks>Only values of 0 or 1 have been found</remarks>
        public uint? UnknownRCValue2 { get; set; }

        /// <summary>
        /// One of four unknown values only observed on RC matroschka sections
        /// </summary>
        /// <remarks>Only values of 0 or 1 have been found</remarks>
        public uint? UnknownRCValue3 { get; set; }

        /// <summary>
        /// Unknown 32-character string only observed on RC matroschka sections.
        /// Due to encryption on later  DFA-encrypted RC executables, this is the
        /// most reliable way to identify which executables are using the same or
        /// a different key (even if the encrypted executables inside can be
        /// different).
        /// </summary>
        public string? UnknownRCString { get; set; }

        /// <summary>
        /// One of four unknown values only observed on RC matroschka sections,
        /// possibly padding for alignment
        /// </summary>
        /// <remarks>Only a value of 0 have been found</remarks>
        public uint? UnknownRCValue4 { get; set; }

        #endregion

        /// <summary>
        /// Entries array whose length is given by <see cref="EntryCount"/> 
        /// </summary>
        public MatroshkaEntry[]? Entries { get; set; }
    }
}