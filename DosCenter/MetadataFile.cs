namespace SabreTools.Models.DosCenter
{
    public class MetadataFile
    {
        /// <remarks>doscenter</remarks>
#if NET48
        public DosCenter DosCenter { get; set; }
#else
        public DosCenter? DosCenter { get; set; }
#endif

        /// <remarks>game</remarks>
#if NET48
        public Game[] Game { get; set; }
#else
        public Game[]? Game { get; set; }
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