namespace SabreTools.Models.RomCenter
{
    /// <remarks>[emulator]</remarks>
    public class Emulator
    {
        /// <remarks>refname</remarks>
        public string? RefName { get; set; }

        /// <remarks>version</remarks>
        public string? Version { get; set; }

        #region DO NOT USE IN PRODUCTION

        /// <remarks>Should be empty</remarks>
        public string[]? ADDITIONAL_ELEMENTS { get; set; }

        #endregion
    }
}