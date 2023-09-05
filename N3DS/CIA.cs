namespace SabreTools.Models.N3DS
{
    /// <summary>
    /// CIA stands for CTR Importable Archive. This format allows the installation of
    /// titles to the 3DS. CIA files and titles on Nintendo's CDN contain identical data.
    /// As a consequence, valid CIA files can be generated from CDN content. This also
    /// means CIA files can contain anything that titles on Nintendo's CDN can contain.
    /// 
    /// Under normal circumstances CIA files are used where downloading a title is
    /// impractical or not possible. Such as distributing a Download Play child, or
    /// installing forced Gamecard updates. Those CIA(s) are stored by the titles in
    /// question, in an auxiliary CFA file.
    /// </summary>
    /// <see href="https://www.3dbrew.org/wiki/CIA"/>
    public class CIA
    {
        /// <summary>
        /// CIA header
        /// </summary>
#if NET48
        public CIAHeader Header { get; set; }
#else
        public CIAHeader? Header { get; set; }
#endif

        /// <summary>
        /// Certificate chain
        /// </summary>
        /// <remarks>
        /// https://www.3dbrew.org/wiki/CIA#Certificate_Chain
        /// </remarks>
#if NET48
        public Certificate[] CertificateChain { get; set; }
#else
        public Certificate[]? CertificateChain { get; set; }
#endif

        /// <summary>
        /// Ticket
        /// </summary>
#if NET48
        public Ticket Ticket { get; set; }
#else
        public Ticket? Ticket { get; set; }
#endif

        /// <summary>
        /// TMD file data
        /// </summary>
#if NET48
        public TitleMetadata TMDFileData { get; set; }
#else
        public TitleMetadata? TMDFileData { get; set; }
#endif

        /// <summary>
        /// Content file data
        /// </summary>
#if NET48
        public NCCHHeader[] Partitions { get; set; }
#else
        public NCCHHeader[]? Partitions { get; set; }
#endif

        /// <summary>
        /// Content file data
        /// </summary>
        /// TODO: Parse the content file data
#if NET48
        public byte[] ContentFileData { get; set; }
#else
        public byte[]? ContentFileData { get; set; }
#endif

        /// <summary>
        /// Meta file data (Not a necessary component)
        /// </summary>
#if NET48
        public MetaData MetaData { get; set; }
#else
        public MetaData? MetaData { get; set; }
#endif
    }
}