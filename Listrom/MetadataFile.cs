namespace SabreTools.Models.Listrom
{
    public class MetadataFile
    {
#if NET48
        public Set[] Set { get; set; }
#else
        public Set[]? Set { get; set; }
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