namespace SabreTools.Models.InstallShieldCabinet
{
    /// <see href="https://github.com/twogood/unshield/blob/main/lib/cabfile.h"/>
    public sealed class OffsetList
    {
        public uint NameOffset;

#if NET48
        public string Name;
#else
        public string? Name;
#endif

        public uint DescriptorOffset;

        public uint NextOffset;
    }
}