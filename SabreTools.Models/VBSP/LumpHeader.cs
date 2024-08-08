using System.Runtime.InteropServices;

namespace SabreTools.Models.VBSP
{
    /// <see href="https://github.com/RavuAlHemio/hllib/blob/master/HLLib/VBSPFile.h"/>
    [StructLayout(LayoutKind.Sequential)]
    public sealed class LumpHeader
    {
        public int LumpOffset;

        public int LumpID;

        public int LumpVersion;

        public int LumpLength;

        public int MapRevision;
    }
}
