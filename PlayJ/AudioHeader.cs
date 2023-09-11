namespace SabreTools.Models.PlayJ
{
    /// <summary>
    /// PlayJ audio header / CDS entry header
    /// </summary>
    /// <remarks>V1 and V2 variants exist</remarks>
    public abstract class AudioHeader
    {
        /// <summary>
        /// Signature (0x4B539DFF)
        /// </summary>
        public uint Signature { get; set; }

        /// <summary>
        /// Version
        /// </summary>
        public uint Version { get; set; }

        // Header-specific data goes here

        /// <summary>
        /// Length of the track name
        /// </summary>
        public ushort TrackLength { get; set; }

        /// <summary>
        /// Track name (not null-terminated)
        /// </summary>
#if NET48
        public string Track { get; set; }
#else
        public string? Track { get; set; }
#endif

        /// <summary>
        /// Length of the artist name
        /// </summary>
        public ushort ArtistLength { get; set; }

        /// <summary>
        /// Artist name (not null-terminated)
        /// </summary>
#if NET48
        public string Artist { get; set; }
#else
        public string? Artist { get; set; }
#endif

        /// <summary>
        /// Length of the album name
        /// </summary>
        public ushort AlbumLength { get; set; }

        /// <summary>
        /// Album name (not null-terminated)
        /// </summary>
#if NET48
        public string Album { get; set; }
#else
        public string? Album { get; set; }
#endif

        /// <summary>
        /// Length of the writer name
        /// </summary>
        public ushort WriterLength { get; set; }

        /// <summary>
        /// Writer name (not null-terminated)
        /// </summary>
#if NET48
        public string Writer { get; set; }
#else
        public string? Writer { get; set; }
#endif

        /// <summary>
        /// Length of the publisher name
        /// </summary>
        public ushort PublisherLength { get; set; }

        /// <summary>
        /// Publisher name (not null-terminated)
        /// </summary>
#if NET48
        public string Publisher { get; set; }
#else
        public string? Publisher { get; set; }
#endif

        /// <summary>
        /// Length of the label name
        /// </summary>
        public ushort LabelLength { get; set; }

        /// <summary>
        /// Label name (not null-terminated)
        /// </summary>
#if NET48
        public string Label { get; set; }
#else
        public string? Label { get; set; }
#endif

        /// <summary>
        /// Length of the comments
        /// </summary>
        /// <remarks>Optional field only in some samples</remarks>
        public ushort CommentsLength { get; set; }

        /// <summary>
        /// Comments (not null-terminated)
        /// </summary>
        /// <remarks>Optional field only in some samples</remarks>
#if NET48
        public string Comments { get; set; }
#else
        public string? Comments { get; set; }
#endif
    }
}