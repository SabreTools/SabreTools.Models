namespace SabreTools.Models.DosCenter
{
    /// <remarks>game</remarks>
    public class Game
    {
        /// <remarks>name</remarks>
        [Required]
        public string? Name { get; set; }

        /// <remarks>file</remarks>
        public File[]? File { get; set; }

        #region DO NOT USE IN PRODUCTION

        /// <remarks>Should be empty</remarks>
        public string[]? ADDITIONAL_ELEMENTS { get; set; }

        #endregion
    }
}