namespace SabreTools.Models.AACS
{
    /// <summary>
    /// This record type is undocumented but found in real media key blocks
    /// </summary>
    public sealed class CopyrightRecord : Record
    {
        /// <summary>
        /// Null-terminated ASCII string representing the copyright
        /// </summary>
#if NET48
        public string Copyright;
#else
        public string? Copyright;
#endif
    }
}