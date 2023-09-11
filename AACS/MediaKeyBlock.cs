namespace SabreTools.Models.AACS
{
    /// <summary>
    /// A Media Key Block is formatted as a sequence of contiguous Records.
    /// </summary>
    /// <see href="https://aacsla.com/wp-content/uploads/2019/02/AACS_Spec_Common_Final_0953.pdf"/>
    public sealed class MediaKeyBlock
    {
        /// <summary>
        /// Records
        /// </summary>
#if NET48
        public Record[] Records { get; set; }
#else
        public Record?[]? Records { get; set; }
#endif
    }
}