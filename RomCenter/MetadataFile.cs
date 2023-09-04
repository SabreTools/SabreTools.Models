namespace SabreTools.Models.RomCenter
{
    public class MetadataFile
    {
        /// <remarks>[credits]</remarks>
#if NET48
        public Credits Credits { get; set; }
#else
        public Credits? Credits { get; set; }
#endif

        /// <remarks>[dat]</remarks>
#if NET48
        public Dat Dat { get; set; }
#else
        public Dat? Dat { get; set; }
#endif

        /// <remarks>[emulator]</remarks>
#if NET48
        public Emulator Emulator { get; set; }
#else
        public Emulator? Emulator { get; set; }
#endif

        /// <remarks>[games]</remarks>
#if NET48
        public Games Games { get; set; }
#else
        public Games? Games { get; set; }
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