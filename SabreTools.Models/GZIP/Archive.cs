namespace SabreTools.Models.GZIP
{
    /// <see href="https://www.ietf.org/rfc/rfc1952.txt"/> 
    public sealed class Archive
    {
        /// <summary>
        /// Header including optional fields
        /// </summary>
        public Header? Header;

        // Compressed blocks live here

        /// <summary>
        /// Trailer
        /// </summary>
        public Trailer? Trailer;
    }
}