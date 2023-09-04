namespace SabreTools.Models.DosCenter
{
    public class MetadataFile
    {
        /// <remarks>doscenter</remarks>
        public DosCenter? DosCenter { get; set; }

        /// <remarks>game</remarks>
        public Game[]? Game { get; set; }

        #region DO NOT USE IN PRODUCTION

        /// <remarks>Should be empty</remarks>
        public string[]? ADDITIONAL_ELEMENTS { get; set; }

        #endregion
    }
}