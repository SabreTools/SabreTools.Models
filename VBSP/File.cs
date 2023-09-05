namespace SabreTools.Models.VBSP
{
    /// <summary>
    /// Half-Life 2 Level
    /// </summary>
    /// <see href="https://github.com/RavuAlHemio/hllib/blob/master/HLLib/VBSPFile.h"/>
    public sealed class File
    {
        /// <summary>
        /// Directory header data
        /// </summary>
#if NET48
        public Header Header { get; set; }
#else
        public Header? Header { get; set; }
#endif
    }
}