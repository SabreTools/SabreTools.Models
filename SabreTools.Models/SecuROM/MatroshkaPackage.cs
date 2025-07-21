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

        // The combination of the 3 following values have only been seen in
        // one of 3 distinct patterns. The meaning of these patterns is unknown.
        // - 0 0 1
        // - 0 1 1
        // - 1 1 1
        // These values do not seem to have a link to whether the paths included
        // in entries are 256- or 512-byte. There also do not seem to be any links
        // between these values and the hex string values.

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
        /// <remarks>Only a value of 1 has been found</remarks>
        public uint? UnknownRCValue3 { get; set; }

        /// <summary>
        /// 32-character hex string
        /// </summary>
        /// <remarks>
        /// Due to encryption on later DFA-encrypted RC executables, this is the
        /// most reliable way to identify which executables are using the same key.
        /// </remarks>
        public string? KeyHexString { get; set; }

        /// <summary>
        /// Padding for alignment, always 0x00000000
        /// </summary>
        public uint? Padding { get; set; }

        #endregion

        /// <summary>
        /// Entries array whose length is given by <see cref="EntryCount"/> 
        /// </summary>
        public MatroshkaEntry[]? Entries { get; set; }
    }
}