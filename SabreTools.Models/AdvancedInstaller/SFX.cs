namespace SabreTools.Models.AdvancedInstaller
{
    /// <summary>
    /// Represents the structure at the end of a Caphyon
    /// Advanced Installer SFX file. These SFX files store
    /// all files uncompressed sequentially in the overlay
    /// of an executable.
    /// </summary>
    public class SFX
    {
        /// <summary>
        /// Set of file entries
        /// </summary>
        public FileEntry[]? Entries { get; set; }

        /// <summary>
        /// Footer representing the central directory
        /// </summary>
        public Footer? Footer { get; set; }
    }
}
