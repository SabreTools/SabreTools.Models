namespace SabreTools.Models.CHD
{
    /// <see href="https://github.com/mamedev/mame/blob/master/src/lib/util/chd.h"/> 
    public abstract class Header
    {
        /// <summary>
        /// 'MComprHD'
        /// </summary>
#if NET48
        public string Tag { get; set; }
#else
        public string? Tag { get; set; }
#endif

        /// <summary>
        /// Length of header (including tag and length fields)
        /// </summary>
        public uint Length { get; set; }

        /// <summary>
        /// Drive format version
        /// </summary>
        public uint Version { get; set; }
    }
}