namespace SabreTools.Models.VBSP
{
    /// <see href="https://github.com/RavuAlHemio/hllib/blob/master/HLLib/VBSPFile.h"/>
    public sealed class Lump
    {
        public uint Offset { get; set; }

        public uint Length { get; set; }

        /// <summary>
        /// Default to zero.
        /// </summary>
        public uint Version { get; set; }

        /// <summary>
        /// Default to (char)0, (char)0, (char)0, (char)0.
        /// </summary>
        public char[]? FourCC { get; set; }
    }
}
