namespace SabreTools.Models.RomCenter
{
    public class MetadataFile
    {
        /// <remarks>[credits]</remarks>
        public Credits? Credits { get; set; }

        /// <remarks>[dat]</remarks>
        public Dat? Dat { get; set; }

        /// <remarks>[emulator]</remarks>
        public Emulator? Emulator { get; set; }

        /// <remarks>[games]</remarks>
        public Games? Games { get; set; }

        #region DO NOT USE IN PRODUCTION

        /// <remarks>Should be empty</remarks>
        public string[]? ADDITIONAL_ELEMENTS { get; set; }

        #endregion
    }
}