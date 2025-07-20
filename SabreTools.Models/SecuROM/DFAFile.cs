namespace SabreTools.Models.SecuROM
{
    /// <summary>
    /// Most DFA-protected files seem to also have some additional encryption (it looks like SecuROM DFE, but that
    /// could be an incorrect guess); only early RC-encrypted executables seem to have anything parsable beyond the
    /// SDFA header. This is what is meant by "observable cases".
    /// </summary>
    public class DFAFile
    {
        /// <summary>
        /// Encrypted data portion of the file.
        /// </summary>
        /// <remarks>
        /// Name given by subheader.
        /// </remarks>
        public byte[]? MAC1 { get; set; }
    }
}
