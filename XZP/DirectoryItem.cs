namespace SabreTools.Models.XZP
{
    /// <see href="https://github.com/RavuAlHemio/hllib/blob/master/HLLib/XZPFile.h"/>
    public sealed class DirectoryItem
    {
        public uint FileNameCRC { get; set; }

        public uint NameOffset { get; set; }

#if NET48
        public string Name { get; set; }
#else
        public string? Name { get; set; }
#endif

        public uint TimeCreated { get; set; }
    }
}
