namespace SabreTools.Models.InstallShieldArchiveV3
{
    /// <see href="https://github.com/wfr/unshieldv3/blob/master/ISArchiveV3.cpp"/>
    public class Directory
    {
        public string? Name { get; set; }

        public ushort FileCount { get; set; }
    }
}