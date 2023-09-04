namespace SabreTools.Models.RomCenter
{
    /// <remarks>[emulator]</remarks>
    public class Emulator
    {
        /// <remarks>refname</remarks>
#if NET48
        public string RefName { get; set; }
#else
        public string? RefName { get; set; }
#endif

        /// <remarks>version</remarks>
#if NET48
        public string Version { get; set; }
#else
        public string? Version { get; set; }
#endif

        #region DO NOT USE IN PRODUCTION

        /// <remarks>Should be empty</remarks>
#if NET48
        public string[] ADDITIONAL_ELEMENTS { get; set; }
#else
        public string[]? ADDITIONAL_ELEMENTS { get; set; }
#endif

        #endregion
    }
}