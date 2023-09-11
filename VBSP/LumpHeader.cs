namespace SabreTools.Models.VBSP
{
    /// <see href="https://github.com/RavuAlHemio/hllib/blob/master/HLLib/VBSPFile.h"/>
    public sealed class LumpHeader
    {
        public int LumpOffset { get; set; }

        public int LumpID { get; set; }

        public int LumpVersion { get; set; }

        public int LumpLength { get; set; }

        public int MapRevision { get; set; }
    }
}
