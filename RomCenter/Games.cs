namespace SabreTools.Models.RomCenter
{
    /// <remarks>[games]</remarks>
    public class Games
    {
#if NET48
        public Rom[] Rom { get; set; }
#else
        public Rom[]? Rom { get; set; }
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