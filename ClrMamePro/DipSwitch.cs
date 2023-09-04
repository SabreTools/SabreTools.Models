namespace SabreTools.Models.ClrMamePro
{
    /// <remarks>dipswitch</remarks>
    public class DipSwitch
    {
        /// <remarks>name</remarks>
        [Required]
#if NET48
        public string Name { get; set; }
#else
        public string? Name { get; set; }
#endif

        /// <remarks>entry</remarks>
#if NET48
        public string[] Entry { get; set; }
#else
        public string[]? Entry { get; set; }
#endif

        /// <remarks>default, (yes|no) "no"</remarks>
#if NET48
        public string Default { get; set; }
#else
        public string? Default { get; set; }
#endif

        #region DO NOT USE IN PRODUCTION

        /// <remarks>Should be empty</remarks>
#if NET48
        public object[] ADDITIONAL_ELEMENTS { get; set; }
#else
        public object[]? ADDITIONAL_ELEMENTS { get; set; }
#endif

        #endregion
    }
}