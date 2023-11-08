namespace SabreTools.Models.RomCenter
{
    /// <remarks>[games]</remarks>
    public class Games
    {
        public Rom[]? Rom { get; set; }

        #region DO NOT USE IN PRODUCTION

        /// <remarks>Should be empty</remarks>
        public string[]? ADDITIONAL_ELEMENTS { get; set; }

        #endregion
    }
}