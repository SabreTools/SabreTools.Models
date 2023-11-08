namespace SabreTools.Models.SGA
{
    /// <see href="https://github.com/RavuAlHemio/hllib/blob/master/HLLib/SGAFile.h"/>
    public sealed class Header4 : Header
    {
        public byte[]? FileMD5 { get; set; }

        public string? Name { get; set; }

        public byte[]? HeaderMD5 { get; set; }

        public uint HeaderLength { get; set; }

        public uint FileDataOffset { get; set; }

        public uint Dummy0 { get; set; }
    }
}
