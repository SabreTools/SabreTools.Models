namespace SabreTools.Models.InstallShieldCabinet
{
    /// <see href="https://github.com/twogood/unshield/blob/main/lib/cabfile.h"/>
    public sealed class OffsetList
    {
        public uint NameOffset { get; set; }

#if NET48
        public string Name { get; set; }
#else
        public string? Name { get; set; }
#endif

        public uint DescriptorOffset { get; set; }

        public uint NextOffset { get; set; }
    }
}