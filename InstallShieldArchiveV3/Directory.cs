using System.Runtime.InteropServices;

namespace SabreTools.Models.InstallShieldArchiveV3
{
    /// <see href="https://github.com/wfr/unshieldv3/blob/master/ISArchiveV3.cpp"/>
    [StructLayout(LayoutKind.Sequential)]
    public class Directory
    {
        [MarshalAs(UnmanagedType.BStr)]
        public string? Name;

        public ushort FileCount;
    }
}