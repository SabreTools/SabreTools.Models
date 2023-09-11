namespace SabreTools.Models.SGA
{
    /// <see href="https://github.com/RavuAlHemio/hllib/blob/master/HLLib/SGAFile.h"/>
    public class File4
    {
        public uint NameOffset { get; set; }

#if NET48
        public string Name { get; set; }
#else
        public string? Name { get; set; }
#endif

        public uint Offset { get; set; }

        public uint SizeOnDisk { get; set; }

        public uint Size { get; set; }

        public uint TimeModified { get; set; }

        public byte Dummy0 { get; set; }

        public byte Type { get; set; }
    }
}
