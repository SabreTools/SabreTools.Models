namespace SabreTools.Models.XZP
{
    /// <see href="https://github.com/RavuAlHemio/hllib/blob/master/HLLib/XZPFile.h"/>
    public sealed class DirectoryItem
    {
        public uint FileNameCRC;

        public uint NameOffset;

#if NET48
        public string Name;
#else
        public string? Name;
#endif

        public uint TimeCreated;
    }
}
