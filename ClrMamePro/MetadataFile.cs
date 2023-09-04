namespace SabreTools.Models.ClrMamePro
{
    public class MetadataFile
    {
        /// <remarks>clrmamepro</remarks>
        public ClrMamePro? ClrMamePro { get; set; }

        /// <remarks>game, machine, resource, set</remarks>
        public GameBase[]? Game { get; set; }

        #region DO NOT USE IN PRODUCTION

        /// <remarks>Should be empty</remarks>
        public string[]? ADDITIONAL_ELEMENTS { get; set; }

        #endregion
    }
}