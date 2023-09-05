namespace SabreTools.Models.PlayJ
{
    /// <summary>
    /// PlayJ playlist file
    /// </summary>
    public sealed class Playlist
    {
        /// <summary>
        /// Playlist header
        /// </summary>
#if NET48
        public PlaylistHeader Header { get; set; }
#else
        public PlaylistHeader? Header { get; set; }
#endif

        /// <summary>
        /// Embedded audio files / headers
        /// </summary>
#if NET48
        public AudioFile[] AudioFiles { get; set; }
#else
        public AudioFile[]? AudioFiles { get; set; }
#endif
    }
}