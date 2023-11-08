namespace SabreTools.Models.BDPlus
{
    /// <see href="https://github.com/mwgoldsmith/bdplus/blob/master/src/libbdplus/bdsvm/loader.c"/>
    public sealed class SVM
    {
        /// <summary>
        /// "BDSVM_CC"
        /// </summary>
        public string? Signature { get; set; }

        /// <summary>
        /// 5 bytes of unknown data
        /// </summary>
        public byte[]? Unknown1 { get; set; }

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
        public byte[]? Unknown2 { get; set; }

        /// <summary>
        /// Length
        /// </summary>
        public uint Length { get; set; }

        /// <summary>
        /// Length bytes of data
        /// </summary>
        public byte[]? Data { get; set; }
    }
}