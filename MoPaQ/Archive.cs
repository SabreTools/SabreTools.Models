namespace SabreTools.Models.MoPaQ
{
    /// <summary>
    /// MPQ (MoPaQ) is an archive format developed by Blizzard Entertainment,
    /// purposed for storing data files, images, sounds, music and videos for
    /// their games. The name MoPaQ comes from the author of the format,
    /// Mike O'Brien (Mike O'brien PaCK).
    /// </summary>
    /// <see href="http://zezula.net/en/mpq/mpqformat.html"/>
    public sealed class Archive
    {
        // TODO: Data before archive, ignored

        /// <summary>
        /// MPQ User Data (optional)
        /// </summary>
#if NET48
        public UserData UserData { get; set; }
#else
        public UserData? UserData { get; set; }
#endif

        /// <summary>
        /// MPQ Header (required)
        /// </summary>
#if NET48
        public ArchiveHeader ArchiveHeader { get; set; }
#else
        public ArchiveHeader? ArchiveHeader { get; set; }
#endif

        // TODO: Files (optional)
        // TODO: Special files (optional)

        /// <summary>
        /// HET Table (optional)
        /// </summary>
#if NET48
        public HetTable HetTable { get; set; }
#else
        public HetTable? HetTable { get; set; }
#endif

        /// <summary>
        /// BET Table (optional)
        /// </summary>
#if NET48
        public BetTable BetTable { get; set; }
#else
        public BetTable? BetTable { get; set; }
#endif

        /// <summary>
        /// Hash Table (optional)
        /// </summary>
#if NET48
        public HashEntry[] HashTable { get; set; }
#else
        public HashEntry?[]? HashTable { get; set; }
#endif

        /// <summary>
        /// Block Table (optional)
        /// </summary>
#if NET48
        public BlockEntry[] BlockTable { get; set; }
#else
        public BlockEntry?[]? BlockTable { get; set; }
#endif

        /// <summary>
        /// Hi-Block Table (optional)
        /// </summary>
        /// <remarks>
        /// Since World of Warcraft - The Burning Crusade, Blizzard extended
        /// the MPQ format to support archives larger than 4GB. The hi-block
        /// table holds the higher 16-bits of the file position in the MPQ.
        /// Hi-block table is plain array of 16-bit values. This table is
        /// not encrypted.
        /// </remarks>
#if NET48
        public short[] HiBlockTable { get; set; }
#else
        public short[]? HiBlockTable { get; set; }
#endif

        // TODO: Strong digital signature
    }
}
