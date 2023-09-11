namespace SabreTools.Models.BDPlus
{
    /// <see href="https://github.com/mwgoldsmith/bdplus/blob/master/src/libbdplus/bdsvm/loader.c"/>
    public sealed class SVM
    {
        /// <summary>
        /// "BDSVM_CC"
        /// </summary>
#if NET48
        public string Signature { get; set; }
#else
        public string? Signature { get; set; }
#endif

        /// <summary>
        /// 5 bytes of unknown data
        /// </summary>
#if NET48
        public byte[] Unknown1 { get; set; }
#else
        public byte[]? Unknown1 { get; set; }
#endif

        /// <summary>
        /// Version year
        /// </summary>
        public ushort Year { get; set; }

        /// <summary>
        /// Version month
        /// </summary>
        public byte Month { get; set; }

        /// <summary>
        /// Version day
        /// </summary>
        public byte Day { get; set; }

        /// <summary>
        /// 4 bytes of unknown data
        /// </summary>
#if NET48
        public byte[] Unknown2 { get; set; }
#else
        public byte[]? Unknown2 { get; set; }
#endif

        /// <summary>
        /// Length
        /// </summary>
        public uint Length { get; set; }

        /// <summary>
        /// Length bytes of data
        /// </summary>
#if NET48
        public byte[] Data { get; set; }
#else
        public byte[]? Data { get; set; }
#endif
    }
}