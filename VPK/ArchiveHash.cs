namespace SabreTools.Models.VPK
{
    /// <see href="https://github.com/RavuAlHemio/hllib/blob/master/HLLib/VPKFile.h"/>
    public sealed class ArchiveHash
    {
        public uint ArchiveIndex { get; set; }

        public uint ArchiveOffset { get; set; }

        public uint Length { get; set; }

        /// <summary>
        /// MD5
        /// </summary>
        public byte[]? Hash { get; set; }
    }
}
