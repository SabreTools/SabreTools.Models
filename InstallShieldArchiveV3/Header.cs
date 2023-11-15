namespace SabreTools.Models.InstallShieldArchiveV3
{
    /// <see href="https://github.com/wfr/unshieldv3/blob/master/ISArchiveV3.h"/>
    public class Header
    {
        public uint Signature1 { get; set; }

        public uint Signature2 { get; set; }

        public ushort Reserved0 { get; set; }

        public ushort IsMultivolume { get; set; }

        public ushort FileCount { get; set; }

        public uint DateTime { get; set; }

        public uint CompressedSize { get; set; }

        public uint UncompressedSize { get; set; }

        public uint Reserved1 { get; set; }

        /// <remarks>
        /// Set in first vol only, zero in subsequent vols
        /// </remarks>
        public byte VolumeTotal { get; set; }

        /// <remarks>
        /// [1...n]
        /// </remarks>
        public byte VolumeNumber { get; set; }

        public byte Reserved2 { get; set; }

        public uint SplitBeginAddress { get; set; }

        public uint SplitEndAddress { get; set; }

        public uint TocAddress { get; set; }

        public uint Reserved3 { get; set; }

        public ushort DirCount { get; set; }

        public uint Reserved4 { get; set; }

        public uint Reserved5 { get; set; }
    }
}