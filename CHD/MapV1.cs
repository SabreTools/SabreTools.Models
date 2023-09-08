namespace SabreTools.Models.CHD
{
    /// <see href="https://github.com/mamedev/mame/blob/master/src/lib/util/chd.h"/> 
    public class MapV1
    {
        /// <summary>
        /// Starting offset within the file
        /// </summary>
        public ulong StartingOffset { get; set; }

        /// <summary>
        /// Length of data; If == hunksize, data is uncompressed
        /// </summary>
        public ulong Length { get; set; }
    }
}
