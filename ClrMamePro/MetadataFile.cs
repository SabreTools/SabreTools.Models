namespace SabreTools.Models.ClrMamePro
{
    public class MetadataFile
    {
        /// <remarks>clrmamepro</remarks>
#if NET48
        public ClrMamePro ClrMamePro { get; set; }
#else
        public ClrMamePro? ClrMamePro { get; set; }
#endif

        /// <remarks>game, machine, resource, set</remarks>
#if NET48
        public GameBase[] Game { get; set; }
#else
        public GameBase?[]? Game { get; set; }
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