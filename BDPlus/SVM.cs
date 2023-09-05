namespace SabreTools.Models.BDPlus
{
    /// <see href="https://github.com/mwgoldsmith/bdplus/blob/master/src/libbdplus/bdsvm/loader.c"/>
    public sealed class SVM
    {
        /// <summary>
        /// "BDSVM_CC"
        /// </summary>
#if NET48
        public string Signature;
#else
        public string? Signature;
#endif

        /// <summary>
        /// 5 bytes of unknown data
        /// </summary>
#if NET48
        public byte[] Unknown1;
#else
        public byte[]? Unknown1;
#endif

        /// <summary>
        /// Version year
        /// </summary>
        public ushort Year;

        /// <summary>
        /// Version month
        /// </summary>
        public byte Month;

        /// <summary>
        /// Version day
        /// </summary>
        public byte Day;

        /// <summary>
        /// 4 bytes of unknown data
        /// </summary>
#if NET48
        public byte[] Unknown2;
#else
        public byte[]? Unknown2;
#endif

        /// <summary>
        /// Length
        /// </summary>
        public uint Length;

        /// <summary>
        /// Length bytes of data
        /// </summary>
#if NET48
        public byte[] Data;
#else
        public byte[]? Data;
#endif
    }
}