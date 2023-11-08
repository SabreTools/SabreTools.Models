namespace SabreTools.Models.MoPaQ
{
    /// <summary>
    /// MPQ User Data are optional, and is commonly used in custom maps for
    /// Starcraft II. If MPQ User Data header is present, it contains an offset,
    /// from where the MPQ header should be searched.
    /// </summary>
    /// <see href="http://zezula.net/en/mpq/mpqformat.html"/>
    public sealed class UserData
    {
        /// <summary>
        /// The user data signature
        /// </summary>
        /// <see cref="SignatureValue"/>
        public string? Signature { get; set; }

        /// <summary>
        /// Maximum size of the user data
        /// </summary>
        public uint UserDataSize { get; set; }

        /// <summary>
        /// Offset of the MPQ header, relative to the beginning of this header
        /// </summary>
        public uint HeaderOffset { get; set; }

        /// <summary>
        /// Appears to be size of user data header (Starcraft II maps)
        /// </summary>
        public uint UserDataHeaderSize { get; set; }

        // TODO: Does this area contain extra data that should be read in?
    }
}
